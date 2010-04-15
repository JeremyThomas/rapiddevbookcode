
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;

namespace JesseJohnston.Tests
{
	public class SimpleClass
	{
		private int intValue = -1;
		private string stringValue;
		private DateTime dateValue;
		private DateTime? nullableDateValue;
		private Incomparable incomparableValue;

		public DateTime DateTimeValue
		{
			get { return dateValue; }
		}
		public Incomparable IncomparableValue
		{
			get { return this.incomparableValue; }
		}
		public int IntegerValue
		{
			get { return intValue; }
		}
		public DateTime? NullableDateTimeValue
		{
			get { return nullableDateValue; }
		}
		public string StringValue
		{
			get { return stringValue; }
		}
		protected int ProtectedValue
		{
			get { return 1; }
			set { }
		}
		private int PrivateValue
		{
			get { return 2; }
			set { }
		}

		public SimpleClass()
		{
		}
		public SimpleClass(int i, string s, DateTime d) : this(i,s,d,null)
		{
		}
		public SimpleClass(int i, string s, DateTime d, DateTime? nd)
		{
			intValue = i;
			stringValue = s;
			dateValue = d;
			nullableDateValue = nd;
			Random r = new Random();
			incomparableValue = new Incomparable(r.Next(0,100));
		}

		public override string ToString()
		{
			return string.Format("{0} {1} {2}", intValue, stringValue, dateValue.ToShortDateString());
		}
	}

	public class Incomparable
	{
		private int val;

		public Incomparable(int value)
		{
			this.val = value;
		}
	}
}
#endif