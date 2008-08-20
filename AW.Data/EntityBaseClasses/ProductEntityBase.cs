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
	/// <summary>Entity base class which represents the base class for the entity 'Product'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract class ProductEntityBase : EntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.SpecialOfferProductCollection	_specialOfferProduct;
		private bool	_alwaysFetchSpecialOfferProduct, _alreadyFetchedSpecialOfferProduct;
		private AW.Data.CollectionClasses.SpecialOfferCollection _specialOfferCollectionViaSpecialOfferProduct;
		private bool	_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct, _alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct;


		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region DataBinding Change Event Handler Declarations
		/// <summary>Event which is thrown when ProductId changes value. Databinding related.</summary>
		public event EventHandler ProductIdChanged;
		/// <summary>Event which is thrown when Name changes value. Databinding related.</summary>
		public event EventHandler NameChanged;
		/// <summary>Event which is thrown when ProductNumber changes value. Databinding related.</summary>
		public event EventHandler ProductNumberChanged;
		/// <summary>Event which is thrown when MakeFlag changes value. Databinding related.</summary>
		public event EventHandler MakeFlagChanged;
		/// <summary>Event which is thrown when FinishedGoodsFlag changes value. Databinding related.</summary>
		public event EventHandler FinishedGoodsFlagChanged;
		/// <summary>Event which is thrown when Color changes value. Databinding related.</summary>
		public event EventHandler ColorChanged;
		/// <summary>Event which is thrown when SafetyStockLevel changes value. Databinding related.</summary>
		public event EventHandler SafetyStockLevelChanged;
		/// <summary>Event which is thrown when ReorderPoint changes value. Databinding related.</summary>
		public event EventHandler ReorderPointChanged;
		/// <summary>Event which is thrown when StandardCost changes value. Databinding related.</summary>
		public event EventHandler StandardCostChanged;
		/// <summary>Event which is thrown when ListPrice changes value. Databinding related.</summary>
		public event EventHandler ListPriceChanged;
		/// <summary>Event which is thrown when Size changes value. Databinding related.</summary>
		public event EventHandler SizeChanged;
		/// <summary>Event which is thrown when SizeUnitMeasureCode changes value. Databinding related.</summary>
		public event EventHandler SizeUnitMeasureCodeChanged;
		/// <summary>Event which is thrown when WeightUnitMeasureCode changes value. Databinding related.</summary>
		public event EventHandler WeightUnitMeasureCodeChanged;
		/// <summary>Event which is thrown when Weight changes value. Databinding related.</summary>
		public event EventHandler WeightChanged;
		/// <summary>Event which is thrown when DaysToManufacture changes value. Databinding related.</summary>
		public event EventHandler DaysToManufactureChanged;
		/// <summary>Event which is thrown when ProductLine changes value. Databinding related.</summary>
		public event EventHandler ProductLineChanged;
		/// <summary>Event which is thrown when Class changes value. Databinding related.</summary>
		public event EventHandler ClassChanged;
		/// <summary>Event which is thrown when Style changes value. Databinding related.</summary>
		public event EventHandler StyleChanged;
		/// <summary>Event which is thrown when ProductSubcategoryId changes value. Databinding related.</summary>
		public event EventHandler ProductSubcategoryIdChanged;
		/// <summary>Event which is thrown when ProductModelId changes value. Databinding related.</summary>
		public event EventHandler ProductModelIdChanged;
		/// <summary>Event which is thrown when SellStartDate changes value. Databinding related.</summary>
		public event EventHandler SellStartDateChanged;
		/// <summary>Event which is thrown when SellEndDate changes value. Databinding related.</summary>
		public event EventHandler SellEndDateChanged;
		/// <summary>Event which is thrown when DiscontinuedDate changes value. Databinding related.</summary>
		public event EventHandler DiscontinuedDateChanged;
		/// <summary>Event which is thrown when Rowguid changes value. Databinding related.</summary>
		public event EventHandler RowguidChanged;
		/// <summary>Event which is thrown when ModifiedDate changes value. Databinding related.</summary>
		public event EventHandler ModifiedDateChanged;

		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductEntityBase()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), CreateValidator());
		}

	
		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		public ProductEntityBase(System.Int32 productId)
		{
			InitClassFetch(productId, CreateValidator(), new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductEntityBase(System.Int32 productId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(productId, CreateValidator(), new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntityBase(System.Int32 productId, ProductValidator validator)
		{
			InitClassFetch(productId, validator, new PropertyDescriptorFactory(), CreateEntityFactoryInstance(), null);
		}

		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductEntityBase(System.Int32 productId, ProductValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(productId, validator, propertyDescriptorFactoryToUse, entityFactoryToUse, null);
		}
	

		/// <summary>CTor</summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductEntityBase(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse, CreateValidator());
		}

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_specialOfferProduct = (AW.Data.CollectionClasses.SpecialOfferProductCollection)info.GetValue("_specialOfferProduct", typeof(AW.Data.CollectionClasses.SpecialOfferProductCollection));
			_alwaysFetchSpecialOfferProduct = info.GetBoolean("_alwaysFetchSpecialOfferProduct");
			_alreadyFetchedSpecialOfferProduct = info.GetBoolean("_alreadyFetchedSpecialOfferProduct");
			_specialOfferCollectionViaSpecialOfferProduct = (AW.Data.CollectionClasses.SpecialOfferCollection)info.GetValue("_specialOfferCollectionViaSpecialOfferProduct", typeof(AW.Data.CollectionClasses.SpecialOfferCollection));
			_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct = info.GetBoolean("_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct");
			_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = info.GetBoolean("_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct");


			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary> Will perform post-ReadXml actions as well as the normal ReadXml() actions, performed by the base class.</summary>
		/// <param name="node">XmlNode with Xml data which should be read into this entity and its members. Node's root element is the root element of the entity's Xml data</param>
		public override void ReadXml(System.Xml.XmlNode node)
		{
			base.ReadXml (node);
			_alreadyFetchedSpecialOfferProduct = (_specialOfferProduct.Count > 0);
			_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = (_specialOfferCollectionViaSpecialOfferProduct.Count > 0);


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
			info.AddValue("_specialOfferProduct", _specialOfferProduct);
			info.AddValue("_alwaysFetchSpecialOfferProduct", _alwaysFetchSpecialOfferProduct);
			info.AddValue("_alreadyFetchedSpecialOfferProduct", _alreadyFetchedSpecialOfferProduct);
			info.AddValue("_specialOfferCollectionViaSpecialOfferProduct", _specialOfferCollectionViaSpecialOfferProduct);
			info.AddValue("_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct", _alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct);
			info.AddValue("_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct", _alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct);


			
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

				case "SpecialOfferProduct":
					_alreadyFetchedSpecialOfferProduct = true;
					if(entity!=null)
					{
						this.SpecialOfferProduct.Add((SpecialOfferProductEntity)entity);
					}
					break;
				case "SpecialOfferCollectionViaSpecialOfferProduct":
					_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = true;
					if(entity!=null)
					{
						this.SpecialOfferCollectionViaSpecialOfferProduct.Add((SpecialOfferEntity)entity);
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

				case "SpecialOfferProduct":
					_specialOfferProduct.Add(relatedEntity);
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

				case "SpecialOfferProduct":
					_specialOfferProduct.Remove(relatedEntity);
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



			return toReturn;
		}
		
		/// <summary> Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override ArrayList GetMemberEntityCollections()
		{
			ArrayList toReturn = new ArrayList();
			toReturn.Add(_specialOfferProduct);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId)
		{
			return FetchUsingPK(productId, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productId, prefetchPathToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(productId, prefetchPathToUse, contextToUse);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductId, null, null);
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
		public bool TestOriginalFieldValueForNull(ProductFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ProductFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}
		
		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("ProductEntity", ((AW.Data.EntityType)typeOfEntity).ToString());
		}


		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch)
		{
			return GetMultiSpecialOfferProduct(forceFetch, _specialOfferProduct.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSpecialOfferProduct(forceFetch, _specialOfferProduct.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSpecialOfferProduct(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSpecialOfferProduct || forceFetch || _alwaysFetchSpecialOfferProduct) && !base.IsSerializing && !base.IsDeserializing && !EntityCollectionBase.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferProduct);
					}
				}
				_specialOfferProduct.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_specialOfferProduct.EntityFactoryToUse = entityFactoryToUse;
				}
				_specialOfferProduct.GetMultiManyToOne(this, null, filter);
				_specialOfferProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferProduct = true;
			}
			return _specialOfferProduct;
		}

		/// <summary> Sets the collection parameters for the collection for 'SpecialOfferProduct'. These settings will be taken into account
		/// when the property SpecialOfferProduct is requested or GetMultiSpecialOfferProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOfferProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOfferProduct.SortClauses=sortClauses;
			_specialOfferProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferEntity'</returns>
		public AW.Data.CollectionClasses.SpecialOfferCollection GetMultiSpecialOfferCollectionViaSpecialOfferProduct(bool forceFetch)
		{
			return GetMultiSpecialOfferCollectionViaSpecialOfferProduct(forceFetch, _specialOfferCollectionViaSpecialOfferProduct.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.SpecialOfferCollection GetMultiSpecialOfferCollectionViaSpecialOfferProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct || forceFetch || _alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct) && !base.IsSerializing && !base.IsDeserializing && !EntityCollectionBase.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferCollectionViaSpecialOfferProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferCollectionViaSpecialOfferProduct);
					}
				}
				IRelationCollection relations = new RelationCollection();
				IPredicateExpression filter = new PredicateExpression();
				relations.Add(ProductEntity.Relations.SpecialOfferProductEntityUsingProductId, "SpecialOfferProduct_");
				relations.Add(SpecialOfferProductEntity.Relations.SpecialOfferEntityUsingSpecialOfferId, "SpecialOfferProduct_", string.Empty, JoinHint.None);
				filter.Add(new FieldCompareValuePredicate(EntityFieldFactory.Create(ProductFieldIndex.ProductId), ComparisonOperator.Equal, this.ProductId));
				_specialOfferCollectionViaSpecialOfferProduct.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_specialOfferCollectionViaSpecialOfferProduct.EntityFactoryToUse = entityFactoryToUse;
				}
				_specialOfferCollectionViaSpecialOfferProduct.GetMulti(filter, relations);
				_specialOfferCollectionViaSpecialOfferProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = true;
			}
			return _specialOfferCollectionViaSpecialOfferProduct;
		}

		/// <summary> Sets the collection parameters for the collection for 'SpecialOfferCollectionViaSpecialOfferProduct'. These settings will be taken into account
		/// when the property SpecialOfferCollectionViaSpecialOfferProduct is requested or GetMultiSpecialOfferCollectionViaSpecialOfferProduct is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOfferCollectionViaSpecialOfferProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOfferCollectionViaSpecialOfferProduct.SortClauses=sortClauses;
			_specialOfferCollectionViaSpecialOfferProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


	
		#region Data binding change event raising methods

		/// <summary> Event thrower for the ProductIdChanged event, which is thrown when ProductId changes value. Databinding related.</summary>
		protected virtual void OnProductIdChanged()
		{
			if(ProductIdChanged!=null)
			{
				ProductIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the NameChanged event, which is thrown when Name changes value. Databinding related.</summary>
		protected virtual void OnNameChanged()
		{
			if(NameChanged!=null)
			{
				NameChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ProductNumberChanged event, which is thrown when ProductNumber changes value. Databinding related.</summary>
		protected virtual void OnProductNumberChanged()
		{
			if(ProductNumberChanged!=null)
			{
				ProductNumberChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the MakeFlagChanged event, which is thrown when MakeFlag changes value. Databinding related.</summary>
		protected virtual void OnMakeFlagChanged()
		{
			if(MakeFlagChanged!=null)
			{
				MakeFlagChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the FinishedGoodsFlagChanged event, which is thrown when FinishedGoodsFlag changes value. Databinding related.</summary>
		protected virtual void OnFinishedGoodsFlagChanged()
		{
			if(FinishedGoodsFlagChanged!=null)
			{
				FinishedGoodsFlagChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ColorChanged event, which is thrown when Color changes value. Databinding related.</summary>
		protected virtual void OnColorChanged()
		{
			if(ColorChanged!=null)
			{
				ColorChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the SafetyStockLevelChanged event, which is thrown when SafetyStockLevel changes value. Databinding related.</summary>
		protected virtual void OnSafetyStockLevelChanged()
		{
			if(SafetyStockLevelChanged!=null)
			{
				SafetyStockLevelChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ReorderPointChanged event, which is thrown when ReorderPoint changes value. Databinding related.</summary>
		protected virtual void OnReorderPointChanged()
		{
			if(ReorderPointChanged!=null)
			{
				ReorderPointChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the StandardCostChanged event, which is thrown when StandardCost changes value. Databinding related.</summary>
		protected virtual void OnStandardCostChanged()
		{
			if(StandardCostChanged!=null)
			{
				StandardCostChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ListPriceChanged event, which is thrown when ListPrice changes value. Databinding related.</summary>
		protected virtual void OnListPriceChanged()
		{
			if(ListPriceChanged!=null)
			{
				ListPriceChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the SizeChanged event, which is thrown when Size changes value. Databinding related.</summary>
		protected virtual void OnSizeChanged()
		{
			if(SizeChanged!=null)
			{
				SizeChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the SizeUnitMeasureCodeChanged event, which is thrown when SizeUnitMeasureCode changes value. Databinding related.</summary>
		protected virtual void OnSizeUnitMeasureCodeChanged()
		{
			if(SizeUnitMeasureCodeChanged!=null)
			{
				SizeUnitMeasureCodeChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the WeightUnitMeasureCodeChanged event, which is thrown when WeightUnitMeasureCode changes value. Databinding related.</summary>
		protected virtual void OnWeightUnitMeasureCodeChanged()
		{
			if(WeightUnitMeasureCodeChanged!=null)
			{
				WeightUnitMeasureCodeChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the WeightChanged event, which is thrown when Weight changes value. Databinding related.</summary>
		protected virtual void OnWeightChanged()
		{
			if(WeightChanged!=null)
			{
				WeightChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the DaysToManufactureChanged event, which is thrown when DaysToManufacture changes value. Databinding related.</summary>
		protected virtual void OnDaysToManufactureChanged()
		{
			if(DaysToManufactureChanged!=null)
			{
				DaysToManufactureChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ProductLineChanged event, which is thrown when ProductLine changes value. Databinding related.</summary>
		protected virtual void OnProductLineChanged()
		{
			if(ProductLineChanged!=null)
			{
				ProductLineChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ClassChanged event, which is thrown when Class changes value. Databinding related.</summary>
		protected virtual void OnClassChanged()
		{
			if(ClassChanged!=null)
			{
				ClassChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the StyleChanged event, which is thrown when Style changes value. Databinding related.</summary>
		protected virtual void OnStyleChanged()
		{
			if(StyleChanged!=null)
			{
				StyleChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ProductSubcategoryIdChanged event, which is thrown when ProductSubcategoryId changes value. Databinding related.</summary>
		protected virtual void OnProductSubcategoryIdChanged()
		{
			if(ProductSubcategoryIdChanged!=null)
			{
				ProductSubcategoryIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the ProductModelIdChanged event, which is thrown when ProductModelId changes value. Databinding related.</summary>
		protected virtual void OnProductModelIdChanged()
		{
			if(ProductModelIdChanged!=null)
			{
				ProductModelIdChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the SellStartDateChanged event, which is thrown when SellStartDate changes value. Databinding related.</summary>
		protected virtual void OnSellStartDateChanged()
		{
			if(SellStartDateChanged!=null)
			{
				SellStartDateChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the SellEndDateChanged event, which is thrown when SellEndDate changes value. Databinding related.</summary>
		protected virtual void OnSellEndDateChanged()
		{
			if(SellEndDateChanged!=null)
			{
				SellEndDateChanged(this, new EventArgs());
			}
		}

		/// <summary> Event thrower for the DiscontinuedDateChanged event, which is thrown when DiscontinuedDate changes value. Databinding related.</summary>
		protected virtual void OnDiscontinuedDateChanged()
		{
			if(DiscontinuedDateChanged!=null)
			{
				DiscontinuedDateChanged(this, new EventArgs());
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
				switch((ProductFieldIndex)fieldIndex)
				{
					default:
						break;
				}
				base.PostFieldValueSetAction(toReturn);
				switch((ProductFieldIndex)fieldIndex)
				{
					case ProductFieldIndex.ProductId:
						OnProductIdChanged();
						break;
					case ProductFieldIndex.Name:
						OnNameChanged();
						break;
					case ProductFieldIndex.ProductNumber:
						OnProductNumberChanged();
						break;
					case ProductFieldIndex.MakeFlag:
						OnMakeFlagChanged();
						break;
					case ProductFieldIndex.FinishedGoodsFlag:
						OnFinishedGoodsFlagChanged();
						break;
					case ProductFieldIndex.Color:
						OnColorChanged();
						break;
					case ProductFieldIndex.SafetyStockLevel:
						OnSafetyStockLevelChanged();
						break;
					case ProductFieldIndex.ReorderPoint:
						OnReorderPointChanged();
						break;
					case ProductFieldIndex.StandardCost:
						OnStandardCostChanged();
						break;
					case ProductFieldIndex.ListPrice:
						OnListPriceChanged();
						break;
					case ProductFieldIndex.Size:
						OnSizeChanged();
						break;
					case ProductFieldIndex.SizeUnitMeasureCode:
						OnSizeUnitMeasureCodeChanged();
						break;
					case ProductFieldIndex.WeightUnitMeasureCode:
						OnWeightUnitMeasureCodeChanged();
						break;
					case ProductFieldIndex.Weight:
						OnWeightChanged();
						break;
					case ProductFieldIndex.DaysToManufacture:
						OnDaysToManufactureChanged();
						break;
					case ProductFieldIndex.ProductLine:
						OnProductLineChanged();
						break;
					case ProductFieldIndex.Class:
						OnClassChanged();
						break;
					case ProductFieldIndex.Style:
						OnStyleChanged();
						break;
					case ProductFieldIndex.ProductSubcategoryId:
						OnProductSubcategoryIdChanged();
						break;
					case ProductFieldIndex.ProductModelId:
						OnProductModelIdChanged();
						break;
					case ProductFieldIndex.SellStartDate:
						OnSellStartDateChanged();
						break;
					case ProductFieldIndex.SellEndDate:
						OnSellEndDateChanged();
						break;
					case ProductFieldIndex.DiscontinuedDate:
						OnDiscontinuedDateChanged();
						break;
					case ProductFieldIndex.Rowguid:
						OnRowguidChanged();
						break;
					case ProductFieldIndex.ModifiedDate:
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
			ProductDAO dao = (ProductDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_specialOfferProduct.ActiveContext = base.ActiveContext;
			_specialOfferCollectionViaSpecialOfferProduct.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ProductDAO dao = (ProductDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ProductDAO dao = (ProductDAO)CreateDAOInstance();
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
			OnProductIdChanged();
			OnNameChanged();
			OnProductNumberChanged();
			OnMakeFlagChanged();
			OnFinishedGoodsFlagChanged();
			OnColorChanged();
			OnSafetyStockLevelChanged();
			OnReorderPointChanged();
			OnStandardCostChanged();
			OnListPriceChanged();
			OnSizeChanged();
			OnSizeUnitMeasureCodeChanged();
			OnWeightUnitMeasureCodeChanged();
			OnWeightChanged();
			OnDaysToManufactureChanged();
			OnProductLineChanged();
			OnClassChanged();
			OnStyleChanged();
			OnProductSubcategoryIdChanged();
			OnProductModelIdChanged();
			OnSellStartDateChanged();
			OnSellEndDateChanged();
			OnDiscontinuedDateChanged();
			OnRowguidChanged();
			OnModifiedDateChanged();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ProductEntity);
		}

		/// <summary>Creates field validator object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IValidator CreateValidator()
		{
			return new ProductValidator();
		}


		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this ProductEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 productId, IValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse, IPrefetchPath prefetchPathToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);

			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(productId, prefetchPathToUse, null);
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
			_specialOfferProduct = new AW.Data.CollectionClasses.SpecialOfferProductCollection(propertyDescriptorFactoryToUse, new SpecialOfferProductEntityFactory());
			_specialOfferProduct.SetContainingEntityInfo(this, "Product");
			_alwaysFetchSpecialOfferProduct = false;
			_alreadyFetchedSpecialOfferProduct = false;
			_specialOfferCollectionViaSpecialOfferProduct = new AW.Data.CollectionClasses.SpecialOfferCollection(propertyDescriptorFactoryToUse, new SpecialOfferEntityFactory());
			_alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct = false;
			_alreadyFetchedSpecialOfferCollectionViaSpecialOfferProduct = false;


			
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

			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ProductNumber", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("MakeFlag", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("FinishedGoodsFlag", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Color", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("SafetyStockLevel", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ReorderPoint", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("StandardCost", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ListPrice", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Size", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("SizeUnitMeasureCode", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("WeightUnitMeasureCode", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Weight", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("DaysToManufacture", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ProductLine", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Class", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Style", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ProductSubcategoryId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ProductModelId", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("SellStartDate", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("SellEndDate", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("DiscontinuedDate", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ProductFieldIndex.ProductId].ForcedCurrentValueWrite(productId);
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
			return DAOFactory.CreateProductDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactoryInstance()
		{
			return new ProductEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductRelations Relations
		{
			get	{ return new ProductRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOfferProduct
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferProductCollection(),
					ProductEntity.Relations.SpecialOfferProductEntityUsingProductId, 
					(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.SpecialOfferProductEntity, 0, null, null, null, "SpecialOfferProduct", RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SpecialOffer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSpecialOfferCollectionViaSpecialOfferProduct
		{
			get
			{
				IRelationCollection relations = new RelationCollection();
				relations.Add(ProductEntity.Relations.SpecialOfferProductEntityUsingProductId);
				relations.Add(SpecialOfferProductEntity.Relations.SpecialOfferEntityUsingSpecialOfferId);
				return new PrefetchPathElement(new AW.Data.CollectionClasses.SpecialOfferCollection(),
					ProductEntity.Relations.SpecialOfferProductEntityUsingProductId,
					(int)AW.Data.EntityType.ProductEntity, (int)AW.Data.EntityType.SpecialOfferEntity, 0, null, null, relations, "SpecialOfferCollectionViaSpecialOfferProduct", RelationType.ManyToMany);
			}
		}



		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return ProductEntity.CustomProperties;}
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
			get { return ProductEntity.FieldsCustomProperties;}
		}

		/// <summary> The ProductId property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ProductId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.ProductId, value); }
		}
		/// <summary> The Name property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Name);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.Name, value); }
		}
		/// <summary> The ProductNumber property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."ProductNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ProductNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ProductNumber);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.ProductNumber, value); }
		}
		/// <summary> The MakeFlag property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."MakeFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean MakeFlag
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.MakeFlag);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Boolean));
				}
				return (System.Boolean)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.MakeFlag, value); }
		}
		/// <summary> The FinishedGoodsFlag property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."FinishedGoodsFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean FinishedGoodsFlag
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.FinishedGoodsFlag);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Boolean));
				}
				return (System.Boolean)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.FinishedGoodsFlag, value); }
		}
		/// <summary> The Color property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."Color"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Color
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Color);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.Color, value); }
		}
		/// <summary> The SafetyStockLevel property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."SafetyStockLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 SafetyStockLevel
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.SafetyStockLevel);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int16));
				}
				return (System.Int16)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.SafetyStockLevel, value); }
		}
		/// <summary> The ReorderPoint property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."ReorderPoint"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 ReorderPoint
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ReorderPoint);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int16));
				}
				return (System.Int16)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.ReorderPoint, value); }
		}
		/// <summary> The StandardCost property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."StandardCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal StandardCost
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.StandardCost);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Decimal));
				}
				return (System.Decimal)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.StandardCost, value); }
		}
		/// <summary> The ListPrice property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."ListPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ListPrice
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ListPrice);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Decimal));
				}
				return (System.Decimal)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.ListPrice, value); }
		}
		/// <summary> The Size property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."Size"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Size
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Size);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.Size, value); }
		}
		/// <summary> The SizeUnitMeasureCode property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."SizeUnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String SizeUnitMeasureCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.SizeUnitMeasureCode);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.SizeUnitMeasureCode, value); }
		}
		/// <summary> The WeightUnitMeasureCode property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."WeightUnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String WeightUnitMeasureCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.WeightUnitMeasureCode);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.WeightUnitMeasureCode, value); }
		}
		/// <summary> The Weight property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."Weight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Decimal Weight
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Weight);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Decimal));
				}
				return (System.Decimal)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.Weight, value); }
		}
		/// <summary> The DaysToManufacture property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."DaysToManufacture"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DaysToManufacture
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.DaysToManufacture);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.DaysToManufacture, value); }
		}
		/// <summary> The ProductLine property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."ProductLine"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ProductLine
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ProductLine);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.ProductLine, value); }
		}
		/// <summary> The Class property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."Class"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Class
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Class);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.Class, value); }
		}
		/// <summary> The Style property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."Style"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Style
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Style);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				return (System.String)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.Style, value); }
		}
		/// <summary> The ProductSubcategoryId property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."ProductSubcategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Int32 ProductSubcategoryId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ProductSubcategoryId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.ProductSubcategoryId, value); }
		}
		/// <summary> The ProductModelId property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."ProductModelID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Int32 ProductModelId
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ProductModelId);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Int32));
				}
				return (System.Int32)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.ProductModelId, value); }
		}
		/// <summary> The SellStartDate property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."SellStartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime SellStartDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.SellStartDate);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.SellStartDate, value); }
		}
		/// <summary> The SellEndDate property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."SellEndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.DateTime SellEndDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.SellEndDate);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.SellEndDate, value); }
		}
		/// <summary> The DiscontinuedDate property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."DiscontinuedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.DateTime DiscontinuedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.DiscontinuedDate);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.DiscontinuedDate, value); }
		}
		/// <summary> The Rowguid property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.Guid));
				}
				return (System.Guid)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.Rowguid, value); }
		}
		/// <summary> The ModifiedDate property of the Entity Product<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Product"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					valueToReturn = TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				return (System.DateTime)valueToReturn;
			}
			set	{ SetNewFieldValue((int)ProductFieldIndex.ModifiedDate, value); }
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOfferProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SpecialOfferProductCollection SpecialOfferProduct
		{
			get	{ return GetMultiSpecialOfferProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOfferProduct. When set to true, SpecialOfferProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferProduct is accessed. You can always execute
		/// a forced fetch by calling GetMultiSpecialOfferProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOfferProduct
		{
			get	{ return _alwaysFetchSpecialOfferProduct; }
			set	{ _alwaysFetchSpecialOfferProduct = value; }	
		}

		/// <summary> Retrieves all related entities of type 'SpecialOfferEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOfferCollectionViaSpecialOfferProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.SpecialOfferCollection SpecialOfferCollectionViaSpecialOfferProduct
		{
			get { return GetMultiSpecialOfferCollectionViaSpecialOfferProduct(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SpecialOfferCollectionViaSpecialOfferProduct. When set to true, SpecialOfferCollectionViaSpecialOfferProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferCollectionViaSpecialOfferProduct is accessed. You can always execute
		/// a forced fetch by calling GetMultiSpecialOfferCollectionViaSpecialOfferProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOfferCollectionViaSpecialOfferProduct
		{
			get	{ return _alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct; }
			set	{ _alwaysFetchSpecialOfferCollectionViaSpecialOfferProduct = value; }	
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
			get { return (int)AW.Data.EntityType.ProductEntity; }
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
