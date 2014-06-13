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
    public class ContextMenuTest : NUnitFormTest
    {
        private LabelTester label;

        public override void Setup()
        {
            new ContextMenuTestForm().Show();
            label = new LabelTester("myCounterLabel");
        }

        [Test]
        [ExpectedException(typeof (AmbiguousNameException))]
        public void AmbiguousNameBecauseInSubMenusButNotQualified()
        {
            MenuItemTester myMenuItem = new MenuItemTester("Not Ambiguous");
            myMenuItem.Click();
        }

        [Test]
        [ExpectedException(typeof (AmbiguousNameException))]
        public void AmbiguousNameBecauseInTwoMenus()
        {
            MenuItemTester myMenuItem = new MenuItemTester("Test 2.Not Ambiguous");
            myMenuItem.Click();
        }

        [Test]
        [ExpectedException(typeof (AmbiguousNameException))]
        public void AmbiguousNameBecauseWeUseTextNotNameForMenuItems()
        {
            MenuItemTester myMenuItem = new MenuItemTester("Ambiguous");
            myMenuItem.Click();
        }

        [Test]
        public void ContextMenuClick()
        {
            MenuItemTester myMenuItem = new MenuItemTester("Click To Count");
            myMenuItem.Click();
            Assert.AreEqual("1", label.Text);
        }

        [Test]
        public void DontNeedToSpecifyWhichForm()
        {
            MenuItemTester myMenuItem = new MenuItemTester("myCounterLabel.ContextMenu.Test 2.Not Ambiguous");
            myMenuItem.Click();
        }

        [Test]
        public void GeneratedTest()
        {
            MenuItemTester ClickToCount = new MenuItemTester("Click To Count");
            ClickToCount.Click();
            Assert.AreEqual("1", label.Properties.Text);
        }

        [Test]
        [ExpectedException(typeof (NoSuchControlException))]
        public void NoSuchControlFinder()
        {
            MenuItemTester myMenuItem = new MenuItemTester("junkData");
            myMenuItem.Click();
        }

        [Test]
        public void NotAmbiguousNameBecauseInSubMenus()
        {
            MenuItemTester myMenuItem = new MenuItemTester("Test 1.Not Ambiguous");
            myMenuItem.Click();
        }

        [Test]
        public void NotAmbiguousNameBecauseInTwoMenusButQualified()
        {
            //source control property of the menu item is not actually set on the menu item in the tester
            //so handlers that rely on this are currently broken.  I am not sure whether anyone will notice
            //this.
            MenuItemTester myMenuItem = new MenuItemTester("myCounterLabel.ContextMenu.Test 2.Not Ambiguous");
            myMenuItem.Click();
        }
    }
}