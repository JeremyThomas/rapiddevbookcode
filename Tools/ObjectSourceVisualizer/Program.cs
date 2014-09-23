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
      Application.Run(new FormDebuggerVisualizerInstaller(typeof(IDialogVisualizerService)));
    }
  }
}
