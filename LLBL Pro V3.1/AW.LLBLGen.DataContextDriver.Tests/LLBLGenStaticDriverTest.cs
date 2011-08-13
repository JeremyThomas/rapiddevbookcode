using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using AW.Data.Linq;
using AW.Helper;
using AW.Helper.LLBL;
using AW.LLBLGen.DataContextDriver.Static;
using LINQPad.Extensibility.DataContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Northwind.DAL;
using Northwind.DAL.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using CustomerEntity = AW.Data.EntityClasses.CustomerEntity;
using ElementCreator = Northwind.DAL.FactoryClasses.ElementCreator;
using EntityType = AW.Data.EntityType;

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
			var explorerItems = GetSchemaTest<EntityType>(customType, EntityFactoryFactory.GetFactory, true);
			var customerExplorerItem = explorerItems.First(e => e.Text == EntityHelper.GetNameFromEntityEnum(EntityType.CustomerEntity));
			IEntityCore customerEntity = new CustomerEntity();
			var msDescription = customerEntity.CustomPropertiesOfType.Values.First();
			StringAssert.Contains(customerExplorerItem.ToolTipText, msDescription);

			var firstExplorerItem = customerExplorerItem.Children.First();
			Assert.IsFalse(string.IsNullOrWhiteSpace(firstExplorerItem.ToolTipText));
			var firstField = (IEntityField) customerEntity.Fields[0];
			StringAssert.Contains(firstExplorerItem.ToolTipText, firstField.SourceColumnName);

			StringAssert.Contains(customerExplorerItem.ToolTipText, firstField.SourceObjectName);
			StringAssert.Contains(customerExplorerItem.ToolTipText, firstField.SourceCatalogName);
			StringAssert.Contains(customerExplorerItem.ToolTipText, firstField.SourceSchemaName);

			var individualExplorerItem = explorerItems.First(e => e.Text == EntityHelper.GetNameFromEntityEnum(EntityType.IndividualEntity));
			foreach (var explorerItem in customerExplorerItem.Children)
			{
				var item = individualExplorerItem.Children.Single(c=>c.Text==explorerItem.Text);
				Assert.AreEqual(explorerItem.ToolTipText, item.ToolTipText);
			}
		}

		/// <summary>
		///A test for GetSchema using AW
		///</summary>
		[TestMethod]
		public void GetAWSchemaPropertiesTest()
		{
			var customType = typeof (LinqMetaData);
			GetSchemaTest<EntityType>(customType, EntityFactoryFactory.GetFactory, false);
		}

		/// <summary>
		///A test for GetSchema using Northwind
		///</summary>
		[TestMethod]
		public void GetNorthwindSchemaFieldsTest()
		{
			var explorerItems = GetSchemaTest<Northwind.DAL.EntityType>(typeof (Northwind.DAL.Linq.LinqMetaData),
			                                                            Northwind.DAL.FactoryClasses.EntityFactoryFactory.GetFactory, true);

			var customerExplorerItem = TestNorthWindToolTips(explorerItems);
			var employeeExplorerItem = customerExplorerItem.Children.Single(e => e.Text == "EmployeesViaOrders");
			Assert.AreEqual(ExplorerIcon.ManyToMany, employeeExplorerItem.Icon);
		}

		private static ExplorerItem TestNorthWindToolTips(List<ExplorerItem> explorerItems, bool testForiegnKey = true)
		{
			var customerName = EntityHelper.GetNameFromEntityEnum(Northwind.DAL.EntityType.CustomerEntity);
			var explorerItem = explorerItems.First(e => e.Text == customerName);

			var orderExplorerItem = explorerItems.Single(e => e.Text == EntityHelper.GetNameFromEntityEnum(Northwind.DAL.EntityType.OrderEntity));
			var customerNavigator = orderExplorerItem.Children.Single(e => e.Text == customerName);

			var customerEntitytype = typeof (Northwind.DAL.EntityClasses.CustomerEntity);
			var displayNameAttributes = MetaDataHelper.GetDisplayNameAttributes(customerEntitytype).ToList();
			foreach (var displayNameAttribute in displayNameAttributes)
			{
				StringAssert.Contains(explorerItem.ToolTipText, displayNameAttribute.DisplayName);
				StringAssert.Contains(customerNavigator.ToolTipText, displayNameAttribute.DisplayName);
			}
			var descriptionAttributes = MetaDataHelper.GetDescriptionAttributes(customerEntitytype).ToList();
			foreach (var descriptionAttribute in descriptionAttributes)
			{
				StringAssert.Contains(explorerItem.ToolTipText, descriptionAttribute.Description);
				StringAssert.Contains(customerNavigator.ToolTipText, descriptionAttribute.Description);
			}

			var orderEntitytype = typeof (OrderEntity);
			var orderPropertiesToShowInSchema = LLBLGenStaticDriver.GetPropertiesToShowInSchema(orderEntitytype);
			var customerPropertyDescriptor = orderPropertiesToShowInSchema.Single(p => p.Name == customerName);
			StringAssert.Contains(customerNavigator.ToolTipText, customerPropertyDescriptor.Description);
			StringAssert.Contains(customerNavigator.ToolTipText, customerPropertyDescriptor.DisplayName);

			if (testForiegnKey)
			  StringAssert.Contains(customerNavigator.ToolTipText, OrderFieldIndex.CustomerId.ToString());

			var first = explorerItem.Children.First();
			Assert.IsFalse(string.IsNullOrWhiteSpace(first.ToolTipText));
			var customerPropertiesToShowInSchema = LLBLGenStaticDriver.GetPropertiesToShowInSchema(customerEntitytype);
			var description = customerPropertiesToShowInSchema.First().Description;
			Assert.IsFalse(String.IsNullOrEmpty(description));
			Assert.IsTrue(first.ToolTipText.Contains(description));

			var orderDetailExplorerItem = explorerItems.Single(e => e.Text == EntityHelper.GetNameFromEntityEnum(Northwind.DAL.EntityType.OrderDetailEntity));
			var quantityExplorerItem = orderDetailExplorerItem.Children.Single(ei => ei.DragText == "Quantity");
			StringAssert.Contains(quantityExplorerItem.ToolTipText, "Quantity description attribute");

			return explorerItem;
		}

		[TestMethod]
		public void GetNorthwindElementCreatorSchemaFieldsTest()
		{
			var explorerItems = GetSchemaTest<Northwind.DAL.EntityType>(typeof (ElementCreator),
			                                                            Northwind.DAL.FactoryClasses.EntityFactoryFactory.GetFactory, true);
			TestNorthWindToolTips(explorerItems);
		}

		[TestMethod]
		public void GetNorthwindSchemaPropertiesTest()
		{
			var explorerItems = GetSchemaTest<Northwind.DAL.EntityType>(typeof (Northwind.DAL.Linq.LinqMetaData),
			                                                            Northwind.DAL.FactoryClasses.EntityFactoryFactory.GetFactory, false);
			TestNorthWindToolTips(explorerItems, false);
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
				var navigatorProperties = useFields ? EntityHelper.GetNavigatorProperties(entity) : MetaDataHelper.GetPropertyDescriptors(entity.GetType()).FilterByIsEnumerable(typeof (IEntityCore));
				var explorerItem = actual[index];
				index++;
				var entityName = entityFactory.ForEntityName + " - " + explorerItem.Text;
				Assert.AreEqual(fieldNames.Count(), explorerItem.Children.Count(ei => ei.Kind == ExplorerItemKind.Property), entityName + " - fieldNames");
				Assert.AreEqual(navigatorProperties.Count(er => !EntityHelper.IsEntityCore(er)), explorerItem.Children.Count(ei => ei.Kind == ExplorerItemKind.CollectionLink), entityName + " - Many navigator");
				Assert.AreEqual(navigatorProperties.Count(EntityHelper.IsEntityCore), explorerItem.Children.Count(ei => ei.Kind == ExplorerItemKind.ReferenceLink), entityName + " - single navigator");
			}
			return actual;
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
			var propertiesToShowInSchema = LLBLGenStaticDriver.GetPropertiesToShowInSchema(typeof (Northwind.DAL.EntityClasses.CustomerEntity));
			Assert.IsFalse(String.IsNullOrEmpty(propertiesToShowInSchema.First().Description));
		}

		[TestMethod]
		public void GetPropertiesToShowInSchemaBuddyTest()
		{
			Type type= typeof (OrderDetailEntity);;
			MetaDataHelper.AddAssociatedMetadataProvider(type);
			var descriptionAttributes = MetaDataHelper.GetDescriptionAttributes(type, OrderDetailFieldIndex.Quantity.ToString());
			Assert.IsTrue(descriptionAttributes.Any());
			var propertiesToShowInSchema = LLBLGenStaticDriver.GetPropertiesToShowInSchema(type);
			Assert.IsFalse(String.IsNullOrEmpty(propertiesToShowInSchema.GetFieldPropertyDescriptor(OrderDetailFieldIndex.Quantity.ToString()).Description));
		}
	}
}