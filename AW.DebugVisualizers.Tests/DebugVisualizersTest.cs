using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
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
    public void SerializableEnumerableTest()
    {
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      TestShow(addressTypeEntityCollection);
    }

    [TestMethod]
    public void NonSerializableEnumerableTest()
    {
      TestShow(MetaSingletons.MetaData.AddressType);
      TestShow(MetaSingletons.MetaData.AddressType.Where(at => at.AddressTypeID > 2));
      TestShow(GetListofNonSerializableClasses());
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      TestShow(addressTypeEntityCollection.DefaultView);
      TestShow(new BindingSource(addressTypeEntityCollection, null));
      TestShow(addressTypeEntityCollection.Where(at => at.AddressTypeID > 2));
    }

    private static IEnumerable<NonSerializableClass> GetListofNonSerializableClasses()
    {
      var list = new List<NonSerializableClass>();
      for (var i = 0; i < 10; i++)
        list.Add(new NonSerializableClass {DateTimeField = DateTime.Now, IntField = list.Count, StringField = list.Count.ToString()});


      return list;
    }

    public static void TestShow(IEnumerable enumerableToVisualize)
    {
      var visualizerHost = new VisualizerDevelopmentHost(enumerableToVisualize, typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource));
      visualizerHost.ShowVisualizer();
    }

    /// <summary>
    ///A test for Serialize
    ///</summary>
    [TestMethod()]
    public void SerializeTest()
    {
      IList list = new List<int>();
      Stream outgoingData = new MemoryStream();
      Type itemType = BindingListHelper.GetEnumerableItemType(list);
      EnumerableVisualizerObjectSource.Serialize(list, outgoingData, itemType);
    }
  }

  public class NonSerializableClass
  {
    public int IntField;
    public string StringField;
    public DateTime DateTimeField;
  }
}