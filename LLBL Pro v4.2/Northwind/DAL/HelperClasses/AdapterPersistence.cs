using System;
using System.Linq;
using Northwind.DAL.Interfaces;
using Northwind.DAL.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.HelperClasses
{
  public class AdapterPersistence : IPersistence
  {
    private UnitOfWork2 _unitOfWork;
    private DataAccessAdapterBase _adapterToUse;
    private readonly Func<DataAccessAdapterBase> _dataAccessAdapterFactory;
    //   private readonly Func<IQueryable<TEntity> > x where TEntity : class

    public AdapterPersistence(Func<DataAccessAdapterBase> dataAccessAdapterFactory)
    {
      _dataAccessAdapterFactory = dataAccessAdapterFactory;
    }

    public void Save(IEntity2 entity, bool commit = true)
    {
      if (commit)
        using (var adapter = CreateDataAccessAdapter())
        {
          adapter.SaveEntity(entity);
        }

      else
      {
        Uow.AddForSave(entity);
      }
    }

    private DataAccessAdapterBase CreateDataAccessAdapter()
    {
      return _dataAccessAdapterFactory();
    }

    private UnitOfWork2 Uow
    {
      get { return _unitOfWork ?? (_unitOfWork = new UnitOfWork2()); }
    }

    public void Delete(IEntity2 entity, bool commit = true)
    {
      if (commit)
        using (var adapter = CreateDataAccessAdapter())
        {
          adapter.DeleteEntity(entity);
        }
      else
      {
        Uow.AddForDelete(entity);
      }
    }

    public void Commit()
    {
      if (_unitOfWork != null)
        using (var adapter = CreateDataAccessAdapter())
        {
          _unitOfWork.Commit(adapter);
          _unitOfWork = null;
        }
    }

    public IQueryable<TEntity> GetQueryableForEntity<TEntity>() where TEntity : class
    {
      var linqMetaData = new LinqMetaData(GetAdapter());
      return linqMetaData.GetQueryableForEntity<TEntity>();
    }

    private DataAccessAdapterBase GetAdapter()
    {
      return _adapterToUse = _adapterToUse ?? CreateDataAccessAdapter();
    }
  }
}