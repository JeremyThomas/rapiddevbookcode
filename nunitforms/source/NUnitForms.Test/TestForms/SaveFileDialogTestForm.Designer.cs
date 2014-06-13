namespace NUnit.Extensions.Forms.TestApplications
{
  partial class SaveFileDialogTestForm
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
      this.btSave = new System.Windows.Forms.Button();
      this.lblFileName = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btSave
      // 
      this.btSave.Location = new System.Drawing.Point(91, 37);
      this.btSave.Name = "btSave";
      this.btSave.Size = new System.Drawing.Size(75, 23);
      this.btSave.TabIndex = 0;
      this.btSave.Text = "Save";
      this.btSave.UseVisualStyleBackColor = true;
      this.btSave.Click += new System.EventHandler(this.btSave_Click);
      // 
      // lblFileName
      // 
      this.lblFileName.AutoSize = true;
      this.lblFileName.Location = new System.Drawing.Point(91, 120);
      this.lblFileName.Name = "lblFileName";
      this.lblFileName.Size = new System.Drawing.Size(0, 13);
      this.lblFileName.TabIndex = 1;
      // 
      // SaveFileDialogTestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.lblFileName);
      this.Controls.Add(this.btSave);
      this.Name = "SaveFileDialogTestForm";
      this.Text = "SaveFileDialogTestForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btSave;
    private System.Windows.Forms.Label lblFileName;
  }
}