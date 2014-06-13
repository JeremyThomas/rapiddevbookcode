namespace JesseJohnston
{
	partial class VisualizerForm
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
			this.labelListItemType = new System.Windows.Forms.Label();
			this.groupBoxListItem = new System.Windows.Forms.GroupBox();
			this.labelIEditableObject = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.labelINotifyPropertyChanged = new System.Windows.Forms.Label();
			this.labelPropertyChangedEvents = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxListType = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.labelReadOnly = new System.Windows.Forms.Label();
			this.labelFixedSize = new System.Windows.Forms.Label();
			this.labelSynced = new System.Windows.Forms.Label();
			this.labelListSupportsListChanged = new System.Windows.Forms.Label();
			this.labelListIRaiseItemChangedEvents = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelListType = new System.Windows.Forms.Label();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageView = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView = new System.Windows.Forms.DataGrid();
			this.dataGridViewTableStyle = new System.Windows.Forms.DataGridTableStyle();
			this.tabPageList = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridList = new System.Windows.Forms.DataGrid();
			this.dataGridListTableStyle = new System.Windows.Forms.DataGridTableStyle();
			this.listViewSort = new System.Windows.Forms.ListView();
			this.columnHeaderProperty = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderDirection = new System.Windows.Forms.ColumnHeader();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxFilter = new System.Windows.Forms.TextBox();
			this.buttonAnalysis = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.groupBoxListItem.SuspendLayout();
			this.groupBoxListType.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageView.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.tabPageList.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridList)).BeginInit();
			this.SuspendLayout();
			// 
			// labelListItemType
			// 
			this.labelListItemType.AutoEllipsis = true;
			this.labelListItemType.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelListItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelListItemType.Location = new System.Drawing.Point(6, 20);
			this.labelListItemType.Name = "labelListItemType";
			this.labelListItemType.Size = new System.Drawing.Size(167, 23);
			this.labelListItemType.TabIndex = 0;
			this.labelListItemType.Text = "<not set>";
			// 
			// groupBoxListItem
			// 
			this.groupBoxListItem.Controls.Add(this.labelIEditableObject);
			this.groupBoxListItem.Controls.Add(this.label8);
			this.groupBoxListItem.Controls.Add(this.labelINotifyPropertyChanged);
			this.groupBoxListItem.Controls.Add(this.labelPropertyChangedEvents);
			this.groupBoxListItem.Controls.Add(this.label2);
			this.groupBoxListItem.Controls.Add(this.label1);
			this.groupBoxListItem.Controls.Add(this.labelListItemType);
			this.groupBoxListItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBoxListItem.Location = new System.Drawing.Point(12, 12);
			this.groupBoxListItem.Name = "groupBoxListItem";
			this.groupBoxListItem.Size = new System.Drawing.Size(187, 109);
			this.groupBoxListItem.TabIndex = 0;
			this.groupBoxListItem.TabStop = false;
			this.groupBoxListItem.Text = "List Item Type";
			// 
			// labelIEditableObject
			// 
			this.labelIEditableObject.AutoSize = true;
			this.labelIEditableObject.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelIEditableObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIEditableObject.ForeColor = System.Drawing.Color.DarkOrange;
			this.labelIEditableObject.Location = new System.Drawing.Point(151, 89);
			this.labelIEditableObject.Name = "labelIEditableObject";
			this.labelIEditableObject.Size = new System.Drawing.Size(21, 13);
			this.labelIEditableObject.TabIndex = 6;
			this.labelIEditableObject.Text = "No";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label8.Location = new System.Drawing.Point(6, 89);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "IEditableObject?";
			// 
			// labelINotifyPropertyChanged
			// 
			this.labelINotifyPropertyChanged.AutoSize = true;
			this.labelINotifyPropertyChanged.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelINotifyPropertyChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelINotifyPropertyChanged.ForeColor = System.Drawing.Color.Red;
			this.labelINotifyPropertyChanged.Location = new System.Drawing.Point(151, 43);
			this.labelINotifyPropertyChanged.Name = "labelINotifyPropertyChanged";
			this.labelINotifyPropertyChanged.Size = new System.Drawing.Size(21, 13);
			this.labelINotifyPropertyChanged.TabIndex = 2;
			this.labelINotifyPropertyChanged.Text = "No";
			// 
			// labelPropertyChangedEvents
			// 
			this.labelPropertyChangedEvents.AutoSize = true;
			this.labelPropertyChangedEvents.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelPropertyChangedEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPropertyChangedEvents.Location = new System.Drawing.Point(151, 66);
			this.labelPropertyChangedEvents.Name = "labelPropertyChangedEvents";
			this.labelPropertyChangedEvents.Size = new System.Drawing.Size(21, 13);
			this.labelPropertyChangedEvents.TabIndex = 4;
			this.labelPropertyChangedEvents.Text = "No";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Location = new System.Drawing.Point(6, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Property changed events?";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Location = new System.Drawing.Point(6, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "INotifyPropertyChanged?";
			// 
			// groupBoxListType
			// 
			this.groupBoxListType.Controls.Add(this.flowLayoutPanel1);
			this.groupBoxListType.Controls.Add(this.labelListSupportsListChanged);
			this.groupBoxListType.Controls.Add(this.labelListIRaiseItemChangedEvents);
			this.groupBoxListType.Controls.Add(this.label5);
			this.groupBoxListType.Controls.Add(this.label6);
			this.groupBoxListType.Controls.Add(this.labelListType);
			this.groupBoxListType.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBoxListType.Location = new System.Drawing.Point(12, 127);
			this.groupBoxListType.Name = "groupBoxListType";
			this.groupBoxListType.Size = new System.Drawing.Size(187, 115);
			this.groupBoxListType.TabIndex = 1;
			this.groupBoxListType.TabStop = false;
			this.groupBoxListType.Text = "List Type";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.labelReadOnly);
			this.flowLayoutPanel1.Controls.Add(this.labelFixedSize);
			this.flowLayoutPanel1.Controls.Add(this.labelSynced);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 91);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 20);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// labelReadOnly
			// 
			this.labelReadOnly.AutoSize = true;
			this.labelReadOnly.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelReadOnly.ForeColor = System.Drawing.Color.DarkOrange;
			this.labelReadOnly.Location = new System.Drawing.Point(3, 0);
			this.labelReadOnly.Name = "labelReadOnly";
			this.labelReadOnly.Size = new System.Drawing.Size(54, 13);
			this.labelReadOnly.TabIndex = 0;
			this.labelReadOnly.Text = "ReadOnly";
			// 
			// labelFixedSize
			// 
			this.labelFixedSize.AutoSize = true;
			this.labelFixedSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelFixedSize.ForeColor = System.Drawing.Color.DarkOrange;
			this.labelFixedSize.Location = new System.Drawing.Point(63, 0);
			this.labelFixedSize.Name = "labelFixedSize";
			this.labelFixedSize.Size = new System.Drawing.Size(52, 13);
			this.labelFixedSize.TabIndex = 1;
			this.labelFixedSize.Text = "FixedSize";
			// 
			// labelSynced
			// 
			this.labelSynced.AutoSize = true;
			this.labelSynced.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelSynced.ForeColor = System.Drawing.Color.DarkOrange;
			this.labelSynced.Location = new System.Drawing.Point(121, 0);
			this.labelSynced.Name = "labelSynced";
			this.labelSynced.Size = new System.Drawing.Size(43, 13);
			this.labelSynced.TabIndex = 2;
			this.labelSynced.Text = "Synced";
			// 
			// labelListSupportsListChanged
			// 
			this.labelListSupportsListChanged.AutoSize = true;
			this.labelListSupportsListChanged.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelListSupportsListChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelListSupportsListChanged.ForeColor = System.Drawing.Color.Red;
			this.labelListSupportsListChanged.Location = new System.Drawing.Point(151, 43);
			this.labelListSupportsListChanged.Name = "labelListSupportsListChanged";
			this.labelListSupportsListChanged.Size = new System.Drawing.Size(21, 13);
			this.labelListSupportsListChanged.TabIndex = 2;
			this.labelListSupportsListChanged.Text = "No";
			// 
			// labelListIRaiseItemChangedEvents
			// 
			this.labelListIRaiseItemChangedEvents.AutoSize = true;
			this.labelListIRaiseItemChangedEvents.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelListIRaiseItemChangedEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelListIRaiseItemChangedEvents.Location = new System.Drawing.Point(151, 66);
			this.labelListIRaiseItemChangedEvents.Name = "labelListIRaiseItemChangedEvents";
			this.labelListIRaiseItemChangedEvents.Size = new System.Drawing.Size(21, 13);
			this.labelListIRaiseItemChangedEvents.TabIndex = 4;
			this.labelListIRaiseItemChangedEvents.Text = "No";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label5.Location = new System.Drawing.Point(6, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "IRaiseItemChangedEvents?";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label6.Location = new System.Drawing.Point(6, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "ListChanged event?";
			// 
			// labelListType
			// 
			this.labelListType.AutoEllipsis = true;
			this.labelListType.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.labelListType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelListType.Location = new System.Drawing.Point(6, 20);
			this.labelListType.Name = "labelListType";
			this.labelListType.Size = new System.Drawing.Size(173, 23);
			this.labelListType.TabIndex = 0;
			this.labelListType.Text = "<not set>";
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPageView);
			this.tabControl.Controls.Add(this.tabPageList);
			this.tabControl.Location = new System.Drawing.Point(205, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(575, 420);
			this.tabControl.TabIndex = 6;
			// 
			// tabPageView
			// 
			this.tabPageView.Controls.Add(this.panel1);
			this.tabPageView.Location = new System.Drawing.Point(4, 22);
			this.tabPageView.Name = "tabPageView";
			this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageView.Size = new System.Drawing.Size(567, 394);
			this.tabPageView.TabIndex = 0;
			this.tabPageView.Text = "View";
			this.tabPageView.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.dataGridView);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(561, 388);
			this.panel1.TabIndex = 1;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowSorting = false;
			this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView.CaptionText = "List items sorted and filtered by ObjectListView.";
			this.dataGridView.DataMember = "";
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.PreferredColumnWidth = 60;
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeaderWidth = 20;
			this.dataGridView.Size = new System.Drawing.Size(559, 386);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridViewTableStyle});
			// 
			// dataGridViewTableStyle
			// 
			this.dataGridViewTableStyle.AllowSorting = false;
			this.dataGridViewTableStyle.AlternatingBackColor = System.Drawing.Color.Honeydew;
			this.dataGridViewTableStyle.BackColor = System.Drawing.Color.White;
			this.dataGridViewTableStyle.DataGrid = this.dataGridView;
			this.dataGridViewTableStyle.GridLineColor = System.Drawing.SystemColors.ControlDark;
			this.dataGridViewTableStyle.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridViewTableStyle.PreferredColumnWidth = 60;
			this.dataGridViewTableStyle.ReadOnly = true;
			this.dataGridViewTableStyle.RowHeaderWidth = 20;
			// 
			// tabPageList
			// 
			this.tabPageList.Controls.Add(this.panel2);
			this.tabPageList.Location = new System.Drawing.Point(4, 22);
			this.tabPageList.Name = "tabPageList";
			this.tabPageList.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageList.Size = new System.Drawing.Size(567, 394);
			this.tabPageList.TabIndex = 1;
			this.tabPageList.Text = "List";
			this.tabPageList.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.dataGridList);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(561, 388);
			this.panel2.TabIndex = 1;
			// 
			// dataGridList
			// 
			this.dataGridList.AllowSorting = false;
			this.dataGridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridList.CaptionText = "All of the list items in the underlying list.";
			this.dataGridList.DataMember = "";
			this.dataGridList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridList.Location = new System.Drawing.Point(0, 0);
			this.dataGridList.Margin = new System.Windows.Forms.Padding(0);
			this.dataGridList.Name = "dataGridList";
			this.dataGridList.PreferredColumnWidth = 60;
			this.dataGridList.ReadOnly = true;
			this.dataGridList.RowHeaderWidth = 20;
			this.dataGridList.Size = new System.Drawing.Size(559, 386);
			this.dataGridList.TabIndex = 0;
			this.dataGridList.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridListTableStyle});
			// 
			// dataGridListTableStyle
			// 
			this.dataGridListTableStyle.AllowSorting = false;
			this.dataGridListTableStyle.AlternatingBackColor = System.Drawing.Color.OldLace;
			this.dataGridListTableStyle.BackColor = System.Drawing.Color.White;
			this.dataGridListTableStyle.DataGrid = this.dataGridList;
			this.dataGridListTableStyle.GridLineColor = System.Drawing.SystemColors.ControlDark;
			this.dataGridListTableStyle.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridListTableStyle.PreferredColumnWidth = 60;
			this.dataGridListTableStyle.ReadOnly = true;
			this.dataGridListTableStyle.RowHeaderWidth = 20;
			// 
			// listViewSort
			// 
			this.listViewSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.listViewSort.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProperty,
            this.columnHeaderDirection});
			this.listViewSort.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewSort.Location = new System.Drawing.Point(12, 248);
			this.listViewSort.MultiSelect = false;
			this.listViewSort.Name = "listViewSort";
			this.listViewSort.Size = new System.Drawing.Size(187, 71);
			this.listViewSort.TabIndex = 2;
			this.listViewSort.UseCompatibleStateImageBehavior = false;
			this.listViewSort.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderProperty
			// 
			this.columnHeaderProperty.Text = "Sort Property";
			this.columnHeaderProperty.Width = 110;
			// 
			// columnHeaderDirection
			// 
			this.columnHeaderDirection.Text = "Direction";
			this.columnHeaderDirection.Width = 70;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label7.Location = new System.Drawing.Point(12, 332);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Filter";
			// 
			// textBoxFilter
			// 
			this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxFilter.Location = new System.Drawing.Point(12, 348);
			this.textBoxFilter.Multiline = true;
			this.textBoxFilter.Name = "textBoxFilter";
			this.textBoxFilter.ReadOnly = true;
			this.textBoxFilter.Size = new System.Drawing.Size(187, 55);
			this.textBoxFilter.TabIndex = 4;
			// 
			// buttonAnalysis
			// 
			this.buttonAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonAnalysis.Location = new System.Drawing.Point(12, 409);
			this.buttonAnalysis.Name = "buttonAnalysis";
			this.buttonAnalysis.Size = new System.Drawing.Size(75, 23);
			this.buttonAnalysis.TabIndex = 5;
			this.buttonAnalysis.Text = "Analysis...";
			this.buttonAnalysis.UseVisualStyleBackColor = true;
			this.buttonAnalysis.Click += new System.EventHandler(this.buttonAnalysis_Click);
			// 
			// VisualizerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 444);
			this.Controls.Add(this.buttonAnalysis);
			this.Controls.Add(this.textBoxFilter);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.listViewSort);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.groupBoxListType);
			this.Controls.Add(this.groupBoxListItem);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimizeBox = false;
			this.Name = "VisualizerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ObjectListView Visualizer";
			this.groupBoxListItem.ResumeLayout(false);
			this.groupBoxListItem.PerformLayout();
			this.groupBoxListType.ResumeLayout(false);
			this.groupBoxListType.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageView.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.tabPageList.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Label labelListItemType;
		private System.Windows.Forms.GroupBox groupBoxListItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelINotifyPropertyChanged;
		private System.Windows.Forms.Label labelPropertyChangedEvents;
		private System.Windows.Forms.GroupBox groupBoxListType;
		private System.Windows.Forms.Label labelListSupportsListChanged;
		private System.Windows.Forms.Label labelListIRaiseItemChangedEvents;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelListType;
		private System.Windows.Forms.Label labelIEditableObject;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label labelReadOnly;
		private System.Windows.Forms.Label labelFixedSize;
		private System.Windows.Forms.Label labelSynced;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageView;
		private System.Windows.Forms.TabPage tabPageList;
		private System.Windows.Forms.ListView listViewSort;
		private System.Windows.Forms.ColumnHeader columnHeaderProperty;
		private System.Windows.Forms.ColumnHeader columnHeaderDirection;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxFilter;
		private System.Windows.Forms.DataGrid dataGridView;
		private System.Windows.Forms.DataGrid dataGridList;
		private System.Windows.Forms.DataGridTableStyle dataGridViewTableStyle;
		private System.Windows.Forms.Button buttonAnalysis;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridTableStyle dataGridListTableStyle;
	}
}