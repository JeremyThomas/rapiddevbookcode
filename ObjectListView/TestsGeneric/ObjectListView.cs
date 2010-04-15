// ObjectListView
// Copyright � 2006, 2007 Jesse Johnston.  All rights reserved.

#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using JesseJohnston;
using System.ComponentModel;

namespace JesseJohnston.Tests.Generic
{
	[TestFixture]
	public class ObjectListViewTests
	{
		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ConstructNullList()
		{
			ObjectListView<SimpleClass> view = new ObjectListView<SimpleClass>(null);
		}

		[Test]
		public void ConstructEmptyList()
		{
			ObjectListView<SimpleClass> view = new ObjectListView<SimpleClass>(new List<SimpleClass>());
			Assert.AreEqual(0, view.Count);
		}

		[Test]
		public void BeginUpdate()
		{
			ViewFactory<NotifyingListItem> factory = ViewFactory<NotifyingListItem>.IBindingList();
			ObjectListView<NotifyingListItem> view = factory.View;
			IList<NotifyingListItem> list = factory.List;

			view.BeginUpdate();

			NotifyingListItem item = new NotifyingListItem();

			view.Add(item);			// normally would raise ListChanged (ItemAdded)
			item.IntegerValue = 9;	// normally would raise ListChanged (ItemChanged, reflecting PropertyChanged)

			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedItemChangedCount);

