using System;
using System.Globalization;
using System.Windows.Data;

namespace AW.Winforms.Helpers.WPF
{
  public class EnumToBooleanConverter : LinkedConverter
  {
    /// <summary>
    ///   Derived classes implement the <see cref="IValueConverter.Convert" /> logic in this method.
    /// </summary>
    protected override object InstanceConvert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return value.Equals(parameter);
    }

    /// <summary>
    ///   Derived classes implement the <see cref="IValueConverter.ConvertBack" /> logic in this method.
    /// </summary>
    protected override object InstanceConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return value.Equals(true) ? parameter : Binding.DoNothing;
    }
  }
}