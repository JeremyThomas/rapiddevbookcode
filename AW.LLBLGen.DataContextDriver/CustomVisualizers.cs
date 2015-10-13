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

    public static IQueryable<T> DisplaySelfServicingHierarchyInTree<T, TName, TChildCollection>(this IQueryable<T> queryable, Func<IEnumerable<T>, IEnumerable<T>> postProcessing, 
      Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression) where T : EntityBase
    {
      return LINQPad.CustomVisualizers.DisplayControl(queryable, LLBLWinformHelper.HierarchyEditorFactoryServicing(queryable, postProcessing, namePropertyExpression, childCollectionPropertyExpression));
    }
    
    #endregion

    #region Adapter

    public static IEnumerable DisplayInGrid(this IEnumerable enumerable, ITransactionController transactionController, ushort pageSize)
    {
      return enumerable.DisplayInGrid(new DataEditorLLBLDataScopePersister(enumerable, transactionController), pageSize);
    }

    #region ByID

    public static IEnumerable DisplayHierarchyInTree<T>(this IEnumerable<T> enumerable, ITransactionController transactionController, string iDPropertyName, string parentIDPropertyName, string nameColumn) 
    {
      return enumerable.DisplayHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn, new DataEditorLLBLDataScopePersister(enumerable, transactionController));
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T, TId, TParentId, TName>(this IEnumerable<T> enumerable, ITransactionController dataAccessAdapter, Expression<Func<T, TId>> iDPropertyExpression,
      Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression) 
    {
      return enumerable.DisplayHierarchyInTree(iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression, new DataEditorLLBLDataScopePersister(enumerable, dataAccessAdapter));
    }

    #endregion

    public static IEnumerable DisplayHierarchyInTree<T>(this IEnumerable<T> enumerable, ITransactionController transactionController, string nameColumn, string childCollectionPropertyName)
    {
      return enumerable.DisplayHierarchyInTree(nameColumn, childCollectionPropertyName, new DataEditorLLBLDataScopePersister(enumerable, transactionController));
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T, TName, TChildCollection>(this IEnumerable<T> enumerable, ITransactionController dataAccessAdapter, Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression) 
    {
      return enumerable.DisplayHierarchyInTree(namePropertyExpression, childCollectionPropertyExpression, new DataEditorLLBLDataScopePersister(enumerable, dataAccessAdapter));
    }

    public static IQueryable<T> DisplayAdapterHierarchyInTree<T, TName, TChildCollection>(this IQueryable<T> queryable, Func<IEnumerable<T>, IEnumerable<T>> postProcessing, Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression) where T : EntityBase2
    {
      return LINQPad.CustomVisualizers.DisplayControl(queryable, LLBLWinformHelper.HierarchyEditorFactory(queryable, postProcessing, namePropertyExpression, childCollectionPropertyExpression));
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T, TI, TName, TChildCollection>(this IEnumerable<T> enumerable, ITransactionController dataAccessAdapter, Func<T, TI> iDFunc, Func<T, bool> isChildFunc,
      Func<T, TI> parentIDFunc, Action<T, T> assignToParentFunc,
      Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression) 
    {
      return enumerable.DisplayHierarchyInTree(iDFunc, isChildFunc, parentIDFunc, assignToParentFunc,namePropertyExpression, childCollectionPropertyExpression, 
        new DataEditorLLBLDataScopePersister(enumerable, dataAccessAdapter));
    }

    #endregion

    // ReSharper restore MemberCanBePrivate.Global
    // ReSharper restore UnusedMethodReturnValue.Global
    // ReSharper restore UnusedMember.Global
  }
}