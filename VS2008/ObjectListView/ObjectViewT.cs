using System;
using System.ComponentModel;

namespace JesseJohnston
{
  /// <summary>
  /// Wrapper returned by <seealso cref="ObjectListView{T}.AddNew()"/>
  /// </summary>
  /// <remarks>
  /// This type is returned from <seealso cref="ObjectListView{T}.AddNew"/> so that if the added object supports <seealso cref="IEditableObject"/>, 
  /// calling <see cref="EndEdit"/> or <see cref="CancelEdit"/> through the wrapper will notify the ObjectListView that the object addition has been committed
  /// or cancelled.
  /// </remarks>
  /// <typeparam name="T"></typeparam>
  [Serializable]
  public sealed class ObjectView<T> : IEditableObject, IEditableObjectEvents
  {
    private readonly T item;
    private EventHandler beganImpl;
    private EventHandler cancelledImpl;
    private EventHandler endedImpl;

    /// <summary>
    /// Gets the object wrapped by this instance.
    /// </summary>
    /// <value>The object.</value>
    public T Object
    {
      get { return item; }
    }

    internal ObjectView(T item)
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
        ((IEditableObject) item).BeginEdit();
        if (beganImpl != null)
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
        ((IEditableObject) item).CancelEdit();
        if (cancelledImpl != null)
          cancelledImpl(this, EventArgs.Empty);
      }
    }

    /// <summary>
    /// Commits changes made since the last <see cref="BeginEdit"/> or <seealso cref="ObjectListView{T}.AddNew"/> call.
    /// </summary>
    public void EndEdit()
    {
      if (!IsEditableObject())
        throw new NotSupportedException("Object does not implement IEditableObject.");
      else
      {
        ((IEditableObject) item).EndEdit();
        if (endedImpl != null)
          endedImpl(this, EventArgs.Empty);
      }
    }

    #endregion

    #region IEditableObjectEvents Members

    event EventHandler IEditableObjectEvents.Began
    {
      add { beganImpl = (EventHandler) Delegate.Combine(beganImpl, value); }
      remove { beganImpl = (EventHandler) Delegate.Remove(beganImpl, value); }
    }

    event EventHandler IEditableObjectEvents.Cancelled
    {
      add { cancelledImpl = (EventHandler) Delegate.Combine(cancelledImpl, value); }
      remove { cancelledImpl = (EventHandler) Delegate.Remove(cancelledImpl, value); }
    }

    event EventHandler IEditableObjectEvents.Ended
    {
      add { endedImpl = (EventHandler) Delegate.Combine(endedImpl, value); }
      remove { endedImpl = (EventHandler) Delegate.Remove(endedImpl, value); }
    }

    #endregion

    private bool IsEditableObject()
    {
      return (item != null && item is IEditableObject);
    }
  }
}