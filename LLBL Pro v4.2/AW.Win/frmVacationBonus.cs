using System;
using System.Globalization;
using AW.Data.EntityClasses;
using AW.Winforms.Helpers;

namespace AW.Win
{
  public partial class FrmVacationBonus : FrmPersistantLocation
  {
    public FrmVacationBonus()
    {
      InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      lblResult.Text = EmployeeEntity.AddBonusVacationHours(
        dtpHireDate.Value,
        Convert.ToInt32(nudSalariedHours.Value),
        Convert.ToInt32(nudUnsalariedHours.Value)).ToString(CultureInfo.InvariantCulture);
    }
  }
}