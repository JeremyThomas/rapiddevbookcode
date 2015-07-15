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
using AW.Winforms.Helpers.QueryRunner;

public class Script : MarshalByRefObject, IQueryScript
{
  public IEnumerable Query()
  {
    return from p in (new LinqMetaData(new DataAccessAdapter("Data Source=(local);Initial Catalog=Northwind;Integrated Security=True"))).Product
           from od in p.OrderDetails.DefaultIfEmpty()
           where od.Quantity < 2
           select new { od.Quantity, p.ProductName };
  }
}