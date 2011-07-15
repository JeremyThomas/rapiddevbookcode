using System.Linq;
using AW.Winforms.Helpers.ConnectionUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Data.ConnectionUI;

namespace AW.Tests
{
		
		
		/// <summary>
		///This is a test class for DataConnectionConfigurationTest and is intended
		///to contain all DataConnectionConfigurationTest Unit Tests
		///</summary>
	[TestClass()]
	public class DataConnectionConfigurationTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

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
		///A test for LoadConfiguration
		///</summary>
		[TestMethod()]
		public void LoadConfigurationTest()
		{
			var dcd = new DataConnectionDialog();
			var dcs = new DataConnectionConfiguration(null);
			dcs.LoadConfiguration(dcd);
			string systemDataSqlite = "System.Data.SQLite";
			DataSource dataSource = dcd.DataSources.FirstOrDefault(d => d.Name == systemDataSqlite);
			Assert.IsNotNull(dataSource);
			Assert.AreEqual(systemDataSqlite,dataSource.Providers.First().Name);
		}

		[TestMethod()]
		public void DataConnectionDialogTest()
		{
			var dcd = new DataConnectionDialog();
			var dcs = new DataConnectionConfiguration(null);
			dcs.LoadConfiguration(dcd);
			//dcd.SelectedDataSource = dcd.UnspecifiedDataSource;
			//dcd.ShowDialog();
			DataConnectionDialog.Show(dcd);
		}
	}
}
