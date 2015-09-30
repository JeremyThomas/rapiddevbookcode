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
      this.gridDataEditor = new AW.Winforms.Helpers.Controls.GridDataEditor();
      this.bindingNavigatorPaging = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorData = new System.Windows.Forms.BindingNavigator(this.components);
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
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
      this.treeViewEntities.Size = new System.Drawing.Size(167, 585);
      this.treeViewEntities.TabIndex = 1;
      this.toolTip1.SetToolTip(this.treeViewEntities, "Entities amd their proerties");
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
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.gridDataEditor);
      this.splitContainer1.Size = new System.Drawing.Size(502, 585);
      this.splitContainer1.SplitterDistance = 167;
      this.splitContainer1.TabIndex = 3;
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
      this.gridDataEditor.Size = new System.Drawing.Size(331, 585);
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
      this.Size = new System.Drawing.Size(502, 585);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
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
  }
}