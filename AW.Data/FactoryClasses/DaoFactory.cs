﻿///////////////////////////////////////////////////////////////
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

using AW.Data.DaoClasses;
using AW.Data.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.FactoryClasses
{
	/// <summary>
	/// Generic factory for DAO objects. 
	/// </summary>
	public class DAOFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private DAOFactory()
		{
		}

		/// <summary>Creates a new AddressDAO object</summary>
		/// <returns>the new DAO object ready to use for Address Entities</returns>
		public static AddressDAO CreateAddressDAO()
		{
			return new AddressDAO();
		}

		/// <summary>Creates a new AddressTypeDAO object</summary>
		/// <returns>the new DAO object ready to use for AddressType Entities</returns>
		public static AddressTypeDAO CreateAddressTypeDAO()
		{
			return new AddressTypeDAO();
		}

		/// <summary>Creates a new ContactDAO object</summary>
		/// <returns>the new DAO object ready to use for Contact Entities</returns>
		public static ContactDAO CreateContactDAO()
		{
			return new ContactDAO();
		}

		/// <summary>Creates a new CountryRegionDAO object</summary>
		/// <returns>the new DAO object ready to use for CountryRegion Entities</returns>
		public static CountryRegionDAO CreateCountryRegionDAO()
		{
			return new CountryRegionDAO();
		}

		/// <summary>Creates a new CustomerDAO object</summary>
		/// <returns>the new DAO object ready to use for Customer Entities</returns>
		public static CustomerDAO CreateCustomerDAO()
		{
			return new CustomerDAO();
		}

		/// <summary>Creates a new CustomerAddressDAO object</summary>
		/// <returns>the new DAO object ready to use for CustomerAddress Entities</returns>
		public static CustomerAddressDAO CreateCustomerAddressDAO()
		{
			return new CustomerAddressDAO();
		}

		/// <summary>Creates a new CustomerViewRelatedDAO object</summary>
		/// <returns>the new DAO object ready to use for CustomerViewRelated Entities</returns>
		public static CustomerViewRelatedDAO CreateCustomerViewRelatedDAO()
		{
			return new CustomerViewRelatedDAO();
		}

		/// <summary>Creates a new EmployeeDAO object</summary>
		/// <returns>the new DAO object ready to use for Employee Entities</returns>
		public static EmployeeDAO CreateEmployeeDAO()
		{
			return new EmployeeDAO();
		}

		/// <summary>Creates a new EmployeeAddressDAO object</summary>
		/// <returns>the new DAO object ready to use for EmployeeAddress Entities</returns>
		public static EmployeeAddressDAO CreateEmployeeAddressDAO()
		{
			return new EmployeeAddressDAO();
		}

		/// <summary>Creates a new IndividualDAO object</summary>
		/// <returns>the new DAO object ready to use for Individual Entities</returns>
		public static IndividualDAO CreateIndividualDAO()
		{
			return new IndividualDAO();
		}

		/// <summary>Creates a new ProductDAO object</summary>
		/// <returns>the new DAO object ready to use for Product Entities</returns>
		public static ProductDAO CreateProductDAO()
		{
			return new ProductDAO();
		}

		/// <summary>Creates a new SalesOrderDetailDAO object</summary>
		/// <returns>the new DAO object ready to use for SalesOrderDetail Entities</returns>
		public static SalesOrderDetailDAO CreateSalesOrderDetailDAO()
		{
			return new SalesOrderDetailDAO();
		}

		/// <summary>Creates a new SalesOrderHeaderDAO object</summary>
		/// <returns>the new DAO object ready to use for SalesOrderHeader Entities</returns>
		public static SalesOrderHeaderDAO CreateSalesOrderHeaderDAO()
		{
			return new SalesOrderHeaderDAO();
		}

		/// <summary>Creates a new ShipMethodDAO object</summary>
		/// <returns>the new DAO object ready to use for ShipMethod Entities</returns>
		public static ShipMethodDAO CreateShipMethodDAO()
		{
			return new ShipMethodDAO();
		}

		/// <summary>Creates a new SpecialOfferDAO object</summary>
		/// <returns>the new DAO object ready to use for SpecialOffer Entities</returns>
		public static SpecialOfferDAO CreateSpecialOfferDAO()
		{
			return new SpecialOfferDAO();
		}

		/// <summary>Creates a new SpecialOfferProductDAO object</summary>
		/// <returns>the new DAO object ready to use for SpecialOfferProduct Entities</returns>
		public static SpecialOfferProductDAO CreateSpecialOfferProductDAO()
		{
			return new SpecialOfferProductDAO();
		}

		/// <summary>Creates a new StateProvinceDAO object</summary>
		/// <returns>the new DAO object ready to use for StateProvince Entities</returns>
		public static StateProvinceDAO CreateStateProvinceDAO()
		{
			return new StateProvinceDAO();
		}

		/// <summary>Creates a new TypedListDAO object</summary>
		/// <returns>The new DAO object ready to use for Typed Lists</returns>
		public static TypedListDAO CreateTypedListDAO()
		{
			return new TypedListDAO();
		}

		#region Included Code

		#endregion
	}
}
