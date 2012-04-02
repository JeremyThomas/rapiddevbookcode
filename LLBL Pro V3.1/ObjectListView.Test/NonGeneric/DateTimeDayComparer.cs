#pragma warning disable 1591	// Missing XML comment


using System;
using System.Collections;

namespace JesseJohnston.Tests
{
  public class DateTimeDayComparer : IComparer
  {
    public int Compare(object x, object y)
    {
      return ((DateTime) x).Day.CompareTo(((DateTime) y).Day);
    }
  }
}

