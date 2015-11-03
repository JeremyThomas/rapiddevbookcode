﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.LLBL.Annotations;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public partial class UsrCntrlEntityBrowser : UserControl, IContextAwareElement, INotifyPropertyChanged
  {
    public const int DefaultCacheDurationInSeconds = 20;
    public const string DefaultPrefixDelimiter = "_";
    private ILinqMetaData _linqMetaData;
    private bool _userHasInteracted;
    private EntityHelper.GetQueryableForEntityDelegate _getQueryableForEntityDelegate;
    private bool _useSchema;
    private string _prefixDelimiter;

    [DefaultValue(DefaultPrefixDelimiter),
     Category("EntityBrowser"),
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

    [DefaultValue(true),
     Category("EntityBrowser"),
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

    private bool _useContext;
    private int _cacheDurationInSeconds;

    [DefaultValue(true),
     Category("EntityBrowser"),
     Description("Gets or sets wether a Context is used for entity fetches, if true then entites will remain dirty until saved or reverted.")]
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
            dataEditorLLBLDataScopePersister.EntityAdded += DataEditorEventHandlers_ContainedDataChanged;
          }
        }
        else
        {
          ContextToUse = null;
          gridDataEditor.DataEditorPersister = null;
        }
      }
      else
        _useContext = value;
      useContextCheckBox.Checked = value;
      // ReSharper disable once UseNameofExpression
      OnPropertyChanged("UseContext");
    }

    private GenericDataScopeBase DataScope
    {
      get
      {
        var dataEditorLLBLDataScopePersister = gridDataEditor.DataEditorPersister as DataEditorLLBLDataScopePersister;
        if (dataEditorLLBLDataScopePersister == null) return null; return dataEditorLLBLDataScopePersister.GenericDataScope;
      }
    }


    [Category("EntityBrowser"), Description("Gets or sets wether filtering is enabled in the grid, even if the underlying collection doesn't support it.")]
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

    [DefaultValue(DefaultCacheDurationInSeconds), Category("EntityBrowser"), Description("Specifies that the query's resultset should be cached for the duration specified, 0 means don't cache at all.")]
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

    public static FrmPersistantLocation ShowDataBrowser(ILinqMetaData linqMetaData, Form parentForm = null,
      bool useSchema = true, string prefixDelimiter = DefaultPrefixDelimiter, bool ensureFilteringEnabled = true, bool useContext = true, int cacheDurationInSeconds = DefaultCacheDurationInSeconds,
      params string[] membersToExclude)
    {
      return FrmPersistantLocation.ShowControlInForm(new UsrCntrlEntityBrowser(linqMetaData, useSchema, prefixDelimiter,
        ensureFilteringEnabled, useContext, cacheDurationInSeconds, membersToExclude)
        , "Data Browser", parentForm, "DataBrowser");
    }

    public UsrCntrlEntityBrowser()
    {
      InitializeComponent();
      PrefixDelimiter = DefaultPrefixDelimiter;
      UseSchema = true;
      UseContext = true;
      CacheDurationInSeconds = DefaultCacheDurationInSeconds;
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="UsrCntrlEntityBrowser" /> class.
    /// </summary>
    /// <param name="linqMetaData">The linq meta data.</param>
    /// <param name="useSchema">if set to <c>true</c> [use schema].</param>
    /// <param name="prefixDelimiter">The prefix delimiter.</param>
    /// <param name="ensureFilteringEnabled">if set to <c>true</c> [ensure filtering enabled].</param>
    /// <param name="useContext">if set to <c>true</c> [use context].</param>
    /// <param name="cacheDurationInSeconds">The cache duration in seconds, 0 means don't cache.</param>
    /// <param name="membersToExclude">The members to exclude.</param>
    public UsrCntrlEntityBrowser(ILinqMetaData linqMetaData, bool useSchema = true, string prefixDelimiter = DefaultPrefixDelimiter,
      bool ensureFilteringEnabled = true, bool useContext = true, int cacheDurationInSeconds = DefaultCacheDurationInSeconds, params string[] membersToExclude)
      : this()
    {
      PrefixDelimiter = prefixDelimiter;
      UseSchema = useSchema;
      UseContext = useContext;
      Initialize(linqMetaData, null, membersToExclude);
      EnsureFilteringEnabled = ensureFilteringEnabled;
      CacheDurationInSeconds = cacheDurationInSeconds;
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
      SetContextToUse();
      _getQueryableForEntityDelegate = getQueryableForEntityDelegate;
      gridDataEditor.MembersToExclude = membersToExclude;
      gridDataEditor.BindingListViewCreater = BindingListViewCreater;
      PopulateTreeViewWithSchema();
    }

    private IBindingListView BindingListViewCreater(IEnumerable enumerable, Type itemType)
    {
      var genericDataScopeBase = DataScope;
      if (genericDataScopeBase != null)
      {
        var queryable = enumerable as IQueryable;
        enumerable =genericDataScopeBase.FetchData(queryable);
      }
      return EntityHelper.CreateEntityView(enumerable, itemType);
    }

    private void PopulateTreeViewWithSchema()
    {
      if (HasLinqMetaData)
      {
        treeViewEntities.Nodes.Clear();
        LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities.Nodes, _linqMetaData, null, UseSchema, PrefixDelimiter);
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
      return _getQueryableForEntityDelegate == null ?
        EntityHelper.GetQueryableForEntityIgnoreIfNull(_linqMetaData, treeViewEntities.SelectedNode.Tag as Type)
        : _getQueryableForEntityDelegate(_linqMetaData, treeViewEntities.SelectedNode.Tag as Type);
    }

    private void ViewEntities(IQueryable entityQueryable)
    {
      if (typeof (IEntity).IsAssignableFrom(entityQueryable.ElementType))
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
    /// Set a Cache on the base query of the gridDataEditor, which means all pageing based off that query will be cached too.
    /// </summary>
    /// <param name="entityQueryable">The entity queryable.</param>
    /// <returns></returns>
    private dynamic CacheResultset(dynamic entityQueryable)
    {
      return CacheDurationInSeconds > 0 ? QueryableExtensionMethods.CacheResultset(entityQueryable, CacheDurationInSeconds,false, Name):entityQueryable;
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
        gridDataEditor.DataEditorPersister.Save();
        gridDataEditor.SaveEdits();
        SetSaveButtons();
      }
    }

    private void toolStripButtonCancelEdit_Click(object sender, EventArgs e)
    {
      if (gridDataEditor.DataEditorPersister != null)
      {
        gridDataEditor.CancelEdits();
        if (gridDataEditor.DataEditorPersister.Undo())
        SetSaveButtons();
      }
    }

    private void SetSaveButtons(bool enabled = false)
    {
      saveToolStripButton.Enabled = enabled;
      toolStripButtonCancelEdit.Enabled = saveToolStripButton.Enabled;
    }

    private void DataEditorEventHandlers_ContainedDataChanged(object sender, EventArgs e)
    {
      SetSaveButtons(true);
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
      CacheDurationInSeconds = (int)cacheDurationInSecondsNumericUpDown.Value;
    }

    private void prefixDelimiterTextBox_Click(object sender, EventArgs e)
    {
      PrefixDelimiter = prefixDelimiterTextBox.Text;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}