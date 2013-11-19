///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using AW.Helper.TypeConverters;

namespace AW.Data
{
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AwbuildVersion.</summary>
	public enum AwbuildVersionFieldIndex
	{
		///<summary>DatabaseVersion. </summary>
		DatabaseVersion,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>SystemInformationID. </summary>
		SystemInformationID,
		///<summary>VersionDate. </summary>
		VersionDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DatabaseLog.</summary>
	public enum DatabaseLogFieldIndex
	{
		///<summary>DatabaseLogID. </summary>
		DatabaseLogID,
		///<summary>DatabaseUser. </summary>
		DatabaseUser,
		///<summary>Event. </summary>
		Event,
		///<summary>Object. </summary>
		Object,
		///<summary>PostTime. </summary>
		PostTime,
		///<summary>Schema. </summary>
		Schema,
		///<summary>Tsql. </summary>
		Tsql,
		///<summary>XmlEvent. </summary>
		XmlEvent,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ErrorLog.</summary>
	public enum ErrorLogFieldIndex
	{
		///<summary>ErrorLine. </summary>
		ErrorLine,
		///<summary>ErrorLogID. </summary>
		ErrorLogID,
		///<summary>ErrorMessage. </summary>
		ErrorMessage,
		///<summary>ErrorNumber. </summary>
		ErrorNumber,
		///<summary>ErrorProcedure. </summary>
		ErrorProcedure,
		///<summary>ErrorSeverity. </summary>
		ErrorSeverity,
		///<summary>ErrorState. </summary>
		ErrorState,
		///<summary>ErrorTime. </summary>
		ErrorTime,
		///<summary>UserName. </summary>
		UserName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Department.</summary>
	public enum DepartmentFieldIndex
	{
		///<summary>DepartmentID. </summary>
		DepartmentID,
		///<summary>GroupName. </summary>
		GroupName,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Employee.</summary>
	public enum EmployeeFieldIndex
	{
		///<summary>BirthDate. </summary>
		BirthDate,
		///<summary>ContactID. </summary>
		ContactID,
		///<summary>CurrentFlag. </summary>
		CurrentFlag,
		///<summary>EmployeeID. </summary>
		EmployeeID,
		///<summary>Gender. </summary>
		Gender,
		///<summary>HireDate. </summary>
		HireDate,
		///<summary>LoginID. </summary>
		LoginID,
		///<summary>ManagerID. </summary>
		ManagerID,
		///<summary>MaritalStatus. </summary>
		MaritalStatus,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>NationalIdnumber. </summary>
		NationalIdnumber,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalariedFlag. </summary>
		SalariedFlag,
		///<summary>SickLeaveHours. </summary>
		SickLeaveHours,
		///<summary>Title. </summary>
		Title,
		///<summary>VacationHours. </summary>
		VacationHours,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EmployeeAddress.</summary>
	public enum EmployeeAddressFieldIndex
	{
		///<summary>AddressID. </summary>
		AddressID,
		///<summary>EmployeeID. </summary>
		EmployeeID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EmployeeDepartmentHistory.</summary>
	public enum EmployeeDepartmentHistoryFieldIndex
	{
		///<summary>DepartmentID. </summary>
		DepartmentID,
		///<summary>EmployeeID. </summary>
		EmployeeID,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ShiftID. </summary>
		ShiftID,
		///<summary>StartDate. </summary>
		StartDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EmployeePayHistory.</summary>
	public enum EmployeePayHistoryFieldIndex
	{
		///<summary>EmployeeID. </summary>
		EmployeeID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PayFrequency. </summary>
		PayFrequency,
		///<summary>Rate. </summary>
		Rate,
		///<summary>RateChangeDate. </summary>
		RateChangeDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: JobCandidate.</summary>
	public enum JobCandidateFieldIndex
	{
		///<summary>EmployeeID. </summary>
		EmployeeID,
		///<summary>JobCandidateID. </summary>
		JobCandidateID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Resume. </summary>
		Resume,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Shift.</summary>
	public enum ShiftFieldIndex
	{
		///<summary>EndTime. </summary>
		EndTime,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ShiftID. </summary>
		ShiftID,
		///<summary>StartTime. </summary>
		StartTime,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Address.</summary>
	public enum AddressFieldIndex
	{
		///<summary>AddressID. </summary>
		AddressID,
		///<summary>AddressLine1. </summary>
		AddressLine1,
		///<summary>AddressLine2. </summary>
		AddressLine2,
		///<summary>City. </summary>
		City,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PostalCode. </summary>
		PostalCode,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>StateProvinceID. </summary>
		StateProvinceID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AddressType.</summary>
	public enum AddressTypeFieldIndex
	{
		///<summary>AddressTypeID. </summary>
		AddressTypeID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Contact.</summary>
	public enum ContactFieldIndex
	{
		///<summary>AdditionalContactInfo. </summary>
		AdditionalContactInfo,
		///<summary>ContactID. </summary>
		ContactID,
		///<summary>EmailAddress. </summary>
		EmailAddress,
		///<summary>EmailPromotion. </summary>
		EmailPromotion,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>LastName. </summary>
		LastName,
		///<summary>MiddleName. </summary>
		MiddleName,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>NameStyle. </summary>
		NameStyle,
		///<summary>PasswordHash. </summary>
		PasswordHash,
		///<summary>PasswordSalt. </summary>
		PasswordSalt,
		///<summary>Phone. </summary>
		Phone,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>Suffix. </summary>
		Suffix,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ContactType.</summary>
	public enum ContactTypeFieldIndex
	{
		///<summary>ContactTypeID. </summary>
		ContactTypeID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CountryRegion.</summary>
	public enum CountryRegionFieldIndex
	{
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: StateProvince.</summary>
	public enum StateProvinceFieldIndex
	{
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>IsOnlyStateProvinceFlag. </summary>
		IsOnlyStateProvinceFlag,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>StateProvinceCode. </summary>
		StateProvinceCode,
		///<summary>StateProvinceID. </summary>
		StateProvinceID,
		///<summary>TerritoryID. </summary>
		TerritoryID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: BillOfMaterial.</summary>
	public enum BillOfMaterialFieldIndex
	{
		///<summary>BillOfMaterialsID. </summary>
		BillOfMaterialsID,
		///<summary>Bomlevel. </summary>
		Bomlevel,
		///<summary>ComponentID. </summary>
		ComponentID,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PerAssemblyQuantity. </summary>
		PerAssemblyQuantity,
		///<summary>ProductAssemblyID. </summary>
		ProductAssemblyID,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>UnitMeasureCode. </summary>
		UnitMeasureCode,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Culture.</summary>
	public enum CultureFieldIndex
	{
		///<summary>CultureID. </summary>
		CultureID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Document.</summary>
	public enum DocumentFieldIndex
	{
		///<summary>ChangeNumber. </summary>
		ChangeNumber,
		///<summary>Document. </summary>
		Document,
		///<summary>DocumentID. </summary>
		DocumentID,
		///<summary>DocumentSummary. </summary>
		DocumentSummary,
		///<summary>FileExtension. </summary>
		FileExtension,
		///<summary>FileName. </summary>
		FileName,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Revision. </summary>
		Revision,
		///<summary>Status. </summary>
		Status,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Illustration.</summary>
	public enum IllustrationFieldIndex
	{
		///<summary>Diagram. </summary>
		Diagram,
		///<summary>IllustrationID. </summary>
		IllustrationID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Location.</summary>
	public enum LocationFieldIndex
	{
		///<summary>Availability. </summary>
		Availability,
		///<summary>CostRate. </summary>
		CostRate,
		///<summary>LocationID. </summary>
		LocationID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Product.</summary>
	public enum ProductFieldIndex
	{
		///<summary>Class. </summary>
		Class,
		///<summary>Color. </summary>
		Color,
		///<summary>DaysToManufacture. </summary>
		DaysToManufacture,
		///<summary>DiscontinuedDate. </summary>
		DiscontinuedDate,
		///<summary>FinishedGoodsFlag. </summary>
		FinishedGoodsFlag,
		///<summary>ListPrice. </summary>
		ListPrice,
		///<summary>MakeFlag. </summary>
		MakeFlag,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>ProductLine. </summary>
		ProductLine,
		///<summary>ProductModelID. </summary>
		ProductModelID,
		///<summary>ProductNumber. </summary>
		ProductNumber,
		///<summary>ProductSubcategoryID. </summary>
		ProductSubcategoryID,
		///<summary>ReorderPoint. </summary>
		ReorderPoint,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SafetyStockLevel. </summary>
		SafetyStockLevel,
		///<summary>SellEndDate. </summary>
		SellEndDate,
		///<summary>SellStartDate. </summary>
		SellStartDate,
		///<summary>Size. </summary>
		Size,
		///<summary>SizeUnitMeasureCode. </summary>
		SizeUnitMeasureCode,
		///<summary>StandardCost. </summary>
		StandardCost,
		///<summary>Style. </summary>
		Style,
		///<summary>Weight. </summary>
		Weight,
		///<summary>WeightUnitMeasureCode. </summary>
		WeightUnitMeasureCode,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductCategory.</summary>
	public enum ProductCategoryFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ProductCategoryID. </summary>
		ProductCategoryID,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductCostHistory.</summary>
	public enum ProductCostHistoryFieldIndex
	{
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>StandardCost. </summary>
		StandardCost,
		///<summary>StartDate. </summary>
		StartDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductDescription.</summary>
	public enum ProductDescriptionFieldIndex
	{
		///<summary>Description. </summary>
		Description,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductDescriptionID. </summary>
		ProductDescriptionID,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductDocument.</summary>
	public enum ProductDocumentFieldIndex
	{
		///<summary>DocumentID. </summary>
		DocumentID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductID. </summary>
		ProductID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductInventory.</summary>
	public enum ProductInventoryFieldIndex
	{
		///<summary>Bin. </summary>
		Bin,
		///<summary>LocationID. </summary>
		LocationID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>Shelf. </summary>
		Shelf,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductListPriceHistory.</summary>
	public enum ProductListPriceHistoryFieldIndex
	{
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ListPrice. </summary>
		ListPrice,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>StartDate. </summary>
		StartDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductModel.</summary>
	public enum ProductModelFieldIndex
	{
		///<summary>CatalogDescription. </summary>
		CatalogDescription,
		///<summary>Instructions. </summary>
		Instructions,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ProductModelID. </summary>
		ProductModelID,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductModelIllustration.</summary>
	public enum ProductModelIllustrationFieldIndex
	{
		///<summary>IllustrationID. </summary>
		IllustrationID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductModelID. </summary>
		ProductModelID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductModelProductDescriptionCulture.</summary>
	public enum ProductModelProductDescriptionCultureFieldIndex
	{
		///<summary>CultureID. </summary>
		CultureID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductDescriptionID. </summary>
		ProductDescriptionID,
		///<summary>ProductModelID. </summary>
		ProductModelID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductPhoto.</summary>
	public enum ProductPhotoFieldIndex
	{
		///<summary>LargePhoto. </summary>
		LargePhoto,
		///<summary>LargePhotoFileName. </summary>
		LargePhotoFileName,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductPhotoID. </summary>
		ProductPhotoID,
		///<summary>ThumbNailPhoto. </summary>
		ThumbNailPhoto,
		///<summary>ThumbnailPhotoFileName. </summary>
		ThumbnailPhotoFileName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductProductPhoto.</summary>
	public enum ProductProductPhotoFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Primary. </summary>
		Primary,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>ProductPhotoID. </summary>
		ProductPhotoID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductReview.</summary>
	public enum ProductReviewFieldIndex
	{
		///<summary>Comments. </summary>
		Comments,
		///<summary>EmailAddress. </summary>
		EmailAddress,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>ProductReviewID. </summary>
		ProductReviewID,
		///<summary>Rating. </summary>
		Rating,
		///<summary>ReviewDate. </summary>
		ReviewDate,
		///<summary>ReviewerName. </summary>
		ReviewerName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductSubcategory.</summary>
	public enum ProductSubcategoryFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ProductCategoryID. </summary>
		ProductCategoryID,
		///<summary>ProductSubcategoryID. </summary>
		ProductSubcategoryID,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PurchaseOrderHistory.</summary>
	public enum PurchaseOrderHistoryFieldIndex
	{
		///<summary>ActualCost. Inherited from TransactionHistory</summary>
		ActualCost,
		///<summary>ModifiedDate. Inherited from TransactionHistory</summary>
		ModifiedDate,
		///<summary>ProductID. Inherited from TransactionHistory</summary>
		ProductID,
		///<summary>Quantity. Inherited from TransactionHistory</summary>
		Quantity,
		///<summary>ReferenceOrderID. Inherited from TransactionHistory</summary>
		ReferenceOrderID,
		///<summary>ReferenceOrderLineID. Inherited from TransactionHistory</summary>
		ReferenceOrderLineID,
		///<summary>TransactionDate. Inherited from TransactionHistory</summary>
		TransactionDate,
		///<summary>TransactionID. Inherited from TransactionHistory</summary>
		TransactionID,
		///<summary>TransactionType. Inherited from TransactionHistory</summary>
		TransactionType,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesOrderHistory.</summary>
	public enum SalesOrderHistoryFieldIndex
	{
		///<summary>ActualCost. Inherited from TransactionHistory</summary>
		ActualCost,
		///<summary>ModifiedDate. Inherited from TransactionHistory</summary>
		ModifiedDate,
		///<summary>ProductID. Inherited from TransactionHistory</summary>
		ProductID,
		///<summary>Quantity. Inherited from TransactionHistory</summary>
		Quantity,
		///<summary>ReferenceOrderID. Inherited from TransactionHistory</summary>
		ReferenceOrderID,
		///<summary>ReferenceOrderLineID. Inherited from TransactionHistory</summary>
		ReferenceOrderLineID,
		///<summary>TransactionDate. Inherited from TransactionHistory</summary>
		TransactionDate,
		///<summary>TransactionID. Inherited from TransactionHistory</summary>
		TransactionID,
		///<summary>TransactionType. Inherited from TransactionHistory</summary>
		TransactionType,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ScrapReason.</summary>
	public enum ScrapReasonFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ScrapReasonID. </summary>
		ScrapReasonID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TransactionHistory.</summary>
	public enum TransactionHistoryFieldIndex
	{
		///<summary>ActualCost. </summary>
		ActualCost,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>ReferenceOrderID. </summary>
		ReferenceOrderID,
		///<summary>ReferenceOrderLineID. </summary>
		ReferenceOrderLineID,
		///<summary>TransactionDate. </summary>
		TransactionDate,
		///<summary>TransactionID. </summary>
		TransactionID,
		///<summary>TransactionType. </summary>
		TransactionType,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TransactionHistoryArchive.</summary>
	public enum TransactionHistoryArchiveFieldIndex
	{
		///<summary>ActualCost. </summary>
		ActualCost,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>ReferenceOrderID. </summary>
		ReferenceOrderID,
		///<summary>ReferenceOrderLineID. </summary>
		ReferenceOrderLineID,
		///<summary>TransactionDate. </summary>
		TransactionDate,
		///<summary>TransactionID. </summary>
		TransactionID,
		///<summary>TransactionType. </summary>
		TransactionType,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UnitMeasure.</summary>
	public enum UnitMeasureFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>UnitMeasureCode. </summary>
		UnitMeasureCode,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: WorkOrder.</summary>
	public enum WorkOrderFieldIndex
	{
		///<summary>DueDate. </summary>
		DueDate,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OrderQuantity. </summary>
		OrderQuantity,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>ScrappedQuantity. </summary>
		ScrappedQuantity,
		///<summary>ScrapReasonID. </summary>
		ScrapReasonID,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>StockedQuantity. </summary>
		StockedQuantity,
		///<summary>WorkOrderID. </summary>
		WorkOrderID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: WorkOrderHistory.</summary>
	public enum WorkOrderHistoryFieldIndex
	{
		///<summary>ActualCost. Inherited from TransactionHistory</summary>
		ActualCost,
		///<summary>ModifiedDate. Inherited from TransactionHistory</summary>
		ModifiedDate,
		///<summary>ProductID. Inherited from TransactionHistory</summary>
		ProductID,
		///<summary>Quantity. Inherited from TransactionHistory</summary>
		Quantity,
		///<summary>ReferenceOrderID. Inherited from TransactionHistory</summary>
		ReferenceOrderID,
		///<summary>ReferenceOrderLineID. Inherited from TransactionHistory</summary>
		ReferenceOrderLineID,
		///<summary>TransactionDate. Inherited from TransactionHistory</summary>
		TransactionDate,
		///<summary>TransactionID. Inherited from TransactionHistory</summary>
		TransactionID,
		///<summary>TransactionType. Inherited from TransactionHistory</summary>
		TransactionType,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: WorkOrderRouting.</summary>
	public enum WorkOrderRoutingFieldIndex
	{
		///<summary>ActualCost. </summary>
		ActualCost,
		///<summary>ActualEndDate. </summary>
		ActualEndDate,
		///<summary>ActualResourceHrs. </summary>
		ActualResourceHrs,
		///<summary>ActualStartDate. </summary>
		ActualStartDate,
		///<summary>LocationID. </summary>
		LocationID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OperationSequence. </summary>
		OperationSequence,
		///<summary>PlannedCost. </summary>
		PlannedCost,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>ScheduledEndDate. </summary>
		ScheduledEndDate,
		///<summary>ScheduledStartDate. </summary>
		ScheduledStartDate,
		///<summary>WorkOrderID. </summary>
		WorkOrderID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductVendor.</summary>
	public enum ProductVendorFieldIndex
	{
		///<summary>AverageLeadTime. </summary>
		AverageLeadTime,
		///<summary>LastReceiptCost. </summary>
		LastReceiptCost,
		///<summary>LastReceiptDate. </summary>
		LastReceiptDate,
		///<summary>MaxOrderQuantity. </summary>
		MaxOrderQuantity,
		///<summary>MinOrderQuantity. </summary>
		MinOrderQuantity,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OnOrderQuantity. </summary>
		OnOrderQuantity,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>StandardPrice. </summary>
		StandardPrice,
		///<summary>UnitMeasureCode. </summary>
		UnitMeasureCode,
		///<summary>VendorID. </summary>
		VendorID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PurchaseOrderDetail.</summary>
	public enum PurchaseOrderDetailFieldIndex
	{
		///<summary>DueDate. </summary>
		DueDate,
		///<summary>LineTotal. </summary>
		LineTotal,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OrderQuantity. </summary>
		OrderQuantity,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>PurchaseOrderDetailID. </summary>
		PurchaseOrderDetailID,
		///<summary>PurchaseOrderID. </summary>
		PurchaseOrderID,
		///<summary>ReceivedQuantity. </summary>
		ReceivedQuantity,
		///<summary>RejectedQuantity. </summary>
		RejectedQuantity,
		///<summary>StockedQuantity. </summary>
		StockedQuantity,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PurchaseOrderHeader.</summary>
	public enum PurchaseOrderHeaderFieldIndex
	{
		///<summary>EmployeeID. </summary>
		EmployeeID,
		///<summary>Freight. </summary>
		Freight,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OrderDate. </summary>
		OrderDate,
		///<summary>PurchaseOrderID. </summary>
		PurchaseOrderID,
		///<summary>RevisionNumber. </summary>
		RevisionNumber,
		///<summary>ShipDate. </summary>
		ShipDate,
		///<summary>ShipMethodID. </summary>
		ShipMethodID,
		///<summary>Status. </summary>
		Status,
		///<summary>SubTotal. </summary>
		SubTotal,
		///<summary>TaxAmt. </summary>
		TaxAmt,
		///<summary>TotalDue. </summary>
		TotalDue,
		///<summary>VendorID. </summary>
		VendorID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ShipMethod.</summary>
	public enum ShipMethodFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ShipBase. </summary>
		ShipBase,
		///<summary>ShipMethodID. </summary>
		ShipMethodID,
		///<summary>ShipRate. </summary>
		ShipRate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Vendor.</summary>
	public enum VendorFieldIndex
	{
		///<summary>AccountNumber. </summary>
		AccountNumber,
		///<summary>ActiveFlag. </summary>
		ActiveFlag,
		///<summary>CreditRating. </summary>
		CreditRating,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>PreferredVendorStatus. </summary>
		PreferredVendorStatus,
		///<summary>PurchasingWebServiceUrl. </summary>
		PurchasingWebServiceUrl,
		///<summary>VendorID. </summary>
		VendorID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: VendorAddress.</summary>
	public enum VendorAddressFieldIndex
	{
		///<summary>AddressID. </summary>
		AddressID,
		///<summary>AddressTypeID. </summary>
		AddressTypeID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>VendorID. </summary>
		VendorID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: VendorContact.</summary>
	public enum VendorContactFieldIndex
	{
		///<summary>ContactID. </summary>
		ContactID,
		///<summary>ContactTypeID. </summary>
		ContactTypeID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>VendorID. </summary>
		VendorID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ContactCreditCard.</summary>
	public enum ContactCreditCardFieldIndex
	{
		///<summary>ContactID. </summary>
		ContactID,
		///<summary>CreditCardID. </summary>
		CreditCardID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CountryRegionCurrency.</summary>
	public enum CountryRegionCurrencyFieldIndex
	{
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>CurrencyCode. </summary>
		CurrencyCode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CreditCard.</summary>
	public enum CreditCardFieldIndex
	{
		///<summary>CardNumber. </summary>
		CardNumber,
		///<summary>CardType. </summary>
		CardType,
		///<summary>CreditCardID. </summary>
		CreditCardID,
		///<summary>ExpMonth. </summary>
		ExpMonth,
		///<summary>ExpYear. </summary>
		ExpYear,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Currency.</summary>
	public enum CurrencyFieldIndex
	{
		///<summary>CurrencyCode. </summary>
		CurrencyCode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CurrencyRate.</summary>
	public enum CurrencyRateFieldIndex
	{
		///<summary>AverageRate. </summary>
		AverageRate,
		///<summary>CurrencyRateDate. </summary>
		CurrencyRateDate,
		///<summary>CurrencyRateID. </summary>
		CurrencyRateID,
		///<summary>EndOfDayRate. </summary>
		EndOfDayRate,
		///<summary>FromCurrencyCode. </summary>
		FromCurrencyCode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ToCurrencyCode. </summary>
		ToCurrencyCode,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Customer.</summary>
	public enum CustomerFieldIndex
	{
		///<summary>AccountNumber. </summary>
		AccountNumber,
		///<summary>CustomerID. </summary>
		CustomerID,
		///<summary>CustomerType. </summary>
		CustomerType,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>TerritoryID. </summary>
		TerritoryID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CustomerAddress.</summary>
	public enum CustomerAddressFieldIndex
	{
		///<summary>AddressID. </summary>
		AddressID,
		///<summary>AddressTypeID. </summary>
		AddressTypeID,
		///<summary>CustomerID. </summary>
		CustomerID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CustomerViewRelated.</summary>
	public enum CustomerViewRelatedFieldIndex
	{
		///<summary>AddressLine1. </summary>
		AddressLine1,
		///<summary>AddressLine2. </summary>
		AddressLine2,
		///<summary>AddressType. </summary>
		AddressType,
		///<summary>City. </summary>
		City,
		///<summary>CountryRegionName. </summary>
		CountryRegionName,
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>Demographics. </summary>
		Demographics,
		///<summary>EmailAddress. </summary>
		EmailAddress,
		///<summary>EmailPromotion. </summary>
		EmailPromotion,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>LastName. </summary>
		LastName,
		///<summary>MiddleName. </summary>
		MiddleName,
		///<summary>Phone. </summary>
		Phone,
		///<summary>PostalCode. </summary>
		PostalCode,
		///<summary>StateProvinceName. </summary>
		StateProvinceName,
		///<summary>Suffix. </summary>
		Suffix,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Individual.</summary>
	public enum IndividualFieldIndex
	{
		///<summary>AccountNumber. Inherited from Customer</summary>
		AccountNumber,
		///<summary>CustomerID. Inherited from Customer</summary>
		CustomerID_Customer,
		///<summary>CustomerType. Inherited from Customer</summary>
		CustomerType,
		///<summary>ModifiedDate. Inherited from Customer</summary>
		ModifiedDate,
		///<summary>Rowguid. Inherited from Customer</summary>
		Rowguid,
		///<summary>TerritoryID. Inherited from Customer</summary>
		TerritoryID,
		///<summary>CustomerID. </summary>
		CustomerID,
		///<summary>ContactID. </summary>
		ContactID,
		///<summary>Demographics. </summary>
		Demographics,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesOrderDetail.</summary>
	public enum SalesOrderDetailFieldIndex
	{
		///<summary>CarrierTrackingNumber. </summary>
		CarrierTrackingNumber,
		///<summary>LineTotal. </summary>
		LineTotal,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OrderQty. </summary>
		OrderQty,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesOrderDetailID. </summary>
		SalesOrderDetailID,
		///<summary>SalesOrderID. </summary>
		SalesOrderID,
		///<summary>SpecialOfferID. </summary>
		SpecialOfferID,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		///<summary>UnitPriceDiscount. </summary>
		UnitPriceDiscount,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesOrderHeader.</summary>
	public enum SalesOrderHeaderFieldIndex
	{
		///<summary>AccountNumber. </summary>
		AccountNumber,
		///<summary>BillToAddressID. </summary>
		BillToAddressID,
		///<summary>Comment. </summary>
		Comment,
		///<summary>ContactID. </summary>
		ContactID,
		///<summary>CreditCardApprovalCode. </summary>
		CreditCardApprovalCode,
		///<summary>CreditCardID. </summary>
		CreditCardID,
		///<summary>CurrencyRateID. </summary>
		CurrencyRateID,
		///<summary>CustomerID. </summary>
		CustomerID,
		///<summary>DueDate. </summary>
		DueDate,
		///<summary>Freight. </summary>
		Freight,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OnlineOrderFlag. </summary>
		OnlineOrderFlag,
		///<summary>OrderDate. </summary>
		OrderDate,
		///<summary>PurchaseOrderNumber. </summary>
		PurchaseOrderNumber,
		///<summary>RevisionNumber. </summary>
		RevisionNumber,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesOrderID. </summary>
		SalesOrderID,
		///<summary>SalesOrderNumber. </summary>
		SalesOrderNumber,
		///<summary>SalesPersonID. </summary>
		SalesPersonID,
		///<summary>ShipDate. </summary>
		ShipDate,
		///<summary>ShipMethodID. </summary>
		ShipMethodID,
		///<summary>ShipToAddressID. </summary>
		ShipToAddressID,
		///<summary>Status. </summary>
		Status,
		///<summary>SubTotal. </summary>
		SubTotal,
		///<summary>TaxAmt. </summary>
		TaxAmt,
		///<summary>TerritoryID. </summary>
		TerritoryID,
		///<summary>TotalDue. </summary>
		TotalDue,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesOrderHeaderSalesReason.</summary>
	public enum SalesOrderHeaderSalesReasonFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>SalesOrderID. </summary>
		SalesOrderID,
		///<summary>SalesReasonID. </summary>
		SalesReasonID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesPerson.</summary>
	public enum SalesPersonFieldIndex
	{
		///<summary>BirthDate. Inherited from Employee</summary>
		BirthDate,
		///<summary>ContactID. Inherited from Employee</summary>
		ContactID,
		///<summary>CurrentFlag. Inherited from Employee</summary>
		CurrentFlag,
		///<summary>EmployeeID. Inherited from Employee</summary>
		EmployeeID_Employee,
		///<summary>Gender. Inherited from Employee</summary>
		Gender,
		///<summary>HireDate. Inherited from Employee</summary>
		HireDate,
		///<summary>LoginID. Inherited from Employee</summary>
		LoginID,
		///<summary>ManagerID. Inherited from Employee</summary>
		ManagerID,
		///<summary>MaritalStatus. Inherited from Employee</summary>
		MaritalStatus,
		///<summary>ModifiedDate. Inherited from Employee</summary>
		ModifiedDate,
		///<summary>NationalIdnumber. Inherited from Employee</summary>
		NationalIdnumber,
		///<summary>Rowguid. Inherited from Employee</summary>
		Rowguid,
		///<summary>SalariedFlag. Inherited from Employee</summary>
		SalariedFlag,
		///<summary>SickLeaveHours. Inherited from Employee</summary>
		SickLeaveHours,
		///<summary>Title. Inherited from Employee</summary>
		Title,
		///<summary>VacationHours. Inherited from Employee</summary>
		VacationHours,
		///<summary>EmployeeID. </summary>
		EmployeeID,
		///<summary>Bonus. </summary>
		Bonus,
		///<summary>CommissionPct. </summary>
		CommissionPct,
		///<summary>SalesLastYear. </summary>
		SalesLastYear,
		///<summary>SalesQuota. </summary>
		SalesQuota,
		///<summary>SalesYtd. </summary>
		SalesYtd,
		///<summary>TerritoryID. </summary>
		TerritoryID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesPersonQuotaHistory.</summary>
	public enum SalesPersonQuotaHistoryFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>QuotaDate. </summary>
		QuotaDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesPersonID. </summary>
		SalesPersonID,
		///<summary>SalesQuota. </summary>
		SalesQuota,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesReason.</summary>
	public enum SalesReasonFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ReasonType. </summary>
		ReasonType,
		///<summary>SalesReasonID. </summary>
		SalesReasonID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesTaxRate.</summary>
	public enum SalesTaxRateFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesTaxRateID. </summary>
		SalesTaxRateID,
		///<summary>StateProvinceID. </summary>
		StateProvinceID,
		///<summary>TaxRate. </summary>
		TaxRate,
		///<summary>TaxType. </summary>
		TaxType,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesTerritory.</summary>
	public enum SalesTerritoryFieldIndex
	{
		///<summary>CostLastYear. </summary>
		CostLastYear,
		///<summary>CostYtd. </summary>
		CostYtd,
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>Group. </summary>
		Group,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesLastYear. </summary>
		SalesLastYear,
		///<summary>SalesYtd. </summary>
		SalesYtd,
		///<summary>TerritoryID. </summary>
		TerritoryID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesTerritoryHistory.</summary>
	public enum SalesTerritoryHistoryFieldIndex
	{
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesPersonID. </summary>
		SalesPersonID,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>TerritoryID. </summary>
		TerritoryID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ShoppingCartItem.</summary>
	public enum ShoppingCartItemFieldIndex
	{
		///<summary>DateCreated. </summary>
		DateCreated,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>ShoppingCartID. </summary>
		ShoppingCartID,
		///<summary>ShoppingCartItemID. </summary>
		ShoppingCartItemID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SpecialOffer.</summary>
	public enum SpecialOfferFieldIndex
	{
		///<summary>Category. </summary>
		Category,
		///<summary>Description. </summary>
		Description,
		///<summary>DiscountPct. </summary>
		DiscountPct,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>MaxQty. </summary>
		MaxQty,
		///<summary>MinQty. </summary>
		MinQty,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SpecialOfferID. </summary>
		SpecialOfferID,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>Type. </summary>
		Type,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SpecialOfferProduct.</summary>
	public enum SpecialOfferProductFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductID. </summary>
		ProductID,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SpecialOfferID. </summary>
		SpecialOfferID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Store.</summary>
	public enum StoreFieldIndex
	{
		///<summary>AccountNumber. Inherited from Customer</summary>
		AccountNumber,
		///<summary>CustomerID. Inherited from Customer</summary>
		CustomerID_Customer,
		///<summary>CustomerType. Inherited from Customer</summary>
		CustomerType,
		///<summary>ModifiedDate. Inherited from Customer</summary>
		ModifiedDate,
		///<summary>Rowguid. Inherited from Customer</summary>
		Rowguid,
		///<summary>TerritoryID. Inherited from Customer</summary>
		TerritoryID,
		///<summary>CustomerID. </summary>
		CustomerID,
		///<summary>Demographics. </summary>
		Demographics,
		///<summary>Name. </summary>
		Name,
		///<summary>SalesPersonID. </summary>
		SalesPersonID,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: StoreContact.</summary>
	public enum StoreContactFieldIndex
	{
		///<summary>ContactID. </summary>
		ContactID,
		///<summary>ContactTypeID. </summary>
		ContactTypeID,
		///<summary>CustomerID. </summary>
		CustomerID,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}

	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : CustomerView.</summary>
	public enum CustomerViewFieldIndex
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

