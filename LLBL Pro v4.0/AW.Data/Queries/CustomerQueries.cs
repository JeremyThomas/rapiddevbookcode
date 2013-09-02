using System.Linq;
using AW.Data.CollectionClasses;
using AW.Data.DaoClasses;
using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using AW.Data.Filters;
using AW.Data.HelperClasses;
using AW.Data.TypedListClasses;
using AW.Data.TypedViewClasses;
using AW.Data.ViewModels;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.SelfServicing;

namespace AW.Data.Queries
{
  public static class CustomerQueries
  {
    /// <summary>
    ///   Gets the customer view typed view. Example 5.18. pg59. maxNumberOfItemsToReturn does not result in a SQL TOP command
    /// </summary>
    /// <param name="maxNumberOfItemsToReturn">The max number of items to return.</param>
    /// <returns></returns>
    /// <remarks>
    ///   SELECT [SALES].[VINDIVIDUALCUSTOMER].[CustomerID]        AS [CustomerID],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[TITLE],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[FIRSTNAME],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[MIDDLENAME],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[LASTNAME],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[SUFFIX],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[PHONE],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[EMAILADDRESS],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[EMAILPROMOTION],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSTYPE],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSLINE1],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSLINE2],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[CITY],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[STATEPROVINCENAME],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[POSTALCODE],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[COUNTRYREGIONNAME],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[DEMOGRAPHICS]
    ///   FROM   [SALES].[VINDIVIDUALCUSTOMER]
    /// </remarks>
    public static CustomerViewTypedView GetCustomerViewTypedView(OrderSearchCriteria orderSearchCriteria, int maxNumberOfItemsToReturn)
    {
      var customers = new CustomerViewTypedView();
      var relations = new RelationCollection();
      var filter = SalesOrderHeaderFilters.FilterByDateOrderIDOrderNumberCustomerNameAddress(orderSearchCriteria);
      if (orderSearchCriteria.HasCustomerViewRelatedCriteria())
        relations.Add(CustomerViewRelatedEntity.Relations.SalesOrderHeaderEntityUsingCustomerID);
      customers.Fill(maxNumberOfItemsToReturn, null, false,filter);
      return customers;
    }

    public static CustomerViewTypedView GetCustomerViewTypedViewQuerySpec(int maxNumberOfItemsToReturn)
    {
      var qf = new QueryFactory();
      var q = qf.Create()
        .Select(CustomerViewFields.AddressLine1,
          CustomerViewFields.AddressLine2,
          CustomerViewFields.AddressType,
          CustomerViewFields.City,
          CustomerViewFields.CountryRegionName,
          CustomerViewFields.CustomerId,
          CustomerViewFields.Demographics,
          CustomerViewFields.EmailAddress,
          CustomerViewFields.EmailPromotion,
          CustomerViewFields.FirstName,
          CustomerViewFields.LastName,
          CustomerViewFields.MiddleName,
          CustomerViewFields.Phone,
          CustomerViewFields.PostalCode,
          CustomerViewFields.StateProvinceName,
          CustomerViewFields.Suffix,
          CustomerViewFields.Title)
        //.Where(CustomerViewFields.FirstName.StartsWith("J"))
        .Page(1, maxNumberOfItemsToReturn)
        ;

      var customers = new CustomerViewTypedView();
      new TypedListDAO().FetchAsDataTable(q, customers);
      return customers;
    }

