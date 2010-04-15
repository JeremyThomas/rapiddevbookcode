// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests
{
	[TestFixture]
	public class IBindingListViewTests
	{
		[Test]
		public void ApplySortMultipleProps()
		{
			List<SimpleClass> list = new List<SimpleClass>();
			ObjectListView view = new ObjectListView(list);

			list.Add(new SimpleClass(4, "aaa", new DateTime(1930, 5, 5)));
			list.Add(new SimpleClass(2, "qqq", new DateTime(1950, 5, 5)));
			list.Add(new SimpleClass(1, "zzz", new DateTime(1980, 5, 5)));
			list.Add(new SimpleClass(2, "mmm", new DateTime(1960, 5, 5)));
			list.Add(new SimpleClass(3, "bbb", new DateTime(1940, 5, 5)));
			list.Add(new SimpleClass(2, "mmm", new DateTime(1970, 5, 5)));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(props["IntegerValue"], ListSortDirection.Ascending),
				new ListSortDescription(props["StringValue"], ListSortDirection.Descending),
				new ListSortDescription(props["DateTimeValue"], ListSortDirection.Ascending)
			});
			view.ApplySort(sorts);

			IEnumerator pos = view.GetEnumerator();

			pos.MoveNext();
			object val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual(1, ((SimpleClass)val).IntegerValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual(2, ((SimpleClass)val).IntegerValue);
			Assert.AreEqual("qqq", ((SimpleClass)val).StringValue);
			Assert.AreEqual(new DateTime(1950, 5, 5), ((SimpleClass)val).DateTimeValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual(2, ((SimpleClass)val).IntegerValue);
			Assert.AreEqual("mmm", ((SimpleClass)val).StringValue);
			Assert.AreEqual(new DateTime(1960, 5, 5), ((SimpleClass)val).DateTimeValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual(2, ((SimpleClass)val).IntegerValue);
			Assert.AreEqual("mmm", ((SimpleClass)val).StringValue);
			Assert.AreEqual(new DateTime(1970, 5, 5), ((SimpleClass)val).DateTimeValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual(3, ((SimpleClass)val).IntegerValue);

			pos.MoveNext();
			val = pos.Current;
			Assert.IsNotNull(val);
			Assert.IsTrue(val is SimpleClass);
			Assert.AreEqual(4, ((SimpleClass)val).IntegerValue);
		}

		[Test]
		public void SupportsAdvancedSorting()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			Assert.IsTrue(((IBindingListView)factory.View).SupportsAdvancedSorting);
		}

		[Test]
		public void SupportsFiltering()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			Assert.IsTrue(((IBindingListView)factory.View).SupportsFiltering);
		}

		[Test]
		public void FilterDefault()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			Assert.IsNull(factory.View.Filter);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void FilterInvalidProperty()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "BadProp = 5";
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void FilterNoValue()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "BadProp =";
		}

		[Test]
		public void FilterNull()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = null;
			Assert.IsNull(view.Filter);

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("aaa", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[3]).StringValue);
			Assert.AreEqual("eee", ((SimpleClass)view[4]).StringValue);
		}

		[Test]
		public void FilterNoWhitespace()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "IntegerValue=5";
			Assert.AreEqual("IntegerValue=5", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual("bbb", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("eee", ((SimpleClass)view[2]).StringValue);
		}

		[Test]
		public void FilterExtraWhitespace()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "            IntegerValue               =           5   ";
			Assert.AreEqual("            IntegerValue               =           5   ", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual("bbb", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("eee", ((SimpleClass)view[2]).StringValue);
		}

		[Test]
		public void FilterEqualsInt()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "IntegerValue = 5";
			Assert.AreEqual("IntegerValue = 5", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual("bbb", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("eee", ((SimpleClass)view[2]).StringValue);
		}

		[Test]
		public void FilterNotEqualsInt()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "IntegerValue != 5";
			Assert.AreEqual("IntegerValue != 5", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual("aaa", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[1]).StringValue);
		}

		[Test]
		public void FilterNotEqualsIntAlternateOp()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "IntegerValue <> 5";
			Assert.AreEqual("IntegerValue <> 5", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual("aaa", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[1]).StringValue);
		}

		[Test]
		public void FilterLessThanInt()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "IntegerValue < 5";
			Assert.AreEqual("IntegerValue < 5", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual("aaa", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[1]).StringValue);
		}

		[Test]
		public void FilterLessThanEqualInt()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "IntegerValue <= 2";
			Assert.AreEqual("IntegerValue <= 2", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual("aaa", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[1]).StringValue);
		}

		[Test]
		public void FilterGreaterThanInt()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "IntegerValue > 1";
			Assert.AreEqual("IntegerValue > 1", view.Filter);

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual("bbb", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual("eee", ((SimpleClass)view[3]).StringValue);
		}

		[Test]
		public void FilterGreaterThanEqualInt()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "IntegerValue >= 2";
			Assert.AreEqual("IntegerValue >= 2", view.Filter);

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual("bbb", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual("eee", ((SimpleClass)view[3]).StringValue);
		}

		[Test]
		public void FilterEqualsString()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "aaa", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "StringValue = aaa";
			Assert.AreEqual("StringValue = aaa", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual(1, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(3, ((SimpleClass)view[1]).IntegerValue);
		}

		[Test]
		public void FilterEqualsStringRegExp()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "aaa", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "StringValue = a*";
			Assert.AreEqual("StringValue = a*", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual(1, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(3, ((SimpleClass)view[1]).IntegerValue);
		}

		[Test]
		public void FilterNotEqualsString()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "aaa", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "StringValue != aaa";
			Assert.AreEqual("StringValue != aaa", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(2, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[2]).IntegerValue);
		}

		[Test]
		public void FilterNotEqualsStringRegExp()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "aaa", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "StringValue != a*";
			Assert.AreEqual("StringValue != a*", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(2, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[2]).IntegerValue);
		}

		[Test]
		public void FilterNotEqualsStringAlternateOp()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "aaa", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "StringValue <> aaa";
			Assert.AreEqual("StringValue <> aaa", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(2, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[2]).IntegerValue);
		}

		[Test]
		public void FilterLessThanString()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "aaa", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "StringValue < ddd";
			Assert.AreEqual("StringValue < ddd", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(1, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(2, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(3, ((SimpleClass)view[2]).IntegerValue);
		}

		[Test]
		public void FilterLessThanEqualString()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "aaa", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "StringValue <= ddd";
			Assert.AreEqual("StringValue <= ddd", view.Filter);

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(2, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(3, ((SimpleClass)view[2]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[3]).IntegerValue);
		}

		[Test]
		public void FilterGreaterThanString()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "aaa", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "StringValue > bbb";
			Assert.AreEqual("StringValue > bbb", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual(4, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[1]).IntegerValue);
		}

		[Test]
		public void FilterGreaterThanEqualString()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "aaa", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "StringValue >= bbb";
			Assert.AreEqual("StringValue >= bbb", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(2, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[2]).IntegerValue);
		}

		[Test]
		public void FilterEqualsDate()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(3, "ccc", new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", new DateTime(1993, 11, 12)));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "DateTimeValue = 3/5/91";
			Assert.AreEqual("DateTimeValue = 3/5/91", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual(2, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[1]).IntegerValue);
		}

		[Test]
		public void FilterNotEqualsDate()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(3, "ccc", new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", new DateTime(1993, 11, 12)));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "DateTimeValue != 3/5/91";
			Assert.AreEqual("DateTimeValue != 3/5/91", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(1, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(3, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[2]).IntegerValue);
		}

		[Test]
		public void FilterNotEqualsDateAlternateOp()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(3, "ccc", new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", new DateTime(1993, 11, 12)));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "DateTimeValue <> 3/5/91";
			Assert.AreEqual("DateTimeValue <> 3/5/91", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(1, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(3, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[2]).IntegerValue);
		}

		[Test]
		public void FilterLessThanDate()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(3, "ccc", new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", new DateTime(1993, 11, 12)));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "DateTimeValue < 3/5/92";
			Assert.AreEqual("DateTimeValue < 3/5/92", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(2, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(3, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[2]).IntegerValue);
		}

		[Test]
		public void FilterLessThanEqualDate()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(3, "ccc", new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", new DateTime(1993, 11, 12)));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "DateTimeValue <= 3/5/92";
			Assert.AreEqual("DateTimeValue <= 3/5/92", view.Filter);

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(2, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(3, ((SimpleClass)view[2]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[3]).IntegerValue);
		}

		[Test]
		public void FilterGreaterThanDate()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(3, "ccc", new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", new DateTime(1993, 11, 12)));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "DateTimeValue > 1/2/91";
			Assert.AreEqual("DateTimeValue > 1/2/91", view.Filter);

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(2, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[2]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[3]).IntegerValue);
		}

		[Test]
		public void FilterGreaterThanEqualDate()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(3, "ccc", new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", new DateTime(1993, 11, 12)));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "DateTimeValue >= 3/5/92";
			Assert.AreEqual("DateTimeValue >= 3/5/92", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual(1, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[1]).IntegerValue);
		}

		[Test]
		public void FilterTwoTerms()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(3, "ccc", new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", new DateTime(1993, 11, 12)));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "DateTimeValue <= 3/5/92 AND IntegerValue > 2";
			Assert.AreEqual("DateTimeValue <= 3/5/92 AND IntegerValue > 2", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual(3, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[1]).IntegerValue);
		}

		[Test]
		public void FilterTwoTermsTrailingWhitespace()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(3, "ccc", new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", new DateTime(1993, 11, 12)));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "DateTimeValue <= 3/5/92 AND IntegerValue > 2 ";
			Assert.AreEqual("DateTimeValue <= 3/5/92 AND IntegerValue > 2 ", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual(3, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[1]).IntegerValue);
		}

		[Test]
		public void FilterThreeTerms()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(3, "ccc", new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", new DateTime(1993, 11, 12)));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "DateTimeValue <= 3/5/92 AND IntegerValue > 2 OR StringValue = 'eee'";
			Assert.AreEqual("DateTimeValue <= 3/5/92 AND IntegerValue > 2 OR StringValue = 'eee'", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual(3, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[2]).IntegerValue);
		}

		[Test]
		public void FilterThreeTermsWithParens()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", new DateTime(1992, 3, 5)));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(3, "ccc", new DateTime(1991, 1, 2)));
			list.Add(new SimpleClass(4, "ddd", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(5, "eee", new DateTime(1993, 11, 12)));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "DateTimeValue <= 3/5/92 AND (IntegerValue > 2 OR StringValue = 'eee')";
			Assert.AreEqual("DateTimeValue <= 3/5/92 AND (IntegerValue > 2 OR StringValue = 'eee')", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual(3, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[1]).IntegerValue);
		}

		[Test]
		public void FilterPathEquals()
		{
			ViewFactory factory = ViewFactory.IListOrders();
			ObjectListView view = factory.View;
			IList list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 12);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, carol);
			Customer mike = new Customer("Mike Palooza", acme, john);

			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));

			view.ItemType = typeof(Order);

			view.Filter = "Customer.AccountRep.Department = 12";
			Assert.AreEqual("Customer.AccountRep.Department = 12", view.Filter);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual("Boxes", ((Order)view[0]).Product);
			Assert.AreEqual("Gadgets", ((Order)view[1]).Product);
			Assert.AreEqual("Bolts", ((Order)view[2]).Product);
		}

		[Test]
		public void FilterPathNotEquals()
		{
			ViewFactory factory = ViewFactory.IListOrders();
			ObjectListView view = factory.View;
			IList list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 12);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, carol);
			Customer mike = new Customer("Mike Palooza", acme, john);

			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));

			view.ItemType = typeof(Order);

			view.Filter = "Customer.AccountRep.Department != 12";
			Assert.AreEqual("Customer.AccountRep.Department != 12", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual("Widgets", ((Order)view[0]).Product);
			Assert.AreEqual("Nails", ((Order)view[1]).Product);
		}

		[Test]
		public void FilterPathTwoTerms()
		{
			ViewFactory factory = ViewFactory.IListOrders();
			ObjectListView view = factory.View;
			IList list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 12);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, carol);
			Customer mike = new Customer("Mike Palooza", acme, john);

			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));

			view.ItemType = typeof(Order);

			view.Filter = "Customer.AccountRep.Department = 12 AND Customer.AccountRep.Name = Carol*";
			Assert.AreEqual("Customer.AccountRep.Department = 12 AND Customer.AccountRep.Name = Carol*", view.Filter);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual("Boxes", ((Order)view[0]).Product);
			Assert.AreEqual("Gadgets", ((Order)view[1]).Product);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void FilterPathMalformed()
		{
			ViewFactory factory = ViewFactory.IListOrders();
			ObjectListView view = factory.View;
			IList list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 12);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, carol);
			Customer mike = new Customer("Mike Palooza", acme, john);

			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));

			view.ItemType = typeof(Order);

			view.Filter = "Customer. = 12";
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void FilterPathMalformed2()
		{
			ViewFactory factory = ViewFactory.IListOrders();
			ObjectListView view = factory.View;
			IList list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 12);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, carol);
			Customer mike = new Customer("Mike Palooza", acme, john);

			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));

			view.ItemType = typeof(Order);

			view.Filter = "Customer..AccountRep = 12";
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void FilterPathMalformed3()
		{
			ViewFactory factory = ViewFactory.IListOrders();
			ObjectListView view = factory.View;
			IList list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 12);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, carol);
			Customer mike = new Customer("Mike Palooza", acme, john);

			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));

			view.ItemType = typeof(Order);

			view.Filter = ".";
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void FilterPathInvalid()
		{
			ViewFactory factory = ViewFactory.IListOrders();
			ObjectListView view = factory.View;
			IList list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 12);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, carol);
			Customer mike = new Customer("Mike Palooza", acme, john);

			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));

			view.ItemType = typeof(Order);

			view.Filter = "Customer.Rank = 12";
		}

		[Test]
		public void FilterPathInaccessibleValue()
		{
			ViewFactory factory = ViewFactory.IListOrders();
			ObjectListView view = factory.View;
			IList list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 12);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, carol);
			Customer mike = new Customer("Mike Palooza", acme, john);
			Customer rick = new Customer("Rick Doohan", ajax, null);

			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));
			list.Add(new Order(rick, "Glue", 15));

			view.ItemType = typeof(Order);

			// Rick's order should be excluded because there is no AccountRep.
			view.Filter = "Customer.AccountRep.Department = 12";

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual("Boxes", ((Order)view[0]).Product);
			Assert.AreEqual("Gadgets", ((Order)view[1]).Product);
			Assert.AreEqual("Bolts", ((Order)view[2]).Product);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void FilterPathNonPublicProperty()
		{
			ViewFactory factory = ViewFactory.IListOrders();
			ObjectListView view = factory.View;
			IList list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 12);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, carol);
			Customer mike = new Customer("Mike Palooza", acme, john);
			Customer rick = new Customer("Rick Doohan", ajax, null);

			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));
			list.Add(new Order(rick, "Glue", 15));

			view.ItemType = typeof(Order);

			// SSN is protected.
			view.Filter = "Customer.AccountRep.SSN = 123456789";
		}

		[Test]
		public void FilterNullAfterFilter()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "IntegerValue = 5";

			Assert.AreEqual(1, view.Count);

			view.Filter = null;

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual(1, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(2, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(3, ((SimpleClass)view[2]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[3]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[4]).IntegerValue);
		}

		[Test]
		public void FilterRemove()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "IntegerValue = 5";

			Assert.AreEqual(1, view.Count);

			view.RemoveFilter();

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual(1, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(2, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(3, ((SimpleClass)view[2]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[3]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[4]).IntegerValue);
		}

		[Test]
		public void FilterRemoveNoFilter()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.RemoveFilter();

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual(1, ((SimpleClass)view[0]).IntegerValue);
			Assert.AreEqual(2, ((SimpleClass)view[1]).IntegerValue);
			Assert.AreEqual(3, ((SimpleClass)view[2]).IntegerValue);
			Assert.AreEqual(4, ((SimpleClass)view[3]).IntegerValue);
			Assert.AreEqual(5, ((SimpleClass)view[4]).IntegerValue);
		}

		[Test]
		public void FilterAddMatchingItem()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "IntegerValue = 5";

			view.Add(new SimpleClass(5, "fff", DateTime.Now));

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual("bbb", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("eee", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual("fff", ((SimpleClass)view[3]).StringValue);
		}

		[Test]
		public void FilterAddNonMatchingItem()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			view.Filter = "IntegerValue = 5";

			view.Add(new SimpleClass(6, "fff", DateTime.Now));

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual("bbb", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("eee", ((SimpleClass)view[2]).StringValue);
		}

		[Test]
		public void FilterRemoveMatchingItem()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			// Filter is:
			//  bbb
			//  ccc
			//  eee
			view.Filter = "IntegerValue = 5";

			// Remove ccc
			view.RemoveAt(1);

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual("bbb", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("eee", ((SimpleClass)view[1]).StringValue);
		}

		[Test]
		public void FilterRemoveNonMatchingItem()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			SimpleClass aaa = new SimpleClass(1, "aaa", DateTime.Now);
			list.Add(aaa);
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.ItemType = typeof(SimpleClass);

			// Filter is:
			//  bbb
			//  ccc
			//  eee
			view.Filter = "IntegerValue = 5";

			// Remove aaa
			// Since aaa is not in the filter, it's not "in the view" and can't be removed.  However, the remove should be silent.
			view.Remove(aaa);

			Assert.IsTrue(list.Contains(aaa));
		}

		[Test]
		public void FilterAndSort()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(1, "eee", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			view.ItemType = typeof(SimpleClass);

			// Filter should be:
			//  aaa Now
			//  bbb 1950
			//  eee Now
			//  bbb 1960
			view.Filter = "IntegerValue = 1";

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];
			PropertyDescriptor dateProp = props["DateTimeValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(stringProp, ListSortDirection.Descending),
				new ListSortDescription(dateProp, ListSortDirection.Descending)});

			// Sort should be:
			//  eee Now
			//  bbb 1960
			//  bbb 1950
			//  aaa Now
			view.ApplySort(sorts);

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual("eee", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass)view[1]).DateTimeValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass)view[2]).DateTimeValue);
			Assert.AreEqual("aaa", ((SimpleClass)view[3]).StringValue);
		}

		[Test]
		public void SortAndFilter()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(1, "eee", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			view.ItemType = typeof(SimpleClass);

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];
			PropertyDescriptor dateProp = props["DateTimeValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(stringProp, ListSortDirection.Descending),
				new ListSortDescription(dateProp, ListSortDirection.Descending)});

			// Sort should be:
			//  eee Now
			//  ddd Now
			//  ccc Now
			//  bbb 1960
			//  bbb 1950
			//  aaa Now
			view.ApplySort(sorts);

			// Filter should be:
			//  eee Now
			//  bbb 1960
			//  bbb 1950
			//  aaa Now
			view.Filter = "IntegerValue = 1";

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual("eee", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass)view[1]).DateTimeValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass)view[2]).DateTimeValue);
			Assert.AreEqual("aaa", ((SimpleClass)view[3]).StringValue);
		}

		[Test]
		public void FilterSortFilter()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(3, "aaa", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(1, "eee", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			view.ItemType = typeof(SimpleClass);

			// Filter should be:
			//  aaa Now
			//  bbb 1950
			//  eee Now
			//  bbb 1960
			view.Filter = "IntegerValue = 1";

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];
			PropertyDescriptor dateProp = props["DateTimeValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(stringProp, ListSortDirection.Descending),
				new ListSortDescription(dateProp, ListSortDirection.Descending)});

			// Sort should be:
			//  eee Now
			//  bbb 1960
			//  bbb 1950
			//  aaa Now
			view.ApplySort(sorts);

			// Filter should be:
			//  ccc Now
			//  aaa Now
			view.Filter = "IntegerValue = 3";

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual("ccc", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("aaa", ((SimpleClass)view[1]).StringValue);
		}

		[Test]
		public void FilterSortSort()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(1, "eee", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			view.ItemType = typeof(SimpleClass);

			// Filter should be:
			//  aaa Now
			//  bbb 1950
			//  eee Now
			//  bbb 1960
			view.Filter = "IntegerValue = 1";

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];
			PropertyDescriptor dateProp = props["DateTimeValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(stringProp, ListSortDirection.Descending),
				new ListSortDescription(dateProp, ListSortDirection.Descending)});

			// Sort should be:
			//  eee Now
			//  bbb 1960
			//  bbb 1950
			//  aaa Now
			view.ApplySort(sorts);

			sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(stringProp, ListSortDirection.Ascending),
				new ListSortDescription(dateProp, ListSortDirection.Descending)});

			// Sort should be:
			//  aaa Now
			//  bbb 1960
			//  bbb 1950
			//  eee Now
			view.ApplySort(sorts);

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual("aaa", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass)view[1]).DateTimeValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass)view[2]).DateTimeValue);
			Assert.AreEqual("eee", ((SimpleClass)view[3]).StringValue);
		}

		[Test]
		public void SortFilterSort()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(1, "eee", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			view.ItemType = typeof(SimpleClass);

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];
			PropertyDescriptor dateProp = props["DateTimeValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(stringProp, ListSortDirection.Descending),
				new ListSortDescription(dateProp, ListSortDirection.Descending)});

			// Sort should be:
			//  eee Now
			//  ddd Now
			//  ccc Now
			//  bbb 1960
			//  bbb 1950
			//  aaa Now
			view.ApplySort(sorts);

			// Filter should be:
			//  eee Now
			//  bbb 1960
			//  bbb 1950
			//  aaa Now
			view.Filter = "IntegerValue = 1";

			sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(stringProp, ListSortDirection.Ascending),
				new ListSortDescription(dateProp, ListSortDirection.Descending)});

			// Sort should be:
			//  aaa Now
			//  bbb 1960
			//  bbb 1950
			//  eee Now
			view.ApplySort(sorts);

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual("aaa", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass)view[1]).DateTimeValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass)view[2]).DateTimeValue);
			Assert.AreEqual("eee", ((SimpleClass)view[3]).StringValue);
		}

		[Test]
		public void SortFilterFilter()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(3, "ddd", DateTime.Now));
			list.Add(new SimpleClass(1, "eee", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			view.ItemType = typeof(SimpleClass);

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];
			PropertyDescriptor dateProp = props["DateTimeValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(stringProp, ListSortDirection.Descending),
				new ListSortDescription(dateProp, ListSortDirection.Descending)});

			// Sort should be:
			//  eee Now
			//  ddd Now
			//  ccc Now
			//  bbb 1960
			//  bbb 1950
			//  aaa Now
			view.ApplySort(sorts);

			// Filter should be:
			//  eee Now
			//  bbb 1960
			//  bbb 1950
			//  aaa Now
			view.Filter = "IntegerValue = 1";

			// Filter should be:
			//  ddd Now
			//  ccc Now
			view.Filter = "IntegerValue = 3";

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual("ddd", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[1]).StringValue);
		}

		[Test]
		public void SortStable()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(3, "ddd", now));
			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			view.ItemType = typeof(SimpleClass);

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Ascending)});

			// Sort should be:
			//  aaa Now
			//  bbb 1950
			//  eee Now
			//  bbb 1960
			//  ccc Now
			//  ddd Now
			view.ApplySort(sorts);

			Assert.AreEqual(6, view.Count);
			Assert.AreEqual("aaa", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass)view[1]).DateTimeValue);
			Assert.AreEqual("eee", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[3]).StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass)view[3]).DateTimeValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[4]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[5]).StringValue);
		}

		[Test]
		public void SortStableNullItems()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(null);
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(3, "ddd", now));
			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			view.ItemType = typeof(SimpleClass);

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Ascending)});

			// Sort should be:
			//  null
			//  aaa Now
			//  bbb 1950
			//  eee Now
			//  bbb 1960
			//  ccc Now
			//  ddd Now
			view.ApplySort(sorts);

			Assert.AreEqual(7, view.Count);
			Assert.IsNull(view[0]);
			Assert.AreEqual("aaa", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass)view[2]).DateTimeValue);
			Assert.AreEqual("eee", ((SimpleClass)view[3]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[4]).StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass)view[4]).DateTimeValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[5]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[6]).StringValue);

			sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Descending)});

			// Sort should be:
			//  ddd Now
			//  ccc Now
			//  bbb 1960
			//  eee Now
			//  bbb 1950
			//  aaa Now
			//  null
			view.ApplySort(sorts);

			Assert.AreEqual(7, view.Count);
			Assert.AreEqual("ddd", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass)view[2]).DateTimeValue);
			Assert.AreEqual("eee", ((SimpleClass)view[3]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[4]).StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass)view[4]).DateTimeValue);
			Assert.AreEqual("aaa", ((SimpleClass)view[5]).StringValue);
			Assert.IsNull(view[6]);
		}

		[Test]
		public void SortStableNullValues()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(1, null, new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(3, "ddd", now));
			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			view.ItemType = typeof(SimpleClass);

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Ascending)});

			// Sort should be:
			//  aaa Now
			//  bbb 1950
			//  null
			//  eee Now
			//  bbb 1960
			//  ccc Now
			//  ddd Now
			view.ApplySort(sorts);

			Assert.AreEqual(7, view.Count);
			Assert.AreEqual("aaa", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass)view[1]).DateTimeValue);
			Assert.IsNull(((SimpleClass)view[2]).StringValue);
			Assert.AreEqual("eee", ((SimpleClass)view[3]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[4]).StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass)view[4]).DateTimeValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[5]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[6]).StringValue);

			sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Descending)});

			// Sort should be:
			//  ddd Now
			//  ccc Now
			//  bbb 1960
			//  eee Now
			//  null
			//  bbb 1950
			//  aaa Now
			view.ApplySort(sorts);

			Assert.AreEqual(7, view.Count);
			Assert.AreEqual("ddd", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass)view[2]).DateTimeValue);
			Assert.AreEqual("eee", ((SimpleClass)view[3]).StringValue);
			Assert.IsNull(((SimpleClass)view[4]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[5]).StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass)view[5]).DateTimeValue);
			Assert.AreEqual("aaa", ((SimpleClass)view[6]).StringValue);
		}

		[Test]
		public void SortStableMultipleProps()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(3, "ddd", now));
			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			view.ItemType = typeof(SimpleClass);

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];
			PropertyDescriptor stringProp = props["StringValue"];
			PropertyDescriptor dateProp = props["DateTimeValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Ascending),
				new ListSortDescription(stringProp, ListSortDirection.Ascending)});

			// Sort should be:
			//  aaa Now
			//  bbb 1950
			//  bbb 1960
			//  eee Now
			//  ccc Now
			//  ddd Now
			view.ApplySort(sorts);

			Assert.AreEqual(6, view.Count);
			Assert.AreEqual("aaa", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass)view[1]).DateTimeValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass)view[2]).DateTimeValue);
			Assert.AreEqual("eee", ((SimpleClass)view[3]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[4]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[5]).StringValue);
		}

		[Test]
		public void SortStableMultiplePropsResort()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(3, "ddd", now));
			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			view.ItemType = typeof(SimpleClass);

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];
			PropertyDescriptor stringProp = props["StringValue"];
			PropertyDescriptor dateProp = props["DateTimeValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Ascending),
				new ListSortDescription(stringProp, ListSortDirection.Ascending)});

			// Sort should be:
			//  aaa Now
			//  bbb 1950
			//  bbb 1960
			//  eee Now
			//  ccc Now
			//  ddd Now
			view.ApplySort(sorts);

			sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Descending)});

			// Sort should be:
			//  ddd Now
			//  ccc Now
			//  bbb 1960
			//  eee Now
			//  bbb 1950
			//  aaa Now
			view.ApplySort(sorts);

			Assert.AreEqual(6, view.Count);
			Assert.AreEqual("ddd", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass)view[2]).DateTimeValue);
			Assert.AreEqual("eee", ((SimpleClass)view[3]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[4]).StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass)view[4]).DateTimeValue);
			Assert.AreEqual("aaa", ((SimpleClass)view[5]).StringValue);
		}

		[Test]
		public void SortStableRemoveSort()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(3, "ddd", now));
			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			view.ItemType = typeof(SimpleClass);

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];
			PropertyDescriptor stringProp = props["StringValue"];
			PropertyDescriptor dateProp = props["DateTimeValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Ascending),
				new ListSortDescription(stringProp, ListSortDirection.Ascending)});

			// Sort should be:
			//  aaa Now
			//  bbb 1950
			//  bbb 1960
			//  eee Now
			//  ccc Now
			//  ddd Now
			view.ApplySort(sorts);

			sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Descending)});

			// Sort should be:
			//  ddd Now
			//  ccc Now
			//  bbb 1960
			//  eee Now
			//  bbb 1950
			//  aaa Now
			view.ApplySort(sorts);

			// Sort should be:
			//  aaa Now
			//  bbb 1950
			//  ccc Now
			//  ddd Now
			//  eee Now
			//  bbb 1960
			view.RemoveSort();

			Assert.AreEqual(6, view.Count);
			Assert.AreEqual("aaa", ((SimpleClass)view[0]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[1]).StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass)view[1]).DateTimeValue);
			Assert.AreEqual("ccc", ((SimpleClass)view[2]).StringValue);
			Assert.AreEqual("ddd", ((SimpleClass)view[3]).StringValue);
			Assert.AreEqual("eee", ((SimpleClass)view[4]).StringValue);
			Assert.AreEqual("bbb", ((SimpleClass)view[5]).StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass)view[5]).DateTimeValue);
		}

		[Test]
		public void SortDescriptionsDefault()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;

			Assert.IsNotNull(view.SortDescriptions);
			Assert.AreEqual(0, view.SortDescriptions.Count);
		}

		[Test]
		public void SortDescriptionsSorted()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;
			view.ItemType = factory.ListItemType;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(3, "ddd", now));
			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Ascending)});

			view.ApplySort(sorts);

			Assert.IsNotNull(view.SortDescriptions);
			Assert.AreEqual(1, view.SortDescriptions.Count);
			Assert.AreEqual(intProp, view.SortDescriptions[0].PropertyDescriptor);
			Assert.AreEqual(ListSortDirection.Ascending, view.SortDescriptions[0].SortDirection);
		}

		[Test]
		public void SortDescriptionsSortedMultipleProps()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;
			view.ItemType = factory.ListItemType;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(1, "eee", DateTime.Now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];
			PropertyDescriptor dateProp = props["DateTimeValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(stringProp, ListSortDirection.Descending),
				new ListSortDescription(dateProp, ListSortDirection.Ascending)});

			view.ApplySort(sorts);

			Assert.IsNotNull(view.SortDescriptions);
			Assert.AreEqual(2, view.SortDescriptions.Count);
			Assert.AreEqual(stringProp, view.SortDescriptions[0].PropertyDescriptor);
			Assert.AreEqual(ListSortDirection.Descending, view.SortDescriptions[0].SortDirection);
			Assert.AreEqual(dateProp, view.SortDescriptions[1].PropertyDescriptor);
			Assert.AreEqual(ListSortDirection.Ascending, view.SortDescriptions[1].SortDirection);
		}

		[Test]
		public void SortDescriptionsRemoveSort()
		{
			ViewFactory factory = ViewFactory.IListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;
			view.ItemType = factory.ListItemType;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(3, "ddd", now));
			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Ascending)});

			view.ApplySort(sorts);
			view.RemoveSort();

			Assert.IsNotNull(view.SortDescriptions);
			Assert.AreEqual(0, view.SortDescriptions.Count);
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void EnumerateFilterPropertyChanging()
		{
			ViewFactory factory = ViewFactory.IListINotifyPropertyChangedItems();
			ObjectListView view = factory.View;

			view.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
			view.Add(new NotifyingListItem(2, "bbb", DateTime.Now));
			view.Add(new NotifyingListItem(3, "ccc", DateTime.Now));
			view.Add(new NotifyingListItem(4, "ddd", DateTime.Now));
			view.Add(new NotifyingListItem(5, "eee", DateTime.Now));

			view.ItemType = typeof(NotifyingListItem);

			view.Filter = "IntegerValue > 1";

			foreach (NotifyingListItem item in view)
			{
				item.IntegerValue = 7;
			}
		}

		[Test]
		[ExpectedException(typeof(InvalidOperationException))]
		public void EnumerateSortPropertyChanging()
		{
			ViewFactory factory = ViewFactory.IListINotifyPropertyChangedItems();
			ObjectListView view = factory.View;

			view.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
			view.Add(new NotifyingListItem(2, "bbb", DateTime.Now));
			view.Add(new NotifyingListItem(3, "ccc", DateTime.Now));
			view.Add(new NotifyingListItem(4, "ddd", DateTime.Now));
			view.Add(new NotifyingListItem(5, "eee", DateTime.Now));

			view.ItemType = typeof(NotifyingListItem);

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(NotifyingListItem))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			foreach (NotifyingListItem item in view)
			{
				item.IntegerValue = 7;
			}
		}

		[Test]
		public void EnumerateFilterUnrelatedPropertyChanging()
		{
			ViewFactory factory = ViewFactory.IListINotifyPropertyChangedItems();
			ObjectListView view = factory.View;

			view.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
			view.Add(new NotifyingListItem(2, "bbb", DateTime.Now));
			view.Add(new NotifyingListItem(3, "ccc", DateTime.Now));
			view.Add(new NotifyingListItem(4, "ddd", DateTime.Now));
			view.Add(new NotifyingListItem(5, "eee", DateTime.Now));

			view.ItemType = typeof(NotifyingListItem);

			view.Filter = "IntegerValue = 5";

			foreach (NotifyingListItem item in view)
			{
				item.DateTimeValue = new DateTime(1991, 3, 5);
			}
		}

		[Test]
		public void EnumerateSortUnrelatedPropertyChanging()
		{
			ViewFactory factory = ViewFactory.IListINotifyPropertyChangedItems();
			ObjectListView view = factory.View;

			view.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
			view.Add(new NotifyingListItem(2, "bbb", DateTime.Now));
			view.Add(new NotifyingListItem(3, "ccc", DateTime.Now));
			view.Add(new NotifyingListItem(4, "ddd", DateTime.Now));
			view.Add(new NotifyingListItem(5, "eee", DateTime.Now));

			view.ItemType = typeof(NotifyingListItem);

			PropertyDescriptor intProp = TypeDescriptor.GetProperties(typeof(NotifyingListItem))["IntegerValue"];
			view.ApplySort(intProp, ListSortDirection.Ascending);

			foreach (NotifyingListItem item in view)
			{
				item.DateTimeValue = new DateTime(1991, 3, 5);
			}
		}

		[Test]
		public void FilterValuesChanged()
		{
			ViewFactory factory = ViewFactory.IBindingListOrders();
			ObjectListView view = factory.View;
			IList list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 12);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, carol);
			Customer mike = new Customer("Mike Palooza", acme, john);

			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));

			view.ItemType = typeof(Order);

			view.Filter = "Quantity > 20";

			Assert.AreEqual(2, view.Count);

			((Order)list[0]).Quantity = 100;

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual("Widgets", ((Order)view[0]).Product);
			Assert.AreEqual("Nails", ((Order)view[1]).Product);
			Assert.AreEqual("Bolts", ((Order)view[2]).Product);
		}

		//[Test]
		//public void FilterPathValuesChanged()
		//{
		//    ViewFactory factory = ViewFactory.IBindingListOrders();
		//    ObjectListView view = factory.View;
		//    IList list = factory.List;

		//    Company acme = new Company("Acme", "Seattle", "WA");
		//    Company ajax = new Company("Ajax", "Detroit", "MI");
		//    AccountRep steve = new AccountRep("Steve O'Donnell", 56);
		//    AccountRep carol = new AccountRep("Carol Hanson", 12);
		//    AccountRep john = new AccountRep("John Roche", 12);

		//    Customer bob = new Customer("Bob Smith", acme, steve);
		//    Customer tom = new Customer("Tom Kelly", ajax, carol);
		//    Customer mike = new Customer("Mike Palooza", acme, john);

		//    list.Add(new Order(bob, "Widgets", 10));
		//    list.Add(new Order(bob, "Nails", 200));
		//    list.Add(new Order(tom, "Boxes", 20));
		//    list.Add(new Order(tom, "Gadgets", 7));
		//    list.Add(new Order(mike, "Bolts", 3000));

		//    view.ItemType = typeof(Order);

		//    view.Filter = "Customer.Company.Name = Ajax";

		//    Assert.AreEqual(2, view.Count);

		//    mike.Company = ajax;

		//    Assert.AreEqual(3, view.Count);
		//    Assert.AreEqual("Boxes", ((Order)view[0]).Product);
		//    Assert.AreEqual("Gadgets", ((Order)view[1]).Product);
		//    Assert.AreEqual("Bolts", ((Order)view[2]).Product);
		//}

		[Test]
		public void ListChangedItemAddedNotInFilter()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.Filter = "IntegerValue < 5";
			factory.ClearEventCounts();

			list.Add(new SimpleClass(6, "fff", DateTime.Now));

			Assert.AreEqual(0, factory.ListChangedAddedCount);
		}

		[Test]
		public void ListChangedItemDeletedNotInFilter()
		{
			ViewFactory factory = ViewFactory.IBindingListSimpleItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.Filter = "IntegerValue < 5";
			factory.ClearEventCounts();

			list.RemoveAt(1);

			Assert.AreEqual(0, factory.ListChangedDeletedCount);
		}

		[Test]
		public void ListChangedItemChangedNotInFilter()
		{
			ViewFactory factory = ViewFactory.IBindingListINotifyPropertyChangedItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
			NotifyingListItem bbb = new NotifyingListItem(5, "bbb", DateTime.Now);
			list.Add(bbb);
			list.Add(new NotifyingListItem(5, "ccc", DateTime.Now));
			list.Add(new NotifyingListItem(2, "ddd", DateTime.Now));
			list.Add(new NotifyingListItem(5, "eee", DateTime.Now));

			view.Filter = "IntegerValue < 5";
			factory.ClearEventCounts();

			bbb.IntegerValue = 6;

			Assert.AreEqual(0, factory.ListChangedItemChangedCount);
			Assert.AreEqual(0, factory.ListChangedDeletedCount);
		}

		[Test]
		public void ListChangedItemChangedIntoFilter()
		{
			ViewFactory factory = ViewFactory.IBindingListINotifyPropertyChangedItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
			NotifyingListItem bbb = new NotifyingListItem(5, "bbb", DateTime.Now);
			list.Add(bbb);
			list.Add(new NotifyingListItem(5, "ccc", DateTime.Now));
			list.Add(new NotifyingListItem(2, "ddd", DateTime.Now));
			list.Add(new NotifyingListItem(5, "eee", DateTime.Now));

			view.Filter = "IntegerValue < 5";
			factory.ClearEventCounts();

			bbb.IntegerValue = 4;

			Assert.AreEqual(1, factory.ListChangedAddedCount);
		}

		[Test]
		public void ListChangedItemChangedOutOfFilter()
		{
			ViewFactory factory = ViewFactory.IBindingListINotifyPropertyChangedItems();
			ObjectListView view = factory.View;
			IList list = factory.List;

			list.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
			list.Add(new NotifyingListItem(5, "bbb", DateTime.Now));
			list.Add(new NotifyingListItem(5, "ccc", DateTime.Now));
			NotifyingListItem ddd = new NotifyingListItem(2, "ddd", DateTime.Now);
			list.Add(ddd);
			list.Add(new NotifyingListItem(5, "eee", DateTime.Now));

			view.Filter = "IntegerValue < 5";
			factory.ClearEventCounts();

			ddd.IntegerValue = 6;

			Assert.AreEqual(0, factory.ListChangedItemChangedCount);
			Assert.AreEqual(1, factory.ListChangedDeletedCount);
		}
	}
}
#endif
