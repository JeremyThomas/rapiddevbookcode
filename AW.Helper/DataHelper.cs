using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlLocalDb;
using System.Diagnostics;
using System.Linq;
using Microsoft.Win32;

namespace AW.Helper
{
  public enum DBSourceType
  {
    DBUnknown,
    DBSqlserver,
    DBOracle,
    DBUnsupported,
  }

  public static class DataHelper
  {
    /// <summary>
    ///   EXEC sp_MSforeachtable @command1 = 'ALTER TABLE ? {0} CONSTRAINT ALL'
    /// </summary>
    private const string SQLAlterAllConstraints = "EXEC sp_MSforeachtable @command1 = 'ALTER TABLE ? {0} CONSTRAINT ALL'";

    /// <summary>
    ///   EXEC sp_MSforeachtable @command1 = 'ALTER TABLE ? {0} TRIGGER ALL'
    /// </summary>
    private const string SQLAlterAllTriggers = "EXEC sp_MSforeachtable @command1 = 'ALTER TABLE ? {0} TRIGGER ALL'";

    /// <summary>
    ///   select * from
    /// </summary>
    public const string SQLSelectAllFrom = "select * from ";

    /// <summary>
    ///   Delete from
    /// </summary>
    public const string SQLDeleteFrom = "Delete from ";

    public static string SQLDisableAllTriggers
    {
      get { return String.Format(SQLAlterAllTriggers, "DISABLE"); }
    }

    public static string SQLEnableAllTriggers
    {
      get { return String.Format(SQLAlterAllTriggers, "ENABLE"); }
    }

    public static string SQLDisableAllConstraints
    {
      get { return String.Format(SQLAlterAllConstraints, "NOCHECK"); }
    }

    public static string SQLEnableAllConstraints
    {
      get { return String.Format(SQLAlterAllConstraints, "CHECK"); }
    }

    private const string MsOracleDataAccessClientProviderName = "System.Data.OracleClient";

    /// <summary>
    ///   Oracle.DataAccess.Client
    /// </summary>
    private const string OracleDataAccessClientProviderName = "Oracle.DataAccess.Client";

    /// <summary>
    ///   System.Data.SqlClient
    /// </summary>
    private const string SqlclientProviderName = "System.Data.SqlClient";

    /// <summary>
    ///   Initial Catalog
    /// </summary>
    public const string DBPropInitialCatalog = "Initial Catalog";

    /// <summary>
    ///   Initial File Name
    /// </summary>
    public const string DBPropinitialFileName = "Initial File Name";

    /// <summary>
    ///   Integrated Security"
    /// </summary>
    public const string DBPropIntegratedSecurity = "Integrated Security";

    /// <summary>
    ///   Extended properties"
    /// </summary>
    public const string DBPropExtendedProperties = "Extended Properties";

    /// <summary>
    ///   Password
    /// </summary>
    public static string DbpropAuthPassword = "Password";

    /// <summary>
    ///   Persist Security Info
    /// </summary>
    public static string DbpropAuthPersistSensitiveAuthinfo = "Persist Security Info";

    /// <summary>
    ///   Failover Partner
    /// </summary>
    public static string DbpropFailoverPartner = "Failover Partner";

    /// <summary>
    ///   User ID
    /// </summary>
    public static string DbpropAuthUserid = "User ID";

    /// <summary>
    ///   Data Source
    /// </summary>
    public static string DbPropDataSource = "Data Source";

    /// <summary>
    ///   Pooling
    /// </summary>
    public static string DbPropPooling = "Pooling";

    /// <summary>
    ///   Returns a value indicating whether one of the contained strings occurs within aString. Sames as
    ///   aString.Contains(value) except it is case-insensitive
    /// </summary>
    /// <param name="aString"> A string. </param>
    /// <param name="contained"> A list of possible substrings of to test for. </param>
    /// <returns> <c>true</c> if aString contains value; otherwise, <c>false</c> . </returns>
    public static Boolean Contains(string aString, params string[] contained)
    {
      var found = false;
      foreach (var s in contained)
      {
        found = aString.IndexOf(s, StringComparison.OrdinalIgnoreCase) > -1;
        if (found)
          break;
      }
      return found;
    }

    /// <summary>
    ///   Guesses the database type from a DB connection string
    /// </summary>
    /// <param name="sourceString"> A connection string. </param>
    /// <returns> The database type </returns>
    /// <remarks>
    ///   http://net-test2/mantis/view.php?id=5613
    /// </remarks>
    public static DBSourceType GetDBSourceType(string sourceString)
    {
      if (Contains(sourceString, "ORACLE", "MSDAORA"))
      {
        return DBSourceType.DBOracle;
      }
      return Contains(sourceString, "SQL") ? DBSourceType.DBSqlserver : DBSourceType.DBUnsupported;
    }

