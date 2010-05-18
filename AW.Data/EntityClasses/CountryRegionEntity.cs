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
  using AW.Data.HelperClasses;
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'CountryRegion'. This class is used for Business Logic or for framework extension code.</summary>
	[Serializable]
	public partial class CountryRegionEntity : CountryRegionEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		/// <summary>CTor</summary>
		public CountryRegionEntity():base()
		{
		}

		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		public CountryRegionEntity(System.String countryRegionCode):
			base(countryRegionCode)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CountryRegionEntity(System.String countryRegionCode, IPrefetchPath prefetchPathToUse):
			base(countryRegionCode, prefetchPathToUse)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="validator">The custom validator object for this CountryRegionEntity</param>
		public CountryRegionEntity(System.String countryRegionCode, IValidator validator):
			base(countryRegionCode, validator)
		{
		}
		
		/// <summary>CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CountryRegionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        public static CountryRegionCollection GetCountryRegionCollection()
        {
            ISortExpression Sort = new SortExpression();
            Sort.Add(CountryRegionFields.Name | SortOperator.Ascending);
            CountryRegionCollection Countries = new CountryRegionCollection();
            Countries.GetMulti(null, 0, Sort);
            return Countries;
        }
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}
}
