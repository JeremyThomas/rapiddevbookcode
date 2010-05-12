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
    public static TreeNode MakeNode(object lastName, object firstName, object employeeID)
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
      TreeNode FoundNode = null;
      foreach (TreeNode node in nodes)
      {
        if (FoundNode != null)
          return FoundNode;
        if (Convert.ToInt32(node.Tag) == employeeID)
        {
          FoundNode = node;
          break;
        }
        if (node.Nodes.Count > 0)
          FoundNode = FindEmployeeRecursive(
            employeeID, node.Nodes);
      }
      return FoundNode;
    }

    internal static void GetManagerEmployees(int employeeID, TreeNode masterNode)
    {
      var managees = RetrievalProcedures.UspGetManagerEmployees(employeeID);
      foreach (DataRow row in managees.Rows)
        FindEmployeeRecursive(Convert.ToInt32(row["ManagerID"]), masterNode.Nodes).Nodes.Add(MakeNode(row));
    }

    internal static TreeNode GetEmployeeManagersNodes(int employeeID)
    {
      TreeNode MasterNode;
      var Managers = RetrievalProcedures.UspGetEmployeeManagers(employeeID);

      if (Managers.Rows.Count > 0)
      {
        var ManagersCol = new TreeNode().Nodes;
        CreateNode(Managers.Rows[Managers.Rows.Count - 1], ManagersCol);

        var CEORow = Managers.Rows[Managers.Rows.Count - 1];
        var CEONode = MakeNode(CEORow["ManagerLastName"], CEORow["ManagerFirstName"], CEORow["ManagerID"]);
        CEONode.Nodes.Add(ManagersCol[0]);
        MasterNode = CEONode;
      }
      else
      {
        MasterNode = MakeNode(null, null, employeeID);
        MasterNode.Nodes.Add(MakeNode(null, null, employeeID));
      }
      return MasterNode;
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
    /// Gets the prefetch path for a Manager's Employees. By using this prefetch all a manager's employees a bought back in 1 query.
    /// </summary>
    /// <returns></returns>
    public static IPrefetchPath GetManagesPrefetchPath()
    {
      IPrefetchPath prefetch =
        new PrefetchPath((int)EntityType.EmployeeEntity) { EmployeeEntityBase.PrefetchPathContact };
      prefetch.Add(EmployeeEntityBase.PrefetchPathManages)
        .SubPath.Add(EmployeeEntityBase.PrefetchPathManages)
        .SubPath.Add(EmployeeEntityBase.PrefetchPathManages)
        .SubPath.Add(EmployeeEntityBase.PrefetchPathManages)
        .SubPath.Add(EmployeeEntityBase.PrefetchPathManages);
      prefetch[1].SubPath.Add(EmployeeEntityBase.PrefetchPathContact);
      prefetch[1].SubPath[0].SubPath.Add(
        EmployeeEntityBase.PrefetchPathContact);
      prefetch[1].SubPath[0].SubPath[0].SubPath.Add(
        EmployeeEntityBase.PrefetchPathContact);
      prefetch[1].SubPath[0].SubPath[0].SubPath[0].SubPath.Add(
        EmployeeEntityBase.PrefetchPathContact);
      prefetch[1].SubPath[0].SubPath[0].SubPath[0].SubPath[0].SubPath.Add(
        EmployeeEntityBase.PrefetchPathContact);
      return prefetch;
    }

    private static TreeNode FindLowestNode(TreeNode node)
    {
      return node.Nodes.Count > 0 ? FindLowestNode(node.Nodes[0]) : node;
    }

    private static TreeNode MakeNode(EmployeeEntityBase employee)
    {
      return MakeNode(employee.Contact.LastName, employee.Contact.FirstName, employee.EmployeeID);
    }

    internal static TreeNode GetManagersRecursive(EmployeeEntity employee)
    {
      var EmployeeNode = MakeNode(employee);
      if (employee.ManagerID != 0 && employee.ManagerID != null)
      {
        var ManagerNode = GetManagersRecursive(employee.Manager);
        FindLowestNode(ManagerNode).Nodes.Add(EmployeeNode);
        return ManagerNode;
      }
      return EmployeeNode;
    }

    internal static TreeNode GetEmployeesRecursive(EmployeeEntity employee)
    {
      var EmployeeNode = MakeNode(employee);
      if (employee.Manages.Count > 0)
        foreach (var subordinate in employee.Manages)
        {
          EmployeeNode.Nodes.Add(GetEmployeesRecursive(subordinate));
        }
      return EmployeeNode;
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