	/// <summary>Index enum to fast-access TypedList Fields in the Columns collection of the Typed List: CustomerList</summary>
	public enum CustomerListTypedListFieldIndex
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

	/// <summary>Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.</summary>
	public enum EntityType
	{
		///<summary>AwbuildVersion</summary>
		AwbuildVersionEntity,
		///<summary>DatabaseLog</summary>
		DatabaseLogEntity,
		///<summary>ErrorLog</summary>
		ErrorLogEntity,
		///<summary>Department</summary>
		DepartmentEntity,
		///<summary>Employee</summary>
		EmployeeEntity,
		///<summary>EmployeeAddress</summary>
		EmployeeAddressEntity,
		///<summary>EmployeeDepartmentHistory</summary>
		EmployeeDepartmentHistoryEntity,
		///<summary>EmployeePayHistory</summary>
		EmployeePayHistoryEntity,
		///<summary>JobCandidate</summary>
		JobCandidateEntity,
		///<summary>Shift</summary>
		ShiftEntity,
		///<summary>Address</summary>
		AddressEntity,
		///<summary>AddressType</summary>
		AddressTypeEntity,
		///<summary>Contact</summary>
		ContactEntity,
		///<summary>ContactType</summary>
		ContactTypeEntity,
		///<summary>CountryRegion</summary>
		CountryRegionEntity,
		///<summary>StateProvince</summary>
		StateProvinceEntity,
		///<summary>BillOfMaterial</summary>
		BillOfMaterialEntity,
		///<summary>Culture</summary>
		CultureEntity,
		///<summary>Document</summary>
		DocumentEntity,
		///<summary>Illustration</summary>
		IllustrationEntity,
		///<summary>Location</summary>
		LocationEntity,
		///<summary>Product</summary>
		ProductEntity,
		///<summary>ProductCategory</summary>
		ProductCategoryEntity,
		///<summary>ProductCostHistory</summary>
		ProductCostHistoryEntity,
		///<summary>ProductDescription</summary>
		ProductDescriptionEntity,
		///<summary>ProductDocument</summary>
		ProductDocumentEntity,
		///<summary>ProductInventory</summary>
		ProductInventoryEntity,
		///<summary>ProductListPriceHistory</summary>
		ProductListPriceHistoryEntity,
		///<summary>ProductModel</summary>
		ProductModelEntity,
		///<summary>ProductModelIllustration</summary>
		ProductModelIllustrationEntity,
		///<summary>ProductModelProductDescriptionCulture</summary>
		ProductModelProductDescriptionCultureEntity,
		///<summary>ProductPhoto</summary>
		ProductPhotoEntity,
		///<summary>ProductProductPhoto</summary>
		ProductProductPhotoEntity,
		///<summary>ProductReview</summary>
		ProductReviewEntity,
		///<summary>ProductSubcategory</summary>
		ProductSubcategoryEntity,
		///<summary>PurchaseOrderHistory</summary>
		PurchaseOrderHistoryEntity,
		///<summary>SalesOrderHistory</summary>
		SalesOrderHistoryEntity,
		///<summary>ScrapReason</summary>
		ScrapReasonEntity,
		///<summary>TransactionHistory</summary>
		TransactionHistoryEntity,
		///<summary>TransactionHistoryArchive</summary>
		TransactionHistoryArchiveEntity,
		///<summary>UnitMeasure</summary>
		UnitMeasureEntity,
		///<summary>WorkOrder</summary>
		WorkOrderEntity,
		///<summary>WorkOrderHistory</summary>
		WorkOrderHistoryEntity,
		///<summary>WorkOrderRouting</summary>
		WorkOrderRoutingEntity,
		///<summary>ProductVendor</summary>
		ProductVendorEntity,
		///<summary>PurchaseOrderDetail</summary>
		PurchaseOrderDetailEntity,
		///<summary>PurchaseOrderHeader</summary>
		PurchaseOrderHeaderEntity,
		///<summary>ShipMethod</summary>
		ShipMethodEntity,
		///<summary>Vendor</summary>
		VendorEntity,
		///<summary>VendorAddress</summary>
		VendorAddressEntity,
		///<summary>VendorContact</summary>
		VendorContactEntity,
		///<summary>ContactCreditCard</summary>
		ContactCreditCardEntity,
		///<summary>CountryRegionCurrency</summary>
		CountryRegionCurrencyEntity,
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
		///<summary>Individual</summary>
		IndividualEntity,
		///<summary>SalesOrderDetail</summary>
		SalesOrderDetailEntity,
		///<summary>SalesOrderHeader</summary>
		SalesOrderHeaderEntity,
		///<summary>SalesOrderHeaderSalesReason</summary>
		SalesOrderHeaderSalesReasonEntity,
		///<summary>SalesPerson</summary>
		SalesPersonEntity,
		///<summary>SalesPersonQuotaHistory</summary>
		SalesPersonQuotaHistoryEntity,
		///<summary>SalesReason</summary>
		SalesReasonEntity,
		///<summary>SalesTaxRate</summary>
		SalesTaxRateEntity,
		///<summary>SalesTerritory</summary>
		SalesTerritoryEntity,
		///<summary>SalesTerritoryHistory</summary>
		SalesTerritoryHistoryEntity,
		///<summary>ShoppingCartItem</summary>
		ShoppingCartItemEntity,
		///<summary>SpecialOffer</summary>
		SpecialOfferEntity,
		///<summary>SpecialOfferProduct</summary>
		SpecialOfferProductEntity,
		///<summary>Store</summary>
		StoreEntity,
		///<summary>StoreContact</summary>
		StoreContactEntity
	}

