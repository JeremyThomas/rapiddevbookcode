﻿///////////////////////////////////////////////////////////////
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

	/// <summary>Entity class which represents the entity 'SalesTaxRate'. <br/><br/>
	/// 
	/// MS_Description: Tax rate lookup table.<br/>
	/// </summary>
	[Serializable]
	public partial class SalesTaxRateEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
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
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesTaxRateEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SalesTaxRateEntity() :base("SalesTaxRateEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="salesTaxRateID">PK value for SalesTaxRate which data should be fetched into this SalesTaxRate object</param>
		public SalesTaxRateEntity(System.Int32 salesTaxRateID):base("SalesTaxRateEntity")
		{
			InitClassFetch(salesTaxRateID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="salesTaxRateID">PK value for SalesTaxRate which data should be fetched into this SalesTaxRate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesTaxRateEntity(System.Int32 salesTaxRateID, IPrefetchPath prefetchPathToUse):base("SalesTaxRateEntity")
		{
			InitClassFetch(salesTaxRateID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="salesTaxRateID">PK value for SalesTaxRate which data should be fetched into this SalesTaxRate object</param>
		/// <param name="validator">The custom validator object for this SalesTaxRateEntity</param>
		public SalesTaxRateEntity(System.Int32 salesTaxRateID, IValidator validator):base("SalesTaxRateEntity")
		{
			InitClassFetch(salesTaxRateID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesTaxRateEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
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
			switch((SalesTaxRateFieldIndex)fieldIndex)
			{
				case SalesTaxRateFieldIndex.StateProvinceID:
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


			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesTaxRateID">PK value for SalesTaxRate which data should be fetched into this SalesTaxRate object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesTaxRateID)
		{
			return FetchUsingPK(salesTaxRateID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesTaxRateID">PK value for SalesTaxRate which data should be fetched into this SalesTaxRate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesTaxRateID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(salesTaxRateID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesTaxRateID">PK value for SalesTaxRate which data should be fetched into this SalesTaxRate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesTaxRateID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(salesTaxRateID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="salesTaxRateID">PK value for SalesTaxRate which data should be fetched into this SalesTaxRate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesTaxRateID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(salesTaxRateID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.SalesTaxRateID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SalesTaxRateRelations().GetAllRelations();
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
		/// <param name="salesTaxRateID">PK value for SalesTaxRate which data should be fetched into this SalesTaxRate object</param>
		/// <param name="validator">The validator object for this SalesTaxRateEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 salesTaxRateID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(salesTaxRateID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
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
			_customProperties.Add("MS_Description", @"Tax rate lookup table.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Tax rate description.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.");
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("SalesTaxRateID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"State, province, or country/region the sales tax applies to.");
			_fieldsCustomProperties.Add("StateProvinceID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Tax rate amount.");
			_fieldsCustomProperties.Add("TaxRate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index. Used to support replication samples.");
			_fieldsCustomProperties.Add("TaxType", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _stateProvince</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStateProvince(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _stateProvince, new PropertyChangedEventHandler( OnStateProvincePropertyChanged ), "StateProvince", AW.Data.RelationClasses.StaticSalesTaxRateRelations.StateProvinceEntityUsingStateProvinceIDStatic, true, signalRelatedEntity, "SalesTaxRates", resetFKFields, new int[] { (int)SalesTaxRateFieldIndex.StateProvinceID } );		
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
				this.PerformSetupSyncRelatedEntity( _stateProvince, new PropertyChangedEventHandler( OnStateProvincePropertyChanged ), "StateProvince", AW.Data.RelationClasses.StaticSalesTaxRateRelations.StateProvinceEntityUsingStateProvinceIDStatic, true, ref _alreadyFetchedStateProvince, new string[] {  } );
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
		/// <param name="salesTaxRateID">PK value for SalesTaxRate which data should be fetched into this SalesTaxRate object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 salesTaxRateID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)SalesTaxRateFieldIndex.SalesTaxRateID].ForcedCurrentValueWrite(salesTaxRateID);
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
			return DAOFactory.CreateSalesTaxRateDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new SalesTaxRateEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SalesTaxRateRelations Relations
		{
			get	{ return new SalesTaxRateRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'StateProvince'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStateProvince
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.StateProvinceCollection(), (IEntityRelation)GetRelationsForField("StateProvince")[0], (int)AW.Data.EntityType.SalesTaxRateEntity, (int)AW.Data.EntityType.StateProvinceEntity, 0, null, null, null, "StateProvince", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The ModifiedDate property of the Entity SalesTaxRate<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesTaxRateFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The Name property of the Entity SalesTaxRate<br/><br/>
		/// MS_Description: Tax rate description.<br/>Tax rate description.</summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)SalesTaxRateFieldIndex.Name, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.Name, value, true); }
		}

		/// <summary> The Rowguid property of the Entity SalesTaxRate<br/><br/>
		/// MS_Description: ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.<br/>ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesTaxRateFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.Rowguid, value, true); }
		}

		/// <summary> The SalesTaxRateID property of the Entity SalesTaxRate<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."SalesTaxRateID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SalesTaxRateID
		{
			get { return (System.Int32)GetValue((int)SalesTaxRateFieldIndex.SalesTaxRateID, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.SalesTaxRateID, value, true); }
		}

		/// <summary> The StateProvinceID property of the Entity SalesTaxRate<br/><br/>
		/// MS_Description: State, province, or country/region the sales tax applies to.<br/>State, province, or country/region the sales tax applies to.</summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."StateProvinceID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StateProvinceID
		{
			get { return (System.Int32)GetValue((int)SalesTaxRateFieldIndex.StateProvinceID, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.StateProvinceID, value, true); }
		}

		/// <summary> The TaxRate property of the Entity SalesTaxRate<br/><br/>
		/// MS_Description: Tax rate amount.<br/>Tax rate amount.</summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."TaxRate"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TaxRate
		{
			get { return (System.Decimal)GetValue((int)SalesTaxRateFieldIndex.TaxRate, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.TaxRate, value, true); }
		}

		/// <summary> The TaxType property of the Entity SalesTaxRate<br/><br/>
		/// MS_Description: Unique nonclustered index. Used to support replication samples.<br/>Unique nonclustered index. Used to support replication samples.</summary>
		/// <remarks>Mapped on  table field: "SalesTaxRate"."TaxType"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte TaxType
		{
			get { return (System.Byte)GetValue((int)SalesTaxRateFieldIndex.TaxType, true); }
			set	{ SetValue((int)SalesTaxRateFieldIndex.TaxType, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'StateProvinceEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleStateProvince()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
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
					SetSingleRelatedEntityNavigator(value, "SalesTaxRates", "StateProvince", _stateProvince, true); 
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
			get { return (int)AW.Data.EntityType.SalesTaxRateEntity; }
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
