///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.0
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

	/// <summary>Entity class which represents the entity 'EmployeeDepartmentHistory'. <br/><br/>
	/// 
	/// MS_Description: Employee department transfers.<br/>
	/// </summary>
	[Serializable]
	public partial class EmployeeDepartmentHistoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DepartmentEntity _department;
		private bool	_alwaysFetchDepartment, _alreadyFetchedDepartment, _departmentReturnsNewIfNotFound;
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee, _employeeReturnsNewIfNotFound;
		private ShiftEntity _shift;
		private bool	_alwaysFetchShift, _alreadyFetchedShift, _shiftReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Department</summary>
			public static readonly string Department = "Department";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name Shift</summary>
			public static readonly string Shift = "Shift";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static EmployeeDepartmentHistoryEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public EmployeeDepartmentHistoryEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		public EmployeeDepartmentHistoryEntity(System.Int16 departmentID, System.Int32 employeeID, System.Byte shiftID, System.DateTime startDate)
		{
			InitClassFetch(departmentID, employeeID, shiftID, startDate, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public EmployeeDepartmentHistoryEntity(System.Int16 departmentID, System.Int32 employeeID, System.Byte shiftID, System.DateTime startDate, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(departmentID, employeeID, shiftID, startDate, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="validator">The custom validator object for this EmployeeDepartmentHistoryEntity</param>
		public EmployeeDepartmentHistoryEntity(System.Int16 departmentID, System.Int32 employeeID, System.Byte shiftID, System.DateTime startDate, IValidator validator)
		{
			InitClassFetch(departmentID, employeeID, shiftID, startDate, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeDepartmentHistoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_department = (DepartmentEntity)info.GetValue("_department", typeof(DepartmentEntity));
			if(_department!=null)
			{
				_department.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_departmentReturnsNewIfNotFound = info.GetBoolean("_departmentReturnsNewIfNotFound");
			_alwaysFetchDepartment = info.GetBoolean("_alwaysFetchDepartment");
			_alreadyFetchedDepartment = info.GetBoolean("_alreadyFetchedDepartment");

			_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
			if(_employee!=null)
			{
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employeeReturnsNewIfNotFound = info.GetBoolean("_employeeReturnsNewIfNotFound");
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");

			_shift = (ShiftEntity)info.GetValue("_shift", typeof(ShiftEntity));
			if(_shift!=null)
			{
				_shift.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_shiftReturnsNewIfNotFound = info.GetBoolean("_shiftReturnsNewIfNotFound");
			_alwaysFetchShift = info.GetBoolean("_alwaysFetchShift");
			_alreadyFetchedShift = info.GetBoolean("_alreadyFetchedShift");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((EmployeeDepartmentHistoryFieldIndex)fieldIndex)
			{
				case EmployeeDepartmentHistoryFieldIndex.DepartmentID:
					DesetupSyncDepartment(true, false);
					_alreadyFetchedDepartment = false;
					break;
				case EmployeeDepartmentHistoryFieldIndex.EmployeeID:
					DesetupSyncEmployee(true, false);
					_alreadyFetchedEmployee = false;
					break;
				case EmployeeDepartmentHistoryFieldIndex.ShiftID:
					DesetupSyncShift(true, false);
					_alreadyFetchedShift = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedDepartment = (_department != null);
			_alreadyFetchedEmployee = (_employee != null);
			_alreadyFetchedShift = (_shift != null);
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
				case "Department":
					toReturn.Add(Relations.DepartmentEntityUsingDepartmentID);
					break;
				case "Employee":
					toReturn.Add(Relations.EmployeeEntityUsingEmployeeID);
					break;
				case "Shift":
					toReturn.Add(Relations.ShiftEntityUsingShiftID);
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
			info.AddValue("_department", (!this.MarkedForDeletion?_department:null));
			info.AddValue("_departmentReturnsNewIfNotFound", _departmentReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchDepartment", _alwaysFetchDepartment);
			info.AddValue("_alreadyFetchedDepartment", _alreadyFetchedDepartment);
			info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			info.AddValue("_employeeReturnsNewIfNotFound", _employeeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_shift", (!this.MarkedForDeletion?_shift:null));
			info.AddValue("_shiftReturnsNewIfNotFound", _shiftReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchShift", _alwaysFetchShift);
			info.AddValue("_alreadyFetchedShift", _alreadyFetchedShift);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "Department":
					_alreadyFetchedDepartment = true;
					this.Department = (DepartmentEntity)entity;
					break;
				case "Employee":
					_alreadyFetchedEmployee = true;
					this.Employee = (EmployeeEntity)entity;
					break;
				case "Shift":
					_alreadyFetchedShift = true;
					this.Shift = (ShiftEntity)entity;
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
		protected override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Department":
					SetupSyncDepartment(relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "Shift":
					SetupSyncShift(relatedEntity);
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
		protected override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Department":
					DesetupSyncDepartment(false, true);
					break;
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "Shift":
					DesetupSyncShift(false, true);
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
			if(_department!=null)
			{
				toReturn.Add(_department);
			}
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_shift!=null)
			{
				toReturn.Add(_shift);
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
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 departmentID, System.Int32 employeeID, System.Byte shiftID, System.DateTime startDate)
		{
			return FetchUsingPK(departmentID, employeeID, shiftID, startDate, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 departmentID, System.Int32 employeeID, System.Byte shiftID, System.DateTime startDate, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(departmentID, employeeID, shiftID, startDate, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 departmentID, System.Int32 employeeID, System.Byte shiftID, System.DateTime startDate, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(departmentID, employeeID, shiftID, startDate, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 departmentID, System.Int32 employeeID, System.Byte shiftID, System.DateTime startDate, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(departmentID, employeeID, shiftID, startDate, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.DepartmentID, this.EmployeeID, this.ShiftID, this.StartDate, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new EmployeeDepartmentHistoryRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'DepartmentEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'DepartmentEntity' which is related to this entity.</returns>
		public DepartmentEntity GetSingleDepartment()
		{
			return GetSingleDepartment(false);
		}

		/// <summary> Retrieves the related entity of type 'DepartmentEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'DepartmentEntity' which is related to this entity.</returns>
		public virtual DepartmentEntity GetSingleDepartment(bool forceFetch)
		{
			if( ( !_alreadyFetchedDepartment || forceFetch || _alwaysFetchDepartment) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.DepartmentEntityUsingDepartmentID);
				DepartmentEntity newEntity = new DepartmentEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.DepartmentID);
				}
				if(fetchResult)
				{
					newEntity = (DepartmentEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_departmentReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Department = newEntity;
				_alreadyFetchedDepartment = fetchResult;
			}
			return _department;
		}


		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee()
		{
			return GetSingleEmployee(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.EmployeeEntityUsingEmployeeID);
				EmployeeEntity newEntity = (EmployeeEntity)GeneralEntityFactory.Create(AW.Data.EntityType.EmployeeEntity);
				bool fetchResult = false;
				if(performLazyLoading)
				{
					newEntity = EmployeeEntity.FetchPolymorphic(this.Transaction, this.EmployeeID, this.ActiveContext);
					fetchResult = (newEntity.Fields.State==EntityState.Fetched);
				}
				if(fetchResult)
				{
					newEntity = (EmployeeEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_employeeReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Employee = newEntity;
				_alreadyFetchedEmployee = fetchResult;
			}
			return _employee;
		}


		/// <summary> Retrieves the related entity of type 'ShiftEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ShiftEntity' which is related to this entity.</returns>
		public ShiftEntity GetSingleShift()
		{
			return GetSingleShift(false);
		}

		/// <summary> Retrieves the related entity of type 'ShiftEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ShiftEntity' which is related to this entity.</returns>
		public virtual ShiftEntity GetSingleShift(bool forceFetch)
		{
			if( ( !_alreadyFetchedShift || forceFetch || _alwaysFetchShift) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ShiftEntityUsingShiftID);
				ShiftEntity newEntity = new ShiftEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ShiftID);
				}
				if(fetchResult)
				{
					newEntity = (ShiftEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_shiftReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Shift = newEntity;
				_alreadyFetchedShift = fetchResult;
			}
			return _shift;
		}

		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_department!=null)
			{
				_department.ActiveContext = this.ActiveContext;
			}
			if(_employee!=null)
			{
				_employee.ActiveContext = this.ActiveContext;
			}
			if(_shift!=null)
			{
				_shift.ActiveContext = this.ActiveContext;
			}
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Department", _department);
			toReturn.Add("Employee", _employee);
			toReturn.Add("Shift", _shift);
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
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="validator">The validator object for this EmployeeDepartmentHistoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 departmentID, System.Int32 employeeID, System.Byte shiftID, System.DateTime startDate, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(departmentID, employeeID, shiftID, startDate, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{			_departmentReturnsNewIfNotFound = true;
			_employeeReturnsNewIfNotFound = true;
			_shiftReturnsNewIfNotFound = true;
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
			_customProperties.Add("MS_Description", @"Employee department transfers.");
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Department in which the employee worked including currently. Foreign key to Department.DepartmentID.");
			_fieldsCustomProperties.Add("DepartmentID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Clustered index created by a primary key constraint.");
			_fieldsCustomProperties.Add("EmployeeID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the employee left the department. NULL = Current department.");
			_fieldsCustomProperties.Add("EndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date and time the record was last updated.");
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Nonclustered index.");
			_fieldsCustomProperties.Add("ShiftID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			fieldHashtable.Add("MS_Description", @"Date the employee started work in the department.");
			_fieldsCustomProperties.Add("StartDate", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _department</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDepartment(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _department, new PropertyChangedEventHandler( OnDepartmentPropertyChanged ), "Department", EmployeeDepartmentHistoryEntity.Relations.DepartmentEntityUsingDepartmentID, true, signalRelatedEntity, "EmployeeDepartmentHistories", resetFKFields, new int[] { (int)EmployeeDepartmentHistoryFieldIndex.DepartmentID } );		
			_department = null;
		}
		
		/// <summary> setups the sync logic for member _department</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDepartment(IEntity relatedEntity)
		{
			if(_department!=relatedEntity)
			{		
				DesetupSyncDepartment(true, true);
				_department = (DepartmentEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _department, new PropertyChangedEventHandler( OnDepartmentPropertyChanged ), "Department", EmployeeDepartmentHistoryEntity.Relations.DepartmentEntityUsingDepartmentID, true, ref _alreadyFetchedDepartment, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDepartmentPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", EmployeeDepartmentHistoryEntity.Relations.EmployeeEntityUsingEmployeeID, true, signalRelatedEntity, "EmployeeDepartmentHistories", resetFKFields, new int[] { (int)EmployeeDepartmentHistoryFieldIndex.EmployeeID } );		
			_employee = null;
		}
		
		/// <summary> setups the sync logic for member _employee</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee(IEntity relatedEntity)
		{
			if(_employee!=relatedEntity)
			{		
				DesetupSyncEmployee(true, true);
				_employee = (EmployeeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", EmployeeDepartmentHistoryEntity.Relations.EmployeeEntityUsingEmployeeID, true, ref _alreadyFetchedEmployee, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployeePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _shift</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncShift(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _shift, new PropertyChangedEventHandler( OnShiftPropertyChanged ), "Shift", EmployeeDepartmentHistoryEntity.Relations.ShiftEntityUsingShiftID, true, signalRelatedEntity, "EmployeeDepartmentHistories", resetFKFields, new int[] { (int)EmployeeDepartmentHistoryFieldIndex.ShiftID } );		
			_shift = null;
		}
		
		/// <summary> setups the sync logic for member _shift</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncShift(IEntity relatedEntity)
		{
			if(_shift!=relatedEntity)
			{		
				DesetupSyncShift(true, true);
				_shift = (ShiftEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _shift, new PropertyChangedEventHandler( OnShiftPropertyChanged ), "Shift", EmployeeDepartmentHistoryEntity.Relations.ShiftEntityUsingShiftID, true, ref _alreadyFetchedShift, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnShiftPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 departmentID, System.Int32 employeeID, System.Byte shiftID, System.DateTime startDate, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)EmployeeDepartmentHistoryFieldIndex.DepartmentID].ForcedCurrentValueWrite(departmentID);
				this.Fields[(int)EmployeeDepartmentHistoryFieldIndex.EmployeeID].ForcedCurrentValueWrite(employeeID);
				this.Fields[(int)EmployeeDepartmentHistoryFieldIndex.ShiftID].ForcedCurrentValueWrite(shiftID);
				this.Fields[(int)EmployeeDepartmentHistoryFieldIndex.StartDate].ForcedCurrentValueWrite(startDate);
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
			return DAOFactory.CreateEmployeeDepartmentHistoryDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new EmployeeDepartmentHistoryEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static EmployeeDepartmentHistoryRelations Relations
		{
			get	{ return new EmployeeDepartmentHistoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Department'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDepartment
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.DepartmentCollection(), (IEntityRelation)GetRelationsForField("Department")[0], (int)AW.Data.EntityType.EmployeeDepartmentHistoryEntity, (int)AW.Data.EntityType.DepartmentEntity, 0, null, null, null, "Department", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.EmployeeCollection(), (IEntityRelation)GetRelationsForField("Employee")[0], (int)AW.Data.EntityType.EmployeeDepartmentHistoryEntity, (int)AW.Data.EntityType.EmployeeEntity, 0, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Shift'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathShift
		{
			get	{ return new PrefetchPathElement(new AW.Data.CollectionClasses.ShiftCollection(), (IEntityRelation)GetRelationsForField("Shift")[0], (int)AW.Data.EntityType.EmployeeDepartmentHistoryEntity, (int)AW.Data.EntityType.ShiftEntity, 0, null, null, null, "Shift", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "EmployeeDepartmentHistoryEntity";}
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

		/// <summary> The DepartmentID property of the Entity EmployeeDepartmentHistory<br/><br/>
		/// MS_Description: Department in which the employee worked including currently. Foreign key to Department.DepartmentID.<br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeDepartmentHistory"."DepartmentID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int16 DepartmentID
		{
			get { return (System.Int16)GetValue((int)EmployeeDepartmentHistoryFieldIndex.DepartmentID, true); }
			set	{ SetValue((int)EmployeeDepartmentHistoryFieldIndex.DepartmentID, value, true); }
		}

		/// <summary> The EmployeeID property of the Entity EmployeeDepartmentHistory<br/><br/>
		/// MS_Description: Clustered index created by a primary key constraint.<br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeDepartmentHistory"."EmployeeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 EmployeeID
		{
			get { return (System.Int32)GetValue((int)EmployeeDepartmentHistoryFieldIndex.EmployeeID, true); }
			set	{ SetValue((int)EmployeeDepartmentHistoryFieldIndex.EmployeeID, value, true); }
		}

		/// <summary> The EndDate property of the Entity EmployeeDepartmentHistory<br/><br/>
		/// MS_Description: Date the employee left the department. NULL = Current department.<br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeDepartmentHistory"."EndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> EndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)EmployeeDepartmentHistoryFieldIndex.EndDate, false); }
			set	{ SetValue((int)EmployeeDepartmentHistoryFieldIndex.EndDate, value, true); }
		}

		/// <summary> The ModifiedDate property of the Entity EmployeeDepartmentHistory<br/><br/>
		/// MS_Description: Date and time the record was last updated.<br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeDepartmentHistory"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeDepartmentHistoryFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)EmployeeDepartmentHistoryFieldIndex.ModifiedDate, value, true); }
		}

		/// <summary> The ShiftID property of the Entity EmployeeDepartmentHistory<br/><br/>
		/// MS_Description: Nonclustered index.<br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeDepartmentHistory"."ShiftID"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Byte ShiftID
		{
			get { return (System.Byte)GetValue((int)EmployeeDepartmentHistoryFieldIndex.ShiftID, true); }
			set	{ SetValue((int)EmployeeDepartmentHistoryFieldIndex.ShiftID, value, true); }
		}

		/// <summary> The StartDate property of the Entity EmployeeDepartmentHistory<br/><br/>
		/// MS_Description: Date the employee started work in the department.<br/></summary>
		/// <remarks>Mapped on  table field: "EmployeeDepartmentHistory"."StartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.DateTime StartDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeDepartmentHistoryFieldIndex.StartDate, true); }
			set	{ SetValue((int)EmployeeDepartmentHistoryFieldIndex.StartDate, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'DepartmentEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleDepartment()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual DepartmentEntity Department
		{
			get	{ return GetSingleDepartment(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncDepartment(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "EmployeeDepartmentHistories", "Department", _department, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Department. When set to true, Department is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Department is accessed. You can always execute a forced fetch by calling GetSingleDepartment(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDepartment
		{
			get	{ return _alwaysFetchDepartment; }
			set	{ _alwaysFetchDepartment = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Department already has been fetched. Setting this property to false when Department has been fetched
		/// will set Department to null as well. Setting this property to true while Department hasn't been fetched disables lazy loading for Department</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDepartment
		{
			get { return _alreadyFetchedDepartment;}
			set 
			{
				if(_alreadyFetchedDepartment && !value)
				{
					this.Department = null;
				}
				_alreadyFetchedDepartment = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Department is not found
		/// in the database. When set to true, Department will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool DepartmentReturnsNewIfNotFound
		{
			get	{ return _departmentReturnsNewIfNotFound; }
			set { _departmentReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual EmployeeEntity Employee
		{
			get	{ return GetSingleEmployee(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncEmployee(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "EmployeeDepartmentHistories", "Employee", _employee, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee. When set to true, Employee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee is accessed. You can always execute a forced fetch by calling GetSingleEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee
		{
			get	{ return _alwaysFetchEmployee; }
			set	{ _alwaysFetchEmployee = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee already has been fetched. Setting this property to false when Employee has been fetched
		/// will set Employee to null as well. Setting this property to true while Employee hasn't been fetched disables lazy loading for Employee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee
		{
			get { return _alreadyFetchedEmployee;}
			set 
			{
				if(_alreadyFetchedEmployee && !value)
				{
					this.Employee = null;
				}
				_alreadyFetchedEmployee = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee is not found
		/// in the database. When set to true, Employee will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool EmployeeReturnsNewIfNotFound
		{
			get	{ return _employeeReturnsNewIfNotFound; }
			set { _employeeReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'ShiftEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleShift()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual ShiftEntity Shift
		{
			get	{ return GetSingleShift(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncShift(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "EmployeeDepartmentHistories", "Shift", _shift, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Shift. When set to true, Shift is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Shift is accessed. You can always execute a forced fetch by calling GetSingleShift(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchShift
		{
			get	{ return _alwaysFetchShift; }
			set	{ _alwaysFetchShift = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Shift already has been fetched. Setting this property to false when Shift has been fetched
		/// will set Shift to null as well. Setting this property to true while Shift hasn't been fetched disables lazy loading for Shift</summary>
		[Browsable(false)]
		public bool AlreadyFetchedShift
		{
			get { return _alreadyFetchedShift;}
			set 
			{
				if(_alreadyFetchedShift && !value)
				{
					this.Shift = null;
				}
				_alreadyFetchedShift = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Shift is not found
		/// in the database. When set to true, Shift will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ShiftReturnsNewIfNotFound
		{
			get	{ return _shiftReturnsNewIfNotFound; }
			set { _shiftReturnsNewIfNotFound = value; }	
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
			get { return (int)AW.Data.EntityType.EmployeeDepartmentHistoryEntity; }
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
