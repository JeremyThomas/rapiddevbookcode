using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Data.EntityClasses;

namespace AW.Data.EntityValidators
{
    public class SalesOrderHeaderEntityValidator : IEntityValidator
    {
        public string ErrorMessage = "";
        private bool Validated = true;
        public bool Validate(object containingEntity)
        {
            ErrorMessage = "";
            SalesOrderHeaderEntity order =
                (SalesOrderHeaderEntity)containingEntity;
            if (order.ShipDate != DateTime.MinValue &&
                order.ShipDate < order.OrderDate)
            {
                ErrorMessage +=
                    "Ship Date must be equal to/greater " +
                    "than the Order Date. ";
                Validated = false;
            }
            if (order.DueDate < order.OrderDate)
            {
                ErrorMessage +=
                    "Due Date must be null or greater than " +
                    "the Order Date. ";
                Validated = false;
            }
            return Validated;
        }
    }
}