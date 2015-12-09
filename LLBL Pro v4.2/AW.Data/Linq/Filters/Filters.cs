using System;
using System.Collections.Generic;
using System.Linq;
using AW.Data.EntityClasses;
using AW.Data.TypedViewClasses;
using AW.Data.ViewModels;

namespace AW.Data.Linq.Filters
{
  public static class Filters
  {
    public static IQueryable<AddressEntity> FilterByCity(this IQueryable<AddressEntity> addressQuery, string cityName = null)
    {
      return string.IsNullOrEmpty(cityName) ? addressQuery : addressQuery.Where(c => c.City == cityName);
    }

    public static IQueryable<SpecialOfferProductEntity> FilterByProducts(this IQueryable<SpecialOfferProductEntity> orders, params int[] productIds)
    {
      if (productIds != null && productIds.Length > 0)
        return from e in orders
          from o in e.SalesOrderDetails
          where productIds.Contains(o.ProductID)
          select e;
      return orders;
    }

    public static IQueryable<SalesOrderHeaderEntity> FilterBySpecialOfferProductQuery(this IQueryable<SalesOrderHeaderEntity> orderQuery, IQueryable<SpecialOfferProductEntity> productQuery)
    {
      return from o in orderQuery
        from od in o.SalesOrderDetails
        from p in productQuery
             where p.ProductID == od.ProductID
        select o;
    }

    public static IQueryable<VendorEntity> FilterByProductQuery(this IQueryable<VendorEntity> vendorQuery, IQueryable<ProductEntity> productQuery)
    {
      return from vendor in vendorQuery
             from productVendor in vendor.ProductVendors
             from p in productQuery
             where productVendor.ProductID == p.ProductID
             select vendor;
    }

    public static IQueryable<ProductEntity> FilterByVendorQuery(this IQueryable<ProductEntity> productQuery, IQueryable<VendorEntity> vendorQuery)
    {
      return  from p in productQuery
             from productVendor in p.ProductVendors
            from vendor in vendorQuery
             where productVendor.ProductID == p.ProductID
             select p;
    }

    public static IQueryable<ProductEntity> FilterByUnitMeasureCode(this IQueryable<ProductEntity> productQuery, params string[] unitMeasureCodes)
    {
      return from p in productQuery
             from billOfMaterialEntity in p.BillOfAssemblyMaterials
             where unitMeasureCodes.Contains(billOfMaterialEntity.UnitMeasureCode)
             select p;
    }

    public static IQueryable<ProductEntity> FilterByStockedQuantity(this IQueryable<ProductEntity> productQuery, int stockedQuantity)
    {
      return from p in productQuery
             from workOrderEntity in p.WorkOrders
             where workOrderEntity.StockedQuantity==stockedQuantity
             select p;
    }

    public static IQueryable<T> FilterBySalesOrderIDs<T>(this IQueryable<T> customerQuery, params int[] salesOrderIDs) where T : CustomerEntity
    {
      if (salesOrderIDs != null && salesOrderIDs.Length > 0)
        customerQuery = from customerEntity in customerQuery
          from salesOrderHeaderEntity in customerEntity.SalesOrderHeaders
          where salesOrderIDs.Contains(salesOrderHeaderEntity.SalesOrderID)
          select customerEntity;
      return customerQuery;
    }

    public static IQueryable<T> FilterBySalesPersonID<T>(this IQueryable<T> customerQuery, params int[] salesPersonIDs) where T : CustomerEntity
    {
      if (salesPersonIDs != null && salesPersonIDs.Length > 0)
        customerQuery = from customerEntity in customerQuery
          from orderEntity in customerEntity.SalesOrderHeaders
          where salesPersonIDs.Contains(orderEntity.SalesPersonID.Value)
          select customerEntity;
      return customerQuery;
    }

