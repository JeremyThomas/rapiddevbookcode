using System;

namespace JesseJohnston
{
  /// <summary>
  /// Class providing information about an item about to be deleted from the underlying list.
  /// </summary>
  public class RemovingItemEventArgs : EventArgs
  {
    private readonly int index;

    /// <summary>
    /// Gets the view index of the item about to be deleted.
    /// </summary>
    /// <value>The index.</value>
    public int Index
    {
      get { return index; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RemovingItemEventArgs"/> class.
    /// </summary>
    /// <param name="index">The view index of the item to be deleted.</param>
    public RemovingItemEventArgs(int index)
    {
      if (index < 0)
        throw new ArgumentOutOfRangeException("index");
      this.index = index;
    }
  }
}