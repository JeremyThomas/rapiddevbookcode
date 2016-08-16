using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Fasterflect;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Helper.LLBL
{
  public class GeneralEntityCollectionDataScope : DataScope
  {
    protected ITransactionController TransactionController { get; set; }

    #region Events

    /// <summary>
    ///   Raised when an entity has been Removed from the scope. Ignored during fetches. Sender is the entity which was Removed.
    /// </summary>
    public event EventHandler EntityRemoved;

    /// <summary>
    ///   Occurs when editing is finished, either through a commit or undo.
    /// </summary>
    public event EventHandler EditingFinished;

    #endregion

    public GeneralEntityCollectionDataScope()
    {
    }

    public GeneralEntityCollectionDataScope(DataScopeRefetchStrategyType refetchStrategy) : base(refetchStrategy)
    {
    }

    public GeneralEntityCollectionDataScope(IQueryable query)
    {
      Query = TryTrackQuery(query);
      TransactionController = EntityHelper.GetTransactionController(query);
    }

    public GeneralEntityCollectionDataScope(IContextAwareElement contextAwareElement, ITransactionController transactionController = null)
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

    public GeneralEntityCollectionDataScope(IEnumerable enumerable, ITransactionController transactionController)
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
        FetchData();
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
      _context = entityCollectionCore.ActiveContext;
      if (entityCollectionCore.RemovedEntitiesTracker == null && entityCollectionCore.EntityFactoryToUse != null)
      {
        _currentRemovedEntitiesTracker = entityCollectionCore.EntityFactoryToUse.CreateEntityCollection();
        entityCollectionCore.RemovedEntitiesTracker = _currentRemovedEntitiesTracker;
        entityCollectionCore.RemovedEntitiesTracker.EntityAdded += RemovedEntitiesTracker_EntityAdded;
        for (var i = entityCollectionCore.Count - 1; i > -1; i--)
        {
          var entity = entityCollectionCore[i];
          if (entity.MarkedForDeletion //This wont be true as its reset in CollectionCore.PerformAdd
              || _entitiesRemovalTracker.Contains(entity))
            entityCollectionCore.Remove(entity);
        }
      }
      else
      {
        _currentRemovedEntitiesTracker = null;
      }
      var enumerableItemType = MetaDataHelper.GetEnumerableItemType(entityCollectionCore);
      foreach (var entityCore in NewEntities.Where(e => e.GetType().IsAssignableTo(enumerableItemType)).WhereIsDirty())
      {
        entityCollectionCore.Add(entityCore);
      }
      RemoveEmptyNew();
    }

    //private Context Context
    //{
    //  get { return (Context) GetType().GetFieldValue("_context"); }
    //}

    /// <summary>
    ///   The _entities removal tracker, this is used instead doing MarkForDeletion directly to enable undo, since there is no way to clear DataScopeContext._manualAddedEntitiesRemovalTracker
    ///   except, perhaps calling DataScopeContext.PerformPostCommitActions
    ///   also need to remove entities when opening and old page of data
    ///   e.g
    ///   DataScope.BuildWorkForCommit
    ///   DataScope.PerformPostCommitActions
    ///   except that will also remove them from the context
    /// </summary>
    private readonly List<IEntityCore> _entitiesRemovalTracker = new List<IEntityCore>();

    private bool _cascadeDeletes;
    private Context _context;
    private IEntityCollectionCore _currentRemovedEntitiesTracker;
    private static readonly MemberGetter DelegateForGetNewEntities = typeof (Context).DelegateForGetPropertyValue("NewEntities");

    private Dictionary<Guid, IEntityCore>.ValueCollection NewEntities
    {
      get { return ((Dictionary<Guid, IEntityCore>) DelegateForGetNewEntities(_context)).Values; }
    }

    private static readonly MemberGetter DelegateForGetObjectIDToEntityInstance = typeof (Context).DelegateForGetPropertyValue("ObjectIDToEntityInstance");

    private Dictionary<Guid, IEntityCore>.ValueCollection ExistingEntities
    {
      get { return ((Dictionary<Guid, IEntityCore>) DelegateForGetObjectIDToEntityInstance(_context)).Values; }
    }

    /// <summary>
    ///   Handles the EntityAdded event of a removedEntitiesTracker.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="SD.LLBLGen.Pro.ORMSupportClasses.CollectionChangedEventArgs" /> instance containing the event data.</param>
    private void RemovedEntitiesTracker_EntityAdded(object sender, CollectionChangedEventArgs e)
    {
      if (EntityRemoved != null && e.InvolvedEntity != null && !e.InvolvedEntity.IsNew)
      {
        EntityRemoved(sender, e);
        _entitiesRemovalTracker.AddDistinct(e.InvolvedEntity);
      }
    }

    private int CommitAllChanges(bool cascadeDeletes)
    {
      try
      {
        _cascadeDeletes = cascadeDeletes;
        return Convert.ToInt32(TransactionController != null && CommitChanges(TransactionController));
      }
      finally
      {
        _cascadeDeletes = false;
      }
    }

    protected override void OnBeforeCommitChanges()
    {
      foreach (var entity in EntitiesMarkedForDeletion)
      {
        MarkForDeletion(entity);
      }
    }

    private IEnumerable<IEntityCore> EntitiesMarkedForDeletion
    {
      get { return _entitiesRemovalTracker.Where(e => e.MarkedForDeletion); }
    }

    protected override IUnitOfWorkCore BuildWorkForCommit()
    {
      var unitOfWorkCore = base.BuildWorkForCommit();
      return unitOfWorkCore; //AddForSave contains all entites in context
    }

    protected override void OnAfterCommitChanges()
    {
      _entitiesRemovalTracker.Clear();
      if (_currentRemovedEntitiesTracker != null) _currentRemovedEntitiesTracker.Clear();

      if (EditingFinished != null)
      {
        EditingFinished(this, EventArgs.Empty);
      }
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
      if (_cascadeDeletes)
        foreach (var entityRelation in EntityHelper.GetAllRelationsWhereStartEntityIsPkSide(toDelete, true))
        {
          workData.Add(entityRelation);
        }
    }

    public int Save(object dataToSave = null, bool cascadeDeletes = false)
    {
      if (dataToSave == null) return CommitAllChanges(cascadeDeletes);
      var dataAccessAdapter = TransactionController as IDataAccessAdapter;
      var numberSaved = dataAccessAdapter == null ? EntityHelper.Save(dataToSave, cascadeDeletes) : EntityHelper.Save(dataToSave, dataAccessAdapter, cascadeDeletes);
      for (var i = _entitiesRemovalTracker.Count - 1; i > -1; i--)
      {
        var entity = _entitiesRemovalTracker[i];
        if (entity.IsDeleted())
          _entitiesRemovalTracker.Remove(entity);
      }
      CallEditingFinishedIfNotDirty();
      return numberSaved;
    }

    public int Delete(object dataToDelete = null, bool cascade = false)
    {
      if (dataToDelete == null) return CommitAllChanges(cascade);
      var dataAccessAdapter = TransactionController as IDataAccessAdapter;
      return dataAccessAdapter == null ? EntityHelper.Delete(dataToDelete) : EntityHelper.Delete(dataToDelete, dataAccessAdapter, cascade);
    }

    public Dictionary<string, int> GetChildCounts(object entityThatMayHaveChildren)
    {
      var dataAccessAdapter = TransactionController as IDataAccessAdapter;
      return dataAccessAdapter == null ? EntityHelper.GetExistingChildCounts(null, entityThatMayHaveChildren as EntityBase): EntityHelper.GetExistingChildCounts(dataAccessAdapter, entityThatMayHaveChildren as EntityBase2);
    }

    public void Undo(object modifiedData = null)
    {
      if (modifiedData == null)
      {
        UndoContext();
        OnAfterCommitChanges();
      }
      else
      {
        EntityHelper.Undo(modifiedData);
        for (var i = _entitiesRemovalTracker.Count - 1; i > -1; i--)
        {
          var entity = _entitiesRemovalTracker[i];
          if (!entity.MarkedForDeletion)
            _entitiesRemovalTracker.Remove(entity);
        }

        CallEditingFinishedIfNotDirty();
      }
    }

    private void UndoContext()
    {
//From _context.Clear();
      foreach (var toRemove in NewEntities.ToList())
      {
        // _context.OnRemove(toRemove);
        toRemove.ActiveContext = null;
        // _context.OnRemoveComplete(toRemove);
      }
      EntityHelper.RevertChangesToDBValue(ExistingEntities);
    }

    private void RemoveEmptyNew()
    {
      var someRemoved = false;
      foreach (var toRemove in NewEntities.Where(e => !e.IsDirty).ToList())
      {
        toRemove.ActiveContext = null;
        someRemoved = true;
      }
      if (someRemoved)
        CallEditingFinishedIfNotDirty();
    }


    private bool ContextIsDirty()
    {
      return NewEntities.Any(e => !e.MarkedForDeletion && e.IsDirty) || ExistingEntities.IsAnyDirty() || EntitiesMarkedForDeletion.Any();
    }

    private void CallEditingFinishedIfNotDirty()
    {
      if (EditingFinished == null) return;
      if (!ContextIsDirty())
        EditingFinished(this, EventArgs.Empty);
    }
  }
}