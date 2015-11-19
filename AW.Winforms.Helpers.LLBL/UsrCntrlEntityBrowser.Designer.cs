using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AW.Winforms.Helpers.Controls;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  partial class UsrCntrlEntityBrowser
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrCntrlEntityBrowser));
      this.treeViewEntities = new System.Windows.Forms.TreeView();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonCancelEdit = new System.Windows.Forms.ToolStripButton();
      this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.ensureFilteringEnabledCheckBox = new AW.Winforms.Helpers.Controls.ToolStripCheckBox();
      this.useSchemaCheckBox = new AW.Winforms.Helpers.Controls.ToolStripCheckBox();
      this.useContextCheckBox = new AW.Winforms.Helpers.Controls.ToolStripCheckBox();
      this.prefixDelimiterLabel = new System.Windows.Forms.ToolStripLabel();
      this.prefixDelimiterTextBox = new System.Windows.Forms.ToolStripTextBox();
      this.cacheDurationInSecondsNumericUpDown = new AW.Winforms.Helpers.Controls.ToolStripNumericUpDown();
      this.pageSizeNumericUpDown = new AW.Winforms.Helpers.Controls.ToolStripNumericUpDown();
      this.gridDataEditor = new AW.Winforms.Helpers.Controls.GridDataEditor();
      this.bindingNavigatorPaging = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorData = new System.Windows.Forms.BindingNavigator(this.components);
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.toolStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridDataEditor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPaging)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorData)).BeginInit();
      this.SuspendLayout();
      // 
      // treeViewEntities
      // 
      this.treeViewEntities.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeViewEntities.ImageIndex = 0;
      this.treeViewEntities.ImageList = this.imageList1;
      this.treeViewEntities.Location = new System.Drawing.Point(0, 0);
      this.treeViewEntities.Name = "treeViewEntities";
      this.treeViewEntities.SelectedImageIndex = 4;
      this.treeViewEntities.ShowNodeToolTips = true;
      this.treeViewEntities.Size = new System.Drawing.Size(254, 557);
      this.treeViewEntities.TabIndex = 1;
      this.toolTip1.SetToolTip(this.treeViewEntities, "Entities amd their proerties");
      this.treeViewEntities.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEntities_AfterExpand);
      this.treeViewEntities.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEntities_AfterExpand);
      this.treeViewEntities.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEntities_AfterSelect);
      this.treeViewEntities.Click += new System.EventHandler(this.treeViewEntities_Click);
      this.treeViewEntities.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewEntities_KeyDown);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "TableHS.png");
      this.imageList1.Images.SetKeyName(1, "PropertiesHS.png");
      this.imageList1.Images.SetKeyName(2, "GoRtl.bmp");
      this.imageList1.Images.SetKeyName(3, "GoLtr.bmp");
      this.imageList1.Images.SetKeyName(4, "PushpinHS.png");
      this.imageList1.Images.SetKeyName(5, "EntityDataModel_entity_container_16x16.png");
      this.imageList1.Images.SetKeyName(6, "XSDSchema_SequenceIcon.png");
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.treeViewEntities);
      this.splitContainer1.Panel1.Controls.Add(this.toolStrip);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.gridDataEditor);
      this.splitContainer1.Size = new System.Drawing.Size(764, 585);
      this.splitContainer1.SplitterDistance = 254;
      this.splitContainer1.TabIndex = 3;
      // 
      // toolStrip
      // 
      this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCancelEdit,
            this.saveToolStripButton,
            this.ensureFilteringEnabledCheckBox,
            this.useSchemaCheckBox,
            this.useContextCheckBox,
            this.prefixDelimiterLabel,
            this.prefixDelimiterTextBox,
            this.cacheDurationInSecondsNumericUpDown,
            this.pageSizeNumericUpDown});
      this.toolStrip.Location = new System.Drawing.Point(0, 557);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(254, 28);
      this.toolStrip.TabIndex = 2;
      this.toolStrip.Text = "toolStrip";
      // 
      // toolStripButtonCancelEdit
      // 
      this.toolStripButtonCancelEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonCancelEdit.Enabled = false;
      this.toolStripButtonCancelEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelEdit.Image")));
      this.toolStripButtonCancelEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonCancelEdit.Name = "toolStripButtonCancelEdit";
      this.toolStripButtonCancelEdit.Size = new System.Drawing.Size(23, 25);
      this.toolStripButtonCancelEdit.Text = "Cancel";
      this.toolStripButtonCancelEdit.Click += new System.EventHandler(this.toolStripButtonCancelEdit_Click);
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Enabled = false;
      this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
      this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new System.Drawing.Size(23, 25);
      this.saveToolStripButton.Text = "&Save";
      this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
      // 
      // ensureFilteringEnabledCheckBox
      // 
      this.ensureFilteringEnabledCheckBox.Checked = false;
      this.ensureFilteringEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Unchecked;
      this.ensureFilteringEnabledCheckBox.Name = "ensureFilteringEnabledCheckBox";
      this.ensureFilteringEnabledCheckBox.Size = new System.Drawing.Size(155, 25);
      this.ensureFilteringEnabledCheckBox.Text = "Ensure Filtering Enabled:";
      this.ensureFilteringEnabledCheckBox.Click += new System.EventHandler(this.ensureFilteringEnabledCheckBox_Click);
      // 
      // useSchemaCheckBox
      // 
      this.useSchemaCheckBox.Checked = false;
      this.useSchemaCheckBox.CheckState = System.Windows.Forms.CheckState.Unchecked;
      this.useSchemaCheckBox.Name = "useSchemaCheckBox";
      this.useSchemaCheckBox.Size = new System.Drawing.Size(93, 19);
      this.useSchemaCheckBox.Text = "Use Schema:";
      this.useSchemaCheckBox.Click += new System.EventHandler(this.toolStripCheckBox1_Click);
      // 
      // useContextCheckBox
      // 
      this.useContextCheckBox.Checked = false;
      this.useContextCheckBox.CheckState = System.Windows.Forms.CheckState.Unchecked;
      this.useContextCheckBox.Name = "useContextCheckBox";
      this.useContextCheckBox.Size = new System.Drawing.Size(92, 19);
      this.useContextCheckBox.Text = "Use Context:";
      this.useContextCheckBox.Click += new System.EventHandler(this.useContextCheckBox_Click);
      // 
      // prefixDelimiterLabel
      // 
      this.prefixDelimiterLabel.Name = "prefixDelimiterLabel";
      this.prefixDelimiterLabel.Size = new System.Drawing.Size(90, 15);
      this.prefixDelimiterLabel.Text = "Prefix Delimiter:";
      // 
      // prefixDelimiterTextBox
      // 
      this.prefixDelimiterTextBox.MaxLength = 25;
      this.prefixDelimiterTextBox.Name = "prefixDelimiterTextBox";
      this.prefixDelimiterTextBox.Size = new System.Drawing.Size(20, 23);
      this.prefixDelimiterTextBox.ToolTipText = "Prefix Delimiter e.g. _";
      this.prefixDelimiterTextBox.Click += new System.EventHandler(this.prefixDelimiterTextBox_Click);
      // 
      // cacheDurationInSecondsNumericUpDown
      // 
      this.cacheDurationInSecondsNumericUpDown.BackColor = System.Drawing.Color.Transparent;
      this.cacheDurationInSecondsNumericUpDown.DecimalPlaces = 0;
      this.cacheDurationInSecondsNumericUpDown.Name = "cacheDurationInSecondsNumericUpDown";
      this.cacheDurationInSecondsNumericUpDown.NumBackColor = System.Drawing.SystemColors.Window;
      this.cacheDurationInSecondsNumericUpDown.Size = new System.Drawing.Size(53, 25);
      this.cacheDurationInSecondsNumericUpDown.Text = "Cache Duration In Seconds:";
      this.cacheDurationInSecondsNumericUpDown.TextVisible = false;
      this.cacheDurationInSecondsNumericUpDown.ValueChanged += new System.EventHandler(this.cacheDurationInSecondsNumericUpDown_ValueChanged);
      // 
      // pageSizeNumericUpDown
      // 
      this.pageSizeNumericUpDown.BackColor = System.Drawing.Color.Transparent;
      this.pageSizeNumericUpDown.DecimalPlaces = 0;
      this.pageSizeNumericUpDown.Name = "pageSizeNumericUpDown";
      this.pageSizeNumericUpDown.NumBackColor = System.Drawing.SystemColors.Window;
      this.pageSizeNumericUpDown.Size = new System.Drawing.Size(53, 25);
      this.pageSizeNumericUpDown.Text = "PageSize";
      this.pageSizeNumericUpDown.TextVisible = false;
      this.pageSizeNumericUpDown.Click += new System.EventHandler(this.pageSizeNumericUpDown_Click);
      // 
      // gridDataEditor
      // 
      this.gridDataEditor.DataMember = "";
      this.gridDataEditor.DataSource = null;
      this.gridDataEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridDataEditor.EnsureFilteringEnabled = false;
      this.gridDataEditor.Location = new System.Drawing.Point(0, 0);
      this.gridDataEditor.MembersToExclude = null;
      this.gridDataEditor.Name = "gridDataEditor";
      this.gridDataEditor.PageSize = ((ushort)(15));
      this.gridDataEditor.Readonly = false;
      this.gridDataEditor.Size = new System.Drawing.Size(506, 585);
      this.gridDataEditor.TabIndex = 0;
      this.toolTip1.SetToolTip(this.gridDataEditor, "Data in the Tables");
      // 
      // bindingNavigatorPaging
      // 
      this.bindingNavigatorPaging.AddNewItem = null;
      this.bindingNavigatorPaging.CountItem = null;
      this.bindingNavigatorPaging.DeleteItem = null;
      this.bindingNavigatorPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.bindingNavigatorPaging.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPaging.Location = new System.Drawing.Point(0, 538);
      this.bindingNavigatorPaging.MoveFirstItem = null;
      this.bindingNavigatorPaging.MoveLastItem = null;
      this.bindingNavigatorPaging.MoveNextItem = null;
      this.bindingNavigatorPaging.MovePreviousItem = null;
      this.bindingNavigatorPaging.Name = "bindingNavigatorPaging";
      this.bindingNavigatorPaging.PositionItem = null;
      this.bindingNavigatorPaging.Size = new System.Drawing.Size(331, 25);
      this.bindingNavigatorPaging.TabIndex = 5;
      this.bindingNavigatorPaging.Text = "bindingNavigator2";
      // 
      // bindingNavigatorData
      // 
      this.bindingNavigatorData.AddNewItem = null;
      this.bindingNavigatorData.CountItem = null;
      this.bindingNavigatorData.DeleteItem = null;
      this.bindingNavigatorData.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorData.Location = new System.Drawing.Point(0, 0);
      this.bindingNavigatorData.MoveFirstItem = null;
      this.bindingNavigatorData.MoveLastItem = null;
      this.bindingNavigatorData.MoveNextItem = null;
      this.bindingNavigatorData.MovePreviousItem = null;
      this.bindingNavigatorData.Name = "bindingNavigatorData";
      this.bindingNavigatorData.PositionItem = null;
      this.bindingNavigatorData.Size = new System.Drawing.Size(331, 25);
      this.bindingNavigatorData.TabIndex = 2;
      this.bindingNavigatorData.Text = "bindingNavigator1";
      // 
      // UsrCntrlEntityBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Name = "UsrCntrlEntityBrowser";
      this.Size = new System.Drawing.Size(764, 585);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridDataEditor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPaging)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorData)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private ImageList imageList1;
    private SplitContainer splitContainer1;
    internal TreeView treeViewEntities;
    private GridDataEditor gridDataEditor;
    private BindingNavigator bindingNavigatorPaging;
    private BindingNavigator bindingNavigatorData;
    private ToolTip toolTip1;
    private ToolStrip toolStrip;
    private ToolStripButton saveToolStripButton;
    public ToolStripButton toolStripButtonCancelEdit;
    private ToolStripCheckBox ensureFilteringEnabledCheckBox;
    private ToolStripCheckBox useSchemaCheckBox;
    private ToolStripCheckBox useContextCheckBox;
    private ToolStripLabel prefixDelimiterLabel;
    private ToolStripTextBox prefixDelimiterTextBox;
    private ToolStripNumericUpDown cacheDurationInSecondsNumericUpDown;
    private ToolStripNumericUpDown pageSizeNumericUpDown;
  }
}