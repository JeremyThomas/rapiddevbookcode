using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Helper.LLBL
{
	public static class Validation
	{
		public static bool ValidatePropertyAssignment(EntityBase entity, int fieldToValidate, object value)
		{
			if (entity.Validator != null)
				return value.Equals(entity.GetCurrentFieldValue(fieldToValidate)) || entity.Validator.ValidateFieldValue(entity, fieldToValidate, value);
			return true;
		}

		/// <summary>
		/// Gets the validation attributes of a field in an entity.
		/// </summary>
		/// <param name="involvedEntity">The involved entity.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>The validation attributes.</returns>
		public static IEnumerable<ValidationAttribute> GetValidationAttributes(IEntityCore involvedEntity, string fieldName)
		{
			return MetaDataHelper.GetValidationAttributes(involvedEntity.GetType(), fieldName);
		}

		/// <summary>
		/// Validates a field according to the validation attributes defined in the entity class and the entities metadata class.
		/// </summary>
		/// <param name="involvedEntity">The involved entity.</param>
		/// <param name="fieldIndex">Index of the field which value is changed</param>
		/// <param name="value">new value of the field. This value should be validated</param>
		/// <returns>
		/// true, if value is a valid value for the field with index fieldIndex, false otherwise.
		/// </returns>
		public static bool ValidateFieldValue(IEntityCore involvedEntity, int fieldIndex, object value)
		{
			return ValidateFieldValue(involvedEntity, ((IFieldInfo) involvedEntity.Fields[fieldIndex]).Name, value);
		}

		/// <summary>
		/// Validates a field according to the validation attributes defined in the entity class and the entities metadata class.
		/// </summary>
		/// <param name="involvedEntity">The involved entity.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <param name="value">The value.</param>
		/// <returns>true, if value is a valid value for the field with index fieldIndex, false otherwise.</returns>
		public static bool ValidateFieldValue(IEntityCore involvedEntity, string fieldName, object value)
		{
			return ValidateFieldValue(involvedEntity, fieldName, GetValidationAttributes(involvedEntity, fieldName), value);
		}

		/// <summary>
		/// Validates a field according to the validation attributes defined in the entity class and the entities metadata class.
		/// </summary>
		/// <param name="involvedEntity">The involved entity.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <param name="validationAttributes">The validation attributes.</param>
		/// <param name="value">The value.</param>
		/// <returns>true, if value is a valid value for the field with index fieldIndex, false otherwise.</returns>
		private static bool ValidateFieldValue(IEntityCore involvedEntity, string fieldName, IEnumerable<ValidationAttribute> validationAttributes, object value)
		{
			involvedEntity.SetEntityFieldError(fieldName, String.Empty, false);
			foreach (var validationAttribute in validationAttributes)
				if (!validationAttribute.IsValid(value))
					involvedEntity.SetEntityFieldError(fieldName, validationAttribute.ErrorMessage, true);
			return String.IsNullOrEmpty(((IDataErrorInfo) involvedEntity)[fieldName]);
		}
	}
}