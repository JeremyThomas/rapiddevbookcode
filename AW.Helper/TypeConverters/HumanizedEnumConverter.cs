using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;

namespace AW.Helper.TypeConverters
{
  /// <summary>
  ///   An Enum Converter that converts to/from strings using Humanizer.
  /// </summary>
  [Description("An Enum Converter that converts to/from strings using Humanizer")]
  public class HumanizedEnumConverter : EnumConverter
  {
    private readonly Type _coreEnumType;
    private readonly bool _isNullable;
    private static bool _humanizerNotLoading;

    /// <summary>
    ///   Initializes a new instance of the <see cref="HumanizedEnumConverter" /> class.
    /// </summary>
    /// <param name="type">
    ///   A <see cref="T:System.Type" /> that represents the type of enumeration to associate with this
    ///   enumeration converter.
    /// </param>
    public HumanizedEnumConverter(Type type) : base(type)
    {
      _coreEnumType = MetaDataHelper.GetCoreType(type);
      _isNullable = _coreEnumType != type;
    }

    /// <summary>
    ///   Adds the enumeration converter if the enum doesn't already have one.
    /// </summary>
    /// <param name="enumType">Type of the enum.</param>
    public static void AddEnumerationConverter(Type enumType)
    {
      var coreType = MetaDataHelper.GetCoreType(enumType);
      GeneralHelper.CheckIsEnum(coreType);
      TypeConverterHelper.AddConverter(typeof(HumanizedEnumConverter), enumType, coreType);
    }

    /// <summary>
    ///   Converts the given value object to the specified destination type.
    ///   When the converting to string and the enum is not defined then return empty string rather than the number
    /// </summary>
    /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
    /// <param name="culture">
    ///   An optional <see cref="T:System.Globalization.CultureInfo" />. If not supplied, the current
    ///   culture is assumed.
    /// </param>
    /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
    /// <param name="destinationType">The <see cref="T:System.Type" /> to convert the value to.</param>
    /// <returns>
    ///   An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.
    /// </returns>
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      if (destinationType == typeof(string) && value != null)
        if (Enum.IsDefined(_coreEnumType, value))
        {
          var theEnum = (Enum) Enum.ToObject(_coreEnumType, value);
          if (_humanizerNotLoading)
          {
            var description = MetaDataHelper.GetDisplayNameOrDescription(theEnum);
            if (!String.IsNullOrEmpty(description))
              return description;
          }
          else
            try
            {
              return theEnum.EnumToString();
            }
            catch (FileNotFoundException e)
            {
              _humanizerNotLoading = true;
              e.TraceOut();
              var description = MetaDataHelper.GetDisplayNameOrDescription(theEnum);
              if (!String.IsNullOrEmpty(description))
                return description;
            }
        }
        else return string.Empty;
      return base.ConvertTo(context, culture, value, destinationType);
    }

    /// <summary>
    ///   Converts the specified value object to an enumeration object.
    /// </summary>
    /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
    /// <param name="culture">
    ///   An optional <see cref="T:System.Globalization.CultureInfo" />. If not supplied, the current
    ///   culture is assumed.
    /// </param>
    /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
    /// <returns>
    ///   An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.
    /// </returns>
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
      var s = value as string;
      if (s == null) return base.ConvertFrom(context, culture, value);
      object enumConversion;
      if (_humanizerNotLoading)
        enumConversion = Enum.IsDefined(EnumType, s) ? base.ConvertFrom(context, culture, s) : DisplayNameOrDescriptionToEnum(s);
      else
        try
        {
          enumConversion = GeneralHelper.StringToEnum(s, EnumType, false);
        }
        catch (FileNotFoundException e)
        {
          _humanizerNotLoading = true;
          e.TraceOut();
          enumConversion = Enum.IsDefined(EnumType, s) ? base.ConvertFrom(context, culture, s) : DisplayNameOrDescriptionToEnum(s);
        }
      if (enumConversion == null && !_isNullable)
        return base.ConvertFrom(context, culture, s); // To throw an exception
      return enumConversion;
    }

    private Enum DisplayNameOrDescriptionToEnum(string s)
    {
      return Enum.GetValues(EnumType).Cast<Enum>().FirstOrDefault(enumValue =>
        string.Equals(MetaDataHelper.GetDisplayNameOrDescription(enumValue), s, StringComparison.OrdinalIgnoreCase));
    }
  }
}