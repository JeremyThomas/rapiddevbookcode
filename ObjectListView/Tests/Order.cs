
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.ComponentModel;

namespace JesseJohnston.Tests
{
	[Serializable]
	public class Order : INotifyPropertyChanged
	{
		private Customer customer;
		private string product;
		private int qty;

		public Customer Customer
		{
			get { return customer; }
			set
			{
				if (customer != value)
				{
					customer = value;
					OnPropertyChanged("Customer");
				}
			}
		}
		public string Product
		{
			get { return product; }
			set
			{
				if (product != value)
				{
					product = value;
					OnPropertyChanged("Product");
				}
			}
		}
		public int Quantity
		{
			get { return qty; }
			set
			{
				if (qty != value)
				{
					qty = value;
					OnPropertyChanged("Quantity");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public Order(Customer customer, string product, int quantity)
		{
			this.customer = customer;
			this.product = product;
			this.qty = quantity;
		}

		private void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#endif