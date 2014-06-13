﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using AW.Winforms.Helpers.Controls;

namespace AW.Winforms.Helpers.DataEditor
{
  public static class DataEditorExtensions
  {
    public const int DefaultPageSize = 30;

    #region DataGridView

    public static IQueryable ShowInGrid(this IEnumerable enumerable)
    {
      return ShowInGrid(enumerable, DefaultPageSize) as IQueryable;
    }

// ReSharper disable MemberCanBePrivate.Global
    public static IEnumerable ShowInGrid(this IEnumerable enumerable, ushort pageSize)
    {
      return ShowInGrid(enumerable, null, pageSize);
    }

    public static IEnumerable ShowInGrid(this IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize = DefaultPageSize)
    {
      if (enumerable != null)
        FrmDataEditor.CreateDataEditorForm(enumerable, dataEditorPersister, pageSize).ShowDialog();
      return enumerable;
    }

    #endregion

    #region DataGridViewGeneric

    public static IEnumerable<T> ShowInGrid<T>(this IEnumerable<T> enumerable)
    {
      var contextField = enumerable.GetType().GetField("context", BindingFlags.Instance | BindingFlags.NonPublic);
      if (contextField != null)
      {
        var queryContext = contextField.GetValue(enumerable) as DataContext;
        if (queryContext != null)
          return ShowInGrid(enumerable, queryContext);
      }
      return ShowInGrid(enumerable, (IDataEditorPersister) null);
    }

    /// <summary>
    ///   Edits the enumerable in a DataGridView.
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    /// <param name="enumerable"> The enumerable. </param>
    /// <param name="dataEditorPersister"> The grid data editor persister. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
    public static IEnumerable<T> ShowInGrid<T>(this IEnumerable<T> enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize = DefaultPageSize)
    {
      if (enumerable != null)
        FrmDataEditor.CreateDataEditorForm(enumerable, dataEditorPersister, pageSize, false).ShowDialog();
      return enumerable;
    }

    #endregion

    #region LinqtoSQL

    public static IEnumerable<T> ShowInGrid<T>(this Table<T> table, ushort pageSize = DefaultPageSize) where T : class
    {
      return ShowInGrid(table, table.Context, pageSize);
    }

    /// <summary>
    ///   Edits the DataQuery in a DataGridView.
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    /// <param name="dataQuery"> The data query (System.Data.Linq.DataQuery`1). </param>
    /// <param name="dataContext"> The data context. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
    public static IEnumerable<T> ShowInGrid<T>(this IEnumerable<T> dataQuery, DataContext dataContext, ushort pageSize = DefaultPageSize)
    {
      return ShowInGrid(dataQuery, new DataEditorLinqtoSQLPersister(dataContext), pageSize);
    }

    public static IEnumerable<T> ShowHierarchyInTree<T>(this Table<T> table, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : class
    {
      return table.ShowHierarchyInTree(table.Context, iDPropertyName, parentIDPropertyName, nameColumn);
    }

    public static IEnumerable<T> ShowHierarchyInTree<T>(this IEnumerable<T> enumerable, DataContext dataContext, string iDPropertyName, string parentIDPropertyName, string nameColumn)
    {
      return enumerable.ShowHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn, new DataEditorLinqtoSQLPersister(dataContext));
    }

    #endregion

    public static void CopyEntireDataGridViewToClipboard(this DataGridView dataGridView)
    {
      dataGridView.SelectAll();
      Clipboard.SetDataObject(dataGridView.GetClipboardContent());
    }

    public static IEnumerable<T> ShowHierarchyInTree<T>(this IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn, IDataEditorPersister dataEditorPersister = null)
    {
      FrmHierarchyEditor.LaunchForm(enumerable, iDPropertyName, parentIDPropertyName, nameColumn, dataEditorPersister);
      return enumerable;
    }

    public static IEnumerable<T> ShowHierarchyInTree<T, TId, TParentId, TName>(this IEnumerable<T> enumerable, Expression<Func<T, TId>> iDPropertyExpression,
      Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression,
      IDataEditorPersister dataEditorPersister = null)
    {
      FrmHierarchyEditor.LaunchForm(enumerable, iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression, dataEditorPersister);
      return enumerable;
    }

    // ReSharper restore MemberCanBePrivate.Global
  }
}