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
      return false;
    }
  }
}