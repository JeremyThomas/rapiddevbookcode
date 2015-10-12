using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public class GenericDataScopeBase : DataScope 
  {
    protected ITransactionController TransactionController;

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

    public GenericDataScopeBase(IContextAwareElement contextAwareElement)
    {
      TryTrackQuery(contextAwareElement);
      var linqMetaData = contextAwareElement as ILinqMetaData;
      if (linqMetaData != null)
        TransactionController = EntityHelper.GetTransactionController(linqMetaData);
      else
      {
        var queryProvider = contextAwareElement as IQueryProvider;
        if (queryProvider != null)
          TransactionController = EntityHelper.GetTransactionController(queryProvider);
      }
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
      return CommitChanges(TransactionController);
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
        EntityCollection = _postProcessingFunction((IQueryable<T>)Query).ToEntityCollection2();
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
    private readonly GenericDataScopeBase _adapterGenericDataScope;

    public DataEditorLLBLDataScopePersister(IQueryable query)
    {
      _adapterGenericDataScope = new GenericDataScopeBase(query);
    }

    public DataEditorLLBLDataScopePersister(GenericDataScopeBase adapterGenericDataScope)
    {
      _adapterGenericDataScope = adapterGenericDataScope;
    }

    //public DataEditorLLBLDataScopePersiste(IEnumerable enumerable, IDataAccessAdapter dataAccessAdapter) : this(new GenericDataScopeBase(enumerable, dataAccessAdapter))
    //{
    //}

    /// <summary>
    ///   Raised when the data of an entity in the scope changed. Ignored during fetches. Sender is the entity which data was changed
    /// </summary>
    public event EventHandler ContainedDataChanged
    {
      add { _adapterGenericDataScope.ContainedDataChanged += value; }
      remove { _adapterGenericDataScope.ContainedDataChanged -= value; }
    }

    /// <summary>
    ///   Raised when an entity has been added to the scope. Ignored during fetches. Sender is the entity which was added.
    /// </summary>
    public event EventHandler EntityAdded
    {
      add { _adapterGenericDataScope.EntityAdded += value; }
      remove { _adapterGenericDataScope.EntityAdded -= value; }
    }

    private int CommitAllChanges()
    {
      return Convert.ToInt32(_adapterGenericDataScope.CommitChanges());
    }

    public override int Save(object dataToSave)
    {
      return CommitAllChanges();
    }

    public override int Delete(object dataToDelete)
    {
      return CommitAllChanges();
    }

    public override bool CanSave(Type typeToSave)
    {
      return typeof(IEntityCore).IsAssignableFrom(typeToSave);
    }
  }

  public class DataEditorLLBLAdapterDataScopePersister<T> : DataEditorLLBLDataScopePersister where T : EntityBase2
  {
    private AdapterGenericDataScope<T> AdapterGenericDataScope { get; set; }

    public DataEditorLLBLAdapterDataScopePersister(IQueryable<T> query):base(query)
    {
      AdapterGenericDataScope = new AdapterGenericDataScope<T>(query);
    }

    public DataEditorLLBLAdapterDataScopePersister(AdapterGenericDataScope<T> adapterGenericDataScope) : base(adapterGenericDataScope)
    {
      AdapterGenericDataScope = adapterGenericDataScope;
    }

    public DataEditorLLBLAdapterDataScopePersister(IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter) : this(new AdapterGenericDataScope<T>(enumerable, dataAccessAdapter))
    {
    }

    #region Events

    #endregion

    public override bool CanSave(Type typeToSave)
    {
      return typeof (T).IsAssignableFrom(typeToSave);
    }
  }
}