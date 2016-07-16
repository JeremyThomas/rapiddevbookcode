using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.LLBL.Annotations;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public partial class UsrCntrlEntityExplorer : UserControl, IContextAwareElement, INotifyPropertyChanged
  {
    public const int DefaultCacheDurationInSeconds = 20;
    public const string DefaultPrefixDelimiter = "_";
    private ILinqMetaData _linqMetaData;
    private bool _userHasInteracted;
    private EntityHelper.GetQueryableForEntityDelegate _getQueryableForEntityDelegate;
    private bool _useSchema;
    private string _prefixDelimiter;
    private int _cacheDurationInSeconds;
    private bool _useContext;

    [DefaultValue(DefaultPrefixDelimiter), Category("EntityBrowser"),
     Description("Table Prefix Delimiter to group Entities by (e.g. with a delimiter of _ table Sales_Order would grouped into a node called Sales)")]
    public string PrefixDelimiter
    {
      get { return _prefixDelimiter; }
      set
      {
        if (_prefixDelimiter != value)
        {
          _prefixDelimiter = value;
          PopulateTreeViewWithSchema();
          OnPropertyChanged();
        }
        prefixDelimiterTextBox.Text = value;
      }
    }

    [DefaultValue(true), Category("EntityBrowser"),
     Description("Use Table Schema to group the Entities")]
    public bool UseSchema
    {
      get { return _useSchema; }
      set
      {
        if (_useSchema != value)
        {
          _useSchema = value;
          PopulateTreeViewWithSchema();
          OnPropertyChanged();
        }
        useSchemaCheckBox.Checked = value;
      }
    }

    [Category("EntityBrowser"), Description("Specifies whether filtering is enabled in the grid, even if the underlying collection doesn't support it.")]
    public bool EnsureFilteringEnabled
    {
      get { return gridDataEditor.EnsureFilteringEnabled; }
      set
      {
        gridDataEditor.EnsureFilteringEnabled = value;
        ensureFilteringEnabledCheckBox.Checked = value;
        OnPropertyChanged();
      }
    }

    [Category("EntityBrowser"), Description("Page size in the grid. Zero for no paging.")]
    public ushort PageSize
    {
      get { return gridDataEditor.PageSize; }
      set
      {
        gridDataEditor.PageSize = value;
        pageSizeNumericUpDown.Value = value;
        OnPropertyChanged();
      }
    }

    [DefaultValue(DefaultCacheDurationInSeconds), Category("EntityBrowser"),
     Description("Specifies the duration that the query's result set should be cached for. Zero to turn caching off.")]
    public int CacheDurationInSeconds
    {
      get { return _cacheDurationInSeconds; }
      set
      {
        if (value == 0)
        {
          CacheController.PurgeResultsets(Name);
        }
        _cacheDurationInSeconds = value;
        cacheDurationInSecondsNumericUpDown.Value = value;
        OnPropertyChanged();
      }
    }

    [DefaultValue(true), Category("EntityBrowser"),
     Description("Deletes cascade non-recursively to children of the selected entity.")]
    public bool CascadeDeletes
    {
      get { return toolStripCheckBoxDeletesAreCascading.Checked; }
      set { toolStripCheckBoxDeletesAreCascading.Checked = value; }
    }

    private void ensureFilteringEnabledCheckBox_Click(object sender, EventArgs e)
    {
      EnsureFilteringEnabled = ensureFilteringEnabledCheckBox.Checked;
    }

    private void toolStripCheckBox1_Click(object sender, EventArgs e)
    {
      UseSchema = useSchemaCheckBox.Checked;
    }

    private void useContextCheckBox_Click(object sender, EventArgs e)
    {
      UseContext = useContextCheckBox.Checked;
    }

    private void cacheDurationInSecondsNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      CacheDurationInSeconds = (int) cacheDurationInSecondsNumericUpDown.Value;
    }

    private void pageSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
      PageSize = (ushort) pageSizeNumericUpDown.Value;
    }

    private void prefixDelimiterTextBox_Click(object sender, EventArgs e)
    {
      PrefixDelimiter = prefixDelimiterTextBox.Text;
    }

    private void toolStripCheckBoxDeletesAreCascading_Click(object sender, EventArgs e)
    {
      gridDataEditor.CascadeDeletes = toolStripCheckBoxDeletesAreCascading.Checked;
      OnPropertyChanged();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }

    [DefaultValue(true), Category("EntityBrowser"),
     Description(
       "Specifies whether a Context is used for entity fetches, if true then entities will remain dirty until saved or reverted, i.e. the entity stays in memory and will be reused even if re-fetched."
       )]
    public bool UseContext
    {
      get { return HasLinqMetaData ? ContextToUse != null : _useContext; }
      set { SetContextToUse(value); }
    }

    private void SetContextToUse()
    {
      SetContextToUse(_useContext);
    }

    private void SetContextToUse(bool value)
    {
      if (HasLinqMetaData)
      {
        if (value)
        {
          if (!UseContext)
          {
            var dataEditorLLBLDataScopePersister = new DataEditorLLBLDataScopePersister(this, EntityHelper.GetTransactionController(_linqMetaData));
            gridDataEditor.DataEditorPersister = dataEditorLLBLDataScopePersister;
            dataEditorLLBLDataScopePersister.ContainedDataChanged += DataEditorEventHandlers_ContainedDataChanged;
            dataEditorLLBLDataScopePersister.EntityAdded += DataEditorEventHandlers_EntityAdded;
            dataEditorLLBLDataScopePersister.EntityRemoved += dataEditorLLBLDataScopePersister_EntityRemoved;
            dataEditorLLBLDataScopePersister.EditingFinished += dataEditorLLBLDataScopePersister_EditingFinished;
            saveToolStripButton.Visible = true;
            toolStripButtonCancelEdit.Visible = true;
          }
        }
        else
        {
          ContextToUse = null;
          gridDataEditor.DataEditorPersister = null;
          saveToolStripButton.Visible = false;
          toolStripButtonCancelEdit.Visible = false;
        }
      }
      else
        _useContext = value;
      useContextCheckBox.Checked = value;
      // ReSharper disable once UseNameofExpression
      OnPropertyChanged("UseContext");
    }

    private bool HasLinqMetaData
    {
      get { return _linqMetaData != null; }
    }

    /// <summary>
    /// </summary>
    public Context ContextToUse
    {
      //IContextAwareElement contextAwareElement = (object) query as IContextAwareElement;
      get { return HasLinqMetaData ? EntityHelper.GetContextToUse(_linqMetaData) : null; }
      set
      {
        if (HasLinqMetaData)
          ((dynamic) _linqMetaData).ContextToUse = value;
      }
    }

    private GeneralEntityCollectionDataScope EntityCollectionDataScope
    {
      get
      {
        var dataEditorLLBLDataScopePersister = gridDataEditor.DataEditorPersister as DataEditorLLBLDataScopePersister;
        if (dataEditorLLBLDataScopePersister == null) return null;
        return dataEditorLLBLDataScopePersister.GeneralEntityCollectionDataScope;
      }
    }

    public static FrmPersistantLocation ShowDataBrowser(ILinqMetaData linqMetaData, Form parentForm = null,
      bool useSchema = true, string prefixDelimiter = DefaultPrefixDelimiter, bool ensureFilteringEnabled = true, 
      bool useContext = true, int cacheDurationInSeconds = DefaultCacheDurationInSeconds,
      ushort pageSize = GridDataEditor.DefaultPageSize, bool cascadeDeletes = true,
      params string[] membersToExclude)
    {
      var usrCntrlEntityBrowser = new UsrCntrlEntityExplorer(linqMetaData, useSchema, prefixDelimiter,
        ensureFilteringEnabled, useContext, cacheDurationInSeconds, pageSize, cascadeDeletes, membersToExclude);
      var dataBrowser = FrmPersistantLocation.ShowControlInForm(usrCntrlEntityBrowser, "Data Browser", parentForm, "DataBrowser");
      //usrCntrlEntityBrowser.ResizeToFitNodes();
      return dataBrowser;
    }

    public UsrCntrlEntityExplorer()
    {
      InitializeComponent();
      PrefixDelimiter = DefaultPrefixDelimiter;
      UseSchema = true;
      UseContext = true;
      CascadeDeletes = true;
      CacheDurationInSeconds = DefaultCacheDurationInSeconds;
      gridDataEditor.PropertyChanged += GridDataEditor_PropertyChanged;
    }

    private void GridDataEditor_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      if (e.PropertyName == "PageSize")
        pageSizeNumericUpDown.Value = gridDataEditor.PageSize;
      else if (e.PropertyName == "EnsureFilteringEnabled")
        ensureFilteringEnabledCheckBox.Checked = gridDataEditor.EnsureFilteringEnabled;
      else if (e.PropertyName == "CascadeDeletes")
        toolStripCheckBoxDeletesAreCascading.Checked = gridDataEditor.CascadeDeletes;
      OnPropertyChanged(e.PropertyName);
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="UsrCntrlEntityExplorer" /> class.
    /// </summary>
    /// <param name="linqMetaData">The linq meta data.</param>
    /// <param name="useSchema">if set to <c>true</c> [use schema].</param>
    /// <param name="prefixDelimiter">The prefix delimiter.</param>
    /// <param name="ensureFilteringEnabled">if set to <c>true</c> [ensure filtering enabled].</param>
    /// <param name="useContext">if set to <c>true</c> [use context].</param>
    /// <param name="cacheDurationInSeconds">The cache duration in seconds, 0 means don't cache.</param>
    /// <param name="pageSize">Size of the page.</param>
    /// <param name="cascadeDeletes">if set to <c>true</c> [cascade deletes].</param>
    /// <param name="membersToExclude">The members to exclude.</param>
    public UsrCntrlEntityExplorer(ILinqMetaData linqMetaData, bool useSchema = true, string prefixDelimiter = DefaultPrefixDelimiter,
      bool ensureFilteringEnabled = true, bool useContext = true, int cacheDurationInSeconds = DefaultCacheDurationInSeconds,
      ushort pageSize = GridDataEditor.DefaultPageSize, bool cascadeDeletes = true, params string[] membersToExclude)
      : this()
    {
      PrefixDelimiter = prefixDelimiter;
      UseSchema = useSchema;
      UseContext = useContext;
      Initialize(linqMetaData, null, membersToExclude);
      EnsureFilteringEnabled = ensureFilteringEnabled;
      CacheDurationInSeconds = cacheDurationInSeconds;
      PageSize = pageSize;
      CascadeDeletes = cascadeDeletes;
    }

    /// <summary>
    ///   Initializes the specified linq meta data.
    /// </summary>
    /// <param name="linqMetaData">The linq meta data.</param>
    /// <param name="getQueryableForEntityDelegate">The get queryable for entity delegate.</param>
    /// <param name="membersToExclude">The members to exclude.</param>
    public void Initialize(ILinqMetaData linqMetaData, EntityHelper.GetQueryableForEntityDelegate getQueryableForEntityDelegate = null, params string[] membersToExclude)
    {
      _linqMetaData = linqMetaData;
      var dataAccessAdapter = EntityHelper.GetTransactionController(_linqMetaData) as IDataAccessAdapter;
      toolStripNumericUpDownCommandTimeOut.Value = dataAccessAdapter == null ? DaoBase.CommandTimeOut : dataAccessAdapter.CommandTimeOut;
      SetContextToUse();
      _getQueryableForEntityDelegate = getQueryableForEntityDelegate;
      gridDataEditor.MembersToExclude = membersToExclude;
      gridDataEditor.BindingListViewCreater = BindingListViewCreater;
      PopulateTreeViewWithSchema();
    }

    private bool _fullyPainted;

    /// <summary>
    ///   http://stackoverflow.com/questions/7309736/which-event-is-launched-right-after-control-is-fully-loaded
    ///   TCM_SETCURSEL==32
    /// </summary>
    /// <param name="m">The Message.</param>
    protected override void WndProc(ref Message m)
    {
      base.WndProc(ref m);
      if ((m.Msg == 15 || m.Msg == 32) && !_fullyPainted)
      {
        _fullyPainted = true;
        ResizeToFitNodes(); //Also want to do it when tab for the first time
      }
    }

    private void UsrCntrlEntityBrowser_VisibleChanged(object sender, EventArgs e)
    {
    }

    private void UsrCntrlEntityBrowser_Load(object sender, EventArgs e)
    {
    }

    private IBindingListView BindingListViewCreater(IEnumerable enumerable, Type itemType)
    {
      var genericDataScopeBase = EntityCollectionDataScope;
      if (genericDataScopeBase != null && enumerable != null)
      {
        var queryable = enumerable as IQueryable;
        if (queryable != null)
          enumerable = genericDataScopeBase.FetchData(queryable);
      }
      return EntityHelper.CreateEntityView(enumerable, itemType);
    }

    private void PopulateTreeViewWithSchema()
    {
      if (HasLinqMetaData)
      {
        treeViewEntities.Nodes.Clear();
        LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities.Nodes, _linqMetaData, null, UseSchema, PrefixDelimiter);
        //treeViewEntities.Sort();
      }
    }

    //#region Overrides of UserControl

    ///// <summary>
    /////   Raises the CreateControl event.
    ///// </summary>
    //protected override void OnCreateControl()
    //{
    //  if (treeViewEntities.Nodes.Count == 0)
    //    LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities, EntityHelper.GetEntitiesTypes(null, _linqMetaData));
    //  base.OnCreateControl();
    //}

    //#endregion

    private void treeViewEntities_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (!_userHasInteracted)
        return;
      var prop = treeViewEntities.SelectedNode.Tag as PropertyDescriptor;
      if (prop != null)
      {
        var typeParameter = ListBindingHelper.GetListItemType(prop.PropertyType);
        //if (typeof(IEntityCore).IsAssignableFrom(prop.PropertyType))
        //  typeParameter = prop.PropertyType;
        //if (typeParameter == null)
        //  typeParameter = MetaDataHelper.GetTypeParameterOfGenericType(prop.PropertyType);
        if (typeParameter != null)
          if (treeViewEntities.Nodes.ContainsKey(typeParameter.Name))
          {
            treeViewEntities.SelectedNode = treeViewEntities.Nodes[typeParameter.Name];
            treeViewEntities.SelectedNode.Expand();
          }
          else
          {
            var treeNodes = treeViewEntities.Nodes.Find(typeParameter.Name, true);
            var firstOrDefault = treeNodes.FirstOrDefault();
            if (firstOrDefault != null)
            {
              treeViewEntities.SelectedNode = firstOrDefault;
              treeViewEntities.SelectedNode.Expand();
            }
          }
      }
      else
      {
        openPagedToolStripMenuItem_Click();
      }
    }

    private void Open()
    {
      var entityQueryable = GetEntityQueryable();
      if (entityQueryable != null)
        ViewEntities(entityQueryable);
    }

    private IQueryable GetEntityQueryable()
    {
      return _getQueryableForEntityDelegate == null
        ? EntityHelper.GetQueryableForEntityIgnoreIfNull(_linqMetaData, treeViewEntities.SelectedNode.Tag as Type)
        : _getQueryableForEntityDelegate(_linqMetaData, treeViewEntities.SelectedNode.Tag as Type);
    }

    private void ViewEntities(IQueryable entityQueryable)
    {
      if (typeof(IEntity).IsAssignableFrom(entityQueryable.ElementType))
      {
        if (gridDataEditor.DataEditorPersister == null)
          gridDataEditor.DataEditorPersister = new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister();
      }
      else
      {
        var provider = entityQueryable.Provider as LLBLGenProProvider2;
        if (provider != null && gridDataEditor.DataEditorPersister == null)
          gridDataEditor.DataEditorPersister = new LLBLWinformHelper.DataEditorLLBLAdapterPersister(provider.AdapterToUse);
      }
      gridDataEditor.BindEnumerable(CacheResultset(entityQueryable));
    }

    /// <summary>
    ///   Set a Cache on the base query of the gridDataEditor, which means all paging based off that query will be cached too.
    /// </summary>
    /// <param name="entityQueryable">The entity queryable.</param>
    /// <returns></returns>
    private dynamic CacheResultset(dynamic entityQueryable)
    {
      return CacheDurationInSeconds > 0 ? QueryableExtensionMethods.CacheResultset(entityQueryable, CacheDurationInSeconds, false, Name) : entityQueryable;
    }

    private void openPagedToolStripMenuItem_Click()
    {
      Open();
    }

    private void treeViewEntities_Click(object sender, EventArgs e)
    {
      _userHasInteracted = true;
    }

    private void treeViewEntities_KeyDown(object sender, KeyEventArgs e)
    {
      _userHasInteracted = true;
    }

    private void saveToolStripButton_Click(object sender, EventArgs e)
    {
      if (gridDataEditor.DataEditorPersister != null)
      {
        if (gridDataEditor.DataEditorPersister.Save(null, CascadeDeletes) == 0)
          gridDataEditor.SaveEdits();
        else
          gridDataEditor.CancelEdits();
        dataEditorLLBLDataScopePersister_EditingFinished(sender, e);
      }
    }

    private void toolStripButtonCancelEdit_Click(object sender, EventArgs e)
    {
      if (gridDataEditor.DataEditorPersister != null)
      {
        gridDataEditor.CancelEdits();
        if (gridDataEditor.DataEditorPersister.Undo())
          dataEditorLLBLDataScopePersister_EditingFinished(sender, e);
      }
    }

    void dataEditorLLBLDataScopePersister_EditingFinished(object sender, EventArgs e)
    {
      SetSaveButtons();
    }

    private void SetSaveButtons(bool enabled = false)
    {
      saveToolStripButton.Enabled = enabled;
      toolStripButtonCancelEdit.Enabled = saveToolStripButton.Enabled;
    }

    private void DataEditorEventHandlers_ContainedDataChanged(object sender, EventArgs e)
    {
      var propertyChangedEventArgs = e as PropertyChangedEventArgs;
      if (propertyChangedEventArgs == null || propertyChangedEventArgs.PropertyName != "IsDirty")
        SetSaveButtons(true);
    }

    private void dataEditorLLBLDataScopePersister_EntityRemoved(object sender, EventArgs e)
    {
      SetSaveButtons(true);
    }

    private void DataEditorEventHandlers_EntityAdded(object sender, EventArgs e)
    {
      toolStripButtonCancelEdit.Enabled = true;
    }

    private void treeViewEntities_AfterExpand(object sender, TreeViewEventArgs e)
    {
      AWHelper.ResizeToFitNodes(e);
    }

    public void ResizeToFitNodes()
    {
      AWHelper.ResizeToFitNodes(treeViewEntities);
    }

    private void toolStripNumericUpDownCommandTimeOut_ValueChanged(object sender, EventArgs e)
    {
      if (HasLinqMetaData)
      {
        var dataAccessAdapter = EntityHelper.GetTransactionController(_linqMetaData) as IDataAccessAdapter;
        if (dataAccessAdapter == null)
          DaoBase.CommandTimeOut = (int) toolStripNumericUpDownCommandTimeOut.Value;
        else
          dataAccessAdapter.CommandTimeOut = (int) toolStripNumericUpDownCommandTimeOut.Value;
      }
    }
  }
}