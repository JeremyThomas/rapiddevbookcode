using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using AW.Data.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
  [MetadataType(typeof (SalesOrderHeaderMetadata))]
  public partial class SalesOrderHeaderEntity
  {
  }
}

[Category("Sales")]
[Description("You can use this page to find out what is happening with your orders")]
[DisplayName("My Orders")]
public class SalesOrderHeaderMetadata
{
  [RegularExpression(@"^.{4,8}$", ErrorMessage = "Purchase order number must be 4 - 8 characters.")]
  public object PurchaseOrderNumber { get; set; }
}

namespace AW.Data.EntityValidators
{
  public class SalesOrderHeaderEntityValidator : ValidatorBase
  {
    public string ErrorMessage = "";

    public override void ValidateEntityBeforeSave(IEntityCore involvedEntity)
    {
      // variable to collect errors
      var sbExceptionMessage = new StringBuilder();

      // order to validate. Cast depends upon the entity you are validating.
      var order = (SalesOrderHeaderEntity) involvedEntity;
      if (order.ShipDate != DateTime.MinValue &&
          order.ShipDate < order.OrderDate)
      {
        // add the error info to the message
        sbExceptionMessage.Append("Ship Date must be equal to/greater " +
                                  "than the Order Date. ");
      }
      if (order.DueDate < order.OrderDate)
      {
        sbExceptionMessage.Append(
          "Due Date must be null or greater than " +
          "the Order Date. ");
      }

      // get the errors collected
      var strExceptionMessage = sbExceptionMessage.ToString();

      // Do exist any break rule in this entity?
      if (strExceptionMessage != string.Empty)
      {
        // set error info so we can access that outside
        order.SetEntityError(strExceptionMessage);

        // throws an exception with all the breaking rules info
        throw new ORMEntityValidationException(strExceptionMessage, order);
      }
    }

    public static string PurchaseOrderError = "Purchase order number must be 4 - 8 characters.";

    /// <summary>
    /// Validation method which is called when a field value changes. When a value fails the test, this method will return false
    /// and the field will keep its current value. When true is returned, the field will receive value as its new value.
    /// </summary>
    /// <param name="involvedEntity">The involved entity.</param>
    /// <param name="fieldIndex">Index of the field which value is changed</param>
    /// <param name="value">new value of the field. This value should be validated</param>
    /// <returns>
    /// true, if value is a valid value for the field with index fieldIndex, false otherwise.
    /// </returns>
    /// <remarks>Originally SalesOrderHeaderValidator.Validate</remarks>
    public override bool ValidateFieldValue(IEntityCore involvedEntity, int fieldIndex, object value)
    {
      var Validated = true;
      var PurchaseOrderValidator = "^.{4,8}$";
      switch ((SalesOrderHeaderFieldIndex) fieldIndex)
      {
        case SalesOrderHeaderFieldIndex.PurchaseOrderNumber:
                      // Get list of properties from validationModel
          //var props = typeof(SalesOrderHeaderMetadata).GetProperties();

          //  // Perform validation on each property
          //  foreach (var prop in props)
          //    ValidateProperty(involvedEntity, prop);
          var RegExVal =new Regex(PurchaseOrderValidator);
          if (RegExVal.IsMatch((string) value) == false)
            Validated = false;
          break;
        default:
          break;
      }
      return Validated;
    }

    protected virtual void ValidateProperty(IEntityCore involvedEntity, PropertyInfo property)
    {
      // Get list of validator attributes
      var validators = property.GetCustomAttributes(typeof(ValidationAttribute), true);
      foreach (ValidationAttribute validator in validators)
        ValidateValidator(involvedEntity, property, validator);
    }

    protected virtual void ValidateValidator<TEntity>(TEntity entity, PropertyInfo property, ValidationAttribute validator)
    {
      var value = property.GetValue(entity, null);
      if (!validator.IsValid(value))
      {
        
      }
    }
  }
}