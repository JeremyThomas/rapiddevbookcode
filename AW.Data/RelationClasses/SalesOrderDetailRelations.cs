///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Thursday, 12 February 2009 11:38:24 p.m.
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
	/// <summary>Implements the static Relations variant for the entity: SalesOrderDetail. </summary>
	public partial class SalesOrderDetailRelations
	{
		/// <summary>CTor</summary>
		public SalesOrderDetailRelations()
		{
		}

		/// <summary>Gets all relations of the SalesOrderDetailEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.SalesOrderHeaderEntityUsingSalesOrderID);
			toReturn.Add(this.SpecialOfferProductEntityUsingSpecialOfferIDProductID);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SalesOrderDetailEntity and SalesOrderHeaderEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderDetail.SalesOrderID - SalesOrderHeader.SalesOrderID
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingSalesOrderID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesOrderHeader", false);
				relation.AddEntityFieldPair(SalesOrderHeaderFields.SalesOrderID, SalesOrderDetailFields.SalesOrderID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderDetailEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderDetailEntity and SpecialOfferProductEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderDetail.SpecialOfferID - SpecialOfferProduct.SpecialOfferID
		/// SalesOrderDetail.ProductID - SpecialOfferProduct.ProductID
		/// </summary>
		public virtual IEntityRelation SpecialOfferProductEntityUsingSpecialOfferIDProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SpecialOfferProduct", false);
				relation.AddEntityFieldPair(SpecialOfferProductFields.SpecialOfferID, SalesOrderDetailFields.SpecialOfferID);
				relation.AddEntityFieldPair(SpecialOfferProductFields.ProductID, SalesOrderDetailFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderDetailEntity", true);
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
