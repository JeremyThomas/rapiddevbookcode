using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Data.EntityClasses;
using System.Text;

namespace AW.Data.EntityValidators
{
    public class SalesOrderHeaderEntityValidator : ValidatorBase
    {
        public string ErrorMessage = "";
        private bool Validated = true;
        public override void ValidateEntityBeforeSave(IEntityCore involvedEntity)
        {

          // variable to collect errors
          StringBuilder sbExceptionMessage = new StringBuilder();

          // order to validate. Cast depends upon the entity you are validating.
             SalesOrderHeaderEntity order = (SalesOrderHeaderEntity)involvedEntity;
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
            string strExceptionMessage = sbExceptionMessage.ToString();

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
        /// <param name="fieldIndex">Index of the field which value is changed</param>
        /// <param name="value">new value of the field. This value should be validated</param>
        /// <returns>true, if value is a valid value for the field with index fieldIndex, false otherwise.</returns>
        /// <remarks>Originally SalesOrderHeaderValidator.Validate</remarks>
        public override bool ValidateFieldValue(IEntityCore involvedEntity, int fieldIndex, object value)
        {
          bool Validated = true;
          string PurchaseOrderValidator = "^.{4,8}$";
          switch ((SalesOrderHeaderFieldIndex)fieldIndex)
          {
            case SalesOrderHeaderFieldIndex.PurchaseOrderNumber:
              System.Text.RegularExpressions.Regex RegExVal =
                      new System.Text.RegularExpressions.Regex(
                      PurchaseOrderValidator);
              if (RegExVal.IsMatch((string)value) == false)
                Validated = false;
              break;
            default:
              break;
          }
          return Validated;
        }
    }
}