// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace JesseJohnston
{
	internal class StringComparerPredicate
	{
		private string compareTo;
		private PropertyDescriptor property;
		private RelationalOperator op;
		private Regex exp;

		public StringComparerPredicate(PropertyDescriptor property, string value, RelationalOperator op)
		{
			if (property == null)
				throw new ArgumentNullException("property");

			this.property = property;
			this.compareTo = value;
			if (compareTo != null && compareTo.IndexOfAny(new char[] { '%', '*' }) > -1)
			{
				StringBuilder expr = new StringBuilder();
				expr.Append("^");
				foreach (char c in compareTo)
				{
					if (c == '*' || c == '%')
						expr.Append(".*");
					else
						expr.Append(c);
				}
				this.exp = new Regex(expr.ToString(), RegexOptions.IgnoreCase);
			}
			this.op = op;
		}

		public bool Matches(object item)
		{
			if (item == null)
				throw new ArgumentNullException("item");
			if (property.ComponentType != item.GetType())
				throw new ArgumentException("item");
			if (op == RelationalOperator.None)
				throw new ArgumentException("op");

			try
			{
				string testValue = (string)property.GetValue(item);

				int result;
				if (compareTo == null)
				{
					if (testValue == null)
						result = 0;
					else
						result = -1;
				}
				else if (testValue == null)
				{
					result = 1;
				}
				else
				{
					if (exp == null || (op != RelationalOperator.Equal && op != RelationalOperator.NotEqual))
					{
						result = compareTo.CompareTo(testValue);
					}
					else
					{
						Match m = exp.Match(testValue);
						return op == RelationalOperator.Equal ? m.Success : !m.Success;
					}
				}

				switch (op)
				{
					case RelationalOperator.Greater:
						return result < 0;
					case RelationalOperator.GreaterEqual:
						return result <= 0;
					case RelationalOperator.Less:
						return result > 0;
					case RelationalOperator.LessEqual:
						return result >= 0;
					case RelationalOperator.NotEqual:
						return result != 0;
					case RelationalOperator.Equal:
					default:
						return result == 0;
				}
			}
			catch (TargetException)
			{
				// An intermediate property is null, so the leaf property value in the path is inaccessible.
				// Just exclude this list item from the matches.
				if (property is PropertyPathDescriptor)
					return false;
				else
					throw;
			}
		}
	}
}
