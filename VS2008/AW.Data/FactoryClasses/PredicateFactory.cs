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

using AW.Data;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.FactoryClasses
{
	/// <summary>
	/// Class which eases the creation of the different predicate clauses defined in the ORM support classes. 
	/// Use these methods to create predicate clauses for filters without a lot of code.
	/// </summary>
	public class PredicateFactory
	{
		/// <summary>
		/// Static class, no CTor
		/// </summary>
		private PredicateFactory()
		{
		}

		#region FieldCompareValuePredicate creators (4 per entity type)

		/// <summary>FieldCompareValuePredicate factory for AddressEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(AddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for AddressEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(AddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for AddressEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(AddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for AddressEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(AddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(AddressTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(AddressTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(AddressTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(AddressTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for ContactEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ContactFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ContactEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ContactFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for ContactEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ContactFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ContactEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ContactFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CountryRegionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CountryRegionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CountryRegionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CountryRegionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for CustomerEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for CustomerEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerViewRelatedFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerViewRelatedFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerViewRelatedFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerViewRelatedFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for EmployeeEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(EmployeeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for EmployeeEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(EmployeeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for EmployeeEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(EmployeeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for EmployeeEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(EmployeeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(EmployeeAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(EmployeeAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(EmployeeAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(EmployeeAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for IndividualEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(IndividualFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for IndividualEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(IndividualFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for IndividualEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(IndividualFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for IndividualEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(IndividualFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for ProductEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ProductEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for ProductEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ProductEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SalesOrderDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SalesOrderDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SalesOrderDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SalesOrderDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SalesOrderHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SalesOrderHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SalesOrderHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SalesOrderHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ShipMethodFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ShipMethodFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ShipMethodFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(ShipMethodFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		/// <summary>FieldCompareValuePredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(StateProvinceFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(StateProvinceFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(StateProvinceFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareValuePredicate CompareValue(StateProvinceFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		#endregion

		#region FieldCompareValuePredicate creators (4 per typed view type)

		/// <summary>FieldCompareValuePredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerViewFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerViewFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}

		/// <summary>FieldCompareValuePredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerViewFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareValuePredicate CompareValue(CustomerViewFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, string objectAlias, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, objectAlias, negate);
		}
		#endregion

		#region FieldCompareNullPredicate creators (4 per entity type)

		/// <summary>FieldCompareNullPredicate factory for AddressEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(AddressFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for AddressEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(AddressFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for AddressEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(AddressFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for AddressEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(AddressFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(AddressTypeFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(AddressTypeFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(AddressTypeFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(AddressTypeFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for ContactEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ContactFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for ContactEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ContactFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for ContactEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ContactFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for ContactEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ContactFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CountryRegionFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CountryRegionFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CountryRegionFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CountryRegionFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for CustomerEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for CustomerEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for CustomerEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for CustomerEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerAddressFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerAddressFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerAddressFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerAddressFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerViewRelatedFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerViewRelatedFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerViewRelatedFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerViewRelatedFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for EmployeeEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(EmployeeFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for EmployeeEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(EmployeeFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for EmployeeEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(EmployeeFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for EmployeeEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(EmployeeFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(EmployeeAddressFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(EmployeeAddressFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(EmployeeAddressFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(EmployeeAddressFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for IndividualEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(IndividualFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for IndividualEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(IndividualFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for IndividualEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(IndividualFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for IndividualEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(IndividualFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for ProductEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ProductFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for ProductEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ProductFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for ProductEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ProductFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for ProductEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ProductFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SalesOrderDetailFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SalesOrderDetailFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SalesOrderDetailFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SalesOrderDetailFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SalesOrderHeaderFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SalesOrderHeaderFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SalesOrderHeaderFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SalesOrderHeaderFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ShipMethodFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ShipMethodFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ShipMethodFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(ShipMethodFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferProductFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferProductFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferProductFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferProductFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		/// <summary>FieldCompareNullPredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(StateProvinceFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(StateProvinceFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(StateProvinceFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareNullPredicate CompareNull(StateProvinceFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		#endregion

		#region FieldCompareNullPredicate creators (4 per typed view type)

		/// <summary>FieldCompareNullPredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerViewFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>FieldCompareNullPredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerViewFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}

		/// <summary>FieldCompareNullPredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerViewFieldIndex indexOfField, string objectAlias)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias);
		}

		/// <summary>FieldCompareNullPredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareNullPredicate CompareNull(CustomerViewFieldIndex indexOfField, string objectAlias, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate);
		}
		#endregion

		#region FieldBetweenPredicate creators (4 per entity type)

		/// <summary>FieldBetweenPredicate factory for AddressEntity.</summary>
		public static FieldBetweenPredicate Between(AddressFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for AddressEntity.</summary>
		public static FieldBetweenPredicate Between(AddressFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for AddressEntity.</summary>
		public static FieldBetweenPredicate Between(AddressFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for AddressEntity.</summary>
		public static FieldBetweenPredicate Between(AddressFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for AddressTypeEntity.</summary>
		public static FieldBetweenPredicate Between(AddressTypeFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for AddressTypeEntity.</summary>
		public static FieldBetweenPredicate Between(AddressTypeFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for AddressTypeEntity.</summary>
		public static FieldBetweenPredicate Between(AddressTypeFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for AddressTypeEntity.</summary>
		public static FieldBetweenPredicate Between(AddressTypeFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for ContactEntity.</summary>
		public static FieldBetweenPredicate Between(ContactFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for ContactEntity.</summary>
		public static FieldBetweenPredicate Between(ContactFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for ContactEntity.</summary>
		public static FieldBetweenPredicate Between(ContactFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for ContactEntity.</summary>
		public static FieldBetweenPredicate Between(ContactFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for CountryRegionEntity.</summary>
		public static FieldBetweenPredicate Between(CountryRegionFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for CountryRegionEntity.</summary>
		public static FieldBetweenPredicate Between(CountryRegionFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for CountryRegionEntity.</summary>
		public static FieldBetweenPredicate Between(CountryRegionFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for CountryRegionEntity.</summary>
		public static FieldBetweenPredicate Between(CountryRegionFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for CustomerEntity.</summary>
		public static FieldBetweenPredicate Between(CustomerFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for CustomerEntity.</summary>
		public static FieldBetweenPredicate Between(CustomerFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for CustomerEntity.</summary>
		public static FieldBetweenPredicate Between(CustomerFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for CustomerEntity.</summary>
		public static FieldBetweenPredicate Between(CustomerFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for CustomerAddressEntity.</summary>
		public static FieldBetweenPredicate Between(CustomerAddressFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for CustomerAddressEntity.</summary>
		public static FieldBetweenPredicate Between(CustomerAddressFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for CustomerAddressEntity.</summary>
		public static FieldBetweenPredicate Between(CustomerAddressFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for CustomerAddressEntity.</summary>
		public static FieldBetweenPredicate Between(CustomerAddressFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldBetweenPredicate Between(CustomerViewRelatedFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldBetweenPredicate Between(CustomerViewRelatedFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldBetweenPredicate Between(CustomerViewRelatedFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldBetweenPredicate Between(CustomerViewRelatedFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for EmployeeEntity.</summary>
		public static FieldBetweenPredicate Between(EmployeeFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for EmployeeEntity.</summary>
		public static FieldBetweenPredicate Between(EmployeeFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for EmployeeEntity.</summary>
		public static FieldBetweenPredicate Between(EmployeeFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for EmployeeEntity.</summary>
		public static FieldBetweenPredicate Between(EmployeeFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for EmployeeAddressEntity.</summary>
		public static FieldBetweenPredicate Between(EmployeeAddressFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for EmployeeAddressEntity.</summary>
		public static FieldBetweenPredicate Between(EmployeeAddressFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for EmployeeAddressEntity.</summary>
		public static FieldBetweenPredicate Between(EmployeeAddressFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for EmployeeAddressEntity.</summary>
		public static FieldBetweenPredicate Between(EmployeeAddressFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for IndividualEntity.</summary>
		public static FieldBetweenPredicate Between(IndividualFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for IndividualEntity.</summary>
		public static FieldBetweenPredicate Between(IndividualFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for IndividualEntity.</summary>
		public static FieldBetweenPredicate Between(IndividualFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for IndividualEntity.</summary>
		public static FieldBetweenPredicate Between(IndividualFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for ProductEntity.</summary>
		public static FieldBetweenPredicate Between(ProductFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for ProductEntity.</summary>
		public static FieldBetweenPredicate Between(ProductFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for ProductEntity.</summary>
		public static FieldBetweenPredicate Between(ProductFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for ProductEntity.</summary>
		public static FieldBetweenPredicate Between(ProductFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldBetweenPredicate Between(SalesOrderDetailFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldBetweenPredicate Between(SalesOrderDetailFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldBetweenPredicate Between(SalesOrderDetailFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldBetweenPredicate Between(SalesOrderDetailFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldBetweenPredicate Between(SalesOrderHeaderFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldBetweenPredicate Between(SalesOrderHeaderFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldBetweenPredicate Between(SalesOrderHeaderFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldBetweenPredicate Between(SalesOrderHeaderFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for ShipMethodEntity.</summary>
		public static FieldBetweenPredicate Between(ShipMethodFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for ShipMethodEntity.</summary>
		public static FieldBetweenPredicate Between(ShipMethodFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for ShipMethodEntity.</summary>
		public static FieldBetweenPredicate Between(ShipMethodFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for ShipMethodEntity.</summary>
		public static FieldBetweenPredicate Between(ShipMethodFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for SpecialOfferEntity.</summary>
		public static FieldBetweenPredicate Between(SpecialOfferFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for SpecialOfferEntity.</summary>
		public static FieldBetweenPredicate Between(SpecialOfferFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for SpecialOfferEntity.</summary>
		public static FieldBetweenPredicate Between(SpecialOfferFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for SpecialOfferEntity.</summary>
		public static FieldBetweenPredicate Between(SpecialOfferFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldBetweenPredicate Between(SpecialOfferProductFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldBetweenPredicate Between(SpecialOfferProductFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldBetweenPredicate Between(SpecialOfferProductFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldBetweenPredicate Between(SpecialOfferProductFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		/// <summary>FieldBetweenPredicate factory for StateProvinceEntity.</summary>
		public static FieldBetweenPredicate Between(StateProvinceFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for StateProvinceEntity.</summary>
		public static FieldBetweenPredicate Between(StateProvinceFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for StateProvinceEntity.</summary>
		public static FieldBetweenPredicate Between(StateProvinceFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for StateProvinceEntity.</summary>
		public static FieldBetweenPredicate Between(StateProvinceFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		#endregion

		#region FieldBetweenPredicate creators (4 per typed view type)

		/// <summary>FieldBetweenPredicate factory for CustomerViewTypedView.</summary>
		public static FieldBetweenPredicate Between(CustomerViewFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>FieldBetweenPredicate factory for CustomerViewTypedView.</summary>
		public static FieldBetweenPredicate Between(CustomerViewFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}

		/// <summary>FieldBetweenPredicate factory for CustomerViewTypedView.</summary>
		public static FieldBetweenPredicate Between(CustomerViewFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias);
		}

		/// <summary>FieldBetweenPredicate factory for CustomerViewTypedView.</summary>
		public static FieldBetweenPredicate Between(CustomerViewFieldIndex indexOfField, object valueBegin, object valueEnd, string objectAlias, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, objectAlias, negate);
		}
		#endregion

		#region FieldLikePredicate creators (4 per entity type)

		/// <summary>FieldLikePredicate factory for AddressEntity.</summary>
		public static FieldLikePredicate Like(AddressFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for AddressEntity.</summary>
		public static FieldLikePredicate Like(AddressFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for AddressEntity.</summary>
		public static FieldLikePredicate Like(AddressFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for AddressEntity.</summary>
		public static FieldLikePredicate Like(AddressFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for AddressTypeEntity.</summary>
		public static FieldLikePredicate Like(AddressTypeFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for AddressTypeEntity.</summary>
		public static FieldLikePredicate Like(AddressTypeFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for AddressTypeEntity.</summary>
		public static FieldLikePredicate Like(AddressTypeFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for AddressTypeEntity.</summary>
		public static FieldLikePredicate Like(AddressTypeFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for ContactEntity.</summary>
		public static FieldLikePredicate Like(ContactFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for ContactEntity.</summary>
		public static FieldLikePredicate Like(ContactFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for ContactEntity.</summary>
		public static FieldLikePredicate Like(ContactFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for ContactEntity.</summary>
		public static FieldLikePredicate Like(ContactFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for CountryRegionEntity.</summary>
		public static FieldLikePredicate Like(CountryRegionFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for CountryRegionEntity.</summary>
		public static FieldLikePredicate Like(CountryRegionFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for CountryRegionEntity.</summary>
		public static FieldLikePredicate Like(CountryRegionFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for CountryRegionEntity.</summary>
		public static FieldLikePredicate Like(CountryRegionFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for CustomerEntity.</summary>
		public static FieldLikePredicate Like(CustomerFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for CustomerEntity.</summary>
		public static FieldLikePredicate Like(CustomerFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for CustomerEntity.</summary>
		public static FieldLikePredicate Like(CustomerFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for CustomerEntity.</summary>
		public static FieldLikePredicate Like(CustomerFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for CustomerAddressEntity.</summary>
		public static FieldLikePredicate Like(CustomerAddressFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for CustomerAddressEntity.</summary>
		public static FieldLikePredicate Like(CustomerAddressFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for CustomerAddressEntity.</summary>
		public static FieldLikePredicate Like(CustomerAddressFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for CustomerAddressEntity.</summary>
		public static FieldLikePredicate Like(CustomerAddressFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldLikePredicate Like(CustomerViewRelatedFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldLikePredicate Like(CustomerViewRelatedFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldLikePredicate Like(CustomerViewRelatedFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldLikePredicate Like(CustomerViewRelatedFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for EmployeeEntity.</summary>
		public static FieldLikePredicate Like(EmployeeFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for EmployeeEntity.</summary>
		public static FieldLikePredicate Like(EmployeeFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for EmployeeEntity.</summary>
		public static FieldLikePredicate Like(EmployeeFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for EmployeeEntity.</summary>
		public static FieldLikePredicate Like(EmployeeFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for EmployeeAddressEntity.</summary>
		public static FieldLikePredicate Like(EmployeeAddressFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for EmployeeAddressEntity.</summary>
		public static FieldLikePredicate Like(EmployeeAddressFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for EmployeeAddressEntity.</summary>
		public static FieldLikePredicate Like(EmployeeAddressFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for EmployeeAddressEntity.</summary>
		public static FieldLikePredicate Like(EmployeeAddressFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for IndividualEntity.</summary>
		public static FieldLikePredicate Like(IndividualFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for IndividualEntity.</summary>
		public static FieldLikePredicate Like(IndividualFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for IndividualEntity.</summary>
		public static FieldLikePredicate Like(IndividualFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for IndividualEntity.</summary>
		public static FieldLikePredicate Like(IndividualFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for ProductEntity.</summary>
		public static FieldLikePredicate Like(ProductFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for ProductEntity.</summary>
		public static FieldLikePredicate Like(ProductFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for ProductEntity.</summary>
		public static FieldLikePredicate Like(ProductFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for ProductEntity.</summary>
		public static FieldLikePredicate Like(ProductFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldLikePredicate Like(SalesOrderDetailFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldLikePredicate Like(SalesOrderDetailFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldLikePredicate Like(SalesOrderDetailFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldLikePredicate Like(SalesOrderDetailFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldLikePredicate Like(SalesOrderHeaderFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldLikePredicate Like(SalesOrderHeaderFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldLikePredicate Like(SalesOrderHeaderFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldLikePredicate Like(SalesOrderHeaderFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for ShipMethodEntity.</summary>
		public static FieldLikePredicate Like(ShipMethodFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for ShipMethodEntity.</summary>
		public static FieldLikePredicate Like(ShipMethodFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for ShipMethodEntity.</summary>
		public static FieldLikePredicate Like(ShipMethodFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for ShipMethodEntity.</summary>
		public static FieldLikePredicate Like(ShipMethodFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for SpecialOfferEntity.</summary>
		public static FieldLikePredicate Like(SpecialOfferFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for SpecialOfferEntity.</summary>
		public static FieldLikePredicate Like(SpecialOfferFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for SpecialOfferEntity.</summary>
		public static FieldLikePredicate Like(SpecialOfferFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for SpecialOfferEntity.</summary>
		public static FieldLikePredicate Like(SpecialOfferFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldLikePredicate Like(SpecialOfferProductFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldLikePredicate Like(SpecialOfferProductFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldLikePredicate Like(SpecialOfferProductFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldLikePredicate Like(SpecialOfferProductFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		/// <summary>FieldLikePredicate factory for StateProvinceEntity.</summary>
		public static FieldLikePredicate Like(StateProvinceFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for StateProvinceEntity.</summary>
		public static FieldLikePredicate Like(StateProvinceFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for StateProvinceEntity.</summary>
		public static FieldLikePredicate Like(StateProvinceFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for StateProvinceEntity.</summary>
		public static FieldLikePredicate Like(StateProvinceFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		#endregion

		#region FieldLikePredicate creators (4 per typed view type)

		/// <summary>FieldLikePredicate factory for CustomerViewTypedView.</summary>
		public static FieldLikePredicate Like(CustomerViewFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>FieldLikePredicate factory for CustomerViewTypedView.</summary>
		public static FieldLikePredicate Like(CustomerViewFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}

		/// <summary>FieldLikePredicate factory for CustomerViewTypedView.</summary>
		public static FieldLikePredicate Like(CustomerViewFieldIndex indexOfField, string objectAlias, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern);
		}

		/// <summary>FieldLikePredicate factory for CustomerViewTypedView.</summary>
		public static FieldLikePredicate Like(CustomerViewFieldIndex indexOfField, string objectAlias, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, pattern, negate);
		}
		#endregion
		
		
		#region FieldCompareRangePredicate creators (4 per entity type)

		/// <summary>FieldCompareRangePredicate factory for AddressEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(AddressFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for AddressEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(AddressFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for AddressEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(AddressFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for AddressEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(AddressFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(AddressTypeFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(AddressTypeFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(AddressTypeFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(AddressTypeFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for ContactEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ContactFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ContactEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ContactFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for ContactEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ContactFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ContactEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ContactFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CountryRegionFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CountryRegionFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CountryRegionFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CountryRegionFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for CustomerEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for CustomerEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerAddressFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerAddressFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerAddressFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerAddressFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerViewRelatedFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerViewRelatedFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerViewRelatedFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerViewRelatedFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for EmployeeEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(EmployeeFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for EmployeeEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(EmployeeFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for EmployeeEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(EmployeeFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for EmployeeEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(EmployeeFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(EmployeeAddressFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(EmployeeAddressFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(EmployeeAddressFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(EmployeeAddressFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for IndividualEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(IndividualFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for IndividualEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(IndividualFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for IndividualEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(IndividualFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for IndividualEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(IndividualFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for ProductEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ProductFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ProductEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ProductFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for ProductEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ProductFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ProductEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ProductFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SalesOrderDetailFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SalesOrderDetailFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SalesOrderDetailFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SalesOrderDetailFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SalesOrderHeaderFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SalesOrderHeaderFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SalesOrderHeaderFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SalesOrderHeaderFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ShipMethodFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ShipMethodFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ShipMethodFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(ShipMethodFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferProductFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferProductFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferProductFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferProductFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		/// <summary>FieldCompareRangePredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(StateProvinceFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(StateProvinceFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(StateProvinceFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareValuePredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareRangePredicate CompareRange(StateProvinceFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		#endregion

		#region FieldCompareRangePredicate creators (4 per typed view type)

		/// <summary>FieldCompareRangePredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerViewFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerViewFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}

		/// <summary>FieldCompareRangePredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerViewFieldIndex indexOfField, string objectAlias, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, values);
		}
		
		/// <summary>FieldCompareRangePredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareRangePredicate CompareRange(CustomerViewFieldIndex indexOfField, string objectAlias, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), objectAlias, negate, values);
		}
		#endregion

		#region FieldCompareExpressionPredicate creators (4 per entity type)

		/// <summary>FieldCompareExpressionPredicate factory for AddressEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(AddressFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for AddressEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(AddressFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for AddressEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(AddressFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for AddressEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(AddressFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(AddressTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(AddressTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(AddressTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for AddressTypeEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(AddressTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for ContactEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ContactFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for ContactEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ContactFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for ContactEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ContactFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for ContactEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ContactFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CountryRegionFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CountryRegionFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CountryRegionFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for CountryRegionEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CountryRegionFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for CustomerEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for CustomerEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for CustomerEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for CustomerEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for CustomerAddressEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerViewRelatedFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerViewRelatedFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerViewRelatedFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for CustomerViewRelatedEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerViewRelatedFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for EmployeeEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(EmployeeFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for EmployeeEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(EmployeeFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for EmployeeEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(EmployeeFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for EmployeeEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(EmployeeFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(EmployeeAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(EmployeeAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(EmployeeAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for EmployeeAddressEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(EmployeeAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for IndividualEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(IndividualFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for IndividualEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(IndividualFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for IndividualEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(IndividualFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for IndividualEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(IndividualFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for ProductEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for ProductEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for ProductEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for ProductEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SalesOrderDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SalesOrderDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SalesOrderDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for SalesOrderDetailEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SalesOrderDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SalesOrderHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SalesOrderHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SalesOrderHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for SalesOrderHeaderEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SalesOrderHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ShipMethodFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ShipMethodFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ShipMethodFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for ShipMethodEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(ShipMethodFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for SpecialOfferEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SpecialOfferProductFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SpecialOfferProductFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SpecialOfferProductFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for SpecialOfferProductEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(SpecialOfferProductFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		/// <summary>FieldCompareExpressionPredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(StateProvinceFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(StateProvinceFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(StateProvinceFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for StateProvinceEntity.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(StateProvinceFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		#endregion

		#region FieldCompareExpressionPredicate creators (4 per typed view type)

		/// <summary>FieldCompareExpressionPredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerViewFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerViewFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, negate);
		}

		/// <summary>FieldCompareExpressionPredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerViewFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias);
		}
		
		/// <summary>FieldCompareExpressionPredicate factory for CustomerViewTypedView.</summary>
		public static FieldCompareExpressionPredicate CompareExpression(CustomerViewFieldIndex indexOfField, ComparisonOperator operatorToUse, IExpression expressionToCompareWith, string objectAlias, bool negate)
		{
			return new FieldCompareExpressionPredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, expressionToCompareWith, objectAlias, negate);
		}
		#endregion

		#region Included Code

		#endregion
	}
}
