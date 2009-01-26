using System;
using System.ComponentModel;
using System.Reflection;

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
          var cat = base.Category + " " + ComponentType.Name;
          return _field.FieldType.IsSubclassOf(typeof (Delegate)) ? cat + "-Events" : cat + "-Fields";
        }
        return base.Category;
      }
    }

    public override string Description
    {
      get
      {
        if (string. IsNullOrEmpty(base.Description))
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
        //foreach (Delegate d in ((Delegate)value).GetInvocationList())
        //{
        //  return d;
        //}
      }
      return value;
    }

    public override void SetValue(object component, object value)
    {
      _field.SetValue(component, value);
      OnValueChanged(component, EventArgs.Empty);
    }
  }

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
          return base.Category + " " + ComponentType.Name + "-Property";
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
      return property.GetValue(component, null);
    }

    public override void SetValue(object component, object value)
    {
      property.SetValue(component, value, null);
      OnValueChanged(component, EventArgs.Empty);
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

//    private static PropertyDescriptor[] ReflectGetProperties(Type type)
//    {
//      if (_propertyCache == null)
//      {
//        lock (_internalSyncObject)
//        {
//          if (_propertyCache == null)
//          {
//            _propertyCache = new Hashtable();
//          }
//        }
//      }

//      PropertyDescriptor[] properties = (PropertyDescriptor[])_propertyCache[type];
//      if (properties == null)
//      {
//        BindingFlags bindingFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;
//        TypeDescriptor.Trace("Properties : Building properties for {0}", type.Name);

//        // Get the type's properties.  Properties may have their
//        // get and set methods individually overridden in a derived
//        // class, so if we find a missing method we need to walk
//        // down the base class chain to find it.  We actually merge
//        // "new" properties of the same name, so we must preserve
//        // the member info for each method individually.
//        //
//        PropertyInfo[] propertyInfos = type.GetProperties(bindingFlags);
//        properties = new PropertyDescriptor[propertyInfos.Length];
//        int propertyCount = 0;


//        for (int idx = 0; idx < propertyInfos.Length; idx++)
//        {
//          PropertyInfo propertyInfo = propertyInfos[idx];

//          // Today we do not support parameterized properties.
//          // UNDONE : We should support these!
//          if (propertyInfo.GetIndexParameters().Length > 0)
//          {
//            continue;
//          }

//          MethodInfo getMethod = propertyInfo.GetGetMethod();
//          MethodInfo setMethod = propertyInfo.GetSetMethod();
//          string name = propertyInfo.Name;

//          // If the property only overrode "set", then we don't
//          // pick it up here.  Rather, we just merge it in from
//          // the base class list.


//          // If a property had at least a get method, we consider it.  We don't
//          // consider write-only properties.
//          //
//          if (getMethod != null)
//          {
//            properties[propertyCount++] = new ReflectPropertyDescriptor(type, name,
//                                                                        propertyInfo.PropertyType,
//                                                                        propertyInfo, getMethod,
//                                                                        setMethod, null);
//          }
//        }


//        if (propertyCount != properties.Length)
//        {
//          PropertyDescriptor[] newProperties = new PropertyDescriptor[propertyCount];
//          Array.Copy(properties, 0, newProperties, 0, propertyCount);
//          properties = newProperties;
//        }

//#if DEBUG
//        foreach (PropertyDescriptor dbgProp in properties)
//        {
//          Debug.Assert(dbgProp != null, "Holes in property array for type " + type);
//        }
//#endif
//        _propertyCache[type] = properties;
//      }

//      return properties;
//    }

    public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
      // Retrieve cached properties and filtered properties
      var filtering = attributes != null && attributes.Length > 0;
      var cache = _provider._filterCache;
      var props = _provider._propCache;

      // Use a cached version if we can
      if (filtering && cache != null && cache.IsValid(attributes)) return cache.FilteredProperties;
      else if (!filtering && props != null) return props;

      // Otherwise, create the property collection
      props = new PropertyDescriptorCollection(null);
      foreach (PropertyDescriptor prop in base.GetProperties(attributes))
      {
        props.Add(prop);
      }
      foreach (var prop in _objectType.GetProperties(BindingFlags.Instance |
                                                     BindingFlags.NonPublic | BindingFlags.Static))
      {
        var fieldDesc = new MyReflectedPropertyDescriptor(prop);
        if (!filtering || fieldDesc.Attributes.Contains(attributes))
          props.Add(fieldDesc);
      }

      foreach (var field in _objectType.GetFields(BindingFlags.Instance |
                                                  BindingFlags.Public |
                                                  BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.FlattenHierarchy))
      {
        var fieldDesc = new FieldPropertyDescriptor(field);
        if (!filtering || fieldDesc.Attributes.Contains(attributes))
          props.Add(fieldDesc);
      }
      AddBaseEventFields(props, attributes);

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

    public void AddBaseEventFields(PropertyDescriptorCollection propertyDescriptorCollection, Attribute[] attributes)
    {
      var t = _objectType.BaseType;
      var filtering = attributes != null && attributes.Length > 0;

      while (t != null)
      {
        foreach (var field in t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic ))
          if (field.FieldType.IsSubclassOf(typeof(Delegate)))
        {
          var fieldDesc = new FieldPropertyDescriptor(field);
          if (!filtering || fieldDesc.Attributes.Contains(attributes))
            propertyDescriptorCollection.Add(fieldDesc);
        }

        t = t.BaseType;
      }
    }

    public Delegate[] GetEventSubscribers(object target, string eventName)
    {
      var WinFormsEventName = "Event" + eventName;

      var t = target.GetType();


      do
      {
        var fia = t.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var fi in fia)
        {
          if (fi.Name == eventName)
          {
            //we've found the compiler generated event

            var d = fi.GetValue(target) as Delegate;

            if (d != null)

              return d.GetInvocationList();
          }

          if (fi.Name == WinFormsEventName)
          {
            //we've found an EventHandlerList key

            //get the list

            var ehl = (EventHandlerList) target.GetType().GetProperty("Events", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy).GetValue(target, null);

            //and dereference the delegate.

            var d = ehl[fi.GetValue(target)];

            if (d != null)

              return d.GetInvocationList();
          }
        }

        t = t.BaseType;
      } while (t != null);


      return new Delegate[] {};
    }
  }
}