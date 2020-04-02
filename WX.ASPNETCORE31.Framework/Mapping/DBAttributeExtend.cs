using System;
using System.Reflection;

namespace WX.ASPNETCORE31.Framework
{
    /// <summary>
    /// 扩展方法, 静态类+静态方法+this参数   
    /// </summary>
    public static class DBAttributeExtend
    {
        public static string GetMappingName<T>(this T t) where T : MemberInfo
        {
            if (t.IsDefined(typeof(BaseAttribute), true))
            {
                var attribute = t.GetCustomAttribute<BaseAttribute>();
                return attribute.GetMappingName();
            }
            else
            {
                return t.Name;
            }
        }
        //public static string GetTableName(this Type type)
        //{
        //    if (type.IsDefined(typeof(TabaleAttribute), true))
        //    {
        //        var attribute = type.GetCustomAttribute<TabaleAttribute>();
        //        return attribute.GetMappingName();
        //    }
        //    else
        //    {
        //        return type.Name;
        //    }
        //}

        //public static string GetColumnName(this PropertyInfo prop)
        //{
        //    if (prop.IsDefined(typeof(ColumnAttribute), true))
        //    {
        //        var attribute = prop.GetCustomAttribute<ColumnAttribute>();
        //        return attribute.GetMappingName();
        //    }
        //    else
        //    {
        //        return prop.Name;
        //    }
        //}
    }
}
