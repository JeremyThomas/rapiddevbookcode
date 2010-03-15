using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AW.Winforms.Helpers.Controls;

namespace AW.Winforms.Helpers.DataEditor
{
  public static class DataEditorExtensions
  {
    #region DataGridView

    public static IQueryable ViewInDataGridView(this IQueryable enumerable)
    {
      return ViewInDataGridView(enumerable, 0) as IQueryable;
    }

    public static IEnumerable ViewInDataGridView(this IQueryable enumerable, ushort pageSize)
    {
      return EditInDataGridView(enumerable, null, null, pageSize);
    }

    public static IEnumerable EditInDataGridView(this IEnumerable enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction)
    {
      return EditInDataGridView(enumerable, saveFunction, deleteFunction, 0);
    }

    public static IEnumerable EditInDataGridView(this IEnumerable enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction, ushort pageSize, params Type[] saveableTypes)
    {
      if (enumerable != null)
      {
        var dataGridView = new FrmDataEditor {Text = enumerable.ToString()};
        var gridDataEditor = new GridDataEditor {Dock = DockStyle.Fill};
        dataGridView.Controls.Add(gridDataEditor);
        if (saveFunction != null)
          gridDataEditor.SaveFunction += saveFunction;
        if (deleteFunction != null)
          gridDataEditor.DeleteFunction += deleteFunction;
        gridDataEditor.BindEnumerable(enumerable, pageSize);
        dataGridView.ShowDialog();
      }
      return enumerable;
    }

    #endregion

    #region DataGridViewGeneric

    public static IQueryable<T> ViewInDataGridView<T>(this IQueryable<T> enumerable)
    {
      return EditInDataGridView(enumerable, null).AsQueryable();
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction)
    {
      return EditInDataGridView(enumerable, saveFunction, null);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction)
    {
      return EditInDataGridView(enumerable, saveFunction, deleteFunction, 0);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction, ushort pageSize)
    {
      if (enumerable != null)
      {
        var frmDataEditor = new FrmDataEditor {Text = enumerable.ToString()};
        var gridDataEditor = new GridDataEditorT<T> {Dock = DockStyle.Fill};
        frmDataEditor.Controls.Add(gridDataEditor);
        if (saveFunction != null)
          gridDataEditor.SaveFunction += saveFunction;
        if (deleteFunction != null)
          gridDataEditor.DeleteFunction += deleteFunction;
        gridDataEditor.BindEnumerable(enumerable, pageSize);
        frmDataEditor.ShowDialog();
      }
      return enumerable;
    }

    #endregion

    public static void CopyEntireDataGridViewToClipboard(this DataGridView dataGridView)
    {
      dataGridView.SelectAll();
      Clipboard.SetDataObject(dataGridView.GetClipboardContent());
    }
  }
}