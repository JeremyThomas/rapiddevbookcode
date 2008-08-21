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
using System.ComponentModel;
using System.Collections;
#if !CF
using System.Linq;
using System.Runtime.Serialization;
#endif
using AW.Data.FactoryClasses;
using AW.Data.CollectionClasses;
using AW.Data.DaoClasses;
using AW.Data.Linq;
using AW.Data.RelationClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
  using AW.Data.HelperClasses;
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
		public SalesOrderHeaderEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderId):
			base(salesOrderId)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderId, IPrefetchPath prefetchPathToUse):
			base(salesOrderId, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderId, IValidator validator):
			base(salesOrderId, validator)
		{
		}
	
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesOrderHeaderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
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
                //note      Orders.SupportsSorting = true;
                IPrefetchPath Prefetch = 
                    new PrefetchPath((int)EntityType.SalesOrderHeaderEntity);
                //note Prefetch.Add(SalesOrderHeaderEntity.PrefetchPathCustomerView_);
                Orders.GetMulti(Filter, 100, Sort, Relations,Prefetch);
                return Orders;
            }

        public static SalesOrderHeaderCollection GetSalesOrderHeaderCollectionWithLinq
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
          var Relations = new RelationCollection();
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

          var predicate = MetaData.SalesOrderHeader.AsQueryable();
          if (FromDate != DateTime.MinValue)
          {
            predicate = predicate.Where(soh => soh.OrderDate >= FromDate);
          }
          if (ToDate != DateTime.MinValue)
          {
            predicate = predicate.Where(soh => soh.OrderDate <= FromDate);
          }
          if (FirstName != "")
          {
            //predicate = predicate.Where(System.Data.Linq.SqlClient.SqlMethods.Like("FirstName"", "L_n%"));
            predicate = predicate.Where(soh => soh.CustomerFirstName.Contains(FirstName));
          }
          if (LastName != "")
          {
            predicate = predicate.Where(soh => soh.CustomerLastName.Contains(LastName));
          }
          if (CityName != "")
          {
            predicate = predicate.Where(soh => soh.CustomerCity.Contains(CityName));
          }
          if (StateName != "")
          {
            predicate = predicate.Where(soh => soh.CustomerState == StateName);
          }
          if (CountryName != "")
          {
            predicate = predicate.Where(soh => soh.CustomerCountry == CountryName);
          }
          if (Zip != "")
          {
            predicate = predicate.Where(soh => soh.CustomerZip == Zip);
          }
          if (OrderID != 0)
          {
            predicate = predicate.Where(soh => soh.SalesOrderId == OrderID);
          }
          if (OrderNumber != "")
          {
            predicate = predicate.Where(soh => soh.SalesOrderNumber == OrderNumber);
          }
          var q = from c in predicate select c;
          q.OrderBy(s => s.OrderDate);
          return ((ILLBLGenProQuery)q).Execute<SalesOrderHeaderCollection>();
        }

        private static LinqMetaData metaData;

        public static LinqMetaData MetaData
        {
          get
          {
            if (metaData == null)
              metaData = new LinqMetaData();
            return metaData;
          }
        }


        public string CustomerLastName
        { get { return this.CustomerViewRelated.LastName; } }
        public string CustomerFirstName
        { get { return this.CustomerViewRelated.FirstName; } }
        public string CustomerCity
        { get { return this.CustomerViewRelated.City; } }
        public string CustomerState
        { get { return this.CustomerViewRelated.StateProvinceName; } }
        public string CustomerCountry
        { get { return this.CustomerViewRelated.CountryRegionName; } }
        public string CustomerZip
        { get { return this.CustomerViewRelated.PostalCode; } }

    //note  //protected override void OnFieldValidateComplete(IEntityField field, bool validationResult)
        //{
        //    base.OnFieldValidateComplete(field, validationResult);
        //}
        //protected override void OnFieldValidate(IEntityField field)
        //{
        //    base.OnFieldValidate(field);
        //}
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}
}
