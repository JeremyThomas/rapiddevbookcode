///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:30 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;

using AW.Data;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.FactoryClasses
{
	/// <summary>Class which eases the creation of sort clauses used in a SortExpression, to sort resultsets on specified fields.</summary>
	public class SortClauseFactory
	{
		/// <summary>Static class, no CTor</summary>
		private SortClauseFactory()
		{
		}

		/// <summary>Creates a new sort clause for the AddressEntity field specified.</summary>
		public static ISortClause Create(AddressFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the AddressEntity field specified.</summary>
		public static ISortClause Create(AddressFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the AddressTypeEntity field specified.</summary>
		public static ISortClause Create(AddressTypeFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the AddressTypeEntity field specified.</summary>
		public static ISortClause Create(AddressTypeFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the ContactEntity field specified.</summary>
		public static ISortClause Create(ContactFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the ContactEntity field specified.</summary>
		public static ISortClause Create(ContactFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the CountryRegionEntity field specified.</summary>
		public static ISortClause Create(CountryRegionFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the CountryRegionEntity field specified.</summary>
		public static ISortClause Create(CountryRegionFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the CustomerEntity field specified.</summary>
		public static ISortClause Create(CustomerFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the CustomerEntity field specified.</summary>
		public static ISortClause Create(CustomerFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the CustomerAddressEntity field specified.</summary>
		public static ISortClause Create(CustomerAddressFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the CustomerAddressEntity field specified.</summary>
		public static ISortClause Create(CustomerAddressFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the CustomerViewRelatedEntity field specified.</summary>
		public static ISortClause Create(CustomerViewRelatedFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the CustomerViewRelatedEntity field specified.</summary>
		public static ISortClause Create(CustomerViewRelatedFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the EmployeeEntity field specified.</summary>
		public static ISortClause Create(EmployeeFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the EmployeeEntity field specified.</summary>
		public static ISortClause Create(EmployeeFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the EmployeeAddressEntity field specified.</summary>
		public static ISortClause Create(EmployeeAddressFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the EmployeeAddressEntity field specified.</summary>
		public static ISortClause Create(EmployeeAddressFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the IndividualEntity field specified.</summary>
		public static ISortClause Create(IndividualFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the IndividualEntity field specified.</summary>
		public static ISortClause Create(IndividualFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the ProductEntity field specified.</summary>
		public static ISortClause Create(ProductFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the ProductEntity field specified.</summary>
		public static ISortClause Create(ProductFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the SalesOrderDetailEntity field specified.</summary>
		public static ISortClause Create(SalesOrderDetailFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the SalesOrderDetailEntity field specified.</summary>
		public static ISortClause Create(SalesOrderDetailFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the SalesOrderHeaderEntity field specified.</summary>
		public static ISortClause Create(SalesOrderHeaderFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the SalesOrderHeaderEntity field specified.</summary>
		public static ISortClause Create(SalesOrderHeaderFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the ShipMethodEntity field specified.</summary>
		public static ISortClause Create(ShipMethodFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the ShipMethodEntity field specified.</summary>
		public static ISortClause Create(ShipMethodFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the SpecialOfferEntity field specified.</summary>
		public static ISortClause Create(SpecialOfferFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the SpecialOfferEntity field specified.</summary>
		public static ISortClause Create(SpecialOfferFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the SpecialOfferProductEntity field specified.</summary>
		public static ISortClause Create(SpecialOfferProductFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the SpecialOfferProductEntity field specified.</summary>
		public static ISortClause Create(SpecialOfferProductFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the StateProvinceEntity field specified.</summary>
		public static ISortClause Create(StateProvinceFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the StateProvinceEntity field specified.</summary>
		public static ISortClause Create(StateProvinceFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		/// <summary>Creates a new sort clause for the CustomerViewTypedView field specified.</summary>
		public static ISortClause Create(CustomerViewFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}

		/// <summary>Creates a new sort clause for the CustomerViewTypedView field specified.</summary>
		public static ISortClause Create(CustomerViewFieldIndex fieldToSort, SortOperator operatorToUse, string objectAlias)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse, objectAlias);
		}

		#region Included Code

		#endregion
	}
}
