using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.Properties;
using DynamicTable;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.EntityViewer
{
  public partial class FrmEntityViewer : Form
  {
    private readonly Type[] _saveableTypes;
    public event Func<object, int> SaveFunction;
    private static TypeDescriptionProvider _commonEntityBaseTypeDescriptionProvider;
    private static TypeDescriptionProvider _entityFieldsTypeDescriptionProvider;
    private bool _doingObjectBrowserNodeSelection;

    public FrmEntityViewer()
    {
      InitializeComponent();
      dataGridViewEnumerable.AutoGenerateColumns = true;
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.EntityViewerSizeLocation);
      if (_commonEntityBaseTypeDescriptionProvider == null)
        _commonEntityBaseTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof (object));
      //  TypeDescriptor.AddProvider(_commonEntityBaseTypeDescriptionProvider, typeof (object));

      if (_entityFieldsTypeDescriptionProvider == null)
        _entityFieldsTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof (EntityFields));
      // TypeDescriptor.AddProvider(_entityFieldsTypeDescriptionProvider, typeof(EntityFields));
    }

    public FrmEntityViewer(object entity) : this()
    {
      if (entity == null) throw new ArgumentNullException("entity");
      ObjectBrowser.ObjectToBrowse = entity;
    }

    public FrmEntityViewer(object entity, Func<object, int> saveFunction, params Type[] saveableTypes)
      : this(entity)
    {
      _saveableTypes = saveableTypes;
      SaveFunction += saveFunction;
    }

    public static Form LaunchAsChildForm(object entity)
    {
      var frm = new FrmEntityViewer(entity);
      AWHelper.ShowChildForm(frm);
      return frm;
    }

    public static Form LaunchAsChildForm(object entity, Func<object, int> saveFunction, params Type[] saveableTypes)
    {
      var frm = new FrmEntityViewer(entity, saveFunction, saveableTypes);
      AWHelper.ShowChildForm(frm);
      return frm;
    }

    private void FrmEntityViewer_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.EntityViewerSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
      Settings.Default.EntityFieldColumns = AWHelper.SaveColumnState(dataGridViewEnumerable);
      Settings.Default.Save();
    }

    private void FrmEntityViewer_Load(object sender, EventArgs e)
    {
      //((TreeView) (ObjectBrowser.ActiveControl)).SelectedNode = ((TreeView) (ObjectBrowser.ActiveControl)).TopNode;
      //    propertyGrid1.SelectedObject = ObjectBeingBrowsed;
      //  propertyGrid1.RefreshSelectedObject();
      splitContainerValues.Panel2Collapsed = true;
      _doingObjectBrowserNodeSelection = true;
      try
      {
        propertyGrid1.SelectedObject = ObjectBeingBrowsed;
      }
      finally
      {
        _doingObjectBrowserNodeSelection = false;
      }
      AWHelper.RestoreColumnsState(Settings.Default.EntityFieldColumns, dataGridViewEnumerable);
      var dataGridViewScriptClipboardCopyMode = dataGridViewEnumerable.ClipboardCopyMode;
      if (toolStripComboBoxClipboardCopyMode.ComboBox != null) toolStripComboBoxClipboardCopyMode.ComboBox.DataSource = Enum.GetValues(typeof (DataGridViewClipboardCopyMode));
      toolStripComboBoxClipboardCopyMode.SelectedItem = dataGridViewScriptClipboardCopyMode;
      toolStripStatusLabelInstance.Text = string.Format("(({0})((FrmEntityViewer)Application.OpenForms[{1}]).ObjectBeingBrowsed)", ObjectBeingBrowsed.GetType(), AWHelper.GetIndexOfForm(this));
      textBoxObjectBeingBrowsed.Text = toolStripStatusLabelInstance.Text;

      //checkBoxShowStaticMembers.Checked = ObjectBrowser.ShowStaticMembers;
      //checkBoxShowNonPublicMembers.Checked = ObjectBrowser.ShowNonPublicMembers;
      //checkBoxShowDataTypes.Checked = ObjectBrowser.ShowDataTypes;
      checkBoxShowStaticMembers_CheckedChanged(this, e);
      checkBoxShowNonPublicMembers_CheckedChanged(this, e);
      checkBoxShowDataTypes_CheckedChanged(this, e);
    }

    private void propertyGrid1_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
    {
      var x = e.NewSelection;
      var t = x.PropertyDescriptor;
      if (!_doingObjectBrowserNodeSelection && e.NewSelection.Value != null && !(e.OldSelection == null && bindingSourceEnumerable.DataSource == propertyGrid1.SelectedObject))
        if (!ShowEnumerable(e.NewSelection.Value as IEnumerable))
          if (!e.NewSelection.PropertyDescriptor.PropertyType.IsValueType)
            bindingSourceEnumerable.DataSource = e.NewSelection.Value;
    }

    private void ObjectBrowser_NodeSelected(object sender, EventArgs e)
    {
      _doingObjectBrowserNodeSelection = true;
      try
      {
        toolStripStatusLabelSelectePath.Text = (((TreeView) (ObjectBrowser.ActiveControl)).SelectedNode).FullPath;
        propertyGrid1.SelectedObject = sender;
        if (!ShowEnumerable(sender as IEnumerable))
          bindingSourceEnumerable.DataSource = null;
      }
      finally
      {
        _doingObjectBrowserNodeSelection = false;
      }
    }

    private bool ShowEnumerable(IEnumerable enumerable)
    {
      var iSEnumerable = AWHelper.BindEnumerable(enumerable, bindingSourceEnumerable);
      splitContainerValues.Panel2Collapsed = !iSEnumerable;
      if (iSEnumerable)
        saveToolStripButton.Enabled = CanEditEnumerable();
      else
        saveToolStripButton.Enabled = false;
      EnableEnumerableEditing();
      return iSEnumerable;
    }

    private void EnableEnumerableEditing()
    {
      saveToolStripButton.Enabled = CanEditEnumerable();
      bindingSourceEnumerable.AllowNew = saveToolStripButton.Enabled;
      dataGridViewEnumerable.ReadOnly = !saveToolStripButton.Enabled;
      bindingNavigatorDeleteItem1.Enabled = saveToolStripButton.Enabled;
    }

    private void selectObjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (propertyGrid1.SelectedGridItem.Expandable)
        propertyGrid1.SelectedObject = propertyGrid1.SelectedGridItem.Value;
    }

    public object ObjectBeingBrowsed
    {
      get { return ObjectBrowser.ObjectToBrowse; }
    }

    private void copyToolStripButton_Click(object sender, EventArgs e)
    {
      AWHelper.CopyEntireDataGridViewToClipboard(dataGridViewEnumerable);
    }

    private void printToolStripButton_Click(object sender, EventArgs e)
    {
      var frm = new FrmReportViewer {MdiParent = MdiParent, WindowState = FormWindowState.Normal};
      frm.OpenDataSet(bindingSourceEnumerable, false);
      frm.Show();
    }

    private void toolStripComboBoxClipboardCopyMode_SelectedIndexChanged(object sender, EventArgs e)
    {
      dataGridViewEnumerable.ClipboardCopyMode = (DataGridViewClipboardCopyMode) toolStripComboBoxClipboardCopyMode.SelectedItem;
    }

    private void copyObjectRefToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(toolStripStatusLabelInstance.Text);
    }

    private void checkBoxShowStaticMembers_CheckedChanged(object sender, EventArgs e)
    {
      ObjectBrowser.ShowStaticMembers = checkBoxShowStaticMembers.Checked;
    }

    private void checkBoxShowNonPublicMembers_CheckedChanged(object sender, EventArgs e)
    {
      ObjectBrowser.ShowNonPublicMembers = checkBoxShowNonPublicMembers.Checked;
    }

    private void checkBoxShowDataTypes_CheckedChanged(object sender, EventArgs e)
    {
      ObjectBrowser.ShowDataTypes = checkBoxShowDataTypes.Checked;
    }

    private void dataGridViewEnumerable_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
    }

    private void saveToolStripButton_Click(object sender, EventArgs e)
    {
      var ds = bindingSourceEnumerable.List;
      if (ds != null)
      {
        var f = ListBindingHelper.GetListItemType(ds);
        if (_saveableTypes != null && _saveableTypes.Contains(f))
          return;
        //ds.
        //var x = ds.ElementType;
        //var d = new EntityCollectionNonGeneric();
        //d.AddRange(ds.Cast<EntityBase2>());
        if (CanSave())
        {
          var numSaved = SaveFunction(ds);
          MessageBox.Show("numSaved"+numSaved);
        }
      }
    }

    private bool CanSave()
    {
      return SaveFunction != null;
    }

    private bool CanEdit(Type typeToEdit)
    {
      return CanSave() && (_saveableTypes == null || typeToEdit.IsAssignableTo(_saveableTypes));
    }

    private bool CanEditEnumerable()
    {
      return CanEdit(ListBindingHelper.GetListItemType(bindingSourceEnumerable.List));
    }

    private object GetDataSource()
    {
      return AWHelper.GetDataSource(bindingSourceEnumerable);
    }
  }
}