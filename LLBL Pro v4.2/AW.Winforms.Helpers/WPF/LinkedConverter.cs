using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace AW.Winforms.Helpers.WPF
{
  /// <summary>
  ///   Base class for all linked converters.
  ///   http://www.level533.com/2011/05/combining-value-converters-in-silverlight-and-wpf/
  ///   http://www.thejoyofcode.com/WPF_Quick_Tip_Converters_as_MarkupExtensions.aspx
  ///   http://www.scottlogic.co.uk/blog/colin/2010/07/a-universal-value-converter-for-wpf/
  ///   http://drwpf.com/blog/2009/03/17/tips-and-tricks-making-value-converters-more-accessible-in-markup/
  /// </summary>
  public abstract class LinkedConverter : MarkupExtension, IValueConverter
  {
    #region Overrides of MarkupExtension

    /// <summary>
    ///   When implemented in a derived class, returns an object that is set as the value of the target property for this
    ///   markup extension.
    /// </summary>
    /// <returns>
    ///   The object value to set on the property where the extension is applied.
    /// </returns>
    /// <param name="serviceProvider">Object that can provide services for the markup extension.</param>
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
      return this;
    }

    #endregion

    private IValueConverter _linkedConverter;

    /// <summary>
    ///   A reference to a <see cref="LinkedConverter" /> to process the value before this instance process the value in
    ///   <see cref="IValueConverter.Convert" />.
    /// </summary>
    /// <remarks>
    ///   For the <see cref="IValueConverter.ConvertBack" /> operation, this instance process the value before hand.
    /// </remarks>
    public IValueConverter Link
    {
      get { return _linkedConverter; }
      set { _linkedConverter = value; }
    }

    /// <summary>
    ///   An optional <see cref="System.Type" /> value to pass to the <see cref="InstanceConvert" /> method of the chained
    ///   converter if the <see cref="Link" />
    ///   property is set.
    /// </summary>
    /// <remarks>
    ///   Normally this value is ignored as it is in most implementations of <see cref="IValueConverter.Convert" />.
    /// </remarks>
    [TypeConverter(typeof (StringToTypeConverter))]
    public Type OverrideType { get; set; }

    /// <summary>
    ///   An optional <see cref="System.Type" /> value to pass to the <see cref="InstanceConvertBack" /> method of this
    ///   instance if the <see cref="Link" />
    ///   property is set.
    /// </summary>
    /// <remarks>
    ///   Normally this value is ignored as it is in most implementations of <see cref="IValueConverter.ConvertBack" />.
    /// </remarks>
    [TypeConverter(typeof (StringToTypeConverter))]
    public Type BackOverrideType { get; set; }

    /// <summary>
    ///   Derived classes implement the <see cref="IValueConverter.Convert" /> logic in this method.
    /// </summary>
    protected abstract object InstanceConvert(object value, Type targetType, object parameter, CultureInfo culture);

    /// <summary>
    ///   Derived classes implement the <see cref="IValueConverter.ConvertBack" /> logic in this method.
    /// </summary>
    protected abstract object InstanceConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

    /// <summary>
    ///   Implementation of <see cref="IValueConverter.Convert" />.
    ///   First calls the chained converter if the <see cref="Link" /> property is set before processing the value.
    /// </summary>
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (_linkedConverter != null)
      {
        // Linked converter is set, this is not the last in the chain

        // call the linked converter, i.e. the next in the chain
        value = _linkedConverter.Convert(value, OverrideType ?? targetType, parameter, culture);
      }

      // at the end (or beginning, depending on how you look at it) of the chain, or this could be an instance that is not linked,
      // convert it in the overriding class
      return InstanceConvert(value, targetType, parameter, culture);
    }

    /// <summary>
    ///   Implementation of <see cref="IValueConverter.ConvertBack" />.
    ///   First calls the chained converter if the <see cref="Link" /> property is set before processing the value.
    /// </summary>
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      // this is similar logic of the Convert method, only this works for converting the value back in two way binding

      if (_linkedConverter != null)
      {
        // The linked converters will be called in reverse order for the ConvertBack logic.
        value = InstanceConvertBack(value, BackOverrideType ?? targetType, parameter, culture);
      }

      return InstanceConvertBack(value, targetType, parameter, culture);
    }
  }

  /// <summary>
  ///   Used for assigning a <c>true</c> or <c>false</c> value to two values from an arbitrary enumerated value,
  ///   i.e. a class based on <see cref="System.Enum" />.
  /// </summary>
  /// <typeparam name="TEnum">An enumerated value, e.g. <see cref="System.Windows.Visibility" />.</typeparam>
  public abstract class BoolToEnumConverter<TEnum> : LinkedConverter where TEnum : struct
  {
    /// <summary />
    protected object BoxedTrue;

    /// <summary />
    protected object BoxedFalse;

    /// <summary>
    ///   A string value from the TEnum values for <c>true</c>.  Use just the value name, not the name of the enum itself.
    ///   For example, &quot;<c>Visible</c>&quot; for TEnum = Visibility.
    /// </summary>
    /// <remarks>
    ///   This enum value is what boolean <c>true</c> is converted to.
    /// </remarks>
    public string TrueValue
    {
      get { return BoxedTrue.ToString(); }

      set { BoxedTrue = Enum.Parse(typeof (TEnum), value, false); }
    }

    /// <summary>
    ///   A string value from the TEnum values for <c>true</c>.  Use just the value name, not the name of the enum itself.
    ///   For example, &quot;<c>Hidden</c>&quot; for TEnum = Visibility.
    /// </summary>
    /// <remarks>
    ///   This enum value is what boolean <c>false</c> is converted to.
    /// </remarks>
    public string FalseValue
    {
      get { return BoxedFalse.ToString(); }
      set { BoxedFalse = Enum.Parse(typeof (TEnum), value, false); }
    }

    /// <summary>
    ///   Convert a <c>true</c> or <c>false</c> value to corresponding values of the enum specified by <see cref="TrueValue" />
    ///   or <see cref="FalseValue" />.
    /// </summary>
    protected override object InstanceConvert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (!(value is bool))
        return null;
      return (TEnum) ((bool) value ? BoxedTrue : BoxedFalse);
    }

    /// <summary>
    ///   Convert an enum value back to <c>true</c> or <c>false</c>.
    /// </summary>
    protected override object InstanceConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (!(value is TEnum))
        return null;
      if (Equals(value, BoxedTrue)) return true;
      if (Equals(value, BoxedFalse)) return false;
      return null;
    }
  }
}