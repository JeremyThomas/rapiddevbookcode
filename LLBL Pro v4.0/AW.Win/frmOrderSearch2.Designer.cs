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
      this.checkBoxUsePredicate = new System.Windows.Forms.CheckBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.numericUpDownNumRows = new System.Windows.Forms.NumericUpDown();
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
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.QPanel = new Korzh.EasyQuery.WinControls.QueryPanel();
      this.query1 = new Korzh.EasyQuery.Db.DbQuery();
      this.dataModel1 = new Korzh.EasyQuery.Db.DbModel();
      this.orderSearchCriteria1 = new AW.Win.OrderSearchCriteria();
      this.checkBoxFilterUsingCustomerViewRelated = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingSource)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingNavigator)).BeginInit();
      this.salesOrderHeaderEntityBindingNavigator.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // checkBoxUsePredicate
      // 
      this.checkBoxUsePredicate.AutoSize = true;
      this.checkBoxUsePredicate.Checked = global::AW.Win.Properties.Settings.Default.UsePredicate;
      this.checkBoxUsePredicate.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxUsePredicate.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Win.Properties.Settings.Default, "UsePredicate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxUsePredicate.Location = new System.Drawing.Point(73, 9);
      this.checkBoxUsePredicate.Name = "checkBoxUsePredicate";
      this.checkBoxUsePredicate.Size = new System.Drawing.Size(93, 17);
      this.checkBoxUsePredicate.TabIndex = 27;
      this.checkBoxUsePredicate.Text = "Use Predicate";
      this.checkBoxUsePredicate.UseVisualStyleBackColor = true;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(12, 6);
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
      this.numericUpDownNumRows.Location = new System.Drawing.Point(188, 6);
      this.numericUpDownNumRows.Name = "numericUpDownNumRows";
      this.numericUpDownNumRows.Size = new System.Drawing.Size(41, 20);
      this.numericUpDownNumRows.TabIndex = 23;
      this.toolTip1.SetToolTip(this.numericUpDownNumRows, "max Number Of Items To Return");
      this.numericUpDownNumRows.Value = global::AW.Win.Properties.Settings.Default.NumRows;
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
      this.salesOrderHeaderEntityDataGridView.Location = new System.Drawing.Point(0, 303);
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
      this.salesOrderHeaderEntityDataGridView.Size = new System.Drawing.Size(694, 265);
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
      // panel2
      // 
      this.panel2.Controls.Add(this.panel3);
      this.panel2.Controls.Add(this.QPanel);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 169);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(694, 134);
      this.panel2.TabIndex = 3;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.checkBoxFilterUsingCustomerViewRelated);
      this.panel3.Controls.Add(this.checkBoxUsePredicate);
      this.panel3.Controls.Add(this.btnSearch);
      this.panel3.Controls.Add(this.numericUpDownNumRows);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(0, 98);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(694, 36);
      this.panel3.TabIndex = 1;
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
      this.QPanel.Location = new System.Drawing.Point(0, 0);
      this.QPanel.Name = "QPanel";
      this.QPanel.Query = this.query1;
      this.QPanel.Size = new System.Drawing.Size(694, 98);
      this.QPanel.TabIndex = 28;
      this.QPanel.TabStop = true;
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
      // orderSearchCriteria1
      // 
      this.orderSearchCriteria1.Dock = System.Windows.Forms.DockStyle.Top;
      this.orderSearchCriteria1.Location = new System.Drawing.Point(0, 0);
      this.orderSearchCriteria1.Name = "orderSearchCriteria1";
      this.orderSearchCriteria1.Size = new System.Drawing.Size(694, 169);
      this.orderSearchCriteria1.TabIndex = 1;
      // 
      // checkBoxFilterUsingCustomerViewRelated
      // 
      this.checkBoxFilterUsingCustomerViewRelated.AutoSize = true;
      this.checkBoxFilterUsingCustomerViewRelated.Checked = global::AW.Win.Properties.Settings.Default.FilterUsingCustomerViewRelated;
      this.checkBoxFilterUsingCustomerViewRelated.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxFilterUsingCustomerViewRelated.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Win.Properties.Settings.Default, "FilterUsingCustomerViewRelated", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxFilterUsingCustomerViewRelated.Location = new System.Drawing.Point(253, 9);
      this.checkBoxFilterUsingCustomerViewRelated.Name = "checkBoxFilterUsingCustomerViewRelated";
      this.checkBoxFilterUsingCustomerViewRelated.Size = new System.Drawing.Size(185, 17);
      this.checkBoxFilterUsingCustomerViewRelated.TabIndex = 28;
      this.checkBoxFilterUsingCustomerViewRelated.Text = "Filter Using CustomerViewRelated";
      this.checkBoxFilterUsingCustomerViewRelated.UseVisualStyleBackColor = true;
      // 
      // FrmOrderSearch2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(694, 593);
      this.Controls.Add(this.salesOrderHeaderEntityDataGridView);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.orderSearchCriteria1);
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
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingSource)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.salesOrderHeaderEntityBindingNavigator)).EndInit();
      this.salesOrderHeaderEntityBindingNavigator.ResumeLayout(false);
      this.salesOrderHeaderEntityBindingNavigator.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

				}


				#endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
				private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker searchWorker;
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
        private System.Windows.Forms.Panel panel2;
        private Korzh.EasyQuery.Db.DbQuery query1;
        private Korzh.EasyQuery.Db.DbModel dataModel1;
        private Korzh.EasyQuery.WinControls.QueryPanel QPanel;
        private System.Windows.Forms.CheckBox checkBoxUsePredicate;
        private System.Windows.Forms.Panel panel3;
        private OrderSearchCriteria orderSearchCriteria1;
        private System.Windows.Forms.CheckBox checkBoxFilterUsingCustomerViewRelated;
		}
}