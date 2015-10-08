using System;
using System.Linq;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public class SelfServicingGenericDataScope<T> : DataScope where T : EntityBase
  {
    private readonly IQueryable<T> _query;
    private readonly Func<TransactionBase> _getTransaction;

    public SelfServicingGenericDataScope(IQueryable<T> query,Func<TransactionBase> getTransaction=null)
    {
      _query = query;
      _getTransaction = getTransaction;
    }

    protected override bool FetchDataImpl(params object[] fetchMethodParameters)
    {
      var trackQuery = TrackQuery(_query);
      EntityCollection = trackQuery.ToEntityCollection();
      return EntityCollection.Count > 0;
    }

    public EntityCollectionBase<T> EntityCollection { get; set; }

    internal bool CommitChanges()
    {
      return _getTransaction != null && CommitChanges(_getTransaction());
    }
  }

  public class DataEditorLLBLSelfServicingDataScopePersister<T> : LLBLWinformHelper.DataEditorLLBLSelfServicingPersister, IDataEditorEventHandlers where T : EntityBase
  {
    private SelfServicingGenericDataScope<T> SelfServicingGenericDataScope { get; set; }

    public DataEditorLLBLSelfServicingDataScopePersister(SelfServicingGenericDataScope<T> selfServicingGenericDataScope)
    {
      SelfServicingGenericDataScope = selfServicingGenericDataScope;
    }

    #region Events

    /// <summary>
    ///   Raised when the data of an entity in the scope changed. Ignored during fetches. Sender is the entity which data was changed
    /// </summary>
    public event EventHandler ContainedDataChanged
    {
      add { SelfServicingGenericDataScope.ContainedDataChanged += value; }
      remove { SelfServicingGenericDataScope.ContainedDataChanged -= value; }
    }

    /// <summary>
    ///   Raised when an entity has been added to the scope. Ignored during fetches. Sender is the entity which was added.
    /// </summary>
    public event EventHandler EntityAdded
    {
      add { SelfServicingGenericDataScope.EntityAdded += value; }
      remove { SelfServicingGenericDataScope.EntityAdded -= value; }
    }

    #endregion

    private int CommitAllChanges()
    {
      return Convert.ToInt32(SelfServicingGenericDataScope.CommitChanges());
    }

    public override int Save(object dataToSave)
    {
      return dataToSave==null ? CommitAllChanges() : base.Save(dataToSave);
    }

    public override int Delete(object dataToDelete)
    {
      return dataToDelete == null ? CommitAllChanges() : base.Delete(dataToDelete);
    }
  }
}