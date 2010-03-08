using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.DataEditor;
using DynamicTable;
using JesseJohnston;

namespace AW.Winforms.Helpers.Controls
{
  public partial class GridDataEditor : UserControl
  {
    public Type[] SaveableTypes;
    public event Func<object, int> SaveFunction;
    public event Func<object, int> DeleteFunction;
    private readonly ArrayList _deleteItems = new ArrayList();
    private bool _canSave;

    public GridDataEditor()
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
      toolStripLabelSaveResult.Text = @"numSaved: " + numSaved;
      if (DeleteFunction != null && _deleteItems != null)
      {
        var numDeleted = DeleteFunction(_deleteItems);
        toolStripLabelSaveResult.Text += @" numDeleted: " + numDeleted;
        if (_deleteItems.Count == numDeleted)
        {
          _deleteItems.Clear();
          toolStripLabelDeleteCount.Text = "";
          saveToolStripButton.Enabled = false;
        }
      }
      else
        saveToolStripButton.Enabled = numSaved == 0;
      toolStripButtonCancelEdit.Enabled = false; 
    }

    private void dataGridViewEnumerable_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
    }

    private void bindingSourceEnumerable_DataSourceChanged(object sender, EventArgs e)
    {
      if (bindingSourceEnumerable.Count > 0)
      {
        _canSave = CanSaveEnumerable();
        copyToolStripButton.Enabled = true;
        printToolStripButton.Enabled = true;
      }

      else
        saveToolStripButton.Enabled = false;
      toolStripLabelSaveResult.Text = "";
    }

    public bool BindEnumerable(IEnumerable enumerable)
    {
      var iSEnumerable = bindingSourceEnumerable.BindEnumerable(enumerable, EnumerableShouldBeReadonly(enumerable, null));
      SetRemovingItem();
      return iSEnumerable;
    }

    private bool EnumerableShouldBeReadonly(IEnumerable enumerable, Type typeToEdit)
    {
      var queryable = enumerable as IQueryable;
      var shouldBeReadonly = queryable != null;
      if (shouldBeReadonly)
      {
        if (typeToEdit == null)
          typeToEdit = queryable.ElementType;
        shouldBeReadonly = !CanSave(typeToEdit);
      }
      return shouldBeReadonly;
    }

    public bool BindEnumerable<T>(IEnumerable<T> enumerable)
    {
      var iSEnumerable = bindingSourceEnumerable.BindEnumerable(enumerable, EnumerableShouldBeReadonly(enumerable, typeof (T)));
      if (bindingSourceEnumerable.DataSource is ObjectListView<T>)
        ((ObjectListView<T>) bindingSourceEnumerable.DataSource).RemovingItem += GridDataEditor_RemovingItem;
      else
        SetRemovingItem();
      return iSEnumerable;
    }

    private void SetRemovingItem()
    {
      if (bindingSourceEnumerable.DataSource is ObjectListView)
        ((ObjectListView) bindingSourceEnumerable.DataSource).RemovingItem += GridDataEditor_RemovingItem;
    }

    private void GridDataEditor_RemovingItem(object sender, RemovingItemEventArgs e)
    {
      _deleteItems.Add(bindingSourceEnumerable[e.Index]);
      toolStripLabelDeleteCount.Text = @"Num removed=" + _deleteItems.Count;
    }

    private bool CanSave()
    {
      return SaveFunction != null;
    }

    private bool CanSave(Type typeToEdit)
    {
      return CanSave() && (SaveableTypes == null || typeToEdit.IsAssignableTo(SaveableTypes));
    }

    private bool CanSaveEnumerable()
    {
      return CanSave(ListBindingHelper.GetListItemType(bindingSourceEnumerable.List));
    }

    private void bindingSourceEnumerable_BindingComplete(object sender, BindingCompleteEventArgs e)
    {
      bindingSourceEnumerable_DataSourceChanged(sender, e);
    }

    private void bindingSourceEnumerable_ListChanged(object sender, ListChangedEventArgs e)
    {
      toolStripLabelSaveResult.Text = "";
      switch (e.ListChangedType)
      {
        case ListChangedType.ItemDeleted:
        case ListChangedType.ItemChanged:
        case ListChangedType.ItemAdded:
          saveToolStripButton.Enabled = _canSave;
          toolStripButtonCancelEdit.Enabled = true;          
          break;
      }
    }

    private void toolStripButtonCancelEdit_Click(object sender, EventArgs e)
    {
      bindingSourceEnumerable.CancelEdit();
      toolStripButtonCancelEdit.Enabled = false; 
    }

    private void bindingSourceEnumerable_PositionChanged(object sender, EventArgs e)
    {
      toolStripButtonCancelEdit.Enabled = false; 
    }
  }
}