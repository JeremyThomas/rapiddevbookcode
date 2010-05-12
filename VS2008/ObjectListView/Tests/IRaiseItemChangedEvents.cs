
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.ComponentModel;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests
{
	[TestFixture]
	public class IRaiseItemChangedEventsTests
	{
		[Test]
		public void IsIRaiseItemChangedEvents()
		{
			ObjectListView view = new ObjectListView(new ArrayList());
			Assert.IsTrue(view is IRaiseItemChangedEvents);
		}

		[Test]
		public void RaisesItemChangedEvents()
		{
			ObjectListView view = new ObjectListView(new ArrayList());
			Assert.IsTrue(((IRaiseItemChangedEvents)view).RaisesItemChangedEvents);
		}
	}
}
#endif