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
	/// Entity class which represents the entity 'SpecialOfferProduct'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class SpecialOfferProductEntity : SpecialOfferProductEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public SpecialOfferProductEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="specialOfferID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="productID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		public SpecialOfferProductEntity(System.Int32 specialOfferID, System.Int32 productID):
			base(specialOfferID, productID)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="specialOfferID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="productID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SpecialOfferProductEntity(System.Int32 specialOfferID, System.Int32 productID, IPrefetchPath prefetchPathToUse):
			base(specialOfferID, productID, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="specialOfferID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="productID">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="validator">The custom validator object for this SpecialOfferProductEntity</param>
		public SpecialOfferProductEntity(System.Int32 specialOfferID, System.Int32 productID, IValidator validator):
			base(specialOfferID, productID, validator)
		{
		}
	
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SpecialOfferProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
