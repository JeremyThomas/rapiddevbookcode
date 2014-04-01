using System;
using System.IO;
using System.Windows.Forms;

namespace JesseJohnston
{
  public static class ObjectListViewHelper
  {
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
    /// QuoteStringIfNeed
    /// </summary>
    /// <param name="data"></param>
    /// <param name="stringToQuote"></param>
    /// <param name="quoteString"></param>
    /// <returns></returns>
    public static string QuoteStringIfNeed(string data, string stringToQuote=",", string quoteString=@"""")
    {
      var oneQuote = String.Format("{0}", quoteString);
      var twoQuotes = String.Format("{0}{0}", quoteString);
      var quotedFormat = String.Format("{0}{{0}}{0}", quoteString);

      if (data.Contains(stringToQuote))
        return String.Format(quotedFormat, data.Replace(oneQuote, twoQuotes));
      return data;
    }

    public static string[] SplitCSVLine(string value)
    {
      var stringReader = new StringReader(value);
      var textFieldParser = new Microsoft.VisualBasic.FileIO.TextFieldParser(stringReader) {Delimiters = new[] {","}, HasFieldsEnclosedInQuotes = true};
      return textFieldParser.ReadFields();
    }
  }
}