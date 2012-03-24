/*----------------------------------------------------------------------------------------

	A-Soft Ingenieurbüro

	Copyright © 1994 - 2007. All Righsts reserved.

	Related Copyrights :

			Microsoft .NET Windows Forms V2.0 library.
			Copyright (C) 2004...2006 Microsoft Corporation,
			All rights reserved.


	FILE		:	ImageFormatHandler.cs

	PROJECT		:	A-Soft Library
	SUB			:	Standard Library
 
	SYSTEM		:	Windows-XP, (Windows 2000), C# (.NET 2.0, Visual Studio.NET 2005)

	AUTHOR		:	Joachim Holzhauer
	
	DESCRIPTION	:	Supplies some helpers methods used for image processing (file 
					selection dialog, image format options selection etc.).
 
	VERSION		:	1.0 - 2006.01.31

----------------------------------------------------------------------------------------*/

using System;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}