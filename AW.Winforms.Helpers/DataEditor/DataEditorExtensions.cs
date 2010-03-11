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
    public static IEnumerable ViewInDataGridViewx(this IQueryable enumerable)
    {
      return EditInDataGridViewx(enumerable, null, null);
    }

    public static IEnumerable EditInDataGridViewx(this IEnumerable enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction, params Type[] saveableTypes)
    {
      var dataGridView = new FrmDataEditor {Text = enumerable.ToString()};
      var gridDataEditor = new GridDataEditor {Dock = DockStyle.Fill};
      dataGridView.Controls.Add(gridDataEditor);
      if (saveFunction != null)
        gridDataEditor.SaveFunction += saveFunction;
      if (deleteFunction != null)
        gridDataEditor.DeleteFunction += deleteFunction;
      gridDataEditor.BindEnumerable(enumerable);
      // AWHelper.BindEnumerable(enumerable,gridDataEditor.BindingSource);
      dataGridView.ShowDialog();
      return enumerable;
    }

    public static IEnumerable<T> ViewInDataGridView<T>(this IQueryable<T> enumerable)
    {
      return EditInDataGridView(enumerable, null);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction)
    {
      return EditInDataGridView(enumerable, saveFunction, null);
    }

    public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction)
    {
      if (enumerable != null)
      {
        var frmDataEditor = new FrmDataEditor {Text = enumerable.ToString()};
        var gridDataEditor = new GridDataEditor {Dock = DockStyle.Fill};
        frmDataEditor.Controls.Add(gridDataEditor);
        if (saveFunction != null)
          gridDataEditor.SaveFunction += saveFunction;
        if (deleteFunction != null)
          gridDataEditor.DeleteFunction += deleteFunction;
        gridDataEditor.BindEnumerable(enumerable);
        frmDataEditor.ShowDialog();
      }
      return enumerable;
    }

    public static void CopyEntireDataGridViewToClipboard(this DataGridView dataGridView)
    {
      dataGridView.SelectAll();
      Clipboard.SetDataObject(dataGridView.GetClipboardContent());
    }
  }
}