// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace JesseJohnston
{
	/// <summary>
	/// Describes a property of a property, and provides access to the property value.
	/// </summary>
	internal class PropertyPathDescriptor : PropertyDescriptor
	{
		private PropertyDescriptor[] childDescriptors;

		public override Type ComponentType
		{
			// Get the type that declares the root property (e.g. for "A.B.C.D", the type that declares A).
			get { return this.childDescriptors[0].ComponentType; }
		}
		public override bool IsReadOnly
		{
			get { return true; }
		}
		public override Type PropertyType
		{
			// Get the type of the leaf property (e.g. for "A.B.C.D", the type of D).
			get { return this.childDescriptors[this.childDescriptors.Length - 1].PropertyType; }
		}
		public string RootPropertyName
		{
			get { return this.childDescriptors[0].Name; }
		}

		public PropertyPathDescriptor(Type componentType, string propertyPath) : base(propertyPath, new Attribute[0])
		{
			if (componentType == null)
				throw new ArgumentNullException("componentType");
			if (propertyPath == null)
				throw new ArgumentNullException("propertyPath");
			if (propertyPath == "")
				throw new ArgumentException("propertyPath");

			GetDescriptors(componentType);
		}

		public override bool CanResetValue(object component)
		{
			return false;
		}
		public override object GetValue(object component)
		{
			object currentTarget = component;

			for (int i = 0; i < childDescriptors.Length; i++)
			{
				if (currentTarget == null)
				{
					string msg;
					if (i == 0)
						msg = "The root object";
					else
						msg = childDescriptors[i - 1].Name;
					throw new TargetException(string.Format("Cannot get value for property {0}.  {1} is null.", this.Name, msg));
				}

				PropertyDescriptor desc = childDescriptors[i];
				currentTarget = desc.GetValue(currentTarget);
			}

			return currentTarget;
		}
		public override void ResetValue(object component)
		{
			throw new NotImplementedException();
		}
		public override void SetValue(object component, object value)
		{
			throw new NotImplementedException();
		}
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}

		private void GetDescriptors(Type componentType)
		{
			string[] parts = this.Name.Split('.');

			this.childDescriptors = new PropertyDescriptor[parts.Length];

			Type currentType = componentType;

			for (int i = 0; i < parts.Length; i++)
			{
				string propertyName = parts[i];

				PropertyDescriptor desc = TypeDescriptor.GetProperties(currentType)[propertyName];
				if (desc == null)
					throw new ArgumentException("propertyPath");

				this.childDescriptors[i] = desc;

				currentType = desc.PropertyType;
			}
		}
	}
}
