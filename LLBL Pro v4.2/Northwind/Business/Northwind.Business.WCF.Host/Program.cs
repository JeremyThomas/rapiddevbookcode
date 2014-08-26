using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SD.LLBLGen.Pro.Examples.WCF.Host
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
            Application.Run(new WCFServiceManager());
        }
    }
}