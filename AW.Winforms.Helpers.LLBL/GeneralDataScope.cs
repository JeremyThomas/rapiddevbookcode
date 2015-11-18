using System;
using System.Collections;
using System.Linq;
using AW.Helper;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public class GeneralDataScope : DataScope
  {
    protected ITransactionController TransactionController { get; set; }

    public GeneralDataScope()
    {
    }

    public GeneralDataScope(DataScopeRefetchStrategyType refetchStrategy) : base(refetchStrategy)
    {
    }

    public GeneralDataScope(IQueryable query)
    {
      Query = TryTrackQuery(query);
      TransactionController = EntityHelper.GetTransactionController(query);
    }

    public GeneralDataScope(IContextAwareElement contextAwareElement, ITransactionController transactionController = null)
    {
      TryTrackQuery(contextAwareElement);
      var linqMetaData = contextAwareElement as ILinqMetaData;
      if (transactionController == null)
        if (linqMetaData != null)
          TransactionController = EntityHelper.GetTransactionController(linqMetaData);
        else
        {
          var queryProvider = contextAwareElement as IQueryProvider;
          if (queryProvider != null)
            TransactionController = EntityHelper.GetTransactionController(queryProvider);
        }
      else
      {
        TransactionController = transactionController;
      }
    }

    public GeneralDataScope(IEnumerable enumerable, ITransactionController transactionController)
    {
      var entityCollection = EntityHelper.ToEntityCollection(enumerable, MetaDataHelper.GetEnumerableItemType(enumerable));
      if (entityCollection != null)
        Attach(entityCollection);
      TransactionController = transactionController;
    }

    public IQueryable Query { get; set; }

    private IEntityCollectionCore _entityCollection;

    protected IQueryable TryTrackQuery(dynamic query)
    {
      dynamic tryTrackQuery = TrackQuery(query);
      return tryTrackQuery is IQueryable ? tryTrackQuery : null;
    }

    public IEntityCollectionCore FetchData(IQueryable query)
    {
      Query = TryTrackQuery(query);
      FetchData();
      return _entityCollection;
    }

    public CollectionCore<T> FetchData<T>(IQueryable<T> query) where T : class, IEntityCore
    {
      return (CollectionCore<T>)FetchData((IQueryable)query);
    }

    protected override bool FetchDataImpl(params object[] fetchMethodParameters)
    {
      if (Query == null)
        return false;

      _entityCollection = EntityHelper.ToEntityCollectionCore(Query as ILLBLGenProQuery);
      var anyData = _entityCollection.Count > 0;
      return anyData;
    }

    public bool CommitChanges()
    {
      return TransactionController != null && CommitChanges(TransactionController);
    }

    protected int CommitAllChanges()
    {
      return Convert.ToInt32(CommitChanges());
    }

    public int Save(object dataToSave = null)
    {
      if (dataToSave == null) return CommitAllChanges();
      var dataAccessAdapter = TransactionController as IDataAccessAdapter;
      return dataAccessAdapter == null ? EntityHelper.Save(dataToSave) : EntityHelper.Save(dataToSave, dataAccessAdapter);
    }

    public int Delete(object dataToDelete = null)
    {
      if (dataToDelete == null) return CommitAllChanges();
      var dataAccessAdapter = TransactionController as IDataAccessAdapter;
      return dataAccessAdapter == null ? EntityHelper.Delete(dataToDelete) : EntityHelper.Delete(dataToDelete, dataAccessAdapter);
    }

    public void Undo(object modifiedData = null)
    {
      if (modifiedData == null)
      {
        var unitOfWorkCore = BuildWorkForCommit();
        EntityHelper.Undo(unitOfWorkCore);
      }
      else
        EntityHelper.Undo(modifiedData);
    }
  }
}