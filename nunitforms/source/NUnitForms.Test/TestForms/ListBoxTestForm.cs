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
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms.TestApplications
{
    /// <summary>
    /// Summary description for ButtonTestForm.
    /// </summary>
    public class ListBoxTestForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        private Label myLabel;

        private ListBox myListBox;

        private ListBox mySingleSelectBox;

        public ListBoxTestForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            int i = int.Parse(myLabel.Text) + 1;
            myLabel.Text = i.ToString();
        }

        private void selectedValueChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (object selectedItem in ((ListBox) sender).SelectedItems)
            {
                sb.Append(selectedItem);
            }
            myLabel.Text = sb.ToString();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myLabel = new Label();
            this.myListBox = new ListBox();
            this.mySingleSelectBox = new ListBox();
            this.SuspendLayout();
            // 
            // myLabel
            // 
            this.myLabel.Location = new Point(176, 16);
            this.myLabel.Name = "myLabel";
            this.myLabel.TabIndex = 1;
            this.myLabel.Text = "0";
            // 
            // myListBox
            // 
            this.myListBox.Items.AddRange(new object[] {"Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet"});
            this.myListBox.Location = new Point(16, 16);
            this.myListBox.Name = "myListBox";
            this.myListBox.SelectionMode = SelectionMode.MultiExtended;
            this.myListBox.Size = new Size(120, 95);
            this.myListBox.TabIndex = 2;
            this.myListBox.SelectedValueChanged += new EventHandler(this.selectedValueChanged);
            // 
            // mySingleSelectBox
            // 
            this.mySingleSelectBox.Items.AddRange(new object[] {"Can", "Only", "Select", "One", "At", "A", "Time"});
            this.mySingleSelectBox.Location = new Point(24, 160);
            this.mySingleSelectBox.Name = "mySingleSelectBox";
            this.mySingleSelectBox.Size = new Size(120, 186);
            this.mySingleSelectBox.TabIndex = 3;
            // 
            // ListBoxTestForm
            // 
            this.AutoScaleDimensions = new SizeF(5, 13);
            this.ClientSize = new Size(384, 389);
            this.Controls.Add(this.mySingleSelectBox);
            this.Controls.Add(this.myListBox);
            this.Controls.Add(this.myLabel);
            this.Name = "ListBoxTestForm";
            this.Text = "ButtonTestForm";
            this.ResumeLayout(false);
        }

        #endregion
    }
}