using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using AW.Data.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
  [DisplayName("An Order")]
  [MetadataType(typeof (SalesOrderHeaderMetadata))]
  public partial class SalesOrderHeaderEntity
  {
    public const string PurchaseOrderError = "Purchase order number must be 4 - 8 characters.";
    public const string PurchaseOrderRegularExpression = "^.{4,8}$";

    [Category("Sales")]
    [Description("You can use this page to find out what is happening with an order")]
    private interface SalesOrderHeaderMetadata
    {
      [RegularExpression(PurchaseOrderRegularExpression, ErrorMessage = PurchaseOrderError)]
      object PurchaseOrderNumber { get; set; }
    }
  }
}

namespace AW.Data.EntityValidators
{
  public class SalesOrderHeaderEntityValidator: ValidatorBase
  {
    public string ErrorMessage = "";

    public override void ValidateEntityBeforeSave(IEntityCore involvedEntity)
    {
      // variable to collect errors
      var sbExceptionMessage = new StringBuilder();

      // order to validate. Cast depends upon the entity you are validating.
      var order = (SalesOrderHeaderEntity)involvedEntity;
      if (order.ShipDate != DateTime.MinValue &&
          order.ShipDate < order.OrderDate)
        // add the error info to the message
        sbExceptionMessage.Append("Ship Date must be equal to/greater " +
                                  "than the Order Date. ");
      if (order.DueDate < order.OrderDate)
        sbExceptionMessage.Append(
          "Due Date must be null or greater than " +
          "the Order Date. ");

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
      return Validation.ValidateFieldValue(involvedEntity, fieldIndex, value);
    }
  }
}