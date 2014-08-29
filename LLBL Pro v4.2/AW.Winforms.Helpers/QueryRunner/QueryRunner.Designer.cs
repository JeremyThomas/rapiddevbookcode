﻿using AW.Winforms.Helpers.Controls;

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
      this.splitContainerScript = new System.Windows.Forms.SplitContainer();
      this.textBoxScript = new CSharpEditor();
      this.contextMenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.viewObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.browseObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStripBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.gridDataEditorScript = new AW.Winforms.Helpers.Controls.GridDataEditor();
      this.toolStripButtonRunQuery = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonBrowse = new System.Windows.Forms.ToolStripButton();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerScript)).BeginInit();
      this.splitContainerScript.Panel1.SuspendLayout();
      this.splitContainerScript.Panel2.SuspendLayout();
      this.splitContainerScript.SuspendLayout();
      this.contextMenuStripGrid.SuspendLayout();
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
      this.splitContainerScript.Panel2.Controls.Add(this.gridDataEditorScript);
      this.splitContainerScript.Size = new System.Drawing.Size(913, 400);
      this.splitContainerScript.SplitterDistance = 200;
      this.splitContainerScript.TabIndex = 6;
      // 
      // textBoxScript
      // 
      this.textBoxScript.AllowDrop = true;
      this.textBoxScript.Dock = System.Windows.Forms.DockStyle.Fill;

      this.textBoxScript.Location = new System.Drawing.Point(0, 0);
      this.textBoxScript.Name = "textBoxScript";
      this.textBoxScript.Size = new System.Drawing.Size(913, 200);
      this.textBoxScript.TabIndex = 0;
      this.textBoxScript.Text = resources.GetString("textBoxScript.Text");

      this.textBoxScript.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragDrop);
      this.textBoxScript.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragEnter);
      this.textBoxScript.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragOver);
      this.textBoxScript.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxScript_MouseDown);
      // 
      // contextMenuStripGrid
      // 
      this.contextMenuStripGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewObjectToolStripMenuItem,
            this.browseObjectToolStripMenuItem});
      this.contextMenuStripGrid.Name = "contextMenuStripGrid";
      this.contextMenuStripGrid.Size = new System.Drawing.Size(151, 48);
      // 
      // viewObjectToolStripMenuItem
      // 
      this.viewObjectToolStripMenuItem.Name = "viewObjectToolStripMenuItem";
      this.viewObjectToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.viewObjectToolStripMenuItem.Text = "View Object";
      this.viewObjectToolStripMenuItem.Click += new System.EventHandler(this.viewObjectToolStripMenuItem_Click);
      // 
      // browseObjectToolStripMenuItem
      // 
      this.browseObjectToolStripMenuItem.Name = "browseObjectToolStripMenuItem";
      this.browseObjectToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.browseObjectToolStripMenuItem.Text = "Browse Object";
      this.browseObjectToolStripMenuItem.Click += new System.EventHandler(this.browseObjectToolStripMenuItem_Click);
      // 
      // contextMenuStripBlank
      // 
      this.contextMenuStripBlank.Name = "contextMenuStripBlank";
      this.contextMenuStripBlank.Size = new System.Drawing.Size(61, 4);
      // 
      // gridDataEditorScript
      // 
      this.gridDataEditorScript.ContextMenuStrip = this.contextMenuStripGrid;
      this.gridDataEditorScript.DataMember = "";
      this.gridDataEditorScript.DataSource = null;
      this.gridDataEditorScript.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridDataEditorScript.EnsureFilteringEnabled = false;
      this.gridDataEditorScript.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRunQuery,
            this.toolStripButtonBrowse});
      this.gridDataEditorScript.Location = new System.Drawing.Point(0, 0);
      this.gridDataEditorScript.MembersToExclude = null;
      this.gridDataEditorScript.Name = "gridDataEditorScript";
      this.gridDataEditorScript.PageSize = ((ushort)(0));
      this.gridDataEditorScript.Readonly = false;
      this.gridDataEditorScript.Size = new System.Drawing.Size(913, 196);
      this.gridDataEditorScript.TabIndex = 5;
      // 
      // toolStripButtonRunQuery
      // 
      this.toolStripButtonRunQuery.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRunQuery.Image")));
      this.toolStripButtonRunQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonRunQuery.MergeIndex = 0;
      this.toolStripButtonRunQuery.Name = "toolStripButtonRunQuery";
      this.toolStripButtonRunQuery.Size = new System.Drawing.Size(80, 22);
      this.toolStripButtonRunQuery.Text = "RunQuery";
      this.toolStripButtonRunQuery.Click += new System.EventHandler(this.toolStripButtonViewRunQuery_Click);
      // 
      // toolStripButtonBrowse
      // 
      this.toolStripButtonBrowse.Enabled = false;
      this.toolStripButtonBrowse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBrowse.Image")));
      this.toolStripButtonBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonBrowse.Name = "toolStripButtonBrowse";
      this.toolStripButtonBrowse.Size = new System.Drawing.Size(65, 22);
      this.toolStripButtonBrowse.Text = "Browse";
      this.toolStripButtonBrowse.Click += new System.EventHandler(this.toolStripButtonBrowse_Click);
      // 
      // QueryRunner
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainerScript);
      this.Name = "QueryRunner";
      this.Size = new System.Drawing.Size(913, 400);
      this.Load += new System.EventHandler(this.QueryRunner_Load);
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragDrop);
      this.splitContainerScript.Panel1.ResumeLayout(false);
      this.splitContainerScript.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerScript)).EndInit();
      this.splitContainerScript.ResumeLayout(false);
      this.contextMenuStripGrid.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.SplitContainer splitContainerScript;
    private CSharpEditor textBoxScript;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripBlank;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripGrid;
    private System.Windows.Forms.ToolStripMenuItem viewObjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem browseObjectToolStripMenuItem;
    private AW.Winforms.Helpers.Controls.GridDataEditor gridDataEditorScript;
    private System.Windows.Forms.ToolStripButton toolStripButtonRunQuery;
    private System.Windows.Forms.ToolStripButton toolStripButtonBrowse;

  }
}