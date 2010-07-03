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
	/// Entity class which represents the entity 'PurchaseOrderHeader'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class PurchaseOrderHeaderEntity : PurchaseOrderHeaderEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public PurchaseOrderHeaderEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		public PurchaseOrderHeaderEntity(System.Int32 purchaseOrderID):
			base(purchaseOrderID)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public PurchaseOrderHeaderEntity(System.Int32 purchaseOrderID, IPrefetchPath prefetchPathToUse):
			base(purchaseOrderID, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="validator">The custom validator object for this PurchaseOrderHeaderEntity</param>
		public PurchaseOrderHeaderEntity(System.Int32 purchaseOrderID, IValidator validator):
			base(purchaseOrderID, validator)
		{
		}
	
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PurchaseOrderHeaderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
