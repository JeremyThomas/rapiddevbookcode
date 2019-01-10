///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Configuration;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.DQE.Oracle;

namespace Northwind.DAL.Oracle
{
	
  // __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
  using AW.Helper;
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
		public static string ConnectionStringKeyName="ConnectionString.Oracle (ODP.NET)";
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

		/// <summary>Sets the default compatibility level used by the DQE. Default is Oracle9i10g11g. This is a global setting.
		/// Compatibility level influences the query generated for paging and identity sequence usage in inserts. </summary>
		/// <remarks>Setting this property will overrule a similar setting in the .config file. Don't set this property when queries are executed as
		/// it might switch factories for ADO.NET elements which could result in undefined behavior so set this property at startup of your application</remarks>
		public static void SetOracleCompatibilityLevel(OracleCompatibilityLevel compatibilityLevel)
		{
			DynamicQueryEngine.DefaultCompatibilityLevel = compatibilityLevel;
		} 

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
    private void OnExecuteQuery(IQuery query)
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
    /// Creates a new Select DQ for the fields passed in using the parameters specified.
    /// </summary>
    /// <param name="parameters">The parameters.</param>
    /// <returns>
    /// ready to use query to use.
    /// </returns>
    protected override IRetrievalQuery CreateSelectDQ(QueryParameters parameters)
    {
      var query = base.CreateSelectDQ(parameters);	
      OnExecuteQuery(query);
      return query;
    }

    static DataAccessAdapter()
    {
      StaticCustomFunctionMappings = new FunctionMappingStore();
      StaticCustomFunctionMappings.Add(new FunctionMapping(typeof(string), "IsNullOrEmpty", 1, "{0} IS NULL"));
      StaticCustomFunctionMappings.Add(new FunctionMapping(typeof(GeneralHelper), "ContainsIgnoreCase", 2, "REGEXP_LIKE({0},{1},'i')"));
      StaticCustomFunctionMappings.Add(new FunctionMapping(typeof(GeneralHelper), "EqualsIgnoreCase", 2, "UPPER({0}) = UPPER({1})"));
    }

    static readonly FunctionMappingStore StaticCustomFunctionMappings;

    // __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
