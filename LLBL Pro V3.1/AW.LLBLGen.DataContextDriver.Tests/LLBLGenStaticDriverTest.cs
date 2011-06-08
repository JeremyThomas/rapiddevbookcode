using System;
using System.Linq;
using System.Xml.Linq;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using AW.Data.Linq;
using AW.Helper;
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
		///A test for GetSchema using Northwind
		///</summary>
		[TestMethod]
		public void GetNorthwindSchemaTest()
		{
			GetSchemaTest<Northwind.DAL.EntityType>(typeof (Northwind.DAL.Linq.LinqMetaData), Northwind.DAL.FactoryClasses.EntityFactoryFactory.GetFactory, true);
			GetSchemaTest<Northwind.DAL.EntityType>(typeof (Northwind.DAL.Linq.LinqMetaData), Northwind.DAL.FactoryClasses.EntityFactoryFactory.GetFactory, false);
		}

		private static void GetSchemaTest<TEnum>(Type customType, Func<TEnum, IEntityFactoryCore> entityFactoryFactory, bool useFields)
		{
			var entityTypes = GeneralHelper.EnumAsEnumerable<TEnum>();
			var target = new LLBLGenStaticDriver();
			var mockedIConnectionInfo = new Mock<IConnectionInfo>();
			var xElementDriverData = new XElement("DriverData");
			var xElementUseFields = new XElement(ConnectionDialog.ElementNameUseFields) {Value = useFields.ToString()};
			xElementDriverData.Add(xElementUseFields);
			mockedIConnectionInfo.Setup(ci => ci.DriverData).Returns(xElementDriverData);
			var actual = target.GetSchema(mockedIConnectionInfo.Object, customType);
			Assert.AreEqual(entityTypes.Length, actual.Count);
			var orderedEnumerable = entityTypes.OrderBy(et => et.ToString().Replace("Entity", ""));
			var index = 0;
			foreach (var entityType in orderedEnumerable)
			{
				var entityFactory = entityFactoryFactory(entityType);
				var entity = entityFactory.Create();
				var fieldNames = entity.Fields.Cast<IEntityFieldCore>().Select(f => f.Name).Distinct();
				var entityRelations = entity.GetAllRelations();
				var explorerItem = actual[index];
				index++;
				Assert.AreEqual(fieldNames.Count(), explorerItem.Children.Count(ei => ei.Kind == ExplorerItemKind.Property), entityFactory.ForEntityName + " - " + explorerItem.Text);
				Assert.AreEqual(entityRelations.Count(er => er.TypeOfRelation == RelationType.OneToMany), explorerItem.Children.Count(ei => ei.Kind == ExplorerItemKind.CollectionLink), entityFactory.ForEntityName + " - " + explorerItem.Text);
				Assert.AreEqual(entityRelations.Count(er => er.TypeOfRelation == RelationType.ManyToOne), explorerItem.Children.Count(ei => ei.Kind == ExplorerItemKind.ReferenceLink), entityFactory.ForEntityName + " - " + explorerItem.Text);
			}
		}

		[TestMethod]
		public void GetFieldsToShowInSchemaTest()
		{
			var fieldsToShowInSchema = LLBLGenStaticDriver.GetFieldsToShowInSchema(typeof (AddressEntity));
			Assert.IsFalse(String.IsNullOrEmpty(fieldsToShowInSchema.First().Description));
		}
	}
}