using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AW.Helper.TypeConverters;

namespace AW.Winforms.Helpers.Misc
{
  public static class ConvertersAndDescriptors
  {
    public static void AddConverters()
    {
      SingleValueCollectionConverter.AddConverter(typeof (ResultPropertyValueCollection));
      HumanizedEnumConverter.AddEnumerationConverter(typeof(DataGridViewClipboardCopyMode));
    }

    public static void AddTypeDescriptionProviders()
    {
      SubstitutingTypeDescriptionProvider.AddSpecificTypeConverterFor((DictionaryEntry d) => d.Value);
    }

    public static void AddBoth()
    {
      AddConverters();
      AddTypeDescriptionProviders();
    }
  }

  public static class AddConvertersAndDescriptors
  {
    static AddConvertersAndDescriptors()
    {
      ConvertersAndDescriptors.AddBoth();
    }

    public static void AddIfNotAllready()
    {
    }
  }
}
