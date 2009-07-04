namespace AW.Winforms.Helpers
{
    partial class frmMain
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
          this.menuStrip1 = new System.Windows.Forms.MenuStrip();
          this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.fileToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
          this.mostRecentlyUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
          this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.orders2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.organizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.vacationBonusUtilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.traceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.adHocLINQQueryRunnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.viewMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
          this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
          this.reOpenWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.openFileDialogProject = new System.Windows.Forms.OpenFileDialog();
          this.mruHandlerProject = new AW.Winforms.Helpers.MostRecentlyUsedHandler.MRUHandler(this.components);
          this.viewEntitiesAndFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.menuStrip1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.mruHandlerProject)).BeginInit();
          this.SuspendLayout();
          // 
          // menuStrip1
          // 
          this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.windowsMenu});
          this.menuStrip1.Location = new System.Drawing.Point(0, 0);
          this.menuStrip1.MdiWindowListItem = this.windowsMenu;
          this.menuStrip1.Name = "menuStrip1";
          this.menuStrip1.Size = new System.Drawing.Size(617, 24);
          this.menuStrip1.TabIndex = 1;
          this.menuStrip1.Text = "menuStrip1";
          // 
          // fileToolStripMenuItem
          // 
          this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItemOpen,
            this.toolStripSeparator2,
            this.mostRecentlyUsedToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
          this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
          this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
          this.fileToolStripMenuItem.Text = "&File";
          // 
          // fileToolStripMenuItemOpen
          // 
          this.fileToolStripMenuItemOpen.Name = "fileToolStripMenuItemOpen";
          this.fileToolStripMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
          this.fileToolStripMenuItemOpen.Size = new System.Drawing.Size(180, 22);
          this.fileToolStripMenuItemOpen.Text = "&Open";
          this.fileToolStripMenuItemOpen.Click += new System.EventHandler(this.fileToolStripMenuItemOpen_Click);
          // 
          // toolStripSeparator2
          // 
          this.toolStripSeparator2.Name = "toolStripSeparator2";
          this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
          // 
          // mostRecentlyUsedToolStripMenuItem
          // 
          this.mostRecentlyUsedToolStripMenuItem.Name = "mostRecentlyUsedToolStripMenuItem";
          this.mostRecentlyUsedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
          this.mostRecentlyUsedToolStripMenuItem.Text = "Most Recently Used";
          // 
          // toolStripSeparator1
          // 
          this.toolStripSeparator1.Name = "toolStripSeparator1";
          this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
          // 
          // exitToolStripMenuItem
          // 
          this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
          this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
          this.exitToolStripMenuItem.Text = "E&xit";
          this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
          // 
          // searchToolStripMenuItem
          // 
          this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.orders2ToolStripMenuItem});
          this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
          this.searchToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
          this.searchToolStripMenuItem.Text = "&Search";
          // 
          // ordersToolStripMenuItem
          // 
          this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
          this.ordersToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
          this.ordersToolStripMenuItem.Text = "&Orders ...";
          this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
          // 
          // orders2ToolStripMenuItem
          // 
          this.orders2ToolStripMenuItem.Name = "orders2ToolStripMenuItem";
          this.orders2ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
          this.orders2ToolStripMenuItem.Text = "Orders2 ...";
          this.orders2ToolStripMenuItem.Click += new System.EventHandler(this.orders2ToolStripMenuItem_Click);
          // 
          // reportsToolStripMenuItem
          // 
          this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.organizationToolStripMenuItem});
          this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
          this.reportsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
          this.reportsToolStripMenuItem.Text = "&Reports";
          // 
          // customersToolStripMenuItem
          // 
          this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
          this.customersToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
          this.customersToolStripMenuItem.Text = "&Customers";
          this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
          // 
          // organizationToolStripMenuItem
          // 
          this.organizationToolStripMenuItem.Name = "organizationToolStripMenuItem";
          this.organizationToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
          this.organizationToolStripMenuItem.Text = "&Organization";
          this.organizationToolStripMenuItem.Click += new System.EventHandler(this.organizationToolStripMenuItem_Click);
          // 
          // utilitiesToolStripMenuItem
          // 
          this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacationBonusUtilityToolStripMenuItem,
            this.traceToolStripMenuItem,
            this.adHocLINQQueryRunnerToolStripMenuItem,
            this.viewMetadataToolStripMenuItem,
            this.viewEntitiesAndFieldsToolStripMenuItem});
          this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
          this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
          this.utilitiesToolStripMenuItem.Text = "&Utilities";
          // 
          // vacationBonusUtilityToolStripMenuItem
          // 
          this.vacationBonusUtilityToolStripMenuItem.Name = "vacationBonusUtilityToolStripMenuItem";
          this.vacationBonusUtilityToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
          this.vacationBonusUtilityToolStripMenuItem.Text = "Vacation Bonus Utility ...";
          this.vacationBonusUtilityToolStripMenuItem.Click += new System.EventHandler(this.vacationBonusUtilityToolStripMenuItem_Click);
          // 
          // traceToolStripMenuItem
          // 
          this.traceToolStripMenuItem.Name = "traceToolStripMenuItem";
          this.traceToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
          this.traceToolStripMenuItem.Text = "Trace...";
          this.traceToolStripMenuItem.Click += new System.EventHandler(this.traceToolStripMenuItem_Click);
          // 
          // adHocLINQQueryRunnerToolStripMenuItem
          // 
          this.adHocLINQQueryRunnerToolStripMenuItem.Name = "adHocLINQQueryRunnerToolStripMenuItem";
          this.adHocLINQQueryRunnerToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
          this.adHocLINQQueryRunnerToolStripMenuItem.Text = "AdHoc LINQ Query Runner";
          this.adHocLINQQueryRunnerToolStripMenuItem.Click += new System.EventHandler(this.adHocLINQQueryRunnerToolStripMenuItem_Click);
          // 
          // viewMetadataToolStripMenuItem
          // 
          this.viewMetadataToolStripMenuItem.Name = "viewMetadataToolStripMenuItem";
          this.viewMetadataToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
          this.viewMetadataToolStripMenuItem.Text = "View Metadata";
          this.viewMetadataToolStripMenuItem.Click += new System.EventHandler(this.viewMetadataToolStripMenuItem_Click);
          // 
          // windowsMenu
          // 
          this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem,
            this.toolStripSeparator3,
            this.reOpenWindowsToolStripMenuItem});
          this.windowsMenu.Name = "windowsMenu";
          this.windowsMenu.Size = new System.Drawing.Size(62, 20);
          this.windowsMenu.Text = "&Windows";
          // 
          // cascadeToolStripMenuItem
          // 
          this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
          this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
          this.cascadeToolStripMenuItem.Text = "&Cascade";
          this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
          // 
          // tileVerticalToolStripMenuItem
          // 
          this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
          this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
          this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
          this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
          // 
          // tileHorizontalToolStripMenuItem
          // 
          this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
          this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
          this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
          this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
          // 
          // closeAllToolStripMenuItem
          // 
          this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
          this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
          this.closeAllToolStripMenuItem.Text = "C&lose All";
          this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
          // 
          // arrangeIconsToolStripMenuItem
          // 
          this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
          this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
          this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
          this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
          // 
          // toolStripSeparator3
          // 
          this.toolStripSeparator3.Name = "toolStripSeparator3";
          this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
          // 
          // reOpenWindowsToolStripMenuItem
          // 
          this.reOpenWindowsToolStripMenuItem.Checked = global::AW.Winforms.Helpers.Properties.Settings.Default.ReopenWindows;
          this.reOpenWindowsToolStripMenuItem.CheckOnClick = true;
          this.reOpenWindowsToolStripMenuItem.Name = "reOpenWindowsToolStripMenuItem";
          this.reOpenWindowsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
          this.reOpenWindowsToolStripMenuItem.Text = "Reopen Windows";
          // 
          // openFileDialogProject
          // 
          this.openFileDialogProject.FileName = "AQDRenamedEntities.lgp";
          this.openFileDialogProject.Filter = "\"LLBL Project Files\"|*.lgp|C# files|*.cs|Text files (*.txt)|*.txt|All files (*.*)" +
              "|*.* ";
          // 
          // mruHandlerProject
          // 
          this.mruHandlerProject.AutoSeparators = true;
          this.mruHandlerProject.MruItem = this.mostRecentlyUsedToolStripMenuItem;
          this.mruHandlerProject.StorageName = "mru";
          this.mruHandlerProject.MRUItemClicked += new AW.Winforms.Helpers.MostRecentlyUsedHandler.MRUItemClickedHandler(this.mruHandlerProject_MRUItemClicked);
          // 
          // viewEntitiesAndFieldsToolStripMenuItem
          // 
          this.viewEntitiesAndFieldsToolStripMenuItem.Name = "viewEntitiesAndFieldsToolStripMenuItem";
          this.viewEntitiesAndFieldsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
          this.viewEntitiesAndFieldsToolStripMenuItem.Text = "View Entities and Fields";
          this.viewEntitiesAndFieldsToolStripMenuItem.Click += new System.EventHandler(this.viewEntitiesAndFieldsToolStripMenuItem_Click);
          // 
          // frmMain
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(617, 443);
          this.Controls.Add(this.menuStrip1);
          this.DataBindings.Add(new System.Windows.Forms.Binding("WindowState", global::AW.Winforms.Helpers.Properties.Settings.Default, "MainWindowState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.IsMdiContainer = true;
          this.MainMenuStrip = this.menuStrip1;
          this.Name = "frmMain";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "Adventure Works";
          this.WindowState = global::AW.Winforms.Helpers.Properties.Settings.Default.MainWindowState;
          this.Load += new System.EventHandler(this.frmMain_Load);
          this.Shown += new System.EventHandler(this.frmMain_Shown);
          this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
          this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
          this.menuStrip1.ResumeLayout(false);
          this.menuStrip1.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.mruHandlerProject)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacationBonusUtilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orders2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItemOpen;
        private AW.Winforms.Helpers.MostRecentlyUsedHandler.MRUHandler mruHandlerProject;
        private System.Windows.Forms.ToolStripMenuItem mostRecentlyUsedToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogProject;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reOpenWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem adHocLINQQueryRunnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMetadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEntitiesAndFieldsToolStripMenuItem;
    }
}