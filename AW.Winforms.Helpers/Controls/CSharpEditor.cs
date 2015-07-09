using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using AW.Winforms.Helpers.Properties;
using FarsiLibrary.Win;
using FastColoredTextBoxNS;

namespace AW.Winforms.Helpers.Controls
{
  /// <summary>
  ///   http://www.codeproject.com/Articles/161871/Fast-Colored-TextBox-for-syntax-highlighting
  /// </summary>
  public partial class CSharpEditor : UserControl
  {
    private readonly string[] keywords = {"abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while", "add", "alias", "ascending", "descending", "dynamic", "from", "get", "global", "group", "into", "join", "let", "orderby", "partial", "remove", "select", "set", "value", "var", "where", "yield"};
    private readonly string[] methods = {"Equals()", "GetHashCode()", "GetType()", "ToString()"};
    private readonly string[] snippets = {"if(^)\n{\n;\n}", "if(^)\n{\n;\n}\nelse\n{\n;\n}", "for(^;;)\n{\n;\n}", "while(^)\n{\n;\n}", "do\n{\n^;\n}while();", "switch(^)\n{\ncase : break;\n}"};

    private readonly string[] declarationSnippets =
    {
      "public class ^\n{\n}", "private class ^\n{\n}", "internal class ^\n{\n}",
      "public struct ^\n{\n;\n}", "private struct ^\n{\n;\n}", "internal struct ^\n{\n;\n}",
      "public void ^()\n{\n;\n}", "private void ^()\n{\n;\n}", "internal void ^()\n{\n;\n}", "protected void ^()\n{\n;\n}",
      "public ^{ get; set; }", "private ^{ get; set; }", "internal ^{ get; set; }", "protected ^{ get; set; }"
    };

    private readonly Style invisibleCharsStyle = new InvisibleCharsRenderer(Pens.Gray);
    private readonly Color currentLineColor = Color.FromArgb(100, 210, 210, 255);
    private readonly Color changedLineColor = Color.FromArgb(255, 230, 230, 255);


    public CSharpEditor()
    {
      InitializeComponent();

      //init menu images
      var resources = new ComponentResourceManager(typeof (CSharpEditor));
      copyToolStripMenuItem.Image = ((Image) (resources.GetObject("copyToolStripButton.Image")));
      cutToolStripMenuItem.Image = ((Image) (resources.GetObject("cutToolStripButton.Image")));
      pasteToolStripMenuItem.Image = ((Image) (resources.GetObject("pasteToolStripButton.Image")));
    }


    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CreateTab(null);
    }

