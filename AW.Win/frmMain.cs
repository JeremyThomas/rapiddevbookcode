using System;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Win.Properties;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.LLBL;
using AW.Winforms.Helpers.LLBL.PropGridEx;
using AW.Winforms.Helpers.MostRecentlyUsedHandler;
using AW.Winforms.Helpers.QueryRunner;

namespace AW.Win
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
      MetaDataHelper.AddAssociatedMetadataProviders(MetaDataHelper.GetDescendance(typeof (CommonEntityBase)));
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
      return formType == null ? null : AWHelper.LaunchChildForm(this, formType, args);
    }

    private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmOrderSearch));
    }

    private void orders2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmOrderSearch2));
    }

    private void customersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmCustomers));
    }

    private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmOrganization));
    }

    private void vacationBonusUtilityToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmVacationBonus));
    }

    private void traceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmTrace));
    }

    private void fileToolStripMenuItemOpen_Click(object sender, EventArgs e)
    {
      var dr = openFileDialogProject.ShowDialog();

      if (dr == DialogResult.OK)
        DoFileOpen(openFileDialogProject.FileNames);
    }

    private void DoFileOpen(string fileName)
    {
      var frmQueryRunner = LaunchQueryRunner();
      if (frmQueryRunner != null) frmQueryRunner.DoFileOpen(fileName);

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
      LaunchQueryRunner();
    }

    private FrmQueryRunner LaunchQueryRunner()
    {
      var qr = LaunchChildForm(typeof (FrmQueryRunner)) as FrmQueryRunner;
      if (qr != null)
      {
        qr.SaveFunction += EntityHelper.Save;
        qr.DeleteFunction += EntityHelper.Delete;
      }
      return qr;
    }

    private void viewMetadataToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmLLBLEntityViewer.LaunchAsChildForm(MetaSingletons.MetaData, new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister());
    }

    private void viewEntitiesAndFieldsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmEntitiesAndFields), typeof (CommonEntityBase), MetaSingletons.MetaData);
    }

    private void organizationStructureToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmOrganizationStructure));
    }

    private void frmMain_DragDrop(object sender, DragEventArgs e)
    {
      var files = (string[]) e.Data.GetData(DataFormats.FileDrop);
      if (files != null)
      {
        Activate();
        DoFileOpen(files);
      }
    }

    private void DoFileOpen(params string[] fileNames)
    {
      foreach (var fileName in fileNames)
        DoFileOpen(fileName);
    }

    private void frmMain_DragOver(object sender, DragEventArgs e)
    {
      e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
    }
  }
}