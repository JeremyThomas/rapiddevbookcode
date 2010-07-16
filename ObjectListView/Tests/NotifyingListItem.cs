#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.ComponentModel;

namespace JesseJohnston.Tests
{
  public class NotifyingListItem : INotifyPropertyChanged
  {
    private int intValue = -1;
    private string stringValue;
    private DateTime dateValue;

    public DateTime DateTimeValue
    {
      get { return dateValue; }
      set
      {
        dateValue = value;
        OnPropertyChanged("DateTimeValue");
      }
    }

    public int IntegerValue
    {
      get { return intValue; }
      set
      {
        intValue = value;
        OnPropertyChanged("IntegerValue");
      }
    }

    public string StringValue
    {
      get { return stringValue; }
      set
      {
        stringValue = value;
        OnPropertyChanged("StringValue");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public NotifyingListItem()
    {
    }

    public NotifyingListItem(int intValue, string stringValue, DateTime dateValue)
    {
      this.intValue = intValue;
      this.dateValue = dateValue;
      this.stringValue = stringValue;
    }

    private void OnPropertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}

#endif