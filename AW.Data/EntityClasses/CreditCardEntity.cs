///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
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

	/// <summary>Entity class which represents the entity 'CreditCard'. <br/><br/>
	/// 
	/// MS_Description: Customer credit card information.<br/>
	/// </summary>
	[Serializable]
	public partial class CreditCardEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ContactCreditCardCollection	_contactCreditCards;
		private bool	_alwaysFetchContactCreditCards, _alreadyFetchedContactCreditCards;
		private AW.Data.CollectionClasses.SalesOrderHeaderCollection	_salesOrderHeaders;
		private bool	_alwaysFetchSalesOrderHeaders, _alreadyFetchedSalesOrderHeaders;
		private AW.Data.CollectionClasses.ContactCollection _contactCollectionViaContactCreditCard;
		private bool	_alwaysFetchContactCollectionViaContactCreditCard, _alreadyFetchedContactCollectionViaContactCreditCard;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ContactCreditCards</summary>
			public static readonly string ContactCreditCards = "ContactCreditCards";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name ContactCollectionViaContactCreditCard</summary>
			public static readonly string ContactCollectionViaContactCreditCard = "ContactCollectionViaContactCreditCard";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CreditCardEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CreditCardEntity() :base("CreditCardEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		public CreditCardEntity(System.Int32 creditCardID):base("CreditCardEntity")
		{
			InitClassFetch(creditCardID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CreditCardEntity(System.Int32 creditCardID, IPrefetchPath prefetchPathToUse):base("CreditCardEntity")
		{
			InitClassFetch(creditCardID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="validator">The custom validator object for this CreditCardEntity</param>
		public CreditCardEntity(System.Int32 creditCardID, IValidator validator):base("CreditCardEntity")
		{
			InitClassFetch(creditCardID, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CreditCardEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_contactCreditCards = (AW.Data.CollectionClasses.ContactCreditCardCollection)info.GetValue("_contactCreditCards", typeof(AW.Data.CollectionClasses.ContactCreditCardCollection));
			_alwaysFetchContactCreditCards = info.GetBoolean("_alwaysFetchContactCreditCards");
			_alreadyFetchedContactCreditCards = info.GetBoolean("_alreadyFetchedContactCreditCards");

			_salesOrderHeaders = (AW.Data.CollectionClasses.SalesOrderHeaderCollection)info.GetValue("_salesOrderHeaders", typeof(AW.Data.CollectionClasses.SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeaders = info.GetBoolean("_alwaysFetchSalesOrderHeaders");
			_alreadyFetchedSalesOrderHeaders = info.GetBoolean("_alreadyFetchedSalesOrderHeaders");
			_contactCollectionViaContactCreditCard = (AW.Data.CollectionClasses.ContactCollection)info.GetValue("_contactCollectionViaContactCreditCard", typeof(AW.Data.CollectionClasses.ContactCollection));
			_alwaysFetchContactCollectionViaContactCreditCard = info.GetBoolean("_alwaysFetchContactCollectionViaContactCreditCard");
			_alreadyFetchedContactCollectionViaContactCreditCard = info.GetBoolean("_alreadyFetchedContactCollectionViaContactCreditCard");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedContactCreditCards = (_contactCreditCards.Count > 0);
			_alreadyFetchedSalesOrderHeaders = (_salesOrderHeaders.Count > 0);
			_alreadyFetchedContactCollectionViaContactCreditCard = (_contactCollectionViaContactCreditCard.Count > 0);
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
				case "ContactCreditCards":
					toReturn.Add(Relations.ContactCreditCardEntityUsingCreditCardID);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingCreditCardID);
					break;
				case "ContactCollectionViaContactCreditCard":
					toReturn.Add(Relations.ContactCreditCardEntityUsingCreditCardID, "CreditCardEntity__", "ContactCreditCard_", JoinHint.None);
					toReturn.Add(ContactCreditCardEntity.Relations.ContactEntityUsingContactID, "ContactCreditCard_", string.Empty, JoinHint.None);
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
			info.AddValue("_contactCreditCards", (!this.MarkedForDeletion?_contactCreditCards:null));
			info.AddValue("_alwaysFetchContactCreditCards", _alwaysFetchContactCreditCards);
			info.AddValue("_alreadyFetchedContactCreditCards", _alreadyFetchedContactCreditCards);
			info.AddValue("_salesOrderHeaders", (!this.MarkedForDeletion?_salesOrderHeaders:null));
			info.AddValue("_alwaysFetchSalesOrderHeaders", _alwaysFetchSalesOrderHeaders);
			info.AddValue("_alreadyFetchedSalesOrderHeaders", _alreadyFetchedSalesOrderHeaders);
			info.AddValue("_contactCollectionViaContactCreditCard", (!this.MarkedForDeletion?_contactCollectionViaContactCreditCard:null));
			info.AddValue("_alwaysFetchContactCollectionViaContactCreditCard", _alwaysFetchContactCollectionViaContactCreditCard);
			info.AddValue("_alreadyFetchedContactCollectionViaContactCreditCard", _alreadyFetchedContactCollectionViaContactCreditCard);

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
				case "ContactCreditCards":
					_alreadyFetchedContactCreditCards = true;
					if(entity!=null)
					{
						this.ContactCreditCards.Add((ContactCreditCardEntity)entity);
					}
					break;
				case "SalesOrderHeaders":
					_alreadyFetchedSalesOrderHeaders = true;
					if(entity!=null)
					{
						this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					}
					break;
				case "ContactCollectionViaContactCreditCard":
					_alreadyFetchedContactCollectionViaContactCreditCard = true;
					if(entity!=null)
					{
						this.ContactCollectionViaContactCreditCard.Add((ContactEntity)entity);
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
				case "ContactCreditCards":
					_contactCreditCards.Add((ContactCreditCardEntity)relatedEntity);
					break;
				case "SalesOrderHeaders":
					_salesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
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
				case "ContactCreditCards":
					this.PerformRelatedEntityRemoval(_contactCreditCards, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeaders":
					this.PerformRelatedEntityRemoval(_salesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_contactCreditCards);
			toReturn.Add(_salesOrderHeaders);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 creditCardID)
		{
			return FetchUsingPK(creditCardID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 creditCardID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(creditCardID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 creditCardID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(creditCardID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 creditCardID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(creditCardID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CreditCardID, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CreditCardRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactCreditCardEntity'</returns>
		public AW.Data.CollectionClasses.ContactCreditCardCollection GetMultiContactCreditCards(bool forceFetch)
		{
			return GetMultiContactCreditCards(forceFetch, _contactCreditCards.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ContactCreditCardEntity'</returns>
		public AW.Data.CollectionClasses.ContactCreditCardCollection GetMultiContactCreditCards(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiContactCreditCards(forceFetch, _contactCreditCards.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCreditCardCollection GetMultiContactCreditCards(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiContactCreditCards(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ContactCreditCardCollection GetMultiContactCreditCards(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedContactCreditCards || forceFetch || _alwaysFetchContactCreditCards) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_contactCreditCards);
				_contactCreditCards.SuppressClearInGetMulti=!forceFetch;
				_contactCreditCards.EntityFactoryToUse = entityFactoryToUse;
				_contactCreditCards.GetMultiManyToOne(null, this, filter);
				_contactCreditCards.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCreditCards = true;
			}
			return _contactCreditCards;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactCreditCards'. These settings will be taken into account
		/// when the property ContactCreditCards is requested or GetMultiContactCreditCards is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCreditCards(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCreditCards.SortClauses=sortClauses;
			_contactCreditCards.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_salesOrderHeaders.GetMultiManyToOne(null, null, null, null, this, null, null, null, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactEntity'</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaContactCreditCard(bool forceFetch)
		{
			return GetMultiContactCollectionViaContactCreditCard(forceFetch, _contactCollectionViaContactCreditCard.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ContactCollection GetMultiContactCollectionViaContactCreditCard(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactCollectionViaContactCreditCard || forceFetch || _alwaysFetchContactCollectionViaContactCreditCard) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_contactCollectionViaContactCreditCard);
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(CreditCardFields.CreditCardID, ComparisonOperator.Equal, this.CreditCardID, "CreditCardEntity__"));
				_contactCollectionViaContactCreditCard.SuppressClearInGetMulti=!forceFetch;
				_contactCollectionViaContactCreditCard.EntityFactoryToUse = entityFactoryToUse;
				_contactCollectionViaContactCreditCard.GetMulti(filter, GetRelationsForField("ContactCollectionViaContactCreditCard"));
				_contactCollectionViaContactCreditCard.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCollectionViaContactCreditCard = true;
			}
			return _contactCollectionViaContactCreditCard;
		}

		/// <summary> Sets the collection parameters for the collection for 'ContactCollectionViaContactCreditCard'. These settings will be taken into account
		/// when the property ContactCollectionViaContactCreditCard is requested or GetMultiContactCollectionViaContactCreditCard is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCollectionViaContactCreditCard(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCollectionViaContactCreditCard.SortClauses=sortClauses;
			_contactCollectionViaContactCreditCard.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ContactCreditCards", _contactCreditCards);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("ContactCollectionViaContactCreditCard", _contactCollectionViaContactCreditCard);
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
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="validator">The validator object for this CreditCardEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 creditCardID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(creditCardID, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_contactCreditCards = new AW.Data.CollectionClasses.ContactCreditCardCollection();
			_contactCreditCards.SetContainingEntityInfo(this, "CreditCard");

			_salesOrderHeaders = new AW.Data.CollectionClasses.SalesOrderHeaderCollection();
			_salesOrderHeaders.SetContainingEntityInfo(this, "CreditCard");
			_contactCollectionViaContactCreditCard = new AW.Data.CollectionClasses.ContactCollection();
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
			_customProperties.Add("MS_Description", @"Customer credit card information.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Credit card number.");
			_fieldsCustomProperties.Add("CardNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Credit card name.");
			_fieldsCustomProperties.Add("CardType", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("CreditCardID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Credit card expiration month.");
			_fieldsCustomProperties.Add("ExpMonth", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Credit card expiration year.");
			_fieldsCustomProperties.Add("ExpYear", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 creditCardID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)CreditCardFieldIndex.CreditCardID].ForcedCurrentValueWrite(creditCardID);
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
			return DAOFactory.CreateCreditCardDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CreditCardEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CreditCardRelations Relations
		{
			get	{ return new CreditCardRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ContactCreditCard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCreditCards
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCreditCardCollection(), (IEntityRelation)GetRelationsForField("ContactCreditCards")[0], (int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.ContactCreditCardEntity, 0, null, null, null, "ContactCreditCards", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSalesOrderHeaders
		{
			get { return new PrefetchPathElement(new AW.Data.CollectionClasses.SalesOrderHeaderCollection(), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.SalesOrderHeaderEntity, 0, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Contact'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathContactCollectionViaContactCreditCard
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.ContactCreditCardEntityUsingCreditCardID;
				intermediateRelation.SetAliases(string.Empty, "ContactCreditCard_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ContactCollection(), intermediateRelation,	(int)AW.Data.EntityType.CreditCardEntity, (int)AW.Data.EntityType.ContactEntity, 0, null, null, GetRelationsForField("ContactCollectionViaContactCreditCard"), "ContactCollectionViaContactCreditCard", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
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

		/// <summary> The CardNumber property of the Entity CreditCard<br/><br/>
		/// MS_Description: Credit card number.<br/>Credit card number.</summary>
		/// <remarks>Mapped on  table field: "CreditCard"."CardNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CardNumber
		{
			get { return (System.String)GetValue((int)CreditCardFieldIndex.CardNumber, true); }
			set	{ SetValue((int)CreditCardFieldIndex.CardNumber, value, true); }
		}

		/// <summary> The CardType property of the Entity CreditCard<br/><br/>
		/// MS_Description: Credit card name.<br/>Credit card name.</summary>
		/// <remarks>Mapped on  table field: "CreditCard"."CardType"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CardType
		{
			get { return (System.String)GetValue((int)CreditCardFieldIndex.CardType, true); }
			set	{ SetValue((int)CreditCardFieldIndex.CardType, value, true); }
		}

		/// <summary> The CreditCardID property of the Entity CreditCard<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/>Clustered index created by a primary key constraint.</summary>
		/// <remarks>Mapped on  table field: "CreditCard"."CreditCardID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 CreditCardID
		{
			get { return (System.Int32)GetValue((int)CreditCardFieldIndex.CreditCardID, true); }
			set	{ SetValue((int)CreditCardFieldIndex.CreditCardID, value, true); }
		}

		/// <summary> The ExpMonth property of the Entity CreditCard<br/><br/>
		/// MS_Description: Credit card expiration month.<br/>Credit card expiration month.</summary>
		/// <remarks>Mapped on  table field: "CreditCard"."ExpMonth"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte ExpMonth
		{
			get { return (System.Byte)GetValue((int)CreditCardFieldIndex.ExpMonth, true); }
			set	{ SetValue((int)CreditCardFieldIndex.ExpMonth, value, true); }
		}

		/// <summary> The ExpYear property of the Entity CreditCard<br/><br/>
		/// MS_Description: Credit card expiration year.<br/>Credit card expiration year.</summary>
		/// <remarks>Mapped on  table field: "CreditCard"."ExpYear"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 ExpYear
		{
			get { return (System.Int16)GetValue((int)CreditCardFieldIndex.ExpYear, true); }
			set	{ SetValue((int)CreditCardFieldIndex.ExpYear, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity CreditCard<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/>Date and time the record was last updated.</summary>
		/// <remarks>Mapped on  table field: "CreditCard"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CreditCardFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CreditCardFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCreditCards()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCreditCardCollection ContactCreditCards
		{
			get	{ return GetMultiContactCreditCards(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCreditCards. When set to true, ContactCreditCards is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCreditCards is accessed. You can always execute/ a forced fetch by calling GetMultiContactCreditCards(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCreditCards
		{
			get	{ return _alwaysFetchContactCreditCards; }
			set	{ _alwaysFetchContactCreditCards = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactCreditCards already has been fetched. Setting this property to false when ContactCreditCards has been fetched
		/// will clear the ContactCreditCards collection well. Setting this property to true while ContactCreditCards hasn't been fetched disables lazy loading for ContactCreditCards</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactCreditCards
		{
			get { return _alreadyFetchedContactCreditCards;}
			set 
			{
				if(_alreadyFetchedContactCreditCards && !value && (_contactCreditCards != null))
				{
					_contactCreditCards.Clear();
				}
				_alreadyFetchedContactCreditCards = value;
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

		/// <summary> Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCollectionViaContactCreditCard()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ContactCollection ContactCollectionViaContactCreditCard
		{
			get { return GetMultiContactCollectionViaContactCreditCard(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ContactCollectionViaContactCreditCard. When set to true, ContactCollectionViaContactCreditCard is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCollectionViaContactCreditCard is accessed. You can always execute a forced fetch by calling GetMultiContactCollectionViaContactCreditCard(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCollectionViaContactCreditCard
		{
			get	{ return _alwaysFetchContactCollectionViaContactCreditCard; }
			set	{ _alwaysFetchContactCollectionViaContactCreditCard = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ContactCollectionViaContactCreditCard already has been fetched. Setting this property to false when ContactCollectionViaContactCreditCard has been fetched
		/// will clear the ContactCollectionViaContactCreditCard collection well. Setting this property to true while ContactCollectionViaContactCreditCard hasn't been fetched disables lazy loading for ContactCollectionViaContactCreditCard</summary>
		[Browsable(false)]
		public bool AlreadyFetchedContactCollectionViaContactCreditCard
		{
			get { return _alreadyFetchedContactCollectionViaContactCreditCard;}
			set 
			{
				if(_alreadyFetchedContactCollectionViaContactCreditCard && !value && (_contactCollectionViaContactCreditCard != null))
				{
					_contactCollectionViaContactCreditCard.Clear();
				}
				_alreadyFetchedContactCollectionViaContactCreditCard = value;
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
			get { return (int)AW.Data.EntityType.CreditCardEntity; }
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
