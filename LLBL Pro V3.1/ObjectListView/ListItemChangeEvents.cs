using System;

namespace JesseJohnston
{
  /// <summary>
  /// Describes the ways that a list item reports changes to it's property values.
  /// </summary>
  [Flags]
  [Serializable]
  public enum ListItemChangeEvents
  {
    /// <summary>
    /// The list item does not raise events when it's property values change.
    /// </summary>
    None = 0,
    /// <summary>
    /// The list item class implements the <see cref="T:System.ComponentModel.INotifyPropertyChanged"/> interface.
    /// </summary>
    INotifyPropertyChanged = 1,
    /// <summary>
    /// The list item class provides an event named <b><i>propertyName</i>Changed</b> for each property.
    /// </summary>
    PropertyChangedEvents = 2
  }
}