using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using AW.Data;
using AW.Winforms.Helpers.EntityViewer;
using AW.Winforms.Helpers.MostRecentlyUsedHandler;
using AW.Winforms.Helpers.Properties;
using AW.Winforms.Helpers.QueryRunner;
using SD.LLBLGen.Pro.ApplicationCore;

namespace AW.Winforms.Helpers
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.MainWindowSizeLocation);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
    }

    private void frmMain_Shown(object sender, EventArgs e)
    {
      if (Settings.Default.ReopenWindows && Settings.Default.OpenWindows != null)
        foreach (var formName in Settings.Default.OpenWindows)
        {
          var frm = LaunchChildForm(formName);
          if (frm is FrmQueryRunner)
            ((FrmQueryRunner) frm).OpenFiles(Settings.Default.QueryFilesToReopen);
          Application.DoEvents();
        }
    }

    private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Default.Save();
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.MainWindowSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);

      Settings.Default.ReopenWindows = reOpenWindowsToolStripMenuItem.Checked;
      if (Settings.Default.OpenWindows == null)
        Settings.Default.OpenWindows = new StringCollection();
      else
        Settings.Default.OpenWindows.Clear();
      if (Settings.Default.ReopenWindows && MdiChildren.Length > 0)
        foreach (var myForm in MdiChildren)
          if (Convert.ToBoolean(myForm.Tag))
          {
            Settings.Default.OpenWindows.Add(myForm.GetType().FullName);
            if (myForm is FrmQueryRunner)
              Settings.Default.QueryFilesToReopen = ((FrmQueryRunner) myForm).GetOpenFiles();
          }
    }

    public Form LaunchChildForm(string formName)
    {
      var formType = Type.GetType(formName);
      if (formType == null)
      {
        if (formName == typeof (FrmQueryRunner).FullName)
          return LaunchChildForm(typeof (FrmQueryRunner));
        return null;
      }
      return LaunchChildForm(formType);
    }

    public Form LaunchChildForm(Type formType, params Object[] args)
    {
      return formType != null ? AWHelper.LaunchChildForm(this, formType, args) : null;
    }

    private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (frmOrderSearch));
    }

    private void orders2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (frmOrderSearch2));
    }

    private void customersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (frmCustomers));
    }

    private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (frmOrganization));
    }

    private void vacationBonusUtilityToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (frmVacationBonus));
    }

    private void traceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (frmTrace));
    }

    private void fileToolStripMenuItemOpen_Click(object sender, EventArgs e)
    {
      var dr = openFileDialogProject.ShowDialog();

      if (dr == DialogResult.OK)
        DoFileOpen(openFileDialogProject.FileName);
    }

    private void DoFileOpen(string fileName)
    {
      if (Path.GetExtension(fileName).Equals(".lgp", StringComparison.InvariantCultureIgnoreCase))
        try
        {
          var projectToBrowse = Project.Load(fileName);
          LaunchChildForm(typeof (FrmEntityViewer), projectToBrowse);
        }
        catch (SerializationException ex)
        {
          throw new ApplicationException(string.Format("The specified file \"{0}\" is not a valid LLBLGen Pro project file. Please verify that the project file is valid, that it has been saved in the most recent version available, and then try again.", fileName), ex);
        }
      else
      {
        var frmQueryRunner = LaunchChildForm(typeof (FrmQueryRunner)) as FrmQueryRunner;
        frmQueryRunner.DoFileOpen(fileName);
      }
      openFileDialogProject.InitialDirectory = Path.GetDirectoryName(fileName);
      mruHandlerProject.AddRecentlyUsedFile(fileName);
    }

    private void mruHandlerProject_MRUItemClicked(object sender, MRUItemClickedEventArgs e)
    {
      DoFileOpen(e.File);
    }

    #region WindowsMenuHandlers

    private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.Cascade);
    }

    private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileVertical);
    }

    private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.ArrangeIcons);
    }

    private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (var childForm in MdiChildren)
      {
        childForm.Close();
      }
    }

    #endregion

    private void adHocLINQQueryRunnerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmQueryRunner));
    }

    private void viewMetadataToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmEntityViewer), MetaSingletons.MetaData);
    }

    private void viewEntitiesAndFieldsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmEntitiesAndFields));
    }

    private void frmMain_DragDrop(object sender, DragEventArgs e)
    {
      var files = (IEnumerable<string>) e.Data.GetData(DataFormats.FileDrop);
      if (files != null)
      {
        Activate();
        foreach (var file in files)
          DoFileOpen(file);
      }
    }

    private void frmMain_DragOver(object sender, DragEventArgs e)
    {
      e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
    }
  }
}