namespace AW.Win
{
    partial class FrmOrderSearch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderSearch));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.salesOrderHeaderEntityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.salesOrderHeaderEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.orderSearchCriteria1 = new AW.Win.OrderSearchCriteria();
      this.QPanel = new Korzh.EasyQuery.WinControls.QueryPanel();
      this.query1 = new Korzh.EasyQuery.Db.DbQuery();
      this.dataModel1 = new Korzh.EasyQuery.Db.DbModel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.salesOrderHeaderEntityDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SalesOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dgResults = new System.Windows.Forms.DataGridView();
      this.salesOrderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.totalDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.checkBoxUseEasyQuery = new System.Windows.Forms.CheckBox();
      this.checkBoxUsePredicate = new System.Windows.Forms.CheckBox();
      this.checkBoxShowCustomerViewRelatedFields = new System.Windows.Forms.CheckBox();
      this.checkBoxFilterUsingCustomerViewRelated = new System.Windows.Forms.CheckBox();
      this.groupBoxLLBLQueryType = new System.Windows.Forms.GroupBox();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButtonQuerySpec = new System.Windows.Forms.RadioButton();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.checkBoxPrefetch = new System.Windows.Forms.CheckBox();
      this.numericUpDownNumRows = new System.Windows.Forms.NumericUpDown();
      this.btnSearch = new System.Windows.Forms.Button();
      this.searchWorker = new System.ComponentModel.BackgroundWorker();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.billToAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.creditCardApprovalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.creditCardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.currencyRateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.onlineOrderFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.orderDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.purchaseOrderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.revisionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rowguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesOrderNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesPersonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipMethodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipToAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.taxAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.territoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.totalDueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.billingAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shippingAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.creditCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.currencyRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerViewRelatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.individualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesTerritoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerCityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerCountryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerFirstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerLastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerStateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerZipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.accountNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.billToAddressIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.contactIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.creditCardApprovalCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.creditCardIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.currencyRateIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dueDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.freightDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.modifiedDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.onlineOrderFlagDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.orderDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.purchaseOrderNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.revisionNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rowguidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesOrderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesOrderNumberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesPersonIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipMethodIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipToAddressIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.subTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.taxAmtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.territoryIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.totalDueDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.billingAddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shippingAddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.contactDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipMethodDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.creditCardDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.currencyRateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerViewRelatedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.individualDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesPersonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesTerritoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerCityDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerCountryDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerFirstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerLastNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerStateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerZipDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingNavigator)).BeginInit();
      this.salesOrderHeaderEntityBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingSource)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.groupBoxLLBLQueryType.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.salesOrderHeaderEntityBindingNavigator, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.orderSearchCriteria1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.QPanel, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 593);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // salesOrderHeaderEntityBindingNavigator
      // 
      this.salesOrderHeaderEntityBindingNavigator.AddNewItem = null;
      this.salesOrderHeaderEntityBindingNavigator.BindingSource = this.salesOrderHeaderEntityBindingSource;
      this.salesOrderHeaderEntityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.salesOrderHeaderEntityBindingNavigator.DeleteItem = null;
      this.salesOrderHeaderEntityBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.salesOrderHeaderEntityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
      this.salesOrderHeaderEntityBindingNavigator.Location = new System.Drawing.Point(2, 623);
      this.salesOrderHeaderEntityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.salesOrderHeaderEntityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.salesOrderHeaderEntityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.salesOrderHeaderEntityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.salesOrderHeaderEntityBindingNavigator.Name = "salesOrderHeaderEntityBindingNavigator";
      this.salesOrderHeaderEntityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.salesOrderHeaderEntityBindingNavigator.Size = new System.Drawing.Size(771, 20);
      this.salesOrderHeaderEntityBindingNavigator.TabIndex = 24;
      this.salesOrderHeaderEntityBindingNavigator.Text = "bindingNavigator1";
      // 
      // salesOrderHeaderEntityBindingSource
      // 
      this.salesOrderHeaderEntityBindingSource.AllowNew = false;
      this.salesOrderHeaderEntityBindingSource.DataSource = typeof(AW.Data.EntityClasses.SalesOrderHeaderEntity);
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 17);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 17);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 17);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 20);
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
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 20);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 17);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 17);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 20);
      // 
      // orderSearchCriteria1
      // 
      this.orderSearchCriteria1.Dock = System.Windows.Forms.DockStyle.Top;
      this.orderSearchCriteria1.Location = new System.Drawing.Point(5, 5);
      this.orderSearchCriteria1.Name = "orderSearchCriteria1";
      this.orderSearchCriteria1.Size = new System.Drawing.Size(765, 227);
      this.orderSearchCriteria1.TabIndex = 23;
      // 
      // QPanel
      // 
      this.QPanel.Active = false;
      this.QPanel.ActiveRowIndex = -1;
      this.QPanel.Appearance.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(190)))));
      this.QPanel.Appearance.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
      this.QPanel.Appearance.AdditionRowColor = System.Drawing.Color.DarkGreen;
      this.QPanel.Appearance.ButtonForeColor = System.Drawing.SystemColors.ControlText;
      this.QPanel.Appearance.ButtonMacStyle = false;
      this.QPanel.Appearance.ExprColor = System.Drawing.Color.Indigo;
      this.QPanel.Appearance.FocusBorderStyle = System.Windows.Forms.BorderStyle.None;
      this.QPanel.Appearance.OperatorColor = System.Drawing.Color.MediumBlue;
      this.QPanel.Appearance.ShowRootRow = true;
      this.QPanel.BackColor = System.Drawing.Color.White;
      this.QPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.QPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.QPanel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.QPanel.Location = new System.Drawing.Point(5, 240);
      this.QPanel.Name = "QPanel";
      this.QPanel.Query = this.query1;
      this.QPanel.Size = new System.Drawing.Size(765, 78);
      this.QPanel.TabIndex = 29;
      this.QPanel.TabStop = true;
      this.QPanel.Click += new System.EventHandler(this.QPanel_DoubleClick);
      this.QPanel.DoubleClick += new System.EventHandler(this.QPanel_DoubleClick);
      // 
      // query1
      // 
      this.query1.ExtraColumns = "";
      this.query1.FilePath = "";
      this.query1.Formats.EscapeSymbol = "";
      this.query1.Formats.QuoteColumnAlias = false;
      this.query1.Formats.UseTableAlias = false;
      this.query1.Formats.WildSymbol = '%';
      this.query1.Model = this.dataModel1;
      this.query1.NoPathResolution = Korzh.EasyQuery.NoPathResolution.ThrowException;
      this.query1.QueryName = "SampleQuery";
      this.query1.SyncColSortOrder = true;
      // 
      // dataModel1
      // 
      this.dataModel1.CustomInfo = "";
      this.dataModel1.DefQueryFilePath = "";
      this.dataModel1.Description = null;
      this.dataModel1.ID = "25704bf3-5f67-4ad8-8be8-bb1b47a3073e";
      this.dataModel1.IsLoadedFromDbContext = false;
      this.dataModel1.ModelName = null;
      this.dataModel1.StoreDbParams = false;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.salesOrderHeaderEntityDataGridView);
      this.panel2.Controls.Add(this.dgResults);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(5, 384);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(765, 234);
      this.panel2.TabIndex = 29;
      // 
      // salesOrderHeaderEntityDataGridView
      // 
      this.salesOrderHeaderEntityDataGridView.AllowUserToAddRows = false;
      this.salesOrderHeaderEntityDataGridView.AllowUserToDeleteRows = false;
      this.salesOrderHeaderEntityDataGridView.AutoGenerateColumns = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.salesOrderHeaderEntityDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.salesOrderHeaderEntityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.salesOrderHeaderEntityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn13,
            this.SalesOrderID,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn32});
      this.salesOrderHeaderEntityDataGridView.DataSource = this.salesOrderHeaderEntityBindingSource;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.salesOrderHeaderEntityDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
      this.salesOrderHeaderEntityDataGridView.Location = new System.Drawing.Point(0, 113);
      this.salesOrderHeaderEntityDataGridView.Name = "salesOrderHeaderEntityDataGridView";
      this.salesOrderHeaderEntityDataGridView.ReadOnly = true;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.salesOrderHeaderEntityDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.salesOrderHeaderEntityDataGridView.Size = new System.Drawing.Size(684, 106);
      this.salesOrderHeaderEntityDataGridView.TabIndex = 25;
      this.salesOrderHeaderEntityDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResults_CellContentDoubleClick);
      // 
      // dataGridViewTextBoxColumn15
      // 
      this.dataGridViewTextBoxColumn15.DataPropertyName = "AccountNumber";
      this.dataGridViewTextBoxColumn15.HeaderText = "AccountNumber";
      this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
      this.dataGridViewTextBoxColumn15.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn13
      // 
      this.dataGridViewTextBoxColumn13.DataPropertyName = "SalesOrderNumber";
      this.dataGridViewTextBoxColumn13.HeaderText = "SalesOrderNumber";
      this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
      this.dataGridViewTextBoxColumn13.ReadOnly = true;
      // 
      // SalesOrderID
      // 
      this.SalesOrderID.DataPropertyName = "SalesOrderID";
      this.SalesOrderID.HeaderText = "SalesOrderID";
      this.SalesOrderID.Name = "SalesOrderID";
      this.SalesOrderID.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "RevisionNumber";
      this.dataGridViewTextBoxColumn8.HeaderText = "RevisionNumber";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.DataPropertyName = "OrderDate";
      this.dataGridViewTextBoxColumn9.HeaderText = "OrderDate";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn9.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.DataPropertyName = "DueDate";
      this.dataGridViewTextBoxColumn10.HeaderText = "DueDate";
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      this.dataGridViewTextBoxColumn10.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn11
      // 
      this.dataGridViewTextBoxColumn11.DataPropertyName = "ShipDate";
      this.dataGridViewTextBoxColumn11.HeaderText = "ShipDate";
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      this.dataGridViewTextBoxColumn11.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn12
      // 
      this.dataGridViewTextBoxColumn12.DataPropertyName = "Status";
      this.dataGridViewTextBoxColumn12.HeaderText = "Status";
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      this.dataGridViewTextBoxColumn12.ReadOnly = true;
      // 
      // dataGridViewCheckBoxColumn1
      // 
      this.dataGridViewCheckBoxColumn1.DataPropertyName = "OnlineOrderFlag";
      this.dataGridViewCheckBoxColumn1.HeaderText = "OnlineOrderFlag";
      this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
      this.dataGridViewCheckBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn14
      // 
      this.dataGridViewTextBoxColumn14.DataPropertyName = "PurchaseOrderNumber";
      this.dataGridViewTextBoxColumn14.HeaderText = "PurchaseOrderNumber";
      this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
      this.dataGridViewTextBoxColumn14.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn24
      // 
      this.dataGridViewTextBoxColumn24.DataPropertyName = "CreditCardApprovalCode";
      this.dataGridViewTextBoxColumn24.HeaderText = "CreditCardApprovalCode";
      this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
      this.dataGridViewTextBoxColumn24.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn26
      // 
      this.dataGridViewTextBoxColumn26.DataPropertyName = "SubTotal";
      this.dataGridViewTextBoxColumn26.HeaderText = "SubTotal";
      this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
      this.dataGridViewTextBoxColumn26.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn27
      // 
      this.dataGridViewTextBoxColumn27.DataPropertyName = "TaxAmt";
      this.dataGridViewTextBoxColumn27.HeaderText = "TaxAmt";
      this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
      this.dataGridViewTextBoxColumn27.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn28
      // 
      this.dataGridViewTextBoxColumn28.DataPropertyName = "Freight";
      this.dataGridViewTextBoxColumn28.HeaderText = "Freight";
      this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
      this.dataGridViewTextBoxColumn28.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn29
      // 
      this.dataGridViewTextBoxColumn29.DataPropertyName = "TotalDue";
      this.dataGridViewTextBoxColumn29.HeaderText = "TotalDue";
      this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
      this.dataGridViewTextBoxColumn29.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn30
      // 
      this.dataGridViewTextBoxColumn30.DataPropertyName = "Comment";
      this.dataGridViewTextBoxColumn30.HeaderText = "Comment";
      this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
      this.dataGridViewTextBoxColumn30.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn32
      // 
      this.dataGridViewTextBoxColumn32.DataPropertyName = "ModifiedDate";
      this.dataGridViewTextBoxColumn32.HeaderText = "ModifiedDate";
      this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
      this.dataGridViewTextBoxColumn32.ReadOnly = true;
      // 
      // dgResults
      // 
      this.dgResults.AllowUserToAddRows = false;
      this.dgResults.AutoGenerateColumns = false;
      this.dgResults.BackgroundColor = System.Drawing.Color.White;
      this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesOrderNumberDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.customerLastNameDataGridViewTextBoxColumn,
            this.customerFirstNameDataGridViewTextBoxColumn,
            this.customerCityDataGridViewTextBoxColumn,
            this.customerStateDataGridViewTextBoxColumn,
            this.customerZipDataGridViewTextBoxColumn,
            this.customerCountryDataGridViewTextBoxColumn,
            this.totalDueDataGridViewTextBoxColumn});
      this.dgResults.ContextMenuStrip = this.contextMenuStrip1;
      this.dgResults.DataSource = this.salesOrderHeaderEntityBindingSource;
      this.dgResults.Location = new System.Drawing.Point(3, 20);
      this.dgResults.Name = "dgResults";
      this.dgResults.RowHeadersVisible = false;
      this.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgResults.Size = new System.Drawing.Size(684, 77);
      this.dgResults.TabIndex = 1;
      this.dgResults.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResults_CellContentDoubleClick);
      this.dgResults.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgResults_DataError);
      // 
      // salesOrderNumberDataGridViewTextBoxColumn
      // 
      this.salesOrderNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.salesOrderNumberDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderNumber";
      this.salesOrderNumberDataGridViewTextBoxColumn.HeaderText = "#";
      this.salesOrderNumberDataGridViewTextBoxColumn.Name = "salesOrderNumberDataGridViewTextBoxColumn";
      this.salesOrderNumberDataGridViewTextBoxColumn.ReadOnly = true;
      this.salesOrderNumberDataGridViewTextBoxColumn.Width = 39;
      // 
      // orderDateDataGridViewTextBoxColumn
      // 
      this.orderDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
      dataGridViewCellStyle4.Format = "d";
      dataGridViewCellStyle4.NullValue = null;
      this.orderDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
      this.orderDateDataGridViewTextBoxColumn.HeaderText = "Date";
      this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
      this.orderDateDataGridViewTextBoxColumn.Width = 55;
      // 
      // customerLastNameDataGridViewTextBoxColumn
      // 
      this.customerLastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerLastName";
      this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "Last";
      this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
      this.customerLastNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.customerLastNameDataGridViewTextBoxColumn.Width = 52;
      // 
      // customerFirstNameDataGridViewTextBoxColumn
      // 
      this.customerFirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFirstName";
      this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "First";
      this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
      this.customerFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.customerFirstNameDataGridViewTextBoxColumn.Width = 51;
      // 
      // customerCityDataGridViewTextBoxColumn
      // 
      this.customerCityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.customerCityDataGridViewTextBoxColumn.DataPropertyName = "CustomerCity";
      this.customerCityDataGridViewTextBoxColumn.HeaderText = "City";
      this.customerCityDataGridViewTextBoxColumn.Name = "customerCityDataGridViewTextBoxColumn";
      this.customerCityDataGridViewTextBoxColumn.ReadOnly = true;
      this.customerCityDataGridViewTextBoxColumn.Width = 49;
      // 
      // customerStateDataGridViewTextBoxColumn
      // 
      this.customerStateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.customerStateDataGridViewTextBoxColumn.DataPropertyName = "CustomerState";
      this.customerStateDataGridViewTextBoxColumn.HeaderText = "State";
      this.customerStateDataGridViewTextBoxColumn.Name = "customerStateDataGridViewTextBoxColumn";
      this.customerStateDataGridViewTextBoxColumn.ReadOnly = true;
      this.customerStateDataGridViewTextBoxColumn.Width = 57;
      // 
      // customerZipDataGridViewTextBoxColumn
      // 
      this.customerZipDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.customerZipDataGridViewTextBoxColumn.DataPropertyName = "CustomerZip";
      this.customerZipDataGridViewTextBoxColumn.HeaderText = "Zip";
      this.customerZipDataGridViewTextBoxColumn.Name = "customerZipDataGridViewTextBoxColumn";
      this.customerZipDataGridViewTextBoxColumn.ReadOnly = true;
      this.customerZipDataGridViewTextBoxColumn.Width = 47;
      // 
      // customerCountryDataGridViewTextBoxColumn
      // 
      this.customerCountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.customerCountryDataGridViewTextBoxColumn.DataPropertyName = "CustomerCountry";
      this.customerCountryDataGridViewTextBoxColumn.HeaderText = "Country";
      this.customerCountryDataGridViewTextBoxColumn.Name = "customerCountryDataGridViewTextBoxColumn";
      this.customerCountryDataGridViewTextBoxColumn.ReadOnly = true;
      this.customerCountryDataGridViewTextBoxColumn.Width = 68;
      // 
      // totalDueDataGridViewTextBoxColumn
      // 
      this.totalDueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.totalDueDataGridViewTextBoxColumn.DataPropertyName = "TotalDue";
      dataGridViewCellStyle5.Format = "C2";
      dataGridViewCellStyle5.NullValue = null;
      this.totalDueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
      this.totalDueDataGridViewTextBoxColumn.HeaderText = "Total";
      this.totalDueDataGridViewTextBoxColumn.Name = "totalDueDataGridViewTextBoxColumn";
      this.totalDueDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(132, 26);
      // 
      // newOrderToolStripMenuItem
      // 
      this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
      this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
      this.newOrderToolStripMenuItem.Text = "New Order";
      this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.checkBoxUseEasyQuery);
      this.panel1.Controls.Add(this.checkBoxUsePredicate);
      this.panel1.Controls.Add(this.checkBoxShowCustomerViewRelatedFields);
      this.panel1.Controls.Add(this.checkBoxFilterUsingCustomerViewRelated);
      this.panel1.Controls.Add(this.groupBoxLLBLQueryType);
      this.panel1.Controls.Add(this.checkBoxPrefetch);
      this.panel1.Controls.Add(this.numericUpDownNumRows);
      this.panel1.Controls.Add(this.btnSearch);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(5, 326);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(765, 50);
      this.panel1.TabIndex = 22;
      // 
      // checkBoxUseEasyQuery
      // 
      this.checkBoxUseEasyQuery.AutoSize = true;
      this.checkBoxUseEasyQuery.Checked = global::AW.Win.Properties.Settings.Default.UseEasyQuery;
      this.checkBoxUseEasyQuery.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxUseEasyQuery.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Win.Properties.Settings.Default, "UseEasyQuery", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxUseEasyQuery.Location = new System.Drawing.Point(572, 27);
      this.checkBoxUseEasyQuery.Name = "checkBoxUseEasyQuery";
      this.checkBoxUseEasyQuery.Size = new System.Drawing.Size(99, 17);
      this.checkBoxUseEasyQuery.TabIndex = 29;
      this.checkBoxUseEasyQuery.Text = "Use EasyQuery";
      this.checkBoxUseEasyQuery.UseVisualStyleBackColor = true;
      this.checkBoxUseEasyQuery.CheckedChanged += new System.EventHandler(this.checkBoxUseEasyQuery_CheckedChanged);
      // 
      // checkBoxUsePredicate
      // 
      this.checkBoxUsePredicate.AutoSize = true;
      this.checkBoxUsePredicate.Checked = global::AW.Win.Properties.Settings.Default.UsePredicate;
      this.checkBoxUsePredicate.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxUsePredicate.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Win.Properties.Settings.Default, "UsePredicate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxUsePredicate.Location = new System.Drawing.Point(476, 6);
      this.checkBoxUsePredicate.Name = "checkBoxUsePredicate";
      this.checkBoxUsePredicate.Size = new System.Drawing.Size(93, 17);
      this.checkBoxUsePredicate.TabIndex = 28;
      this.checkBoxUsePredicate.Text = "Use Predicate";
      this.checkBoxUsePredicate.UseVisualStyleBackColor = true;
      // 
      // checkBoxShowCustomerViewRelatedFields
      // 
      this.checkBoxShowCustomerViewRelatedFields.AutoCheck = false;
      this.checkBoxShowCustomerViewRelatedFields.AutoSize = true;
      this.checkBoxShowCustomerViewRelatedFields.Checked = global::AW.Win.Properties.Settings.Default.ShowCustomerViewRelatedFields;
      this.checkBoxShowCustomerViewRelatedFields.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxShowCustomerViewRelatedFields.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Win.Properties.Settings.Default, "ShowCustomerViewRelatedFields", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxShowCustomerViewRelatedFields.Location = new System.Drawing.Point(280, 29);
      this.checkBoxShowCustomerViewRelatedFields.Name = "checkBoxShowCustomerViewRelatedFields";
      this.checkBoxShowCustomerViewRelatedFields.Size = new System.Drawing.Size(190, 17);
      this.checkBoxShowCustomerViewRelatedFields.TabIndex = 27;
      this.checkBoxShowCustomerViewRelatedFields.Text = "Show CustomerViewRelated Fields";
      this.checkBoxShowCustomerViewRelatedFields.UseVisualStyleBackColor = true;
      this.checkBoxShowCustomerViewRelatedFields.CheckedChanged += new System.EventHandler(this.checkBoxShowCustomerViewRelatedFields_CheckedChanged);
      this.checkBoxShowCustomerViewRelatedFields.Click += new System.EventHandler(this.checkBoxShowCustomerViewRelatedFields_Click);
      // 
      // checkBoxFilterUsingCustomerViewRelated
      // 
      this.checkBoxFilterUsingCustomerViewRelated.AutoSize = true;
      this.checkBoxFilterUsingCustomerViewRelated.Checked = global::AW.Win.Properties.Settings.Default.FilterUsingCustomerViewRelated;
      this.checkBoxFilterUsingCustomerViewRelated.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxFilterUsingCustomerViewRelated.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Win.Properties.Settings.Default, "FilterUsingCustomerViewRelated", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxFilterUsingCustomerViewRelated.Location = new System.Drawing.Point(280, 6);
      this.checkBoxFilterUsingCustomerViewRelated.Name = "checkBoxFilterUsingCustomerViewRelated";
      this.checkBoxFilterUsingCustomerViewRelated.Size = new System.Drawing.Size(185, 17);
      this.checkBoxFilterUsingCustomerViewRelated.TabIndex = 26;
      this.checkBoxFilterUsingCustomerViewRelated.Text = "Filter Using CustomerViewRelated";
      this.checkBoxFilterUsingCustomerViewRelated.UseVisualStyleBackColor = true;
      // 
      // groupBoxLLBLQueryType
      // 
      this.groupBoxLLBLQueryType.Controls.Add(this.radioButton3);
      this.groupBoxLLBLQueryType.Controls.Add(this.radioButtonQuerySpec);
      this.groupBoxLLBLQueryType.Controls.Add(this.radioButton1);
      this.groupBoxLLBLQueryType.Location = new System.Drawing.Point(73, 3);
      this.groupBoxLLBLQueryType.Name = "groupBoxLLBLQueryType";
      this.groupBoxLLBLQueryType.Size = new System.Drawing.Size(192, 44);
      this.groupBoxLLBLQueryType.TabIndex = 25;
      this.groupBoxLLBLQueryType.TabStop = false;
      this.groupBoxLLBLQueryType.Text = "LLBL Query Type";
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new System.Drawing.Point(144, 19);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(45, 17);
      this.radioButton3.TabIndex = 2;
      this.radioButton3.Tag = "";
      this.radioButton3.Text = "Linq";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButtonLLBLQueryType_CheckedChanged);
      // 
      // radioButtonQuerySpec
      // 
      this.radioButtonQuerySpec.AutoSize = true;
      this.radioButtonQuerySpec.Location = new System.Drawing.Point(64, 19);
      this.radioButtonQuerySpec.Name = "radioButtonQuerySpec";
      this.radioButtonQuerySpec.Size = new System.Drawing.Size(78, 17);
      this.radioButtonQuerySpec.TabIndex = 1;
      this.radioButtonQuerySpec.Tag = "";
      this.radioButtonQuerySpec.Text = "QuerySpec";
      this.radioButtonQuerySpec.UseVisualStyleBackColor = true;
      this.radioButtonQuerySpec.CheckedChanged += new System.EventHandler(this.radioButtonLLBLQueryType_CheckedChanged);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Checked = true;
      this.radioButton1.Location = new System.Drawing.Point(6, 19);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(56, 17);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.TabStop = true;
      this.radioButton1.Tag = "LLBLQueryType.Native";
      this.radioButton1.Text = "Native";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtonLLBLQueryType_CheckedChanged);
      // 
      // checkBoxPrefetch
      // 
      this.checkBoxPrefetch.AutoSize = true;
      this.checkBoxPrefetch.Checked = global::AW.Win.Properties.Settings.Default.Prefetch;
      this.checkBoxPrefetch.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxPrefetch.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Win.Properties.Settings.Default, "Prefetch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxPrefetch.Location = new System.Drawing.Point(476, 29);
      this.checkBoxPrefetch.Name = "checkBoxPrefetch";
      this.checkBoxPrefetch.Size = new System.Drawing.Size(66, 17);
      this.checkBoxPrefetch.TabIndex = 24;
      this.checkBoxPrefetch.Text = "Prefetch";
      this.checkBoxPrefetch.UseVisualStyleBackColor = true;
      // 
      // numericUpDownNumRows
      // 
      this.numericUpDownNumRows.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AW.Win.Properties.Settings.Default, "NumRows", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.numericUpDownNumRows.Location = new System.Drawing.Point(7, 27);
      this.numericUpDownNumRows.Name = "numericUpDownNumRows";
      this.numericUpDownNumRows.Size = new System.Drawing.Size(48, 20);
      this.numericUpDownNumRows.TabIndex = 23;
      this.toolTip1.SetToolTip(this.numericUpDownNumRows, "max Number Of Items To Return");
      this.numericUpDownNumRows.Value = global::AW.Win.Properties.Settings.Default.NumRows;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(3, 0);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(55, 22);
      this.btnSearch.TabIndex = 21;
      this.btnSearch.Text = "Search";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      this.btnSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSearch_MouseUp);
      // 
      // searchWorker
      // 
      this.searchWorker.WorkerSupportsCancellation = true;
      this.searchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchWorker_DoWork);
      this.searchWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searchWorker_RunWorkerCompleted);
      // 
      // accountNumberDataGridViewTextBoxColumn
      // 
      this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
      this.accountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber";
      this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
      // 
      // billToAddressIDDataGridViewTextBoxColumn
      // 
      this.billToAddressIDDataGridViewTextBoxColumn.DataPropertyName = "BillToAddressID";
      this.billToAddressIDDataGridViewTextBoxColumn.HeaderText = "BillToAddressID";
      this.billToAddressIDDataGridViewTextBoxColumn.Name = "billToAddressIDDataGridViewTextBoxColumn";
      // 
      // commentDataGridViewTextBoxColumn
      // 
      this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
      this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
      this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
      // 
      // contactIDDataGridViewTextBoxColumn
      // 
      this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID";
      this.contactIDDataGridViewTextBoxColumn.HeaderText = "ContactID";
      this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
      // 
      // creditCardApprovalCodeDataGridViewTextBoxColumn
      // 
      this.creditCardApprovalCodeDataGridViewTextBoxColumn.DataPropertyName = "CreditCardApprovalCode";
      this.creditCardApprovalCodeDataGridViewTextBoxColumn.HeaderText = "CreditCardApprovalCode";
      this.creditCardApprovalCodeDataGridViewTextBoxColumn.Name = "creditCardApprovalCodeDataGridViewTextBoxColumn";
      // 
      // creditCardIDDataGridViewTextBoxColumn
      // 
      this.creditCardIDDataGridViewTextBoxColumn.DataPropertyName = "CreditCardID";
      this.creditCardIDDataGridViewTextBoxColumn.HeaderText = "CreditCardID";
      this.creditCardIDDataGridViewTextBoxColumn.Name = "creditCardIDDataGridViewTextBoxColumn";
      // 
      // currencyRateIDDataGridViewTextBoxColumn
      // 
      this.currencyRateIDDataGridViewTextBoxColumn.DataPropertyName = "CurrencyRateID";
      this.currencyRateIDDataGridViewTextBoxColumn.HeaderText = "CurrencyRateID";
      this.currencyRateIDDataGridViewTextBoxColumn.Name = "currencyRateIDDataGridViewTextBoxColumn";
      // 
      // customerIDDataGridViewTextBoxColumn
      // 
      this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
      this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
      this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
      // 
      // dueDateDataGridViewTextBoxColumn
      // 
      this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
      this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
      this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
      // 
      // freightDataGridViewTextBoxColumn
      // 
      this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
      this.freightDataGridViewTextBoxColumn.HeaderText = "Freight";
      this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
      // 
      // modifiedDateDataGridViewTextBoxColumn
      // 
      this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
      this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
      this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
      // 
      // onlineOrderFlagDataGridViewCheckBoxColumn
      // 
      this.onlineOrderFlagDataGridViewCheckBoxColumn.DataPropertyName = "OnlineOrderFlag";
      this.onlineOrderFlagDataGridViewCheckBoxColumn.HeaderText = "OnlineOrderFlag";
      this.onlineOrderFlagDataGridViewCheckBoxColumn.Name = "onlineOrderFlagDataGridViewCheckBoxColumn";
      // 
      // orderDateDataGridViewTextBoxColumn1
      // 
      this.orderDateDataGridViewTextBoxColumn1.DataPropertyName = "OrderDate";
      this.orderDateDataGridViewTextBoxColumn1.HeaderText = "OrderDate";
      this.orderDateDataGridViewTextBoxColumn1.Name = "orderDateDataGridViewTextBoxColumn1";
      // 
      // purchaseOrderNumberDataGridViewTextBoxColumn
      // 
      this.purchaseOrderNumberDataGridViewTextBoxColumn.DataPropertyName = "PurchaseOrderNumber";
      this.purchaseOrderNumberDataGridViewTextBoxColumn.HeaderText = "PurchaseOrderNumber";
      this.purchaseOrderNumberDataGridViewTextBoxColumn.Name = "purchaseOrderNumberDataGridViewTextBoxColumn";
      // 
      // revisionNumberDataGridViewTextBoxColumn
      // 
      this.revisionNumberDataGridViewTextBoxColumn.DataPropertyName = "RevisionNumber";
      this.revisionNumberDataGridViewTextBoxColumn.HeaderText = "RevisionNumber";
      this.revisionNumberDataGridViewTextBoxColumn.Name = "revisionNumberDataGridViewTextBoxColumn";
      // 
      // rowguidDataGridViewTextBoxColumn
      // 
      this.rowguidDataGridViewTextBoxColumn.DataPropertyName = "Rowguid";
      this.rowguidDataGridViewTextBoxColumn.HeaderText = "Rowguid";
      this.rowguidDataGridViewTextBoxColumn.Name = "rowguidDataGridViewTextBoxColumn";
      // 
      // salesOrderIDDataGridViewTextBoxColumn
      // 
      this.salesOrderIDDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderID";
      this.salesOrderIDDataGridViewTextBoxColumn.HeaderText = "SalesOrderID";
      this.salesOrderIDDataGridViewTextBoxColumn.Name = "salesOrderIDDataGridViewTextBoxColumn";
      // 
      // salesOrderNumberDataGridViewTextBoxColumn1
      // 
      this.salesOrderNumberDataGridViewTextBoxColumn1.DataPropertyName = "SalesOrderNumber";
      this.salesOrderNumberDataGridViewTextBoxColumn1.HeaderText = "SalesOrderNumber";
      this.salesOrderNumberDataGridViewTextBoxColumn1.Name = "salesOrderNumberDataGridViewTextBoxColumn1";
      this.salesOrderNumberDataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // salesPersonIDDataGridViewTextBoxColumn
      // 
      this.salesPersonIDDataGridViewTextBoxColumn.DataPropertyName = "SalesPersonID";
      this.salesPersonIDDataGridViewTextBoxColumn.HeaderText = "SalesPersonID";
      this.salesPersonIDDataGridViewTextBoxColumn.Name = "salesPersonIDDataGridViewTextBoxColumn";
      // 
      // shipDateDataGridViewTextBoxColumn
      // 
      this.shipDateDataGridViewTextBoxColumn.DataPropertyName = "ShipDate";
      this.shipDateDataGridViewTextBoxColumn.HeaderText = "ShipDate";
      this.shipDateDataGridViewTextBoxColumn.Name = "shipDateDataGridViewTextBoxColumn";
      // 
      // shipMethodIDDataGridViewTextBoxColumn
      // 
      this.shipMethodIDDataGridViewTextBoxColumn.DataPropertyName = "ShipMethodID";
      this.shipMethodIDDataGridViewTextBoxColumn.HeaderText = "ShipMethodID";
      this.shipMethodIDDataGridViewTextBoxColumn.Name = "shipMethodIDDataGridViewTextBoxColumn";
      // 
      // shipToAddressIDDataGridViewTextBoxColumn
      // 
      this.shipToAddressIDDataGridViewTextBoxColumn.DataPropertyName = "ShipToAddressID";
      this.shipToAddressIDDataGridViewTextBoxColumn.HeaderText = "ShipToAddressID";
      this.shipToAddressIDDataGridViewTextBoxColumn.Name = "shipToAddressIDDataGridViewTextBoxColumn";
      // 
      // statusDataGridViewTextBoxColumn
      // 
      this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
      this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
      this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
      // 
      // subTotalDataGridViewTextBoxColumn
      // 
      this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
      this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
      this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
      // 
      // taxAmtDataGridViewTextBoxColumn
      // 
      this.taxAmtDataGridViewTextBoxColumn.DataPropertyName = "TaxAmt";
      this.taxAmtDataGridViewTextBoxColumn.HeaderText = "TaxAmt";
      this.taxAmtDataGridViewTextBoxColumn.Name = "taxAmtDataGridViewTextBoxColumn";
      // 
      // territoryIDDataGridViewTextBoxColumn
      // 
      this.territoryIDDataGridViewTextBoxColumn.DataPropertyName = "TerritoryID";
      this.territoryIDDataGridViewTextBoxColumn.HeaderText = "TerritoryID";
      this.territoryIDDataGridViewTextBoxColumn.Name = "territoryIDDataGridViewTextBoxColumn";
      // 
      // totalDueDataGridViewTextBoxColumn1
      // 
      this.totalDueDataGridViewTextBoxColumn1.DataPropertyName = "TotalDue";
      this.totalDueDataGridViewTextBoxColumn1.HeaderText = "TotalDue";
      this.totalDueDataGridViewTextBoxColumn1.Name = "totalDueDataGridViewTextBoxColumn1";
      this.totalDueDataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // billingAddressDataGridViewTextBoxColumn
      // 
      this.billingAddressDataGridViewTextBoxColumn.DataPropertyName = "BillingAddress";
      this.billingAddressDataGridViewTextBoxColumn.HeaderText = "BillingAddress";
      this.billingAddressDataGridViewTextBoxColumn.Name = "billingAddressDataGridViewTextBoxColumn";
      // 
      // shippingAddressDataGridViewTextBoxColumn
      // 
      this.shippingAddressDataGridViewTextBoxColumn.DataPropertyName = "ShippingAddress";
      this.shippingAddressDataGridViewTextBoxColumn.HeaderText = "ShippingAddress";
      this.shippingAddressDataGridViewTextBoxColumn.Name = "shippingAddressDataGridViewTextBoxColumn";
      // 
      // contactDataGridViewTextBoxColumn
      // 
      this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
      this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
      this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
      // 
      // shipMethodDataGridViewTextBoxColumn
      // 
      this.shipMethodDataGridViewTextBoxColumn.DataPropertyName = "ShipMethod";
      this.shipMethodDataGridViewTextBoxColumn.HeaderText = "ShipMethod";
      this.shipMethodDataGridViewTextBoxColumn.Name = "shipMethodDataGridViewTextBoxColumn";
      // 
      // creditCardDataGridViewTextBoxColumn
      // 
      this.creditCardDataGridViewTextBoxColumn.DataPropertyName = "CreditCard";
      this.creditCardDataGridViewTextBoxColumn.HeaderText = "CreditCard";
      this.creditCardDataGridViewTextBoxColumn.Name = "creditCardDataGridViewTextBoxColumn";
      // 
      // currencyRateDataGridViewTextBoxColumn
      // 
      this.currencyRateDataGridViewTextBoxColumn.DataPropertyName = "CurrencyRate";
      this.currencyRateDataGridViewTextBoxColumn.HeaderText = "CurrencyRate";
      this.currencyRateDataGridViewTextBoxColumn.Name = "currencyRateDataGridViewTextBoxColumn";
      // 
      // customerDataGridViewTextBoxColumn
      // 
      this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
      this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
      this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
      // 
      // customerViewRelatedDataGridViewTextBoxColumn
      // 
      this.customerViewRelatedDataGridViewTextBoxColumn.DataPropertyName = "CustomerViewRelated";
      this.customerViewRelatedDataGridViewTextBoxColumn.HeaderText = "CustomerViewRelated";
      this.customerViewRelatedDataGridViewTextBoxColumn.Name = "customerViewRelatedDataGridViewTextBoxColumn";
      // 
      // individualDataGridViewTextBoxColumn
      // 
      this.individualDataGridViewTextBoxColumn.DataPropertyName = "Individual";
      this.individualDataGridViewTextBoxColumn.HeaderText = "Individual";
      this.individualDataGridViewTextBoxColumn.Name = "individualDataGridViewTextBoxColumn";
      // 
      // salesPersonDataGridViewTextBoxColumn
      // 
      this.salesPersonDataGridViewTextBoxColumn.DataPropertyName = "SalesPerson";
      this.salesPersonDataGridViewTextBoxColumn.HeaderText = "SalesPerson";
      this.salesPersonDataGridViewTextBoxColumn.Name = "salesPersonDataGridViewTextBoxColumn";
      // 
      // salesTerritoryDataGridViewTextBoxColumn
      // 
      this.salesTerritoryDataGridViewTextBoxColumn.DataPropertyName = "SalesTerritory";
      this.salesTerritoryDataGridViewTextBoxColumn.HeaderText = "SalesTerritory";
      this.salesTerritoryDataGridViewTextBoxColumn.Name = "salesTerritoryDataGridViewTextBoxColumn";
      // 
      // customerCityDataGridViewTextBoxColumn1
      // 
      this.customerCityDataGridViewTextBoxColumn1.DataPropertyName = "CustomerCity";
      this.customerCityDataGridViewTextBoxColumn1.HeaderText = "CustomerCity";
      this.customerCityDataGridViewTextBoxColumn1.Name = "customerCityDataGridViewTextBoxColumn1";
      // 
      // customerCountryDataGridViewTextBoxColumn1
      // 
      this.customerCountryDataGridViewTextBoxColumn1.DataPropertyName = "CustomerCountry";
      this.customerCountryDataGridViewTextBoxColumn1.HeaderText = "CustomerCountry";
      this.customerCountryDataGridViewTextBoxColumn1.Name = "customerCountryDataGridViewTextBoxColumn1";
      // 
      // customerFirstNameDataGridViewTextBoxColumn1
      // 
      this.customerFirstNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerFirstName";
      this.customerFirstNameDataGridViewTextBoxColumn1.HeaderText = "CustomerFirstName";
      this.customerFirstNameDataGridViewTextBoxColumn1.Name = "customerFirstNameDataGridViewTextBoxColumn1";
      // 
      // customerLastNameDataGridViewTextBoxColumn1
      // 
      this.customerLastNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerLastName";
      this.customerLastNameDataGridViewTextBoxColumn1.HeaderText = "CustomerLastName";
      this.customerLastNameDataGridViewTextBoxColumn1.Name = "customerLastNameDataGridViewTextBoxColumn1";
      // 
      // customerStateDataGridViewTextBoxColumn1
      // 
      this.customerStateDataGridViewTextBoxColumn1.DataPropertyName = "CustomerState";
      this.customerStateDataGridViewTextBoxColumn1.HeaderText = "CustomerState";
      this.customerStateDataGridViewTextBoxColumn1.Name = "customerStateDataGridViewTextBoxColumn1";
      // 
      // customerZipDataGridViewTextBoxColumn1
      // 
      this.customerZipDataGridViewTextBoxColumn1.DataPropertyName = "CustomerZip";
      this.customerZipDataGridViewTextBoxColumn1.HeaderText = "CustomerZip";
      this.customerZipDataGridViewTextBoxColumn1.Name = "customerZipDataGridViewTextBoxColumn1";
      // 
      // accountNumberDataGridViewTextBoxColumn1
      // 
      this.accountNumberDataGridViewTextBoxColumn1.DataPropertyName = "AccountNumber";
      this.accountNumberDataGridViewTextBoxColumn1.HeaderText = "AccountNumber";
      this.accountNumberDataGridViewTextBoxColumn1.Name = "accountNumberDataGridViewTextBoxColumn1";
      // 
      // billToAddressIDDataGridViewTextBoxColumn1
      // 
      this.billToAddressIDDataGridViewTextBoxColumn1.DataPropertyName = "BillToAddressID";
      this.billToAddressIDDataGridViewTextBoxColumn1.HeaderText = "BillToAddressID";
      this.billToAddressIDDataGridViewTextBoxColumn1.Name = "billToAddressIDDataGridViewTextBoxColumn1";
      // 
      // commentDataGridViewTextBoxColumn1
      // 
      this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
      this.commentDataGridViewTextBoxColumn1.HeaderText = "Comment";
      this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
      // 
      // contactIDDataGridViewTextBoxColumn1
      // 
      this.contactIDDataGridViewTextBoxColumn1.DataPropertyName = "ContactID";
      this.contactIDDataGridViewTextBoxColumn1.HeaderText = "ContactID";
      this.contactIDDataGridViewTextBoxColumn1.Name = "contactIDDataGridViewTextBoxColumn1";
      // 
      // creditCardApprovalCodeDataGridViewTextBoxColumn1
      // 
      this.creditCardApprovalCodeDataGridViewTextBoxColumn1.DataPropertyName = "CreditCardApprovalCode";
      this.creditCardApprovalCodeDataGridViewTextBoxColumn1.HeaderText = "CreditCardApprovalCode";
      this.creditCardApprovalCodeDataGridViewTextBoxColumn1.Name = "creditCardApprovalCodeDataGridViewTextBoxColumn1";
      // 
      // creditCardIDDataGridViewTextBoxColumn1
      // 
      this.creditCardIDDataGridViewTextBoxColumn1.DataPropertyName = "CreditCardID";
      this.creditCardIDDataGridViewTextBoxColumn1.HeaderText = "CreditCardID";
      this.creditCardIDDataGridViewTextBoxColumn1.Name = "creditCardIDDataGridViewTextBoxColumn1";
      // 
      // currencyRateIDDataGridViewTextBoxColumn1
      // 
      this.currencyRateIDDataGridViewTextBoxColumn1.DataPropertyName = "CurrencyRateID";
      this.currencyRateIDDataGridViewTextBoxColumn1.HeaderText = "CurrencyRateID";
      this.currencyRateIDDataGridViewTextBoxColumn1.Name = "currencyRateIDDataGridViewTextBoxColumn1";
      // 
      // customerIDDataGridViewTextBoxColumn1
      // 
      this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
      this.customerIDDataGridViewTextBoxColumn1.HeaderText = "CustomerID";
      this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
      // 
      // dueDateDataGridViewTextBoxColumn1
      // 
      this.dueDateDataGridViewTextBoxColumn1.DataPropertyName = "DueDate";
      this.dueDateDataGridViewTextBoxColumn1.HeaderText = "DueDate";
      this.dueDateDataGridViewTextBoxColumn1.Name = "dueDateDataGridViewTextBoxColumn1";
      // 
      // freightDataGridViewTextBoxColumn1
      // 
      this.freightDataGridViewTextBoxColumn1.DataPropertyName = "Freight";
      this.freightDataGridViewTextBoxColumn1.HeaderText = "Freight";
      this.freightDataGridViewTextBoxColumn1.Name = "freightDataGridViewTextBoxColumn1";
      // 
      // modifiedDateDataGridViewTextBoxColumn1
      // 
      this.modifiedDateDataGridViewTextBoxColumn1.DataPropertyName = "ModifiedDate";
      this.modifiedDateDataGridViewTextBoxColumn1.HeaderText = "ModifiedDate";
      this.modifiedDateDataGridViewTextBoxColumn1.Name = "modifiedDateDataGridViewTextBoxColumn1";
      // 
      // onlineOrderFlagDataGridViewCheckBoxColumn1
      // 
      this.onlineOrderFlagDataGridViewCheckBoxColumn1.DataPropertyName = "OnlineOrderFlag";
      this.onlineOrderFlagDataGridViewCheckBoxColumn1.HeaderText = "OnlineOrderFlag";
      this.onlineOrderFlagDataGridViewCheckBoxColumn1.Name = "onlineOrderFlagDataGridViewCheckBoxColumn1";
      // 
      // orderDateDataGridViewTextBoxColumn2
      // 
      this.orderDateDataGridViewTextBoxColumn2.DataPropertyName = "OrderDate";
      this.orderDateDataGridViewTextBoxColumn2.HeaderText = "OrderDate";
      this.orderDateDataGridViewTextBoxColumn2.Name = "orderDateDataGridViewTextBoxColumn2";
      // 
      // purchaseOrderNumberDataGridViewTextBoxColumn1
      // 
      this.purchaseOrderNumberDataGridViewTextBoxColumn1.DataPropertyName = "PurchaseOrderNumber";
      this.purchaseOrderNumberDataGridViewTextBoxColumn1.HeaderText = "PurchaseOrderNumber";
      this.purchaseOrderNumberDataGridViewTextBoxColumn1.Name = "purchaseOrderNumberDataGridViewTextBoxColumn1";
      // 
      // revisionNumberDataGridViewTextBoxColumn1
      // 
      this.revisionNumberDataGridViewTextBoxColumn1.DataPropertyName = "RevisionNumber";
      this.revisionNumberDataGridViewTextBoxColumn1.HeaderText = "RevisionNumber";
      this.revisionNumberDataGridViewTextBoxColumn1.Name = "revisionNumberDataGridViewTextBoxColumn1";
      // 
      // rowguidDataGridViewTextBoxColumn1
      // 
      this.rowguidDataGridViewTextBoxColumn1.DataPropertyName = "Rowguid";
      this.rowguidDataGridViewTextBoxColumn1.HeaderText = "Rowguid";
      this.rowguidDataGridViewTextBoxColumn1.Name = "rowguidDataGridViewTextBoxColumn1";
      // 
      // salesOrderIDDataGridViewTextBoxColumn1
      // 
      this.salesOrderIDDataGridViewTextBoxColumn1.DataPropertyName = "SalesOrderID";
      this.salesOrderIDDataGridViewTextBoxColumn1.HeaderText = "SalesOrderID";
      this.salesOrderIDDataGridViewTextBoxColumn1.Name = "salesOrderIDDataGridViewTextBoxColumn1";
      // 
      // salesOrderNumberDataGridViewTextBoxColumn2
      // 
      this.salesOrderNumberDataGridViewTextBoxColumn2.DataPropertyName = "SalesOrderNumber";
      this.salesOrderNumberDataGridViewTextBoxColumn2.HeaderText = "SalesOrderNumber";
      this.salesOrderNumberDataGridViewTextBoxColumn2.Name = "salesOrderNumberDataGridViewTextBoxColumn2";
      this.salesOrderNumberDataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // salesPersonIDDataGridViewTextBoxColumn1
      // 
      this.salesPersonIDDataGridViewTextBoxColumn1.DataPropertyName = "SalesPersonID";
      this.salesPersonIDDataGridViewTextBoxColumn1.HeaderText = "SalesPersonID";
      this.salesPersonIDDataGridViewTextBoxColumn1.Name = "salesPersonIDDataGridViewTextBoxColumn1";
      // 
      // shipDateDataGridViewTextBoxColumn1
      // 
      this.shipDateDataGridViewTextBoxColumn1.DataPropertyName = "ShipDate";
      this.shipDateDataGridViewTextBoxColumn1.HeaderText = "ShipDate";
      this.shipDateDataGridViewTextBoxColumn1.Name = "shipDateDataGridViewTextBoxColumn1";
      // 
      // shipMethodIDDataGridViewTextBoxColumn1
      // 
      this.shipMethodIDDataGridViewTextBoxColumn1.DataPropertyName = "ShipMethodID";
      this.shipMethodIDDataGridViewTextBoxColumn1.HeaderText = "ShipMethodID";
      this.shipMethodIDDataGridViewTextBoxColumn1.Name = "shipMethodIDDataGridViewTextBoxColumn1";
      // 
      // shipToAddressIDDataGridViewTextBoxColumn1
      // 
      this.shipToAddressIDDataGridViewTextBoxColumn1.DataPropertyName = "ShipToAddressID";
      this.shipToAddressIDDataGridViewTextBoxColumn1.HeaderText = "ShipToAddressID";
      this.shipToAddressIDDataGridViewTextBoxColumn1.Name = "shipToAddressIDDataGridViewTextBoxColumn1";
      // 
      // statusDataGridViewTextBoxColumn1
      // 
      this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
      this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
      this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
      // 
      // subTotalDataGridViewTextBoxColumn1
      // 
      this.subTotalDataGridViewTextBoxColumn1.DataPropertyName = "SubTotal";
      this.subTotalDataGridViewTextBoxColumn1.HeaderText = "SubTotal";
      this.subTotalDataGridViewTextBoxColumn1.Name = "subTotalDataGridViewTextBoxColumn1";
      // 
      // taxAmtDataGridViewTextBoxColumn1
      // 
      this.taxAmtDataGridViewTextBoxColumn1.DataPropertyName = "TaxAmt";
      this.taxAmtDataGridViewTextBoxColumn1.HeaderText = "TaxAmt";
      this.taxAmtDataGridViewTextBoxColumn1.Name = "taxAmtDataGridViewTextBoxColumn1";
      // 
      // territoryIDDataGridViewTextBoxColumn1
      // 
      this.territoryIDDataGridViewTextBoxColumn1.DataPropertyName = "TerritoryID";
      this.territoryIDDataGridViewTextBoxColumn1.HeaderText = "TerritoryID";
      this.territoryIDDataGridViewTextBoxColumn1.Name = "territoryIDDataGridViewTextBoxColumn1";
      // 
      // totalDueDataGridViewTextBoxColumn2
      // 
      this.totalDueDataGridViewTextBoxColumn2.DataPropertyName = "TotalDue";
      this.totalDueDataGridViewTextBoxColumn2.HeaderText = "TotalDue";
      this.totalDueDataGridViewTextBoxColumn2.Name = "totalDueDataGridViewTextBoxColumn2";
      this.totalDueDataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // billingAddressDataGridViewTextBoxColumn1
      // 
      this.billingAddressDataGridViewTextBoxColumn1.DataPropertyName = "BillingAddress";
      this.billingAddressDataGridViewTextBoxColumn1.HeaderText = "BillingAddress";
      this.billingAddressDataGridViewTextBoxColumn1.Name = "billingAddressDataGridViewTextBoxColumn1";
      // 
      // shippingAddressDataGridViewTextBoxColumn1
      // 
      this.shippingAddressDataGridViewTextBoxColumn1.DataPropertyName = "ShippingAddress";
      this.shippingAddressDataGridViewTextBoxColumn1.HeaderText = "ShippingAddress";
      this.shippingAddressDataGridViewTextBoxColumn1.Name = "shippingAddressDataGridViewTextBoxColumn1";
      // 
      // contactDataGridViewTextBoxColumn1
      // 
      this.contactDataGridViewTextBoxColumn1.DataPropertyName = "Contact";
      this.contactDataGridViewTextBoxColumn1.HeaderText = "Contact";
      this.contactDataGridViewTextBoxColumn1.Name = "contactDataGridViewTextBoxColumn1";
      // 
      // shipMethodDataGridViewTextBoxColumn1
      // 
      this.shipMethodDataGridViewTextBoxColumn1.DataPropertyName = "ShipMethod";
      this.shipMethodDataGridViewTextBoxColumn1.HeaderText = "ShipMethod";
      this.shipMethodDataGridViewTextBoxColumn1.Name = "shipMethodDataGridViewTextBoxColumn1";
      // 
      // creditCardDataGridViewTextBoxColumn1
      // 
      this.creditCardDataGridViewTextBoxColumn1.DataPropertyName = "CreditCard";
      this.creditCardDataGridViewTextBoxColumn1.HeaderText = "CreditCard";
      this.creditCardDataGridViewTextBoxColumn1.Name = "creditCardDataGridViewTextBoxColumn1";
      // 
      // currencyRateDataGridViewTextBoxColumn1
      // 
      this.currencyRateDataGridViewTextBoxColumn1.DataPropertyName = "CurrencyRate";
      this.currencyRateDataGridViewTextBoxColumn1.HeaderText = "CurrencyRate";
      this.currencyRateDataGridViewTextBoxColumn1.Name = "currencyRateDataGridViewTextBoxColumn1";
      // 
      // customerDataGridViewTextBoxColumn1
      // 
      this.customerDataGridViewTextBoxColumn1.DataPropertyName = "Customer";
      this.customerDataGridViewTextBoxColumn1.HeaderText = "Customer";
      this.customerDataGridViewTextBoxColumn1.Name = "customerDataGridViewTextBoxColumn1";
      // 
      // customerViewRelatedDataGridViewTextBoxColumn1
      // 
      this.customerViewRelatedDataGridViewTextBoxColumn1.DataPropertyName = "CustomerViewRelated";
      this.customerViewRelatedDataGridViewTextBoxColumn1.HeaderText = "CustomerViewRelated";
      this.customerViewRelatedDataGridViewTextBoxColumn1.Name = "customerViewRelatedDataGridViewTextBoxColumn1";
      // 
      // individualDataGridViewTextBoxColumn1
      // 
      this.individualDataGridViewTextBoxColumn1.DataPropertyName = "Individual";
      this.individualDataGridViewTextBoxColumn1.HeaderText = "Individual";
      this.individualDataGridViewTextBoxColumn1.Name = "individualDataGridViewTextBoxColumn1";
      // 
      // salesPersonDataGridViewTextBoxColumn1
      // 
      this.salesPersonDataGridViewTextBoxColumn1.DataPropertyName = "SalesPerson";
      this.salesPersonDataGridViewTextBoxColumn1.HeaderText = "SalesPerson";
      this.salesPersonDataGridViewTextBoxColumn1.Name = "salesPersonDataGridViewTextBoxColumn1";
      // 
      // salesTerritoryDataGridViewTextBoxColumn1
      // 
      this.salesTerritoryDataGridViewTextBoxColumn1.DataPropertyName = "SalesTerritory";
      this.salesTerritoryDataGridViewTextBoxColumn1.HeaderText = "SalesTerritory";
      this.salesTerritoryDataGridViewTextBoxColumn1.Name = "salesTerritoryDataGridViewTextBoxColumn1";
      // 
      // customerCityDataGridViewTextBoxColumn2
      // 
      this.customerCityDataGridViewTextBoxColumn2.DataPropertyName = "CustomerCity";
      this.customerCityDataGridViewTextBoxColumn2.HeaderText = "CustomerCity";
      this.customerCityDataGridViewTextBoxColumn2.Name = "customerCityDataGridViewTextBoxColumn2";
      // 
      // customerCountryDataGridViewTextBoxColumn2
      // 
      this.customerCountryDataGridViewTextBoxColumn2.DataPropertyName = "CustomerCountry";
      this.customerCountryDataGridViewTextBoxColumn2.HeaderText = "CustomerCountry";
      this.customerCountryDataGridViewTextBoxColumn2.Name = "customerCountryDataGridViewTextBoxColumn2";
      // 
      // customerFirstNameDataGridViewTextBoxColumn2
      // 
      this.customerFirstNameDataGridViewTextBoxColumn2.DataPropertyName = "CustomerFirstName";
      this.customerFirstNameDataGridViewTextBoxColumn2.HeaderText = "CustomerFirstName";
      this.customerFirstNameDataGridViewTextBoxColumn2.Name = "customerFirstNameDataGridViewTextBoxColumn2";
      // 
      // customerLastNameDataGridViewTextBoxColumn2
      // 
      this.customerLastNameDataGridViewTextBoxColumn2.DataPropertyName = "CustomerLastName";
      this.customerLastNameDataGridViewTextBoxColumn2.HeaderText = "CustomerLastName";
      this.customerLastNameDataGridViewTextBoxColumn2.Name = "customerLastNameDataGridViewTextBoxColumn2";
      // 
      // customerStateDataGridViewTextBoxColumn2
      // 
      this.customerStateDataGridViewTextBoxColumn2.DataPropertyName = "CustomerState";
      this.customerStateDataGridViewTextBoxColumn2.HeaderText = "CustomerState";
      this.customerStateDataGridViewTextBoxColumn2.Name = "customerStateDataGridViewTextBoxColumn2";
      // 
      // customerZipDataGridViewTextBoxColumn2
      // 
      this.customerZipDataGridViewTextBoxColumn2.DataPropertyName = "CustomerZip";
      this.customerZipDataGridViewTextBoxColumn2.HeaderText = "CustomerZip";
      this.customerZipDataGridViewTextBoxColumn2.Name = "customerZipDataGridViewTextBoxColumn2";
      // 
      // FrmOrderSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(775, 593);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "FrmOrderSearch";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Tag = "True";
      this.Text = "Order Search";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderSearch_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrderSearch_FormClosed);
      this.Load += new System.EventHandler(this.frmOrderSearch_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingNavigator)).EndInit();
      this.salesOrderHeaderEntityBindingNavigator.ResumeLayout(false);
      this.salesOrderHeaderEntityBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingSource)).EndInit();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBoxLLBLQueryType.ResumeLayout(false);
      this.groupBoxLLBLQueryType.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).EndInit();
      this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker searchWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown numericUpDownNumRows;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxPrefetch;
        private OrderSearchCriteria orderSearchCriteria1;
        private System.Windows.Forms.GroupBox groupBoxLLBLQueryType;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButtonQuerySpec;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBoxFilterUsingCustomerViewRelated;
        private System.Windows.Forms.BindingSource salesOrderHeaderEntityBindingSource;
        private Korzh.EasyQuery.Db.DbModel dataModel1;
        private Korzh.EasyQuery.Db.DbQuery query1;
        private System.Windows.Forms.CheckBox checkBoxShowCustomerViewRelatedFields;
        private System.Windows.Forms.CheckBox checkBoxUsePredicate;
        private Korzh.EasyQuery.WinControls.QueryPanel QPanel;
        private System.Windows.Forms.BindingNavigator salesOrderHeaderEntityBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView salesOrderHeaderEntityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerZipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBoxUseEasyQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billToAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardApprovalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyRateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onlineOrderFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPersonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipMethodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipToAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn territoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerViewRelatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesTerritoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCountryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerStateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerZipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn billToAddressIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardApprovalCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyRateIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onlineOrderFlagDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderNumberDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPersonIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipMethodIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipToAddressIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxAmtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn territoryIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDueDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingAddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingAddressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipMethodDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyRateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerViewRelatedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPersonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesTerritoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCityDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCountryDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerStateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerZipDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel2;
    }
}