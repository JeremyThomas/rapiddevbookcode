using System;
using System.IO;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Helper.LLBL
{
  public class SQLTraceEventArgs : EventArgs
  {
    /// <summary>
    ///   SQLTraceEvent
    /// </summary>
    public const string SqlTraceEventName = "SQLTraceEvent";

    /// <summary>
    ///   SQLTrace
    /// </summary>
    private const string SQLTracePropertyName = "SQLTrace";

    /// <summary>
    ///   Query
    /// </summary>
    private const string QueryPropertyName = "Query";

    private string _sqlTrace;

    public string SQLTrace
    {
      get
      {
        if (String.IsNullOrEmpty(_sqlTrace) && Query != null)
          _sqlTrace = QueryToSQL.GetExecutableSQLFromQuery(Query);
        return _sqlTrace;
      }
      private set { _sqlTrace = value; }
    }

    private IQuery Query { get; set; }

    public SQLTraceEventArgs(IQuery query)
    {
      if (query == null) throw new ArgumentNullException("query");
      Query = query;
    }

    public SQLTraceEventArgs(string sqlTrace)
    {
      if (String.IsNullOrEmpty(sqlTrace)) throw new ArgumentNullException("sqlTrace");
      SQLTrace = sqlTrace;
    }

    public static void WriteSQLTranslation(TextWriter sqlTranslationWriter, EventArgs e)
    {
      if (sqlTranslationWriter != null && e != null)
      {
        var traceEventArgs = e as SQLTraceEventArgs;
        if (traceEventArgs != null)
        {
          var sqlTraceEventArgs = traceEventArgs;
          if (!String.IsNullOrEmpty(sqlTraceEventArgs.SQLTrace))
          {
            sqlTranslationWriter.WriteLine(sqlTraceEventArgs.SQLTrace);
            return;
          }
          if (sqlTraceEventArgs.Query != null)
            sqlTranslationWriter.WriteLine(QueryToSQL.GetExecutableSQLFromQuery(sqlTraceEventArgs.Query));
        }
        else
        {
          var sqlTracePi = e.GetType().GetProperty(SQLTracePropertyName);
          //var sqlTracePi = MetaDataHelper.GetMemberInfo<SQLTraceEventArgs>(ste => ste.SQLTrace) as PropertyInfo;
          if (sqlTracePi != null)
          {
            var sqlTrace = sqlTracePi.GetValue(e, null) as string;
            if (!String.IsNullOrEmpty(sqlTrace))
            {
              sqlTranslationWriter.WriteLine(sqlTrace);
              return;
            }
          }
          var queryPi = e.GetType().GetProperty(QueryPropertyName);
          //var queryPi = MetaDataHelper.GetMemberInfo<SQLTraceEventArgs>(ste => ste.Query) as PropertyInfo;
          if (queryPi != null)
          {
            var query = queryPi.GetValue(e, null) as IQuery;
            if (query != null)
              sqlTranslationWriter.WriteLine(QueryToSQL.GetExecutableSQLFromQuery(query));
          }
        }
      }
    }
  }
}