namespace AW.Win
{
    partial class frmOrderSearch
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
          this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
          this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
          this.label9 = new System.Windows.Forms.Label();
          this.tbCity = new System.Windows.Forms.TextBox();
          this.label8 = new System.Windows.Forms.Label();
          this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
          this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
          this.label1 = new System.Windows.Forms.Label();
          this.label2 = new System.Windows.Forms.Label();
          this.label3 = new System.Windows.Forms.Label();
          this.label4 = new System.Windows.Forms.Label();
          this.label5 = new System.Windows.Forms.Label();
          this.label6 = new System.Windows.Forms.Label();
          this.label7 = new System.Windows.Forms.Label();
          this.tbZip = new System.Windows.Forms.TextBox();
          this.tbFirstName = new System.Windows.Forms.TextBox();
          this.tbLastName = new System.Windows.Forms.TextBox();
          this.cbState = new System.Windows.Forms.ComboBox();
          this.cbCountry = new System.Windows.Forms.ComboBox();
          this.tbOrderID = new System.Windows.Forms.TextBox();
          this.panel1 = new System.Windows.Forms.Panel();
          this.numericUpDownNumRows = new System.Windows.Forms.NumericUpDown();
          this.checkBoxUseLinq = new System.Windows.Forms.CheckBox();
          this.btnSearch = new System.Windows.Forms.Button();
          this.dgResults = new System.Windows.Forms.DataGridView();
          this.salesOrderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
          this.salesOrderHeaderCollection1 = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
          this.searchWorker = new System.ComponentModel.BackgroundWorker();
          this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
          this.tableLayoutPanel1.SuspendLayout();
          this.tableLayoutPanel2.SuspendLayout();
          this.panel1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
          this.contextMenuStrip1.SuspendLayout();
          this.SuspendLayout();
          // 
          // tableLayoutPanel1
          // 
          this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
          this.tableLayoutPanel1.ColumnCount = 1;
          this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
          this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
          this.tableLayoutPanel1.Controls.Add(this.dgResults, 0, 1);
          this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
          this.tableLayoutPanel1.Name = "tableLayoutPanel1";
          this.tableLayoutPanel1.RowCount = 2;
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
          this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 578);
          this.tableLayoutPanel1.TabIndex = 0;
          // 
          // tableLayoutPanel2
          // 
          this.tableLayoutPanel2.ColumnCount = 4;
          this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
          this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
          this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
          this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
          this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
          this.tableLayoutPanel2.Controls.Add(this.tbCity, 3, 0);
          this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
          this.tableLayoutPanel2.Controls.Add(this.dtpDateFrom, 1, 0);
          this.tableLayoutPanel2.Controls.Add(this.dtpDateTo, 1, 1);
          this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
          this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
          this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
          this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
          this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
          this.tableLayoutPanel2.Controls.Add(this.label6, 2, 2);
          this.tableLayoutPanel2.Controls.Add(this.label7, 2, 3);
          this.tableLayoutPanel2.Controls.Add(this.tbZip, 3, 3);
          this.tableLayoutPanel2.Controls.Add(this.tbFirstName, 1, 2);
          this.tableLayoutPanel2.Controls.Add(this.tbLastName, 1, 3);
          this.tableLayoutPanel2.Controls.Add(this.cbState, 3, 1);
          this.tableLayoutPanel2.Controls.Add(this.cbCountry, 3, 2);
          this.tableLayoutPanel2.Controls.Add(this.tbOrderID, 1, 4);
          this.tableLayoutPanel2.Controls.Add(this.panel1, 3, 4);
          this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
          this.tableLayoutPanel2.Name = "tableLayoutPanel2";
          this.tableLayoutPanel2.RowCount = 5;
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
          this.tableLayoutPanel2.Size = new System.Drawing.Size(684, 129);
          this.tableLayoutPanel2.TabIndex = 0;
          // 
          // label9
          // 
          this.label9.AutoSize = true;
          this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label9.Location = new System.Drawing.Point(3, 100);
          this.label9.Name = "label9";
          this.label9.Size = new System.Drawing.Size(62, 29);
          this.label9.TabIndex = 18;
          this.label9.Text = "Order ID:";
          this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // tbCity
          // 
          this.tbCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "City", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.tbCity.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tbCity.Location = new System.Drawing.Point(412, 3);
          this.tbCity.Name = "tbCity";
          this.tbCity.Size = new System.Drawing.Size(269, 20);
          this.tbCity.TabIndex = 16;
          this.tbCity.Text = global::AW.Win.Properties.Settings.Default.City;
          // 
          // label8
          // 
          this.label8.AutoSize = true;
          this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label8.Location = new System.Drawing.Point(3, 0);
          this.label8.Name = "label8";
          this.label8.Size = new System.Drawing.Size(62, 25);
          this.label8.TabIndex = 9;
          this.label8.Text = "From Date:";
          this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // dtpDateFrom
          // 
          this.dtpDateFrom.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AW.Win.Properties.Settings.Default, "DateFrom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.dtpDateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
          this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
          this.dtpDateFrom.Location = new System.Drawing.Point(71, 3);
          this.dtpDateFrom.Name = "dtpDateFrom";
          this.dtpDateFrom.ShowCheckBox = true;
          this.dtpDateFrom.Size = new System.Drawing.Size(267, 20);
          this.dtpDateFrom.TabIndex = 0;
          this.dtpDateFrom.Value = global::AW.Win.Properties.Settings.Default.DateFrom;
          // 
          // dtpDateTo
          // 
          this.dtpDateTo.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AW.Win.Properties.Settings.Default, "DateTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.dtpDateTo.Dock = System.Windows.Forms.DockStyle.Fill;
          this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
          this.dtpDateTo.Location = new System.Drawing.Point(71, 28);
          this.dtpDateTo.Name = "dtpDateTo";
          this.dtpDateTo.ShowCheckBox = true;
          this.dtpDateTo.Size = new System.Drawing.Size(267, 20);
          this.dtpDateTo.TabIndex = 1;
          this.dtpDateTo.Value = global::AW.Win.Properties.Settings.Default.DateTo;
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label1.Location = new System.Drawing.Point(3, 25);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(62, 25);
          this.label1.TabIndex = 2;
          this.label1.Text = "To Date:";
          this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label2.Location = new System.Drawing.Point(3, 50);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(62, 25);
          this.label2.TabIndex = 3;
          this.label2.Text = "First Name:";
          this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label3.Location = new System.Drawing.Point(3, 75);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(62, 25);
          this.label3.TabIndex = 4;
          this.label3.Text = "Last Name:";
          this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label4
          // 
          this.label4.AutoSize = true;
          this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label4.Location = new System.Drawing.Point(344, 0);
          this.label4.Name = "label4";
          this.label4.Size = new System.Drawing.Size(62, 25);
          this.label4.TabIndex = 5;
          this.label4.Text = "City:";
          this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label5
          // 
          this.label5.AutoSize = true;
          this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label5.Location = new System.Drawing.Point(344, 25);
          this.label5.Name = "label5";
          this.label5.Size = new System.Drawing.Size(62, 25);
          this.label5.TabIndex = 6;
          this.label5.Text = "State:";
          this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label6
          // 
          this.label6.AutoSize = true;
          this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label6.Location = new System.Drawing.Point(344, 50);
          this.label6.Name = "label6";
          this.label6.Size = new System.Drawing.Size(62, 25);
          this.label6.TabIndex = 7;
          this.label6.Text = "Country:";
          this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label7
          // 
          this.label7.AutoSize = true;
          this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
          this.label7.Location = new System.Drawing.Point(344, 75);
          this.label7.Name = "label7";
          this.label7.Size = new System.Drawing.Size(62, 25);
          this.label7.TabIndex = 8;
          this.label7.Text = "Zip:";
          this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // tbZip
          // 
          this.tbZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "Zip", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.tbZip.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tbZip.Location = new System.Drawing.Point(412, 78);
          this.tbZip.Name = "tbZip";
          this.tbZip.Size = new System.Drawing.Size(269, 20);
          this.tbZip.TabIndex = 13;
          this.tbZip.Text = global::AW.Win.Properties.Settings.Default.Zip;
          // 
          // tbFirstName
          // 
          this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "FirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.tbFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tbFirstName.Location = new System.Drawing.Point(71, 53);
          this.tbFirstName.Name = "tbFirstName";
          this.tbFirstName.Size = new System.Drawing.Size(267, 20);
          this.tbFirstName.TabIndex = 11;
          this.tbFirstName.Text = global::AW.Win.Properties.Settings.Default.FirstName;
          // 
          // tbLastName
          // 
          this.tbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "LastName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.tbLastName.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tbLastName.Location = new System.Drawing.Point(71, 78);
          this.tbLastName.Name = "tbLastName";
          this.tbLastName.Size = new System.Drawing.Size(267, 20);
          this.tbLastName.TabIndex = 12;
          this.tbLastName.Text = global::AW.Win.Properties.Settings.Default.LastName;
          // 
          // cbState
          // 
          this.cbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
          this.cbState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
          this.cbState.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "State", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.cbState.Dock = System.Windows.Forms.DockStyle.Fill;
          this.cbState.FormattingEnabled = true;
          this.cbState.Location = new System.Drawing.Point(412, 28);
          this.cbState.Name = "cbState";
          this.cbState.Size = new System.Drawing.Size(269, 21);
          this.cbState.TabIndex = 14;
          this.cbState.Text = global::AW.Win.Properties.Settings.Default.State;
          // 
          // cbCountry
          // 
          this.cbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
          this.cbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
          this.cbCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "Country", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.cbCountry.Dock = System.Windows.Forms.DockStyle.Fill;
          this.cbCountry.FormattingEnabled = true;
          this.cbCountry.Location = new System.Drawing.Point(412, 53);
          this.cbCountry.Name = "cbCountry";
          this.cbCountry.Size = new System.Drawing.Size(269, 21);
          this.cbCountry.TabIndex = 15;
          this.cbCountry.Text = global::AW.Win.Properties.Settings.Default.Country;
          // 
          // tbOrderID
          // 
          this.tbOrderID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "OrderID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.tbOrderID.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tbOrderID.Location = new System.Drawing.Point(71, 103);
          this.tbOrderID.Name = "tbOrderID";
          this.tbOrderID.Size = new System.Drawing.Size(267, 20);
          this.tbOrderID.TabIndex = 17;
          this.tbOrderID.Text = global::AW.Win.Properties.Settings.Default.OrderID;
          // 
          // panel1
          // 
          this.panel1.Controls.Add(this.numericUpDownNumRows);
          this.panel1.Controls.Add(this.checkBoxUseLinq);
          this.panel1.Controls.Add(this.btnSearch);
          this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.panel1.Location = new System.Drawing.Point(412, 103);
          this.panel1.Name = "panel1";
          this.panel1.Size = new System.Drawing.Size(269, 23);
          this.panel1.TabIndex = 22;
          // 
          // numericUpDownNumRows
          // 
          this.numericUpDownNumRows.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AW.Win.Properties.Settings.Default, "NumRows", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.numericUpDownNumRows.Location = new System.Drawing.Point(201, 2);
          this.numericUpDownNumRows.Name = "numericUpDownNumRows";
          this.numericUpDownNumRows.Size = new System.Drawing.Size(48, 20);
          this.numericUpDownNumRows.TabIndex = 23;
          this.toolTip1.SetToolTip(this.numericUpDownNumRows, "max Number Of Items To Return");
          this.numericUpDownNumRows.Value = global::AW.Win.Properties.Settings.Default.NumRows;
          // 
          // checkBoxUseLinq
          // 
          this.checkBoxUseLinq.AutoSize = true;
          this.checkBoxUseLinq.Checked = global::AW.Win.Properties.Settings.Default.UseLinq;
          this.checkBoxUseLinq.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Win.Properties.Settings.Default, "UseLinq", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
          this.checkBoxUseLinq.Location = new System.Drawing.Point(102, 4);
          this.checkBoxUseLinq.Name = "checkBoxUseLinq";
          this.checkBoxUseLinq.Size = new System.Drawing.Size(65, 17);
          this.checkBoxUseLinq.TabIndex = 22;
          this.checkBoxUseLinq.Text = "UseLinq";
          this.checkBoxUseLinq.UseVisualStyleBackColor = true;
          // 
          // btnSearch
          // 
          this.btnSearch.Location = new System.Drawing.Point(3, 0);
          this.btnSearch.Name = "btnSearch";
          this.btnSearch.Size = new System.Drawing.Size(75, 22);
          this.btnSearch.TabIndex = 21;
          this.btnSearch.Text = "Search";
          this.btnSearch.UseVisualStyleBackColor = true;
          this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
          // 
          // dgResults
          // 
          this.dgResults.AllowUserToAddRows = false;
          this.dgResults.AutoGenerateColumns = false;
          this.dgResults.BackgroundColor = System.Drawing.Color.White;
          this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dgResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesOrderIdDataGridViewTextBoxColumn,
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
          this.dgResults.DataSource = this.salesOrderHeaderCollection1;
          this.dgResults.Dock = System.Windows.Forms.DockStyle.Fill;
          this.dgResults.Location = new System.Drawing.Point(5, 142);
          this.dgResults.Name = "dgResults";
          this.dgResults.RowHeadersVisible = false;
          this.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
          this.dgResults.Size = new System.Drawing.Size(684, 431);
          this.dgResults.TabIndex = 1;
          this.dgResults.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResults_CellContentDoubleClick);
          // 
          // salesOrderIdDataGridViewTextBoxColumn
          // 
          this.salesOrderIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
          this.salesOrderIdDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderId";
          this.salesOrderIdDataGridViewTextBoxColumn.HeaderText = "ID";
          this.salesOrderIdDataGridViewTextBoxColumn.Name = "salesOrderIdDataGridViewTextBoxColumn";
          this.salesOrderIdDataGridViewTextBoxColumn.ReadOnly = true;
          this.salesOrderIdDataGridViewTextBoxColumn.Width = 43;
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
          dataGridViewCellStyle1.Format = "d";
          dataGridViewCellStyle1.NullValue = null;
          this.orderDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
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
          dataGridViewCellStyle2.Format = "C2";
          dataGridViewCellStyle2.NullValue = null;
          this.totalDueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
          this.totalDueDataGridViewTextBoxColumn.HeaderText = "Total";
          this.totalDueDataGridViewTextBoxColumn.Name = "totalDueDataGridViewTextBoxColumn";
          this.totalDueDataGridViewTextBoxColumn.ReadOnly = true;
          // 
          // contextMenuStrip1
          // 
          this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem});
          this.contextMenuStrip1.Name = "contextMenuStrip1";
          this.contextMenuStrip1.Size = new System.Drawing.Size(138, 26);
          // 
          // newOrderToolStripMenuItem
          // 
          this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
          this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
          this.newOrderToolStripMenuItem.Text = "New Order";
          this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
          // 
          // salesOrderHeaderCollection1
          // 
          this.salesOrderHeaderCollection1.ActiveContext = null;
          this.salesOrderHeaderCollection1.AllowEdit = true;
          this.salesOrderHeaderCollection1.AllowNew = true;
          this.salesOrderHeaderCollection1.AllowRemove = false;
          this.salesOrderHeaderCollection1.Capacity = 0;
          this.salesOrderHeaderCollection1.ConcurrencyPredicateFactoryToUse = null;
          this.salesOrderHeaderCollection1.DoNotPerformAddIfPresent = true;
          this.salesOrderHeaderCollection1.EntityFactoryToUse = new AW.Data.FactoryClasses.SalesOrderHeaderEntityFactory();
          this.salesOrderHeaderCollection1.IsReadOnly = false;
          this.salesOrderHeaderCollection1.MaxNumberOfItemsToReturn = ((long)(0));
          this.salesOrderHeaderCollection1.RemovedEntitiesTracker = null;
          this.salesOrderHeaderCollection1.SortClauses = null;
          this.salesOrderHeaderCollection1.SuppressClearInGetMulti = false;
          this.salesOrderHeaderCollection1.Transaction = null;
          // 
          // searchWorker
          // 
          this.searchWorker.WorkerSupportsCancellation = true;
          this.searchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchWorker_DoWork);
          this.searchWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searchWorker_RunWorkerCompleted);
          // 
          // frmOrderSearch
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(694, 578);
          this.Controls.Add(this.tableLayoutPanel1);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
          this.Name = "frmOrderSearch";
          this.ShowInTaskbar = false;
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Tag = "True";
          this.Text = "Order Search";
          this.Load += new System.EventHandler(this.frmOrderSearch_Load);
          this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrderSearch_FormClosed);
          this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderSearch_FormClosing);
          this.tableLayoutPanel1.ResumeLayout(false);
          this.tableLayoutPanel2.ResumeLayout(false);
          this.tableLayoutPanel2.PerformLayout();
          this.panel1.ResumeLayout(false);
          this.panel1.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
          this.contextMenuStrip1.ResumeLayout(false);
          this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.TextBox tbOrderID;
        private AW.Data.CollectionClasses.SalesOrderHeaderCollection salesOrderHeaderCollection1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerZipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker searchWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox checkBoxUseLinq;
        private System.Windows.Forms.NumericUpDown numericUpDownNumRows;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}