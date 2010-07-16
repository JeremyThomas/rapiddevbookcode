using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers;
using JesseJohnston;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
	/// <summary>
	///This is a test class for BindingListHelperTest and is intended
	///to contain all BindingListHelperTest Unit Tests
	///</summary>
	[TestClass]
	public class BindingListHelperTest
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

		[TestMethod]
		public void DifferentItemTypesTest()
		{
			var listofNonSerializableClasses = SerializableClass.GenerateListWithBothSerializableClasses();
			var bindingSource = new BindingSource();
			Assert.IsTrue(bindingSource.BindEnumerable((IEnumerable)listofNonSerializableClasses, false));
			Assert.AreEqual(listofNonSerializableClasses, bindingSource.List);

			TestBindEnumerable(listofNonSerializableClasses);
			TestBindEnumerable(SerializableClass.GenerateListWithBoth());
		}

		/// <summary>
		///A test for BindEnumerable
		///</summary>
		[TestMethod]
		public void BindEnumerableTest()
		{
			var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();

			Assert.AreEqual(addressTypeEntityCollection.DefaultView, TestBindEnumerable(addressTypeEntityCollection));
			Assert.AreEqual(addressTypeEntityCollection.DefaultView, TestBindEnumerable(addressTypeEntityCollection.DefaultView));

			TestBindEnumerable((IEnumerable)MetaSingletons.MetaData.AddressType);
			TestBindEnumerable(MetaSingletons.MetaData.AddressType);

			var dt = new DataSet();
			addressTypeEntityCollection.CreateHierarchicalProjection(dt);
			TestBindEnumerable(dt.Tables[0].DefaultView);

			TestBindEnumerable((IEnumerable)SerializableClass.GenerateList());
			TestBindEnumerable(SerializableClass.GenerateList());
		}

		private static IEnumerable<T> TestBindEnumerable<T>(IEnumerable<T> enumerable)
		{
			TestBindEnumerableReadonly(enumerable, true);
			var bindingSource = TestBindEnumerableReadonly(enumerable, false);
			return (IEnumerable<T>)bindingSource.List;
		}

		private static BindingSource TestBindEnumerableReadonly<T>(IEnumerable<T> enumerable, bool setReadonly)
		{
			var bindingSource = new BindingSource();
			Assert.IsTrue(bindingSource.BindEnumerable(enumerable, setReadonly));
			Assert.IsInstanceOfType(bindingSource.List, typeof (IBindingListView));
			return bindingSource;
		}

		private static IList TestBindEnumerable(IEnumerable enumerable)
		{
			TestBindEnumerableReadonly(enumerable, true);
			var bindingSource = TestBindEnumerableReadonly(enumerable, false);
			return bindingSource.List;
		}

		private static BindingSource TestBindEnumerableReadonly(IEnumerable enumerable, bool setReadonly)
		{
			var bindingSource = new BindingSource();
			Assert.IsTrue(bindingSource.BindEnumerable(enumerable, setReadonly));
			Assert.IsInstanceOfType(bindingSource.List, typeof (IBindingListView));
			// Assert.AreNotEqual(bindingSource.AllowEdit, setReadonly);
			return bindingSource;
		}

		[TestMethod]
		public void ToBindingListViewTest()
		{
			TestToBindingListView(MetaDataHelper.GetPropertiesToDisplay(typeof (AddressTypeEntity)));
			TestToBindingListView(((IEntity) MetaSingletons.MetaData.AddressType.First()).CustomPropertiesOfType);
			var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
			var list = TestToBindingListView(addressTypeEntityCollection.DefaultView);
			Assert.AreEqual(addressTypeEntityCollection.DefaultView, list);

			Assert.AreEqual(addressTypeEntityCollection.DefaultView, TestToBindingListView(addressTypeEntityCollection));
			CollectionAssert.AreEqual(addressTypeEntityCollection, TestToBindingListView(addressTypeEntityCollection.AsQueryable()));
			CollectionAssert.AreEqual(addressTypeEntityCollection, TestToBindingListView(addressTypeEntityCollection.Cast<CommonEntityBase>()));

			TestToBindingListView(MetaSingletons.MetaData.AddressType);

			var dt = new DataSet();
			addressTypeEntityCollection.CreateHierarchicalProjection(dt);
			var dataTable = dt.Tables[0];
			Assert.AreEqual(dataTable.DefaultView, TestListSourceToBindingListView(dataTable));

			var enumerable = Enumerable.Range(1, 100);
			var actual = TestToBindingListView(enumerable);
			CollectionAssert.AreEqual(enumerable.ToList(), actual);

			Assert.IsNull("A string".ToBindingListView());

			Assert.IsNull((new[] {"s1", "s2", "s3"}).ToBindingListView());

			TestToBindingListView(SerializableClass.GenerateList().ToBindingListView());
		}

		private static IBindingListView TestToBindingListView(IEnumerable enumerable)
		{
			var bindingListView = enumerable.ToBindingListView();
			Assert.IsInstanceOfType(bindingListView, typeof (IBindingListView));
			Assert.IsTrue(bindingListView.Count > 0);
			return bindingListView;
		}

		[TestMethod]
		public void ListSourceToBindingListViewTest()
		{
			var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();

			var dt = new DataSet();
			addressTypeEntityCollection.CreateHierarchicalProjection(dt);
			var dataTable = dt.Tables[0];
			Assert.AreEqual(dataTable.DefaultView, TestListSourceToBindingListView(dataTable));
		}

		private static IBindingListView TestListSourceToBindingListView(IListSource enumerable)
		{
			var bindingListView = BindingListHelper.ListSourceToBindingListView(enumerable);
			Assert.IsInstanceOfType(bindingListView, typeof (IBindingListView));
			Assert.IsTrue(bindingListView.Count > 0);
			return bindingListView;
		}
	}
}