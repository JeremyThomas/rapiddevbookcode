/*
 * Copyright © 2012
 * This code is for the codeproject article "A N-Tier Architecture Sample with ASP.NET MVC3, WCF and Entity Framework" at  
 * http://www.codeproject.com/Articles/434282/A-N-Tier-Architecture-Sample-with-ASP.NET-MVC3-WCF-and-Entity-Framework. 
 * Permission to use, copy or modify this software freely is hereby granted, 
 * provided that this copyright notice appears in the orginal or modified copies. 
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
using System.Linq;
using System.ServiceModel;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Interfaces
{
  [ServiceContract]
  [ServiceKnownType(typeof (EntityCollection))]
  [ServiceKnownType(typeof (EntityField2))]
  [ServiceKnownType(typeof(SD.LLBLGen.Pro.ORMSupportClasses.UnitOfWork2))]
  public interface ILLBLPersistance // : INorthwindLinqMetaData
  {
    [OperationContract]
    void Commit(IUnitOfWorkCore uow);

    IQueryable<CategoryEntity> Category { [OperationContract] get; }
    IQueryable<CustomerEntity> Customer { [OperationContract] get; }

    IQueryable<OrderEntity> Order { [OperationContract] get; }

    IQueryable<ProductEntity> Product { [OperationContract] get; }

    IQueryable<SupplierEntity> Supplier { [OperationContract] get; }


    // [OperationContract]
    IQueryable GetQueryableForEntity(Type entityType);
  }
}