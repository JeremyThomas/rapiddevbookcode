namespace AW.Winforms.Helpers
{
	partial class FrmThreePanelBase
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
			this.splitContainerVertical = new System.Windows.Forms.SplitContainer();
			this.splitContainerHorizontal = new System.Windows.Forms.SplitContainer();
			this.splitContainerVertical.Panel2.SuspendLayout();
			this.splitContainerVertical.SuspendLayout();
			this.splitContainerHorizontal.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainerVertical
			// 
			this.splitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerVertical.Location = new System.Drawing.Point(0, 0);
			this.splitContainerVertical.Name = "splitContainerVertical";
			// 
			// splitContainerVertical.Panel1
			// 
			this.splitContainerVertical.Panel1.SizeChanged += new System.EventHandler(this.splitContainerVertical_SizeChanged);
			// 
			// splitContainerVertical.Panel2
			// 
			this.splitContainerVertical.Panel2.Controls.Add(this.splitContainerHorizontal);
			this.splitContainerVertical.Size = new System.Drawing.Size(675, 597);
			this.splitContainerVertical.SplitterDistance = 225;
			this.splitContainerVertical.TabIndex = 0;
			this.splitContainerVertical.SizeChanged += new System.EventHandler(this.splitContainerVertical_SizeChanged);
			this.splitContainerVertical.DoubleClick += new System.EventHandler(this.splitContainerVertical_DoubleClick);
			// 
			// splitContainerHorizontal
			// 
			this.splitContainerHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerHorizontal.Location = new System.Drawing.Point(0, 0);
			this.splitContainerHorizontal.Name = "splitContainerHorizontal";
			this.splitContainerHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.splitContainerHorizontal.Size = new System.Drawing.Size(446, 597);
			this.splitContainerHorizontal.SplitterDistance = 400;
			this.splitContainerHorizontal.TabIndex = 0;
			// 
			// FrmThreePanelBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 597);
			this.Controls.Add(this.splitContainerVertical);
			this.Name = "FrmThreePanelBase";
			this.Text = "FrmThreePanelBase";
			this.splitContainerVertical.Panel2.ResumeLayout(false);
			this.splitContainerVertical.ResumeLayout(false);
			this.splitContainerHorizontal.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.SplitContainer splitContainerVertical;
		protected System.Windows.Forms.SplitContainer splitContainerHorizontal;

	}
}