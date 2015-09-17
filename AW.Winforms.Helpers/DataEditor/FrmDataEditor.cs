using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AW.Winforms.Helpers.Controls;
using JesseJohnston;

namespace AW.Winforms.Helpers.DataEditor
{
  public partial class FrmDataEditor : FrmPersistantLocation
  {
// ReSharper disable once MemberCanBePrivate.Global
    public FrmDataEditor()
    {
      InitializeComponent();
    }

    private static string GetEnumerableDescription(IEnumerable enumerable)
    {
      string text;
      var dataView = enumerable as DataView;
      if (dataView != null)
        text = dataView.Table.TableName + " via a DataView";
      else
      {
        var objectListView = enumerable as ObjectListView;
        if (objectListView != null)
          text = objectListView.List + " via a ObjectListView";
        else
          text = enumerable.ToString();
      }
      return text;
    }

    public static Form CreateDataViewForm(IEnumerable enumerable)
    {
      return CreateDataEditorForm(enumerable, null, GridDataEditor.DefaultPageSize, true);
    }

    public static Form CreateDataEditorForm(IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize)
    {
      return CreateDataEditorForm(enumerable, dataEditorPersister, pageSize, false);
    }

// ReSharper disable once MemberCanBePrivate.Global
    public static Form CreateDataEditorForm(IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
    {
      return InitialiseDataEditorForm(new FrmDataEditor(), enumerable, dataEditorPersister, pageSize, readOnly);
    }

    private static Form InitialiseDataEditorForm(Form frmDataEditor, IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
    {
      frmDataEditor.Text = GetEnumerableDescription(enumerable);
      var gridDataEditor = new GridDataEditor(enumerable, dataEditorPersister, pageSize, readOnly) {Dock = DockStyle.Fill};
      frmDataEditor.Controls.Add(gridDataEditor);
      return frmDataEditor;
    }

    public static Form CreateDataEditorForm<T>(IEnumerable<T> enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
    {
      return InitialiseDataEditorForm(new FrmDataEditor(), enumerable, dataEditorPersister, pageSize, readOnly);
    }

    private static Form InitialiseDataEditorForm<T>(Form frmDataEditor, IEnumerable<T> enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
    {
      frmDataEditor.Text = GetEnumerableDescription(enumerable);
      var gridDataEditor = GridDataEditorT<T>.GridDataEditorFactory(enumerable, dataEditorPersister, pageSize, readOnly);
      gridDataEditor.Dock = DockStyle.Fill;
      frmDataEditor.Controls.Add(gridDataEditor);
      return frmDataEditor;
    }
  }
}