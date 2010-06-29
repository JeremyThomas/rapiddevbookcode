using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using ACorns.Hawkeye;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.EntityViewer;
using CSScriptLibrary;
using JesseJohnston;

namespace AW.Winforms.Helpers.QueryRunner
{
  public partial class QueryRunner : UserControl
  {
    public event Func<object, int> SaveFunction;
    public event Func<object, int> DeleteFunction;

    public QueryRunner()
    {
      InitializeComponent();
    }

    public QueryRunner(Func<object, int> saveFunction, Func<object, int> deleteFunction, params Type[] saveableTypes)
      : this()
    {
      SaveFunction = saveFunction;
      DeleteFunction = deleteFunction;
      gridDataEditorScript.DataEditorPersister = new DataEditorPersister(saveFunction, deleteFunction, saveableTypes);
    }

    private void toolStripButtonViewRunQuery_Click(object sender, EventArgs e)
    {
      var helper = new AsmHelper(CSScript.LoadCode(textBoxScript.Text, null, true));
      using (helper)
      {
        gridDataEditorScript.BindEnumerable(((IQueryScript) helper.CreateObject("Script")).Query());
      }
      if (gridDataEditorScript.BindingSource.Count > 0)
        if (gridDataEditorScript.Height < 30)
        {
          splitContainerScript.SplitterDistance = Height/2;
          toolStripButtonBrowse.Enabled = true;
        }
    }

    private void QueryRunner_Load(object sender, EventArgs e)
    {
      splitContainerScript.SplitterDistance = Height - gridDataEditorScript.BindingNavigator.Height - gridDataEditorScript.BindingNavigator.Height;
      gridDataEditorScript.Items.Remove(toolStripButtonRunQuery);
      gridDataEditorScript.Items.Insert(0, toolStripButtonRunQuery);
    }

    internal void Save(string fileName)
    {
      File.WriteAllText(fileName, textBoxScript.Text);
    }

    internal void LoadFile(string fileName)
    {
      textBoxScript.Text = File.ReadAllText(fileName);
    }

    internal void Save(StreamWriter streamWriter)
    {
      //streamWriter.
      //File.WriteAllText(fileName, textBoxScript.Text);
    }

    internal void LoadStream(StreamReader streamReader)
    {
      textBoxScript.Text = streamReader.ReadToEnd();
    }

    private void viewObjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ObjectEditor.Instance.Show(gridDataEditorScript.BindingSource.Current);
    }

    private void toolStripButtonBrowse_Click(object sender, EventArgs e)
    {
      FrmEntityViewer.LaunchAsChildForm(((ObjectListView)gridDataEditorScript.BindingSource.DataSource).List, gridDataEditorScript.DataEditorPersister);
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

      textBoxScript.SelectedText = node.Text;

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
  }

  public interface IQueryScript
  {
    IEnumerable Query();
  }
}