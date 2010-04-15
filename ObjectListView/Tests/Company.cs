// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.ComponentModel;

namespace JesseJohnston.Tests
{
	[Serializable]
	public class Company : INotifyPropertyChanged
	{
		private string name;
		private string city;
		private string state;

		public string City
		{
			get { return city; }
			set
			{
				if (city != value)
				{
					city = value;
					OnPropertyChanged("City");
				}
			}
		}
		public string Name
		{
			get { return name; }
			set
			{
				if (name != value)
				{
					name = value;
					OnPropertyChanged("Name");
				}
			}
		}
		public string State
		{
			get { return state; }
			set
			{
				if (state != value)
				{
					state = value;
					OnPropertyChanged("State");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public Company()
		{
		}
		public Company(string name, string city, string state)
		{
			this.name = name;
			this.city = city;
			this.state = state;
		}

		private void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#endif
