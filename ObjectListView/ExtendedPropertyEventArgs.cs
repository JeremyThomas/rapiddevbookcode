// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

using System;

namespace JesseJohnston
{
	/// <summary>
	/// This class contains information about the <seealso cref="ExtendedProperty.GetValue"/> and <seealso cref="ExtendedProperty.SetValue"/>
	/// events.
	/// </summary>
	internal class ExtendedPropertyEventArgs : EventArgs
	{
		private string name;
		private object target;
		private object newValue;
		private bool userSetValue;

		/// <summary>
		/// Gets the name of the property being set or get.
		/// </summary>
		/// <value>The name of the property.</value>
		public string PropertyName
		{
			get { return name; }
		}

		/// <summary>
		/// Gets the target object on which the property is being set or get.
		/// </summary>
		/// <value>The target.</value>
		public object Target
		{
			get { return target; }
		}

		/// <summary>
		/// Gets or sets the value of the property.
		/// </summary>
		/// <remarks>
		/// When the event <seealso cref="ExtendedProperty.GetValue"/> is raised, Value should be set to the value to be returned.
		/// When the event <seealso cref="ExtendedProperty.SetValue"/> is raised, Value contains the new value of the property, and 
		/// setting it performs no useful function.
		/// </remarks>
		/// <value>The value.</value>
		public object Value
		{
			get { return this.newValue; }
			set
			{
				this.newValue = value;
				this.userSetValue = true;
			}
		}

		internal bool UserSetValue
		{
			get { return this.userSetValue; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ExtendedPropertyEventArgs"/> class.
		/// </summary>
		/// <param name="propertyName">Name of the property being read.</param>
		/// <param name="target">The object that contains the property.</param>
		public ExtendedPropertyEventArgs(string propertyName, object target) : this(propertyName, target, null)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ExtendedPropertyEventArgs"/> class.
		/// </summary>
		/// <param name="propertyName">Name of the property being written.</param>
		/// <param name="target">The object that contains the property.</param>
		/// <param name="newValue">The new value of the property.</param>
		public ExtendedPropertyEventArgs(string propertyName, object target, object newValue)
		{
			if (propertyName == null)
				throw new ArgumentNullException("propertyName");
			if (propertyName == "")
				throw new ArgumentException("propertyName");
			if (target == null)
				throw new ArgumentNullException("target");

			this.name = propertyName;
			this.target = target;
			this.newValue = newValue;
		}
	}
}
