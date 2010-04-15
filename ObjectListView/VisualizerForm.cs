// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;

namespace JesseJohnston
{
	internal partial class VisualizerForm : Form
	{
		private ObjectListView view;
		private string listTypeName;
		private string listItemTypeName;
		private bool iEditableObject;
		private bool iNotifyPropertyChanged;
		private bool propertyChangeEvents;
		private bool listChanged;
		private bool iRaiseItemChangedEvents;
		private bool synced;

		public ObjectListView View
		{
			get { return view; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("View");
				view = value;
			}
		}

		public VisualizerForm()
		{
			InitializeComponent();
		}

		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			if (view == null)
				throw new ArgumentNullException("View");

			GetTypeNames();
			ShowListItemProperties();
			ShowListProperties();
			ShowView();
			ShowList();
		}

		private void ShowListProperties()
		{
			this.labelListType.Text = this.listTypeName;
			this.toolTip.SetToolTip(this.labelListType, view.List.GetType().FullName);

			if (ListSupportsListChanged(this.view.List))
			{
				this.listChanged = true;
				this.labelListSupportsListChanged.Text = "Yes";
				this.labelListSupportsListChanged.ForeColor = Color.Green;
			}
			if (this.view.List is IRaiseItemChangedEvents && ((IRaiseItemChangedEvents)this.view.List).RaisesItemChangedEvents)
			{
				this.iRaiseItemChangedEvents = true;
				this.labelListIRaiseItemChangedEvents.Text = "Yes";
				this.labelListIRaiseItemChangedEvents.ForeColor = Color.Green;
			}

			if (!this.view.List.IsFixedSize)
				this.labelFixedSize.Visible = false;

			if (!this.view.List.IsSynchronized || this.view.List.SyncRoot == null)
				this.labelSynced.Visible = false;
			else
				this.synced = true;

			if (!this.view.List.IsReadOnly)
				this.labelReadOnly.Visible = false;

			foreach (ListSortDescription sort in this.view.SortDescriptions)
				this.listViewSort.Items.Add(new ListViewItem(new string[] { sort.PropertyDescriptor.Name, sort.SortDirection.ToString() }));

			if (this.view.FilterPredicate == null)
				this.textBoxFilter.Text = this.view.Filter;
			else
				this.textBoxFilter.Text = "(FilterPredicate is in effect)";
		}
		private void ShowListItemProperties()
		{
			if (view.ItemType != null)
			{
				this.labelListItemType.Text = this.listItemTypeName;
				this.toolTip.SetToolTip(this.labelListItemType, view.ItemType.FullName);

				if (typeof(INotifyPropertyChanged).IsAssignableFrom(view.ItemType))
				{
					this.iNotifyPropertyChanged = true;
					this.labelINotifyPropertyChanged.Text = "Yes";
					this.labelINotifyPropertyChanged.ForeColor = Color.Green;
				}

				List<string> notifyingProps = GetPropertyChangedEvents(view.ItemType);
				if (notifyingProps.Count > 0)
				{
					this.propertyChangeEvents = true;
					this.labelPropertyChangedEvents.Text = "Yes";
					this.labelPropertyChangedEvents.ForeColor = Color.Green;
					this.toolTip.SetToolTip(this.labelPropertyChangedEvents, MakeTooltip(notifyingProps));

					if (!iNotifyPropertyChanged)
						this.labelINotifyPropertyChanged.ForeColor = Color.DarkOrange;
				}
				else if (!iNotifyPropertyChanged)
					this.labelPropertyChangedEvents.ForeColor = Color.Red;

				if (typeof(IEditableObject).IsAssignableFrom(view.ItemType))
				{
					this.iEditableObject = true;
					this.labelIEditableObject.Text = "Yes";
					this.labelIEditableObject.ForeColor = Color.Green;
				}
			}
		}
		private void ShowView()
		{
			List<PropertyDescriptor> props = new List<PropertyDescriptor>();
			foreach (PropertyDescriptor prop in ((ITypedList)this.view).GetItemProperties(null))
				props.Add(prop);
			props.Sort(delegate(PropertyDescriptor desc1, PropertyDescriptor desc2) { return string.Compare(desc1.Name, desc2.Name, true); });

			// When deciding whether to use a DataGridTableStyle that we have provided, or to use the default table style, DataGrid
			// tries to match the MappingName of our table style against the list name.  If it doesn't match, the default table style
			// is used.  The mapping name of our table style is "", the default.  This matches the list name returned by ObjectListView's
			// implementation of ITypedList.GetListName().

			foreach (PropertyDescriptor prop in props)
			{
				DataGridTextBoxColumn column = new DataGridTextBoxColumn();
				column.HeaderText = prop.Name;
				column.MappingName = prop.Name;
				column.NullText = "";
				column.ReadOnly = true;
				this.dataGridViewTableStyle.GridColumnStyles.Add(column);
			}

			this.dataGridView.DataSource = this.view;
		}
		private void ShowList()
		{
			List<PropertyDescriptor> props = new List<PropertyDescriptor>();
			foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(this.view.ItemType))
				props.Add(prop);
			props.Sort(delegate(PropertyDescriptor desc1, PropertyDescriptor desc2) { return string.Compare(desc1.Name, desc2.Name, true); });

