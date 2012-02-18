using System;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Helper.LLBL
{
	/// <summary>
	/// 	Methods to get an executable SQL string from a query for using in tracing etc. 
	///  	<see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=15420" /> 
	///  	<see cref="http://cs.rthand.com/blogs/blog_with_righthand/pages/Implementing-more-useful-tracing-for-LLBLGenPro-2.0.aspx" />
	/// </summary>
	public static class QueryToSQL
	{
		/// <summary>
		/// 	Gets SQL from query such that it can be executed/run.
		/// </summary>
		/// <param name="query"> The query. </param>
		/// <returns> Executable SQL string </returns>
		public static string GetExecutableSQLFromQuery(IQuery query)
		{
			try
			{
				var sb = new StringBuilder();

				if (query is IActionQuery)
				{
					if (query is BatchActionQuery)
					{
						DumpBatchActionQuery(sb, query as BatchActionQuery);
					}
					else
					{
						DumpActionQuery(sb, (IActionQuery) query);
					}
				}
				else if (query is IRetrievalQuery)
				{
					CommandToExecutableSQL.GetExecutableSQLFromQueryCommand(sb, query.Command);
				}
				else
				{
					sb.Append("** Unknown query type **");
				}

				return sb.ToString();
			}
			catch (Exception ex)
			{
				return "** Exception occurred during GetExecutableSQLFromQuery: " + ex.Message + "**";
			}
		}

		private static void DumpBatchActionQuery(StringBuilder sb, BatchActionQuery batchActionQuery)
		{
			sb.AppendFormat("BatchAction Query (Count={0}):\r\n", batchActionQuery.Count);

			var part = 1;
			foreach (var actionQuery in batchActionQuery.ActionQueries)
			{
				sb.Append("\r\n Action Query #" + part++ + ":\r\n");
				DumpActionQuery(sb, actionQuery);
			}

			sb.AppendLine();
		}

		private static void DumpActionQuery(StringBuilder sb, IActionQuery query)
		{
			CommandToExecutableSQL.GetExecutableSQLFromActionCommand(sb, query.Command);
			var part = 1;
			foreach (var sequenceRetrievalQuery in query.SequenceRetrievalQueries)
				sb.Append("\r\n Sequence Retrieval Query #" + part++ + ":\r\n" + sequenceRetrievalQuery.SequenceRetrievalCommand.CommandText);
		}
	}
}