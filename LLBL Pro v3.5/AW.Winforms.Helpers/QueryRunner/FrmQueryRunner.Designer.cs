namespace AW.Winforms.Helpers.QueryRunner
{
  partial class FrmQueryRunner
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.contextMenuStripTab = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
      this.closeAllButThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabPageSample = new System.Windows.Forms.TabPage();
      this.queryRunner1 = new AW.Winforms.Helpers.QueryRunner.QueryRunner();
      this.contextMenuStripBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.blankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.tabControl.SuspendLayout();
      this.contextMenuStripTab.SuspendLayout();
      this.tabPageSample.SuspendLayout();
      this.contextMenuStripBlank.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.AllowDrop = true;
      this.tabControl.ContextMenuStrip = this.contextMenuStripTab;
      this.tabControl.Controls.Add(this.tabPageSample);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 0);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(918, 624);
      this.tabControl.TabIndex = 0;
      this.tabControl.DragOver += new System.Windows.Forms.DragEventHandler(this.tabControl_DragOver);
      this.tabControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabControl_DragDrop);
      // 
      // contextMenuStripTab
      // 
      this.contextMenuStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSave,
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemClose,
            this.closeAllButThisToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.newToolStripMenuItem});
      this.contextMenuStripTab.Name = "contextMenuStripTab";
      this.contextMenuStripTab.Size = new System.Drawing.Size(167, 136);
      this.contextMenuStripTab.Text = "Save As...";
      // 
      // toolStripMenuItemSave
      // 
      this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
      this.toolStripMenuItemSave.Size = new System.Drawing.Size(166, 22);
      this.toolStripMenuItemSave.Text = "Save";
      this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
      // 
      // toolStripMenuItemOpen
      // 
      this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
      this.toolStripMenuItemOpen.Size = new System.Drawing.Size(166, 22);
      this.toolStripMenuItemOpen.Text = "Open";
      this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
      // 
      // toolStripMenuItemClose
      // 
      this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
      this.toolStripMenuItemClose.Size = new System.Drawing.Size(166, 22);
      this.toolStripMenuItemClose.Text = "Close";
      this.toolStripMenuItemClose.Click += new System.EventHandler(this.toolStripMenuItemClose_Click);
      // 
      // closeAllButThisToolStripMenuItem
      // 
      this.closeAllButThisToolStripMenuItem.Name = "closeAllButThisToolStripMenuItem";
      this.closeAllButThisToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
      this.closeAllButThisToolStripMenuItem.Text = "Close All But This";
      this.closeAllButThisToolStripMenuItem.Click += new System.EventHandler(this.closeAllButThisToolStripMenuItem_Click);
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
      this.saveAsToolStripMenuItem.Text = "Save As...";
      this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
      this.newToolStripMenuItem.Text = "New";
      this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
      // 
      // tabPageSample
      // 
      this.tabPageSample.ContextMenuStrip = this.contextMenuStripTab;
      this.tabPageSample.Controls.Add(this.queryRunner1);
      this.tabPageSample.Location = new System.Drawing.Point(4, 22);
      this.tabPageSample.Name = "tabPageSample";
      this.tabPageSample.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageSample.Size = new System.Drawing.Size(910, 598);
      this.tabPageSample.TabIndex = 0;
      this.tabPageSample.Text = "Sample";
      this.tabPageSample.ToolTipText = "Sample";
      this.tabPageSample.UseVisualStyleBackColor = true;
      // 
      // queryRunner1
      // 
      this.queryRunner1.AllowDrop = true;
      this.queryRunner1.ContextMenuStrip = this.contextMenuStripBlank;
      this.queryRunner1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.queryRunner1.Location = new System.Drawing.Point(3, 3);
      this.queryRunner1.Name = "queryRunner1";
      this.queryRunner1.Size = new System.Drawing.Size(904, 592);
      this.queryRunner1.TabIndex = 0;
      this.queryRunner1.DragOver += new System.Windows.Forms.DragEventHandler(this.tabControl_DragOver);
      this.queryRunner1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabControl_DragDrop);
      // 
      // contextMenuStripBlank
      // 
      this.contextMenuStripBlank.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blankToolStripMenuItem});
      this.contextMenuStripBlank.Name = "contextMenuStripBlank";
      this.contextMenuStripBlank.Size = new System.Drawing.Size(111, 26);
      // 
      // blankToolStripMenuItem
      // 
      this.blankToolStripMenuItem.Name = "blankToolStripMenuItem";
      this.blankToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.blankToolStripMenuItem.Text = "blank";
      // 
      // openFileDialog
      // 
      this.openFileDialog.DefaultExt = "cs";
      this.openFileDialog.Filter = "C# files|*.cs|Text files (*.txt)|*.txt|All files (*.*)|*.* ";
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.Filter = "C# files|*.cs|Text files (*.txt)|*.txt|All files (*.*)|*.* ";
      // 
      // FrmQueryRunner
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(918, 624);
      this.Controls.Add(this.tabControl);
      this.Name = "FrmQueryRunner";
      this.Tag = "true";
      this.Text = "Query Runner";
      this.tabControl.ResumeLayout(false);
      this.contextMenuStripTab.ResumeLayout(false);
      this.tabPageSample.ResumeLayout(false);
      this.contextMenuStripBlank.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPageSample;
    private QueryRunner queryRunner1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripTab;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClose;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.ToolStripMenuItem closeAllButThisToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripBlank;
    private System.Windows.Forms.ToolStripMenuItem blankToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
  }
}