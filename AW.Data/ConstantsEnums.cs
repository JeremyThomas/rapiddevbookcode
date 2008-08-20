///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:32 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;

namespace AW.Data
{

	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Address.
	/// </summary>
	public enum AddressFieldIndex:int
	{
		///<summary>AddressId. </summary>
		AddressId,
		///<summary>AddressLine1. </summary>
		AddressLine1,
		///<summary>AddressLine2. </summary>
		AddressLine2,
		///<summary>City. </summary>
		City,
		///<summary>StateProvinceId. </summary>
		StateProvinceId,
		///<summary>PostalCode. </summary>
		PostalCode,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AddressType.
	/// </summary>
	public enum AddressTypeFieldIndex:int
	{
		///<summary>AddressTypeId. </summary>
		AddressTypeId,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Contact.
	/// </summary>
	public enum ContactFieldIndex:int
	{
		///<summary>ContactId. </summary>
		ContactId,
		///<summary>NameStyle. </summary>
		NameStyle,
		///<summary>Title. </summary>
		Title,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>MiddleName. </summary>
		MiddleName,
		///<summary>LastName. </summary>
		LastName,
		///<summary>Suffix. </summary>
		Suffix,
		///<summary>EmailAddress. </summary>
		EmailAddress,
		///<summary>EmailPromotion. </summary>
		EmailPromotion,
		///<summary>Phone. </summary>
		Phone,
		///<summary>PasswordHash. </summary>
		PasswordHash,
		///<summary>PasswordSalt. </summary>
		PasswordSalt,
		///<summary>AdditionalContactInfo. </summary>
		AdditionalContactInfo,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CountryRegion.
	/// </summary>
	public enum CountryRegionFieldIndex:int
	{
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>Name. </summary>
		Name,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Customer.
	/// </summary>
	public enum CustomerFieldIndex:int
	{
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		///<summary>AccountNumber. </summary>
		AccountNumber,
		///<summary>CustomerType. </summary>
		CustomerType,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CustomerAddress.
	/// </summary>
	public enum CustomerAddressFieldIndex:int
	{
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>AddressId. </summary>
		AddressId,
		///<summary>AddressTypeId. </summary>
		AddressTypeId,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CustomerViewRelated.
	/// </summary>
	public enum CustomerViewRelatedFieldIndex:int
	{
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>Title. </summary>
		Title,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>MiddleName. </summary>
		MiddleName,
		///<summary>LastName. </summary>
		LastName,
		///<summary>Suffix. </summary>
		Suffix,
		///<summary>Phone. </summary>
		Phone,
		///<summary>EmailAddress. </summary>
		EmailAddress,
		///<summary>EmailPromotion. </summary>
		EmailPromotion,
		///<summary>AddressType. </summary>
		AddressType,
		///<summary>AddressLine1. </summary>
		AddressLine1,
		///<summary>AddressLine2. </summary>
		AddressLine2,
		///<summary>City. </summary>
		City,
		///<summary>StateProvinceName. </summary>
		StateProvinceName,
		///<summary>PostalCode. </summary>
		PostalCode,
		///<summary>CountryRegionName. </summary>
		CountryRegionName,
		///<summary>Demographics. </summary>
		Demographics,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Employee.
	/// </summary>
	public enum EmployeeFieldIndex:int
	{
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>NationalIdnumber. </summary>
		NationalIdnumber,
		///<summary>ContactId. </summary>
		ContactId,
		///<summary>LoginId. </summary>
		LoginId,
		///<summary>ManagerId. </summary>
		ManagerId,
		///<summary>Title. </summary>
		Title,
		///<summary>BirthDate. </summary>
		BirthDate,
		///<summary>MaritalStatus. </summary>
		MaritalStatus,
		///<summary>Gender. </summary>
		Gender,
		///<summary>HireDate. </summary>
		HireDate,
		///<summary>SalariedFlag. </summary>
		SalariedFlag,
		///<summary>VacationHours. </summary>
		VacationHours,
		///<summary>SickLeaveHours. </summary>
		SickLeaveHours,
		///<summary>CurrentFlag. </summary>
		CurrentFlag,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EmployeeAddress.
	/// </summary>
	public enum EmployeeAddressFieldIndex:int
	{
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>AddressId. </summary>
		AddressId,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Individual.
	/// </summary>
	public enum IndividualFieldIndex:int
	{
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>ContactId. </summary>
		ContactId,
		///<summary>Demographics. </summary>
		Demographics,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Product.
	/// </summary>
	public enum ProductFieldIndex:int
	{
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Name. </summary>
		Name,
		///<summary>ProductNumber. </summary>
		ProductNumber,
		///<summary>MakeFlag. </summary>
		MakeFlag,
		///<summary>FinishedGoodsFlag. </summary>
		FinishedGoodsFlag,
		///<summary>Color. </summary>
		Color,
		///<summary>SafetyStockLevel. </summary>
		SafetyStockLevel,
		///<summary>ReorderPoint. </summary>
		ReorderPoint,
		///<summary>StandardCost. </summary>
		StandardCost,
		///<summary>ListPrice. </summary>
		ListPrice,
		///<summary>Size. </summary>
		Size,
		///<summary>SizeUnitMeasureCode. </summary>
		SizeUnitMeasureCode,
		///<summary>WeightUnitMeasureCode. </summary>
		WeightUnitMeasureCode,
		///<summary>Weight. </summary>
		Weight,
		///<summary>DaysToManufacture. </summary>
		DaysToManufacture,
		///<summary>ProductLine. </summary>
		ProductLine,
		///<summary>Class. </summary>
		Class,
		///<summary>Style. </summary>
		Style,
		///<summary>ProductSubcategoryId. </summary>
		ProductSubcategoryId,
		///<summary>ProductModelId. </summary>
		ProductModelId,
		///<summary>SellStartDate. </summary>
		SellStartDate,
		///<summary>SellEndDate. </summary>
		SellEndDate,
		///<summary>DiscontinuedDate. </summary>
		DiscontinuedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesOrderDetail.
	/// </summary>
	public enum SalesOrderDetailFieldIndex:int
	{
		///<summary>SalesOrderId. </summary>
		SalesOrderId,
		///<summary>SalesOrderDetailId. </summary>
		SalesOrderDetailId,
		///<summary>CarrierTrackingNumber. </summary>
		CarrierTrackingNumber,
		///<summary>OrderQty. </summary>
		OrderQty,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>SpecialOfferId. </summary>
		SpecialOfferId,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		///<summary>UnitPriceDiscount. </summary>
		UnitPriceDiscount,
		///<summary>LineTotal. </summary>
		LineTotal,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesOrderHeader.
	/// </summary>
	public enum SalesOrderHeaderFieldIndex:int
	{
		///<summary>SalesOrderId. </summary>
		SalesOrderId,
		///<summary>RevisionNumber. </summary>
		RevisionNumber,
		///<summary>OrderDate. </summary>
		OrderDate,
		///<summary>DueDate. </summary>
		DueDate,
		///<summary>ShipDate. </summary>
		ShipDate,
		///<summary>Status. </summary>
		Status,
		///<summary>OnlineOrderFlag. </summary>
		OnlineOrderFlag,
		///<summary>SalesOrderNumber. </summary>
		SalesOrderNumber,
		///<summary>PurchaseOrderNumber. </summary>
		PurchaseOrderNumber,
		///<summary>AccountNumber. </summary>
		AccountNumber,
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>ContactId. </summary>
		ContactId,
		///<summary>SalesPersonId. </summary>
		SalesPersonId,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		///<summary>BillToAddressId. </summary>
		BillToAddressId,
		///<summary>ShipToAddressId. </summary>
		ShipToAddressId,
		///<summary>ShipMethodId. </summary>
		ShipMethodId,
		///<summary>CreditCardId. </summary>
		CreditCardId,
		///<summary>CreditCardApprovalCode. </summary>
		CreditCardApprovalCode,
		///<summary>CurrencyRateId. </summary>
		CurrencyRateId,
		///<summary>SubTotal. </summary>
		SubTotal,
		///<summary>TaxAmt. </summary>
		TaxAmt,
		///<summary>Freight. </summary>
		Freight,
		///<summary>TotalDue. </summary>
		TotalDue,
		///<summary>Comment. </summary>
		Comment,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ShipMethod.
	/// </summary>
	public enum ShipMethodFieldIndex:int
	{
		///<summary>ShipMethodId. </summary>
		ShipMethodId,
		///<summary>Name. </summary>
		Name,
		///<summary>ShipBase. </summary>
		ShipBase,
		///<summary>ShipRate. </summary>
		ShipRate,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SpecialOffer.
	/// </summary>
	public enum SpecialOfferFieldIndex:int
	{
		///<summary>SpecialOfferId. </summary>
		SpecialOfferId,
		///<summary>Description. </summary>
		Description,
		///<summary>DiscountPct. </summary>
		DiscountPct,
		///<summary>Type. </summary>
		Type,
		///<summary>Category. </summary>
		Category,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>MinQty. </summary>
		MinQty,
		///<summary>MaxQty. </summary>
		MaxQty,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SpecialOfferProduct.
	/// </summary>
	public enum SpecialOfferProductFieldIndex:int
	{
		///<summary>SpecialOfferId. </summary>
		SpecialOfferId,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: StateProvince.
	/// </summary>
	public enum StateProvinceFieldIndex:int
	{
		///<summary>StateProvinceId. </summary>
		StateProvinceId,
		///<summary>StateProvinceCode. </summary>
		StateProvinceCode,
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>IsOnlyStateProvinceFlag. </summary>
		IsOnlyStateProvinceFlag,
		///<summary>Name. </summary>
		Name,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : CustomerView.
	/// </summary>
	public enum CustomerViewFieldIndex:int
	{
		///<summary>CustomerId</summary>
		CustomerId,
		///<summary>Title</summary>
		Title,
		///<summary>FirstName</summary>
		FirstName,
		///<summary>MiddleName</summary>
		MiddleName,
		///<summary>LastName</summary>
		LastName,
		///<summary>Suffix</summary>
		Suffix,
		///<summary>Phone</summary>
		Phone,
		///<summary>EmailAddress</summary>
		EmailAddress,
		///<summary>EmailPromotion</summary>
		EmailPromotion,
		///<summary>AddressType</summary>
		AddressType,
		///<summary>AddressLine1</summary>
		AddressLine1,
		///<summary>AddressLine2</summary>
		AddressLine2,
		///<summary>City</summary>
		City,
		///<summary>StateProvinceName</summary>
		StateProvinceName,
		///<summary>PostalCode</summary>
		PostalCode,
		///<summary>CountryRegionName</summary>
		CountryRegionName,
		///<summary>Demographics</summary>
		Demographics,
		/// <summary></summary>
		AmountOfFields
	}

 
	/// <summary>
	/// Index enum to fast-access TypedList Fields in the Columns collection of the Typed List: CustomerList
	/// </summary>
	public enum CustomerListTypedListFieldIndex:int
	{
		///<summary>CustomerId</summary>
		CustomerId,
		///<summary>Title</summary>
		Title,
		///<summary>FirstName</summary>
		FirstName,
		///<summary>MiddleName</summary>
		MiddleName,
		///<summary>LastName</summary>
		LastName,
		///<summary>Suffix</summary>
		Suffix,
		///<summary>Phone</summary>
		Phone,
		///<summary>EmailAddress</summary>
		EmailAddress,
		///<summary>EmailPromotion</summary>
		EmailPromotion,
		///<summary>AddressType</summary>
		AddressType,
		///<summary>AddressLine1</summary>
		AddressLine1,
		///<summary>AddressLine2</summary>
		AddressLine2,
		///<summary>City</summary>
		City,
		///<summary>StateProvinceName</summary>
		StateProvinceName,
		///<summary>PostalCode</summary>
		PostalCode,
		///<summary>CountryRegionName</summary>
		CountryRegionName,
		/// <summary></summary>
		AmountOfFields
	}



