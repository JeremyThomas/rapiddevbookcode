using System.Linq;
using AW.Data.EntityClasses;

namespace AW.Data.ViewModels
{
  public class CustomerListLinqedTypedList
	{
		private readonly string _addressLine1;
		private readonly string _addressLine2;
		private readonly string _city;
		private readonly string _addressType;
		private readonly string _title;
		private readonly string _firstName;
		private readonly string _middleName;
		private readonly string _lastName;
		private readonly string _suffix;
		private readonly string _emailAddress;
		private readonly int _emailPromotion;
		private readonly string _countryRegionName;
		private readonly string _stateProvinceName;
		private readonly int _customerID;

		public string AddressLine1
		{
			get { return _addressLine1; }
		}

		public string AddressLine2
		{
			get { return _addressLine2; }
		}

		public string City
		{
			get { return _city; }
		}

		public string AddressType
		{
			get { return _addressType; }
		}

		public string Title
		{
			get { return _title; }
		}

		public string FirstName
		{
			get { return _firstName; }
		}

		public string MiddleName
		{
			get { return _middleName; }
		}

		public string LastName
		{
			get { return _lastName; }
		}

		public string Suffix
		{
			get { return _suffix; }
		}

		public string EmailAddress
		{
			get { return _emailAddress; }
		}

		public int EmailPromotion
		{
			get { return _emailPromotion; }
		}

		public string CountryRegionName
		{
			get { return _countryRegionName; }
		}

		public string StateProvinceName
		{
			get { return _stateProvinceName; }
		}

		public int CustomerID
		{
			get { return _customerID; }
		}

		public CustomerListLinqedTypedList(string addressLine1, string addressLine2, string city, string addressType, string title,
																			 string firstName, string middleName, string lastName, string suffix, string emailAddress,
																			 int emailPromotion, string countryRegionName, string stateProvinceName, int customerID)
		{
			_addressLine1 = addressLine1;
			_addressLine2 = addressLine2;
			_city = city;
			_addressType = addressType;
			_title = title;
			_firstName = firstName;
			_middleName = middleName;
			_lastName = lastName;
			_suffix = suffix;
			_emailAddress = emailAddress;
			_emailPromotion = emailPromotion;
			_countryRegionName = countryRegionName;
			_stateProvinceName = stateProvinceName;
			_customerID = customerID;
		}

		public static IQueryable<CustomerListLinqedTypedList> GetCustomerListQuery()
		{
			return GetCustomerListQuery(MetaSingletons.MetaData.Individual);
		}

		public static IQueryable<CustomerListLinqedTypedList> GetCustomerListQuery(IQueryable<IndividualEntity> individuals)
		{
			return (from individual in individuals
							from customerAddress in individual.CustomerAddresses
							select
								new CustomerListLinqedTypedList(customerAddress.Address.AddressLine1, customerAddress.Address.AddressLine2,
																								customerAddress.Address.City, customerAddress.AddressType.Name,
																								individual.Contact.Title, individual.Contact.FirstName,
																								individual.Contact.MiddleName, individual.Contact.LastName,
																								individual.Contact.Suffix, individual.Contact.EmailAddress,
																								individual.Contact.EmailPromotion,
																								customerAddress.Address.StateProvince.CountryRegion.Name,
																								customerAddress.Address.StateProvince.Name, individual.CustomerID));
		}
	}
}