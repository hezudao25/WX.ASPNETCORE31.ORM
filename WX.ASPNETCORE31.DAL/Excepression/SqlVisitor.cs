using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace WX.ASPNETCORE31.DAL.Excepression
{
    public class SqlVisitor : ExpressionVisitor
    {
        private Stack<string> _ConditionStack = new Stack<string>();
        public string GetWhere()
        {
            string where = string.Join(" ",_ConditionStack);
            this._ConditionStack.Clear();
            return where;
        }
    }
}
