#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using NUnit.Framework;

namespace JesseJohnston.Tests
{
  [TestFixture]
  public class ObjectListViewTests
  {
    [Test]
    public void ConstructEmptyList()
    {
      var view = new ObjectListView(new ArrayList());
      Assert.IsNull(view.ItemType);
      Assert.AreEqual(0, view.Count);
    }

    [Test]
    public void ConstructEmptyGenericList()
    {
      var view = new ObjectListView(new List<SimpleClass>());
      Assert.AreEqual(typeof (SimpleClass), view.ItemType);
      Assert.AreEqual(0, view.Count);
    }

    [Test]
    public void BeginUpdate()
    {
      var factory = ViewFactory.IBindingListINotifyPropertyChangedItems();
      var view = factory.View;
      var list = factory.List;

      view.BeginUpdate();

      var item = new NotifyingListItem();

      view.Add(item); // normally would raise ListChanged (ItemAdded)
      item.IntegerValue = 9; // normally would raise ListChanged (ItemChanged, reflecting PropertyChanged)

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
      var factory = ViewFactory.IBindingListINotifyPropertyChangedItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new NotifyingListItem(1, "aaa", DateTime.Now));

      view.Filter = "IntegerValue < 5";
      view.ApplySort(TypeDescriptor.GetProperties(typeof (NotifyingListItem))["StringValue"], ListSortDirection.Descending);

      factory.ClearEventCounts();

      view.BeginUpdate();

      list.Add(new NotifyingListItem(5, "bbb", DateTime.Now));
      list.Add(new NotifyingListItem(5, "ccc", DateTime.Now));
      list.Add(new NotifyingListItem(2, "ddd", DateTime.Now));
      list.Add(new NotifyingListItem(5, "eee", DateTime.Now));

      ((NotifyingListItem) list[1]).IntegerValue = 4;
      list.RemoveAt(3);

      view.EndUpdate();

      Assert.AreEqual(2, view.Count);
      Assert.AreEqual("bbb", ((NotifyingListItem) view[0]).StringValue);
      Assert.AreEqual("aaa", ((NotifyingListItem) view[1]).StringValue);

      Assert.AreEqual(0, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedItemChangedCount);
      Assert.AreEqual(0, factory.ListChangedDeletedCount);
      Assert.AreEqual(1, factory.ListChangedResetCount);
    }

    [Test]
    public void EndUpdateWithoutBeginUpdate()
    {
      var factory = ViewFactory.IBindingListINotifyPropertyChangedItems();
      var view = factory.View;
      var list = factory.List;

      var item = new NotifyingListItem();

      view.Add(item); // normally would raise ListChanged (ItemAdded)
      item.IntegerValue = 9; // normally would raise ListChanged (ItemChanged, reflecting PropertyChanged)

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
      var factory = ViewFactory.IBindingListINotifyPropertyChangedItems();
      var view = factory.View;

      var item = new NotifyingListItem();

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
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var now = DateTime.Now;

      list.Add(new SimpleClass(1, "aaa", now));
      list.Add(new SimpleClass(1, "bbb", new DateTime(1950, 1, 1)));
      list.Add(new SimpleClass(3, "ccc", now));
      list.Add(new SimpleClass(3, "ddd", now));
      list.Add(new SimpleClass(1, "eee", now));
      list.Add(new SimpleClass(1, "bbb", new DateTime(1960, 1, 1)));

      view.ItemType = typeof (SimpleClass);

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var intProp = props["IntegerValue"];

      var sorts = new ListSortDescriptionCollection(new[]
                                                      {
                                                        new ListSortDescription(intProp, ListSortDirection.Ascending)
                                                      });

      Assert.AreEqual(0, factory.SortedCount);

      view.ApplySort(sorts);

      Assert.AreEqual(1, factory.SortedCount);
    }

    [Test]
    public void RemoveSorted()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var now = DateTime.Now;

      list.Add(new SimpleClass(5, "aaa", now));
      list.Add(new SimpleClass(4, "bbb", new DateTime(1950, 1, 1)));
      list.Add(new SimpleClass(3, "ccc", now));
      list.Add(new SimpleClass(3, "ddd", now));
      list.Add(new SimpleClass(1, "eee", now));
      list.Add(new SimpleClass(2, "bbb", new DateTime(1960, 1, 1)));

      view.ItemType = typeof (SimpleClass);

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var intProp = props["IntegerValue"];

      var sorts = new ListSortDescriptionCollection(new[]
                                                      {
                                                        new ListSortDescription(intProp, ListSortDirection.Ascending)
                                                      });

      view.ApplySort(sorts);
      factory.ClearEventCounts();

