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
using System.Runtime.Serialization;
#endif
using AW.Data.EntityValidators;
using AW.Data.FactoryClasses;
using AW.Data.CollectionClasses;
using AW.Data.DaoClasses;
using AW.Data.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

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
		public SalesOrderHeaderEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderID):
			base(salesOrderID)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse):
			base(salesOrderID, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderID, IValidator validator):
			base(salesOrderID, validator)
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

    public string CustomerLastName
    {
      get { return CustomerViewRelated.LastName; }
    }

    public string CustomerFirstName
    {
      get { return CustomerViewRelated.FirstName; }
    }

    public string CustomerCity
    {
      get { return CustomerViewRelated.City; }
    }

    public string CustomerState
    {
      get { return CustomerViewRelated.StateProvinceName; }
    }

    public string CustomerCountry
    {
      get { return CustomerViewRelated.CountryRegionName; }
    }

    public string CustomerZip
    {
      get { return CustomerViewRelated.PostalCode; }
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
