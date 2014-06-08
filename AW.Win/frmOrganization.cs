using System;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.Queries;
using AW.Winforms.Helpers;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AW.Win
{
  public partial class FrmOrganization : FrmPersistantLocation
  {
    public FrmOrganization()
    {
      InitializeComponent();
    }

    private int SelectedEmployeeID
    {
      get { return Convert.ToInt32(cbEmployee.SelectedValue); }
    }

    private void frmOrganization_Load(object sender, EventArgs e)
    {
      cbEmployee.DataSource = LookUpQueries.GetEmployees();
      cbEmployee.DisplayMember = "EmployeeDisplayName";
      cbEmployee.ValueMember = EmployeeFieldIndex.EmployeeID.ToString();
    }

    private void frmOrganization_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    /// <summary>
    ///   Stored Procedure Version
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
    private void btnSearchSP_Click(object sender, EventArgs e)
    {
      OrganizationHelper.ShowEmployeesPlaceInOrganization(SelectedEmployeeID, tvOrganization.Nodes);
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      OrganizationHelper.ShowEmployeesPlaceInOrganization(new EmployeeEntity(SelectedEmployeeID, OrganizationHelper.GetManagesPrefetchPath()), tvOrganization.Nodes);
    }

    private void buttonSearchNoPrefetch_Click(object sender, EventArgs e)
    {
      OrganizationHelper.ShowEmployeesPlaceInOrganization(new EmployeeEntity(SelectedEmployeeID), tvOrganization.Nodes);
    }

    private void BtnSearchLinqPrefetchClick(object sender, EventArgs e)
    {
      OrganizationHelper.ShowEmployeesPlaceInOrganization(MetaSingletons.MetaData.Employee.Where(employee => employee.EmployeeID == SelectedEmployeeID)
        .WithPath(OrganizationHelper.GetManagesPrefetchPath()).Single(),
        tvOrganization.Nodes);
    }
  }
}