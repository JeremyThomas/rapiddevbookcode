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
      this.openPaged30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.getCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewInPropertyGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewPropertyDescriptorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewAttributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewInObjectBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabelSelected = new System.Windows.Forms.ToolStripStatusLabel();
      this.gridDataEditor = new AW.Winforms.Helpers.Controls.GridDataEditor();
      this.propertyGrid = new AW.Winforms.Helpers.PropGridEx.PropertyGridEx();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).BeginInit();
      this.splitContainerVertical.Panel1.SuspendLayout();
      this.splitContainerVertical.Panel2.SuspendLayout();
      this.splitContainerVertical.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).BeginInit();
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
      this.splitContainerHorizontal.SplitterDistance = 155;
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
      this.treeViewEntities.Size = new System.Drawing.Size(166, 563);
      this.treeViewEntities.TabIndex = 1;
      this.toolTip1.SetToolTip(this.treeViewEntities, "Entities amd their proerties");
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
            this.getCountToolStripMenuItem,
            this.viewInPropertyGridToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.viewFieldsToolStripMenuItem,
            this.viewPropertiesToolStripMenuItem,
            this.viewPropertyDescriptorsToolStripMenuItem,
            this.viewAttributesToolStripMenuItem,
            this.viewInObjectBrowserToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(240, 224);
      // 
      // openPaged30ToolStripMenuItem
      // 
      this.openPaged30ToolStripMenuItem.Name = "openPaged30ToolStripMenuItem";
      this.openPaged30ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.openPaged30ToolStripMenuItem.Text = "Open 30 per Page";
      this.openPaged30ToolStripMenuItem.Click += new System.EventHandler(this.openPagedToolStripMenuItem_Click);
      // 
      // toolStripMenuItemOpen
      // 
      this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
      this.toolStripMenuItemOpen.Size = new System.Drawing.Size(239, 22);
      this.toolStripMenuItemOpen.Text = "Open wthout paging";
      this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
      // 
      // getCountToolStripMenuItem
      // 
      this.getCountToolStripMenuItem.Name = "getCountToolStripMenuItem";
      this.getCountToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.getCountToolStripMenuItem.Text = "Get Count";
      this.getCountToolStripMenuItem.Click += new System.EventHandler(this.getCountToolStripMenuItem_Click);
      // 
      // viewInPropertyGridToolStripMenuItem
      // 
      this.viewInPropertyGridToolStripMenuItem.Name = "viewInPropertyGridToolStripMenuItem";
      this.viewInPropertyGridToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.viewInPropertyGridToolStripMenuItem.Text = "View in PropertyGrid";
      this.viewInPropertyGridToolStripMenuItem.Click += new System.EventHandler(this.viewInPropertyGridToolStripMenuItem_Click);
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.viewToolStripMenuItem.Text = "View Queryable in PropertyGrid";
      this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
      // 
      // viewFieldsToolStripMenuItem
      // 
      this.viewFieldsToolStripMenuItem.Name = "viewFieldsToolStripMenuItem";
      this.viewFieldsToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.viewFieldsToolStripMenuItem.Text = "View Fields";
      this.viewFieldsToolStripMenuItem.Click += new System.EventHandler(this.viewFieldsToolStripMenuItem_Click);
      // 
      // viewPropertiesToolStripMenuItem
      // 
      this.viewPropertiesToolStripMenuItem.Name = "viewPropertiesToolStripMenuItem";
      this.viewPropertiesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.viewPropertiesToolStripMenuItem.Text = "View Properties";
      this.viewPropertiesToolStripMenuItem.Click += new System.EventHandler(this.viewPropertiesToolStripMenuItem_Click);
      // 
      // viewPropertyDescriptorsToolStripMenuItem
      // 
      this.viewPropertyDescriptorsToolStripMenuItem.Name = "viewPropertyDescriptorsToolStripMenuItem";
      this.viewPropertyDescriptorsToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.viewPropertyDescriptorsToolStripMenuItem.Text = "View Property Descriptors";
      this.viewPropertyDescriptorsToolStripMenuItem.Click += new System.EventHandler(this.viewPropertyDescriptorsToolStripMenuItem_Click);
      // 
      // viewAttributesToolStripMenuItem
      // 
      this.viewAttributesToolStripMenuItem.Name = "viewAttributesToolStripMenuItem";
      this.viewAttributesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.viewAttributesToolStripMenuItem.Text = "View Attributes";
      this.viewAttributesToolStripMenuItem.Click += new System.EventHandler(this.viewAttributesToolStripMenuItem_Click);
      // 
      // viewInObjectBrowserToolStripMenuItem
      // 
      this.viewInObjectBrowserToolStripMenuItem.Name = "viewInObjectBrowserToolStripMenuItem";
      this.viewInObjectBrowserToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.viewInObjectBrowserToolStripMenuItem.Text = "View in Object Browser";
      this.viewInObjectBrowserToolStripMenuItem.Click += new System.EventHandler(this.viewInObjectBrowserToolStripMenuItem_Click);
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
      this.gridDataEditor.EnsureFilteringEnabled = false;
      this.gridDataEditor.Location = new System.Drawing.Point(0, 0);
      this.gridDataEditor.Name = "gridDataEditor";
      this.gridDataEditor.PageSize = ((ushort)(0));
      this.gridDataEditor.Readonly = false;
      this.gridDataEditor.Size = new System.Drawing.Size(332, 404);
      this.gridDataEditor.TabIndex = 0;
      this.toolTip1.SetToolTip(this.gridDataEditor, "Data in the Tables");
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
      this.propertyGrid.Size = new System.Drawing.Size(332, 155);
      this.propertyGrid.TabIndex = 0;
      // 
      // FrmEntitiesAndFields
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(502, 585);
      this.Controls.Add(this.statusStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmEntitiesAndFields";
      this.Text = "Data Browser";
      this.WindowSettingsName = "EntitiesAndFieldsWindowSettings";
      this.Controls.SetChildIndex(this.statusStrip1, 0);
      this.Controls.SetChildIndex(this.splitContainerVertical, 0);
      this.splitContainerVertical.Panel1.ResumeLayout(false);
      this.splitContainerVertical.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).EndInit();
      this.splitContainerVertical.ResumeLayout(false);
      this.splitContainerHorizontal.Panel1.ResumeLayout(false);
      this.splitContainerHorizontal.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).EndInit();
      this.splitContainerHorizontal.ResumeLayout(false);
      this.contextMenuStrip1.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
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
		private Controls.GridDataEditor gridDataEditor;
		private Helpers.PropGridEx.PropertyGridEx propertyGrid;
		internal System.Windows.Forms.TreeView treeViewEntities;
		private System.Windows.Forms.ToolStripMenuItem viewInPropertyGridToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewFieldsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewPropertiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewPropertyDescriptorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewAttributesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewInObjectBrowserToolStripMenuItem;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}