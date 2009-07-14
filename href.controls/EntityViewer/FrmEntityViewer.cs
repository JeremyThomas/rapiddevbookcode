using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using AW.Winforms.Helpers.Properties;
using DynamicTable;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.EntityViewer
{
  public partial class FrmEntityViewer : Form
  {
    private static TypeDescriptionProvider CommonEntityBaseTypeDescriptionProvider;
    private static TypeDescriptionProvider EntityFieldsTypeDescriptionProvider; //
    private bool DoingObjectBrowserNodeSelection;

    public FrmEntityViewer()
    {
      InitializeComponent();
      dataGridViewEnumerable.AutoGenerateColumns = true;
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.EntityViewerSizeLocation);
      if (CommonEntityBaseTypeDescriptionProvider == null)
        CommonEntityBaseTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof (object));
      //  TypeDescriptor.AddProvider(CommonEntityBaseTypeDescriptionProvider, typeof (object));

      if (EntityFieldsTypeDescriptionProvider == null)
        EntityFieldsTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof (EntityFields));
      // TypeDescriptor.AddProvider(EntityFieldsTypeDescriptionProvider, typeof(EntityFields));
    }

    public FrmEntityViewer(object entity) : this()
    {
      if (entity == null) throw new ArgumentNullException("entity");
      ObjectBrowser.ObjectToBrowse = entity;
    }

    public static Form LaunchAsChildForm(object entity)
    {
      var frm = new FrmEntityViewer(entity);
      AWHelper.ShowChildForm(frm);
      return frm;
    }

    private void FrmEntityViewer_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.EntityViewerSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
      Settings.Default.EntityFieldColumns = AWHelper.SaveColumnState(dataGridViewEnumerable);
    }

    private void FrmEntityViewer_Load(object sender, EventArgs e)
    {
      //((TreeView) (ObjectBrowser.ActiveControl)).SelectedNode = ((TreeView) (ObjectBrowser.ActiveControl)).TopNode;
      //    propertyGrid1.SelectedObject = ObjectBeingBrowsed;
      //  propertyGrid1.RefreshSelectedObject();
      splitContainerValues.Panel2Collapsed = true;
      DoingObjectBrowserNodeSelection = true;
      try
      {
        propertyGrid1.SelectedObject = ObjectBeingBrowsed;
      }
      finally
      {
        DoingObjectBrowserNodeSelection = false;
      }
      AWHelper.RestoreColumnsState(Settings.Default.EntityFieldColumns, dataGridViewEnumerable);
      var dataGridViewScriptClipboardCopyMode = dataGridViewEnumerable.ClipboardCopyMode;
      toolStripComboBoxClipboardCopyMode.ComboBox.DataSource = Enum.GetValues(typeof (DataGridViewClipboardCopyMode));
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
      if (!DoingObjectBrowserNodeSelection && e.NewSelection.Value != null && !(e.OldSelection == null && bindingSourceEnumerable.DataSource == propertyGrid1.SelectedObject))
        if (!ShowEnumerable(e.NewSelection.Value as IEnumerable))
          if (!e.NewSelection.PropertyDescriptor.PropertyType.IsValueType)
            bindingSourceEnumerable.DataSource = e.NewSelection.Value;
    }

    private void ObjectBrowser_NodeSelected(object sender, EventArgs e)
    {
      DoingObjectBrowserNodeSelection = true;
      try
      {
        toolStripStatusLabelSelectePath.Text = (((TreeView) (ObjectBrowser.ActiveControl)).SelectedNode).FullPath;
        propertyGrid1.SelectedObject = sender;
        if (!ShowEnumerable(sender as IEnumerable))
          bindingSourceEnumerable.DataSource = null;
      }
      finally
      {
        DoingObjectBrowserNodeSelection = false;
      }
    }

    private bool ShowEnumerable(IEnumerable enumerable)
    {
      var iSEnumerable = AWHelper.BindEnumerable(enumerable, bindingSourceEnumerable);
      splitContainerValues.Panel2Collapsed = !iSEnumerable;
      return iSEnumerable;
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
  }
}