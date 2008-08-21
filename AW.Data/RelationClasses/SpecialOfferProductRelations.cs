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
	/// <summary>Implements the static Relations variant for the entity: SpecialOfferProduct. </summary>
	public partial class SpecialOfferProductRelations
	{
		/// <summary>CTor</summary>
		public SpecialOfferProductRelations()
		{
		}

		/// <summary>Gets all relations of the SpecialOfferProductEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SalesOrderDetailEntityUsingSpecialOfferIdProductId);

			toReturn.Add(this.ProductEntityUsingProductId);
			toReturn.Add(this.SpecialOfferEntityUsingSpecialOfferId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SpecialOfferProductEntity and SalesOrderDetailEntity over the 1:n relation they have, using the relation between the fields:
		/// SpecialOfferProduct.SpecialOfferId - SalesOrderDetail.SpecialOfferId
		/// SpecialOfferProduct.ProductId - SalesOrderDetail.ProductId
		/// </summary>
		public virtual IEntityRelation SalesOrderDetailEntityUsingSpecialOfferIdProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderDetail" , true);
				relation.AddEntityFieldPair(SpecialOfferProductFields.SpecialOfferId, SalesOrderDetailFields.SpecialOfferId);
				relation.AddEntityFieldPair(SpecialOfferProductFields.ProductId, SalesOrderDetailFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderDetailEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SpecialOfferProductEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// SpecialOfferProduct.ProductId - Product.ProductId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductId, SpecialOfferProductFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SpecialOfferProductEntity and SpecialOfferEntity over the m:1 relation they have, using the relation between the fields:
		/// SpecialOfferProduct.SpecialOfferId - SpecialOffer.SpecialOfferId
		/// </summary>
		public virtual IEntityRelation SpecialOfferEntityUsingSpecialOfferId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SpecialOffer", false);
				relation.AddEntityFieldPair(SpecialOfferFields.SpecialOfferId, SpecialOfferProductFields.SpecialOfferId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", true);
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
