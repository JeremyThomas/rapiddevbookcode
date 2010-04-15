
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections.Generic;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests.Generic
{
	[TestFixture]
	public class IEnumerableTTests
	{
		[Test]
		public void GetEnumeratorEmptyList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IEnumerator<SimpleClass> e = factory.View.GetEnumerator();

			Assert.IsNotNull(e);
			Assert.IsFalse(e.MoveNext());
		}

		[Test]
		public void GetEnumeratorNonEmptyList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();

			factory.List.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			factory.List.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			factory.List.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			IEnumerator<SimpleClass> e = factory.View.GetEnumerator();
			Assert.IsNotNull(e);

			Assert.IsTrue(e.MoveNext());
			SimpleClass item = e.Current;
			Assert.IsNotNull(item);
			Assert.AreEqual(100, item.IntegerValue);
			Assert.AreEqual("aaa", item.StringValue);
			Assert.AreEqual(new DateTime(1970, 1, 1), item.DateTimeValue);

			Assert.IsTrue(e.MoveNext());
			item = e.Current;
			Assert.IsNotNull(item);
			Assert.AreEqual(80, item.IntegerValue);
			Assert.AreEqual("bbb", item.StringValue);
			Assert.AreEqual(new DateTime(1980, 12, 12), item.DateTimeValue);

			Assert.IsTrue(e.MoveNext());
			item = e.Current;
			Assert.IsNotNull(item);
			Assert.AreEqual(60, item.IntegerValue);
			Assert.AreEqual("ccc", item.StringValue);
			Assert.AreEqual(new DateTime(1975, 6, 6), item.DateTimeValue);

			Assert.IsFalse(e.MoveNext());
		}
	}
}
#endif