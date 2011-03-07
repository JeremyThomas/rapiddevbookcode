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
      this.textBoxScript = new System.Windows.Forms.RichTextBox();
      this.gridDataEditorScript = new AW.Winforms.Helpers.Controls.GridDataEditor();
      this.contextMenuStripGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.viewObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.browseObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripButtonRunQuery = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonBrowse = new System.Windows.Forms.ToolStripButton();
      this.contextMenuStripBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
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
      this.splitContainerScript.Size = new System.Drawing.Size(841, 595);
      this.splitContainerScript.SplitterDistance = 280;
      this.splitContainerScript.TabIndex = 6;
      // 
      // textBoxScript
      // 
      this.textBoxScript.AllowDrop = true;
      this.textBoxScript.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxScript.EnableAutoDragDrop = true;
      this.textBoxScript.Location = new System.Drawing.Point(0, 0);
      this.textBoxScript.Name = "textBoxScript";
      this.textBoxScript.Size = new System.Drawing.Size(841, 280);
      this.textBoxScript.TabIndex = 0;
      this.textBoxScript.Text = resources.GetString("textBoxScript.Text");
      this.textBoxScript.WordWrap = false;
      this.textBoxScript.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragDrop);
      this.textBoxScript.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxScript_MouseDown);
      this.textBoxScript.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragEnter);
      this.textBoxScript.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragOver);
      // 
      // gridDataEditorScript
      // 
      this.gridDataEditorScript.ContextMenuStrip = this.contextMenuStripGrid;
      this.gridDataEditorScript.DataMember = "";
      this.gridDataEditorScript.DataSource = null;
      this.gridDataEditorScript.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridDataEditorScript.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRunQuery,
            this.toolStripButtonBrowse});
      this.gridDataEditorScript.Location = new System.Drawing.Point(0, 0);
      this.gridDataEditorScript.Name = "gridDataEditorScript";
      this.gridDataEditorScript.PageSize = ((ushort)(0));
      this.gridDataEditorScript.Size = new System.Drawing.Size(841, 311);
      this.gridDataEditorScript.TabIndex = 5;
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
      // toolStripButtonRunQuery
      // 
      this.toolStripButtonRunQuery.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRunQuery.Image")));
      this.toolStripButtonRunQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonRunQuery.MergeIndex = 0;
      this.toolStripButtonRunQuery.Name = "toolStripButtonRunQuery";
      this.toolStripButtonRunQuery.Size = new System.Drawing.Size(76, 22);
      this.toolStripButtonRunQuery.Text = "RunQuery";
      this.toolStripButtonRunQuery.Click += new System.EventHandler(this.toolStripButtonViewRunQuery_Click);
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
      // contextMenuStripBlank
      // 
      this.contextMenuStripBlank.Name = "contextMenuStripBlank";
      this.contextMenuStripBlank.Size = new System.Drawing.Size(61, 4);
      // 
      // QueryRunner
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainerScript);
      this.Name = "QueryRunner";
      this.Size = new System.Drawing.Size(841, 595);
      this.Load += new System.EventHandler(this.QueryRunner_Load);
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxScript_DragDrop);
      this.splitContainerScript.Panel1.ResumeLayout(false);
      this.splitContainerScript.Panel2.ResumeLayout(false);
      this.splitContainerScript.ResumeLayout(false);
      this.contextMenuStripGrid.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainerScript;
    private System.Windows.Forms.RichTextBox textBoxScript;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripBlank;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripGrid;
    private System.Windows.Forms.ToolStripMenuItem viewObjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem browseObjectToolStripMenuItem;
    private AW.Winforms.Helpers.Controls.GridDataEditor gridDataEditorScript;
    private System.Windows.Forms.ToolStripButton toolStripButtonRunQuery;
    private System.Windows.Forms.ToolStripButton toolStripButtonBrowse;

  }
}