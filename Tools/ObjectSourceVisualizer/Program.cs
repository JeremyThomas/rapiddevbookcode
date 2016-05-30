using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace ObjectAsSourceCodeVisualizer
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
      var description = "This is an Debugger Visualizer that displays C# source code the will generate the .Net object chosen in the debugger." + Environment.NewLine +
                        "In other words: It will serialize the object as C# source text." + Environment.NewLine +
                        "To install click on either of the buttons below which will copy this assembly to the directory chosen. " + Environment.NewLine +
                        "To uninstall go to the folder and remove the assembly." + Environment.NewLine +
                        "For more info see: https://rapiddevbookcode.codeplex.com/wikipage?title=ObjectAsSourceCodeDebuggerVisualizer";
      Application.Run(new FormDebuggerVisualizerInstaller(typeof(IDialogVisualizerService), "C# object literal Debugger Visualizer", description, DemoAction));
    }

    private static void DemoAction()
    {
      var controls = new List<Control> { new Control("Control1"), new Control("Control2"), new Control("Control3") };
      var dataViewForm = ObjectSourceVisualizer.CreateQueryRunnerForm(controls.SerializeToCSharp(OutputFormat.Compileable,
        "Anchor,AutoScrollOffset,BackColor,Bounds,Cursor,DataBindings,Font,ForeColor,Margin,WindowTarget,Padding,ClientSize,Location,MaximumSize,MinimumSize,Size"));
      dataViewForm.Show();
    }
  }
}