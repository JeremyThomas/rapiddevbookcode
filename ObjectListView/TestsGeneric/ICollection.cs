
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests.Generic
{
	[TestFixture]
	public class ICollectionTests
	{
		[Test]
		public void CopyTo()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			SimpleClass[] array = new SimpleClass[3];
			((ICollection)factory.View).CopyTo(array, 0);

			SimpleClass item = array[0];
			Assert.IsNotNull(item);
			Assert.AreEqual(100, item.IntegerValue);
			Assert.AreEqual("aaa", item.StringValue);
			Assert.AreEqual(new DateTime(1970, 1, 1), item.DateTimeValue);

			item = array[1];
			Assert.AreEqual(80, item.IntegerValue);
			Assert.AreEqual("bbb", item.StringValue);
			Assert.AreEqual(new DateTime(1980, 12, 12), item.DateTimeValue);

			item = array[2];
			Assert.AreEqual(60, item.IntegerValue);
			Assert.AreEqual("ccc", item.StringValue);
			Assert.AreEqual(new DateTime(1975, 6, 6), item.DateTimeValue);
		}

		[Test]
		public void CopyToEmptyList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			SimpleClass[] array = new SimpleClass[0];
			((ICollection)factory.View).CopyTo(array, 0);
		}

		[Test]
		public void Count()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			Assert.AreEqual(list.Count, ((ICollection)factory.View).Count);
		}

		[Test]
		public void CountEmptyList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.AreEqual(0, ((ICollection)factory.View).Count);
		}

		[Test]
		public void IsSynchronized()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.IsFalse(((IList)factory.View).IsSynchronized);
		}

		[Test]
		public void SyncRoot()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.IsNull(((IList)factory.View).SyncRoot);
		}
	}
}
#endif