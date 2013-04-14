using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using AW.Helper;
using LINQPad;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	/// <summary>Common base class which is the base class for all generated entities which aren't a subtype of another entity.</summary>
	public abstract partial class CommonEntityBase : ICustomMemberProvider
	{
		static CommonEntityBase()
		{
			MetaDataHelper.FoldAllAssociatedMetadataProvidersIntoTheSubjectType(typeof (CommonEntityBase));
			ProfilerHelper.InitializeOrmProfilerIfEnabled();
		}

		public static void Initialize()
		{
		}

		/// <summary>
		/// Called at the end of the initialization routine. Raises Initialized event.
		/// </summary>
		protected override void OnInitialized()
		{
			//Not needed as setup using DI ConcurrencyPredicateFactoryToUse = GeneralConcurrencyPredicateFactory.ConcurrencyPredicateFactory;
		}

		/// <summary>
		/// Gets the entity fields errors.
		/// </summary>
		/// <returns>A separator-by-semicolon errors in string representation of the 
		/// error (if exist).
		/// This could be useful if you want to obtain the errors list at some GUI.</returns>
		public string GetEntityFieldsErrors()
		{
			// variables to construct the message
			var sbErrors = new StringBuilder();
			var toReturn = string.Empty;

			// iterate over fields and get their errorInfo
			foreach (IEntityField field in Fields)
				// IEntity implements IDataErrorInfo, and it contains a collections of field errors already set. 
				// For more info read the docs (LLBLGen Pro Help -> Using generated code -> Validation per field or per entity -> IDataErrorInfo implementation).
				if (!string.IsNullOrEmpty(((IDataErrorInfo) this)[field.Name]))
					sbErrors.Append(((IDataErrorInfo) this)[field.Name] + ";");

			// determine if there was errors and cut off the extra ';'
			if (sbErrors.ToString() != string.Empty)
			{
				toReturn = sbErrors.ToString();
				toReturn = toReturn.Substring(0, toReturn.Length - 2);
			}

			return toReturn;
		}

		/// <summary>
		/// Resets the errors.
		/// Used to clean the IDataErrorInfo when GUI cancels an Insert/Update operation.
		/// </summary>
		public void ResetErrors()
		{
			// reset the field errors
			foreach (EntityField field in Fields)
				SetEntityFieldError(field.Name, string.Empty, false);

			// reset entity error
			SetEntityError(string.Empty);
		}

		/// <summary>
		/// Called right at the beginning of SetValue(), which is called from an entity field property setter
		/// </summary>
		/// <param name="fieldIndex">Index of the field to set.</param>
		/// <param name="valueToSet">The value to set.</param>
		/// <param name="cancel">if set to true, the setvalue is cancelled and the set action is terminated</param>
		/// <remarks>
		/// This code fixes the flaw of the IDataErrorInfo + Refresh field value in controls.
		/// For more explanation on this issue, please visit this forum's post: http://www.llblgen.com/TinyForum/Messages.aspx?ThreadID=12166 
		/// </remarks>
		protected override void OnSetValue(int fieldIndex, object valueToSet, out bool cancel)
		{
			if (Fields[fieldIndex].CurrentValue != null)
				if (Fields[fieldIndex].CurrentValue.Equals(valueToSet)
						&& !string.IsNullOrEmpty(((IDataErrorInfo) this)[Fields[fieldIndex].Name]))
					SetEntityFieldError(Fields[fieldIndex].Name, string.Empty, false);

			base.OnSetValue(fieldIndex, valueToSet, out cancel);
		}

		#region Implementation of ICustomMemberProvider

		IEnumerable<string> ICustomMemberProvider.GetNames()
		{
			return GetPropertiesToDisplay().Select(p => p.Name);
		}

		IEnumerable<Type> ICustomMemberProvider.GetTypes()
		{
			return GetPropertiesToDisplay().Select(p => p.PropertyType);
		}

		IEnumerable<object> ICustomMemberProvider.GetValues()
		{
			return GetPropertiesToDisplay().Select(p => p.GetValue(this));
		}

		/// <summary>
		/// Gets the properties to display in LINQPad's Dump method. They should be the same as would appear in a DataGridView with AutoGenerateColumns.
		/// </summary>
		/// <returns>The properties to display in LINQPad's Dump</returns>
		private IEnumerable<PropertyDescriptor> GetPropertiesToDisplay()
		{
			return MetaDataHelper.GetPropertiesToDisplay(GetType());
		}

		#endregion
	}
}