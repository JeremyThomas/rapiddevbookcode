using System;
using System.ComponentModel;

namespace JesseJohnston
{
  /// <summary>
  /// Represents a sort defined by a list item property name and sort direction.
  /// </summary>
  [Serializable]
  internal class SortDescription
  {
    private readonly string name;
    private readonly ListSortDirection dir;
    [NonSerialized] private readonly PropertyDescriptor property;

    /// <summary>
    /// Gets the sort direction.
    /// </summary>
    /// <value>The direction.</value>
    public ListSortDirection Direction
    {
      get { return dir; }
    }

    /// <summary>
    /// Gets the property descriptor (if provided in the constructor).
    /// </summary>
    /// <value>The property descriptor.</value>
    public PropertyDescriptor PropertyDescriptor
    {
      get { return property; }
    }

    /// <summary>
    /// Gets the name of the property that is to be used in sorting the items.
    /// </summary>
    /// <value>The name of the property.</value>
    public string PropertyName
    {
      get { return name; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SortDescription"/> class.
    /// </summary>
    /// <param name="propertyName">Name of the property to sort on.</param>
    /// <param name="direction">The sort direction.</param>
    public SortDescription(string propertyName, ListSortDirection direction)
    {
      if (propertyName == null)
        throw new ArgumentNullException("propertyName");
      if (propertyName == "")
        throw new ArgumentException("propertyName");

      name = propertyName;
      dir = direction;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SortDescription"/> class.
    /// </summary>
    /// <param name="property">The property to sort on.</param>
    /// <param name="direction">The sort direction.</param>
    public SortDescription(PropertyDescriptor property, ListSortDirection direction)
    {
      if (property == null)
        throw new ArgumentNullException("property");

      this.property = property;
      name = property.Name;
      dir = direction;
    }

    /// <summary>
    /// Determines whether the specified <see cref="T:System.Object"></see> is equal to the current <see cref="T:System.Object"></see>.
    /// </summary>
    /// <param name="obj">The <see cref="T:System.Object"></see> to compare with the current <see cref="T:System.Object"></see>.</param>
    /// <returns>
    /// true if the specified <see cref="T:System.Object"></see> is equal to the current <see cref="T:System.Object"></see>; otherwise, false.
    /// </returns>
    public override bool Equals(object obj)
    {
      if (obj == null)
        return false;
      if (obj.GetType() != GetType())
        return false;

      var desc = (SortDescription) obj;

      return desc.name == name && desc.dir == dir;
    }

    /// <summary>
    /// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"></see> is suitable for use in hashing algorithms and data structures like a hash table.
    /// </summary>
    /// <returns>
    /// A hash code for the current <see cref="T:System.Object"></see>.
    /// </returns>
    public override int GetHashCode()
    {
      return (name + dir).GetHashCode();
    }

    /// <summary>
    /// Determines if two <seealso cref="SortDescription"/> objects refer to the same property name and sort direction.
    /// </summary>
    /// <param name="desc1">The first <seealso cref="SortDescription"/>.</param>
    /// <param name="desc2">The second <seealso cref="SortDescription"/>.</param>
    /// <returns>true if the two <seealso cref="SortDescription"/> objects refer to the same property name and sort direction; otherwise false.</returns>
    public static bool operator ==(SortDescription desc1, SortDescription desc2)
    {
      if (ReferenceEquals(desc1, null))
        return ReferenceEquals(desc2, null);
      else if (ReferenceEquals(desc2, null))
        return false;

      return desc1.Equals(desc2);
    }

    /// <summary>
    /// Determines if two <seealso cref="SortDescription"/> objects refer to the different property names or sort directions.
    /// </summary>
    /// <param name="desc1">The first <seealso cref="SortDescription"/>.</param>
    /// <param name="desc2">The second <seealso cref="SortDescription"/>.</param>
    /// <returns>true if the two <seealso cref="SortDescription"/> objects refer to different property names or sort directions; otherwise false.</returns>
    public static bool operator !=(SortDescription desc1, SortDescription desc2)
    {
      return !(desc1 == desc2);
    }
  }
}