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
using Northwind.DAL.Interfaces;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.HelperClasses
{
  public static class PersistSvr
  {
    private static IPersistence _provider;

    public static Func<IPersistence> ProviderImplementation;

    public static IPersistence PersistenceProvider
    {
      get
      {
        if (_provider == null) _provider = ProviderImplementation();
        return _provider;
      }
      set { _provider = value; }
    }

    public static void Insert(IEntity2 entity, bool commit)
    {
      PersistenceProvider.Save(entity, commit);
    }

    public static void Update(IEntity2 entity, bool commit)
    {
      PersistenceProvider.Save(entity, commit);
    }

    public static void Delete(IEntity2 entity, bool commit)
    {
      PersistenceProvider.Delete(entity, commit);
    }

    public static void Commit()
    {
      PersistenceProvider.Commit();
    }


    public static IQueryable<T> GetAll<T>() where T : class
    {
      return PersistenceProvider.GetQueryableForEntity<T>();
    }
  }
}