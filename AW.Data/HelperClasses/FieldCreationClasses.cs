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
using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Data.FactoryClasses;
using AW.Data;

namespace AW.Data.HelperClasses
{
	/// <summary>Field Creation Class for entity AddressEntity</summary>
	public class AddressFields
	{
		/// <summary>Creates a new AddressEntity.AddressId field instance</summary>
		public static EntityField AddressId
		{
			get { return (EntityField)EntityFieldFactory.Create(AddressFieldIndex.AddressId);}
		}
		/// <summary>Creates a new AddressEntity.AddressLine1 field instance</summary>
		public static EntityField AddressLine1
		{
			get { return (EntityField)EntityFieldFactory.Create(AddressFieldIndex.AddressLine1);}
		}
		/// <summary>Creates a new AddressEntity.AddressLine2 field instance</summary>
		public static EntityField AddressLine2
		{
			get { return (EntityField)EntityFieldFactory.Create(AddressFieldIndex.AddressLine2);}
		}
		/// <summary>Creates a new AddressEntity.City field instance</summary>
		public static EntityField City
		{
			get { return (EntityField)EntityFieldFactory.Create(AddressFieldIndex.City);}
		}
		/// <summary>Creates a new AddressEntity.StateProvinceId field instance</summary>
		public static EntityField StateProvinceId
		{
			get { return (EntityField)EntityFieldFactory.Create(AddressFieldIndex.StateProvinceId);}
		}
		/// <summary>Creates a new AddressEntity.PostalCode field instance</summary>
		public static EntityField PostalCode
		{
			get { return (EntityField)EntityFieldFactory.Create(AddressFieldIndex.PostalCode);}
		}
		/// <summary>Creates a new AddressEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(AddressFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new AddressEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(AddressFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity AddressTypeEntity</summary>
	public class AddressTypeFields
	{
		/// <summary>Creates a new AddressTypeEntity.AddressTypeId field instance</summary>
		public static EntityField AddressTypeId
		{
			get { return (EntityField)EntityFieldFactory.Create(AddressTypeFieldIndex.AddressTypeId);}
		}
		/// <summary>Creates a new AddressTypeEntity.Name field instance</summary>
		public static EntityField Name
		{
			get { return (EntityField)EntityFieldFactory.Create(AddressTypeFieldIndex.Name);}
		}
		/// <summary>Creates a new AddressTypeEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(AddressTypeFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new AddressTypeEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(AddressTypeFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity ContactEntity</summary>
	public class ContactFields
	{
		/// <summary>Creates a new ContactEntity.ContactId field instance</summary>
		public static EntityField ContactId
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.ContactId);}
		}
		/// <summary>Creates a new ContactEntity.NameStyle field instance</summary>
		public static EntityField NameStyle
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.NameStyle);}
		}
		/// <summary>Creates a new ContactEntity.Title field instance</summary>
		public static EntityField Title
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.Title);}
		}
		/// <summary>Creates a new ContactEntity.FirstName field instance</summary>
		public static EntityField FirstName
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.FirstName);}
		}
		/// <summary>Creates a new ContactEntity.MiddleName field instance</summary>
		public static EntityField MiddleName
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.MiddleName);}
		}
		/// <summary>Creates a new ContactEntity.LastName field instance</summary>
		public static EntityField LastName
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.LastName);}
		}
		/// <summary>Creates a new ContactEntity.Suffix field instance</summary>
		public static EntityField Suffix
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.Suffix);}
		}
		/// <summary>Creates a new ContactEntity.EmailAddress field instance</summary>
		public static EntityField EmailAddress
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.EmailAddress);}
		}
		/// <summary>Creates a new ContactEntity.EmailPromotion field instance</summary>
		public static EntityField EmailPromotion
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.EmailPromotion);}
		}
		/// <summary>Creates a new ContactEntity.Phone field instance</summary>
		public static EntityField Phone
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.Phone);}
		}
		/// <summary>Creates a new ContactEntity.PasswordHash field instance</summary>
		public static EntityField PasswordHash
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.PasswordHash);}
		}
		/// <summary>Creates a new ContactEntity.PasswordSalt field instance</summary>
		public static EntityField PasswordSalt
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.PasswordSalt);}
		}
		/// <summary>Creates a new ContactEntity.AdditionalContactInfo field instance</summary>
		public static EntityField AdditionalContactInfo
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.AdditionalContactInfo);}
		}
		/// <summary>Creates a new ContactEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new ContactEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(ContactFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity CountryRegionEntity</summary>
	public class CountryRegionFields
	{
		/// <summary>Creates a new CountryRegionEntity.CountryRegionCode field instance</summary>
		public static EntityField CountryRegionCode
		{
			get { return (EntityField)EntityFieldFactory.Create(CountryRegionFieldIndex.CountryRegionCode);}
		}
		/// <summary>Creates a new CountryRegionEntity.Name field instance</summary>
		public static EntityField Name
		{
			get { return (EntityField)EntityFieldFactory.Create(CountryRegionFieldIndex.Name);}
		}
		/// <summary>Creates a new CountryRegionEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(CountryRegionFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity CustomerEntity</summary>
	public class CustomerFields
	{
		/// <summary>Creates a new CustomerEntity.CustomerId field instance</summary>
		public static EntityField CustomerId
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.CustomerId);}
		}
		/// <summary>Creates a new CustomerEntity.TerritoryId field instance</summary>
		public static EntityField TerritoryId
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.TerritoryId);}
		}
		/// <summary>Creates a new CustomerEntity.AccountNumber field instance</summary>
		public static EntityField AccountNumber
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.AccountNumber);}
		}
		/// <summary>Creates a new CustomerEntity.CustomerType field instance</summary>
		public static EntityField CustomerType
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.CustomerType);}
		}
		/// <summary>Creates a new CustomerEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new CustomerEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity CustomerAddressEntity</summary>
	public class CustomerAddressFields
	{
		/// <summary>Creates a new CustomerAddressEntity.CustomerId field instance</summary>
		public static EntityField CustomerId
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerAddressFieldIndex.CustomerId);}
		}
		/// <summary>Creates a new CustomerAddressEntity.AddressId field instance</summary>
		public static EntityField AddressId
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerAddressFieldIndex.AddressId);}
		}
		/// <summary>Creates a new CustomerAddressEntity.AddressTypeId field instance</summary>
		public static EntityField AddressTypeId
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerAddressFieldIndex.AddressTypeId);}
		}
		/// <summary>Creates a new CustomerAddressEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerAddressFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new CustomerAddressEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerAddressFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity CustomerViewRelatedEntity</summary>
	public class CustomerViewRelatedFields
	{
		/// <summary>Creates a new CustomerViewRelatedEntity.CustomerId field instance</summary>
		public static EntityField CustomerId
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.CustomerId);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.Title field instance</summary>
		public static EntityField Title
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.Title);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.FirstName field instance</summary>
		public static EntityField FirstName
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.FirstName);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.MiddleName field instance</summary>
		public static EntityField MiddleName
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.MiddleName);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.LastName field instance</summary>
		public static EntityField LastName
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.LastName);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.Suffix field instance</summary>
		public static EntityField Suffix
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.Suffix);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.Phone field instance</summary>
		public static EntityField Phone
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.Phone);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.EmailAddress field instance</summary>
		public static EntityField EmailAddress
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.EmailAddress);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.EmailPromotion field instance</summary>
		public static EntityField EmailPromotion
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.EmailPromotion);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.AddressType field instance</summary>
		public static EntityField AddressType
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.AddressType);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.AddressLine1 field instance</summary>
		public static EntityField AddressLine1
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.AddressLine1);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.AddressLine2 field instance</summary>
		public static EntityField AddressLine2
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.AddressLine2);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.City field instance</summary>
		public static EntityField City
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.City);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.StateProvinceName field instance</summary>
		public static EntityField StateProvinceName
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.StateProvinceName);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.PostalCode field instance</summary>
		public static EntityField PostalCode
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.PostalCode);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.CountryRegionName field instance</summary>
		public static EntityField CountryRegionName
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.CountryRegionName);}
		}
		/// <summary>Creates a new CustomerViewRelatedEntity.Demographics field instance</summary>
		public static EntityField Demographics
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewRelatedFieldIndex.Demographics);}
		}
	}

	/// <summary>Field Creation Class for entity EmployeeEntity</summary>
	public class EmployeeFields
	{
		/// <summary>Creates a new EmployeeEntity.EmployeeId field instance</summary>
		public static EntityField EmployeeId
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.EmployeeId);}
		}
		/// <summary>Creates a new EmployeeEntity.NationalIdnumber field instance</summary>
		public static EntityField NationalIdnumber
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.NationalIdnumber);}
		}
		/// <summary>Creates a new EmployeeEntity.ContactId field instance</summary>
		public static EntityField ContactId
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.ContactId);}
		}
		/// <summary>Creates a new EmployeeEntity.LoginId field instance</summary>
		public static EntityField LoginId
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.LoginId);}
		}
		/// <summary>Creates a new EmployeeEntity.ManagerId field instance</summary>
		public static EntityField ManagerId
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.ManagerId);}
		}
		/// <summary>Creates a new EmployeeEntity.Title field instance</summary>
		public static EntityField Title
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.Title);}
		}
		/// <summary>Creates a new EmployeeEntity.BirthDate field instance</summary>
		public static EntityField BirthDate
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.BirthDate);}
		}
		/// <summary>Creates a new EmployeeEntity.MaritalStatus field instance</summary>
		public static EntityField MaritalStatus
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.MaritalStatus);}
		}
		/// <summary>Creates a new EmployeeEntity.Gender field instance</summary>
		public static EntityField Gender
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.Gender);}
		}
		/// <summary>Creates a new EmployeeEntity.HireDate field instance</summary>
		public static EntityField HireDate
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.HireDate);}
		}
		/// <summary>Creates a new EmployeeEntity.SalariedFlag field instance</summary>
		public static EntityField SalariedFlag
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.SalariedFlag);}
		}
		/// <summary>Creates a new EmployeeEntity.VacationHours field instance</summary>
		public static EntityField VacationHours
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.VacationHours);}
		}
		/// <summary>Creates a new EmployeeEntity.SickLeaveHours field instance</summary>
		public static EntityField SickLeaveHours
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.SickLeaveHours);}
		}
		/// <summary>Creates a new EmployeeEntity.CurrentFlag field instance</summary>
		public static EntityField CurrentFlag
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.CurrentFlag);}
		}
		/// <summary>Creates a new EmployeeEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new EmployeeEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity EmployeeAddressEntity</summary>
	public class EmployeeAddressFields
	{
		/// <summary>Creates a new EmployeeAddressEntity.EmployeeId field instance</summary>
		public static EntityField EmployeeId
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeAddressFieldIndex.EmployeeId);}
		}
		/// <summary>Creates a new EmployeeAddressEntity.AddressId field instance</summary>
		public static EntityField AddressId
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeAddressFieldIndex.AddressId);}
		}
		/// <summary>Creates a new EmployeeAddressEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeAddressFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new EmployeeAddressEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(EmployeeAddressFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity IndividualEntity</summary>
	public class IndividualFields
	{
		/// <summary>Creates a new IndividualEntity.CustomerId field instance</summary>
		public static EntityField CustomerId
		{
			get { return (EntityField)EntityFieldFactory.Create(IndividualFieldIndex.CustomerId);}
		}
		/// <summary>Creates a new IndividualEntity.ContactId field instance</summary>
		public static EntityField ContactId
		{
			get { return (EntityField)EntityFieldFactory.Create(IndividualFieldIndex.ContactId);}
		}
		/// <summary>Creates a new IndividualEntity.Demographics field instance</summary>
		public static EntityField Demographics
		{
			get { return (EntityField)EntityFieldFactory.Create(IndividualFieldIndex.Demographics);}
		}
		/// <summary>Creates a new IndividualEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(IndividualFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity ProductEntity</summary>
	public class ProductFields
	{
		/// <summary>Creates a new ProductEntity.ProductId field instance</summary>
		public static EntityField ProductId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.ProductId);}
		}
		/// <summary>Creates a new ProductEntity.Name field instance</summary>
		public static EntityField Name
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.Name);}
		}
		/// <summary>Creates a new ProductEntity.ProductNumber field instance</summary>
		public static EntityField ProductNumber
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.ProductNumber);}
		}
		/// <summary>Creates a new ProductEntity.MakeFlag field instance</summary>
		public static EntityField MakeFlag
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.MakeFlag);}
		}
		/// <summary>Creates a new ProductEntity.FinishedGoodsFlag field instance</summary>
		public static EntityField FinishedGoodsFlag
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.FinishedGoodsFlag);}
		}
		/// <summary>Creates a new ProductEntity.Color field instance</summary>
		public static EntityField Color
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.Color);}
		}
		/// <summary>Creates a new ProductEntity.SafetyStockLevel field instance</summary>
		public static EntityField SafetyStockLevel
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.SafetyStockLevel);}
		}
		/// <summary>Creates a new ProductEntity.ReorderPoint field instance</summary>
		public static EntityField ReorderPoint
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.ReorderPoint);}
		}
		/// <summary>Creates a new ProductEntity.StandardCost field instance</summary>
		public static EntityField StandardCost
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.StandardCost);}
		}
		/// <summary>Creates a new ProductEntity.ListPrice field instance</summary>
		public static EntityField ListPrice
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.ListPrice);}
		}
		/// <summary>Creates a new ProductEntity.Size field instance</summary>
		public static EntityField Size
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.Size);}
		}
		/// <summary>Creates a new ProductEntity.SizeUnitMeasureCode field instance</summary>
		public static EntityField SizeUnitMeasureCode
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.SizeUnitMeasureCode);}
		}
		/// <summary>Creates a new ProductEntity.WeightUnitMeasureCode field instance</summary>
		public static EntityField WeightUnitMeasureCode
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.WeightUnitMeasureCode);}
		}
		/// <summary>Creates a new ProductEntity.Weight field instance</summary>
		public static EntityField Weight
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.Weight);}
		}
		/// <summary>Creates a new ProductEntity.DaysToManufacture field instance</summary>
		public static EntityField DaysToManufacture
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.DaysToManufacture);}
		}
		/// <summary>Creates a new ProductEntity.ProductLine field instance</summary>
		public static EntityField ProductLine
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.ProductLine);}
		}
		/// <summary>Creates a new ProductEntity.Class field instance</summary>
		public static EntityField Class
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.Class);}
		}
		/// <summary>Creates a new ProductEntity.Style field instance</summary>
		public static EntityField Style
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.Style);}
		}
		/// <summary>Creates a new ProductEntity.ProductSubcategoryId field instance</summary>
		public static EntityField ProductSubcategoryId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.ProductSubcategoryId);}
		}
		/// <summary>Creates a new ProductEntity.ProductModelId field instance</summary>
		public static EntityField ProductModelId
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.ProductModelId);}
		}
		/// <summary>Creates a new ProductEntity.SellStartDate field instance</summary>
		public static EntityField SellStartDate
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.SellStartDate);}
		}
		/// <summary>Creates a new ProductEntity.SellEndDate field instance</summary>
		public static EntityField SellEndDate
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.SellEndDate);}
		}
		/// <summary>Creates a new ProductEntity.DiscontinuedDate field instance</summary>
		public static EntityField DiscontinuedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.DiscontinuedDate);}
		}
		/// <summary>Creates a new ProductEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new ProductEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(ProductFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity SalesOrderDetailEntity</summary>
	public class SalesOrderDetailFields
	{
		/// <summary>Creates a new SalesOrderDetailEntity.SalesOrderId field instance</summary>
		public static EntityField SalesOrderId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderDetailFieldIndex.SalesOrderId);}
		}
		/// <summary>Creates a new SalesOrderDetailEntity.SalesOrderDetailId field instance</summary>
		public static EntityField SalesOrderDetailId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderDetailFieldIndex.SalesOrderDetailId);}
		}
		/// <summary>Creates a new SalesOrderDetailEntity.CarrierTrackingNumber field instance</summary>
		public static EntityField CarrierTrackingNumber
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderDetailFieldIndex.CarrierTrackingNumber);}
		}
		/// <summary>Creates a new SalesOrderDetailEntity.OrderQty field instance</summary>
		public static EntityField OrderQty
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderDetailFieldIndex.OrderQty);}
		}
		/// <summary>Creates a new SalesOrderDetailEntity.ProductId field instance</summary>
		public static EntityField ProductId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderDetailFieldIndex.ProductId);}
		}
		/// <summary>Creates a new SalesOrderDetailEntity.SpecialOfferId field instance</summary>
		public static EntityField SpecialOfferId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderDetailFieldIndex.SpecialOfferId);}
		}
		/// <summary>Creates a new SalesOrderDetailEntity.UnitPrice field instance</summary>
		public static EntityField UnitPrice
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderDetailFieldIndex.UnitPrice);}
		}
		/// <summary>Creates a new SalesOrderDetailEntity.UnitPriceDiscount field instance</summary>
		public static EntityField UnitPriceDiscount
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderDetailFieldIndex.UnitPriceDiscount);}
		}
		/// <summary>Creates a new SalesOrderDetailEntity.LineTotal field instance</summary>
		public static EntityField LineTotal
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderDetailFieldIndex.LineTotal);}
		}
		/// <summary>Creates a new SalesOrderDetailEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderDetailFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new SalesOrderDetailEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderDetailFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity SalesOrderHeaderEntity</summary>
	public class SalesOrderHeaderFields
	{
		/// <summary>Creates a new SalesOrderHeaderEntity.SalesOrderId field instance</summary>
		public static EntityField SalesOrderId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.SalesOrderId);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.RevisionNumber field instance</summary>
		public static EntityField RevisionNumber
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.RevisionNumber);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.OrderDate field instance</summary>
		public static EntityField OrderDate
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.OrderDate);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.DueDate field instance</summary>
		public static EntityField DueDate
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.DueDate);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.ShipDate field instance</summary>
		public static EntityField ShipDate
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.ShipDate);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.Status field instance</summary>
		public static EntityField Status
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.Status);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.OnlineOrderFlag field instance</summary>
		public static EntityField OnlineOrderFlag
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.OnlineOrderFlag);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.SalesOrderNumber field instance</summary>
		public static EntityField SalesOrderNumber
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.SalesOrderNumber);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.PurchaseOrderNumber field instance</summary>
		public static EntityField PurchaseOrderNumber
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.PurchaseOrderNumber);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.AccountNumber field instance</summary>
		public static EntityField AccountNumber
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.AccountNumber);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.CustomerId field instance</summary>
		public static EntityField CustomerId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.CustomerId);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.ContactId field instance</summary>
		public static EntityField ContactId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.ContactId);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.SalesPersonId field instance</summary>
		public static EntityField SalesPersonId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.SalesPersonId);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.TerritoryId field instance</summary>
		public static EntityField TerritoryId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.TerritoryId);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.BillToAddressId field instance</summary>
		public static EntityField BillToAddressId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.BillToAddressId);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.ShipToAddressId field instance</summary>
		public static EntityField ShipToAddressId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.ShipToAddressId);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.ShipMethodId field instance</summary>
		public static EntityField ShipMethodId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.ShipMethodId);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.CreditCardId field instance</summary>
		public static EntityField CreditCardId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.CreditCardId);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.CreditCardApprovalCode field instance</summary>
		public static EntityField CreditCardApprovalCode
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.CreditCardApprovalCode);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.CurrencyRateId field instance</summary>
		public static EntityField CurrencyRateId
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.CurrencyRateId);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.SubTotal field instance</summary>
		public static EntityField SubTotal
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.SubTotal);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.TaxAmt field instance</summary>
		public static EntityField TaxAmt
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.TaxAmt);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.Freight field instance</summary>
		public static EntityField Freight
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.Freight);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.TotalDue field instance</summary>
		public static EntityField TotalDue
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.TotalDue);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.Comment field instance</summary>
		public static EntityField Comment
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.Comment);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new SalesOrderHeaderEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity ShipMethodEntity</summary>
	public class ShipMethodFields
	{
		/// <summary>Creates a new ShipMethodEntity.ShipMethodId field instance</summary>
		public static EntityField ShipMethodId
		{
			get { return (EntityField)EntityFieldFactory.Create(ShipMethodFieldIndex.ShipMethodId);}
		}
		/// <summary>Creates a new ShipMethodEntity.Name field instance</summary>
		public static EntityField Name
		{
			get { return (EntityField)EntityFieldFactory.Create(ShipMethodFieldIndex.Name);}
		}
		/// <summary>Creates a new ShipMethodEntity.ShipBase field instance</summary>
		public static EntityField ShipBase
		{
			get { return (EntityField)EntityFieldFactory.Create(ShipMethodFieldIndex.ShipBase);}
		}
		/// <summary>Creates a new ShipMethodEntity.ShipRate field instance</summary>
		public static EntityField ShipRate
		{
			get { return (EntityField)EntityFieldFactory.Create(ShipMethodFieldIndex.ShipRate);}
		}
		/// <summary>Creates a new ShipMethodEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(ShipMethodFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new ShipMethodEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(ShipMethodFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity SpecialOfferEntity</summary>
	public class SpecialOfferFields
	{
		/// <summary>Creates a new SpecialOfferEntity.SpecialOfferId field instance</summary>
		public static EntityField SpecialOfferId
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferFieldIndex.SpecialOfferId);}
		}
		/// <summary>Creates a new SpecialOfferEntity.Description field instance</summary>
		public static EntityField Description
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferFieldIndex.Description);}
		}
		/// <summary>Creates a new SpecialOfferEntity.DiscountPct field instance</summary>
		public static EntityField DiscountPct
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferFieldIndex.DiscountPct);}
		}
		/// <summary>Creates a new SpecialOfferEntity.Type field instance</summary>
		public static EntityField Type
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferFieldIndex.Type);}
		}
		/// <summary>Creates a new SpecialOfferEntity.Category field instance</summary>
		public static EntityField Category
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferFieldIndex.Category);}
		}
		/// <summary>Creates a new SpecialOfferEntity.StartDate field instance</summary>
		public static EntityField StartDate
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferFieldIndex.StartDate);}
		}
		/// <summary>Creates a new SpecialOfferEntity.EndDate field instance</summary>
		public static EntityField EndDate
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferFieldIndex.EndDate);}
		}
		/// <summary>Creates a new SpecialOfferEntity.MinQty field instance</summary>
		public static EntityField MinQty
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferFieldIndex.MinQty);}
		}
		/// <summary>Creates a new SpecialOfferEntity.MaxQty field instance</summary>
		public static EntityField MaxQty
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferFieldIndex.MaxQty);}
		}
		/// <summary>Creates a new SpecialOfferEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new SpecialOfferEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity SpecialOfferProductEntity</summary>
	public class SpecialOfferProductFields
	{
		/// <summary>Creates a new SpecialOfferProductEntity.SpecialOfferId field instance</summary>
		public static EntityField SpecialOfferId
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferProductFieldIndex.SpecialOfferId);}
		}
		/// <summary>Creates a new SpecialOfferProductEntity.ProductId field instance</summary>
		public static EntityField ProductId
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferProductFieldIndex.ProductId);}
		}
		/// <summary>Creates a new SpecialOfferProductEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferProductFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new SpecialOfferProductEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(SpecialOfferProductFieldIndex.ModifiedDate);}
		}
	}

	/// <summary>Field Creation Class for entity StateProvinceEntity</summary>
	public class StateProvinceFields
	{
		/// <summary>Creates a new StateProvinceEntity.StateProvinceId field instance</summary>
		public static EntityField StateProvinceId
		{
			get { return (EntityField)EntityFieldFactory.Create(StateProvinceFieldIndex.StateProvinceId);}
		}
		/// <summary>Creates a new StateProvinceEntity.StateProvinceCode field instance</summary>
		public static EntityField StateProvinceCode
		{
			get { return (EntityField)EntityFieldFactory.Create(StateProvinceFieldIndex.StateProvinceCode);}
		}
		/// <summary>Creates a new StateProvinceEntity.CountryRegionCode field instance</summary>
		public static EntityField CountryRegionCode
		{
			get { return (EntityField)EntityFieldFactory.Create(StateProvinceFieldIndex.CountryRegionCode);}
		}
		/// <summary>Creates a new StateProvinceEntity.IsOnlyStateProvinceFlag field instance</summary>
		public static EntityField IsOnlyStateProvinceFlag
		{
			get { return (EntityField)EntityFieldFactory.Create(StateProvinceFieldIndex.IsOnlyStateProvinceFlag);}
		}
		/// <summary>Creates a new StateProvinceEntity.Name field instance</summary>
		public static EntityField Name
		{
			get { return (EntityField)EntityFieldFactory.Create(StateProvinceFieldIndex.Name);}
		}
		/// <summary>Creates a new StateProvinceEntity.TerritoryId field instance</summary>
		public static EntityField TerritoryId
		{
			get { return (EntityField)EntityFieldFactory.Create(StateProvinceFieldIndex.TerritoryId);}
		}
		/// <summary>Creates a new StateProvinceEntity.Rowguid field instance</summary>
		public static EntityField Rowguid
		{
			get { return (EntityField)EntityFieldFactory.Create(StateProvinceFieldIndex.Rowguid);}
		}
		/// <summary>Creates a new StateProvinceEntity.ModifiedDate field instance</summary>
		public static EntityField ModifiedDate
		{
			get { return (EntityField)EntityFieldFactory.Create(StateProvinceFieldIndex.ModifiedDate);}
		}
	}
	

	/// <summary>Field Creation Class for typedview CustomerViewTypedView</summary>
	public class CustomerViewFields
	{
		/// <summary>Creates a new CustomerViewTypedView.CustomerId field instance</summary>
		public static EntityField CustomerId
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.CustomerId);}
		}

		/// <summary>Creates a new CustomerViewTypedView.Title field instance</summary>
		public static EntityField Title
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.Title);}
		}

		/// <summary>Creates a new CustomerViewTypedView.FirstName field instance</summary>
		public static EntityField FirstName
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.FirstName);}
		}

		/// <summary>Creates a new CustomerViewTypedView.MiddleName field instance</summary>
		public static EntityField MiddleName
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.MiddleName);}
		}

		/// <summary>Creates a new CustomerViewTypedView.LastName field instance</summary>
		public static EntityField LastName
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.LastName);}
		}

		/// <summary>Creates a new CustomerViewTypedView.Suffix field instance</summary>
		public static EntityField Suffix
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.Suffix);}
		}

		/// <summary>Creates a new CustomerViewTypedView.Phone field instance</summary>
		public static EntityField Phone
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.Phone);}
		}

		/// <summary>Creates a new CustomerViewTypedView.EmailAddress field instance</summary>
		public static EntityField EmailAddress
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.EmailAddress);}
		}

		/// <summary>Creates a new CustomerViewTypedView.EmailPromotion field instance</summary>
		public static EntityField EmailPromotion
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.EmailPromotion);}
		}

		/// <summary>Creates a new CustomerViewTypedView.AddressType field instance</summary>
		public static EntityField AddressType
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.AddressType);}
		}

		/// <summary>Creates a new CustomerViewTypedView.AddressLine1 field instance</summary>
		public static EntityField AddressLine1
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.AddressLine1);}
		}

		/// <summary>Creates a new CustomerViewTypedView.AddressLine2 field instance</summary>
		public static EntityField AddressLine2
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.AddressLine2);}
		}

		/// <summary>Creates a new CustomerViewTypedView.City field instance</summary>
		public static EntityField City
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.City);}
		}

		/// <summary>Creates a new CustomerViewTypedView.StateProvinceName field instance</summary>
		public static EntityField StateProvinceName
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.StateProvinceName);}
		}

		/// <summary>Creates a new CustomerViewTypedView.PostalCode field instance</summary>
		public static EntityField PostalCode
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.PostalCode);}
		}

		/// <summary>Creates a new CustomerViewTypedView.CountryRegionName field instance</summary>
		public static EntityField CountryRegionName
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.CountryRegionName);}
		}

		/// <summary>Creates a new CustomerViewTypedView.Demographics field instance</summary>
		public static EntityField Demographics
		{
			get { return (EntityField)EntityFieldFactory.Create(CustomerViewFieldIndex.Demographics);}
		}
	}
}