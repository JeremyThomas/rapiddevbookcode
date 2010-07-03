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
	
	/// <summary>Entity base class which represents the base class for the entity 'ProductModel'.<br/><br/>
	/// 
	/// MS_Description: Primary XML index.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class ProductModelEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductCollection	_product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;
		private AW.Data.CollectionClasses.ProductModelIllustrationCollection	_productModelIllustration;
		private bool	_alwaysFetchProductModelIllustration, _alreadyFetchedProductModelIllustration;
		private AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection	_productModelProductDescriptionCulture;
		private bool	_alwaysFetchProductModelProductDescriptionCulture, _alreadyFetchedProductModelProductDescriptionCulture;
		private AW.Data.CollectionClasses.CultureCollection _cultureCollectionViaProductModelProductDescriptionCulture;
		private bool	_alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture, _alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture;
		private AW.Data.CollectionClasses.IllustrationCollection _illustrationCollectionViaProductModelIllustration;
		private bool	_alwaysFetchIllustrationCollectionViaProductModelIllustration, _alreadyFetchedIllustrationCollectionViaProductModelIllustration;
		private AW.Data.CollectionClasses.ProductDescriptionCollection _productDescriptionCollectionViaProductModelProductDescriptionCulture;
		private bool	_alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture, _alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture;
		private AW.Data.CollectionClasses.ProductSubcategoryCollection _productSubcategoryCollectionViaProduct;
		private bool	_alwaysFetchProductSubcategoryCollectionViaProduct, _alreadyFetchedProductSubcategoryCollectionViaProduct;
		private AW.Data.CollectionClasses.UnitMeasureCollection _unitMeasureCollectionViaProduct_;
		private bool	_alwaysFetchUnitMeasureCollectionViaProduct_, _alreadyFetchedUnitMeasureCollectionViaProduct_;
		private AW.Data.CollectionClasses.UnitMeasureCollection _unitMeasureCollectionViaProduct;
		private bool	_alwaysFetchUnitMeasureCollectionViaProduct, _alreadyFetchedUnitMeasureCollectionViaProduct;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
			/// <summary>Member name ProductModelIllustration</summary>
			public static readonly string ProductModelIllustration = "ProductModelIllustration";
			/// <summary>Member name ProductModelProductDescriptionCulture</summary>
			public static readonly string ProductModelProductDescriptionCulture = "ProductModelProductDescriptionCulture";
			/// <summary>Member name CultureCollectionViaProductModelProductDescriptionCulture</summary>
			public static readonly string CultureCollectionViaProductModelProductDescriptionCulture = "CultureCollectionViaProductModelProductDescriptionCulture";
			/// <summary>Member name IllustrationCollectionViaProductModelIllustration</summary>
			public static readonly string IllustrationCollectionViaProductModelIllustration = "IllustrationCollectionViaProductModelIllustration";
			/// <summary>Member name ProductDescriptionCollectionViaProductModelProductDescriptionCulture</summary>
			public static readonly string ProductDescriptionCollectionViaProductModelProductDescriptionCulture = "ProductDescriptionCollectionViaProductModelProductDescriptionCulture";
			/// <summary>Member name ProductSubcategoryCollectionViaProduct</summary>
			public static readonly string ProductSubcategoryCollectionViaProduct = "ProductSubcategoryCollectionViaProduct";
			/// <summary>Member name UnitMeasureCollectionViaProduct_</summary>
			public static readonly string UnitMeasureCollectionViaProduct_ = "UnitMeasureCollectionViaProduct_";
			/// <summary>Member name UnitMeasureCollectionViaProduct</summary>
			public static readonly string UnitMeasureCollectionViaProduct = "UnitMeasureCollectionViaProduct";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductModelEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductModelEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		public ProductModelEntityBase(System.Int32 productModelID)
		{
			InitClassFetch(productModelID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductModelEntityBase(System.Int32 productModelID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(productModelID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="validator">The custom validator object for this ProductModelEntity</param>
		public ProductModelEntityBase(System.Int32 productModelID, IValidator validator)
		{
			InitClassFetch(productModelID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductModelEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_product = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_product", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");
			_productModelIllustration = (AW.Data.CollectionClasses.ProductModelIllustrationCollection)info.GetValue("_productModelIllustration", typeof(AW.Data.CollectionClasses.ProductModelIllustrationCollection));
			_alwaysFetchProductModelIllustration = info.GetBoolean("_alwaysFetchProductModelIllustration");
			_alreadyFetchedProductModelIllustration = info.GetBoolean("_alreadyFetchedProductModelIllustration");
			_productModelProductDescriptionCulture = (AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection)info.GetValue("_productModelProductDescriptionCulture", typeof(AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection));
			_alwaysFetchProductModelProductDescriptionCulture = info.GetBoolean("_alwaysFetchProductModelProductDescriptionCulture");
			_alreadyFetchedProductModelProductDescriptionCulture = info.GetBoolean("_alreadyFetchedProductModelProductDescriptionCulture");
			_cultureCollectionViaProductModelProductDescriptionCulture = (AW.Data.CollectionClasses.CultureCollection)info.GetValue("_cultureCollectionViaProductModelProductDescriptionCulture", typeof(AW.Data.CollectionClasses.CultureCollection));
			_alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture = info.GetBoolean("_alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture");
			_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture = info.GetBoolean("_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture");
			_illustrationCollectionViaProductModelIllustration = (AW.Data.CollectionClasses.IllustrationCollection)info.GetValue("_illustrationCollectionViaProductModelIllustration", typeof(AW.Data.CollectionClasses.IllustrationCollection));
			_alwaysFetchIllustrationCollectionViaProductModelIllustration = info.GetBoolean("_alwaysFetchIllustrationCollectionViaProductModelIllustration");
			_alreadyFetchedIllustrationCollectionViaProductModelIllustration = info.GetBoolean("_alreadyFetchedIllustrationCollectionViaProductModelIllustration");
			_productDescriptionCollectionViaProductModelProductDescriptionCulture = (AW.Data.CollectionClasses.ProductDescriptionCollection)info.GetValue("_productDescriptionCollectionViaProductModelProductDescriptionCulture", typeof(AW.Data.CollectionClasses.ProductDescriptionCollection));
			_alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture = info.GetBoolean("_alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture");
			_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture = info.GetBoolean("_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture");
			_productSubcategoryCollectionViaProduct = (AW.Data.CollectionClasses.ProductSubcategoryCollection)info.GetValue("_productSubcategoryCollectionViaProduct", typeof(AW.Data.CollectionClasses.ProductSubcategoryCollection));
			_alwaysFetchProductSubcategoryCollectionViaProduct = info.GetBoolean("_alwaysFetchProductSubcategoryCollectionViaProduct");
			_alreadyFetchedProductSubcategoryCollectionViaProduct = info.GetBoolean("_alreadyFetchedProductSubcategoryCollectionViaProduct");
			_unitMeasureCollectionViaProduct_ = (AW.Data.CollectionClasses.UnitMeasureCollection)info.GetValue("_unitMeasureCollectionViaProduct_", typeof(AW.Data.CollectionClasses.UnitMeasureCollection));
			_alwaysFetchUnitMeasureCollectionViaProduct_ = info.GetBoolean("_alwaysFetchUnitMeasureCollectionViaProduct_");
			_alreadyFetchedUnitMeasureCollectionViaProduct_ = info.GetBoolean("_alreadyFetchedUnitMeasureCollectionViaProduct_");
			_unitMeasureCollectionViaProduct = (AW.Data.CollectionClasses.UnitMeasureCollection)info.GetValue("_unitMeasureCollectionViaProduct", typeof(AW.Data.CollectionClasses.UnitMeasureCollection));
			_alwaysFetchUnitMeasureCollectionViaProduct = info.GetBoolean("_alwaysFetchUnitMeasureCollectionViaProduct");
			_alreadyFetchedUnitMeasureCollectionViaProduct = info.GetBoolean("_alreadyFetchedUnitMeasureCollectionViaProduct");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ProductModelFieldIndex)fieldIndex)
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
			_alreadyFetchedProduct = (_product.Count > 0);
			_alreadyFetchedProductModelIllustration = (_productModelIllustration.Count > 0);
			_alreadyFetchedProductModelProductDescriptionCulture = (_productModelProductDescriptionCulture.Count > 0);
			_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture = (_cultureCollectionViaProductModelProductDescriptionCulture.Count > 0);
			_alreadyFetchedIllustrationCollectionViaProductModelIllustration = (_illustrationCollectionViaProductModelIllustration.Count > 0);
			_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture = (_productDescriptionCollectionViaProductModelProductDescriptionCulture.Count > 0);
			_alreadyFetchedProductSubcategoryCollectionViaProduct = (_productSubcategoryCollectionViaProduct.Count > 0);
			_alreadyFetchedUnitMeasureCollectionViaProduct_ = (_unitMeasureCollectionViaProduct_.Count > 0);
			_alreadyFetchedUnitMeasureCollectionViaProduct = (_unitMeasureCollectionViaProduct.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ProductModelEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "Product":
					toReturn.Add(ProductModelEntity.Relations.ProductEntityUsingProductModelID);
					break;
				case "ProductModelIllustration":
					toReturn.Add(ProductModelEntity.Relations.ProductModelIllustrationEntityUsingProductModelID);
					break;
				case "ProductModelProductDescriptionCulture":
					toReturn.Add(ProductModelEntity.Relations.ProductModelProductDescriptionCultureEntityUsingProductModelID);
					break;
				case "CultureCollectionViaProductModelProductDescriptionCulture":
					toReturn.Add(ProductModelEntity.Relations.ProductModelProductDescriptionCultureEntityUsingProductModelID, "ProductModelEntity__", "ProductModelProductDescriptionCulture_", JoinHint.None);
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.CultureEntityUsingCultureID, "ProductModelProductDescriptionCulture_", string.Empty, JoinHint.None);
					break;
				case "IllustrationCollectionViaProductModelIllustration":
					toReturn.Add(ProductModelEntity.Relations.ProductModelIllustrationEntityUsingProductModelID, "ProductModelEntity__", "ProductModelIllustration_", JoinHint.None);
					toReturn.Add(ProductModelIllustrationEntity.Relations.IllustrationEntityUsingIllustrationID, "ProductModelIllustration_", string.Empty, JoinHint.None);
					break;
				case "ProductDescriptionCollectionViaProductModelProductDescriptionCulture":
					toReturn.Add(ProductModelEntity.Relations.ProductModelProductDescriptionCultureEntityUsingProductModelID, "ProductModelEntity__", "ProductModelProductDescriptionCulture_", JoinHint.None);
					toReturn.Add(ProductModelProductDescriptionCultureEntity.Relations.ProductDescriptionEntityUsingProductDescriptionID, "ProductModelProductDescriptionCulture_", string.Empty, JoinHint.None);
					break;
				case "ProductSubcategoryCollectionViaProduct":
					toReturn.Add(ProductModelEntity.Relations.ProductEntityUsingProductModelID, "ProductModelEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryID, "Product_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaProduct_":
					toReturn.Add(ProductModelEntity.Relations.ProductEntityUsingProductModelID, "ProductModelEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.UnitMeasureEntityUsingWeightUnitMeasureCode, "Product_", string.Empty, JoinHint.None);
					break;
				case "UnitMeasureCollectionViaProduct":
					toReturn.Add(ProductModelEntity.Relations.ProductEntityUsingProductModelID, "ProductModelEntity__", "Product_", JoinHint.None);
					toReturn.Add(ProductEntity.Relations.UnitMeasureEntityUsingSizeUnitMeasureCode, "Product_", string.Empty, JoinHint.None);
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
			info.AddValue("_product", (!this.MarkedForDeletion?_product:null));
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_productModelIllustration", (!this.MarkedForDeletion?_productModelIllustration:null));
			info.AddValue("_alwaysFetchProductModelIllustration", _alwaysFetchProductModelIllustration);
			info.AddValue("_alreadyFetchedProductModelIllustration", _alreadyFetchedProductModelIllustration);
			info.AddValue("_productModelProductDescriptionCulture", (!this.MarkedForDeletion?_productModelProductDescriptionCulture:null));
			info.AddValue("_alwaysFetchProductModelProductDescriptionCulture", _alwaysFetchProductModelProductDescriptionCulture);
			info.AddValue("_alreadyFetchedProductModelProductDescriptionCulture", _alreadyFetchedProductModelProductDescriptionCulture);
			info.AddValue("_cultureCollectionViaProductModelProductDescriptionCulture", (!this.MarkedForDeletion?_cultureCollectionViaProductModelProductDescriptionCulture:null));
			info.AddValue("_alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture", _alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture);
			info.AddValue("_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture", _alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture);
			info.AddValue("_illustrationCollectionViaProductModelIllustration", (!this.MarkedForDeletion?_illustrationCollectionViaProductModelIllustration:null));
			info.AddValue("_alwaysFetchIllustrationCollectionViaProductModelIllustration", _alwaysFetchIllustrationCollectionViaProductModelIllustration);
			info.AddValue("_alreadyFetchedIllustrationCollectionViaProductModelIllustration", _alreadyFetchedIllustrationCollectionViaProductModelIllustration);
			info.AddValue("_productDescriptionCollectionViaProductModelProductDescriptionCulture", (!this.MarkedForDeletion?_productDescriptionCollectionViaProductModelProductDescriptionCulture:null));
			info.AddValue("_alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture", _alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture);
			info.AddValue("_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture", _alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture);
			info.AddValue("_productSubcategoryCollectionViaProduct", (!this.MarkedForDeletion?_productSubcategoryCollectionViaProduct:null));
			info.AddValue("_alwaysFetchProductSubcategoryCollectionViaProduct", _alwaysFetchProductSubcategoryCollectionViaProduct);
			info.AddValue("_alreadyFetchedProductSubcategoryCollectionViaProduct", _alreadyFetchedProductSubcategoryCollectionViaProduct);
			info.AddValue("_unitMeasureCollectionViaProduct_", (!this.MarkedForDeletion?_unitMeasureCollectionViaProduct_:null));
			info.AddValue("_alwaysFetchUnitMeasureCollectionViaProduct_", _alwaysFetchUnitMeasureCollectionViaProduct_);
			info.AddValue("_alreadyFetchedUnitMeasureCollectionViaProduct_", _alreadyFetchedUnitMeasureCollectionViaProduct_);
			info.AddValue("_unitMeasureCollectionViaProduct", (!this.MarkedForDeletion?_unitMeasureCollectionViaProduct:null));
			info.AddValue("_alwaysFetchUnitMeasureCollectionViaProduct", _alwaysFetchUnitMeasureCollectionViaProduct);
			info.AddValue("_alreadyFetchedUnitMeasureCollectionViaProduct", _alreadyFetchedUnitMeasureCollectionViaProduct);


			
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

				case "Product":
					_alreadyFetchedProduct = true;
					if(entity!=null)
					{
						this.Product.Add((ProductEntity)entity);
					}
					break;
				case "ProductModelIllustration":
					_alreadyFetchedProductModelIllustration = true;
					if(entity!=null)
					{
						this.ProductModelIllustration.Add((ProductModelIllustrationEntity)entity);
					}
					break;
				case "ProductModelProductDescriptionCulture":
					_alreadyFetchedProductModelProductDescriptionCulture = true;
					if(entity!=null)
					{
						this.ProductModelProductDescriptionCulture.Add((ProductModelProductDescriptionCultureEntity)entity);
					}
					break;
				case "CultureCollectionViaProductModelProductDescriptionCulture":
					_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture = true;
					if(entity!=null)
					{
						this.CultureCollectionViaProductModelProductDescriptionCulture.Add((CultureEntity)entity);
					}
					break;
				case "IllustrationCollectionViaProductModelIllustration":
					_alreadyFetchedIllustrationCollectionViaProductModelIllustration = true;
					if(entity!=null)
					{
						this.IllustrationCollectionViaProductModelIllustration.Add((IllustrationEntity)entity);
					}
					break;
				case "ProductDescriptionCollectionViaProductModelProductDescriptionCulture":
					_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture = true;
					if(entity!=null)
					{
						this.ProductDescriptionCollectionViaProductModelProductDescriptionCulture.Add((ProductDescriptionEntity)entity);
					}
					break;
				case "ProductSubcategoryCollectionViaProduct":
					_alreadyFetchedProductSubcategoryCollectionViaProduct = true;
					if(entity!=null)
					{
						this.ProductSubcategoryCollectionViaProduct.Add((ProductSubcategoryEntity)entity);
					}
					break;
				case "UnitMeasureCollectionViaProduct_":
					_alreadyFetchedUnitMeasureCollectionViaProduct_ = true;
					if(entity!=null)
					{
						this.UnitMeasureCollectionViaProduct_.Add((UnitMeasureEntity)entity);
					}
					break;
				case "UnitMeasureCollectionViaProduct":
					_alreadyFetchedUnitMeasureCollectionViaProduct = true;
					if(entity!=null)
					{
						this.UnitMeasureCollectionViaProduct.Add((UnitMeasureEntity)entity);
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

				case "Product":
					_product.Add((ProductEntity)relatedEntity);
					break;
				case "ProductModelIllustration":
					_productModelIllustration.Add((ProductModelIllustrationEntity)relatedEntity);
					break;
				case "ProductModelProductDescriptionCulture":
					_productModelProductDescriptionCulture.Add((ProductModelProductDescriptionCultureEntity)relatedEntity);
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

				case "Product":
					base.PerformRelatedEntityRemoval(_product, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductModelIllustration":
					base.PerformRelatedEntityRemoval(_productModelIllustration, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductModelProductDescriptionCulture":
					base.PerformRelatedEntityRemoval(_productModelProductDescriptionCulture, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_product);
			toReturn.Add(_productModelIllustration);
			toReturn.Add(_productModelProductDescriptionCulture);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID)
		{
			return FetchUsingPK(productModelID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productModelID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(productModelID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(productModelID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductModelID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ProductModelFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ProductModelFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ProductModelRelations().GetAllRelations();
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
				_product.GetMultiManyToOne(this, null, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelIllustrationEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelIllustrationCollection GetMultiProductModelIllustration(bool forceFetch)
		{
			return GetMultiProductModelIllustration(forceFetch, _productModelIllustration.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelIllustrationEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelIllustrationCollection GetMultiProductModelIllustration(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductModelIllustration(forceFetch, _productModelIllustration.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductModelIllustrationCollection GetMultiProductModelIllustration(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductModelIllustration(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductModelIllustrationCollection GetMultiProductModelIllustration(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductModelIllustration || forceFetch || _alwaysFetchProductModelIllustration) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelIllustration.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelIllustration);
					}
				}
				_productModelIllustration.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productModelIllustration.EntityFactoryToUse = entityFactoryToUse;
				}
				_productModelIllustration.GetMultiManyToOne(null, this, filter);
				_productModelIllustration.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelIllustration = true;
			}
			return _productModelIllustration;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductModelIllustration'. These settings will be taken into account
		/// when the property ProductModelIllustration is requested or GetMultiProductModelIllustration is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelIllustration(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelIllustration.SortClauses=sortClauses;
			_productModelIllustration.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelProductDescriptionCultureEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCulture(bool forceFetch)
		{
			return GetMultiProductModelProductDescriptionCulture(forceFetch, _productModelProductDescriptionCulture.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelProductDescriptionCultureEntity'</returns>
		public AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCulture(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductModelProductDescriptionCulture(forceFetch, _productModelProductDescriptionCulture.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCulture(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductModelProductDescriptionCulture(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCulture(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductModelProductDescriptionCulture || forceFetch || _alwaysFetchProductModelProductDescriptionCulture) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelProductDescriptionCulture.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelProductDescriptionCulture);
					}
				}
				_productModelProductDescriptionCulture.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productModelProductDescriptionCulture.EntityFactoryToUse = entityFactoryToUse;
				}
				_productModelProductDescriptionCulture.GetMultiManyToOne(null, null, this, filter);
				_productModelProductDescriptionCulture.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelProductDescriptionCulture = true;
			}
			return _productModelProductDescriptionCulture;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductModelProductDescriptionCulture'. These settings will be taken into account
		/// when the property ProductModelProductDescriptionCulture is requested or GetMultiProductModelProductDescriptionCulture is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelProductDescriptionCulture(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelProductDescriptionCulture.SortClauses=sortClauses;
			_productModelProductDescriptionCulture.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CultureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CultureEntity'</returns>
		public AW.Data.CollectionClasses.CultureCollection GetMultiCultureCollectionViaProductModelProductDescriptionCulture(bool forceFetch)
		{
			return GetMultiCultureCollectionViaProductModelProductDescriptionCulture(forceFetch, _cultureCollectionViaProductModelProductDescriptionCulture.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CultureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CultureCollection GetMultiCultureCollectionViaProductModelProductDescriptionCulture(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture || forceFetch || _alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_cultureCollectionViaProductModelProductDescriptionCulture.ParticipatesInTransaction)
					{
						base.Transaction.Add(_cultureCollectionViaProductModelProductDescriptionCulture);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelID, ComparisonOperator.Equal, this.ProductModelID, "ProductModelEntity__"));
				_cultureCollectionViaProductModelProductDescriptionCulture.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_cultureCollectionViaProductModelProductDescriptionCulture.EntityFactoryToUse = entityFactoryToUse;
				}
				_cultureCollectionViaProductModelProductDescriptionCulture.GetMulti(filter, GetRelationsForField("CultureCollectionViaProductModelProductDescriptionCulture"));
				_cultureCollectionViaProductModelProductDescriptionCulture.SuppressClearInGetMulti=false;
				_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture = true;
			}
			return _cultureCollectionViaProductModelProductDescriptionCulture;
		}

		/// <summary> Sets the collection parameters for the collection for 'CultureCollectionViaProductModelProductDescriptionCulture'. These settings will be taken into account
		/// when the property CultureCollectionViaProductModelProductDescriptionCulture is requested or GetMultiCultureCollectionViaProductModelProductDescriptionCulture is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCultureCollectionViaProductModelProductDescriptionCulture(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_cultureCollectionViaProductModelProductDescriptionCulture.SortClauses=sortClauses;
			_cultureCollectionViaProductModelProductDescriptionCulture.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'IllustrationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'IllustrationEntity'</returns>
		public AW.Data.CollectionClasses.IllustrationCollection GetMultiIllustrationCollectionViaProductModelIllustration(bool forceFetch)
		{
			return GetMultiIllustrationCollectionViaProductModelIllustration(forceFetch, _illustrationCollectionViaProductModelIllustration.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'IllustrationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.IllustrationCollection GetMultiIllustrationCollectionViaProductModelIllustration(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedIllustrationCollectionViaProductModelIllustration || forceFetch || _alwaysFetchIllustrationCollectionViaProductModelIllustration) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_illustrationCollectionViaProductModelIllustration.ParticipatesInTransaction)
					{
						base.Transaction.Add(_illustrationCollectionViaProductModelIllustration);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelID, ComparisonOperator.Equal, this.ProductModelID, "ProductModelEntity__"));
				_illustrationCollectionViaProductModelIllustration.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_illustrationCollectionViaProductModelIllustration.EntityFactoryToUse = entityFactoryToUse;
				}
				_illustrationCollectionViaProductModelIllustration.GetMulti(filter, GetRelationsForField("IllustrationCollectionViaProductModelIllustration"));
				_illustrationCollectionViaProductModelIllustration.SuppressClearInGetMulti=false;
				_alreadyFetchedIllustrationCollectionViaProductModelIllustration = true;
			}
			return _illustrationCollectionViaProductModelIllustration;
		}

		/// <summary> Sets the collection parameters for the collection for 'IllustrationCollectionViaProductModelIllustration'. These settings will be taken into account
		/// when the property IllustrationCollectionViaProductModelIllustration is requested or GetMultiIllustrationCollectionViaProductModelIllustration is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersIllustrationCollectionViaProductModelIllustration(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_illustrationCollectionViaProductModelIllustration.SortClauses=sortClauses;
			_illustrationCollectionViaProductModelIllustration.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductDescriptionEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductDescriptionEntity'</returns>
		public AW.Data.CollectionClasses.ProductDescriptionCollection GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture(bool forceFetch)
		{
			return GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture(forceFetch, _productDescriptionCollectionViaProductModelProductDescriptionCulture.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductDescriptionEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductDescriptionCollection GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture || forceFetch || _alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productDescriptionCollectionViaProductModelProductDescriptionCulture.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productDescriptionCollectionViaProductModelProductDescriptionCulture);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelID, ComparisonOperator.Equal, this.ProductModelID, "ProductModelEntity__"));
				_productDescriptionCollectionViaProductModelProductDescriptionCulture.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productDescriptionCollectionViaProductModelProductDescriptionCulture.EntityFactoryToUse = entityFactoryToUse;
				}
				_productDescriptionCollectionViaProductModelProductDescriptionCulture.GetMulti(filter, GetRelationsForField("ProductDescriptionCollectionViaProductModelProductDescriptionCulture"));
				_productDescriptionCollectionViaProductModelProductDescriptionCulture.SuppressClearInGetMulti=false;
				_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture = true;
			}
			return _productDescriptionCollectionViaProductModelProductDescriptionCulture;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductDescriptionCollectionViaProductModelProductDescriptionCulture'. These settings will be taken into account
		/// when the property ProductDescriptionCollectionViaProductModelProductDescriptionCulture is requested or GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductDescriptionCollectionViaProductModelProductDescriptionCulture(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productDescriptionCollectionViaProductModelProductDescriptionCulture.SortClauses=sortClauses;
			_productDescriptionCollectionViaProductModelProductDescriptionCulture.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelID, ComparisonOperator.Equal, this.ProductModelID, "ProductModelEntity__"));
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

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaProduct_(bool forceFetch)
		{
			return GetMultiUnitMeasureCollectionViaProduct_(forceFetch, _unitMeasureCollectionViaProduct_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaProduct_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasureCollectionViaProduct_ || forceFetch || _alwaysFetchUnitMeasureCollectionViaProduct_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasureCollectionViaProduct_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasureCollectionViaProduct_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelID, ComparisonOperator.Equal, this.ProductModelID, "ProductModelEntity__"));
				_unitMeasureCollectionViaProduct_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_unitMeasureCollectionViaProduct_.EntityFactoryToUse = entityFactoryToUse;
				}
				_unitMeasureCollectionViaProduct_.GetMulti(filter, GetRelationsForField("UnitMeasureCollectionViaProduct_"));
				_unitMeasureCollectionViaProduct_.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasureCollectionViaProduct_ = true;
			}
			return _unitMeasureCollectionViaProduct_;
		}

		/// <summary> Sets the collection parameters for the collection for 'UnitMeasureCollectionViaProduct_'. These settings will be taken into account
		/// when the property UnitMeasureCollectionViaProduct_ is requested or GetMultiUnitMeasureCollectionViaProduct_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasureCollectionViaProduct_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasureCollectionViaProduct_.SortClauses=sortClauses;
			_unitMeasureCollectionViaProduct_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaProduct(bool forceFetch)
		{
			return GetMultiUnitMeasureCollectionViaProduct(forceFetch, _unitMeasureCollectionViaProduct.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.UnitMeasureCollection GetMultiUnitMeasureCollectionViaProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasureCollectionViaProduct || forceFetch || _alwaysFetchUnitMeasureCollectionViaProduct) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasureCollectionViaProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasureCollectionViaProduct);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelID, ComparisonOperator.Equal, this.ProductModelID, "ProductModelEntity__"));
				_unitMeasureCollectionViaProduct.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_unitMeasureCollectionViaProduct.EntityFactoryToUse = entityFactoryToUse;
				}
				_unitMeasureCollectionViaProduct.GetMulti(filter, GetRelationsForField("UnitMeasureCollectionViaProduct"));
				_unitMeasureCollectionViaProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasureCollectionViaProduct = true;
			}
			return _unitMeasureCollectionViaProduct;
		}

		/// <summary> Sets the collection parameters for the collection for 'UnitMeasureCollectionViaProduct'. These settings will be taken into account
		/// when the property UnitMeasureCollectionViaProduct is requested or GetMultiUnitMeasureCollectionViaProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasureCollectionViaProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasureCollectionViaProduct.SortClauses=sortClauses;
			_unitMeasureCollectionViaProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ProductModelDAO dao = (ProductModelDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_product.ActiveContext = base.ActiveContext;
			_productModelIllustration.ActiveContext = base.ActiveContext;
			_productModelProductDescriptionCulture.ActiveContext = base.ActiveContext;
			_cultureCollectionViaProductModelProductDescriptionCulture.ActiveContext = base.ActiveContext;
			_illustrationCollectionViaProductModelIllustration.ActiveContext = base.ActiveContext;
			_productDescriptionCollectionViaProductModelProductDescriptionCulture.ActiveContext = base.ActiveContext;
			_productSubcategoryCollectionViaProduct.ActiveContext = base.ActiveContext;
			_unitMeasureCollectionViaProduct_.ActiveContext = base.ActiveContext;
			_unitMeasureCollectionViaProduct.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ProductModelDAO dao = (ProductModelDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ProductModelDAO dao = (ProductModelDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ProductModelEntity);
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

			toReturn.Add("Product", _product);
			toReturn.Add("ProductModelIllustration", _productModelIllustration);
			toReturn.Add("ProductModelProductDescriptionCulture", _productModelProductDescriptionCulture);
			toReturn.Add("CultureCollectionViaProductModelProductDescriptionCulture", _cultureCollectionViaProductModelProductDescriptionCulture);
			toReturn.Add("IllustrationCollectionViaProductModelIllustration", _illustrationCollectionViaProductModelIllustration);
			toReturn.Add("ProductDescriptionCollectionViaProductModelProductDescriptionCulture", _productDescriptionCollectionViaProductModelProductDescriptionCulture);
			toReturn.Add("ProductSubcategoryCollectionViaProduct", _productSubcategoryCollectionViaProduct);
			toReturn.Add("UnitMeasureCollectionViaProduct_", _unitMeasureCollectionViaProduct_);
			toReturn.Add("UnitMeasureCollectionViaProduct", _unitMeasureCollectionViaProduct);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="validator">The validator object for this ProductModelEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 productModelID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(productModelID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_product = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_product.SetContainingEntityInfo(this, "ProductModel");
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;
			_productModelIllustration = new AW.Data.CollectionClasses.ProductModelIllustrationCollection(new ProductModelIllustrationEntityFactory());
			_productModelIllustration.SetContainingEntityInfo(this, "ProductModel");
			_alwaysFetchProductModelIllustration = false;
			_alreadyFetchedProductModelIllustration = false;
			_productModelProductDescriptionCulture = new AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection(new ProductModelProductDescriptionCultureEntityFactory());
			_productModelProductDescriptionCulture.SetContainingEntityInfo(this, "ProductModel");
			_alwaysFetchProductModelProductDescriptionCulture = false;
			_alreadyFetchedProductModelProductDescriptionCulture = false;
			_cultureCollectionViaProductModelProductDescriptionCulture = new AW.Data.CollectionClasses.CultureCollection(new CultureEntityFactory());
			_alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture = false;
			_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture = false;
			_illustrationCollectionViaProductModelIllustration = new AW.Data.CollectionClasses.IllustrationCollection(new IllustrationEntityFactory());
			_alwaysFetchIllustrationCollectionViaProductModelIllustration = false;
			_alreadyFetchedIllustrationCollectionViaProductModelIllustration = false;
			_productDescriptionCollectionViaProductModelProductDescriptionCulture = new AW.Data.CollectionClasses.ProductDescriptionCollection(new ProductDescriptionEntityFactory());
			_alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture = false;
			_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture = false;
			_productSubcategoryCollectionViaProduct = new AW.Data.CollectionClasses.ProductSubcategoryCollection(new ProductSubcategoryEntityFactory());
			_alwaysFetchProductSubcategoryCollectionViaProduct = false;
			_alreadyFetchedProductSubcategoryCollectionViaProduct = false;
			_unitMeasureCollectionViaProduct_ = new AW.Data.CollectionClasses.UnitMeasureCollection(new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasureCollectionViaProduct_ = false;
			_alreadyFetchedUnitMeasureCollectionViaProduct_ = false;
			_unitMeasureCollectionViaProduct = new AW.Data.CollectionClasses.UnitMeasureCollection(new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasureCollectionViaProduct = false;
			_alreadyFetchedUnitMeasureCollectionViaProduct = false;



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
			_customProperties.Add("MS_Description", @"Primary XML index.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Primary key for ProductModel records.");
			_fieldsCustomProperties.Add("ProductModelID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Detailed product catalog information in xml format.");
			_fieldsCustomProperties.Add("CatalogDescription", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Manufacturing instructions in xml format.");
			_fieldsCustomProperties.Add("Instructions", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productModelID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ProductModelFieldIndex.ProductModelID].ForcedCurrentValueWrite(productModelID);
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
			return DAOFactory.CreateProductModelDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ProductModelEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductModelRelations Relations
		{
			get	{ return new ProductModelRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProduct
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(),
					(IEntityRelation)GetRelationsForField("Product")[0], (int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, null, "Product", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModelIllustration' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModelIllustration
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelIllustrationCollection(),
					(IEntityRelation)GetRelationsForField("ProductModelIllustration")[0], (int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.ProductModelIllustrationEntity, 0, null, null, null, "ProductModelIllustration", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductModelProductDescriptionCulture' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductModelProductDescriptionCulture
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection(),
					(IEntityRelation)GetRelationsForField("ProductModelProductDescriptionCulture")[0], (int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.ProductModelProductDescriptionCultureEntity, 0, null, null, null, "ProductModelProductDescriptionCulture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Culture' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCultureCollectionViaProductModelProductDescriptionCulture
		{
			get
			{
				IEntityRelation intermediateRelation = ProductModelEntity.Relations.ProductModelProductDescriptionCultureEntityUsingProductModelID;
				intermediateRelation.SetAliases(string.Empty, "ProductModelProductDescriptionCulture_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CultureCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.CultureEntity, 0, null, null, GetRelationsForField("CultureCollectionViaProductModelProductDescriptionCulture"), "CultureCollectionViaProductModelProductDescriptionCulture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Illustration' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathIllustrationCollectionViaProductModelIllustration
		{
			get
			{
				IEntityRelation intermediateRelation = ProductModelEntity.Relations.ProductModelIllustrationEntityUsingProductModelID;
				intermediateRelation.SetAliases(string.Empty, "ProductModelIllustration_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.IllustrationCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.IllustrationEntity, 0, null, null, GetRelationsForField("IllustrationCollectionViaProductModelIllustration"), "IllustrationCollectionViaProductModelIllustration", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductDescription' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductDescriptionCollectionViaProductModelProductDescriptionCulture
		{
			get
			{
				IEntityRelation intermediateRelation = ProductModelEntity.Relations.ProductModelProductDescriptionCultureEntityUsingProductModelID;
				intermediateRelation.SetAliases(string.Empty, "ProductModelProductDescriptionCulture_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductDescriptionCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.ProductDescriptionEntity, 0, null, null, GetRelationsForField("ProductDescriptionCollectionViaProductModelProductDescriptionCulture"), "ProductDescriptionCollectionViaProductModelProductDescriptionCulture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductSubcategory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductSubcategoryCollectionViaProduct
		{
			get
			{
				IEntityRelation intermediateRelation = ProductModelEntity.Relations.ProductEntityUsingProductModelID;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductSubcategoryCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.ProductSubcategoryEntity, 0, null, null, GetRelationsForField("ProductSubcategoryCollectionViaProduct"), "ProductSubcategoryCollectionViaProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasureCollectionViaProduct_
		{
			get
			{
				IEntityRelation intermediateRelation = ProductModelEntity.Relations.ProductEntityUsingProductModelID;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaProduct_"), "UnitMeasureCollectionViaProduct_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnitMeasure' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUnitMeasureCollectionViaProduct
		{
			get
			{
				IEntityRelation intermediateRelation = ProductModelEntity.Relations.ProductEntityUsingProductModelID;
				intermediateRelation.SetAliases(string.Empty, "Product_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.UnitMeasureCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ProductModelEntity, (int)AW.Data.EntityType.UnitMeasureEntity, 0, null, null, GetRelationsForField("UnitMeasureCollectionViaProduct"), "UnitMeasureCollectionViaProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ProductModelEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ProductModelEntity.CustomProperties;}
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
			get { return ProductModelEntity.FieldsCustomProperties;}
		}

		/// <summary> The ProductModelID property of the Entity ProductModel<br/><br/>
		/// 
		/// MS_Description: Primary key for ProductModel records.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."ProductModelID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductModelID
		{
			get { return (System.Int32)GetValue((int)ProductModelFieldIndex.ProductModelID, true); }
			set	{ SetValue((int)ProductModelFieldIndex.ProductModelID, value, true); }
		}
		/// <summary> The Name property of the Entity ProductModel<br/><br/>
		/// 
		/// MS_Description: Unique nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ProductModelFieldIndex.Name, true); }
			set	{ SetValue((int)ProductModelFieldIndex.Name, value, true); }
		}
		/// <summary> The CatalogDescription property of the Entity ProductModel<br/><br/>
		/// 
		/// MS_Description: Detailed product catalog information in xml format.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."CatalogDescription"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CatalogDescription
		{
			get { return (System.String)GetValue((int)ProductModelFieldIndex.CatalogDescription, true); }
			set	{ SetValue((int)ProductModelFieldIndex.CatalogDescription, value, true); }
		}
		/// <summary> The Instructions property of the Entity ProductModel<br/><br/>
		/// 
		/// MS_Description: Manufacturing instructions in xml format.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."Instructions"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Instructions
		{
			get { return (System.String)GetValue((int)ProductModelFieldIndex.Instructions, true); }
			set	{ SetValue((int)ProductModelFieldIndex.Instructions, value, true); }
		}
		/// <summary> The Rowguid property of the Entity ProductModel<br/><br/>
		/// 
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductModelFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductModelFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity ProductModel<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "ProductModel"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductModelFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductModelFieldIndex.ModifiedDate, value, true); }
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
		/// <summary> Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelIllustration()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductModelIllustrationCollection ProductModelIllustration
		{
			get	{ return GetMultiProductModelIllustration(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModelIllustration. When set to true, ProductModelIllustration is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelIllustration is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModelIllustration(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelIllustration
		{
			get	{ return _alwaysFetchProductModelIllustration; }
			set	{ _alwaysFetchProductModelIllustration = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModelIllustration already has been fetched. Setting this property to false when ProductModelIllustration has been fetched
		/// will clear the ProductModelIllustration collection well. Setting this property to true while ProductModelIllustration hasn't been fetched disables lazy loading for ProductModelIllustration</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModelIllustration
		{
			get { return _alreadyFetchedProductModelIllustration;}
			set 
			{
				if(_alreadyFetchedProductModelIllustration && !value && (_productModelIllustration != null))
				{
					_productModelIllustration.Clear();
				}
				_alreadyFetchedProductModelIllustration = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelProductDescriptionCulture()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductModelProductDescriptionCultureCollection ProductModelProductDescriptionCulture
		{
			get	{ return GetMultiProductModelProductDescriptionCulture(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductModelProductDescriptionCulture. When set to true, ProductModelProductDescriptionCulture is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelProductDescriptionCulture is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModelProductDescriptionCulture(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelProductDescriptionCulture
		{
			get	{ return _alwaysFetchProductModelProductDescriptionCulture; }
			set	{ _alwaysFetchProductModelProductDescriptionCulture = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductModelProductDescriptionCulture already has been fetched. Setting this property to false when ProductModelProductDescriptionCulture has been fetched
		/// will clear the ProductModelProductDescriptionCulture collection well. Setting this property to true while ProductModelProductDescriptionCulture hasn't been fetched disables lazy loading for ProductModelProductDescriptionCulture</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductModelProductDescriptionCulture
		{
			get { return _alreadyFetchedProductModelProductDescriptionCulture;}
			set 
			{
				if(_alreadyFetchedProductModelProductDescriptionCulture && !value && (_productModelProductDescriptionCulture != null))
				{
					_productModelProductDescriptionCulture.Clear();
				}
				_alreadyFetchedProductModelProductDescriptionCulture = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'CultureEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCultureCollectionViaProductModelProductDescriptionCulture()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CultureCollection CultureCollectionViaProductModelProductDescriptionCulture
		{
			get { return GetMultiCultureCollectionViaProductModelProductDescriptionCulture(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CultureCollectionViaProductModelProductDescriptionCulture. When set to true, CultureCollectionViaProductModelProductDescriptionCulture is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CultureCollectionViaProductModelProductDescriptionCulture is accessed. You can always execute
		/// a forced fetch by calling GetMultiCultureCollectionViaProductModelProductDescriptionCulture(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCultureCollectionViaProductModelProductDescriptionCulture
		{
			get	{ return _alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture; }
			set	{ _alwaysFetchCultureCollectionViaProductModelProductDescriptionCulture = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CultureCollectionViaProductModelProductDescriptionCulture already has been fetched. Setting this property to false when CultureCollectionViaProductModelProductDescriptionCulture has been fetched
		/// will clear the CultureCollectionViaProductModelProductDescriptionCulture collection well. Setting this property to true while CultureCollectionViaProductModelProductDescriptionCulture hasn't been fetched disables lazy loading for CultureCollectionViaProductModelProductDescriptionCulture</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture
		{
			get { return _alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture;}
			set 
			{
				if(_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture && !value && (_cultureCollectionViaProductModelProductDescriptionCulture != null))
				{
					_cultureCollectionViaProductModelProductDescriptionCulture.Clear();
				}
				_alreadyFetchedCultureCollectionViaProductModelProductDescriptionCulture = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'IllustrationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiIllustrationCollectionViaProductModelIllustration()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.IllustrationCollection IllustrationCollectionViaProductModelIllustration
		{
			get { return GetMultiIllustrationCollectionViaProductModelIllustration(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for IllustrationCollectionViaProductModelIllustration. When set to true, IllustrationCollectionViaProductModelIllustration is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time IllustrationCollectionViaProductModelIllustration is accessed. You can always execute
		/// a forced fetch by calling GetMultiIllustrationCollectionViaProductModelIllustration(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchIllustrationCollectionViaProductModelIllustration
		{
			get	{ return _alwaysFetchIllustrationCollectionViaProductModelIllustration; }
			set	{ _alwaysFetchIllustrationCollectionViaProductModelIllustration = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property IllustrationCollectionViaProductModelIllustration already has been fetched. Setting this property to false when IllustrationCollectionViaProductModelIllustration has been fetched
		/// will clear the IllustrationCollectionViaProductModelIllustration collection well. Setting this property to true while IllustrationCollectionViaProductModelIllustration hasn't been fetched disables lazy loading for IllustrationCollectionViaProductModelIllustration</summary>
		[Browsable(false)]
		public bool AlreadyFetchedIllustrationCollectionViaProductModelIllustration
		{
			get { return _alreadyFetchedIllustrationCollectionViaProductModelIllustration;}
			set 
			{
				if(_alreadyFetchedIllustrationCollectionViaProductModelIllustration && !value && (_illustrationCollectionViaProductModelIllustration != null))
				{
					_illustrationCollectionViaProductModelIllustration.Clear();
				}
				_alreadyFetchedIllustrationCollectionViaProductModelIllustration = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductDescriptionEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductDescriptionCollection ProductDescriptionCollectionViaProductModelProductDescriptionCulture
		{
			get { return GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductDescriptionCollectionViaProductModelProductDescriptionCulture. When set to true, ProductDescriptionCollectionViaProductModelProductDescriptionCulture is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductDescriptionCollectionViaProductModelProductDescriptionCulture is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductDescriptionCollectionViaProductModelProductDescriptionCulture(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture
		{
			get	{ return _alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture; }
			set	{ _alwaysFetchProductDescriptionCollectionViaProductModelProductDescriptionCulture = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductDescriptionCollectionViaProductModelProductDescriptionCulture already has been fetched. Setting this property to false when ProductDescriptionCollectionViaProductModelProductDescriptionCulture has been fetched
		/// will clear the ProductDescriptionCollectionViaProductModelProductDescriptionCulture collection well. Setting this property to true while ProductDescriptionCollectionViaProductModelProductDescriptionCulture hasn't been fetched disables lazy loading for ProductDescriptionCollectionViaProductModelProductDescriptionCulture</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture
		{
			get { return _alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture;}
			set 
			{
				if(_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture && !value && (_productDescriptionCollectionViaProductModelProductDescriptionCulture != null))
				{
					_productDescriptionCollectionViaProductModelProductDescriptionCulture.Clear();
				}
				_alreadyFetchedProductDescriptionCollectionViaProductModelProductDescriptionCulture = value;
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
		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasureCollectionViaProduct_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.UnitMeasureCollection UnitMeasureCollectionViaProduct_
		{
			get { return GetMultiUnitMeasureCollectionViaProduct_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasureCollectionViaProduct_. When set to true, UnitMeasureCollectionViaProduct_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasureCollectionViaProduct_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasureCollectionViaProduct_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasureCollectionViaProduct_
		{
			get	{ return _alwaysFetchUnitMeasureCollectionViaProduct_; }
			set	{ _alwaysFetchUnitMeasureCollectionViaProduct_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UnitMeasureCollectionViaProduct_ already has been fetched. Setting this property to false when UnitMeasureCollectionViaProduct_ has been fetched
		/// will clear the UnitMeasureCollectionViaProduct_ collection well. Setting this property to true while UnitMeasureCollectionViaProduct_ hasn't been fetched disables lazy loading for UnitMeasureCollectionViaProduct_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUnitMeasureCollectionViaProduct_
		{
			get { return _alreadyFetchedUnitMeasureCollectionViaProduct_;}
			set 
			{
				if(_alreadyFetchedUnitMeasureCollectionViaProduct_ && !value && (_unitMeasureCollectionViaProduct_ != null))
				{
					_unitMeasureCollectionViaProduct_.Clear();
				}
				_alreadyFetchedUnitMeasureCollectionViaProduct_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasureCollectionViaProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.UnitMeasureCollection UnitMeasureCollectionViaProduct
		{
			get { return GetMultiUnitMeasureCollectionViaProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UnitMeasureCollectionViaProduct. When set to true, UnitMeasureCollectionViaProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasureCollectionViaProduct is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasureCollectionViaProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasureCollectionViaProduct
		{
			get	{ return _alwaysFetchUnitMeasureCollectionViaProduct; }
			set	{ _alwaysFetchUnitMeasureCollectionViaProduct = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UnitMeasureCollectionViaProduct already has been fetched. Setting this property to false when UnitMeasureCollectionViaProduct has been fetched
		/// will clear the UnitMeasureCollectionViaProduct collection well. Setting this property to true while UnitMeasureCollectionViaProduct hasn't been fetched disables lazy loading for UnitMeasureCollectionViaProduct</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUnitMeasureCollectionViaProduct
		{
			get { return _alreadyFetchedUnitMeasureCollectionViaProduct;}
			set 
			{
				if(_alreadyFetchedUnitMeasureCollectionViaProduct && !value && (_unitMeasureCollectionViaProduct != null))
				{
					_unitMeasureCollectionViaProduct.Clear();
				}
				_alreadyFetchedUnitMeasureCollectionViaProduct = value;
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
			get { return (int)AW.Data.EntityType.ProductModelEntity; }
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
