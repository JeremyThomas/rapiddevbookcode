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
using System.Data;
using System.Data.Common;
using AW.Data.DaoClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses.SelfServicingSpecific;

namespace AW.Data.StoredProcedureCallerClasses
{
	/// <summary>Class which contains the static logic to execute retrieval stored procedures in the database.</summary>
	public static partial class RetrievalProcedures
	{

	

		/// <summary>Calls stored procedure 'uspGetEmployeeManagers'.<br/><br/></summary>
		/// <param name="employeeId">Input parameter of stored procedure. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable UspGetEmployeeManagers(System.Int32 employeeId)
		{
			return UspGetEmployeeManagers(employeeId, null);
		}

		/// <summary>Calls stored procedure 'uspGetEmployeeManagers'.<br/><br/></summary>
		/// <param name="employeeId">Input parameter of stored procedure. </param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable UspGetEmployeeManagers(System.Int32 employeeId,  ITransaction transactionToUse)
		{
			using(StoredProcedureCall call = CreateUspGetEmployeeManagersCall(new DataAccessCoreImpl(new CommonDaoBase(), transactionToUse), employeeId))
			{
				DataTable toReturn = call.FillDataTable();				
				return toReturn;
			}
		}
		
		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'uspGetEmployeeManagers'.</summary>
		/// <param name="employeeId">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetUspGetEmployeeManagersCallAsQuery( System.Int32 employeeId )
		{
			return CreateUspGetEmployeeManagersCall(new DataAccessCoreImpl(new CommonDaoBase(), null), employeeId).ToRetrievalQuery();
		}

		/// <summary>Calls stored procedure 'uspGetManagerEmployees'.<br/><br/></summary>
		/// <param name="managerId">Input parameter of stored procedure. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable UspGetManagerEmployees(System.Int32 managerId)
		{
			return UspGetManagerEmployees(managerId, null);
		}

		/// <summary>Calls stored procedure 'uspGetManagerEmployees'.<br/><br/></summary>
		/// <param name="managerId">Input parameter of stored procedure. </param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable UspGetManagerEmployees(System.Int32 managerId,  ITransaction transactionToUse)
		{
			using(StoredProcedureCall call = CreateUspGetManagerEmployeesCall(new DataAccessCoreImpl(new CommonDaoBase(), transactionToUse), managerId))
			{
				DataTable toReturn = call.FillDataTable();				
				return toReturn;
			}
		}
		
		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'uspGetManagerEmployees'.</summary>
		/// <param name="managerId">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetUspGetManagerEmployeesCallAsQuery( System.Int32 managerId )
		{
			return CreateUspGetManagerEmployeesCall(new DataAccessCoreImpl(new CommonDaoBase(), null), managerId).ToRetrievalQuery();
		}

		/// <summary>Creates the call object for the call 'UspGetEmployeeManagers' to stored procedure 'uspGetEmployeeManagers'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="employeeId">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateUspGetEmployeeManagersCall(IDataAccessCore dataAccessProvider, System.Int32 employeeId)
		{
			return new StoredProcedureCall(dataAccessProvider, "[AdventureWorks].[dbo].[uspGetEmployeeManagers]", "UspGetEmployeeManagers")
							.AddParameter("@EmployeeID", "Int", 0, ParameterDirection.Input, true, 0, 0, employeeId);
		}

		/// <summary>Creates the call object for the call 'UspGetManagerEmployees' to stored procedure 'uspGetManagerEmployees'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="managerId">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateUspGetManagerEmployeesCall(IDataAccessCore dataAccessProvider, System.Int32 managerId)
		{
			return new StoredProcedureCall(dataAccessProvider, "[AdventureWorks].[dbo].[uspGetManagerEmployees]", "UspGetManagerEmployees")
							.AddParameter("@ManagerID", "Int", 0, ParameterDirection.Input, true, 0, 0, managerId);
		}


		#region Included Code

		#endregion
	}
}