	/// <summary>Enum definition for all the typed view types defined in this namespace. Used by the entityfields factory.</summary>
	public enum TypedViewType
	{
		///<summary>CustomerView</summary>
		CustomerViewTypedView
	}

	#region Custom ConstantsEnums Code
	
  // __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants

  public enum ContactType
  {
    AccountingManager = 1,
    AssistantSalesAgent = 2,
    AssistantSalesRepresentative = 3,
    CoordinatorForeignMarkets = 4,
    ExportAdministrator = 5,
    InternationalMarketingManager = 6,
    MarketingAssistant = 7,
    MarketingManager = 8,
    MarketingRepresentative = 9,
    OrderAdministrator = 10,
    Owner = 11,
    OwnerMarketingAssistant = 12,
    ProductManager = 13,
    PurchasingAgent = 14,
    PurchasingManager = 15,
    RegionalAccountRepresentative = 16,
    SalesAgent = 17,
    SalesAssociate = 18,
    SalesManager = 19,
    SalesRepresentative = 20,
  }

  [TypeConverter(typeof(EnumerationConverter))]
  public enum AddressType
  {
    Billing = 1,
    Home = 2,
    [System.ComponentModel.Description("Main Office")]
// ReSharper disable once InconsistentNaming
    Main_Office = 3,
    Primary = 4,
    Shipping = 5,
    Archive = 6
  };

