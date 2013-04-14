namespace AW.Win
{
  partial class FrmOrganizationStructure
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrganizationStructure));
      this.employeeEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.employeeEntityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.employeeEntityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonRevert = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonExpand = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonCollapse = new System.Windows.Forms.ToolStripButton();
      this.employeeEntityDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.dataTreeViewrOganizationStructure = new Chaliy.Windows.Forms.DataTreeView();
      this.dataTreeViewrOganizationStructureEcho = new Chaliy.Windows.Forms.DataTreeView();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.employeeEntityBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeEntityBindingNavigator)).BeginInit();
      this.employeeEntityBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.employeeEntityDataGridView)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.SuspendLayout();
      // 
      // employeeEntityBindingSource
      // 
      this.employeeEntityBindingSource.DataSource = typeof(AW.Data.EntityClasses.EmployeeEntity);
      this.employeeEntityBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.employeeEntityBindingSource_ListChanged);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "");
      this.imageList1.Images.SetKeyName(1, "");
      // 
      // employeeEntityBindingNavigator
      // 
      this.employeeEntityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.employeeEntityBindingNavigator.BindingSource = this.employeeEntityBindingSource;
      this.employeeEntityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.employeeEntityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.employeeEntityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.employeeEntityBindingNavigatorSaveItem,
            this.toolStripButtonRevert,
            this.toolStripSeparator2,
            this.toolStripButtonExpand,
            this.toolStripButtonCollapse});
      this.employeeEntityBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.employeeEntityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.employeeEntityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.employeeEntityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.employeeEntityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.employeeEntityBindingNavigator.Name = "employeeEntityBindingNavigator";
      this.employeeEntityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.employeeEntityBindingNavigator.Size = new System.Drawing.Size(422, 25);
      this.employeeEntityBindingNavigator.TabIndex = 1;
      this.employeeEntityBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // employeeEntityBindingNavigatorSaveItem
      // 
      this.employeeEntityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.employeeEntityBindingNavigatorSaveItem.Enabled = false;
      this.employeeEntityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeEntityBindingNavigatorSaveItem.Image")));
      this.employeeEntityBindingNavigatorSaveItem.Name = "employeeEntityBindingNavigatorSaveItem";
      this.employeeEntityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.employeeEntityBindingNavigatorSaveItem.Text = "Save Data";
      this.employeeEntityBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeEntityBindingNavigatorSaveItem_Click);
      // 
      // toolStripButtonRevert
      // 
      this.toolStripButtonRevert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonRevert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRevert.Image")));
      this.toolStripButtonRevert.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonRevert.Name = "toolStripButtonRevert";
      this.toolStripButtonRevert.Size = new System.Drawing.Size(23, 22);
      this.toolStripButtonRevert.Text = "Revert";
      this.toolStripButtonRevert.Click += new System.EventHandler(this.toolStripButtonRevert_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButtonExpand
      // 
      this.toolStripButtonExpand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonExpand.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExpand.Image")));
      this.toolStripButtonExpand.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonExpand.Name = "toolStripButtonExpand";
      this.toolStripButtonExpand.Size = new System.Drawing.Size(23, 22);
      this.toolStripButtonExpand.Text = "Expand";
      this.toolStripButtonExpand.Click += new System.EventHandler(this.toolStripButtonExpand_Click);
      // 
      // toolStripButtonCollapse
      // 
      this.toolStripButtonCollapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonCollapse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCollapse.Image")));
      this.toolStripButtonCollapse.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonCollapse.Name = "toolStripButtonCollapse";
      this.toolStripButtonCollapse.Size = new System.Drawing.Size(23, 22);
      this.toolStripButtonCollapse.Text = "Collapse";
      this.toolStripButtonCollapse.Click += new System.EventHandler(this.toolStripButtonCollapse_Click);
      // 
      // employeeEntityDataGridView
      // 
      this.employeeEntityDataGridView.AllowUserToOrderColumns = true;
      this.employeeEntityDataGridView.AutoGenerateColumns = false;
      this.employeeEntityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.employeeEntityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
      this.employeeEntityDataGridView.DataSource = this.employeeEntityBindingSource;
      this.employeeEntityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.employeeEntityDataGridView.Location = new System.Drawing.Point(0, 25);
      this.employeeEntityDataGridView.Name = "employeeEntityDataGridView";
      this.employeeEntityDataGridView.Size = new System.Drawing.Size(422, 266);
      this.employeeEntityDataGridView.TabIndex = 2;
      this.employeeEntityDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.employeeEntityDataGridView_DataError);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeDisplayName";
      this.dataGridViewTextBoxColumn1.HeaderText = "EmployeeDisplayName";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.DataPropertyName = "Title";
      this.dataGridViewTextBoxColumn7.HeaderText = "Title";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeID";
      this.dataGridViewTextBoxColumn2.HeaderText = "EmployeeID";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "ManagerID";
      this.dataGridViewTextBoxColumn6.HeaderText = "ManagerID";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      // 
      // dataGridViewCheckBoxColumn2
      // 
      this.dataGridViewCheckBoxColumn2.DataPropertyName = "CurrentFlag";
      this.dataGridViewCheckBoxColumn2.HeaderText = "CurrentFlag";
      this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "NationalIdnumber";
      this.dataGridViewTextBoxColumn3.HeaderText = "NationalIdnumber";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "ContactID";
      this.dataGridViewTextBoxColumn4.HeaderText = "ContactID";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "LoginID";
      this.dataGridViewTextBoxColumn5.HeaderText = "LoginID";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "BirthDate";
      this.dataGridViewTextBoxColumn8.HeaderText = "BirthDate";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.DataPropertyName = "MaritalStatus";
      this.dataGridViewTextBoxColumn9.HeaderText = "MaritalStatus";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.DataPropertyName = "Gender";
      this.dataGridViewTextBoxColumn10.HeaderText = "Gender";
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      // 
      // dataGridViewTextBoxColumn11
      // 
      this.dataGridViewTextBoxColumn11.DataPropertyName = "HireDate";
      this.dataGridViewTextBoxColumn11.HeaderText = "HireDate";
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      // 
      // dataGridViewCheckBoxColumn1
      // 
      this.dataGridViewCheckBoxColumn1.DataPropertyName = "SalariedFlag";
      this.dataGridViewCheckBoxColumn1.HeaderText = "SalariedFlag";
      this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
      // 
      // dataGridViewTextBoxColumn12
      // 
      this.dataGridViewTextBoxColumn12.DataPropertyName = "VacationHours";
      this.dataGridViewTextBoxColumn12.HeaderText = "VacationHours";
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      // 
      // dataGridViewTextBoxColumn13
      // 
      this.dataGridViewTextBoxColumn13.DataPropertyName = "SickLeaveHours";
      this.dataGridViewTextBoxColumn13.HeaderText = "SickLeaveHours";
      this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
      // 
      // dataGridViewTextBoxColumn14
      // 
      this.dataGridViewTextBoxColumn14.DataPropertyName = "Rowguid";
      this.dataGridViewTextBoxColumn14.HeaderText = "Rowguid";
      this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
      // 
      // dataGridViewTextBoxColumn15
      // 
      this.dataGridViewTextBoxColumn15.DataPropertyName = "ModifiedDate";
      this.dataGridViewTextBoxColumn15.HeaderText = "ModifiedDate";
      this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.employeeEntityDataGridView);
      this.splitContainer1.Panel2.Controls.Add(this.employeeEntityBindingNavigator);
      this.splitContainer1.Size = new System.Drawing.Size(422, 541);
      this.splitContainer1.SplitterDistance = 246;
      this.splitContainer1.TabIndex = 3;
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.dataTreeViewrOganizationStructure);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.dataTreeViewrOganizationStructureEcho);
      this.splitContainer2.Size = new System.Drawing.Size(422, 246);
      this.splitContainer2.SplitterDistance = 200;
      this.splitContainer2.TabIndex = 1;
      // 
      // dataTreeViewrOganizationStructure
      // 
      this.dataTreeViewrOganizationStructure.AllowDrop = true;
      this.dataTreeViewrOganizationStructure.DataMember = "";
      this.dataTreeViewrOganizationStructure.DataSource = this.employeeEntityBindingSource;
      this.dataTreeViewrOganizationStructure.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataTreeViewrOganizationStructure.FullRowSelect = true;
      this.dataTreeViewrOganizationStructure.HideSelection = false;
      this.dataTreeViewrOganizationStructure.HotTracking = true;
      this.dataTreeViewrOganizationStructure.IDColumn = "EmployeeID";
      this.dataTreeViewrOganizationStructure.IgnoreErrors = false;
      this.dataTreeViewrOganizationStructure.ImageIndex = 1;
      this.dataTreeViewrOganizationStructure.ImageList = this.imageList1;
      this.dataTreeViewrOganizationStructure.Location = new System.Drawing.Point(0, 0);
      this.dataTreeViewrOganizationStructure.Name = "dataTreeViewrOganizationStructure";
      this.dataTreeViewrOganizationStructure.NameColumn = "EmployeeDisplayName";
      this.dataTreeViewrOganizationStructure.ParentIDColumn = "ManagerID";
      this.dataTreeViewrOganizationStructure.SelectedImageIndex = 0;
      this.dataTreeViewrOganizationStructure.ShowNodeToolTips = true;
      this.dataTreeViewrOganizationStructure.Size = new System.Drawing.Size(200, 246);
      this.dataTreeViewrOganizationStructure.TabIndex = 0;
      // 
      // dataTreeViewrOganizationStructureEcho
      // 
      this.dataTreeViewrOganizationStructureEcho.AllowDrop = true;
      this.dataTreeViewrOganizationStructureEcho.DataMember = "";
      this.dataTreeViewrOganizationStructureEcho.DataSource = this.employeeEntityBindingSource;
      this.dataTreeViewrOganizationStructureEcho.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataTreeViewrOganizationStructureEcho.FullRowSelect = true;
      this.dataTreeViewrOganizationStructureEcho.HideSelection = false;
      this.dataTreeViewrOganizationStructureEcho.HotTracking = true;
      this.dataTreeViewrOganizationStructureEcho.IDColumn = "EmployeeID";
      this.dataTreeViewrOganizationStructureEcho.IgnoreErrors = false;
      this.dataTreeViewrOganizationStructureEcho.ImageIndex = 1;
      this.dataTreeViewrOganizationStructureEcho.ImageList = this.imageList1;
      this.dataTreeViewrOganizationStructureEcho.Location = new System.Drawing.Point(0, 0);
      this.dataTreeViewrOganizationStructureEcho.Name = "dataTreeViewrOganizationStructureEcho";
      this.dataTreeViewrOganizationStructureEcho.NameColumn = "EmployeeDisplayName";
      this.dataTreeViewrOganizationStructureEcho.ParentIDColumn = "ManagerID";
      this.dataTreeViewrOganizationStructureEcho.SelectedImageIndex = 0;
      this.dataTreeViewrOganizationStructureEcho.ShowNodeToolTips = true;
      this.dataTreeViewrOganizationStructureEcho.Size = new System.Drawing.Size(218, 246);
      this.dataTreeViewrOganizationStructureEcho.TabIndex = 0;
      // 
      // FrmOrganizationStructure
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(422, 541);
      this.Controls.Add(this.splitContainer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmOrganizationStructure";
      this.Tag = "True";
      this.Text = "Organization Structure";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOrganizationStructure_FormClosing);
      this.Load += new System.EventHandler(this.FrmOrganizationStructureLoad);
      ((System.ComponentModel.ISupportInitialize)(this.employeeEntityBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeEntityBindingNavigator)).EndInit();
      this.employeeEntityBindingNavigator.ResumeLayout(false);
      this.employeeEntityBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.employeeEntityDataGridView)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Chaliy.Windows.Forms.DataTreeView dataTreeViewrOganizationStructure;
    private System.Windows.Forms.BindingSource employeeEntityBindingSource;
    private System.Windows.Forms.BindingNavigator employeeEntityBindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton employeeEntityBindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView employeeEntityDataGridView;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ToolStripButton toolStripButtonExpand;
    private System.Windows.Forms.ToolStripButton toolStripButtonCollapse;
    private System.Windows.Forms.ToolStripButton toolStripButtonRevert;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private Chaliy.Windows.Forms.DataTreeView dataTreeViewrOganizationStructureEcho;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}