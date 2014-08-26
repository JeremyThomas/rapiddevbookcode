using System;
using System.ServiceModel;
using System.Windows.Forms;
using Northwind.DAL.Interfaces;

namespace Northwind.Client.Winforms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
      /// From https://github.com/SolutionsDesign/LLBLGenProExamples_4.x/
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Open a channel with the WCF service endpoint, and keep it alive till the end of the program.
            ChannelFactory<INorthwindService> channelFactory = new ChannelFactory<INorthwindService>("WCFServer");
            INorthwindService service = channelFactory.CreateChannel();
      var toRun = new MainForm(service);
            Application.Run(toRun);

            channelFactory.Close();
        }
    }
}