    private readonly Style sameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(50, Color.Gray)));

    public FastColoredTextBox CreateTab(string fileName = null)
    {
      try
      {
        var tb = CurrentTB;
        tb.Font = new Font("Consolas", 9.75f);
        tb.ContextMenuStrip = cmMain;
        tb.Dock = DockStyle.Fill;
        tb.BorderStyle = BorderStyle.Fixed3D;
        //tb.VirtualSpace = true;
        tb.LeftPadding = 17;
        tb.Language = Language.CSharp;
        tb.AddStyle(sameWordsStyle); //same words style
        if (fileName != null)
          tb.OpenFile(fileName);
        tb.Tag = new TbInfo();
        tb.Focus();
        tb.DelayedTextChangedInterval = 1000;
        tb.DelayedEventsInterval = 500;
        tb.TextChangedDelayed += new EventHandler<TextChangedEventArgs>(tb_TextChangedDelayed);
        tb.SelectionChangedDelayed += new EventHandler(tb_SelectionChangedDelayed);
        tb.KeyDown += new KeyEventHandler(tb_KeyDown);
        tb.MouseMove += new MouseEventHandler(tb_MouseMove);
        tb.ChangedLineColor = changedLineColor;
        if (btHighlightCurrentLine.Checked)
          tb.CurrentLineColor = currentLineColor;
        tb.ShowFoldingLines = btShowFoldingLines.Checked;
        tb.HighlightingRangeType = HighlightingRangeType.VisibleRange;
        //create autocomplete popup menu
        var popupMenu = new AutocompleteMenu(tb);
        popupMenu.Items.ImageList = ilAutocomplete;
        popupMenu.Opening += new EventHandler<CancelEventArgs>(popupMenu_Opening);
        BuildAutocompleteMenu(popupMenu);
        (tb.Tag as TbInfo).popupMenu = popupMenu;
        return tb;
      }
      catch (Exception ex)
      {
        if (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
          return CreateTab(fileName);
      }
      return null;
    }

    private void popupMenu_Opening(object sender, CancelEventArgs e)
    {
      //---block autocomplete menu for comments
      //get index of green style (used for comments)
      var iGreenStyle = CurrentTB.GetStyleIndex(CurrentTB.SyntaxHighlighter.GreenStyle);
      if (iGreenStyle >= 0)
        if (CurrentTB.Selection.Start.iChar > 0)
        {
          //current char (before caret)
          var c = CurrentTB[CurrentTB.Selection.Start.iLine][CurrentTB.Selection.Start.iChar - 1];
          //green Style
          var greenStyleIndex = Range.ToStyleIndex(iGreenStyle);
          //if char contains green style then block popup menu
          if ((c.style & greenStyleIndex) != 0)
            e.Cancel = true;
        }
    }

    private void BuildAutocompleteMenu(AutocompleteMenu popupMenu)
    {
      var items = new List<AutocompleteItem>();

      foreach (var item in snippets)
        items.Add(new SnippetAutocompleteItem(item) {ImageIndex = 1});
      foreach (var item in declarationSnippets)
        items.Add(new DeclarationSnippet(item) {ImageIndex = 0});
      foreach (var item in methods)
        items.Add(new MethodAutocompleteItem(item) {ImageIndex = 2});
      foreach (var item in keywords)
        items.Add(new AutocompleteItem(item));

      items.Add(new InsertSpaceSnippet());
      items.Add(new InsertSpaceSnippet(@"^(\w+)([=<>!:]+)(\w+)$"));
      items.Add(new InsertEnterSnippet());

      //set as autocomplete source
      popupMenu.Items.SetAutocompleteItems(items);
      popupMenu.SearchPattern = @"[\w\.:=!<>]";
    }

    private void tb_MouseMove(object sender, MouseEventArgs e)
    {
      var tb = sender as FastColoredTextBox;
      var place = tb.PointToPlace(e.Location);
      var r = new Range(tb, place, place);

      var text = r.GetFragment("[a-zA-Z]").Text;
      lbWordUnderMouse.Text = text;
    }

    private void tb_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Modifiers == Keys.Control && e.KeyCode == Keys.OemMinus)
      {
        NavigateBackward();
        e.Handled = true;
      }

      if (e.Modifiers == (Keys.Control | Keys.Shift) && e.KeyCode == Keys.OemMinus)
      {
        NavigateForward();
        e.Handled = true;
      }

      if (e.KeyData == (Keys.K | Keys.Control))
      {
        //forced show (MinFragmentLength will be ignored)
        (CurrentTB.Tag as TbInfo).popupMenu.Show(true);
        e.Handled = true;
      }
    }

    private void tb_SelectionChangedDelayed(object sender, EventArgs e)
    {
      var tb = sender as FastColoredTextBox;
      //remember last visit time
      if (tb.Selection.IsEmpty && tb.Selection.Start.iLine < tb.LinesCount)
      {
        if (lastNavigatedDateTime != tb[tb.Selection.Start.iLine].LastVisit)
        {
          tb[tb.Selection.Start.iLine].LastVisit = DateTime.Now;
          lastNavigatedDateTime = tb[tb.Selection.Start.iLine].LastVisit;
        }
      }

      //highlight same words
      tb.VisibleRange.ClearStyle(sameWordsStyle);
      if (!tb.Selection.IsEmpty)
        return; //user selected diapason
      //get fragment around caret
      var fragment = tb.Selection.GetFragment(@"\w");
      var text = fragment.Text;
      if (text.Length == 0)
        return;
      //highlight same words
      var ranges = tb.VisibleRange.GetRanges("\\b" + text + "\\b").ToArray();

      if (ranges.Length > 1)
        foreach (var r in ranges)
          r.SetStyle(sameWordsStyle);
    }

    private void tb_TextChangedDelayed(object sender, TextChangedEventArgs e)
    {
      var tb = (sender as FastColoredTextBox);
      //rebuild object explorer
      var text = (sender as FastColoredTextBox).Text;
      ThreadPool.QueueUserWorkItem(
        (o) => ReBuildObjectExplorer(text)
        );

      //show invisible chars
      HighlightInvisibleChars(e.ChangedRange);
    }

    private void HighlightInvisibleChars(Range range)
    {
      range.ClearStyle(invisibleCharsStyle);
      if (btInvisibleChars.Checked)
        range.SetStyle(invisibleCharsStyle, @".$|.\r\n|\s");
    }

    private List<ExplorerItem> explorerList = new List<ExplorerItem>();

    private void ReBuildObjectExplorer(string text)
    {
      try
      {
        var list = new List<ExplorerItem>();
        var lastClassIndex = -1;
        //find classes, methods and properties
        var regex = new Regex(@"^(?<range>[\w\s]+\b(class|struct|enum|interface)\s+[\w<>,\s]+)|^\s*(public|private|internal|protected)[^\n]+(\n?\s*{|;)?", RegexOptions.Multiline);
        foreach (Match r in regex.Matches(text))
          try
          {
            var s = r.Value;
            var i = s.IndexOfAny(new char[] {'=', '{', ';'});
            if (i >= 0)
              s = s.Substring(0, i);
            s = s.Trim();

            var item = new ExplorerItem() {title = s, position = r.Index};
            if (Regex.IsMatch(item.title, @"\b(class|struct|enum|interface)\b"))
            {
              item.title = item.title.Substring(item.title.LastIndexOf(' ')).Trim();
              item.type = ExplorerItemType.Class;
              list.Sort(lastClassIndex + 1, list.Count - (lastClassIndex + 1), new ExplorerItemComparer());
              lastClassIndex = list.Count;
            }
            else if (item.title.Contains(" event "))
            {
              var ii = item.title.LastIndexOf(' ');
              item.title = item.title.Substring(ii).Trim();
              item.type = ExplorerItemType.Event;
            }
            else if (item.title.Contains("("))
            {
              var parts = item.title.Split('(');
              item.title = parts[0].Substring(parts[0].LastIndexOf(' ')).Trim() + "(" + parts[1];
              item.type = ExplorerItemType.Method;
            }
            else if (item.title.EndsWith("]"))
            {
              var parts = item.title.Split('[');
              if (parts.Length < 2) continue;
              item.title = parts[0].Substring(parts[0].LastIndexOf(' ')).Trim() + "[" + parts[1];
              item.type = ExplorerItemType.Method;
            }
            else
            {
              var ii = item.title.LastIndexOf(' ');
              item.title = item.title.Substring(ii).Trim();
              item.type = ExplorerItemType.Property;
            }
            list.Add(item);
          }
          catch
          {
            ;
          }

        list.Sort(lastClassIndex + 1, list.Count - (lastClassIndex + 1), new ExplorerItemComparer());

        BeginInvoke(
          new Action(() =>
          {
            explorerList = list;
            dgvObjectExplorer.RowCount = explorerList.Count;
            dgvObjectExplorer.Invalidate();
          })
          );
      }
      catch
      {
        ;
      }
    }

    private enum ExplorerItemType
    {
      Class,
      Method,
      Property,
      Event
    }

    private class ExplorerItem
    {
      public ExplorerItemType type;
      public string title;
      public int position;
    }

    private class ExplorerItemComparer : IComparer<ExplorerItem>
    {
      public int Compare(ExplorerItem x, ExplorerItem y)
      {
        return x.title.CompareTo(y.title);
      }
    }

  

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.Cut();
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.Copy();
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.Paste();
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.Selection.SelectAll();
    }

    private void undoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (CurrentTB.UndoEnabled)
        CurrentTB.Undo();
    }

    private void redoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (CurrentTB.RedoEnabled)
        CurrentTB.Redo();
    }

    private void tmUpdateInterface_Tick(object sender, EventArgs e)
    {
      try
      {
        if (CurrentTB != null )
        {
          var tb = CurrentTB;
          undoStripButton.Enabled = undoToolStripMenuItem.Enabled = tb.UndoEnabled;
          redoStripButton.Enabled = redoToolStripMenuItem.Enabled = tb.RedoEnabled;

          pasteToolStripButton.Enabled = pasteToolStripMenuItem.Enabled = true;
          cutToolStripButton.Enabled = cutToolStripMenuItem.Enabled =
            copyToolStripButton.Enabled = copyToolStripMenuItem.Enabled = !tb.Selection.IsEmpty;
        }
        else
        {
          cutToolStripButton.Enabled = cutToolStripMenuItem.Enabled =
            copyToolStripButton.Enabled = copyToolStripMenuItem.Enabled = false;
          pasteToolStripButton.Enabled = pasteToolStripMenuItem.Enabled = false;
          undoStripButton.Enabled = undoToolStripMenuItem.Enabled = false;
          redoStripButton.Enabled = redoToolStripMenuItem.Enabled = false;
          dgvObjectExplorer.RowCount = 0;
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    private bool tbFindChanged = false;

    private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == '\r' && CurrentTB != null)
      {
        var r = tbFindChanged ? CurrentTB.Range.Clone() : CurrentTB.Selection.Clone();
        tbFindChanged = false;
        r.End = new Place(CurrentTB[CurrentTB.LinesCount - 1].Count, CurrentTB.LinesCount - 1);
        var pattern = Regex.Escape(tbFind.Text);
        foreach (var found in r.GetRanges(pattern))
        {
          found.Inverse();
          CurrentTB.Selection = found;
          CurrentTB.DoSelectionVisible();
          return;
        }
        MessageBox.Show("Not found.");
      }
      else
        tbFindChanged = true;
    }

    private void findToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.ShowFindDialog();
    }

    private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.ShowReplaceDialog();
    }

    private void PowerfulCSharpEditor_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void dgvObjectExplorer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (CurrentTB != null)
      {
        var item = explorerList[e.RowIndex];
        CurrentTB.GoEnd();
        CurrentTB.SelectionStart = item.position;
        CurrentTB.DoSelectionVisible();
        CurrentTB.Focus();
      }
    }

    private void dgvObjectExplorer_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
    {
      try
      {
        var item = explorerList[e.RowIndex];
        if (e.ColumnIndex == 1)
          e.Value = item.title;
        else
          switch (item.type)
          {
            case ExplorerItemType.Class:
              e.Value = Resources.class_libraries;
              return;
            case ExplorerItemType.Method:
              e.Value = Resources.box;
              return;
            case ExplorerItemType.Event:
              e.Value = Resources.lightning;
              return;
            case ExplorerItemType.Property:
              e.Value = Resources.property;
              return;
          }
      }
      catch
      {
        ;
      }
    }

    private void tsFiles_TabStripItemSelectionChanged(TabStripItemChangedEventArgs e)
    {
      if (CurrentTB != null)
      {
        CurrentTB.Focus();
        var text = CurrentTB.Text;
        ThreadPool.QueueUserWorkItem(
          (o) => ReBuildObjectExplorer(text)
          );
      }
    }

    private void backStripButton_Click(object sender, EventArgs e)
    {
      NavigateBackward();
    }

    private void forwardStripButton_Click(object sender, EventArgs e)
    {
      NavigateForward();
    }

    private DateTime lastNavigatedDateTime = DateTime.Now;

    private bool NavigateBackward()
    {
      var max = new DateTime();
      var iLine = -1;
      FastColoredTextBox tb = CurrentTB;

      {
        var t = CurrentTB;
        for (var i = 0; i < t.LinesCount; i++)
          if (t[i].LastVisit < lastNavigatedDateTime && t[i].LastVisit > max)
          {
            max = t[i].LastVisit;
            iLine = i;
            tb = t;
          }
      }
      if (iLine >= 0)
      {
        
        tb.Navigate(iLine);
        lastNavigatedDateTime = tb[iLine].LastVisit;
        Console.WriteLine("Backward: " + lastNavigatedDateTime);
        tb.Focus();
        tb.Invalidate();
        return true;
      }
      else
        return false;
    }

    private bool NavigateForward()
    {
      var min = DateTime.Now;
      var iLine = -1;
      FastColoredTextBox tb = CurrentTB;
      {
        var t = CurrentTB;
        for (var i = 0; i < t.LinesCount; i++)
          if (t[i].LastVisit > lastNavigatedDateTime && t[i].LastVisit < min)
          {
            min = t[i].LastVisit;
            iLine = i;
            tb = t;
          }
      }
      if (iLine >= 0)
      {
        tb.Navigate(iLine);
        lastNavigatedDateTime = tb[iLine].LastVisit;
        Console.WriteLine("Forward: " + lastNavigatedDateTime);
        tb.Focus();
        tb.Invalidate();
        return true;
      }
      else
        return false;
    }

    /// <summary>
    ///   This item appears when any part of snippet text is typed
    /// </summary>
    private class DeclarationSnippet : SnippetAutocompleteItem
    {
      public DeclarationSnippet(string snippet)
        : base(snippet)
      {
      }

      public override CompareResult Compare(string fragmentText)
      {
        var pattern = Regex.Escape(fragmentText);
        if (Regex.IsMatch(Text, "\\b" + pattern, RegexOptions.IgnoreCase))
          return CompareResult.Visible;
        return CompareResult.Hidden;
      }
    }

    /// <summary>
    ///   Divides numbers and words: "123AND456" -> "123 AND 456"
    ///   Or "i=2" -> "i = 2"
    /// </summary>
    private class InsertSpaceSnippet : AutocompleteItem
    {
      private readonly string pattern;

      public InsertSpaceSnippet(string pattern)
        : base("")
      {
        this.pattern = pattern;
      }

      public InsertSpaceSnippet()
        : this(@"^(\d+)([a-zA-Z_]+)(\d*)$")
      {
      }

      public override CompareResult Compare(string fragmentText)
      {
        if (Regex.IsMatch(fragmentText, pattern))
        {
          Text = InsertSpaces(fragmentText);
          if (Text != fragmentText)
            return CompareResult.Visible;
        }
        return CompareResult.Hidden;
      }

      public string InsertSpaces(string fragment)
      {
        var m = Regex.Match(fragment, pattern);
        if (m == null)
          return fragment;
        if (m.Groups[1].Value == "" && m.Groups[3].Value == "")
          return fragment;
        return (m.Groups[1].Value + " " + m.Groups[2].Value + " " + m.Groups[3].Value).Trim();
      }

      public override string ToolTipTitle
      {
        get { return Text; }
      }
    }

    /// <summary>
    ///   Inerts line break after '}'
    /// </summary>
    private class InsertEnterSnippet : AutocompleteItem
    {
      private Place enterPlace = Place.Empty;

      public InsertEnterSnippet()
        : base("[Line break]")
      {
      }

      public override CompareResult Compare(string fragmentText)
      {
        var r = Parent.Fragment.Clone();
        while (r.Start.iChar > 0)
        {
          if (r.CharBeforeStart == '}')
          {
            enterPlace = r.Start;
            return CompareResult.Visible;
          }

          r.GoLeftThroughFolded();
        }

        return CompareResult.Hidden;
      }

      public override string GetTextForReplace()
      {
        //extend range
        var r = Parent.Fragment;
        var end = r.End;
        r.Start = enterPlace;
        r.End = r.End;
        //insert line break
        return Environment.NewLine + r.Text;
      }

      public override void OnSelected(AutocompleteMenu popupMenu, SelectedEventArgs e)
      {
        base.OnSelected(popupMenu, e);
        if (Parent.Fragment.tb.AutoIndent)
          Parent.Fragment.tb.DoAutoIndent();
      }

      public override string ToolTipTitle
      {
        get { return "Insert line break after '}'"; }
      }
    }

    private void autoIndentSelectedTextToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.DoAutoIndent();
    }

    private void btInvisibleChars_Click(object sender, EventArgs e)
    {
        HighlightInvisibleChars(CurrentTB.Range);
      if (CurrentTB != null)
        CurrentTB.Invalidate();
    }

    private void btHighlightCurrentLine_Click(object sender, EventArgs e)
    {
      {
        if (btHighlightCurrentLine.Checked)
          CurrentTB.CurrentLineColor = currentLineColor;
        else
          CurrentTB.CurrentLineColor = Color.Transparent;
      }
      if (CurrentTB != null)
        CurrentTB.Invalidate();
    }

    private void commentSelectedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.InsertLinePrefix("//");
    }

    private void uncommentSelectedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.RemoveLinePrefix("//");
    }

    private void cloneLinesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //expand selection
      CurrentTB.Selection.Expand();
      //get text of selected lines
      var text = Environment.NewLine + CurrentTB.Selection.Text;
      //move caret to end of selected lines
      CurrentTB.Selection.Start = CurrentTB.Selection.End;
      //insert text
      CurrentTB.InsertText(text);
    }

    private void cloneLinesAndCommentToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //start autoUndo block
      CurrentTB.BeginAutoUndo();
      //expand selection
      CurrentTB.Selection.Expand();
      //get text of selected lines
      var text = Environment.NewLine + CurrentTB.Selection.Text;
      //comment lines
      CurrentTB.InsertLinePrefix("//");
      //move caret to end of selected lines
      CurrentTB.Selection.Start = CurrentTB.Selection.End;
      //insert text
      CurrentTB.InsertText(text);
      //end of autoUndo block
      CurrentTB.EndAutoUndo();
    }

    private void bookmarkPlusButton_Click(object sender, EventArgs e)
    {
      if (CurrentTB == null)
        return;
      CurrentTB.BookmarkLine(CurrentTB.Selection.Start.iLine);
    }

    private void bookmarkMinusButton_Click(object sender, EventArgs e)
    {
      if (CurrentTB == null)
        return;
      CurrentTB.UnbookmarkLine(CurrentTB.Selection.Start.iLine);
    }

    private void gotoButton_DropDownOpening(object sender, EventArgs e)
    {
      gotoButton.DropDownItems.Clear();

      {
        var tb = CurrentTB;
        foreach (var bookmark in tb.Bookmarks)
        {
          var item = gotoButton.DropDownItems.Add(bookmark.Name + " [" + Path.GetFileNameWithoutExtension("tab.Tag" as String) + "]");
          item.Tag = bookmark;
          item.Click += (o, a) =>
          {
            var b = (Bookmark) (o as ToolStripItem).Tag;
            try
            {
              CurrentTB = b.TB;
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
              return;
            }
            b.DoVisible();
          };
        }
      }
    }

    private void btShowFoldingLines_Click(object sender, EventArgs e)
    {

        CurrentTB.ShowFoldingLines = btShowFoldingLines.Checked;
      if (CurrentTB != null)
        CurrentTB.Invalidate();
    }

    private void Zoom_click(object sender, EventArgs e)
    {
      if (CurrentTB != null)
        CurrentTB.Zoom = int.Parse((sender as ToolStripItem).Tag.ToString());
    }

    #region MenuStrip

    private void collapseSelectedBlockToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.CollapseBlock(CurrentTB.Selection.Start.iLine, CurrentTB.Selection.End.iLine);
    }

    private void collapseAllregionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //this example shows how to collapse all #region blocks (C#)

      for (int iLine = 0; iLine < CurrentTB.LinesCount; iLine++)
      {
        if (CurrentTB[iLine].FoldingStartMarker == @"#region\b")//marker @"#region\b" was used in SetFoldingMarkers()
          CurrentTB.CollapseFoldingBlock(iLine);
      }
    }

    private void exapndAllregionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //this example shows how to expand all #region blocks (C#)

      for (int iLine = 0; iLine < CurrentTB.LinesCount; iLine++)
      {
        if (CurrentTB[iLine].FoldingStartMarker == @"#region\b")//marker @"#region\b" was used in SetFoldingMarkers()
          CurrentTB.ExpandFoldedBlock(iLine);
      }
    }

    private void increaseIndentSiftTabToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.IncreaseIndent();
    }

    private void decreaseIndentTabToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.DecreaseIndent();
    }

    private void hTMLToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      SaveFileDialog sfd = new SaveFileDialog();
      sfd.Filter = "HTML with <PRE> tag|*.html|HTML without <PRE> tag|*.html";
      if (sfd.ShowDialog() == DialogResult.OK)
      {
        string html = "";

        if (sfd.FilterIndex == 1)
        {
          html = CurrentTB.Html;
        }
        if (sfd.FilterIndex == 2)
        {

          ExportToHTML exporter = new ExportToHTML();
          exporter.UseBr = true;
          exporter.UseNbsp = false;
          exporter.UseForwardNbsp = true;
          exporter.UseStyleTag = true;
          html = exporter.GetHtml(CurrentTB);
        }
        File.WriteAllText(sfd.FileName, html);
      }
    }

    MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));

    private void fctb_SelectionChangedDelayed(object sender, EventArgs e)
    {
      CurrentTB.VisibleRange.ClearStyle(SameWordsStyle);
      if (!CurrentTB.Selection.IsEmpty)
        return;//user selected diapason

      //get fragment around caret
      var fragment = CurrentTB.Selection.GetFragment(@"\w");
      string text = fragment.Text;
      if (text.Length == 0)
        return;
      //highlight same words
      var ranges = CurrentTB.VisibleRange.GetRanges("\\b" + text + "\\b").ToArray();
      if (ranges.Length > 1)
        foreach (var r in ranges)
          r.SetStyle(SameWordsStyle);
    }

    private void goForwardCtrlShiftToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.NavigateForward();
    }

    private void goBackwardCtrlToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.NavigateBackward();
    }

    private void autoIndentToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.DoAutoIndent();
    }

    const int maxBracketSearchIterations = 2000;

    void GoLeftBracket(FastColoredTextBox tb, char leftBracket, char rightBracket)
    {
      Range range = tb.Selection.Clone();//need to clone because we will move caret
      int counter = 0;
      int maxIterations = maxBracketSearchIterations;
      while (range.GoLeftThroughFolded())//move caret left
      {
        if (range.CharAfterStart == leftBracket) counter++;
        if (range.CharAfterStart == rightBracket) counter--;
        if (counter == 1)
        {
          //found
          tb.Selection.Start = range.Start;
          tb.DoSelectionVisible();
          break;
        }
        //
        maxIterations--;
        if (maxIterations <= 0) break;
      }
      tb.Invalidate();
    }

    void GoRightBracket(FastColoredTextBox tb, char leftBracket, char rightBracket)
    {
      var range = tb.Selection.Clone();//need clone because we will move caret
      int counter = 0;
      int maxIterations = maxBracketSearchIterations;
      do
      {
        if (range.CharAfterStart == leftBracket) counter++;
        if (range.CharAfterStart == rightBracket) counter--;
        if (counter == -1)
        {
          //found
          tb.Selection.Start = range.Start;
          tb.Selection.GoRightThroughFolded();
          tb.DoSelectionVisible();
          break;
        }
        //
        maxIterations--;
        if (maxIterations <= 0) break;
      } while (range.GoRightThroughFolded());//move caret right

      tb.Invalidate();
    }

    private void goLeftBracketToolStripMenuItem_Click(object sender, EventArgs e)
    {
      GoLeftBracket(CurrentTB, '{', '}');
    }

    private void goRightBracketToolStripMenuItem_Click(object sender, EventArgs e)
    {
      GoRightBracket(CurrentTB, '{', '}');
    }

    private void fctb_AutoIndentNeeded(object sender, AutoIndentEventArgs args)
    {
      //block {}
      if (Regex.IsMatch(args.LineText, @"^[^""']*\{.*\}[^""']*$"))
        return;
      //start of block {}
      if (Regex.IsMatch(args.LineText, @"^[^""']*\{"))
      {
        args.ShiftNextLines = args.TabLength;
        return;
      }
      //end of block {}
      if (Regex.IsMatch(args.LineText, @"}[^""']*$"))
      {
        args.Shift = -args.TabLength;
        args.ShiftNextLines = -args.TabLength;
        return;
      }
      //label
      if (Regex.IsMatch(args.LineText, @"^\s*\w+\s*:\s*($|//)") &&
          !Regex.IsMatch(args.LineText, @"^\s*default\s*:"))
      {
        args.Shift = -args.TabLength;
        return;
      }
      //some statements: case, default
      if (Regex.IsMatch(args.LineText, @"^\s*(case|default)\b.*:\s*($|//)"))
      {
        args.Shift = -args.TabLength / 2;
        return;
      }
      //is unclosed operator in previous line ?
      if (Regex.IsMatch(args.PrevLineText, @"^\s*(if|for|foreach|while|[\}\s]*else)\b[^{]*$"))
        if (!Regex.IsMatch(args.PrevLineText, @"(;\s*$)|(;\s*//)"))//operator is unclosed
        {
          args.Shift = args.TabLength;
          return;
        }
    }

    private void miPrint_Click(object sender, EventArgs e)
    {
      CurrentTB.Print(new PrintDialogSettings() { ShowPrintPreviewDialog = true });
    }

    Random rnd = new Random();

    private void miChangeColors_Click(object sender, EventArgs e)
    {
      var styles = new Style[] { CurrentTB.SyntaxHighlighter.BlueBoldStyle, CurrentTB.SyntaxHighlighter.BlueStyle, CurrentTB.SyntaxHighlighter.BoldStyle, CurrentTB.SyntaxHighlighter.BrownStyle, CurrentTB.SyntaxHighlighter.GrayStyle, CurrentTB.SyntaxHighlighter.GreenStyle, CurrentTB.SyntaxHighlighter.MagentaStyle, CurrentTB.SyntaxHighlighter.MaroonStyle, CurrentTB.SyntaxHighlighter.RedStyle };
      CurrentTB.SyntaxHighlighter.AttributeStyle = styles[rnd.Next(styles.Length)];
      CurrentTB.SyntaxHighlighter.ClassNameStyle = styles[rnd.Next(styles.Length)];
      CurrentTB.SyntaxHighlighter.CommentStyle = styles[rnd.Next(styles.Length)];
      CurrentTB.SyntaxHighlighter.CommentTagStyle = styles[rnd.Next(styles.Length)];
      CurrentTB.SyntaxHighlighter.KeywordStyle = styles[rnd.Next(styles.Length)];
      CurrentTB.SyntaxHighlighter.NumberStyle = styles[rnd.Next(styles.Length)];
      CurrentTB.SyntaxHighlighter.StringStyle = styles[rnd.Next(styles.Length)];

      CurrentTB.OnSyntaxHighlight(new TextChangedEventArgs(CurrentTB.Range));
    }

    private void setSelectedAsReadonlyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.Selection.ReadOnly = true;
    }

    private void setSelectedAsWritableToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.Selection.ReadOnly = false;
    }

    private void startStopMacroRecordingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.MacrosManager.IsRecording = !CurrentTB.MacrosManager.IsRecording;
    }

    private void executeMacroToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.MacrosManager.ExecuteMacros();
    }

    private void changeHotkeysToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var form = new HotkeysEditorForm(CurrentTB.HotkeysMapping);
      if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        CurrentTB.HotkeysMapping = form.GetHotkeys();
    }

    private void rTFToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog sfd = new SaveFileDialog();
      sfd.Filter = "RTF|*.rtf";
      if (sfd.ShowDialog() == DialogResult.OK)
      {
        string rtf = CurrentTB.Rtf;
        File.WriteAllText(sfd.FileName, rtf);
      }
    }

    private void fctb_CustomAction(object sender, CustomActionEventArgs e)
    {
      MessageBox.Show(e.Action.ToString());
    }

    private void commentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.InsertLinePrefix(CurrentTB.CommentPrefix);
    }

    private void uncommentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CurrentTB.RemoveLinePrefix(CurrentTB.CommentPrefix);
    }
    #endregion
  }

  public class InvisibleCharsRenderer : Style
  {
    private readonly Pen pen;

    public InvisibleCharsRenderer(Pen pen)
    {
      this.pen = pen;
    }

    public override void Draw(Graphics gr, Point position, Range range)
    {
      var tb = range.tb;
      using (Brush brush = new SolidBrush(pen.Color))
        foreach (var place in range)
        {
          switch (tb[place].c)
          {
            case ' ':
              var point = tb.PlaceToPoint(place);
              point.Offset(tb.CharWidth/2, tb.CharHeight/2);
              gr.DrawLine(pen, point.X, point.Y, point.X + 1, point.Y);
              break;
          }

          if (tb[place.iLine].Count - 1 == place.iChar)
          {
            var point = tb.PlaceToPoint(place);
            point.Offset(tb.CharWidth, 0);
            gr.DrawString("¶", tb.Font, brush, point);
          }
        }
    }


  }

  public class TbInfo
  {
    public AutocompleteMenu popupMenu;
  }
}