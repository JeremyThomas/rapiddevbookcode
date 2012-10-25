using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.DAL.EntityClasses;

namespace Northwind.DAL.DTO
{
  public class CustomerVM
  {
    public string Address { get; private set; }

    public string City { get; private set; }

    public string CompanyName { get; private set; }

    public string ContactName { get; private set; }

    public string ContactTitle { get; private set; }

    public string Country { get; private set; }

    public string CustomerId { get; private set; }

    public string Fax { get; private set; }

    public string Phone { get; private set; }

    public string PostalCode { get; private set; }

    public string Region { get; private set; }

    public CustomerVM(string address, string city, string companyName, string contactName, string contactTitle, string country, string customerId, 
      string fax, string phone, string postalCode, string region)
    {
      Address = address;
      City = city;
      CompanyName = companyName;
      ContactName = contactName;
      ContactTitle = contactTitle;
      Country = country;
      CustomerId = customerId;
      Fax = fax;
      Phone = phone;
      PostalCode = postalCode;
      Region = region;
    }

    public CustomerVM(CustomerEntity c)
      : this(c.Address, c.City, c.CompanyName, c.ContactName, c.ContactTitle, c.Country, c.CustomerId, c.Fax, c.Phone, c.PostalCode, c.Region)
    {
    }

    public static IQueryable<CustomerVM> CustomerVmFactoryEntityInstance(IQueryable<CustomerEntity> customerEntities)
    {
      return from c in customerEntities select new CustomerVM(c);
    }

    public static IQueryable<CustomerVM> CustomerVmFactoryConstructor(IQueryable<CustomerEntity> customerEntities)
    {
      return from c in customerEntities select new CustomerVM(c.Address, c.City, c.CompanyName, c.ContactName, c.ContactTitle, c.Country, c.CustomerId, c.Fax, c.Phone, c.PostalCode, c.Region);
    }

    public override string ToString()
    {
      var builder = new StringBuilder();
      builder.Append("{ Address = ");
      builder.Append(Address);
      builder.Append(", City = ");
      builder.Append(City);
      builder.Append(", CompanyName = ");
      builder.Append(CompanyName);
      builder.Append(", ContactName = ");
      builder.Append(ContactName);
      builder.Append(", ContactTitle = ");
      builder.Append(ContactTitle);
      builder.Append(", Country = ");
      builder.Append(Country);
      builder.Append(", CustomerId = ");
      builder.Append(CustomerId);
      builder.Append(", Fax = ");
      builder.Append(Fax);
      builder.Append(", Phone = ");
      builder.Append(Phone);
      builder.Append(", PostalCode = ");
      builder.Append(PostalCode);
      builder.Append(", Region = ");
      builder.Append(Region);
      builder.Append(" }");
      return builder.ToString();
    }

    public override bool Equals(object value)
    {
      var type = value as CustomerVM;
      return (type != null) && EqualityComparer<string>.Default.Equals(type.Address, Address) && EqualityComparer<string>.Default.Equals(type.City, City) && EqualityComparer<string>.Default.Equals(type.CompanyName, CompanyName) &&
             EqualityComparer<string>.Default.Equals(type.ContactName, ContactName) && EqualityComparer<string>.Default.Equals(type.ContactTitle, ContactTitle) && EqualityComparer<string>.Default.Equals(type.Country, Country) &&
             EqualityComparer<string>.Default.Equals(type.CustomerId, CustomerId) && EqualityComparer<string>.Default.Equals(type.Fax, Fax) && EqualityComparer<string>.Default.Equals(type.Phone, Phone) &&
             EqualityComparer<string>.Default.Equals(type.PostalCode, PostalCode) && EqualityComparer<string>.Default.Equals(type.Region, Region);
    }

    public override int GetHashCode()
    {
      var num = 0x7a2f0b42;
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Address);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(City);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(CompanyName);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(ContactName);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(ContactTitle);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Country);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(CustomerId);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Fax);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Phone);
      num = (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(PostalCode);
      return (-1521134295*num) + EqualityComparer<string>.Default.GetHashCode(Region);
    }
  }
}