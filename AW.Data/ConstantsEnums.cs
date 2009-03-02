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

namespace AW.Data
{

	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Address.
	/// </summary>
	public enum AddressFieldIndex:int
	{
		///<summary>AddressID. </summary>
		AddressID,
		///<summary>AddressLine1. </summary>
		AddressLine1,
		///<summary>AddressLine2. </summary>
		AddressLine2,
		///<summary>City. </summary>
		City,
		///<summary>StateProvinceID. </summary>
		StateProvinceID,
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
		///<summary>AddressTypeID. </summary>
		AddressTypeID,
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
		///<summary>ContactID. </summary>
		ContactID,
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
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CreditCard.
	/// </summary>
	public enum CreditCardFieldIndex:int
	{
		///<summary>CreditCardID. </summary>
		CreditCardID,
		///<summary>CardType. </summary>
		CardType,
		///<summary>CardNumber. </summary>
		CardNumber,
		///<summary>ExpMonth. </summary>
		ExpMonth,
		///<summary>ExpYear. </summary>
		ExpYear,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Currency.
	/// </summary>
	public enum CurrencyFieldIndex:int
	{
		///<summary>CurrencyCode. </summary>
		CurrencyCode,
		///<summary>Name. </summary>
		Name,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CurrencyRate.
	/// </summary>
	public enum CurrencyRateFieldIndex:int
	{
		///<summary>CurrencyRateID. </summary>
		CurrencyRateID,
		///<summary>CurrencyRateDate. </summary>
		CurrencyRateDate,
		///<summary>FromCurrencyCode. </summary>
		FromCurrencyCode,
		///<summary>ToCurrencyCode. </summary>
		ToCurrencyCode,
		///<summary>AverageRate. </summary>
		AverageRate,
		///<summary>EndOfDayRate. </summary>
		EndOfDayRate,
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
		///<summary>CustomerID. </summary>
		CustomerID,
		///<summary>TerritoryID. </summary>
		TerritoryID,
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
		///<summary>CustomerID. </summary>
		CustomerID,
		///<summary>AddressID. </summary>
		AddressID,
		///<summary>AddressTypeID. </summary>
		AddressTypeID,
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
		///<summary>EmployeeID. </summary>
		EmployeeID,
		///<summary>NationalIdnumber. </summary>
		NationalIdnumber,
		///<summary>ContactID. </summary>
		ContactID,
		///<summary>LoginID. </summary>
		LoginID,
		///<summary>ManagerID. </summary>
		ManagerID,
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
		///<summary>EmployeeID. </summary>
		EmployeeID,
		///<summary>AddressID. </summary>
		AddressID,
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
		///<summary>CustomerID. </summary>
		CustomerID,
		///<summary>ContactID. </summary>
		ContactID,
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
		///<summary>ProductID. </summary>
		ProductID,
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
		///<summary>ProductSubcategoryID. </summary>
		ProductSubcategoryID,
		///<summary>ProductModelID. </summary>
		ProductModelID,
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
		///<summary>SalesOrderID. </summary>
		SalesOrderID,
		///<summary>SalesOrderDetailID. </summary>
		SalesOrderDetailID,
		///<summary>CarrierTrackingNumber. </summary>
		CarrierTrackingNumber,
		///<summary>OrderQty. </summary>
		OrderQty,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>SpecialOfferID. </summary>
		SpecialOfferID,
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
		///<summary>SalesOrderID. </summary>
		SalesOrderID,
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
		///<summary>CustomerID. </summary>
		CustomerID,
		///<summary>ContactID. </summary>
		ContactID,
		///<summary>SalesPersonID. </summary>
		SalesPersonID,
		///<summary>TerritoryID. </summary>
		TerritoryID,
		///<summary>BillToAddressID. </summary>
		BillToAddressID,
		///<summary>ShipToAddressID. </summary>
		ShipToAddressID,
		///<summary>ShipMethodID. </summary>
		ShipMethodID,
		///<summary>CreditCardID. </summary>
		CreditCardID,
		///<summary>CreditCardApprovalCode. </summary>
		CreditCardApprovalCode,
		///<summary>CurrencyRateID. </summary>
		CurrencyRateID,
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
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesTerritory.
	/// </summary>
	public enum SalesTerritoryFieldIndex:int
	{
		///<summary>TerritoryID. </summary>
		TerritoryID,
		///<summary>Name. </summary>
		Name,
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>Group. </summary>
		Group,
		///<summary>SalesYtd. </summary>
		SalesYtd,
		///<summary>SalesLastYear. </summary>
		SalesLastYear,
		///<summary>CostYtd. </summary>
		CostYtd,
		///<summary>CostLastYear. </summary>
		CostLastYear,
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
		///<summary>ShipMethodID. </summary>
		ShipMethodID,
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
		///<summary>SpecialOfferID. </summary>
		SpecialOfferID,
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
		///<summary>SpecialOfferID. </summary>
		SpecialOfferID,
		///<summary>ProductID. </summary>
		ProductID,
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
		///<summary>StateProvinceID. </summary>
		StateProvinceID,
		///<summary>StateProvinceCode. </summary>
		StateProvinceCode,
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>IsOnlyStateProvinceFlag. </summary>
		IsOnlyStateProvinceFlag,
		///<summary>Name. </summary>
		Name,
		///<summary>TerritoryID. </summary>
		TerritoryID,
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
		///<summary>AddressLine1</summary>
		AddressLine1,
		///<summary>AddressLine2</summary>
		AddressLine2,
		///<summary>City</summary>
		City,
		///<summary>Name</summary>
		Name,
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
		///<summary>EmailAddress</summary>
		EmailAddress,
		///<summary>EmailPromotion</summary>
		EmailPromotion,
		///<summary>CountryRegionName</summary>
		CountryRegionName,
		///<summary>StateProvinceName</summary>
		StateProvinceName,
		///<summary>CustomerId</summary>
		CustomerId,
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
		///<summary>CreditCard</summary>
		CreditCardEntity,
		///<summary>Currency</summary>
		CurrencyEntity,
		///<summary>CurrencyRate</summary>
		CurrencyRateEntity,
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
		///<summary>SalesTerritory</summary>
		SalesTerritoryEntity,
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


