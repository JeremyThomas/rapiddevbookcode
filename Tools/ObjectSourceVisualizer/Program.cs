using System;
using System.Windows.Forms;
using AW.Winforms.Helpers.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace ObjectSourceVisualizer
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      var description = "This is an Debugger Visualizer that emits a C# object literal constructor from the C# object chosen in the debugger." + Environment.NewLine +
                  "To install click on either of the buttons below which will copy this assembly to the directory chosen. " + Environment.NewLine +
                  "To uninstall go to the folder and remove the assembly." + Environment.NewLine +
                  "For more info see: https://github.com/jefflomax/csharp-object-to-object-literal";
      Application.Run(new FormDebuggerVisualizerInstaller(typeof(IDialogVisualizerService), "C# object literal Debugger Visualizer", description));
    }
  }
}
