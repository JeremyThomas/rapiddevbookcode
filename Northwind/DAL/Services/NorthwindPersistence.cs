using System;
using System.Linq;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.Interfaces;
using Northwind.DAL.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Services
{
  public class NorthwindPersistence : AdapterPersistence
  {
    public NorthwindPersistence()
      : base(Factories.CreateDataAccessAdapter, new NorthwindQueryableProvider())
    {
    }
  }

  public class NorthwindQueryableProvider: IAdapterQueryableProvider
  {

    public IQueryable<TEntity> GetQueryableForEntity<TEntity>(Func<DataAccessAdapterBase> dataAccessAdapterFactory) where TEntity : class
    {
      var linqMetaData = new LinqMetaData(dataAccessAdapterFactory());
      return linqMetaData.GetQueryableForEntity<TEntity>();
    }
  }
  
}