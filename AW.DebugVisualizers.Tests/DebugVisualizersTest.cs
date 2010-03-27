using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers;
using Microsoft.VisualStudio.DebuggerVisualizers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.DebugVisualizers.Tests
{
  /// <summary>
  /// Summary description for DebugVisualizersTest
  /// </summary>
  [TestClass]
  public class DebugVisualizersTest
  {
    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext { get; set; }

    #region Additional test attributes

    //
    // You can use the following additional attributes as you write your tests:
    //
    // Use ClassInitialize to run code before running the first test in the class
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // Use ClassCleanup to run code after all tests in a class have run
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    // Use TestInitialize to run code before running each test 
    // [TestInitialize()]
    // public void MyTestInitialize() { }
    //
    // Use TestCleanup to run code after each test has run
    // [TestCleanup()]
    // public void MyTestCleanup() { }
    //

    #endregion


    [TestMethod]
    public void DataTableTest()
    {
			var nonSerializableClasseDataTable = GeneralHelper.CopyToDataTable(NonSerializableClass.GenerateList());
			TestSerialize(nonSerializableClasseDataTable);
			TestSerialize(nonSerializableClasseDataTable.DefaultView);

			var serializableClassDataTable = GeneralHelper.CopyToDataTable(SerializableClass.GenerateList());
			TestSerialize(serializableClassDataTable);
			TestSerialize(serializableClassDataTable.DefaultView);

			var dt = new DataSet();
			var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
			addressTypeEntityCollection.CreateHierarchicalProjection(dt);
			TestShow(dt.Tables[0]);
			TestSerialize(dt.Tables[0].DefaultView);

			//var addressTypeDataTable = GeneralHelper.CopyToDataTable(MetaSingletons.MetaData.AddressType);
			//TestSerialize(addressTypeDataTable);
			//TestSerialize(addressTypeDataTable.DefaultView);
    }

    [TestMethod]
    public void SerializableEnumerableTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
			TestSerialize(addressTypeEntityCollection);
			TestSerialize(SerializableBaseClass.GenerateList());
    	TestSerialize(addressTypeEntityCollection.First().CustomPropertiesOfType);
			TestShow(SerializableBaseClass2.GenerateListWithBothSerializableClasses());
			TestSerialize(SerializableClass.GenerateList());
    }

    [TestMethod]
    public void NonSerializableEnumerationTest()
    {
			TestSerialize(MetaSingletons.MetaData.AddressType);
			TestSerialize(MetaSingletons.MetaData.AddressType.Where(at => at.AddressTypeID > 2));
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
			TestSerialize(addressTypeEntityCollection.DefaultView);
			TestSerialize(new BindingSource(addressTypeEntityCollection, null));
			TestSerialize(addressTypeEntityCollection.Where(at => at.AddressTypeID > 2));
    }

    [TestMethod]
    public void NonSerializableItemTest()
    {
			var listofNonSerializableClasses = NonSerializableClass.GenerateList();
			TestSerialize(listofNonSerializableClasses);
      listofNonSerializableClasses.Insert(0, new SerializableClass {DateTimeField = DateTime.Now, IntField = listofNonSerializableClasses.Count, StringField = listofNonSerializableClasses.Count.ToString()});
			TestSerialize(listofNonSerializableClasses);
			TestSerialize(new ArrayList(listofNonSerializableClasses));
    	TestShow(MetaDataHelper.GetPropertiesToDisplay(typeof (AddressTypeEntity)));
    }

		public static void TestSerialize(object enumerableToVisualize)
		{
			var enumerableVisualizerObjectSource = new EnumerableVisualizerObjectSource();
			var memoryStream = new MemoryStream();
			enumerableVisualizerObjectSource.GetData(enumerableToVisualize, memoryStream);
			memoryStream.Position = 0;			
			var value = VisualizerObjectSource.Deserialize(memoryStream);
			if (!(value is DataTableSurrogate) && !(value is IListSource) && value.GetType() != enumerableToVisualize.GetType())
				Assert.IsInstanceOfType(value, typeof(IBindingListView)); ;
		}

		public static void TestShow(object enumerableOrDataTableToVisualize)
    {
			var visualizerHost = new VisualizerDevelopmentHost(enumerableOrDataTableToVisualize, typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource));
      visualizerHost.ShowVisualizer();
    }

  }

}