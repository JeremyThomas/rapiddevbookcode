namespace AW.Winforms.Helpers.LLBL
{
  partial class FrmEntitiesAndFields
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntitiesAndFields));
			this.treeViewEntities = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.openPaged30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.getCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelSelected = new System.Windows.Forms.ToolStripStatusLabel();
			this.gridDataEditor = new AW.Winforms.Helpers.Controls.GridDataEditor();
			this.propertyGrid = new AW.Winforms.Helpers.PropGridEx.PropertyGridEx();
			this.splitContainerVertical.Panel1.SuspendLayout();
			this.splitContainerVertical.Panel2.SuspendLayout();
			this.splitContainerVertical.SuspendLayout();
			this.splitContainerHorizontal.Panel1.SuspendLayout();
			this.splitContainerHorizontal.Panel2.SuspendLayout();
			this.splitContainerHorizontal.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainerVertical
			// 
			// 
			// splitContainerVertical.Panel1
			// 
			this.splitContainerVertical.Panel1.Controls.Add(this.treeViewEntities);
			this.splitContainerVertical.Size = new System.Drawing.Size(502, 563);
			this.splitContainerVertical.SplitterDistance = 166;
			// 
			// splitContainerHorizontal
			// 
			// 
			// splitContainerHorizontal.Panel1
			// 
			this.splitContainerHorizontal.Panel1.Controls.Add(this.propertyGrid);
			// 
			// splitContainerHorizontal.Panel2
			// 
			this.splitContainerHorizontal.Panel2.Controls.Add(this.gridDataEditor);
			this.splitContainerHorizontal.Size = new System.Drawing.Size(332, 563);
			this.splitContainerHorizontal.SplitterDistance = 188;
			// 
			// treeViewEntities
			// 
			this.treeViewEntities.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewEntities.ImageIndex = 0;
			this.treeViewEntities.ImageList = this.imageList1;
			this.treeViewEntities.Location = new System.Drawing.Point(0, 0);
			this.treeViewEntities.Name = "treeViewEntities";
			this.treeViewEntities.SelectedImageIndex = 4;
			this.treeViewEntities.Size = new System.Drawing.Size(166, 563);
			this.treeViewEntities.TabIndex = 1;
			this.treeViewEntities.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewEntities_ItemDrag);
			this.treeViewEntities.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEntities_AfterSelect);
			this.treeViewEntities.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewEntities_NodeMouseClick);
			this.treeViewEntities.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewEntities_NodeMouseDoubleClick);
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
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPaged30ToolStripMenuItem,
            this.toolStripMenuItemOpen,
            this.getCountToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(185, 92);
			// 
			// toolStripMenuItemOpen
			// 
			this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
			this.toolStripMenuItemOpen.Size = new System.Drawing.Size(184, 22);
			this.toolStripMenuItemOpen.Text = "Open wthout paging";
			this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
			// 
			// openPaged30ToolStripMenuItem
			// 
			this.openPaged30ToolStripMenuItem.Name = "openPaged30ToolStripMenuItem";
			this.openPaged30ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.openPaged30ToolStripMenuItem.Text = "Open 30 per Page";
			this.openPaged30ToolStripMenuItem.Click += new System.EventHandler(this.openPaged20ToolStripMenuItem_Click);
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
			// gridDataEditor
			// 
			this.gridDataEditor.DataMember = "";
			this.gridDataEditor.DataSource = null;
			this.gridDataEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridDataEditor.Location = new System.Drawing.Point(0, 0);
			this.gridDataEditor.Name = "gridDataEditor";
			this.gridDataEditor.PageSize = ((ushort)(0));
			this.gridDataEditor.Readonly = false;
			this.gridDataEditor.Size = new System.Drawing.Size(332, 371);
			this.gridDataEditor.TabIndex = 0;
			// 
			// propertyGrid
			// 
			this.propertyGrid.CommandsActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
			this.propertyGrid.CommandsDisabledLinkColor = System.Drawing.SystemColors.ControlDark;
			this.propertyGrid.CommandsLinkColor = System.Drawing.SystemColors.ActiveCaption;
			this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid.DrawFlat = true;
			this.propertyGrid.Location = new System.Drawing.Point(0, 0);
			this.propertyGrid.Name = "propertyGrid";
			this.propertyGrid.Size = new System.Drawing.Size(332, 188);
			this.propertyGrid.TabIndex = 0;
			// 
			// FrmEntitiesAndFields
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 585);
			this.Controls.Add(this.statusStrip1);
			this.Name = "FrmEntitiesAndFields";
			this.Text = "Entities And Fields";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEntitiesAndFields_FormClosed);
			this.Load += new System.EventHandler(this.EntitiesAndFields_Load);
			this.Controls.SetChildIndex(this.statusStrip1, 0);
			this.Controls.SetChildIndex(this.splitContainerVertical, 0);
			this.splitContainerVertical.Panel1.ResumeLayout(false);
			this.splitContainerVertical.Panel2.ResumeLayout(false);
			this.splitContainerVertical.ResumeLayout(false);
			this.splitContainerHorizontal.Panel1.ResumeLayout(false);
			this.splitContainerHorizontal.Panel2.ResumeLayout(false);
			this.splitContainerHorizontal.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView treeViewEntities;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelected;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
    private System.Windows.Forms.ToolStripMenuItem openPaged30ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem getCountToolStripMenuItem;
		private Controls.GridDataEditor gridDataEditor;
		private Helpers.PropGridEx.PropertyGridEx propertyGrid;
  }
}