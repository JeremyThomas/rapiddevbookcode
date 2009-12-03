using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.DataEditor;
using DynamicTable;

namespace AW.Winforms.Helpers.Controls
{
  public partial class GridDataEditorT<T> : UserControl
  {
    public Type[] SaveableTypes;
    public event Func<object, int> SaveFunction;

    public GridDataEditorT()
    {
      InitializeComponent();
      dataGridViewEnumerable.AutoGenerateColumns = true;
    }

    #region Properties

    [AttributeProvider(typeof (IListSource)),
     Category("Data"),
     Description("Data source of the tree.")]
    public object DataSource
    {
      get { return bindingSourceEnumerable.DataSource; }
      set
      {
        if (bindingSourceEnumerable.DataSource != value)
          bindingSourceEnumerable.DataSource = value;
      }
    }

    [Editor("System.Windows.Forms.Design.DataMemberListEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor)),
     RefreshProperties(RefreshProperties.Repaint),
     Category("Data"),
     Description("Data member of the tree.")]
    public string DataMember
    {
      get { return bindingSourceEnumerable.DataMember; }
      set
      {
        if (bindingSourceEnumerable.DataMember != value)
          bindingSourceEnumerable.DataMember = value;
      }
    }

    [Description("ToolStripItemsDescr"), MergableProperty(false), Category("CatData"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public ToolStripItemCollection Items
    {
      get { return BindingNavigator.Items; }
    }

    public BindingNavigator BindingNavigator
    {
      get { return bindingNavigator1; }
    }

    public BindingSource BindingSource
    {
      get { return bindingSourceEnumerable; }
    }

    #endregion

    private void printToolStripButton_Click(object sender, EventArgs e)
    {
      var frm = new FrmReportViewer {WindowState = FormWindowState.Normal};
      frm.OpenDataSet(bindingSourceEnumerable, false);
      frm.Show();
    }

    private void copyToolStripButton_Click(object sender, EventArgs e)
    {
      dataGridViewEnumerable.CopyEntireDataGridViewToClipboard();
    }

    private void toolStripComboBoxClipboardCopyMode_SelectedIndexChanged(object sender, EventArgs e)
    {
      dataGridViewEnumerable.ClipboardCopyMode = (DataGridViewClipboardCopyMode) toolStripComboBoxClipboardCopyMode.SelectedItem;
    }

    private void GridDataEditor_Load(object sender, EventArgs e)
    {
      var dataGridViewScriptClipboardCopyMode = dataGridViewEnumerable.ClipboardCopyMode;
      if (toolStripComboBoxClipboardCopyMode.ComboBox != null) toolStripComboBoxClipboardCopyMode.ComboBox.DataSource = Enum.GetValues(typeof (DataGridViewClipboardCopyMode));
      toolStripComboBoxClipboardCopyMode.SelectedItem = dataGridViewScriptClipboardCopyMode;
    }

    private void saveToolStripButton_Click(object sender, EventArgs e)
    {
      var numSaved = SaveFunction(bindingSourceEnumerable.List);
      MessageBox.Show("numSaved" + numSaved);
    }

    private void dataGridViewEnumerable_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
    }

    private void bindingSourceEnumerable_DataSourceChanged(object sender, EventArgs e)
    {
      if (bindingSourceEnumerable.Count > 0)
      {
        saveToolStripButton.Enabled = CanSaveEnumerable();
        copyToolStripButton.Enabled = true;
        printToolStripButton.Enabled = true;
      }

      else
        saveToolStripButton.Enabled = false;
      EnableEnumerableEditing();
    }

    private bool CanSave()
    {
      return SaveFunction != null;
    }

    public bool CanSave(Type typeToEdit)
    {
      return CanSave() && (SaveableTypes == null || typeToEdit.IsAssignableTo(SaveableTypes));
    }

    private bool CanSaveEnumerable()
    {
      return CanSave(ListBindingHelper.GetListItemType(bindingSourceEnumerable.List));
    }

    private void EnableEnumerableEditing()
    {
      saveToolStripButton.Enabled = CanSaveEnumerable();
      bindingSourceEnumerable.AllowNew = bindingSourceEnumerable.AllowEdit;
    }

    private void bindingSourceEnumerable_BindingComplete(object sender, BindingCompleteEventArgs e)
    {
      bindingSourceEnumerable_DataSourceChanged(sender, e);
    }
  }
}