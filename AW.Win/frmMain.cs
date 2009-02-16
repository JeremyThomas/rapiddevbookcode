using System;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Windows.Forms;
using AW.Winforms.Helpers.EntityViewer;
using AW.Winforms.Helpers.Properties;
using SD.LLBLGen.Pro.ApplicationCore;

namespace AW.Winforms.Helpers
{
  public partial class frmMain : Form
  {
    public frmMain()
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
          LaunchChildForm(formName);
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
            Settings.Default.OpenWindows.Add(myForm.GetType().FullName);
    }

    //private void LaunchChildForm(Form ChildForm)
    //{
    //    ChildForm.MdiParent = this;
    //    ChildForm.WindowState = FormWindowState.Normal;
    //    ChildForm.Show();
    //}
    public void LaunchChildForm(Form ChildForm)
    {
      if (ChildForm == null) throw new ArgumentNullException("ChildForm");
      var FormAlreadyExists = false;
      foreach (var myForm in MdiChildren)
        if (myForm.GetType() == ChildForm.GetType())
        {
          FormAlreadyExists = true;
          ChildForm = myForm;
          break;
        }
      if (FormAlreadyExists)
        ChildForm.BringToFront();
      else
      {
        ChildForm.MdiParent = this;
        ChildForm.WindowState = FormWindowState.Normal;
        ChildForm.Show();
      }
    }

    public void LaunchChildForm(string formName)
    {
      LaunchChildForm((Form) Activator.CreateInstance(Type.GetType(formName)));
    }

    private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(new frmOrderSearch());
    }

    private void orders2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(new frmOrderSearch2());
    }

    private void customersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(new frmCustomers());
    }

    private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(new frmOrganization());
    }

    private void vacationBonusUtilityToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(new frmVacationBonus());
    }

    private void traceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(new frmTrace());
    }

    private void fileToolStripMenuItemOpen_Click(object sender, EventArgs e)
    {
      var dr = openFileDialogProject.ShowDialog();

      if (dr == DialogResult.OK)
      {
        DoFileOpen(openFileDialogProject.FileName);
      }
    }

    private void DoFileOpen(string fileName)
    {
      try
      {
        var projectToBrowse = Project.Load(fileName);
        LaunchChildForm(new FrmEntityViewer(projectToBrowse));
        mruHandlerProject.AddRecentlyUsedFile(fileName);
      }
      catch (SerializationException ex)
      {
        throw new ApplicationException(string.Format("The specified file \"{0}\" is not a valid LLBLGen Pro project file. Please verify that the project file is valid, that it has been saved in the most recent version available, and then try again.", fileName), ex);
      }
    }

    private void mruHandlerProject_MRUItemClicked(object sender, AW.Winforms.Helpers.MostRecentlyUsedHandler.MRUItemClickedEventArgs e)
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
      foreach (Form childForm in MdiChildren)
      {
        childForm.Close();
      }
    }
    #endregion
  }
}