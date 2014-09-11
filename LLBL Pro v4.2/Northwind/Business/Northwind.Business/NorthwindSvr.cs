/*
 * Copyright © 2012
 * This code is for the codeproject.com article "N-Tier Architecture and Tips" at  
 * http://www.codeproject.com/Articles/434282/A-N-Tier-Architecture-Sample-with-ASP.NET-MVC3-WCF-and-Entity-Framework. 
 * Permission to use, copy or modify this software freely is hereby granted, 
 * provided that this copyright notice appears in all orginal or modified copies 
 * 
 * This code isn't guaranteed to work correctly; it is your own responsibility for 
 * any result from using this code. 
 *                           
 * @description
 * 
 * @author  
 * @version July 18, 2012
 * @see
 * @since
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.Interfaces;
using Northwind.DAL.Services;

namespace Northwind.Business
{
  [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall)]
  public class NorthwindSvr : INorthwindSvr
  {
    static NorthwindSvr()
    {
      var useWcfDataService = ConfigurationManager.AppSettings["UseWcfDataService"];
      if (useWcfDataService.ToLower() == "true")
      {
        var dataServiceUrl = ConfigurationSettings.AppSettings["WcfDataServiceNorthwindLLBLPersistenceUrl"];
        //DataCxt.Cxt = new DataServiceContext(new Uri(dataServiceUrl));
        PersistSvr.PersistenceProvider = new ProLinqPersistence(dataServiceUrl);
        // PersistSvr
      }
      else
      {
        PersistSvr.PersistenceProvider = new NorthwindPersistence();
      }
    }

    public List<CustomerEntity> GetCustomers()
    {
      return PersistSvr.GetAll<CustomerEntity>().ToList();
    }

    public void InsertCustomer(CustomerEntity customerEntity, bool commit)
    {
      PersistSvr.Insert(customerEntity, commit);
    }

    public void UpdateCustomer(CustomerEntity currentCustomer, bool commit)
    {
      PersistSvr.Update(currentCustomer, commit);
    }

    public void DeleteCustomer(String customerId, bool commit)
    {
      var qCustomer = PersistSvr.GetAll<CustomerEntity>();
      var cus = (from c in qCustomer where c.CustomerId == customerId select c).ToList();
      if (cus.Count <= 0)
        throw new ApplicationException("NorthwindSvr::DeleteCustomer: CustomerEntity with Id " + customerId +
                                       " doesn't exist.");
      PersistSvr.Delete(cus[0], commit);
    }

    public List<OrderEntity> GetOrders()
    {
      return PersistSvr.GetAll<OrderEntity>().ToList();
    }

    public List<OrderDetailEntity> GetOrderDetailForAnOrder(int orderId)
    {
      var qOrderDetail = PersistSvr.GetAll<OrderDetailEntity>();
      var ods = (from od in qOrderDetail where od.OrderId == orderId select od).ToList();
      return ods;
    }

    public List<OrderEntity> GetOrderForACustomer(String customerId)
    {
      var qOrder = PersistSvr.GetAll<OrderEntity>();
      var orders = (from o in qOrder where o.CustomerId == customerId select o).ToList();
      return orders;
    }

    public void CreateOrder(OrderEntity orderEntity, OrderDetailEntity[] details)
    {
      PersistSvr.Insert(orderEntity, true);
      foreach (var od in details)
      {
        od.OrderId = orderEntity.OrderId;
        PersistSvr.Insert(od, true);
      }
    }

    public void UpdateOrder(OrderEntity currentOrder, OrderDetailEntity[] details, bool commit)
    {
      PersistSvr.Update(currentOrder, commit);
      foreach (var od in details)
      {
        PersistSvr.Update(od, commit);
      }
    }

    public void DeleteAnOrderDetailFromAnOrder(int orderId, int productId, bool commit)
    {
      var qOrderDetail = PersistSvr.GetAll<OrderDetailEntity>();
      var ods =
        (from od in qOrderDetail where od.ProductId == productId && od.OrderId == orderId select od).ToList();
      if (ods.Count <= 0)
        throw new ApplicationException(
          "NorthwindSvr::DeleteAnOrderDetailFromAnOrder: OrderEntity detail with OrderEntity id " + orderId +
          " and ProductEntity id: " + productId +
          " doesn't exist.");
      PersistSvr.Delete(ods[0], commit);
    }

    public void DeleteOrder(int orderId, bool commit)
    {
      var qOrder = PersistSvr.GetAll<OrderEntity>();
      var orders = (from o in qOrder where o.OrderId == orderId select o).ToList();
      if (orders.Count <= 0)
        throw new ApplicationException("NorthwindSvr::DeleteOrder: ProductEntity with Id " + orderId +
                                       " doesn't exist.");
      // Delete each OrderEntity detail
      var orderDetails = GetOrderDetailForAnOrder(orders[0].OrderId);
      foreach (var od in orderDetails)
      {
        DeleteAnOrderDetailFromAnOrder(orders[0].OrderId, od.ProductId, commit);
      }
      PersistSvr.Delete(orders[0], commit);
    }

    public List<ProductEntity> GetProducts()
    {
      return PersistSvr.GetAll<ProductEntity>().ToList();
    }

    public ProductEntity GetProductById(int id)
    {
      var pds = PersistSvr.GetAll<ProductEntity>().Where(p => p.ProductId == id);
      return pds.FirstOrDefault();
    }

    public void InsertProduct(ProductEntity productEntity, bool commit)
    {
      PersistSvr.Insert(productEntity, commit);
    }

    public void UpdateProduct(ProductEntity currentProduct, bool commit)
    {
      PersistSvr.Update(currentProduct, commit);
    }

    public void DeleteProduct(int productId, bool commit)
    {
      var qProduct = PersistSvr.GetAll<ProductEntity>();
      var pros = (from p in qProduct where p.ProductId == productId select p).ToList();
      if (pros.Count <= 0)
        throw new ApplicationException("NorthwindSvr::DeleteProduct: ProductEntity with Id " + productId +
                                       " doesn't exist.");
      PersistSvr.Delete(pros[0], commit);
    }


    public List<CategoryEntity> GetProductCategories()
    {
      return PersistSvr.GetAll<CategoryEntity>().ToList();
    }


    public List<SupplierEntity> GetSuppliers()
    {
      return PersistSvr.GetAll<SupplierEntity>().ToList();
    }

    public void Commit()
    {
      //In our implementation, any entity's commit will do the same: commit all changes to the database
      // so PersistSvr<OrderEntity>.Commit() and PersistSvr<ProductEntity>.Commit() will do the same.
      PersistSvr.Commit();
    }
  }
}