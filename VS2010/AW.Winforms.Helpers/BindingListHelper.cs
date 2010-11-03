using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AW.Helper;
using JesseJohnston;

namespace AW.Winforms.Helpers
{
	public static class BindingListHelper
	{
		//&& enumerable.ToString() != "System.Collections.Hashtable+KeyCollection"
		public static IBindingListView ToBindingListView(this IEnumerable enumerable)
		{
			var showenEnumerable = enumerable != null && !(enumerable is string);
			if (showenEnumerable)
			{
				if (enumerable is IBindingListView)
					return (IBindingListView) enumerable;
				if (enumerable is IListSource)
				{
					var bindingListView = ListSourceToBindingListView((IListSource) enumerable);
					if (bindingListView != null)
						return bindingListView;
				}
				return CreateBindingListView(enumerable);
			}
			return null;
		}

		public static IBindingListView ToBindingListView<T>(this IEnumerable<T> enumerable)
		{
			var showenEnumerable = enumerable != null && !(enumerable is string);
			if (showenEnumerable)
			{
				if (enumerable is IBindingListView)
					return (IBindingListView) enumerable;
				if (enumerable is IListSource)
				{
					var bindingListView = ListSourceToBindingListView((IListSource) enumerable);
					if (bindingListView != null)
						return bindingListView;
				}
				return ToObjectListView(enumerable);
			}
			return null;
		}

		public static IBindingListView ListSourceToBindingListView(IListSource listSource)
		{
			if (listSource != null)
			{
				var list = listSource.GetList();
				if (list != null)
					return list.ToBindingListView();
			}
			return null;
		}

		private static IBindingListView ToObjectListView(this IList list)
		{
			if (list != null)
			{
				if (list is IBindingListView)
					return (IBindingListView) list;
				var objectListView = new ObjectListView(list);
				if (objectListView.ItemType != null)
					return objectListView;
			}
			return null;
		}

		private static IBindingListView ToObjectListView(this ICollection collection)
		{
			if (collection != null)
			{
				if (collection is IList)
					return ToObjectListView((IList)collection);
				var objectListView = new ObjectListView(new ArrayList(collection));
				if (objectListView.ItemType != null)
					return objectListView;
			}
			return null;
		}

		private static IBindingListView ToObjectListView<T>(this IList<T> list)
		{
			if (list != null)
			{
				if (list is IBindingListView)
					return (IBindingListView) list;
				var objectListView = new ObjectListView<T>(list);
				return objectListView;
			}
			return null;
		}

		private static IBindingListView CreateBindingListView(IEnumerable enumerable)
		{
			var itemType = MetaDataHelper.GetEnumerableItemType(enumerable);
			return itemType == typeof (string) ? null : CreateBindingListView(enumerable, itemType);
		}

		private static IBindingListView CreateBindingListView(IEnumerable enumerable, Type itemType)
		{
			enumerable = (IEnumerable) ListBindingHelper.GetList(enumerable);
			if (enumerable is ICollection)
			{
				var objectListView = ((ICollection)enumerable).ToObjectListView();
				if (objectListView != null)
					return objectListView;
			}
			var bindingListView = CreateObjectListView();
			foreach (var item in enumerable)
			{
				bindingListView.Add(item);
			}
			return bindingListView;
		}

		public static IList CreateList(Type type)
		{
			var genericType = typeof (List<>);
			var bindingType = genericType.MakeGenericType(new[] {type});
			return (IList) Activator.CreateInstance(bindingType);
		}

		public static IBindingListView CreateObjectListView(Type type)
		{
			var genericType = typeof (ObjectListView<>);
			var bindingType = genericType.MakeGenericType(new[] {type});
			return (IBindingListView)Activator.CreateInstance(bindingType, CreateList(type));
		}

		public static IBindingListView CreateObjectListView()
		{
			return new ObjectListView(new ArrayList());
		}

		private static IBindingListView ToObjectListView<T>(this IEnumerable<T> enumerable)
		{
			if (typeof (T) == typeof (string))
				return null;
			enumerable = (IEnumerable<T>) ListBindingHelper.GetList(enumerable);
			return ToObjectListView((IList<T>) enumerable.ToList());
		}

		private static IBindingListView CreateObjectListViewViaBindingSource(IEnumerable enumerable)
		{
			var bindingSource = new BindingSource(enumerable, null);
			return bindingSource.Count > 0 ? bindingSource.List.ToObjectListView() : null;
		}

