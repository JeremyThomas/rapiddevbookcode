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
	/// Entity class which represents the entity 'ProductProductPhoto'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class ProductProductPhotoEntity : ProductProductPhotoEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public ProductProductPhotoEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productID">PK value for ProductProductPhoto which data should be fetched into this ProductProductPhoto object</param>
		/// <param name="productPhotoID">PK value for ProductProductPhoto which data should be fetched into this ProductProductPhoto object</param>
		public ProductProductPhotoEntity(System.Int32 productID, System.Int32 productPhotoID):
			base(productID, productPhotoID)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productID">PK value for ProductProductPhoto which data should be fetched into this ProductProductPhoto object</param>
		/// <param name="productPhotoID">PK value for ProductProductPhoto which data should be fetched into this ProductProductPhoto object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductProductPhotoEntity(System.Int32 productID, System.Int32 productPhotoID, IPrefetchPath prefetchPathToUse):
			base(productID, productPhotoID, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productID">PK value for ProductProductPhoto which data should be fetched into this ProductProductPhoto object</param>
		/// <param name="productPhotoID">PK value for ProductProductPhoto which data should be fetched into this ProductProductPhoto object</param>
		/// <param name="validator">The custom validator object for this ProductProductPhotoEntity</param>
		public ProductProductPhotoEntity(System.Int32 productID, System.Int32 productPhotoID, IValidator validator):
			base(productID, productPhotoID, validator)
		{
		}
	
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductProductPhotoEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
