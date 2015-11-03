using System;
using System.Collections;
using System.Linq;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public class GenericDataScopeBase : DataScope
  {
    protected ITransactionController TransactionController { get; set; }

    public GenericDataScopeBase()
    {
    }

    public GenericDataScopeBase(DataScopeRefetchStrategyType refetchStrategy) : base(refetchStrategy)
    {
    }

    public GenericDataScopeBase(IQueryable query)
    {
      Query = TryTrackQuery(query);
      TransactionController = EntityHelper.GetTransactionController(query);
    }

    public GenericDataScopeBase(IContextAwareElement contextAwareElement, ITransactionController transactionController = null)
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

    public GenericDataScopeBase(IEnumerable enumerable, ITransactionController transactionController)
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

  public class DataEditorLLBLDataScopePersister : LLBLWinformHelper.DataEditorLLBLPersister, IDataEditorEventHandlers
  {
    public GenericDataScopeBase GenericDataScope;

    protected DataEditorLLBLDataScopePersister()
    {
    }

    public DataEditorLLBLDataScopePersister(IQueryable query)
    {
      GenericDataScope = new GenericDataScopeBase(query);
    }

    public DataEditorLLBLDataScopePersister(GenericDataScopeBase genericDataScope)
    {
      GenericDataScope = genericDataScope;
    }
    
    public DataEditorLLBLDataScopePersister(IEnumerable enumerable, ITransactionController transactionController) : this(new GenericDataScopeBase(enumerable, transactionController))
    {
    }

    public DataEditorLLBLDataScopePersister(IContextAwareElement contextAwareElement, ITransactionController transactionController = null) : this(new GenericDataScopeBase(contextAwareElement, transactionController))
    {
    }

    /// <summary>
    ///   Raised when the data of an entity in the scope changed. Ignored during fetches. Sender is the entity which data was changed
    /// </summary>
    public event EventHandler ContainedDataChanged
    {
      add { GenericDataScope.ContainedDataChanged += value; }
      remove { GenericDataScope.ContainedDataChanged -= value; }
    }

    /// <summary>
    ///   Raised when an entity has been added to the scope. Ignored during fetches. Sender is the entity which was added.
    /// </summary>
    public event EventHandler EntityAdded
    {
      add { GenericDataScope.EntityAdded += value; }
      remove { GenericDataScope.EntityAdded -= value; }
    }

    public override int Save(object dataToSave)
    {
      return GenericDataScope.Save(dataToSave);
    }

    public override int Delete(object dataToDelete)
    {
      return GenericDataScope.Delete(dataToDelete);
    }

    public override bool Undo(object dataToDelete)
    {
      GenericDataScope.Undo(dataToDelete);
      return true;
    }
  }
}