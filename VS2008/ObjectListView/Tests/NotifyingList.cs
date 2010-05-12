
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;
using System.ComponentModel;

namespace JesseJohnston.Tests
{
	public class NotifyingList : IList
	{
		private ArrayList list = new ArrayList();

		public event ListChangedEventHandler ListChanged;

		private void OnListChanged(ListChangedType action, int index)
		{
			if (ListChanged != null)
				ListChanged(this, new ListChangedEventArgs(action, index));
		}

		#region IList Members
		public int Add(object value)
		{
			int index = list.Add(value);
			OnListChanged(ListChangedType.ItemAdded, index);
			return index;
		}
		public void Clear()
		{
			list.Clear();
			OnListChanged(ListChangedType.Reset, -1);
		}
		public bool Contains(object value)
		{
			return list.Contains(value);
		}
		public int IndexOf(object value)
		{
			return list.IndexOf(value);
		}
		public void Insert(int index, object value)
		{
			list.Insert(index, value);
			OnListChanged(ListChangedType.ItemAdded, index);
		}
		public bool IsFixedSize
		{
			get { return false; }
		}
		public bool IsReadOnly
		{
			get { return false; }
		}
		public void Remove(object value)
		{
			int index = list.IndexOf(value);
			list.Remove(value);
			OnListChanged(ListChangedType.ItemDeleted, index);
		}
		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
			OnListChanged(ListChangedType.ItemDeleted, index);
		}
		public object this[int index]
		{
			get
			{
				return list[index];
			}
			set
			{
				list[index] = value;
				OnListChanged(ListChangedType.ItemChanged, index);
			}
		}
		#endregion

		#region ICollection Members
		public void CopyTo(Array array, int index)
		{
			list.CopyTo(array, index);
		}
		public int Count
		{
			get { return list.Count; }
		}
		public bool IsSynchronized
		{
			get { return false; }
		}
		public object SyncRoot
		{
			get { return list; }
		}
		#endregion

		#region IEnumerable Members
		public IEnumerator GetEnumerator()
		{
			return list.GetEnumerator();
		}
		#endregion
	}
}
#endif