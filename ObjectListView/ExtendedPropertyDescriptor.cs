// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

using System;
using System.ComponentModel;

namespace JesseJohnston
{
	internal class ExtendedPropertyDescriptor : PropertyDescriptor
	{
		private Type componentType;
		private Type propertyType;
		private object defaultValue;
		private bool readOnly;

		public override Type ComponentType
		{
			get { return this.componentType;  }
		}
		public override bool IsReadOnly
		{
			get { return this.readOnly; }
		}
		public override Type PropertyType
		{
			get { return this.propertyType;  }
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
			this.readOnly = !writable;
			this.defaultValue = defaultValue;
		}

		public override bool CanResetValue(object component)
		{
			return true;
		}
		public override object GetValue(object component)
		{
			object val = this.defaultValue;
			OnValueGet(component, out val);

			if (this.propertyType.IsValueType)
			{
				if (val == null)
				{
					if (!propertyType.IsGenericType || propertyType.GetGenericTypeDefinition() != typeof(Nullable<>))
						throw new ArgumentException("Value");
				}
				else if (!(this.propertyType.IsAssignableFrom(val.GetType())))
					throw new ArgumentException("Value");
			}
			else
			{
				if (val != null && !(this.propertyType.IsAssignableFrom(val.GetType())))
					throw new ArgumentException("Value");
			}

			return val;
		}
		public override void ResetValue(object component)
		{
			SetValue(component, this.defaultValue);
		}
		public override void SetValue(object component, object value)
		{
			if (this.IsReadOnly)
				throw new InvalidOperationException("Property " + this.DisplayName + " is readonly.");
			OnValueSet(component, value);
		}
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}

		private bool OnValueGet(object component, out object userValue)
		{
			userValue = this.defaultValue;

			if (ValueGet != null)
			{
				ExtendedPropertyEventArgs args = new ExtendedPropertyEventArgs(this.DisplayName, component);
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
				ValueSet(this, new ExtendedPropertyEventArgs(this.DisplayName, component, value));
		}
	}
}
