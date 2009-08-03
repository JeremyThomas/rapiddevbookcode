using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using ACorns.Hawkeye;
using AW.Winforms.Helpers.EntityViewer;
using CSScriptLibrary;
using DynamicTable;
using JesseJohnston;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.QueryRunner
{
  public partial class QueryRunner : UserControl
  {
    private readonly Type[] _saveableTypes;
    public event Func<object, int> SaveFunction;

    public QueryRunner()
    {
      InitializeComponent();
      dataGridViewScript.AutoGenerateColumns = true;
    }

    public QueryRunner(Func<object, int> saveFunction, params Type[] saveableTypes)
      : this()
    {
      _saveableTypes = saveableTypes;
      SaveFunction += saveFunction;
    }

    private void toolStripButtonViewRunQuery_Click(object sender, EventArgs e)
    {
      var helper = new AsmHelper(CSScript.LoadCode(textBoxScript.Text, null, true));
      using (helper)
      {
        AWHelper.BindEnumerable(((IQueryScript) helper.CreateObject("Script")).Query(), BindingSourceScript);
      }
      if (BindingSourceScript.Count > 0)
      {
        copyToolStripButtonQuery.Enabled = true;
        toolStripButtonBrowse.Enabled = true;
        printToolStripButtonViewReport.Enabled = true;
        if (dataGridViewScript.Height < 30)
          splitContainerScript.SplitterDistance = Height/2;
      }
    }

    private void printToolStripButtonViewReport_Click(object sender, EventArgs e)
    {
      var frm = new FrmReportViewer {WindowState = FormWindowState.Normal};
      frm.OpenDataSet(BindingSourceScript, false);
      frm.Show();
    }

    private void copyToolStripButtonQuery_Click(object sender, EventArgs e)
    {
      AWHelper.CopyEntireDataGridViewToClipboard(dataGridViewScript);
    }

    private void QueryRunner_Load(object sender, EventArgs e)
    {
      var dataGridViewScriptClipboardCopyMode = dataGridViewScript.ClipboardCopyMode;
      toolStripComboBoxClipboardCopyMode.ComboBox.DataSource = Enum.GetValues(typeof (DataGridViewClipboardCopyMode));
      toolStripComboBoxClipboardCopyMode.SelectedItem = dataGridViewScriptClipboardCopyMode;
      splitContainerScript.SplitterDistance = Height - bindingNavigatorScript.Height;
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
      ObjectEditor.Instance.Show(BindingSourceScript.Current);
    }

    private void toolStripButtonBrowse_Click(object sender, EventArgs e)
    {
      FrmEntityViewer.LaunchAsChildForm(((ObjectListView)BindingSourceScript.DataSource).List, SaveFunction, _saveableTypes);
    }

    private void browseObjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmEntityViewer.LaunchAsChildForm(BindingSourceScript.Current, SaveFunction, _saveableTypes);
    }

    private void dataGridViewScript_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {

    }

    private void textBoxScript_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(typeof(TreeNode)))
      {
        //this.DragDrop(sender, e);
        return;
      }
      var node = (TreeNode)e.Data.GetData(typeof(TreeNode));

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