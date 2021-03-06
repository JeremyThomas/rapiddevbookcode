﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: PurchaseOrderDetail. </summary>
	public partial class PurchaseOrderDetailRelations
	{
		/// <summary>CTor</summary>
		public PurchaseOrderDetailRelations()
		{
		}

		/// <summary>Gets all relations of the PurchaseOrderDetailEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.PurchaseOrderHistoryEntityUsingReferenceOrderLineIDReferenceOrderID);
			toReturn.Add(this.ProductEntityUsingProductID);
			toReturn.Add(this.PurchaseOrderHeaderEntityUsingPurchaseOrderID);
			return toReturn;
		}

		#region Class Property Declarations


		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderDetailEntity and PurchaseOrderHistoryEntity over the 1:1 relation they have, using the relation between the fields:
		/// PurchaseOrderDetail.PurchaseOrderDetailID - PurchaseOrderHistory.ReferenceOrderLineID
		/// PurchaseOrderDetail.PurchaseOrderID - PurchaseOrderHistory.ReferenceOrderID
		/// </summary>
		public virtual IEntityRelation PurchaseOrderHistoryEntityUsingReferenceOrderLineIDReferenceOrderID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "PurchaseOrderHistory", true);


				relation.AddEntityFieldPair(PurchaseOrderDetailFields.PurchaseOrderDetailID, PurchaseOrderHistoryFields.ReferenceOrderLineID);



				relation.AddEntityFieldPair(PurchaseOrderDetailFields.PurchaseOrderID, PurchaseOrderHistoryFields.ReferenceOrderID);


				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderDetailEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderDetailEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// PurchaseOrderDetail.ProductID - Product.ProductID
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductID, PurchaseOrderDetailFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderDetailEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderDetailEntity and PurchaseOrderHeaderEntity over the m:1 relation they have, using the relation between the fields:
		/// PurchaseOrderDetail.PurchaseOrderID - PurchaseOrderHeader.PurchaseOrderID
		/// </summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingPurchaseOrderID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "PurchaseOrderHeader", false);
				relation.AddEntityFieldPair(PurchaseOrderHeaderFields.PurchaseOrderID, PurchaseOrderDetailFields.PurchaseOrderID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderDetailEntity", true);
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
	internal static class StaticPurchaseOrderDetailRelations
	{
		internal static readonly IEntityRelation PurchaseOrderHistoryEntityUsingReferenceOrderLineIDReferenceOrderIDStatic = new PurchaseOrderDetailRelations().PurchaseOrderHistoryEntityUsingReferenceOrderLineIDReferenceOrderID;
		internal static readonly IEntityRelation ProductEntityUsingProductIDStatic = new PurchaseOrderDetailRelations().ProductEntityUsingProductID;
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingPurchaseOrderIDStatic = new PurchaseOrderDetailRelations().PurchaseOrderHeaderEntityUsingPurchaseOrderID;

		/// <summary>CTor</summary>
		static StaticPurchaseOrderDetailRelations()
		{
		}
	}
}
