///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
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

	/// <summary>Entity class which represents the entity 'Product'. <br/><br/>
	/// 
	/// MS_Description: Products sold or used in the manfacturing of sold products.<br/>
	/// </summary>
	[Serializable]
	public partial class ProductEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces

		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.BillOfMaterialCollection	_billOfComponentMaterials;
		private bool	_alwaysFetchBillOfComponentMaterials, _alreadyFetchedBillOfComponentMaterials;
		private AW.Data.CollectionClasses.BillOfMaterialCollection	_billOfAssemblyMaterials;
		private bool	_alwaysFetchBillOfAssemblyMaterials, _alreadyFetchedBillOfAssemblyMaterials;
		private AW.Data.CollectionClasses.ProductCostHistoryCollection	_productCostHistories;
		private bool	_alwaysFetchProductCostHistories, _alreadyFetchedProductCostHistories;
		private AW.Data.CollectionClasses.ProductDocumentCollection	_productDocuments;
		private bool	_alwaysFetchProductDocuments, _alreadyFetchedProductDocuments;
		private AW.Data.CollectionClasses.ProductInventoryCollection	_productInventories;
		private bool	_alwaysFetchProductInventories, _alreadyFetchedProductInventories;
		private AW.Data.CollectionClasses.ProductListPriceHistoryCollection	_productListPriceHistories;
		private bool	_alwaysFetchProductListPriceHistories, _alreadyFetchedProductListPriceHistories;
		private AW.Data.CollectionClasses.ProductProductPhotoCollection	_productProductPhotos;
		private bool	_alwaysFetchProductProductPhotos, _alreadyFetchedProductProductPhotos;
		private AW.Data.CollectionClasses.ProductReviewCollection	_productReviews;
		private bool	_alwaysFetchProductReviews, _alreadyFetchedProductReviews;
		private AW.Data.CollectionClasses.TransactionHistoryCollection	_transactionHistories;
		private bool	_alwaysFetchTransactionHistories, _alreadyFetchedTransactionHistories;
		private AW.Data.CollectionClasses.WorkOrderCollection	_workOrders;
		private bool	_alwaysFetchWorkOrders, _alreadyFetchedWorkOrders;
		private AW.Data.CollectionClasses.ProductVendorCollection	_productVendors;
		private bool	_alwaysFetchProductVendors, _alreadyFetchedProductVendors;
		private AW.Data.CollectionClasses.PurchaseOrderDetailCollection	_purchaseOrderDetails;
		private bool	_alwaysFetchPurchaseOrderDetails, _alreadyFetchedPurchaseOrderDetails;
		private AW.Data.CollectionClasses.ShoppingCartItemCollection	_shoppingCartItems;
		private bool	_alwaysFetchShoppingCartItems, _alreadyFetchedShoppingCartItems;
		private AW.Data.CollectionClasses.SpecialOfferProductCollection	_specialOfferProducts;
		private bool	_alwaysFetchSpecialOfferProducts, _alreadyFetchedSpecialOfferProducts;
		private ProductModelEntity _productModel;
		private bool	_alwaysFetchProductModel, _alreadyFetchedProductModel, _productModelReturnsNewIfNotFound;
		private ProductSubcategoryEntity _productSubcategory;
		private bool	_alwaysFetchProductSubcategory, _alreadyFetchedProductSubcategory, _productSubcategoryReturnsNewIfNotFound;
		private UnitMeasureEntity _sizeUnitMeasure;
		private bool	_alwaysFetchSizeUnitMeasure, _alreadyFetchedSizeUnitMeasure, _sizeUnitMeasureReturnsNewIfNotFound;
		private UnitMeasureEntity _weightUnitMeasure;
		private bool	_alwaysFetchWeightUnitMeasure, _alreadyFetchedWeightUnitMeasure, _weightUnitMeasureReturnsNewIfNotFound;

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
			/// <summary>Member name SizeUnitMeasure</summary>
			public static readonly string SizeUnitMeasure = "SizeUnitMeasure";
			/// <summary>Member name WeightUnitMeasure</summary>
			public static readonly string WeightUnitMeasure = "WeightUnitMeasure";
			/// <summary>Member name BillOfComponentMaterials</summary>
			public static readonly string BillOfComponentMaterials = "BillOfComponentMaterials";
			/// <summary>Member name BillOfAssemblyMaterials</summary>
			public static readonly string BillOfAssemblyMaterials = "BillOfAssemblyMaterials";
			/// <summary>Member name ProductCostHistories</summary>
			public static readonly string ProductCostHistories = "ProductCostHistories";
			/// <summary>Member name ProductDocuments</summary>
			public static readonly string ProductDocuments = "ProductDocuments";
			/// <summary>Member name ProductInventories</summary>
			public static readonly string ProductInventories = "ProductInventories";
			/// <summary>Member name ProductListPriceHistories</summary>
			public static readonly string ProductListPriceHistories = "ProductListPriceHistories";
			/// <summary>Member name ProductProductPhotos</summary>
			public static readonly string ProductProductPhotos = "ProductProductPhotos";
			/// <summary>Member name ProductReviews</summary>
			public static readonly string ProductReviews = "ProductReviews";
			/// <summary>Member name TransactionHistories</summary>
			public static readonly string TransactionHistories = "TransactionHistories";
			/// <summary>Member name WorkOrders</summary>
			public static readonly string WorkOrders = "WorkOrders";
			/// <summary>Member name ProductVendors</summary>
			public static readonly string ProductVendors = "ProductVendors";
			/// <summary>Member name PurchaseOrderDetails</summary>
			public static readonly string PurchaseOrderDetails = "PurchaseOrderDetails";
			/// <summary>Member name ShoppingCartItems</summary>
			public static readonly string ShoppingCartItems = "ShoppingCartItems";
			/// <summary>Member name SpecialOfferProducts</summary>
			public static readonly string SpecialOfferProducts = "SpecialOfferProducts";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		public ProductEntity(System.Int32 productID)
		{
			InitClassFetch(productID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductEntity(System.Int32 productID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(productID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntity(System.Int32 productID, IValidator validator)
		{
			InitClassFetch(productID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_billOfComponentMaterials = (AW.Data.CollectionClasses.BillOfMaterialCollection)info.GetValue("_billOfComponentMaterials", typeof(AW.Data.CollectionClasses.BillOfMaterialCollection));
			_alwaysFetchBillOfComponentMaterials = info.GetBoolean("_alwaysFetchBillOfComponentMaterials");
			_alreadyFetchedBillOfComponentMaterials = info.GetBoolean("_alreadyFetchedBillOfComponentMaterials");

			_billOfAssemblyMaterials = (AW.Data.CollectionClasses.BillOfMaterialCollection)info.GetValue("_billOfAssemblyMaterials", typeof(AW.Data.CollectionClasses.BillOfMaterialCollection));
			_alwaysFetchBillOfAssemblyMaterials = info.GetBoolean("_alwaysFetchBillOfAssemblyMaterials");
			_alreadyFetchedBillOfAssemblyMaterials = info.GetBoolean("_alreadyFetchedBillOfAssemblyMaterials");

			_productCostHistories = (AW.Data.CollectionClasses.ProductCostHistoryCollection)info.GetValue("_productCostHistories", typeof(AW.Data.CollectionClasses.ProductCostHistoryCollection));
			_alwaysFetchProductCostHistories = info.GetBoolean("_alwaysFetchProductCostHistories");
			_alreadyFetchedProductCostHistories = info.GetBoolean("_alreadyFetchedProductCostHistories");

			_productDocuments = (AW.Data.CollectionClasses.ProductDocumentCollection)info.GetValue("_productDocuments", typeof(AW.Data.CollectionClasses.ProductDocumentCollection));
			_alwaysFetchProductDocuments = info.GetBoolean("_alwaysFetchProductDocuments");
			_alreadyFetchedProductDocuments = info.GetBoolean("_alreadyFetchedProductDocuments");

			_productInventories = (AW.Data.CollectionClasses.ProductInventoryCollection)info.GetValue("_productInventories", typeof(AW.Data.CollectionClasses.ProductInventoryCollection));
			_alwaysFetchProductInventories = info.GetBoolean("_alwaysFetchProductInventories");
			_alreadyFetchedProductInventories = info.GetBoolean("_alreadyFetchedProductInventories");

			_productListPriceHistories = (AW.Data.CollectionClasses.ProductListPriceHistoryCollection)info.GetValue("_productListPriceHistories", typeof(AW.Data.CollectionClasses.ProductListPriceHistoryCollection));
			_alwaysFetchProductListPriceHistories = info.GetBoolean("_alwaysFetchProductListPriceHistories");
			_alreadyFetchedProductListPriceHistories = info.GetBoolean("_alreadyFetchedProductListPriceHistories");

			_productProductPhotos = (AW.Data.CollectionClasses.ProductProductPhotoCollection)info.GetValue("_productProductPhotos", typeof(AW.Data.CollectionClasses.ProductProductPhotoCollection));
			_alwaysFetchProductProductPhotos = info.GetBoolean("_alwaysFetchProductProductPhotos");
			_alreadyFetchedProductProductPhotos = info.GetBoolean("_alreadyFetchedProductProductPhotos");

			_productReviews = (AW.Data.CollectionClasses.ProductReviewCollection)info.GetValue("_productReviews", typeof(AW.Data.CollectionClasses.ProductReviewCollection));
			_alwaysFetchProductReviews = info.GetBoolean("_alwaysFetchProductReviews");
			_alreadyFetchedProductReviews = info.GetBoolean("_alreadyFetchedProductReviews");

			_transactionHistories = (AW.Data.CollectionClasses.TransactionHistoryCollection)info.GetValue("_transactionHistories", typeof(AW.Data.CollectionClasses.TransactionHistoryCollection));
			_alwaysFetchTransactionHistories = info.GetBoolean("_alwaysFetchTransactionHistories");
			_alreadyFetchedTransactionHistories = info.GetBoolean("_alreadyFetchedTransactionHistories");

			_workOrders = (AW.Data.CollectionClasses.WorkOrderCollection)info.GetValue("_workOrders", typeof(AW.Data.CollectionClasses.WorkOrderCollection));
			_alwaysFetchWorkOrders = info.GetBoolean("_alwaysFetchWorkOrders");
			_alreadyFetchedWorkOrders = info.GetBoolean("_alreadyFetchedWorkOrders");

			_productVendors = (AW.Data.CollectionClasses.ProductVendorCollection)info.GetValue("_productVendors", typeof(AW.Data.CollectionClasses.ProductVendorCollection));
			_alwaysFetchProductVendors = info.GetBoolean("_alwaysFetchProductVendors");
			_alreadyFetchedProductVendors = info.GetBoolean("_alreadyFetchedProductVendors");

			_purchaseOrderDetails = (AW.Data.CollectionClasses.PurchaseOrderDetailCollection)info.GetValue("_purchaseOrderDetails", typeof(AW.Data.CollectionClasses.PurchaseOrderDetailCollection));
			_alwaysFetchPurchaseOrderDetails = info.GetBoolean("_alwaysFetchPurchaseOrderDetails");
			_alreadyFetchedPurchaseOrderDetails = info.GetBoolean("_alreadyFetchedPurchaseOrderDetails");

			_shoppingCartItems = (AW.Data.CollectionClasses.ShoppingCartItemCollection)info.GetValue("_shoppingCartItems", typeof(AW.Data.CollectionClasses.ShoppingCartItemCollection));
			_alwaysFetchShoppingCartItems = info.GetBoolean("_alwaysFetchShoppingCartItems");
			_alreadyFetchedShoppingCartItems = info.GetBoolean("_alreadyFetchedShoppingCartItems");

			_specialOfferProducts = (AW.Data.CollectionClasses.SpecialOfferProductCollection)info.GetValue("_specialOfferProducts", typeof(AW.Data.CollectionClasses.SpecialOfferProductCollection));
			_alwaysFetchSpecialOfferProducts = info.GetBoolean("_alwaysFetchSpecialOfferProducts");
			_alreadyFetchedSpecialOfferProducts = info.GetBoolean("_alreadyFetchedSpecialOfferProducts");
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

			_sizeUnitMeasure = (UnitMeasureEntity)info.GetValue("_sizeUnitMeasure", typeof(UnitMeasureEntity));
			if(_sizeUnitMeasure!=null)
			{
				_sizeUnitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_sizeUnitMeasureReturnsNewIfNotFound = info.GetBoolean("_sizeUnitMeasureReturnsNewIfNotFound");
			_alwaysFetchSizeUnitMeasure = info.GetBoolean("_alwaysFetchSizeUnitMeasure");
			_alreadyFetchedSizeUnitMeasure = info.GetBoolean("_alreadyFetchedSizeUnitMeasure");

			_weightUnitMeasure = (UnitMeasureEntity)info.GetValue("_weightUnitMeasure", typeof(UnitMeasureEntity));
			if(_weightUnitMeasure!=null)
			{
				_weightUnitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_weightUnitMeasureReturnsNewIfNotFound = info.GetBoolean("_weightUnitMeasureReturnsNewIfNotFound");
			_alwaysFetchWeightUnitMeasure = info.GetBoolean("_alwaysFetchWeightUnitMeasure");
			_alreadyFetchedWeightUnitMeasure = info.GetBoolean("_alreadyFetchedWeightUnitMeasure");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ProductFieldIndex)fieldIndex)
			{
				case ProductFieldIndex.ProductModelID:
					DesetupSyncProductModel(true, false);
					_alreadyFetchedProductModel = false;
					break;
				case ProductFieldIndex.ProductSubcategoryID:
					DesetupSyncProductSubcategory(true, false);
					_alreadyFetchedProductSubcategory = false;
					break;
				case ProductFieldIndex.SizeUnitMeasureCode:
					DesetupSyncSizeUnitMeasure(true, false);
					_alreadyFetchedSizeUnitMeasure = false;
					break;
				case ProductFieldIndex.WeightUnitMeasureCode:
					DesetupSyncWeightUnitMeasure(true, false);
					_alreadyFetchedWeightUnitMeasure = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedBillOfComponentMaterials = (_billOfComponentMaterials.Count > 0);
			_alreadyFetchedBillOfAssemblyMaterials = (_billOfAssemblyMaterials.Count > 0);
			_alreadyFetchedProductCostHistories = (_productCostHistories.Count > 0);
			_alreadyFetchedProductDocuments = (_productDocuments.Count > 0);
			_alreadyFetchedProductInventories = (_productInventories.Count > 0);
			_alreadyFetchedProductListPriceHistories = (_productListPriceHistories.Count > 0);
			_alreadyFetchedProductProductPhotos = (_productProductPhotos.Count > 0);
			_alreadyFetchedProductReviews = (_productReviews.Count > 0);
			_alreadyFetchedTransactionHistories = (_transactionHistories.Count > 0);
			_alreadyFetchedWorkOrders = (_workOrders.Count > 0);
			_alreadyFetchedProductVendors = (_productVendors.Count > 0);
			_alreadyFetchedPurchaseOrderDetails = (_purchaseOrderDetails.Count > 0);
			_alreadyFetchedShoppingCartItems = (_shoppingCartItems.Count > 0);
			_alreadyFetchedSpecialOfferProducts = (_specialOfferProducts.Count > 0);
			_alreadyFetchedProductModel = (_productModel != null);
			_alreadyFetchedProductSubcategory = (_productSubcategory != null);
			_alreadyFetchedSizeUnitMeasure = (_sizeUnitMeasure != null);
			_alreadyFetchedWeightUnitMeasure = (_weightUnitMeasure != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ProductModel":
					toReturn.Add(Relations.ProductModelEntityUsingProductModelID);
					break;
				case "ProductSubcategory":
					toReturn.Add(Relations.ProductSubcategoryEntityUsingProductSubcategoryID);
					break;
				case "SizeUnitMeasure":
					toReturn.Add(Relations.UnitMeasureEntityUsingSizeUnitMeasureCode);
					break;
				case "WeightUnitMeasure":
					toReturn.Add(Relations.UnitMeasureEntityUsingWeightUnitMeasureCode);
					break;
				case "BillOfComponentMaterials":
					toReturn.Add(Relations.BillOfMaterialEntityUsingComponentID);
					break;
				case "BillOfAssemblyMaterials":
					toReturn.Add(Relations.BillOfMaterialEntityUsingProductAssemblyID);
					break;
				case "ProductCostHistories":
					toReturn.Add(Relations.ProductCostHistoryEntityUsingProductID);
					break;
				case "ProductDocuments":
					toReturn.Add(Relations.ProductDocumentEntityUsingProductID);
					break;
				case "ProductInventories":
					toReturn.Add(Relations.ProductInventoryEntityUsingProductID);
					break;
				case "ProductListPriceHistories":
					toReturn.Add(Relations.ProductListPriceHistoryEntityUsingProductID);
					break;
				case "ProductProductPhotos":
					toReturn.Add(Relations.ProductProductPhotoEntityUsingProductID);
					break;
				case "ProductReviews":
					toReturn.Add(Relations.ProductReviewEntityUsingProductID);
					break;
				case "TransactionHistories":
					toReturn.Add(Relations.TransactionHistoryEntityUsingProductID);
					break;
				case "WorkOrders":
					toReturn.Add(Relations.WorkOrderEntityUsingProductID);
					break;
				case "ProductVendors":
					toReturn.Add(Relations.ProductVendorEntityUsingProductID);
					break;
				case "PurchaseOrderDetails":
					toReturn.Add(Relations.PurchaseOrderDetailEntityUsingProductID);
					break;
				case "ShoppingCartItems":
					toReturn.Add(Relations.ShoppingCartItemEntityUsingProductID);
					break;
				case "SpecialOfferProducts":
					toReturn.Add(Relations.SpecialOfferProductEntityUsingProductID);
					break;
				default:
					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_billOfComponentMaterials", (!this.MarkedForDeletion?_billOfComponentMaterials:null));
			info.AddValue("_alwaysFetchBillOfComponentMaterials", _alwaysFetchBillOfComponentMaterials);
			info.AddValue("_alreadyFetchedBillOfComponentMaterials", _alreadyFetchedBillOfComponentMaterials);
			info.AddValue("_billOfAssemblyMaterials", (!this.MarkedForDeletion?_billOfAssemblyMaterials:null));
			info.AddValue("_alwaysFetchBillOfAssemblyMaterials", _alwaysFetchBillOfAssemblyMaterials);
			info.AddValue("_alreadyFetchedBillOfAssemblyMaterials", _alreadyFetchedBillOfAssemblyMaterials);
			info.AddValue("_productCostHistories", (!this.MarkedForDeletion?_productCostHistories:null));
			info.AddValue("_alwaysFetchProductCostHistories", _alwaysFetchProductCostHistories);
			info.AddValue("_alreadyFetchedProductCostHistories", _alreadyFetchedProductCostHistories);
			info.AddValue("_productDocuments", (!this.MarkedForDeletion?_productDocuments:null));
			info.AddValue("_alwaysFetchProductDocuments", _alwaysFetchProductDocuments);
			info.AddValue("_alreadyFetchedProductDocuments", _alreadyFetchedProductDocuments);
			info.AddValue("_productInventories", (!this.MarkedForDeletion?_productInventories:null));
			info.AddValue("_alwaysFetchProductInventories", _alwaysFetchProductInventories);
			info.AddValue("_alreadyFetchedProductInventories", _alreadyFetchedProductInventories);
			info.AddValue("_productListPriceHistories", (!this.MarkedForDeletion?_productListPriceHistories:null));
			info.AddValue("_alwaysFetchProductListPriceHistories", _alwaysFetchProductListPriceHistories);
			info.AddValue("_alreadyFetchedProductListPriceHistories", _alreadyFetchedProductListPriceHistories);
			info.AddValue("_productProductPhotos", (!this.MarkedForDeletion?_productProductPhotos:null));
			info.AddValue("_alwaysFetchProductProductPhotos", _alwaysFetchProductProductPhotos);
			info.AddValue("_alreadyFetchedProductProductPhotos", _alreadyFetchedProductProductPhotos);
			info.AddValue("_productReviews", (!this.MarkedForDeletion?_productReviews:null));
			info.AddValue("_alwaysFetchProductReviews", _alwaysFetchProductReviews);
			info.AddValue("_alreadyFetchedProductReviews", _alreadyFetchedProductReviews);
			info.AddValue("_transactionHistories", (!this.MarkedForDeletion?_transactionHistories:null));
			info.AddValue("_alwaysFetchTransactionHistories", _alwaysFetchTransactionHistories);
			info.AddValue("_alreadyFetchedTransactionHistories", _alreadyFetchedTransactionHistories);
			info.AddValue("_workOrders", (!this.MarkedForDeletion?_workOrders:null));
			info.AddValue("_alwaysFetchWorkOrders", _alwaysFetchWorkOrders);
			info.AddValue("_alreadyFetchedWorkOrders", _alreadyFetchedWorkOrders);
			info.AddValue("_productVendors", (!this.MarkedForDeletion?_productVendors:null));
			info.AddValue("_alwaysFetchProductVendors", _alwaysFetchProductVendors);
			info.AddValue("_alreadyFetchedProductVendors", _alreadyFetchedProductVendors);
			info.AddValue("_purchaseOrderDetails", (!this.MarkedForDeletion?_purchaseOrderDetails:null));
			info.AddValue("_alwaysFetchPurchaseOrderDetails", _alwaysFetchPurchaseOrderDetails);
			info.AddValue("_alreadyFetchedPurchaseOrderDetails", _alreadyFetchedPurchaseOrderDetails);
			info.AddValue("_shoppingCartItems", (!this.MarkedForDeletion?_shoppingCartItems:null));
			info.AddValue("_alwaysFetchShoppingCartItems", _alwaysFetchShoppingCartItems);
			info.AddValue("_alreadyFetchedShoppingCartItems", _alreadyFetchedShoppingCartItems);
			info.AddValue("_specialOfferProducts", (!this.MarkedForDeletion?_specialOfferProducts:null));
			info.AddValue("_alwaysFetchSpecialOfferProducts", _alwaysFetchSpecialOfferProducts);
			info.AddValue("_alreadyFetchedSpecialOfferProducts", _alreadyFetchedSpecialOfferProducts);
			info.AddValue("_productModel", (!this.MarkedForDeletion?_productModel:null));
			info.AddValue("_productModelReturnsNewIfNotFound", _productModelReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProductModel", _alwaysFetchProductModel);
			info.AddValue("_alreadyFetchedProductModel", _alreadyFetchedProductModel);
			info.AddValue("_productSubcategory", (!this.MarkedForDeletion?_productSubcategory:null));
			info.AddValue("_productSubcategoryReturnsNewIfNotFound", _productSubcategoryReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProductSubcategory", _alwaysFetchProductSubcategory);
			info.AddValue("_alreadyFetchedProductSubcategory", _alreadyFetchedProductSubcategory);
			info.AddValue("_sizeUnitMeasure", (!this.MarkedForDeletion?_sizeUnitMeasure:null));
			info.AddValue("_sizeUnitMeasureReturnsNewIfNotFound", _sizeUnitMeasureReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchSizeUnitMeasure", _alwaysFetchSizeUnitMeasure);
			info.AddValue("_alreadyFetchedSizeUnitMeasure", _alreadyFetchedSizeUnitMeasure);
			info.AddValue("_weightUnitMeasure", (!this.MarkedForDeletion?_weightUnitMeasure:null));
			info.AddValue("_weightUnitMeasureReturnsNewIfNotFound", _weightUnitMeasureReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchWeightUnitMeasure", _alwaysFetchWeightUnitMeasure);
			info.AddValue("_alreadyFetchedWeightUnitMeasure", _alreadyFetchedWeightUnitMeasure);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntity entity)
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
				case "SizeUnitMeasure":
					_alreadyFetchedSizeUnitMeasure = true;
					this.SizeUnitMeasure = (UnitMeasureEntity)entity;
					break;
				case "WeightUnitMeasure":
					_alreadyFetchedWeightUnitMeasure = true;
					this.WeightUnitMeasure = (UnitMeasureEntity)entity;
					break;
				case "BillOfComponentMaterials":
					_alreadyFetchedBillOfComponentMaterials = true;
					if(entity!=null)
					{
						this.BillOfComponentMaterials.Add((BillOfMaterialEntity)entity);
					}
					break;
				case "BillOfAssemblyMaterials":
					_alreadyFetchedBillOfAssemblyMaterials = true;
					if(entity!=null)
					{
						this.BillOfAssemblyMaterials.Add((BillOfMaterialEntity)entity);
					}
					break;
				case "ProductCostHistories":
					_alreadyFetchedProductCostHistories = true;
					if(entity!=null)
					{
						this.ProductCostHistories.Add((ProductCostHistoryEntity)entity);
					}
					break;
				case "ProductDocuments":
					_alreadyFetchedProductDocuments = true;
					if(entity!=null)
					{
						this.ProductDocuments.Add((ProductDocumentEntity)entity);
					}
					break;
				case "ProductInventories":
					_alreadyFetchedProductInventories = true;
					if(entity!=null)
					{
						this.ProductInventories.Add((ProductInventoryEntity)entity);
					}
					break;
				case "ProductListPriceHistories":
					_alreadyFetchedProductListPriceHistories = true;
					if(entity!=null)
					{
						this.ProductListPriceHistories.Add((ProductListPriceHistoryEntity)entity);
					}
					break;
				case "ProductProductPhotos":
					_alreadyFetchedProductProductPhotos = true;
					if(entity!=null)
					{
						this.ProductProductPhotos.Add((ProductProductPhotoEntity)entity);
					}
					break;
				case "ProductReviews":
					_alreadyFetchedProductReviews = true;
					if(entity!=null)
					{
						this.ProductReviews.Add((ProductReviewEntity)entity);
					}
					break;
				case "TransactionHistories":
					_alreadyFetchedTransactionHistories = true;
					if(entity!=null)
					{
						this.TransactionHistories.Add((TransactionHistoryEntity)entity);
					}
					break;
				case "WorkOrders":
					_alreadyFetchedWorkOrders = true;
					if(entity!=null)
					{
						this.WorkOrders.Add((WorkOrderEntity)entity);
					}
					break;
				case "ProductVendors":
					_alreadyFetchedProductVendors = true;
					if(entity!=null)
					{
						this.ProductVendors.Add((ProductVendorEntity)entity);
					}
					break;
				case "PurchaseOrderDetails":
					_alreadyFetchedPurchaseOrderDetails = true;
					if(entity!=null)
					{
						this.PurchaseOrderDetails.Add((PurchaseOrderDetailEntity)entity);
					}
					break;
				case "ShoppingCartItems":
					_alreadyFetchedShoppingCartItems = true;
					if(entity!=null)
					{
						this.ShoppingCartItems.Add((ShoppingCartItemEntity)entity);
					}
					break;
				case "SpecialOfferProducts":
					_alreadyFetchedSpecialOfferProducts = true;
					if(entity!=null)
					{
						this.SpecialOfferProducts.Add((SpecialOfferProductEntity)entity);
					}
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "ProductModel":
					SetupSyncProductModel(relatedEntity);
					break;
				case "ProductSubcategory":
					SetupSyncProductSubcategory(relatedEntity);
					break;
				case "SizeUnitMeasure":
					SetupSyncSizeUnitMeasure(relatedEntity);
					break;
				case "WeightUnitMeasure":
					SetupSyncWeightUnitMeasure(relatedEntity);
					break;
				case "BillOfComponentMaterials":
					_billOfComponentMaterials.Add((BillOfMaterialEntity)relatedEntity);
					break;
				case "BillOfAssemblyMaterials":
					_billOfAssemblyMaterials.Add((BillOfMaterialEntity)relatedEntity);
					break;
				case "ProductCostHistories":
					_productCostHistories.Add((ProductCostHistoryEntity)relatedEntity);
					break;
				case "ProductDocuments":
					_productDocuments.Add((ProductDocumentEntity)relatedEntity);
					break;
				case "ProductInventories":
					_productInventories.Add((ProductInventoryEntity)relatedEntity);
					break;
				case "ProductListPriceHistories":
					_productListPriceHistories.Add((ProductListPriceHistoryEntity)relatedEntity);
					break;
				case "ProductProductPhotos":
					_productProductPhotos.Add((ProductProductPhotoEntity)relatedEntity);
					break;
				case "ProductReviews":
					_productReviews.Add((ProductReviewEntity)relatedEntity);
					break;
				case "TransactionHistories":
					_transactionHistories.Add((TransactionHistoryEntity)relatedEntity);
					break;
				case "WorkOrders":
					_workOrders.Add((WorkOrderEntity)relatedEntity);
					break;
				case "ProductVendors":
					_productVendors.Add((ProductVendorEntity)relatedEntity);
					break;
				case "PurchaseOrderDetails":
					_purchaseOrderDetails.Add((PurchaseOrderDetailEntity)relatedEntity);
					break;
				case "ShoppingCartItems":
					_shoppingCartItems.Add((ShoppingCartItemEntity)relatedEntity);
					break;
				case "SpecialOfferProducts":
					_specialOfferProducts.Add((SpecialOfferProductEntity)relatedEntity);
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
		protected override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "ProductModel":
					DesetupSyncProductModel(false, true);
					break;
				case "ProductSubcategory":
					DesetupSyncProductSubcategory(false, true);
					break;
				case "SizeUnitMeasure":
					DesetupSyncSizeUnitMeasure(false, true);
					break;
				case "WeightUnitMeasure":
					DesetupSyncWeightUnitMeasure(false, true);
					break;
				case "BillOfComponentMaterials":
					this.PerformRelatedEntityRemoval(_billOfComponentMaterials, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BillOfAssemblyMaterials":
					this.PerformRelatedEntityRemoval(_billOfAssemblyMaterials, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductCostHistories":
					this.PerformRelatedEntityRemoval(_productCostHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductDocuments":
					this.PerformRelatedEntityRemoval(_productDocuments, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductInventories":
					this.PerformRelatedEntityRemoval(_productInventories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductListPriceHistories":
					this.PerformRelatedEntityRemoval(_productListPriceHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductProductPhotos":
					this.PerformRelatedEntityRemoval(_productProductPhotos, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductReviews":
					this.PerformRelatedEntityRemoval(_productReviews, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "TransactionHistories":
					this.PerformRelatedEntityRemoval(_transactionHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrders":
					this.PerformRelatedEntityRemoval(_workOrders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductVendors":
					this.PerformRelatedEntityRemoval(_productVendors, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PurchaseOrderDetails":
					this.PerformRelatedEntityRemoval(_purchaseOrderDetails, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ShoppingCartItems":
					this.PerformRelatedEntityRemoval(_shoppingCartItems, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SpecialOfferProducts":
					this.PerformRelatedEntityRemoval(_specialOfferProducts, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependentRelatedEntities()
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
			if(_sizeUnitMeasure!=null)
			{
				toReturn.Add(_sizeUnitMeasure);
			}
			if(_weightUnitMeasure!=null)
			{
				toReturn.Add(_weightUnitMeasure);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_billOfComponentMaterials);
			toReturn.Add(_billOfAssemblyMaterials);
			toReturn.Add(_productCostHistories);
			toReturn.Add(_productDocuments);
			toReturn.Add(_productInventories);
			toReturn.Add(_productListPriceHistories);
			toReturn.Add(_productProductPhotos);
			toReturn.Add(_productReviews);
			toReturn.Add(_transactionHistories);
			toReturn.Add(_workOrders);
			toReturn.Add(_productVendors);
			toReturn.Add(_purchaseOrderDetails);
			toReturn.Add(_shoppingCartItems);
			toReturn.Add(_specialOfferProducts);

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
			return FetchUsingPK(productID, prefetchPathToUse, contextToUse, null);
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

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialEntity'</returns>
		public AW.Data.CollectionClasses.BillOfMaterialCollection GetMultiBillOfComponentMaterials(bool forceFetch)
		{
			return GetMultiBillOfComponentMaterials(forceFetch, _billOfComponentMaterials.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialEntity'</returns>
		public AW.Data.CollectionClasses.BillOfMaterialCollection GetMultiBillOfComponentMaterials(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiBillOfComponentMaterials(forceFetch, _billOfComponentMaterials.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.BillOfMaterialCollection GetMultiBillOfComponentMaterials(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiBillOfComponentMaterials(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.BillOfMaterialCollection GetMultiBillOfComponentMaterials(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBillOfComponentMaterials || forceFetch || _alwaysFetchBillOfComponentMaterials) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_billOfComponentMaterials);
				_billOfComponentMaterials.SuppressClearInGetMulti=!forceFetch;
				_billOfComponentMaterials.EntityFactoryToUse = entityFactoryToUse;
				_billOfComponentMaterials.GetMultiManyToOne(this, null, null, filter);
				_billOfComponentMaterials.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfComponentMaterials = true;
			}
			return _billOfComponentMaterials;
		}

		/// <summary> Sets the collection parameters for the collection for 'BillOfComponentMaterials'. These settings will be taken into account
		/// when the property BillOfComponentMaterials is requested or GetMultiBillOfComponentMaterials is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBillOfComponentMaterials(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_billOfComponentMaterials.SortClauses=sortClauses;
			_billOfComponentMaterials.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialEntity'</returns>
		public AW.Data.CollectionClasses.BillOfMaterialCollection GetMultiBillOfAssemblyMaterials(bool forceFetch)
		{
			return GetMultiBillOfAssemblyMaterials(forceFetch, _billOfAssemblyMaterials.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialEntity'</returns>
		public AW.Data.CollectionClasses.BillOfMaterialCollection GetMultiBillOfAssemblyMaterials(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiBillOfAssemblyMaterials(forceFetch, _billOfAssemblyMaterials.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.BillOfMaterialCollection GetMultiBillOfAssemblyMaterials(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiBillOfAssemblyMaterials(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.BillOfMaterialCollection GetMultiBillOfAssemblyMaterials(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBillOfAssemblyMaterials || forceFetch || _alwaysFetchBillOfAssemblyMaterials) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_billOfAssemblyMaterials);
				_billOfAssemblyMaterials.SuppressClearInGetMulti=!forceFetch;
				_billOfAssemblyMaterials.EntityFactoryToUse = entityFactoryToUse;
				_billOfAssemblyMaterials.GetMultiManyToOne(null, this, null, filter);
				_billOfAssemblyMaterials.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfAssemblyMaterials = true;
			}
			return _billOfAssemblyMaterials;
		}

		/// <summary> Sets the collection parameters for the collection for 'BillOfAssemblyMaterials'. These settings will be taken into account
		/// when the property BillOfAssemblyMaterials is requested or GetMultiBillOfAssemblyMaterials is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBillOfAssemblyMaterials(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_billOfAssemblyMaterials.SortClauses=sortClauses;
			_billOfAssemblyMaterials.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductCostHistoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductCostHistoryCollection GetMultiProductCostHistories(bool forceFetch)
		{
			return GetMultiProductCostHistories(forceFetch, _productCostHistories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductCostHistoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductCostHistoryCollection GetMultiProductCostHistories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductCostHistories(forceFetch, _productCostHistories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCostHistoryCollection GetMultiProductCostHistories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductCostHistories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductCostHistoryCollection GetMultiProductCostHistories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductCostHistories || forceFetch || _alwaysFetchProductCostHistories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productCostHistories);
				_productCostHistories.SuppressClearInGetMulti=!forceFetch;
				_productCostHistories.EntityFactoryToUse = entityFactoryToUse;
				_productCostHistories.GetMultiManyToOne(this, filter);
				_productCostHistories.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCostHistories = true;
			}
			return _productCostHistories;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductCostHistories'. These settings will be taken into account
		/// when the property ProductCostHistories is requested or GetMultiProductCostHistories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductCostHistories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productCostHistories.SortClauses=sortClauses;
			_productCostHistories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductDocumentEntity'</returns>
		public AW.Data.CollectionClasses.ProductDocumentCollection GetMultiProductDocuments(bool forceFetch)
		{
			return GetMultiProductDocuments(forceFetch, _productDocuments.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductDocumentEntity'</returns>
		public AW.Data.CollectionClasses.ProductDocumentCollection GetMultiProductDocuments(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductDocuments(forceFetch, _productDocuments.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductDocumentCollection GetMultiProductDocuments(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductDocuments(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductDocumentCollection GetMultiProductDocuments(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductDocuments || forceFetch || _alwaysFetchProductDocuments) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productDocuments);
				_productDocuments.SuppressClearInGetMulti=!forceFetch;
				_productDocuments.EntityFactoryToUse = entityFactoryToUse;
				_productDocuments.GetMultiManyToOne(null, this, filter);
				_productDocuments.SuppressClearInGetMulti=false;
				_alreadyFetchedProductDocuments = true;
			}
			return _productDocuments;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductDocuments'. These settings will be taken into account
		/// when the property ProductDocuments is requested or GetMultiProductDocuments is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductDocuments(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productDocuments.SortClauses=sortClauses;
			_productDocuments.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductInventoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventories(bool forceFetch)
		{
			return GetMultiProductInventories(forceFetch, _productInventories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductInventoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductInventories(forceFetch, _productInventories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductInventories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductInventoryCollection GetMultiProductInventories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductInventories || forceFetch || _alwaysFetchProductInventories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productInventories);
				_productInventories.SuppressClearInGetMulti=!forceFetch;
				_productInventories.EntityFactoryToUse = entityFactoryToUse;
				_productInventories.GetMultiManyToOne(null, this, filter);
				_productInventories.SuppressClearInGetMulti=false;
				_alreadyFetchedProductInventories = true;
			}
			return _productInventories;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductInventories'. These settings will be taken into account
		/// when the property ProductInventories is requested or GetMultiProductInventories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductInventories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productInventories.SortClauses=sortClauses;
			_productInventories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductListPriceHistoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductListPriceHistoryCollection GetMultiProductListPriceHistories(bool forceFetch)
		{
			return GetMultiProductListPriceHistories(forceFetch, _productListPriceHistories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductListPriceHistoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductListPriceHistoryCollection GetMultiProductListPriceHistories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductListPriceHistories(forceFetch, _productListPriceHistories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductListPriceHistoryCollection GetMultiProductListPriceHistories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductListPriceHistories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductListPriceHistoryCollection GetMultiProductListPriceHistories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductListPriceHistories || forceFetch || _alwaysFetchProductListPriceHistories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productListPriceHistories);
				_productListPriceHistories.SuppressClearInGetMulti=!forceFetch;
				_productListPriceHistories.EntityFactoryToUse = entityFactoryToUse;
				_productListPriceHistories.GetMultiManyToOne(this, filter);
				_productListPriceHistories.SuppressClearInGetMulti=false;
				_alreadyFetchedProductListPriceHistories = true;
			}
			return _productListPriceHistories;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductListPriceHistories'. These settings will be taken into account
		/// when the property ProductListPriceHistories is requested or GetMultiProductListPriceHistories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductListPriceHistories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productListPriceHistories.SortClauses=sortClauses;
			_productListPriceHistories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductProductPhotoEntity'</returns>
		public AW.Data.CollectionClasses.ProductProductPhotoCollection GetMultiProductProductPhotos(bool forceFetch)
		{
			return GetMultiProductProductPhotos(forceFetch, _productProductPhotos.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductProductPhotoEntity'</returns>
		public AW.Data.CollectionClasses.ProductProductPhotoCollection GetMultiProductProductPhotos(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductProductPhotos(forceFetch, _productProductPhotos.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductProductPhotoCollection GetMultiProductProductPhotos(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductProductPhotos(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductProductPhotoCollection GetMultiProductProductPhotos(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductProductPhotos || forceFetch || _alwaysFetchProductProductPhotos) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productProductPhotos);
				_productProductPhotos.SuppressClearInGetMulti=!forceFetch;
				_productProductPhotos.EntityFactoryToUse = entityFactoryToUse;
				_productProductPhotos.GetMultiManyToOne(this, null, filter);
				_productProductPhotos.SuppressClearInGetMulti=false;
				_alreadyFetchedProductProductPhotos = true;
			}
			return _productProductPhotos;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductProductPhotos'. These settings will be taken into account
		/// when the property ProductProductPhotos is requested or GetMultiProductProductPhotos is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductProductPhotos(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productProductPhotos.SortClauses=sortClauses;
			_productProductPhotos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductReviewEntity'</returns>
		public AW.Data.CollectionClasses.ProductReviewCollection GetMultiProductReviews(bool forceFetch)
		{
			return GetMultiProductReviews(forceFetch, _productReviews.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductReviewEntity'</returns>
		public AW.Data.CollectionClasses.ProductReviewCollection GetMultiProductReviews(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductReviews(forceFetch, _productReviews.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductReviewCollection GetMultiProductReviews(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductReviews(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductReviewCollection GetMultiProductReviews(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductReviews || forceFetch || _alwaysFetchProductReviews) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productReviews);
				_productReviews.SuppressClearInGetMulti=!forceFetch;
				_productReviews.EntityFactoryToUse = entityFactoryToUse;
				_productReviews.GetMultiManyToOne(this, filter);
				_productReviews.SuppressClearInGetMulti=false;
				_alreadyFetchedProductReviews = true;
			}
			return _productReviews;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductReviews'. These settings will be taken into account
		/// when the property ProductReviews is requested or GetMultiProductReviews is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductReviews(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productReviews.SortClauses=sortClauses;
			_productReviews.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'TransactionHistoryEntity'</returns>
		public AW.Data.CollectionClasses.TransactionHistoryCollection GetMultiTransactionHistories(bool forceFetch)
		{
			return GetMultiTransactionHistories(forceFetch, _transactionHistories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'TransactionHistoryEntity'</returns>
		public AW.Data.CollectionClasses.TransactionHistoryCollection GetMultiTransactionHistories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiTransactionHistories(forceFetch, _transactionHistories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.TransactionHistoryCollection GetMultiTransactionHistories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiTransactionHistories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.TransactionHistoryCollection GetMultiTransactionHistories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedTransactionHistories || forceFetch || _alwaysFetchTransactionHistories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_transactionHistories);
				_transactionHistories.SuppressClearInGetMulti=!forceFetch;
				_transactionHistories.EntityFactoryToUse = entityFactoryToUse;
				_transactionHistories.GetMultiManyToOne(this, filter);
				_transactionHistories.SuppressClearInGetMulti=false;
				_alreadyFetchedTransactionHistories = true;
			}
			return _transactionHistories;
		}

		/// <summary> Sets the collection parameters for the collection for 'TransactionHistories'. These settings will be taken into account
		/// when the property TransactionHistories is requested or GetMultiTransactionHistories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersTransactionHistories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_transactionHistories.SortClauses=sortClauses;
			_transactionHistories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public AW.Data.CollectionClasses.WorkOrderCollection GetMultiWorkOrders(bool forceFetch)
		{
			return GetMultiWorkOrders(forceFetch, _workOrders.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public AW.Data.CollectionClasses.WorkOrderCollection GetMultiWorkOrders(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiWorkOrders(forceFetch, _workOrders.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.WorkOrderCollection GetMultiWorkOrders(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiWorkOrders(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.WorkOrderCollection GetMultiWorkOrders(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrders || forceFetch || _alwaysFetchWorkOrders) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_workOrders);
				_workOrders.SuppressClearInGetMulti=!forceFetch;
				_workOrders.EntityFactoryToUse = entityFactoryToUse;
				_workOrders.GetMultiManyToOne(this, null, filter);
				_workOrders.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrders = true;
			}
			return _workOrders;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrders'. These settings will be taken into account
		/// when the property WorkOrders is requested or GetMultiWorkOrders is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrders(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrders.SortClauses=sortClauses;
			_workOrders.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductVendorEntity'</returns>
		public AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendors(bool forceFetch)
		{
			return GetMultiProductVendors(forceFetch, _productVendors.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductVendorEntity'</returns>
		public AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendors(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductVendors(forceFetch, _productVendors.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendors(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductVendors(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductVendorCollection GetMultiProductVendors(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductVendors || forceFetch || _alwaysFetchProductVendors) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_productVendors);
				_productVendors.SuppressClearInGetMulti=!forceFetch;
				_productVendors.EntityFactoryToUse = entityFactoryToUse;
				_productVendors.GetMultiManyToOne(this, null, null, filter);
				_productVendors.SuppressClearInGetMulti=false;
				_alreadyFetchedProductVendors = true;
			}
			return _productVendors;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductVendors'. These settings will be taken into account
		/// when the property ProductVendors is requested or GetMultiProductVendors is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductVendors(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productVendors.SortClauses=sortClauses;
			_productVendors.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetails(bool forceFetch)
		{
			return GetMultiPurchaseOrderDetails(forceFetch, _purchaseOrderDetails.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetails(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiPurchaseOrderDetails(forceFetch, _purchaseOrderDetails.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiPurchaseOrderDetails(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.PurchaseOrderDetailCollection GetMultiPurchaseOrderDetails(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderDetails || forceFetch || _alwaysFetchPurchaseOrderDetails) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_purchaseOrderDetails);
				_purchaseOrderDetails.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderDetails.EntityFactoryToUse = entityFactoryToUse;
				_purchaseOrderDetails.GetMultiManyToOne(this, null, filter);
				_purchaseOrderDetails.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderDetails = true;
			}
			return _purchaseOrderDetails;
		}

		/// <summary> Sets the collection parameters for the collection for 'PurchaseOrderDetails'. These settings will be taken into account
		/// when the property PurchaseOrderDetails is requested or GetMultiPurchaseOrderDetails is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderDetails(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderDetails.SortClauses=sortClauses;
			_purchaseOrderDetails.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShoppingCartItemEntity'</returns>
		public AW.Data.CollectionClasses.ShoppingCartItemCollection GetMultiShoppingCartItems(bool forceFetch)
		{
			return GetMultiShoppingCartItems(forceFetch, _shoppingCartItems.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ShoppingCartItemEntity'</returns>
		public AW.Data.CollectionClasses.ShoppingCartItemCollection GetMultiShoppingCartItems(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiShoppingCartItems(forceFetch, _shoppingCartItems.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ShoppingCartItemCollection GetMultiShoppingCartItems(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiShoppingCartItems(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ShoppingCartItemCollection GetMultiShoppingCartItems(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedShoppingCartItems || forceFetch || _alwaysFetchShoppingCartItems) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_shoppingCartItems);
				_shoppingCartItems.SuppressClearInGetMulti=!forceFetch;
				_shoppingCartItems.EntityFactoryToUse = entityFactoryToUse;
				_shoppingCartItems.GetMultiManyToOne(this, filter);
				_shoppingCartItems.SuppressClearInGetMulti=false;
				_alreadyFetchedShoppingCartItems = true;
			}
			return _shoppingCartItems;
		}

		/// <summary> Sets the collection parameters for the collection for 'ShoppingCartItems'. These settings will be taken into account
		/// when the property ShoppingCartItems is requested or GetMultiShoppingCartItems is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShoppingCartItems(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shoppingCartItems.SortClauses=sortClauses;
			_shoppingCartItems.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
 			if( ( !_alreadyFetchedSpecialOfferProducts || forceFetch || _alwaysFetchSpecialOfferProducts) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_specialOfferProducts);
				_specialOfferProducts.SuppressClearInGetMulti=!forceFetch;
				_specialOfferProducts.EntityFactoryToUse = entityFactoryToUse;
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
			if( ( !_alreadyFetchedProductModel || forceFetch || _alwaysFetchProductModel) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ProductModelEntityUsingProductModelID);
				ProductModelEntity newEntity = new ProductModelEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ProductModelID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (ProductModelEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_productModelReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.ProductModel = newEntity;
				_alreadyFetchedProductModel = fetchResult;
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
			if( ( !_alreadyFetchedProductSubcategory || forceFetch || _alwaysFetchProductSubcategory) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ProductSubcategoryEntityUsingProductSubcategoryID);
				ProductSubcategoryEntity newEntity = new ProductSubcategoryEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ProductSubcategoryID.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (ProductSubcategoryEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_productSubcategoryReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.ProductSubcategory = newEntity;
				_alreadyFetchedProductSubcategory = fetchResult;
			}
			return _productSubcategory;
		}


		/// <summary> Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public UnitMeasureEntity GetSingleSizeUnitMeasure()
		{
			return GetSingleSizeUnitMeasure(false);
		}

		/// <summary> Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public virtual UnitMeasureEntity GetSingleSizeUnitMeasure(bool forceFetch)
		{
			if( ( !_alreadyFetchedSizeUnitMeasure || forceFetch || _alwaysFetchSizeUnitMeasure) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.UnitMeasureEntityUsingSizeUnitMeasureCode);
				UnitMeasureEntity newEntity = new UnitMeasureEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.SizeUnitMeasureCode);
				}
				if(fetchResult)
				{
					newEntity = (UnitMeasureEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_sizeUnitMeasureReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.SizeUnitMeasure = newEntity;
				_alreadyFetchedSizeUnitMeasure = fetchResult;
			}
			return _sizeUnitMeasure;
		}


		/// <summary> Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public UnitMeasureEntity GetSingleWeightUnitMeasure()
		{
			return GetSingleWeightUnitMeasure(false);
		}

		/// <summary> Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public virtual UnitMeasureEntity GetSingleWeightUnitMeasure(bool forceFetch)
		{
			if( ( !_alreadyFetchedWeightUnitMeasure || forceFetch || _alwaysFetchWeightUnitMeasure) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.UnitMeasureEntityUsingWeightUnitMeasureCode);
				UnitMeasureEntity newEntity = new UnitMeasureEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.WeightUnitMeasureCode);
				}
				if(fetchResult)
				{
					newEntity = (UnitMeasureEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_weightUnitMeasureReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.WeightUnitMeasure = newEntity;
				_alreadyFetchedWeightUnitMeasure = fetchResult;
			}
			return _weightUnitMeasure;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ProductModel", _productModel);
			toReturn.Add("ProductSubcategory", _productSubcategory);
			toReturn.Add("SizeUnitMeasure", _sizeUnitMeasure);
			toReturn.Add("WeightUnitMeasure", _weightUnitMeasure);
			toReturn.Add("BillOfComponentMaterials", _billOfComponentMaterials);
			toReturn.Add("BillOfAssemblyMaterials", _billOfAssemblyMaterials);
			toReturn.Add("ProductCostHistories", _productCostHistories);
			toReturn.Add("ProductDocuments", _productDocuments);
			toReturn.Add("ProductInventories", _productInventories);
			toReturn.Add("ProductListPriceHistories", _productListPriceHistories);
			toReturn.Add("ProductProductPhotos", _productProductPhotos);
			toReturn.Add("ProductReviews", _productReviews);
			toReturn.Add("TransactionHistories", _transactionHistories);
			toReturn.Add("WorkOrders", _workOrders);
			toReturn.Add("ProductVendors", _productVendors);
			toReturn.Add("PurchaseOrderDetails", _purchaseOrderDetails);
			toReturn.Add("ShoppingCartItems", _shoppingCartItems);
			toReturn.Add("SpecialOfferProducts", _specialOfferProducts);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			this.Fields = CreateFields();
			this.Validator = validatorToUse;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The validator object for this ProductEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 productID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(productID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_billOfComponentMaterials = new AW.Data.CollectionClasses.BillOfMaterialCollection();
			_billOfComponentMaterials.SetContainingEntityInfo(this, "ProductComponent");

			_billOfAssemblyMaterials = new AW.Data.CollectionClasses.BillOfMaterialCollection();
			_billOfAssemblyMaterials.SetContainingEntityInfo(this, "ProductAssembly");

			_productCostHistories = new AW.Data.CollectionClasses.ProductCostHistoryCollection();
			_productCostHistories.SetContainingEntityInfo(this, "Product");

			_productDocuments = new AW.Data.CollectionClasses.ProductDocumentCollection();
			_productDocuments.SetContainingEntityInfo(this, "Product");

			_productInventories = new AW.Data.CollectionClasses.ProductInventoryCollection();
			_productInventories.SetContainingEntityInfo(this, "Product");

			_productListPriceHistories = new AW.Data.CollectionClasses.ProductListPriceHistoryCollection();
			_productListPriceHistories.SetContainingEntityInfo(this, "Product");

			_productProductPhotos = new AW.Data.CollectionClasses.ProductProductPhotoCollection();
			_productProductPhotos.SetContainingEntityInfo(this, "Product");

			_productReviews = new AW.Data.CollectionClasses.ProductReviewCollection();
			_productReviews.SetContainingEntityInfo(this, "Product");

			_transactionHistories = new AW.Data.CollectionClasses.TransactionHistoryCollection();
			_transactionHistories.SetContainingEntityInfo(this, "Product");

			_workOrders = new AW.Data.CollectionClasses.WorkOrderCollection();
			_workOrders.SetContainingEntityInfo(this, "Product");

			_productVendors = new AW.Data.CollectionClasses.ProductVendorCollection();
			_productVendors.SetContainingEntityInfo(this, "Product");

			_purchaseOrderDetails = new AW.Data.CollectionClasses.PurchaseOrderDetailCollection();
			_purchaseOrderDetails.SetContainingEntityInfo(this, "Product");

			_shoppingCartItems = new AW.Data.CollectionClasses.ShoppingCartItemCollection();
			_shoppingCartItems.SetContainingEntityInfo(this, "Product");

			_specialOfferProducts = new AW.Data.CollectionClasses.SpecialOfferProductCollection();
			_specialOfferProducts.SetContainingEntityInfo(this, "Product");
			_productModelReturnsNewIfNotFound = true;
			_productSubcategoryReturnsNewIfNotFound = true;
			_sizeUnitMeasureReturnsNewIfNotFound = true;
			_weightUnitMeasureReturnsNewIfNotFound = true;
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
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"H = High, M = Medium, L = Low");
			_fieldsCustomProperties.Add("Class", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product color.");
			_fieldsCustomProperties.Add("Color", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Number of days required to manufacture the product.");
			_fieldsCustomProperties.Add("DaysToManufacture", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the product was discontinued.");
			_fieldsCustomProperties.Add("DiscontinuedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = Product is not a salable item. 1 = Product is salable.");
			_fieldsCustomProperties.Add("FinishedGoodsFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Selling price.");
			_fieldsCustomProperties.Add("ListPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = Product is purchased, 1 = Product is manufactured in-house.");
			_fieldsCustomProperties.Add("MakeFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Name of the product.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("ProductID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"R = Road, M = Mountain, T = Touring, S = Standard");
			_fieldsCustomProperties.Add("ProductLine", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product is a member of this product model. Foreign key to ProductModel.ProductModelID.");
			_fieldsCustomProperties.Add("ProductModelID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index.");
			_fieldsCustomProperties.Add("ProductNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. ");
			_fieldsCustomProperties.Add("ProductSubcategoryID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Inventory level that triggers a purchase order or work order. ");
			_fieldsCustomProperties.Add("ReorderPoint", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Minimum inventory quantity. ");
			_fieldsCustomProperties.Add("SafetyStockLevel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the product was no longer available for sale.");
			_fieldsCustomProperties.Add("SellEndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the product was available for sale.");
			_fieldsCustomProperties.Add("SellStartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product size.");
			_fieldsCustomProperties.Add("Size", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unit of measure for Size column.");
			_fieldsCustomProperties.Add("SizeUnitMeasureCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Standard cost of the product.");
			_fieldsCustomProperties.Add("StandardCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"W = Womens, M = Mens, U = Universal");
			_fieldsCustomProperties.Add("Style", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Product weight.");
			_fieldsCustomProperties.Add("Weight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unit of measure for Weight column.");
			_fieldsCustomProperties.Add("WeightUnitMeasureCode", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _productModel</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductModel(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _productModel, new PropertyChangedEventHandler( OnProductModelPropertyChanged ), "ProductModel", AW.Data.RelationClasses.StaticProductRelations.ProductModelEntityUsingProductModelIDStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.ProductModelID } );		
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
				this.PerformSetupSyncRelatedEntity( _productModel, new PropertyChangedEventHandler( OnProductModelPropertyChanged ), "ProductModel", AW.Data.RelationClasses.StaticProductRelations.ProductModelEntityUsingProductModelIDStatic, true, ref _alreadyFetchedProductModel, new string[] {  } );
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
			this.PerformDesetupSyncRelatedEntity( _productSubcategory, new PropertyChangedEventHandler( OnProductSubcategoryPropertyChanged ), "ProductSubcategory", AW.Data.RelationClasses.StaticProductRelations.ProductSubcategoryEntityUsingProductSubcategoryIDStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.ProductSubcategoryID } );		
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
				this.PerformSetupSyncRelatedEntity( _productSubcategory, new PropertyChangedEventHandler( OnProductSubcategoryPropertyChanged ), "ProductSubcategory", AW.Data.RelationClasses.StaticProductRelations.ProductSubcategoryEntityUsingProductSubcategoryIDStatic, true, ref _alreadyFetchedProductSubcategory, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _sizeUnitMeasure</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSizeUnitMeasure(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _sizeUnitMeasure, new PropertyChangedEventHandler( OnSizeUnitMeasurePropertyChanged ), "SizeUnitMeasure", AW.Data.RelationClasses.StaticProductRelations.UnitMeasureEntityUsingSizeUnitMeasureCodeStatic, true, signalRelatedEntity, "ProductsOfSize", resetFKFields, new int[] { (int)ProductFieldIndex.SizeUnitMeasureCode } );		
			_sizeUnitMeasure = null;
		}
		
		/// <summary> setups the sync logic for member _sizeUnitMeasure</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSizeUnitMeasure(IEntity relatedEntity)
		{
			if(_sizeUnitMeasure!=relatedEntity)
			{		
				DesetupSyncSizeUnitMeasure(true, true);
				_sizeUnitMeasure = (UnitMeasureEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _sizeUnitMeasure, new PropertyChangedEventHandler( OnSizeUnitMeasurePropertyChanged ), "SizeUnitMeasure", AW.Data.RelationClasses.StaticProductRelations.UnitMeasureEntityUsingSizeUnitMeasureCodeStatic, true, ref _alreadyFetchedSizeUnitMeasure, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSizeUnitMeasurePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _weightUnitMeasure</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWeightUnitMeasure(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _weightUnitMeasure, new PropertyChangedEventHandler( OnWeightUnitMeasurePropertyChanged ), "WeightUnitMeasure", AW.Data.RelationClasses.StaticProductRelations.UnitMeasureEntityUsingWeightUnitMeasureCodeStatic, true, signalRelatedEntity, "ProductsOfWeight", resetFKFields, new int[] { (int)ProductFieldIndex.WeightUnitMeasureCode } );		
			_weightUnitMeasure = null;
		}
		
		/// <summary> setups the sync logic for member _weightUnitMeasure</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWeightUnitMeasure(IEntity relatedEntity)
		{
			if(_weightUnitMeasure!=relatedEntity)
			{		
				DesetupSyncWeightUnitMeasure(true, true);
				_weightUnitMeasure = (UnitMeasureEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _weightUnitMeasure, new PropertyChangedEventHandler( OnWeightUnitMeasurePropertyChanged ), "WeightUnitMeasure", AW.Data.RelationClasses.StaticProductRelations.UnitMeasureEntityUsingWeightUnitMeasureCodeStatic, true, ref _alreadyFetchedWeightUnitMeasure, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnWeightUnitMeasurePropertyChanged( object sender, PropertyChangedEventArgs e )
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
				this.Fields[(int)ProductFieldIndex.ProductID].ForcedCurrentValueWrite(productID);
				CreateDAOInstance().FetchExisting(this, this.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
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

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BillOfMaterial' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBillOfComponentMaterials
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.BillOfMaterialCollection(), (IEntityRelation)GetRelationsForField("BillOfComponentMaterials")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.BillOfMaterialEntity, 0, null, null, null, "BillOfComponentMaterials", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BillOfMaterial' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBillOfAssemblyMaterials
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.BillOfMaterialCollection(), (IEntityRelation)GetRelationsForField("BillOfAssemblyMaterials")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.BillOfMaterialEntity, 0, null, null, null, "BillOfAssemblyMaterials", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductCostHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCostHistories
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCostHistoryCollection(), (IEntityRelation)GetRelationsForField("ProductCostHistories")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductCostHistoryEntity, 0, null, null, null, "ProductCostHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductDocument' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductDocuments
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductDocumentCollection(), (IEntityRelation)GetRelationsForField("ProductDocuments")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductDocumentEntity, 0, null, null, null, "ProductDocuments", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductInventory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductInventories
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductInventoryCollection(), (IEntityRelation)GetRelationsForField("ProductInventories")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductInventoryEntity, 0, null, null, null, "ProductInventories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductListPriceHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductListPriceHistories
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductListPriceHistoryCollection(), (IEntityRelation)GetRelationsForField("ProductListPriceHistories")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductListPriceHistoryEntity, 0, null, null, null, "ProductListPriceHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductProductPhoto' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductProductPhotos
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductProductPhotoCollection(), (IEntityRelation)GetRelationsForField("ProductProductPhotos")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductProductPhotoEntity, 0, null, null, null, "ProductProductPhotos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductReview' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductReviews
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductReviewCollection(), (IEntityRelation)GetRelationsForField("ProductReviews")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductReviewEntity, 0, null, null, null, "ProductReviews", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TransactionHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathTransactionHistories
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.TransactionHistoryCollection(), (IEntityRelation)GetRelationsForField("TransactionHistories")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.TransactionHistoryEntity, 0, null, null, null, "TransactionHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrder' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrders
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.WorkOrderCollection(), (IEntityRelation)GetRelationsForField("WorkOrders")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.WorkOrderEntity, 0, null, null, null, "WorkOrders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductVendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductVendors
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductVendorCollection(), (IEntityRelation)GetRelationsForField("ProductVendors")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductVendorEntity, 0, null, null, null, "ProductVendors", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrderDetails
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderDetailCollection(), (IEntityRelation)GetRelationsForField("PurchaseOrderDetails")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.PurchaseOrderDetailEntity, 0, null, null, null, "PurchaseOrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShoppingCartItem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShoppingCartItems
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ShoppingCartItemCollection(), (IEntityRelation)GetRelationsForField("ShoppingCartItems")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ShoppingCartItemEntity, 0, null, null, null, "ShoppingCartItems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOfferProducts
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferProductCollection(), (IEntityRelation)GetRelationsForField("SpecialOfferProducts")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.SpecialOfferProductEntity, 0, null, null, null, "SpecialOfferProducts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModel'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModel
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelCollection(), (IEntityRelation)GetRelationsForField("ProductModel")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductModelEntity, 0, null, null, null, "ProductModel", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductSubcategory'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductSubcategory
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductSubcategoryCollection(), (IEntityRelation)GetRelationsForField("ProductSubcategory")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.ProductSubcategoryEntity, 0, null, null, null, "ProductSubcategory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSizeUnitMeasure
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(), (IEntityRelation)GetRelationsForField("SizeUnitMeasure")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, null, "SizeUnitMeasure", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWeightUnitMeasure
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(), (IEntityRelation)GetRelationsForField("WeightUnitMeasure")[0], (int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, null, "WeightUnitMeasure", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "ProductEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
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
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The Class property of the Entity Product<br/><br/>
		/// MS_Description: H = High, M = Medium, L = Low<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Class"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Class
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Class, true); }
			set	{ SetValue((int)ProductFieldIndex.Class, value, true); }
		}

		/// <summary> The Color property of the Entity Product<br/><br/>
		/// MS_Description: Product color.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Color"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Color
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Color, true); }
			set	{ SetValue((int)ProductFieldIndex.Color, value, true); }
		}

		/// <summary> The DaysToManufacture property of the Entity Product<br/><br/>
		/// MS_Description: Number of days required to manufacture the product.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."DaysToManufacture"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DaysToManufacture
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.DaysToManufacture, true); }
			set	{ SetValue((int)ProductFieldIndex.DaysToManufacture, value, true); }
		}

		/// <summary> The DiscontinuedDate property of the Entity Product<br/><br/>
		/// MS_Description: Date the product was discontinued.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."DiscontinuedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DiscontinuedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.DiscontinuedDate, false); }
			set	{ SetValue((int)ProductFieldIndex.DiscontinuedDate, value, true); }
		}

		/// <summary> The FinishedGoodsFlag property of the Entity Product<br/><br/>
		/// MS_Description: 0 = Product is not a salable item. 1 = Product is salable.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."FinishedGoodsFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean FinishedGoodsFlag
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.FinishedGoodsFlag, true); }
			set	{ SetValue((int)ProductFieldIndex.FinishedGoodsFlag, value, true); }
		}

		/// <summary> The ListPrice property of the Entity Product<br/><br/>
		/// MS_Description: Selling price.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ListPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ListPrice
		{
			get { return (System.Decimal)GetValue((int)ProductFieldIndex.ListPrice, true); }
			set	{ SetValue((int)ProductFieldIndex.ListPrice, value, true); }
		}

		/// <summary> The MakeFlag property of the Entity Product<br/><br/>
		/// MS_Description: 0 = Product is purchased, 1 = Product is manufactured in-house.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."MakeFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean MakeFlag
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.MakeFlag, true); }
			set	{ SetValue((int)ProductFieldIndex.MakeFlag, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity Product<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity Product<br/><br/>
		/// MS_Description: Name of the product.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Name, true); }
			set	{ SetValue((int)ProductFieldIndex.Name, value, true); }
		}

		/// <summary> The ProductID property of the Entity Product<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductID
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.ProductID, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductID, value, true); }
		}

		/// <summary> The ProductLine property of the Entity Product<br/><br/>
		/// MS_Description: R = Road, M = Mountain, T = Touring, S = Standard<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductLine"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ProductLine
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductLine, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductLine, value, true); }
		}

		/// <summary> The ProductModelID property of the Entity Product<br/><br/>
		/// MS_Description: Product is a member of this product model. Foreign key to ProductModel.ProductModelID.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductModelID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductModelID
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.ProductModelID, false); }
			set	{ SetValue((int)ProductFieldIndex.ProductModelID, value, true); }
		}

		/// <summary> The ProductNumber property of the Entity Product<br/><br/>
		/// MS_Description: Unique nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ProductNumber
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductNumber, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductNumber, value, true); }
		}

		/// <summary> The ProductSubcategoryID property of the Entity Product<br/><br/>
		/// MS_Description: Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. <br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductSubcategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductSubcategoryID
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.ProductSubcategoryID, false); }
			set	{ SetValue((int)ProductFieldIndex.ProductSubcategoryID, value, true); }
		}

		/// <summary> The ReorderPoint property of the Entity Product<br/><br/>
		/// MS_Description: Inventory level that triggers a purchase order or work order. <br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ReorderPoint"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 ReorderPoint
		{
			get { return (System.Int16)GetValue((int)ProductFieldIndex.ReorderPoint, true); }
			set	{ SetValue((int)ProductFieldIndex.ReorderPoint, value, true); }
		}

		/// <summary> The Rowguid property of the Entity Product<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductFieldIndex.Rowguid, value, true); }
		}

		/// <summary> The SafetyStockLevel property of the Entity Product<br/><br/>
		/// MS_Description: Minimum inventory quantity. <br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SafetyStockLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 SafetyStockLevel
		{
			get { return (System.Int16)GetValue((int)ProductFieldIndex.SafetyStockLevel, true); }
			set	{ SetValue((int)ProductFieldIndex.SafetyStockLevel, value, true); }
		}

		/// <summary> The SellEndDate property of the Entity Product<br/><br/>
		/// MS_Description: Date the product was no longer available for sale.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SellEndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> SellEndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.SellEndDate, false); }
			set	{ SetValue((int)ProductFieldIndex.SellEndDate, value, true); }
		}

		/// <summary> The SellStartDate property of the Entity Product<br/><br/>
		/// MS_Description: Date the product was available for sale.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SellStartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime SellStartDate
		{
			get { return (System.DateTime)GetValue((int)ProductFieldIndex.SellStartDate, true); }
			set	{ SetValue((int)ProductFieldIndex.SellStartDate, value, true); }
		}

		/// <summary> The Size property of the Entity Product<br/><br/>
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
		/// MS_Description: Unit of measure for Size column.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SizeUnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String SizeUnitMeasureCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.SizeUnitMeasureCode, true); }
			set	{ SetValue((int)ProductFieldIndex.SizeUnitMeasureCode, value, true); }
		}

		/// <summary> The StandardCost property of the Entity Product<br/><br/>
		/// MS_Description: Standard cost of the product.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."StandardCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal StandardCost
		{
			get { return (System.Decimal)GetValue((int)ProductFieldIndex.StandardCost, true); }
			set	{ SetValue((int)ProductFieldIndex.StandardCost, value, true); }
		}

		/// <summary> The Style property of the Entity Product<br/><br/>
		/// MS_Description: W = Womens, M = Mens, U = Universal<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Style"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Style
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Style, true); }
			set	{ SetValue((int)ProductFieldIndex.Style, value, true); }
		}

		/// <summary> The Weight property of the Entity Product<br/><br/>
		/// MS_Description: Product weight.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Weight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Weight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductFieldIndex.Weight, false); }
			set	{ SetValue((int)ProductFieldIndex.Weight, value, true); }
		}

		/// <summary> The WeightUnitMeasureCode property of the Entity Product<br/><br/>
		/// MS_Description: Unit of measure for Weight column.<br/></summary>
		/// <remarks>Mapped on  table field: "Product"."WeightUnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String WeightUnitMeasureCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.WeightUnitMeasureCode, true); }
			set	{ SetValue((int)ProductFieldIndex.WeightUnitMeasureCode, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBillOfComponentMaterials()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.BillOfMaterialCollection BillOfComponentMaterials
		{
			get	{ return GetMultiBillOfComponentMaterials(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for BillOfComponentMaterials. When set to true, BillOfComponentMaterials is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BillOfComponentMaterials is accessed. You can always execute/ a forced fetch by calling GetMultiBillOfComponentMaterials(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBillOfComponentMaterials
		{
			get	{ return _alwaysFetchBillOfComponentMaterials; }
			set	{ _alwaysFetchBillOfComponentMaterials = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property BillOfComponentMaterials already has been fetched. Setting this property to false when BillOfComponentMaterials has been fetched
		/// will clear the BillOfComponentMaterials collection well. Setting this property to true while BillOfComponentMaterials hasn't been fetched disables lazy loading for BillOfComponentMaterials</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBillOfComponentMaterials
		{
			get { return _alreadyFetchedBillOfComponentMaterials;}
			set 
			{
				if(_alreadyFetchedBillOfComponentMaterials && !value && (_billOfComponentMaterials != null))
				{
					_billOfComponentMaterials.Clear();
				}
				_alreadyFetchedBillOfComponentMaterials = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'BillOfMaterialEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBillOfAssemblyMaterials()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.BillOfMaterialCollection BillOfAssemblyMaterials
		{
			get	{ return GetMultiBillOfAssemblyMaterials(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for BillOfAssemblyMaterials. When set to true, BillOfAssemblyMaterials is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BillOfAssemblyMaterials is accessed. You can always execute/ a forced fetch by calling GetMultiBillOfAssemblyMaterials(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBillOfAssemblyMaterials
		{
			get	{ return _alwaysFetchBillOfAssemblyMaterials; }
			set	{ _alwaysFetchBillOfAssemblyMaterials = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property BillOfAssemblyMaterials already has been fetched. Setting this property to false when BillOfAssemblyMaterials has been fetched
		/// will clear the BillOfAssemblyMaterials collection well. Setting this property to true while BillOfAssemblyMaterials hasn't been fetched disables lazy loading for BillOfAssemblyMaterials</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBillOfAssemblyMaterials
		{
			get { return _alreadyFetchedBillOfAssemblyMaterials;}
			set 
			{
				if(_alreadyFetchedBillOfAssemblyMaterials && !value && (_billOfAssemblyMaterials != null))
				{
					_billOfAssemblyMaterials.Clear();
				}
				_alreadyFetchedBillOfAssemblyMaterials = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductCostHistories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCostHistoryCollection ProductCostHistories
		{
			get	{ return GetMultiProductCostHistories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCostHistories. When set to true, ProductCostHistories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCostHistories is accessed. You can always execute/ a forced fetch by calling GetMultiProductCostHistories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCostHistories
		{
			get	{ return _alwaysFetchProductCostHistories; }
			set	{ _alwaysFetchProductCostHistories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductCostHistories already has been fetched. Setting this property to false when ProductCostHistories has been fetched
		/// will clear the ProductCostHistories collection well. Setting this property to true while ProductCostHistories hasn't been fetched disables lazy loading for ProductCostHistories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductCostHistories
		{
			get { return _alreadyFetchedProductCostHistories;}
			set 
			{
				if(_alreadyFetchedProductCostHistories && !value && (_productCostHistories != null))
				{
					_productCostHistories.Clear();
				}
				_alreadyFetchedProductCostHistories = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductDocuments()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductDocumentCollection ProductDocuments
		{
			get	{ return GetMultiProductDocuments(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductDocuments. When set to true, ProductDocuments is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductDocuments is accessed. You can always execute/ a forced fetch by calling GetMultiProductDocuments(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductDocuments
		{
			get	{ return _alwaysFetchProductDocuments; }
			set	{ _alwaysFetchProductDocuments = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductDocuments already has been fetched. Setting this property to false when ProductDocuments has been fetched
		/// will clear the ProductDocuments collection well. Setting this property to true while ProductDocuments hasn't been fetched disables lazy loading for ProductDocuments</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductDocuments
		{
			get { return _alreadyFetchedProductDocuments;}
			set 
			{
				if(_alreadyFetchedProductDocuments && !value && (_productDocuments != null))
				{
					_productDocuments.Clear();
				}
				_alreadyFetchedProductDocuments = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductInventories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductInventoryCollection ProductInventories
		{
			get	{ return GetMultiProductInventories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductInventories. When set to true, ProductInventories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductInventories is accessed. You can always execute/ a forced fetch by calling GetMultiProductInventories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductInventories
		{
			get	{ return _alwaysFetchProductInventories; }
			set	{ _alwaysFetchProductInventories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductInventories already has been fetched. Setting this property to false when ProductInventories has been fetched
		/// will clear the ProductInventories collection well. Setting this property to true while ProductInventories hasn't been fetched disables lazy loading for ProductInventories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductInventories
		{
			get { return _alreadyFetchedProductInventories;}
			set 
			{
				if(_alreadyFetchedProductInventories && !value && (_productInventories != null))
				{
					_productInventories.Clear();
				}
				_alreadyFetchedProductInventories = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductListPriceHistories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductListPriceHistoryCollection ProductListPriceHistories
		{
			get	{ return GetMultiProductListPriceHistories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductListPriceHistories. When set to true, ProductListPriceHistories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductListPriceHistories is accessed. You can always execute/ a forced fetch by calling GetMultiProductListPriceHistories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductListPriceHistories
		{
			get	{ return _alwaysFetchProductListPriceHistories; }
			set	{ _alwaysFetchProductListPriceHistories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductListPriceHistories already has been fetched. Setting this property to false when ProductListPriceHistories has been fetched
		/// will clear the ProductListPriceHistories collection well. Setting this property to true while ProductListPriceHistories hasn't been fetched disables lazy loading for ProductListPriceHistories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductListPriceHistories
		{
			get { return _alreadyFetchedProductListPriceHistories;}
			set 
			{
				if(_alreadyFetchedProductListPriceHistories && !value && (_productListPriceHistories != null))
				{
					_productListPriceHistories.Clear();
				}
				_alreadyFetchedProductListPriceHistories = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductProductPhotos()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductProductPhotoCollection ProductProductPhotos
		{
			get	{ return GetMultiProductProductPhotos(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductProductPhotos. When set to true, ProductProductPhotos is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductProductPhotos is accessed. You can always execute/ a forced fetch by calling GetMultiProductProductPhotos(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductProductPhotos
		{
			get	{ return _alwaysFetchProductProductPhotos; }
			set	{ _alwaysFetchProductProductPhotos = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductProductPhotos already has been fetched. Setting this property to false when ProductProductPhotos has been fetched
		/// will clear the ProductProductPhotos collection well. Setting this property to true while ProductProductPhotos hasn't been fetched disables lazy loading for ProductProductPhotos</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductProductPhotos
		{
			get { return _alreadyFetchedProductProductPhotos;}
			set 
			{
				if(_alreadyFetchedProductProductPhotos && !value && (_productProductPhotos != null))
				{
					_productProductPhotos.Clear();
				}
				_alreadyFetchedProductProductPhotos = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductReviews()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductReviewCollection ProductReviews
		{
			get	{ return GetMultiProductReviews(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductReviews. When set to true, ProductReviews is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductReviews is accessed. You can always execute/ a forced fetch by calling GetMultiProductReviews(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductReviews
		{
			get	{ return _alwaysFetchProductReviews; }
			set	{ _alwaysFetchProductReviews = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductReviews already has been fetched. Setting this property to false when ProductReviews has been fetched
		/// will clear the ProductReviews collection well. Setting this property to true while ProductReviews hasn't been fetched disables lazy loading for ProductReviews</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductReviews
		{
			get { return _alreadyFetchedProductReviews;}
			set 
			{
				if(_alreadyFetchedProductReviews && !value && (_productReviews != null))
				{
					_productReviews.Clear();
				}
				_alreadyFetchedProductReviews = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTransactionHistories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.TransactionHistoryCollection TransactionHistories
		{
			get	{ return GetMultiTransactionHistories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for TransactionHistories. When set to true, TransactionHistories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time TransactionHistories is accessed. You can always execute/ a forced fetch by calling GetMultiTransactionHistories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchTransactionHistories
		{
			get	{ return _alwaysFetchTransactionHistories; }
			set	{ _alwaysFetchTransactionHistories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property TransactionHistories already has been fetched. Setting this property to false when TransactionHistories has been fetched
		/// will clear the TransactionHistories collection well. Setting this property to true while TransactionHistories hasn't been fetched disables lazy loading for TransactionHistories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedTransactionHistories
		{
			get { return _alreadyFetchedTransactionHistories;}
			set 
			{
				if(_alreadyFetchedTransactionHistories && !value && (_transactionHistories != null))
				{
					_transactionHistories.Clear();
				}
				_alreadyFetchedTransactionHistories = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.WorkOrderCollection WorkOrders
		{
			get	{ return GetMultiWorkOrders(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrders. When set to true, WorkOrders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrders is accessed. You can always execute/ a forced fetch by calling GetMultiWorkOrders(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrders
		{
			get	{ return _alwaysFetchWorkOrders; }
			set	{ _alwaysFetchWorkOrders = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrders already has been fetched. Setting this property to false when WorkOrders has been fetched
		/// will clear the WorkOrders collection well. Setting this property to true while WorkOrders hasn't been fetched disables lazy loading for WorkOrders</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrders
		{
			get { return _alreadyFetchedWorkOrders;}
			set 
			{
				if(_alreadyFetchedWorkOrders && !value && (_workOrders != null))
				{
					_workOrders.Clear();
				}
				_alreadyFetchedWorkOrders = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductVendors()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductVendorCollection ProductVendors
		{
			get	{ return GetMultiProductVendors(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductVendors. When set to true, ProductVendors is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductVendors is accessed. You can always execute/ a forced fetch by calling GetMultiProductVendors(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductVendors
		{
			get	{ return _alwaysFetchProductVendors; }
			set	{ _alwaysFetchProductVendors = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductVendors already has been fetched. Setting this property to false when ProductVendors has been fetched
		/// will clear the ProductVendors collection well. Setting this property to true while ProductVendors hasn't been fetched disables lazy loading for ProductVendors</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductVendors
		{
			get { return _alreadyFetchedProductVendors;}
			set 
			{
				if(_alreadyFetchedProductVendors && !value && (_productVendors != null))
				{
					_productVendors.Clear();
				}
				_alreadyFetchedProductVendors = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderDetails()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.PurchaseOrderDetailCollection PurchaseOrderDetails
		{
			get	{ return GetMultiPurchaseOrderDetails(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrderDetails. When set to true, PurchaseOrderDetails is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderDetails is accessed. You can always execute/ a forced fetch by calling GetMultiPurchaseOrderDetails(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderDetails
		{
			get	{ return _alwaysFetchPurchaseOrderDetails; }
			set	{ _alwaysFetchPurchaseOrderDetails = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrderDetails already has been fetched. Setting this property to false when PurchaseOrderDetails has been fetched
		/// will clear the PurchaseOrderDetails collection well. Setting this property to true while PurchaseOrderDetails hasn't been fetched disables lazy loading for PurchaseOrderDetails</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrderDetails
		{
			get { return _alreadyFetchedPurchaseOrderDetails;}
			set 
			{
				if(_alreadyFetchedPurchaseOrderDetails && !value && (_purchaseOrderDetails != null))
				{
					_purchaseOrderDetails.Clear();
				}
				_alreadyFetchedPurchaseOrderDetails = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShoppingCartItems()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ShoppingCartItemCollection ShoppingCartItems
		{
			get	{ return GetMultiShoppingCartItems(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ShoppingCartItems. When set to true, ShoppingCartItems is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShoppingCartItems is accessed. You can always execute/ a forced fetch by calling GetMultiShoppingCartItems(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShoppingCartItems
		{
			get	{ return _alwaysFetchShoppingCartItems; }
			set	{ _alwaysFetchShoppingCartItems = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShoppingCartItems already has been fetched. Setting this property to false when ShoppingCartItems has been fetched
		/// will clear the ShoppingCartItems collection well. Setting this property to true while ShoppingCartItems hasn't been fetched disables lazy loading for ShoppingCartItems</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShoppingCartItems
		{
			get { return _alreadyFetchedShoppingCartItems;}
			set 
			{
				if(_alreadyFetchedShoppingCartItems && !value && (_shoppingCartItems != null))
				{
					_shoppingCartItems.Clear();
				}
				_alreadyFetchedShoppingCartItems = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOfferProducts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SpecialOfferProductCollection SpecialOfferProducts
		{
			get	{ return GetMultiSpecialOfferProducts(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOfferProducts. When set to true, SpecialOfferProducts is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferProducts is accessed. You can always execute/ a forced fetch by calling GetMultiSpecialOfferProducts(true).</summary>
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

		/// <summary> Gets / sets related entity of type 'ProductModelEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductModel()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual ProductModelEntity ProductModel
		{
			get	{ return GetSingleProductModel(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncProductModel(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "ProductModel", _productModel, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModel. When set to true, ProductModel is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModel is accessed. You can always execute a forced fetch by calling GetSingleProductModel(true).</summary>
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
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductSubcategory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual ProductSubcategoryEntity ProductSubcategory
		{
			get	{ return GetSingleProductSubcategory(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncProductSubcategory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "ProductSubcategory", _productSubcategory, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ProductSubcategory. When set to true, ProductSubcategory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductSubcategory is accessed. You can always execute a forced fetch by calling GetSingleProductSubcategory(true).</summary>
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
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSizeUnitMeasure()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual UnitMeasureEntity SizeUnitMeasure
		{
			get	{ return GetSingleSizeUnitMeasure(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncSizeUnitMeasure(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "ProductsOfSize", "SizeUnitMeasure", _sizeUnitMeasure, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for SizeUnitMeasure. When set to true, SizeUnitMeasure is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SizeUnitMeasure is accessed. You can always execute a forced fetch by calling GetSingleSizeUnitMeasure(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSizeUnitMeasure
		{
			get	{ return _alwaysFetchSizeUnitMeasure; }
			set	{ _alwaysFetchSizeUnitMeasure = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property SizeUnitMeasure already has been fetched. Setting this property to false when SizeUnitMeasure has been fetched
		/// will set SizeUnitMeasure to null as well. Setting this property to true while SizeUnitMeasure hasn't been fetched disables lazy loading for SizeUnitMeasure</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSizeUnitMeasure
		{
			get { return _alreadyFetchedSizeUnitMeasure;}
			set 
			{
				if(_alreadyFetchedSizeUnitMeasure && !value)
				{
					this.SizeUnitMeasure = null;
				}
				_alreadyFetchedSizeUnitMeasure = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property SizeUnitMeasure is not found
		/// in the database. When set to true, SizeUnitMeasure will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool SizeUnitMeasureReturnsNewIfNotFound
		{
			get	{ return _sizeUnitMeasureReturnsNewIfNotFound; }
			set { _sizeUnitMeasureReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'UnitMeasureEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleWeightUnitMeasure()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual UnitMeasureEntity WeightUnitMeasure
		{
			get	{ return GetSingleWeightUnitMeasure(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncWeightUnitMeasure(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "ProductsOfWeight", "WeightUnitMeasure", _weightUnitMeasure, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for WeightUnitMeasure. When set to true, WeightUnitMeasure is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WeightUnitMeasure is accessed. You can always execute a forced fetch by calling GetSingleWeightUnitMeasure(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWeightUnitMeasure
		{
			get	{ return _alwaysFetchWeightUnitMeasure; }
			set	{ _alwaysFetchWeightUnitMeasure = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WeightUnitMeasure already has been fetched. Setting this property to false when WeightUnitMeasure has been fetched
		/// will set WeightUnitMeasure to null as well. Setting this property to true while WeightUnitMeasure hasn't been fetched disables lazy loading for WeightUnitMeasure</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWeightUnitMeasure
		{
			get { return _alreadyFetchedWeightUnitMeasure;}
			set 
			{
				if(_alreadyFetchedWeightUnitMeasure && !value)
				{
					this.WeightUnitMeasure = null;
				}
				_alreadyFetchedWeightUnitMeasure = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property WeightUnitMeasure is not found
		/// in the database. When set to true, WeightUnitMeasure will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool WeightUnitMeasureReturnsNewIfNotFound
		{
			get	{ return _weightUnitMeasureReturnsNewIfNotFound; }
			set { _weightUnitMeasureReturnsNewIfNotFound = value; }	
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
		protected override int LLBLGenProEntityTypeValue 
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
