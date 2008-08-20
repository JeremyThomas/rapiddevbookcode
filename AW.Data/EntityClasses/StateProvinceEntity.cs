///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Sunday, November 06, 2005 1:19:31 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;

using AW.Data.FactoryClasses;
using AW.Data.CollectionClasses;
using AW.Data.DaoClasses;
using AW.Data.RelationClasses;
using AW.Data.ValidatorClasses;
using AW.Data.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	/// <summary>
	/// Entity class which represents the entity 'StateProvince'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class StateProvinceEntity : StateProvinceEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public StateProvinceEntity():base(new PropertyDescriptorFactory(), new StateProvinceEntityFactory())
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		public StateProvinceEntity(System.Int32 stateProvinceId):
			base(stateProvinceId)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public StateProvinceEntity(System.Int32 stateProvinceId, IPrefetchPath prefetchPathToUse):
			base(stateProvinceId, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="validator">The custom validator object for this StateProvinceEntity</param>
		public StateProvinceEntity(System.Int32 stateProvinceId, StateProvinceValidator validator):
			base(stateProvinceId, validator)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="validator">The custom validator object for this StateProvinceEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public StateProvinceEntity(System.Int32 stateProvinceId, StateProvinceValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse):
			base(stateProvinceId, validator, propertyDescriptorFactoryToUse, entityFactoryToUse)
		{
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public StateProvinceEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse):
			base(propertyDescriptorFactoryToUse, entityFactoryToUse)
		{
		}
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected StateProvinceEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
        public static StateProvinceCollection GetStateProvinceCollection()
        {
            ISortExpression Sort = new SortExpression();
            Sort.Add(StateProvinceFields.Name | SortOperator.Ascending);
            StateProvinceCollection States = new StateProvinceCollection();
            States.GetMulti(null, 0, Sort);
            return States;
        }
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included Code

		#endregion
	}
}
