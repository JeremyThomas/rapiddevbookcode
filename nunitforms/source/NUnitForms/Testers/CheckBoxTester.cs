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

namespace NUnit.Extensions.Forms
{
    /// <summary>
    /// A ControlTester for testing CheckBoxes.
    /// </summary>
    public partial class CheckBoxTester
    {
        /// <summary>
        /// Retrieves the Checked property of the CheckBox
        /// </summary>
        public bool Checked
        {
            get { return Properties.Checked; }
        }

        /// <summary>
        /// Sets the shouldCheck property to the specified value.
        /// </summary>
        public void Check(bool shouldCheck)
        {
            EditChecked(shouldCheck);
        }

        /// <summary>
        /// Sets the Checked property of the CheckBox to true
        /// </summary>
        public void Check()
        {
            EditChecked(true);
        }

        /// <summary>
        /// Sets the Checked property of the CheckBox to false
        /// </summary>
        public void UnCheck()
        {
            EditChecked(false);
        }

        private void EditChecked(bool shouldCheck)
        {
            Properties.Checked = shouldCheck;
            EndCurrentEdit("Checked");
        }
    }
}