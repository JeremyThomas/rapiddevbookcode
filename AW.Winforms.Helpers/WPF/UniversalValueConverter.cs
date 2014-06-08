using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;

namespace AW.Winforms.Helpers.WPF
{
  /// <summary>
  ///   http://www.scottlogic.co.uk/blog/colin/2010/07/a-universal-value-converter-for-wpf/
  ///   http://wpfconverters.codeplex.com/wikipage?title=User%20Documentation#TypeConverter
  /// </summary>
  public class UniversalValueConverter : LinkedConverter
  {
    /// <summary>
    ///   Derived classes implement the <see cref="IValueConverter.Convert" /> logic in this method.
    /// </summary>
    protected override object InstanceConvert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (targetType == typeof (object))
        return value; //No need to convert to object

      if ((value is IConvertible) || (value == null))
      {
        try
        {
          return System.Convert.ChangeType(value, targetType, culture);
        }
        catch (Exception)
        {
          return value;
        }
      }
      // obtain the converter for the target type
      var converter = TypeDescriptor.GetConverter(targetType);
      if (converter == null)
        return value;
      try
      {
        // determine if the supplied value is of a suitable type

        if (converter.CanConvertFrom(value.GetType()))
        {
          // return the converted value
          return converter.ConvertFrom(value);
        }
        // try to convert from the string representation
        return converter.ConvertFrom(value.ToString());
      }
      catch (Exception)
      {
        return value;
      }
    }

    /// <summary>
    ///   Derived classes implement the <see cref="IValueConverter.ConvertBack" /> logic in this method.
    /// </summary>
    protected override object InstanceConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return value.GetType() == targetType ? value : parameter;
    }
  }
}