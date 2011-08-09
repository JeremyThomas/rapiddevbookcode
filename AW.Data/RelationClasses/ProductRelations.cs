///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.0
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
	/// <summary>Implements the static Relations variant for the entity: Product. </summary>
	public partial class ProductRelations
	{
		/// <summary>CTor</summary>
		public ProductRelations()
		{
		}

		/// <summary>Gets all relations of the ProductEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BillOfMaterialEntityUsingProductAssemblyID);
			toReturn.Add(this.BillOfMaterialEntityUsingComponentID);
			toReturn.Add(this.ProductCostHistoryEntityUsingProductID);
			toReturn.Add(this.ProductDocumentEntityUsingProductID);
			toReturn.Add(this.ProductInventoryEntityUsingProductID);
			toReturn.Add(this.ProductListPriceHistoryEntityUsingProductID);
			toReturn.Add(this.ProductProductPhotoEntityUsingProductID);
			toReturn.Add(this.ProductReviewEntityUsingProductID);
			toReturn.Add(this.TransactionHistoryEntityUsingProductID);
			toReturn.Add(this.WorkOrderEntityUsingProductID);
			toReturn.Add(this.ProductVendorEntityUsingProductID);
			toReturn.Add(this.PurchaseOrderDetailEntityUsingProductID);
			toReturn.Add(this.ShoppingCartItemEntityUsingProductID);
			toReturn.Add(this.SpecialOfferProductEntityUsingProductID);
			toReturn.Add(this.ProductModelEntityUsingProductModelID);
			toReturn.Add(this.ProductSubcategoryEntityUsingProductSubcategoryID);
			toReturn.Add(this.UnitMeasureEntityUsingSizeUnitMeasureCode);
			toReturn.Add(this.UnitMeasureEntityUsingWeightUnitMeasureCode);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and BillOfMaterialEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - BillOfMaterial.ProductAssemblyID
		/// </summary>
		public virtual IEntityRelation BillOfMaterialEntityUsingProductAssemblyID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BillOfAssemblyMaterials" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, BillOfMaterialFields.ProductAssemblyID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and BillOfMaterialEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - BillOfMaterial.ComponentID
		/// </summary>
		public virtual IEntityRelation BillOfMaterialEntityUsingComponentID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BillOfComponentMaterials" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, BillOfMaterialFields.ComponentID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductCostHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - ProductCostHistory.ProductID
		/// </summary>
		public virtual IEntityRelation ProductCostHistoryEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductCostHistories" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, ProductCostHistoryFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductCostHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductDocumentEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - ProductDocument.ProductID
		/// </summary>
		public virtual IEntityRelation ProductDocumentEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductDocuments" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, ProductDocumentFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductDocumentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductInventoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - ProductInventory.ProductID
		/// </summary>
		public virtual IEntityRelation ProductInventoryEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductInventories" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, ProductInventoryFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductInventoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductListPriceHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - ProductListPriceHistory.ProductID
		/// </summary>
		public virtual IEntityRelation ProductListPriceHistoryEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductListPriceHistories" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, ProductListPriceHistoryFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductListPriceHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductProductPhotoEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - ProductProductPhoto.ProductID
		/// </summary>
		public virtual IEntityRelation ProductProductPhotoEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductProductPhotos" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, ProductProductPhotoFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductProductPhotoEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductReviewEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - ProductReview.ProductID
		/// </summary>
		public virtual IEntityRelation ProductReviewEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductReviews" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, ProductReviewFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductReviewEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and TransactionHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - TransactionHistory.ProductID
		/// </summary>
		public virtual IEntityRelation TransactionHistoryEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "TransactionHistories" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, TransactionHistoryFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TransactionHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and WorkOrderEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - WorkOrder.ProductID
		/// </summary>
		public virtual IEntityRelation WorkOrderEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrders" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, WorkOrderFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductVendorEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - ProductVendor.ProductID
		/// </summary>
		public virtual IEntityRelation ProductVendorEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductVendors" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, ProductVendorFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductVendorEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and PurchaseOrderDetailEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - PurchaseOrderDetail.ProductID
		/// </summary>
		public virtual IEntityRelation PurchaseOrderDetailEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PurchaseOrderDetails" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, PurchaseOrderDetailFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderDetailEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ShoppingCartItemEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - ShoppingCartItem.ProductID
		/// </summary>
		public virtual IEntityRelation ShoppingCartItemEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ShoppingCartItems" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, ShoppingCartItemFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ShoppingCartItemEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and SpecialOfferProductEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductID - SpecialOfferProduct.ProductID
		/// </summary>
		public virtual IEntityRelation SpecialOfferProductEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SpecialOfferProducts" , true);
				relation.AddEntityFieldPair(ProductFields.ProductID, SpecialOfferProductFields.ProductID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductModelEntity over the m:1 relation they have, using the relation between the fields:
		/// Product.ProductModelID - ProductModel.ProductModelID
		/// </summary>
		public virtual IEntityRelation ProductModelEntityUsingProductModelID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ProductModel", false);
				relation.AddEntityFieldPair(ProductModelFields.ProductModelID, ProductFields.ProductModelID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductSubcategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// Product.ProductSubcategoryID - ProductSubcategory.ProductSubcategoryID
		/// </summary>
		public virtual IEntityRelation ProductSubcategoryEntityUsingProductSubcategoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ProductSubcategory", false);
				relation.AddEntityFieldPair(ProductSubcategoryFields.ProductSubcategoryID, ProductFields.ProductSubcategoryID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductSubcategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductEntity and UnitMeasureEntity over the m:1 relation they have, using the relation between the fields:
		/// Product.SizeUnitMeasureCode - UnitMeasure.UnitMeasureCode
		/// </summary>
		public virtual IEntityRelation UnitMeasureEntityUsingSizeUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SizeUnitMeasure", false);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, ProductFields.SizeUnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductEntity and UnitMeasureEntity over the m:1 relation they have, using the relation between the fields:
		/// Product.WeightUnitMeasureCode - UnitMeasure.UnitMeasureCode
		/// </summary>
		public virtual IEntityRelation UnitMeasureEntityUsingWeightUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "WeightUnitMeasure", false);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, ProductFields.WeightUnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
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
