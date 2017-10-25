using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
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
          dataEditorPersister = new DataEditorLLBLSelfServicingPersister();
        else
        {
          var dataAccessAdapter = EntityHelper.GetDataAccessAdapter(enumerable);
          if (dataAccessAdapter != null) dataEditorPersister = new DataEditorLLBLAdapterPersister(dataAccessAdapter);
        }
      }
      return enumerable.DisplayInGrid(dataEditorPersister, pageSize, options);
    }

    /// <summary>
    /// Explore the data as LLBL Entities from a LINQPad like Treeview.
    /// </summary>
    /// <param name="linqMetaData">The linq meta data.</param>
    /// <param name="useSchema">if set to <c>true</c> group by schema.</param>
    /// <param name="prefixDelimiter">The prefix delimiter to group by table prefixes. e.g "_"</param>
    /// <param name="ensureFilteringEnabled">if set to <c>true</c> ensure filtering enabled, i.e. use ObjectListView rather than native LLBL EntityView.</param>
    /// <param name="useContext">if set to <c>true</c> [use context].</param>
    /// <param name="cacheDurationInSeconds">The cache duration in seconds.</param>
    /// <param name="pageSize">Size of the page.</param>
    /// <param name="cascadeDeletes">if set to <c>true</c> [cascade deletes].</param>
    /// <returns>
    /// True if succeeded rather than void so can be passed to LINQPads Dump method.
    /// </returns>
    /// <example>LinqPad: this.Explore()</example>
// ReSharper disable UnusedMember.Global
    public static bool Explore(this ILinqMetaData linqMetaData, bool useSchema = true, string prefixDelimiter = UsrCntrlEntityExplorer.DefaultPrefixDelimiter,
      bool ensureFilteringEnabled = true, bool useContext = true, int cacheDurationInSeconds = UsrCntrlEntityExplorer.DefaultCacheDurationInSeconds,
      ushort pageSize = GridDataEditor.DefaultPageSize, bool cascadeDeletes = true)
    {
      if (linqMetaData == null)
        return false;
      PanelManager.DisplayControl(new UsrCntrlEntityExplorer(linqMetaData, useSchema, prefixDelimiter, ensureFilteringEnabled, useContext, cacheDurationInSeconds, pageSize, cascadeDeletes
        , MembersToExcludeCache.GetMembersToExclude(typeof (EntityBase))), "Entity Explorer");
      return true;
    }

#if async
    public static async Task<IQueryable<T>> DisplayHierarchyInTree<T, TName, TChildCollection>(this IQueryable<T> queryable, Func<IEnumerable<T>, IEnumerable<T>> postProcessing, Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression) where T : class, IEntityCore
    {
      return LINQPad.CustomVisualizers.DisplayControl(queryable, await LLBLWinformHelper.HierarchyEditorFactoryAsync(queryable, postProcessing, namePropertyExpression, childCollectionPropertyExpression));
    }
#endif

    public static IEnumerable DisplayInGrid(this IEnumerable enumerable, ITransactionController transactionController, ushort pageSize)
    {
      return enumerable.DisplayInGrid(new DataEditorLLBLDataScopePersister(enumerable, transactionController), pageSize);
    }

    #region Adapter

    #region ByID

    public static IEnumerable DisplayHierarchyInTree<T>(this IEnumerable<T> enumerable, ITransactionController transactionController, string iDPropertyName, string parentIDPropertyName, string nameColumn)
    {
      return enumerable.DisplayHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn, new DataEditorLLBLDataScopePersister(enumerable, transactionController));
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T, TId, TParentId, TName>(this IEnumerable<T> enumerable, ITransactionController transactionController, Expression<Func<T, TId>> iDPropertyExpression,
      Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression)
    {
      return enumerable.DisplayHierarchyInTree(iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression, new DataEditorLLBLDataScopePersister(enumerable, transactionController));
    }

    #endregion

    public static IEnumerable DisplayHierarchyInTree<T>(this IEnumerable<T> enumerable, ITransactionController transactionController, string nameColumn, string childCollectionPropertyName)
    {
      return enumerable.DisplayHierarchyInTree(nameColumn, childCollectionPropertyName, new DataEditorLLBLDataScopePersister(enumerable, transactionController));
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T, TName, TChildCollection>(this IEnumerable<T> enumerable, ITransactionController transactionController, Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression)
    {
      return enumerable.DisplayHierarchyInTree(namePropertyExpression, childCollectionPropertyExpression, new DataEditorLLBLDataScopePersister(enumerable, transactionController));
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T, TI, TName, TChildCollection>(this IEnumerable<T> enumerable, ITransactionController transactionController, Func<T, TI> iDFunc, Func<T, bool> isChildFunc,
      Func<T, TI> parentIDFunc, Action<T, T> assignToParentFunc,
      Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression)
    {
      return enumerable.DisplayHierarchyInTree(iDFunc, isChildFunc, parentIDFunc, assignToParentFunc, namePropertyExpression, childCollectionPropertyExpression,
        new DataEditorLLBLDataScopePersister(enumerable, transactionController));
    }

    #endregion

    // ReSharper restore MemberCanBePrivate.Global
    // ReSharper restore UnusedMethodReturnValue.Global
    // ReSharper restore UnusedMember.Global
  }
}