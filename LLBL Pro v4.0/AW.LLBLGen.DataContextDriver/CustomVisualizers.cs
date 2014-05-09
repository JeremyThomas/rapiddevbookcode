using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AW.Helper.LLBL;
using AW.LinqPadExtensions;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.LLBL;
using LINQPad.Extensibility.DataContext;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.LLBLGen.DataContextDriver
{
	public static class CustomVisualizers
	{
    /// <summary>
    /// Displays the enumerable in a paged DataGridView Custom Visualizer.
    /// If the enumerable contains LLBL entities it attempts to create a LLBL Persister
    /// </summary>
    /// <param name="enumerable">The enumerable.</param>
    /// <param name="pageSize">Size of the page.</param>
    /// <param name="options">The options.</param>
    /// <returns></returns>
    public static IEnumerable DisplayInGrid(IEnumerable enumerable, ushort pageSize, GridOptions options = null)
    {
      IDataEditorPersister dataEditorPersister = null;
      if (enumerable != null)
      {
        var elementType = LinqUtils.DetermineSetElementType(enumerable.GetType());
        if (typeof(EntityBase).IsAssignableFrom(elementType))
          dataEditorPersister = new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister();
        else
          {
            var dataAccessAdapter = EntityHelper.GetDataAccessAdapter(enumerable);
            if (dataAccessAdapter != null) dataEditorPersister = new LLBLWinformHelper.DataEditorLLBLAdapterPersister(dataAccessAdapter);
          }
      }
      return enumerable.DisplayInGrid(dataEditorPersister, pageSize, options);
    }

		#region Self Servicing

		public static IEnumerable<T> DisplaySelfServicingInGrid<T>(this IEnumerable<T> enumerable, ushort pageSize) where T : EntityBase
		{
			return enumerable.DisplayInGrid(new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister(), pageSize);
		}

		public static IEnumerable<T> DisplaySelfServicingInGrid<T>(this IEnumerable<T> enumerable) where T : EntityBase
		{
			return enumerable.DisplaySelfServicingInGrid(LinqPadExtensions.CustomVisualizers.DefaultPageSize);
		}

		public static IEnumerable DisplaySelfServicingInGrid(this IEnumerable enumerable, ushort pageSize)
		{
			return enumerable.DisplayInGrid(new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister(), pageSize);
		}

		public static IEnumerable<T> DisplaySelfServicingHierarchyInTree<T>(this IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : EntityBase
		{
			return enumerable.DisplayHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn, new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister());
		}

		public static IEnumerable<T> DisplaySelfServicingHierarchyInTree<T, TId, TParentId, TName>(this IEnumerable<T> enumerable, Expression<Func<T, TId>> iDPropertyExpression,
																																					Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression) where T : EntityBase
		{
			return enumerable.DisplayHierarchyInTree(iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression, new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister());
		}

		#endregion

		#region Adapter

		public static IEnumerable DisplayInGrid(this IEnumerable enumerable, IDataAccessAdapter dataAccessAdapter, ushort pageSize)
		{
			return enumerable.DisplayInGrid(new LLBLWinformHelper.DataEditorLLBLAdapterPersister(dataAccessAdapter), pageSize);
		}

		public static IEnumerable<T> DisplayInGrid<T>(this IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter, ushort pageSize) where T : EntityBase2
		{
			return enumerable.DisplayInGrid(new LLBLWinformHelper.DataEditorLLBLAdapterPersister(dataAccessAdapter), pageSize);
		}

		public static IEnumerable<T> DisplayAdapterInGrid<T>(this IQueryable<T> query, ushort pageSize) where T : EntityBase2
		{
			return DisplayInGrid(query, EntityHelper.GetDataAccessAdapter(query), pageSize);
		}

		public static IEnumerable<T> DisplayAdapterInGrid<T>(this IQueryable<T> query) where T : EntityBase2
		{
			return DisplayAdapterInGrid(query, LinqPadExtensions.CustomVisualizers.DefaultPageSize);
		}

		public static IEnumerable<T> DisplayHierarchyInTree<T>(this IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : EntityBase2
		{
			return enumerable.DisplayHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn, new LLBLWinformHelper.DataEditorLLBLAdapterPersister(dataAccessAdapter));
		}

		public static IEnumerable<T> DisplayAdapterHierarchyInTree<T>(this IQueryable<T> query, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : EntityBase2
		{
			return query.DisplayHierarchyInTree(EntityHelper.GetDataAccessAdapter(query), iDPropertyName, parentIDPropertyName, nameColumn);
		}

		public static IEnumerable<T> DisplayAdapterHierarchyInTree<T, TId, TParentId, TName>(this IQueryable<T> query, Expression<Func<T, TId>> iDPropertyExpression,
																																							Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression)
		{
			return query.DisplayHierarchyInTree(EntityHelper.GetDataAccessAdapter(query), iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression);
		}

		public static IEnumerable<T> DisplayHierarchyInTree<T, TId, TParentId, TName>(this IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter, Expression<Func<T, TId>> iDPropertyExpression,
																																					Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression)
		{
			return enumerable.DisplayHierarchyInTree(iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression, new LLBLWinformHelper.DataEditorLLBLAdapterPersister(dataAccessAdapter));
		}

		#endregion
	}
}
