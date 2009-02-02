using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using href.Controls.PropGridEx;

//http://msdn.microsoft.com/en-us/magazine/cc163804.aspx

public class FieldsToPropertiesTypeDescriptionProvider : TypeDescriptionProvider
{
  private readonly TypeDescriptionProvider _baseProvider;
  private PropertyDescriptorCollection _propCache;
  private FilterCache _filterCache;

  public FieldsToPropertiesTypeDescriptionProvider(Type t)
  {
    _baseProvider = TypeDescriptor.GetProvider(t);
  }

  public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
  {
    return new FieldsToPropertiesTypeDescriptor(
      this, _baseProvider.GetTypeDescriptor(objectType, instance), objectType);
  }

  private class FilterCache
  {
    public Attribute[] Attributes;
    public PropertyDescriptorCollection FilteredProperties;

    public bool IsValid(Attribute[] other)
    {
      if (other == null || Attributes == null) return false;
      if (Attributes.Length != other.Length) return false;
      for (var i = 0; i < other.Length; i++)
      {
        if (!Attributes[i].Match(other[i])) return false;
      }
      return true;
    }
  }

  public class FieldPropertyDescriptor : PropertyDescriptor
  {
    private readonly FieldInfo _field;

    public FieldPropertyDescriptor(FieldInfo field) : base(field.Name,
                                                           (Attribute[]) field.GetCustomAttributes(typeof (Attribute), true))
    {
      _field = field;
    }

    public FieldInfo Field
    {
      get { return _field; }
    }

    public override bool Equals(object obj)
    {
      var other = obj as FieldPropertyDescriptor;
      return other != null && other._field.Equals(_field);
    }

    public override int GetHashCode()
    {
      return _field.GetHashCode();
    }

    public override bool IsReadOnly
    {
      get { return false; }
    }

    public override void ResetValue(object component)
    {
    }

    public override bool CanResetValue(object component)
    {
      return false;
    }

    public override bool ShouldSerializeValue(object component)
    {
      return true;
    }

    public override string Category
    {
      get
      {
        if (base.Category == "Misc")
        {
          return base.Category + (_field.IsStatic ? " Static" : "") + (_field.FieldType.IsSubclassOf(typeof(Delegate)) ? " Events" : " Fields");
        }
        return base.Category;
      }
    }

    public override string Description
    {
      get
      {
        if (string.IsNullOrEmpty(base.Description))
          return String.Format("{0} {1} {2}\n\rDefined in class {3}", Category, _field.FieldType, _field.Name, _field.DeclaringType.FullName);

        return base.Description;
      }
    }

    public override Type ComponentType
    {
      get { return _field.DeclaringType; }
    }

    public override Type PropertyType
    {
      get { return _field.FieldType; }
    }

    public override object GetValue(object component)
    {
      var value = _field.GetValue(component);
      if (value is Delegate)
      {
        var m = ((Delegate) value).Method;
        return m.DeclaringType.FullName + "." + m.Name;
      }
      return value;
    }

    public override void SetValue(object component, object value)
    {
      if (component == null)
        return;
      _field.SetValue(component, value);
      OnValueChanged(component, EventArgs.Empty);
    }

