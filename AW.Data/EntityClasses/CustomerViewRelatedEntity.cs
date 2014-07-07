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
  using AW.Data.TypedViewClasses;
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'CustomerViewRelated'. <br/><br/>
	/// 
	/// MS_Description: Individual customers (names and addresses) that purchase Adventure Works Cycles products online.<br/>
	/// </summary>
	[Serializable]
	public partial class CustomerViewRelatedEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
    ,IIndividualCustomer
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SalesOrderHeader</summary>
			public static readonly string SalesOrderHeader = "SalesOrderHeader";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CustomerViewRelatedEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CustomerViewRelatedEntity() :base("CustomerViewRelatedEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		public CustomerViewRelatedEntity(System.Int32 customerId):base("CustomerViewRelatedEntity")
		{
			InitClassFetch(customerId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CustomerViewRelatedEntity(System.Int32 customerId, IPrefetchPath prefetchPathToUse):base("CustomerViewRelatedEntity")
		{
			InitClassFetch(customerId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <param name="validator">The custom validator object for this CustomerViewRelatedEntity</param>
		public CustomerViewRelatedEntity(System.Int32 customerId, IValidator validator):base("CustomerViewRelatedEntity")
		{
			InitClassFetch(customerId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CustomerViewRelatedEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_salesOrderHeader = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeader", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader.Count > 0);
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
				case "SalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingCustomerID);
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
			info.AddValue("_salesOrderHeader", (!this.MarkedForDeletion?_salesOrderHeader:null));
			info.AddValue("_alwaysFetchSalesOrderHeader", _alwaysFetchSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesOrderHeader", _alreadyFetchedSalesOrderHeader);

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
				case "SalesOrderHeader":
					_alreadyFetchedSalesOrderHeader = true;
					if(entity!=null)
					{
						this.SalesOrderHeader.Add((SalesOrderHeaderEntity)entity);
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
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "SalesOrderHeader":
					this.PerformRelatedEntityRemoval(_salesOrderHeader, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_salesOrderHeader);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId)
		{
			return FetchUsingPK(customerId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(customerId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(customerId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
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

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CustomerId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CustomerViewRelatedRelations().GetAllRelations();
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
 			if( ( !_alreadyFetchedSalesOrderHeader || forceFetch || _alwaysFetchSalesOrderHeader) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_salesOrderHeader);
				_salesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, null, null, null, this, null, null, filter);
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


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("SalesOrderHeader", _salesOrderHeader);
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
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
		/// <param name="validator">The validator object for this CustomerViewRelatedEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 customerId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(customerId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_salesOrderHeader = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
			_salesOrderHeader.SetContainingEntityInfo(this, "CustomerViewRelated");
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
			_customProperties.Add("MS_Description", @"Individual customers (names and addresses) that purchase Adventure Works Cycles products online.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AddressLine1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AddressLine2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AddressType", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CountryRegionName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Demographics", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EmailAddress", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EmailPromotion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MiddleName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Phone", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PostalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StateProvinceName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Suffix", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Title", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="customerId">PK value for CustomerViewRelated which data should be fetched into this CustomerViewRelated object</param>
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
				this.Fields[(int)CustomerViewRelatedFieldIndex.CustomerId].ForcedCurrentValueWrite(customerId);
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
			return DAOFactory.CreateCustomerViewRelatedDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CustomerViewRelatedEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CustomerViewRelatedRelations Relations
		{
			get	{ return new CustomerViewRelatedRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeader
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeader")[0], (int)AW.Data.EntityType.CustomerViewRelatedEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
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

		/// <summary> The AddressLine1 property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."AddressLine1"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AddressLine1
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.AddressLine1, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.AddressLine1, value, true); }
		}

		/// <summary> The AddressLine2 property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."AddressLine2"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AddressLine2
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.AddressLine2, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.AddressLine2, value, true); }
		}

		/// <summary> The AddressType property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."AddressType"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AddressType
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.AddressType, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.AddressType, value, true); }
		}

		/// <summary> The City property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."City"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.City, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.City, value, true); }
		}

		/// <summary> The CountryRegionName property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."CountryRegionName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CountryRegionName
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.CountryRegionName, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.CountryRegionName, value, true); }
		}

		/// <summary> The CustomerId property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."CustomerID"<br/>
		/// View field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 CustomerId
		{
			get { return (System.Int32)GetValue((int)CustomerViewRelatedFieldIndex.CustomerId, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.CustomerId, value, true); }
		}

		/// <summary> The Demographics property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."Demographics"<br/>
		/// View field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Demographics
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.Demographics, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.Demographics, value, true); }
		}

		/// <summary> The EmailAddress property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."EmailAddress"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EmailAddress
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.EmailAddress, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.EmailAddress, value, true); }
		}

		/// <summary> The EmailPromotion property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."EmailPromotion"<br/>
		/// View field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual AW.Data.EmailPromotion EmailPromotion
		{
			get { return (AW.Data.EmailPromotion)GetValue((int)CustomerViewRelatedFieldIndex.EmailPromotion, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.EmailPromotion, value, true); }
		}

		/// <summary> The FirstName property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."FirstName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.FirstName, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.FirstName, value, true); }
		}

		/// <summary> The LastName property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."LastName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.LastName, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.LastName, value, true); }
		}

		/// <summary> The MiddleName property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."MiddleName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MiddleName
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.MiddleName, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.MiddleName, value, true); }
		}

		/// <summary> The Phone property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."Phone"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.Phone, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.Phone, value, true); }
		}

		/// <summary> The PostalCode property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."PostalCode"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.PostalCode, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.PostalCode, value, true); }
		}

		/// <summary> The StateProvinceName property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."StateProvinceName"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String StateProvinceName
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.StateProvinceName, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.StateProvinceName, value, true); }
		}

		/// <summary> The Suffix property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."Suffix"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Suffix
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.Suffix, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.Suffix, value, true); }
		}

		/// <summary> The Title property of the Entity CustomerViewRelated<br/><br/></summary>
		/// <remarks>Mapped on  view field: "vIndividualCustomer"."Title"<br/>
		/// View field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 8<br/>
		/// View field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)CustomerViewRelatedFieldIndex.Title, true); }
			set	{ SetValue((int)CustomerViewRelatedFieldIndex.Title, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SalesOrderHeaderCollection SalesOrderHeader
		{
			get	{ return GetMultiSalesOrderHeader(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SalesOrderHeader. When set to true, SalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeader is accessed. You can always execute/ a forced fetch by calling GetMultiSalesOrderHeader(true).</summary>
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
			get { return (int)AW.Data.EntityType.CustomerViewRelatedEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        public string DisplayName
        { 
            get { return this.LastName + ", " + this.FirstName; } 
        }
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
