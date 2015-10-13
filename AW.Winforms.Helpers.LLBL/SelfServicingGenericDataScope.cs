using System;
using System.Collections.Generic;
using System.Linq;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public class SelfServicingGenericDataScope<T> : GenericDataScopeBase where T : EntityBase
  {
    private readonly Func<IEnumerable<T>, IEnumerable<T>> _postProcessingFunction;

    public SelfServicingGenericDataScope(IQueryable<T> query) : base(query)
    {
    }

    public SelfServicingGenericDataScope(IQueryable<T> query, Func<IEnumerable<T>, IEnumerable<T>> postProcessingFunction) : this(query)
    {
      _postProcessingFunction = postProcessingFunction;
    }

    public SelfServicingGenericDataScope(IEnumerable<T> enumerable, ITransactionController transactionController)
    {
      EntityCollection = enumerable.ToEntityCollection();
      TransactionController = transactionController;
    }

    protected override bool FetchDataImpl(params object[] fetchMethodParameters)
    {
      if (Query == null)
        return false;
      if (_postProcessingFunction == null)
        EntityCollection = (EntityCollectionBase<T>)EntityHelper.ToEntityCollectionCore(Query as ILLBLGenProQuery);
      else
        EntityCollection = _postProcessingFunction((IQueryable<T>)Query).ToEntityCollection();
      var anyData = EntityCollection.Count > 0;
      if (anyData)
      {
        //if (_postProcessing != null)
        //  _postProcessing(EntityCollection);
      }
      return anyData;
    }

    public EntityCollectionBase<T> EntityCollection { get; set; }
  }

}