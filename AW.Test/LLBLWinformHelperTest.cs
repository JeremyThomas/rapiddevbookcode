using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Test.Helpers;
using AW.Winforms.Helpers.LLBL;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using CustomerEntity = Northwind.DAL.EntityClasses.CustomerEntity;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class for LLBLWinformHelperTest and is intended
  ///   to contain all LLBLWinformHelperTest Unit Tests
  /// </summary>
  [TestClass]
  public class LLBLWinformHelperTest : GridDataEditorTestBase
  {
    private static readonly TreeView EntityTreeView = new TreeView();
    public const int NumSchemaObjects = 851;

    /// <summary>
    ///   Gets or sets the test context which provides
    ///   information about and functionality for the current test run.
    /// </summary>
    public TestContext TestContext { get; set; }

    #region Additional test attributes

    // 
    //You can use the following additional attributes as you write your tests:
    //
    //Use ClassInitialize to run code before running the first test in the class
    //[ClassInitialize()]
    //public static void MyClassInitialize(TestContext testContext)
    //{
    //}
    //
    //Use ClassCleanup to run code after all tests in a class have run
    //[ClassCleanup()]
    //public static void MyClassCleanup()
    //{
    //}
    //
    //Use TestInitialize to run code before running each test
    [TestInitialize()]
    public void MyTestInitialize()
    {
      Init();
    }

    //Use TestCleanup to run code after each test has run
    [TestCleanup()]
    public void MyTestCleanup()
    {
      Verify();
    }

    #endregion

    /// <summary>
    ///   A test for ShowInGrid
    /// </summary>
    private void EditInDataGridViewTestHelper<T>(ushort pageSize, int numProperties = -1, int numFieldsToShow = 0) where T : EntityBase
    {
      ModalFormHandler = Handler;
      var enumerable = MetaSingletons.MetaData.GetQueryableForEntity<T>().AsEnumerable();
      var expected = enumerable;
      numProperties = GetNumberOfColumns<T>(numProperties, ref numFieldsToShow);
      var actual = enumerable.ShowSelfServicingInGrid(pageSize);
      Assert.AreEqual(expected, actual);
      Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
    }

    private void EditAdapterInDataGridViewTestHelper<T>(ushort pageSize, int numProperties = -1, int numFieldsToShow = 0) where T : EntityBase2
    {
      ModalFormHandler = Handler;
      var enumerable = NorthwindTest.GetNorthwindLinqMetaData().GetQueryableForEntity<T>().AsEnumerable();
      var expected = enumerable;
      numProperties = GetNumberOfColumns<T>(numProperties, ref numFieldsToShow);
      var actual = enumerable.ShowInGrid(null, pageSize);
      Assert.AreEqual(expected, actual);
      Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
    }

    private void TestShowSelfServicingInGrid<T>(IEnumerable<T> enumerable, ushort pageSize, int numProperties = -1, int numFieldsToShow = 0) where T : EntityBase
    {
      ModalFormHandler = Handler;
      GetNumberOfColumns<T>(numProperties, ref numFieldsToShow);
      var actual = enumerable.ShowSelfServicingInGrid(pageSize);
      Assert.AreEqual(enumerable, actual);
      Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
    }

    protected void TestShowSelfAdapterInGrid<T>(IEnumerable<T> enumerable, ushort pageSize, int numProperties = -1, int numFieldsToShow = 0) where T : EntityBase2
    {
      ModalFormHandler = Handler;
      GetNumberOfColumns<T>(numProperties, ref numFieldsToShow);
      var actual = enumerable.ShowInGrid(null, pageSize);
      Assert.AreEqual(enumerable, actual);
      Assert.AreEqual(ExpectedColumnCount, ActualColumnCount);
    }

    [TestCategory("Winforms"), TestMethod]
    public void ShowSelfServicingInGridTest()
    {
      EditInDataGridViewTestHelper<AddressEntity>(20);

      var addressTypes = from at in MetaSingletons.MetaData.AddressType
        orderby at.AddressTypeID
        select at;
      var addressTypeEntities = addressTypes.ToEntityCollection();
      TestShowSelfServicingInGrid(addressTypeEntities, 2);
      TestShowSelfServicingInGrid(addressTypeEntities.DefaultView, 3);
      TestShowSelfServicingInGrid(addressTypes.AsEnumerable(), 3);
      TestShowInGrid(addressTypeEntities.AsQueryable());
    }

    [TestCategory("Winforms"), TestMethod]
    public void ShowAdapterInGridTest()
    {
      EditAdapterInDataGridViewTestHelper<CustomerEntity>(12);
    }

    /// <summary>
    ///   A test for PopulateTreeViewWithSchema
    /// </summary>
    [TestMethod]
    public void PopulateTreeViewWithSchemaTest()
    {
      TestPopulateTreeViewWithSchema(EntityTreeView, null, null);
    }

    /// <summary>
    ///   A test for PopulateTreeViewWithSchema
    /// </summary>
    [TestMethod]
    public void PopulateTreeViewWithSchemaCommonEntityBaseTest()
    {
      TestPopulateTreeViewWithSchema(EntityTreeView, typeof (CommonEntityBase), null);
    }

    /// <summary>
    ///   A test for PopulateTreeViewWithSchema
    /// </summary>
    [TestMethod]
    public void PopulateTreeViewWithSchemaILinqMetaDataTest()
    {
      TestPopulateTreeViewWithSchema(EntityTreeView, null, MetaSingletons.MetaData);
    }

    /// <summary>
    ///   A test for PopulateTreeViewWithSchema
    /// </summary>
    [TestMethod]
    public void PopulateTreeViewWithSchemaDataContextTypeTest()
    {
      EntityTreeView.Nodes.Clear();
      LLBLWinformHelper.PopulateTreeViewWithSchema(EntityTreeView.Nodes, MetaSingletons.MetaData.GetType());
      EntityHelperTest.NumberOfEntities.Should().BeLessOrEqualTo(EntityTreeView.Nodes.Count);
      var treeNodes = EntityTreeView.Nodes.Cast<TreeNode>().Descendants(tn => tn.Nodes.Cast<TreeNode>()).ToList();
      NumSchemaObjects.Should().BeLessOrEqualTo(treeNodes.Count());
    }

    private static IEnumerable<Type> GetEntitiesTypes(Type baseType, ILinqMetaData linqMetaData)
    {
      return baseType == null ? (linqMetaData == null ? EntityHelper.GetEntitiesTypes() : EntityHelper.GetEntitiesTypes(linqMetaData.GetType().Assembly)) : MetaDataHelper.GetDescendants(baseType);
    }

    private static void TestPopulateTreeViewWithSchema(TreeView entityTreeView, Type baseType, ILinqMetaData linqMetaData)
    {
      TestPopulateTreeViewWithSchema(entityTreeView, GetEntitiesTypes(baseType, linqMetaData));
    }

    private static void TestPopulateTreeViewWithSchema(TreeView entityTreeView, IEnumerable<Type> entitiesTypes)
    {
      LLBLWinformHelper.PopulateTreeViewWithSchema(entityTreeView, entitiesTypes, false);
      Assert.AreEqual(entitiesTypes.Count(), entityTreeView.Nodes.Count, "entityTreeView.Nodes.Count");
      if (entityTreeView.Nodes.Count == EntityHelperTest.NumberOfEntities)
        Assert.AreEqual(NumSchemaObjects, entityTreeView.Nodes.Cast<TreeNode>().Descendants(tn => tn.Nodes.Cast<TreeNode>()).Count(), "NumSchemaObjects");
    }

    /// <summary>
    ///A test for PopulateTreeViewWithSchema
    ///</summary>
    //[TestMethod()]
    //public void PopulateTreeViewWithSchemaTest1()
    //{
    //  TreeNodeCollection schemaTreeNodeCollection = null; // TODO: Initialize to an appropriate value
    //  IEnumerable<Type> entitiesTypes = null; // TODO: Initialize to an appropriate value
    //  LLBLWinformHelper.PopulateTreeViewWithSchema(schemaTreeNodeCollection, entitiesTypes);
    //  Assert.Inconclusive("A method that does not return a value cannot be verified.");
    //}
  }
}