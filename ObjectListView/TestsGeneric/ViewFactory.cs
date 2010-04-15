// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using JesseJohnston;
using System.ComponentModel;

namespace JesseJohnston.Tests.Generic
{
	public class ViewFactory<T>
	{
		#region Fields
		private ObjectListView<T> view;
		private IList<T> list;
		private int listChangedAddedRaised;
		private int listChangedDeletedRaised;
		private int listChangedResetRaised;
		private int listChangedItemChangedRaised;
		private int addingNewRaised;
		private int sortedRaised;
		private int removingItemRaised;
		private int beforeListChangedRaised;
		private int afterListChangedRaised;
		#endregion

		#region Properties
		public int AddingNewCount
		{
			get { return this.addingNewRaised; }
		}
		public int AfterListChangedCount
		{
			get { return this.afterListChangedRaised; }
		}
		public int BeforeListChangedCount
		{
			get { return this.beforeListChangedRaised; }
		}
		public IList<T> List
		{
			get { return this.list; }
		}
		public int ListChangedAddedCount
		{
			get { return this.listChangedAddedRaised; }
		}
		public int ListChangedDeletedCount
		{
			get { return this.listChangedDeletedRaised; }
		}
		public int ListChangedItemChangedCount
		{
			get { return this.listChangedItemChangedRaised; }
		}
		public int ListChangedResetCount
		{
			get { return this.listChangedResetRaised; }
		}
		public int RemovingItemCount
		{
			get { return this.removingItemRaised; }
		}
		public int SortedCount
		{
			get { return this.sortedRaised; }
		}
		public ObjectListView<T> View
		{
			get { return this.view; }
		}
		#endregion

		private ViewFactory()
		{
		}

		public void ClearEventCounts()
		{
			this.listChangedAddedRaised = 0;
			this.listChangedDeletedRaised = 0;
			this.listChangedResetRaised = 0;
			this.listChangedItemChangedRaised = 0;
			this.addingNewRaised = 0;
			this.removingItemRaised = 0;
			this.sortedRaised = 0;
			this.beforeListChangedRaised = 0;
			this.afterListChangedRaised = 0;
		}

		public T CreateItem()
		{
			return (T)Activator.CreateInstance(typeof(T));
		}

		public static ViewFactory<T> IList()
		{
			ViewFactory<T> factory = new ViewFactory<T>();

			factory.list = new List<T>();
			factory.view = new ObjectListView<T>(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}
		public static ViewFactory<T> IListReadOnly()
		{
			ViewFactory<T> factory = new ViewFactory<T>();

			factory.list = new List<T>().AsReadOnly();
			factory.view = new ObjectListView<T>(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}
		public static ViewFactory<T> IBindingList()
		{
			ViewFactory<T> factory = new ViewFactory<T>();

			factory.list = new BindingList<T>();
			factory.view = new ObjectListView<T>(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}
		public static ViewFactory<T> IBindingList(BindingList<T> list)
		{
			ViewFactory<T> factory = new ViewFactory<T>();

			factory.list = list;
			factory.view = new ObjectListView<T>(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}

		private void SetupListEventHandlers()
		{
			ClearEventCounts();

			this.view.ListChanged += delegate(object sender, ListChangedEventArgs e)
			{
				switch (e.ListChangedType)
				{
					case ListChangedType.ItemAdded:
						this.listChangedAddedRaised++;
						break;
					case ListChangedType.ItemDeleted:
						this.listChangedDeletedRaised++;
						break;
					case ListChangedType.Reset:
						this.listChangedResetRaised++;
						break;
					case ListChangedType.ItemChanged:
						this.listChangedItemChangedRaised++;
						break;
				}
			};

			this.view.AddingNew += delegate(object sender, ObjectListView<T>.AddingNewEventArgs e)
			{
				this.addingNewRaised++;
			};

			this.view.RemovingItem += delegate(object sender, RemovingItemEventArgs e)
			{
				this.removingItemRaised++;
			};

			this.view.Sorted += delegate(object sender, EventArgs e)
			{
				this.sortedRaised++;
			};

			this.view.BeforeListChanged += delegate(object sender, ListChangedEventArgs e)
			{
				this.beforeListChangedRaised++;
			};

			this.view.AfterListChanged += delegate(object sender, ListChangedEventArgs e)
			{
				this.afterListChangedRaised++;
			};
		}
	}
}
#endif
