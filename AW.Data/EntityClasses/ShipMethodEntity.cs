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

using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Data.HelperClasses;
namespace AW.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
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
		public ShipMethodEntity():base(new PropertyDescriptorFactory(), new ShipMethodEntityFactory())
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="shipMethodId">PK value for ShipMethod which data should be fetched into this ShipMethod object</param>
		public ShipMethodEntity(System.Int32 shipMethodId):
			base(shipMethodId)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="shipMethodId">PK value for ShipMethod which data should be fetched into this ShipMethod object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ShipMethodEntity(System.Int32 shipMethodId, IPrefetchPath prefetchPathToUse):
			base(shipMethodId, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="shipMethodId">PK value for ShipMethod which data should be fetched into this ShipMethod object</param>
		/// <param name="validator">The custom validator object for this ShipMethodEntity</param>
		public ShipMethodEntity(System.Int32 shipMethodId, ShipMethodValidator validator):
			base(shipMethodId, validator)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="shipMethodId">PK value for ShipMethod which data should be fetched into this ShipMethod object</param>
		/// <param name="validator">The custom validator object for this ShipMethodEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ShipMethodEntity(System.Int32 shipMethodId, ShipMethodValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse):
			base(shipMethodId, validator, propertyDescriptorFactoryToUse, entityFactoryToUse)
		{
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ShipMethodEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse):
			base(propertyDescriptorFactoryToUse, entityFactoryToUse)
		{
		}
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ShipMethodEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
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
