using System;
using System.Collections;
using System.Collections.Generic;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Helper.LLBL
{
  public abstract class DataEditorLLBLPersister : IDataEditorPersisterWithCounts
  {
    /// <summary>
    ///   Saves (persist CUD changes) the specified data.
    /// </summary>
    /// <param name="dataToSave">The data to save.The data must a type that would pass 'CanSave' or an enumeration of that type</param>
    /// <param name="cascadeDeletes">Deletes cascade non-recursively to children of the selected entity</param>
    /// <returns></returns>
    public abstract int Save(object dataToSave = null, bool cascadeDeletes = false);

    /// <summary>
    ///   Deletes the specified data, may not be needed if 'Save' can handle deletes.
    /// </summary>
    /// <param name="dataToDelete">
    ///   The data to delete.The data must a type that would pass 'CanSave' or an enumeration of that
    ///   type
    /// </param>
    /// <param name="cascade">if set to <c>true</c>Deletes cascade non-recursively to children of the selected entity.</param>
    /// <returns></returns>
    public abstract int Delete(object dataToDelete, bool cascade = false);

    public virtual bool CanSave(Type typeToSave)
    {
      return typeof(IEntityCore).IsAssignableFrom(typeToSave);
    }

    public virtual bool Undo(object modifiedData)
    {
      EntityHelper.Undo(modifiedData);
      return true;
    }

    public bool IsDirty(object data)
    {
      return EntityHelper.IsDirty(data);
    }

    public bool TracksRemoves(IEnumerable enumerable)
    {
      var entityCollection = enumerable as IEntityCollection;
      if (entityCollection == null)
      {
        var entityCollection2 = enumerable as IEntityCollection2;
        return entityCollection2 != null && entityCollection2.RemovedEntitiesTracker != null;
      }
      return entityCollection.RemovedEntitiesTracker != null;
    }

    public abstract IDictionary<string, int> GetChildCounts(object entityThatMayHaveChildren);
  }

  public class DataEditorLLBLSelfServicingPersister : DataEditorLLBLPersister
  {
    /// <summary>
    ///   Saves (persist CUD changes) the specified data.
    /// </summary>
    /// <param name="dataToSave">The data to save.The data must a type that would pass 'CanSave' or an enumeration of that type</param>
    /// <param name="cascadeDeletes">Deletes cascade non-recursively to children of the selected entity</param>
    /// <returns></returns>
    public override int Save(object dataToSave = null, bool cascadeDeletes = false)
    {
      return EntityHelper.Save(dataToSave);
    }

    /// <summary>
    ///   Deletes the specified data, may not be needed if 'Save' can handle deletes.
    /// </summary>
    /// <param name="dataToDelete">
    ///   The data to delete.The data must a type that would pass 'CanSave' or an enumeration of that
    ///   type
    /// </param>
    /// <param name="cascade">if set to <c>true</c>Deletes cascade non-recursively to children of the selected entity.</param>
    /// <returns></returns>
    public override int Delete(object dataToDelete, bool cascade = false)
    {
      return EntityHelper.Delete(dataToDelete, cascade);
    }

    public override bool CanSave(Type typeToSave)
    {
      return typeof(EntityBase).IsAssignableFrom(typeToSave);
    }

    public override IDictionary<string, int> GetChildCounts(object entityThatMayHaveChildren)
    {
      return EntityHelper.GetExistingChildCounts(null, entityThatMayHaveChildren as EntityBase2);
    }
  }

  public class DataEditorLLBLAdapterPersister : DataEditorLLBLPersister
  {
    private readonly IDataAccessAdapter _dataAccessAdapter;

    public DataEditorLLBLAdapterPersister(IDataAccessAdapter dataAccessAdapter)
    {
      _dataAccessAdapter = dataAccessAdapter;
    }

    /// <summary>
    ///   Saves (persist CUD changes) the specified data.
    /// </summary>
    /// <param name="dataToSave">The data to save.The data must a type that would pass 'CanSave' or an enumeration of that type</param>
    /// <param name="cascadeDeletes">Deletes cascade non-recursively to children of the selected entity</param>
    /// <returns></returns>
    public override int Save(object dataToSave = null, bool cascadeDeletes = false)
    {
      return EntityHelper.Save(dataToSave, _dataAccessAdapter, cascadeDeletes);
    }

    /// <summary>
    ///   Deletes the specified data, may not be needed if 'Save' can handle deletes.
    /// </summary>
    /// <param name="dataToDelete">The data to delete.The data must a type that would pass 'CanSave' or an enumeration of that type</param>
    /// <param name="cascade">if set to <c>true</c>Deletes cascade non-recursively to children of the selected entity.</param>
    /// <returns></returns>
    public override int Delete(object dataToDelete, bool cascade = false)
    {
      return EntityHelper.Delete(dataToDelete, _dataAccessAdapter, cascade);
    }

    public override bool CanSave(Type typeToSave)
    {
      return typeof(EntityBase2).IsAssignableFrom(typeToSave);
    }

    public override IDictionary<string, int> GetChildCounts(object entityThatMayHaveChildren)
    {
      return EntityHelper.GetExistingChildCounts(_dataAccessAdapter, entityThatMayHaveChildren as EntityBase2);
    }
  }

}