using System.Collections;
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

    public static Form CreateDataViewForm(IEnumerable enumerable, params ToolStripItem[] toolStripItems)
    {
      return InitialiseDataViewerForm(new FrmDataEditor(), enumerable, false, toolStripItems);
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
      var gridDataEditor = new GridDataEditor(enumerable, true, DataEditorPersisterFactory.Create(enumerable, dataEditorPersister), pageSize, readOnly) {Dock = DockStyle.Fill};
      frmDataEditor.Controls.Add(gridDataEditor);
      return frmDataEditor;
    }

    private static Form InitialiseDataViewerForm(Form frmDataEditor, IEnumerable enumerable, bool allowPaging = false, params ToolStripItem[] toolStripItems)
    {
      frmDataEditor.Text = GetEnumerableDescription(enumerable);
      var gridDataEditor = new GridDataEditor(enumerable, true, null, 0)
      {
        Dock = DockStyle.Fill,
        bindingNavigatorPaging = {Visible = allowPaging}
      };
      gridDataEditor.bindingNavigatorData.Items.AddRange(toolStripItems);
      frmDataEditor.Controls.Add(gridDataEditor);
      return frmDataEditor;
    }

    /// <summary>
    ///   Edits the enumerable in a DataGridView.
    /// </summary>
    /// <param name="enumerable"> The enumerable. </param>
    /// <param name="dataEditorPersister"> The grid data editor persister. </param>
    /// <param name="pageSize"> Size of the page. </param>
    /// <returns> </returns>
    public static IEnumerable ShowInGrid(IEnumerable enumerable, IDataEditorPersister dataEditorPersister = null, ushort pageSize = GridDataEditor.DefaultPageSize)
    {
      if (enumerable != null)
        CreateDataEditorForm(enumerable, dataEditorPersister, pageSize).ShowDialog();
      return enumerable;
    }
  }
}