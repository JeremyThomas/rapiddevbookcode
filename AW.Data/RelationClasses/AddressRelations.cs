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
			toReturn.Add(this.CustomerAddressEntityUsingAddressId);
			toReturn.Add(this.EmployeeAddressEntityUsingAddressId);
			toReturn.Add(this.SalesOrderHeaderEntityUsingShipToAddressId);
			toReturn.Add(this.SalesOrderHeaderEntityUsingBillToAddressId);

			toReturn.Add(this.StateProvinceEntityUsingStateProvinceId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and CustomerAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressId - CustomerAddress.AddressId
		/// </summary>
		public virtual IEntityRelation CustomerAddressEntityUsingAddressId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CustomerAddress" , true);
				relation.AddEntityFieldPair(AddressFields.AddressId, CustomerAddressFields.AddressId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and EmployeeAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressId - EmployeeAddress.AddressId
		/// </summary>
		public virtual IEntityRelation EmployeeAddressEntityUsingAddressId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeeAddress" , true);
				relation.AddEntityFieldPair(AddressFields.AddressId, EmployeeAddressFields.AddressId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressId - SalesOrderHeader.ShipToAddressId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingShipToAddressId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeader_" , true);
				relation.AddEntityFieldPair(AddressFields.AddressId, SalesOrderHeaderFields.ShipToAddressId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressId - SalesOrderHeader.BillToAddressId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingBillToAddressId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeader" , true);
				relation.AddEntityFieldPair(AddressFields.AddressId, SalesOrderHeaderFields.BillToAddressId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between AddressEntity and StateProvinceEntity over the m:1 relation they have, using the relation between the fields:
		/// Address.StateProvinceId - StateProvince.StateProvinceId
		/// </summary>
		public virtual IEntityRelation StateProvinceEntityUsingStateProvinceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "StateProvince", false);
				relation.AddEntityFieldPair(StateProvinceFields.StateProvinceId, AddressFields.StateProvinceId);
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
