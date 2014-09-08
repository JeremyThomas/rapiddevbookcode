using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Northwind.DAL.Services;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.Business
{
  internal class RemoteAdapterClient : IDataAccessAdapter
  {
    private readonly IRemoteDataAccessAdapter _remoteDataAccessAdapter;

    public RemoteAdapterClient(IRemoteDataAccessAdapter remoteDataAccessAdapter)
    {
      _remoteDataAccessAdapter = remoteDataAccessAdapter;
      FunctionMappings = _remoteDataAccessAdapter.FunctionMappings;
    }

    public int CallActionStoredProcedure(string storedProcedureToCall, DbParameter[] parameters)
    {
      throw new NotImplementedException();
    }

    public bool CallRetrievalStoredProcedure(string storedProcedureToCall, DbParameter[] parameters, DataTable tableToFill)
    {
      throw new NotImplementedException();
    }

    public bool CallRetrievalStoredProcedure(string storedProcedureToCall, DbParameter[] parameters, DataSet dataSetToFill)
    {
      throw new NotImplementedException();
    }

    public string ProduceCorrectStoredProcedureName(string storedProcedureToCall)
    {
      throw new NotImplementedException();
    }

    public DbProviderFactory GetDbProviderFactoryInstance()
    {
      throw new NotImplementedException();
    }

    public IDbSpecificCreator GetDbSpecificCreatorInstance()
    {
      throw new NotImplementedException();
    }

    public IDataReader FetchExcludedFieldBatch(IEntityFieldsCore resultFields, IRelationPredicateBucket filter, int batchSize)
    {
      throw new NotImplementedException();
    }

    public void Dispose()
    {
    }

    public void Commit()
    {
      _remoteDataAccessAdapter.Commit();
    }

    public void Rollback()
    {
      throw new NotImplementedException();
    }

    public bool IsTransactionInProgress { get; private set; }
    public event EventHandler TransactionCommitted;
    public event EventHandler TransactionRolledback;

    public IPredicateExpression CreatePrimaryKeyFilter(IList primaryKeyFields)
    {
      throw new NotImplementedException();
    }

    public int ExecuteActionQuery(IActionQuery queryToExecute)
    {
      throw new NotImplementedException();
    }

    public void ExecuteSingleRowRetrievalQuery(IRetrievalQuery queryToExecute, IEntityFields2 fieldsToFill, IFieldPersistenceInfo[] fieldsPersistenceInfo)
    {
      throw new NotImplementedException();
    }

    public void ExecuteMultiRowRetrievalQuery(IRetrievalQuery queryToExecute, IEntityFactory2 entityFactory, IEntityCollection2 collectionToFill, IFieldPersistenceInfo[] fieldsPersistenceInfo, bool allowDuplicates, IEntityFields2 fieldsUsedForQuery)
    {
      throw new NotImplementedException();
    }

    public DataTable ExecuteMultiRowDataTableRetrievalQuery(IRetrievalQuery queryToExecute, DbDataAdapter dataAdapterToUse, IFieldPersistenceInfo[] fieldsPersistenceInfo)
    {
      throw new NotImplementedException();
    }

    public bool ExecuteMultiRowDataTableRetrievalQuery(IRetrievalQuery queryToExecute, DbDataAdapter dataAdapterToUse, DataTable tableToFill, IFieldPersistenceInfo[] fieldsPersistenceInfo)
    {
      throw new NotImplementedException();
    }

    public void StartTransaction(IsolationLevel isolationLevelToUse, string name)
    {
      throw new NotImplementedException();
    }

    public void SaveTransaction(string savePointName)
    {
      throw new NotImplementedException();
    }

    public void Rollback(string savePointName)
    {
      throw new NotImplementedException();
    }

    public void OpenConnection()
    {
      throw new NotImplementedException();
    }

    public void CloseConnection()
    {
      throw new NotImplementedException();
    }

    public bool SaveEntity(IEntity2 entityToSave)
    {
      throw new NotImplementedException();
    }

    public bool SaveEntity(IEntity2 entityToSave, bool refetchAfterSave)
    {
      throw new NotImplementedException();
    }

    public bool SaveEntity(IEntity2 entityToSave, bool refetchAfterSave, IPredicateExpression updateRestriction)
    {
      throw new NotImplementedException();
    }

    public bool SaveEntity(IEntity2 entityToSave, bool refetchAfterSave, IPredicateExpression updateRestriction, bool recurse)
    {
      throw new NotImplementedException();
    }

    public bool SaveEntity(IEntity2 entityToSave, bool refetchAfterSave, bool recurse)
    {
      throw new NotImplementedException();
    }

    public bool FetchEntity(IEntity2 entityToFetch)
    {
      throw new NotImplementedException();
    }

    public bool FetchEntity(IEntity2 entityToFetch, IPrefetchPath2 prefetchPath)
    {
      throw new NotImplementedException();
    }

    public bool FetchEntity(IEntity2 entityToFetch, Context contextToUse)
    {
      throw new NotImplementedException();
    }

    public bool FetchEntity(IEntity2 entityToFetch, IPrefetchPath2 prefetchPath, Context contextToUse)
    {
      throw new NotImplementedException();
    }

    public bool FetchEntity(IEntity2 entityToFetch, IPrefetchPath2 prefetchPath, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
    {
      throw new NotImplementedException();
    }

    public bool FetchEntityUsingUniqueConstraint(IEntity2 entityToFetch, IPredicateExpression uniqueConstraintFilter)
    {
      throw new NotImplementedException();
    }

    public bool FetchEntityUsingUniqueConstraint(IEntity2 entityToFetch, IPredicateExpression uniqueConstraintFilter, IPrefetchPath2 prefetchPath)
    {
      throw new NotImplementedException();
    }

    public bool FetchEntityUsingUniqueConstraint(IEntity2 entityToFetch, IPredicateExpression uniqueConstraintFilter, Context contextToUse)
    {
      throw new NotImplementedException();
    }

    public bool FetchEntityUsingUniqueConstraint(IEntity2 entityToFetch, IPredicateExpression uniqueConstraintFilter, IPrefetchPath2 prefetchPath, Context contextToUse)
    {
      throw new NotImplementedException();
    }

    public bool FetchEntityUsingUniqueConstraint(IEntity2 entityToFetch, IPredicateExpression uniqueConstraintFilter, IPrefetchPath2 prefetchPath, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
    {
      throw new NotImplementedException();
    }

    public IEntity2 FetchNewEntity(IEntityFactory2 entityFactoryToUse, IRelationPredicateBucket filterBucket)
    {
      throw new NotImplementedException();
    }

    public IEntity2 FetchNewEntity(IEntityFactory2 entityFactoryToUse, IRelationPredicateBucket filterBucket, IPrefetchPath2 prefetchPath)
    {
      throw new NotImplementedException();
    }

    public IEntity2 FetchNewEntity(IEntityFactory2 entityFactoryToUse, IRelationPredicateBucket filterBucket, Context contextToUse)
    {
      throw new NotImplementedException();
    }

    public IEntity2 FetchNewEntity(IEntityFactory2 entityFactoryToUse, IRelationPredicateBucket filterBucket, IPrefetchPath2 prefetchPath, Context contextToUse)
    {
      throw new NotImplementedException();
    }

    public IEntity2 FetchNewEntity(IEntityFactory2 entityFactoryToUse, IRelationPredicateBucket filterBucket, IPrefetchPath2 prefetchPath, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
    {
      throw new NotImplementedException();
    }

    public TEntity FetchNewEntity<TEntity>(IRelationPredicateBucket filterBucket) where TEntity : EntityBase2, IEntity2, new()
    {
      throw new NotImplementedException();
    }

    public TEntity FetchNewEntity<TEntity>(IRelationPredicateBucket filterBucket, Context contextToUse) where TEntity : EntityBase2, IEntity2, new()
    {
      throw new NotImplementedException();
    }

    public TEntity FetchNewEntity<TEntity>(IRelationPredicateBucket filterBucket, IPrefetchPath2 prefetchPath) where TEntity : EntityBase2, IEntity2, new()
    {
      throw new NotImplementedException();
    }

    public TEntity FetchNewEntity<TEntity>(IRelationPredicateBucket filterBucket, IPrefetchPath2 prefetchPath, Context contextToUse) where TEntity : EntityBase2, IEntity2, new()
    {
      throw new NotImplementedException();
    }

    public TEntity FetchNewEntity<TEntity>(IRelationPredicateBucket filterBucket, IPrefetchPath2 prefetchPath, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields) where TEntity : EntityBase2, IEntity2, new()
    {
      throw new NotImplementedException();
    }

    public bool DeleteEntity(IEntity2 entityToDelete)
    {
      throw new NotImplementedException();
    }

    public bool DeleteEntity(IEntity2 entityToDelete, IPredicateExpression deleteRestriction)
    {
      throw new NotImplementedException();
    }

    public void FetchEntityCollection(QueryParameters parameters)
    {
      throw new NotImplementedException();
    }

    public void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket)
    {
      throw new NotImplementedException();
    }

    public void FetchEntityCollection(IEntityCollection2 collectionToFill, ExcludeIncludeFieldsList excludedIncludedFields, IRelationPredicateBucket filterBucket)
    {
      throw new NotImplementedException();
    }

    public void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket, IPrefetchPath2 prefetchPath)
    {
      throw new NotImplementedException();
    }

    public void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn)
    {
      throw new NotImplementedException();
    }

    public void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses)
    {
      throw new NotImplementedException();
    }

    public void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath2 prefetchPath)
    {
      throw new NotImplementedException();
    }

    public void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath2 prefetchPath, ExcludeIncludeFieldsList excludedIncludedFields)
    {
      throw new NotImplementedException();
    }

    public void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
    {
      throw new NotImplementedException();
    }

    public void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath2 prefetchPath, int pageNumber, int pageSize)
    {
      throw new NotImplementedException();
    }

    public void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath2 prefetchPath, ExcludeIncludeFieldsList excludedIncludedFields, int pageNumber, int pageSize)
    {
      throw new NotImplementedException();
    }

    public int SaveEntityCollection(IEntityCollection2 collectionToSave)
    {
      throw new NotImplementedException();
    }

    public int SaveEntityCollection(IEntityCollection2 collectionToSave, bool refetchSavedEntitiesAfterSave, bool recurse)
    {
      throw new NotImplementedException();
    }

    public int DeleteEntityCollection(IEntityCollection2 collectionToDelete)
    {
      throw new NotImplementedException();
    }

    public int DeleteEntitiesDirectly(string entityName, IRelationPredicateBucket filterBucket)
    {
      throw new NotImplementedException();
    }

    public int DeleteEntitiesDirectly(Type typeOfEntity, IRelationPredicateBucket filterBucket)
    {
      throw new NotImplementedException();
    }

    public int UpdateEntitiesDirectly(IEntity2 entityWithNewValues, IRelationPredicateBucket filterBucket)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedList(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedList(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedList(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedList(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedList(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IGroupByCollection groupByClause)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedList(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IGroupByCollection groupByClause, int pageNumber, int pageSize)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedList(DataTable dataTableToFill, QueryParameters parameters)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedList(ITypedListLgp2 typedListToFill)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedList(ITypedListLgp2 typedListToFill, IPredicateExpression additionalFilter)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedList(ITypedListLgp2 typedListToFill, IPredicateExpression additionalFilter, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedList(ITypedListLgp2 typedListToFill, IPredicateExpression additionalFilter, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, int pageNumber, int pageSize)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IGroupByCollection groupByClause)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IGroupByCollection groupByClause, int pageNumber, int pageSize)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(ITypedView2 typedViewToFill, IRetrievalQuery queryToUse)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(DataTable dataTableToFill, QueryParameters parameters)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(ITypedView2 typedViewToFill)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(ITypedView2 typedViewToFill, IRelationPredicateBucket filterBucket, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(ITypedView2 typedViewToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(ITypedView2 typedViewToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IGroupByCollection groupByClause)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(ITypedView2 typedViewToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchTypedView(ITypedView2 typedViewToFill, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public IDataReader FetchDataReader(IRetrievalQuery queryToExecute, CommandBehavior readerBehavior)
    {
      throw new NotImplementedException();
    }

    public IDataReader FetchDataReader(CommandBehavior readerBehavior, QueryParameters parameters)
    {
      throw new NotImplementedException();
    }

    public IDataReader FetchDataReader(IEntityFields2 fields, IRelationPredicateBucket filter, CommandBehavior readerBehavior, int maxNumberOfItemsToReturn, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public IDataReader FetchDataReader(IEntityFields2 fields, IRelationPredicateBucket filter, CommandBehavior readerBehavior, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public IDataReader FetchDataReader(IEntityFields2 fields, IRelationPredicateBucket filter, CommandBehavior readerBehavior, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, int pageNumber, int pageSize)
    {
      throw new NotImplementedException();
    }

    public IDataReader FetchDataReader(IEntityFields2 fields, IRelationPredicateBucket filter, CommandBehavior readerBehavior, int maxNumberOfItemsToReturn, ISortExpression sortClauses, IGroupByCollection groupByClause, bool allowDuplicates, int pageNumber, int pageSize)
    {
      throw new NotImplementedException();
    }

    public void FetchProjection(List<IDataValueProjector> valueProjectors, IGeneralDataProjector projector, IEntityFields2 fields, IRelationPredicateBucket filter, int maxNumberOfItemsToReturn, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchProjection(List<IDataValueProjector> valueProjectors, IGeneralDataProjector projector, IEntityFields2 fields, IRelationPredicateBucket filter, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public void FetchProjection(List<IDataValueProjector> valueProjectors, IGeneralDataProjector projector, IEntityFields2 fields, IRelationPredicateBucket filter, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, int pageNumber, int pageSize)
    {
      throw new NotImplementedException();
    }

    public void FetchProjection(List<IDataValueProjector> valueProjectors, IGeneralDataProjector projector, IEntityFields2 fields, IRelationPredicateBucket filter, int maxNumberOfItemsToReturn, ISortExpression sortClauses, IGroupByCollection groupByClause, bool allowDuplicates, int pageNumber, int pageSize)
    {
      throw new NotImplementedException();
    }

    public void FetchProjection(List<IDataValueProjector> valueProjectors, IGeneralDataProjector projector, IRetrievalQuery queryToExecute)
    {
      throw new NotImplementedException();
    }

    public void FetchProjection(List<IDataValueProjector> valueProjectors, IGeneralDataProjector projector, IDataReader reader)
    {
      throw new NotImplementedException();
    }

    public void FetchProjection(List<IDataValueProjector> valueProjectors, IGeneralDataProjector projector, IDataReader reader, IRetrievalQuery executedQuery)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    ///   Creates a new Retrieval query from the elements passed in, executes that retrievalquery and projects the resultset of
    ///   that query using the
    ///   value projectors and the projector specified. If a transaction is in progress, the command is wired to the
    ///   transaction and executed inside the
    ///   transaction. The projection results will be stored in the projector.
    ///   Additional information: Type 'SD.LLBLGen.Pro.QuerySpec.NullAwareDataValueProjector' cannot be serialized.
    ///   Consider marking it with the DataContractAttribute attribute, and marking all of its members you want serialized with
    ///   the DataMemberAttribute attribute.
    ///   If the type is a collection, consider marking it with the CollectionDataContractAttribute.
    ///   See the Microsoft .NET Framework documentation for other supported types.
    /// </summary>
    /// <param name="valueProjectors">The value projectors.</param>
    /// <param name="projector">The projector to use for projecting a raw row onto a new object provided by the projector.</param>
    /// <param name="parameters">The parameters.</param>
    public void FetchProjection(List<IDataValueProjector> valueProjectors, IGeneralDataProjector projector, QueryParameters parameters)
    {
      _remoteDataAccessAdapter.FetchProjection(valueProjectors, projector, parameters);
    }

    public object GetScalar(IEntityField2 field, AggregateFunction aggregateToApply)
    {
      throw new NotImplementedException();
    }

    public object GetScalar(IEntityField2 field, IExpression expressionToExecute, AggregateFunction aggregateToApply)
    {
      throw new NotImplementedException();
    }

    public object GetScalar(IEntityField2 field, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
    {
      throw new NotImplementedException();
    }

    public object GetScalar(IEntityField2 field, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
    {
      throw new NotImplementedException();
    }

    public object GetScalar(IEntityField2 field, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause, IRelationCollection relations)
    {
      throw new NotImplementedException();
    }

    public object GetScalar(IEntityFields2 fields, IPredicate filter, IGroupByCollection groupByClause)
    {
      throw new NotImplementedException();
    }

    public object GetScalar(IEntityFields2 fields, IPredicate filter, IGroupByCollection groupByClause, IRelationCollection relations)
    {
      throw new NotImplementedException();
    }

    public int GetDbCount(IEntityCollection2 collection, IRelationPredicateBucket filter)
    {
      throw new NotImplementedException();
    }

    public int GetDbCount(IEntityCollection2 collection, IRelationPredicateBucket filter, IGroupByCollection groupByClause)
    {
      throw new NotImplementedException();
    }

    public int GetDbCount(IEntityFields2 fields, IRelationPredicateBucket filter)
    {
      throw new NotImplementedException();
    }

    public int GetDbCount(IEntityFields2 fields, IRelationPredicateBucket filter, IGroupByCollection groupByClause)
    {
      throw new NotImplementedException();
    }

    public int GetDbCount(IEntityFields2 fields, IRelationPredicateBucket filter, IGroupByCollection groupByClause, bool allowDuplicates)
    {
      throw new NotImplementedException();
    }

    public object ExecuteScalarQuery(IRetrievalQuery queryToExecute)
    {
      throw new NotImplementedException();
    }

    public void FetchExcludedFields(IEntity2 entity, ExcludeIncludeFieldsList excludedIncludedFields)
    {
      throw new NotImplementedException();
    }

    public void FetchExcludedFields(IEntityCollection2 entities, ExcludeIncludeFieldsList excludedIncludedFields)
    {
      throw new NotImplementedException();
    }

    public int ParameterisedPrefetchPathThreshold { get; set; }
    public IsolationLevel TransactionIsolationLevel { get; set; }
    public string TransactionName { get; set; }
    public string ConnectionString { get; set; }
    public bool KeepConnectionOpen { get; set; }
    public int CommandTimeOut { get; set; }
    public bool InSystemTransaction { get; private set; }
    public FunctionMappingStore FunctionMappings { get; private set; }
    public RecoveryStrategyBase ActiveRecoveryStrategy { get; set; }
  }
}