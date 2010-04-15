// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

using System;
using System.ComponentModel;

namespace JesseJohnston
{
	/// <summary>
	/// This class represents a dynamic property of an <seealso cref="ObjectListView"/> list item type.
	/// </summary>
	internal class ExtendedProperty
	{
		private string name;
		private Type type;
		private object defaultValue;
		private ExtendedPropertyDescriptor descriptor;

		/// <summary>
		/// Gets the default value of this property.
		/// </summary>
		/// <value>The default.</value>
		public object Default
		{
			get { return defaultValue; }
		}

		/// <summary>
		/// Gets the name of this property.
		/// </summary>
		/// <value>The name.</value>
		public string Name
		{
			get { return name; }
		}

		/// <summary>
		/// Gets a property descriptor representing this property.
		/// </summary>
		/// <value>The property descriptor.</value>
		public PropertyDescriptor PropertyDescriptor
		{
			get { return descriptor; }
		}

		/// <summary>
		/// Gets the type of the property.
		/// </summary>
		/// <value>The type of the property.</value>
		public Type PropertyType
		{
			get { return type; }
		}

		/// <summary>
		/// Gets a value indicating whether this property is read only.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this property is read only; otherwise, <c>false</c>.
		/// </value>
		public bool IsReadOnly
		{
			get { return this.descriptor.IsReadOnly; }
		}

		/// <summary>
		/// Raised when the property value is being read through the property descriptor.
		/// </summary>
		/// <remarks>
		/// Set the Value property of <seealso cref="ExtendedPropertyEventArgs"/> to supply the value for the property.
		/// </remarks>
		public event EventHandler<ExtendedPropertyEventArgs> GetValue;

		/// <summary>
		/// Raised when the property value is being set through the property descriptor.
		/// </summary>
		/// <remarks>
		/// The Value property of <seealso cref="ExtendedPropertyEventArgs"/> contains the new value for the property.
		/// </remarks>
		public event EventHandler<ExtendedPropertyEventArgs> SetValue;

		/// <summary>
		/// Initializes a new instance of the <see cref="ExtendedProperty"/> class.
		/// </summary>
		/// <remarks>
		/// This overload of the constructor creates a read-only string property with a default value of null.
		/// </remarks>
		/// <param name="componentType">Type of the component to which the property will be added.</param>
		/// <param name="propertyName">Name of the property.</param>
		public ExtendedProperty(Type componentType, string propertyName) : this(componentType, propertyName, typeof(string), false, null)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ExtendedProperty"/> class.
		/// </summary>
		/// <remarks>
		/// This overload of the constructor creates a read-only property with a default value of null.
		/// </remarks>
		/// <param name="componentType">Type of the component to which the property will be added.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="propertyType">Type of the property.</param>
		public ExtendedProperty(Type componentType, string propertyName, Type propertyType) : this(componentType, propertyName, propertyType, false, null)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ExtendedProperty"/> class.
		/// </summary>
		/// <param name="componentType">Type of the component to which the property will be added.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="propertyType">Type of the property.</param>
		/// <param name="writable">if set to <c>true</c>, the property value can be set.</param>
		/// <param name="defaultValue">The default value of the property.</param>
		public ExtendedProperty(Type componentType, string propertyName, Type propertyType, bool writable, object defaultValue)
		{
			if (componentType == null)
				throw new ArgumentNullException("componentType");
			if (propertyName == null)
				throw new ArgumentNullException("propertyName");
			if (propertyName == "")
				throw new ArgumentException("propertyName");
			if (propertyType == null)
				throw new ArgumentNullException("propertyType");
			if (defaultValue != null && !propertyType.IsAssignableFrom(defaultValue.GetType()))
				throw new ArgumentException("defaultValue");

			this.name = propertyName;
			this.type = propertyType;
			this.defaultValue = defaultValue;
			this.descriptor = new ExtendedPropertyDescriptor(componentType, propertyName, propertyType, writable, defaultValue);
			this.descriptor.ValueGet += new EventHandler<ExtendedPropertyEventArgs>(descriptor_ValueGet);
			this.descriptor.ValueSet += new EventHandler<ExtendedPropertyEventArgs>(descriptor_ValueSet);
		}

		private void descriptor_ValueGet(object sender, ExtendedPropertyEventArgs e)
		{
			if (GetValue != null)
				GetValue(this, e);
		}
		private void descriptor_ValueSet(object sender, ExtendedPropertyEventArgs e)
		{
			if (SetValue != null)
				SetValue(this, e);
		}
	}
}
