using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web.DynamicData;
using AW.Data.FactoryClasses;
using AW.Data.Linq;
using SD.LLBLGen.Pro.DynamicDataSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data
{
  public static class MetaSingletons
  {
    private static LinqMetaData metaData;

    public static LinqMetaData MetaData
    {
      get
      {
        if (metaData == null)
          metaData = new LinqMetaData();
        return metaData;
      }
    }

    /// <summary>
    /// Gets the DynamicData model. Its used to get the validation attributes of entity fields without using reflection
    /// </summary>
    /// <value>The model.</value>
    public static MetaModel Model
    {
      get
      {
        if (MetaModel.Default == null)
        {
          var model = new MetaModel();
          // Define the model provider. You've to specify the type of the DataAccessAdapter to use and the type of the generated EntityType enum below.
          // register the modelprovider with the model so DynamicData knows how the model looks like 
          model.RegisterContext(new LLBLGenProDataModelProvider(typeof (EntityType), MetaData, new ElementCreator()));
        }
        return MetaModel.Default;
      }
    }
  }

  public static class GlobalHelper
  {
    #region Debuging
    
    /// <summary>
    /// Sends a msg to the Win32 debug output and prefixs it with the name off the method that called TraceOut
    /// </summary>
    /// <param name="msg">The message.</param>
    public static void TraceOut(string msg)
    {
      Trace.WriteLine(new StackTrace(false).GetFrame(1).GetMethod().Name + ": " + msg);
    }

    public static void DebugOut(string msg)
    {
      Debug.WriteLine(new StackTrace(false).GetFrame(1).GetMethod().Name + ": " + msg);
    }

    #endregion
  }

  public static class Validation
  {
    public static bool ValidatePropertyAssignment<T>(T Value, EntityBase Entity, int FieldToValidate)
    {
      if (Entity.Validator != null)
        return Value.Equals(Entity.GetCurrentFieldValue(FieldToValidate)) || Entity.Validator.ValidateFieldValue(Entity, FieldToValidate, Value);
      return true;
    }

    /// <summary>
    /// Validates a field according to the validation attributes defined in the entity metadata class
    /// </summary>
    /// <param name="involvedEntity">The involved entity.</param>
    /// <param name="fieldIndex">Index of the field which value is changed</param>
    /// <param name="value">new value of the field. This value should be validated</param>
    /// <returns>
    /// true, if value is a valid value for the field with index fieldIndex, false otherwise.
    /// </returns>
    /// <remarks>Originally SalesOrderHeaderValidator.Validate</remarks>
    public static bool ValidateFieldValue(IEntityCore involvedEntity, int fieldIndex, object value)
    {
      var fieldName = ((EntityField) involvedEntity.Fields[fieldIndex]).SourceColumnName;
      //var fieldName = FieldInfoProviderSingleton.GetInstance().GetFieldInfo(involvedEntity.LLBLGenProEntityName, fieldIndex).Name;
      var validationAttributes = MetaSingletons.Model.GetTable(involvedEntity.GetType()).GetColumn(fieldName).Attributes.OfType<ValidationAttribute>();
      involvedEntity.SetEntityFieldError(fieldName, String.Empty, false);
      foreach (var validationAttribute in validationAttributes)
        if (!validationAttribute.IsValid(value))
          involvedEntity.SetEntityFieldError(fieldName, validationAttribute.ErrorMessage, true);
      return String.IsNullOrEmpty(((IDataErrorInfo) involvedEntity)[fieldName]);
    }
  }
}