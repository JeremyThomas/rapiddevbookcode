using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.Linq;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.LLBL;
using Chaliy.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.Linq.Filters;
using SD.LLBLGen.Pro.ORMSupportClasses;
using CustomerEntity = Northwind.DAL.EntityClasses.CustomerEntity;

namespace AW.Tests
{
  [TestClass]
  public class HierarchyEditorTest
  {
    public static readonly Lazy<EntityCollectionBase<EmployeeEntity>> Employees = new Lazy<EntityCollectionBase<EmployeeEntity>>(ToWireUpEntityCollection);

    private static EntityCollectionBase<EmployeeEntity> ToWireUpEntityCollection()
    {
      var employeeEntities = MetaSingletons.MetaData.Employee.ToEntityCollection();
      return EmployeeEntity.WireUpSelfJoin(employeeEntities).OrderBy(e => e.EmployeeDisplayName).ToEntityCollection();
    }

    [TestMethod]
    public void TestDataTreeView()
    {
      var employeeEntities = Employees.Value;
      var dataTreeView = new DataTreeView
      {
        Sorted = true,
        IDColumn = "EmployeeID",
        ParentIDColumn = "ManagerID",
        NameColumn = "EmployeeDisplayName",
        DataSource = employeeEntities,
        BindingContext = new BindingContext()
      };
      // dataTreeView.ResetData();
      AssertEmployeesInTree(dataTreeView);
    }

    [TestMethod]
    public void TestDataTreeViewWithChildCollectionProperty()
    {
      var employeeEntities = Employees.Value;
      TestDataTreeViewWithChildCollectionProperty(employeeEntities);
    }

    [TestMethod]
    public void TestDataTreeViewWithChildCollectionPropertyPrefetched()
    {
      var employeeEntities = EmployeeEntity.WireUpSelfJoin(LinqMetaData.CreateWithContext().Employee.PrefetchAll());
      TestDataTreeViewWithChildCollectionProperty(employeeEntities);
    }

    private static void TestDataTreeViewWithChildCollectionProperty(IEnumerable<EmployeeEntity> employeeEntities)
    {
      var managers = employeeEntities.Where(e => e.ManagerID == null).ToEntityCollection();
      var dataTreeView = new DataTreeView
      {
        Sorted = true,
        ChildCollectionPropertyName = "Manages",
        NameColumn = "EmployeeDisplayName",
        DataSource = managers,
        BindingContext = new BindingContext()
      };
      // dataTreeView.ResetData();
      AssertEmployeesInTree(dataTreeView);
    }

    [TestMethod]
    public void TestDataTreeViewGroup()
    {
      var groupBy = NorthwindTest.GetNorthwindLinqMetaData().Customer.GroupByCountry();
      TestDataTreeViewGroup(groupBy.ToList());
      TestDataTreeViewGroup(groupBy.ToBindingListView());
      TestDataTreeViewGroup(((IEnumerable) groupBy).ToBindingListView());
      var customerGroupedByCountry = NorthwindTest.GetNorthwindLinqMetaData().Customer.ToEntityCollection2().GroupByCountry();
      TestDataTreeViewGroup(customerGroupedByCountry.ToBindingListView());
  //    TestDataTreeViewGroup(((IEnumerable)customerGroupedByCountry).ToBindingListView());
      TestDataTreeViewGroup(customerGroupedByCountry);
    }

    private static void TestDataTreeViewGroup(IEnumerable customerGroupedByCountry)
    {
      var dataTreeView = new DataTreeView
      {
        Sorted = true,
        DataSource = customerGroupedByCountry,
        NameColumn = "CompanyName",
        BindingContext = new BindingContext()
      };
      AssertCustomerGroupedByCountryInTree(dataTreeView);
    }

    private static void AssertCustomerGroupedByCountryInTree(TreeView dataTreeView)
    {
      Assert.AreEqual(21, dataTreeView.Nodes.Count);
      var rootNode = dataTreeView.Nodes[0];
      Assert.AreEqual("Argentina", rootNode.Text);
      Assert.AreEqual(3, rootNode.Nodes.Count);
      var treeNodeCactus = rootNode.Nodes[0];
      Assert.AreEqual("Cactus Comidas para llevar", treeNodeCactus.Text);
    }

