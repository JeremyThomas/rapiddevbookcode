using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Xml.Schema;
using AW.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Tests
{
	/// <summary>
	///This is a test class for MetaDataHelperTest and is intended
	///to contain all MetaDataHelperTest Unit Tests
	///</summary>
	[TestClass]
	public class MetaDataHelperTest
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
		///A test for GetEnumerableItemType
		///</summary>
		[TestMethod]
		public void GetEnumerableItemTypeTest()
		{
			var xmlSchema = TestData.GetTestXmlSchema();
			var actual = MetaDataHelper.GetEnumerableItemType(xmlSchema.Items);
			Assert.AreEqual(typeof (XmlSchemaObject), actual);
		}

		/// <summary>
		///A test for GetPropertiesToSerialize
		///</summary>
		[TestMethod]
		public void GetPropertiesToSerializeTest()
		{
			var xmlSchemaElementType = typeof (XmlSchemaElement);
			var xmlSchemaObjectType = typeof (XmlSchemaObject);

			var expected = MetaDataHelper.GetPropertiesToSerialize(xmlSchemaElementType);

			var fieldsToPropertiesTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(xmlSchemaObjectType, BindingFlags.Instance | BindingFlags.Public);
			TypeDescriptor.AddProvider(fieldsToPropertiesTypeDescriptionProvider, xmlSchemaObjectType);
			MetaDataHelper.GetPropertiesToSerialize(xmlSchemaObjectType);
			var actual = MetaDataHelper.GetPropertiesToSerialize(xmlSchemaElementType);
			try
			{
				CollectionAssert.AreEqual(expected.ToList(), actual.ToList());
			}
			finally
			{
				TypeDescriptor.RemoveProvider(fieldsToPropertiesTypeDescriptionProvider, xmlSchemaObjectType);
			}
		}

		[TestMethod]
		public void FieldsToPropertiesTypeDescriptionProviderInheritanceTest()
		{
			TestFieldsToPropertiesTypeDescriptionProviderInheritance(typeof (SerializableBaseClass), typeof (SerializableClass), 4);
			TestFieldsToPropertiesTypeDescriptionProviderInheritance(typeof (XmlSchemaObject), typeof (XmlSchemaElement));
		}

		private static void TestFieldsToPropertiesTypeDescriptionProviderInheritance(Type baseType, Type derivedType, int numFields = 0)
		{
			var browsableAttributeList = new Attribute[] {new BrowsableAttribute(true)};
			var expected = TypeDescriptor.GetProperties(derivedType, browsableAttributeList);

			var fieldsToPropertiesTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(baseType, BindingFlags.Instance | BindingFlags.Public);
			TypeDescriptor.AddProvider(fieldsToPropertiesTypeDescriptionProvider, baseType);

			TypeDescriptor.GetProperties(baseType, browsableAttributeList);
			var actual = TypeDescriptor.GetProperties(derivedType, browsableAttributeList);
			try
			{
				if (numFields > 0)
					Assert.AreEqual(expected.Count + numFields, actual.Count);
				else
					CollectionAssert.AreEqual(expected, actual, derivedType.ToString());
			}
			finally
			{
				TypeDescriptor.RemoveProvider(fieldsToPropertiesTypeDescriptionProvider, baseType);
			}
		}

		[TestMethod]
		public void FieldsToPropertiesTypeDescriptionProviderTest()
		{
			var serializableClassType = typeof (SerializableClass);

			var browsableAttributeList = new Attribute[] {new BrowsableAttribute(true)};
			var expected = TypeDescriptor.GetProperties(serializableClassType, browsableAttributeList);

			var fieldsToPropertiesTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(serializableClassType, BindingFlags.Instance | BindingFlags.Public);
			TypeDescriptor.AddProvider(fieldsToPropertiesTypeDescriptionProvider, serializableClassType);

			var actual = TypeDescriptor.GetProperties(serializableClassType, browsableAttributeList);
			try
			{
				Assert.AreEqual(expected.Count*2, actual.Count);
			}
			finally
			{
				TypeDescriptor.RemoveProvider(fieldsToPropertiesTypeDescriptionProvider, serializableClassType);
			}
		}

		[TestMethod]
		public void GetEnumerablePropertiesTest()
		{
			var customer = new Northwind.DAL.EntityClasses.CustomerEntity();
			var propertyDescriptors = MetaDataHelper.GetPropertyDescriptors(customer.GetType());
			var enumerableProperties = propertyDescriptors.FilterByIsEnumerable(typeof(IEntityCore));
			Assert.AreEqual(5, enumerableProperties.Count());
		}
	}
}