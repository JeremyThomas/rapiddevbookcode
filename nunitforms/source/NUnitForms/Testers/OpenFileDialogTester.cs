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

namespace NUnit.Extensions.Forms
{
    /// <summary>
    /// This class is used to test the built-in OpenFileDialog. This class is not meant to be
    /// used directly. Instead you should use the ExpectOpenFileDialog and CancelOpenFileDialog functions
    /// in the NUnitFormTest
    /// class.
    /// </summary>
    public class OpenFileDialogTester : FileDialogTester
    {
        /// <summary>
        /// Constructs a new OpenFileDialogTester working on the dialog box having the given handle.
        /// </summary>
        public OpenFileDialogTester(IntPtr hWnd) : base(hWnd)
        {
        }
        /// <summary>
        /// Unreliable, kept for compatibility. The title is not actually used.
        /// </summary>
        [Obsolete]
        public OpenFileDialogTester(string title)
            : base(title)
        {
        }

        ///<summary>
        /// Inputs the give file name into the dialog box, and clicks the open button.
        ///</summary>
        public void OpenFile(string file)
        {
            SetFileName(file);
        }
    }
}