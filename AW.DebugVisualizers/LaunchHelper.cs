using AW.Winforms.Helpers.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Windows.Forms;

namespace AW.DebugVisualizers
{
  internal static class LaunchHelper
  {
    internal static void FormDebuggerVisualizerInstallerLauncher(string description)
    {
      Application.Run(new FormDebuggerVisualizerInstaller(typeof(IDialogVisualizerService), "Enumerable Debugger Visualizer", description, DemoAction));
    }

    private static void DemoAction()
    {
      var dataViewForm = EnumerableVisualizer.CreateDataViewForm(AppDomain.CurrentDomain.GetAssemblies());
      dataViewForm.Show();
    }


  }
}
