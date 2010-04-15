
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests.Generic
{
	[TestFixture]
	public class ICancelAddNewTests
	{
		[Test]
		public void AddNewAndEndNew()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			ObjectView<SimpleClass> added = (ObjectView<SimpleClass>)view.AddNew();

			((ICancelAddNew)view).EndNew(view.IndexOf(added.Object));
			Assert.AreEqual(1, factory.ListChangedAddedCount);
		}

		[Test]
		public void AddNewAndCancelNew()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			ObjectView<SimpleClass> added = (ObjectView<SimpleClass>)view.AddNew();

			((ICancelAddNew)view).CancelNew(view.IndexOf(added.Object));
			Assert.AreEqual(1, factory.ListChangedAddedCount);
			Assert.AreEqual(1, factory.ListChangedDeletedCount);
		}

		[Test]
		public void AddNewEditableObjectAndEndNew()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			ObjectListView<SimpleEditableObject> view = factory.View;

			ObjectView<SimpleEditableObject> added = (ObjectView<SimpleEditableObject>)view.AddNew();

			((ICancelAddNew)view).EndNew(view.IndexOf(added.Object));
			Assert.AreEqual(2, factory.ListChangedAddedCount);
		}

		[Test]
		public void AddNewEditableObjectAndCancelNew()
		{
			ViewFactory<SimpleEditableObject> factory = ViewFactory<SimpleEditableObject>.IList();
			ObjectListView<SimpleEditableObject> view = factory.View;

			ObjectView<SimpleEditableObject> added = (ObjectView<SimpleEditableObject>)view.AddNew();

			((ICancelAddNew)view).CancelNew(view.IndexOf(added.Object));
			Assert.AreEqual(1, factory.ListChangedAddedCount);
			Assert.AreEqual(1, factory.ListChangedDeletedCount);
		}

		[Test]
		public void EndNewWithoutAddNew()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			((ICancelAddNew)view).EndNew(0);
			Assert.AreEqual(0, factory.ListChangedAddedCount);
		}

		[Test]
		public void EndNewWithoutAddNewWithListAdd()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			factory.List.Add(new SimpleClass());
			Assert.AreEqual(1, factory.ListChangedAddedCount);

			((ICancelAddNew)view).EndNew(0);
			Assert.AreEqual(1, factory.ListChangedAddedCount);
		}

		[Test]
		public void CancelNewWithoutAddNew()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IList();
			ObjectListView<SimpleClass> view = factory.View;

			((ICancelAddNew)view).CancelNew(0);
			Assert.AreEqual(0, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedDeletedCount);
		}

		[Test]
		public void CancelNewWithoutAddNewWithListAdd()
		{
			ViewFactory<SimpleClass> factory = ViewFactory<SimpleClass>.IBindingList();
			ObjectListView<SimpleClass> view = factory.View;

			factory.List.Add(new SimpleClass());
			Assert.AreEqual(1, factory.ListChangedAddedCount);

			((ICancelAddNew)view).CancelNew(0);
			Assert.AreEqual(1, factory.ListChangedAddedCount);
			Assert.AreEqual(0, factory.ListChangedDeletedCount);
		}
	}
}
#endif