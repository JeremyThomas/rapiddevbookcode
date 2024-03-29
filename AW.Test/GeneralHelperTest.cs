﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Winforms.Helpers.DataEditor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
	///<summary>
	///	This is a test class for GeneralHelperTest and is intended
	///	to contain all GeneralHelperTest Unit Tests
	///</summary>
	[TestClass]
	public class GeneralHelperTest
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
		///	A test for GetEnumerableItemType
		///</summary>
		[TestMethod]
		public void GetEnumerableItemTypeTest()
		{
			Assert.AreEqual(typeof (int), MetaDataHelper.GetEnumerableItemType(new List<int>()));
			Assert.AreEqual(typeof (int), MetaDataHelper.GetEnumerableItemType((new List<int> {1, 2, 3, 4}).Where(i => i > 2)));
			Assert.AreEqual(typeof (AddressTypeEntity), MetaDataHelper.GetEnumerableItemType(new AddressTypeCollection()));
			Assert.AreEqual(typeof (AddressTypeEntity), MetaDataHelper.GetEnumerableItemType(MetaSingletons.MetaData.AddressType));
			Assert.AreEqual(typeof (int), MetaDataHelper.GetEnumerableItemType(new ArrayList {1, 2, 3}));
			Assert.AreEqual(typeof (object), MetaDataHelper.GetEnumerableItemType(new ArrayList()));

			Assert.AreEqual(typeof(string), MetaDataHelper.GetEnumerableItemType(new string[0]));
			var emptySerializableClasses = new SerializableClass[0];
			Assert.AreEqual(typeof(SerializableClass), MetaDataHelper.GetEnumerableItemType(emptySerializableClasses));
			Assert.AreEqual(typeof(SerializableClass), MetaDataHelper.GetEnumerableItemType(emptySerializableClasses.Take(30)));
		}

		public void CopyToDataTableAndAssert<T>(IEnumerable<T> source)
		{
			var actual = GeneralHelper.CopyToDataTable(source);
			Assert.AreEqual(source.Count(), actual.Rows.Count);
			AssertCopyToDataTable(typeof (T), actual);
		}

		public void CopyToDataTableAndAssert(ICollection source, Type type)
		{
			var actual = source.CopyToDataTable();
			Assert.AreEqual(source.Count, actual.Rows.Count);
			AssertCopyToDataTable(type, actual);
		}

		private static void AssertCopyToDataTable(Type type, DataTable actual)
		{
			var propertyDescriptors = MetaDataHelper.GetPropertiesToSerialize(type);
			Assert.AreEqual(propertyDescriptors.Count(), actual.Columns.Count);
			var expectedPropertyDescriptorNames = propertyDescriptors.Select(pd => pd.Name).ToList();
			var actualNames = actual.Columns.Cast<DataColumn>().Select(dc => dc.ColumnName).ToList();
			CollectionAssert.AreEquivalent(expectedPropertyDescriptorNames, actualNames);
		}

		[TestMethod, Microsoft.VisualStudio.TestTools.UnitTesting.Description("A test for CopyToDataTable")]
		public void CopyToDataTableTest()
		{
			var listofNonSerializableClasses = NonSerializableClass.GenerateList();
			CopyToDataTableAndAssert(listofNonSerializableClasses);
			CopyToDataTableAndAssert(MetaSingletons.MetaData.AddressType);
			listofNonSerializableClasses.Add(new SerializableClass {DateTimeField = DateTime.Now, IntField = listofNonSerializableClasses.Count, StringField = listofNonSerializableClasses.Count.ToString()});
			CopyToDataTableAndAssert(listofNonSerializableClasses, typeof (SerializableClass));
			var d = new DataGridView {AutoGenerateColumns = true, DataSource = listofNonSerializableClasses};
			listofNonSerializableClasses.Insert(0, new SerializableClass {DateTimeField = DateTime.Now, IntField = listofNonSerializableClasses.Count, StringField = listofNonSerializableClasses.Count.ToString()});
			CopyToDataTableAndAssert(listofNonSerializableClasses, typeof (SerializableClass));
			CopyToDataTableAndAssert(MetaDataHelper.GetPropertiesToSerialize(typeof (AddressTypeEntity)));
		}

		[TestMethod]
		public void StringPropertiesTest()
		{
			var strings = new[] {"one", "two", "a string"};
			var stringWrapperForBinding = strings.CreateStringWrapperForBinding();
			var stringWrapperProperties = ListBindingHelper.GetListItemProperties(stringWrapperForBinding);
			Assert.AreEqual(1, stringWrapperProperties.Count);
			Assert.AreEqual(typeof(string), stringWrapperProperties[0].PropertyType);
			//stringWrapperForBinding.ShowInGrid(null);
			//strings.ShowInGrid(null);

			//TypeDescriptor.AddProvider(new StringTypeDescriptorProvider(typeof(string)), typeof(string));
			//var stringProperties = ListBindingHelper.GetListItemProperties(strings);
			//Assert.AreEqual(1, stringProperties.Count);
			//Assert.AreEqual(typeof(string), stringProperties[0].PropertyType);
			//strings.ShowInGrid(null);
		}
	}

	public class StringPropertyDescriptor : PropertyDescriptor
	{
		public StringPropertyDescriptor(string name, Attribute[] attrs) : base(name, attrs)
		{
		}


		public override TypeConverter Converter
		{
			get { return new StringConverter(); }
		}

		public override bool CanResetValue(object component)
		{
			return false;
		}

		public override object GetValue(object component)
		{
			return component;
		}

		public override void ResetValue(object component)
		{
			
		}

		public override void SetValue(object component, object value)
		{

		}

		public override bool ShouldSerializeValue(object component)
		{
			return true;
		}

		public override Type ComponentType
		{
			get { return typeof(string); }
		}

		public override bool IsReadOnly
		{
			get { return true; }
		}

		public override Type PropertyType
		{
			get { return typeof(string); }
		}
	}

	public class StringTypeDescriptor : CustomTypeDescriptor
	{
		private readonly TypeDescriptionProvider _baseProvider;
		private readonly string _aString;

		public StringTypeDescriptor(TypeDescriptionProvider baseProvider)
		{
			_baseProvider = baseProvider;
		}

		public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			return new PropertyDescriptorCollection(null) { new StringPropertyDescriptor("StringPropertyDescriptor", attributes) };
			//return _baseProvider.GetTypeDescriptor(typeof(string)).GetProperties(attributes);
		}

		public override PropertyDescriptorCollection GetProperties()
		{
			return _baseProvider.GetTypeDescriptor(typeof(string)).GetProperties();
		}
	}

	public class StringTypeDescriptorProvider : TypeDescriptionProvider
	{

		  private readonly TypeDescriptionProvider _baseProvider;

			public StringTypeDescriptorProvider(Type t) 
	{
		_baseProvider = TypeDescriptor.GetProvider(t);
	}

		public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			return objectType == typeof(string) ? new StringTypeDescriptor(_baseProvider) : _baseProvider.GetTypeDescriptor(objectType, instance);
		}
	}

	
}