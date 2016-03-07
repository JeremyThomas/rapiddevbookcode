using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class for DataTableSurrogateTest and is intended
  ///   to contain all DataTableSurrogateTest Unit Tests
  /// </summary>
  [TestClass]
  public class DataTableBinarySerializationTest
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
    ///   A test for DataTableSurrogate Constructor
    /// </summary>
    [TestMethod]
    public void DataTableSurrogateSerializeDeserializeTest()
    {
      TestDataTableBinarySerializeDeserialize(GeneralHelper.CopyToDataTable(NonSerializableClass.GenerateList()));
      TestDataTableBinarySerializeDeserialize(GeneralHelper.CopyToDataTable(SerializableClass.GenerateList()));
      var dt = new DataSet();
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      addressTypeEntityCollection.CreateHierarchicalProjection(dt);
      TestDataTableBinarySerializeDeserialize(dt.Tables[0]);
      TestDataTableBinarySerializeDeserialize(GeneralHelper.CopyToDataTable(MetaDataHelper.GetPropertiesToDisplay(typeof (AddressTypeEntity))));
      //TestDataTableSurrogateSerializeDeserialize(GeneralHelper.CopyToDataTable(MetaSingletons.MetaData.AddressType));
    }

    /// <summary>
    ///   A test for DataTableSurrogate Constructor
    /// </summary>
    [TestMethod]
    public void DataTableSurrogateSerializeDeserializexmlSchemaTest()
    {
      var xmlSchema = TestData.GetTestXmlSchema();
      TestDataTableBinarySerializeDeserialize(xmlSchema.Items.CopyToDataTable(ObjectShredder.ShreddingMode.Safe));
    //  TestDataTableSurrogateSerializeDeserialize(xmlSchema.Items.CopyToDataTable());
    }

    [TestMethod]
    public void DataTableSurrogateSerializeDeserializeStringTest()
    {
      var enumerable = new[] {"s1", "s2", "s3"};
      var stringEnumerable = enumerable.Where(s => s.Length > 1);
      var datatable = GeneralHelper.CopyToDataTable(stringEnumerable);
      Assert.AreEqual(enumerable[0], datatable.Rows[0][0].ToString());
      TestDataTableBinarySerializeDeserialize(datatable);
    }

    private static void TestDataTableBinarySerializeDeserialize(DataTable datatable)
    {
      DataHelper.SetRemotingFormat(datatable);
      var memoryStream = new MemoryStream();
      var binaryFormatter = new BinaryFormatter();
      binaryFormatter.Serialize(memoryStream, datatable);
      memoryStream.Position = 0;
      var resultDataTable = binaryFormatter.Deserialize(memoryStream) as DataTable;
      Assert.IsNotNull(resultDataTable);
      Assert.AreEqual(datatable.Columns.Count, resultDataTable.Columns.Count);
      Assert.AreEqual(datatable.Rows.Count, resultDataTable.Rows.Count);
      //CollectionAssert.AreEqual(datatable.DefaultView, resultDataTable.DefaultView);
    }
  }
}