using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace WX.ASPNETCORE31.DAL.Excepression
{
    public class ExcepressionToSqlVisitor : ExpressionVisitor
    {
        private Stack<string> ConditionStack = new Stack<string>();

        public string GetWhere()
        {
            string where = string.Concat(this.ConditionStack.ToArray());
            this.ConditionStack.Clear();
            return where;
        }
        /// <summary>
        /// 解析入口
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public override Expression Visit(Expression node)
        {
            //Console.WriteLine("");
            return base.Visit(node);
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            // Console.WriteLine($"VisitBinary {node}");
            this.ConditionStack.Push(" ) ");
            base.Visit(node.Right);
            this.ConditionStack.Push(node.NodeType.ToSqlOperator());
            // Console.WriteLine($"VisitBinary {node} NodeType {node.NodeType}");
            base.Visit(node.Left);
            this.ConditionStack.Push(" ( ");
            return node;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            this.ConditionStack.Push($"'{node.Value.ToString()}'");
            return node;
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            this.ConditionStack.Push($"{node.Member.Name}");
            return node;
        }    

        protected override Expression VisitMethodCall(MethodCallExpression m)
        {
            if (m == null) throw new ArgumentNullException("MethonCallExpression");

            string format;
            switch(m.Method.Name)
            {
                case "StartsWith":
                    format = "({0} like {1}+'%')";
                    break;
                case "Contains":
                    format = "({0} like '%'+{1}+'%')";
                    break;
                case "EndsWith":
                    format = "({0} like '%'+{1})";
                    break;
                case "Equals":
                    format = " not({0} like '%'+{1}+'%')";
                    break;
                default:
                    throw new NotSupportedException(m.NodeType + "is not supported!");
            }
            this.Visit(m.Object);
            this.Visit(m.Arguments[0]);
            string right = this.ConditionStack.Pop();
            string left = this.ConditionStack.Pop();
            this.ConditionStack.Push(String.Format(format, left, right));
            return m;
        }
    }
}
