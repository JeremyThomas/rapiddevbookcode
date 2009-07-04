using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using AW.Winforms.Helpers.Properties;

namespace AW.Winforms.Helpers.QueryRunner
{
  public partial class FrmQueryRunner : Form
  {
    public FrmQueryRunner()
    {
      InitializeComponent();
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.QueryRunnerSizeAndLocation);
    }

    private void FrmQueryRunner_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.QueryRunnerSizeAndLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
    }

    private void FrmQueryRunner_Load(object sender, EventArgs e)
    {
    }

    private void contextMenuStripTab_Opening(object sender, CancelEventArgs e)
    {
    }

    private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
    {
      var dr = openFileDialog.ShowDialog();

      if (dr == DialogResult.OK)
        DoFileOpen(openFileDialog.FileName);
    }

    public void DoFileOpen(string fileName)
    {
      var fileKeyIndex = tabControl.TabPages.IndexOfKey(fileName);
      if (fileKeyIndex > -1)
      {
        tabControl.SelectedTab = tabControl.TabPages[fileKeyIndex];
        return;
      }
      var queryRunner = AddNew(fileName);
      queryRunner.LoadFile(fileName);
      if (tabControl.TabPages[0].ToolTipText == "Sample")
        tabControl.TabPages.RemoveAt(0);
    }

    private QueryRunner AddNew(string fileName)
    {
      tabControl.TabPages.Add(fileName, Path.GetFileNameWithoutExtension(fileName));
      var queryRunner = new QueryRunner();
      var tp = tabControl.TabPages[fileName];
      tp.ToolTipText = fileName;
      tp.Controls.Add(queryRunner);
      queryRunner.Dock = DockStyle.Fill;
      tabControl.SelectedTab = tp;
      return queryRunner;
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AddNew("Query" + tabControl.TabPages.Count);
    }

    private void toolStripMenuItemSave_Click(object sender, EventArgs e)
    {
      if (File.Exists(tabControl.SelectedTab.ToolTipText))
        SaveScript(tabControl.SelectedTab.ToolTipText);
      else
        saveAsToolStripMenuItem_Click(sender, e);
    }

    private QueryRunner CurrentQueryRunner()
    {
      return tabControl.SelectedTab.Controls[0] as QueryRunner;
    }

    private void toolStripMenuItemClose_Click(object sender, EventArgs e)
    {
      tabControl.TabPages.Remove(tabControl.SelectedTab);
      if (tabControl.TabPages.Count == 0)
        Close();
    }

    private void closeAllButThisToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (TabPage page in tabControl.TabPages)
      {
        if (page != tabControl.SelectedTab)
          tabControl.TabPages.Remove(page);
      }
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      saveFileDialog.FileName = tabControl.SelectedTab.ToolTipText;
      var dr = saveFileDialog.ShowDialog();
      if (dr == DialogResult.OK)
      {
        SaveScript(saveFileDialog.FileName);
        tabControl.SelectedTab.ToolTipText = saveFileDialog.FileName;
        tabControl.SelectedTab.Text = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
      }
    }

    private void SaveScript(string filename)
    {
      CurrentQueryRunner().Save(filename);
    }

    private void tabControl_DragDrop(object sender, DragEventArgs e)
    {
      try
      {
        var a = (Array) e.Data.GetData(DataFormats.FileDrop);
        if (a != null)
        {
          var s = a.GetValue(0).ToString();
          Activate();
          DoFileOpen(s);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error in DragDrop function: " + ex.Message);
      }
    }

    private void tabControl_DragOver(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
        e.Effect = DragDropEffects.Move;
      else e.Effect = DragDropEffects.None;
    }
  }
}