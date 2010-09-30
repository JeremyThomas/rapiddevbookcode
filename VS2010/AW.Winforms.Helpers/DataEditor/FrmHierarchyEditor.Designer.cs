namespace AW.Winforms.Helpers.DataEditor
{
	partial class FrmHierarchyEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHierarchyEditor));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.bindingSourceHierarchicalData = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorHierarchicalData = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonExpandAll = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonCollapseAll = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.splitContainerNode = new System.Windows.Forms.SplitContainer();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelSelectePath = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataTreeView = new Chaliy.Windows.Forms.DataTreeView();
			this.gridDataEditor = new AW.Winforms.Helpers.Controls.GridDataEditor();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceHierarchicalData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHierarchicalData)).BeginInit();
			this.bindingNavigatorHierarchicalData.SuspendLayout();
			this.splitContainerNode.Panel1.SuspendLayout();
			this.splitContainerNode.Panel2.SuspendLayout();
			this.splitContainerNode.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dataTreeView);
			this.splitContainer1.Panel1.Controls.Add(this.bindingNavigatorHierarchicalData);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainerNode);
			this.splitContainer1.Size = new System.Drawing.Size(895, 584);
			this.splitContainer1.SplitterDistance = 482;
			this.splitContainer1.TabIndex = 0;
			// 
			// bindingSourceHierarchicalData
			// 
			this.bindingSourceHierarchicalData.AllowNew = false;
			// 
			// bindingNavigatorHierarchicalData
			// 
			this.bindingNavigatorHierarchicalData.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigatorHierarchicalData.BindingSource = this.bindingSourceHierarchicalData;
			this.bindingNavigatorHierarchicalData.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigatorHierarchicalData.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigatorHierarchicalData.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bindingNavigatorHierarchicalData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButtonExpandAll,
            this.toolStripButtonCollapseAll,
            this.toolStripSeparator,
            this.toolStripSeparator2});
			this.bindingNavigatorHierarchicalData.Location = new System.Drawing.Point(0, 559);
			this.bindingNavigatorHierarchicalData.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigatorHierarchicalData.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigatorHierarchicalData.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigatorHierarchicalData.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigatorHierarchicalData.Name = "bindingNavigatorHierarchicalData";
			this.bindingNavigatorHierarchicalData.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigatorHierarchicalData.Size = new System.Drawing.Size(482, 25);
			this.bindingNavigatorHierarchicalData.TabIndex = 1;
			this.bindingNavigatorHierarchicalData.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Enabled = false;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Enabled = false;
			this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
			this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.saveToolStripButton.Text = "&Save";
			this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonExpandAll
			// 
			this.toolStripButtonExpandAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExpandAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExpandAll.Image")));
			this.toolStripButtonExpandAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonExpandAll.Name = "toolStripButtonExpandAll";
			this.toolStripButtonExpandAll.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonExpandAll.Text = "toolStripButton1";
			this.toolStripButtonExpandAll.Click += new System.EventHandler(this.toolStripButtonExpandAll_Click);
			// 
			// toolStripButtonCollapseAll
			// 
			this.toolStripButtonCollapseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonCollapseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCollapseAll.Image")));
			this.toolStripButtonCollapseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCollapseAll.Name = "toolStripButtonCollapseAll";
			this.toolStripButtonCollapseAll.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonCollapseAll.Text = "toolStripButton1";
			this.toolStripButtonCollapseAll.Click += new System.EventHandler(this.toolStripButtonCollapseAll_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// splitContainerNode
			// 
			this.splitContainerNode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerNode.Location = new System.Drawing.Point(0, 0);
			this.splitContainerNode.Name = "splitContainerNode";
			this.splitContainerNode.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerNode.Panel1
			// 
			this.splitContainerNode.Panel1.Controls.Add(this.propertyGrid1);
			// 
			// splitContainerNode.Panel2
			// 
			this.splitContainerNode.Panel2.Controls.Add(this.gridDataEditor);
			this.splitContainerNode.Size = new System.Drawing.Size(409, 584);
			this.splitContainerNode.SplitterDistance = 292;
			this.splitContainerNode.TabIndex = 1;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(409, 292);
			this.propertyGrid1.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSelectePath});
			this.statusStrip1.Location = new System.Drawing.Point(0, 584);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(895, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabelSelectePath
			// 
			this.toolStripStatusLabelSelectePath.Name = "toolStripStatusLabelSelectePath";
			this.toolStripStatusLabelSelectePath.Size = new System.Drawing.Size(173, 17);
			this.toolStripStatusLabelSelectePath.Text = "toolStripStatusLabelSelectePath";
			// 
			// dataTreeView
			// 
			this.dataTreeView.AllowDrop = true;
			this.dataTreeView.DataMember = "";
			this.dataTreeView.DataSource = this.bindingSourceHierarchicalData;
			this.dataTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataTreeView.FullRowSelect = true;
			this.dataTreeView.HideSelection = false;
			this.dataTreeView.HotTracking = true;
			this.dataTreeView.IgnoreErrors = true;
			this.dataTreeView.Location = new System.Drawing.Point(0, 0);
			this.dataTreeView.Name = "dataTreeView";
			this.dataTreeView.Size = new System.Drawing.Size(482, 559);
			this.dataTreeView.TabIndex = 0;
			this.dataTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dataTreeView1_AfterSelect);
			// 
			// gridDataEditor
			// 
			this.gridDataEditor.DataMember = "";
			this.gridDataEditor.DataSource = null;
			this.gridDataEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridDataEditor.Location = new System.Drawing.Point(0, 0);
			this.gridDataEditor.Name = "gridDataEditor";
			this.gridDataEditor.PageSize = ((ushort)(0));
			this.gridDataEditor.Readonly = false;
			this.gridDataEditor.Size = new System.Drawing.Size(409, 288);
			this.gridDataEditor.TabIndex = 0;
			// 
			// FrmHierarchyEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(895, 606);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Name = "FrmHierarchyEditor";
			this.Text = "FrmHierarchyEditor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHierarchyEditor_FormClosing);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceHierarchicalData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHierarchicalData)).EndInit();
			this.bindingNavigatorHierarchicalData.ResumeLayout(false);
			this.bindingNavigatorHierarchicalData.PerformLayout();
			this.splitContainerNode.Panel1.ResumeLayout(false);
			this.splitContainerNode.Panel2.ResumeLayout(false);
			this.splitContainerNode.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private Chaliy.Windows.Forms.DataTreeView dataTreeView;
		private System.Windows.Forms.SplitContainer splitContainerNode;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private Controls.GridDataEditor gridDataEditor;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelectePath;
		private System.Windows.Forms.BindingNavigator bindingNavigatorHierarchicalData;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.BindingSource bindingSourceHierarchicalData;
		private System.Windows.Forms.ToolStripButton toolStripButtonExpandAll;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButtonCollapseAll;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

	}
}