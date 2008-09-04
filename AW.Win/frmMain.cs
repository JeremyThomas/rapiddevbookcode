using System;
using System.Collections.Specialized;
using System.Windows.Forms;
using AW.Win.Properties;

namespace AW.Win
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
      if (Settings.Default.ReopenWindows && MdiChildren.Length > 0)
      {
        if (Settings.Default.OpenWindows == null)
          Settings.Default.OpenWindows = new StringCollection();
        else
          Settings.Default.OpenWindows.Clear();
        foreach (var myForm in MdiChildren)
          Settings.Default.OpenWindows.Add(myForm.GetType().FullName);
      }
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
  }
}