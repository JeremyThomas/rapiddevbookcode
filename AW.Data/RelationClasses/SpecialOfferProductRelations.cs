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
	/// <summary>Implements the relations factory for the entity: SpecialOfferProduct. </summary>
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
			toReturn.Add(this.SalesOrderDetailEntityUsingProductIDSpecialOfferID);
			toReturn.Add(this.ProductEntityUsingProductID);
			toReturn.Add(this.SpecialOfferEntityUsingSpecialOfferID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SpecialOfferProductEntity and SalesOrderDetailEntity over the 1:n relation they have, using the relation between the fields:
		/// SpecialOfferProduct.ProductID - SalesOrderDetail.ProductID
		/// SpecialOfferProduct.SpecialOfferID - SalesOrderDetail.SpecialOfferID
		/// </summary>
		public virtual IEntityRelation SalesOrderDetailEntityUsingProductIDSpecialOfferID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderDetails" , true);
				relation.AddEntityFieldPair(SpecialOfferProductFields.ProductID, SalesOrderDetailFields.ProductID);
				relation.AddEntityFieldPair(SpecialOfferProductFields.SpecialOfferID, SalesOrderDetailFields.SpecialOfferID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderDetailEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SpecialOfferProductEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// SpecialOfferProduct.ProductID - Product.ProductID
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductID, SpecialOfferProductFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SpecialOfferProductEntity and SpecialOfferEntity over the m:1 relation they have, using the relation between the fields:
		/// SpecialOfferProduct.SpecialOfferID - SpecialOffer.SpecialOfferID
		/// </summary>
		public virtual IEntityRelation SpecialOfferEntityUsingSpecialOfferID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SpecialOffer", false);
				relation.AddEntityFieldPair(SpecialOfferFields.SpecialOfferID, SpecialOfferProductFields.SpecialOfferID);
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
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSpecialOfferProductRelations
	{
		internal static readonly IEntityRelation SalesOrderDetailEntityUsingProductIDSpecialOfferIDStatic = new SpecialOfferProductRelations().SalesOrderDetailEntityUsingProductIDSpecialOfferID;
		internal static readonly IEntityRelation ProductEntityUsingProductIDStatic = new SpecialOfferProductRelations().ProductEntityUsingProductID;
		internal static readonly IEntityRelation SpecialOfferEntityUsingSpecialOfferIDStatic = new SpecialOfferProductRelations().SpecialOfferEntityUsingSpecialOfferID;

		/// <summary>CTor</summary>
		static StaticSpecialOfferProductRelations()
		{
		}
	}
}
