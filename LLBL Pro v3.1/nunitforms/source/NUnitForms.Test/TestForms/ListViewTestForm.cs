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

using System.ComponentModel;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms.TestApplications
{
    public class ListViewTestForm : Form
    {
        private Container components = null;
        private ListView listViewDetails;

        public ListViewTestForm()
        {
            InitializeComponent();
        }

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewDetails = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewDetails
            // 
            this.listViewDetails.CheckBoxes = true;
            this.listViewDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDetails.FullRowSelect = true;
            this.listViewDetails.Location = new System.Drawing.Point(0, 0);
            this.listViewDetails.Name = "listViewDetails";
            this.listViewDetails.Size = new System.Drawing.Size(472, 456);
            this.listViewDetails.TabIndex = 0;
            this.listViewDetails.View = System.Windows.Forms.View.Details;
            // 
            // ListViewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6, 15);
            this.ClientSize = new System.Drawing.Size(472, 456);
            this.Controls.Add(this.listViewDetails);
            this.Name = "ListViewTestForm";
            this.Text = "ListViewTestForm";
            this.ResumeLayout(false);
        }

        #endregion
    }
}