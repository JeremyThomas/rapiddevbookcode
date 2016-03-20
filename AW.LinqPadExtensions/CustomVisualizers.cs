using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
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
    public static object DisplayInGrid(this IEnumerable enumerable)
    {
      return DisplayInGrid(enumerable, DefaultPageSize);
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
    /// <returns>Null so can be used in a linqpad expression</returns>
    public static IEnumerable DisplayInGrid(this IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize = DefaultPageSize, GridOptions options = null)
    {
      if (enumerable != null)
      {
        var panelTitle = GetPanelTitle(enumerable, options);
        var outputPanel = PanelManager.DisplayControl(new GridDataEditor(enumerable, false, DataEditorPersisterFactory.Create(enumerable, dataEditorPersister), pageSize,
          false, options == null ? null : options.MembersToExclude), TrimTitle(panelTitle));
        outputPanel.ToolTip = panelTitle;
      }
      return null; //So can be used in a linqpad expression
    }

    #endregion

    #region LinqtoSQL

    public static IEnumerable DisplayInGrid<T>(this Table<T> table, ushort pageSize = DefaultPageSize) where T : class
    {
      return DisplayInGrid(table, table.Context, pageSize);
    }

    /// <summary>
    ///   Edits the DataQuery in a DataGridView.
    /// </summary>
    /// <param name="dataQuery"> The data query (System.Data.Linq.DataQuery`1). </param>
    /// <param name="dataContext"> The data context. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
    public static IEnumerable DisplayInGrid(this IEnumerable dataQuery, DataContext dataContext, ushort pageSize = DefaultPageSize)
    {
      return DisplayInGrid(dataQuery, new DataEditorLinqtoSQLPersister(dataContext), pageSize);
    }

    // ReSharper restore MemberCanBePrivate.Global

    #endregion

    #region HierarchyEditor

    #region  ByID

    public static IEnumerable DisplayHierarchyInTree(this IEnumerable enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn,
      IDataEditorPersister dataEditorPersister = null, params string[] membersToExclude)
    {
      return DisplayControl(enumerable, new HierarchyEditor(enumerable, iDPropertyName, parentIDPropertyName, nameColumn, DataEditorPersisterFactory.Create(enumerable, dataEditorPersister), membersToExclude));
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T, TId, TParentId, TName>(this IEnumerable<T> enumerable, Expression<Func<T, TId>> iDPropertyExpression,
      Expression<Func<T, TParentId>> parentIDPropertyExpression,
      Expression<Func<T, TName>> namePropertyExpression, IDataEditorPersister dataEditorPersister = null, params string[] membersToExclude)
    {
      return DisplayControl(enumerable, HierarchyEditor.HierarchyEditorFactory(enumerable, iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression,
        DataEditorPersisterFactory.Create(enumerable, dataEditorPersister), membersToExclude));
    }

    #endregion

    public static IEnumerable DisplayHierarchyInTree(this IEnumerable enumerable, string nameColumn, string childCollectionPropertyName,
      IDataEditorPersister dataEditorPersister = null, params string[] membersToExclude)
    {
      return DisplayControl(enumerable, new HierarchyEditor(enumerable, nameColumn, childCollectionPropertyName, DataEditorPersisterFactory.Create(enumerable, dataEditorPersister), membersToExclude));
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T, TName, TChildCollection>(this IEnumerable<T> enumerable, Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression, IDataEditorPersister dataEditorPersister = null, params string[] membersToExclude)
    {
      return DisplayControl(enumerable, HierarchyEditor.HierarchyEditorFactory(enumerable, namePropertyExpression, childCollectionPropertyExpression,
        DataEditorPersisterFactory.Create(enumerable, dataEditorPersister), membersToExclude));
    }

    public static IEnumerable<T> DisplayHierarchyInTree<T, TI, TName, TChildCollection>(this IEnumerable<T> enumerable, Func<T, TI> iDFunc, Func<T, bool> isChildFunc,
      Func<T, TI> parentIDFunc, Action<T, T> assignToParentFunc,
      Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression, IDataEditorPersister dataEditorPersister = null, params string[] membersToExclude)
    {
      return DisplayControl(enumerable, HierarchyEditor.HierarchyEditorFactory(enumerable, iDFunc, isChildFunc, parentIDFunc, assignToParentFunc,
        namePropertyExpression, childCollectionPropertyExpression, DataEditorPersisterFactory.Create(enumerable, dataEditorPersister)));
    }

    #endregion

    public static T DisplayControl<T>(T o, Control control)
    {
      if (o != null)
      {
        var panelTitle = GetPanelTitle(o);
        var outputPanel = PanelManager.DisplayControl(control, TrimTitle(panelTitle));
        outputPanel.ToolTip = panelTitle;
      }
      return default(T); //So can be used in a linqpad expression ala LINQPad.Extensions.Dump
    }

    private static T DisplayForm<T>(T o, Form form)
    {
      if (o != null)
      {
        form.TopLevel = false;
        form.FormBorderStyle = FormBorderStyle.None;
        DisplayControl(o, form);
      }
      return o; //So can be used in a linqpad expression
    }

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
      return _objectToStringMethodInfo == null ? o.GetType().FriendlyName() :
        Convert.ToString(_objectToStringMethodInfo.Invoke(null, BindingFlags.InvokeMethod, null, new[] {o}, null));
    }

    /// <summary>
    ///   Browse the properties of an object and any objects it references in the LINQPad output panel.
    /// </summary>
    /// <remarks>https://rapiddevbookcode.codeplex.com/wikipage?title=ObjectInspector</remarks>
    /// <param name="objectToBrowse">The object to browse.</param>
    /// <returns>The object to browse.</returns>
    public static object Inspect(this object objectToBrowse)
    {
      return DisplayForm(objectToBrowse, new FrmEntityViewer(objectToBrowse));
    }

    // ReSharper restore PossibleMultipleEnumeration
    // ReSharper restore UnusedMember.Global
  }
}