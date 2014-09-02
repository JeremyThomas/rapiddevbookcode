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
using System.Linq.Expressions;

namespace Northwind.DAL.Interfaces
{
    public interface IPersistence<T>
    {
        void Insert(T entity, bool commit);
        void Update(T entity, bool commit);
        void Delete(T entity, bool commit);
        void Commit();
        IQueryable<T> SearchBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
    }
}