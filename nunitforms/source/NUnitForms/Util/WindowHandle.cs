#region Copyright (c) 2003-2007, Luke T. Maxon

/********************************************************************************************************************
'
' Copyright (c) 2003-2007, Luke T. Maxon
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

namespace NUnit.Extensions.Forms
{
    ///<summary>
    /// Additional methods for working with Window Handles.
    ///</summary>
    public static class WindowHandle
    {
        private const string DialogClass = "#32770";

        ///<summary>
        /// Returns true if the given window handle references a Dialog.
        ///</summary>
        ///<param name="handle"></param>
        ///<returns></returns>
        public static bool IsDialog(IntPtr handle)
        {
            return GetClassName(handle) == DialogClass;
        }

        ///<summary>
        /// Returns the text of the references control.
        ///</summary>
        ///<param name="handle">A window handle to a control.</param>
        ///<returns>The text of the control.</returns>
        public static string GetText(IntPtr handle)
        {
            IntPtr handleToDialogText = Win32.GetDlgItem(handle, 0xFFFF);
            StringBuilder buffer = new StringBuilder(255);
            Win32.GetWindowText(handleToDialogText, buffer, 255);
            return buffer.ToString();
        }

        ///<summary>
        /// Gets the caption of the referenced window.
        ///</summary>
        public static string GetCaption(IntPtr handle)
        {
            StringBuilder buffer = new StringBuilder(255);
            Win32.GetWindowText(handle, buffer, 255);
            return buffer.ToString();
        }

        ///<summary>
        /// Returns the window class name for the referenced window.
        ///</summary>
        public static string GetClassName(IntPtr handle)
        {
            StringBuilder className = new StringBuilder();
            className.Capacity = 255;
            Win32.GetClassName(handle, className, 255);
            return className.ToString();
        }
    }
}