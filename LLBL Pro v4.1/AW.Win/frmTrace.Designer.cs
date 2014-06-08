namespace AW.Win
{
  sealed partial class FrmTrace
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label queryExecutionLevelLabel;
      System.Windows.Forms.Label persistenceExecutionTraceLevelLabel;
      AW.Win.Properties.Settings settings1 = new AW.Win.Properties.Settings();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrace));
      this.textBoxTrace = new System.Windows.Forms.TextBox();
      this.comboBoxDQETraceLevel = new System.Windows.Forms.ComboBox();
      this.frmTraceBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.traceLevelEnumerableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
      this.buttonClearTrace = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.persistenceExecutionTraceLevelComboBox = new System.Windows.Forms.ComboBox();
      this.traceLevelEnumerableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
      this.queryExecutionLevelComboBox = new System.Windows.Forms.ComboBox();
      this.traceLevelEnumerableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.checkBoxSQLTrace = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.comboBoxLinqTraceLevel = new System.Windows.Forms.ComboBox();
      this.traceLevelEnumerableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      queryExecutionLevelLabel = new System.Windows.Forms.Label();
      persistenceExecutionTraceLevelLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.frmTraceBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource3)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource2)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // queryExecutionLevelLabel
      // 
      queryExecutionLevelLabel.AutoSize = true;
      queryExecutionLevelLabel.Location = new System.Drawing.Point(242, 16);
      queryExecutionLevelLabel.Name = "queryExecutionLevelLabel";
      queryExecutionLevelLabel.Size = new System.Drawing.Size(88, 13);
      queryExecutionLevelLabel.TabIndex = 6;
      queryExecutionLevelLabel.Text = "Query Execution:";
      this.toolTip1.SetToolTip(queryExecutionLevelLabel, "TraceHelper.QueryExecutionSwitch");
      // 
      // persistenceExecutionTraceLevelLabel
      // 
      persistenceExecutionTraceLevelLabel.AutoSize = true;
      persistenceExecutionTraceLevelLabel.Location = new System.Drawing.Point(412, 18);
      persistenceExecutionTraceLevelLabel.Name = "persistenceExecutionTraceLevelLabel";
      persistenceExecutionTraceLevelLabel.Size = new System.Drawing.Size(115, 13);
      persistenceExecutionTraceLevelLabel.TabIndex = 8;
      persistenceExecutionTraceLevelLabel.Text = "Persistence Execution:";
      this.toolTip1.SetToolTip(persistenceExecutionTraceLevelLabel, "TraceHelper.PersistenceExecutionSwitch");
      // 
      // textBoxTrace
      // 
      this.textBoxTrace.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxTrace.Location = new System.Drawing.Point(0, 0);
      this.textBoxTrace.Multiline = true;
      this.textBoxTrace.Name = "textBoxTrace";
      this.textBoxTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxTrace.Size = new System.Drawing.Size(793, 264);
      this.textBoxTrace.TabIndex = 1;
      // 
      // comboBoxDQETraceLevel
      // 
      this.comboBoxDQETraceLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmTraceBindingSource, "DQETraceLevel", true));
      this.comboBoxDQETraceLevel.DataSource = this.traceLevelEnumerableBindingSource3;
      this.comboBoxDQETraceLevel.FormattingEnabled = true;
      this.comboBoxDQETraceLevel.Location = new System.Drawing.Point(48, 13);
      this.comboBoxDQETraceLevel.Name = "comboBoxDQETraceLevel";
      this.comboBoxDQETraceLevel.Size = new System.Drawing.Size(70, 21);
      this.comboBoxDQETraceLevel.TabIndex = 0;
      this.toolTip1.SetToolTip(this.comboBoxDQETraceLevel, "Dynamic Query Engine tracing");
      // 
      // frmTraceBindingSource
      // 
      this.frmTraceBindingSource.DataSource = typeof(AW.Win.FrmTrace);
      // 
      // traceLevelEnumerableBindingSource3
      // 
      this.traceLevelEnumerableBindingSource3.DataMember = "TraceLevelEnumerable";
      this.traceLevelEnumerableBindingSource3.DataSource = this.frmTraceBindingSource;
      // 
      // buttonClearTrace
      // 
      this.buttonClearTrace.Location = new System.Drawing.Point(702, 17);
      this.buttonClearTrace.Name = "buttonClearTrace";
      this.buttonClearTrace.Size = new System.Drawing.Size(74, 23);
      this.buttonClearTrace.TabIndex = 1;
      this.buttonClearTrace.Text = "Clear Trace";
      this.buttonClearTrace.UseVisualStyleBackColor = true;
      this.buttonClearTrace.Click += new System.EventHandler(this.buttonClearTrace_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.AutoScroll = true;
      this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
      this.splitContainer1.Panel1.Controls.Add(this.checkBoxSQLTrace);
      this.splitContainer1.Panel1.Controls.Add(this.buttonClearTrace);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.textBoxTrace);
      this.splitContainer1.Size = new System.Drawing.Size(793, 318);
      this.splitContainer1.TabIndex = 3;
      // 
      // persistenceExecutionTraceLevelComboBox
      // 
      this.persistenceExecutionTraceLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmTraceBindingSource, "PersistenceExecutionTraceLevel", true));
      this.persistenceExecutionTraceLevelComboBox.DataSource = this.traceLevelEnumerableBindingSource4;
      this.persistenceExecutionTraceLevelComboBox.FormattingEnabled = true;
      this.persistenceExecutionTraceLevelComboBox.Location = new System.Drawing.Point(533, 13);
      this.persistenceExecutionTraceLevelComboBox.Name = "persistenceExecutionTraceLevelComboBox";
      this.persistenceExecutionTraceLevelComboBox.Size = new System.Drawing.Size(70, 21);
      this.persistenceExecutionTraceLevelComboBox.TabIndex = 9;
      this.toolTip1.SetToolTip(this.persistenceExecutionTraceLevelComboBox, "TraceHelper.PersistenceExecutionSwitch");
      // 
      // traceLevelEnumerableBindingSource4
      // 
      this.traceLevelEnumerableBindingSource4.DataMember = "TraceLevelEnumerable";
      this.traceLevelEnumerableBindingSource4.DataSource = this.frmTraceBindingSource;
      // 
      // queryExecutionLevelComboBox
      // 
      this.queryExecutionLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmTraceBindingSource, "QueryExecutionTraceLevel", true));
      this.queryExecutionLevelComboBox.DataSource = this.traceLevelEnumerableBindingSource1;
      this.queryExecutionLevelComboBox.FormattingEnabled = true;
      this.queryExecutionLevelComboBox.Location = new System.Drawing.Point(336, 13);
      this.queryExecutionLevelComboBox.Name = "queryExecutionLevelComboBox";
      this.queryExecutionLevelComboBox.Size = new System.Drawing.Size(70, 21);
      this.queryExecutionLevelComboBox.TabIndex = 7;
      this.toolTip1.SetToolTip(this.queryExecutionLevelComboBox, "TraceHelper.QueryExecutionSwitch");
      // 
      // traceLevelEnumerableBindingSource1
      // 
      this.traceLevelEnumerableBindingSource1.DataMember = "TraceLevelEnumerable";
      this.traceLevelEnumerableBindingSource1.DataSource = this.frmTraceBindingSource;
      // 
      // checkBoxSQLTrace
      // 
      this.checkBoxSQLTrace.AutoSize = true;
      settings1.City = "";
      settings1.Countries = null;
      settings1.Country = "";
      settings1.CustomersSizeLocation = new System.Drawing.Rectangle(0, 0, 0, 0);
      settings1.DateFrom = new System.DateTime(2008, 8, 24, 21, 34, 1, 0);
      settings1.DateTo = new System.DateTime(2008, 8, 24, 21, 34, 1, 0);
      settings1.EntityFieldColumns = null;
      settings1.EntityViewerSizeLocation = new System.Drawing.Rectangle(0, 0, 0, 0);
      settings1.FilterOnFromDate = true;
      settings1.FilterOnToDate = false;
      settings1.FirstName = "";
      settings1.FrmEntityViewerSplitterDistance = 289;
      settings1.LastName = "";
      settings1.LinqTraceLevel = System.Diagnostics.TraceLevel.Off;
      settings1.MainWindowSizeLocation = new System.Drawing.Rectangle(0, 0, 0, 0);
      settings1.MainWindowState = System.Windows.Forms.FormWindowState.Normal;
      settings1.NumRows = new decimal(new int[] {
            100,
            0,
            0,
            0});
      settings1.OpenTraceWindosOnStart = false;
      settings1.OpenWindows = null;
      settings1.OrderEditSizeLocation = new System.Drawing.Rectangle(0, 0, 0, 0);
      settings1.OrderID = "";
      settings1.OrderSearchSizeLocation = new System.Drawing.Rectangle(0, 0, 0, 0);
      settings1.OrganizationSizeLocation = new System.Drawing.Rectangle(0, 0, 0, 0);
      settings1.OrganizationStructureSizeLocation = new System.Drawing.Rectangle(0, 0, 0, 0);
      settings1.PersistenceExecutionTraceLevel = System.Diagnostics.TraceLevel.Off;
      settings1.Prefetch = true;
      settings1.QueryExecutionTraceLevel = System.Diagnostics.TraceLevel.Off;
      settings1.QueryFilesToReopen = null;
      settings1.ReopenWindows = false;
      settings1.SettingQueryRunnerSizeAndLocation = new System.Drawing.Rectangle(0, 0, 0, 0);
      settings1.SettingsKey = "";
      settings1.SQLTrace = false;
      settings1.State = "";
      settings1.TraceLevel = System.Diagnostics.TraceLevel.Off;
      settings1.TraceSizeLocation = new System.Drawing.Rectangle(0, 0, 0, 0);
      settings1.TraceWindowSizeLocation = new System.Drawing.Rectangle(0, 0, 0, 0);
      settings1.UseLinq = false;
      settings1.VacationSizeLocation = new System.Drawing.Rectangle(0, 0, 0, 0);
      settings1.Zip = "";
      this.checkBoxSQLTrace.Checked = settings1.SQLTrace;
      this.checkBoxSQLTrace.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "SQLTrace", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxSQLTrace.Location = new System.Drawing.Point(621, 21);
      this.checkBoxSQLTrace.Name = "checkBoxSQLTrace";
      this.checkBoxSQLTrace.Size = new System.Drawing.Size(75, 17);
      this.checkBoxSQLTrace.TabIndex = 5;
      this.checkBoxSQLTrace.Text = "SQLTrace";
      this.toolTip1.SetToolTip(this.checkBoxSQLTrace, "CommonDaoBase.SQLTraceEvent");
      this.checkBoxSQLTrace.UseVisualStyleBackColor = true;
      this.checkBoxSQLTrace.CheckedChanged += new System.EventHandler(this.checkBoxSQLTrace_CheckedChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(130, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Linq:";
      this.toolTip1.SetToolTip(this.label2, "Linq to LLBLGen Pro tracing");
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "DQE:";
      this.toolTip1.SetToolTip(this.label1, "Dynamic Query Engine tracing");
      // 
      // comboBoxLinqTraceLevel
      // 
      this.comboBoxLinqTraceLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmTraceBindingSource, "LinqTraceLevel", true));
      this.comboBoxLinqTraceLevel.DataSource = this.traceLevelEnumerableBindingSource2;
      this.comboBoxLinqTraceLevel.FormattingEnabled = true;
      this.comboBoxLinqTraceLevel.Location = new System.Drawing.Point(166, 13);
      this.comboBoxLinqTraceLevel.Name = "comboBoxLinqTraceLevel";
      this.comboBoxLinqTraceLevel.Size = new System.Drawing.Size(70, 21);
      this.comboBoxLinqTraceLevel.TabIndex = 2;
      this.toolTip1.SetToolTip(this.comboBoxLinqTraceLevel, "Linq to LLBLGen Pro tracing");
      // 
      // traceLevelEnumerableBindingSource2
      // 
      this.traceLevelEnumerableBindingSource2.DataMember = "TraceLevelEnumerable";
      this.traceLevelEnumerableBindingSource2.DataSource = this.frmTraceBindingSource;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.comboBoxDQETraceLevel);
      this.groupBox1.Controls.Add(this.comboBoxLinqTraceLevel);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.queryExecutionLevelComboBox);
      this.groupBox1.Controls.Add(queryExecutionLevelLabel);
      this.groupBox1.Controls.Add(this.persistenceExecutionTraceLevelComboBox);
      this.groupBox1.Controls.Add(persistenceExecutionTraceLevelLabel);
      this.groupBox1.Location = new System.Drawing.Point(3, 7);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(612, 39);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Trace Levels";
      // 
      // FrmTrace
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(793, 318);
      this.Controls.Add(this.splitContainer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmTrace";
      this.Tag = "True";
      this.Text = "Trace form";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTrace_FormClosed);
      this.Load += new System.EventHandler(this.FrmTrace_Load);
      this.Shown += new System.EventHandler(this.frmTrace_Shown);
      ((System.ComponentModel.ISupportInitialize)(this.frmTraceBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource3)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource2)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBoxDQETraceLevel;
    private System.Windows.Forms.TextBox textBoxTrace;
    private System.Windows.Forms.Button buttonClearTrace;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ComboBox comboBoxLinqTraceLevel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox checkBoxSQLTrace;
    private System.Windows.Forms.BindingSource frmTraceBindingSource;
    private System.Windows.Forms.ComboBox queryExecutionLevelComboBox;
    private System.Windows.Forms.BindingSource traceLevelEnumerableBindingSource1;
    private System.Windows.Forms.BindingSource traceLevelEnumerableBindingSource2;
    private System.Windows.Forms.BindingSource traceLevelEnumerableBindingSource3;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.ComboBox persistenceExecutionTraceLevelComboBox;
    private System.Windows.Forms.BindingSource traceLevelEnumerableBindingSource4;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}