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
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.HelperClasses
{
	/// <summary>
	/// General utility methods used for SqlServer usage by the framework. 
	/// </summary>
	public class DbUtils
	{
		#region Public Static Members
		public static string ActualConnectionString = string.Empty;
		#endregion

		#region Constants
		private const string connectionKeyString = "Main.ConnectionString";
		#endregion

		#region Class Member Declarations
		private static int _commandTimeOut = 30;
		#endregion

		/// <summary>
		/// Private CTor, no instatiation possible
		/// </summary>
		private DbUtils()
		{
		}


		/// <summary>
		/// Sets the flag to signal the SqlServer DQE to generate SET ARITHABORT ON statements prior to INSERT, DELETE and UPDATE Queries.
		/// Keep this flag to false in normal usage, but set it to true if you need to write into a table which is part of an indexed view.
		/// It will not affect normal inserts/updates that much, leaving it on is not harmful. See Books online for details on SET ARITHABORT ON.
		/// After each statement the setting is turned off if it has been turned on prior to that statement.
		/// </summary>
		/// <remarks>Setting this flag is a global change.</remarks>
		public static void SetArithAbortFlag(bool value)
		{
			SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.ArithAbortOn = value;
		}


		/// <summary>
		/// Creates a new SqlConnection
		/// </summary>
		/// <param name="connectionString">Conectionstring To use</param>
		/// <returns>A ready to use, closed, sqlconnection object</returns>
		public static SqlConnection CreateConnection(string connectionString)
		{
			return new SqlConnection(connectionString);
		}


		/// <summary>
		/// Creates a new closed SqlConnection object based on the connection string read from the *.config file of the appdomain.
		/// The connection string is stored in a key with the name defined in the constant connectionKeyString, mentioned above.
		/// </summary>
		/// <returns>A ready to use, closed, sqlconnection object</returns>
		public static SqlConnection CreateConnection()
		{
			if(ActualConnectionString==string.Empty)
			{
				// read the connection string from the *.config file.
				AppSettingsReader configReader = new AppSettingsReader();
				ActualConnectionString = configReader.GetValue(connectionKeyString, typeof(string)).ToString();
			}

			return CreateConnection(ActualConnectionString);
		}


		/// <summary>
		/// Determines which connection to use: the connection held by the passed in transaction (if any) or a new one (if no Transaction was passed in)
		/// </summary>
		/// <param name="containingTransaction">A transaction the caller participates in. If null, the caller is not participating in a transaction</param>
		/// <returns>A ready to use connection object</returns>
		public static IDbConnection DetermineConnectionToUse(ITransaction containingTransaction)
		{
			if(containingTransaction!=null)
			{
				return containingTransaction.ConnectionToUse;
			}
			else
			{
				return CreateConnection();
			}
		}


		/// <summary>
		/// Creates a new SqlDataAdapter.
		/// </summary>
		/// <returns></returns>
		public static SqlDataAdapter CreateDataAdapter()
		{
			return new SqlDataAdapter();
		}


		/// <summary>
		/// Creates a new SqlServer transaction
		/// </summary>
		/// <param name="connectionToUse">the connection to use</param>
		/// <param name="isolationLevelToUse">the isolation level to use</param>
		/// <param name="name">the name for the transaction</param>
		/// <returns>new SqlTransaction object.</returns>
		public static SqlTransaction CreateTransaction(IDbConnection connectionToUse, IsolationLevel isolationLevelToUse, string name)
		{
			return ((SqlConnection)connectionToUse).BeginTransaction(isolationLevelToUse, name);
		}


		/// <summary>
		/// Calls the specified action stored procedure in the SqlServer database a newly created connection is connecting to. 
		/// </summary>
		/// <param name="storedProcedureToCall">Stored procedure to call</param>
		/// <param name="parameters">array of parameters to specify</param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>the amount of rows affected. This value will be -1 if the stored procedure sets ROWCOUNT to OFF or this has
		/// been disabled in the catalog by other settings.</returns>
		public static int CallActionStoredProcedure(string storedProcedureToCall, SqlParameter[] parameters, ITransaction transactionToUse )
		{
			SqlCommand command = null;
			bool connectionOpenedLocally = false;
			string procName = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName(storedProcedureToCall);
			if(transactionToUse!=null)
			{
				command = new SqlCommand(procName, (SqlConnection)transactionToUse.ConnectionToUse);
				command.Transaction = (SqlTransaction)transactionToUse.PhysicalTransaction;
			}
			else
			{
				command = new SqlCommand(procName, CreateConnection());
			}
			command.CommandType = CommandType.StoredProcedure;
			command.CommandTimeout = _commandTimeOut;

			int toReturn = -1;
			try
			{
				for(int i=0;i<parameters.Length;i++)
				{
					command.Parameters.Add(parameters[i]);
				}

				if(command.Connection.State!=ConnectionState.Open)
				{
					command.Connection.Open();
					connectionOpenedLocally = true;
				}
				toReturn = command.ExecuteNonQuery();
			}
			finally
			{
				if(connectionOpenedLocally)
				{
					command.Connection.Close();
				}
			}
			return toReturn;
		}


		/// <summary>
		/// Calls the specified retrieval stored procedure in the SqlServer database a newly created connection is connecting to. Fills the
		/// specified datatable. 
		/// </summary>
		/// <param name="storedProcedureToCall">Stored procedure to call</param>
		/// <param name="parameters">array of parameters to specify</param>
		/// <param name="tableToFill">Datatable to fill by the stored procedure</param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public static bool CallRetrievalStoredProcedure(string storedProcedureToCall, SqlParameter[] parameters, DataTable tableToFill, ITransaction transactionToUse)
		{
			SqlCommand command = null;
			string procName = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName(storedProcedureToCall);
			if(transactionToUse!=null)
			{
				command = new SqlCommand(procName, (SqlConnection)transactionToUse.ConnectionToUse);
				command.Transaction = (SqlTransaction)transactionToUse.PhysicalTransaction;
			}
			else
			{
				command = new SqlCommand(procName, CreateConnection());
			}
			command.CommandType = CommandType.StoredProcedure;
			command.CommandTimeout = _commandTimeOut;

			SqlDataAdapter adapter = new SqlDataAdapter(command);
			for(int i=0;i<parameters.Length;i++)
			{
				command.Parameters.Add(parameters[i]);
			}
			adapter.Fill(tableToFill);

			return true;
		}


		/// <summary>
		/// Calls the specified retrieval stored procedure in the SqlServer database a newly created connection is connecting to. Fills the
		/// specified DataSet. 
		/// </summary>
		/// <param name="storedProcedureToCall">Stored procedure to call</param>
		/// <param name="parameters">array of parameters to specify</param>
		/// <param name="dataSetToFill">DataSet to fill by the stored procedure</param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public static bool CallRetrievalStoredProcedure(string storedProcedureToCall, SqlParameter[] parameters, DataSet dataSetToFill, ITransaction transactionToUse)
		{
			SqlCommand command = null;
			string procName = SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.GetNewStoredProcedureName(storedProcedureToCall);
			if(transactionToUse!=null)
			{
				command = new SqlCommand(procName, (SqlConnection)transactionToUse.ConnectionToUse);
				command.Transaction = (SqlTransaction)transactionToUse.PhysicalTransaction;
			}
			else
			{
				command = new SqlCommand(procName, CreateConnection());
			}
			command.CommandType = CommandType.StoredProcedure;
			command.CommandTimeout = _commandTimeOut;

			SqlDataAdapter adapter = new SqlDataAdapter(command);
			for(int i=0;i<parameters.Length;i++)
			{
				command.Parameters.Add(parameters[i]);
			}
			adapter.Fill(dataSetToFill);

			return true;
		}


		#region Class Property Declarations
		/// <summary>
		/// Gets / sets the command time out (in seconds). This is a global setting, so every Command object created after you've set this
		/// property to a value will have that value as CommandTimeOut. Default is 30 seconds which is the ADO.NET default.
		/// </summary>
		public static int CommandTimeOut
		{
			get
			{
				return _commandTimeOut;
			}
			set
			{
				_commandTimeOut = value;
				SD.LLBLGen.Pro.DQE.SqlServer.DynamicQueryEngine.CommandTimeOut = _commandTimeOut;
			}
		}
		#endregion


		#region Included Code

		#endregion
	}
}
