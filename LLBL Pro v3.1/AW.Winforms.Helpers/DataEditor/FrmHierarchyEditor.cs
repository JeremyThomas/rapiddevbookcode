using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.Properties;

namespace AW.Winforms.Helpers.DataEditor
{
	public partial class FrmHierarchyEditor : FrmThreePanelBase
	{
		public FrmHierarchyEditor()
		{
			InitializeComponent();
			AWHelper.SetWindowSizeAndLocation(this, Settings.Default.HierarchyEditorSizeLocation);
		}

		public FrmHierarchyEditor(IEnumerable hierarchicalData, string iDPropertyName, string parentIDPropertyName, string nameColumn)
			: this()
		{
			if (hierarchicalData == null) throw new ArgumentNullException("hierarchicalData");
			bindingSourceHierarchicalData.BindEnumerable(hierarchicalData, false);
			bindingNavigatorDeleteItem.Enabled = bindingSourceHierarchicalData.AllowRemove;
			dataTreeView.IDColumn = iDPropertyName;
			dataTreeView.ParentIDColumn = parentIDPropertyName;
			dataTreeView.NameColumn = nameColumn;
		}

		public FrmHierarchyEditor(IEnumerable hierarchicalData, string iDPropertyName, string parentIDPropertyName, string nameColumn, IDataEditorPersister dataEditorPersister)
			: this(hierarchicalData, iDPropertyName, parentIDPropertyName, nameColumn)
		{
			gridDataEditor.DataEditorPersister = dataEditorPersister;
			saveToolStripButton.Enabled = gridDataEditor.DataEditorPersister != null;
			toolStripButtonCancelEdit.Enabled = saveToolStripButton.Enabled;
		}

		public static Form LaunchForm(IEnumerable hierarchicalData, string iDPropertyName, string parentIDPropertyName, string nameColumn, IDataEditorPersister dataEditorPersister)
		{
			var frm = new FrmHierarchyEditor(hierarchicalData, iDPropertyName, parentIDPropertyName, nameColumn, dataEditorPersister) {Text = hierarchicalData.ToString()};
			AWHelper.ShowForm(frm);
			return frm;
		}

		private void dataTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			toolStripStatusLabelSelectePath.Text = ((dataTreeView).SelectedNode).FullPath;
			propertyGrid1.SelectedObject = e.Node.Tag;
			splitContainerHorizontal.Panel2Collapsed = e.Node.Nodes.Count == 0;
			if (splitContainerHorizontal.Panel2Collapsed)
				gridDataEditor.DataSource = null;
			else
				gridDataEditor.BindEnumerable(e.Node.Nodes.Cast<TreeNode>().Select(tn => tn.Tag).ToList());
		}

		private void FrmHierarchyEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.HierarchyEditorSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
			Settings.Default.Save();
		}

		private void toolStripButtonExpandAll_Click(object sender, EventArgs e)
		{
			dataTreeView.ExpandAll();
		}

		private void toolStripButtonCollapseAll_Click(object sender, EventArgs e)
		{
			dataTreeView.CollapseAll();
		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{
			if (gridDataEditor.DataEditorPersister != null)
				gridDataEditor.DataEditorPersister.Save(bindingSourceHierarchicalData.DataSource);
		}

		private void toolStripButtonCancelEdit_Click(object sender, EventArgs e)
		{
			bindingSourceHierarchicalData.CancelEdit();
			if (gridDataEditor.DataEditorPersister != null && gridDataEditor.DataEditorPersister.Undo(bindingSourceHierarchicalData.List))
			{
				bindingSourceHierarchicalData.ResetBindings(false);
				//saveToolStripButton.Enabled = false;
			}
			//toolStripButtonCancelEdit.Enabled = false;
		}

	}
}