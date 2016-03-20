using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace AW.DebugVisualizers
{
  internal static class Program
  {
    /// <summary>
    ///   The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      var description = "This is an Enumerable Debugger Visualizer that displays any registered IEnumerable object in a DataGridView control." + Environment.NewLine +
                        "To install click on either of the buttons below which will copy this assembly to the directory chosen. " + Environment.NewLine +
                        "To uninstall go to the folder and remove the AW.EnumerableVisualizer assembly." + Environment.NewLine +
                        "For more info see: https://rapiddevbookcode.codeplex.com/wikipage?title=EnumerableDebugVisualizer";
      Application.Run(new FormDebuggerVisualizerInstaller(typeof(IDialogVisualizerService), "Enumerable Debugger Visualizer", description, DemoAction));
    }

    private static void DemoAction()
    {
      var dataViewForm = FrmDataEditor.CreateDataViewForm(AppDomain.CurrentDomain.GetAssemblies());
      dataViewForm.Show();
    }
  }
}