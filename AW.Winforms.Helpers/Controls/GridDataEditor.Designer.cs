using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ADGV;
using AW.Helper;
using AW.Winforms.Helpers.DataEditor;

namespace AW.Winforms.Helpers.Controls
{
  partial class GridDataEditor
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
      this.components = new Container();
      ComponentResourceManager resources = new ComponentResourceManager(typeof(GridDataEditor));
      DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
      this.bindingSourceEnumerable = new BindingSource(this.components);
      this.bindingNavigatorData = new BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem1 = new ToolStripButton();
      this.bindingNavigatorCountItem1 = new ToolStripLabel();
      this.bindingNavigatorDeleteItem1 = new ToolStripButton();
      this.bindingNavigatorMoveFirstItem1 = new ToolStripButton();
      this.bindingNavigatorMovePreviousItem1 = new ToolStripButton();
      this.bindingNavigatorSeparator3 = new ToolStripSeparator();
      this.bindingNavigatorPositionItem1 = new ToolStripTextBox();
      this.bindingNavigatorSeparator4 = new ToolStripSeparator();
      this.bindingNavigatorMoveNextItem1 = new ToolStripButton();
      this.bindingNavigatorMoveLastItem1 = new ToolStripButton();
      this.bindingNavigatorSeparator5 = new ToolStripSeparator();
      this.toolStripButtonCancelEdit = new ToolStripButton();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.saveToolStripButton = new ToolStripButton();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.toolStripButtonClearSort = new ToolStripButton();
      this.toolStripButtonEnableFilter = new ToolStripButton();
      this.toolStripButtonClearFilters = new ToolStripButton();
      this.toolStripButtonSearch = new ToolStripButton();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.toolStripButtonCellPopOut = new ToolStripButton();
      this.toolStripButtonMultiLine = new ToolStripButton();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.printToolStripButton = new ToolStripButton();
      this.toolStripSeparator = new ToolStripSeparator();
      this.toolStripComboBoxClipboardCopyMode = new ToolStripComboBox();
      this.copyToolStripButton = new ToolStripButton();
      this.toolStripButtonCSharp = new ToolStripButton();
      this.toolStripLabelDeleteCount = new ToolStripLabel();
      this.toolStripLabelSaveResult = new ToolStripLabel();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.toolStripButtonShowDatagrid = new ToolStripButton();
      this.toolStripButtonObjectBrowser = new ToolStripButton();
      this.toolStripButtonObjectListViewVisualizer = new ToolStripButton();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.dataGridViewEnumerable = new AdvancedDataGridView();
      this.bindingNavigatorPaging = new BindingNavigator(this.components);
      this.bindingSourcePaging = new BindingSource(this.components);
      this.bindingNavigatorCountItem = new ToolStripLabel();
      this.bindingNavigatorMoveFirstItem = new ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new ToolStripButton();
      this.bindingNavigatorSeparator = new ToolStripSeparator();
      this.bindingNavigatorPositionItem = new ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new ToolStripButton();
      this.bindingNavigatorMoveLastItem = new ToolStripButton();
      this.bindingNavigatorSeparator2 = new ToolStripSeparator();
      this.toolStripLabel1 = new ToolStripLabel();
      this.toolStripLabel2 = new ToolStripLabel();
      this.toolStripLabelCurrentPagesSize = new ToolStripLabel();
      this.toolStripLabel3 = new ToolStripLabel();
      this.toolStripTextBoxNewPageSize = new ToolStripTextBox();
      this.toolStripButtonSetPageSize = new ToolStripButton();
      this.toolStripButtonUnPage = new ToolStripButton();
      this.toolStripLabel4 = new ToolStripLabel();
      this.toolStripLabelSuperSetCount = new ToolStripLabel();
      this.dataGridEnumerable = new DataGrid();
      this.tabControlGrids = new TabControl();
      this.tabPageDataGrid = new TabPage();
      this.tabPageDataGridView = new TabPage();
      this.searchToolBar = new SearchToolBar();
      ((ISupportInitialize)(this.bindingSourceEnumerable)).BeginInit();
      ((ISupportInitialize)(this.bindingNavigatorData)).BeginInit();
      this.bindingNavigatorData.SuspendLayout();
      ((ISupportInitialize)(this.dataGridViewEnumerable)).BeginInit();
      ((ISupportInitialize)(this.bindingNavigatorPaging)).BeginInit();
      this.bindingNavigatorPaging.SuspendLayout();
      ((ISupportInitialize)(this.bindingSourcePaging)).BeginInit();
      ((ISupportInitialize)(this.dataGridEnumerable)).BeginInit();
      this.tabControlGrids.SuspendLayout();
      this.tabPageDataGrid.SuspendLayout();
      this.tabPageDataGridView.SuspendLayout();
      this.SuspendLayout();
      // 
      // bindingSourceEnumerable
      // 
      this.bindingSourceEnumerable.AllowNew = false;
      this.bindingSourceEnumerable.BindingComplete += new BindingCompleteEventHandler(this.bindingSourceEnumerable_BindingComplete);
      this.bindingSourceEnumerable.DataSourceChanged += new EventHandler(this.bindingSourceEnumerable_DataSourceChanged);
      this.bindingSourceEnumerable.ListChanged += new ListChangedEventHandler(this.bindingSourceEnumerable_ListChanged);
      // 
      // bindingNavigatorData
      // 
      this.bindingNavigatorData.AddNewItem = this.bindingNavigatorAddNewItem1;
      this.bindingNavigatorData.BindingSource = this.bindingSourceEnumerable;
      this.bindingNavigatorData.CountItem = this.bindingNavigatorCountItem1;
      this.bindingNavigatorData.DeleteItem = this.bindingNavigatorDeleteItem1;
      this.bindingNavigatorData.Font = new Font("Segoe UI", 9F);
      this.bindingNavigatorData.Items.AddRange(new ToolStripItem[] {
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
            this.toolStripButtonClearSort,
            this.toolStripButtonEnableFilter,
            this.toolStripButtonClearFilters,
            this.toolStripButtonSearch,
            this.toolStripSeparator6,
            this.toolStripButtonCellPopOut,
            this.toolStripButtonMultiLine,
            this.toolStripSeparator4,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.toolStripComboBoxClipboardCopyMode,
            this.copyToolStripButton,
            this.toolStripButtonCSharp,
            this.toolStripLabelDeleteCount,
            this.toolStripLabelSaveResult,
            this.toolStripSeparator3,
            this.toolStripButtonShowDatagrid,
            this.toolStripButtonObjectBrowser,
            this.toolStripButtonObjectListViewVisualizer,
            this.toolStripSeparator5});
      this.bindingNavigatorData.Location = new Point(0, 0);
      this.bindingNavigatorData.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
      this.bindingNavigatorData.MoveLastItem = this.bindingNavigatorMoveLastItem1;
      this.bindingNavigatorData.MoveNextItem = this.bindingNavigatorMoveNextItem1;
      this.bindingNavigatorData.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
      this.bindingNavigatorData.Name = "bindingNavigatorData";
      this.bindingNavigatorData.PositionItem = this.bindingNavigatorPositionItem1;
      this.bindingNavigatorData.Size = new Size(1335, 25);
      this.bindingNavigatorData.TabIndex = 2;
      this.bindingNavigatorData.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem1
      // 
      this.bindingNavigatorAddNewItem1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem1.Image = ((Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
      this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
      this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem1.Size = new Size(23, 22);
      this.bindingNavigatorAddNewItem1.Text = "Add new";
      // 
      // bindingNavigatorCountItem1
      // 
      this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
      this.bindingNavigatorCountItem1.Size = new Size(35, 22);
      this.bindingNavigatorCountItem1.Text = "of {0}";
      this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem1
      // 
      this.bindingNavigatorDeleteItem1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem1.Image = ((Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
      this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
      this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem1.Size = new Size(23, 22);
      this.bindingNavigatorDeleteItem1.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem1
      // 
      this.bindingNavigatorMoveFirstItem1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem1.Image = ((Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
      this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
      this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem1.Size = new Size(23, 22);
      this.bindingNavigatorMoveFirstItem1.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem1
      // 
      this.bindingNavigatorMovePreviousItem1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem1.Image = ((Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
      this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
      this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem1.Size = new Size(23, 22);
      this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
      // 
      // bindingNavigatorSeparator3
      // 
      this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
      this.bindingNavigatorSeparator3.Size = new Size(6, 25);
      // 
      // bindingNavigatorPositionItem1
      // 
      this.bindingNavigatorPositionItem1.AccessibleName = "Position";
      this.bindingNavigatorPositionItem1.AutoSize = false;
      this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
      this.bindingNavigatorPositionItem1.Size = new Size(50, 21);
      this.bindingNavigatorPositionItem1.Text = "0";
      this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator4
      // 
      this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
      this.bindingNavigatorSeparator4.Size = new Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem1
      // 
      this.bindingNavigatorMoveNextItem1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem1.Image = ((Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
      this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
      this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem1.Size = new Size(23, 22);
      this.bindingNavigatorMoveNextItem1.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem1
      // 
      this.bindingNavigatorMoveLastItem1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem1.Image = ((Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
      this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
      this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem1.Size = new Size(23, 22);
      this.bindingNavigatorMoveLastItem1.Text = "Move last";
      // 
      // bindingNavigatorSeparator5
      // 
      this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
      this.bindingNavigatorSeparator5.Size = new Size(6, 25);
      // 
      // toolStripButtonCancelEdit
      // 
      this.toolStripButtonCancelEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButtonCancelEdit.Enabled = false;
      this.toolStripButtonCancelEdit.Image = ((Image)(resources.GetObject("toolStripButtonCancelEdit.Image")));
      this.toolStripButtonCancelEdit.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonCancelEdit.Name = "toolStripButtonCancelEdit";
      this.toolStripButtonCancelEdit.Size = new Size(23, 22);
      this.toolStripButtonCancelEdit.Text = "Cancel";
      this.toolStripButtonCancelEdit.Click += new EventHandler(this.toolStripButtonCancelEdit_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(6, 25);
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Enabled = false;
      this.saveToolStripButton.Image = ((Image)(resources.GetObject("saveToolStripButton.Image")));
      this.saveToolStripButton.ImageTransparentColor = Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new Size(23, 22);
      this.saveToolStripButton.Text = "&Save";
      this.saveToolStripButton.Click += new EventHandler(this.saveToolStripButton_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(6, 25);
      // 
      // toolStripButtonClearSort
      // 
      this.toolStripButtonClearSort.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButtonClearSort.Image = ((Image)(resources.GetObject("toolStripButtonClearSort.Image")));
      this.toolStripButtonClearSort.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonClearSort.Name = "toolStripButtonClearSort";
      this.toolStripButtonClearSort.Size = new Size(62, 22);
      this.toolStripButtonClearSort.Text = "Clear Sort";
      this.toolStripButtonClearSort.Click += new EventHandler(this.toolStripButtonClearSort_Click);
      // 
      // toolStripButtonEnableFilter
      // 
      this.toolStripButtonEnableFilter.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButtonEnableFilter.Image = ((Image)(resources.GetObject("toolStripButtonEnableFilter.Image")));
      this.toolStripButtonEnableFilter.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonEnableFilter.Name = "toolStripButtonEnableFilter";
      this.toolStripButtonEnableFilter.Size = new Size(92, 22);
      this.toolStripButtonEnableFilter.Text = "Enable Filtering";
      this.toolStripButtonEnableFilter.ToolTipText = "Enable Filtering";
      this.toolStripButtonEnableFilter.Visible = false;
      this.toolStripButtonEnableFilter.Click += new EventHandler(this.toolStripButtonEnableFilter_Click);
      // 
      // toolStripButtonClearFilters
      // 
      this.toolStripButtonClearFilters.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButtonClearFilters.Image = ((Image)(resources.GetObject("toolStripButtonClearFilters.Image")));
      this.toolStripButtonClearFilters.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonClearFilters.Name = "toolStripButtonClearFilters";
      this.toolStripButtonClearFilters.Size = new Size(72, 22);
      this.toolStripButtonClearFilters.Text = "Clear Filters";
      this.toolStripButtonClearFilters.Visible = false;
      this.toolStripButtonClearFilters.Click += new EventHandler(this.toolStripButtonClearFilters_Click);
      // 
      // toolStripButtonSearch
      // 
      this.toolStripButtonSearch.CheckOnClick = true;
      this.toolStripButtonSearch.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButtonSearch.Image = ((Image)(resources.GetObject("toolStripButtonSearch.Image")));
      this.toolStripButtonSearch.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonSearch.Name = "toolStripButtonSearch";
      this.toolStripButtonSearch.Size = new Size(46, 22);
      this.toolStripButtonSearch.Text = "Search";
      this.toolStripButtonSearch.Click += new EventHandler(this.toolStripButtonSearch_Click);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new Size(6, 25);
      // 
      // toolStripButtonCellPopOut
      // 
      this.toolStripButtonCellPopOut.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButtonCellPopOut.Image = ((Image)(resources.GetObject("toolStripButtonCellPopOut.Image")));
      this.toolStripButtonCellPopOut.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonCellPopOut.Name = "toolStripButtonCellPopOut";
      this.toolStripButtonCellPopOut.Size = new Size(75, 22);
      this.toolStripButtonCellPopOut.Text = "PopOut Cell";
      this.toolStripButtonCellPopOut.Click += new EventHandler(this.toolStripButtonCellPopOut_Click);
      // 
      // toolStripButtonMultiLine
      // 
      this.toolStripButtonMultiLine.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButtonMultiLine.Image = ((Image)(resources.GetObject("toolStripButtonMultiLine.Image")));
      this.toolStripButtonMultiLine.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonMultiLine.Name = "toolStripButtonMultiLine";
      this.toolStripButtonMultiLine.Size = new Size(61, 22);
      this.toolStripButtonMultiLine.Text = "MultiLine";
      this.toolStripButtonMultiLine.Click += new EventHandler(this.toolStripButtonMultiLine_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(6, 25);
      // 
      // printToolStripButton
      // 
      this.printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.printToolStripButton.Image = ((Image)(resources.GetObject("printToolStripButton.Image")));
      this.printToolStripButton.ImageTransparentColor = Color.Magenta;
      this.printToolStripButton.Name = "printToolStripButton";
      this.printToolStripButton.Size = new Size(23, 22);
      this.printToolStripButton.Text = "&Print";
      this.printToolStripButton.ToolTipText = "Print Via ReportViewer";
      this.printToolStripButton.Click += new EventHandler(this.printToolStripButton_Click);
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new Size(6, 25);
      // 
      // toolStripComboBoxClipboardCopyMode
      // 
      this.toolStripComboBoxClipboardCopyMode.DropDownStyle = ComboBoxStyle.DropDownList;
      this.toolStripComboBoxClipboardCopyMode.Name = "toolStripComboBoxClipboardCopyMode";
      this.toolStripComboBoxClipboardCopyMode.Size = new Size(180, 25);
      this.toolStripComboBoxClipboardCopyMode.ToolTipText = "ClipboardCopyMode";
      this.toolStripComboBoxClipboardCopyMode.SelectedIndexChanged += new EventHandler(this.toolStripComboBoxClipboardCopyMode_SelectedIndexChanged);
      // 
      // copyToolStripButton
      // 
      this.copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.copyToolStripButton.Image = ((Image)(resources.GetObject("copyToolStripButton.Image")));
      this.copyToolStripButton.ImageTransparentColor = Color.Magenta;
      this.copyToolStripButton.Name = "copyToolStripButton";
      this.copyToolStripButton.Size = new Size(23, 22);
      this.copyToolStripButton.Text = "&Copy";
      this.copyToolStripButton.Click += new EventHandler(this.copyToolStripButton_Click);
      // 
      // toolStripButtonCSharp
      // 
      this.toolStripButtonCSharp.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButtonCSharp.Image = ((Image)(resources.GetObject("toolStripButtonCSharp.Image")));
      this.toolStripButtonCSharp.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonCSharp.Name = "toolStripButtonCSharp";
      this.toolStripButtonCSharp.Size = new Size(68, 22);
      this.toolStripButtonCSharp.Text = "View as C#";
      this.toolStripButtonCSharp.ToolTipText = "View contents as C# source code";
      this.toolStripButtonCSharp.Click += new EventHandler(this.toolStripButtonCSharp_Click);
      // 
      // toolStripLabelDeleteCount
      // 
      this.toolStripLabelDeleteCount.Name = "toolStripLabelDeleteCount";
      this.toolStripLabelDeleteCount.Size = new Size(0, 22);
      // 
      // toolStripLabelSaveResult
      // 
      this.toolStripLabelSaveResult.Name = "toolStripLabelSaveResult";
      this.toolStripLabelSaveResult.Size = new Size(0, 22);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(6, 25);
      // 
      // toolStripButtonShowDatagrid
      // 
      this.toolStripButtonShowDatagrid.CheckOnClick = true;
      this.toolStripButtonShowDatagrid.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButtonShowDatagrid.Image = ((Image)(resources.GetObject("toolStripButtonShowDatagrid.Image")));
      this.toolStripButtonShowDatagrid.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonShowDatagrid.Name = "toolStripButtonShowDatagrid";
      this.toolStripButtonShowDatagrid.Size = new Size(187, 22);
      this.toolStripButtonShowDatagrid.Text = "Enable Related Object Navigation";
      this.toolStripButtonShowDatagrid.Click += new EventHandler(this.toolStripButtonShowDatagrid_Click);
      // 
      // toolStripButtonObjectBrowser
      // 
      this.toolStripButtonObjectBrowser.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButtonObjectBrowser.Enabled = false;
      this.toolStripButtonObjectBrowser.Image = ((Image)(resources.GetObject("toolStripButtonObjectBrowser.Image")));
      this.toolStripButtonObjectBrowser.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonObjectBrowser.Name = "toolStripButtonObjectBrowser";
      this.toolStripButtonObjectBrowser.Size = new Size(132, 22);
      this.toolStripButtonObjectBrowser.Text = "View in Object Browser";
      this.toolStripButtonObjectBrowser.Click += new EventHandler(this.toolStripButtonObjectBrowser_Click);
      // 
      // toolStripButtonObjectListViewVisualizer
      // 
      this.toolStripButtonObjectListViewVisualizer.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButtonObjectListViewVisualizer.Enabled = false;
      this.toolStripButtonObjectListViewVisualizer.Image = ((Image)(resources.GetObject("toolStripButtonObjectListViewVisualizer.Image")));
      this.toolStripButtonObjectListViewVisualizer.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonObjectListViewVisualizer.Name = "toolStripButtonObjectListViewVisualizer";
      this.toolStripButtonObjectListViewVisualizer.Size = new Size(141, 19);
      this.toolStripButtonObjectListViewVisualizer.Text = "ObjectListView Visualizer";
      this.toolStripButtonObjectListViewVisualizer.Click += new EventHandler(this.toolStripButtonObjectListViewVisualizer_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new Size(6, 25);
      // 
      // dataGridViewEnumerable
      // 
      this.dataGridViewEnumerable.AllowUserToOrderColumns = true;
      this.dataGridViewEnumerable.AutoGenerateColumns = false;
      dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = SystemColors.Control;
      dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.dataGridViewEnumerable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewEnumerable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewEnumerable.DataSource = this.bindingSourceEnumerable;
      this.dataGridViewEnumerable.DefaultCellBehavior = ADGVColumnHeaderCellBehavior.SortingFiltering;
      dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = SystemColors.Window;
      dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dataGridViewEnumerable.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridViewEnumerable.DefaultDateTimeGrouping = ADGVFilterMenuDateTimeGrouping.Second;
      this.dataGridViewEnumerable.Dock = DockStyle.Fill;
      this.dataGridViewEnumerable.Location = new Point(3, 3);
      this.dataGridViewEnumerable.Name = "dataGridViewEnumerable";
      this.dataGridViewEnumerable.Size = new Size(1321, 516);
      this.dataGridViewEnumerable.TabIndex = 4;
      this.dataGridViewEnumerable.SortStringChanged += new EventHandler(this.dataGridViewEnumerable_SortStringChanged);
      this.dataGridViewEnumerable.FilterStringChanged += new EventHandler(this.dataGridViewEnumerable_FilterStringChanged);
      this.dataGridViewEnumerable.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewEnumerable_CellFormatting);
      this.dataGridViewEnumerable.ColumnAdded += new DataGridViewColumnEventHandler(this.dataGridViewEnumerable_ColumnAdded);
      this.dataGridViewEnumerable.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.dataGridViewEnumerable_DataBindingComplete);
      this.dataGridViewEnumerable.DataError += new DataGridViewDataErrorEventHandler(this.dataGridViewEnumerable_DataError);
      this.dataGridViewEnumerable.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dataGridViewEnumerable_EditingControlShowing);
      // 
      // bindingNavigatorPaging
      // 
      this.bindingNavigatorPaging.AddNewItem = null;
      this.bindingNavigatorPaging.BindingSource = this.bindingSourcePaging;
      this.bindingNavigatorPaging.CountItem = this.bindingNavigatorCountItem;
      this.bindingNavigatorPaging.DeleteItem = null;
      this.bindingNavigatorPaging.Dock = DockStyle.Bottom;
      this.bindingNavigatorPaging.Font = new Font("Segoe UI", 9F);
      this.bindingNavigatorPaging.Items.AddRange(new ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabelCurrentPagesSize,
            this.toolStripLabel3,
            this.toolStripTextBoxNewPageSize,
            this.toolStripButtonSetPageSize,
            this.toolStripButtonUnPage,
            this.toolStripLabel4,
            this.toolStripLabelSuperSetCount});
      this.bindingNavigatorPaging.Location = new Point(0, 573);
      this.bindingNavigatorPaging.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bindingNavigatorPaging.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bindingNavigatorPaging.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bindingNavigatorPaging.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bindingNavigatorPaging.Name = "bindingNavigatorPaging";
      this.bindingNavigatorPaging.PositionItem = this.bindingNavigatorPositionItem;
      this.bindingNavigatorPaging.Size = new Size(1335, 25);
      this.bindingNavigatorPaging.TabIndex = 5;
      this.bindingNavigatorPaging.Text = "bindingNavigator2";
      // 
      // bindingSourcePaging
      // 
      this.bindingSourcePaging.PositionChanged += new EventHandler(this.bindingSourcePaging_PositionChanged);
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new Size(50, 21);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new Size(6, 25);
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new Size(65, 22);
      this.toolStripLabel1.Text = "PagesSize:";
      // 
      // toolStripLabel2
      // 
      this.toolStripLabel2.Name = "toolStripLabel2";
      this.toolStripLabel2.Size = new Size(50, 22);
      this.toolStripLabel2.Text = "Current:";
      // 
      // toolStripLabelCurrentPagesSize
      // 
      this.toolStripLabelCurrentPagesSize.Name = "toolStripLabelCurrentPagesSize";
      this.toolStripLabelCurrentPagesSize.Size = new Size(13, 22);
      this.toolStripLabelCurrentPagesSize.Text = "0";
      // 
      // toolStripLabel3
      // 
      this.toolStripLabel3.Name = "toolStripLabel3";
      this.toolStripLabel3.Size = new Size(34, 22);
      this.toolStripLabel3.Text = "New:";
      // 
      // toolStripTextBoxNewPageSize
      // 
      this.toolStripTextBoxNewPageSize.Name = "toolStripTextBoxNewPageSize";
      this.toolStripTextBoxNewPageSize.Size = new Size(40, 25);
      // 
      // toolStripButtonSetPageSize
      // 
      this.toolStripButtonSetPageSize.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButtonSetPageSize.Image = ((Image)(resources.GetObject("toolStripButtonSetPageSize.Image")));
      this.toolStripButtonSetPageSize.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonSetPageSize.Name = "toolStripButtonSetPageSize";
      this.toolStripButtonSetPageSize.Size = new Size(27, 22);
      this.toolStripButtonSetPageSize.Text = "Set";
      this.toolStripButtonSetPageSize.Click += new EventHandler(this.toolStripButtonSetPageSize_Click);
      // 
      // toolStripButtonUnPage
      // 
      this.toolStripButtonUnPage.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButtonUnPage.Image = ((Image)(resources.GetObject("toolStripButtonUnPage.Image")));
      this.toolStripButtonUnPage.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonUnPage.Name = "toolStripButtonUnPage";
      this.toolStripButtonUnPage.Size = new Size(100, 22);
      this.toolStripButtonUnPage.Text = "Remove Pageing";
      this.toolStripButtonUnPage.Click += new EventHandler(this.toolStripButtonUnPage_Click);
      // 
      // toolStripLabel4
      // 
      this.toolStripLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      this.toolStripLabel4.Name = "toolStripLabel4";
      this.toolStripLabel4.Size = new Size(71, 22);
      this.toolStripLabel4.Text = "Total Count";
      // 
      // toolStripLabelSuperSetCount
      // 
      this.toolStripLabelSuperSetCount.Name = "toolStripLabelSuperSetCount";
      this.toolStripLabelSuperSetCount.Size = new Size(0, 22);
      // 
      // dataGridEnumerable
      // 
      this.dataGridEnumerable.DataMember = "";
      this.dataGridEnumerable.Dock = DockStyle.Fill;
      this.dataGridEnumerable.HeaderForeColor = SystemColors.ControlText;
      this.dataGridEnumerable.Location = new Point(3, 3);
      this.dataGridEnumerable.Name = "dataGridEnumerable";
      this.dataGridEnumerable.Size = new Size(1321, 516);
      this.dataGridEnumerable.TabIndex = 6;
      // 
      // tabControlGrids
      // 
      this.tabControlGrids.Controls.Add(this.tabPageDataGrid);
      this.tabControlGrids.Controls.Add(this.tabPageDataGridView);
      this.tabControlGrids.Dock = DockStyle.Fill;
      this.tabControlGrids.Location = new Point(0, 25);
      this.tabControlGrids.Name = "tabControlGrids";
      this.tabControlGrids.SelectedIndex = 0;
      this.tabControlGrids.Size = new Size(1335, 548);
      this.tabControlGrids.TabIndex = 7;
      this.tabControlGrids.SelectedIndexChanged += new EventHandler(this.tabControlGrids_SelectedIndexChanged);
      // 
      // tabPageDataGrid
      // 
      this.tabPageDataGrid.Controls.Add(this.dataGridEnumerable);
      this.tabPageDataGrid.Location = new Point(4, 22);
      this.tabPageDataGrid.Name = "tabPageDataGrid";
      this.tabPageDataGrid.Padding = new Padding(3);
      this.tabPageDataGrid.Size = new Size(1327, 522);
      this.tabPageDataGrid.TabIndex = 0;
      this.tabPageDataGrid.Text = "DataGrid";
      this.tabPageDataGrid.UseVisualStyleBackColor = true;
      // 
      // tabPageDataGridView
      // 
      this.tabPageDataGridView.Controls.Add(this.dataGridViewEnumerable);
      this.tabPageDataGridView.Location = new Point(4, 22);
      this.tabPageDataGridView.Name = "tabPageDataGridView";
      this.tabPageDataGridView.Padding = new Padding(3);
      this.tabPageDataGridView.Size = new Size(1327, 522);
      this.tabPageDataGridView.TabIndex = 1;
      this.tabPageDataGridView.Text = "DataGridView";
      this.tabPageDataGridView.UseVisualStyleBackColor = true;
      // 
      // searchToolBar
      // 
      this.searchToolBar.AllowMerge = false;
      this.searchToolBar.GripStyle = ToolStripGripStyle.Hidden;
      this.searchToolBar.Location = new Point(0, 25);
      this.searchToolBar.MaximumSize = new Size(0, 27);
      this.searchToolBar.MinimumSize = new Size(0, 27);
      this.searchToolBar.Name = "searchToolBar";
      this.searchToolBar.RenderMode = ToolStripRenderMode.Professional;
      this.searchToolBar.Size = new Size(0, 27);
      this.searchToolBar.TabIndex = 8;
      this.searchToolBar.Text = "searchToolBar1";
      this.searchToolBar.Visible = false;
      this.searchToolBar.Search += new SearchToolBarSearchEventHandler(this.searchToolBar_Search);
      this.searchToolBar.VisibleChanged += new EventHandler(this.searchToolBar_VisibleChanged);
      // 
      // GridDataEditor
      // 
      this.AutoScaleDimensions = new SizeF(6F, 13F);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add(this.tabControlGrids);
      this.Controls.Add(this.bindingNavigatorPaging);
      this.Controls.Add(this.searchToolBar);
      this.Controls.Add(this.bindingNavigatorData);
      this.Name = "GridDataEditor";
      this.Size = new Size(1335, 598);
      this.Load += new EventHandler(this.GridDataEditor_Load);
      ((ISupportInitialize)(this.bindingSourceEnumerable)).EndInit();
      ((ISupportInitialize)(this.bindingNavigatorData)).EndInit();
      this.bindingNavigatorData.ResumeLayout(false);
      this.bindingNavigatorData.PerformLayout();
      ((ISupportInitialize)(this.dataGridViewEnumerable)).EndInit();
      ((ISupportInitialize)(this.bindingNavigatorPaging)).EndInit();
      this.bindingNavigatorPaging.ResumeLayout(false);
      this.bindingNavigatorPaging.PerformLayout();
      ((ISupportInitialize)(this.bindingSourcePaging)).EndInit();
      ((ISupportInitialize)(this.dataGridEnumerable)).EndInit();
      this.tabControlGrids.ResumeLayout(false);
      this.tabPageDataGrid.ResumeLayout(false);
      this.tabPageDataGridView.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ToolStripLabel bindingNavigatorCountItem1;
    private ToolStripButton bindingNavigatorMoveFirstItem1;
    private ToolStripButton bindingNavigatorMovePreviousItem1;
    private ToolStripSeparator bindingNavigatorSeparator3;
    private ToolStripTextBox bindingNavigatorPositionItem1;
    private ToolStripSeparator bindingNavigatorSeparator4;
    private ToolStripButton bindingNavigatorMoveNextItem1;
    private ToolStripButton bindingNavigatorMoveLastItem1;
    private ToolStripSeparator bindingNavigatorSeparator5;
    private ToolStripSeparator toolStripSeparator;
    private ToolStripComboBox toolStripComboBoxClipboardCopyMode;
    private ToolStripButton copyToolStripButton;
    private ToolStripLabel toolStripLabelDeleteCount;
    private ToolStripLabel toolStripLabelSaveResult;
    protected BindingSource bindingSourcePaging;
    private ToolStripLabel bindingNavigatorCountItem;
    private ToolStripButton bindingNavigatorMoveFirstItem;
    private ToolStripButton bindingNavigatorMovePreviousItem;
    private ToolStripSeparator bindingNavigatorSeparator;
    private ToolStripTextBox bindingNavigatorPositionItem;
    private ToolStripSeparator bindingNavigatorSeparator1;
    private ToolStripButton bindingNavigatorMoveNextItem;
    private ToolStripButton bindingNavigatorMoveLastItem;
    private ToolStripSeparator bindingNavigatorSeparator2;
    public ToolStripButton bindingNavigatorAddNewItem1;
    public ToolStripButton bindingNavigatorDeleteItem1;
    public ToolStripButton printToolStripButton;
    public BindingNavigator bindingNavigatorData;
    public AdvancedDataGridView dataGridViewEnumerable;
    public ToolStripButton toolStripButtonCancelEdit;
    public BindingNavigator bindingNavigatorPaging;
    public ToolStripButton toolStripButtonObjectListViewVisualizer;
    public ToolStripButton saveToolStripButton;
    public BindingSource bindingSourceEnumerable;
    private ToolStripButton toolStripButtonObjectBrowser;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripSeparator toolStripSeparator3;
    private DataGrid dataGridEnumerable;
    private TabControl tabControlGrids;
    private TabPage tabPageDataGrid;
    private TabPage tabPageDataGridView;
    private ToolStripButton toolStripButtonEnableFilter;
    private ToolStripButton toolStripButtonClearFilters;
    private ToolStripButton toolStripButtonClearSort;
    private ToolStripSeparator toolStripSeparator4;
    private SearchToolBar searchToolBar;
    private ToolStripButton toolStripButtonSearch;
    private ToolStripButton toolStripButtonUnPage;
    private ToolStripLabel toolStripLabel1;
    private ToolStripLabel toolStripLabel2;
    private ToolStripLabel toolStripLabelCurrentPagesSize;
    private ToolStripLabel toolStripLabel3;
    private ToolStripTextBox toolStripTextBoxNewPageSize;
    private ToolStripButton toolStripButtonSetPageSize;
    private ToolStripButton toolStripButtonShowDatagrid;
    private ToolStripLabel toolStripLabel4;
    private ToolStripLabel toolStripLabelSuperSetCount;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripButton toolStripButtonMultiLine;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripButton toolStripButtonCellPopOut;
    private ToolStripButton toolStripButtonCSharp;
  }
}
