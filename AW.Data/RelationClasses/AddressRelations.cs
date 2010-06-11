///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AW.Data;
using AW.Data.FactoryClasses;
using AW.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.RelationClasses
{
	/// <summary>Implements the static Relations variant for the entity: Address. </summary>
	public partial class AddressRelations
	{
		/// <summary>CTor</summary>
		public AddressRelations()
		{
		}

		/// <summary>Gets all relations of the AddressEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeeAddressEntityUsingAddressID);
			toReturn.Add(this.VendorAddressEntityUsingAddressID);
			toReturn.Add(this.CustomerAddressEntityUsingAddressID);
			toReturn.Add(this.SalesOrderHeaderEntityUsingBillToAddressID);
			toReturn.Add(this.SalesOrderHeaderEntityUsingShipToAddressID);
			toReturn.Add(this.StateProvinceEntityUsingStateProvinceID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and EmployeeAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressID - EmployeeAddress.AddressID
		/// </summary>
		public virtual IEntityRelation EmployeeAddressEntityUsingAddressID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeeAddresses" , true);
				relation.AddEntityFieldPair(AddressFields.AddressID, EmployeeAddressFields.AddressID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and VendorAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressID - VendorAddress.AddressID
		/// </summary>
		public virtual IEntityRelation VendorAddressEntityUsingAddressID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "VendorAddresses" , true);
				relation.AddEntityFieldPair(AddressFields.AddressID, VendorAddressFields.AddressID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and CustomerAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressID - CustomerAddress.AddressID
		/// </summary>
		public virtual IEntityRelation CustomerAddressEntityUsingAddressID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CustomerAddresses" , true);
				relation.AddEntityFieldPair(AddressFields.AddressID, CustomerAddressFields.AddressID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressID - SalesOrderHeader.BillToAddressID
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingBillToAddressID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(AddressFields.AddressID, SalesOrderHeaderFields.BillToAddressID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressID - SalesOrderHeader.ShipToAddressID
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingShipToAddressID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders_" , true);
				relation.AddEntityFieldPair(AddressFields.AddressID, SalesOrderHeaderFields.ShipToAddressID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between AddressEntity and StateProvinceEntity over the m:1 relation they have, using the relation between the fields:
		/// Address.StateProvinceID - StateProvince.StateProvinceID
		/// </summary>
		public virtual IEntityRelation StateProvinceEntityUsingStateProvinceID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "StateProvince", false);
				relation.AddEntityFieldPair(StateProvinceFields.StateProvinceID, AddressFields.StateProvinceID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
}
