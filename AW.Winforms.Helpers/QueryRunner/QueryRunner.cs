using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.EntityViewer;
using CSScriptLibrary;
using JesseJohnston;

namespace AW.Winforms.Helpers.QueryRunner
{
  public partial class QueryRunner : UserControl
  {
    public QueryRunner()
    {
      InitializeComponent();
    }

    public QueryRunner(Func<object, int> saveFunction, Func<object, int> deleteFunction, params Type[] saveableTypes)
      : this()
    {
      gridDataEditorScript.DataEditorPersister = new DataEditorPersister(saveFunction, deleteFunction, null, saveableTypes);
    }

    /// <summary>
    ///   Handles the Click event of the toolStripButtonViewRunQuery control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void toolStripButtonViewRunQuery_Click(object sender, EventArgs e)
    {
      try
      {
        var helper = new AsmHelper(CSScript.LoadCode(textBoxScript.CurrentTB.Text, null, true));
        using (helper)
        {
          var enumerable = ((IQueryScript) helper.CreateObject("Script")).Query();
          gridDataEditorScript.BindEnumerable(enumerable);
          tabControlResults.SelectedTab = tabPageGrid;
        }
        if (gridDataEditorScript.BindingSource.Count > 0)
          if (gridDataEditorScript.Height < 50)
          {
            splitContainerScript.SplitterDistance = Height/2;
            toolStripButtonBrowse.Enabled = true;
          }
      }
      catch (Exception ex)
      {
        textBoxOutPut.Text += ex.Message;
        tabControlResults.SelectedTab = tabPageText;
      }
    }

    private void QueryRunner_Load(object sender, EventArgs e)
    {
      splitContainerScript.SplitterDistance = Height - gridDataEditorScript.BindingNavigator.Height - gridDataEditorScript.BindingNavigator.Height;

      textBoxScript.Merge(toolStripHidden);
//      textBoxScript.tsMain.Items.Add(toolStripButtonRunQuery);
      tabControlResults.ItemSize = new Size(0, 1);
    }

    internal void Save(string fileName)
    {
      File.WriteAllText(fileName, textBoxScript.CurrentTB.Text);
    }

    internal void LoadFile(string fileName)
    {
      textBoxScript.CreateTab(fileName);
    }

    internal void Save(StreamWriter streamWriter)
    {
      //streamWriter.
      //File.WriteAllText(fileName, textBoxScript.Text);
    }

    internal void LoadStream(StreamReader streamReader)
    {
      LoadText(streamReader.ReadToEnd());
    }

    internal void LoadText(string text)
    {
      var fastColoredTextBox = textBoxScript.CreateTab();
      fastColoredTextBox.Text = text;
    }

    private void viewObjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //ObjectEditor.Instance.Show(gridDataEditorScript.BindingSource.Current);
    }

    private void toolStripButtonBrowse_Click(object sender, EventArgs e)
    {
      FrmEntityViewer.LaunchAsChildForm(((ObjectListView) gridDataEditorScript.BindingSource.DataSource).List, gridDataEditorScript.DataEditorPersister);
    }

    private void browseObjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (gridDataEditorScript.BindingSource.Current != null)
        FrmEntityViewer.LaunchAsChildForm(gridDataEditorScript.BindingSource.Current, gridDataEditorScript.DataEditorPersister);
    }

    private void textBoxScript_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(typeof (TreeNode)))
        //this.DragDrop(sender, e);
        return;
      var node = (TreeNode) e.Data.GetData(typeof (TreeNode));

      //  textBoxScript.SelectedText = node.Text;

      //try
      //{
      //  Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
      //  if (a != null)
      //  {
      //    string s = a.GetValue(0).ToString();
      //    //this.Activate();
      //    //OpenFile(s);
      //  }
      //}
      //catch (Exception ex)
      //{
      //  MessageBox.Show("Error in DragDrop function: " + ex.Message);
      //}
    }

    private void textBoxScript_DragEnter(object sender, DragEventArgs e)
    {
      //if (e.Data.GetDataPresent(typeof(TreeNode)))
      //  e.Effect = DragDropEffects.Copy;
      //else
      //  e.Effect = DragDropEffects.None;
    }

    private void textBoxScript_DragOver(object sender, DragEventArgs e)
    {
      //if (e.Data.GetDataPresent(typeof(TreeNode)))
      //  e.Effect = DragDropEffects.Move;
      //else e.Effect = DragDropEffects.None;
    }

    private void textBoxScript_MouseDown(object sender, MouseEventArgs e)
    {
      //var txt = (TextBox)sender;
      //txt.DoDragDrop(txt.Text, DragDropEffects.Copy);
    }

    public int SplitterDistance
    {
      get { return splitContainerScript.SplitterDistance; }
      set { splitContainerScript.SplitterDistance = value; }
    }
  }

  public interface IQueryScript
  {
    IEnumerable Query();
  }
}