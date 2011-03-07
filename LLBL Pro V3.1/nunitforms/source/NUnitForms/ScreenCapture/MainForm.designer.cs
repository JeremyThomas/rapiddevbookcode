namespace NUnit.Extensions.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.buttonPrimaryScreen = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonAllFormats = new System.Windows.Forms.Button();
            this.buttonAllScreens = new System.Windows.Forms.Button();
            this.buttonVirtualScreen = new System.Windows.Forms.Button();
            this.buttonWorkingArea = new System.Windows.Forms.Button();
            this.buttonPrintScreen = new System.Windows.Forms.Button();
            this.groupBoxProcess = new System.Windows.Forms.GroupBox();
            this.listBoxProcesses = new System.Windows.Forms.ListBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            this.groupBoxProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrimaryScreen
            // 
            this.buttonPrimaryScreen.Location = new System.Drawing.Point(6, 19);
            this.buttonPrimaryScreen.Name = "buttonPrimaryScreen";
            this.buttonPrimaryScreen.Size = new System.Drawing.Size(189, 23);
            this.buttonPrimaryScreen.TabIndex = 0;
            this.buttonPrimaryScreen.Text = "Primary Screen";
            this.buttonPrimaryScreen.UseVisualStyleBackColor = true;
            this.buttonPrimaryScreen.Click += new System.EventHandler(this.buttonPrimaryScreen_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonAllFormats);
            this.groupBox.Controls.Add(this.buttonAllScreens);
            this.groupBox.Controls.Add(this.buttonVirtualScreen);
            this.groupBox.Controls.Add(this.buttonWorkingArea);
            this.groupBox.Controls.Add(this.buttonPrimaryScreen);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(201, 182);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Select what should be captured";
            // 
            // buttonAllFormats
            // 
            this.buttonAllFormats.Location = new System.Drawing.Point(6, 148);
            this.buttonAllFormats.Name = "buttonAllFormats";
            this.buttonAllFormats.Size = new System.Drawing.Size(189, 23);
            this.buttonAllFormats.TabIndex = 4;
            this.buttonAllFormats.Text = "All File Formats";
            this.buttonAllFormats.UseVisualStyleBackColor = true;
            this.buttonAllFormats.Click += new System.EventHandler(this.buttonAllFormats_Click);
            // 
            // buttonAllScreens
            // 
            this.buttonAllScreens.Location = new System.Drawing.Point(6, 106);
            this.buttonAllScreens.Name = "buttonAllScreens";
            this.buttonAllScreens.Size = new System.Drawing.Size(189, 23);
            this.buttonAllScreens.TabIndex = 3;
            this.buttonAllScreens.Text = "All Screens";
            this.buttonAllScreens.UseVisualStyleBackColor = true;
            this.buttonAllScreens.Click += new System.EventHandler(this.buttonAllScreens_Click);
            // 
            // buttonVirtualScreen
            // 
            this.buttonVirtualScreen.Location = new System.Drawing.Point(6, 77);
            this.buttonVirtualScreen.Name = "buttonVirtualScreen";
            this.buttonVirtualScreen.Size = new System.Drawing.Size(189, 23);
            this.buttonVirtualScreen.TabIndex = 2;
            this.buttonVirtualScreen.Text = "Virtual Screen";
            this.buttonVirtualScreen.UseVisualStyleBackColor = true;
            this.buttonVirtualScreen.Click += new System.EventHandler(this.buttonVirtualScreen_Click);
            // 
            // buttonWorkingArea
            // 
            this.buttonWorkingArea.Location = new System.Drawing.Point(6, 48);
            this.buttonWorkingArea.Name = "buttonWorkingArea";
            this.buttonWorkingArea.Size = new System.Drawing.Size(189, 23);
            this.buttonWorkingArea.TabIndex = 1;
            this.buttonWorkingArea.Text = "Working Area";
            this.buttonWorkingArea.UseVisualStyleBackColor = true;
            this.buttonWorkingArea.Click += new System.EventHandler(this.buttonWorkingArea_Click);
            // 
            // buttonPrintScreen
            // 
            this.buttonPrintScreen.Location = new System.Drawing.Point(18, 209);
            this.buttonPrintScreen.Name = "buttonPrintScreen";
            this.buttonPrintScreen.Size = new System.Drawing.Size(189, 23);
            this.buttonPrintScreen.TabIndex = 2;
            this.buttonPrintScreen.Text = "Print (use any capture before)";
            this.buttonPrintScreen.UseVisualStyleBackColor = true;
            this.buttonPrintScreen.Click += new System.EventHandler(this.buttonPrintScreen_Click);
            // 
            // groupBoxProcess
            // 
            this.groupBoxProcess.Controls.Add(this.listBoxProcesses);
            this.groupBoxProcess.Controls.Add(this.buttonProcess);
            this.groupBoxProcess.Location = new System.Drawing.Point(228, 12);
            this.groupBoxProcess.Name = "groupBoxProcess";
            this.groupBoxProcess.Size = new System.Drawing.Size(201, 231);
            this.groupBoxProcess.TabIndex = 1;
            this.groupBoxProcess.TabStop = false;
            this.groupBoxProcess.Text = "Capture from a process";
            // 
            // listBoxProcesses
            // 
            this.listBoxProcesses.FormattingEnabled = true;
            this.listBoxProcesses.Location = new System.Drawing.Point(6, 19);
            this.listBoxProcesses.Name = "listBoxProcesses";
            this.listBoxProcesses.Size = new System.Drawing.Size(189, 173);
            this.listBoxProcesses.Sorted = true;
            this.listBoxProcesses.TabIndex = 0;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(6, 197);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(189, 23);
            this.buttonProcess.TabIndex = 1;
            this.buttonProcess.Text = "Capture selected";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 195);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxProcess);
            this.Controls.Add(this.buttonPrintScreen);
            this.Controls.Add(this.groupBox);
            this.Name = "MainForm";
            this.Text = "Demo of screen capture";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBoxProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonPrimaryScreen;
		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.Button buttonWorkingArea;
		private System.Windows.Forms.Button buttonVirtualScreen;
		private System.Windows.Forms.Button buttonAllScreens;
		private System.Windows.Forms.Button buttonAllFormats;
		private System.Windows.Forms.Button buttonPrintScreen;
		private System.Windows.Forms.GroupBox groupBoxProcess;
		private System.Windows.Forms.Button buttonProcess;
		private System.Windows.Forms.ListBox listBoxProcesses;
        private System.Windows.Forms.PictureBox pictureBox1;
	}
}

