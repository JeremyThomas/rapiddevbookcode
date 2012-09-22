namespace AW.Win
{
		partial class FrmOrderSearch2
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderSearch2));
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
      this.label6 = new System.Windows.Forms.Label();
      this.tbFirstName = new System.Windows.Forms.TextBox();
      this.tbLastName = new System.Windows.Forms.TextBox();
      this.tbOrderID = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.buttonClear = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.numericUpDownNumRows = new System.Windows.Forms.NumericUpDown();
      this.tbZip = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.cbState = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.listBoxCountry = new System.Windows.Forms.ListBox();
      this.buttonClearCountries = new System.Windows.Forms.Button();
      this.salesOrderHeaderEntityDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.salesOrderHeaderEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.searchWorker = new System.ComponentModel.BackgroundWorker();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.salesOrderHeaderEntityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tableLayoutPanel2.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingSource)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingNavigator)).BeginInit();
      this.salesOrderHeaderEntityBindingNavigator.SuspendLayout();
      this.SuspendLayout();
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
      this.tableLayoutPanel2.Controls.Add(this.label6, 2, 2);
      this.tableLayoutPanel2.Controls.Add(this.tbFirstName, 1, 2);
      this.tableLayoutPanel2.Controls.Add(this.tbLastName, 1, 3);
      this.tableLayoutPanel2.Controls.Add(this.tbOrderID, 1, 4);
      this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 5);
      this.tableLayoutPanel2.Controls.Add(this.tbZip, 3, 1);
      this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
      this.tableLayoutPanel2.Controls.Add(this.cbState, 3, 5);
      this.tableLayoutPanel2.Controls.Add(this.label5, 2, 5);
      this.tableLayoutPanel2.Controls.Add(this.listBoxCountry, 3, 2);
      this.tableLayoutPanel2.Controls.Add(this.buttonClearCountries, 2, 3);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 6;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(694, 170);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label9.Location = new System.Drawing.Point(3, 100);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(63, 32);
      this.label9.TabIndex = 18;
      this.label9.Text = "Order ID:";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbCity
      // 
      this.tbCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "City", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbCity.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbCity.Location = new System.Drawing.Point(418, 3);
      this.tbCity.Name = "tbCity";
      this.tbCity.Size = new System.Drawing.Size(273, 20);
      this.tbCity.TabIndex = 16;
      this.tbCity.Text = global::AW.Win.Properties.Settings.Default.City;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label8.Location = new System.Drawing.Point(3, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(63, 25);
      this.label8.TabIndex = 9;
      this.label8.Text = "From Date:";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // dtpDateFrom
      // 
      this.dtpDateFrom.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AW.Win.Properties.Settings.Default, "DateFrom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.dtpDateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpDateFrom.Location = new System.Drawing.Point(72, 3);
      this.dtpDateFrom.Name = "dtpDateFrom";
      this.dtpDateFrom.ShowCheckBox = true;
      this.dtpDateFrom.Size = new System.Drawing.Size(271, 20);
      this.dtpDateFrom.TabIndex = 0;
      this.dtpDateFrom.Value = global::AW.Win.Properties.Settings.Default.DateFrom;
      // 
      // dtpDateTo
      // 
      this.dtpDateTo.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AW.Win.Properties.Settings.Default, "DateTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.dtpDateTo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpDateTo.Location = new System.Drawing.Point(72, 28);
      this.dtpDateTo.Name = "dtpDateTo";
      this.dtpDateTo.ShowCheckBox = true;
      this.dtpDateTo.Size = new System.Drawing.Size(271, 20);
      this.dtpDateTo.TabIndex = 1;
      this.dtpDateTo.Value = global::AW.Win.Properties.Settings.Default.DateTo;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 25);
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
      this.label2.Size = new System.Drawing.Size(63, 25);
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
      this.label3.Size = new System.Drawing.Size(63, 25);
      this.label3.TabIndex = 4;
      this.label3.Text = "Last Name:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label4.Location = new System.Drawing.Point(349, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 25);
      this.label4.TabIndex = 5;
      this.label4.Text = "City:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label6.Location = new System.Drawing.Point(349, 50);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(63, 25);
      this.label6.TabIndex = 7;
      this.label6.Text = "Country:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbFirstName
      // 
      this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "FirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbFirstName.Location = new System.Drawing.Point(72, 53);
      this.tbFirstName.Name = "tbFirstName";
      this.tbFirstName.Size = new System.Drawing.Size(271, 20);
      this.tbFirstName.TabIndex = 11;
      this.tbFirstName.Text = global::AW.Win.Properties.Settings.Default.FirstName;
      // 
      // tbLastName
      // 
      this.tbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "LastName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbLastName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbLastName.Location = new System.Drawing.Point(72, 78);
      this.tbLastName.Name = "tbLastName";
      this.tbLastName.Size = new System.Drawing.Size(271, 20);
      this.tbLastName.TabIndex = 12;
      this.tbLastName.Text = global::AW.Win.Properties.Settings.Default.LastName;
      // 
      // tbOrderID
      // 
      this.tbOrderID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "OrderID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbOrderID.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbOrderID.Location = new System.Drawing.Point(72, 103);
      this.tbOrderID.Name = "tbOrderID";
      this.tbOrderID.Size = new System.Drawing.Size(271, 20);
      this.tbOrderID.TabIndex = 17;
      this.tbOrderID.Text = global::AW.Win.Properties.Settings.Default.OrderID;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.buttonClear);
      this.panel1.Controls.Add(this.btnSearch);
      this.panel1.Controls.Add(this.numericUpDownNumRows);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(72, 135);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(271, 32);
      this.panel1.TabIndex = 22;
      // 
      // buttonClear
      // 
      this.buttonClear.Location = new System.Drawing.Point(63, 4);
      this.buttonClear.Name = "buttonClear";
      this.buttonClear.Size = new System.Drawing.Size(54, 23);
      this.buttonClear.TabIndex = 26;
      this.buttonClear.Text = "Clear All";
      this.buttonClear.UseVisualStyleBackColor = true;
      this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(3, 4);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(54, 23);
      this.btnSearch.TabIndex = 21;
      this.btnSearch.Text = "Search";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // numericUpDownNumRows
      // 
      this.numericUpDownNumRows.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AW.Win.Properties.Settings.Default, "NumRows", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.numericUpDownNumRows.Location = new System.Drawing.Point(123, 7);
      this.numericUpDownNumRows.Name = "numericUpDownNumRows";
      this.numericUpDownNumRows.Size = new System.Drawing.Size(63, 20);
      this.numericUpDownNumRows.TabIndex = 23;
      this.toolTip1.SetToolTip(this.numericUpDownNumRows, "max Number Of Items To Return");
      this.numericUpDownNumRows.Value = global::AW.Win.Properties.Settings.Default.NumRows;
      // 
      // tbZip
      // 
      this.tbZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "Zip", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.tbZip.Location = new System.Drawing.Point(418, 28);
      this.tbZip.Name = "tbZip";
      this.tbZip.Size = new System.Drawing.Size(269, 20);
      this.tbZip.TabIndex = 13;
      this.tbZip.Text = global::AW.Win.Properties.Settings.Default.Zip;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label7.Location = new System.Drawing.Point(349, 25);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(63, 25);
      this.label7.TabIndex = 8;
      this.label7.Text = "Zip:";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // cbState
      // 
      this.cbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cbState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cbState.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AW.Win.Properties.Settings.Default, "State", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.cbState.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbState.FormattingEnabled = true;
      this.cbState.Location = new System.Drawing.Point(418, 135);
      this.cbState.Name = "cbState";
      this.cbState.Size = new System.Drawing.Size(273, 21);
      this.cbState.TabIndex = 14;
      this.cbState.Text = global::AW.Win.Properties.Settings.Default.State;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label5.Location = new System.Drawing.Point(349, 132);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(63, 38);
      this.label5.TabIndex = 6;
      this.label5.Text = "State:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // listBoxCountry
      // 
      this.listBoxCountry.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listBoxCountry.FormattingEnabled = true;
      this.listBoxCountry.Location = new System.Drawing.Point(418, 53);
      this.listBoxCountry.Name = "listBoxCountry";
      this.tableLayoutPanel2.SetRowSpan(this.listBoxCountry, 3);
      this.listBoxCountry.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.listBoxCountry.Size = new System.Drawing.Size(273, 76);
      this.listBoxCountry.TabIndex = 24;
      // 
      // buttonClearCountries
      // 
      this.buttonClearCountries.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonClearCountries.Location = new System.Drawing.Point(349, 78);
      this.buttonClearCountries.Name = "buttonClearCountries";
      this.buttonClearCountries.Size = new System.Drawing.Size(63, 19);
      this.buttonClearCountries.TabIndex = 25;
      this.buttonClearCountries.Text = "Clear cnty";
      this.buttonClearCountries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonClearCountries.UseVisualStyleBackColor = true;
      this.buttonClearCountries.Click += new System.EventHandler(this.buttonClearCountries_Click);
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
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
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
      this.salesOrderHeaderEntityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.salesOrderHeaderEntityDataGridView.Location = new System.Drawing.Point(0, 170);
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
      this.salesOrderHeaderEntityDataGridView.Size = new System.Drawing.Size(694, 398);
      this.salesOrderHeaderEntityDataGridView.TabIndex = 2;
      this.salesOrderHeaderEntityDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResults_CellContentDoubleClick);
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
      // dataGridViewTextBoxColumn13
      // 
      this.dataGridViewTextBoxColumn13.DataPropertyName = "SalesOrderNumber";
      this.dataGridViewTextBoxColumn13.HeaderText = "SalesOrderNumber";
      this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
      this.dataGridViewTextBoxColumn13.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn14
      // 
      this.dataGridViewTextBoxColumn14.DataPropertyName = "PurchaseOrderNumber";
      this.dataGridViewTextBoxColumn14.HeaderText = "PurchaseOrderNumber";
      this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
      this.dataGridViewTextBoxColumn14.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn15
      // 
      this.dataGridViewTextBoxColumn15.DataPropertyName = "AccountNumber";
      this.dataGridViewTextBoxColumn15.HeaderText = "AccountNumber";
      this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
      this.dataGridViewTextBoxColumn15.ReadOnly = true;
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
      // salesOrderHeaderEntityBindingSource
      // 
      this.salesOrderHeaderEntityBindingSource.AllowNew = false;
      this.salesOrderHeaderEntityBindingSource.DataSource = typeof(AW.Data.EntityClasses.SalesOrderHeaderEntity);
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
      // searchWorker
      // 
      this.searchWorker.WorkerSupportsCancellation = true;
      this.searchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchWorker_DoWork);
      this.searchWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searchWorker_RunWorkerCompleted);
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
      this.salesOrderHeaderEntityBindingNavigator.Location = new System.Drawing.Point(0, 568);
      this.salesOrderHeaderEntityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.salesOrderHeaderEntityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.salesOrderHeaderEntityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.salesOrderHeaderEntityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.salesOrderHeaderEntityBindingNavigator.Name = "salesOrderHeaderEntityBindingNavigator";
      this.salesOrderHeaderEntityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.salesOrderHeaderEntityBindingNavigator.Size = new System.Drawing.Size(694, 25);
      this.salesOrderHeaderEntityBindingNavigator.TabIndex = 1;
      this.salesOrderHeaderEntityBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
      // FrmOrderSearch2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(694, 593);
      this.Controls.Add(this.salesOrderHeaderEntityDataGridView);
      this.Controls.Add(this.tableLayoutPanel2);
      this.Controls.Add(this.salesOrderHeaderEntityBindingNavigator);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "FrmOrderSearch2";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Tag = "True";
      this.Text = "Order Search No CustomerViewRelated";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderSearch_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrderSearch_FormClosed);
      this.Load += new System.EventHandler(this.frmOrderSearch_Load);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingSource)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingNavigator)).EndInit();
      this.salesOrderHeaderEntityBindingNavigator.ResumeLayout(false);
      this.salesOrderHeaderEntityBindingNavigator.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

				}


				#endregion

				private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
				private System.Windows.Forms.DateTimePicker dtpDateFrom;
				private System.Windows.Forms.DateTimePicker dtpDateTo;
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
				private System.Windows.Forms.TextBox tbOrderID;
				private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
				private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
				private System.ComponentModel.BackgroundWorker searchWorker;
				private System.Windows.Forms.Panel panel1;
				private System.Windows.Forms.Button btnSearch;
				private System.Windows.Forms.NumericUpDown numericUpDownNumRows;
				private System.Windows.Forms.ToolTip toolTip1;
				private System.Windows.Forms.DataGridView salesOrderHeaderEntityDataGridView;
				private System.Windows.Forms.BindingSource salesOrderHeaderEntityBindingSource;
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
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
				private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
				private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
				private System.Windows.Forms.Button buttonClear;
				private System.Windows.Forms.ListBox listBoxCountry;
				private System.Windows.Forms.Button buttonClearCountries;
		}
}