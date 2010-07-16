#pragma warning disable 1591	// Missing XML comment

#if TEST
using System.Collections;
using System.ComponentModel;
using NUnit.Framework;

namespace JesseJohnston.Tests
{
  [TestFixture]
  public class IRaiseItemChangedEventsTests
  {
    [Test]
    public void IsIRaiseItemChangedEvents()
    {
      var view = new ObjectListView(new ArrayList());
      Assert.IsTrue(view is IRaiseItemChangedEvents);
    }

    [Test]
    public void RaisesItemChangedEvents()
    {
      var view = new ObjectListView(new ArrayList());
      Assert.IsTrue(((IRaiseItemChangedEvents) view).RaisesItemChangedEvents);
    }
  }
}

#endif