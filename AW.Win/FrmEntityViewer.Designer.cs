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
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.isChangedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.isNullDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.isNullableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.isReadOnlyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.fieldIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.isPrimaryKeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.actualDotNetTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sourceCatalogNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sourceSchemaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sourceObjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sourceColumnNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sourceColumnMaxLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sourceColumnDbTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sourceColumnIsNullableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.sourceColumnScaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sourceColumnPrecisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.isIdentityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.identityValueSequenceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.typeConverterToUseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.linkedSuperTypeFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.maxLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.scaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.precisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.aliasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.containingObjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.objectAliasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.aggregateFunctionToApplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.expressionToApplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.isForeignKeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.actualContainingObjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.isInMultiTargetEntityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.actAsDerivedTableFieldDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.entityFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.propertyGrid1 = new href.Controls.PropGridEx.PropertyGridEx();
      this.propertyGrid2 = new System.Windows.Forms.PropertyGrid();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.selectObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.dataGridViewEnumerable = new System.Windows.Forms.DataGridView();
      this.bindingSourceEnumerable = new System.Windows.Forms.BindingSource(this.components);
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.currentValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dbValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFields)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.entityFieldBindingSource)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnumerable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnumerable)).BeginInit();
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
      this.dataGridViewFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.isChangedDataGridViewCheckBoxColumn,
            this.isNullDataGridViewCheckBoxColumn,
            this.dataTypeDataGridViewTextBoxColumn,
            this.isNullableDataGridViewCheckBoxColumn,
            this.isReadOnlyDataGridViewCheckBoxColumn,
            this.fieldIndexDataGridViewTextBoxColumn,
            this.isPrimaryKeyDataGridViewCheckBoxColumn,
            this.actualDotNetTypeDataGridViewTextBoxColumn,
            this.sourceCatalogNameDataGridViewTextBoxColumn,
            this.sourceSchemaNameDataGridViewTextBoxColumn,
            this.sourceObjectNameDataGridViewTextBoxColumn,
            this.sourceColumnNameDataGridViewTextBoxColumn,
            this.sourceColumnMaxLengthDataGridViewTextBoxColumn,
            this.sourceColumnDbTypeDataGridViewTextBoxColumn,
            this.sourceColumnIsNullableDataGridViewCheckBoxColumn,
            this.sourceColumnScaleDataGridViewTextBoxColumn,
            this.sourceColumnPrecisionDataGridViewTextBoxColumn,
            this.isIdentityDataGridViewCheckBoxColumn,
            this.identityValueSequenceNameDataGridViewTextBoxColumn,
            this.typeConverterToUseDataGridViewTextBoxColumn,
            this.linkedSuperTypeFieldDataGridViewTextBoxColumn,
            this.maxLengthDataGridViewTextBoxColumn,
            this.scaleDataGridViewTextBoxColumn,
            this.precisionDataGridViewTextBoxColumn,
            this.aliasDataGridViewTextBoxColumn,
            this.containingObjectNameDataGridViewTextBoxColumn,
            this.objectAliasDataGridViewTextBoxColumn,
            this.aggregateFunctionToApplyDataGridViewTextBoxColumn,
            this.expressionToApplyDataGridViewTextBoxColumn,
            this.isForeignKeyDataGridViewCheckBoxColumn,
            this.actualContainingObjectNameDataGridViewTextBoxColumn,
            this.isInMultiTargetEntityDataGridViewCheckBoxColumn,
            this.actAsDerivedTableFieldDataGridViewCheckBoxColumn,
            this.currentValueDataGridViewTextBoxColumn,
            this.dbValueDataGridViewTextBoxColumn});
      this.dataGridViewFields.DataSource = this.entityFieldBindingSource;
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
      this.dataGridViewFields.Size = new System.Drawing.Size(575, 281);
      this.dataGridViewFields.TabIndex = 1;
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      this.nameDataGridViewTextBoxColumn.ReadOnly = true;
      this.nameDataGridViewTextBoxColumn.Width = 60;
      // 
      // isChangedDataGridViewCheckBoxColumn
      // 
      this.isChangedDataGridViewCheckBoxColumn.DataPropertyName = "IsChanged";
      this.isChangedDataGridViewCheckBoxColumn.HeaderText = "IsChanged";
      this.isChangedDataGridViewCheckBoxColumn.Name = "isChangedDataGridViewCheckBoxColumn";
      this.isChangedDataGridViewCheckBoxColumn.Width = 64;
      // 
      // isNullDataGridViewCheckBoxColumn
      // 
      this.isNullDataGridViewCheckBoxColumn.DataPropertyName = "IsNull";
      this.isNullDataGridViewCheckBoxColumn.HeaderText = "IsNull";
      this.isNullDataGridViewCheckBoxColumn.Name = "isNullDataGridViewCheckBoxColumn";
      this.isNullDataGridViewCheckBoxColumn.Width = 39;
      // 
      // dataTypeDataGridViewTextBoxColumn
      // 
      this.dataTypeDataGridViewTextBoxColumn.DataPropertyName = "DataType";
      this.dataTypeDataGridViewTextBoxColumn.HeaderText = "DataType";
      this.dataTypeDataGridViewTextBoxColumn.Name = "dataTypeDataGridViewTextBoxColumn";
      this.dataTypeDataGridViewTextBoxColumn.ReadOnly = true;
      this.dataTypeDataGridViewTextBoxColumn.Width = 79;
      // 
      // isNullableDataGridViewCheckBoxColumn
      // 
      this.isNullableDataGridViewCheckBoxColumn.DataPropertyName = "IsNullable";
      this.isNullableDataGridViewCheckBoxColumn.HeaderText = "IsNullable";
      this.isNullableDataGridViewCheckBoxColumn.Name = "isNullableDataGridViewCheckBoxColumn";
      this.isNullableDataGridViewCheckBoxColumn.ReadOnly = true;
      this.isNullableDataGridViewCheckBoxColumn.Width = 59;
      // 
      // isReadOnlyDataGridViewCheckBoxColumn
      // 
      this.isReadOnlyDataGridViewCheckBoxColumn.DataPropertyName = "IsReadOnly";
      this.isReadOnlyDataGridViewCheckBoxColumn.HeaderText = "IsReadOnly";
      this.isReadOnlyDataGridViewCheckBoxColumn.Name = "isReadOnlyDataGridViewCheckBoxColumn";
      this.isReadOnlyDataGridViewCheckBoxColumn.ReadOnly = true;
      this.isReadOnlyDataGridViewCheckBoxColumn.Width = 68;
      // 
      // fieldIndexDataGridViewTextBoxColumn
      // 
      this.fieldIndexDataGridViewTextBoxColumn.DataPropertyName = "FieldIndex";
      this.fieldIndexDataGridViewTextBoxColumn.HeaderText = "FieldIndex";
      this.fieldIndexDataGridViewTextBoxColumn.Name = "fieldIndexDataGridViewTextBoxColumn";
      this.fieldIndexDataGridViewTextBoxColumn.ReadOnly = true;
      this.fieldIndexDataGridViewTextBoxColumn.Width = 80;
      // 
      // isPrimaryKeyDataGridViewCheckBoxColumn
      // 
      this.isPrimaryKeyDataGridViewCheckBoxColumn.DataPropertyName = "IsPrimaryKey";
      this.isPrimaryKeyDataGridViewCheckBoxColumn.HeaderText = "IsPrimaryKey";
      this.isPrimaryKeyDataGridViewCheckBoxColumn.Name = "isPrimaryKeyDataGridViewCheckBoxColumn";
      this.isPrimaryKeyDataGridViewCheckBoxColumn.ReadOnly = true;
      this.isPrimaryKeyDataGridViewCheckBoxColumn.Width = 73;
      // 
      // actualDotNetTypeDataGridViewTextBoxColumn
      // 
      this.actualDotNetTypeDataGridViewTextBoxColumn.DataPropertyName = "ActualDotNetType";
      this.actualDotNetTypeDataGridViewTextBoxColumn.HeaderText = "ActualDotNetType";
      this.actualDotNetTypeDataGridViewTextBoxColumn.Name = "actualDotNetTypeDataGridViewTextBoxColumn";
      this.actualDotNetTypeDataGridViewTextBoxColumn.ReadOnly = true;
      this.actualDotNetTypeDataGridViewTextBoxColumn.Width = 120;
      // 
      // sourceCatalogNameDataGridViewTextBoxColumn
      // 
      this.sourceCatalogNameDataGridViewTextBoxColumn.DataPropertyName = "SourceCatalogName";
      this.sourceCatalogNameDataGridViewTextBoxColumn.HeaderText = "SourceCatalogName";
      this.sourceCatalogNameDataGridViewTextBoxColumn.Name = "sourceCatalogNameDataGridViewTextBoxColumn";
      this.sourceCatalogNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.sourceCatalogNameDataGridViewTextBoxColumn.Width = 130;
      // 
      // sourceSchemaNameDataGridViewTextBoxColumn
      // 
      this.sourceSchemaNameDataGridViewTextBoxColumn.DataPropertyName = "SourceSchemaName";
      this.sourceSchemaNameDataGridViewTextBoxColumn.HeaderText = "SourceSchemaName";
      this.sourceSchemaNameDataGridViewTextBoxColumn.Name = "sourceSchemaNameDataGridViewTextBoxColumn";
      this.sourceSchemaNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.sourceSchemaNameDataGridViewTextBoxColumn.Width = 133;
      // 
      // sourceObjectNameDataGridViewTextBoxColumn
      // 
      this.sourceObjectNameDataGridViewTextBoxColumn.DataPropertyName = "SourceObjectName";
      this.sourceObjectNameDataGridViewTextBoxColumn.HeaderText = "SourceObjectName";
      this.sourceObjectNameDataGridViewTextBoxColumn.Name = "sourceObjectNameDataGridViewTextBoxColumn";
      this.sourceObjectNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.sourceObjectNameDataGridViewTextBoxColumn.Width = 125;
      // 
      // sourceColumnNameDataGridViewTextBoxColumn
      // 
      this.sourceColumnNameDataGridViewTextBoxColumn.DataPropertyName = "SourceColumnName";
      this.sourceColumnNameDataGridViewTextBoxColumn.HeaderText = "SourceColumnName";
      this.sourceColumnNameDataGridViewTextBoxColumn.Name = "sourceColumnNameDataGridViewTextBoxColumn";
      this.sourceColumnNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.sourceColumnNameDataGridViewTextBoxColumn.Width = 129;
      // 
      // sourceColumnMaxLengthDataGridViewTextBoxColumn
      // 
      this.sourceColumnMaxLengthDataGridViewTextBoxColumn.DataPropertyName = "SourceColumnMaxLength";
      this.sourceColumnMaxLengthDataGridViewTextBoxColumn.HeaderText = "SourceColumnMaxLength";
      this.sourceColumnMaxLengthDataGridViewTextBoxColumn.Name = "sourceColumnMaxLengthDataGridViewTextBoxColumn";
      this.sourceColumnMaxLengthDataGridViewTextBoxColumn.ReadOnly = true;
      this.sourceColumnMaxLengthDataGridViewTextBoxColumn.Width = 154;
      // 
      // sourceColumnDbTypeDataGridViewTextBoxColumn
      // 
      this.sourceColumnDbTypeDataGridViewTextBoxColumn.DataPropertyName = "SourceColumnDbType";
      this.sourceColumnDbTypeDataGridViewTextBoxColumn.HeaderText = "SourceColumnDbType";
      this.sourceColumnDbTypeDataGridViewTextBoxColumn.Name = "sourceColumnDbTypeDataGridViewTextBoxColumn";
      this.sourceColumnDbTypeDataGridViewTextBoxColumn.ReadOnly = true;
      this.sourceColumnDbTypeDataGridViewTextBoxColumn.Width = 139;
      // 
      // sourceColumnIsNullableDataGridViewCheckBoxColumn
      // 
      this.sourceColumnIsNullableDataGridViewCheckBoxColumn.DataPropertyName = "SourceColumnIsNullable";
      this.sourceColumnIsNullableDataGridViewCheckBoxColumn.HeaderText = "SourceColumnIsNullable";
      this.sourceColumnIsNullableDataGridViewCheckBoxColumn.Name = "sourceColumnIsNullableDataGridViewCheckBoxColumn";
      this.sourceColumnIsNullableDataGridViewCheckBoxColumn.ReadOnly = true;
      this.sourceColumnIsNullableDataGridViewCheckBoxColumn.Width = 128;
      // 
      // sourceColumnScaleDataGridViewTextBoxColumn
      // 
      this.sourceColumnScaleDataGridViewTextBoxColumn.DataPropertyName = "SourceColumnScale";
      this.sourceColumnScaleDataGridViewTextBoxColumn.HeaderText = "SourceColumnScale";
      this.sourceColumnScaleDataGridViewTextBoxColumn.Name = "sourceColumnScaleDataGridViewTextBoxColumn";
      this.sourceColumnScaleDataGridViewTextBoxColumn.ReadOnly = true;
      this.sourceColumnScaleDataGridViewTextBoxColumn.Width = 128;
      // 
      // sourceColumnPrecisionDataGridViewTextBoxColumn
      // 
      this.sourceColumnPrecisionDataGridViewTextBoxColumn.DataPropertyName = "SourceColumnPrecision";
      this.sourceColumnPrecisionDataGridViewTextBoxColumn.HeaderText = "SourceColumnPrecision";
      this.sourceColumnPrecisionDataGridViewTextBoxColumn.Name = "sourceColumnPrecisionDataGridViewTextBoxColumn";
      this.sourceColumnPrecisionDataGridViewTextBoxColumn.ReadOnly = true;
      this.sourceColumnPrecisionDataGridViewTextBoxColumn.Width = 144;
      // 
      // isIdentityDataGridViewCheckBoxColumn
      // 
      this.isIdentityDataGridViewCheckBoxColumn.DataPropertyName = "IsIdentity";
      this.isIdentityDataGridViewCheckBoxColumn.HeaderText = "IsIdentity";
      this.isIdentityDataGridViewCheckBoxColumn.Name = "isIdentityDataGridViewCheckBoxColumn";
      this.isIdentityDataGridViewCheckBoxColumn.ReadOnly = true;
      this.isIdentityDataGridViewCheckBoxColumn.Width = 55;
      // 
      // identityValueSequenceNameDataGridViewTextBoxColumn
      // 
      this.identityValueSequenceNameDataGridViewTextBoxColumn.DataPropertyName = "IdentityValueSequenceName";
      this.identityValueSequenceNameDataGridViewTextBoxColumn.HeaderText = "IdentityValueSequenceName";
      this.identityValueSequenceNameDataGridViewTextBoxColumn.Name = "identityValueSequenceNameDataGridViewTextBoxColumn";
      this.identityValueSequenceNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.identityValueSequenceNameDataGridViewTextBoxColumn.Width = 170;
      // 
      // typeConverterToUseDataGridViewTextBoxColumn
      // 
      this.typeConverterToUseDataGridViewTextBoxColumn.DataPropertyName = "TypeConverterToUse";
      this.typeConverterToUseDataGridViewTextBoxColumn.HeaderText = "TypeConverterToUse";
      this.typeConverterToUseDataGridViewTextBoxColumn.Name = "typeConverterToUseDataGridViewTextBoxColumn";
      this.typeConverterToUseDataGridViewTextBoxColumn.ReadOnly = true;
      this.typeConverterToUseDataGridViewTextBoxColumn.Width = 134;
      // 
      // linkedSuperTypeFieldDataGridViewTextBoxColumn
      // 
      this.linkedSuperTypeFieldDataGridViewTextBoxColumn.DataPropertyName = "LinkedSuperTypeField";
      this.linkedSuperTypeFieldDataGridViewTextBoxColumn.HeaderText = "LinkedSuperTypeField";
      this.linkedSuperTypeFieldDataGridViewTextBoxColumn.Name = "linkedSuperTypeFieldDataGridViewTextBoxColumn";
      this.linkedSuperTypeFieldDataGridViewTextBoxColumn.Width = 138;
      // 
      // maxLengthDataGridViewTextBoxColumn
      // 
      this.maxLengthDataGridViewTextBoxColumn.DataPropertyName = "MaxLength";
      this.maxLengthDataGridViewTextBoxColumn.HeaderText = "MaxLength";
      this.maxLengthDataGridViewTextBoxColumn.Name = "maxLengthDataGridViewTextBoxColumn";
      this.maxLengthDataGridViewTextBoxColumn.ReadOnly = true;
      this.maxLengthDataGridViewTextBoxColumn.Width = 85;
      // 
      // scaleDataGridViewTextBoxColumn
      // 
      this.scaleDataGridViewTextBoxColumn.DataPropertyName = "Scale";
      this.scaleDataGridViewTextBoxColumn.HeaderText = "Scale";
      this.scaleDataGridViewTextBoxColumn.Name = "scaleDataGridViewTextBoxColumn";
      this.scaleDataGridViewTextBoxColumn.ReadOnly = true;
      this.scaleDataGridViewTextBoxColumn.Width = 59;
      // 
      // precisionDataGridViewTextBoxColumn
      // 
      this.precisionDataGridViewTextBoxColumn.DataPropertyName = "Precision";
      this.precisionDataGridViewTextBoxColumn.HeaderText = "Precision";
      this.precisionDataGridViewTextBoxColumn.Name = "precisionDataGridViewTextBoxColumn";
      this.precisionDataGridViewTextBoxColumn.ReadOnly = true;
      this.precisionDataGridViewTextBoxColumn.Width = 75;
      // 
      // aliasDataGridViewTextBoxColumn
      // 
      this.aliasDataGridViewTextBoxColumn.DataPropertyName = "Alias";
      this.aliasDataGridViewTextBoxColumn.HeaderText = "Alias";
      this.aliasDataGridViewTextBoxColumn.Name = "aliasDataGridViewTextBoxColumn";
      this.aliasDataGridViewTextBoxColumn.Width = 54;
      // 
      // containingObjectNameDataGridViewTextBoxColumn
      // 
      this.containingObjectNameDataGridViewTextBoxColumn.DataPropertyName = "ContainingObjectName";
      this.containingObjectNameDataGridViewTextBoxColumn.HeaderText = "ContainingObjectName";
      this.containingObjectNameDataGridViewTextBoxColumn.Name = "containingObjectNameDataGridViewTextBoxColumn";
      this.containingObjectNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.containingObjectNameDataGridViewTextBoxColumn.Width = 141;
      // 
      // objectAliasDataGridViewTextBoxColumn
      // 
      this.objectAliasDataGridViewTextBoxColumn.DataPropertyName = "ObjectAlias";
      this.objectAliasDataGridViewTextBoxColumn.HeaderText = "ObjectAlias";
      this.objectAliasDataGridViewTextBoxColumn.Name = "objectAliasDataGridViewTextBoxColumn";
      this.objectAliasDataGridViewTextBoxColumn.Width = 85;
      // 
      // aggregateFunctionToApplyDataGridViewTextBoxColumn
      // 
      this.aggregateFunctionToApplyDataGridViewTextBoxColumn.DataPropertyName = "AggregateFunctionToApply";
      this.aggregateFunctionToApplyDataGridViewTextBoxColumn.HeaderText = "AggregateFunctionToApply";
      this.aggregateFunctionToApplyDataGridViewTextBoxColumn.Name = "aggregateFunctionToApplyDataGridViewTextBoxColumn";
      this.aggregateFunctionToApplyDataGridViewTextBoxColumn.Width = 161;
      // 
      // expressionToApplyDataGridViewTextBoxColumn
      // 
      this.expressionToApplyDataGridViewTextBoxColumn.DataPropertyName = "ExpressionToApply";
      this.expressionToApplyDataGridViewTextBoxColumn.HeaderText = "ExpressionToApply";
      this.expressionToApplyDataGridViewTextBoxColumn.Name = "expressionToApplyDataGridViewTextBoxColumn";
      this.expressionToApplyDataGridViewTextBoxColumn.Width = 122;
      // 
      // isForeignKeyDataGridViewCheckBoxColumn
      // 
      this.isForeignKeyDataGridViewCheckBoxColumn.DataPropertyName = "IsForeignKey";
      this.isForeignKeyDataGridViewCheckBoxColumn.HeaderText = "IsForeignKey";
      this.isForeignKeyDataGridViewCheckBoxColumn.Name = "isForeignKeyDataGridViewCheckBoxColumn";
      this.isForeignKeyDataGridViewCheckBoxColumn.ReadOnly = true;
      this.isForeignKeyDataGridViewCheckBoxColumn.Width = 74;
      // 
      // actualContainingObjectNameDataGridViewTextBoxColumn
      // 
      this.actualContainingObjectNameDataGridViewTextBoxColumn.DataPropertyName = "ActualContainingObjectName";
      this.actualContainingObjectNameDataGridViewTextBoxColumn.HeaderText = "ActualContainingObjectName";
      this.actualContainingObjectNameDataGridViewTextBoxColumn.Name = "actualContainingObjectNameDataGridViewTextBoxColumn";
      this.actualContainingObjectNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.actualContainingObjectNameDataGridViewTextBoxColumn.Width = 171;
      // 
      // isInMultiTargetEntityDataGridViewCheckBoxColumn
      // 
      this.isInMultiTargetEntityDataGridViewCheckBoxColumn.DataPropertyName = "IsInMultiTargetEntity";
      this.isInMultiTargetEntityDataGridViewCheckBoxColumn.HeaderText = "IsInMultiTargetEntity";
      this.isInMultiTargetEntityDataGridViewCheckBoxColumn.Name = "isInMultiTargetEntityDataGridViewCheckBoxColumn";
      this.isInMultiTargetEntityDataGridViewCheckBoxColumn.ReadOnly = true;
      this.isInMultiTargetEntityDataGridViewCheckBoxColumn.Width = 109;
      // 
      // actAsDerivedTableFieldDataGridViewCheckBoxColumn
      // 
      this.actAsDerivedTableFieldDataGridViewCheckBoxColumn.DataPropertyName = "ActAsDerivedTableField";
      this.actAsDerivedTableFieldDataGridViewCheckBoxColumn.HeaderText = "ActAsDerivedTableField";
      this.actAsDerivedTableFieldDataGridViewCheckBoxColumn.Name = "actAsDerivedTableFieldDataGridViewCheckBoxColumn";
      this.actAsDerivedTableFieldDataGridViewCheckBoxColumn.ReadOnly = true;
      this.actAsDerivedTableFieldDataGridViewCheckBoxColumn.Width = 127;
      // 
      // entityFieldBindingSource
      // 
      this.entityFieldBindingSource.DataSource = typeof(SD.LLBLGen.Pro.ORMSupportClasses.EntityField);
      // 
      // splitContainer1
      // 
      this.splitContainer1.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::AW.Win.Properties.Settings.Default, "FrmEntityViewerSplitterDistance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
      this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
      this.splitContainer1.Size = new System.Drawing.Size(868, 562);
      this.splitContainer1.SplitterDistance = global::AW.Win.Properties.Settings.Default.FrmEntityViewerSplitterDistance;
      this.splitContainer1.TabIndex = 2;
      // 
      // propertyGrid1
      // 
      this.propertyGrid1.CommandsActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
      this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.SystemColors.ControlDark;
      this.propertyGrid1.CommandsLinkColor = System.Drawing.SystemColors.ActiveCaption;
      this.propertyGrid1.ContextMenuStrip = this.contextMenuStrip1;
      this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.propertyGrid1.DrawFlat = true;
      this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new System.Drawing.Size(289, 562);
      this.propertyGrid1.TabIndex = 0;
      this.propertyGrid1.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.propertyGrid1_SelectedGridItemChanged);
      this.propertyGrid1.SelectedObjectsChanged += new System.EventHandler(this.propertyGrid1_SelectedObjectsChanged);
      // 
      // propertyGrid2
      // 
      this.propertyGrid2.Location = new System.Drawing.Point(0, 0);
      this.propertyGrid2.Name = "propertyGrid2";
      this.propertyGrid2.Size = new System.Drawing.Size(469, 141);
      this.propertyGrid2.TabIndex = 2;
      this.propertyGrid2.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.propertyGrid2_SelectedGridItemChanged);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectObjectToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(147, 26);
      // 
      // selectObjectToolStripMenuItem
      // 
      this.selectObjectToolStripMenuItem.Name = "selectObjectToolStripMenuItem";
      this.selectObjectToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.selectObjectToolStripMenuItem.Text = "SelectObject";
      this.selectObjectToolStripMenuItem.Click += new System.EventHandler(this.selectObjectToolStripMenuItem_Click);
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.dataGridViewFields);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.dataGridViewEnumerable);
      this.splitContainer2.Panel2.Controls.Add(this.propertyGrid2);
      this.splitContainer2.Size = new System.Drawing.Size(575, 562);
      this.splitContainer2.SplitterDistance = 281;
      this.splitContainer2.TabIndex = 3;
      // 
      // dataGridViewEnumerable
      // 
      this.dataGridViewEnumerable.AllowUserToAddRows = false;
      this.dataGridViewEnumerable.AllowUserToDeleteRows = false;
      this.dataGridViewEnumerable.AutoGenerateColumns = false;
      this.dataGridViewEnumerable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridViewEnumerable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewEnumerable.DataSource = this.bindingSourceEnumerable;
      this.dataGridViewEnumerable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewEnumerable.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewEnumerable.Name = "dataGridViewEnumerable";
      this.dataGridViewEnumerable.Size = new System.Drawing.Size(575, 277);
      this.dataGridViewEnumerable.TabIndex = 3;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "CurrentValue";
      this.dataGridViewTextBoxColumn1.HeaderText = "CurrentValue";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.Width = 93;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "DbValue";
      this.dataGridViewTextBoxColumn2.HeaderText = "DbValue";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 73;
      // 
      // currentValueDataGridViewTextBoxColumn
      // 
      this.currentValueDataGridViewTextBoxColumn.DataPropertyName = "CurrentValue";
      this.currentValueDataGridViewTextBoxColumn.HeaderText = "CurrentValue";
      this.currentValueDataGridViewTextBoxColumn.Name = "currentValueDataGridViewTextBoxColumn";
      this.currentValueDataGridViewTextBoxColumn.Width = 93;
      // 
      // dbValueDataGridViewTextBoxColumn
      // 
      this.dbValueDataGridViewTextBoxColumn.DataPropertyName = "DbValue";
      this.dbValueDataGridViewTextBoxColumn.HeaderText = "DbValue";
      this.dbValueDataGridViewTextBoxColumn.Name = "dbValueDataGridViewTextBoxColumn";
      this.dbValueDataGridViewTextBoxColumn.ReadOnly = true;
      this.dbValueDataGridViewTextBoxColumn.Width = 73;
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
      ((System.ComponentModel.ISupportInitialize)(this.entityFieldBindingSource)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.contextMenuStrip1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnumerable)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnumerable)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewFields;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private href.Controls.PropGridEx.PropertyGridEx propertyGrid1;
    private System.Windows.Forms.BindingSource entityFieldBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isChangedDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn currentValueDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dbValueDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isNullDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataTypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isNullableDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isReadOnlyDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fieldIndexDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isPrimaryKeyDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn actualDotNetTypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn sourceCatalogNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn sourceSchemaNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn sourceObjectNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn sourceColumnNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn sourceColumnMaxLengthDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn sourceColumnDbTypeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn sourceColumnIsNullableDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn sourceColumnScaleDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn sourceColumnPrecisionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isIdentityDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn identityValueSequenceNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn typeConverterToUseDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn linkedSuperTypeFieldDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn maxLengthDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn scaleDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn precisionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn containingObjectNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn objectAliasDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn aggregateFunctionToApplyDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn expressionToApplyDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isForeignKeyDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn actualContainingObjectNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isInMultiTargetEntityDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn actAsDerivedTableFieldDataGridViewCheckBoxColumn;
    private System.Windows.Forms.PropertyGrid propertyGrid2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem selectObjectToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.DataGridView dataGridViewEnumerable;
    private System.Windows.Forms.BindingSource bindingSourceEnumerable;

  }
}