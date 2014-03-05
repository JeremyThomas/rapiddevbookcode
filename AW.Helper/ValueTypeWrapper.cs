using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AW.Helper.Annotations;

namespace AW.Helper
{
  public class ValueTypeWrapper<T> : IEquatable<ValueTypeWrapper<T>>, INotifyPropertyChanged
  {
    private T _value;
    public T Value
    {
      get { return _value; }
      set
      {
        if (Equals(value, _value)) return;
        _value = value;
        OnPropertyChanged("Value");
      }
    }

    public static IEnumerable<ValueTypeWrapper<T>> CreateWrapperForBinding(IEnumerable<T> values)
    {
      return values == null ? Enumerable.Empty<ValueTypeWrapper<T>>() : values.Select(data => new ValueTypeWrapper<T> { Value = data });
    }

    public static IEnumerable<T> UnWrap(IEnumerable<ValueTypeWrapper<T>> wrappedValues)
    {
      return wrappedValues.Select(sr => sr.Value);
    }

    public static void Add(ICollection<ValueTypeWrapper<T>> wrappedValues, ValueTypeWrapper<T> wrappedValue)
    {
      if (!wrappedValues.Contains(wrappedValue))
        wrappedValues.Add(wrappedValue);
    }

    public static void Add(ICollection<ValueTypeWrapper<T>> wrappedValues, params T[] values)
    {
      AddRange(wrappedValues, values);
    }

    public static void AddRange(ICollection<ValueTypeWrapper<T>> wrappedValues, IEnumerable<T> values)
    {
      AddRange(wrappedValues, CreateWrapperForBinding(values));
    }

    private static void AddRange(ICollection<ValueTypeWrapper<T>> wrappedValues, IEnumerable<ValueTypeWrapper<T>> newWrappedValues)
    {
      foreach (var wrappedValue in newWrappedValues)
        Add(wrappedValues, wrappedValue);
    }

    public override string ToString()
    {
      return Convert.ToString(Value);
    }

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <returns>
    /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
    /// </returns>
    /// <param name="other">An object to compare with this object.
    ///                 </param>
    public bool Equals(ValueTypeWrapper<T> other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return Equals(other.Value, Value);
    }

    /// <summary>
    /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
    /// </summary>
    /// <returns>
    /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
    /// </returns>
    /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>. 
    ///                 </param><exception cref="T:System.NullReferenceException">The <paramref name="obj"/> parameter is null.
    ///                 </exception><filterpriority>2</filterpriority>
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != typeof (ValueTypeWrapper<T>)) return false;
      return Equals((ValueTypeWrapper<T>) obj);
    }

    /// <summary>
    /// Serves as a hash function for a particular type. 
    /// </summary>
    /// <returns>
    /// A hash code for the current <see cref="T:System.Object"/>.
    /// </returns>
    /// <filterpriority>2</filterpriority>
    public override int GetHashCode()
    {
// ReSharper disable CompareNonConstrainedGenericWithNull
      return Value == null ? 0: Value.GetHashCode();
// ReSharper restore CompareNonConstrainedGenericWithNull
    }

    public static bool operator ==(ValueTypeWrapper<T> left, ValueTypeWrapper<T> right)
    {
      return Equals(left, right);
    }

    public static bool operator !=(ValueTypeWrapper<T> left, ValueTypeWrapper<T> right)
    {
      return !Equals(left, right);
    }

    /// <summary>
    /// True if the type the needs wrapping for databinding.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static bool TypeNeedsWrappingForBinding()
    {
      return ValueTypeWrapper.TypeNeedsWrappingForBinding(typeof(T));
    }

    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged(string propertyName)
    {
      var handler = PropertyChanged;
      if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }
  }

  public class ReadonlyValueTypeWrapper<T>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Object"/> class.
    /// </summary>
    public ReadonlyValueTypeWrapper(T value)
    {
      Value = value;
    }

    public T Value { get; private set; }

    public static IEnumerable<ReadonlyValueTypeWrapper<T>> CreateWrapperForBinding(IEnumerable<T> values)
    {
      return values.Select(data => new ReadonlyValueTypeWrapper<T>(data)).ToList();
    }
  }

  public class ValueTypeWrapper
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Object"/> class.
    /// </summary>
    public ValueTypeWrapper(object value)
    {
      Value = value;
    }

    public object Value { get; private set; }

    public static List<ValueTypeWrapper> CreateWrapperForBinding(IEnumerable values)
    {
      return values.Cast<object>().Select(data => new ValueTypeWrapper(data)).ToList();
    }

    /// <summary>
    /// True if the type the needs wrapping for databinding.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <returns></returns>
    public static bool TypeNeedsWrappingForBinding(Type type)
    {
      return Type.GetTypeCode(type) != TypeCode.Object;
    }
  }
}