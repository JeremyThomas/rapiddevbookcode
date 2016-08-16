using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Reflection;

namespace AW.Helper
{
  /// <summary>
  ///   If an implementation of this is supplied to GridDataEditor it will be able to persist CUD changes
  /// </summary>
  public interface IDataEditorPersister
  {
    /// <summary>
    ///   Saves (persist CUD changes) the specified data.
    /// </summary>
    /// <param name="dataToSave">The data to save.The data must a type that would pass 'CanSave' or an enumeration of that type</param>
    /// <param name="cascadeDeletes">Deletes cascade non-recursively to children of the selected entity</param>
    /// <returns></returns>
    int Save(object dataToSave = null, bool cascadeDeletes = false);

    /// <summary>
    ///   Deletes the specified data, may not be needed if 'Save' can handle deletes.
    /// </summary>
    /// <param name="dataToDelete">The data to delete.The data must a type that would pass 'CanSave' or an enumeration of that type</param>
    /// <param name="cascade">if set to <c>true</c>Deletes cascade non-recursively to children of the selected entity.</param>
    /// <returns></returns>
    int Delete(object dataToDelete = null, bool cascade = false);

    /// <summary>
    ///   Determines whether this instance can save the specified type.
    /// </summary>
    /// <param name="typeToSave">The type to save.</param>
    /// <returns></returns>
    bool CanSave(Type typeToSave);

    /// <summary>
    ///   Undoes any changes to the specified data.
    /// </summary>
    /// <param name="modifiedData">The modified data.</param>
    /// <returns></returns>
    bool Undo(object modifiedData = null);

    /// <summary>
    ///   Determines whether the specified data is dirty (Has a CUD)
    /// </summary>
    /// <param name="modifiedData">The modified data.</param>
    /// <returns></returns>
    bool IsDirty(object modifiedData = null);

    /// <summary>
    /// Indicates wether the container trackes removals itself or the edit needs to do it instead
    /// </summary>
    /// <param name="enumerable">The enumerable.</param>
    /// <returns></returns>
    bool TracksRemoves(IEnumerable enumerable);
  }

  public interface IDataEditorPersisterWithCounts : IDataEditorPersister
  {
    IDictionary<string, int> GetChildCounts(object entityThatMayHaveChildren);
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

  public static class DataEditorPersisterFactory
  {
    private static readonly List<Func<object, IDataEditorPersister>> Factories = new List<Func<object, IDataEditorPersister>>();

    static DataEditorPersisterFactory()
    {
      Register(CreateDataEditorLinqtoSQLPersister);
    }

    public static IDataEditorPersister CreateDataEditorLinqtoSQLPersister(object data)
    {
      var context = data as DataContext;
      if (context == null)
      {
        context = GetDataContext(data);
        if (context == null)
          return null;
      }
      return new DataEditorLinqtoSQLPersister(context);
    }

    private static DataContext GetDataContext(object enumerable)
    {
      var contextField = enumerable.GetType().GetField("context", BindingFlags.Instance | BindingFlags.NonPublic);
      if (contextField != null)
        return contextField.GetValue(enumerable) as DataContext;
      return null;
    }

    public static void Register(Func<object, IDataEditorPersister> factory)
    {
      Factories.Add(factory);
    }

    public static IDataEditorPersister Create(object data, IDataEditorPersister persister = null)
    {
      return persister ?? Factories.Select(factory => factory(data)).FirstOrDefault(dataEditorPersister => dataEditorPersister != null);
    }
  }

  public class DataEditorPersister : IDataEditorPersister
  {
    private readonly Type[] _saveableTypes;
    private readonly Func<object, bool, int> _saveFunction;
    private readonly Func<object, bool, int> _deleteFunction;
    private readonly Func<object, bool> _undoMethod;

    public DataEditorPersister(Func<object, bool, int> saveFunction, Func<object, bool, int> deleteFunction, Func<object, bool> undoMethod, params Type[] saveableTypes)
    {
      _saveableTypes = saveableTypes;
      _saveFunction = saveFunction;
      _deleteFunction = deleteFunction;
      _undoMethod = undoMethod;
    }

    public int Save(object dataToSave = null, bool cascadeDeletes = false)
    {
      return _saveFunction != null ? _saveFunction(dataToSave, cascadeDeletes) : 0;
    }

    public int Delete(object dataToDelete, bool cascade = false)
    {
      return _deleteFunction != null ? _deleteFunction(dataToDelete, cascade) : 0;
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

    public bool TracksRemoves(IEnumerable enumerable)
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

    public int Save(object dataToSave = null, bool cascadeDeletes = false)
    {
      var changeSet = _dataContext.GetChangeSet();
      _dataContext.SubmitChanges();
      return changeSet.Inserts.Count + changeSet.Updates.Count;
    }

    public int Delete(object dataToDelete, bool cascade = false)
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
      var changeSet = _dataContext.GetChangeSet();
      return changeSet.Updates.Count > 0;
    }

    public bool TracksRemoves(IEnumerable enumerable)
    {
      return false;
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