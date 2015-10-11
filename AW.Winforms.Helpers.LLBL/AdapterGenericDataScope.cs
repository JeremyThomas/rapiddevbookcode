using System;
using System.Collections.Generic;
using System.Linq;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public class AdapterGenericDataScopeBase<T> : DataScope where T : EntityBase2
  {
    protected IQueryable<T> Query;
    protected IDataAccessAdapter DataAccessAdapter;

    public AdapterGenericDataScopeBase()
    {
    }

    public AdapterGenericDataScopeBase(IQueryable<T> query)
    {
      Query = TrackQuery(query);
      DataAccessAdapter = EntityHelper.GetDataAccessAdapter(query);
    }

    protected override bool FetchDataImpl(params object[] fetchMethodParameters)
    {
      return false;
    }

    public bool CommitChanges()
    {
      return CommitChanges(DataAccessAdapter);
    }
  }

  public class AdapterGenericDataScope<T> : AdapterGenericDataScopeBase<T> where T : EntityBase2
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

    public AdapterGenericDataScope(IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter)
    {
      EntityCollection = enumerable.ToEntityCollection2();
      DataAccessAdapter = dataAccessAdapter;
    }

    protected override bool FetchDataImpl(params object[] fetchMethodParameters)
    {
      if (Query == null)
        return false;
      if (_postProcessingFunction == null)
        _entityCollection = Query.ToEntityCollection2();
      else
        EntityCollection = _postProcessingFunction(Query).ToEntityCollection2();
      var anyData = EntityCollection.Count > 0;
      if (anyData)
      {
        if (_postProcessing != null)
          _postProcessing(EntityCollection); 
      }
      return anyData;
    }
  }

  public class DataEditorLLBLAdapterDataScopePersister<T> : LLBLWinformHelper.DataEditorLLBLPersister, IDataEditorEventHandlers where T : EntityBase2
  {
    private AdapterGenericDataScopeBase<T> AdapterGenericDataScope { get; set; }

    public DataEditorLLBLAdapterDataScopePersister(IQueryable<T> query)
    {
      AdapterGenericDataScope = new AdapterGenericDataScopeBase<T>(query);
    }

    public DataEditorLLBLAdapterDataScopePersister(AdapterGenericDataScopeBase<T> adapterGenericDataScope)
    {
      AdapterGenericDataScope = adapterGenericDataScope;
    }

    public DataEditorLLBLAdapterDataScopePersister(IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter) : this(new AdapterGenericDataScope<T>(enumerable, dataAccessAdapter))
    {
    }

    #region Events

    /// <summary>
    ///   Raised when the data of an entity in the scope changed. Ignored during fetches. Sender is the entity which data was changed
    /// </summary>
    public event EventHandler ContainedDataChanged
    {
      add { AdapterGenericDataScope.ContainedDataChanged += value; }
      remove { AdapterGenericDataScope.ContainedDataChanged -= value; }
    }

    /// <summary>
    ///   Raised when an entity has been added to the scope. Ignored during fetches. Sender is the entity which was added.
    /// </summary>
    public event EventHandler EntityAdded
    {
      add { AdapterGenericDataScope.EntityAdded += value; }
      remove { AdapterGenericDataScope.EntityAdded -= value; }
    }

    #endregion

    private int CommitAllChanges()
    {
      return Convert.ToInt32(AdapterGenericDataScope.CommitChanges());
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
      return typeof (T).IsAssignableFrom(typeToSave);
    }
  }
}