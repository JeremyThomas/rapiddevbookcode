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
	/// Implements the static Relations variant for the entity: Customer.
	/// This class is generated. Do not modify.
	/// </summary>
	public class CustomerRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public CustomerRelations()
		{
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CustomerEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Customer.CustomerId - SalesOrderHeader.CustomerId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingCustomerId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CustomerFieldIndex.CustomerId), EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.CustomerId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}
	
		/// <summary>Returns a new IEntityRelation object, between CustomerEntity and CustomerAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Customer.CustomerId - CustomerAddress.CustomerId
		/// </summary>
		public virtual IEntityRelation CustomerAddressEntityUsingCustomerId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CustomerFieldIndex.CustomerId), EntityFieldFactory.Create(CustomerAddressFieldIndex.CustomerId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerAddressEntity", false);
				return relation;
			}
		}
	
	
		/// <summary>Returns a new IEntityRelation object, between CustomerEntity and IndividualEntity over the 1:1 relation they have, using the relation between the fields:
		/// Customer.CustomerId - Individual.CustomerId
		/// </summary>
		public virtual IEntityRelation IndividualEntityUsingCustomerId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.OneToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CustomerFieldIndex.CustomerId), EntityFieldFactory.Create(IndividualFieldIndex.CustomerId));



				relation.StartEntityIsPkSide = true;
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IndividualEntity", false);
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
