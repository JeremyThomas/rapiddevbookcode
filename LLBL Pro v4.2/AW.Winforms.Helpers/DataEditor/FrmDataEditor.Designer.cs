using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AW.Winforms.Helpers.Controls;

namespace AW.Winforms.Helpers.DataEditor
{
  partial class FrmDataEditor
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
      ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmDataEditor));
      this.SuspendLayout();
      // 
      // FrmDataEditor
      // 
      this.AutoScaleDimensions = new SizeF(6F, 13F);
      this.ClientSize = new Size(529, 459);
      this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmDataEditor";
      this.Text = "FrmDataEditor";
      this.ResumeLayout(false);

    }

    #endregion
  }
}