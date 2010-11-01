namespace AW.Winforms.Helpers.Controls
{
  partial class GridDataEditor
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridDataEditor));
			this.bindingSourceEnumerable = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorData = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripComboBoxClipboardCopyMode = new System.Windows.Forms.ToolStripComboBox();
			this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabelDeleteCount = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabelSaveResult = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButtonCancelEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonObjectListViewVisualizer = new System.Windows.Forms.ToolStripButton();
			this.dataGridViewEnumerable = new System.Windows.Forms.DataGridView();
			this.bindingNavigatorPaging = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingSourcePaging = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnumerable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorData)).BeginInit();
			this.bindingNavigatorData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnumerable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPaging)).BeginInit();
			this.bindingNavigatorPaging.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourcePaging)).BeginInit();
			this.SuspendLayout();
			// 
			// bindingSourceEnumerable
			// 
			this.bindingSourceEnumerable.AllowNew = false;
			this.bindingSourceEnumerable.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.bindingSourceEnumerable_BindingComplete);
			this.bindingSourceEnumerable.DataSourceChanged += new System.EventHandler(this.bindingSourceEnumerable_DataSourceChanged);
			this.bindingSourceEnumerable.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSourceEnumerable_ListChanged);
			this.bindingSourceEnumerable.PositionChanged += new System.EventHandler(this.bindingSourceEnumerable_PositionChanged);
			// 
			// bindingNavigatorData
			// 
			this.bindingNavigatorData.AddNewItem = this.bindingNavigatorAddNewItem1;
			this.bindingNavigatorData.BindingSource = this.bindingSourceEnumerable;
			this.bindingNavigatorData.CountItem = this.bindingNavigatorCountItem1;
			this.bindingNavigatorData.DeleteItem = this.bindingNavigatorDeleteItem1;
			this.bindingNavigatorData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.toolStripComboBoxClipboardCopyMode,
            this.copyToolStripButton,
            this.toolStripLabelDeleteCount,
            this.toolStripLabelSaveResult,
            this.toolStripButtonCancelEdit,
            this.toolStripButtonObjectListViewVisualizer});
			this.bindingNavigatorData.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigatorData.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
			this.bindingNavigatorData.MoveLastItem = this.bindingNavigatorMoveLastItem1;
			this.bindingNavigatorData.MoveNextItem = this.bindingNavigatorMoveNextItem1;
			this.bindingNavigatorData.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
			this.bindingNavigatorData.Name = "bindingNavigatorData";
			this.bindingNavigatorData.PositionItem = this.bindingNavigatorPositionItem1;
			this.bindingNavigatorData.Size = new System.Drawing.Size(717, 25);
			this.bindingNavigatorData.TabIndex = 2;
			this.bindingNavigatorData.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem1
			// 
			this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
			this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
			this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem1.Text = "Add new";
			// 
			// bindingNavigatorCountItem1
			// 
			this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
			this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem1.Text = "of {0}";
			this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem1
			// 
			this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
			this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
			this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem1.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem1
			// 
			this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
			this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
			this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem1.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem1
			// 
			this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
			this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
			this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
			// 
			// bindingNavigatorSeparator3
			// 
			this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
			this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem1
			// 
			this.bindingNavigatorPositionItem1.AccessibleName = "Position";
			this.bindingNavigatorPositionItem1.AutoSize = false;
			this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
			this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 21);
			this.bindingNavigatorPositionItem1.Text = "0";
			this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator4
			// 
			this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
			this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem1
			// 
			this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
			this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
			this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem1.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem1
			// 
			this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
			this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
			this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem1.Text = "Move last";
			// 
			// bindingNavigatorSeparator5
			// 
			this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
			this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Enabled = false;
			this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
			this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.saveToolStripButton.Text = "&Save";
			this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
			// 
			// printToolStripButton
			// 
			this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
			this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.printToolStripButton.Name = "printToolStripButton";
			this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.printToolStripButton.Text = "&Print";
			this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripComboBoxClipboardCopyMode
			// 
			this.toolStripComboBoxClipboardCopyMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxClipboardCopyMode.Name = "toolStripComboBoxClipboardCopyMode";
			this.toolStripComboBoxClipboardCopyMode.Size = new System.Drawing.Size(160, 25);
			this.toolStripComboBoxClipboardCopyMode.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxClipboardCopyMode_SelectedIndexChanged);
			// 
			// copyToolStripButton
			// 
			this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
			this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripButton.Name = "copyToolStripButton";
			this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.copyToolStripButton.Text = "&Copy";
			this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
			// 
			// toolStripLabelDeleteCount
			// 
			this.toolStripLabelDeleteCount.Name = "toolStripLabelDeleteCount";
			this.toolStripLabelDeleteCount.Size = new System.Drawing.Size(0, 22);
			// 
			// toolStripLabelSaveResult
			// 
			this.toolStripLabelSaveResult.Name = "toolStripLabelSaveResult";
			this.toolStripLabelSaveResult.Size = new System.Drawing.Size(0, 22);
			// 
			// toolStripButtonCancelEdit
			// 
			this.toolStripButtonCancelEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonCancelEdit.Enabled = false;
			this.toolStripButtonCancelEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelEdit.Image")));
			this.toolStripButtonCancelEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCancelEdit.Name = "toolStripButtonCancelEdit";
			this.toolStripButtonCancelEdit.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonCancelEdit.Text = "Cancel";
			this.toolStripButtonCancelEdit.Click += new System.EventHandler(this.toolStripButtonCancelEdit_Click);
			// 
			// toolStripButtonObjectListViewVisualizer
			// 
			this.toolStripButtonObjectListViewVisualizer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonObjectListViewVisualizer.Image")));
			this.toolStripButtonObjectListViewVisualizer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonObjectListViewVisualizer.Name = "toolStripButtonObjectListViewVisualizer";
			this.toolStripButtonObjectListViewVisualizer.Size = new System.Drawing.Size(154, 22);
			this.toolStripButtonObjectListViewVisualizer.Text = "ObjectListViewVisualizer";
			this.toolStripButtonObjectListViewVisualizer.Click += new System.EventHandler(this.toolStripButtonObjectListViewVisualizer_Click);
			// 
			// dataGridViewEnumerable
			// 
			this.dataGridViewEnumerable.AllowUserToOrderColumns = true;
			this.dataGridViewEnumerable.AutoGenerateColumns = false;
			this.dataGridViewEnumerable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewEnumerable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEnumerable.DataSource = this.bindingSourceEnumerable;
			this.dataGridViewEnumerable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewEnumerable.Location = new System.Drawing.Point(0, 25);
			this.dataGridViewEnumerable.Name = "dataGridViewEnumerable";
			this.dataGridViewEnumerable.Size = new System.Drawing.Size(717, 548);
			this.dataGridViewEnumerable.TabIndex = 4;
			this.dataGridViewEnumerable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(dataGridViewEnumerable_DataError);
			// 
			// bindingNavigatorPaging
			// 
			this.bindingNavigatorPaging.AddNewItem = null;
			this.bindingNavigatorPaging.BindingSource = this.bindingSourcePaging;
			this.bindingNavigatorPaging.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigatorPaging.DeleteItem = null;
			this.bindingNavigatorPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bindingNavigatorPaging.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
			this.bindingNavigatorPaging.Location = new System.Drawing.Point(0, 573);
			this.bindingNavigatorPaging.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigatorPaging.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigatorPaging.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigatorPaging.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigatorPaging.Name = "bindingNavigatorPaging";
			this.bindingNavigatorPaging.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigatorPaging.Size = new System.Drawing.Size(717, 25);
			this.bindingNavigatorPaging.TabIndex = 5;
			this.bindingNavigatorPaging.Text = "bindingNavigator2";
			// 
			// bindingSourcePaging
			// 
			this.bindingSourcePaging.PositionChanged += new System.EventHandler(this.bindingSourcePaging_PositionChanged);
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
			// GridDataEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridViewEnumerable);
			this.Controls.Add(this.bindingNavigatorPaging);
			this.Controls.Add(this.bindingNavigatorData);
			this.Name = "GridDataEditor";
			this.Size = new System.Drawing.Size(717, 598);
			this.Load += new System.EventHandler(this.GridDataEditor_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnumerable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorData)).EndInit();
			this.bindingNavigatorData.ResumeLayout(false);
			this.bindingNavigatorData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnumerable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPaging)).EndInit();
			this.bindingNavigatorPaging.ResumeLayout(false);
			this.bindingNavigatorPaging.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourcePaging)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripComboBox toolStripComboBoxClipboardCopyMode;
    private System.Windows.Forms.ToolStripButton copyToolStripButton;
		protected System.Windows.Forms.BindingSource bindingSourceEnumerable;
    private System.Windows.Forms.ToolStripLabel toolStripLabelDeleteCount;
		private System.Windows.Forms.ToolStripLabel toolStripLabelSaveResult;
    protected System.Windows.Forms.BindingSource bindingSourcePaging;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		public System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
		public System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
		public System.Windows.Forms.ToolStripButton printToolStripButton;
		public System.Windows.Forms.BindingNavigator bindingNavigatorData;
		public System.Windows.Forms.DataGridView dataGridViewEnumerable;
		public System.Windows.Forms.ToolStripButton toolStripButtonCancelEdit;
		public System.Windows.Forms.BindingNavigator bindingNavigatorPaging;
		public System.Windows.Forms.ToolStripButton toolStripButtonObjectListViewVisualizer;
		public System.Windows.Forms.ToolStripButton saveToolStripButton;
  }
}