			view.EndUpdate();

			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedItemChangedCount);
			Assert.AreEqual(1, factory.ListChangedResetCount);
		}

		[Test]
		public void BeginUpdateSortFilter()
		{
			ViewFactory<NotifyingListItem> factory = ViewFactory<NotifyingListItem>.IBindingList();
			ObjectListView<NotifyingListItem> view = factory.View;
			IList<NotifyingListItem> list = factory.List;

			list.Add(new NotifyingListItem(1, "aaa", DateTime.Now));

			view.Filter = "IntegerValue < 5";
			view.ApplySort(TypeDescriptor.GetProperties(typeof(NotifyingListItem))["StringValue"], ListSortDirection.Descending);

			factory.ClearEventCounts();

			view.BeginUpdate();

			list.Add(new NotifyingListItem(5, "bbb", DateTime.Now));
			list.Add(new NotifyingListItem(5, "ccc", DateTime.Now));
			list.Add(new NotifyingListItem(2, "ddd", DateTime.Now));
			list.Add(new NotifyingListItem(5, "eee", DateTime.Now));

			((NotifyingListItem)list[1]).IntegerValue = 4;
			list.RemoveAt(3);

			view.EndUpdate();

			Assert.AreEqual(2, view.Count);
			Assert.AreEqual("bbb", view[0].StringValue);
			Assert.AreEqual("aaa", view[1].StringValue);

			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedItemChangedCount);
			Assert.AreEqual(0, factory.ListChangedDeletedCount);
			Assert.AreEqual(1, factory.ListChangedResetCount);
		}

		[Test]
		public void EndUpdateWithoutBeginUpdate()
		{
			ViewFactory<NotifyingListItem> factory = ViewFactory<NotifyingListItem>.IBindingList();
			ObjectListView<NotifyingListItem> view = factory.View;

			NotifyingListItem item = new NotifyingListItem();

			view.Add(item);
			item.IntegerValue = 9;

			Assert.AreEqual(1, factory.ListChangedAddedCount);
			Assert.AreEqual(1, factory.ListChangedItemChangedCount);

			view.EndUpdate();

			Assert.AreEqual(1, factory.ListChangedAddedCount);
			Assert.AreEqual(1, factory.ListChangedItemChangedCount);
			Assert.AreEqual(0, factory.ListChangedResetCount);
		}

		[Test]
		public void EndUpdateWithoutChanges()
		{
			ViewFactory<NotifyingListItem> factory = ViewFactory<NotifyingListItem>.IBindingList();
			ObjectListView<NotifyingListItem> view = factory.View;

			NotifyingListItem item = new NotifyingListItem();

			view.Add(item);
			item.IntegerValue = 9;

			factory.ClearEventCounts();

			view.BeginUpdate();
			view.EndUpdate();

			Assert.AreEqual(0, factory.ListChangedResetCount);
		}

		[Test]
		public void SortedEvent()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

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

			Assert.AreEqual(0, factory.SortedCount);

			view.ApplySort(sorts);

			Assert.AreEqual(1, factory.SortedCount);
		}

		[Test]
		public void RemoveSorted()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(5, "aaa", now));
			list.Add(new SimpleClass(4, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(3, "ddd", now));
			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1960, 1, 1)));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Ascending)});

			view.ApplySort(sorts);
			factory.ClearEventCounts();

			view.RemoveAt(3);
			view.RemoveAt(2);

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, view[0].IntegerValue);
			Assert.AreEqual(2, view[1].IntegerValue);
			Assert.AreEqual(4, view[2].IntegerValue);
			Assert.AreEqual(5, view[3].IntegerValue);

			Assert.AreEqual(2, factory.ListChangedDeletedCount);
			Assert.AreEqual(0, factory.ListChangedResetCount);
			Assert.AreEqual(0, factory.SortedCount);
		}

		[Test]
		public void RemoveSortedIBindingList()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(5, "aaa", now));
			list.Add(new SimpleClass(4, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(3, "ddd", now));
			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(2, "bbb", new DateTime(1960, 1, 1)));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor intProp = props["IntegerValue"];

			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
				new ListSortDescription(intProp, ListSortDirection.Ascending)});

			view.ApplySort(sorts);
			factory.ClearEventCounts();

			view.RemoveAt(3);
			view.RemoveAt(2);

			Assert.AreEqual(4, view.Count);
			Assert.AreEqual(1, view[0].IntegerValue);
			Assert.AreEqual(2, view[1].IntegerValue);
			Assert.AreEqual(4, view[2].IntegerValue);
			Assert.AreEqual(5, view[3].IntegerValue);

			Assert.AreEqual(2, factory.ListChangedDeletedCount);
			Assert.AreEqual(0, factory.ListChangedResetCount);
			Assert.AreEqual(0, factory.SortedCount);
		}

		[Test]
		public void PropertyComparerDefault()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			Assert.IsNotNull(view.PropertyComparers);
			Assert.AreEqual(0, view.PropertyComparers.Count);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void PropertyComparerNullProperty()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			factory.View.PropertyComparers[null] = new StringLengthComparer();
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void PropertyComparerEmptyProperty()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			factory.View.PropertyComparers[""] = new StringLengthComparer();
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void PropertyComparerInvalidProperty()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			factory.View.PropertyComparers["NonexistentProperty"] = new StringLengthComparer();
		}

		[Test]
		public void PropertyComparerAdd()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			view.PropertyComparers.Add("StringProperty", new StringLengthComparer());
			Assert.AreEqual(1, view.PropertyComparers.Count);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void PropertyComparerAddDuplicate()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			view.PropertyComparers.Add("StringProperty", new StringLengthComparer());
			view.PropertyComparers.Add("StringProperty", new StringLengthComparer());
		}

		[Test]
		public void PropertyComparerSet()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			view.PropertyComparers["StringValue"] = new StringLengthComparer();
			Assert.AreEqual(1, view.PropertyComparers.Count);
		}

		[Test]
		public void PropertyComparerSetTwice()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			view.PropertyComparers["StringValue"] = new StringLengthComparer();
			view.PropertyComparers["StringValue"] = new StringLengthComparer();
			Assert.AreEqual(1, view.PropertyComparers.Count);
		}

		[Test]
		public void PropertyComparerSetNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			view.PropertyComparers["StringValue"] = null;
			Assert.AreEqual(0, view.PropertyComparers.Count);
		}

		[Test]
		public void PropertyComparerSetNullAfterSet()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			view.PropertyComparers["StringValue"] = new StringLengthComparer();
			view.PropertyComparers["StringValue"] = null;
			Assert.AreEqual(0, view.PropertyComparers.Count);
		}

		[Test]
		public void PropertyComparerGet()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			StringLengthComparer s = new StringLengthComparer();
			view.PropertyComparers["StringValue"] = s;
			Assert.AreEqual(s, view.PropertyComparers["StringValue"]);
		}

		[Test]
		public void PropertyComparerGetNotSet()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			Assert.IsNull(view.PropertyComparers["StringValue"]);
		}

		[Test]
		public void PropertyComparerGetSetNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			view.PropertyComparers["StringValue"] = null;
			Assert.IsNull(view.PropertyComparers["StringValue"]);
		}

		[Test]
		public void PropertyComparerRemove()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			view.PropertyComparers.Add("StringProperty", new StringLengthComparer());
			view.PropertyComparers.Remove("StringProperty");
			Assert.AreEqual(0, view.PropertyComparers.Count);
		}

		[Test]
		public void PropertyComparerRemoveNoAdd()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			view.PropertyComparers.Remove("StringProperty");
			Assert.AreEqual(0, view.PropertyComparers.Count);
		}

		[Test]
		public void UsePropertyComparer()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "a", now));
			list.Add(new SimpleClass(1, "bbb", now));
			list.Add(new SimpleClass(1, "aaaa", now));
			list.Add(new SimpleClass(1, "aa", now));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];

			factory.ClearEventCounts();

			view.PropertyComparers["StringValue"] = new StringLengthComparer();
			view.ApplySort(stringProp, ListSortDirection.Ascending);

			Assert.AreEqual(1, factory.ListChangedResetCount);
			Assert.AreEqual(1, factory.SortedCount);

			Assert.AreEqual("a", view[0].StringValue);
			Assert.AreEqual("aa", view[1].StringValue);
			Assert.AreEqual("bbb", view[2].StringValue);
			Assert.AreEqual("aaaa", view[3].StringValue);
		}

		[Test]
		public void UsePropertyComparerAfterSort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "a", now));
			list.Add(new SimpleClass(1, "bbb", now));
			list.Add(new SimpleClass(1, "aaaa", now));
			list.Add(new SimpleClass(1, "aa", now));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];

			view.ApplySort(stringProp, ListSortDirection.Ascending);

			Assert.AreEqual("a", view[0].StringValue);
			Assert.AreEqual("aa", view[1].StringValue);
			Assert.AreEqual("aaaa", view[2].StringValue);
			Assert.AreEqual("bbb", view[3].StringValue);

			factory.ClearEventCounts();

			view.PropertyComparers["StringValue"] = new StringLengthComparer();

			Assert.AreEqual(1, factory.ListChangedResetCount);
			Assert.AreEqual(1, factory.SortedCount);

			Assert.AreEqual("a", view[0].StringValue);
			Assert.AreEqual("aa", view[1].StringValue);
			Assert.AreEqual("bbb", view[2].StringValue);
			Assert.AreEqual("aaaa", view[3].StringValue);
		}

		[Test]
		public void UsePropertyComparerUnsorted()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "a", now));
			list.Add(new SimpleClass(1, "bbb", now));
			list.Add(new SimpleClass(1, "aaaa", now));
			list.Add(new SimpleClass(1, "aa", now));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];

			factory.ClearEventCounts();

			view.PropertyComparers["StringValue"] = new StringLengthComparer();

			Assert.AreEqual(0, factory.ListChangedResetCount);
			Assert.AreEqual(0, factory.SortedCount);

			Assert.AreEqual("a", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual("aaaa", view[2].StringValue);
			Assert.AreEqual("aa", view[3].StringValue);
		}

		[Test]
		public void UsePropertyComparerOneColumnInMultiColumnSort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "a", now));
			list.Add(new SimpleClass(1, "bbb", now));
			list.Add(new SimpleClass(1, "aaaa", now));
			list.Add(new SimpleClass(1, "aa", new DateTime(1991, 3, 5)));
			list.Add(new SimpleClass(1, "aa", new DateTime(1989, 7, 22)));

			view.PropertyComparers["StringValue"] = new StringLengthComparer();

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
		        new ListSortDescription(props["StringValue"], ListSortDirection.Descending),
		        new ListSortDescription(props["DateTimeValue"], ListSortDirection.Ascending)
		    });
			view.ApplySort(sorts);

			Assert.AreEqual("aaaa", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual(new DateTime(1989, 7, 22), view[2].DateTimeValue);
			Assert.AreEqual(new DateTime(1991, 3, 5), view[3].DateTimeValue);
			Assert.AreEqual("a", view[4].StringValue);
		}

		[Test]
		public void UsePropertyComparerMultipleColumnsInMultiColumnSort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "a", now));
			list.Add(new SimpleClass(1, "bbb", now));
			list.Add(new SimpleClass(1, "aaaa", now));
			list.Add(new SimpleClass(1, "aa", new DateTime(1989, 7, 22)));
			list.Add(new SimpleClass(1, "aa", new DateTime(1991, 3, 5)));

			view.PropertyComparers["StringValue"] = new StringLengthComparer();
			view.PropertyComparers["DateTimeValue"] = new DateTimeDayComparer();

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			ListSortDescriptionCollection sorts = new ListSortDescriptionCollection(new ListSortDescription[] {
		        new ListSortDescription(props["StringValue"], ListSortDirection.Descending),
		        new ListSortDescription(props["DateTimeValue"], ListSortDirection.Ascending)
		    });
			view.ApplySort(sorts);

			Assert.AreEqual("aaaa", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual(new DateTime(1991, 3, 5), view[2].DateTimeValue);
			Assert.AreEqual(new DateTime(1989, 7, 22), view[3].DateTimeValue);
			Assert.AreEqual("a", view[4].StringValue);
		}

		[Test]
		public void PropertyComparerEventsMultipleSets()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "a", now));
			list.Add(new SimpleClass(1, "bbb", now));
			list.Add(new SimpleClass(1, "aaaa", now));
			list.Add(new SimpleClass(1, "aa", now));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];

			view.ApplySort(stringProp, ListSortDirection.Ascending);

			factory.ClearEventCounts();

			view.PropertyComparers["StringValue"] = new StringLengthComparer();
			view.PropertyComparers["DateTimeValue"] = new DateTimeDayComparer();

			Assert.AreEqual(2, factory.ListChangedResetCount);
			Assert.AreEqual(2, factory.SortedCount);

			Assert.AreEqual("a", view[0].StringValue);
			Assert.AreEqual("aa", view[1].StringValue);
			Assert.AreEqual("bbb", view[2].StringValue);
			Assert.AreEqual("aaaa", view[3].StringValue);
		}

		[Test]
		public void PropertyComparerBeginUpdate()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "a", now));
			list.Add(new SimpleClass(1, "bbb", now));
			list.Add(new SimpleClass(1, "aaaa", now));
			list.Add(new SimpleClass(1, "aa", now));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];

			view.ApplySort(stringProp, ListSortDirection.Ascending);

			factory.ClearEventCounts();

			view.BeginUpdate();
			view.PropertyComparers["StringValue"] = new StringLengthComparer();
			view.PropertyComparers["DateTimeValue"] = new DateTimeDayComparer();
			view.EndUpdate();

			Assert.AreEqual(1, factory.ListChangedResetCount);
			Assert.AreEqual(0, factory.SortedCount);
		}

		[Test]
		public void PropertyComparerEndUpdateWithoutBeginUpdate()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "a", now));
			list.Add(new SimpleClass(1, "bbb", now));
			list.Add(new SimpleClass(1, "aaaa", now));
			list.Add(new SimpleClass(1, "aa", now));

			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			PropertyDescriptor stringProp = props["StringValue"];

			view.ApplySort(stringProp, ListSortDirection.Ascending);

			factory.ClearEventCounts();

			view.PropertyComparers["StringValue"] = new StringLengthComparer();
			view.PropertyComparers["DateTimeValue"] = new DateTimeDayComparer();

			Assert.AreEqual(2, factory.ListChangedResetCount);
			Assert.AreEqual(2, factory.SortedCount);

			view.EndUpdate();

			Assert.AreEqual(2, factory.ListChangedResetCount);
			Assert.AreEqual(2, factory.SortedCount);
		}

		[Test]
		public void FilterPredicateDefault()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			Assert.IsNull(factory.View.FilterPredicate);
		}

		[Test]
		public void FilterPredicateNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.FilterPredicate = null;
			Assert.IsNull(view.FilterPredicate);

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("aaa", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual("ccc", view[2].StringValue);
			Assert.AreEqual("ddd", view[3].StringValue);
			Assert.AreEqual("eee", view[4].StringValue);
		}

		[Test]
		public void FilterPredicateEventRaised()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			factory.ClearEventCounts();

			view.FilterPredicate = delegate(SimpleClass listItem) { return ((SimpleClass)listItem).IntegerValue == 5; };

			Assert.IsNotNull(view.FilterPredicate);
			Assert.AreEqual(1, factory.ListChangedResetCount);
		}

		[Test]
		public void FilterPredicateEqualsInt()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.FilterPredicate = delegate(SimpleClass listItem) { return listItem.IntegerValue == 5; };

			Assert.IsNotNull(view.FilterPredicate);

			Assert.AreEqual(3, view.Count);
			Assert.AreEqual("bbb", view[0].StringValue);
			Assert.AreEqual("ccc", view[1].StringValue);
			Assert.AreEqual("eee", view[2].StringValue);
		}

		[Test]
		public void FilterPredicateVaryingCriteria()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			object criteria = 1;
			view.FilterPredicate = delegate(SimpleClass listItem) { return listItem.IntegerValue < (int)criteria; };
			Assert.AreEqual(0, view.Count);

			for (int i = 2; i < 6; i++)
			{
				criteria = i;
				view.ApplyFilter();
				Assert.AreEqual(i - 1, view.Count);
			}
		}

		[Test]
		public void FilterPredicateVaryingListItemProperties()
		{
			ViewFactory<NotifyingListItem> factory = ViewFactory <NotifyingListItem>.IBindingList();
			ObjectListView<NotifyingListItem> view = factory.View;
			IList<NotifyingListItem> list = factory.List;

			list.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
			list.Add(new NotifyingListItem(2, "bbb", DateTime.Now));

			NotifyingListItem changingItem = new NotifyingListItem(3, "ccc", DateTime.Now);
			list.Add(changingItem);
			list.Add(new NotifyingListItem(4, "ddd", DateTime.Now));
			list.Add(new NotifyingListItem(5, "eee", DateTime.Now));

			view.FilterPredicate = delegate(NotifyingListItem listItem) { return listItem.IntegerValue < 3; };
			Assert.AreEqual(2, view.Count);

			changingItem.IntegerValue = 0;
			Assert.AreEqual(3, view.Count);
		}

		[Test]
		public void FilterPredicateRemoveFilter()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.FilterPredicate = delegate(SimpleClass listItem) { return listItem.IntegerValue == 5; };

			Assert.AreEqual(1, view.Count);

			view.RemoveFilter();

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual(1, view[0].IntegerValue);
			Assert.AreEqual(2, view[1].IntegerValue);
			Assert.AreEqual(3, view[2].IntegerValue);
			Assert.AreEqual(4, view[3].IntegerValue);
			Assert.AreEqual(5, view[4].IntegerValue);
		}

		[Test]
		public void FilterPredicateRemoveSetNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.FilterPredicate = delegate(SimpleClass listItem) { return listItem.IntegerValue == 5; };

			Assert.AreEqual(1, view.Count);

			view.FilterPredicate = null;

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual(1, view[0].IntegerValue);
			Assert.AreEqual(2, view[1].IntegerValue);
			Assert.AreEqual(3, view[2].IntegerValue);
			Assert.AreEqual(4, view[3].IntegerValue);
			Assert.AreEqual(5, view[4].IntegerValue);
		}

		[Test]
		public void FilterPredicateRemoveSetFilterNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.FilterPredicate = delegate(SimpleClass listItem) { return listItem.IntegerValue == 5; };
			Assert.AreEqual(1, view.Count);

			view.Filter = null;
			Assert.AreEqual(5, view.Count);
		}

		[Test]
		public void FilterPredicateSetFilter()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(2, "bbb", DateTime.Now));
			list.Add(new SimpleClass(3, "ccc", DateTime.Now));
			list.Add(new SimpleClass(4, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.FilterPredicate = delegate(SimpleClass listItem) { return listItem.IntegerValue == 5; };
			Assert.AreEqual(1, view.Count);

			view.Filter = "StringValue < 'ccc'";
			Assert.AreEqual(2, view.Count);
		}

		[Test]
		public void FilterRemoveSetPredicateNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.Filter = "IntegerValue = 5";
			Assert.AreEqual(3, view.Count);

			view.FilterPredicate = null;
			Assert.AreEqual(5, view.Count);
		}

		[Test]
		public void FilterSetPredicate()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			view.Filter = "IntegerValue = 5";
			Assert.AreEqual(3, view.Count);

			view.FilterPredicate = delegate(SimpleClass listItem) { return listItem.IntegerValue < 5; };
			Assert.AreEqual(2, view.Count);
		}

		[Test]
		public void ToArray()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			list.Add(new SimpleClass(1, "aaa", DateTime.Now));
			list.Add(new SimpleClass(5, "bbb", DateTime.Now));
			list.Add(new SimpleClass(5, "ccc", DateTime.Now));
			list.Add(new SimpleClass(2, "ddd", DateTime.Now));
			list.Add(new SimpleClass(5, "eee", DateTime.Now));

			SimpleClass[] arr = view.ToArray();
			Assert.IsNotNull(arr);
			Assert.AreEqual(5, arr.Length);

			for (int i = 0; i < view.Count; i++)
				Assert.AreEqual(view[i], arr[i]);
		}

		[Test]
		public void ToArrayEmpty()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			SimpleClass[] arr = view.ToArray();
			Assert.IsNotNull(arr);
			Assert.AreEqual(0, arr.Length);
		}

		[Test]
		public void FindCriteria()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			int index = view.Find("DateTimeValue = 6/6/1975");
			Assert.AreEqual(2, index);
		}

		[Test]
		public void FindCriteriaNullValue()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, null, new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			int index = view.Find("StringValue = null");
			Assert.AreEqual(1, index);
		}

		[Test]
		public void FindCriteriaPath()
		{
			ViewFactory<Order> factory = ViewFactory<Order>.IList();
			ObjectListView<Order> view = factory.View;
			IList<Order> list = factory.List;

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

			int firstIndex = view.Find("Customer.AccountRep.Department = 12 AND Customer.AccountRep.Name = Carol*");

			Assert.AreEqual(2, firstIndex);
		}

		[Test]
		public void FindCriteriaPathInaccessibleValue()
		{
			ViewFactory<Order> factory = ViewFactory<Order>.IList();
			ObjectListView<Order> view = factory.View;
			IList<Order> list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 12);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, carol);
			Customer mike = new Customer("Mike Palooza", acme, john);
			Customer rick = new Customer("Rick Doohan", ajax, null);

			list.Add(new Order(rick, "Glue", 15));
			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));

			int firstIndex = view.Find("Customer.AccountRep.Department = 12 AND Customer.AccountRep.Name = Carol*");

			Assert.AreEqual(3, firstIndex);
		}

		[Test]
		public void FindCriteriaSortedFiltered()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(70, "ddd", new DateTime(1989, 7, 22)));
			view.Filter = "StringValue != 'ccc'";
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);

			int index = view.Find("DateTimeValue = 12/12/1980");
			Assert.AreEqual(1, index);
		}

		[Test]
		public void FindCriteriaNotFound()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			int index = view.Find("DateTimeValue = 6/7/1975");
			Assert.AreEqual(-1, index);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void FindCriteriaNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			view.Find((string)null);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void FindCriteriaEmpty()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			view.Find("");
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void FindCriteriaInvalid()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			view.Find("someprop = 7");
		}

		[Test]
		public void FindPredicate()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			int index = view.Find(delegate(SimpleClass item)
			{
				return item.DateTimeValue == new DateTime(1975, 6, 6);
			});

			Assert.AreEqual(2, index);
		}

		[Test]
		public void FindPrediateNullValue()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, null, new DateTime(1975, 6, 6)));

			int index = view.Find(delegate(SimpleClass item)
			{
				return item.StringValue == null;
			});

			Assert.AreEqual(2, index);
		}

		[Test]
		public void FindPredicateSortedFiltered()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(70, "ddd", new DateTime(1989, 7, 22)));
			view.Filter = "StringValue != 'ccc'";
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);

			int index = view.Find(delegate(SimpleClass item)
			{
				return item.DateTimeValue == new DateTime(1980, 12, 12);
			});

			Assert.AreEqual(1, index);
		}

		[Test]
		public void FindPredicateNotFound()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			int index = view.Find(delegate(SimpleClass item)
			{
				return item.DateTimeValue == new DateTime(1975, 7, 6);
			});

			Assert.AreEqual(-1, index);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void FindPredicateNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

			view.Find((Predicate<SimpleClass>)null);
		}

		[Test]
		public void Select()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			IList<SimpleClass> matches = view.Select("IntegerValue > 60 AND StringValue != 'bbb'");

			Assert.IsNotNull(matches);
			Assert.AreEqual(2, matches.Count);
			Assert.AreEqual(100, matches[0].IntegerValue);
			Assert.AreEqual(65, matches[1].IntegerValue);
		}

		[Test]
		public void SelectNullValue()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, null, new DateTime(1975, 6, 6)));

			IList<SimpleClass> matches = view.Select("StringValue = null");
			Assert.IsNotNull(matches);
			Assert.AreEqual(1, matches.Count);
			Assert.AreEqual(60, matches[0].IntegerValue);
		}

		[Test]
		public void SelectCriteriaPath()
		{
			ViewFactory<Order> factory = ViewFactory<Order>.IList();
			ObjectListView<Order> view = factory.View;
			IList<Order> list = factory.List;

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

			IList<Order> matches = view.Select("Customer.AccountRep.Department = 12 AND Customer.AccountRep.Name = Carol*");

			Assert.IsNotNull(matches);
			Assert.AreEqual(2, matches.Count);
			Assert.AreEqual("Boxes", matches[0].Product);
			Assert.AreEqual("Gadgets", matches[1].Product);
		}

		[Test]
		public void SelectCriteriaPathInaccessibleValue()
		{
			ViewFactory<Order> factory = ViewFactory<Order>.IList();
			ObjectListView<Order> view = factory.View;
			IList<Order> list = factory.List;

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

			IList<Order> matches = view.Select("Customer.AccountRep.Department = 12 AND Customer.AccountRep.Name = Carol*");

			Assert.IsNotNull(matches);
			Assert.AreEqual(2, matches.Count);
			Assert.AreEqual("Boxes", matches[0].Product);
			Assert.AreEqual("Gadgets", matches[1].Product);
		}

		[Test]
		public void SelectNoMatches()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			IList<SimpleClass> matches = view.Select("IntegerValue > 100");

			Assert.IsNotNull(matches);
			Assert.AreEqual(0, matches.Count);
		}

		[Test]
		public void SelectSortedFiltered()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(110, "eee", new DateTime(1975, 6, 6)));

			view.Filter = "StringValue != 'bbb'";
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);

			IList<SimpleClass> matches = view.Select("IntegerValue > 60 AND StringValue != 'aaa'");

			Assert.IsNotNull(matches);
			Assert.AreEqual(2, matches.Count);
			Assert.AreEqual(65, matches[0].IntegerValue);
			Assert.AreEqual(110, matches[1].IntegerValue);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void SelectNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			view.Select((string)null);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void SelectEmpty()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			view.Select("");
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void SelectInvalid()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			view.Select("someProp = 16");
		}

		[Test]
		public void SelectPredicate()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			IList<SimpleClass> matches = view.Select(delegate(SimpleClass item)
			{
				return item.IntegerValue > 60 && item.StringValue != "bbb";
			});

			Assert.IsNotNull(matches);
			Assert.AreEqual(2, matches.Count);
			Assert.AreEqual(100, matches[0].IntegerValue);
			Assert.AreEqual(65, matches[1].IntegerValue);
		}

		[Test]
		public void SelectPredicateNoMatches()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			IList<SimpleClass> matches = view.Select(delegate(SimpleClass item)
			{
				return item.IntegerValue > 100;
			});

			Assert.IsNotNull(matches);
			Assert.AreEqual(0, matches.Count);
		}

		[Test]
		public void SelectPredicateSortedFiltered()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(110, "eee", new DateTime(1975, 6, 6)));

			view.Filter = "StringValue != 'bbb'";
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(SimpleClass));
			view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);

			IList<SimpleClass> matches = view.Select(delegate(SimpleClass item)
			{
				return item.IntegerValue > 60 && item.StringValue != "aaa";
			});

			Assert.IsNotNull(matches);
			Assert.AreEqual(2, matches.Count);
			Assert.AreEqual(65, matches[0].IntegerValue);
			Assert.AreEqual(110, matches[1].IntegerValue);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void SelectPredicateNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
			view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
			view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
			view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

			view.Select((Predicate<SimpleClass>)null);
		}

		[Test]
		public void SortNull()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(3, "ddd", now));

			// Sort should be:
			//  1 eee Now
			//  1 bbb 1950
			//  3 ccc Now
			//  1 aaa Now
			//  3 ddd Now
			view.Sort = null;

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("eee", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual("ccc", view[2].StringValue);
			Assert.AreEqual("aaa", view[3].StringValue);
			Assert.AreEqual("ddd", view[4].StringValue);
		}

		[Test]
		public void SortEmpty()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(3, "ddd", now));

			// Sort should be:
			//  1 eee Now
			//  1 bbb 1950
			//  3 ccc Now
			//  1 aaa Now
			//  3 ddd Now
			view.Sort = "";

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("eee", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual("ccc", view[2].StringValue);
			Assert.AreEqual("aaa", view[3].StringValue);
			Assert.AreEqual("ddd", view[4].StringValue);
		}

		[Test]
		public void SortGetNotSet()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();

			Assert.AreEqual("", factory.View.Sort);
		}

		[Test]
		public void SortGetApplySort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

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

			Assert.AreEqual("IntegerValue ASC, StringValue DESC, DateTimeValue ASC", view.Sort);
		}

		[Test]
		public void SortGetRemoveSort()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

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
			view.RemoveSort();

			Assert.AreEqual("", view.Sort);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void SortInvalidProperty()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();

			factory.View.Sort = "BadProperty";
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void SortInvalidDirection()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();

			factory.View.Sort = "StringValue XYZ";
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void SortInvalidTerm()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();

			factory.View.Sort = "StringValue ASC, DateTimeValue DESC IntegerValue";
		}

		[Test]
		public void SortSinglePropDefaultDirection()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(3, "ddd", now));

			// Sort should be:
			//  1 aaa Now
			//  1 bbb 1950
			//  3 ccc Now
			//  3 ddd Now
			//  1 eee Now
			view.Sort = "StringValue";

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("aaa", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual("ccc", view[2].StringValue);
			Assert.AreEqual("ddd", view[3].StringValue);
			Assert.AreEqual("eee", view[4].StringValue);
		}

		[Test]
		public void SortSinglePropAsc()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(3, "ddd", now));

			// Sort should be:
			//  1 aaa Now
			//  1 bbb 1950
			//  3 ccc Now
			//  3 ddd Now
			//  1 eee Now
			view.Sort = "StringValue ASC";

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("aaa", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual("ccc", view[2].StringValue);
			Assert.AreEqual("ddd", view[3].StringValue);
			Assert.AreEqual("eee", view[4].StringValue);
		}

		[Test]
		public void SortSinglePropDesc()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(3, "ddd", now));

			// Sort should be:
			//  1 eee Now
			//  3 ddd Now
			//  3 ccc Now
			//  1 bbb 1950
			//  1 aaa Now
			view.Sort = "StringValue DESC";

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("eee", view[0].StringValue);
			Assert.AreEqual("ddd", view[1].StringValue);
			Assert.AreEqual("ccc", view[2].StringValue);
			Assert.AreEqual("bbb", view[3].StringValue);
			Assert.AreEqual("aaa", view[4].StringValue);
		}

		[Test]
		public void SortPropertyPath()
		{
			ViewFactory<Order> factory = ViewFactory<Order>.IList();
			ObjectListView<Order> view = factory.View;
			IList<Order> list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 10);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, carol);
			Customer mike = new Customer("Mike Palooza", acme, john);

			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));

			// Sort should be:
			// Bolts
			// Boxes
			// Gadgets
			// Widgets
			// Nails
			view.Sort = "Customer.AccountRep.Department ASC";

			Assert.AreEqual(5, view.Count);
			Assert.AreEqual("Bolts", view[0].Product);
			Assert.AreEqual("Boxes", view[1].Product);
			Assert.AreEqual("Gadgets", view[2].Product);
			Assert.AreEqual("Widgets", view[3].Product);
			Assert.AreEqual("Nails", view[4].Product);
		}

		[Test]
		public void SortPropertyPathInaccessibleValues()
		{
			ViewFactory<Order> factory = ViewFactory<Order>.IList();
			ObjectListView<Order> view = factory.View;
			IList<Order> list = factory.List;

			Company acme = new Company("Acme", "Seattle", "WA");
			Company ajax = new Company("Ajax", "Detroit", "MI");
			AccountRep steve = new AccountRep("Steve O'Donnell", 56);
			AccountRep carol = new AccountRep("Carol Hanson", 12);
			AccountRep john = new AccountRep("John Roche", 10);

			Customer bob = new Customer("Bob Smith", acme, steve);
			Customer tom = new Customer("Tom Kelly", ajax, null);
			Customer mike = new Customer("Mike Palooza", acme, carol);
			Customer rick = new Customer("Rick Doohan", ajax, john);

			list.Add(new Order(bob, "Widgets", 10));
			list.Add(new Order(bob, "Nails", 200));
			list.Add(new Order(tom, "Boxes", 20));
			list.Add(new Order(tom, "Gadgets", 7));
			list.Add(new Order(mike, "Bolts", 3000));
			list.Add(new Order(rick, "Glue", 15));

			// Sort should be:
			// (note that the items that compare equally will be sorted in reverse of list order because the sort direction is descending)
			// Nails
			// Widgets
			// Bolts
			// Glue
			// Gadgets
			// Boxes
			view.Sort = "Customer.AccountRep.Department DESC";

			Assert.AreEqual(6, view.Count);
			Assert.AreEqual("Nails", view[0].Product);
			Assert.AreEqual("Widgets", view[1].Product);
			Assert.AreEqual("Bolts", view[2].Product);
			Assert.AreEqual("Glue", view[3].Product);
			Assert.AreEqual("Gadgets", view[4].Product);
			Assert.AreEqual("Boxes", view[5].Product);
		}

		[Test]
		public void SortMultipleProps()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(3, "ddd", now));
			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			// Sort should be:
			//  1 eee Now
			//  1 bbb 1950
			//  1 bbb 1960
			//  1 aaa Now
			//  3 ddd Now
			//  3 ccc Now
			view.Sort = "IntegerValue ASC, StringValue DESC, DateTimeValue ASC";

			Assert.AreEqual(6, view.Count);
			Assert.AreEqual("eee", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), view[1].DateTimeValue);
			Assert.AreEqual("bbb", view[2].StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), view[2].DateTimeValue);
			Assert.AreEqual("aaa", view[3].StringValue);
			Assert.AreEqual("ddd", view[4].StringValue);
			Assert.AreEqual("ccc", view[5].StringValue);
		}

		[Test]
		public void SortMultiplePropsDefaultDirection()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			DateTime now = DateTime.Now;

			list.Add(new SimpleClass(1, "aaa", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
			list.Add(new SimpleClass(3, "ccc", now));
			list.Add(new SimpleClass(3, "ddd", now));
			list.Add(new SimpleClass(1, "eee", now));
			list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

			// Sort should be:
			//  1 eee Now
			//  1 bbb 1950
			//  1 bbb 1960
			//  1 aaa Now
			//  3 ddd Now
			//  3 ccc Now
			view.Sort = "IntegerValue ASC, StringValue DESC, DateTimeValue";

			Assert.AreEqual(6, view.Count);
			Assert.AreEqual("eee", view[0].StringValue);
			Assert.AreEqual("bbb", view[1].StringValue);
			Assert.AreEqual(new DateTime(1950, 1, 1), view[1].DateTimeValue);
			Assert.AreEqual("bbb", view[2].StringValue);
			Assert.AreEqual(new DateTime(1960, 1, 1), view[2].DateTimeValue);
			Assert.AreEqual("aaa", view[3].StringValue);
			Assert.AreEqual("ddd", view[4].StringValue);
			Assert.AreEqual("ccc", view[5].StringValue);
		}

		[Test]
		public void BeforeAfterListChanged()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			int callbackOrder = 0;
			ListChangedEventArgs args = null;
			view.BeforeListChanged += delegate(object sender, ListChangedEventArgs e)
			{
				callbackOrder++;
				Assert.AreEqual(1, callbackOrder);
				Assert.IsNull(args);
				args = e;
			};
			view.ListChanged += delegate(object sender, ListChangedEventArgs e)
			{
				callbackOrder++;
				Assert.AreEqual(2, callbackOrder);
				Assert.AreEqual(args, e);
			};
			view.AfterListChanged += delegate(object sender, ListChangedEventArgs e)
			{
				callbackOrder++;
				Assert.AreEqual(3, callbackOrder);
				Assert.AreEqual(args, e);
			};

			list.Add(new SimpleClass());

			Assert.AreEqual(3, callbackOrder);
		}

		[Test]
		public void BeforeAfterListChangedInUpdate()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;
			IList<SimpleClass> list = factory.List;

			int callbackOrder = 0;
			ListChangedEventArgs args = null;
			view.BeforeListChanged += delegate(object sender, ListChangedEventArgs e)
			{
				callbackOrder++;
				Assert.AreEqual(1, callbackOrder);
				Assert.IsNull(args);
				args = e;
			};
			view.ListChanged += delegate(object sender, ListChangedEventArgs e)
			{
				callbackOrder++;
				Assert.AreEqual(2, callbackOrder);
				Assert.AreEqual(args, e);
			};
			view.AfterListChanged += delegate(object sender, ListChangedEventArgs e)
			{
				callbackOrder++;
				Assert.AreEqual(3, callbackOrder);
				Assert.AreEqual(args, e);
			};

			view.BeginUpdate();
			list.Add(new SimpleClass());

			Assert.AreEqual(0, callbackOrder);
			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.BeforeListChangedCount);
			Assert.AreEqual(0, factory.AfterListChangedCount);

			view.EndUpdate();

			Assert.AreEqual(3, callbackOrder);
			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(1, factory.ListChangedResetCount);
			Assert.AreEqual(1, factory.BeforeListChangedCount);
			Assert.AreEqual(1, factory.AfterListChangedCount);
		}
	}
}
#endif
