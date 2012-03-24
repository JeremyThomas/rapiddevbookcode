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
namespace NUnit.Extensions.Forms.TestApplications
{
  partial class ToolStripButtonTestForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolStripButtonTestForm));
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonOnMain = new System.Windows.Forms.ToolStripButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.toolStrip2 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonInPanel = new System.Windows.Forms.ToolStripButton();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripDropDownButtonOnStatusStrip = new System.Windows.Forms.ToolStripDropDownButton();
      this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
      this.toolStrip6 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonBottomInContainer = new System.Windows.Forms.ToolStripButton();
      this.toolStrip7 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonCenterInContainer = new System.Windows.Forms.ToolStripButton();
      this.toolStrip4 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonLeftInContainer = new System.Windows.Forms.ToolStripButton();
      this.toolStrip5 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonRightInContainer = new System.Windows.Forms.ToolStripButton();
      this.toolStrip3 = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonTopInContainer = new System.Windows.Forms.ToolStripButton();
      this.label1 = new System.Windows.Forms.Label();
      this.toolStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.toolStrip2.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
      this.toolStripContainer1.ContentPanel.SuspendLayout();
      this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
      this.toolStripContainer1.RightToolStripPanel.SuspendLayout();
      this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer1.SuspendLayout();
      this.toolStrip6.SuspendLayout();
      this.toolStrip7.SuspendLayout();
      this.toolStrip4.SuspendLayout();
      this.toolStrip5.SuspendLayout();
      this.toolStrip3.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOnMain});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(354, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButtonOnMain
      // 
      this.toolStripButtonOnMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonOnMain.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOnMain.Image")));
      this.toolStripButtonOnMain.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonOnMain.Name = "toolStripButtonOnMain";
      this.toolStripButtonOnMain.Size = new System.Drawing.Size(23, 22);
      this.toolStripButtonOnMain.Text = "toolStripButton1";
      this.toolStripButtonOnMain.Click += new System.EventHandler(this.toolStripButtonOnMain_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.toolStrip2);
      this.panel1.Location = new System.Drawing.Point(12, 52);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(180, 78);
      this.panel1.TabIndex = 1;
      // 
      // toolStrip2
      // 
      this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInPanel});
      this.toolStrip2.Location = new System.Drawing.Point(0, 0);
      this.toolStrip2.Name = "toolStrip2";
      this.toolStrip2.Size = new System.Drawing.Size(180, 25);
      this.toolStrip2.TabIndex = 0;
      this.toolStrip2.Text = "toolStrip2";
      // 
      // toolStripButtonInPanel
      // 
      this.toolStripButtonInPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonInPanel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInPanel.Image")));
      this.toolStripButtonInPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonInPanel.Name = "toolStripButtonInPanel";
      this.toolStripButtonInPanel.Size = new System.Drawing.Size(23, 22);
      this.toolStripButtonInPanel.Text = "toolStripButton1";
      this.toolStripButtonInPanel.Click += new System.EventHandler(this.toolStripButtonInPanel_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonOnStatusStrip});
      this.statusStrip1.Location = new System.Drawing.Point(0, 328);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(354, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripDropDownButtonOnStatusStrip
      // 
      this.toolStripDropDownButtonOnStatusStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripDropDownButtonOnStatusStrip.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonOnStatusStrip.Image")));
      this.toolStripDropDownButtonOnStatusStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButtonOnStatusStrip.Name = "toolStripDropDownButtonOnStatusStrip";
      this.toolStripDropDownButtonOnStatusStrip.Size = new System.Drawing.Size(29, 20);
      this.toolStripDropDownButtonOnStatusStrip.Text = "toolStripDropDownButton1";
      this.toolStripDropDownButtonOnStatusStrip.Click += new System.EventHandler(this.toolStripDropDownButtonOnStatusStrip_Click);
      // 
      // toolStripContainer1
      // 
      // 
      // toolStripContainer1.BottomToolStripPanel
      // 
      this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip6);
      // 
      // toolStripContainer1.ContentPanel
      // 
      this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip7);
      this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(153, 142);
      // 
      // toolStripContainer1.LeftToolStripPanel
      // 
      this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStrip4);
      this.toolStripContainer1.Location = new System.Drawing.Point(12, 133);
      this.toolStripContainer1.Name = "toolStripContainer1";
      // 
      // toolStripContainer1.RightToolStripPanel
      // 
      this.toolStripContainer1.RightToolStripPanel.Controls.Add(this.toolStrip5);
      this.toolStripContainer1.Size = new System.Drawing.Size(201, 192);
      this.toolStripContainer1.TabIndex = 3;
      this.toolStripContainer1.Text = "toolStripContainer1";
      // 
      // toolStripContainer1.TopToolStripPanel
      // 
      this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip3);
      // 
      // toolStrip6
      // 
      this.toolStrip6.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBottomInContainer});
      this.toolStrip6.Location = new System.Drawing.Point(3, 0);
      this.toolStrip6.Name = "toolStrip6";
      this.toolStrip6.Size = new System.Drawing.Size(35, 25);
      this.toolStrip6.TabIndex = 0;
      // 
      // toolStripButtonBottomInContainer
      // 
      this.toolStripButtonBottomInContainer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonBottomInContainer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBottomInContainer.Image")));
      this.toolStripButtonBottomInContainer.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonBottomInContainer.Name = "toolStripButtonBottomInContainer";
      this.toolStripButtonBottomInContainer.Size = new System.Drawing.Size(23, 22);
      this.toolStripButtonBottomInContainer.Text = "toolStripButton1";
      this.toolStripButtonBottomInContainer.Click += new System.EventHandler(this.toolStripButtonBottomInContainer_Click);
      // 
      // toolStrip7
      // 
      this.toolStrip7.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCenterInContainer});
      this.toolStrip7.Location = new System.Drawing.Point(45, 48);
      this.toolStrip7.Name = "toolStrip7";
      this.toolStrip7.Size = new System.Drawing.Size(35, 25);
      this.toolStrip7.TabIndex = 0;
      this.toolStrip7.Text = "toolStrip7";
      // 
      // toolStripButtonCenterInContainer
      // 
      this.toolStripButtonCenterInContainer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonCenterInContainer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCenterInContainer.Image")));
      this.toolStripButtonCenterInContainer.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonCenterInContainer.Name = "toolStripButtonCenterInContainer";
      this.toolStripButtonCenterInContainer.Size = new System.Drawing.Size(23, 22);
      this.toolStripButtonCenterInContainer.Text = "toolStripButton1";
      this.toolStripButtonCenterInContainer.Click += new System.EventHandler(this.toolStripButtonCenterInContainer_Click);
      // 
      // toolStrip4
      // 
      this.toolStrip4.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLeftInContainer});
      this.toolStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
      this.toolStrip4.Location = new System.Drawing.Point(0, 5);
      this.toolStrip4.Name = "toolStrip4";
      this.toolStrip4.Size = new System.Drawing.Size(24, 34);
      this.toolStrip4.TabIndex = 0;
      this.toolStrip4.Text = "toolStrip4";
      this.toolStrip4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
      // 
      // toolStripButtonLeftInContainer
      // 
      this.toolStripButtonLeftInContainer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonLeftInContainer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLeftInContainer.Image")));
      this.toolStripButtonLeftInContainer.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonLeftInContainer.Name = "toolStripButtonLeftInContainer";
      this.toolStripButtonLeftInContainer.Size = new System.Drawing.Size(22, 20);
      this.toolStripButtonLeftInContainer.Text = "toolStripButton1";
      this.toolStripButtonLeftInContainer.Click += new System.EventHandler(this.toolStripButtonLeftInContainer_Click);
      // 
      // toolStrip5
      // 
      this.toolStrip5.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRightInContainer});
      this.toolStrip5.Location = new System.Drawing.Point(0, 3);
      this.toolStrip5.Name = "toolStrip5";
      this.toolStrip5.Size = new System.Drawing.Size(24, 34);
      this.toolStrip5.TabIndex = 0;
      // 
      // toolStripButtonRightInContainer
      // 
      this.toolStripButtonRightInContainer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonRightInContainer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRightInContainer.Image")));
      this.toolStripButtonRightInContainer.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonRightInContainer.Name = "toolStripButtonRightInContainer";
      this.toolStripButtonRightInContainer.Size = new System.Drawing.Size(22, 20);
      this.toolStripButtonRightInContainer.Text = "toolStripButton1";
      this.toolStripButtonRightInContainer.Click += new System.EventHandler(this.toolStripButtonRightInContainer_Click);
      // 
      // toolStrip3
      // 
      this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonTopInContainer});
      this.toolStrip3.Location = new System.Drawing.Point(3, 0);
      this.toolStrip3.Name = "toolStrip3";
      this.toolStrip3.Size = new System.Drawing.Size(35, 25);
      this.toolStrip3.TabIndex = 0;
      // 
      // toolStripButtonTopInContainer
      // 
      this.toolStripButtonTopInContainer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonTopInContainer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTopInContainer.Image")));
      this.toolStripButtonTopInContainer.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonTopInContainer.Name = "toolStripButtonTopInContainer";
      this.toolStripButtonTopInContainer.Size = new System.Drawing.Size(23, 22);
      this.toolStripButtonTopInContainer.Text = "toolStripButton1";
      this.toolStripButtonTopInContainer.Click += new System.EventHandler(this.toolStripButtonTopInContainer_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(217, 74);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Not Clicked";
      // 
      // ToolStripButtonTestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(354, 350);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.toolStripContainer1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.toolStrip1);
      this.Name = "ToolStripButtonTestForm";
      this.Text = "ToolStripButtonTestForm";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.toolStrip2.ResumeLayout(false);
      this.toolStrip2.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
      this.toolStripContainer1.ContentPanel.ResumeLayout(false);
      this.toolStripContainer1.ContentPanel.PerformLayout();
      this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
      this.toolStripContainer1.RightToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.RightToolStripPanel.PerformLayout();
      this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.PerformLayout();
      this.toolStripContainer1.ResumeLayout(false);
      this.toolStripContainer1.PerformLayout();
      this.toolStrip6.ResumeLayout(false);
      this.toolStrip6.PerformLayout();
      this.toolStrip7.ResumeLayout(false);
      this.toolStrip7.PerformLayout();
      this.toolStrip4.ResumeLayout(false);
      this.toolStrip4.PerformLayout();
      this.toolStrip5.ResumeLayout(false);
      this.toolStrip5.PerformLayout();
      this.toolStrip3.ResumeLayout(false);
      this.toolStrip3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ToolStrip toolStrip2;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    private System.Windows.Forms.ToolStrip toolStrip4;
    private System.Windows.Forms.ToolStripButton toolStripButtonLeftInContainer;
    private System.Windows.Forms.ToolStrip toolStrip5;
    private System.Windows.Forms.ToolStripButton toolStripButtonRightInContainer;
    private System.Windows.Forms.ToolStrip toolStrip3;
    private System.Windows.Forms.ToolStripButton toolStripButtonTopInContainer;
    private System.Windows.Forms.ToolStripButton toolStripButtonOnMain;
    private System.Windows.Forms.ToolStripButton toolStripButtonInPanel;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonOnStatusStrip;
    private System.Windows.Forms.ToolStrip toolStrip6;
    private System.Windows.Forms.ToolStripButton toolStripButtonBottomInContainer;
    private System.Windows.Forms.ToolStrip toolStrip7;
    private System.Windows.Forms.ToolStripButton toolStripButtonCenterInContainer;
    private System.Windows.Forms.Label label1;
  }
}