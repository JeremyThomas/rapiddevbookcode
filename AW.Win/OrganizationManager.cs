using System;
using System.Data;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.StoredProcedureCallerClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Win
{
  public static class OrganizationManager
  {
    #region Stored procedure version

    public static void CreateNode(DataRow row, TreeNodeCollection nodes)
    {
      var Node = new TreeNode
                   {
                     Text = (row["LastName"] + ", " + row["FirstName"]
                             + " [" + row["EmployeeID"] + "]"), Tag = row["EmployeeID"]
                   };
      nodes.Add(Node);
      var Children = GetChildRow(row, row.Table);
      if (Children != null)
        CreateNode(Children, nodes[0].Nodes);
    }

    public static DataRow GetChildRow(DataRow row, DataTable table)
    {
      if (!(table.Rows.IndexOf(row) - 1 < 0))
        return table.Rows[table.Rows.IndexOf(row) - 1];
      return null;
    }

    public static TreeNode FindEmployeeRecursive(
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

    public static void GetManagerEmployees(int employeeID, TreeNode masterNode)
    {
      var Managees = RetrievalProcedures.UspGetManagerEmployees(employeeID);
      foreach (DataRow row in Managees.Rows)
      {
        var Manager = FindEmployeeRecursive(
          Convert.ToInt32(row["ManagerID"])
          , masterNode.Nodes);
        var Employee = new TreeNode
                         {
                           Text = (row["LastName"] + ", "
                                   + row["FirstName"] + " [" + row["EmployeeID"] + "]"),
                           Tag = row["EmployeeID"]
                         };
        Manager.Nodes.Add(Employee);
      }
    }

    public static TreeNode GetMasterNode(int employeeID)
    {
      var MasterNode = new TreeNode();
      var Managers = RetrievalProcedures.UspGetEmployeeManagers(employeeID);

      if (Managers.Rows.Count > 0)
      {
        var ManagersCol = new TreeNode().Nodes;
        CreateNode(Managers.Rows[Managers.Rows.Count - 1], ManagersCol);
        var CEONode = new TreeNode();
        var CEORow = Managers.Rows[Managers.Rows.Count - 1];
        CEONode.Text = CEORow["ManagerLastName"] + ", "
                       + CEORow["ManagerFirstName"]
                       + " [" + CEORow["ManagerID"] + "]";
        CEONode.Tag = CEORow["ManagerID"].ToString();
        CEONode.Nodes.Add(ManagersCol[0]);
        MasterNode = CEONode;
      }
      return MasterNode;
    }

    #endregion

    #region Dynamic Version with prefetch

    public static TreeNode GetManagersRecursive(EmployeeEntityBase employee)
    {
      var EmployeeNode = new TreeNode {Text = (employee.Contact.LastName + ", " + employee.Contact.FirstName + " [" + employee.EmployeeID + "]"), Tag = employee.EmployeeID};
      if (employee.ManagerID != 0 && employee.ManagerID != null)
      {
        var ManagerNode = GetManagersRecursive(employee.Manager);
        FindLowestNode(ManagerNode).Nodes.Add(EmployeeNode);
        return ManagerNode;
      }
      return EmployeeNode;
    }

    public static TreeNode FindLowestNode(TreeNode Node)
    {
      if (Node.Nodes.Count > 0)
        return FindLowestNode(Node.Nodes[0]);
      return Node;
    }

    public static TreeNode GetEmployeesRecursive(EmployeeEntityBase employee)
    {
      var EmployeeNode = new TreeNode {Text = (employee.Contact.LastName + ", " + employee.Contact.FirstName + " [" + employee.EmployeeID + "]"), Tag = employee.EmployeeID};
      if (employee.Manages.Count > 0)
        foreach (var subordinate in employee.Manages)
        {
          EmployeeNode.Nodes.Add(GetEmployeesRecursive(subordinate));
        }
      return EmployeeNode;
    }


    public static EmployeeEntity GetPrefetchedEmployeeEntity(Int32 EmployeeID)
    {
      IPrefetchPath prefetch =
        new PrefetchPath((int) EntityType.EmployeeEntity) {EmployeeEntityBase.PrefetchPathContact};
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
      return new
        EmployeeEntity(EmployeeID, prefetch);
    }

    #endregion

    #region Dynamic Version

    public static TreeNode MakeNode(EmployeeEntity employee)
    {
      var MyNode = new TreeNode(employee.Contact.LastName
                                + ", " + employee.Contact.FirstName + " ["
                                + employee.EmployeeID + " ]") {Tag = employee.EmployeeID};
      return MyNode;
    }

    public static TreeNode GetManagersRecursive(EmployeeEntity employee)
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

    public static TreeNode GetEmployeesRecursive(EmployeeEntity employee)
    {
      var EmployeeNode = MakeNode(employee);
      if (employee.Manages.Count > 0)
        foreach (var subordinate in employee.Manages)
        {
          EmployeeNode.Nodes.Add(GetEmployeesRecursive(subordinate));
        }
      return EmployeeNode;
    }

    #endregion


  }
}