namespace LLBLGen.EntityBrowser
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.linqMetaDataAssemblyPathLabel = new System.Windows.Forms.LinkLabel();
      this.adapterAssemblyPathLabel = new System.Windows.Forms.LinkLabel();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonAddConnection = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.contextMenuStripTabControl = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.toggleSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panelSettings = new System.Windows.Forms.Panel();
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
      this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      cacheDurationInSecondsLabel = new System.Windows.Forms.Label();
      prefixDelimiterLabel = new System.Windows.Forms.Label();
      this.toolStrip1.SuspendLayout();
      this.contextMenuStripTabControl.SuspendLayout();
      this.panelSettings.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPageSize)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cacheDurationInSecondsNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
      this.contextMenuStripTabPage.SuspendLayout();
      this.SuspendLayout();
      // 
      // cacheDurationInSecondsLabel
      // 
      cacheDurationInSecondsLabel.AutoSize = true;
      cacheDurationInSecondsLabel.Location = new System.Drawing.Point(97, 81);
      cacheDurationInSecondsLabel.Name = "cacheDurationInSecondsLabel";
      cacheDurationInSecondsLabel.Size = new System.Drawing.Size(141, 13);
      cacheDurationInSecondsLabel.TabIndex = 6;
      cacheDurationInSecondsLabel.Text = "Cache Duration In Seconds:";
      // 
      // prefixDelimiterLabel
      // 
      prefixDelimiterLabel.AutoSize = true;
      prefixDelimiterLabel.Location = new System.Drawing.Point(455, 77);
      prefixDelimiterLabel.Name = "prefixDelimiterLabel";
      prefixDelimiterLabel.Size = new System.Drawing.Size(79, 13);
      prefixDelimiterLabel.TabIndex = 10;
      prefixDelimiterLabel.Text = "Prefix Delimiter:";
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
            this.toolStripMenuItem2,
            this.toggleSettingsToolStripMenuItem});
      this.contextMenuStripTabControl.Name = "contextMenuStripTabControl";
      this.contextMenuStripTabControl.Size = new System.Drawing.Size(162, 70);
      // 
      // addConnectionToolStripMenuItem
      // 
      this.addConnectionToolStripMenuItem.Name = "addConnectionToolStripMenuItem";
      this.addConnectionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.addConnectionToolStripMenuItem.Text = "Add Connection";
      this.addConnectionToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonAddConnection_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
      this.toolStripMenuItem2.Text = "_";
      // 
      // toggleSettingsToolStripMenuItem
      // 
      this.toggleSettingsToolStripMenuItem.Name = "toggleSettingsToolStripMenuItem";
      this.toggleSettingsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.toggleSettingsToolStripMenuItem.Text = "Toggle Settings";
      this.toggleSettingsToolStripMenuItem.Click += new System.EventHandler(this.toggleSettingsToolStripMenuItem_Click);
      // 
      // panelSettings
      // 
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(774, 76);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 13);
      this.label1.TabIndex = 16;
      this.label1.Text = "PageSize";
      // 
      // numericUpDownPageSize
      // 
      this.numericUpDownPageSize.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "PageSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.numericUpDownPageSize.Location = new System.Drawing.Point(841, 74);
      this.numericUpDownPageSize.Name = "numericUpDownPageSize";
      this.numericUpDownPageSize.Size = new System.Drawing.Size(54, 20);
      this.numericUpDownPageSize.TabIndex = 15;
      this.numericUpDownPageSize.Value = global::LLBLGen.EntityBrowser.Properties.Settings.Default.PageSize;
      // 
      // cacheDurationInSecondsNumericUpDown
      // 
      this.cacheDurationInSecondsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "CacheDurationInSeconds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.cacheDurationInSecondsNumericUpDown.Location = new System.Drawing.Point(244, 80);
      this.cacheDurationInSecondsNumericUpDown.Name = "cacheDurationInSecondsNumericUpDown";
      this.cacheDurationInSecondsNumericUpDown.Size = new System.Drawing.Size(49, 20);
      this.cacheDurationInSecondsNumericUpDown.TabIndex = 14;
      this.cacheDurationInSecondsNumericUpDown.Value = global::LLBLGen.EntityBrowser.Properties.Settings.Default.CacheDurationInSeconds;
      // 
      // ensureFilteringEnabledCheckBox
      // 
      this.ensureFilteringEnabledCheckBox.Checked = global::LLBLGen.EntityBrowser.Properties.Settings.Default.EnsureFilteringEnabled;
      this.ensureFilteringEnabledCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "EnsureFilteringEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.ensureFilteringEnabledCheckBox.Location = new System.Drawing.Point(663, 76);
      this.ensureFilteringEnabledCheckBox.Name = "ensureFilteringEnabledCheckBox";
      this.ensureFilteringEnabledCheckBox.Size = new System.Drawing.Size(104, 24);
      this.ensureFilteringEnabledCheckBox.TabIndex = 13;
      this.ensureFilteringEnabledCheckBox.Text = "Ensure Filtering Enabled";
      this.ensureFilteringEnabledCheckBox.UseVisualStyleBackColor = true;
      // 
      // prefixDelimiterTextBox
      // 
      this.prefixDelimiterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "PrefixDelimiter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.prefixDelimiterTextBox.Location = new System.Drawing.Point(540, 74);
      this.prefixDelimiterTextBox.Name = "prefixDelimiterTextBox";
      this.prefixDelimiterTextBox.Size = new System.Drawing.Size(100, 20);
      this.prefixDelimiterTextBox.TabIndex = 11;
      this.prefixDelimiterTextBox.Text = global::LLBLGen.EntityBrowser.Properties.Settings.Default.PrefixDelimiter;
      // 
      // useSchemaCheckBox
      // 
      this.useSchemaCheckBox.Checked = global::LLBLGen.EntityBrowser.Properties.Settings.Default.UseSchema;
      this.useSchemaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.useSchemaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "UseSchema", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.useSchemaCheckBox.Location = new System.Drawing.Point(345, 76);
      this.useSchemaCheckBox.Name = "useSchemaCheckBox";
      this.useSchemaCheckBox.Size = new System.Drawing.Size(104, 24);
      this.useSchemaCheckBox.TabIndex = 9;
      this.useSchemaCheckBox.Text = "Use Schema";
      this.useSchemaCheckBox.UseVisualStyleBackColor = true;
      // 
      // useContextCheckBox
      // 
      this.useContextCheckBox.Checked = global::LLBLGen.EntityBrowser.Properties.Settings.Default.UseContext;
      this.useContextCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.useContextCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LLBLGen.EntityBrowser.Properties.Settings.Default, "UseContext", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.useContextCheckBox.Location = new System.Drawing.Point(6, 78);
      this.useContextCheckBox.Name = "useContextCheckBox";
      this.useContextCheckBox.Size = new System.Drawing.Size(104, 24);
      this.useContextCheckBox.TabIndex = 5;
      this.useContextCheckBox.Text = "Use Context";
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
      // 
      // contextMenuStripTabPage
      // 
      this.contextMenuStripTabPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConnectionToolStripMenuItem1,
            this.removeToolStripMenuItem,
            this.editConnectionToolStripMenuItem,
            this.renameToolStripMenuItem});
      this.contextMenuStripTabPage.Name = "contextMenuStripTabPage";
      this.contextMenuStripTabPage.Size = new System.Drawing.Size(162, 92);
      // 
      // addConnectionToolStripMenuItem1
      // 
      this.addConnectionToolStripMenuItem1.Name = "addConnectionToolStripMenuItem1";
      this.addConnectionToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
      this.addConnectionToolStripMenuItem1.Text = "Add Connection";
      this.addConnectionToolStripMenuItem1.Click += new System.EventHandler(this.toolStripButtonAddConnection_Click);
      // 
      // removeToolStripMenuItem
      // 
      this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
      this.removeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.removeToolStripMenuItem.Text = "Remove";
      this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
      // 
      // editConnectionToolStripMenuItem
      // 
      this.editConnectionToolStripMenuItem.Name = "editConnectionToolStripMenuItem";
      this.editConnectionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.editConnectionToolStripMenuItem.Text = "Edit Connection";
      this.editConnectionToolStripMenuItem.Click += new System.EventHandler(this.editConnectionToolStripMenuItem_Click);
      // 
      // renameToolStripMenuItem
      // 
      this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
      this.renameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.renameToolStripMenuItem.Text = "Rename";
      this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1181, 588);
      this.ContextMenuStrip = this.contextMenuStripTabControl;
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.panelSettings);
      this.Controls.Add(this.toolStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "Data Browser";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.contextMenuStripTabControl.ResumeLayout(false);
      this.panelSettings.ResumeLayout(false);
      this.panelSettings.PerformLayout();
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
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem toggleSettingsToolStripMenuItem;
    private System.Windows.Forms.CheckBox ensureFilteringEnabledCheckBox;
    private System.Windows.Forms.TextBox prefixDelimiterTextBox;
    private System.Windows.Forms.CheckBox useSchemaCheckBox;
    private System.Windows.Forms.CheckBox useContextCheckBox;
    private System.Windows.Forms.NumericUpDown cacheDurationInSecondsNumericUpDown;
    private System.Windows.Forms.NumericUpDown numericUpDownPageSize;
    private System.Windows.Forms.Label label1;
  }
}

