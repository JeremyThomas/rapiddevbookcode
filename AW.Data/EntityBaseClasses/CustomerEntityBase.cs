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
	/// <summary>Entity base class which represents the base class for the entity 'Customer'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract partial class CustomerEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.CustomerAddressCollection	_customerAddress;
		private bool	_alwaysFetchCustomerAddress, _alreadyFetchedCustomerAddress;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchAddressCollectionViaSalesOrderHeader, _alreadyFetchedAddressCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchAddressCollectionViaSalesOrderHeader_, _alreadyFetchedAddressCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaCustomerAddress;
		private bool	_alwaysFetchAddressCollectionViaCustomerAddress, _alreadyFetchedAddressCollectionViaCustomerAddress;
		private AW.Data.CollectionClasses.AddressTypeCollection _addressTypeCollectionViaCustomerAddress;
		private bool	_alwaysFetchAddressTypeCollectionViaCustomerAddress, _alreadyFetchedAddressTypeCollectionViaCustomerAddress;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchContactCollectionViaSalesOrderHeader, _alreadyFetchedContactCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerViewRelatedCollection _customerViewRelatedCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_, _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.ShipMethodCollection _shipMethodCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchShipMethodCollectionViaSalesOrderHeader, _alreadyFetchedShipMethodCollectionViaSalesOrderHeader;

		private IndividualEntity _individual;
		private bool	_alwaysFetchIndividual, _alreadyFetchedIndividual, _individualReturnsNewIfNotFound;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name CustomerAddress</summary>
			public static readonly string CustomerAddress = "CustomerAddress";
			/// <summary>Member name SalesOrderHeader</summary>
			public static readonly string SalesOrderHeader = "SalesOrderHeader";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader = "AddressCollectionViaSalesOrderHeader";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader_</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader_ = "AddressCollectionViaSalesOrderHeader_";
			/// <summary>Member name AddressCollectionViaCustomerAddress</summary>
			public static readonly string AddressCollectionViaCustomerAddress = "AddressCollectionViaCustomerAddress";
			/// <summary>Member name AddressTypeCollectionViaCustomerAddress</summary>
			public static readonly string AddressTypeCollectionViaCustomerAddress = "AddressTypeCollectionViaCustomerAddress";
			/// <summary>Member name ContactCollectionViaSalesOrderHeader</summary>
			public static readonly string ContactCollectionViaSalesOrderHeader = "ContactCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerViewRelatedCollectionViaSalesOrderHeader_</summary>
			public static readonly string CustomerViewRelatedCollectionViaSalesOrderHeader_ = "CustomerViewRelatedCollectionViaSalesOrderHeader_";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader = "ShipMethodCollectionViaSalesOrderHeader";
			/// <summary>Member name Individual</summary>
			public static readonly string Individual = "Individual";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CustomerEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CustomerEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		public CustomerEntityBase(System.Int32 customerId)
		{
			InitClassFetch(customerId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CustomerEntityBase(System.Int32 customerId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(customerId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="validator">The custom validator object for this CustomerEntity</param>
		public CustomerEntityBase(System.Int32 customerId, IValidator validator)
		{
			InitClassFetch(customerId, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CustomerEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_customerAddress = (AW.Data.CollectionClasses.CustomerAddressCollection)info.GetValue("_customerAddress", typeof(AW.Data.CollectionClasses.CustomerAddressCollection));
			_alwaysFetchCustomerAddress = info.GetBoolean("_alwaysFetchCustomerAddress");
			_alreadyFetchedCustomerAddress = info.GetBoolean("_alreadyFetchedCustomerAddress");
			_salesOrderHeader = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeader", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");
			_addressCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchAddressCollectionViaSalesOrderHeader");
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedAddressCollectionViaSalesOrderHeader");
			_addressCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchAddressCollectionViaSalesOrderHeader_");
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedAddressCollectionViaSalesOrderHeader_");
			_addressCollectionViaCustomerAddress = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaCustomerAddress", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaCustomerAddress = info.GetBoolean("_alwaysFetchAddressCollectionViaCustomerAddress");
			_alreadyFetchedAddressCollectionViaCustomerAddress = info.GetBoolean("_alreadyFetchedAddressCollectionViaCustomerAddress");
			_addressTypeCollectionViaCustomerAddress = (AW.Data.CollectionClasses.AddressTypeCollection)info.GetValue("_addressTypeCollectionViaCustomerAddress", typeof(AW.Data.CollectionClasses.AddressTypeCollection));
			_alwaysFetchAddressTypeCollectionViaCustomerAddress = info.GetBoolean("_alwaysFetchAddressTypeCollectionViaCustomerAddress");
			_alreadyFetchedAddressTypeCollectionViaCustomerAddress = info.GetBoolean("_alreadyFetchedAddressTypeCollectionViaCustomerAddress");
			_contactCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchContactCollectionViaSalesOrderHeader");
			_alreadyFetchedContactCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedContactCollectionViaSalesOrderHeader");
			_customerViewRelatedCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.CustomerViewRelatedCollection)info.GetValue("_customerViewRelatedCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.CustomerViewRelatedCollection));
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_");
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_");
			_shipMethodCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.ShipMethodCollection)info.GetValue("_shipMethodCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.ShipMethodCollection));
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchShipMethodCollectionViaSalesOrderHeader");
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader");

			_individual = (IndividualEntity)info.GetValue("_individual", typeof(IndividualEntity));
			if(_individual!=null)
			{
				_individual.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_individualReturnsNewIfNotFound = info.GetBoolean("_individualReturnsNewIfNotFound");
			_alwaysFetchIndividual = info.GetBoolean("_alwaysFetchIndividual");
			_alreadyFetchedIndividual = info.GetBoolean("_alreadyFetchedIndividual");
			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CustomerFieldIndex)fieldIndex)
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
			_alreadyFetchedCustomerAddress = (_customerAddress.Count > 0);
			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader.Count > 0);
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = (_addressCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = (_addressCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedAddressCollectionViaCustomerAddress = (_addressCollectionViaCustomerAddress.Count > 0);
			_alreadyFetchedAddressTypeCollectionViaCustomerAddress = (_addressTypeCollectionViaCustomerAddress.Count > 0);
			_alreadyFetchedContactCollectionViaSalesOrderHeader = (_contactCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ = (_customerViewRelatedCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = (_shipMethodCollectionViaSalesOrderHeader.Count > 0);

			_alreadyFetchedIndividual = (_individual != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return CustomerEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "CustomerAddress":
					toReturn.Add(CustomerEntity.Relations.CustomerAddressEntityUsingCustomerId);
					break;
				case "SalesOrderHeader":
					toReturn.Add(CustomerEntity.Relations.SalesOrderHeaderEntityUsingCustomerId);
					break;
				case "AddressCollectionViaSalesOrderHeader":
					toReturn.Add(CustomerEntity.Relations.SalesOrderHeaderEntityUsingCustomerId, "CustomerEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaSalesOrderHeader_":
					toReturn.Add(CustomerEntity.Relations.SalesOrderHeaderEntityUsingCustomerId, "CustomerEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaCustomerAddress":
					toReturn.Add(CustomerEntity.Relations.CustomerAddressEntityUsingCustomerId, "CustomerEntity__", "CustomerAddress_", JoinHint.None);
					toReturn.Add(CustomerAddressEntity.Relations.AddressEntityUsingAddressId, "CustomerAddress_", string.Empty, JoinHint.None);
					break;
				case "AddressTypeCollectionViaCustomerAddress":
					toReturn.Add(CustomerEntity.Relations.CustomerAddressEntityUsingCustomerId, "CustomerEntity__", "CustomerAddress_", JoinHint.None);
					toReturn.Add(CustomerAddressEntity.Relations.AddressTypeEntityUsingAddressTypeId, "CustomerAddress_", string.Empty, JoinHint.None);
					break;
				case "ContactCollectionViaSalesOrderHeader":
					toReturn.Add(CustomerEntity.Relations.SalesOrderHeaderEntityUsingCustomerId, "CustomerEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ContactEntityUsingContactId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader_":
					toReturn.Add(CustomerEntity.Relations.SalesOrderHeaderEntityUsingCustomerId, "CustomerEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					toReturn.Add(CustomerEntity.Relations.SalesOrderHeaderEntityUsingCustomerId, "CustomerEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "Individual":
					toReturn.Add(CustomerEntity.Relations.IndividualEntityUsingCustomerId);
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
			info.AddValue("_customerAddress", (!this.MarkedForDeletion?_customerAddress:null));
			info.AddValue("_alwaysFetchCustomerAddress", _alwaysFetchCustomerAddress);
			info.AddValue("_alreadyFetchedCustomerAddress", _alreadyFetchedCustomerAddress);
			info.AddValue("_salesOrderHeader", (!this.MarkedForDeletion?_salesOrderHeader:null));
			info.AddValue("_alwaysFetchSalesOrderHeader", _alwaysFetchSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesOrderHeader", _alreadyFetchedSalesOrderHeader);
			info.AddValue("_addressCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_addressCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchAddressCollectionViaSalesOrderHeader", _alwaysFetchAddressCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedAddressCollectionViaSalesOrderHeader", _alreadyFetchedAddressCollectionViaSalesOrderHeader);
			info.AddValue("_addressCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_addressCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchAddressCollectionViaSalesOrderHeader_", _alwaysFetchAddressCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedAddressCollectionViaSalesOrderHeader_", _alreadyFetchedAddressCollectionViaSalesOrderHeader_);
			info.AddValue("_addressCollectionViaCustomerAddress", (!this.MarkedForDeletion?_addressCollectionViaCustomerAddress:null));
			info.AddValue("_alwaysFetchAddressCollectionViaCustomerAddress", _alwaysFetchAddressCollectionViaCustomerAddress);
			info.AddValue("_alreadyFetchedAddressCollectionViaCustomerAddress", _alreadyFetchedAddressCollectionViaCustomerAddress);
			info.AddValue("_addressTypeCollectionViaCustomerAddress", (!this.MarkedForDeletion?_addressTypeCollectionViaCustomerAddress:null));
			info.AddValue("_alwaysFetchAddressTypeCollectionViaCustomerAddress", _alwaysFetchAddressTypeCollectionViaCustomerAddress);
			info.AddValue("_alreadyFetchedAddressTypeCollectionViaCustomerAddress", _alreadyFetchedAddressTypeCollectionViaCustomerAddress);
			info.AddValue("_contactCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_contactCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchContactCollectionViaSalesOrderHeader", _alwaysFetchContactCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedContactCollectionViaSalesOrderHeader", _alreadyFetchedContactCollectionViaSalesOrderHeader);
			info.AddValue("_customerViewRelatedCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_customerViewRelatedCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_", _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_", _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_);
			info.AddValue("_shipMethodCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_shipMethodCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchShipMethodCollectionViaSalesOrderHeader", _alwaysFetchShipMethodCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader", _alreadyFetchedShipMethodCollectionViaSalesOrderHeader);

			info.AddValue("_individual", (!this.MarkedForDeletion?_individual:null));
			info.AddValue("_individualReturnsNewIfNotFound", _individualReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchIndividual", _alwaysFetchIndividual);
			info.AddValue("_alreadyFetchedIndividual", _alreadyFetchedIndividual);
			
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

				case "CustomerAddress":
					_alreadyFetchedCustomerAddress = true;
					if(entity!=null)
					{
						this.CustomerAddress.Add((CustomerAddressEntity)entity);
					}
					break;
				case "SalesOrderHeader":
					_alreadyFetchedSalesOrderHeader = true;
					if(entity!=null)
					{
						this.SalesOrderHeader.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "AddressCollectionViaSalesOrderHeader":
					_alreadyFetchedAddressCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.AddressCollectionViaSalesOrderHeader.Add((AddressEntity)entity);
					}
					break;
				case "AddressCollectionViaSalesOrderHeader_":
					_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.AddressCollectionViaSalesOrderHeader_.Add((AddressEntity)entity);
					}
					break;
				case "AddressCollectionViaCustomerAddress":
					_alreadyFetchedAddressCollectionViaCustomerAddress = true;
					if(entity!=null)
					{
						this.AddressCollectionViaCustomerAddress.Add((AddressEntity)entity);
					}
					break;
				case "AddressTypeCollectionViaCustomerAddress":
					_alreadyFetchedAddressTypeCollectionViaCustomerAddress = true;
					if(entity!=null)
					{
						this.AddressTypeCollectionViaCustomerAddress.Add((AddressTypeEntity)entity);
					}
					break;
				case "ContactCollectionViaSalesOrderHeader":
					_alreadyFetchedContactCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.ContactCollectionViaSalesOrderHeader.Add((ContactEntity)entity);
					}
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader_":
					_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.CustomerViewRelatedCollectionViaSalesOrderHeader_.Add((CustomerViewRelatedEntity)entity);
					}
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.ShipMethodCollectionViaSalesOrderHeader.Add((ShipMethodEntity)entity);
					}
					break;
				case "Individual":
					_alreadyFetchedIndividual = true;
					this.Individual = (IndividualEntity)entity;
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

				case "CustomerAddress":
					_customerAddress.Add((CustomerAddressEntity)relatedEntity);
					break;
				case "SalesOrderHeader":
					_salesOrderHeader.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				case "Individual":
					SetupSyncIndividual(relatedEntity);
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

				case "CustomerAddress":
					base.PerformRelatedEntityRemoval(_customerAddress, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeader":
					base.PerformRelatedEntityRemoval(_salesOrderHeader, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Individual":
					DesetupSyncIndividual(false, true);
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
			if(_individual!=null)
			{
				toReturn.Add(_individual);
			}


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
			toReturn.Add(_customerAddress);
			toReturn.Add(_salesOrderHeader);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId)
		{
			return FetchUsingPK(customerId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(customerId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(customerId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(customerId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CustomerId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(CustomerFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(CustomerFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new CustomerRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerAddressEntity'</returns>
		public AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddress(bool forceFetch)
		{
			return GetMultiCustomerAddress(forceFetch, _customerAddress.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CustomerAddressEntity'</returns>
		public AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddress(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCustomerAddress(forceFetch, _customerAddress.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCustomerAddress(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.CustomerAddressCollection GetMultiCustomerAddress(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCustomerAddress || forceFetch || _alwaysFetchCustomerAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerAddress);
					}
				}
				_customerAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerAddress.GetMultiManyToOne(null, null, this, filter);
				_customerAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerAddress = true;
			}
			return _customerAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerAddress'. These settings will be taken into account
		/// when the property CustomerAddress is requested or GetMultiCustomerAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerAddress.SortClauses=sortClauses;
			_customerAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeader(bool forceFetch)
		{
			return GetMultiSalesOrderHeader(forceFetch, _salesOrderHeader.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeader(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderHeader(forceFetch, _salesOrderHeader.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderHeader(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection GetMultiSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeader || forceFetch || _alwaysFetchSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeader);
					}
				}
				_salesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesOrderHeader.GetMultiManyToOne(null, null, null, this, null, null, filter);
				_salesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeader = true;
			}
			return _salesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderHeader'. These settings will be taken into account
		/// when the property SalesOrderHeader is requested or GetMultiSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeader.SortClauses=sortClauses;
			_salesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiAddressCollectionViaSalesOrderHeader(forceFetch, _addressCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchAddressCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
				_addressCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_addressCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("AddressCollectionViaSalesOrderHeader"));
				_addressCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressCollectionViaSalesOrderHeader = true;
			}
			return _addressCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property AddressCollectionViaSalesOrderHeader is requested or GetMultiAddressCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_addressCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaSalesOrderHeader_(bool forceFetch)
		{
			return GetMultiAddressCollectionViaSalesOrderHeader_(forceFetch, _addressCollectionViaSalesOrderHeader_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchAddressCollectionViaSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressCollectionViaSalesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressCollectionViaSalesOrderHeader_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
				_addressCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				}
				_addressCollectionViaSalesOrderHeader_.GetMulti(filter, GetRelationsForField("AddressCollectionViaSalesOrderHeader_"));
				_addressCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = true;
			}
			return _addressCollectionViaSalesOrderHeader_;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressCollectionViaSalesOrderHeader_'. These settings will be taken into account
		/// when the property AddressCollectionViaSalesOrderHeader_ is requested or GetMultiAddressCollectionViaSalesOrderHeader_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressCollectionViaSalesOrderHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressCollectionViaSalesOrderHeader_.SortClauses=sortClauses;
			_addressCollectionViaSalesOrderHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaCustomerAddress(bool forceFetch)
		{
			return GetMultiAddressCollectionViaCustomerAddress(forceFetch, _addressCollectionViaCustomerAddress.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressCollection GetMultiAddressCollectionViaCustomerAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressCollectionViaCustomerAddress || forceFetch || _alwaysFetchAddressCollectionViaCustomerAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressCollectionViaCustomerAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressCollectionViaCustomerAddress);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
				_addressCollectionViaCustomerAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressCollectionViaCustomerAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_addressCollectionViaCustomerAddress.GetMulti(filter, GetRelationsForField("AddressCollectionViaCustomerAddress"));
				_addressCollectionViaCustomerAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressCollectionViaCustomerAddress = true;
			}
			return _addressCollectionViaCustomerAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressCollectionViaCustomerAddress'. These settings will be taken into account
		/// when the property AddressCollectionViaCustomerAddress is requested or GetMultiAddressCollectionViaCustomerAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressCollectionViaCustomerAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressCollectionViaCustomerAddress.SortClauses=sortClauses;
			_addressCollectionViaCustomerAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressTypeEntity'</returns>
		public AW.Data.CollectionClasses.AddressTypeCollection GetMultiAddressTypeCollectionViaCustomerAddress(bool forceFetch)
		{
			return GetMultiAddressTypeCollectionViaCustomerAddress(forceFetch, _addressTypeCollectionViaCustomerAddress.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.AddressTypeCollection GetMultiAddressTypeCollectionViaCustomerAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressTypeCollectionViaCustomerAddress || forceFetch || _alwaysFetchAddressTypeCollectionViaCustomerAddress) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_addressTypeCollectionViaCustomerAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressTypeCollectionViaCustomerAddress);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
				_addressTypeCollectionViaCustomerAddress.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_addressTypeCollectionViaCustomerAddress.EntityFactoryToUse = entityFactoryToUse;
				}
				_addressTypeCollectionViaCustomerAddress.GetMulti(filter, GetRelationsForField("AddressTypeCollectionViaCustomerAddress"));
				_addressTypeCollectionViaCustomerAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressTypeCollectionViaCustomerAddress = true;
			}
			return _addressTypeCollectionViaCustomerAddress;
		}

		/// <summary> Sets the collection parameters for the collection for 'AddressTypeCollectionViaCustomerAddress'. These settings will be taken into account
		/// when the property AddressTypeCollectionViaCustomerAddress is requested or GetMultiAddressTypeCollectionViaCustomerAddress is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressTypeCollectionViaCustomerAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressTypeCollectionViaCustomerAddress.SortClauses=sortClauses;
			_addressTypeCollectionViaCustomerAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactEntity'</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiContactCollectionViaSalesOrderHeader(forceFetch, _contactCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchContactCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
				_contactCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_contactCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_contactCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("ContactCollectionViaSalesOrderHeader"));
				_contactCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCollectionViaSalesOrderHeader = true;
			}
			return _contactCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property ContactCollectionViaSalesOrderHeader is requested or GetMultiContactCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_contactCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerViewRelatedEntity'</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_(bool forceFetch)
		{
			return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_(forceFetch, _customerViewRelatedCollectionViaSalesOrderHeader_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ || forceFetch || _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerViewRelatedCollectionViaSalesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerViewRelatedCollectionViaSalesOrderHeader_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
				_customerViewRelatedCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerViewRelatedCollectionViaSalesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerViewRelatedCollectionViaSalesOrderHeader_.GetMulti(filter, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader_"));
				_customerViewRelatedCollectionViaSalesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ = true;
			}
			return _customerViewRelatedCollectionViaSalesOrderHeader_;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerViewRelatedCollectionViaSalesOrderHeader_'. These settings will be taken into account
		/// when the property CustomerViewRelatedCollectionViaSalesOrderHeader_ is requested or GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerViewRelatedCollectionViaSalesOrderHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerViewRelatedCollectionViaSalesOrderHeader_.SortClauses=sortClauses;
			_customerViewRelatedCollectionViaSalesOrderHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShipMethodEntity'</returns>
		public AW.Data.CollectionClasses.ShipMethodCollection GetMultiShipMethodCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiShipMethodCollectionViaSalesOrderHeader(forceFetch, _shipMethodCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ShipMethodCollection GetMultiShipMethodCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShipMethodCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchShipMethodCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_shipMethodCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shipMethodCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
				_shipMethodCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_shipMethodCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_shipMethodCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"));
				_shipMethodCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = true;
			}
			return _shipMethodCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'ShipMethodCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property ShipMethodCollectionViaSalesOrderHeader is requested or GetMultiShipMethodCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShipMethodCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shipMethodCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_shipMethodCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary> Retrieves the related entity of type 'IndividualEntity', using a relation of type '1:1'</summary>
		/// <returns>A fetched entity of type 'IndividualEntity' which is related to this entity.</returns>
		public IndividualEntity GetSingleIndividual()
		{
			return GetSingleIndividual(false);
		}
		
		/// <summary> Retrieves the related entity of type 'IndividualEntity', using a relation of type '1:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'IndividualEntity' which is related to this entity.</returns>
		public virtual IndividualEntity GetSingleIndividual(bool forceFetch)
		{
			if( ( !_alreadyFetchedIndividual || forceFetch || _alwaysFetchIndividual) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode )
			{
				IndividualEntity newEntity = new IndividualEntity();
				IEntityRelation relation = CustomerEntity.Relations.IndividualEntityUsingCustomerId;
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(relation))
				{
					fetchResult = newEntity.FetchUsingPK(this.CustomerId);
				}
				if(!_individualReturnsNewIfNotFound && !fetchResult)
				{
					this.Individual = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (IndividualEntity)base.ActiveContext.Get(newEntity);
					}
					this.Individual = newEntity;
					_alreadyFetchedIndividual = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _individual;
		}

		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			CustomerDAO dao = (CustomerDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_customerAddress.ActiveContext = base.ActiveContext;
			_salesOrderHeader.ActiveContext = base.ActiveContext;
			_addressCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_addressCollectionViaSalesOrderHeader_.ActiveContext = base.ActiveContext;
			_addressCollectionViaCustomerAddress.ActiveContext = base.ActiveContext;
			_addressTypeCollectionViaCustomerAddress.ActiveContext = base.ActiveContext;
			_contactCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_customerViewRelatedCollectionViaSalesOrderHeader_.ActiveContext = base.ActiveContext;
			_shipMethodCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;

			if(_individual!=null)
			{
				_individual.ActiveContext = base.ActiveContext;
			}

		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			CustomerDAO dao = (CustomerDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			CustomerDAO dao = (CustomerDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.CustomerEntity);
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

			toReturn.Add("CustomerAddress", _customerAddress);
			toReturn.Add("SalesOrderHeader", _salesOrderHeader);
			toReturn.Add("AddressCollectionViaSalesOrderHeader", _addressCollectionViaSalesOrderHeader);
			toReturn.Add("AddressCollectionViaSalesOrderHeader_", _addressCollectionViaSalesOrderHeader_);
			toReturn.Add("AddressCollectionViaCustomerAddress", _addressCollectionViaCustomerAddress);
			toReturn.Add("AddressTypeCollectionViaCustomerAddress", _addressTypeCollectionViaCustomerAddress);
			toReturn.Add("ContactCollectionViaSalesOrderHeader", _contactCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerViewRelatedCollectionViaSalesOrderHeader_", _customerViewRelatedCollectionViaSalesOrderHeader_);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader", _shipMethodCollectionViaSalesOrderHeader);
			toReturn.Add("Individual", _individual);
			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="validator">The validator object for this CustomerEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 customerId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(customerId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_customerAddress = new AW.Data.CollectionClasses.CustomerAddressCollection(new CustomerAddressEntityFactory());
			_customerAddress.SetContainingEntityInfo(this, "Customer");
			_alwaysFetchCustomerAddress = false;
			_alreadyFetchedCustomerAddress = false;
			_salesOrderHeader = new AW.Data.CollectionClasses.SalesOrderHeaderCollection(new SalesOrderHeaderEntityFactory());
			_salesOrderHeader.SetContainingEntityInfo(this, "Customer");
			_alwaysFetchSalesOrderHeader = false;
			_alreadyFetchedSalesOrderHeader = false;
			_addressCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaSalesOrderHeader = false;
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = false;
			_addressCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaSalesOrderHeader_ = false;
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = false;
			_addressCollectionViaCustomerAddress = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaCustomerAddress = false;
			_alreadyFetchedAddressCollectionViaCustomerAddress = false;
			_addressTypeCollectionViaCustomerAddress = new AW.Data.CollectionClasses.AddressTypeCollection(new AddressTypeEntityFactory());
			_alwaysFetchAddressTypeCollectionViaCustomerAddress = false;
			_alreadyFetchedAddressTypeCollectionViaCustomerAddress = false;
			_contactCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.ContactCollection(new ContactEntityFactory());
			_alwaysFetchContactCollectionViaSalesOrderHeader = false;
			_alreadyFetchedContactCollectionViaSalesOrderHeader = false;
			_customerViewRelatedCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.CustomerViewRelatedCollection(new CustomerViewRelatedEntityFactory());
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_ = false;
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ = false;
			_shipMethodCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.ShipMethodCollection(new ShipMethodEntityFactory());
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader = false;
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = false;

			_individual = null;
			_individualReturnsNewIfNotFound = true;
			_alwaysFetchIndividual = false;
			_alreadyFetchedIndividual = false;

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

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("TerritoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AccountNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CustomerType", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion



		/// <summary> Removes the sync logic for member _individual</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncIndividual(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _individual, new PropertyChangedEventHandler( OnIndividualPropertyChanged ), "Individual", CustomerEntity.Relations.IndividualEntityUsingCustomerId, false, signalRelatedEntity, "Customer", false, new int[] { (int)CustomerFieldIndex.CustomerId } );
			_individual = null;
		}
	
		/// <summary> setups the sync logic for member _individual</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncIndividual(IEntity relatedEntity)
		{
			if(_individual!=relatedEntity)
			{
				DesetupSyncIndividual(true, true);
				_individual = (IndividualEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _individual, new PropertyChangedEventHandler( OnIndividualPropertyChanged ), "Individual", CustomerEntity.Relations.IndividualEntityUsingCustomerId, false, ref _alreadyFetchedIndividual, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnIndividualPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 customerId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)CustomerFieldIndex.CustomerId].ForcedCurrentValueWrite(customerId);
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
			return DAOFactory.CreateCustomerDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CustomerEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CustomerRelations Relations
		{
			get	{ return new CustomerRelations(); }
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
		public static IPrefetchPathElement PrefetchPathCustomerAddress
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerAddressCollection(),
					(IEntityRelation)GetRelationsForField("CustomerAddress")[0], (int)AW.Data.EntityType.CustomerEntity, (int)AW.Data.EntityType.CustomerAddressEntity, 0, null, null, null, "CustomerAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeader
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(),
					(IEntityRelation)GetRelationsForField("SalesOrderHeader")[0], (int)AW.Data.EntityType.CustomerEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = CustomerEntity.Relations.SalesOrderHeaderEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CustomerEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader"), "AddressCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = CustomerEntity.Relations.SalesOrderHeaderEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CustomerEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader_"), "AddressCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaCustomerAddress
		{
			get
			{
				IEntityRelation intermediateRelation = CustomerEntity.Relations.CustomerAddressEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "CustomerAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CustomerEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaCustomerAddress"), "AddressCollectionViaCustomerAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AddressType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressTypeCollectionViaCustomerAddress
		{
			get
			{
				IEntityRelation intermediateRelation = CustomerEntity.Relations.CustomerAddressEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "CustomerAddress_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressTypeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CustomerEntity, (int)AW.Data.EntityType.AddressTypeEntity, 0, null, null, GetRelationsForField("AddressTypeCollectionViaCustomerAddress"), "AddressTypeCollectionViaCustomerAddress", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = CustomerEntity.Relations.SalesOrderHeaderEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CustomerEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaSalesOrderHeader"), "ContactCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerViewRelated' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerViewRelatedCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = CustomerEntity.Relations.SalesOrderHeaderEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerViewRelatedCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CustomerEntity, (int)AW.Data.EntityType.CustomerViewRelatedEntity, 0, null, null, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader_"), "CustomerViewRelatedCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethodCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = CustomerEntity.Relations.SalesOrderHeaderEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), intermediateRelation,
					(int)AW.Data.EntityType.CustomerEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"), "ShipMethodCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Individual' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathIndividual
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.IndividualCollection(),
					(IEntityRelation)GetRelationsForField("Individual")[0], (int)AW.Data.EntityType.CustomerEntity, (int)AW.Data.EntityType.IndividualEntity, 0, null, null, null, "Individual", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);
			}
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "CustomerEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomerEntity.CustomProperties;}
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
			get { return CustomerEntity.FieldsCustomProperties;}
		}

		/// <summary> The CustomerId property of the Entity Customer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Customer"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 CustomerId
		{
			get { return (System.Int32)GetValue((int)CustomerFieldIndex.CustomerId, true); }
			set	{ SetValue((int)CustomerFieldIndex.CustomerId, value, true); }
		}
		/// <summary> The TerritoryId property of the Entity Customer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Customer"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TerritoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)CustomerFieldIndex.TerritoryId, false); }
			set	{ SetValue((int)CustomerFieldIndex.TerritoryId, value, true); }
		}
		/// <summary> The AccountNumber property of the Entity Customer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Customer"."AccountNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AccountNumber
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.AccountNumber, true); }

		}
		/// <summary> The CustomerType property of the Entity Customer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Customer"."CustomerType"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 1<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CustomerType
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.CustomerType, true); }
			set	{ SetValue((int)CustomerFieldIndex.CustomerType, value, true); }
		}
		/// <summary> The Rowguid property of the Entity Customer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Customer"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)CustomerFieldIndex.Rowguid, true); }
			set	{ SetValue((int)CustomerFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Customer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Customer"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CustomerFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CustomerFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerAddressCollection CustomerAddress
		{
			get	{ return GetMultiCustomerAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerAddress. When set to true, CustomerAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerAddress
		{
			get	{ return _alwaysFetchCustomerAddress; }
			set	{ _alwaysFetchCustomerAddress = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerAddress already has been fetched. Setting this property to false when CustomerAddress has been fetched
		/// will clear the CustomerAddress collection well. Setting this property to true while CustomerAddress hasn't been fetched disables lazy loading for CustomerAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerAddress
		{
			get { return _alreadyFetchedCustomerAddress;}
			set 
			{
				if(_alreadyFetchedCustomerAddress && !value && (_customerAddress != null))
				{
					_customerAddress.Clear();
				}
				_alreadyFetchedCustomerAddress = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeader
		{
			get	{ return GetMultiSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeader. When set to true, SalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeader
		{
			get	{ return _alwaysFetchSalesOrderHeader; }
			set	{ _alwaysFetchSalesOrderHeader = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SalesOrderHeader already has been fetched. Setting this property to false when SalesOrderHeader has been fetched
		/// will clear the SalesOrderHeader collection well. Setting this property to true while SalesOrderHeader hasn't been fetched disables lazy loading for SalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSalesOrderHeader
		{
			get { return _alreadyFetchedSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedSalesOrderHeader && !value && (_salesOrderHeader != null))
				{
					_salesOrderHeader.Clear();
				}
				_alreadyFetchedSalesOrderHeader = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressCollection AddressCollectionViaSalesOrderHeader
		{
			get { return GetMultiAddressCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressCollectionViaSalesOrderHeader. When set to true, AddressCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchAddressCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchAddressCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when AddressCollectionViaSalesOrderHeader has been fetched
		/// will clear the AddressCollectionViaSalesOrderHeader collection well. Setting this property to true while AddressCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for AddressCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedAddressCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedAddressCollectionViaSalesOrderHeader && !value && (_addressCollectionViaSalesOrderHeader != null))
				{
					_addressCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedAddressCollectionViaSalesOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressCollection AddressCollectionViaSalesOrderHeader_
		{
			get { return GetMultiAddressCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressCollectionViaSalesOrderHeader_. When set to true, AddressCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressCollectionViaSalesOrderHeader_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressCollectionViaSalesOrderHeader_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressCollectionViaSalesOrderHeader_
		{
			get	{ return _alwaysFetchAddressCollectionViaSalesOrderHeader_; }
			set	{ _alwaysFetchAddressCollectionViaSalesOrderHeader_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressCollectionViaSalesOrderHeader_ already has been fetched. Setting this property to false when AddressCollectionViaSalesOrderHeader_ has been fetched
		/// will clear the AddressCollectionViaSalesOrderHeader_ collection well. Setting this property to true while AddressCollectionViaSalesOrderHeader_ hasn't been fetched disables lazy loading for AddressCollectionViaSalesOrderHeader_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressCollectionViaSalesOrderHeader_
		{
			get { return _alreadyFetchedAddressCollectionViaSalesOrderHeader_;}
			set 
			{
				if(_alreadyFetchedAddressCollectionViaSalesOrderHeader_ && !value && (_addressCollectionViaSalesOrderHeader_ != null))
				{
					_addressCollectionViaSalesOrderHeader_.Clear();
				}
				_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressCollectionViaCustomerAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressCollection AddressCollectionViaCustomerAddress
		{
			get { return GetMultiAddressCollectionViaCustomerAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressCollectionViaCustomerAddress. When set to true, AddressCollectionViaCustomerAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressCollectionViaCustomerAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressCollectionViaCustomerAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressCollectionViaCustomerAddress
		{
			get	{ return _alwaysFetchAddressCollectionViaCustomerAddress; }
			set	{ _alwaysFetchAddressCollectionViaCustomerAddress = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressCollectionViaCustomerAddress already has been fetched. Setting this property to false when AddressCollectionViaCustomerAddress has been fetched
		/// will clear the AddressCollectionViaCustomerAddress collection well. Setting this property to true while AddressCollectionViaCustomerAddress hasn't been fetched disables lazy loading for AddressCollectionViaCustomerAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressCollectionViaCustomerAddress
		{
			get { return _alreadyFetchedAddressCollectionViaCustomerAddress;}
			set 
			{
				if(_alreadyFetchedAddressCollectionViaCustomerAddress && !value && (_addressCollectionViaCustomerAddress != null))
				{
					_addressCollectionViaCustomerAddress.Clear();
				}
				_alreadyFetchedAddressCollectionViaCustomerAddress = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressTypeCollectionViaCustomerAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.AddressTypeCollection AddressTypeCollectionViaCustomerAddress
		{
			get { return GetMultiAddressTypeCollectionViaCustomerAddress(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AddressTypeCollectionViaCustomerAddress. When set to true, AddressTypeCollectionViaCustomerAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressTypeCollectionViaCustomerAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressTypeCollectionViaCustomerAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressTypeCollectionViaCustomerAddress
		{
			get	{ return _alwaysFetchAddressTypeCollectionViaCustomerAddress; }
			set	{ _alwaysFetchAddressTypeCollectionViaCustomerAddress = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AddressTypeCollectionViaCustomerAddress already has been fetched. Setting this property to false when AddressTypeCollectionViaCustomerAddress has been fetched
		/// will clear the AddressTypeCollectionViaCustomerAddress collection well. Setting this property to true while AddressTypeCollectionViaCustomerAddress hasn't been fetched disables lazy loading for AddressTypeCollectionViaCustomerAddress</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAddressTypeCollectionViaCustomerAddress
		{
			get { return _alreadyFetchedAddressTypeCollectionViaCustomerAddress;}
			set 
			{
				if(_alreadyFetchedAddressTypeCollectionViaCustomerAddress && !value && (_addressTypeCollectionViaCustomerAddress != null))
				{
					_addressTypeCollectionViaCustomerAddress.Clear();
				}
				_alreadyFetchedAddressTypeCollectionViaCustomerAddress = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection ContactCollectionViaSalesOrderHeader
		{
			get { return GetMultiContactCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCollectionViaSalesOrderHeader. When set to true, ContactCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchContactCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchContactCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when ContactCollectionViaSalesOrderHeader has been fetched
		/// will clear the ContactCollectionViaSalesOrderHeader collection well. Setting this property to true while ContactCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for ContactCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedContactCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedContactCollectionViaSalesOrderHeader && !value && (_contactCollectionViaSalesOrderHeader != null))
				{
					_contactCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedContactCollectionViaSalesOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerViewRelatedCollection CustomerViewRelatedCollectionViaSalesOrderHeader_
		{
			get { return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerViewRelatedCollectionViaSalesOrderHeader_. When set to true, CustomerViewRelatedCollectionViaSalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerViewRelatedCollectionViaSalesOrderHeader_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_
		{
			get	{ return _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_; }
			set	{ _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerViewRelatedCollectionViaSalesOrderHeader_ already has been fetched. Setting this property to false when CustomerViewRelatedCollectionViaSalesOrderHeader_ has been fetched
		/// will clear the CustomerViewRelatedCollectionViaSalesOrderHeader_ collection well. Setting this property to true while CustomerViewRelatedCollectionViaSalesOrderHeader_ hasn't been fetched disables lazy loading for CustomerViewRelatedCollectionViaSalesOrderHeader_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_
		{
			get { return _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_;}
			set 
			{
				if(_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ && !value && (_customerViewRelatedCollectionViaSalesOrderHeader_ != null))
				{
					_customerViewRelatedCollectionViaSalesOrderHeader_.Clear();
				}
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShipMethodCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ShipMethodCollection ShipMethodCollectionViaSalesOrderHeader
		{
			get { return GetMultiShipMethodCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ShipMethodCollectionViaSalesOrderHeader. When set to true, ShipMethodCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethodCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiShipMethodCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShipMethodCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchShipMethodCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchShipMethodCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShipMethodCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when ShipMethodCollectionViaSalesOrderHeader has been fetched
		/// will clear the ShipMethodCollectionViaSalesOrderHeader collection well. Setting this property to true while ShipMethodCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for ShipMethodCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShipMethodCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedShipMethodCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedShipMethodCollectionViaSalesOrderHeader && !value && (_shipMethodCollectionViaSalesOrderHeader != null))
				{
					_shipMethodCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = value;
			}
		}


		/// <summary> Gets / sets related entity of type 'IndividualEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleIndividual()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		public virtual IndividualEntity Individual
		{
			get	{ return GetSingleIndividual(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncIndividual(value);
				}
				else
				{
					if(value==null)
					{
						DesetupSyncIndividual(true, true);
					}
					else
					{
						if(_individual!=value)
						{
							IEntity relatedEntity = (IEntity)value;
							relatedEntity.SetRelatedEntity(this, "Customer");
							SetupSyncIndividual(relatedEntity);
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Individual. When set to true, Individual is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Individual is accessed. You can always execute
		/// a forced fetch by calling GetSingleIndividual(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchIndividual
		{
			get	{ return _alwaysFetchIndividual; }
			set	{ _alwaysFetchIndividual = value; }	
		}
		
		/// <summary>Gets / Sets the lazy loading flag if the property Individual already has been fetched. Setting this property to false when Individual has been fetched
		/// will set Individual to null as well. Setting this property to true while Individual hasn't been fetched disables lazy loading for Individual</summary>
		[Browsable(false)]
		public bool AlreadyFetchedIndividual
		{
			get { return _alreadyFetchedIndividual;}
			set 
			{
				if(_alreadyFetchedIndividual && !value)
				{
					this.Individual = null;
				}
				_alreadyFetchedIndividual = value;
			}
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Individual is not found
		/// in the database. When set to true, Individual will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool IndividualReturnsNewIfNotFound
		{
			get	{ return _individualReturnsNewIfNotFound; }
			set	{ _individualReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.CustomerEntity; }
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
