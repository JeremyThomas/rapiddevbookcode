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
using System.Collections.Generic;
using AW.Data.HelperClasses;

using AW.Data.EntityClasses;
using AW.Data.RelationClasses;
using AW.Data.DaoClasses;
using AW.Data.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase : EntityFactoryCore
	{
		private string _entityName;
		private AW.Data.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase(string entityName, AW.Data.EntityType typeOfEntity)
		{
			_entityName = entityName;
			_typeOfEntity = typeOfEntity;
		}

		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((AW.Data.EntityType)entityTypeValue);
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public override IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(_entityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			IEntityFactory toReturn = (IEntityFactory)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(_entityName, fieldValues, entityFieldStartIndexesPerEntity);
			if(toReturn == null)
			{
				toReturn = this;
			}
			return toReturn;
		}
						
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public override IEntityCollection CreateEntityCollection()
		{
			return GeneralEntityCollectionFactory.Create(_typeOfEntity);
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public override string ForEntityName 
		{ 
			get { return _entityName; }
		}
	}
	
	/// <summary>Factory to create new, empty AddressEntity objects.</summary>
	[Serializable]
	public partial class AddressEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AddressEntityFactory() : base("AddressEntity", AW.Data.EntityType.AddressEntity) { }

		/// <summary>Creates a new, empty AddressEntity object.</summary>
		/// <returns>A new, empty AddressEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AddressEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAddress
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new AddressEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAddressUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty AddressTypeEntity objects.</summary>
	[Serializable]
	public partial class AddressTypeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AddressTypeEntityFactory() : base("AddressTypeEntity", AW.Data.EntityType.AddressTypeEntity) { }

		/// <summary>Creates a new, empty AddressTypeEntity object.</summary>
		/// <returns>A new, empty AddressTypeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AddressTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAddressType
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new AddressTypeEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAddressTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ContactEntity objects.</summary>
	[Serializable]
	public partial class ContactEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ContactEntityFactory() : base("ContactEntity", AW.Data.EntityType.ContactEntity) { }

		/// <summary>Creates a new, empty ContactEntity object.</summary>
		/// <returns>A new, empty ContactEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ContactEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewContact
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new ContactEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewContactUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CountryRegionEntity objects.</summary>
	[Serializable]
	public partial class CountryRegionEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CountryRegionEntityFactory() : base("CountryRegionEntity", AW.Data.EntityType.CountryRegionEntity) { }

		/// <summary>Creates a new, empty CountryRegionEntity object.</summary>
		/// <returns>A new, empty CountryRegionEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CountryRegionEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCountryRegion
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new CountryRegionEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCountryRegionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CustomerEntity objects.</summary>
	[Serializable]
	public partial class CustomerEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CustomerEntityFactory() : base("CustomerEntity", AW.Data.EntityType.CustomerEntity) { }

		/// <summary>Creates a new, empty CustomerEntity object.</summary>
		/// <returns>A new, empty CustomerEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CustomerEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomer
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new CustomerEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CustomerAddressEntity objects.</summary>
	[Serializable]
	public partial class CustomerAddressEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CustomerAddressEntityFactory() : base("CustomerAddressEntity", AW.Data.EntityType.CustomerAddressEntity) { }

		/// <summary>Creates a new, empty CustomerAddressEntity object.</summary>
		/// <returns>A new, empty CustomerAddressEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CustomerAddressEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerAddress
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new CustomerAddressEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerAddressUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CustomerViewRelatedEntity objects.</summary>
	[Serializable]
	public partial class CustomerViewRelatedEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CustomerViewRelatedEntityFactory() : base("CustomerViewRelatedEntity", AW.Data.EntityType.CustomerViewRelatedEntity) { }

		/// <summary>Creates a new, empty CustomerViewRelatedEntity object.</summary>
		/// <returns>A new, empty CustomerViewRelatedEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CustomerViewRelatedEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerViewRelated
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new CustomerViewRelatedEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerViewRelatedUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EmployeeEntity objects.</summary>
	[Serializable]
	public partial class EmployeeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public EmployeeEntityFactory() : base("EmployeeEntity", AW.Data.EntityType.EmployeeEntity) { }

		/// <summary>Creates a new, empty EmployeeEntity object.</summary>
		/// <returns>A new, empty EmployeeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new EmployeeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployee
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new EmployeeEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EmployeeAddressEntity objects.</summary>
	[Serializable]
	public partial class EmployeeAddressEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public EmployeeAddressEntityFactory() : base("EmployeeAddressEntity", AW.Data.EntityType.EmployeeAddressEntity) { }

		/// <summary>Creates a new, empty EmployeeAddressEntity object.</summary>
		/// <returns>A new, empty EmployeeAddressEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new EmployeeAddressEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeAddress
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new EmployeeAddressEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeAddressUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty IndividualEntity objects.</summary>
	[Serializable]
	public partial class IndividualEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public IndividualEntityFactory() : base("IndividualEntity", AW.Data.EntityType.IndividualEntity) { }

		/// <summary>Creates a new, empty IndividualEntity object.</summary>
		/// <returns>A new, empty IndividualEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new IndividualEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIndividual
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new IndividualEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIndividualUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductEntity objects.</summary>
	[Serializable]
	public partial class ProductEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductEntityFactory() : base("ProductEntity", AW.Data.EntityType.ProductEntity) { }

		/// <summary>Creates a new, empty ProductEntity object.</summary>
		/// <returns>A new, empty ProductEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProduct
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new ProductEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SalesOrderDetailEntity objects.</summary>
	[Serializable]
	public partial class SalesOrderDetailEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SalesOrderDetailEntityFactory() : base("SalesOrderDetailEntity", AW.Data.EntityType.SalesOrderDetailEntity) { }

		/// <summary>Creates a new, empty SalesOrderDetailEntity object.</summary>
		/// <returns>A new, empty SalesOrderDetailEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SalesOrderDetailEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderDetail
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new SalesOrderDetailEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderDetailUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SalesOrderHeaderEntity objects.</summary>
	[Serializable]
	public partial class SalesOrderHeaderEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SalesOrderHeaderEntityFactory() : base("SalesOrderHeaderEntity", AW.Data.EntityType.SalesOrderHeaderEntity) { }

		/// <summary>Creates a new, empty SalesOrderHeaderEntity object.</summary>
		/// <returns>A new, empty SalesOrderHeaderEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SalesOrderHeaderEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderHeader
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new SalesOrderHeaderEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderHeaderUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ShipMethodEntity objects.</summary>
	[Serializable]
	public partial class ShipMethodEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ShipMethodEntityFactory() : base("ShipMethodEntity", AW.Data.EntityType.ShipMethodEntity) { }

		/// <summary>Creates a new, empty ShipMethodEntity object.</summary>
		/// <returns>A new, empty ShipMethodEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ShipMethodEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewShipMethod
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new ShipMethodEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewShipMethodUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SpecialOfferEntity objects.</summary>
	[Serializable]
	public partial class SpecialOfferEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SpecialOfferEntityFactory() : base("SpecialOfferEntity", AW.Data.EntityType.SpecialOfferEntity) { }

		/// <summary>Creates a new, empty SpecialOfferEntity object.</summary>
		/// <returns>A new, empty SpecialOfferEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SpecialOfferEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSpecialOffer
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new SpecialOfferEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSpecialOfferUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SpecialOfferProductEntity objects.</summary>
	[Serializable]
	public partial class SpecialOfferProductEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SpecialOfferProductEntityFactory() : base("SpecialOfferProductEntity", AW.Data.EntityType.SpecialOfferProductEntity) { }

		/// <summary>Creates a new, empty SpecialOfferProductEntity object.</summary>
		/// <returns>A new, empty SpecialOfferProductEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SpecialOfferProductEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSpecialOfferProduct
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new SpecialOfferProductEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSpecialOfferProductUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty StateProvinceEntity objects.</summary>
	[Serializable]
	public partial class StateProvinceEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public StateProvinceEntityFactory() : base("StateProvinceEntity", AW.Data.EntityType.StateProvinceEntity) { }

		/// <summary>Creates a new, empty StateProvinceEntity object.</summary>
		/// <returns>A new, empty StateProvinceEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new StateProvinceEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStateProvince
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		
		/// <summary>Creates a new StateProvinceEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStateProvinceUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new entity collection objects</summary>
	[Serializable]
	public partial class GeneralEntityCollectionFactory
	{
		/// <summary>Creates a new entity collection</summary>
		/// <param name="typeToUse">The entity type to create the collection for.</param>
		/// <returns>A new entity collection object.</returns>
		public static IEntityCollection Create(AW.Data.EntityType typeToUse)
		{
			switch(typeToUse)
			{
				case AW.Data.EntityType.AddressEntity:
					return new AddressCollection();
				case AW.Data.EntityType.AddressTypeEntity:
					return new AddressTypeCollection();
				case AW.Data.EntityType.ContactEntity:
					return new ContactCollection();
				case AW.Data.EntityType.CountryRegionEntity:
					return new CountryRegionCollection();
				case AW.Data.EntityType.CustomerEntity:
					return new CustomerCollection();
				case AW.Data.EntityType.CustomerAddressEntity:
					return new CustomerAddressCollection();
				case AW.Data.EntityType.CustomerViewRelatedEntity:
					return new CustomerViewRelatedCollection();
				case AW.Data.EntityType.EmployeeEntity:
					return new EmployeeCollection();
				case AW.Data.EntityType.EmployeeAddressEntity:
					return new EmployeeAddressCollection();
				case AW.Data.EntityType.IndividualEntity:
					return new IndividualCollection();
				case AW.Data.EntityType.ProductEntity:
					return new ProductCollection();
				case AW.Data.EntityType.SalesOrderDetailEntity:
					return new SalesOrderDetailCollection();
				case AW.Data.EntityType.SalesOrderHeaderEntity:
					return new SalesOrderHeaderCollection();
				case AW.Data.EntityType.ShipMethodEntity:
					return new ShipMethodCollection();
				case AW.Data.EntityType.SpecialOfferEntity:
					return new SpecialOfferCollection();
				case AW.Data.EntityType.SpecialOfferProductEntity:
					return new SpecialOfferProductCollection();
				case AW.Data.EntityType.StateProvinceEntity:
					return new StateProvinceCollection();
				default:
					return null;
			}
		}		
	}
	
	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity Create(AW.Data.EntityType entityTypeToCreate)
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
			IEntity toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
	
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
#if CF
		/// <summary>Gets the factory of the entity with the AW.Data.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(AW.Data.EntityType typeOfEntity)
		{
			return GeneralEntityFactory.Create(typeOfEntity).GetEntityFactory();
		}
#else
		private static Dictionary<Type, IEntityFactory> _factoryPerType = new Dictionary<Type, IEntityFactory>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(AW.Data.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity dummy = GeneralEntityFactory.Create((AW.Data.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Type typeOfEntity)
		{
			IEntityFactory toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the AW.Data.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(AW.Data.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
#endif
	}
	
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator
	{
		/// <summary>Gets the factory of the Entity type with the AW.Data.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(int entityTypeValue)
		{
			return (IEntityFactory)this.GetFactoryImpl(entityTypeValue);
		}

		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}
		
		/// <summary>Gets an instance of the TypedListDAO class to execute dynamic lists and projections.</summary>
		/// <returns>ready to use typedlistDAO</returns>
		public IDao GetTypedListDao()
		{
			return new TypedListDAO();
		}
		
		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (AW.Data.EntityType)Enum.Parse(typeof(AW.Data.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((AW.Data.EntityType)Enum.Parse(typeof(AW.Data.EntityType), leftOperandEntityName, false), joinType, (AW.Data.EntityType)Enum.Parse(typeof(AW.Data.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
				
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}

		/// <summary>Implementation of the routine which gets the factory of the Entity type with the AW.Data.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((AW.Data.EntityType)entityTypeValue);
		}
#if !CF		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}
#endif
	}
}
