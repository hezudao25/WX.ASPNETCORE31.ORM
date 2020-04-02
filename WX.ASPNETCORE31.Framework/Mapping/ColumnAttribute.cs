using System;

namespace WX.ASPNETCORE31.Framework
{
   
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : BaseAttribute
    {
       // private string _ColumnName = null;
        public ColumnAttribute(string columnName): base(columnName)
        {
            //this._ColumnName = columnName;
        }

        //public string GetMappingName()
        //{
        //    return _ColumnName;
        //}
    }
}
