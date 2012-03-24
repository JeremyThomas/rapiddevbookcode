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
    public class MainMenuTest : NUnitFormTest
    {
        private LabelTester label = new LabelTester("label");

        public override void Setup()
        {
            new MainMenuTestForm().Show();
        }

        private void ClickAndTest(string name)
        {
            new MenuItemTester(name).Click();
            Assert.AreEqual("clicked", label.Text);
        }

        [Test]
        [ExpectedException(typeof (NoSuchControlException))]
        public void CantUseAmpsInName()
        {
            ClickAndTest("Main.With &Alt Key");
        }

        [Test]
        [ExpectedException(typeof (NoSuchControlException))]
        public void CantUseDotInName()
        {
            ClickAndTest("Main.With Dots...");
        }

        [Test]
        public void FormQualifiedMenuItem()
        {
            ClickAndTest("MainMenuTestForm.MainMenu.Main.Item");
        }

        [Test]
        public void FullyQualifiedMenuItem()
        {
            ClickAndTest("MainMenu.Main.Item");
        }

        [Test]
        public void ItemWithAltKey()
        {
            ClickAndTest("Main.With Alt Key");
        }

        [Test]
        public void ItemWithDot()
        {
            ClickAndTest("Main.With Dots");
        }

        [Test]
        public void MenuPopup()
        {
            new MenuItemTester("Main").Popup();
            Assert.AreEqual("shown", label.Text);
        }

        [Test]
        public void PartiallyQualifiedSubMenuItem()
        {
            ClickAndTest("Sub Menu.Sub Menu Item");
        }

        [Test]
        public void PlainMenu()
        {
            ClickAndTest("Item");
        }

        [Test]
        public void QualifiedMenu()
        {
            ClickAndTest("Main.Item");
        }

        [Test]
        public void SubMenuItem()
        {
            ClickAndTest("Sub Menu Item");
        }
    }
}