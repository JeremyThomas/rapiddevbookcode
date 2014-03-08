namespace AW.Winforms.Helpers.LLBL
{
  partial class UsrCntrlEntityBrowser
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrCntrlEntityBrowser));
      this.treeViewEntities = new System.Windows.Forms.TreeView();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.openPaged30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.getCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabelSelected = new System.Windows.Forms.ToolStripStatusLabel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.gridDataEditor = new AW.Winforms.Helpers.Controls.GridDataEditor();
      this.bindingNavigatorPaging = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorData = new System.Windows.Forms.BindingNavigator(this.components);
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.contextMenuStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPaging)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorData)).BeginInit();
      this.SuspendLayout();
      // 
      // treeViewEntities
      // 
      this.treeViewEntities.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeViewEntities.ImageIndex = 0;
      this.treeViewEntities.ImageList = this.imageList1;
      this.treeViewEntities.Location = new System.Drawing.Point(0, 0);
      this.treeViewEntities.Name = "treeViewEntities";
      this.treeViewEntities.SelectedImageIndex = 4;
      this.treeViewEntities.ShowNodeToolTips = true;
      this.treeViewEntities.Size = new System.Drawing.Size(167, 563);
      this.treeViewEntities.TabIndex = 1;
      this.toolTip1.SetToolTip(this.treeViewEntities, "Entities amd their proerties");
      this.treeViewEntities.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewEntities_ItemDrag);
      this.treeViewEntities.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEntities_AfterSelect);
      this.treeViewEntities.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewEntities_NodeMouseClick);
      this.treeViewEntities.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewEntities_NodeMouseDoubleClick);
      this.treeViewEntities.Click += new System.EventHandler(this.treeViewEntities_Click);
      this.treeViewEntities.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewEntities_KeyDown);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "TableHS.png");
      this.imageList1.Images.SetKeyName(1, "PropertiesHS.png");
      this.imageList1.Images.SetKeyName(2, "GoRtl.bmp");
      this.imageList1.Images.SetKeyName(3, "GoLtr.bmp");
      this.imageList1.Images.SetKeyName(4, "PushpinHS.png");
      this.imageList1.Images.SetKeyName(5, "EntityDataModel_entity_container_16x16.png");
      this.imageList1.Images.SetKeyName(6, "XSDSchema_SequenceIcon.png");
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPaged30ToolStripMenuItem,
            this.toolStripMenuItemOpen,
            this.getCountToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(185, 70);
      // 
      // openPaged30ToolStripMenuItem
      // 
      this.openPaged30ToolStripMenuItem.Name = "openPaged30ToolStripMenuItem";
      this.openPaged30ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
      this.openPaged30ToolStripMenuItem.Text = "Open 30 per Page";
      this.openPaged30ToolStripMenuItem.Click += new System.EventHandler(this.openPagedToolStripMenuItem_Click);
      // 
      // toolStripMenuItemOpen
      // 
      this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
      this.toolStripMenuItemOpen.Size = new System.Drawing.Size(184, 22);
      this.toolStripMenuItemOpen.Text = "Open wthout paging";
      this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
      // 
      // getCountToolStripMenuItem
      // 
      this.getCountToolStripMenuItem.Name = "getCountToolStripMenuItem";
      this.getCountToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
      this.getCountToolStripMenuItem.Text = "Get Count";
      this.getCountToolStripMenuItem.Click += new System.EventHandler(this.getCountToolStripMenuItem_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSelected});
      this.statusStrip1.Location = new System.Drawing.Point(0, 563);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(502, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabelSelected
      // 
      this.toolStripStatusLabelSelected.Name = "toolStripStatusLabelSelected";
      this.toolStripStatusLabelSelected.Size = new System.Drawing.Size(118, 17);
      this.toolStripStatusLabelSelected.Text = "toolStripStatusLabel1";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.treeViewEntities);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.gridDataEditor);
      this.splitContainer1.Size = new System.Drawing.Size(502, 563);
      this.splitContainer1.SplitterDistance = 167;
      this.splitContainer1.TabIndex = 3;
      // 
      // gridDataEditor
      // 
      this.gridDataEditor.DataMember = "";
      this.gridDataEditor.DataSource = null;
      this.gridDataEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridDataEditor.EnsureFilteringEnabled = false;
      this.gridDataEditor.Location = new System.Drawing.Point(0, 0);
      this.gridDataEditor.Name = "gridDataEditor";
      this.gridDataEditor.PageSize = ((ushort)(0));
      this.gridDataEditor.Readonly = false;
      this.gridDataEditor.Size = new System.Drawing.Size(331, 563);
      this.gridDataEditor.TabIndex = 0;
      this.toolTip1.SetToolTip(this.gridDataEditor, "Data in the Tables");
      // 
      // bindingNavigatorPaging
      // 
      this.bindingNavigatorPaging.AddNewItem = null;
      this.bindingNavigatorPaging.CountItem = null;
      this.bindingNavigatorPaging.DeleteItem = null;
      this.bindingNavigatorPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.bindingNavigatorPaging.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPaging.Location = new System.Drawing.Point(0, 538);
      this.bindingNavigatorPaging.MoveFirstItem = null;
      this.bindingNavigatorPaging.MoveLastItem = null;
      this.bindingNavigatorPaging.MoveNextItem = null;
      this.bindingNavigatorPaging.MovePreviousItem = null;
      this.bindingNavigatorPaging.Name = "bindingNavigatorPaging";
      this.bindingNavigatorPaging.PositionItem = null;
      this.bindingNavigatorPaging.Size = new System.Drawing.Size(331, 25);
      this.bindingNavigatorPaging.TabIndex = 5;
      this.bindingNavigatorPaging.Text = "bindingNavigator2";
      // 
      // bindingNavigatorData
      // 
      this.bindingNavigatorData.AddNewItem = null;
      this.bindingNavigatorData.CountItem = null;
      this.bindingNavigatorData.DeleteItem = null;
      this.bindingNavigatorData.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorData.Location = new System.Drawing.Point(0, 0);
      this.bindingNavigatorData.MoveFirstItem = null;
      this.bindingNavigatorData.MoveLastItem = null;
      this.bindingNavigatorData.MoveNextItem = null;
      this.bindingNavigatorData.MovePreviousItem = null;
      this.bindingNavigatorData.Name = "bindingNavigatorData";
      this.bindingNavigatorData.PositionItem = null;
      this.bindingNavigatorData.Size = new System.Drawing.Size(331, 25);
      this.bindingNavigatorData.TabIndex = 2;
      this.bindingNavigatorData.Text = "bindingNavigator1";
      // 
      // UsrCntrlEntityBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.statusStrip1);
      this.Name = "UsrCntrlEntityBrowser";
      this.Size = new System.Drawing.Size(502, 585);
      this.contextMenuStrip1.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPaging)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorData)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

		private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelected;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
    private System.Windows.Forms.ToolStripMenuItem openPaged30ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem getCountToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer1;
    internal System.Windows.Forms.TreeView treeViewEntities;
    private Controls.GridDataEditor gridDataEditor;
    private System.Windows.Forms.BindingNavigator bindingNavigatorPaging;
    private System.Windows.Forms.BindingNavigator bindingNavigatorData;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}