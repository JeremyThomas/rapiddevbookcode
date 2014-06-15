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
using System.ComponentModel.DataAnnotations;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Address'. <br/><br/>
	/// 
	/// MS_Description: Street address information for customers, employees, and vendors.<br/>
	/// </summary>
	[Serializable]
	public partial class AddressEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.EmployeeAddressCollection	_employeeAddresses;
		private bool	_alwaysFetchEmployeeAddresses, _alreadyFetchedEmployeeAddresses;
		private AW.Data.CollectionClasses.VendorAddressCollection	_vendorAddresses;
		private bool	_alwaysFetchVendorAddresses, _alreadyFetchedVendorAddresses;
		private AW.Data.CollectionClasses.CustomerAddressCollection	_customerAddresses;
		private bool	_alwaysFetchCustomerAddresses, _alreadyFetchedCustomerAddresses;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeaders;
		private bool	_alwaysFetchSalesOrderHeaders, _alreadyFetchedSalesOrderHeaders;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeadersShipped;
		private bool	_alwaysFetchSalesOrderHeadersShipped, _alreadyFetchedSalesOrderHeadersShipped;
		private AW.Data.CollectionClasses.CustomerCollection _customerCollectionViaCustomerAddress;
		private bool	_alwaysFetchCustomerCollectionViaCustomerAddress, _alreadyFetchedCustomerCollectionViaCustomerAddress;
		private StateProvinceEntity _stateProvince;
		private bool	_alwaysFetchStateProvince, _alreadyFetchedStateProvince, _stateProvinceReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name StateProvince</summary>
			public static readonly string StateProvince = "StateProvince";
			/// <summary>Member name EmployeeAddresses</summary>
			public static readonly string EmployeeAddresses = "EmployeeAddresses";
			/// <summary>Member name VendorAddresses</summary>
			public static readonly string VendorAddresses = "VendorAddresses";
			/// <summary>Member name CustomerAddresses</summary>
			public static readonly string CustomerAddresses = "CustomerAddresses";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name SalesOrderHeadersShipped</summary>
			public static readonly string SalesOrderHeadersShipped = "SalesOrderHeadersShipped";
			/// <summary>Member name CustomerCollectionViaCustomerAddress</summary>
			public static readonly string CustomerCollectionViaCustomerAddress = "CustomerCollectionViaCustomerAddress";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AddressEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AddressEntity() :base("AddressEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		public AddressEntity(System.Int32 addressID):base("AddressEntity")
		{
			InitClassFetch(addressID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AddressEntity(System.Int32 addressID, IPrefetchPath prefetchPathToUse):base("AddressEntity")
		{
			InitClassFetch(addressID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="validator">The custom validator object for this AddressEntity</param>
		public AddressEntity(System.Int32 addressID, IValidator validator):base("AddressEntity")
		{
			InitClassFetch(addressID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_employeeAddresses = (AW.Data.CollectionClasses.EmployeeAddressCollection)info.GetValue("_employeeAddresses", typeof(AW.Data.CollectionClasses.EmployeeAddressCollection));
			_alwaysFetchEmployeeAddresses = info.GetBoolean("_alwaysFetchEmployeeAddresses");
			_alreadyFetchedEmployeeAddresses = info.GetBoolean("_alreadyFetchedEmployeeAddresses");

			_vendorAddresses = (AW.Data.CollectionClasses.VendorAddressCollection)info.GetValue("_vendorAddresses", typeof(AW.Data.CollectionClasses.VendorAddressCollection));
			_alwaysFetchVendorAddresses = info.GetBoolean("_alwaysFetchVendorAddresses");
			_alreadyFetchedVendorAddresses = info.GetBoolean("_alreadyFetchedVendorAddresses");

			_customerAddresses = (AW.Data.CollectionClasses.CustomerAddressCollection)info.GetValue("_customerAddresses", typeof(AW.Data.CollectionClasses.CustomerAddressCollection));
			_alwaysFetchCustomerAddresses = info.GetBoolean("_alwaysFetchCustomerAddresses");
			_alreadyFetchedCustomerAddresses = info.GetBoolean("_alreadyFetchedCustomerAddresses");

			_salesOrderHeaders = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaders", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaders = info.GetBoolean("_alwaysFetchSalesOrderHeaders");
			_alreadyFetchedSalesOrderHeaders = info.GetBoolean("_alreadyFetchedSalesOrderHeaders");

			_salesOrderHeadersShipped = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeadersShipped", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeadersShipped = info.GetBoolean("_alwaysFetchSalesOrderHeadersShipped");
			_alreadyFetchedSalesOrderHeadersShipped = info.GetBoolean("_alreadyFetchedSalesOrderHeadersShipped");
			_customerCollectionViaCustomerAddress = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaCustomerAddress", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaCustomerAddress = info.GetBoolean("_alwaysFetchCustomerCollectionViaCustomerAddress");
			_alreadyFetchedCustomerCollectionViaCustomerAddress = info.GetBoolean("_alreadyFetchedCustomerCollectionViaCustomerAddress");
			_stateProvince = (StateProvinceEntity)info.GetValue("_stateProvince", typeof(StateProvinceEntity));
			if(_stateProvince!=null)
			{
				_stateProvince.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_stateProvinceReturnsNewIfNotFound = info.GetBoolean("_stateProvinceReturnsNewIfNotFound");
			_alwaysFetchStateProvince = info.GetBoolean("_alwaysFetchStateProvince");
			_alreadyFetchedStateProvince = info.GetBoolean("_alreadyFetchedStateProvince");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AddressFieldIndex)fieldIndex)
			{
				case AddressFieldIndex.StateProvinceID:
					DesetupSyncStateProvince(true, false);
					_alreadyFetchedStateProvince = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedEmployeeAddresses = (_employeeAddresses.Count > 0);
			_alreadyFetchedVendorAddresses = (_vendorAddresses.Count > 0);
			_alreadyFetchedCustomerAddresses = (_customerAddresses.Count > 0);
			_alreadyFetchedSalesOrderHeaders = (_salesOrderHeaders.Count > 0);
			_alreadyFetchedSalesOrderHeadersShipped = (_salesOrderHeadersShipped.Count > 0);
			_alreadyFetchedCustomerCollectionViaCustomerAddress = (_customerCollectionViaCustomerAddress.Count > 0);
			_alreadyFetchedStateProvince = (_stateProvince != null);
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
				case "StateProvince":
					toReturn.Add(Relations.StateProvinceEntityUsingStateProvinceID);
					break;
				case "EmployeeAddresses":
					toReturn.Add(Relations.EmployeeAddressEntityUsingAddressID);
					break;
				case "VendorAddresses":
					toReturn.Add(Relations.VendorAddressEntityUsingAddressID);
					break;
				case "CustomerAddresses":
					toReturn.Add(Relations.CustomerAddressEntityUsingAddressID);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingBillToAddressID);
					break;
				case "SalesOrderHeadersShipped":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingShipToAddressID);
					break;
				case "CustomerCollectionViaCustomerAddress":
					toReturn.Add(Relations.CustomerAddressEntityUsingAddressID, "AddressEntity__", "CustomerAddress_", JoinHint.None);
					toReturn.Add(CustomerAddressEntity.Relations.CustomerEntityUsingCustomerID, "CustomerAddress_", string.Empty, JoinHint.None);
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
			info.AddValue("_employeeAddresses", (!this.MarkedForDeletion?_employeeAddresses:null));
			info.AddValue("_alwaysFetchEmployeeAddresses", _alwaysFetchEmployeeAddresses);
			info.AddValue("_alreadyFetchedEmployeeAddresses", _alreadyFetchedEmployeeAddresses);
			info.AddValue("_vendorAddresses", (!this.MarkedForDeletion?_vendorAddresses:null));
			info.AddValue("_alwaysFetchVendorAddresses", _alwaysFetchVendorAddresses);
			info.AddValue("_alreadyFetchedVendorAddresses", _alreadyFetchedVendorAddresses);
			info.AddValue("_customerAddresses", (!this.MarkedForDeletion?_customerAddresses:null));
			info.AddValue("_alwaysFetchCustomerAddresses", _alwaysFetchCustomerAddresses);
			info.AddValue("_alreadyFetchedCustomerAddresses", _alreadyFetchedCustomerAddresses);
			info.AddValue("_salesOrderHeaders", (!this.MarkedForDeletion?_salesOrderHeaders:null));
			info.AddValue("_alwaysFetchSalesOrderHeaders", _alwaysFetchSalesOrderHeaders);
			info.AddValue("_alreadyFetchedSalesOrderHeaders", _alreadyFetchedSalesOrderHeaders);
			info.AddValue("_salesOrderHeadersShipped", (!this.MarkedForDeletion?_salesOrderHeadersShipped:null));
			info.AddValue("_alwaysFetchSalesOrderHeadersShipped", _alwaysFetchSalesOrderHeadersShipped);
			info.AddValue("_alreadyFetchedSalesOrderHeadersShipped", _alreadyFetchedSalesOrderHeadersShipped);
			info.AddValue("_customerCollectionViaCustomerAddress", (!this.MarkedForDeletion?_customerCollectionViaCustomerAddress:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaCustomerAddress", _alwaysFetchCustomerCollectionViaCustomerAddress);
			info.AddValue("_alreadyFetchedCustomerCollectionViaCustomerAddress", _alreadyFetchedCustomerCollectionViaCustomerAddress);
			info.AddValue("_stateProvince", (!this.MarkedForDeletion?_stateProvince:null));
			info.AddValue("_stateProvinceReturnsNewIfNotFound", _stateProvinceReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchStateProvince", _alwaysFetchStateProvince);
			info.AddValue("_alreadyFetchedStateProvince", _alreadyFetchedStateProvince);

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
				case "StateProvince":
					_alreadyFetchedStateProvince = true;
					this.StateProvince = (StateProvinceEntity)entity;
					break;
				case "EmployeeAddresses":
					_alreadyFetchedEmployeeAddresses = true;
					if(entity!=null)
					{
						this.EmployeeAddresses.Add((EmployeeAddressEntity)entity);
					}
					break;
				case "VendorAddresses":
					_alreadyFetchedVendorAddresses = true;
					if(entity!=null)
					{
						this.VendorAddresses.Add((VendorAddressEntity)entity);
					}
					break;
				case "CustomerAddresses":
					_alreadyFetchedCustomerAddresses = true;
					if(entity!=null)
					{
						this.CustomerAddresses.Add((CustomerAddressEntity)entity);
					}
					break;
				case "SalesOrderHeaders":
					_alreadyFetchedSalesOrderHeaders = true;
					if(entity!=null)
					{
						this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "SalesOrderHeadersShipped":
					_alreadyFetchedSalesOrderHeadersShipped = true;
					if(entity!=null)
					{
						this.SalesOrderHeadersShipped.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "CustomerCollectionViaCustomerAddress":
					_alreadyFetchedCustomerCollectionViaCustomerAddress = true;
					if(entity!=null)
					{
						this.CustomerCollectionViaCustomerAddress.Add((CustomerEntity)entity);
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
				case "StateProvince":
					SetupSyncStateProvince(relatedEntity);
					break;
				case "EmployeeAddresses":
					_employeeAddresses.Add((EmployeeAddressEntity)relatedEntity);
					break;
				case "VendorAddresses":
					_vendorAddresses.Add((VendorAddressEntity)relatedEntity);
					break;
				case "CustomerAddresses":
					_customerAddresses.Add((CustomerAddressEntity)relatedEntity);
					break;
				case "SalesOrderHeaders":
					_salesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				case "SalesOrderHeadersShipped":
					_salesOrderHeadersShipped.Add((SalesOrderHeaderEntity)relatedEntity);
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
				case "StateProvince":
					DesetupSyncStateProvince(false, true);
					break;
				case "EmployeeAddresses":
					this.PerformRelatedEntityRemoval(_employeeAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "VendorAddresses":
					this.PerformRelatedEntityRemoval(_vendorAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CustomerAddresses":
					this.PerformRelatedEntityRemoval(_customerAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeaders":
					this.PerformRelatedEntityRemoval(_salesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeadersShipped":
					this.PerformRelatedEntityRemoval(_salesOrderHeadersShipped, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_stateProvince!=null)
			{
				toReturn.Add(_stateProvince);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_employeeAddresses);
			toReturn.Add(_vendorAddresses);
			toReturn.Add(_customerAddresses);
			toReturn.Add(_salesOrderHeaders);
			toReturn.Add(_salesOrderHeadersShipped);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID)
		{
			return FetchUsingPK(addressID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(addressID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(addressID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(addressID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AddressID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new AddressRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeAddressEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeAddressCollection GetMultiEmployeeAddresses(bool forceFetch)
		{
			return GetMultiEmployeeAddresses(forceFetch, _employeeAddresses.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeAddressEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeAddressCollection GetMultiEmployeeAddresses(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployeeAddresses(forceFetch, _employeeAddresses.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeAddressCollection GetMultiEmployeeAddresses(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployeeAddresses(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.EmployeeAddressCollection GetMultiEmployeeAddresses(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeAddresses || forceFetch || _alwaysFetchEmployeeAddresses) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_employeeAddresses);
				_employeeAddresses.SuppressClearInGetMulti=!forceFetch;
				_employeeAddresses.EntityFactoryToUse = entityFactoryToUse;
				_employeeAddresses.GetMultiManyToOne(null, this, filter);
				_employeeAddresses.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeAddresses = true;
			}
			return _employeeAddresses;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeAddresses'. These settings will be taken into account
		/// when the property EmployeeAddresses is requested or GetMultiEmployeeAddresses is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeAddresses(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeAddresses.SortClauses=sortClauses;
			_employeeAddresses.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_vendorAddresses.GetMultiManyToOne(this, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerAddressEntity'</returns>
		public AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddresses(bool forceFetch)
		{
			return GetMultiCustomerAddresses(forceFetch, _customerAddresses.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CustomerAddressEntity'</returns>
		public AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddresses(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCustomerAddresses(forceFetch, _customerAddresses.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddresses(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCustomerAddresses(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddresses(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCustomerAddresses || forceFetch || _alwaysFetchCustomerAddresses) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customerAddresses);
				_customerAddresses.SuppressClearInGetMulti=!forceFetch;
				_customerAddresses.EntityFactoryToUse = entityFactoryToUse;
				_customerAddresses.GetMultiManyToOne(this, null, null, filter);
				_customerAddresses.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerAddresses = true;
			}
			return _customerAddresses;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerAddresses'. These settings will be taken into account
		/// when the property CustomerAddresses is requested or GetMultiCustomerAddresses is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerAddresses(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerAddresses.SortClauses=sortClauses;
			_customerAddresses.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch)
		{
			return GetMultiSalesOrderHeaders(forceFetch, _salesOrderHeaders.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderHeaders(forceFetch, _salesOrderHeaders.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderHeaders(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeaders(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaders || forceFetch || _alwaysFetchSalesOrderHeaders) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesOrderHeaders);
				_salesOrderHeaders.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeaders.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeaders.GetMultiManyToOne(this, null, null, null, null, null, null, null, null, null, null, filter);
				_salesOrderHeaders.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaders = true;
			}
			return _salesOrderHeaders;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeaders'. These settings will be taken into account
		/// when the property SalesOrderHeaders is requested or GetMultiSalesOrderHeaders is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeaders(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeaders.SortClauses=sortClauses;
			_salesOrderHeaders.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeadersShipped(bool forceFetch)
		{
			return GetMultiSalesOrderHeadersShipped(forceFetch, _salesOrderHeadersShipped.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeadersShipped(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderHeadersShipped(forceFetch, _salesOrderHeadersShipped.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeadersShipped(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderHeadersShipped(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeadersShipped(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeadersShipped || forceFetch || _alwaysFetchSalesOrderHeadersShipped) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesOrderHeadersShipped);
				_salesOrderHeadersShipped.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeadersShipped.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeadersShipped.GetMultiManyToOne(null, this, null, null, null, null, null, null, null, null, null, filter);
				_salesOrderHeadersShipped.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeadersShipped = true;
			}
			return _salesOrderHeadersShipped;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeadersShipped'. These settings will be taken into account
		/// when the property SalesOrderHeadersShipped is requested or GetMultiSalesOrderHeadersShipped is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeadersShipped(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeadersShipped.SortClauses=sortClauses;
			_salesOrderHeadersShipped.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaCustomerAddress(bool forceFetch)
		{
			return GetMultiCustomerCollectionViaCustomerAddress(forceFetch, _customerCollectionViaCustomerAddress.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaCustomerAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerCollectionViaCustomerAddress || forceFetch || _alwaysFetchCustomerCollectionViaCustomerAddress) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_customerCollectionViaCustomerAddress);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressFields.AddressID, ComparisonOperator.Equal, this.AddressID, "AddressEntity__"));
				_customerCollectionViaCustomerAddress.SuppressClearInGetMulti=!forceFetch;
				_customerCollectionViaCustomerAddress.EntityFactoryToUse = entityFactoryToUse;
				_customerCollectionViaCustomerAddress.GetMulti(filter, GetRelationsForField("CustomerCollectionViaCustomerAddress"));
				_customerCollectionViaCustomerAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerCollectionViaCustomerAddress = true;
			}
			return _customerCollectionViaCustomerAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerCollectionViaCustomerAddress'. These settings will be taken into account
		/// when the property CustomerCollectionViaCustomerAddress is requested or GetMultiCustomerCollectionViaCustomerAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerCollectionViaCustomerAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerCollectionViaCustomerAddress.SortClauses=sortClauses;
			_customerCollectionViaCustomerAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'StateProvinceEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'StateProvinceEntity' which is related to this entity.</returns>
		public StateProvinceEntity GetSingleStateProvince()
		{
			return GetSingleStateProvince(false);
		}

		/// <summary> Retrieves the related entity of type 'StateProvinceEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'StateProvinceEntity' which is related to this entity.</returns>
		public virtual StateProvinceEntity GetSingleStateProvince(bool forceFetch)
		{
			if( ( !_alreadyFetchedStateProvince || forceFetch || _alwaysFetchStateProvince) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.StateProvinceEntityUsingStateProvinceID);
				StateProvinceEntity newEntity = new StateProvinceEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.StateProvinceID);
				}
				if(fetchResult)
				{
					newEntity = (StateProvinceEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_stateProvinceReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.StateProvince = newEntity;
				_alreadyFetchedStateProvince = fetchResult;
			}
			return _stateProvince;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("StateProvince", _stateProvince);
			toReturn.Add("EmployeeAddresses", _employeeAddresses);
			toReturn.Add("VendorAddresses", _vendorAddresses);
			toReturn.Add("CustomerAddresses", _customerAddresses);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("SalesOrderHeadersShipped", _salesOrderHeadersShipped);
			toReturn.Add("CustomerCollectionViaCustomerAddress", _customerCollectionViaCustomerAddress);
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
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="validator">The validator object for this AddressEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 addressID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(addressID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_employeeAddresses = new AW.Data.CollectionClasses.EmployeeAddressCollection();
			_employeeAddresses.SetContainingEntityInfo(this, "Address");

			_vendorAddresses = new AW.Data.CollectionClasses.VendorAddressCollection();
			_vendorAddresses.SetContainingEntityInfo(this, "Address");

			_customerAddresses = new AW.Data.CollectionClasses.CustomerAddressCollection();
			_customerAddresses.SetContainingEntityInfo(this, "Address");

			_salesOrderHeaders = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
			_salesOrderHeaders.SetContainingEntityInfo(this, "BillingAddress");

			_salesOrderHeadersShipped = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
			_salesOrderHeadersShipped.SetContainingEntityInfo(this, "ShippingAddress");
			_customerCollectionViaCustomerAddress = new AW.Data.CollectionClasses.CustomerCollection();
			_stateProvinceReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"Street address information for customers, employees, and vendors.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("AddressID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"First street address line.");
			_fieldsCustomProperties.Add("AddressLine1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("AddressLine2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Name of the city.");
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Postal code for the street address.");
			_fieldsCustomProperties.Add("PostalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique identification number for the state or province. Foreign key to StateProvince table.");
			_fieldsCustomProperties.Add("StateProvinceID", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _stateProvince</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStateProvince(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _stateProvince, new PropertyChangedEventHandler( OnStateProvincePropertyChanged ), "StateProvince", AW.Data.RelationClasses.StaticAddressRelations.StateProvinceEntityUsingStateProvinceIDStatic, true, signalRelatedEntity, "Addresses", resetFKFields, new int[] { (int)AddressFieldIndex.StateProvinceID } );		
			_stateProvince = null;
		}
		
		/// <summary> setups the sync logic for member _stateProvince</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncStateProvince(IEntityCore relatedEntity)
		{
			if(_stateProvince!=relatedEntity)
			{		
				DesetupSyncStateProvince(true, true);
				_stateProvince = (StateProvinceEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _stateProvince, new PropertyChangedEventHandler( OnStateProvincePropertyChanged ), "StateProvince", AW.Data.RelationClasses.StaticAddressRelations.StateProvinceEntityUsingStateProvinceIDStatic, true, ref _alreadyFetchedStateProvince, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnStateProvincePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 addressID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)AddressFieldIndex.AddressID].ForcedCurrentValueWrite(addressID);
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
			return DAOFactory.CreateAddressDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AddressEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AddressRelations Relations
		{
			get	{ return new AddressRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeeAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeAddresses
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeAddressCollection(), (IEntityRelation)GetRelationsForField("EmployeeAddresses")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.EmployeeAddressEntity, 0, null, null, null, "EmployeeAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VendorAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorAddresses
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorAddressCollection(), (IEntityRelation)GetRelationsForField("VendorAddresses")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.VendorAddressEntity, 0, null, null, null, "VendorAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerAddresses
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerAddressCollection(), (IEntityRelation)GetRelationsForField("CustomerAddresses")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerAddressEntity, 0, null, null, null, "CustomerAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaders
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeadersShipped
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeadersShipped")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeadersShipped", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaCustomerAddress
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CustomerAddressEntityUsingAddressID;
				intermediateRelation.SetAliases(string.Empty, "CustomerAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), intermediateRelation,	(int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaCustomerAddress"), "CustomerCollectionViaCustomerAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StateProvince'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStateProvince
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.StateProvinceCollection(), (IEntityRelation)GetRelationsForField("StateProvince")[0], (int)AW.Data.EntityType.AddressEntity, (int)AW.Data.EntityType.StateProvinceEntity, 0, null, null, null, "StateProvince", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The AddressID property of the Entity Address<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "Address"."AddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AddressID
		{
			get { return (System.Int32)GetValue((int)AddressFieldIndex.AddressID, true); }
			set	{ SetValue((int)AddressFieldIndex.AddressID, value, true); }
		}

		/// <summary> The AddressLine1 property of the Entity Address<br/><br/>
		/// MS_Description: First street address line.<br/>First street address line.</summary>
		/// <remarks>Mapped on  table field: "Address"."AddressLine1"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AddressLine1
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.AddressLine1, true); }
			set	{ SetValue((int)AddressFieldIndex.AddressLine1, value, true); }
		}

		/// <summary> The AddressLine2 property of the Entity Address<br/><br/>
		/// MS_Description: Nonclustered index.<br/>Nonclustered index.</summary>
		/// <remarks>Mapped on  table field: "Address"."AddressLine2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AddressLine2
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.AddressLine2, true); }
			set	{ SetValue((int)AddressFieldIndex.AddressLine2, value, true); }
		}

		/// <summary> The City property of the Entity Address<br/><br/>
		/// MS_Description: Name of the city.<br/>Name of the city.</summary>
		/// <remarks>Mapped on  table field: "Address"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.City, true); }
			set	{ SetValue((int)AddressFieldIndex.City, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity Address<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "Address"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)AddressFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)AddressFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The PostalCode property of the Entity Address<br/><br/>
		/// MS_Description: Postal code for the street address.<br/>Postal code for the street address.</summary>
		/// <remarks>Mapped on  table field: "Address"."PostalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)AddressFieldIndex.PostalCode, true); }
			set	{ SetValue((int)AddressFieldIndex.PostalCode, value, true); }
		}

		/// <summary> The Rowguid property of the Entity Address<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
		/// <remarks>Mapped on  table field: "Address"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)AddressFieldIndex.Rowguid, true); }
			set	{ SetValue((int)AddressFieldIndex.Rowguid, value, true); }
		}

		/// <summary> The StateProvinceID property of the Entity Address<br/><br/>
		/// MS_Description: Unique identification number for the state or province. Foreign key to StateProvince table.<br/>Unique identification number for the state or province. Foreign key to StateProvince table.</summary>
		/// <remarks>Mapped on  table field: "Address"."StateProvinceID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StateProvinceID
		{
			get { return (System.Int32)GetValue((int)AddressFieldIndex.StateProvinceID, true); }
			set	{ SetValue((int)AddressFieldIndex.StateProvinceID, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeAddresses()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeAddressCollection EmployeeAddresses
		{
			get	{ return GetMultiEmployeeAddresses(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeAddresses. When set to true, EmployeeAddresses is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeAddresses is accessed. You can always execute/ a forced fetch by calling GetMultiEmployeeAddresses(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeAddresses
		{
			get	{ return _alwaysFetchEmployeeAddresses; }
			set	{ _alwaysFetchEmployeeAddresses = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeAddresses already has been fetched. Setting this property to false when EmployeeAddresses has been fetched
		/// will clear the EmployeeAddresses collection well. Setting this property to true while EmployeeAddresses hasn't been fetched disables lazy loading for EmployeeAddresses</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeAddresses
		{
			get { return _alreadyFetchedEmployeeAddresses;}
			set 
			{
				if(_alreadyFetchedEmployeeAddresses && !value && (_employeeAddresses != null))
				{
					_employeeAddresses.Clear();
				}
				_alreadyFetchedEmployeeAddresses = value;
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
		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerAddresses()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerAddressCollection CustomerAddresses
		{
			get	{ return GetMultiCustomerAddresses(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerAddresses. When set to true, CustomerAddresses is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerAddresses is accessed. You can always execute/ a forced fetch by calling GetMultiCustomerAddresses(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerAddresses
		{
			get	{ return _alwaysFetchCustomerAddresses; }
			set	{ _alwaysFetchCustomerAddresses = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerAddresses already has been fetched. Setting this property to false when CustomerAddresses has been fetched
		/// will clear the CustomerAddresses collection well. Setting this property to true while CustomerAddresses hasn't been fetched disables lazy loading for CustomerAddresses</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerAddresses
		{
			get { return _alreadyFetchedCustomerAddresses;}
			set 
			{
				if(_alreadyFetchedCustomerAddresses && !value && (_customerAddresses != null))
				{
					_customerAddresses.Clear();
				}
				_alreadyFetchedCustomerAddresses = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeaders()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeaders
		{
			get	{ return GetMultiSalesOrderHeaders(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeaders. When set to true, SalesOrderHeaders is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeaders is accessed. You can always execute/ a forced fetch by calling GetMultiSalesOrderHeaders(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeaders
		{
			get	{ return _alwaysFetchSalesOrderHeaders; }
			set	{ _alwaysFetchSalesOrderHeaders = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeaders already has been fetched. Setting this property to false when SalesOrderHeaders has been fetched
		/// will clear the SalesOrderHeaders collection well. Setting this property to true while SalesOrderHeaders hasn't been fetched disables lazy loading for SalesOrderHeaders</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeaders
		{
			get { return _alreadyFetchedSalesOrderHeaders;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeaders && !value && (_salesOrderHeaders != null))
				{
					_salesOrderHeaders.Clear();
				}
				_alreadyFetchedSalesOrderHeaders = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeadersShipped()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeadersShipped
		{
			get	{ return GetMultiSalesOrderHeadersShipped(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeadersShipped. When set to true, SalesOrderHeadersShipped is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeadersShipped is accessed. You can always execute/ a forced fetch by calling GetMultiSalesOrderHeadersShipped(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeadersShipped
		{
			get	{ return _alwaysFetchSalesOrderHeadersShipped; }
			set	{ _alwaysFetchSalesOrderHeadersShipped = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeadersShipped already has been fetched. Setting this property to false when SalesOrderHeadersShipped has been fetched
		/// will clear the SalesOrderHeadersShipped collection well. Setting this property to true while SalesOrderHeadersShipped hasn't been fetched disables lazy loading for SalesOrderHeadersShipped</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeadersShipped
		{
			get { return _alreadyFetchedSalesOrderHeadersShipped;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeadersShipped && !value && (_salesOrderHeadersShipped != null))
				{
					_salesOrderHeadersShipped.Clear();
				}
				_alreadyFetchedSalesOrderHeadersShipped = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerCollectionViaCustomerAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerCollection CustomerCollectionViaCustomerAddress
		{
			get { return GetMultiCustomerCollectionViaCustomerAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerCollectionViaCustomerAddress. When set to true, CustomerCollectionViaCustomerAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerCollectionViaCustomerAddress is accessed. You can always execute a forced fetch by calling GetMultiCustomerCollectionViaCustomerAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerCollectionViaCustomerAddress
		{
			get	{ return _alwaysFetchCustomerCollectionViaCustomerAddress; }
			set	{ _alwaysFetchCustomerCollectionViaCustomerAddress = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerCollectionViaCustomerAddress already has been fetched. Setting this property to false when CustomerCollectionViaCustomerAddress has been fetched
		/// will clear the CustomerCollectionViaCustomerAddress collection well. Setting this property to true while CustomerCollectionViaCustomerAddress hasn't been fetched disables lazy loading for CustomerCollectionViaCustomerAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerCollectionViaCustomerAddress
		{
			get { return _alreadyFetchedCustomerCollectionViaCustomerAddress;}
			set 
			{
				if(_alreadyFetchedCustomerCollectionViaCustomerAddress && !value && (_customerCollectionViaCustomerAddress != null))
				{
					_customerCollectionViaCustomerAddress.Clear();
				}
				_alreadyFetchedCustomerCollectionViaCustomerAddress = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'StateProvinceEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleStateProvince()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual StateProvinceEntity StateProvince
		{
			get	{ return GetSingleStateProvince(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncStateProvince(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Addresses", "StateProvince", _stateProvince, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for StateProvince. When set to true, StateProvince is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StateProvince is accessed. You can always execute a forced fetch by calling GetSingleStateProvince(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStateProvince
		{
			get	{ return _alwaysFetchStateProvince; }
			set	{ _alwaysFetchStateProvince = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property StateProvince already has been fetched. Setting this property to false when StateProvince has been fetched
		/// will set StateProvince to null as well. Setting this property to true while StateProvince hasn't been fetched disables lazy loading for StateProvince</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStateProvince
		{
			get { return _alreadyFetchedStateProvince;}
			set 
			{
				if(_alreadyFetchedStateProvince && !value)
				{
					this.StateProvince = null;
				}
				_alreadyFetchedStateProvince = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property StateProvince is not found
		/// in the database. When set to true, StateProvince will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool StateProvinceReturnsNewIfNotFound
		{
			get	{ return _stateProvinceReturnsNewIfNotFound; }
			set { _stateProvinceReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.AddressEntity; }
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
