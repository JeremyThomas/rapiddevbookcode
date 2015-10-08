using System;
using System.Collections.Generic;
using System.Linq;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public class AdapterGenericDataScope<T> : DataScope where T : EntityBase2
  {
    private readonly IQueryable<T> _query;
    private readonly IDataAccessAdapter _dataAccessAdapter;
    private readonly Action<EntityCollectionBase2<T>> _postProcessing;
    private EntityCollectionBase2<T> _entityCollection;

    public EntityCollectionBase2<T> EntityCollection
    {
      get { return _entityCollection; }
      set
      {
        if (value!=null)
          Attach(value);
        _entityCollection = value;
      }
    }

    public AdapterGenericDataScope(IQueryable<T> query, Action<EntityCollectionBase2<T>> postProcessing = null)
    {
      _query = query;
      _postProcessing = postProcessing;
      _dataAccessAdapter = EntityHelper.GetDataAccessAdapter(query);
    }

    public AdapterGenericDataScope(IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter)
    {
      EntityCollection = enumerable.ToEntityCollection2();
      _dataAccessAdapter = dataAccessAdapter;
    }

    protected override bool FetchDataImpl(params object[] fetchMethodParameters)
    {
      if (_query == null)
        return false;
      var trackQuery = TrackQuery(_query);
      _entityCollection = trackQuery.ToEntityCollection2();
      var anyData = EntityCollection.Count > 0;
      if (_postProcessing != null && anyData)
        _postProcessing(EntityCollection);
      return anyData;
    }

    public bool CommitChanges()
    {
      return CommitChanges(_dataAccessAdapter);
    }
  }

  public class DataEditorLLBLAdapterDataScopePersister<T> : LLBLWinformHelper.DataEditorLLBLPersister, IDataEditorEventHandlers where T : EntityBase2
  {
    private AdapterGenericDataScope<T> AdapterGenericDataScope { get; set; }

    public DataEditorLLBLAdapterDataScopePersister(AdapterGenericDataScope<T> adapterGenericDataScope)
    {
      AdapterGenericDataScope = adapterGenericDataScope;
    }

    public DataEditorLLBLAdapterDataScopePersister(IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter):this(new AdapterGenericDataScope<T>(enumerable, dataAccessAdapter))
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
      return typeof(EntityBase2).IsAssignableFrom(typeToSave);
    }
  }
}