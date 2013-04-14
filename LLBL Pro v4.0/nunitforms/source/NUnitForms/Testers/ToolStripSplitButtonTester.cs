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

using System.Windows.Forms;

namespace NUnit.Extensions.Forms
{
    /// <summary>
    /// A ToolStripItem tester for testing ToolStripSplitButtons.
    /// </summary>
    public partial class ToolStripSplitButtonTester
    {
        /// <summary>
        /// Clicks the DropDownItem with the given index.
        /// </summary>
        /// <param name="index"></param>
        public void ClickDropDownItem(int index)
        {
            bool found = false;
            ToolStripSplitButton button = Properties;

            if (button.HasDropDownItems)
            {
                ToolStripItemCollection items = button.DropDownItems;
                if (items.Count > index)
                {
                    ToolStripItem item = items[index];
                    FireEvent("DropDownItemClicked", new ToolStripItemClickedEventArgs(item));
                    found = true;
                }
            }
            FormsAssert.IsTrue(found, "No drop down item found at that index.");
        }


        /// <summary>
        /// Simulates that the "user" clicks on the button part of the
        /// ToolStripSplitButton.
        /// </summary>
        public virtual void ButtonClick()
        {
            FireEvent("ButtonClick");
        }

        /// <summary>
        /// Simulates that the "user" double clicks on the button part of the
        /// ToolStripSplitButton.
        /// </summary>
        public virtual void ButtonDoubleClick()
        {
            FireEvent("ButtonDoubleClick");
        }
    }
}