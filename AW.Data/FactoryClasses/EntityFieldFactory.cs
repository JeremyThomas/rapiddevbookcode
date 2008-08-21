///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
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
	public partial class EntityFieldFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private EntityFieldFactory()
		{
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the AddressEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(AddressFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("AddressEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the AddressTypeEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(AddressTypeFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("AddressTypeEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the ContactEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ContactFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ContactEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the CountryRegionEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(CountryRegionFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("CountryRegionEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the CustomerEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(CustomerFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("CustomerEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the CustomerAddressEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(CustomerAddressFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("CustomerAddressEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the CustomerViewRelatedEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(CustomerViewRelatedFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("CustomerViewRelatedEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the EmployeeEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(EmployeeFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("EmployeeEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the EmployeeAddressEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(EmployeeAddressFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("EmployeeAddressEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the IndividualEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(IndividualFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("IndividualEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the ProductEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ProductFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ProductEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the SalesOrderDetailEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(SalesOrderDetailFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("SalesOrderDetailEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the SalesOrderHeaderEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(SalesOrderHeaderFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("SalesOrderHeaderEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the ShipMethodEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ShipMethodFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ShipMethodEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the SpecialOfferEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(SpecialOfferFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("SpecialOfferEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the SpecialOfferProductEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(SpecialOfferProductFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("SpecialOfferProductEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the StateProvinceEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(StateProvinceFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("StateProvinceEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the CustomerView TypedView. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(CustomerViewFieldIndex fieldIndex)
		{
			return new EntityField(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("CustomerViewTypedView", (int)fieldIndex), PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo("CustomerViewTypedView", fieldIndex.ToString()));
		}

		/// <summary>Creates a new IEntityField instance, which represents the field objectName.fieldName</summary>
		/// <param name="objectName">the name of the object the field belongs to, like CustomerEntity or OrdersTypedView</param>
		/// <param name="fieldName">the name of the field to create</param>
		public static IEntityField Create(string objectName, string fieldName)
        {
			return new EntityField(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(objectName, fieldName), PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(objectName, fieldName));
        }

		#region Included Code

		#endregion
	}
}
