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
    /// Summary description for RadioButtonTestForm.
    /// </summary>
    public class RadioButtonTestForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        private GroupBox grpColors;

        private Label lblSelectedColor;

        private RadioButton rbBlue;
        private RadioButton rbGreen;

        private RadioButton rbIndigo;
        private RadioButton rbOrange;
        private RadioButton rbRed;

        private RadioButton rbViolet;
        private RadioButton rbYellow;

        public RadioButtonTestForm()
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

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton) sender;
            lblSelectedColor.Text = (string) rb.Tag;
        }

        private void RadioButtonTestForm_Load(object sender, EventArgs e)
        {
            rbRed.Tag = "Red";
            rbOrange.Tag = "Orange";
            rbGreen.Tag = "Green";
            rbYellow.Tag = "Yellow";
            rbBlue.Tag = "Blue";
            rbIndigo.Tag = "Indigo";
            rbViolet.Tag = "Violet";
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpColors = new GroupBox();
            this.rbViolet = new RadioButton();
            this.rbIndigo = new RadioButton();
            this.rbBlue = new RadioButton();
            this.rbYellow = new RadioButton();
            this.rbGreen = new RadioButton();
            this.rbOrange = new RadioButton();
            this.rbRed = new RadioButton();
            this.lblSelectedColor = new Label();
            this.grpColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpColors
            // 
            this.grpColors.Controls.Add(this.rbViolet);
            this.grpColors.Controls.Add(this.rbIndigo);
            this.grpColors.Controls.Add(this.rbBlue);
            this.grpColors.Controls.Add(this.rbYellow);
            this.grpColors.Controls.Add(this.rbGreen);
            this.grpColors.Controls.Add(this.rbOrange);
            this.grpColors.Controls.Add(this.rbRed);
            this.grpColors.Location = new Point(8, 16);
            this.grpColors.Name = "grpColors";
            this.grpColors.Size = new Size(272, 248);
            this.grpColors.TabIndex = 0;
            this.grpColors.TabStop = false;
            this.grpColors.Text = "Colors";
            // 
            // rbViolet
            // 
            this.rbViolet.Location = new Point(8, 208);
            this.rbViolet.Name = "rbViolet";
            this.rbViolet.TabIndex = 6;
            this.rbViolet.Text = "Violet";
            this.rbViolet.Click += new EventHandler(this.rb_CheckedChanged);
            // 
            // rbIndigo
            // 
            this.rbIndigo.Location = new Point(8, 176);
            this.rbIndigo.Name = "rbIndigo";
            this.rbIndigo.TabIndex = 5;
            this.rbIndigo.Text = "Indigo";
            this.rbIndigo.Click += new EventHandler(this.rb_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.Location = new Point(8, 144);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.TabIndex = 4;
            this.rbBlue.Text = "Blue";
            this.rbBlue.Click += new EventHandler(this.rb_CheckedChanged);
            // 
            // rbYellow
            // 
            this.rbYellow.Location = new Point(8, 112);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.TabIndex = 3;
            this.rbYellow.Text = "Yellow";
            this.rbYellow.Click += new EventHandler(this.rb_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.Location = new Point(8, 80);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.TabIndex = 2;
            this.rbGreen.Text = "Green";
            this.rbGreen.Click += new EventHandler(this.rb_CheckedChanged);
            // 
            // rbOrange
            // 
            this.rbOrange.Location = new Point(8, 48);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.TabIndex = 1;
            this.rbOrange.Text = "Orange";
            this.rbOrange.Click += new EventHandler(this.rb_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.Location = new Point(8, 16);
            this.rbRed.Name = "rbRed";
            this.rbRed.TabIndex = 0;
            this.rbRed.Text = "Red";
            this.rbRed.CheckedChanged += new EventHandler(this.rb_CheckedChanged);
            // 
            // lblSelectedColor
            // 
            this.lblSelectedColor.Location = new Point(8, 288);
            this.lblSelectedColor.Name = "lblSelectedColor";
            this.lblSelectedColor.TabIndex = 1;
            // 
            // RadioButtonTestForm
            // 
            this.AutoScaleDimensions = new SizeF(6, 15);
            this.ClientSize = new Size(292, 336);
            this.Controls.Add(this.lblSelectedColor);
            this.Controls.Add(this.grpColors);
            this.Name = "RadioButtonTestForm";
            this.Text = "RadioButtonTestForm";
            this.Load += new EventHandler(this.RadioButtonTestForm_Load);
            this.grpColors.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}