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
	/// <summary>Entity base class which represents the base class for the entity 'AddressType'.<br/><br/>
	/// 
	/// MS_Description: Types of addresses stored in the Address table. <br/>
	/// </summary>
	[Serializable]
	public abstract partial class AddressTypeEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.CustomerAddressCollection	_customerAddresses;
		private bool	_alwaysFetchCustomerAddresses, _alreadyFetchedCustomerAddresses;
		private AW.Data.CollectionClasses.VendorAddressCollection	_vendorAddress;
		private bool	_alwaysFetchVendorAddress, _alreadyFetchedVendorAddress;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaVendorAddress;
		private bool	_alwaysFetchAddressCollectionViaVendorAddress, _alreadyFetchedAddressCollectionViaVendorAddress;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaCustomerAddres;
		private bool	_alwaysFetchAddressCollectionViaCustomerAddres, _alreadyFetchedAddressCollectionViaCustomerAddres;
		private AW.Data.CollectionClasses.CustomerCollection _customerCollectionViaCustomerAddres;
		private bool	_alwaysFetchCustomerCollectionViaCustomerAddres, _alreadyFetchedCustomerCollectionViaCustomerAddres;
		private AW.Data.CollectionClasses.VendorCollection _vendorCollectionViaVendorAddress;
		private bool	_alwaysFetchVendorCollectionViaVendorAddress, _alreadyFetchedVendorCollectionViaVendorAddress;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name CustomerAddresses</summary>
			public static readonly string CustomerAddresses = "CustomerAddresses";
			/// <summary>Member name VendorAddress</summary>
			public static readonly string VendorAddress = "VendorAddress";
			/// <summary>Member name AddressCollectionViaVendorAddress</summary>
			public static readonly string AddressCollectionViaVendorAddress = "AddressCollectionViaVendorAddress";
			/// <summary>Member name AddressCollectionViaCustomerAddres</summary>
			public static readonly string AddressCollectionViaCustomerAddres = "AddressCollectionViaCustomerAddres";
			/// <summary>Member name CustomerCollectionViaCustomerAddres</summary>
			public static readonly string CustomerCollectionViaCustomerAddres = "CustomerCollectionViaCustomerAddres";
			/// <summary>Member name VendorCollectionViaVendorAddress</summary>
			public static readonly string VendorCollectionViaVendorAddress = "VendorCollectionViaVendorAddress";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AddressTypeEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AddressTypeEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		public AddressTypeEntityBase(System.Int32 addressTypeID)
		{
			InitClassFetch(addressTypeID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AddressTypeEntityBase(System.Int32 addressTypeID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(addressTypeID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <param name="validator">The custom validator object for this AddressTypeEntity</param>
		public AddressTypeEntityBase(System.Int32 addressTypeID, IValidator validator)
		{
			InitClassFetch(addressTypeID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AddressTypeEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_customerAddresses = (AW.Data.CollectionClasses.CustomerAddressCollection)info.GetValue("_customerAddresses", typeof(AW.Data.CollectionClasses.CustomerAddressCollection));
			_alwaysFetchCustomerAddresses = info.GetBoolean("_alwaysFetchCustomerAddresses");
			_alreadyFetchedCustomerAddresses = info.GetBoolean("_alreadyFetchedCustomerAddresses");
			_vendorAddress = (AW.Data.CollectionClasses.VendorAddressCollection)info.GetValue("_vendorAddress", typeof(AW.Data.CollectionClasses.VendorAddressCollection));
			_alwaysFetchVendorAddress = info.GetBoolean("_alwaysFetchVendorAddress");
			_alreadyFetchedVendorAddress = info.GetBoolean("_alreadyFetchedVendorAddress");
			_addressCollectionViaVendorAddress = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaVendorAddress", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaVendorAddress = info.GetBoolean("_alwaysFetchAddressCollectionViaVendorAddress");
			_alreadyFetchedAddressCollectionViaVendorAddress = info.GetBoolean("_alreadyFetchedAddressCollectionViaVendorAddress");
			_addressCollectionViaCustomerAddres = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaCustomerAddres", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaCustomerAddres = info.GetBoolean("_alwaysFetchAddressCollectionViaCustomerAddres");
			_alreadyFetchedAddressCollectionViaCustomerAddres = info.GetBoolean("_alreadyFetchedAddressCollectionViaCustomerAddres");
			_customerCollectionViaCustomerAddres = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaCustomerAddres", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaCustomerAddres = info.GetBoolean("_alwaysFetchCustomerCollectionViaCustomerAddres");
			_alreadyFetchedCustomerCollectionViaCustomerAddres = info.GetBoolean("_alreadyFetchedCustomerCollectionViaCustomerAddres");
			_vendorCollectionViaVendorAddress = (AW.Data.CollectionClasses.VendorCollection)info.GetValue("_vendorCollectionViaVendorAddress", typeof(AW.Data.CollectionClasses.VendorCollection));
			_alwaysFetchVendorCollectionViaVendorAddress = info.GetBoolean("_alwaysFetchVendorCollectionViaVendorAddress");
			_alreadyFetchedVendorCollectionViaVendorAddress = info.GetBoolean("_alreadyFetchedVendorCollectionViaVendorAddress");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AddressTypeFieldIndex)fieldIndex)
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
			_alreadyFetchedCustomerAddresses = (_customerAddresses.Count > 0);
			_alreadyFetchedVendorAddress = (_vendorAddress.Count > 0);
			_alreadyFetchedAddressCollectionViaVendorAddress = (_addressCollectionViaVendorAddress.Count > 0);
			_alreadyFetchedAddressCollectionViaCustomerAddres = (_addressCollectionViaCustomerAddres.Count > 0);
			_alreadyFetchedCustomerCollectionViaCustomerAddres = (_customerCollectionViaCustomerAddres.Count > 0);
			_alreadyFetchedVendorCollectionViaVendorAddress = (_vendorCollectionViaVendorAddress.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return AddressTypeEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "CustomerAddresses":
					toReturn.Add(AddressTypeEntity.Relations.CustomerAddressEntityUsingAddressTypeID);
					break;
				case "VendorAddress":
					toReturn.Add(AddressTypeEntity.Relations.VendorAddressEntityUsingAddressTypeID);
					break;
				case "AddressCollectionViaVendorAddress":
					toReturn.Add(AddressTypeEntity.Relations.VendorAddressEntityUsingAddressTypeID, "AddressTypeEntity__", "VendorAddress_", JoinHint.None);
					toReturn.Add(VendorAddressEntity.Relations.AddressEntityUsingAddressID, "VendorAddress_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaCustomerAddres":
					toReturn.Add(AddressTypeEntity.Relations.CustomerAddressEntityUsingAddressTypeID, "AddressTypeEntity__", "CustomerAddress_", JoinHint.None);
					toReturn.Add(CustomerAddressEntity.Relations.AddressEntityUsingAddressID, "CustomerAddress_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaCustomerAddres":
					toReturn.Add(AddressTypeEntity.Relations.CustomerAddressEntityUsingAddressTypeID, "AddressTypeEntity__", "CustomerAddress_", JoinHint.None);
					toReturn.Add(CustomerAddressEntity.Relations.CustomerEntityUsingCustomerID, "CustomerAddress_", string.Empty, JoinHint.None);
					break;
				case "VendorCollectionViaVendorAddress":
					toReturn.Add(AddressTypeEntity.Relations.VendorAddressEntityUsingAddressTypeID, "AddressTypeEntity__", "VendorAddress_", JoinHint.None);
					toReturn.Add(VendorAddressEntity.Relations.VendorEntityUsingVendorID, "VendorAddress_", string.Empty, JoinHint.None);
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
			info.AddValue("_customerAddresses", (!this.MarkedForDeletion?_customerAddresses:null));
			info.AddValue("_alwaysFetchCustomerAddresses", _alwaysFetchCustomerAddresses);
			info.AddValue("_alreadyFetchedCustomerAddresses", _alreadyFetchedCustomerAddresses);
			info.AddValue("_vendorAddress", (!this.MarkedForDeletion?_vendorAddress:null));
			info.AddValue("_alwaysFetchVendorAddress", _alwaysFetchVendorAddress);
			info.AddValue("_alreadyFetchedVendorAddress", _alreadyFetchedVendorAddress);
			info.AddValue("_addressCollectionViaVendorAddress", (!this.MarkedForDeletion?_addressCollectionViaVendorAddress:null));
			info.AddValue("_alwaysFetchAddressCollectionViaVendorAddress", _alwaysFetchAddressCollectionViaVendorAddress);
			info.AddValue("_alreadyFetchedAddressCollectionViaVendorAddress", _alreadyFetchedAddressCollectionViaVendorAddress);
			info.AddValue("_addressCollectionViaCustomerAddres", (!this.MarkedForDeletion?_addressCollectionViaCustomerAddres:null));
			info.AddValue("_alwaysFetchAddressCollectionViaCustomerAddres", _alwaysFetchAddressCollectionViaCustomerAddres);
			info.AddValue("_alreadyFetchedAddressCollectionViaCustomerAddres", _alreadyFetchedAddressCollectionViaCustomerAddres);
			info.AddValue("_customerCollectionViaCustomerAddres", (!this.MarkedForDeletion?_customerCollectionViaCustomerAddres:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaCustomerAddres", _alwaysFetchCustomerCollectionViaCustomerAddres);
			info.AddValue("_alreadyFetchedCustomerCollectionViaCustomerAddres", _alreadyFetchedCustomerCollectionViaCustomerAddres);
			info.AddValue("_vendorCollectionViaVendorAddress", (!this.MarkedForDeletion?_vendorCollectionViaVendorAddress:null));
			info.AddValue("_alwaysFetchVendorCollectionViaVendorAddress", _alwaysFetchVendorCollectionViaVendorAddress);
			info.AddValue("_alreadyFetchedVendorCollectionViaVendorAddress", _alreadyFetchedVendorCollectionViaVendorAddress);


			
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

				case "CustomerAddresses":
					_alreadyFetchedCustomerAddresses = true;
					if(entity!=null)
					{
						this.CustomerAddresses.Add((CustomerAddressEntity)entity);
					}
					break;
				case "VendorAddress":
					_alreadyFetchedVendorAddress = true;
					if(entity!=null)
					{
						this.VendorAddress.Add((VendorAddressEntity)entity);
					}
					break;
				case "AddressCollectionViaVendorAddress":
					_alreadyFetchedAddressCollectionViaVendorAddress = true;
					if(entity!=null)
					{
						this.AddressCollectionViaVendorAddress.Add((AddressEntity)entity);
					}
					break;
				case "AddressCollectionViaCustomerAddres":
					_alreadyFetchedAddressCollectionViaCustomerAddres = true;
					if(entity!=null)
					{
						this.AddressCollectionViaCustomerAddres.Add((AddressEntity)entity);
					}
					break;
				case "CustomerCollectionViaCustomerAddres":
					_alreadyFetchedCustomerCollectionViaCustomerAddres = true;
					if(entity!=null)
					{
						this.CustomerCollectionViaCustomerAddres.Add((CustomerEntity)entity);
					}
					break;
				case "VendorCollectionViaVendorAddress":
					_alreadyFetchedVendorCollectionViaVendorAddress = true;
					if(entity!=null)
					{
						this.VendorCollectionViaVendorAddress.Add((VendorEntity)entity);
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

				case "CustomerAddresses":
					_customerAddresses.Add((CustomerAddressEntity)relatedEntity);
					break;
				case "VendorAddress":
					_vendorAddress.Add((VendorAddressEntity)relatedEntity);
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

				case "CustomerAddresses":
					base.PerformRelatedEntityRemoval(_customerAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "VendorAddress":
					base.PerformRelatedEntityRemoval(_vendorAddress, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_customerAddresses);
			toReturn.Add(_vendorAddress);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressTypeID)
		{
			return FetchUsingPK(addressTypeID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressTypeID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(addressTypeID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressTypeID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(addressTypeID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressTypeID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(addressTypeID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AddressTypeID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(AddressTypeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(AddressTypeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new AddressTypeRelations().GetAllRelations();
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
 			if( ( !_alreadyFetchedCustomerAddresses || forceFetch || _alwaysFetchCustomerAddresses) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerAddresses.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerAddresses);
					}
				}
				_customerAddresses.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerAddresses.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerAddresses.GetMultiManyToOne(null, this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorAddressEntity'</returns>
		public AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddress(bool forceFetch)
		{
			return GetMultiVendorAddress(forceFetch, _vendorAddress.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorAddressEntity'</returns>
		public AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddress(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiVendorAddress(forceFetch, _vendorAddress.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiVendorAddress(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.VendorAddressCollection GetMultiVendorAddress(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorAddress || forceFetch || _alwaysFetchVendorAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorAddress);
					}
				}
				_vendorAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_vendorAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_vendorAddress.GetMultiManyToOne(null, this, null, filter);
				_vendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorAddress = true;
			}
			return _vendorAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorAddress'. These settings will be taken into account
		/// when the property VendorAddress is requested or GetMultiVendorAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorAddress.SortClauses=sortClauses;
			_vendorAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaVendorAddress(bool forceFetch)
		{
			return GetMultiAddressCollectionViaVendorAddress(forceFetch, _addressCollectionViaVendorAddress.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaVendorAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressCollectionViaVendorAddress || forceFetch || _alwaysFetchAddressCollectionViaVendorAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressCollectionViaVendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressCollectionViaVendorAddress);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressTypeFields.AddressTypeID, ComparisonOperator.Equal, this.AddressTypeID, "AddressTypeEntity__"));
				_addressCollectionViaVendorAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressCollectionViaVendorAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_addressCollectionViaVendorAddress.GetMulti(filter, GetRelationsForField("AddressCollectionViaVendorAddress"));
				_addressCollectionViaVendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressCollectionViaVendorAddress = true;
			}
			return _addressCollectionViaVendorAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressCollectionViaVendorAddress'. These settings will be taken into account
		/// when the property AddressCollectionViaVendorAddress is requested or GetMultiAddressCollectionViaVendorAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressCollectionViaVendorAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressCollectionViaVendorAddress.SortClauses=sortClauses;
			_addressCollectionViaVendorAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaCustomerAddres(bool forceFetch)
		{
			return GetMultiAddressCollectionViaCustomerAddres(forceFetch, _addressCollectionViaCustomerAddres.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaCustomerAddres(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressCollectionViaCustomerAddres || forceFetch || _alwaysFetchAddressCollectionViaCustomerAddres) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressCollectionViaCustomerAddres.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressCollectionViaCustomerAddres);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressTypeFields.AddressTypeID, ComparisonOperator.Equal, this.AddressTypeID, "AddressTypeEntity__"));
				_addressCollectionViaCustomerAddres.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressCollectionViaCustomerAddres.EntityFactoryToUse = entityFactoryToUse;
				}
				_addressCollectionViaCustomerAddres.GetMulti(filter, GetRelationsForField("AddressCollectionViaCustomerAddres"));
				_addressCollectionViaCustomerAddres.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressCollectionViaCustomerAddres = true;
			}
			return _addressCollectionViaCustomerAddres;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressCollectionViaCustomerAddres'. These settings will be taken into account
		/// when the property AddressCollectionViaCustomerAddres is requested or GetMultiAddressCollectionViaCustomerAddres is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressCollectionViaCustomerAddres(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressCollectionViaCustomerAddres.SortClauses=sortClauses;
			_addressCollectionViaCustomerAddres.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaCustomerAddres(bool forceFetch)
		{
			return GetMultiCustomerCollectionViaCustomerAddres(forceFetch, _customerCollectionViaCustomerAddres.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaCustomerAddres(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerCollectionViaCustomerAddres || forceFetch || _alwaysFetchCustomerCollectionViaCustomerAddres) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerCollectionViaCustomerAddres.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerCollectionViaCustomerAddres);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressTypeFields.AddressTypeID, ComparisonOperator.Equal, this.AddressTypeID, "AddressTypeEntity__"));
				_customerCollectionViaCustomerAddres.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerCollectionViaCustomerAddres.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerCollectionViaCustomerAddres.GetMulti(filter, GetRelationsForField("CustomerCollectionViaCustomerAddres"));
				_customerCollectionViaCustomerAddres.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerCollectionViaCustomerAddres = true;
			}
			return _customerCollectionViaCustomerAddres;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerCollectionViaCustomerAddres'. These settings will be taken into account
		/// when the property CustomerCollectionViaCustomerAddres is requested or GetMultiCustomerCollectionViaCustomerAddres is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerCollectionViaCustomerAddres(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerCollectionViaCustomerAddres.SortClauses=sortClauses;
			_customerCollectionViaCustomerAddres.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorEntity'</returns>
		public AW.Data.CollectionClasses.VendorCollection GetMultiVendorCollectionViaVendorAddress(bool forceFetch)
		{
			return GetMultiVendorCollectionViaVendorAddress(forceFetch, _vendorCollectionViaVendorAddress.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.VendorCollection GetMultiVendorCollectionViaVendorAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedVendorCollectionViaVendorAddress || forceFetch || _alwaysFetchVendorCollectionViaVendorAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorCollectionViaVendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorCollectionViaVendorAddress);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AddressTypeFields.AddressTypeID, ComparisonOperator.Equal, this.AddressTypeID, "AddressTypeEntity__"));
				_vendorCollectionViaVendorAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_vendorCollectionViaVendorAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_vendorCollectionViaVendorAddress.GetMulti(filter, GetRelationsForField("VendorCollectionViaVendorAddress"));
				_vendorCollectionViaVendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorCollectionViaVendorAddress = true;
			}
			return _vendorCollectionViaVendorAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'VendorCollectionViaVendorAddress'. These settings will be taken into account
		/// when the property VendorCollectionViaVendorAddress is requested or GetMultiVendorCollectionViaVendorAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorCollectionViaVendorAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorCollectionViaVendorAddress.SortClauses=sortClauses;
			_vendorCollectionViaVendorAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			AddressTypeDAO dao = (AddressTypeDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_customerAddresses.ActiveContext = base.ActiveContext;
			_vendorAddress.ActiveContext = base.ActiveContext;
			_addressCollectionViaVendorAddress.ActiveContext = base.ActiveContext;
			_addressCollectionViaCustomerAddres.ActiveContext = base.ActiveContext;
			_customerCollectionViaCustomerAddres.ActiveContext = base.ActiveContext;
			_vendorCollectionViaVendorAddress.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			AddressTypeDAO dao = (AddressTypeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			AddressTypeDAO dao = (AddressTypeDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.AddressTypeEntity);
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

			toReturn.Add("CustomerAddresses", _customerAddresses);
			toReturn.Add("VendorAddress", _vendorAddress);
			toReturn.Add("AddressCollectionViaVendorAddress", _addressCollectionViaVendorAddress);
			toReturn.Add("AddressCollectionViaCustomerAddres", _addressCollectionViaCustomerAddres);
			toReturn.Add("CustomerCollectionViaCustomerAddres", _customerCollectionViaCustomerAddres);
			toReturn.Add("VendorCollectionViaVendorAddress", _vendorCollectionViaVendorAddress);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <param name="validator">The validator object for this AddressTypeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 addressTypeID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(addressTypeID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_customerAddresses = new AW.Data.CollectionClasses.CustomerAddressCollection(new CustomerAddressEntityFactory());
			_customerAddresses.SetContainingEntityInfo(this, "AddressType");
			_alwaysFetchCustomerAddresses = false;
			_alreadyFetchedCustomerAddresses = false;
			_vendorAddress = new AW.Data.CollectionClasses.VendorAddressCollection(new VendorAddressEntityFactory());
			_vendorAddress.SetContainingEntityInfo(this, "AddressType");
			_alwaysFetchVendorAddress = false;
			_alreadyFetchedVendorAddress = false;
			_addressCollectionViaVendorAddress = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaVendorAddress = false;
			_alreadyFetchedAddressCollectionViaVendorAddress = false;
			_addressCollectionViaCustomerAddres = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaCustomerAddres = false;
			_alreadyFetchedAddressCollectionViaCustomerAddres = false;
			_customerCollectionViaCustomerAddres = new AW.Data.CollectionClasses.CustomerCollection(new CustomerEntityFactory());
			_alwaysFetchCustomerCollectionViaCustomerAddres = false;
			_alreadyFetchedCustomerCollectionViaCustomerAddres = false;
			_vendorCollectionViaVendorAddress = new AW.Data.CollectionClasses.VendorCollection(new VendorEntityFactory());
			_alwaysFetchVendorCollectionViaVendorAddress = false;
			_alreadyFetchedVendorCollectionViaVendorAddress = false;



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
			_customProperties.Add("MS_Description", @"Types of addresses stored in the Address table. ");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("AddressTypeID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Address type description. For example, Billing, Home, or Shipping.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 addressTypeID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)AddressTypeFieldIndex.AddressTypeID].ForcedCurrentValueWrite(addressTypeID);
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
			return DAOFactory.CreateAddressTypeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AddressTypeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AddressTypeRelations Relations
		{
			get	{ return new AddressTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerAddress' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerAddresses
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerAddressCollection(),
					(IEntityRelation)GetRelationsForField("CustomerAddresses")[0], (int)AW.Data.EntityType.AddressTypeEntity, (int)AW.Data.EntityType.CustomerAddressEntity, 0, null, null, null, "CustomerAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VendorAddress' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorAddress
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorAddressCollection(),
					(IEntityRelation)GetRelationsForField("VendorAddress")[0], (int)AW.Data.EntityType.AddressTypeEntity, (int)AW.Data.EntityType.VendorAddressEntity, 0, null, null, null, "VendorAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaVendorAddress
		{
			get
			{
				IEntityRelation intermediateRelation = AddressTypeEntity.Relations.VendorAddressEntityUsingAddressTypeID;
				intermediateRelation.SetAliases(string.Empty, "VendorAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressTypeEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaVendorAddress"), "AddressCollectionViaVendorAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaCustomerAddres
		{
			get
			{
				IEntityRelation intermediateRelation = AddressTypeEntity.Relations.CustomerAddressEntityUsingAddressTypeID;
				intermediateRelation.SetAliases(string.Empty, "CustomerAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressTypeEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaCustomerAddres"), "AddressCollectionViaCustomerAddres", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaCustomerAddres
		{
			get
			{
				IEntityRelation intermediateRelation = AddressTypeEntity.Relations.CustomerAddressEntityUsingAddressTypeID;
				intermediateRelation.SetAliases(string.Empty, "CustomerAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressTypeEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaCustomerAddres"), "CustomerCollectionViaCustomerAddres", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Vendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVendorCollectionViaVendorAddress
		{
			get
			{
				IEntityRelation intermediateRelation = AddressTypeEntity.Relations.VendorAddressEntityUsingAddressTypeID;
				intermediateRelation.SetAliases(string.Empty, "VendorAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.VendorCollection(), intermediateRelation,
					(int)AW.Data.EntityType.AddressTypeEntity, (int)AW.Data.EntityType.VendorEntity, 0, null, null, GetRelationsForField("VendorCollectionViaVendorAddress"), "VendorCollectionViaVendorAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "AddressTypeEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return AddressTypeEntity.CustomProperties;}
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
			get { return AddressTypeEntity.FieldsCustomProperties;}
		}

		/// <summary> The AddressTypeID property of the Entity AddressType<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "AddressType"."AddressTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AddressTypeID
		{
			get { return (System.Int32)GetValue((int)AddressTypeFieldIndex.AddressTypeID, true); }
			set	{ SetValue((int)AddressTypeFieldIndex.AddressTypeID, value, true); }
		}
		/// <summary> The Name property of the Entity AddressType<br/><br/>
		/// 
		/// MS_Description: Address type description. For example, Billing, Home, or Shipping.<br/></summary>
		/// <remarks>Mapped on  table field: "AddressType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)AddressTypeFieldIndex.Name, true); }
			set	{ SetValue((int)AddressTypeFieldIndex.Name, value, true); }
		}
		/// <summary> The Rowguid property of the Entity AddressType<br/><br/>
		/// 
		/// MS_Description: Unique nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "AddressType"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)AddressTypeFieldIndex.Rowguid, true); }
			set	{ SetValue((int)AddressTypeFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity AddressType<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "AddressType"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)AddressTypeFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)AddressTypeFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerAddresses()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerAddressCollection CustomerAddresses
		{
			get	{ return GetMultiCustomerAddresses(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerAddresses. When set to true, CustomerAddresses is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerAddresses is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerAddresses(true).</summary>
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
		/// <summary> Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorAddressCollection VendorAddress
		{
			get	{ return GetMultiVendorAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorAddress. When set to true, VendorAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorAddress
		{
			get	{ return _alwaysFetchVendorAddress; }
			set	{ _alwaysFetchVendorAddress = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorAddress already has been fetched. Setting this property to false when VendorAddress has been fetched
		/// will clear the VendorAddress collection well. Setting this property to true while VendorAddress hasn't been fetched disables lazy loading for VendorAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorAddress
		{
			get { return _alreadyFetchedVendorAddress;}
			set 
			{
				if(_alreadyFetchedVendorAddress && !value && (_vendorAddress != null))
				{
					_vendorAddress.Clear();
				}
				_alreadyFetchedVendorAddress = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressCollectionViaVendorAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressCollection AddressCollectionViaVendorAddress
		{
			get { return GetMultiAddressCollectionViaVendorAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressCollectionViaVendorAddress. When set to true, AddressCollectionViaVendorAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressCollectionViaVendorAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressCollectionViaVendorAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressCollectionViaVendorAddress
		{
			get	{ return _alwaysFetchAddressCollectionViaVendorAddress; }
			set	{ _alwaysFetchAddressCollectionViaVendorAddress = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressCollectionViaVendorAddress already has been fetched. Setting this property to false when AddressCollectionViaVendorAddress has been fetched
		/// will clear the AddressCollectionViaVendorAddress collection well. Setting this property to true while AddressCollectionViaVendorAddress hasn't been fetched disables lazy loading for AddressCollectionViaVendorAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressCollectionViaVendorAddress
		{
			get { return _alreadyFetchedAddressCollectionViaVendorAddress;}
			set 
			{
				if(_alreadyFetchedAddressCollectionViaVendorAddress && !value && (_addressCollectionViaVendorAddress != null))
				{
					_addressCollectionViaVendorAddress.Clear();
				}
				_alreadyFetchedAddressCollectionViaVendorAddress = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressCollectionViaCustomerAddres()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressCollection AddressCollectionViaCustomerAddres
		{
			get { return GetMultiAddressCollectionViaCustomerAddres(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressCollectionViaCustomerAddres. When set to true, AddressCollectionViaCustomerAddres is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressCollectionViaCustomerAddres is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressCollectionViaCustomerAddres(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressCollectionViaCustomerAddres
		{
			get	{ return _alwaysFetchAddressCollectionViaCustomerAddres; }
			set	{ _alwaysFetchAddressCollectionViaCustomerAddres = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressCollectionViaCustomerAddres already has been fetched. Setting this property to false when AddressCollectionViaCustomerAddres has been fetched
		/// will clear the AddressCollectionViaCustomerAddres collection well. Setting this property to true while AddressCollectionViaCustomerAddres hasn't been fetched disables lazy loading for AddressCollectionViaCustomerAddres</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressCollectionViaCustomerAddres
		{
			get { return _alreadyFetchedAddressCollectionViaCustomerAddres;}
			set 
			{
				if(_alreadyFetchedAddressCollectionViaCustomerAddres && !value && (_addressCollectionViaCustomerAddres != null))
				{
					_addressCollectionViaCustomerAddres.Clear();
				}
				_alreadyFetchedAddressCollectionViaCustomerAddres = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerCollectionViaCustomerAddres()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerCollection CustomerCollectionViaCustomerAddres
		{
			get { return GetMultiCustomerCollectionViaCustomerAddres(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerCollectionViaCustomerAddres. When set to true, CustomerCollectionViaCustomerAddres is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerCollectionViaCustomerAddres is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerCollectionViaCustomerAddres(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerCollectionViaCustomerAddres
		{
			get	{ return _alwaysFetchCustomerCollectionViaCustomerAddres; }
			set	{ _alwaysFetchCustomerCollectionViaCustomerAddres = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerCollectionViaCustomerAddres already has been fetched. Setting this property to false when CustomerCollectionViaCustomerAddres has been fetched
		/// will clear the CustomerCollectionViaCustomerAddres collection well. Setting this property to true while CustomerCollectionViaCustomerAddres hasn't been fetched disables lazy loading for CustomerCollectionViaCustomerAddres</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerCollectionViaCustomerAddres
		{
			get { return _alreadyFetchedCustomerCollectionViaCustomerAddres;}
			set 
			{
				if(_alreadyFetchedCustomerCollectionViaCustomerAddres && !value && (_customerCollectionViaCustomerAddres != null))
				{
					_customerCollectionViaCustomerAddres.Clear();
				}
				_alreadyFetchedCustomerCollectionViaCustomerAddres = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorCollectionViaVendorAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.VendorCollection VendorCollectionViaVendorAddress
		{
			get { return GetMultiVendorCollectionViaVendorAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VendorCollectionViaVendorAddress. When set to true, VendorCollectionViaVendorAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorCollectionViaVendorAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorCollectionViaVendorAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorCollectionViaVendorAddress
		{
			get	{ return _alwaysFetchVendorCollectionViaVendorAddress; }
			set	{ _alwaysFetchVendorCollectionViaVendorAddress = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property VendorCollectionViaVendorAddress already has been fetched. Setting this property to false when VendorCollectionViaVendorAddress has been fetched
		/// will clear the VendorCollectionViaVendorAddress collection well. Setting this property to true while VendorCollectionViaVendorAddress hasn't been fetched disables lazy loading for VendorCollectionViaVendorAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVendorCollectionViaVendorAddress
		{
			get { return _alreadyFetchedVendorCollectionViaVendorAddress;}
			set 
			{
				if(_alreadyFetchedVendorCollectionViaVendorAddress && !value && (_vendorCollectionViaVendorAddress != null))
				{
					_vendorCollectionViaVendorAddress.Clear();
				}
				_alreadyFetchedVendorCollectionViaVendorAddress = value;
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
			get { return (int)AW.Data.EntityType.AddressTypeEntity; }
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
