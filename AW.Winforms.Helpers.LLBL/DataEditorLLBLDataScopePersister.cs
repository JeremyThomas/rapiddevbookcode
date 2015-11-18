using System;
using System.Collections;
using System.Linq;
using AW.Winforms.Helpers.Controls;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public class DataEditorLLBLDataScopePersister : LLBLWinformHelper.DataEditorLLBLPersister, IDataEditorEventHandlers
  {
    public GeneralDataScope GeneralDataScope;

    protected DataEditorLLBLDataScopePersister()
    {
    }

    public DataEditorLLBLDataScopePersister(IQueryable query)
    {
      GeneralDataScope = new GeneralDataScope(query);
    }

    public DataEditorLLBLDataScopePersister(GeneralDataScope generalDataScope)
    {
      GeneralDataScope = generalDataScope;
    }
    
    public DataEditorLLBLDataScopePersister(IEnumerable enumerable, ITransactionController transactionController) 
      : this(new GeneralDataScope(enumerable, transactionController))
    {
    }

    public DataEditorLLBLDataScopePersister(IContextAwareElement contextAwareElement, ITransactionController transactionController = null) 
      : this(new GeneralDataScope(contextAwareElement, transactionController))
    {
    }

    /// <summary>
    ///   Raised when the data of an entity in the scope changed. Ignored during fetches. Sender is the entity which data was changed
    /// </summary>
    public event EventHandler ContainedDataChanged
    {
      add { GeneralDataScope.ContainedDataChanged += value; }
      remove { GeneralDataScope.ContainedDataChanged -= value; }
    }

    /// <summary>
    ///   Raised when an entity has been added to the scope. Ignored during fetches. Sender is the entity which was added.
    /// </summary>
    public event EventHandler EntityAdded
    {
      add { GeneralDataScope.EntityAdded += value; }
      remove { GeneralDataScope.EntityAdded -= value; }
    }

    public override int Save(object dataToSave)
    {
      return GeneralDataScope.Save(dataToSave);
    }

    public override int Delete(object dataToDelete)
    {
      return GeneralDataScope.Delete(dataToDelete);
    }

    public override bool Undo(object dataToDelete)
    {
      GeneralDataScope.Undo(dataToDelete);
      return true;
    }
  }
}