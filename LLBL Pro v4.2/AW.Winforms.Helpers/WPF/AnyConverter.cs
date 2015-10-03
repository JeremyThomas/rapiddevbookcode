using System;
using System.Collections;
using System.Globalization;
using System.Windows.Data;
using AW.Helper;

namespace AW.Winforms.Helpers.WPF
{
  public class AnyConverter : LinkedConverter
  {
    #region Overrides of LinkedConverter

    /// <summary>
    ///   Derived classes implement the <see cref="IValueConverter.Convert" /> logic in this method.
    /// </summary>
    protected override object InstanceConvert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var enumerable = value as IEnumerable;
      return enumerable != null && LinqHelper.Any(enumerable);
    }

    /// <summary>
    ///   Derived classes implement the <see cref="IValueConverter.ConvertBack" /> logic in this method.
    /// </summary>
    protected override object InstanceConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}