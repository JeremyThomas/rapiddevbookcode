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
	/// Implements the static Relations variant for the entity: Individual.
	/// This class is generated. Do not modify.
	/// </summary>
	public class IndividualRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public IndividualRelations()
		{
		}

		#region Class Property Declarations

	
		/// <summary>Returns a new IEntityRelation object, between IndividualEntity and CustomerEntity over the 1:1 relation they have, using the relation between the fields:
		/// Individual.CustomerId - Customer.CustomerId
		/// </summary>
		public virtual IEntityRelation CustomerEntityUsingCustomerId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.OneToOne);
				


				relation.AddEntityFieldPair(EntityFieldFactory.Create(CustomerFieldIndex.CustomerId), EntityFieldFactory.Create(IndividualFieldIndex.CustomerId));

				relation.StartEntityIsPkSide = false;
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IndividualEntity", true);
				return relation;
			}
		}
	
	
		/// <summary>Returns a new IEntityRelation object, between IndividualEntity and ContactEntity over the m:1 relation they have, using the relation between the fields:
		/// Individual.ContactId - Contact.ContactId
		/// </summary>
		public virtual IEntityRelation ContactEntityUsingContactId
		{
			get
			{

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ContactFieldIndex.ContactId), EntityFieldFactory.Create(IndividualFieldIndex.ContactId));
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IndividualEntity", true);
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
