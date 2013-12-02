using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace AW.Helper.TypeConverters
{
  /// <summary>
  ///   Base Converter with as core type System.Enum, for mapping a field with a .NET type System.Enum onto a string database
  ///   field
  /// </summary>
  /// <remarks>Unfortunately a subclass is need for every enum as the LLBL designer doesn't support generic type converters</remarks>
  /// <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=7355" />
  /// <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=7945" />
  /// <see cref="http://www.llblgen.com/documentation/2.6/hh_start.htm" />
  /// <example>
  ///   Usage public class MyEnumConverter : EnumConverter<!--MyEnum-->{}
  /// </example>
  /// <typeparam name="T">System.Enum</typeparam>
  [Description("Converter with as core type System.Enum, for mapping a field with a .NET type System.Enum onto a numeric or string database field")]
  public class BaseEnumConverter<T> : EnumConverter where T : struct
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEnumConverter{T}"/> class.
    /// </summary>
    public BaseEnumConverter() : base(typeof (T))
    {
    }

    /// <summary>
    /// Converts the specified value object to an enumeration object.
    /// </summary>
    /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
    /// <param name="culture">An optional <see cref="T:System.Globalization.CultureInfo" />. If not supplied, the current culture is assumed.</param>
    /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
    /// <returns>
    /// An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.
    /// </returns>
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
      return value == null ? null : base.ConvertFrom(context, culture, value);
    }

    /// <summary>
    /// Creates an instance of the type that this <see cref="T:System.ComponentModel.TypeConverter"/> is associated with, using the specified context, given a set of property values for the object.
    /// </summary>
    /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> that provides a format context.</param>
    /// <param name="propertyValues">An <see cref="T:System.Collections.IDictionary"/> of new property values.</param>
    /// <returns>
    /// An <see cref="T:System.Object"/> representing the given <see cref="T:System.Collections.IDictionary"/>, or null if the object cannot be created. This method always returns null.
    /// </returns>
    public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
    {
      return default(T);
    }

  }
}