///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
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
	/// <summary>Implements the relations factory for the entity: ContactCreditCard. </summary>
	public partial class ContactCreditCardRelations
	{
		/// <summary>CTor</summary>
		public ContactCreditCardRelations()
		{
		}

		/// <summary>Gets all relations of the ContactCreditCardEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ContactEntityUsingContactID);
			toReturn.Add(this.CreditCardEntityUsingCreditCardID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ContactCreditCardEntity and ContactEntity over the m:1 relation they have, using the relation between the fields:
		/// ContactCreditCard.ContactID - Contact.ContactID
		/// </summary>
		public virtual IEntityRelation ContactEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Contact", false);
				relation.AddEntityFieldPair(ContactFields.ContactID, ContactCreditCardFields.ContactID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactCreditCardEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ContactCreditCardEntity and CreditCardEntity over the m:1 relation they have, using the relation between the fields:
		/// ContactCreditCard.CreditCardID - CreditCard.CreditCardID
		/// </summary>
		public virtual IEntityRelation CreditCardEntityUsingCreditCardID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CreditCard", false);
				relation.AddEntityFieldPair(CreditCardFields.CreditCardID, ContactCreditCardFields.CreditCardID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CreditCardEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactCreditCardEntity", true);
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
	internal static class StaticContactCreditCardRelations
	{
		internal static readonly IEntityRelation ContactEntityUsingContactIDStatic = new ContactCreditCardRelations().ContactEntityUsingContactID;
		internal static readonly IEntityRelation CreditCardEntityUsingCreditCardIDStatic = new ContactCreditCardRelations().CreditCardEntityUsingCreditCardID;

		/// <summary>CTor</summary>
		static StaticContactCreditCardRelations()
		{
		}
	}
}
