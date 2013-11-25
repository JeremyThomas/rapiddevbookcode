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
using NUnit.Framework;

namespace NUnit.Extensions.Forms.TestApplications
{
    [TestFixture]
    public class ToolStripMenuTest : NUnitFormTest
    {
        private Form form = null;
        private LabelTester label1 = null;

        public override void Setup()
        {
            form = new ToolStripMenuTestForm();
            form.Show();
            label1 = new LabelTester("label1", form);
        }

        [Test]
        public void InContainerMenu()
        {
            new ToolStripMenuItemTester("itemInContainerToolStripMenuItem").Click();
            Assert.AreEqual("itemInContainerToolStripMenuItem clicked", label1.Text);
        }

        [Test]
        public void InPanelMenu()
        {
            new ToolStripMenuItemTester("itemInPanelToolStripMenuItem").Click();
            Assert.AreEqual("itemInPanelToolStripMenuItem clicked", label1.Text);
        }

        [Test]
        public void MainMenuSubItem()
        {
            new ToolStripMenuItemTester("subItemToolStripMenuItem").Click();
            Assert.AreEqual("subItemToolStripMenuItem clicked", label1.Text);
        }

        [Test]
        public void PlainMenu()
        {
            new ToolStripMenuItemTester("itemToolStripMenuItem").Click();
            Assert.AreEqual("itemToolStripMenuItem clicked", label1.Text);
        }
    }
}