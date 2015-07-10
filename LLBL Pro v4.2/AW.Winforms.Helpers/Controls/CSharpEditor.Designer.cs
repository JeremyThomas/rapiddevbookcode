using FastColoredTextBoxNS;

namespace AW.Winforms.Helpers.Controls
{
    partial class CSharpEditor
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSharpEditor));
      this.ssMain = new System.Windows.Forms.StatusStrip();
      this.lbWordUnderMouse = new System.Windows.Forms.ToolStripStatusLabel();
      this.btZoom = new System.Windows.Forms.ToolStripSplitButton();
      this.toolStripMenuItem300 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem200 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem150 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem100 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem50 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
      this.tsMain = new System.Windows.Forms.ToolStrip();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.btInvisibleChars = new System.Windows.Forms.ToolStripButton();
      this.btHighlightCurrentLine = new System.Windows.Forms.ToolStripButton();
      this.btShowFoldingLines = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.undoStripButton = new System.Windows.Forms.ToolStripButton();
      this.redoStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.backStripButton = new System.Windows.Forms.ToolStripButton();
      this.forwardStripButton = new System.Windows.Forms.ToolStripButton();
      this.tbFind = new System.Windows.Forms.ToolStripTextBox();
      this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.bookmarkPlusButton = new System.Windows.Forms.ToolStripButton();
      this.bookmarkMinusButton = new System.Windows.Forms.ToolStripButton();
      this.gotoButton = new System.Windows.Forms.ToolStripDropDownButton();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.cmMain = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemS2 = new System.Windows.Forms.ToolStripSeparator();
      this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemS3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripMenuItemS4 = new System.Windows.Forms.ToolStripSeparator();
      this.autoIndentSelectedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.commentSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.uncommentSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cloneLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cloneLinesAndCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tmUpdateInterface = new System.Windows.Forms.Timer(this.components);
      this.dgvObjectExplorer = new System.Windows.Forms.DataGridView();
      this.clImage = new System.Windows.Forms.DataGridViewImageColumn();
      this.ilAutocomplete = new System.Windows.Forms.ImageList(this.components);
      this.CurrentTB = new FastColoredTextBoxNS.FastColoredTextBox();
      this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.setSelectedAsReadonlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.setSelectedAsWritableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
      this.collapseSelectedBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.collapseAllregionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exapndAllregionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.increaseIndentSiftTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.decreaseIndentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
      this.commentSelectedLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.uncommentSelectedLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
      this.goBackwardCtrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.goForwardCtrlShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
      this.autoIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
      this.goLeftBracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.goRightBracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
      this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
      this.startStopMacroRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.executeMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.miLanguage = new System.Windows.Forms.ToolStripMenuItem();
      this.miExport = new System.Windows.Forms.ToolStripMenuItem();
      this.hTMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.rTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.miChangeColors = new System.Windows.Forms.ToolStripMenuItem();
      this.changeHotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.findToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.replaceToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.miCSharp = new System.Windows.Forms.ToolStripMenuItem();
      this.cSharpbuiltinHighlighterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.miVB = new System.Windows.Forms.ToolStripMenuItem();
      this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.jSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.luaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ssMain.SuspendLayout();
      this.tsMain.SuspendLayout();
      this.cmMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvObjectExplorer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.CurrentTB)).BeginInit();
      this.toolStripContainer1.ContentPanel.SuspendLayout();
      this.toolStripContainer1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ssMain
      // 
      this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbWordUnderMouse,
            this.btZoom});
      this.ssMain.Location = new System.Drawing.Point(0, 407);
      this.ssMain.Name = "ssMain";
      this.ssMain.Size = new System.Drawing.Size(901, 22);
      this.ssMain.TabIndex = 2;
      this.ssMain.Text = "statusStrip1";
      // 
      // lbWordUnderMouse
      // 
      this.lbWordUnderMouse.AutoSize = false;
      this.lbWordUnderMouse.ForeColor = System.Drawing.Color.Gray;
      this.lbWordUnderMouse.Name = "lbWordUnderMouse";
      this.lbWordUnderMouse.Size = new System.Drawing.Size(831, 17);
      this.lbWordUnderMouse.Spring = true;
      this.lbWordUnderMouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btZoom
      // 
      this.btZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.btZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem300,
            this.toolStripMenuItem200,
            this.toolStripMenuItem150,
            this.toolStripMenuItem100,
            this.toolStripMenuItem50,
            this.toolStripMenuItem25});
      this.btZoom.Image = ((System.Drawing.Image)(resources.GetObject("btZoom.Image")));
      this.btZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btZoom.Name = "btZoom";
      this.btZoom.Size = new System.Drawing.Size(55, 20);
      this.btZoom.Text = "Zoom";
      // 
      // toolStripMenuItem300
      // 
      this.toolStripMenuItem300.Name = "toolStripMenuItem300";
      this.toolStripMenuItem300.Size = new System.Drawing.Size(102, 22);
      this.toolStripMenuItem300.Tag = "300";
      this.toolStripMenuItem300.Text = "300%";
      this.toolStripMenuItem300.Click += new System.EventHandler(this.Zoom_click);
      // 
      // toolStripMenuItem200
      // 
      this.toolStripMenuItem200.Name = "toolStripMenuItem200";
      this.toolStripMenuItem200.Size = new System.Drawing.Size(102, 22);
      this.toolStripMenuItem200.Tag = "200";
      this.toolStripMenuItem200.Text = "200%";
      this.toolStripMenuItem200.Click += new System.EventHandler(this.Zoom_click);
      // 
      // toolStripMenuItem150
      // 
      this.toolStripMenuItem150.Name = "toolStripMenuItem150";
      this.toolStripMenuItem150.Size = new System.Drawing.Size(102, 22);
      this.toolStripMenuItem150.Tag = "150";
      this.toolStripMenuItem150.Text = "150%";
      this.toolStripMenuItem150.Click += new System.EventHandler(this.Zoom_click);
      // 
      // toolStripMenuItem100
      // 
      this.toolStripMenuItem100.Name = "toolStripMenuItem100";
      this.toolStripMenuItem100.Size = new System.Drawing.Size(102, 22);
      this.toolStripMenuItem100.Tag = "100";
      this.toolStripMenuItem100.Text = "100%";
      this.toolStripMenuItem100.Click += new System.EventHandler(this.Zoom_click);
      // 
      // toolStripMenuItem50
      // 
      this.toolStripMenuItem50.Name = "toolStripMenuItem50";
      this.toolStripMenuItem50.Size = new System.Drawing.Size(102, 22);
      this.toolStripMenuItem50.Tag = "50";
      this.toolStripMenuItem50.Text = "50%";
      this.toolStripMenuItem50.Click += new System.EventHandler(this.Zoom_click);
      // 
      // toolStripMenuItem25
      // 
      this.toolStripMenuItem25.Name = "toolStripMenuItem25";
      this.toolStripMenuItem25.Size = new System.Drawing.Size(102, 22);
      this.toolStripMenuItem25.Tag = "25";
      this.toolStripMenuItem25.Text = "25%";
      this.toolStripMenuItem25.Click += new System.EventHandler(this.Zoom_click);
      // 
      // tsMain
      // 
      this.tsMain.Dock = System.Windows.Forms.DockStyle.None;
      this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.btInvisibleChars,
            this.btHighlightCurrentLine,
            this.btShowFoldingLines,
            this.toolStripSeparator4,
            this.undoStripButton,
            this.redoStripButton,
            this.toolStripSeparator5,
            this.backStripButton,
            this.forwardStripButton,
            this.tbFind,
            this.toolStripLabel1,
            this.toolStripSeparator6,
            this.bookmarkPlusButton,
            this.bookmarkMinusButton,
            this.gotoButton});
      this.tsMain.Location = new System.Drawing.Point(0, 3);
      this.tsMain.Name = "tsMain";
      this.tsMain.Size = new System.Drawing.Size(536, 25);
      this.tsMain.TabIndex = 3;
      this.tsMain.Text = "toolStrip1";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // cutToolStripButton
      // 
      this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
      this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cutToolStripButton.Name = "cutToolStripButton";
      this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.cutToolStripButton.Text = "C&ut";
      this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
      // 
      // copyToolStripButton
      // 
      this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
      this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripButton.Name = "copyToolStripButton";
      this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.copyToolStripButton.Text = "&Copy";
      this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // pasteToolStripButton
      // 
      this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
      this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolStripButton.Name = "pasteToolStripButton";
      this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.pasteToolStripButton.Text = "&Paste";
      this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // btInvisibleChars
      // 
      this.btInvisibleChars.CheckOnClick = true;
      this.btInvisibleChars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.btInvisibleChars.Image = ((System.Drawing.Image)(resources.GetObject("btInvisibleChars.Image")));
      this.btInvisibleChars.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btInvisibleChars.Name = "btInvisibleChars";
      this.btInvisibleChars.Size = new System.Drawing.Size(23, 22);
      this.btInvisibleChars.Text = "¶";
      this.btInvisibleChars.ToolTipText = "Show invisible chars";
      this.btInvisibleChars.Click += new System.EventHandler(this.btInvisibleChars_Click);
      // 
      // btHighlightCurrentLine
      // 
      this.btHighlightCurrentLine.CheckOnClick = true;
      this.btHighlightCurrentLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btHighlightCurrentLine.Image = global::AW.Winforms.Helpers.Properties.Resources.edit_padding_top;
      this.btHighlightCurrentLine.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btHighlightCurrentLine.Name = "btHighlightCurrentLine";
      this.btHighlightCurrentLine.Size = new System.Drawing.Size(23, 22);
      this.btHighlightCurrentLine.Text = "Highlight current line";
      this.btHighlightCurrentLine.ToolTipText = "Highlight current line";
      this.btHighlightCurrentLine.Click += new System.EventHandler(this.btHighlightCurrentLine_Click);
      // 
      // btShowFoldingLines
      // 
      this.btShowFoldingLines.Checked = true;
      this.btShowFoldingLines.CheckOnClick = true;
      this.btShowFoldingLines.CheckState = System.Windows.Forms.CheckState.Checked;
      this.btShowFoldingLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btShowFoldingLines.Image = ((System.Drawing.Image)(resources.GetObject("btShowFoldingLines.Image")));
      this.btShowFoldingLines.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btShowFoldingLines.Name = "btShowFoldingLines";
      this.btShowFoldingLines.Size = new System.Drawing.Size(23, 22);
      this.btShowFoldingLines.Text = "Show folding lines";
      this.btShowFoldingLines.Click += new System.EventHandler(this.btShowFoldingLines_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
      // 
      // undoStripButton
      // 
      this.undoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.undoStripButton.Image = global::AW.Winforms.Helpers.Properties.Resources.undo_16x16;
      this.undoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.undoStripButton.Name = "undoStripButton";
      this.undoStripButton.Size = new System.Drawing.Size(23, 22);
      this.undoStripButton.Text = "Undo (Ctrl+Z)";
      this.undoStripButton.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
      // 
      // redoStripButton
      // 
      this.redoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.redoStripButton.Image = global::AW.Winforms.Helpers.Properties.Resources.redo_16x16;
      this.redoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.redoStripButton.Name = "redoStripButton";
      this.redoStripButton.Size = new System.Drawing.Size(23, 22);
      this.redoStripButton.Text = "Redo (Ctrl+R)";
      this.redoStripButton.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
      // 
      // backStripButton
      // 
      this.backStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.backStripButton.Image = global::AW.Winforms.Helpers.Properties.Resources.backward0_16x16;
      this.backStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.backStripButton.Name = "backStripButton";
      this.backStripButton.Size = new System.Drawing.Size(23, 22);
      this.backStripButton.Text = "Navigate Backward (Ctrl+ -)";
      this.backStripButton.Click += new System.EventHandler(this.backStripButton_Click);
      // 
      // forwardStripButton
      // 
      this.forwardStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.forwardStripButton.Image = global::AW.Winforms.Helpers.Properties.Resources.forward_16x16;
      this.forwardStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.forwardStripButton.Name = "forwardStripButton";
      this.forwardStripButton.Size = new System.Drawing.Size(23, 22);
      this.forwardStripButton.Text = "Navigate Forward (Ctrl+Shift+ -)";
      this.forwardStripButton.Click += new System.EventHandler(this.forwardStripButton_Click);
      // 
      // tbFind
      // 
      this.tbFind.AcceptsReturn = true;
      this.tbFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.tbFind.Name = "tbFind";
      this.tbFind.Size = new System.Drawing.Size(100, 25);
      this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
      this.toolStripLabel1.Text = "Find: ";
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
      // 
      // bookmarkPlusButton
      // 
      this.bookmarkPlusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bookmarkPlusButton.Image = global::AW.Winforms.Helpers.Properties.Resources.layer__plus;
      this.bookmarkPlusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.bookmarkPlusButton.Name = "bookmarkPlusButton";
      this.bookmarkPlusButton.Size = new System.Drawing.Size(23, 22);
      this.bookmarkPlusButton.Text = "Add bookmark (Ctrl-B)";
      this.bookmarkPlusButton.Click += new System.EventHandler(this.bookmarkPlusButton_Click);
      // 
      // bookmarkMinusButton
      // 
      this.bookmarkMinusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bookmarkMinusButton.Image = global::AW.Winforms.Helpers.Properties.Resources.layer__minus;
      this.bookmarkMinusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.bookmarkMinusButton.Name = "bookmarkMinusButton";
      this.bookmarkMinusButton.Size = new System.Drawing.Size(23, 22);
      this.bookmarkMinusButton.Text = "Remove bookmark (Ctrl-Shift-B)";
      this.bookmarkMinusButton.Click += new System.EventHandler(this.bookmarkMinusButton_Click);
      // 
      // gotoButton
      // 
      this.gotoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.gotoButton.Image = ((System.Drawing.Image)(resources.GetObject("gotoButton.Image")));
      this.gotoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.gotoButton.Name = "gotoButton";
      this.gotoButton.Size = new System.Drawing.Size(55, 22);
      this.gotoButton.Text = "Goto...";
      this.gotoButton.DropDownOpening += new System.EventHandler(this.gotoButton_DropDownOpening);
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // splitter1
      // 
      this.splitter1.Location = new System.Drawing.Point(0, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(3, 407);
      this.splitter1.TabIndex = 5;
      this.splitter1.TabStop = false;
      // 
      // cmMain
      // 
      this.cmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.toolStripMenuItemS2,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItemS3,
            this.toolStripMenuItemS4,
            this.autoIndentSelectedTextToolStripMenuItem,
            this.commentSelectedToolStripMenuItem,
            this.uncommentSelectedToolStripMenuItem,
            this.cloneLinesToolStripMenuItem,
            this.cloneLinesAndCommentToolStripMenuItem});
      this.cmMain.Name = "cmMain";
      this.cmMain.Size = new System.Drawing.Size(219, 264);
      // 
      // cutToolStripMenuItem
      // 
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.cutToolStripMenuItem.Text = "Cut";
      this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.copyToolStripMenuItem.Text = "Copy";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.pasteToolStripMenuItem.Text = "Paste";
      this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
      // 
      // selectAllToolStripMenuItem
      // 
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.selectAllToolStripMenuItem.Text = "Select all";
      this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
      // 
      // toolStripMenuItemS2
      // 
      this.toolStripMenuItemS2.Name = "toolStripMenuItemS2";
      this.toolStripMenuItemS2.Size = new System.Drawing.Size(215, 6);
      // 
      // undoToolStripMenuItem
      // 
      this.undoToolStripMenuItem.Image = global::AW.Winforms.Helpers.Properties.Resources.undo_16x16;
      this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
      this.undoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.undoToolStripMenuItem.Text = "Undo";
      this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Image = global::AW.Winforms.Helpers.Properties.Resources.redo_16x16;
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.redoToolStripMenuItem.Text = "Redo";
      this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
      // 
      // toolStripMenuItemS3
      // 
      this.toolStripMenuItemS3.Name = "toolStripMenuItemS3";
      this.toolStripMenuItemS3.Size = new System.Drawing.Size(215, 6);
      // 
      // toolStripMenuItemS4
      // 
      this.toolStripMenuItemS4.Name = "toolStripMenuItemS4";
      this.toolStripMenuItemS4.Size = new System.Drawing.Size(215, 6);
      // 
      // autoIndentSelectedTextToolStripMenuItem
      // 
      this.autoIndentSelectedTextToolStripMenuItem.Name = "autoIndentSelectedTextToolStripMenuItem";
      this.autoIndentSelectedTextToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.autoIndentSelectedTextToolStripMenuItem.Text = "AutoIndent selected text";
      this.autoIndentSelectedTextToolStripMenuItem.Click += new System.EventHandler(this.autoIndentSelectedTextToolStripMenuItem_Click);
      // 
      // commentSelectedToolStripMenuItem
      // 
      this.commentSelectedToolStripMenuItem.Name = "commentSelectedToolStripMenuItem";
      this.commentSelectedToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.commentSelectedToolStripMenuItem.Text = "Comment selected";
      this.commentSelectedToolStripMenuItem.Click += new System.EventHandler(this.commentSelectedToolStripMenuItem_Click);
      // 
      // uncommentSelectedToolStripMenuItem
      // 
      this.uncommentSelectedToolStripMenuItem.Name = "uncommentSelectedToolStripMenuItem";
      this.uncommentSelectedToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.uncommentSelectedToolStripMenuItem.Text = "Uncomment selected";
      this.uncommentSelectedToolStripMenuItem.Click += new System.EventHandler(this.uncommentSelectedToolStripMenuItem_Click);
      // 
      // cloneLinesToolStripMenuItem
      // 
      this.cloneLinesToolStripMenuItem.Name = "cloneLinesToolStripMenuItem";
      this.cloneLinesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.cloneLinesToolStripMenuItem.Text = "Clone line(s)";
      this.cloneLinesToolStripMenuItem.Click += new System.EventHandler(this.cloneLinesToolStripMenuItem_Click);
      // 
      // cloneLinesAndCommentToolStripMenuItem
      // 
      this.cloneLinesAndCommentToolStripMenuItem.Name = "cloneLinesAndCommentToolStripMenuItem";
      this.cloneLinesAndCommentToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.cloneLinesAndCommentToolStripMenuItem.Text = "Clone line(s) and comment";
      this.cloneLinesAndCommentToolStripMenuItem.Click += new System.EventHandler(this.cloneLinesAndCommentToolStripMenuItem_Click);
      // 
      // findToolStripMenuItem
      // 
      this.findToolStripMenuItem.Name = "findToolStripMenuItem";
      this.findToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.findToolStripMenuItem.Text = "&Find [Ctrl+F]";
      this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
      // 
      // replaceToolStripMenuItem
      // 
      this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
      this.replaceToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.replaceToolStripMenuItem.Text = "&Replace [Ctrl+H]";
      this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
      // 
      // tmUpdateInterface
      // 
      this.tmUpdateInterface.Enabled = true;
      this.tmUpdateInterface.Interval = 400;
      this.tmUpdateInterface.Tick += new System.EventHandler(this.tmUpdateInterface_Tick);
      // 
      // dgvObjectExplorer
      // 
      this.dgvObjectExplorer.AllowUserToAddRows = false;
      this.dgvObjectExplorer.AllowUserToDeleteRows = false;
      this.dgvObjectExplorer.AllowUserToResizeColumns = false;
      this.dgvObjectExplorer.AllowUserToResizeRows = false;
      this.dgvObjectExplorer.BackgroundColor = System.Drawing.Color.White;
      this.dgvObjectExplorer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.dgvObjectExplorer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvObjectExplorer.ColumnHeadersVisible = false;
      this.dgvObjectExplorer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clImage,
            this.clName});
      this.dgvObjectExplorer.Cursor = System.Windows.Forms.Cursors.Hand;
      this.dgvObjectExplorer.Dock = System.Windows.Forms.DockStyle.Right;
      this.dgvObjectExplorer.GridColor = System.Drawing.Color.White;
      this.dgvObjectExplorer.Location = new System.Drawing.Point(729, 0);
      this.dgvObjectExplorer.MultiSelect = false;
      this.dgvObjectExplorer.Name = "dgvObjectExplorer";
      this.dgvObjectExplorer.ReadOnly = true;
      this.dgvObjectExplorer.RowHeadersVisible = false;
      this.dgvObjectExplorer.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
      this.dgvObjectExplorer.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
      this.dgvObjectExplorer.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Green;
      this.dgvObjectExplorer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvObjectExplorer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvObjectExplorer.Size = new System.Drawing.Size(172, 407);
      this.dgvObjectExplorer.TabIndex = 6;
      this.dgvObjectExplorer.VirtualMode = true;
      this.dgvObjectExplorer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvObjectExplorer_CellMouseDoubleClick);
      this.dgvObjectExplorer.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvObjectExplorer_CellValueNeeded);
      // 
      // clImage
      // 
      this.clImage.HeaderText = "Column2";
      this.clImage.MinimumWidth = 32;
      this.clImage.Name = "clImage";
      this.clImage.ReadOnly = true;
      this.clImage.Width = 32;
      // 
      // ilAutocomplete
      // 
      this.ilAutocomplete.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilAutocomplete.ImageStream")));
      this.ilAutocomplete.TransparentColor = System.Drawing.Color.Transparent;
      this.ilAutocomplete.Images.SetKeyName(0, "script_16x16.png");
      this.ilAutocomplete.Images.SetKeyName(1, "app_16x16.png");
      this.ilAutocomplete.Images.SetKeyName(2, "1302166543_virtualbox.png");
      // 
      // CurrentTB
      // 
      this.CurrentTB.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
      this.CurrentTB.AutoScrollMinSize = new System.Drawing.Size(27, 14);
      this.CurrentTB.BackBrush = null;
      this.CurrentTB.CharHeight = 14;
      this.CurrentTB.CharWidth = 8;
      this.CurrentTB.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.CurrentTB.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.CurrentTB.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CurrentTB.IsReplaceMode = false;
      this.CurrentTB.Location = new System.Drawing.Point(3, 53);
      this.CurrentTB.Name = "CurrentTB";
      this.CurrentTB.Paddings = new System.Windows.Forms.Padding(0);
      this.CurrentTB.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.CurrentTB.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("CurrentTB.ServiceColors")));
      this.CurrentTB.Size = new System.Drawing.Size(726, 354);
      this.CurrentTB.TabIndex = 7;
      this.CurrentTB.Zoom = 100;
      // 
      // toolStripContainer1
      // 
      this.toolStripContainer1.BottomToolStripPanelVisible = false;
      // 
      // toolStripContainer1.ContentPanel
      // 
      this.toolStripContainer1.ContentPanel.Controls.Add(this.tsMain);
      this.toolStripContainer1.ContentPanel.Controls.Add(this.menuStrip1);
      this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(726, 28);
      this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top;
      this.toolStripContainer1.LeftToolStripPanelVisible = false;
      this.toolStripContainer1.Location = new System.Drawing.Point(3, 0);
      this.toolStripContainer1.Name = "toolStripContainer1";
      this.toolStripContainer1.RightToolStripPanelVisible = false;
      this.toolStripContainer1.Size = new System.Drawing.Size(726, 53);
      this.toolStripContainer1.TabIndex = 10;
      this.toolStripContainer1.Text = "toolStripContainer1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.miLanguage,
            this.miExport,
            this.miChangeColors,
            this.changeHotkeysToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(500, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(51, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.setSelectedAsReadonlyToolStripMenuItem,
            this.setSelectedAsWritableToolStripMenuItem,
            this.toolStripMenuItem8,
            this.collapseSelectedBlockToolStripMenuItem,
            this.toolStripMenuItem3,
            this.collapseAllregionToolStripMenuItem,
            this.exapndAllregionToolStripMenuItem,
            this.toolStripMenuItem2,
            this.increaseIndentSiftTabToolStripMenuItem,
            this.decreaseIndentTabToolStripMenuItem,
            this.toolStripMenuItem10,
            this.commentSelectedLinesToolStripMenuItem,
            this.uncommentSelectedLinesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.goBackwardCtrlToolStripMenuItem,
            this.goForwardCtrlShiftToolStripMenuItem,
            this.toolStripMenuItem5,
            this.autoIndentToolStripMenuItem,
            this.toolStripMenuItem6,
            this.goLeftBracketToolStripMenuItem,
            this.goRightBracketToolStripMenuItem,
            this.toolStripMenuItem7,
            this.miPrint,
            this.toolStripMenuItem9,
            this.startStopMacroRecordingToolStripMenuItem,
            this.executeMacroToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 6);
      // 
      // setSelectedAsReadonlyToolStripMenuItem
      // 
      this.setSelectedAsReadonlyToolStripMenuItem.Name = "setSelectedAsReadonlyToolStripMenuItem";
      this.setSelectedAsReadonlyToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.setSelectedAsReadonlyToolStripMenuItem.Text = "Set selected as readonly";
      this.setSelectedAsReadonlyToolStripMenuItem.Click += new System.EventHandler(this.setSelectedAsReadonlyToolStripMenuItem_Click);
      // 
      // setSelectedAsWritableToolStripMenuItem
      // 
      this.setSelectedAsWritableToolStripMenuItem.Name = "setSelectedAsWritableToolStripMenuItem";
      this.setSelectedAsWritableToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.setSelectedAsWritableToolStripMenuItem.Text = "Set selected as writable";
      this.setSelectedAsWritableToolStripMenuItem.Click += new System.EventHandler(this.setSelectedAsWritableToolStripMenuItem_Click);
      // 
      // toolStripMenuItem8
      // 
      this.toolStripMenuItem8.Name = "toolStripMenuItem8";
      this.toolStripMenuItem8.Size = new System.Drawing.Size(264, 6);
      // 
      // collapseSelectedBlockToolStripMenuItem
      // 
      this.collapseSelectedBlockToolStripMenuItem.Name = "collapseSelectedBlockToolStripMenuItem";
      this.collapseSelectedBlockToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.collapseSelectedBlockToolStripMenuItem.Text = "Collapse selected block";
      this.collapseSelectedBlockToolStripMenuItem.Click += new System.EventHandler(this.collapseSelectedBlockToolStripMenuItem_Click);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(264, 6);
      // 
      // collapseAllregionToolStripMenuItem
      // 
      this.collapseAllregionToolStripMenuItem.Name = "collapseAllregionToolStripMenuItem";
      this.collapseAllregionToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.collapseAllregionToolStripMenuItem.Text = "Collapse all #region";
      this.collapseAllregionToolStripMenuItem.Click += new System.EventHandler(this.collapseAllregionToolStripMenuItem_Click);
      // 
      // exapndAllregionToolStripMenuItem
      // 
      this.exapndAllregionToolStripMenuItem.Name = "exapndAllregionToolStripMenuItem";
      this.exapndAllregionToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.exapndAllregionToolStripMenuItem.Text = "Exapnd all #region";
      this.exapndAllregionToolStripMenuItem.Click += new System.EventHandler(this.exapndAllregionToolStripMenuItem_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(264, 6);
      // 
      // increaseIndentSiftTabToolStripMenuItem
      // 
      this.increaseIndentSiftTabToolStripMenuItem.Name = "increaseIndentSiftTabToolStripMenuItem";
      this.increaseIndentSiftTabToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.increaseIndentSiftTabToolStripMenuItem.Text = "Increase Indent [Tab]";
      this.increaseIndentSiftTabToolStripMenuItem.Click += new System.EventHandler(this.increaseIndentSiftTabToolStripMenuItem_Click);
      // 
      // decreaseIndentTabToolStripMenuItem
      // 
      this.decreaseIndentTabToolStripMenuItem.Name = "decreaseIndentTabToolStripMenuItem";
      this.decreaseIndentTabToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.decreaseIndentTabToolStripMenuItem.Text = "Decrease Indent [Shift + Tab]";
      this.decreaseIndentTabToolStripMenuItem.Click += new System.EventHandler(this.decreaseIndentTabToolStripMenuItem_Click);
      // 
      // toolStripMenuItem10
      // 
      this.toolStripMenuItem10.Name = "toolStripMenuItem10";
      this.toolStripMenuItem10.Size = new System.Drawing.Size(264, 6);
      // 
      // commentSelectedLinesToolStripMenuItem
      // 
      this.commentSelectedLinesToolStripMenuItem.Name = "commentSelectedLinesToolStripMenuItem";
      this.commentSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.commentSelectedLinesToolStripMenuItem.Text = "Comment selected lines";
      this.commentSelectedLinesToolStripMenuItem.Click += new System.EventHandler(this.commentSelectedLinesToolStripMenuItem_Click);
      // 
      // uncommentSelectedLinesToolStripMenuItem
      // 
      this.uncommentSelectedLinesToolStripMenuItem.Name = "uncommentSelectedLinesToolStripMenuItem";
      this.uncommentSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.uncommentSelectedLinesToolStripMenuItem.Text = "Uncomment selected lines";
      this.uncommentSelectedLinesToolStripMenuItem.Click += new System.EventHandler(this.uncommentSelectedLinesToolStripMenuItem_Click);
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(264, 6);
      // 
      // goBackwardCtrlToolStripMenuItem
      // 
      this.goBackwardCtrlToolStripMenuItem.Name = "goBackwardCtrlToolStripMenuItem";
      this.goBackwardCtrlToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.goBackwardCtrlToolStripMenuItem.Text = "Go Backward [Ctrl+ -]";
      this.goBackwardCtrlToolStripMenuItem.Click += new System.EventHandler(this.goBackwardCtrlToolStripMenuItem_Click);
      // 
      // goForwardCtrlShiftToolStripMenuItem
      // 
      this.goForwardCtrlShiftToolStripMenuItem.Name = "goForwardCtrlShiftToolStripMenuItem";
      this.goForwardCtrlShiftToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.goForwardCtrlShiftToolStripMenuItem.Text = "Go Forward [Ctrl+Shift+ -]";
      this.goForwardCtrlShiftToolStripMenuItem.Click += new System.EventHandler(this.goForwardCtrlShiftToolStripMenuItem_Click);
      // 
      // toolStripMenuItem5
      // 
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new System.Drawing.Size(264, 6);
      // 
      // autoIndentToolStripMenuItem
      // 
      this.autoIndentToolStripMenuItem.Name = "autoIndentToolStripMenuItem";
      this.autoIndentToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.autoIndentToolStripMenuItem.Text = "Auto Indent selected text";
      this.autoIndentToolStripMenuItem.Click += new System.EventHandler(this.autoIndentToolStripMenuItem_Click);
      // 
      // toolStripMenuItem6
      // 
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.Size = new System.Drawing.Size(264, 6);
      // 
      // goLeftBracketToolStripMenuItem
      // 
      this.goLeftBracketToolStripMenuItem.Name = "goLeftBracketToolStripMenuItem";
      this.goLeftBracketToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.goLeftBracketToolStripMenuItem.Text = "Go Left Bracket";
      this.goLeftBracketToolStripMenuItem.Click += new System.EventHandler(this.goLeftBracketToolStripMenuItem_Click);
      // 
      // goRightBracketToolStripMenuItem
      // 
      this.goRightBracketToolStripMenuItem.Name = "goRightBracketToolStripMenuItem";
      this.goRightBracketToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.goRightBracketToolStripMenuItem.Text = "Go Right Bracket";
      this.goRightBracketToolStripMenuItem.Click += new System.EventHandler(this.goRightBracketToolStripMenuItem_Click);
      // 
      // toolStripMenuItem7
      // 
      this.toolStripMenuItem7.Name = "toolStripMenuItem7";
      this.toolStripMenuItem7.Size = new System.Drawing.Size(264, 6);
      // 
      // miPrint
      // 
      this.miPrint.Name = "miPrint";
      this.miPrint.Size = new System.Drawing.Size(267, 22);
      this.miPrint.Text = "Print...";
      this.miPrint.Click += new System.EventHandler(this.miPrint_Click);
      // 
      // toolStripMenuItem9
      // 
      this.toolStripMenuItem9.Name = "toolStripMenuItem9";
      this.toolStripMenuItem9.Size = new System.Drawing.Size(264, 6);
      // 
      // startStopMacroRecordingToolStripMenuItem
      // 
      this.startStopMacroRecordingToolStripMenuItem.Name = "startStopMacroRecordingToolStripMenuItem";
      this.startStopMacroRecordingToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.startStopMacroRecordingToolStripMenuItem.Text = "Start/Stop macro recording [Ctrl+M]";
      this.startStopMacroRecordingToolStripMenuItem.Click += new System.EventHandler(this.startStopMacroRecordingToolStripMenuItem_Click);
      // 
      // executeMacroToolStripMenuItem
      // 
      this.executeMacroToolStripMenuItem.Name = "executeMacroToolStripMenuItem";
      this.executeMacroToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
      this.executeMacroToolStripMenuItem.Text = "Execute macro [Ctrl+E]";
      this.executeMacroToolStripMenuItem.Click += new System.EventHandler(this.executeMacroToolStripMenuItem_Click);
      // 
      // miLanguage
      // 
      this.miLanguage.Name = "miLanguage";
      this.miLanguage.Size = new System.Drawing.Size(12, 20);
      this.miLanguage.Visible = false;
      // 
      // miExport
      // 
      this.miExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTMLToolStripMenuItem1,
            this.rTFToolStripMenuItem});
      this.miExport.Name = "miExport";
      this.miExport.Size = new System.Drawing.Size(52, 20);
      this.miExport.Text = "Export";
      this.miExport.Visible = false;
      // 
      // hTMLToolStripMenuItem1
      // 
      this.hTMLToolStripMenuItem1.Name = "hTMLToolStripMenuItem1";
      this.hTMLToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
      this.hTMLToolStripMenuItem1.Text = "HTML";
      this.hTMLToolStripMenuItem1.Click += new System.EventHandler(this.hTMLToolStripMenuItem1_Click);
      // 
      // rTFToolStripMenuItem
      // 
      this.rTFToolStripMenuItem.Name = "rTFToolStripMenuItem";
      this.rTFToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.rTFToolStripMenuItem.Text = "RTF";
      this.rTFToolStripMenuItem.Click += new System.EventHandler(this.rTFToolStripMenuItem_Click);
      // 
      // miChangeColors
      // 
      this.miChangeColors.Enabled = false;
      this.miChangeColors.Name = "miChangeColors";
      this.miChangeColors.Size = new System.Drawing.Size(95, 20);
      this.miChangeColors.Text = "Change colors";
      this.miChangeColors.Visible = false;
      this.miChangeColors.Click += new System.EventHandler(this.miChangeColors_Click);
      // 
      // changeHotkeysToolStripMenuItem
      // 
      this.changeHotkeysToolStripMenuItem.Name = "changeHotkeysToolStripMenuItem";
      this.changeHotkeysToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
      this.changeHotkeysToolStripMenuItem.Text = "Change hotkeys";
      this.changeHotkeysToolStripMenuItem.Visible = false;
      this.changeHotkeysToolStripMenuItem.Click += new System.EventHandler(this.changeHotkeysToolStripMenuItem_Click);
      // 
      // findToolStripMenuItem2
      // 
      this.findToolStripMenuItem2.Name = "findToolStripMenuItem2";
      this.findToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
      // 
      // replaceToolStripMenuItem2
      // 
      this.replaceToolStripMenuItem2.Name = "replaceToolStripMenuItem2";
      this.replaceToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
      // 
      // miCSharp
      // 
      this.miCSharp.Name = "miCSharp";
      this.miCSharp.Size = new System.Drawing.Size(32, 19);
      // 
      // cSharpbuiltinHighlighterToolStripMenuItem
      // 
      this.cSharpbuiltinHighlighterToolStripMenuItem.Name = "cSharpbuiltinHighlighterToolStripMenuItem";
      this.cSharpbuiltinHighlighterToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
      // 
      // miVB
      // 
      this.miVB.Name = "miVB";
      this.miVB.Size = new System.Drawing.Size(32, 19);
      // 
      // hTMLToolStripMenuItem
      // 
      this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
      this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
      // 
      // xmlToolStripMenuItem
      // 
      this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
      this.xmlToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
      // 
      // sQLToolStripMenuItem
      // 
      this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
      this.sQLToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
      // 
      // pHPToolStripMenuItem
      // 
      this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
      this.pHPToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
      // 
      // jSToolStripMenuItem
      // 
      this.jSToolStripMenuItem.Name = "jSToolStripMenuItem";
      this.jSToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
      // 
      // luaToolStripMenuItem
      // 
      this.luaToolStripMenuItem.Name = "luaToolStripMenuItem";
      this.luaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // clName
      // 
      this.clName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.clName.HeaderText = "Column1";
      this.clName.Name = "clName";
      this.clName.ReadOnly = true;
      // 
      // CSharpEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.CurrentTB);
      this.Controls.Add(this.toolStripContainer1);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.dgvObjectExplorer);
      this.Controls.Add(this.ssMain);
      this.Name = "CSharpEditor";
      this.Size = new System.Drawing.Size(901, 429);
      this.ssMain.ResumeLayout(false);
      this.ssMain.PerformLayout();
      this.tsMain.ResumeLayout(false);
      this.tsMain.PerformLayout();
      this.cmMain.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvObjectExplorer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.CurrentTB)).EndInit();
      this.toolStripContainer1.ContentPanel.ResumeLayout(false);
      this.toolStripContainer1.ContentPanel.PerformLayout();
      this.toolStripContainer1.ResumeLayout(false);
      this.toolStripContainer1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ContextMenuStrip cmMain;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemS2;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Timer tmUpdateInterface;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton undoStripButton;
        private System.Windows.Forms.ToolStripButton redoStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox tbFind;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemS3;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvObjectExplorer;
        private System.Windows.Forms.ToolStripButton backStripButton;
        private System.Windows.Forms.ToolStripButton forwardStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridViewImageColumn clImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.ToolStripStatusLabel lbWordUnderMouse;
        private System.Windows.Forms.ImageList ilAutocomplete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemS4;
        private System.Windows.Forms.ToolStripMenuItem autoIndentSelectedTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btInvisibleChars;
        private System.Windows.Forms.ToolStripButton btHighlightCurrentLine;
        private System.Windows.Forms.ToolStripMenuItem commentSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncommentSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneLinesAndCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton bookmarkPlusButton;
        private System.Windows.Forms.ToolStripButton bookmarkMinusButton;
        private System.Windows.Forms.ToolStripDropDownButton gotoButton;
        private System.Windows.Forms.ToolStripButton btShowFoldingLines;
        private System.Windows.Forms.ToolStripSplitButton btZoom;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem300;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem200;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem150;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem100;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem50;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem miLanguage;
    private System.Windows.Forms.ToolStripMenuItem miCSharp;
    private System.Windows.Forms.ToolStripMenuItem miVB;
    private System.Windows.Forms.ToolStripMenuItem collapseAllregionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exapndAllregionToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem increaseIndentSiftTabToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem decreaseIndentTabToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem miExport;
    private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem collapseSelectedBlockToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem goBackwardCtrlToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem goForwardCtrlShiftToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
    private System.Windows.Forms.ToolStripMenuItem autoIndentToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
    private System.Windows.Forms.ToolStripMenuItem goLeftBracketToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem goRightBracketToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem jSToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
    private System.Windows.Forms.ToolStripMenuItem miPrint;
    private System.Windows.Forms.ToolStripMenuItem miChangeColors;
    private System.Windows.Forms.ToolStripMenuItem cSharpbuiltinHighlighterToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem setSelectedAsReadonlyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem setSelectedAsWritableToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
    private System.Windows.Forms.ToolStripMenuItem startStopMacroRecordingToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem executeMacroToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem changeHotkeysToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rTFToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
    private System.Windows.Forms.ToolStripMenuItem commentSelectedLinesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem uncommentSelectedLinesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem luaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
    public FastColoredTextBox CurrentTB;
    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    public System.Windows.Forms.ToolStrip tsMain;
  }
}