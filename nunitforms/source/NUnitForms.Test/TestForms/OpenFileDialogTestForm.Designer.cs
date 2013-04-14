namespace NUnit.Extensions.Forms.TestApplications
{
  partial class OpenFileDialogTestForm
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
      this.lblFileName = new System.Windows.Forms.Label();
      this.btOpenFile = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblFileName
      // 
      this.lblFileName.AutoSize = true;
      this.lblFileName.Location = new System.Drawing.Point(113, 137);
      this.lblFileName.Name = "lblFileName";
      this.lblFileName.Size = new System.Drawing.Size(35, 13);
      this.lblFileName.TabIndex = 0;
      this.lblFileName.Text = "label1";
      // 
      // btOpenFile
      // 
      this.btOpenFile.Location = new System.Drawing.Point(96, 89);
      this.btOpenFile.Name = "btOpenFile";
      this.btOpenFile.Size = new System.Drawing.Size(75, 23);
      this.btOpenFile.TabIndex = 1;
      this.btOpenFile.Text = "Open";
      this.btOpenFile.UseVisualStyleBackColor = true;
      this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
      // 
      // OpenFileDialogTestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.btOpenFile);
      this.Controls.Add(this.lblFileName);
      this.Name = "OpenFileDialogTestForm";
      this.Text = "OpenFileDialogTestForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblFileName;
    private System.Windows.Forms.Button btOpenFile;
  }
}