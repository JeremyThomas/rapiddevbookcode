using System;
using System.Threading;
using System.Windows.Forms;
using AW.Helper;

namespace AW.Win
{
	internal static class Program
	{
		/// <summary>
		/// Handles the ThreadException event of the Application control. Needed to use to avoid the NativeWindow.DebuggableCallBack method when debugging.
		/// </summary>
		/// <remarks>http://support.microsoft.com/kb/836674</remarks>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.Threading.ThreadExceptionEventArgs"/> instance containing the event data.</param>
		private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			using (var dialog = new ThreadExceptionDialog(e.Exception))
			{
				GeneralHelper.TraceOut(e.Exception.ToString());
				dialog.ShowDialog();
			}
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.ThreadException += Application_ThreadException;
			Application.Run(new FrmMain());
		}
	}
}