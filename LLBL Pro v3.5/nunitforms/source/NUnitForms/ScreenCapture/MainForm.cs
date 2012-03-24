/*----------------------------------------------------------------------------------------

	A-Soft Ingenieurbüro

	Copyright © 1994 - 2007. All Rights reserved.

	Related Copyrights :

			Microsoft .NET Windows Forms V2.0 library.
			Copyright (C) 2004...2006 Microsoft Corporation,
			All rights reserved.


	FILE		:	MainForm.cs

	PROJECT		:	A-Soft Library
	SUB			:	Standard Library
 
	SYSTEM		:	Windows-XP, (Windows 2000), C# (.NET 2.0, Visual Studio.NET 2005)

	AUTHOR		:	Joachim Holzhauer
	
	DESCRIPTION	:	Main form of screen capture application
 
	VERSION		:	1.0 - 2006.01.31

----------------------------------------------------------------------------------------*/

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms
{
    /// <summary>
    /// Main form of screen capture application
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The class instance used to capture the screen
        /// </summary>
        private ScreenCapture capture;

        /// <summary>
        /// Helper to handle the file formats
        /// </summary>
        private ImageFormatHandler handlers;

        /// <summary>
        /// The path of the executable, used to save the captured images.
        /// </summary>
        private string pathName;

        /// <summary>
        /// Do it....
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            pathName = String.Format("{0}\\Data\\", Path.GetDirectoryName(Application.ExecutablePath));
            if (! Directory.Exists(pathName))
            {
                Directory.CreateDirectory(pathName);
            }

            handlers = new ImageFormatHandler();
            capture = new ScreenCapture(handlers);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                if (!String.IsNullOrEmpty(process.ProcessName) && process.MainWindowHandle != null)
                {
                    listBoxProcesses.Items.Add(process.ProcessName);
                }
            }
        }

        private void buttonPrimaryScreen_Click(object sender, EventArgs e)
        {
            string filename = String.Format("{0}Captured PrimaryScreen.png", pathName);
            capture.Capture(ScreenCapture.CaptureType.PrimaryScreen, filename,
                            ImageFormatHandler.ImageFormatTypes.imgPNG);
        }

        private void buttonWorkingArea_Click(object sender, EventArgs e)
        {
            string filename = String.Format("{0}Captured WorkingArea.png", pathName);
            capture.Capture(ScreenCapture.CaptureType.WorkingArea, filename, ImageFormatHandler.ImageFormatTypes.imgPNG);
        }

        private void buttonVirtualScreen_Click(object sender, EventArgs e)
        {
            string filename = String.Format("{0}Captured VirtualScreen.png", pathName);
            capture.Capture(ScreenCapture.CaptureType.VirtualScreen, filename,
                            ImageFormatHandler.ImageFormatTypes.imgPNG);
        }

        private void buttonAllScreens_Click(object sender, EventArgs e)
        {
            string filename = String.Format("{0}Captured All.png", pathName);
            capture.Capture(ScreenCapture.CaptureType.AllScreens, filename, ImageFormatHandler.ImageFormatTypes.imgPNG);
        }

        private void buttonAllFormats_Click(object sender, EventArgs e)
        {
            string filename = String.Format("{0}Capture Formats.png", pathName);
            capture.Capture(ScreenCapture.CaptureType.VirtualScreen, filename,
                            ImageFormatHandler.ImageFormatTypes.imgPNG);
            capture.Capture(ScreenCapture.CaptureType.VirtualScreen, filename,
                            ImageFormatHandler.ImageFormatTypes.imgBMP);
            capture.Capture(ScreenCapture.CaptureType.VirtualScreen, filename,
                            ImageFormatHandler.ImageFormatTypes.imgGIF);
            capture.Capture(ScreenCapture.CaptureType.VirtualScreen, filename,
                            ImageFormatHandler.ImageFormatTypes.imgJPEG);
            capture.Capture(ScreenCapture.CaptureType.VirtualScreen, filename,
                            ImageFormatHandler.ImageFormatTypes.imgTIFF);
        }

        private void buttonPrintScreen_Click(object sender, EventArgs e)
        {
            capture.Print();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(listBoxProcesses.SelectedItem.ToString());

                string filename = String.Format("{0}Captured Other Process.png", pathName);
                Bitmap bitmap =
                    capture.Capture(processes[0].MainWindowHandle, filename, ImageFormatHandler.ImageFormatTypes.imgPNG);
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Image = bitmap;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}