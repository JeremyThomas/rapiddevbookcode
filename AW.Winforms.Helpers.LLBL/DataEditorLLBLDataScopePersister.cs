using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AW.Winforms.Helpers.Controls;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public class DataEditorLLBLDataScopePersister : LLBLWinformHelper.DataEditorLLBLPersister, IDataEditorEventHandlers
  {
    public GeneralEntityCollectionDataScope GeneralEntityCollectionDataScope;

    protected DataEditorLLBLDataScopePersister()
    {
    }

    public DataEditorLLBLDataScopePersister(IQueryable query)
    {
      GeneralEntityCollectionDataScope = new GeneralEntityCollectionDataScope(query);
    }

    public DataEditorLLBLDataScopePersister(GeneralEntityCollectionDataScope generalEntityCollectionDataScope)
    {
      GeneralEntityCollectionDataScope = generalEntityCollectionDataScope;
    }
    
    public DataEditorLLBLDataScopePersister(IEnumerable enumerable, ITransactionController transactionController) 
      : this(new GeneralEntityCollectionDataScope(enumerable, transactionController))
    {
    }

    public DataEditorLLBLDataScopePersister(IContextAwareElement contextAwareElement, ITransactionController transactionController = null) 
      : this(new GeneralEntityCollectionDataScope(contextAwareElement, transactionController))
    {
    }

    /// <summary>
    ///   Raised when the data of an entity in the scope changed. Ignored during fetches. Sender is the entity which data was changed
    /// </summary>
    public event EventHandler ContainedDataChanged
    {
      add { GeneralEntityCollectionDataScope.ContainedDataChanged += value; }
      remove { GeneralEntityCollectionDataScope.ContainedDataChanged -= value; }
    }

    /// <summary>
    ///   Raised when an entity has been added to the scope. Ignored during fetches. Sender is the entity which was added.
    /// </summary>
    public event EventHandler EntityAdded
    {
      add
      {
        GeneralEntityCollectionDataScope.EntityAdded += value;
        GeneralEntityCollectionDataScope.EntityRemoved += value;
      }
      remove
      {
        GeneralEntityCollectionDataScope.EntityAdded -= value;
        GeneralEntityCollectionDataScope.EntityRemoved -= value;
      }
    }

    public override int Save(object dataToSave)
    {
      return GeneralEntityCollectionDataScope.Save(dataToSave);
    }

    public override int Delete(object dataToDelete, bool cascade = false)
    {
      return GeneralEntityCollectionDataScope.Delete(dataToDelete, cascade);
    }

    public override bool Undo(object dataToDelete)
    {
      GeneralEntityCollectionDataScope.Undo(dataToDelete);
      return true;
    }

    public override IDictionary<string, int> GetChildCounts(object entityThatMayHaveChildren)
    {
      return GeneralEntityCollectionDataScope.GetChildCounts(entityThatMayHaveChildren);
    }
  }
}