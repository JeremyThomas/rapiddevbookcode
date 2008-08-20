///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:29 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using AW.Data.EntityClasses;
using AW.Data.HelperClasses;
using AW.Data.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	
	/// <summary>Factory to create new, empty AddressEntity objects.</summary>
	[Serializable]
	public class AddressEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty AddressEntity object.</summary>
		/// <returns>A new, empty AddressEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new AddressEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAddress
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new AddressEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAddressUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.AddressEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new AddressCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "AddressEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty AddressTypeEntity objects.</summary>
	[Serializable]
	public class AddressTypeEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty AddressTypeEntity object.</summary>
		/// <returns>A new, empty AddressTypeEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new AddressTypeEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAddressType
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new AddressTypeEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAddressTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.AddressTypeEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new AddressTypeCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "AddressTypeEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ContactEntity objects.</summary>
	[Serializable]
	public class ContactEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty ContactEntity object.</summary>
		/// <returns>A new, empty ContactEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new ContactEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewContact
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new ContactEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewContactUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ContactEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new ContactCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "ContactEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CountryRegionEntity objects.</summary>
	[Serializable]
	public class CountryRegionEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty CountryRegionEntity object.</summary>
		/// <returns>A new, empty CountryRegionEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new CountryRegionEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCountryRegion
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new CountryRegionEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCountryRegionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.CountryRegionEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new CountryRegionCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "CountryRegionEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CustomerEntity objects.</summary>
	[Serializable]
	public class CustomerEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty CustomerEntity object.</summary>
		/// <returns>A new, empty CustomerEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new CustomerEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomer
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new CustomerEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.CustomerEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new CustomerCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "CustomerEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CustomerAddressEntity objects.</summary>
	[Serializable]
	public class CustomerAddressEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty CustomerAddressEntity object.</summary>
		/// <returns>A new, empty CustomerAddressEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new CustomerAddressEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerAddress
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new CustomerAddressEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerAddressUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.CustomerAddressEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new CustomerAddressCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "CustomerAddressEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CustomerViewRelatedEntity objects.</summary>
	[Serializable]
	public class CustomerViewRelatedEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty CustomerViewRelatedEntity object.</summary>
		/// <returns>A new, empty CustomerViewRelatedEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new CustomerViewRelatedEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerViewRelated
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new CustomerViewRelatedEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerViewRelatedUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.CustomerViewRelatedEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new CustomerViewRelatedCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "CustomerViewRelatedEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EmployeeEntity objects.</summary>
	[Serializable]
	public class EmployeeEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty EmployeeEntity object.</summary>
		/// <returns>A new, empty EmployeeEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new EmployeeEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployee
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new EmployeeEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.EmployeeEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new EmployeeCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "EmployeeEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EmployeeAddressEntity objects.</summary>
	[Serializable]
	public class EmployeeAddressEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty EmployeeAddressEntity object.</summary>
		/// <returns>A new, empty EmployeeAddressEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new EmployeeAddressEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeAddress
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new EmployeeAddressEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeAddressUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.EmployeeAddressEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new EmployeeAddressCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "EmployeeAddressEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty IndividualEntity objects.</summary>
	[Serializable]
	public class IndividualEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty IndividualEntity object.</summary>
		/// <returns>A new, empty IndividualEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new IndividualEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIndividual
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new IndividualEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIndividualUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.IndividualEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new IndividualCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "IndividualEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductEntity objects.</summary>
	[Serializable]
	public class ProductEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty ProductEntity object.</summary>
		/// <returns>A new, empty ProductEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new ProductEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProduct
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new ProductEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ProductEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new ProductCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "ProductEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SalesOrderDetailEntity objects.</summary>
	[Serializable]
	public class SalesOrderDetailEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty SalesOrderDetailEntity object.</summary>
		/// <returns>A new, empty SalesOrderDetailEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new SalesOrderDetailEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderDetail
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new SalesOrderDetailEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderDetailUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.SalesOrderDetailEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new SalesOrderDetailCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "SalesOrderDetailEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SalesOrderHeaderEntity objects.</summary>
	[Serializable]
	public class SalesOrderHeaderEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty SalesOrderHeaderEntity object.</summary>
		/// <returns>A new, empty SalesOrderHeaderEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new SalesOrderHeaderEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderHeader
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new SalesOrderHeaderEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderHeaderUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.SalesOrderHeaderEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new SalesOrderHeaderCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "SalesOrderHeaderEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ShipMethodEntity objects.</summary>
	[Serializable]
	public class ShipMethodEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty ShipMethodEntity object.</summary>
		/// <returns>A new, empty ShipMethodEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new ShipMethodEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewShipMethod
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new ShipMethodEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewShipMethodUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.ShipMethodEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new ShipMethodCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "ShipMethodEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SpecialOfferEntity objects.</summary>
	[Serializable]
	public class SpecialOfferEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty SpecialOfferEntity object.</summary>
		/// <returns>A new, empty SpecialOfferEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new SpecialOfferEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSpecialOffer
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new SpecialOfferEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSpecialOfferUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.SpecialOfferEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new SpecialOfferCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "SpecialOfferEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SpecialOfferProductEntity objects.</summary>
	[Serializable]
	public class SpecialOfferProductEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty SpecialOfferProductEntity object.</summary>
		/// <returns>A new, empty SpecialOfferProductEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new SpecialOfferProductEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSpecialOfferProduct
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new SpecialOfferProductEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSpecialOfferProductUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.SpecialOfferProductEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new SpecialOfferProductCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "SpecialOfferProductEntity"; }
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty StateProvinceEntity objects.</summary>
	[Serializable]
	public class StateProvinceEntityFactory : IEntityFactory
	{
		/// <summary>Creates a new, empty StateProvinceEntity object.</summary>
		/// <returns>A new, empty StateProvinceEntity object.</returns>
		public virtual IEntity Create()
		{
			IEntity toReturn = new StateProvinceEntity(new PropertyDescriptorFactory(), this);
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStateProvince
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;

		}
		
		/// <summary>Creates a new StateProvinceEntity instance but uses a special constructor which will set the Fields object of the new
		/// IEntity instance to the passed in fields object. Implement this method to support multi-type in single table inheritance.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public virtual IEntity Create(IEntityFields fields)
		{
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStateProvinceUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. This method is used by internal code to create the fields object to store fetched data. 
		/// </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(AW.Data.EntityType.StateProvinceEntity);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public virtual IEntityFields CreateHierarchyFields()
		{
			return this.CreateFields();
		}
		
		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public virtual IRelationCollection CreateHierarchyRelations()
		{
			return null;			
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public virtual IEntityFactory GetEntityFactory(object[] fieldValues, Hashtable entityFieldStartIndexesPerEntity)
		{
			return this;
		}
		
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public virtual IEntityCollection CreateEntityCollection()
		{
			return new StateProvinceCollection();
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public virtual string ForEntityName 
		{ 
			get { return "StateProvinceEntity"; }
		}

		#region Included Code

		#endregion
	}


	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses entity specific factory objects
	/// </summary>
	[Serializable]
	public class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity Create(EntityType entityTypeToCreate)
		{
			IEntityFactory factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case AW.Data.EntityType.AddressEntity:
					factoryToUse = new AddressEntityFactory();
					break;
				case AW.Data.EntityType.AddressTypeEntity:
					factoryToUse = new AddressTypeEntityFactory();
					break;
				case AW.Data.EntityType.ContactEntity:
					factoryToUse = new ContactEntityFactory();
					break;
				case AW.Data.EntityType.CountryRegionEntity:
					factoryToUse = new CountryRegionEntityFactory();
					break;
				case AW.Data.EntityType.CustomerEntity:
					factoryToUse = new CustomerEntityFactory();
					break;
				case AW.Data.EntityType.CustomerAddressEntity:
					factoryToUse = new CustomerAddressEntityFactory();
					break;
				case AW.Data.EntityType.CustomerViewRelatedEntity:
					factoryToUse = new CustomerViewRelatedEntityFactory();
					break;
				case AW.Data.EntityType.EmployeeEntity:
					factoryToUse = new EmployeeEntityFactory();
					break;
				case AW.Data.EntityType.EmployeeAddressEntity:
					factoryToUse = new EmployeeAddressEntityFactory();
					break;
				case AW.Data.EntityType.IndividualEntity:
					factoryToUse = new IndividualEntityFactory();
					break;
				case AW.Data.EntityType.ProductEntity:
					factoryToUse = new ProductEntityFactory();
					break;
				case AW.Data.EntityType.SalesOrderDetailEntity:
					factoryToUse = new SalesOrderDetailEntityFactory();
					break;
				case AW.Data.EntityType.SalesOrderHeaderEntity:
					factoryToUse = new SalesOrderHeaderEntityFactory();
					break;
				case AW.Data.EntityType.ShipMethodEntity:
					factoryToUse = new ShipMethodEntityFactory();
					break;
				case AW.Data.EntityType.SpecialOfferEntity:
					factoryToUse = new SpecialOfferEntityFactory();
					break;
				case AW.Data.EntityType.SpecialOfferProductEntity:
					factoryToUse = new SpecialOfferProductEntityFactory();
					break;
				case AW.Data.EntityType.StateProvinceEntity:
					factoryToUse = new StateProvinceEntityFactory();
					break;
			}
			return factoryToUse.Create();
		}		
	}
}
