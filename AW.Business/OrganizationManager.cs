using System;
using System.Data;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.StoredProcedureCallerClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Business
{
  public static class OrganizationManager
  {
    #region Stored procedure version

    public static void CreateNode(DataRow row, TreeNodeCollection Nodes)
    {
      var Node = new TreeNode
                   {
                     Text = (row["LastName"] + ", " + row["FirstName"]
                             + " [" + row["EmployeeID"] + "]"), Tag = row["EmployeeID"]
                   };
      Nodes.Add(Node);
      var Children = GetChildRow(row, row.Table);
      if (Children != null)
        CreateNode(Children, Nodes[0].Nodes);
    }

    public static DataRow GetChildRow(DataRow row, DataTable table)
    {
      if (!(table.Rows.IndexOf(row) - 1 < 0))
        return table.Rows[table.Rows.IndexOf(row) - 1];
      return null;
    }

    public static TreeNode FindEmployeeRecursive(
      int EmployeeID, TreeNodeCollection Nodes)
    {
      TreeNode FoundNode = null;
      foreach (TreeNode Node in Nodes)
      {
        if (FoundNode != null)
          return FoundNode;
        if (Convert.ToInt32(Node.Tag) == EmployeeID)
        {
          FoundNode = Node;
          break;
        }
        if (Node.Nodes.Count > 0)
          FoundNode = FindEmployeeRecursive(
            EmployeeID, Node.Nodes);
      }
      return FoundNode;
    }

    public static void GetManagerEmployees(int EmployeeID, TreeNode MasterNode)
    {
      var Managees = RetrievalProcedures.UspGetManagerEmployees(EmployeeID);
      foreach (DataRow row in Managees.Rows)
      {
        var Manager = FindEmployeeRecursive(
          Convert.ToInt32(row["ManagerID"])
          , MasterNode.Nodes);
        var Employee = new TreeNode
        {
          Text = (row["LastName"] + ", "
                  + row["FirstName"] + " [" + row["EmployeeID"] + "]"),
          Tag = row["EmployeeID"]
        };
        Manager.Nodes.Add(Employee);
      }
    }

    public static TreeNode GetMasterNode(int EmployeeID)
    {
      var MasterNode = new TreeNode();
      var Managers = RetrievalProcedures.UspGetEmployeeManagers(EmployeeID);

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

    public static TreeNode GetManagersRecursive(EmployeeEntityBase Employee)
    {
      var EmployeeNode = new TreeNode {Text = (Employee.Contact.LastName + ", " + Employee.Contact.FirstName + " [" + Employee.EmployeeId + "]"), Tag = Employee.EmployeeId};
      if (Employee.ManagerId != 0 && Employee.ManagerId != null)
      {
        var ManagerNode = GetManagersRecursive(Employee.Manager);
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

    public static TreeNode GetEmployeesRecursive(EmployeeEntityBase Employee)
    {
      var EmployeeNode = new TreeNode {Text = (Employee.Contact.LastName + ", " + Employee.Contact.FirstName + " [" + Employee.EmployeeId + "]"), Tag = Employee.EmployeeId};
      if (Employee.Manages.Count > 0)
        foreach (var Subordinate in Employee.Manages)
        {
          EmployeeNode.Nodes.Add(GetEmployeesRecursive(Subordinate));
        }
      return EmployeeNode;
    }


    public static EmployeeEntity GetPrefetchedEmployeeEntity(Int32 employeeId)
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
        EmployeeEntity(employeeId, prefetch);
    }

    #endregion

    #region Dynamic Version

    public static TreeNode MakeNode(EmployeeEntity Employee)
    {
      var MyNode = new TreeNode(Employee.Contact.LastName
                                + ", " + Employee.Contact.FirstName + " ["
                                + Employee.EmployeeId + " ]") {Tag = Employee.EmployeeId};
      return MyNode;
    }

    public static TreeNode GetManagersRecursive(EmployeeEntity Employee)
    {
      var EmployeeNode = MakeNode(Employee);
      if (Employee.ManagerId != 0 && Employee.ManagerId != null)
      {
        var ManagerNode = GetManagersRecursive(Employee.Manager);
        FindLowestNode(ManagerNode).Nodes.Add(EmployeeNode);
        return ManagerNode;
      }
      return EmployeeNode;
    }

    public static TreeNode GetEmployeesRecursive(EmployeeEntity Employee)
    {
      var EmployeeNode = MakeNode(Employee);
      if (Employee.Manages.Count > 0)
        foreach (var Subordinate in Employee.Manages)
        {
          EmployeeNode.Nodes.Add(GetEmployeesRecursive(Subordinate));
        }
      return EmployeeNode;
    }

    #endregion


  }
}