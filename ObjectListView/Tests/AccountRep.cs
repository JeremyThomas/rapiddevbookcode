#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.ComponentModel;

namespace JesseJohnston.Tests
{
  [Serializable]
  public class AccountRep : INotifyPropertyChanged
  {
    private string name;
    private int dept;
    private string ssn;

    public int Department
    {
      get { return dept; }
      set
      {
        if (value != dept)
        {
          dept = value;
          OnPropertyChanged("Department");
        }
      }
    }

    public string Name
    {
      get { return name; }
      set
      {
        if (value != name)
        {
          name = value;
          OnPropertyChanged("Name");
        }
      }
    }

    protected string SSN
    {
      get { return ssn; }
      set
      {
        if (value != ssn)
        {
          ssn = value;
          OnPropertyChanged("SSN");
        }
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public AccountRep()
    {
    }

    public AccountRep(string name, int department)
    {
      this.name = name;
      dept = department;
    }

    private void OnPropertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}

#endif