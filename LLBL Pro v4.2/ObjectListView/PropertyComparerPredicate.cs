using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace JesseJohnston
{
  internal class PropertyComparerPredicate<T>
  {
    private readonly T compareTo;
    private readonly PropertyDescriptor property;
    private readonly RelationalOperator op;
    private readonly Comparer<T> comparer;

    public PropertyComparerPredicate(PropertyDescriptor property, string value, RelationalOperator op)
    {
      if (property == null)
        throw new ArgumentNullException("property");
      if (op == RelationalOperator.None)
        throw new ArgumentException("op");

      this.property = property;

      if (value == null)
        compareTo = default(T);
      else
        compareTo = (T) property.Converter.ConvertFrom(value);

      this.op = op;

      comparer = Comparer<T>.Default;
    }

    public bool Matches(object item)
    {
      if (item == null)
        throw new ArgumentNullException("item");
      if (property.ComponentType != item.GetType())
        throw new ArgumentException("item");

      try
      {
        var testValue = (T) property.GetValue(item);

        var result = comparer.Compare(compareTo, testValue);

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

  internal class InComparerPredicate<T>
  {
    private readonly PropertyDescriptor property;
    private readonly List<T> compareTo = new List<T>();
    private readonly Comparer<T> comparer;

    public InComparerPredicate(PropertyDescriptor property, string value)
    {
      if (property == null)
        throw new ArgumentNullException("property");

      this.property = property;

      if (value == null)
        compareTo.Add(default(T));
      else
      {
        comparer = Comparer<T>.Default;
        var values = ObjectListViewHelper.SplitCsvLine(value);
        if (values == null)
        {
          var compareTov = (T)property.Converter.ConvertFrom(null);
          compareTo.Add(compareTov);
        }
        else
          foreach (var s in values)
          {
            if (!string.IsNullOrEmpty(s))
            {
              var compareTov = (T) property.Converter.ConvertFrom(s);
              compareTo.Add(compareTov);
            }
          }
      }
    }

    public bool Matches(object item)
    {
      if (item == null)
        throw new ArgumentNullException("item");
      if (!property.ComponentType.IsAssignableFrom(item.GetType()))
        throw new ArgumentException("item");

      try
      {
        var testValue = (T)property.GetValue(item);
        foreach (var compareTov in compareTo)
        {
          var result = comparer.Compare(compareTov, testValue);
          if (result == 0)
            return true;
        }


            return false;
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