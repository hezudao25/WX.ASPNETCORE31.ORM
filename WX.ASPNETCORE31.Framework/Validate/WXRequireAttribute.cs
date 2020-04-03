using System;
using System.Collections.Generic;
using System.Text;

namespace WX.ASPNETCORE31.Framework.Validate
{
    /// <summary>
    /// 非空验证
    /// </summary>
    public class WXRequireAttribute : WXBaseValidateAttribute
    {
        public WXRequireAttribute()
        {
          
        }
        public override bool Validate(object oValue)
        {
            return oValue != null && !string.IsNullOrWhiteSpace(oValue.ToString());
        }
    }
}
