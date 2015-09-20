using System;
using System.Linq;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  internal class AdapterGenericDataScope<T> : DataScope where T : EntityBase2
  {
    private readonly IQueryable<T> _query;
    private readonly IDataAccessAdapter _dataAccessAdapter;
    private readonly Action<EntityCollectionBase2<T>> _postProcessing;

    public EntityCollectionBase2<T> EntityCollection { get; set; }

    public AdapterGenericDataScope(IQueryable<T> query, Action<EntityCollectionBase2<T>> postProcessing = null)
    {
      _query = query;
      _postProcessing = postProcessing;
      _dataAccessAdapter = EntityHelper.GetDataAccessAdapter(query);
    }

    protected override bool FetchDataImpl(params object[] fetchMethodParameters)
    {
      var trackQuery = TrackQuery(_query);
      EntityCollection = trackQuery.ToEntityCollection2();
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
}