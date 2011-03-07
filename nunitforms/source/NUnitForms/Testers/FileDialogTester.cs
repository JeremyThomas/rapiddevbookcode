#region Copyright (c) 2006-2007, Luke T. Maxon (Authored by Anders Lillrank)

/********************************************************************************************************************
'
' Copyright (c) 2006-2007, Luke T. Maxon
' All rights reserved.
' 
' Redistribution and use in source and binary forms, with or without modification, are permitted provided
' that the following conditions are met:
' 
' * Redistributions of source code must retain the above copyright notice, this list of conditions and the
' 	following disclaimer.
' 
' * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and
' 	the following disclaimer in the documentation and/or other materials provided with the distribution.
' 
' * Neither the name of the author nor the names of its contributors may be used to endorse or 
' 	promote products derived from this software without specific prior written permission.
' 
' THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED
' WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A
' PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
' ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
' LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
' INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
' OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN
' IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
'
'*******************************************************************************************************************/

#endregion

using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms
{
    ///<summary>
    /// A form tester for the <see cref="FileDialog"/>.
    ///</summary>
    public class FileDialogTester
    {
        /// <summary>
        /// Control ID for the Cancel button.
        /// </summary>
        protected const int CancelButton = 2;

        /// <summary>
        /// Control ID for the file name checkbox.
        /// </summary>
        protected const int FileNameCheckBox = 1148;

        /// <summary>
        /// Control ID for the Open or Save button.
        /// </summary>
        protected const int OpenButton = 1;

        IntPtr hWnd;
        public IntPtr Handle
        {
            get { return hWnd; }
        }


        public FileDialogTester(IntPtr hWnd)
        {
            this.hWnd = hWnd;
        }

 
        /// <summary>
        /// Clicks the cancel button of a OpenFiledialog.
        /// </summary>
        public void ClickCancel()
        {
            if (hWnd == IntPtr.Zero) hWnd = FindFileDialog();
            Util.GetMessageHook.Record(ClickCancelCB);
        }
        bool ClickCancelCB()
        {
            IntPtr cancel_btn = Win32.GetDlgItem(hWnd, CancelButton);
            Win32.PostMessage(cancel_btn, Win32.BM_CLICK, (IntPtr)0, IntPtr.Zero);
            return true;
        }

        /// <summary>
        /// Click the first button, usually "Open" or "Save".
        /// </summary>
        protected void ClickOpenSaveButton()
        {
            if (hWnd == IntPtr.Zero) hWnd = FindFileDialog();
            Util.GetMessageHook.Record(ClickOpenSaveButtonCB);
        }
        bool ClickOpenSaveButtonCB()
        {
            IntPtr open_btn = Win32.GetDlgItem(hWnd, OpenButton);
            Win32.PostMessage(open_btn, Win32.BM_CLICK, (IntPtr) 0, IntPtr.Zero);
            return true;
        }


        /// <summary>
        /// Sets the filename in the filename ComboBox and presses the OpenSave button.
        /// </summary>
        protected void SetFileName(string file)
        {
            if (hWnd == IntPtr.Zero) hWnd = FindFileDialog();
            Util.GetMessageHook.Record(delegate() { return SetFileNameCB(file); });
        }
        bool SetFileNameCB(string file)
        {
            if (!Win32.IsWindowVisible(hWnd)) return false;
            IntPtr fnh = Win32.GetDlgItem(hWnd, FileNameCheckBox);
            if (fnh == IntPtr.Zero)
            {
                // On Vista 64, it seems the combo box does not have an id. However, it contains a control with id 1001.
                Win32.EnumChildWindows(hWnd,
                    delegate(IntPtr wnd, IntPtr lparam)
                    {
                        if (Win32.GetDlgItem(wnd, 1001) == IntPtr.Zero) return 1;
                        fnh = wnd;
                        return 0;
                    }, IntPtr.Zero);

                if (fnh == IntPtr.Zero)
                {
                    throw new System.Exception("NUnitForms fatal error: cannot find filename box");
                }

                Util.GetMessageHook.Record(delegate()
                {
                    Win32.SetWindowText(fnh, file);
                    StringBuilder sb = new StringBuilder(file.Length + 1);
                    Win32.GetWindowText(fnh, sb, file.Length + 1);
                    if (sb.ToString().ToLowerInvariant() != file.ToString().ToLowerInvariant())
                    {
                        return false;
                    }

                    IntPtr open_btn = Win32.GetDlgItem(hWnd, OpenButton);
                    Win32.PostMessage(open_btn, Win32.BM_CLICK, (IntPtr)0, IntPtr.Zero);

                    return true;
                });
            }
            else
            {
                Win32.SetDlgItemText(hWnd, FileNameCheckBox, file);

                StringBuilder sb = new StringBuilder(file.Length + 1);
                Win32.GetDlgItemText(hWnd, FileNameCheckBox, sb, file.Length + 1);

                if (sb.ToString().ToLowerInvariant() != file.ToString().ToLowerInvariant())
                {
                    return false;
                }

                IntPtr open_btn = Win32.GetDlgItem(hWnd, OpenButton);
                Win32.PostMessage(open_btn, Win32.BM_CLICK, (IntPtr)0, IntPtr.Zero);
                return true;
            }

            return true;
        }

        // Old interface

        /// <summary>
        /// Determines the initial name of the file dialog boxes, based on the locale.
        /// Currently works for english, german and french only.
        /// </summary>
        static FileDialogTester()
        {
            // The initial name for the file dialogs depend on the locale.
            // Add a case for your own system if you really want to use the obsoleted
            // ExpectFileDialog functions
            if (new System.Text.RegularExpressions.Regex("french|france",
                System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                .IsMatch(System.Globalization.CultureInfo.CurrentCulture.EnglishName))
            {
                InitialFileDialogName = "Ouvrir";
            } 
            else if (new System.Text.RegularExpressions.Regex("german",
                System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                .IsMatch(System.Globalization.CultureInfo.CurrentCulture.EnglishName))
            {
                InitialFileDialogName = "Öffnen";
            }
            else InitialFileDialogName = "Open";
        }
        /// <summary>
        /// Initial name of the file dialog boxes. They seem to change name after their creation.
        /// </summary>
        public static string InitialFileDialogName
        {
            get;
            private set;
        }


        [Obsolete]
        public FileDialogTester(string title) 
        {
            // disregard the given title, since at the time it is called, it will always be InitialFileDialogName
            hWnd = IntPtr.Zero;
        }


        /// <summary>
        /// Finds the OpenFileDialog.
        /// </summary>
        protected static IntPtr FindFileDialog()
        {
            IntPtr desktop = Win32.GetDesktopWindow();
            IntPtr res = IntPtr.Zero;
            Win32.EnumChildWindows(desktop,
                delegate(IntPtr hwnd, IntPtr lParam)
                {
                    if (WindowHandle.IsDialog(hwnd))
                    {
                        string name = WindowHandle.GetCaption(hwnd);
                        if (name == FileDialogTester.InitialFileDialogName
                            // Vista 64 hack
                            || name == "Save as" || name == "Enregistrer sous" || name == "Speichern unter")
                        {
                            res = hwnd;
                        }
                    }
                    return 1;
                },
                IntPtr.Zero);
            if (res == IntPtr.Zero)
            {
                throw new ControlNotVisibleException("Open File Dialog is not visible");
            }
            return res;
        }
    }
}