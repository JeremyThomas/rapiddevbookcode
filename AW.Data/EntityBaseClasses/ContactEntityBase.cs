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
	/// <summary>Entity base class which represents the base class for the entity 'Contact'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract partial class ContactEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.EmployeeCollection	_employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee;
		private AW.Data.CollectionClasses.IndividualCollection	_individual;
		private bool	_alwaysFetchIndividual, _alreadyFetchedIndividual;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaSalesOrderHeader_;
		private bool	_alwaysFetchAddressCollectionViaSalesOrderHeader_, _alreadyFetchedAddressCollectionViaSalesOrderHeader_;
		private AW.Data.CollectionClasses.AddressCollection _addressCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchAddressCollectionViaSalesOrderHeader, _alreadyFetchedAddressCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerCollection _customerCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCustomerCollectionViaSalesOrderHeader, _alreadyFetchedCustomerCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.CustomerViewRelatedCollection _customerViewRelatedCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader, _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader;
		private AW.Data.CollectionClasses.EmployeeCollection _employeeCollectionViaEmployee;
		private bool	_alwaysFetchEmployeeCollectionViaEmployee, _alreadyFetchedEmployeeCollectionViaEmployee;
		private AW.Data.CollectionClasses.ShipMethodCollection _shipMethodCollectionViaSalesOrderHeader;
		private bool	_alwaysFetchShipMethodCollectionViaSalesOrderHeader, _alreadyFetchedShipMethodCollectionViaSalesOrderHeader;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name Individual</summary>
			public static readonly string Individual = "Individual";
			/// <summary>Member name SalesOrderHeader</summary>
			public static readonly string SalesOrderHeader = "SalesOrderHeader";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader_</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader_ = "AddressCollectionViaSalesOrderHeader_";
			/// <summary>Member name AddressCollectionViaSalesOrderHeader</summary>
			public static readonly string AddressCollectionViaSalesOrderHeader = "AddressCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerCollectionViaSalesOrderHeader = "CustomerCollectionViaSalesOrderHeader";
			/// <summary>Member name CustomerViewRelatedCollectionViaSalesOrderHeader</summary>
			public static readonly string CustomerViewRelatedCollectionViaSalesOrderHeader = "CustomerViewRelatedCollectionViaSalesOrderHeader";
			/// <summary>Member name EmployeeCollectionViaEmployee</summary>
			public static readonly string EmployeeCollectionViaEmployee = "EmployeeCollectionViaEmployee";
			/// <summary>Member name ShipMethodCollectionViaSalesOrderHeader</summary>
			public static readonly string ShipMethodCollectionViaSalesOrderHeader = "ShipMethodCollectionViaSalesOrderHeader";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ContactEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ContactEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="contactId">PK value for Contact which data should be fetched into this Contact object</param>
		public ContactEntityBase(System.Int32 contactId)
		{
			InitClassFetch(contactId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="contactId">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ContactEntityBase(System.Int32 contactId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(contactId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="contactId">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="validator">The custom validator object for this ContactEntity</param>
		public ContactEntityBase(System.Int32 contactId, IValidator validator)
		{
			InitClassFetch(contactId, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ContactEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_employee = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_employee", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");
			_individual = (AW.Data.CollectionClasses.IndividualCollection)info.GetValue("_individual", typeof(AW.Data.CollectionClasses.IndividualCollection));
			_alwaysFetchIndividual = info.GetBoolean("_alwaysFetchIndividual");
			_alreadyFetchedIndividual = info.GetBoolean("_alreadyFetchedIndividual");
			_salesOrderHeader = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeader", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");
			_addressCollectionViaSalesOrderHeader_ = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaSalesOrderHeader_", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaSalesOrderHeader_ = info.GetBoolean("_alwaysFetchAddressCollectionViaSalesOrderHeader_");
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedAddressCollectionViaSalesOrderHeader_");
			_addressCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.AddressCollection)info.GetValue("_addressCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.AddressCollection));
			_alwaysFetchAddressCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchAddressCollectionViaSalesOrderHeader");
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedAddressCollectionViaSalesOrderHeader");
			_customerCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CustomerCollection)info.GetValue("_customerCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CustomerCollection));
			_alwaysFetchCustomerCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCustomerCollectionViaSalesOrderHeader");
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCustomerCollectionViaSalesOrderHeader");
			_customerViewRelatedCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.CustomerViewRelatedCollection)info.GetValue("_customerViewRelatedCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.CustomerViewRelatedCollection));
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader");
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader");
			_employeeCollectionViaEmployee = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaEmployee", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaEmployee = info.GetBoolean("_alwaysFetchEmployeeCollectionViaEmployee");
			_alreadyFetchedEmployeeCollectionViaEmployee = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaEmployee");
			_shipMethodCollectionViaSalesOrderHeader = (AW.Data.CollectionClasses.ShipMethodCollection)info.GetValue("_shipMethodCollectionViaSalesOrderHeader", typeof(AW.Data.CollectionClasses.ShipMethodCollection));
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader = info.GetBoolean("_alwaysFetchShipMethodCollectionViaSalesOrderHeader");
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = info.GetBoolean("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ContactFieldIndex)fieldIndex)
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
			_alreadyFetchedEmployee = (_employee.Count > 0);
			_alreadyFetchedIndividual = (_individual.Count > 0);
			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader.Count > 0);
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = (_addressCollectionViaSalesOrderHeader_.Count > 0);
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = (_addressCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = (_customerCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader = (_customerViewRelatedCollectionViaSalesOrderHeader.Count > 0);
			_alreadyFetchedEmployeeCollectionViaEmployee = (_employeeCollectionViaEmployee.Count > 0);
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = (_shipMethodCollectionViaSalesOrderHeader.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ContactEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "Employee":
					toReturn.Add(ContactEntity.Relations.EmployeeEntityUsingContactId);
					break;
				case "Individual":
					toReturn.Add(ContactEntity.Relations.IndividualEntityUsingContactId);
					break;
				case "SalesOrderHeader":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactId);
					break;
				case "AddressCollectionViaSalesOrderHeader_":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactId, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "AddressCollectionViaSalesOrderHeader":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactId, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactId, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactId, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.CustomerViewRelatedEntityUsingCustomerId, "SalesOrderHeader_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaEmployee":
					toReturn.Add(ContactEntity.Relations.EmployeeEntityUsingContactId, "ContactEntity__", "Employee_", JoinHint.None);
					toReturn.Add(EmployeeEntity.Relations.EmployeeEntityUsingManagerId, "Employee_", string.Empty, JoinHint.None);
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					toReturn.Add(ContactEntity.Relations.SalesOrderHeaderEntityUsingContactId, "ContactEntity__", "SalesOrderHeader_", JoinHint.None);
					toReturn.Add(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodId, "SalesOrderHeader_", string.Empty, JoinHint.None);
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
			info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_individual", (!this.MarkedForDeletion?_individual:null));
			info.AddValue("_alwaysFetchIndividual", _alwaysFetchIndividual);
			info.AddValue("_alreadyFetchedIndividual", _alreadyFetchedIndividual);
			info.AddValue("_salesOrderHeader", (!this.MarkedForDeletion?_salesOrderHeader:null));
			info.AddValue("_alwaysFetchSalesOrderHeader", _alwaysFetchSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesOrderHeader", _alreadyFetchedSalesOrderHeader);
			info.AddValue("_addressCollectionViaSalesOrderHeader_", (!this.MarkedForDeletion?_addressCollectionViaSalesOrderHeader_:null));
			info.AddValue("_alwaysFetchAddressCollectionViaSalesOrderHeader_", _alwaysFetchAddressCollectionViaSalesOrderHeader_);
			info.AddValue("_alreadyFetchedAddressCollectionViaSalesOrderHeader_", _alreadyFetchedAddressCollectionViaSalesOrderHeader_);
			info.AddValue("_addressCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_addressCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchAddressCollectionViaSalesOrderHeader", _alwaysFetchAddressCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedAddressCollectionViaSalesOrderHeader", _alreadyFetchedAddressCollectionViaSalesOrderHeader);
			info.AddValue("_customerCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_customerCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCustomerCollectionViaSalesOrderHeader", _alwaysFetchCustomerCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCustomerCollectionViaSalesOrderHeader", _alreadyFetchedCustomerCollectionViaSalesOrderHeader);
			info.AddValue("_customerViewRelatedCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_customerViewRelatedCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader", _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader", _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader);
			info.AddValue("_employeeCollectionViaEmployee", (!this.MarkedForDeletion?_employeeCollectionViaEmployee:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaEmployee", _alwaysFetchEmployeeCollectionViaEmployee);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaEmployee", _alreadyFetchedEmployeeCollectionViaEmployee);
			info.AddValue("_shipMethodCollectionViaSalesOrderHeader", (!this.MarkedForDeletion?_shipMethodCollectionViaSalesOrderHeader:null));
			info.AddValue("_alwaysFetchShipMethodCollectionViaSalesOrderHeader", _alwaysFetchShipMethodCollectionViaSalesOrderHeader);
			info.AddValue("_alreadyFetchedShipMethodCollectionViaSalesOrderHeader", _alreadyFetchedShipMethodCollectionViaSalesOrderHeader);


			
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

				case "Employee":
					_alreadyFetchedEmployee = true;
					if(entity!=null)
					{
						this.Employee.Add((EmployeeEntity)entity);
					}
					break;
				case "Individual":
					_alreadyFetchedIndividual = true;
					if(entity!=null)
					{
						this.Individual.Add((IndividualEntity)entity);
					}
					break;
				case "SalesOrderHeader":
					_alreadyFetchedSalesOrderHeader = true;
					if(entity!=null)
					{
						this.SalesOrderHeader.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "AddressCollectionViaSalesOrderHeader_":
					_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = true;
					if(entity!=null)
					{
						this.AddressCollectionViaSalesOrderHeader_.Add((AddressEntity)entity);
					}
					break;
				case "AddressCollectionViaSalesOrderHeader":
					_alreadyFetchedAddressCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.AddressCollectionViaSalesOrderHeader.Add((AddressEntity)entity);
					}
					break;
				case "CustomerCollectionViaSalesOrderHeader":
					_alreadyFetchedCustomerCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.CustomerCollectionViaSalesOrderHeader.Add((CustomerEntity)entity);
					}
					break;
				case "CustomerViewRelatedCollectionViaSalesOrderHeader":
					_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.CustomerViewRelatedCollectionViaSalesOrderHeader.Add((CustomerViewRelatedEntity)entity);
					}
					break;
				case "EmployeeCollectionViaEmployee":
					_alreadyFetchedEmployeeCollectionViaEmployee = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaEmployee.Add((EmployeeEntity)entity);
					}
					break;
				case "ShipMethodCollectionViaSalesOrderHeader":
					_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = true;
					if(entity!=null)
					{
						this.ShipMethodCollectionViaSalesOrderHeader.Add((ShipMethodEntity)entity);
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

				case "Employee":
					_employee.Add((EmployeeEntity)relatedEntity);
					break;
				case "Individual":
					_individual.Add((IndividualEntity)relatedEntity);
					break;
				case "SalesOrderHeader":
					_salesOrderHeader.Add((SalesOrderHeaderEntity)relatedEntity);
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

				case "Employee":
					base.PerformRelatedEntityRemoval(_employee, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Individual":
					base.PerformRelatedEntityRemoval(_individual, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeader":
					base.PerformRelatedEntityRemoval(_salesOrderHeader, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_employee);
			toReturn.Add(_individual);
			toReturn.Add(_salesOrderHeader);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactId">PK value for Contact which data should be fetched into this Contact object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactId)
		{
			return FetchUsingPK(contactId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactId">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(contactId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactId">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(contactId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="contactId">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(contactId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ContactId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ContactFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ContactFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ContactRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployee(bool forceFetch)
		{
			return GetMultiEmployee(forceFetch, _employee.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployee(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployee(forceFetch, _employee.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployee(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployee(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployee(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employee);
					}
				}
				_employee.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employee.EntityFactoryToUse = entityFactoryToUse;
				}
				_employee.GetMultiManyToOne(this, null, filter);
				_employee.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployee = true;
			}
			return _employee;
		}

		/// <summary> Sets the collection parameters for the collection for 'Employee'. These settings will be taken into account
		/// when the property Employee is requested or GetMultiEmployee is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployee(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employee.SortClauses=sortClauses;
			_employee.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'IndividualEntity'</returns>
		public AW.Data.CollectionClasses.IndividualCollection GetMultiIndividual(bool forceFetch)
		{
			return GetMultiIndividual(forceFetch, _individual.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'IndividualEntity'</returns>
		public AW.Data.CollectionClasses.IndividualCollection GetMultiIndividual(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiIndividual(forceFetch, _individual.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.IndividualCollection GetMultiIndividual(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiIndividual(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.IndividualCollection GetMultiIndividual(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedIndividual || forceFetch || _alwaysFetchIndividual) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_individual.ParticipatesInTransaction)
					{
						base.Transaction.Add(_individual);
					}
				}
				_individual.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_individual.EntityFactoryToUse = entityFactoryToUse;
				}
				_individual.GetMultiManyToOne(this, filter);
				_individual.SuppressClearInGetMulti=false;
				_alreadyFetchedIndividual = true;
			}
			return _individual;
		}

		/// <summary> Sets the collection parameters for the collection for 'Individual'. These settings will be taken into account
		/// when the property Individual is requested or GetMultiIndividual is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersIndividual(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_individual.SortClauses=sortClauses;
			_individual.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_salesOrderHeader.GetMultiManyToOne(null, null, this, null, null, null, filter);
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
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactId, ComparisonOperator.Equal, this.ContactId, "ContactEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactId, ComparisonOperator.Equal, this.ContactId, "ContactEntity__"));
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

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiCustomerCollectionViaSalesOrderHeader(forceFetch, _customerCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerCollection GetMultiCustomerCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchCustomerCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactId, ComparisonOperator.Equal, this.ContactId, "ContactEntity__"));
				_customerCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"));
				_customerCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerCollectionViaSalesOrderHeader = true;
			}
			return _customerCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property CustomerCollectionViaSalesOrderHeader is requested or GetMultiCustomerCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_customerCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerViewRelatedEntity'</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader(bool forceFetch)
		{
			return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader(forceFetch, _customerViewRelatedCollectionViaSalesOrderHeader.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.CustomerViewRelatedCollection GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader || forceFetch || _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_customerViewRelatedCollectionViaSalesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerViewRelatedCollectionViaSalesOrderHeader);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactId, ComparisonOperator.Equal, this.ContactId, "ContactEntity__"));
				_customerViewRelatedCollectionViaSalesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_customerViewRelatedCollectionViaSalesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				}
				_customerViewRelatedCollectionViaSalesOrderHeader.GetMulti(filter, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader"));
				_customerViewRelatedCollectionViaSalesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader = true;
			}
			return _customerViewRelatedCollectionViaSalesOrderHeader;
		}

		/// <summary> Sets the collection parameters for the collection for 'CustomerViewRelatedCollectionViaSalesOrderHeader'. These settings will be taken into account
		/// when the property CustomerViewRelatedCollectionViaSalesOrderHeader is requested or GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerViewRelatedCollectionViaSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerViewRelatedCollectionViaSalesOrderHeader.SortClauses=sortClauses;
			_customerViewRelatedCollectionViaSalesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaEmployee(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaEmployee(forceFetch, _employeeCollectionViaEmployee.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaEmployee(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaEmployee || forceFetch || _alwaysFetchEmployeeCollectionViaEmployee) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaEmployee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaEmployee);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactId, ComparisonOperator.Equal, this.ContactId, "ContactEntity__"));
				_employeeCollectionViaEmployee.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaEmployee.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaEmployee.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaEmployee"));
				_employeeCollectionViaEmployee.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaEmployee = true;
			}
			return _employeeCollectionViaEmployee;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaEmployee'. These settings will be taken into account
		/// when the property EmployeeCollectionViaEmployee is requested or GetMultiEmployeeCollectionViaEmployee is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaEmployee(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaEmployee.SortClauses=sortClauses;
			_employeeCollectionViaEmployee.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(ContactFields.ContactId, ComparisonOperator.Equal, this.ContactId, "ContactEntity__"));
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



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ContactDAO dao = (ContactDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_employee.ActiveContext = base.ActiveContext;
			_individual.ActiveContext = base.ActiveContext;
			_salesOrderHeader.ActiveContext = base.ActiveContext;
			_addressCollectionViaSalesOrderHeader_.ActiveContext = base.ActiveContext;
			_addressCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_customerCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_customerViewRelatedCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;
			_employeeCollectionViaEmployee.ActiveContext = base.ActiveContext;
			_shipMethodCollectionViaSalesOrderHeader.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ContactDAO dao = (ContactDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ContactDAO dao = (ContactDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ContactEntity);
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

			toReturn.Add("Employee", _employee);
			toReturn.Add("Individual", _individual);
			toReturn.Add("SalesOrderHeader", _salesOrderHeader);
			toReturn.Add("AddressCollectionViaSalesOrderHeader_", _addressCollectionViaSalesOrderHeader_);
			toReturn.Add("AddressCollectionViaSalesOrderHeader", _addressCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerCollectionViaSalesOrderHeader", _customerCollectionViaSalesOrderHeader);
			toReturn.Add("CustomerViewRelatedCollectionViaSalesOrderHeader", _customerViewRelatedCollectionViaSalesOrderHeader);
			toReturn.Add("EmployeeCollectionViaEmployee", _employeeCollectionViaEmployee);
			toReturn.Add("ShipMethodCollectionViaSalesOrderHeader", _shipMethodCollectionViaSalesOrderHeader);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="contactId">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="validator">The validator object for this ContactEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 contactId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(contactId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_employee = new AW.Data.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_employee.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
			_individual = new AW.Data.CollectionClasses.IndividualCollection(new IndividualEntityFactory());
			_individual.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchIndividual = false;
			_alreadyFetchedIndividual = false;
			_salesOrderHeader = new AW.Data.CollectionClasses.SalesOrderHeaderCollection(new SalesOrderHeaderEntityFactory());
			_salesOrderHeader.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchSalesOrderHeader = false;
			_alreadyFetchedSalesOrderHeader = false;
			_addressCollectionViaSalesOrderHeader_ = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaSalesOrderHeader_ = false;
			_alreadyFetchedAddressCollectionViaSalesOrderHeader_ = false;
			_addressCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.AddressCollection(new AddressEntityFactory());
			_alwaysFetchAddressCollectionViaSalesOrderHeader = false;
			_alreadyFetchedAddressCollectionViaSalesOrderHeader = false;
			_customerCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CustomerCollection(new CustomerEntityFactory());
			_alwaysFetchCustomerCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCustomerCollectionViaSalesOrderHeader = false;
			_customerViewRelatedCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.CustomerViewRelatedCollection(new CustomerViewRelatedEntityFactory());
			_alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader = false;
			_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader = false;
			_employeeCollectionViaEmployee = new AW.Data.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaEmployee = false;
			_alreadyFetchedEmployeeCollectionViaEmployee = false;
			_shipMethodCollectionViaSalesOrderHeader = new AW.Data.CollectionClasses.ShipMethodCollection(new ShipMethodEntityFactory());
			_alwaysFetchShipMethodCollectionViaSalesOrderHeader = false;
			_alreadyFetchedShipMethodCollectionViaSalesOrderHeader = false;



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

			_fieldsCustomProperties.Add("ContactId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NameStyle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("MiddleName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Suffix", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EmailAddress", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EmailPromotion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phone", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("PasswordHash", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("PasswordSalt", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AdditionalContactInfo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="contactId">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 contactId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ContactFieldIndex.ContactId].ForcedCurrentValueWrite(contactId);
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
			return DAOFactory.CreateContactDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ContactEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ContactRelations Relations
		{
			get	{ return new ContactRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("Individual")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.IndividualEntity, 0, null, null, null, "Individual", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("SalesOrderHeader")[0], (int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaSalesOrderHeader_
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader_"), "AddressCollectionViaSalesOrderHeader_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Address' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAddressCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.AddressCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.AddressEntity, 0, null, null, GetRelationsForField("AddressCollectionViaSalesOrderHeader"), "AddressCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Customer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.CustomerEntity, 0, null, null, GetRelationsForField("CustomerCollectionViaSalesOrderHeader"), "CustomerCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CustomerViewRelated' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCustomerViewRelatedCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.CustomerViewRelatedCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.CustomerViewRelatedEntity, 0, null, null, GetRelationsForField("CustomerViewRelatedCollectionViaSalesOrderHeader"), "CustomerViewRelatedCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaEmployee
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.EmployeeEntityUsingContactId;
				intermediateRelation.SetAliases(string.Empty, "Employee_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaEmployee"), "EmployeeCollectionViaEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ShipMethod' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShipMethodCollectionViaSalesOrderHeader
		{
			get
			{
				IEntityRelation intermediateRelation = ContactEntity.Relations.SalesOrderHeaderEntityUsingContactId;
				intermediateRelation.SetAliases(string.Empty, "SalesOrderHeader_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShipMethodCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ContactEntity, (int)AW.Data.EntityType.ShipMethodEntity, 0, null, null, GetRelationsForField("ShipMethodCollectionViaSalesOrderHeader"), "ShipMethodCollectionViaSalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ContactEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ContactEntity.CustomProperties;}
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
			get { return ContactEntity.FieldsCustomProperties;}
		}

		/// <summary> The ContactId property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."ContactID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ContactId
		{
			get { return (System.Int32)GetValue((int)ContactFieldIndex.ContactId, true); }
			set	{ SetValue((int)ContactFieldIndex.ContactId, value, true); }
		}
		/// <summary> The NameStyle property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."NameStyle"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean NameStyle
		{
			get { return (System.Boolean)GetValue((int)ContactFieldIndex.NameStyle, true); }
			set	{ SetValue((int)ContactFieldIndex.NameStyle, value, true); }
		}
		/// <summary> The Title property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 8<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.Title, true); }
			set	{ SetValue((int)ContactFieldIndex.Title, value, true); }
		}
		/// <summary> The FirstName property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.FirstName, true); }
			set	{ SetValue((int)ContactFieldIndex.FirstName, value, true); }
		}
		/// <summary> The MiddleName property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."MiddleName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MiddleName
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.MiddleName, true); }
			set	{ SetValue((int)ContactFieldIndex.MiddleName, value, true); }
		}
		/// <summary> The LastName property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.LastName, true); }
			set	{ SetValue((int)ContactFieldIndex.LastName, value, true); }
		}
		/// <summary> The Suffix property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."Suffix"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Suffix
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.Suffix, true); }
			set	{ SetValue((int)ContactFieldIndex.Suffix, value, true); }
		}
		/// <summary> The EmailAddress property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."EmailAddress"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EmailAddress
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.EmailAddress, true); }
			set	{ SetValue((int)ContactFieldIndex.EmailAddress, value, true); }
		}
		/// <summary> The EmailPromotion property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."EmailPromotion"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 EmailPromotion
		{
			get { return (System.Int32)GetValue((int)ContactFieldIndex.EmailPromotion, true); }
			set	{ SetValue((int)ContactFieldIndex.EmailPromotion, value, true); }
		}
		/// <summary> The Phone property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."Phone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.Phone, true); }
			set	{ SetValue((int)ContactFieldIndex.Phone, value, true); }
		}
		/// <summary> The PasswordHash property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."PasswordHash"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 40<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PasswordHash
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.PasswordHash, true); }
			set	{ SetValue((int)ContactFieldIndex.PasswordHash, value, true); }
		}
		/// <summary> The PasswordSalt property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."PasswordSalt"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PasswordSalt
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.PasswordSalt, true); }
			set	{ SetValue((int)ContactFieldIndex.PasswordSalt, value, true); }
		}
		/// <summary> The AdditionalContactInfo property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."AdditionalContactInfo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AdditionalContactInfo
		{
			get { return (System.String)GetValue((int)ContactFieldIndex.AdditionalContactInfo, true); }
			set	{ SetValue((int)ContactFieldIndex.AdditionalContactInfo, value, true); }
		}
		/// <summary> The Rowguid property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ContactFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ContactFieldIndex.Rowguid, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Contact<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Contact"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ContactFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ContactFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeCollection Employee
		{
			get	{ return GetMultiEmployee(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Employee. When set to true, Employee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee
		{
			get	{ return _alwaysFetchEmployee; }
			set	{ _alwaysFetchEmployee = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee already has been fetched. Setting this property to false when Employee has been fetched
		/// will clear the Employee collection well. Setting this property to true while Employee hasn't been fetched disables lazy loading for Employee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee
		{
			get { return _alreadyFetchedEmployee;}
			set 
			{
				if(_alreadyFetchedEmployee && !value && (_employee != null))
				{
					_employee.Clear();
				}
				_alreadyFetchedEmployee = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiIndividual()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.IndividualCollection Individual
		{
			get	{ return GetMultiIndividual(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Individual. When set to true, Individual is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Individual is accessed. You can always execute
		/// a forced fetch by calling GetMultiIndividual(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchIndividual
		{
			get	{ return _alwaysFetchIndividual; }
			set	{ _alwaysFetchIndividual = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Individual already has been fetched. Setting this property to false when Individual has been fetched
		/// will clear the Individual collection well. Setting this property to true while Individual hasn't been fetched disables lazy loading for Individual</summary>
		[Browsable(false)]
		public bool AlreadyFetchedIndividual
		{
			get { return _alreadyFetchedIndividual;}
			set 
			{
				if(_alreadyFetchedIndividual && !value && (_individual != null))
				{
					_individual.Clear();
				}
				_alreadyFetchedIndividual = value;
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
		/// <summary> Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerCollection CustomerCollectionViaSalesOrderHeader
		{
			get { return GetMultiCustomerCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerCollectionViaSalesOrderHeader. When set to true, CustomerCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchCustomerCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchCustomerCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when CustomerCollectionViaSalesOrderHeader has been fetched
		/// will clear the CustomerCollectionViaSalesOrderHeader collection well. Setting this property to true while CustomerCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for CustomerCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedCustomerCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedCustomerCollectionViaSalesOrderHeader && !value && (_customerCollectionViaSalesOrderHeader != null))
				{
					_customerCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedCustomerCollectionViaSalesOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'CustomerViewRelatedEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.CustomerViewRelatedCollection CustomerViewRelatedCollectionViaSalesOrderHeader
		{
			get { return GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CustomerViewRelatedCollectionViaSalesOrderHeader. When set to true, CustomerViewRelatedCollectionViaSalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerViewRelatedCollectionViaSalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerViewRelatedCollectionViaSalesOrderHeader(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader
		{
			get	{ return _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader; }
			set	{ _alwaysFetchCustomerViewRelatedCollectionViaSalesOrderHeader = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CustomerViewRelatedCollectionViaSalesOrderHeader already has been fetched. Setting this property to false when CustomerViewRelatedCollectionViaSalesOrderHeader has been fetched
		/// will clear the CustomerViewRelatedCollectionViaSalesOrderHeader collection well. Setting this property to true while CustomerViewRelatedCollectionViaSalesOrderHeader hasn't been fetched disables lazy loading for CustomerViewRelatedCollectionViaSalesOrderHeader</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader
		{
			get { return _alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader;}
			set 
			{
				if(_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader && !value && (_customerViewRelatedCollectionViaSalesOrderHeader != null))
				{
					_customerViewRelatedCollectionViaSalesOrderHeader.Clear();
				}
				_alreadyFetchedCustomerViewRelatedCollectionViaSalesOrderHeader = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeCollection EmployeeCollectionViaEmployee
		{
			get { return GetMultiEmployeeCollectionViaEmployee(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaEmployee. When set to true, EmployeeCollectionViaEmployee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaEmployee is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaEmployee
		{
			get	{ return _alwaysFetchEmployeeCollectionViaEmployee; }
			set	{ _alwaysFetchEmployeeCollectionViaEmployee = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaEmployee already has been fetched. Setting this property to false when EmployeeCollectionViaEmployee has been fetched
		/// will clear the EmployeeCollectionViaEmployee collection well. Setting this property to true while EmployeeCollectionViaEmployee hasn't been fetched disables lazy loading for EmployeeCollectionViaEmployee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaEmployee
		{
			get { return _alreadyFetchedEmployeeCollectionViaEmployee;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaEmployee && !value && (_employeeCollectionViaEmployee != null))
				{
					_employeeCollectionViaEmployee.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaEmployee = value;
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
			get { return (int)AW.Data.EntityType.ContactEntity; }
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
