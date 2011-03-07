namespace NUnit.Extensions.Forms.TestApplications
{
  partial class UnderscoreNameForm
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
      this._button = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // _button
      // 
      this._button.Location = new System.Drawing.Point(13, 13);
      this._button.Name = "_button";
      this._button.Size = new System.Drawing.Size(75, 23);
      this._button.TabIndex = 0;
      this._button.Text = "_button";
      this._button.UseVisualStyleBackColor = true;
      // 
      // UnderscoreNameTest
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(241, 62);
      this.Controls.Add(this._button);
      this.Name = "UnderscoreNameTest";
      this.Text = "UnderscoreNameTest";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button _button;
  }
}