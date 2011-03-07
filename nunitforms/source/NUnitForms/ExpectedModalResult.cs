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

using System.Collections.ObjectModel;

namespace NUnit.Extensions.Forms
{
    /// <summary>
    /// This class stores expected and unexpected dialog information.
    /// </summary>
    public class ExpectedModalResult
    {
        /// <summary>
        /// The actual caption of this window.
        /// </summary>
        public string ActualCaption;

        /// <summary>
        /// The actual WinForms name of this window, if applicable.
        /// </summary>
        public string ActualName;

        /// <summary>
        /// The expected key for this window.
        /// </summary>
        public string ExpectedName;

        /// <summary>
        /// True if this window was expected.
        /// </summary>
        public bool WasExpected;

        /// <summary>
        /// True if this window was shown.
        /// </summary>
        public bool WasShown;

        /// <summary>
        /// True if this window was expected and shown, or unexpected and not shown.
        /// </summary>
        public bool Passed
        {
            get { return WasExpected == WasShown; }
        }
    }

    /// <summary>
    /// A collection of <see cref="ExpectedModalResult"/>s.
    /// </summary>
    public class ExpectedModalResultCollection : Collection<ExpectedModalResult>
    {
        /// <summary>
        /// Returns a list of all results in this list that did not pass.
        /// </summary>
        public ExpectedModalResultCollection GetFailures()
        {
            ExpectedModalResultCollection list = new ExpectedModalResultCollection();
            foreach (ExpectedModalResult result in this)
            {
                if (!result.Passed)
                    list.Add(result);
            }
            return list;
        }
    }
}