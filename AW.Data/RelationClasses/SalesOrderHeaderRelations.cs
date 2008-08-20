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
	/// Implements the static Relations variant for the entity: SalesOrderHeader.
	/// This class is generated. Do not modify.
	/// </summary>
	public class SalesOrderHeaderRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public SalesOrderHeaderRelations()
		{
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and SalesOrderDetailEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesOrderHeader.SalesOrderId - SalesOrderDetail.SalesOrderId
		/// </summary>
		public virtual IEntityRelation SalesOrderDetailEntityUsingSalesOrderId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.SalesOrderId), EntityFieldFactory.Create(SalesOrderDetailFieldIndex.SalesOrderId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderDetailEntity", false);
				return relation;
			}
		}
	
	
	
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and AddressEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.BillToAddressId - Address.AddressId
		/// </summary>
		public virtual IEntityRelation AddressEntityUsingBillToAddressId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AddressFieldIndex.AddressId), EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.BillToAddressId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and AddressEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.ShipToAddressId - Address.AddressId
		/// </summary>
		public virtual IEntityRelation AddressEntityUsingShipToAddressId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AddressFieldIndex.AddressId), EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.ShipToAddressId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and ContactEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.ContactId - Contact.ContactId
		/// </summary>
		public virtual IEntityRelation ContactEntityUsingContactId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ContactFieldIndex.ContactId), EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.ContactId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CustomerEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.CustomerId - Customer.CustomerId
		/// </summary>
		public virtual IEntityRelation CustomerEntityUsingCustomerId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CustomerFieldIndex.CustomerId), EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.CustomerId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and ShipMethodEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.ShipMethodId - ShipMethod.ShipMethodId
		/// </summary>
		public virtual IEntityRelation ShipMethodEntityUsingShipMethodId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ShipMethodFieldIndex.ShipMethodId), EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.ShipMethodId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ShipMethodEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CustomerViewRelatedEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderHeader.CustomerId - CustomerViewRelated.CustomerId
		/// </summary>
		public virtual IEntityRelation CustomerViewRelatedEntityUsingCustomerId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.CustomerId), EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.CustomerId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerViewRelatedEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", true);
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
