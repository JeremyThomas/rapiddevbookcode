namespace LLBLGen.EntityBrowser
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonAddConnection = new System.Windows.Forms.ToolStripButton();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.usrCntrlEntityBrowser1 = new AW.Winforms.Helpers.LLBL.UsrCntrlEntityBrowser();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.toolStrip1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabControl.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddConnection});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(714, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButtonAddConnection
      // 
      this.toolStripButtonAddConnection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddConnection.Image")));
      this.toolStripButtonAddConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonAddConnection.Name = "toolStripButtonAddConnection";
      this.toolStripButtonAddConnection.Size = new System.Drawing.Size(49, 22);
      this.toolStripButtonAddConnection.Text = "Add";
      this.toolStripButtonAddConnection.Click += new System.EventHandler(this.toolStripButtonAddConnection_Click);
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.usrCntrlEntityBrowser1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(706, 537);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // usrCntrlEntityBrowser1
      // 
      this.usrCntrlEntityBrowser1.ContextToUse = null;
      this.usrCntrlEntityBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.usrCntrlEntityBrowser1.EnsureFilteringEnabled = false;
      this.usrCntrlEntityBrowser1.Location = new System.Drawing.Point(3, 3);
      this.usrCntrlEntityBrowser1.Name = "usrCntrlEntityBrowser1";
      this.usrCntrlEntityBrowser1.Size = new System.Drawing.Size(700, 531);
      this.usrCntrlEntityBrowser1.TabIndex = 0;
      // 
      // tabControl
      // 
      this.tabControl.Controls.Add(this.tabPage1);
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 25);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(714, 563);
      this.tabControl.TabIndex = 1;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(714, 588);
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.toolStrip1);
      this.Name = "MainForm";
      this.Text = "Data Browser";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.tabPage1.ResumeLayout(false);
      this.tabControl.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButtonAddConnection;
    private System.Windows.Forms.TabPage tabPage1;
    private AW.Winforms.Helpers.LLBL.UsrCntrlEntityBrowser usrCntrlEntityBrowser1;
    private System.Windows.Forms.TabControl tabControl;
  }
}

