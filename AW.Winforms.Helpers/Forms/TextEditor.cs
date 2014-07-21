using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using AW.Helper;

namespace AW.Winforms.Helpers.Forms
{
  /// <summary>
  ///   http://www.thecodingguys.net/blog/article/1038/2013/december/creating-a-texteditor-in-csharp-and-visual-basic
  /// </summary>
  public partial class TextEditor : FrmPersistantLocation
  {
    private int TabCount = 0;

    public TextEditor()
    {
      InitializeComponent();
    }

    public static string ShowTextEditorDialog(string text)
    {
      var textEditor = new TextEditor();
     // AWHelper.ShowForm(textEditor);
     // Application.DoEvents();
      textEditor.Open(text);
      if (textEditor.ShowDialog() == DialogResult.OK)
      {
        if (textEditor.tabControl1 != null && textEditor.tabControl1.TabPages.Count>0) 
          return textEditor.tabControl1.TabPages[0].Controls["Body"].Text;
      }
       
      return null;
    }

    #region Methods

    #region Tabs

    private void AddTab()
    {
      var Body = new RichTextBox();

      Body.Name = "Body";
      Body.Dock = DockStyle.Fill;
      Body.ContextMenuStrip = contextMenuStrip1;

      var NewPage = new TabPage();
      TabCount += 1;

      var DocumentText = "Document " + TabCount;
      NewPage.Name = DocumentText;
      NewPage.Text = DocumentText;
      NewPage.Controls.Add(Body);

      tabControl1.TabPages.Add(NewPage);
    }

    private void RemoveTab()
    {
      if (tabControl1.TabPages.Count != 1)
      {
        tabControl1.TabPages.Remove(tabControl1.SelectedTab);
      }
      else
      {
        tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        AddTab();
      }
    }

    private void RemoveAllTabs()
    {
      foreach (TabPage Page in tabControl1.TabPages)
      {
        tabControl1.TabPages.Remove(Page);
      }

      AddTab();
    }

    private void RemoveAllTabsButThis()
    {
      foreach (TabPage Page in tabControl1.TabPages)
      {
        if (Page.Name != tabControl1.SelectedTab.Name)
        {
          tabControl1.TabPages.Remove(Page);
        }
      }
    }

    #endregion

    #region SaveAndOpen

    private void Save()
    {
      if (Modal)
      {
        DialogResult = DialogResult.OK;
        Close();
      }
      else
      {
        saveFileDialog1.FileName = tabControl1.SelectedTab.Name;
        saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        saveFileDialog1.Filter = "RTF|.rtf";
        saveFileDialog1.Title = "Save";

        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
          if (saveFileDialog1.FileName.Length > 0)
          {
            GetCurrentDocument.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
          }
        }
      }

    }

