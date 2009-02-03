///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
#if !CF
using System.Runtime.Serialization;
#endif
using AW.Data.EntityValidators;

namespace AW.Data.EntityClasses
{

  // __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
  using HelperClasses;
  using Linq;
  using System.Linq;
  using SD.LLBLGen.Pro.LinqSupportClasses;
  using SD.LLBLGen.Pro.ORMSupportClasses;
  // __LLBLGENPRO_USER_CODE_REGION_END

  /// <summary>
  /// Entity class which represents the entity 'SalesOrderHeader'. <br/>
  /// This class is used for Business Logic or for framework extension code. 
  /// </summary>
  [Serializable]
  public partial class SalesOrderHeaderEntity : SalesOrderHeaderEntityBase
    // __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
    // __LLBLGENPRO_USER_CODE_REGION_END	
  {
    #region Constructors

    /// <summary>
    /// CTor
    /// </summary>
    public SalesOrderHeaderEntity()
    {
    }


    /// <summary>
    /// CTor
    /// </summary>
    /// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
    public SalesOrderHeaderEntity(Int32 salesOrderId) :
      base(salesOrderId)
    {
    }


    /// <summary>
    /// CTor
    /// </summary>
    /// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
    /// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
    public SalesOrderHeaderEntity(Int32 salesOrderId, IPrefetchPath prefetchPathToUse) :
      base(salesOrderId, prefetchPathToUse)
    {
    }


    /// <summary>
    /// CTor
    /// </summary>
    /// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
    /// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
    public SalesOrderHeaderEntity(Int32 salesOrderId, IValidator validator) :
      base(salesOrderId, validator)
    {
    }


    /// <summary>
    /// Private CTor for deserialization
    /// </summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    protected SalesOrderHeaderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
    {
      // __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
      // __LLBLGENPRO_USER_CODE_REGION_END
    }

    #endregion

    #region Custom Entity code

    // __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
    //public static SalesOrderHeaderCollection GetSalesOrderHeaderCollection
    //    (
    //    DateTime FromDate,
    //    DateTime ToDate,
    //    string FirstName,
    //    string LastName,
    //    int OrderID,
    //    string OrderNumber,
    //    string CityName,
    //    string StateName,
    //    string CountryName,
    //    string Zip
    //    )
    //{
    //  RelationCollection Relations = new RelationCollection();
    //  IPredicateExpression Filter = new PredicateExpression();
    //  if (
    //      (FirstName != "") |
    //      (LastName != "") |
    //      (CityName != "") |
    //      (StateName != "") |
    //      (CountryName != "") |
    //      (Zip != "")
    //     )
    //  {
    //    Relations.Add(
    //        SalesOrderHeaderEntity.Relations.
    //        CustomerViewRelatedEntityUsingCustomerId);
    //  }
    //  if (FromDate != DateTime.MinValue)
    //  {
    //    Filter.Add(
    //        SalesOrderHeaderFields.OrderDate >= FromDate);
    //  }
    //  if (ToDate != DateTime.MinValue)
    //  {
    //    Filter.Add(
    //        SalesOrderHeaderFields.OrderDate <= ToDate);
    //  }
    //  if (FirstName != "")
    //  {
    //    Filter.Add(
    //        CustomerViewRelatedFields.FirstName % FirstName);
    //  }
    //  if (LastName != "")
    //  {
    //    Filter.Add(
    //        CustomerViewRelatedFields.LastName % LastName);
    //  }
    //  if (CityName != "")
    //  {
    //    Filter.Add(
    //        CustomerViewRelatedFields.City % CityName);
    //  }
    //  if (StateName != "")
    //  {
    //    Filter.Add(
    //        CustomerViewRelatedFields.StateProvinceName == StateName);
    //  }
    //  if (CountryName != "")
    //  {
    //    Filter.Add(
    //        CustomerViewRelatedFields.CountryRegionName == CountryName);
    //  }
    //  if (Zip != "")
    //  {
    //    Filter.Add(
    //        CustomerViewRelatedFields.PostalCode == Zip);
    //  }
    //  if (OrderID != 0)
    //  {
    //    Filter.Add(
    //        SalesOrderHeaderFields.SalesOrderId == OrderID);
    //  }
    //  if (OrderNumber != "")
    //  {
    //    Filter.Add(
    //        SalesOrderHeaderFields.SalesOrderNumber == OrderNumber);
    //  }
    //  ISortExpression Sort = new SortExpression();
    //  Sort.Add(
    //      SalesOrderHeaderFields.OrderDate | SortOperator.Ascending);
    //  SalesOrderHeaderCollection Orders = new SalesOrderHeaderCollection();
    //  Orders.SupportsSorting = true;
    //  Orders.GetMulti(Filter, 100, Sort, Relations);
    //  return Orders;
    //}

    public string CustomerLastName
    {
      get
      {
        PostReadXmlFixups();
        return CustomerViewRelated.LastName;
      }
    }

    public string CustomerFirstName
    {
      get { return CustomerViewRelated.FirstName; }
    }

    public string CustomerCity
    {
      get { return CustomerViewRelated.City; }
    }

    public string CustomerState
    {
      get { return CustomerViewRelated.StateProvinceName; }
    }

    public string CustomerCountry
    {
      get { return CustomerViewRelated.CountryRegionName; }
    }

    public string CustomerZip
    {
      get { return CustomerViewRelated.PostalCode; }
    }

    /// <summary>
    /// Called at the end of the initialization routine. Raises Initialized event.
    /// </summary>
    protected override void OnInitialized()
    {
      // Set the validator to this customer instance.
      Validator = new SalesOrderHeaderEntityValidator();
    }

    //__LLBLGENPRO_USER_CODE_REGION_END

    #endregion

    #region Included Code

    #endregion
  }
}