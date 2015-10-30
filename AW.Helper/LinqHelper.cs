using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AW.Helper
{
  public static class LinqHelper
  {
    /// <summary>
    ///   Skips then takes.
    /// </summary>
    /// <param name="enumerable"> The enumerable. </param>
    /// <param name="pageIndex"> Index of the page. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
    public static IEnumerable SkipTake(IEnumerable enumerable, int pageIndex, int pageSize)
    {
      return Take(Skip(enumerable, pageIndex*pageSize), pageSize);
    }

    public static IEnumerable Skip(IEnumerable source, int count)
    {
      if (source == null) throw new ArgumentNullException("source");
      return SkipIterator(source, count);
    }

    private static IEnumerable SkipIterator(IEnumerable source, int count)
    {
      var e = source.GetEnumerator();
      {
        while (count > 0 && e.MoveNext()) count--;
        if (count <= 0)
        {
          while (e.MoveNext()) yield return e.Current;
        }
      }
    }

    public static IEnumerable Take(IEnumerable source, int count)
    {
      if (source == null) throw new ArgumentNullException("source");
      return TakeIterator(source, count);
    }

    private static IEnumerable TakeIterator(IEnumerable source, int count)
    {
      if (count > 0)
      {
        foreach (var element in source)
        {
          yield return element;
          if (--count == 0) break;
        }
      }
    }

    /// <summary>
    ///   Skips then takes.
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    /// <param name="queryable"> The query able. </param>
    /// <param name="pageIndex"> Index of the page. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
    public static IQueryable<T> SkipTake<T>(this IQueryable<T> queryable, int pageIndex, int pageSize)
    {
      return queryable.Skip(pageIndex*pageSize).Take(pageSize);
    }

    public static int GetPageCount(int pageSize, int totalItemCount)
    {
      if (totalItemCount > 0)
        return (int) Math.Ceiling(totalItemCount/(double) pageSize);
      return 0;
    }

    /// <summary>
    ///   returns null if empty.
    /// </summary>
    /// <see cref="http://haacked.com/archive/2010/06/16/null-or-empty-coalescing.aspx" />
    /// <param name="items"> The items. </param>
    /// <returns> </returns>
    public static IEnumerable<T> AsNullIfEmpty<T>(this IEnumerable<T> items)
    {
      return items == null || !items.Any() ? null : items;
    }

    /// <summary>
    ///   Determines whether the specified IEnumerable is null or empty.
    /// </summary>
    /// <see cref="http://haacked.com/archive/2010/06/10/checking-for-empty-enumerations.aspx" />
    /// <returns> <c>true</c> if specified IEnumerable is null or empty; otherwise, <c>false</c> . </returns>
    public static bool IsNullOrEmpty(this IEnumerable enumerable)
    {
      return TryIsNullOrEmpty(enumerable);
    }

    private static bool TryIsNullOrEmpty(dynamic enumerable)
    {
      return enumerable == null || MaybeIsNullOrEmpty(enumerable);
    }

    private static bool MaybeIsNullOrEmpty<T>(IEnumerable<T> items)
    {
      return items is ICollection ? !Any((ICollection)items) : items.AsNullIfEmpty() == null;
    }

    private static bool MaybeIsNullOrEmpty(IEnumerable enumerable)
    {
      return !Any(enumerable);
    }

    private static bool Any(ICollection collection)
    {
      return collection.Count > 0;
    }

    /// <summary>
    ///   Determines whether the specified enumerable has any items.
    /// </summary>
    /// <param name="enumerable"> The enumerable. </param>
    /// <param name="reset"> if set to <c>true</c> reset the enumerator if there are any items found. </param>
    /// <returns> </returns>
    public static bool Any(IEnumerable enumerable, bool reset = false)
    {
      var collection = enumerable as ICollection;
      if (collection != null)
        return Any(collection);
      var enumerator = enumerable.GetEnumerator();
      var any = enumerator.MoveNext();
      if (any && reset)
        try
        {
          enumerator.Reset();
        }
        catch (NotSupportedException)
        {
        }
        catch (NotImplementedException)
        {
        }
      
      return any;
    }

    public static IQueryable WhereDynamic(this IQueryable source, Expression lambdaExpression)
    {
      if (source == null)
        throw new ArgumentNullException("source");
      if (lambdaExpression == null)
        throw new ArgumentNullException("lambdaExpression");
      return source.Provider.CreateQuery(Expression.Call(typeof (Queryable), "Where", new[]
      {
        source.ElementType
      }, source.Expression, Expression.Quote(lambdaExpression) as Expression));
    }

    public static IQueryable OrderByDynamic(this IQueryable source, Expression expression, bool ascending = true)
    {
      if (source == null)
        throw new ArgumentNullException("source");
      if (expression == null)
        throw new ArgumentNullException("expression");
      const string str1 = "OrderBy";
      const string str2 = "OrderByDescending";
      var newExpression = (Expression) Expression.Call(typeof (Queryable), @ascending ? str1 : str2, new[]
      {
        source.ElementType,
        expression.Type
      }, source.Expression, Expression.Quote(expression));
      return source.Provider.CreateQuery(newExpression);
    }
  }
}