using System;
using System.Linq;
using AW.Helper.LLBL;
using Northwind.DAL.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Linq
{
  partial class LinqMetaData: INorthwindLinqMetaData
  {
    static LinqMetaData()
    {
      CommonEntityBase.Initialize();
    }

    public static void Initialize()
    {
    }
  }

  public class NorthwindQueryableProvider : IAdapterQueryableProvider
  {

    public IQueryable<TEntity> GetQueryableForEntity<TEntity>(Func<DataAccessAdapterBase> dataAccessAdapterFactory) where TEntity : class
    {
      var linqMetaData = new LinqMetaData(dataAccessAdapterFactory());
      return linqMetaData.GetQueryableForEntity<TEntity>();
    }
  }
}