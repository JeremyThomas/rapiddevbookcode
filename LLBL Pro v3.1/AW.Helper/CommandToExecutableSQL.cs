using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace AW.Helper
{
	public static class CommandToExecutableSQL
	{
		private static readonly string[] CommonKeywords = new[] {"FROM", "WHERE", "GROUP BY", "HAVING", "INNER JOIN", "LEFT JOIN", "RIGHT JOIN"};

		public static void GetExecutableSQLFromActionCommand(StringBuilder sb, DbCommand dbCommand)
		{
			var text = dbCommand.CommandText;
			DumpParameters(sb, (IEnumerable<IDbDataParameter>)dbCommand.Parameters);
			text = ReplaceAllWholeKeywords(text, "\r\n", "", "INSERT INTO", "DELETE");
			text = ReplaceAllWholeKeywords(text, "\r\n", "\r\n ", CommonKeywords);
			text = ReplaceAllKeywords(text, "", "\r\n ", ",");

			sb.AppendLine(text);
		}

		public static void GetExecutableSQLFromQueryCommand(StringBuilder sb, DbCommand dbCommand)
		{
			if (dbCommand.CommandType == CommandType.StoredProcedure)
				DumpStoredProcedureRetrievalQuery(sb, dbCommand);
			else
				DumpSelectCommand(sb, dbCommand);
		}

		private static void DumpStoredProcedureRetrievalQuery(StringBuilder sb, DbCommand dbCommand)
		{
			DumpParameters(sb, (IEnumerable<IDbDataParameter>) dbCommand.Parameters);
			sb.Append(dbCommand.CommandText);
			sb.Append("(");

			for (var i = 0; i < dbCommand.Parameters.Count; i++)
			{
				if (i > 0) sb.Append(", ");
				sb.Append(((IDataParameter) dbCommand.Parameters[i]).ParameterName);
			}

			sb.AppendLine(")");
		}

		private static void DumpSelectCommand(StringBuilder sb, DbCommand dbCommand)
		{
			var text = dbCommand.CommandText;
			text = ReplaceAllWholeKeywords(text, "\r\n", "\r\n ", "SELECT DISTINCT", "SELECT");
			text = ReplaceAllWholeKeywords(text, "\r\n", "\r\n ", CommonKeywords);
			text = ReplaceAllKeywords(text, "", "\r\n ", ",");

			if (dbCommand.Connection is SqlConnection)
				DumpParameters(sb, (IEnumerable<IDbDataParameter>) dbCommand.Parameters);
			else
				foreach (IDbDataParameter param in dbCommand.Parameters)
				{
					var value = ParameterValueToString(param);
					text = text.Replace(param.ParameterName, value);
				}

			sb.AppendLine(text);
		}

		private static void DumpParameters(StringBuilder sb, IEnumerable<IDbDataParameter> parameters)
		{
			var sqlParam = new SqlParameter();
			foreach (var param in parameters)
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
						value = "'" + ((DateTime)param.Value).ToString("yyyyMMdd HH:mm:ss") + "'";
						break;

					case DbType.Date:
						value = "'" + ((DateTime)param.Value).ToString("dd/MM/yy") + "'";
						break;

					default:
						var paramAsEnum = param.Value as Enum;
						if (paramAsEnum != null)
						{
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
				if (String.IsNullOrEmpty(before))
					before = " ";
				if (String.IsNullOrEmpty(after))
					after = " ";
				text = text.Replace(wholeKeyword, before + keyword + after);
			}
			return text;
		}

	}
}
