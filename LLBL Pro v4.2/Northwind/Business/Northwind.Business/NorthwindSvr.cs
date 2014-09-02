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
using System.Data.Entity;
using System.Data.Objects;
using System.Data.Services.Client;
using System.Linq;
using System.ServiceModel;
using GH.Common.Framework.Persistence;
using GH.Common.Framework.Persistence.DataServiceCxt;
using GH.Common.ServiceLocator;
using GH.Northwind.Business.Entities;
using GH.Northwind.EntityFramework;
using GH.Northwind.Persistence.DataServiceCxt;
using Northwind.DAL;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.Interfaces;


namespace GH.Northwind.Business
{
    using ObjectCxtNamespace = Persistence.ObjectCxt;
    using DbCxtNamespace = Persistence.DbCxt;
    using DataServiceCxtNamespace = Persistence.DataServiceCxt;
    using ObjectCxtFrameWkNamespace = Common.Framework.Persistence.ObjectCxt;
    using DbCxtFrameWkNamespace = Common.Framework.Persistence.DbCxt;
    using DataServiceCxtFrameWkNamespace = Common.Framework.Persistence.DataServiceCxt;

    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Multiple,InstanceContextMode = InstanceContextMode.PerCall)]
    public class NorthwindSvr : INorthwindSvr
    {
        static NorthwindSvr()
        {
            string useWcfDataService = ConfigurationManager.AppSettings["UseWcfDataService"];
            if (useWcfDataService.ToLower() == "true")
            {
                string dataServiceUrl = ConfigurationSettings.AppSettings["WcfDataServiceUrl"];
                DataCxt.Cxt = new DataServiceContext(new Uri(dataServiceUrl));
                ServiceLocator<IPersistence<CustomerEntity>>.RegisterService<CustomerPrst>();
                ServiceLocator<IPersistence<ProductEntity>>.RegisterService<ProductPrst>();
                ServiceLocator<IPersistence<OrderEntity>>.RegisterService<OrderPrst>();
                ServiceLocator<IPersistence<OrderDetailEntity>>.RegisterService<Order_DetailPrst>();
                ServiceLocator<IPersistence<CategoryEntity>>.RegisterService<CategoryPrst>();
                ServiceLocator<IPersistence<SupplierEntity>>.RegisterService<SupplierPrst>();
            }
            else
            {
                if (typeof (NorthwindEntities).IsSubclassOf(typeof (ObjectContext)))
                {
                    // Below are commented out since now NorthwindEntities is DbContext; Uncomment them out if NorthwindEntities is ObjectContext; 

                    /*ObjectCxtFrameWkNamespace.DataCxt.Cxt = new NorthwindEntities(); 
                    ServiceLocator<IPersistence<CustomerEntity>>.RegisterService<ObjectCxtNamespace.CustomerPrst>();
                    ServiceLocator<IPersistence<ProductEntity>>.RegisterService<ObjectCxtNamespace.ProductPrst>();
                    ServiceLocator<IPersistence<OrderEntity>>.RegisterService<ObjectCxtNamespace.OrderPrst>();
                    ServiceLocator<IPersistence<OrderDetailEntity>>.RegisterService<ObjectCxtNamespace.Order_DetailPrst>();
                    ServiceLocator<IPersistence<Category>>.RegisterService<ObjectCxtNamespace.CategoryPrst>();
                    ServiceLocator<IPersistence<Supplier>>.RegisterService<ObjectCxtNamespace.SupplierPrst>();
                     */
                }
                else if (typeof (NorthwindEntities).IsSubclassOf(typeof (DbContext)))
                {
                    Common.Framework.Persistence.DbCxt.DataCxt.Cxt = new NorthwindEntities();
                    ServiceLocator<IPersistence<CustomerEntity>>.RegisterService<Persistence.DbCxt.CustomerPrst>();
                    ServiceLocator<IPersistence<ProductEntity>>.RegisterService<Persistence.DbCxt.ProductPrst>();
                    ServiceLocator<IPersistence<OrderEntity>>.RegisterService<Persistence.DbCxt.OrderPrst>();
                    ServiceLocator<IPersistence<OrderDetailEntity>>.RegisterService<Persistence.DbCxt.Order_DetailPrst>();
                    ServiceLocator<IPersistence<Category>>.RegisterService<Persistence.DbCxt.CategoryPrst>();
                    ServiceLocator<IPersistence<Supplier>>.RegisterService<Persistence.DbCxt.SupplierPrst>();
                }
                else
                {
                    throw new NotSupportedException("NorthwindSvr: static Constructor: " + typeof (NorthwindEntities) +
                                                    " isn't a supported type.");
                }
            }
        }

        public List<CustomerEntity> GetCustomers()
        {
            return PersistSvr<CustomerEntity>.GetAll().ToList();
        }

        public void InsertCustomer(CustomerEntity CustomerEntity, bool commit)
        {
            PersistSvr<CustomerEntity>.Insert(CustomerEntity, commit);
        }

        public void UpdateCustomer(CustomerEntity currentCustomer, bool commit)
        {
            PersistSvr<CustomerEntity>.Update(currentCustomer, commit);
        }

        public void DeleteCustomer(String customerId, bool commit)
        {
            IQueryable<CustomerEntity> qCustomer = PersistSvr<CustomerEntity>.GetAll();
            List<CustomerEntity> cus = (from c in qCustomer where c.CustomerID == customerId select c).ToList();
            if (cus.Count <= 0)
                throw new ApplicationException("NorthwindSvr::DeleteCustomer: CustomerEntity with Id " + customerId +
                                               " doesn't exist.");
            PersistSvr<CustomerEntity>.Delete(cus[0], commit);
        }

        public List<OrderEntity> GetOrders()
        {
            return PersistSvr<OrderEntity>.GetAll().ToList();
        }

        public List<OrderDetailEntity> GetOrderDetailForAnOrder(int orderId)
        {
            IQueryable<OrderDetailEntity> qOrder_Detail = PersistSvr<OrderDetailEntity>.GetAll();
            List<OrderDetailEntity> ods = (from od in qOrder_Detail where od.OrderID == orderId select od).ToList();
            return ods;
        }

        public List<OrderEntity> GetOrderForACustomer(String customerId)
        {
            IQueryable<OrderEntity> qOrder = PersistSvr<OrderEntity>.GetAll();
            List<OrderEntity> orders = (from o in qOrder where o.CustomerID == customerId select o).ToList();
            return orders;
        }

        public void CreateOrder(OrderEntity OrderEntity, OrderDetailEntity[] details)
        {
            PersistSvr<OrderEntity>.Insert(OrderEntity, true);
            foreach (var od in details)
            {
                od.OrderID = OrderEntity.OrderID;
                PersistSvr<OrderDetailEntity>.Insert(od, true);
            }
        }

        public void UpdateOrder(OrderEntity currentOrder, OrderDetailEntity[] details, bool commit)
        {
            PersistSvr<OrderEntity>.Update(currentOrder, commit);
            foreach (var od in details)
            {
                PersistSvr<OrderDetailEntity>.Update(od, commit);
            }
        }

        public void DeleteAnOrderDetailFromAnOrder(int orderId, int productId, bool commit)
        {
            IQueryable<OrderDetailEntity> qOrder_Detail = PersistSvr<OrderDetailEntity>.GetAll();
            List<OrderDetailEntity> ods =
                (from od in qOrder_Detail where od.ProductID == productId && od.OrderID == orderId select od).ToList();
            if (ods.Count <= 0)
                throw new ApplicationException(
                    "NorthwindSvr::DeleteAnOrderDetailFromAnOrder: OrderEntity detail with OrderEntity id " + orderId.ToString() +
                    " and ProductEntity id: " + productId.ToString() +
                    " doesn't exist.");
            PersistSvr<OrderDetailEntity>.Delete(ods[0], commit);
        }

        public void DeleteOrder(int orderId, bool commit)
        {
            IQueryable<OrderEntity> qOrder = PersistSvr<OrderEntity>.GetAll();
            List<OrderEntity> orders = (from o in qOrder where o.OrderID == orderId select o).ToList();
            if (orders.Count <= 0)
                throw new ApplicationException("NorthwindSvr::DeleteOrder: ProductEntity with Id " + orderId.ToString() +
                                               " doesn't exist.");
            // Delete each OrderEntity detail
            List<OrderDetailEntity> orderDetails = GetOrderDetailForAnOrder(orders[0].OrderID);
            foreach (var od in orderDetails)
            {
                DeleteAnOrderDetailFromAnOrder(orders[0].OrderID, od.ProductID, commit);
            }
            PersistSvr<OrderEntity>.Delete(orders[0], commit);
        }

        public List<ProductEntity> GetProducts()
        {
            return PersistSvr<ProductEntity>.GetAll().ToList();
        }

        public ProductEntity GetProductById(int id)
        {
            IQueryable<ProductEntity> pds = PersistSvr<ProductEntity>.SearchBy(p => p.ProductID == id);
            return pds.Count() == 0 ? null : pds.First();
        }

        public void InsertProduct(ProductEntity ProductEntity, bool commit)
        {
            PersistSvr<ProductEntity>.Insert(ProductEntity, commit);
        }

        public void UpdateProduct(ProductEntity currentProduct, bool commit)
        {
            PersistSvr<ProductEntity>.Update(currentProduct, commit);
        }

        public void DeleteProduct(int productId, bool commit)
        {
            IQueryable<ProductEntity> qProduct = PersistSvr<ProductEntity>.GetAll();
            List<ProductEntity> pros = (from p in qProduct where p.ProductID == productId select p).ToList();
            if (pros.Count <= 0)
                throw new ApplicationException("NorthwindSvr::DeleteProduct: ProductEntity with Id " + productId.ToString() +
                                               " doesn't exist.");
            PersistSvr<ProductEntity>.Delete(pros[0], commit);
        }

        
        public List<Category> GetProductCategories()
        {
            return PersistSvr<Category>.GetAll().ToList();
        }


        public List<SupplierEntity> GetSuppliers()
        {
            return PersistSvr<Supplier>.GetAll().ToList();
        }

        public void Commit()
        {
            //In our implementation, any entity's commit will do the same: commit all changes to the database
            // so PersistSvr<OrderEntity>.Commit() and PersistSvr<ProductEntity>.Commit() will do the same.
            PersistSvr<OrderEntity>.Commit();
        }
    }
}