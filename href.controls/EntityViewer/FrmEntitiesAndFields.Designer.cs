﻿namespace AW.Winforms.Helpers.EntityViewer
{
  partial class FrmEntitiesAndFields
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
      this.treeViewEntities = new System.Windows.Forms.TreeView();
      this.SuspendLayout();
      // 
      // treeViewEntities
      // 
      this.treeViewEntities.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeViewEntities.Location = new System.Drawing.Point(0, 0);
      this.treeViewEntities.Name = "treeViewEntities";
      this.treeViewEntities.Size = new System.Drawing.Size(292, 585);
      this.treeViewEntities.TabIndex = 1;
      this.treeViewEntities.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewEntities_ItemDrag);
      // 
      // FrmEntitiesAndFields
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 585);
      this.Controls.Add(this.treeViewEntities);
      this.Name = "FrmEntitiesAndFields";
      this.Text = "Entities And Fields";
      this.Load += new System.EventHandler(this.EntitiesAndFields_Load);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEntitiesAndFields_FormClosed);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TreeView treeViewEntities;
  }
}