#pragma warning disable 1591	// Missing XML comment


using System.Collections;

namespace JesseJohnston.Tests
{
  public class StringLengthComparer : IComparer
  {
    public int Compare(object x, object y)
    {
      return ((string) x).Length.CompareTo(((string) y).Length);
    }
  }
}

