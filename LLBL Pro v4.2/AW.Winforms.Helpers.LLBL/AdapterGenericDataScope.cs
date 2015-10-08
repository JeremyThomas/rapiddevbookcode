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

    private readonly Action<EntityCollectionBase2<T>> _postProcessing;
    private EntityCollectionBase2<T> _entityCollection;

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

    public AdapterGenericDataScope(IQueryable<T> query, Action<EntityCollectionBase2<T>> postProcessing = null) : base(query)
    {
      _postProcessing = postProcessing;

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
      _entityCollection = Query.ToEntityCollection2();
      var anyData = EntityCollection.Count > 0;
      if (_postProcessing != null && anyData)
        _postProcessing(EntityCollection);
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
      return typeof (EntityBase2).IsAssignableFrom(typeToSave);
    }
  }
}