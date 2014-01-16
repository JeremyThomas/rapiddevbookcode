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
      this.toolStripButtonCancelEdit = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripComboBoxClipboardCopyMode = new System.Windows.Forms.ToolStripComboBox();
      this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripLabelDeleteCount = new System.Windows.Forms.ToolStripLabel();
      this.toolStripLabelSaveResult = new System.Windows.Forms.ToolStripLabel();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonEnableFilter = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonClearFilters = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonClearSort = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonObjectBrowser = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonObjectListViewVisualizer = new System.Windows.Forms.ToolStripButton();
      this.dataGridViewEnumerable = new ADGV.AdvancedDataGridView();
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
      this.dataGridEnumerable = new System.Windows.Forms.DataGrid();
      this.tabControlGrids = new System.Windows.Forms.TabControl();
      this.tabPageDataGrid = new System.Windows.Forms.TabPage();
      this.tabPageDataGridView = new System.Windows.Forms.TabPage();
      this.searchToolBar = new ACS.UserControls.SearchToolBar();
      this.toolStripButtonUnPage = new System.Windows.Forms.ToolStripButton();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnumerable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorData)).BeginInit();
      this.bindingNavigatorData.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnumerable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPaging)).BeginInit();
      this.bindingNavigatorPaging.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePaging)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEnumerable)).BeginInit();
      this.tabControlGrids.SuspendLayout();
      this.tabPageDataGrid.SuspendLayout();
      this.tabPageDataGridView.SuspendLayout();
      this.SuspendLayout();
      // 
      // bindingSourceEnumerable
      // 
      this.bindingSourceEnumerable.AllowNew = false;
      this.bindingSourceEnumerable.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.bindingSourceEnumerable_BindingComplete);
      this.bindingSourceEnumerable.DataSourceChanged += new System.EventHandler(this.bindingSourceEnumerable_DataSourceChanged);
      this.bindingSourceEnumerable.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSourceEnumerable_ListChanged);
      // 
      // bindingNavigatorData
      // 
      this.bindingNavigatorData.AddNewItem = this.bindingNavigatorAddNewItem1;
      this.bindingNavigatorData.BindingSource = this.bindingSourceEnumerable;
      this.bindingNavigatorData.CountItem = this.bindingNavigatorCountItem1;
      this.bindingNavigatorData.DeleteItem = this.bindingNavigatorDeleteItem1;
      this.bindingNavigatorData.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.toolStripButtonCancelEdit,
            this.toolStripSeparator2,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.toolStripComboBoxClipboardCopyMode,
            this.copyToolStripButton,
            this.toolStripLabelDeleteCount,
            this.toolStripLabelSaveResult,
            this.toolStripSeparator3,
            this.toolStripButtonEnableFilter,
            this.toolStripButtonClearFilters,
            this.toolStripButtonClearSort,
            this.toolStripButtonSearch,
            this.toolStripSeparator4,
            this.toolStripButtonObjectBrowser,
            this.toolStripButtonObjectListViewVisualizer,
            this.toolStripButtonUnPage});
      this.bindingNavigatorData.Location = new System.Drawing.Point(0, 0);
      this.bindingNavigatorData.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
      this.bindingNavigatorData.MoveLastItem = this.bindingNavigatorMoveLastItem1;
      this.bindingNavigatorData.MoveNextItem = this.bindingNavigatorMoveNextItem1;
      this.bindingNavigatorData.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
      this.bindingNavigatorData.Name = "bindingNavigatorData";
      this.bindingNavigatorData.PositionItem = this.bindingNavigatorPositionItem1;
      this.bindingNavigatorData.Size = new System.Drawing.Size(1155, 25);
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
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
      this.toolStripComboBoxClipboardCopyMode.Size = new System.Drawing.Size(180, 25);
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
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButtonEnableFilter
      // 
      this.toolStripButtonEnableFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonEnableFilter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEnableFilter.Image")));
      this.toolStripButtonEnableFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonEnableFilter.Name = "toolStripButtonEnableFilter";
      this.toolStripButtonEnableFilter.Size = new System.Drawing.Size(92, 22);
      this.toolStripButtonEnableFilter.Text = "Enable Filtering";
      this.toolStripButtonEnableFilter.ToolTipText = "Enable Filtering";
      this.toolStripButtonEnableFilter.Visible = false;
      this.toolStripButtonEnableFilter.Click += new System.EventHandler(this.toolStripButtonEnableFilter_Click);
      // 
      // toolStripButtonClearFilters
      // 
      this.toolStripButtonClearFilters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonClearFilters.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearFilters.Image")));
      this.toolStripButtonClearFilters.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonClearFilters.Name = "toolStripButtonClearFilters";
      this.toolStripButtonClearFilters.Size = new System.Drawing.Size(72, 22);
      this.toolStripButtonClearFilters.Text = "Clear Filters";
      this.toolStripButtonClearFilters.Visible = false;
      this.toolStripButtonClearFilters.Click += new System.EventHandler(this.toolStripButtonClearFilters_Click);
      // 
      // toolStripButtonClearSort
      // 
      this.toolStripButtonClearSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonClearSort.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearSort.Image")));
      this.toolStripButtonClearSort.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonClearSort.Name = "toolStripButtonClearSort";
      this.toolStripButtonClearSort.Size = new System.Drawing.Size(62, 22);
      this.toolStripButtonClearSort.Text = "Clear Sort";
      this.toolStripButtonClearSort.Click += new System.EventHandler(this.toolStripButtonClearSort_Click);
      // 
      // toolStripButtonSearch
      // 
      this.toolStripButtonSearch.CheckOnClick = true;
      this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
      this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonSearch.Name = "toolStripButtonSearch";
      this.toolStripButtonSearch.Size = new System.Drawing.Size(46, 22);
      this.toolStripButtonSearch.Text = "Search";
      this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButtonObjectBrowser
      // 
      this.toolStripButtonObjectBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonObjectBrowser.Enabled = false;
      this.toolStripButtonObjectBrowser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonObjectBrowser.Image")));
      this.toolStripButtonObjectBrowser.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonObjectBrowser.Name = "toolStripButtonObjectBrowser";
      this.toolStripButtonObjectBrowser.Size = new System.Drawing.Size(132, 22);
      this.toolStripButtonObjectBrowser.Text = "View in Object Browser";
      this.toolStripButtonObjectBrowser.Click += new System.EventHandler(this.toolStripButtonObjectBrowser_Click);
      // 
      // toolStripButtonObjectListViewVisualizer
      // 
      this.toolStripButtonObjectListViewVisualizer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonObjectListViewVisualizer.Enabled = false;
      this.toolStripButtonObjectListViewVisualizer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonObjectListViewVisualizer.Image")));
      this.toolStripButtonObjectListViewVisualizer.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonObjectListViewVisualizer.Name = "toolStripButtonObjectListViewVisualizer";
      this.toolStripButtonObjectListViewVisualizer.Size = new System.Drawing.Size(141, 22);
      this.toolStripButtonObjectListViewVisualizer.Text = "ObjectListView Visualizer";
      this.toolStripButtonObjectListViewVisualizer.Click += new System.EventHandler(this.toolStripButtonObjectListViewVisualizer_Click);
      // 
      // dataGridViewEnumerable
      // 
      this.dataGridViewEnumerable.AllowUserToOrderColumns = true;
      this.dataGridViewEnumerable.AutoGenerateColumns = false;
      this.dataGridViewEnumerable.AutoGenerateContextFilters = true;
      this.dataGridViewEnumerable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewEnumerable.DataSource = this.bindingSourceEnumerable;
      this.dataGridViewEnumerable.DateWithTime = false;
      this.dataGridViewEnumerable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewEnumerable.Location = new System.Drawing.Point(3, 3);
      this.dataGridViewEnumerable.Name = "dataGridViewEnumerable";
      this.dataGridViewEnumerable.Size = new System.Drawing.Size(1141, 516);
      this.dataGridViewEnumerable.TabIndex = 4;
      this.dataGridViewEnumerable.TimeFilter = false;
      this.dataGridViewEnumerable.SortStringChanged += new System.EventHandler(this.dataGridViewEnumerable_SortStringChanged);
      this.dataGridViewEnumerable.FilterStringChanged += new System.EventHandler(this.dataGridViewEnumerable_FilterStringChanged);
      this.dataGridViewEnumerable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewEnumerable_CellFormatting);
      this.dataGridViewEnumerable.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewEnumerable_ColumnAdded);
      this.dataGridViewEnumerable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewEnumerable_DataBindingComplete);
      this.dataGridViewEnumerable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewEnumerable_DataError);
      // 
      // bindingNavigatorPaging
      // 
      this.bindingNavigatorPaging.AddNewItem = null;
      this.bindingNavigatorPaging.BindingSource = this.bindingSourcePaging;
      this.bindingNavigatorPaging.CountItem = this.bindingNavigatorCountItem;
      this.bindingNavigatorPaging.DeleteItem = null;
      this.bindingNavigatorPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.bindingNavigatorPaging.Font = new System.Drawing.Font("Segoe UI", 9F);
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
      this.bindingNavigatorPaging.Size = new System.Drawing.Size(1155, 25);
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
      // dataGridEnumerable
      // 
      this.dataGridEnumerable.DataMember = "";
      this.dataGridEnumerable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridEnumerable.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGridEnumerable.Location = new System.Drawing.Point(3, 3);
      this.dataGridEnumerable.Name = "dataGridEnumerable";
      this.dataGridEnumerable.Size = new System.Drawing.Size(1141, 516);
      this.dataGridEnumerable.TabIndex = 6;
      this.dataGridEnumerable.DataSourceChanged += new System.EventHandler(this.dataGridEnumerable_DataSourceChanged);
      this.dataGridEnumerable.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGridEnumerable_Navigate);
      // 
      // tabControlGrids
      // 
      this.tabControlGrids.Controls.Add(this.tabPageDataGrid);
      this.tabControlGrids.Controls.Add(this.tabPageDataGridView);
      this.tabControlGrids.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlGrids.Location = new System.Drawing.Point(0, 25);
      this.tabControlGrids.Name = "tabControlGrids";
      this.tabControlGrids.SelectedIndex = 0;
      this.tabControlGrids.Size = new System.Drawing.Size(1155, 548);
      this.tabControlGrids.TabIndex = 7;
      this.tabControlGrids.SelectedIndexChanged += new System.EventHandler(this.tabControlGrids_SelectedIndexChanged);
      // 
      // tabPageDataGrid
      // 
      this.tabPageDataGrid.Controls.Add(this.dataGridEnumerable);
      this.tabPageDataGrid.Location = new System.Drawing.Point(4, 22);
      this.tabPageDataGrid.Name = "tabPageDataGrid";
      this.tabPageDataGrid.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageDataGrid.Size = new System.Drawing.Size(1147, 522);
      this.tabPageDataGrid.TabIndex = 0;
      this.tabPageDataGrid.Text = "DataGrid";
      this.tabPageDataGrid.UseVisualStyleBackColor = true;
      // 
      // tabPageDataGridView
      // 
      this.tabPageDataGridView.Controls.Add(this.dataGridViewEnumerable);
      this.tabPageDataGridView.Location = new System.Drawing.Point(4, 22);
      this.tabPageDataGridView.Name = "tabPageDataGridView";
      this.tabPageDataGridView.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageDataGridView.Size = new System.Drawing.Size(1147, 522);
      this.tabPageDataGridView.TabIndex = 1;
      this.tabPageDataGridView.Text = "DataGridView";
      this.tabPageDataGridView.UseVisualStyleBackColor = true;
      // 
      // searchToolBar
      // 
      this.searchToolBar.AllowMerge = false;
      this.searchToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.searchToolBar.Location = new System.Drawing.Point(0, 25);
      this.searchToolBar.MaximumSize = new System.Drawing.Size(0, 27);
      this.searchToolBar.MinimumSize = new System.Drawing.Size(0, 27);
      this.searchToolBar.Name = "searchToolBar";
      this.searchToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.searchToolBar.Size = new System.Drawing.Size(0, 27);
      this.searchToolBar.TabIndex = 8;
      this.searchToolBar.Text = "searchToolBar1";
      this.searchToolBar.Visible = false;
      this.searchToolBar.Search += new ACS.UserControls.SearchToolBarSearchEventHandler(this.searchToolBar_Search);
      this.searchToolBar.VisibleChanged += new System.EventHandler(this.searchToolBar_VisibleChanged);
      // 
      // toolStripButtonUnPage
      // 
      this.toolStripButtonUnPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonUnPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnPage.Image")));
      this.toolStripButtonUnPage.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonUnPage.Name = "toolStripButtonUnPage";
      this.toolStripButtonUnPage.Size = new System.Drawing.Size(100, 19);
      this.toolStripButtonUnPage.Text = "Remove Pageing";
      this.toolStripButtonUnPage.Visible = false;
      this.toolStripButtonUnPage.Click += new System.EventHandler(this.toolStripButtonUnPage_Click);
      // 
      // GridDataEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tabControlGrids);
      this.Controls.Add(this.bindingNavigatorPaging);
      this.Controls.Add(this.searchToolBar);
      this.Controls.Add(this.bindingNavigatorData);
      this.Name = "GridDataEditor";
      this.Size = new System.Drawing.Size(1155, 598);
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
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEnumerable)).EndInit();
      this.tabControlGrids.ResumeLayout(false);
      this.tabPageDataGrid.ResumeLayout(false);
      this.tabPageDataGridView.ResumeLayout(false);
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
    public ADGV.AdvancedDataGridView dataGridViewEnumerable;
		public System.Windows.Forms.ToolStripButton toolStripButtonCancelEdit;
		public System.Windows.Forms.BindingNavigator bindingNavigatorPaging;
		public System.Windows.Forms.ToolStripButton toolStripButtonObjectListViewVisualizer;
		public System.Windows.Forms.ToolStripButton saveToolStripButton;
		public System.Windows.Forms.BindingSource bindingSourceEnumerable;
		private System.Windows.Forms.ToolStripButton toolStripButtonObjectBrowser;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.DataGrid dataGridEnumerable;
    private System.Windows.Forms.TabControl tabControlGrids;
    private System.Windows.Forms.TabPage tabPageDataGrid;
    private System.Windows.Forms.TabPage tabPageDataGridView;
    private System.Windows.Forms.ToolStripButton toolStripButtonEnableFilter;
    private System.Windows.Forms.ToolStripButton toolStripButtonClearFilters;
    private System.Windows.Forms.ToolStripButton toolStripButtonClearSort;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private ACS.UserControls.SearchToolBar searchToolBar;
    private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
    private System.Windows.Forms.ToolStripButton toolStripButtonUnPage;
  }
}
