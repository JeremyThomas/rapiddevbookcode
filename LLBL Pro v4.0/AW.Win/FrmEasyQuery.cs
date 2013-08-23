using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Korzh.EasyQuery;
using Korzh.EasyQuery.Db;
using Korzh.EasyQuery.WinControls;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Path = System.IO.Path;

namespace AW.Win
{
  /// <summary>
  /// Summary description for Form1.
  /// </summary>
  public class FrmEasyQuery : Form
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private Container components = null;

    private DbModel dataModel1;
    private DbQuery query1;
    private OpenFileDialog openFileDlg;
    private SaveFileDialog saveFileDlg;
    private DataSet ResultDS;
    private DataTable ResultDataTable;
    private ContextMenu contextMenu1;
    private MenuItem menuItemAddConditions;
    private MenuItem menuItemFillDataModel;
    private Panel panelBottom;
    private GroupBox groupBoxSQL;
    private Splitter splitter1;
    private GroupBox groupBoxResultSet;
    private TextBox teSQL;
    private DataGrid dataGrid1;
    private Splitter splitter2;
    private Panel panelBG;
    private Panel panelButtons;
    private Button btCodeSamples;
    private Button btClear;
    private Button btLoad;
    private Button btSave;
    private Button btExecute;
    private GroupBox groupBoxConditions;
    private Panel panelQuery;
    private MenuItem menuItemResetDataModel;
    private Panel panelColumns;
    private Splitter splitter4;
    private GroupBox groupBoxSorting;
    private SortColumnsPanel SCPanel;
    private GroupBox groupBoxColumns;
    private QueryColumnsPanel QCPanel;
    private QueryPanel QPanel;
    private GroupBox groupBoxEntities;
    private EntitiesPanel EntPanel;
    private Splitter splitter3;
    private ComboBox comboBoxDbType;
    private Label labelDbTypeHint;
    private Label label1;

    private string dataFolder = "";

    private string appDirectory;

    private SqlConnection sqlCon;

    public FrmEasyQuery()
    {
      appDirectory = Directory.GetCurrentDirectory();
      dataFolder = appDirectory;

      InitializeComponent();
      query1.Model = dataModel1;
      QPanel.Query = query1;
      query1.Formats.SetDefaultFormats(FormatType.MsSqlServer);
      QPanel.Activate();
      QCPanel.Activate();
      SCPanel.Activate();
      EntPanel.UpdateModelInfo();
      comboBoxDbType.SelectedIndex = 0;
      countryAttr = dataModel1.EntityRoot.FindAttribute(EntityAttrProp.Expression, "Customers.Country");
      query1.Formats.UseSchema = true;
    }

    private void CheckConnection()
    {
      if (dbMode == 0)
        CheckSqlConnection();
    }

