using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using AW.Winforms.Helpers.PropGridEx;

//http://msdn.microsoft.com/en-us/magazine/cc163804.aspx

namespace AW.Winforms.Helpers.EntityViewer
{
  public class FieldsToPropertiesTypeDescriptionProvider : TypeDescriptionProvider
  {
    private readonly TypeDescriptionProvider _baseProvider;
    private PropertyDescriptorCollection _propCache;
    private readonly Dictionary<Type, FilterCache> _filterCaches = new Dictionary<Type, FilterCache>();

    private readonly BindingFlags _bindingFlag = BindingFlags.Instance | BindingFlags.Public |
                                                 BindingFlags.NonPublic | BindingFlags.Static;

    public FieldsToPropertiesTypeDescriptionProvider(Type t)
    {
      _baseProvider = TypeDescriptor.GetProvider(t);
    }

    public FieldsToPropertiesTypeDescriptionProvider(Type t, BindingFlags bindingAttr) : this(t)
    {
      _bindingFlag = bindingAttr;
    }

    public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
    {
      return new FieldsToPropertiesTypeDescriptor(
        this, _baseProvider.GetTypeDescriptor(objectType, instance), objectType, _bindingFlag);
    }

    private class FilterCache
    {
      public Attribute[] Attributes;
      public PropertyDescriptorCollection FilteredProperties;

      public bool IsValid(Attribute[] other)
      {
        if (other == null || Attributes == null) return false;
        if (Attributes.Length != other.Length) return false;
        return !other.Where((t, i) => !Attributes[i].Match(t)).Any();
      }
    }

    private void AddToCache(Type type, Attribute[] attributes, PropertyDescriptorCollection props)
    {
      _filterCaches.Add(type, new FilterCache {FilteredProperties = props, Attributes = attributes});
    }

    private FilterCache GetCache(Type type)
    {
      return _filterCaches.ContainsKey(type) ? _filterCaches[type] : null;
    }

