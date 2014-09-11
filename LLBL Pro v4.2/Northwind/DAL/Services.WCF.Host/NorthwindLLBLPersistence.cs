using System;
using System.Linq;
using System.Reflection;
using AW.Helper.LLBL;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.Interfaces;
using Northwind.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Serialize.Linq.Extensions;

namespace Northwind.DAL.Services.WCF.Host
{
  public class NorthwindLLBLPersistence : ILLBLPersistance
  {
  //  Lazy<DataAccessAdapterBase> _adapterToUse = new Lazy<DataAccessAdapterBase>
  //(Factories.CreateDataAccessAdapter, true);

    readonly Lazy<LinqMetaData> _linqMetaData = new Lazy<LinqMetaData>
      (() => new LinqMetaData(Factories.CreateDataAccessAdapter()), true);


    public void Commit(IUnitOfWorkCore uow)
    {
      using (var adapter = Factories.CreateDataAccessAdapter())
        uow.Commit(adapter);
    }

    public IQueryable<CustomerEntity> Customer
    {
      get { return _linqMetaData.Value.Customer; }
    }

    public IQueryable<OrderEntity> Order
    {
      get { return _linqMetaData.Value.Order; }
    }

    public IQueryable<ProductEntity> Product
    {
      get
      {
        return GetQueryableForEntity<ProductEntity>();
      }
    }

    public IQueryable<SupplierEntity> Supplier
    {
      get
      {
        return GetQueryableForEntity<SupplierEntity>();
      }
    }

    public IQueryable<CategoryEntity> Category
    {
      get
      {
        return GetQueryableForEntity<CategoryEntity>();
      }
    }

    public DataSource2<TEntity> GetQueryableForEntity<TEntity>()
          where TEntity : class
    {
    
      return _linqMetaData.Value.GetQueryableForEntity<TEntity>();
    }

    public IQueryable GetQueryableForEntity(Type entityType)
    {

      return (IQueryable)_linqMetaData.Value.GetQueryableForEntity(entityType);
    }

 
  }
}