namespace AW.Win
{
  partial class FrmEntityViewer
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dataGridViewFields = new System.Windows.Forms.DataGridView();
      this.entityFieldsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.propertyGrid1 = new href.Controls.PropGridEx.PropertyGridEx();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFields)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.entityFieldsBindingSource)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridViewFields
      // 
      this.dataGridViewFields.AllowUserToAddRows = false;
      this.dataGridViewFields.AllowUserToDeleteRows = false;
      this.dataGridViewFields.AllowUserToOrderColumns = true;
      this.dataGridViewFields.AllowUserToResizeRows = false;
      this.dataGridViewFields.AutoGenerateColumns = false;
      this.dataGridViewFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewFields.DataSource = this.entityFieldsBindingSource;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewFields.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridViewFields.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewFields.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewFields.Name = "dataGridViewFields";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewFields.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridViewFields.Size = new System.Drawing.Size(575, 562);
      this.dataGridViewFields.TabIndex = 1;
      // 
      // entityFieldsBindingSource
      // 
      this.entityFieldsBindingSource.DataSource = typeof(SD.LLBLGen.Pro.ORMSupportClasses.IEntityField);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dataGridViewFields);
      this.splitContainer1.Size = new System.Drawing.Size(868, 562);
      this.splitContainer1.SplitterDistance = 289;
      this.splitContainer1.TabIndex = 2;
      // 
      // propertyGrid1
      // 
      this.propertyGrid1.CommandsActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
      this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.SystemColors.ControlDark;
      this.propertyGrid1.CommandsLinkColor = System.Drawing.SystemColors.ActiveCaption;
      this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.propertyGrid1.DrawFlat = true;
      this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new System.Drawing.Size(289, 562);
      this.propertyGrid1.TabIndex = 0;
      // 
      // FrmEntityViewer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(868, 562);
      this.Controls.Add(this.splitContainer1);
      this.Name = "FrmEntityViewer";
      this.Tag = "False";
      this.Text = "Entity Viewer";
      this.Load += new System.EventHandler(this.FrmEntityViewer_Load);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEntityViewer_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFields)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.entityFieldsBindingSource)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewFields;
    private System.Windows.Forms.BindingSource entityFieldsBindingSource;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private href.Controls.PropGridEx.PropertyGridEx propertyGrid1;

  }
}