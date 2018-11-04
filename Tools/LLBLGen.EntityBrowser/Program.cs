using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AW.Helper;
using Microsoft.CSharp;

namespace LLBLGen.EntityExplorer
{
  static class Program
  {
    private const string ErrorMsg = "An application error occurred. Please contact the adminstrator " +
                                    "with the following information:\n\n";

    private static readonly Lazy<bool> IsAdministrator = new Lazy<bool>(GeneralHelper.IsAdministrator);

    /// <summary>
    ///   The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main(string[] args)
    {
      if (args != null && args.Length > 0)
      {
        var source = args[args.Length - 1];
      }
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.ThreadException += Application_ThreadException;
      // Set the unhandled exception mode to force all Windows Forms errors to go through our handler.
      Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

      // Add the event handler for handling non-UI thread exceptions to the event. 
      AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

      TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

      Application.Run(new FrmLLBLGenEntityExplorer());
    }

    private static void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
    {
      ShowThreadExceptionDialog(e.Exception);
    }

    /// <summary>
    ///   Handles the ThreadException event of the Application control. Needed to use to avoid the
    ///   NativeWindow.DebuggableCallBack method when debugging.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Threading.ThreadExceptionEventArgs" /> instance containing the event data.</param>
    /// <remarks>
    ///   http://support.microsoft.com/kb/836674
    /// </remarks>
    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
      ShowThreadExceptionDialog(e.Exception);
    }

    private static void ShowThreadExceptionDialog(Exception exception)
    {
      if (exception != null)
        using (var dialog = new ThreadExceptionDialog(exception))
        {
          GeneralHelper.TraceOut(exception.ToString());
          try
          {
            WriteExceptionToEventLog(exception, "LLBLGen.EntityExplorer");
          }
          catch (Exception ex)
          {
            GeneralHelper.TraceOut(ex.ToString());
          }

          if (exception.StackTrace != null && !exception.StackTrace.Contains("System.Windows.Forms.DataGridTextBoxColumn.GetText(Object value)")) //As DataGrid doesn't have DataError event
            if (dialog.ShowDialog() == DialogResult.Abort)
              Exit();
        }
    }

    /// <summary>
    ///   Exits this instance.
    /// </summary>
    /// <remarks>See Application.OnThreadException</remarks>
    private static void Exit()
    {
      Application.Exit();
      new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
      Environment.Exit(0);
    }

    /// <summary>
    ///   Handles the UnhandledException event of the CurrentDomain control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="UnhandledExceptionEventArgs" /> instance containing the event data.</param>
    /// <remarks>
    ///   https://msdn.microsoft.com/en-us/library/system.windows.forms.application.setunhandledexceptionmode(v=vs.110).aspx
    /// </remarks>
    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
      try
      {
        // Since we can't prevent the app from terminating, log this to the event log.
        WriteExceptionToEventLog((Exception) e.ExceptionObject, "ThreadException");
      }
      catch (Exception exc)
      {
        try
        {
          MessageBox.Show(string.Format("Fatal Non-UI Error. Could not write the error to the event log. Reason: {0}", exc.Message), "Fatal Non-UI Error"
            , MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        finally
        {
          Exit();
        }
      }
    }

    /// <summary>
    ///   Writes the exception to the event log.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <param name="source">The source.</param>
    /// <remarks>
    ///   https://msdn.microsoft.com/en-us/library/system.windows.forms.application.setunhandledexceptionmode(v=vs.110).aspx
    /// </remarks>
    private static void WriteExceptionToEventLog(Exception exception, string source)
    {
      // Create an EventLog instance and assign its source.
      var myLog = new EventLog {Source = source};
      try
      {
        myLog.WriteEntry(ErrorMsg + Environment.NewLine + exception + "\n\nStack Trace:\n" + exception.StackTrace);
      }
      catch (SecurityException)
      {
        var executableDirectory = Path.GetDirectoryName(Application.ExecutablePath);
        if (executableDirectory != null)
        {
          var createEventSourceExe = Path.Combine(executableDirectory, "CreateEventSource.exe");
          if (!CreateEventSourceApp(createEventSourceExe).Any())
          {
            const int errorCancelled = 1223; //The operation was canceled by the user.
            var info = new ProcessStartInfo(createEventSourceExe)
            {
              UseShellExecute = true,
              Verb = "runas",
              Arguments = source
            };
            try
            {
              Process.Start(info);
            }
            catch (Win32Exception ex)
            {
              if (ex.NativeErrorCode == errorCancelled)
                MessageBox.Show("Why you no select Yes?");
              else
                throw;
            }
          }
        }
      }
    }

    [PrincipalPermission(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]
    public static void CreateEventSource(string source)
    {
      if (IsAdministrator.Value && !EventLog.SourceExists(source))
        EventLog.CreateEventSource(source, "Application");
    }

    private static IEnumerable<CompilerError> CreateEventSourceApp(string exeName = "foo.exe")
    {
      var csc = new CSharpCodeProvider(new Dictionary<string, string> {{"CompilerVersion", "v3.5"}});
      var parameters = new CompilerParameters(new[] {"mscorlib.dll", "System.Core.dll", "System.dll"}, exeName, true) {GenerateExecutable = true};
      var results = csc.CompileAssemblyFromSource(parameters,
        @"using System.Diagnostics;
            class Program {
              public static void Main(string[] args) {
                if (args != null && args.Length > 0)
                {
                  var source = args[args.Length - 1];
                  if (!System.Diagnostics.EventLog.SourceExists(source))
                    System.Diagnostics.EventLog.CreateEventSource(source, ""Application"");
                }
              }
            }");
      return results.Errors.Cast<CompilerError>();
    }
  }
}