      view.RemoveAt(3);
      view.RemoveAt(2);

      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, ((SimpleClass) view[0]).IntegerValue);
      Assert.AreEqual(2, ((SimpleClass) view[1]).IntegerValue);
      Assert.AreEqual(4, ((SimpleClass) view[2]).IntegerValue);
      Assert.AreEqual(5, ((SimpleClass) view[3]).IntegerValue);

      Assert.AreEqual(2, factory.ListChangedDeletedCount);
      Assert.AreEqual(0, factory.ListChangedResetCount);
      Assert.AreEqual(0, factory.SortedCount);
    }

    [Test]
    public void RemoveSortedIBindingList()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var now = DateTime.Now;

      list.Add(new SimpleClass(5, "aaa", now));
      list.Add(new SimpleClass(4, "bbb", new DateTime(1950, 1, 1)));
      list.Add(new SimpleClass(3, "ccc", now));
      list.Add(new SimpleClass(3, "ddd", now));
      list.Add(new SimpleClass(1, "eee", now));
      list.Add(new SimpleClass(2, "bbb", new DateTime(1960, 1, 1)));

      view.ItemType = typeof (SimpleClass);

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var intProp = props["IntegerValue"];

      var sorts = new ListSortDescriptionCollection(new[]
                                                      {
                                                        new ListSortDescription(intProp, ListSortDirection.Ascending)
                                                      });

      view.ApplySort(sorts);
      factory.ClearEventCounts();

      view.RemoveAt(3);
      view.RemoveAt(2);

      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, ((SimpleClass) view[0]).IntegerValue);
      Assert.AreEqual(2, ((SimpleClass) view[1]).IntegerValue);
      Assert.AreEqual(4, ((SimpleClass) view[2]).IntegerValue);
      Assert.AreEqual(5, ((SimpleClass) view[3]).IntegerValue);

      Assert.AreEqual(2, factory.ListChangedDeletedCount);
      Assert.AreEqual(0, factory.ListChangedResetCount);
      Assert.AreEqual(0, factory.SortedCount);
    }

    [Test]
    public void PropertyComparerDefault()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      Assert.IsNotNull(view.PropertyComparers);
      Assert.AreEqual(0, view.PropertyComparers.Count);
    }

    [Test]
    [ExpectedException(typeof (InvalidOperationException))]
    public void PropertyComparerNoItemType()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      var c = view.PropertyComparers;
    }

    [Test]
    [ExpectedException(typeof (ArgumentNullException))]
    public void PropertyComparerNullProperty()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      view.PropertyComparers[null] = new StringLengthComparer();
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void PropertyComparerEmptyProperty()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      view.PropertyComparers[""] = new StringLengthComparer();
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void PropertyComparerInvalidProperty()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      view.PropertyComparers["NonexistentProperty"] = new StringLengthComparer();
    }

    [Test]
    public void PropertyComparerAdd()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      view.PropertyComparers.Add("StringProperty", new StringLengthComparer());
      Assert.AreEqual(1, view.PropertyComparers.Count);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void PropertyComparerAddDuplicate()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      view.PropertyComparers.Add("StringProperty", new StringLengthComparer());
      view.PropertyComparers.Add("StringProperty", new StringLengthComparer());
    }

    [Test]
    public void PropertyComparerSet()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      view.PropertyComparers["StringValue"] = new StringLengthComparer();
      Assert.AreEqual(1, view.PropertyComparers.Count);
    }

    [Test]
    public void PropertyComparerSetTwice()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      view.PropertyComparers["StringValue"] = new StringLengthComparer();
      view.PropertyComparers["StringValue"] = new StringLengthComparer();
      Assert.AreEqual(1, view.PropertyComparers.Count);
    }

    [Test]
    public void PropertyComparerSetNull()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      view.PropertyComparers["StringValue"] = null;
      Assert.AreEqual(0, view.PropertyComparers.Count);
    }

    [Test]
    public void PropertyComparerSetNullAfterSet()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      view.PropertyComparers["StringValue"] = new StringLengthComparer();
      view.PropertyComparers["StringValue"] = null;
      Assert.AreEqual(0, view.PropertyComparers.Count);
    }

    [Test]
    public void PropertyComparerGet()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      var s = new StringLengthComparer();
      view.PropertyComparers["StringValue"] = s;
      Assert.AreEqual(s, view.PropertyComparers["StringValue"]);
    }

    [Test]
    public void PropertyComparerGetNotSet()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      Assert.IsNull(view.PropertyComparers["StringValue"]);
    }

    [Test]
    public void PropertyComparerGetSetNull()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      view.PropertyComparers["StringValue"] = null;
      Assert.IsNull(view.PropertyComparers["StringValue"]);
    }

    [Test]
    public void PropertyComparerRemove()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      view.PropertyComparers.Add("StringProperty", new StringLengthComparer());
      view.PropertyComparers.Remove("StringProperty");
      Assert.AreEqual(0, view.PropertyComparers.Count);
    }

    [Test]
    public void PropertyComparerRemoveNoAdd()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;

      view.PropertyComparers.Remove("StringProperty");
      Assert.AreEqual(0, view.PropertyComparers.Count);
    }

    [Test]
    public void UsePropertyComparer()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var now = DateTime.Now;

      list.Add(new SimpleClass(1, "a", now));
      list.Add(new SimpleClass(1, "bbb", now));
      list.Add(new SimpleClass(1, "aaaa", now));
      list.Add(new SimpleClass(1, "aa", now));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var stringProp = props["StringValue"];

      factory.ClearEventCounts();

      view.PropertyComparers["StringValue"] = new StringLengthComparer();
      view.ApplySort(stringProp, ListSortDirection.Ascending);

      Assert.AreEqual(1, factory.ListChangedResetCount);
      Assert.AreEqual(1, factory.SortedCount);

      Assert.AreEqual("a", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("aa", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("aaaa", ((SimpleClass) view[3]).StringValue);
    }

    [Test]
    public void UsePropertyComparerAfterSort()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var now = DateTime.Now;

      list.Add(new SimpleClass(1, "a", now));
      list.Add(new SimpleClass(1, "bbb", now));
      list.Add(new SimpleClass(1, "aaaa", now));
      list.Add(new SimpleClass(1, "aa", now));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var stringProp = props["StringValue"];

      view.ApplySort(stringProp, ListSortDirection.Ascending);

      Assert.AreEqual("a", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("aa", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("aaaa", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[3]).StringValue);

      factory.ClearEventCounts();

      view.PropertyComparers["StringValue"] = new StringLengthComparer();

      Assert.AreEqual(1, factory.ListChangedResetCount);
      Assert.AreEqual(1, factory.SortedCount);

      Assert.AreEqual("a", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("aa", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("aaaa", ((SimpleClass) view[3]).StringValue);
    }

    [Test]
    public void UsePropertyComparerUnsorted()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var now = DateTime.Now;

      list.Add(new SimpleClass(1, "a", now));
      list.Add(new SimpleClass(1, "bbb", now));
      list.Add(new SimpleClass(1, "aaaa", now));
      list.Add(new SimpleClass(1, "aa", now));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var stringProp = props["StringValue"];

      factory.ClearEventCounts();

      view.PropertyComparers["StringValue"] = new StringLengthComparer();

      Assert.AreEqual(0, factory.ListChangedResetCount);
      Assert.AreEqual(0, factory.SortedCount);

      Assert.AreEqual("a", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("aaaa", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("aa", ((SimpleClass) view[3]).StringValue);
    }

    [Test]
    public void UsePropertyComparerOneColumnInMultiColumnSort()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var now = DateTime.Now;

      list.Add(new SimpleClass(1, "a", now));
      list.Add(new SimpleClass(1, "bbb", now));
      list.Add(new SimpleClass(1, "aaaa", now));
      list.Add(new SimpleClass(1, "aa", new DateTime(1991, 3, 5)));
      list.Add(new SimpleClass(1, "aa", new DateTime(1989, 7, 22)));

      view.PropertyComparers["StringValue"] = new StringLengthComparer();

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var sorts = new ListSortDescriptionCollection(new[]
                                                      {
                                                        new ListSortDescription(props["StringValue"], ListSortDirection.Descending),
                                                        new ListSortDescription(props["DateTimeValue"], ListSortDirection.Ascending)
                                                      });
      view.ApplySort(sorts);

      Assert.AreEqual("aaaa", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual(new DateTime(1989, 7, 22), ((SimpleClass) view[2]).DateTimeValue);
      Assert.AreEqual(new DateTime(1991, 3, 5), ((SimpleClass) view[3]).DateTimeValue);
      Assert.AreEqual("a", ((SimpleClass) view[4]).StringValue);
    }

    [Test]
    public void UsePropertyComparerMultipleColumnsInMultiColumnSort()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var now = DateTime.Now;

      list.Add(new SimpleClass(1, "a", now));
      list.Add(new SimpleClass(1, "bbb", now));
      list.Add(new SimpleClass(1, "aaaa", now));
      list.Add(new SimpleClass(1, "aa", new DateTime(1989, 7, 22)));
      list.Add(new SimpleClass(1, "aa", new DateTime(1991, 3, 5)));

      view.PropertyComparers["StringValue"] = new StringLengthComparer();
      view.PropertyComparers["DateTimeValue"] = new DateTimeDayComparer();

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var sorts = new ListSortDescriptionCollection(new[]
                                                      {
                                                        new ListSortDescription(props["StringValue"], ListSortDirection.Descending),
                                                        new ListSortDescription(props["DateTimeValue"], ListSortDirection.Ascending)
                                                      });
      view.ApplySort(sorts);

      Assert.AreEqual("aaaa", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual(new DateTime(1991, 3, 5), ((SimpleClass) view[2]).DateTimeValue);
      Assert.AreEqual(new DateTime(1989, 7, 22), ((SimpleClass) view[3]).DateTimeValue);
      Assert.AreEqual("a", ((SimpleClass) view[4]).StringValue);
    }

    [Test]
    public void PropertyComparerEventsMultipleSets()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var now = DateTime.Now;

      list.Add(new SimpleClass(1, "a", now));
      list.Add(new SimpleClass(1, "bbb", now));
      list.Add(new SimpleClass(1, "aaaa", now));
      list.Add(new SimpleClass(1, "aa", now));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var stringProp = props["StringValue"];

      view.ApplySort(stringProp, ListSortDirection.Ascending);

      factory.ClearEventCounts();

      view.PropertyComparers["StringValue"] = new StringLengthComparer();
      view.PropertyComparers["DateTimeValue"] = new DateTimeDayComparer();

      Assert.AreEqual(2, factory.ListChangedResetCount);
      Assert.AreEqual(2, factory.SortedCount);

      Assert.AreEqual("a", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("aa", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("aaaa", ((SimpleClass) view[3]).StringValue);
    }

    [Test]
    public void PropertyComparerBeginUpdate()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var now = DateTime.Now;

      list.Add(new SimpleClass(1, "a", now));
      list.Add(new SimpleClass(1, "bbb", now));
      list.Add(new SimpleClass(1, "aaaa", now));
      list.Add(new SimpleClass(1, "aa", now));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var stringProp = props["StringValue"];

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
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var now = DateTime.Now;

      list.Add(new SimpleClass(1, "a", now));
      list.Add(new SimpleClass(1, "bbb", now));
      list.Add(new SimpleClass(1, "aaaa", now));
      list.Add(new SimpleClass(1, "aa", now));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var stringProp = props["StringValue"];

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
      var factory = ViewFactory.IListSimpleItems();
      Assert.IsNull(factory.View.FilterPredicate);
    }

    [Test]
    public void FilterPredicateNull()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now));
      list.Add(new SimpleClass(5, "bbb", DateTime.Now));
      list.Add(new SimpleClass(5, "ccc", DateTime.Now));
      list.Add(new SimpleClass(2, "ddd", DateTime.Now));
      list.Add(new SimpleClass(5, "eee", DateTime.Now));

      view.ItemType = typeof (SimpleClass);

      view.FilterPredicate = null;
      Assert.IsNull(view.FilterPredicate);

      Assert.AreEqual(5, view.Count);
      Assert.AreEqual("aaa", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("ddd", ((SimpleClass) view[3]).StringValue);
      Assert.AreEqual("eee", ((SimpleClass) view[4]).StringValue);
    }

    [Test]
    public void FilterPredicateEventRaised()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now));
      list.Add(new SimpleClass(5, "bbb", DateTime.Now));
      list.Add(new SimpleClass(5, "ccc", DateTime.Now));
      list.Add(new SimpleClass(2, "ddd", DateTime.Now));
      list.Add(new SimpleClass(5, "eee", DateTime.Now));

      view.ItemType = typeof (SimpleClass);

      factory.ClearEventCounts();

      view.FilterPredicate = delegate(object listItem) { return ((SimpleClass) listItem).IntegerValue == 5; };

      Assert.IsNotNull(view.FilterPredicate);
      Assert.AreEqual(1, factory.ListChangedResetCount);
    }

    [Test]
    public void FilterPredicateEqualsInt()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now));
      list.Add(new SimpleClass(5, "bbb", DateTime.Now));
      list.Add(new SimpleClass(5, "ccc", DateTime.Now));
      list.Add(new SimpleClass(2, "ddd", DateTime.Now));
      list.Add(new SimpleClass(5, "eee", DateTime.Now));

      view.ItemType = typeof (SimpleClass);

      view.FilterPredicate = delegate(object listItem) { return ((SimpleClass) listItem).IntegerValue == 5; };

      Assert.IsNotNull(view.FilterPredicate);

      Assert.AreEqual(3, view.Count);
      Assert.AreEqual("bbb", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("eee", ((SimpleClass) view[2]).StringValue);
    }

    [Test]
    public void FilterPredicateVaryingCriteria()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now));
      list.Add(new SimpleClass(2, "bbb", DateTime.Now));
      list.Add(new SimpleClass(3, "ccc", DateTime.Now));
      list.Add(new SimpleClass(4, "ddd", DateTime.Now));
      list.Add(new SimpleClass(5, "eee", DateTime.Now));

      view.ItemType = typeof (SimpleClass);

      object criteria = 1;
      view.FilterPredicate = delegate(object listItem) { return ((SimpleClass) listItem).IntegerValue < (int) criteria; };
      Assert.AreEqual(0, view.Count);

      for (var i = 2; i < 6; i++)
      {
        criteria = i;
        view.ApplyFilter();
        Assert.AreEqual(i - 1, view.Count);
      }
    }

    [Test]
    public void FilterPredicateVaryingListItemProperties()
    {
      var factory = ViewFactory.IBindingListINotifyPropertyChangedItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
      list.Add(new NotifyingListItem(2, "bbb", DateTime.Now));

      var changingItem = new NotifyingListItem(3, "ccc", DateTime.Now);
      list.Add(changingItem);
      list.Add(new NotifyingListItem(4, "ddd", DateTime.Now));
      list.Add(new NotifyingListItem(5, "eee", DateTime.Now));

      view.ItemType = typeof (NotifyingListItem);

      view.FilterPredicate = delegate(object listItem) { return ((NotifyingListItem) listItem).IntegerValue < 3; };
      Assert.AreEqual(2, view.Count);

      changingItem.IntegerValue = 0;
      Assert.AreEqual(3, view.Count);
    }

    [Test]
    public void FilterPredicateRemoveFilter()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now));
      list.Add(new SimpleClass(2, "bbb", DateTime.Now));
      list.Add(new SimpleClass(3, "ccc", DateTime.Now));
      list.Add(new SimpleClass(4, "ddd", DateTime.Now));
      list.Add(new SimpleClass(5, "eee", DateTime.Now));

      view.ItemType = typeof (SimpleClass);

      view.FilterPredicate = delegate(object listItem) { return ((SimpleClass) listItem).IntegerValue == 5; };

      Assert.AreEqual(1, view.Count);

      view.RemoveFilter();

      Assert.AreEqual(5, view.Count);
      Assert.AreEqual(1, ((SimpleClass) view[0]).IntegerValue);
      Assert.AreEqual(2, ((SimpleClass) view[1]).IntegerValue);
      Assert.AreEqual(3, ((SimpleClass) view[2]).IntegerValue);
      Assert.AreEqual(4, ((SimpleClass) view[3]).IntegerValue);
      Assert.AreEqual(5, ((SimpleClass) view[4]).IntegerValue);
    }

    [Test]
    public void FilterPredicateRemoveSetNull()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now));
      list.Add(new SimpleClass(2, "bbb", DateTime.Now));
      list.Add(new SimpleClass(3, "ccc", DateTime.Now));
      list.Add(new SimpleClass(4, "ddd", DateTime.Now));
      list.Add(new SimpleClass(5, "eee", DateTime.Now));

      view.ItemType = typeof (SimpleClass);

      view.FilterPredicate = delegate(object listItem) { return ((SimpleClass) listItem).IntegerValue == 5; };

      Assert.AreEqual(1, view.Count);

      view.FilterPredicate = null;

      Assert.AreEqual(5, view.Count);
      Assert.AreEqual(1, ((SimpleClass) view[0]).IntegerValue);
      Assert.AreEqual(2, ((SimpleClass) view[1]).IntegerValue);
      Assert.AreEqual(3, ((SimpleClass) view[2]).IntegerValue);
      Assert.AreEqual(4, ((SimpleClass) view[3]).IntegerValue);
      Assert.AreEqual(5, ((SimpleClass) view[4]).IntegerValue);
    }

    [Test]
    public void FilterPredicateRemoveSetFilterNull()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now));
      list.Add(new SimpleClass(2, "bbb", DateTime.Now));
      list.Add(new SimpleClass(3, "ccc", DateTime.Now));
      list.Add(new SimpleClass(4, "ddd", DateTime.Now));
      list.Add(new SimpleClass(5, "eee", DateTime.Now));

      view.ItemType = typeof (SimpleClass);

      view.FilterPredicate = delegate(object listItem) { return ((SimpleClass) listItem).IntegerValue == 5; };
      Assert.AreEqual(1, view.Count);

      view.Filter = null;
      Assert.AreEqual(5, view.Count);
    }

    [Test]
    public void FilterPredicateSetFilter()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now));
      list.Add(new SimpleClass(2, "bbb", DateTime.Now));
      list.Add(new SimpleClass(3, "ccc", DateTime.Now));
      list.Add(new SimpleClass(4, "ddd", DateTime.Now));
      list.Add(new SimpleClass(5, "eee", DateTime.Now));

      view.ItemType = typeof (SimpleClass);

      view.FilterPredicate = delegate(object listItem) { return ((SimpleClass) listItem).IntegerValue == 5; };
      Assert.AreEqual(1, view.Count);

      view.Filter = "StringValue < 'ccc'";
      Assert.AreEqual(2, view.Count);
    }

    [Test]
    public void FilterRemoveSetPredicateNull()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now));
      list.Add(new SimpleClass(5, "bbb", DateTime.Now));
      list.Add(new SimpleClass(5, "ccc", DateTime.Now));
      list.Add(new SimpleClass(2, "ddd", DateTime.Now));
      list.Add(new SimpleClass(5, "eee", DateTime.Now));

      view.ItemType = typeof (SimpleClass);

      view.Filter = "IntegerValue = 5";
      Assert.AreEqual(3, view.Count);

      view.FilterPredicate = null;
      Assert.AreEqual(5, view.Count);
    }

    [Test]
    public void FilterSetPredicate()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now));
      list.Add(new SimpleClass(5, "bbb", DateTime.Now));
      list.Add(new SimpleClass(5, "ccc", DateTime.Now));
      list.Add(new SimpleClass(2, "ddd", DateTime.Now));
      list.Add(new SimpleClass(5, "eee", DateTime.Now));

      view.ItemType = typeof (SimpleClass);

      view.Filter = "IntegerValue = 5";
      Assert.AreEqual(3, view.Count);

      view.FilterPredicate = delegate(object listItem) { return ((SimpleClass) listItem).IntegerValue < 5; };
      Assert.AreEqual(2, view.Count);
    }

    [Test]
    public void ToArray()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now));
      list.Add(new SimpleClass(5, "bbb", DateTime.Now));
      list.Add(new SimpleClass(5, "ccc", DateTime.Now));
      list.Add(new SimpleClass(2, "ddd", DateTime.Now));
      list.Add(new SimpleClass(5, "eee", DateTime.Now));

      view.ItemType = typeof (SimpleClass);

      var arr = view.ToArray();
      Assert.IsNotNull(arr);
      Assert.AreEqual(5, arr.Length);

      for (var i = 0; i < view.Count; i++)
        Assert.AreEqual(view[i], arr.GetValue(i));
    }

    [Test]
    public void ToArrayEmpty()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.ItemType = typeof (SimpleClass);

      var arr = view.ToArray();
      Assert.IsNotNull(arr);
      Assert.AreEqual(0, arr.Length);
    }

    [Test]
    public void FindCriteria()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      var index = view.Find("DateTimeValue = 6/6/1975");
      Assert.AreEqual(2, index);
    }

    [Test]
    public void FindCriteriaNullValue()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, null, new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      var index = view.Find("StringValue = null");
      Assert.AreEqual(1, index);
    }

    [Test]
    public void FindCriteriaPath()
    {
      var factory = ViewFactory.IListOrders();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (Order);

      var acme = new Company("Acme", "Seattle", "WA");
      var ajax = new Company("Ajax", "Detroit", "MI");
      var steve = new AccountRep("Steve O'Donnell", 56);
      var carol = new AccountRep("Carol Hanson", 12);
      var john = new AccountRep("John Roche", 12);

      var bob = new Customer("Bob Smith", acme, steve);
      var tom = new Customer("Tom Kelly", ajax, carol);
      var mike = new Customer("Mike Palooza", acme, john);

      list.Add(new Order(bob, "Widgets", 10));
      list.Add(new Order(bob, "Nails", 200));
      list.Add(new Order(tom, "Boxes", 20));
      list.Add(new Order(tom, "Gadgets", 7));
      list.Add(new Order(mike, "Bolts", 3000));

      var firstIndex = view.Find("Customer.AccountRep.Department = 12 AND Customer.AccountRep.Name = Carol*");

      Assert.AreEqual(2, firstIndex);
    }

    [Test]
    public void FindCriteriaPathInaccessibleValue()
    {
      var factory = ViewFactory.IListOrders();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (Order);

      var acme = new Company("Acme", "Seattle", "WA");
      var ajax = new Company("Ajax", "Detroit", "MI");
      var steve = new AccountRep("Steve O'Donnell", 56);
      var carol = new AccountRep("Carol Hanson", 12);
      var john = new AccountRep("John Roche", 12);

      var bob = new Customer("Bob Smith", acme, steve);
      var tom = new Customer("Tom Kelly", ajax, carol);
      var mike = new Customer("Mike Palooza", acme, john);
      var rick = new Customer("Rick Doohan", ajax, null);

      list.Add(new Order(rick, "Glue", 15));
      list.Add(new Order(bob, "Widgets", 10));
      list.Add(new Order(bob, "Nails", 200));
      list.Add(new Order(tom, "Boxes", 20));
      list.Add(new Order(tom, "Gadgets", 7));
      list.Add(new Order(mike, "Bolts", 3000));

      var firstIndex = view.Find("Customer.AccountRep.Department = 12 AND Customer.AccountRep.Name = Carol*");

      Assert.AreEqual(3, firstIndex);
    }

    [Test]
    public void FindCriteriaSortedFiltered()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(70, "ddd", new DateTime(1989, 7, 22)));
      view.Filter = "StringValue != 'ccc'";
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);

      var index = view.Find("DateTimeValue = 12/12/1980");
      Assert.AreEqual(1, index);
    }

    [Test]
    public void FindCriteriaNotFound()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      var index = view.Find("DateTimeValue = 6/7/1975");
      Assert.AreEqual(-1, index);
    }

    [Test]
    [ExpectedException(typeof (ArgumentNullException))]
    public void FindCriteriaNull()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      view.Find((string) null);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void FindCriteriaEmpty()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      view.Find("");
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void FindCriteriaInvalid()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      view.Find("someprop = 7");
    }

    [Test]
    public void FindPredicate()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      var index = view.Find(delegate(object item) { return ((SimpleClass) item).DateTimeValue == new DateTime(1975, 6, 6); });

      Assert.AreEqual(2, index);
    }

    [Test]
    public void FindPrediateNullValue()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, null, new DateTime(1975, 6, 6)));

      var index = view.Find(delegate(object item) { return ((SimpleClass) item).StringValue == null; });

      Assert.AreEqual(2, index);
    }

    [Test]
    public void FindPredicateSortedFiltered()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(70, "ddd", new DateTime(1989, 7, 22)));
      view.Filter = "StringValue != 'ccc'";
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);

      var index = view.Find(delegate(object item) { return ((SimpleClass) item).DateTimeValue == new DateTime(1980, 12, 12); });

      Assert.AreEqual(1, index);
    }

    [Test]
    public void FindPredicateNotFound()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      var index = view.Find(delegate(object item) { return ((SimpleClass) item).DateTimeValue == new DateTime(1975, 7, 6); });

      Assert.AreEqual(-1, index);
    }

    [Test]
    [ExpectedException(typeof (ArgumentNullException))]
    public void FindPredicateNull()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      view.Find((Predicate) null);
    }

    [Test]
    public void Select()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      var matches = view.Select("IntegerValue > 60 AND StringValue != 'bbb'");

      Assert.IsNotNull(matches);
      Assert.AreEqual(2, matches.Count);
      Assert.AreEqual(100, ((SimpleClass) matches[0]).IntegerValue);
      Assert.AreEqual(65, ((SimpleClass) matches[1]).IntegerValue);
    }

    [Test]
    public void SelectNullValue()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, null, new DateTime(1975, 6, 6)));

      var matches = view.Select("StringValue = null");
      Assert.IsNotNull(matches);
      Assert.AreEqual(1, matches.Count);
      Assert.AreEqual(60, ((SimpleClass) matches[0]).IntegerValue);
    }

    [Test]
    public void SelectCriteriaPath()
    {
      var factory = ViewFactory.IListOrders();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (Order);

      var acme = new Company("Acme", "Seattle", "WA");
      var ajax = new Company("Ajax", "Detroit", "MI");
      var steve = new AccountRep("Steve O'Donnell", 56);
      var carol = new AccountRep("Carol Hanson", 12);
      var john = new AccountRep("John Roche", 12);

      var bob = new Customer("Bob Smith", acme, steve);
      var tom = new Customer("Tom Kelly", ajax, carol);
      var mike = new Customer("Mike Palooza", acme, john);

      list.Add(new Order(bob, "Widgets", 10));
      list.Add(new Order(bob, "Nails", 200));
      list.Add(new Order(tom, "Boxes", 20));
      list.Add(new Order(tom, "Gadgets", 7));
      list.Add(new Order(mike, "Bolts", 3000));

      var matches = view.Select("Customer.AccountRep.Department = 12 AND Customer.AccountRep.Name = Carol*");

      Assert.IsNotNull(matches);
      Assert.AreEqual(2, matches.Count);
      Assert.AreEqual("Boxes", ((Order) matches[0]).Product);
      Assert.AreEqual("Gadgets", ((Order) matches[1]).Product);
    }

    [Test]
    public void SelectCriteriaPathInaccessibleValue()
    {
      var factory = ViewFactory.IListOrders();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (Order);

      var acme = new Company("Acme", "Seattle", "WA");
      var ajax = new Company("Ajax", "Detroit", "MI");
      var steve = new AccountRep("Steve O'Donnell", 56);
      var carol = new AccountRep("Carol Hanson", 12);
      var john = new AccountRep("John Roche", 12);

      var bob = new Customer("Bob Smith", acme, steve);
      var tom = new Customer("Tom Kelly", ajax, carol);
      var mike = new Customer("Mike Palooza", acme, john);
      var rick = new Customer("Rick Doohan", ajax, null);

      list.Add(new Order(bob, "Widgets", 10));
      list.Add(new Order(bob, "Nails", 200));
      list.Add(new Order(tom, "Boxes", 20));
      list.Add(new Order(tom, "Gadgets", 7));
      list.Add(new Order(mike, "Bolts", 3000));
      list.Add(new Order(rick, "Glue", 15));

      var matches = view.Select("Customer.AccountRep.Department = 12 AND Customer.AccountRep.Name = Carol*");

      Assert.IsNotNull(matches);
      Assert.AreEqual(2, matches.Count);
      Assert.AreEqual("Boxes", ((Order) matches[0]).Product);
      Assert.AreEqual("Gadgets", ((Order) matches[1]).Product);
    }

    [Test]
    public void SelectNoMatches()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      var matches = view.Select("IntegerValue > 100");

      Assert.IsNotNull(matches);
      Assert.AreEqual(0, matches.Count);
    }

    [Test]
    public void SelectSortedFiltered()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(110, "eee", new DateTime(1975, 6, 6)));

      view.Filter = "StringValue != 'bbb'";
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);

      var matches = view.Select("IntegerValue > 60 AND StringValue != 'aaa'");

      Assert.IsNotNull(matches);
      Assert.AreEqual(2, matches.Count);
      Assert.AreEqual(65, ((SimpleClass) matches[0]).IntegerValue);
      Assert.AreEqual(110, ((SimpleClass) matches[1]).IntegerValue);
    }

    [Test]
    [ExpectedException(typeof (ArgumentNullException))]
    public void SelectNull()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      view.Select((string) null);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void SelectEmpty()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      view.Select("");
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void SelectInvalid()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      view.Select("someProp = 16");
    }

    [Test]
    public void SelectPredicate()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      var matches = view.Select(delegate(object item) { return ((SimpleClass) item).IntegerValue > 60 && ((SimpleClass) item).StringValue != "bbb"; });

      Assert.IsNotNull(matches);
      Assert.AreEqual(2, matches.Count);
      Assert.AreEqual(100, ((SimpleClass) matches[0]).IntegerValue);
      Assert.AreEqual(65, ((SimpleClass) matches[1]).IntegerValue);
    }

    [Test]
    public void SelectPredicateNoMatches()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      var matches = view.Select(delegate(object item) { return ((SimpleClass) item).IntegerValue > 100; });

      Assert.IsNotNull(matches);
      Assert.AreEqual(0, matches.Count);
    }

    [Test]
    public void SelectPredicateSortedFiltered()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(110, "eee", new DateTime(1975, 6, 6)));

      view.Filter = "StringValue != 'bbb'";
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);

      var matches = view.Select(delegate(object item) { return ((SimpleClass) item).IntegerValue > 60 && ((SimpleClass) item).StringValue != "aaa"; });

      Assert.IsNotNull(matches);
      Assert.AreEqual(2, matches.Count);
      Assert.AreEqual(65, ((SimpleClass) matches[0]).IntegerValue);
      Assert.AreEqual(110, ((SimpleClass) matches[1]).IntegerValue);
    }

    [Test]
    [ExpectedException(typeof (ArgumentNullException))]
    public void SelectPredicateNull()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));
      view.Add(new SimpleClass(65, "ccc", new DateTime(1975, 6, 6)));

      view.Select((Predicate) null);
    }

    [Test]
    public void SortNull()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (SimpleClass);

      var now = DateTime.Now;

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
      Assert.AreEqual("eee", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("aaa", ((SimpleClass) view[3]).StringValue);
      Assert.AreEqual("ddd", ((SimpleClass) view[4]).StringValue);
    }

    [Test]
    public void SortEmpty()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (SimpleClass);

      var now = DateTime.Now;

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
      Assert.AreEqual("eee", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("aaa", ((SimpleClass) view[3]).StringValue);
      Assert.AreEqual("ddd", ((SimpleClass) view[4]).StringValue);
    }

    [Test]
    public void SortGetNotSet()
    {
      var factory = ViewFactory.IListSimpleItems();

      Assert.AreEqual("", factory.View.Sort);
    }

    [Test]
    public void SortGetApplySort()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (SimpleClass);

      list.Add(new SimpleClass(4, "aaa", new DateTime(1930, 5, 5)));
      list.Add(new SimpleClass(2, "qqq", new DateTime(1950, 5, 5)));
      list.Add(new SimpleClass(1, "zzz", new DateTime(1980, 5, 5)));
      list.Add(new SimpleClass(2, "mmm", new DateTime(1960, 5, 5)));
      list.Add(new SimpleClass(3, "bbb", new DateTime(1940, 5, 5)));
      list.Add(new SimpleClass(2, "mmm", new DateTime(1970, 5, 5)));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var sorts = new ListSortDescriptionCollection(new[]
                                                      {
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
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (SimpleClass);

      list.Add(new SimpleClass(4, "aaa", new DateTime(1930, 5, 5)));
      list.Add(new SimpleClass(2, "qqq", new DateTime(1950, 5, 5)));
      list.Add(new SimpleClass(1, "zzz", new DateTime(1980, 5, 5)));
      list.Add(new SimpleClass(2, "mmm", new DateTime(1960, 5, 5)));
      list.Add(new SimpleClass(3, "bbb", new DateTime(1940, 5, 5)));
      list.Add(new SimpleClass(2, "mmm", new DateTime(1970, 5, 5)));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var sorts = new ListSortDescriptionCollection(new[]
                                                      {
                                                        new ListSortDescription(props["IntegerValue"], ListSortDirection.Ascending),
                                                        new ListSortDescription(props["StringValue"], ListSortDirection.Descending),
                                                        new ListSortDescription(props["DateTimeValue"], ListSortDirection.Ascending)
                                                      });
      view.ApplySort(sorts);
      view.RemoveSort();

      Assert.AreEqual("", view.Sort);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void SortInvalidProperty()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (SimpleClass);

      view.Sort = "BadProperty";
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void SortInvalidDirection()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (SimpleClass);

      view.Sort = "StringValue XYZ";
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void SortInvalidTerm()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (SimpleClass);

      view.Sort = "StringValue ASC, DateTimeValue DESC IntegerValue";
    }

    [Test]
    public void SortSinglePropDefaultDirection()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (SimpleClass);

      var now = DateTime.Now;

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
      Assert.AreEqual("aaa", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("ddd", ((SimpleClass) view[3]).StringValue);
      Assert.AreEqual("eee", ((SimpleClass) view[4]).StringValue);
    }

    [Test]
    public void SortSinglePropAsc()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (SimpleClass);

      var now = DateTime.Now;

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
      Assert.AreEqual("aaa", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("ddd", ((SimpleClass) view[3]).StringValue);
      Assert.AreEqual("eee", ((SimpleClass) view[4]).StringValue);
    }

    [Test]
    public void SortSinglePropDesc()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (SimpleClass);

      var now = DateTime.Now;

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
      Assert.AreEqual("eee", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("ddd", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[3]).StringValue);
      Assert.AreEqual("aaa", ((SimpleClass) view[4]).StringValue);
    }

    [Test]
    public void SortPropertyPath()
    {
      var factory = ViewFactory.IListOrders();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (Order);

      var acme = new Company("Acme", "Seattle", "WA");
      var ajax = new Company("Ajax", "Detroit", "MI");
      var steve = new AccountRep("Steve O'Donnell", 56);
      var carol = new AccountRep("Carol Hanson", 12);
      var john = new AccountRep("John Roche", 10);

      var bob = new Customer("Bob Smith", acme, steve);
      var tom = new Customer("Tom Kelly", ajax, carol);
      var mike = new Customer("Mike Palooza", acme, john);

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
      Assert.AreEqual("Bolts", ((Order) view[0]).Product);
      Assert.AreEqual("Boxes", ((Order) view[1]).Product);
      Assert.AreEqual("Gadgets", ((Order) view[2]).Product);
      Assert.AreEqual("Widgets", ((Order) view[3]).Product);
      Assert.AreEqual("Nails", ((Order) view[4]).Product);
    }

    [Test]
    public void SortPropertyPathInaccessibleValues()
    {
      var factory = ViewFactory.IListOrders();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (Order);

      var acme = new Company("Acme", "Seattle", "WA");
      var ajax = new Company("Ajax", "Detroit", "MI");
      var steve = new AccountRep("Steve O'Donnell", 56);
      var carol = new AccountRep("Carol Hanson", 12);
      var john = new AccountRep("John Roche", 10);

      var bob = new Customer("Bob Smith", acme, steve);
      var tom = new Customer("Tom Kelly", ajax, null);
      var mike = new Customer("Mike Palooza", acme, carol);
      var rick = new Customer("Rick Doohan", ajax, john);

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
      Assert.AreEqual("Nails", ((Order) view[0]).Product);
      Assert.AreEqual("Widgets", ((Order) view[1]).Product);
      Assert.AreEqual("Bolts", ((Order) view[2]).Product);
      Assert.AreEqual("Glue", ((Order) view[3]).Product);
      Assert.AreEqual("Gadgets", ((Order) view[4]).Product);
      Assert.AreEqual("Boxes", ((Order) view[5]).Product);
    }

    [Test]
    public void SortMultipleProps()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (SimpleClass);

      var now = DateTime.Now;

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
      Assert.AreEqual("eee", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass) view[1]).DateTimeValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass) view[2]).DateTimeValue);
      Assert.AreEqual("aaa", ((SimpleClass) view[3]).StringValue);
      Assert.AreEqual("ddd", ((SimpleClass) view[4]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[5]).StringValue);
    }

    [Test]
    public void SortMultiplePropsDefaultDirection()
    {
      var factory = ViewFactory.IListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      view.ItemType = typeof (SimpleClass);

      var now = DateTime.Now;

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
      Assert.AreEqual("eee", ((SimpleClass) view[0]).StringValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[1]).StringValue);
      Assert.AreEqual(new DateTime(1950, 1, 1), ((SimpleClass) view[1]).DateTimeValue);
      Assert.AreEqual("bbb", ((SimpleClass) view[2]).StringValue);
      Assert.AreEqual(new DateTime(1960, 1, 1), ((SimpleClass) view[2]).DateTimeValue);
      Assert.AreEqual("aaa", ((SimpleClass) view[3]).StringValue);
      Assert.AreEqual("ddd", ((SimpleClass) view[4]).StringValue);
      Assert.AreEqual("ccc", ((SimpleClass) view[5]).StringValue);
    }

    [Test]
    public void BeforeAfterListChanged()
    {
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var callbackOrder = 0;
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
      var factory = ViewFactory.IBindingListSimpleItems();
      var view = factory.View;
      var list = factory.List;

      var callbackOrder = 0;
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