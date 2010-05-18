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

	/// <summary>Entity class which represents the entity 'CustomerAddress'. This class is used for Business Logic or for framework extension code.</summary>
	[Serializable]
	public partial class CustomerAddressEntity : CustomerAddressEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		/// <summary>CTor</summary>
		public CustomerAddressEntity():base()
		{
		}

		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		public CustomerAddressEntity(System.Int32 addressID, System.Int32 customerID):
			base(addressID, customerID)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CustomerAddressEntity(System.Int32 addressID, System.Int32 customerID, IPrefetchPath prefetchPathToUse):
			base(addressID, customerID, prefetchPathToUse)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="validator">The custom validator object for this CustomerAddressEntity</param>
		public CustomerAddressEntity(System.Int32 addressID, System.Int32 customerID, IValidator validator):
			base(addressID, customerID, validator)
		{
		}
		
		/// <summary>CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CustomerAddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}
}
