using System;
using System.Configuration;
using System.IO;
using System.ServiceModel;
using System.Windows.Forms;
using AW.Helper;
using Northwind.DAL.Interfaces;

namespace Northwind.Client.Winforms
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

      var usenTier = ConfigurationSettings.AppSettings["N-Tier"] == "true";
      var serviceAndCleanup = WcfUtility.CreateService<INorthwindService>(usenTier, "Northwind.Business.dll", "Northwind.Business.NorthwindService");
      var toRun = new MainForm(serviceAndCleanup.Item1);
      Application.Run(toRun);

      serviceAndCleanup.Item2();
    }



  }
}