using System;
using System.Threading;
using System.Windows.Forms;
using AW.Data;
using AW.Helper;
using AW.Winforms.Helpers.LLBL;
using Serilog;

namespace AW.Win
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
      Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Debug()
       // .WriteTo.Trace()
        .WriteTo.Debug()
        .CreateLogger();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.ThreadException += Application_ThreadException;
      LLBLWinformHelper.ForceInitialization();
      ProfilerHelper.InitializeOrmProfiler();
    //  MetaSingletons.AddContext();
      Application.Run(new FrmMain());
    }
  }
}