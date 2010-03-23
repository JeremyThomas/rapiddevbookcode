using System;
using System.Collections.Generic;

namespace AW.Test
{
	public class NonSerializableClass
	{
		public int IntField;
		public string StringField;
		public DateTime DateTimeField;

		public int IntProperty
		{
			get { return IntField; }
			set { IntField = value; }
		}

		public string StringProperty
		{
			get { return StringField; }
			set { StringField = value; }
		}

		public DateTime DateTimeProperty
		{
			get { return DateTimeField; }
			set { DateTimeField = value; }
		}

		public static List<NonSerializableClass> GenerateList()
		{
			var list = new List<NonSerializableClass>();
			for (var i = 0; i < 10; i++)
				list.Add(new NonSerializableClass { DateTimeField = DateTime.Now, IntField = list.Count, StringField = list.Count.ToString() });
			return list;
		}
	}

	[Serializable]
	internal class SerializableClass : NonSerializableClass
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
	}
}