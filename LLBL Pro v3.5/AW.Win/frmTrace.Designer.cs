namespace AW.Win
{
  partial class FrmTrace
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
      AW.Win.Properties.Settings settings1 = new AW.Win.Properties.Settings();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrace));
      this.textBoxTrace = new System.Windows.Forms.TextBox();
      this.comboBoxDQETraceLevel = new System.Windows.Forms.ComboBox();
      this.traceLevelEnumerableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
      this.frmTraceBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.buttonClearTrace = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.queryExecutionLevelComboBox = new System.Windows.Forms.ComboBox();
      this.traceLevelEnumerableBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.checkBoxSQLTrace = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.comboBoxLinqTraceLevel = new System.Windows.Forms.ComboBox();
      this.traceLevelEnumerableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      queryExecutionLevelLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.frmTraceBindingSource)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource2)).BeginInit();
      this.SuspendLayout();
      // 
      // queryExecutionLevelLabel
      // 
      queryExecutionLevelLabel.AutoSize = true;
      queryExecutionLevelLabel.Location = new System.Drawing.Point(530, 16);
      queryExecutionLevelLabel.Name = "queryExecutionLevelLabel";
      queryExecutionLevelLabel.Size = new System.Drawing.Size(117, 13);
      queryExecutionLevelLabel.TabIndex = 6;
      queryExecutionLevelLabel.Text = "Query Execution Level:";
      // 
      // textBoxTrace
      // 
      this.textBoxTrace.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxTrace.Location = new System.Drawing.Point(0, 0);
      this.textBoxTrace.Multiline = true;
      this.textBoxTrace.Name = "textBoxTrace";
      this.textBoxTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxTrace.Size = new System.Drawing.Size(1036, 415);
      this.textBoxTrace.TabIndex = 1;
      // 
      // comboBoxDQETraceLevel
      // 
      this.comboBoxDQETraceLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmTraceBindingSource, "DQETraceLevel", true));
      this.comboBoxDQETraceLevel.DataSource = this.traceLevelEnumerableBindingSource3;
      this.comboBoxDQETraceLevel.FormattingEnabled = true;
      this.comboBoxDQETraceLevel.Location = new System.Drawing.Point(108, 10);
      this.comboBoxDQETraceLevel.Name = "comboBoxDQETraceLevel";
      this.comboBoxDQETraceLevel.Size = new System.Drawing.Size(153, 21);
      this.comboBoxDQETraceLevel.TabIndex = 0;
      this.toolTip1.SetToolTip(this.comboBoxDQETraceLevel, "Dynamic Query Engine tracing");
      // 
      // traceLevelEnumerableBindingSource3
      // 
      this.traceLevelEnumerableBindingSource3.DataMember = "TraceLevelEnumerable";
      this.traceLevelEnumerableBindingSource3.DataSource = this.frmTraceBindingSource;
      // 
      // frmTraceBindingSource
      // 
      this.frmTraceBindingSource.DataSource = typeof(AW.Win.FrmTrace);
      // 
      // buttonClearTrace
      // 
      this.buttonClearTrace.Location = new System.Drawing.Point(859, 12);
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
      this.splitContainer1.Panel1.Controls.Add(queryExecutionLevelLabel);
      this.splitContainer1.Panel1.Controls.Add(this.queryExecutionLevelComboBox);
      this.splitContainer1.Panel1.Controls.Add(this.checkBoxSQLTrace);
      this.splitContainer1.Panel1.Controls.Add(this.label2);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      this.splitContainer1.Panel1.Controls.Add(this.comboBoxLinqTraceLevel);
      this.splitContainer1.Panel1.Controls.Add(this.buttonClearTrace);
      this.splitContainer1.Panel1.Controls.Add(this.comboBoxDQETraceLevel);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.textBoxTrace);
      this.splitContainer1.Size = new System.Drawing.Size(1036, 455);
      this.splitContainer1.SplitterDistance = 36;
      this.splitContainer1.TabIndex = 3;
      // 
      // queryExecutionLevelComboBox
      // 
      this.queryExecutionLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmTraceBindingSource, "QueryExecutionTraceLevel", true));
      this.queryExecutionLevelComboBox.DataSource = this.traceLevelEnumerableBindingSource;
      this.queryExecutionLevelComboBox.FormattingEnabled = true;
      this.queryExecutionLevelComboBox.Location = new System.Drawing.Point(653, 13);
      this.queryExecutionLevelComboBox.Name = "queryExecutionLevelComboBox";
      this.queryExecutionLevelComboBox.Size = new System.Drawing.Size(121, 21);
      this.queryExecutionLevelComboBox.TabIndex = 7;
      // 
      // traceLevelEnumerableBindingSource
      // 
      this.traceLevelEnumerableBindingSource.DataMember = "TraceLevelEnumerable";
      this.traceLevelEnumerableBindingSource.DataSource = this.frmTraceBindingSource;
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
      this.checkBoxSQLTrace.Location = new System.Drawing.Point(778, 16);
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
      this.label2.Location = new System.Drawing.Point(267, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(87, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Linq Trace Level";
      this.toolTip1.SetToolTip(this.label2, "Linq to LLBLGen Pro tracing");
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(90, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "DQE Trace Level";
      this.toolTip1.SetToolTip(this.label1, "Dynamic Query Engine tracing");
      // 
      // comboBoxLinqTraceLevel
      // 
      this.comboBoxLinqTraceLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmTraceBindingSource, "LinqTraceLevel", true));
      this.comboBoxLinqTraceLevel.DataSource = this.traceLevelEnumerableBindingSource2;
      this.comboBoxLinqTraceLevel.FormattingEnabled = true;
      this.comboBoxLinqTraceLevel.Location = new System.Drawing.Point(360, 12);
      this.comboBoxLinqTraceLevel.Name = "comboBoxLinqTraceLevel";
      this.comboBoxLinqTraceLevel.Size = new System.Drawing.Size(153, 21);
      this.comboBoxLinqTraceLevel.TabIndex = 2;
      this.toolTip1.SetToolTip(this.comboBoxLinqTraceLevel, "Linq to LLBLGen Pro tracing");
      // 
      // traceLevelEnumerableBindingSource2
      // 
      this.traceLevelEnumerableBindingSource2.DataMember = "TraceLevelEnumerable";
      this.traceLevelEnumerableBindingSource2.DataSource = this.frmTraceBindingSource;
      // 
      // FrmTrace
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1036, 455);
      this.Controls.Add(this.splitContainer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmTrace";
      this.Tag = "True";
      this.Text = "Trace form";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTrace_FormClosed);
      this.Load += new System.EventHandler(this.FrmTrace_Load);
      this.Shown += new System.EventHandler(this.frmTrace_Shown);
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.frmTraceBindingSource)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.traceLevelEnumerableBindingSource2)).EndInit();
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
    private System.Windows.Forms.BindingSource traceLevelEnumerableBindingSource;
    private System.Windows.Forms.BindingSource traceLevelEnumerableBindingSource2;
    private System.Windows.Forms.BindingSource traceLevelEnumerableBindingSource3;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}