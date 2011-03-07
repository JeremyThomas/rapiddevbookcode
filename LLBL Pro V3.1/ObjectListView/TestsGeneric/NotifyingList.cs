#pragma warning disable 1591	// Missing XML comment

#if TEST
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace JesseJohnston.Tests.Generic
{
  public class NotifyingList<T> : IList<T>
  {
    private readonly List<T> list = new List<T>();

    public event ListChangedEventHandler ListChanged;

    private void OnListChanged(ListChangedType action, int index)
    {
      if (ListChanged != null)
        ListChanged(this, new ListChangedEventArgs(action, index));
    }

    #region IList<T> Members

    public int IndexOf(T item)
    {
      return list.IndexOf(item);
    }

    public void Insert(int index, T item)
    {
      list.Insert(index, item);
      OnListChanged(ListChangedType.ItemAdded, index);
    }

    public void RemoveAt(int index)
    {
      list.RemoveAt(index);
      OnListChanged(ListChangedType.ItemDeleted, index);
    }

    public T this[int index]
    {
      get { return list[index]; }
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
      list.Add(item);
      OnListChanged(ListChangedType.ItemAdded, list.Count - 1);
    }

    public void Clear()
    {
      list.Clear();
      OnListChanged(ListChangedType.Reset, -1);
    }

    public bool Contains(T item)
    {
      return list.Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
      list.CopyTo(array, arrayIndex);
    }

    public int Count
    {
      get { return list.Count; }
    }

    public bool IsReadOnly
    {
      get { return false; }
    }

    public bool Remove(T item)
    {
      var index = list.IndexOf(item);

      if (index > -1)
      {
        list.Remove(item);
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

    IEnumerator IEnumerable.GetEnumerator()
    {
      return list.GetEnumerator();
    }

    #endregion
  }
}

#endif