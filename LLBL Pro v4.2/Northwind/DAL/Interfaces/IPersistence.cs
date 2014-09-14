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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Interfaces
{

  public interface IPersistence
  {

    void Save(IEntity2 entity, bool commit = true);

 
    void Delete(IEntity2 entity, bool commit = true);

  
    void Commit();

    IQueryable<TEntity> GetQueryableForEntity<TEntity>() where TEntity : class;
  }

  public interface IAdapterQueryableProvider
  {
    IQueryable<TEntity> GetQueryableForEntity<TEntity>(Func<DataAccessAdapterBase> dataAccessAdapterFactory) where TEntity : class;
  }
}