using System;
using System.ComponentModel;

namespace JesseJohnston
{
  internal class ExtendedPropertyDescriptor : PropertyDescriptor
  {
    private readonly Type componentType;
    private readonly Type propertyType;
    private readonly object defaultValue;
    private readonly bool readOnly;

    public override Type ComponentType
    {
      get { return componentType; }
    }

    public override bool IsReadOnly
    {
      get { return readOnly; }
    }

    public override Type PropertyType
    {
      get { return propertyType; }
    }

    public event EventHandler<ExtendedPropertyEventArgs> ValueGet;
    public event EventHandler<ExtendedPropertyEventArgs> ValueSet;

    public ExtendedPropertyDescriptor(Type componentType, string propertyName, Type propertyType, bool writable, object defaultValue) : base(propertyName, new Attribute[0])
    {
      if (componentType == null)
        throw new ArgumentNullException("componentType");
      if (propertyName == null)
        throw new ArgumentNullException("propertyName");
      if (propertyName == "")
        throw new ArgumentException("propertyName");
      if (propertyType == null)
        throw new ArgumentNullException("propertyName");
      if (defaultValue != null && !propertyType.IsAssignableFrom(defaultValue.GetType()))
        throw new ArgumentException("defaultValue");

      this.componentType = componentType;
      this.propertyType = propertyType;
      readOnly = !writable;
      this.defaultValue = defaultValue;
    }

    public override bool CanResetValue(object component)
    {
      return true;
    }

    public override object GetValue(object component)
    {
      var val = defaultValue;
      OnValueGet(component, out val);

      if (propertyType.IsValueType)
      {
        if (val == null)
        {
          if (!propertyType.IsGenericType || propertyType.GetGenericTypeDefinition() != typeof (Nullable<>))
            throw new ArgumentException("Value");
        }
        else if (!(propertyType.IsAssignableFrom(val.GetType())))
          throw new ArgumentException("Value");
      }
      else if (val != null && !(propertyType.IsAssignableFrom(val.GetType())))
        throw new ArgumentException("Value");

      return val;
    }

    public override void ResetValue(object component)
    {
      SetValue(component, defaultValue);
    }

    public override void SetValue(object component, object value)
    {
      if (IsReadOnly)
        throw new InvalidOperationException("Property " + DisplayName + " is readonly.");
      OnValueSet(component, value);
    }

    public override bool ShouldSerializeValue(object component)
    {
      return false;
    }

    private bool OnValueGet(object component, out object userValue)
    {
      userValue = defaultValue;

      if (ValueGet != null)
      {
        var args = new ExtendedPropertyEventArgs(DisplayName, component);
        ValueGet(this, args);
        if (args.UserSetValue)
        {
          userValue = args.Value;
          return true;
        }
      }

      return false;
    }

    private void OnValueSet(object component, object value)
    {
      if (ValueSet != null)
        ValueSet(this, new ExtendedPropertyEventArgs(DisplayName, component, value));
    }
  }
}