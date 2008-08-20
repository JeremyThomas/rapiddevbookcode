///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:31 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;

using AW.Data;
using AW.Data.FactoryClasses;
using AW.Data.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.RelationClasses
{
	/// <summary>
	/// Implements the static Relations variant for the entity: Address.
	/// This class is generated. Do not modify.
	/// </summary>
	public class AddressRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public AddressRelations()
		{
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressId - SalesOrderHeader.BillToAddressId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingBillToAddressId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AddressFieldIndex.AddressId), EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.BillToAddressId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
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

				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AddressFieldIndex.AddressId), EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.ShipToAddressId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
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

				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AddressFieldIndex.AddressId), EntityFieldFactory.Create(EmployeeAddressFieldIndex.AddressId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeAddressEntity", false);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between AddressEntity and CustomerAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressId - CustomerAddress.AddressId
		/// </summary>
		public virtual IEntityRelation CustomerAddressEntityUsingAddressId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AddressFieldIndex.AddressId), EntityFieldFactory.Create(CustomerAddressFieldIndex.AddressId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerAddressEntity", false);
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

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(StateProvinceFieldIndex.StateProvinceId), EntityFieldFactory.Create(AddressFieldIndex.StateProvinceId));
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
