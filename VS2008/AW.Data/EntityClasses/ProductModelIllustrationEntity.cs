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
	/// Entity class which represents the entity 'ProductModelIllustration'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class ProductModelIllustrationEntity : ProductModelIllustrationEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public ProductModelIllustrationEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productModelID">PK value for ProductModelIllustration which data should be fetched into this ProductModelIllustration object</param>
		/// <param name="illustrationID">PK value for ProductModelIllustration which data should be fetched into this ProductModelIllustration object</param>
		public ProductModelIllustrationEntity(System.Int32 productModelID, System.Int32 illustrationID):
			base(productModelID, illustrationID)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productModelID">PK value for ProductModelIllustration which data should be fetched into this ProductModelIllustration object</param>
		/// <param name="illustrationID">PK value for ProductModelIllustration which data should be fetched into this ProductModelIllustration object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductModelIllustrationEntity(System.Int32 productModelID, System.Int32 illustrationID, IPrefetchPath prefetchPathToUse):
			base(productModelID, illustrationID, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productModelID">PK value for ProductModelIllustration which data should be fetched into this ProductModelIllustration object</param>
		/// <param name="illustrationID">PK value for ProductModelIllustration which data should be fetched into this ProductModelIllustration object</param>
		/// <param name="validator">The custom validator object for this ProductModelIllustrationEntity</param>
		public ProductModelIllustrationEntity(System.Int32 productModelID, System.Int32 illustrationID, IValidator validator):
			base(productModelID, illustrationID, validator)
		{
		}
	
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductModelIllustrationEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
