using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace JesseJohnston
{
  /// <summary>
  /// Collection of <seealso cref="IComparer"/> objects to compare property values for a specified type.
  /// </summary>
  [Serializable]
  public class PropertyComparerCollection : IDictionary<string, IComparer>
  {
    private readonly Dictionary<string, IComparer> comparers = new Dictionary<string, IComparer>();
    private readonly List<string> properties = new List<string>();
    private bool suppressEvents;
    private bool collectionChanged;

    internal event EventHandler CollectionChanged;

    internal PropertyComparerCollection(Type itemType)
    {
      if (itemType == null)
        throw new ArgumentNullException("itemType");

      foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(itemType))
        properties.Add(prop.Name);
    }

    internal void BeginUpdate()
    {
      suppressEvents = true;
    }

    internal void EndUpdate()
    {
      suppressEvents = false;
      if (collectionChanged)
      {
        collectionChanged = false;
        OnCollectionChanged();
      }
    }

    #region IDictionary<string,IComparer> Members

    /// <summary>
    /// Adds an <see cref="IComparer"/> for the provided property name.
    /// </summary>
    /// <param name="key">The property name.</param>
    /// <param name="value">The <seealso cref="IComparer"/> to use when comparing values of the property.</param>
    /// <exception cref="T:System.ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Generic.IDictionary`2"></see>.</exception>
    /// <exception cref="T:System.ArgumentNullException">key is null.</exception>
    public void Add(string key, IComparer value)
    {
      comparers.Add(key, value);
      OnCollectionChanged();
    }

    /// <summary>
    /// Determines whether the collection contains an <see cref="IComparer"/> for the specified property name.
    /// </summary>
    /// <param name="key">The property name.</param>
    /// <returns>
    /// <b>true</b> if the contains contains an element with the key; otherwise, <b>false</b>.
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">key is null.</exception>
    public bool ContainsKey(string key)
    {
      return comparers.ContainsKey(key);
    }

    ICollection<string> IDictionary<string, IComparer>.Keys
    {
      get { return comparers.Keys; }
    }

    /// <summary>
    /// Removes the <see cref="IComparer"/> associated with the specified property name from the collection.
    /// </summary>
    /// <param name="key">The property name associated with the <seealso cref="IComparer"/> to remove.</param>
    /// <returns>
    /// <b>true</b> if the element is successfully removed; otherwise, <b>false</b>.  This method also returns false if key was not found in the original collection.
    /// </returns>
    /// <exception cref="T:System.ArgumentNullException">key is null.</exception>
    public bool Remove(string key)
    {
      var result = comparers.Remove(key);
      OnCollectionChanged();
      return result;
    }

    bool IDictionary<string, IComparer>.TryGetValue(string key, out IComparer value)
    {
      return comparers.TryGetValue(key, out value);
    }

    ICollection<IComparer> IDictionary<string, IComparer>.Values
    {
      get { return comparers.Values; }
    }

    /// <summary>
    /// Gets or sets the <see cref="IComparer"/> for the specified property name.
    /// </summary>
    public IComparer this[string key]
    {
      get
      {
        if (comparers.ContainsKey(key))
          return comparers[key];
        else
          return null;
      }
      set
      {
        if (key == null)
          throw new ArgumentNullException("key");
        if (key == "")
          throw new ArgumentException("key");

        var containsKey = comparers.ContainsKey(key);
        if ((!containsKey && value != null) ||
            (containsKey && value != comparers[key]))
        {
          if (value == null)
            comparers.Remove(key);
          else
          {
            if (!HasProperty(key))
              throw new ArgumentException("key");

            comparers[key] = value;
          }
          OnCollectionChanged();
        }
      }
    }

    #endregion

    #region ICollection<KeyValuePair<string,IComparer>> Members

    void ICollection<KeyValuePair<string, IComparer>>.Add(KeyValuePair<string, IComparer> item)
    {
      ((ICollection<KeyValuePair<string, IComparer>>) comparers).Add(item);
      OnCollectionChanged();
    }

    /// <summary>
    /// Removes all <see cref="IComparer"/>s from the collection.
    /// </summary>
    public void Clear()
    {
      comparers.Clear();
      OnCollectionChanged();
    }

    bool ICollection<KeyValuePair<string, IComparer>>.Contains(KeyValuePair<string, IComparer> item)
    {
      return ((ICollection<KeyValuePair<string, IComparer>>) comparers).Contains(item);
    }

    void ICollection<KeyValuePair<string, IComparer>>.CopyTo(KeyValuePair<string, IComparer>[] array, int arrayIndex)
    {
      ((ICollection<KeyValuePair<string, IComparer>>) comparers).CopyTo(array, arrayIndex);
    }

    /// <summary>
    /// Gets the number of <see cref="IComparer"/>s contained in the collection.
    /// </summary>
    /// <returns>The number of elements contained in the collection.</returns>
    public int Count
    {
      get { return comparers.Count; }
    }

    bool ICollection<KeyValuePair<string, IComparer>>.IsReadOnly
    {
      get { return false; }
    }

    bool ICollection<KeyValuePair<string, IComparer>>.Remove(KeyValuePair<string, IComparer> item)
    {
      var result = ((ICollection<KeyValuePair<string, IComparer>>) comparers).Remove(item);
      OnCollectionChanged();
      return result;
    }

    #endregion

    #region IEnumerable<KeyValuePair<string,IComparer>> Members

    IEnumerator<KeyValuePair<string, IComparer>> IEnumerable<KeyValuePair<string, IComparer>>.GetEnumerator()
    {
      return ((IEnumerable<KeyValuePair<string, IComparer>>) comparers).GetEnumerator();
    }

    #endregion

    #region IEnumerable Members

    IEnumerator IEnumerable.GetEnumerator()
    {
      return ((IEnumerable) comparers).GetEnumerator();
    }

    #endregion

    private bool HasProperty(string propertyName)
    {
      return properties.Contains(propertyName);
    }

    private void OnCollectionChanged()
    {
      if (CollectionChanged != null)
        if (suppressEvents)
          collectionChanged = true;
        else
          CollectionChanged(this, EventArgs.Empty);
    }
  }
}