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
  partial class ToolStripMenuTestForm
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
      this.menuStripInContainer = new System.Windows.Forms.MenuStrip();
      this.mainInContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.itemInContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.mainInPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.itemInPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.subItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer1.SuspendLayout();
      this.menuStripInContainer.SuspendLayout();
      this.panel1.SuspendLayout();
      this.menuStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(396, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mainToolStripMenuItem
      // 
      this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem});
      this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
      this.mainToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
      this.mainToolStripMenuItem.Text = "Main";
      // 
      // itemToolStripMenuItem
      // 
      this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItemToolStripMenuItem});
      this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
      this.itemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.itemToolStripMenuItem.Text = "Item";
      this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 342);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Not Clicked";
      // 
      // toolStripContainer1
      // 
      // 
      // toolStripContainer1.ContentPanel
      // 
      this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(268, 51);
      this.toolStripContainer1.Location = new System.Drawing.Point(12, 67);
      this.toolStripContainer1.Name = "toolStripContainer1";
      this.toolStripContainer1.Size = new System.Drawing.Size(268, 75);
      this.toolStripContainer1.TabIndex = 2;
      this.toolStripContainer1.Text = "toolStripContainer1";
      // 
      // toolStripContainer1.TopToolStripPanel
      // 
      this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStripInContainer);
      // 
      // menuStripInContainer
      // 
      this.menuStripInContainer.Dock = System.Windows.Forms.DockStyle.None;
      this.menuStripInContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainInContainerToolStripMenuItem});
      this.menuStripInContainer.Location = new System.Drawing.Point(0, 0);
      this.menuStripInContainer.Name = "menuStripInContainer";
      this.menuStripInContainer.Size = new System.Drawing.Size(268, 24);
      this.menuStripInContainer.TabIndex = 0;
      this.menuStripInContainer.Text = "Main in Container";
      // 
      // mainInContainerToolStripMenuItem
      // 
      this.mainInContainerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemInContainerToolStripMenuItem});
      this.mainInContainerToolStripMenuItem.Name = "mainInContainerToolStripMenuItem";
      this.mainInContainerToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
      this.mainInContainerToolStripMenuItem.Text = "Main In Container";
      // 
      // itemInContainerToolStripMenuItem
      // 
      this.itemInContainerToolStripMenuItem.Name = "itemInContainerToolStripMenuItem";
      this.itemInContainerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
      this.itemInContainerToolStripMenuItem.Text = "Item In Container";
      this.itemInContainerToolStripMenuItem.Click += new System.EventHandler(this.itemInContainerToolStripMenuItem_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.menuStrip2);
      this.panel1.Location = new System.Drawing.Point(12, 182);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(200, 100);
      this.panel1.TabIndex = 4;
      // 
      // menuStrip2
      // 
      this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainInPanelToolStripMenuItem});
      this.menuStrip2.Location = new System.Drawing.Point(0, 0);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(200, 24);
      this.menuStrip2.TabIndex = 0;
      this.menuStrip2.Text = "Main In Panel";
      // 
      // mainInPanelToolStripMenuItem
      // 
      this.mainInPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemInPanelToolStripMenuItem});
      this.mainInPanelToolStripMenuItem.Name = "mainInPanelToolStripMenuItem";
      this.mainInPanelToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
      this.mainInPanelToolStripMenuItem.Text = "Main In Panel";
      // 
      // itemInPanelToolStripMenuItem
      // 
      this.itemInPanelToolStripMenuItem.Name = "itemInPanelToolStripMenuItem";
      this.itemInPanelToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.itemInPanelToolStripMenuItem.Text = "Item In Panel";
      this.itemInPanelToolStripMenuItem.Click += new System.EventHandler(this.itemInPanelToolStripMenuItem_Click);
      // 
      // subItemToolStripMenuItem
      // 
      this.subItemToolStripMenuItem.Name = "subItemToolStripMenuItem";
      this.subItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.subItemToolStripMenuItem.Text = "Sub Item";
      this.subItemToolStripMenuItem.Click += new System.EventHandler(this.subItemToolStripMenuItem_Click);
      // 
      // ToolStripMenuTestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(396, 413);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.toolStripContainer1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "ToolStripMenuTestForm";
      this.Text = "ToolStripMenuTestForm";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.PerformLayout();
      this.toolStripContainer1.ResumeLayout(false);
      this.toolStripContainer1.PerformLayout();
      this.menuStripInContainer.ResumeLayout(false);
      this.menuStripInContainer.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.menuStrip2.ResumeLayout(false);
      this.menuStrip2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    private System.Windows.Forms.MenuStrip menuStripInContainer;
    private System.Windows.Forms.ToolStripMenuItem mainInContainerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem itemInContainerToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem mainInPanelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem itemInPanelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem subItemToolStripMenuItem;
  }
}