using System;
using System.Collections.Generic;
using System.Linq;

namespace AW.Tests
{
  [Serializable]
  public class SerializableBaseClass
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
        list.Add(new SerializableBaseClass { IntField = list.Count });
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

    public new static List<SerializableBaseClass2> GenerateList()
    {
      var list = new List<SerializableBaseClass2>();
      for (var i = 0; i < 10; i++)
        list.Add(new SerializableBaseClass2 { IntField = list.Count });
      return list;
    }

    public static List<SerializableBaseClass> GenerateListWithBothSerializableClasses()
    {
      var list = SerializableBaseClass.GenerateList();
      list.AddRange(GenerateList().Cast<SerializableBaseClass>());
      return list;
    }
  }

  public class NonSerializableClass : SerializableBaseClass2
  {
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
        list.Add(new NonSerializableClass { DateTimeField = DateTime.Now, IntField = list.Count, StringField = list.Count.ToString() });
      return list;
    }
  }

  [Serializable]
  public class SerializableClass : NonSerializableClass
  {
    public int? NulllableIntField;

    public int? NulllableIntProperty
    {
      get { return NulllableIntField; }
      set { NulllableIntField = value; }
    }

    public new static List<SerializableClass> GenerateList()
    {
      var list = new List<SerializableClass>();
      for (var i = 0; i < 10; i++)
        list.Add(new SerializableClass { DateTimeField = DateTime.Now, IntField = list.Count, StringField = list.Count.ToString() });
      return list;
    }

    public static List<NonSerializableClass> GenerateListWithBoth()
    {
      var list = NonSerializableClass.GenerateList();
      list.AddRange(GenerateList().Cast<NonSerializableClass>());
      return list;
    }

    public new static List<SerializableBaseClass> GenerateListWithBothSerializableClasses()
    {
      var list = SerializableBaseClass.GenerateList();
      list.AddRange(GenerateList().Cast<SerializableBaseClass>());
      return list;
    }
  }
}