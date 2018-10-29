using System;
using System.ComponentModel;
using System.Globalization;

namespace AW.Helper.TypeConverters
{
  public interface IExtendingOriginalConverter
  {
    TypeConverter OriginalConverter { get; set; }
  }

  /// <summary>
  /// To convert using the specific TypeConverter for the type of value being converted rather than and an ancestor type.
  /// For use when a value of a descendant type is assigned to a property with an ancestor type
  /// </summary>
  /// <remarks>Not used by LLBL</remarks>
  public class SpecificTypeConverter : TypeConverter, IExtendingOriginalConverter
  {
    public TypeConverter OriginalConverter { get;  set; }

    public SpecificTypeConverter()
    {
    }

    public SpecificTypeConverter(TypeConverter originalConverter)
    {
      OriginalConverter = originalConverter;
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      var typeConverter = TypeDescriptor.GetConverter(value);
      if (typeConverter.GetType() == GetType())
        return OriginalConverter == null ? base.ConvertTo(context, culture, value, destinationType) : OriginalConverter.ConvertTo(context, culture, value, destinationType);
      if (typeConverter is IExtendingOriginalConverter extendingOriginalConverter) extendingOriginalConverter.OriginalConverter = OriginalConverter;
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