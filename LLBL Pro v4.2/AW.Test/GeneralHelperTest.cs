using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Helper.TypeConverters;
using AW.Test.Helpers;
using Humanizer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
  /// <summary>
  ///   This is a test class for GeneralHelperTest and is intended
  ///   to contain all GeneralHelperTest Unit Tests
  /// </summary>
  [TestClass]
  public class GeneralHelperTest
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

    [TestMethod]
    public void AsNullIfEmptyTest()
    {
      Assert.IsNotNull(SerializableClass.GenerateList().AsNullIfEmpty());
      Assert.IsNull((new List<SerializableClass>()).AsNullIfEmpty());
   //   Assert.IsNull(new System.Collections.Specialized.NameValueCollection().AsNullIfEmpty());
    }

    [TestMethod]
    public void IsNullOrEmptyTest()
    {
      Assert.IsFalse(SerializableClass.GenerateList().Where(mc => !mc.NullableIntField.Equals(1)).IsNullOrEmpty());
      Assert.IsTrue((new List<SerializableClass>()).IsNullOrEmpty());
      Assert.IsTrue(LinqHelper.IsNullOrEmpty(null));

      Assert.IsTrue(new System.Collections.Specialized.NameValueCollection().IsNullOrEmpty());
      Assert.IsTrue(new NonGenericEnumerable().IsNullOrEmpty());
    }


    private static void CopyToDataTableAndAssert<T>(IEnumerable<T> source)
    {
      var actual = GeneralHelper.CopyToDataTable(source);
      Assert.AreEqual(source.Count(), actual.Rows.Count);
      AssertCopyToDataTable(typeof (T), actual);
    }

    private static void CopyToDataTableAndAssert(ICollection source, Type type)
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
      listofNonSerializableClasses.Add(new SerializableClass {DateTimeField = DateTime.Now, IntField = listofNonSerializableClasses.Count, StringField = listofNonSerializableClasses.Count.ToString(CultureInfo.InvariantCulture)});
      CopyToDataTableAndAssert(listofNonSerializableClasses, typeof (SerializableClass));
      var d = new DataGridView {AutoGenerateColumns = true, DataSource = listofNonSerializableClasses};
      listofNonSerializableClasses.Insert(0, new SerializableClass {DateTimeField = DateTime.Now, IntField = listofNonSerializableClasses.Count, StringField = listofNonSerializableClasses.Count.ToString(CultureInfo.InvariantCulture)});
      CopyToDataTableAndAssert(listofNonSerializableClasses, typeof (SerializableClass));
      CopyToDataTableAndAssert(MetaDataHelper.GetPropertiesToSerialize(typeof (AddressTypeEntity)));
    }

    [TestMethod, Microsoft.VisualStudio.TestTools.UnitTesting.Description("A test for CopyToDataTable")]
    public void XmlSchemaObjectCollectionCopyToDataTableTest()
    {
      var xmlSchema = TestData.GetTestXmlSchema();
      CopyToDataTableAndAssert(xmlSchema.Items, xmlSchema.Items[0].GetType());
    }

    [TestMethod]
    public void EnumerationConverterTest()
    {
      var maritalStatusDBConverter = new MaritalStatusDBConverter();
      var instance = maritalStatusDBConverter.CreateInstance(null, null);
      Assert.IsNotNull(instance);
      Assert.AreEqual("M", maritalStatusDBConverter.ConvertToString(MaritalStatus.M));

      EnumToStringTest<AddressType>();
      EnumToStringTest<OrderStatus>();
      EnumToStringTest<MaritalStatus>();
      EnumToStringTest<NameStyle>();
      EnumToStringTest<ProductMaintenanceDocumentStatus>();
      EnumToStringTest<CreditRating>();
      EnumToStringTest<ContactType>();
    }

    private static void EnumToStringTest<TEnum>() where TEnum : struct
    {
      var enumType = typeof (TEnum);
      var enumerationConverter = new HumanizedEnumConverter(enumType);
      var underlyingType = Enum.GetUnderlyingType(enumType);
      foreach (var anEnum in GeneralHelper.EnumAsEnumerable<TEnum>())
      {
        var enumAsString = anEnum.ToString();
        Assert.AreEqual(anEnum, enumerationConverter.ConvertFromString(enumAsString), enumAsString);
        var asUnderlyingType = Convert.ChangeType(anEnum, underlyingType);
        var asUnderlyingTypesString = Convert.ToString(asUnderlyingType);
        Assert.AreEqual(anEnum, enumerationConverter.ConvertFromString(asUnderlyingTypesString), asUnderlyingTypesString);
        var humanizedEnumString = ((Enum) (object) anEnum).Humanize();
        Assert.AreEqual(anEnum, enumerationConverter.ConvertFromString(humanizedEnumString), humanizedEnumString);
        HumanizedEnumConverter.AddEnumerationConverter(enumType);
        Assert.IsInstanceOfType(TypeDescriptor.GetConverter(enumType), typeof (HumanizedEnumConverter), enumType.ToString());
      }
    }

    [TestMethod, Microsoft.VisualStudio.TestTools.UnitTesting.Description("A test for WireUpSelfJoin")]
    public void WireUpSelfJoinTest()
    {
      var employeeEntities = MetaSingletons.MetaData.Employee.ToEntityCollection();
      EmployeeEntity.WireUpSelfJoin(employeeEntities);
      Assert.AreEqual(employeeEntities[0].Manager, employeeEntities[15]);
      var employeeEntitiesQuery = EmployeeEntity.WireUpSelfJoin(MetaSingletons.MetaData.Employee).ToEntityCollection();
      Assert.AreEqual(employeeEntitiesQuery[0].Manager, employeeEntitiesQuery[15]);
    }

    [TestMethod, Microsoft.VisualStudio.TestTools.UnitTesting.Description("A test for WireUpSelfJoinAndRemoveChildren")]
    public void WireUpSelfJoinAndRemoveChildrenTest()
    {
      var northwindLinqMetaData = NorthwindTest.GetNorthwindLinqMetaData();
      var employeeEntities = northwindLinqMetaData.Employee.ToEntityCollection2();
      var root = Northwind.DAL.EntityClasses.EmployeeEntity.WireUpSelfJoinAndRemoveChildren(employeeEntities);
      Assert.AreEqual(employeeEntities[0].Manager, employeeEntities[1]);
      Assert.AreEqual(1, root.Count());
      var employeeEntitiesQueryRoot = Northwind.DAL.EntityClasses.EmployeeEntity.WireUpSelfJoinAndRemoveChildren(northwindLinqMetaData.Employee).ToEntityCollection2();
      Assert.AreEqual(1, root.Count());
      Assert.AreEqual(5, employeeEntitiesQueryRoot.Single().Staff.Count);
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
      get { return typeof (string); }
    }

    public override bool IsReadOnly
    {
      get { return true; }
    }

    public override Type PropertyType
    {
      get { return typeof (string); }
    }
  }

  public class StringTypeDescriptor : CustomTypeDescriptor
  {
    private readonly TypeDescriptionProvider _baseProvider;

    public StringTypeDescriptor(TypeDescriptionProvider baseProvider)
    {
      _baseProvider = baseProvider;
    }

    public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
      return new PropertyDescriptorCollection(null) {new StringPropertyDescriptor("StringPropertyDescriptor", attributes)};
      //return _baseProvider.GetTypeDescriptor(typeof(string)).GetProperties(attributes);
    }

    public override PropertyDescriptorCollection GetProperties()
    {
      return _baseProvider.GetTypeDescriptor(typeof (string)).GetProperties();
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
      return objectType == typeof (string) ? new StringTypeDescriptor(_baseProvider) : _baseProvider.GetTypeDescriptor(objectType, instance);
    }
  }
}