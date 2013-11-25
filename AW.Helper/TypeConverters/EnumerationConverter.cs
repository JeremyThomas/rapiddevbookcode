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
      if (value is string)
        try
        {
          return base.ConvertFrom(context, culture, value);
        }
        catch (FormatException)
        {
          var strValue = (string) value;
          GeneralHelper.StringToEnum(EnumType, strValue);
          throw;
        }
      return base.ConvertFrom(context, culture, value);
    }
  }
}