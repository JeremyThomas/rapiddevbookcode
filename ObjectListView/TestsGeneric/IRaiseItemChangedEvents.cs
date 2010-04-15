// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.ComponentModel;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests.Generic
{
	[TestFixture]
	public class IRaiseItemChangedEventsTests
	{
		[Test]
		public void IsIRaiseItemChangedEvents()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.IsTrue(factory.View is IRaiseItemChangedEvents);
		}

		[Test]
		public void RaisesItemChangedEvents()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.IsTrue(((IRaiseItemChangedEvents)factory.View).RaisesItemChangedEvents);
		}
	}
}
#endif
