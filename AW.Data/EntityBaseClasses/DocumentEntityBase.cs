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
	
	/// <summary>Entity base class which represents the base class for the entity 'Document'.<br/><br/>
	/// 
	/// MS_Description: Product maintenance documents.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class DocumentEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.ProductDocumentCollection	_productDocument;
		private bool	_alwaysFetchProductDocument, _alreadyFetchedProductDocument;
		private AW.Data.CollectionClasses.ProductCollection _productCollectionViaProductDocument;
		private bool	_alwaysFetchProductCollectionViaProductDocument, _alreadyFetchedProductCollectionViaProductDocument;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name ProductDocument</summary>
			public static readonly string ProductDocument = "ProductDocument";
			/// <summary>Member name ProductCollectionViaProductDocument</summary>
			public static readonly string ProductCollectionViaProductDocument = "ProductCollectionViaProductDocument";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DocumentEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public DocumentEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		public DocumentEntityBase(System.Int32 documentID)
		{
			InitClassFetch(documentID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public DocumentEntityBase(System.Int32 documentID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(documentID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <param name="validator">The custom validator object for this DocumentEntity</param>
		public DocumentEntityBase(System.Int32 documentID, IValidator validator)
		{
			InitClassFetch(documentID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DocumentEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_productDocument = (AW.Data.CollectionClasses.ProductDocumentCollection)info.GetValue("_productDocument", typeof(AW.Data.CollectionClasses.ProductDocumentCollection));
			_alwaysFetchProductDocument = info.GetBoolean("_alwaysFetchProductDocument");
			_alreadyFetchedProductDocument = info.GetBoolean("_alreadyFetchedProductDocument");
			_productCollectionViaProductDocument = (AW.Data.CollectionClasses.ProductCollection)info.GetValue("_productCollectionViaProductDocument", typeof(AW.Data.CollectionClasses.ProductCollection));
			_alwaysFetchProductCollectionViaProductDocument = info.GetBoolean("_alwaysFetchProductCollectionViaProductDocument");
			_alreadyFetchedProductCollectionViaProductDocument = info.GetBoolean("_alreadyFetchedProductCollectionViaProductDocument");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((DocumentFieldIndex)fieldIndex)
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
			_alreadyFetchedProductDocument = (_productDocument.Count > 0);
			_alreadyFetchedProductCollectionViaProductDocument = (_productCollectionViaProductDocument.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return DocumentEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "ProductDocument":
					toReturn.Add(DocumentEntity.Relations.ProductDocumentEntityUsingDocumentID);
					break;
				case "ProductCollectionViaProductDocument":
					toReturn.Add(DocumentEntity.Relations.ProductDocumentEntityUsingDocumentID, "DocumentEntity__", "ProductDocument_", JoinHint.None);
					toReturn.Add(ProductDocumentEntity.Relations.ProductEntityUsingProductID, "ProductDocument_", string.Empty, JoinHint.None);
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
			info.AddValue("_productDocument", (!this.MarkedForDeletion?_productDocument:null));
			info.AddValue("_alwaysFetchProductDocument", _alwaysFetchProductDocument);
			info.AddValue("_alreadyFetchedProductDocument", _alreadyFetchedProductDocument);
			info.AddValue("_productCollectionViaProductDocument", (!this.MarkedForDeletion?_productCollectionViaProductDocument:null));
			info.AddValue("_alwaysFetchProductCollectionViaProductDocument", _alwaysFetchProductCollectionViaProductDocument);
			info.AddValue("_alreadyFetchedProductCollectionViaProductDocument", _alreadyFetchedProductCollectionViaProductDocument);


			
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

				case "ProductDocument":
					_alreadyFetchedProductDocument = true;
					if(entity!=null)
					{
						this.ProductDocument.Add((ProductDocumentEntity)entity);
					}
					break;
				case "ProductCollectionViaProductDocument":
					_alreadyFetchedProductCollectionViaProductDocument = true;
					if(entity!=null)
					{
						this.ProductCollectionViaProductDocument.Add((ProductEntity)entity);
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

				case "ProductDocument":
					_productDocument.Add((ProductDocumentEntity)relatedEntity);
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

				case "ProductDocument":
					base.PerformRelatedEntityRemoval(_productDocument, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_productDocument);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 documentID)
		{
			return FetchUsingPK(documentID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 documentID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(documentID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 documentID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(documentID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 documentID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(documentID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.DocumentID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DocumentFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DocumentFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DocumentRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductDocumentEntity'</returns>
		public AW.Data.CollectionClasses.ProductDocumentCollection GetMultiProductDocument(bool forceFetch)
		{
			return GetMultiProductDocument(forceFetch, _productDocument.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductDocumentEntity'</returns>
		public AW.Data.CollectionClasses.ProductDocumentCollection GetMultiProductDocument(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProductDocument(forceFetch, _productDocument.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductDocumentCollection GetMultiProductDocument(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProductDocument(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.ProductDocumentCollection GetMultiProductDocument(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductDocument || forceFetch || _alwaysFetchProductDocument) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productDocument.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productDocument);
					}
				}
				_productDocument.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productDocument.EntityFactoryToUse = entityFactoryToUse;
				}
				_productDocument.GetMultiManyToOne(this, null, filter);
				_productDocument.SuppressClearInGetMulti=false;
				_alreadyFetchedProductDocument = true;
			}
			return _productDocument;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductDocument'. These settings will be taken into account
		/// when the property ProductDocument is requested or GetMultiProductDocument is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductDocument(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productDocument.SortClauses=sortClauses;
			_productDocument.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaProductDocument(bool forceFetch)
		{
			return GetMultiProductCollectionViaProductDocument(forceFetch, _productCollectionViaProductDocument.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ProductCollection GetMultiProductCollectionViaProductDocument(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductCollectionViaProductDocument || forceFetch || _alwaysFetchProductCollectionViaProductDocument) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_productCollectionViaProductDocument.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCollectionViaProductDocument);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(DocumentFields.DocumentID, ComparisonOperator.Equal, this.DocumentID, "DocumentEntity__"));
				_productCollectionViaProductDocument.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_productCollectionViaProductDocument.EntityFactoryToUse = entityFactoryToUse;
				}
				_productCollectionViaProductDocument.GetMulti(filter, GetRelationsForField("ProductCollectionViaProductDocument"));
				_productCollectionViaProductDocument.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCollectionViaProductDocument = true;
			}
			return _productCollectionViaProductDocument;
		}

		/// <summary> Sets the collection parameters for the collection for 'ProductCollectionViaProductDocument'. These settings will be taken into account
		/// when the property ProductCollectionViaProductDocument is requested or GetMultiProductCollectionViaProductDocument is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductCollectionViaProductDocument(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productCollectionViaProductDocument.SortClauses=sortClauses;
			_productCollectionViaProductDocument.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			DocumentDAO dao = (DocumentDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_productDocument.ActiveContext = base.ActiveContext;
			_productCollectionViaProductDocument.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			DocumentDAO dao = (DocumentDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			DocumentDAO dao = (DocumentDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.DocumentEntity);
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

			toReturn.Add("ProductDocument", _productDocument);
			toReturn.Add("ProductCollectionViaProductDocument", _productCollectionViaProductDocument);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <param name="validator">The validator object for this DocumentEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 documentID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(documentID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_productDocument = new AW.Data.CollectionClasses.ProductDocumentCollection(new ProductDocumentEntityFactory());
			_productDocument.SetContainingEntityInfo(this, "Document");
			_alwaysFetchProductDocument = false;
			_alreadyFetchedProductDocument = false;
			_productCollectionViaProductDocument = new AW.Data.CollectionClasses.ProductCollection(new ProductEntityFactory());
			_alwaysFetchProductCollectionViaProductDocument = false;
			_alreadyFetchedProductCollectionViaProductDocument = false;



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
			_customProperties.Add("MS_Description", @"Product maintenance documents.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("DocumentID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Title of the document.");
			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Directory path and file name of the document");
			_fieldsCustomProperties.Add("FileName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"File extension indicating the document type. For example, .doc or .txt.");
			_fieldsCustomProperties.Add("FileExtension", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Revision number of the document. ");
			_fieldsCustomProperties.Add("Revision", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Engineering change approval number.");
			_fieldsCustomProperties.Add("ChangeNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"1 = Pending approval, 2 = Approved, 3 = Obsolete");
			_fieldsCustomProperties.Add("Status", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Document abstract.");
			_fieldsCustomProperties.Add("DocumentSummary", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Complete document.");
			_fieldsCustomProperties.Add("Document", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 documentID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)DocumentFieldIndex.DocumentID].ForcedCurrentValueWrite(documentID);
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
			return DAOFactory.CreateDocumentDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new DocumentEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static DocumentRelations Relations
		{
			get	{ return new DocumentRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ProductDocument' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductDocument
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductDocumentCollection(),
					(IEntityRelation)GetRelationsForField("ProductDocument")[0], (int)AW.Data.EntityType.DocumentEntity, (int)AW.Data.EntityType.ProductDocumentEntity, 0, null, null, null, "ProductDocument", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProductCollectionViaProductDocument
		{
			get
			{
				IEntityRelation intermediateRelation = DocumentEntity.Relations.ProductDocumentEntityUsingDocumentID;
				intermediateRelation.SetAliases(string.Empty, "ProductDocument_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ProductCollection(), intermediateRelation,
					(int)AW.Data.EntityType.DocumentEntity, (int)AW.Data.EntityType.ProductEntity, 0, null, null, GetRelationsForField("ProductCollectionViaProductDocument"), "ProductCollectionViaProductDocument", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "DocumentEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DocumentEntity.CustomProperties;}
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
			get { return DocumentEntity.FieldsCustomProperties;}
		}

		/// <summary> The DocumentID property of the Entity Document<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Document"."DocumentID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 DocumentID
		{
			get { return (System.Int32)GetValue((int)DocumentFieldIndex.DocumentID, true); }
			set	{ SetValue((int)DocumentFieldIndex.DocumentID, value, true); }
		}
		/// <summary> The Title property of the Entity Document<br/><br/>
		/// 
		/// MS_Description: Title of the document.<br/></summary>
		/// <remarks>Mapped on  table field: "Document"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)DocumentFieldIndex.Title, true); }
			set	{ SetValue((int)DocumentFieldIndex.Title, value, true); }
		}
		/// <summary> The FileName property of the Entity Document<br/><br/>
		/// 
		/// MS_Description: Directory path and file name of the document<br/></summary>
		/// <remarks>Mapped on  table field: "Document"."FileName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 400<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FileName
		{
			get { return (System.String)GetValue((int)DocumentFieldIndex.FileName, true); }
			set	{ SetValue((int)DocumentFieldIndex.FileName, value, true); }
		}
		/// <summary> The FileExtension property of the Entity Document<br/><br/>
		/// 
		/// MS_Description: File extension indicating the document type. For example, .doc or .txt.<br/></summary>
		/// <remarks>Mapped on  table field: "Document"."FileExtension"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 8<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FileExtension
		{
			get { return (System.String)GetValue((int)DocumentFieldIndex.FileExtension, true); }
			set	{ SetValue((int)DocumentFieldIndex.FileExtension, value, true); }
		}
		/// <summary> The Revision property of the Entity Document<br/><br/>
		/// 
		/// MS_Description: Revision number of the document. <br/></summary>
		/// <remarks>Mapped on  table field: "Document"."Revision"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Revision
		{
			get { return (System.String)GetValue((int)DocumentFieldIndex.Revision, true); }
			set	{ SetValue((int)DocumentFieldIndex.Revision, value, true); }
		}
		/// <summary> The ChangeNumber property of the Entity Document<br/><br/>
		/// 
		/// MS_Description: Engineering change approval number.<br/></summary>
		/// <remarks>Mapped on  table field: "Document"."ChangeNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ChangeNumber
		{
			get { return (System.Int32)GetValue((int)DocumentFieldIndex.ChangeNumber, true); }
			set	{ SetValue((int)DocumentFieldIndex.ChangeNumber, value, true); }
		}
		/// <summary> The Status property of the Entity Document<br/><br/>
		/// 
		/// MS_Description: 1 = Pending approval, 2 = Approved, 3 = Obsolete<br/></summary>
		/// <remarks>Mapped on  table field: "Document"."Status"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte Status
		{
			get { return (System.Byte)GetValue((int)DocumentFieldIndex.Status, true); }
			set	{ SetValue((int)DocumentFieldIndex.Status, value, true); }
		}
		/// <summary> The DocumentSummary property of the Entity Document<br/><br/>
		/// 
		/// MS_Description: Document abstract.<br/></summary>
		/// <remarks>Mapped on  table field: "Document"."DocumentSummary"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String DocumentSummary
		{
			get { return (System.String)GetValue((int)DocumentFieldIndex.DocumentSummary, true); }
			set	{ SetValue((int)DocumentFieldIndex.DocumentSummary, value, true); }
		}
		/// <summary> The Document property of the Entity Document<br/><br/>
		/// 
		/// MS_Description: Complete document.<br/></summary>
		/// <remarks>Mapped on  table field: "Document"."Document"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarBinary, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] Document
		{
			get { return (System.Byte[])GetValue((int)DocumentFieldIndex.Document, true); }
			set	{ SetValue((int)DocumentFieldIndex.Document, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Document<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Document"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)DocumentFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)DocumentFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductDocument()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductDocumentCollection ProductDocument
		{
			get	{ return GetMultiProductDocument(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductDocument. When set to true, ProductDocument is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductDocument is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductDocument(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductDocument
		{
			get	{ return _alwaysFetchProductDocument; }
			set	{ _alwaysFetchProductDocument = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductDocument already has been fetched. Setting this property to false when ProductDocument has been fetched
		/// will clear the ProductDocument collection well. Setting this property to true while ProductDocument hasn't been fetched disables lazy loading for ProductDocument</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductDocument
		{
			get { return _alreadyFetchedProductDocument;}
			set 
			{
				if(_alreadyFetchedProductDocument && !value && (_productDocument != null))
				{
					_productDocument.Clear();
				}
				_alreadyFetchedProductDocument = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductCollectionViaProductDocument()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ProductCollection ProductCollectionViaProductDocument
		{
			get { return GetMultiProductCollectionViaProductDocument(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ProductCollectionViaProductDocument. When set to true, ProductCollectionViaProductDocument is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCollectionViaProductDocument is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductCollectionViaProductDocument(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCollectionViaProductDocument
		{
			get	{ return _alwaysFetchProductCollectionViaProductDocument; }
			set	{ _alwaysFetchProductCollectionViaProductDocument = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ProductCollectionViaProductDocument already has been fetched. Setting this property to false when ProductCollectionViaProductDocument has been fetched
		/// will clear the ProductCollectionViaProductDocument collection well. Setting this property to true while ProductCollectionViaProductDocument hasn't been fetched disables lazy loading for ProductCollectionViaProductDocument</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProductCollectionViaProductDocument
		{
			get { return _alreadyFetchedProductCollectionViaProductDocument;}
			set 
			{
				if(_alreadyFetchedProductCollectionViaProductDocument && !value && (_productCollectionViaProductDocument != null))
				{
					_productCollectionViaProductDocument.Clear();
				}
				_alreadyFetchedProductCollectionViaProductDocument = value;
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
			get { return (int)AW.Data.EntityType.DocumentEntity; }
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