		public static bool BindEnumerable<T>(this BindingSource bindingSource, IEnumerable<T> enumerable, bool setReadonly)
		{
			var showenEnumerable = BindEnumerable(bindingSource, enumerable);
			if (showenEnumerable)
				if (setReadonly && bindingSource.AllowEdit && bindingSource.DataSource is IBindingList)
				{
					if (!(SetReadonly<T>((IBindingList) bindingSource.DataSource)))
						bindingSource.DataSource = new ObjectListView<T>(enumerable.ToList().AsReadOnly());
				}
				else
					bindingSource.AllowNew = !setReadonly;
			return showenEnumerable;
		}

		public static bool BindEnumerable(this BindingSource bindingSource, IEnumerable enumerable, bool setReadonly)
		{
			var showenEnumerable = BindEnumerable(bindingSource, enumerable);
			if (showenEnumerable)
				if (setReadonly && bindingSource.AllowEdit && bindingSource.DataSource is IBindingList)
					SetReadonly(((IBindingList) bindingSource.DataSource));
				else
					bindingSource.AllowNew = !setReadonly;
			return showenEnumerable;
		}

		private static bool BindEnumerable<T>(BindingSource bindingSource, IEnumerable<T> enumerable)
		{
			bool showenEnumerable;
			try
			{
				bindingSource.DataSource = enumerable.ToBindingListView();
				showenEnumerable = bindingSource.Count > 0;
			}
			catch (Exception)
			{
				try
				{
					bindingSource.DataSource = enumerable;
				}
				catch (Exception)
				{
					bindingSource.DataSource = null;
				}
				showenEnumerable = bindingSource.Count > 0;
			}
			return showenEnumerable;
		}

		private static bool BindEnumerable(BindingSource bindingSource, IEnumerable enumerable)
		{
			bool showenEnumerable;
			try
			{
				bindingSource.DataSource = enumerable.ToBindingListView();
				showenEnumerable = bindingSource.Count > 0;
			}
			catch (Exception)
			{
				try
				{
					bindingSource.DataSource = enumerable;
				}
				catch (Exception)
				{
					bindingSource.DataSource = null;
				}
				showenEnumerable = bindingSource.Count > 0;
			}
			return showenEnumerable;
		}

		public static bool SetReadonly(IBindingList bindingList)
		{
			var result = bindingList is ObjectListView;
			if (result)
			{
				((ObjectListView) bindingList).AllowEdit = false;
				((ObjectListView) bindingList).AllowRemove = false;
				((ObjectListView) bindingList).AllowNew = false;
			}
			else
			{
				result = bindingList is DataView;
				if (result)
				{
					((DataView) bindingList).AllowEdit = false;
					((DataView) bindingList).AllowNew = false;
				}
				else
				{
					SetPropertyFalse(bindingList, "AllowEdit");
					SetPropertyFalse(bindingList, "AllowRemove");
					SetPropertyFalse(bindingList, "AllowNew");
				}
			}
			return result;
		}

		private static void SetPropertyFalse(IEnumerable bindingList, string name)
		{
			var propertyInfo = bindingList.GetType().GetProperty(name);
			if (propertyInfo.CanWrite)
				propertyInfo.SetValue(bindingList, false, null);
		}

		public static bool SetReadonly<T>(IBindingList bindingList)
		{
			var result = bindingList is ObjectListView<T>;
			if (result)
			{
				((ObjectListView<T>) bindingList).AllowEdit = false;
				((ObjectListView<T>) bindingList).AllowRemove = false;
				((ObjectListView<T>) bindingList).AllowNew = false;
			}
			else
			{
				result = bindingList is BindingList<T>;
				if (result)
				{
					((BindingList<T>) bindingList).AllowEdit = false;
					((BindingList<T>) bindingList).AllowRemove = false;
					((BindingList<T>) bindingList).AllowNew = false;
				}
				else
					result = SetReadonly(bindingList);
			}
			return result && !bindingList.AllowEdit;
		}

		public static object GetDataSource(this BindingSource bindingSource)
		{
			if (bindingSource.DataSource is BindingSource)
				return GetDataSource((BindingSource) bindingSource.DataSource);
			var objectListView = bindingSource.DataSource as ObjectListView;
			return objectListView == null ? bindingSource.DataSource : GetDataSource(objectListView);
		}

		public static object GetDataSource(this ObjectListView objectListView)
		{
			var bindingSource = objectListView.List as BindingSource;
			if (bindingSource != null)
				return GetDataSource(bindingSource);
			var objectListViewSource = objectListView.List as ObjectListView;
			return objectListViewSource == null ? objectListView.List : GetDataSource(objectListViewSource);
		}
	}
}