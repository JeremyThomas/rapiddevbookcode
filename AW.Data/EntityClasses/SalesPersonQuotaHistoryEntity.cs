﻿///////////////////////////////////////////////////////////////
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
	/// Entity class which represents the entity 'SalesPersonQuotaHistory'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class SalesPersonQuotaHistoryEntity : SalesPersonQuotaHistoryEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public SalesPersonQuotaHistoryEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesPersonID">PK value for SalesPersonQuotaHistory which data should be fetched into this SalesPersonQuotaHistory object</param>
		/// <param name="quotaDate">PK value for SalesPersonQuotaHistory which data should be fetched into this SalesPersonQuotaHistory object</param>
		public SalesPersonQuotaHistoryEntity(System.Int32 salesPersonID, System.DateTime quotaDate):
			base(salesPersonID, quotaDate)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesPersonID">PK value for SalesPersonQuotaHistory which data should be fetched into this SalesPersonQuotaHistory object</param>
		/// <param name="quotaDate">PK value for SalesPersonQuotaHistory which data should be fetched into this SalesPersonQuotaHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SalesPersonQuotaHistoryEntity(System.Int32 salesPersonID, System.DateTime quotaDate, IPrefetchPath prefetchPathToUse):
			base(salesPersonID, quotaDate, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesPersonID">PK value for SalesPersonQuotaHistory which data should be fetched into this SalesPersonQuotaHistory object</param>
		/// <param name="quotaDate">PK value for SalesPersonQuotaHistory which data should be fetched into this SalesPersonQuotaHistory object</param>
		/// <param name="validator">The custom validator object for this SalesPersonQuotaHistoryEntity</param>
		public SalesPersonQuotaHistoryEntity(System.Int32 salesPersonID, System.DateTime quotaDate, IValidator validator):
			base(salesPersonID, quotaDate, validator)
		{
		}
	
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesPersonQuotaHistoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}
		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included Code

		#endregion
	}
}
