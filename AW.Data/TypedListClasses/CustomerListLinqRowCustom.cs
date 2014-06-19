using System.Linq;
using AW.Data.EntityClasses;
using AW.Data.TypedViewClasses;

namespace AW.Data.TypedListClasses
{
  public partial class CustomerListLinqRow : IIndividualCustomer
  {

    public CustomerListLinqRow(string addressLine1, string addressLine2, string city, string addressType, string title,
                                       string firstName, string middleName, string lastName, string suffix, string emailAddress,
                                       EmailPromotion emailPromotion, string countryRegionName, string stateProvinceName, int customerID)
    {
      AddressLine1 = addressLine1;
      AddressLine2 = addressLine2;
      City = city;
      AddressType = addressType;
      Title = title;
      FirstName = firstName;
      MiddleName = middleName;
      LastName = lastName;
      Suffix = suffix;
      EmailAddress = emailAddress;
      EmailPromotion = emailPromotion;
      CountryRegionName = countryRegionName;
      StateProvinceName = stateProvinceName;
      CustomerId = customerID;
    }
    
    public static IQueryable<CustomerListLinqRow> GetCustomerListQuery(IQueryable<IndividualEntity> individuals)
    {
      return (from individual in individuals
              from customerAddress in individual.CustomerAddresses
              select
                new CustomerListLinqRow(customerAddress.Address.AddressLine1, customerAddress.Address.AddressLine2,
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