    public static DbConnectionStringBuilder CreateConnectionStringBuilder(string oleDBConnectionString)
    {
      return ConvertConnectionStringBuilder(new OleDbConnectionStringBuilder(oleDBConnectionString), GetDBSourceType(oleDBConnectionString));
    }

    /// <summary>
    ///   Converts the connection string builder from and OleDbConnectionStringBuilder to either a SqlConnectionStringBuilder
    ///   or a OracleConnectionStringBuilder.
    /// </summary>
    /// <param name="oleConnectionStringBuilder"> The OLEDB connection string builder. </param>
    /// <param name="dbType"> Type of the db. </param>
    /// <returns> </returns>
    public static DbConnectionStringBuilder ConvertConnectionStringBuilder(OleDbConnectionStringBuilder oleConnectionStringBuilder, DBSourceType dbType)
    {
      switch (dbType)
      {
        case DBSourceType.DBOracle:
        {
          DbProviderFactory oracleDbProviderFactory;
          var oracleDbProviderName = GetDBProviderName(dbType);
          try
          {
            oracleDbProviderFactory = DbProviderFactories.GetFactory(oracleDbProviderName);
          }
          catch (ArgumentException)
          {
            oracleDbProviderFactory = DbProviderFactories.GetFactory(MsOracleDataAccessClientProviderName);
          }
          var ocsb = oracleDbProviderFactory.CreateConnectionStringBuilder();
          if (ocsb != null)
          {
            ocsb["DATA SOURCE"] = oleConnectionStringBuilder.DataSource;
            if (oleConnectionStringBuilder.ContainsKey(DbpropAuthUserid))
            {
              var userID = (string) oleConnectionStringBuilder[DbpropAuthUserid];
              if (!String.IsNullOrEmpty(userID))
                ocsb[DbpropAuthUserid] = userID;
            }
            if (oleConnectionStringBuilder.ContainsKey(DbpropAuthPassword))
            {
              var password = (string) oleConnectionStringBuilder[DbpropAuthPassword];
              if (!String.IsNullOrEmpty(password))
                ocsb[DbpropAuthPassword] = password;
            }
          }
          return ocsb;
        }
        case DBSourceType.DBSqlserver:
        {
          var csb = new SqlConnectionStringBuilder {DataSource = oleConnectionStringBuilder.DataSource};
          var initialCatalog = (string) oleConnectionStringBuilder[DBPropInitialCatalog];
          if (!String.IsNullOrEmpty(initialCatalog))
            csb.InitialCatalog = initialCatalog;
          if (oleConnectionStringBuilder.ContainsKey(DBPropinitialFileName))
          {
            var attachDBFilename = (string) oleConnectionStringBuilder[DBPropinitialFileName];
            if (!String.IsNullOrEmpty(attachDBFilename))
              csb.AttachDBFilename = attachDBFilename;
          }
          var integratedSecurity = (string) oleConnectionStringBuilder[DBPropIntegratedSecurity];
          if (integratedSecurity.Equals("SSPI", StringComparison.OrdinalIgnoreCase) || integratedSecurity.Equals(Boolean.TrueString, StringComparison.OrdinalIgnoreCase))
            csb.IntegratedSecurity = true;
          else
          {
            csb.UserID = oleConnectionStringBuilder[DbpropAuthUserid].ToString();
            csb.Password = oleConnectionStringBuilder[DbpropAuthPassword].ToString();
          }
          return csb;
        }
      }
      return oleConnectionStringBuilder;
    }

    public static bool DBIsOracle(DbConnectionStringBuilder dbConnectionStringBuilder)
    {
      Debug.Assert(dbConnectionStringBuilder != null);
      return !(dbConnectionStringBuilder is SqlConnectionStringBuilder);
    }

    public static bool DBIsOracle(DBSourceType dBSourceType)
    {
      return dBSourceType == DBSourceType.DBOracle;
    }

    /// <summary>
    ///   Gets the name of the DB provider.
    /// </summary>
    /// <param name="dBSourceType"> Type of database source. </param>
    /// <returns> </returns>
    public static string GetDBProviderName(DBSourceType dBSourceType)
    {
      return DBIsOracle(dBSourceType) ? OracleDataAccessClientProviderName : SqlclientProviderName;
    }

