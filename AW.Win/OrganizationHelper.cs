using System;
using System.Data;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.StoredProcedureCallerClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Win
{
  public static class OrganizationHelper
  {
    private static TreeNode MakeNode(object lastName, object firstName, object employeeID)
    {
      return new TreeNode(lastName + ", " + firstName + " [" + employeeID + "]") {Tag = employeeID};
    }

    #region Stored procedure version

    private static void CreateNode(DataRow row, TreeNodeCollection nodes)
    {
      nodes.Add(MakeNode(row));
      var children = GetChildRow(row, row.Table);
      if (children != null)
        CreateNode(children, nodes[0].Nodes);
    }

    private static TreeNode MakeNode(DataRow row)
    {
      return MakeNode(row["LastName"], row["FirstName"], row["EmployeeID"]);
    }

    private static DataRow GetChildRow(DataRow row, DataTable table)
    {
      return !(table.Rows.IndexOf(row) - 1 < 0) ? table.Rows[table.Rows.IndexOf(row) - 1] : null;
    }

    private static TreeNode FindEmployeeRecursive(
      int employeeID, TreeNodeCollection nodes)
    {
      TreeNode foundNode = null;
      foreach (TreeNode node in nodes)
      {
        if (foundNode != null)
          return foundNode;
        if (Convert.ToInt32(node.Tag) == employeeID)
        {
          foundNode = node;
          break;
        }
        if (node.Nodes.Count > 0)
          foundNode = FindEmployeeRecursive(
            employeeID, node.Nodes);
      }
      return foundNode;
    }

    private static void GetManagerEmployees(int employeeID, TreeNode masterNode)
    {
      var managees = RetrievalProcedures.UspGetManagerEmployees(employeeID);
      foreach (DataRow row in managees.Rows)
        FindEmployeeRecursive(Convert.ToInt32(row["ManagerID"]), masterNode.Nodes).Nodes.Add(MakeNode(row));
    }

    public static TreeNode GetEmployeeManagersNodes(int employeeID)
    {
      TreeNode masterNode;
      var managers = RetrievalProcedures.UspGetEmployeeManagers(employeeID);

      if (managers.Rows.Count > 0)
      {
        var managersCol = new TreeNode().Nodes;
        CreateNode(managers.Rows[managers.Rows.Count - 1], managersCol);

        var ceoRow = managers.Rows[managers.Rows.Count - 1];
        var ceoNode = MakeNode(ceoRow["ManagerLastName"], ceoRow["ManagerFirstName"], ceoRow["ManagerID"]);
        ceoNode.Nodes.Add(managersCol[0]);
        masterNode = ceoNode;
      }
      else
      {
        masterNode = MakeNode(null, null, employeeID);
        masterNode.Nodes.Add(MakeNode(null, null, employeeID));
      }
      return masterNode;
    }

    public static void ShowEmployeesPlaceInOrganization(int employeeID, TreeNodeCollection treeNodeCollection)
    {
      treeNodeCollection.Clear();
      var masterNode = GetEmployeeManagersNodes(employeeID);
      GetManagerEmployees(employeeID, masterNode);
      treeNodeCollection.Add(masterNode);
      treeNodeCollection[0].ExpandAll();
    }

    #endregion

    #region Dynamic Version

    /// <summary>
    ///   Gets the prefetch path for a Manager's Employees. By using this prefetch all a manager's employees a bought back in 1
    ///   query.
    /// </summary>
    /// <returns></returns>
    public static IPrefetchPath GetManagesPrefetchPath()
    {
      IPrefetchPath prefetch =
        new PrefetchPath((int) EntityType.EmployeeEntity) {EmployeeEntity.PrefetchPathContact};
      prefetch.Add(EmployeeEntity.PrefetchPathManages)
        .SubPath.Add(EmployeeEntity.PrefetchPathManages)
        .SubPath.Add(EmployeeEntity.PrefetchPathManages)
        .SubPath.Add(EmployeeEntity.PrefetchPathManages)
        .SubPath.Add(EmployeeEntity.PrefetchPathManages);
      prefetch[1].SubPath.Add(EmployeeEntity.PrefetchPathContact);
      prefetch[1].SubPath[0].SubPath.Add(
        EmployeeEntity.PrefetchPathContact);
      prefetch[1].SubPath[0].SubPath[0].SubPath.Add(
        EmployeeEntity.PrefetchPathContact);
      prefetch[1].SubPath[0].SubPath[0].SubPath[0].SubPath.Add(
        EmployeeEntity.PrefetchPathContact);
      prefetch[1].SubPath[0].SubPath[0].SubPath[0].SubPath[0].SubPath.Add(
        EmployeeEntity.PrefetchPathContact);
      return prefetch;
    }

    private static TreeNode FindLowestNode(TreeNode node)
    {
      return node.Nodes.Count > 0 ? FindLowestNode(node.Nodes[0]) : node;
    }

    private static TreeNode MakeNode(EmployeeEntity employee)
    {
      return MakeNode(employee.Contact.LastName, employee.Contact.FirstName, employee.EmployeeID);
    }

    public static TreeNode GetManagersRecursive(EmployeeEntity employee)
    {
      var employeeNode = MakeNode(employee);
      if (employee.ManagerID != 0 && employee.ManagerID != null)
      {
        var managerNode = GetManagersRecursive(employee.Manager);
        FindLowestNode(managerNode).Nodes.Add(employeeNode);
        return managerNode;
      }
      return employeeNode;
    }

    public static TreeNode GetEmployeesRecursive(EmployeeEntity employee)
    {
      var employeeNode = MakeNode(employee);
      if (employee.Manages.Count > 0)
        foreach (var subordinate in employee.Manages)
        {
          employeeNode.Nodes.Add(GetEmployeesRecursive(subordinate));
        }
      return employeeNode;
    }

    public static void ShowEmployeesPlaceInOrganization(EmployeeEntity employee, TreeNodeCollection treeNodeCollection)
    {
      treeNodeCollection.Clear();
      TreeNode masterNode;
      var employeeNode = MakeNode(employee);
      if (employee.Manages.Count > 0)
        foreach (var subordinate in employee.Manages)
          employeeNode.Nodes.Add(GetEmployeesRecursive(subordinate));
      if (employee.ManagerID != 0 && employee.ManagerID != null)
      {
        var managersNode = GetManagersRecursive(employee.Manager);
        FindLowestNode(managersNode).Nodes.Add(employeeNode);
        masterNode = managersNode;
      }
      else
        masterNode = employeeNode;
      masterNode.ExpandAll();
      treeNodeCollection.Add(masterNode);
    }

    #endregion
  }
}