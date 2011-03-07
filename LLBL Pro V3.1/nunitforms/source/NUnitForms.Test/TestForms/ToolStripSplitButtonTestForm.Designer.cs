namespace NUnit.Extensions.Forms.TestApplications
{
  partial class ToolStripSplitButtonTestForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolStripSplitButtonTestForm));
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
      this.oneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.twoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.threeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(292, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripSplitButton1
      // 
      this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneToolStripMenuItem,
            this.twoToolStripMenuItem,
            this.threeToolStripMenuItem});
      this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
      this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripSplitButton1.Name = "toolStripSplitButton1";
      this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
      this.toolStripSplitButton1.Text = "toolStripSplitButton1";
      this.toolStripSplitButton1.Click += new System.EventHandler(this.toolStripSplitButton1_Click);
      // 
      // oneToolStripMenuItem
      // 
      this.oneToolStripMenuItem.Name = "oneToolStripMenuItem";
      this.oneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.oneToolStripMenuItem.Text = "One";
      // 
      // twoToolStripMenuItem
      // 
      this.twoToolStripMenuItem.Name = "twoToolStripMenuItem";
      this.twoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.twoToolStripMenuItem.Text = "Two";
      // 
      // threeToolStripMenuItem
      // 
      this.threeToolStripMenuItem.Name = "threeToolStripMenuItem";
      this.threeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.threeToolStripMenuItem.Text = "Three";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(119, 143);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // ToolStripSplitButtonTestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.toolStrip1);
      this.Name = "ToolStripSplitButtonTestForm";
      this.Text = "ToolStripSplitButtonTestForm";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
    private System.Windows.Forms.ToolStripMenuItem oneToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem twoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem threeToolStripMenuItem;
    private System.Windows.Forms.Label label1;
  }
}