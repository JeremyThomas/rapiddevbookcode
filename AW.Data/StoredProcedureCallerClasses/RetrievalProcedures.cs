///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//
// Do not try to run this code on another version of the database than the database
// which was used to generate this code. This means that when you used f.e. SqlServer 2000
// to generate this code, it is likely that you will not be able to use that code on
// SqlServer 7 due to SQL syntax mismatches. Most code is generic code which will work
// with any database, but some code relies on a specific database type/vendor/version used. 
// This code is located in the DaoClasses which target a specific specified database. Also all
// classes target a specific specified Dynamic Query Engine (DQE) in the using/imports
// directives. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:32 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlClient;

using AW.Data.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.StoredProcedureCallerClasses
{
	/// <summary>
	/// Class which contains the static logic to execute retrieval stored procedures in the database.
	/// </summary>
	public class RetrievalProcedures
	{
		/// <summary>
		/// private CTor so no instance can be created.
		/// </summary>
		private RetrievalProcedures()
		{
		}

	
		/// <summary>
		/// Calls stored procedure 'uspGetEmployeeManagers'.<br/><br/>
		/// 
		/// </summary>
		/// <param name="employeeId">Input parameter of stored procedure</param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable UspGetEmployeeManagers(System.Int32 employeeId)
		{
			// create parameters
			SqlParameter[] parameters = new SqlParameter[1];
			parameters[0] = new SqlParameter("@EmployeeID", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, employeeId);

			// Call the stored proc.
			DataTable toReturn = new DataTable("UspGetEmployeeManagers");
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[dbo].[uspGetEmployeeManagers]", parameters, toReturn, null);

			return toReturn;
		}

	
		/// <summary>
		/// Calls stored procedure 'uspGetEmployeeManagers'. This version also returns the return value of the stored procedure.<br/><br/>
		/// 
		/// </summary>
		/// <param name="employeeId">Input parameter of stored procedure</param>
		/// <param name="returnValue">Return value of the stored procedure</param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable UspGetEmployeeManagers(System.Int32 employeeId, ref System.Int32 returnValue)
		{
			// create parameters. Add 1 to make room for the return value parameter.
			SqlParameter[] parameters = new SqlParameter[1 + 1];
			parameters[0] = new SqlParameter("@EmployeeID", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, employeeId);

			// return value parameter
			parameters[1] = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, true, 10, 0, "",  DataRowVersion.Current, returnValue);
			
			// Call the stored proc.
			DataTable toReturn = new DataTable("UspGetEmployeeManagers");
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[dbo].[uspGetEmployeeManagers]", parameters, toReturn, null);


			returnValue = (int)parameters[1].Value;
			return toReturn;
		}


		/// <summary>
		/// Calls stored procedure 'uspGetEmployeeManagers'.<br/><br/>
		/// 
		/// </summary>
		/// <param name="employeeId">Input parameter of stored procedure</param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable UspGetEmployeeManagers(System.Int32 employeeId,  ITransaction transactionToUse)
		{
			// create parameters
			SqlParameter[] parameters = new SqlParameter[1];
			parameters[0] = new SqlParameter("@EmployeeID", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, employeeId);

			// Call the stored proc.
			DataTable toReturn = new DataTable("UspGetEmployeeManagers");
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[dbo].[uspGetEmployeeManagers]", parameters, toReturn, transactionToUse);

			return toReturn;
		}

	
		/// <summary>
		/// Calls stored procedure 'uspGetEmployeeManagers'. This version also returns the return value of the stored procedure.<br/><br/>
		/// 
		/// </summary>
		/// <param name="employeeId">Input parameter of stored procedure</param>
		/// <param name="returnValue">Return value of the stored procedure</param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable UspGetEmployeeManagers(System.Int32 employeeId, ref System.Int32 returnValue, ITransaction transactionToUse)
		{
			// create parameters. Add 1 to make room for the return value parameter.
			SqlParameter[] parameters = new SqlParameter[1 + 1];
			parameters[0] = new SqlParameter("@EmployeeID", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, employeeId);

			// return value parameter
			parameters[1] = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, true, 10, 0, "",  DataRowVersion.Current, returnValue);
			
			// Call the stored proc.
			DataTable toReturn = new DataTable("UspGetEmployeeManagers");
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[dbo].[uspGetEmployeeManagers]", parameters, toReturn, transactionToUse);


			returnValue = (int)parameters[1].Value;
			return toReturn;
		}
	

		/// <summary>
		/// Calls stored procedure 'uspGetManagerEmployees'.<br/><br/>
		/// 
		/// </summary>
		/// <param name="managerId">Input parameter of stored procedure</param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable UspGetManagerEmployees(System.Int32 managerId)
		{
			// create parameters
			SqlParameter[] parameters = new SqlParameter[1];
			parameters[0] = new SqlParameter("@ManagerID", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, managerId);

			// Call the stored proc.
			DataTable toReturn = new DataTable("UspGetManagerEmployees");
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[dbo].[uspGetManagerEmployees]", parameters, toReturn, null);

			return toReturn;
		}

	
		/// <summary>
		/// Calls stored procedure 'uspGetManagerEmployees'. This version also returns the return value of the stored procedure.<br/><br/>
		/// 
		/// </summary>
		/// <param name="managerId">Input parameter of stored procedure</param>
		/// <param name="returnValue">Return value of the stored procedure</param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable UspGetManagerEmployees(System.Int32 managerId, ref System.Int32 returnValue)
		{
			// create parameters. Add 1 to make room for the return value parameter.
			SqlParameter[] parameters = new SqlParameter[1 + 1];
			parameters[0] = new SqlParameter("@ManagerID", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, managerId);

			// return value parameter
			parameters[1] = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, true, 10, 0, "",  DataRowVersion.Current, returnValue);
			
			// Call the stored proc.
			DataTable toReturn = new DataTable("UspGetManagerEmployees");
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[dbo].[uspGetManagerEmployees]", parameters, toReturn, null);


			returnValue = (int)parameters[1].Value;
			return toReturn;
		}


		/// <summary>
		/// Calls stored procedure 'uspGetManagerEmployees'.<br/><br/>
		/// 
		/// </summary>
		/// <param name="managerId">Input parameter of stored procedure</param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable UspGetManagerEmployees(System.Int32 managerId,  ITransaction transactionToUse)
		{
			// create parameters
			SqlParameter[] parameters = new SqlParameter[1];
			parameters[0] = new SqlParameter("@ManagerID", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, managerId);

			// Call the stored proc.
			DataTable toReturn = new DataTable("UspGetManagerEmployees");
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[dbo].[uspGetManagerEmployees]", parameters, toReturn, transactionToUse);

			return toReturn;
		}

	
		/// <summary>
		/// Calls stored procedure 'uspGetManagerEmployees'. This version also returns the return value of the stored procedure.<br/><br/>
		/// 
		/// </summary>
		/// <param name="managerId">Input parameter of stored procedure</param>
		/// <param name="returnValue">Return value of the stored procedure</param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable UspGetManagerEmployees(System.Int32 managerId, ref System.Int32 returnValue, ITransaction transactionToUse)
		{
			// create parameters. Add 1 to make room for the return value parameter.
			SqlParameter[] parameters = new SqlParameter[1 + 1];
			parameters[0] = new SqlParameter("@ManagerID", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, managerId);

			// return value parameter
			parameters[1] = new SqlParameter("RETURNVALUE", SqlDbType.Int, 0, ParameterDirection.ReturnValue, true, 10, 0, "",  DataRowVersion.Current, returnValue);
			
			// Call the stored proc.
			DataTable toReturn = new DataTable("UspGetManagerEmployees");
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[dbo].[uspGetManagerEmployees]", parameters, toReturn, transactionToUse);


			returnValue = (int)parameters[1].Value;
			return toReturn;
		}
	

		#region Included Code

		#endregion
	}
}
