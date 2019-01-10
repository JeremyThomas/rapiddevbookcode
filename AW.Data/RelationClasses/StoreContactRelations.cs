///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
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
	/// <summary>Implements the relations factory for the entity: StoreContact. </summary>
	public partial class StoreContactRelations
	{
		/// <summary>CTor</summary>
		public StoreContactRelations()
		{
		}

		/// <summary>Gets all relations of the StoreContactEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ContactEntityUsingContactID);
			toReturn.Add(this.ContactTypeEntityUsingContactTypeID);
			toReturn.Add(this.StoreEntityUsingCustomerID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between StoreContactEntity and ContactEntity over the m:1 relation they have, using the relation between the fields:
		/// StoreContact.ContactID - Contact.ContactID
		/// </summary>
		public virtual IEntityRelation ContactEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Contact", false);
				relation.AddEntityFieldPair(ContactFields.ContactID, StoreContactFields.ContactID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreContactEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between StoreContactEntity and ContactTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// StoreContact.ContactTypeID - ContactType.ContactTypeID
		/// </summary>
		public virtual IEntityRelation ContactTypeEntityUsingContactTypeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ContactType", false);
				relation.AddEntityFieldPair(ContactTypeFields.ContactTypeID, StoreContactFields.ContactTypeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreContactEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between StoreContactEntity and StoreEntity over the m:1 relation they have, using the relation between the fields:
		/// StoreContact.CustomerID - Store.CustomerID
		/// </summary>
		public virtual IEntityRelation StoreEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Store", false);
				relation.AddEntityFieldPair(StoreFields.CustomerID, StoreContactFields.CustomerID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreContactEntity", true);
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
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticStoreContactRelations
	{
		internal static readonly IEntityRelation ContactEntityUsingContactIDStatic = new StoreContactRelations().ContactEntityUsingContactID;
		internal static readonly IEntityRelation ContactTypeEntityUsingContactTypeIDStatic = new StoreContactRelations().ContactTypeEntityUsingContactTypeID;
		internal static readonly IEntityRelation StoreEntityUsingCustomerIDStatic = new StoreContactRelations().StoreEntityUsingCustomerID;

		/// <summary>CTor</summary>
		static StaticStoreContactRelations()
		{
		}
	}
}
