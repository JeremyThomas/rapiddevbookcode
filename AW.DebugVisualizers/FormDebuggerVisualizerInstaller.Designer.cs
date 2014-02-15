namespace AW.DebugVisualizers
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.labelStatusAll = new System.Windows.Forms.Label();
      this.linkLabelUser = new System.Windows.Forms.LinkLabel();
      this.labelStatusUser = new System.Windows.Forms.Label();
      this.labelVersion = new System.Windows.Forms.Label();
      this.linkLabelWebSite = new System.Windows.Forms.LinkLabel();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonInstallAllUsers
      // 
      this.buttonInstallAllUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.buttonInstallAllUsers.AutoSize = true;
      this.buttonInstallAllUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.buttonInstallAllUsers.Location = new System.Drawing.Point(3, 28);
      this.buttonInstallAllUsers.Name = "buttonInstallAllUsers";
      this.buttonInstallAllUsers.Size = new System.Drawing.Size(102, 23);
      this.buttonInstallAllUsers.TabIndex = 0;
      this.buttonInstallAllUsers.Text = "Install for all Users";
      this.toolTip1.SetToolTip(this.buttonInstallAllUsers, "May need to run as admin to do this");
      this.buttonInstallAllUsers.UseVisualStyleBackColor = true;
      this.buttonInstallAllUsers.Click += new System.EventHandler(this.buttonInstallAllUsers_Click);
      // 
      // buttonInstallCurrentUser
      // 
      this.buttonInstallCurrentUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.buttonInstallCurrentUser.AutoSize = true;
      this.buttonInstallCurrentUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.buttonInstallCurrentUser.Location = new System.Drawing.Point(3, 57);
      this.buttonInstallCurrentUser.Name = "buttonInstallCurrentUser";
      this.buttonInstallCurrentUser.Size = new System.Drawing.Size(130, 23);
      this.buttonInstallCurrentUser.TabIndex = 1;
      this.buttonInstallCurrentUser.Text = "Install Current User Only";
      this.buttonInstallCurrentUser.UseVisualStyleBackColor = true;
      this.buttonInstallCurrentUser.Click += new System.EventHandler(this.buttonInstallCurrentUser_Click);
      // 
      // linkLabelAll
      // 
      this.linkLabelAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.linkLabelAll.AutoSize = true;
      this.linkLabelAll.Location = new System.Drawing.Point(219, 33);
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
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.tableLayoutPanel1.AutoSize = true;
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.buttonInstallCurrentUser, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.linkLabelAll, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.labelStatusAll, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.linkLabelUser, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.labelStatusUser, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.buttonInstallAllUsers, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.labelVersion, 0, 3);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 56);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 103);
      this.tableLayoutPanel1.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(219, 6);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(101, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Location to install to";
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(139, 6);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(74, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Current Status";
      // 
      // labelStatusAll
      // 
      this.labelStatusAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelStatusAll.AutoSize = true;
      this.labelStatusAll.Location = new System.Drawing.Point(139, 33);
      this.labelStatusAll.Name = "labelStatusAll";
      this.labelStatusAll.Size = new System.Drawing.Size(66, 13);
      this.labelStatusAll.TabIndex = 6;
      this.labelStatusAll.Text = "Not Installed";
      // 
      // linkLabelUser
      // 
      this.linkLabelUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.linkLabelUser.AutoSize = true;
      this.linkLabelUser.Location = new System.Drawing.Point(219, 62);
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
      this.labelStatusUser.Location = new System.Drawing.Point(139, 62);
      this.labelStatusUser.Name = "labelStatusUser";
      this.labelStatusUser.Size = new System.Drawing.Size(66, 13);
      this.labelStatusUser.TabIndex = 7;
      this.labelStatusUser.Text = "Not Installed";
      // 
      // labelVersion
      // 
      this.labelVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelVersion.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.labelVersion, 3);
      this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
      this.linkLabelWebSite.Location = new System.Drawing.Point(3, 9);
      this.linkLabelWebSite.Name = "linkLabelWebSite";
      this.linkLabelWebSite.Size = new System.Drawing.Size(558, 39);
      this.linkLabelWebSite.TabIndex = 6;
      this.linkLabelWebSite.Text = resources.GetString("linkLabelWebSite.Text");
      this.linkLabelWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAll_LinkClicked);
      // 
      // FormDebuggerVisualizerInstaller
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(628, 159);
      this.Controls.Add(this.linkLabelWebSite);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "FormDebuggerVisualizerInstaller";
      this.ShowIcon = false;
      this.Text = "Enumerable Debugger Visualizer Installer";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonInstallAllUsers;
    private System.Windows.Forms.Button buttonInstallCurrentUser;
    private System.Windows.Forms.LinkLabel linkLabelAll;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.LinkLabel linkLabelUser;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label labelStatusAll;
    private System.Windows.Forms.Label labelStatusUser;
    private System.Windows.Forms.LinkLabel linkLabelWebSite;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Label labelVersion;
  }
}