			// When deciding whether to use a DataGridTableStyle that we have provided, or to use the default table style, DataGrid
			// tries to match the MappingName of our table style against the list name.  If it doesn't match, the default table style
			// is used.  The logic below assigns the mapping name to mimic the way that the DataGrid list manager retrieves the name of the list.
			if (this.view.List is ITypedList)
				this.dataGridListTableStyle.MappingName = ((ITypedList)this.view.List).GetListName(null);
			else
				this.dataGridListTableStyle.MappingName = this.view.List.GetType().Name;

			foreach (PropertyDescriptor prop in props)
			{
				DataGridTextBoxColumn column = new DataGridTextBoxColumn();
				column.HeaderText = prop.Name;
				column.MappingName = prop.Name;
				column.NullText = "";
				column.ReadOnly = true;
				this.dataGridListTableStyle.GridColumnStyles.Add(column);
			}

			this.dataGridList.DataSource = this.view.List;
		}
		private void GetTypeNames()
		{
			this.listItemTypeName = view.ItemType.Name;

			Type listType = view.List.GetType();
			this.listTypeName = listType.Name;

			if (listType.IsGenericType)
			{
				Type[] args = listType.GetGenericArguments();
				if (args != null && args.Length > 0)
				{
					if (listTypeName.Contains("`1"))
						listTypeName = listTypeName.Replace("`1", "<" + args[0].Name + ">");
				}
			}
		}
		private bool ListSupportsListChanged(IList list)
		{
			if (list == null)
				throw new ArgumentNullException("list");

			if (list is IBindingList)
			{
				return true;
			}
			else
			{
				EventInfo listChanged = list.GetType().GetEvent("ListChanged");
				return (listChanged != null && listChanged.EventHandlerType == typeof(ListChangedEventHandler));
			}
		}
		private string MakeTooltip(List<string> properties)
		{
			StringBuilder sb = new StringBuilder();
			bool first = true;
			for (int i = 0; i < properties.Count; i++)
			{
				if (first)
				{
					sb.Append(properties[i]);
					first = false;
				}
				else
					sb.AppendFormat(", {0}", properties[i]);
			}

			return sb.ToString();
		}
		private List<string> GetPropertyChangedEvents(Type itemType)
		{
			if (itemType == null)
				throw new ArgumentNullException("itemType");

			List<string> events = new List<string>();

			foreach (PropertyInfo prop in itemType.GetProperties())
			{
				EventInfo propChangedEvent = itemType.GetEvent(prop.Name + "Changed");
				if (propChangedEvent != null && propChangedEvent.EventHandlerType == typeof(EventHandler))
				{
					events.Add(prop.Name);
				}
			}

			return events;
		}

		private void buttonAnalysis_Click(object sender, EventArgs e)
		{
			AnalysisForm dlg = new AnalysisForm(this.listItemTypeName,
												this.listTypeName,
												this.iEditableObject,
												this.iNotifyPropertyChanged,
												this.propertyChangeEvents,
												this.listChanged,
												this.iRaiseItemChangedEvents,
												this.view.List.IsReadOnly,
												this.view.List.IsFixedSize,
												this.synced);
			dlg.ShowDialog();
		}
	}
}