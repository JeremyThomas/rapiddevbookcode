using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;

namespace AW.Helper.TypeConverters
{
  /// <summary>
  ///   Converter with as core type System.Enum, for mapping a field with a .NET type System.Enum onto a numeric string database field
  /// </summary>
  /// <remarks>
  ///   Unfortunately a subclass is need for every enum as the LLBL designer doesn't support generic type converters
  /// </remarks>
  /// <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=7355" />
  /// <example>
  ///   Usage public class MyEnumConverter : EnumerationConverter<!--MyEnum-->{}
  /// </example>
  /// <typeparam name="T"> </typeparam>
  [Description("Converter with as core type System.Enum, for mapping a field with a .NET type System.Enum onto a numeric database field")]
  public abstract class EnumerationConverter<T> : TypeConverter
  {
    private static readonly IList<TypeCode> ValidTypeCodes = TypeConverterHelper.IntegralTypes;

    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      if (sourceType == null)
        throw new ArgumentNullException("sourceType");
      return ValidTypeCodes.Contains(Type.GetTypeCode(sourceType));
    }

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      if (destinationType == null)
        throw new ArgumentNullException("destinationType");
      return ValidTypeCodes.Contains(Type.GetTypeCode(destinationType));
    }

    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
      if (value == null)
        return null;
      var valueTypeCode = Type.GetTypeCode(value.GetType());
      if (valueTypeCode == TypeCode.DBNull)
        return null;
      if (valueTypeCode == TypeCode.Decimal)
        value = Convert.ToUInt64(value);
      if (ValidTypeCodes.Contains(valueTypeCode))
        return Enum.ToObject(typeof (T), value);
      throw new NotSupportedException();
    }

    public override object ConvertTo(ITypeDescriptorContext context,
                                     CultureInfo culture,
                                     object value,
                                     Type destinationType)
    {
      if (destinationType == null)
        throw new ArgumentNullException("destinationType");
      if (value == null)
        throw new ArgumentNullException("value");
      Debug.Assert(value is T);
      return Convert.ChangeType(value, destinationType, culture ?? CultureInfo.InvariantCulture);
    }

    public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
    {
      return default(T);
    }
  }
}