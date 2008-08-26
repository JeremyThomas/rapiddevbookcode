using System;
using System.Windows.Forms;
using AW.Data.EntityClasses;
using AW.Win.Properties;

namespace AW.Win
{
  public partial class frmVacationBonus : Form
  {
    public frmVacationBonus()
    {
      InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      lblResult.Text = EmployeeEntity.AddBonusVacationHours(
        dtpHireDate.Value,
        Convert.ToInt32(nudSalariedHours.Value),
        Convert.ToInt32(nudUnsalariedHours.Value)).ToString();
    }

    private void frmVacationBonus_Load(object sender, EventArgs e)
    {
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.VacationSizeLocation);
    }

    private void frmVacationBonus_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.VacationSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
    }
  }
}