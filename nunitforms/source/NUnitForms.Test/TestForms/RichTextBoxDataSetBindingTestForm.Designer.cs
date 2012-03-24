namespace NUnit.Extensions.Forms.TestApplications
{
  partial class RichTextBoxDataSetBindingTestForm
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
      this.myRichTextBox = new System.Windows.Forms.RichTextBox();
      this.btnView = new System.Windows.Forms.Button();
      this.myDataSet = new System.Data.DataSet();
      ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // myRichTextBox
      // 
      this.myRichTextBox.Location = new System.Drawing.Point(66, 71);
      this.myRichTextBox.Name = "myRichTextBox";
      this.myRichTextBox.Size = new System.Drawing.Size(135, 33);
      this.myRichTextBox.TabIndex = 0;
      this.myRichTextBox.Text = "";
      // 
      // btnView
      // 
      this.btnView.Location = new System.Drawing.Point(86, 133);
      this.btnView.Name = "btnView";
      this.btnView.Size = new System.Drawing.Size(75, 23);
      this.btnView.TabIndex = 1;
      this.btnView.Text = "View";
      this.btnView.UseVisualStyleBackColor = true;
      this.btnView.Click += new System.EventHandler(this.btnView_Click);
      // 
      // myDataSet
      // 
      this.myDataSet.DataSetName = "NewDataSet";
      // 
      // RichTextBoxDataSetBindingTestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.btnView);
      this.Controls.Add(this.myRichTextBox);
      this.Name = "RichTextBoxDataSetBindingTestForm";
      this.Text = "RichTextBoxtDataSetBindingTestForm";
      this.Load += new System.EventHandler(this.RichTextBoxtDataSetBindingTestForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox myRichTextBox;
    private System.Windows.Forms.Button btnView;
    private System.Data.DataSet myDataSet;
  }
}