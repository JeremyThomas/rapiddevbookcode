namespace AW.Data.TypedViewClasses
{
  public partial class CustomerViewLinqRow : IIndividualCustomer
  {

  }

  public interface IIndividualCustomer
  {
    /// <summary>Gets the AddressLine1 field.</summary>
    System.String AddressLine1 { get; set; }

    /// <summary>Gets the AddressLine2 field.</summary>
    System.String AddressLine2 { get; set; }

    /// <summary>Gets the AddressType field.</summary>
    System.String AddressType { get; set; }

    /// <summary>Gets the City field.</summary>
    System.String City { get; set; }

    /// <summary>Gets the CountryRegionName field.</summary>
    System.String CountryRegionName { get; set; }

    /// <summary>Gets the CustomerId field.</summary>
    System.Int32 CustomerId { get; set; }

    /// <summary>Gets the Demographics field.</summary>
//    System.String Demographics { get; set; }

    /// <summary>Gets the EmailAddress field.</summary>
    System.String EmailAddress { get; set; }

    /// <summary>Gets the EmailPromotion field.</summary>
    AW.Data.EmailPromotion EmailPromotion { get; set; }

    /// <summary>Gets the FirstName field.</summary>
    System.String FirstName { get; set; }

    /// <summary>Gets the LastName field.</summary>
    System.String LastName { get; set; }

    /// <summary>Gets the MiddleName field.</summary>
    System.String MiddleName { get; set; }

    /// <summary>Gets the Phone field.</summary>
  //  System.String Phone { get; set; }

    /// <summary>Gets the PostalCode field.</summary>
 //   System.String PostalCode { get; set; }

    /// <summary>Gets the StateProvinceName field.</summary>
    System.String StateProvinceName { get; set; }

    /// <summary>Gets the Suffix field.</summary>
    System.String Suffix { get; set; }

    /// <summary>Gets the Title field.</summary>
    System.String Title { get; set; }
  }
}