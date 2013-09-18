using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using AW.Data;
using AW.Data.EntityClasses;
using AW.Data.Linq;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Win.Properties;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.MostRecentlyUsedHandler;
using Korzh.EasyQuery;
using Korzh.EasyQuery.Db;
using Korzh.EasyQuery.WinControls;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Expression = System.Linq.Expressions.Expression;
using Path = System.IO.Path;
using Query = Korzh.EasyQuery.Query;

namespace AW.Win
{
  /// <summary>
  ///   Summary description for Form1.
  /// </summary>
  public class FrmEasyQuery : FrmPersistantLocation
  {
    private const string DefaultFileName = "lastquery.xml";

    /// <summary>
    ///   Required designer variable.
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

    private readonly string _dataFolder = "";

    private string appDirectory;
    private Button buttonSaveModel;
    private GridDataEditor dataGrid1;
    private NumericUpDown numericUpDownNumRows;
    private CheckBox checkBoxIQueryable;

    private SqlConnection sqlCon;

    public FrmEasyQuery()
    {
      appDirectory = Directory.GetCurrentDirectory();
      _dataFolder = appDirectory;

      InitializeComponent();
      query1.Model = dataModel1;
      QPanel.Query = query1;
      QPanel.Activate();
      QCPanel.Activate();
      SCPanel.Activate();
      EntPanel.UpdateModelInfo();
      DBMode = Settings.Default.EasyQueryDBMode;
    }

    public int DBMode
    {
      get { return comboBoxDbType.SelectedIndex; }
      set { comboBoxDbType.SelectedIndex = value; }
    }

    public MRUHandler MRUHandlerProject { get; set; }

    private void OnDBModeChange()
    {
      CloseConnections();
      var dbQuery = query1;
      dbQuery.Clear();
      if (DBMode == 0)
      {
        dbQuery.Formats.SetDefaultFormats(FormatType.MsSqlServer);
        dbQuery.Formats.UseSchema = true;
        dbQuery.Model.LoadFromFile(Path.Combine(_dataFolder, "AdventureWorks.xml"));
      }
      else
      {
        LoadFromLinqMetaData(dbQuery);
      }
      QPanel.UpdateModelInfo();
      QCPanel.UpdateModelInfo();
      EntPanel.UpdateModelInfo();
      Settings.Default.EasyQueryDBMode = DBMode;
    }

    public static void LoadFromLinqMetaData(DbQuery dbQuery)
    {
      dbQuery.Formats.SetDefaultFormats(FormatType.EntityFramework);
      dbQuery.Model.Clear();
      dbQuery.Model.LoadFromContext(typeof (LinqMetaData), typeof (DataSource<>));
      var dbModel = dbQuery.Model as DbModel;
      if (dbModel == null) return;
      foreach (var subEntity in dbModel.EntityRoot.SubEntities)
      {
        for (var i = subEntity.Attributes.Count - 1; i >= 0; i--)
        {
          if (ShouldBeExcluded(subEntity.Attributes[i]))
            subEntity.Attributes.RemoveAt(i);
        }
      }
      //dbModel.UpdateEntityJoinInfo(typeof(AddressEntity), typeof(StateProvinceEntity), "StateProvinceID", "StateProvinceID");
      //dbModel.UpdateEntityJoinInfo(typeof(SalesOrderHeaderEntity), typeof(CustomerViewRelatedEntity), "CustomerID", "CustomerID");
    }

    public static bool ShouldBeExcluded(EntityAttr entityAttr)
    {
      return entityAttr.DataType == DataType.Bool &&
             entityAttr.Caption.StartsWith("AlreadyFetched")
             || entityAttr.Caption.StartsWith("AlwaysFetch")
             || entityAttr.Caption.EndsWith("ReturnsNewIfNotFound")
             || entityAttr.Caption == "IsNew" || entityAttr.Caption == "IsDirty";
    }