    public static IQueryable<CustomerViewRelatedEntity> FilterByDateOrderIDOrderNumberCustomerNameAddress(this IQueryable<CustomerViewRelatedEntity> customerViewQuery,
      OrderSearchCriteria orderSearchCriteria)
    {
      customerViewQuery = customerViewQuery.FilterByDateCustomerNameAddress(orderSearchCriteria);
      if (orderSearchCriteria.OrderID != 0)
        customerViewQuery = from cv in customerViewQuery
          from soh in cv.SalesOrderHeader
          where soh.SalesOrderID == orderSearchCriteria.OrderID
          select cv;

      if (!string.IsNullOrEmpty(orderSearchCriteria.OrderNumber))
        customerViewQuery = from cv in customerViewQuery
          from soh in cv.SalesOrderHeader
          where soh.SalesOrderNumber == orderSearchCriteria.OrderNumber
          select cv;

      if (orderSearchCriteria.FromDate != DateTime.MinValue)
        customerViewQuery = from cv in customerViewQuery
          from soh in cv.SalesOrderHeader
          where soh.OrderDate >= orderSearchCriteria.FromDate
          select cv;

      if (orderSearchCriteria.ToDate != DateTime.MinValue)
        customerViewQuery = from cv in customerViewQuery
          from soh in cv.SalesOrderHeader
          where soh.OrderDate <= orderSearchCriteria.ToDate
          select cv;

      return customerViewQuery;
    }

    public static IQueryable<T> FilterIndividualCustomerEntityEntityByDateCustomerNameAddress<T>(this IQueryable<T> customerViewQuery,
      OrderSearchCriteria orderSearchCriteria) where T : class, IIndividualCustomer
    {
      if (!string.IsNullOrEmpty(orderSearchCriteria.FirstName))
        customerViewQuery = customerViewQuery.Where(cv => cv.FirstName.Contains(orderSearchCriteria.FirstName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.LastName))
        customerViewQuery = customerViewQuery.Where(cv => cv.LastName.Contains(orderSearchCriteria.LastName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.CityName))
        customerViewQuery = customerViewQuery.Where(cv => cv.City == orderSearchCriteria.CityName);
      if (!string.IsNullOrEmpty(orderSearchCriteria.StateName))
        customerViewQuery = customerViewQuery.Where(cv => cv.StateProvinceName == orderSearchCriteria.StateName);
      if (orderSearchCriteria.Countries.Any())
        customerViewQuery = from soh in customerViewQuery
          where orderSearchCriteria.Countries.Contains(soh.CountryRegionName)
          select soh;
      return customerViewQuery;
    }

    public static IQueryable<T> FilterByDateCustomerNameAddress<T>(this IQueryable<T> customerViewQuery,
      OrderSearchCriteria orderSearchCriteria) where T : class, IIndividualCustomer
    {
      if (!string.IsNullOrEmpty(orderSearchCriteria.FirstName))
        customerViewQuery = customerViewQuery.Where(cv => cv.FirstName.Contains(orderSearchCriteria.FirstName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.LastName))
        customerViewQuery = customerViewQuery.Where(cv => cv.LastName.Contains(orderSearchCriteria.LastName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.CityName))
        customerViewQuery = customerViewQuery.Where(cv => cv.City == orderSearchCriteria.CityName);
      if (!string.IsNullOrEmpty(orderSearchCriteria.StateName))
        customerViewQuery = customerViewQuery.Where(cv => cv.StateProvinceName == orderSearchCriteria.StateName);
      if (orderSearchCriteria.Countries.Any())
        customerViewQuery = from soh in customerViewQuery
          where orderSearchCriteria.Countries.Contains(soh.CountryRegionName)
          select soh;
      return customerViewQuery;
    }

