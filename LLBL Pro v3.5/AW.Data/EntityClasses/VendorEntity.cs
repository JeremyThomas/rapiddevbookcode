///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
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

	/// <summary>Entity class which represents the entity 'Vendor'. <br/><br/>
	/// 
	/// MS_Description: Companies from whom Adventure Works Cycles purchases parts or other goods.<br/>
	/// </summary>
	[Serializable]
	public partial class VendorEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductVendorCollection	_productVendors;
		private bool	_alwaysFetchProductVendors, _alreadyFetchedProductVendors;
		private AW.Data.CollectionClasses.PurchaseOrderHeaderCollection	_purchaseOrderHeaders;
		private bool	_alwaysFetchPurchaseOrderHeaders, _alreadyFetchedPurchaseOrderHeaders;
		private AW.Data.CollectionClasses.VendorAddressCollection	_vendorAddresses;
		private bool	_alwaysFetchVendorAddresses, _alreadyFetchedVendorAddresses;
		private AW.Data.CollectionClasses.VendorContactCollection	_vendorContacts;
		private bool	_alwaysFetchVendorContacts, _alreadyFetchedVendorContacts;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductVendors</summary>
			public static readonly string ProductVendors = "ProductVendors";
			/// <summary>Member name PurchaseOrderHeaders</summary>
			public static readonly string PurchaseOrderHeaders = "PurchaseOrderHeaders";
			/// <summary>Member name VendorAddresses</summary>
			public static readonly string VendorAddresses = "VendorAddresses";
			/// <summary>Member name VendorContacts</summary>
			public static readonly string VendorContacts = "VendorContacts";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static VendorEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public VendorEntity() :base("VendorEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		public VendorEntity(System.Int32 vendorID):base("VendorEntity")
		{
			InitClassFetch(vendorID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public VendorEntity(System.Int32 vendorID, IPrefetchPath prefetchPathToUse):base("VendorEntity")
		{
			InitClassFetch(vendorID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="validator">The custom validator object for this VendorEntity</param>
		public VendorEntity(System.Int32 vendorID, IValidator validator):base("VendorEntity")
		{
			InitClassFetch(vendorID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected VendorEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_productVendors = (AW.Data.CollectionClasses.ProductVendorCollection)info.GetValue("_productVendors", typeof(AW.Data.CollectionClasses.ProductVendorCollection));
			_alwaysFetchProductVendors = info.GetBoolean("_alwaysFetchProductVendors");
			_alreadyFetchedProductVendors = info.GetBoolean("_alreadyFetchedProductVendors");

			_purchaseOrderHeaders = (AW.Data.CollectionClasses.PurchaseOrderHeaderCollection)info.GetValue("_purchaseOrderHeaders", typeof(AW.Data.CollectionClasses.PurchaseOrderHeaderCollection));
			_alwaysFetchPurchaseOrderHeaders = info.GetBoolean("_alwaysFetchPurchaseOrderHeaders");
			_alreadyFetchedPurchaseOrderHeaders = info.GetBoolean("_alreadyFetchedPurchaseOrderHeaders");

			_vendorAddresses = (AW.Data.CollectionClasses.VendorAddressCollection)info.GetValue("_vendorAddresses", typeof(AW.Data.CollectionClasses.VendorAddressCollection));
			_alwaysFetchVendorAddresses = info.GetBoolean("_alwaysFetchVendorAddresses");
			_alreadyFetchedVendorAddresses = info.GetBoolean("_alreadyFetchedVendorAddresses");

			_vendorContacts = (AW.Data.CollectionClasses.VendorContactCollection)info.GetValue("_vendorContacts", typeof(AW.Data.CollectionClasses.VendorContactCollection));
			_alwaysFetchVendorContacts = info.GetBoolean("_alwaysFetchVendorContacts");
			_alreadyFetchedVendorContacts = info.GetBoolean("_alreadyFetchedVendorContacts");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedProductVendors = (_productVendors.Count > 0);
			_alreadyFetchedPurchaseOrderHeaders = (_purchaseOrderHeaders.Count > 0);
			_alreadyFetchedVendorAddresses = (_vendorAddresses.Count > 0);
			_alreadyFetchedVendorContacts = (_vendorContacts.Count > 0);
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
				case "ProductVendors":
					toReturn.Add(Relations.ProductVendorEntityUsingVendorID);
					break;
				case "PurchaseOrderHeaders":
					toReturn.Add(Relations.PurchaseOrderHeaderEntityUsingVendorID);
					break;
				case "VendorAddresses":
					toReturn.Add(Relations.VendorAddressEntityUsingVendorID);
					break;
				case "VendorContacts":
					toReturn.Add(Relations.VendorContactEntityUsingVendorID);
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
			info.AddValue("_productVendors", (!this.MarkedForDeletion?_productVendors:null));
			info.AddValue("_alwaysFetchProductVendors", _alwaysFetchProductVendors);
			info.AddValue("_alreadyFetchedProductVendors", _alreadyFetchedProductVendors);
			info.AddValue("_purchaseOrderHeaders", (!this.MarkedForDeletion?_purchaseOrderHeaders:null));
			info.AddValue("_alwaysFetchPurchaseOrderHeaders", _alwaysFetchPurchaseOrderHeaders);
			info.AddValue("_alreadyFetchedPurchaseOrderHeaders", _alreadyFetchedPurchaseOrderHeaders);
			info.AddValue("_vendorAddresses", (!this.MarkedForDeletion?_vendorAddresses:null));
			info.AddValue("_alwaysFetchVendorAddresses", _alwaysFetchVendorAddresses);
			info.AddValue("_alreadyFetchedVendorAddresses", _alreadyFetchedVendorAddresses);
			info.AddValue("_vendorContacts", (!this.MarkedForDeletion?_vendorContacts:null));
			info.AddValue("_alwaysFetchVendorContacts", _alwaysFetchVendorContacts);
			info.AddValue("_alreadyFetchedVendorContacts", _alreadyFetchedVendorContacts);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "ProductVendors":
					_alreadyFetchedProductVendors = true;
					if(entity!=null)
					{
						this.ProductVendors.Add((ProductVendorEntity)entity);
					}
					break;
				case "PurchaseOrderHeaders":
					_alreadyFetchedPurchaseOrderHeaders = true;
					if(entity!=null)
					{
						this.PurchaseOrderHeaders.Add((PurchaseOrderHeaderEntity)entity);
					}
					break;
				case "VendorAddresses":
					_alreadyFetchedVendorAddresses = true;
					if(entity!=null)
					{
						this.VendorAddresses.Add((VendorAddressEntity)entity);
					}
					break;
				case "VendorContacts":
					_alreadyFetchedVendorContacts = true;
					if(entity!=null)
					{
						this.VendorContacts.Add((VendorContactEntity)entity);
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
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "ProductVendors":
					_productVendors.Add((ProductVendorEntity)relatedEntity);
					break;
				case "PurchaseOrderHeaders":
					_purchaseOrderHeaders.Add((PurchaseOrderHeaderEntity)relatedEntity);
					break;
				case "VendorAddresses":
					_vendorAddresses.Add((VendorAddressEntity)relatedEntity);
					break;
				case "VendorContacts":
					_vendorContacts.Add((VendorContactEntity)relatedEntity);
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
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "ProductVendors":
					this.PerformRelatedEntityRemoval(_productVendors, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PurchaseOrderHeaders":
					this.PerformRelatedEntityRemoval(_purchaseOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "VendorAddresses":
					this.PerformRelatedEntityRemoval(_vendorAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "VendorContacts":
					this.PerformRelatedEntityRemoval(_vendorContacts, relatedEntity, signalRelatedEntityManyToOne);
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
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_productVendors);
			toReturn.Add(_purchaseOrderHeaders);
			toReturn.Add(_vendorAddresses);
			toReturn.Add(_vendorContacts);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 vendorID)
		{
			return FetchUsingPK(vendorID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 vendorID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(vendorID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 vendorID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(vendorID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 vendorID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(vendorID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.VendorID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new VendorRelations().GetAllRelations();
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
				_productVendors.GetMultiManyToOne(null, null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeaders(bool forceFetch)
		{
			return GetMultiPurchaseOrderHeaders(forceFetch, _purchaseOrderHeaders.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeaders(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiPurchaseOrderHeaders(forceFetch, _purchaseOrderHeaders.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeaders(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiPurchaseOrderHeaders(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeaders(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeaders || forceFetch || _alwaysFetchPurchaseOrderHeaders) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_purchaseOrderHeaders);
				_purchaseOrderHeaders.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderHeaders.EntityFactoryToUse = entityFactoryToUse;
				_purchaseOrderHeaders.GetMultiManyToOne(null, null, this, filter);
				_purchaseOrderHeaders.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeaders = true;
			}
			return _purchaseOrderHeaders;
		}

		/// <summary> Sets the collection parameters for the collection for 'PurchaseOrderHeaders'. These settings will be taken into account
		/// when the property PurchaseOrderHeaders is requested or GetMultiPurchaseOrderHeaders is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderHeaders(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderHeaders.SortClauses=sortClauses;
			_purchaseOrderHeaders.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorAddressEntity'</returns>
		public AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddresses(bool forceFetch)
		{
			return GetMultiVendorAddresses(forceFetch, _vendorAddresses.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorAddressEntity'</returns>
		public AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddresses(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiVendorAddresses(forceFetch, _vendorAddresses.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddresses(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiVendorAddresses(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddresses(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorAddresses || forceFetch || _alwaysFetchVendorAddresses) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_vendorAddresses);
				_vendorAddresses.SuppressClearInGetMulti=!forceFetch;
				_vendorAddresses.EntityFactoryToUse = entityFactoryToUse;
				_vendorAddresses.GetMultiManyToOne(null, null, this, filter);
				_vendorAddresses.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorAddresses = true;
			}
			return _vendorAddresses;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorAddresses'. These settings will be taken into account
		/// when the property VendorAddresses is requested or GetMultiVendorAddresses is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorAddresses(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorAddresses.SortClauses=sortClauses;
			_vendorAddresses.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContacts(bool forceFetch)
		{
			return GetMultiVendorContacts(forceFetch, _vendorContacts.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContacts(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiVendorContacts(forceFetch, _vendorContacts.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContacts(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiVendorContacts(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.VendorContactCollection GetMultiVendorContacts(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorContacts || forceFetch || _alwaysFetchVendorContacts) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_vendorContacts);
				_vendorContacts.SuppressClearInGetMulti=!forceFetch;
				_vendorContacts.EntityFactoryToUse = entityFactoryToUse;
				_vendorContacts.GetMultiManyToOne(null, null, this, filter);
				_vendorContacts.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContacts = true;
			}
			return _vendorContacts;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorContacts'. These settings will be taken into account
		/// when the property VendorContacts is requested or GetMultiVendorContacts is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorContacts(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorContacts.SortClauses=sortClauses;
			_vendorContacts.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ProductVendors", _productVendors);
			toReturn.Add("PurchaseOrderHeaders", _purchaseOrderHeaders);
			toReturn.Add("VendorAddresses", _vendorAddresses);
			toReturn.Add("VendorContacts", _vendorContacts);
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
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="validator">The validator object for this VendorEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 vendorID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(vendorID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_productVendors = new AW.Data.CollectionClasses.ProductVendorCollection();
			_productVendors.SetContainingEntityInfo(this, "Vendor");

			_purchaseOrderHeaders = new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection();
			_purchaseOrderHeaders.SetContainingEntityInfo(this, "Vendor");

			_vendorAddresses = new AW.Data.CollectionClasses.VendorAddressCollection();
			_vendorAddresses.SetContainingEntityInfo(this, "Vendor");

			_vendorContacts = new AW.Data.CollectionClasses.VendorContactCollection();
			_vendorContacts.SetContainingEntityInfo(this, "Vendor");
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
			_customProperties.Add("MS_Description", @"Companies from whom Adventure Works Cycles purchases parts or other goods.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Vendor account (identification) number.");
			_fieldsCustomProperties.Add("AccountNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = Vendor no longer used. 1 = Vendor is actively used.");
			_fieldsCustomProperties.Add("ActiveFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average");
			_fieldsCustomProperties.Add("CreditRating", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Company name.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.");
			_fieldsCustomProperties.Add("PreferredVendorStatus", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Vendor URL.");
			_fieldsCustomProperties.Add("PurchasingWebServiceUrl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("VendorID", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 vendorID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)VendorFieldIndex.VendorID].ForcedCurrentValueWrite(vendorID);
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
			return DAOFactory.CreateVendorDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new VendorEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static VendorRelations Relations
		{
			get	{ return new VendorRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductVendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductVendors
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductVendorCollection(), (IEntityRelation)GetRelationsForField("ProductVendors")[0], (int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.ProductVendorEntity, 0, null, null, null, "ProductVendors", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathPurchaseOrderHeaders
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.PurchaseOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("PurchaseOrderHeaders")[0], (int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.PurchaseOrderHeaderEntity, 0, null, null, null, "PurchaseOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VendorAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorAddresses
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorAddressCollection(), (IEntityRelation)GetRelationsForField("VendorAddresses")[0], (int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.VendorAddressEntity, 0, null, null, null, "VendorAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VendorContact' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorContacts
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorContactCollection(), (IEntityRelation)GetRelationsForField("VendorContacts")[0], (int)AW.Data.EntityType.VendorEntity, (int)AW.Data.EntityType.VendorContactEntity, 0, null, null, null, "VendorContacts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
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

		/// <summary> The AccountNumber property of the Entity Vendor<br/><br/>
		/// MS_Description: Vendor account (identification) number.<br/>Vendor account (identification) number.</summary>
		/// <remarks>Mapped on  table field: "Vendor"."AccountNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AccountNumber
		{
			get { return (System.String)GetValue((int)VendorFieldIndex.AccountNumber, true); }
			set	{ SetValue((int)VendorFieldIndex.AccountNumber, value, true); }
		}

		/// <summary> The ActiveFlag property of the Entity Vendor<br/><br/>
		/// MS_Description: 0 = Vendor no longer used. 1 = Vendor is actively used.<br/>0 = Vendor no longer used. 1 = Vendor is actively used.</summary>
		/// <remarks>Mapped on  table field: "Vendor"."ActiveFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ActiveFlag
		{
			get { return (System.Boolean)GetValue((int)VendorFieldIndex.ActiveFlag, true); }
			set	{ SetValue((int)VendorFieldIndex.ActiveFlag, value, true); }
		}

		/// <summary> The CreditRating property of the Entity Vendor<br/><br/>
		/// MS_Description: 1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average<br/>1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average</summary>
		/// <remarks>Mapped on  table field: "Vendor"."CreditRating"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte CreditRating
		{
			get { return (System.Byte)GetValue((int)VendorFieldIndex.CreditRating, true); }
			set	{ SetValue((int)VendorFieldIndex.CreditRating, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity Vendor<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "Vendor"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)VendorFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)VendorFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity Vendor<br/><br/>
		/// MS_Description: Company name.<br/>Company name.</summary>
		/// <remarks>Mapped on  table field: "Vendor"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)VendorFieldIndex.Name, true); }
			set	{ SetValue((int)VendorFieldIndex.Name, value, true); }
		}

		/// <summary> The PreferredVendorStatus property of the Entity Vendor<br/><br/>
		/// MS_Description: 0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.<br/>0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.</summary>
		/// <remarks>Mapped on  table field: "Vendor"."PreferredVendorStatus"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean PreferredVendorStatus
		{
			get { return (System.Boolean)GetValue((int)VendorFieldIndex.PreferredVendorStatus, true); }
			set	{ SetValue((int)VendorFieldIndex.PreferredVendorStatus, value, true); }
		}

		/// <summary> The PurchasingWebServiceUrl property of the Entity Vendor<br/><br/>
		/// MS_Description: Vendor URL.<br/>Vendor URL.</summary>
		/// <remarks>Mapped on  table field: "Vendor"."PurchasingWebServiceURL"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 1024<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PurchasingWebServiceUrl
		{
			get { return (System.String)GetValue((int)VendorFieldIndex.PurchasingWebServiceUrl, true); }
			set	{ SetValue((int)VendorFieldIndex.PurchasingWebServiceUrl, value, true); }
		}

		/// <summary> The VendorID property of the Entity Vendor<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "Vendor"."VendorID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 VendorID
		{
			get { return (System.Int32)GetValue((int)VendorFieldIndex.VendorID, true); }
			set	{ SetValue((int)VendorFieldIndex.VendorID, value, true); }
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
		/// <summary> Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderHeaders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.PurchaseOrderHeaderCollection PurchaseOrderHeaders
		{
			get	{ return GetMultiPurchaseOrderHeaders(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for PurchaseOrderHeaders. When set to true, PurchaseOrderHeaders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderHeaders is accessed. You can always execute/ a forced fetch by calling GetMultiPurchaseOrderHeaders(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderHeaders
		{
			get	{ return _alwaysFetchPurchaseOrderHeaders; }
			set	{ _alwaysFetchPurchaseOrderHeaders = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property PurchaseOrderHeaders already has been fetched. Setting this property to false when PurchaseOrderHeaders has been fetched
		/// will clear the PurchaseOrderHeaders collection well. Setting this property to true while PurchaseOrderHeaders hasn't been fetched disables lazy loading for PurchaseOrderHeaders</summary>
		[Browsable(false)]
		public bool AlreadyFetchedPurchaseOrderHeaders
		{
			get { return _alreadyFetchedPurchaseOrderHeaders;}
			set 
			{
				if(_alreadyFetchedPurchaseOrderHeaders && !value && (_purchaseOrderHeaders != null))
				{
					_purchaseOrderHeaders.Clear();
				}
				_alreadyFetchedPurchaseOrderHeaders = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorAddresses()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorAddressCollection VendorAddresses
		{
			get	{ return GetMultiVendorAddresses(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorAddresses. When set to true, VendorAddresses is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorAddresses is accessed. You can always execute/ a forced fetch by calling GetMultiVendorAddresses(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorAddresses
		{
			get	{ return _alwaysFetchVendorAddresses; }
			set	{ _alwaysFetchVendorAddresses = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorAddresses already has been fetched. Setting this property to false when VendorAddresses has been fetched
		/// will clear the VendorAddresses collection well. Setting this property to true while VendorAddresses hasn't been fetched disables lazy loading for VendorAddresses</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorAddresses
		{
			get { return _alreadyFetchedVendorAddresses;}
			set 
			{
				if(_alreadyFetchedVendorAddresses && !value && (_vendorAddresses != null))
				{
					_vendorAddresses.Clear();
				}
				_alreadyFetchedVendorAddresses = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorContacts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorContactCollection VendorContacts
		{
			get	{ return GetMultiVendorContacts(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorContacts. When set to true, VendorContacts is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorContacts is accessed. You can always execute/ a forced fetch by calling GetMultiVendorContacts(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorContacts
		{
			get	{ return _alwaysFetchVendorContacts; }
			set	{ _alwaysFetchVendorContacts = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorContacts already has been fetched. Setting this property to false when VendorContacts has been fetched
		/// will clear the VendorContacts collection well. Setting this property to true while VendorContacts hasn't been fetched disables lazy loading for VendorContacts</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorContacts
		{
			get { return _alreadyFetchedVendorContacts;}
			set 
			{
				if(_alreadyFetchedVendorContacts && !value && (_vendorContacts != null))
				{
					_vendorContacts.Clear();
				}
				_alreadyFetchedVendorContacts = value;
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
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AW.Data.EntityType.VendorEntity; }
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
