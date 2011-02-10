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
		private readonly AW.Data.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase(string entityName, AW.Data.EntityType typeOfEntity) : base(entityName)
		{
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
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(ForEntityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return (IEntityFactory)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(ForEntityName, fieldValues, entityFieldStartIndexesPerEntity) ?? this;
		}
						
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public override IEntityCollection CreateEntityCollection()
		{
			return GeneralEntityCollectionFactory.Create(_typeOfEntity);
		}
	}
	
	/// <summary>Factory to create new, empty AwbuildVersionEntity objects.</summary>
	[Serializable]
	public partial class AwbuildVersionEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AwbuildVersionEntityFactory() : base("AwbuildVersionEntity", AW.Data.EntityType.AwbuildVersionEntity) { }

		/// <summary>Creates a new, empty AwbuildVersionEntity object.</summary>
		/// <returns>A new, empty AwbuildVersionEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AwbuildVersionEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAwbuildVersion
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty DatabaseLogEntity objects.</summary>
	[Serializable]
	public partial class DatabaseLogEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public DatabaseLogEntityFactory() : base("DatabaseLogEntity", AW.Data.EntityType.DatabaseLogEntity) { }

		/// <summary>Creates a new, empty DatabaseLogEntity object.</summary>
		/// <returns>A new, empty DatabaseLogEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new DatabaseLogEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDatabaseLog
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ErrorLogEntity objects.</summary>
	[Serializable]
	public partial class ErrorLogEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ErrorLogEntityFactory() : base("ErrorLogEntity", AW.Data.EntityType.ErrorLogEntity) { }

		/// <summary>Creates a new, empty ErrorLogEntity object.</summary>
		/// <returns>A new, empty ErrorLogEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ErrorLogEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewErrorLog
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty DepartmentEntity objects.</summary>
	[Serializable]
	public partial class DepartmentEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public DepartmentEntityFactory() : base("DepartmentEntity", AW.Data.EntityType.DepartmentEntity) { }

		/// <summary>Creates a new, empty DepartmentEntity object.</summary>
		/// <returns>A new, empty DepartmentEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new DepartmentEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDepartment
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

		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields CreateHierarchyFields()
		{
			return new EntityFields(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields("EmployeeEntity"), InheritanceInfoProviderSingleton.GetInstance(), null);
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


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EmployeeDepartmentHistoryEntity objects.</summary>
	[Serializable]
	public partial class EmployeeDepartmentHistoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public EmployeeDepartmentHistoryEntityFactory() : base("EmployeeDepartmentHistoryEntity", AW.Data.EntityType.EmployeeDepartmentHistoryEntity) { }

		/// <summary>Creates a new, empty EmployeeDepartmentHistoryEntity object.</summary>
		/// <returns>A new, empty EmployeeDepartmentHistoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new EmployeeDepartmentHistoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeDepartmentHistory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EmployeePayHistoryEntity objects.</summary>
	[Serializable]
	public partial class EmployeePayHistoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public EmployeePayHistoryEntityFactory() : base("EmployeePayHistoryEntity", AW.Data.EntityType.EmployeePayHistoryEntity) { }

		/// <summary>Creates a new, empty EmployeePayHistoryEntity object.</summary>
		/// <returns>A new, empty EmployeePayHistoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new EmployeePayHistoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeePayHistory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty JobCandidateEntity objects.</summary>
	[Serializable]
	public partial class JobCandidateEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public JobCandidateEntityFactory() : base("JobCandidateEntity", AW.Data.EntityType.JobCandidateEntity) { }

		/// <summary>Creates a new, empty JobCandidateEntity object.</summary>
		/// <returns>A new, empty JobCandidateEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new JobCandidateEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewJobCandidate
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ShiftEntity objects.</summary>
	[Serializable]
	public partial class ShiftEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ShiftEntityFactory() : base("ShiftEntity", AW.Data.EntityType.ShiftEntity) { }

		/// <summary>Creates a new, empty ShiftEntity object.</summary>
		/// <returns>A new, empty ShiftEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ShiftEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewShift
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
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


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ContactTypeEntity objects.</summary>
	[Serializable]
	public partial class ContactTypeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ContactTypeEntityFactory() : base("ContactTypeEntity", AW.Data.EntityType.ContactTypeEntity) { }

		/// <summary>Creates a new, empty ContactTypeEntity object.</summary>
		/// <returns>A new, empty ContactTypeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ContactTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewContactType
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


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BillOfMaterialEntity objects.</summary>
	[Serializable]
	public partial class BillOfMaterialEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BillOfMaterialEntityFactory() : base("BillOfMaterialEntity", AW.Data.EntityType.BillOfMaterialEntity) { }

		/// <summary>Creates a new, empty BillOfMaterialEntity object.</summary>
		/// <returns>A new, empty BillOfMaterialEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BillOfMaterialEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBillOfMaterial
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CultureEntity objects.</summary>
	[Serializable]
	public partial class CultureEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CultureEntityFactory() : base("CultureEntity", AW.Data.EntityType.CultureEntity) { }

		/// <summary>Creates a new, empty CultureEntity object.</summary>
		/// <returns>A new, empty CultureEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CultureEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCulture
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty DocumentEntity objects.</summary>
	[Serializable]
	public partial class DocumentEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public DocumentEntityFactory() : base("DocumentEntity", AW.Data.EntityType.DocumentEntity) { }

		/// <summary>Creates a new, empty DocumentEntity object.</summary>
		/// <returns>A new, empty DocumentEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new DocumentEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDocument
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty IllustrationEntity objects.</summary>
	[Serializable]
	public partial class IllustrationEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public IllustrationEntityFactory() : base("IllustrationEntity", AW.Data.EntityType.IllustrationEntity) { }

		/// <summary>Creates a new, empty IllustrationEntity object.</summary>
		/// <returns>A new, empty IllustrationEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new IllustrationEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIllustration
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LocationEntity objects.</summary>
	[Serializable]
	public partial class LocationEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LocationEntityFactory() : base("LocationEntity", AW.Data.EntityType.LocationEntity) { }

		/// <summary>Creates a new, empty LocationEntity object.</summary>
		/// <returns>A new, empty LocationEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LocationEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLocation
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


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductCategoryEntity objects.</summary>
	[Serializable]
	public partial class ProductCategoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductCategoryEntityFactory() : base("ProductCategoryEntity", AW.Data.EntityType.ProductCategoryEntity) { }

		/// <summary>Creates a new, empty ProductCategoryEntity object.</summary>
		/// <returns>A new, empty ProductCategoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductCategoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductCategory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductCostHistoryEntity objects.</summary>
	[Serializable]
	public partial class ProductCostHistoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductCostHistoryEntityFactory() : base("ProductCostHistoryEntity", AW.Data.EntityType.ProductCostHistoryEntity) { }

		/// <summary>Creates a new, empty ProductCostHistoryEntity object.</summary>
		/// <returns>A new, empty ProductCostHistoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductCostHistoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductCostHistory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductDescriptionEntity objects.</summary>
	[Serializable]
	public partial class ProductDescriptionEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductDescriptionEntityFactory() : base("ProductDescriptionEntity", AW.Data.EntityType.ProductDescriptionEntity) { }

		/// <summary>Creates a new, empty ProductDescriptionEntity object.</summary>
		/// <returns>A new, empty ProductDescriptionEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductDescriptionEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductDescription
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductDocumentEntity objects.</summary>
	[Serializable]
	public partial class ProductDocumentEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductDocumentEntityFactory() : base("ProductDocumentEntity", AW.Data.EntityType.ProductDocumentEntity) { }

		/// <summary>Creates a new, empty ProductDocumentEntity object.</summary>
		/// <returns>A new, empty ProductDocumentEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductDocumentEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductDocument
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductInventoryEntity objects.</summary>
	[Serializable]
	public partial class ProductInventoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductInventoryEntityFactory() : base("ProductInventoryEntity", AW.Data.EntityType.ProductInventoryEntity) { }

		/// <summary>Creates a new, empty ProductInventoryEntity object.</summary>
		/// <returns>A new, empty ProductInventoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductInventoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductInventory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductListPriceHistoryEntity objects.</summary>
	[Serializable]
	public partial class ProductListPriceHistoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductListPriceHistoryEntityFactory() : base("ProductListPriceHistoryEntity", AW.Data.EntityType.ProductListPriceHistoryEntity) { }

		/// <summary>Creates a new, empty ProductListPriceHistoryEntity object.</summary>
		/// <returns>A new, empty ProductListPriceHistoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductListPriceHistoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductListPriceHistory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductModelEntity objects.</summary>
	[Serializable]
	public partial class ProductModelEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductModelEntityFactory() : base("ProductModelEntity", AW.Data.EntityType.ProductModelEntity) { }

		/// <summary>Creates a new, empty ProductModelEntity object.</summary>
		/// <returns>A new, empty ProductModelEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductModelEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductModel
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductModelIllustrationEntity objects.</summary>
	[Serializable]
	public partial class ProductModelIllustrationEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductModelIllustrationEntityFactory() : base("ProductModelIllustrationEntity", AW.Data.EntityType.ProductModelIllustrationEntity) { }

		/// <summary>Creates a new, empty ProductModelIllustrationEntity object.</summary>
		/// <returns>A new, empty ProductModelIllustrationEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductModelIllustrationEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductModelIllustration
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductModelProductDescriptionCultureEntity objects.</summary>
	[Serializable]
	public partial class ProductModelProductDescriptionCultureEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductModelProductDescriptionCultureEntityFactory() : base("ProductModelProductDescriptionCultureEntity", AW.Data.EntityType.ProductModelProductDescriptionCultureEntity) { }

		/// <summary>Creates a new, empty ProductModelProductDescriptionCultureEntity object.</summary>
		/// <returns>A new, empty ProductModelProductDescriptionCultureEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductModelProductDescriptionCultureEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductModelProductDescriptionCulture
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductPhotoEntity objects.</summary>
	[Serializable]
	public partial class ProductPhotoEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductPhotoEntityFactory() : base("ProductPhotoEntity", AW.Data.EntityType.ProductPhotoEntity) { }

		/// <summary>Creates a new, empty ProductPhotoEntity object.</summary>
		/// <returns>A new, empty ProductPhotoEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductPhotoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductPhoto
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductProductPhotoEntity objects.</summary>
	[Serializable]
	public partial class ProductProductPhotoEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductProductPhotoEntityFactory() : base("ProductProductPhotoEntity", AW.Data.EntityType.ProductProductPhotoEntity) { }

		/// <summary>Creates a new, empty ProductProductPhotoEntity object.</summary>
		/// <returns>A new, empty ProductProductPhotoEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductProductPhotoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductProductPhoto
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductReviewEntity objects.</summary>
	[Serializable]
	public partial class ProductReviewEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductReviewEntityFactory() : base("ProductReviewEntity", AW.Data.EntityType.ProductReviewEntity) { }

		/// <summary>Creates a new, empty ProductReviewEntity object.</summary>
		/// <returns>A new, empty ProductReviewEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductReviewEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductReview
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductSubcategoryEntity objects.</summary>
	[Serializable]
	public partial class ProductSubcategoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductSubcategoryEntityFactory() : base("ProductSubcategoryEntity", AW.Data.EntityType.ProductSubcategoryEntity) { }

		/// <summary>Creates a new, empty ProductSubcategoryEntity object.</summary>
		/// <returns>A new, empty ProductSubcategoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductSubcategoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductSubcategory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty PurchaseOrderHistoryEntity objects.</summary>
	[Serializable]
	public partial class PurchaseOrderHistoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public PurchaseOrderHistoryEntityFactory() : base("PurchaseOrderHistoryEntity", AW.Data.EntityType.PurchaseOrderHistoryEntity) { }

		/// <summary>Creates a new, empty PurchaseOrderHistoryEntity object.</summary>
		/// <returns>A new, empty PurchaseOrderHistoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new PurchaseOrderHistoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPurchaseOrderHistory
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields CreateHierarchyFields()
		{
			return new EntityFields(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields("PurchaseOrderHistoryEntity"), InheritanceInfoProviderSingleton.GetInstance(), null);
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SalesOrderHistoryEntity objects.</summary>
	[Serializable]
	public partial class SalesOrderHistoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SalesOrderHistoryEntityFactory() : base("SalesOrderHistoryEntity", AW.Data.EntityType.SalesOrderHistoryEntity) { }

		/// <summary>Creates a new, empty SalesOrderHistoryEntity object.</summary>
		/// <returns>A new, empty SalesOrderHistoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SalesOrderHistoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderHistory
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields CreateHierarchyFields()
		{
			return new EntityFields(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields("SalesOrderHistoryEntity"), InheritanceInfoProviderSingleton.GetInstance(), null);
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ScrapReasonEntity objects.</summary>
	[Serializable]
	public partial class ScrapReasonEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ScrapReasonEntityFactory() : base("ScrapReasonEntity", AW.Data.EntityType.ScrapReasonEntity) { }

		/// <summary>Creates a new, empty ScrapReasonEntity object.</summary>
		/// <returns>A new, empty ScrapReasonEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ScrapReasonEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewScrapReason
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty TransactionHistoryEntity objects.</summary>
	[Serializable]
	public partial class TransactionHistoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public TransactionHistoryEntityFactory() : base("TransactionHistoryEntity", AW.Data.EntityType.TransactionHistoryEntity) { }

		/// <summary>Creates a new, empty TransactionHistoryEntity object.</summary>
		/// <returns>A new, empty TransactionHistoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new TransactionHistoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTransactionHistory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields CreateHierarchyFields()
		{
			return new EntityFields(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields("TransactionHistoryEntity"), InheritanceInfoProviderSingleton.GetInstance(), null);
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty TransactionHistoryArchiveEntity objects.</summary>
	[Serializable]
	public partial class TransactionHistoryArchiveEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public TransactionHistoryArchiveEntityFactory() : base("TransactionHistoryArchiveEntity", AW.Data.EntityType.TransactionHistoryArchiveEntity) { }

		/// <summary>Creates a new, empty TransactionHistoryArchiveEntity object.</summary>
		/// <returns>A new, empty TransactionHistoryArchiveEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new TransactionHistoryArchiveEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTransactionHistoryArchive
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty UnitMeasureEntity objects.</summary>
	[Serializable]
	public partial class UnitMeasureEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public UnitMeasureEntityFactory() : base("UnitMeasureEntity", AW.Data.EntityType.UnitMeasureEntity) { }

		/// <summary>Creates a new, empty UnitMeasureEntity object.</summary>
		/// <returns>A new, empty UnitMeasureEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new UnitMeasureEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUnitMeasure
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty WorkOrderEntity objects.</summary>
	[Serializable]
	public partial class WorkOrderEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public WorkOrderEntityFactory() : base("WorkOrderEntity", AW.Data.EntityType.WorkOrderEntity) { }

		/// <summary>Creates a new, empty WorkOrderEntity object.</summary>
		/// <returns>A new, empty WorkOrderEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new WorkOrderEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWorkOrder
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty WorkOrderHistoryEntity objects.</summary>
	[Serializable]
	public partial class WorkOrderHistoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public WorkOrderHistoryEntityFactory() : base("WorkOrderHistoryEntity", AW.Data.EntityType.WorkOrderHistoryEntity) { }

		/// <summary>Creates a new, empty WorkOrderHistoryEntity object.</summary>
		/// <returns>A new, empty WorkOrderHistoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new WorkOrderHistoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWorkOrderHistory
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields CreateHierarchyFields()
		{
			return new EntityFields(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields("WorkOrderHistoryEntity"), InheritanceInfoProviderSingleton.GetInstance(), null);
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty WorkOrderRoutingEntity objects.</summary>
	[Serializable]
	public partial class WorkOrderRoutingEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public WorkOrderRoutingEntityFactory() : base("WorkOrderRoutingEntity", AW.Data.EntityType.WorkOrderRoutingEntity) { }

		/// <summary>Creates a new, empty WorkOrderRoutingEntity object.</summary>
		/// <returns>A new, empty WorkOrderRoutingEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new WorkOrderRoutingEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWorkOrderRouting
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductVendorEntity objects.</summary>
	[Serializable]
	public partial class ProductVendorEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductVendorEntityFactory() : base("ProductVendorEntity", AW.Data.EntityType.ProductVendorEntity) { }

		/// <summary>Creates a new, empty ProductVendorEntity object.</summary>
		/// <returns>A new, empty ProductVendorEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductVendorEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductVendor
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty PurchaseOrderDetailEntity objects.</summary>
	[Serializable]
	public partial class PurchaseOrderDetailEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public PurchaseOrderDetailEntityFactory() : base("PurchaseOrderDetailEntity", AW.Data.EntityType.PurchaseOrderDetailEntity) { }

		/// <summary>Creates a new, empty PurchaseOrderDetailEntity object.</summary>
		/// <returns>A new, empty PurchaseOrderDetailEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new PurchaseOrderDetailEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPurchaseOrderDetail
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty PurchaseOrderHeaderEntity objects.</summary>
	[Serializable]
	public partial class PurchaseOrderHeaderEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public PurchaseOrderHeaderEntityFactory() : base("PurchaseOrderHeaderEntity", AW.Data.EntityType.PurchaseOrderHeaderEntity) { }

		/// <summary>Creates a new, empty PurchaseOrderHeaderEntity object.</summary>
		/// <returns>A new, empty PurchaseOrderHeaderEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new PurchaseOrderHeaderEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPurchaseOrderHeader
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


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty VendorEntity objects.</summary>
	[Serializable]
	public partial class VendorEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public VendorEntityFactory() : base("VendorEntity", AW.Data.EntityType.VendorEntity) { }

		/// <summary>Creates a new, empty VendorEntity object.</summary>
		/// <returns>A new, empty VendorEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new VendorEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVendor
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty VendorAddressEntity objects.</summary>
	[Serializable]
	public partial class VendorAddressEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public VendorAddressEntityFactory() : base("VendorAddressEntity", AW.Data.EntityType.VendorAddressEntity) { }

		/// <summary>Creates a new, empty VendorAddressEntity object.</summary>
		/// <returns>A new, empty VendorAddressEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new VendorAddressEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVendorAddress
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty VendorContactEntity objects.</summary>
	[Serializable]
	public partial class VendorContactEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public VendorContactEntityFactory() : base("VendorContactEntity", AW.Data.EntityType.VendorContactEntity) { }

		/// <summary>Creates a new, empty VendorContactEntity object.</summary>
		/// <returns>A new, empty VendorContactEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new VendorContactEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVendorContact
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ContactCreditCardEntity objects.</summary>
	[Serializable]
	public partial class ContactCreditCardEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ContactCreditCardEntityFactory() : base("ContactCreditCardEntity", AW.Data.EntityType.ContactCreditCardEntity) { }

		/// <summary>Creates a new, empty ContactCreditCardEntity object.</summary>
		/// <returns>A new, empty ContactCreditCardEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ContactCreditCardEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewContactCreditCard
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CountryRegionCurrencyEntity objects.</summary>
	[Serializable]
	public partial class CountryRegionCurrencyEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CountryRegionCurrencyEntityFactory() : base("CountryRegionCurrencyEntity", AW.Data.EntityType.CountryRegionCurrencyEntity) { }

		/// <summary>Creates a new, empty CountryRegionCurrencyEntity object.</summary>
		/// <returns>A new, empty CountryRegionCurrencyEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CountryRegionCurrencyEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCountryRegionCurrency
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CreditCardEntity objects.</summary>
	[Serializable]
	public partial class CreditCardEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CreditCardEntityFactory() : base("CreditCardEntity", AW.Data.EntityType.CreditCardEntity) { }

		/// <summary>Creates a new, empty CreditCardEntity object.</summary>
		/// <returns>A new, empty CreditCardEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CreditCardEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCreditCard
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CurrencyEntity objects.</summary>
	[Serializable]
	public partial class CurrencyEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CurrencyEntityFactory() : base("CurrencyEntity", AW.Data.EntityType.CurrencyEntity) { }

		/// <summary>Creates a new, empty CurrencyEntity object.</summary>
		/// <returns>A new, empty CurrencyEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CurrencyEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCurrency
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CurrencyRateEntity objects.</summary>
	[Serializable]
	public partial class CurrencyRateEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CurrencyRateEntityFactory() : base("CurrencyRateEntity", AW.Data.EntityType.CurrencyRateEntity) { }

		/// <summary>Creates a new, empty CurrencyRateEntity object.</summary>
		/// <returns>A new, empty CurrencyRateEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CurrencyRateEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCurrencyRate
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

		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields CreateHierarchyFields()
		{
			return new EntityFields(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields("CustomerEntity"), InheritanceInfoProviderSingleton.GetInstance(), null);
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

		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields CreateHierarchyFields()
		{
			return new EntityFields(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields("IndividualEntity"), InheritanceInfoProviderSingleton.GetInstance(), null);
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
      toReturn.ConcurrencyPredicateFactoryToUse = GeneralConcurrencyPredicateFactory.ConcurrencyPredicateFactory;
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SalesOrderHeaderSalesReasonEntity objects.</summary>
	[Serializable]
	public partial class SalesOrderHeaderSalesReasonEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SalesOrderHeaderSalesReasonEntityFactory() : base("SalesOrderHeaderSalesReasonEntity", AW.Data.EntityType.SalesOrderHeaderSalesReasonEntity) { }

		/// <summary>Creates a new, empty SalesOrderHeaderSalesReasonEntity object.</summary>
		/// <returns>A new, empty SalesOrderHeaderSalesReasonEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SalesOrderHeaderSalesReasonEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderHeaderSalesReason
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SalesPersonEntity objects.</summary>
	[Serializable]
	public partial class SalesPersonEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SalesPersonEntityFactory() : base("SalesPersonEntity", AW.Data.EntityType.SalesPersonEntity) { }

		/// <summary>Creates a new, empty SalesPersonEntity object.</summary>
		/// <returns>A new, empty SalesPersonEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SalesPersonEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesPerson
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields CreateHierarchyFields()
		{
			return new EntityFields(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields("SalesPersonEntity"), InheritanceInfoProviderSingleton.GetInstance(), null);
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SalesPersonQuotaHistoryEntity objects.</summary>
	[Serializable]
	public partial class SalesPersonQuotaHistoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SalesPersonQuotaHistoryEntityFactory() : base("SalesPersonQuotaHistoryEntity", AW.Data.EntityType.SalesPersonQuotaHistoryEntity) { }

		/// <summary>Creates a new, empty SalesPersonQuotaHistoryEntity object.</summary>
		/// <returns>A new, empty SalesPersonQuotaHistoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SalesPersonQuotaHistoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesPersonQuotaHistory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SalesReasonEntity objects.</summary>
	[Serializable]
	public partial class SalesReasonEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SalesReasonEntityFactory() : base("SalesReasonEntity", AW.Data.EntityType.SalesReasonEntity) { }

		/// <summary>Creates a new, empty SalesReasonEntity object.</summary>
		/// <returns>A new, empty SalesReasonEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SalesReasonEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesReason
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SalesTaxRateEntity objects.</summary>
	[Serializable]
	public partial class SalesTaxRateEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SalesTaxRateEntityFactory() : base("SalesTaxRateEntity", AW.Data.EntityType.SalesTaxRateEntity) { }

		/// <summary>Creates a new, empty SalesTaxRateEntity object.</summary>
		/// <returns>A new, empty SalesTaxRateEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SalesTaxRateEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesTaxRate
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SalesTerritoryEntity objects.</summary>
	[Serializable]
	public partial class SalesTerritoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SalesTerritoryEntityFactory() : base("SalesTerritoryEntity", AW.Data.EntityType.SalesTerritoryEntity) { }

		/// <summary>Creates a new, empty SalesTerritoryEntity object.</summary>
		/// <returns>A new, empty SalesTerritoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SalesTerritoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesTerritory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SalesTerritoryHistoryEntity objects.</summary>
	[Serializable]
	public partial class SalesTerritoryHistoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SalesTerritoryHistoryEntityFactory() : base("SalesTerritoryHistoryEntity", AW.Data.EntityType.SalesTerritoryHistoryEntity) { }

		/// <summary>Creates a new, empty SalesTerritoryHistoryEntity object.</summary>
		/// <returns>A new, empty SalesTerritoryHistoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SalesTerritoryHistoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesTerritoryHistory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ShoppingCartItemEntity objects.</summary>
	[Serializable]
	public partial class ShoppingCartItemEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ShoppingCartItemEntityFactory() : base("ShoppingCartItemEntity", AW.Data.EntityType.ShoppingCartItemEntity) { }

		/// <summary>Creates a new, empty ShoppingCartItemEntity object.</summary>
		/// <returns>A new, empty ShoppingCartItemEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ShoppingCartItemEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewShoppingCartItem
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


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty StoreEntity objects.</summary>
	[Serializable]
	public partial class StoreEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public StoreEntityFactory() : base("StoreEntity", AW.Data.EntityType.StoreEntity) { }

		/// <summary>Creates a new, empty StoreEntity object.</summary>
		/// <returns>A new, empty StoreEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new StoreEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStore
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}

		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields CreateHierarchyFields()
		{
			return new EntityFields(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields("StoreEntity"), InheritanceInfoProviderSingleton.GetInstance(), null);
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty StoreContactEntity objects.</summary>
	[Serializable]
	public partial class StoreContactEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public StoreContactEntityFactory() : base("StoreContactEntity", AW.Data.EntityType.StoreContactEntity) { }

		/// <summary>Creates a new, empty StoreContactEntity object.</summary>
		/// <returns>A new, empty StoreContactEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new StoreContactEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStoreContact
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
				case AW.Data.EntityType.AwbuildVersionEntity:
					return new AwbuildVersionCollection();
				case AW.Data.EntityType.DatabaseLogEntity:
					return new DatabaseLogCollection();
				case AW.Data.EntityType.ErrorLogEntity:
					return new ErrorLogCollection();
				case AW.Data.EntityType.DepartmentEntity:
					return new DepartmentCollection();
				case AW.Data.EntityType.EmployeeEntity:
					return new EmployeeCollection();
				case AW.Data.EntityType.EmployeeAddressEntity:
					return new EmployeeAddressCollection();
				case AW.Data.EntityType.EmployeeDepartmentHistoryEntity:
					return new EmployeeDepartmentHistoryCollection();
				case AW.Data.EntityType.EmployeePayHistoryEntity:
					return new EmployeePayHistoryCollection();
				case AW.Data.EntityType.JobCandidateEntity:
					return new JobCandidateCollection();
				case AW.Data.EntityType.ShiftEntity:
					return new ShiftCollection();
				case AW.Data.EntityType.AddressEntity:
					return new AddressCollection();
				case AW.Data.EntityType.AddressTypeEntity:
					return new AddressTypeCollection();
				case AW.Data.EntityType.ContactEntity:
					return new ContactCollection();
				case AW.Data.EntityType.ContactTypeEntity:
					return new ContactTypeCollection();
				case AW.Data.EntityType.CountryRegionEntity:
					return new CountryRegionCollection();
				case AW.Data.EntityType.StateProvinceEntity:
					return new StateProvinceCollection();
				case AW.Data.EntityType.BillOfMaterialEntity:
					return new BillOfMaterialCollection();
				case AW.Data.EntityType.CultureEntity:
					return new CultureCollection();
				case AW.Data.EntityType.DocumentEntity:
					return new DocumentCollection();
				case AW.Data.EntityType.IllustrationEntity:
					return new IllustrationCollection();
				case AW.Data.EntityType.LocationEntity:
					return new LocationCollection();
				case AW.Data.EntityType.ProductEntity:
					return new ProductCollection();
				case AW.Data.EntityType.ProductCategoryEntity:
					return new ProductCategoryCollection();
				case AW.Data.EntityType.ProductCostHistoryEntity:
					return new ProductCostHistoryCollection();
				case AW.Data.EntityType.ProductDescriptionEntity:
					return new ProductDescriptionCollection();
				case AW.Data.EntityType.ProductDocumentEntity:
					return new ProductDocumentCollection();
				case AW.Data.EntityType.ProductInventoryEntity:
					return new ProductInventoryCollection();
				case AW.Data.EntityType.ProductListPriceHistoryEntity:
					return new ProductListPriceHistoryCollection();
				case AW.Data.EntityType.ProductModelEntity:
					return new ProductModelCollection();
				case AW.Data.EntityType.ProductModelIllustrationEntity:
					return new ProductModelIllustrationCollection();
				case AW.Data.EntityType.ProductModelProductDescriptionCultureEntity:
					return new ProductModelProductDescriptionCultureCollection();
				case AW.Data.EntityType.ProductPhotoEntity:
					return new ProductPhotoCollection();
				case AW.Data.EntityType.ProductProductPhotoEntity:
					return new ProductProductPhotoCollection();
				case AW.Data.EntityType.ProductReviewEntity:
					return new ProductReviewCollection();
				case AW.Data.EntityType.ProductSubcategoryEntity:
					return new ProductSubcategoryCollection();
				case AW.Data.EntityType.PurchaseOrderHistoryEntity:
					return new PurchaseOrderHistoryCollection();
				case AW.Data.EntityType.SalesOrderHistoryEntity:
					return new SalesOrderHistoryCollection();
				case AW.Data.EntityType.ScrapReasonEntity:
					return new ScrapReasonCollection();
				case AW.Data.EntityType.TransactionHistoryEntity:
					return new TransactionHistoryCollection();
				case AW.Data.EntityType.TransactionHistoryArchiveEntity:
					return new TransactionHistoryArchiveCollection();
				case AW.Data.EntityType.UnitMeasureEntity:
					return new UnitMeasureCollection();
				case AW.Data.EntityType.WorkOrderEntity:
					return new WorkOrderCollection();
				case AW.Data.EntityType.WorkOrderHistoryEntity:
					return new WorkOrderHistoryCollection();
				case AW.Data.EntityType.WorkOrderRoutingEntity:
					return new WorkOrderRoutingCollection();
				case AW.Data.EntityType.ProductVendorEntity:
					return new ProductVendorCollection();
				case AW.Data.EntityType.PurchaseOrderDetailEntity:
					return new PurchaseOrderDetailCollection();
				case AW.Data.EntityType.PurchaseOrderHeaderEntity:
					return new PurchaseOrderHeaderCollection();
				case AW.Data.EntityType.ShipMethodEntity:
					return new ShipMethodCollection();
				case AW.Data.EntityType.VendorEntity:
					return new VendorCollection();
				case AW.Data.EntityType.VendorAddressEntity:
					return new VendorAddressCollection();
				case AW.Data.EntityType.VendorContactEntity:
					return new VendorContactCollection();
				case AW.Data.EntityType.ContactCreditCardEntity:
					return new ContactCreditCardCollection();
				case AW.Data.EntityType.CountryRegionCurrencyEntity:
					return new CountryRegionCurrencyCollection();
				case AW.Data.EntityType.CreditCardEntity:
					return new CreditCardCollection();
				case AW.Data.EntityType.CurrencyEntity:
					return new CurrencyCollection();
				case AW.Data.EntityType.CurrencyRateEntity:
					return new CurrencyRateCollection();
				case AW.Data.EntityType.CustomerEntity:
					return new CustomerCollection();
				case AW.Data.EntityType.CustomerAddressEntity:
					return new CustomerAddressCollection();
				case AW.Data.EntityType.CustomerViewRelatedEntity:
					return new CustomerViewRelatedCollection();
				case AW.Data.EntityType.IndividualEntity:
					return new IndividualCollection();
				case AW.Data.EntityType.SalesOrderDetailEntity:
					return new SalesOrderDetailCollection();
				case AW.Data.EntityType.SalesOrderHeaderEntity:
					return new SalesOrderHeaderCollection();
				case AW.Data.EntityType.SalesOrderHeaderSalesReasonEntity:
					return new SalesOrderHeaderSalesReasonCollection();
				case AW.Data.EntityType.SalesPersonEntity:
					return new SalesPersonCollection();
				case AW.Data.EntityType.SalesPersonQuotaHistoryEntity:
					return new SalesPersonQuotaHistoryCollection();
				case AW.Data.EntityType.SalesReasonEntity:
					return new SalesReasonCollection();
				case AW.Data.EntityType.SalesTaxRateEntity:
					return new SalesTaxRateCollection();
				case AW.Data.EntityType.SalesTerritoryEntity:
					return new SalesTerritoryCollection();
				case AW.Data.EntityType.SalesTerritoryHistoryEntity:
					return new SalesTerritoryHistoryCollection();
				case AW.Data.EntityType.ShoppingCartItemEntity:
					return new ShoppingCartItemCollection();
				case AW.Data.EntityType.SpecialOfferEntity:
					return new SpecialOfferCollection();
				case AW.Data.EntityType.SpecialOfferProductEntity:
					return new SpecialOfferProductCollection();
				case AW.Data.EntityType.StoreEntity:
					return new StoreCollection();
				case AW.Data.EntityType.StoreContactEntity:
					return new StoreContactCollection();
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
				case AW.Data.EntityType.AwbuildVersionEntity:
					factoryToUse = new AwbuildVersionEntityFactory();
					break;
				case AW.Data.EntityType.DatabaseLogEntity:
					factoryToUse = new DatabaseLogEntityFactory();
					break;
				case AW.Data.EntityType.ErrorLogEntity:
					factoryToUse = new ErrorLogEntityFactory();
					break;
				case AW.Data.EntityType.DepartmentEntity:
					factoryToUse = new DepartmentEntityFactory();
					break;
				case AW.Data.EntityType.EmployeeEntity:
					factoryToUse = new EmployeeEntityFactory();
					break;
				case AW.Data.EntityType.EmployeeAddressEntity:
					factoryToUse = new EmployeeAddressEntityFactory();
					break;
				case AW.Data.EntityType.EmployeeDepartmentHistoryEntity:
					factoryToUse = new EmployeeDepartmentHistoryEntityFactory();
					break;
				case AW.Data.EntityType.EmployeePayHistoryEntity:
					factoryToUse = new EmployeePayHistoryEntityFactory();
					break;
				case AW.Data.EntityType.JobCandidateEntity:
					factoryToUse = new JobCandidateEntityFactory();
					break;
				case AW.Data.EntityType.ShiftEntity:
					factoryToUse = new ShiftEntityFactory();
					break;
				case AW.Data.EntityType.AddressEntity:
					factoryToUse = new AddressEntityFactory();
					break;
				case AW.Data.EntityType.AddressTypeEntity:
					factoryToUse = new AddressTypeEntityFactory();
					break;
				case AW.Data.EntityType.ContactEntity:
					factoryToUse = new ContactEntityFactory();
					break;
				case AW.Data.EntityType.ContactTypeEntity:
					factoryToUse = new ContactTypeEntityFactory();
					break;
				case AW.Data.EntityType.CountryRegionEntity:
					factoryToUse = new CountryRegionEntityFactory();
					break;
				case AW.Data.EntityType.StateProvinceEntity:
					factoryToUse = new StateProvinceEntityFactory();
					break;
				case AW.Data.EntityType.BillOfMaterialEntity:
					factoryToUse = new BillOfMaterialEntityFactory();
					break;
				case AW.Data.EntityType.CultureEntity:
					factoryToUse = new CultureEntityFactory();
					break;
				case AW.Data.EntityType.DocumentEntity:
					factoryToUse = new DocumentEntityFactory();
					break;
				case AW.Data.EntityType.IllustrationEntity:
					factoryToUse = new IllustrationEntityFactory();
					break;
				case AW.Data.EntityType.LocationEntity:
					factoryToUse = new LocationEntityFactory();
					break;
				case AW.Data.EntityType.ProductEntity:
					factoryToUse = new ProductEntityFactory();
					break;
				case AW.Data.EntityType.ProductCategoryEntity:
					factoryToUse = new ProductCategoryEntityFactory();
					break;
				case AW.Data.EntityType.ProductCostHistoryEntity:
					factoryToUse = new ProductCostHistoryEntityFactory();
					break;
				case AW.Data.EntityType.ProductDescriptionEntity:
					factoryToUse = new ProductDescriptionEntityFactory();
					break;
				case AW.Data.EntityType.ProductDocumentEntity:
					factoryToUse = new ProductDocumentEntityFactory();
					break;
				case AW.Data.EntityType.ProductInventoryEntity:
					factoryToUse = new ProductInventoryEntityFactory();
					break;
				case AW.Data.EntityType.ProductListPriceHistoryEntity:
					factoryToUse = new ProductListPriceHistoryEntityFactory();
					break;
				case AW.Data.EntityType.ProductModelEntity:
					factoryToUse = new ProductModelEntityFactory();
					break;
				case AW.Data.EntityType.ProductModelIllustrationEntity:
					factoryToUse = new ProductModelIllustrationEntityFactory();
					break;
				case AW.Data.EntityType.ProductModelProductDescriptionCultureEntity:
					factoryToUse = new ProductModelProductDescriptionCultureEntityFactory();
					break;
				case AW.Data.EntityType.ProductPhotoEntity:
					factoryToUse = new ProductPhotoEntityFactory();
					break;
				case AW.Data.EntityType.ProductProductPhotoEntity:
					factoryToUse = new ProductProductPhotoEntityFactory();
					break;
				case AW.Data.EntityType.ProductReviewEntity:
					factoryToUse = new ProductReviewEntityFactory();
					break;
				case AW.Data.EntityType.ProductSubcategoryEntity:
					factoryToUse = new ProductSubcategoryEntityFactory();
					break;
				case AW.Data.EntityType.PurchaseOrderHistoryEntity:
					factoryToUse = new PurchaseOrderHistoryEntityFactory();
					break;
				case AW.Data.EntityType.SalesOrderHistoryEntity:
					factoryToUse = new SalesOrderHistoryEntityFactory();
					break;
				case AW.Data.EntityType.ScrapReasonEntity:
					factoryToUse = new ScrapReasonEntityFactory();
					break;
				case AW.Data.EntityType.TransactionHistoryEntity:
					factoryToUse = new TransactionHistoryEntityFactory();
					break;
				case AW.Data.EntityType.TransactionHistoryArchiveEntity:
					factoryToUse = new TransactionHistoryArchiveEntityFactory();
					break;
				case AW.Data.EntityType.UnitMeasureEntity:
					factoryToUse = new UnitMeasureEntityFactory();
					break;
				case AW.Data.EntityType.WorkOrderEntity:
					factoryToUse = new WorkOrderEntityFactory();
					break;
				case AW.Data.EntityType.WorkOrderHistoryEntity:
					factoryToUse = new WorkOrderHistoryEntityFactory();
					break;
				case AW.Data.EntityType.WorkOrderRoutingEntity:
					factoryToUse = new WorkOrderRoutingEntityFactory();
					break;
				case AW.Data.EntityType.ProductVendorEntity:
					factoryToUse = new ProductVendorEntityFactory();
					break;
				case AW.Data.EntityType.PurchaseOrderDetailEntity:
					factoryToUse = new PurchaseOrderDetailEntityFactory();
					break;
				case AW.Data.EntityType.PurchaseOrderHeaderEntity:
					factoryToUse = new PurchaseOrderHeaderEntityFactory();
					break;
				case AW.Data.EntityType.ShipMethodEntity:
					factoryToUse = new ShipMethodEntityFactory();
					break;
				case AW.Data.EntityType.VendorEntity:
					factoryToUse = new VendorEntityFactory();
					break;
				case AW.Data.EntityType.VendorAddressEntity:
					factoryToUse = new VendorAddressEntityFactory();
					break;
				case AW.Data.EntityType.VendorContactEntity:
					factoryToUse = new VendorContactEntityFactory();
					break;
				case AW.Data.EntityType.ContactCreditCardEntity:
					factoryToUse = new ContactCreditCardEntityFactory();
					break;
				case AW.Data.EntityType.CountryRegionCurrencyEntity:
					factoryToUse = new CountryRegionCurrencyEntityFactory();
					break;
				case AW.Data.EntityType.CreditCardEntity:
					factoryToUse = new CreditCardEntityFactory();
					break;
				case AW.Data.EntityType.CurrencyEntity:
					factoryToUse = new CurrencyEntityFactory();
					break;
				case AW.Data.EntityType.CurrencyRateEntity:
					factoryToUse = new CurrencyRateEntityFactory();
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
				case AW.Data.EntityType.IndividualEntity:
					factoryToUse = new IndividualEntityFactory();
					break;
				case AW.Data.EntityType.SalesOrderDetailEntity:
					factoryToUse = new SalesOrderDetailEntityFactory();
					break;
				case AW.Data.EntityType.SalesOrderHeaderEntity:
					factoryToUse = new SalesOrderHeaderEntityFactory();
					break;
				case AW.Data.EntityType.SalesOrderHeaderSalesReasonEntity:
					factoryToUse = new SalesOrderHeaderSalesReasonEntityFactory();
					break;
				case AW.Data.EntityType.SalesPersonEntity:
					factoryToUse = new SalesPersonEntityFactory();
					break;
				case AW.Data.EntityType.SalesPersonQuotaHistoryEntity:
					factoryToUse = new SalesPersonQuotaHistoryEntityFactory();
					break;
				case AW.Data.EntityType.SalesReasonEntity:
					factoryToUse = new SalesReasonEntityFactory();
					break;
				case AW.Data.EntityType.SalesTaxRateEntity:
					factoryToUse = new SalesTaxRateEntityFactory();
					break;
				case AW.Data.EntityType.SalesTerritoryEntity:
					factoryToUse = new SalesTerritoryEntityFactory();
					break;
				case AW.Data.EntityType.SalesTerritoryHistoryEntity:
					factoryToUse = new SalesTerritoryHistoryEntityFactory();
					break;
				case AW.Data.EntityType.ShoppingCartItemEntity:
					factoryToUse = new ShoppingCartItemEntityFactory();
					break;
				case AW.Data.EntityType.SpecialOfferEntity:
					factoryToUse = new SpecialOfferEntityFactory();
					break;
				case AW.Data.EntityType.SpecialOfferProductEntity:
					factoryToUse = new SpecialOfferProductEntityFactory();
					break;
				case AW.Data.EntityType.StoreEntity:
					factoryToUse = new StoreEntityFactory();
					break;
				case AW.Data.EntityType.StoreContactEntity:
					factoryToUse = new StoreContactEntityFactory();
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
		private static readonly Dictionary<Type, IEntityFactory> _factoryPerType = new Dictionary<Type, IEntityFactory>();

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
