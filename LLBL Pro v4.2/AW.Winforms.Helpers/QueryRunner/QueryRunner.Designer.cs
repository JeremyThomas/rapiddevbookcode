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
      this.contextMenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.viewObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.browseObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStripBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.splitContainerScript = new System.Windows.Forms.SplitContainer();
      this.textBoxScript = new AW.Winforms.Helpers.Controls.CSharpEditor();
      this.tabControlResults = new System.Windows.Forms.TabControl();
      this.tabPageGrid = new System.Windows.Forms.TabPage();
      this.gridDataEditorScript = new AW.Winforms.Helpers.Controls.GridDataEditor();
      this.toolStripButtonRunQuery = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonBrowse = new System.Windows.Forms.ToolStripButton();
      this.tabPageText = new System.Windows.Forms.TabPage();
      this.textBoxOutPut = new System.Windows.Forms.TextBox();
      this.contextMenuStripGrid.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerScript)).BeginInit();
      this.splitContainerScript.Panel1.SuspendLayout();
      this.splitContainerScript.Panel2.SuspendLayout();
      this.splitContainerScript.SuspendLayout();
      this.tabControlResults.SuspendLayout();
      this.tabPageGrid.SuspendLayout();
      this.tabPageText.SuspendLayout();
      this.SuspendLayout();
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
      this.splitContainerScript.Panel2.Controls.Add(this.tabControlResults);
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
      this.textBoxScript.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragDrop);
      this.textBoxScript.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragEnter);
      this.textBoxScript.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragOver);
      this.textBoxScript.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxScript_MouseDown);
      // 
      // tabControlResults
      // 
      this.tabControlResults.Controls.Add(this.tabPageGrid);
      this.tabControlResults.Controls.Add(this.tabPageText);
      this.tabControlResults.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tabControlResults.Location = new System.Drawing.Point(0, 0);
      this.tabControlResults.Name = "tabControlResults";
      this.tabControlResults.SelectedIndex = 0;
      this.tabControlResults.Size = new System.Drawing.Size(913, 196);
      this.tabControlResults.TabIndex = 6;
      // 
      // tabPageGrid
      // 
      this.tabPageGrid.Controls.Add(this.gridDataEditorScript);
      this.tabPageGrid.Location = new System.Drawing.Point(4, 22);
      this.tabPageGrid.Name = "tabPageGrid";
      this.tabPageGrid.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageGrid.Size = new System.Drawing.Size(905, 170);
      this.tabPageGrid.TabIndex = 0;
      this.tabPageGrid.Text = "Grid";
      this.tabPageGrid.UseVisualStyleBackColor = true;
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
      this.gridDataEditorScript.Location = new System.Drawing.Point(3, 3);
      this.gridDataEditorScript.MembersToExclude = null;
      this.gridDataEditorScript.Name = "gridDataEditorScript";
      this.gridDataEditorScript.PageSize = ((ushort)(0));
      this.gridDataEditorScript.Readonly = false;
      this.gridDataEditorScript.Size = new System.Drawing.Size(899, 164);
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
      // tabPageText
      // 
      this.tabPageText.Controls.Add(this.textBoxOutPut);
      this.tabPageText.Location = new System.Drawing.Point(4, 22);
      this.tabPageText.Name = "tabPageText";
      this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageText.Size = new System.Drawing.Size(905, 170);
      this.tabPageText.TabIndex = 1;
      this.tabPageText.Text = "Text";
      this.tabPageText.UseVisualStyleBackColor = true;
      // 
      // textBoxOutPut
      // 
      this.textBoxOutPut.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxOutPut.Location = new System.Drawing.Point(3, 3);
      this.textBoxOutPut.Multiline = true;
      this.textBoxOutPut.Name = "textBoxOutPut";
      this.textBoxOutPut.Size = new System.Drawing.Size(899, 164);
      this.textBoxOutPut.TabIndex = 0;
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
      this.contextMenuStripGrid.ResumeLayout(false);
      this.splitContainerScript.Panel1.ResumeLayout(false);
      this.splitContainerScript.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerScript)).EndInit();
      this.splitContainerScript.ResumeLayout(false);
      this.tabControlResults.ResumeLayout(false);
      this.tabPageGrid.ResumeLayout(false);
      this.tabPageText.ResumeLayout(false);
      this.tabPageText.PerformLayout();
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
    private System.Windows.Forms.TabControl tabControlResults;
    private System.Windows.Forms.TabPage tabPageGrid;
    private System.Windows.Forms.TabPage tabPageText;
    private System.Windows.Forms.TextBox textBoxOutPut;
  }
}