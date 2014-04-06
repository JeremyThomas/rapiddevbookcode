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
      this.SuspendLayout();
      // 
      // usrCntrlEntityBrowser1
      // 
      this.usrCntrlEntityBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.usrCntrlEntityBrowser1.Location = new System.Drawing.Point(0, 0);
      this.usrCntrlEntityBrowser1.Name = "usrCntrlEntityBrowser1";
      this.usrCntrlEntityBrowser1.Size = new System.Drawing.Size(643, 579);
      this.usrCntrlEntityBrowser1.TabIndex = 0;
      // 
      // FrmEntityBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(643, 579);
      this.Controls.Add(this.usrCntrlEntityBrowser1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmEntityBrowser";
      this.Text = "Northwind Data Browser";
      this.ResumeLayout(false);

    }

    #endregion

    private AW.Winforms.Helpers.LLBL.UsrCntrlEntityBrowser usrCntrlEntityBrowser1;
  }
}

