using System;
using System.Collections.Generic;
using System.Text;

namespace WX.ASPNETCORE31.Framework.Validate
{
    /// <summary>
    /// 检验基类
    /// </summary>
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true,Inherited =true)]
    public abstract class WXBaseValidateAttribute : Attribute
    {
        public abstract bool Validate(object oValue);
        
    }
}
