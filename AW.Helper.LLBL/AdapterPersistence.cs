using System;
using System.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Helper.LLBL
{
  public class AdapterPersistence : IPersistence, IDisposable
  {
    private IUnitOfWorkCore _unitOfWork;
    private DataAccessAdapterBase _adapterToUse;
    readonly IAdapterQueryableProvider _queryableProvider;
    private readonly Func<DataAccessAdapterBase> _dataAccessAdapterFactory;

    public AdapterPersistence(Func<DataAccessAdapterBase> dataAccessAdapterFactory, IAdapterQueryableProvider queryableProvider)
    {
      _dataAccessAdapterFactory = dataAccessAdapterFactory;
      _queryableProvider = queryableProvider;
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

    private IUnitOfWorkCore Uow
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
      return _queryableProvider.GetQueryableForEntity<TEntity>(GetAdapterForQuery);
    }

    private DataAccessAdapterBase GetAdapterForQuery()
    {
      return _adapterToUse = _adapterToUse ?? CreateDataAccessAdapter();
    }

    public void Dispose()
    {
      if (_adapterToUse != null) _adapterToUse.Dispose();
    }
  }
}