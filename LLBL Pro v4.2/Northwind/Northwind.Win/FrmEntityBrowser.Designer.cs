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
      System.Windows.Forms.Label cacheDurationInSecondsLabel;
      System.Windows.Forms.Label prefixDelimiterLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntityBrowser));
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonRemote = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonShowEmployeeHierarchyInTreeByID = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonShowEmployeeHierarchyInTreePostProcessing = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonShowEmployeeHierarchyInTree = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonCustomerGroupedByCountry = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButtonFilterByDiscontinued = new System.Windows.Forms.ToolStripButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cacheDurationInSecondsNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.prefixDelimiterTextBox = new System.Windows.Forms.TextBox();
      this.useSchemaCheckBox = new System.Windows.Forms.CheckBox();
      this.useContextCheckBox = new System.Windows.Forms.CheckBox();
      this.ensureFilteringEnabledCheckBox = new System.Windows.Forms.CheckBox();
      this.usrCntrlEntityBrowser1 = new AW.Winforms.Helpers.LLBL.UsrCntrlEntityBrowser();
      cacheDurationInSecondsLabel = new System.Windows.Forms.Label();
      prefixDelimiterLabel = new System.Windows.Forms.Label();
      this.toolStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cacheDurationInSecondsNumericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // cacheDurationInSecondsLabel
      // 
      cacheDurationInSecondsLabel.AutoSize = true;
      cacheDurationInSecondsLabel.Location = new System.Drawing.Point(440, 8);
      cacheDurationInSecondsLabel.Name = "cacheDurationInSecondsLabel";
      cacheDurationInSecondsLabel.Size = new System.Drawing.Size(141, 13);
      cacheDurationInSecondsLabel.TabIndex = 6;
      cacheDurationInSecondsLabel.Text = "Cache Duration In Seconds:";
      // 
      // prefixDelimiterLabel
      // 
      prefixDelimiterLabel.AutoSize = true;
      prefixDelimiterLabel.Location = new System.Drawing.Point(311, 8);
      prefixDelimiterLabel.Name = "prefixDelimiterLabel";
      prefixDelimiterLabel.Size = new System.Drawing.Size(79, 13);
      prefixDelimiterLabel.TabIndex = 8;
      prefixDelimiterLabel.Text = "Prefix Delimiter:";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRemote,
            this.toolStripButtonShowEmployeeHierarchyInTreeByID,
            this.toolStripButtonShowEmployeeHierarchyInTreePostProcessing,
            this.toolStripButtonShowEmployeeHierarchyInTree,
            this.toolStripButtonCustomerGroupedByCountry,
            this.toolStripButton1,
            this.toolStripButtonFilterByDiscontinued});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(1080, 25);
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
      // toolStripButtonShowEmployeeHierarchyInTreePostProcessing
      // 
      this.toolStripButtonShowEmployeeHierarchyInTreePostProcessing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonShowEmployeeHierarchyInTreePostProcessing.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowEmployeeHierarchyInTreePostProcessing.Image")));
      this.toolStripButtonShowEmployeeHierarchyInTreePostProcessing.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonShowEmployeeHierarchyInTreePostProcessing.Name = "toolStripButtonShowEmployeeHierarchyInTreePostProcessing";
      this.toolStripButtonShowEmployeeHierarchyInTreePostProcessing.Size = new System.Drawing.Size(270, 22);
      this.toolStripButtonShowEmployeeHierarchyInTreePostProcessing.Text = "Show Employee Hierarchy In Tree PostProcessing";
      this.toolStripButtonShowEmployeeHierarchyInTreePostProcessing.Click += new System.EventHandler(this.toolStripButtonShowEmployeeHierarchyInTreePostProcessing_Click);
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
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton1.Text = "toolStripButton1";
      // 
      // toolStripButtonFilterByDiscontinued
      // 
      this.toolStripButtonFilterByDiscontinued.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonFilterByDiscontinued.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFilterByDiscontinued.Image")));
      this.toolStripButtonFilterByDiscontinued.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonFilterByDiscontinued.Name = "toolStripButtonFilterByDiscontinued";
      this.toolStripButtonFilterByDiscontinued.Size = new System.Drawing.Size(120, 22);
      this.toolStripButtonFilterByDiscontinued.Text = "FilterByDiscontinued";
      this.toolStripButtonFilterByDiscontinued.Click += new System.EventHandler(this.toolStripButtonFilterByDiscontinued_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.cacheDurationInSecondsNumericUpDown);
      this.panel1.Controls.Add(prefixDelimiterLabel);
      this.panel1.Controls.Add(this.prefixDelimiterTextBox);
      this.panel1.Controls.Add(cacheDurationInSecondsLabel);
      this.panel1.Controls.Add(this.useSchemaCheckBox);
      this.panel1.Controls.Add(this.useContextCheckBox);
      this.panel1.Controls.Add(this.ensureFilteringEnabledCheckBox);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 25);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1080, 29);
      this.panel1.TabIndex = 2;
      // 
      // cacheDurationInSecondsNumericUpDown
      // 
      this.cacheDurationInSecondsNumericUpDown.Location = new System.Drawing.Point(596, 5);
      this.cacheDurationInSecondsNumericUpDown.Name = "cacheDurationInSecondsNumericUpDown";
      this.cacheDurationInSecondsNumericUpDown.Size = new System.Drawing.Size(49, 20);
      this.cacheDurationInSecondsNumericUpDown.TabIndex = 10;
      this.cacheDurationInSecondsNumericUpDown.ValueChanged += new System.EventHandler(this.cacheDurationInSecondsNumericUpDown_ValueChanged);
      // 
      // prefixDelimiterTextBox
      // 
      this.prefixDelimiterTextBox.Location = new System.Drawing.Point(396, 6);
      this.prefixDelimiterTextBox.Name = "prefixDelimiterTextBox";
      this.prefixDelimiterTextBox.Size = new System.Drawing.Size(38, 20);
      this.prefixDelimiterTextBox.TabIndex = 9;
      // 
      // useSchemaCheckBox
      // 
      this.useSchemaCheckBox.Location = new System.Drawing.Point(223, 3);
      this.useSchemaCheckBox.Name = "useSchemaCheckBox";
      this.useSchemaCheckBox.Size = new System.Drawing.Size(96, 24);
      this.useSchemaCheckBox.TabIndex = 5;
      this.useSchemaCheckBox.Text = "Use Schema:";
      this.useSchemaCheckBox.UseVisualStyleBackColor = true;
      // 
      // useContextCheckBox
      // 
      this.useContextCheckBox.Location = new System.Drawing.Point(143, 3);
      this.useContextCheckBox.Name = "useContextCheckBox";
      this.useContextCheckBox.Size = new System.Drawing.Size(88, 24);
      this.useContextCheckBox.TabIndex = 3;
      this.useContextCheckBox.Text = "Use Context:";
      this.useContextCheckBox.UseVisualStyleBackColor = true;
      this.useContextCheckBox.CheckedChanged += new System.EventHandler(this.useContextCheckBox_CheckedChanged);
      // 
      // ensureFilteringEnabledCheckBox
      // 
      this.ensureFilteringEnabledCheckBox.Location = new System.Drawing.Point(4, 3);
      this.ensureFilteringEnabledCheckBox.Name = "ensureFilteringEnabledCheckBox";
      this.ensureFilteringEnabledCheckBox.Size = new System.Drawing.Size(148, 24);
      this.ensureFilteringEnabledCheckBox.TabIndex = 1;
      this.ensureFilteringEnabledCheckBox.Text = "Ensure Filtering Enabled:";
      this.ensureFilteringEnabledCheckBox.UseVisualStyleBackColor = true;
      // 
      // usrCntrlEntityBrowser1
      // 
      this.usrCntrlEntityBrowser1.CacheDurationInSeconds = 30;
      this.usrCntrlEntityBrowser1.ContextToUse = null;
      this.usrCntrlEntityBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.usrCntrlEntityBrowser1.EnsureFilteringEnabled = true;
      this.usrCntrlEntityBrowser1.Location = new System.Drawing.Point(0, 54);
      this.usrCntrlEntityBrowser1.Name = "usrCntrlEntityBrowser1";
      this.usrCntrlEntityBrowser1.PageSize = ((ushort)(15));
      this.usrCntrlEntityBrowser1.Size = new System.Drawing.Size(1080, 525);
      this.usrCntrlEntityBrowser1.TabIndex = 0;
      // 
      // FrmEntityBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1080, 579);
      this.Controls.Add(this.usrCntrlEntityBrowser1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.toolStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmEntityBrowser";
      this.Text = "Northwind Data Browser";
      this.Load += new System.EventHandler(this.FrmEntityBrowser_Load);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cacheDurationInSecondsNumericUpDown)).EndInit();
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
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox prefixDelimiterTextBox;
    private System.Windows.Forms.CheckBox useSchemaCheckBox;
    private System.Windows.Forms.CheckBox useContextCheckBox;
    private System.Windows.Forms.CheckBox ensureFilteringEnabledCheckBox;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.NumericUpDown cacheDurationInSecondsNumericUpDown;
    private System.Windows.Forms.ToolStripButton toolStripButtonShowEmployeeHierarchyInTreePostProcessing;
    private System.Windows.Forms.ToolStripButton toolStripButtonFilterByDiscontinued;
  }
}

