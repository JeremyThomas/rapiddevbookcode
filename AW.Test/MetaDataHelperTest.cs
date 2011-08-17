using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Xml.Schema;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using AW.Helper;
using AW.Helper.LLBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;
using CommonEntityBase = Northwind.DAL.EntityClasses.CommonEntityBase;
using CustomerEntity = Northwind.DAL.EntityClasses.CustomerEntity;
using EmployeeEntity = Northwind.DAL.EntityClasses.EmployeeEntity;

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
			var customer = new CustomerEntity();
			var propertyDescriptors = MetaDataHelper.GetPropertyDescriptors(customer.GetType());
			var enumerableProperties = propertyDescriptors.FilterByIsEnumerable(typeof (IEntityCore));
			Assert.AreEqual(5, enumerableProperties.Count());
		}

		[TestMethod]
		public void GetEnumerablePropertyTest()
		{
			var customer = new CustomerEntity();
			var propertyDescriptors = MetaDataHelper.GetPropertyDescriptors(customer.GetType());
			var propertyDescriptor = propertyDescriptors.SingleOrDefault(pd => pd.Name == "EmployeesViaOrdersInCode");
			var typeParameterOfGenericType = MetaDataHelper.GetTypeParameterOfGenericType(propertyDescriptor.PropertyType);
			Assert.AreEqual(typeof (EmployeeEntity), typeParameterOfGenericType);
			var elementType = MetaDataHelper.GetElementType(propertyDescriptor.PropertyType);
			Assert.AreEqual(typeof (EmployeeEntity), elementType);
			//var interfaces = propertyDescriptor.PropertyType.GetInterfaces();

			propertyDescriptor = propertyDescriptors.SingleOrDefault(pd => pd.Name == "EmployeesViaOrders");
			typeParameterOfGenericType = MetaDataHelper.GetTypeParameterOfGenericType(propertyDescriptor.PropertyType);
			Assert.AreEqual(typeof (EmployeeEntity), typeParameterOfGenericType);
			elementType = MetaDataHelper.GetElementType(propertyDescriptor.PropertyType);
			Assert.AreEqual(typeof (EmployeeEntity), elementType);
			//interfaces = propertyDescriptor.PropertyType.GetInterfaces();
		}

		/// <summary>
		///A test for FoldAllAssociatedMetadataProvidersIntoTheSubjectType
		///</summary>
		[TestMethod]
		public void FoldAllAssociatedMetadataProvidersIntoTheSubjectTypeTest()
		{
			MetaDataHelper.FoldAllAssociatedMetadataProvidersIntoTheSubjectType(typeof (CommonEntityBase));
			MetaDataHelper.FoldAllAssociatedMetadataProvidersIntoTheSubjectType(typeof(CommonEntityBase));
			AssertNorthwindFoldAllAssociatedMetadataProvidersIntoTheSubjectType();
			MetaDataHelper.FoldAllAssociatedMetadataProvidersIntoTheSubjectType(typeof (Data.EntityClasses.CommonEntityBase));
			AssertAWFoldAllAssociatedMetadataProvidersIntoTheSubjectType();
		}

		[TestMethod]
		public void TestIsFoldAllAssociatedMetadataProvidersIntoTheSubjectType()
		{
			var linqMetaData = new LinqMetaData();
			AssertNorthwindFoldAllAssociatedMetadataProvidersIntoTheSubjectType();
			var awLinqMetaData = new Data.Linq.LinqMetaData();
			new SalesOrderHeaderEntity();
			AssertAWFoldAllAssociatedMetadataProvidersIntoTheSubjectType();
		}

		private static void AssertNorthwindFoldAllAssociatedMetadataProvidersIntoTheSubjectType()
		{
			var propertyDescriptors = MetaDataHelper.GetPropertyDescriptors(typeof (OrderDetailEntity));
			var quantityPropertyDescriptor = propertyDescriptors.Single(pd => pd.Name.Equals("Quantity"));
			Assert.AreEqual(StringConstants.QuantityDescription, quantityPropertyDescriptor.Description);
			var displayNameAttributes = MetaDataHelper.GetAttributes<DisplayNameAttribute>(propertyDescriptors, "Quantity");
			Assert.AreEqual(1, displayNameAttributes.Count());
			var descriptionAttributes = MetaDataHelper.GetAttributes<System.ComponentModel.DescriptionAttribute>(propertyDescriptors, "Quantity");
			Assert.AreEqual(1, descriptionAttributes.Count());
		}

		private static void AssertAWFoldAllAssociatedMetadataProvidersIntoTheSubjectType()
		{
//			var description = MetaDataHelper.GetDescriptionAttributes(typeof (AW.Data.EntityClasses.SalesOrderHeaderEntity)).Select(da => da.Description).JoinAsString();
			//		Assert.AreEqual("You can use this page to find out what is happening with an order", description);
			var propertyDescriptors = MetaDataHelper.GetPropertyDescriptors(typeof (SalesOrderHeaderEntity));
			var quantityPropertyDescriptor = propertyDescriptors.Single(pd => pd.Name.Equals("PurchaseOrderNumber"));
			Assert.AreEqual(SalesOrderHeaderEntity.PurchaseOrderNumberDescription, quantityPropertyDescriptor.Description);
		}

		[TestMethod, Microsoft.VisualStudio.TestTools.UnitTesting.Description("A test that All Fields Have Property Descriptors")]
		public void TestAllFieldsHavePropertyDescriptors()
		{
			AssertAllFieldsHavePropertyDescriptors<EntityType>(EntityFactoryFactory.GetFactory, EntityType.IndividualEntity);
			AssertAllFieldsHavePropertyDescriptors<Northwind.DAL.EntityType>(Northwind.DAL.FactoryClasses.EntityFactoryFactory.GetFactory);
		}

		public static void AssertAllFieldsHavePropertyDescriptors<TEnum>(Func<TEnum, IEntityFactoryCore> entityFactoryFactory, params TEnum[] entityTypes)
		{
			if (entityTypes.IsNullOrEmpty())
				entityTypes = GeneralHelper.EnumAsEnumerable<TEnum>().ToArray();
			else
				GeneralHelper.CheckIsEnum(typeof(TEnum));
			foreach (var entityType in entityTypes)
			{
				var entityFactoryCore = entityFactoryFactory(entityType);
				var entity2 = entityFactoryCore.Create();
				var propertyDescriptors = MetaDataHelper.GetPropertyDescriptors(entity2.GetType());
				foreach (var entityFieldCore in entity2.GetFields())
				{
					Assert.IsNotNull(propertyDescriptors.GetFieldPropertyDescriptor(entityFieldCore.Name));
				}
			}
		}
	}
}