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
      this.tabPageSample = new System.Windows.Forms.TabPage();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.closeAllButThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStripBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.queryRunner1 = new AW.Winforms.Helpers.QueryRunner.QueryRunner();
      this.blankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabControl.SuspendLayout();
      this.contextMenuStripTab.SuspendLayout();
      this.tabPageSample.SuspendLayout();
      this.contextMenuStripBlank.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.ContextMenuStrip = this.contextMenuStripTab;
      this.tabControl.Controls.Add(this.tabPageSample);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 0);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(918, 624);
      this.tabControl.TabIndex = 0;
      // 
      // contextMenuStripTab
      // 
      this.contextMenuStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSave,
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemClose,
            this.closeAllButThisToolStripMenuItem,
            this.saveAsToolStripMenuItem});
      this.contextMenuStripTab.Name = "contextMenuStripTab";
      this.contextMenuStripTab.Size = new System.Drawing.Size(167, 114);
      this.contextMenuStripTab.Text = "Save As...";
      this.contextMenuStripTab.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTab_Opening);
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
      // tabPageSample
      // 
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
      // openFileDialog
      // 
      this.openFileDialog.DefaultExt = "cs";
      this.openFileDialog.Filter = "C# files|*.cs|Text files (*.txt)|*.txt|All files (*.*)|*.* ";
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.Filter = "C# files|*.cs|Text files (*.txt)|*.txt|All files (*.*)|*.* ";
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
      // contextMenuStripBlank
      // 
      this.contextMenuStripBlank.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blankToolStripMenuItem});
      this.contextMenuStripBlank.Name = "contextMenuStripBlank";
      this.contextMenuStripBlank.Size = new System.Drawing.Size(111, 26);
      // 
      // queryRunner1
      // 
      this.queryRunner1.ContextMenuStrip = this.contextMenuStripBlank;
      this.queryRunner1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.queryRunner1.Location = new System.Drawing.Point(3, 3);
      this.queryRunner1.Name = "queryRunner1";
      this.queryRunner1.Size = new System.Drawing.Size(904, 592);
      this.queryRunner1.TabIndex = 0;
      // 
      // blankToolStripMenuItem
      // 
      this.blankToolStripMenuItem.Name = "blankToolStripMenuItem";
      this.blankToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.blankToolStripMenuItem.Text = "blank";
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
      this.Load += new System.EventHandler(this.FrmQueryRunner_Load);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQueryRunner_FormClosing);
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
  }
}