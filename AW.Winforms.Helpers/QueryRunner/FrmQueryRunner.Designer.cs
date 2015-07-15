namespace AW.Winforms.Helpers.QueryRunner
{
  partial class FrmQueryRunner
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQueryRunner));
      this.contextMenuStripTab = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
      this.closeAllButThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStripBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.blankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.mostRecentlyUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPageNew = new System.Windows.Forms.TabPage();
      this.queryRunner1 = new AW.Winforms.Helpers.QueryRunner.QueryRunner();
      this.mruHandler1 = new AW.Winforms.Helpers.MostRecentlyUsedHandler.MRUHandler(this.components);
      this.contextMenuStripTab.SuspendLayout();
      this.contextMenuStripBlank.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.toolStripContainer2.ContentPanel.SuspendLayout();
      this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer2.SuspendLayout();
      this.tabControl.SuspendLayout();
      this.tabPageNew.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.mruHandler1)).BeginInit();
      this.SuspendLayout();
      // 
      // contextMenuStripTab
      // 
      this.contextMenuStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSave,
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemClose,
            this.closeAllButThisToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.newToolStripMenuItem});
      this.contextMenuStripTab.Name = "contextMenuStripTab";
      this.contextMenuStripTab.Size = new System.Drawing.Size(167, 136);
      this.contextMenuStripTab.Text = "Save As...";
      // 
      // toolStripMenuItemSave
      // 
      this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
      this.toolStripMenuItemSave.Size = new System.Drawing.Size(166, 22);
      this.toolStripMenuItemSave.Text = "Save";
      this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
      // 
      // toolStripMenuItemOpen
      // 
      this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
      this.toolStripMenuItemOpen.Size = new System.Drawing.Size(166, 22);
      this.toolStripMenuItemOpen.Text = "Open";
      this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
      // 
      // toolStripMenuItemClose
      // 
      this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
      this.toolStripMenuItemClose.Size = new System.Drawing.Size(166, 22);
      this.toolStripMenuItemClose.Text = "Close";
      this.toolStripMenuItemClose.Click += new System.EventHandler(this.toolStripMenuItemClose_Click);
      // 
      // closeAllButThisToolStripMenuItem
      // 
      this.closeAllButThisToolStripMenuItem.Name = "closeAllButThisToolStripMenuItem";
      this.closeAllButThisToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
      this.closeAllButThisToolStripMenuItem.Text = "Close All But This";
      this.closeAllButThisToolStripMenuItem.Click += new System.EventHandler(this.closeAllButThisToolStripMenuItem_Click);
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
      this.saveAsToolStripMenuItem.Text = "Save As...";
      this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
      this.newToolStripMenuItem.Text = "New";
      this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
      // 
      // contextMenuStripBlank
      // 
      this.contextMenuStripBlank.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blankToolStripMenuItem});
      this.contextMenuStripBlank.Name = "contextMenuStripBlank";
      this.contextMenuStripBlank.Size = new System.Drawing.Size(104, 26);
      // 
      // blankToolStripMenuItem
      // 
      this.blankToolStripMenuItem.Name = "blankToolStripMenuItem";
      this.blankToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.blankToolStripMenuItem.Text = "blank";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(3, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(136, 24);
      this.menuStrip1.Stretch = false;
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem1
      // 
      this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.mostRecentlyUsedToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem1,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
      this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem1.Text = "&File";
      // 
      // newToolStripMenuItem1
      // 
      this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
      this.newToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
      this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
      this.newToolStripMenuItem1.Text = "&New";
      this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
      // 
      // mostRecentlyUsedToolStripMenuItem
      // 
      this.mostRecentlyUsedToolStripMenuItem.Name = "mostRecentlyUsedToolStripMenuItem";
      this.mostRecentlyUsedToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
      this.mostRecentlyUsedToolStripMenuItem.Text = "Most Recently Used";
      // 
      // openToolStripMenuItem1
      // 
      this.openToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem1.Image")));
      this.openToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
      this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
      this.openToolStripMenuItem1.Text = "&Open";
      this.openToolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
      this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
      this.saveToolStripMenuItem.Text = "&Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
      // 
      // saveAsToolStripMenuItem1
      // 
      this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
      this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
      this.saveAsToolStripMenuItem1.Text = "Save &As";
      this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(175, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
      this.toolsToolStripMenuItem.Text = "&Tools";
      // 
      // customizeToolStripMenuItem
      // 
      this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
      this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.customizeToolStripMenuItem.Text = "&Customize";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new System.Drawing.Size(113, 6);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // openFileDialog
      // 
      this.openFileDialog.DefaultExt = "cs";
      this.openFileDialog.Filter = "C# files|*.cs|Text files (*.txt)|*.txt|All files (*.*)|*.* ";
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.Filter = "C# files|*.cs|Text files (*.txt)|*.txt|All files (*.*)|*.* ";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1});
      this.toolStrip1.Location = new System.Drawing.Point(139, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(78, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // newToolStripButton
      // 
      this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
      this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripButton.Name = "newToolStripButton";
      this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.newToolStripButton.Text = "&New";
      this.newToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
      // 
      // openToolStripButton
      // 
      this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
      this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripButton.Name = "openToolStripButton";
      this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.openToolStripButton.Text = "&Open";
      this.openToolStripButton.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
      this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.saveToolStripButton.Text = "&Save";
      this.saveToolStripButton.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripContainer2
      // 
      this.toolStripContainer2.BottomToolStripPanelVisible = false;
      // 
      // toolStripContainer2.ContentPanel
      // 
      this.toolStripContainer2.ContentPanel.Controls.Add(this.tabControl);
      this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(918, 599);
      this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.toolStripContainer2.LeftToolStripPanelVisible = false;
      this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
      this.toolStripContainer2.Name = "toolStripContainer2";
      this.toolStripContainer2.RightToolStripPanelVisible = false;
      this.toolStripContainer2.Size = new System.Drawing.Size(918, 624);
      this.toolStripContainer2.TabIndex = 2;
      this.toolStripContainer2.Text = "toolStripContainer2";
      // 
      // toolStripContainer2.TopToolStripPanel
      // 
      this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.menuStrip1);
      this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip1);
      // 
      // tabControl
      // 
      this.tabControl.AllowDrop = true;
      this.tabControl.ContextMenuStrip = this.contextMenuStripTab;
      this.tabControl.Controls.Add(this.tabPageNew);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 0);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(918, 599);
      this.tabControl.TabIndex = 0;
      this.tabControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabControl_DragDrop);
      this.tabControl.DragOver += new System.Windows.Forms.DragEventHandler(this.tabControl_DragOver);
      // 
      // tabPageNew
      // 
      this.tabPageNew.ContextMenuStrip = this.contextMenuStripTab;
      this.tabPageNew.Controls.Add(this.queryRunner1);
      this.tabPageNew.Location = new System.Drawing.Point(4, 22);
      this.tabPageNew.Name = "tabPageNew";
      this.tabPageNew.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageNew.Size = new System.Drawing.Size(910, 573);
      this.tabPageNew.TabIndex = 0;
      this.tabPageNew.Text = "New";
      this.tabPageNew.ToolTipText = "New";
      this.tabPageNew.UseVisualStyleBackColor = true;
      // 
      // queryRunner1
      // 
      this.queryRunner1.AllowDrop = true;
      this.queryRunner1.ContextMenuStrip = this.contextMenuStripBlank;
      this.queryRunner1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.queryRunner1.Location = new System.Drawing.Point(3, 3);
      this.queryRunner1.Name = "queryRunner1";
      this.queryRunner1.Size = new System.Drawing.Size(904, 567);
      this.queryRunner1.SplitterDistance = 538;
      this.queryRunner1.TabIndex = 0;
      this.queryRunner1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabControl_DragDrop);
      this.queryRunner1.DragOver += new System.Windows.Forms.DragEventHandler(this.tabControl_DragOver);
      // 
      // mruHandler1
      // 
      this.mruHandler1.MruItem = this.mostRecentlyUsedToolStripMenuItem;
      this.mruHandler1.StorageName = "mru";
      this.mruHandler1.MRUItemClicked += new AW.Winforms.Helpers.MostRecentlyUsedHandler.MRUItemClickedHandler(this.mruHandler1_MRUItemClicked);
      // 
      // FrmQueryRunner
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(918, 624);
      this.Controls.Add(this.toolStripContainer2);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FrmQueryRunner";
      this.Tag = "true";
      this.Text = "Query Runner";
      this.contextMenuStripTab.ResumeLayout(false);
      this.contextMenuStripBlank.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.toolStripContainer2.ContentPanel.ResumeLayout(false);
      this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer2.TopToolStripPanel.PerformLayout();
      this.toolStripContainer2.ResumeLayout(false);
      this.toolStripContainer2.PerformLayout();
      this.tabControl.ResumeLayout(false);
      this.tabPageNew.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.mruHandler1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ContextMenuStrip contextMenuStripTab;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClose;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.ToolStripMenuItem closeAllButThisToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripBlank;
    private System.Windows.Forms.ToolStripMenuItem blankToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton newToolStripButton;
    private System.Windows.Forms.ToolStripButton openToolStripButton;
    private System.Windows.Forms.ToolStripButton saveToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripContainer toolStripContainer2;
    private MostRecentlyUsedHandler.MRUHandler mruHandler1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPageNew;
    private QueryRunner queryRunner1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem mostRecentlyUsedToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
  }
}