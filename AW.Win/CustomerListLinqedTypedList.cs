using System.Linq;
using AW.Data.EntityClasses;
using AW.Data.WinForms;

namespace AW.Win
{
  public class CustomerListLinqedTypedList
  {
    private readonly string addressLine1;
    private readonly string addressLine2;
    private readonly string city;
    private readonly string addressType;
    private readonly string title;
    private readonly string firstName;
    private readonly string middleName;
    private readonly string lastName;
    private readonly string suffix;
    private readonly string emailAddress;
    private readonly int emailPromotion;
    private readonly string countryRegionName;
    private readonly string stateProvinceName;
    private readonly int customerId;

    public string AddressLine1
    {
      get { return addressLine1; }
    }

    public string AddressLine2
    {
      get { return addressLine2; }
    }

    public string City
    {
      get { return city; }
    }

    public string AddressType
    {
      get { return addressType; }
    }

    public string Title
    {
      get { return title; }
    }

    public string FirstName
    {
      get { return firstName; }
    }

    public string MiddleName
    {
      get { return middleName; }
    }

    public string LastName
    {
      get { return lastName; }
    }

    public string Suffix
    {
      get { return suffix; }
    }

    public string EmailAddress
    {
      get { return emailAddress; }
    }

    public int EmailPromotion
    {
      get { return emailPromotion; }
    }

    public string CountryRegionName
    {
      get { return countryRegionName; }
    }

    public string StateProvinceName
    {
      get { return stateProvinceName; }
    }

    public int CustomerId
    {
      get { return customerId; }
    }

    public CustomerListLinqedTypedList(string addressLine1, string addressLine2, string city, string addressType, string title,
                                       string firstName, string middleName, string lastName, string suffix, string emailAddress,
                                       int emailPromotion, string countryRegionName, string stateProvinceName, int customerId)
    {
      this.addressLine1 = addressLine1;
      this.addressLine2 = addressLine2;
      this.city = city;
      this.addressType = addressType;
      this.title = title;
      this.firstName = firstName;
      this.middleName = middleName;
      this.lastName = lastName;
      this.suffix = suffix;
      this.emailAddress = emailAddress;
      this.emailPromotion = emailPromotion;
      this.countryRegionName = countryRegionName;
      this.stateProvinceName = stateProvinceName;
      this.customerId = customerId;
    }

    public static IQueryable<CustomerListLinqedTypedList> GetCustomerListQuery()
    {
      return GetCustomerListQuery(Validation.MetaData.Customer);
    }

    public static IQueryable<CustomerListLinqedTypedList> GetCustomerListQuery(IQueryable<CustomerEntity> customers)
    {
      return (from customer in customers
              from customerAddress in customer.CustomerAddress
              select
                new CustomerListLinqedTypedList(customerAddress.Address.AddressLine1, customerAddress.Address.AddressLine2,
                                                customerAddress.Address.City, customerAddress.AddressType.Name,
                                                customer.Individual.Contact.Title, customer.Individual.Contact.FirstName,
                                                customer.Individual.Contact.MiddleName, customer.Individual.Contact.LastName,
                                                customer.Individual.Contact.Suffix, customer.Individual.Contact.EmailAddress,
                                                customer.Individual.Contact.EmailPromotion,
                                                customerAddress.Address.StateProvince.CountryRegion.Name,
                                                customerAddress.Address.StateProvince.Name, customer.CustomerId));
    }
  }
}