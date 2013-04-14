using System;
using System.Linq.Expressions;

namespace AW.Helper
{
	/// <summary>
	/// http://pastebin.com/j0neZ478 
	/// http://joelabrahamsson.com/entry/getting-property-and-method-names-using-static-reflection-in-c-sharp 
	/// <seealso cref="StaticReflection" />
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
			if (expression is MethodCallExpression)
				return (expression as MethodCallExpression).Method.Name;
			if (expression is MemberExpression)
				return (expression as MemberExpression).Member.Name;
			throw new ArgumentException("Invalid expression [" + expression + "]");
		}
	}
}