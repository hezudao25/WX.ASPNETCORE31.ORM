using System;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using WX.ASPNETCORE31.DAL.Excepression;
using WX.ASPNETCORE31.Framework;
using WX.ASPNETCORE31.Framework.DBFilter;
using WX.ASPNETCORE31.Framework.Validate;
using WX.ASPNETCORE31.Model;

namespace WX.ASPNETCORE31.DAL
{
    public class SqlHelper
    {
        //private static string configuationmanager = ConfigurationManager.SqlConnectionStringWrite;

    
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
            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@id", id)};
           
            string sql = SqlCacheBuilder<T>.GetSql(SqlCacheBuilderType.FindOne);
            return this.ExceuteSql<T>(sql, sqlParameters, sqlCommand => {
                var reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    T t = Activator.CreateInstance<T>();
                    foreach (var prop in type.GetProperties())
                    {
                        prop.SetValue(t, reader[prop.GetMappingName()] is DBNull ? null : reader[prop.GetMappingName()]);
                    }
                    return t;
                }
                else return null;
            }, SqlConnectionStringPool.DBOperateType.Read);
            //using (SqlConnection connection = new SqlConnection(configuationmanager))
            //{
            //    var command = connection.CreateCommand();

            //    SqlParameter[] para = new SqlParameter[1];
            //    para[0] = new SqlParameter("@id", id);

            //    command.CommandText = sql;
            //    command.Parameters.AddRange(para);
            //    connection.Open();
            //    var reader = command.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        T t = Activator.CreateInstance<T>();
            //        foreach(var prop in type.GetProperties())
            //        {
            //            prop.SetValue(t, reader[prop.GetMappingName()] is DBNull? null: reader[prop.GetMappingName()]);
            //        }
            //        return t;
            //    }