    /// <summary>
    ///   Returns an instance of a DbProviderFactory if exists.
    /// </summary>
    /// <param name="providerInvariantName"> Name of the provider invariant. </param>
    /// <returns> An instance of a DbProviderFactory for a specified provider name. </returns>
    public static DbProviderFactory GetFactoryIfExists(string providerInvariantName)
    {
      var dataTable = DbProviderFactories.GetFactoryClasses();
      var providerRow = dataTable.Rows.Find(providerInvariantName);
      return providerRow == null ? null : GetFactoryIfExists(providerRow);
    }

    /// <summary>
    ///   Returns an instance of a DbProviderFactory if exists.
    /// </summary>
    /// <param name="providerRow">The provider row.</param>
    /// <returns></returns>
    public static DbProviderFactory GetFactoryIfExists(DataRow providerRow)
    {
      try
      {
        return DbProviderFactories.GetFactory(providerRow);
      }
      catch (Exception e)
      {
        e.TraceOut();
        return null;
      }
    }

    public static bool ServerNotFoundError(SqlException e)
    {
      return (e.Number == -1 || e.Number == 2) && e.State == 0 && string.IsNullOrWhiteSpace(e.Server);
    }

    public static bool DbNotFoundError(SqlException e)
    {
      return e.Number == 4060 && e.State == 1;
    }

    public static bool LogonError(SqlException e)
    {
      return e.Number == 233 && e.State == 0;
    }

    public static IEnumerable<string> GetSqlLocalDBAndLocalInstanceNames()
    {
      return GetSqlLocalDBInstanceNames().Union(GetSqlInstanceNames());
    }

