///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Linq;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using Northwind.DAL;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.RelationClasses;

namespace Northwind.DAL.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData: ILinqMetaData
	{
		#region Class Member Declarations
		private IDataAccessAdapter _adapterToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null)
		{
		}

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			_adapterToUse = adapterToUse;
			_customFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((Northwind.DAL.EntityType)typeOfEntity)
			{
				case Northwind.DAL.EntityType.CategoryEntity:
					toReturn = this.Category;
					break;
				case Northwind.DAL.EntityType.CustomerEntity:
					toReturn = this.Customer;
					break;
				case Northwind.DAL.EntityType.CustomerCustomerDemoEntity:
					toReturn = this.CustomerCustomerDemo;
					break;
				case Northwind.DAL.EntityType.CustomerDemographicEntity:
					toReturn = this.CustomerDemographic;
					break;
				case Northwind.DAL.EntityType.EmployeeEntity:
					toReturn = this.Employee;
					break;
				case Northwind.DAL.EntityType.EmployeeTerritoryEntity:
					toReturn = this.EmployeeTerritory;
					break;
				case Northwind.DAL.EntityType.OrderEntity:
					toReturn = this.Order;
					break;
				case Northwind.DAL.EntityType.OrderDetailEntity:
					toReturn = this.OrderDetail;
					break;
				case Northwind.DAL.EntityType.ProductEntity:
					toReturn = this.Product;
					break;
				case Northwind.DAL.EntityType.RegionEntity:
					toReturn = this.Region;
					break;
				case Northwind.DAL.EntityType.ShipperEntity:
					toReturn = this.Shipper;
					break;
				case Northwind.DAL.EntityType.SupplierEntity:
					toReturn = this.Supplier;
					break;
				case Northwind.DAL.EntityType.TerritoryEntity:
					toReturn = this.Territory;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <typeparam name="TEntity">the type of the entity to get the datasource for</typeparam>
		/// <returns>the requested datasource</returns>
		public DataSource2<TEntity> GetQueryableForEntity<TEntity>()
			    where TEntity : class
		{
    		return new DataSource2<TEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse);
		}

		/// <summary>returns the datasource to use in a Linq query when targeting CategoryEntity instances in the database.</summary>
		public DataSource2<CategoryEntity> Category
		{
			get { return new DataSource2<CategoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerEntity instances in the database.</summary>
		public DataSource2<CustomerEntity> Customer
		{
			get { return new DataSource2<CustomerEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerCustomerDemoEntity instances in the database.</summary>
		public DataSource2<CustomerCustomerDemoEntity> CustomerCustomerDemo
		{
			get { return new DataSource2<CustomerCustomerDemoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerDemographicEntity instances in the database.</summary>
		public DataSource2<CustomerDemographicEntity> CustomerDemographic
		{
			get { return new DataSource2<CustomerDemographicEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeEntity instances in the database.</summary>
		public DataSource2<EmployeeEntity> Employee
		{
			get { return new DataSource2<EmployeeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeTerritoryEntity instances in the database.</summary>
		public DataSource2<EmployeeTerritoryEntity> EmployeeTerritory
		{
			get { return new DataSource2<EmployeeTerritoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting OrderEntity instances in the database.</summary>
		public DataSource2<OrderEntity> Order
		{
			get { return new DataSource2<OrderEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting OrderDetailEntity instances in the database.</summary>
		public DataSource2<OrderDetailEntity> OrderDetail
		{
			get { return new DataSource2<OrderDetailEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductEntity instances in the database.</summary>
		public DataSource2<ProductEntity> Product
		{
			get { return new DataSource2<ProductEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RegionEntity instances in the database.</summary>
		public DataSource2<RegionEntity> Region
		{
			get { return new DataSource2<RegionEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ShipperEntity instances in the database.</summary>
		public DataSource2<ShipperEntity> Shipper
		{
			get { return new DataSource2<ShipperEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SupplierEntity instances in the database.</summary>
		public DataSource2<SupplierEntity> Supplier
		{
			get { return new DataSource2<SupplierEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting TerritoryEntity instances in the database.</summary>
		public DataSource2<TerritoryEntity> Territory
		{
			get { return new DataSource2<TerritoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		

		/// <summary>returns the datasource to use in a Linq query when targeting AlphabeticalListOfProduct instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.AlphabeticalListOfProductRow> AlphabeticalListOfProduct
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.AlphabeticalListOfProductRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.AlphabeticalListOfProductTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting CategorySalesFor1997 instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.CategorySalesFor1997Row> CategorySalesFor1997
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.CategorySalesFor1997Row>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.CategorySalesFor1997TypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting CurrentProductList instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.CurrentProductListRow> CurrentProductList
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.CurrentProductListRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.CurrentProductListTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting CustomerAndSuppliersByCity instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.CustomerAndSuppliersByCityRow> CustomerAndSuppliersByCity
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.CustomerAndSuppliersByCityRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.CustomerAndSuppliersByCityTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting Invoice instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.InvoiceRow> Invoice
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.InvoiceRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.InvoiceTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting OrderDetailsExtended instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.OrderDetailsExtendedRow> OrderDetailsExtended
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.OrderDetailsExtendedRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.OrderDetailsExtendedTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting OrdersQry instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.OrdersQryRow> OrdersQry
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.OrdersQryRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.OrdersQryTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting OrderSubtotal instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.OrderSubtotalRow> OrderSubtotal
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.OrderSubtotalRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.OrderSubtotalTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting ProductsAboveAveragePrice instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.ProductsAboveAveragePriceRow> ProductsAboveAveragePrice
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.ProductsAboveAveragePriceRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.ProductsAboveAveragePriceTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting ProductSalesFor1997 instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.ProductSalesFor1997Row> ProductSalesFor1997
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.ProductSalesFor1997Row>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.ProductSalesFor1997TypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting ProductsByCategory instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.ProductsByCategoryRow> ProductsByCategory
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.ProductsByCategoryRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.ProductsByCategoryTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting QuarterlyOrder instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.QuarterlyOrderRow> QuarterlyOrder
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.QuarterlyOrderRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.QuarterlyOrderTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting SalesByCategory instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.SalesByCategoryRow> SalesByCategory
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.SalesByCategoryRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.SalesByCategoryTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting SalesTotalsByAmount instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.SalesTotalsByAmountRow> SalesTotalsByAmount
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.SalesTotalsByAmountRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.SalesTotalsByAmountTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting SummaryOfSalesByQuarter instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.SummaryOfSalesByQuarterRow> SummaryOfSalesByQuarter
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.SummaryOfSalesByQuarterRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.SummaryOfSalesByQuarterTypedView }; }
		}

		/// <summary>returns the datasource to use in a Linq query when targeting SummaryOfSalesByYear instances in the database.</summary>
		public DataSource2<Northwind.DAL.TypedViewClasses.SummaryOfSalesByYearRow> SummaryOfSalesByYear
		{
			get { return new DataSource2<Northwind.DAL.TypedViewClasses.SummaryOfSalesByYearRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.SummaryOfSalesByYearTypedView }; }
		}

		#region Class Property Declarations
		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse
		{
			get { return _adapterToUse;}
			set { _adapterToUse = value;}
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