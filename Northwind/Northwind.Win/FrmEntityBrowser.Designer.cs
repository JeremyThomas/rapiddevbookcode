namespace Northwind.Win
{
  partial class FrmEntityBrowser
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntityBrowser));
      this.usrCntrlEntityBrowser1 = new AW.Winforms.Helpers.LLBL.UsrCntrlEntityBrowser();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonRemote = new System.Windows.Forms.ToolStripButton();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // usrCntrlEntityBrowser1
      // 
      this.usrCntrlEntityBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.usrCntrlEntityBrowser1.Location = new System.Drawing.Point(0, 25);
      this.usrCntrlEntityBrowser1.Name = "usrCntrlEntityBrowser1";
      this.usrCntrlEntityBrowser1.Size = new System.Drawing.Size(643, 554);
      this.usrCntrlEntityBrowser1.TabIndex = 0;
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRemote});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(643, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButtonRemote
      // 
      this.toolStripButtonRemote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonRemote.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemote.Image")));
      this.toolStripButtonRemote.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonRemote.Name = "toolStripButtonRemote";
      this.toolStripButtonRemote.Size = new System.Drawing.Size(52, 22);
      this.toolStripButtonRemote.Text = "Remote";
      this.toolStripButtonRemote.Click += new System.EventHandler(this.toolStripButtonRemote_Click);
      // 
      // FrmEntityBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(643, 579);
      this.Controls.Add(this.usrCntrlEntityBrowser1);
      this.Controls.Add(this.toolStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmEntityBrowser";
      this.Text = "Northwind Data Browser";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private AW.Winforms.Helpers.LLBL.UsrCntrlEntityBrowser usrCntrlEntityBrowser1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButtonRemote;
  }
}

