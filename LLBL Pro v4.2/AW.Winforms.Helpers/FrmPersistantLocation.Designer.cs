﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AW.Winforms.Helpers
{
	partial class FrmPersistantLocation
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(284, 262);
			this.Name = "FrmPersistantLocation";
			this.Text = "Form Persistant Location";
			this.ResumeLayout(false);

		}

		#endregion
	}
}