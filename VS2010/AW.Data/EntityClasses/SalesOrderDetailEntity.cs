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
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'SalesOrderDetail'. This class is used for Business Logic or for framework extension code.</summary>
	[Serializable]
	public partial class SalesOrderDetailEntity : SalesOrderDetailEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		/// <summary>CTor</summary>
		public SalesOrderDetailEntity():base()
		{
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderDetailID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		public SalesOrderDetailEntity(System.Int32 salesOrderDetailID, System.Int32 salesOrderID):
			base(salesOrderDetailID, salesOrderID)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderDetailID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesOrderDetailEntity(System.Int32 salesOrderDetailID, System.Int32 salesOrderID, IPrefetchPath prefetchPathToUse):
			base(salesOrderDetailID, salesOrderID, prefetchPathToUse)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="salesOrderDetailID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderID">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="validator">The custom validator object for this SalesOrderDetailEntity</param>
		public SalesOrderDetailEntity(System.Int32 salesOrderDetailID, System.Int32 salesOrderID, IValidator validator):
			base(salesOrderDetailID, salesOrderID, validator)
		{
		}
		
		/// <summary>CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesOrderDetailEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        public string ProductName
        {
            get {return this.SpecialOfferProduct.Product.Name; }
        }
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}
}
