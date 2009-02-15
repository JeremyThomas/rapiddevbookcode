namespace AW.Winforms.Helpers
{
  partial class FrmReconcile
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReconcile));
      this.entityFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.entityFieldDataGridView = new System.Windows.Forms.DataGridView();
      this.bindingNavigatorEntityField = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonToggleUseYourChanges = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonResolve = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonShowAllChanges = new System.Windows.Forms.ToolStripButton();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumnCurrentValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumnDbValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCheckBoxColumnUseYourChanges = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.entityFieldBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.entityFieldDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEntityField)).BeginInit();
      this.bindingNavigatorEntityField.SuspendLayout();
      this.SuspendLayout();
      // 
      // entityFieldBindingSource
      // 
      this.entityFieldBindingSource.DataSource = typeof(SD.LLBLGen.Pro.ORMSupportClasses.EntityField);
      // 
      // entityFieldDataGridView
      // 
      this.entityFieldDataGridView.AllowUserToOrderColumns = true;
      this.entityFieldDataGridView.AutoGenerateColumns = false;
      this.entityFieldDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.entityFieldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.entityFieldDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnName,
            this.dataGridViewTextBoxColumnCurrentValue,
            this.dataGridViewTextBoxColumnDbValue,
            this.dataGridViewCheckBoxColumnUseYourChanges});
      this.entityFieldDataGridView.DataSource = this.entityFieldBindingSource;
      this.entityFieldDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.entityFieldDataGridView.Location = new System.Drawing.Point(0, 25);
      this.entityFieldDataGridView.Name = "entityFieldDataGridView";
      this.entityFieldDataGridView.Size = new System.Drawing.Size(629, 334);
      this.entityFieldDataGridView.TabIndex = 0;
      // 
      // bindingNavigatorEntityField
      // 
      this.bindingNavigatorEntityField.AddNewItem = null;
      this.bindingNavigatorEntityField.BindingSource = this.entityFieldBindingSource;
      this.bindingNavigatorEntityField.CountItem = this.bindingNavigatorCountItem;
      this.bindingNavigatorEntityField.DeleteItem = null;
      this.bindingNavigatorEntityField.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonToggleUseYourChanges,
            this.toolStripButtonResolve,
            this.toolStripButtonShowAllChanges});
      this.bindingNavigatorEntityField.Location = new System.Drawing.Point(0, 0);
      this.bindingNavigatorEntityField.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bindingNavigatorEntityField.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bindingNavigatorEntityField.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bindingNavigatorEntityField.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bindingNavigatorEntityField.Name = "bindingNavigatorEntityField";
      this.bindingNavigatorEntityField.PositionItem = this.bindingNavigatorPositionItem;
      this.bindingNavigatorEntityField.Size = new System.Drawing.Size(629, 25);
      this.bindingNavigatorEntityField.TabIndex = 1;
      this.bindingNavigatorEntityField.Text = "bindingNavigator1";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
      // toolStripButtonToggleUseYourChanges
      // 
      this.toolStripButtonToggleUseYourChanges.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonToggleUseYourChanges.Image")));
      this.toolStripButtonToggleUseYourChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonToggleUseYourChanges.Name = "toolStripButtonToggleUseYourChanges";
      this.toolStripButtonToggleUseYourChanges.Size = new System.Drawing.Size(141, 22);
      this.toolStripButtonToggleUseYourChanges.Text = "ToggleUseYourChanges";
      this.toolStripButtonToggleUseYourChanges.Click += new System.EventHandler(this.toolStripButtonToggleUseYourChanges_Click);
      // 
      // toolStripButtonResolve
      // 
      this.toolStripButtonResolve.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResolve.Image")));
      this.toolStripButtonResolve.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonResolve.Name = "toolStripButtonResolve";
      this.toolStripButtonResolve.Size = new System.Drawing.Size(65, 22);
      this.toolStripButtonResolve.Text = "Resolve";
      this.toolStripButtonResolve.Click += new System.EventHandler(this.toolStripButtonResolve_Click);
      // 
      // toolStripButtonShowAllChanges
      // 
      this.toolStripButtonShowAllChanges.CheckOnClick = true;
      this.toolStripButtonShowAllChanges.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowAllChanges.Image")));
      this.toolStripButtonShowAllChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonShowAllChanges.Name = "toolStripButtonShowAllChanges";
      this.toolStripButtonShowAllChanges.Size = new System.Drawing.Size(112, 22);
      this.toolStripButtonShowAllChanges.Text = "Show All Changes";
      this.toolStripButtonShowAllChanges.Click += new System.EventHandler(this.toolStripButtonShowAllChanges_Click);
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
      // dataGridViewTextBoxColumnName
      // 
      this.dataGridViewTextBoxColumnName.DataPropertyName = "Name";
      this.dataGridViewTextBoxColumnName.HeaderText = "Name";
      this.dataGridViewTextBoxColumnName.Name = "dataGridViewTextBoxColumnName";
      this.dataGridViewTextBoxColumnName.ReadOnly = true;
      this.dataGridViewTextBoxColumnName.Width = 60;
      // 
      // dataGridViewTextBoxColumnCurrentValue
      // 
      this.dataGridViewTextBoxColumnCurrentValue.DataPropertyName = "CurrentValue";
      this.dataGridViewTextBoxColumnCurrentValue.HeaderText = "CurrentValue";
      this.dataGridViewTextBoxColumnCurrentValue.Name = "dataGridViewTextBoxColumnCurrentValue";
      this.dataGridViewTextBoxColumnCurrentValue.Width = 93;
      // 
      // dataGridViewTextBoxColumnDbValue
      // 
      this.dataGridViewTextBoxColumnDbValue.DataPropertyName = "DbValue";
      this.dataGridViewTextBoxColumnDbValue.HeaderText = "DbValue";
      this.dataGridViewTextBoxColumnDbValue.Name = "dataGridViewTextBoxColumnDbValue";
      this.dataGridViewTextBoxColumnDbValue.ReadOnly = true;
      this.dataGridViewTextBoxColumnDbValue.Width = 73;
      // 
      // dataGridViewCheckBoxColumnUseYourChanges
      // 
      this.dataGridViewCheckBoxColumnUseYourChanges.DataPropertyName = "UseYourChanges";
      this.dataGridViewCheckBoxColumnUseYourChanges.FalseValue = "";
      this.dataGridViewCheckBoxColumnUseYourChanges.HeaderText = "Use Your Changes";
      this.dataGridViewCheckBoxColumnUseYourChanges.Name = "dataGridViewCheckBoxColumnUseYourChanges";
      this.dataGridViewCheckBoxColumnUseYourChanges.TrueValue = "";
      this.dataGridViewCheckBoxColumnUseYourChanges.Width = 92;
      // 
      // FrmReconcile
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(629, 359);
      this.Controls.Add(this.entityFieldDataGridView);
      this.Controls.Add(this.bindingNavigatorEntityField);
      this.Name = "FrmReconcile";
      this.Text = "Reconcile Conflicts";
      ((System.ComponentModel.ISupportInitialize)(this.entityFieldBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.entityFieldDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEntityField)).EndInit();
      this.bindingNavigatorEntityField.ResumeLayout(false);
      this.bindingNavigatorEntityField.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource entityFieldBindingSource;
    private System.Windows.Forms.DataGridView entityFieldDataGridView;
    private System.Windows.Forms.BindingNavigator bindingNavigatorEntityField;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton toolStripButtonToggleUseYourChanges;
    private System.Windows.Forms.ToolStripButton toolStripButtonResolve;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.ToolStripButton toolStripButtonShowAllChanges;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnName;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCurrentValue;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDbValue;
    private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumnUseYourChanges;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
  
  }
}