using System.Linq;
using System.ServiceModel;
using Northwind.DAL.Interfaces;
using ProLinq.Wcf;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.Business
{
  public class ProLinqPersistence : IPersistence
  {
    private UnitOfWork2 _unitOfWork;
    private readonly ILLBLPersistance _persistence;

    public ProLinqPersistence(string dataServiceUrl)
    {
      var channelFactory = new QueryableChannelFactory<ILLBLPersistance>(new BasicHttpBinding(), new EndpointAddress(dataServiceUrl));
      _persistence = channelFactory.CreateChannel();
    }

    public void Save(IEntity2 entity, bool commit = true)
    {
      if (commit)
      {
        var unitOfWork = new UnitOfWork2();
        unitOfWork.AddForSave(entity);
        _persistence.Commit(unitOfWork);
      }
      else
      {
        Uow.AddForSave(entity);
      }
    }

    private UnitOfWork2 Uow
    {
      get { return _unitOfWork ?? (_unitOfWork = new UnitOfWork2()); }
    }

    public void Delete(IEntity2 entity, bool commit = true)
    {
      if (commit)
      {
        var unitOfWork = new UnitOfWork2();
        unitOfWork.AddForDelete(entity);
        _persistence.Commit(unitOfWork);
      }
      else
      {
        Uow.AddForDelete(entity);
      }
    }

    public void Commit()
    {
      if (_unitOfWork != null)
        _persistence.Commit(_unitOfWork);
    }

    public IQueryable<TEntity> GetQueryableForEntity<TEntity>() where TEntity : class
    {
     var p = _persistence.Product;
      return (IQueryable<TEntity>) p;
      //   var queryableForEntity = _persistence.GetQueryableForEntity(typeof(TEntity));
//return (IQueryable<TEntity>) queryableForEntity;
    }
  }
}