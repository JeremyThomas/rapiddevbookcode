using System;

namespace AW.Data.TypedViewClasses
{
  public interface IIndividualCustomer
  {
    /// <summary>Gets the AddressLine1 field.</summary>
    String AddressLine1 { get; set; }

    /// <summary>Gets the AddressLine2 field.</summary>
    String AddressLine2 { get; set; }

    /// <summary>Gets the AddressType field.</summary>
    String AddressType { get; set; }

    /// <summary>Gets the City field.</summary>
    String City { get; set; }

    /// <summary>Gets the CountryRegionName field.</summary>
    String CountryRegionName { get; set; }

    /// <summary>Gets the CustomerId field.</summary>
    Int32 CustomerId { get; set; }

    /// <summary>Gets the Demographics field.</summary>
    String Demographics { get; set; }

    /// <summary>Gets the EmailAddress field.</summary>
    String EmailAddress { get; set; }

    /// <summary>Gets the EmailPromotion field.</summary>
    EmailPromotion EmailPromotion { get; set; }

    /// <summary>Gets the FirstName field.</summary>
    String FirstName { get; set; }

    /// <summary>Gets the LastName field.</summary>
    String LastName { get; set; }

    /// <summary>Gets the MiddleName field.</summary>
    String MiddleName { get; set; }

    /// <summary>Gets the Phone field.</summary>
    String Phone { get; set; }

    /// <summary>Gets the PostalCode field.</summary>
    String PostalCode { get; set; }

    /// <summary>Gets the StateProvinceName field.</summary>
    String StateProvinceName { get; set; }

    /// <summary>Gets the Suffix field.</summary>
    String Suffix { get; set; }

    /// <summary>Gets the Title field.</summary>
    String Title { get; set; }
  }
}