namespace SD.LLBLGen.Pro.Examples.WCF.Host
{
    partial class WCFServiceManager
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
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._serviceState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.PaleGreen;
            this.start.Location = new System.Drawing.Point(128, 70);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(110, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start WCF Service";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.LightCoral;
            this.stop.Location = new System.Drawing.Point(334, 70);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(108, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop WCF Service";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Service state:";
            // 
            // _serviceState
            // 
            this._serviceState.AutoSize = true;
            this._serviceState.Location = new System.Drawing.Point(204, 124);
            this._serviceState.Name = "_serviceState";
            this._serviceState.Size = new System.Drawing.Size(0, 13);
            this._serviceState.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 172);
            this.Controls.Add(this._serviceState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "WCF Service Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _serviceState;
    }
}

