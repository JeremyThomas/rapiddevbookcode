using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.LLBL;
using LINQPad;
using LINQPad.Extensibility.DataContext;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.LLBLGen.DataContextDriver
{
  /// <summary>
  /// </summary>
  public static class CustomVisualizers
  {
    static CustomVisualizers()
    {
      CSharpSerializer.SetPropertiesToExcludeIfEmpty("Fields,EntityFactoryToUse");
      GridDataEditor.SerializeToCSharpOutputFormat = OutputFormat.LinqpadProgram;
    }

    /// <summary>
    ///   Displays the enumerable in a paged DataGridView Custom Visualizer.
    ///   If the enumerable contains LLBL entities it attempts to create a LLBL Persister
    /// </summary>
    /// <param name="enumerable">The enumerable.</param>
    /// <param name="pageSize">Size of the page.</param>
    /// <param name="options">The options.</param>
    /// <returns></returns>
// ReSharper disable UnusedMethodReturnValue.Global
    public static object DisplayInGrid(IEnumerable enumerable, ushort pageSize, GridOptions options = null)
    {
      IDataEditorPersister dataEditorPersister = null;
      if (enumerable != null)
      {
        var elementType = LinqUtils.DetermineSetElementType(enumerable.GetType());
        if (typeof (EntityBase).IsAssignableFrom(elementType))
          dataEditorPersister = new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister();
        else
        {
          var dataAccessAdapter = EntityHelper.GetDataAccessAdapter(enumerable);
          if (dataAccessAdapter != null) dataEditorPersister = new LLBLWinformHelper.DataEditorLLBLAdapterPersister(dataAccessAdapter);
        }
      }
      return enumerable.DisplayInGrid(dataEditorPersister, pageSize, options);
    }

    /// <summary>
    ///   Browses the data as LLBL Entities from a LINQPad like Treeview.
    /// </summary>
    /// <param name="linqMetaData">The linq meta data.</param>
    /// <param name="useSchema">if set to <c>true</c> group by schema.</param>
    /// <param name="prefixDelimiter">The prefix delimiter to group by table prefixes. e.g "_"</param>
    /// <param name="ensureFilteringEnabled">if set to <c>true</c> ensure filtering enabled, i.e. use ObjectListView rather than native LLBL EntityView.</param>
    /// <param name="useContext">if set to <c>true</c> [use context].</param>
    /// <param name="cacheDurationInSeconds">The cache duration in seconds.</param>
    /// <returns>
    ///   True if succeeded rather than void so can be passed to LINQPads Dump method.
    /// </returns>
    /// <example>LinqPad: this.BrowseData()</example>
// ReSharper disable UnusedMember.Global
    public static bool BrowseData(this ILinqMetaData linqMetaData, bool useSchema = true, string prefixDelimiter = UsrCntrlEntityBrowser.DefaultPrefixDelimiter,
      bool ensureFilteringEnabled = true, bool useContext = true, int cacheDurationInSeconds = UsrCntrlEntityBrowser.DefaultCacheDurationInSeconds)
    {
      if (linqMetaData == null)
        return false;
      PanelManager.DisplayControl(new UsrCntrlEntityBrowser(linqMetaData, useSchema, prefixDelimiter, ensureFilteringEnabled, useContext, cacheDurationInSeconds
        , MembersToExcludeCache.GetMembersToExclude(typeof (EntityBase))), "Data Browser");
      return true;
    }

    #region Self Servicing

// ReSharper disable MemberCanBePrivate.Global
    public static object DisplaySelfServicingInGrid<T>(this IEnumerable<T> enumerable, ushort pageSize) where T : EntityBase
    {
      return enumerable.DisplayInGrid(new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister(), pageSize);
    }

    public static object DisplaySelfServicingInGrid<T>(this IEnumerable<T> enumerable) where T : EntityBase
    {
      return enumerable.DisplaySelfServicingInGrid(LINQPad.CustomVisualizers.DefaultPageSize);
    }

    public static object DisplaySelfServicingInGrid(this IEnumerable enumerable, ushort pageSize)
    {
      return enumerable.DisplayInGrid(new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister(), pageSize);
    }

    public static IEnumerable<T> DisplaySelfServicingHierarchyInTree<T>(this IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : EntityBase
    {
      return enumerable.DisplayHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn, new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister());
    }

    public static IEnumerable<T> DisplaySelfServicingHierarchyInTree<T>(this IEnumerable<T> enumerable, string nameColumn, string childCollectionPropertyName) where T : EntityBase
    {
      return enumerable.DisplayHierarchyInTree(nameColumn, childCollectionPropertyName, new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister());
    }

    public static IEnumerable<T> DisplaySelfServicingHierarchyInTree<T, TId, TParentId, TName>(this IEnumerable<T> enumerable, Expression<Func<T, TId>> iDPropertyExpression,
      Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression) where T : EntityBase
    {
      return enumerable.DisplayHierarchyInTree(iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression, new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister());
    }

    public static IEnumerable<T> DisplaySelfServicingHierarchyInTree<T, TName, TChildCollection>(IEnumerable<T> enumerable, Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression)
    {
      return enumerable.DisplayHierarchyInTree(namePropertyExpression, childCollectionPropertyExpression, new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister());
    }

    #endregion

    #region Adapter

    public static object DisplayInGrid(this IEnumerable enumerable, IDataAccessAdapter dataAccessAdapter, ushort pageSize)
    {
      return enumerable.DisplayInGrid(new LLBLWinformHelper.DataEditorLLBLAdapterPersister(dataAccessAdapter), pageSize);
    }

    public static object DisplayInGrid<T>(this IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter, ushort pageSize) where T : EntityBase2
    {
      return enumerable.DisplayInGrid(new DataEditorLLBLAdapterDataScopePersister<T>(enumerable, dataAccessAdapter), pageSize);
    }

    public static object DisplayAdapterInGrid<T>(this IQueryable<T> query, ushort pageSize = LINQPad.CustomVisualizers.DefaultPageSize) where T : EntityBase2
    {
      return DisplayInGrid(query, EntityHelper.GetDataAccessAdapter(query), pageSize);
    }

    #region ByID

    public static IEnumerable<T> DisplayHierarchyInTree<T>(this IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : EntityBase2
    {
      return enumerable.DisplayHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn, new DataEditorLLBLAdapterDataScopePersister<T>(enumerable, dataAccessAdapter));
    }

    public static IEnumerable<T> DisplayAdapterHierarchyInTree<T>(this IQueryable<T> query, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : EntityBase2
    {
      return LINQPad.CustomVisualizers.DisplayControl(query, LLBLWinformHelper.HierarchyEditorFactory(query, iDPropertyName, parentIDPropertyName, nameColumn));
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T, TId, TParentId, TName>(this IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter, Expression<Func<T, TId>> iDPropertyExpression,
      Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression) where T : EntityBase2
    {
      return enumerable.DisplayHierarchyInTree(iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression, new DataEditorLLBLAdapterDataScopePersister<T>(enumerable, dataAccessAdapter));
    }

    public static IEnumerable<T> DisplayAdapterHierarchyInTree<T, TId, TParentId, TName>(this IQueryable<T> query, Expression<Func<T, TId>> iDPropertyExpression,
      Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression) where T : EntityBase2
    {
      return LINQPad.CustomVisualizers.DisplayControl(query, LLBLWinformHelper.HierarchyEditorFactory(query, iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression));
    }

    #endregion

    public static IEnumerable<T> DisplayHierarchyInTree<T>(this IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter, string nameColumn, string childCollectionPropertyName) where T : EntityBase2
    {
      return enumerable.DisplayHierarchyInTree(nameColumn, childCollectionPropertyName, new DataEditorLLBLAdapterDataScopePersister<T>(enumerable, dataAccessAdapter));
    }

    public static IEnumerable<T> DisplayAdapterHierarchyInTree<T>(this IQueryable<T> query, string nameColumn, string childCollectionPropertyName) where T : EntityBase2
    {
      return LINQPad.CustomVisualizers.DisplayControl(query, LLBLWinformHelper.HierarchyEditorFactory(query, nameColumn, childCollectionPropertyName));
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T, TName, TChildCollection>(this IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter, Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression) where T : EntityBase2
    {
      return enumerable.DisplayHierarchyInTree(namePropertyExpression, childCollectionPropertyExpression, new DataEditorLLBLAdapterDataScopePersister<T>(enumerable, dataAccessAdapter));
    }

    public static IQueryable<T> DisplayAdapterHierarchyInTree<T, TName, TChildCollection>(this IQueryable<T> queryable, Action<IEnumerable<T>> postProcessing, Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression) where T : EntityBase2
    {
      return LINQPad.CustomVisualizers.DisplayControl(queryable, LLBLWinformHelper.HierarchyEditorFactory(queryable, postProcessing, namePropertyExpression, childCollectionPropertyExpression));
    }

    public static IQueryable<T> DisplayAdapterHierarchyInTree<T, TI, TName, TChildCollection>(IQueryable<T> query, Func<T, TI> iDFunc, Func<T, bool> isChildFunc,
      Func<T, TI> parentIDFunc, Action<T, T> assignToParentFunc,
      Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression) where T : EntityBase2
    {
      return LINQPad.CustomVisualizers.DisplayControl(query, HierarchyEditor.HierarchyEditorFactory(query, iDFunc, isChildFunc, parentIDFunc, assignToParentFunc,
        namePropertyExpression, childCollectionPropertyExpression, new DataEditorLLBLAdapterDataScopePersister<T>(query)));
    }

    #endregion

    // ReSharper restore MemberCanBePrivate.Global
    // ReSharper restore UnusedMethodReturnValue.Global
    // ReSharper restore UnusedMember.Global
  }
}