﻿using System;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper.LLBL;
using AW.Test.Helpers;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class for FrmEntitiesAndFieldsTest and is intended
  ///   to contain all FrmEntitiesAndFieldsTest Unit Tests
  /// </summary>
  [TestClass]
  public class FrmEntitiesAndFieldsTest : NUnitFormMSTest
  {
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
    [TestInitialize]
    public void MyTestInitialize()
    {
      Init();
    }

    //Use TestCleanup to run code after each test has run
    [TestCleanup]
    public void MyTestCleanup()
    {
      Verify();
    }

    #endregion

    /// <summary>
    ///   A test for ShowEntitiesAndFields
    /// </summary>
    [TestCategory("Winforms"), TestMethod]
    public void ShowEntitiesAndFieldsTest()
    {
      if (EntityHelper.GetEntitiesTypes().Count() == EntityHelperTest.NumberOfEntities)
        TestShowEntitiesAndFields(null, null);
    }

    [TestMethod]
    public void ShowEntitiesAndFieldsILinqMetaDataTest()
    {
      TestShowEntitiesAndFields(null, MetaSingletons.MetaData);
    }

    [TestMethod]
    public void ShowEntitiesAndFieldsCommonEntityBaseTest()
    {
      TestShowEntitiesAndFields(typeof(CommonEntityBase), null);
    }

    private void TestShowEntitiesAndFields(Type baseType, ILinqMetaData linqMetaData)
    {
      ModalFormHandler = Handler;
      var form = baseType == null ? (linqMetaData == null ? new FrmEntitiesAndFields() : new FrmEntitiesAndFields(linqMetaData, false)) : new FrmEntitiesAndFields(baseType, false);
      AWHelper.ShowForm(form);
      Assert.AreEqual(EntityHelperTest.NumberOfEntities, _rootNodesCount, "EntityHelperTest.NumberOfEntities");
      Assert.AreEqual(LLBLWinformHelperTest.NumSchemaObjects, _nodesCount, "LLBLWinformHelperTest.NumSchemaObjects");
      _nodesCount = null;
    }

    private int? _rootNodesCount;
    private int? _nodesCount;

    private void Handler(string name, IntPtr hWnd, Form form)
    {
      var treeNodeCollection = GetTreeViewEntitiesFromFrmEntitiesAndFields(form).Nodes;
      _rootNodesCount = treeNodeCollection.Count;
      _nodesCount = treeNodeCollection.GetAllNodes().Count();
      form.Close();
    }

    private static TreeView GetTreeViewEntitiesFromFrmEntitiesAndFields(Form form)
    {
      return form.GetAllContainedControls().First(c => c is TreeView) as TreeView;
    }
  }
}