///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET35
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using AW.Data;
using AW.Data.DaoClasses;
using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using AW.Data.HelperClasses;
using AW.Data.RelationClasses;

namespace AW.Data.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData : ILinqMetaData
	{
		#region Class Member Declarations
		private ITransaction _transactionToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the transaction object to use empty. This is ok if you're not executing queries created with this
		/// meta data inside a transaction. If you're executing the queries created with this meta-data inside a transaction, either set the Transaction property
		/// on the IQueryable.Provider instance of the created LLBLGenProQuery object prior to execution or use the ctor which accepts a transaction object.</summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse) : this(transactionToUse, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse, FunctionMappingStore customFunctionMappings)
		{
			_transactionToUse = transactionToUse;
			_customFunctionMappings = customFunctionMappings;
		}
		
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((AW.Data.EntityType)typeOfEntity)
			{
				case AW.Data.EntityType.AwbuildVersionEntity:
					toReturn = this.AwbuildVersion;
					break;
				case AW.Data.EntityType.DatabaseLogEntity:
					toReturn = this.DatabaseLog;
					break;
				case AW.Data.EntityType.ErrorLogEntity:
					toReturn = this.ErrorLog;
					break;
				case AW.Data.EntityType.DepartmentEntity:
					toReturn = this.Department;
					break;
				case AW.Data.EntityType.EmployeeEntity:
					toReturn = this.Employee;
					break;
				case AW.Data.EntityType.EmployeeAddressEntity:
					toReturn = this.EmployeeAddress;
					break;
				case AW.Data.EntityType.EmployeeDepartmentHistoryEntity:
					toReturn = this.EmployeeDepartmentHistory;
					break;
				case AW.Data.EntityType.EmployeePayHistoryEntity:
					toReturn = this.EmployeePayHistory;
					break;
				case AW.Data.EntityType.JobCandidateEntity:
					toReturn = this.JobCandidate;
					break;
				case AW.Data.EntityType.ShiftEntity:
					toReturn = this.Shift;
					break;
				case AW.Data.EntityType.AddressEntity:
					toReturn = this.Address;
					break;
				case AW.Data.EntityType.AddressTypeEntity:
					toReturn = this.AddressType;
					break;
				case AW.Data.EntityType.ContactEntity:
					toReturn = this.Contact;
					break;
				case AW.Data.EntityType.ContactTypeEntity:
					toReturn = this.ContactType;
					break;
				case AW.Data.EntityType.CountryRegionEntity:
					toReturn = this.CountryRegion;
					break;
				case AW.Data.EntityType.StateProvinceEntity:
					toReturn = this.StateProvince;
					break;
				case AW.Data.EntityType.BillOfMaterialEntity:
					toReturn = this.BillOfMaterial;
					break;
				case AW.Data.EntityType.CultureEntity:
					toReturn = this.Culture;
					break;
				case AW.Data.EntityType.DocumentEntity:
					toReturn = this.Document;
					break;
				case AW.Data.EntityType.IllustrationEntity:
					toReturn = this.Illustration;
					break;
				case AW.Data.EntityType.LocationEntity:
					toReturn = this.Location;
					break;
				case AW.Data.EntityType.ProductEntity:
					toReturn = this.Product;
					break;
				case AW.Data.EntityType.ProductCategoryEntity:
					toReturn = this.ProductCategory;
					break;
				case AW.Data.EntityType.ProductCostHistoryEntity:
					toReturn = this.ProductCostHistory;
					break;
				case AW.Data.EntityType.ProductDescriptionEntity:
					toReturn = this.ProductDescription;
					break;
				case AW.Data.EntityType.ProductDocumentEntity:
					toReturn = this.ProductDocument;
					break;
				case AW.Data.EntityType.ProductInventoryEntity:
					toReturn = this.ProductInventory;
					break;
				case AW.Data.EntityType.ProductListPriceHistoryEntity:
					toReturn = this.ProductListPriceHistory;
					break;
				case AW.Data.EntityType.ProductModelEntity:
					toReturn = this.ProductModel;
					break;
				case AW.Data.EntityType.ProductModelIllustrationEntity:
					toReturn = this.ProductModelIllustration;
					break;
				case AW.Data.EntityType.ProductModelProductDescriptionCultureEntity:
					toReturn = this.ProductModelProductDescriptionCulture;
					break;
				case AW.Data.EntityType.ProductPhotoEntity:
					toReturn = this.ProductPhoto;
					break;
				case AW.Data.EntityType.ProductProductPhotoEntity:
					toReturn = this.ProductProductPhoto;
					break;
				case AW.Data.EntityType.ProductReviewEntity:
					toReturn = this.ProductReview;
					break;
				case AW.Data.EntityType.ProductSubcategoryEntity:
					toReturn = this.ProductSubcategory;
					break;
				case AW.Data.EntityType.ScrapReasonEntity:
					toReturn = this.ScrapReason;
					break;
				case AW.Data.EntityType.TransactionHistoryEntity:
					toReturn = this.TransactionHistory;
					break;
				case AW.Data.EntityType.TransactionHistoryArchiveEntity:
					toReturn = this.TransactionHistoryArchive;
					break;
				case AW.Data.EntityType.UnitMeasureEntity:
					toReturn = this.UnitMeasure;
					break;
				case AW.Data.EntityType.WorkOrderEntity:
					toReturn = this.WorkOrder;
					break;
				case AW.Data.EntityType.WorkOrderRoutingEntity:
					toReturn = this.WorkOrderRouting;
					break;
				case AW.Data.EntityType.ProductVendorEntity:
					toReturn = this.ProductVendor;
					break;
				case AW.Data.EntityType.PurchaseOrderDetailEntity:
					toReturn = this.PurchaseOrderDetail;
					break;
				case AW.Data.EntityType.PurchaseOrderHeaderEntity:
					toReturn = this.PurchaseOrderHeader;
					break;
				case AW.Data.EntityType.ShipMethodEntity:
					toReturn = this.ShipMethod;
					break;
				case AW.Data.EntityType.VendorEntity:
					toReturn = this.Vendor;
					break;
				case AW.Data.EntityType.VendorAddressEntity:
					toReturn = this.VendorAddress;
					break;
				case AW.Data.EntityType.VendorContactEntity:
					toReturn = this.VendorContact;
					break;
				case AW.Data.EntityType.ContactCreditCardEntity:
					toReturn = this.ContactCreditCard;
					break;
				case AW.Data.EntityType.CountryRegionCurrencyEntity:
					toReturn = this.CountryRegionCurrency;
					break;
				case AW.Data.EntityType.CreditCardEntity:
					toReturn = this.CreditCard;
					break;
				case AW.Data.EntityType.CurrencyEntity:
					toReturn = this.Currency;
					break;
				case AW.Data.EntityType.CurrencyRateEntity:
					toReturn = this.CurrencyRate;
					break;
				case AW.Data.EntityType.CustomerEntity:
					toReturn = this.Customer;
					break;
				case AW.Data.EntityType.CustomerAddressEntity:
					toReturn = this.CustomerAddress;
					break;
				case AW.Data.EntityType.CustomerViewRelatedEntity:
					toReturn = this.CustomerViewRelated;
					break;
				case AW.Data.EntityType.IndividualEntity:
					toReturn = this.Individual;
					break;
				case AW.Data.EntityType.SalesOrderDetailEntity:
					toReturn = this.SalesOrderDetail;
					break;
				case AW.Data.EntityType.SalesOrderHeaderEntity:
					toReturn = this.SalesOrderHeader;
					break;
				case AW.Data.EntityType.SalesOrderHeaderSalesReasonEntity:
					toReturn = this.SalesOrderHeaderSalesReason;
					break;
				case AW.Data.EntityType.SalesPersonEntity:
					toReturn = this.SalesPerson;
					break;
				case AW.Data.EntityType.SalesPersonQuotaHistoryEntity:
					toReturn = this.SalesPersonQuotaHistory;
					break;
				case AW.Data.EntityType.SalesReasonEntity:
					toReturn = this.SalesReason;
					break;
				case AW.Data.EntityType.SalesTaxRateEntity:
					toReturn = this.SalesTaxRate;
					break;
				case AW.Data.EntityType.SalesTerritoryEntity:
					toReturn = this.SalesTerritory;
					break;
				case AW.Data.EntityType.SalesTerritoryHistoryEntity:
					toReturn = this.SalesTerritoryHistory;
					break;
				case AW.Data.EntityType.ShoppingCartItemEntity:
					toReturn = this.ShoppingCartItem;
					break;
				case AW.Data.EntityType.SpecialOfferEntity:
					toReturn = this.SpecialOffer;
					break;
				case AW.Data.EntityType.SpecialOfferProductEntity:
					toReturn = this.SpecialOfferProduct;
					break;
				case AW.Data.EntityType.StoreEntity:
					toReturn = this.Store;
					break;
				case AW.Data.EntityType.StoreContactEntity:
					toReturn = this.StoreContact;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query when targeting AwbuildVersionEntity instances in the database.</summary>
		public DataSource<AwbuildVersionEntity> AwbuildVersion
		{
			get { return new DataSource<AwbuildVersionEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting DatabaseLogEntity instances in the database.</summary>
		public DataSource<DatabaseLogEntity> DatabaseLog
		{
			get { return new DataSource<DatabaseLogEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ErrorLogEntity instances in the database.</summary>
		public DataSource<ErrorLogEntity> ErrorLog
		{
			get { return new DataSource<ErrorLogEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting DepartmentEntity instances in the database.</summary>
		public DataSource<DepartmentEntity> Department
		{
			get { return new DataSource<DepartmentEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeEntity instances in the database.</summary>
		public DataSource<EmployeeEntity> Employee
		{
			get { return new DataSource<EmployeeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeAddressEntity instances in the database.</summary>
		public DataSource<EmployeeAddressEntity> EmployeeAddress
		{
			get { return new DataSource<EmployeeAddressEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeDepartmentHistoryEntity instances in the database.</summary>
		public DataSource<EmployeeDepartmentHistoryEntity> EmployeeDepartmentHistory
		{
			get { return new DataSource<EmployeeDepartmentHistoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeePayHistoryEntity instances in the database.</summary>
		public DataSource<EmployeePayHistoryEntity> EmployeePayHistory
		{
			get { return new DataSource<EmployeePayHistoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting JobCandidateEntity instances in the database.</summary>
		public DataSource<JobCandidateEntity> JobCandidate
		{
			get { return new DataSource<JobCandidateEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ShiftEntity instances in the database.</summary>
		public DataSource<ShiftEntity> Shift
		{
			get { return new DataSource<ShiftEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AddressEntity instances in the database.</summary>
		public DataSource<AddressEntity> Address
		{
			get { return new DataSource<AddressEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AddressTypeEntity instances in the database.</summary>
		public DataSource<AddressTypeEntity> AddressType
		{
			get { return new DataSource<AddressTypeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ContactEntity instances in the database.</summary>
		public DataSource<ContactEntity> Contact
		{
			get { return new DataSource<ContactEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ContactTypeEntity instances in the database.</summary>
		public DataSource<ContactTypeEntity> ContactType
		{
			get { return new DataSource<ContactTypeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CountryRegionEntity instances in the database.</summary>
		public DataSource<CountryRegionEntity> CountryRegion
		{
			get { return new DataSource<CountryRegionEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting StateProvinceEntity instances in the database.</summary>
		public DataSource<StateProvinceEntity> StateProvince
		{
			get { return new DataSource<StateProvinceEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BillOfMaterialEntity instances in the database.</summary>
		public DataSource<BillOfMaterialEntity> BillOfMaterial
		{
			get { return new DataSource<BillOfMaterialEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CultureEntity instances in the database.</summary>
		public DataSource<CultureEntity> Culture
		{
			get { return new DataSource<CultureEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting DocumentEntity instances in the database.</summary>
		public DataSource<DocumentEntity> Document
		{
			get { return new DataSource<DocumentEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting IllustrationEntity instances in the database.</summary>
		public DataSource<IllustrationEntity> Illustration
		{
			get { return new DataSource<IllustrationEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LocationEntity instances in the database.</summary>
		public DataSource<LocationEntity> Location
		{
			get { return new DataSource<LocationEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductEntity instances in the database.</summary>
		public DataSource<ProductEntity> Product
		{
			get { return new DataSource<ProductEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductCategoryEntity instances in the database.</summary>
		public DataSource<ProductCategoryEntity> ProductCategory
		{
			get { return new DataSource<ProductCategoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductCostHistoryEntity instances in the database.</summary>
		public DataSource<ProductCostHistoryEntity> ProductCostHistory
		{
			get { return new DataSource<ProductCostHistoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductDescriptionEntity instances in the database.</summary>
		public DataSource<ProductDescriptionEntity> ProductDescription
		{
			get { return new DataSource<ProductDescriptionEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductDocumentEntity instances in the database.</summary>
		public DataSource<ProductDocumentEntity> ProductDocument
		{
			get { return new DataSource<ProductDocumentEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductInventoryEntity instances in the database.</summary>
		public DataSource<ProductInventoryEntity> ProductInventory
		{
			get { return new DataSource<ProductInventoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductListPriceHistoryEntity instances in the database.</summary>
		public DataSource<ProductListPriceHistoryEntity> ProductListPriceHistory
		{
			get { return new DataSource<ProductListPriceHistoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductModelEntity instances in the database.</summary>
		public DataSource<ProductModelEntity> ProductModel
		{
			get { return new DataSource<ProductModelEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductModelIllustrationEntity instances in the database.</summary>
		public DataSource<ProductModelIllustrationEntity> ProductModelIllustration
		{
			get { return new DataSource<ProductModelIllustrationEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductModelProductDescriptionCultureEntity instances in the database.</summary>
		public DataSource<ProductModelProductDescriptionCultureEntity> ProductModelProductDescriptionCulture
		{
			get { return new DataSource<ProductModelProductDescriptionCultureEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductPhotoEntity instances in the database.</summary>
		public DataSource<ProductPhotoEntity> ProductPhoto
		{
			get { return new DataSource<ProductPhotoEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductProductPhotoEntity instances in the database.</summary>
		public DataSource<ProductProductPhotoEntity> ProductProductPhoto
		{
			get { return new DataSource<ProductProductPhotoEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductReviewEntity instances in the database.</summary>
		public DataSource<ProductReviewEntity> ProductReview
		{
			get { return new DataSource<ProductReviewEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductSubcategoryEntity instances in the database.</summary>
		public DataSource<ProductSubcategoryEntity> ProductSubcategory
		{
			get { return new DataSource<ProductSubcategoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ScrapReasonEntity instances in the database.</summary>
		public DataSource<ScrapReasonEntity> ScrapReason
		{
			get { return new DataSource<ScrapReasonEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting TransactionHistoryEntity instances in the database.</summary>
		public DataSource<TransactionHistoryEntity> TransactionHistory
		{
			get { return new DataSource<TransactionHistoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting TransactionHistoryArchiveEntity instances in the database.</summary>
		public DataSource<TransactionHistoryArchiveEntity> TransactionHistoryArchive
		{
			get { return new DataSource<TransactionHistoryArchiveEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting UnitMeasureEntity instances in the database.</summary>
		public DataSource<UnitMeasureEntity> UnitMeasure
		{
			get { return new DataSource<UnitMeasureEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting WorkOrderEntity instances in the database.</summary>
		public DataSource<WorkOrderEntity> WorkOrder
		{
			get { return new DataSource<WorkOrderEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting WorkOrderRoutingEntity instances in the database.</summary>
		public DataSource<WorkOrderRoutingEntity> WorkOrderRouting
		{
			get { return new DataSource<WorkOrderRoutingEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductVendorEntity instances in the database.</summary>
		public DataSource<ProductVendorEntity> ProductVendor
		{
			get { return new DataSource<ProductVendorEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting PurchaseOrderDetailEntity instances in the database.</summary>
		public DataSource<PurchaseOrderDetailEntity> PurchaseOrderDetail
		{
			get { return new DataSource<PurchaseOrderDetailEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting PurchaseOrderHeaderEntity instances in the database.</summary>
		public DataSource<PurchaseOrderHeaderEntity> PurchaseOrderHeader
		{
			get { return new DataSource<PurchaseOrderHeaderEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ShipMethodEntity instances in the database.</summary>
		public DataSource<ShipMethodEntity> ShipMethod
		{
			get { return new DataSource<ShipMethodEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting VendorEntity instances in the database.</summary>
		public DataSource<VendorEntity> Vendor
		{
			get { return new DataSource<VendorEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting VendorAddressEntity instances in the database.</summary>
		public DataSource<VendorAddressEntity> VendorAddress
		{
			get { return new DataSource<VendorAddressEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting VendorContactEntity instances in the database.</summary>
		public DataSource<VendorContactEntity> VendorContact
		{
			get { return new DataSource<VendorContactEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ContactCreditCardEntity instances in the database.</summary>
		public DataSource<ContactCreditCardEntity> ContactCreditCard
		{
			get { return new DataSource<ContactCreditCardEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CountryRegionCurrencyEntity instances in the database.</summary>
		public DataSource<CountryRegionCurrencyEntity> CountryRegionCurrency
		{
			get { return new DataSource<CountryRegionCurrencyEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CreditCardEntity instances in the database.</summary>
		public DataSource<CreditCardEntity> CreditCard
		{
			get { return new DataSource<CreditCardEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CurrencyEntity instances in the database.</summary>
		public DataSource<CurrencyEntity> Currency
		{
			get { return new DataSource<CurrencyEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CurrencyRateEntity instances in the database.</summary>
		public DataSource<CurrencyRateEntity> CurrencyRate
		{
			get { return new DataSource<CurrencyRateEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerEntity instances in the database.</summary>
		public DataSource<CustomerEntity> Customer
		{
			get { return new DataSource<CustomerEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerAddressEntity instances in the database.</summary>
		public DataSource<CustomerAddressEntity> CustomerAddress
		{
			get { return new DataSource<CustomerAddressEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerViewRelatedEntity instances in the database.</summary>
		public DataSource<CustomerViewRelatedEntity> CustomerViewRelated
		{
			get { return new DataSource<CustomerViewRelatedEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting IndividualEntity instances in the database.</summary>
		public DataSource<IndividualEntity> Individual
		{
			get { return new DataSource<IndividualEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SalesOrderDetailEntity instances in the database.</summary>
		public DataSource<SalesOrderDetailEntity> SalesOrderDetail
		{
			get { return new DataSource<SalesOrderDetailEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SalesOrderHeaderEntity instances in the database.</summary>
		public DataSource<SalesOrderHeaderEntity> SalesOrderHeader
		{
			get { return new DataSource<SalesOrderHeaderEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SalesOrderHeaderSalesReasonEntity instances in the database.</summary>
		public DataSource<SalesOrderHeaderSalesReasonEntity> SalesOrderHeaderSalesReason
		{
			get { return new DataSource<SalesOrderHeaderSalesReasonEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SalesPersonEntity instances in the database.</summary>
		public DataSource<SalesPersonEntity> SalesPerson
		{
			get { return new DataSource<SalesPersonEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SalesPersonQuotaHistoryEntity instances in the database.</summary>
		public DataSource<SalesPersonQuotaHistoryEntity> SalesPersonQuotaHistory
		{
			get { return new DataSource<SalesPersonQuotaHistoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SalesReasonEntity instances in the database.</summary>
		public DataSource<SalesReasonEntity> SalesReason
		{
			get { return new DataSource<SalesReasonEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SalesTaxRateEntity instances in the database.</summary>
		public DataSource<SalesTaxRateEntity> SalesTaxRate
		{
			get { return new DataSource<SalesTaxRateEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SalesTerritoryEntity instances in the database.</summary>
		public DataSource<SalesTerritoryEntity> SalesTerritory
		{
			get { return new DataSource<SalesTerritoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SalesTerritoryHistoryEntity instances in the database.</summary>
		public DataSource<SalesTerritoryHistoryEntity> SalesTerritoryHistory
		{
			get { return new DataSource<SalesTerritoryHistoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ShoppingCartItemEntity instances in the database.</summary>
		public DataSource<ShoppingCartItemEntity> ShoppingCartItem
		{
			get { return new DataSource<ShoppingCartItemEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SpecialOfferEntity instances in the database.</summary>
		public DataSource<SpecialOfferEntity> SpecialOffer
		{
			get { return new DataSource<SpecialOfferEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SpecialOfferProductEntity instances in the database.</summary>
		public DataSource<SpecialOfferProductEntity> SpecialOfferProduct
		{
			get { return new DataSource<SpecialOfferProductEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting StoreEntity instances in the database.</summary>
		public DataSource<StoreEntity> Store
		{
			get { return new DataSource<StoreEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting StoreContactEntity instances in the database.</summary>
		public DataSource<StoreContactEntity> StoreContact
		{
			get { return new DataSource<StoreContactEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		#region Class Property Declarations
		/// <summary> Gets / sets the ITransaction to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public ITransaction TransactionToUse
		{
			get { return _transactionToUse;}
			set { _transactionToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}