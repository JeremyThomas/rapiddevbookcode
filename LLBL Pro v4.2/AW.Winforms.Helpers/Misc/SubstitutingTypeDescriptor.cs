using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using AW.Helper;

namespace AW.Winforms.Helpers.Misc
{
  internal class SubstitutingTypeDescriptor : CustomTypeDescriptor
  {
    public SubstitutingTypeDescriptor(ICustomTypeDescriptor defaultDescriptor, Func<PropertyDescriptor, bool> conditionOnWhichToReplace,
      Func<PropertyDescriptor, PropertyDescriptor> substitute) : base(defaultDescriptor)
    {
      var origPropertyDescriptors = defaultDescriptor.GetProperties().AsEnumerable();
      //   var propertyDescriptorsToSub = origPropertyDescriptors.Where(ConditionOnWhichToReplace);

      SubstitutedPropertyDescriptorCollection = new PropertyDescriptorCollection(origPropertyDescriptors.Select(propertyDescriptor => conditionOnWhichToReplace(propertyDescriptor)
        ? substitute(propertyDescriptor) : propertyDescriptor).ToArray());
    }

    public PropertyDescriptorCollection SubstitutedPropertyDescriptorCollection { get; set; }

    public override PropertyDescriptorCollection GetProperties()
    {
      return GetProperties(null);
    }

    /// <summary>
    ///   call TypeDescriptor.GetProperties(this,attributes) to get SubstitutedPropertyDescriptorCollection filtered by
    ///   attributes
    /// </summary>
    /// <param name="attributes"></param>
    /// <returns></returns>
    public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
      return SubstitutedPropertyDescriptorCollection;
    }
  }

  public class SubstitutingTypeDescriptionProvider : TypeDescriptionProvider
  {
    private static readonly TypeDescriptionProvider DefaultTypeProvider = TypeDescriptor.GetProvider(typeof (DictionaryEntry));
    private readonly Func<PropertyDescriptor, bool> _conditionOnWhichToReplace;
    private readonly Func<PropertyDescriptor, PropertyDescriptor> _substitute;

    public static void Add<T>(Func<PropertyDescriptor, bool> conditionOnWhichToReplace, Func<PropertyDescriptor, PropertyDescriptor> substitute)
    {
      TypeDescriptor.AddProvider(new SubstitutingTypeDescriptionProvider(conditionOnWhichToReplace, substitute), typeof (T));
    }

    public static void Add<T>(Func<PropertyDescriptor, bool> conditionOnWhichToReplace, TypeConverter substituteTypeConverter)
    {
      Add<T>(conditionOnWhichToReplace, p => new ConverterSubstitutingPropertyDescriptor(p,substituteTypeConverter));
    }

    public SubstitutingTypeDescriptionProvider(Func<PropertyDescriptor, bool> conditionOnWhichToReplace, Func<PropertyDescriptor, PropertyDescriptor> substitute) : base(DefaultTypeProvider)
    {
      _conditionOnWhichToReplace = conditionOnWhichToReplace;
      _substitute = substitute;
    }

    public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
    {
      var defaultDescriptor = base.GetTypeDescriptor(objectType, instance);

      return new SubstitutingTypeDescriptor(defaultDescriptor, _conditionOnWhichToReplace, _substitute);
    }
  }

  public class ConverterSubstitutingPropertyDescriptor : ChainingPropertyDescriptor
  {
    public ConverterSubstitutingPropertyDescriptor(PropertyDescriptor root, TypeConverter substituteTypeConverter) : base(root)
    {
      _converter = substituteTypeConverter;
    }

    private readonly TypeConverter _converter;

    public override TypeConverter Converter
    {
      get { return _converter; }
    }
  }
}