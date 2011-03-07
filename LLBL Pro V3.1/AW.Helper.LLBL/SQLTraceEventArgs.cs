using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Helper.LLBL
{
	public class QueryTraceEventArgs : EventArgs
	{
		public QueryTraceEventArgs(IQuery query)
		{
			if (query == null) throw new ArgumentNullException("query");
			Query = query;
		}

		public IQuery Query { get; private set; }
	}

	public class SQLTraceEventArgs : EventArgs
	{
		private string _sqlTrace;

		public string SQLTrace
		{
			get
			{
				if (string.IsNullOrEmpty(_sqlTrace) && Query != null)
					_sqlTrace = QueryToSQL.GetExecutableSQLFromQuery(Query);
				return _sqlTrace;
			}
			private set { _sqlTrace = value; }
		}

		public IQuery Query { get; private set; }

		public SQLTraceEventArgs(IQuery query)
		{
			if (query == null) throw new ArgumentNullException("query");
			Query = query;
		}

		public SQLTraceEventArgs(string sqlTrace)
		{
			if (string.IsNullOrEmpty(sqlTrace)) throw new ArgumentNullException("sqlTrace");
			SQLTrace = sqlTrace;
		}
	}
}