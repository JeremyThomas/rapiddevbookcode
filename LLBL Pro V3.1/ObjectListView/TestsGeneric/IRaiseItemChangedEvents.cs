#pragma warning disable 1591	// Missing XML comment

#if TEST
using System.ComponentModel;
using NUnit.Framework;

namespace JesseJohnston.Tests.Generic
{
  [TestFixture]
  public class IRaiseItemChangedEventsTests
  {
    [Test]
    public void IsIRaiseItemChangedEvents()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      Assert.IsTrue(factory.View is IRaiseItemChangedEvents);
    }

    [Test]
    public void RaisesItemChangedEvents()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      Assert.IsTrue(((IRaiseItemChangedEvents) factory.View).RaisesItemChangedEvents);
    }
  }
}

#endif