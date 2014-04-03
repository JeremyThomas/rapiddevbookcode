using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JesseJohnston
{
  public static class ObjectListViewHelper
  {
    private static readonly string[] StringsToQuoteForCsv = {",", Environment.NewLine};

    /// <summary>
    ///   Creates the visualizer form filled with either a ObjectListView or a ObjectListView<>.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns></returns>
    public static Form CreateVisualizerForm(object data)
    {
      Form visualizerForm = null;
      var objectListView = data as ObjectListView;
      if (objectListView != null)
        visualizerForm = new VisualizerForm {View = objectListView};
      else
      {
        // If ObjectListView<T>
        var dataType = data.GetType();

        if (dataType.IsGenericType && dataType.GetGenericTypeDefinition() == typeof (ObjectListView<>))
        {
          // Construct a VisualizerForm<T>
          var visType = typeof (VisualizerTForm<>);
          var visConstructed = visType.MakeGenericType(data.GetType().GetGenericArguments());
          var v = Activator.CreateInstance(visConstructed);
          var view = visConstructed.GetProperty("View");
          view.SetValue(v, data, null);
          visualizerForm = (Form) v;
        }
      }
      return visualizerForm;
    }

    /// <summary>
    /// Removed Quotes put in by ADGV.
    /// <see cref="ADGVFilterMenu.FormatString"/>
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns></returns>
    public static string UnQuoteStringFromADVGIfNeed(string data)
    {
      String[] replace = { "%", "[", "]", "*", "\"", "`", "\\" };
      foreach (var q in replace)
      {
        data = data.Replace(string.Format("[{0}]",q),q);
      }
      return data;
    }

    /// <summary>
    /// Quotes the string for making a Comma Separated Variable if need.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns></returns>
    public static string QuoteStringForCsvIfNeed(string data)
    {
      return QuoteStringIfNeed(data, StringsToQuoteForCsv);
    }

    /// <summary>
    /// Quotes a string for adding to a delimited line of fields
    /// </summary>
    /// <param name="data">The data.</param>
    /// <param name="stringsToQuote">The strings to quote.</param>
    /// <param name="quoteString">The quote string.</param>
    /// <returns></returns>
    public static string QuoteStringIfNeed(string data, string[] stringsToQuote, string quoteString=@"""")
    {
      var oneQuote = String.Format("{0}", quoteString);
      var twoQuotes = String.Format("{0}{0}", quoteString);
      var quotedFormat = String.Format("{0}{{0}}{0}", quoteString);

      if (stringsToQuote.Any(data.Contains))
        return String.Format(quotedFormat, data.Replace(oneQuote, twoQuotes));
      return data;
    }

    /// <summary>
    /// Joins the values as Comma Separated Variable line.
    /// </summary>
    /// <param name="values">The values.</param>
    /// <returns></returns>
    public static string JoinAsCsv(params String[] values)
    {
      return JoinAsDelimited(",", values);
    }

    /// <summary>
    /// Concatenates a specified delimiter <see cref="T:System.String"/> between each element of a specified <see cref="T:System.String"/> array, yielding a single concatenated string.
    /// The values are quoted if they contain the delimiter or the NewLine string
    /// </summary>
    /// <param name="delimiter">The delimiter.</param>
    /// <param name="values">The values.</param>
    /// <returns></returns>
    public static string JoinAsDelimited(String delimiter, params String[] values)
    {
      return String.Join(delimiter, values.Select(s => QuoteStringIfNeed(s, new[] { delimiter, Environment.NewLine })).ToArray());
    }

    /// <summary>
    /// Splits the Comma Separated Variable line into its fields.
    /// </summary>
    /// <param name="csvLine">The csv line.</param>
    /// <returns>The fields</returns>
    public static string[] SplitCsvLine(string csvLine)
    {
      return SplitDelimitedLine(csvLine, ",");
    }

    /// <summary>
    /// Splits the delimited line.
    /// </summary>
    /// <param name="csvLine">The CSV line.</param>
    /// <param name="delimiters">The delimiters.</param>
    /// <returns></returns>
    public static string[] SplitDelimitedLine(string csvLine, params string[] delimiters)
    {
      var stringReader = new StringReader(csvLine);
      var textFieldParser = new Microsoft.VisualBasic.FileIO.TextFieldParser(stringReader) 
      { Delimiters = delimiters, HasFieldsEnclosedInQuotes = true, TrimWhiteSpace = false };
      return textFieldParser.ReadFields();
    }
  }
}