using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;

namespace AW.Helper.TypeConverters
{
  public class SingleValueCollectionConverter: CollectionConverter
  {
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      var collection = value as ICollection;
      if (collection != null && collection.Count == 1)
        return base.ConvertTo(context, culture, GetFirstItemByEnumerable(collection), destinationType);
      return base.ConvertTo(context, culture, value, destinationType);
    }

    /// <summary>
    ///   Adds the SingleValueCollection converter if the Collection doesn't already have one.
    /// </summary>
    /// <param name="collectionType">Type of the enum.</param>
    public static void AddConverter(Type collectionType)
    {
      TypeConverterHelper.AddConverter(typeof(SingleValueCollectionConverter), collectionType);
    }

    /// <summary>
    /// From ListBindingHelper
    /// </summary>
    /// <param name="enumerable"></param>
    /// <returns></returns>
    private static object GetFirstItemByEnumerable(IEnumerable enumerable)
    {
      object obj = (object)null;
      if (enumerable is IList)
      {
        IList list = enumerable as IList;
        obj = list.Count > 0 ? list[0] : (object)null;
      }
      else
      {
        try
        {
          IEnumerator enumerator = enumerable.GetEnumerator();
          enumerator.Reset();
          if (enumerator.MoveNext())
            obj = enumerator.Current;
          enumerator.Reset();
        }
        catch (NotSupportedException ex)
        {
          obj = (object)null;
        }
      }
      return obj;
    }
  }
}
