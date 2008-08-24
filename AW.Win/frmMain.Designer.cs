namespace AW.Win
{
    partial class frmMain
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
          this.menuStrip1 = new System.Windows.Forms.MenuStrip();
          this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.organizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.vacationBonusUtilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.traceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.menuStrip1.SuspendLayout();
          this.SuspendLayout();
          // 
          // menuStrip1
          // 
          this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.windowToolStripMenuItem});
          this.menuStrip1.Location = new System.Drawing.Point(0, 0);
          this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
          this.menuStrip1.Name = "menuStrip1";
          this.menuStrip1.Size = new System.Drawing.Size(395, 24);
          this.menuStrip1.TabIndex = 1;
          this.menuStrip1.Text = "menuStrip1";
          // 
          // fileToolStripMenuItem
          // 
          this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
          this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
          this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
          this.fileToolStripMenuItem.Text = "&File";
          // 
          // exitToolStripMenuItem
          // 
          this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
          this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
          this.exitToolStripMenuItem.Text = "E&xit";
          this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
          // 
          // searchToolStripMenuItem
          // 
          this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem});
          this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
          this.searchToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
          this.searchToolStripMenuItem.Text = "&Search";
          // 
          // ordersToolStripMenuItem
          // 
          this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
          this.ordersToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
          this.ordersToolStripMenuItem.Text = "&Orders ...";
          this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
          // 
          // reportsToolStripMenuItem
          // 
          this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.organizationToolStripMenuItem});
          this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
          this.reportsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
          this.reportsToolStripMenuItem.Text = "&Reports";
          // 
          // customersToolStripMenuItem
          // 
          this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
          this.customersToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
          this.customersToolStripMenuItem.Text = "&Customers";
          this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
          // 
          // organizationToolStripMenuItem
          // 
          this.organizationToolStripMenuItem.Name = "organizationToolStripMenuItem";
          this.organizationToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
          this.organizationToolStripMenuItem.Text = "&Organization";
          this.organizationToolStripMenuItem.Click += new System.EventHandler(this.organizationToolStripMenuItem_Click);
          // 
          // utilitiesToolStripMenuItem
          // 
          this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacationBonusUtilityToolStripMenuItem,
            this.traceToolStripMenuItem});
          this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
          this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
          this.utilitiesToolStripMenuItem.Text = "&Utilities";
          // 
          // vacationBonusUtilityToolStripMenuItem
          // 
          this.vacationBonusUtilityToolStripMenuItem.Name = "vacationBonusUtilityToolStripMenuItem";
          this.vacationBonusUtilityToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
          this.vacationBonusUtilityToolStripMenuItem.Text = "Vacation Bonus Utility ...";
          this.vacationBonusUtilityToolStripMenuItem.Click += new System.EventHandler(this.vacationBonusUtilityToolStripMenuItem_Click);
          // 
          // windowToolStripMenuItem
          // 
          this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
          this.windowToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
          this.windowToolStripMenuItem.Text = "&Window";
          // 
          // traceToolStripMenuItem
          // 
          this.traceToolStripMenuItem.Name = "traceToolStripMenuItem";
          this.traceToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
          this.traceToolStripMenuItem.Text = "Trace...";
          this.traceToolStripMenuItem.Click += new System.EventHandler(this.traceToolStripMenuItem_Click);
          // 
          // frmMain
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(395, 273);
          this.Controls.Add(this.menuStrip1);
          this.IsMdiContainer = true;
          this.MainMenuStrip = this.menuStrip1;
          this.Name = "frmMain";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "Adventure Works";
          this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
          this.Load += new System.EventHandler(this.frmMain_Load);
          this.menuStrip1.ResumeLayout(false);
          this.menuStrip1.PerformLayout();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacationBonusUtilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traceToolStripMenuItem;
    }
}