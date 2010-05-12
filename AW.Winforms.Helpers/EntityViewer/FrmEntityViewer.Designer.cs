namespace AW.Winforms.Helpers.EntityViewer
{
  partial class FrmEntityViewer
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
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.selectObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyObjectRefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageBrowser = new System.Windows.Forms.TabPage();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.ObjectBrowser = new sliver.Windows.Forms.StateBrowser();
      this.splitContainerValues = new System.Windows.Forms.SplitContainer();
      this.panel1 = new System.Windows.Forms.Panel();
      this.textBoxObjectBeingBrowsed = new System.Windows.Forms.TextBox();
      this.checkBoxShowNonPublicMembers = new System.Windows.Forms.CheckBox();
      this.checkBoxShowStaticMembers = new System.Windows.Forms.CheckBox();
      this.checkBoxShowDataTypes = new System.Windows.Forms.CheckBox();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabelInstance = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabelSelectePath = new System.Windows.Forms.ToolStripStatusLabel();
      this.propertyGrid1 = new AW.Winforms.Helpers.PropGridEx.PropertyGridEx();
      this.gridDataEditor = new AW.Winforms.Helpers.Controls.GridDataEditor();
      this.contextMenuStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPageBrowser.SuspendLayout();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.splitContainerValues.Panel1.SuspendLayout();
      this.splitContainerValues.Panel2.SuspendLayout();
      this.splitContainerValues.SuspendLayout();
      this.panel1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectObjectToolStripMenuItem,
            this.copyObjectRefToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(166, 48);
      // 
      // selectObjectToolStripMenuItem
      // 
      this.selectObjectToolStripMenuItem.Name = "selectObjectToolStripMenuItem";
      this.selectObjectToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
      this.selectObjectToolStripMenuItem.Text = "SelectObject";
      this.selectObjectToolStripMenuItem.Click += new System.EventHandler(this.selectObjectToolStripMenuItem_Click);
      // 
      // copyObjectRefToolStripMenuItem
      // 
      this.copyObjectRefToolStripMenuItem.Name = "copyObjectRefToolStripMenuItem";
      this.copyObjectRefToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
      this.copyObjectRefToolStripMenuItem.Text = "Copy Object Ref";
      this.copyObjectRefToolStripMenuItem.Click += new System.EventHandler(this.copyObjectRefToolStripMenuItem_Click);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "CurrentValue";
      this.dataGridViewTextBoxColumn1.HeaderText = "CurrentValue";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.Width = 93;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "DbValue";
      this.dataGridViewTextBoxColumn2.HeaderText = "DbValue";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 73;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "CurrentValue";
      this.dataGridViewTextBoxColumn3.HeaderText = "CurrentValue";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.Width = 93;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "DbValue";
      this.dataGridViewTextBoxColumn4.HeaderText = "DbValue";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 73;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "CurrentValue";
      this.dataGridViewTextBoxColumn5.HeaderText = "CurrentValue";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.Width = 93;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "DbValue";
      this.dataGridViewTextBoxColumn6.HeaderText = "DbValue";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Width = 73;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.DataPropertyName = "CurrentValue";
      this.dataGridViewTextBoxColumn7.HeaderText = "CurrentValue";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.Width = 93;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "DbValue";
      this.dataGridViewTextBoxColumn8.HeaderText = "DbValue";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.ReadOnly = true;
      this.dataGridViewTextBoxColumn8.Width = 73;
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.DataPropertyName = "CurrentValue";
      this.dataGridViewTextBoxColumn9.HeaderText = "CurrentValue";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn9.Width = 93;
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.DataPropertyName = "DbValue";
      this.dataGridViewTextBoxColumn10.HeaderText = "DbValue";
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      this.dataGridViewTextBoxColumn10.ReadOnly = true;
      this.dataGridViewTextBoxColumn10.Width = 73;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageBrowser);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1031, 540);
      this.tabControl1.TabIndex = 1;
      // 
      // tabPageBrowser
      // 
      this.tabPageBrowser.Controls.Add(this.splitContainer1);
      this.tabPageBrowser.Location = new System.Drawing.Point(4, 22);
      this.tabPageBrowser.Name = "tabPageBrowser";
      this.tabPageBrowser.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageBrowser.Size = new System.Drawing.Size(1023, 514);
      this.tabPageBrowser.TabIndex = 0;
      this.tabPageBrowser.Text = "Browser";
      this.tabPageBrowser.UseVisualStyleBackColor = true;
      // 
      // splitContainer1
      // 
      this.splitContainer1.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::AW.Winforms.Helpers.Properties.Settings.Default, "FrmEntityViewerSplitterDistance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(3, 3);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.ObjectBrowser);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.splitContainerValues);
      this.splitContainer1.Size = new System.Drawing.Size(1017, 508);
      this.splitContainer1.SplitterDistance = global::AW.Winforms.Helpers.Properties.Settings.Default.FrmEntityViewerSplitterDistance;
      this.splitContainer1.TabIndex = 2;
      // 
      // ObjectBrowser
      // 
      this.ObjectBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ObjectBrowser.Location = new System.Drawing.Point(0, 0);
      this.ObjectBrowser.Name = "ObjectBrowser";
      this.ObjectBrowser.ObjectToBrowse = null;
      this.ObjectBrowser.Size = new System.Drawing.Size(462, 508);
      this.ObjectBrowser.TabIndex = 0;
      this.ObjectBrowser.NodeSelected += new System.EventHandler(this.ObjectBrowser_NodeSelected);
      // 
      // splitContainerValues
      // 
      this.splitContainerValues.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerValues.Location = new System.Drawing.Point(0, 0);
      this.splitContainerValues.Name = "splitContainerValues";
      this.splitContainerValues.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainerValues.Panel1
      // 
      this.splitContainerValues.Panel1.Controls.Add(this.propertyGrid1);
      this.splitContainerValues.Panel1.Controls.Add(this.panel1);
      // 
      // splitContainerValues.Panel2
      // 
      this.splitContainerValues.Panel2.Controls.Add(this.gridDataEditor);
      this.splitContainerValues.Size = new System.Drawing.Size(551, 508);
      this.splitContainerValues.SplitterDistance = 254;
      this.splitContainerValues.TabIndex = 3;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.textBoxObjectBeingBrowsed);
      this.panel1.Controls.Add(this.checkBoxShowNonPublicMembers);
      this.panel1.Controls.Add(this.checkBoxShowStaticMembers);
      this.panel1.Controls.Add(this.checkBoxShowDataTypes);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(551, 63);
      this.panel1.TabIndex = 1;
      // 
      // textBoxObjectBeingBrowsed
      // 
      this.textBoxObjectBeingBrowsed.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.textBoxObjectBeingBrowsed.Location = new System.Drawing.Point(0, 43);
      this.textBoxObjectBeingBrowsed.Name = "textBoxObjectBeingBrowsed";
      this.textBoxObjectBeingBrowsed.Size = new System.Drawing.Size(551, 20);
      this.textBoxObjectBeingBrowsed.TabIndex = 3;
      // 
      // checkBoxShowNonPublicMembers
      // 
      this.checkBoxShowNonPublicMembers.AutoSize = true;
      this.checkBoxShowNonPublicMembers.Checked = global::AW.Winforms.Helpers.Properties.Settings.Default.ShowNonPublicMembers;
      this.checkBoxShowNonPublicMembers.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Winforms.Helpers.Properties.Settings.Default, "ShowNonPublicMembers", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxShowNonPublicMembers.Location = new System.Drawing.Point(138, 3);
      this.checkBoxShowNonPublicMembers.Name = "checkBoxShowNonPublicMembers";
      this.checkBoxShowNonPublicMembers.Size = new System.Drawing.Size(145, 17);
      this.checkBoxShowNonPublicMembers.TabIndex = 2;
      this.checkBoxShowNonPublicMembers.Text = "ShowNonPublicMembers";
      this.checkBoxShowNonPublicMembers.UseVisualStyleBackColor = true;
      this.checkBoxShowNonPublicMembers.CheckedChanged += new System.EventHandler(this.checkBoxShowNonPublicMembers_CheckedChanged);
      // 
      // checkBoxShowStaticMembers
      // 
      this.checkBoxShowStaticMembers.AutoSize = true;
      this.checkBoxShowStaticMembers.Checked = global::AW.Winforms.Helpers.Properties.Settings.Default.ShowStaticMembers;
      this.checkBoxShowStaticMembers.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Winforms.Helpers.Properties.Settings.Default, "ShowStaticMembers", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxShowStaticMembers.Location = new System.Drawing.Point(309, 3);
      this.checkBoxShowStaticMembers.Name = "checkBoxShowStaticMembers";
      this.checkBoxShowStaticMembers.Size = new System.Drawing.Size(123, 17);
      this.checkBoxShowStaticMembers.TabIndex = 1;
      this.checkBoxShowStaticMembers.Text = "ShowStaticMembers";
      this.checkBoxShowStaticMembers.UseVisualStyleBackColor = true;
      this.checkBoxShowStaticMembers.CheckedChanged += new System.EventHandler(this.checkBoxShowStaticMembers_CheckedChanged);
      // 
      // checkBoxShowDataTypes
      // 
      this.checkBoxShowDataTypes.AutoSize = true;
      this.checkBoxShowDataTypes.Checked = global::AW.Winforms.Helpers.Properties.Settings.Default.ShowDataTypes;
      this.checkBoxShowDataTypes.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Winforms.Helpers.Properties.Settings.Default, "ShowDataTypes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxShowDataTypes.Location = new System.Drawing.Point(3, 3);
      this.checkBoxShowDataTypes.Name = "checkBoxShowDataTypes";
      this.checkBoxShowDataTypes.Size = new System.Drawing.Size(105, 17);
      this.checkBoxShowDataTypes.TabIndex = 0;
      this.checkBoxShowDataTypes.Text = "ShowDataTypes";
      this.checkBoxShowDataTypes.UseVisualStyleBackColor = true;
      this.checkBoxShowDataTypes.CheckedChanged += new System.EventHandler(this.checkBoxShowDataTypes_CheckedChanged);
      // 
      // dataGridViewTextBoxColumn11
      // 
      this.dataGridViewTextBoxColumn11.DataPropertyName = "CurrentValue";
      this.dataGridViewTextBoxColumn11.HeaderText = "CurrentValue";
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      this.dataGridViewTextBoxColumn11.Width = 93;
      // 
      // dataGridViewTextBoxColumn12
      // 
      this.dataGridViewTextBoxColumn12.DataPropertyName = "DbValue";
      this.dataGridViewTextBoxColumn12.HeaderText = "DbValue";
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      this.dataGridViewTextBoxColumn12.ReadOnly = true;
      this.dataGridViewTextBoxColumn12.Width = 73;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInstance,
            this.toolStripStatusLabelSelectePath});
      this.statusStrip1.Location = new System.Drawing.Point(0, 540);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1031, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabelInstance
      // 
      this.toolStripStatusLabelInstance.Name = "toolStripStatusLabelInstance";
      this.toolStripStatusLabelInstance.Size = new System.Drawing.Size(49, 17);
      this.toolStripStatusLabelInstance.Text = "Instance";
      // 
      // toolStripStatusLabelSelectePath
      // 
      this.toolStripStatusLabelSelectePath.Name = "toolStripStatusLabelSelectePath";
      this.toolStripStatusLabelSelectePath.Size = new System.Drawing.Size(109, 17);
      this.toolStripStatusLabelSelectePath.Text = "toolStripStatusLabel1";
      // 
      // propertyGrid1
      // 
      this.propertyGrid1.CommandsActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
      this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.SystemColors.ControlDark;
      this.propertyGrid1.CommandsLinkColor = System.Drawing.SystemColors.ActiveCaption;
      this.propertyGrid1.ContextMenuStrip = this.contextMenuStrip1;
      this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.propertyGrid1.DrawFlat = true;
      this.propertyGrid1.Location = new System.Drawing.Point(0, 63);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new System.Drawing.Size(551, 191);
      this.propertyGrid1.TabIndex = 0;
      this.propertyGrid1.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.propertyGrid1_SelectedGridItemChanged);
      // 
      // gridDataEditor
      // 
      this.gridDataEditor.DataMember = "";
      this.gridDataEditor.DataSource = null;
      this.gridDataEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridDataEditor.Location = new System.Drawing.Point(0, 0);
      this.gridDataEditor.Name = "gridDataEditor";
      this.gridDataEditor.PageSize = ((ushort)(20));
      this.gridDataEditor.Size = new System.Drawing.Size(551, 250);
      this.gridDataEditor.TabIndex = 3;
      // 
      // FrmEntityViewer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1031, 562);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.statusStrip1);
      this.Name = "FrmEntityViewer";
      this.Tag = "False";
      this.Text = "Entity Viewer";
      this.Load += new System.EventHandler(this.FrmEntityViewer_Load);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEntityViewer_FormClosing);
      this.contextMenuStrip1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPageBrowser.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.splitContainerValues.Panel1.ResumeLayout(false);
      this.splitContainerValues.Panel2.ResumeLayout(false);
      this.splitContainerValues.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem selectObjectToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainerValues;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageBrowser;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInstance;
    private System.Windows.Forms.ToolStripMenuItem copyObjectRefToolStripMenuItem;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelectePath;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.CheckBox checkBoxShowDataTypes;
    private System.Windows.Forms.CheckBox checkBoxShowNonPublicMembers;
    private System.Windows.Forms.CheckBox checkBoxShowStaticMembers;
    private System.Windows.Forms.TextBox textBoxObjectBeingBrowsed;
    protected AW.Winforms.Helpers.PropGridEx.PropertyGridEx propertyGrid1;
    protected sliver.Windows.Forms.StateBrowser ObjectBrowser;
    protected AW.Winforms.Helpers.Controls.GridDataEditor gridDataEditor;

  }
}