    /// <summary>
    /// Create an AttributeCollection that ensures an ExpandableObjectConverter
    /// and add Description and Category attributes
    /// </summary>
    public override AttributeCollection Attributes
    {
      get
      {
        var hasExpandebleTypeConverter = false;
        var baseAttribs = base.Attributes;
        var attributes = new List<Attribute>(baseAttribs.Count);
        foreach (Attribute baseAttribute in baseAttribs)
        {
          var tca = baseAttribute as TypeConverterAttribute;

          if ((tca != null) && (Type.GetType(tca.ConverterTypeName).IsSubclassOf(typeof(ExpandableObjectConverter))))
          {
            attributes.Add(baseAttribute);
            hasExpandebleTypeConverter = true;
          }
          else
          {
            attributes.Add(baseAttribute);
          }
        }


        // add expandable type conv?
        if ((!hasExpandebleTypeConverter) && (!_field.FieldType.IsValueType) && (_field.FieldType != typeof(string)) && !_field.FieldType.IsSubclassOf(typeof(Delegate)))
        {
          attributes.Add(new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        var result = new AttributeCollection(attributes.ToArray());


        return result;
      }
    }

    public override PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter)
    {
      // get default child properties
      var props = base.GetChildProperties(instance, filter);

      // if it is an IList
      var list = instance as IList;
      if (list != null)
      {
        // add special property Descriptors for the items
        for (var i = 0; i < list.Count; i++)
        {
          props.Add(new ListItemMemberDescriptor(list, i));
        }
      }

      // if it is an IDictionary
      var dict = instance as IDictionary;
      if (dict != null)
      {
        foreach (var key in dict.Keys)
        {
          // add special property Descriptors for the values
          props.Add(new DictionaryItemMemberDescriptor(dict, key));
        }
      }
      return props;
    }
  }

  /// <summary>
  /// Use this as ReflectPropertyDescriptor is internal
  /// </summary>
  public class MyReflectedPropertyDescriptor : PropertyDescriptor
  {
    private readonly PropertyInfo property;

    public MyReflectedPropertyDescriptor(PropertyInfo property)
      : base(property.Name,
             (Attribute[]) property.GetCustomAttributes(typeof (Attribute), true))
    {
      this.property = property;
    }

    public PropertyInfo Property
    {
      get { return property; }
    }

    public override bool Equals(object obj)
    {
      var other = obj as MyReflectedPropertyDescriptor;
      return other != null && other.Property.Equals(property);
    }

    public override int GetHashCode()
    {
      return property.GetHashCode();
    }

    public override bool IsReadOnly
    {
      get { return false; }
    }

    public override void ResetValue(object component)
    {
    }

    public override bool CanResetValue(object component)
    {
      return false;
    }

    public override bool ShouldSerializeValue(object component)
    {
      return true;
    }

    public override string Category
    {
      get
      {
        if (base.Category == "Misc")
          return base.Category + " Properties";
        return base.Category;
      }
    }

    public override string Description
    {
      get
      {
        if (string.IsNullOrEmpty(base.Description))
          return String.Format("{0} {1} {2}\n\rDefined in class {3}", Category, property.PropertyType, property.Name, property.DeclaringType.FullName);

        return base.Description;
      }
    }

    public override Type ComponentType
    {
      get { return property.DeclaringType; }
    }

    public override Type PropertyType
    {
      get { return property.PropertyType; }
    }

    public override object GetValue(object component)
    {
      try
      {
        return property.GetValue(component, null);
      }
      catch (Exception e)
      {
        return null;
      } 
    }

    public override void SetValue(object component, object value)
    {
      property.SetValue(component, value, null);
      OnValueChanged(component, EventArgs.Empty);
    }

