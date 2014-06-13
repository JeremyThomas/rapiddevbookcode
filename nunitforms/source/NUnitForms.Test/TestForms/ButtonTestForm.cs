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
    /// Summary description for ButtonTestForm.
    /// </summary>
    public class ButtonTestForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        private Button myButton;

        private Label myLabel;

        public ButtonTestForm()
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myButton = new Button();
            this.myLabel = new Label();
            this.SuspendLayout();
            // 
            // myButton
            // 
            this.myButton.Location = new Point(16, 16);
            this.myButton.Name = "myButton";
            this.myButton.TabIndex = 0;
            this.myButton.Text = "button1";
            this.myButton.Click += new EventHandler(this.myButton_Click);
            // 
            // myLabel
            // 
            this.myLabel.Location = new Point(112, 16);
            this.myLabel.Name = "myLabel";
            this.myLabel.TabIndex = 1;
            this.myLabel.Text = "0";
            // 
            // ButtonTestForm
            // 
            this.AutoScaleDimensions = new SizeF(5, 13);
            this.ClientSize = new Size(280, 61);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.myButton);
            this.Name = "ButtonTestForm";
            this.Text = "ButtonTestForm";
            this.ResumeLayout(true);
        }

        #endregion
    }
}