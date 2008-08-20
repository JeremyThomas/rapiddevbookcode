///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Sunday, November 06, 2005 1:19:31 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;

using AW.Data.FactoryClasses;
using AW.Data.CollectionClasses;
using AW.Data.DaoClasses;
using AW.Data.RelationClasses;
using AW.Data.ValidatorClasses;
using AW.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Data.EntityClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	/// <summary>
	/// Entity class which represents the entity 'SalesOrderHeader'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class SalesOrderHeaderEntity : SalesOrderHeaderEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
        public SalesOrderHeaderEntity():base(
            new PropertyDescriptorFactory(), new SalesOrderHeaderEntityFactory())
        {
            EntityValidators.SalesOrderHeaderEntityValidator val =
                new AW.Data.EntityValidators.SalesOrderHeaderEntityValidator();
            this.EntityValidatorToUse = val;
        }

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderId):
			base(salesOrderId)
		{
            EntityValidators.SalesOrderHeaderEntityValidator val =
    new AW.Data.EntityValidators.SalesOrderHeaderEntityValidator();
            this.EntityValidatorToUse = val;
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderId, IPrefetchPath prefetchPathToUse):
			base(salesOrderId, prefetchPathToUse)
		{
            EntityValidators.SalesOrderHeaderEntityValidator val =
    new AW.Data.EntityValidators.SalesOrderHeaderEntityValidator();
            this.EntityValidatorToUse = val;
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderId, SalesOrderHeaderValidator validator):
			base(salesOrderId, validator)
		{
            EntityValidators.SalesOrderHeaderEntityValidator val =
    new AW.Data.EntityValidators.SalesOrderHeaderEntityValidator();
            this.EntityValidatorToUse = val;
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderId, SalesOrderHeaderValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse):
			base(salesOrderId, validator, propertyDescriptorFactoryToUse, entityFactoryToUse)
		{
            EntityValidators.SalesOrderHeaderEntityValidator val =
    new AW.Data.EntityValidators.SalesOrderHeaderEntityValidator();
            this.EntityValidatorToUse = val;
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesOrderHeaderEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse):
			base(propertyDescriptorFactoryToUse, entityFactoryToUse)
		{
            EntityValidators.SalesOrderHeaderEntityValidator val =
    new AW.Data.EntityValidators.SalesOrderHeaderEntityValidator();
            this.EntityValidatorToUse = val;
		}
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesOrderHeaderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
            EntityValidators.SalesOrderHeaderEntityValidator val =
    new AW.Data.EntityValidators.SalesOrderHeaderEntityValidator();
            this.EntityValidatorToUse = val;
		}
		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        //public static SalesOrderHeaderCollection GetSalesOrderHeaderCollection
        //    (
        //    DateTime FromDate,
        //    DateTime ToDate,
        //    string FirstName,
        //    string LastName,
        //    int OrderID,
        //    string OrderNumber,
        //    string CityName,
        //    string StateName,
        //    string CountryName,
        //    string Zip
        //    )
        //{
        //    RelationCollection Relations = new RelationCollection();
        //    IPredicateExpression Filter = new PredicateExpression();
        //    if (
        //        ( FirstName   != "" ) |
        //        ( LastName    != "" ) |
        //        ( CityName    != "" ) |
        //        ( StateName   != "" ) |
        //        ( CountryName != "" ) |
        //        ( Zip         != "" )
        //       )
        //    {
        //        Relations.Add(
        //            SalesOrderHeaderEntity.Relations.
        //            CustomerViewRelatedEntityUsingCustomerId);
        //    }
        //    if (FromDate != DateTime.MinValue)
        //    {
        //        Filter.Add(
        //            SalesOrderHeaderFields.OrderDate >= FromDate);
        //    }
        //    if (ToDate != DateTime.MinValue)
        //    {
        //        Filter.Add(
        //            SalesOrderHeaderFields.OrderDate <= ToDate);
        //    }
        //    if (FirstName != "")
        //    {
        //        Filter.Add(
        //            CustomerViewRelatedFields.FirstName % FirstName);
        //    }
        //    if (LastName != "")
        //    {
        //        Filter.Add(
        //            CustomerViewRelatedFields.LastName % LastName);
        //    }
        //    if (CityName != "")
        //    {
        //        Filter.Add(
        //            CustomerViewRelatedFields.City % CityName);
        //    }
        //    if (StateName != "")
        //    {
        //        Filter.Add(
        //            CustomerViewRelatedFields.StateProvinceName == StateName);
        //    }
        //    if (CountryName != "")
        //    {
        //        Filter.Add(
        //            CustomerViewRelatedFields.CountryRegionName == CountryName);
        //    }
        //    if (Zip != "")
        //    {
        //        Filter.Add(
        //            CustomerViewRelatedFields.PostalCode == Zip);
        //    }
        //    if (OrderID != 0)
        //    {
        //        Filter.Add(
        //            SalesOrderHeaderFields.SalesOrderId == OrderID);
        //    }
        //    if (OrderNumber != "")
        //    {
        //        Filter.Add(
        //            SalesOrderHeaderFields.SalesOrderNumber == OrderNumber);
        //    }
        //    ISortExpression Sort = new SortExpression();
        //    Sort.Add(
        //        SalesOrderHeaderFields.OrderDate | SortOperator.Ascending);
        //    SalesOrderHeaderCollection Orders = new SalesOrderHeaderCollection();
        //    Orders.SupportsSorting = true;
        //    Orders.GetMulti(Filter, 100, Sort, Relations);
        //    return Orders;
        //}
        public static SalesOrderHeaderCollection GetSalesOrderHeaderCollection
            (
            DateTime FromDate,
            DateTime ToDate,
            string FirstName,
            string LastName,
            int OrderID,
            string OrderNumber,
            string CityName,
            string StateName,
            string CountryName,
            string Zip
            )
        {
            RelationCollection Relations = new RelationCollection();
            IPredicateExpression Filter = new PredicateExpression();
            if (
                (FirstName != "") |
                (LastName != "") |
                (CityName != "") |
                (StateName != "") |
                (CountryName != "") |
                (Zip != "")
               )
            {
                Relations.Add(
                    SalesOrderHeaderEntity.Relations.
                    CustomerViewRelatedEntityUsingCustomerId);
            }
            if (FromDate != DateTime.MinValue)
            {
                Filter.Add(
                    SalesOrderHeaderFields.OrderDate >= FromDate);
            }
            if (ToDate != DateTime.MinValue)
            {
                Filter.Add(
                    SalesOrderHeaderFields.OrderDate <= ToDate);
            }
            if (FirstName != "")
            {
                Filter.Add(
                    CustomerViewRelatedFields.FirstName % FirstName);
            }
            if (LastName != "")
            {
                Filter.Add(
                    CustomerViewRelatedFields.LastName % LastName);
            }
            if (CityName != "")
            {
                Filter.Add(
                    CustomerViewRelatedFields.City % CityName);
            }
            if (StateName != "")
            {
                Filter.Add(
                    CustomerViewRelatedFields.StateProvinceName == StateName);
            }
            if (CountryName != "")
            {
                Filter.Add(
                    CustomerViewRelatedFields.CountryRegionName == CountryName);
            }
            if (Zip != "")
            {
                Filter.Add(
                    CustomerViewRelatedFields.PostalCode == Zip);
            }
            if (OrderID != 0)
            {
                Filter.Add(
                    SalesOrderHeaderFields.SalesOrderId == OrderID);
            }
            if (OrderNumber != "")
            {
                Filter.Add(
                    SalesOrderHeaderFields.SalesOrderNumber == OrderNumber);
            }
                ISortExpression Sort = new SortExpression();
                Sort.Add(
                    SalesOrderHeaderFields.OrderDate | SortOperator.Ascending);
                SalesOrderHeaderCollection Orders = new SalesOrderHeaderCollection();
                Orders.SupportsSorting = true;
                IPrefetchPath Prefetch = 
                    new PrefetchPath((int)EntityType.SalesOrderHeaderEntity);
                Prefetch.Add(
                    SalesOrderHeaderEntity.PrefetchPathCustomerView_);
                Orders.GetMulti(Filter, 100, Sort, Relations,Prefetch);
                return Orders;
            }
        public string CustomerLastName
        { get {return this.CustomerView_.LastName;} }
        public string CustomerFirstName
        { get {return this.CustomerView_.FirstName;} }
        public string CustomerCity
        { get {return this.CustomerView_.City;} }
        public string CustomerState
        { get {return this.CustomerView_.StateProvinceName;} }
        public string CustomerCountry
        { get {return this.CustomerView_.CountryRegionName;} }
        public string CustomerZip
        { get {return this.CustomerView_.PostalCode;} }

        protected override void OnFieldValidateComplete(IEntityField field, bool validationResult)
        {
            base.OnFieldValidateComplete(field, validationResult);
        }
        protected override void OnFieldValidate(IEntityField field)
        {
            base.OnFieldValidate(field);
        }
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included Code

		#endregion
	}
}