            //}
            
        }
        /// <summary>
        /// 多条件获取实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        public T FindCondition<T>(Expression<Func<T, bool>> expression)
        {
            Type type = typeof(T);
            string colunmString = string.Join(",", type.GetProperties().Select(p => $"[{ p.GetMappingName()}]"));

            ExcepressionToSqlVisitor visitor = new ExcepressionToSqlVisitor();
            {
                visitor.Visit(expression);
                string where = visitor.GetWhere();
                string sql = $"select {colunmString} from [{type.GetMappingName()}] where {where}";
                return this.ExceuteSql<T>(sql, null, sqlCommand => {
                    var reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        T t = Activator.CreateInstance<T>();
                        foreach (var prop in type.GetProperties())
                        {
                            prop.SetValue(t, reader[prop.GetMappingName()] is DBNull ? null : reader[prop.GetMappingName()]);
                        }
                        return t;
                    }
                    return default(T);             
                }, SqlConnectionStringPool.DBOperateType.Read);
            }
        }

        public bool Insert<T>(T t) where T :BaseModel, new()
        {
            if (!t.ValidataModel())
            {
                throw new Exception("数据验证失败");
            }
            Type type = typeof(T);
            //string columnStrings = string.Join(",", type.GetPropertiesWithNoKey().Select(p => $"[{p.GetMappingName()}]"));
            //string valueStrings = string.Join(",", type.GetPropertiesWithNoKey().Select(p => $"@{p.GetMappingName()}"));

            // 泛型缓存
            //string sql = $"insert into [{type.Name}] ({columnStrings}) values ({valueStrings})";
            string sql = SqlCacheBuilder<T>.GetSql(SqlCacheBuilderType.Insert);
            //参数化
            var sqlParameters = type.GetProperties().Select(p => new SqlParameter($"@{p.GetMappingName()}", p.GetValue(t) ?? DBNull.Value)).ToArray();

            return this.ExceuteSql<bool>(sql, sqlParameters, sqlCommand => 1 == sqlCommand.ExecuteNonQuery());
            //using(SqlConnection connection = new SqlConnection(configuationmanager))
            //{
            //    SqlCommand command = new SqlCommand(sql, connection);
            //    command.Parameters.AddRange(parameters);
            //    connection.Open();
            //    int result = command.ExecuteNonQuery();
            //    return result == 1;
            //}

        }

        public bool Update<T>(T t) where T:BaseModel, new()
        {
            if(!t.ValidataModel())
            {
                throw new Exception("数据验证失败");
            }
            Type type = typeof(T);
            //string columnStrings = string.Join(",", type.GetPropertiesWithNoKey().Select(p => $"[{p.GetMappingName()}]=@{p.GetMappingName()}"));
            //string sql = $"update [{type.GetMappingName()}] set {columnStrings} where Id=@id";
            string sql = SqlCacheBuilder<T>.GetSql(SqlCacheBuilderType.Update);
            var sqlParameters = type.GetPropertiesWithNoKey().Select(p => new SqlParameter($"@{p.GetMappingName()}", p.GetValue(t)?? DBNull.Value)).Append(new SqlParameter("@id", t.Id)).ToArray();
            return this.ExceuteSql<bool>(sql, sqlParameters, sqlCommand => 1 == sqlCommand.ExecuteNonQuery());
            //using (SqlConnection connection = new SqlConnection(configuationmanager))
            //{
            //    SqlCommand command = new SqlCommand(sql, connection);
            //    command.Parameters.AddRange(parameters);
            //    connection.Open();
            //    int result = command.ExecuteNonQuery();
            //    return result == 1;
            //}
        }

        public bool Delete<T>(T t) where T : BaseModel, new()
        {
            Type type = typeof(T);
            //string sql = $"Delete from [{type.GetMappingName()}] where Id=@id";
            string sql= SqlCacheBuilder<T>.GetSql(SqlCacheBuilderType.Delete);

            SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@id", t.Id) };
            return this.ExceuteSql<bool>(sql, sqlParameters, sqlCommand => 1 == sqlCommand.ExecuteNonQuery());
            //using (SqlConnection connection = new SqlConnection(configuationmanager))
            //{
            //    SqlCommand command = new SqlCommand(sql, connection);
            //    command.Parameters.AddRange(sqlParameters);
            //    connection.Open();
            //    int result = command.ExecuteNonQuery();
            //    return result == 1;
            //}
        }
        /// <summary>
        /// 条件删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        public bool DeleteCondition<T>(Expression<Func<T,bool>> expression)
        {
            Type type = typeof(T);
            ExcepressionToSqlVisitor visitor = new ExcepressionToSqlVisitor();
            {
                visitor.Visit(expression);
                string where = visitor.GetWhere();
                string sql = $"Delete from [{type.GetMappingName()}] where {where}";
                return this.ExceuteSql<bool>(sql, null, sqlCommand => 1 == sqlCommand.ExecuteNonQuery());
            }
            //string sql = $"Delete from [{type.GetMappingName()}] where Id=@id";
            //string sql = SqlCacheBuilder<T>.GetSql(SqlCacheBuilderType.Delete);

            //SqlParameter[] sqlParameters = new SqlParameter[] { new SqlParameter("@id", t.Id) };
            //return this.ExceuteSql<bool>(sql, sqlParameters, sqlCommand => 1 == sqlCommand.ExecuteNonQuery());
            //using (SqlConnection connection = new SqlConnection(configuationmanager))
            //{
            //    SqlCommand command = new SqlCommand(sql, connection);
            //    command.Parameters.AddRange(sqlParameters);
            //    connection.Open();
            //    int result = command.ExecuteNonQuery();
            //    return result == 1;
            //}
            
        }
        /// <summary>
        /// ADO.NET操作集合,方便升级
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="func">委托</param>
        /// <returns></returns>
        private S ExceuteSql<S>(string sql, SqlParameter[] parameters, Func<SqlCommand, S> func, SqlConnectionStringPool.DBOperateType dBOperateType=SqlConnectionStringPool.DBOperateType.Write)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionStringPool.GetConnectionString(dBOperateType)))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                if(parameters != null) command.Parameters.AddRange(parameters);
                connection.Open();
                return func.Invoke(command);
            }
        }
    }
}
