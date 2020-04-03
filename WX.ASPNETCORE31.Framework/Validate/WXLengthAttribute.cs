using System;
using System.Collections.Generic;
using System.Text;

namespace WX.ASPNETCORE31.Framework.Validate
{
    /// <summary>
    /// 长度验证
    /// </summary>
    public class WXLengthAttribute : WXBaseValidateAttribute
    {
        private int _iMin = 0;
        private int _iMax = 0;

        public WXLengthAttribute(int min, int max)
        {
            this._iMin = min;
            this._iMax = max;
        }
        public override bool Validate(object oValue)
        {
            return oValue != null && !string.IsNullOrWhiteSpace(oValue.ToString()) && oValue.ToString().Length>=this._iMin && oValue.ToString().Length < this._iMax;
        }
    }
}
