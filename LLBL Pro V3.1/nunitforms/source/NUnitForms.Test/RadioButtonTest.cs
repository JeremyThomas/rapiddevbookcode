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

using NUnit.Framework;

namespace NUnit.Extensions.Forms.TestApplications
{
    [TestFixture]
    public class RadioButtonTest : NUnitFormTest
    {
        public override void Setup()
        {
            new RadioButtonTestForm().Show();
        }

        [Test]
        public void SelectOption()
        {
            RadioButtonTester rbRed = new RadioButtonTester("rbRed");
            LabelTester lblSelectedColor = new LabelTester("lblSelectedColor");
            RadioButtonTester rbOrange = new RadioButtonTester("rbOrange");
            RadioButtonTester rbGreen = new RadioButtonTester("rbGreen");
            RadioButtonTester rbYellow = new RadioButtonTester("rbYellow");
            RadioButtonTester rbBlue = new RadioButtonTester("rbBlue");
            RadioButtonTester rbIndigo = new RadioButtonTester("rbIndigo");
            RadioButtonTester rbViolet = new RadioButtonTester("rbViolet");

            rbRed.Click();
            Assert.AreEqual("Red", lblSelectedColor.Properties.Text);
            Assert.AreEqual(true, rbRed.Properties.Checked);
            Assert.AreEqual(false, rbOrange.Properties.Checked);
            Assert.AreEqual("Red", rbRed.Text);
            Assert.AreEqual("Red", rbRed.Properties.Text);

            rbOrange.Click();
            Assert.AreEqual("Orange", lblSelectedColor.Properties.Text);
            Assert.AreEqual(false, rbRed.Properties.Checked);
            Assert.AreEqual(true, rbOrange.Properties.Checked);
            Assert.AreEqual("Orange", rbOrange.Text);
            Assert.AreEqual("Orange", rbOrange.Properties.Text);
        }
    }
}