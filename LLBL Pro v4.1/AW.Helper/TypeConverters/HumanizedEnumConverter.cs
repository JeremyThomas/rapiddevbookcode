﻿using System;
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
    private readonly Type _coreEnumType;
    private readonly bool _isNullable;
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
      if (!(TypeDescriptor.GetConverter(enumType) is HumanizedEnumConverter))
        TypeDescriptor.AddAttributes(enumType, new TypeConverterAttribute(typeof (HumanizedEnumConverter)));
      if (coreType != enumType)
      {
        if (!(TypeDescriptor.GetConverter(coreType) is HumanizedEnumConverter))
          TypeDescriptor.AddAttributes(coreType, new TypeConverterAttribute(typeof(HumanizedEnumConverter))); 
      }
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      if (destinationType == typeof (string) && value != null)
          return Enum.IsDefined(_coreEnumType, value) ? ((Enum)value).Humanize() : string.Empty;
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