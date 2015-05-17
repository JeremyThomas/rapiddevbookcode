using System;
using System.ComponentModel;
using System.Globalization;

namespace AW.Helper.TypeConverters
{
  public class SpecificTypeConverter : TypeConverter
  {
    private readonly TypeConverter _originalConverter;

    public SpecificTypeConverter()
    {
    }

    public SpecificTypeConverter(TypeConverter originalConverter)
    {
      _originalConverter = originalConverter;
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      var typeConverter = TypeDescriptor.GetConverter(value);
      if (typeConverter.GetType() == GetType())
        return _originalConverter == null ? base.ConvertTo(context, culture, value, destinationType) : _originalConverter.ConvertTo(context, culture, value, destinationType);
      return typeConverter.ConvertTo(context, culture, value, destinationType);
    }

    /// <summary>
    ///   Adds the SingleValueCollection converter if the Collection doesn't already have one.
    /// </summary>
    /// <param name="targetTypes"></param>
    public static void AddConverter(params Type[] targetTypes)
    {
      TypeConverterHelper.AddConverter<SpecificTypeConverter>(targetTypes);
    }
  }
}