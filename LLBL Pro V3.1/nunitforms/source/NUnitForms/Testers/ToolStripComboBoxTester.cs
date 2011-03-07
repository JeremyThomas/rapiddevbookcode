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

namespace NUnit.Extensions.Forms
{
    /// <summary>
    /// A Component tester for testing ToolStripComboBoxes.
    /// </summary>
    public partial class ToolStripComboBoxTester
    {
        public void Select(int index)
        {
            Properties.SelectedIndex = index;
        }

        /// <summary>
        /// Sets the text property of the ToolStripComboBox to the specified value.
        /// </summary>
        /// <remarks>
        /// TODO: Also calls EndCurrentEdit() so that databinding will happen.
        /// </remarks>
        /// <param name="text">The specified value for the text property.</param>
        public void Enter(string text)
        {
            Properties.Text = text;
            // EndCurrentEdit("Text");
        }

        /// <summary>
        /// Selects an entry in the ToolStripComboBox according to its string value.
        /// </summary>
        /// <remarks>
        /// Sets the Selected Index property on the underlying control after calling
        /// FindStringExact
        /// </remarks>
        /// <param name="text">The string value of the entry to select.</param>
        public void Select(string text)
        {
            int index;
            if ((index = Properties.FindStringExact(text)) == -1)
            {
                throw new FormsTestAssertionException("Could not find text '" + text + "' in ToolStripComboBox '" + name +
                                                      "'");
            }
            Select(index);
        }
    }
}