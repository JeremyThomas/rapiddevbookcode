namespace LLBLGen.EntityBrowser
{
  partial class FrmLLBLGenEntityBrowser
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLLBLGenEntityBrowser));
      this.linqMetaDataAssemblyPathLabel = new System.Windows.Forms.LinkLabel();
      this.adapterAssemblyPathLabel = new System.Windows.Forms.LinkLabel();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.contextMenuStripTabControl = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toggleSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panelSettings = new System.Windows.Forms.Panel();
      this.adapterAssemblyPathTextBox = new System.Windows.Forms.TextBox();
      this.panelMetaData = new System.Windows.Forms.Panel();
      this.linqMetaDataAssemblyPathTextBox = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.labellinqMetaDataAssemblyVersion = new System.Windows.Forms.Label();
      this.contextMenuStripTabPage = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addConnectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.editConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toggleSettingsVisibilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonAddConnection = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonCancelEdit = new System.Windows.Forms.ToolStripButton();
      this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      this.toolStripTextBoxTablePrefixDelimiter = new System.Windows.Forms.ToolStripTextBox();
      this.toolStripCheckBoxUseSchema = new AW.Winforms.Helpers.Controls.ToolStripCheckBox();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripCheckBoxUseContext = new AW.Winforms.Helpers.Controls.ToolStripCheckBox();
      this.toolStripNumericUpDownCacheDurationInSeconds = new AW.Winforms.Helpers.Controls.ToolStripNumericUpDown();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripCheckBoxEnsureFilteringEnabled = new AW.Winforms.Helpers.Controls.ToolStripCheckBox();
      this.toolStripNumericUpDownPageSize = new AW.Winforms.Helpers.Controls.ToolStripNumericUpDown();
      this.toolStripCheckBoxCascadeDeletes = new AW.Winforms.Helpers.Controls.ToolStripCheckBox();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripNumericUpDownCommandTimeOut = new AW.Winforms.Helpers.Controls.ToolStripNumericUpDown();
      this.toolStripLabelOrmProfilerStatus = new System.Windows.Forms.ToolStripLabel();
      this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
      this.contextMenuStripTabControl.SuspendLayout();
      this.panelSettings.SuspendLayout();
      this.panelMetaData.SuspendLayout();
      this.panel2.SuspendLayout();
      this.contextMenuStripTabPage.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // linqMetaDataAssemblyPathLabel
      // 
      this.linqMetaDataAssemblyPathLabel.AutoSize = true;
      this.linqMetaDataAssemblyPathLabel.Dock = System.Windows.Forms.DockStyle.Left;
      this.linqMetaDataAssemblyPathLabel.Location = new System.Drawing.Point(0, 0);
      this.linqMetaDataAssemblyPathLabel.Name = "linqMetaDataAssemblyPathLabel";
      this.linqMetaDataAssemblyPathLabel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.linqMetaDataAssemblyPathLabel.Size = new System.Drawing.Size(158, 13);
      this.linqMetaDataAssemblyPathLabel.TabIndex = 0;
      this.linqMetaDataAssemblyPathLabel.TabStop = true;
      this.linqMetaDataAssemblyPathLabel.Text = "Linq Meta Data Assembly Path:";
      this.linqMetaDataAssemblyPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.toolTip1.SetToolTip(this.linqMetaDataAssemblyPathLabel, "Path to a LLBLGen Pro generated assembly containing an ILinqMetaData implementati" +
        "on");
      this.linqMetaDataAssemblyPathLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linqMetaDataAssemblyPathLabel_LinkClicked);
      // 
      // adapterAssemblyPathLabel
      // 
      this.adapterAssemblyPathLabel.AutoSize = true;
      this.adapterAssemblyPathLabel.Dock = System.Windows.Forms.DockStyle.Left;
      this.adapterAssemblyPathLabel.Location = new System.Drawing.Point(0, 0);
      this.adapterAssemblyPathLabel.Name = "adapterAssemblyPathLabel";
      this.adapterAssemblyPathLabel.Size = new System.Drawing.Size(119, 13);
      this.adapterAssemblyPathLabel.TabIndex = 2;
      this.adapterAssemblyPathLabel.TabStop = true;
      this.adapterAssemblyPathLabel.Text = "Adapter Assembly Path:";
      this.toolTip1.SetToolTip(this.adapterAssemblyPathLabel, "Path to Adapter assembly");
      this.adapterAssemblyPathLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linqMetaDataAssemblyPathLabel_LinkClicked);
      // 
      // tabControl
      // 
      this.tabControl.ContextMenuStrip = this.contextMenuStripTabControl;
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 73);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(1501, 515);
      this.tabControl.TabIndex = 1;
      this.tabControl.MouseLeave += new System.EventHandler(this.tabControl_MouseLeave);
      this.tabControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseMove);
      // 
      // contextMenuStripTabControl
      // 
      this.contextMenuStripTabControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConnectionToolStripMenuItem,
            this.toolStripSeparator1,
            this.toggleSettingsToolStripMenuItem});
      this.contextMenuStripTabControl.Name = "contextMenuStripTabControl";
      this.contextMenuStripTabControl.Size = new System.Drawing.Size(203, 54);
      // 
      // addConnectionToolStripMenuItem
      // 
      this.addConnectionToolStripMenuItem.Name = "addConnectionToolStripMenuItem";
      this.addConnectionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
      this.addConnectionToolStripMenuItem.Text = "Add Connection";
      this.addConnectionToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonAddConnection_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
      // 
      // toggleSettingsToolStripMenuItem
      // 
      this.toggleSettingsToolStripMenuItem.Name = "toggleSettingsToolStripMenuItem";
      this.toggleSettingsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
      this.toggleSettingsToolStripMenuItem.Text = "Toggle Settings Visibility";
      this.toggleSettingsToolStripMenuItem.Click += new System.EventHandler(this.toggleSettingsToolStripMenuItem_Click);
      // 
      // panelSettings
      // 
      this.panelSettings.Controls.Add(this.adapterAssemblyPathTextBox);
      this.panelSettings.Controls.Add(this.adapterAssemblyPathLabel);
      this.panelSettings.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "ShowSettings", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.panelSettings.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelSettings.Location = new System.Drawing.Point(0, 50);
      this.panelSettings.Name = "panelSettings";
      this.panelSettings.Size = new System.Drawing.Size(1501, 23);
      this.panelSettings.TabIndex = 2;
      this.panelSettings.Visible = global::LLBLGen.EntityBrowser.Properties.Settings.Default.ShowSettings;
      // 
      // adapterAssemblyPathTextBox
      // 
      this.adapterAssemblyPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "AdapterAssemblyPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.adapterAssemblyPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.adapterAssemblyPathTextBox.Location = new System.Drawing.Point(119, 0);
      this.adapterAssemblyPathTextBox.Name = "adapterAssemblyPathTextBox";
      this.adapterAssemblyPathTextBox.Size = new System.Drawing.Size(1382, 20);
      this.adapterAssemblyPathTextBox.TabIndex = 3;
      this.adapterAssemblyPathTextBox.Text = global::LLBLGen.EntityBrowser.Properties.Settings.Default.AdapterAssemblyPath;
      this.toolTip1.SetToolTip(this.adapterAssemblyPathTextBox, "Path to Adapter assembly");
      // 
      // panelMetaData
      // 
      this.panelMetaData.Controls.Add(this.linqMetaDataAssemblyPathTextBox);
      this.panelMetaData.Controls.Add(this.linqMetaDataAssemblyPathLabel);
      this.panelMetaData.Controls.Add(this.panel2);
      this.panelMetaData.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelMetaData.Location = new System.Drawing.Point(0, 28);
      this.panelMetaData.Name = "panelMetaData";
      this.panelMetaData.Size = new System.Drawing.Size(1501, 22);
      this.panelMetaData.TabIndex = 20;
      // 
      // linqMetaDataAssemblyPathTextBox
      // 
      this.linqMetaDataAssemblyPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "LinqMetaDataAssemblyPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.linqMetaDataAssemblyPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.linqMetaDataAssemblyPathTextBox.Location = new System.Drawing.Point(158, 0);
      this.linqMetaDataAssemblyPathTextBox.Name = "linqMetaDataAssemblyPathTextBox";
      this.linqMetaDataAssemblyPathTextBox.Size = new System.Drawing.Size(1301, 20);
      this.linqMetaDataAssemblyPathTextBox.TabIndex = 1;
      this.linqMetaDataAssemblyPathTextBox.Text = global::LLBLGen.EntityBrowser.Properties.Settings.Default.LinqMetaDataAssemblyPath;
      this.toolTip1.SetToolTip(this.linqMetaDataAssemblyPathTextBox, "Path to a LLBLGen Pro generated assembly containing an ILinqMetaData implementati" +
        "on");
      this.linqMetaDataAssemblyPathTextBox.Leave += new System.EventHandler(this.linqMetaDataAssemblyPathTextBox_Leave);
      // 
      // panel2
      // 
      this.panel2.AutoSize = true;
      this.panel2.Controls.Add(this.labellinqMetaDataAssemblyVersion);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel2.Location = new System.Drawing.Point(1459, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(42, 22);
      this.panel2.TabIndex = 3;
      // 
      // labellinqMetaDataAssemblyVersion
      // 
      this.labellinqMetaDataAssemblyVersion.AutoSize = true;
      this.labellinqMetaDataAssemblyVersion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.labellinqMetaDataAssemblyVersion.Location = new System.Drawing.Point(0, 0);
      this.labellinqMetaDataAssemblyVersion.Name = "labellinqMetaDataAssemblyVersion";
      this.labellinqMetaDataAssemblyVersion.Size = new System.Drawing.Size(42, 13);
      this.labellinqMetaDataAssemblyVersion.TabIndex = 2;
      this.labellinqMetaDataAssemblyVersion.Text = "Version";
      this.labellinqMetaDataAssemblyVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // contextMenuStripTabPage
      // 
      this.contextMenuStripTabPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConnectionToolStripMenuItem1,
            this.editConnectionToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.toolStripSeparator3,
            this.removeToolStripMenuItem,
            this.toolStripSeparator2,
            this.toggleSettingsVisibilityToolStripMenuItem});
      this.contextMenuStripTabPage.Name = "contextMenuStripTabPage";
      this.contextMenuStripTabPage.Size = new System.Drawing.Size(203, 126);
      // 
      // addConnectionToolStripMenuItem1
      // 
      this.addConnectionToolStripMenuItem1.Name = "addConnectionToolStripMenuItem1";
      this.addConnectionToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
      this.addConnectionToolStripMenuItem1.Text = "Add Connection";
      this.addConnectionToolStripMenuItem1.Click += new System.EventHandler(this.toolStripButtonAddConnection_Click);
      // 
      // editConnectionToolStripMenuItem
      // 
      this.editConnectionToolStripMenuItem.Name = "editConnectionToolStripMenuItem";
      this.editConnectionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
      this.editConnectionToolStripMenuItem.Text = "Edit Connection";
      this.editConnectionToolStripMenuItem.Click += new System.EventHandler(this.editConnectionToolStripMenuItem_Click);
      // 
      // renameToolStripMenuItem
      // 
      this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
      this.renameToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
      this.renameToolStripMenuItem.Text = "Rename";
      this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
      // 
      // removeToolStripMenuItem
      // 
      this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
      this.removeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
      this.removeToolStripMenuItem.Text = "Remove";
      this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
      // 
      // toggleSettingsVisibilityToolStripMenuItem
      // 
      this.toggleSettingsVisibilityToolStripMenuItem.Name = "toggleSettingsVisibilityToolStripMenuItem";
      this.toggleSettingsVisibilityToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
      this.toggleSettingsVisibilityToolStripMenuItem.Text = "Toggle Settings Visibility";
      this.toggleSettingsVisibilityToolStripMenuItem.Click += new System.EventHandler(this.toggleSettingsToolStripMenuItem_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // toolStrip
      // 
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddConnection,
            this.toolStripButtonLoad,
            this.toolStripButtonCancelEdit,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.toolStripLabel1,
            this.toolStripTextBoxTablePrefixDelimiter,
            this.toolStripCheckBoxUseSchema,
            this.toolStripSeparator4,
            this.toolStripCheckBoxUseContext,
            this.toolStripNumericUpDownCacheDurationInSeconds,
            this.toolStripSeparator5,
            this.toolStripCheckBoxEnsureFilteringEnabled,
            this.toolStripNumericUpDownPageSize,
            this.toolStripCheckBoxCascadeDeletes,
            this.toolStripSeparator7,
            this.toolStripNumericUpDownCommandTimeOut,
            this.toolStripLabelOrmProfilerStatus,
            this.toolStripButtonAbout});
      this.toolStrip.Location = new System.Drawing.Point(0, 0);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(1501, 28);
      this.toolStrip.TabIndex = 3;
      this.toolStrip.Text = "toolStrip";
      // 
      // toolStripButtonAddConnection
      // 
      this.toolStripButtonAddConnection.BackColor = System.Drawing.Color.Transparent;
      this.toolStripButtonAddConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonAddConnection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddConnection.Image")));
      this.toolStripButtonAddConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonAddConnection.Name = "toolStripButtonAddConnection";
      this.toolStripButtonAddConnection.Size = new System.Drawing.Size(33, 25);
      this.toolStripButtonAddConnection.Text = "Add";
      this.toolStripButtonAddConnection.ToolTipText = "Add Connection";
      this.toolStripButtonAddConnection.Click += new System.EventHandler(this.toolStripButtonAddConnection_Click);
      // 
      // toolStripButtonLoad
      // 
      this.toolStripButtonLoad.BackColor = System.Drawing.Color.Transparent;
      this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonLoad.Enabled = false;
      this.toolStripButtonLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoad.Image")));
      this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonLoad.Name = "toolStripButtonLoad";
      this.toolStripButtonLoad.Size = new System.Drawing.Size(47, 25);
      this.toolStripButtonLoad.Text = "Reload";
      this.toolStripButtonLoad.ToolTipText = "Reload all the tabs with the default settings";
      this.toolStripButtonLoad.Click += new System.EventHandler(this.toolStripButtonLoad_Click);
      // 
      // toolStripButtonCancelEdit
      // 
      this.toolStripButtonCancelEdit.BackColor = System.Drawing.Color.Transparent;
      this.toolStripButtonCancelEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonCancelEdit.Enabled = false;
      this.toolStripButtonCancelEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelEdit.Image")));
      this.toolStripButtonCancelEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonCancelEdit.Name = "toolStripButtonCancelEdit";
      this.toolStripButtonCancelEdit.Size = new System.Drawing.Size(23, 25);
      this.toolStripButtonCancelEdit.Text = "Cancel";
      this.toolStripButtonCancelEdit.Visible = false;
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.BackColor = System.Drawing.Color.Transparent;
      this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Enabled = false;
      this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
      this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new System.Drawing.Size(23, 25);
      this.saveToolStripButton.Text = "&Save";
      this.saveToolStripButton.Visible = false;
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.BackColor = System.Drawing.Color.Transparent;
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new System.Drawing.Size(90, 25);
      this.toolStripLabel1.Text = "Prefix Delimiter:";
      this.toolStripLabel1.ToolTipText = "Table Prefix Delimiter to group Entities by (e.g. with a delimiter of _ table Sal" +
    "es_Order would grouped into a node called Sales)";
      // 
      // toolStripTextBoxTablePrefixDelimiter
      // 
      this.toolStripTextBoxTablePrefixDelimiter.MaxLength = 25;
      this.toolStripTextBoxTablePrefixDelimiter.Name = "toolStripTextBoxTablePrefixDelimiter";
      this.toolStripTextBoxTablePrefixDelimiter.Size = new System.Drawing.Size(20, 28);
      this.toolStripTextBoxTablePrefixDelimiter.Text = global::LLBLGen.EntityBrowser.Properties.Settings.Default.PrefixDelimiter;
      this.toolStripTextBoxTablePrefixDelimiter.ToolTipText = "Table Prefix Delimiter to group Entities by (e.g. with a delimiter of _ table Sal" +
    "es_Order would grouped into a node called Sales)";
      // 
      // toolStripCheckBoxUseSchema
      // 
      this.toolStripCheckBoxUseSchema.BackColor = System.Drawing.Color.Transparent;
      this.toolStripCheckBoxUseSchema.Checked = global::LLBLGen.EntityBrowser.Properties.Settings.Default.UseSchema;
      this.toolStripCheckBoxUseSchema.CheckState = System.Windows.Forms.CheckState.Checked;
      this.toolStripCheckBoxUseSchema.Name = "toolStripCheckBoxUseSchema";
      this.toolStripCheckBoxUseSchema.Size = new System.Drawing.Size(90, 25);
      this.toolStripCheckBoxUseSchema.Text = "Use Schema";
      this.toolStripCheckBoxUseSchema.ToolTipText = "Use Table Schema to group the Entities";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.BackColor = System.Drawing.Color.Transparent;
      this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
      // 
      // toolStripCheckBoxUseContext
      // 
      this.toolStripCheckBoxUseContext.BackColor = System.Drawing.Color.Transparent;
      this.toolStripCheckBoxUseContext.Checked = global::LLBLGen.EntityBrowser.Properties.Settings.Default.UseContext;
      this.toolStripCheckBoxUseContext.CheckState = System.Windows.Forms.CheckState.Checked;
      this.toolStripCheckBoxUseContext.Name = "toolStripCheckBoxUseContext";
      this.toolStripCheckBoxUseContext.Size = new System.Drawing.Size(89, 25);
      this.toolStripCheckBoxUseContext.Text = "Use Context";
      this.toolStripCheckBoxUseContext.ToolTipText = resources.GetString("toolStripCheckBoxUseContext.ToolTipText");
      // 
      // toolStripNumericUpDownCacheDurationInSeconds
      // 
      this.toolStripNumericUpDownCacheDurationInSeconds.BackColor = System.Drawing.Color.Transparent;
      this.toolStripNumericUpDownCacheDurationInSeconds.DecimalPlaces = 0;
      this.toolStripNumericUpDownCacheDurationInSeconds.Name = "toolStripNumericUpDownCacheDurationInSeconds";
      this.toolStripNumericUpDownCacheDurationInSeconds.NumBackColor = System.Drawing.SystemColors.Window;
      this.toolStripNumericUpDownCacheDurationInSeconds.Size = new System.Drawing.Size(151, 25);
      this.toolStripNumericUpDownCacheDurationInSeconds.Text = "Cache Duration:";
      this.toolStripNumericUpDownCacheDurationInSeconds.ToolTipText = "Specifies the duration (in seconds) that the query\'s result set should be cached " +
    "for. Zero to turn caching off.";
      this.toolStripNumericUpDownCacheDurationInSeconds.Value = global::LLBLGen.EntityBrowser.Properties.Settings.Default.CacheDurationInSeconds;
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.BackColor = System.Drawing.Color.Transparent;
      this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
      // 
      // toolStripCheckBoxEnsureFilteringEnabled
      // 
      this.toolStripCheckBoxEnsureFilteringEnabled.BackColor = System.Drawing.Color.Transparent;
      this.toolStripCheckBoxEnsureFilteringEnabled.Checked = global::LLBLGen.EntityBrowser.Properties.Settings.Default.EnsureFilteringEnabled;
      this.toolStripCheckBoxEnsureFilteringEnabled.CheckState = System.Windows.Forms.CheckState.Unchecked;
      this.toolStripCheckBoxEnsureFilteringEnabled.Name = "toolStripCheckBoxEnsureFilteringEnabled";
      this.toolStripCheckBoxEnsureFilteringEnabled.Size = new System.Drawing.Size(152, 25);
      this.toolStripCheckBoxEnsureFilteringEnabled.Text = "Ensure Filtering Enabled";
      this.toolStripCheckBoxEnsureFilteringEnabled.ToolTipText = "Specifies whether filtering is enabled in the grid, even if the underlying collec" +
    "tion doesn\'t support it.";
      // 
      // toolStripNumericUpDownPageSize
      // 
      this.toolStripNumericUpDownPageSize.BackColor = System.Drawing.Color.Transparent;
      this.toolStripNumericUpDownPageSize.DecimalPlaces = 0;
      this.toolStripNumericUpDownPageSize.Name = "toolStripNumericUpDownPageSize";
      this.toolStripNumericUpDownPageSize.NumBackColor = System.Drawing.SystemColors.Window;
      this.toolStripNumericUpDownPageSize.Size = new System.Drawing.Size(118, 25);
      this.toolStripNumericUpDownPageSize.Text = "Page Size:";
      this.toolStripNumericUpDownPageSize.ToolTipText = "The number of rows per page in the grid. Zero to turn paging off.";
      this.toolStripNumericUpDownPageSize.Value = global::LLBLGen.EntityBrowser.Properties.Settings.Default.PageSize;
      // 
      // toolStripCheckBoxCascadeDeletes
      // 
      this.toolStripCheckBoxCascadeDeletes.BackColor = System.Drawing.Color.Transparent;
      this.toolStripCheckBoxCascadeDeletes.Checked = global::LLBLGen.EntityBrowser.Properties.Settings.Default.CascadeDeletes;
      this.toolStripCheckBoxCascadeDeletes.CheckState = System.Windows.Forms.CheckState.Unchecked;
      this.toolStripCheckBoxCascadeDeletes.Name = "toolStripCheckBoxCascadeDeletes";
      this.toolStripCheckBoxCascadeDeletes.Size = new System.Drawing.Size(111, 25);
      this.toolStripCheckBoxCascadeDeletes.Text = "Cascade Deletes";
      this.toolStripCheckBoxCascadeDeletes.ToolTipText = "Deletes cascade non-recursively to children of the selected entity.";
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.BackColor = System.Drawing.Color.Transparent;
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
      // 
      // toolStripNumericUpDownCommandTimeOut
      // 
      this.toolStripNumericUpDownCommandTimeOut.BackColor = System.Drawing.Color.Transparent;
      this.toolStripNumericUpDownCommandTimeOut.DecimalPlaces = 0;
      this.toolStripNumericUpDownCommandTimeOut.Name = "toolStripNumericUpDownCommandTimeOut";
      this.toolStripNumericUpDownCommandTimeOut.NumBackColor = System.Drawing.SystemColors.Window;
      this.toolStripNumericUpDownCommandTimeOut.Size = new System.Drawing.Size(176, 25);
      this.toolStripNumericUpDownCommandTimeOut.Text = "Command TimeOut:";
      this.toolStripNumericUpDownCommandTimeOut.ToolTipText = "The timeout value (in seconds) to use with the ADO.NET data fetching";
      this.toolStripNumericUpDownCommandTimeOut.Value = global::LLBLGen.EntityBrowser.Properties.Settings.Default.CommandTimeOut;
      // 
      // toolStripLabelOrmProfilerStatus
      // 
      this.toolStripLabelOrmProfilerStatus.BackColor = System.Drawing.Color.Transparent;
      this.toolStripLabelOrmProfilerStatus.Name = "toolStripLabelOrmProfilerStatus";
      this.toolStripLabelOrmProfilerStatus.Size = new System.Drawing.Size(101, 25);
      this.toolStripLabelOrmProfilerStatus.Text = "OrmProfilerStatus";
      // 
      // toolStripButtonAbout
      // 
      this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
      this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonAbout.Name = "toolStripButtonAbout";
      this.toolStripButtonAbout.Size = new System.Drawing.Size(44, 25);
      this.toolStripButtonAbout.Text = "About";
      this.toolStripButtonAbout.ToolTipText = "About";
      this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
      // 
      // FrmLLBLGenEntityBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1501, 588);
      this.ContextMenuStrip = this.contextMenuStripTabControl;
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.panelSettings);
      this.Controls.Add(this.panelMetaData);
      this.Controls.Add(this.toolStrip);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmLLBLGenEntityBrowser";
      this.Text = "Data Browser";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.contextMenuStripTabControl.ResumeLayout(false);
      this.panelSettings.ResumeLayout(false);
      this.panelSettings.PerformLayout();
      this.panelMetaData.ResumeLayout(false);
      this.panelMetaData.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.contextMenuStripTabPage.ResumeLayout(false);
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.Panel panelSettings;
    private System.Windows.Forms.TextBox adapterAssemblyPathTextBox;
    private System.Windows.Forms.TextBox linqMetaDataAssemblyPathTextBox;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripTabControl;
    private System.Windows.Forms.ToolStripMenuItem addConnectionToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripTabPage;
    private System.Windows.Forms.ToolStripMenuItem addConnectionToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editConnectionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    private System.Windows.Forms.LinkLabel linqMetaDataAssemblyPathLabel;
    private System.Windows.Forms.LinkLabel adapterAssemblyPathLabel;
    private System.Windows.Forms.ToolStripMenuItem toggleSettingsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem toggleSettingsVisibilityToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Panel panelMetaData;
    private System.Windows.Forms.Label labellinqMetaDataAssemblyVersion;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.ToolStripButton toolStripButtonAddConnection;
    private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
    public System.Windows.Forms.ToolStripButton toolStripButtonCancelEdit;
    private System.Windows.Forms.ToolStripButton saveToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBoxTablePrefixDelimiter;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private AW.Winforms.Helpers.Controls.ToolStripCheckBox toolStripCheckBoxUseSchema;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private AW.Winforms.Helpers.Controls.ToolStripCheckBox toolStripCheckBoxUseContext;
    private AW.Winforms.Helpers.Controls.ToolStripNumericUpDown toolStripNumericUpDownCacheDurationInSeconds;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private AW.Winforms.Helpers.Controls.ToolStripCheckBox toolStripCheckBoxEnsureFilteringEnabled;
    private AW.Winforms.Helpers.Controls.ToolStripNumericUpDown toolStripNumericUpDownPageSize;
    private AW.Winforms.Helpers.Controls.ToolStripCheckBox toolStripCheckBoxCascadeDeletes;
    private AW.Winforms.Helpers.Controls.ToolStripNumericUpDown toolStripNumericUpDownCommandTimeOut;
    private System.Windows.Forms.ToolStripLabel toolStripLabelOrmProfilerStatus;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
  }
}

