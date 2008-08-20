///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:27 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Data;
using System.Xml.Serialization;

using AW.Data;
using AW.Data.FactoryClasses;
using AW.Data.DaoClasses;
using AW.Data.RelationClasses;
using AW.Data.ValidatorClasses;
using AW.Data.HelperClasses;
using AW.Data.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity base class which represents the base class for the entity 'SalesOrderHeader'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract class SalesOrderHeaderEntityBase : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.SalesOrderDetailCollection	_salesOrderDetail;
		private bool	_alwaysFetchSalesOrderDetail, _alreadyFetchedSalesOrderDetail;
		private AW.Data.CollectionClasses.SpecialOfferProductCollection _specialOfferProductCollectionViaSalesOrderDetail;
		private bool	_alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail, _alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail;
		private AddressEntity _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress, _addressReturnsNewIfNotFound;
		private AddressEntity _address_;
		private bool	_alwaysFetchAddress_, _alreadyFetchedAddress_, _address_ReturnsNewIfNotFound;
		private ContactEntity _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact, _contactReturnsNewIfNotFound;
		private CustomerEntity _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer, _customerReturnsNewIfNotFound;
		private ShipMethodEntity _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod, _shipMethodReturnsNewIfNotFound;
		private CustomerViewRelatedEntity _customerView_;
		private bool	_alwaysFetchCustomerView_, _alreadyFetchedCustomerView_, _customerView_ReturnsNewIfNotFound;

		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region DataBinding Change Event Handler Declarations
		/// <summary>Event which is thrown when SalesOrderId changes value. Databinding related.</summary>
		public event EventHandler SalesOrderIdChanged;
		/// <summary>Event which is thrown when RevisionNumber changes value. Databinding related.</summary>
		public event EventHandler RevisionNumberChanged;
		/// <summary>Event which is thrown when OrderDate changes value. Databinding related.</summary>
		public event EventHandler OrderDateChanged;
		/// <summary>Event which is thrown when DueDate changes value. Databinding related.</summary>
		public event EventHandler DueDateChanged;
		/// <summary>Event which is thrown when ShipDate changes value. Databinding related.</summary>
		public event EventHandler ShipDateChanged;
		/// <summary>Event which is thrown when Status changes value. Databinding related.</summary>
		public event EventHandler StatusChanged;
		/// <summary>Event which is thrown when OnlineOrderFlag changes value. Databinding related.</summary>
		public event EventHandler OnlineOrderFlagChanged;
		/// <summary>Event which is thrown when SalesOrderNumber changes value. Databinding related.</summary>
		public event EventHandler SalesOrderNumberChanged;
		/// <summary>Event which is thrown when PurchaseOrderNumber changes value. Databinding related.</summary>
		public event EventHandler PurchaseOrderNumberChanged;
		/// <summary>Event which is thrown when AccountNumber changes value. Databinding related.</summary>
		public event EventHandler AccountNumberChanged;
		/// <summary>Event which is thrown when CustomerId changes value. Databinding related.</summary>
		public event EventHandler CustomerIdChanged;
		/// <summary>Event which is thrown when ContactId changes value. Databinding related.</summary>
		public event EventHandler ContactIdChanged;
		/// <summary>Event which is thrown when SalesPersonId changes value. Databinding related.</summary>
		public event EventHandler SalesPersonIdChanged;
		/// <summary>Event which is thrown when TerritoryId changes value. Databinding related.</summary>
		public event EventHandler TerritoryIdChanged;
		/// <summary>Event which is thrown when BillToAddressId changes value. Databinding related.</summary>
		public event EventHandler BillToAddressIdChanged;
		/// <summary>Event which is thrown when ShipToAddressId changes value. Databinding related.</summary>
		public event EventHandler ShipToAddressIdChanged;
		/// <summary>Event which is thrown when ShipMethodId changes value. Databinding related.</summary>
		public event EventHandler ShipMethodIdChanged;
		/// <summary>Event which is thrown when CreditCardId changes value. Databinding related.</summary>
		public event EventHandler CreditCardIdChanged;
		/// <summary>Event which is thrown when CreditCardApprovalCode changes value. Databinding related.</summary>
		public event EventHandler CreditCardApprovalCodeChanged;
		/// <summary>Event which is thrown when CurrencyRateId changes value. Databinding related.</summary>
		public event EventHandler CurrencyRateIdChanged;
		/// <summary>Event which is thrown when SubTotal changes value. Databinding related.</summary>
		public event EventHandler SubTotalChanged;
		/// <summary>Event which is thrown when TaxAmt changes value. Databinding related.</summary>
		public event EventHandler TaxAmtChanged;
		/// <summary>Event which is thrown when Freight changes value. Databinding related.</summary>
		public event EventHandler FreightChanged;
		/// <summary>Event which is thrown when TotalDue changes value. Databinding related.</summary>
		public event EventHandler TotalDueChanged;
		/// <summary>Event which is thrown when Comment changes value. Databinding related.</summary>
		public event EventHandler CommentChanged;
		/// <summary>Event which is thrown when Rowguid changes value. Databinding related.</summary>
		public event EventHandler RowguidChanged;
		/// <summary>Event which is thrown when ModifiedDate changes value. Databinding related.</summary>
		public event EventHandler ModifiedDateChanged;

		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesOrderHeaderEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SalesOrderHeaderEntityBase()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), CreateValidator());
		}

	
		/// <summary>CTor</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		public SalesOrderHeaderEntityBase(System.Int32 salesOrderId)
		{
			InitClassFetch(salesOrderId, CreateValidator(), new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesOrderHeaderEntityBase(System.Int32 salesOrderId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(salesOrderId, CreateValidator(), new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		public SalesOrderHeaderEntityBase(System.Int32 salesOrderId, SalesOrderHeaderValidator validator)
		{
			InitClassFetch(salesOrderId, validator, new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesOrderHeaderEntityBase(System.Int32 salesOrderId, SalesOrderHeaderValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(salesOrderId, validator, propertyDescriptorFactoryToUse, entityFactoryToUse, null);
		}
	

		/// <summary>CTor</summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesOrderHeaderEntityBase(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse, CreateValidator());
		}

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesOrderHeaderEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_salesOrderDetail = (AW.Data.CollectionClasses.SalesOrderDetailCollection)info.GetValue("_salesOrderDetail", typeof(AW.Data.CollectionClasses.SalesOrderDetailCollection));
			_alwaysFetchSalesOrderDetail = info.GetBoolean("_alwaysFetchSalesOrderDetail");
			_alreadyFetchedSalesOrderDetail = info.GetBoolean("_alreadyFetchedSalesOrderDetail");
			_specialOfferProductCollectionViaSalesOrderDetail = (AW.Data.CollectionClasses.SpecialOfferProductCollection)info.GetValue("_specialOfferProductCollectionViaSalesOrderDetail", typeof(AW.Data.CollectionClasses.SpecialOfferProductCollection));
			_alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail = info.GetBoolean("_alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail");
			_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail = info.GetBoolean("_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail");
			_address = (AddressEntity)info.GetValue("_address", typeof(AddressEntity));
			if(_address!=null)
			{
				_address.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_addressReturnsNewIfNotFound = info.GetBoolean("_addressReturnsNewIfNotFound");
			_alwaysFetchAddress = info.GetBoolean("_alwaysFetchAddress");
			_alreadyFetchedAddress = info.GetBoolean("_alreadyFetchedAddress");
			_address_ = (AddressEntity)info.GetValue("_address_", typeof(AddressEntity));
			if(_address_!=null)
			{
				_address_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_address_ReturnsNewIfNotFound = info.GetBoolean("_address_ReturnsNewIfNotFound");
			_alwaysFetchAddress_ = info.GetBoolean("_alwaysFetchAddress_");
			_alreadyFetchedAddress_ = info.GetBoolean("_alreadyFetchedAddress_");
			_contact = (ContactEntity)info.GetValue("_contact", typeof(ContactEntity));
			if(_contact!=null)
			{
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_contactReturnsNewIfNotFound = info.GetBoolean("_contactReturnsNewIfNotFound");
			_alwaysFetchContact = info.GetBoolean("_alwaysFetchContact");
			_alreadyFetchedContact = info.GetBoolean("_alreadyFetchedContact");
			_customer = (CustomerEntity)info.GetValue("_customer", typeof(CustomerEntity));
			if(_customer!=null)
			{
				_customer.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_customerReturnsNewIfNotFound = info.GetBoolean("_customerReturnsNewIfNotFound");
			_alwaysFetchCustomer = info.GetBoolean("_alwaysFetchCustomer");
			_alreadyFetchedCustomer = info.GetBoolean("_alreadyFetchedCustomer");
			_shipMethod = (ShipMethodEntity)info.GetValue("_shipMethod", typeof(ShipMethodEntity));
			if(_shipMethod!=null)
			{
				_shipMethod.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_shipMethodReturnsNewIfNotFound = info.GetBoolean("_shipMethodReturnsNewIfNotFound");
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");
			_customerView_ = (CustomerViewRelatedEntity)info.GetValue("_customerView_", typeof(CustomerViewRelatedEntity));
			if(_customerView_!=null)
			{
				_customerView_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_customerView_ReturnsNewIfNotFound = info.GetBoolean("_customerView_ReturnsNewIfNotFound");
			_alwaysFetchCustomerView_ = info.GetBoolean("_alwaysFetchCustomerView_");
			_alreadyFetchedCustomerView_ = info.GetBoolean("_alreadyFetchedCustomerView_");

			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary> Will perform post-ReadXml actions as well as the normal ReadXml() actions, performed by the base class.</summary>
		/// <param name="node">XmlNode with Xml data which should be read into this entity and its members. Node's root element is the root element of the entity's Xml data</param>
		public override void ReadXml(System.Xml.XmlNode node)
		{
			base.ReadXml (node);
			_alreadyFetchedSalesOrderDetail = (_salesOrderDetail.Count > 0);
			_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail = (_specialOfferProductCollectionViaSalesOrderDetail.Count > 0);
			_alreadyFetchedAddress = (_address != null);
			_alreadyFetchedAddress_ = (_address_ != null);
			_alreadyFetchedContact = (_contact != null);
			_alreadyFetchedCustomer = (_customer != null);
			_alreadyFetchedShipMethod = (_shipMethod != null);
			_alreadyFetchedCustomerView_ = (_customerView_ != null);

		}
		
		/// <summary> Saves the Entity class to the persistent storage. It updates or inserts the entity, which depends if the entity was originally read from the 
		/// database. If the entity is new, an insert is done and the updateRestriction is ignored. If the entity is not new, the updateRestriction
		/// predicate is used to create an additional where clause (it will be added with AND) for the update query. This predicate can be used for
		/// concurrency checks, like checks on timestamp column values.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query. Will be ignored when the entity is new </param>
		/// <param name="recurse">When true, it will save all dirty objects referenced (directly or indirectly) by this entity also.</param>
		/// <returns>true if Save succeeded, false otherwise</returns>
		/// <remarks>Do not call this routine directly, use the overloaded version in a derived class as this version doesn't construct a
		/// local transaction during recursive save, this is done in the overloaded version in a derived class.</remarks>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		public override bool Save(IPredicate updateRestriction, bool recurse)
		{
			bool transactionStartedInThisScope = false;
			Transaction transactionManager = null;

			if(recurse || ((this.LLBLGenProIsInHierarchyOfType==InheritanceHierarchyType.TargetPerEntity) && this.LLBLGenProIsSubType))
			{
				if(!base.ParticipatesInTransaction)
				{
					transactionManager = new Transaction(IsolationLevel.ReadCommitted, "SaveRecursively");
					transactionManager.Add(this);
					transactionStartedInThisScope=true;
				}
			}
			try
			{
				bool result = base.Save(updateRestriction, recurse);
				if(transactionStartedInThisScope)
				{
					transactionManager.Commit();
				}
				return result;
			}
			catch
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Rollback();
				}
				throw;
			}
			finally
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Dispose();
				}
			}
		}
		


		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_salesOrderDetail", _salesOrderDetail);
			info.AddValue("_alwaysFetchSalesOrderDetail", _alwaysFetchSalesOrderDetail);
			info.AddValue("_alreadyFetchedSalesOrderDetail", _alreadyFetchedSalesOrderDetail);
			info.AddValue("_specialOfferProductCollectionViaSalesOrderDetail", _specialOfferProductCollectionViaSalesOrderDetail);
			info.AddValue("_alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail", _alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail);
			info.AddValue("_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail", _alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail);
			info.AddValue("_address", _address);
			info.AddValue("_addressReturnsNewIfNotFound", _addressReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAddress", _alwaysFetchAddress);
			info.AddValue("_alreadyFetchedAddress", _alreadyFetchedAddress);
			info.AddValue("_address_", _address_);
			info.AddValue("_address_ReturnsNewIfNotFound", _address_ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAddress_", _alwaysFetchAddress_);
			info.AddValue("_alreadyFetchedAddress_", _alreadyFetchedAddress_);
			info.AddValue("_contact", _contact);
			info.AddValue("_contactReturnsNewIfNotFound", _contactReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);
			info.AddValue("_customer", _customer);
			info.AddValue("_customerReturnsNewIfNotFound", _customerReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCustomer", _alwaysFetchCustomer);
			info.AddValue("_alreadyFetchedCustomer", _alreadyFetchedCustomer);
			info.AddValue("_shipMethod", _shipMethod);
			info.AddValue("_shipMethodReturnsNewIfNotFound", _shipMethodReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchShipMethod", _alwaysFetchShipMethod);
			info.AddValue("_alreadyFetchedShipMethod", _alreadyFetchedShipMethod);
			info.AddValue("_customerView_", _customerView_);
			info.AddValue("_customerView_ReturnsNewIfNotFound", _customerView_ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCustomerView_", _alwaysFetchCustomerView_);
			info.AddValue("_alreadyFetchedCustomerView_", _alreadyFetchedCustomerView_);

			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "Address":
					_alreadyFetchedAddress = true;
					this.Address = (AddressEntity)entity;
					break;
				case "Address_":
					_alreadyFetchedAddress_ = true;
					this.Address_ = (AddressEntity)entity;
					break;
				case "Contact":
					_alreadyFetchedContact = true;
					this.Contact = (ContactEntity)entity;
					break;
				case "Customer":
					_alreadyFetchedCustomer = true;
					this.Customer = (CustomerEntity)entity;
					break;
				case "ShipMethod":
					_alreadyFetchedShipMethod = true;
					this.ShipMethod = (ShipMethodEntity)entity;
					break;
				case "CustomerView_":
					_alreadyFetchedCustomerView_ = true;
					this.CustomerView_ = (CustomerViewRelatedEntity)entity;
					break;
				case "SalesOrderDetail":
					_alreadyFetchedSalesOrderDetail = true;
					if(entity!=null)
					{
						this.SalesOrderDetail.Add((SalesOrderDetailEntity)entity);
					}
					break;
				case "SpecialOfferProductCollectionViaSalesOrderDetail":
					_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail = true;
					if(entity!=null)
					{
						this.SpecialOfferProductCollectionViaSalesOrderDetail.Add((SpecialOfferProductEntity)entity);
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
				case "Address":
					SetupSyncAddress(relatedEntity);
					break;
				case "Address_":
					SetupSyncAddress_(relatedEntity);
					break;
				case "Contact":
					SetupSyncContact(relatedEntity);
					break;
				case "Customer":
					SetupSyncCustomer(relatedEntity);
					break;
				case "ShipMethod":
					SetupSyncShipMethod(relatedEntity);
					break;
				case "CustomerView_":
					SetupSyncCustomerView_(relatedEntity);
					break;
				case "SalesOrderDetail":
					_salesOrderDetail.Add(relatedEntity);
					break;

				default:

					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Address":
					DesetupSyncAddress(false);
					break;
				case "Address_":
					DesetupSyncAddress_(false);
					break;
				case "Contact":
					DesetupSyncContact(false);
					break;
				case "Customer":
					DesetupSyncCustomer(false);
					break;
				case "ShipMethod":
					DesetupSyncShipMethod(false);
					break;
				case "CustomerView_":
					DesetupSyncCustomerView_(false);
					break;
				case "SalesOrderDetail":
					_salesOrderDetail.Remove(relatedEntity);
					break;

				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override ArrayList GetDependingRelatedEntities()
		{
			ArrayList toReturn = new ArrayList();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override ArrayList GetDependentRelatedEntities()
		{
			ArrayList toReturn = new ArrayList();
			if(_address!=null)
			{
				toReturn.Add(_address);
			}
			if(_address_!=null)
			{
				toReturn.Add(_address_);
			}
			if(_contact!=null)
			{
				toReturn.Add(_contact);
			}
			if(_customer!=null)
			{
				toReturn.Add(_customer);
			}
			if(_shipMethod!=null)
			{
				toReturn.Add(_shipMethod);
			}
			if(_customerView_!=null)
			{
				toReturn.Add(_customerView_);
			}


			return toReturn;
		}
		
		/// <summary> Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override ArrayList GetMemberEntityCollections()
		{
			ArrayList toReturn = new ArrayList();
			toReturn.Add(_salesOrderDetail);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderId)
		{
			return FetchUsingPK(salesOrderId, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(salesOrderId, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(salesOrderId, prefetchPathToUse, contextToUse);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.SalesOrderId, null, null);
		}


		/// <summary> Deletes the Entity from the persistent storage. This method succeeds also when the Entity is not present.</summary>
		/// <param name="deleteRestriction">Predicate expression, meant for concurrency checks in a delete query. Overrules the predicate returned by a set ConcurrencyPredicateFactory object.</param>
		/// <returns>true if Delete succeeded, false otherwise</returns>
		public override bool Delete(IPredicate deleteRestriction)
		{
			bool transactionStartedInThisScope = false;
			Transaction transactionManager = null;
			if((this.LLBLGenProIsInHierarchyOfType==InheritanceHierarchyType.TargetPerEntity) && this.LLBLGenProIsSubType)
			{
				if(!base.ParticipatesInTransaction)
				{
					transactionManager = new Transaction(IsolationLevel.ReadCommitted, "DeleteEntity");
					transactionManager.Add(this);
					transactionStartedInThisScope=true;
				}
			}
			try
			{
				OnDelete();
				IDao dao = CreateDAOInstance();
				bool wasSuccesful = dao.DeleteExisting(base.Fields, base.Transaction, deleteRestriction);
				if(wasSuccesful)
				{
					base.Delete(deleteRestriction);
				}
				if(transactionStartedInThisScope)
				{
					transactionManager.Commit();
				}
				return wasSuccesful;
			}
			catch
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Rollback();
				}
				throw;
			}
			finally
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Dispose();
				}
				OnDeleteComplete();
			}
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(SalesOrderHeaderFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(SalesOrderHeaderFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}
		
		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("SalesOrderHeaderEntity", ((AW.Data.EntityType)typeOfEntity).ToString());
		}


		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetail(bool forceFetch)
		{
			return GetMultiSalesOrderDetail(forceFetch, _salesOrderDetail.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderDetailEntity'</returns>
		public AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetail(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSalesOrderDetail(forceFetch, _salesOrderDetail.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSalesOrderDetail(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SalesOrderDetailCollection GetMultiSalesOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderDetail || forceFetch || _alwaysFetchSalesOrderDetail) && !base.IsSerializing && !base.IsDeserializing && !EntityCollectionBase.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderDetail);
					}
				}
				_salesOrderDetail.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_salesOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				}
				_salesOrderDetail.GetMultiManyToOne(null, this, filter);
				_salesOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderDetail = true;
			}
			return _salesOrderDetail;
		}

		/// <summary> Sets the collection parameters for the collection for 'SalesOrderDetail'. These settings will be taken into account
		/// when the property SalesOrderDetail is requested or GetMultiSalesOrderDetail is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderDetail(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderDetail.SortClauses=sortClauses;
			_salesOrderDetail.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProductCollectionViaSalesOrderDetail(bool forceFetch)
		{
			return GetMultiSpecialOfferProductCollectionViaSalesOrderDetail(forceFetch, _specialOfferProductCollectionViaSalesOrderDetail.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProductCollectionViaSalesOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail || forceFetch || _alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail) && !base.IsSerializing && !base.IsDeserializing && !EntityCollectionBase.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferProductCollectionViaSalesOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferProductCollectionViaSalesOrderDetail);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(SalesOrderHeaderEntity.Relations.SalesOrderDetailEntityUsingSalesOrderId, "SalesOrderDetail_");
				relations.Add(SalesOrderDetailEntity.Relations.SpecialOfferProductEntityUsingSpecialOfferIdProductId, "SalesOrderDetail_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.SalesOrderId), ComparisonOperator.Equal, this.SalesOrderId));
				_specialOfferProductCollectionViaSalesOrderDetail.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_specialOfferProductCollectionViaSalesOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				}
				_specialOfferProductCollectionViaSalesOrderDetail.GetMulti(filter, relations);
				_specialOfferProductCollectionViaSalesOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail = true;
			}
			return _specialOfferProductCollectionViaSalesOrderDetail;
		}

		/// <summary> Sets the collection parameters for the collection for 'SpecialOfferProductCollectionViaSalesOrderDetail'. These settings will be taken into account
		/// when the property SpecialOfferProductCollectionViaSalesOrderDetail is requested or GetMultiSpecialOfferProductCollectionViaSalesOrderDetail is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOfferProductCollectionViaSalesOrderDetail(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOfferProductCollectionViaSalesOrderDetail.SortClauses=sortClauses;
			_specialOfferProductCollectionViaSalesOrderDetail.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public AddressEntity GetSingleAddress()
		{
			return GetSingleAddress(false);
		}

		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public virtual AddressEntity GetSingleAddress(bool forceFetch)
		{
 			if( ( !_alreadyFetchedAddress || forceFetch || _alwaysFetchAddress) && !base.IsSerializing && !base.IsDeserializing )
			{

				AddressEntity newEntity = new AddressEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = newEntity.FetchUsingPK(this.BillToAddressId);
				if(!_addressReturnsNewIfNotFound && !fetchResult)
				{
					this.Address = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (AddressEntity)base.ActiveContext.Get(newEntity);
					}
					this.Address = newEntity;
					_alreadyFetchedAddress = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _address;
		}

		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public AddressEntity GetSingleAddress_()
		{
			return GetSingleAddress_(false);
		}

		/// <summary> Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public virtual AddressEntity GetSingleAddress_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedAddress_ || forceFetch || _alwaysFetchAddress_) && !base.IsSerializing && !base.IsDeserializing )
			{

				AddressEntity newEntity = new AddressEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = newEntity.FetchUsingPK(this.ShipToAddressId);
				if(!_address_ReturnsNewIfNotFound && !fetchResult)
				{
					this.Address_ = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (AddressEntity)base.ActiveContext.Get(newEntity);
					}
					this.Address_ = newEntity;
					_alreadyFetchedAddress_ = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _address_;
		}

		/// <summary> Retrieves the related entity of type 'ContactEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ContactEntity' which is related to this entity.</returns>
		public ContactEntity GetSingleContact()
		{
			return GetSingleContact(false);
		}

		/// <summary> Retrieves the related entity of type 'ContactEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ContactEntity' which is related to this entity.</returns>
		public virtual ContactEntity GetSingleContact(bool forceFetch)
		{
 			if( ( !_alreadyFetchedContact || forceFetch || _alwaysFetchContact) && !base.IsSerializing && !base.IsDeserializing )
			{

				ContactEntity newEntity = new ContactEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = newEntity.FetchUsingPK(this.ContactId);
				if(!_contactReturnsNewIfNotFound && !fetchResult)
				{
					this.Contact = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (ContactEntity)base.ActiveContext.Get(newEntity);
					}
					this.Contact = newEntity;
					_alreadyFetchedContact = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _contact;
		}

		/// <summary> Retrieves the related entity of type 'CustomerEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public CustomerEntity GetSingleCustomer()
		{
			return GetSingleCustomer(false);
		}

		/// <summary> Retrieves the related entity of type 'CustomerEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public virtual CustomerEntity GetSingleCustomer(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCustomer || forceFetch || _alwaysFetchCustomer) && !base.IsSerializing && !base.IsDeserializing )
			{

				CustomerEntity newEntity = new CustomerEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = newEntity.FetchUsingPK(this.CustomerId);
				if(!_customerReturnsNewIfNotFound && !fetchResult)
				{
					this.Customer = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (CustomerEntity)base.ActiveContext.Get(newEntity);
					}
					this.Customer = newEntity;
					_alreadyFetchedCustomer = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _customer;
		}

		/// <summary> Retrieves the related entity of type 'ShipMethodEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ShipMethodEntity' which is related to this entity.</returns>
		public ShipMethodEntity GetSingleShipMethod()
		{
			return GetSingleShipMethod(false);
		}

		/// <summary> Retrieves the related entity of type 'ShipMethodEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ShipMethodEntity' which is related to this entity.</returns>
		public virtual ShipMethodEntity GetSingleShipMethod(bool forceFetch)
		{
 			if( ( !_alreadyFetchedShipMethod || forceFetch || _alwaysFetchShipMethod) && !base.IsSerializing && !base.IsDeserializing )
			{

				ShipMethodEntity newEntity = new ShipMethodEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = newEntity.FetchUsingPK(this.ShipMethodId);
				if(!_shipMethodReturnsNewIfNotFound && !fetchResult)
				{
					this.ShipMethod = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (ShipMethodEntity)base.ActiveContext.Get(newEntity);
					}
					this.ShipMethod = newEntity;
					_alreadyFetchedShipMethod = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _shipMethod;
		}

		/// <summary> Retrieves the related entity of type 'CustomerViewRelatedEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CustomerViewRelatedEntity' which is related to this entity.</returns>
		public CustomerViewRelatedEntity GetSingleCustomerView_()
		{
			return GetSingleCustomerView_(false);
		}

		/// <summary> Retrieves the related entity of type 'CustomerViewRelatedEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CustomerViewRelatedEntity' which is related to this entity.</returns>
		public virtual CustomerViewRelatedEntity GetSingleCustomerView_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCustomerView_ || forceFetch || _alwaysFetchCustomerView_) && !base.IsSerializing && !base.IsDeserializing )
			{

				CustomerViewRelatedEntity newEntity = new CustomerViewRelatedEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = newEntity.FetchUsingPK(this.CustomerId);
				if(!_customerView_ReturnsNewIfNotFound && !fetchResult)
				{
					this.CustomerView_ = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (CustomerViewRelatedEntity)base.ActiveContext.Get(newEntity);
					}
					this.CustomerView_ = newEntity;
					_alreadyFetchedCustomerView_ = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _customerView_;
		}

	
		#region Data binding change event raising methods

		/// <summary> Event thrower for the SalesOrderIdChanged event, which is thrown when SalesOrderId changes value. Databinding related.</summary>
		protected virtual void OnSalesOrderIdChanged()
		{
			if(SalesOrderIdChanged!=null)
			{
				SalesOrderIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the RevisionNumberChanged event, which is thrown when RevisionNumber changes value. Databinding related.</summary>
		protected virtual void OnRevisionNumberChanged()
		{
			if(RevisionNumberChanged!=null)
			{
				RevisionNumberChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the OrderDateChanged event, which is thrown when OrderDate changes value. Databinding related.</summary>
		protected virtual void OnOrderDateChanged()
		{
			if(OrderDateChanged!=null)
			{
				OrderDateChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the DueDateChanged event, which is thrown when DueDate changes value. Databinding related.</summary>
		protected virtual void OnDueDateChanged()
		{
			if(DueDateChanged!=null)
			{
				DueDateChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ShipDateChanged event, which is thrown when ShipDate changes value. Databinding related.</summary>
		protected virtual void OnShipDateChanged()
		{
			if(ShipDateChanged!=null)
			{
				ShipDateChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the StatusChanged event, which is thrown when Status changes value. Databinding related.</summary>
		protected virtual void OnStatusChanged()
		{
			if(StatusChanged!=null)
			{
				StatusChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the OnlineOrderFlagChanged event, which is thrown when OnlineOrderFlag changes value. Databinding related.</summary>
		protected virtual void OnOnlineOrderFlagChanged()
		{
			if(OnlineOrderFlagChanged!=null)
			{
				OnlineOrderFlagChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the SalesOrderNumberChanged event, which is thrown when SalesOrderNumber changes value. Databinding related.</summary>
		protected virtual void OnSalesOrderNumberChanged()
		{
			if(SalesOrderNumberChanged!=null)
			{
				SalesOrderNumberChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the PurchaseOrderNumberChanged event, which is thrown when PurchaseOrderNumber changes value. Databinding related.</summary>
		protected virtual void OnPurchaseOrderNumberChanged()
		{
			if(PurchaseOrderNumberChanged!=null)
			{
				PurchaseOrderNumberChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the AccountNumberChanged event, which is thrown when AccountNumber changes value. Databinding related.</summary>
		protected virtual void OnAccountNumberChanged()
		{
			if(AccountNumberChanged!=null)
			{
				AccountNumberChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the CustomerIdChanged event, which is thrown when CustomerId changes value. Databinding related.</summary>
		protected virtual void OnCustomerIdChanged()
		{
			if(CustomerIdChanged!=null)
			{
				CustomerIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ContactIdChanged event, which is thrown when ContactId changes value. Databinding related.</summary>
		protected virtual void OnContactIdChanged()
		{
			if(ContactIdChanged!=null)
			{
				ContactIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the SalesPersonIdChanged event, which is thrown when SalesPersonId changes value. Databinding related.</summary>
		protected virtual void OnSalesPersonIdChanged()
		{
			if(SalesPersonIdChanged!=null)
			{
				SalesPersonIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the TerritoryIdChanged event, which is thrown when TerritoryId changes value. Databinding related.</summary>
		protected virtual void OnTerritoryIdChanged()
		{
			if(TerritoryIdChanged!=null)
			{
				TerritoryIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the BillToAddressIdChanged event, which is thrown when BillToAddressId changes value. Databinding related.</summary>
		protected virtual void OnBillToAddressIdChanged()
		{
			if(BillToAddressIdChanged!=null)
			{
				BillToAddressIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ShipToAddressIdChanged event, which is thrown when ShipToAddressId changes value. Databinding related.</summary>
		protected virtual void OnShipToAddressIdChanged()
		{
			if(ShipToAddressIdChanged!=null)
			{
				ShipToAddressIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ShipMethodIdChanged event, which is thrown when ShipMethodId changes value. Databinding related.</summary>
		protected virtual void OnShipMethodIdChanged()
		{
			if(ShipMethodIdChanged!=null)
			{
				ShipMethodIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the CreditCardIdChanged event, which is thrown when CreditCardId changes value. Databinding related.</summary>
		protected virtual void OnCreditCardIdChanged()
		{
			if(CreditCardIdChanged!=null)
			{
				CreditCardIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the CreditCardApprovalCodeChanged event, which is thrown when CreditCardApprovalCode changes value. Databinding related.</summary>
		protected virtual void OnCreditCardApprovalCodeChanged()
		{
			if(CreditCardApprovalCodeChanged!=null)
			{
				CreditCardApprovalCodeChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the CurrencyRateIdChanged event, which is thrown when CurrencyRateId changes value. Databinding related.</summary>
		protected virtual void OnCurrencyRateIdChanged()
		{
			if(CurrencyRateIdChanged!=null)
			{
				CurrencyRateIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the SubTotalChanged event, which is thrown when SubTotal changes value. Databinding related.</summary>
		protected virtual void OnSubTotalChanged()
		{
			if(SubTotalChanged!=null)
			{
				SubTotalChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the TaxAmtChanged event, which is thrown when TaxAmt changes value. Databinding related.</summary>
		protected virtual void OnTaxAmtChanged()
		{
			if(TaxAmtChanged!=null)
			{
				TaxAmtChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the FreightChanged event, which is thrown when Freight changes value. Databinding related.</summary>
		protected virtual void OnFreightChanged()
		{
			if(FreightChanged!=null)
			{
				FreightChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the TotalDueChanged event, which is thrown when TotalDue changes value. Databinding related.</summary>
		protected virtual void OnTotalDueChanged()
		{
			if(TotalDueChanged!=null)
			{
				TotalDueChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the CommentChanged event, which is thrown when Comment changes value. Databinding related.</summary>
		protected virtual void OnCommentChanged()
		{
			if(CommentChanged!=null)
			{
				CommentChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the RowguidChanged event, which is thrown when Rowguid changes value. Databinding related.</summary>
		protected virtual void OnRowguidChanged()
		{
			if(RowguidChanged!=null)
			{
				RowguidChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ModifiedDateChanged event, which is thrown when ModifiedDate changes value. Databinding related.</summary>
		protected virtual void OnModifiedDateChanged()
		{
			if(ModifiedDateChanged!=null)
			{
				ModifiedDateChanged(this, new EventArgs());
			}
		}

		#endregion
		
		/// <summary> Sets the field on index fieldIndex to the new value value. Marks also the fields object as dirty. </summary>
		/// <param name="fieldIndex">Index of field to set the new value of</param>
		/// <param name="value">Value to set</param>
		/// <param name="checkForRefetch">If set to true, it will check if this entity is out of sync and will refetch it first if it is. Use true in normal behavior, false for framework specific code.</param>
		/// <returns>true if the value is actually set, false otherwise.</returns>
		/// <remarks>Dereferences a related object in an 1:1/m:1 relation if the field is an FK field and responsible for the reference of that particular related object.</remarks>
		/// <exception cref="ArgumentOutOfRangeException">When fieldIndex is smaller than 0 or bigger than the number of fields in the fields collection.</exception>
		protected override bool SetNewFieldValue(int fieldIndex, object value, bool checkForRefetch)
		{
			bool toReturn = base.SetNewFieldValue (fieldIndex, value, checkForRefetch, false);
			if(toReturn)
			{
				switch((SalesOrderHeaderFieldIndex)fieldIndex)
				{
					case SalesOrderHeaderFieldIndex.CustomerId:
						DecoupleEventsCustomer();
						_customer = null;
						_alreadyFetchedCustomer = false;
						DecoupleEventsCustomerView_();
						_customerView_ = null;
						_alreadyFetchedCustomerView_ = false;
						break;
					case SalesOrderHeaderFieldIndex.ContactId:
						DecoupleEventsContact();
						_contact = null;
						_alreadyFetchedContact = false;
						break;
					case SalesOrderHeaderFieldIndex.BillToAddressId:
						DecoupleEventsAddress();
						_address = null;
						_alreadyFetchedAddress = false;
						break;
					case SalesOrderHeaderFieldIndex.ShipToAddressId:
						DecoupleEventsAddress_();
						_address_ = null;
						_alreadyFetchedAddress_ = false;
						break;
					case SalesOrderHeaderFieldIndex.ShipMethodId:
						DecoupleEventsShipMethod();
						_shipMethod = null;
						_alreadyFetchedShipMethod = false;
						break;
					default:
						break;
				}
				base.PostFieldValueSetAction(toReturn);
				switch((SalesOrderHeaderFieldIndex)fieldIndex)
				{
					case SalesOrderHeaderFieldIndex.SalesOrderId:
						OnSalesOrderIdChanged();
						break;
					case SalesOrderHeaderFieldIndex.RevisionNumber:
						OnRevisionNumberChanged();
						break;
					case SalesOrderHeaderFieldIndex.OrderDate:
						OnOrderDateChanged();
						break;
					case SalesOrderHeaderFieldIndex.DueDate:
						OnDueDateChanged();
						break;
					case SalesOrderHeaderFieldIndex.ShipDate:
						OnShipDateChanged();
						break;
					case SalesOrderHeaderFieldIndex.Status:
						OnStatusChanged();
						break;
					case SalesOrderHeaderFieldIndex.OnlineOrderFlag:
						OnOnlineOrderFlagChanged();
						break;
					case SalesOrderHeaderFieldIndex.SalesOrderNumber:
						OnSalesOrderNumberChanged();
						break;
					case SalesOrderHeaderFieldIndex.PurchaseOrderNumber:
						OnPurchaseOrderNumberChanged();
						break;
					case SalesOrderHeaderFieldIndex.AccountNumber:
						OnAccountNumberChanged();
						break;
					case SalesOrderHeaderFieldIndex.CustomerId:
						OnCustomerIdChanged();
						break;
					case SalesOrderHeaderFieldIndex.ContactId:
						OnContactIdChanged();
						break;
					case SalesOrderHeaderFieldIndex.SalesPersonId:
						OnSalesPersonIdChanged();
						break;
					case SalesOrderHeaderFieldIndex.TerritoryId:
						OnTerritoryIdChanged();
						break;
					case SalesOrderHeaderFieldIndex.BillToAddressId:
						OnBillToAddressIdChanged();
						break;
					case SalesOrderHeaderFieldIndex.ShipToAddressId:
						OnShipToAddressIdChanged();
						break;
					case SalesOrderHeaderFieldIndex.ShipMethodId:
						OnShipMethodIdChanged();
						break;
					case SalesOrderHeaderFieldIndex.CreditCardId:
						OnCreditCardIdChanged();
						break;
					case SalesOrderHeaderFieldIndex.CreditCardApprovalCode:
						OnCreditCardApprovalCodeChanged();
						break;
					case SalesOrderHeaderFieldIndex.CurrencyRateId:
						OnCurrencyRateIdChanged();
						break;
					case SalesOrderHeaderFieldIndex.SubTotal:
						OnSubTotalChanged();
						break;
					case SalesOrderHeaderFieldIndex.TaxAmt:
						OnTaxAmtChanged();
						break;
					case SalesOrderHeaderFieldIndex.Freight:
						OnFreightChanged();
						break;
					case SalesOrderHeaderFieldIndex.TotalDue:
						OnTotalDueChanged();
						break;
					case SalesOrderHeaderFieldIndex.Comment:
						OnCommentChanged();
						break;
					case SalesOrderHeaderFieldIndex.Rowguid:
						OnRowguidChanged();
						break;
					case SalesOrderHeaderFieldIndex.ModifiedDate:
						OnModifiedDateChanged();
						break;
					default:
						break;
				}
			}
			return toReturn;
		}

		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			SalesOrderHeaderDAO dao = (SalesOrderHeaderDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_salesOrderDetail.ActiveContext = base.ActiveContext;
			_specialOfferProductCollectionViaSalesOrderDetail.ActiveContext = base.ActiveContext;
			if(_address!=null)
			{
				_address.ActiveContext = base.ActiveContext;
			}
			if(_address_!=null)
			{
				_address_.ActiveContext = base.ActiveContext;
			}
			if(_contact!=null)
			{
				_contact.ActiveContext = base.ActiveContext;
			}
			if(_customer!=null)
			{
				_customer.ActiveContext = base.ActiveContext;
			}
			if(_shipMethod!=null)
			{
				_shipMethod.ActiveContext = base.ActiveContext;
			}
			if(_customerView_!=null)
			{
				_customerView_.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			SalesOrderHeaderDAO dao = (SalesOrderHeaderDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			SalesOrderHeaderDAO dao = (SalesOrderHeaderDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction, updateRestriction);
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse, IValidator validatorToUse)
		{
			base.Fields = CreateFields();
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = validatorToUse;

			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

		}

		/// <summary> A method which calls all OnFieldnameChanged methods to signal that the field has been changed
		/// to bound controls. This is required after a RollbackFields() call.</summary>
		protected override void FlagAllFieldsAsChanged()
		{
			OnSalesOrderIdChanged();
			OnRevisionNumberChanged();
			OnOrderDateChanged();
			OnDueDateChanged();
			OnShipDateChanged();
			OnStatusChanged();
			OnOnlineOrderFlagChanged();
			OnSalesOrderNumberChanged();
			OnPurchaseOrderNumberChanged();
			OnAccountNumberChanged();
			OnCustomerIdChanged();
			OnContactIdChanged();
			OnSalesPersonIdChanged();
			OnTerritoryIdChanged();
			OnBillToAddressIdChanged();
			OnShipToAddressIdChanged();
			OnShipMethodIdChanged();
			OnCreditCardIdChanged();
			OnCreditCardApprovalCodeChanged();
			OnCurrencyRateIdChanged();
			OnSubTotalChanged();
			OnTaxAmtChanged();
			OnFreightChanged();
			OnTotalDueChanged();
			OnCommentChanged();
			OnRowguidChanged();
			OnModifiedDateChanged();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.SalesOrderHeaderEntity);
		}

		/// <summary>Creates field validator object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IValidator CreateValidator()
		{
			return new SalesOrderHeaderValidator();
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this SalesOrderHeaderEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 salesOrderId, IValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse, IPrefetchPath prefetchPathToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);

			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(salesOrderId, prefetchPathToUse, null);
			base.IsNew = !wasSuccesful;
			base.Validator = validator;
			base.EntityFactoryToUse = entityFactoryToUse;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

		}

		/// <summary> Initializes the class members</summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassMembers(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			_salesOrderDetail = new AW.Data.CollectionClasses.SalesOrderDetailCollection(propertyDescriptorFactoryToUse, new SalesOrderDetailEntityFactory());
			_salesOrderDetail.SetContainingEntityInfo(this, "SalesOrderHeader");
			_alwaysFetchSalesOrderDetail = false;
			_alreadyFetchedSalesOrderDetail = false;
			_specialOfferProductCollectionViaSalesOrderDetail = new AW.Data.CollectionClasses.SpecialOfferProductCollection(propertyDescriptorFactoryToUse, new SpecialOfferProductEntityFactory());
			_alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail = false;
			_alreadyFetchedSpecialOfferProductCollectionViaSalesOrderDetail = false;
			_address = null;
			_addressReturnsNewIfNotFound = true;
			_alwaysFetchAddress = false;
			_alreadyFetchedAddress = false;
			_address_ = null;
			_address_ReturnsNewIfNotFound = true;
			_alwaysFetchAddress_ = false;
			_alreadyFetchedAddress_ = false;
			_contact = null;
			_contactReturnsNewIfNotFound = true;
			_alwaysFetchContact = false;
			_alreadyFetchedContact = false;
			_customer = null;
			_customerReturnsNewIfNotFound = true;
			_alwaysFetchCustomer = false;
			_alreadyFetchedCustomer = false;
			_shipMethod = null;
			_shipMethodReturnsNewIfNotFound = true;
			_alwaysFetchShipMethod = false;
			_alreadyFetchedShipMethod = false;
			_customerView_ = null;
			_customerView_ReturnsNewIfNotFound = true;
			_alwaysFetchCustomerView_ = false;
			_alreadyFetchedCustomerView_ = false;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();

			Hashtable fieldHashtable = null;
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("SalesOrderId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("RevisionNumber", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("OrderDate", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("DueDate", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ShipDate", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Status", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("OnlineOrderFlag", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("SalesOrderNumber", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("PurchaseOrderNumber", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("AccountNumber", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ContactId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("SalesPersonId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("TerritoryId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("BillToAddressId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ShipToAddressId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ShipMethodId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CreditCardId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CreditCardApprovalCode", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CurrencyRateId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("TaxAmt", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Freight", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("TotalDue", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Comment", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _address</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncAddress(bool signalRelatedEntity)
		{
			if(_address != null)
			{

				_address.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Address", _address, SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId);
				if(signalRelatedEntity)
				{
					_address.UnsetRelatedEntity(this, "SalesOrderHeader");
				}
				SetNewFieldValue((int)SalesOrderHeaderFieldIndex.BillToAddressId, null, false);
				_address = null;
			}
		}
		
		/// <summary> Decouples events from member _address</summary>
		private void DecoupleEventsAddress()
		{
			if(_address != null)
			{

				
				_address.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Address", _address, SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId);
			}
		}
		
		/// <summary> setups the sync logic for member _address</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddress(IEntity relatedEntity)
		{
			DesetupSyncAddress(true);
			if(relatedEntity!=null)
			{
				_address = (AddressEntity)relatedEntity;
				_address.ActiveContext = base.ActiveContext;
				_alreadyFetchedAddress = true;
				_address.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Address", _address, SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId);

			}
			else
			{
				_alreadyFetchedAddress = false;
			}
		}

		/// <summary> Removes the sync logic for member _address_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncAddress_(bool signalRelatedEntity)
		{
			if(_address_ != null)
			{

				_address_.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Address_", _address_, SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId);
				if(signalRelatedEntity)
				{
					_address_.UnsetRelatedEntity(this, "SalesOrderHeader_");
				}
				SetNewFieldValue((int)SalesOrderHeaderFieldIndex.ShipToAddressId, null, false);
				_address_ = null;
			}
		}
		
		/// <summary> Decouples events from member _address_</summary>
		private void DecoupleEventsAddress_()
		{
			if(_address_ != null)
			{

				
				_address_.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Address_", _address_, SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId);
			}
		}
		
		/// <summary> setups the sync logic for member _address_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddress_(IEntity relatedEntity)
		{
			DesetupSyncAddress_(true);
			if(relatedEntity!=null)
			{
				_address_ = (AddressEntity)relatedEntity;
				_address_.ActiveContext = base.ActiveContext;
				_alreadyFetchedAddress_ = true;
				_address_.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Address_", _address_, SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId);

			}
			else
			{
				_alreadyFetchedAddress_ = false;
			}
		}

		/// <summary> Removes the sync logic for member _contact</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncContact(bool signalRelatedEntity)
		{
			if(_contact != null)
			{

				_contact.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Contact", _contact, SalesOrderHeaderEntity.Relations.ContactEntityUsingContactId);
				if(signalRelatedEntity)
				{
					_contact.UnsetRelatedEntity(this, "SalesOrderHeader");
				}
				SetNewFieldValue((int)SalesOrderHeaderFieldIndex.ContactId, null, false);
				_contact = null;
			}
		}
		
		/// <summary> Decouples events from member _contact</summary>
		private void DecoupleEventsContact()
		{
			if(_contact != null)
			{

				
				_contact.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Contact", _contact, SalesOrderHeaderEntity.Relations.ContactEntityUsingContactId);
			}
		}
		
		/// <summary> setups the sync logic for member _contact</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncContact(IEntity relatedEntity)
		{
			DesetupSyncContact(true);
			if(relatedEntity!=null)
			{
				_contact = (ContactEntity)relatedEntity;
				_contact.ActiveContext = base.ActiveContext;
				_alreadyFetchedContact = true;
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Contact", _contact, SalesOrderHeaderEntity.Relations.ContactEntityUsingContactId);

			}
			else
			{
				_alreadyFetchedContact = false;
			}
		}

		/// <summary> Removes the sync logic for member _customer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncCustomer(bool signalRelatedEntity)
		{
			if(_customer != null)
			{

				_customer.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Customer", _customer, SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId);
				if(signalRelatedEntity)
				{
					_customer.UnsetRelatedEntity(this, "SalesOrderHeader");
				}
				SetNewFieldValue((int)SalesOrderHeaderFieldIndex.CustomerId, null, false);
				_customer = null;
			}
		}
		
		/// <summary> Decouples events from member _customer</summary>
		private void DecoupleEventsCustomer()
		{
			if(_customer != null)
			{

				
				_customer.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Customer", _customer, SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId);
			}
		}
		
		/// <summary> setups the sync logic for member _customer</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomer(IEntity relatedEntity)
		{
			DesetupSyncCustomer(true);
			if(relatedEntity!=null)
			{
				_customer = (CustomerEntity)relatedEntity;
				_customer.ActiveContext = base.ActiveContext;
				_alreadyFetchedCustomer = true;
				_customer.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Customer", _customer, SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId);

			}
			else
			{
				_alreadyFetchedCustomer = false;
			}
		}

		/// <summary> Removes the sync logic for member _shipMethod</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncShipMethod(bool signalRelatedEntity)
		{
			if(_shipMethod != null)
			{

				_shipMethod.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("ShipMethod", _shipMethod, SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId);
				if(signalRelatedEntity)
				{
					_shipMethod.UnsetRelatedEntity(this, "SalesOrderHeader");
				}
				SetNewFieldValue((int)SalesOrderHeaderFieldIndex.ShipMethodId, null, false);
				_shipMethod = null;
			}
		}
		
		/// <summary> Decouples events from member _shipMethod</summary>
		private void DecoupleEventsShipMethod()
		{
			if(_shipMethod != null)
			{

				
				_shipMethod.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("ShipMethod", _shipMethod, SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId);
			}
		}
		
		/// <summary> setups the sync logic for member _shipMethod</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncShipMethod(IEntity relatedEntity)
		{
			DesetupSyncShipMethod(true);
			if(relatedEntity!=null)
			{
				_shipMethod = (ShipMethodEntity)relatedEntity;
				_shipMethod.ActiveContext = base.ActiveContext;
				_alreadyFetchedShipMethod = true;
				_shipMethod.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("ShipMethod", _shipMethod, SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId);

			}
			else
			{
				_alreadyFetchedShipMethod = false;
			}
		}

		/// <summary> Removes the sync logic for member _customerView_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncCustomerView_(bool signalRelatedEntity)
		{
			if(_customerView_ != null)
			{

				_customerView_.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("CustomerView_", _customerView_, SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerId);
				if(signalRelatedEntity)
				{
					_customerView_.UnsetRelatedEntity(this, "SalesOrderHeader");
				}
				SetNewFieldValue((int)SalesOrderHeaderFieldIndex.CustomerId, null, false);
				_customerView_ = null;
			}
		}
		
		/// <summary> Decouples events from member _customerView_</summary>
		private void DecoupleEventsCustomerView_()
		{
			if(_customerView_ != null)
			{

				
				_customerView_.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("CustomerView_", _customerView_, SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerId);
			}
		}
		
		/// <summary> setups the sync logic for member _customerView_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomerView_(IEntity relatedEntity)
		{
			DesetupSyncCustomerView_(true);
			if(relatedEntity!=null)
			{
				_customerView_ = (CustomerViewRelatedEntity)relatedEntity;
				_customerView_.ActiveContext = base.ActiveContext;
				_alreadyFetchedCustomerView_ = true;
				_customerView_.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("CustomerView_", _customerView_, SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerId);

			}
			else
			{
				_alreadyFetchedCustomerView_ = false;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 salesOrderId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)SalesOrderHeaderFieldIndex.SalesOrderId].ForcedCurrentValueWrite(salesOrderId);
				dao.FetchExisting(this, base.Transaction, prefetchPathToUse, contextToUse);
				bool fetchResult = false;
				if(base.Fields.State == EntityState.Fetched)
				{
					base.IsNew = false;
					fetchResult = true;
					if(contextToUse!=null)
					{
						base.ActiveContext = contextToUse;
						IEntity dummy = contextToUse.Get(this);
					}
				}
				return fetchResult;
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
			return DAOFactory.CreateSalesOrderHeaderDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactoryInstance()
		{
			return new SalesOrderHeaderEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SalesOrderHeaderRelations Relations
		{
			get	{ return new SalesOrderHeaderRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderDetail' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderDetail
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderDetailCollection(),
					SalesOrderHeaderEntity.Relations.SalesOrderDetailEntityUsingSalesOrderId, 
					(int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.SalesOrderDetailEntity, 0, null, null, null, "SalesOrderDetail", RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOfferProductCollectionViaSalesOrderDetail
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(SalesOrderHeaderEntity.Relations.SalesOrderDetailEntityUsingSalesOrderId);
				relations.Add(SalesOrderDetailEntity.Relations.SpecialOfferProductEntityUsingSpecialOfferIdProductId);
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferProductCollection(),
					SalesOrderHeaderEntity.Relations.SalesOrderDetailEntityUsingSalesOrderId,
					(int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.SpecialOfferProductEntity, 0, null, null, relations, "SpecialOfferProductCollectionViaSalesOrderDetail", RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddress
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(),
					SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId, 
					(int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, null, "Address", RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddress_
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(),
					SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId, 
					(int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, null, "Address_", RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContact
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(),
					SalesOrderHeaderEntity.Relations.ContactEntityUsingContactId, 
					(int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, null, "Contact", RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomer
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(),
					SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId, 
					(int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, null, "Customer", RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethod
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(),
					SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId, 
					(int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, null, "ShipMethod", RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerViewRelated' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerView_
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerViewRelatedCollection(),
					SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerId, 
					(int)AW.Data.EntityType.SalesOrderHeaderEntity, (int)AW.Data.EntityType.CustomerViewRelatedEntity, 0, null, null, null, "CustomerView_", RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return SalesOrderHeaderEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Hashtable FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Hashtable FieldsCustomPropertiesOfType
		{
			get { return SalesOrderHeaderEntity.FieldsCustomProperties;}
		}

		/// <summary> The SalesOrderId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SalesOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SalesOrderId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.SalesOrderId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.SalesOrderId, value); }
		}
		/// <summary> The RevisionNumber property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."RevisionNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte RevisionNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.RevisionNumber);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Byte));
				}
				return (System.Byte)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.RevisionNumber, value); }
		}
		/// <summary> The OrderDate property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."OrderDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime OrderDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.OrderDate);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.OrderDate, value); }
		}
		/// <summary> The DueDate property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."DueDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DueDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.DueDate);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.DueDate, value); }
		}
		/// <summary> The ShipDate property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ShipDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.DateTime ShipDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.ShipDate);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.ShipDate, value); }
		}
		/// <summary> The Status property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."Status"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte Status
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.Status);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Byte));
				}
				return (System.Byte)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.Status, value); }
		}
		/// <summary> The OnlineOrderFlag property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."OnlineOrderFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean OnlineOrderFlag
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.OnlineOrderFlag);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Boolean));
				}
				return (System.Boolean)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.OnlineOrderFlag, value); }
		}
		/// <summary> The SalesOrderNumber property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SalesOrderNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String SalesOrderNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.SalesOrderNumber);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.SalesOrderNumber, value); }
		}
		/// <summary> The PurchaseOrderNumber property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."PurchaseOrderNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PurchaseOrderNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber, value); }
		}
		/// <summary> The AccountNumber property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."AccountNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AccountNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.AccountNumber);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.AccountNumber, value); }
		}
		/// <summary> The CustomerId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CustomerId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.CustomerId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.CustomerId, value); }
		}
		/// <summary> The ContactId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ContactID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ContactId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.ContactId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.ContactId, value); }
		}
		/// <summary> The SalesPersonId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SalesPersonID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Int32 SalesPersonId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.SalesPersonId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.SalesPersonId, value); }
		}
		/// <summary> The TerritoryId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Int32 TerritoryId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.TerritoryId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.TerritoryId, value); }
		}
		/// <summary> The BillToAddressId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."BillToAddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 BillToAddressId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.BillToAddressId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.BillToAddressId, value); }
		}
		/// <summary> The ShipToAddressId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ShipToAddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ShipToAddressId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.ShipToAddressId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.ShipToAddressId, value); }
		}
		/// <summary> The ShipMethodId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ShipMethodID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ShipMethodId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.ShipMethodId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.ShipMethodId, value); }
		}
		/// <summary> The CreditCardId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CreditCardID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Int32 CreditCardId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.CreditCardId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.CreditCardId, value); }
		}
		/// <summary> The CreditCardApprovalCode property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CreditCardApprovalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CreditCardApprovalCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode, value); }
		}
		/// <summary> The CurrencyRateId property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CurrencyRateID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Int32 CurrencyRateId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.CurrencyRateId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.CurrencyRateId, value); }
		}
		/// <summary> The SubTotal property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SubTotal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SubTotal
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.SubTotal);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Decimal));
				}
				return (System.Decimal)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.SubTotal, value); }
		}
		/// <summary> The TaxAmt property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."TaxAmt"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TaxAmt
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.TaxAmt);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Decimal));
				}
				return (System.Decimal)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.TaxAmt, value); }
		}
		/// <summary> The Freight property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."Freight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Freight
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.Freight);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Decimal));
				}
				return (System.Decimal)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.Freight, value); }
		}
		/// <summary> The TotalDue property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."TotalDue"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TotalDue
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.TotalDue);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Decimal));
				}
				return (System.Decimal)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.TotalDue, value); }
		}
		/// <summary> The Comment property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."Comment"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 128<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Comment
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.Comment);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.Comment, value); }
		}
		/// <summary> The Rowguid property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Guid));
				}
				return (System.Guid)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.Rowguid, value); }
		}
		/// <summary> The ModifiedDate property of the Entity SalesOrderHeader<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)SalesOrderHeaderFieldIndex.ModifiedDate, value); }
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderDetailCollection SalesOrderDetail
		{
			get	{ return GetMultiSalesOrderDetail(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderDetail. When set to true, SalesOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderDetail is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesOrderDetail(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderDetail
		{
			get	{ return _alwaysFetchSalesOrderDetail; }
			set	{ _alwaysFetchSalesOrderDetail = value; }	
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOfferProductCollectionViaSalesOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SpecialOfferProductCollection SpecialOfferProductCollectionViaSalesOrderDetail
		{
			get { return GetMultiSpecialOfferProductCollectionViaSalesOrderDetail(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOfferProductCollectionViaSalesOrderDetail. When set to true, SpecialOfferProductCollectionViaSalesOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferProductCollectionViaSalesOrderDetail is accessed. You can always execute
		/// a forced fetch by calling GetMultiSpecialOfferProductCollectionViaSalesOrderDetail(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail
		{
			get	{ return _alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail; }
			set	{ _alwaysFetchSpecialOfferProductCollectionViaSalesOrderDetail = value; }	
		}

		/// <summary> Gets / sets related entity of type 'AddressEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AddressEntity Address
		{
			get	{ return GetSingleAddress(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAddress(value);
				}
				else
				{
					if(value==null)
					{
						if(_address != null)
						{
							_address.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Address. When set to true, Address is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address is accessed. You can always execute
		/// a forced fetch by calling GetSingleAddress(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddress
		{
			get	{ return _alwaysFetchAddress; }
			set	{ _alwaysFetchAddress = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Address is not found
		/// in the database. When set to true, Address will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool AddressReturnsNewIfNotFound
		{
			get	{ return _addressReturnsNewIfNotFound; }
			set { _addressReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'AddressEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAddress_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AddressEntity Address_
		{
			get	{ return GetSingleAddress_(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAddress_(value);
				}
				else
				{
					if(value==null)
					{
						if(_address_ != null)
						{
							_address_.UnsetRelatedEntity(this, "SalesOrderHeader_");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader_");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Address_. When set to true, Address_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address_ is accessed. You can always execute
		/// a forced fetch by calling GetSingleAddress_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAddress_
		{
			get	{ return _alwaysFetchAddress_; }
			set	{ _alwaysFetchAddress_ = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Address_ is not found
		/// in the database. When set to true, Address_ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool Address_ReturnsNewIfNotFound
		{
			get	{ return _address_ReturnsNewIfNotFound; }
			set { _address_ReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ContactEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ContactEntity Contact
		{
			get	{ return GetSingleContact(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncContact(value);
				}
				else
				{
					if(value==null)
					{
						if(_contact != null)
						{
							_contact.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Contact. When set to true, Contact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Contact is accessed. You can always execute
		/// a forced fetch by calling GetSingleContact(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContact
		{
			get	{ return _alwaysFetchContact; }
			set	{ _alwaysFetchContact = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Contact is not found
		/// in the database. When set to true, Contact will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ContactReturnsNewIfNotFound
		{
			get	{ return _contactReturnsNewIfNotFound; }
			set { _contactReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'CustomerEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CustomerEntity Customer
		{
			get	{ return GetSingleCustomer(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCustomer(value);
				}
				else
				{
					if(value==null)
					{
						if(_customer != null)
						{
							_customer.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Customer. When set to true, Customer is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Customer is accessed. You can always execute
		/// a forced fetch by calling GetSingleCustomer(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomer
		{
			get	{ return _alwaysFetchCustomer; }
			set	{ _alwaysFetchCustomer = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Customer is not found
		/// in the database. When set to true, Customer will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CustomerReturnsNewIfNotFound
		{
			get	{ return _customerReturnsNewIfNotFound; }
			set { _customerReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ShipMethodEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleShipMethod()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ShipMethodEntity ShipMethod
		{
			get	{ return GetSingleShipMethod(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncShipMethod(value);
				}
				else
				{
					if(value==null)
					{
						if(_shipMethod != null)
						{
							_shipMethod.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ShipMethod. When set to true, ShipMethod is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethod is accessed. You can always execute
		/// a forced fetch by calling GetSingleShipMethod(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShipMethod
		{
			get	{ return _alwaysFetchShipMethod; }
			set	{ _alwaysFetchShipMethod = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ShipMethod is not found
		/// in the database. When set to true, ShipMethod will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ShipMethodReturnsNewIfNotFound
		{
			get	{ return _shipMethodReturnsNewIfNotFound; }
			set { _shipMethodReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'CustomerViewRelatedEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomerView_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CustomerViewRelatedEntity CustomerView_
		{
			get	{ return GetSingleCustomerView_(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCustomerView_(value);
				}
				else
				{
					if(value==null)
					{
						if(_customerView_ != null)
						{
							_customerView_.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerView_. When set to true, CustomerView_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerView_ is accessed. You can always execute
		/// a forced fetch by calling GetSingleCustomerView_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerView_
		{
			get	{ return _alwaysFetchCustomerView_; }
			set	{ _alwaysFetchCustomerView_ = value; }	
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property CustomerView_ is not found
		/// in the database. When set to true, CustomerView_ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool CustomerView_ReturnsNewIfNotFound
		{
			get	{ return _customerView_ReturnsNewIfNotFound; }
			set { _customerView_ReturnsNewIfNotFound = value; }	
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
		
		/// <summary>Returns the EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AW.Data.EntityType.SalesOrderHeaderEntity; }
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
