using System.Collections.Generic;
using System.ServiceModel;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.Services
{
  [ServiceContract]
  public interface IRemoteDataAccessAdapter
  {
    [OperationContract]
    void Commit();

    [OperationContract]
    void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket);

    [OperationContract]
    void FetchProjection(List<IDataValueProjector> valueProjectors, IGeneralDataProjector projector, QueryParameters parameters);

    FunctionMappingStore FunctionMappings { [OperationContract] get; }
  }

  [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall)]
  public class RemoteAdapter : IRemoteDataAccessAdapter
  {
    public void Commit()
    {
      Factories.CreateDataAccessAdapter().Commit();
    }

    public void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket)
    {
      Factories.CreateDataAccessAdapter().FetchEntityCollection(collectionToFill, filterBucket);
    }

    public void FetchProjection(List<IDataValueProjector> valueProjectors, IGeneralDataProjector projector, QueryParameters parameters)
    {
      Factories.CreateDataAccessAdapter().FetchProjection(valueProjectors, projector, parameters);
    }

    public FunctionMappingStore FunctionMappings
    {
      get { return Factories.CreateDataAccessAdapter().FunctionMappings; }
    }
  }
}