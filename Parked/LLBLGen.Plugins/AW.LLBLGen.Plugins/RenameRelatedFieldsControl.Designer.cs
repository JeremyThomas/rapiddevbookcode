namespace AW.LLBLGen.Plugins
{
  partial class RenameRelatedFieldsControl
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
      this.labelDescription = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelDescription
      // 
      this.labelDescription.AutoSize = true;
      this.labelDescription.Dock = System.Windows.Forms.DockStyle.Top;
      this.labelDescription.Location = new System.Drawing.Point(0, 0);
      this.labelDescription.Name = "labelDescription";
      this.labelDescription.Size = new System.Drawing.Size(82, 13);
      this.labelDescription.TabIndex = 0;
      this.labelDescription.Text = "labelDescription";
      // 
      // RenameRelatedFieldsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelDescription);
      this.Name = "RenameRelatedFieldsControl";
      this.Load += new System.EventHandler(this.RenameRelatedFieldsControl_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelDescription;
  }
}