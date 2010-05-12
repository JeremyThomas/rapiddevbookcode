
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace JesseJohnston.Tests.Generic
{
	public class NotifyingList<T> : IList<T>
	{
		private List<T> list = new List<T>();

		public event ListChangedEventHandler ListChanged;

		private void OnListChanged(ListChangedType action, int index)
		{
			if (ListChanged != null)
				ListChanged(this, new ListChangedEventArgs(action, index));
		}

		#region IList<T> Members
		public int IndexOf(T item)
		{
			return this.list.IndexOf(item);
		}
		public void Insert(int index, T item)
		{
			this.list.Insert(index, item);
			OnListChanged(ListChangedType.ItemAdded, index);
		}
		public void RemoveAt(int index)
		{
			this.list.RemoveAt(index);
			OnListChanged(ListChangedType.ItemDeleted, index);
		}
		public T this[int index]
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

		#region ICollection<T> Members
		public void Add(T item)
		{
			this.list.Add(item);
			OnListChanged(ListChangedType.ItemAdded, this.list.Count - 1);
		}
		public void Clear()
		{
			this.list.Clear();
			this.OnListChanged(ListChangedType.Reset, -1);
		}
		public bool Contains(T item)
		{
			return this.list.Contains(item);
		}
		public void CopyTo(T[] array, int arrayIndex)
		{
			this.list.CopyTo(array, arrayIndex);
		}
		public int Count
		{
			get { return this.list.Count; }
		}
		public bool IsReadOnly
		{
			get { return false; }
		}
		public bool Remove(T item)
		{
			int index = list.IndexOf(item);

			if (index > -1)
			{
				this.list.Remove(item);
				OnListChanged(ListChangedType.ItemDeleted, index);
				return true;
			}
			else
				return false;
		}
		#endregion

		#region IEnumerable<T> Members
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return list.GetEnumerator();
		}
		#endregion

		#region IEnumerable Members
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return list.GetEnumerator();
		}
		#endregion
	}
}
#endif