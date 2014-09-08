using System;
using System.Windows.Forms;
using AW.Winforms.Helpers.Forms;
using Northwind.DAL.EntityClasses;

namespace Northwind.DAL.Services.WCF.Host
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
      CommonEntityBase.Initialize();
      Application.Run(new WcfServiceManager(WcfDataServiceHost.StartService, WcfDataServiceHost.StopService) { Text = "WcfDataServiceHost" });
    }
  }
}