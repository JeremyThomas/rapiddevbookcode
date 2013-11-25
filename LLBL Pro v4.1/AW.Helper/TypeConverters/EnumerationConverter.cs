using System;
using System.ComponentModel;
using System.Globalization;
using Humanizer;

namespace AW.Helper.TypeConverters
{
  public class EnumerationConverter : EnumConverter

  {
    public EnumerationConverter(Type type) : base(type)
    {
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      if (destinationType == typeof (string) && value != null)
      {
        return ((Enum) value).Humanize();
      }
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
        return GeneralHelper.StringToEnum(EnumType, s);
      }
    }
  }
}