///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:30 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.EnterpriseServices;

using AW.Data.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.HelperClasses
{
	/// <summary>
	/// Specific implementation of the TransactionComPlus class. The constructor will take care of the creation of the physical transaction and the
	/// opening of the connection. It will require a COM+ transaction.
	/// </summary>
	[MustRunInClientContext(true)]
	public class TransactionComPlus : TransactionComPlusBase
	{
		/// <summary>
		/// CTor
		/// </summary>
		public TransactionComPlus()
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="connectionString">Connection string to use in this transaction</param>
		public TransactionComPlus(string connectionString):base(connectionString)
		{
		}


		/// <summary>
		/// Creates a new IDbConnection instance which will be used by all elements using this ITransaction instance. 
		/// Reads connectionstring from .config file. The COM+ transaction will flow to the used method.
		/// </summary>
		/// <returns>new IDbConnection instance</returns>
		protected override System.Data.IDbConnection CreateConnection()
		{
			DbUtilsComPlus dbUtilsToUse = new DbUtilsComPlus();
			return dbUtilsToUse.CreateConnection();
		}


		/// <summary>
		/// Creates a new IDbConnection instance which will be used by all elements using this ITransaction instance
		/// The COM+ transaction will flow to the used method.
		/// </summary>
		/// <param name="connectionString">Connection string to use</param>
		/// <returns>new IDbConnection instance</returns>
		protected override System.Data.IDbConnection CreateConnection(string connectionString)
		{
			DbUtilsComPlus dbUtilsToUse = new DbUtilsComPlus();
			return dbUtilsToUse.CreateConnection(connectionString);
		}


		/// <summary>
		/// Creates a new physical transaction object over the created connection. The connection is assumed to be open.
		/// This method is void in combination of a COM+ transaction. It will always return null.
		/// </summary>
		/// <returns>null</returns>
		protected override System.Data.IDbTransaction CreatePhysicalTransaction()
		{
			return null;
		}

		#region Included Code

		#endregion
	}
}
