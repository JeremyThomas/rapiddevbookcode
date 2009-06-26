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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntityViewer));
      this.bindingSourceEnumerable = new System.Windows.Forms.BindingSource(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.selectObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.BindingSourceScript = new System.Windows.Forms.BindingSource(this.components);
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
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabelInstance = new System.Windows.Forms.ToolStripStatusLabel();
      this.copyObjectRefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripStatusLabelSelectePath = new System.Windows.Forms.ToolStripStatusLabel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.ObjectBrowser = new sliver.Windows.Forms.StateBrowser();
      this.splitContainerValues = new System.Windows.Forms.SplitContainer();
      this.panel1 = new System.Windows.Forms.Panel();
      this.checkBoxShowNonPublicMembers = new System.Windows.Forms.CheckBox();
      this.checkBoxShowStaticMembers = new System.Windows.Forms.CheckBox();
      this.checkBoxShowDataTypes = new System.Windows.Forms.CheckBox();
      this.dataGridViewEnumerable = new System.Windows.Forms.DataGridView();
      this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.textBoxObjectBeingBrowsed = new System.Windows.Forms.TextBox();
      this.buttonRunPlugin = new System.Windows.Forms.Button();
      this.propertyGrid1 = new AW.Winforms.Helpers.PropGridEx.PropertyGridEx();
      this.toolStripComboBoxClipboardCopyMode = new System.Windows.Forms.ToolStripComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnumerable)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BindingSourceScript)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPageBrowser.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.splitContainerValues.Panel1.SuspendLayout();
      this.splitContainerValues.Panel2.SuspendLayout();
      this.splitContainerValues.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnumerable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
      this.bindingNavigator1.SuspendLayout();
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
      // BindingSourceScript
      // 
      this.BindingSourceScript.AllowNew = false;
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
      this.tabControl1.Size = new System.Drawing.Size(1031, 562);
      this.tabControl1.TabIndex = 1;
      // 
      // tabPageBrowser
      // 
      this.tabPageBrowser.Controls.Add(this.splitContainer1);
      this.tabPageBrowser.Location = new System.Drawing.Point(4, 22);
      this.tabPageBrowser.Name = "tabPageBrowser";
      this.tabPageBrowser.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageBrowser.Size = new System.Drawing.Size(1023, 536);
      this.tabPageBrowser.TabIndex = 0;
      this.tabPageBrowser.Text = "Browser";
      this.tabPageBrowser.UseVisualStyleBackColor = true;
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
      // copyObjectRefToolStripMenuItem
      // 
      this.copyObjectRefToolStripMenuItem.Name = "copyObjectRefToolStripMenuItem";
      this.copyObjectRefToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
      this.copyObjectRefToolStripMenuItem.Text = "Copy Object Ref";
      this.copyObjectRefToolStripMenuItem.Click += new System.EventHandler(this.copyObjectRefToolStripMenuItem_Click);
      // 
      // toolStripStatusLabelSelectePath
      // 
      this.toolStripStatusLabelSelectePath.Name = "toolStripStatusLabelSelectePath";
      this.toolStripStatusLabelSelectePath.Size = new System.Drawing.Size(109, 17);
      this.toolStripStatusLabelSelectePath.Text = "toolStripStatusLabel1";
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
      this.splitContainer1.Size = new System.Drawing.Size(1017, 530);
      this.splitContainer1.SplitterDistance = global::AW.Winforms.Helpers.Properties.Settings.Default.FrmEntityViewerSplitterDistance;
      this.splitContainer1.TabIndex = 2;
      // 
      // ObjectBrowser
      // 
      this.ObjectBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ObjectBrowser.Location = new System.Drawing.Point(0, 0);
      this.ObjectBrowser.Name = "ObjectBrowser";
      this.ObjectBrowser.ObjectToBrowse = null;
      this.ObjectBrowser.Size = new System.Drawing.Size(462, 530);
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
      this.splitContainerValues.Panel2.Controls.Add(this.dataGridViewEnumerable);
      this.splitContainerValues.Panel2.Controls.Add(this.bindingNavigator1);
      this.splitContainerValues.Size = new System.Drawing.Size(551, 530);
      this.splitContainerValues.SplitterDistance = 265;
      this.splitContainerValues.TabIndex = 3;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.buttonRunPlugin);
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
      // dataGridViewEnumerable
      // 
      this.dataGridViewEnumerable.AllowUserToAddRows = false;
      this.dataGridViewEnumerable.AllowUserToDeleteRows = false;
      this.dataGridViewEnumerable.AllowUserToOrderColumns = true;
      this.dataGridViewEnumerable.AllowUserToResizeRows = false;
      this.dataGridViewEnumerable.AutoGenerateColumns = false;
      this.dataGridViewEnumerable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridViewEnumerable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewEnumerable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewEnumerable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewEnumerable.DataSource = this.bindingSourceEnumerable;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewEnumerable.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridViewEnumerable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewEnumerable.Location = new System.Drawing.Point(0, 25);
      this.dataGridViewEnumerable.Name = "dataGridViewEnumerable";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewEnumerable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridViewEnumerable.Size = new System.Drawing.Size(551, 236);
      this.dataGridViewEnumerable.TabIndex = 1;
      // 
      // bindingNavigator1
      // 
      this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
      this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
      this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
      this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.toolStripComboBoxClipboardCopyMode,
            this.copyToolStripButton});
      this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
      this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
      this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
      this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
      this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
      this.bindingNavigator1.Name = "bindingNavigator1";
      this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
      this.bindingNavigator1.Size = new System.Drawing.Size(551, 25);
      this.bindingNavigator1.TabIndex = 2;
      this.bindingNavigator1.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem1
      // 
      this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
      this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
      this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem1.Text = "Add new";
      // 
      // bindingNavigatorCountItem1
      // 
      this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
      this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(36, 22);
      this.bindingNavigatorCountItem1.Text = "of {0}";
      this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem1
      // 
      this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
      this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
      this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem1.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem1
      // 
      this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
      this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
      this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem1.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem1
      // 
      this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
      this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
      this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
      // 
      // bindingNavigatorSeparator3
      // 
      this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
      this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem1
      // 
      this.bindingNavigatorPositionItem1.AccessibleName = "Position";
      this.bindingNavigatorPositionItem1.AutoSize = false;
      this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
      this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 21);
      this.bindingNavigatorPositionItem1.Text = "0";
      this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator4
      // 
      this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
      this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem1
      // 
      this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
      this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
      this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem1.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem1
      // 
      this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
      this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
      this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem1.Text = "Move last";
      // 
      // bindingNavigatorSeparator5
      // 
      this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
      this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
      this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.saveToolStripButton.Text = "&Save";
      this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
      // 
      // printToolStripButton
      // 
      this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
      this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printToolStripButton.Name = "printToolStripButton";
      this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.printToolStripButton.Text = "&Print";
      this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // copyToolStripButton
      // 
      this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
      this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripButton.Name = "copyToolStripButton";
      this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.copyToolStripButton.Text = "&Copy";
      this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
      // 
      // textBoxObjectBeingBrowsed
      // 
      this.textBoxObjectBeingBrowsed.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.textBoxObjectBeingBrowsed.Location = new System.Drawing.Point(0, 43);
      this.textBoxObjectBeingBrowsed.Name = "textBoxObjectBeingBrowsed";
      this.textBoxObjectBeingBrowsed.Size = new System.Drawing.Size(551, 20);
      this.textBoxObjectBeingBrowsed.TabIndex = 3;
      // 
      // buttonRunPlugin
      // 
      this.buttonRunPlugin.Location = new System.Drawing.Point(439, 4);
      this.buttonRunPlugin.Name = "buttonRunPlugin";
      this.buttonRunPlugin.Size = new System.Drawing.Size(75, 23);
      this.buttonRunPlugin.TabIndex = 4;
      this.buttonRunPlugin.Text = "RunPlugin";
      this.buttonRunPlugin.UseVisualStyleBackColor = true;
      this.buttonRunPlugin.Visible = false;
      this.buttonRunPlugin.Click += new System.EventHandler(this.toolStripButtonRunPlugin_Click);
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
      this.propertyGrid1.Size = new System.Drawing.Size(551, 202);
      this.propertyGrid1.TabIndex = 0;
      this.propertyGrid1.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.propertyGrid1_SelectedGridItemChanged);
      this.propertyGrid1.SelectedObjectsChanged += new System.EventHandler(this.propertyGrid1_SelectedObjectsChanged);
      // 
      // toolStripComboBoxClipboardCopyMode
      // 
      this.toolStripComboBoxClipboardCopyMode.Name = "toolStripComboBoxClipboardCopyMode";
      this.toolStripComboBoxClipboardCopyMode.Size = new System.Drawing.Size(160, 25);
      this.toolStripComboBoxClipboardCopyMode.Text = "ClipboardCopyMode";
      this.toolStripComboBoxClipboardCopyMode.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxClipboardCopyMode_SelectedIndexChanged);
      // 
      // FrmEntityViewer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1031, 562);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.tabControl1);
      this.Name = "FrmEntityViewer";
      this.Tag = "False";
      this.Text = "Entity Viewer";
      this.Load += new System.EventHandler(this.FrmEntityViewer_Load);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEntityViewer_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnumerable)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.BindingSourceScript)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPageBrowser.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.splitContainerValues.Panel1.ResumeLayout(false);
      this.splitContainerValues.Panel2.ResumeLayout(false);
      this.splitContainerValues.Panel2.PerformLayout();
      this.splitContainerValues.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnumerable)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
      this.bindingNavigator1.ResumeLayout(false);
      this.bindingNavigator1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewEnumerable;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private AW.Winforms.Helpers.PropGridEx.PropertyGridEx propertyGrid1;
    private System.Windows.Forms.BindingSource BindingSourceScript;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem selectObjectToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainerValues;
    private System.Windows.Forms.BindingSource bindingSourceEnumerable;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private sliver.Windows.Forms.StateBrowser ObjectBrowser;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageBrowser;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private System.Windows.Forms.BindingNavigator bindingNavigator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
    private System.Windows.Forms.ToolStripButton saveToolStripButton;
    private System.Windows.Forms.ToolStripButton printToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripButton copyToolStripButton;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInstance;
    private System.Windows.Forms.ToolStripMenuItem copyObjectRefToolStripMenuItem;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelectePath;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.CheckBox checkBoxShowDataTypes;
    private System.Windows.Forms.CheckBox checkBoxShowNonPublicMembers;
    private System.Windows.Forms.CheckBox checkBoxShowStaticMembers;
    private System.Windows.Forms.TextBox textBoxObjectBeingBrowsed;
    private System.Windows.Forms.Button buttonRunPlugin;
    private System.Windows.Forms.ToolStripComboBox toolStripComboBoxClipboardCopyMode;

  }
}