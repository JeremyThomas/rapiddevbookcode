
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using JesseJohnston;
using System.ComponentModel;

namespace JesseJohnston.Tests
{
	public class ViewFactory
	{
		#region Fields
		private ObjectListView view;
		private IList list;
		private Type itemType;
		private int listChangedAddedRaised;
		private int listChangedDeletedRaised;
		private int listChangedResetRaised;
		private int listChangedItemChangedRaised;
		private int addingNewRaised;
		private int removingItemRaised;
		private int sortedRaised;
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
		public IList List
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
		public Type ListItemType
		{
			get { return itemType; }
		}
		public int RemovingItemCount
		{
			get { return this.removingItemRaised; }
		}
		public int SortedCount
		{
			get { return this.sortedRaised; }
		}
		public ObjectListView View
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

		public object CreateItem()
		{
			return Activator.CreateInstance(this.itemType);
		}

		public static ViewFactory IListSimpleItems()
		{
			ViewFactory factory = new ViewFactory();

			factory.list = new ArrayList();
			factory.itemType = typeof(SimpleClass);
			factory.view = new ObjectListView(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}
		public static ViewFactory IListIEditableObjectItems()
		{
			ViewFactory factory = new ViewFactory();

			factory.list = new ArrayList();
			factory.itemType = typeof(SimpleEditableObject);
			factory.view = new ObjectListView(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}
		public static ViewFactory IListINotifyPropertyChangedItems()
		{
			ViewFactory factory = new ViewFactory();

			factory.list = new ArrayList();
			factory.itemType = typeof(NotifyingListItem);
			factory.view = new ObjectListView(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}
		public static ViewFactory IListOrders()
		{
			ViewFactory factory = new ViewFactory();

			factory.list = new ArrayList();
			factory.itemType = typeof(Order);
			factory.view = new ObjectListView(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}
		public static ViewFactory IListPropertyChangedEventsItems()
		{
			ViewFactory factory = new ViewFactory();

			factory.list = new ArrayList();
			factory.itemType = typeof(NotifyingListItemEvents);
			factory.view = new ObjectListView(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}

		public static ViewFactory IBindingListSimpleItems()
		{
			ViewFactory factory = new ViewFactory();

			factory.list = new BindingList<SimpleClass>();
			factory.itemType = typeof(SimpleClass);
			factory.view = new ObjectListView(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}
		public static ViewFactory IBindingListIEditableObjectItems()
		{
			ViewFactory factory = new ViewFactory();

			factory.list = new BindingList<SimpleEditableObject>();
			factory.itemType = typeof(SimpleEditableObject);
			factory.view = new ObjectListView(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}
		public static ViewFactory IBindingListINotifyPropertyChangedItems()
		{
			ViewFactory factory = new ViewFactory();

			factory.list = new BindingList<NotifyingListItem>();
			factory.itemType = typeof(NotifyingListItem);
			factory.view = new ObjectListView(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}
		public static ViewFactory IBindingListOrders()
		{
			ViewFactory factory = new ViewFactory();

			factory.list = new BindingList<Order>();
			factory.itemType = typeof(Order);
			factory.view = new ObjectListView(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}
		public static ViewFactory IBindingListPropertyChangedEventsItems()
		{
			ViewFactory factory = new ViewFactory();

			factory.list = new BindingList<NotifyingListItemEvents>();
			factory.itemType = typeof(NotifyingListItemEvents);
			factory.view = new ObjectListView(factory.list);
			factory.SetupListEventHandlers();

			return factory;
		}

		private void SetupListEventHandlers()
		{
			ClearEventCounts();

			this.view.AddingNew += delegate(object sender, AddingNewEventArgs e)
			{
				this.addingNewRaised++;
			};

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