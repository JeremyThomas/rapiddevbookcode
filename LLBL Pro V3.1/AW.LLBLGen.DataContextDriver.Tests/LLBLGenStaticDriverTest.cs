using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Documents;
using System.Xml.Linq;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using AW.Data.Linq;
using AW.Helper;
using AW.Helper.LLBL;
using AW.LLBLGen.DataContextDriver.Static;
using LINQPad.Extensibility.DataContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.LLBLGen.DataContextDriver.Tests
{
	/// <summary>
	///This is a test class for LLBLGenStaticDriverTest and is intended
	///to contain all LLBLGenStaticDriverTest Unit Tests
	///</summary>
	[TestClass]
	public class LLBLGenStaticDriverTest
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
		///A test for GetSchema using AW
		///</summary>
		[TestMethod]
		public void GetAWSchemaTest()
		{
			var customType = typeof (LinqMetaData);
			GetSchemaTest<EntityType>(customType, EntityFactoryFactory.GetFactory, true);
		}

		/// <summary>
		///A test for GetSchema using AW
		///</summary>
		[TestMethod, Ignore]
		public void GetAWSchemaPropertiesTest()
		{
			var customType = typeof(LinqMetaData);
			GetSchemaTest<EntityType>(customType, EntityFactoryFactory.GetFactory, false);
		}
		
		/// <summary>
		///A test for GetSchema using Northwind
		///</summary>
		[TestMethod]
		public void GetNorthwindSchemaFieldsTest()
		{
			var explorerItems = GetSchemaTest<Northwind.DAL.EntityType>(typeof (Northwind.DAL.Linq.LinqMetaData), Northwind.DAL.FactoryClasses.EntityFactoryFactory.GetFactory, true);
			var explorerItem = explorerItems.First(e => e.Text == EntityHelper.GetNameFromEntityEnum(Northwind.DAL.EntityType.CustomerEntity));
			var first = explorerItem.Children.First();
			Assert.IsFalse(string.IsNullOrWhiteSpace(first.ToolTipText));
			var propertiesToShowInSchema = LLBLGenStaticDriver.GetPropertiesToShowInSchema(typeof(Northwind.DAL.EntityClasses.CustomerEntity));
			var description = propertiesToShowInSchema.First().Description;
			Assert.IsFalse(String.IsNullOrEmpty(description));
			Assert.IsTrue(first.ToolTipText.Contains(description));
		}

		[TestMethod]
		public void GetNorthwindElementCreatorSchemaFieldsTest()
		{
			GetSchemaTest<Northwind.DAL.EntityType>(typeof(Northwind.DAL.FactoryClasses.ElementCreator), Northwind.DAL.FactoryClasses.EntityFactoryFactory.GetFactory, true);
		}

		[TestMethod]
		public void GetNorthwindSchemaPropertiesTest()
		{
			GetSchemaTest<Northwind.DAL.EntityType>(typeof(Northwind.DAL.Linq.LinqMetaData), Northwind.DAL.FactoryClasses.EntityFactoryFactory.GetFactory, false);
		}

		private static List<ExplorerItem> GetSchemaTest<TEnum>(Type customType, Func<TEnum, IEntityFactoryCore> entityFactoryFactory, bool useFields)
		{
			var entityTypes = GeneralHelper.EnumAsEnumerable<TEnum>();
			var target = new LLBLGenStaticDriver();
			var mockedICustomTypeInfo = new Mock<ICustomTypeInfo>();
			var mockedIConnectionInfo = new Mock<IConnectionInfo>();
			var xElementDriverData = new XElement("DriverData");
			var xElementUseFields = new XElement(ConnectionDialog.ElementNameUseFields) {Value = useFields.ToString()};
			xElementDriverData.Add(xElementUseFields);
			mockedIConnectionInfo.Setup(ci => ci.DriverData).Returns(xElementDriverData);
			mockedIConnectionInfo.Setup(ci => ci.CustomTypeInfo).Returns(mockedICustomTypeInfo.Object);
			var actual = target.GetSchema(mockedIConnectionInfo.Object, customType);
			Assert.AreEqual(entityTypes.Length, actual.Count);
			var orderedEnumerable = entityTypes.OrderBy(et => et.ToString().Replace("Entity", ""));
			var index = 0;
			foreach (var entityType in orderedEnumerable)
			{
				var entityFactory = entityFactoryFactory(entityType);
				var entity = entityFactory.Create();
				var fieldNames = entity.Fields.Cast<IEntityFieldCore>().Select(f => f.Name).Distinct();
				var navigatorProperties = useFields ? EntityHelper.GetNavigatorProperties(entity) : MetaDataHelper.GetPropertyDescriptors(entity.GetType()).FilterByIsEnumerable(typeof(IEntityCore)); ;
				var explorerItem = actual[index];
				index++;
				var entityName = entityFactory.ForEntityName + " - " + explorerItem.Text;
				Assert.AreEqual(fieldNames.Count(), explorerItem.Children.Count(ei => ei.Kind == ExplorerItemKind.Property), entityName + " - fieldNames");
				Assert.AreEqual(navigatorProperties.Count(er => !EntityHelper.IsEntityCore(er)), explorerItem.Children.Count(ei => ei.Kind == ExplorerItemKind.CollectionLink), entityName + " - Many navigator");
				Assert.AreEqual(navigatorProperties.Count(EntityHelper.IsEntityCore), explorerItem.Children.Count(ei => ei.Kind == ExplorerItemKind.ReferenceLink), entityName + " - single navigator");
			}
			return actual;
		}

		[TestMethod]
		public void GetNavigatorPropertiesTest()
		{
			var customer = new Northwind.DAL.EntityClasses.CustomerEntity();
			var toManyProperties = EntityHelper.GetNavigatorProperties(customer);
			Assert.AreEqual(4, toManyProperties.Count());

			var employeeEntity = new Northwind.DAL.EntityClasses.EmployeeEntity();
			toManyProperties = EntityHelper.GetNavigatorProperties(employeeEntity);
			Assert.AreEqual(5, toManyProperties.Count());
		}

		[TestMethod]
		public void GetEnumerablePropertyTest()
		{
			var customer = new Northwind.DAL.EntityClasses.CustomerEntity();
			var propertyDescriptors = MetaDataHelper.GetPropertyDescriptors(customer.GetType());
			var propertyDescriptor = propertyDescriptors.SingleOrDefault(pd=>pd.Name=="EmployeesViaOrdersInCode");
			var typeParameterOfGenericType = MetaDataHelper.GetTypeParameterOfGenericType(propertyDescriptor.PropertyType);
			Assert.AreEqual(typeof(Northwind.DAL.EntityClasses.EmployeeEntity), typeParameterOfGenericType);
			var elementType = MetaDataHelper.GetElementType(propertyDescriptor.PropertyType);
			Assert.AreEqual(typeof(Northwind.DAL.EntityClasses.EmployeeEntity), elementType);
			//var interfaces = propertyDescriptor.PropertyType.GetInterfaces();

			propertyDescriptor = propertyDescriptors.SingleOrDefault(pd => pd.Name == "EmployeesViaOrders");
			typeParameterOfGenericType = MetaDataHelper.GetTypeParameterOfGenericType(propertyDescriptor.PropertyType);
			Assert.AreEqual(typeof(Northwind.DAL.EntityClasses.EmployeeEntity), typeParameterOfGenericType);
			elementType = MetaDataHelper.GetElementType(propertyDescriptor.PropertyType);
			Assert.AreEqual(typeof(Northwind.DAL.EntityClasses.EmployeeEntity), elementType);
			//interfaces = propertyDescriptor.PropertyType.GetInterfaces();
		}
		
		//[TestMethod]
		//public void GetFieldsToShowInSchemaTest()
		//{
		//  var fieldsToShowInSchema = LLBLGenStaticDriver.GetFieldsToShowInSchema(typeof (Northwind.DAL.EntityClasses.CustomerEntity));
		//  Assert.IsFalse(String.IsNullOrEmpty(fieldsToShowInSchema.First().Description));
		//}

		[TestMethod]
		public void GetPropertiesToShowInSchemaTest()
		{
			var propertiesToShowInSchema = LLBLGenStaticDriver.GetPropertiesToShowInSchema(typeof(Northwind.DAL.EntityClasses.CustomerEntity));
			Assert.IsFalse(String.IsNullOrEmpty(propertiesToShowInSchema.First().Description));
		}
	}
}