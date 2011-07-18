#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;

namespace JesseJohnston.Tests
{
  public class SimpleClass
  {
    private readonly int intValue = -1;
    private readonly string stringValue;
    private DateTime dateValue;
    private readonly DateTime? nullableDateValue;
    private readonly Incomparable incomparableValue;

    public DateTime DateTimeValue
    {
      get { return dateValue; }
    }

    public Incomparable IncomparableValue
    {
      get { return incomparableValue; }
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

    public SimpleClass(int i, string s, DateTime d) : this(i, s, d, null)
    {
    }

    public SimpleClass(int i, string s, DateTime d, DateTime? nd)
    {
      intValue = i;
      stringValue = s;
      dateValue = d;
      nullableDateValue = nd;
      var r = new Random();
      incomparableValue = new Incomparable(r.Next(0, 100));
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
      val = value;
    }
  }
}

#endif