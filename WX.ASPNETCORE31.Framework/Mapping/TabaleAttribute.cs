using System;

namespace WX.ASPNETCORE31.Framework
{
 
    [AttributeUsage(AttributeTargets.Class)]
    public class TabaleAttribute : BaseAttribute
    {
       // private string _TableName = null;
        public TabaleAttribute(string tablename):base(tablename)
        {
            //this._TableName = tablename;
        }

        //public string GetMappingName()
        //{
        //    return _TableName;
        //}
    }
}