    private void CheckConnection()
    {
      if (DBMode == 0)
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

    private void FrmEasyQuery_FormClosed(object sender, FormClosedEventArgs e)
    {
      QPanel.Query.SaveToFile(GetFileNameWithPath(DefaultFileName));
    }

    /// <summary>
    ///   Clean up any resources being used.
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
    ///   Required method for Designer support - do not modify
    ///   the contents of this method with the code editor.
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
      this.dataGrid1 = new AW.Winforms.Helpers.Controls.GridDataEditor();
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
      this.splitter3 = new System.Windows.Forms.Splitter();
      this.groupBoxColumns = new System.Windows.Forms.GroupBox();
      this.QCPanel = new Korzh.EasyQuery.WinControls.QueryColumnsPanel();
      this.groupBoxConditions = new System.Windows.Forms.GroupBox();
      this.QPanel = new Korzh.EasyQuery.WinControls.QueryPanel();
      this.panelColumns = new System.Windows.Forms.Panel();
      this.splitter4 = new System.Windows.Forms.Splitter();
      this.groupBoxSorting = new System.Windows.Forms.GroupBox();
      this.SCPanel = new Korzh.EasyQuery.WinControls.SortColumnsPanel();
      this.panelButtons = new System.Windows.Forms.Panel();
      this.buttonSaveModel = new System.Windows.Forms.Button();
      this.btCodeSamples = new System.Windows.Forms.Button();
      this.btClear = new System.Windows.Forms.Button();
      this.btLoad = new System.Windows.Forms.Button();
      this.btSave = new System.Windows.Forms.Button();
      this.btExecute = new System.Windows.Forms.Button();
      this.checkBoxIQueryable = new System.Windows.Forms.CheckBox();
      this.numericUpDownNumRows = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.ResultDataTable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ResultDS)).BeginInit();
      this.panelBottom.SuspendLayout();
      this.groupBoxResultSet.SuspendLayout();
      this.groupBoxSQL.SuspendLayout();
      this.panelBG.SuspendLayout();
      this.groupBoxEntities.SuspendLayout();
      this.panelQuery.SuspendLayout();
      this.groupBoxColumns.SuspendLayout();
      this.groupBoxConditions.SuspendLayout();
      this.panelColumns.SuspendLayout();
      this.groupBoxSorting.SuspendLayout();
      this.panelButtons.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).BeginInit();
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
      // openFileDlg
      // 
      this.openFileDlg.Filter = "XML files|*.xml|All files (*.*)|*.*";
      // 
      // saveFileDlg
      // 
      this.saveFileDlg.Filter = "XML files|*.xml|All files (*.*)|*.*";
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
      this.panelBottom.Location = new System.Drawing.Point(0, 355);
      this.panelBottom.Name = "panelBottom";
      this.panelBottom.Size = new System.Drawing.Size(838, 210);
      this.panelBottom.TabIndex = 23;
      // 
      // groupBoxResultSet
      // 
      this.groupBoxResultSet.Controls.Add(this.dataGrid1);
      this.groupBoxResultSet.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBoxResultSet.Location = new System.Drawing.Point(0, 65);
      this.groupBoxResultSet.Name = "groupBoxResultSet";
      this.groupBoxResultSet.Size = new System.Drawing.Size(838, 145);
      this.groupBoxResultSet.TabIndex = 2;
      this.groupBoxResultSet.TabStop = false;
      this.groupBoxResultSet.Text = "Result set";
      // 
      // dataGrid1
      // 
      this.dataGrid1.DataMember = "";
      this.dataGrid1.DataSource = null;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGrid1.Location = new System.Drawing.Point(3, 16);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.PageSize = ((ushort)(0));
      this.dataGrid1.Readonly = false;
      this.dataGrid1.Size = new System.Drawing.Size(832, 126);
      this.dataGrid1.TabIndex = 0;
      // 
      // splitter1
      // 
      this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitter1.Location = new System.Drawing.Point(0, 62);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(838, 3);
      this.splitter1.TabIndex = 1;
      this.splitter1.TabStop = false;
      // 
      // groupBoxSQL
      // 
      this.groupBoxSQL.Controls.Add(this.teSQL);
      this.groupBoxSQL.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBoxSQL.Location = new System.Drawing.Point(0, 0);
      this.groupBoxSQL.Name = "groupBoxSQL";
      this.groupBoxSQL.Size = new System.Drawing.Size(838, 62);
      this.groupBoxSQL.TabIndex = 0;
      this.groupBoxSQL.TabStop = false;
      this.groupBoxSQL.Text = "SQL";
      // 
      // teSQL
      // 
      this.teSQL.Dock = System.Windows.Forms.DockStyle.Fill;
      this.teSQL.Location = new System.Drawing.Point(3, 16);
      this.teSQL.Multiline = true;
      this.teSQL.Name = "teSQL";
      this.teSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.teSQL.Size = new System.Drawing.Size(832, 43);
      this.teSQL.TabIndex = 9;
      // 
      // splitter2
      // 
      this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitter2.Location = new System.Drawing.Point(0, 352);
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
      this.panelBG.Size = new System.Drawing.Size(838, 352);
      this.panelBG.TabIndex = 25;
      // 
      // groupBoxEntities
      // 
      this.groupBoxEntities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.groupBoxEntities.Controls.Add(this.EntPanel);
      this.groupBoxEntities.Location = new System.Drawing.Point(3, 44);
      this.groupBoxEntities.Name = "groupBoxEntities";
      this.groupBoxEntities.Size = new System.Drawing.Size(179, 308);
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
      this.EntPanel.Size = new System.Drawing.Size(173, 283);
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
      this.panelQuery.Controls.Add(this.splitter3);
      this.panelQuery.Controls.Add(this.groupBoxColumns);
      this.panelQuery.Controls.Add(this.groupBoxConditions);
      this.panelQuery.Controls.Add(this.panelColumns);
      this.panelQuery.Location = new System.Drawing.Point(185, 41);
      this.panelQuery.Name = "panelQuery";
      this.panelQuery.Size = new System.Drawing.Size(569, 311);
      this.panelQuery.TabIndex = 23;
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
      // groupBoxColumns
      // 
      this.groupBoxColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxColumns.Controls.Add(this.QCPanel);
      this.groupBoxColumns.Location = new System.Drawing.Point(0, 0);
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
      this.groupBoxConditions.Size = new System.Drawing.Size(566, 166);
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
      this.QPanel.Size = new System.Drawing.Size(553, 149);
      this.QPanel.TabIndex = 27;
      this.QPanel.TabStop = true;
      this.QPanel.SqlExecute += new Korzh.EasyQuery.WinControls.SqlExecuteEventHandler(this.QPanel_SqlExecute);
      this.QPanel.ValueRequest += new Korzh.EasyQuery.WinControls.ValueRequestEventHandler(this.QPanel_ValueRequest);
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
      this.panelButtons.Controls.Add(this.checkBoxIQueryable);
      this.panelButtons.Controls.Add(this.numericUpDownNumRows);
      this.panelButtons.Controls.Add(this.buttonSaveModel);
      this.panelButtons.Controls.Add(this.btCodeSamples);
      this.panelButtons.Controls.Add(this.btClear);
      this.panelButtons.Controls.Add(this.btLoad);
      this.panelButtons.Controls.Add(this.btSave);
      this.panelButtons.Controls.Add(this.btExecute);
      this.panelButtons.Location = new System.Drawing.Point(760, 38);
      this.panelButtons.Name = "panelButtons";
      this.panelButtons.Size = new System.Drawing.Size(78, 311);
      this.panelButtons.TabIndex = 22;
      // 
      // buttonSaveModel
      // 
      this.buttonSaveModel.Location = new System.Drawing.Point(8, 128);
      this.buttonSaveModel.Name = "buttonSaveModel";
      this.buttonSaveModel.Size = new System.Drawing.Size(62, 35);
      this.buttonSaveModel.TabIndex = 14;
      this.buttonSaveModel.Text = "Save Model";
      this.buttonSaveModel.Click += new System.EventHandler(this.buttonSaveModel_Click);
      // 
      // btCodeSamples
      // 
      this.btCodeSamples.Location = new System.Drawing.Point(8, 214);
      this.btCodeSamples.Name = "btCodeSamples";
      this.btCodeSamples.Size = new System.Drawing.Size(62, 36);
      this.btCodeSamples.TabIndex = 13;
      this.btCodeSamples.Text = "Code Samples";
      this.btCodeSamples.Click += new System.EventHandler(this.btCodeSamples_Click);
      // 
      // btClear
      // 
      this.btClear.Location = new System.Drawing.Point(8, 6);
      this.btClear.Name = "btClear";
      this.btClear.Size = new System.Drawing.Size(62, 24);
      this.btClear.TabIndex = 12;
      this.btClear.Text = "Clear";
      this.btClear.Click += new System.EventHandler(this.btClear_Click);
      // 
      // btLoad
      // 
      this.btLoad.Location = new System.Drawing.Point(8, 36);
      this.btLoad.Name = "btLoad";
      this.btLoad.Size = new System.Drawing.Size(62, 24);
      this.btLoad.TabIndex = 11;
      this.btLoad.Text = "Load";
      this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
      // 
      // btSave
      // 
      this.btSave.Location = new System.Drawing.Point(8, 66);
      this.btSave.Name = "btSave";
      this.btSave.Size = new System.Drawing.Size(62, 24);
      this.btSave.TabIndex = 10;
      this.btSave.Text = "Save";
      this.btSave.Click += new System.EventHandler(this.btSave_Click);
      // 
      // btExecute
      // 
      this.btExecute.Location = new System.Drawing.Point(8, 169);
      this.btExecute.Name = "btExecute";
      this.btExecute.Size = new System.Drawing.Size(62, 39);
      this.btExecute.TabIndex = 9;
      this.btExecute.Text = "Execute Query";
      this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
      // 
      // checkBoxIQueryable
      // 
      this.checkBoxIQueryable.AutoSize = true;
      this.checkBoxIQueryable.Checked = global::AW.Win.Properties.Settings.Default.IQueryable;
      this.checkBoxIQueryable.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AW.Win.Properties.Settings.Default, "IQueryable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.checkBoxIQueryable.Location = new System.Drawing.Point(8, 283);
      this.checkBoxIQueryable.Name = "checkBoxIQueryable";
      this.checkBoxIQueryable.Size = new System.Drawing.Size(77, 17);
      this.checkBoxIQueryable.TabIndex = 25;
      this.checkBoxIQueryable.Text = "IQueryable";
      this.checkBoxIQueryable.UseVisualStyleBackColor = true;
      // 
      // numericUpDownNumRows
      // 
      this.numericUpDownNumRows.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AW.Win.Properties.Settings.Default, "NumRows", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.numericUpDownNumRows.Location = new System.Drawing.Point(8, 256);
      this.numericUpDownNumRows.Name = "numericUpDownNumRows";
      this.numericUpDownNumRows.Size = new System.Drawing.Size(48, 20);
      this.numericUpDownNumRows.TabIndex = 24;
      this.numericUpDownNumRows.Tag = "True";
      this.numericUpDownNumRows.Value = global::AW.Win.Properties.Settings.Default.NumRows;
      // 
      // FrmEasyQuery
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(838, 565);
      this.Controls.Add(this.panelBG);
      this.Controls.Add(this.splitter2);
      this.Controls.Add(this.panelBottom);
      this.Name = "FrmEasyQuery";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Tag = "True";
      this.Text = "Easy Query.NET WinForms demo";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEasyQuery_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.ResultDataTable)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ResultDS)).EndInit();
      this.panelBottom.ResumeLayout(false);
      this.groupBoxResultSet.ResumeLayout(false);
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
      this.panelButtons.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumRows)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private void btClear_Click(object sender, EventArgs e)
    {
      try
      {
        _clearing = true;
        QPanel.Query.Clear();
      }
      finally
      {
        _clearing = false;
      }
    }

    private void btLoad_Click(object sender, EventArgs e)
    {
      openFileDlg.FileName = GetFileNameWithPath(_lastFileName);
      if (openFileDlg.ShowDialog() == DialogResult.OK)
      {
        LoadFromFile(openFileDlg.FileName);
        if (MRUHandlerProject != null) MRUHandlerProject.AddRecentlyUsedFile(openFileDlg.FileName);
      }
    }

    public void LoadFromFile(string fileName = null)
    {
      QPanel.Query.Clear();
      if (fileName == null)
        fileName = DefaultFileName;
      var fullFileName = GetFileNameWithPath(fileName);
      if (!File.Exists(fullFileName)) return;
      QPanel.Query.LoadFromFile(fullFileName);
      if (fileName != DefaultFileName)
        _lastFileName = fileName;
    }

    private string GetFileNameWithPath(string fileName)
    {
      return Path.IsPathRooted(fileName) ? fileName : Path.Combine(_dataFolder, fileName);
    }

    private void btSave_Click(object sender, EventArgs e)
    {
      saveFileDlg.FileName = Path.Combine(_dataFolder, _lastFileName);
      if (saveFileDlg.ShowDialog() == DialogResult.OK)
      {
        QPanel.Query.SaveToFile(saveFileDlg.FileName);
        _lastFileName = saveFileDlg.FileName;
        if (MRUHandlerProject != null) MRUHandlerProject.AddRecentlyUsedFile(_lastFileName);
      }
    }

    private void btExecute_Click(object sender, EventArgs e)
    {
      try
      {
        ResultDS.Reset();
        //BuildSQL();
        var sql = teSQL.Text;
        CheckConnection();
        if (DBMode == 0)
        {
          var resultDA = new SqlDataAdapter(sql, sqlCon);
          resultDA.Fill(ResultDS, "Result");
          dataGrid1.DataSource = ResultDS.Tables[0].DefaultView;
          sqlCon.Close();
        }
        else
        {
          if (Settings.Default.IQueryable)
          //dataGrid1.DataSource = GetQuery();
            dataGrid1.BindEnumerable(GetQuery(), Convert.ToUInt16(numericUpDownNumRows.Value));
          else
            dataGrid1.BindEnumerable(ExecuteToEnumerable(), Convert.ToUInt16(numericUpDownNumRows.Value));
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
        if (DBMode == 0)
        {
          var builder = new SqlQueryBuilder(query1);
          if (builder.CanBuild)
          {
            builder.BuildSQL();
            teSQL.Text = builder.Result.SQL;
          }
        }
        else if (_clearing)
          teSQL.Text = "";
        else if (query1.Columns.Count > 0 || query1.Root.Conditions.Count > 0)
        {
          var expression = GetLinqExpression();
          teSQL.Text = expression.ToString();
        }
      }
      catch
      {
        //Simply ignore any possible exception
      }
    }

    private Expression GetLinqExpression()
    {
      return GetLinqExpression(query1);
    }

    public static Expression GetLinqExpression(Query query)
    {
      var linqQueryBuilder = new LinqQueryBuilder(query, MetaSingletons.MetaData);
      var expression = linqQueryBuilder.Build();
      return expression;
    }

    private void QPanel_SqlExecute(object sender, SqlExecuteEventArgs e)
    {
      CheckConnection();
      var strWriter = new StringWriter();
      var tempDS = new DataSet();
      if (DBMode == 0)
      {
        var tempDA = new SqlDataAdapter(e.SQL, sqlCon);
        tempDA.Fill(tempDS, "Temp");
        tempDS.WriteXml(strWriter);
      }
      else
      {
        ExecuteToDataTable();
      }
      e.ResultXml = strWriter.ToString();
    }

    private DataTable ExecuteToDataTable()
    {
      var queryResult = ExecuteToEnumerable();
      //          var dynamicInvoke = Expression.Lambda(expression).Compile().DynamicInvoke() as IEnumerable;
      return queryResult.CopyToDataTable();
    }

    private IEnumerable ExecuteToEnumerable()
    {
      var expression = GetLinqExpression();
      var queryResult = EntityHelper.GetProvider(MetaSingletons.MetaData).Execute(expression) as IEnumerable;
      return queryResult;
    }

    private IQueryable GetQuery()
    {
      var expression = GetLinqExpression();
      var methodCallExpression = expression as MethodCallExpression;
      var queryProvider = EntityHelper.GetProvider(MetaSingletons.MetaData);
      if (methodCallExpression != null)
      {
        var expressionParts = EntityHelper.GetMethodCallExpressionParts(methodCallExpression);
        var queryable = queryProvider.CreateQuery(expressionParts.Item1);
        queryable = queryable.WhereDynamic(expressionParts.Item2);
        //queryable = queryable.OrderByDynamic(expressionParts.Item3);
        return queryable;
      }
      return queryProvider.CreateQuery(expression);
    }

    private string _lastFileName = DefaultFileName;
    private bool _clearing;

    private void query1_ColumnsChanged(object sender, ColumnsChangeEventArgs e)
    {
      ResultDS.Reset();
      BuildSQL();
    }

    private void query1_ConditionsChanged(object sender, ConditionsChangeEventArgs e)
    {
      ResultDS.Reset();
      BuildSQL();
    }

    private void ResetDataModel()
    {
      query1.Clear();
      dataModel1.LoadFromFile(Path.Combine(_dataFolder, "AdventureWorks.xml"));
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

      if (DBMode == 0)
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
      foreach (var attr in entity.Attributes)
      {
        attr.Operations.Clear();
        attr.Operations.AddByIDs(dataModel1, "Equal,NotEqual,InList,NotInList");
        var valEditor = new SqlListValueEditor {SQL = string.Format("SELECT DISTINCT {0}, {0} FROM {1}", attr.Expr, ((DbEntityAttr) attr).Tables[0].Alias)};
        attr.DefaultEditor = valEditor;
      }
    }

    private void menuItemAddConditions_Click(object sender, EventArgs e)
    {
      if (DBMode == 1)
      {
        MessageBox.Show("Not implemented for EntityFramework mode");
        return;
      }
      ResetDataModel();
      query1.Clear();

      var attr = dataModel1.EntityRoot.FindAttribute(EntityAttrProp.Expression, "Customers.Country");

      //create columns
      Column col = new DbColumn("Country", SortDirection.Ascending) {Expr = new DbEntityAttrExpr(dataModel1, attr)};
      query1.Columns.Add(col);

      attr = dataModel1.EntityRoot.FindAttribute(EntityAttrProp.Expression, "Orders.Freight");
      col = new DbColumn("Total sum", SortDirection.None) {Expr = new DbAggrFuncExpr(dataModel1, "SUM", new DbEntityAttrExpr(dataModel1, attr))};
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
      OnDBModeChange();
    }

    private void buttonSaveModel_Click(object sender, EventArgs e)
    {
      query1.Model.SaveToFile(Path.Combine(_dataFolder, (DBMode == 0 ? "AWSQLModel" : "AWLLBLModel") + ".xml"));
    }
  }
}