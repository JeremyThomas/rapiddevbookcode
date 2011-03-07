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

using System;
using NUnit.Framework;

namespace NUnit.Extensions.Forms.TestApplications
{
    [TestFixture]
    [Category("DisplayHidden")]
    [Category("ControlsMouse")]
    [Ignore]
    public class SimpleAPIMouseTest : NUnitFormTest
    {
        public override bool DisplayHidden
        {
            get { return true; }
        }

        private int click;

        private void OnClick(object sender, EventArgs e)
        {
            ++click;
        }

        //this is correct.  we are testing a text box here.  does it fire events
        //when it is supposed to?

        private int click2;

        private void OnClick2(object sender, EventArgs e)
        {
            ++click2;
        }

        //this is correct.  we are testing a text box here.  does it fire events
        //when it is supposed to?  (unusual that we would unit test two controls
        //at the same time.. maybe I don't need this functionality?
        [Test]
        public void CanClickMultipleControls()
        {
            new TextBoxTestForm().Show();
            new TextBoxTester("myTextBox").Properties.Click += new EventHandler(OnClick);
            new TextBoxTester("anotherTextBox").Properties.Click += new EventHandler(OnClick2);

            click = 0;
            click2 = 0;

            Mouse.UseOn("myTextBox");
            Mouse.Click(1, 3);

            Assert.AreEqual(1, click);
            Assert.AreEqual(0, click2);

            Mouse.UseOn("anotherTextBox");
            Mouse.Click(1, 3);

            Assert.AreEqual(1, click);
            Assert.AreEqual(1, click2);
        }

        [Test]
        public void CorrectMouseClicking()
        {
            new TextBoxTestForm().Show();

            TextBoxTester textBox = new TextBoxTester("myTextBox");

            textBox.Properties.Click += new EventHandler(OnClick);

            click = 0;

            Mouse.UseOn(textBox);
            Mouse.Click(1, 3);

            Assert.AreEqual(1, click);
        }

        //this is incorrect.  we are testing the form here.  we should use regular 
        //click method instead.
        [Test]
        public void IncorrectMouseClicking()
        {
            new ButtonTestForm().Show();
            ButtonTester button = new ButtonTester("myButton");
            LabelTester label = new LabelTester("myLabel");
            Mouse.UseOn(button);
            Mouse.Click(1, 3);
            Assert.AreEqual(label.Text, "1");
        }

        //this is incorrect.  we are testing the form here.  we should use regular 
        //click method instead.  consider this an example of the mouse and some of
        //the new api features ( not an example of testing a form... )
        [Test]
        public void IncorrectMouseClickingSimplifiedAPI()
        {
            new ButtonTestForm().Show();

            Mouse.UseOn("myButton");
            Mouse.Click(1, 3);
            Mouse.Click(1, 3);

            Assert.AreEqual(new ControlTester("myLabel")["Text"], "2");
        }
    }
}