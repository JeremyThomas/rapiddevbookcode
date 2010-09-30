namespace NUnit.Extensions.Forms.TestApplications
{
  partial class RichTextBoxTestForm
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
      this.myTextBox = new System.Windows.Forms.RichTextBox();
      this.anotherTextBox = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // myTextBox
      // 
      this.myTextBox.Location = new System.Drawing.Point(67, 69);
      this.myTextBox.Name = "myTextBox";
      this.myTextBox.Size = new System.Drawing.Size(137, 30);
      this.myTextBox.TabIndex = 0;
      this.myTextBox.Text = "default";
      // 
      // anotherTextBox
      // 
      this.anotherTextBox.Location = new System.Drawing.Point(66, 131);
      this.anotherTextBox.Name = "anotherTextBox";
      this.anotherTextBox.Size = new System.Drawing.Size(138, 26);
      this.anotherTextBox.TabIndex = 1;
      this.anotherTextBox.Text = "";
      // 
      // RichTextBoxTestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.anotherTextBox);
      this.Controls.Add(this.myTextBox);
      this.Name = "RichTextBoxTestForm";
      this.Text = "RichTextBoxTestForm";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox myTextBox;
    private System.Windows.Forms.RichTextBox anotherTextBox;
  }
}