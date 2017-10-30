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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridDataEditor));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.bindingSourceEnumerable = new System.Windows.Forms.BindingSource(this.components);
      this.bindingNavigatorData = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
      this.toolStripProgressBarFetching = new System.Windows.Forms.ToolStripProgressBar();
      this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
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
      this.toolStripButtonClearSort = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonEnableFilter = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonClearFilters = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonCellPopOut = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonMultiLine = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripComboBoxClipboardCopyMode = new System.Windows.Forms.ToolStripComboBox();
      this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonCSharp = new System.Windows.Forms.ToolStripButton();
      this.toolStripLabelDeleteCount = new System.Windows.Forms.ToolStripLabel();
      this.toolStripLabelSaveResult = new System.Windows.Forms.ToolStripLabel();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonShowDatagrid = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonObjectBrowser = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonObjectListViewVisualizer = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonRelatedCounts = new System.Windows.Forms.ToolStripButton();
      this.toolStripCheckBoxDeletesAreCascading = new AW.Winforms.Helpers.Controls.ToolStripCheckBox();
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
      this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
      this.toolStripLabelCurrentPagesSize = new System.Windows.Forms.ToolStripLabel();
      this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
      this.toolStripTextBoxNewPageSize = new System.Windows.Forms.ToolStripTextBox();
      this.toolStripButtonSetPageSize = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonUnPage = new System.Windows.Forms.ToolStripButton();
      this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
      this.toolStripLabelSuperSetCount = new System.Windows.Forms.ToolStripLabel();
      this.dataGridEnumerable = new System.Windows.Forms.DataGrid();
      this.tabControlGrids = new System.Windows.Forms.TabControl();
      this.tabPageDataGridView = new System.Windows.Forms.TabPage();
      this.tabPageDataGrid = new System.Windows.Forms.TabPage();
      this.searchToolBar = new ADGV.SearchToolBar();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnumerable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorData)).BeginInit();
      this.bindingNavigatorData.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnumerable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPaging)).BeginInit();
      this.bindingNavigatorPaging.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePaging)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEnumerable)).BeginInit();
      this.tabControlGrids.SuspendLayout();
      this.tabPageDataGridView.SuspendLayout();
      this.tabPageDataGrid.SuspendLayout();
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
      this.bindingNavigatorData.AllowItemReorder = true;
      this.bindingNavigatorData.BindingSource = this.bindingSourceEnumerable;
      this.bindingNavigatorData.CountItem = this.bindingNavigatorCountItem1;
      this.bindingNavigatorData.DeleteItem = this.bindingNavigatorDeleteItem1;
      this.bindingNavigatorData.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarFetching,
            this.toolStripButtonCancel,
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
            this.toolStripSeparator5,
            this.toolStripButtonRelatedCounts,
            this.toolStripCheckBoxDeletesAreCascading});
      this.bindingNavigatorData.Location = new System.Drawing.Point(0, 0);
      this.bindingNavigatorData.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
      this.bindingNavigatorData.MoveLastItem = this.bindingNavigatorMoveLastItem1;
      this.bindingNavigatorData.MoveNextItem = this.bindingNavigatorMoveNextItem1;
      this.bindingNavigatorData.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
      this.bindingNavigatorData.Name = "bindingNavigatorData";
      this.bindingNavigatorData.PositionItem = this.bindingNavigatorPositionItem1;
      this.bindingNavigatorData.Size = new System.Drawing.Size(1512, 25);
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
      this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.bindingNavigatorDeleteItem1_Click);
      // 
      // toolStripProgressBarFetching
      // 
      this.toolStripProgressBarFetching.Name = "toolStripProgressBarFetching";
      this.toolStripProgressBarFetching.Size = new System.Drawing.Size(100, 22);
      this.toolStripProgressBarFetching.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.toolStripProgressBarFetching.Visible = false;
      // 
      // toolStripButtonCancel
      // 
      this.toolStripButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancel.Image")));
      this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonCancel.Name = "toolStripButtonCancel";
      this.toolStripButtonCancel.Size = new System.Drawing.Size(63, 22);
      this.toolStripButtonCancel.Text = "Cancel";
      this.toolStripButtonCancel.Visible = false;
      this.toolStripButtonCancel.Click += new System.EventHandler(this.toolStripButtonCancel_Click);
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
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButtonCellPopOut
      // 
      this.toolStripButtonCellPopOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonCellPopOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCellPopOut.Image")));
      this.toolStripButtonCellPopOut.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonCellPopOut.Name = "toolStripButtonCellPopOut";
      this.toolStripButtonCellPopOut.Size = new System.Drawing.Size(75, 22);
      this.toolStripButtonCellPopOut.Text = "PopOut Cell";
      this.toolStripButtonCellPopOut.Click += new System.EventHandler(this.toolStripButtonCellPopOut_Click);
      // 
      // toolStripButtonMultiLine
      // 
      this.toolStripButtonMultiLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonMultiLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMultiLine.Image")));
      this.toolStripButtonMultiLine.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonMultiLine.Name = "toolStripButtonMultiLine";
      this.toolStripButtonMultiLine.Size = new System.Drawing.Size(61, 22);
      this.toolStripButtonMultiLine.Text = "MultiLine";
      this.toolStripButtonMultiLine.Click += new System.EventHandler(this.toolStripButtonMultiLine_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
      // 
      // printToolStripButton
      // 
      this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
      this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printToolStripButton.Name = "printToolStripButton";
      this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.printToolStripButton.Text = "&Print";
      this.printToolStripButton.ToolTipText = "Print Via ReportViewer";
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
      this.toolStripComboBoxClipboardCopyMode.ToolTipText = "Grid Clipboard Copy Mode";
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
      this.copyToolStripButton.ToolTipText = "Copy entire grid to the clipboard";
      this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
      // 
      // toolStripButtonCSharp
      // 
      this.toolStripButtonCSharp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonCSharp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCSharp.Image")));
      this.toolStripButtonCSharp.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonCSharp.Name = "toolStripButtonCSharp";
      this.toolStripButtonCSharp.Size = new System.Drawing.Size(68, 22);
      this.toolStripButtonCSharp.Text = "View as C#";
      this.toolStripButtonCSharp.ToolTipText = "View contents as C# source code";
      this.toolStripButtonCSharp.Click += new System.EventHandler(this.toolStripButtonCSharp_Click);
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
      // toolStripButtonShowDatagrid
      // 
      this.toolStripButtonShowDatagrid.CheckOnClick = true;
      this.toolStripButtonShowDatagrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonShowDatagrid.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowDatagrid.Image")));
      this.toolStripButtonShowDatagrid.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonShowDatagrid.Name = "toolStripButtonShowDatagrid";
      this.toolStripButtonShowDatagrid.Size = new System.Drawing.Size(187, 22);
      this.toolStripButtonShowDatagrid.Text = "Enable Related Object Navigation";
      this.toolStripButtonShowDatagrid.Click += new System.EventHandler(this.toolStripButtonShowDatagrid_Click);
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
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButtonRelatedCounts
      // 
      this.toolStripButtonRelatedCounts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonRelatedCounts.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRelatedCounts.Image")));
      this.toolStripButtonRelatedCounts.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonRelatedCounts.Name = "toolStripButtonRelatedCounts";
      this.toolStripButtonRelatedCounts.Size = new System.Drawing.Size(129, 22);
      this.toolStripButtonRelatedCounts.Text = "Related Object Counts";
      this.toolStripButtonRelatedCounts.Click += new System.EventHandler(this.toolStripButtonRelatedCounts_Click);
      // 
      // toolStripCheckBoxDeletesAreCascading
      // 
      this.toolStripCheckBoxDeletesAreCascading.Checked = false;
      this.toolStripCheckBoxDeletesAreCascading.CheckState = System.Windows.Forms.CheckState.Unchecked;
      this.toolStripCheckBoxDeletesAreCascading.Name = "toolStripCheckBoxDeletesAreCascading";
      this.toolStripCheckBoxDeletesAreCascading.Size = new System.Drawing.Size(143, 19);
      this.toolStripCheckBoxDeletesAreCascading.Text = "Deletes Are Cascading";
      this.toolStripCheckBoxDeletesAreCascading.CheckedChanged += new System.EventHandler(this.toolStripCheckBoxDeletesAreCascading_CheckedChanged);
      // 
      // dataGridViewEnumerable
      // 
      this.dataGridViewEnumerable.AllowUserToOrderColumns = true;
      this.dataGridViewEnumerable.AutoGenerateColumns = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewEnumerable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewEnumerable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewEnumerable.DataSource = this.bindingSourceEnumerable;
      this.dataGridViewEnumerable.DefaultCellBehavior = ADGV.ADGVColumnHeaderCellBehavior.SortingFiltering;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewEnumerable.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridViewEnumerable.DefaultDateTimeGrouping = ADGV.ADGVFilterMenuDateTimeGrouping.Second;
      this.dataGridViewEnumerable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewEnumerable.Location = new System.Drawing.Point(3, 3);
      this.dataGridViewEnumerable.Name = "dataGridViewEnumerable";
      this.dataGridViewEnumerable.Size = new System.Drawing.Size(1498, 516);
      this.dataGridViewEnumerable.TabIndex = 4;
      this.dataGridViewEnumerable.SortStringChanged += new System.EventHandler(this.dataGridViewEnumerable_SortStringChanged);
      this.dataGridViewEnumerable.FilterStringChanged += new System.EventHandler(this.dataGridViewEnumerable_FilterStringChanged);
      this.dataGridViewEnumerable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewEnumerable_CellFormatting);
      this.dataGridViewEnumerable.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewEnumerable_ColumnAdded);
      this.dataGridViewEnumerable.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewEnumerable_ColumnRemoved);
      this.dataGridViewEnumerable.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewEnumerable_CurrentCellDirtyStateChanged);
      this.dataGridViewEnumerable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewEnumerable_DataBindingComplete);
      this.dataGridViewEnumerable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewEnumerable_DataError);
      this.dataGridViewEnumerable.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewEnumerable_EditingControlShowing);
      this.dataGridViewEnumerable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewEnumerable_KeyDown);
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
      this.bindingNavigatorPaging.Location = new System.Drawing.Point(0, 573);
      this.bindingNavigatorPaging.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bindingNavigatorPaging.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bindingNavigatorPaging.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bindingNavigatorPaging.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bindingNavigatorPaging.Name = "bindingNavigatorPaging";
      this.bindingNavigatorPaging.PositionItem = this.bindingNavigatorPositionItem;
      this.bindingNavigatorPaging.Size = new System.Drawing.Size(1512, 25);
      this.bindingNavigatorPaging.TabIndex = 5;
      this.bindingNavigatorPaging.Text = "bindingNavigator2";
      // 
      // bindingSourcePaging
      // 
      this.bindingSourcePaging.PositionChanged += new System.EventHandler(this.bindingSourcePaging_PositionChangedAsync);
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
      // toolStripLabel1
      // 
      this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
      this.toolStripLabel1.Text = "PagesSize:";
      // 
      // toolStripLabel2
      // 
      this.toolStripLabel2.Name = "toolStripLabel2";
      this.toolStripLabel2.Size = new System.Drawing.Size(50, 22);
      this.toolStripLabel2.Text = "Current:";
      // 
      // toolStripLabelCurrentPagesSize
      // 
      this.toolStripLabelCurrentPagesSize.Name = "toolStripLabelCurrentPagesSize";
      this.toolStripLabelCurrentPagesSize.Size = new System.Drawing.Size(13, 22);
      this.toolStripLabelCurrentPagesSize.Text = "0";
      // 
      // toolStripLabel3
      // 
      this.toolStripLabel3.Name = "toolStripLabel3";
      this.toolStripLabel3.Size = new System.Drawing.Size(34, 22);
      this.toolStripLabel3.Text = "New:";
      // 
      // toolStripTextBoxNewPageSize
      // 
      this.toolStripTextBoxNewPageSize.Name = "toolStripTextBoxNewPageSize";
      this.toolStripTextBoxNewPageSize.Size = new System.Drawing.Size(40, 25);
      // 
      // toolStripButtonSetPageSize
      // 
      this.toolStripButtonSetPageSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonSetPageSize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSetPageSize.Image")));
      this.toolStripButtonSetPageSize.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonSetPageSize.Name = "toolStripButtonSetPageSize";
      this.toolStripButtonSetPageSize.Size = new System.Drawing.Size(27, 22);
      this.toolStripButtonSetPageSize.Text = "Set";
      this.toolStripButtonSetPageSize.Click += new System.EventHandler(this.toolStripButtonSetPageSize_Click);
      // 
      // toolStripButtonUnPage
      // 
      this.toolStripButtonUnPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonUnPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnPage.Image")));
      this.toolStripButtonUnPage.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonUnPage.Name = "toolStripButtonUnPage";
      this.toolStripButtonUnPage.Size = new System.Drawing.Size(94, 22);
      this.toolStripButtonUnPage.Text = "Remove Paging";
      this.toolStripButtonUnPage.Click += new System.EventHandler(this.toolStripButtonUnPage_ClickAsync);
      // 
      // toolStripLabel4
      // 
      this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.toolStripLabel4.Name = "toolStripLabel4";
      this.toolStripLabel4.Size = new System.Drawing.Size(70, 22);
      this.toolStripLabel4.Text = "Total Count";
      // 
      // toolStripLabelSuperSetCount
      // 
      this.toolStripLabelSuperSetCount.Name = "toolStripLabelSuperSetCount";
      this.toolStripLabelSuperSetCount.Size = new System.Drawing.Size(0, 22);
      // 
      // dataGridEnumerable
      // 
      this.dataGridEnumerable.DataMember = "";
      this.dataGridEnumerable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridEnumerable.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGridEnumerable.Location = new System.Drawing.Point(3, 3);
      this.dataGridEnumerable.Name = "dataGridEnumerable";
      this.dataGridEnumerable.Size = new System.Drawing.Size(1498, 516);
      this.dataGridEnumerable.TabIndex = 6;
      // 
      // tabControlGrids
      // 
      this.tabControlGrids.Controls.Add(this.tabPageDataGridView);
      this.tabControlGrids.Controls.Add(this.tabPageDataGrid);
      this.tabControlGrids.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControlGrids.Location = new System.Drawing.Point(0, 25);
      this.tabControlGrids.Name = "tabControlGrids";
      this.tabControlGrids.SelectedIndex = 0;
      this.tabControlGrids.Size = new System.Drawing.Size(1512, 548);
      this.tabControlGrids.TabIndex = 7;
      this.tabControlGrids.SelectedIndexChanged += new System.EventHandler(this.tabControlGrids_SelectedIndexChanged);
      // 
      // tabPageDataGridView
      // 
      this.tabPageDataGridView.Controls.Add(this.dataGridViewEnumerable);
      this.tabPageDataGridView.Location = new System.Drawing.Point(4, 22);
      this.tabPageDataGridView.Name = "tabPageDataGridView";
      this.tabPageDataGridView.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageDataGridView.Size = new System.Drawing.Size(1504, 522);
      this.tabPageDataGridView.TabIndex = 1;
      this.tabPageDataGridView.Text = "DataGridView";
      this.tabPageDataGridView.UseVisualStyleBackColor = true;
      // 
      // tabPageDataGrid
      // 
      this.tabPageDataGrid.Controls.Add(this.dataGridEnumerable);
      this.tabPageDataGrid.Location = new System.Drawing.Point(4, 22);
      this.tabPageDataGrid.Name = "tabPageDataGrid";
      this.tabPageDataGrid.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageDataGrid.Size = new System.Drawing.Size(1504, 522);
      this.tabPageDataGrid.TabIndex = 0;
      this.tabPageDataGrid.Text = "DataGrid";
      this.tabPageDataGrid.UseVisualStyleBackColor = true;
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
      this.searchToolBar.Size = new System.Drawing.Size(1512, 27);
      this.searchToolBar.TabIndex = 8;
      this.searchToolBar.Text = "searchToolBar1";
      this.searchToolBar.Visible = false;
      this.searchToolBar.Search += new ADGV.SearchToolBarSearchEventHandler(this.searchToolBar_Search);
      this.searchToolBar.VisibleChanged += new System.EventHandler(this.searchToolBar_VisibleChanged);
      // 
      // GridDataEditor
      // 
      this.Controls.Add(this.tabControlGrids);
      this.Controls.Add(this.bindingNavigatorPaging);
      this.Controls.Add(this.searchToolBar);
      this.Controls.Add(this.bindingNavigatorData);
      this.Name = "GridDataEditor";
      this.Size = new System.Drawing.Size(1512, 598);
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
      this.tabPageDataGridView.ResumeLayout(false);
      this.tabPageDataGrid.ResumeLayout(false);
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
    private ToolStripButton toolStripButtonRelatedCounts;
    private ToolStripCheckBox toolStripCheckBoxDeletesAreCascading;
    private ToolStripProgressBar toolStripProgressBarFetching;
    private ToolStripButton toolStripButtonCancel;
  }
}
