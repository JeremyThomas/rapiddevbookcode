using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace AW.Helper
{
  public static class GeneralHelper
  {
    #region Debuging

    /// <summary>
    /// Sends a msg to the Win32 debug output and prefixs it with the name off the method that called TraceOut
    /// </summary>
    /// <param name="msg">The message.</param>
    public static void TraceOut(string msg)
    {
      Trace.WriteLine(new StackTrace(false).GetFrame(1).GetMethod().Name + ": " + msg);
    }

    public static void DebugOut(string msg)
    {
      Debug.WriteLine(new StackTrace(false).GetFrame(1).GetMethod().Name + ": " + msg);
    }

    #endregion

    public static void ApplicationOutputLogLine(string lineToLog, string source, bool isVerboseMessage, bool appendNewLine)
    {
      if (appendNewLine)
        Trace.WriteLine(lineToLog);
      else
        Trace.Write(lineToLog);
    }
  }
}
