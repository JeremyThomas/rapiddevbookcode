using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using AW.Helper;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.DaoClasses
{
  public partial class CommonDaoBase
  {
    #region Overrides of DaoBase

    /// <summary>
    ///   Executes the passed in action query and, if not null, runs it inside the passed in transaction.
    /// </summary>
    /// <param name="queryToExecute">ActionQuery to execute.</param>
    /// <param name="containingTransaction">A containing transaction if caller is added to a transaction, or null of not.</param>
    /// <returns>
    ///   execution result, which is the amount of rows affected (if applicable)
    /// </returns>
    public override int ExecuteActionQuery(IActionQuery queryToExecute, ITransaction containingTransaction)
    {
      OnExecuteQuery(queryToExecute);
      return base.ExecuteActionQuery(queryToExecute, containingTransaction);
    }

    /// <summary>
    ///   Executes the passed in retrieval query and returns the results in thedatatable specified using the passed in
    ///   data-adapter.
    /// </summary>
    /// <param name="queryToExecute">Retrieval query to execute</param>
    /// <param name="dataAdapterToUse">The dataadapter to use to fill the datatable.</param>
    /// <param name="tableToFill">DataTable to fill</param>
    /// <param name="fieldsToReturn">
    ///   Fields persistence info objects for the fields used for the query. Required for type
    ///   conversion on values.
    /// </param>
    /// <returns>
    ///   true if succeeded, false otherwise
    /// </returns>
    public override bool ExecuteMultiRowDataTableRetrievalQuery(IRetrievalQuery queryToExecute, DbDataAdapter dataAdapterToUse, DataTable tableToFill, IEntityFields fieldsToReturn)
    {
      OnExecuteQuery(queryToExecute);
      return base.ExecuteMultiRowDataTableRetrievalQuery(queryToExecute, dataAdapterToUse, tableToFill, fieldsToReturn);
    }

    /// <summary>
    ///   Executes the passed in retrieval query and, if not null, runs it inside the passed in transaction. Used to read 1
    ///   row.
    /// </summary>
    /// <param name="queryToExecute">Retrieval query to execute</param>
    /// <param name="containingTransaction">A containing transaction if caller is added to a transaction, or null of not.</param>
    /// <param name="collectionToFill">Collection to fill with the retrieved rows.</param>
    /// <param name="allowDuplicates">
    ///   Flag to signal if duplicates in the datastream should be loaded into the collection
    ///   (true) or not (false)
    /// </param>
    /// <param name="fieldsUsedForQuery">Fields used for producing the query</param>
    /// <param name="fieldPersistenceInfos">
    ///   The field persistence info objects used to produce the query. This array contains null for all excluded
    ///   fields and is necessary for the row fetcher. Overriders of this method should pass
    ///   fieldsToFill.GetAsPersistenceInfoArray() to this parameter
    /// </param>
    public override void ExecuteMultiRowRetrievalQuery(IRetrievalQuery queryToExecute, ITransaction containingTransaction, IEntityCollection collectionToFill, bool allowDuplicates, IEntityFields fieldsUsedForQuery, IFieldPersistenceInfo[] fieldPersistenceInfos)
    {
      OnExecuteQuery(queryToExecute);
      base.ExecuteMultiRowRetrievalQuery(queryToExecute, containingTransaction, collectionToFill, allowDuplicates, fieldsUsedForQuery, fieldPersistenceInfos);
    }

    /// <summary>
    ///   Executes the passed in query as a scalar query and returns the value returned from this scalar execution.
    /// </summary>
    /// <param name="queryToExecute">a scalar query, which is a SELECT query which returns a single value</param>
    /// <param name="containingTransaction">A containing transaction if caller is added to a transaction, or null of not.</param>
    /// <returns>
    ///   the scalar value returned from the query.
    /// </returns>
    public override object ExecuteScalarQuery(IRetrievalQuery queryToExecute, ITransaction containingTransaction)
    {
      OnExecuteQuery(queryToExecute);
      return base.ExecuteScalarQuery(queryToExecute, containingTransaction);
    }

    /// <summary>
    ///   Executes the passed in retrieval query and, if not null, runs it inside the passed in transaction. Used to read 1
    ///   row.
    /// </summary>
    /// <param name="queryToExecute">Retrieval query to execute</param>
    /// <param name="containingTransaction">A containing transaction if caller is added to a transaction, or null of not.</param>
    /// <param name="fieldsToFill">The IEntityFields object to store the fetched data in</param>
    /// <param name="fieldPersistenceInfos">
    ///   The field persistence info objects used to produce the query. This array contains null for all excluded
    ///   fields and is necessary for the row fetcher. Overriders of this method should pass
    ///   fieldsToFill.GetAsPersistenceInfoArray() to this parameter
    /// </param>
    public override void ExecuteSingleRowRetrievalQuery(IRetrievalQuery queryToExecute, ITransaction containingTransaction, IEntityFields fieldsToFill, IFieldPersistenceInfo[] fieldPersistenceInfos)
    {
      OnExecuteQuery(queryToExecute);
      base.ExecuteSingleRowRetrievalQuery(queryToExecute, containingTransaction, fieldsToFill, fieldPersistenceInfos);
    }

    /// <summary>
    ///   Performs the execute single row retrieval query action. This method simply calls Execute on the queryToExecute passed
    ///   in.
    /// </summary>
    /// <param name="queryToExecute">The query to execute.</param>
    /// <param name="behavior">The commandbehavior to pass to Execute.</param>
    /// <returns>
    ///   live datareader created by the execute method
    /// </returns>
    protected override IDataReader PerformExecuteSingleRowRetrievalQuery(IRetrievalQuery queryToExecute, CommandBehavior behavior)
    {
      OnExecuteQuery(queryToExecute);
      return base.PerformExecuteSingleRowRetrievalQuery(queryToExecute, behavior);
    }

    public override DbConnection CreateConnection(string connectionString)
    {
      var dbConnection = base.CreateConnection(connectionString);
      try
      {
        dbConnection.Open();
        dbConnection.Close();
      }
      catch (SqlException e)
      {
        if (DataHelper.ServerNotFoundError(e) || DataHelper.DbNotFoundError(e))
        {
          dbConnection = ConnectToOtherLocalServers(connectionString);
          if (dbConnection != null)
            return dbConnection;
        }
        throw;
      }
      return dbConnection;
    }

    private DbConnection ConnectToOtherLocalServers(string connectionString)
    {
      var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
      var dataSource = sqlConnectionStringBuilder.DataSource;
      foreach (var sqlInstanceName in DataHelper.GetSqlLocalDBAndLocalInstanceNames().Where(sqlInstanceName => dataSource != sqlInstanceName))
      {
        sqlConnectionStringBuilder.DataSource = sqlInstanceName;
        connectionString = sqlConnectionStringBuilder.ConnectionString;
        try
        {
          var dbConnection = base.CreateConnection(connectionString);
          dbConnection.Open();
          dbConnection.Close();
          ActualConnectionString = connectionString;
          return dbConnection;
        }
        catch (SqlException e)
        {
          if (DataHelper.ServerNotFoundError(e) || DataHelper.DbNotFoundError(e))
            continue;
          throw;
        }
      }
      return null;
    }

    #endregion

    public void OnExecuteQuery(IQuery query)
    {
      SQLTraceEvent?.Invoke(this, new SQLTraceEventArgs(query));
    }

    public static event EventHandler<SQLTraceEventArgs> SQLTraceEvent;
  }
}