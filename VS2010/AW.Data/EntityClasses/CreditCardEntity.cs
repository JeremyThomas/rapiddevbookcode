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

	/// <summary>Entity class which represents the entity 'CreditCard'. This class is used for Business Logic or for framework extension code.</summary>
	[Serializable]
	public partial class CreditCardEntity : CreditCardEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		/// <summary>CTor</summary>
		public CreditCardEntity():base()
		{
		}

		/// <summary>CTor</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		public CreditCardEntity(System.Int32 creditCardID):
			base(creditCardID)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CreditCardEntity(System.Int32 creditCardID, IPrefetchPath prefetchPathToUse):
			base(creditCardID, prefetchPathToUse)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="creditCardID">PK value for CreditCard which data should be fetched into this CreditCard object</param>
		/// <param name="validator">The custom validator object for this CreditCardEntity</param>
		public CreditCardEntity(System.Int32 creditCardID, IValidator validator):
			base(creditCardID, validator)
		{
		}
		
		/// <summary>CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CreditCardEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
