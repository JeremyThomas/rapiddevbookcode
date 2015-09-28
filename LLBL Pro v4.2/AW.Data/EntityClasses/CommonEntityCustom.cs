using System.ComponentModel;
using System.Text;
using AW.Helper;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
  /// <summary>Common base class which is the base class for all generated entities which aren't a subtype of another entity.</summary>
  public abstract partial class CommonEntityBase
  {
    static CommonEntityBase()
    {
      MetaDataHelper.FoldAllAssociatedMetadataProvidersIntoTheSubjectType(typeof (CommonEntityBase));
      ProfilerHelper.InitializeOrmProfiler();
    }

    public static void Initialize()
    {
    }

    /// <summary>
    ///   Called at the end of the initialization routine. Raises Initialized event.
    /// </summary>
    protected override void OnInitialized()
    {
      //Not needed as setup using DI ConcurrencyPredicateFactoryToUse = GeneralConcurrencyPredicateFactory.ConcurrencyPredicateFactory;
    }

    public string GetEntityFieldsErrors()
    {
     return EntityHelper.GetEntityFieldsErrors(this);
    }

    /// <summary>
    ///   Resets the errors.
    ///   Used to clean the IDataErrorInfo when GUI cancels an Insert/Update operation.
    /// </summary>
    public void ResetErrors()
    {
      EntityHelper.ResetErrors(this);
    }

    /// <summary>
    ///   Called right at the beginning of SetValue(), which is called from an entity field property setter
    /// </summary>
    /// <param name="fieldIndex">Index of the field to set.</param>
    /// <param name="valueToSet">The value to set.</param>
    /// <param name="cancel">if set to true, the setvalue is cancelled and the set action is terminated</param>
    /// <remarks>
    ///   This code fixes the flaw of the IDataErrorInfo + Refresh field value in controls.
    ///   For more explanation on this issue, please visit this forum's post:
    ///   http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=12166
    /// </remarks>
    protected override void OnSetValue(int fieldIndex, object valueToSet, out bool cancel)
    {
      EntityHelper.SetEntityFieldErrorIfNeeded(this, fieldIndex, valueToSet);

      base.OnSetValue(fieldIndex, valueToSet, out cancel);
    }
  }
}