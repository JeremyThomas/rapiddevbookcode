using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;

namespace AW.Winforms.Helpers.Forms
{
	partial class AboutBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
      this.DetailsButton = new Button();
      this.ImagePictureBox = new PictureBox();
      this.AppDateLabel = new Label();
      this.SysInfoButton = new Button();
      this.AppCopyrightLabel = new Label();
      this.AppVersionLabel = new Label();
      this.AppDescriptionLabel = new Label();
      this.GroupBox1 = new GroupBox();
      this.AppTitleLabel = new Label();
      this.OKButton = new Button();
      this.MoreRichTextBox = new RichTextBox();
      this.TabPanelDetails = new TabControl();
      this.TabPageApplication = new TabPage();
      this.AppInfoListView = new ListView();
      this.colKey = ((ColumnHeader)(new ColumnHeader()));
      this.colValue = ((ColumnHeader)(new ColumnHeader()));
      this.TabPageAssemblies = new TabPage();
      this.AssemblyInfoListView = new ListView();
      this.colAssemblyName = ((ColumnHeader)(new ColumnHeader()));
      this.colAssemblyVersion = ((ColumnHeader)(new ColumnHeader()));
      this.colAssemblyBuilt = ((ColumnHeader)(new ColumnHeader()));
      this.colAssemblyCodeBase = ((ColumnHeader)(new ColumnHeader()));
      this.TabPageAssemblyDetails = new TabPage();
      this.AssemblyDetailsListView = new ListView();
      this.ColumnHeader1 = ((ColumnHeader)(new ColumnHeader()));
      this.ColumnHeader2 = ((ColumnHeader)(new ColumnHeader()));
      this.AssemblyNamesComboBox = new ComboBox();
      ((ISupportInitialize)(this.ImagePictureBox)).BeginInit();
      this.TabPanelDetails.SuspendLayout();
      this.TabPageApplication.SuspendLayout();
      this.TabPageAssemblies.SuspendLayout();
      this.TabPageAssemblyDetails.SuspendLayout();
      this.SuspendLayout();
      // 
      // DetailsButton
      // 
      this.DetailsButton.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
      this.DetailsButton.Location = new Point(228, 245);
      this.DetailsButton.Name = "DetailsButton";
      this.DetailsButton.Size = new Size(76, 23);
      this.DetailsButton.TabIndex = 25;
      this.DetailsButton.Text = "&Details >>";
      this.DetailsButton.Click += new EventHandler(this.DetailsButtonClick);
      // 
      // ImagePictureBox
      // 
      this.ImagePictureBox.Location = new Point(14, 7);
      this.ImagePictureBox.Name = "ImagePictureBox";
      this.ImagePictureBox.Size = new Size(32, 32);
      this.ImagePictureBox.TabIndex = 24;
      this.ImagePictureBox.TabStop = false;
      // 
      // AppDateLabel
      // 
      this.AppDateLabel.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
      this.AppDateLabel.Location = new Point(6, 79);
      this.AppDateLabel.Name = "AppDateLabel";
      this.AppDateLabel.Size = new Size(380, 16);
      this.AppDateLabel.TabIndex = 23;
      this.AppDateLabel.Text = "Built on %builddate%";
      // 
      // SysInfoButton
      // 
      this.SysInfoButton.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
      this.SysInfoButton.Location = new Point(212, 245);
      this.SysInfoButton.Name = "SysInfoButton";
      this.SysInfoButton.Size = new Size(92, 23);
      this.SysInfoButton.TabIndex = 22;
      this.SysInfoButton.Text = "&System Info...";
      this.SysInfoButton.Visible = false;
      this.SysInfoButton.Click += new EventHandler(this.SysInfoButtonClick);
      // 
      // AppCopyrightLabel
      // 
      this.AppCopyrightLabel.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
      this.AppCopyrightLabel.Location = new Point(6, 99);
      this.AppCopyrightLabel.Name = "AppCopyrightLabel";
      this.AppCopyrightLabel.Size = new Size(380, 16);
      this.AppCopyrightLabel.TabIndex = 21;
      this.AppCopyrightLabel.Text = "Copyright © %year%, %company%";
      // 
      // AppVersionLabel
      // 
      this.AppVersionLabel.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
      this.AppVersionLabel.Location = new Point(6, 59);
      this.AppVersionLabel.Name = "AppVersionLabel";
      this.AppVersionLabel.Size = new Size(380, 16);
      this.AppVersionLabel.TabIndex = 20;
      this.AppVersionLabel.Text = "Version %version%";
      // 
      // AppDescriptionLabel
      // 
      this.AppDescriptionLabel.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
      this.AppDescriptionLabel.AutoEllipsis = true;
      this.AppDescriptionLabel.AutoSize = true;
      this.AppDescriptionLabel.Location = new Point(58, 27);
      this.AppDescriptionLabel.Name = "AppDescriptionLabel";
      this.AppDescriptionLabel.Size = new Size(74, 13);
      this.AppDescriptionLabel.TabIndex = 19;
      this.AppDescriptionLabel.Text = "%description%";
      // 
      // GroupBox1
      // 
      this.GroupBox1.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
      this.GroupBox1.Location = new Point(6, 47);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(380, 2);
      this.GroupBox1.TabIndex = 18;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "GroupBox1";
      // 
      // AppTitleLabel
      // 
      this.AppTitleLabel.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
      this.AppTitleLabel.Location = new Point(58, 7);
      this.AppTitleLabel.Name = "AppTitleLabel";
      this.AppTitleLabel.Size = new Size(328, 16);
      this.AppTitleLabel.TabIndex = 17;
      this.AppTitleLabel.Text = "%title%";
      // 
      // OKButton
      // 
      this.OKButton.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
      this.OKButton.DialogResult = DialogResult.Cancel;
      this.OKButton.Location = new Point(312, 245);
      this.OKButton.Name = "OKButton";
      this.OKButton.Size = new Size(76, 23);
      this.OKButton.TabIndex = 16;
      this.OKButton.Text = "OK";
      // 
      // MoreRichTextBox
      // 
      this.MoreRichTextBox.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
      this.MoreRichTextBox.BackColor = SystemColors.ControlLight;
      this.MoreRichTextBox.Location = new Point(6, 123);
      this.MoreRichTextBox.Name = "MoreRichTextBox";
      this.MoreRichTextBox.ReadOnly = true;
      this.MoreRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
      this.MoreRichTextBox.Size = new Size(380, 114);
      this.MoreRichTextBox.TabIndex = 26;
      this.MoreRichTextBox.Text = "%product% is %copyright%, %trademark%";
      this.MoreRichTextBox.LinkClicked += new LinkClickedEventHandler(this.MoreRichTextBoxLinkClicked);
      // 
      // TabPanelDetails
      // 
      this.TabPanelDetails.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
      this.TabPanelDetails.Controls.Add(this.TabPageApplication);
      this.TabPanelDetails.Controls.Add(this.TabPageAssemblies);
      this.TabPanelDetails.Controls.Add(this.TabPageAssemblyDetails);
      this.TabPanelDetails.Location = new Point(6, 123);
      this.TabPanelDetails.Name = "TabPanelDetails";
      this.TabPanelDetails.SelectedIndex = 0;
      this.TabPanelDetails.Size = new Size(378, 114);
      this.TabPanelDetails.TabIndex = 27;
      this.TabPanelDetails.Visible = false;
      this.TabPanelDetails.SelectedIndexChanged += new EventHandler(this.TabPanelDetailsSelectedIndexChanged);
      // 
      // TabPageApplication
      // 
      this.TabPageApplication.Controls.Add(this.AppInfoListView);
      this.TabPageApplication.Location = new Point(4, 22);
      this.TabPageApplication.Name = "TabPageApplication";
      this.TabPageApplication.Size = new Size(370, 88);
      this.TabPageApplication.TabIndex = 0;
      this.TabPageApplication.Text = "Application";
      // 
      // AppInfoListView
      // 
      this.AppInfoListView.Columns.AddRange(new ColumnHeader[] {
            this.colKey,
            this.colValue});
      this.AppInfoListView.Dock = DockStyle.Fill;
      this.AppInfoListView.FullRowSelect = true;
      this.AppInfoListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.AppInfoListView.Location = new Point(0, 0);
      this.AppInfoListView.Name = "AppInfoListView";
      this.AppInfoListView.Size = new Size(370, 88);
      this.AppInfoListView.TabIndex = 16;
      this.AppInfoListView.UseCompatibleStateImageBehavior = false;
      this.AppInfoListView.View = View.Details;
      // 
      // colKey
      // 
      this.colKey.Text = "Application Key";
      this.colKey.Width = 120;
      // 
      // colValue
      // 
      this.colValue.Text = "Value";
      this.colValue.Width = 700;
      // 
      // TabPageAssemblies
      // 
      this.TabPageAssemblies.Controls.Add(this.AssemblyInfoListView);
      this.TabPageAssemblies.Location = new Point(4, 22);
      this.TabPageAssemblies.Name = "TabPageAssemblies";
      this.TabPageAssemblies.Size = new Size(370, 88);
      this.TabPageAssemblies.TabIndex = 1;
      this.TabPageAssemblies.Text = "Assemblies";
      // 
      // AssemblyInfoListView
      // 
      this.AssemblyInfoListView.Columns.AddRange(new ColumnHeader[] {
            this.colAssemblyName,
            this.colAssemblyVersion,
            this.colAssemblyBuilt,
            this.colAssemblyCodeBase});
      this.AssemblyInfoListView.Dock = DockStyle.Fill;
      this.AssemblyInfoListView.FullRowSelect = true;
      this.AssemblyInfoListView.Location = new Point(0, 0);
      this.AssemblyInfoListView.MultiSelect = false;
      this.AssemblyInfoListView.Name = "AssemblyInfoListView";
      this.AssemblyInfoListView.Size = new Size(370, 88);
      this.AssemblyInfoListView.Sorting = SortOrder.Ascending;
      this.AssemblyInfoListView.TabIndex = 13;
      this.AssemblyInfoListView.UseCompatibleStateImageBehavior = false;
      this.AssemblyInfoListView.View = View.Details;
      this.AssemblyInfoListView.ColumnClick += new ColumnClickEventHandler(this.AssemblyInfoListViewColumnClick);
      this.AssemblyInfoListView.DoubleClick += new EventHandler(this.AssemblyInfoListViewDoubleClick);
      // 
      // colAssemblyName
      // 
      this.colAssemblyName.Text = "Assembly";
      this.colAssemblyName.Width = 123;
      // 
      // colAssemblyVersion
      // 
      this.colAssemblyVersion.Text = "Version";
      this.colAssemblyVersion.Width = 100;
      // 
      // colAssemblyBuilt
      // 
      this.colAssemblyBuilt.Text = "Built";
      this.colAssemblyBuilt.Width = 130;
      // 
      // colAssemblyCodeBase
      // 
      this.colAssemblyCodeBase.Text = "CodeBase";
      this.colAssemblyCodeBase.Width = 750;
      // 
      // TabPageAssemblyDetails
      // 
      this.TabPageAssemblyDetails.Controls.Add(this.AssemblyDetailsListView);
      this.TabPageAssemblyDetails.Controls.Add(this.AssemblyNamesComboBox);
      this.TabPageAssemblyDetails.Location = new Point(4, 22);
      this.TabPageAssemblyDetails.Name = "TabPageAssemblyDetails";
      this.TabPageAssemblyDetails.Size = new Size(370, 88);
      this.TabPageAssemblyDetails.TabIndex = 2;
      this.TabPageAssemblyDetails.Text = "Assembly Details";
      // 
      // AssemblyDetailsListView
      // 
      this.AssemblyDetailsListView.Columns.AddRange(new ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
      this.AssemblyDetailsListView.Dock = DockStyle.Fill;
      this.AssemblyDetailsListView.FullRowSelect = true;
      this.AssemblyDetailsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.AssemblyDetailsListView.Location = new Point(0, 21);
      this.AssemblyDetailsListView.Name = "AssemblyDetailsListView";
      this.AssemblyDetailsListView.Size = new Size(370, 67);
      this.AssemblyDetailsListView.Sorting = SortOrder.Ascending;
      this.AssemblyDetailsListView.TabIndex = 19;
      this.AssemblyDetailsListView.UseCompatibleStateImageBehavior = false;
      this.AssemblyDetailsListView.View = View.Details;
      // 
      // ColumnHeader1
      // 
      this.ColumnHeader1.Text = "Assembly Key";
      this.ColumnHeader1.Width = 120;
      // 
      // ColumnHeader2
      // 
      this.ColumnHeader2.Text = "Value";
      this.ColumnHeader2.Width = 700;
      // 
      // AssemblyNamesComboBox
      // 
      this.AssemblyNamesComboBox.Dock = DockStyle.Top;
      this.AssemblyNamesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      this.AssemblyNamesComboBox.Location = new Point(0, 0);
      this.AssemblyNamesComboBox.Name = "AssemblyNamesComboBox";
      this.AssemblyNamesComboBox.Size = new Size(370, 21);
      this.AssemblyNamesComboBox.Sorted = true;
      this.AssemblyNamesComboBox.TabIndex = 18;
      this.AssemblyNamesComboBox.SelectedIndexChanged += new EventHandler(this.AssemblyNamesComboBoxSelectedIndexChanged);
      // 
      // AboutBox
      // 
      this.AutoScaleDimensions = new SizeF(6F, 13F);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = this.OKButton;
      this.ClientSize = new Size(394, 275);
      this.Controls.Add(this.DetailsButton);
      this.Controls.Add(this.ImagePictureBox);
      this.Controls.Add(this.AppDateLabel);
      this.Controls.Add(this.SysInfoButton);
      this.Controls.Add(this.AppCopyrightLabel);
      this.Controls.Add(this.AppVersionLabel);
      this.Controls.Add(this.AppDescriptionLabel);
      this.Controls.Add(this.GroupBox1);
      this.Controls.Add(this.AppTitleLabel);
      this.Controls.Add(this.OKButton);
      this.Controls.Add(this.MoreRichTextBox);
      this.Controls.Add(this.TabPanelDetails);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutBox";
      this.SizeGripStyle = SizeGripStyle.Hide;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "About %title%";
      this.Load += new EventHandler(this.AboutBoxLoad);
      this.Paint += new PaintEventHandler(this.AboutBoxPaint);
      ((ISupportInitialize)(this.ImagePictureBox)).EndInit();
      this.TabPanelDetails.ResumeLayout(false);
      this.TabPageApplication.ResumeLayout(false);
      this.TabPageAssemblies.ResumeLayout(false);
      this.TabPageAssemblyDetails.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private Button DetailsButton;
		private PictureBox ImagePictureBox;
		private Label AppDateLabel;
		private Button SysInfoButton;
		private Label AppCopyrightLabel;
		private Label AppVersionLabel;
		private Label AppDescriptionLabel;
		private GroupBox GroupBox1;
		private Label AppTitleLabel;
		private Button OKButton;
		internal RichTextBox MoreRichTextBox;
		internal TabControl TabPanelDetails;
		internal TabPage TabPageApplication;
		internal ListView AppInfoListView;
		internal ColumnHeader colKey;
		internal ColumnHeader colValue;
		internal TabPage TabPageAssemblies;
		internal ListView AssemblyInfoListView;
		internal ColumnHeader colAssemblyName;
		internal ColumnHeader colAssemblyVersion;
		internal ColumnHeader colAssemblyBuilt;
		internal ColumnHeader colAssemblyCodeBase;
		internal TabPage TabPageAssemblyDetails;
		internal ListView AssemblyDetailsListView;
		internal ColumnHeader ColumnHeader1;
		internal ColumnHeader ColumnHeader2;
		internal ComboBox AssemblyNamesComboBox;
	}
}