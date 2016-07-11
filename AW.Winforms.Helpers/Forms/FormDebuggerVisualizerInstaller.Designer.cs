namespace AW.Winforms.Helpers.Forms
{
  sealed partial class FormDebuggerVisualizerInstaller
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebuggerVisualizerInstaller));
      this.buttonInstallAllUsers = new System.Windows.Forms.Button();
      this.buttonInstallCurrentUser = new System.Windows.Forms.Button();
      this.linkLabelAll = new System.Windows.Forms.LinkLabel();
      this.label1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.labelLocation = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.labelStatusAll = new System.Windows.Forms.Label();
      this.linkLabelUser = new System.Windows.Forms.LinkLabel();
      this.labelStatusUser = new System.Windows.Forms.Label();
      this.labelVersion = new System.Windows.Forms.Label();
      this.linkLabelWebSite = new System.Windows.Forms.LinkLabel();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.buttonAbout = new System.Windows.Forms.Button();
      this.buttonRegistered = new System.Windows.Forms.Button();
      this.buttonDemo = new System.Windows.Forms.Button();
      this.tableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonInstallAllUsers
      // 
      this.buttonInstallAllUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.buttonInstallAllUsers.AutoSize = true;
      this.buttonInstallAllUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.buttonInstallAllUsers.BackColor = System.Drawing.Color.LightGreen;
      this.buttonInstallAllUsers.Location = new System.Drawing.Point(3, 28);
      this.buttonInstallAllUsers.Name = "buttonInstallAllUsers";
      this.buttonInstallAllUsers.Size = new System.Drawing.Size(100, 23);
      this.buttonInstallAllUsers.TabIndex = 0;
      this.buttonInstallAllUsers.Text = "Install for all users";
      this.toolTip1.SetToolTip(this.buttonInstallAllUsers, "May need to run as administator to do this");
      this.buttonInstallAllUsers.UseVisualStyleBackColor = false;
      this.buttonInstallAllUsers.Click += new System.EventHandler(this.buttonInstallAllUsers_Click);
      // 
      // buttonInstallCurrentUser
      // 
      this.buttonInstallCurrentUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.buttonInstallCurrentUser.AutoSize = true;
      this.buttonInstallCurrentUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.buttonInstallCurrentUser.BackColor = System.Drawing.Color.LightGreen;
      this.buttonInstallCurrentUser.Location = new System.Drawing.Point(3, 57);
      this.buttonInstallCurrentUser.Name = "buttonInstallCurrentUser";
      this.buttonInstallCurrentUser.Size = new System.Drawing.Size(140, 23);
      this.buttonInstallCurrentUser.TabIndex = 1;
      this.buttonInstallCurrentUser.Text = "Install for current user only";
      this.buttonInstallCurrentUser.UseVisualStyleBackColor = false;
      this.buttonInstallCurrentUser.Click += new System.EventHandler(this.buttonInstallCurrentUser_Click);
      // 
      // linkLabelAll
      // 
      this.linkLabelAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.linkLabelAll.AutoSize = true;
      this.linkLabelAll.Location = new System.Drawing.Point(229, 33);
      this.linkLabelAll.Name = "linkLabelAll";
      this.linkLabelAll.Size = new System.Drawing.Size(55, 13);
      this.linkLabelAll.TabIndex = 2;
      this.linkLabelAll.TabStop = true;
      this.linkLabelAll.Text = "linkLabel1";
      this.linkLabelAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAll_LinkClicked);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Install Action";
      // 
      // tableLayoutPanel
      // 
      this.tableLayoutPanel.AutoSize = true;
      this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanel.ColumnCount = 3;
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel.Controls.Add(this.buttonInstallCurrentUser, 0, 2);
      this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.labelLocation, 2, 0);
      this.tableLayoutPanel.Controls.Add(this.label4, 1, 0);
      this.tableLayoutPanel.Controls.Add(this.linkLabelAll, 2, 1);
      this.tableLayoutPanel.Controls.Add(this.labelStatusAll, 1, 1);
      this.tableLayoutPanel.Controls.Add(this.linkLabelUser, 2, 2);
      this.tableLayoutPanel.Controls.Add(this.labelStatusUser, 1, 2);
      this.tableLayoutPanel.Controls.Add(this.buttonInstallAllUsers, 0, 1);
      this.tableLayoutPanel.Controls.Add(this.labelVersion, 0, 3);
      this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tableLayoutPanel.Location = new System.Drawing.Point(0, 57);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 4;
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel.Size = new System.Drawing.Size(324, 103);
      this.tableLayoutPanel.TabIndex = 5;
      // 
      // labelLocation
      // 
      this.labelLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelLocation.AutoSize = true;
      this.labelLocation.Location = new System.Drawing.Point(229, 6);
      this.labelLocation.Name = "labelLocation";
      this.labelLocation.Size = new System.Drawing.Size(101, 13);
      this.labelLocation.TabIndex = 2;
      this.labelLocation.Text = "Location to install to";
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(149, 6);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(74, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Current Status";
      // 
      // labelStatusAll
      // 
      this.labelStatusAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelStatusAll.AutoSize = true;
      this.labelStatusAll.Location = new System.Drawing.Point(149, 33);
      this.labelStatusAll.Name = "labelStatusAll";
      this.labelStatusAll.Size = new System.Drawing.Size(66, 13);
      this.labelStatusAll.TabIndex = 6;
      this.labelStatusAll.Text = "Not Installed";
      // 
      // linkLabelUser
      // 
      this.linkLabelUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.linkLabelUser.AutoSize = true;
      this.linkLabelUser.Location = new System.Drawing.Point(229, 62);
      this.linkLabelUser.Name = "linkLabelUser";
      this.linkLabelUser.Size = new System.Drawing.Size(55, 13);
      this.linkLabelUser.TabIndex = 4;
      this.linkLabelUser.TabStop = true;
      this.linkLabelUser.Text = "linkLabel2";
      this.linkLabelUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAll_LinkClicked);
      // 
      // labelStatusUser
      // 
      this.labelStatusUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelStatusUser.AutoSize = true;
      this.labelStatusUser.Location = new System.Drawing.Point(149, 62);
      this.labelStatusUser.Name = "labelStatusUser";
      this.labelStatusUser.Size = new System.Drawing.Size(66, 13);
      this.labelStatusUser.TabIndex = 7;
      this.labelStatusUser.Text = "Not Installed";
      // 
      // labelVersion
      // 
      this.labelVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelVersion.AutoSize = true;
      this.tableLayoutPanel.SetColumnSpan(this.labelVersion, 3);
      this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelVersion.Location = new System.Drawing.Point(3, 86);
      this.labelVersion.Name = "labelVersion";
      this.labelVersion.Size = new System.Drawing.Size(51, 13);
      this.labelVersion.TabIndex = 8;
      this.labelVersion.Text = "Version 3";
      // 
      // linkLabelWebSite
      // 
      this.linkLabelWebSite.AutoSize = true;
      this.linkLabelWebSite.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
      this.linkLabelWebSite.Location = new System.Drawing.Point(3, 0);
      this.linkLabelWebSite.Name = "linkLabelWebSite";
      this.linkLabelWebSite.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
      this.linkLabelWebSite.Size = new System.Drawing.Size(162, 18);
      this.linkLabelWebSite.TabIndex = 0;
      this.linkLabelWebSite.Text = "Debugger Visualizer Description";
      this.linkLabelWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAll_LinkClicked);
      // 
      // buttonAbout
      // 
      this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonAbout.Location = new System.Drawing.Point(218, 0);
      this.buttonAbout.Name = "buttonAbout";
      this.buttonAbout.Size = new System.Drawing.Size(48, 23);
      this.buttonAbout.TabIndex = 7;
      this.buttonAbout.Text = "About";
      this.toolTip1.SetToolTip(this.buttonAbout, "Show loaded assemblies");
      this.buttonAbout.UseVisualStyleBackColor = true;
      this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
      // 
      // buttonRegistered
      // 
      this.buttonRegistered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonRegistered.Location = new System.Drawing.Point(218, 29);
      this.buttonRegistered.Name = "buttonRegistered";
      this.buttonRegistered.Size = new System.Drawing.Size(106, 24);
      this.buttonRegistered.TabIndex = 8;
      this.buttonRegistered.Text = "Registered classes";
      this.toolTip1.SetToolTip(this.buttonRegistered, "Show the classes this is registered for");
      this.buttonRegistered.UseVisualStyleBackColor = true;
      this.buttonRegistered.Click += new System.EventHandler(this.buttonRegistered_Click);
      // 
      // buttonDemo
      // 
      this.buttonDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonDemo.Location = new System.Drawing.Point(272, 0);
      this.buttonDemo.Name = "buttonDemo";
      this.buttonDemo.Size = new System.Drawing.Size(51, 23);
      this.buttonDemo.TabIndex = 9;
      this.buttonDemo.Text = "Demo";
      this.buttonDemo.UseVisualStyleBackColor = true;
      // 
      // FormDebuggerVisualizerInstaller
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(324, 160);
      this.Controls.Add(this.buttonAbout);
      this.Controls.Add(this.buttonDemo);
      this.Controls.Add(this.buttonRegistered);
      this.Controls.Add(this.tableLayoutPanel);
      this.Controls.Add(this.linkLabelWebSite);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormDebuggerVisualizerInstaller";
      this.ShowIcon = false;
      this.Text = "Debugger Visualizer Installer";
      this.Shown += new System.EventHandler(this.FormDebuggerVisualizerInstaller_Shown);
      this.tableLayoutPanel.ResumeLayout(false);
      this.tableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonInstallAllUsers;
    private System.Windows.Forms.Button buttonInstallCurrentUser;
    private System.Windows.Forms.LinkLabel linkLabelAll;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.Label labelLocation;
    private System.Windows.Forms.LinkLabel linkLabelUser;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label labelStatusAll;
    private System.Windows.Forms.Label labelStatusUser;
    private System.Windows.Forms.LinkLabel linkLabelWebSite;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Button buttonAbout;
    private System.Windows.Forms.Button buttonRegistered;
    private System.Windows.Forms.Button buttonDemo;
  }
}

