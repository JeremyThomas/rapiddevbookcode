﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: SpecialOffer. </summary>
	public partial class SpecialOfferRelations
	{
		/// <summary>CTor</summary>
		public SpecialOfferRelations()
		{
		}

		/// <summary>Gets all relations of the SpecialOfferEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SpecialOfferProductEntityUsingSpecialOfferID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SpecialOfferEntity and SpecialOfferProductEntity over the 1:n relation they have, using the relation between the fields:
		/// SpecialOffer.SpecialOfferID - SpecialOfferProduct.SpecialOfferID
		/// </summary>
		public virtual IEntityRelation SpecialOfferProductEntityUsingSpecialOfferID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SpecialOfferProducts" , true);
				relation.AddEntityFieldPair(SpecialOfferFields.SpecialOfferID, SpecialOfferProductFields.SpecialOfferID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", false);
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
	internal static class StaticSpecialOfferRelations
	{
		internal static readonly IEntityRelation SpecialOfferProductEntityUsingSpecialOfferIDStatic = new SpecialOfferRelations().SpecialOfferProductEntityUsingSpecialOfferID;

		/// <summary>CTor</summary>
		static StaticSpecialOfferRelations()
		{
		}
	}
}
