using System.Linq;
using AW.Data;
using AW.Data.CollectionClasses;
using AW.Data.EntityClasses;
using AW.Data.TypedListClasses;
using AW.Data.TypedViewClasses;

namespace AW.Business
{
  public static class CustomerQueries
  {
    /// <summary>
    /// Gets the customer view typed view. Example 5.18. pg59.
    /// </summary>
    /// <param name="maxNumberOfItemsToReturn">The max number of items to return.</param>
    /// <returns></returns>
    /// <remarks>
    /// SELECT [SALES].[VINDIVIDUALCUSTOMER].[CustomerID]        AS [CustomerID],
    /// [SALES].[VINDIVIDUALCUSTOMER].[TITLE],
    /// [SALES].[VINDIVIDUALCUSTOMER].[FIRSTNAME],
    /// [SALES].[VINDIVIDUALCUSTOMER].[MIDDLENAME],
    /// [SALES].[VINDIVIDUALCUSTOMER].[LASTNAME],
    /// [SALES].[VINDIVIDUALCUSTOMER].[SUFFIX],
    /// [SALES].[VINDIVIDUALCUSTOMER].[PHONE],
    /// [SALES].[VINDIVIDUALCUSTOMER].[EMAILADDRESS],
    /// [SALES].[VINDIVIDUALCUSTOMER].[EMAILPROMOTION],
    /// [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSTYPE],
    /// [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSLINE1],
    /// [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSLINE2],
    /// [SALES].[VINDIVIDUALCUSTOMER].[CITY],
    /// [SALES].[VINDIVIDUALCUSTOMER].[STATEPROVINCENAME],
    /// [SALES].[VINDIVIDUALCUSTOMER].[POSTALCODE],
    /// [SALES].[VINDIVIDUALCUSTOMER].[COUNTRYREGIONNAME],
    /// [SALES].[VINDIVIDUALCUSTOMER].[DEMOGRAPHICS]
    /// FROM   [SALES].[VINDIVIDUALCUSTOMER]
    /// </remarks>
    public static CustomerViewTypedView GetCustomerViewTypedView(int maxNumberOfItemsToReturn)
    {
      var Customers = new CustomerViewTypedView();
      Customers.Fill(maxNumberOfItemsToReturn, null);
      return Customers;
    }

