using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AW.Helper
{
	/// <summary>
	/// Hierarchy node class which contains a nested collection of hierarchy nodes
	/// </summary>
	/// <typeparam name="T">Entity</typeparam>
	public class HierarchyNode<T>
	{
		public T Item { get; set; }
		public IEnumerable<HierarchyNode<T>> Children { get; set; }
	}

	// Stefan Cruysberghs, July 2008, http://www.scip.be
	/// <summary>
	/// AsHierarchy extension methods for LINQ to Objects IEnumerable
	/// </summary>
	public static class LinqToObjectsExtensionMethods
	{
		private static IQueryable<HierarchyNode<TSelectedEntity>> CreateHierarchy<TEntity, TSelectedEntity, TProperty, TProperty2>(IQueryable<TEntity> allItems, Expression<Func<TEntity, TProperty>> idProperty,
		                                                                                                                           Expression<Func<TEntity, TProperty2>> parentIdProperty, Expression<Func<TEntity, TSelectedEntity>> itemProperty,
		                                                                                                                           object rootItem)
			where TEntity : class
		{
			var exp =
				Expression.Lambda<Func<TEntity, bool>>(Expression.Equal(parentIdProperty.Body, Expression.Constant(rootItem, typeof (TProperty2))),
				                                       parentIdProperty.Parameters[0]);
			return allItems.Where(exp).Select(s => new HierarchyNode<TSelectedEntity> {Item = itemProperty.Compile().Invoke(s), Children = CreateHierarchy(allItems, idProperty, parentIdProperty, itemProperty, idProperty.Compile().Invoke(s))});
		}

		public static IQueryable<HierarchyNode<TEntity>> AsHierarchy<TEntity, TProperty>(
			this IQueryable<TEntity> allItems,
			Expression<Func<TEntity, TProperty>> idProperty,
			Expression<Func<TEntity, TProperty>> parentIdProperty
			) where TEntity : class
		{
			return CreateHierarchy(allItems, idProperty, parentIdProperty, s => s, default(TProperty));
		}

		public static IQueryable<HierarchyNode<TEntity>> AsHierarchy<TEntity, TProperty>(
			this IQueryable<TEntity> allItems,
			Expression<Func<TEntity, TProperty>> idProperty,
			Expression<Func<TEntity, TProperty?>> parentIdProperty)
			where TEntity : class
			where TProperty : struct
		{
			return CreateHierarchy(allItems, idProperty, parentIdProperty, s => s, null);
		}

		public static IQueryable<HierarchyNode<TSelectedEntity>> AsHierarchy<TEntity, TProperty, TSelectedEntity>(
			this IQueryable<TEntity> allItems,
			Expression<Func<TEntity, TProperty>> idProperty,
			Expression<Func<TEntity, TProperty>> parentIdProperty,
			Expression<Func<TEntity, TSelectedEntity>> itemSelector
			) where TEntity : class
		{
			return CreateHierarchy(allItems, idProperty, parentIdProperty, itemSelector, default(TProperty));
		}

		public static IQueryable<HierarchyNode<TSelectedEntity>> AsHierarchy<TEntity, TProperty, TSelectedEntity>(
			this IQueryable<TEntity> allItems,
			Expression<Func<TEntity, TProperty>> idProperty,
			Expression<Func<TEntity, TProperty?>> parentIdProperty,
			Expression<Func<TEntity, TSelectedEntity>> itemSelector)
			where TEntity : class
			where TProperty : struct
		{
			return CreateHierarchy(allItems, idProperty, parentIdProperty, itemSelector, null);
		}

		/// <summary>
		/// Recursively gets all the descendants of the specified source.
		/// </summary>
		/// <see cref="http://mutable.net/blog/archive/2008/05/23/using-linq-to-objects-for-recursion.aspx"/>
		/// <typeparam name="T"></typeparam>
		/// <param name="source">The source.</param>
		/// <param name="descendBy">The descend by function.</param>
		/// <returns></returns>
		public static IEnumerable<T> Descendants<T>(this IEnumerable<T> source, Func<T, IEnumerable<T>> descendBy)
		{
			if (source != null)
				foreach (var value in source)
				{
					yield return value;

					foreach (var child in descendBy(value).Descendants(descendBy))
					{
						yield return child;
					}
				}
		}

		public static IEnumerable<T> Descendants<T>(this T value, Func<T, IEnumerable<T>> descendBy)
		{
			return descendBy(value).Descendants(descendBy);
		}

		public static IEnumerable<T> DescendantsAndSelf<T>(this T value, Func<T, IEnumerable<T>> descendBy)
		{
			return descendBy(value).Descendants(descendBy).Union(new [] {value});
		}
	}
}