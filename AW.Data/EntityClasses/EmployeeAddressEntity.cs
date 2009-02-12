﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Thursday, 12 February 2009 11:38:24 p.m.
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
	/// Entity class which represents the entity 'EmployeeAddress'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class EmployeeAddressEntity : EmployeeAddressEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public EmployeeAddressEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeID">PK value for EmployeeAddress which data should be fetched into this EmployeeAddress object</param>
		/// <param name="addressID">PK value for EmployeeAddress which data should be fetched into this EmployeeAddress object</param>
		public EmployeeAddressEntity(System.Int32 employeeID, System.Int32 addressID):
			base(employeeID, addressID)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeID">PK value for EmployeeAddress which data should be fetched into this EmployeeAddress object</param>
		/// <param name="addressID">PK value for EmployeeAddress which data should be fetched into this EmployeeAddress object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public EmployeeAddressEntity(System.Int32 employeeID, System.Int32 addressID, IPrefetchPath prefetchPathToUse):
			base(employeeID, addressID, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeID">PK value for EmployeeAddress which data should be fetched into this EmployeeAddress object</param>
		/// <param name="addressID">PK value for EmployeeAddress which data should be fetched into this EmployeeAddress object</param>
		/// <param name="validator">The custom validator object for this EmployeeAddressEntity</param>
		public EmployeeAddressEntity(System.Int32 employeeID, System.Int32 addressID, IValidator validator):
			base(employeeID, addressID, validator)
		{
		}
	
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeAddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