    private void SaveAs()
    {
      saveFileDialog1.FileName = tabControl1.SelectedTab.Name;
      saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      saveFileDialog1.Filter = "Text Files|*.txt|VB Files|*.vb|C# Files|*.cs|All Files|*.*";
      saveFileDialog1.Title = "Save As";

      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        if (saveFileDialog1.FileName.Length > 0)
        {
          GetCurrentDocument.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }
      }
    }

    private void Open()
    {
      openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      openFileDialog1.Filter = "All Files|*.*|RTF|*.rtf|Text Files|*.txt|VB Files|*.vb|C# Files|*.cs";

      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        if (openFileDialog1.FileName.Length > 9)
        {
          var richTextBoxStreamType = Path.GetExtension(openFileDialog1.FileName).EqualsIgnoreCase("rtf")
            ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText;
          GetCurrentDocument.LoadFile(openFileDialog1.FileName, richTextBoxStreamType);
        }
      }
    }

    public void Open(string text)
    {
      AddTab();
      GetCurrentDocument.Text = text;
    }

    #endregion

    #region TextFunctions

    private void Undo()
    {
      GetCurrentDocument.Undo();
    }

    private void Redo()
    {
      GetCurrentDocument.Redo();
    }

    private void Cut()
    {
      GetCurrentDocument.Cut();
    }

    private void Copy()
    {
      GetCurrentDocument.Copy();
    }

    private void Paste()
    {
      GetCurrentDocument.Paste();
    }

    private void SelectAll()
    {
      GetCurrentDocument.SelectAll();
    }

    #endregion

    #region General

    private void GetFontCollection()
    {
      var InsFonts = new InstalledFontCollection();

      foreach (var item in InsFonts.Families)
      {
        toolStripComboBox1.Items.Add(item.Name);
      }
      toolStripComboBox1.SelectedIndex = 0;
    }

    private void PopulateFontSizes()
    {
      for (var i = 1; i <= 75; i++)
      {
        toolStripComboBox2.Items.Add(i);
      }

      toolStripComboBox2.SelectedIndex = 11;
    }

    #endregion

    #endregion

    #region Properties

    private RichTextBox GetCurrentDocument
    {
      get { return (RichTextBox) tabControl1.SelectedTab.Controls["Body"]; }
    }

    #endregion

    #region EventBindings

    private void AdvancedTextEditor_Load(object sender, EventArgs e)
    {
      if (TabCount==0)
        AddTab();
      GetFontCollection();
      PopulateFontSizes();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (GetCurrentDocument.Text.Length > 0)
      {
        toolStripStatusLabel1.Text = GetCurrentDocument.Text.Length.ToString();
      }
    }

    #region Menu

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AddTab();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Open();
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Save();
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveAs();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void undoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Undo();
    }

    private void redoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Redo();
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Cut();
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Copy();
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Paste();
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SelectAll();
    }


    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RemoveTab();
    }

    #endregion

    #region Toolbar

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      var BoldFont = new Font(GetCurrentDocument.SelectionFont.FontFamily, GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Bold);
      var RegularFont = new Font(GetCurrentDocument.SelectionFont.FontFamily, GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Regular);

      if (GetCurrentDocument.SelectionFont.Bold)
      {
        GetCurrentDocument.SelectionFont = RegularFont;
      }
      else
      {
        GetCurrentDocument.SelectionFont = BoldFont;
      }
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
      var ItalicFont = new Font(GetCurrentDocument.SelectionFont.FontFamily, GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Italic);
      var RegularFont = new Font(GetCurrentDocument.SelectionFont.FontFamily, GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Regular);

      if (GetCurrentDocument.SelectionFont.Italic)
      {
        GetCurrentDocument.SelectionFont = RegularFont;
      }
      else
      {
        GetCurrentDocument.SelectionFont = ItalicFont;
      }
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      var UnderlineFont = new Font(GetCurrentDocument.SelectionFont.FontFamily, GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Underline);
      var RegularFont = new Font(GetCurrentDocument.SelectionFont.FontFamily, GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Regular);

      if (GetCurrentDocument.SelectionFont.Underline)
      {
        GetCurrentDocument.SelectionFont = RegularFont;
      }
      else
      {
        GetCurrentDocument.SelectionFont = UnderlineFont;
      }
    }

    private void toolStripButton4_Click(object sender, EventArgs e)
    {
      var Strikeout = new Font(GetCurrentDocument.SelectionFont.FontFamily, GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Strikeout);
      var RegularFont = new Font(GetCurrentDocument.SelectionFont.FontFamily, GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Regular);

      if (GetCurrentDocument.SelectionFont.Strikeout)
      {
        GetCurrentDocument.SelectionFont = RegularFont;
      }
      else
      {
        GetCurrentDocument.SelectionFont = Strikeout;
      }
    }


    private void toolStripButton5_Click(object sender, EventArgs e)
    {
      GetCurrentDocument.SelectedText = GetCurrentDocument.SelectedText.ToUpper();
    }

    private void toolStripButton6_Click(object sender, EventArgs e)
    {
      GetCurrentDocument.SelectedText = GetCurrentDocument.SelectedText.ToLower();
    }

    private void toolStripButton7_Click(object sender, EventArgs e)
    {
      var NewFontSize = GetCurrentDocument.SelectionFont.SizeInPoints + 2;

      var NewSize = new Font(GetCurrentDocument.SelectionFont.Name, NewFontSize, GetCurrentDocument.SelectionFont.Style);

      GetCurrentDocument.SelectionFont = NewSize;
    }

    private void toolStripButton8_Click(object sender, EventArgs e)
    {
      var NewFontSize = GetCurrentDocument.SelectionFont.SizeInPoints - 2;

      var NewSize = new Font(GetCurrentDocument.SelectionFont.Name, NewFontSize, GetCurrentDocument.SelectionFont.Style);

      GetCurrentDocument.SelectionFont = NewSize;
    }

    private void toolStripButton9_Click(object sender, EventArgs e)
    {
      if (colorDialog1.ShowDialog() == DialogResult.OK)
      {
        GetCurrentDocument.SelectionColor = colorDialog1.Color;
      }
    }

    private void HighlighGreen_Click(object sender, EventArgs e)
    {
      GetCurrentDocument.SelectionBackColor = Color.LightGreen;
    }

    private void HighlighOrange_Click(object sender, EventArgs e)
    {
      GetCurrentDocument.SelectionBackColor = Color.Orange;
    }

    private void HighlighYellow_Click(object sender, EventArgs e)
    {
      GetCurrentDocument.SelectionBackColor = Color.Yellow;
    }

    private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      var NewFont = new Font(toolStripComboBox1.SelectedItem.ToString(), GetCurrentDocument.SelectionFont.Size, GetCurrentDocument.SelectionFont.Style);

      GetCurrentDocument.SelectionFont = NewFont;
    }

    private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      float NewSize;

      Single.TryParse(toolStripComboBox2.SelectedItem.ToString(), out NewSize);

      var NewFont = new Font(GetCurrentDocument.SelectionFont.Name, NewSize, GetCurrentDocument.SelectionFont.Style);

      GetCurrentDocument.SelectionFont = NewFont;
    }

    #endregion

    #region LeftToolStrip

    private void newToolStripButton_Click(object sender, EventArgs e)
    {
      AddTab();
    }

    private void RemoveTabToolStripButton_Click(object sender, EventArgs e)
    {
      RemoveTab();
    }

    private void openToolStripButton_Click(object sender, EventArgs e)
    {
      Open();
    }

    private void saveToolStripButton_Click(object sender, EventArgs e)
    {
      Save();
    }

    private void cutToolStripButton_Click(object sender, EventArgs e)
    {
      Cut();
    }

    private void copyToolStripButton_Click(object sender, EventArgs e)
    {
      Copy();
    }

    private void pasteToolStripButton_Click(object sender, EventArgs e)
    {
      Paste();
    }

    #endregion

    #region ContextMenu

    private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Undo();
    }

    private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Redo();
    }

    private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Cut();
    }

    private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Copy();
    }

    private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Paste();
    }

    private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Save();
    }

    private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RemoveAllTabs();
    }

    private void closeAllButThisToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RemoveAllTabsButThis();
    }

    #endregion

    #endregion
  }
}