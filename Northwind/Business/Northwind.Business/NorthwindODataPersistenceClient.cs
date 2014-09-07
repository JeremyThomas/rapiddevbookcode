using System;
using System.Data.Services.Client;
using System.Data.Services.Common;
using System.Linq;
using AW.Helper.LLBL;
using Northwind.DAL.Interfaces;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.Business
{
  public class NorthwindODataPersistenceClient : IPersistence
  {
    private readonly DataServiceContext _dataServiceContext;

    public NorthwindODataPersistenceClient(string dataServiceUrl)
    {
      _dataServiceContext = new DataServiceContext(new Uri(dataServiceUrl),DataServiceProtocolVersion.V3);
    }

    public void Save(IEntity2 entity, bool commit = true)
    {
      var entitySetName = EntityHelper.GetNameFromEntity(entity);
      if (entity.IsNew)
        _dataServiceContext.AddObject(entitySetName, entity);
        if (entity == null) throw new ApplicationException("Entity doesn't exist in the repository");
      try
      {
        _dataServiceContext.UpdateObject(entity);
      }
      catch (ArgumentException e) // this usually means Context didn't track this entity, so we need to detach the old one and attach this one
      {
        try
        {
          _dataServiceContext.Detach(entity);
          _dataServiceContext.AttachTo(entitySetName, entity);
          _dataServiceContext.UpdateObject(entity);
        }
        catch (Exception exx)
        {
          //Roll back
          _dataServiceContext.Detach(entity);
          _dataServiceContext.AttachTo(entitySetName, entity);
          throw;
        }
      }
      try
      {
        if (commit) _dataServiceContext.SaveChanges();
      }
      catch (DataServiceRequestException ex)
      {
        var response = ex.Response.FirstOrDefault();
        if (response != null && (response.StatusCode == 412 || response.StatusCode == 409)) //Concurrency Exception - PreCondition Failed (412) or Conflict occured (409)
        {
          var oldOp = _dataServiceContext.MergeOption;
          _dataServiceContext.MergeOption = MergeOption.PreserveChanges;
          //  entity = t;
          _dataServiceContext.SaveChanges();
          _dataServiceContext.MergeOption = oldOp;
        }
      }
      catch (Exception ex)
      {
        //Need to restore back the original data in the client side if _dataServiceContext._dataServiceContext.SaveChanges() fails; otherwise, next time, these bad data is still here
        var oldOp = _dataServiceContext.MergeOption;
        _dataServiceContext.MergeOption = MergeOption.OverwriteChanges;
        //     entity = t;
        _dataServiceContext.MergeOption = oldOp;
        throw;
      }
    }
    
    public void Delete(IEntity2 entity, bool commit = true)
    {
      _dataServiceContext.DeleteObject(entity);
      if (commit)
        Commit();
    }

    public void Commit()
    {
      _dataServiceContext.SaveChanges();
    }

    public IQueryable<TEntity> GetQueryableForEntity<TEntity>() where TEntity : class
    {
      return _dataServiceContext.CreateQuery<TEntity>(EntityHelper.GetNameFromEntityName(typeof (TEntity).Name));
    }
  }
}