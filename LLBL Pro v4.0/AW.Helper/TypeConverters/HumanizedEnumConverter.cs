using System;
using System.ComponentModel;
using System.Globalization;
using Humanizer;

namespace AW.Helper.TypeConverters
{
  /// <summary>
  ///   An Enum Converter that converts to/from strings using Humanizer
  /// </summary>
  [Description("An Enum Converter that converts to/from strings using Humanizer")]
  public class HumanizedEnumConverter : EnumConverter
  {

    public HumanizedEnumConverter(Type type) : base(type)
    {
    }

    /// <summary>
    ///   Adds the enumeration converter if the enum doesn't already have one.
    /// </summary>
    /// <param name="enumType">Type of the enum.</param>
    public static void AddEnumerationConverter(Type enumType)
    {
      GeneralHelper.CheckIsEnum(enumType);
      if (!(TypeDescriptor.GetConverter(enumType) is HumanizedEnumConverter))
        TypeDescriptor.AddAttributes(enumType, new TypeConverterAttribute(typeof (HumanizedEnumConverter)));
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      if (destinationType == typeof (string) && value != null)
        return ((Enum) value).Humanize();
      return base.ConvertTo(context, culture, value, destinationType);
    }

    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
      var s = value as string;
      if (s == null) return base.ConvertFrom(context, culture, value);
      try
      {
        return base.ConvertFrom(context, culture, s);
      }
      catch (FormatException)
      {
        return GeneralHelper.StringToEnum(s, EnumType);
      }
    }
  }
}