    /// <summary>
    ///   Gets the related customer view of SalesOrder 46117. Example 5.27 pg63.
    /// </summary>
    /// <param name="salesOrderID"></param>
    /// <returns></returns>
    /// <remarks>
    ///   SELECT [SALES].[SALESORDERHEADER].[SALESORDERID]           AS [SALESORDERID],
    ///   [SALES].[SALESORDERHEADER].[REVISIONNUMBER],
    ///   [SALES].[SALESORDERHEADER].[ORDERDATE],
    ///   [SALES].[SALESORDERHEADER].[DUEDATE],
    ///   [SALES].[SALESORDERHEADER].[SHIPDATE],
    ///   [SALES].[SALESORDERHEADER].[STATUS],
    ///   [SALES].[SALESORDERHEADER].[ONLINEORDERFLAG],
    ///   [SALES].[SALESORDERHEADER].[SALESORDERNUMBER],
    ///   [SALES].[SALESORDERHEADER].[PURCHASEORDERNUMBER],
    ///   [SALES].[SALESORDERHEADER].[ACCOUNTNUMBER],
    ///   [SALES].[SALESORDERHEADER].[CustomerID]             AS [CustomerID],
    ///   [SALES].[SALESORDERHEADER].[CONTACTID]              AS [CONTACTID],
    ///   [SALES].[SALESORDERHEADER].[SALESPERSONID]          AS [SALESPERSONID],
    ///   [SALES].[SALESORDERHEADER].[TERRITORYID]            AS [TERRITORYID],
    ///   [SALES].[SALESORDERHEADER].[BILLTOADDRESSID]        AS [BILLTOADDRESSID],
    ///   [SALES].[SALESORDERHEADER].[SHIPTOADDRESSID]        AS [SHIPTOADDRESSID],
    ///   [SALES].[SALESORDERHEADER].[SHIPMETHODID]           AS [SHIPMETHODID],
    ///   [SALES].[SALESORDERHEADER].[CREDITCARDID]           AS [CREDITCARDID],
    ///   [SALES].[SALESORDERHEADER].[CREDITCARDAPPROVALCODE],
    ///   [SALES].[SALESORDERHEADER].[CURRENCYRATEID]         AS [CURRENCYRATEID],
    ///   [SALES].[SALESORDERHEADER].[SUBTOTAL],
    ///   [SALES].[SALESORDERHEADER].[TAXAMT],
    ///   [SALES].[SALESORDERHEADER].[FREIGHT],
    ///   [SALES].[SALESORDERHEADER].[TOTALDUE],
    ///   [SALES].[SALESORDERHEADER].[COMMENT],
    ///   [SALES].[SALESORDERHEADER].[ROWGUID]                AS [ROWGUID],
    ///   [SALES].[SALESORDERHEADER].[MODIFIEDDATE]
    ///   FROM   [SALES].[SALESORDERHEADER]
    ///   WHERE  (([SALES].[SALESORDERHEADER].[SALESORDERID] = @SalesOrderId1))
    ///   .
    ///   SELECT [SALES].[VINDIVIDUALCUSTOMER].[CustomerID]        AS [CustomerID],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[TITLE],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[FIRSTNAME],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[MIDDLENAME],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[LASTNAME],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[SUFFIX],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[PHONE],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[EMAILADDRESS],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[EMAILPROMOTION],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSTYPE],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSLINE1],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSLINE2],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[CITY],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[STATEPROVINCENAME],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[POSTALCODE],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[COUNTRYREGIONNAME],
    ///   [SALES].[VINDIVIDUALCUSTOMER].[DEMOGRAPHICS]
    ///   FROM   [SALES].[VINDIVIDUALCUSTOMER]
    ///   WHERE  (([SALES].[VINDIVIDUALCUSTOMER].[CustomerID] = @CustomerID1))
    /// </remarks>
    public static CustomerViewRelatedEntity GetCustomerViewRelatedCollection(int salesOrderID = 46117)
    {
      var order = new SalesOrderHeaderEntity(salesOrderID);
      return order.CustomerViewRelated;
    }

