///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using AW.Data.FactoryClasses;
using AW.Data.CollectionClasses;
using AW.Data.DaoClasses;
using AW.Data.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	using AW.Data.EntityValidators;
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'SalesOrderHeader'. This class is used for Business Logic or for framework extension code.</summary>
	[Serializable]
	public partial class SalesOrderHeaderEntity : SalesOrderHeaderEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		/// <summary>CTor</summary>
		public SalesOrderHeaderEntity():base()
		{
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderID):
			base(salesOrderID)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse):
			base(salesOrderID, prefetchPathToUse)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderID, IValidator validator):
			base(salesOrderID, validator)
		{
		}
		
		/// <summary>CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesOrderHeaderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode

    public string CustomerLastName
    {
      //CustomerViewRelated will be null if the customer is not an individual 
      get { return CustomerViewRelated == null ? null : CustomerViewRelated.LastName; }
    }

    public string CustomerFirstName
    {
      get { return CustomerViewRelated == null ? null : CustomerViewRelated.FirstName; }
    }

    public string CustomerCity
    {
      get { return CustomerViewRelated == null ? null : CustomerViewRelated.City; }
    }

    public string CustomerState
    {
      get { return CustomerViewRelated == null ? null : CustomerViewRelated.StateProvinceName; }
    }

    public string CustomerCountry
    {
      get { return CustomerViewRelated == null ? null : CustomerViewRelated.CountryRegionName; }
    }

    public string CustomerZip
    {
      get { return CustomerViewRelated == null ? null : CustomerViewRelated.PostalCode; }
    }

    /// <summary>
    /// Called at the end of the initialization routine. Raises Initialized event.
    /// </summary>
    protected override void OnInitialized()
    {
      // Set the validator to this customer instance.
      Validator = new SalesOrderHeaderEntityValidator();
    }

		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}
}
