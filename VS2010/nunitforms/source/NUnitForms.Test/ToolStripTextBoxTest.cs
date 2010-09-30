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

using NUnit.Framework;

namespace NUnit.Extensions.Forms.TestApplications
{
    ///<summary>
    /// Test Fixture for ToolStripTextBoxTester.
    ///</summary>
    [TestFixture]
    public class ToolStripTextBoxTest : NUnitFormTest
    {
        ///<summary>
        /// Sets up this test.
        ///</summary>
        public override void Setup()
        {
            new ToolStripTextBoxForm().Show();
        }

        /// <summary>
        /// This testcase presses a ToolStripButton which will put the string clicked into the ToolStripTextBox. 
        /// Test is ok if the ToolStripTextBox text is clicked.
        /// </summary>
        [Test]
        public void ToolStripTextBoxOnToolBar()
        {
            ToolStripButtonTester button_tester = new ToolStripButtonTester("toolStripButton1");

            ToolStripTextBoxTester textbox_tester = new ToolStripTextBoxTester("toolStripTextBox1");
            Assert.IsTrue(string.IsNullOrEmpty(textbox_tester.Text));

            button_tester.Click();
            Assert.IsTrue(textbox_tester.Text == "clicked");

            textbox_tester.Enter("entered text");
            Assert.IsTrue(textbox_tester.Text == "entered text");
        }
    }
}