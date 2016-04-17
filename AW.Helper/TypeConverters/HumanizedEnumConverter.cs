using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;

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
      if (destinationType == typeof (string) && value != null)
        try
        {
          return Enum.IsDefined(_coreEnumType, value) ? ((Enum)Enum.ToObject(_coreEnumType, value)).EnumToString() : string.Empty;
        }
        catch (FileNotFoundException e)
        {
          e.TraceOut();
          var description = GeneralHelper.GetDescription(value);
          if  (!String.IsNullOrEmpty(description))
            return description;
        }
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
      var enumConversion = GeneralHelper.StringToEnum(s, EnumType, false);
      if (enumConversion == null && !_isNullable)
        return base.ConvertFrom(context, culture, s); // To throw an exception
      return enumConversion;
    }
  }
}