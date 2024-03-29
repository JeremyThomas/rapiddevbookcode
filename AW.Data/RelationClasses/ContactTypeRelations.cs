﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the static Relations variant for the entity: ContactType. </summary>
	public partial class ContactTypeRelations
	{
		/// <summary>CTor</summary>
		public ContactTypeRelations()
		{
		}

		/// <summary>Gets all relations of the ContactTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.StoreContactEntityUsingContactTypeID);
			toReturn.Add(this.VendorContactEntityUsingContactTypeID);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ContactTypeEntity and StoreContactEntity over the 1:n relation they have, using the relation between the fields:
		/// ContactType.ContactTypeID - StoreContact.ContactTypeID
		/// </summary>
		public virtual IEntityRelation StoreContactEntityUsingContactTypeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "StoreContact" , true);
				relation.AddEntityFieldPair(ContactTypeFields.ContactTypeID, StoreContactFields.ContactTypeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreContactEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactTypeEntity and VendorContactEntity over the 1:n relation they have, using the relation between the fields:
		/// ContactType.ContactTypeID - VendorContact.ContactTypeID
		/// </summary>
		public virtual IEntityRelation VendorContactEntityUsingContactTypeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "VendorContact" , true);
				relation.AddEntityFieldPair(ContactTypeFields.ContactTypeID, VendorContactFields.ContactTypeID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorContactEntity", false);
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
