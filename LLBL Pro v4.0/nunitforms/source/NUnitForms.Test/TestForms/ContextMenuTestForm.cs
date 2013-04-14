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
using System.Windows.Forms;

namespace NUnit.Extensions.Forms.TestApplications
{
    /// <summary>
    /// Summary description for ContextMenuTestForm.
    /// </summary>
    public class ContextMenuTestForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        private MenuItem menuItem1;

        private MenuItem menuItem2;

        private MenuItem menuItem3;

        private MenuItem menuItem4;

        private MenuItem menuItem5;

        private MenuItem menuItem6;

        private MenuItem menuItem7;

        private MenuItem menuItem8;
        private Label myCounterLabel;
        private MenuItem myFirstMenuItem;
        private Label myLabel;
        private ContextMenu myLabelContextMenu;
        private ContextMenu secondMenu;

        public ContextMenuTestForm()
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

        private void myFirstMenuItem_Click(object sender, EventArgs e)
        {
            int i = int.Parse(myCounterLabel.Text) + 1;
            myCounterLabel.Text = i.ToString();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myLabel = new Label();
            this.myLabelContextMenu = new ContextMenu();
            this.myFirstMenuItem = new MenuItem();
            this.menuItem1 = new MenuItem();
            this.menuItem2 = new MenuItem();
            this.menuItem3 = new MenuItem();
            this.menuItem5 = new MenuItem();
            this.menuItem4 = new MenuItem();
            this.menuItem6 = new MenuItem();
            this.myCounterLabel = new Label();
            this.secondMenu = new ContextMenu();
            this.menuItem7 = new MenuItem();
            this.menuItem8 = new MenuItem();
            this.SuspendLayout();
            // 
            // myLabel
            // 
            this.myLabel.ContextMenu = this.myLabelContextMenu;
            this.myLabel.Location = new Point(32, 40);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new Size(100, 48);
            this.myLabel.TabIndex = 0;
            this.myLabel.Text = "Right click me for a context menu";
            // 
            // myLabelContextMenu
            // 
            this.myLabelContextMenu.MenuItems.AddRange(
                new MenuItem[]
                    {this.myFirstMenuItem, this.menuItem1, this.menuItem2, this.menuItem3, this.menuItem4});
            // 
            // myFirstMenuItem
            // 
            this.myFirstMenuItem.Index = 0;
            this.myFirstMenuItem.Text = "Click To Count";
            this.myFirstMenuItem.Click += new EventHandler(this.myFirstMenuItem_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "Ambiguous";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "Ambiguous";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.MenuItems.AddRange(new MenuItem[] {this.menuItem5});
            this.menuItem3.Text = "Test 1";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Not Ambiguous";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.MenuItems.AddRange(new MenuItem[] {this.menuItem6});
            this.menuItem4.Text = "Test 2";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Not Ambiguous";
            // 
            // myCounterLabel
            // 
            this.myCounterLabel.ContextMenu = this.secondMenu;
            this.myCounterLabel.Location = new Point(184, 48);
            this.myCounterLabel.Name = "myCounterLabel";
            this.myCounterLabel.TabIndex = 1;
            this.myCounterLabel.Text = "0";
            // 
            // secondMenu
            // 
            this.secondMenu.MenuItems.AddRange(new MenuItem[] {this.menuItem7});
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.MenuItems.AddRange(new MenuItem[] {this.menuItem8});
            this.menuItem7.Text = "Test 2";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Text = "Not Ambiguous";
            // 
            // ContextMenuTestForm
            // 
            this.AutoScaleDimensions = new SizeF(5, 13);
            this.ClientSize = new Size(336, 149);
            this.Controls.Add(this.myCounterLabel);
            this.Controls.Add(this.myLabel);
            this.Name = "ContextMenuTestForm";
            this.Text = "ContextMenuTestForm";
            this.ResumeLayout(false);
        }

        #endregion
    }
}