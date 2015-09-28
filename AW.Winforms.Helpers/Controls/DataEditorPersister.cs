using System;
using System.Data.Linq;
using AW.Helper;

namespace AW.Winforms.Helpers.Controls
{
  public interface IDataEditorPersister
  {
    int Save(object dataToSave);
    int Delete(object dataToDelete);
    bool CanSave(Type typeToSave);
    bool Undo(object modifiedData);

    bool IsDirty(object modifiedData);
  }

  public interface IDataEditorEventHandlers
  {
    /// <summary>
    ///   Raised when the data of an entity in the scope changed. Ignored during fetches. Sender is the entity which data was changed
    /// </summary>
    event EventHandler ContainedDataChanged;

    /// <summary>
    ///   Raised when an entity has been added to the scope. Ignored during fetches. Sender is the entity which was added.
    /// </summary>
    event EventHandler EntityAdded;
  }

  public class DataEditorPersister : IDataEditorPersister
  {
    private readonly Type[] _saveableTypes;
    private readonly Func<object, int> _saveFunction;
    private readonly Func<object, int> _deleteFunction;
    private readonly Func<object, bool> _undoMethod;

    public DataEditorPersister(Func<object, int> saveFunction, Func<object, int> deleteFunction, Func<object, bool> undoMethod, params Type[] saveableTypes)
    {
      _saveableTypes = saveableTypes;
      _saveFunction = saveFunction;
      _deleteFunction = deleteFunction;
      _undoMethod = undoMethod;
    }

    public int Save(object dataToSave)
    {
      return _saveFunction != null ? _saveFunction(dataToSave) : 0;
    }

    public int Delete(object dataToDelete)
    {
      return _deleteFunction != null ? _deleteFunction(dataToDelete) : 0;
    }

    public bool CanSave(Type typeToSave)
    {
      return _saveFunction != null && (_saveableTypes == null || typeToSave.IsAssignableTo(_saveableTypes));
    }

    public bool Undo(object modifiedData)
    {
      return _undoMethod != null && _undoMethod(modifiedData);
    }

    public bool IsDirty(object modifiedData)
    {
      return false;
    }
  }

  public class DataEditorLinqtoSQLPersister : IDataEditorPersister
  {
    private readonly DataContext _dataContext;

    public DataEditorLinqtoSQLPersister(DataContext dataContext)
    {
      _dataContext = dataContext;
    }

    public int Save(object dataToSave)
    {
      var changeSet = _dataContext.GetChangeSet();
      _dataContext.SubmitChanges();
      return changeSet.Inserts.Count + changeSet.Updates.Count;
    }

    public int Delete(object dataToDelete)
    {
      _dataContext.SubmitChanges();
      return _dataContext.GetChangeSet().Deletes.Count;
    }

    public bool CanSave(Type typeToSave)
    {
      try
      {
        var metaType = _dataContext.Mapping.GetMetaType(typeToSave);
        //_dataContext.GetTable(typeToSave);
        return metaType.Table != null;
      }
      catch (InvalidOperationException)
      {
        return false;
      }
    }

    public bool Undo(object modifiedData)
    {
      _dataContext.DiscardPendingChanges();
      return true;
    }

    public bool IsDirty(object modifiedData)
    {
      var changeSet = _dataContext. GetChangeSet();
      return changeSet.Updates.Count > 0;
    }
  }

  /// <summary>
  ///   http://stackoverflow.com/questions/259219/how-can-i-reject-all-changes-in-a-linq-to-sqls-datacontext
  /// </summary>
  internal static class DataContextExtensions
  {
    /// <summary>
    ///   Discard all pending changes of current DataContext.
    ///   All un-submitted changes, including insert/delete/modify will lost.
    /// </summary>
    /// <param name="context"></param>
    public static void DiscardPendingChanges(this DataContext context)
    {
      context.RefreshPendingChanges(RefreshMode.OverwriteCurrentValues);
      var changeSet = context.GetChangeSet();
      //Undo inserts
      foreach (var objToInsert in changeSet.Inserts)
      {
        context.GetTable(objToInsert.GetType()).DeleteOnSubmit(objToInsert);
      }
      //Undo deletes
      foreach (var objToDelete in changeSet.Deletes)
      {
        context.GetTable(objToDelete.GetType()).InsertOnSubmit(objToDelete);
      }
    }

    /// <summary>
    ///   Refreshes all pending Delete/Update entity objects of current DataContext according to the specified mode.
    ///   Nothing will do on Pending Insert entity objects.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="refreshMode">A value that specifies how optimistic concurrency conflicts are handled.</param>
    public static void RefreshPendingChanges(this DataContext context, RefreshMode refreshMode)
    {
      var changeSet = context.GetChangeSet();
      context.Refresh(refreshMode, changeSet.Deletes);
      context.Refresh(refreshMode, changeSet.Updates);
    }
  }
}