	/// <summary>
	/// Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.
	/// </summary>
	public enum EntityType:int
	{
		///<summary>Address</summary>
		AddressEntity,
		///<summary>AddressType</summary>
		AddressTypeEntity,
		///<summary>Contact</summary>
		ContactEntity,
		///<summary>CountryRegion</summary>
		CountryRegionEntity,
		///<summary>Customer</summary>
		CustomerEntity,
		///<summary>CustomerAddress</summary>
		CustomerAddressEntity,
		///<summary>CustomerViewRelated</summary>
		CustomerViewRelatedEntity,
		///<summary>Employee</summary>
		EmployeeEntity,
		///<summary>EmployeeAddress</summary>
		EmployeeAddressEntity,
		///<summary>Individual</summary>
		IndividualEntity,
		///<summary>Product</summary>
		ProductEntity,
		///<summary>SalesOrderDetail</summary>
		SalesOrderDetailEntity,
		///<summary>SalesOrderHeader</summary>
		SalesOrderHeaderEntity,
		///<summary>ShipMethod</summary>
		ShipMethodEntity,
		///<summary>SpecialOffer</summary>
		SpecialOfferEntity,
		///<summary>SpecialOfferProduct</summary>
		SpecialOfferProductEntity,
		///<summary>StateProvince</summary>
		StateProvinceEntity
	}



	/// <summary>
	/// Enum definition for all the typed view types defined in this namespace. Used by the entityfields factory.
	/// </summary>
	public enum TypedViewType:int
	{
		///<summary>CustomerView</summary>
		CustomerViewTypedView
	}


	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	#endregion

	#region Included code

	#endregion
}


