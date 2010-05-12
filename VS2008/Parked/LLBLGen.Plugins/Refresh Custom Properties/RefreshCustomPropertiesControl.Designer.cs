namespace WB.LLBLGen.Pro.Plugins
{
  partial class RefreshCustomPropertiesControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.IgnoreMsDesignerInfo = new System.Windows.Forms.CheckBox();
      this.TypedListMap = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // IgnoreMsDesignerInfo
      // 
      this.IgnoreMsDesignerInfo.AutoSize = true;
      this.IgnoreMsDesignerInfo.Checked = true;
      this.IgnoreMsDesignerInfo.CheckState = System.Windows.Forms.CheckState.Checked;
      this.IgnoreMsDesignerInfo.Location = new System.Drawing.Point(4, 14);
      this.IgnoreMsDesignerInfo.Name = "IgnoreMsDesignerInfo";
      this.IgnoreMsDesignerInfo.Size = new System.Drawing.Size(316, 17);
      this.IgnoreMsDesignerInfo.TabIndex = 0;
      this.IgnoreMsDesignerInfo.Text = "Ignore Microsoft Designer Properties (except MS_Description)";
      this.IgnoreMsDesignerInfo.UseVisualStyleBackColor = true;
      // 
      // TypedListMap
      // 
      this.TypedListMap.AutoSize = true;
      this.TypedListMap.Location = new System.Drawing.Point(4, 37);
      this.TypedListMap.Name = "TypedListMap";
      this.TypedListMap.Size = new System.Drawing.Size(308, 17);
      this.TypedListMap.TabIndex = 1;
      this.TypedListMap.Text = "Map properties from actual field to Typed List field properties";
      this.TypedListMap.UseVisualStyleBackColor = true;
      // 
      // RefreshCustomPropertiesControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.TypedListMap);
      this.Controls.Add(this.IgnoreMsDesignerInfo);
      this.Name = "RefreshCustomPropertiesControl";
      this.Size = new System.Drawing.Size(327, 145);
      this.Load += new System.EventHandler(this.RefreshCustomPropertiesControl_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox IgnoreMsDesignerInfo;
    private System.Windows.Forms.CheckBox TypedListMap;
  }
}