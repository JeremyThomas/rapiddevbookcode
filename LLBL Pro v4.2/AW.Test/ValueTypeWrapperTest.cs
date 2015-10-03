using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;
using AW.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class for ValueTypeWrapperTest and is intended
  ///   to contain all ValueTypeWrapperTest Unit Tests
  /// </summary>
  [TestClass]
  public class ValueTypeWrapperTest
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

    private List<ValueTypeWrapper<T>> CreateWrapperForBindingTestHelper<T>(params T[] values)
    {
      return CreateWrapperForBindingTestHelper((IEnumerable<T>) values);
    }

    /// <summary>
    ///   A test for CreateWrapperForBinding
    /// </summary>
    private List<ValueTypeWrapper<T>> CreateWrapperForBindingTestHelper<T>(IEnumerable<T> values)
    {
      var actual = ValueTypeWrapper<T>.CreateWrapperForBinding(values);
      Assert.IsNotNull(actual);
      Assert.IsInstanceOfType(actual, typeof (IEnumerable<ValueTypeWrapper<T>>));
      var expectedCount = values.IsNullOrEmpty() ? 0 : values.Count();
      Assert.AreEqual(expectedCount, actual.Count());
      if (values.IsNullOrEmpty())
        Assert.IsFalse(actual.Contains(new ValueTypeWrapper<T> {Value = default(T)}));
      else
        foreach (var value in values)
          Assert.IsTrue(actual.Contains(new ValueTypeWrapper<T> {Value = value}));
      foreach (var valueTypeWrapper in actual)
        valueTypeWrapper.GetHashCode();
      var actualList = actual.ToList();
      CollectionAssert.AreEqual(ValueTypeWrapper<T>.CreateWrapperForBinding(values).ToList(), actualList);
      return actualList;
    }

    [TestMethod]
    public void CreateWrapperForBindingTest()
    {
      CreateWrapperForBindingTestHelper("one", "two", null);
      CreateWrapperForBindingTestHelper(1, 2);
      CreateWrapperForBindingTestHelper((int?) 1, (int?) 2, (int?) null);
      CreateWrapperForBindingTestHelper(1.00, 2.00);
      CreateWrapperForBindingTestHelper((double?) 1.00, (double?) 2.00, (double?) null);
      CreateWrapperForBindingTestHelper(true, false);
    }

    /// <summary>
    ///   A test for CreateStringWrapperForBindingNullTest
    /// </summary>
    [TestMethod]
    public void CreateStringWrapperForBindingNullTest()
    {
      StringCollection nullStringCollection = null;
      CreateWrapperForBindingTestHelper(nullStringCollection.AsEnumerable());

      var strings = new StringCollection {"one", null};
      CreateWrapperForBindingTestHelper(strings.AsEnumerable());
    }

    /// <summary>
    ///   A test for CreateStringWrapperForBinding
    /// </summary>
    [TestMethod]
    public void CreateStringWrapperForBindingTest()
    {
      var strings = new StringCollection {"one", "two"};
      var stringsAsEnumerable = strings.AsEnumerable();
      CreateWrapperForBindingTestHelper(stringsAsEnumerable);
      var expected = ValueTypeWrapper<string>.CreateWrapperForBinding(stringsAsEnumerable).ToList();
      var actual = strings.CreateStringWrapperForBinding();
      CollectionAssert.AreEqual(expected, actual.ToList());
    }

    [TestMethod]
    public void StringWrapperAddTest()
    {
      var strings = new StringCollection {"one", "two"};
      var actual = CreateWrapperForBindingTestHelper(strings.AsEnumerable());
      ValueTypeWrapper<string>.Add(actual, "one", "two");
      Assert.AreEqual(strings.Count, actual.Count());
    }

    [TestMethod]
    public void StringPropertiesTest()
    {
      var strings = new[] {"one", "two", "a string"};
      var stringWrapperForBinding = strings.CreateStringWrapperForBinding().ToList();
      AssertStringWrapperProperties(stringWrapperForBinding);
      AssertStringWrapperProperties(ValueTypeWrapper.CreateWrapperForBinding(strings));
      //stringWrapperForBinding.ShowInGrid(null);
      //strings.ShowInGrid(null);

      //TypeDescriptor.AddProvider(new StringTypeDescriptorProvider(typeof(string)), typeof(string));
      //var stringProperties = ListBindingHelper.GetListItemProperties(strings);
      //Assert.AreEqual(1, stringProperties.Count);
      //Assert.AreEqual(typeof(string), stringProperties[0].PropertyType);
      //strings.ShowInGrid(null);
    }

    private static void AssertStringWrapperProperties(IEnumerable stringWrapperForBinding)
    {
      var stringWrapperProperties = ListBindingHelper.GetListItemProperties(stringWrapperForBinding);
      Assert.AreEqual(1, stringWrapperProperties.Count);
      Assert.AreEqual(typeof (string), stringWrapperProperties[0].PropertyType);
    }
  }
}