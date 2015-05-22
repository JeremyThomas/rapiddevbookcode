using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace AW.Helper.TypeConverters
{
  /// <summary>
  /// If a collection only contains 1 item then, when converting to string, convert that 1 item
  /// </summary>
  public class SingleValueCollectionConverter : CollectionConverter, IExtendingOriginalConverter
  {
    public TypeConverter OriginalConverter { get;  set; }

    public SingleValueCollectionConverter()
    {
    }

    public SingleValueCollectionConverter(TypeConverter originalConverter)
    {
      OriginalConverter = originalConverter;
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      var collection = value as ICollection;
      if (collection != null && typeof(string) == destinationType && collection.Count == 1)
        return base.ConvertTo(context, culture, GetFirstItemByEnumerable(collection), destinationType);
      return OriginalConverter == null ? base.ConvertTo(context, culture, value, destinationType) : OriginalConverter.ConvertTo(context, culture, value, destinationType);
    }

    /// <summary>
    ///   Adds the SingleValueCollection converter if the Collection doesn't already have one.
    /// </summary>
    /// <param name="targetTypes"></param>
    public static void AddConverter(params Type[] targetTypes)
    {
      TypeConverterHelper.AddConverter<SingleValueCollectionConverter>(targetTypes);
    }

    /// <summary>
    ///   From ListBindingHelper
    /// </summary>
    /// <param name="enumerable"></param>
    /// <returns></returns>
    private static object GetFirstItemByEnumerable(IEnumerable enumerable)
    {
      object obj = null;
      var list1 = enumerable as IList;
      if (list1 != null)
      {
        var list = list1;
        obj = list.Count > 0 ? list[0] : null;
      }
      else
      {
        try
        {
          var enumerator = enumerable.GetEnumerator();
          enumerator.Reset();
          if (enumerator.MoveNext())
            obj = enumerator.Current;
          enumerator.Reset();
        }
        catch (NotSupportedException)
        {
          obj = null;
        }
      }
      return obj;
    }
  }
}