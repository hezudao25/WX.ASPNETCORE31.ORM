using System;

namespace WX.ASPNETCORE31.Framework
{     
    public class BaseAttribute : Attribute
    {
        private string _mappingName = null;
        public BaseAttribute(string mappingName)
        {
            this._mappingName = mappingName;
        }

        public string GetMappingName()
        {
            return _mappingName;
        }
    }
}