    /// <summary>
    /// Gets the customer view related collection. Example 5.27 pg63.
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// SELECT [SALES].[SALESORDERHEADER].[SALESORDERID]           AS [SALESORDERID],
    /// [SALES].[SALESORDERHEADER].[REVISIONNUMBER],
    /// [SALES].[SALESORDERHEADER].[ORDERDATE],
    /// [SALES].[SALESORDERHEADER].[DUEDATE],
    /// [SALES].[SALESORDERHEADER].[SHIPDATE],
    /// [SALES].[SALESORDERHEADER].[STATUS],
    /// [SALES].[SALESORDERHEADER].[ONLINEORDERFLAG],
    /// [SALES].[SALESORDERHEADER].[SALESORDERNUMBER],
    /// [SALES].[SALESORDERHEADER].[PURCHASEORDERNUMBER],
    /// [SALES].[SALESORDERHEADER].[ACCOUNTNUMBER],
    /// [SALES].[SALESORDERHEADER].[CustomerID]             AS [CustomerID],
    /// [SALES].[SALESORDERHEADER].[CONTACTID]              AS [CONTACTID],
    /// [SALES].[SALESORDERHEADER].[SALESPERSONID]          AS [SALESPERSONID],
    /// [SALES].[SALESORDERHEADER].[TERRITORYID]            AS [TERRITORYID],
    /// [SALES].[SALESORDERHEADER].[BILLTOADDRESSID]        AS [BILLTOADDRESSID],
    /// [SALES].[SALESORDERHEADER].[SHIPTOADDRESSID]        AS [SHIPTOADDRESSID],
    /// [SALES].[SALESORDERHEADER].[SHIPMETHODID]           AS [SHIPMETHODID],
    /// [SALES].[SALESORDERHEADER].[CREDITCARDID]           AS [CREDITCARDID],
    /// [SALES].[SALESORDERHEADER].[CREDITCARDAPPROVALCODE],
    /// [SALES].[SALESORDERHEADER].[CURRENCYRATEID]         AS [CURRENCYRATEID],
    /// [SALES].[SALESORDERHEADER].[SUBTOTAL],
    /// [SALES].[SALESORDERHEADER].[TAXAMT],
    /// [SALES].[SALESORDERHEADER].[FREIGHT],
    /// [SALES].[SALESORDERHEADER].[TOTALDUE],
    /// [SALES].[SALESORDERHEADER].[COMMENT],
    /// [SALES].[SALESORDERHEADER].[ROWGUID]                AS [ROWGUID],
    /// [SALES].[SALESORDERHEADER].[MODIFIEDDATE]
    /// FROM   [SALES].[SALESORDERHEADER]
    /// WHERE  (([SALES].[SALESORDERHEADER].[SALESORDERID] = @SalesOrderId1))
    /// .
    /// SELECT [SALES].[VINDIVIDUALCUSTOMER].[CustomerID]        AS [CustomerID],
    /// [SALES].[VINDIVIDUALCUSTOMER].[TITLE],
    /// [SALES].[VINDIVIDUALCUSTOMER].[FIRSTNAME],
    /// [SALES].[VINDIVIDUALCUSTOMER].[MIDDLENAME],
    /// [SALES].[VINDIVIDUALCUSTOMER].[LASTNAME],
    /// [SALES].[VINDIVIDUALCUSTOMER].[SUFFIX],
    /// [SALES].[VINDIVIDUALCUSTOMER].[PHONE],
    /// [SALES].[VINDIVIDUALCUSTOMER].[EMAILADDRESS],
    /// [SALES].[VINDIVIDUALCUSTOMER].[EMAILPROMOTION],
    /// [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSTYPE],
    /// [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSLINE1],
    /// [SALES].[VINDIVIDUALCUSTOMER].[ADDRESSLINE2],
    /// [SALES].[VINDIVIDUALCUSTOMER].[CITY],
    /// [SALES].[VINDIVIDUALCUSTOMER].[STATEPROVINCENAME],
    /// [SALES].[VINDIVIDUALCUSTOMER].[POSTALCODE],
    /// [SALES].[VINDIVIDUALCUSTOMER].[COUNTRYREGIONNAME],
    /// [SALES].[VINDIVIDUALCUSTOMER].[DEMOGRAPHICS]
    /// FROM   [SALES].[VINDIVIDUALCUSTOMER]
    /// WHERE  (([SALES].[VINDIVIDUALCUSTOMER].[CustomerID] = @CustomerID1))
    /// </remarks>
    public static CustomerViewRelatedCollection GetCustomerViewRelatedCollection()
    {
      var Order = new SalesOrderHeaderEntity(46117);
      var CustomerView = Order.CustomerViewRelated;
      return new CustomerViewRelatedCollection {CustomerView};
    }

    /// <summary>
    /// Gets the customer list typed list. Example 5.29. pg64.
    /// </summary>
    /// <param name="maxNumberOfItemsToReturn">The max number of items to return.</param>
    /// <returns></returns>
    /// <remarks>SQL Output:
    /// SELECT     Person.Address.AddressLine1, Person.Address.AddressLine2, Person.Address.City, Person.AddressType.Name AS AddressType, Person.Contact.Title,
    /// , Person.CountryRegion.Name AS CountryRegionName, Person.StateProvince.Name AS StateProvinceName,
    /// Sales.Customer.CustomerID AS CustomerID
    /// FROM         Sales.Customer INNER JOIN
    /// Sales.Individual ON Sales.Customer.CustomerID = Sales.Individual.CustomerID INNER JOIN
    /// Person.Contact ON Person.Contact.ContactID = Sales.Individual.ContactID INNER JOIN
    /// Sales.CustomerAddress ON Sales.Customer.CustomerID = Sales.CustomerAddress.CustomerID INNER JOIN
    /// Person.AddressType ON Person.AddressType.AddressTypeID = Sales.CustomerAddress.AddressTypeID INNER JOIN
    /// Person.Address ON Person.Address.AddressID = Sales.CustomerAddress.AddressID INNER JOIN
    /// Person.StateProvince ON Person.StateProvince.StateProvinceID = Person.Address.StateProvinceID INNER JOIN
    /// Person.CountryRegion ON Person.CountryRegion.CountryRegionCode = Person.StateProvince.CountryRegionCode</remarks>
    public static CustomerListTypedList GetCustomerListTypedList(int maxNumberOfItemsToReturn)
    {
      var Customers = new CustomerListTypedList();
      Customers.Fill(maxNumberOfItemsToReturn, null);
      return Customers;
    }

