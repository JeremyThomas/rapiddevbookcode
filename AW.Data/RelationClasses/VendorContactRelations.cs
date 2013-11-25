///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
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
	/// <summary>Implements the relations factory for the entity: VendorContact. </summary>
	public partial class VendorContactRelations
	{
		/// <summary>CTor</summary>
		public VendorContactRelations()
		{
		}

		/// <summary>Gets all relations of the VendorContactEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ContactEntityUsingContactID);
			toReturn.Add(this.ContactTypeEntityUsingContactTypeID);
			toReturn.Add(this.VendorEntityUsingVendorID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between VendorContactEntity and ContactEntity over the m:1 relation they have, using the relation between the fields:
		/// VendorContact.ContactID - Contact.ContactID
		/// </summary>
		public virtual IEntityRelation ContactEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Contact", false);
				relation.AddEntityFieldPair(ContactFields.ContactID, VendorContactFields.ContactID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorContactEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between VendorContactEntity and ContactTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// VendorContact.ContactTypeID - ContactType.ContactTypeID
		/// </summary>
		public virtual IEntityRelation ContactTypeEntityUsingContactTypeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ContactType", false);
				relation.AddEntityFieldPair(ContactTypeFields.ContactTypeID, VendorContactFields.ContactTypeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorContactEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between VendorContactEntity and VendorEntity over the m:1 relation they have, using the relation between the fields:
		/// VendorContact.VendorID - Vendor.VendorID
		/// </summary>
		public virtual IEntityRelation VendorEntityUsingVendorID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Vendor", false);
				relation.AddEntityFieldPair(VendorFields.VendorID, VendorContactFields.VendorID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorContactEntity", true);
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
	internal static class StaticVendorContactRelations
	{
		internal static readonly IEntityRelation ContactEntityUsingContactIDStatic = new VendorContactRelations().ContactEntityUsingContactID;
		internal static readonly IEntityRelation ContactTypeEntityUsingContactTypeIDStatic = new VendorContactRelations().ContactTypeEntityUsingContactTypeID;
		internal static readonly IEntityRelation VendorEntityUsingVendorIDStatic = new VendorContactRelations().VendorEntityUsingVendorID;

		/// <summary>CTor</summary>
		static StaticVendorContactRelations()
		{
		}
	}
}
