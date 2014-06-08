using System;
using System.ComponentModel;
using System.Globalization;

namespace AW.Winforms.Helpers.WPF
{
  /// <summary>
  ///   Convert a string defining a .NET type into a <see cref="System.Type" /> value.  This code is from
  ///   http://compiledexperience.com/blog/posts/creating-a-dependency-property-of-type-systemtype-in-silverlight
  /// </summary>
  public class StringToTypeConverter : TypeConverter
  {
    /// <summary />
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      return sourceType.IsAssignableFrom(typeof (string));
    }

    /// <summary />
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
      var typeName = value as string;
      return String.IsNullOrEmpty(typeName) ? null : Type.GetType(typeName);
    }
  }
}