﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.LLBL;
using Chaliy.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
      var managers = employeeEntities.Where(e=>e.ManagerID==null).ToEntityCollection();
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
      var groupBy = NorthwindTest.GetNorthwindLinqMetaData().Customer.GroupBy(c => c.Country);
      TestDataTreeViewGroup(groupBy.ToList());
      TestDataTreeViewGroup(AW.Winforms.Helpers.BindingListHelper.ToBindingListView(groupBy));
      TestDataTreeViewGroup(AW.Winforms.Helpers.BindingListHelper.ToBindingListView((IEnumerable)groupBy));
    }

    private static void TestDataTreeViewGroup(IEnumerable customerGroupedByCountry)
    {
      var dataTreeView = new DataTreeView
      {
        Sorted = true,
        NameColumn = "CompanyName",
        DataSource = customerGroupedByCountry,
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
      var customerGroupedByCountry = NorthwindTest.GetNorthwindLinqMetaData().Customer.GroupBy(c => c.Country).ToList();
      var hierarchyEditor = new HierarchyEditor(customerGroupedByCountry, "CompanyName", null) {BindingContext = new BindingContext()};
      var dataTreeView = hierarchyEditor.Controls.Find("dataTreeView",true).Single() as TreeView;
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

    [TestProperty("Winforms", "Interactive"), TestMethod]
    public void TestShowSelfServicingInTree()
    {
      var employeeEntities = Employees.Value;
      employeeEntities.ShowSelfServicingHierarchyInTree(EmployeeFieldIndex.EmployeeID.ToString(), EmployeeFieldIndex.ManagerID.ToString(), "EmployeeDisplayName");
    }

    private static IEnumerable<T> TestShowInTree<T>(IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn)
    {
      var actual = enumerable.ShowHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn);
      Assert.AreEqual(enumerable, actual);
      CollectionAssert.AreEqual(enumerable.ToList(), actual.ToList());
      return actual;
    }

    private static IEnumerable<T> TestShowInTree<T, TId, TParentId, TName>(IEnumerable<T> enumerable, Expression<Func<T, TId>> iDPropertyExpression,
      Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression)
    {
      var actual = enumerable.ShowHierarchyInTree(iDPropertyExpression, parentIDPropertyExpression, namePropertyExpression);
      Assert.AreEqual(enumerable, actual);
      CollectionAssert.AreEqual(enumerable.ToList(), actual.ToList());
      return actual;
    }
  }
}