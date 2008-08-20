using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
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
            cbEmployee.DataSource = EmployeeEntity.GetEmployees();
            cbEmployee.DisplayMember = "EmployeeDisplayName";
            cbEmployee.ValueMember = EmployeeFieldIndex.EmployeeId.ToString();
        }


        #region Stored procedure version
        //Stored Procedure Version
        //private void CreateNode(DataRow row, TreeNodeCollection Nodes)
        //{
        //    TreeNode Node = new TreeNode();
        //    Node.Text = row["LastName"] + ", " + row["FirstName"]
        //        + " [" + row["EmployeeID"] + "]";
        //    Node.Tag = row["EmployeeID"];
        //    Nodes.Add(Node);
        //    DataRow Children = GetChildRow(row, row.Table);
        //    if (Children != null)
        //        CreateNode(Children, Nodes[0].Nodes);
        //}
        //private DataRow GetChildRow(DataRow row, DataTable table)
        //{
        //    if (!(table.Rows.IndexOf(row) - 1 < 0))
        //    {
        //        return table.Rows[table.Rows.IndexOf(row) - 1];
        //    }
        //    else
        //        return null;
        //}
        //private TreeNode FindEmployeeRecursive(
        //    int EmployeeID, TreeNodeCollection Nodes)
        //{
        //    TreeNode FoundNode = null;
        //    foreach (TreeNode Node in Nodes)
        //    {
        //        if (FoundNode != null)
        //            return FoundNode;
        //        if (Convert.ToInt32(Node.Tag) == EmployeeID)
        //        {
        //            FoundNode = Node;
        //            break;
        //        }
        //        else
        //        {
        //            if (Node.Nodes.Count > 0)
        //            {
        //                FoundNode = FindEmployeeRecursive(
        //                    EmployeeID, Node.Nodes);
        //            }
        //        }
        //    }
        //    return FoundNode;
        //}
        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    tvOrganization.Nodes.Clear();
        //    TreeNode MasterNode = new TreeNode();
        //    int EmployeeID = Int32.Parse(this.cbEmployee.Text);
        //    DataTable Managers = AW.Data.StoredProcedureCallerClasses.
        //        RetrievalProcedures.UspGetEmployeeManagers(EmployeeID);
        //    DataTable Managees = AW.Data.StoredProcedureCallerClasses.
        //        RetrievalProcedures.UspGetManagerEmployees(EmployeeID);
        //    if (Managers.Rows.Count > 0)
        //    {
        //        TreeNodeCollection ManagersCol = new TreeNode().Nodes;
        //        CreateNode(Managers.Rows[Managers.Rows.Count - 1],
        //            ManagersCol);
        //        TreeNode CEONode = new TreeNode();
        //        DataRow CEORow = Managers.Rows[Managers.Rows.Count-1];
        //        CEONode.Text = CEORow["ManagerLastName"] + ", " 
        //            + CEORow["ManagerFirstName"]
        //            + " [" + CEORow["ManagerID"] + "]";
        //        CEONode.Tag = CEORow["ManagerID"].ToString();
        //        CEONode.Nodes.Add(ManagersCol[0]);
        //        MasterNode = CEONode;
        //    }
        //    foreach (DataRow row in Managees.Rows)
        //    {
        //        TreeNode Manager = FindEmployeeRecursive(
        //            Convert.ToInt32(row["ManagerID"])
        //            , MasterNode.Nodes);
        //        TreeNode Employee = new TreeNode();
        //        Employee.Text = row["LastName"] + ", " 
        //            + row["FirstName"] + " [" + row["EmployeeID"] + "]";
        //        Employee.Tag = row["EmployeeID"];
        //        Manager.Nodes.Add(Employee);
        //    }
        //    tvOrganization.Nodes.Add(MasterNode);
        //    tvOrganization.Nodes[0].ExpandAll();
        //}
        #endregion

        #region Dynamic Version with prefetch
        private void btnSearch_Click(object sender, EventArgs e)
        {
            tvOrganization.Nodes.Clear();
            TreeNode MasterNode;
            IPrefetchPath prefetch = 
                new PrefetchPath((int)EntityType.EmployeeEntity);
            prefetch.Add(EmployeeEntity.PrefetchPathContact);
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
            EmployeeEntity emp = new 
                EmployeeEntity(Convert.ToInt32(cbEmployee.SelectedValue), prefetch);
            TreeNode EmployeeNode = new TreeNode();
            EmployeeNode.Text = emp.Contact.FirstName + ", " + emp.Contact.LastName + " [" + emp.EmployeeId.ToString() + "]";
            EmployeeNode.Tag = emp.EmployeeId;
            if (emp.Manages.Count > 0)
            {
                foreach (EmployeeEntity Subordinate in emp.Manages)
                {
                    EmployeeNode.Nodes.Add(GetEmployeesRecursive(Subordinate));
                }
            }
            if (emp.ManagerId != 0)
            {
                TreeNode ManagersNode = GetManagersRecursive(emp.Manager);
                FindLowestNode(ManagersNode).Nodes.Add(EmployeeNode);
                MasterNode = ManagersNode;
            }
            else
            {
                MasterNode = EmployeeNode;
            }
            MasterNode.ExpandAll();
            tvOrganization.Nodes.Add(MasterNode);
        }
        private TreeNode GetManagersRecursive(EmployeeEntity Employee)
        {
            TreeNode EmployeeNode = new TreeNode();
            EmployeeNode.Text = Employee.Contact.LastName + ", " + Employee.Contact.FirstName + " [" + Employee.EmployeeId.ToString() + "]";
            EmployeeNode.Tag = Employee.EmployeeId;
            if (Employee.ManagerId != 0)
            {
                TreeNode ManagerNode = GetManagersRecursive(Employee.Manager);
                FindLowestNode(ManagerNode).Nodes.Add(EmployeeNode);
                return ManagerNode;
            }
            return EmployeeNode;
        }
        private TreeNode FindLowestNode(TreeNode Node)
        {
            if (Node.Nodes.Count > 0)
                return FindLowestNode(Node.Nodes[0]);
            else
                return Node;
        }
        private TreeNode GetEmployeesRecursive(EmployeeEntity Employee)
        {
            TreeNode EmployeeNode = new TreeNode();
            EmployeeNode.Text = Employee.Contact.LastName + ", " + Employee.Contact.FirstName + " [" + Employee.EmployeeId.ToString() + "]";
            EmployeeNode.Tag = Employee.EmployeeId;
            if (Employee.Manages.Count > 0)
            {
                foreach (EmployeeEntity Subordinate in Employee.Manages)
                {
                    EmployeeNode.Nodes.Add(GetEmployeesRecursive(Subordinate));
                }
            }
            return EmployeeNode;
        }
        #endregion
        #region Dynamic Version
        //private TreeNode FindLowestNode(TreeNode Node)
        //{
        //    if (Node.Nodes.Count > 0)
        //        return FindLowestNode(Node.Nodes[0]);
        //    else
        //        return Node;
        //}
        //private TreeNode MakeNode(EmployeeEntity Employee)
        //{
        //    TreeNode MyNode = new TreeNode(Employee.Contact.LastName
        //        + ", " + Employee.Contact.FirstName + " [" 
        //        + Employee.EmployeeId.ToString() + " ]");
        //    MyNode.Tag = Employee.EmployeeId;
        //    return MyNode;
        //}
        //private TreeNode GetManagersRecursive(EmployeeEntity Employee)
        //{
        //    TreeNode EmployeeNode = MakeNode(Employee);
        //    if (Employee.ManagerId != 0)
        //    {
        //        TreeNode ManagerNode = GetManagersRecursive(Employee.Manager);
        //        FindLowestNode(ManagerNode).Nodes.Add(EmployeeNode);
        //        return ManagerNode;
        //    }
        //    return EmployeeNode;
        //}
        //private TreeNode GetEmployeesRecursive(EmployeeEntity Employee)
        //{
        //    TreeNode EmployeeNode = MakeNode(Employee);
        //    if (Employee.Manages.Count > 0)
        //    {
        //        foreach (EmployeeEntity Subordinate in Employee.Manages)
        //        {
        //            EmployeeNode.Nodes.Add(GetEmployeesRecursive(Subordinate));
        //        }
        //    }
        //    return EmployeeNode;
        //}
        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    tvOrganization.Nodes.Clear();
        //    TreeNode MasterNode;
        //    EmployeeEntity Employee = new EmployeeEntity(
        //        Convert.ToInt32(cbEmployee.SelectedValue));
        //    TreeNode EmployeeNode = MakeNode(Employee);
        //    if (Employee.Manages.Count > 0)
        //    {
        //        foreach (EmployeeEntity Subordinate in Employee.Manages)
        //        {
        //            EmployeeNode.Nodes.Add(GetEmployeesRecursive(Subordinate));
        //        }
        //    }
        //    if (Employee.ManagerId != 0)
        //    {
        //        TreeNode ManagersNode = GetManagersRecursive(Employee.Manager);
        //        FindLowestNode(ManagersNode).Nodes.Add(EmployeeNode);
        //        MasterNode = ManagersNode;
        //    }
        //    else
        //    {
        //        MasterNode = EmployeeNode;
        //    }
        //    MasterNode.ExpandAll();
        //    tvOrganization.Nodes.Add(MasterNode);
        //}
        #endregion

        #region Testing Code
        //private void btnSearchNon_Click(object sender, EventArgs e)
        //{
        //    tvOrganization.Nodes.Clear();
        //    TreeNode MasterNode;

        //    EmployeeEntity emp = new EmployeeEntity(Int32.Parse(tbID.Text));
        //    TreeNode EmployeeNode = new TreeNode();
        //    EmployeeNode.Text = emp.Contact.FirstName + ", " + emp.Contact.LastName + " [" + emp.EmployeeId.ToString() + "]";
        //    EmployeeNode.Tag = emp.EmployeeId;
        //    if (emp.Manages.Count > 0)
        //    {
        //        foreach (EmployeeEntity Subordinate in emp.Manages)
        //        {
        //            EmployeeNode.Nodes.Add(GetEmployeesRecursive(Subordinate));
        //        }
        //    }
        //    if (emp.ManagerId != 0)
        //    {
        //        TreeNode ManagersNode = GetManagersRecursive(emp.Manager);
        //        FindLowestNode(ManagersNode).Nodes.Add(EmployeeNode);
        //        MasterNode = ManagersNode;
        //    }
        //    else
        //    {
        //        MasterNode = EmployeeNode;
        //    }
        //    MasterNode.ExpandAll();
        //    tvOrganization.Nodes.Add(MasterNode);
        //}
        #endregion

    }
}