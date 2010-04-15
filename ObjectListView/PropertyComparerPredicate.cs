// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace JesseJohnston
{
	internal class PropertyComparerPredicate<T>
	{
		private T compareTo;
		private PropertyDescriptor property;
		private RelationalOperator op;
		private Comparer<T> comparer;

		public PropertyComparerPredicate(PropertyDescriptor property, string value, RelationalOperator op)
		{
			if (property == null)
				throw new ArgumentNullException("property");
			if (op == RelationalOperator.None)
				throw new ArgumentException("op");

			this.property = property;

			if (value == null)
				this.compareTo = default(T);
			else
				this.compareTo = (T)property.Converter.ConvertFrom(value);

			this.op = op;

			this.comparer = Comparer<T>.Default;
		}

		public bool Matches(object item)
		{
			if (item == null)
				throw new ArgumentNullException("item");
			if (property.ComponentType != item.GetType())
				throw new ArgumentException("item");

			try
			{
				T testValue = (T)property.GetValue(item);

				int result = comparer.Compare(compareTo, testValue);

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
