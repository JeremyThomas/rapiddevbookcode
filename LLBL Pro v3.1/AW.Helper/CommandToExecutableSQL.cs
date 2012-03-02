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
	/// <summary>
	/// 	Methods to get an executable SQL string from a Db Command for using in tracing etc. 
	/// <see cref="http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=15420" /> 
	/// <see cref="http://cs.rthand.com/blogs/blog_with_righthand/pages/Implementing-more-useful-tracing-for-LLBLGenPro-2.0.aspx" />
	/// </summary>
	public static class CommandToExecutableSQL
	{
		private static readonly string[] CommonKeywords = new[] {"FROM", "WHERE", "GROUP BY", "HAVING", "INNER JOIN", "LEFT JOIN", "RIGHT JOIN"};
		private static readonly string[] ActionKeywords = new[] {"INSERT INTO", "DELETE"};
		private static readonly string[] SelectKeywords = new[] {"SELECT DISTINCT", "SELECT"};

		/// <summary>
		/// Copy of "gudusoft.gsqlparser.TDbVendor
		/// </summary>
// ReSharper disable InconsistentNaming
		public enum TDbVendor : byte
// ReSharper restore InconsistentNaming
		{
			DbVMssql,
			DbVOracle,
			DbVMysql,
			DbVAccess,
			DbVGeneric,
			DbVDB2,
			DbVSybase,
			DbVInformix,
			DbVPostgresql,
			DbVfirebird,
			DbVMdx,
		}		
		
		public static void GetExecutableSQLFromQueryCommand(StringBuilder sb, DbCommand dbCommand)
		{
			var wrappedCommand = ProfilerHelper.GetWrappedCommand(dbCommand);
			if (wrappedCommand.CommandType == CommandType.StoredProcedure)
				DumpStoredProcedureRetrievalQuery(sb, wrappedCommand);
			else
				DumpSelectCommand(sb, wrappedCommand);
		}

		public static void GetExecutableSQLFromActionCommand(StringBuilder sb, DbCommand dbCommand)
		{
			var wrappedCommand = ProfilerHelper.GetWrappedCommand(dbCommand);
			var dbVendor = DetermineTDbVendor(wrappedCommand.GetType());
			var text = wrappedCommand.CommandText;
			text = DumpOrInlineParameters(sb, text, wrappedCommand, dbVendor);
			text = FormatSQL(text, ActionKeywords, dbVendor);
			sb.AppendLine(text);
		}

		private static void DumpStoredProcedureRetrievalQuery(StringBuilder sb, DbCommand dbCommand)
		{
			var dbVendor = DetermineTDbVendor(dbCommand.GetType());
			var text = DumpOrInlineParameters(sb, dbCommand.CommandText, dbCommand, dbVendor);
			sb.Append(text);
			sb.Append("(");

			for (var i = 0; i < dbCommand.Parameters.Count; i++)
			{
				if (i > 0)
					sb.Append(", ");
				sb.Append(((IDataParameter)dbCommand.Parameters[i]).ParameterName);
			}

			sb.AppendLine(")");
		}

		private static void DumpSelectCommand(StringBuilder sb, DbCommand dbCommand)
		{
			var text = dbCommand.CommandText;
			var dbVendor = DetermineTDbVendor(dbCommand.GetType());
			text = FormatSQL(text, SelectKeywords, dbVendor);
			text = DumpOrInlineParameters(sb, text, dbCommand, dbVendor);
			sb.AppendLine(text);
		}

		private static string FormatSQL(string text, string[] keywords, TDbVendor dbVendor)
		{
			if (!FormatSQLUsingTGSqlParser(ref text, dbVendor))
			{
				text = ReplaceAllWholeKeywords(text, "\r\n", "", keywords);
				text = ReplaceAllWholeKeywords(text, "\r\n", "\r\n ", CommonKeywords);
				text = ReplaceAllKeywords(text, "", "\r\n ", ",");
			}
			return text;
		}

		/// <summary>
		/// Formats the SQL using TG SQL parser.
		/// var sqlparser = new TGSqlParser(getDBVendor()) {SqlText = {Text = inputsql.Text}};
		/// var i = sqlparser.PrettyPrint();
		/// </summary>
		/// <param name="text">The text.</param>
		/// <param name="dbVendor">The db vendor.</param>
		/// <returns></returns>
		private static bool FormatSQLUsingTGSqlParser(ref string text, TDbVendor dbVendor)
		{
			var type = Type.GetType("gudusoft.gsqlparser.TGSqlParser, gudusoft.gsqlparser");
			if (type == null)
				return false;
			var sqlparser = Activator.CreateInstance(type, Enum.ToObject(type.Assembly.GetType("gudusoft.gsqlparser.TDbVendor"), (byte)dbVendor));
			var sqlTextPropertyInfo = type.GetProperty("SqlText");
			var sqlTextProperty = sqlTextPropertyInfo.GetValue(sqlparser, null);
			var textPropertyInfo = sqlTextProperty.GetType().GetProperty("Text");
			textPropertyInfo.SetValue(sqlTextProperty, text, null);
			var prettyPrintMethodInfo = type.GetMethod("PrettyPrint");
			var i = (int) prettyPrintMethodInfo.Invoke(sqlparser, null);
			if (i != 0)
				return false;
			{
				var formattedSqlTextPropertyInfo = type.GetProperty("FormattedSqlText");
				var formattedSqlTextProperty = formattedSqlTextPropertyInfo.GetValue(sqlparser, null);
				textPropertyInfo = formattedSqlTextProperty.GetType().GetProperty("Text");
				text = textPropertyInfo.GetValue(formattedSqlTextProperty, null) as string;
				return true;
			}
		}

		public static TDbVendor DetermineTDbVendor(Type commandType)
		{
			var databaseType = TDbVendor.DbVGeneric;
			switch (commandType.Namespace)
			{
				case "IBM.Data.DB2":
				case "DDTek.DB2":
					databaseType = TDbVendor.DbVDB2;
					break;
				case "FirebirdSql.Data.FirebirdClient":
					databaseType = TDbVendor.DbVfirebird;
					break;
				case "CoreLab.MySql":
				case "Devart.Data.MySql":
				case "MySql.Data.MySqlClient":
					databaseType = TDbVendor.DbVMysql;
					break;
				case "System.Data.OracleClient":
				case "Oracle.DataAccess.Client":
				case "DDTek.Oracle":
					databaseType = TDbVendor.DbVOracle;
					break;
				case "Npgsql":
				case "Devart.Data.PostgreSql":
					databaseType = TDbVendor.DbVPostgresql;
					break;
				case "System.Data.SqlServerCe":
				case "System.Data.SqlServerCe.3.5":
				case "System.Data.SqlServerCe.4.0":
				case "System.Data.SqlClient":
				case "DDTek.SQLServer":
				case "Devart.Data.SqlServer":
				case "iAnywhere.Data.SQLAnywhere":
					databaseType = TDbVendor.DbVMssql;
					break;
				case "Sybase.Data.AseClient":
				case "DDTek.Sybase":
					databaseType = TDbVendor.DbVSybase;
					break;
				default:			
					if (databaseType == TDbVendor.DbVGeneric)
			{
				var str = commandType.Name.ToLowerInvariant();
				if (str.Contains("db2"))
					databaseType = TDbVendor.DbVDB2;
				else if (str.Contains("firebird"))
					databaseType = TDbVendor.DbVfirebird;
				else if (str.Contains("mysql"))
					databaseType = TDbVendor.DbVMysql;
				else if (str.Contains("oracle"))
					databaseType = TDbVendor.DbVOracle;
				else if (str.Contains("postgres"))
					databaseType = TDbVendor.DbVPostgresql;
				else if (str.Contains("sqlserver"))
					databaseType = TDbVendor.DbVMssql;
				else if (str.Contains("ianywhere"))
					databaseType = TDbVendor.DbVSybase;
				else if (str.Contains("sybasease"))
					databaseType = TDbVendor.DbVSybase;
			}
					break;
			}
			return databaseType;
		}

		private static string DumpOrInlineParameters(StringBuilder sb, string text, DbCommand dbCommand, TDbVendor dbVendor)
		{
			return DumpOrInlineParameters(sb, text, dbVendor, dbCommand.Parameters);
		}

		private static string DumpOrInlineParameters(StringBuilder sb, string text, TDbVendor dbVendor, DbParameterCollection dbParameterCollection)
		{
			if (dbVendor == TDbVendor.DbVMssql)
				DumpParameters(sb, dbParameterCollection.AsEnumerable());
			else
				foreach (IDbDataParameter param in dbParameterCollection)
				{
					var value = ParameterValueToString(param);
					text = text.Replace(param.ParameterName + " ", value + " ");
					text = text.Replace(param.ParameterName + ",", value + ",");
				}
			return text;
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
				GeneralHelper.TraceOut(e.Message);
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