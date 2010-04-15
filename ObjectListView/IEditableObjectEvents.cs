// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

using System;

namespace JesseJohnston
{
	/// <summary>
	/// Events raised when methods of <seealso cref="System.ComponentModel.IEditableObject"/> are called.
	/// </summary>
	public interface IEditableObjectEvents
	{
		/// <summary>
		/// Raised when <seealso cref="System.ComponentModel.IEditableObject.BeginEdit"/> is called.
		/// </summary>
		event EventHandler Began;
		/// <summary>
		/// Raised when <seealso cref="System.ComponentModel.IEditableObject.CancelEdit"/> is called.
		/// </summary>
		event EventHandler Cancelled;
		/// <summary>
		/// Raised when <seealso cref="System.ComponentModel.IEditableObject.EndEdit"/> is called.
		/// </summary>
		event EventHandler Ended;
	}
}
