using System;
using System.Windows.Forms;
using AW.Business;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Win.Properties;

namespace AW.Win
{
  public partial class frmOrganization : Form
  {
    public frmOrganization()
    {
      InitializeComponent();
    }

    private void frmOrganization_Load(object sender, EventArgs e)
    {
      cbEmployee.DataSource = LookUpQueries.GetEmployees();
      cbEmployee.DisplayMember = "EmployeeDisplayName";
      cbEmployee.ValueMember = EmployeeFieldIndex.EmployeeID.ToString();
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.OrderSearchSizeLocation);
    }

    private void frmOrganization_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.OrderSearchSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
    }

    #region Stored procedure version

    /// <summary>
    /// Stored Procedure Version
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void btnSearchSP_Click(object sender, EventArgs e)
    {
      tvOrganization.Nodes.Clear();
      var EmployeeID = Convert.ToInt32(cbEmployee.SelectedValue);
      var MasterNode = OrganizationManager.GetMasterNode(EmployeeID);
      OrganizationManager.GetManagerEmployees(EmployeeID, MasterNode);
      tvOrganization.Nodes.Add(MasterNode);
      tvOrganization.Nodes[0].ExpandAll();
    }

    #endregion

    #region Dynamic Version with prefetch

    private void btnSearch_Click(object sender, EventArgs e)
    {
      tvOrganization.Nodes.Clear();
      TreeNode MasterNode;
      var emp = OrganizationManager.GetPrefetchedEmployeeEntity(Convert.ToInt32(cbEmployee.SelectedValue));
      var EmployeeNode = new TreeNode {Text = (emp.Contact.FirstName + ", " + emp.Contact.LastName + " [" + emp.EmployeeID + "]"), Tag = emp.EmployeeID};
      if (emp.Manages.Count > 0)
        foreach (var Subordinate in emp.Manages)
        {
          EmployeeNode.Nodes.Add(OrganizationManager.GetEmployeesRecursive(Subordinate));
        }
      if (emp.ManagerID != 0)
      {
        var ManagersNode = OrganizationManager.GetManagersRecursive(emp.Manager);
        OrganizationManager.FindLowestNode(ManagersNode).Nodes.Add(EmployeeNode);
        MasterNode = ManagersNode;
      }
      else
        MasterNode = EmployeeNode;
      MasterNode.ExpandAll();
      tvOrganization.Nodes.Add(MasterNode);
    }

    #endregion

    #region Dynamic Version

    private void buttonSearchNP_Click(object sender, EventArgs e)
    {
      tvOrganization.Nodes.Clear();
      TreeNode MasterNode;
      var Employee = new EmployeeEntity(Convert.ToInt32(cbEmployee.SelectedValue));
      var EmployeeNode = OrganizationManager.MakeNode(Employee);
      if (Employee.Manages.Count > 0)
        foreach (var Subordinate in Employee.Manages)
        {
          EmployeeNode.Nodes.Add(OrganizationManager.GetEmployeesRecursive(Subordinate));
        }
      if (Employee.ManagerID != 0)
      {
        var ManagersNode = OrganizationManager.GetManagersRecursive(Employee.Manager);
        OrganizationManager.FindLowestNode(ManagersNode).Nodes.Add(EmployeeNode);
        MasterNode = ManagersNode;
      }
      else
        MasterNode = EmployeeNode;
      MasterNode.ExpandAll();
      tvOrganization.Nodes.Add(MasterNode);
    }

    #endregion

    #region Testing Code

    private void btnSearchNon_Click(object sender, EventArgs e)
    {
      tvOrganization.Nodes.Clear();
      TreeNode MasterNode;

      var emp = new EmployeeEntity(Convert.ToInt32(cbEmployee.SelectedValue));
      var EmployeeNode = new TreeNode {Text = (emp.Contact.FirstName + ", " + emp.Contact.LastName + " [" + emp.EmployeeID + "]"), Tag = emp.EmployeeID};
      if (emp.Manages.Count > 0)
        foreach (var Subordinate in emp.Manages)
        {
          EmployeeNode.Nodes.Add(OrganizationManager.GetEmployeesRecursive(Subordinate));
        }
      if (emp.ManagerID != 0)
      {
        var ManagersNode = OrganizationManager.GetManagersRecursive(emp.Manager);
        OrganizationManager.FindLowestNode(ManagersNode).Nodes.Add(EmployeeNode);
        MasterNode = ManagersNode;
      }
      else
        MasterNode = EmployeeNode;
      MasterNode.ExpandAll();
      tvOrganization.Nodes.Add(MasterNode);
    }

    #endregion
  }
}