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
        private static string _UpdateSql = null;
        private static string _DeleteSql = null;

        /// <summary>
        /// 泛型类的类型参数T在不同的时候，会产生一个全新的类
        /// 所以，静态字段  静态构造函数 都会重新执行一次
        /// 缺点：只能跟类型相关，一个类型只能保持一份缓存
        /// 有点：性能好，无法更新
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
            {
                Type type = typeof(T);
                string columnStrings = string.Join(",", type.GetPropertiesWithNoKey().Select(p => $"[{p.GetMappingName()}]=@{p.GetMappingName()}"));
                _UpdateSql = $"update [{type.GetMappingName()}] set {columnStrings} where Id=@id";
            }
            {
                Type type = typeof(T);
                _DeleteSql = $"Delete from [{type.GetMappingName()}] where Id=@id";
            }
        }
        /// <summary>
        /// 负载生产SQL，缓存重用
        /// </summary>
        public static string GetSql(SqlCacheBuilderType sqlCacheBuilderType)
        {
            switch (sqlCacheBuilderType)
            {
                case SqlCacheBuilderType.FindOne:
                    return _FindOneSql;
                case SqlCacheBuilderType.Insert:
                    return _InsertSql;
                case SqlCacheBuilderType.Update:
                    return _UpdateSql;
                case SqlCacheBuilderType.Delete:
                    return _DeleteSql;
                default :
                    return _FindOneSql;
            }
            
        }
    }

    public enum SqlCacheBuilderType
    {
        FindOne,
        Insert,
        Update,
        Delete
    }

    /// <summary>
    /// 常规字典缓存  
    /// 优势：方便，数据保存以Key为准
    /// 劣势： 数据超过1W以上性能下降
    /// </summary>
    internal class CustomCache
    {
        private static Dictionary<string, string> CustomCacheDictionary = new Dictionary<string, string>();

        public static void Add(string key ,string value)
        {
            CustomCacheDictionary.Add(key, value);
        }

        public static string Get(string key)
        {
            return CustomCacheDictionary[key];
        }
    }
}
