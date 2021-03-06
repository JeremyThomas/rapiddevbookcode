using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using AW.Data;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Test.Helpers
{
  public static class TestData
  {
    /// <summary>
    ///   37 - The number of EntityField properties. 
    /// IEntityFieldCore(10) + IFieldInfo (15)
    ///   No LinkedSubTypeFields or LinkedSuperTypeField in LLBL 4
    /// </summary>
    /// <see cref="IEntityFieldCore"/>
    /// <see cref="IFieldInfo"/>
    /// <see cref="IEntityField"/>
    /// <see cref="EntityField"/>
    public const int NumFieldProperties = 37;

    /// <summary>
    ///   The number of EntityField2 properties. 
    /// </summary>
    /// <see cref="IEntityFieldCore"/>
    /// <see cref="IFieldInfo"/>
    /// <see cref="IEntityField2"/>
    /// <see cref="EntityField2"/>
    public const int NumField2Properties = 24;

    /// <summary>
    ///   8 browseable address properties
    /// </summary>
    public const int BrowseableAddressProperties = 8;

    /// <summary>
    ///   4 browseable address type properties
    /// </summary>
    public const int BrowseableAddressTypeProperties = 4;

    public static readonly List<string> ThreeStrings = new List<string> {"s1", "s2", "s3"};

    /// <summary>
    ///   from e in query select e
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="query">The query.</param>
    /// <returns></returns>
    public static IQueryable<T> EmptySelect<T>(this IQueryable<T> query) where T : IEntityCore
    {
      return from e in query select e;
    }

    private static readonly Lazy<string> LazyTestXmlString = new Lazy<string>(GetTestXmlString);
    public static string TestXmlString
    {
      get { return LazyTestXmlString.Value; }
    }

    private static string GetTestXmlString()
    {
      //var x = new XmlSerializer(typeof (List<SerializableClass>));
      //var s = new MemoryStream();
      //x.Serialize(s, SerializableClass.GenerateList());

      //	var serializableClassDataTable = GeneralHelper.CopyToDataTable(SerializableClass.GenerateList());
      //var sw = new StringWriter();
      //var xmltw = new XmlTextWriter(sw);
      //
      //		serializableClassDataTable.WriteXml( s, XmlWriteMode.IgnoreSchema);

      var ds = GetAddressTypeDataSet();

      return ds.GetXml();
    }

    public static List<XElement> TestXElements()
    {
      var xElement = XElement.Parse(TestData.TestXmlString);
      var xElements = xElement.Elements().ToList();
      return xElements;
    }

    public static XmlSchema GetTestXmlSchema()
    {
      var schema = new XmlSchema();

      // <xs:element name="cat" type="xs:string"/>
      var elementCat = new XmlSchemaElement();
      schema.Items.Add(elementCat);
      elementCat.Name = "cat";
      elementCat.SchemaTypeName = new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");

      // <xs:element name="dog" type="xs:string"/>
      var elementDog = new XmlSchemaElement();
      schema.Items.Add(elementDog);
      elementDog.Name = "dog";
      elementDog.SchemaTypeName = new XmlQualifiedName("string", "http://www.w3.org/2001/XMLSchema");

      // <xs:element name="redDog" substitutionGroup="dog" />
      var elementRedDog = new XmlSchemaElement();
      schema.Items.Add(elementRedDog);
      elementRedDog.Name = "redDog";
      elementRedDog.SubstitutionGroup = new XmlQualifiedName("dog");

      // <xs:element name="brownDog" substitutionGroup ="dog" />
      var elementBrownDog = new XmlSchemaElement();
      schema.Items.Add(elementBrownDog);
      elementBrownDog.Name = "brownDog";
      elementBrownDog.SubstitutionGroup = new XmlQualifiedName("dog");


      // <xs:element name="pets">
      var elementPets = new XmlSchemaElement();
      schema.Items.Add(elementPets);
      elementPets.Name = "pets";

      // <xs:complexType>
      var complexType = new XmlSchemaComplexType();
      elementPets.SchemaType = complexType;

      // <xs:choice minOccurs="0" maxOccurs="unbounded">
      var choice = new XmlSchemaChoice();
      complexType.Particle = choice;
      choice.MinOccurs = 0;
      choice.MaxOccursString = "unbounded";

      // <xs:element ref="cat"/>
      var catRef = new XmlSchemaElement();
      choice.Items.Add(catRef);
      catRef.RefName = new XmlQualifiedName("cat");

      // <xs:element ref="dog"/>
      var dogRef = new XmlSchemaElement();
      choice.Items.Add(dogRef);
      dogRef.RefName = new XmlQualifiedName("dog");

      var schemaSet = new XmlSchemaSet();
      schemaSet.ValidationEventHandler += ValidationCallbackOne;
      schemaSet.Add(schema);
      schemaSet.Compile();

      XmlSchema compiledSchema = null;

      foreach (XmlSchema schema1 in schemaSet.Schemas())
      {
        compiledSchema = schema1;
      }
      return compiledSchema;
    }

    public static XmlSchema GetTestXmlSchema(string path)
    {
      if (File.Exists(path))
      {
        var schema = XmlSchema.Read(new FileStream(path, FileMode.Open, FileAccess.Read), ValidationCallbackOne);
        var schemaSet = new XmlSchemaSet();
        schemaSet.ValidationEventHandler += ValidationCallbackOne;
        schemaSet.Add(schema);
        schemaSet.Compile();
        return schema;
      }
      return GetTestXmlSchema();
    }

    private static void ValidationCallbackOne(object sender, ValidationEventArgs args)
    {
    }

    private static DataSet GetAddressTypeDataSet()
    {
      var ds = new DataSet();
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      addressTypeEntityCollection.CreateHierarchicalProjection(ds);
      return ds;
    }

    public static DataTable GetAddressTypeDataTable()
    {
      var ds = new DataSet();
      var addressTypeEntityCollection = MetaSingletons.MetaData.AddressType.ToEntityCollection();
      addressTypeEntityCollection.CreateHierarchicalProjection(ds);
      return ds.Tables[0];
    }

    public static IEnumerable<string> ThreeStringsEnumerable
    {
      get { return ThreeStrings.Distinct(); }
    }

    public const string LdapUserName = "guest1";
    public const string LdapUserNameWildCard = "guest*";

    /// <summary>
    /// Creates the LDAP directory entry. LDAP://www.zflexldap.com"
    /// </summary>
    /// <remarks>
    /// http://www.zflexldapadministrator.com/index.php/blog/82-free-online-ldap
    /// http://www.forumsys.com/en/tutorials/integration-how-to/ldap/online-ldap-test-server/
    /// </remarks>
    /// <returns></returns>
    public static DirectoryEntry CreateLdapDirectoryEntry()
    {
      return new DirectoryEntry("LDAP://www.zflexldap.com", "cn=ro_admin,ou=sysadmins,dc=zflexsoftware,dc=com", "zflexpass", AuthenticationTypes.None);
    }
  }

  [Serializable]
  public abstract class SerializableAbstractBaseClass
  {
    //private readonly string _someString;

    //protected SerializableAbstractBaseClass(string someString)
    //{
    //  _someString = someString;
    //}
  }

  [Serializable]
  public class SerializableBaseClass : SerializableAbstractBaseClass
  {
    public int IntField;

    public int IntProperty
    {
      get { return IntField; }
      set { IntField = value; }
    }

    public static List<SerializableBaseClass> GenerateList()
    {
      var list = new List<SerializableBaseClass>();
      for (var i = 0; i < 10; i++)
        list.Add(new SerializableBaseClass {IntField = list.Count});
      return list;
    }
  }

  [Serializable]
  public class SerializableBaseClass2 : SerializableBaseClass
  {
    public string StringField;

    public string StringProperty
    {
      get { return StringField; }
      set { StringField = value; }
    }

    private static List<SerializableBaseClass2> GenerateSerializableBaseClass2List()
    {
      var list = new List<SerializableBaseClass2>();
      for (var i = 0; i < 10; i++)
        list.Add(new SerializableBaseClass2 {IntField = list.Count});
      return list;
    }

    public static List<SerializableBaseClass> GenerateListWithBothSerializableClasses()
    {
      var list = GenerateList();
      list.AddRange(GenerateSerializableBaseClass2List());
      return list;
    }
  }

  public class NonSerializableClass : SerializableBaseClass2
  {
    /// <summary>
    ///   3
    /// </summary>
    public const int NumberOfNonSerializableClassProperties = 3;

    public DateTime DateTimeField;

    public DateTime DateTimeProperty
    {
      get { return DateTimeField; }
      set { DateTimeField = value; }
    }

    public new static List<NonSerializableClass> GenerateList()
    {
      var list = new List<NonSerializableClass>();
      for (var i = 0; i < 10; i++)
        list.Add(new NonSerializableClass {DateTimeField = DateTime.Now, IntField = list.Count, StringField = list.Count.ToString(CultureInfo.InvariantCulture)});
      return list;
    }
  }

  [Serializable]
  public class SerializableClass : NonSerializableClass
  {
    public int? NullableIntField;

    public int? NullableIntProperty
    {
      get { return NullableIntField; }
      set { NullableIntField = value; }
    }

    public new static List<SerializableClass> GenerateList()
    {
      var list = new List<SerializableClass>();
      for (var i = 0; i < 10; i++)
        list.Add(new SerializableClass {DateTimeField = DateTime.Now, IntField = list.Count, StringField = list.Count.ToString(CultureInfo.InvariantCulture)});
      return list;
    }

    public static List<NonSerializableClass> GenerateListWithBoth()
    {
      var list = NonSerializableClass.GenerateList();
      list.AddRange(GenerateList());
      return list;
    }

    public new static List<SerializableBaseClass> GenerateListWithBothSerializableClasses()
    {
      var list = SerializableBaseClass.GenerateList();
      list.AddRange(GenerateList());
      return list;
    }
  }

  public class NonSerializableClassWithSerializableClassProperty
  {
    public string StringProperty { get; set; }

    public SerializableClass Value
    {
      get { return new SerializableClass { DateTimeField = DateTime.Now, IntField = 10, StringField = "aaa" }; }
    }

    public static List<NonSerializableClassWithSerializableClassProperty> GenerateList()
    {
      return new List<NonSerializableClassWithSerializableClassProperty>
      {
        new NonSerializableClassWithSerializableClassProperty {StringProperty = "1"},
        new NonSerializableClassWithSerializableClassProperty {StringProperty = "2"}
      };
    }
  }

  [Serializable]
  public abstract class SerializableAbstractNoDefaultConstructorClass
  {
    public string SomeString { get; private set; }

    protected SerializableAbstractNoDefaultConstructorClass(string someString)
    {
      SomeString = someString;
    }
  }

  [Serializable]
  public class SerializableNoDefaultConstructorClass : SerializableAbstractNoDefaultConstructorClass
  {
    public SerializableNoDefaultConstructorClass(string someString) : base(someString)
    {
    }
  }

  public class NonGenericEnumerable : IEnumerable
  {
    public IEnumerator GetEnumerator()
    {
      return new TestEnumerator();
    }
  }

  public class TestEnumerator : IEnumerator
  {
    public bool MoveNext()
    {
      return false;
    }

    public void Reset()
    {
    }

    public object Current { get; set; }
  }
}