using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.DynamicData;
using System.Windows.Forms;
using AW.Data.FactoryClasses;
using AW.Data.HelperClasses;
using AW.Data.Linq;
using SD.LLBLGen.Pro.DynamicDataSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.WinForms
{
  public static class Validation
  {
    public static bool ValidatePropertyAssignment<T>(
      Control ControltoValidate,
      int FieldToValidate,
      T Value, string ErrorMessage,
      ErrorProvider myError,
      EntityBase Entity)
    {
      var Validated = true;
      try
      {
        var Validator = Entity.Validator;
        if (Value.Equals(Entity.GetCurrentFieldValue(FieldToValidate)) == false
            && Validator.ValidateFieldValue(Entity, FieldToValidate, Value) == false
          )
        {
          myError.SetError(ControltoValidate, ErrorMessage);
          Validated = false;
        }
        else
        {
          myError.SetError(ControltoValidate, "");
        }
      }
      catch (Exception err)
      {
        myError.SetError(ControltoValidate, err.Message);
        Validated = false;
      }
      return Validated;
    }

    public static bool ValidateForm(Control mycontrol, ErrorProvider MyError)
    {
      var IsValid = true;
      foreach (Control ChildControl in mycontrol.Controls)
      {
        if (MyError.GetError(ChildControl) != "")
        {
          IsValid = false;
          break;
        }
        if (ChildControl.Controls.Count > 0)
        {
          IsValid = ValidateForm(ChildControl, MyError);
          if (IsValid == false)
            break;
        }
      }
      return IsValid;
    }

    private static MetaModel model;

    /// <summary>
    /// Gets the DynamicData model. Its used to get the validation attributes of entity fields without using reflection
    /// </summary>
    /// <value>The model.</value>
    public static MetaModel Model
    {
      get
      {
        if (model == null)
        {
          model = new MetaModel();
          // Define the model provider. You've to specify the type of the DataAccessAdapter to use and the type of the generated EntityType enum below.
          // register the modelprovider with the model so DynamicData knows how the model looks like 
          model.RegisterContext(new LLBLGenProDataModelProvider(typeof (EntityType), new LinqMetaData(), new ElementCreator()), new ContextConfiguration());
        }
        return model;
      }
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
      var validationAttributes = Model.GetTable(involvedEntity.GetType()).GetColumn(FieldInfoProviderSingleton.GetInstance().
        GetFieldInfo(involvedEntity.LLBLGenProEntityName, fieldIndex).Name).Attributes.OfType<ValidationAttribute>();
      foreach (var validationAttribute in validationAttributes)
        if (!validationAttribute.IsValid(value))
          return false;
      return true;
    }
  }
}