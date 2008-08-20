///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:29 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;
using System.Data;

using AW.Data;
using AW.Data.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.FactoryClasses
{
	/// <summary>
	/// Factory class for IEntityField instances, used in IEntityFields instances.
	/// </summary>
	public class EntityFieldFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private EntityFieldFactory()
		{
		}

	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the AddressEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(AddressFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case AddressFieldIndex.AddressId:
					fieldToReturn = new EntityField("AddressId", typeof(System.Int32), "AddressEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Person", "Address", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case AddressFieldIndex.AddressLine1:
					fieldToReturn = new EntityField("AddressLine1", typeof(System.String), "AddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Address", "AddressLine1", false, (int)SqlDbType.NVarChar, 60, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case AddressFieldIndex.AddressLine2:
					fieldToReturn = new EntityField("AddressLine2", typeof(System.String), "AddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Address", "AddressLine2", true, (int)SqlDbType.NVarChar, 60, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case AddressFieldIndex.City:
					fieldToReturn = new EntityField("City", typeof(System.String), "AddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Address", "City", false, (int)SqlDbType.NVarChar, 30, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case AddressFieldIndex.StateProvinceId:
					fieldToReturn = new EntityField("StateProvinceId", typeof(System.Int32), "AddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Person", "Address", "StateProvinceID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case AddressFieldIndex.PostalCode:
					fieldToReturn = new EntityField("PostalCode", typeof(System.String), "AddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Address", "PostalCode", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case AddressFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "AddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"Person", "Address", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case AddressFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "AddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Person", "Address", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the AddressTypeEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(AddressTypeFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case AddressTypeFieldIndex.AddressTypeId:
					fieldToReturn = new EntityField("AddressTypeId", typeof(System.Int32), "AddressTypeEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Person", "AddressType", "AddressTypeID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case AddressTypeFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), "AddressTypeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "AddressType", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case AddressTypeFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "AddressTypeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"Person", "AddressType", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case AddressTypeFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "AddressTypeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Person", "AddressType", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ContactEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ContactFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ContactFieldIndex.ContactId:
					fieldToReturn = new EntityField("ContactId", typeof(System.Int32), "ContactEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Person", "Contact", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case ContactFieldIndex.NameStyle:
					fieldToReturn = new EntityField("NameStyle", typeof(System.Boolean), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), @"Person", "Contact", "NameStyle", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", false, null, typeof(System.Boolean), (int)fieldIndex);
					break;
				case ContactFieldIndex.Title:
					fieldToReturn = new EntityField("Title", typeof(System.String), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Contact", "Title", true, (int)SqlDbType.NVarChar, 8, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ContactFieldIndex.FirstName:
					fieldToReturn = new EntityField("FirstName", typeof(System.String), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Contact", "FirstName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ContactFieldIndex.MiddleName:
					fieldToReturn = new EntityField("MiddleName", typeof(System.String), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Contact", "MiddleName", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ContactFieldIndex.LastName:
					fieldToReturn = new EntityField("LastName", typeof(System.String), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Contact", "LastName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ContactFieldIndex.Suffix:
					fieldToReturn = new EntityField("Suffix", typeof(System.String), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Contact", "Suffix", true, (int)SqlDbType.NVarChar, 10, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ContactFieldIndex.EmailAddress:
					fieldToReturn = new EntityField("EmailAddress", typeof(System.String), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Contact", "EmailAddress", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ContactFieldIndex.EmailPromotion:
					fieldToReturn = new EntityField("EmailPromotion", typeof(System.Int32), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Person", "Contact", "EmailPromotion", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case ContactFieldIndex.Phone:
					fieldToReturn = new EntityField("Phone", typeof(System.String), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Contact", "Phone", true, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ContactFieldIndex.PasswordHash:
					fieldToReturn = new EntityField("PasswordHash", typeof(System.String), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Contact", "PasswordHash", false, (int)SqlDbType.VarChar, 40, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ContactFieldIndex.PasswordSalt:
					fieldToReturn = new EntityField("PasswordSalt", typeof(System.String), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Contact", "PasswordSalt", false, (int)SqlDbType.VarChar, 10, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ContactFieldIndex.AdditionalContactInfo:
					fieldToReturn = new EntityField("AdditionalContactInfo", typeof(System.String), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "Contact", "AdditionalContactInfo", true, (int)SqlDbType.Xml, 2147483647, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ContactFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"Person", "Contact", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case ContactFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "ContactEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Person", "Contact", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CountryRegionEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(CountryRegionFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CountryRegionFieldIndex.CountryRegionCode:
					fieldToReturn = new EntityField("CountryRegionCode", typeof(System.String), "CountryRegionEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "CountryRegion", "CountryRegionCode", false, (int)SqlDbType.NVarChar, 3, 0, 0, true, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CountryRegionFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), "CountryRegionEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "CountryRegion", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CountryRegionFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "CountryRegionEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Person", "CountryRegion", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CustomerEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(CustomerFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CustomerFieldIndex.CustomerId:
					fieldToReturn = new EntityField("CustomerId", typeof(System.Int32), "CustomerEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "Customer", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case CustomerFieldIndex.TerritoryId:
					fieldToReturn = new EntityField("TerritoryId", typeof(System.Int32), "CustomerEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "Customer", "TerritoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case CustomerFieldIndex.AccountNumber:
					fieldToReturn = new EntityField("AccountNumber", typeof(System.String), "CustomerEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "Customer", "AccountNumber", false, (int)SqlDbType.VarChar, 10, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerFieldIndex.CustomerType:
					fieldToReturn = new EntityField("CustomerType", typeof(System.String), "CustomerEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "Customer", "CustomerType", false, (int)SqlDbType.NChar, 1, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "CustomerEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"Sales", "Customer", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case CustomerFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "CustomerEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Sales", "Customer", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CustomerAddressEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(CustomerAddressFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CustomerAddressFieldIndex.CustomerId:
					fieldToReturn = new EntityField("CustomerId", typeof(System.Int32), "CustomerAddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "CustomerAddress", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case CustomerAddressFieldIndex.AddressId:
					fieldToReturn = new EntityField("AddressId", typeof(System.Int32), "CustomerAddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "CustomerAddress", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case CustomerAddressFieldIndex.AddressTypeId:
					fieldToReturn = new EntityField("AddressTypeId", typeof(System.Int32), "CustomerAddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "CustomerAddress", "AddressTypeID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case CustomerAddressFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "CustomerAddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"Sales", "CustomerAddress", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case CustomerAddressFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "CustomerAddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Sales", "CustomerAddress", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CustomerViewRelatedEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(CustomerViewRelatedFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CustomerViewRelatedFieldIndex.CustomerId:
					fieldToReturn = new EntityField("CustomerId", typeof(System.Int32), "CustomerViewRelatedEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "vIndividualCustomer", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.Title:
					fieldToReturn = new EntityField("Title", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "Title", false, (int)SqlDbType.NVarChar, 8, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.FirstName:
					fieldToReturn = new EntityField("FirstName", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "FirstName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.MiddleName:
					fieldToReturn = new EntityField("MiddleName", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "MiddleName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.LastName:
					fieldToReturn = new EntityField("LastName", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "LastName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.Suffix:
					fieldToReturn = new EntityField("Suffix", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "Suffix", false, (int)SqlDbType.NVarChar, 10, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.Phone:
					fieldToReturn = new EntityField("Phone", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "Phone", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.EmailAddress:
					fieldToReturn = new EntityField("EmailAddress", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "EmailAddress", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.EmailPromotion:
					fieldToReturn = new EntityField("EmailPromotion", typeof(System.Int32), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "vIndividualCustomer", "EmailPromotion", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.AddressType:
					fieldToReturn = new EntityField("AddressType", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "AddressType", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.AddressLine1:
					fieldToReturn = new EntityField("AddressLine1", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "AddressLine1", false, (int)SqlDbType.NVarChar, 60, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.AddressLine2:
					fieldToReturn = new EntityField("AddressLine2", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "AddressLine2", false, (int)SqlDbType.NVarChar, 60, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.City:
					fieldToReturn = new EntityField("City", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "City", false, (int)SqlDbType.NVarChar, 30, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.StateProvinceName:
					fieldToReturn = new EntityField("StateProvinceName", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "StateProvinceName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.PostalCode:
					fieldToReturn = new EntityField("PostalCode", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "PostalCode", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.CountryRegionName:
					fieldToReturn = new EntityField("CountryRegionName", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "CountryRegionName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewRelatedFieldIndex.Demographics:
					fieldToReturn = new EntityField("Demographics", typeof(System.String), "CustomerViewRelatedEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "Demographics", false, (int)SqlDbType.Xml, 2147483647, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the EmployeeEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(EmployeeFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case EmployeeFieldIndex.EmployeeId:
					fieldToReturn = new EntityField("EmployeeId", typeof(System.Int32), "EmployeeEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"HumanResources", "Employee", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.NationalIdnumber:
					fieldToReturn = new EntityField("NationalIdnumber", typeof(System.String), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"HumanResources", "Employee", "NationalIDNumber", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.ContactId:
					fieldToReturn = new EntityField("ContactId", typeof(System.Int32), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"HumanResources", "Employee", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.LoginId:
					fieldToReturn = new EntityField("LoginId", typeof(System.String), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"HumanResources", "Employee", "LoginID", false, (int)SqlDbType.NVarChar, 256, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.ManagerId:
					fieldToReturn = new EntityField("ManagerId", typeof(System.Int32), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"HumanResources", "Employee", "ManagerID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.Title:
					fieldToReturn = new EntityField("Title", typeof(System.String), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"HumanResources", "Employee", "Title", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.BirthDate:
					fieldToReturn = new EntityField("BirthDate", typeof(System.DateTime), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"HumanResources", "Employee", "BirthDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.MaritalStatus:
					fieldToReturn = new EntityField("MaritalStatus", typeof(System.String), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"HumanResources", "Employee", "MaritalStatus", false, (int)SqlDbType.NChar, 1, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.Gender:
					fieldToReturn = new EntityField("Gender", typeof(System.String), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"HumanResources", "Employee", "Gender", false, (int)SqlDbType.NChar, 1, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.HireDate:
					fieldToReturn = new EntityField("HireDate", typeof(System.DateTime), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"HumanResources", "Employee", "HireDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.SalariedFlag:
					fieldToReturn = new EntityField("SalariedFlag", typeof(System.Boolean), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), @"HumanResources", "Employee", "SalariedFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", false, null, typeof(System.Boolean), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.VacationHours:
					fieldToReturn = new EntityField("VacationHours", typeof(System.Int16), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), @"HumanResources", "Employee", "VacationHours", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", false, null, typeof(System.Int16), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.SickLeaveHours:
					fieldToReturn = new EntityField("SickLeaveHours", typeof(System.Int16), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), @"HumanResources", "Employee", "SickLeaveHours", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", false, null, typeof(System.Int16), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.CurrentFlag:
					fieldToReturn = new EntityField("CurrentFlag", typeof(System.Boolean), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), @"HumanResources", "Employee", "CurrentFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", false, null, typeof(System.Boolean), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"HumanResources", "Employee", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case EmployeeFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "EmployeeEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"HumanResources", "Employee", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the EmployeeAddressEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(EmployeeAddressFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case EmployeeAddressFieldIndex.EmployeeId:
					fieldToReturn = new EntityField("EmployeeId", typeof(System.Int32), "EmployeeAddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"HumanResources", "EmployeeAddress", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case EmployeeAddressFieldIndex.AddressId:
					fieldToReturn = new EntityField("AddressId", typeof(System.Int32), "EmployeeAddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"HumanResources", "EmployeeAddress", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case EmployeeAddressFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "EmployeeAddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"HumanResources", "EmployeeAddress", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case EmployeeAddressFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "EmployeeAddressEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"HumanResources", "EmployeeAddress", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the IndividualEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(IndividualFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case IndividualFieldIndex.CustomerId:
					fieldToReturn = new EntityField("CustomerId", typeof(System.Int32), "IndividualEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "Individual", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case IndividualFieldIndex.ContactId:
					fieldToReturn = new EntityField("ContactId", typeof(System.Int32), "IndividualEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "Individual", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case IndividualFieldIndex.Demographics:
					fieldToReturn = new EntityField("Demographics", typeof(System.String), "IndividualEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "Individual", "Demographics", true, (int)SqlDbType.Xml, 2147483647, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case IndividualFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "IndividualEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Sales", "Individual", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ProductFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductFieldIndex.ProductId:
					fieldToReturn = new EntityField("ProductId", typeof(System.Int32), "ProductEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Production", "Product", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case ProductFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Production", "Product", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ProductFieldIndex.ProductNumber:
					fieldToReturn = new EntityField("ProductNumber", typeof(System.String), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Production", "Product", "ProductNumber", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ProductFieldIndex.MakeFlag:
					fieldToReturn = new EntityField("MakeFlag", typeof(System.Boolean), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), @"Production", "Product", "MakeFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", false, null, typeof(System.Boolean), (int)fieldIndex);
					break;
				case ProductFieldIndex.FinishedGoodsFlag:
					fieldToReturn = new EntityField("FinishedGoodsFlag", typeof(System.Boolean), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), @"Production", "Product", "FinishedGoodsFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", false, null, typeof(System.Boolean), (int)fieldIndex);
					break;
				case ProductFieldIndex.Color:
					fieldToReturn = new EntityField("Color", typeof(System.String), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Production", "Product", "Color", true, (int)SqlDbType.NVarChar, 15, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ProductFieldIndex.SafetyStockLevel:
					fieldToReturn = new EntityField("SafetyStockLevel", typeof(System.Int16), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), @"Production", "Product", "SafetyStockLevel", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", false, null, typeof(System.Int16), (int)fieldIndex);
					break;
				case ProductFieldIndex.ReorderPoint:
					fieldToReturn = new EntityField("ReorderPoint", typeof(System.Int16), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), @"Production", "Product", "ReorderPoint", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", false, null, typeof(System.Int16), (int)fieldIndex);
					break;
				case ProductFieldIndex.StandardCost:
					fieldToReturn = new EntityField("StandardCost", typeof(System.Decimal), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Production", "Product", "StandardCost", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case ProductFieldIndex.ListPrice:
					fieldToReturn = new EntityField("ListPrice", typeof(System.Decimal), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Production", "Product", "ListPrice", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case ProductFieldIndex.Size:
					fieldToReturn = new EntityField("Size", typeof(System.String), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Production", "Product", "Size", true, (int)SqlDbType.NVarChar, 5, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ProductFieldIndex.SizeUnitMeasureCode:
					fieldToReturn = new EntityField("SizeUnitMeasureCode", typeof(System.String), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Production", "Product", "SizeUnitMeasureCode", true, (int)SqlDbType.NChar, 3, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ProductFieldIndex.WeightUnitMeasureCode:
					fieldToReturn = new EntityField("WeightUnitMeasureCode", typeof(System.String), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Production", "Product", "WeightUnitMeasureCode", true, (int)SqlDbType.NChar, 3, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ProductFieldIndex.Weight:
					fieldToReturn = new EntityField("Weight", typeof(System.Decimal), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Production", "Product", "Weight", true, (int)SqlDbType.Decimal, 0, 2, 8, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case ProductFieldIndex.DaysToManufacture:
					fieldToReturn = new EntityField("DaysToManufacture", typeof(System.Int32), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Production", "Product", "DaysToManufacture", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case ProductFieldIndex.ProductLine:
					fieldToReturn = new EntityField("ProductLine", typeof(System.String), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Production", "Product", "ProductLine", true, (int)SqlDbType.NChar, 2, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ProductFieldIndex.Class:
					fieldToReturn = new EntityField("Class", typeof(System.String), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Production", "Product", "Class", true, (int)SqlDbType.NChar, 2, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ProductFieldIndex.Style:
					fieldToReturn = new EntityField("Style", typeof(System.String), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Production", "Product", "Style", true, (int)SqlDbType.NChar, 2, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ProductFieldIndex.ProductSubcategoryId:
					fieldToReturn = new EntityField("ProductSubcategoryId", typeof(System.Int32), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Production", "Product", "ProductSubcategoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case ProductFieldIndex.ProductModelId:
					fieldToReturn = new EntityField("ProductModelId", typeof(System.Int32), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Production", "Product", "ProductModelID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case ProductFieldIndex.SellStartDate:
					fieldToReturn = new EntityField("SellStartDate", typeof(System.DateTime), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Production", "Product", "SellStartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
				case ProductFieldIndex.SellEndDate:
					fieldToReturn = new EntityField("SellEndDate", typeof(System.DateTime), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Production", "Product", "SellEndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
				case ProductFieldIndex.DiscontinuedDate:
					fieldToReturn = new EntityField("DiscontinuedDate", typeof(System.DateTime), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Production", "Product", "DiscontinuedDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
				case ProductFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"Production", "Product", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case ProductFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "ProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Production", "Product", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SalesOrderDetailEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(SalesOrderDetailFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SalesOrderDetailFieldIndex.SalesOrderId:
					fieldToReturn = new EntityField("SalesOrderId", typeof(System.Int32), "SalesOrderDetailEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderDetail", "SalesOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.SalesOrderDetailId:
					fieldToReturn = new EntityField("SalesOrderDetailId", typeof(System.Int32), "SalesOrderDetailEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderDetail", "SalesOrderDetailID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.CarrierTrackingNumber:
					fieldToReturn = new EntityField("CarrierTrackingNumber", typeof(System.String), "SalesOrderDetailEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "SalesOrderDetail", "CarrierTrackingNumber", true, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.OrderQty:
					fieldToReturn = new EntityField("OrderQty", typeof(System.Int16), "SalesOrderDetailEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), @"Sales", "SalesOrderDetail", "OrderQty", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", false, null, typeof(System.Int16), (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.ProductId:
					fieldToReturn = new EntityField("ProductId", typeof(System.Int32), "SalesOrderDetailEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderDetail", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.SpecialOfferId:
					fieldToReturn = new EntityField("SpecialOfferId", typeof(System.Int32), "SalesOrderDetailEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderDetail", "SpecialOfferID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.UnitPrice:
					fieldToReturn = new EntityField("UnitPrice", typeof(System.Decimal), "SalesOrderDetailEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Sales", "SalesOrderDetail", "UnitPrice", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.UnitPriceDiscount:
					fieldToReturn = new EntityField("UnitPriceDiscount", typeof(System.Decimal), "SalesOrderDetailEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Sales", "SalesOrderDetail", "UnitPriceDiscount", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.LineTotal:
					fieldToReturn = new EntityField("LineTotal", typeof(System.Decimal), "SalesOrderDetailEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Sales", "SalesOrderDetail", "LineTotal", false, (int)SqlDbType.Decimal, 0, 6, 38, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "SalesOrderDetailEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"Sales", "SalesOrderDetail", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "SalesOrderDetailEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Sales", "SalesOrderDetail", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SalesOrderHeaderEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(SalesOrderHeaderFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SalesOrderHeaderFieldIndex.SalesOrderId:
					fieldToReturn = new EntityField("SalesOrderId", typeof(System.Int32), "SalesOrderHeaderEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderHeader", "SalesOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.RevisionNumber:
					fieldToReturn = new EntityField("RevisionNumber", typeof(System.Byte), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), @"Sales", "SalesOrderHeader", "RevisionNumber", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, false, "", false, null, typeof(System.Byte), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.OrderDate:
					fieldToReturn = new EntityField("OrderDate", typeof(System.DateTime), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Sales", "SalesOrderHeader", "OrderDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.DueDate:
					fieldToReturn = new EntityField("DueDate", typeof(System.DateTime), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Sales", "SalesOrderHeader", "DueDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.ShipDate:
					fieldToReturn = new EntityField("ShipDate", typeof(System.DateTime), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Sales", "SalesOrderHeader", "ShipDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.Status:
					fieldToReturn = new EntityField("Status", typeof(System.Byte), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), @"Sales", "SalesOrderHeader", "Status", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, false, "", false, null, typeof(System.Byte), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.OnlineOrderFlag:
					fieldToReturn = new EntityField("OnlineOrderFlag", typeof(System.Boolean), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), @"Sales", "SalesOrderHeader", "OnlineOrderFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", false, null, typeof(System.Boolean), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.SalesOrderNumber:
					fieldToReturn = new EntityField("SalesOrderNumber", typeof(System.String), "SalesOrderHeaderEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "SalesOrderHeader", "SalesOrderNumber", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.PurchaseOrderNumber:
					fieldToReturn = new EntityField("PurchaseOrderNumber", typeof(System.String), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "SalesOrderHeader", "PurchaseOrderNumber", true, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.AccountNumber:
					fieldToReturn = new EntityField("AccountNumber", typeof(System.String), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "SalesOrderHeader", "AccountNumber", true, (int)SqlDbType.NVarChar, 15, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.CustomerId:
					fieldToReturn = new EntityField("CustomerId", typeof(System.Int32), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderHeader", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.ContactId:
					fieldToReturn = new EntityField("ContactId", typeof(System.Int32), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderHeader", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.SalesPersonId:
					fieldToReturn = new EntityField("SalesPersonId", typeof(System.Int32), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderHeader", "SalesPersonID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.TerritoryId:
					fieldToReturn = new EntityField("TerritoryId", typeof(System.Int32), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderHeader", "TerritoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.BillToAddressId:
					fieldToReturn = new EntityField("BillToAddressId", typeof(System.Int32), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderHeader", "BillToAddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.ShipToAddressId:
					fieldToReturn = new EntityField("ShipToAddressId", typeof(System.Int32), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderHeader", "ShipToAddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.ShipMethodId:
					fieldToReturn = new EntityField("ShipMethodId", typeof(System.Int32), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderHeader", "ShipMethodID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.CreditCardId:
					fieldToReturn = new EntityField("CreditCardId", typeof(System.Int32), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderHeader", "CreditCardID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.CreditCardApprovalCode:
					fieldToReturn = new EntityField("CreditCardApprovalCode", typeof(System.String), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "SalesOrderHeader", "CreditCardApprovalCode", true, (int)SqlDbType.VarChar, 15, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.CurrencyRateId:
					fieldToReturn = new EntityField("CurrencyRateId", typeof(System.Int32), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SalesOrderHeader", "CurrencyRateID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.SubTotal:
					fieldToReturn = new EntityField("SubTotal", typeof(System.Decimal), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Sales", "SalesOrderHeader", "SubTotal", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.TaxAmt:
					fieldToReturn = new EntityField("TaxAmt", typeof(System.Decimal), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Sales", "SalesOrderHeader", "TaxAmt", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.Freight:
					fieldToReturn = new EntityField("Freight", typeof(System.Decimal), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Sales", "SalesOrderHeader", "Freight", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.TotalDue:
					fieldToReturn = new EntityField("TotalDue", typeof(System.Decimal), "SalesOrderHeaderEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Sales", "SalesOrderHeader", "TotalDue", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.Comment:
					fieldToReturn = new EntityField("Comment", typeof(System.String), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "SalesOrderHeader", "Comment", true, (int)SqlDbType.NVarChar, 128, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"Sales", "SalesOrderHeader", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "SalesOrderHeaderEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Sales", "SalesOrderHeader", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ShipMethodEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ShipMethodFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ShipMethodFieldIndex.ShipMethodId:
					fieldToReturn = new EntityField("ShipMethodId", typeof(System.Int32), "ShipMethodEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Purchasing", "ShipMethod", "ShipMethodID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case ShipMethodFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), "ShipMethodEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Purchasing", "ShipMethod", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case ShipMethodFieldIndex.ShipBase:
					fieldToReturn = new EntityField("ShipBase", typeof(System.Decimal), "ShipMethodEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Purchasing", "ShipMethod", "ShipBase", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case ShipMethodFieldIndex.ShipRate:
					fieldToReturn = new EntityField("ShipRate", typeof(System.Decimal), "ShipMethodEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Purchasing", "ShipMethod", "ShipRate", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case ShipMethodFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "ShipMethodEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"Purchasing", "ShipMethod", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case ShipMethodFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "ShipMethodEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Purchasing", "ShipMethod", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SpecialOfferEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(SpecialOfferFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SpecialOfferFieldIndex.SpecialOfferId:
					fieldToReturn = new EntityField("SpecialOfferId", typeof(System.Int32), "SpecialOfferEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SpecialOffer", "SpecialOfferID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.Description:
					fieldToReturn = new EntityField("Description", typeof(System.String), "SpecialOfferEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "SpecialOffer", "Description", false, (int)SqlDbType.NVarChar, 255, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.DiscountPct:
					fieldToReturn = new EntityField("DiscountPct", typeof(System.Decimal), "SpecialOfferEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), @"Sales", "SpecialOffer", "DiscountPct", false, (int)SqlDbType.SmallMoney, 0, 4, 10, false, false, "", false, null, typeof(System.Decimal), (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.Type:
					fieldToReturn = new EntityField("Type", typeof(System.String), "SpecialOfferEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "SpecialOffer", "Type", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.Category:
					fieldToReturn = new EntityField("Category", typeof(System.String), "SpecialOfferEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "SpecialOffer", "Category", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.StartDate:
					fieldToReturn = new EntityField("StartDate", typeof(System.DateTime), "SpecialOfferEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Sales", "SpecialOffer", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.EndDate:
					fieldToReturn = new EntityField("EndDate", typeof(System.DateTime), "SpecialOfferEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Sales", "SpecialOffer", "EndDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.MinQty:
					fieldToReturn = new EntityField("MinQty", typeof(System.Int32), "SpecialOfferEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SpecialOffer", "MinQty", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.MaxQty:
					fieldToReturn = new EntityField("MaxQty", typeof(System.Int32), "SpecialOfferEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SpecialOffer", "MaxQty", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "SpecialOfferEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"Sales", "SpecialOffer", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "SpecialOfferEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Sales", "SpecialOffer", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SpecialOfferProductEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(SpecialOfferProductFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SpecialOfferProductFieldIndex.SpecialOfferId:
					fieldToReturn = new EntityField("SpecialOfferId", typeof(System.Int32), "SpecialOfferProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SpecialOfferProduct", "SpecialOfferID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SpecialOfferProductFieldIndex.ProductId:
					fieldToReturn = new EntityField("ProductId", typeof(System.Int32), "SpecialOfferProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "SpecialOfferProduct", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", true, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case SpecialOfferProductFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "SpecialOfferProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"Sales", "SpecialOfferProduct", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case SpecialOfferProductFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "SpecialOfferProductEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Sales", "SpecialOfferProduct", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the StateProvinceEntity. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(StateProvinceFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case StateProvinceFieldIndex.StateProvinceId:
					fieldToReturn = new EntityField("StateProvinceId", typeof(System.Int32), "StateProvinceEntity", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Person", "StateProvince", "StateProvinceID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.StateProvinceCode:
					fieldToReturn = new EntityField("StateProvinceCode", typeof(System.String), "StateProvinceEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "StateProvince", "StateProvinceCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.CountryRegionCode:
					fieldToReturn = new EntityField("CountryRegionCode", typeof(System.String), "StateProvinceEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "StateProvince", "CountryRegionCode", false, (int)SqlDbType.NVarChar, 3, 0, 0, false, false, "", true, null, typeof(System.String), (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.IsOnlyStateProvinceFlag:
					fieldToReturn = new EntityField("IsOnlyStateProvinceFlag", typeof(System.Boolean), "StateProvinceEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), @"Person", "StateProvince", "IsOnlyStateProvinceFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", false, null, typeof(System.Boolean), (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), "StateProvinceEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Person", "StateProvince", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.TerritoryId:
					fieldToReturn = new EntityField("TerritoryId", typeof(System.Int32), "StateProvinceEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Person", "StateProvince", "TerritoryID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), "StateProvinceEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), @"Person", "StateProvince", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", false, null, typeof(System.Guid), (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), "StateProvinceEntity", false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), @"Person", "StateProvince", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", false, null, typeof(System.DateTime), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CustomerView TypedView. 
		/// Which EntityField is created is specified by fieldIndex
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(CustomerViewFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CustomerViewFieldIndex.CustomerId:
					fieldToReturn = new EntityField("CustomerId", typeof(System.Int32), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "vIndividualCustomer", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.Title:
					fieldToReturn = new EntityField("Title", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "Title", false, (int)SqlDbType.NVarChar, 8, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.FirstName:
					fieldToReturn = new EntityField("FirstName", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "FirstName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.MiddleName:
					fieldToReturn = new EntityField("MiddleName", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "MiddleName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.LastName:
					fieldToReturn = new EntityField("LastName", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "LastName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.Suffix:
					fieldToReturn = new EntityField("Suffix", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "Suffix", false, (int)SqlDbType.NVarChar, 10, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.Phone:
					fieldToReturn = new EntityField("Phone", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "Phone", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.EmailAddress:
					fieldToReturn = new EntityField("EmailAddress", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "EmailAddress", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.EmailPromotion:
					fieldToReturn = new EntityField("EmailPromotion", typeof(System.Int32), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), @"Sales", "vIndividualCustomer", "EmailPromotion", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", false, null, typeof(System.Int32), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.AddressType:
					fieldToReturn = new EntityField("AddressType", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "AddressType", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.AddressLine1:
					fieldToReturn = new EntityField("AddressLine1", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "AddressLine1", false, (int)SqlDbType.NVarChar, 60, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.AddressLine2:
					fieldToReturn = new EntityField("AddressLine2", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "AddressLine2", false, (int)SqlDbType.NVarChar, 60, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.City:
					fieldToReturn = new EntityField("City", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "City", false, (int)SqlDbType.NVarChar, 30, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.StateProvinceName:
					fieldToReturn = new EntityField("StateProvinceName", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "StateProvinceName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.PostalCode:
					fieldToReturn = new EntityField("PostalCode", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "PostalCode", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.CountryRegionName:
					fieldToReturn = new EntityField("CountryRegionName", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "CountryRegionName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
				case CustomerViewFieldIndex.Demographics:
					fieldToReturn = new EntityField("Demographics", typeof(System.String), "CustomerViewTypedView", true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), @"Sales", "vIndividualCustomer", "Demographics", false, (int)SqlDbType.Xml, 2147483647, 0, 0, false, false, "", false, null, typeof(System.String), (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	


		#region Included Code

		#endregion
	}
}
