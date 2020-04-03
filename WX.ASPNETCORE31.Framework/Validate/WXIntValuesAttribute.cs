using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WX.ASPNETCORE31.Framework.Validate
{
    /// <summary>
    /// 要求是几个int值之一
    /// </summary>
    public class WXIntValuesAttribute : WXBaseValidateAttribute
    {
        private int[] _values = null;
        public WXIntValuesAttribute(params int[] values)
        {
            this._values = values;
        }
        public override bool Validate(object oValue)
        {
            return oValue != null && !string.IsNullOrWhiteSpace(oValue.ToString())
                && int.TryParse(oValue.ToString(), out int iValue)
                && this._values != null
                && this._values.Contains(iValue);
        }
    }
}