    /// <summary>
    /// Gets the customer list with a linq version of CustomerListTypedList.
    /// </summary>
    /// <param name="maxNumberOfItemsToReturn">The max number of items to return.</param>
    /// <returns></returns>
    /// <remarks>http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14170
    /// SQL Output:
    ///SELECT DISTINCT TOP 3 [LPA_L3].[AddressLine1]   AS [addressLine1],
    ///                      [LPA_L3].[AddressLine2]   AS [addressLine2],
    ///                      [LPA_L3].[City]           AS [city],
    ///                      [LPA_L4].[Name]           AS [addressType],
    ///                      [LPA_L6].[Title]          AS [title],
    ///                      [LPA_L6].[FirstName]      AS [firstName],
    ///                      [LPA_L6].[MiddleName]     AS [middleName],
    ///                      [LPA_L6].[LastName]       AS [lastName],
    ///                      [LPA_L6].[Suffix]         AS [suffix],
    ///                      [LPA_L6].[EmailAddress]   AS [emailAddress],
    ///                      [LPA_L6].[EmailPromotion] AS [emailPromotion],
    ///                      [LPA_L8].[Name]           AS [countryRegionName],
    ///                      [LPA_L7].[Name]           AS [stateProvinceName],
    ///                      [LPA_L1].[CustomerID]     AS [CustomerID]
    ///FROM   ((((((((SELECT [LPLA_1].[CustomerID]    AS [CustomerID],
    ///                      [LPLA_1].[TerritoryID]   AS [TerritoryId],
    ///                      [LPLA_1].[AccountNumber],
    ///                      [LPLA_1].[CustomerType],
    ///                      [LPLA_1].[rowguid]       AS [Rowguid],
    ///                      [LPLA_1].[ModifiedDate]
    ///               FROM   [AdventureWorks].[Sales].[Customer] [LPLA_1]
    ///               WHERE  ((([LPLA_1].[CustomerID] > @CustomerID1))
    ///                       AND EXISTS (SELECT [LPA_L11].[ModifiedDate]
    ///                                   FROM   ([AdventureWorks].[Person].[Address] [LPA_L10]
    ///                                           INNER JOIN [AdventureWorks].[Sales].[CustomerAddress] [LPA_L11]
    ///                                             ON [LPA_L10].[AddressID] = [LPA_L11].[AddressID])
    ///                                   WHERE  ([LPLA_1].[CustomerID] = [LPA_L11].[CustomerID]
    ///                                           AND ([LPA_L10].[City] = @City2))))) [LPA_L1]
    ///              INNER JOIN [AdventureWorks].[Sales].[CustomerAddress] [LPA_L2]
    ///                ON ([LPA_L1].[CustomerID] = [LPA_L2].[CustomerID]))
    ///             INNER JOIN [AdventureWorks].[Person].[Address] [LPA_L3]
    ///               ON [LPA_L3].[AddressID] = [LPA_L2].[AddressID])
    ///            INNER JOIN [AdventureWorks].[Person].[AddressType] [LPA_L4]
    ///              ON [LPA_L4].[AddressTypeID] = [LPA_L2].[AddressTypeID])
    ///           INNER JOIN [AdventureWorks].[Sales].[Individual] [LPA_L5]
    ///             ON [LPA_L1].[CustomerID] = [LPA_L5].[CustomerID])
    ///          INNER JOIN [AdventureWorks].[Person].[Contact] [LPA_L6]
    ///            ON [LPA_L6].[ContactID] = [LPA_L5].[ContactID])
    ///         INNER JOIN [AdventureWorks].[Person].[StateProvince] [LPA_L7]
    ///           ON [LPA_L7].[StateProvinceID] = [LPA_L3].[StateProvinceID])
    ///        INNER JOIN [AdventureWorks].[Person].[CountryRegion] [LPA_L8]
    ///          ON [LPA_L8].[CountryRegionCode] = [LPA_L7].[CountryRegionCode])</remarks>
    public static IQueryable<CustomerListLinqedTypedList> GetCustomerListLinqedTypedList(int maxNumberOfItemsToReturn)
    {
      var customers = MetaSingletons.MetaData.Customer.AsQueryable();
      customers = customers.Where(c => c.CustomerID > 10);
      var cityName = "London";
      if (cityName != "")
        customers = from customer in customers
                    where customer.CustomerAddresses.Any(ca => ca.Address.City == cityName)
                    select customer;

      return CustomerListLinqedTypedList.GetCustomerListQuery(customers).Take(maxNumberOfItemsToReturn);
    }

