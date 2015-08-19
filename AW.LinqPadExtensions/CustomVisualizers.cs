using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.EntityViewer;
using LINQPad.Extensibility.DataContext;

namespace LINQPad
{
  public static class CustomVisualizers
  {
    #region DataGridView

    /// <summary>
    ///   10
    /// </summary>
    public const ushort DefaultPageSize = 10;

    /// <summary>
    ///   Displays the enumerable in a paged DataGridView Custom Visualizer.
    /// </summary>
    /// <param name="enumerable"> The enumerable. </param>
    /// <returns> </returns>
// ReSharper disable UnusedMember.Global
    public static IEnumerable DisplayInGrid(this IEnumerable enumerable)
    {
      if (enumerable != null)
      {
        var dataContext = GetDataContext(enumerable);
        if (dataContext != null)
          return DisplayInGrid(enumerable, new DataEditorLinqtoSQLPersister(dataContext));
      }
      return DisplayInGrid(enumerable, DefaultPageSize);
    }

    private static DataContext GetDataContext(object enumerable)
    {
      var contextField = enumerable.GetType().GetField("context", BindingFlags.Instance | BindingFlags.NonPublic);
      if (contextField != null)
        return contextField.GetValue(enumerable) as DataContext;
      return null;
    }

    /// <summary>
    ///   Displays the enumerable in a paged DataGridView Custom Visualizer.
    /// </summary>
    /// <param name="enumerable"> The enumerable. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
// ReSharper disable MemberCanBePrivate.Global
    public static IEnumerable DisplayInGrid(this IEnumerable enumerable, ushort pageSize)
    {
      return DisplayInGrid(enumerable, null, pageSize);
    }

    // ReSharper disable PossibleMultipleEnumeration

    /// <summary>
    ///   Displays the enumerable in a paged DataGridView Custom Visualizer.
    /// </summary>
    /// <param name="enumerable">The enumerable.</param>
    /// <param name="dataEditorPersister">The data editor persister.</param>
    /// <param name="pageSize">Size of the page.</param>
    /// <param name="options">The options.</param>
    /// <returns></returns>
    public static IEnumerable DisplayInGrid(this IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize = DefaultPageSize, GridOptions options = null)
    {
      if (enumerable != null)
      {
        var panelTitle = GetPanelTitle(enumerable, options);
        var outputPanel = PanelManager.DisplayControl(new GridDataEditor(enumerable, dataEditorPersister, pageSize, false, options == null ? null : options.MembersToExclude), TrimTitle(panelTitle));
        outputPanel.ToolTip = panelTitle;
      }
      return Enumerable.Empty<object>(); //So can be used in a linqpad expression
    }

    #endregion

    #region DataGridViewGeneric

    /// <summary>
    ///   Displays the enumerable in a paged DataGridView Custom Visualizer.
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    /// <param name="enumerable"> The enumerable. </param>
    /// <returns> </returns>
    public static IEnumerable<T> DisplayInGrid<T>(this IEnumerable<T> enumerable)
    {
      if (enumerable != null)
      {
        var queryContext = GetDataContext(enumerable);
        return queryContext == null ? DisplayInGrid(enumerable, (IDataEditorPersister) null) : DisplayInGrid(enumerable, queryContext);
      }
      return Enumerable.Empty<T>();
    }

    /// <summary>
    ///   Displays the enumerable in a paged DataGridView Custom Visualizer.
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    /// <param name="enumerable"> The enumerable. </param>
    /// <param name="dataEditorPersister"> The data editor persister. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
    public static IEnumerable<T> DisplayInGrid<T>(this IEnumerable<T> enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize = DefaultPageSize)
    {
      if (enumerable != null)
      {
        var panelTitle = GetPanelTitle(enumerable);
        var outputPanel = PanelManager.DisplayControl(GridDataEditorT<T>.GridDataEditorFactory(enumerable, dataEditorPersister, pageSize, false), TrimTitle(panelTitle));
        outputPanel.ToolTip = panelTitle;
      }
      return Enumerable.Empty<T>(); //So can be used in a linqpad expression
    }

    #endregion

    #region LinqtoSQL

    public static IEnumerable<T> DisplayInGrid<T>(this Table<T> table, ushort pageSize = DefaultPageSize) where T : class
    {
      return DisplayInGrid(table, table.Context, pageSize);
    }


