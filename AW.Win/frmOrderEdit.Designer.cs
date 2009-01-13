namespace AW.Win
{
    partial class frmOrderEdit
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderEdit));
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
          this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
          this.label8 = new System.Windows.Forms.Label();
          this.label3 = new System.Windows.Forms.Label();
          this.label1 = new System.Windows.Forms.Label();
          this.label5 = new System.Windows.Forms.Label();
          this.label2 = new System.Windows.Forms.Label();
          this.label7 = new System.Windows.Forms.Label();
          this.label9 = new System.Windows.Forms.Label();
          this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
          this.salesOrderHeaderEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
          this.dtpShipDate = new System.Windows.Forms.DateTimePicker();
          this.cbOnlineOrder = new System.Windows.Forms.CheckBox();
          this.tbPurchaseOrder = new System.Windows.Forms.TextBox();
          this.cbShipMethod = new System.Windows.Forms.ComboBox();
          this.tbCustomer = new System.Windows.Forms.TextBox();
          this.tbContact = new System.Windows.Forms.TextBox();
          this.label11 = new System.Windows.Forms.Label();
          this.tbSubtotal = new System.Windows.Forms.TextBox();
          this.label12 = new System.Windows.Forms.Label();
          this.tbTax = new System.Windows.Forms.TextBox();
          this.label13 = new System.Windows.Forms.Label();
          this.tbFreight = new System.Windows.Forms.TextBox();
          this.label14 = new System.Windows.Forms.Label();
          this.lblTotal = new System.Windows.Forms.Label();
          this.toolStrip1 = new System.Windows.Forms.ToolStrip();
          this.tspSave = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
          this.tspClose = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
          this.tspDelete = new System.Windows.Forms.ToolStripButton();
          this.toolStripButtonViewEntity = new System.Windows.Forms.ToolStripButton();
          this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
          this.dgvDetail = new System.Windows.Forms.DataGridView();
          this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.orderQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.unitPriceDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.lineTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.salesOrderDetailCollection1 = new AW.Data.CollectionClasses.SalesOrderDetailCollection();
          this.myError = new System.Windows.Forms.ErrorProvider(this.components);
          this.toolStripButtonRefetch = new System.Windows.Forms.ToolStripButton();
          this.toolStripButtonRevert = new System.Windows.Forms.ToolStripButton();
          this.tableLayoutPanel1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingSource)).BeginInit();
          this.toolStrip1.SuspendLayout();
          this.tableLayoutPanel2.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.myError)).BeginInit();
          this.SuspendLayout();
          // 
          // tableLayoutPanel1
          // 
          this.tableLayoutPanel1.ColumnCount = 4;
          this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
          this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
          this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
          this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
          this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
          this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
          this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
          this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
          this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
          this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
          this.tableLayoutPanel1.Controls.Add(this.label9, 2, 1);
          this.tableLayoutPanel1.Controls.Add(this.dtpOrderDate, 1, 0);
          this.tableLayoutPanel1.Controls.Add(this.dtpDueDate, 1, 1);
          this.tableLayoutPanel1.Controls.Add(this.dtpShipDate, 1, 2);
          this.tableLayoutPanel1.Controls.Add(this.cbOnlineOrder, 1, 3);
          this.tableLayoutPanel1.Controls.Add(this.tbPurchaseOrder, 1, 4);
          this.tableLayoutPanel1.Controls.Add(this.cbShipMethod, 1, 5);
          this.tableLayoutPanel1.Controls.Add(this.tbCustomer, 3, 0);
          this.tableLayoutPanel1.Controls.Add(this.tbContact, 3, 1);
          this.tableLayoutPanel1.Controls.Add(this.label11, 2, 2);
          this.tableLayoutPanel1.Controls.Add(this.tbSubtotal, 3, 2);
          this.tableLayoutPanel1.Controls.Add(this.label12, 2, 3);
          this.tableLayoutPanel1.Controls.Add(this.tbTax, 3, 3);
          this.tableLayoutPanel1.Controls.Add(this.label13, 2, 4);
          this.tableLayoutPanel1.Controls.Add(this.tbFreight, 3, 4);
          this.tableLayoutPanel1.Controls.Add(this.label14, 2, 5);
          this.tableLayoutPanel1.Controls.Add(this.lblTotal, 3, 5);
          this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
          this.tableLayoutPanel1.Name = "tableLayoutPanel1";
          this.tableLayoutPanel1.RowCount = 6;
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
          this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 149);
          this.tableLayoutPanel1.TabIndex = 0;
          // 
          // label8
          // 
          this.label8.AutoSize = true;
          this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label8.Location = new System.Drawing.Point(3, 0);
          this.label8.Name = "label8";
          this.label8.Size = new System.Drawing.Size(88, 25);
          this.label8.TabIndex = 10;
          this.label8.Text = "Order Date:";
          this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label3.Location = new System.Drawing.Point(3, 25);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(88, 25);
          this.label3.TabIndex = 13;
          this.label3.Text = "Due Date:";
          this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label1.Location = new System.Drawing.Point(3, 50);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(88, 25);
          this.label1.TabIndex = 11;
          this.label1.Text = "Ship Date:";
          this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label5
          // 
          this.label5.AutoSize = true;
          this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label5.Location = new System.Drawing.Point(3, 100);
          this.label5.Name = "label5";
          this.label5.Size = new System.Drawing.Size(88, 25);
          this.label5.TabIndex = 15;
          this.label5.Text = "P.O. #:";
          this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label2.Location = new System.Drawing.Point(3, 125);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(88, 25);
          this.label2.TabIndex = 17;
          this.label2.Text = "Ship Method:";
          this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label7
          // 
          this.label7.AutoSize = true;
          this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label7.Location = new System.Drawing.Point(318, 0);
          this.label7.Name = "label7";
          this.label7.Size = new System.Drawing.Size(88, 25);
          this.label7.TabIndex = 18;
          this.label7.Text = "Customer:";
          this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label9
          // 
          this.label9.AutoSize = true;
          this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label9.Location = new System.Drawing.Point(318, 25);
          this.label9.Name = "label9";
          this.label9.Size = new System.Drawing.Size(88, 25);
          this.label9.TabIndex = 19;
          this.label9.Text = "Contact:";
          this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // dtpOrderDate
          // 
          this.dtpOrderDate.Checked = false;
          this.dtpOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesOrderHeaderEntityBindingSource, "OrderDate", true));
          this.dtpOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
          this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
          this.dtpOrderDate.Location = new System.Drawing.Point(97, 3);
          this.dtpOrderDate.Name = "dtpOrderDate";
          this.dtpOrderDate.Size = new System.Drawing.Size(215, 20);
          this.dtpOrderDate.TabIndex = 26;
          // 
          // salesOrderHeaderEntityBindingSource
          // 
          this.salesOrderHeaderEntityBindingSource.DataSource = typeof(AW.Data.EntityClasses.SalesOrderHeaderEntity);
          // 
          // dtpDueDate
          // 
          this.dtpDueDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesOrderHeaderEntityBindingSource, "DueDate", true));
          this.dtpDueDate.Dock = System.Windows.Forms.DockStyle.Fill;
          this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
          this.dtpDueDate.Location = new System.Drawing.Point(97, 28);
          this.dtpDueDate.Name = "dtpDueDate";
          this.dtpDueDate.Size = new System.Drawing.Size(215, 20);
          this.dtpDueDate.TabIndex = 27;
          // 
          // dtpShipDate
          // 
          this.dtpShipDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesOrderHeaderEntityBindingSource, "ShipDate", true));
          this.dtpShipDate.Dock = System.Windows.Forms.DockStyle.Fill;
          this.dtpShipDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
          this.dtpShipDate.Location = new System.Drawing.Point(97, 53);
          this.dtpShipDate.Name = "dtpShipDate";
          this.dtpShipDate.ShowCheckBox = true;
          this.dtpShipDate.Size = new System.Drawing.Size(215, 20);
          this.dtpShipDate.TabIndex = 28;
          // 
          // cbOnlineOrder
          // 
          this.cbOnlineOrder.AutoSize = true;
          this.cbOnlineOrder.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.salesOrderHeaderEntityBindingSource, "OnlineOrderFlag", true));
          this.cbOnlineOrder.Dock = System.Windows.Forms.DockStyle.Fill;
          this.cbOnlineOrder.Location = new System.Drawing.Point(97, 78);
          this.cbOnlineOrder.Name = "cbOnlineOrder";
          this.cbOnlineOrder.Size = new System.Drawing.Size(215, 19);
          this.cbOnlineOrder.TabIndex = 29;
          this.cbOnlineOrder.Text = "Online Order";
          this.cbOnlineOrder.UseVisualStyleBackColor = true;
          // 
          // tbPurchaseOrder
          // 
          this.tbPurchaseOrder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderHeaderEntityBindingSource, "PurchaseOrderNumber", true));
          this.tbPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tbPurchaseOrder.Location = new System.Drawing.Point(97, 103);
          this.tbPurchaseOrder.Name = "tbPurchaseOrder";
          this.tbPurchaseOrder.Size = new System.Drawing.Size(215, 20);
          this.tbPurchaseOrder.TabIndex = 30;
          this.tbPurchaseOrder.TextChanged += new System.EventHandler(this.tbPurchaseOrder_TextChanged);
          // 
          // cbShipMethod
          // 
          this.cbShipMethod.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesOrderHeaderEntityBindingSource, "ShipMethodId", true));
          this.cbShipMethod.DisplayMember = "AddressCollectionViaSalesOrderHeader";
          this.cbShipMethod.Dock = System.Windows.Forms.DockStyle.Fill;
          this.cbShipMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.cbShipMethod.FormattingEnabled = true;
          this.cbShipMethod.Location = new System.Drawing.Point(97, 128);
          this.cbShipMethod.Name = "cbShipMethod";
          this.cbShipMethod.Size = new System.Drawing.Size(215, 21);
          this.cbShipMethod.TabIndex = 38;
          this.cbShipMethod.ValueMember = "AddressCollectionViaSalesOrderHeader";
          // 
          // tbCustomer
          // 
          this.tbCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderHeaderEntityBindingSource, "CustomerViewRelated.DisplayName", true));
          this.tbCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tbCustomer.Location = new System.Drawing.Point(412, 3);
          this.tbCustomer.Name = "tbCustomer";
          this.tbCustomer.ReadOnly = true;
          this.tbCustomer.Size = new System.Drawing.Size(217, 20);
          this.tbCustomer.TabIndex = 39;
          // 
          // tbContact
          // 
          this.tbContact.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tbContact.Location = new System.Drawing.Point(412, 28);
          this.tbContact.Name = "tbContact";
          this.tbContact.ReadOnly = true;
          this.tbContact.Size = new System.Drawing.Size(217, 20);
          this.tbContact.TabIndex = 40;
          // 
          // label11
          // 
          this.label11.AutoSize = true;
          this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label11.Location = new System.Drawing.Point(318, 50);
          this.label11.Name = "label11";
          this.label11.Size = new System.Drawing.Size(88, 25);
          this.label11.TabIndex = 21;
          this.label11.Text = "Subtotal ($):";
          this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // tbSubtotal
          // 
          this.tbSubtotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderHeaderEntityBindingSource, "SubTotal", true));
          this.tbSubtotal.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tbSubtotal.Location = new System.Drawing.Point(412, 53);
          this.tbSubtotal.Name = "tbSubtotal";
          this.tbSubtotal.Size = new System.Drawing.Size(217, 20);
          this.tbSubtotal.TabIndex = 41;
          this.tbSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
          // 
          // label12
          // 
          this.label12.AutoSize = true;
          this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label12.Location = new System.Drawing.Point(318, 75);
          this.label12.Name = "label12";
          this.label12.Size = new System.Drawing.Size(88, 25);
          this.label12.TabIndex = 22;
          this.label12.Text = "Tax ($):";
          this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // tbTax
          // 
          this.tbTax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderHeaderEntityBindingSource, "TaxAmt", true));
          this.tbTax.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tbTax.Location = new System.Drawing.Point(412, 78);
          this.tbTax.Name = "tbTax";
          this.tbTax.Size = new System.Drawing.Size(217, 20);
          this.tbTax.TabIndex = 42;
          this.tbTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
          // 
          // label13
          // 
          this.label13.AutoSize = true;
          this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label13.Location = new System.Drawing.Point(318, 100);
          this.label13.Name = "label13";
          this.label13.Size = new System.Drawing.Size(88, 25);
          this.label13.TabIndex = 23;
          this.label13.Text = "Freight ($):";
          this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // tbFreight
          // 
          this.tbFreight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderHeaderEntityBindingSource, "Freight", true));
          this.tbFreight.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tbFreight.Location = new System.Drawing.Point(412, 103);
          this.tbFreight.Name = "tbFreight";
          this.tbFreight.Size = new System.Drawing.Size(217, 20);
          this.tbFreight.TabIndex = 36;
          this.tbFreight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
          // 
          // label14
          // 
          this.label14.AutoSize = true;
          this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label14.Location = new System.Drawing.Point(318, 125);
          this.label14.Name = "label14";
          this.label14.Size = new System.Drawing.Size(88, 25);
          this.label14.TabIndex = 24;
          this.label14.Text = "Total ($):";
          this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // lblTotal
          // 
          this.lblTotal.AutoSize = true;
          this.lblTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesOrderHeaderEntityBindingSource, "TotalDue", true));
          this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
          this.lblTotal.Location = new System.Drawing.Point(412, 125);
          this.lblTotal.Name = "lblTotal";
          this.lblTotal.Size = new System.Drawing.Size(217, 25);
          this.lblTotal.TabIndex = 37;
          this.lblTotal.Text = "lblTotal";
          this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // toolStrip1
          // 
          this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspSave,
            this.toolStripSeparator1,
            this.tspClose,
            this.toolStripSeparator2,
            this.tspDelete,
            this.toolStripButtonViewEntity,
            this.toolStripButtonRefetch,
            this.toolStripButtonRevert});
          this.toolStrip1.Location = new System.Drawing.Point(0, 0);
          this.toolStrip1.Name = "toolStrip1";
          this.toolStrip1.Size = new System.Drawing.Size(642, 25);
          this.toolStrip1.TabIndex = 1;
          this.toolStrip1.Text = "toolStrip1";
          // 
          // tspSave
          // 
          this.tspSave.Image = ((System.Drawing.Image)(resources.GetObject("tspSave.Image")));
          this.tspSave.ImageTransparentColor = System.Drawing.Color.Black;
          this.tspSave.Name = "tspSave";
          this.tspSave.Size = new System.Drawing.Size(51, 22);
          this.tspSave.Text = "Save";
          this.tspSave.Click += new System.EventHandler(this.tspSave_Click);
          // 
          // toolStripSeparator1
          // 
          this.toolStripSeparator1.Name = "toolStripSeparator1";
          this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
          // 
          // tspClose
          // 
          this.tspClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
          this.tspClose.Image = ((System.Drawing.Image)(resources.GetObject("tspClose.Image")));
          this.tspClose.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tspClose.Name = "tspClose";
          this.tspClose.Size = new System.Drawing.Size(37, 22);
          this.tspClose.Text = "Close";
          this.tspClose.Click += new System.EventHandler(this.tspClose_Click);
          // 
          // toolStripSeparator2
          // 
          this.toolStripSeparator2.Name = "toolStripSeparator2";
          this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
          // 
          // tspDelete
          // 
          this.tspDelete.Image = ((System.Drawing.Image)(resources.GetObject("tspDelete.Image")));
          this.tspDelete.ImageTransparentColor = System.Drawing.Color.Black;
          this.tspDelete.Name = "tspDelete";
          this.tspDelete.Size = new System.Drawing.Size(58, 22);
          this.tspDelete.Text = "Delete";
          this.tspDelete.Click += new System.EventHandler(this.tspDelete_Click);
          // 
          // toolStripButtonViewEntity
          // 
          this.toolStripButtonViewEntity.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewEntity.Image")));
          this.toolStripButtonViewEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.toolStripButtonViewEntity.Name = "toolStripButtonViewEntity";
          this.toolStripButtonViewEntity.Size = new System.Drawing.Size(80, 22);
          this.toolStripButtonViewEntity.Text = "View Entity";
          this.toolStripButtonViewEntity.Click += new System.EventHandler(this.toolStripButtonViewEntity_Click);
          // 
          // tableLayoutPanel2
          // 
          this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
          this.tableLayoutPanel2.ColumnCount = 1;
          this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
          this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
          this.tableLayoutPanel2.Controls.Add(this.dgvDetail, 0, 1);
          this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 25);
          this.tableLayoutPanel2.Name = "tableLayoutPanel2";
          this.tableLayoutPanel2.RowCount = 2;
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
          this.tableLayoutPanel2.Size = new System.Drawing.Size(642, 351);
          this.tableLayoutPanel2.TabIndex = 39;
          // 
          // dgvDetail
          // 
          this.dgvDetail.AllowUserToAddRows = false;
          this.dgvDetail.AllowUserToDeleteRows = false;
          this.dgvDetail.AllowUserToResizeColumns = false;
          this.dgvDetail.AllowUserToResizeRows = false;
          this.dgvDetail.AutoGenerateColumns = false;
          this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
          this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.orderQtyDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.unitPriceDiscountDataGridViewTextBoxColumn,
            this.lineTotalDataGridViewTextBoxColumn});
          this.dgvDetail.DataSource = this.salesOrderDetailCollection1;
          this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
          this.dgvDetail.Location = new System.Drawing.Point(5, 162);
          this.dgvDetail.Name = "dgvDetail";
          this.dgvDetail.RowHeadersVisible = false;
          this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
          this.dgvDetail.Size = new System.Drawing.Size(632, 184);
          this.dgvDetail.TabIndex = 38;
          // 
          // ProductName
          // 
          this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
          this.ProductName.DataPropertyName = "ProductName";
          this.ProductName.HeaderText = "Name";
          this.ProductName.Name = "ProductName";
          this.ProductName.ReadOnly = true;
          this.ProductName.Width = 60;
          // 
          // orderQtyDataGridViewTextBoxColumn
          // 
          this.orderQtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
          this.orderQtyDataGridViewTextBoxColumn.DataPropertyName = "OrderQty";
          dataGridViewCellStyle1.Format = "N0";
          dataGridViewCellStyle1.NullValue = null;
          this.orderQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
          this.orderQtyDataGridViewTextBoxColumn.HeaderText = "#";
          this.orderQtyDataGridViewTextBoxColumn.Name = "orderQtyDataGridViewTextBoxColumn";
          this.orderQtyDataGridViewTextBoxColumn.Width = 39;
          // 
          // unitPriceDataGridViewTextBoxColumn
          // 
          this.unitPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
          this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
          dataGridViewCellStyle2.Format = "C2";
          dataGridViewCellStyle2.NullValue = null;
          this.unitPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
          this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Price/Unit";
          this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
          this.unitPriceDataGridViewTextBoxColumn.Width = 80;
          // 
          // unitPriceDiscountDataGridViewTextBoxColumn
          // 
          this.unitPriceDiscountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
          this.unitPriceDiscountDataGridViewTextBoxColumn.DataPropertyName = "UnitPriceDiscount";
          dataGridViewCellStyle3.Format = "C2";
          dataGridViewCellStyle3.NullValue = null;
          this.unitPriceDiscountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
          this.unitPriceDiscountDataGridViewTextBoxColumn.HeaderText = "Discount/Unit";
          this.unitPriceDiscountDataGridViewTextBoxColumn.Name = "unitPriceDiscountDataGridViewTextBoxColumn";
          this.unitPriceDiscountDataGridViewTextBoxColumn.Width = 98;
          // 
          // lineTotalDataGridViewTextBoxColumn
          // 
          this.lineTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
          this.lineTotalDataGridViewTextBoxColumn.DataPropertyName = "LineTotal";
          dataGridViewCellStyle4.Format = "C2";
          dataGridViewCellStyle4.NullValue = null;
          this.lineTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
          this.lineTotalDataGridViewTextBoxColumn.HeaderText = "Total";
          this.lineTotalDataGridViewTextBoxColumn.Name = "lineTotalDataGridViewTextBoxColumn";
          this.lineTotalDataGridViewTextBoxColumn.ReadOnly = true;
          // 
          // salesOrderDetailCollection1
          // 
          this.salesOrderDetailCollection1.ActiveContext = null;
          this.salesOrderDetailCollection1.AllowEdit = true;
          this.salesOrderDetailCollection1.AllowNew = true;
          this.salesOrderDetailCollection1.AllowRemove = false;
          this.salesOrderDetailCollection1.Capacity = 0;
          this.salesOrderDetailCollection1.ConcurrencyPredicateFactoryToUse = null;
          this.salesOrderDetailCollection1.DoNotPerformAddIfPresent = true;
          this.salesOrderDetailCollection1.EntityFactoryToUse = new AW.Data.FactoryClasses.SalesOrderDetailEntityFactory();
          this.salesOrderDetailCollection1.IsReadOnly = false;
          this.salesOrderDetailCollection1.MaxNumberOfItemsToReturn = ((long)(0));
          this.salesOrderDetailCollection1.RemovedEntitiesTracker = null;
          this.salesOrderDetailCollection1.SortClauses = null;
          this.salesOrderDetailCollection1.SuppressClearInGetMulti = false;
          this.salesOrderDetailCollection1.Transaction = null;
          // 
          // myError
          // 
          this.myError.ContainerControl = this;
          this.myError.DataSource = this.salesOrderHeaderEntityBindingSource;
          // 
          // toolStripButtonRefetch
          // 
          this.toolStripButtonRefetch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefetch.Image")));
          this.toolStripButtonRefetch.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.toolStripButtonRefetch.Name = "toolStripButtonRefetch";
          this.toolStripButtonRefetch.Size = new System.Drawing.Size(101, 22);
          this.toolStripButtonRefetch.Text = "Reload from DB";
          this.toolStripButtonRefetch.Click += new System.EventHandler(this.toolStripButtonRefetch_Click);
          // 
          // toolStripButtonRevert
          // 
          this.toolStripButtonRevert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRevert.Image")));
          this.toolStripButtonRevert.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.toolStripButtonRevert.Name = "toolStripButtonRevert";
          this.toolStripButtonRevert.Size = new System.Drawing.Size(116, 22);
          this.toolStripButtonRevert.Text = "Revert all changes";
          this.toolStripButtonRevert.Click += new System.EventHandler(this.toolStripButtonRevert_Click);
          // 
          // frmOrderEdit
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(642, 376);
          this.Controls.Add(this.tableLayoutPanel2);
          this.Controls.Add(this.toolStrip1);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
          this.Name = "frmOrderEdit";
          this.ShowInTaskbar = false;
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "Order Edit";
          this.Load += new System.EventHandler(this.frmOrderEdit_Load);
          this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderEdit_FormClosing);
          this.tableLayoutPanel1.ResumeLayout(false);
          this.tableLayoutPanel1.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingSource)).EndInit();
          this.toolStrip1.ResumeLayout(false);
          this.toolStrip1.PerformLayout();
          this.tableLayoutPanel2.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.myError)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tspSave;
        private System.Windows.Forms.ToolStripButton tspClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tspDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpShipDate;
        private System.Windows.Forms.CheckBox cbOnlineOrder;
        private System.Windows.Forms.TextBox tbPurchaseOrder;
        private System.Windows.Forms.TextBox tbFreight;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.ComboBox cbShipMethod;
        private AW.Data.CollectionClasses.SalesOrderDetailCollection salesOrderDetailCollection1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbTax;
        private System.Windows.Forms.ErrorProvider myError;
        private System.Windows.Forms.BindingSource salesOrderHeaderEntityBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewEntity;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefetch;
        private System.Windows.Forms.ToolStripButton toolStripButtonRevert;
    }
}