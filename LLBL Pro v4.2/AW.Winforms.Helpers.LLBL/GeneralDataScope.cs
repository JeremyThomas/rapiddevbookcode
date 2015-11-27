using System;
using System.Collections;
using System.Collections.Generic;
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

    #region Events
    /// <summary>
    /// Raised when an entity has been Removed from the scope. Ignored during fetches. Sender is the entity which was Removed.
    /// </summary>
    public event EventHandler EntityRemoved;
    #endregion

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
      {
        Attach(entityCollection);
        SetRemovedEntitiesTracker(entityCollection);
      }
      TransactionController = transactionController;
    }

    public IQueryable Query { get; set; }

    private IEntityCollectionCore _entityCollection;

    protected IQueryable TryTrackQuery(dynamic query)
    {
      if (query != null)
      {
        dynamic tryTrackQuery = TrackQuery(query);
        return tryTrackQuery is IQueryable ? tryTrackQuery : null;
      }
      return null;
    }

    public IEntityCollectionCore FetchData(IQueryable query)
    {
      Query = TryTrackQuery(query);
      if (Query != null)
      {
        FetchData();
      }
      var entityCollectionCore = _entityCollection;
      _entityCollection = null;
      return entityCollectionCore;
    }

    public CollectionCore<T> FetchData<T>(IQueryable<T> query) where T : class, IEntityCore
    {
      return (CollectionCore<T>) FetchData((IQueryable) query);
    }

    protected override bool FetchDataImpl(params object[] fetchMethodParameters)
    {
      if (Query == null)
        return false;

      _entityCollection = EntityHelper.ToEntityCollectionCore(Query as ILLBLGenProQuery);
      if (_entityCollection == null) 
        return false;
      SetRemovedEntitiesTracker(_entityCollection);
      var anyData = _entityCollection.Count > 0;
      return anyData;
    }

    private void SetRemovedEntitiesTracker(IEntityCollectionCore entityCollectionCore)
    {
      if (entityCollectionCore.RemovedEntitiesTracker == null && entityCollectionCore.EntityFactoryToUse != null)
      {
        entityCollectionCore.RemovedEntitiesTracker = entityCollectionCore.EntityFactoryToUse.CreateEntityCollection();
        entityCollectionCore.RemovedEntitiesTracker.EntityAdded += RemovedEntitiesTracker_EntityAdded;
        foreach (IEntityCore entity in entityCollectionCore)
        {
          if (entity.MarkedForDeletion) //This wont be true as its reset in CollectionCore.PerformAdd
            entityCollectionCore.Remove(entity);
        }
      }
    }

    private List<IEntityCore> _manualAddedEntitiesRemovalTracker = new List<IEntityCore>();

    /// <summary>
    /// Handles the EntityAdded event of a removedEntitiesTracker.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="SD.LLBLGen.Pro.ORMSupportClasses.CollectionChangedEventArgs"/> instance containing the event data.</param>
    private void RemovedEntitiesTracker_EntityAdded(object sender, CollectionChangedEventArgs e)
    {
      if (EntityRemoved != null)
      {
        EntityRemoved(sender, e);
        _manualAddedEntitiesRemovalTracker.Add(e.InvolvedEntity);
      }
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
      _manualAddedEntitiesRemovalTracker.Clear();
    }

    /// <summary>
    ///   Called when toDelete is about to be deleted. Use this method to specify work to be done by the scope to
    ///   avoid FK constraint issues. workData is meant to collect this work. It can either be additional entities to
    ///   delete prior to 'toDelete', or a list of relations which are used to create cascading delete actions executed
    ///   prior to the delete action of toDelete.
    /// </summary>
    /// <param name="toDelete">To delete.</param>
    /// <param name="workData">The work data.</param>
    protected override void OnEntityDelete(IEntityCore toDelete, WorkDataCollector workData)
    {
    }

    protected override IUnitOfWorkCore BuildWorkForCommit()
    {
      var unitOfWorkCore = base.BuildWorkForCommit();
      foreach (var entity in _manualAddedEntitiesRemovalTracker.Where(e => e.MarkedForDeletion))
      {
        //AddDeleteActionsForDependingEntitiesToUoW(entity, unitOfWorkCore);
        unitOfWorkCore.AddForDelete(entity);
      }
      return unitOfWorkCore;
    }

    protected override void OnAfterCommitChanges()
    {
      _manualAddedEntitiesRemovalTracker.Clear();
    }
  }
}