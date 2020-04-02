using System;
using System.Data.SqlClient;
using System.Linq;
using WX.ASPNETCORE31.Framework;
using WX.ASPNETCORE31.Framework.DBFilter;
using WX.ASPNETCORE31.Model;

namespace WX.ASPNETCORE31.DAL
{
    public class SqlHelper
    {
        private static string configuationmanager = ConfigurationManager.ConfigurationManagerCustom;

        /// <summary>
        /// 泛型完成通类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Find<T>(int id) where T:BaseModel, new()
        {
            Type type = typeof(T);
            //string colunmString = string.Join(",", type.GetProperties().Select(p => $"[{ p.GetMappingName()}]"));
            //string sql = $@"SELECT {colunmString} FROM [{type.GetMappingName()}] where id =@id";
            string sql = SqlCacheBuilder<T>.GetSql(SqlCacheBuilderType.FindOne);
            using (SqlConnection connection = new SqlConnection(configuationmanager))
            {
                var command = connection.CreateCommand();

                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@id", id);

                command.CommandText = sql;
                command.Parameters.AddRange(para);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    T t = Activator.CreateInstance<T>();
                    foreach(var prop in type.GetProperties())
                    {
                        prop.SetValue(t, reader[prop.GetMappingName()] is DBNull? null: reader[prop.GetMappingName()]);
                    }
                    return t;
                }

            }

            return null;
        }

        public bool Insert<T>(T t) where T :BaseModel, new()
        {
            Type type = typeof(T);
            //string columnStrings = string.Join(",", type.GetPropertiesWithNoKey().Select(p => $"[{p.GetMappingName()}]"));
            //string valueStrings = string.Join(",", type.GetPropertiesWithNoKey().Select(p => $"@{p.GetMappingName()}"));

            // 泛型缓存
            //string sql = $"insert into [{type.Name}] ({columnStrings}) values ({valueStrings})";
            string sql = SqlCacheBuilder<T>.GetSql(SqlCacheBuilderType.Insert);
            //参数化
            var parameters = type.GetProperties().Select(p => new SqlParameter($"@{p.GetMappingName()}", p.GetValue(t) ?? DBNull.Value)).ToArray();
           

            using(SqlConnection connection = new SqlConnection(configuationmanager))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddRange(parameters);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return result == 1;
            }

        }
    }
}
