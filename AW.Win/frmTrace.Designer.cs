namespace AW.Win
{
  partial class frmTrace
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
      this.textBoxTrace = new System.Windows.Forms.TextBox();
      this.comboBoxTraceLevel = new System.Windows.Forms.ComboBox();
      this.buttonClearTrace = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxTrace
      // 
      this.textBoxTrace.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxTrace.Location = new System.Drawing.Point(0, 0);
      this.textBoxTrace.Multiline = true;
      this.textBoxTrace.Name = "textBoxTrace";
      this.textBoxTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxTrace.Size = new System.Drawing.Size(982, 524);
      this.textBoxTrace.TabIndex = 1;
      // 
      // comboBoxTraceLevel
      // 
      this.comboBoxTraceLevel.FormattingEnabled = true;
      this.comboBoxTraceLevel.Location = new System.Drawing.Point(12, 12);
      this.comboBoxTraceLevel.Name = "comboBoxTraceLevel";
      this.comboBoxTraceLevel.Size = new System.Drawing.Size(153, 21);
      this.comboBoxTraceLevel.TabIndex = 0;
      this.comboBoxTraceLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxTraceLevel_SelectedIndexChanged);
      // 
      // buttonClearTrace
      // 
      this.buttonClearTrace.Location = new System.Drawing.Point(213, 12);
      this.buttonClearTrace.Name = "buttonClearTrace";
      this.buttonClearTrace.Size = new System.Drawing.Size(90, 23);
      this.buttonClearTrace.TabIndex = 1;
      this.buttonClearTrace.Text = "Clear Trace";
      this.buttonClearTrace.UseVisualStyleBackColor = true;
      this.buttonClearTrace.Click += new System.EventHandler(this.buttonClearTrace_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.buttonClearTrace);
      this.splitContainer1.Panel1.Controls.Add(this.comboBoxTraceLevel);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.textBoxTrace);
      this.splitContainer1.Size = new System.Drawing.Size(982, 573);
      this.splitContainer1.SplitterDistance = 45;
      this.splitContainer1.TabIndex = 3;
      // 
      // frmTrace
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(982, 573);
      this.Controls.Add(this.splitContainer1);
      this.Name = "frmTrace";
      this.Text = "FormTrace";
      this.Load += new System.EventHandler(this.FrmTrace_Load);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTrace_FormClosed);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrace_FormClosing);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBoxTraceLevel;
    private System.Windows.Forms.TextBox textBoxTrace;
    private System.Windows.Forms.Button buttonClearTrace;
    private System.Windows.Forms.SplitContainer splitContainer1;
  }
}