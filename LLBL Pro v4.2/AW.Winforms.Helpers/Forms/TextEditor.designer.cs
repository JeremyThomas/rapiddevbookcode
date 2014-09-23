using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AW.Winforms.Helpers.Forms
{
    partial class TextEditor
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
      this.components = new Container();
      ComponentResourceManager resources = new ComponentResourceManager(typeof(TextEditor));
      this.toolStripContainer1 = new ToolStripContainer();
      this.statusStrip1 = new StatusStrip();
      this.toolStripStatusLabel1 = new ToolStripStatusLabel();
      this.tabControl1 = new TabControl();
      this.toolStrip1 = new ToolStrip();
      this.newToolStripButton = new ToolStripButton();
      this.RemoveTabToolStripButton = new ToolStripButton();
      this.openToolStripButton = new ToolStripButton();
      this.saveToolStripButton = new ToolStripButton();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.cutToolStripButton = new ToolStripButton();
      this.copyToolStripButton = new ToolStripButton();
      this.pasteToolStripButton = new ToolStripButton();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.newToolStripMenuItem = new ToolStripMenuItem();
      this.openToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator = new ToolStripSeparator();
      this.saveToolStripMenuItem = new ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.exitToolStripMenuItem = new ToolStripMenuItem();
      this.editToolStripMenuItem = new ToolStripMenuItem();
      this.undoToolStripMenuItem = new ToolStripMenuItem();
      this.redoToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.cutToolStripMenuItem = new ToolStripMenuItem();
      this.copyToolStripMenuItem = new ToolStripMenuItem();
      this.pasteToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.selectAllToolStripMenuItem = new ToolStripMenuItem();
      this.toolStrip2 = new ToolStrip();
      this.toolStripButton1 = new ToolStripButton();
      this.toolStripButton2 = new ToolStripButton();
      this.toolStripButton3 = new ToolStripButton();
      this.toolStripButton4 = new ToolStripButton();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.toolStripButton5 = new ToolStripButton();
      this.toolStripButton6 = new ToolStripButton();
      this.toolStripSeparator7 = new ToolStripSeparator();
      this.toolStripButton7 = new ToolStripButton();
      this.toolStripButton8 = new ToolStripButton();
      this.toolStripSeparator8 = new ToolStripSeparator();
      this.toolStripButton9 = new ToolStripButton();
      this.toolStripDropDownButton1 = new ToolStripDropDownButton();
      this.HighlighGreen = new ToolStripMenuItem();
      this.HighlighOrange = new ToolStripMenuItem();
      this.HighlighYellow = new ToolStripMenuItem();
      this.toolStripSeparator9 = new ToolStripSeparator();
      this.toolStripComboBox1 = new ToolStripComboBox();
      this.toolStripComboBox2 = new ToolStripComboBox();
      this.contextMenuStrip1 = new ContextMenuStrip(this.components);
      this.undoToolStripMenuItem1 = new ToolStripMenuItem();
      this.redoToolStripMenuItem1 = new ToolStripMenuItem();
      this.toolStripSeparator10 = new ToolStripSeparator();
      this.cutToolStripMenuItem1 = new ToolStripMenuItem();
      this.copyToolStripMenuItem1 = new ToolStripMenuItem();
      this.pasteToolStripMenuItem1 = new ToolStripMenuItem();
      this.toolStripSeparator11 = new ToolStripSeparator();
      this.saveToolStripMenuItem1 = new ToolStripMenuItem();
      this.closeToolStripMenuItem = new ToolStripMenuItem();
      this.closeAllToolStripMenuItem = new ToolStripMenuItem();
      this.closeAllButThisToolStripMenuItem = new ToolStripMenuItem();
      this.timer1 = new Timer(this.components);
      this.colorDialog1 = new ColorDialog();
      this.openFileDialog1 = new OpenFileDialog();
      this.saveFileDialog1 = new SaveFileDialog();
      this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
      this.toolStripContainer1.ContentPanel.SuspendLayout();
      this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
      this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.toolStrip2.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStripContainer1
      // 
      // 
      // toolStripContainer1.BottomToolStripPanel
      // 
      this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
      // 
      // toolStripContainer1.ContentPanel
      // 
      this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
      this.toolStripContainer1.ContentPanel.Size = new Size(611, 336);
      this.toolStripContainer1.Dock = DockStyle.Fill;
      // 
      // toolStripContainer1.LeftToolStripPanel
      // 
      this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStrip1);
      this.toolStripContainer1.Location = new Point(0, 0);
      this.toolStripContainer1.Name = "toolStripContainer1";
      this.toolStripContainer1.Size = new Size(635, 407);
      this.toolStripContainer1.TabIndex = 0;
      this.toolStripContainer1.Text = "toolStripContainer1";
      // 
      // toolStripContainer1.TopToolStripPanel
      // 
      this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
      this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Dock = DockStyle.None;
      this.statusStrip1.Items.AddRange(new ToolStripItem[] {
            this.toolStripStatusLabel1});
      this.statusStrip1.Location = new Point(0, 0);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new Size(635, 22);
      this.statusStrip1.TabIndex = 0;
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new Size(13, 17);
      this.toolStripStatusLabel1.Text = "0";
      // 
      // tabControl1
      // 
      this.tabControl1.Dock = DockStyle.Fill;
      this.tabControl1.Location = new Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(611, 336);
      this.tabControl1.TabIndex = 0;
      // 
      // toolStrip1
      // 
      this.toolStrip1.Dock = DockStyle.None;
      this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new ToolStripItem[] {
            this.newToolStripButton,
            this.RemoveTabToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator5});
      this.toolStrip1.Location = new Point(0, 3);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new Size(24, 174);
      this.toolStrip1.TabIndex = 0;
      // 
      // newToolStripButton
      // 
      this.newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.newToolStripButton.Image = ((Image)(resources.GetObject("newToolStripButton.Image")));
      this.newToolStripButton.ImageTransparentColor = Color.Magenta;
      this.newToolStripButton.Name = "newToolStripButton";
      this.newToolStripButton.Size = new Size(22, 20);
      this.newToolStripButton.Text = "&New";
      this.newToolStripButton.Click += new EventHandler(this.newToolStripButton_Click);
      // 
      // RemoveTabToolStripButton
      // 
      this.RemoveTabToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.RemoveTabToolStripButton.Image = ((Image)(resources.GetObject("RemoveTabToolStripButton.Image")));
      this.RemoveTabToolStripButton.ImageTransparentColor = Color.Magenta;
      this.RemoveTabToolStripButton.Name = "RemoveTabToolStripButton";
      this.RemoveTabToolStripButton.Size = new Size(22, 19);
      this.RemoveTabToolStripButton.Text = "X";
      this.RemoveTabToolStripButton.Click += new EventHandler(this.RemoveTabToolStripButton_Click);
      // 
      // openToolStripButton
      // 
      this.openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.openToolStripButton.Image = ((Image)(resources.GetObject("openToolStripButton.Image")));
      this.openToolStripButton.ImageTransparentColor = Color.Magenta;
      this.openToolStripButton.Name = "openToolStripButton";
      this.openToolStripButton.Size = new Size(22, 20);
      this.openToolStripButton.Text = "&Open";
      this.openToolStripButton.Click += new EventHandler(this.openToolStripButton_Click);
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Image = ((Image)(resources.GetObject("saveToolStripButton.Image")));
      this.saveToolStripButton.ImageTransparentColor = Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new Size(22, 20);
      this.saveToolStripButton.Text = "&Save";
      this.saveToolStripButton.Click += new EventHandler(this.saveToolStripButton_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(22, 6);
      // 
      // cutToolStripButton
      // 
      this.cutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.cutToolStripButton.Image = ((Image)(resources.GetObject("cutToolStripButton.Image")));
      this.cutToolStripButton.ImageTransparentColor = Color.Magenta;
      this.cutToolStripButton.Name = "cutToolStripButton";
      this.cutToolStripButton.Size = new Size(22, 20);
      this.cutToolStripButton.Text = "C&ut";
      this.cutToolStripButton.Click += new EventHandler(this.cutToolStripButton_Click);
      // 
      // copyToolStripButton
      // 
      this.copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.copyToolStripButton.Image = ((Image)(resources.GetObject("copyToolStripButton.Image")));
      this.copyToolStripButton.ImageTransparentColor = Color.Magenta;
      this.copyToolStripButton.Name = "copyToolStripButton";
      this.copyToolStripButton.Size = new Size(22, 20);
      this.copyToolStripButton.Text = "&Copy";
      this.copyToolStripButton.Click += new EventHandler(this.copyToolStripButton_Click);
      // 
      // pasteToolStripButton
      // 
      this.pasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.pasteToolStripButton.Image = ((Image)(resources.GetObject("pasteToolStripButton.Image")));
      this.pasteToolStripButton.ImageTransparentColor = Color.Magenta;
      this.pasteToolStripButton.Name = "pasteToolStripButton";
      this.pasteToolStripButton.Size = new Size(22, 20);
      this.pasteToolStripButton.Text = "&Paste";
      this.pasteToolStripButton.Click += new EventHandler(this.pasteToolStripButton_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new Size(22, 6);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Dock = DockStyle.None;
      this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(635, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Image = ((Image)(resources.GetObject("newToolStripMenuItem.Image")));
      this.newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.N)));
      this.newToolStripMenuItem.Size = new Size(152, 22);
      this.newToolStripMenuItem.Text = "&New";
      this.newToolStripMenuItem.Click += new EventHandler(this.newToolStripMenuItem_Click);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Image = ((Image)(resources.GetObject("openToolStripMenuItem.Image")));
      this.openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.O)));
      this.openToolStripMenuItem.Size = new Size(152, 22);
      this.openToolStripMenuItem.Text = "&Open";
      this.openToolStripMenuItem.Click += new EventHandler(this.openToolStripMenuItem_Click);
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new Size(149, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Image = ((Image)(resources.GetObject("saveToolStripMenuItem.Image")));
      this.saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.S)));
      this.saveToolStripMenuItem.Size = new Size(152, 22);
      this.saveToolStripMenuItem.Text = "&Save";
      this.saveToolStripMenuItem.Click += new EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new Size(152, 22);
      this.saveAsToolStripMenuItem.Text = "Save &As";
      this.saveAsToolStripMenuItem.Click += new EventHandler(this.saveAsToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(149, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new Size(152, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // undoToolStripMenuItem
      // 
      this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
      this.undoToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.Z)));
      this.undoToolStripMenuItem.Size = new Size(152, 22);
      this.undoToolStripMenuItem.Text = "&Undo";
      this.undoToolStripMenuItem.Click += new EventHandler(this.undoToolStripMenuItem_Click);
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.Y)));
      this.redoToolStripMenuItem.Size = new Size(152, 22);
      this.redoToolStripMenuItem.Text = "&Redo";
      this.redoToolStripMenuItem.Click += new EventHandler(this.redoToolStripMenuItem_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(149, 6);
      // 
      // cutToolStripMenuItem
      // 
      this.cutToolStripMenuItem.Image = ((Image)(resources.GetObject("cutToolStripMenuItem.Image")));
      this.cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.X)));
      this.cutToolStripMenuItem.Size = new Size(152, 22);
      this.cutToolStripMenuItem.Text = "Cu&t";
      this.cutToolStripMenuItem.Click += new EventHandler(this.cutToolStripMenuItem_Click);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Image = ((Image)(resources.GetObject("copyToolStripMenuItem.Image")));
      this.copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.C)));
      this.copyToolStripMenuItem.Size = new Size(152, 22);
      this.copyToolStripMenuItem.Text = "&Copy";
      this.copyToolStripMenuItem.Click += new EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.Image = ((Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
      this.pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = ((Keys)((Keys.Control | Keys.V)));
      this.pasteToolStripMenuItem.Size = new Size(152, 22);
      this.pasteToolStripMenuItem.Text = "&Paste";
      this.pasteToolStripMenuItem.Click += new EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(149, 6);
      // 
      // selectAllToolStripMenuItem
      // 
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.Size = new Size(152, 22);
      this.selectAllToolStripMenuItem.Text = "Select &All";
      this.selectAllToolStripMenuItem.Click += new EventHandler(this.selectAllToolStripMenuItem_Click);
      // 
      // toolStrip2
      // 
      this.toolStrip2.Dock = DockStyle.None;
      this.toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
      this.toolStrip2.Items.AddRange(new ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator6,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator7,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator8,
            this.toolStripButton9,
            this.toolStripDropDownButton1,
            this.toolStripSeparator9,
            this.toolStripComboBox1,
            this.toolStripComboBox2});
      this.toolStrip2.Location = new Point(3, 24);
      this.toolStrip2.Name = "toolStrip2";
      this.toolStrip2.Size = new Size(586, 25);
      this.toolStrip2.TabIndex = 1;
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      this.toolStripButton1.Image = ((Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new Size(23, 22);
      this.toolStripButton1.Text = "B";
      this.toolStripButton1.Click += new EventHandler(this.toolStripButton1_Click);
      // 
      // toolStripButton2
      // 
      this.toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButton2.Font = new Font("Segoe UI", 9F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))));
      this.toolStripButton2.Image = ((Image)(resources.GetObject("toolStripButton2.Image")));
      this.toolStripButton2.ImageTransparentColor = Color.Magenta;
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.Size = new Size(23, 22);
      this.toolStripButton2.Text = "I";
      this.toolStripButton2.Click += new EventHandler(this.toolStripButton2_Click);
      // 
      // toolStripButton3
      // 
      this.toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButton3.Font = new Font("Segoe UI", 9F, ((FontStyle)((FontStyle.Bold | FontStyle.Underline))));
      this.toolStripButton3.Image = ((Image)(resources.GetObject("toolStripButton3.Image")));
      this.toolStripButton3.ImageTransparentColor = Color.Magenta;
      this.toolStripButton3.Name = "toolStripButton3";
      this.toolStripButton3.Size = new Size(23, 22);
      this.toolStripButton3.Text = "U";
      this.toolStripButton3.Click += new EventHandler(this.toolStripButton3_Click);
      // 
      // toolStripButton4
      // 
      this.toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButton4.Font = new Font("Segoe UI", 9F, ((FontStyle)((FontStyle.Bold | FontStyle.Strikeout))));
      this.toolStripButton4.Image = ((Image)(resources.GetObject("toolStripButton4.Image")));
      this.toolStripButton4.ImageTransparentColor = Color.Magenta;
      this.toolStripButton4.Name = "toolStripButton4";
      this.toolStripButton4.Size = new Size(23, 22);
      this.toolStripButton4.Text = "S";
      this.toolStripButton4.Click += new EventHandler(this.toolStripButton4_Click);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new Size(6, 25);
      // 
      // toolStripButton5
      // 
      this.toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButton5.Font = new Font("Segoe UI", 9F);
      this.toolStripButton5.Image = ((Image)(resources.GetObject("toolStripButton5.Image")));
      this.toolStripButton5.ImageTransparentColor = Color.Magenta;
      this.toolStripButton5.Name = "toolStripButton5";
      this.toolStripButton5.Size = new Size(23, 22);
      this.toolStripButton5.Text = "A";
      this.toolStripButton5.Click += new EventHandler(this.toolStripButton5_Click);
      // 
      // toolStripButton6
      // 
      this.toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButton6.Font = new Font("Segoe UI", 9F);
      this.toolStripButton6.Image = ((Image)(resources.GetObject("toolStripButton6.Image")));
      this.toolStripButton6.ImageTransparentColor = Color.Magenta;
      this.toolStripButton6.Name = "toolStripButton6";
      this.toolStripButton6.Size = new Size(23, 22);
      this.toolStripButton6.Text = "a";
      this.toolStripButton6.Click += new EventHandler(this.toolStripButton6_Click);
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new Size(6, 25);
      // 
      // toolStripButton7
      // 
      this.toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButton7.Image = ((Image)(resources.GetObject("toolStripButton7.Image")));
      this.toolStripButton7.ImageTransparentColor = Color.Magenta;
      this.toolStripButton7.Name = "toolStripButton7";
      this.toolStripButton7.Size = new Size(27, 22);
      this.toolStripButton7.Text = "A+";
      this.toolStripButton7.Click += new EventHandler(this.toolStripButton7_Click);
      // 
      // toolStripButton8
      // 
      this.toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButton8.Image = ((Image)(resources.GetObject("toolStripButton8.Image")));
      this.toolStripButton8.ImageTransparentColor = Color.Magenta;
      this.toolStripButton8.Name = "toolStripButton8";
      this.toolStripButton8.Size = new Size(24, 22);
      this.toolStripButton8.Text = "A-";
      this.toolStripButton8.Click += new EventHandler(this.toolStripButton8_Click);
      // 
      // toolStripSeparator8
      // 
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new Size(6, 25);
      // 
      // toolStripButton9
      // 
      this.toolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripButton9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      this.toolStripButton9.ForeColor = Color.Maroon;
      this.toolStripButton9.Image = ((Image)(resources.GetObject("toolStripButton9.Image")));
      this.toolStripButton9.ImageTransparentColor = Color.Magenta;
      this.toolStripButton9.Name = "toolStripButton9";
      this.toolStripButton9.Size = new Size(23, 22);
      this.toolStripButton9.Text = "A";
      this.toolStripButton9.Click += new EventHandler(this.toolStripButton9_Click);
      // 
      // toolStripDropDownButton1
      // 
      this.toolStripDropDownButton1.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] {
            this.HighlighGreen,
            this.HighlighOrange,
            this.HighlighYellow});
      this.toolStripDropDownButton1.Font = new Font("Wingdings", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));
      this.toolStripDropDownButton1.Image = ((Image)(resources.GetObject("toolStripDropDownButton1.Image")));
      this.toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
      this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
      this.toolStripDropDownButton1.Size = new Size(32, 22);
      this.toolStripDropDownButton1.Text = "!";
      // 
      // HighlighGreen
      // 
      this.HighlighGreen.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.HighlighGreen.Name = "HighlighGreen";
      this.HighlighGreen.Size = new Size(67, 22);
      this.HighlighGreen.Click += new EventHandler(this.HighlighGreen_Click);
      // 
      // HighlighOrange
      // 
      this.HighlighOrange.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.HighlighOrange.Name = "HighlighOrange";
      this.HighlighOrange.Size = new Size(67, 22);
      this.HighlighOrange.Click += new EventHandler(this.HighlighOrange_Click);
      // 
      // HighlighYellow
      // 
      this.HighlighYellow.BackColor = Color.Yellow;
      this.HighlighYellow.Name = "HighlighYellow";
      this.HighlighYellow.Size = new Size(67, 22);
      this.HighlighYellow.Click += new EventHandler(this.HighlighYellow_Click);
      // 
      // toolStripSeparator9
      // 
      this.toolStripSeparator9.Name = "toolStripSeparator9";
      this.toolStripSeparator9.Size = new Size(6, 25);
      // 
      // toolStripComboBox1
      // 
      this.toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.toolStripComboBox1.FlatStyle = FlatStyle.System;
      this.toolStripComboBox1.Name = "toolStripComboBox1";
      this.toolStripComboBox1.Size = new Size(190, 25);
      this.toolStripComboBox1.SelectedIndexChanged += new EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
      // 
      // toolStripComboBox2
      // 
      this.toolStripComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.toolStripComboBox2.FlatStyle = FlatStyle.Standard;
      this.toolStripComboBox2.Name = "toolStripComboBox2";
      this.toolStripComboBox2.Size = new Size(121, 25);
      this.toolStripComboBox2.SelectedIndexChanged += new EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] {
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem1,
            this.toolStripSeparator10,
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.toolStripSeparator11,
            this.saveToolStripMenuItem1,
            this.closeToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.closeAllButThisToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new Size(167, 214);
      // 
      // undoToolStripMenuItem1
      // 
      this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
      this.undoToolStripMenuItem1.Size = new Size(166, 22);
      this.undoToolStripMenuItem1.Text = "Undo";
      this.undoToolStripMenuItem1.Click += new EventHandler(this.undoToolStripMenuItem1_Click);
      // 
      // redoToolStripMenuItem1
      // 
      this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
      this.redoToolStripMenuItem1.Size = new Size(166, 22);
      this.redoToolStripMenuItem1.Text = "Redo";
      this.redoToolStripMenuItem1.Click += new EventHandler(this.redoToolStripMenuItem1_Click);
      // 
      // toolStripSeparator10
      // 
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      this.toolStripSeparator10.Size = new Size(163, 6);
      // 
      // cutToolStripMenuItem1
      // 
      this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
      this.cutToolStripMenuItem1.Size = new Size(166, 22);
      this.cutToolStripMenuItem1.Text = "Cut";
      this.cutToolStripMenuItem1.Click += new EventHandler(this.cutToolStripMenuItem1_Click);
      // 
      // copyToolStripMenuItem1
      // 
      this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
      this.copyToolStripMenuItem1.Size = new Size(166, 22);
      this.copyToolStripMenuItem1.Text = "Copy";
      this.copyToolStripMenuItem1.Click += new EventHandler(this.copyToolStripMenuItem1_Click);
      // 
      // pasteToolStripMenuItem1
      // 
      this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
      this.pasteToolStripMenuItem1.Size = new Size(166, 22);
      this.pasteToolStripMenuItem1.Text = "Paste";
      this.pasteToolStripMenuItem1.Click += new EventHandler(this.pasteToolStripMenuItem1_Click);
      // 
      // toolStripSeparator11
      // 
      this.toolStripSeparator11.Name = "toolStripSeparator11";
      this.toolStripSeparator11.Size = new Size(163, 6);
      // 
      // saveToolStripMenuItem1
      // 
      this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
      this.saveToolStripMenuItem1.Size = new Size(166, 22);
      this.saveToolStripMenuItem1.Text = "Save";
      this.saveToolStripMenuItem1.Click += new EventHandler(this.saveToolStripMenuItem1_Click);
      // 
      // closeToolStripMenuItem
      // 
      this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      this.closeToolStripMenuItem.Size = new Size(166, 22);
      this.closeToolStripMenuItem.Text = "Close";
      this.closeToolStripMenuItem.Click += new EventHandler(this.closeToolStripMenuItem_Click);
      // 
      // closeAllToolStripMenuItem
      // 
      this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
      this.closeAllToolStripMenuItem.Size = new Size(166, 22);
      this.closeAllToolStripMenuItem.Text = "Close All";
      this.closeAllToolStripMenuItem.Click += new EventHandler(this.closeAllToolStripMenuItem_Click);
      // 
      // closeAllButThisToolStripMenuItem
      // 
      this.closeAllButThisToolStripMenuItem.Name = "closeAllButThisToolStripMenuItem";
      this.closeAllButThisToolStripMenuItem.Size = new Size(166, 22);
      this.closeAllButThisToolStripMenuItem.Text = "Close All But This";
      this.closeAllButThisToolStripMenuItem.Click += new EventHandler(this.closeAllButThisToolStripMenuItem_Click);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.DefaultExt = "txt";
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "Text Files|*.txt|VB Files|*.vb|C# Files|*.cs|All Files|*.*";
      // 
      // saveFileDialog1
      // 
      this.saveFileDialog1.DefaultExt = "txt";
      this.saveFileDialog1.Filter = "Text Files|*.txt|VB Files|*.vb|C# Files|*.cs|All Files|*.*";
      // 
      // TextEditor
      // 
      this.AutoScaleDimensions = new SizeF(6F, 13F);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(635, 407);
      this.Controls.Add(this.toolStripContainer1);
      this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new Size(651, 445);
      this.Name = "TextEditor";
      this.Text = "TextEditor";
      this.Load += new EventHandler(this.AdvancedTextEditor_Load);
      this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
      this.toolStripContainer1.ContentPanel.ResumeLayout(false);
      this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
      this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.PerformLayout();
      this.toolStripContainer1.ResumeLayout(false);
      this.toolStripContainer1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip2.ResumeLayout(false);
      this.toolStrip2.PerformLayout();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton newToolStripButton;
        private ToolStripButton RemoveTabToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton cutToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
        private ToolStripSeparator toolStripSeparator5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabControl1;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolStripButton9;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripComboBox toolStripComboBox2;
        private ToolStripMenuItem HighlighGreen;
        private ToolStripMenuItem HighlighOrange;
        private ToolStripMenuItem HighlighYellow;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem undoToolStripMenuItem1;
        private ToolStripMenuItem redoToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem cutToolStripMenuItem1;
        private ToolStripMenuItem copyToolStripMenuItem1;
        private ToolStripMenuItem pasteToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem closeAllToolStripMenuItem;
        private ToolStripMenuItem closeAllButThisToolStripMenuItem;
        private Timer timer1;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}

