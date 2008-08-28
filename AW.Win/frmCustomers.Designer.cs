namespace AW.Win
{
    partial class frmCustomers
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
          this.dgvResults = new System.Windows.Forms.DataGridView();
          this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.StateProvinceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.CountryRegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
          this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
          this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
          this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
          this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
          this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
          this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
          this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
          this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
          this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
          this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
          this.toolStripButtonPlaintypedview = new System.Windows.Forms.ToolStripButton();
          this.toolStripButtonViewAsEntity = new System.Windows.Forms.ToolStripButton();
          this.toolStripButtonTypedList = new System.Windows.Forms.ToolStripButton();
          this.toolStripButtonLinq = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
          this.toolStripButtonLinqBarf = new System.Windows.Forms.ToolStripButton();
          this.numericUpDownNumRows = new System.Windows.Forms.NumericUpDown();
          ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
          this.bindingNavigator1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).BeginInit();
          this.SuspendLayout();
          // 
          // dgvResults
          // 
          this.dgvResults.AutoGenerateColumns = false;
          this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.FirstName,
            this.LastName,
            this.EmailAddress,
            this.StateProvinceName,
            this.CountryRegionName});
          this.dgvResults.DataSource = this.bindingSource1;
          this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
          this.dgvResults.Location = new System.Drawing.Point(0, 25);
          this.dgvResults.Name = "dgvResults";
          this.dgvResults.Size = new System.Drawing.Size(794, 353);
          this.dgvResults.TabIndex = 0;
          // 
          // Column1
          // 
          this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
          this.Column1.DataPropertyName = "CustomerId";
          this.Column1.HeaderText = "ID";
          this.Column1.Name = "Column1";
          this.Column1.ReadOnly = true;
          this.Column1.Width = 43;
          // 
          // FirstName
          // 
          this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
          this.FirstName.DataPropertyName = "FirstName";
          this.FirstName.HeaderText = "First";
          this.FirstName.Name = "FirstName";
          this.FirstName.ReadOnly = true;
          this.FirstName.Width = 51;
          // 
          // LastName
          // 
          this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
          this.LastName.DataPropertyName = "LastName";
          this.LastName.HeaderText = "Last";
          this.LastName.Name = "LastName";
          this.LastName.ReadOnly = true;
          this.LastName.Width = 52;
          // 
          // EmailAddress
          // 
          this.EmailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
          this.EmailAddress.DataPropertyName = "EmailAddress";
          this.EmailAddress.HeaderText = "Email";
          this.EmailAddress.Name = "EmailAddress";
          this.EmailAddress.ReadOnly = true;
          // 
          // StateProvinceName
          // 
          this.StateProvinceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
          this.StateProvinceName.DataPropertyName = "StateProvinceName";
          this.StateProvinceName.HeaderText = "State";
          this.StateProvinceName.Name = "StateProvinceName";
          this.StateProvinceName.ReadOnly = true;
          this.StateProvinceName.Width = 57;
          // 
          // CountryRegionName
          // 
          this.CountryRegionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
          this.CountryRegionName.DataPropertyName = "CountryRegionName";
          this.CountryRegionName.HeaderText = "Country";
          this.CountryRegionName.Name = "CountryRegionName";
          this.CountryRegionName.ReadOnly = true;
          this.CountryRegionName.Width = 68;
          // 
          // bindingNavigator1
          // 
          this.bindingNavigator1.AddNewItem = null;
          this.bindingNavigator1.BindingSource = this.bindingSource1;
          this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
          this.bindingNavigator1.DeleteItem = null;
          this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonPlaintypedview,
            this.toolStripButtonViewAsEntity,
            this.toolStripButtonTypedList,
            this.toolStripButtonLinq,
            this.toolStripSeparator1,
            this.toolStripButtonLinqBarf});
          this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
          this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
          this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
          this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
          this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
          this.bindingNavigator1.Name = "bindingNavigator1";
          this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
          this.bindingNavigator1.Size = new System.Drawing.Size(794, 25);
          this.bindingNavigator1.TabIndex = 1;
          this.bindingNavigator1.Text = "bindingNavigator1";
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
          // toolStripButtonPlaintypedview
          // 
          this.toolStripButtonPlaintypedview.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlaintypedview.Image")));
          this.toolStripButtonPlaintypedview.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.toolStripButtonPlaintypedview.Name = "toolStripButtonPlaintypedview";
          this.toolStripButtonPlaintypedview.Size = new System.Drawing.Size(105, 22);
          this.toolStripButtonPlaintypedview.Text = "Plain typed view";
          this.toolStripButtonPlaintypedview.Click += new System.EventHandler(this.toolStripButtonPlaintypedview_Click);
          // 
          // toolStripButtonViewAsEntity
          // 
          this.toolStripButtonViewAsEntity.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewAsEntity.Image")));
          this.toolStripButtonViewAsEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.toolStripButtonViewAsEntity.Name = "toolStripButtonViewAsEntity";
          this.toolStripButtonViewAsEntity.Size = new System.Drawing.Size(94, 22);
          this.toolStripButtonViewAsEntity.Text = "View as entity";
          this.toolStripButtonViewAsEntity.Click += new System.EventHandler(this.toolStripButtonViewAsEntity_Click);
          // 
          // toolStripButtonTypedList
          // 
          this.toolStripButtonTypedList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTypedList.Image")));
          this.toolStripButtonTypedList.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.toolStripButtonTypedList.Name = "toolStripButtonTypedList";
          this.toolStripButtonTypedList.Size = new System.Drawing.Size(73, 22);
          this.toolStripButtonTypedList.Text = "TypedList";
          this.toolStripButtonTypedList.Click += new System.EventHandler(this.toolStripButtonTypedList_Click);
          // 
          // toolStripButtonLinq
          // 
          this.toolStripButtonLinq.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLinq.Image")));
          this.toolStripButtonLinq.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.toolStripButtonLinq.Name = "toolStripButtonLinq";
          this.toolStripButtonLinq.Size = new System.Drawing.Size(46, 22);
          this.toolStripButtonLinq.Text = "Linq";
          this.toolStripButtonLinq.Click += new System.EventHandler(this.toolStripButtonLinq_Click);
          // 
          // toolStripSeparator1
          // 
          this.toolStripSeparator1.Name = "toolStripSeparator1";
          this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
          // 
          // toolStripButtonLinqBarf
          // 
          this.toolStripButtonLinqBarf.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLinqBarf.Image")));
          this.toolStripButtonLinqBarf.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.toolStripButtonLinqBarf.Name = "toolStripButtonLinqBarf";
          this.toolStripButtonLinqBarf.Size = new System.Drawing.Size(69, 22);
          this.toolStripButtonLinqBarf.Text = "Linq Barf";
          this.toolStripButtonLinqBarf.Visible = false;
          this.toolStripButtonLinqBarf.Click += new System.EventHandler(this.toolStripButtonLinqBarf_Click);
          // 
          // numericUpDownNumRows
          // 
          this.numericUpDownNumRows.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AW.Win.Properties.Settings.Default, "NumRows", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.numericUpDownNumRows.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
          this.numericUpDownNumRows.Location = new System.Drawing.Point(649, 2);
          this.numericUpDownNumRows.Name = "numericUpDownNumRows";
          this.numericUpDownNumRows.Size = new System.Drawing.Size(59, 20);
          this.numericUpDownNumRows.TabIndex = 2;
          this.numericUpDownNumRows.Value = global::AW.Win.Properties.Settings.Default.NumRows;
          // 
          // frmCustomers
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(794, 378);
          this.Controls.Add(this.numericUpDownNumRows);
          this.Controls.Add(this.dgvResults);
          this.Controls.Add(this.bindingNavigator1);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
          this.Name = "frmCustomers";
          this.ShowInTaskbar = false;
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "Customer List";
          this.Load += new System.EventHandler(this.frmCustomers_Load);
          this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomers_FormClosing);
          ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
          this.bindingNavigator1.ResumeLayout(false);
          this.bindingNavigator1.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateProvinceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryRegionName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonPlaintypedview;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewAsEntity;
        private System.Windows.Forms.ToolStripButton toolStripButtonTypedList;
        private System.Windows.Forms.ToolStripButton toolStripButtonLinq;
        private System.Windows.Forms.NumericUpDown numericUpDownNumRows;
        private System.Windows.Forms.ToolStripButton toolStripButtonLinqBarf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    }
}