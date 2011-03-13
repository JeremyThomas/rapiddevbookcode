using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using AW.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
	/// <summary>
	///This is a test class for ValueTypeWrapperTest and is intended
	///to contain all ValueTypeWrapperTest Unit Tests
	///</summary>
	[TestClass]
	public class ValueTypeWrapperTest
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
		///A test for CreateWrapperForBinding
		///</summary>
		public void CreateWrapperForBindingTestHelper<T>(IEnumerable<T> values)
		{
			var actual = ValueTypeWrapper<T>.CreateWrapperForBinding(values);
			Assert.IsNotNull(actual);
			Assert.IsInstanceOfType(actual, typeof (List<ValueTypeWrapper<string>>));
			var expectedCount = values.IsNullOrEmpty() ? 0 : values.Count();
			Assert.AreEqual(expectedCount, actual.Count);
		}

		[TestMethod]
		public void CreateWrapperForBindingTest()
		{
			var strings = new StringCollection {"one", "two"};
			CreateWrapperForBindingTestHelper(strings.AsEnumerable());
			StringCollection nullStringCollection = null;
			CreateWrapperForBindingTestHelper(nullStringCollection.AsEnumerable());
		}
	}
}