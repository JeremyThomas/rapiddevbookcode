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
  using AW.Data.HelperClasses;
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>
	/// Entity class which represents the entity 'ShipMethod'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class ShipMethodEntity : ShipMethodEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public ShipMethodEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="shipMethodID">PK value for ShipMethod which data should be fetched into this ShipMethod object</param>
		public ShipMethodEntity(System.Int32 shipMethodID):
			base(shipMethodID)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="shipMethodID">PK value for ShipMethod which data should be fetched into this ShipMethod object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ShipMethodEntity(System.Int32 shipMethodID, IPrefetchPath prefetchPathToUse):
			base(shipMethodID, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="shipMethodID">PK value for ShipMethod which data should be fetched into this ShipMethod object</param>
		/// <param name="validator">The custom validator object for this ShipMethodEntity</param>
		public ShipMethodEntity(System.Int32 shipMethodID, IValidator validator):
			base(shipMethodID, validator)
		{
		}
	
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ShipMethodEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        public static ShipMethodCollection GetShipMethodCollection()
        {
            ISortExpression Sort = new SortExpression();
            Sort.Add(ShipMethodFields.ShipRate| SortOperator.Ascending);
            ShipMethodCollection Methods = new ShipMethodCollection();
            Methods.GetMulti(null, 0, Sort);
            return Methods;
        }
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}
}
