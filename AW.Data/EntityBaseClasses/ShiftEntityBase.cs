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
	
	/// <summary>Entity base class which represents the base class for the entity 'Shift'.<br/><br/>
	/// 
	/// MS_Description: Work shift lookup table.<br/>
	/// </summary>
	[Serializable]
	public abstract partial class ShiftEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection	_employeeDepartmentHistory;
		private bool	_alwaysFetchEmployeeDepartmentHistory, _alreadyFetchedEmployeeDepartmentHistory;
		private AW.Data.CollectionClasses.DepartmentCollection _departmentCollectionViaEmployeeDepartmentHistory;
		private bool	_alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory, _alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory;
		private AW.Data.CollectionClasses.EmployeeCollection _employeeCollectionViaEmployeeDepartmentHistory;
		private bool	_alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory, _alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory;


		
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
			/// <summary>Member name DepartmentCollectionViaEmployeeDepartmentHistory</summary>
			public static readonly string DepartmentCollectionViaEmployeeDepartmentHistory = "DepartmentCollectionViaEmployeeDepartmentHistory";
			/// <summary>Member name EmployeeCollectionViaEmployeeDepartmentHistory</summary>
			public static readonly string EmployeeCollectionViaEmployeeDepartmentHistory = "EmployeeCollectionViaEmployeeDepartmentHistory";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ShiftEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ShiftEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="shiftID">PK value for Shift which data should be fetched into this Shift object</param>
		public ShiftEntityBase(System.Byte shiftID)
		{
			InitClassFetch(shiftID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="shiftID">PK value for Shift which data should be fetched into this Shift object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ShiftEntityBase(System.Byte shiftID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(shiftID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="shiftID">PK value for Shift which data should be fetched into this Shift object</param>
		/// <param name="validator">The custom validator object for this ShiftEntity</param>
		public ShiftEntityBase(System.Byte shiftID, IValidator validator)
		{
			InitClassFetch(shiftID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ShiftEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_employeeDepartmentHistory = (AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection)info.GetValue("_employeeDepartmentHistory", typeof(AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection));
			_alwaysFetchEmployeeDepartmentHistory = info.GetBoolean("_alwaysFetchEmployeeDepartmentHistory");
			_alreadyFetchedEmployeeDepartmentHistory = info.GetBoolean("_alreadyFetchedEmployeeDepartmentHistory");
			_departmentCollectionViaEmployeeDepartmentHistory = (AW.Data.CollectionClasses.DepartmentCollection)info.GetValue("_departmentCollectionViaEmployeeDepartmentHistory", typeof(AW.Data.CollectionClasses.DepartmentCollection));
			_alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory = info.GetBoolean("_alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory");
			_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory = info.GetBoolean("_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory");
			_employeeCollectionViaEmployeeDepartmentHistory = (AW.Data.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaEmployeeDepartmentHistory", typeof(AW.Data.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory = info.GetBoolean("_alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory");
			_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ShiftFieldIndex)fieldIndex)
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
			_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory = (_departmentCollectionViaEmployeeDepartmentHistory.Count > 0);
			_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory = (_employeeCollectionViaEmployeeDepartmentHistory.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ShiftEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(ShiftEntity.Relations.EmployeeDepartmentHistoryEntityUsingShiftID);
					break;
				case "DepartmentCollectionViaEmployeeDepartmentHistory":
					toReturn.Add(ShiftEntity.Relations.EmployeeDepartmentHistoryEntityUsingShiftID, "ShiftEntity__", "EmployeeDepartmentHistory_", JoinHint.None);
					toReturn.Add(EmployeeDepartmentHistoryEntity.Relations.DepartmentEntityUsingDepartmentID, "EmployeeDepartmentHistory_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaEmployeeDepartmentHistory":
					toReturn.Add(ShiftEntity.Relations.EmployeeDepartmentHistoryEntityUsingShiftID, "ShiftEntity__", "EmployeeDepartmentHistory_", JoinHint.None);
					toReturn.Add(EmployeeDepartmentHistoryEntity.Relations.EmployeeEntityUsingEmployeeID, "EmployeeDepartmentHistory_", string.Empty, JoinHint.None);
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
			info.AddValue("_departmentCollectionViaEmployeeDepartmentHistory", (!this.MarkedForDeletion?_departmentCollectionViaEmployeeDepartmentHistory:null));
			info.AddValue("_alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory", _alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory);
			info.AddValue("_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory", _alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory);
			info.AddValue("_employeeCollectionViaEmployeeDepartmentHistory", (!this.MarkedForDeletion?_employeeCollectionViaEmployeeDepartmentHistory:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory", _alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory", _alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory);


			
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
				case "DepartmentCollectionViaEmployeeDepartmentHistory":
					_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory = true;
					if(entity!=null)
					{
						this.DepartmentCollectionViaEmployeeDepartmentHistory.Add((DepartmentEntity)entity);
					}
					break;
				case "EmployeeCollectionViaEmployeeDepartmentHistory":
					_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaEmployeeDepartmentHistory.Add((EmployeeEntity)entity);
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
		/// <param name="shiftID">PK value for Shift which data should be fetched into this Shift object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte shiftID)
		{
			return FetchUsingPK(shiftID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="shiftID">PK value for Shift which data should be fetched into this Shift object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte shiftID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(shiftID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="shiftID">PK value for Shift which data should be fetched into this Shift object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte shiftID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(shiftID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="shiftID">PK value for Shift which data should be fetched into this Shift object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Byte shiftID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(shiftID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ShiftID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ShiftFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ShiftFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ShiftRelations().GetAllRelations();
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
				_employeeDepartmentHistory.GetMultiManyToOne(null, null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'DepartmentEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DepartmentEntity'</returns>
		public AW.Data.CollectionClasses.DepartmentCollection GetMultiDepartmentCollectionViaEmployeeDepartmentHistory(bool forceFetch)
		{
			return GetMultiDepartmentCollectionViaEmployeeDepartmentHistory(forceFetch, _departmentCollectionViaEmployeeDepartmentHistory.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'DepartmentEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public AW.Data.CollectionClasses.DepartmentCollection GetMultiDepartmentCollectionViaEmployeeDepartmentHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory || forceFetch || _alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_departmentCollectionViaEmployeeDepartmentHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_departmentCollectionViaEmployeeDepartmentHistory);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ShiftFields.ShiftID, ComparisonOperator.Equal, this.ShiftID, "ShiftEntity__"));
				_departmentCollectionViaEmployeeDepartmentHistory.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_departmentCollectionViaEmployeeDepartmentHistory.EntityFactoryToUse = entityFactoryToUse;
				}
				_departmentCollectionViaEmployeeDepartmentHistory.GetMulti(filter, GetRelationsForField("DepartmentCollectionViaEmployeeDepartmentHistory"));
				_departmentCollectionViaEmployeeDepartmentHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory = true;
			}
			return _departmentCollectionViaEmployeeDepartmentHistory;
		}

		/// <summary> Sets the collection parameters for the collection for 'DepartmentCollectionViaEmployeeDepartmentHistory'. These settings will be taken into account
		/// when the property DepartmentCollectionViaEmployeeDepartmentHistory is requested or GetMultiDepartmentCollectionViaEmployeeDepartmentHistory is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDepartmentCollectionViaEmployeeDepartmentHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_departmentCollectionViaEmployeeDepartmentHistory.SortClauses=sortClauses;
			_departmentCollectionViaEmployeeDepartmentHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(ShiftFields.ShiftID, ComparisonOperator.Equal, this.ShiftID, "ShiftEntity__"));
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



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ShiftDAO dao = (ShiftDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_employeeDepartmentHistory.ActiveContext = base.ActiveContext;
			_departmentCollectionViaEmployeeDepartmentHistory.ActiveContext = base.ActiveContext;
			_employeeCollectionViaEmployeeDepartmentHistory.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ShiftDAO dao = (ShiftDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ShiftDAO dao = (ShiftDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ShiftEntity);
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
			toReturn.Add("DepartmentCollectionViaEmployeeDepartmentHistory", _departmentCollectionViaEmployeeDepartmentHistory);
			toReturn.Add("EmployeeCollectionViaEmployeeDepartmentHistory", _employeeCollectionViaEmployeeDepartmentHistory);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="shiftID">PK value for Shift which data should be fetched into this Shift object</param>
		/// <param name="validator">The validator object for this ShiftEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Byte shiftID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(shiftID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_employeeDepartmentHistory = new AW.Data.CollectionClasses.EmployeeDepartmentHistoryCollection(new EmployeeDepartmentHistoryEntityFactory());
			_employeeDepartmentHistory.SetContainingEntityInfo(this, "Shift");
			_alwaysFetchEmployeeDepartmentHistory = false;
			_alreadyFetchedEmployeeDepartmentHistory = false;
			_departmentCollectionViaEmployeeDepartmentHistory = new AW.Data.CollectionClasses.DepartmentCollection(new DepartmentEntityFactory());
			_alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory = false;
			_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory = false;
			_employeeCollectionViaEmployeeDepartmentHistory = new AW.Data.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaEmployeeDepartmentHistory = false;
			_alreadyFetchedEmployeeCollectionViaEmployeeDepartmentHistory = false;



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
			_customProperties.Add("MS_Description", @"Work shift lookup table.");
			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("ShiftID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Shift description.");
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Unique nonclustered index.");
			_fieldsCustomProperties.Add("StartTime", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Shift end time.");
			_fieldsCustomProperties.Add("EndTime", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="shiftID">PK value for Shift which data should be fetched into this Shift object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Byte shiftID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ShiftFieldIndex.ShiftID].ForcedCurrentValueWrite(shiftID);
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
			return DAOFactory.CreateShiftDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ShiftEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ShiftRelations Relations
		{
			get	{ return new ShiftRelations(); }
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
					(IEntityRelation)GetRelationsForField("EmployeeDepartmentHistory")[0], (int)AW.Data.EntityType.ShiftEntity, (int)AW.Data.EntityType.EmployeeDepartmentHistoryEntity, 0, null, null, null, "EmployeeDepartmentHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Department' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDepartmentCollectionViaEmployeeDepartmentHistory
		{
			get
			{
				IEntityRelation intermediateRelation = ShiftEntity.Relations.EmployeeDepartmentHistoryEntityUsingShiftID;
				intermediateRelation.SetAliases(string.Empty, "EmployeeDepartmentHistory_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.DepartmentCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ShiftEntity, (int)AW.Data.EntityType.DepartmentEntity, 0, null, null, GetRelationsForField("DepartmentCollectionViaEmployeeDepartmentHistory"), "DepartmentCollectionViaEmployeeDepartmentHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaEmployeeDepartmentHistory
		{
			get
			{
				IEntityRelation intermediateRelation = ShiftEntity.Relations.EmployeeDepartmentHistoryEntityUsingShiftID;
				intermediateRelation.SetAliases(string.Empty, "EmployeeDepartmentHistory_");
				return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)AW.Data.EntityType.ShiftEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaEmployeeDepartmentHistory"), "EmployeeCollectionViaEmployeeDepartmentHistory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ShiftEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ShiftEntity.CustomProperties;}
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
			get { return ShiftEntity.FieldsCustomProperties;}
		}

		/// <summary> The ShiftID property of the Entity Shift<br/><br/>
		/// 
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "Shift"."ShiftID"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Byte ShiftID
		{
			get { return (System.Byte)GetValue((int)ShiftFieldIndex.ShiftID, true); }
			set	{ SetValue((int)ShiftFieldIndex.ShiftID, value, true); }
		}
		/// <summary> The Name property of the Entity Shift<br/><br/>
		/// 
		/// MS_Description: Shift description.<br/></summary>
		/// <remarks>Mapped on  table field: "Shift"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ShiftFieldIndex.Name, true); }
			set	{ SetValue((int)ShiftFieldIndex.Name, value, true); }
		}
		/// <summary> The StartTime property of the Entity Shift<br/><br/>
		/// 
		/// MS_Description: Unique nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "Shift"."StartTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime StartTime
		{
			get { return (System.DateTime)GetValue((int)ShiftFieldIndex.StartTime, true); }
			set	{ SetValue((int)ShiftFieldIndex.StartTime, value, true); }
		}
		/// <summary> The EndTime property of the Entity Shift<br/><br/>
		/// 
		/// MS_Description: Shift end time.<br/></summary>
		/// <remarks>Mapped on  table field: "Shift"."EndTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime EndTime
		{
			get { return (System.DateTime)GetValue((int)ShiftFieldIndex.EndTime, true); }
			set	{ SetValue((int)ShiftFieldIndex.EndTime, value, true); }
		}
		/// <summary> The ModifiedDate property of the Entity Shift<br/><br/>
		/// 
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "Shift"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ShiftFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ShiftFieldIndex.ModifiedDate, value, true); }
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

		/// <summary> Retrieves all related entities of type 'DepartmentEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDepartmentCollectionViaEmployeeDepartmentHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual AW.Data.CollectionClasses.DepartmentCollection DepartmentCollectionViaEmployeeDepartmentHistory
		{
			get { return GetMultiDepartmentCollectionViaEmployeeDepartmentHistory(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DepartmentCollectionViaEmployeeDepartmentHistory. When set to true, DepartmentCollectionViaEmployeeDepartmentHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DepartmentCollectionViaEmployeeDepartmentHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiDepartmentCollectionViaEmployeeDepartmentHistory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory
		{
			get	{ return _alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory; }
			set	{ _alwaysFetchDepartmentCollectionViaEmployeeDepartmentHistory = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property DepartmentCollectionViaEmployeeDepartmentHistory already has been fetched. Setting this property to false when DepartmentCollectionViaEmployeeDepartmentHistory has been fetched
		/// will clear the DepartmentCollectionViaEmployeeDepartmentHistory collection well. Setting this property to true while DepartmentCollectionViaEmployeeDepartmentHistory hasn't been fetched disables lazy loading for DepartmentCollectionViaEmployeeDepartmentHistory</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory
		{
			get { return _alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory;}
			set 
			{
				if(_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory && !value && (_departmentCollectionViaEmployeeDepartmentHistory != null))
				{
					_departmentCollectionViaEmployeeDepartmentHistory.Clear();
				}
				_alreadyFetchedDepartmentCollectionViaEmployeeDepartmentHistory = value;
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
			get { return (int)AW.Data.EntityType.ShiftEntity; }
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
