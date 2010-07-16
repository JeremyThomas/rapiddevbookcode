#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.ComponentModel;

namespace JesseJohnston.Tests
{
  public class SimpleEditableObject : IEditableObject
  {
    private int intValue = -1;
    private string stringValue;
    private DateTime dateValue;
    private int originalIntValue;
    private string originalStringValue;
    private DateTime originalDateValue;

    public DateTime DateTimeValue
    {
      get { return dateValue; }
      set { dateValue = value; }
    }

    public int IntegerValue
    {
      get { return intValue; }
      set { intValue = value; }
    }

    public string StringValue
    {
      get { return stringValue; }
      set { stringValue = value; }
    }

    public SimpleEditableObject()
    {
    }

    public SimpleEditableObject(int intValue, DateTime dateValue, string stringValue)
    {
      this.intValue = intValue;
      this.dateValue = dateValue;
      this.stringValue = stringValue;
    }

    #region IEditableObject Members

    public void BeginEdit()
    {
      originalDateValue = dateValue;
      originalIntValue = intValue;
      originalStringValue = stringValue;
    }

    public void CancelEdit()
    {
      dateValue = originalDateValue;
      intValue = originalIntValue;
      stringValue = originalStringValue;
    }

    public void EndEdit()
    {
    }

    #endregion
  }
}

#endif