    public static IQueryable<IndividualEntity> FilterByDateOrderIDOrderNumberCustomerNameAddress(this IQueryable<IndividualEntity> individualQuery,
      OrderSearchCriteria orderSearchCriteria)
    {
      if (!string.IsNullOrEmpty(orderSearchCriteria.FirstName))
        individualQuery = individualQuery.Where(i => i.Contact.FirstName.Contains(orderSearchCriteria.FirstName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.LastName))
        individualQuery = individualQuery.Where(i => i.Contact.LastName.Contains(orderSearchCriteria.LastName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.CityName))
        individualQuery = individualQuery.Where(i => i.CustomerAddresses.Any(ca => ca.Address.City == orderSearchCriteria.CityName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.StateName))
        individualQuery = individualQuery.Where(i => i.CustomerAddresses.Any(ca => ca.Address.StateProvince.Name == orderSearchCriteria.StateName));
      if (!string.IsNullOrEmpty(orderSearchCriteria.CountryName))
        individualQuery = individualQuery.Where(i => i.CustomerAddresses.Any(ca => ca.Address.StateProvince.CountryRegion.Name == orderSearchCriteria.CountryName));
      if (orderSearchCriteria.Countries.Any())
        individualQuery = individualQuery.Where(i => i.CustomerAddresses.Any(ca => orderSearchCriteria.Countries.Contains(ca.Address.StateProvince.CountryRegion.Name)));
      if (!string.IsNullOrEmpty(orderSearchCriteria.Zip))
        individualQuery = individualQuery.Where(i => i.CustomerAddresses.Any(ca => ca.Address.PostalCode == orderSearchCriteria.Zip));
      if (orderSearchCriteria.FromDate != DateTime.MinValue)
        individualQuery = individualQuery.Where(i => i.SalesOrderHeaders.Any(soh => soh.OrderDate >= orderSearchCriteria.FromDate));
      if (orderSearchCriteria.ToDate != DateTime.MinValue)
        individualQuery = individualQuery.Where(i => i.SalesOrderHeaders.Any(soh => soh.OrderDate <= orderSearchCriteria.ToDate));
      if (orderSearchCriteria.OrderID != 0)
        individualQuery = individualQuery.Where(i => i.SalesOrderHeaders.Any(soh => soh.SalesOrderID == orderSearchCriteria.OrderID));
      if (!string.IsNullOrEmpty(orderSearchCriteria.OrderNumber))
        individualQuery = individualQuery.Where(i => i.SalesOrderHeaders.Any(soh => soh.SalesOrderNumber == orderSearchCriteria.OrderNumber));
      return individualQuery;
    }

    public static IQueryable<T> FilterByProductID<T>(this IQueryable<T> transactionHistoryEntities, int productID) where T : TransactionHistoryEntity
    {
      return transactionHistoryEntities.Where(th => th.ProductID == productID);
    }

    public static IQueryable<T> FilterByProductIDWithLet<T>(this IQueryable<T> transactionHistoryEntities, int productID) where T : TransactionHistoryEntity
    {
      return from th in transactionHistoryEntities
        let soh = th as SalesOrderHistoryEntity
        where soh.ProductID == productID
        select th;
    }

    public static IQueryable<T> FilterByProductNumberWithLet<T>(this IQueryable<T> transactionHistoryEntities, string productNumber) where T : TransactionHistoryEntity
    {
      return from th in transactionHistoryEntities
        let soh = th as SalesOrderHistoryEntity
        where soh.Product.ProductNumber == productNumber
        select th;
    }

    public static IQueryable<T> FilterByProductNumber<T>(this IQueryable<T> transactionHistoryEntities, string productNumber) where T : TransactionHistoryEntity
    {
      return from th in transactionHistoryEntities
        where th.Product.ProductNumber == productNumber
        select th;
    }

    public static IQueryable<T> FilterByProductNumberWithJoin<T>(this IQueryable<T> transactionHistoryEntities, string productNumber) where T : TransactionHistoryEntity
    {
      return from th in transactionHistoryEntities
        join p in MetaSingletons.MetaData.Product on th.ProductID equals p.ProductID
        where p.ProductNumber == productNumber
        select th;
    }
  }
}