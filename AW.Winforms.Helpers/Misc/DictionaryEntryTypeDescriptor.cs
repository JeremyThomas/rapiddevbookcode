using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AW.Helper.TypeConverters;

namespace AW.Winforms.Helpers.Misc
{
  internal class DictionaryEntryTypeDescriptor : CustomTypeDescriptor
  {
   
    public DictionaryEntryTypeDescriptor(ICustomTypeDescriptor defaultDescriptor)
    {
      _defaultDescriptor = defaultDescriptor;
      var propertyDescriptor = defaultDescriptor.GetProperties().Cast<PropertyDescriptor>().Last();
      _customFields.Add(new PropertyDescriptorSingleValue(propertyDescriptor));
    }

    private readonly List<PropertyDescriptor> _customFields = new List<PropertyDescriptor>();
    private readonly ICustomTypeDescriptor _defaultDescriptor;

    public override PropertyDescriptorCollection GetProperties()
    {
      return new PropertyDescriptorCollection(_defaultDescriptor.GetProperties()
          .Cast<PropertyDescriptor>().Union(_customFields).ToArray());
    }

    public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
      var propertyDescriptorCollection = new PropertyDescriptorCollection(_defaultDescriptor.GetProperties(attributes)
        .Cast<PropertyDescriptor>().Union(_customFields).ToArray());
      return propertyDescriptorCollection;
    }
  }

  public class DictionaryEntryTypeDescriptionProvider : TypeDescriptionProvider
  {
    private static readonly TypeDescriptionProvider DefaultTypeProvider = TypeDescriptor.GetProvider(typeof (DictionaryEntry));

    public static void Add()
    {
      TypeDescriptor.AddProvider(new DictionaryEntryTypeDescriptionProvider(),typeof(DictionaryEntry));
    }

    public DictionaryEntryTypeDescriptionProvider() : base(DefaultTypeProvider)
    {
     
    }

    public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
    {
      var defaultDescriptor = base.GetTypeDescriptor(objectType, instance);

      return new DictionaryEntryTypeDescriptor(defaultDescriptor);
    }
  }

  class PropertyDescriptorSingleValue : ChainingPropertyDescriptor
  {
    public PropertyDescriptorSingleValue(PropertyDescriptor root) : base(root)
    {
    }

    private readonly TypeConverter _converter = new SingleValueCollectionConverter();

    public override TypeConverter Converter
    {
      get { return _converter; }
    }

    public override string Name
    {
      get { return base.Name+"single"; }
    }
  }
}