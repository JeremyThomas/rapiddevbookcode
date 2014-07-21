//css_ref SD.LLBLGen.Pro.ORMSupportClasses.dll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AW.Data;
using AW.Data.Linq;
using AW.Winforms.Helpers.QueryRunner;

public class Script : MarshalByRefObject, IQueryScript
{
  public IEnumerable Query()
  {
    //Copy of CustomerQueries.GetCustomerListAnonymousLinq
var customerlist = from individual in MetaSingletons.MetaData.Individual
from customerAddress in individual.CustomerAddresses
select new
                                  {
                                    customerAddress.Address.AddressLine1,
                                    customerAddress.Address.AddressLine2,
                                    customerAddress.Address.City,
                                    AddressType = customerAddress.AddressType.Name,
                                    individual.Contact.Title,
                                    individual.Contact.FirstName,
                                    individual.Contact.MiddleName,
                                    individual.Contact.LastName,
                                    individual.Contact.Suffix,
                                    individual.Contact.EmailAddress,
                                    individual.Contact.EmailPromotion,
                                    CountryRegionName = customerAddress.Address.StateProvince.CountryRegion.Name,
                                    StateProvinceName = customerAddress.Address.StateProvince.Name,
                                    individual.CustomerID
                                  };
                
    return customerlist.Take(5);
  }

}