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

using System.Windows.Forms;
using NUnit.Framework;

namespace NUnit.Extensions.Forms.TestApplications
{
    [TestFixture]
    public class ListViewTest : NUnitFormTest
    {
        private ListViewTestForm listViewForm = null;

        private ListViewTester listViewDetails = null;

        public override void Setup()
        {
            base.Setup();
            listViewForm = new ListViewTestForm();
            listViewDetails = new ListViewTester("listViewDetails", listViewForm);
        }

        private ListViewItem[] ColorList()
        {
            listViewForm.Show();
            return
                new ListViewItem[]
                    {
                        new ListViewItem("Red"), new ListViewItem("Orange"), new ListViewItem("Yellow"),
                        new ListViewItem("Green"), new ListViewItem("Blue"), new ListViewItem("Indigo"),
                        new ListViewItem("Violet")
                    };
        }

        [Test]
        public void AllowSingleSelectonly()
        {
            listViewDetails.Properties.MultiSelect = false;
            listViewDetails.Items.AddRange(ColorList());
            listViewForm.Show();

            string[] selectedColors = new string[] {"Red"};
            listViewDetails.SelectItems(selectedColors);
            Assert.IsTrue(listViewDetails.SelectedItemsMatch(selectedColors));

            selectedColors = new string[] {"Red", "Violet"};
            listViewDetails.SelectItems(selectedColors);
            Assert.IsFalse(listViewDetails.SelectedItemsMatch(selectedColors));
        }

        [Test]
        public void ColorSelectionTest()
        {
            listViewForm.Show();
            listViewDetails.Items.AddRange(ColorList());
            string[] selectedColors = new string[] {"Red", "Violet"};
            listViewDetails.SelectItems(selectedColors);
            Assert.IsTrue(listViewDetails.SelectedItemsMatch(selectedColors));
        }

        [Test]
        public void ShowListViewForm()
        {
            listViewForm.Show();
            Assert.IsTrue(listViewDetails.Properties.Visible);
        }
    }
}