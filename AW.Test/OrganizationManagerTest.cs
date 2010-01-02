using System.Data;
using System.Windows.Forms;
using AW.Data.EntityClasses;
using AW.Win;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Test
{
  /// <summary>
  ///This is a test class for OrganizationManagerTest and is intended
  ///to contain all OrganizationManagerTest Unit Tests
  ///</summary>
  [TestClass]
  public class OrganizationManagerTest
  {
    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext { get; set; }

    #region Additional test attributes

    private const int SyedAbbasID = 288;
    private const string SyedAbbas = "Abbas, Syed [288]";
    private const string SyedAbbas_ = "Abbas, Syed [288 ]";
    private const string KenSánchez = "Sánchez, Ken [109 ]";
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
    //[TestInitialize()]
    //public void MyTestInitialize()
    //{
    //}
    //
    //Use TestCleanup to run code after each test has run
    //[TestCleanup()]
    //public void MyTestCleanup()
    //{
    //}
    //

    #endregion

    /// <summary>
    ///A test for MakeNode
    ///</summary>
    [TestMethod(), Ignore]
    public void MakeNodeTest()
    {
      EmployeeEntity Employee = null; // TODO: Initialize to an appropriate value
      TreeNode expected = null; // TODO: Initialize to an appropriate value
      TreeNode actual = OrganizationManager.MakeNode(Employee);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for GetPrefetchedEmployeeEntity
    ///</summary>
    [TestMethod]
    public void GetPrefetchedEmployeeEntityTest()
    {
      var actual = OrganizationManager.GetPrefetchedEmployeeEntity(SyedAbbasID);
      Assert.AreEqual(SyedAbbasID, actual.EmployeeID);
    }

    /// <summary>
    ///A test for GetMasterNode
    ///</summary>
    [TestMethod]
    public void GetMasterNodeTest()
    {
      var actual = OrganizationManager.GetMasterNode(SyedAbbasID);
      Assert.AreEqual("TreeNode: Sánchez, Ken [109]", actual.ToString());
    }

    /// <summary>
    ///A test for GetManagersRecursive
    ///</summary>
    [TestMethod]
    public void GetManagersRecursiveTest1()
    {
      EmployeeEntityBase Employee = new EmployeeEntity(SyedAbbasID);
      var actual = OrganizationManager.GetManagersRecursive(Employee);
      Assert.AreEqual(KenSánchez, actual.Text);
    }

    /// <summary>
    ///A test for GetManagersRecursive
    ///</summary>
    [TestMethod]
    public void GetManagersRecursiveTest()
    {
      var actual = OrganizationManager.GetManagersRecursive(new EmployeeEntity(SyedAbbasID));
      Assert.AreEqual(KenSánchez, actual.Text);
    }

    /// <summary>
    ///A test for GetManagerEmployees
    ///</summary>
    [TestMethod(), Ignore]
    public void GetManagerEmployeesTest()
    {
      TreeNode MasterNode = null; // TODO: Initialize to an appropriate value
      OrganizationManager.GetManagerEmployees(SyedAbbasID, MasterNode);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }

    /// <summary>
    ///A test for GetEmployeesRecursive
    ///</summary>
    [TestMethod]
    public void GetEmployeesRecursiveTest1()
    {
      var actual = OrganizationManager.GetEmployeesRecursive(new EmployeeEntity(SyedAbbasID));
      Assert.AreEqual(SyedAbbas_, actual.Text);
    }

    /// <summary>
    ///A test for GetEmployeesRecursive
    ///</summary>
    [TestMethod]
    public void GetEmployeesRecursiveTest()
    {
      EmployeeEntityBase Employee = new EmployeeEntity(SyedAbbasID);
      var actual = OrganizationManager.GetEmployeesRecursive(Employee);
      Assert.AreEqual(SyedAbbas, actual.Text);
    }

    /// <summary>
    ///A test for GetChildRow
    ///</summary>
    [TestMethod(), Ignore]
    public void GetChildRowTest()
    {
      DataRow row = null; // TODO: Initialize to an appropriate value
      DataTable table = null; // TODO: Initialize to an appropriate value
      DataRow expected = null; // TODO: Initialize to an appropriate value
      DataRow actual = OrganizationManager.GetChildRow(row, table);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for FindLowestNode
    ///</summary>
    [TestMethod(), Ignore]
    public void FindLowestNodeTest()
    {
      TreeNode Node = null; // TODO: Initialize to an appropriate value
      TreeNode expected = null; // TODO: Initialize to an appropriate value
      TreeNode actual = OrganizationManager.FindLowestNode(Node);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for FindEmployeeRecursive
    ///</summary>
    [TestMethod(), Ignore]
    public void FindEmployeeRecursiveTest()
    {
      TreeNodeCollection Nodes = null; // TODO: Initialize to an appropriate value
      TreeNode expected = null; // TODO: Initialize to an appropriate value
      TreeNode actual = OrganizationManager.FindEmployeeRecursive(SyedAbbasID, Nodes);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for CreateNode
    ///</summary>
    [TestMethod(),Ignore]
    public void CreateNodeTest()
    {
      DataRow row = null; // TODO: Initialize to an appropriate value
      TreeNodeCollection Nodes = null; // TODO: Initialize to an appropriate value
      OrganizationManager.CreateNode(row, Nodes);
      Assert.Inconclusive("A method that does not return a value cannot be verified.");
    }
  }
}