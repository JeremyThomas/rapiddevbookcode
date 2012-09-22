namespace AW.Win
{
  partial class FrmTrace
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrace));
      this.textBoxTrace = new System.Windows.Forms.TextBox();
      this.comboBoxDQETraceLevel = new System.Windows.Forms.ComboBox();
      this.buttonClearTrace = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.checkBoxSQLTrace = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.comboBoxLinqTraceLevel = new System.Windows.Forms.ComboBox();
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
      this.textBoxTrace.Size = new System.Drawing.Size(773, 427);
      this.textBoxTrace.TabIndex = 1;
      this.textBoxTrace.TextChanged += new System.EventHandler(this.textBoxTrace_TextChanged);
      // 
      // comboBoxDQETraceLevel
      // 
      this.comboBoxDQETraceLevel.FormattingEnabled = true;
      this.comboBoxDQETraceLevel.Location = new System.Drawing.Point(108, 10);
      this.comboBoxDQETraceLevel.Name = "comboBoxDQETraceLevel";
      this.comboBoxDQETraceLevel.Size = new System.Drawing.Size(153, 21);
      this.comboBoxDQETraceLevel.TabIndex = 0;
      this.comboBoxDQETraceLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxTraceLevel_SelectedIndexChanged);
      // 
      // buttonClearTrace
      // 
      this.buttonClearTrace.Location = new System.Drawing.Point(600, 11);
      this.buttonClearTrace.Name = "buttonClearTrace";
      this.buttonClearTrace.Size = new System.Drawing.Size(74, 23);
      this.buttonClearTrace.TabIndex = 1;
      this.buttonClearTrace.Text = "Clear Trace";
      this.buttonClearTrace.UseVisualStyleBackColor = true;
      this.buttonClearTrace.Click += new System.EventHandler(this.buttonClearTrace_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.checkBoxSQLTrace);
      this.splitContainer1.Panel1.Controls.Add(this.label2);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      this.splitContainer1.Panel1.Controls.Add(this.comboBoxLinqTraceLevel);
      this.splitContainer1.Panel1.Controls.Add(this.buttonClearTrace);
      this.splitContainer1.Panel1.Controls.Add(this.comboBoxDQETraceLevel);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.textBoxTrace);
      this.splitContainer1.Size = new System.Drawing.Size(773, 467);
      this.splitContainer1.SplitterDistance = 36;
      this.splitContainer1.TabIndex = 3;
      // 
      // checkBoxSQLTrace
      // 
      this.checkBoxSQLTrace.AutoSize = true;
      this.checkBoxSQLTrace.Checked = global::AW.Win.Properties.Settings.Default.SQLTrace;
      this.checkBoxSQLTrace.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Win.Properties.Settings.Default, "SQLTrace", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxSQLTrace.Location = new System.Drawing.Point(519, 15);
      this.checkBoxSQLTrace.Name = "checkBoxSQLTrace";
      this.checkBoxSQLTrace.Size = new System.Drawing.Size(75, 17);
      this.checkBoxSQLTrace.TabIndex = 5;
      this.checkBoxSQLTrace.Text = "SQLTrace";
      this.checkBoxSQLTrace.UseVisualStyleBackColor = true;
      this.checkBoxSQLTrace.CheckedChanged += new System.EventHandler(this.checkBoxSQLTrace_CheckedChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(267, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(87, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Linq Trace Level";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(90, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "DQE Trace Level";
      // 
      // comboBoxLinqTraceLevel
      // 
      this.comboBoxLinqTraceLevel.FormattingEnabled = true;
      this.comboBoxLinqTraceLevel.Location = new System.Drawing.Point(360, 12);
      this.comboBoxLinqTraceLevel.Name = "comboBoxLinqTraceLevel";
      this.comboBoxLinqTraceLevel.Size = new System.Drawing.Size(153, 21);
      this.comboBoxLinqTraceLevel.TabIndex = 2;
      this.comboBoxLinqTraceLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLinqTraceLevel_SelectedIndexChanged);
      // 
      // FrmTrace
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(773, 467);
      this.Controls.Add(this.splitContainer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmTrace";
      this.Tag = "True";
      this.Text = "Trace form";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrace_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTrace_FormClosed);
      this.Load += new System.EventHandler(this.FrmTrace_Load);
      this.Shown += new System.EventHandler(this.frmTrace_Shown);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBoxDQETraceLevel;
    private System.Windows.Forms.TextBox textBoxTrace;
    private System.Windows.Forms.Button buttonClearTrace;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ComboBox comboBoxLinqTraceLevel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxSQLTrace;
  }
}