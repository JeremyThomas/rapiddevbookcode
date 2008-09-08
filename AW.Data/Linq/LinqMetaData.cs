///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.Linq
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
	public class LinqMetaData : ILinqMetaData
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
				case AW.Data.EntityType.AddressEntity:
					toReturn = this.Address;
					break;
				case AW.Data.EntityType.AddressTypeEntity:
					toReturn = this.AddressType;
					break;
				case AW.Data.EntityType.ContactEntity:
					toReturn = this.Contact;
					break;
				case AW.Data.EntityType.CountryRegionEntity:
					toReturn = this.CountryRegion;
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
				case AW.Data.EntityType.EmployeeEntity:
					toReturn = this.Employee;
					break;
				case AW.Data.EntityType.EmployeeAddressEntity:
					toReturn = this.EmployeeAddress;
					break;
				case AW.Data.EntityType.IndividualEntity:
					toReturn = this.Individual;
					break;
				case AW.Data.EntityType.ProductEntity:
					toReturn = this.Product;
					break;
				case AW.Data.EntityType.SalesOrderDetailEntity:
					toReturn = this.SalesOrderDetail;
					break;
				case AW.Data.EntityType.SalesOrderHeaderEntity:
					toReturn = this.SalesOrderHeader;
					break;
				case AW.Data.EntityType.SalesTerritoryEntity:
					toReturn = this.SalesTerritory;
					break;
				case AW.Data.EntityType.ShipMethodEntity:
					toReturn = this.ShipMethod;
					break;
				case AW.Data.EntityType.SpecialOfferEntity:
					toReturn = this.SpecialOffer;
					break;
				case AW.Data.EntityType.SpecialOfferProductEntity:
					toReturn = this.SpecialOfferProduct;
					break;
				case AW.Data.EntityType.StateProvinceEntity:
					toReturn = this.StateProvince;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
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
		/// <summary>returns the datasource to use in a Linq query when targeting CountryRegionEntity instances in the database.</summary>
		public DataSource<CountryRegionEntity> CountryRegion
		{
			get { return new DataSource<CountryRegionEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
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
		/// <summary>returns the datasource to use in a Linq query when targeting IndividualEntity instances in the database.</summary>
		public DataSource<IndividualEntity> Individual
		{
			get { return new DataSource<IndividualEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductEntity instances in the database.</summary>
		public DataSource<ProductEntity> Product
		{
			get { return new DataSource<ProductEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
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
		/// <summary>returns the datasource to use in a Linq query when targeting SalesTerritoryEntity instances in the database.</summary>
		public DataSource<SalesTerritoryEntity> SalesTerritory
		{
			get { return new DataSource<SalesTerritoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ShipMethodEntity instances in the database.</summary>
		public DataSource<ShipMethodEntity> ShipMethod
		{
			get { return new DataSource<ShipMethodEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
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
		/// <summary>returns the datasource to use in a Linq query when targeting StateProvinceEntity instances in the database.</summary>
		public DataSource<StateProvinceEntity> StateProvince
		{
			get { return new DataSource<StateProvinceEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
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