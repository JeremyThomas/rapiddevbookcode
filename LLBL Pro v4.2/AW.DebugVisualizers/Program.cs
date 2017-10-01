﻿using System;
using System.Windows.Forms;
using AW.Winforms.Helpers.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;
using AW.Helper;
using System.Threading;

namespace AW.DebugVisualizers
{
  internal static class Program
  {
    /// <summary>
    ///   Handles the ThreadException event of the Application control. Needed to use to avoid the
    ///   NativeWindow.DebuggableCallBack method when debugging.
    /// </summary>
    /// <remarks>http://support.microsoft.com/kb/836674</remarks>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Threading.ThreadExceptionEventArgs" /> instance containing the event data.</param>
    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
      using (var dialog = new ThreadExceptionDialog(e.Exception))
      {
        GeneralHelper.TraceOut(e.Exception.ToString());
        if (!e.Exception.StackTrace.Contains("System.Windows.Forms.DataGridTextBoxColumn.GetText(Object value)")) //As DataGrid doesn't have DataError event
          dialog.ShowDialog();
      }
    }


    /// <summary>
    ///   The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
      GeneralHelper.TraceOut("Main");
      Application.ThreadException += Application_ThreadException;
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      var description = "This is an Enumerable Debugger Visualizer that displays any registered IEnumerable object in a Grid." + Environment.NewLine +
                        "To install click on either of the buttons below which will copy this assembly to the directory chosen. " + Environment.NewLine +
                        "To uninstall go to the folder and remove the AW.EnumerableVisualizer assembly." + Environment.NewLine + 
                        "For more info see: " + EnumerableVisualizer.VisualizerWebSite;
      Application.Run(new FormDebuggerVisualizerInstaller(typeof(IDialogVisualizerService), "Enumerable Debugger Visualizer", description, DemoAction));
    }

    private static void DemoAction()
    {
      var dataViewForm = EnumerableVisualizer.CreateDataViewForm(AppDomain.CurrentDomain.GetAssemblies());
      dataViewForm.Show();
    }
  }
}