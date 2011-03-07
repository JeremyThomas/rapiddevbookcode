namespace NUnit.Extensions.Forms.Test.TestForms
{
    partial class ToolStripContainerTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolStripContainerTestForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb = new System.Windows.Forms.ToolStripButton();
            this.tsl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tb1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.b1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(438, 389);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(438, 414);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tb1
            // 
            this.tb1.AcceptsReturn = true;
            this.tb1.Location = new System.Drawing.Point(194, 163);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(55, 20);
            this.tb1.TabIndex = 1;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(106, 146);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(58, 52);
            this.b1.TabIndex = 0;
            this.b1.Text = "button1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb,
            this.tsl});
            this.toolStrip1.Location = new System.Drawing.Point(87, 66);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(152, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb
            // 
            this.tsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb.Image = ((System.Drawing.Image)(resources.GetObject("tsb.Image")));
            this.tsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb.Name = "tsb";
            this.tsb.Size = new System.Drawing.Size(23, 22);
            this.tsb.Text = "toolStripButton1";
            this.tsb.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsl
            // 
            this.tsl.Name = "tsl";
            this.tsl.Size = new System.Drawing.Size(86, 22);
            this.tsl.Text = "toolStripLabel1";
            // 
            // ToolStripContainerTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 414);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "ToolStripContainerTestForm";
            this.Text = "ToolStripContainerTestForm";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb;
        private System.Windows.Forms.ToolStripLabel tsl;
    }
}