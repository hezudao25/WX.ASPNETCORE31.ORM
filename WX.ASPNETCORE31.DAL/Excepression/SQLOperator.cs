﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace WX.ASPNETCORE31.DAL.Excepression
{
    internal static class SQLOperator
    {
        internal static string ToSqlOperator(this ExpressionType type)
        {
            switch(type)
            {
                case (ExpressionType.AndAlso):
                case (ExpressionType.And):
                    return "AND";
                case (ExpressionType.OrElse):
                case (ExpressionType.Or):
                    return "OR";
                case (ExpressionType.Not):
                    return "Not";
                case (ExpressionType.NotEqual):
                    return "<>";
                case (ExpressionType.GreaterThan):
                    return ">";
                case (ExpressionType.GreaterThanOrEqual):
                    return ">=";
                case (ExpressionType.LessThan):
                    return "<";
                case (ExpressionType.LessThanOrEqual):
                    return "<=";
                case (ExpressionType.Equal):
                    return "=";
                default:
                    throw new Exception("不支持该方法");
            }
        }
    }
}
