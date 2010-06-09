﻿///////////////////////////////////////////////////////////////
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

	/// <summary>Entity class which represents the entity 'EmployeeAddress'. This class is used for Business Logic or for framework extension code.</summary>
	[Serializable]
	public partial class EmployeeAddressEntity : EmployeeAddressEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		/// <summary>CTor</summary>
		public EmployeeAddressEntity():base()
		{
		}

		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for EmployeeAddress which data should be fetched into this EmployeeAddress object</param>
		/// <param name="employeeID">PK value for EmployeeAddress which data should be fetched into this EmployeeAddress object</param>
		public EmployeeAddressEntity(System.Int32 addressID, System.Int32 employeeID):
			base(addressID, employeeID)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for EmployeeAddress which data should be fetched into this EmployeeAddress object</param>
		/// <param name="employeeID">PK value for EmployeeAddress which data should be fetched into this EmployeeAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public EmployeeAddressEntity(System.Int32 addressID, System.Int32 employeeID, IPrefetchPath prefetchPathToUse):
			base(addressID, employeeID, prefetchPathToUse)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="addressID">PK value for EmployeeAddress which data should be fetched into this EmployeeAddress object</param>
		/// <param name="employeeID">PK value for EmployeeAddress which data should be fetched into this EmployeeAddress object</param>
		/// <param name="validator">The custom validator object for this EmployeeAddressEntity</param>
		public EmployeeAddressEntity(System.Int32 addressID, System.Int32 employeeID, IValidator validator):
			base(addressID, employeeID, validator)
		{
		}
		
		/// <summary>CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeAddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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