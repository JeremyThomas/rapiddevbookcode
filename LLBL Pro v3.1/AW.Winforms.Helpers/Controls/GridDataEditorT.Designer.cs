using System.ComponentModel;
using System.Drawing;

namespace AW.Winforms.Helpers.Controls
{
  partial class GridDataEditorT<T>
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
      ((ISupportInitialize)(this.bindingSourceEnumerable)).BeginInit();
      ((ISupportInitialize)(this.bindingSourcePaging)).BeginInit();
      this.SuspendLayout();
      // 
      // bindingSourcePaging
      // 
      // 
      // GridDataEditorT
      // 
      this.AutoScaleDimensions = new SizeF(6F, 13F);
      this.Name = "GridDataEditorT";
      ((ISupportInitialize)(this.bindingSourceEnumerable)).EndInit();
      ((ISupportInitialize)(this.bindingSourcePaging)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion


  }
}
