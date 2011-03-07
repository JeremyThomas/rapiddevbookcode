using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms.TestApplications
{
	/// <summary>
	/// Form for use in testing <see cref="AmbiguousNameException"/>.
	/// </summary>
	public partial class AmbiguousNameForm
	{
		private ButtonControl myControl1;

		private ButtonControl myControl2;

		private Label myFirstLabel;

		private Label mySecondLabel;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
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
			this.myControl2 = new ButtonControl();
			this.myControl1 = new ButtonControl();
			this.myFirstLabel = new Label();
			this.mySecondLabel = new Label();
			this.SuspendLayout();
			// 
			// myControl2
			// 
			this.myControl2.Location = new Point(8, 56);
			this.myControl2.Name = "myControl2";
			this.myControl2.Size = new Size(96, 40);
			this.myControl2.TabIndex = 2;
			this.myControl2.SuperClick += new EventHandler(this.onSuperClick2);
			// 
			// myControl1
			// 
			this.myControl1.Location = new Point(8, 8);
			this.myControl1.Name = "myControl1";
			this.myControl1.Size = new Size(96, 40);
			this.myControl1.TabIndex = 1;
			this.myControl1.SuperClick += new EventHandler(this.onSuperClick1);
			// 
			// myFirstLabel
			// 
			this.myFirstLabel.Location = new Point(120, 16);
			this.myFirstLabel.Name = "myFirstLabel";
			this.myFirstLabel.TabIndex = 3;
			this.myFirstLabel.Text = "0";
			// 
			// mySecondLabel
			// 
			this.mySecondLabel.Location = new Point(120, 72);
			this.mySecondLabel.Name = "mySecondLabel";
			this.mySecondLabel.TabIndex = 4;
			this.mySecondLabel.Text = "0";
			// 
			// AmbiguousNameForm
			// 
			this.AutoScaleDimensions = new SizeF(5, 13);
			this.ClientSize = new Size(232, 109);
			this.Controls.Add(this.mySecondLabel);
			this.Controls.Add(this.myFirstLabel);
			this.Controls.Add(this.myControl1);
			this.Controls.Add(this.myControl2);
			this.Name = "AmbiguousNameForm";
			this.Text = "AmbiguousNameForm";
			this.ResumeLayout(false);
		}

		#endregion
	}
}