using System;
using System.Diagnostics;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using AW.Helper;

namespace LLBLGen.EntityBrowser
{
  static class Program
  {
    private const string ErrorMsg = "An application error occurred. Please contact the adminstrator " +
                                    "with the following information:\n\n";

    /// <summary>
    ///   The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.ThreadException += Application_ThreadException;
      // Set the unhandled exception mode to force all Windows Forms errors to go through our handler.
      Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

      // Add the event handler for handling non-UI thread exceptions to the event. 
      AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

      Application.Run(new FrmLLBLGenEntityBrowser());
    }

    /// <summary>
    /// Handles the ThreadException event of the Application control. Needed to use to avoid the
    /// NativeWindow.DebuggableCallBack method when debugging.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.Threading.ThreadExceptionEventArgs" /> instance containing the event data.</param>
    /// <remarks>
    /// http://support.microsoft.com/kb/836674
    /// </remarks>
    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
      var exception = e.Exception;
      if (exception != null)
        using (var dialog = new ThreadExceptionDialog(exception))
        {
          GeneralHelper.TraceOut(exception.ToString());
          try
          {
            WriteExceptionToEventLog(exception, "ThreadException");
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
    /// Exits this instance.
    /// </summary>
    /// <remarks>See Application.OnThreadException</remarks>
    private static void Exit()
    {
      Application.Exit();
      new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
      Environment.Exit(0);
    }

    /// <summary>
    /// Handles the UnhandledException event of the CurrentDomain control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="UnhandledExceptionEventArgs" /> instance containing the event data.</param>
    /// <remarks>
    /// https://msdn.microsoft.com/en-us/library/system.windows.forms.application.setunhandledexceptionmode(v=vs.110).aspx
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
    /// Writes the exception to the event log.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <param name="source">The source.</param>
    /// <remarks>
    /// https://msdn.microsoft.com/en-us/library/system.windows.forms.application.setunhandledexceptionmode(v=vs.110).aspx
    /// </remarks>
    private static void WriteExceptionToEventLog(Exception exception, string source)
    {
      if (!EventLog.SourceExists(source))
        EventLog.CreateEventSource(source, "Application");
      // Create an EventLog instance and assign its source.
      var myLog = new EventLog {Source = source};
      myLog.WriteEntry(ErrorMsg +Environment.NewLine + exception + "\n\nStack Trace:\n" + exception.StackTrace);
    }
  }
}