using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace AW.Helper
{
  public static class GeneralHelper
  {
		/// <summary>
		/// Used for converting any spaces in the string version of an enum name to a substitute in the CLR enum name.
		/// </summary>
		/// <example>In_Progress -to- "In Progress"</example>
		public static readonly char EnumSpaceSubstitute = '_';
		public static readonly char EnumNumberPrefix = '_';
		public const string StringJoinSeperator = ", ";

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

		/// <summary>
		/// Converts the string to the enum.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="strOfEnum">The string version of the enum.</param>
		/// <returns></returns>
		public static T ToEnum<T>(this string strOfEnum)
		{
			return string.IsNullOrEmpty(strOfEnum) ? default(T) : strOfEnum.ToEnum<T>(EnumSpaceSubstitute);
		}

		/// <summary>
		/// Converts the string to the enum.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="strOfEnum">The string version of the enum.</param>
		/// <param name="spaceSubstitute">The space substitute.</param>
		/// <returns></returns>
		public static T ToEnum<T>(this string strOfEnum, char spaceSubstitute)
		{
			var fixedString = strOfEnum.Replace(' ', spaceSubstitute);
			if (Char.IsDigit(fixedString, 0))
			{
				int enumindex;
				if (int.TryParse(fixedString, out enumindex))
					return (T)Enum.ToObject(typeof(T), enumindex);
				fixedString = EnumNumberPrefix + fixedString;
			}
			return (T)Enum.Parse(typeof(T), fixedString, true);
		}

		public static string JoinAsString<T>(this IEnumerable<T> input)
		{
			return JoinAsString(input, StringJoinSeperator);
		}

		public static string JoinAsString<T>(this IEnumerable<T> input, string seperator)
		{
			var ar = input.Select(i => i.ToString()).ToArray();
			return String.Join(seperator, ar);
		}

    public static IEnumerable<T> SkipTake<T>(this IEnumerable<T> superset, int pageIndex, int pageSize) 
    {
      return superset.Skip(pageIndex * pageSize).Take(pageSize);
    }

    public static int GetPageCount(int pageSize, int totalItemCount)
    {
      if (totalItemCount > 0)
        return (int)Math.Ceiling(totalItemCount / (double)pageSize);
      return 0;
    }
  }
}