  public enum OrderStatus
  {
    [System.ComponentModel.Description("In process")]
// ReSharper disable InconsistentNaming
    In_process = 1,
// ReSharper restore InconsistentNaming
    Approved,
    Backordered,
    Rejected,
    Shipped,
    Cancelled
  }

  public enum OrderPlacesBy
  {
    SalesPerson,
    Customer
  }

  public enum MaritalStatus
  {
    [System.ComponentModel.Description("Married")]
    M,
    [System.ComponentModel.Description("Single")]
    S
  }

  public enum Gender
  {
    [System.ComponentModel.Description("Male")]
    M,
    [System.ComponentModel.Description("Female")]
    F
  }

  public enum Current
  {
    Inactive,
    Active
  }

  public enum PayFrequency
  {
    Monthly = 1,
    BiWeekly
  }

  public enum NameStyle
  {
    FirstLast,
    LastFirst
  }

  public enum EmailPromotion
  {
    None,
    AWOnly,
    AWAndPartners
  }

  public enum StateProvinceCodeExistence
  {
    Exists,
    Unavailable
  }

  public enum ProductMaintenanceDocumentStatus
  {
    PendingApproval = 1, 
    Approved, 
    Obsolete
  }

  public enum ProductMake
  {
    Purchased,
    InHouse
  }

  public enum ProductFinished
  {
    Salable,
    NotSalable
  }

  public enum PurchaseOrderStatus
  {
    Pending = 1,
    Approved,
    Rejected,
    Complete,
  }

  public enum CreditRating
  {
    Superior = 1,
    Excellent,
    AboveAverage,
    Average,
    BelowAverage,
  }

  public enum TaxApplication
  {
    Retail = 1,
    Wholesale,
    All,
  }

  // __LLBLGENPRO_USER_CODE_REGION_END
	#endregion

	#region Included code

	#endregion
}

