///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using AW.Data;
using AW.Data.FactoryClasses;
using AW.Data.DaoClasses;
using AW.Data.RelationClasses;
using AW.Data.HelperClasses;
using AW.Data.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity base class which represents the base class for the entity 'Product'.<br/><br/>
	/// 
	/// MS_Description: Products sold or used in the manfacturing of sold products.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class ProductEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.BillOfMaterialsCollection	_billOfMaterials;
		private bool	_alwaysFetchBillOfMaterials, _alreadyFetchedBillOfMaterials;
		private AW.Data.CollectionClasses.BillOfMaterialsCollection	_billOfMaterials_;
		private bool	_alwaysFetchBillOfMaterials_, _alreadyFetchedBillOfMaterials_;
		private AW.Data.CollectionClasses.ProductCostHistoryCollection	_productCostHistory;
		private bool	_alwaysFetchProductCostHistory, _alreadyFetchedProductCostHistory;
		private AW.Data.CollectionClasses.ProductDocumentCollection	_productDocument;
		private bool	_alwaysFetchProductDocument, _alreadyFetchedProductDocument;
		private AW.Data.CollectionClasses.ProductInventoryCollection	_productInventory;
		private bool	_alwaysFetchProductInventory, _alreadyFetchedProductInventory;
		private AW.Data.CollectionClasses.ProductListPriceHistoryCollection	_productListPriceHistory;
		private bool	_alwaysFetchProductListPriceHistory, _alreadyFetchedProductListPriceHistory;
		private AW.Data.CollectionClasses.ProductProductPhotoCollection	_productProductPhoto;
		private bool	_alwaysFetchProductProductPhoto, _alreadyFetchedProductProductPhoto;
		private AW.Data.CollectionClasses.ProductReviewCollection	_productReview;
		private bool	_alwaysFetchProductReview, _alreadyFetchedProductReview;
		private AW.Data.CollectionClasses.ProductVendorCollection	_productVendor;
		private bool	_alwaysFetchProductVendor, _alreadyFetchedProductVendor;
		private AW.Data.CollectionClasses.PurchaseOrderDetailCollection	_purchaseOrderDetail;
		private bool	_alwaysFetchPurchaseOrderDetail, _alreadyFetchedPurchaseOrderDetail;
		private AW.Data.CollectionClasses.ShoppingCartItemCollection	_shoppingCartItem;
		private bool	_alwaysFetchShoppingCartItem, _alreadyFetchedShoppingCartItem;
		private AW.Data.CollectionClasses.SpecialOfferProductCollection	_specialOfferProducts;
		private bool	_alwaysFetchSpecialOfferProducts, _alreadyFetchedSpecialOfferProducts;
		private AW.Data.CollectionClasses.TransactionHistoryCollection	_transactionHistory;
		private bool	_alwaysFetchTransactionHistory, _alreadyFetchedTransactionHistory;
		private AW.Data.CollectionClasses.WorkOrderCollection	_workOrder;
		private bool	_alwaysFetchWorkOrder, _alreadyFetchedWorkOrder;
		private AW.Data.CollectionClasses.DocumentCollection _documentCollectionViaProductDocument;
		private bool	_alwaysFetchDocumentCollectionViaProductDocument, _alreadyFetchedDocumentCollectionViaProductDocument;
		private AW.Data.CollectionClasses.LocationCollection _locationCollectionViaProductInventory;
		private bool	_alwaysFetchLocationCollectionViaProductInventory, _alreadyFetchedLocationCollectionViaProductInventory;
		private AW.Data.CollectionClasses.ProductPhotoCollection _productPhotoCollectionViaProductProductPhoto;
		private bool	_alwaysFetchProductPhotoCollectionViaProductProductPhoto, _alreadyFetchedProductPhotoCollectionViaProductProductPhoto;
		private AW.Data.CollectionClasses.PurchaseOrderHeaderCollection _purchaseOrderHeaderCollectionViaPurchaseOrderDetail;
		private bool	_alwaysFetchPurchaseOrderHeaderCollectionViaPurchaseOrderDetail, _alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail;
		private AW.Data.CollectionClasses.ScrapReasonCollection _scrapReasonCollectionViaWorkOrder;
		private bool	_alwaysFetchScrapReasonCollectionViaWorkOrder, _alreadyFetchedScrapReasonCollectionViaWorkOrder;
		private AW.Data.CollectionClasses.SpecialOfferCollection _specialOfferCollectionViaSpecialOfferProduct;
		private bool	_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct, _alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct;
		private AW.Data.CollectionClasses.UnitMeasureCollection _unitMeasureCollectionViaBillOfMaterials;
		private bool	_alwaysFetchUnitMeasureCollectionViaBillOfMaterials, _alreadyFetchedUnitMeasureCollectionViaBillOfMaterials;
		private AW.Data.CollectionClasses.UnitMeasureCollection _unitMeasureCollectionViaBillOfMaterials_;
		private bool	_alwaysFetchUnitMeasureCollectionViaBillOfMaterials_, _alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_;
		private AW.Data.CollectionClasses.UnitMeasureCollection _unitMeasureCollectionViaProductVendor;
		private bool	_alwaysFetchUnitMeasureCollectionViaProductVendor, _alreadyFetchedUnitMeasureCollectionViaProductVendor;
		private AW.Data.CollectionClasses.VendorCollection _vendorCollectionViaProductVendor;
		private bool	_alwaysFetchVendorCollectionViaProductVendor, _alreadyFetchedVendorCollectionViaProductVendor;
		private ProductModelEntity _productModel;
		private bool	_alwaysFetchProductModel, _alreadyFetchedProductModel, _productModelReturnsNewIfNotFound;
		private ProductSubcategoryEntity _productSubcategory;
		private bool	_alwaysFetchProductSubcategory, _alreadyFetchedProductSubcategory, _productSubcategoryReturnsNewIfNotFound;
		private UnitMeasureEntity _unitMeasure;
		private bool	_alwaysFetchUnitMeasure, _alreadyFetchedUnitMeasure, _unitMeasureReturnsNewIfNotFound;
		private UnitMeasureEntity _unitMeasure_;
		private bool	_alwaysFetchUnitMeasure_, _alreadyFetchedUnitMeasure_, _unitMeasure_ReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductModel</summary>
			public static readonly string ProductModel = "ProductModel";
			/// <summary>Member name ProductSubcategory</summary>
			public static readonly string ProductSubcategory = "ProductSubcategory";
			/// <summary>Member name UnitMeasure</summary>
			public static readonly string UnitMeasure = "UnitMeasure";
			/// <summary>Member name UnitMeasure_</summary>
			public static readonly string UnitMeasure_ = "UnitMeasure_";
			/// <summary>Member name BillOfMaterials</summary>
			public static readonly string BillOfMaterials = "BillOfMaterials";
			/// <summary>Member name BillOfMaterials_</summary>
			public static readonly string BillOfMaterials_ = "BillOfMaterials_";
			/// <summary>Member name ProductCostHistory</summary>
			public static readonly string ProductCostHistory = "ProductCostHistory";
			/// <summary>Member name ProductDocument</summary>
			public static readonly string ProductDocument = "ProductDocument";
			/// <summary>Member name ProductInventory</summary>
			public static readonly string ProductInventory = "ProductInventory";
			/// <summary>Member name ProductListPriceHistory</summary>
			public static readonly string ProductListPriceHistory = "ProductListPriceHistory";
			/// <summary>Member name ProductProductPhoto</summary>
			public static readonly string ProductProductPhoto = "ProductProductPhoto";
			/// <summary>Member name ProductReview</summary>
			public static readonly string ProductReview = "ProductReview";
			/// <summary>Member name ProductVendor</summary>
			public static readonly string ProductVendor = "ProductVendor";
			/// <summary>Member name PurchaseOrderDetail</summary>
			public static readonly string PurchaseOrderDetail = "PurchaseOrderDetail";
			/// <summary>Member name ShoppingCartItem</summary>
			public static readonly string ShoppingCartItem = "ShoppingCartItem";
			/// <summary>Member name SpecialOfferProducts</summary>
			public static readonly string SpecialOfferProducts = "SpecialOfferProducts";
			/// <summary>Member name TransactionHistory</summary>
			public static readonly string TransactionHistory = "TransactionHistory";
			/// <summary>Member name WorkOrder</summary>
			public static readonly string WorkOrder = "WorkOrder";
			/// <summary>Member name DocumentCollectionViaProductDocument</summary>
			public static readonly string DocumentCollectionViaProductDocument = "DocumentCollectionViaProductDocument";
			/// <summary>Member name LocationCollectionViaProductInventory</summary>
			public static readonly string LocationCollectionViaProductInventory = "LocationCollectionViaProductInventory";
			/// <summary>Member name ProductPhotoCollectionViaProductProductPhoto</summary>
			public static readonly string ProductPhotoCollectionViaProductProductPhoto = "ProductPhotoCollectionViaProductProductPhoto";
			/// <summary>Member name PurchaseOrderHeaderCollectionViaPurchaseOrderDetail</summary>
			public static readonly string PurchaseOrderHeaderCollectionViaPurchaseOrderDetail = "PurchaseOrderHeaderCollectionViaPurchaseOrderDetail";
			/// <summary>Member name ScrapReasonCollectionViaWorkOrder</summary>
			public static readonly string ScrapReasonCollectionViaWorkOrder = "ScrapReasonCollectionViaWorkOrder";
			/// <summary>Member name SpecialOfferCollectionViaSpecialOfferProduct</summary>
			public static readonly string SpecialOfferCollectionViaSpecialOfferProduct = "SpecialOfferCollectionViaSpecialOfferProduct";
			/// <summary>Member name UnitMeasureCollectionViaBillOfMaterials</summary>
			public static readonly string UnitMeasureCollectionViaBillOfMaterials = "UnitMeasureCollectionViaBillOfMaterials";
			/// <summary>Member name UnitMeasureCollectionViaBillOfMaterials_</summary>
			public static readonly string UnitMeasureCollectionViaBillOfMaterials_ = "UnitMeasureCollectionViaBillOfMaterials_";
			/// <summary>Member name UnitMeasureCollectionViaProductVendor</summary>
			public static readonly string UnitMeasureCollectionViaProductVendor = "UnitMeasureCollectionViaProductVendor";
			/// <summary>Member name VendorCollectionViaProductVendor</summary>
			public static readonly string VendorCollectionViaProductVendor = "VendorCollectionViaProductVendor";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		public ProductEntityBase(System.Int32 productID)
		{
			InitClassFetch(productID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductEntityBase(System.Int32 productID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(productID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntityBase(System.Int32 productID, IValidator validator)
		{
			InitClassFetch(productID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_billOfMaterials = (AW.Data.CollectionClasses.BillOfMaterialsCollection)info.GetValue("_billOfMaterials", typeof(AW.Data.CollectionClasses.BillOfMaterialsCollection));
			_alwaysFetchBillOfMaterials = info.GetBoolean("_alwaysFetchBillOfMaterials");
			_alreadyFetchedBillOfMaterials = info.GetBoolean("_alreadyFetchedBillOfMaterials");
			_billOfMaterials_ = (AW.Data.CollectionClasses.BillOfMaterialsCollection)info.GetValue("_billOfMaterials_", typeof(AW.Data.CollectionClasses.BillOfMaterialsCollection));
			_alwaysFetchBillOfMaterials_ = info.GetBoolean("_alwaysFetchBillOfMaterials_");
			_alreadyFetchedBillOfMaterials_ = info.GetBoolean("_alreadyFetchedBillOfMaterials_");
			_productCostHistory = (AW.Data.CollectionClasses.ProductCostHistoryCollection)info.GetValue("_productCostHistory", typeof(AW.Data.CollectionClasses.ProductCostHistoryCollection));
			_alwaysFetchProductCostHistory = info.GetBoolean("_alwaysFetchProductCostHistory");
			_alreadyFetchedProductCostHistory = info.GetBoolean("_alreadyFetchedProductCostHistory");
			_productDocument = (AW.Data.CollectionClasses.ProductDocumentCollection)info.GetValue("_productDocument", typeof(AW.Data.CollectionClasses.ProductDocumentCollection));
			_alwaysFetchProductDocument = info.GetBoolean("_alwaysFetchProductDocument");
			_alreadyFetchedProductDocument = info.GetBoolean("_alreadyFetchedProductDocument");
			_productInventory = (AW.Data.CollectionClasses.ProductInventoryCollection)info.GetValue("_productInventory", typeof(AW.Data.CollectionClasses.ProductInventoryCollection));
			_alwaysFetchProductInventory = info.GetBoolean("_alwaysFetchProductInventory");
			_alreadyFetchedProductInventory = info.GetBoolean("_alreadyFetchedProductInventory");
			_productListPriceHistory = (AW.Data.CollectionClasses.ProductListPriceHistoryCollection)info.GetValue("_productListPriceHistory", typeof(AW.Data.CollectionClasses.ProductListPriceHistoryCollection));
			_alwaysFetchProductListPriceHistory = info.GetBoolean("_alwaysFetchProductListPriceHistory");
			_alreadyFetchedProductListPriceHistory = info.GetBoolean("_alreadyFetchedProductListPriceHistory");
			_productProductPhoto = (AW.Data.CollectionClasses.ProductProductPhotoCollection)info.GetValue("_productProductPhoto", typeof(AW.Data.CollectionClasses.ProductProductPhotoCollection));
			_alwaysFetchProductProductPhoto = info.GetBoolean("_alwaysFetchProductProductPhoto");
			_alreadyFetchedProductProductPhoto = info.GetBoolean("_alreadyFetchedProductProductPhoto");
			_productReview = (AW.Data.CollectionClasses.ProductReviewCollection)info.GetValue("_productReview", typeof(AW.Data.CollectionClasses.ProductReviewCollection));
			_alwaysFetchProductReview = info.GetBoolean("_alwaysFetchProductReview");
			_alreadyFetchedProductReview = info.GetBoolean("_alreadyFetchedProductReview");
			_productVendor = (AW.Data.CollectionClasses.ProductVendorCollection)info.GetValue("_productVendor", typeof(AW.Data.CollectionClasses.ProductVendorCollection));
			_alwaysFetchProductVendor = info.GetBoolean("_alwaysFetchProductVendor");
			_alreadyFetchedProductVendor = info.GetBoolean("_alreadyFetchedProductVendor");
			_purchaseOrderDetail = (AW.Data.CollectionClasses.PurchaseOrderDetailCollection)info.GetValue("_purchaseOrderDetail", typeof(AW.Data.CollectionClasses.PurchaseOrderDetailCollection));
			_alwaysFetchPurchaseOrderDetail = info.GetBoolean("_alwaysFetchPurchaseOrderDetail");
			_alreadyFetchedPurchaseOrderDetail = info.GetBoolean("_alreadyFetchedPurchaseOrderDetail");
			_shoppingCartItem = (AW.Data.CollectionClasses.ShoppingCartItemCollection)info.GetValue("_shoppingCartItem", typeof(AW.Data.CollectionClasses.ShoppingCartItemCollection));
			_alwaysFetchShoppingCartItem = info.GetBoolean("_alwaysFetchShoppingCartItem");
			_alreadyFetchedShoppingCartItem = info.GetBoolean("_alreadyFetchedShoppingCartItem");
			_specialOfferProducts = (AW.Data.CollectionClasses.SpecialOfferProductCollection)info.GetValue("_specialOfferProducts", typeof(AW.Data.CollectionClasses.SpecialOfferProductCollection));
			_alwaysFetchSpecialOfferProducts = info.GetBoolean("_alwaysFetchSpecialOfferProducts");
			_alreadyFetchedSpecialOfferProducts = info.GetBoolean("_alreadyFetchedSpecialOfferProducts");
			_transactionHistory = (AW.Data.CollectionClasses.TransactionHistoryCollection)info.GetValue("_transactionHistory", typeof(AW.Data.CollectionClasses.TransactionHistoryCollection));
			_alwaysFetchTransactionHistory = info.GetBoolean("_alwaysFetchTransactionHistory");
			_alreadyFetchedTransactionHistory = info.GetBoolean("_alreadyFetchedTransactionHistory");
			_workOrder = (AW.Data.CollectionClasses.WorkOrderCollection)info.GetValue("_workOrder", typeof(AW.Data.CollectionClasses.WorkOrderCollection));
			_alwaysFetchWorkOrder = info.GetBoolean("_alwaysFetchWorkOrder");
			_alreadyFetchedWorkOrder = info.GetBoolean("_alreadyFetchedWorkOrder");
			_documentCollectionViaProductDocument = (AW.Data.CollectionClasses.DocumentCollection)info.GetValue("_documentCollectionViaProductDocument", typeof(AW.Data.CollectionClasses.DocumentCollection));
			_alwaysFetchDocumentCollectionViaProductDocument = info.GetBoolean("_alwaysFetchDocumentCollectionViaProductDocument");
			_alreadyFetchedDocumentCollectionViaProductDocument = info.GetBoolean("_alreadyFetchedDocumentCollectionViaProductDocument");
			_locationCollectionViaProductInventory = (AW.Data.CollectionClasses.LocationCollection)info.GetValue("_locationCollectionViaProductInventory", typeof(AW.Data.CollectionClasses.LocationCollection));
			_alwaysFetchLocationCollectionViaProductInventory = info.GetBoolean("_alwaysFetchLocationCollectionViaProductInventory");
			_alreadyFetchedLocationCollectionViaProductInventory = info.GetBoolean("_alreadyFetchedLocationCollectionViaProductInventory");
			_productPhotoCollectionViaProductProductPhoto = (AW.Data.CollectionClasses.ProductPhotoCollection)info.GetValue("_productPhotoCollectionViaProductProductPhoto", typeof(AW.Data.CollectionClasses.ProductPhotoCollection));
			_alwaysFetchProductPhotoCollectionViaProductProductPhoto = info.GetBoolean("_alwaysFetchProductPhotoCollectionViaProductProductPhoto");
			_alreadyFetchedProductPhotoCollectionViaProductProductPhoto = info.GetBoolean("_alreadyFetchedProductPhotoCollectionViaProductProductPhoto");
			_purchaseOrderHeaderCollectionViaPurchaseOrderDetail = (AW.Data.CollectionClasses.PurchaseOrderHeaderCollection)info.GetValue("_purchaseOrderHeaderCollectionViaPurchaseOrderDetail", typeof(AW.Data.CollectionClasses.PurchaseOrderHeaderCollection));
			_alwaysFetchPurchaseOrderHeaderCollectionViaPurchaseOrderDetail = info.GetBoolean("_alwaysFetchPurchaseOrderHeaderCollectionViaPurchaseOrderDetail");
			_alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail = info.GetBoolean("_alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail");
			_scrapReasonCollectionViaWorkOrder = (AW.Data.CollectionClasses.ScrapReasonCollection)info.GetValue("_scrapReasonCollectionViaWorkOrder", typeof(AW.Data.CollectionClasses.ScrapReasonCollection));
			_alwaysFetchScrapReasonCollectionViaWorkOrder = info.GetBoolean("_alwaysFetchScrapReasonCollectionViaWorkOrder");
			_alreadyFetchedScrapReasonCollectionViaWorkOrder = info.GetBoolean("_alreadyFetchedScrapReasonCollectionViaWorkOrder");
			_specialOfferCollectionViaSpecialOfferProduct = (AW.Data.CollectionClasses.SpecialOfferCollection)info.GetValue("_specialOfferCollectionViaSpecialOfferProduct", typeof(AW.Data.CollectionClasses.SpecialOfferCollection));
			_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct = info.GetBoolean("_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct");
			_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = info.GetBoolean("_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct");
			_unitMeasureCollectionViaBillOfMaterials = (AW.Data.CollectionClasses.UnitMeasureCollection)info.GetValue("_unitMeasureCollectionViaBillOfMaterials", typeof(AW.Data.CollectionClasses.UnitMeasureCollection));
			_alwaysFetchUnitMeasureCollectionViaBillOfMaterials = info.GetBoolean("_alwaysFetchUnitMeasureCollectionViaBillOfMaterials");
			_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials = info.GetBoolean("_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials");
			_unitMeasureCollectionViaBillOfMaterials_ = (AW.Data.CollectionClasses.UnitMeasureCollection)info.GetValue("_unitMeasureCollectionViaBillOfMaterials_", typeof(AW.Data.CollectionClasses.UnitMeasureCollection));
			_alwaysFetchUnitMeasureCollectionViaBillOfMaterials_ = info.GetBoolean("_alwaysFetchUnitMeasureCollectionViaBillOfMaterials_");
			_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_ = info.GetBoolean("_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_");
			_unitMeasureCollectionViaProductVendor = (AW.Data.CollectionClasses.UnitMeasureCollection)info.GetValue("_unitMeasureCollectionViaProductVendor", typeof(AW.Data.CollectionClasses.UnitMeasureCollection));
			_alwaysFetchUnitMeasureCollectionViaProductVendor = info.GetBoolean("_alwaysFetchUnitMeasureCollectionViaProductVendor");
			_alreadyFetchedUnitMeasureCollectionViaProductVendor = info.GetBoolean("_alreadyFetchedUnitMeasureCollectionViaProductVendor");
			_vendorCollectionViaProductVendor = (AW.Data.CollectionClasses.VendorCollection)info.GetValue("_vendorCollectionViaProductVendor", typeof(AW.Data.CollectionClasses.VendorCollection));
			_alwaysFetchVendorCollectionViaProductVendor = info.GetBoolean("_alwaysFetchVendorCollectionViaProductVendor");
			_alreadyFetchedVendorCollectionViaProductVendor = info.GetBoolean("_alreadyFetchedVendorCollectionViaProductVendor");
			_productModel = (ProductModelEntity)info.GetValue("_productModel", typeof(ProductModelEntity));
			if(_productModel!=null)
			{
				_productModel.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productModelReturnsNewIfNotFound = info.GetBoolean("_productModelReturnsNewIfNotFound");
			_alwaysFetchProductModel = info.GetBoolean("_alwaysFetchProductModel");
			_alreadyFetchedProductModel = info.GetBoolean("_alreadyFetchedProductModel");
			_productSubcategory = (ProductSubcategoryEntity)info.GetValue("_productSubcategory", typeof(ProductSubcategoryEntity));
			if(_productSubcategory!=null)
			{
				_productSubcategory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productSubcategoryReturnsNewIfNotFound = info.GetBoolean("_productSubcategoryReturnsNewIfNotFound");
			_alwaysFetchProductSubcategory = info.GetBoolean("_alwaysFetchProductSubcategory");
			_alreadyFetchedProductSubcategory = info.GetBoolean("_alreadyFetchedProductSubcategory");
			_unitMeasure = (UnitMeasureEntity)info.GetValue("_unitMeasure", typeof(UnitMeasureEntity));
			if(_unitMeasure!=null)
			{
				_unitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_unitMeasureReturnsNewIfNotFound = info.GetBoolean("_unitMeasureReturnsNewIfNotFound");
			_alwaysFetchUnitMeasure = info.GetBoolean("_alwaysFetchUnitMeasure");
			_alreadyFetchedUnitMeasure = info.GetBoolean("_alreadyFetchedUnitMeasure");
			_unitMeasure_ = (UnitMeasureEntity)info.GetValue("_unitMeasure_", typeof(UnitMeasureEntity));
			if(_unitMeasure_!=null)
			{
				_unitMeasure_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_unitMeasure_ReturnsNewIfNotFound = info.GetBoolean("_unitMeasure_ReturnsNewIfNotFound");
			_alwaysFetchUnitMeasure_ = info.GetBoolean("_alwaysFetchUnitMeasure_");
			_alreadyFetchedUnitMeasure_ = info.GetBoolean("_alreadyFetchedUnitMeasure_");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ProductFieldIndex)fieldIndex)
			{
				case ProductFieldIndex.SizeUnitMeasureCode:
					DesetupSyncUnitMeasure(true, false);
					_alreadyFetchedUnitMeasure = false;
					break;
				case ProductFieldIndex.WeightUnitMeasureCode:
					DesetupSyncUnitMeasure_(true, false);
					_alreadyFetchedUnitMeasure_ = false;
					break;
				case ProductFieldIndex.ProductSubcategoryID:
					DesetupSyncProductSubcategory(true, false);
					_alreadyFetchedProductSubcategory = false;
					break;
				case ProductFieldIndex.ProductModelID:
					DesetupSyncProductModel(true, false);
					_alreadyFetchedProductModel = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}
		
		/// <summary>Gets the inheritance info provider instance of the project this entity instance is located in. </summary>
		/// <returns>ready to use inheritance info provider instance.</returns>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedBillOfMaterials = (_billOfMaterials.Count > 0);
			_alreadyFetchedBillOfMaterials_ = (_billOfMaterials_.Count > 0);
			_alreadyFetchedProductCostHistory = (_productCostHistory.Count > 0);
			_alreadyFetchedProductDocument = (_productDocument.Count > 0);
			_alreadyFetchedProductInventory = (_productInventory.Count > 0);
			_alreadyFetchedProductListPriceHistory = (_productListPriceHistory.Count > 0);
			_alreadyFetchedProductProductPhoto = (_productProductPhoto.Count > 0);
			_alreadyFetchedProductReview = (_productReview.Count > 0);
			_alreadyFetchedProductVendor = (_productVendor.Count > 0);
			_alreadyFetchedPurchaseOrderDetail = (_purchaseOrderDetail.Count > 0);
			_alreadyFetchedShoppingCartItem = (_shoppingCartItem.Count > 0);
			_alreadyFetchedSpecialOfferProducts = (_specialOfferProducts.Count > 0);
			_alreadyFetchedTransactionHistory = (_transactionHistory.Count > 0);
			_alreadyFetchedWorkOrder = (_workOrder.Count > 0);
			_alreadyFetchedDocumentCollectionViaProductDocument = (_documentCollectionViaProductDocument.Count > 0);
			_alreadyFetchedLocationCollectionViaProductInventory = (_locationCollectionViaProductInventory.Count > 0);
			_alreadyFetchedProductPhotoCollectionViaProductProductPhoto = (_productPhotoCollectionViaProductProductPhoto.Count > 0);
			_alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail = (_purchaseOrderHeaderCollectionViaPurchaseOrderDetail.Count > 0);
			_alreadyFetchedScrapReasonCollectionViaWorkOrder = (_scrapReasonCollectionViaWorkOrder.Count > 0);
			_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = (_specialOfferCollectionViaSpecialOfferProduct.Count > 0);
			_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials = (_unitMeasureCollectionViaBillOfMaterials.Count > 0);
			_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_ = (_unitMeasureCollectionViaBillOfMaterials_.Count > 0);
			_alreadyFetchedUnitMeasureCollectionViaProductVendor = (_unitMeasureCollectionViaProductVendor.Count > 0);
			_alreadyFetchedVendorCollectionViaProductVendor = (_vendorCollectionViaProductVendor.Count > 0);
			_alreadyFetchedProductModel = (_productModel != null);
			_alreadyFetchedProductSubcategory = (_productSubcategory != null);
			_alreadyFetchedUnitMeasure = (_unitMeasure != null);
			_alreadyFetchedUnitMeasure_ = (_unitMeasure_ != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ProductEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ProductModel":
					toReturn.Add(ProductEntity.Relations.ProductModelEntityUsingProductModelID);
					break;
				case "ProductSubcategory":
					toReturn.Add(ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryID);
					break;
				case "UnitMeasure":
					toReturn.Add(ProductEntity.Relations.UnitMeasureEntityUsingSizeUnitMeasureCode);
					break;
				case "UnitMeasure_":
					toReturn.Add(ProductEntity.Relations.UnitMeasureEntityUsingWeightUnitMeasureCode);
					break;
				case "BillOfMaterials":
					toReturn.Add(ProductEntity.Relations.BillOfMaterialsEntityUsingComponentID);
					break;
				case "BillOfMaterials_":
					toReturn.Add(ProductEntity.Relations.BillOfMaterialsEntityUsingProductAssemblyID);
					break;
				case "ProductCostHistory":
					toReturn.Add(ProductEntity.Relations.ProductCostHistoryEntityUsingProductID);
					break;
				case "ProductDocument":
					toReturn.Add(ProductEntity.Relations.ProductDocumentEntityUsingProductID);
					break;
				case "ProductInventory":
					toReturn.Add(ProductEntity.Relations.ProductInventoryEntityUsingProductID);
					break;
				case "ProductListPriceHistory":
					toReturn.Add(ProductEntity.Relations.ProductListPriceHistoryEntityUsingProductID);
					break;
				case "ProductProductPhoto":
					toReturn.Add(ProductEntity.Relations.ProductProductPhotoEntityUsingProductID);
					break;
				case "ProductReview":
					toReturn.Add(ProductEntity.Relations.ProductReviewEntityUsingProductID);
					break;
				case "ProductVendor":
					toReturn.Add(ProductEntity.Relations.ProductVendorEntityUsingProductID);
					break;
				case "PurchaseOrderDetail":
					toReturn.Add(ProductEntity.Relations.PurchaseOrderDetailEntityUsingProductID);
					break;
				case "ShoppingCartItem":
					toReturn.Add(ProductEntity.Relations.ShoppingCartItemEntityUsingProductID);
					break;
				case "SpecialOfferProducts":
					toReturn.Add(ProductEntity.Relations.SpecialOfferProductEntityUsingProductID);
					break;
				case "TransactionHistory":
					toReturn.Add(ProductEntity.Relations.TransactionHistoryEntityUsingProductID);
					break;
				case "WorkOrder":
					toReturn.Add(ProductEntity.Relations.WorkOrderEntityUsingProductID);
					break;
				case "DocumentCollectionViaProductDocument":
					toReturn.Add(ProductEntity.Relations.ProductDocumentEntityUsingProductID, "ProductEntity__", "ProductDocument_", JoinHint.None);
					toReturn.Add(ProductDocumentEntity.Relations.DocumentEntityUsingDocumentID, "ProductDocument_", string.Empty, JoinHint.None);
					break;
				case "LocationCollectionViaProductInventory":
					toReturn.Add(ProductEntity.Relations.ProductInventoryEntityUsingProductID, "ProductEntity__", "ProductInventory_", JoinHint.None);
					toReturn.Add(ProductInventoryEntity.Relations.LocationEntityUsingLocationID, "ProductInventory_", string.Empty, JoinHint.None);
					break;
				case "ProductPhotoCollectionViaProductProductPhoto":
					toReturn.Add(ProductEntity.Relations.ProductProductPhotoEntityUsingProductID, "ProductEntity__", "ProductProductPhoto_", JoinHint.None);
					toReturn.Add(ProductProductPhotoEntity.Relations.ProductPhotoEntityUsingProductPhotoID, "ProductProductPhoto_", string.Empty, JoinHint.None);
					break;
				case "PurchaseOrderHeaderCollectionViaPurchaseOrderDetail":
					toReturn.Add(ProductEntity.Relations.PurchaseOrderDetailEntityUsingProductID, "ProductEntity__", "PurchaseOrderDetail_", JoinHint.None);
					toReturn.Add(PurchaseOrderDetailEntity.Relations.PurchaseOrderHeaderEntityUsingPurchaseOrderID, "PurchaseOrderDetail_", string.Empty, JoinHint.None);
					break;
				case "ScrapReasonCollectionViaWorkOrder":
					toReturn.Add(ProductEntity.Relations.WorkOrderEntityUsingProductID, "ProductEntity__", "WorkOrder_", JoinHint.None);
					toReturn.Add(WorkOrderEntity.Relations.ScrapReasonEntityUsingScrapReasonID, "WorkOrder_", string.Empty, JoinHint.None);
					break;
				case "SpecialOfferCollectionViaSpecialOfferProduct":
					toReturn.Add(ProductEntity.Relations.SpecialOfferProductEntityUsingProductID, "ProductEntity__", "SpecialOfferProduct_", JoinHint.None);
					toReturn.Add(SpecialOfferProductEntity.Relations.SpecialOfferEntityUsingSpecialOfferID, "SpecialOfferProduct_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaBillOfMaterials":
					toReturn.Add(ProductEntity.Relations.BillOfMaterialsEntityUsingComponentID, "ProductEntity__", "BillOfMaterials_", JoinHint.None);
					toReturn.Add(BillOfMaterialsEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode, "BillOfMaterials_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaBillOfMaterials_":
					toReturn.Add(ProductEntity.Relations.BillOfMaterialsEntityUsingProductAssemblyID, "ProductEntity__", "BillOfMaterials_", JoinHint.None);
					toReturn.Add(BillOfMaterialsEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode, "BillOfMaterials_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaProductVendor":
					toReturn.Add(ProductEntity.Relations.ProductVendorEntityUsingProductID, "ProductEntity__", "ProductVendor_", JoinHint.None);
					toReturn.Add(ProductVendorEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode, "ProductVendor_", string.Empty, JoinHint.None);
					break;
				case "VendorCollectionViaProductVendor":
					toReturn.Add(ProductEntity.Relations.ProductVendorEntityUsingProductID, "ProductEntity__", "ProductVendor_", JoinHint.None);
					toReturn.Add(ProductVendorEntity.Relations.VendorEntityUsingVendorID, "ProductVendor_", string.Empty, JoinHint.None);
					break;

				default:

					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_billOfMaterials", (!this.MarkedForDeletion?_billOfMaterials:null));
			info.AddValue("_alwaysFetchBillOfMaterials", _alwaysFetchBillOfMaterials);
			info.AddValue("_alreadyFetchedBillOfMaterials", _alreadyFetchedBillOfMaterials);
			info.AddValue("_billOfMaterials_", (!this.MarkedForDeletion?_billOfMaterials_:null));
			info.AddValue("_alwaysFetchBillOfMaterials_", _alwaysFetchBillOfMaterials_);
			info.AddValue("_alreadyFetchedBillOfMaterials_", _alreadyFetchedBillOfMaterials_);
			info.AddValue("_productCostHistory", (!this.MarkedForDeletion?_productCostHistory:null));
			info.AddValue("_alwaysFetchProductCostHistory", _alwaysFetchProductCostHistory);
			info.AddValue("_alreadyFetchedProductCostHistory", _alreadyFetchedProductCostHistory);
			info.AddValue("_productDocument", (!this.MarkedForDeletion?_productDocument:null));
			info.AddValue("_alwaysFetchProductDocument", _alwaysFetchProductDocument);
			info.AddValue("_alreadyFetchedProductDocument", _alreadyFetchedProductDocument);
			info.AddValue("_productInventory", (!this.MarkedForDeletion?_productInventory:null));
			info.AddValue("_alwaysFetchProductInventory", _alwaysFetchProductInventory);
			info.AddValue("_alreadyFetchedProductInventory", _alreadyFetchedProductInventory);
			info.AddValue("_productListPriceHistory", (!this.MarkedForDeletion?_productListPriceHistory:null));
			info.AddValue("_alwaysFetchProductListPriceHistory", _alwaysFetchProductListPriceHistory);
			info.AddValue("_alreadyFetchedProductListPriceHistory", _alreadyFetchedProductListPriceHistory);
			info.AddValue("_productProductPhoto", (!this.MarkedForDeletion?_productProductPhoto:null));
			info.AddValue("_alwaysFetchProductProductPhoto", _alwaysFetchProductProductPhoto);
			info.AddValue("_alreadyFetchedProductProductPhoto", _alreadyFetchedProductProductPhoto);
			info.AddValue("_productReview", (!this.MarkedForDeletion?_productReview:null));
			info.AddValue("_alwaysFetchProductReview", _alwaysFetchProductReview);
			info.AddValue("_alreadyFetchedProductReview", _alreadyFetchedProductReview);
			info.AddValue("_productVendor", (!this.MarkedForDeletion?_productVendor:null));
			info.AddValue("_alwaysFetchProductVendor", _alwaysFetchProductVendor);
			info.AddValue("_alreadyFetchedProductVendor", _alreadyFetchedProductVendor);
			info.AddValue("_purchaseOrderDetail", (!this.MarkedForDeletion?_purchaseOrderDetail:null));
			info.AddValue("_alwaysFetchPurchaseOrderDetail", _alwaysFetchPurchaseOrderDetail);
			info.AddValue("_alreadyFetchedPurchaseOrderDetail", _alreadyFetchedPurchaseOrderDetail);
			info.AddValue("_shoppingCartItem", (!this.MarkedForDeletion?_shoppingCartItem:null));
			info.AddValue("_alwaysFetchShoppingCartItem", _alwaysFetchShoppingCartItem);
			info.AddValue("_alreadyFetchedShoppingCartItem", _alreadyFetchedShoppingCartItem);
			info.AddValue("_specialOfferProducts", (!this.MarkedForDeletion?_specialOfferProducts:null));
			info.AddValue("_alwaysFetchSpecialOfferProducts", _alwaysFetchSpecialOfferProducts);
			info.AddValue("_alreadyFetchedSpecialOfferProducts", _alreadyFetchedSpecialOfferProducts);
			info.AddValue("_transactionHistory", (!this.MarkedForDeletion?_transactionHistory:null));
			info.AddValue("_alwaysFetchTransactionHistory", _alwaysFetchTransactionHistory);
			info.AddValue("_alreadyFetchedTransactionHistory", _alreadyFetchedTransactionHistory);
			info.AddValue("_workOrder", (!this.MarkedForDeletion?_workOrder:null));
			info.AddValue("_alwaysFetchWorkOrder", _alwaysFetchWorkOrder);
			info.AddValue("_alreadyFetchedWorkOrder", _alreadyFetchedWorkOrder);
			info.AddValue("_documentCollectionViaProductDocument", (!this.MarkedForDeletion?_documentCollectionViaProductDocument:null));
			info.AddValue("_alwaysFetchDocumentCollectionViaProductDocument", _alwaysFetchDocumentCollectionViaProductDocument);
			info.AddValue("_alreadyFetchedDocumentCollectionViaProductDocument", _alreadyFetchedDocumentCollectionViaProductDocument);
			info.AddValue("_locationCollectionViaProductInventory", (!this.MarkedForDeletion?_locationCollectionViaProductInventory:null));
			info.AddValue("_alwaysFetchLocationCollectionViaProductInventory", _alwaysFetchLocationCollectionViaProductInventory);
			info.AddValue("_alreadyFetchedLocationCollectionViaProductInventory", _alreadyFetchedLocationCollectionViaProductInventory);
			info.AddValue("_productPhotoCollectionViaProductProductPhoto", (!this.MarkedForDeletion?_productPhotoCollectionViaProductProductPhoto:null));
			info.AddValue("_alwaysFetchProductPhotoCollectionViaProductProductPhoto", _alwaysFetchProductPhotoCollectionViaProductProductPhoto);
			info.AddValue("_alreadyFetchedProductPhotoCollectionViaProductProductPhoto", _alreadyFetchedProductPhotoCollectionViaProductProductPhoto);
			info.AddValue("_purchaseOrderHeaderCollectionViaPurchaseOrderDetail", (!this.MarkedForDeletion?_purchaseOrderHeaderCollectionViaPurchaseOrderDetail:null));
			info.AddValue("_alwaysFetchPurchaseOrderHeaderCollectionViaPurchaseOrderDetail", _alwaysFetchPurchaseOrderHeaderCollectionViaPurchaseOrderDetail);
			info.AddValue("_alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail", _alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail);
			info.AddValue("_scrapReasonCollectionViaWorkOrder", (!this.MarkedForDeletion?_scrapReasonCollectionViaWorkOrder:null));
			info.AddValue("_alwaysFetchScrapReasonCollectionViaWorkOrder", _alwaysFetchScrapReasonCollectionViaWorkOrder);
			info.AddValue("_alreadyFetchedScrapReasonCollectionViaWorkOrder", _alreadyFetchedScrapReasonCollectionViaWorkOrder);
			info.AddValue("_specialOfferCollectionViaSpecialOfferProduct", (!this.MarkedForDeletion?_specialOfferCollectionViaSpecialOfferProduct:null));
			info.AddValue("_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct", _alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct);
			info.AddValue("_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct", _alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct);
			info.AddValue("_unitMeasureCollectionViaBillOfMaterials", (!this.MarkedForDeletion?_unitMeasureCollectionViaBillOfMaterials:null));
			info.AddValue("_alwaysFetchUnitMeasureCollectionViaBillOfMaterials", _alwaysFetchUnitMeasureCollectionViaBillOfMaterials);
			info.AddValue("_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials", _alreadyFetchedUnitMeasureCollectionViaBillOfMaterials);
			info.AddValue("_unitMeasureCollectionViaBillOfMaterials_", (!this.MarkedForDeletion?_unitMeasureCollectionViaBillOfMaterials_:null));
			info.AddValue("_alwaysFetchUnitMeasureCollectionViaBillOfMaterials_", _alwaysFetchUnitMeasureCollectionViaBillOfMaterials_);
			info.AddValue("_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_", _alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_);
			info.AddValue("_unitMeasureCollectionViaProductVendor", (!this.MarkedForDeletion?_unitMeasureCollectionViaProductVendor:null));
			info.AddValue("_alwaysFetchUnitMeasureCollectionViaProductVendor", _alwaysFetchUnitMeasureCollectionViaProductVendor);
			info.AddValue("_alreadyFetchedUnitMeasureCollectionViaProductVendor", _alreadyFetchedUnitMeasureCollectionViaProductVendor);
			info.AddValue("_vendorCollectionViaProductVendor", (!this.MarkedForDeletion?_vendorCollectionViaProductVendor:null));
			info.AddValue("_alwaysFetchVendorCollectionViaProductVendor", _alwaysFetchVendorCollectionViaProductVendor);
			info.AddValue("_alreadyFetchedVendorCollectionViaProductVendor", _alreadyFetchedVendorCollectionViaProductVendor);
			info.AddValue("_productModel", (!this.MarkedForDeletion?_productModel:null));
			info.AddValue("_productModelReturnsNewIfNotFound", _productModelReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProductModel", _alwaysFetchProductModel);
			info.AddValue("_alreadyFetchedProductModel", _alreadyFetchedProductModel);
			info.AddValue("_productSubcategory", (!this.MarkedForDeletion?_productSubcategory:null));
			info.AddValue("_productSubcategoryReturnsNewIfNotFound", _productSubcategoryReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProductSubcategory", _alwaysFetchProductSubcategory);
			info.AddValue("_alreadyFetchedProductSubcategory", _alreadyFetchedProductSubcategory);
			info.AddValue("_unitMeasure", (!this.MarkedForDeletion?_unitMeasure:null));
			info.AddValue("_unitMeasureReturnsNewIfNotFound", _unitMeasureReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUnitMeasure", _alwaysFetchUnitMeasure);
			info.AddValue("_alreadyFetchedUnitMeasure", _alreadyFetchedUnitMeasure);
			info.AddValue("_unitMeasure_", (!this.MarkedForDeletion?_unitMeasure_:null));
			info.AddValue("_unitMeasure_ReturnsNewIfNotFound", _unitMeasure_ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUnitMeasure_", _alwaysFetchUnitMeasure_);
			info.AddValue("_alreadyFetchedUnitMeasure_", _alreadyFetchedUnitMeasure_);

			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "ProductModel":
					_alreadyFetchedProductModel = true;
					this.ProductModel = (ProductModelEntity)entity;
					break;
				case "ProductSubcategory":
					_alreadyFetchedProductSubcategory = true;
					this.ProductSubcategory = (ProductSubcategoryEntity)entity;
					break;
				case "UnitMeasure":
					_alreadyFetchedUnitMeasure = true;
					this.UnitMeasure = (UnitMeasureEntity)entity;
					break;
				case "UnitMeasure_":
					_alreadyFetchedUnitMeasure_ = true;
					this.UnitMeasure_ = (UnitMeasureEntity)entity;
					break;
				case "BillOfMaterials":
					_alreadyFetchedBillOfMaterials = true;
					if(entity!=null)
					{
						this.BillOfMaterials.Add((BillOfMaterialsEntity)entity);
					}
					break;
				case "BillOfMaterials_":
					_alreadyFetchedBillOfMaterials_ = true;
					if(entity!=null)
					{
						this.BillOfMaterials_.Add((BillOfMaterialsEntity)entity);
					}
					break;
				case "ProductCostHistory":
					_alreadyFetchedProductCostHistory = true;
					if(entity!=null)
					{
						this.ProductCostHistory.Add((ProductCostHistoryEntity)entity);
					}
					break;
				case "ProductDocument":
					_alreadyFetchedProductDocument = true;
					if(entity!=null)
					{
						this.ProductDocument.Add((ProductDocumentEntity)entity);
					}
					break;
				case "ProductInventory":
					_alreadyFetchedProductInventory = true;
					if(entity!=null)
					{
						this.ProductInventory.Add((ProductInventoryEntity)entity);
					}
					break;
				case "ProductListPriceHistory":
					_alreadyFetchedProductListPriceHistory = true;
					if(entity!=null)
					{
						this.ProductListPriceHistory.Add((ProductListPriceHistoryEntity)entity);
					}
					break;
				case "ProductProductPhoto":
					_alreadyFetchedProductProductPhoto = true;
					if(entity!=null)
					{
						this.ProductProductPhoto.Add((ProductProductPhotoEntity)entity);
					}
					break;
				case "ProductReview":
					_alreadyFetchedProductReview = true;
					if(entity!=null)
					{
						this.ProductReview.Add((ProductReviewEntity)entity);
					}
					break;
				case "ProductVendor":
					_alreadyFetchedProductVendor = true;
					if(entity!=null)
					{
						this.ProductVendor.Add((ProductVendorEntity)entity);
					}
					break;
				case "PurchaseOrderDetail":
					_alreadyFetchedPurchaseOrderDetail = true;
					if(entity!=null)
					{
						this.PurchaseOrderDetail.Add((PurchaseOrderDetailEntity)entity);
					}
					break;
				case "ShoppingCartItem":
					_alreadyFetchedShoppingCartItem = true;
					if(entity!=null)
					{
						this.ShoppingCartItem.Add((ShoppingCartItemEntity)entity);
					}
					break;
				case "SpecialOfferProducts":
					_alreadyFetchedSpecialOfferProducts = true;
					if(entity!=null)
					{
						this.SpecialOfferProducts.Add((SpecialOfferProductEntity)entity);
					}
					break;
				case "TransactionHistory":
					_alreadyFetchedTransactionHistory = true;
					if(entity!=null)
					{
						this.TransactionHistory.Add((TransactionHistoryEntity)entity);
					}
					break;
				case "WorkOrder":
					_alreadyFetchedWorkOrder = true;
					if(entity!=null)
					{
						this.WorkOrder.Add((WorkOrderEntity)entity);
					}
					break;
				case "DocumentCollectionViaProductDocument":
					_alreadyFetchedDocumentCollectionViaProductDocument = true;
					if(entity!=null)
					{
						this.DocumentCollectionViaProductDocument.Add((DocumentEntity)entity);
					}
					break;
				case "LocationCollectionViaProductInventory":
					_alreadyFetchedLocationCollectionViaProductInventory = true;
					if(entity!=null)
					{
						this.LocationCollectionViaProductInventory.Add((LocationEntity)entity);
					}
					break;
				case "ProductPhotoCollectionViaProductProductPhoto":
					_alreadyFetchedProductPhotoCollectionViaProductProductPhoto = true;
					if(entity!=null)
					{
						this.ProductPhotoCollectionViaProductProductPhoto.Add((ProductPhotoEntity)entity);
					}
					break;
				case "PurchaseOrderHeaderCollectionViaPurchaseOrderDetail":
					_alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail = true;
					if(entity!=null)
					{
						this.PurchaseOrderHeaderCollectionViaPurchaseOrderDetail.Add((PurchaseOrderHeaderEntity)entity);
					}
					break;
				case "ScrapReasonCollectionViaWorkOrder":
					_alreadyFetchedScrapReasonCollectionViaWorkOrder = true;
					if(entity!=null)
					{
						this.ScrapReasonCollectionViaWorkOrder.Add((ScrapReasonEntity)entity);
					}
					break;
				case "SpecialOfferCollectionViaSpecialOfferProduct":
					_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = true;
					if(entity!=null)
					{
						this.SpecialOfferCollectionViaSpecialOfferProduct.Add((SpecialOfferEntity)entity);
					}
					break;
				case "UnitMeasureCollectionViaBillOfMaterials":
					_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials = true;
					if(entity!=null)
					{
						this.UnitMeasureCollectionViaBillOfMaterials.Add((UnitMeasureEntity)entity);
					}
					break;
				case "UnitMeasureCollectionViaBillOfMaterials_":
					_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_ = true;
					if(entity!=null)
					{
						this.UnitMeasureCollectionViaBillOfMaterials_.Add((UnitMeasureEntity)entity);
					}
					break;
				case "UnitMeasureCollectionViaProductVendor":
					_alreadyFetchedUnitMeasureCollectionViaProductVendor = true;
					if(entity!=null)
					{
						this.UnitMeasureCollectionViaProductVendor.Add((UnitMeasureEntity)entity);
					}
					break;
				case "VendorCollectionViaProductVendor":
					_alreadyFetchedVendorCollectionViaProductVendor = true;
					if(entity!=null)
					{
						this.VendorCollectionViaProductVendor.Add((VendorEntity)entity);
					}
					break;

				default:

					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "ProductModel":
					SetupSyncProductModel(relatedEntity);
					break;
				case "ProductSubcategory":
					SetupSyncProductSubcategory(relatedEntity);
					break;
				case "UnitMeasure":
					SetupSyncUnitMeasure(relatedEntity);
					break;
				case "UnitMeasure_":
					SetupSyncUnitMeasure_(relatedEntity);
					break;
				case "BillOfMaterials":
					_billOfMaterials.Add((BillOfMaterialsEntity)relatedEntity);
					break;
				case "BillOfMaterials_":
					_billOfMaterials_.Add((BillOfMaterialsEntity)relatedEntity);
					break;
				case "ProductCostHistory":
					_productCostHistory.Add((ProductCostHistoryEntity)relatedEntity);
					break;
				case "ProductDocument":
					_productDocument.Add((ProductDocumentEntity)relatedEntity);
					break;
				case "ProductInventory":
					_productInventory.Add((ProductInventoryEntity)relatedEntity);
					break;
				case "ProductListPriceHistory":
					_productListPriceHistory.Add((ProductListPriceHistoryEntity)relatedEntity);
					break;
				case "ProductProductPhoto":
					_productProductPhoto.Add((ProductProductPhotoEntity)relatedEntity);
					break;
				case "ProductReview":
					_productReview.Add((ProductReviewEntity)relatedEntity);
					break;
				case "ProductVendor":
					_productVendor.Add((ProductVendorEntity)relatedEntity);
					break;
				case "PurchaseOrderDetail":
					_purchaseOrderDetail.Add((PurchaseOrderDetailEntity)relatedEntity);
					break;
				case "ShoppingCartItem":
					_shoppingCartItem.Add((ShoppingCartItemEntity)relatedEntity);
					break;
				case "SpecialOfferProducts":
					_specialOfferProducts.Add((SpecialOfferProductEntity)relatedEntity);
					break;
				case "TransactionHistory":
					_transactionHistory.Add((TransactionHistoryEntity)relatedEntity);
					break;
				case "WorkOrder":
					_workOrder.Add((WorkOrderEntity)relatedEntity);
					break;

				default:

					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "ProductModel":
					DesetupSyncProductModel(false, true);
					break;
				case "ProductSubcategory":
					DesetupSyncProductSubcategory(false, true);
					break;
				case "UnitMeasure":
					DesetupSyncUnitMeasure(false, true);
					break;
				case "UnitMeasure_":
					DesetupSyncUnitMeasure_(false, true);
					break;
				case "BillOfMaterials":
					base.PerformRelatedEntityRemoval(_billOfMaterials, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BillOfMaterials_":
					base.PerformRelatedEntityRemoval(_billOfMaterials_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductCostHistory":
					base.PerformRelatedEntityRemoval(_productCostHistory, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductDocument":
					base.PerformRelatedEntityRemoval(_productDocument, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductInventory":
					base.PerformRelatedEntityRemoval(_productInventory, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductListPriceHistory":
					base.PerformRelatedEntityRemoval(_productListPriceHistory, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductProductPhoto":
					base.PerformRelatedEntityRemoval(_productProductPhoto, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductReview":
					base.PerformRelatedEntityRemoval(_productReview, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductVendor":
					base.PerformRelatedEntityRemoval(_productVendor, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PurchaseOrderDetail":
					base.PerformRelatedEntityRemoval(_purchaseOrderDetail, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ShoppingCartItem":
					base.PerformRelatedEntityRemoval(_shoppingCartItem, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SpecialOfferProducts":
					base.PerformRelatedEntityRemoval(_specialOfferProducts, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "TransactionHistory":
					base.PerformRelatedEntityRemoval(_transactionHistory, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrder":
					base.PerformRelatedEntityRemoval(_workOrder, relatedEntity, signalRelatedEntityManyToOne);
					break;

				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_productModel!=null)
			{
				toReturn.Add(_productModel);
			}
			if(_productSubcategory!=null)
			{
				toReturn.Add(_productSubcategory);
			}
			if(_unitMeasure!=null)
			{
				toReturn.Add(_unitMeasure);
			}
			if(_unitMeasure_!=null)
			{
				toReturn.Add(_unitMeasure_);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_billOfMaterials);
			toReturn.Add(_billOfMaterials_);
			toReturn.Add(_productCostHistory);
			toReturn.Add(_productDocument);
			toReturn.Add(_productInventory);
			toReturn.Add(_productListPriceHistory);
			toReturn.Add(_productProductPhoto);
			toReturn.Add(_productReview);
			toReturn.Add(_productVendor);
			toReturn.Add(_purchaseOrderDetail);
			toReturn.Add(_shoppingCartItem);
			toReturn.Add(_specialOfferProducts);
			toReturn.Add(_transactionHistory);
			toReturn.Add(_workOrder);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID)
		{
			return FetchUsingPK(productID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(productID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(productID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ProductFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ProductFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ProductRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialsEntity'</returns>
		public AW.Data.CollectionClasses.BillOfMaterialsCollection GetMultiBillOfMaterials(bool forceFetch)
		{
			return GetMultiBillOfMaterials(forceFetch, _billOfMaterials.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialsEntity'</returns>
		public AW.Data.CollectionClasses.BillOfMaterialsCollection GetMultiBillOfMaterials(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiBillOfMaterials(forceFetch, _billOfMaterials.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.BillOfMaterialsCollection GetMultiBillOfMaterials(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiBillOfMaterials(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.BillOfMaterialsCollection GetMultiBillOfMaterials(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBillOfMaterials || forceFetch || _alwaysFetchBillOfMaterials) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_billOfMaterials.ParticipatesInTransaction)
					{
						base.Transaction.Add(_billOfMaterials);
					}
				}
				_billOfMaterials.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_billOfMaterials.EntityFactoryToUse = entityFactoryToUse;
				}
				_billOfMaterials.GetMultiManyToOne(null, this, null, filter);
				_billOfMaterials.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfMaterials = true;
			}
			return _billOfMaterials;
		}

		/// <summary> Sets the collection parameters for the collection for 'BillOfMaterials'. These settings will be taken into account
		/// when the property BillOfMaterials is requested or GetMultiBillOfMaterials is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBillOfMaterials(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_billOfMaterials.SortClauses=sortClauses;
			_billOfMaterials.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialsEntity'</returns>
		public AW.Data.CollectionClasses.BillOfMaterialsCollection GetMultiBillOfMaterials_(bool forceFetch)
		{
			return GetMultiBillOfMaterials_(forceFetch, _billOfMaterials_.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialsEntity'</returns>
		public AW.Data.CollectionClasses.BillOfMaterialsCollection GetMultiBillOfMaterials_(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiBillOfMaterials_(forceFetch, _billOfMaterials_.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.BillOfMaterialsCollection GetMultiBillOfMaterials_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiBillOfMaterials_(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.BillOfMaterialsCollection GetMultiBillOfMaterials_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBillOfMaterials_ || forceFetch || _alwaysFetchBillOfMaterials_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_billOfMaterials_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_billOfMaterials_);
					}
				}
				_billOfMaterials_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_billOfMaterials_.EntityFactoryToUse = entityFactoryToUse;
				}
				_billOfMaterials_.GetMultiManyToOne(this, null, null, filter);
				_billOfMaterials_.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfMaterials_ = true;
			}
			return _billOfMaterials_;
		}

		/// <summary> Sets the collection parameters for the collection for 'BillOfMaterials_'. These settings will be taken into account
		/// when the property BillOfMaterials_ is requested or GetMultiBillOfMaterials_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBillOfMaterials_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_billOfMaterials_.SortClauses=sortClauses;
			_billOfMaterials_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductCostHistoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductCostHistoryCollection GetMultiProductCostHistory(bool forceFetch)
		{
			return GetMultiProductCostHistory(forceFetch, _productCostHistory.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductCostHistoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductCostHistoryCollection GetMultiProductCostHistory(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductCostHistory(forceFetch, _productCostHistory.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCostHistoryCollection GetMultiProductCostHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductCostHistory(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductCostHistoryCollection GetMultiProductCostHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductCostHistory || forceFetch || _alwaysFetchProductCostHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productCostHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCostHistory);
					}
				}
				_productCostHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productCostHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_productCostHistory.GetMultiManyToOne(this, filter);
				_productCostHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCostHistory = true;
			}
			return _productCostHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductCostHistory'. These settings will be taken into account
		/// when the property ProductCostHistory is requested or GetMultiProductCostHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductCostHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productCostHistory.SortClauses=sortClauses;
			_productCostHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductDocumentEntity'</returns>
		public AW.Data.CollectionClasses.ProductDocumentCollection GetMultiProductDocument(bool forceFetch)
		{
			return GetMultiProductDocument(forceFetch, _productDocument.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductDocumentEntity'</returns>
		public AW.Data.CollectionClasses.ProductDocumentCollection GetMultiProductDocument(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductDocument(forceFetch, _productDocument.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductDocumentCollection GetMultiProductDocument(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductDocument(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductDocumentCollection GetMultiProductDocument(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductDocument || forceFetch || _alwaysFetchProductDocument) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productDocument.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productDocument);
					}
				}
				_productDocument.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productDocument.EntityFactoryToUse = entityFactoryToUse;
				}
				_productDocument.GetMultiManyToOne(null, this, filter);
				_productDocument.SuppressClearInGetMulti=false;
				_alreadyFetchedProductDocument = true;
			}
			return _productDocument;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductDocument'. These settings will be taken into account
		/// when the property ProductDocument is requested or GetMultiProductDocument is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductDocument(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productDocument.SortClauses=sortClauses;
			_productDocument.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductInventoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventory(bool forceFetch)
		{
			return GetMultiProductInventory(forceFetch, _productInventory.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductInventoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventory(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductInventory(forceFetch, _productInventory.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductInventory(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductInventory || forceFetch || _alwaysFetchProductInventory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productInventory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productInventory);
					}
				}
				_productInventory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productInventory.EntityFactoryToUse = entityFactoryToUse;
				}
				_productInventory.GetMultiManyToOne(null, this, filter);
				_productInventory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductInventory = true;
			}
			return _productInventory;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductInventory'. These settings will be taken into account
		/// when the property ProductInventory is requested or GetMultiProductInventory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductInventory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productInventory.SortClauses=sortClauses;
			_productInventory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductListPriceHistoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductListPriceHistoryCollection GetMultiProductListPriceHistory(bool forceFetch)
		{
			return GetMultiProductListPriceHistory(forceFetch, _productListPriceHistory.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductListPriceHistoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductListPriceHistoryCollection GetMultiProductListPriceHistory(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductListPriceHistory(forceFetch, _productListPriceHistory.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductListPriceHistoryCollection GetMultiProductListPriceHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductListPriceHistory(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductListPriceHistoryCollection GetMultiProductListPriceHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductListPriceHistory || forceFetch || _alwaysFetchProductListPriceHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productListPriceHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productListPriceHistory);
					}
				}
				_productListPriceHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productListPriceHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_productListPriceHistory.GetMultiManyToOne(this, filter);
				_productListPriceHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductListPriceHistory = true;
			}
			return _productListPriceHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductListPriceHistory'. These settings will be taken into account
		/// when the property ProductListPriceHistory is requested or GetMultiProductListPriceHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductListPriceHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productListPriceHistory.SortClauses=sortClauses;
			_productListPriceHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductProductPhotoEntity'</returns>
		public AW.Data.CollectionClasses.ProductProductPhotoCollection GetMultiProductProductPhoto(bool forceFetch)
		{
			return GetMultiProductProductPhoto(forceFetch, _productProductPhoto.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductProductPhotoEntity'</returns>
		public AW.Data.CollectionClasses.ProductProductPhotoCollection GetMultiProductProductPhoto(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductProductPhoto(forceFetch, _productProductPhoto.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductProductPhotoCollection GetMultiProductProductPhoto(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductProductPhoto(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductProductPhotoCollection GetMultiProductProductPhoto(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductProductPhoto || forceFetch || _alwaysFetchProductProductPhoto) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productProductPhoto.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productProductPhoto);
					}
				}
				_productProductPhoto.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productProductPhoto.EntityFactoryToUse = entityFactoryToUse;
				}
				_productProductPhoto.GetMultiManyToOne(this, null, filter);
				_productProductPhoto.SuppressClearInGetMulti=false;
				_alreadyFetchedProductProductPhoto = true;
			}
			return _productProductPhoto;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductProductPhoto'. These settings will be taken into account
		/// when the property ProductProductPhoto is requested or GetMultiProductProductPhoto is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductProductPhoto(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productProductPhoto.SortClauses=sortClauses;
			_productProductPhoto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductReviewEntity'</returns>
		public AW.Data.CollectionClasses.ProductReviewCollection GetMultiProductReview(bool forceFetch)
		{
			return GetMultiProductReview(forceFetch, _productReview.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductReviewEntity'</returns>
		public AW.Data.CollectionClasses.ProductReviewCollection GetMultiProductReview(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductReview(forceFetch, _productReview.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductReviewCollection GetMultiProductReview(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductReview(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductReviewCollection GetMultiProductReview(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductReview || forceFetch || _alwaysFetchProductReview) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productReview.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productReview);
					}
				}
				_productReview.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productReview.EntityFactoryToUse = entityFactoryToUse;
				}
				_productReview.GetMultiManyToOne(this, filter);
				_productReview.SuppressClearInGetMulti=false;
				_alreadyFetchedProductReview = true;
			}
			return _productReview;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductReview'. These settings will be taken into account
		/// when the property ProductReview is requested or GetMultiProductReview is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductReview(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productReview.SortClauses=sortClauses;
			_productReview.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductVendorEntity'</returns>
		public AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendor(bool forceFetch)
		{
			return GetMultiProductVendor(forceFetch, _productVendor.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductVendorEntity'</returns>
		public AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendor(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductVendor(forceFetch, _productVendor.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendor(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductVendor(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendor(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductVendor || forceFetch || _alwaysFetchProductVendor) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productVendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productVendor);
					}
				}
				_productVendor.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productVendor.EntityFactoryToUse = entityFactoryToUse;
				}
				_productVendor.GetMultiManyToOne(this, null, null, filter);
				_productVendor.SuppressClearInGetMulti=false;
				_alreadyFetchedProductVendor = true;
			}
			return _productVendor;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductVendor'. These settings will be taken into account
		/// when the property ProductVendor is requested or GetMultiProductVendor is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductVendor(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productVendor.SortClauses=sortClauses;
			_productVendor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch)
		{
			return GetMultiPurchaseOrderDetail(forceFetch, _purchaseOrderDetail.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiPurchaseOrderDetail(forceFetch, _purchaseOrderDetail.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiPurchaseOrderDetail(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderDetail || forceFetch || _alwaysFetchPurchaseOrderDetail) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderDetail);
					}
				}
				_purchaseOrderDetail.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_purchaseOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				}
				_purchaseOrderDetail.GetMultiManyToOne(this, null, filter);
				_purchaseOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderDetail = true;
			}
			return _purchaseOrderDetail;
		}

		/// <summary> Sets the collection parameters for the collection for 'PurchaseOrderDetail'. These settings will be taken into account
		/// when the property PurchaseOrderDetail is requested or GetMultiPurchaseOrderDetail is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderDetail(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderDetail.SortClauses=sortClauses;
			_purchaseOrderDetail.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShoppingCartItemEntity'</returns>
		public AW.Data.CollectionClasses.ShoppingCartItemCollection GetMultiShoppingCartItem(bool forceFetch)
		{
			return GetMultiShoppingCartItem(forceFetch, _shoppingCartItem.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ShoppingCartItemEntity'</returns>
		public AW.Data.CollectionClasses.ShoppingCartItemCollection GetMultiShoppingCartItem(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiShoppingCartItem(forceFetch, _shoppingCartItem.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ShoppingCartItemCollection GetMultiShoppingCartItem(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiShoppingCartItem(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ShoppingCartItemCollection GetMultiShoppingCartItem(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedShoppingCartItem || forceFetch || _alwaysFetchShoppingCartItem) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_shoppingCartItem.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shoppingCartItem);
					}
				}
				_shoppingCartItem.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_shoppingCartItem.EntityFactoryToUse = entityFactoryToUse;
				}
				_shoppingCartItem.GetMultiManyToOne(this, filter);
				_shoppingCartItem.SuppressClearInGetMulti=false;
				_alreadyFetchedShoppingCartItem = true;
			}
			return _shoppingCartItem;
		}

		/// <summary> Sets the collection parameters for the collection for 'ShoppingCartItem'. These settings will be taken into account
		/// when the property ShoppingCartItem is requested or GetMultiShoppingCartItem is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShoppingCartItem(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shoppingCartItem.SortClauses=sortClauses;
			_shoppingCartItem.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProducts(bool forceFetch)
		{
			return GetMultiSpecialOfferProducts(forceFetch, _specialOfferProducts.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProducts(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSpecialOfferProducts(forceFetch, _specialOfferProducts.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProducts(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSpecialOfferProducts(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProducts(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSpecialOfferProducts || forceFetch || _alwaysFetchSpecialOfferProducts) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferProducts.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferProducts);
					}
				}
				_specialOfferProducts.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_specialOfferProducts.EntityFactoryToUse = entityFactoryToUse;
				}
				_specialOfferProducts.GetMultiManyToOne(this, null, filter);
				_specialOfferProducts.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferProducts = true;
			}
			return _specialOfferProducts;
		}

		/// <summary> Sets the collection parameters for the collection for 'SpecialOfferProducts'. These settings will be taken into account
		/// when the property SpecialOfferProducts is requested or GetMultiSpecialOfferProducts is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOfferProducts(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOfferProducts.SortClauses=sortClauses;
			_specialOfferProducts.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'TransactionHistoryEntity'</returns>
		public AW.Data.CollectionClasses.TransactionHistoryCollection GetMultiTransactionHistory(bool forceFetch)
		{
			return GetMultiTransactionHistory(forceFetch, _transactionHistory.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'TransactionHistoryEntity'</returns>
		public AW.Data.CollectionClasses.TransactionHistoryCollection GetMultiTransactionHistory(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiTransactionHistory(forceFetch, _transactionHistory.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.TransactionHistoryCollection GetMultiTransactionHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiTransactionHistory(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.TransactionHistoryCollection GetMultiTransactionHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedTransactionHistory || forceFetch || _alwaysFetchTransactionHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_transactionHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_transactionHistory);
					}
				}
				_transactionHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_transactionHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_transactionHistory.GetMultiManyToOne(this, filter);
				_transactionHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedTransactionHistory = true;
			}
			return _transactionHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'TransactionHistory'. These settings will be taken into account
		/// when the property TransactionHistory is requested or GetMultiTransactionHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersTransactionHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_transactionHistory.SortClauses=sortClauses;
			_transactionHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public AW.Data.CollectionClasses.WorkOrderCollection GetMultiWorkOrder(bool forceFetch)
		{
			return GetMultiWorkOrder(forceFetch, _workOrder.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public AW.Data.CollectionClasses.WorkOrderCollection GetMultiWorkOrder(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiWorkOrder(forceFetch, _workOrder.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.WorkOrderCollection GetMultiWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiWorkOrder(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.WorkOrderCollection GetMultiWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrder || forceFetch || _alwaysFetchWorkOrder) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrder);
					}
				}
				_workOrder.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrder.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrder.GetMultiManyToOne(this, null, filter);
				_workOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrder = true;
			}
			return _workOrder;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrder'. These settings will be taken into account
		/// when the property WorkOrder is requested or GetMultiWorkOrder is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrder(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrder.SortClauses=sortClauses;
			_workOrder.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'DocumentEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DocumentEntity'</returns>
		public AW.Data.CollectionClasses.DocumentCollection GetMultiDocumentCollectionViaProductDocument(bool forceFetch)
		{
			return GetMultiDocumentCollectionViaProductDocument(forceFetch, _documentCollectionViaProductDocument.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'DocumentEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.DocumentCollection GetMultiDocumentCollectionViaProductDocument(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedDocumentCollectionViaProductDocument || forceFetch || _alwaysFetchDocumentCollectionViaProductDocument) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_documentCollectionViaProductDocument.ParticipatesInTransaction)
					{
						base.Transaction.Add(_documentCollectionViaProductDocument);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductFields.ProductID, ComparisonOperator.Equal, this.ProductID, "ProductEntity__"));
				_documentCollectionViaProductDocument.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_documentCollectionViaProductDocument.EntityFactoryToUse = entityFactoryToUse;
				}
				_documentCollectionViaProductDocument.GetMulti(filter, GetRelationsForField("DocumentCollectionViaProductDocument"));
				_documentCollectionViaProductDocument.SuppressClearInGetMulti=false;
				_alreadyFetchedDocumentCollectionViaProductDocument = true;
			}
			return _documentCollectionViaProductDocument;
		}

		/// <summary> Sets the collection parameters for the collection for 'DocumentCollectionViaProductDocument'. These settings will be taken into account
		/// when the property DocumentCollectionViaProductDocument is requested or GetMultiDocumentCollectionViaProductDocument is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDocumentCollectionViaProductDocument(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_documentCollectionViaProductDocument.SortClauses=sortClauses;
			_documentCollectionViaProductDocument.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'LocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'LocationEntity'</returns>
		public AW.Data.CollectionClasses.LocationCollection GetMultiLocationCollectionViaProductInventory(bool forceFetch)
		{
			return GetMultiLocationCollectionViaProductInventory(forceFetch, _locationCollectionViaProductInventory.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'LocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.LocationCollection GetMultiLocationCollectionViaProductInventory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedLocationCollectionViaProductInventory || forceFetch || _alwaysFetchLocationCollectionViaProductInventory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_locationCollectionViaProductInventory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_locationCollectionViaProductInventory);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductFields.ProductID, ComparisonOperator.Equal, this.ProductID, "ProductEntity__"));
				_locationCollectionViaProductInventory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_locationCollectionViaProductInventory.EntityFactoryToUse = entityFactoryToUse;
				}
				_locationCollectionViaProductInventory.GetMulti(filter, GetRelationsForField("LocationCollectionViaProductInventory"));
				_locationCollectionViaProductInventory.SuppressClearInGetMulti=false;
				_alreadyFetchedLocationCollectionViaProductInventory = true;
			}
			return _locationCollectionViaProductInventory;
		}

		/// <summary> Sets the collection parameters for the collection for 'LocationCollectionViaProductInventory'. These settings will be taken into account
		/// when the property LocationCollectionViaProductInventory is requested or GetMultiLocationCollectionViaProductInventory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersLocationCollectionViaProductInventory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_locationCollectionViaProductInventory.SortClauses=sortClauses;
			_locationCollectionViaProductInventory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductPhotoEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductPhotoEntity'</returns>
		public AW.Data.CollectionClasses.ProductPhotoCollection GetMultiProductPhotoCollectionViaProductProductPhoto(bool forceFetch)
		{
			return GetMultiProductPhotoCollectionViaProductProductPhoto(forceFetch, _productPhotoCollectionViaProductProductPhoto.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductPhotoEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductPhotoCollection GetMultiProductPhotoCollectionViaProductProductPhoto(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductPhotoCollectionViaProductProductPhoto || forceFetch || _alwaysFetchProductPhotoCollectionViaProductProductPhoto) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productPhotoCollectionViaProductProductPhoto.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productPhotoCollectionViaProductProductPhoto);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductFields.ProductID, ComparisonOperator.Equal, this.ProductID, "ProductEntity__"));
				_productPhotoCollectionViaProductProductPhoto.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productPhotoCollectionViaProductProductPhoto.EntityFactoryToUse = entityFactoryToUse;
				}
				_productPhotoCollectionViaProductProductPhoto.GetMulti(filter, GetRelationsForField("ProductPhotoCollectionViaProductProductPhoto"));
				_productPhotoCollectionViaProductProductPhoto.SuppressClearInGetMulti=false;
				_alreadyFetchedProductPhotoCollectionViaProductProductPhoto = true;
			}
			return _productPhotoCollectionViaProductProductPhoto;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductPhotoCollectionViaProductProductPhoto'. These settings will be taken into account
		/// when the property ProductPhotoCollectionViaProductProductPhoto is requested or GetMultiProductPhotoCollectionViaProductProductPhoto is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductPhotoCollectionViaProductProductPhoto(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productPhotoCollectionViaProductProductPhoto.SortClauses=sortClauses;
			_productPhotoCollectionViaProductProductPhoto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(bool forceFetch)
		{
			return GetMultiPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(forceFetch, _purchaseOrderHeaderCollectionViaPurchaseOrderDetail.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail || forceFetch || _alwaysFetchPurchaseOrderHeaderCollectionViaPurchaseOrderDetail) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderHeaderCollectionViaPurchaseOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderHeaderCollectionViaPurchaseOrderDetail);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductFields.ProductID, ComparisonOperator.Equal, this.ProductID, "ProductEntity__"));
				_purchaseOrderHeaderCollectionViaPurchaseOrderDetail.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_purchaseOrderHeaderCollectionViaPurchaseOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				}
				_purchaseOrderHeaderCollectionViaPurchaseOrderDetail.GetMulti(filter, GetRelationsForField("PurchaseOrderHeaderCollectionViaPurchaseOrderDetail"));
				_purchaseOrderHeaderCollectionViaPurchaseOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail = true;
			}
			return _purchaseOrderHeaderCollectionViaPurchaseOrderDetail;
		}

		/// <summary> Sets the collection parameters for the collection for 'PurchaseOrderHeaderCollectionViaPurchaseOrderDetail'. These settings will be taken into account
		/// when the property PurchaseOrderHeaderCollectionViaPurchaseOrderDetail is requested or GetMultiPurchaseOrderHeaderCollectionViaPurchaseOrderDetail is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderHeaderCollectionViaPurchaseOrderDetail.SortClauses=sortClauses;
			_purchaseOrderHeaderCollectionViaPurchaseOrderDetail.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ScrapReasonEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ScrapReasonEntity'</returns>
		public AW.Data.CollectionClasses.ScrapReasonCollection GetMultiScrapReasonCollectionViaWorkOrder(bool forceFetch)
		{
			return GetMultiScrapReasonCollectionViaWorkOrder(forceFetch, _scrapReasonCollectionViaWorkOrder.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ScrapReasonEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ScrapReasonCollection GetMultiScrapReasonCollectionViaWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedScrapReasonCollectionViaWorkOrder || forceFetch || _alwaysFetchScrapReasonCollectionViaWorkOrder) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_scrapReasonCollectionViaWorkOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_scrapReasonCollectionViaWorkOrder);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductFields.ProductID, ComparisonOperator.Equal, this.ProductID, "ProductEntity__"));
				_scrapReasonCollectionViaWorkOrder.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_scrapReasonCollectionViaWorkOrder.EntityFactoryToUse = entityFactoryToUse;
				}
				_scrapReasonCollectionViaWorkOrder.GetMulti(filter, GetRelationsForField("ScrapReasonCollectionViaWorkOrder"));
				_scrapReasonCollectionViaWorkOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedScrapReasonCollectionViaWorkOrder = true;
			}
			return _scrapReasonCollectionViaWorkOrder;
		}

		/// <summary> Sets the collection parameters for the collection for 'ScrapReasonCollectionViaWorkOrder'. These settings will be taken into account
		/// when the property ScrapReasonCollectionViaWorkOrder is requested or GetMultiScrapReasonCollectionViaWorkOrder is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersScrapReasonCollectionViaWorkOrder(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_scrapReasonCollectionViaWorkOrder.SortClauses=sortClauses;
			_scrapReasonCollectionViaWorkOrder.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferCollection GetMultiSpecialOfferCollectionViaSpecialOfferProduct(bool forceFetch)
		{
			return GetMultiSpecialOfferCollectionViaSpecialOfferProduct(forceFetch, _specialOfferCollectionViaSpecialOfferProduct.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SpecialOfferCollection GetMultiSpecialOfferCollectionViaSpecialOfferProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct || forceFetch || _alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferCollectionViaSpecialOfferProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferCollectionViaSpecialOfferProduct);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductFields.ProductID, ComparisonOperator.Equal, this.ProductID, "ProductEntity__"));
				_specialOfferCollectionViaSpecialOfferProduct.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_specialOfferCollectionViaSpecialOfferProduct.EntityFactoryToUse = entityFactoryToUse;
				}
				_specialOfferCollectionViaSpecialOfferProduct.GetMulti(filter, GetRelationsForField("SpecialOfferCollectionViaSpecialOfferProduct"));
				_specialOfferCollectionViaSpecialOfferProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = true;
			}
			return _specialOfferCollectionViaSpecialOfferProduct;
		}

		/// <summary> Sets the collection parameters for the collection for 'SpecialOfferCollectionViaSpecialOfferProduct'. These settings will be taken into account
		/// when the property SpecialOfferCollectionViaSpecialOfferProduct is requested or GetMultiSpecialOfferCollectionViaSpecialOfferProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOfferCollectionViaSpecialOfferProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOfferCollectionViaSpecialOfferProduct.SortClauses=sortClauses;
			_specialOfferCollectionViaSpecialOfferProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaBillOfMaterials(bool forceFetch)
		{
			return GetMultiUnitMeasureCollectionViaBillOfMaterials(forceFetch, _unitMeasureCollectionViaBillOfMaterials.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaBillOfMaterials(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials || forceFetch || _alwaysFetchUnitMeasureCollectionViaBillOfMaterials) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasureCollectionViaBillOfMaterials.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasureCollectionViaBillOfMaterials);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductFields.ProductID, ComparisonOperator.Equal, this.ProductID, "ProductEntity__"));
				_unitMeasureCollectionViaBillOfMaterials.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_unitMeasureCollectionViaBillOfMaterials.EntityFactoryToUse = entityFactoryToUse;
				}
				_unitMeasureCollectionViaBillOfMaterials.GetMulti(filter, GetRelationsForField("UnitMeasureCollectionViaBillOfMaterials"));
				_unitMeasureCollectionViaBillOfMaterials.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials = true;
			}
			return _unitMeasureCollectionViaBillOfMaterials;
		}

		/// <summary> Sets the collection parameters for the collection for 'UnitMeasureCollectionViaBillOfMaterials'. These settings will be taken into account
		/// when the property UnitMeasureCollectionViaBillOfMaterials is requested or GetMultiUnitMeasureCollectionViaBillOfMaterials is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasureCollectionViaBillOfMaterials(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasureCollectionViaBillOfMaterials.SortClauses=sortClauses;
			_unitMeasureCollectionViaBillOfMaterials.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaBillOfMaterials_(bool forceFetch)
		{
			return GetMultiUnitMeasureCollectionViaBillOfMaterials_(forceFetch, _unitMeasureCollectionViaBillOfMaterials_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaBillOfMaterials_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_ || forceFetch || _alwaysFetchUnitMeasureCollectionViaBillOfMaterials_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasureCollectionViaBillOfMaterials_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasureCollectionViaBillOfMaterials_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductFields.ProductID, ComparisonOperator.Equal, this.ProductID, "ProductEntity__"));
				_unitMeasureCollectionViaBillOfMaterials_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_unitMeasureCollectionViaBillOfMaterials_.EntityFactoryToUse = entityFactoryToUse;
				}
				_unitMeasureCollectionViaBillOfMaterials_.GetMulti(filter, GetRelationsForField("UnitMeasureCollectionViaBillOfMaterials_"));
				_unitMeasureCollectionViaBillOfMaterials_.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_ = true;
			}
			return _unitMeasureCollectionViaBillOfMaterials_;
		}

		/// <summary> Sets the collection parameters for the collection for 'UnitMeasureCollectionViaBillOfMaterials_'. These settings will be taken into account
		/// when the property UnitMeasureCollectionViaBillOfMaterials_ is requested or GetMultiUnitMeasureCollectionViaBillOfMaterials_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasureCollectionViaBillOfMaterials_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasureCollectionViaBillOfMaterials_.SortClauses=sortClauses;
			_unitMeasureCollectionViaBillOfMaterials_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaProductVendor(bool forceFetch)
		{
			return GetMultiUnitMeasureCollectionViaProductVendor(forceFetch, _unitMeasureCollectionViaProductVendor.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaProductVendor(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasureCollectionViaProductVendor || forceFetch || _alwaysFetchUnitMeasureCollectionViaProductVendor) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasureCollectionViaProductVendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasureCollectionViaProductVendor);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductFields.ProductID, ComparisonOperator.Equal, this.ProductID, "ProductEntity__"));
				_unitMeasureCollectionViaProductVendor.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_unitMeasureCollectionViaProductVendor.EntityFactoryToUse = entityFactoryToUse;
				}
				_unitMeasureCollectionViaProductVendor.GetMulti(filter, GetRelationsForField("UnitMeasureCollectionViaProductVendor"));
				_unitMeasureCollectionViaProductVendor.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasureCollectionViaProductVendor = true;
			}
			return _unitMeasureCollectionViaProductVendor;
		}

		/// <summary> Sets the collection parameters for the collection for 'UnitMeasureCollectionViaProductVendor'. These settings will be taken into account
		/// when the property UnitMeasureCollectionViaProductVendor is requested or GetMultiUnitMeasureCollectionViaProductVendor is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasureCollectionViaProductVendor(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasureCollectionViaProductVendor.SortClauses=sortClauses;
			_unitMeasureCollectionViaProductVendor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorEntity'</returns>
		public AW.Data.CollectionClasses.VendorCollection GetMultiVendorCollectionViaProductVendor(bool forceFetch)
		{
			return GetMultiVendorCollectionViaProductVendor(forceFetch, _vendorCollectionViaProductVendor.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorCollection GetMultiVendorCollectionViaProductVendor(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedVendorCollectionViaProductVendor || forceFetch || _alwaysFetchVendorCollectionViaProductVendor) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorCollectionViaProductVendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorCollectionViaProductVendor);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductFields.ProductID, ComparisonOperator.Equal, this.ProductID, "ProductEntity__"));
				_vendorCollectionViaProductVendor.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_vendorCollectionViaProductVendor.EntityFactoryToUse = entityFactoryToUse;
				}
				_vendorCollectionViaProductVendor.GetMulti(filter, GetRelationsForField("VendorCollectionViaProductVendor"));
				_vendorCollectionViaProductVendor.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorCollectionViaProductVendor = true;
			}
			return _vendorCollectionViaProductVendor;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorCollectionViaProductVendor'. These settings will be taken into account
		/// when the property VendorCollectionViaProductVendor is requested or GetMultiVendorCollectionViaProductVendor is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorCollectionViaProductVendor(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorCollectionViaProductVendor.SortClauses=sortClauses;
			_vendorCollectionViaProductVendor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'ProductModelEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ProductModelEntity' which is related to this entity.</returns>
		public ProductModelEntity GetSingleProductModel()
		{
			return GetSingleProductModel(false);
		}

		/// <summary> Retrieves the related entity of type 'ProductModelEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductModelEntity' which is related to this entity.</returns>
		public virtual ProductModelEntity GetSingleProductModel(bool forceFetch)
		{
			if( ( !_alreadyFetchedProductModel || forceFetch || _alwaysFetchProductModel) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ProductEntity.Relations.ProductModelEntityUsingProductModelID);

				ProductModelEntity newEntity = new ProductModelEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ProductModelID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ProductModelEntity)base.ActiveContext.Get(newEntity);
					}
					this.ProductModel = newEntity;
				}
				else
				{
					if(_productModelReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_productModel == null)))
						{
							this.ProductModel = newEntity;
						}
					}
					else
					{
						this.ProductModel = null;
					}
				}
				_alreadyFetchedProductModel = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _productModel;
		}

		/// <summary> Retrieves the related entity of type 'ProductSubcategoryEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ProductSubcategoryEntity' which is related to this entity.</returns>
		public ProductSubcategoryEntity GetSingleProductSubcategory()
		{
			return GetSingleProductSubcategory(false);
		}

		/// <summary> Retrieves the related entity of type 'ProductSubcategoryEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductSubcategoryEntity' which is related to this entity.</returns>
		public virtual ProductSubcategoryEntity GetSingleProductSubcategory(bool forceFetch)
		{
			if( ( !_alreadyFetchedProductSubcategory || forceFetch || _alwaysFetchProductSubcategory) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryID);

				ProductSubcategoryEntity newEntity = new ProductSubcategoryEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ProductSubcategoryID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ProductSubcategoryEntity)base.ActiveContext.Get(newEntity);
					}
					this.ProductSubcategory = newEntity;
				}
				else
				{
					if(_productSubcategoryReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_productSubcategory == null)))
						{
							this.ProductSubcategory = newEntity;
						}
					}
					else
					{
						this.ProductSubcategory = null;
					}
				}
				_alreadyFetchedProductSubcategory = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _productSubcategory;
		}

		/// <summary> Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public UnitMeasureEntity GetSingleUnitMeasure()
		{
			return GetSingleUnitMeasure(false);
		}

		/// <summary> Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public virtual UnitMeasureEntity GetSingleUnitMeasure(bool forceFetch)
		{
			if( ( !_alreadyFetchedUnitMeasure || forceFetch || _alwaysFetchUnitMeasure) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ProductEntity.Relations.UnitMeasureEntityUsingSizeUnitMeasureCode);

				UnitMeasureEntity newEntity = new UnitMeasureEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.SizeUnitMeasureCode);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (UnitMeasureEntity)base.ActiveContext.Get(newEntity);
					}
					this.UnitMeasure = newEntity;
				}
				else
				{
					if(_unitMeasureReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_unitMeasure == null)))
						{
							this.UnitMeasure = newEntity;
						}
					}
					else
					{
						this.UnitMeasure = null;
					}
				}
				_alreadyFetchedUnitMeasure = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _unitMeasure;
		}

		/// <summary> Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public UnitMeasureEntity GetSingleUnitMeasure_()
		{
			return GetSingleUnitMeasure_(false);
		}

		/// <summary> Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public virtual UnitMeasureEntity GetSingleUnitMeasure_(bool forceFetch)
		{
			if( ( !_alreadyFetchedUnitMeasure_ || forceFetch || _alwaysFetchUnitMeasure_) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ProductEntity.Relations.UnitMeasureEntityUsingWeightUnitMeasureCode);

				UnitMeasureEntity newEntity = new UnitMeasureEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.WeightUnitMeasureCode);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (UnitMeasureEntity)base.ActiveContext.Get(newEntity);
					}
					this.UnitMeasure_ = newEntity;
				}
				else
				{
					if(_unitMeasure_ReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_unitMeasure_ == null)))
						{
							this.UnitMeasure_ = newEntity;
						}
					}
					else
					{
						this.UnitMeasure_ = null;
					}
				}
				_alreadyFetchedUnitMeasure_ = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _unitMeasure_;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ProductDAO dao = (ProductDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_billOfMaterials.ActiveContext = base.ActiveContext;
			_billOfMaterials_.ActiveContext = base.ActiveContext;
			_productCostHistory.ActiveContext = base.ActiveContext;
			_productDocument.ActiveContext = base.ActiveContext;
			_productInventory.ActiveContext = base.ActiveContext;
			_productListPriceHistory.ActiveContext = base.ActiveContext;
			_productProductPhoto.ActiveContext = base.ActiveContext;
			_productReview.ActiveContext = base.ActiveContext;
			_productVendor.ActiveContext = base.ActiveContext;
			_purchaseOrderDetail.ActiveContext = base.ActiveContext;
			_shoppingCartItem.ActiveContext = base.ActiveContext;
			_specialOfferProducts.ActiveContext = base.ActiveContext;
			_transactionHistory.ActiveContext = base.ActiveContext;
			_workOrder.ActiveContext = base.ActiveContext;
			_documentCollectionViaProductDocument.ActiveContext = base.ActiveContext;
			_locationCollectionViaProductInventory.ActiveContext = base.ActiveContext;
			_productPhotoCollectionViaProductProductPhoto.ActiveContext = base.ActiveContext;
			_purchaseOrderHeaderCollectionViaPurchaseOrderDetail.ActiveContext = base.ActiveContext;
			_scrapReasonCollectionViaWorkOrder.ActiveContext = base.ActiveContext;
			_specialOfferCollectionViaSpecialOfferProduct.ActiveContext = base.ActiveContext;
			_unitMeasureCollectionViaBillOfMaterials.ActiveContext = base.ActiveContext;
			_unitMeasureCollectionViaBillOfMaterials_.ActiveContext = base.ActiveContext;
			_unitMeasureCollectionViaProductVendor.ActiveContext = base.ActiveContext;
			_vendorCollectionViaProductVendor.ActiveContext = base.ActiveContext;
			if(_productModel!=null)
			{
				_productModel.ActiveContext = base.ActiveContext;
			}
			if(_productSubcategory!=null)
			{
				_productSubcategory.ActiveContext = base.ActiveContext;
			}
			if(_unitMeasure!=null)
			{
				_unitMeasure.ActiveContext = base.ActiveContext;
			}
			if(_unitMeasure_!=null)
			{
				_unitMeasure_.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ProductDAO dao = (ProductDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ProductDAO dao = (ProductDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction, updateRestriction);
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			base.Fields = CreateFields();
			base.IsNew=true;
			base.Validator = validatorToUse;

			InitClassMembers();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ProductEntity);
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ProductModel", _productModel);
			toReturn.Add("ProductSubcategory", _productSubcategory);
			toReturn.Add("UnitMeasure", _unitMeasure);
			toReturn.Add("UnitMeasure_", _unitMeasure_);
			toReturn.Add("BillOfMaterials", _billOfMaterials);
			toReturn.Add("BillOfMaterials_", _billOfMaterials_);
			toReturn.Add("ProductCostHistory", _productCostHistory);
			toReturn.Add("ProductDocument", _productDocument);
			toReturn.Add("ProductInventory", _productInventory);
			toReturn.Add("ProductListPriceHistory", _productListPriceHistory);
			toReturn.Add("ProductProductPhoto", _productProductPhoto);
			toReturn.Add("ProductReview", _productReview);
			toReturn.Add("ProductVendor", _productVendor);
			toReturn.Add("PurchaseOrderDetail", _purchaseOrderDetail);
			toReturn.Add("ShoppingCartItem", _shoppingCartItem);
			toReturn.Add("SpecialOfferProducts", _specialOfferProducts);
			toReturn.Add("TransactionHistory", _transactionHistory);
			toReturn.Add("WorkOrder", _workOrder);
			toReturn.Add("DocumentCollectionViaProductDocument", _documentCollectionViaProductDocument);
			toReturn.Add("LocationCollectionViaProductInventory", _locationCollectionViaProductInventory);
			toReturn.Add("ProductPhotoCollectionViaProductProductPhoto", _productPhotoCollectionViaProductProductPhoto);
			toReturn.Add("PurchaseOrderHeaderCollectionViaPurchaseOrderDetail", _purchaseOrderHeaderCollectionViaPurchaseOrderDetail);
			toReturn.Add("ScrapReasonCollectionViaWorkOrder", _scrapReasonCollectionViaWorkOrder);
			toReturn.Add("SpecialOfferCollectionViaSpecialOfferProduct", _specialOfferCollectionViaSpecialOfferProduct);
			toReturn.Add("UnitMeasureCollectionViaBillOfMaterials", _unitMeasureCollectionViaBillOfMaterials);
			toReturn.Add("UnitMeasureCollectionViaBillOfMaterials_", _unitMeasureCollectionViaBillOfMaterials_);
			toReturn.Add("UnitMeasureCollectionViaProductVendor", _unitMeasureCollectionViaProductVendor);
			toReturn.Add("VendorCollectionViaProductVendor", _vendorCollectionViaProductVendor);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The validator object for this ProductEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 productID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(productID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_billOfMaterials = new AW.Data.CollectionClasses.BillOfMaterialsCollection(new BillOfMaterialsEntityFactory());
			_billOfMaterials.SetContainingEntityInfo(this, "Product");
			_alwaysFetchBillOfMaterials = false;
			_alreadyFetchedBillOfMaterials = false;
			_billOfMaterials_ = new AW.Data.CollectionClasses.BillOfMaterialsCollection(new BillOfMaterialsEntityFactory());
			_billOfMaterials_.SetContainingEntityInfo(this, "Product_");
			_alwaysFetchBillOfMaterials_ = false;
			_alreadyFetchedBillOfMaterials_ = false;
			_productCostHistory = new AW.Data.CollectionClasses.ProductCostHistoryCollection(new ProductCostHistoryEntityFactory());
			_productCostHistory.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductCostHistory = false;
			_alreadyFetchedProductCostHistory = false;
			_productDocument = new AW.Data.CollectionClasses.ProductDocumentCollection(new ProductDocumentEntityFactory());
			_productDocument.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductDocument = false;
			_alreadyFetchedProductDocument = false;
			_productInventory = new AW.Data.CollectionClasses.ProductInventoryCollection(new ProductInventoryEntityFactory());
			_productInventory.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductInventory = false;
			_alreadyFetchedProductInventory = false;
			_productListPriceHistory = new AW.Data.CollectionClasses.ProductListPriceHistoryCollection(new ProductListPriceHistoryEntityFactory());
			_productListPriceHistory.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductListPriceHistory = false;
			_alreadyFetchedProductListPriceHistory = false;
			_productProductPhoto = new AW.Data.CollectionClasses.ProductProductPhotoCollection(new ProductProductPhotoEntityFactory());
			_productProductPhoto.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductProductPhoto = false;
			_alreadyFetchedProductProductPhoto = false;
			_productReview = new AW.Data.CollectionClasses.ProductReviewCollection(new ProductReviewEntityFactory());
			_productReview.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductReview = false;
			_alreadyFetchedProductReview = false;
			_productVendor = new AW.Data.CollectionClasses.ProductVendorCollection(new ProductVendorEntityFactory());
			_productVendor.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductVendor = false;
			_alreadyFetchedProductVendor = false;
			_purchaseOrderDetail = new AW.Data.CollectionClasses.PurchaseOrderDetailCollection(new PurchaseOrderDetailEntityFactory());
			_purchaseOrderDetail.SetContainingEntityInfo(this, "Product");
			_alwaysFetchPurchaseOrderDetail = false;
			_alreadyFetchedPurchaseOrderDetail = false;
			_shoppingCartItem = new AW.Data.CollectionClasses.ShoppingCartItemCollection(new ShoppingCartItemEntityFactory());
			_shoppingCartItem.SetContainingEntityInfo(this, "Product");
			_alwaysFetchShoppingCartItem = false;
			_alreadyFetchedShoppingCartItem = false;
			_specialOfferProducts = new AW.Data.CollectionClasses.SpecialOfferProductCollection(new SpecialOfferProductEntityFactory());
			_specialOfferProducts.SetContainingEntityInfo(this, "Product");
			_alwaysFetchSpecialOfferProducts = false;
			_alreadyFetchedSpecialOfferProducts = false;
			_transactionHistory = new AW.Data.CollectionClasses.TransactionHistoryCollection(new TransactionHistoryEntityFactory());
			_transactionHistory.SetContainingEntityInfo(this, "Product");
			_alwaysFetchTransactionHistory = false;
			_alreadyFetchedTransactionHistory = false;
			_workOrder = new AW.Data.CollectionClasses.WorkOrderCollection(new WorkOrderEntityFactory());
			_workOrder.SetContainingEntityInfo(this, "Product");
			_alwaysFetchWorkOrder = false;
			_alreadyFetchedWorkOrder = false;
			_documentCollectionViaProductDocument = new AW.Data.CollectionClasses.DocumentCollection(new DocumentEntityFactory());
			_alwaysFetchDocumentCollectionViaProductDocument = false;
			_alreadyFetchedDocumentCollectionViaProductDocument = false;
			_locationCollectionViaProductInventory = new AW.Data.CollectionClasses.LocationCollection(new LocationEntityFactory());
			_alwaysFetchLocationCollectionViaProductInventory = false;
			_alreadyFetchedLocationCollectionViaProductInventory = false;
			_productPhotoCollectionViaProductProductPhoto = new AW.Data.CollectionClasses.ProductPhotoCollection(new ProductPhotoEntityFactory());
			_alwaysFetchProductPhotoCollectionViaProductProductPhoto = false;
			_alreadyFetchedProductPhotoCollectionViaProductProductPhoto = false;
			_purchaseOrderHeaderCollectionViaPurchaseOrderDetail = new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection(new PurchaseOrderHeaderEntityFactory());
			_alwaysFetchPurchaseOrderHeaderCollectionViaPurchaseOrderDetail = false;
			_alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail = false;
			_scrapReasonCollectionViaWorkOrder = new AW.Data.CollectionClasses.ScrapReasonCollection(new ScrapReasonEntityFactory());
			_alwaysFetchScrapReasonCollectionViaWorkOrder = false;
			_alreadyFetchedScrapReasonCollectionViaWorkOrder = false;
			_specialOfferCollectionViaSpecialOfferProduct = new AW.Data.CollectionClasses.SpecialOfferCollection(new SpecialOfferEntityFactory());
			_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct = false;
			_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = false;
			_unitMeasureCollectionViaBillOfMaterials = new AW.Data.CollectionClasses.UnitMeasureCollection(new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasureCollectionViaBillOfMaterials = false;
			_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials = false;
			_unitMeasureCollectionViaBillOfMaterials_ = new AW.Data.CollectionClasses.UnitMeasureCollection(new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasureCollectionViaBillOfMaterials_ = false;
			_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_ = false;
			_unitMeasureCollectionViaProductVendor = new AW.Data.CollectionClasses.UnitMeasureCollection(new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasureCollectionViaProductVendor = false;
			_alreadyFetchedUnitMeasureCollectionViaProductVendor = false;
			_vendorCollectionViaProductVendor = new AW.Data.CollectionClasses.VendorCollection(new VendorEntityFactory());
			_alwaysFetchVendorCollectionViaProductVendor = false;
			_alreadyFetchedVendorCollectionViaProductVendor = false;
			_productModel = null;
			_productModelReturnsNewIfNotFound = true;
			_alwaysFetchProductModel = false;
			_alreadyFetchedProductModel = false;
			_productSubcategory = null;
			_productSubcategoryReturnsNewIfNotFound = true;
			_alwaysFetchProductSubcategory = false;
			_alreadyFetchedProductSubcategory = false;
			_unitMeasure = null;
			_unitMeasureReturnsNewIfNotFound = true;
			_alwaysFetchUnitMeasure = false;
			_alreadyFetchedUnitMeasure = false;
			_unitMeasure_ = null;
			_unitMeasure_ReturnsNewIfNotFound = true;
			_alwaysFetchUnitMeasure_ = false;
			_alreadyFetchedUnitMeasure_ = false;


			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			_customProperties.Add("MS_Description", @"Products sold or used in the manfacturing of sold products.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("ProductID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Name of the product.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index.");
			_fieldsCustomProperties.Add("ProductNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = Product is purchased, 1 = Product is manufactured in-house.");
			_fieldsCustomProperties.Add("MakeFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = Product is not a salable item. 1 = Product is salable.");
			_fieldsCustomProperties.Add("FinishedGoodsFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product color.");
			_fieldsCustomProperties.Add("Color", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Minimum inventory quantity. ");
			_fieldsCustomProperties.Add("SafetyStockLevel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Inventory level that triggers a purchase order or work order. ");
			_fieldsCustomProperties.Add("ReorderPoint", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Standard cost of the product.");
			_fieldsCustomProperties.Add("StandardCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Selling price.");
			_fieldsCustomProperties.Add("ListPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product size.");
			_fieldsCustomProperties.Add("Size", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unit of measure for Size column.");
			_fieldsCustomProperties.Add("SizeUnitMeasureCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unit of measure for Weight column.");
			_fieldsCustomProperties.Add("WeightUnitMeasureCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product weight.");
			_fieldsCustomProperties.Add("Weight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Number of days required to manufacture the product.");
			_fieldsCustomProperties.Add("DaysToManufacture", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"R = Road, M = Mountain, T = Touring, S = Standard");
			_fieldsCustomProperties.Add("ProductLine", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"H = High, M = Medium, L = Low");
			_fieldsCustomProperties.Add("Class", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"W = Womens, M = Mens, U = Universal");
			_fieldsCustomProperties.Add("Style", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. ");
			_fieldsCustomProperties.Add("ProductSubcategoryID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product is a member of this product model. Foreign key to ProductModel.ProductModelID.");
			_fieldsCustomProperties.Add("ProductModelID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the product was available for sale.");
			_fieldsCustomProperties.Add("SellStartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the product was no longer available for sale.");
			_fieldsCustomProperties.Add("SellEndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the product was discontinued.");
			_fieldsCustomProperties.Add("DiscontinuedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _productModel</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductModel(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _productModel, new PropertyChangedEventHandler( OnProductModelPropertyChanged ), "ProductModel", ProductEntity.Relations.ProductModelEntityUsingProductModelID, true, signalRelatedEntity, "Product", resetFKFields, new int[] { (int)ProductFieldIndex.ProductModelID } );		
			_productModel = null;
		}
		
		/// <summary> setups the sync logic for member _productModel</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductModel(IEntity relatedEntity)
		{
			if(_productModel!=relatedEntity)
			{		
				DesetupSyncProductModel(true, true);
				_productModel = (ProductModelEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _productModel, new PropertyChangedEventHandler( OnProductModelPropertyChanged ), "ProductModel", ProductEntity.Relations.ProductModelEntityUsingProductModelID, true, ref _alreadyFetchedProductModel, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductModelPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _productSubcategory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductSubcategory(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _productSubcategory, new PropertyChangedEventHandler( OnProductSubcategoryPropertyChanged ), "ProductSubcategory", ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryID, true, signalRelatedEntity, "Product", resetFKFields, new int[] { (int)ProductFieldIndex.ProductSubcategoryID } );		
			_productSubcategory = null;
		}
		
		/// <summary> setups the sync logic for member _productSubcategory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductSubcategory(IEntity relatedEntity)
		{
			if(_productSubcategory!=relatedEntity)
			{		
				DesetupSyncProductSubcategory(true, true);
				_productSubcategory = (ProductSubcategoryEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _productSubcategory, new PropertyChangedEventHandler( OnProductSubcategoryPropertyChanged ), "ProductSubcategory", ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryID, true, ref _alreadyFetchedProductSubcategory, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductSubcategoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _unitMeasure</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUnitMeasure(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", ProductEntity.Relations.UnitMeasureEntityUsingSizeUnitMeasureCode, true, signalRelatedEntity, "Product", resetFKFields, new int[] { (int)ProductFieldIndex.SizeUnitMeasureCode } );		
			_unitMeasure = null;
		}
		
		/// <summary> setups the sync logic for member _unitMeasure</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUnitMeasure(IEntity relatedEntity)
		{
			if(_unitMeasure!=relatedEntity)
			{		
				DesetupSyncUnitMeasure(true, true);
				_unitMeasure = (UnitMeasureEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", ProductEntity.Relations.UnitMeasureEntityUsingSizeUnitMeasureCode, true, ref _alreadyFetchedUnitMeasure, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUnitMeasurePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _unitMeasure_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUnitMeasure_(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _unitMeasure_, new PropertyChangedEventHandler( OnUnitMeasure_PropertyChanged ), "UnitMeasure_", ProductEntity.Relations.UnitMeasureEntityUsingWeightUnitMeasureCode, true, signalRelatedEntity, "Product_", resetFKFields, new int[] { (int)ProductFieldIndex.WeightUnitMeasureCode } );		
			_unitMeasure_ = null;
		}
		
		/// <summary> setups the sync logic for member _unitMeasure_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUnitMeasure_(IEntity relatedEntity)
		{
			if(_unitMeasure_!=relatedEntity)
			{		
				DesetupSyncUnitMeasure_(true, true);
				_unitMeasure_ = (UnitMeasureEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _unitMeasure_, new PropertyChangedEventHandler( OnUnitMeasure_PropertyChanged ), "UnitMeasure_", ProductEntity.Relations.UnitMeasureEntityUsingWeightUnitMeasureCode, true, ref _alreadyFetchedUnitMeasure_, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUnitMeasure_PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ProductFieldIndex.ProductID].ForcedCurrentValueWrite(productID);
				dao.FetchExisting(this, base.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (base.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateProductDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ProductEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductRelations Relations
		{
			get	{ return new ProductRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BillOfMaterials' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBillOfMaterials
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.BillOfMaterialsCollection(),
					(IEntityRelation)GetRelationsForField("BillOfMaterials")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.BillOfMaterialsEntity, 0, null, null, null, "BillOfMaterials", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BillOfMaterials' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBillOfMaterials_
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.BillOfMaterialsCollection(),
					(IEntityRelation)GetRelationsForField("BillOfMaterials_")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.BillOfMaterialsEntity, 0, null, null, null, "BillOfMaterials_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductCostHistory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCostHistory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCostHistoryCollection(),
					(IEntityRelation)GetRelationsForField("ProductCostHistory")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductCostHistoryEntity, 0, null, null, null, "ProductCostHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductDocument' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductDocument
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductDocumentCollection(),
					(IEntityRelation)GetRelationsForField("ProductDocument")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductDocumentEntity, 0, null, null, null, "ProductDocument", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductInventory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductInventory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductInventoryCollection(),
					(IEntityRelation)GetRelationsForField("ProductInventory")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductInventoryEntity, 0, null, null, null, "ProductInventory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductListPriceHistory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductListPriceHistory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductListPriceHistoryCollection(),
					(IEntityRelation)GetRelationsForField("ProductListPriceHistory")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductListPriceHistoryEntity, 0, null, null, null, "ProductListPriceHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductProductPhoto' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductProductPhoto
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductProductPhotoCollection(),
					(IEntityRelation)GetRelationsForField("ProductProductPhoto")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductProductPhotoEntity, 0, null, null, null, "ProductProductPhoto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductReview' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductReview
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductReviewCollection(),
					(IEntityRelation)GetRelationsForField("ProductReview")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductReviewEntity, 0, null, null, null, "ProductReview", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductVendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductVendor
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductVendorCollection(),
					(IEntityRelation)GetRelationsForField("ProductVendor")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductVendorEntity, 0, null, null, null, "ProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderDetail' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrderDetail
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderDetailCollection(),
					(IEntityRelation)GetRelationsForField("PurchaseOrderDetail")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.PurchaseOrderDetailEntity, 0, null, null, null, "PurchaseOrderDetail", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShoppingCartItem' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShoppingCartItem
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShoppingCartItemCollection(),
					(IEntityRelation)GetRelationsForField("ShoppingCartItem")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ShoppingCartItemEntity, 0, null, null, null, "ShoppingCartItem", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOfferProducts
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferProductCollection(),
					(IEntityRelation)GetRelationsForField("SpecialOfferProducts")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.SpecialOfferProductEntity, 0, null, null, null, "SpecialOfferProducts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TransactionHistory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathTransactionHistory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.TransactionHistoryCollection(),
					(IEntityRelation)GetRelationsForField("TransactionHistory")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.TransactionHistoryEntity, 0, null, null, null, "TransactionHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrder
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.WorkOrderCollection(),
					(IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.WorkOrderEntity, 0, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Document' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDocumentCollectionViaProductDocument
		{
			get
			{
				IEntityRelation intermediateRelation = ProductEntity.Relations.ProductDocumentEntityUsingProductID;
				intermediateRelation.SetAliases(string.Empty, "ProductDocument_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.DocumentCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.DocumentEntity, 0, null, null, GetRelationsForField("DocumentCollectionViaProductDocument"), "DocumentCollectionViaProductDocument", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Location' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLocationCollectionViaProductInventory
		{
			get
			{
				IEntityRelation intermediateRelation = ProductEntity.Relations.ProductInventoryEntityUsingProductID;
				intermediateRelation.SetAliases(string.Empty, "ProductInventory_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.LocationCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.LocationEntity, 0, null, null, GetRelationsForField("LocationCollectionViaProductInventory"), "LocationCollectionViaProductInventory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductPhoto' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductPhotoCollectionViaProductProductPhoto
		{
			get
			{
				IEntityRelation intermediateRelation = ProductEntity.Relations.ProductProductPhotoEntityUsingProductID;
				intermediateRelation.SetAliases(string.Empty, "ProductProductPhoto_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductPhotoCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductPhotoEntity, 0, null, null, GetRelationsForField("ProductPhotoCollectionViaProductProductPhoto"), "ProductPhotoCollectionViaProductProductPhoto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrderHeaderCollectionViaPurchaseOrderDetail
		{
			get
			{
				IEntityRelation intermediateRelation = ProductEntity.Relations.PurchaseOrderDetailEntityUsingProductID;
				intermediateRelation.SetAliases(string.Empty, "PurchaseOrderDetail_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, 0, null, null, GetRelationsForField("PurchaseOrderHeaderCollectionViaPurchaseOrderDetail"), "PurchaseOrderHeaderCollectionViaPurchaseOrderDetail", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ScrapReason' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathScrapReasonCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = ProductEntity.Relations.WorkOrderEntityUsingProductID;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ScrapReasonCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ScrapReasonEntity, 0, null, null, GetRelationsForField("ScrapReasonCollectionViaWorkOrder"), "ScrapReasonCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOffer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOfferCollectionViaSpecialOfferProduct
		{
			get
			{
				IEntityRelation intermediateRelation = ProductEntity.Relations.SpecialOfferProductEntityUsingProductID;
				intermediateRelation.SetAliases(string.Empty, "SpecialOfferProduct_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.SpecialOfferEntity, 0, null, null, GetRelationsForField("SpecialOfferCollectionViaSpecialOfferProduct"), "SpecialOfferCollectionViaSpecialOfferProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasureCollectionViaBillOfMaterials
		{
			get
			{
				IEntityRelation intermediateRelation = ProductEntity.Relations.BillOfMaterialsEntityUsingComponentID;
				intermediateRelation.SetAliases(string.Empty, "BillOfMaterials_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaBillOfMaterials"), "UnitMeasureCollectionViaBillOfMaterials", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasureCollectionViaBillOfMaterials_
		{
			get
			{
				IEntityRelation intermediateRelation = ProductEntity.Relations.BillOfMaterialsEntityUsingProductAssemblyID;
				intermediateRelation.SetAliases(string.Empty, "BillOfMaterials_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaBillOfMaterials_"), "UnitMeasureCollectionViaBillOfMaterials_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasureCollectionViaProductVendor
		{
			get
			{
				IEntityRelation intermediateRelation = ProductEntity.Relations.ProductVendorEntityUsingProductID;
				intermediateRelation.SetAliases(string.Empty, "ProductVendor_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaProductVendor"), "UnitMeasureCollectionViaProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Vendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorCollectionViaProductVendor
		{
			get
			{
				IEntityRelation intermediateRelation = ProductEntity.Relations.ProductVendorEntityUsingProductID;
				intermediateRelation.SetAliases(string.Empty, "ProductVendor_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.VendorEntity, 0, null, null, GetRelationsForField("VendorCollectionViaProductVendor"), "VendorCollectionViaProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModel' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModel
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelCollection(),
					(IEntityRelation)GetRelationsForField("ProductModel")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductModelEntity, 0, null, null, null, "ProductModel", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductSubcategory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductSubcategory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductSubcategoryCollection(),
					(IEntityRelation)GetRelationsForField("ProductSubcategory")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductSubcategoryEntity, 0, null, null, null, "ProductSubcategory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasure
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(),
					(IEntityRelation)GetRelationsForField("UnitMeasure")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, null, "UnitMeasure", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasure_
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(),
					(IEntityRelation)GetRelationsForField("UnitMeasure_")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, null, "UnitMeasure_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ProductEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ProductEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return ProductEntity.FieldsCustomProperties;}
		}

		/// <summary> The ProductID property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductID
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.ProductID, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductID, value, true); }
		}
		/// <summary> The Name property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Name of the product.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Name, true); }
			set	{ SetValue((int)ProductFieldIndex.Name, value, true); }
		}
		/// <summary> The ProductNumber property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Unique nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ProductNumber
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductNumber, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductNumber, value, true); }
		}
		/// <summary> The MakeFlag property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: 0 = Product is purchased, 1 = Product is manufactured in-house.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."MakeFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean MakeFlag
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.MakeFlag, true); }
			set	{ SetValue((int)ProductFieldIndex.MakeFlag, value, true); }
		}
		/// <summary> The FinishedGoodsFlag property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: 0 = Product is not a salable item. 1 = Product is salable.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."FinishedGoodsFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean FinishedGoodsFlag
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.FinishedGoodsFlag, true); }
			set	{ SetValue((int)ProductFieldIndex.FinishedGoodsFlag, value, true); }
		}
		/// <summary> The Color property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Product color.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Color"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Color
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Color, true); }
			set	{ SetValue((int)ProductFieldIndex.Color, value, true); }
		}
		/// <summary> The SafetyStockLevel property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Minimum inventory quantity. <br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SafetyStockLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 SafetyStockLevel
		{
			get { return (System.Int16)GetValue((int)ProductFieldIndex.SafetyStockLevel, true); }
			set	{ SetValue((int)ProductFieldIndex.SafetyStockLevel, value, true); }
		}
		/// <summary> The ReorderPoint property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Inventory level that triggers a purchase order or work order. <br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ReorderPoint"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 ReorderPoint
		{
			get { return (System.Int16)GetValue((int)ProductFieldIndex.ReorderPoint, true); }
			set	{ SetValue((int)ProductFieldIndex.ReorderPoint, value, true); }
		}
		/// <summary> The StandardCost property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Standard cost of the product.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."StandardCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal StandardCost
		{
			get { return (System.Decimal)GetValue((int)ProductFieldIndex.StandardCost, true); }
			set	{ SetValue((int)ProductFieldIndex.StandardCost, value, true); }
		}
		/// <summary> The ListPrice property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Selling price.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ListPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ListPrice
		{
			get { return (System.Decimal)GetValue((int)ProductFieldIndex.ListPrice, true); }
			set	{ SetValue((int)ProductFieldIndex.ListPrice, value, true); }
		}
		/// <summary> The Size property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Product size.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Size"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Size
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Size, true); }
			set	{ SetValue((int)ProductFieldIndex.Size, value, true); }
		}
		/// <summary> The SizeUnitMeasureCode property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Unit of measure for Size column.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SizeUnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String SizeUnitMeasureCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.SizeUnitMeasureCode, true); }
			set	{ SetValue((int)ProductFieldIndex.SizeUnitMeasureCode, value, true); }
		}
		/// <summary> The WeightUnitMeasureCode property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Unit of measure for Weight column.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."WeightUnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String WeightUnitMeasureCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.WeightUnitMeasureCode, true); }
			set	{ SetValue((int)ProductFieldIndex.WeightUnitMeasureCode, value, true); }
		}
		/// <summary> The Weight property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Product weight.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Weight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Weight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductFieldIndex.Weight, false); }
			set	{ SetValue((int)ProductFieldIndex.Weight, value, true); }
		}
		/// <summary> The DaysToManufacture property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Number of days required to manufacture the product.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."DaysToManufacture"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DaysToManufacture
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.DaysToManufacture, true); }
			set	{ SetValue((int)ProductFieldIndex.DaysToManufacture, value, true); }
		}
		/// <summary> The ProductLine property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: R = Road, M = Mountain, T = Touring, S = Standard<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductLine"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ProductLine
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductLine, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductLine, value, true); }
		}
		/// <summary> The Class property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: H = High, M = Medium, L = Low<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Class"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Class
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Class, true); }
			set	{ SetValue((int)ProductFieldIndex.Class, value, true); }
		}
		/// <summary> The Style property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: W = Womens, M = Mens, U = Universal<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Style"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Style
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Style, true); }
			set	{ SetValue((int)ProductFieldIndex.Style, value, true); }
		}
		/// <summary> The ProductSubcategoryID property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. <br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductSubcategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductSubcategoryID
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.ProductSubcategoryID, false); }
			set	{ SetValue((int)ProductFieldIndex.ProductSubcategoryID, value, true); }
		}
		/// <summary> The ProductModelID property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Product is a member of this product model. Foreign key to ProductModel.ProductModelID.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductModelID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductModelID
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.ProductModelID, false); }
			set	{ SetValue((int)ProductFieldIndex.ProductModelID, value, true); }
		}
		/// <summary> The SellStartDate property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Date the product was available for sale.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SellStartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime SellStartDate
		{
			get { return (System.DateTime)GetValue((int)ProductFieldIndex.SellStartDate, true); }
			set	{ SetValue((int)ProductFieldIndex.SellStartDate, value, true); }
		}
		/// <summary> The SellEndDate property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Date the product was no longer available for sale.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SellEndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> SellEndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.SellEndDate, false); }
			set	{ SetValue((int)ProductFieldIndex.SellEndDate, value, true); }
		}
		/// <summary> The DiscontinuedDate property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Date the product was discontinued.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."DiscontinuedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DiscontinuedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.DiscontinuedDate, false); }
			set	{ SetValue((int)ProductFieldIndex.DiscontinuedDate, value, true); }
		}
		/// <summary> The Rowguid property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Product<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBillOfMaterials()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.BillOfMaterialsCollection BillOfMaterials
		{
			get	{ return GetMultiBillOfMaterials(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for BillOfMaterials. When set to true, BillOfMaterials is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BillOfMaterials is accessed. You can always execute
		/// a forced fetch by calling GetMultiBillOfMaterials(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBillOfMaterials
		{
			get	{ return _alwaysFetchBillOfMaterials; }
			set	{ _alwaysFetchBillOfMaterials = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property BillOfMaterials already has been fetched. Setting this property to false when BillOfMaterials has been fetched
		/// will clear the BillOfMaterials collection well. Setting this property to true while BillOfMaterials hasn't been fetched disables lazy loading for BillOfMaterials</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBillOfMaterials
		{
			get { return _alreadyFetchedBillOfMaterials;}
			set 
			{
				if(_alreadyFetchedBillOfMaterials && !value && (_billOfMaterials != null))
				{
					_billOfMaterials.Clear();
				}
				_alreadyFetchedBillOfMaterials = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBillOfMaterials_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.BillOfMaterialsCollection BillOfMaterials_
		{
			get	{ return GetMultiBillOfMaterials_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for BillOfMaterials_. When set to true, BillOfMaterials_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BillOfMaterials_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiBillOfMaterials_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBillOfMaterials_
		{
			get	{ return _alwaysFetchBillOfMaterials_; }
			set	{ _alwaysFetchBillOfMaterials_ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property BillOfMaterials_ already has been fetched. Setting this property to false when BillOfMaterials_ has been fetched
		/// will clear the BillOfMaterials_ collection well. Setting this property to true while BillOfMaterials_ hasn't been fetched disables lazy loading for BillOfMaterials_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBillOfMaterials_
		{
			get { return _alreadyFetchedBillOfMaterials_;}
			set 
			{
				if(_alreadyFetchedBillOfMaterials_ && !value && (_billOfMaterials_ != null))
				{
					_billOfMaterials_.Clear();
				}
				_alreadyFetchedBillOfMaterials_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductCostHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCostHistoryCollection ProductCostHistory
		{
			get	{ return GetMultiProductCostHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCostHistory. When set to true, ProductCostHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCostHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductCostHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCostHistory
		{
			get	{ return _alwaysFetchProductCostHistory; }
			set	{ _alwaysFetchProductCostHistory = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductCostHistory already has been fetched. Setting this property to false when ProductCostHistory has been fetched
		/// will clear the ProductCostHistory collection well. Setting this property to true while ProductCostHistory hasn't been fetched disables lazy loading for ProductCostHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductCostHistory
		{
			get { return _alreadyFetchedProductCostHistory;}
			set 
			{
				if(_alreadyFetchedProductCostHistory && !value && (_productCostHistory != null))
				{
					_productCostHistory.Clear();
				}
				_alreadyFetchedProductCostHistory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductDocument()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductDocumentCollection ProductDocument
		{
			get	{ return GetMultiProductDocument(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductDocument. When set to true, ProductDocument is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductDocument is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductDocument(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductDocument
		{
			get	{ return _alwaysFetchProductDocument; }
			set	{ _alwaysFetchProductDocument = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductDocument already has been fetched. Setting this property to false when ProductDocument has been fetched
		/// will clear the ProductDocument collection well. Setting this property to true while ProductDocument hasn't been fetched disables lazy loading for ProductDocument</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductDocument
		{
			get { return _alreadyFetchedProductDocument;}
			set 
			{
				if(_alreadyFetchedProductDocument && !value && (_productDocument != null))
				{
					_productDocument.Clear();
				}
				_alreadyFetchedProductDocument = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductInventory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductInventoryCollection ProductInventory
		{
			get	{ return GetMultiProductInventory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductInventory. When set to true, ProductInventory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductInventory is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductInventory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductInventory
		{
			get	{ return _alwaysFetchProductInventory; }
			set	{ _alwaysFetchProductInventory = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductInventory already has been fetched. Setting this property to false when ProductInventory has been fetched
		/// will clear the ProductInventory collection well. Setting this property to true while ProductInventory hasn't been fetched disables lazy loading for ProductInventory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductInventory
		{
			get { return _alreadyFetchedProductInventory;}
			set 
			{
				if(_alreadyFetchedProductInventory && !value && (_productInventory != null))
				{
					_productInventory.Clear();
				}
				_alreadyFetchedProductInventory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductListPriceHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductListPriceHistoryCollection ProductListPriceHistory
		{
			get	{ return GetMultiProductListPriceHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductListPriceHistory. When set to true, ProductListPriceHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductListPriceHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductListPriceHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductListPriceHistory
		{
			get	{ return _alwaysFetchProductListPriceHistory; }
			set	{ _alwaysFetchProductListPriceHistory = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductListPriceHistory already has been fetched. Setting this property to false when ProductListPriceHistory has been fetched
		/// will clear the ProductListPriceHistory collection well. Setting this property to true while ProductListPriceHistory hasn't been fetched disables lazy loading for ProductListPriceHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductListPriceHistory
		{
			get { return _alreadyFetchedProductListPriceHistory;}
			set 
			{
				if(_alreadyFetchedProductListPriceHistory && !value && (_productListPriceHistory != null))
				{
					_productListPriceHistory.Clear();
				}
				_alreadyFetchedProductListPriceHistory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductProductPhoto()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductProductPhotoCollection ProductProductPhoto
		{
			get	{ return GetMultiProductProductPhoto(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductProductPhoto. When set to true, ProductProductPhoto is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductProductPhoto is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductProductPhoto(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductProductPhoto
		{
			get	{ return _alwaysFetchProductProductPhoto; }
			set	{ _alwaysFetchProductProductPhoto = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductProductPhoto already has been fetched. Setting this property to false when ProductProductPhoto has been fetched
		/// will clear the ProductProductPhoto collection well. Setting this property to true while ProductProductPhoto hasn't been fetched disables lazy loading for ProductProductPhoto</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductProductPhoto
		{
			get { return _alreadyFetchedProductProductPhoto;}
			set 
			{
				if(_alreadyFetchedProductProductPhoto && !value && (_productProductPhoto != null))
				{
					_productProductPhoto.Clear();
				}
				_alreadyFetchedProductProductPhoto = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductReview()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductReviewCollection ProductReview
		{
			get	{ return GetMultiProductReview(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductReview. When set to true, ProductReview is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductReview is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductReview(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductReview
		{
			get	{ return _alwaysFetchProductReview; }
			set	{ _alwaysFetchProductReview = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductReview already has been fetched. Setting this property to false when ProductReview has been fetched
		/// will clear the ProductReview collection well. Setting this property to true while ProductReview hasn't been fetched disables lazy loading for ProductReview</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductReview
		{
			get { return _alreadyFetchedProductReview;}
			set 
			{
				if(_alreadyFetchedProductReview && !value && (_productReview != null))
				{
					_productReview.Clear();
				}
				_alreadyFetchedProductReview = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductVendorCollection ProductVendor
		{
			get	{ return GetMultiProductVendor(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductVendor. When set to true, ProductVendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductVendor is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductVendor(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductVendor
		{
			get	{ return _alwaysFetchProductVendor; }
			set	{ _alwaysFetchProductVendor = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductVendor already has been fetched. Setting this property to false when ProductVendor has been fetched
		/// will clear the ProductVendor collection well. Setting this property to true while ProductVendor hasn't been fetched disables lazy loading for ProductVendor</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductVendor
		{
			get { return _alreadyFetchedProductVendor;}
			set 
			{
				if(_alreadyFetchedProductVendor && !value && (_productVendor != null))
				{
					_productVendor.Clear();
				}
				_alreadyFetchedProductVendor = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.PurchaseOrderDetailCollection PurchaseOrderDetail
		{
			get	{ return GetMultiPurchaseOrderDetail(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrderDetail. When set to true, PurchaseOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderDetail is accessed. You can always execute
		/// a forced fetch by calling GetMultiPurchaseOrderDetail(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderDetail
		{
			get	{ return _alwaysFetchPurchaseOrderDetail; }
			set	{ _alwaysFetchPurchaseOrderDetail = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrderDetail already has been fetched. Setting this property to false when PurchaseOrderDetail has been fetched
		/// will clear the PurchaseOrderDetail collection well. Setting this property to true while PurchaseOrderDetail hasn't been fetched disables lazy loading for PurchaseOrderDetail</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrderDetail
		{
			get { return _alreadyFetchedPurchaseOrderDetail;}
			set 
			{
				if(_alreadyFetchedPurchaseOrderDetail && !value && (_purchaseOrderDetail != null))
				{
					_purchaseOrderDetail.Clear();
				}
				_alreadyFetchedPurchaseOrderDetail = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShoppingCartItem()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ShoppingCartItemCollection ShoppingCartItem
		{
			get	{ return GetMultiShoppingCartItem(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ShoppingCartItem. When set to true, ShoppingCartItem is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShoppingCartItem is accessed. You can always execute
		/// a forced fetch by calling GetMultiShoppingCartItem(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShoppingCartItem
		{
			get	{ return _alwaysFetchShoppingCartItem; }
			set	{ _alwaysFetchShoppingCartItem = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShoppingCartItem already has been fetched. Setting this property to false when ShoppingCartItem has been fetched
		/// will clear the ShoppingCartItem collection well. Setting this property to true while ShoppingCartItem hasn't been fetched disables lazy loading for ShoppingCartItem</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShoppingCartItem
		{
			get { return _alreadyFetchedShoppingCartItem;}
			set 
			{
				if(_alreadyFetchedShoppingCartItem && !value && (_shoppingCartItem != null))
				{
					_shoppingCartItem.Clear();
				}
				_alreadyFetchedShoppingCartItem = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOfferProducts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SpecialOfferProductCollection SpecialOfferProducts
		{
			get	{ return GetMultiSpecialOfferProducts(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOfferProducts. When set to true, SpecialOfferProducts is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferProducts is accessed. You can always execute
		/// a forced fetch by calling GetMultiSpecialOfferProducts(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOfferProducts
		{
			get	{ return _alwaysFetchSpecialOfferProducts; }
			set	{ _alwaysFetchSpecialOfferProducts = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SpecialOfferProducts already has been fetched. Setting this property to false when SpecialOfferProducts has been fetched
		/// will clear the SpecialOfferProducts collection well. Setting this property to true while SpecialOfferProducts hasn't been fetched disables lazy loading for SpecialOfferProducts</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSpecialOfferProducts
		{
			get { return _alreadyFetchedSpecialOfferProducts;}
			set 
			{
				if(_alreadyFetchedSpecialOfferProducts && !value && (_specialOfferProducts != null))
				{
					_specialOfferProducts.Clear();
				}
				_alreadyFetchedSpecialOfferProducts = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTransactionHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.TransactionHistoryCollection TransactionHistory
		{
			get	{ return GetMultiTransactionHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for TransactionHistory. When set to true, TransactionHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time TransactionHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiTransactionHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchTransactionHistory
		{
			get	{ return _alwaysFetchTransactionHistory; }
			set	{ _alwaysFetchTransactionHistory = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property TransactionHistory already has been fetched. Setting this property to false when TransactionHistory has been fetched
		/// will clear the TransactionHistory collection well. Setting this property to true while TransactionHistory hasn't been fetched disables lazy loading for TransactionHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedTransactionHistory
		{
			get { return _alreadyFetchedTransactionHistory;}
			set 
			{
				if(_alreadyFetchedTransactionHistory && !value && (_transactionHistory != null))
				{
					_transactionHistory.Clear();
				}
				_alreadyFetchedTransactionHistory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.WorkOrderCollection WorkOrder
		{
			get	{ return GetMultiWorkOrder(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrder. When set to true, WorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrder is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrder(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrder
		{
			get	{ return _alwaysFetchWorkOrder; }
			set	{ _alwaysFetchWorkOrder = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrder already has been fetched. Setting this property to false when WorkOrder has been fetched
		/// will clear the WorkOrder collection well. Setting this property to true while WorkOrder hasn't been fetched disables lazy loading for WorkOrder</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrder
		{
			get { return _alreadyFetchedWorkOrder;}
			set 
			{
				if(_alreadyFetchedWorkOrder && !value && (_workOrder != null))
				{
					_workOrder.Clear();
				}
				_alreadyFetchedWorkOrder = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'DocumentEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDocumentCollectionViaProductDocument()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.DocumentCollection DocumentCollectionViaProductDocument
		{
			get { return GetMultiDocumentCollectionViaProductDocument(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DocumentCollectionViaProductDocument. When set to true, DocumentCollectionViaProductDocument is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DocumentCollectionViaProductDocument is accessed. You can always execute
		/// a forced fetch by calling GetMultiDocumentCollectionViaProductDocument(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDocumentCollectionViaProductDocument
		{
			get	{ return _alwaysFetchDocumentCollectionViaProductDocument; }
			set	{ _alwaysFetchDocumentCollectionViaProductDocument = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property DocumentCollectionViaProductDocument already has been fetched. Setting this property to false when DocumentCollectionViaProductDocument has been fetched
		/// will clear the DocumentCollectionViaProductDocument collection well. Setting this property to true while DocumentCollectionViaProductDocument hasn't been fetched disables lazy loading for DocumentCollectionViaProductDocument</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDocumentCollectionViaProductDocument
		{
			get { return _alreadyFetchedDocumentCollectionViaProductDocument;}
			set 
			{
				if(_alreadyFetchedDocumentCollectionViaProductDocument && !value && (_documentCollectionViaProductDocument != null))
				{
					_documentCollectionViaProductDocument.Clear();
				}
				_alreadyFetchedDocumentCollectionViaProductDocument = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'LocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiLocationCollectionViaProductInventory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.LocationCollection LocationCollectionViaProductInventory
		{
			get { return GetMultiLocationCollectionViaProductInventory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for LocationCollectionViaProductInventory. When set to true, LocationCollectionViaProductInventory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time LocationCollectionViaProductInventory is accessed. You can always execute
		/// a forced fetch by calling GetMultiLocationCollectionViaProductInventory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchLocationCollectionViaProductInventory
		{
			get	{ return _alwaysFetchLocationCollectionViaProductInventory; }
			set	{ _alwaysFetchLocationCollectionViaProductInventory = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property LocationCollectionViaProductInventory already has been fetched. Setting this property to false when LocationCollectionViaProductInventory has been fetched
		/// will clear the LocationCollectionViaProductInventory collection well. Setting this property to true while LocationCollectionViaProductInventory hasn't been fetched disables lazy loading for LocationCollectionViaProductInventory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedLocationCollectionViaProductInventory
		{
			get { return _alreadyFetchedLocationCollectionViaProductInventory;}
			set 
			{
				if(_alreadyFetchedLocationCollectionViaProductInventory && !value && (_locationCollectionViaProductInventory != null))
				{
					_locationCollectionViaProductInventory.Clear();
				}
				_alreadyFetchedLocationCollectionViaProductInventory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductPhotoEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductPhotoCollectionViaProductProductPhoto()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductPhotoCollection ProductPhotoCollectionViaProductProductPhoto
		{
			get { return GetMultiProductPhotoCollectionViaProductProductPhoto(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductPhotoCollectionViaProductProductPhoto. When set to true, ProductPhotoCollectionViaProductProductPhoto is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductPhotoCollectionViaProductProductPhoto is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductPhotoCollectionViaProductProductPhoto(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductPhotoCollectionViaProductProductPhoto
		{
			get	{ return _alwaysFetchProductPhotoCollectionViaProductProductPhoto; }
			set	{ _alwaysFetchProductPhotoCollectionViaProductProductPhoto = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductPhotoCollectionViaProductProductPhoto already has been fetched. Setting this property to false when ProductPhotoCollectionViaProductProductPhoto has been fetched
		/// will clear the ProductPhotoCollectionViaProductProductPhoto collection well. Setting this property to true while ProductPhotoCollectionViaProductProductPhoto hasn't been fetched disables lazy loading for ProductPhotoCollectionViaProductProductPhoto</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductPhotoCollectionViaProductProductPhoto
		{
			get { return _alreadyFetchedProductPhotoCollectionViaProductProductPhoto;}
			set 
			{
				if(_alreadyFetchedProductPhotoCollectionViaProductProductPhoto && !value && (_productPhotoCollectionViaProductProductPhoto != null))
				{
					_productPhotoCollectionViaProductProductPhoto.Clear();
				}
				_alreadyFetchedProductPhotoCollectionViaProductProductPhoto = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderHeaderCollectionViaPurchaseOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.PurchaseOrderHeaderCollection PurchaseOrderHeaderCollectionViaPurchaseOrderDetail
		{
			get { return GetMultiPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrderHeaderCollectionViaPurchaseOrderDetail. When set to true, PurchaseOrderHeaderCollectionViaPurchaseOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderHeaderCollectionViaPurchaseOrderDetail is accessed. You can always execute
		/// a forced fetch by calling GetMultiPurchaseOrderHeaderCollectionViaPurchaseOrderDetail(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderHeaderCollectionViaPurchaseOrderDetail
		{
			get	{ return _alwaysFetchPurchaseOrderHeaderCollectionViaPurchaseOrderDetail; }
			set	{ _alwaysFetchPurchaseOrderHeaderCollectionViaPurchaseOrderDetail = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrderHeaderCollectionViaPurchaseOrderDetail already has been fetched. Setting this property to false when PurchaseOrderHeaderCollectionViaPurchaseOrderDetail has been fetched
		/// will clear the PurchaseOrderHeaderCollectionViaPurchaseOrderDetail collection well. Setting this property to true while PurchaseOrderHeaderCollectionViaPurchaseOrderDetail hasn't been fetched disables lazy loading for PurchaseOrderHeaderCollectionViaPurchaseOrderDetail</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail
		{
			get { return _alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail;}
			set 
			{
				if(_alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail && !value && (_purchaseOrderHeaderCollectionViaPurchaseOrderDetail != null))
				{
					_purchaseOrderHeaderCollectionViaPurchaseOrderDetail.Clear();
				}
				_alreadyFetchedPurchaseOrderHeaderCollectionViaPurchaseOrderDetail = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ScrapReasonEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiScrapReasonCollectionViaWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ScrapReasonCollection ScrapReasonCollectionViaWorkOrder
		{
			get { return GetMultiScrapReasonCollectionViaWorkOrder(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ScrapReasonCollectionViaWorkOrder. When set to true, ScrapReasonCollectionViaWorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ScrapReasonCollectionViaWorkOrder is accessed. You can always execute
		/// a forced fetch by calling GetMultiScrapReasonCollectionViaWorkOrder(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchScrapReasonCollectionViaWorkOrder
		{
			get	{ return _alwaysFetchScrapReasonCollectionViaWorkOrder; }
			set	{ _alwaysFetchScrapReasonCollectionViaWorkOrder = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ScrapReasonCollectionViaWorkOrder already has been fetched. Setting this property to false when ScrapReasonCollectionViaWorkOrder has been fetched
		/// will clear the ScrapReasonCollectionViaWorkOrder collection well. Setting this property to true while ScrapReasonCollectionViaWorkOrder hasn't been fetched disables lazy loading for ScrapReasonCollectionViaWorkOrder</summary>
		[Browsable(false)]
		public bool AlreadyFetchedScrapReasonCollectionViaWorkOrder
		{
			get { return _alreadyFetchedScrapReasonCollectionViaWorkOrder;}
			set 
			{
				if(_alreadyFetchedScrapReasonCollectionViaWorkOrder && !value && (_scrapReasonCollectionViaWorkOrder != null))
				{
					_scrapReasonCollectionViaWorkOrder.Clear();
				}
				_alreadyFetchedScrapReasonCollectionViaWorkOrder = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SpecialOfferEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOfferCollectionViaSpecialOfferProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SpecialOfferCollection SpecialOfferCollectionViaSpecialOfferProduct
		{
			get { return GetMultiSpecialOfferCollectionViaSpecialOfferProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOfferCollectionViaSpecialOfferProduct. When set to true, SpecialOfferCollectionViaSpecialOfferProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferCollectionViaSpecialOfferProduct is accessed. You can always execute
		/// a forced fetch by calling GetMultiSpecialOfferCollectionViaSpecialOfferProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOfferCollectionViaSpecialOfferProduct
		{
			get	{ return _alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct; }
			set	{ _alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SpecialOfferCollectionViaSpecialOfferProduct already has been fetched. Setting this property to false when SpecialOfferCollectionViaSpecialOfferProduct has been fetched
		/// will clear the SpecialOfferCollectionViaSpecialOfferProduct collection well. Setting this property to true while SpecialOfferCollectionViaSpecialOfferProduct hasn't been fetched disables lazy loading for SpecialOfferCollectionViaSpecialOfferProduct</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct
		{
			get { return _alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct;}
			set 
			{
				if(_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct && !value && (_specialOfferCollectionViaSpecialOfferProduct != null))
				{
					_specialOfferCollectionViaSpecialOfferProduct.Clear();
				}
				_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasureCollectionViaBillOfMaterials()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.UnitMeasureCollection UnitMeasureCollectionViaBillOfMaterials
		{
			get { return GetMultiUnitMeasureCollectionViaBillOfMaterials(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasureCollectionViaBillOfMaterials. When set to true, UnitMeasureCollectionViaBillOfMaterials is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasureCollectionViaBillOfMaterials is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasureCollectionViaBillOfMaterials(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasureCollectionViaBillOfMaterials
		{
			get	{ return _alwaysFetchUnitMeasureCollectionViaBillOfMaterials; }
			set	{ _alwaysFetchUnitMeasureCollectionViaBillOfMaterials = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UnitMeasureCollectionViaBillOfMaterials already has been fetched. Setting this property to false when UnitMeasureCollectionViaBillOfMaterials has been fetched
		/// will clear the UnitMeasureCollectionViaBillOfMaterials collection well. Setting this property to true while UnitMeasureCollectionViaBillOfMaterials hasn't been fetched disables lazy loading for UnitMeasureCollectionViaBillOfMaterials</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUnitMeasureCollectionViaBillOfMaterials
		{
			get { return _alreadyFetchedUnitMeasureCollectionViaBillOfMaterials;}
			set 
			{
				if(_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials && !value && (_unitMeasureCollectionViaBillOfMaterials != null))
				{
					_unitMeasureCollectionViaBillOfMaterials.Clear();
				}
				_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasureCollectionViaBillOfMaterials_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.UnitMeasureCollection UnitMeasureCollectionViaBillOfMaterials_
		{
			get { return GetMultiUnitMeasureCollectionViaBillOfMaterials_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasureCollectionViaBillOfMaterials_. When set to true, UnitMeasureCollectionViaBillOfMaterials_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasureCollectionViaBillOfMaterials_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasureCollectionViaBillOfMaterials_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasureCollectionViaBillOfMaterials_
		{
			get	{ return _alwaysFetchUnitMeasureCollectionViaBillOfMaterials_; }
			set	{ _alwaysFetchUnitMeasureCollectionViaBillOfMaterials_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UnitMeasureCollectionViaBillOfMaterials_ already has been fetched. Setting this property to false when UnitMeasureCollectionViaBillOfMaterials_ has been fetched
		/// will clear the UnitMeasureCollectionViaBillOfMaterials_ collection well. Setting this property to true while UnitMeasureCollectionViaBillOfMaterials_ hasn't been fetched disables lazy loading for UnitMeasureCollectionViaBillOfMaterials_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUnitMeasureCollectionViaBillOfMaterials_
		{
			get { return _alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_;}
			set 
			{
				if(_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_ && !value && (_unitMeasureCollectionViaBillOfMaterials_ != null))
				{
					_unitMeasureCollectionViaBillOfMaterials_.Clear();
				}
				_alreadyFetchedUnitMeasureCollectionViaBillOfMaterials_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasureCollectionViaProductVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.UnitMeasureCollection UnitMeasureCollectionViaProductVendor
		{
			get { return GetMultiUnitMeasureCollectionViaProductVendor(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasureCollectionViaProductVendor. When set to true, UnitMeasureCollectionViaProductVendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasureCollectionViaProductVendor is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasureCollectionViaProductVendor(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasureCollectionViaProductVendor
		{
			get	{ return _alwaysFetchUnitMeasureCollectionViaProductVendor; }
			set	{ _alwaysFetchUnitMeasureCollectionViaProductVendor = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UnitMeasureCollectionViaProductVendor already has been fetched. Setting this property to false when UnitMeasureCollectionViaProductVendor has been fetched
		/// will clear the UnitMeasureCollectionViaProductVendor collection well. Setting this property to true while UnitMeasureCollectionViaProductVendor hasn't been fetched disables lazy loading for UnitMeasureCollectionViaProductVendor</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUnitMeasureCollectionViaProductVendor
		{
			get { return _alreadyFetchedUnitMeasureCollectionViaProductVendor;}
			set 
			{
				if(_alreadyFetchedUnitMeasureCollectionViaProductVendor && !value && (_unitMeasureCollectionViaProductVendor != null))
				{
					_unitMeasureCollectionViaProductVendor.Clear();
				}
				_alreadyFetchedUnitMeasureCollectionViaProductVendor = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorCollectionViaProductVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorCollection VendorCollectionViaProductVendor
		{
			get { return GetMultiVendorCollectionViaProductVendor(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorCollectionViaProductVendor. When set to true, VendorCollectionViaProductVendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorCollectionViaProductVendor is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorCollectionViaProductVendor(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorCollectionViaProductVendor
		{
			get	{ return _alwaysFetchVendorCollectionViaProductVendor; }
			set	{ _alwaysFetchVendorCollectionViaProductVendor = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorCollectionViaProductVendor already has been fetched. Setting this property to false when VendorCollectionViaProductVendor has been fetched
		/// will clear the VendorCollectionViaProductVendor collection well. Setting this property to true while VendorCollectionViaProductVendor hasn't been fetched disables lazy loading for VendorCollectionViaProductVendor</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorCollectionViaProductVendor
		{
			get { return _alreadyFetchedVendorCollectionViaProductVendor;}
			set 
			{
				if(_alreadyFetchedVendorCollectionViaProductVendor && !value && (_vendorCollectionViaProductVendor != null))
				{
					_vendorCollectionViaProductVendor.Clear();
				}
				_alreadyFetchedVendorCollectionViaProductVendor = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'ProductModelEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductModel()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductModelEntity ProductModel
		{
			get	{ return GetSingleProductModel(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProductModel(value);
				}
				else
				{
					if(value==null)
					{
						if(_productModel != null)
						{
							_productModel.UnsetRelatedEntity(this, "Product");
						}
					}
					else
					{
						if(_productModel!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Product");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModel. When set to true, ProductModel is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModel is accessed. You can always execute
		/// a forced fetch by calling GetSingleProductModel(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModel
		{
			get	{ return _alwaysFetchProductModel; }
			set	{ _alwaysFetchProductModel = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModel already has been fetched. Setting this property to false when ProductModel has been fetched
		/// will set ProductModel to null as well. Setting this property to true while ProductModel hasn't been fetched disables lazy loading for ProductModel</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModel
		{
			get { return _alreadyFetchedProductModel;}
			set 
			{
				if(_alreadyFetchedProductModel && !value)
				{
					this.ProductModel = null;
				}
				_alreadyFetchedProductModel = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ProductModel is not found
		/// in the database. When set to true, ProductModel will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ProductModelReturnsNewIfNotFound
		{
			get	{ return _productModelReturnsNewIfNotFound; }
			set { _productModelReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ProductSubcategoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductSubcategory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductSubcategoryEntity ProductSubcategory
		{
			get	{ return GetSingleProductSubcategory(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProductSubcategory(value);
				}
				else
				{
					if(value==null)
					{
						if(_productSubcategory != null)
						{
							_productSubcategory.UnsetRelatedEntity(this, "Product");
						}
					}
					else
					{
						if(_productSubcategory!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Product");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ProductSubcategory. When set to true, ProductSubcategory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductSubcategory is accessed. You can always execute
		/// a forced fetch by calling GetSingleProductSubcategory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductSubcategory
		{
			get	{ return _alwaysFetchProductSubcategory; }
			set	{ _alwaysFetchProductSubcategory = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductSubcategory already has been fetched. Setting this property to false when ProductSubcategory has been fetched
		/// will set ProductSubcategory to null as well. Setting this property to true while ProductSubcategory hasn't been fetched disables lazy loading for ProductSubcategory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductSubcategory
		{
			get { return _alreadyFetchedProductSubcategory;}
			set 
			{
				if(_alreadyFetchedProductSubcategory && !value)
				{
					this.ProductSubcategory = null;
				}
				_alreadyFetchedProductSubcategory = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ProductSubcategory is not found
		/// in the database. When set to true, ProductSubcategory will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ProductSubcategoryReturnsNewIfNotFound
		{
			get	{ return _productSubcategoryReturnsNewIfNotFound; }
			set { _productSubcategoryReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'UnitMeasureEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUnitMeasure()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UnitMeasureEntity UnitMeasure
		{
			get	{ return GetSingleUnitMeasure(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncUnitMeasure(value);
				}
				else
				{
					if(value==null)
					{
						if(_unitMeasure != null)
						{
							_unitMeasure.UnsetRelatedEntity(this, "Product");
						}
					}
					else
					{
						if(_unitMeasure!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Product");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasure. When set to true, UnitMeasure is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure is accessed. You can always execute
		/// a forced fetch by calling GetSingleUnitMeasure(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasure
		{
			get	{ return _alwaysFetchUnitMeasure; }
			set	{ _alwaysFetchUnitMeasure = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UnitMeasure already has been fetched. Setting this property to false when UnitMeasure has been fetched
		/// will set UnitMeasure to null as well. Setting this property to true while UnitMeasure hasn't been fetched disables lazy loading for UnitMeasure</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUnitMeasure
		{
			get { return _alreadyFetchedUnitMeasure;}
			set 
			{
				if(_alreadyFetchedUnitMeasure && !value)
				{
					this.UnitMeasure = null;
				}
				_alreadyFetchedUnitMeasure = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property UnitMeasure is not found
		/// in the database. When set to true, UnitMeasure will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool UnitMeasureReturnsNewIfNotFound
		{
			get	{ return _unitMeasureReturnsNewIfNotFound; }
			set { _unitMeasureReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'UnitMeasureEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUnitMeasure_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UnitMeasureEntity UnitMeasure_
		{
			get	{ return GetSingleUnitMeasure_(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncUnitMeasure_(value);
				}
				else
				{
					if(value==null)
					{
						if(_unitMeasure_ != null)
						{
							_unitMeasure_.UnsetRelatedEntity(this, "Product_");
						}
					}
					else
					{
						if(_unitMeasure_!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Product_");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasure_. When set to true, UnitMeasure_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure_ is accessed. You can always execute
		/// a forced fetch by calling GetSingleUnitMeasure_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasure_
		{
			get	{ return _alwaysFetchUnitMeasure_; }
			set	{ _alwaysFetchUnitMeasure_ = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UnitMeasure_ already has been fetched. Setting this property to false when UnitMeasure_ has been fetched
		/// will set UnitMeasure_ to null as well. Setting this property to true while UnitMeasure_ hasn't been fetched disables lazy loading for UnitMeasure_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUnitMeasure_
		{
			get { return _alreadyFetchedUnitMeasure_;}
			set 
			{
				if(_alreadyFetchedUnitMeasure_ && !value)
				{
					this.UnitMeasure_ = null;
				}
				_alreadyFetchedUnitMeasure_ = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property UnitMeasure_ is not found
		/// in the database. When set to true, UnitMeasure_ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool UnitMeasure_ReturnsNewIfNotFound
		{
			get	{ return _unitMeasure_ReturnsNewIfNotFound; }
			set { _unitMeasure_ReturnsNewIfNotFound = value; }	
		}



		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the AW.Data.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AW.Data.EntityType.ProductEntity; }
		}
		#endregion

		
		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
