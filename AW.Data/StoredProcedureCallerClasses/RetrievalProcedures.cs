///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Thursday, 12 February 2009 11:38:25 p.m.
// Code is generated using templates: SD.TemplateBindings.SqlServerSpecific.NET20
// Templates vendor: Solutions Design.
// Templates version: 
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
	public partial class RetrievalProcedures
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
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[AdventureWorks].[dbo].[uspGetEmployeeManagers]", parameters, toReturn, null);

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
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[AdventureWorks].[dbo].[uspGetEmployeeManagers]", parameters, toReturn, null);


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
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[AdventureWorks].[dbo].[uspGetEmployeeManagers]", parameters, toReturn, transactionToUse);

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
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[AdventureWorks].[dbo].[uspGetEmployeeManagers]", parameters, toReturn, transactionToUse);


			returnValue = (int)parameters[1].Value;
			return toReturn;
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'uspGetEmployeeManagers'.
		/// 
		/// </summary>
		/// <param name="employeeId">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetUspGetEmployeeManagersCallAsQuery( System.Int32 employeeId)
		{
			string procName = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[AdventureWorks].[dbo].[uspGetEmployeeManagers]");
			RetrievalQuery toReturn = new RetrievalQuery( new SqlCommand(procName) );
			toReturn.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, employeeId));

			toReturn.Command.CommandType = CommandType.StoredProcedure;
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
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[AdventureWorks].[dbo].[uspGetManagerEmployees]", parameters, toReturn, null);

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
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[AdventureWorks].[dbo].[uspGetManagerEmployees]", parameters, toReturn, null);


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
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[AdventureWorks].[dbo].[uspGetManagerEmployees]", parameters, toReturn, transactionToUse);

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
			bool hasSucceeded = DbUtils.CallRetrievalStoredProcedure("[AdventureWorks].[dbo].[uspGetManagerEmployees]", parameters, toReturn, transactionToUse);


			returnValue = (int)parameters[1].Value;
			return toReturn;
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'uspGetManagerEmployees'.
		/// 
		/// </summary>
		/// <param name="managerId">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetUspGetManagerEmployeesCallAsQuery( System.Int32 managerId)
		{
			string procName = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName("[AdventureWorks].[dbo].[uspGetManagerEmployees]");
			RetrievalQuery toReturn = new RetrievalQuery( new SqlCommand(procName) );
			toReturn.Parameters.Add(new SqlParameter("@ManagerID", SqlDbType.Int, 0, ParameterDirection.Input, true, 10, 0, "",  DataRowVersion.Current, managerId));

			toReturn.Command.CommandType = CommandType.StoredProcedure;
			return toReturn;
		}
	

		#region Included Code

		#endregion
	}
}
