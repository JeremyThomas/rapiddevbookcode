namespace NUnit.Extensions.Forms.TestApplications
{
  partial class ToolStripComboBoxTestForm
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
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
      this.toolStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
      this.toolStrip1.Location = new System.Drawing.Point(0, 25);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(292, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripComboBox1
      // 
      this.toolStripComboBox1.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five"});
      this.toolStripComboBox1.Name = "toolStripComboBox1";
      this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
      this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(54, 117);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(292, 25);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // toolStripComboBox2
      // 
      this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.toolStripComboBox2.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three"});
      this.toolStripComboBox2.Name = "toolStripComboBox2";
      this.toolStripComboBox2.Size = new System.Drawing.Size(121, 21);
      // 
      // ToolStripComboBoxTestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "ToolStripComboBoxTestForm";
      this.Text = "ToolStripComboBoxTestForm";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
  }
}