    /// <summary>
    /// Gets the customer list with an anonymous linq projection.
    /// </summary>
    /// <param name="maxNumberOfItemsToReturn">The max number of items to return.</param>
    /// <returns></returns>    
    /// <remarks>http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=14170
    /// SQL Output:
    ///SELECT [LPA_L3].[ADDRESSLINE1],
    ///       [LPA_L3].[ADDRESSLINE2],
    ///       [LPA_L3].[CITY],
    ///       [LPA_L4].[NAME]           AS [ADDRESSTYPE],
    ///       [LPA_L6].[TITLE],
    ///       [LPA_L6].[FIRSTNAME],
    ///       [LPA_L6].[MIDDLENAME],
    ///       [LPA_L6].[LASTNAME],
    ///       [LPA_L6].[SUFFIX],
    ///       [LPA_L6].[EMAILADDRESS],
    ///       [LPA_L6].[EMAILPROMOTION],
    ///       [LPA_L8].[NAME]           AS [COUNTRYREGIONNAME],
    ///       [LPA_L7].[NAME]           AS [STATEPROVINCENAME],
    ///       [LPA_L1].[CustomerID]     AS [CustomerID]
    ///FROM   ((((((([ADVENTUREWORKS].[SALES].[CUSTOMER] [LPA_L1]
    ///              INNER JOIN [ADVENTUREWORKS].[SALES].[CUSTOMERADDRESS] [LPA_L2]
    ///                ON ([LPA_L1].[CustomerID] = [LPA_L2].[CustomerID]))
    ///             INNER JOIN [ADVENTUREWORKS].[PERSON].[ADDRESS] [LPA_L3]
    ///               ON [LPA_L3].[ADDRESSID] = [LPA_L2].[ADDRESSID])
    ///            INNER JOIN [ADVENTUREWORKS].[PERSON].[ADDRESSTYPE] [LPA_L4]
    ///              ON [LPA_L4].[ADDRESSTYPEID] = [LPA_L2].[ADDRESSTYPEID])
    ///           INNER JOIN [ADVENTUREWORKS].[SALES].[INDIVIDUAL] [LPA_L5]
    ///             ON [LPA_L1].[CustomerID] = [LPA_L5].[CustomerID])
    ///          INNER JOIN [ADVENTUREWORKS].[PERSON].[CONTACT] [LPA_L6]
    ///            ON [LPA_L6].[CONTACTID] = [LPA_L5].[CONTACTID])
    ///         INNER JOIN [ADVENTUREWORKS].[PERSON].[STATEPROVINCE] [LPA_L7]
    ///           ON [LPA_L7].[STATEPROVINCEID] = [LPA_L3].[STATEPROVINCEID])
    ///        INNER JOIN [ADVENTUREWORKS].[PERSON].[COUNTRYREGION] [LPA_L8]
    ///          ON [LPA_L8].[COUNTRYREGIONCODE] = [LPA_L7].[COUNTRYREGIONCODE])</remarks>
    public static IQueryable GetCustomerListAnonymousLinq(int maxNumberOfItemsToReturn)
    {
      var customerlist = from customer in MetaSingletons.MetaData.Customer
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
      return customerlist.Take(maxNumberOfItemsToReturn);
    }

