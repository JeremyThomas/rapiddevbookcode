using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace JesseJohnston
{
  /// <summary>
  /// Collection of <seealso cref="SortDescription"/> objects for a specific list item type.
  /// </summary>
  [Serializable]
  internal class SortDescriptionCollection : ICollection<SortDescription>
  {
    private readonly Type targetType;
    private readonly List<SortDescription> descriptions = new List<SortDescription>();

    /// <summary>
    /// Gets the <see cref="SortDescription"/> at the specified index.
    /// </summary>
    /// <value></value>
    public SortDescription this[int index]
    {
      get { return descriptions[index]; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SortDescriptionCollection"/> class.
    /// </summary>
    /// <param name="targetType">Type of the list item.</param>
    public SortDescriptionCollection(Type targetType)
    {
      if (targetType == null)
        throw new ArgumentNullException("targetType");

      this.targetType = targetType;
      descriptions = new List<SortDescription>();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SortDescriptionCollection"/> class.
    /// </summary>
    /// <param name="targetType">Type of the list item.</param>
    /// <param name="sorts">A set of <seealso cref="ListSortDescription"/> objects to populate the collection with.</param>
    public SortDescriptionCollection(Type targetType, ListSortDescriptionCollection sorts)
    {
      if (targetType == null)
        throw new ArgumentNullException("targetType");

      this.targetType = targetType;
      if (sorts != null)
        foreach (ListSortDescription desc in sorts)
          Add(new SortDescription(desc.PropertyDescriptor, desc.SortDirection));
    }

    /// <summary>
    /// Determines whether the collection contains a <seealso cref="SortDescription"/> for the specified property name.
    /// </summary>
    /// <param name="propertyName">Name of the property.</param>
    /// <returns>
    /// 	<c>true</c> if the collection contains a corresponding <seealso cref="SortDescription"/>; otherwise, <c>false</c>.
    /// </returns>
    public bool Contains(string propertyName)
    {
      return descriptions.Find(delegate(SortDescription s) { return s.PropertyName == propertyName; }) != null;
    }

    /// <summary>
    /// Creates a <seealso cref="ListSortDescriptionCollection"/> from the sort descriptions in the collection.
    /// </summary>
    /// <returns>
    /// A <see cref="ListSortDescriptionCollection"/> representing the sort descriptions.
    /// </returns>
    public ListSortDescriptionCollection GetListSortDescriptions()
    {
      if (targetType == null)
        throw new ArgumentNullException("targetType");

      var props = TypeDescriptor.GetProperties(targetType);

      var sorts = new ListSortDescription[descriptions.Count];
      for (var i = 0; i < descriptions.Count; i++)
      {
        var desc = descriptions[i];
        if (desc.PropertyDescriptor != null)
          sorts[i] = new ListSortDescription(desc.PropertyDescriptor, desc.Direction);
        else
          sorts[i] = new ListSortDescription(props.Find(desc.PropertyName, true), desc.Direction);
      }

      return new ListSortDescriptionCollection(sorts);
    }

    #region ICollection<SortDescription> Members

    /// <summary>
    /// Adds an item to the collection.
    /// </summary>
    /// <param name="item">The object to add to the collection.</param>
    /// <exception cref="T:System.ArgumentException">The property specified in the <seealso cref="SortDescription"/> is not a property of the target (list item) type.</exception>
    public void Add(SortDescription item)
    {
      if (item == null)
        throw new ArgumentNullException("item");
      if (item.PropertyDescriptor == null && TypeDescriptor.GetProperties(targetType).Find(item.PropertyName, true) == null)
        throw new ArgumentException("Property does not exist in the target type", "item");

      descriptions.Add(item);
    }

    /// <summary>
    /// Removes all items from the collection.
    /// </summary>
    public void Clear()
    {
      descriptions.Clear();
    }

    /// <summary>
    /// Determines whether the collection contains a specific value.
    /// </summary>
    /// <param name="item">The object to locate in the collection.</param>
    /// <returns>
    /// true if item is found in the collection; otherwise, false.
    /// </returns>
    public bool Contains(SortDescription item)
    {
      if (item == null)
        throw new ArgumentNullException("item");
      return descriptions.Contains(item);
    }

    /// <summary>
    /// Copies the elements of the collection to an <see cref="T:System.Array"></see>, starting at a particular <see cref="T:System.Array"></see> index.
    /// </summary>
    /// <param name="array">The one-dimensional <see cref="T:System.Array"></see> that is the destination of the elements copied from the collection. The <see cref="T:System.Array"></see> must have zero-based indexing.</param>
    /// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
    /// <exception cref="T:System.ArgumentOutOfRangeException">arrayIndex is less than 0.</exception>
    /// <exception cref="T:System.ArgumentNullException">array is null.</exception>
    /// <exception cref="T:System.ArgumentException">array is multidimensional.-or-arrayIndex is equal to or greater than the length of array.-or-The number of elements in the source collection is greater than the available space from arrayIndex to the end of the destination array.-or-Type T cannot be cast automatically to the type of the destination array.</exception>
    public void CopyTo(SortDescription[] array, int arrayIndex)
    {
      descriptions.CopyTo(array, 0);
    }

    /// <summary>
    /// Gets the number of elements contained in the collection.
    /// </summary>
    /// <value></value>
    /// <returns>The number of elements contained in the collection.</returns>
    public int Count
    {
      get { return descriptions.Count; }
    }

    bool ICollection<SortDescription>.IsReadOnly
    {
      get { return false; }
    }

    /// <summary>
    /// Removes the first occurrence of a specific object from the collection.
    /// </summary>
    /// <param name="item">The object to remove from the collection.</param>
    /// <returns>
    /// true if item was successfully removed from the collection; otherwise, false. This method also returns false if item is not found in the original collection.
    /// </returns>
    public bool Remove(SortDescription item)
    {
      if (item == null)
        throw new ArgumentNullException("item");
      return descriptions.Remove(item);
    }

    #endregion

    #region IEnumerable<SortDescription> Members

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.Collections.Generic.IEnumerator`1"></see> that can be used to iterate through the collection.
    /// </returns>
    public IEnumerator<SortDescription> GetEnumerator()
    {
      return descriptions.GetEnumerator();
    }

    #endregion

    #region IEnumerable Members

    IEnumerator IEnumerable.GetEnumerator()
    {
      return descriptions.GetEnumerator();
    }

    #endregion
  }
}