    private class FieldPropertyDescriptor : PropertyDescriptor
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
            return base.Category + (_field.IsStatic ? " Static" : "") + (_field.FieldType.IsSubclassOf(typeof (Delegate)) ? " Events" : " Fields");
          }
          return base.Category;
        }
      }

      public override string Description
      {
        get
        {
          if (string.IsNullOrEmpty(base.Description))
            return String.Format("{0} {1} {2}\n\rDefined in class {3}", Category, _field.FieldType, _field.Name, _field.DeclaringType == null ? null : _field.DeclaringType.FullName);

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
        var theDelegate = value as Delegate;
        if (theDelegate != null)
        {
          var m = theDelegate.Method;
          return m.DeclaringType.FullName + "." + m.Name;
        }
        return value;
      }

      public override void SetValue(object component, object value)
      {
        _field.SetValue(component, value);
        OnValueChanged(component, EventArgs.Empty);
      }

      /// <summary>
      ///   Create an AttributeCollection that ensures an ExpandableObjectConverter
      ///   and add Description and Category attributes
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

            if ((tca != null) && (Type.GetType(tca.ConverterTypeName).IsSubclassOf(typeof (ExpandableObjectConverter))))
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
          if ((!hasExpandebleTypeConverter) && (!_field.FieldType.IsValueType) && (_field.FieldType != typeof (string)) && !_field.FieldType.IsSubclassOf(typeof (Delegate)))
          {
            attributes.Add(new TypeConverterAttribute(typeof (ExpandableObjectConverter)));
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
    ///   Use this as ReflectPropertyDescriptor is internal
    /// </summary>
    private class MyReflectedPropertyDescriptor : PropertyDescriptor
    {
      private readonly PropertyInfo _property;

      public MyReflectedPropertyDescriptor(PropertyInfo property)
        : base(property.Name,
          (Attribute[]) property.GetCustomAttributes(typeof (Attribute), true))
      {
        _property = property;
      }

      private PropertyInfo Property
      {
        get { return _property; }
      }

      public override bool Equals(object obj)
      {
        var other = obj as MyReflectedPropertyDescriptor;
        return other != null && other.Property.Equals(_property);
      }

      public override int GetHashCode()
      {
        return _property.GetHashCode();
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
            return String.Format("{0} {1} {2}\n\rDefined in class {3}", Category, _property.PropertyType, _property.Name, _property.DeclaringType == null ? null: _property.DeclaringType.FullName);

          return base.Description;
        }
      }

      public override Type ComponentType
      {
        get { return _property.DeclaringType; }
      }

      public override Type PropertyType
      {
        get { return _property.PropertyType; }
      }

      public override object GetValue(object component)
      {
        try
        {
          return _property.GetValue(component, null);
        }
        catch (Exception)
        {
          return null;
        }
      }

      public override void SetValue(object component, object value)
      {
        _property.SetValue(component, value, null);
        OnValueChanged(component, EventArgs.Empty);
      }

      /// <summary>
      ///   Create an AttributeCollection that ensures an ExpandableObjectConverter
      ///   and add Description and Category attributes
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

            if ((tca != null) && (Type.GetType(tca.ConverterTypeName).IsSubclassOf(typeof (ExpandableObjectConverter))))
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
          if ((!hasExpandebleTypeConverter) && (!_property.PropertyType.IsValueType) && (_property.PropertyType != typeof (string)) && !_property.PropertyType.IsSubclassOf(typeof (Delegate)))
          {
            attributes.Add(new TypeConverterAttribute(typeof (ExpandableObjectConverter)));
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

      private static BindingFlags _bindingFlags = BindingFlags.Instance | BindingFlags.Public |
                                                  BindingFlags.NonPublic | BindingFlags.Static;

      public FieldsToPropertiesTypeDescriptor(FieldsToPropertiesTypeDescriptionProvider provider, ICustomTypeDescriptor descriptor, Type objectType, BindingFlags bindingAttr)
        : base(descriptor)
      {
        if (provider == null) throw new ArgumentNullException("provider");
        if (descriptor == null) throw new ArgumentNullException("descriptor");
        if (objectType == null) throw new ArgumentNullException("objectType");
        _objectType = objectType;
        _provider = provider;
        _bindingFlags = bindingAttr;
      }

      public override PropertyDescriptorCollection GetProperties()
      {
        return GetProperties(null);
      }

      public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
      {
        // Retrieve cached properties and filtered properties
        var filtering = attributes != null && attributes.Length > 0;
        var cache = _provider.GetCache(_objectType);
        var props = _provider._propCache;

        // Use a cached version if we can
        if (filtering && cache != null && cache.IsValid(attributes)) return cache.FilteredProperties;
        if (!filtering && props != null) return props;

        // use a stack to reverse hierarchy
        // if fieldnames occur in more than one class
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

        // list to remember already added names
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
          _provider.AddToCache(_objectType, attributes, props);
        }
        else _provider._propCache = props;

        // Return the computed properties
        return props;
      }


      /// <summary>
      ///   Add the  fields of an object
      /// </summary>
      private static void AddTypeFields(Type type, Attribute[] attributes, PropertyDescriptorCollection fields, ICollection<string> addedMemberNames)
      {
        if ((type == typeof (ArrayList)) ||
            (type == typeof (Hashtable)) ||
            (type == typeof (SortedList)))
          return;

        // get all instance FieldInfos
        var fieldInfos = type.GetFields(_bindingFlags);

        var filtering = attributes != null && attributes.Length > 0;

        foreach (var field in fieldInfos.Where(field => !addedMemberNames.Contains(field.Name)))
        {
          // this one made it in the list... 
          addedMemberNames.Add(field.Name);
          var fieldDesc = new FieldPropertyDescriptor(field);
          if (!filtering || fieldDesc.Attributes.Contains(attributes))
          {
            var existing = fields.Find(fieldDesc.Name, false);
            if (existing == null || !existing.IsBrowsable)
            {
              fields.Add(fieldDesc);
              if (existing != null)
                fields.Remove(existing);
            }
          }
        }
      }

      /// <summary>
      ///   Add the  fields of an object
      /// </summary>
      private static void AddTypeProperties(IReflect type, Attribute[] attributes, PropertyDescriptorCollection props)
      {
        var filtering = attributes != null && attributes.Length > 0;

        foreach (var prop in type.GetProperties(_bindingFlags | BindingFlags.FlattenHierarchy))
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
}