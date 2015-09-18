using System.Linq;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  internal class SelfServicingGenericDataScope<T> : DataScope where T : EntityBase
  {
    private readonly IQueryable<T> _query;

    public SelfServicingGenericDataScope(IQueryable<T> query)
    {
      _query = query;
    }

    protected override bool FetchDataImpl(params object[] fetchMethodParameters)
    {
      var trackQuery = TrackQuery(_query);
      EntityCollection = trackQuery.ToEntityCollection();
      return EntityCollection.Count > 0;
    }

    public EntityCollectionBase<T> EntityCollection { get; set; }
  }
}