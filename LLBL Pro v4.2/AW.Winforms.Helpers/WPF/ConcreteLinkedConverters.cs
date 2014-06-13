using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AW.Winforms.Helpers.WPF
{
  /// <summary>
  ///   Converts a True/False value into a <see cref="Visibility.Visible" /> or <see cref="Visibility.Collapsed" /> value.
  /// </summary>
  /// <remarks>
  ///   Not specifying values for the <c>true</c> and <c>false</c> values allows the user to invert the logic declaratively
  ///   by interchange
  ///   the values.
  /// </remarks>
  public class BoolToVisibilityConverter : BoolToEnumConverter<Visibility>
  {
  }

  /// <summary>
  ///   Returns <c>true</c> for a non null value, <c>false</c> for a null value.
  /// </summary>
  public class NullToBoolConverter : LinkedConverter
  {
    /// <summary>
    ///   <see cref="LinkedConverter.InstanceConvert" />
    /// </summary>
    protected override object InstanceConvert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var s = value as string;
      if (s != null)
        return !string.IsNullOrEmpty(s);
      return value != null;
    }

    /// <summary>
    ///   <see cref="LinkedConverter.InstanceConvertBack" />
    /// </summary>
    protected override object InstanceConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }

  /// <summary>
  ///   This class keeps the binding engine happy for nullable types, please see
  ///   http://jeffhandley.com/archive/2008/07/09/binding-to-nullable-values-in-xaml.aspx
  ///   where this code came from.
  /// </summary>
  public class NullableValueConverter : LinkedConverter
  {
    /// <summary>
    ///   <see cref="LinkedConverter.InstanceConvert" />
    /// </summary>
    protected override object InstanceConvert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return value;
    }

    /// <summary>
    ///   <see cref="LinkedConverter.InstanceConvertBack" />
    /// </summary>
    protected override object InstanceConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value == null) return null;
      return string.IsNullOrEmpty(value.ToString()) ? null : value;
    }
  }

  /// <summary>
  ///   http://www.garethevans.com/2010/07/linking-multiple-value-converters-in-wpf-and-silverlight/
  /// </summary>
  public class NegateConverter : LinkedConverter
  {
    #region IValueConverter Members

    /// <summary>
    ///   Derived classes implement the <see cref="IValueConverter.Convert" /> logic in this method.
    /// </summary>
    protected override object InstanceConvert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return !(bool) value;
    }

    /// <summary>
    ///   Derived classes implement the <see cref="IValueConverter.ConvertBack" /> logic in this method.
    /// </summary>
    protected override object InstanceConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return !(bool) value;
    }

    #endregion
  }
}