using System.Data;
using System.Data.Common;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.DaoClasses
{
	public partial class CommonDaoBase
	{
		#region Overrides of DaoBase

		/// <summary>
		/// Executes the passed in action query and, if not null, runs it inside the passed in transaction.
		/// </summary>
		/// <param name="queryToExecute">ActionQuery to execute.</param><param name="containingTransaction">A containing transaction if caller is added to a transaction, or null of not.</param>
		/// <returns>
		/// execution result, which is the amount of rows affected (if applicable)
		/// </returns>
		public override int ExecuteActionQuery(IActionQuery queryToExecute, ITransaction containingTransaction)
		{
			QueryToSQL.LogQuery(queryToExecute);
			return base.ExecuteActionQuery(queryToExecute, containingTransaction);
		}

		/// <summary>
		/// Executes the passed in retrieval query and returns the results in thedatatable specified using the passed in data-adapter. 
		/// </summary>
		/// <param name="queryToExecute">Retrieval query to execute</param><param name="dataAdapterToUse">The dataadapter to use to fill the datatable.</param><param name="tableToFill">DataTable to fill</param><param name="fieldsToReturn">Fields persistence info objects for the fields used for the query. Required for type conversion on values.</param>
		/// <returns>
		/// true if succeeded, false otherwise
		/// </returns>
		public override bool ExecuteMultiRowDataTableRetrievalQuery(IRetrievalQuery queryToExecute, DbDataAdapter dataAdapterToUse, DataTable tableToFill, IEntityFields fieldsToReturn)
		{
			QueryToSQL.LogQuery(queryToExecute);
			return base.ExecuteMultiRowDataTableRetrievalQuery(queryToExecute, dataAdapterToUse, tableToFill, fieldsToReturn);
		}

		/// <summary>
		/// Executes the passed in retrieval query and, if not null, runs it inside the passed in transaction. Used to read 1 row.
		/// </summary>
		/// <param name="queryToExecute">Retrieval query to execute</param><param name="containingTransaction">A containing transaction if caller is added to a transaction, or null of not.</param><param name="collectionToFill">Collection to fill with the retrieved rows.</param><param name="allowDuplicates">Flag to signal if duplicates in the datastream should be loaded into the collection (true) or not (false)</param><param name="fieldsUsedForQuery">Fields used for producing the query</param><param name="fieldPersistenceInfos">The field persistence info objects used to produce the query. This array contains null for all excluded
		///             fields and is necessary for the row fetcher. Overriders of this method should pass fieldsToFill.GetAsPersistenceInfoArray() to this parameter</param>
		public override void ExecuteMultiRowRetrievalQuery(IRetrievalQuery queryToExecute, ITransaction containingTransaction, IEntityCollection collectionToFill, bool allowDuplicates, IEntityFields fieldsUsedForQuery, IFieldPersistenceInfo[] fieldPersistenceInfos)
		{
			QueryToSQL.LogQuery(queryToExecute);
			base.ExecuteMultiRowRetrievalQuery(queryToExecute, containingTransaction, collectionToFill, allowDuplicates, fieldsUsedForQuery, fieldPersistenceInfos);
		}

		/// <summary>
		/// Executes the passed in query as a scalar query and returns the value returned from this scalar execution. 
		/// </summary>
		/// <param name="queryToExecute">a scalar query, which is a SELECT query which returns a single value</param><param name="containingTransaction">A containing transaction if caller is added to a transaction, or null of not.</param>
		/// <returns>
		/// the scalar value returned from the query.
		/// </returns>
		public override object ExecuteScalarQuery(IRetrievalQuery queryToExecute, ITransaction containingTransaction)
		{
			QueryToSQL.LogQuery(queryToExecute);
			return base.ExecuteScalarQuery(queryToExecute, containingTransaction);
		}

		/// <summary>
		/// Executes the passed in retrieval query and, if not null, runs it inside the passed in transaction. Used to read 1 row.
		/// </summary>
		/// <param name="queryToExecute">Retrieval query to execute</param><param name="containingTransaction">A containing transaction if caller is added to a transaction, or null of not.</param><param name="fieldsToFill">The IEntityFields object to store the fetched data in</param><param name="fieldPersistenceInfos">The field persistence info objects used to produce the query. This array contains null for all excluded
		///             fields and is necessary for the row fetcher. Overriders of this method should pass fieldsToFill.GetAsPersistenceInfoArray() to this parameter</param>
		public override void ExecuteSingleRowRetrievalQuery(IRetrievalQuery queryToExecute, ITransaction containingTransaction, IEntityFields fieldsToFill, IFieldPersistenceInfo[] fieldPersistenceInfos)
		{
			QueryToSQL.LogQuery(queryToExecute);
			base.ExecuteSingleRowRetrievalQuery(queryToExecute, containingTransaction, fieldsToFill, fieldPersistenceInfos);
		}

		/// <summary>
		/// Performs the execute single row retrieval query action. This method simply calls Execute on the queryToExecute passed in. 
		/// </summary>
		/// <param name="queryToExecute">The query to execute.</param><param name="behavior">The commandbehavior to pass to Execute.</param>
		/// <returns>
		/// live datareader created by the execute method
		/// </returns>
		/// <remarks>
		/// Use this method to pass a different command behavior to queryToExecute.Execute(), which is necessary for ASE sybase for example, as the 
		///             Sybase ASE provider has a critical bug in some versions where SingleRow doesn't work but SingleResult will.
		/// </remarks>
		protected override IDataReader PerformExecuteSingleRowRetrievalQuery(IRetrievalQuery queryToExecute, CommandBehavior behavior)
		{
			QueryToSQL.LogQuery(queryToExecute);
			return base.PerformExecuteSingleRowRetrievalQuery(queryToExecute, behavior);
		}

		#endregion
	}
}