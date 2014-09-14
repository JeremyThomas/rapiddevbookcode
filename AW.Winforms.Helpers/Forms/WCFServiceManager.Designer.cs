namespace AW.Winforms.Helpers.Forms
{
    partial class WcfServiceManager
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WcfServiceManager));
      this.ToggleOnOff = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this._serviceState = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tableLayoutPanelMetaData = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ToggleOnOff
      // 
      this.ToggleOnOff.BackColor = System.Drawing.Color.PaleGreen;
      this.ToggleOnOff.Location = new System.Drawing.Point(22, 17);
      this.ToggleOnOff.Name = "ToggleOnOff";
      this.ToggleOnOff.Size = new System.Drawing.Size(110, 23);
      this.ToggleOnOff.TabIndex = 0;
      this.ToggleOnOff.Text = "Start WCF Service";
      this.ToggleOnOff.UseVisualStyleBackColor = false;
      this.ToggleOnOff.Click += new System.EventHandler(this.start_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(152, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Service state:";
      // 
      // _serviceState
      // 
      this._serviceState.AutoSize = true;
      this._serviceState.Location = new System.Drawing.Point(230, 22);
      this._serviceState.Name = "_serviceState";
      this._serviceState.Size = new System.Drawing.Size(0, 13);
      this._serviceState.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(19, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(130, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Click to view MEX/WSDL";
      // 
      // tableLayoutPanelMetaData
      // 
      this.tableLayoutPanelMetaData.AutoSize = true;
      this.tableLayoutPanelMetaData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanelMetaData.ColumnCount = 1;
      this.tableLayoutPanelMetaData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanelMetaData.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanelMetaData.Location = new System.Drawing.Point(0, 100);
      this.tableLayoutPanelMetaData.Margin = new System.Windows.Forms.Padding(10);
      this.tableLayoutPanelMetaData.Name = "tableLayoutPanelMetaData";
      this.tableLayoutPanelMetaData.RowCount = 1;
      this.tableLayoutPanelMetaData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelMetaData.Size = new System.Drawing.Size(299, 124);
      this.tableLayoutPanelMetaData.TabIndex = 6;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.ToggleOnOff);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this._serviceState);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(299, 100);
      this.panel1.TabIndex = 7;
      // 
      // WcfServiceManager
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(299, 224);
      this.Controls.Add(this.tableLayoutPanelMetaData);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "WcfServiceManager";
      this.Text = "WCF Service Manager";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToggleOnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _serviceState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMetaData;
        private System.Windows.Forms.Panel panel1;
    }
}

