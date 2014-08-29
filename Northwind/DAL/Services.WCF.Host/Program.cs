using System;
using System.Windows.Forms;

namespace Services.WCF.Host
{
  internal static class Program
  {
    /// <summary>
    ///   The main entry point for the application.
    ///   From https://github.com/SolutionsDesign/LLBLGenProExamples_4.x/
    /// </summary>
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new WcfServiceManager());
    }
  }
}