#region Copyright (c) 2003-2005, Luke T. Maxon

/********************************************************************************************************************
'
' Copyright (c) 2003-2005, Luke T. Maxon
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

//Contributed by: Ian Cooper

using NUnit.Framework;

namespace NUnit.Extensions.Forms.TestApplications
{
    [TestFixture]
    public class ToolbarTest : NUnitFormTest
    {
        private LabelTester labelToolbarSelection;
        private ToolBarTester toolbarTest;


        public override void Setup()
        {
            new ToolbarTestForm().Show();
            labelToolbarSelection = new LabelTester("labelToolbarSelection");
            toolbarTest = new ToolBarTester("toolBarTest");
        }

        [Test]
        public void ClickToolbarButton()
        {
            ToolBarButtonTester button = toolbarTest.GetButton("Open");
            button.Click();
            Assert.AreEqual("Open", labelToolbarSelection.Text);

            button = toolbarTest.GetButton("Previous");
            button.Click();
            Assert.AreEqual("Previous", labelToolbarSelection.Text);
        }

        [Test]
        public void DropDownButtonTest()
        {
            ToolBarButtonTester button = toolbarTest.GetButton("Color");
            button.ClickDropDownMenuItem("Red");
            Assert.AreEqual("Red", labelToolbarSelection.Text);

            button = toolbarTest.GetButton("Color");
            button.ClickDropDownMenuItem("Violet");
            Assert.AreEqual("Violet", labelToolbarSelection.Text);
        }

        [Test]
        public void GetToolbar()
        {
            Assert.IsTrue(toolbarTest.Properties.Visible);
        }

        [Test]
        public void ToggleButtonTest()
        {
            ToolBarButtonTester button = toolbarTest.GetButton(7);
            button.Push();
            Assert.IsTrue(button.Pushed);

            button.PartialPush();
            Assert.IsTrue(button.PartialPushed);
            button.PartialPush();
            Assert.IsFalse(button.PartialPushed);
        }
    }
}