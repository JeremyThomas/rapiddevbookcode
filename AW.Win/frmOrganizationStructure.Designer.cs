namespace AW.Winforms.Helpers
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
      this.employeeEntityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.employeeEntityDataGridView = new System.Windows.Forms.DataGridView();
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
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataTreeViewrOganizationStructure = new Chaliy.Windows.Forms.DataTreeView();
      ((System.ComponentModel.ISupportInitialize)(this.employeeEntityBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeEntityBindingNavigator)).BeginInit();
      this.employeeEntityBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.employeeEntityDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // employeeEntityBindingSource
      // 
      this.employeeEntityBindingSource.DataSource = typeof(AW.Data.EntityClasses.EmployeeEntity);
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
            this.employeeEntityBindingNavigatorSaveItem});
      this.employeeEntityBindingNavigator.Location = new System.Drawing.Point(0, 209);
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
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
      // employeeEntityBindingNavigatorSaveItem
      // 
      this.employeeEntityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.employeeEntityBindingNavigatorSaveItem.Enabled = false;
      this.employeeEntityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeEntityBindingNavigatorSaveItem.Image")));
      this.employeeEntityBindingNavigatorSaveItem.Name = "employeeEntityBindingNavigatorSaveItem";
      this.employeeEntityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.employeeEntityBindingNavigatorSaveItem.Text = "Save Data";
      // 
      // employeeEntityDataGridView
      // 
      this.employeeEntityDataGridView.AllowUserToOrderColumns = true;
      this.employeeEntityDataGridView.AutoGenerateColumns = false;
      this.employeeEntityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.employeeEntityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
      this.employeeEntityDataGridView.DataSource = this.employeeEntityBindingSource;
      this.employeeEntityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.employeeEntityDataGridView.Location = new System.Drawing.Point(0, 234);
      this.employeeEntityDataGridView.Name = "employeeEntityDataGridView";
      this.employeeEntityDataGridView.Size = new System.Drawing.Size(422, 307);
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
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeID";
      this.dataGridViewTextBoxColumn2.HeaderText = "EmployeeID";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "ManagerID";
      this.dataGridViewTextBoxColumn6.HeaderText = "ManagerID";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.DataPropertyName = "Title";
      this.dataGridViewTextBoxColumn7.HeaderText = "Title";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
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
      // dataGridViewCheckBoxColumn2
      // 
      this.dataGridViewCheckBoxColumn2.DataPropertyName = "CurrentFlag";
      this.dataGridViewCheckBoxColumn2.HeaderText = "CurrentFlag";
      this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
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
      // dataTreeViewrOganizationStructure
      // 
      this.dataTreeViewrOganizationStructure.DataMember = "";
      this.dataTreeViewrOganizationStructure.DataSource = this.employeeEntityBindingSource;
      this.dataTreeViewrOganizationStructure.Dock = System.Windows.Forms.DockStyle.Top;
      this.dataTreeViewrOganizationStructure.FullRowSelect = true;
      this.dataTreeViewrOganizationStructure.HideSelection = false;
      this.dataTreeViewrOganizationStructure.HotTracking = true;
      this.dataTreeViewrOganizationStructure.IDColumn = "EmployeeID";
      this.dataTreeViewrOganizationStructure.ImageIndex = 0;
      this.dataTreeViewrOganizationStructure.ImageList = this.imageList1;
      this.dataTreeViewrOganizationStructure.Location = new System.Drawing.Point(0, 0);
      this.dataTreeViewrOganizationStructure.Name = "dataTreeViewrOganizationStructure";
      this.dataTreeViewrOganizationStructure.NameColumn = "LoginID";
      this.dataTreeViewrOganizationStructure.ParentIDColumn = "ManagerID";
      this.dataTreeViewrOganizationStructure.SelectedImageIndex = 0;
      this.dataTreeViewrOganizationStructure.Size = new System.Drawing.Size(422, 209);
      this.dataTreeViewrOganizationStructure.TabIndex = 0;
      // 
      // FrmOrganizationStructure
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(422, 541);
      this.Controls.Add(this.employeeEntityDataGridView);
      this.Controls.Add(this.employeeEntityBindingNavigator);
      this.Controls.Add(this.dataTreeViewrOganizationStructure);
      this.Name = "FrmOrganizationStructure";
      this.Tag = "True";
      this.Text = "Organization Structure";
      this.Load += new System.EventHandler(this.frmOrganizationStructure_Load);
      ((System.ComponentModel.ISupportInitialize)(this.employeeEntityBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeEntityBindingNavigator)).EndInit();
      this.employeeEntityBindingNavigator.ResumeLayout(false);
      this.employeeEntityBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.employeeEntityDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

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
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    private System.Windows.Forms.ImageList imageList1;
  }
}