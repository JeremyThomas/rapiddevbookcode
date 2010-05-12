using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using AW.Winforms.Helpers.Controls;

namespace AW.Winforms.Helpers.DataEditor
{
  public static class DataEditorExtensions
  {
    public const int DefaultPageSize = 30;

    #region DataGridView

    public static IQueryable ViewInDataGridView(this IQueryable enumerable)
    {
      return ViewInDataGridView(enumerable, DefaultPageSize) as IQueryable;
    }

    public static IEnumerable ViewInDataGridView(this IQueryable enumerable, ushort pageSize)
    {
      return EditInDataGridView(enumerable, null, pageSize);
    }

    public static IEnumerable EditInDataGridView(this IEnumerable enumerable, IGridDataEditorPersister gridDataEditorPersister)
    {
      return EditInDataGridView(enumerable, gridDataEditorPersister, DefaultPageSize);
    }

    public static IEnumerable EditInDataGridView(this IEnumerable enumerable, IGridDataEditorPersister gridDataEditorPersister, ushort pageSize)
    {
      if (enumerable != null)
        CreateDataEditorForm(enumerable, gridDataEditorPersister, pageSize, false).ShowDialog();
      return enumerable;
    }

    public static FrmDataEditor CreateDataEditorForm(IEnumerable enumerable, IGridDataEditorPersister gridDataEditorPersister, ushort pageSize, bool readOnly)
    {
      string text;
      if (enumerable is DataView)
      {
        var dataView = ((DataView) enumerable);
        text = dataView.Table.TableName + " via a DataView";
      }
      else
        text = enumerable.ToString();
      var dataGridView = new FrmDataEditor {Text = text};
      var gridDataEditor = new GridDataEditor {Dock = DockStyle.Fill};
      dataGridView.Controls.Add(gridDataEditor);
      gridDataEditor.GridDataEditorPersister = gridDataEditorPersister;
      gridDataEditor.Readonly = readOnly;
      gridDataEditor.BindEnumerable(enumerable, pageSize);
      return dataGridView;
    }

    public static FrmDataEditor CreateDataViewForm(IEnumerable enumerable)
    {
      return CreateDataEditorForm(enumerable, null, DefaultPageSize, true);
    }

    #endregion

    #region DataGridViewGeneric

    public static IQueryable<T> ViewInDataGridView<T>(this IQueryable<T> enumerable)
    {
      return EditInDataGridView((IEnumerable<T>) enumerable, null).AsQueryable();
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, IGridDataEditorPersister gridDataEditorPersister)
    {
      return EditInDataGridView(enumerable, gridDataEditorPersister, DefaultPageSize);
    }

    /// <summary>
    /// Edits the enumerable in a DataGridView.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="enumerable">The enumerable.</param>
    /// <param name="gridDataEditorPersister">The grid data editor persister.</param>
    /// <param name="pageSize">Size of the page.</param>
    /// <returns></returns>
    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, IGridDataEditorPersister gridDataEditorPersister, ushort pageSize)
    {
      if (enumerable != null)
      {
        var frmDataEditor = new FrmDataEditor {Text = enumerable.ToString()};
        var gridDataEditor = new GridDataEditorT<T> {Dock = DockStyle.Fill};
        frmDataEditor.Controls.Add(gridDataEditor);
        gridDataEditor.GridDataEditorPersister = gridDataEditorPersister;
						
				//var type = typeof(T);
				//var typeDescriptionProvider = TypeDescriptor.GetProvider(type);
				//if (!(typeDescriptionProvider is FieldsToPropertiesTypeDescriptionProvider))
				//{
				//  var entityFieldsTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(type);
				//  TypeDescriptor.AddProvider(entityFieldsTypeDescriptionProvider, type);
				//}
      	gridDataEditor.BindEnumerable(enumerable, pageSize);
        frmDataEditor.ShowDialog();
      }
      return enumerable;
    }

    #endregion

    #region LinqtoSQL

    public static IEnumerable<T> EditInDataGridView<T>(this Table<T> table) where T : class
    {
      return EditInDataGridView(table, DefaultPageSize);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this Table<T> table, ushort pageSize) where T : class
    {
      return EditInDataGridView(table, table.Context, pageSize);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IQueryable<T> dataQuery, DataContext dataContext) where T : class
    {
      return EditInDataGridView(dataQuery, dataContext, DefaultPageSize);
    }

    /// <summary>
    /// Edits the DataQuery in a DataGridView.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="dataQuery">The data query (System.Data.Linq.DataQuery`1).</param>
    /// <param name="dataContext">The data context.</param>
    /// <param name="pageSize">Size of the page.</param>
    /// <returns></returns>
    public static IEnumerable<T> EditInDataGridView<T>(this IQueryable<T> dataQuery, DataContext dataContext, ushort pageSize) where T : class
    {
      return EditInDataGridView(dataQuery, new GridDataEditorLinqtoSQLPersister(dataContext), pageSize);
    }

    public class GridDataEditorLinqtoSQLPersister : IGridDataEditorPersister
    {
      private readonly DataContext _dataContext;

      public GridDataEditorLinqtoSQLPersister(DataContext dataContext)
      {
        _dataContext = dataContext;
      }

      public int Save(object dataToSave)
      {
      	var changeSet = _dataContext.GetChangeSet();
      	_dataContext.SubmitChanges();
				return changeSet.Inserts.Count + changeSet.Updates.Count;
      }

      public int Delete(object dataToSave)
      {
        _dataContext.SubmitChanges();
				return _dataContext.GetChangeSet().Deletes.Count;
      }

      public bool CanSave(Type typeToSave)
      {
        return true;
      }
    }

    #endregion

    public static void CopyEntireDataGridViewToClipboard(this DataGridView dataGridView)
    {
      dataGridView.SelectAll();
      Clipboard.SetDataObject(dataGridView.GetClipboardContent());
    }
  }
}