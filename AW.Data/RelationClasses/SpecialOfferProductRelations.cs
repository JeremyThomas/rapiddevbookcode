///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:31 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;

using AW.Data;
using AW.Data.FactoryClasses;
using AW.Data.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.RelationClasses
{
	/// <summary>
	/// Implements the static Relations variant for the entity: SpecialOfferProduct.
	/// This class is generated. Do not modify.
	/// </summary>
	public class SpecialOfferProductRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public SpecialOfferProductRelations()
		{
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

				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				relation.StartEntityIsPkSide = true;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SpecialOfferProductFieldIndex.SpecialOfferId), EntityFieldFactory.Create(SalesOrderDetailFieldIndex.SpecialOfferId));
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SpecialOfferProductFieldIndex.ProductId), EntityFieldFactory.Create(SalesOrderDetailFieldIndex.ProductId));
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

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductId), EntityFieldFactory.Create(SpecialOfferProductFieldIndex.ProductId));
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

				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				relation.StartEntityIsPkSide = false;
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SpecialOfferFieldIndex.SpecialOfferId), EntityFieldFactory.Create(SpecialOfferProductFieldIndex.SpecialOfferId));
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
