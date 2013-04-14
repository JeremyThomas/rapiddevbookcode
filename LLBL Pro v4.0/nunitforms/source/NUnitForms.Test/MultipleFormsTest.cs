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

using System.Windows.Forms;
using NUnit.Framework;

namespace NUnit.Extensions.Forms.TestApplications
{
    [TestFixture]
    public class MultipleFormsTest : NUnitFormTest
    {
        private void ShowForm(Form f)
        {
            f.Show();
        }

        [Test]
        [ExpectedException(typeof (AmbiguousNameException))]
        public void AmbiguousNameWithMultipleForms()
        {
            ShowForm(new ButtonTestForm());
            ShowForm(new ButtonTestForm());

            ButtonTester myButton = new ButtonTester("myButton");
            myButton.Click();
        }

        [Test]
        public void DontNeedToSpecifyForm()
        {
            ShowForm(new ButtonTestForm());
            ShowForm(new TabControlTestForm());

            ButtonTester myButton = new ButtonTester("myButton");
            LabelTester myLabel = new LabelTester("myLabel");
            TabControlTester myTabs = new TabControlTester("myTabs");
            ButtonTester tabButton = new ButtonTester("button2");
            LabelTester tabLabel = new LabelTester("label2");

            myTabs.SelectTab(1);
            Assert.AreEqual("0", tabLabel.Text);

            Assert.AreEqual("0", myLabel.Text);
            myButton.Click();
            Assert.AreEqual("1", myLabel.Text);

            tabButton.Click();
            Assert.AreEqual("1", tabLabel.Text);
        }

        [Test]
        public void TestMultipleForms()
        {
            MultiForm form = new MultiForm();
            form.Show();

            ButtonTester buttonOne = new ButtonTester("myButton", "Form");
            ButtonTester buttonTwo = new ButtonTester("myButton", "Form-0");
            ButtonTester buttonThree = new ButtonTester("myButton", "Form-0-0");
            ButtonTester buttonFour = new ButtonTester("myButton", "Form-1");

            buttonOne.Click();
            buttonTwo.Click();
            buttonThree.Click();
            buttonOne.Click();
            buttonFour.Click();
        }

        [Test]
        [ExpectedException(typeof (NoSuchControlException), ExpectedMessage= "Could not find form with name 'Form-1'")]
        public void TestMultipleFormsShouldNotFindLastButton()
        {
            MultiForm form = new MultiForm();
            form.Show();

            ButtonTester buttonOne = new ButtonTester("myButton", "Form");
            ButtonTester buttonTwo = new ButtonTester("myButton", "Form-0");
            ButtonTester buttonThree = new ButtonTester("myButton", "Form-0-0");
            ButtonTester buttonFour = new ButtonTester("myButton", "Form-1");

            buttonOne.Click();
            buttonTwo.Click();
            buttonThree.Click();
            buttonFour.Click();
        }
    }
}