    /// <summary>
    ///   Gets the customer list typed list. Example 5.29. pg64.
    /// </summary>
    /// <param name="maxNumberOfItemsToReturn">The max number of items to return.</param>
    /// <returns></returns>
    /// <remarks>
    ///   SQL Output:
    ///   SELECT DISTINCT TOP 6 [adventureworks].[person].[address].[addressline1],
    ///   [adventureworks].[person].[address].[addressline2],
    ///   [adventureworks].[person].[address].[city],
    ///   [adventureworks].[person].[addresstype].[name],
    ///   [adventureworks].[person].[contact].[title],
    ///   [adventureworks].[person].[contact].[firstname],
    ///   [adventureworks].[person].[contact].[middlename],
    ///   [adventureworks].[person].[contact].[lastname],
    ///   [adventureworks].[person].[contact].[suffix],
    ///   [adventureworks].[person].[contact].[emailaddress],
    ///   [adventureworks].[person].[contact].[emailpromotion],
    ///   [adventureworks].[person].[stateprovince].[name] AS [countryregionname],
    ///   [adventureworks].[person].[countryregion].[name] AS [stateprovincename],
    ///   [adventureworks].[sales].[customer].[customerid] AS [customerid]
    ///   FROM   ((((((([adventureworks].[person].[stateprovince]
    ///   INNER JOIN [adventureworks].[person].[address]
    ///   ON [adventureworks].[person].[stateprovince].[stateprovinceid] =
    ///   [adventureworks].[person].[address].[stateprovinceid])
    ///   INNER JOIN [adventureworks].[person].[countryregion]
    ///   ON [adventureworks].[person].[countryregion].[countryregioncode] =
    ///   [adventureworks].[person].[stateprovince].[countryregioncode])
    ///   INNER JOIN [adventureworks].[sales].[customeraddress]
    ///   ON [adventureworks].[person].[address].[addressid] = [adventureworks].[sales].[customeraddress].[addressid])
    ///   INNER JOIN [adventureworks].[person].[addresstype]
    ///   ON [adventureworks].[person].[addresstype].[addresstypeid] =
    ///   [adventureworks].[sales].[customeraddress].[addresstypeid])
    ///   INNER JOIN [adventureworks].[sales].[customer]
    ///   ON [adventureworks].[sales].[customer].[customerid] = [adventureworks].[sales].[customeraddress].[customerid])
    ///   INNER JOIN [adventureworks].[sales].[individual]
    ///   ON [adventureworks].[sales].[customer].[customerid] = [adventureworks].[sales].[individual].[customerid])
    ///   INNER JOIN [adventureworks].[person].[contact]
    ///   ON [adventureworks].[person].[contact].[contactid] = [adventureworks].[sales].[individual].[contactid])
    /// </remarks>
    public static CustomerListTypedList GetCustomerListTypedList(int maxNumberOfItemsToReturn)
    {
      var customers = new CustomerListTypedList();
      customers.Fill(maxNumberOfItemsToReturn, null, false);
      return customers;
    }

    public static CustomerListTypedList GetCustomerListTypedListQuerySpec(int maxNumberOfItemsToReturn)
    {
      var customers = new CustomerListTypedList();
      var q = customers.GetQuerySpecQuery(new QueryFactory())
                  .Page(1, maxNumberOfItemsToReturn); 
      new TypedListDAO().FetchAsDataTable(q, customers);
      return customers;
    }

    /// <summary>
    ///   Gets the customer list with a linq version of CustomerListTypedList.
    /// </summary>
    /// <param name="maxNumberOfItemsToReturn">The max number of items to return.</param>
    /// <returns></returns>
    /// <remarks>
    ///   http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14170
    ///   SQL Output:
    ///   SELECT DISTINCT TOP 6 [lpa_l3].[addressline1] AS [addressline1],
    ///   [lpa_l3].[addressline2] AS [addressline2],
    ///   [lpa_l3].[city] AS [city],
    ///   [lpa_l4].[name] AS [addresstype],
    ///   [lpa_l6].[title] AS [title],
    ///   [lpa_l6].[firstname] AS [firstname],
    ///   [lpa_l6].[middlename] AS [middlename],
    ///   [lpa_l6].[lastname] AS [lastname],
    ///   [lpa_l6].[suffix] AS [suffix],
    ///   [lpa_l6].[emailaddress] AS [emailaddress],
    ///   [lpa_l6].[emailpromotion] AS [emailpromotion],
    ///   [lpa_l8].[name] AS [countryregionname],
    ///   [lpa_l7].[name] AS [stateprovincename],
    ///   [lpa_l1].[customerid] AS [customerid]
    ///   FROM   ((((((([adventureworks].[sales].[customer] [lpa_l1]
    ///   INNER JOIN [adventureworks].[sales].[customeraddress] [lpa_l2]
    ///   ON [lpa_l1].[customerid] = [lpa_l2].[customerid])
    ///   INNER JOIN [adventureworks].[person].[address] [lpa_l3]
    ///   ON [lpa_l3].[addressid] = [lpa_l2].[addressid])
    ///   INNER JOIN [adventureworks].[person].[addresstype] [lpa_l4]
    ///   ON [lpa_l4].[addresstypeid] = [lpa_l2].[addresstypeid])
    ///   INNER JOIN [adventureworks].[sales].[individual] [lpa_l5]
    ///   ON [lpa_l1].[customerid] = [lpa_l5].[customerid])
    ///   INNER JOIN [adventureworks].[person].[contact] [lpa_l6]
    ///   ON [lpa_l6].[contactid] = [lpa_l5].[contactid])
    ///   INNER JOIN [adventureworks].[person].[stateprovince] [lpa_l7]
    ///   ON [lpa_l7].[stateprovinceid] = [lpa_l3].[stateprovinceid])
    ///   INNER JOIN [adventureworks].[person].[countryregion] [lpa_l8]
    ///   ON [lpa_l8].[countryregioncode] = [lpa_l7].[countryregioncode])
    ///   WHERE  (((([lpa_l1].[customerid] > @CustomerID1))))
    /// </remarks>
    public static IQueryable<CustomerListLinqedTypedList> GetCustomerListLinqedTypedList(int maxNumberOfItemsToReturn)
    {
      var individuals = MetaSingletons.MetaData.Individual.AsQueryable();
      individuals = individuals.Where(c => c.CustomerID > 10);
      return CustomerListLinqedTypedList.GetCustomerListQuery(individuals).Distinct().Take(maxNumberOfItemsToReturn);
    }

