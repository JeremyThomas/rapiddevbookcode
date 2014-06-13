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
      this.components = new Container();
      ComponentResourceManager resources = new ComponentResourceManager(typeof(UsrCntrlEntityBrowser));
      this.treeViewEntities = new TreeView();
      this.imageList1 = new ImageList(this.components);
      this.splitContainer1 = new SplitContainer();
      this.gridDataEditor = new GridDataEditor();
      this.bindingNavigatorPaging = new BindingNavigator(this.components);
      this.bindingNavigatorData = new BindingNavigator(this.components);
      this.toolTip1 = new ToolTip(this.components);
      ((ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((ISupportInitialize)(this.bindingNavigatorPaging)).BeginInit();
      ((ISupportInitialize)(this.bindingNavigatorData)).BeginInit();
      this.SuspendLayout();
      // 
      // treeViewEntities
      // 
      this.treeViewEntities.Dock = DockStyle.Fill;
      this.treeViewEntities.ImageIndex = 0;
      this.treeViewEntities.ImageList = this.imageList1;
      this.treeViewEntities.Location = new Point(0, 0);
      this.treeViewEntities.Name = "treeViewEntities";
      this.treeViewEntities.SelectedImageIndex = 4;
      this.treeViewEntities.ShowNodeToolTips = true;
      this.treeViewEntities.Size = new Size(167, 585);
      this.treeViewEntities.TabIndex = 1;
      this.toolTip1.SetToolTip(this.treeViewEntities, "Entities amd their proerties");
      this.treeViewEntities.AfterSelect += new TreeViewEventHandler(this.treeViewEntities_AfterSelect);
      this.treeViewEntities.Click += new EventHandler(this.treeViewEntities_Click);
      this.treeViewEntities.KeyDown += new KeyEventHandler(this.treeViewEntities_KeyDown);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = Color.Transparent;
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
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.Location = new Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.treeViewEntities);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.gridDataEditor);
      this.splitContainer1.Size = new Size(502, 585);
      this.splitContainer1.SplitterDistance = 167;
      this.splitContainer1.TabIndex = 3;
      // 
      // gridDataEditor
      // 
      this.gridDataEditor.DataMember = "";
      this.gridDataEditor.DataSource = null;
      this.gridDataEditor.Dock = DockStyle.Fill;
      this.gridDataEditor.EnsureFilteringEnabled = false;
      this.gridDataEditor.Location = new Point(0, 0);
      this.gridDataEditor.MembersToExclude = null;
      this.gridDataEditor.Name = "gridDataEditor";
      this.gridDataEditor.PageSize = ((ushort)(0));
      this.gridDataEditor.Readonly = false;
      this.gridDataEditor.Size = new Size(331, 585);
      this.gridDataEditor.TabIndex = 0;
      this.toolTip1.SetToolTip(this.gridDataEditor, "Data in the Tables");
      // 
      // bindingNavigatorPaging
      // 
      this.bindingNavigatorPaging.AddNewItem = null;
      this.bindingNavigatorPaging.CountItem = null;
      this.bindingNavigatorPaging.DeleteItem = null;
      this.bindingNavigatorPaging.Dock = DockStyle.Bottom;
      this.bindingNavigatorPaging.Font = new Font("Segoe UI", 9F);
      this.bindingNavigatorPaging.Location = new Point(0, 538);
      this.bindingNavigatorPaging.MoveFirstItem = null;
      this.bindingNavigatorPaging.MoveLastItem = null;
      this.bindingNavigatorPaging.MoveNextItem = null;
      this.bindingNavigatorPaging.MovePreviousItem = null;
      this.bindingNavigatorPaging.Name = "bindingNavigatorPaging";
      this.bindingNavigatorPaging.PositionItem = null;
      this.bindingNavigatorPaging.Size = new Size(331, 25);
      this.bindingNavigatorPaging.TabIndex = 5;
      this.bindingNavigatorPaging.Text = "bindingNavigator2";
      // 
      // bindingNavigatorData
      // 
      this.bindingNavigatorData.AddNewItem = null;
      this.bindingNavigatorData.CountItem = null;
      this.bindingNavigatorData.DeleteItem = null;
      this.bindingNavigatorData.Font = new Font("Segoe UI", 9F);
      this.bindingNavigatorData.Location = new Point(0, 0);
      this.bindingNavigatorData.MoveFirstItem = null;
      this.bindingNavigatorData.MoveLastItem = null;
      this.bindingNavigatorData.MoveNextItem = null;
      this.bindingNavigatorData.MovePreviousItem = null;
      this.bindingNavigatorData.Name = "bindingNavigatorData";
      this.bindingNavigatorData.PositionItem = null;
      this.bindingNavigatorData.Size = new Size(331, 25);
      this.bindingNavigatorData.TabIndex = 2;
      this.bindingNavigatorData.Text = "bindingNavigator1";
      // 
      // UsrCntrlEntityBrowser
      // 
      this.AutoScaleDimensions = new SizeF(6F, 13F);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Name = "UsrCntrlEntityBrowser";
      this.Size = new Size(502, 585);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((ISupportInitialize)(this.bindingNavigatorPaging)).EndInit();
      ((ISupportInitialize)(this.bindingNavigatorData)).EndInit();
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
  }
}