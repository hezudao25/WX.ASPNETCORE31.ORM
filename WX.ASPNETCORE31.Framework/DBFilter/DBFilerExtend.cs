using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace WX.ASPNETCORE31.Framework.DBFilter
{
    public static class DBFilerExtend
    {
        /// <summary>
        /// 去掉关键词的列名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IEnumerable<PropertyInfo> GetPropertiesWithNoKey(this Type type)
        {
            return type.GetProperties().Where(p => !p.IsDefined(typeof(KeyAttribute), true));
        }
    }
}
