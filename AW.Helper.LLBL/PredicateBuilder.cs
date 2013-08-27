using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SD.LLBLGen.Pro.LinqSupportClasses.ExpressionHandlers;
using LinqExpression = System.Linq.Expressions.Expression;

namespace AW.Helper.LLBL
{
  /// <summary>
  ///   Class to Dynamically Composing Expression Predicates.
  ///   How to use Linq to LLBLGen Pro with a predicate builder?
  /// </summary
  /// <see cref="http://www.albahari.com/nutshell/predicatebuilder.aspx" />
  /// <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=14144" />
  public static class PredicateBuilder
  {
    public static Expression<Func<T, bool>> Null<T>()
    {
      return null;
    }

    public static Expression<Func<T, bool>> True<T>()
    {
      return f => true;
    }

    public static Expression<Func<T, bool>> False<T>()
    {
      return f => false;
    }

    public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
    {
      if (expr1 == null)
        return expr2;
      var replacer = new ExpressionReplacer(CreateFromToReplaceSet(expr2.Parameters, expr1.Parameters), null, null, null, null);
      var rightExpression = (LambdaExpression) replacer.HandleExpression(expr2);

      return Expression.Lambda<Func<T, bool>>(Expression.OrElse(expr1.Body, rightExpression.Body), expr1.Parameters);
    }

    public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
    {
      if (expr1 == null)
        return expr2;
      var replacer = new ExpressionReplacer(CreateFromToReplaceSet(expr2.Parameters, expr1.Parameters), null, null, null, null);
      var rightExpression = (LambdaExpression) replacer.HandleExpression(expr2);
      return Expression.Lambda<Func<T, bool>>(Expression.AndAlso(expr1.Body, rightExpression.Body), expr1.Parameters);
    }

    public static Expression<Func<T, bool>> AddMethodCallExpression<T>(this Expression<Func<T, bool>> predicate, MethodCallExpression methodCallExpression)
    {
      return methodCallExpression.Arguments.Where(expArg => expArg.NodeType == ExpressionType.Lambda).OfType<Expression<Func<T, bool>>>()
        .Aggregate(predicate, (current, exp) => current.And(exp));
    }

    private static Dictionary<Expression, Expression> CreateFromToReplaceSet(IList<ParameterExpression> from, IList<ParameterExpression> to)
    {
      var toReturn = new Dictionary<Expression, Expression>();
      for (var i = 0; i < @from.Count; i++)
        toReturn.Add(@from[i], to[i]);
      return toReturn;
    }
  }
}