    /// <summary>
    /// Create an AttributeCollection that ensures an ExpandableObjectConverter
    /// and add Description and Category attributes
    /// </summary>
    public override AttributeCollection Attributes
    {
      get
      {
        var hasExpandebleTypeConverter = false;
        var baseAttribs = base.Attributes;
        var attributes = new List<Attribute>(baseAttribs.Count);
        foreach (Attribute baseAttribute in baseAttribs)
        {
          var tca = baseAttribute as TypeConverterAttribute;

          if ((tca != null) && (Type.GetType(tca.ConverterTypeName).IsSubclassOf(typeof(ExpandableObjectConverter))))
          {
            attributes.Add(baseAttribute);
            hasExpandebleTypeConverter = true;
          }
          else
          {
            attributes.Add(baseAttribute);
          }
        }

     //   if (!IsBrowsable)
          //attributes.Add(new BrowsableAttribute(false));
        
        // add expandable type conv?
        if ((!hasExpandebleTypeConverter) && (!property.PropertyType.IsValueType) && (property.PropertyType != typeof(string)) && !property.PropertyType.IsSubclassOf(typeof(Delegate)))
        {
          attributes.Add(new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        var result = new AttributeCollection(attributes.ToArray());


        return result;
      }
    }
  }

  private class FieldsToPropertiesTypeDescriptor : CustomTypeDescriptor
  {
    private readonly Type _objectType;
    private readonly FieldsToPropertiesTypeDescriptionProvider _provider;

    public FieldsToPropertiesTypeDescriptor(FieldsToPropertiesTypeDescriptionProvider provider, ICustomTypeDescriptor descriptor, Type objectType) : base(descriptor)
    {
      if (provider == null) throw new ArgumentNullException("provider");
      if (descriptor == null) throw new ArgumentNullException("descriptor");
      if (objectType == null) throw new ArgumentNullException("objectType");
      _objectType = objectType;
      _provider = provider;
    }

    public override PropertyDescriptorCollection GetProperties()
    {
      return GetProperties(null);
    }

    public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
      // Retrieve cached properties and filtered properties
      var filtering = attributes != null && attributes.Length > 0;
      var cache = _provider._filterCache;
      var props = _provider._propCache;

      // Use a cached version if we can
      //if (filtering && cache != null && cache.IsValid(attributes)) return cache.FilteredProperties;
      //if (!filtering && props != null) return props;

      // use a stack to reverse hierarchy
      // if fieldnames occure in more than one class
      // use the one from the class that is highest in the class hierarchy
      var objectHierarchy = new Stack<Type>();
      var curType = _objectType;
      while (curType != null)
      {
        objectHierarchy.Push(curType);
        curType = curType.BaseType;
      }

      // Otherwise, create the property collection
      props = new PropertyDescriptorCollection(null);
      foreach (PropertyDescriptor prop in base.GetProperties(attributes))
      {
        props.Add(prop);
      }

      // list to rememnber already added names
      var addedMemberNames = new List<string>();

      while (objectHierarchy.Count > 0)
      {
        curType = objectHierarchy.Pop();
        AddTypeFields(curType, attributes, props, addedMemberNames);
        AddTypeProperties(curType, attributes, props);
      }

      // Store the updated properties
      if (filtering)
      {
        cache = new FilterCache {FilteredProperties = props, Attributes = attributes};
        _provider._filterCache = cache;
      }
      else _provider._propCache = props;

      // Return the computed properties
      return props;
    }

    /// <summary>
    /// Add the  fields of an object
    /// </summary>
    private static void AddTypeFields(Type type, Attribute[] attributes, PropertyDescriptorCollection fields, ICollection<string> addedMemberNames)
    {
      if ((type == typeof(ArrayList)) ||
     (type == typeof(Hashtable)) ||
     (type == typeof(SortedList)))
        return;

      // get all instance FieldInfos
      var fieldInfos = type.GetFields(BindingFlags.Instance | BindingFlags.Public |
      BindingFlags.NonPublic | BindingFlags.Static);

      var filtering = attributes != null && attributes.Length > 0;

      for (var i = 0; i < fieldInfos.Length; i++)
      {
        var field = fieldInfos[i];

        // ignore doublette names
        if (addedMemberNames.Contains(field.Name))
          continue;

        // this one made it in the list... 
        addedMemberNames.Add(field.Name);
        var fieldDesc = new FieldPropertyDescriptor(field);
        if (!filtering || fieldDesc.Attributes.Contains(attributes))
          fields.Add(fieldDesc);
      }
    }

    /// <summary>
    /// Add the  fields of an object
    /// </summary>
    private static void AddTypeProperties(Type type, Attribute[] attributes, PropertyDescriptorCollection props)
    {
      var filtering = attributes != null && attributes.Length > 0;

      foreach (var prop in type.GetProperties(BindingFlags.Instance | BindingFlags.Public |
                                               BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.FlattenHierarchy))
      {
        var fieldDesc = new MyReflectedPropertyDescriptor(prop);
        if (!filtering || fieldDesc.Attributes.Contains(attributes))
        {
          var existing = props.Find(fieldDesc.Name, false);
          if (existing == null || !existing.IsBrowsable)
          {
            props.Add(fieldDesc);
            if (existing != null)
              props.Remove(existing);
          }
        }
      }

    }


  }
}