    [TestMethod]
    public void TestHierarchyEditorGroup()
    {
      TestHierarchyEditorGroup(NorthwindTest.GetNorthwindLinqMetaData().Customer.GroupByCountry().ToList());
      TestHierarchyEditorGroup(NorthwindTest.GetNorthwindLinqMetaData().Customer.ToEntityCollection2().GroupByCountry().ToList());
    }

    private static void TestHierarchyEditorGroup(IEnumerable<IGrouping<string, CustomerEntity>> customerGroupedByCountry)
    {
      var hierarchyEditor = new HierarchyEditor(customerGroupedByCountry, "CompanyName", null) {BindingContext = new BindingContext()};
      var dataTreeView = hierarchyEditor.Controls.Find("dataTreeView", true).Single() as TreeView;
      AssertCustomerGroupedByCountryInTree(dataTreeView);
    }

    private static void AssertEmployeesInTree(TreeView dataTreeView)
    {
      Assert.AreEqual(1, dataTreeView.Nodes.Count);
      var rootNode = dataTreeView.Nodes[0];
      Assert.AreEqual(6, rootNode.Nodes.Count);
      var treeNodeBradley = rootNode.Nodes[0];
      Assert.AreEqual("Bradley, David", treeNodeBradley.Text);
      Assert.AreEqual(8, treeNodeBradley.Nodes.Count);
      Assert.AreEqual("Benshoof, Wanida", treeNodeBradley.Nodes[0].Text);
    }

    [TestProperty("Winforms", "Interactive"), TestMethod]
    public void TestShowInTree()
    {
      var employeeEntities = Employees.Value;
      //TestShowInTree(employeeEntities, EmployeeFieldIndex.EmployeeID.ToString(), EmployeeFieldIndex.ManagerID.ToString(), "EmployeeDisplayName");
      TestShowInTree(employeeEntities, e => e.EmployeeID, e => e.ManagerID, e => e.EmployeeDisplayName);
    }

    [TestProperty("Winforms", "Interactive"), TestMethod]
    public void CanChangeParentInTree()
    {
      var employeeEntities = Employees.Value;
      const int danWilsonsID = 128;
      var danWilsonsManagerID = employeeEntities.Single(e => e.EmployeeID == danWilsonsID).ManagerID;
      var employeeEntitiesWithWilsonManagerChanged = TestShowInTree(employeeEntities, EmployeeFieldIndex.EmployeeID.ToString(), EmployeeFieldIndex.ManagerID.ToString(), "EmployeeDisplayName");
      Assert.AreNotEqual(danWilsonsManagerID, employeeEntitiesWithWilsonManagerChanged.Single(e => e.EmployeeID == danWilsonsID).ManagerID);
    }

    public static IEnumerable<T> ShowHierarchyInTree<T>(IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn, IDataEditorPersister dataEditorPersister = null)
    {
      FrmPersistantLocation.ShowControlInForm(new HierarchyEditor(enumerable, iDPropertyName, parentIDPropertyName, nameColumn, dataEditorPersister), enumerable.ToString());
      return enumerable;
    }

    public static IEnumerable<T> ShowHierarchyInTree<T, TId, TParentId, TName>(IEnumerable<T> enumerable, Expression<Func<T, TId>> iDPropertyExpression,
      Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression,
      IDataEditorPersister dataEditorPersister = null)
    {
      FrmPersistantLocation.ShowControlInForm(HierarchyEditor.HierarchyEditorFactory(enumerable, iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression, dataEditorPersister));
      return enumerable;
    }
    
    private static IEnumerable<T> TestShowInTree<T>(IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn)
    {
      var actual = ShowHierarchyInTree(enumerable, iDPropertyName, parentIDPropertyName, nameColumn);
      Assert.AreEqual<IEnumerable<T>>(enumerable, actual);
      CollectionAssert.AreEqual(enumerable.ToList(), Enumerable.ToList<T>(actual));
      return actual;
    }

    private static IEnumerable<T> TestShowInTree<T, TId, TParentId, TName>(IEnumerable<T> enumerable, Expression<Func<T, TId>> iDPropertyExpression,
      Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression)
    {
      var actual = ShowHierarchyInTree(enumerable, iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression);
      Assert.AreEqual<IEnumerable<T>>(enumerable, actual);
      CollectionAssert.AreEqual(enumerable.ToList(), Enumerable.ToList<T>(actual));
      return actual;
    }
  }
}