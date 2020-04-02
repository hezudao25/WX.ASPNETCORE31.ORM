using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WX.ASPNETCORE31.Framework;
using WX.ASPNETCORE31.Framework.DBFilter;
using WX.ASPNETCORE31.Model;

namespace WX.ASPNETCORE31.DAL
{
    /// <summary>
    /// 负载生产SQL，缓存重用
    /// </summary>
    public class SqlCacheBuilder<T> where T : BaseModel, new()
    {
        private static string _InsertSql = null;
        private static string _FindOneSql = null;

        /// <summary>
        /// 泛型类的类型参数T在不同的时候，会产生一个全新的类
        /// 所以，静态字段  静态构造函数 都会重新执行一次
        /// </summary>
        static SqlCacheBuilder()
        {
            {
                Type type = typeof(T);
                string colunmString = string.Join(",", type.GetProperties().Select(p => $"[{ p.GetMappingName()}]"));
                _FindOneSql = $@"SELECT {colunmString} FROM [{type.GetMappingName()}] where id =@id";
            }
            {
                Type type = typeof(T);
                string columnStrings = string.Join(",", type.GetPropertiesWithNoKey().Select(p => $"[{p.GetMappingName()}]"));
                string valueStrings = string.Join(",", type.GetPropertiesWithNoKey().Select(p => $"@{p.GetMappingName()}"));

                _InsertSql = $"insert into [{type.Name}] ({columnStrings}) values ({valueStrings})";
            }
        }

        public static string GetSql(SqlCacheBuilderType sqlCacheBuilderType)
        {
            switch (sqlCacheBuilderType)
            {
                case SqlCacheBuilderType.FindOne:
                    return _FindOneSql;
                case SqlCacheBuilderType.Insert:
                    return _InsertSql;
                default :
                    return _FindOneSql;
            }
            
        }
    }

    public enum SqlCacheBuilderType
    {
        FindOne,
        Insert
    }
}
