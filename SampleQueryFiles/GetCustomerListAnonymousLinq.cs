//css_ref SD.LLBLGen.Pro.ORMSupportClasses.NET20.dll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AW.Data;
using AW.Data.Linq;
using AW.Winforms.Helpers.QueryRunner;

public class Script : MarshalByRefObject, ILinqToLLBLQueryScript
{
  public IEnumerable QueryProject(LinqMetaData metaData)
  {
    //Copy of CustomerQueries.GetCustomerListAnonymousLinq
    var customerlist = from customer in (metaData).Customer
                       from customerAddress in customer.CustomerAddresses
                       select new
                                {
                                  customerAddress.Address.AddressLine1,
                                  customerAddress.Address.AddressLine2,
                                  customerAddress.Address.City,
                                  AddressType = customerAddress.AddressType.Name,
                                  customer.Individual.Contact.Title,
                                  customer.Individual.Contact.FirstName,
                                  customer.Individual.Contact.MiddleName,
                                  customer.Individual.Contact.LastName,
                                  customer.Individual.Contact.Suffix,
                                  customer.Individual.Contact.EmailAddress,
                                  customer.Individual.Contact.EmailPromotion,
                                  CountryRegionName = customerAddress.Address.StateProvince.CountryRegion.Name,
                                  StateProvinceName = customerAddress.Address.StateProvince.Name,
                                  customer.CustomerID
                                };
    return customerlist.Take(5);
  }

}