    /// <summary>
    ///   Edits the DataQuery in a DataGridView.
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    /// <param name="dataQuery"> The data query (System.Data.Linq.DataQuery`1). </param>
    /// <param name="dataContext"> The data context. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
    public static IEnumerable<T> DisplayInGrid<T>(this IEnumerable<T> dataQuery, DataContext dataContext, ushort pageSize = DefaultPageSize)
    {
      return DisplayInGrid(dataQuery, new DataEditorLinqtoSQLPersister(dataContext), pageSize);
    }

    // ReSharper restore MemberCanBePrivate.Global

    #endregion

    #region HierarchyEditor

    public static IEnumerable<T> DisplayHierarchyInTree<T>(this IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn, IDataEditorPersister dataEditorPersister = null, params string[] membersToExclude)
    {
      if (enumerable != null)
      {
        var panelTitle = GetPanelTitle(enumerable);
        var outputPanel = PanelManager.DisplayControl(new HierarchyEditor(enumerable, iDPropertyName, parentIDPropertyName, nameColumn, dataEditorPersister, membersToExclude), TrimTitle(panelTitle));
        outputPanel.ToolTip = panelTitle;
      }
      return enumerable;
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T>(this IEnumerable<T> enumerable, string nameColumn, string childCollectionPropertyName, IDataEditorPersister dataEditorPersister = null, params string[] membersToExclude)
    {
      if (enumerable != null)
      {
        var panelTitle = GetPanelTitle(enumerable);
        var outputPanel = PanelManager.DisplayControl(new HierarchyEditor(enumerable,  nameColumn, childCollectionPropertyName,dataEditorPersister, membersToExclude), TrimTitle(panelTitle));
        outputPanel.ToolTip = panelTitle;
      }
      return enumerable;
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T, TId, TParentId, TName>(this IEnumerable<T> enumerable, Expression<Func<T, TId>> iDPropertyExpression,
      Expression<Func<T, TParentId>> parentIDPropertyExpression,
      Expression<Func<T, TName>> namePropertyExpression, IDataEditorPersister dataEditorPersister = null, params string[] membersToExclude)
    {
      if (enumerable != null)
      {
        var panelTitle = GetPanelTitle(enumerable);
        var outputPanel = PanelManager.DisplayControl(HierarchyEditor.HierarchyEditorFactory(enumerable, iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression, dataEditorPersister, membersToExclude), TrimTitle(panelTitle));
        outputPanel.ToolTip = panelTitle;
      }
      return enumerable;
    }

    #endregion

    private static string GetPanelTitle(object o, GridOptions options = null)
    {
      return options == null || options.PanelTitle == null ? GetFriendlyObjectTypeName(o) : options.PanelTitle;
    }

    private static string TrimTitle(string panelTitle, int trimLength = 25)
    {
      if (panelTitle.Length > trimLength)
        panelTitle = panelTitle.Substring(0, trimLength - 5) + "...";
      return panelTitle;
    }

    private static MethodInfo _objectToStringMethodInfo;

    private static string GetFriendlyObjectTypeName(object o)
    {
      if (_objectToStringMethodInfo == null)
      {
        var explorerGridType = typeof (PanelManager).Assembly.GetType("LINQPad.UI.ExplorerGrid");
        if (explorerGridType != null)
          _objectToStringMethodInfo = explorerGridType.GetMethod("ObjectToString", BindingFlags.Public | BindingFlags.Static);
      }
      return _objectToStringMethodInfo == null ? o.GetType().FriendlyName() : Convert.ToString(_objectToStringMethodInfo.Invoke(null, BindingFlags.InvokeMethod, null, new[] {o}, null));
    }

    /// <summary>
    ///   Browse the properties of an object and any objects it references in the LINQPad output panel.
    /// </summary>
    /// <see cref="https://rapiddevbookcode.codeplex.com/wikipage?title=ObjectInspector" />
    /// <param name="objectToBrowse">The object to browse.</param>
    /// <returns>The object to browse.</returns>
    public static object Inspect(this object objectToBrowse)
    {
      if (objectToBrowse != null)
      {
        var panelTitle = GetPanelTitle(objectToBrowse);
        var outputPanel = PanelManager.DisplayControl(new FrmEntityViewer(objectToBrowse) {TopLevel = false, FormBorderStyle = FormBorderStyle.None}, TrimTitle(panelTitle));
        outputPanel.ToolTip = panelTitle;
      }
      return objectToBrowse;
    }

    // ReSharper restore PossibleMultipleEnumeration
    // ReSharper restore UnusedMember.Global
  }
}