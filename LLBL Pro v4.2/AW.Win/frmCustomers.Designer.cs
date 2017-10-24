namespace AW.Win
{
    partial class FrmCustomers
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
      this.dgvResults = new ADGV.AdvancedDataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.StateProvinceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CountryRegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bindingSourceCustomerList = new System.Windows.Forms.BindingSource(this.components);
      this.bindingNavigatorCustomerList = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.toolStripButtonLinqTypedview = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonTypedViewQuerySpecPoco = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonTypedViewQuerySpec = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonViewAsRelatedEntity = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonViewAsEntityLinq = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonViewAsEntityQuerySpec = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonViewAsEntity = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonTypedList = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonTypedListQuerySpecPoco = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonTypedListQuerySpec = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonTypedListLinq = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonLinqFilterFirst = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonLinq = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonLinqAnonymous = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonClearSort = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonClearFilters = new System.Windows.Forms.ToolStripButton();
      this.numericUpDownNumRows = new AW.Winforms.Helpers.Controls.ToolStripNumericUpDown();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.labelProgress = new System.Windows.Forms.Label();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.orderSearchCriteria1 = new AW.Win.OrderSearchCriteria();
      ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomerList)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCustomerList)).BeginInit();
      this.bindingNavigatorCustomerList.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgvResults
      // 
      this.dgvResults.AutoGenerateColumns = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.FirstName,
            this.LastName,
            this.EmailAddress,
            this.StateProvinceName,
            this.CountryRegionName});
      this.dgvResults.DataSource = this.bindingSourceCustomerList;
      this.dgvResults.DefaultCellBehavior = ADGV.ADGVColumnHeaderCellBehavior.Disabled;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgvResults.DefaultDateTimeGrouping = ADGV.ADGVFilterMenuDateTimeGrouping.Second;
      this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvResults.Location = new System.Drawing.Point(0, 299);
      this.dgvResults.Name = "dgvResults";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dgvResults.RowHeadersVisible = false;
      this.dgvResults.Size = new System.Drawing.Size(1040, 188);
      this.dgvResults.TabIndex = 0;
      this.dgvResults.Tag = "True";
      this.toolTip1.SetToolTip(this.dgvResults, "Double click to view");
      this.dgvResults.SortStringChanged += new System.EventHandler(this.dgvResults_SortStringChanged);
      this.dgvResults.FilterStringChanged += new System.EventHandler(this.dgvResults_FilterStringChanged);
      this.dgvResults.DataSourceChanged += new System.EventHandler(this.dgvResults_DataSourceChanged);
      this.dgvResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellDoubleClick);
      this.dgvResults.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvResults_DataBindingComplete);
      this.dgvResults.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvResults_RowHeaderMouseClick);
      this.dgvResults.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvResults_RowsAdded);
      // 
      // Column1
      // 
      this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Column1.DataPropertyName = "CustomerId";
      this.Column1.HeaderText = "ID";
      this.Column1.MinimumWidth = 22;
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.Column1.Width = 43;
      // 
      // FirstName
      // 
      this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.FirstName.DataPropertyName = "FirstName";
      this.FirstName.HeaderText = "First";
      this.FirstName.MinimumWidth = 22;
      this.FirstName.Name = "FirstName";
      this.FirstName.ReadOnly = true;
      this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.FirstName.Width = 51;
      // 
      // LastName
      // 
      this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.LastName.DataPropertyName = "LastName";
      this.LastName.HeaderText = "Last";
      this.LastName.MinimumWidth = 22;
      this.LastName.Name = "LastName";
      this.LastName.ReadOnly = true;
      this.LastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.LastName.Width = 52;
      // 
      // EmailAddress
      // 
      this.EmailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.EmailAddress.DataPropertyName = "EmailAddress";
      this.EmailAddress.HeaderText = "Email";
      this.EmailAddress.MinimumWidth = 22;
      this.EmailAddress.Name = "EmailAddress";
      this.EmailAddress.ReadOnly = true;
      this.EmailAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      // 
      // StateProvinceName
      // 
      this.StateProvinceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.StateProvinceName.DataPropertyName = "StateProvinceName";
      this.StateProvinceName.HeaderText = "State";
      this.StateProvinceName.MinimumWidth = 22;
      this.StateProvinceName.Name = "StateProvinceName";
      this.StateProvinceName.ReadOnly = true;
      this.StateProvinceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.StateProvinceName.Width = 57;
      // 
      // CountryRegionName
      // 
      this.CountryRegionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.CountryRegionName.DataPropertyName = "CountryRegionName";
      this.CountryRegionName.HeaderText = "Country";
      this.CountryRegionName.MinimumWidth = 22;
      this.CountryRegionName.Name = "CountryRegionName";
      this.CountryRegionName.ReadOnly = true;
      this.CountryRegionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.CountryRegionName.Width = 68;
      // 
      // bindingSourceCustomerList
      // 
      this.bindingSourceCustomerList.AllowNew = false;
      this.bindingSourceCustomerList.DataSourceChanged += new System.EventHandler(this.bindingSourceCustomerList_DataSourceChanged);
      this.bindingSourceCustomerList.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSourceCustomerList_ListChanged);
      // 
      // bindingNavigatorCustomerList
      // 
      this.bindingNavigatorCustomerList.AddNewItem = null;
      this.bindingNavigatorCustomerList.BindingSource = this.bindingSourceCustomerList;
      this.bindingNavigatorCustomerList.CanOverflow = false;
      this.bindingNavigatorCustomerList.CountItem = this.bindingNavigatorCountItem;
      this.bindingNavigatorCustomerList.DeleteItem = null;
      this.bindingNavigatorCustomerList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButtonLinqTypedview,
            this.toolStripButtonTypedViewQuerySpecPoco,
            this.toolStripButtonTypedViewQuerySpec,
            this.toolStripSeparator1,
            this.toolStripButtonViewAsRelatedEntity,
            this.toolStripSeparator3,
            this.toolStripButtonViewAsEntityLinq,
            this.toolStripButtonViewAsEntityQuerySpec,
            this.toolStripButtonViewAsEntity,
            this.toolStripSeparator2,
            this.toolStripButtonTypedList,
            this.toolStripButtonTypedListQuerySpecPoco,
            this.toolStripButtonTypedListQuerySpec,
            this.toolStripButtonTypedListLinq,
            this.toolStripButtonLinqFilterFirst,
            this.toolStripButtonLinq,
            this.toolStripButtonLinqAnonymous,
            this.toolStripSeparator4,
            this.toolStripButtonClearSort,
            this.toolStripButtonClearFilters,
            this.numericUpDownNumRows});
      this.bindingNavigatorCustomerList.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
      this.bindingNavigatorCustomerList.Location = new System.Drawing.Point(0, 225);
      this.bindingNavigatorCustomerList.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bindingNavigatorCustomerList.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bindingNavigatorCustomerList.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bindingNavigatorCustomerList.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bindingNavigatorCustomerList.Name = "bindingNavigatorCustomerList";
      this.bindingNavigatorCustomerList.PositionItem = this.bindingNavigatorPositionItem;
      this.bindingNavigatorCustomerList.Size = new System.Drawing.Size(1040, 74);
      this.bindingNavigatorCustomerList.TabIndex = 1;
      this.bindingNavigatorCustomerList.Text = "bindingNavigator1";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 23);
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
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
      // 
      // toolStripButtonPlaintypedview
      // 
      this.toolStripButtonPlaintypedview.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlaintypedview.Image")));
      this.toolStripButtonPlaintypedview.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonPlaintypedview.Name = "toolStripButtonPlaintypedview";
      this.toolStripButtonPlaintypedview.Size = new System.Drawing.Size(87, 20);
      this.toolStripButtonPlaintypedview.Text = "Typed View";
      this.toolStripButtonPlaintypedview.ToolTipText = "vIndividualCustomer exposed via Typed view CustomerViewTypedView. \r\nExample 5.18." +
    " pg59\r\nNote: sales order filters are ignored";
      this.toolStripButtonPlaintypedview.Click += new System.EventHandler(this.toolStripButtonPlaintypedview_ClickAsync);
      // 
      // toolStripButtonLinqTypedview
      // 
      this.toolStripButtonLinqTypedview.Image = global::AW.Win.Properties.Resources.AdventureWorksCycleIcon;
      this.toolStripButtonLinqTypedview.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonLinqTypedview.Name = "toolStripButtonLinqTypedview";
      this.toolStripButtonLinqTypedview.Size = new System.Drawing.Size(116, 20);
      this.toolStripButtonLinqTypedview.Text = "Typed View Linq ";
      this.toolStripButtonLinqTypedview.Click += new System.EventHandler(this.toolStripButtonLinqTypedview_Click);
      // 
      // toolStripButtonTypedViewQuerySpecPoco
      // 
      this.toolStripButtonTypedViewQuerySpecPoco.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTypedViewQuerySpecPoco.Image")));
      this.toolStripButtonTypedViewQuerySpecPoco.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonTypedViewQuerySpecPoco.Name = "toolStripButtonTypedViewQuerySpecPoco";
      this.toolStripButtonTypedViewQuerySpecPoco.Size = new System.Drawing.Size(177, 20);
      this.toolStripButtonTypedViewQuerySpecPoco.Text = "Typed View QuerySpec Poco";
      this.toolStripButtonTypedViewQuerySpecPoco.ToolTipText = "vIndividualCustomer exposed via Typed view CustomerViewTypedView. \r\nExample 5.18." +
    " pg59\r\nNote: sales order filters are ignored";
      this.toolStripButtonTypedViewQuerySpecPoco.Click += new System.EventHandler(this.toolStripButtonTypedViewQuerySpecPoco_Click);
      // 
      // toolStripButtonTypedViewQuerySpec
      // 
      this.toolStripButtonTypedViewQuerySpec.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTypedViewQuerySpec.Image")));
      this.toolStripButtonTypedViewQuerySpec.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonTypedViewQuerySpec.Name = "toolStripButtonTypedViewQuerySpec";
      this.toolStripButtonTypedViewQuerySpec.Size = new System.Drawing.Size(147, 20);
      this.toolStripButtonTypedViewQuerySpec.Text = "Typed View QuerySpec";
      this.toolStripButtonTypedViewQuerySpec.ToolTipText = "vIndividualCustomer exposed via Typed view CustomerViewTypedView. \r\nExample 5.18." +
    " pg59\r\nNote: sales order filters are ignored";
      this.toolStripButtonTypedViewQuerySpec.Click += new System.EventHandler(this.toolStripButtonTypedViewQuerySpec_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
      // 
      // toolStripButtonViewAsRelatedEntity
      // 
      this.toolStripButtonViewAsRelatedEntity.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewAsRelatedEntity.Image")));
      this.toolStripButtonViewAsRelatedEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonViewAsRelatedEntity.Name = "toolStripButtonViewAsRelatedEntity";
      this.toolStripButtonViewAsRelatedEntity.Size = new System.Drawing.Size(138, 20);
      this.toolStripButtonViewAsRelatedEntity.Text = "View as related entity";
      this.toolStripButtonViewAsRelatedEntity.ToolTipText = "Gets the related customer view (CustomerViewRelated) of SalesOrder 46117 rather t" +
    "han using filter criterea. \r\nExample 5.27 pg63";
      this.toolStripButtonViewAsRelatedEntity.Click += new System.EventHandler(this.toolStripButtonViewAsEntity_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
      // 
      // toolStripButtonViewAsEntityLinq
      // 
      this.toolStripButtonViewAsEntityLinq.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewAsEntityLinq.Image")));
      this.toolStripButtonViewAsEntityLinq.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonViewAsEntityLinq.Name = "toolStripButtonViewAsEntityLinq";
      this.toolStripButtonViewAsEntityLinq.Size = new System.Drawing.Size(127, 20);
      this.toolStripButtonViewAsEntityLinq.Text = "View As Entity Linq";
      this.toolStripButtonViewAsEntityLinq.ToolTipText = "Gets all vIndividualCustomer exposed via entity CustomerViewRelated";
      this.toolStripButtonViewAsEntityLinq.Click += new System.EventHandler(this.toolStripButtonViewAsEntityLinq_Click);
      // 
      // toolStripButtonViewAsEntityQuerySpec
      // 
      this.toolStripButtonViewAsEntityQuerySpec.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewAsEntityQuerySpec.Image")));
      this.toolStripButtonViewAsEntityQuerySpec.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonViewAsEntityQuerySpec.Name = "toolStripButtonViewAsEntityQuerySpec";
      this.toolStripButtonViewAsEntityQuerySpec.Size = new System.Drawing.Size(159, 20);
      this.toolStripButtonViewAsEntityQuerySpec.Text = "View as entity QuerySpec";
      this.toolStripButtonViewAsEntityQuerySpec.Click += new System.EventHandler(this.toolStripButtonViewAsEntityQuerySpec_Click);
      // 
      // toolStripButtonViewAsEntity
      // 
      this.toolStripButtonViewAsEntity.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewAsEntity.Image")));
      this.toolStripButtonViewAsEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonViewAsEntity.Name = "toolStripButtonViewAsEntity";
      this.toolStripButtonViewAsEntity.Size = new System.Drawing.Size(99, 20);
      this.toolStripButtonViewAsEntity.Text = "View as entity";
      this.toolStripButtonViewAsEntity.Click += new System.EventHandler(this.toolStripButtonViewAsEntity_Click_1);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
      // 
      // toolStripButtonTypedList
      // 
      this.toolStripButtonTypedList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTypedList.Image")));
      this.toolStripButtonTypedList.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonTypedList.Name = "toolStripButtonTypedList";
      this.toolStripButtonTypedList.Size = new System.Drawing.Size(80, 20);
      this.toolStripButtonTypedList.Text = "Typed List";
      this.toolStripButtonTypedList.ToolTipText = "CustomerListTypedList -Recreation of vIndividualCustomer as a Typed List. \r\nExamp" +
    "le 5.29. pg64.\r\nNote: sales order filters are ignored";
      this.toolStripButtonTypedList.Click += new System.EventHandler(this.toolStripButtonTypedList_Click);
      // 
      // toolStripButtonTypedListQuerySpecPoco
      // 
      this.toolStripButtonTypedListQuerySpecPoco.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTypedListQuerySpecPoco.Image")));
      this.toolStripButtonTypedListQuerySpecPoco.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonTypedListQuerySpecPoco.Name = "toolStripButtonTypedListQuerySpecPoco";
      this.toolStripButtonTypedListQuerySpecPoco.Size = new System.Drawing.Size(170, 20);
      this.toolStripButtonTypedListQuerySpecPoco.Text = "Typed List QuerySpec Poco";
      this.toolStripButtonTypedListQuerySpecPoco.ToolTipText = "CustomerListTypedList -Recreation of vIndividualCustomer as a Typed List. \r\nExamp" +
    "le 5.29. pg64.\r\nNote: sales order filters are ignored";
      this.toolStripButtonTypedListQuerySpecPoco.Click += new System.EventHandler(this.toolStripButtonTypedListQuerySpecPoco_Click);
      // 
      // toolStripButtonTypedListQuerySpec
      // 
      this.toolStripButtonTypedListQuerySpec.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTypedListQuerySpec.Image")));
      this.toolStripButtonTypedListQuerySpec.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonTypedListQuerySpec.Name = "toolStripButtonTypedListQuerySpec";
      this.toolStripButtonTypedListQuerySpec.Size = new System.Drawing.Size(140, 20);
      this.toolStripButtonTypedListQuerySpec.Text = "Typed List QuerySpec";
      this.toolStripButtonTypedListQuerySpec.ToolTipText = "CustomerListTypedList -Recreation of vIndividualCustomer as a Typed List. \r\nExamp" +
    "le 5.29. pg64.\r\nNote: sales order filters are ignored";
      this.toolStripButtonTypedListQuerySpec.Click += new System.EventHandler(this.toolStripButtonTypedListQuerySpec_Click);
      // 
      // toolStripButtonTypedListLinq
      // 
      this.toolStripButtonTypedListLinq.Image = global::AW.Win.Properties.Resources.AdventureWorksCycleIcon;
      this.toolStripButtonTypedListLinq.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonTypedListLinq.Name = "toolStripButtonTypedListLinq";
      this.toolStripButtonTypedListLinq.Size = new System.Drawing.Size(106, 20);
      this.toolStripButtonTypedListLinq.Text = "Typed List Linq";
      this.toolStripButtonTypedListLinq.Click += new System.EventHandler(this.toolStripButtonTypedListLinq_Click);
      // 
      // toolStripButtonLinqFilterFirst
      // 
      this.toolStripButtonLinqFilterFirst.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLinqFilterFirst.Image")));
      this.toolStripButtonLinqFilterFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonLinqFilterFirst.Name = "toolStripButtonLinqFilterFirst";
      this.toolStripButtonLinqFilterFirst.Size = new System.Drawing.Size(104, 20);
      this.toolStripButtonLinqFilterFirst.Text = "Linq Filter First";
      this.toolStripButtonLinqFilterFirst.ToolTipText = "Linq version of CustomerListTypedList projected on to CustomerListLinqedTypedList" +
    " \r\nwith the Filtering done first";
      this.toolStripButtonLinqFilterFirst.Click += new System.EventHandler(this.toolStripButtonLinqFilterFirst_Click);
      // 
      // toolStripButtonLinq
      // 
      this.toolStripButtonLinq.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLinq.Image")));
      this.toolStripButtonLinq.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonLinq.Name = "toolStripButtonLinq";
      this.toolStripButtonLinq.Size = new System.Drawing.Size(101, 20);
      this.toolStripButtonLinq.Text = "Linq Concrete";
      this.toolStripButtonLinq.ToolTipText = "Linq version of CustomerListTypedList projected on to CustomerListLinqedTypedList" +
    " with the Filtering done afterwards\r\nNote: sales order filters are ignored";
      this.toolStripButtonLinq.Click += new System.EventHandler(this.toolStripButtonLinq_Click);
      // 
      // toolStripButtonLinqAnonymous
      // 
      this.toolStripButtonLinqAnonymous.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLinqAnonymous.Image")));
      this.toolStripButtonLinqAnonymous.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonLinqAnonymous.Name = "toolStripButtonLinqAnonymous";
      this.toolStripButtonLinqAnonymous.Size = new System.Drawing.Size(118, 20);
      this.toolStripButtonLinqAnonymous.Text = "Linq Anonymous";
      this.toolStripButtonLinqAnonymous.ToolTipText = "Linq version of CustomerListTypedList projected on to an anonymous type \r\nwith th" +
    "e Filtering done first";
      this.toolStripButtonLinqAnonymous.Click += new System.EventHandler(this.toolStripButtonLinqBarf_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
      // 
      // toolStripButtonClearSort
      // 
      this.toolStripButtonClearSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonClearSort.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearSort.Image")));
      this.toolStripButtonClearSort.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonClearSort.Name = "toolStripButtonClearSort";
      this.toolStripButtonClearSort.Size = new System.Drawing.Size(62, 19);
      this.toolStripButtonClearSort.Text = "Clear Sort";
      this.toolStripButtonClearSort.Click += new System.EventHandler(this.toolStripButtonClearSort_Click);
      // 
      // toolStripButtonClearFilters
      // 
      this.toolStripButtonClearFilters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonClearFilters.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearFilters.Image")));
      this.toolStripButtonClearFilters.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonClearFilters.Name = "toolStripButtonClearFilters";
      this.toolStripButtonClearFilters.Size = new System.Drawing.Size(72, 19);
      this.toolStripButtonClearFilters.Text = "Clear Filters";
      this.toolStripButtonClearFilters.Click += new System.EventHandler(this.toolStripButtonClearFilters_Click);
      // 
      // numericUpDownNumRows
      // 
      this.numericUpDownNumRows.BackColor = System.Drawing.Color.Transparent;
      this.numericUpDownNumRows.DecimalPlaces = 0;
      this.numericUpDownNumRows.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.numericUpDownNumRows.Name = "numericUpDownNumRows";
      this.numericUpDownNumRows.NumBackColor = System.Drawing.SystemColors.Window;
      this.numericUpDownNumRows.Size = new System.Drawing.Size(222, 25);
      this.numericUpDownNumRows.Text = "MaxNumberOfItemsToReturn";
      this.numericUpDownNumRows.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(105, 164);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(159, 23);
      this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progressBar1.TabIndex = 4;
      this.progressBar1.Visible = false;
      // 
      // labelProgress
      // 
      this.labelProgress.AutoSize = true;
      this.labelProgress.Location = new System.Drawing.Point(287, 134);
      this.labelProgress.Name = "labelProgress";
      this.labelProgress.Size = new System.Drawing.Size(67, 65);
      this.labelProgress.TabIndex = 5;
      this.labelProgress.Text = "label1\r\n123\r\n1234567890\r\n123\r\n23";
      // 
      // buttonCancel
      // 
      this.buttonCancel.Location = new System.Drawing.Point(13, 164);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 6;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // orderSearchCriteria1
      // 
      this.orderSearchCriteria1.Dock = System.Windows.Forms.DockStyle.Top;
      this.orderSearchCriteria1.Location = new System.Drawing.Point(0, 0);
      this.orderSearchCriteria1.Name = "orderSearchCriteria1";
      this.orderSearchCriteria1.Size = new System.Drawing.Size(1040, 225);
      this.orderSearchCriteria1.TabIndex = 3;
      // 
      // FrmCustomers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1040, 487);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.labelProgress);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.dgvResults);
      this.Controls.Add(this.bindingNavigatorCustomerList);
      this.Controls.Add(this.orderSearchCriteria1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmCustomers";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Tag = "True";
      this.Text = "Customer List (vIndividualCustomer)";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomers_FormClosing);
      this.Load += new System.EventHandler(this.frmCustomers_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomerList)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCustomerList)).EndInit();
      this.bindingNavigatorCustomerList.ResumeLayout(false);
      this.bindingNavigatorCustomerList.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private ADGV.AdvancedDataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateProvinceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryRegionName;
        private System.Windows.Forms.BindingSource bindingSourceCustomerList;
        private System.Windows.Forms.BindingNavigator bindingNavigatorCustomerList;
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
        private Winforms.Helpers.Controls.ToolStripNumericUpDown numericUpDownNumRows;
        private System.Windows.Forms.ToolStripButton toolStripButtonLinqAnonymous;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewAsEntityLinq;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonTypedViewQuerySpec;
        private System.Windows.Forms.ToolStripButton toolStripButtonTypedListQuerySpec;
        private OrderSearchCriteria orderSearchCriteria1;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewAsRelatedEntity;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewAsEntityQuerySpec;
        private System.Windows.Forms.ToolStripButton toolStripButtonLinqFilterFirst;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearSort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearFilters;
        private System.Windows.Forms.ToolStripButton toolStripButtonLinqTypedview;
        private System.Windows.Forms.ToolStripButton toolStripButtonTypedListLinq;
        private System.Windows.Forms.ToolStripButton toolStripButtonTypedViewQuerySpecPoco;
        private System.Windows.Forms.ToolStripButton toolStripButtonTypedListQuerySpecPoco;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label labelProgress;
    private System.Windows.Forms.Button buttonCancel;
  }
}