using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JesseJohnston
{
  public static class ObjectListViewHelper
  {
    /// <summary>
    /// Creates the visualizer form filled with either a ObjectListView or a ObjectListView<>.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns></returns>
    public static Form CreateVisualizerForm(object data)
    {
      Form visualizerForm = null;
      if (data is ObjectListView)
        visualizerForm = new VisualizerForm { View = (ObjectListView)data };
      else
      {
        // If ObjectListView<T>
        var dataType = data.GetType();

        if (dataType.IsGenericType && dataType.GetGenericTypeDefinition() == typeof(ObjectListView<>))
        {
          // Construct a VisualizerForm<T>
          var visType = typeof(VisualizerTForm<>);
          var visConstructed = visType.MakeGenericType(data.GetType().GetGenericArguments());
          var v = Activator.CreateInstance(visConstructed);
          var view = visConstructed.GetProperty("View");
          view.SetValue(v, data, null);
          visualizerForm = (Form)v;
        }
      }
      return visualizerForm;
    }
  }
}
