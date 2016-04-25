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
      System.Windows.Forms.Label cacheDurationInSecondsLabel;
      System.Windows.Forms.Label prefixDelimiterLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLLBLGenEntityBrowser));
      this.linqMetaDataAssemblyPathLabel = new System.Windows.Forms.LinkLabel();
      this.adapterAssemblyPathLabel = new System.Windows.Forms.LinkLabel();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonAddConnection = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.contextMenuStripTabControl = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toggleSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panelSettings = new System.Windows.Forms.Panel();
      this.checkBoxCascadeDeletes = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.numericUpDownCommandTimeOut = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.numericUpDownPageSize = new System.Windows.Forms.NumericUpDown();
      this.cacheDurationInSecondsNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.ensureFilteringEnabledCheckBox = new System.Windows.Forms.CheckBox();
      this.prefixDelimiterTextBox = new System.Windows.Forms.TextBox();
      this.useSchemaCheckBox = new System.Windows.Forms.CheckBox();
      this.useContextCheckBox = new System.Windows.Forms.CheckBox();
      this.adapterAssemblyPathTextBox = new System.Windows.Forms.TextBox();
      this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.linqMetaDataAssemblyPathTextBox = new System.Windows.Forms.TextBox();
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
      cacheDurationInSecondsLabel = new System.Windows.Forms.Label();
      prefixDelimiterLabel = new System.Windows.Forms.Label();
      this.toolStrip1.SuspendLayout();
      this.contextMenuStripTabControl.SuspendLayout();
      this.panelSettings.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCommandTimeOut)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPageSize)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cacheDurationInSecondsNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
      this.contextMenuStripTabPage.SuspendLayout();
      this.SuspendLayout();
      // 
      // cacheDurationInSecondsLabel
      // 
      cacheDurationInSecondsLabel.AutoSize = true;
      cacheDurationInSecondsLabel.Location = new System.Drawing.Point(98, 78);
      cacheDurationInSecondsLabel.Name = "cacheDurationInSecondsLabel";
      cacheDurationInSecondsLabel.Size = new System.Drawing.Size(141, 13);
      cacheDurationInSecondsLabel.TabIndex = 6;
      cacheDurationInSecondsLabel.Text = "Cache Duration In Seconds:";
      this.toolTip1.SetToolTip(cacheDurationInSecondsLabel, "Specifies the duration that the query\'s result set should be cached for. Zero to " +
        "turn caching off.");
      // 
      // prefixDelimiterLabel
      // 
      prefixDelimiterLabel.AutoSize = true;
      prefixDelimiterLabel.Location = new System.Drawing.Point(397, 78);
      prefixDelimiterLabel.Name = "prefixDelimiterLabel";
      prefixDelimiterLabel.Size = new System.Drawing.Size(79, 13);
      prefixDelimiterLabel.TabIndex = 10;
      prefixDelimiterLabel.Text = "Prefix Delimiter:";
      this.toolTip1.SetToolTip(prefixDelimiterLabel, "Table Prefix Delimiter to group Entities by (e.g. with a delimiter of _ table Sal" +
        "es_Order would grouped into a node called Sales)");
      // 
      // linqMetaDataAssemblyPathLabel
      // 
      this.linqMetaDataAssemblyPathLabel.AutoSize = true;
      this.linqMetaDataAssemblyPathLabel.Location = new System.Drawing.Point(3, 17);
      this.linqMetaDataAssemblyPathLabel.Name = "linqMetaDataAssemblyPathLabel";
      this.linqMetaDataAssemblyPathLabel.Size = new System.Drawing.Size(155, 13);
      this.linqMetaDataAssemblyPathLabel.TabIndex = 0;
      this.linqMetaDataAssemblyPathLabel.TabStop = true;
      this.linqMetaDataAssemblyPathLabel.Text = "Linq Meta Data Assembly Path:";
      this.toolTip1.SetToolTip(this.linqMetaDataAssemblyPathLabel, "Path to a LLBLGen Pro generated assembly containing an ILinqMetaData implementati" +
        "on");
      this.linqMetaDataAssemblyPathLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linqMetaDataAssemblyPathLabel_LinkClicked);
      // 
      // adapterAssemblyPathLabel
      // 
      this.adapterAssemblyPathLabel.AutoSize = true;
      this.adapterAssemblyPathLabel.Location = new System.Drawing.Point(3, 39);
      this.adapterAssemblyPathLabel.Name = "adapterAssemblyPathLabel";
      this.adapterAssemblyPathLabel.Size = new System.Drawing.Size(119, 13);
      this.adapterAssemblyPathLabel.TabIndex = 2;
      this.adapterAssemblyPathLabel.TabStop = true;
      this.adapterAssemblyPathLabel.Text = "Adapter Assembly Path:";
      this.toolTip1.SetToolTip(this.adapterAssemblyPathLabel, "Path to Adapter assembly");
      this.adapterAssemblyPathLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linqMetaDataAssemblyPathLabel_LinkClicked);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddConnection,
            this.toolStripButtonLoad});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(714, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      this.toolStrip1.Visible = false;
      // 
      // toolStripButtonAddConnection
      // 
      this.toolStripButtonAddConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonAddConnection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddConnection.Image")));
      this.toolStripButtonAddConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonAddConnection.Name = "toolStripButtonAddConnection";
      this.toolStripButtonAddConnection.Size = new System.Drawing.Size(33, 22);
      this.toolStripButtonAddConnection.Text = "Add";
      this.toolStripButtonAddConnection.Click += new System.EventHandler(this.toolStripButtonAddConnection_Click);
      // 
      // toolStripButtonLoad
      // 
      this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoad.Image")));
      this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonLoad.Name = "toolStripButtonLoad";
      this.toolStripButtonLoad.Size = new System.Drawing.Size(37, 22);
      this.toolStripButtonLoad.Text = "Load";
      this.toolStripButtonLoad.Click += new System.EventHandler(this.toolStripButtonLoad_Click);
      // 
      // tabControl
      // 
      this.tabControl.ContextMenuStrip = this.contextMenuStripTabControl;
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 105);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(1181, 483);
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
      this.panelSettings.Controls.Add(this.checkBoxCascadeDeletes);
      this.panelSettings.Controls.Add(this.label2);
      this.panelSettings.Controls.Add(this.numericUpDownCommandTimeOut);
      this.panelSettings.Controls.Add(this.label1);
      this.panelSettings.Controls.Add(this.numericUpDownPageSize);
      this.panelSettings.Controls.Add(this.cacheDurationInSecondsNumericUpDown);
      this.panelSettings.Controls.Add(this.ensureFilteringEnabledCheckBox);
      this.panelSettings.Controls.Add(prefixDelimiterLabel);
      this.panelSettings.Controls.Add(this.prefixDelimiterTextBox);
      this.panelSettings.Controls.Add(this.useSchemaCheckBox);
      this.panelSettings.Controls.Add(cacheDurationInSecondsLabel);
      this.panelSettings.Controls.Add(this.useContextCheckBox);
      this.panelSettings.Controls.Add(this.adapterAssemblyPathLabel);
      this.panelSettings.Controls.Add(this.adapterAssemblyPathTextBox);
      this.panelSettings.Controls.Add(this.linqMetaDataAssemblyPathLabel);
      this.panelSettings.Controls.Add(this.linqMetaDataAssemblyPathTextBox);
      this.panelSettings.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelSettings.Location = new System.Drawing.Point(0, 0);
      this.panelSettings.Name = "panelSettings";
      this.panelSettings.Size = new System.Drawing.Size(1181, 105);
      this.panelSettings.TabIndex = 2;
      this.panelSettings.Visible = false;
      // 
      // checkBoxCascadeDeletes
      // 
      this.checkBoxCascadeDeletes.AutoSize = true;
      this.checkBoxCascadeDeletes.Checked = global::LLBLGen.EntityBrowser.Properties.Settings.Default.CascadeDeletes;
      this.checkBoxCascadeDeletes.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "CascadeDeletes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxCascadeDeletes.Location = new System.Drawing.Point(813, 74);
      this.checkBoxCascadeDeletes.Name = "checkBoxCascadeDeletes";
      this.checkBoxCascadeDeletes.Size = new System.Drawing.Size(107, 17);
      this.checkBoxCascadeDeletes.TabIndex = 19;
      this.checkBoxCascadeDeletes.Text = "Cascade Deletes";
      this.toolTip1.SetToolTip(this.checkBoxCascadeDeletes, "Deletes cascade non-recursively to children of the selected entity.");
      this.checkBoxCascadeDeletes.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(922, 74);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(97, 13);
      this.label2.TabIndex = 18;
      this.label2.Text = "Command TimeOut";
      this.toolTip1.SetToolTip(this.label2, "The timeout value to use with the ADO.NET data fetching");
      // 
      // numericUpDownCommandTimeOut
      // 
      this.numericUpDownCommandTimeOut.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "CommandTimeOut", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.numericUpDownCommandTimeOut.Location = new System.Drawing.Point(1026, 70);
      this.numericUpDownCommandTimeOut.Name = "numericUpDownCommandTimeOut";
      this.numericUpDownCommandTimeOut.Size = new System.Drawing.Size(42, 20);
      this.numericUpDownCommandTimeOut.TabIndex = 17;
      this.toolTip1.SetToolTip(this.numericUpDownCommandTimeOut, "The timeout value to use with the ADO.NET data fetching");
      this.numericUpDownCommandTimeOut.Value = global::LLBLGen.EntityBrowser.Properties.Settings.Default.CommandTimeOut;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(694, 77);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 13);
      this.label1.TabIndex = 16;
      this.label1.Text = "PageSize";
      this.toolTip1.SetToolTip(this.label1, "The number of rows per page in the grid. Zero to turn paging off.");
      // 
      // numericUpDownPageSize
      // 
      this.numericUpDownPageSize.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "PageSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.numericUpDownPageSize.Location = new System.Drawing.Point(753, 73);
      this.numericUpDownPageSize.Name = "numericUpDownPageSize";
      this.numericUpDownPageSize.Size = new System.Drawing.Size(54, 20);
      this.numericUpDownPageSize.TabIndex = 15;
      this.toolTip1.SetToolTip(this.numericUpDownPageSize, "The number of rows per page in the grid. Zero to turn paging off.");
      this.numericUpDownPageSize.Value = global::LLBLGen.EntityBrowser.Properties.Settings.Default.PageSize;
      // 
      // cacheDurationInSecondsNumericUpDown
      // 
      this.cacheDurationInSecondsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "CacheDurationInSeconds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.cacheDurationInSecondsNumericUpDown.Location = new System.Drawing.Point(246, 74);
      this.cacheDurationInSecondsNumericUpDown.Name = "cacheDurationInSecondsNumericUpDown";
      this.cacheDurationInSecondsNumericUpDown.Size = new System.Drawing.Size(49, 20);
      this.cacheDurationInSecondsNumericUpDown.TabIndex = 14;
      this.toolTip1.SetToolTip(this.cacheDurationInSecondsNumericUpDown, "Specifies the duration that the query\'s result set should be cached for. Zero to " +
        "turn caching off.");
      this.cacheDurationInSecondsNumericUpDown.Value = global::LLBLGen.EntityBrowser.Properties.Settings.Default.CacheDurationInSeconds;
      // 
      // ensureFilteringEnabledCheckBox
      // 
      this.ensureFilteringEnabledCheckBox.Checked = global::LLBLGen.EntityBrowser.Properties.Settings.Default.EnsureFilteringEnabled;
      this.ensureFilteringEnabledCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "EnsureFilteringEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.ensureFilteringEnabledCheckBox.Location = new System.Drawing.Point(545, 71);
      this.ensureFilteringEnabledCheckBox.Name = "ensureFilteringEnabledCheckBox";
      this.ensureFilteringEnabledCheckBox.Size = new System.Drawing.Size(142, 24);
      this.ensureFilteringEnabledCheckBox.TabIndex = 13;
      this.ensureFilteringEnabledCheckBox.Text = "Ensure Filtering Enabled";
      this.toolTip1.SetToolTip(this.ensureFilteringEnabledCheckBox, "Specifies whether filtering is enabled in the grid, even if the underlying collec" +
        "tion doesn\'t support it.");
      this.ensureFilteringEnabledCheckBox.UseVisualStyleBackColor = true;
      // 
      // prefixDelimiterTextBox
      // 
      this.prefixDelimiterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "PrefixDelimiter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.prefixDelimiterTextBox.Location = new System.Drawing.Point(483, 74);
      this.prefixDelimiterTextBox.Name = "prefixDelimiterTextBox";
      this.prefixDelimiterTextBox.Size = new System.Drawing.Size(56, 20);
      this.prefixDelimiterTextBox.TabIndex = 11;
      this.prefixDelimiterTextBox.Text = global::LLBLGen.EntityBrowser.Properties.Settings.Default.PrefixDelimiter;
      this.toolTip1.SetToolTip(this.prefixDelimiterTextBox, "Table Prefix Delimiter to group Entities by (e.g. with a delimiter of _ table Sal" +
        "es_Order would grouped into a node called Sales)");
      // 
      // useSchemaCheckBox
      // 
      this.useSchemaCheckBox.Checked = global::LLBLGen.EntityBrowser.Properties.Settings.Default.UseSchema;
      this.useSchemaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.useSchemaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "UseSchema", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.useSchemaCheckBox.Location = new System.Drawing.Point(302, 72);
      this.useSchemaCheckBox.Name = "useSchemaCheckBox";
      this.useSchemaCheckBox.Size = new System.Drawing.Size(88, 24);
      this.useSchemaCheckBox.TabIndex = 9;
      this.useSchemaCheckBox.Text = "Use Schema";
      this.toolTip1.SetToolTip(this.useSchemaCheckBox, "Use Table Schema to group the Entities");
      this.useSchemaCheckBox.UseVisualStyleBackColor = true;
      // 
      // useContextCheckBox
      // 
      this.useContextCheckBox.Checked = global::LLBLGen.EntityBrowser.Properties.Settings.Default.UseContext;
      this.useContextCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.useContextCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "UseContext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.useContextCheckBox.Location = new System.Drawing.Point(6, 72);
      this.useContextCheckBox.Name = "useContextCheckBox";
      this.useContextCheckBox.Size = new System.Drawing.Size(85, 24);
      this.useContextCheckBox.TabIndex = 5;
      this.useContextCheckBox.Text = "Use Context";
      this.toolTip1.SetToolTip(this.useContextCheckBox, resources.GetString("useContextCheckBox.ToolTip"));
      this.useContextCheckBox.UseVisualStyleBackColor = true;
      // 
      // adapterAssemblyPathTextBox
      // 
      this.adapterAssemblyPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.adapterAssemblyPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "AdapterAssemblyPath", true));
      this.adapterAssemblyPathTextBox.Location = new System.Drawing.Point(128, 39);
      this.adapterAssemblyPathTextBox.Name = "adapterAssemblyPathTextBox";
      this.adapterAssemblyPathTextBox.Size = new System.Drawing.Size(1053, 20);
      this.adapterAssemblyPathTextBox.TabIndex = 3;
      // 
      // settingsBindingSource
      // 
      this.settingsBindingSource.DataSource = typeof(System.Configuration.ApplicationSettingsBase);
      // 
      // linqMetaDataAssemblyPathTextBox
      // 
      this.linqMetaDataAssemblyPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.linqMetaDataAssemblyPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "LinqMetaDataAssemblyPath", true));
      this.linqMetaDataAssemblyPathTextBox.Location = new System.Drawing.Point(164, 10);
      this.linqMetaDataAssemblyPathTextBox.Name = "linqMetaDataAssemblyPathTextBox";
      this.linqMetaDataAssemblyPathTextBox.Size = new System.Drawing.Size(1017, 20);
      this.linqMetaDataAssemblyPathTextBox.TabIndex = 1;
      this.toolTip1.SetToolTip(this.linqMetaDataAssemblyPathTextBox, "Path to a LLBLGen Pro generated assembly containing an ILinqMetaData implementati" +
        "on");
      this.linqMetaDataAssemblyPathTextBox.Leave += new System.EventHandler(this.linqMetaDataAssemblyPathTextBox_Leave);
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
      // FrmLLBLGenEntityBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1181, 588);
      this.ContextMenuStrip = this.contextMenuStripTabControl;
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.panelSettings);
      this.Controls.Add(this.toolStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmLLBLGenEntityBrowser";
      this.Text = "Data Browser";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.contextMenuStripTabControl.ResumeLayout(false);
      this.panelSettings.ResumeLayout(false);
      this.panelSettings.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCommandTimeOut)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPageSize)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cacheDurationInSecondsNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
      this.contextMenuStripTabPage.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButtonAddConnection;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.Panel panelSettings;
    private System.Windows.Forms.TextBox adapterAssemblyPathTextBox;
    private System.Windows.Forms.BindingSource settingsBindingSource;
    private System.Windows.Forms.TextBox linqMetaDataAssemblyPathTextBox;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripTabControl;
    private System.Windows.Forms.ToolStripMenuItem addConnectionToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripTabPage;
    private System.Windows.Forms.ToolStripMenuItem addConnectionToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editConnectionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
    private System.Windows.Forms.LinkLabel linqMetaDataAssemblyPathLabel;
    private System.Windows.Forms.LinkLabel adapterAssemblyPathLabel;
    private System.Windows.Forms.ToolStripMenuItem toggleSettingsToolStripMenuItem;
    private System.Windows.Forms.CheckBox ensureFilteringEnabledCheckBox;
    private System.Windows.Forms.TextBox prefixDelimiterTextBox;
    private System.Windows.Forms.CheckBox useSchemaCheckBox;
    private System.Windows.Forms.CheckBox useContextCheckBox;
    private System.Windows.Forms.NumericUpDown cacheDurationInSecondsNumericUpDown;
    private System.Windows.Forms.NumericUpDown numericUpDownPageSize;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem toggleSettingsVisibilityToolStripMenuItem;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDownCommandTimeOut;
    private System.Windows.Forms.CheckBox checkBoxCascadeDeletes;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}

