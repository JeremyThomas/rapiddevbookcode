using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Helper.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
	///<summary>
	///	This is a test class for DataTableSurrogateTest and is intended
	///	to contain all DataTableSurrogateTest Unit Tests
	///</summary>
	[TestClass]
	public class DataTableSurrogateTest
	{
		///<summary>
		///	Gets or sets the test context which provides
		///	information about and functionality for the current test run.
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

		///<summary>
		///	A test for DataTableSurrogate Constructor
		///</summary>
		[TestMethod]
		public void DataTableSurrogateSerializeDeserializeTest()
		{
			TestDataTableSurrogateSerializeDeserialize(GeneralHelper.CopyToDataTable(NonSerializableClass.GenerateList()));
			TestDataTableSurrogateSerializeDeserialize(GeneralHelper.CopyToDataTable(SerializableClass.GenerateList()));
			var dt = new DataSet();
			var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
			addressTypeEntityCollection.CreateHierarchicalProjection(dt);
			TestDataTableSurrogateSerializeDeserialize(dt.Tables[0]);
			TestDataTableSurrogateSerializeDeserialize(GeneralHelper.CopyToDataTable(MetaDataHelper.GetPropertiesToDisplay(typeof (AddressTypeEntity))));
			//TestDataTableSurrogateSerializeDeserialize(GeneralHelper.CopyToDataTable(MetaSingletons.MetaData.AddressType));
		}

		private static void TestDataTableSurrogateSerializeDeserialize(DataTable datatable)
		{
			var target = new DataTableSurrogate(datatable);
			var memoryStream = new MemoryStream();
			var binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, target);
			memoryStream.Position = 0;
			var result = binaryFormatter.Deserialize(memoryStream) as DataTableSurrogate;
			Assert.IsNotNull(result);
			var resultDataTable = result.ConvertToDataTable();
			Assert.AreEqual(datatable.Columns.Count, resultDataTable.Columns.Count);
			Assert.AreEqual(datatable.Rows.Count, resultDataTable.Rows.Count);
			//CollectionAssert.AreEqual(datatable.DefaultView, resultDataTable.DefaultView);
		}
	}
}