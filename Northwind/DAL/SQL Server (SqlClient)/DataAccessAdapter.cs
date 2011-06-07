///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: Tuesday, 7 June 2011 3:12:01 p.m.
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.EnterpriseServices;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.DQE.SqlServer;


namespace Northwind.DAL.SqlServer
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	using AW.Helper.LLBL;
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Data access adapter class, which controls the complete database interaction with the database for all objects.</summary>
	/// <remarks>Use a DataAccessAdapter object solely per thread, and per connection. A DataAccessAdapter object contains 1 active connection 
	/// and no thread-access scheduling code. This means that you need to create a new DataAccessAdapter object if you want to utilize
	/// in another thread a new connection and a new transaction or want to open a new connection.</remarks>
	public partial class DataAccessAdapter : DataAccessAdapterBase
	{
		#region Public static members
		/// <summary>The name of the key in the *.config file of the executing application which contains the connection string.</summary>
		/// <remarks>Default: the value set in the LLBLGen Pro project properties</remarks>
		public static string ConnectionStringKeyName="ConnectionString.SQL Server (SqlClient)";
		#endregion

		/// <summary>CTor</summary>
		public DataAccessAdapter() : this(ReadConnectionStringFromConfig(), false, null, null)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="keepConnectionOpen">when true, the DataAccessAdapter will not close an opened connection. Use this for multi action usage.</param>
		public DataAccessAdapter(bool keepConnectionOpen) : this(ReadConnectionStringFromConfig(), keepConnectionOpen, null, null)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		public DataAccessAdapter(string connectionString) : this(connectionString, false, null, null)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		/// <param name="keepConnectionOpen">when true, the DataAccessAdapter will not close an opened connection. Use this for multi action usage.</param>
		public DataAccessAdapter(string connectionString, bool keepConnectionOpen) : this(connectionString, keepConnectionOpen, null, null)
		{
		}
		
		/// <summary>CTor.</summary>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		/// <param name="keepConnectionOpen">when true, the DataAccessAdapter will not close an opened connection. Use this for multi action usage.</param>
		/// <param name="catalogNameUsageSetting"> Configures this data access adapter object how to threat catalog names in persistence information.</param>
		/// <param name="catalogNameToUse"> The name to use if catalogNameUsageSetting is set to ForceName. Ignored otherwise.</param>
		/// <remarks>For backwards compatibility.</remarks>
		public DataAccessAdapter(string connectionString, bool keepConnectionOpen, CatalogNameUsage catalogNameUsageSetting, string catalogNameToUse) 
				: base(PersistenceInfoProviderSingleton.GetInstance())
		{
			InitClassPhase2(connectionString, keepConnectionOpen, catalogNameUsageSetting, SchemaNameUsage.Default, catalogNameToUse, string.Empty, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		/// <param name="keepConnectionOpen">when true, the DataAccessAdapter will not close an opened connection. Use this for multi action usage.</param>
		/// <param name="schemaNameUsageSetting">Configures this data access adapter object how to threat schema names in persistence information.</param>
		/// <param name="schemaNameToUse">Oracle specific. The name to use if schemaNameUsageSetting is set to ForceName. Ignored otherwise.</param>
		public DataAccessAdapter(string connectionString, bool keepConnectionOpen, SchemaNameUsage schemaNameUsageSetting, string schemaNameToUse) 
				: base(PersistenceInfoProviderSingleton.GetInstance())
		{
			InitClassPhase2(connectionString, keepConnectionOpen, CatalogNameUsage.Default, schemaNameUsageSetting, string.Empty, schemaNameToUse, null, null);
		}

		/// <summary>CTor.</summary>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		/// <param name="keepConnectionOpen">when true, the DataAccessAdapter will not close an opened connection. Use this for multi action usage.</param>
		/// <param name="catalogNameOverwrites"> The from-to name value pairs and setting for the overwriting of catalog names. Can be null.</param>
		/// <param name="schemaNameOverwrites"> The from-to name value pairs and setting for the overwriting of schema names. Can be null.</param>
		public DataAccessAdapter(string connectionString, bool keepConnectionOpen, CatalogNameOverwriteHashtable catalogNameOverwrites, SchemaNameOverwriteHashtable schemaNameOverwrites) 
				: base(PersistenceInfoProviderSingleton.GetInstance())
		{
			InitClassPhase2(connectionString, keepConnectionOpen, CatalogNameUsage.Default, SchemaNameUsage.Default, string.Empty, string.Empty, catalogNameOverwrites, schemaNameOverwrites);
		}
		/// <summary>CTor</summary>
		/// <param name="comPlusContextHost">the COM+ context host for this adapter instance.</param>
		internal DataAccessAdapter(IComPlusAdapterContext comPlusContextHost) : base(comPlusContextHost, PersistenceInfoProviderSingleton.GetInstance())
		{
			InitClassPhase2(ReadConnectionStringFromConfig(), false, CatalogNameUsage.Default, SchemaNameUsage.Default, string.Empty, String.Empty, null, null);
		}

#if !CF
		/// <summary>Sets the flag to signal the SqlServer DQE to generate SET ARITHABORT ON statements prior to INSERT, DELETE and UPDATE Queries.
		/// Keep this flag to false in normal usage, but set it to true if you need to write into a table which is part of an indexed view.
		/// It will not affect normal inserts/updates that much, leaving it on is not harmful. See Books online for details on SET ARITHABORT ON.
		/// After each statement the setting is turned off if it has been turned on prior to that statement.</summary>
		/// <remarks>Setting this flag is a global change.</remarks>
		public static void SetArithAbortFlag(bool value)
		{
			DynamicQueryEngine.ArithAbortOn = value;
		}

		/// <summary>Sets the default compatibility level used by the DQE. Default is SqlServer2005. This is a global setting.
		/// Compatibility level influences the query generated for paging, sequence name (@@IDENTITY/SCOPE_IDENTITY()), and usage of newsequenceid() in inserts. 
		/// It also influences the ado.net provider to use. This way you can switch between SqlServer server client 'SqlClient' and SqlServer CE Desktop.</summary>
		/// <remarks>Setting this property will overrule a similar setting in the .config file. Don't set this property when queries are executed as
		/// it might switch factories for ADO.NET elements which could result in undefined behavior so set this property at startup of your application</remarks>
		public static void SetSqlServerCompatibilityLevel(SqlServerCompatibilityLevel compatibilityLevel)
		{
			DynamicQueryEngine.DefaultCompatibilityLevel = compatibilityLevel;
		}
#endif 
		/// <summary>Creates a new Dynamic Query engine object and passes in the defined catalog/schema overwrite hashtables.</summary>
		protected override DynamicQueryEngineBase CreateDynamicQueryEngine()
		{
			return this.PostProcessNewDynamicQueryEngine(new DynamicQueryEngine());
		}

		/// <summary>Reads the value of the setting with the key ConnectionStringKeyName from the *.config file and stores that value as the active connection string to use for this object.</summary>
		/// <returns>connection string read</returns>
		private static string ReadConnectionStringFromConfig()
		{
			return ConfigFileHelper.ReadConnectionStringFromConfig(ConnectionStringKeyName);
		}
		
		/// <summary>Sets the per instance compatibility level on the dqe instance specified.</summary>
		/// <param name="dqe">The dqe.</param>
		protected override void SetPerInstanceCompatibilityLevel(DynamicQueryEngineBase dqe)
		{
			if(_compatibilityLevel.HasValue)
			{
				((DynamicQueryEngine)dqe).CompatibilityLevel = _compatibilityLevel.Value;
			}
		}
 
		private Nullable<SqlServerCompatibilityLevel> _compatibilityLevel = null;
		
		/// <summary>The per-instance compatibility level used by this DQE instance. Default is the one set globally, which is by default SqlServer2005 (for 2005+). 
		/// Compatibility level influences the query generated for paging, sequence name (@@IDENTITY/SCOPE_IDENTITY()), and usage of newsequenceid() in inserts. 
		/// It also influences the ado.net provider to use. This way you can switch between SqlServer server client 'SqlClient' and SqlServer CE Desktop.</summary>
		public Nullable<SqlServerCompatibilityLevel> CompatibilityLevel
		{
			get { return _compatibilityLevel; }
			set { _compatibilityLevel = value; }
		}

		#region Custom DataAccessAdapter code.
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomDataAccessAdapterCode

		/// <summary>
		/// Event which is raised whenever a query is executed. Use this event to perform SQL tracing. 
		/// </summary>
		public event EventHandler<SQLTraceEventArgs> SQLTraceEvent;

		/// <summary>
		/// Called whenever a query is executed.
		/// </summary>
		/// <param name="query">The query.</param>
		protected void OnExecuteQuery(IQuery query)
		{
			if (SQLTraceEvent != null)
				SQLTraceEvent(this, new SQLTraceEventArgs(query));
		}

		/// <summary>
		/// 	Executes the passed in action query and, if not null, runs it inside the passed in transaction.
		/// </summary>
		/// <param name = "queryToExecute">ActionQuery to execute.</param>
		/// <returns>execution result, which is the amount of rows affected (if applicable)</returns>
		public override int ExecuteActionQuery(IActionQuery queryToExecute)
		{
			OnExecuteQuery(queryToExecute);
			return base.ExecuteActionQuery(queryToExecute);
		}

		/// <summary>
		/// 	Creates a new Select DQ for the fields passed in using the parameters specified.
		/// </summary>
		/// <param name = "fieldsToFetch">fields to fetch using the select</param>
		/// <param name = "persistenceInfoObjects">persistence info objects for the fields</param>
		/// <param name = "filter">filter to use for the where clause</param>
		/// <param name = "maxNumberOfItemsToReturn">max. amount of rows to return</param>
		/// <param name = "sortClauses">sort clause specifications to use</param>
		/// <param name = "relationsToWalk">relations to walk to build the FROM clause</param>
		/// <param name = "allowDuplicates">flag to specify if duplicates should be returned</param>
		/// <param name = "groupByClause">group by clause to embed in the query</param>
		/// <param name = "pageNumber">The page number to retrieve</param>
		/// <param name = "pageSize">the page size to retrieve</param>
		/// <returns>ready to use query to use.</returns>
		protected override IRetrievalQuery CreateSelectDQ(IEntityFields2 fieldsToFetch, IFieldPersistenceInfo[] persistenceInfoObjects,
																											IPredicateExpression filter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relationsToWalk,
																											bool allowDuplicates, IGroupByCollection groupByClause, int pageNumber, int pageSize)
		{
			var query = base.CreateSelectDQ(fieldsToFetch, persistenceInfoObjects, filter, maxNumberOfItemsToReturn, sortClauses, relationsToWalk,
																			allowDuplicates, groupByClause, pageNumber, pageSize);
			OnExecuteQuery(query);
			return query;
		}

		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}

	/// <summary>ComPlusAdapterContext class which is used in Adapter for hosting a COM+ aware DataAccessAdapter class. Use the hosted DataAccessAdapter class to start a new COM+ transaction.</summary>
	public partial class ComPlusAdapterContext : ComPlusAdapterContextBase
	{
		/// <summary>CTor</summary>
		public ComPlusAdapterContext()
		{
			this.SetAdapter(new DataAccessAdapter(this));
		}
	}
}
