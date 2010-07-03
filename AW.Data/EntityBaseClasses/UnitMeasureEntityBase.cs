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
	
	/// <summary>Entity base class which represents the base class for the entity 'UnitMeasure'.<br/><br/>
	/// 
	/// MS_Description: Unit of measure lookup table.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class UnitMeasureEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.BillOfMaterialsCollection	_billOfMaterials;
		private bool	_alwaysFetchBillOfMaterials, _alreadyFetchedBillOfMaterials;
		private AW.Data.CollectionClasses.ProductCollection	_product_;
		private bool	_alwaysFetchProduct_, _alreadyFetchedProduct_;
		private AW.Data.CollectionClasses.ProductCollection	_product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;
		private AW.Data.CollectionClasses.ProductVendorCollection	_productVendor;
		private bool	_alwaysFetchProductVendor, _alreadyFetchedProductVendor;
		private AW.Data.CollectionClasses.ProductCollection _productCollectionViaBillOfMaterials_;
		private bool	_alwaysFetchProductCollectionViaBillOfMaterials_, _alreadyFetchedProductCollectionViaBillOfMaterials_;
		private AW.Data.CollectionClasses.ProductCollection _productCollectionViaProductVendor;
		private bool	_alwaysFetchProductCollectionViaProductVendor, _alreadyFetchedProductCollectionViaProductVendor;
		private AW.Data.CollectionClasses.ProductCollection _productCollectionViaBillOfMaterials;
		private bool	_alwaysFetchProductCollectionViaBillOfMaterials, _alreadyFetchedProductCollectionViaBillOfMaterials;
		private AW.Data.CollectionClasses.ProductModelCollection _productModelCollectionViaProduct_;
		private bool	_alwaysFetchProductModelCollectionViaProduct_, _alreadyFetchedProductModelCollectionViaProduct_;
		private AW.Data.CollectionClasses.ProductModelCollection _productModelCollectionViaProduct;
		private bool	_alwaysFetchProductModelCollectionViaProduct, _alreadyFetchedProductModelCollectionViaProduct;
		private AW.Data.CollectionClasses.ProductSubcategoryCollection _productSubcategoryCollectionViaProduct_;
		private bool	_alwaysFetchProductSubcategoryCollectionViaProduct_, _alreadyFetchedProductSubcategoryCollectionViaProduct_;
		private AW.Data.CollectionClasses.ProductSubcategoryCollection _productSubcategoryCollectionViaProduct;
		private bool	_alwaysFetchProductSubcategoryCollectionViaProduct, _alreadyFetchedProductSubcategoryCollectionViaProduct;
		private AW.Data.CollectionClasses.VendorCollection _vendorCollectionViaProductVendor;
		private bool	_alwaysFetchVendorCollectionViaProductVendor, _alreadyFetchedVendorCollectionViaProductVendor;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name BillOfMaterials</summary>
			public static readonly string BillOfMaterials = "BillOfMaterials";
			/// <summary>Member name Product_</summary>
			public static readonly string Product_ = "Product_";
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
			/// <summary>Member name ProductVendor</summary>
			public static readonly string ProductVendor = "ProductVendor";
			/// <summary>Member name ProductCollectionViaBillOfMaterials_</summary>
			public static readonly string ProductCollectionViaBillOfMaterials_ = "ProductCollectionViaBillOfMaterials_";
			/// <summary>Member name ProductCollectionViaProductVendor</summary>
			public static readonly string ProductCollectionViaProductVendor = "ProductCollectionViaProductVendor";
			/// <summary>Member name ProductCollectionViaBillOfMaterials</summary>
			public static readonly string ProductCollectionViaBillOfMaterials = "ProductCollectionViaBillOfMaterials";
			/// <summary>Member name ProductModelCollectionViaProduct_</summary>
			public static readonly string ProductModelCollectionViaProduct_ = "ProductModelCollectionViaProduct_";
			/// <summary>Member name ProductModelCollectionViaProduct</summary>
			public static readonly string ProductModelCollectionViaProduct = "ProductModelCollectionViaProduct";
			/// <summary>Member name ProductSubcategoryCollectionViaProduct_</summary>
			public static readonly string ProductSubcategoryCollectionViaProduct_ = "ProductSubcategoryCollectionViaProduct_";
			/// <summary>Member name ProductSubcategoryCollectionViaProduct</summary>
			public static readonly string ProductSubcategoryCollectionViaProduct = "ProductSubcategoryCollectionViaProduct";
			/// <summary>Member name VendorCollectionViaProductVendor</summary>
			public static readonly string VendorCollectionViaProductVendor = "VendorCollectionViaProductVendor";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static UnitMeasureEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public UnitMeasureEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		public UnitMeasureEntityBase(System.String unitMeasureCode)
		{
			InitClassFetch(unitMeasureCode, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public UnitMeasureEntityBase(System.String unitMeasureCode, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(unitMeasureCode, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="validator">The custom validator object for this UnitMeasureEntity</param>
		public UnitMeasureEntityBase(System.String unitMeasureCode, IValidator validator)
		{
			InitClassFetch(unitMeasureCode, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UnitMeasureEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_billOfMaterials = (AW.Data.CollectionClasses.BillOfMaterialsCollection)info.GetValue("_billOfMaterials", typeof(AW.Data.CollectionClasses.BillOfMaterialsCollection));
			_alwaysFetchBillOfMaterials = info.GetBoolean("_alwaysFetchBillOfMaterials");
			_alreadyFetchedBillOfMaterials = info.GetBoolean("_alreadyFetchedBillOfMaterials");
			_product_ = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_product_", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProduct_ = info.GetBoolean("_alwaysFetchProduct_");
			_alreadyFetchedProduct_ = info.GetBoolean("_alreadyFetchedProduct_");
			_product = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_product", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");
			_productVendor = (AW.Data.CollectionClasses.ProductVendorCollection)info.GetValue("_productVendor", typeof(AW.Data.CollectionClasses.ProductVendorCollection));
			_alwaysFetchProductVendor = info.GetBoolean("_alwaysFetchProductVendor");
			_alreadyFetchedProductVendor = info.GetBoolean("_alreadyFetchedProductVendor");
			_productCollectionViaBillOfMaterials_ = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_productCollectionViaBillOfMaterials_", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProductCollectionViaBillOfMaterials_ = info.GetBoolean("_alwaysFetchProductCollectionViaBillOfMaterials_");
			_alreadyFetchedProductCollectionViaBillOfMaterials_ = info.GetBoolean("_alreadyFetchedProductCollectionViaBillOfMaterials_");
			_productCollectionViaProductVendor = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_productCollectionViaProductVendor", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProductCollectionViaProductVendor = info.GetBoolean("_alwaysFetchProductCollectionViaProductVendor");
			_alreadyFetchedProductCollectionViaProductVendor = info.GetBoolean("_alreadyFetchedProductCollectionViaProductVendor");
			_productCollectionViaBillOfMaterials = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_productCollectionViaBillOfMaterials", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProductCollectionViaBillOfMaterials = info.GetBoolean("_alwaysFetchProductCollectionViaBillOfMaterials");
			_alreadyFetchedProductCollectionViaBillOfMaterials = info.GetBoolean("_alreadyFetchedProductCollectionViaBillOfMaterials");
			_productModelCollectionViaProduct_ = (AW.Data.CollectionClasses.ProductModelCollection)info.GetValue("_productModelCollectionViaProduct_", typeof(AW.Data.CollectionClasses.ProductModelCollection));
			_alwaysFetchProductModelCollectionViaProduct_ = info.GetBoolean("_alwaysFetchProductModelCollectionViaProduct_");
			_alreadyFetchedProductModelCollectionViaProduct_ = info.GetBoolean("_alreadyFetchedProductModelCollectionViaProduct_");
			_productModelCollectionViaProduct = (AW.Data.CollectionClasses.ProductModelCollection)info.GetValue("_productModelCollectionViaProduct", typeof(AW.Data.CollectionClasses.ProductModelCollection));
			_alwaysFetchProductModelCollectionViaProduct = info.GetBoolean("_alwaysFetchProductModelCollectionViaProduct");
			_alreadyFetchedProductModelCollectionViaProduct = info.GetBoolean("_alreadyFetchedProductModelCollectionViaProduct");
			_productSubcategoryCollectionViaProduct_ = (AW.Data.CollectionClasses.ProductSubcategoryCollection)info.GetValue("_productSubcategoryCollectionViaProduct_", typeof(AW.Data.CollectionClasses.ProductSubcategoryCollection));
			_alwaysFetchProductSubcategoryCollectionViaProduct_ = info.GetBoolean("_alwaysFetchProductSubcategoryCollectionViaProduct_");
			_alreadyFetchedProductSubcategoryCollectionViaProduct_ = info.GetBoolean("_alreadyFetchedProductSubcategoryCollectionViaProduct_");
			_productSubcategoryCollectionViaProduct = (AW.Data.CollectionClasses.ProductSubcategoryCollection)info.GetValue("_productSubcategoryCollectionViaProduct", typeof(AW.Data.CollectionClasses.ProductSubcategoryCollection));
			_alwaysFetchProductSubcategoryCollectionViaProduct = info.GetBoolean("_alwaysFetchProductSubcategoryCollectionViaProduct");
			_alreadyFetchedProductSubcategoryCollectionViaProduct = info.GetBoolean("_alreadyFetchedProductSubcategoryCollectionViaProduct");
			_vendorCollectionViaProductVendor = (AW.Data.CollectionClasses.VendorCollection)info.GetValue("_vendorCollectionViaProductVendor", typeof(AW.Data.CollectionClasses.VendorCollection));
			_alwaysFetchVendorCollectionViaProductVendor = info.GetBoolean("_alwaysFetchVendorCollectionViaProductVendor");
			_alreadyFetchedVendorCollectionViaProductVendor = info.GetBoolean("_alreadyFetchedVendorCollectionViaProductVendor");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((UnitMeasureFieldIndex)fieldIndex)
			{
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
			_alreadyFetchedProduct_ = (_product_.Count > 0);
			_alreadyFetchedProduct = (_product.Count > 0);
			_alreadyFetchedProductVendor = (_productVendor.Count > 0);
			_alreadyFetchedProductCollectionViaBillOfMaterials_ = (_productCollectionViaBillOfMaterials_.Count > 0);
			_alreadyFetchedProductCollectionViaProductVendor = (_productCollectionViaProductVendor.Count > 0);
			_alreadyFetchedProductCollectionViaBillOfMaterials = (_productCollectionViaBillOfMaterials.Count > 0);
			_alreadyFetchedProductModelCollectionViaProduct_ = (_productModelCollectionViaProduct_.Count > 0);
			_alreadyFetchedProductModelCollectionViaProduct = (_productModelCollectionViaProduct.Count > 0);
			_alreadyFetchedProductSubcategoryCollectionViaProduct_ = (_productSubcategoryCollectionViaProduct_.Count > 0);
			_alreadyFetchedProductSubcategoryCollectionViaProduct = (_productSubcategoryCollectionViaProduct.Count > 0);
			_alreadyFetchedVendorCollectionViaProductVendor = (_vendorCollectionViaProductVendor.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return UnitMeasureEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "BillOfMaterials":
					toReturn.Add(UnitMeasureEntity.Relations.BillOfMaterialsEntityUsingUnitMeasureCode);
					break;
				case "Product_":
					toReturn.Add(UnitMeasureEntity.Relations.ProductEntityUsingWeightUnitMeasureCode);
					break;
				case "Product":
					toReturn.Add(UnitMeasureEntity.Relations.ProductEntityUsingSizeUnitMeasureCode);
					break;
				case "ProductVendor":
					toReturn.Add(UnitMeasureEntity.Relations.ProductVendorEntityUsingUnitMeasureCode);
					break;
				case "ProductCollectionViaBillOfMaterials_":
					toReturn.Add(UnitMeasureEntity.Relations.BillOfMaterialsEntityUsingUnitMeasureCode, "UnitMeasureEntity__", "BillOfMaterials_", JoinHint.None);
					toReturn.Add(BillOfMaterialsEntity.Relations.ProductEntityUsingProductAssemblyID, "BillOfMaterials_", string.Empty, JoinHint.None);
					break;
				case "ProductCollectionViaProductVendor":
					toReturn.Add(UnitMeasureEntity.Relations.ProductVendorEntityUsingUnitMeasureCode, "UnitMeasureEntity__", "ProductVendor_", JoinHint.None);
					toReturn.Add(ProductVendorEntity.Relations.ProductEntityUsingProductID, "ProductVendor_", string.Empty, JoinHint.None);
					break;
				case "ProductCollectionViaBillOfMaterials":
					toReturn.Add(UnitMeasureEntity.Relations.BillOfMaterialsEntityUsingUnitMeasureCode, "UnitMeasureEntity__", "BillOfMaterials_", JoinHint.None);
					toReturn.Add(BillOfMaterialsEntity.Relations.ProductEntityUsingComponentID, "BillOfMaterials_", string.Empty, JoinHint.None);
					break;
				case "ProductModelCollectionViaProduct_":
					toReturn.Add(UnitMeasureEntity.Relations.ProductEntityUsingWeightUnitMeasureCode, "UnitMeasureEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductModelEntityUsingProductModelID, "Product_", string.Empty, JoinHint.None);
					break;
				case "ProductModelCollectionViaProduct":
					toReturn.Add(UnitMeasureEntity.Relations.ProductEntityUsingSizeUnitMeasureCode, "UnitMeasureEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductModelEntityUsingProductModelID, "Product_", string.Empty, JoinHint.None);
					break;
				case "ProductSubcategoryCollectionViaProduct_":
					toReturn.Add(UnitMeasureEntity.Relations.ProductEntityUsingWeightUnitMeasureCode, "UnitMeasureEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryID, "Product_", string.Empty, JoinHint.None);
					break;
				case "ProductSubcategoryCollectionViaProduct":
					toReturn.Add(UnitMeasureEntity.Relations.ProductEntityUsingSizeUnitMeasureCode, "UnitMeasureEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryID, "Product_", string.Empty, JoinHint.None);
					break;
				case "VendorCollectionViaProductVendor":
					toReturn.Add(UnitMeasureEntity.Relations.ProductVendorEntityUsingUnitMeasureCode, "UnitMeasureEntity__", "ProductVendor_", JoinHint.None);
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
			info.AddValue("_product_", (!this.MarkedForDeletion?_product_:null));
			info.AddValue("_alwaysFetchProduct_", _alwaysFetchProduct_);
			info.AddValue("_alreadyFetchedProduct_", _alreadyFetchedProduct_);
			info.AddValue("_product", (!this.MarkedForDeletion?_product:null));
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_productVendor", (!this.MarkedForDeletion?_productVendor:null));
			info.AddValue("_alwaysFetchProductVendor", _alwaysFetchProductVendor);
			info.AddValue("_alreadyFetchedProductVendor", _alreadyFetchedProductVendor);
			info.AddValue("_productCollectionViaBillOfMaterials_", (!this.MarkedForDeletion?_productCollectionViaBillOfMaterials_:null));
			info.AddValue("_alwaysFetchProductCollectionViaBillOfMaterials_", _alwaysFetchProductCollectionViaBillOfMaterials_);
			info.AddValue("_alreadyFetchedProductCollectionViaBillOfMaterials_", _alreadyFetchedProductCollectionViaBillOfMaterials_);
			info.AddValue("_productCollectionViaProductVendor", (!this.MarkedForDeletion?_productCollectionViaProductVendor:null));
			info.AddValue("_alwaysFetchProductCollectionViaProductVendor", _alwaysFetchProductCollectionViaProductVendor);
			info.AddValue("_alreadyFetchedProductCollectionViaProductVendor", _alreadyFetchedProductCollectionViaProductVendor);
			info.AddValue("_productCollectionViaBillOfMaterials", (!this.MarkedForDeletion?_productCollectionViaBillOfMaterials:null));
			info.AddValue("_alwaysFetchProductCollectionViaBillOfMaterials", _alwaysFetchProductCollectionViaBillOfMaterials);
			info.AddValue("_alreadyFetchedProductCollectionViaBillOfMaterials", _alreadyFetchedProductCollectionViaBillOfMaterials);
			info.AddValue("_productModelCollectionViaProduct_", (!this.MarkedForDeletion?_productModelCollectionViaProduct_:null));
			info.AddValue("_alwaysFetchProductModelCollectionViaProduct_", _alwaysFetchProductModelCollectionViaProduct_);
			info.AddValue("_alreadyFetchedProductModelCollectionViaProduct_", _alreadyFetchedProductModelCollectionViaProduct_);
			info.AddValue("_productModelCollectionViaProduct", (!this.MarkedForDeletion?_productModelCollectionViaProduct:null));
			info.AddValue("_alwaysFetchProductModelCollectionViaProduct", _alwaysFetchProductModelCollectionViaProduct);
			info.AddValue("_alreadyFetchedProductModelCollectionViaProduct", _alreadyFetchedProductModelCollectionViaProduct);
			info.AddValue("_productSubcategoryCollectionViaProduct_", (!this.MarkedForDeletion?_productSubcategoryCollectionViaProduct_:null));
			info.AddValue("_alwaysFetchProductSubcategoryCollectionViaProduct_", _alwaysFetchProductSubcategoryCollectionViaProduct_);
			info.AddValue("_alreadyFetchedProductSubcategoryCollectionViaProduct_", _alreadyFetchedProductSubcategoryCollectionViaProduct_);
			info.AddValue("_productSubcategoryCollectionViaProduct", (!this.MarkedForDeletion?_productSubcategoryCollectionViaProduct:null));
			info.AddValue("_alwaysFetchProductSubcategoryCollectionViaProduct", _alwaysFetchProductSubcategoryCollectionViaProduct);
			info.AddValue("_alreadyFetchedProductSubcategoryCollectionViaProduct", _alreadyFetchedProductSubcategoryCollectionViaProduct);
			info.AddValue("_vendorCollectionViaProductVendor", (!this.MarkedForDeletion?_vendorCollectionViaProductVendor:null));
			info.AddValue("_alwaysFetchVendorCollectionViaProductVendor", _alwaysFetchVendorCollectionViaProductVendor);
			info.AddValue("_alreadyFetchedVendorCollectionViaProductVendor", _alreadyFetchedVendorCollectionViaProductVendor);


			
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

				case "BillOfMaterials":
					_alreadyFetchedBillOfMaterials = true;
					if(entity!=null)
					{
						this.BillOfMaterials.Add((BillOfMaterialsEntity)entity);
					}
					break;
				case "Product_":
					_alreadyFetchedProduct_ = true;
					if(entity!=null)
					{
						this.Product_.Add((ProductEntity)entity);
					}
					break;
				case "Product":
					_alreadyFetchedProduct = true;
					if(entity!=null)
					{
						this.Product.Add((ProductEntity)entity);
					}
					break;
				case "ProductVendor":
					_alreadyFetchedProductVendor = true;
					if(entity!=null)
					{
						this.ProductVendor.Add((ProductVendorEntity)entity);
					}
					break;
				case "ProductCollectionViaBillOfMaterials_":
					_alreadyFetchedProductCollectionViaBillOfMaterials_ = true;
					if(entity!=null)
					{
						this.ProductCollectionViaBillOfMaterials_.Add((ProductEntity)entity);
					}
					break;
				case "ProductCollectionViaProductVendor":
					_alreadyFetchedProductCollectionViaProductVendor = true;
					if(entity!=null)
					{
						this.ProductCollectionViaProductVendor.Add((ProductEntity)entity);
					}
					break;
				case "ProductCollectionViaBillOfMaterials":
					_alreadyFetchedProductCollectionViaBillOfMaterials = true;
					if(entity!=null)
					{
						this.ProductCollectionViaBillOfMaterials.Add((ProductEntity)entity);
					}
					break;
				case "ProductModelCollectionViaProduct_":
					_alreadyFetchedProductModelCollectionViaProduct_ = true;
					if(entity!=null)
					{
						this.ProductModelCollectionViaProduct_.Add((ProductModelEntity)entity);
					}
					break;
				case "ProductModelCollectionViaProduct":
					_alreadyFetchedProductModelCollectionViaProduct = true;
					if(entity!=null)
					{
						this.ProductModelCollectionViaProduct.Add((ProductModelEntity)entity);
					}
					break;
				case "ProductSubcategoryCollectionViaProduct_":
					_alreadyFetchedProductSubcategoryCollectionViaProduct_ = true;
					if(entity!=null)
					{
						this.ProductSubcategoryCollectionViaProduct_.Add((ProductSubcategoryEntity)entity);
					}
					break;
				case "ProductSubcategoryCollectionViaProduct":
					_alreadyFetchedProductSubcategoryCollectionViaProduct = true;
					if(entity!=null)
					{
						this.ProductSubcategoryCollectionViaProduct.Add((ProductSubcategoryEntity)entity);
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

				case "BillOfMaterials":
					_billOfMaterials.Add((BillOfMaterialsEntity)relatedEntity);
					break;
				case "Product_":
					_product_.Add((ProductEntity)relatedEntity);
					break;
				case "Product":
					_product.Add((ProductEntity)relatedEntity);
					break;
				case "ProductVendor":
					_productVendor.Add((ProductVendorEntity)relatedEntity);
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

				case "BillOfMaterials":
					base.PerformRelatedEntityRemoval(_billOfMaterials, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Product_":
					base.PerformRelatedEntityRemoval(_product_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Product":
					base.PerformRelatedEntityRemoval(_product, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductVendor":
					base.PerformRelatedEntityRemoval(_productVendor, relatedEntity, signalRelatedEntityManyToOne);
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



			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_billOfMaterials);
			toReturn.Add(_product_);
			toReturn.Add(_product);
			toReturn.Add(_productVendor);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String unitMeasureCode)
		{
			return FetchUsingPK(unitMeasureCode, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String unitMeasureCode, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(unitMeasureCode, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String unitMeasureCode, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(unitMeasureCode, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String unitMeasureCode, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(unitMeasureCode, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.UnitMeasureCode, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(UnitMeasureFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(UnitMeasureFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new UnitMeasureRelations().GetAllRelations();
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
				_billOfMaterials.GetMultiManyToOne(null, null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProduct_(bool forceFetch)
		{
			return GetMultiProduct_(forceFetch, _product_.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProduct_(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProduct_(forceFetch, _product_.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProduct_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProduct_(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductCollection GetMultiProduct_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProduct_ || forceFetch || _alwaysFetchProduct_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_product_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product_);
					}
				}
				_product_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_product_.EntityFactoryToUse = entityFactoryToUse;
				}
				_product_.GetMultiManyToOne(null, null, null, this, filter);
				_product_.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct_ = true;
			}
			return _product_;
		}

		/// <summary> Sets the collection parameters for the collection for 'Product_'. These settings will be taken into account
		/// when the property Product_ is requested or GetMultiProduct_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProduct_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_product_.SortClauses=sortClauses;
			_product_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProduct(bool forceFetch)
		{
			return GetMultiProduct(forceFetch, _product.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProduct(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProduct(forceFetch, _product.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProduct(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductCollection GetMultiProduct(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProduct || forceFetch || _alwaysFetchProduct) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_product.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product);
					}
				}
				_product.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_product.EntityFactoryToUse = entityFactoryToUse;
				}
				_product.GetMultiManyToOne(null, null, this, null, filter);
				_product.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct = true;
			}
			return _product;
		}

		/// <summary> Sets the collection parameters for the collection for 'Product'. These settings will be taken into account
		/// when the property Product is requested or GetMultiProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_product.SortClauses=sortClauses;
			_product.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_productVendor.GetMultiManyToOne(null, this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaBillOfMaterials_(bool forceFetch)
		{
			return GetMultiProductCollectionViaBillOfMaterials_(forceFetch, _productCollectionViaBillOfMaterials_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaBillOfMaterials_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductCollectionViaBillOfMaterials_ || forceFetch || _alwaysFetchProductCollectionViaBillOfMaterials_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productCollectionViaBillOfMaterials_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCollectionViaBillOfMaterials_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
				_productCollectionViaBillOfMaterials_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productCollectionViaBillOfMaterials_.EntityFactoryToUse = entityFactoryToUse;
				}
				_productCollectionViaBillOfMaterials_.GetMulti(filter, GetRelationsForField("ProductCollectionViaBillOfMaterials_"));
				_productCollectionViaBillOfMaterials_.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCollectionViaBillOfMaterials_ = true;
			}
			return _productCollectionViaBillOfMaterials_;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductCollectionViaBillOfMaterials_'. These settings will be taken into account
		/// when the property ProductCollectionViaBillOfMaterials_ is requested or GetMultiProductCollectionViaBillOfMaterials_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductCollectionViaBillOfMaterials_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productCollectionViaBillOfMaterials_.SortClauses=sortClauses;
			_productCollectionViaBillOfMaterials_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaProductVendor(bool forceFetch)
		{
			return GetMultiProductCollectionViaProductVendor(forceFetch, _productCollectionViaProductVendor.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaProductVendor(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductCollectionViaProductVendor || forceFetch || _alwaysFetchProductCollectionViaProductVendor) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productCollectionViaProductVendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCollectionViaProductVendor);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
				_productCollectionViaProductVendor.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productCollectionViaProductVendor.EntityFactoryToUse = entityFactoryToUse;
				}
				_productCollectionViaProductVendor.GetMulti(filter, GetRelationsForField("ProductCollectionViaProductVendor"));
				_productCollectionViaProductVendor.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCollectionViaProductVendor = true;
			}
			return _productCollectionViaProductVendor;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductCollectionViaProductVendor'. These settings will be taken into account
		/// when the property ProductCollectionViaProductVendor is requested or GetMultiProductCollectionViaProductVendor is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductCollectionViaProductVendor(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productCollectionViaProductVendor.SortClauses=sortClauses;
			_productCollectionViaProductVendor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaBillOfMaterials(bool forceFetch)
		{
			return GetMultiProductCollectionViaBillOfMaterials(forceFetch, _productCollectionViaBillOfMaterials.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaBillOfMaterials(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductCollectionViaBillOfMaterials || forceFetch || _alwaysFetchProductCollectionViaBillOfMaterials) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productCollectionViaBillOfMaterials.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCollectionViaBillOfMaterials);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
				_productCollectionViaBillOfMaterials.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productCollectionViaBillOfMaterials.EntityFactoryToUse = entityFactoryToUse;
				}
				_productCollectionViaBillOfMaterials.GetMulti(filter, GetRelationsForField("ProductCollectionViaBillOfMaterials"));
				_productCollectionViaBillOfMaterials.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCollectionViaBillOfMaterials = true;
			}
			return _productCollectionViaBillOfMaterials;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductCollectionViaBillOfMaterials'. These settings will be taken into account
		/// when the property ProductCollectionViaBillOfMaterials is requested or GetMultiProductCollectionViaBillOfMaterials is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductCollectionViaBillOfMaterials(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productCollectionViaBillOfMaterials.SortClauses=sortClauses;
			_productCollectionViaBillOfMaterials.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelCollection GetMultiProductModelCollectionViaProduct_(bool forceFetch)
		{
			return GetMultiProductModelCollectionViaProduct_(forceFetch, _productModelCollectionViaProduct_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductModelCollection GetMultiProductModelCollectionViaProduct_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductModelCollectionViaProduct_ || forceFetch || _alwaysFetchProductModelCollectionViaProduct_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelCollectionViaProduct_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelCollectionViaProduct_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
				_productModelCollectionViaProduct_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productModelCollectionViaProduct_.EntityFactoryToUse = entityFactoryToUse;
				}
				_productModelCollectionViaProduct_.GetMulti(filter, GetRelationsForField("ProductModelCollectionViaProduct_"));
				_productModelCollectionViaProduct_.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelCollectionViaProduct_ = true;
			}
			return _productModelCollectionViaProduct_;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductModelCollectionViaProduct_'. These settings will be taken into account
		/// when the property ProductModelCollectionViaProduct_ is requested or GetMultiProductModelCollectionViaProduct_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelCollectionViaProduct_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelCollectionViaProduct_.SortClauses=sortClauses;
			_productModelCollectionViaProduct_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelCollection GetMultiProductModelCollectionViaProduct(bool forceFetch)
		{
			return GetMultiProductModelCollectionViaProduct(forceFetch, _productModelCollectionViaProduct.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductModelCollection GetMultiProductModelCollectionViaProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductModelCollectionViaProduct || forceFetch || _alwaysFetchProductModelCollectionViaProduct) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelCollectionViaProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelCollectionViaProduct);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
				_productModelCollectionViaProduct.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productModelCollectionViaProduct.EntityFactoryToUse = entityFactoryToUse;
				}
				_productModelCollectionViaProduct.GetMulti(filter, GetRelationsForField("ProductModelCollectionViaProduct"));
				_productModelCollectionViaProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelCollectionViaProduct = true;
			}
			return _productModelCollectionViaProduct;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductModelCollectionViaProduct'. These settings will be taken into account
		/// when the property ProductModelCollectionViaProduct is requested or GetMultiProductModelCollectionViaProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelCollectionViaProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelCollectionViaProduct.SortClauses=sortClauses;
			_productModelCollectionViaProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductSubcategoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductSubcategoryCollection GetMultiProductSubcategoryCollectionViaProduct_(bool forceFetch)
		{
			return GetMultiProductSubcategoryCollectionViaProduct_(forceFetch, _productSubcategoryCollectionViaProduct_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductSubcategoryCollection GetMultiProductSubcategoryCollectionViaProduct_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductSubcategoryCollectionViaProduct_ || forceFetch || _alwaysFetchProductSubcategoryCollectionViaProduct_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productSubcategoryCollectionViaProduct_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productSubcategoryCollectionViaProduct_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
				_productSubcategoryCollectionViaProduct_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productSubcategoryCollectionViaProduct_.EntityFactoryToUse = entityFactoryToUse;
				}
				_productSubcategoryCollectionViaProduct_.GetMulti(filter, GetRelationsForField("ProductSubcategoryCollectionViaProduct_"));
				_productSubcategoryCollectionViaProduct_.SuppressClearInGetMulti=false;
				_alreadyFetchedProductSubcategoryCollectionViaProduct_ = true;
			}
			return _productSubcategoryCollectionViaProduct_;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductSubcategoryCollectionViaProduct_'. These settings will be taken into account
		/// when the property ProductSubcategoryCollectionViaProduct_ is requested or GetMultiProductSubcategoryCollectionViaProduct_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductSubcategoryCollectionViaProduct_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productSubcategoryCollectionViaProduct_.SortClauses=sortClauses;
			_productSubcategoryCollectionViaProduct_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductSubcategoryEntity'</returns>
		public AW.Data.CollectionClasses.ProductSubcategoryCollection GetMultiProductSubcategoryCollectionViaProduct(bool forceFetch)
		{
			return GetMultiProductSubcategoryCollectionViaProduct(forceFetch, _productSubcategoryCollectionViaProduct.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductSubcategoryCollection GetMultiProductSubcategoryCollectionViaProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductSubcategoryCollectionViaProduct || forceFetch || _alwaysFetchProductSubcategoryCollectionViaProduct) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productSubcategoryCollectionViaProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productSubcategoryCollectionViaProduct);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
				_productSubcategoryCollectionViaProduct.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productSubcategoryCollectionViaProduct.EntityFactoryToUse = entityFactoryToUse;
				}
				_productSubcategoryCollectionViaProduct.GetMulti(filter, GetRelationsForField("ProductSubcategoryCollectionViaProduct"));
				_productSubcategoryCollectionViaProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedProductSubcategoryCollectionViaProduct = true;
			}
			return _productSubcategoryCollectionViaProduct;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductSubcategoryCollectionViaProduct'. These settings will be taken into account
		/// when the property ProductSubcategoryCollectionViaProduct is requested or GetMultiProductSubcategoryCollectionViaProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductSubcategoryCollectionViaProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productSubcategoryCollectionViaProduct.SortClauses=sortClauses;
			_productSubcategoryCollectionViaProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, ComparisonOperator.Equal, this.UnitMeasureCode, "UnitMeasureEntity__"));
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



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			UnitMeasureDAO dao = (UnitMeasureDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_billOfMaterials.ActiveContext = base.ActiveContext;
			_product_.ActiveContext = base.ActiveContext;
			_product.ActiveContext = base.ActiveContext;
			_productVendor.ActiveContext = base.ActiveContext;
			_productCollectionViaBillOfMaterials_.ActiveContext = base.ActiveContext;
			_productCollectionViaProductVendor.ActiveContext = base.ActiveContext;
			_productCollectionViaBillOfMaterials.ActiveContext = base.ActiveContext;
			_productModelCollectionViaProduct_.ActiveContext = base.ActiveContext;
			_productModelCollectionViaProduct.ActiveContext = base.ActiveContext;
			_productSubcategoryCollectionViaProduct_.ActiveContext = base.ActiveContext;
			_productSubcategoryCollectionViaProduct.ActiveContext = base.ActiveContext;
			_vendorCollectionViaProductVendor.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			UnitMeasureDAO dao = (UnitMeasureDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			UnitMeasureDAO dao = (UnitMeasureDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.UnitMeasureEntity);
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

			toReturn.Add("BillOfMaterials", _billOfMaterials);
			toReturn.Add("Product_", _product_);
			toReturn.Add("Product", _product);
			toReturn.Add("ProductVendor", _productVendor);
			toReturn.Add("ProductCollectionViaBillOfMaterials_", _productCollectionViaBillOfMaterials_);
			toReturn.Add("ProductCollectionViaProductVendor", _productCollectionViaProductVendor);
			toReturn.Add("ProductCollectionViaBillOfMaterials", _productCollectionViaBillOfMaterials);
			toReturn.Add("ProductModelCollectionViaProduct_", _productModelCollectionViaProduct_);
			toReturn.Add("ProductModelCollectionViaProduct", _productModelCollectionViaProduct);
			toReturn.Add("ProductSubcategoryCollectionViaProduct_", _productSubcategoryCollectionViaProduct_);
			toReturn.Add("ProductSubcategoryCollectionViaProduct", _productSubcategoryCollectionViaProduct);
			toReturn.Add("VendorCollectionViaProductVendor", _vendorCollectionViaProductVendor);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="validator">The validator object for this UnitMeasureEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.String unitMeasureCode, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(unitMeasureCode, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_billOfMaterials = new AW.Data.CollectionClasses.BillOfMaterialsCollection(new BillOfMaterialsEntityFactory());
			_billOfMaterials.SetContainingEntityInfo(this, "UnitMeasure");
			_alwaysFetchBillOfMaterials = false;
			_alreadyFetchedBillOfMaterials = false;
			_product_ = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_product_.SetContainingEntityInfo(this, "UnitMeasure_");
			_alwaysFetchProduct_ = false;
			_alreadyFetchedProduct_ = false;
			_product = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_product.SetContainingEntityInfo(this, "UnitMeasure");
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;
			_productVendor = new AW.Data.CollectionClasses.ProductVendorCollection(new ProductVendorEntityFactory());
			_productVendor.SetContainingEntityInfo(this, "UnitMeasure");
			_alwaysFetchProductVendor = false;
			_alreadyFetchedProductVendor = false;
			_productCollectionViaBillOfMaterials_ = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_alwaysFetchProductCollectionViaBillOfMaterials_ = false;
			_alreadyFetchedProductCollectionViaBillOfMaterials_ = false;
			_productCollectionViaProductVendor = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_alwaysFetchProductCollectionViaProductVendor = false;
			_alreadyFetchedProductCollectionViaProductVendor = false;
			_productCollectionViaBillOfMaterials = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_alwaysFetchProductCollectionViaBillOfMaterials = false;
			_alreadyFetchedProductCollectionViaBillOfMaterials = false;
			_productModelCollectionViaProduct_ = new AW.Data.CollectionClasses.ProductModelCollection(new ProductModelEntityFactory());
			_alwaysFetchProductModelCollectionViaProduct_ = false;
			_alreadyFetchedProductModelCollectionViaProduct_ = false;
			_productModelCollectionViaProduct = new AW.Data.CollectionClasses.ProductModelCollection(new ProductModelEntityFactory());
			_alwaysFetchProductModelCollectionViaProduct = false;
			_alreadyFetchedProductModelCollectionViaProduct = false;
			_productSubcategoryCollectionViaProduct_ = new AW.Data.CollectionClasses.ProductSubcategoryCollection(new ProductSubcategoryEntityFactory());
			_alwaysFetchProductSubcategoryCollectionViaProduct_ = false;
			_alreadyFetchedProductSubcategoryCollectionViaProduct_ = false;
			_productSubcategoryCollectionViaProduct = new AW.Data.CollectionClasses.ProductSubcategoryCollection(new ProductSubcategoryEntityFactory());
			_alwaysFetchProductSubcategoryCollectionViaProduct = false;
			_alreadyFetchedProductSubcategoryCollectionViaProduct = false;
			_vendorCollectionViaProductVendor = new AW.Data.CollectionClasses.VendorCollection(new VendorEntityFactory());
			_alwaysFetchVendorCollectionViaProductVendor = false;
			_alreadyFetchedVendorCollectionViaProductVendor = false;



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
			_customProperties.Add("MS_Description", @"Unit of measure lookup table.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("UnitMeasureCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unit of measure description.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String unitMeasureCode, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)UnitMeasureFieldIndex.UnitMeasureCode].ForcedCurrentValueWrite(unitMeasureCode);
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
			return DAOFactory.CreateUnitMeasureDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new UnitMeasureEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static UnitMeasureRelations Relations
		{
			get	{ return new UnitMeasureRelations(); }
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
					(IEntityRelation)GetRelationsForField("BillOfMaterials")[0], (int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.BillOfMaterialsEntity, 0, null, null, null, "BillOfMaterials", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProduct_
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(),
					(IEntityRelation)GetRelationsForField("Product_")[0], (int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Product_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProduct
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(),
					(IEntityRelation)GetRelationsForField("Product")[0], (int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Product", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("ProductVendor")[0], (int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductVendorEntity, 0, null, null, null, "ProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCollectionViaBillOfMaterials_
		{
			get
			{
				IEntityRelation intermediateRelation = UnitMeasureEntity.Relations.BillOfMaterialsEntityUsingUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "BillOfMaterials_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), intermediateRelation,
					(int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaBillOfMaterials_"), "ProductCollectionViaBillOfMaterials_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCollectionViaProductVendor
		{
			get
			{
				IEntityRelation intermediateRelation = UnitMeasureEntity.Relations.ProductVendorEntityUsingUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "ProductVendor_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), intermediateRelation,
					(int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaProductVendor"), "ProductCollectionViaProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCollectionViaBillOfMaterials
		{
			get
			{
				IEntityRelation intermediateRelation = UnitMeasureEntity.Relations.BillOfMaterialsEntityUsingUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "BillOfMaterials_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), intermediateRelation,
					(int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaBillOfMaterials"), "ProductCollectionViaBillOfMaterials", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModel' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModelCollectionViaProduct_
		{
			get
			{
				IEntityRelation intermediateRelation = UnitMeasureEntity.Relations.ProductEntityUsingWeightUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelCollection(), intermediateRelation,
					(int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductModelEntity, 0, null, null, GetRelationsForField("ProductModelCollectionViaProduct_"), "ProductModelCollectionViaProduct_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModel' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModelCollectionViaProduct
		{
			get
			{
				IEntityRelation intermediateRelation = UnitMeasureEntity.Relations.ProductEntityUsingSizeUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelCollection(), intermediateRelation,
					(int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductModelEntity, 0, null, null, GetRelationsForField("ProductModelCollectionViaProduct"), "ProductModelCollectionViaProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductSubcategory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductSubcategoryCollectionViaProduct_
		{
			get
			{
				IEntityRelation intermediateRelation = UnitMeasureEntity.Relations.ProductEntityUsingWeightUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductSubcategoryCollection(), intermediateRelation,
					(int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductSubcategoryEntity, 0, null, null, GetRelationsForField("ProductSubcategoryCollectionViaProduct_"), "ProductSubcategoryCollectionViaProduct_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductSubcategory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductSubcategoryCollectionViaProduct
		{
			get
			{
				IEntityRelation intermediateRelation = UnitMeasureEntity.Relations.ProductEntityUsingSizeUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductSubcategoryCollection(), intermediateRelation,
					(int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.ProductSubcategoryEntity, 0, null, null, GetRelationsForField("ProductSubcategoryCollectionViaProduct"), "ProductSubcategoryCollectionViaProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Vendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorCollectionViaProductVendor
		{
			get
			{
				IEntityRelation intermediateRelation = UnitMeasureEntity.Relations.ProductVendorEntityUsingUnitMeasureCode;
				intermediateRelation.SetAliases(string.Empty, "ProductVendor_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorCollection(), intermediateRelation,
					(int)AW.Data.EntityType.UnitMeasureEntity, (int)AW.Data.EntityType.VendorEntity, 0, null, null, GetRelationsForField("VendorCollectionViaProductVendor"), "VendorCollectionViaProductVendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "UnitMeasureEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return UnitMeasureEntity.CustomProperties;}
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
			get { return UnitMeasureEntity.FieldsCustomProperties;}
		}

		/// <summary> The UnitMeasureCode property of the Entity UnitMeasure<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "UnitMeasure"."UnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String UnitMeasureCode
		{
			get { return (System.String)GetValue((int)UnitMeasureFieldIndex.UnitMeasureCode, true); }
			set	{ SetValue((int)UnitMeasureFieldIndex.UnitMeasureCode, value, true); }
		}
		/// <summary> The Name property of the Entity UnitMeasure<br/><br/>
		/// 
		/// MS_Description: Unit of measure description.<br/></summary>
		/// <remarks>Mapped on  table field: "UnitMeasure"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)UnitMeasureFieldIndex.Name, true); }
			set	{ SetValue((int)UnitMeasureFieldIndex.Name, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity UnitMeasure<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "UnitMeasure"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)UnitMeasureFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)UnitMeasureFieldIndex.ModifiedDate, value, true); }
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
		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProduct_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection Product_
		{
			get	{ return GetMultiProduct_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Product_. When set to true, Product_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiProduct_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct_
		{
			get	{ return _alwaysFetchProduct_; }
			set	{ _alwaysFetchProduct_ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Product_ already has been fetched. Setting this property to false when Product_ has been fetched
		/// will clear the Product_ collection well. Setting this property to true while Product_ hasn't been fetched disables lazy loading for Product_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProduct_
		{
			get { return _alreadyFetchedProduct_;}
			set 
			{
				if(_alreadyFetchedProduct_ && !value && (_product_ != null))
				{
					_product_.Clear();
				}
				_alreadyFetchedProduct_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection Product
		{
			get	{ return GetMultiProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Product. When set to true, Product is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product is accessed. You can always execute
		/// a forced fetch by calling GetMultiProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct
		{
			get	{ return _alwaysFetchProduct; }
			set	{ _alwaysFetchProduct = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Product already has been fetched. Setting this property to false when Product has been fetched
		/// will clear the Product collection well. Setting this property to true while Product hasn't been fetched disables lazy loading for Product</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProduct
		{
			get { return _alreadyFetchedProduct;}
			set 
			{
				if(_alreadyFetchedProduct && !value && (_product != null))
				{
					_product.Clear();
				}
				_alreadyFetchedProduct = value;
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

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductCollectionViaBillOfMaterials_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection ProductCollectionViaBillOfMaterials_
		{
			get { return GetMultiProductCollectionViaBillOfMaterials_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCollectionViaBillOfMaterials_. When set to true, ProductCollectionViaBillOfMaterials_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCollectionViaBillOfMaterials_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductCollectionViaBillOfMaterials_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCollectionViaBillOfMaterials_
		{
			get	{ return _alwaysFetchProductCollectionViaBillOfMaterials_; }
			set	{ _alwaysFetchProductCollectionViaBillOfMaterials_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductCollectionViaBillOfMaterials_ already has been fetched. Setting this property to false when ProductCollectionViaBillOfMaterials_ has been fetched
		/// will clear the ProductCollectionViaBillOfMaterials_ collection well. Setting this property to true while ProductCollectionViaBillOfMaterials_ hasn't been fetched disables lazy loading for ProductCollectionViaBillOfMaterials_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductCollectionViaBillOfMaterials_
		{
			get { return _alreadyFetchedProductCollectionViaBillOfMaterials_;}
			set 
			{
				if(_alreadyFetchedProductCollectionViaBillOfMaterials_ && !value && (_productCollectionViaBillOfMaterials_ != null))
				{
					_productCollectionViaBillOfMaterials_.Clear();
				}
				_alreadyFetchedProductCollectionViaBillOfMaterials_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductCollectionViaProductVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection ProductCollectionViaProductVendor
		{
			get { return GetMultiProductCollectionViaProductVendor(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCollectionViaProductVendor. When set to true, ProductCollectionViaProductVendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCollectionViaProductVendor is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductCollectionViaProductVendor(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCollectionViaProductVendor
		{
			get	{ return _alwaysFetchProductCollectionViaProductVendor; }
			set	{ _alwaysFetchProductCollectionViaProductVendor = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductCollectionViaProductVendor already has been fetched. Setting this property to false when ProductCollectionViaProductVendor has been fetched
		/// will clear the ProductCollectionViaProductVendor collection well. Setting this property to true while ProductCollectionViaProductVendor hasn't been fetched disables lazy loading for ProductCollectionViaProductVendor</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductCollectionViaProductVendor
		{
			get { return _alreadyFetchedProductCollectionViaProductVendor;}
			set 
			{
				if(_alreadyFetchedProductCollectionViaProductVendor && !value && (_productCollectionViaProductVendor != null))
				{
					_productCollectionViaProductVendor.Clear();
				}
				_alreadyFetchedProductCollectionViaProductVendor = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductCollectionViaBillOfMaterials()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection ProductCollectionViaBillOfMaterials
		{
			get { return GetMultiProductCollectionViaBillOfMaterials(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCollectionViaBillOfMaterials. When set to true, ProductCollectionViaBillOfMaterials is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCollectionViaBillOfMaterials is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductCollectionViaBillOfMaterials(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCollectionViaBillOfMaterials
		{
			get	{ return _alwaysFetchProductCollectionViaBillOfMaterials; }
			set	{ _alwaysFetchProductCollectionViaBillOfMaterials = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductCollectionViaBillOfMaterials already has been fetched. Setting this property to false when ProductCollectionViaBillOfMaterials has been fetched
		/// will clear the ProductCollectionViaBillOfMaterials collection well. Setting this property to true while ProductCollectionViaBillOfMaterials hasn't been fetched disables lazy loading for ProductCollectionViaBillOfMaterials</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductCollectionViaBillOfMaterials
		{
			get { return _alreadyFetchedProductCollectionViaBillOfMaterials;}
			set 
			{
				if(_alreadyFetchedProductCollectionViaBillOfMaterials && !value && (_productCollectionViaBillOfMaterials != null))
				{
					_productCollectionViaBillOfMaterials.Clear();
				}
				_alreadyFetchedProductCollectionViaBillOfMaterials = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelCollectionViaProduct_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductModelCollection ProductModelCollectionViaProduct_
		{
			get { return GetMultiProductModelCollectionViaProduct_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModelCollectionViaProduct_. When set to true, ProductModelCollectionViaProduct_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelCollectionViaProduct_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModelCollectionViaProduct_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelCollectionViaProduct_
		{
			get	{ return _alwaysFetchProductModelCollectionViaProduct_; }
			set	{ _alwaysFetchProductModelCollectionViaProduct_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModelCollectionViaProduct_ already has been fetched. Setting this property to false when ProductModelCollectionViaProduct_ has been fetched
		/// will clear the ProductModelCollectionViaProduct_ collection well. Setting this property to true while ProductModelCollectionViaProduct_ hasn't been fetched disables lazy loading for ProductModelCollectionViaProduct_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModelCollectionViaProduct_
		{
			get { return _alreadyFetchedProductModelCollectionViaProduct_;}
			set 
			{
				if(_alreadyFetchedProductModelCollectionViaProduct_ && !value && (_productModelCollectionViaProduct_ != null))
				{
					_productModelCollectionViaProduct_.Clear();
				}
				_alreadyFetchedProductModelCollectionViaProduct_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelCollectionViaProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductModelCollection ProductModelCollectionViaProduct
		{
			get { return GetMultiProductModelCollectionViaProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModelCollectionViaProduct. When set to true, ProductModelCollectionViaProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelCollectionViaProduct is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModelCollectionViaProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelCollectionViaProduct
		{
			get	{ return _alwaysFetchProductModelCollectionViaProduct; }
			set	{ _alwaysFetchProductModelCollectionViaProduct = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModelCollectionViaProduct already has been fetched. Setting this property to false when ProductModelCollectionViaProduct has been fetched
		/// will clear the ProductModelCollectionViaProduct collection well. Setting this property to true while ProductModelCollectionViaProduct hasn't been fetched disables lazy loading for ProductModelCollectionViaProduct</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModelCollectionViaProduct
		{
			get { return _alreadyFetchedProductModelCollectionViaProduct;}
			set 
			{
				if(_alreadyFetchedProductModelCollectionViaProduct && !value && (_productModelCollectionViaProduct != null))
				{
					_productModelCollectionViaProduct.Clear();
				}
				_alreadyFetchedProductModelCollectionViaProduct = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductSubcategoryCollectionViaProduct_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductSubcategoryCollection ProductSubcategoryCollectionViaProduct_
		{
			get { return GetMultiProductSubcategoryCollectionViaProduct_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductSubcategoryCollectionViaProduct_. When set to true, ProductSubcategoryCollectionViaProduct_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductSubcategoryCollectionViaProduct_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductSubcategoryCollectionViaProduct_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductSubcategoryCollectionViaProduct_
		{
			get	{ return _alwaysFetchProductSubcategoryCollectionViaProduct_; }
			set	{ _alwaysFetchProductSubcategoryCollectionViaProduct_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductSubcategoryCollectionViaProduct_ already has been fetched. Setting this property to false when ProductSubcategoryCollectionViaProduct_ has been fetched
		/// will clear the ProductSubcategoryCollectionViaProduct_ collection well. Setting this property to true while ProductSubcategoryCollectionViaProduct_ hasn't been fetched disables lazy loading for ProductSubcategoryCollectionViaProduct_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductSubcategoryCollectionViaProduct_
		{
			get { return _alreadyFetchedProductSubcategoryCollectionViaProduct_;}
			set 
			{
				if(_alreadyFetchedProductSubcategoryCollectionViaProduct_ && !value && (_productSubcategoryCollectionViaProduct_ != null))
				{
					_productSubcategoryCollectionViaProduct_.Clear();
				}
				_alreadyFetchedProductSubcategoryCollectionViaProduct_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductSubcategoryCollectionViaProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductSubcategoryCollection ProductSubcategoryCollectionViaProduct
		{
			get { return GetMultiProductSubcategoryCollectionViaProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductSubcategoryCollectionViaProduct. When set to true, ProductSubcategoryCollectionViaProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductSubcategoryCollectionViaProduct is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductSubcategoryCollectionViaProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductSubcategoryCollectionViaProduct
		{
			get	{ return _alwaysFetchProductSubcategoryCollectionViaProduct; }
			set	{ _alwaysFetchProductSubcategoryCollectionViaProduct = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductSubcategoryCollectionViaProduct already has been fetched. Setting this property to false when ProductSubcategoryCollectionViaProduct has been fetched
		/// will clear the ProductSubcategoryCollectionViaProduct collection well. Setting this property to true while ProductSubcategoryCollectionViaProduct hasn't been fetched disables lazy loading for ProductSubcategoryCollectionViaProduct</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductSubcategoryCollectionViaProduct
		{
			get { return _alreadyFetchedProductSubcategoryCollectionViaProduct;}
			set 
			{
				if(_alreadyFetchedProductSubcategoryCollectionViaProduct && !value && (_productSubcategoryCollectionViaProduct != null))
				{
					_productSubcategoryCollectionViaProduct.Clear();
				}
				_alreadyFetchedProductSubcategoryCollectionViaProduct = value;
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
			get { return (int)AW.Data.EntityType.UnitMeasureEntity; }
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
