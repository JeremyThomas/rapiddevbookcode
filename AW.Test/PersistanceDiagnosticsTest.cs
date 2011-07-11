using System;
using System.Linq;
using System.Text;
using AW.Data;
using AW.Helper.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.Linq;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using EntityType = Northwind.DAL.EntityType;

namespace AW.Tests
{
	/// <summary>
	///This is a test class for PersistanceDiagnosticsTest and is intended
	///to contain all PersistanceDiagnosticsTest Unit Tests
	///</summary>
	[TestClass]
	public class PersistanceDiagnosticsTest
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

		public static LinqMetaData GetNorthwindLinqMetaData()
		{
			return new LinqMetaData {AdapterToUse = new DataAccessAdapter()};
		}

		/// <summary>
		///A test for CheckAllEntitiesCanBeFetchedUsingLINQ
		///</summary>
		[TestMethod]
		public void CheckAlltNorthWindEntitiesCanBeFetchedUsingLINQTest()
		{
			var errors = PersistanceDiagnostics.CheckAllEntitiesCanBeFetchedUsingLINQ<EntityType>(GetNorthwindLinqMetaData(), 1);
			Assert.AreEqual(0, errors.Length, errors.ToString());
		}

		[TestMethod, Ignore]
		public void CheckAllAWEntitiesCanBeFetchedUsingLINQTest()
		{
			var errors = PersistanceDiagnostics.CheckAllEntitiesCanBeFetchedUsingLINQ<Data.EntityType>(MetaSingletons.MetaData, 1);
			Assert.AreEqual(0, errors.Length, errors.ToString());
		}

		[TestMethod, Description("A test for CheckEntitiesCanBeFetched")]
		public void ChecktNorthWindEntitiesCanBeFetchedTes()
		{
			var errors = PersistanceDiagnostics.CheckEntitiesCanBeFetched<EntityType>(EntityFactoryFactory.GetFactory, new DataAccessAdapter(), 1);
			Assert.AreEqual(0, errors.Length, errors.ToString());
		}

		[TestMethod]
		public void CheckAWEntitiesCanBeFetchedTest()
		{
			var errors = PersistanceDiagnostics.CheckEntitiesCanBeFetched<Data.EntityType>(Data.FactoryClasses.EntityFactoryFactory.GetFactory, 1);
			Assert.AreEqual(0, errors.Length, errors.ToString());
		}

		/// <summary>
		///A test for GetEntityFieldInformation
		///</summary>
		[TestMethod]
		public void GettNorthWindEntityFieldInformationTest()
		{
			IDataAccessAdapter adapter = new DataAccessAdapter();
			var actual = PersistanceDiagnostics.GetEntityFieldInformation<EntityType>(adapter, EntityFactoryFactory.GetFactory);
			Assert.AreEqual(Enum.GetNames(typeof(EntityType)).Length, actual.Count());
		}

		[TestMethod]
		public void GeAWEntityFieldInformationTest()
		{
			var actual = EntityInformation.EntityInfoFactory<Data.EntityType>(Data.FactoryClasses.EntityFactoryFactory.GetFactory).OrderBy(fi => fi.Entity);
			Assert.AreEqual(Enum.GetNames(typeof(Data.EntityType)).Length, actual.Count());
		}

		/// <summary>
		///A test for ExecuteQueryAndReadEveryBindableProperty
		///</summary>
		[TestMethod, Ignore]
		public void ExecuteQueryAndReadEveryBindablePropertyTest()
		{
			ILLBLGenProQuery query = null; // TODO: Initialize to an appropriate value
			StringBuilder errors = null; // TODO: Initialize to an appropriate value
			PersistanceDiagnostics.ExecuteQueryAndReadEveryBindableProperty(query, errors);
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		/// <summary>
		///A test for ReadEveryBindableProperty
		///</summary>
		[TestMethod, Ignore]
		public void ReadEveryBindablePropertyTest()
		{
			IEntityCollection2 entityCollection = null; // TODO: Initialize to an appropriate value
			StringBuilder errors = null; // TODO: Initialize to an appropriate value
			PersistanceDiagnostics.ReadEveryBindableProperty(entityCollection, errors);
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		/// <summary>
		///A test for ReadEveryBindableProperty
		///</summary>
		[TestMethod, Ignore]
		public void ReadEveryBindablePropertyTest1()
		{
			IEntity2 entity = null; // TODO: Initialize to an appropriate value
			StringBuilder expected = null; // TODO: Initialize to an appropriate value
			StringBuilder actual;
			actual = PersistanceDiagnostics.ReadEveryBindableProperty(entity);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}