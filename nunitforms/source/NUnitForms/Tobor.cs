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

//Initially authored by Adam Vandenberg

#endregion

using NUnit.Framework;

namespace NUnit.Extensions.Forms
{
    /// <summary>
    /// Experimental "FIT" interface.
    /// </summary>
    public class Tobor
    {
        private readonly FormTester targetForm;
        /*
		 
		 General idea: https://sourceforge.net/forum/forum.php?thread_id=1336913&forum_id=331583
		 
		NUnitFormsFit.Type(form,"txtA","3"); 
		NUnitFormsFit.Type(form,"txtB","4"); 
 
		NUnitFormsFit.Click(form,"btnCompute"); 
		NUnitFormsFit.VerifyText(form,"lblResult","7");

		*/


        /// <summary>
        /// Constructor.
        /// </summary>
        public Tobor(FormTester targetForm)
        {
            this.targetForm = targetForm;
        }

        ///<summary>
        /// Types into the named control.
        ///</summary>
        public void Type(string controlName, string newText)
        {
            TextBoxTester textBox = new TextBoxTester(controlName, targetForm.Properties);
            textBox.Enter(newText);
        }

        ///<summary>
        /// Clicks the named control.
        ///</summary>
        public void Click(string controlName)
        {
            ButtonTester button = new ButtonTester(controlName, targetForm.Properties);
            button.Click();
        }

        ///<summary>
        /// Verifies the text of the named control matches the expected text.
        ///</summary>
        public void VerifyText(string controlName, string expectedText)
        {
            ControlTester anyControl = new ControlTester(controlName, targetForm.Properties);
            Assert.AreEqual(expectedText, anyControl.Text);
        }
    }
}