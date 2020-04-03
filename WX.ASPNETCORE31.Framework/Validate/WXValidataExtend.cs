using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace WX.ASPNETCORE31.Framework.Validate
{
    public static class WXValidataExtend
    {
        public static bool ValidataModel<T>(this T t)
        {
            Type type = typeof(T);
            foreach(var prop in type.GetProperties())
            {
                // 使用父类
                // 封装重复代码
                if(prop.IsDefined(typeof(WXBaseValidateAttribute),true))
                {
                    var values = prop.GetValue(t);
                    var attribute = prop.GetCustomAttribute<WXBaseValidateAttribute>();
                    if(! attribute.Validate(values))
                    {
                        return false;
                    }
                    //if (values is null || string.IsNullOrWhiteSpace(values.ToString()))
                    //{
                    //    return false;
                    //}
                }
                //if (prop.IsDefined(typeof(WXLengthAttribute), true))
                //{
                //    var values = prop.GetValue(t);
                //    var attribute = prop.GetCustomAttribute<WXLengthAttribute>();
                //    if (!attribute.Validate(values))
                //    {
                //        return false;
                //    }
                //    //if (values is null || string.IsNullOrWhiteSpace(values.ToString()) || values.ToString().Length< attribute._iMin || values.ToString().Length >= attribute._iMax)
                //    //{
                //    //    return false;
                //    //}
                //}
            }
            return true;
        }
    }
}
