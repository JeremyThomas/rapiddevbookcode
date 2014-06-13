namespace NUnit.Extensions.Forms.Test.TestForms
{
	partial class ToborTestForm
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
			this.textBoxA = new System.Windows.Forms.TextBox();
			this.textBoxB = new System.Windows.Forms.TextBox();
			this.buttonCalc = new System.Windows.Forms.Button();
			this.labelResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxA
			// 
			this.textBoxA.Location = new System.Drawing.Point(99, 12);
			this.textBoxA.Name = "textBoxA";
			this.textBoxA.Size = new System.Drawing.Size(101, 20);
			this.textBoxA.TabIndex = 0;
			// 
			// textBoxB
			// 
			this.textBoxB.Location = new System.Drawing.Point(99, 38);
			this.textBoxB.Name = "textBoxB";
			this.textBoxB.Size = new System.Drawing.Size(101, 20);
			this.textBoxB.TabIndex = 1;
			// 
			// buttonCalc
			// 
			this.buttonCalc.Location = new System.Drawing.Point(17, 61);
			this.buttonCalc.Name = "buttonCalc";
			this.buttonCalc.Size = new System.Drawing.Size(76, 23);
			this.buttonCalc.TabIndex = 2;
			this.buttonCalc.Text = "Calculate";
			this.buttonCalc.UseVisualStyleBackColor = true;
			this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
			// 
			// labelResult
			// 
			this.labelResult.Location = new System.Drawing.Point(99, 61);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(101, 20);
			this.labelResult.TabIndex = 3;
			this.labelResult.Text = "<Result>";
			this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ToborTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 110);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.buttonCalc);
			this.Controls.Add(this.textBoxB);
			this.Controls.Add(this.textBoxA);
			this.Name = "ToborTestForm";
			this.Text = "ToborTestForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxA;
		private System.Windows.Forms.TextBox textBoxB;
		private System.Windows.Forms.Button buttonCalc;
		private System.Windows.Forms.Label labelResult;
	}
}