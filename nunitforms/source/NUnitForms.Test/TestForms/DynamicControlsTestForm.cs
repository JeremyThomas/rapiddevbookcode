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
    /// Summary description for DynamicControlsTestForm.
    /// </summary>
    public class DynamicControlsTestForm : Form
    {
        private Button addButton;

        private Button btnAddDuplicate;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        private int i = 0;

        public DynamicControlsTestForm()
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

        private void addButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "0";
            b.Name = "button" + i.ToString();
            b.Location = new Point(250, 25*i + 20);
            Controls.Add(b);
            b.Click += new EventHandler(b_Click);
            i++;
        }

        private void b_Click(object sender, EventArgs e)
        {
            int i = int.Parse(((Button) sender).Text) + 1;
            ((Button) sender).Text = i.ToString();
        }

        private void btnAddDuplicate_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "0";
            b.Name = "duplicate";
            b.Location = new Point(250, 25*i + 20);
            Controls.Add(b);
            b.Click += new EventHandler(b_Click);
            i++;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new Button();
            this.btnAddDuplicate = new Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new Point(24, 32);
            this.addButton.Name = "addButton";
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.Click += new EventHandler(this.addButton_Click);
            // 
            // btnAddDuplicate
            // 
            this.btnAddDuplicate.Location = new Point(24, 192);
            this.btnAddDuplicate.Name = "btnAddDuplicate";
            this.btnAddDuplicate.Size = new Size(104, 23);
            this.btnAddDuplicate.TabIndex = 1;
            this.btnAddDuplicate.Text = "AddDuplicate";
            this.btnAddDuplicate.Click += new EventHandler(this.btnAddDuplicate_Click);
            // 
            // DynamicControlsTestForm
            // 
            this.AutoScaleDimensions = new SizeF(5, 13);
            this.ClientSize = new Size(624, 273);
            this.Controls.Add(this.btnAddDuplicate);
            this.Controls.Add(this.addButton);
            this.Name = "DynamicControlsTestForm";
            this.Text = "DynamicControlsTestForm";
            this.ResumeLayout(false);
        }

        #endregion
    }
}