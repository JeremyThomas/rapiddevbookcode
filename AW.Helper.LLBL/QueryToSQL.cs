using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Helper.LLBL
{
	/// <summary>
	/// Methods to get an executable SQL string from a query for using in tracing etc.
	/// <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=15420"/>
	/// <see cref="http://cs.rthand.com/blogs/blog_with_righthand/pages/Implementing-more-useful-tracing-for-LLBLGenPro-2.0.aspx"/>
	/// </summary>
	public static class QueryToSQL
	{
		private static readonly string[] CommonKeywords = new[] {"FROM", "WHERE", "GROUP BY", "HAVING", "INNER JOIN", "LEFT JOIN", "RIGHT JOIN"};

		public static void LogQuery(IQuery query)
		{
			var dumpFormattedQuery = DynamicQueryEngineBase.Switch.TraceVerbose;
			if (!dumpFormattedQuery) DumpIfDebug(ref dumpFormattedQuery);

			if (dumpFormattedQuery)
			{
				var formattedQuery = GetExecutableSQLFromQuery(query);
				Trace.WriteLine(formattedQuery);
			}
		}

		[Conditional("DEBUG")]
		private static void DumpIfDebug(ref bool dumpFormattedQuery)
		{
			dumpFormattedQuery = true;
		}

		/// <summary>
		/// Gets SQL from query such that it can be executed/run.
		/// </summary>
		/// <param name="query">The query.</param>
		/// <returns>Executable SQL string</returns>
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
					if (query.Command.CommandType == CommandType.StoredProcedure)
					{
						DumpStoredProcedureRetrievalQuery(sb, query);
					}
					else
					{
						DumpRetrievalQuery(sb, query);
					}
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

		private static void DumpParameters(StringBuilder sb, IQuery query)
		{
			var sqlParam = new SqlParameter();

			foreach (IDbDataParameter param in query.Parameters)
				sb.AppendFormat("DECLARE {0} {1}; SET {0}={2}\r\n", param.ParameterName, GetSQLType(sqlParam, param), ParameterValueToString(param));
		}

		private static string GetSQLType(SqlParameter sqlParam, IDbDataParameter param)
		{
			var type = "Unknown";
			try
			{
				sqlParam.DbType = param.DbType;

				type = sqlParam.SqlDbType.ToString();
				if (param.Size != 0)
				{
					type += "(" + param.Size + ")";
				}
			}
			catch (Exception e)
			{
				Trace.WriteLine(e);
			}
			return type;
		}

		private static string ParameterValueToString(IDataParameter param)
		{
			string value;

			if ((param.Value == null) || (param.Value == DBNull.Value))
			{
				value = "null";
			}
			else
			{
				switch (param.DbType)
				{
					case DbType.VarNumeric:
					case DbType.Binary:
					case DbType.Object:
						value = "binary lob";
						break;

					case DbType.AnsiStringFixedLength:
					case DbType.StringFixedLength:
					case DbType.String:
					case DbType.AnsiString:
						value = String.Format("'{0}'", param.Value);
						break;

					case DbType.Boolean:
						value = Convert.ToBoolean(param.Value) ? "1" : "0";
						break;

					case DbType.DateTime:
						value = "'" + ((DateTime) param.Value).ToString("yyyyMMdd HH:mm:ss") + "'";
						break;

					case DbType.Date:
						value = "'" + ((DateTime) param.Value).ToString("dd/MM/yy") + "'";
						break;

					default:
						if (param.Value is Enum)
						{
							var paramAsEnum = (Enum) param.Value;
							value = String.Format("{0:d} /* {1}.{0:f} */", paramAsEnum, paramAsEnum.GetType().Name);
							break;
						}

						value = String.Format(CultureInfo.InvariantCulture, "{0}", param.Value);
						break;
				}
			}
			return value;
		}

		private static string ReplaceAllKeywords(this string text, string before, string after, params string[] keywords)
		{
			var text1 = text;
			return keywords.Where(text1.Contains).Aggregate(text, (current, keyword) => current.Replace(keyword, before + keyword + after));
		}

		private static string ReplaceAllWholeKeywords(this string text, string before, string after, params string[] keywords)
		{
			foreach (var keyword in keywords)
			{
				var wholeKeyword = " " + keyword + " ";
				if (!text.Contains(wholeKeyword)) continue;
				if (string.IsNullOrEmpty(before))
					before = " ";
				if (string.IsNullOrEmpty(after))
					after = " ";
				text = text.Replace(wholeKeyword, before + keyword + after);
			}
			return text;
		}

		private static void DumpStoredProcedureRetrievalQuery(StringBuilder sb, IQuery query)
		{
			DumpParameters(sb, query);

			sb.Append(query.Command.CommandText);
			sb.Append("(");

			for (var i = 0; i < query.Command.Parameters.Count; i++)
			{
				if (i > 0) sb.Append(", ");

				sb.Append(((IDataParameter) query.Command.Parameters[i]).ParameterName);
			}

			sb.Append(")");
			sb.Append("\r\n");
		}

		private static void DumpRetrievalQuery(StringBuilder sb, IQuery query)
		{
			var text = query.Command.CommandText;
			text = ReplaceAllWholeKeywords(text, "\r\n", "\r\n ", "SELECT DISTINCT", "SELECT");
			text = ReplaceAllWholeKeywords(text, "\r\n", "\r\n ", CommonKeywords);
			text = ReplaceAllKeywords(text, "", "\r\n ", ",");

			if (query.Connection is SqlConnection)
			{
				DumpParameters(sb, query);
			}
			else
			{
				foreach (IDbDataParameter param in query.Parameters)
				{
					var value = ParameterValueToString(param);
					text = text.Replace(param.ParameterName, value);
				}
			}

			sb.Append(text);
			sb.Append("\r\n");
		}

		private static void DumpBatchActionQuery(StringBuilder sb, BatchActionQuery batchActionQuery)
		{
			sb.AppendFormat("BatchAction Query (Count={0}):\r\n", batchActionQuery.Count);

			var part = 1;
			foreach (var actionQuery in batchActionQuery.ActionQueries)
			{
				sb.Append("\r\n Action Query #" + part++ + ":\r\n");

				DumpActionQueryCore(sb, actionQuery);
			}

			sb.Append("\r\n");
		}

		private static void DumpActionQuery(StringBuilder sb, IActionQuery query)
		{
			DumpActionQueryCore(sb, query);
		}

		private static void DumpActionQueryCore(StringBuilder sb, IActionQuery query)
		{
			DumpParameters(sb, query);

			var text = query.Command.CommandText;

			text = ReplaceAllWholeKeywords(text, "\r\n", "", "INSERT INTO", "DELETE");
			text = ReplaceAllWholeKeywords(text, "\r\n", "\r\n ", CommonKeywords);
			text = ReplaceAllKeywords(text, "", "\r\n ", ",");

			sb.Append(text);
			sb.Append("\r\n");
			var part = 1;
			foreach (var sequenceRetrievalQuery in query.SequenceRetrievalQueries)
			{
				sb.Append("\r\n Sequence Retrieval Query #" + part++ + ":\r\n" + sequenceRetrievalQuery.SequenceRetrievalCommand.CommandText);
			}
		}

	}
}