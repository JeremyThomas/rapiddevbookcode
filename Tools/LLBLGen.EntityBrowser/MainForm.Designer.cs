namespace LLBLGen.EntityBrowser
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
      System.Windows.Forms.Label linqMetaDataAssemblyPathLabel;
      System.Windows.Forms.Label adapterAssemblyPathLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonAddConnection = new System.Windows.Forms.ToolStripButton();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.panel1 = new System.Windows.Forms.Panel();
      this.adapterAssemblyPathTextBox = new System.Windows.Forms.TextBox();
      this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.linqMetaDataAssemblyPathTextBox = new System.Windows.Forms.TextBox();
      linqMetaDataAssemblyPathLabel = new System.Windows.Forms.Label();
      adapterAssemblyPathLabel = new System.Windows.Forms.Label();
      this.toolStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // linqMetaDataAssemblyPathLabel
      // 
      linqMetaDataAssemblyPathLabel.AutoSize = true;
      linqMetaDataAssemblyPathLabel.Location = new System.Drawing.Point(3, 17);
      linqMetaDataAssemblyPathLabel.Name = "linqMetaDataAssemblyPathLabel";
      linqMetaDataAssemblyPathLabel.Size = new System.Drawing.Size(155, 13);
      linqMetaDataAssemblyPathLabel.TabIndex = 0;
      linqMetaDataAssemblyPathLabel.Text = "Linq Meta Data Assembly Path:";
      // 
      // adapterAssemblyPathLabel
      // 
      adapterAssemblyPathLabel.AutoSize = true;
      adapterAssemblyPathLabel.Location = new System.Drawing.Point(3, 39);
      adapterAssemblyPathLabel.Name = "adapterAssemblyPathLabel";
      adapterAssemblyPathLabel.Size = new System.Drawing.Size(119, 13);
      adapterAssemblyPathLabel.TabIndex = 2;
      adapterAssemblyPathLabel.Text = "Adapter Assembly Path:";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddConnection});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(714, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButtonAddConnection
      // 
      this.toolStripButtonAddConnection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddConnection.Image")));
      this.toolStripButtonAddConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonAddConnection.Name = "toolStripButtonAddConnection";
      this.toolStripButtonAddConnection.Size = new System.Drawing.Size(49, 22);
      this.toolStripButtonAddConnection.Text = "Add";
      this.toolStripButtonAddConnection.Click += new System.EventHandler(this.toolStripButtonAddConnection_Click);
      // 
      // tabControl
      // 
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 93);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(714, 495);
      this.tabControl.TabIndex = 1;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(adapterAssemblyPathLabel);
      this.panel1.Controls.Add(this.adapterAssemblyPathTextBox);
      this.panel1.Controls.Add(linqMetaDataAssemblyPathLabel);
      this.panel1.Controls.Add(this.linqMetaDataAssemblyPathTextBox);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 25);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(714, 68);
      this.panel1.TabIndex = 2;
      // 
      // adapterAssemblyPathTextBox
      // 
      this.adapterAssemblyPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.adapterAssemblyPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "AdapterAssemblyPath", true));
      this.adapterAssemblyPathTextBox.Location = new System.Drawing.Point(128, 36);
      this.adapterAssemblyPathTextBox.Name = "adapterAssemblyPathTextBox";
      this.adapterAssemblyPathTextBox.Size = new System.Drawing.Size(586, 20);
      this.adapterAssemblyPathTextBox.TabIndex = 3;
      // 
      // settingsBindingSource
      // 
      this.settingsBindingSource.DataSource = typeof(System.Configuration.ApplicationSettingsBase);
      // 
      // linqMetaDataAssemblyPathTextBox
      // 
      this.linqMetaDataAssemblyPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.linqMetaDataAssemblyPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "LinqMetaDataAssemblyPath", true));
      this.linqMetaDataAssemblyPathTextBox.Location = new System.Drawing.Point(164, 10);
      this.linqMetaDataAssemblyPathTextBox.Name = "linqMetaDataAssemblyPathTextBox";
      this.linqMetaDataAssemblyPathTextBox.Size = new System.Drawing.Size(550, 20);
      this.linqMetaDataAssemblyPathTextBox.TabIndex = 1;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(714, 588);
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.toolStrip1);
      this.Name = "MainForm";
      this.Text = "Data Browser";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButtonAddConnection;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox adapterAssemblyPathTextBox;
    private System.Windows.Forms.BindingSource settingsBindingSource;
    private System.Windows.Forms.TextBox linqMetaDataAssemblyPathTextBox;
  }
}

