using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using AW.Helper;
using Fasterflect;
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
      var channelFactory = new QueryableChannelFactory<ILLBLPersistance>(WcfUtility.CreateBasicHttpBinding(), new EndpointAddress(dataServiceUrl));
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

    private IEnumerable<PropertyInfo> _queryables;
    private static Dictionary<Type, PropertyInfo> _memberGetters;


    public IQueryable<TEntity> GetQueryableForEntity<TEntity>() where TEntity : class
    {  
      var typeOfEntity = typeof (TEntity);
      if (_memberGetters == null)
        _memberGetters = new Dictionary<Type, PropertyInfo>();
      var nameGetter = _memberGetters.GetValue(typeOfEntity);
      if (nameGetter == null)
      {
        //  var queryable = EntityHelper.GetQueryableForEntityIgnoreIfNull(linqMetaData, typeOfEntity);
        //   var typeParameterOfGenericType = MetaDataHelper.GetTypeParameterOfGenericType(queryable.GetType());
        var lLblPersistanceType = typeof(ILLBLPersistance);
        if (_queryables == null)
        {
          _queryables = lLblPersistanceType.Properties().Where(m => m.IsReadable() && m.Type().Implements<IQueryable>());
        }
        nameGetter = _queryables.FirstOrDefault(q => MetaDataHelper.GetTypeParameterOfGenericType(q.PropertyType) == typeOfEntity);
        if (nameGetter != null)
        {
       //   nameGetter = lLblPersistanceType.DelegateForGetPropertyValue(x.Name);
          _memberGetters.Add(typeOfEntity, nameGetter);
          return (IQueryable<TEntity>)nameGetter.GetValue(_persistence, null); 
        }
        return null;
      }
      return (IQueryable<TEntity>)nameGetter.GetValue(_persistence, null); 

     // if (_queryables == null)
     //   _queryables = GetType().Properties().Where(m => m.IsReadable() && m.Type().Implements<IQueryable>());

     //var p = _persistence.GetProducts();
    
     //var x = _queryables.FirstOrDefault(q => MetaDataHelper.GetTypeParameterOfGenericType(q.PropertyType) == typeOfEntity);
     //if (x != null)
     //{
     //  nameGetter = GetType().DelegateForGetPropertyValue(x.Name);
     //  _memberGetters.Add(typeOfEntity, nameGetter);
     //  return (IQueryable)nameGetter(this);
     //}
     // var supplierEntities = _persistence.Supplier;
     // return (IQueryable<TEntity>) p;
      //   var queryableForEntity = _persistence.GetQueryableForEntity(typeof(TEntity));
//return (IQueryable<TEntity>) queryableForEntity;
    }
  }
}