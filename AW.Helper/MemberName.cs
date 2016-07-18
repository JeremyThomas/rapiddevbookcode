using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AW.Helper
{
  /// <summary>
  ///   http://pastebin.com/j0neZ478
  ///   http://joelabrahamsson.com/entry/getting-property-and-method-names-using-static-reflection-in-c-sharp
  ///   <seealso cref="StaticReflection" />
  /// </summary>
  public static class MemberName
  {
    public static string For<T>(T instance, Expression<Action<T>> expression)
    {
      return FindMemberName(expression.Body);
    }

    public static string For<T>(Expression<Action<T>> expression)
    {
      return FindMemberName(expression.Body);
    }

    public static string For(Expression<Action> expression)
    {
      return FindMemberName(expression.Body);
    }

    public static string For<T, TResult>(T instance, Expression<Func<T, TResult>> expression)
    {
      return FindMemberName(expression.Body);
    }

    public static IEnumerable<string> For<T>(Expression<Func<T, object>>[] expressions)
    {
      return expressions.Select(For);
    }

    public static string For<T, TResult>(Expression<Func<T, TResult>> expression)
    {
      return FindMemberName(expression.Body);
    }

    public static string For<TResult>(Expression<Func<TResult>> expression)
    {
      return FindMemberName(expression.Body);
    }

    private static string FindMemberName(Expression expression)
    {
      return FindMember(expression);
    }

    private static string FindMember(Expression expression)
    {
      var methodCallExpression = expression as MethodCallExpression;
      if (methodCallExpression != null)
        return methodCallExpression.Method.Name;
      var memberExpression = expression as MemberExpression;
      if (memberExpression != null)
        return memberExpression.Member.Name;
      throw new ArgumentException("Invalid expression [" + expression + "]");
    }
  }
}