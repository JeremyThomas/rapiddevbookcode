using System;
using System.Configuration;
using System.IO;
using System.ServiceModel;
using System.Windows.Forms;
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

      INorthwindService service;
      ChannelFactory<INorthwindService> channelFactory = null;
      if (ConfigurationSettings.AppSettings["N-Tier"] == "true" || !BusinessPresent())
      {
        // Open a channel with the WCF service endpoint, and keep it alive till the end of the program.
        channelFactory = new ChannelFactory<INorthwindService>("WCFServer");
        service = channelFactory.CreateChannel();
      }
      else
      {
        var objectHandle = Activator.CreateInstanceFrom("Northwind.Business.dll", "Northwind.Business.NorthwindService");
        service = (INorthwindService)objectHandle.Unwrap();
      }
      var toRun = new MainForm(service);
      Application.Run(toRun);

      if (channelFactory != null) channelFactory.Close();
    }

    private static bool BusinessPresent()
    {
      return File.Exists("Northwind.Business.dll");
    }
  }
}