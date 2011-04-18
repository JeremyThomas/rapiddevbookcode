using System.Linq;
using AW.Data;
using AW.Data.FactoryClasses;
using AW.Data.Linq;
using AW.Helper;
using AW.LLBLGen.DataContextDriver.Static;
using LINQPad.Extensibility.DataContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AW.LLBLGen.DataContextDriver.Tests
{
	/// <summary>
	///This is a test class for LLBLGenStaticDriverTest and is intended
	///to contain all LLBLGenStaticDriverTest Unit Tests
	///</summary>
	[TestClass]
	public class LLBLGenStaticDriverTest
	{
		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
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
		///A test for GetSchema
		///</summary>
		[TestMethod, Ignore]
		public void GetAWSchemaTest()
		{
			var target = new LLBLGenStaticDriver();
			var mockedIConnectionInfo = new Mock<IConnectionInfo>();
			var customType = typeof (LinqMetaData);
			var entityTypes = GeneralHelper.EnumAsEnumerable<EntityType>();
			var actual = target.GetSchema(mockedIConnectionInfo.Object, customType);
			Assert.AreEqual(entityTypes.Length, actual.Count);
			var orderedEnumerable = entityTypes.OrderBy(et => et.ToString().Replace("Entity", ""));
			var index = 0;
			foreach (var entityType in orderedEnumerable)
			{
				var entityFactory = EntityFactoryFactory.GetFactory(entityType);
				var fields = entityFactory.CreateFields();
				var explorerItem = actual[index];
				index++;
				Assert.AreEqual(fields.Count, explorerItem.Children.Count(ei => ei.Kind == ExplorerItemKind.Property), entityFactory.ForEntityName + " - " + explorerItem.Text);
			}
		}

		/// <summary>
		///A test for GetSchema
		///</summary>
		[TestMethod]
		public void GetNorthwindSchemaTest()
		{
			var target = new LLBLGenStaticDriver();
			var mockedIConnectionInfo = new Mock<IConnectionInfo>();
			var customType = typeof (Northwind.DAL.Linq.LinqMetaData);
			var entityTypes = GeneralHelper.EnumAsEnumerable<Northwind.DAL.EntityType>();
			var actual = target.GetSchema(mockedIConnectionInfo.Object, customType);
			Assert.AreEqual(entityTypes.Length, actual.Count);
			var orderedEnumerable = entityTypes.OrderBy(et => et.ToString().Replace("Entity", ""));
			var index = 0;
			foreach (var entityType in orderedEnumerable)
			{
				var entityFactory = Northwind.DAL.FactoryClasses.EntityFactoryFactory.GetFactory(entityType);
				var fields = entityFactory.CreateFields();
				var explorerItem = actual[index];
				index++;
				Assert.AreEqual(fields.Count, explorerItem.Children.Count(ei => ei.Kind == ExplorerItemKind.Property), entityFactory.ForEntityName + " - " + explorerItem.Text);
			}
		}
	}
}