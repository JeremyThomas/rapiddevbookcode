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
	
	/// <summary>Entity base class which represents the base class for the entity 'Department'.<br/><br/>
	/// 
	/// MS_Description: Lookup table containing the departments within the Adventure Works Cycles company.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class DepartmentEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection	_employeeDepartmentHistory;
		private bool	_alwaysFetchEmployeeDepartmentHistory, _alreadyFetchedEmployeeDepartmentHistory;
		private AW.Data.CollectionClasses.EmployeeCollection _employeeCollectionViaEmployeeDepartmentHistory;
		private bool	_alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory, _alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory;
		private AW.Data.CollectionClasses.ShiftCollection _shiftCollectionViaEmployeeDepartmentHistory;
		private bool	_alwaysFetchShiftCollectionViaEmployeeDepartmentHistory, _alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name EmployeeDepartmentHistory</summary>
			public static readonly string EmployeeDepartmentHistory = "EmployeeDepartmentHistory";
			/// <summary>Member name EmployeeCollectionViaEmployeeDepartmentHistory</summary>
			public static readonly string EmployeeCollectionViaEmployeeDepartmentHistory = "EmployeeCollectionViaEmployeeDepartmentHistory";
			/// <summary>Member name ShiftCollectionViaEmployeeDepartmentHistory</summary>
			public static readonly string ShiftCollectionViaEmployeeDepartmentHistory = "ShiftCollectionViaEmployeeDepartmentHistory";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DepartmentEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public DepartmentEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="departmentID">PK value for Department which data should be fetched into this Department object</param>
		public DepartmentEntityBase(System.Int16 departmentID)
		{
			InitClassFetch(departmentID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="departmentID">PK value for Department which data should be fetched into this Department object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public DepartmentEntityBase(System.Int16 departmentID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(departmentID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="departmentID">PK value for Department which data should be fetched into this Department object</param>
		/// <param name="validator">The custom validator object for this DepartmentEntity</param>
		public DepartmentEntityBase(System.Int16 departmentID, IValidator validator)
		{
			InitClassFetch(departmentID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DepartmentEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_employeeDepartmentHistory = (AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection)info.GetValue("_employeeDepartmentHistory", typeof(AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection));
			_alwaysFetchEmployeeDepartmentHistory = info.GetBoolean("_alwaysFetchEmployeeDepartmentHistory");
			_alreadyFetchedEmployeeDepartmentHistory = info.GetBoolean("_alreadyFetchedEmployeeDepartmentHistory");
			_employeeCollectionViaEmployeeDepartmentHistory = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaEmployeeDepartmentHistory", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory = info.GetBoolean("_alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory");
			_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory");
			_shiftCollectionViaEmployeeDepartmentHistory = (AW.Data.CollectionClasses.ShiftCollection)info.GetValue("_shiftCollectionViaEmployeeDepartmentHistory", typeof(AW.Data.CollectionClasses.ShiftCollection));
			_alwaysFetchShiftCollectionViaEmployeeDepartmentHistory = info.GetBoolean("_alwaysFetchShiftCollectionViaEmployeeDepartmentHistory");
			_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory = info.GetBoolean("_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((DepartmentFieldIndex)fieldIndex)
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
			_alreadyFetchedEmployeeDepartmentHistory = (_employeeDepartmentHistory.Count > 0);
			_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory = (_employeeCollectionViaEmployeeDepartmentHistory.Count > 0);
			_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory = (_shiftCollectionViaEmployeeDepartmentHistory.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return DepartmentEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "EmployeeDepartmentHistory":
					toReturn.Add(DepartmentEntity.Relations.EmployeeDepartmentHistoryEntityUsingDepartmentID);
					break;
				case "EmployeeCollectionViaEmployeeDepartmentHistory":
					toReturn.Add(DepartmentEntity.Relations.EmployeeDepartmentHistoryEntityUsingDepartmentID, "DepartmentEntity__", "EmployeeDepartmentHistory_", JoinHint.None);
					toReturn.Add(EmployeeDepartmentHistoryEntity.Relations.EmployeeEntityUsingEmployeeID, "EmployeeDepartmentHistory_", string.Empty, JoinHint.None);
					break;
				case "ShiftCollectionViaEmployeeDepartmentHistory":
					toReturn.Add(DepartmentEntity.Relations.EmployeeDepartmentHistoryEntityUsingDepartmentID, "DepartmentEntity__", "EmployeeDepartmentHistory_", JoinHint.None);
					toReturn.Add(EmployeeDepartmentHistoryEntity.Relations.ShiftEntityUsingShiftID, "EmployeeDepartmentHistory_", string.Empty, JoinHint.None);
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
			info.AddValue("_employeeDepartmentHistory", (!this.MarkedForDeletion?_employeeDepartmentHistory:null));
			info.AddValue("_alwaysFetchEmployeeDepartmentHistory", _alwaysFetchEmployeeDepartmentHistory);
			info.AddValue("_alreadyFetchedEmployeeDepartmentHistory", _alreadyFetchedEmployeeDepartmentHistory);
			info.AddValue("_employeeCollectionViaEmployeeDepartmentHistory", (!this.MarkedForDeletion?_employeeCollectionViaEmployeeDepartmentHistory:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory", _alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory", _alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory);
			info.AddValue("_shiftCollectionViaEmployeeDepartmentHistory", (!this.MarkedForDeletion?_shiftCollectionViaEmployeeDepartmentHistory:null));
			info.AddValue("_alwaysFetchShiftCollectionViaEmployeeDepartmentHistory", _alwaysFetchShiftCollectionViaEmployeeDepartmentHistory);
			info.AddValue("_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory", _alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory);


			
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

				case "EmployeeDepartmentHistory":
					_alreadyFetchedEmployeeDepartmentHistory = true;
					if(entity!=null)
					{
						this.EmployeeDepartmentHistory.Add((EmployeeDepartmentHistoryEntity)entity);
					}
					break;
				case "EmployeeCollectionViaEmployeeDepartmentHistory":
					_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaEmployeeDepartmentHistory.Add((EmployeeEntity)entity);
					}
					break;
				case "ShiftCollectionViaEmployeeDepartmentHistory":
					_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory = true;
					if(entity!=null)
					{
						this.ShiftCollectionViaEmployeeDepartmentHistory.Add((ShiftEntity)entity);
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

				case "EmployeeDepartmentHistory":
					_employeeDepartmentHistory.Add((EmployeeDepartmentHistoryEntity)relatedEntity);
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

				case "EmployeeDepartmentHistory":
					base.PerformRelatedEntityRemoval(_employeeDepartmentHistory, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_employeeDepartmentHistory);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="departmentID">PK value for Department which data should be fetched into this Department object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 departmentID)
		{
			return FetchUsingPK(departmentID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="departmentID">PK value for Department which data should be fetched into this Department object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 departmentID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(departmentID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="departmentID">PK value for Department which data should be fetched into this Department object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 departmentID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(departmentID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="departmentID">PK value for Department which data should be fetched into this Department object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 departmentID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(departmentID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.DepartmentID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DepartmentFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DepartmentFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DepartmentRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeDepartmentHistoryEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistory(bool forceFetch)
		{
			return GetMultiEmployeeDepartmentHistory(forceFetch, _employeeDepartmentHistory.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeDepartmentHistoryEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistory(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEmployeeDepartmentHistory(forceFetch, _employeeDepartmentHistory.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEmployeeDepartmentHistory(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeDepartmentHistory || forceFetch || _alwaysFetchEmployeeDepartmentHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeDepartmentHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeDepartmentHistory);
					}
				}
				_employeeDepartmentHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeDepartmentHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeDepartmentHistory.GetMultiManyToOne(this, null, null, filter);
				_employeeDepartmentHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeDepartmentHistory = true;
			}
			return _employeeDepartmentHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeDepartmentHistory'. These settings will be taken into account
		/// when the property EmployeeDepartmentHistory is requested or GetMultiEmployeeDepartmentHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeDepartmentHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeDepartmentHistory.SortClauses=sortClauses;
			_employeeDepartmentHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaEmployeeDepartmentHistory(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaEmployeeDepartmentHistory(forceFetch, _employeeCollectionViaEmployeeDepartmentHistory.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaEmployeeDepartmentHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory || forceFetch || _alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaEmployeeDepartmentHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaEmployeeDepartmentHistory);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(DepartmentFields.DepartmentID, ComparisonOperator.Equal, this.DepartmentID, "DepartmentEntity__"));
				_employeeCollectionViaEmployeeDepartmentHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaEmployeeDepartmentHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaEmployeeDepartmentHistory.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaEmployeeDepartmentHistory"));
				_employeeCollectionViaEmployeeDepartmentHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory = true;
			}
			return _employeeCollectionViaEmployeeDepartmentHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaEmployeeDepartmentHistory'. These settings will be taken into account
		/// when the property EmployeeCollectionViaEmployeeDepartmentHistory is requested or GetMultiEmployeeCollectionViaEmployeeDepartmentHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaEmployeeDepartmentHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaEmployeeDepartmentHistory.SortClauses=sortClauses;
			_employeeCollectionViaEmployeeDepartmentHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ShiftEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShiftEntity'</returns>
		public AW.Data.CollectionClasses.ShiftCollection GetMultiShiftCollectionViaEmployeeDepartmentHistory(bool forceFetch)
		{
			return GetMultiShiftCollectionViaEmployeeDepartmentHistory(forceFetch, _shiftCollectionViaEmployeeDepartmentHistory.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ShiftEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.ShiftCollection GetMultiShiftCollectionViaEmployeeDepartmentHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory || forceFetch || _alwaysFetchShiftCollectionViaEmployeeDepartmentHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_shiftCollectionViaEmployeeDepartmentHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shiftCollectionViaEmployeeDepartmentHistory);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(DepartmentFields.DepartmentID, ComparisonOperator.Equal, this.DepartmentID, "DepartmentEntity__"));
				_shiftCollectionViaEmployeeDepartmentHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_shiftCollectionViaEmployeeDepartmentHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_shiftCollectionViaEmployeeDepartmentHistory.GetMulti(filter, GetRelationsForField("ShiftCollectionViaEmployeeDepartmentHistory"));
				_shiftCollectionViaEmployeeDepartmentHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory = true;
			}
			return _shiftCollectionViaEmployeeDepartmentHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'ShiftCollectionViaEmployeeDepartmentHistory'. These settings will be taken into account
		/// when the property ShiftCollectionViaEmployeeDepartmentHistory is requested or GetMultiShiftCollectionViaEmployeeDepartmentHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShiftCollectionViaEmployeeDepartmentHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shiftCollectionViaEmployeeDepartmentHistory.SortClauses=sortClauses;
			_shiftCollectionViaEmployeeDepartmentHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			DepartmentDAO dao = (DepartmentDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_employeeDepartmentHistory.ActiveContext = base.ActiveContext;
			_employeeCollectionViaEmployeeDepartmentHistory.ActiveContext = base.ActiveContext;
			_shiftCollectionViaEmployeeDepartmentHistory.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			DepartmentDAO dao = (DepartmentDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			DepartmentDAO dao = (DepartmentDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.DepartmentEntity);
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

			toReturn.Add("EmployeeDepartmentHistory", _employeeDepartmentHistory);
			toReturn.Add("EmployeeCollectionViaEmployeeDepartmentHistory", _employeeCollectionViaEmployeeDepartmentHistory);
			toReturn.Add("ShiftCollectionViaEmployeeDepartmentHistory", _shiftCollectionViaEmployeeDepartmentHistory);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="departmentID">PK value for Department which data should be fetched into this Department object</param>
		/// <param name="validator">The validator object for this DepartmentEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int16 departmentID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(departmentID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_employeeDepartmentHistory = new AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection(new EmployeeDepartmentHistoryEntityFactory());
			_employeeDepartmentHistory.SetContainingEntityInfo(this, "Department");
			_alwaysFetchEmployeeDepartmentHistory = false;
			_alreadyFetchedEmployeeDepartmentHistory = false;
			_employeeCollectionViaEmployeeDepartmentHistory = new AW.Data.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory = false;
			_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory = false;
			_shiftCollectionViaEmployeeDepartmentHistory = new AW.Data.CollectionClasses.ShiftCollection(new ShiftEntityFactory());
			_alwaysFetchShiftCollectionViaEmployeeDepartmentHistory = false;
			_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory = false;



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
			_customProperties.Add("MS_Description", @"Lookup table containing the departments within the Adventure Works Cycles company.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("DepartmentID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Name of the department.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Name of the group to which the department belongs.");
			_fieldsCustomProperties.Add("GroupName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="departmentID">PK value for Department which data should be fetched into this Department object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 departmentID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)DepartmentFieldIndex.DepartmentID].ForcedCurrentValueWrite(departmentID);
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
			return DAOFactory.CreateDepartmentDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new DepartmentEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static DepartmentRelations Relations
		{
			get	{ return new DepartmentRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EmployeeDepartmentHistory' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeDepartmentHistory
		{
			get
			{
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection(),
					(IEntityRelation)GetRelationsForField("EmployeeDepartmentHistory")[0], (int)AW.Data.EntityType.DepartmentEntity, (int)AW.Data.EntityType.EmployeeDepartmentHistoryEntity, 0, null, null, null, "EmployeeDepartmentHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaEmployeeDepartmentHistory
		{
			get
			{
				IEntityRelation intermediateRelation = DepartmentEntity.Relations.EmployeeDepartmentHistoryEntityUsingDepartmentID;
				intermediateRelation.SetAliases(string.Empty, "EmployeeDepartmentHistory_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.DepartmentEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaEmployeeDepartmentHistory"), "EmployeeCollectionViaEmployeeDepartmentHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Shift' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShiftCollectionViaEmployeeDepartmentHistory
		{
			get
			{
				IEntityRelation intermediateRelation = DepartmentEntity.Relations.EmployeeDepartmentHistoryEntityUsingDepartmentID;
				intermediateRelation.SetAliases(string.Empty, "EmployeeDepartmentHistory_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.ShiftCollection(), intermediateRelation,
					(int)AW.Data.EntityType.DepartmentEntity, (int)AW.Data.EntityType.ShiftEntity, 0, null, null, GetRelationsForField("ShiftCollectionViaEmployeeDepartmentHistory"), "ShiftCollectionViaEmployeeDepartmentHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "DepartmentEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DepartmentEntity.CustomProperties;}
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
			get { return DepartmentEntity.FieldsCustomProperties;}
		}

		/// <summary> The DepartmentID property of the Entity Department<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Department"."DepartmentID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 DepartmentID
		{
			get { return (System.Int16)GetValue((int)DepartmentFieldIndex.DepartmentID, true); }
			set	{ SetValue((int)DepartmentFieldIndex.DepartmentID, value, true); }
		}
		/// <summary> The Name property of the Entity Department<br/><br/>
		/// 
		/// MS_Description: Name of the department.<br/></summary>
		/// <remarks>Mapped on  table field: "Department"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)DepartmentFieldIndex.Name, true); }
			set	{ SetValue((int)DepartmentFieldIndex.Name, value, true); }
		}
		/// <summary> The GroupName property of the Entity Department<br/><br/>
		/// 
		/// MS_Description: Name of the group to which the department belongs.<br/></summary>
		/// <remarks>Mapped on  table field: "Department"."GroupName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String GroupName
		{
			get { return (System.String)GetValue((int)DepartmentFieldIndex.GroupName, true); }
			set	{ SetValue((int)DepartmentFieldIndex.GroupName, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Department<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Department"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)DepartmentFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)DepartmentFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeDepartmentHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection EmployeeDepartmentHistory
		{
			get	{ return GetMultiEmployeeDepartmentHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeDepartmentHistory. When set to true, EmployeeDepartmentHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeDepartmentHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeDepartmentHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeDepartmentHistory
		{
			get	{ return _alwaysFetchEmployeeDepartmentHistory; }
			set	{ _alwaysFetchEmployeeDepartmentHistory = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeDepartmentHistory already has been fetched. Setting this property to false when EmployeeDepartmentHistory has been fetched
		/// will clear the EmployeeDepartmentHistory collection well. Setting this property to true while EmployeeDepartmentHistory hasn't been fetched disables lazy loading for EmployeeDepartmentHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeDepartmentHistory
		{
			get { return _alreadyFetchedEmployeeDepartmentHistory;}
			set 
			{
				if(_alreadyFetchedEmployeeDepartmentHistory && !value && (_employeeDepartmentHistory != null))
				{
					_employeeDepartmentHistory.Clear();
				}
				_alreadyFetchedEmployeeDepartmentHistory = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaEmployeeDepartmentHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.EmployeeCollection EmployeeCollectionViaEmployeeDepartmentHistory
		{
			get { return GetMultiEmployeeCollectionViaEmployeeDepartmentHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaEmployeeDepartmentHistory. When set to true, EmployeeCollectionViaEmployeeDepartmentHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaEmployeeDepartmentHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaEmployeeDepartmentHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory
		{
			get	{ return _alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory; }
			set	{ _alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaEmployeeDepartmentHistory already has been fetched. Setting this property to false when EmployeeCollectionViaEmployeeDepartmentHistory has been fetched
		/// will clear the EmployeeCollectionViaEmployeeDepartmentHistory collection well. Setting this property to true while EmployeeCollectionViaEmployeeDepartmentHistory hasn't been fetched disables lazy loading for EmployeeCollectionViaEmployeeDepartmentHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory
		{
			get { return _alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory && !value && (_employeeCollectionViaEmployeeDepartmentHistory != null))
				{
					_employeeCollectionViaEmployeeDepartmentHistory.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ShiftEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShiftCollectionViaEmployeeDepartmentHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.ShiftCollection ShiftCollectionViaEmployeeDepartmentHistory
		{
			get { return GetMultiShiftCollectionViaEmployeeDepartmentHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ShiftCollectionViaEmployeeDepartmentHistory. When set to true, ShiftCollectionViaEmployeeDepartmentHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShiftCollectionViaEmployeeDepartmentHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiShiftCollectionViaEmployeeDepartmentHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShiftCollectionViaEmployeeDepartmentHistory
		{
			get	{ return _alwaysFetchShiftCollectionViaEmployeeDepartmentHistory; }
			set	{ _alwaysFetchShiftCollectionViaEmployeeDepartmentHistory = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ShiftCollectionViaEmployeeDepartmentHistory already has been fetched. Setting this property to false when ShiftCollectionViaEmployeeDepartmentHistory has been fetched
		/// will clear the ShiftCollectionViaEmployeeDepartmentHistory collection well. Setting this property to true while ShiftCollectionViaEmployeeDepartmentHistory hasn't been fetched disables lazy loading for ShiftCollectionViaEmployeeDepartmentHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShiftCollectionViaEmployeeDepartmentHistory
		{
			get { return _alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory;}
			set 
			{
				if(_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory && !value && (_shiftCollectionViaEmployeeDepartmentHistory != null))
				{
					_shiftCollectionViaEmployeeDepartmentHistory.Clear();
				}
				_alreadyFetchedShiftCollectionViaEmployeeDepartmentHistory = value;
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
			get { return (int)AW.Data.EntityType.DepartmentEntity; }
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
