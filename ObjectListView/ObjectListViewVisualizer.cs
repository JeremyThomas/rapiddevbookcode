using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace JesseJohnston
{
	/// <summary>
	/// A debugger visualizer for ObjectListView.
	/// </summary>
	/// <remarks>This class is used by Visual Studio, and is not intended to be called from your code.</remarks>
	public class ObjectListViewVisualizer : DialogDebuggerVisualizer
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ObjectListViewVisualizer"/> class.
		/// </summary>
		/// <remarks>This method is used by Visual Studio, and is not intended to be called from your code.</remarks>
		public ObjectListViewVisualizer()
		{
		}

		/// <summary>
		/// Display the visualizer user interface.
		/// </summary>
		/// <remarks>This method is used by Visual Studio, and is not intended to be called from your code.</remarks>
		/// <param name="windowService">An object of type <see cref="T:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService"></see>, which provides methods your visualizer can use to display Windows forms, controls, and dialogs.</param>
		/// <param name="objectProvider">An object of type <see cref="T:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider"></see>. This object provides communication from the debugger side of the visualizer to the object source (<see cref="T:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource"></see>) on the debuggee side.</param>
		protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
		{
			try
			{
				object data = objectProvider.GetObject();
				if (data is ObjectListView)
				{
					using (VisualizerForm displayForm = new VisualizerForm())
					{
						displayForm.View = (ObjectListView)data;
						windowService.ShowDialog(displayForm);
					}
				}
				else
				{
					// If ObjectListView<T>
					Type dataType = data.GetType();
					if (dataType.IsGenericType && dataType.GetGenericTypeDefinition() == typeof(ObjectListView<>))
					{
						// Construct a VisualizerForm<T>
						Type visType = typeof(VisualizerTForm<>);
						Type visConstructed = visType.MakeGenericType(data.GetType().GetGenericArguments());
						object v = Activator.CreateInstance(visConstructed);
						PropertyInfo view = visConstructed.GetProperty("View");
						view.SetValue(v, data, null);
						Form visualizerForm = (Form)v;
						using (visualizerForm)
						{
							windowService.ShowDialog(visualizerForm);
						}
					}
				}
			}
			catch (Exception ex)
			{
				if (ex.GetType().Name == "RemoteObjectSourceException")		// it's an internal type that derives directly from System.Exception
					MessageBox.Show("The visualizer cannot be displayed because your list item type is not marked Serializable.", "Visualizer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					throw;
			}
		}

		/// <summary>
		/// Tests the visualizer by hosting it outside of the debugger.
		/// </summary>
		/// <remarks>This method is not intended to be called from your code.</remarks>
		/// <param name="objectToVisualize">The object to display in the visualizer.</param>
		public static void TestShowVisualizer(object objectToVisualize)
		{
			VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(ObjectListViewVisualizer));
			visualizerHost.ShowVisualizer();
		}
	}
}