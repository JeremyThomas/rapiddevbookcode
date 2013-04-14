///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using AW.Data;
using AW.Data.HelperClasses;
using AW.Data.DaoClasses;
using AW.Data.EntityClasses;
using AW.Data.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;


namespace AW.Data.TypedViewClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Typed datatable for the view 'CustomerView'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class CustomerViewTypedView : TypedViewBase<CustomerViewRow>, ITypedView
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnCustomerId;
		private DataColumn _columnTitle;
		private DataColumn _columnFirstName;
		private DataColumn _columnMiddleName;
		private DataColumn _columnLastName;
		private DataColumn _columnSuffix;
		private DataColumn _columnPhone;
		private DataColumn _columnEmailAddress;
		private DataColumn _columnEmailPromotion;
		private DataColumn _columnAddressType;
		private DataColumn _columnAddressLine1;
		private DataColumn _columnAddressLine2;
		private DataColumn _columnCity;
		private DataColumn _columnStateProvinceName;
		private DataColumn _columnPostalCode;
		private DataColumn _columnCountryRegionName;
		private DataColumn _columnDemographics;
		
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		/// <summary>
		/// The amount of fields in the resultset.
		/// </summary>
		private const int AmountOfFields = 17;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static CustomerViewTypedView()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CustomerViewTypedView():base("CustomerView")
		{
			InitClass();
		}
		
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CustomerViewTypedView(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}

		/// <summary> Fills itself with data. it builds a dynamic query and loads itself with that query. 
		/// Will use no sort filter, no select filter, will allow duplicate rows and will not limit the amount of rows returned</summary>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill()
		{
			return Fill(0, null, true, null, null, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query. Will not use a filter, will allow duplicate rows.</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, true, null, null, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query. Will not use a filter.</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, null, null, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, null, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		/// used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, transactionToUse, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		/// used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <param name="groupByClause">GroupByCollection with fields to group by on.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse, 	IGroupByCollection groupByClause)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, transactionToUse, groupByClause, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <param name="groupByClause">GroupByCollection with fields to group by on.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public virtual bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse, 
								 IGroupByCollection groupByClause, int pageNumber, int pageSize)
		{
			IEntityFields fieldsInResultset = GetFields();
			// __LLBLGENPRO_USER_CODE_REGION_START AdditionalFields
			// be sure to call fieldsInResultset.Expand(number of new fields) first. 
			// __LLBLGENPRO_USER_CODE_REGION_END
			return DAOFactory.CreateTypedListDAO().GetMultiAsDataTable(fieldsInResultset, this, maxNumberOfItemsToReturn, sortClauses, selectFilter, null, allowDuplicates, groupByClause, transactionToUse, pageNumber, pageSize);
		}

		/// <summary>Gets the fields of this typed view</summary>
		/// <returns>IEntityFields object</returns>
		public virtual IEntityFields GetFields()
		{
			return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.CustomerViewTypedView);
		}
		
		/// <summary>Gets the amount of rows in the database for this typed view, not skipping duplicates</summary>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public int GetDbCount()
		{
			return GetDbCount(true, null);
		}
		
		/// <summary>Gets the amount of rows in the database for this typed view.</summary>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public int GetDbCount(bool allowDuplicates)
		{
			return GetDbCount(allowDuplicates, null);
		}
		
		/// <summary>Gets the amount of rows in the database for this typed list.</summary>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="filter">The filter to apply for the count retrieval</param>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public int GetDbCount(bool allowDuplicates, IPredicateExpression filter)
		{
			return GetDbCount(allowDuplicates, filter, null);
		}

		/// <summary>Gets the amount of rows in the database for this typed list.</summary>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="filter">The filter to apply for the count retrieval</param>
		/// <param name="groupByClause">group by clause to embed in the query</param>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public virtual int GetDbCount(bool allowDuplicates, IPredicateExpression filter, GroupByCollection groupByClause)
		{
			IEntityFields fieldsInResultset = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.CustomerViewTypedView);
			return DAOFactory.CreateTypedListDAO().GetDbCount(fieldsInResultset, null, filter, null, groupByClause, allowDuplicates);
		}

		/// <summary>Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.</summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new CustomerViewRow(rowBuilder);
		}

		/// <summary>Initializes the hashtables for the typed view type and typed view field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();
			Hashtable fieldHashtable;
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MiddleName", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Suffix", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Phone", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("EmailAddress", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("EmailPromotion", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AddressType", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AddressLine1", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AddressLine2", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("StateProvinceName", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("PostalCode", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("CountryRegionName", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Demographics", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		protected override void InitClass()
		{
			TableName = "CustomerView";		
			_columnCustomerId = GeneralUtils.CreateTypedDataTableColumn("CustomerId", @"CustomerId", typeof(System.Int32), this.Columns);
			_columnTitle = GeneralUtils.CreateTypedDataTableColumn("Title", @"Title", typeof(System.String), this.Columns);
			_columnFirstName = GeneralUtils.CreateTypedDataTableColumn("FirstName", @"FirstName", typeof(System.String), this.Columns);
			_columnMiddleName = GeneralUtils.CreateTypedDataTableColumn("MiddleName", @"MiddleName", typeof(System.String), this.Columns);
			_columnLastName = GeneralUtils.CreateTypedDataTableColumn("LastName", @"LastName", typeof(System.String), this.Columns);
			_columnSuffix = GeneralUtils.CreateTypedDataTableColumn("Suffix", @"Suffix", typeof(System.String), this.Columns);
			_columnPhone = GeneralUtils.CreateTypedDataTableColumn("Phone", @"Phone", typeof(System.String), this.Columns);
			_columnEmailAddress = GeneralUtils.CreateTypedDataTableColumn("EmailAddress", @"EmailAddress", typeof(System.String), this.Columns);
			_columnEmailPromotion = GeneralUtils.CreateTypedDataTableColumn("EmailPromotion", @"EmailPromotion", typeof(System.Int32), this.Columns);
			_columnAddressType = GeneralUtils.CreateTypedDataTableColumn("AddressType", @"AddressType", typeof(System.String), this.Columns);
			_columnAddressLine1 = GeneralUtils.CreateTypedDataTableColumn("AddressLine1", @"AddressLine1", typeof(System.String), this.Columns);
			_columnAddressLine2 = GeneralUtils.CreateTypedDataTableColumn("AddressLine2", @"AddressLine2", typeof(System.String), this.Columns);
			_columnCity = GeneralUtils.CreateTypedDataTableColumn("City", @"City", typeof(System.String), this.Columns);
			_columnStateProvinceName = GeneralUtils.CreateTypedDataTableColumn("StateProvinceName", @"StateProvinceName", typeof(System.String), this.Columns);
			_columnPostalCode = GeneralUtils.CreateTypedDataTableColumn("PostalCode", @"PostalCode", typeof(System.String), this.Columns);
			_columnCountryRegionName = GeneralUtils.CreateTypedDataTableColumn("CountryRegionName", @"CountryRegionName", typeof(System.String), this.Columns);
			_columnDemographics = GeneralUtils.CreateTypedDataTableColumn("Demographics", @"Demographics", typeof(System.String), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnCustomerId = this.Columns["CustomerId"];
			_columnTitle = this.Columns["Title"];
			_columnFirstName = this.Columns["FirstName"];
			_columnMiddleName = this.Columns["MiddleName"];
			_columnLastName = this.Columns["LastName"];
			_columnSuffix = this.Columns["Suffix"];
			_columnPhone = this.Columns["Phone"];
			_columnEmailAddress = this.Columns["EmailAddress"];
			_columnEmailPromotion = this.Columns["EmailPromotion"];
			_columnAddressType = this.Columns["AddressType"];
			_columnAddressLine1 = this.Columns["AddressLine1"];
			_columnAddressLine2 = this.Columns["AddressLine2"];
			_columnCity = this.Columns["City"];
			_columnStateProvinceName = this.Columns["StateProvinceName"];
			_columnPostalCode = this.Columns["PostalCode"];
			_columnCountryRegionName = this.Columns["CountryRegionName"];
			_columnDemographics = this.Columns["Demographics"];
			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			CustomerViewTypedView cloneToReturn = ((CustomerViewTypedView)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new CustomerViewTypedView();
		}
#endif

		#region Class Property Declarations
		/// <summary>The custom properties for this TypedView type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary>The custom properties for the type of this TypedView instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[System.ComponentModel.Browsable(false)]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return CustomerViewTypedView.CustomProperties;}
		}

		/// <summary>The custom properties for the fields of this TypedView type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary>The custom properties for the fields of the type of this TypedView instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[System.ComponentModel.Browsable(false)]
		public virtual Hashtable FieldsCustomPropertiesOfType
		{
			get { return CustomerViewTypedView.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedView field CustomerId</summary>
		internal DataColumn CustomerIdColumn 
		{
			get { return _columnCustomerId; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Title</summary>
		internal DataColumn TitleColumn 
		{
			get { return _columnTitle; }
		}

		/// <summary>Returns the column object belonging to the TypedView field FirstName</summary>
		internal DataColumn FirstNameColumn 
		{
			get { return _columnFirstName; }
		}

		/// <summary>Returns the column object belonging to the TypedView field MiddleName</summary>
		internal DataColumn MiddleNameColumn 
		{
			get { return _columnMiddleName; }
		}

		/// <summary>Returns the column object belonging to the TypedView field LastName</summary>
		internal DataColumn LastNameColumn 
		{
			get { return _columnLastName; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Suffix</summary>
		internal DataColumn SuffixColumn 
		{
			get { return _columnSuffix; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Phone</summary>
		internal DataColumn PhoneColumn 
		{
			get { return _columnPhone; }
		}

		/// <summary>Returns the column object belonging to the TypedView field EmailAddress</summary>
		internal DataColumn EmailAddressColumn 
		{
			get { return _columnEmailAddress; }
		}

		/// <summary>Returns the column object belonging to the TypedView field EmailPromotion</summary>
		internal DataColumn EmailPromotionColumn 
		{
			get { return _columnEmailPromotion; }
		}

		/// <summary>Returns the column object belonging to the TypedView field AddressType</summary>
		internal DataColumn AddressTypeColumn 
		{
			get { return _columnAddressType; }
		}

		/// <summary>Returns the column object belonging to the TypedView field AddressLine1</summary>
		internal DataColumn AddressLine1Column 
		{
			get { return _columnAddressLine1; }
		}

		/// <summary>Returns the column object belonging to the TypedView field AddressLine2</summary>
		internal DataColumn AddressLine2Column 
		{
			get { return _columnAddressLine2; }
		}

		/// <summary>Returns the column object belonging to the TypedView field City</summary>
		internal DataColumn CityColumn 
		{
			get { return _columnCity; }
		}

		/// <summary>Returns the column object belonging to the TypedView field StateProvinceName</summary>
		internal DataColumn StateProvinceNameColumn 
		{
			get { return _columnStateProvinceName; }
		}

		/// <summary>Returns the column object belonging to the TypedView field PostalCode</summary>
		internal DataColumn PostalCodeColumn 
		{
			get { return _columnPostalCode; }
		}

		/// <summary>Returns the column object belonging to the TypedView field CountryRegionName</summary>
		internal DataColumn CountryRegionNameColumn 
		{
			get { return _columnCountryRegionName; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Demographics</summary>
		internal DataColumn DemographicsColumn 
		{
			get { return _columnDemographics; }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalColumnProperties
		// __LLBLGENPRO_USER_CODE_REGION_END
 		#endregion
		
		#region Custom Typed View code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}


	/// <summary>Typed datarow for the typed datatable CustomerView</summary>
	public partial class CustomerViewRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private CustomerViewTypedView	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal CustomerViewRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((CustomerViewTypedView)(this.Table));
		}

		#region Class Property Declarations

		/// <summary>Gets / sets the value of the TypedView field CustomerId<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."CustomerID"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 CustomerId 
		{
			get { return IsCustomerIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.CustomerIdColumn]; }
			set { this[_parent.CustomerIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field CustomerId is NULL, false otherwise.</summary>
		public bool IsCustomerIdNull() 
		{
			return IsNull(_parent.CustomerIdColumn);
		}

		/// <summary>Sets the TypedView field CustomerId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCustomerIdNull() 
		{
			this[_parent.CustomerIdColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Title<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."Title"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 8</remarks>
		public System.String Title 
		{
			get { return IsTitleNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.TitleColumn]; }
			set { this[_parent.TitleColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Title is NULL, false otherwise.</summary>
		public bool IsTitleNull() 
		{
			return IsNull(_parent.TitleColumn);
		}

		/// <summary>Sets the TypedView field Title to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetTitleNull() 
		{
			this[_parent.TitleColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field FirstName<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."FirstName"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 50</remarks>
		public System.String FirstName 
		{
			get { return IsFirstNameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.FirstNameColumn]; }
			set { this[_parent.FirstNameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field FirstName is NULL, false otherwise.</summary>
		public bool IsFirstNameNull() 
		{
			return IsNull(_parent.FirstNameColumn);
		}

		/// <summary>Sets the TypedView field FirstName to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFirstNameNull() 
		{
			this[_parent.FirstNameColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field MiddleName<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."MiddleName"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 50</remarks>
		public System.String MiddleName 
		{
			get { return IsMiddleNameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.MiddleNameColumn]; }
			set { this[_parent.MiddleNameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field MiddleName is NULL, false otherwise.</summary>
		public bool IsMiddleNameNull() 
		{
			return IsNull(_parent.MiddleNameColumn);
		}

		/// <summary>Sets the TypedView field MiddleName to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMiddleNameNull() 
		{
			this[_parent.MiddleNameColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field LastName<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."LastName"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 50</remarks>
		public System.String LastName 
		{
			get { return IsLastNameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.LastNameColumn]; }
			set { this[_parent.LastNameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field LastName is NULL, false otherwise.</summary>
		public bool IsLastNameNull() 
		{
			return IsNull(_parent.LastNameColumn);
		}

		/// <summary>Sets the TypedView field LastName to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetLastNameNull() 
		{
			this[_parent.LastNameColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Suffix<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."Suffix"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 10</remarks>
		public System.String Suffix 
		{
			get { return IsSuffixNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.SuffixColumn]; }
			set { this[_parent.SuffixColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Suffix is NULL, false otherwise.</summary>
		public bool IsSuffixNull() 
		{
			return IsNull(_parent.SuffixColumn);
		}

		/// <summary>Sets the TypedView field Suffix to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetSuffixNull() 
		{
			this[_parent.SuffixColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Phone<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."Phone"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 25</remarks>
		public System.String Phone 
		{
			get { return IsPhoneNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.PhoneColumn]; }
			set { this[_parent.PhoneColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Phone is NULL, false otherwise.</summary>
		public bool IsPhoneNull() 
		{
			return IsNull(_parent.PhoneColumn);
		}

		/// <summary>Sets the TypedView field Phone to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetPhoneNull() 
		{
			this[_parent.PhoneColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field EmailAddress<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."EmailAddress"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 50</remarks>
		public System.String EmailAddress 
		{
			get { return IsEmailAddressNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.EmailAddressColumn]; }
			set { this[_parent.EmailAddressColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field EmailAddress is NULL, false otherwise.</summary>
		public bool IsEmailAddressNull() 
		{
			return IsNull(_parent.EmailAddressColumn);
		}

		/// <summary>Sets the TypedView field EmailAddress to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetEmailAddressNull() 
		{
			this[_parent.EmailAddressColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field EmailPromotion<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."EmailPromotion"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 EmailPromotion 
		{
			get { return IsEmailPromotionNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.EmailPromotionColumn]; }
			set { this[_parent.EmailPromotionColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field EmailPromotion is NULL, false otherwise.</summary>
		public bool IsEmailPromotionNull() 
		{
			return IsNull(_parent.EmailPromotionColumn);
		}

		/// <summary>Sets the TypedView field EmailPromotion to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetEmailPromotionNull() 
		{
			this[_parent.EmailPromotionColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field AddressType<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."AddressType"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 50</remarks>
		public System.String AddressType 
		{
			get { return IsAddressTypeNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AddressTypeColumn]; }
			set { this[_parent.AddressTypeColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field AddressType is NULL, false otherwise.</summary>
		public bool IsAddressTypeNull() 
		{
			return IsNull(_parent.AddressTypeColumn);
		}

		/// <summary>Sets the TypedView field AddressType to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAddressTypeNull() 
		{
			this[_parent.AddressTypeColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field AddressLine1<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."AddressLine1"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 60</remarks>
		public System.String AddressLine1 
		{
			get { return IsAddressLine1Null() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AddressLine1Column]; }
			set { this[_parent.AddressLine1Column] = value; }
		}

		/// <summary>Returns true if the TypedView field AddressLine1 is NULL, false otherwise.</summary>
		public bool IsAddressLine1Null() 
		{
			return IsNull(_parent.AddressLine1Column);
		}

		/// <summary>Sets the TypedView field AddressLine1 to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAddressLine1Null() 
		{
			this[_parent.AddressLine1Column] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field AddressLine2<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."AddressLine2"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 60</remarks>
		public System.String AddressLine2 
		{
			get { return IsAddressLine2Null() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AddressLine2Column]; }
			set { this[_parent.AddressLine2Column] = value; }
		}

		/// <summary>Returns true if the TypedView field AddressLine2 is NULL, false otherwise.</summary>
		public bool IsAddressLine2Null() 
		{
			return IsNull(_parent.AddressLine2Column);
		}

		/// <summary>Sets the TypedView field AddressLine2 to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAddressLine2Null() 
		{
			this[_parent.AddressLine2Column] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field City<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."City"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 30</remarks>
		public System.String City 
		{
			get { return IsCityNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CityColumn]; }
			set { this[_parent.CityColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field City is NULL, false otherwise.</summary>
		public bool IsCityNull() 
		{
			return IsNull(_parent.CityColumn);
		}

		/// <summary>Sets the TypedView field City to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCityNull() 
		{
			this[_parent.CityColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field StateProvinceName<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."StateProvinceName"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 50</remarks>
		public System.String StateProvinceName 
		{
			get { return IsStateProvinceNameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.StateProvinceNameColumn]; }
			set { this[_parent.StateProvinceNameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field StateProvinceName is NULL, false otherwise.</summary>
		public bool IsStateProvinceNameNull() 
		{
			return IsNull(_parent.StateProvinceNameColumn);
		}

		/// <summary>Sets the TypedView field StateProvinceName to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetStateProvinceNameNull() 
		{
			this[_parent.StateProvinceNameColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field PostalCode<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."PostalCode"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 15</remarks>
		public System.String PostalCode 
		{
			get { return IsPostalCodeNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.PostalCodeColumn]; }
			set { this[_parent.PostalCodeColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field PostalCode is NULL, false otherwise.</summary>
		public bool IsPostalCodeNull() 
		{
			return IsNull(_parent.PostalCodeColumn);
		}

		/// <summary>Sets the TypedView field PostalCode to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetPostalCodeNull() 
		{
			this[_parent.PostalCodeColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field CountryRegionName<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."CountryRegionName"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 50</remarks>
		public System.String CountryRegionName 
		{
			get { return IsCountryRegionNameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CountryRegionNameColumn]; }
			set { this[_parent.CountryRegionNameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field CountryRegionName is NULL, false otherwise.</summary>
		public bool IsCountryRegionNameNull() 
		{
			return IsNull(_parent.CountryRegionNameColumn);
		}

		/// <summary>Sets the TypedView field CountryRegionName to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCountryRegionNameNull() 
		{
			this[_parent.CountryRegionNameColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Demographics<br/><br/></summary>
		/// <remarks>Mapped on view field: "vIndividualCustomer"."Demographics"<br/>
		/// View field characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647</remarks>
		public System.String Demographics 
		{
			get { return IsDemographicsNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.DemographicsColumn]; }
			set { this[_parent.DemographicsColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Demographics is NULL, false otherwise.</summary>
		public bool IsDemographicsNull() 
		{
			return IsNull(_parent.DemographicsColumn);
		}

		/// <summary>Sets the TypedView field Demographics to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDemographicsNull() 
		{
			this[_parent.DemographicsColumn] = System.Convert.DBNull;
		}
		#endregion
		
		#region Custom Typed View Row Code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Row Code

		#endregion		
	}
}
