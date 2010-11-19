using System.Linq;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using AW.Helper.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
	/// <summary>
	///This is a test class for EntityHelpe and is intended
	///to contain all EntityHelper Unit Tests
	///</summary>
	[TestClass]
	public class EntityHelperTest
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

		public static void ToEntityCollectionTestHelper<T>() where T : CommonEntityBase
		{
			var query = MetaSingletons.MetaData.GetQueryableForEntity<T>();
			var expected = FetchEntityCollection<T>();

			var actual = query.ToEntityCollection(); //DataSourceBase
			CollectionAssert.AreEqual(expected, actual);

			actual = query.Distinct().ToEntityCollection(); //LLBLGenProQuery
			CollectionAssert.AreEqual(expected, actual);

			CollectionAssert.AreEqual(expected, actual.Distinct().ToEntityCollection()); //IEnumerable<T> 

			var actualQueryable = actual.AsQueryable().ToEntityCollection();
			CollectionAssert.AreEqual(expected, actualQueryable); //IQueryable not ILLBLGenProQuery

			var emptyCollection = FactoryHelper.CreateEntityCollection<T>();
			CollectionAssert.AreEqual(emptyCollection, emptyCollection.Distinct().ToEntityCollection()); //IEnumerable<T> 
		}

		private static EntityCollectionBase<T> FetchEntityCollection<T>() where T : EntityBase
		{
			var expected = FactoryHelper.CreateEntityCollection<T>();
			expected.GetMulti(null);
			return expected;
		}

		[TestMethod, Description("A test for ToEntityCollection")]
		public void ToEntityCollectionTest()
		{
			ToEntityCollectionTestHelper<AddressTypeEntity>();
		}

		[TestMethod, Description("A test for GetEntitiesTypes")]
		public void GetEntitiesTypesTest()
		{
			var allLoadedDescendanceEntitiesType = EntityHelper.GetEntitiesTypes().ToList();
			var commonEntityBaseEntitiesType = EntityHelper.GetEntitiesTypes(typeof(CommonEntityBase)).ToList();
			var assemblyEntitiesType = EntityHelper.GetEntitiesTypes(MetaSingletons.MetaData.GetType().Assembly).ToList();
			CollectionAssert.AreEqual(allLoadedDescendanceEntitiesType, commonEntityBaseEntitiesType);
			CollectionAssert.AreEqual(commonEntityBaseEntitiesType, assemblyEntitiesType);
		}
	}
}