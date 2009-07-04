namespace AW.Winforms.Helpers.QueryRunner
{
  partial class QueryRunner
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryRunner));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.splitContainerScript = new System.Windows.Forms.SplitContainer();
      this.textBoxScript = new System.Windows.Forms.TextBox();
      this.dataGridViewScript = new System.Windows.Forms.DataGridView();
      this.contextMenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.viewObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.browseObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.BindingSourceScript = new System.Windows.Forms.BindingSource(this.components);
      this.bindingNavigatorScript = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.contextMenuStripBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonViewRunQuery = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.printToolStripButtonViewReport = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.copyToolStripButtonQuery = new System.Windows.Forms.ToolStripButton();
      this.toolStripComboBoxClipboardCopyMode = new System.Windows.Forms.ToolStripComboBox();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButtonBrowse = new System.Windows.Forms.ToolStripButton();
      this.splitContainerScript.Panel1.SuspendLayout();
      this.splitContainerScript.Panel2.SuspendLayout();
      this.splitContainerScript.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScript)).BeginInit();
      this.contextMenuStripGrid.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BindingSourceScript)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorScript)).BeginInit();
      this.bindingNavigatorScript.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainerScript
      // 
      this.splitContainerScript.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerScript.Location = new System.Drawing.Point(0, 0);
      this.splitContainerScript.Name = "splitContainerScript";
      this.splitContainerScript.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainerScript.Panel1
      // 
      this.splitContainerScript.Panel1.Controls.Add(this.textBoxScript);
      // 
      // splitContainerScript.Panel2
      // 
      this.splitContainerScript.Panel2.Controls.Add(this.dataGridViewScript);
      this.splitContainerScript.Panel2.Controls.Add(this.bindingNavigatorScript);
      this.splitContainerScript.Size = new System.Drawing.Size(841, 595);
      this.splitContainerScript.SplitterDistance = 280;
      this.splitContainerScript.TabIndex = 6;
      // 
      // textBoxScript
      // 
      this.textBoxScript.AllowDrop = true;
      this.textBoxScript.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxScript.Location = new System.Drawing.Point(0, 0);
      this.textBoxScript.Multiline = true;
      this.textBoxScript.Name = "textBoxScript";
      this.textBoxScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxScript.Size = new System.Drawing.Size(841, 280);
      this.textBoxScript.TabIndex = 0;
      this.textBoxScript.Text = resources.GetString("textBoxScript.Text");
      this.textBoxScript.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragDrop);
      this.textBoxScript.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxScript_MouseDown);
      this.textBoxScript.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragEnter);
      this.textBoxScript.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragOver);
      // 
      // dataGridViewScript
      // 
      this.dataGridViewScript.AllowUserToAddRows = false;
      this.dataGridViewScript.AllowUserToDeleteRows = false;
      this.dataGridViewScript.AllowUserToOrderColumns = true;
      this.dataGridViewScript.AutoGenerateColumns = false;
      this.dataGridViewScript.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridViewScript.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewScript.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewScript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewScript.ContextMenuStrip = this.contextMenuStripGrid;
      this.dataGridViewScript.DataSource = this.BindingSourceScript;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewScript.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridViewScript.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewScript.Location = new System.Drawing.Point(0, 25);
      this.dataGridViewScript.Name = "dataGridViewScript";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewScript.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridViewScript.RowHeadersVisible = false;
      this.dataGridViewScript.Size = new System.Drawing.Size(841, 286);
      this.dataGridViewScript.TabIndex = 3;
      this.dataGridViewScript.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewScript_DataError);
      // 
      // contextMenuStripGrid
      // 
      this.contextMenuStripGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewObjectToolStripMenuItem,
            this.browseObjectToolStripMenuItem});
      this.contextMenuStripGrid.Name = "contextMenuStripGrid";
      this.contextMenuStripGrid.Size = new System.Drawing.Size(156, 48);
      // 
      // viewObjectToolStripMenuItem
      // 
      this.viewObjectToolStripMenuItem.Name = "viewObjectToolStripMenuItem";
      this.viewObjectToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.viewObjectToolStripMenuItem.Text = "View Object";
      this.viewObjectToolStripMenuItem.Click += new System.EventHandler(this.viewObjectToolStripMenuItem_Click);
      // 
      // browseObjectToolStripMenuItem
      // 
      this.browseObjectToolStripMenuItem.Name = "browseObjectToolStripMenuItem";
      this.browseObjectToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.browseObjectToolStripMenuItem.Text = "Browse Object";
      this.browseObjectToolStripMenuItem.Click += new System.EventHandler(this.browseObjectToolStripMenuItem_Click);
      // 
      // BindingSourceScript
      // 
      this.BindingSourceScript.AllowNew = false;
      // 
      // bindingNavigatorScript
      // 
      this.bindingNavigatorScript.AddNewItem = this.bindingNavigatorAddNewItem;
      this.bindingNavigatorScript.BindingSource = this.BindingSourceScript;
      this.bindingNavigatorScript.ContextMenuStrip = this.contextMenuStripBlank;
      this.bindingNavigatorScript.CountItem = this.bindingNavigatorCountItem;
      this.bindingNavigatorScript.DeleteItem = this.bindingNavigatorDeleteItem;
      this.bindingNavigatorScript.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator4,
            this.toolStripButtonViewRunQuery,
            this.toolStripSeparator2,
            this.printToolStripButtonViewReport,
            this.toolStripSeparator1,
            this.copyToolStripButtonQuery,
            this.toolStripComboBoxClipboardCopyMode,
            this.toolStripSeparator3,
            this.toolStripButtonBrowse});
      this.bindingNavigatorScript.Location = new System.Drawing.Point(0, 0);
      this.bindingNavigatorScript.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bindingNavigatorScript.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bindingNavigatorScript.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bindingNavigatorScript.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bindingNavigatorScript.Name = "bindingNavigatorScript";
      this.bindingNavigatorScript.PositionItem = this.bindingNavigatorPositionItem;
      this.bindingNavigatorScript.Size = new System.Drawing.Size(841, 25);
      this.bindingNavigatorScript.TabIndex = 4;
      this.bindingNavigatorScript.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // contextMenuStripBlank
      // 
      this.contextMenuStripBlank.Name = "contextMenuStripBlank";
      this.contextMenuStripBlank.Size = new System.Drawing.Size(61, 4);
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
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
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButtonViewRunQuery
      // 
      this.toolStripButtonViewRunQuery.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewRunQuery.Image")));
      this.toolStripButtonViewRunQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonViewRunQuery.Name = "toolStripButtonViewRunQuery";
      this.toolStripButtonViewRunQuery.Size = new System.Drawing.Size(76, 22);
      this.toolStripButtonViewRunQuery.Text = "RunQuery";
      this.toolStripButtonViewRunQuery.Click += new System.EventHandler(this.toolStripButtonViewRunQuery_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // printToolStripButtonViewReport
      // 
      this.printToolStripButtonViewReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.printToolStripButtonViewReport.Enabled = false;
      this.printToolStripButtonViewReport.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButtonViewReport.Image")));
      this.printToolStripButtonViewReport.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printToolStripButtonViewReport.Name = "printToolStripButtonViewReport";
      this.printToolStripButtonViewReport.Size = new System.Drawing.Size(23, 22);
      this.printToolStripButtonViewReport.Text = "&Print";
      this.printToolStripButtonViewReport.Click += new System.EventHandler(this.printToolStripButtonViewReport_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // copyToolStripButtonQuery
      // 
      this.copyToolStripButtonQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.copyToolStripButtonQuery.Enabled = false;
      this.copyToolStripButtonQuery.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButtonQuery.Image")));
      this.copyToolStripButtonQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripButtonQuery.Name = "copyToolStripButtonQuery";
      this.copyToolStripButtonQuery.Size = new System.Drawing.Size(23, 22);
      this.copyToolStripButtonQuery.Text = "&Copy";
      this.copyToolStripButtonQuery.Click += new System.EventHandler(this.copyToolStripButtonQuery_Click);
      // 
      // toolStripComboBoxClipboardCopyMode
      // 
      this.toolStripComboBoxClipboardCopyMode.Name = "toolStripComboBoxClipboardCopyMode";
      this.toolStripComboBoxClipboardCopyMode.Size = new System.Drawing.Size(160, 25);
      this.toolStripComboBoxClipboardCopyMode.Text = "ClipboardCopyMode";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButtonBrowse
      // 
      this.toolStripButtonBrowse.Enabled = false;
      this.toolStripButtonBrowse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBrowse.Image")));
      this.toolStripButtonBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonBrowse.Name = "toolStripButtonBrowse";
      this.toolStripButtonBrowse.Size = new System.Drawing.Size(62, 22);
      this.toolStripButtonBrowse.Text = "Browse";
      this.toolStripButtonBrowse.Click += new System.EventHandler(this.toolStripButtonBrowse_Click);
      // 
      // QueryRunner
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainerScript);
      this.Name = "QueryRunner";
      this.Size = new System.Drawing.Size(841, 595);
      this.Load += new System.EventHandler(this.QueryRunner_Load);
      this.splitContainerScript.Panel1.ResumeLayout(false);
      this.splitContainerScript.Panel1.PerformLayout();
      this.splitContainerScript.Panel2.ResumeLayout(false);
      this.splitContainerScript.Panel2.PerformLayout();
      this.splitContainerScript.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScript)).EndInit();
      this.contextMenuStripGrid.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.BindingSourceScript)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorScript)).EndInit();
      this.bindingNavigatorScript.ResumeLayout(false);
      this.bindingNavigatorScript.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainerScript;
    private System.Windows.Forms.TextBox textBoxScript;
    private System.Windows.Forms.DataGridView dataGridViewScript;
    private System.Windows.Forms.BindingNavigator bindingNavigatorScript;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton toolStripButtonViewRunQuery;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton printToolStripButtonViewReport;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton copyToolStripButtonQuery;
    private System.Windows.Forms.ToolStripComboBox toolStripComboBoxClipboardCopyMode;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.BindingSource BindingSourceScript;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripBlank;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripGrid;
    private System.Windows.Forms.ToolStripMenuItem viewObjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem browseObjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton toolStripButtonBrowse;

  }
}