    /// <summary>
    /// Gets the customer view related with linq.
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// SELECT TOP 1 [LPLA_1].[SalesOrderID] AS [SalesOrderId],
    ///       [LPLA_1].[RevisionNumber]                      ,
    ///       [LPLA_1].[OrderDate]                           ,
    ///       [LPLA_1].[DueDate]                             ,
    ///       [LPLA_1].[ShipDate]                            ,
    ///       [LPLA_1].[Status]                              ,
    ///       [LPLA_1].[OnlineOrderFlag]                     ,
    ///       [LPLA_1].[SalesOrderNumber]                    ,
    ///       [LPLA_1].[PurchaseOrderNumber]                 ,
    ///       [LPLA_1].[AccountNumber]                       ,
    ///       [LPLA_1].[CustomerID]      AS [CustomerID]          ,
    ///       [LPLA_1].[ContactID]       AS [ContactId]           ,
    ///       [LPLA_1].[SalesPersonID]   AS [SalesPersonId]       ,
    ///       [LPLA_1].[TerritoryID]     AS [TerritoryId]         ,
    ///       [LPLA_1].[BillToAddressID] AS [BillToAddressId]     ,
    ///       [LPLA_1].[ShipToAddressID] AS [ShipToAddressId]     ,
    ///       [LPLA_1].[ShipMethodID]    AS [ShipMethodId]        ,
    ///       [LPLA_1].[CreditCardID]    AS [CreditCardId]        ,
    ///       [LPLA_1].[CreditCardApprovalCode]                   ,
    ///       [LPLA_1].[CurrencyRateID] AS [CurrencyRateId]       ,
    ///       [LPLA_1].[SubTotal]                                 ,
    ///       [LPLA_1].[TaxAmt]                                   ,
    ///       [LPLA_1].[Freight]                                  ,
    ///       [LPLA_1].[TotalDue]                                 ,
    ///       [LPLA_1].[Comment]                                  ,
    ///       [LPLA_1].[rowguid] AS [Rowguid]                     ,
    ///       [LPLA_1].[ModifiedDate]
    ///FROM   [AdventureWorks].[Sales].[SalesOrderHeader] [LPLA_1]
    ///WHERE ( ( ( ( [LPLA_1].[SalesOrderID] = @SalesOrderId1))))
    /// .
    ///SELECT [AdventureWorks].[Sales].[vIndividualCustomer].[CustomerID] AS [CustomerID],
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[Title]                     ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[FirstName]                 ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[MiddleName]                ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[LastName]                  ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[Suffix]                    ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[Phone]                     ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[EmailAddress]              ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[EmailPromotion]            ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[AddressType]               ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[AddressLine1]              ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[AddressLine2]              ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[City]                      ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[StateProvinceName]         ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[PostalCode]                ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[CountryRegionName]         ,
    ///       [AdventureWorks].[Sales].[vIndividualCustomer].[Demographics]
    ///FROM   [AdventureWorks].[Sales].[vIndividualCustomer]
    ///WHERE ( ( [AdventureWorks].[Sales].[vIndividualCustomer].[CustomerID] = @CustomerID1)) </remarks>
    public static CustomerViewRelatedEntity GetCustomerViewRelatedLinq()
    {
      return MetaSingletons.MetaData.SalesOrderHeader.First(soh => soh.SalesOrderID == 46117).CustomerViewRelated;
    }
  }
}