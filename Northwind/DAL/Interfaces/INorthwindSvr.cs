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
using System.ServiceModel;
using Northwind.DAL.EntityClasses;

namespace Northwind.DAL.Interfaces
{
    [ServiceContract]
    public interface INorthwindSvr
    {
        [OperationContract]
        List<CustomerEntity> GetCustomers();

        [OperationContract]
        void InsertCustomer(CustomerEntity customerEntity, bool commit);

        [OperationContract]
        void UpdateCustomer(CustomerEntity currentCustomer, bool commit);

        [OperationContract]
        void DeleteCustomer(String customerId, bool commit);

        [OperationContract]
        List<OrderEntity> GetOrders();

        [OperationContract]
        List<OrderDetailEntity> GetOrderDetailForAnOrder(int orderId);

        [OperationContract]
        List<OrderEntity> GetOrderForACustomer(String customerId);

        [OperationContract]
        void CreateOrder(OrderEntity orderEntity, OrderDetailEntity[] details);

        [OperationContract]
        void UpdateOrder(OrderEntity currentOrder, OrderDetailEntity[] details, bool commit);

        [OperationContract]
        void DeleteOrder(int orderId, bool commit);

        [OperationContract]
        void DeleteAnOrderDetailFromAnOrder(int orderId, int orderDetailId, bool commit);

        [OperationContract]
        List<ProductEntity> GetProducts();

        [OperationContract]
        ProductEntity GetProductById(int id);

        [OperationContract]
        void InsertProduct(ProductEntity productEntity, bool commit);

        [OperationContract]
        void UpdateProduct(ProductEntity currentProduct, bool commit);

        [OperationContract]
        void DeleteProduct(int productId, bool commit);

        [OperationContract]
        List<CategoryEntity> GetProductCategories();

        [OperationContract]
        List<SupplierEntity> GetSuppliers();

        [OperationContract]
        void Commit();
    }
}