    public static IEnumerable<string> GetSqlInstanceNames()
    {
      var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      try
      {
        var key = baseKey.OpenSubKey(@"SOFTWARE\" + MicrosoftMicrosoftSQLServerInstanceNamesSQL) ?? baseKey.OpenSubKey(@"SOFTWARE\Wow6432Node\" + MicrosoftMicrosoftSQLServerInstanceNamesSQL);
        if (key == null) yield break;
        try
        {
          foreach (var instanceName in key.GetValueNames().Where(instanceName => !String.IsNullOrWhiteSpace(instanceName)))
            yield return "MSSQLSERVER" == instanceName ? LocalInstancePrefix : LocalInstancePrefix + @"\" + instanceName;
        }
        finally
        {
          key.Close();
        }
      }
      finally
      {
        baseKey.Close();
      }
    }

    public static IEnumerable<string> GetSqlLocalDBInstanceNames()
    {
      var sqlLocalDbProvider = new SqlLocalDbProvider();
      return sqlLocalDbProvider.GetInstances().Where(sldb => !sldb.ConfigurationCorrupt).OrderByDescending(sldb => sldb.IsRunning).Select(GetInstanceName);
    }

    /// <summary>
    ///   (LocalDb)\\
    /// </summary>
    public const string LocalDBInstancePrefix = "(LocalDb)\\";

    /// <summary>
    ///   The local instance prefix (local)
    /// </summary>
    private const string LocalInstancePrefix = "(local)";

    /// <summary>
    ///   Microsoft\Microsoft SQL Server\Instance Names\SQL
    /// </summary>
    private const string MicrosoftMicrosoftSQLServerInstanceNamesSQL = @"Microsoft\Microsoft SQL Server\Instance Names\SQL";

    private static string GetInstanceName(ISqlLocalDbInstanceInfo localDbInstanceDataSource)
    {
      return LocalDBInstancePrefix + localDbInstanceDataSource.Name;
    }

    #region DbCommand

    /// <summary>
    ///   Executes a SQL statement against a connection object.
    /// </summary>
    /// .
    /// <param name="dbConnection"> The db connection. </param>
    /// <param name="commandText"> The command text. </param>
    /// <returns> The number of rows affected. </returns>
    public static int ExecuteNonQuery(DbConnection dbConnection, string commandText)
    {
      return ExecuteNonQuery(dbConnection, commandText, CommandType.Text);
    }

    /// <summary>
    ///   Executes a SQL statement against a connection object.
    /// </summary>
    /// <param name="dbConnection"> The db connection. </param>
    /// <param name="commandText"> The command text. </param>
    /// <param name="commandType"> Type of the command. </param>
    public static int ExecuteNonQuery(DbConnection dbConnection, string commandText, CommandType commandType)
    {
      var sqlCommand = CreateDbCommand(dbConnection, commandText, commandType);
      return sqlCommand.ExecuteNonQuery();
    }

    /// <summary>
    ///   Creates and returns a System.Data.Common.DbCommand object associated with the supplied connection.
    /// </summary>
    /// <param name="dbConnection"> The db connection. </param>
    /// <param name="commandText"> The command text. </param>
    /// <returns> </returns>
    public static DbCommand CreateDbCommand(DbConnection dbConnection, string commandText)
    {
      var command = dbConnection.CreateCommand();
      command.CommandText = commandText;
      return command;
    }

    /// <summary>
    ///   Creates and returns a System.Data.Common.DbCommand object associated with the supplied connection.
    /// </summary>
    /// <param name="dbConnection"> The db connection. </param>
    /// <param name="commandText"> The command text. </param>
    /// <param name="commandType"> Type of the command. </param>
    /// <returns> </returns>
    public static DbCommand CreateDbCommand(DbConnection dbConnection, string commandText, CommandType commandType)
    {
      var command = CreateDbCommand(dbConnection, commandText);
      command.CommandType = commandType;
      return command;
    }

    #endregion

    /// <summary>
    /// Loads the data row.
    /// </summary>
    /// <param name="table">The table.</param>
    /// <param name="values">The values.</param>
    /// <returns></returns>
    public static DataRow LoadDataRow(this DataTable table, IEnumerable<object> values)
    {
      return table.LoadDataRowWithValues(values.ToArray());
    }

    /// <summary>
    /// Loads the data row.
    /// </summary>
    /// <param name="table">The table.</param>
    /// <param name="values">The values.</param>
    /// <returns></returns>
    public static DataRow LoadDataRowWithValues(this DataTable table, params object[] values)
    {
      return table.LoadDataRow(values, true);
    }

    public static IEnumerable<DataTable> AsEnumerable(this DataTableCollection dataTableCollection)
    {
      return dataTableCollection.Cast<DataTable>();
    }

    public static IEnumerable<DataTable> AsEnumerable(this DataSet dataSet)
    {
      return dataSet.Tables.AsEnumerable();
    }

    public static IEnumerable<IDbDataParameter> AsEnumerable(this DbParameterCollection dbParameterCollection)
    {
      return dbParameterCollection.Cast<IDbDataParameter>();
    }

    /// <summary>
    ///   Gets the data row from a data row view.
    /// </summary>
    /// <param name="dataRowView">The data row view.</param>
    /// <returns></returns>
    public static T GetDataRowFromDataRowView<T>(DataRowView dataRowView) where T : DataRow
    {
      return dataRowView == null ? null : dataRowView.Row as T;
    }

    /// <summary>
    ///   Inserts the rows of the tables into the DB.
    /// </summary>
    /// <param name="tablesForInsert"> The tables for insert, the names of the tables must be the DB table names. </param>
    /// <param name="dbConnection"> The db connection. </param>
    /// <param name="dbProviderFactory"> The db provider factory. </param>
    /// <returns> </returns>
    public static int InsertTables(DataSet tablesForInsert, DbConnection dbConnection, DbProviderFactory dbProviderFactory)
    {
      return InsertTables(tablesForInsert.AsEnumerable(), dbConnection, dbProviderFactory);
    }

    public static int InsertTables(DbConnection dbConnection, DbProviderFactory dbProviderFactory, params DataTable[] dataTables)
    {
      return InsertTables(dataTables, dbConnection, dbProviderFactory);
    }

    private static int InsertTables(IEnumerable<DataTable> dataTables, DbConnection dbConnection, DbProviderFactory dbProviderFactory)
    {
      var insertCount = 0;
      using (var dbDataAdapter = (dbProviderFactory.CreateDataAdapter()))
        if (dbDataAdapter != null)
          using (dbDataAdapter.SelectCommand = dbConnection.CreateCommand())
            if (dbDataAdapter.SelectCommand != null)
              foreach (var table in dataTables.Where(dt => dt.Rows.Count > 0))
                using (var dbCommandBuilder = dbProviderFactory.CreateCommandBuilder())
                  if (dbCommandBuilder != null)
                  {
                    //DataSetHelper.SetAdded(table);
                    dbDataAdapter.SelectCommand.CommandText = SQLSelectAllFrom + table.TableName + " WHERE 1 = 2";
                    dbCommandBuilder.DataAdapter = dbDataAdapter;
                    using (dbDataAdapter.InsertCommand = dbCommandBuilder.GetInsertCommand())
                      insertCount += dbDataAdapter.Update(table);
                  }
      return insertCount;
    }
  }
}