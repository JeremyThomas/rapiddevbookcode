namespace AW.Winforms.Helpers
{
	partial class FrmPersistantLocation
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
			this.SuspendLayout();
			// 
			// FrmPersistantLocation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Name = "FrmPersistantLocation";
			this.Text = "FrmPersistantLocation";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPersistantLocation_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPersistantLocation_FormClosed);
			this.Load += new System.EventHandler(this.FrmPersistantLocation_Load);
			this.ResumeLayout(false);

		}

		#endregion
	}
}