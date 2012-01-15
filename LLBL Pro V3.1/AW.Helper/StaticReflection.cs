using System;
using System.Linq.Expressions;
using MemberNameUtil;

namespace AW.Helper
{
	/// <summary>
	/// 	http://joelabrahamsson.com/entry/getting-property-and-method-names-using-static-reflection-in-c-sharp
	/// </summary>
	/// <seealso cref="MemberName" />
	public static class StaticReflection
	{
		public static string GetMemberName<T>(this T instance, Expression<Func<T, object>> expression)
		{
			return GetMemberName(expression);
		}

		public static string GetMemberName<T>(Expression<Func<T, object>> expression)
		{
			if (expression == null)
				throw new ArgumentException("The expression cannot be null.");

			return GetMemberName(expression.Body);
		}

		public static string GetMemberName<T>(this T instance, Expression<Action<T>> expression)
		{
			return GetMemberName(expression);
		}

		public static string GetMemberName<T>(Expression<Action<T>> expression)
		{
			if (expression == null)
				throw new ArgumentException("The expression cannot be null.");

			return GetMemberName(expression.Body);
		}

		private static string GetMemberName(Expression expression)
		{
			if (expression == null)
				throw new ArgumentException("The expression cannot be null.");

			var memberExpression = expression as MemberExpression;
			if (memberExpression != null)
			{
				// Reference type property or field
				return memberExpression.Member.Name;
			}

			var methodCallExpression = expression as MethodCallExpression;
			if (methodCallExpression != null)
			{
				// Reference type method
				return methodCallExpression.Method.Name;
			}

			var unaryExpression = expression as UnaryExpression;
			if (unaryExpression != null)
			{
				// Property, field of method returning value type
				return GetMemberName(unaryExpression);
			}

			throw new ArgumentException("Invalid expression");
		}

		private static string GetMemberName(UnaryExpression unaryExpression)
		{
			var methodExpression = unaryExpression.Operand as MethodCallExpression;
			return methodExpression != null ? methodExpression.Method.Name : ((MemberExpression) unaryExpression.Operand).Member.Name;
		}
	}
}