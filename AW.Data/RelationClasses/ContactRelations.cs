///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
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
	/// <summary>Implements the relations factory for the entity: Contact. </summary>
	public partial class ContactRelations
	{
		/// <summary>CTor</summary>
		public ContactRelations()
		{
		}

		/// <summary>Gets all relations of the ContactEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeeEntityUsingContactID);
			toReturn.Add(this.VendorContactEntityUsingContactID);
			toReturn.Add(this.ContactCreditCardEntityUsingContactID);
			toReturn.Add(this.IndividualEntityUsingContactID);
			toReturn.Add(this.SalesOrderHeaderEntityUsingContactID);
			toReturn.Add(this.StoreContactEntityUsingContactID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and EmployeeEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactID - Employee.ContactID
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Employees" , true);
				relation.AddEntityFieldPair(ContactFields.ContactID, EmployeeFields.ContactID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and VendorContactEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactID - VendorContact.ContactID
		/// </summary>
		public virtual IEntityRelation VendorContactEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "VendorContacts" , true);
				relation.AddEntityFieldPair(ContactFields.ContactID, VendorContactFields.ContactID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorContactEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and ContactCreditCardEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactID - ContactCreditCard.ContactID
		/// </summary>
		public virtual IEntityRelation ContactCreditCardEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ContactCreditCards" , true);
				relation.AddEntityFieldPair(ContactFields.ContactID, ContactCreditCardFields.ContactID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactCreditCardEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and IndividualEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactID - Individual.ContactID
		/// </summary>
		public virtual IEntityRelation IndividualEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Individuals" , true);
				relation.AddEntityFieldPair(ContactFields.ContactID, IndividualFields.ContactID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IndividualEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactID - SalesOrderHeader.ContactID
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(ContactFields.ContactID, SalesOrderHeaderFields.ContactID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and StoreContactEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactID - StoreContact.ContactID
		/// </summary>
		public virtual IEntityRelation StoreContactEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "StoreContacts" , true);
				relation.AddEntityFieldPair(ContactFields.ContactID, StoreContactFields.ContactID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreContactEntity", false);
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
	internal static class StaticContactRelations
	{
		internal static readonly IEntityRelation EmployeeEntityUsingContactIDStatic = new ContactRelations().EmployeeEntityUsingContactID;
		internal static readonly IEntityRelation VendorContactEntityUsingContactIDStatic = new ContactRelations().VendorContactEntityUsingContactID;
		internal static readonly IEntityRelation ContactCreditCardEntityUsingContactIDStatic = new ContactRelations().ContactCreditCardEntityUsingContactID;
		internal static readonly IEntityRelation IndividualEntityUsingContactIDStatic = new ContactRelations().IndividualEntityUsingContactID;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingContactIDStatic = new ContactRelations().SalesOrderHeaderEntityUsingContactID;
		internal static readonly IEntityRelation StoreContactEntityUsingContactIDStatic = new ContactRelations().StoreContactEntityUsingContactID;

		/// <summary>CTor</summary>
		static StaticContactRelations()
		{
		}
	}
}
