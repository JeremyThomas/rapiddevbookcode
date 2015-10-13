using System;
using System.Collections;
using System.Collections.Generic;
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
      if (transactionController==null)
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

    private IQueryable TryTrackQuery(dynamic query)
    {
      dynamic tryTrackQuery = TrackQuery(query);
      return tryTrackQuery is IQueryable ? tryTrackQuery : null;
    }

    protected override bool FetchDataImpl(params object[] fetchMethodParameters)
    {
      return false;
    }

    public bool CommitChanges()
    {
      return TransactionController != null && CommitChanges(TransactionController);
    }

    protected int CommitAllChanges()
    {
      return Convert.ToInt32(CommitChanges());
    }

    public int Save(object dataToSave)
    {
      if (dataToSave == null) return CommitAllChanges();
      var dataAccessAdapter = TransactionController as IDataAccessAdapter;
      return dataAccessAdapter == null ? EntityHelper.Save(dataToSave) : EntityHelper.Save(dataToSave, dataAccessAdapter);
    }

    public int Delete(object dataToDelete)
    {
      if (dataToDelete == null) return CommitAllChanges();
      var dataAccessAdapter = TransactionController as IDataAccessAdapter;
      return dataAccessAdapter == null ? EntityHelper.Delete(dataToDelete) : EntityHelper.Delete(dataToDelete, dataAccessAdapter);
    }
  }

  public class AdapterGenericDataScope<T> : GenericDataScopeBase where T : EntityBase2
  {
    private readonly Action<IEnumerable<T>> _postProcessing;
    private EntityCollectionBase2<T> _entityCollection;
    private readonly Func<IEnumerable<T>, IEnumerable<T>> _postProcessingFunction;

    public EntityCollectionBase2<T> EntityCollection
    {
      get { return _entityCollection; }
      set
      {
        if (value != null)
          Attach(value);
        _entityCollection = value;
      }
    }

    public AdapterGenericDataScope(IQueryable<T> query) : base(query)
    {
    }

    public AdapterGenericDataScope(IQueryable<T> query, Action<IEnumerable<T>> postProcessing = null) : this(query)
    {
      _postProcessing = postProcessing;
    }

    public AdapterGenericDataScope(IQueryable<T> query, Func<IEnumerable<T>, IEnumerable<T>> postProcessingFunction) : this(query)
    {
      _postProcessingFunction = postProcessingFunction;
    }

    public AdapterGenericDataScope(IEnumerable<T> enumerable, ITransactionController transactionController)
    {
      EntityCollection = enumerable.ToEntityCollection2();
      TransactionController = transactionController;
    }

    protected override bool FetchDataImpl(params object[] fetchMethodParameters)
    {
      if (Query == null)
        return false;
      if (_postProcessingFunction == null)
        _entityCollection = (EntityCollectionBase2<T>) EntityHelper.ToEntityCollectionCore(Query as ILLBLGenProQuery);
      else
        EntityCollection = _postProcessingFunction((IQueryable<T>) Query).ToEntityCollection2();
      var anyData = EntityCollection.Count > 0;
      if (anyData)
      {
        if (_postProcessing != null)
          _postProcessing(EntityCollection);
      }
      return anyData;
    }
  }

  public class DataEditorLLBLDataScopePersister : LLBLWinformHelper.DataEditorLLBLPersister, IDataEditorEventHandlers
  {
    protected GenericDataScopeBase GenericDataScope;

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
  }

}