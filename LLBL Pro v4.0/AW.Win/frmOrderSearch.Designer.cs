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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderSearch));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBoxLLBLQueryType = new System.Windows.Forms.GroupBox();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButtonQuerySpec = new System.Windows.Forms.RadioButton();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.checkBoxPrefetch = new System.Windows.Forms.CheckBox();
      this.numericUpDownNumRows = new System.Windows.Forms.NumericUpDown();
      this.btnSearch = new System.Windows.Forms.Button();
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
      this.salesOrderHeaderCollection1 = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
      this.orderSearchCriteria1 = new AW.Win.OrderSearchCriteria();
      this.searchWorker = new System.ComponentModel.BackgroundWorker();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.groupBoxLLBLQueryType.SuspendLayout();
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
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.dgResults, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.orderSearchCriteria1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 578);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.groupBoxLLBLQueryType);
      this.panel1.Controls.Add(this.checkBoxPrefetch);
      this.panel1.Controls.Add(this.numericUpDownNumRows);
      this.panel1.Controls.Add(this.btnSearch);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(5, 182);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(684, 50);
      this.panel1.TabIndex = 22;
      // 
      // groupBoxLLBLQueryType
      // 
      this.groupBoxLLBLQueryType.Controls.Add(this.radioButton3);
      this.groupBoxLLBLQueryType.Controls.Add(this.radioButtonQuerySpec);
      this.groupBoxLLBLQueryType.Controls.Add(this.radioButton1);
      this.groupBoxLLBLQueryType.Location = new System.Drawing.Point(215, 3);
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
      this.checkBoxPrefetch.Location = new System.Drawing.Point(76, 5);
      this.checkBoxPrefetch.Name = "checkBoxPrefetch";
      this.checkBoxPrefetch.Size = new System.Drawing.Size(66, 17);
      this.checkBoxPrefetch.TabIndex = 24;
      this.checkBoxPrefetch.Text = "Prefetch";
      this.checkBoxPrefetch.UseVisualStyleBackColor = true;
      // 
      // numericUpDownNumRows
      // 
      this.numericUpDownNumRows.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AW.Win.Properties.Settings.Default, "NumRows", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.numericUpDownNumRows.Location = new System.Drawing.Point(148, 3);
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
      this.dgResults.DataSource = this.salesOrderHeaderCollection1;
      this.dgResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgResults.Location = new System.Drawing.Point(5, 240);
      this.dgResults.Name = "dgResults";
      this.dgResults.RowHeadersVisible = false;
      this.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgResults.Size = new System.Drawing.Size(684, 431);
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
      this.contextMenuStrip1.Size = new System.Drawing.Size(132, 26);
      // 
      // newOrderToolStripMenuItem
      // 
      this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
      this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
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
      this.salesOrderHeaderCollection1.EntityFactoryToUse = ((SD.LLBLGen.Pro.ORMSupportClasses.IEntityFactory)(resources.GetObject("salesOrderHeaderCollection1.EntityFactoryToUse")));
      this.salesOrderHeaderCollection1.IsReadOnly = false;
      this.salesOrderHeaderCollection1.MaxNumberOfItemsToReturn = ((long)(0));
      this.salesOrderHeaderCollection1.RemovedEntitiesTracker = null;
      this.salesOrderHeaderCollection1.SortClauses = null;
      this.salesOrderHeaderCollection1.SuppressClearInGetMulti = false;
      this.salesOrderHeaderCollection1.Transaction = null;
      // 
      // orderSearchCriteria1
      // 
      this.orderSearchCriteria1.Location = new System.Drawing.Point(5, 5);
      this.orderSearchCriteria1.Name = "orderSearchCriteria1";
      this.orderSearchCriteria1.Size = new System.Drawing.Size(684, 169);
      this.orderSearchCriteria1.TabIndex = 23;
      // 
      // searchWorker
      // 
      this.searchWorker.WorkerSupportsCancellation = true;
      this.searchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchWorker_DoWork);
      this.searchWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searchWorker_RunWorkerCompleted);
      // 
      // FrmOrderSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(694, 578);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "FrmOrderSearch";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Tag = "True";
      this.Text = "Order Search";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderSearch_FormClosing);
      this.Load += new System.EventHandler(this.frmOrderSearch_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBoxLLBLQueryType.ResumeLayout(false);
      this.groupBoxLLBLQueryType.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgResults;
        private AW.Data.CollectionClasses.SalesOrderHeaderCollection salesOrderHeaderCollection1;
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
        private System.Windows.Forms.NumericUpDown numericUpDownNumRows;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxPrefetch;
        private OrderSearchCriteria orderSearchCriteria1;
        private System.Windows.Forms.GroupBox groupBoxLLBLQueryType;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButtonQuerySpec;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}