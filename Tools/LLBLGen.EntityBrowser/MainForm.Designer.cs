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
      this.contextMenuStripTabControl = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.adapterAssemblyPathTextBox = new System.Windows.Forms.TextBox();
      this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.linqMetaDataAssemblyPathTextBox = new System.Windows.Forms.TextBox();
      this.contextMenuStripTabPage = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addConnectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
      linqMetaDataAssemblyPathLabel = new System.Windows.Forms.Label();
      adapterAssemblyPathLabel = new System.Windows.Forms.Label();
      this.toolStrip1.SuspendLayout();
      this.contextMenuStripTabControl.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
      this.contextMenuStripTabPage.SuspendLayout();
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
            this.toolStripButtonAddConnection,
            this.toolStripButtonLoad});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(714, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButtonAddConnection
      // 
      this.toolStripButtonAddConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonAddConnection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddConnection.Image")));
      this.toolStripButtonAddConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonAddConnection.Name = "toolStripButtonAddConnection";
      this.toolStripButtonAddConnection.Size = new System.Drawing.Size(33, 22);
      this.toolStripButtonAddConnection.Text = "Add";
      this.toolStripButtonAddConnection.Click += new System.EventHandler(this.toolStripButtonAddConnection_Click);
      // 
      // tabControl
      // 
      this.tabControl.ContextMenuStrip = this.contextMenuStripTabControl;
      this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl.Location = new System.Drawing.Point(0, 93);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(714, 495);
      this.tabControl.TabIndex = 1;
      this.tabControl.MouseLeave += new System.EventHandler(this.tabControl_MouseLeave);
      this.tabControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseMove);
      // 
      // contextMenuStripTabControl
      // 
      this.contextMenuStripTabControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConnectionToolStripMenuItem});
      this.contextMenuStripTabControl.Name = "contextMenuStripTabControl";
      this.contextMenuStripTabControl.Size = new System.Drawing.Size(162, 26);
      // 
      // addConnectionToolStripMenuItem
      // 
      this.addConnectionToolStripMenuItem.Name = "addConnectionToolStripMenuItem";
      this.addConnectionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.addConnectionToolStripMenuItem.Text = "Add Connection";
      this.addConnectionToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonAddConnection_Click);
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
      // contextMenuStripTabPage
      // 
      this.contextMenuStripTabPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConnectionToolStripMenuItem1,
            this.removeToolStripMenuItem,
            this.editConnectionToolStripMenuItem,
            this.renameToolStripMenuItem});
      this.contextMenuStripTabPage.Name = "contextMenuStripTabPage";
      this.contextMenuStripTabPage.Size = new System.Drawing.Size(162, 92);
      // 
      // addConnectionToolStripMenuItem1
      // 
      this.addConnectionToolStripMenuItem1.Name = "addConnectionToolStripMenuItem1";
      this.addConnectionToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
      this.addConnectionToolStripMenuItem1.Text = "Add Connection";
      this.addConnectionToolStripMenuItem1.Click += new System.EventHandler(this.toolStripButtonAddConnection_Click);
      // 
      // removeToolStripMenuItem
      // 
      this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
      this.removeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.removeToolStripMenuItem.Text = "Remove";
      this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
      // 
      // editConnectionToolStripMenuItem
      // 
      this.editConnectionToolStripMenuItem.Name = "editConnectionToolStripMenuItem";
      this.editConnectionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.editConnectionToolStripMenuItem.Text = "Edit Connection";
      this.editConnectionToolStripMenuItem.Click += new System.EventHandler(this.editConnectionToolStripMenuItem_Click);
      // 
      // renameToolStripMenuItem
      // 
      this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
      this.renameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.renameToolStripMenuItem.Text = "Rename";
      this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
      // 
      // toolStripButtonLoad
      // 
      this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButtonLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoad.Image")));
      this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonLoad.Name = "toolStripButtonLoad";
      this.toolStripButtonLoad.Size = new System.Drawing.Size(37, 22);
      this.toolStripButtonLoad.Text = "Load";
      this.toolStripButtonLoad.Click += new System.EventHandler(this.toolStripButtonLoad_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(714, 588);
      this.ContextMenuStrip = this.contextMenuStripTabControl;
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.toolStrip1);
      this.Name = "MainForm";
      this.Text = "Data Browser";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.contextMenuStripTabControl.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
      this.contextMenuStripTabPage.ResumeLayout(false);
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
    private System.Windows.Forms.ContextMenuStrip contextMenuStripTabControl;
    private System.Windows.Forms.ToolStripMenuItem addConnectionToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripTabPage;
    private System.Windows.Forms.ToolStripMenuItem addConnectionToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editConnectionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
  }
}

