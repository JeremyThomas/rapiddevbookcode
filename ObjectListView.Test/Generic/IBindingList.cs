#pragma warning disable 1591	// Missing XML comment


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using NUnit.Framework;

namespace JesseJohnston.Tests.Generic
{
  [TestFixture]
  public class IBindingListTests
  {
    [Test]
    [ExpectedException(typeof (ArgumentNullException))]
    public void AddIndexNull()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      ((IBindingList) factory.View).AddIndex(null);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void AddIndexNotInType()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var dateProps = TypeDescriptor.GetProperties(typeof (DateTime));
      ((IBindingList) factory.View).AddIndex(dateProps[0]);
    }

    [Test]
    public void AddIndexPopulatedList()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var simpleProps = TypeDescriptor.GetProperties(typeof (SimpleClass));
      ((IBindingList) factory.View).AddIndex(simpleProps[0]);
    }

    [Test]
    public void AddNew()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var added = view.AddNew();
      Assert.IsNotNull(added);
      Assert.IsTrue(added is ObjectView<SimpleClass>);

      var item = ((ObjectView<SimpleClass>) added).Object;
      Assert.IsNotNull(item);

      Assert.AreEqual(-1, item.IntegerValue);
      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, factory.AddingNewCount);
      Assert.AreEqual(1, factory.ListChangedAddedCount);
    }

    [Test]
    public void AddNewUserObject()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var list = factory.List;
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      view.AddingNew += delegate(object sender, ObjectListView<SimpleClass>.AddingNewEventArgs e) { e.NewObject = new SimpleClass(5, "55", new DateTime(1955, 5, 5)); };

      var added = view.AddNew();
      Assert.IsNotNull(added);
      Assert.IsTrue(added is ObjectView<SimpleClass>);

      var item = ((ObjectView<SimpleClass>) added).Object;
      Assert.IsNotNull(item);

      Assert.AreEqual(5, item.IntegerValue);
      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, factory.AddingNewCount);
      Assert.AreEqual(1, factory.ListChangedAddedCount);
    }

    [Test]
    [ExpectedException(typeof (NotSupportedException))]
    public void AddNewAndEndEdit()
    {
      var factory = ViewFactory<SimpleClass>.IList();

      var added = (ObjectView<SimpleClass>) factory.View.AddNew();
      added.EndEdit();
    }

    [Test]
    [ExpectedException(typeof (NotSupportedException))]
    public void AddNewAndCancelEdit()
    {
      var factory = ViewFactory<SimpleClass>.IList();

      var added = (ObjectView<SimpleClass>) factory.View.AddNew();
      added.CancelEdit();
    }

    [Test]
    public void AddNewEditableObject()
    {
      var factory = ViewFactory<SimpleEditableObject>.IList();
      var view = factory.View;

      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));
      Assert.AreEqual(1, factory.ListChangedAddedCount);
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      Assert.AreEqual(2, factory.ListChangedAddedCount);
      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      Assert.AreEqual(3, factory.ListChangedAddedCount);

      var added = view.AddNew();
      Assert.IsNotNull(added);
      Assert.IsTrue(added is ObjectView<SimpleEditableObject>);

      var item = ((ObjectView<SimpleEditableObject>) added).Object;
      Assert.IsNotNull(item);

      Assert.AreEqual(-1, item.IntegerValue);
      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, factory.AddingNewCount);
      Assert.AreEqual(4, factory.ListChangedAddedCount);
    }

    [Test]
    public void AddNewExplicitEditableObject()
    {
      var factory = ViewFactory<ExplicitEditableObject>.IList();
      var view = factory.View;

      view.Add(new ExplicitEditableObject(1, DateTime.Now, "1"));
      Assert.AreEqual(1, factory.ListChangedAddedCount);
      view.Add(new ExplicitEditableObject(2, DateTime.Now, "2"));
      Assert.AreEqual(2, factory.ListChangedAddedCount);
      view.Add(new ExplicitEditableObject(3, DateTime.Now, "3"));
      Assert.AreEqual(3, factory.ListChangedAddedCount);

      var added = view.AddNew();
      Assert.IsNotNull(added);
      Assert.IsTrue(added is ObjectView<ExplicitEditableObject>);

      var item = ((ObjectView<ExplicitEditableObject>) added).Object;
      Assert.IsNotNull(item);

      Assert.AreEqual(-1, item.IntegerValue);
      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, factory.AddingNewCount);
      Assert.AreEqual(4, factory.ListChangedAddedCount);
    }

    [Test]
    public void AddNewEditableObjectAndEndEdit()
    {
      var factory = ViewFactory<SimpleEditableObject>.IList();
      var view = factory.View;

      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));
      Assert.AreEqual(1, factory.ListChangedAddedCount);
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      Assert.AreEqual(2, factory.ListChangedAddedCount);
      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      Assert.AreEqual(3, factory.ListChangedAddedCount);

      var item = (ObjectView<SimpleEditableObject>) view.AddNew();

      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, factory.AddingNewCount);
      Assert.AreEqual(4, factory.ListChangedAddedCount);

      item.EndEdit();

      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, factory.AddingNewCount);
      Assert.AreEqual(5, factory.ListChangedAddedCount);
    }

    [Test]
    public void AddNewExplicitEditableObjectAndEndEdit()
    {
      var factory = ViewFactory<ExplicitEditableObject>.IList();
      var view = factory.View;

      view.Add(new ExplicitEditableObject(1, DateTime.Now, "1"));
      Assert.AreEqual(1, factory.ListChangedAddedCount);
      view.Add(new ExplicitEditableObject(2, DateTime.Now, "2"));
      Assert.AreEqual(2, factory.ListChangedAddedCount);
      view.Add(new ExplicitEditableObject(3, DateTime.Now, "3"));
      Assert.AreEqual(3, factory.ListChangedAddedCount);

      var item = (ObjectView<ExplicitEditableObject>) view.AddNew();
      Assert.AreEqual(4, factory.ListChangedAddedCount);

      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, factory.AddingNewCount);

      item.EndEdit();

      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, factory.AddingNewCount);
      Assert.AreEqual(5, factory.ListChangedAddedCount);
    }

    [Test]
    public void AddNewEditableObjectAndCancelEdit()
    {
      var factory = ViewFactory<SimpleEditableObject>.IList();
      var view = factory.View;

      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));
      Assert.AreEqual(1, factory.ListChangedAddedCount);
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      Assert.AreEqual(2, factory.ListChangedAddedCount);
      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      Assert.AreEqual(3, factory.ListChangedAddedCount);

      var item = (ObjectView<SimpleEditableObject>) view.AddNew();

      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, factory.AddingNewCount);
      Assert.AreEqual(4, factory.ListChangedAddedCount);

      item.CancelEdit();

      Assert.AreEqual(3, view.Count);
      Assert.AreEqual(1, factory.AddingNewCount);
      Assert.AreEqual(4, factory.ListChangedAddedCount);
      Assert.AreEqual(1, factory.ListChangedDeletedCount);
    }

    [Test]
    public void AddNewExplicitEditableObjectAndCancelEdit()
    {
      var factory = ViewFactory<ExplicitEditableObject>.IList();
      var view = factory.View;

      view.Add(new ExplicitEditableObject(1, DateTime.Now, "1"));
      Assert.AreEqual(1, factory.ListChangedAddedCount);
      view.Add(new ExplicitEditableObject(2, DateTime.Now, "2"));
      Assert.AreEqual(2, factory.ListChangedAddedCount);
      view.Add(new ExplicitEditableObject(3, DateTime.Now, "3"));
      Assert.AreEqual(3, factory.ListChangedAddedCount);

      var item = (ObjectView<ExplicitEditableObject>) view.AddNew();

      Assert.AreEqual(4, view.Count);
      Assert.AreEqual(1, factory.AddingNewCount);
      Assert.AreEqual(4, factory.ListChangedAddedCount);

      item.CancelEdit();

      Assert.AreEqual(3, view.Count);
      Assert.AreEqual(1, factory.AddingNewCount);
      Assert.AreEqual(4, factory.ListChangedAddedCount);
      Assert.AreEqual(1, factory.ListChangedDeletedCount);
    }

    [Test]
    public void AddNewEditableObjectSorted()
    {
      var factory = ViewFactory<SimpleEditableObject>.IList();
      var view = factory.View;

      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleEditableObject))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      var added = view.AddNew();

      var item = ((ObjectView<SimpleEditableObject>) added).Object;

      // Until the added item is committed, it should be at the end of the collection.
      Assert.AreEqual(3, view.IndexOf(item));
    }

    [Test]
    public void AddNewEditableObjectSortedEndNew()
    {
      var factory = ViewFactory<SimpleEditableObject>.IList();
      var view = factory.View;

      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleEditableObject))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      var added = view.AddNew();

      var item = ((ObjectView<SimpleEditableObject>) added).Object;

      var index = view.IndexOf(item);

      ((ICancelAddNew) view).EndNew(index);

      // After committing the item, it should be placed into the sort.
      Assert.AreEqual(0, view.IndexOf(item));
    }

    [Test]
    public void AddNewEditableObjectFiltered()
    {
      var factory = ViewFactory<SimpleEditableObject>.IList();
      var view = factory.View;

      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

      view.FilterPredicate = delegate(SimpleEditableObject listItem) { return listItem.IntegerValue > -1; };

      var added = view.AddNew();

      var item = ((ObjectView<SimpleEditableObject>) added).Object;

      // Until the added item is committed, it should be at the end of the collection (and visible even though the filter would normally exclude it).
      Assert.AreEqual(3, view.IndexOf(item));
    }

    [Test]
    public void AddNewEditableObjectFilteredEndNew()
    {
      var factory = ViewFactory<SimpleEditableObject>.IList();
      var view = factory.View;

      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

      view.FilterPredicate = delegate(SimpleEditableObject listItem) { return listItem.IntegerValue > -1; };

      var added = view.AddNew();

      var item = ((ObjectView<SimpleEditableObject>) added).Object;

      var index = view.IndexOf(item);

      ((ICancelAddNew) view).EndNew(index);

      // After committing the item, the filter should be applied and the object not visible through the view.
      Assert.AreEqual(-1, view.IndexOf(item));
    }

    [Test]
    public void AddNewEditableObjectSortedFiltered()
    {
      var factory = ViewFactory<SimpleEditableObject>.IList();
      var view = factory.View;

      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleEditableObject))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      view.FilterPredicate = delegate(SimpleEditableObject listItem) { return listItem.IntegerValue > -1; };

      var added = view.AddNew();

      var item = ((ObjectView<SimpleEditableObject>) added).Object;

      // After committing the item, the filter should be applied and the object not visible through the view.
      Assert.AreEqual(3, view.IndexOf(item));
    }

    [Test]
    public void AddNewEditableObjectSortedFilteredEndNew()
    {
      var factory = ViewFactory<SimpleEditableObject>.IList();
      var view = factory.View;

      view.Add(new SimpleEditableObject(3, DateTime.Now, "3"));
      view.Add(new SimpleEditableObject(2, DateTime.Now, "2"));
      view.Add(new SimpleEditableObject(1, DateTime.Now, "1"));

      view.FilterPredicate = delegate(SimpleEditableObject listItem) { return listItem.IntegerValue > -1; };

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleEditableObject))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      var added = view.AddNew();

      var item = ((ObjectView<SimpleEditableObject>) added).Object;

      var index = view.IndexOf(item);

      ((ICancelAddNew) view).EndNew(index);

      // After committing the item, the filter should be applied and the object not visible through the view.
      Assert.AreEqual(-1, view.IndexOf(item));
    }

    [Test]
    public void AddNewSorted()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(3, "3", DateTime.Now));
      view.Add(new SimpleClass(2, "2", DateTime.Now));
      view.Add(new SimpleClass(1, "1", DateTime.Now));

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleClass))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      var added = view.AddNew();

      var item = ((ObjectView<SimpleClass>) added).Object;

      // Until the added item is committed, it should be at the end of the collection.
      Assert.AreEqual(3, view.IndexOf(item));
    }

    [Test]
    public void AddNewSortedEndNew()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(3, "3", DateTime.Now));
      view.Add(new SimpleClass(2, "2", DateTime.Now));
      view.Add(new SimpleClass(1, "1", DateTime.Now));

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleClass))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      var added = view.AddNew();

      var item = ((ObjectView<SimpleClass>) added).Object;

      var index = view.IndexOf(item);

      ((ICancelAddNew) view).EndNew(index);

      // After committing the item, it should be placed into the sort.
      Assert.AreEqual(0, view.IndexOf(item));
    }

    [Test]
    public void AddNewFiltered()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(3, "3", DateTime.Now));
      view.Add(new SimpleClass(2, "2", DateTime.Now));
      view.Add(new SimpleClass(1, "1", DateTime.Now));
      view.Add(new SimpleClass(-1, "1", DateTime.Now));
      view.Add(new SimpleClass(-2, "1", DateTime.Now));
      view.Add(new SimpleClass(-3, "1", DateTime.Now));

      view.FilterPredicate = delegate(SimpleClass listItem) { return listItem.IntegerValue > -1; };

      var added = view.AddNew();

      var item = ((ObjectView<SimpleClass>) added).Object;

      // Until the added item is committed, it should be at the end of the collection (and visible even though the filter would normally exclude it).
      Assert.AreEqual(3, view.IndexOf(item));
    }

    [Test]
    public void AddNewFilteredEndNew()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(3, "3", DateTime.Now));
      view.Add(new SimpleClass(2, "2", DateTime.Now));
      view.Add(new SimpleClass(1, "1", DateTime.Now));

      view.FilterPredicate = delegate(SimpleClass listItem) { return listItem.IntegerValue > -1; };

      var added = view.AddNew();

      var item = ((ObjectView<SimpleClass>) added).Object;

      var index = view.IndexOf(item);

      ((ICancelAddNew) view).EndNew(index);

      // After committing the item, the filter should be applied and the object not visible through the view.
      Assert.AreEqual(-1, view.IndexOf(item));
    }

    [Test]
    public void AddNewSortedFiltered()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(3, "3", DateTime.Now));
      view.Add(new SimpleClass(2, "2", DateTime.Now));
      view.Add(new SimpleClass(1, "1", DateTime.Now));

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleClass))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      view.Filter = "IntegerValue > -1";

      var added = view.AddNew();

      var item = ((ObjectView<SimpleClass>) added).Object;

      // Until the added item is committed, it should be at the end of the collection (and visible even though the filter would normally exclude it).
      Assert.AreEqual(3, view.IndexOf(item));
    }

    [Test]
    public void AddNewSortedFilteredEndNew()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(3, "3", DateTime.Now));
      view.Add(new SimpleClass(2, "2", DateTime.Now));
      view.Add(new SimpleClass(1, "1", DateTime.Now));

      view.Filter = "IntegerValue > -1";

      var intProp = TypeDescriptor.GetProperties(typeof (SimpleClass))["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);

      var added = view.AddNew();

      var item = ((ObjectView<SimpleClass>) added).Object;

      var index = view.IndexOf(item);

      ((ICancelAddNew) view).EndNew(index);

      // After committing the item, the filter should be applied and the object not visible through the view.
      Assert.AreEqual(-1, view.IndexOf(item));
    }

    [Test]
    public void AllowEditDefault()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      Assert.IsTrue(factory.View.AllowEdit);
    }

    [Test]
    public void AllowEditDefaultReadOnly()
    {
      var factory = ViewFactory<SimpleClass>.IListReadOnly();
      Assert.IsFalse(factory.View.AllowEdit);
    }

    [Test]
    public void AllowEditSetTrue()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      factory.View.AllowEdit = true;
      Assert.IsTrue(factory.View.AllowEdit);
    }

    [Test]
    public void AllowEditSetFalse()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      factory.View.AllowEdit = false;
      Assert.IsFalse(factory.View.AllowEdit);
    }

    [Test]
    [ExpectedException(typeof (InvalidOperationException))]
    public void AllowEditSetTrueReadOnly()
    {
      var factory = ViewFactory<SimpleClass>.IListReadOnly();
      factory.View.AllowEdit = true;
    }

    [Test]
    public void AllowEditSetFalseReadOnly()
    {
      var factory = ViewFactory<SimpleClass>.IListReadOnly();
      factory.View.AllowEdit = false;
      Assert.IsFalse(factory.View.AllowEdit);
    }

    [Test]
    [ExpectedException(typeof (DataException))]
    public void AllowEditSetFalseEdit()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      factory.List.Add(new SimpleClass());
      factory.View.AllowEdit = false;
      factory.View[0] = new SimpleClass();
    }

    [Test]
    public void AllowNewDefault()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      Assert.IsTrue(factory.View.AllowNew);
    }

    [Test]
    public void AllowNewDefaultReadOnly()
    {
      var factory = ViewFactory<SimpleClass>.IListReadOnly();
      Assert.IsFalse(factory.View.AllowNew);
    }

    [Test]
    public void AllowNewSetTrue()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      factory.View.AllowNew = true;
      Assert.IsTrue(factory.View.AllowNew);
    }

    [Test]
    public void AllowNewSetFalse()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      factory.View.AllowNew = false;
      Assert.IsFalse(factory.View.AllowNew);
    }

    [Test]
    [ExpectedException(typeof (InvalidOperationException))]
    public void AllowNewSetTrueReadOnly()
    {
      var factory = ViewFactory<SimpleClass>.IListReadOnly();
      factory.View.AllowNew = true;
    }

    [Test]
    public void AllowNewSetFalseReadOnly()
    {
      var factory = ViewFactory<SimpleClass>.IListReadOnly();
      factory.View.AllowNew = false;
      Assert.IsFalse(factory.View.AllowNew);
    }

    [Test]
    [ExpectedException(typeof (DataException))]
    public void AllowNewSetFalseAdd()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      factory.View.AllowNew = false;
      factory.View.Add(new SimpleClass());
    }

    [Test]
    [ExpectedException(typeof (DataException))]
    public void AllowNewSetFalseAddNew()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      factory.View.AllowNew = false;
      factory.View.AddNew();
    }

    [Test]
    [ExpectedException(typeof (DataException))]
    public void AllowNewSetFalseInsert()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      factory.View.AllowNew = false;
      factory.View.Insert(0, new SimpleClass());
    }

    [Test]
    public void AllowRemoveDefault()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      Assert.IsTrue(factory.View.AllowRemove);
    }

    [Test]
    public void AllowRemoveDefaultReadOnly()
    {
      var factory = ViewFactory<SimpleClass>.IListReadOnly();
      Assert.IsFalse(factory.View.AllowRemove);
    }

    [Test]
    public void AllowRemoveSetTrue()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      factory.View.AllowRemove = true;
      Assert.IsTrue(factory.View.AllowRemove);
    }

    [Test]
    public void AllowRemoveSetFalse()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      factory.View.AllowRemove = false;
      Assert.IsFalse(factory.View.AllowRemove);
    }

    [Test]
    [ExpectedException(typeof (InvalidOperationException))]
    public void AllowRemoveSetTrueReadOnly()
    {
      var factory = ViewFactory<SimpleClass>.IListReadOnly();
      factory.View.AllowRemove = true;
    }

    [Test]
    public void AllowRemoveSetFalseReadOnly()
    {
      var factory = ViewFactory<SimpleClass>.IListReadOnly();
      factory.View.AllowRemove = false;
      Assert.IsFalse(factory.View.AllowRemove);
    }

    [Test]
    [ExpectedException(typeof (DataException))]
    public void AllowRemoveSetFalseRemove()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var item = new SimpleClass();
      factory.View.Add(item);
      factory.View.AllowRemove = false;
      factory.View.Remove(item);
    }

    [Test]
    [ExpectedException(typeof (DataException))]
    public void AllowRemoveSetFalseRemoveAt()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var item = new SimpleClass();
      factory.View.Add(item);
      factory.View.AllowRemove = false;
      factory.View.RemoveAt(0);
    }

    [Test]
    public void ApplySort()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
      Assert.AreEqual(1, factory.ListChangedResetCount);

      var pos = view.GetEnumerator();

      pos.MoveNext();
      var val = pos.Current;
      Assert.IsNotNull(val);
      Assert.AreEqual(60, val.IntegerValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsNotNull(val);
      Assert.AreEqual(80, val.IntegerValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsNotNull(val);
      Assert.AreEqual(100, val.IntegerValue);
    }

    [Test]
    public void ApplySortDescending()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["StringValue"], ListSortDirection.Descending);
      Assert.AreEqual(1, factory.ListChangedResetCount);

      var pos = view.GetEnumerator();

      pos.MoveNext();
      var val = pos.Current;
      Assert.IsNotNull(val);
      Assert.AreEqual("ccc", val.StringValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsNotNull(val);
      Assert.AreEqual("bbb", val.StringValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsNotNull(val);
      Assert.AreEqual("aaa", val.StringValue);
    }

    [Test]
    public void ApplySortNullable()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;
      var list = factory.List;

      list.Add(new SimpleClass(1, "aaa", DateTime.Now, new DateTime(1992, 3, 5)));
      list.Add(new SimpleClass(2, "bbb", DateTime.Now, null));
      list.Add(new SimpleClass(3, "ccc", DateTime.Now, new DateTime(1991, 1, 2)));
      list.Add(new SimpleClass(4, "ddd", DateTime.Now, new DateTime(1991, 3, 5)));
      list.Add(new SimpleClass(5, "eee", DateTime.Now, new DateTime(1993, 11, 12)));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["NullableDateTimeValue"], ListSortDirection.Ascending);

      var pos = view.GetEnumerator();

      pos.MoveNext();
      var val = pos.Current;
      Assert.AreEqual(null, val.NullableDateTimeValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsTrue(val.NullableDateTimeValue.HasValue);
      Assert.AreEqual(new DateTime(1991, 1, 2), val.NullableDateTimeValue.Value);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsTrue(val.NullableDateTimeValue.HasValue);
      Assert.AreEqual(new DateTime(1991, 3, 5), val.NullableDateTimeValue.Value);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsTrue(val.NullableDateTimeValue.HasValue);
      Assert.AreEqual(new DateTime(1992, 3, 5), val.NullableDateTimeValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsTrue(val.NullableDateTimeValue.HasValue);
      Assert.AreEqual(new DateTime(1993, 11, 12), val.NullableDateTimeValue);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void ApplySortInvalidProperty()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var props = TypeDescriptor.GetProperties(typeof (DateTime));
      factory.View.ApplySort(props["Day"], ListSortDirection.Ascending);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void ApplySortIncomparableProperty()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));

      factory.View.ApplySort(props["IncomparableValue"], ListSortDirection.Ascending);
    }

    [Test]
    public void ApplySortNull()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(null, ListSortDirection.Ascending);
      Assert.AreEqual(0, factory.ListChangedResetCount);

      var pos = view.GetEnumerator();

      pos.MoveNext();
      var val = pos.Current;
      Assert.IsNotNull(val);
      Assert.AreEqual(100, val.IntegerValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsNotNull(val);
      Assert.AreEqual(80, val.IntegerValue);

      pos.MoveNext();
      val = pos.Current;
      Assert.IsNotNull(val);
      Assert.AreEqual(60, val.IntegerValue);
    }

    [Test]
    public void Find()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var index = ((IBindingList) view).Find(props["DateTimeValue"], new DateTime(1975, 6, 6));
      Assert.AreEqual(2, index);
    }

    [Test]
    [ExpectedException(typeof (ArgumentNullException))]
    public void FindNullProp()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      ((IBindingList) factory.View).Find(null, new DateTime(1975, 6, 6));
    }

    [Test]
    public void FindSorted()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["DateTimeValue"], ListSortDirection.Descending);
      var index = ((IBindingList) view).Find(props["DateTimeValue"], new DateTime(1975, 6, 6));
      Assert.AreEqual(1, index);
    }

    [Test]
    public void IsSortedUnsorted()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      Assert.IsFalse(factory.View.IsSorted);
    }

    [Test]
    public void IsSortedSorted()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      factory.View.ApplySort(props["DateTimeValue"], ListSortDirection.Descending);
      Assert.IsTrue(factory.View.IsSorted);
    }

    [Test]
    public void IsSortedSortedRemoveSort()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["DateTimeValue"], ListSortDirection.Descending);
      view.RemoveSort();
      Assert.IsFalse(view.IsSorted);
    }

    [Test]
    public void IsSortedUnsortedRemoveSort()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.RemoveSort();
      Assert.IsFalse(view.IsSorted);
    }

    [Test]
    public void RemoveIndex()
    {
      var factory = ViewFactory<SimpleClass>.IList();

      var simpleProps = TypeDescriptor.GetProperties(typeof (SimpleClass));
      ((IBindingList) factory.View).RemoveIndex(simpleProps[0]);
    }

    [Test]
    [ExpectedException(typeof (ArgumentNullException))]
    public void RemoveIndexNull()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      ((IBindingList) factory.View).RemoveIndex(null);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void RemoveIndexNotInType()
    {
      var factory = ViewFactory<SimpleClass>.IList();

      var dateProps = TypeDescriptor.GetProperties(typeof (DateTime));
      ((IBindingList) factory.View).RemoveIndex(dateProps[0]);
    }

    [Test]
    public void RemoveSort()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
      view.RemoveSort();
      Assert.AreEqual(2, factory.ListChangedResetCount); // once for apply, once for remove

      Assert.AreEqual(100, view[0].IntegerValue);
    }

    [Test]
    public void RemoveSortNoApplySort()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      view.RemoveSort();
      Assert.AreEqual(0, factory.ListChangedResetCount); // no sort prior to remove; no-op

      Assert.AreEqual(100, view[0].IntegerValue);
    }

    [Test]
    public void RemoveSortMultiple()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      view.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      view.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
      view.RemoveSort();
      view.RemoveSort();
      Assert.AreEqual(2, factory.ListChangedResetCount); // once for the apply, and once for the first remove

      Assert.AreEqual(100, view[0].IntegerValue);
    }

    [Test]
    public void SortDirectionAscending()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Ascending);
      Assert.AreEqual(ListSortDirection.Ascending, view.SortDirection);
    }

    [Test]
    public void SortDirectionDescending()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Descending);
      Assert.AreEqual(ListSortDirection.Descending, view.SortDirection);
    }

    [Test]
    public void SortDirectionNoSort()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      Assert.AreEqual(ListSortDirection.Ascending, factory.View.SortDirection);
    }

    [Test]
    public void SortDirectionAfterRemoveSort()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Descending);
      view.RemoveSort();
      Assert.AreEqual(ListSortDirection.Ascending, view.SortDirection);
    }

    [Test]
    public void SortProperty()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var intProp = props["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Ascending);
      Assert.AreEqual(intProp, view.SortProperty);
    }

    [Test]
    public void SortPropertyNoSort()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      Assert.IsNull(factory.View.SortProperty);
    }

    [Test]
    public void SortPropertyAfterRemoveSort()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      view.ApplySort(props["IntegerValue"], ListSortDirection.Descending);
      view.RemoveSort();
      Assert.IsNull(view.SortProperty);
    }

    [Test]
    public void SortAddItem()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(1, "aaa", DateTime.Now));
      view.Add(new SimpleClass(4, "bbb", DateTime.Now));
      view.Add(new SimpleClass(3, "ccc", DateTime.Now));
      view.Add(new SimpleClass(2, "ddd", DateTime.Now));
      view.Add(new SimpleClass(6, "eee", DateTime.Now));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var intProp = props["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Descending);

      Assert.AreEqual(5, view.Count);
      Assert.AreEqual("eee", view[0].StringValue);
      Assert.AreEqual("bbb", view[1].StringValue);
      Assert.AreEqual("ccc", view[2].StringValue);
      Assert.AreEqual("ddd", view[3].StringValue);
      Assert.AreEqual("aaa", view[4].StringValue);

      view.Add(new SimpleClass(5, "fff", DateTime.Now));

      Assert.AreEqual(6, view.Count);
      Assert.AreEqual("eee", view[0].StringValue);
      Assert.AreEqual("fff", view[1].StringValue);
      Assert.AreEqual("bbb", view[2].StringValue);
      Assert.AreEqual("ccc", view[3].StringValue);
      Assert.AreEqual("ddd", view[4].StringValue);
      Assert.AreEqual("aaa", view[5].StringValue);
    }

    [Test]
    public void SortAddItemListDirect()
    {
      var factory = ViewFactory<SimpleClass>.IList();
      var view = factory.View;

      view.Add(new SimpleClass(1, "aaa", DateTime.Now));
      view.Add(new SimpleClass(4, "bbb", DateTime.Now));
      view.Add(new SimpleClass(3, "ccc", DateTime.Now));
      view.Add(new SimpleClass(2, "ddd", DateTime.Now));
      view.Add(new SimpleClass(6, "eee", DateTime.Now));

      var props = TypeDescriptor.GetProperties(typeof (SimpleClass));
      var intProp = props["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Descending);

      Assert.AreEqual(5, view.Count);
      Assert.AreEqual("eee", view[0].StringValue);
      Assert.AreEqual("bbb", view[1].StringValue);
      Assert.AreEqual("ccc", view[2].StringValue);
      Assert.AreEqual("ddd", view[3].StringValue);
      Assert.AreEqual("aaa", view[4].StringValue);

      factory.List.Add(new SimpleClass(5, "fff", DateTime.Now));

      // This works because as soon as we access the view again, the sort indexes are found dirty and are rebuilt.
      // Dirty detection works only for add/delete, not item change.
      Assert.AreEqual(6, view.Count);
      Assert.AreEqual("eee", view[0].StringValue);
      Assert.AreEqual("fff", view[1].StringValue);
      Assert.AreEqual("bbb", view[2].StringValue);
      Assert.AreEqual("ccc", view[3].StringValue);
      Assert.AreEqual("ddd", view[4].StringValue);
      Assert.AreEqual("aaa", view[5].StringValue);
    }

    [Test]
    public void SortChangeItem()
    {
      var factory = ViewFactory<NotifyingListItem>.IList();
      var view = factory.View;

      view.Add(new NotifyingListItem(1, "aaa", DateTime.Now));
      view.Add(new NotifyingListItem(4, "bbb", DateTime.Now));
      view.Add(new NotifyingListItem(3, "ccc", DateTime.Now));
      view.Add(new NotifyingListItem(2, "ddd", DateTime.Now));
      view.Add(new NotifyingListItem(6, "eee", DateTime.Now));

      var props = TypeDescriptor.GetProperties(typeof (NotifyingListItem));
      var intProp = props["IntegerValue"];
      view.ApplySort(intProp, ListSortDirection.Descending);

      Assert.AreEqual(5, view.Count);
      Assert.AreEqual("eee", view[0].StringValue);
      Assert.AreEqual("bbb", view[1].StringValue);
      Assert.AreEqual("ccc", view[2].StringValue);
      Assert.AreEqual("ddd", view[3].StringValue);
      Assert.AreEqual("aaa", view[4].StringValue);

      // Change bbb from 4 to -1 (putting it at the end of the sort.
      factory.List[1].IntegerValue = -1;

      Assert.AreEqual(5, view.Count);
      Assert.AreEqual("eee", view[0].StringValue);
      Assert.AreEqual("ccc", view[1].StringValue);
      Assert.AreEqual("ddd", view[2].StringValue);
      Assert.AreEqual("aaa", view[3].StringValue);
      Assert.AreEqual("bbb", view[4].StringValue);
    }

    [Test]
    public void SupportsChangeNotification()
    {
      var factory = ViewFactory<SimpleClass>.IList();

      // List<> does not implement ListChanged, but the wrapper must report true.
      Assert.IsTrue(((IBindingListView) factory.View).SupportsChangeNotification);
    }

    [Test]
    public void SupportsChangeNotificationIBindingList()
    {
      var factory = ViewFactory<SimpleClass>.IBindingList();

      // BindingList<> implements ListChanged via IBindingList.
      Assert.IsTrue(((IBindingListView) factory.View).SupportsChangeNotification);
    }

    [Test]
    public void SupportsChangeNotificationNotifyingList()
    {
      var view = new ObjectListView<SimpleClass>(new NotifyingList<SimpleClass>());

      // NotifyingList<> implements ListChanged via matching event declaration.
      Assert.IsTrue(((IBindingListView) view).SupportsChangeNotification);
    }

    /// <summary>
    /// List items that don't support INotifyPropertyChanged or xxxChanged shouldn't cause ListChanged to be raised.
    /// </summary>
    [Test]
    public void ListChangedSimpleItemChanged()
    {
      var list = new BindingList<SimpleEditableObject>();
      var item = new SimpleEditableObject();
      list.Add(item);

      var factory = ViewFactory<SimpleEditableObject>.IBindingList(list);

      factory.ClearEventCounts();

      Assert.AreEqual(0, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedDeletedCount);
      Assert.AreEqual(0, factory.ListChangedItemChangedCount);
      Assert.AreEqual(0, factory.ListChangedResetCount);

      item.IntegerValue++;

      Assert.AreEqual(0, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedDeletedCount);
      Assert.AreEqual(0, factory.ListChangedItemChangedCount);
      Assert.AreEqual(0, factory.ListChangedResetCount);
    }

    /// <summary>
    /// List items that support INotifyPropertyChanged will cause ListChanged to be raised.
    /// </summary>
    [Test]
    public void ListChangedNotifyingItemChanged()
    {
      var list = new BindingList<NotifyingListItem>();
      var item = new NotifyingListItem();
      list.Add(item);

      var factory = ViewFactory<NotifyingListItem>.IBindingList(list);

      factory.ClearEventCounts();

      Assert.AreEqual(0, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedDeletedCount);
      Assert.AreEqual(0, factory.ListChangedItemChangedCount);
      Assert.AreEqual(0, factory.ListChangedResetCount);

      item.IntegerValue++;

      Assert.AreEqual(0, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedDeletedCount);
      Assert.AreEqual(1, factory.ListChangedItemChangedCount);
      Assert.AreEqual(0, factory.ListChangedResetCount);
    }

    /// <summary>
    /// List items that support xxxChanged events will cause ListChanged to be raised.
    /// </summary>
    [Test]
    public void ListChangedNotifyingEventItemChanged()
    {
      var list = new BindingList<NotifyingListItemEvents>();
      var item = new NotifyingListItemEvents();
      list.Add(item);

      var factory = ViewFactory<NotifyingListItemEvents>.IBindingList(list);

      factory.ClearEventCounts();

      Assert.AreEqual(0, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedDeletedCount);
      Assert.AreEqual(0, factory.ListChangedItemChangedCount);
      Assert.AreEqual(0, factory.ListChangedResetCount);

      item.IntegerValue++;

      Assert.AreEqual(0, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedDeletedCount);
      Assert.AreEqual(1, factory.ListChangedItemChangedCount);
      Assert.AreEqual(0, factory.ListChangedResetCount);
    }

    [Test]
    public void ListChangedItemReplaced()
    {
      var factory = ViewFactory<SimpleClass>.IBindingList();
      var list = factory.List;

      list.Add(new SimpleClass(100, "aaa", new DateTime(1970, 1, 1)));
      list.Add(new SimpleClass(80, "bbb", new DateTime(1980, 12, 12)));
      list.Add(new SimpleClass(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var item = new SimpleClass(50, "555", new DateTime(1955, 5, 5));

      Assert.AreEqual(0, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedDeletedCount);
      Assert.AreEqual(0, factory.ListChangedItemChangedCount);
      Assert.AreEqual(0, factory.ListChangedResetCount);

      list[2] = item;

      Assert.AreEqual(0, factory.ListChangedAddedCount);
      Assert.AreEqual(0, factory.ListChangedDeletedCount);
      Assert.AreEqual(1, factory.ListChangedItemChangedCount);
      Assert.AreEqual(0, factory.ListChangedResetCount);
    }

    [Test]
    public void ListChangedItemReplacedAndUpdated()
    {
      var factory = ViewFactory<NotifyingListItem>.IBindingList();
      var list = factory.List;

      list.Add(new NotifyingListItem(100, "aaa", new DateTime(1970, 1, 1)));
      list.Add(new NotifyingListItem(80, "bbb", new DateTime(1980, 12, 12)));
      list.Add(new NotifyingListItem(60, "ccc", new DateTime(1975, 6, 6)));

      factory.ClearEventCounts();

      var item = new NotifyingListItem(50, "555", new DateTime(1955, 5, 5));
      list[2] = item;
      Assert.AreEqual(1, factory.ListChangedItemChangedCount);

      item.IntegerValue = 60;
      Assert.AreEqual(2, factory.ListChangedItemChangedCount);
    }

    [Test]
    public void SupportsSearching()
    {
      var factory = ViewFactory<SimpleEditableObject>.IList();
      Assert.IsTrue(((IBindingListView) factory.View).SupportsSearching);
    }

    [Test]
    public void SupportsSorting()
    {
      var factory = ViewFactory<SimpleEditableObject>.IList();
      Assert.IsTrue(((IBindingListView) factory.View).SupportsSorting);
    }

    [Test]
    public void SupportsSortingNoProps()
    {
      var view = new ObjectListView<int>(new List<int>());
      Assert.IsFalse(((IBindingListView) view).SupportsSorting);
    }
  }
}

