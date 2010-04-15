// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

using System;
using System.ComponentModel;

namespace JesseJohnston
{
	/// <summary>
	/// Wrapper returned by <seealso cref="ObjectListView.AddNew"/>
	/// </summary>
	/// <remarks>
	/// This type is returned from <seealso cref="ObjectListView.AddNew"/> so that if the added object supports <see cref="IEditableObject"/>, 
	/// calling <see cref="EndEdit"/> or <see cref="CancelEdit"/> through the wrapper will notify the ObjectListView that the object addition has been committed
	/// or cancelled.
	/// </remarks>
	[Serializable]
	public sealed class ObjectView : IEditableObject, IEditableObjectEvents
	{
		private object item;
		private EventHandler beganImpl;
		private EventHandler cancelledImpl;
		private EventHandler endedImpl;

		/// <summary>
		/// Gets the object wrapped by this instance.
		/// </summary>
		/// <value>The object.</value>
		public object Object
		{
			get { return item; }
		}

		internal ObjectView(object item)
		{
			this.item = item;
		}

		#region IEditableObject Members
		/// <summary>
		/// Begins an edit on an object.
		/// </summary>
		public void BeginEdit()
		{
			if (!IsEditableObject())
				throw new NotSupportedException("Object does not implement IEditableObject.");
			else
			{
				((IEditableObject)this.item).BeginEdit();
				if (this.beganImpl != null)
					beganImpl(this, EventArgs.Empty);
			}
		}
		/// <summary>
		/// Discards changes made since the last <see cref="BeginEdit"/> call.
		/// </summary>
		public void CancelEdit()
		{
			if (!IsEditableObject())
				throw new NotSupportedException("Object does not implement IEditableObject.");
			else
			{
				((IEditableObject)this.item).CancelEdit();
				if (this.cancelledImpl != null)
					cancelledImpl(this, EventArgs.Empty);
			}
		}
		/// <summary>
		/// Commits changes made since the last <see cref="BeginEdit"/> or <seealso cref="ObjectListView.AddNew"/> call.
		/// </summary>
		public void EndEdit()
		{
			if (!IsEditableObject())
				throw new NotSupportedException("Object does not implement IEditableObject.");
			else
			{
				((IEditableObject)this.item).EndEdit();
				if (this.endedImpl != null)
					endedImpl(this, EventArgs.Empty);
			}
		}
		#endregion

		#region IEditableObjectEvents Members
		event EventHandler IEditableObjectEvents.Began
		{
			add { this.beganImpl = (EventHandler)Delegate.Combine(this.beganImpl, value); }
			remove { this.beganImpl = (EventHandler)Delegate.Remove(this.beganImpl, value); }
		}
		event EventHandler IEditableObjectEvents.Cancelled
		{
			add { this.cancelledImpl = (EventHandler)Delegate.Combine(this.cancelledImpl, value); }
			remove { this.cancelledImpl = (EventHandler)Delegate.Remove(this.cancelledImpl, value); }
		}
		event EventHandler IEditableObjectEvents.Ended
		{
			add { this.endedImpl = (EventHandler)Delegate.Combine(this.endedImpl, value); }
			remove { this.endedImpl = (EventHandler)Delegate.Remove(this.endedImpl, value); }
		}
		#endregion

		private bool IsEditableObject()
		{
			return (this.item != null && this.item is IEditableObject);
		}
	}
}