    /// <summary>
    ///   Gets the customer list with an anonymous linq projection.
    /// </summary>
    /// <param name="maxNumberOfItemsToReturn">The max number of items to return.</param>
    /// <returns></returns>
    /// <remarks>
    ///   http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14170
    ///   SQL Output:
    ///   SELECT DISTINCT TOP 6 [LPA_L3].[ADDRESSLINE1],
    ///   [LPA_L3].[ADDRESSLINE2],
    ///   [LPA_L3].[CITY],
    ///   [LPA_L4].[NAME]           AS [ADDRESSTYPE],
    ///   [LPA_L6].[TITLE],
    ///   [LPA_L6].[FIRSTNAME],
    ///   [LPA_L6].[MIDDLENAME],
    ///   [LPA_L6].[LASTNAME],
    ///   [LPA_L6].[SUFFIX],
    ///   [LPA_L6].[EMAILADDRESS],
    ///   [LPA_L6].[EMAILPROMOTION],
    ///   [LPA_L8].[NAME]           AS [COUNTRYREGIONNAME],
    ///   [LPA_L7].[NAME]           AS [STATEPROVINCENAME],
    ///   [LPA_L1].[CustomerID]     AS [CustomerID]
    ///   FROM   ((((((([ADVENTUREWORKS].[SALES].[CUSTOMER] [LPA_L1]
    ///   INNER JOIN [ADVENTUREWORKS].[SALES].[CUSTOMERADDRESS] [LPA_L2]
    ///   ON ([LPA_L1].[CustomerID] = [LPA_L2].[CustomerID]))
    ///   INNER JOIN [ADVENTUREWORKS].[PERSON].[ADDRESS] [LPA_L3]
    ///   ON [LPA_L3].[ADDRESSID] = [LPA_L2].[ADDRESSID])
    ///   INNER JOIN [ADVENTUREWORKS].[PERSON].[ADDRESSTYPE] [LPA_L4]
    ///   ON [LPA_L4].[ADDRESSTYPEID] = [LPA_L2].[ADDRESSTYPEID])
    ///   INNER JOIN [ADVENTUREWORKS].[SALES].[INDIVIDUAL] [LPA_L5]
    ///   ON [LPA_L1].[CustomerID] = [LPA_L5].[CustomerID])
    ///   INNER JOIN [ADVENTUREWORKS].[PERSON].[CONTACT] [LPA_L6]
    ///   ON [LPA_L6].[CONTACTID] = [LPA_L5].[CONTACTID])
    ///   INNER JOIN [ADVENTUREWORKS].[PERSON].[STATEPROVINCE] [LPA_L7]
    ///   ON [LPA_L7].[STATEPROVINCEID] = [LPA_L3].[STATEPROVINCEID])
    ///   INNER JOIN [ADVENTUREWORKS].[PERSON].[COUNTRYREGION] [LPA_L8]
    ///   ON [LPA_L8].[COUNTRYREGIONCODE] = [LPA_L7].[COUNTRYREGIONCODE])
    /// </remarks>
    public static IQueryable GetCustomerListAnonymousLinq(int maxNumberOfItemsToReturn)
    {
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
      return customerlist.Distinct().Take(maxNumberOfItemsToReturn);
    }
  }
}