namespace AW.Winforms.Helpers
{
    partial class frmVacationBonus
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
          this.nudUnsalariedHours = new System.Windows.Forms.NumericUpDown();
          this.nudSalariedHours = new System.Windows.Forms.NumericUpDown();
          this.lblResult = new System.Windows.Forms.Label();
          this.label4 = new System.Windows.Forms.Label();
          this.btnAdd = new System.Windows.Forms.Button();
          this.label3 = new System.Windows.Forms.Label();
          this.label2 = new System.Windows.Forms.Label();
          this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
          this.label1 = new System.Windows.Forms.Label();
          ((System.ComponentModel.ISupportInitialize)(this.nudUnsalariedHours)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.nudSalariedHours)).BeginInit();
          this.SuspendLayout();
          // 
          // nudUnsalariedHours
          // 
          this.nudUnsalariedHours.Location = new System.Drawing.Point(160, 102);
          this.nudUnsalariedHours.Name = "nudUnsalariedHours";
          this.nudUnsalariedHours.Size = new System.Drawing.Size(120, 20);
          this.nudUnsalariedHours.TabIndex = 19;
          // 
          // nudSalariedHours
          // 
          this.nudSalariedHours.Location = new System.Drawing.Point(160, 57);
          this.nudSalariedHours.Name = "nudSalariedHours";
          this.nudSalariedHours.Size = new System.Drawing.Size(120, 20);
          this.nudSalariedHours.TabIndex = 18;
          // 
          // lblResult
          // 
          this.lblResult.AutoSize = true;
          this.lblResult.Location = new System.Drawing.Point(233, 186);
          this.lblResult.Name = "lblResult";
          this.lblResult.Size = new System.Drawing.Size(47, 13);
          this.lblResult.TabIndex = 17;
          this.lblResult.Text = "lblResult";
          // 
          // label4
          // 
          this.label4.AutoSize = true;
          this.label4.Location = new System.Drawing.Point(12, 186);
          this.label4.Name = "label4";
          this.label4.Size = new System.Drawing.Size(37, 13);
          this.label4.TabIndex = 16;
          this.label4.Text = "Result";
          // 
          // btnAdd
          // 
          this.btnAdd.Location = new System.Drawing.Point(205, 141);
          this.btnAdd.Name = "btnAdd";
          this.btnAdd.Size = new System.Drawing.Size(75, 23);
          this.btnAdd.TabIndex = 15;
          this.btnAdd.Text = "Add Hours";
          this.btnAdd.UseVisualStyleBackColor = true;
          this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
          // 
          // label3
          // 
          this.label3.Location = new System.Drawing.Point(12, 104);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(150, 45);
          this.label3.TabIndex = 14;
          this.label3.Text = "Unsalaried Bonus Hours";
          // 
          // label2
          // 
          this.label2.Location = new System.Drawing.Point(12, 57);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(130, 40);
          this.label2.TabIndex = 13;
          this.label2.Text = "Salaried Bonus Hours";
          // 
          // dtpHireDate
          // 
          this.dtpHireDate.Location = new System.Drawing.Point(80, 12);
          this.dtpHireDate.Name = "dtpHireDate";
          this.dtpHireDate.Size = new System.Drawing.Size(200, 20);
          this.dtpHireDate.TabIndex = 12;
          // 
          // label1
          // 
          this.label1.Location = new System.Drawing.Point(12, 14);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(62, 42);
          this.label1.TabIndex = 11;
          this.label1.Text = "Hired After Date";
          // 
          // frmVacationBonus
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(294, 208);
          this.Controls.Add(this.nudUnsalariedHours);
          this.Controls.Add(this.nudSalariedHours);
          this.Controls.Add(this.lblResult);
          this.Controls.Add(this.label4);
          this.Controls.Add(this.btnAdd);
          this.Controls.Add(this.label3);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.dtpHireDate);
          this.Controls.Add(this.label1);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
          this.Name = "frmVacationBonus";
          this.ShowInTaskbar = false;
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "Vacation Bonus Utility";
          this.Load += new System.EventHandler(this.frmVacationBonus_Load);
          this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVacationBonus_FormClosing);
          ((System.ComponentModel.ISupportInitialize)(this.nudUnsalariedHours)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.nudSalariedHours)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudUnsalariedHours;
        private System.Windows.Forms.NumericUpDown nudSalariedHours;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label label1;
    }
}