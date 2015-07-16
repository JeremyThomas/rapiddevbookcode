//css_ref SD.LLBLGen.Pro.ORMSupportClasses.dll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Northwind.DAL;
using Northwind.DAL.DTO;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.Linq;
using Northwind.DAL.Linq.Filters;
using Northwind.DAL.SqlServer;
using AW.Helper.LLBL;

public static class Script 
{
  public static IEnumerable Query()
  {
    return (from p in (new LinqMetaData(new DataAccessAdapter("Data Source=(local);Initial Catalog=Northwind;Integrated Security=True"))).Product
           from od in p.OrderDetails.DefaultIfEmpty()
           where od.Quantity < 2
           select p).ToEntityCollection2();
  }
       
}