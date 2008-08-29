using System;
using System.Windows.Forms;
using AW.Win.Properties;

namespace AW.Win
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.MainWindowSizeLocation);
      if (Settings.Default.OpenTraceWindosOnStart)
        LaunchChildForm(new frmTrace());
    }

    //private void LaunchChildForm(Form ChildForm)
    //{
    //    ChildForm.MdiParent = this;
    //    ChildForm.WindowState = FormWindowState.Normal;
    //    ChildForm.Show();
    //}
    public void LaunchChildForm(Form ChildForm)
    {
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

    private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Default.Save();
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.MainWindowSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
    }


  }
}