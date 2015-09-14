namespace Northwind.Win
{
  partial class FrmEntityBrowser
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntityBrowser));
      this.usrCntrlEntityBrowser1 = new AW.Winforms.Helpers.LLBL.UsrCntrlEntityBrowser();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonRemote = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonShowEmployeeHierarchyInTreeByID = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonShowEmployeeHierarchyInTree = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonCustomerGroupedByCountry = new System.Windows.Forms.ToolStripButton();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // usrCntrlEntityBrowser1
      // 
      this.usrCntrlEntityBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.usrCntrlEntityBrowser1.Location = new System.Drawing.Point(0, 25);
      this.usrCntrlEntityBrowser1.Name = "usrCntrlEntityBrowser1";
      this.usrCntrlEntityBrowser1.Size = new System.Drawing.Size(708, 554);
      this.usrCntrlEntityBrowser1.TabIndex = 0;
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRemote,
            this.toolStripButtonShowEmployeeHierarchyInTreeByID,
            this.toolStripButtonShowEmployeeHierarchyInTree,
            this.toolStripButtonCustomerGroupedByCountry});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(708, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButtonRemote
      // 
      this.toolStripButtonRemote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonRemote.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemote.Image")));
      this.toolStripButtonRemote.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonRemote.Name = "toolStripButtonRemote";
      this.toolStripButtonRemote.Size = new System.Drawing.Size(52, 22);
      this.toolStripButtonRemote.Text = "Remote";
      this.toolStripButtonRemote.Click += new System.EventHandler(this.toolStripButtonRemote_Click);
      // 
      // toolStripButtonShowEmployeeHierarchyInTreeByID
      // 
      this.toolStripButtonShowEmployeeHierarchyInTreeByID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonShowEmployeeHierarchyInTreeByID.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowEmployeeHierarchyInTreeByID.Image")));
      this.toolStripButtonShowEmployeeHierarchyInTreeByID.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonShowEmployeeHierarchyInTreeByID.Name = "toolStripButtonShowEmployeeHierarchyInTreeByID";
      this.toolStripButtonShowEmployeeHierarchyInTreeByID.Size = new System.Drawing.Size(217, 22);
      this.toolStripButtonShowEmployeeHierarchyInTreeByID.Text = "Show Employee Hierarchy In Tree By ID";
      this.toolStripButtonShowEmployeeHierarchyInTreeByID.Click += new System.EventHandler(this.toolStripButtonShowEmployeeHierarchyInTreeByID_Click);
      // 
      // toolStripButtonShowEmployeeHierarchyInTree
      // 
      this.toolStripButtonShowEmployeeHierarchyInTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonShowEmployeeHierarchyInTree.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowEmployeeHierarchyInTree.Image")));
      this.toolStripButtonShowEmployeeHierarchyInTree.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonShowEmployeeHierarchyInTree.Name = "toolStripButtonShowEmployeeHierarchyInTree";
      this.toolStripButtonShowEmployeeHierarchyInTree.Size = new System.Drawing.Size(187, 22);
      this.toolStripButtonShowEmployeeHierarchyInTree.Text = "Show Employee Hierarchy In Tree";
      this.toolStripButtonShowEmployeeHierarchyInTree.Click += new System.EventHandler(this.toolStripButtonShowEmployeeHierarchyInTree_Click);
      // 
      // toolStripButtonCustomerGroupedByCountry
      // 
      this.toolStripButtonCustomerGroupedByCountry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonCustomerGroupedByCountry.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCustomerGroupedByCountry.Image")));
      this.toolStripButtonCustomerGroupedByCountry.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonCustomerGroupedByCountry.Name = "toolStripButtonCustomerGroupedByCountry";
      this.toolStripButtonCustomerGroupedByCountry.Size = new System.Drawing.Size(165, 22);
      this.toolStripButtonCustomerGroupedByCountry.Text = "CustomerGroupedByCountry";
      this.toolStripButtonCustomerGroupedByCountry.Click += new System.EventHandler(this.toolStripButtonCustomerGroupedByCountry_Click);
      // 
      // FrmEntityBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(708, 579);
      this.Controls.Add(this.usrCntrlEntityBrowser1);
      this.Controls.Add(this.toolStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmEntityBrowser";
      this.Text = "Northwind Data Browser";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private AW.Winforms.Helpers.LLBL.UsrCntrlEntityBrowser usrCntrlEntityBrowser1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButtonRemote;
    private System.Windows.Forms.ToolStripButton toolStripButtonShowEmployeeHierarchyInTree;
    private System.Windows.Forms.ToolStripButton toolStripButtonShowEmployeeHierarchyInTreeByID;
    private System.Windows.Forms.ToolStripButton toolStripButtonCustomerGroupedByCountry;
  }
}

