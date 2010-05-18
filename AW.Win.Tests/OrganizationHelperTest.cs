using System.Windows.Forms;
using AW.Data.EntityClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Win.Tests
{
  /// <summary>
  ///This is a test class for OrganizationHelper and is intended
  ///to contain all OrganizationHelper Unit Tests
  ///</summary>
  [TestClass]
  public class OrganizationHelperTest
  {
    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext { get; set; }

    #region Additional test attributes

    private const int SyedAbbasID = 288;
    private const string SyedAbbas = "Abbas, Syed [288]";
    private const int KenSánchezID = 109;
    private const string KenSánchez = "Sánchez, Ken [109]";
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
    ///A test for GetEmployeeManagersNodes
    ///</summary>
    [TestMethod]
    public void GetMasterNodeTest()
    {
      var actual = OrganizationHelper.GetEmployeeManagersNodes(SyedAbbasID);
      Assert.AreEqual("TreeNode: Sánchez, Ken [109]", actual.ToString());
    }

    /// <summary>
    ///A test for GetManagersRecursive
    ///</summary>
    [TestMethod]
    public void GetManagersRecursiveTest1()
    {
      var employee = new EmployeeEntity(SyedAbbasID);
      var actual = OrganizationHelper.GetManagersRecursive(employee);
      Assert.AreEqual(KenSánchez, actual.Text);
    }

    /// <summary>
    ///A test for GetManagersRecursive
    ///</summary>
    [TestMethod]
    public void GetManagersRecursiveTest()
    {
      var actual = OrganizationHelper.GetManagersRecursive(new EmployeeEntity(SyedAbbasID));
      Assert.AreEqual(KenSánchez, actual.Text);
    }

    /// <summary>
    ///A test for GetEmployeesRecursive
    ///</summary>
    [TestMethod]
    public void GetEmployeesRecursiveTest1()
    {
      var actual = OrganizationHelper.GetEmployeesRecursive(new EmployeeEntity(SyedAbbasID));
      Assert.AreEqual(SyedAbbas, actual.Text);
    }

    /// <summary>
    ///A test for GetEmployeesRecursive
    ///</summary>
    [TestMethod]
    public void GetEmployeesRecursiveTest()
    {
      var employee = new EmployeeEntity(SyedAbbasID);
      var actual = OrganizationHelper.GetEmployeesRecursive(employee);
      Assert.AreEqual(SyedAbbas, actual.Text);
    }


    /// <summary>
    ///A test for ShowEmployeesPlaceInOrganization
    ///</summary>
    [TestMethod]
    public void ShowEmployeesPlaceInOrganizationTest()
    {
      var treeView = new TreeView();
      var employee = new EmployeeEntity(SyedAbbasID);
      OrganizationHelper.ShowEmployeesPlaceInOrganization(employee, treeView.Nodes);
      Assert.AreEqual(4, treeView.GetNodeCount(true));

      employee = new EmployeeEntity(KenSánchezID);
      OrganizationHelper.ShowEmployeesPlaceInOrganization(employee, treeView.Nodes);
      Assert.AreEqual(1, treeView.Nodes.Count);
      Assert.AreEqual(KenSánchez, treeView.Nodes[0].Text);
      Assert.AreEqual(290, treeView.GetNodeCount(true));
    }

    /// <summary>
    ///A test for ShowEmployeesPlaceInOrganization
    ///</summary>
    [TestMethod]
    public void ShowEmployeesPlaceInOrganizationTestSP()
    {
      var treeView = new TreeView();
      OrganizationHelper.ShowEmployeesPlaceInOrganization(SyedAbbasID, treeView.Nodes);
      Assert.AreEqual(4, treeView.GetNodeCount(true));

      OrganizationHelper.ShowEmployeesPlaceInOrganization(KenSánchezID, treeView.Nodes);
      //Assert.AreEqual(1, treeView.Nodes.Count);
      //Assert.AreEqual(KenSánchez, treeView.Nodes[0].Text);
      //Assert.AreEqual(290, treeView.GetNodeCount(true));
    }
  }
}