    private void CheckSqlConnection()
    {
      if (sqlCon == null)
        sqlCon = new SqlConnection(ConfigFileHelper.ReadConnectionStringFromConfig("Main.ConnectionString"));
      if (sqlCon.State != ConnectionState.Open)
      {
        try
        {
          sqlCon.Open();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
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
      CloseConnections();
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEasyQuery));
      this.dataModel1 = new Korzh.EasyQuery.Db.DbModel();
      this.query1 = new Korzh.EasyQuery.Db.DbQuery();
      this.ResultDataTable = new System.Data.DataTable();
      this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
      this.ResultDS = new System.Data.DataSet();
      this.contextMenu1 = new System.Windows.Forms.ContextMenu();
      this.menuItemResetDataModel = new System.Windows.Forms.MenuItem();
      this.menuItemFillDataModel = new System.Windows.Forms.MenuItem();
      this.menuItemAddConditions = new System.Windows.Forms.MenuItem();
      this.panelBottom = new System.Windows.Forms.Panel();
      this.groupBoxResultSet = new System.Windows.Forms.GroupBox();
      this.dataGrid1 = new System.Windows.Forms.DataGrid();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.groupBoxSQL = new System.Windows.Forms.GroupBox();
      this.teSQL = new System.Windows.Forms.TextBox();
      this.splitter2 = new System.Windows.Forms.Splitter();
      this.panelBG = new System.Windows.Forms.Panel();
      this.groupBoxEntities = new System.Windows.Forms.GroupBox();
      this.EntPanel = new Korzh.EasyQuery.WinControls.EntitiesPanel();
      this.comboBoxDbType = new System.Windows.Forms.ComboBox();
      this.labelDbTypeHint = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.panelQuery = new System.Windows.Forms.Panel();
      this.groupBoxColumns = new System.Windows.Forms.GroupBox();
      this.QCPanel = new Korzh.EasyQuery.WinControls.QueryColumnsPanel();
      this.groupBoxConditions = new System.Windows.Forms.GroupBox();
      this.QPanel = new Korzh.EasyQuery.WinControls.QueryPanel();
      this.splitter3 = new System.Windows.Forms.Splitter();
      this.panelColumns = new System.Windows.Forms.Panel();
      this.splitter4 = new System.Windows.Forms.Splitter();
      this.groupBoxSorting = new System.Windows.Forms.GroupBox();
      this.SCPanel = new Korzh.EasyQuery.WinControls.SortColumnsPanel();
      this.panelButtons = new System.Windows.Forms.Panel();
      this.btCodeSamples = new System.Windows.Forms.Button();
      this.btClear = new System.Windows.Forms.Button();
      this.btLoad = new System.Windows.Forms.Button();
      this.btSave = new System.Windows.Forms.Button();
      this.btExecute = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.ResultDataTable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ResultDS)).BeginInit();
      this.panelBottom.SuspendLayout();
      this.groupBoxResultSet.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      this.groupBoxSQL.SuspendLayout();
      this.panelBG.SuspendLayout();
      this.groupBoxEntities.SuspendLayout();
      this.panelQuery.SuspendLayout();
      this.groupBoxColumns.SuspendLayout();
      this.groupBoxConditions.SuspendLayout();
      this.panelColumns.SuspendLayout();
      this.groupBoxSorting.SuspendLayout();
      this.panelButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataModel1
      // 
      this.dataModel1.CustomInfo = "";
      this.dataModel1.DefQueryFilePath = "";
      this.dataModel1.Description = null;
      this.dataModel1.ID = "25704bf3-5f67-4ad8-8be8-bb1b47a3073e";
      this.dataModel1.IsLoadedFromDbContext = false;
      this.dataModel1.ModelName = null;
      this.dataModel1.StoreDbParams = false;
      // 
      // query1
      // 
      this.query1.ExtraColumns = "";
      this.query1.FilePath = "";
      this.query1.Formats.EscapeSymbol = "";
      this.query1.Formats.QuoteColumnAlias = false;
      this.query1.Formats.UseTableAlias = false;
      this.query1.Formats.WildSymbol = '%';
      this.query1.Model = this.dataModel1;
      this.query1.NoPathResolution = Korzh.EasyQuery.NoPathResolution.ThrowException;
      this.query1.QueryName = "SampleQuery";
      this.query1.SyncColSortOrder = true;
      this.query1.ColumnsChanged += new Korzh.EasyQuery.ColumnsChangedEventHandler(this.query1_ColumnsChanged);
      this.query1.ConditionsChanged += new Korzh.EasyQuery.ConditionsChangedEventHandler(this.query1_ConditionsChanged);
      // 
      // ResultDataTable
      // 
      this.ResultDataTable.TableName = "Result";
      // 
      // ResultDS
      // 
      this.ResultDS.DataSetName = "ResultDataSet";
      this.ResultDS.Locale = new System.Globalization.CultureInfo("en");
      this.ResultDS.Tables.AddRange(new System.Data.DataTable[] {
            this.ResultDataTable});
      // 
      // contextMenu1
      // 
      this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemResetDataModel,
            this.menuItemFillDataModel,
            this.menuItemAddConditions});
      // 
      // menuItemResetDataModel
      // 
      this.menuItemResetDataModel.Index = 0;
      this.menuItemResetDataModel.Text = "Reset Data Model";
      this.menuItemResetDataModel.Click += new System.EventHandler(this.menuItemResetDataModel_Click);
      // 
      // menuItemFillDataModel
      // 
      this.menuItemFillDataModel.Index = 1;
      this.menuItemFillDataModel.Text = "Fill Data Model by code";
      this.menuItemFillDataModel.Click += new System.EventHandler(this.menuItemFillDataModel_Click);
      // 
      // menuItemAddConditions
      // 
      this.menuItemAddConditions.Index = 2;
      this.menuItemAddConditions.Text = "Add conditions by code";
      this.menuItemAddConditions.Click += new System.EventHandler(this.menuItemAddConditions_Click);
      // 
      // panelBottom
      // 
      this.panelBottom.Controls.Add(this.groupBoxResultSet);
      this.panelBottom.Controls.Add(this.splitter1);
      this.panelBottom.Controls.Add(this.groupBoxSQL);
      this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelBottom.Location = new System.Drawing.Point(0, 370);
      this.panelBottom.Name = "panelBottom";
      this.panelBottom.Size = new System.Drawing.Size(838, 178);
      this.panelBottom.TabIndex = 23;
      // 
      // groupBoxResultSet
      // 
      this.groupBoxResultSet.Controls.Add(this.dataGrid1);
      this.groupBoxResultSet.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBoxResultSet.Location = new System.Drawing.Point(362, 0);
      this.groupBoxResultSet.Name = "groupBoxResultSet";
      this.groupBoxResultSet.Size = new System.Drawing.Size(476, 178);
      this.groupBoxResultSet.TabIndex = 2;
      this.groupBoxResultSet.TabStop = false;
      this.groupBoxResultSet.Text = "Result set";
      // 
      // dataGrid1
      // 
      this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGrid1.DataMember = "";
      this.dataGrid1.DataSource = this.ResultDataTable;
      this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGrid1.Location = new System.Drawing.Point(8, 16);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.Size = new System.Drawing.Size(463, 154);
      this.dataGrid1.TabIndex = 1;
      // 
      // splitter1
      // 
      this.splitter1.Location = new System.Drawing.Point(359, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(3, 178);
      this.splitter1.TabIndex = 1;
      this.splitter1.TabStop = false;
      // 
      // groupBoxSQL
      // 
      this.groupBoxSQL.Controls.Add(this.teSQL);
      this.groupBoxSQL.Dock = System.Windows.Forms.DockStyle.Left;
      this.groupBoxSQL.Location = new System.Drawing.Point(0, 0);
      this.groupBoxSQL.Name = "groupBoxSQL";
      this.groupBoxSQL.Size = new System.Drawing.Size(359, 178);
      this.groupBoxSQL.TabIndex = 0;
      this.groupBoxSQL.TabStop = false;
      this.groupBoxSQL.Text = "SQL";
      // 
      // teSQL
      // 
      this.teSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.teSQL.Location = new System.Drawing.Point(8, 16);
      this.teSQL.Multiline = true;
      this.teSQL.Name = "teSQL";
      this.teSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.teSQL.Size = new System.Drawing.Size(343, 154);
      this.teSQL.TabIndex = 9;
      // 
      // splitter2
      // 
      this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitter2.Location = new System.Drawing.Point(0, 367);
      this.splitter2.Name = "splitter2";
      this.splitter2.Size = new System.Drawing.Size(838, 3);
      this.splitter2.TabIndex = 24;
      this.splitter2.TabStop = false;
      // 
      // panelBG
      // 
      this.panelBG.Controls.Add(this.groupBoxEntities);
      this.panelBG.Controls.Add(this.comboBoxDbType);
      this.panelBG.Controls.Add(this.labelDbTypeHint);
      this.panelBG.Controls.Add(this.label1);
      this.panelBG.Controls.Add(this.panelQuery);
      this.panelBG.Controls.Add(this.panelButtons);
      this.panelBG.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelBG.Location = new System.Drawing.Point(0, 0);
      this.panelBG.Name = "panelBG";
      this.panelBG.Size = new System.Drawing.Size(838, 367);
      this.panelBG.TabIndex = 25;
      // 
      // groupBoxEntities
      // 
      this.groupBoxEntities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.groupBoxEntities.Controls.Add(this.EntPanel);
      this.groupBoxEntities.Location = new System.Drawing.Point(3, 44);
      this.groupBoxEntities.Name = "groupBoxEntities";
      this.groupBoxEntities.Size = new System.Drawing.Size(179, 323);
      this.groupBoxEntities.TabIndex = 29;
      this.groupBoxEntities.TabStop = false;
      this.groupBoxEntities.Text = "Objects and their attributes";
      // 
      // EntPanel
      // 
      this.EntPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.EntPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.EntPanel.ImageAddColumns = ((System.Drawing.Image)(resources.GetObject("EntPanel.ImageAddColumns")));
      this.EntPanel.ImageAddConditions = ((System.Drawing.Image)(resources.GetObject("EntPanel.ImageAddConditions")));
      this.EntPanel.ImageSelectAll = ((System.Drawing.Image)(resources.GetObject("EntPanel.ImageSelectAll")));
      this.EntPanel.ImageSelectNone = ((System.Drawing.Image)(resources.GetObject("EntPanel.ImageSelectNone")));
      this.EntPanel.Location = new System.Drawing.Point(3, 19);
      this.EntPanel.Name = "EntPanel";
      this.EntPanel.Query = this.query1;
      this.EntPanel.Size = new System.Drawing.Size(173, 298);
      this.EntPanel.TabIndex = 29;
      // 
      // comboBoxDbType
      // 
      this.comboBoxDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxDbType.FormattingEnabled = true;
      this.comboBoxDbType.Items.AddRange(new object[] {
            "SQL Server",
            "LLBL"});
      this.comboBoxDbType.Location = new System.Drawing.Point(87, 6);
      this.comboBoxDbType.Name = "comboBoxDbType";
      this.comboBoxDbType.Size = new System.Drawing.Size(134, 21);
      this.comboBoxDbType.TabIndex = 28;
      this.comboBoxDbType.SelectedValueChanged += new System.EventHandler(this.comboBoxDbType_SelectedValueChanged);
      // 
      // labelDbTypeHint
      // 
      this.labelDbTypeHint.Location = new System.Drawing.Point(227, 6);
      this.labelDbTypeHint.Name = "labelDbTypeHint";
      this.labelDbTypeHint.Size = new System.Drawing.Size(603, 29);
      this.labelDbTypeHint.TabIndex = 26;
      this.labelDbTypeHint.Text = resources.GetString("labelDbTypeHint.Text");
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(5, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 13);
      this.label1.TabIndex = 25;
      this.label1.Text = "Database type:";
      // 
      // panelQuery
      // 
      this.panelQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelQuery.Controls.Add(this.groupBoxColumns);
      this.panelQuery.Controls.Add(this.groupBoxConditions);
      this.panelQuery.Controls.Add(this.splitter3);
      this.panelQuery.Controls.Add(this.panelColumns);
      this.panelQuery.Location = new System.Drawing.Point(185, 41);
      this.panelQuery.Name = "panelQuery";
      this.panelQuery.Size = new System.Drawing.Size(569, 326);
      this.panelQuery.TabIndex = 23;
      // 
      // groupBoxColumns
      // 
      this.groupBoxColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxColumns.Controls.Add(this.QCPanel);
      this.groupBoxColumns.Location = new System.Drawing.Point(0, 3);
      this.groupBoxColumns.Name = "groupBoxColumns";
      this.groupBoxColumns.Size = new System.Drawing.Size(332, 142);
      this.groupBoxColumns.TabIndex = 33;
      this.groupBoxColumns.TabStop = false;
      this.groupBoxColumns.Text = "Query Columns";
      // 
      // QCPanel
      // 
      this.QCPanel.Active = false;
      this.QCPanel.ActiveRowIndex = -1;
      this.QCPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.QCPanel.Appearance.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(190)))));
      this.QCPanel.Appearance.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
      this.QCPanel.Appearance.AdditionRowColor = System.Drawing.Color.DarkGreen;
      this.QCPanel.Appearance.AttrElementFormat = "{entity} {attr}";
      this.QCPanel.Appearance.BackColor = System.Drawing.Color.LightYellow;
      this.QCPanel.Appearance.ButtonForeColor = System.Drawing.SystemColors.ControlText;
      this.QCPanel.Appearance.ButtonMacStyle = false;
      this.QCPanel.Appearance.FocusBorderStyle = System.Windows.Forms.BorderStyle.None;
      this.QCPanel.Appearance.Title = "";
      this.QCPanel.BackColor = System.Drawing.Color.LightYellow;
      this.QCPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.QCPanel.EditMode = Korzh.EasyQuery.WinControls.QueryColumnsPanel.EditModeKind.All;
      this.QCPanel.Location = new System.Drawing.Point(7, 18);
      this.QCPanel.Name = "QCPanel";
      this.QCPanel.Query = this.query1;
      this.QCPanel.Size = new System.Drawing.Size(320, 118);
      this.QCPanel.TabIndex = 27;
      this.QCPanel.TabStop = true;
      // 
      // groupBoxConditions
      // 
      this.groupBoxConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxConditions.Controls.Add(this.QPanel);
      this.groupBoxConditions.Location = new System.Drawing.Point(0, 145);
      this.groupBoxConditions.Name = "groupBoxConditions";
      this.groupBoxConditions.Size = new System.Drawing.Size(566, 181);
      this.groupBoxConditions.TabIndex = 2;
      this.groupBoxConditions.TabStop = false;
      this.groupBoxConditions.Text = "Query Conditions";
      // 
      // QPanel
      // 
      this.QPanel.Active = false;
      this.QPanel.ActiveRowIndex = -1;
      this.QPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.QPanel.Appearance.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(190)))));
      this.QPanel.Appearance.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
      this.QPanel.Appearance.AdditionRowColor = System.Drawing.Color.DarkGreen;
      this.QPanel.Appearance.ButtonForeColor = System.Drawing.SystemColors.ControlText;
      this.QPanel.Appearance.ButtonMacStyle = false;
      this.QPanel.Appearance.ExprColor = System.Drawing.Color.Indigo;
      this.QPanel.Appearance.FocusBorderStyle = System.Windows.Forms.BorderStyle.None;
      this.QPanel.Appearance.OperatorColor = System.Drawing.Color.MediumBlue;
      this.QPanel.Appearance.ShowRootRow = true;
      this.QPanel.BackColor = System.Drawing.Color.White;
      this.QPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.QPanel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.QPanel.Location = new System.Drawing.Point(7, 14);
      this.QPanel.Name = "QPanel";
      this.QPanel.Query = this.query1;
      this.QPanel.Size = new System.Drawing.Size(553, 164);
      this.QPanel.TabIndex = 27;
      this.QPanel.TabStop = true;
      this.QPanel.SqlExecute += new Korzh.EasyQuery.WinControls.SqlExecuteEventHandler(this.QPanel_SqlExecute);
      this.QPanel.ListRequest += new Korzh.EasyQuery.WinControls.ListRequestEventHandler(this.QPanel_ListRequest);
      this.QPanel.ValueRequest += new Korzh.EasyQuery.WinControls.ValueRequestEventHandler(this.QPanel_ValueRequest);
      // 
      // splitter3
      // 
      this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitter3.Location = new System.Drawing.Point(0, 0);
      this.splitter3.Name = "splitter3";
      this.splitter3.Size = new System.Drawing.Size(569, 3);
      this.splitter3.TabIndex = 5;
      this.splitter3.TabStop = false;
      // 
      // panelColumns
      // 
      this.panelColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelColumns.Controls.Add(this.splitter4);
      this.panelColumns.Controls.Add(this.groupBoxSorting);
      this.panelColumns.Location = new System.Drawing.Point(4, 3);
      this.panelColumns.Name = "panelColumns";
      this.panelColumns.Size = new System.Drawing.Size(565, 142);
      this.panelColumns.TabIndex = 4;
      // 
      // splitter4
      // 
      this.splitter4.Location = new System.Drawing.Point(0, 0);
      this.splitter4.Name = "splitter4";
      this.splitter4.Size = new System.Drawing.Size(3, 142);
      this.splitter4.TabIndex = 31;
      this.splitter4.TabStop = false;
      // 
      // groupBoxSorting
      // 
      this.groupBoxSorting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxSorting.Controls.Add(this.SCPanel);
      this.groupBoxSorting.Location = new System.Drawing.Point(328, 0);
      this.groupBoxSorting.Name = "groupBoxSorting";
      this.groupBoxSorting.Size = new System.Drawing.Size(234, 142);
      this.groupBoxSorting.TabIndex = 30;
      this.groupBoxSorting.TabStop = false;
      this.groupBoxSorting.Text = "Columns Sorting";
      // 
      // SCPanel
      // 
      this.SCPanel.Active = false;
      this.SCPanel.ActiveRowIndex = -1;
      this.SCPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.SCPanel.Appearance.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(190)))));
      this.SCPanel.Appearance.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
      this.SCPanel.Appearance.AdditionRowColor = System.Drawing.Color.DarkGreen;
      this.SCPanel.Appearance.AttrElementFormat = "{entity} {attr}";
      this.SCPanel.Appearance.BackColor = System.Drawing.Color.LightYellow;
      this.SCPanel.Appearance.ButtonForeColor = System.Drawing.SystemColors.ControlText;
      this.SCPanel.Appearance.ButtonMacStyle = false;
      this.SCPanel.Appearance.FocusBorderStyle = System.Windows.Forms.BorderStyle.None;
      this.SCPanel.Appearance.Title = "";
      this.SCPanel.BackColor = System.Drawing.Color.LightYellow;
      this.SCPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.SCPanel.EditMode = Korzh.EasyQuery.WinControls.QueryColumnsPanel.EditModeKind.All;
      this.SCPanel.Location = new System.Drawing.Point(6, 18);
      this.SCPanel.Name = "SCPanel";
      this.SCPanel.Query = this.query1;
      this.SCPanel.Size = new System.Drawing.Size(222, 118);
      this.SCPanel.SortEditMode = Korzh.EasyQuery.WinControls.SortColumnsPanel.SortEditModeKind.All;
      this.SCPanel.TabIndex = 28;
      this.SCPanel.TabStop = true;
      // 
      // panelButtons
      // 
      this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.panelButtons.Controls.Add(this.btCodeSamples);
      this.panelButtons.Controls.Add(this.btClear);
      this.panelButtons.Controls.Add(this.btLoad);
      this.panelButtons.Controls.Add(this.btSave);
      this.panelButtons.Controls.Add(this.btExecute);
      this.panelButtons.Location = new System.Drawing.Point(760, 38);
      this.panelButtons.Name = "panelButtons";
      this.panelButtons.Size = new System.Drawing.Size(78, 271);
      this.panelButtons.TabIndex = 22;
      // 
      // btCodeSamples
      // 
      this.btCodeSamples.Location = new System.Drawing.Point(8, 230);
      this.btCodeSamples.Name = "btCodeSamples";
      this.btCodeSamples.Size = new System.Drawing.Size(62, 36);
      this.btCodeSamples.TabIndex = 13;
      this.btCodeSamples.Text = "Code Samples";
      this.btCodeSamples.Click += new System.EventHandler(this.btCodeSamples_Click);
      // 
      // btClear
      // 
      this.btClear.Location = new System.Drawing.Point(8, 16);
      this.btClear.Name = "btClear";
      this.btClear.Size = new System.Drawing.Size(62, 24);
      this.btClear.TabIndex = 12;
      this.btClear.Text = "Clear";
      this.btClear.Click += new System.EventHandler(this.btClear_Click);
      // 
      // btLoad
      // 
      this.btLoad.Location = new System.Drawing.Point(8, 56);
      this.btLoad.Name = "btLoad";
      this.btLoad.Size = new System.Drawing.Size(62, 24);
      this.btLoad.TabIndex = 11;
      this.btLoad.Text = "Load";
      this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
      // 
      // btSave
      // 
      this.btSave.Location = new System.Drawing.Point(8, 88);
      this.btSave.Name = "btSave";
      this.btSave.Size = new System.Drawing.Size(62, 24);
      this.btSave.TabIndex = 10;
      this.btSave.Text = "Save";
      this.btSave.Click += new System.EventHandler(this.btSave_Click);
      // 
      // btExecute
      // 
      this.btExecute.Location = new System.Drawing.Point(8, 149);
      this.btExecute.Name = "btExecute";
      this.btExecute.Size = new System.Drawing.Size(62, 39);
      this.btExecute.TabIndex = 9;
      this.btExecute.Text = "Execute Query";
      this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
      // 
      // FrmEasyQuery
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(838, 548);
      this.Controls.Add(this.panelBG);
      this.Controls.Add(this.splitter2);
      this.Controls.Add(this.panelBottom);
      this.Name = "FrmEasyQuery";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Easy Query.NET WinForms demo";
      ((System.ComponentModel.ISupportInitialize)(this.ResultDataTable)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ResultDS)).EndInit();
      this.panelBottom.ResumeLayout(false);
      this.groupBoxResultSet.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      this.groupBoxSQL.ResumeLayout(false);
      this.groupBoxSQL.PerformLayout();
      this.panelBG.ResumeLayout(false);
      this.panelBG.PerformLayout();
      this.groupBoxEntities.ResumeLayout(false);
      this.panelQuery.ResumeLayout(false);
      this.groupBoxColumns.ResumeLayout(false);
      this.groupBoxConditions.ResumeLayout(false);
      this.panelColumns.ResumeLayout(false);
      this.groupBoxSorting.ResumeLayout(false);
      this.panelButtons.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private void btClear_Click(object sender, EventArgs e)
    {
      QPanel.Query.Clear();
    }

    private int dbMode = 0;

    private void btLoad_Click(object sender, EventArgs e)
    {
      openFileDlg.FileName = Path.Combine(dataFolder, "query1.xml");
      if (openFileDlg.ShowDialog() == DialogResult.OK)
        QPanel.Query.LoadFromFile(openFileDlg.FileName);
    }

    private void btSave_Click(object sender, EventArgs e)
    {
      saveFileDlg.FileName = Path.Combine(dataFolder, "query1.xml");
      if (saveFileDlg.ShowDialog() == DialogResult.OK)
        QPanel.Query.SaveToFile(saveFileDlg.FileName);
    }

    private void btExecute_Click(object sender, EventArgs e)
    {
      try
      {
        ResultDS.Reset();
        //BuildSQL();
        var sql = teSQL.Text;
        CheckConnection();
        if (dbMode == 0)
        {
          var resultDA = new SqlDataAdapter(sql, sqlCon);
          resultDA.Fill(ResultDS, "Result");
          dataGrid1.DataSource = ResultDS.Tables[0].DefaultView;
          sqlCon.Close();
        }
      }
      catch (Exception error)
      {
        //if some error occurs just show the error message 
        MessageBox.Show(error.Message);
      }
    }

    private void BuildSQL()
    {
      teSQL.Clear();
      try
      {
        var builder = new SqlQueryBuilder(query1);
        if (builder.CanBuild)
        {
          builder.BuildSQL();
          var sql = builder.Result.SQL;
          teSQL.Text = sql;
        }
      }
      catch
      {
        //Simply ignore any possible exception
      }
    }

    private void QPanel_SqlExecute(object sender, SqlExecuteEventArgs e)
    {
      CheckConnection();
      var tempDS = new DataSet();
      if (dbMode == 0)
      {
        var tempDA = new SqlDataAdapter(e.SQL, sqlCon);

        tempDA.Fill(tempDS, "Temp");
      }
      var strWriter = new StringWriter();
      tempDS.WriteXml(strWriter);
      e.ResultXml = strWriter.ToString();
    }

    private EntityAttr countryAttr = null;

    private void QPanel_ListRequest(object sender, ListRequestEventArgs e)
    {
      if (e.ListName == "RegionList")
      {
        e.ListItems.Clear();
        var country = query1.GetOneValueForAttr(countryAttr);

        if (country == "Canada")
        {
          e.ListItems.Add("British Columbia", "BC");
          e.ListItems.Add("Quebec", "Quebec");
        }
        else if (country == "USA")
        {
          e.ListItems.Add("California", "CA");
          e.ListItems.Add("Colorado", "CO");
          e.ListItems.Add("Oregon", "OR");
          e.ListItems.Add("Washington", "WA");
        }
      }
    }

    private void query1_ColumnsChanged(object sender, ColumnsChangeEventArgs e)
    {
      BuildSQL();
      ResultDS.Reset();
    }

    private void query1_ConditionsChanged(object sender, ConditionsChangeEventArgs e)
    {
      EntityAttr baseAttr = null;
      if (e.Condition != null)
        baseAttr = e.Condition.BaseAttr;

      if (baseAttr != null && baseAttr == countryAttr)
      {
        QPanel.RefreshList("RegionList");
      }

      BuildSQL();
      ResultDS.Reset();
    }

    private void ResetDataModel()
    {
      query1.Clear();
      dataModel1.LoadFromFile(Path.Combine(dataFolder, "AdventureWorks.xml"));
      QPanel.UpdateModelInfo();
    }


    private void menuItemResetDataModel_Click(object sender, EventArgs e)
    {
      ResetDataModel();
    }

    private void menuItemFillDataModel_Click(object sender, EventArgs e)
    {
      var tempDS = new DataSet();

      CheckConnection();

      if (dbMode == 0)
      {
        var tempDA = new SqlDataAdapter("SELECT * FROM HumanResources.Employee AS Employee WHERE(Employee.Title LIKE 'M%' )", sqlCon);
        tempDA.Fill(tempDS, "HumanResources.Employee");
      }

      var custTable = tempDS.Tables["HumanResources.Employee"];

      query1.Model = null;

      dataModel1.Clear();
      dataModel1.AddDefaultOperators();
      dataModel1.FillByDataTable(custTable, false);

      //AddAttrAutoFill(dataModel1.EntityRoot);

      query1.Model = dataModel1;

      QPanel.UpdateModelInfo();
      QPanel.Activate();

      QCPanel.UpdateModelInfo();
    }

    private void AddAttrAutoFill(Entity entity)
    {
      SqlListValueEditor valEditor;

      foreach (var attr in entity.Attributes)
      {
        attr.Operations.Clear();
        attr.Operations.AddByIDs(dataModel1, "Equal,NotEqual,InList,NotInList");
        valEditor = new SqlListValueEditor();
        valEditor.SQL = string.Format("SELECT DISTINCT {0}, {0} FROM {1}", attr.Expr, ((DbEntityAttr) attr).Tables[0].Alias);
        attr.DefaultEditor = valEditor;
      }
    }

    private void menuItemAddConditions_Click(object sender, EventArgs e)
    {
      if (dbMode == 1)
      {
        MessageBox.Show("Not implemented for EntityFramework mode");
        return;
      }
      ResetDataModel();
      query1.Clear();

      EntityAttr attr;
      attr = dataModel1.EntityRoot.FindAttribute(EntityAttrProp.Expression, "Customers.Country");

      //create columns
      Column col;
      col = new DbColumn("Country", SortDirection.Ascending);
      col.Expr = new DbEntityAttrExpr(dataModel1, attr);
      query1.Columns.Add(col);

      attr = dataModel1.EntityRoot.FindAttribute(EntityAttrProp.Expression, "Orders.Freight");
      col = new DbColumn("Total sum", SortDirection.None);
      col.Expr = new DbAggrFuncExpr(dataModel1, "SUM", new DbEntityAttrExpr(dataModel1, attr));
      query1.Columns.Add(col);

      //create conditions
      //here we create condition object
      SimpleCondition cond = new DbSimpleCondition(dataModel1);

      //then we search for an entity attribute which will be used in the left side of condition
      attr = dataModel1.EntityRoot.FindAttribute(EntityAttrProp.Expression, "Orders.OrderDate");

      //after that we add found entity attribute as first (left side) expression of our condition
      cond.BaseExpr = new DbEntityAttrExpr(dataModel1, attr);

      //here we set an operator used in condition. In our case it will be  "is less than" (< symbol in SQL syntax)
      cond.Operator = dataModel1.Operators.FindByID("LessThan");

      //finally we set the rigth side expression which is some constant value in our case.
      cond.SetValueExpr(1, new ConstExpr(DataType.Date, "2005-01-01"));
      cond.ReadOnly = true;

      //when all parts of our condition are ready - we add it to query
      query1.Root.Conditions.Add(cond);
    }
    
    private void btCodeSamples_Click(object sender, EventArgs e)
    {
      contextMenu1.Show(btCodeSamples, new Point(0, btCodeSamples.Height + 1));
    }

    private void QPanel_ValueRequest(object sender, ValueRequestEventArgs e)
    {
      MessageBox.Show(e.Data);
    }

    private void CloseConnections()
    {
      if (sqlCon != null) sqlCon.Close();
    }

    private void comboBoxDbType_SelectedValueChanged(object sender, EventArgs e)
    {
      CloseConnections();
      dbMode = comboBoxDbType.SelectedIndex;
      query1.Clear();
      if (dbMode == 0)
      {
        query1.Formats.SetDefaultFormats(FormatType.MsSqlServer);
        query1.Model.LoadFromFile(Path.Combine(dataFolder, "AdventureWorks.xml"));
      }
      else
      {
        query1.Formats.SetDefaultFormats(FormatType.EntityFramework);
        (query1.Model as DbModel).LoadFromEdmx("App_Data\\AdventureWorks.edmx");
      }
      QPanel.UpdateModelInfo();
      QCPanel.UpdateModelInfo();
      EntPanel.UpdateModelInfo();
    }
  }
}