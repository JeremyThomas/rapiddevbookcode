using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Helper.LLBL;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public partial class UsrCntrlEntityBrowser : UserControl
  {
    public const int DefaultCacheDurationInSeconds = 20;

    public bool UseContext
    {
      get { return ContextToUse != null; }
      private set
      {
        if (value)
        {
          if (!UseContext)
            ContextToUse = new Context();
        }
      }
    }

    private dynamic ContextToUse
    {
      get { return _linqMetaData != null && ((dynamic) _linqMetaData).ContextToUse; }
      set { if (_linqMetaData != null) ((dynamic) _linqMetaData).ContextToUse = value; }
    }

    public int CacheDurationInSeconds { get; private set; }
    private readonly Type _baseType;
    private ILinqMetaData _linqMetaData;
    private bool _userHasInteracted;
    private EntityHelper.GetQueryableForEntityDelegate _getQueryableForEntityDelegate;

    public static FrmPersistantLocation ShowDataBrowser(ILinqMetaData linqMetaData, Form parentForm = null,
      bool useSchema = true, string prefixDelimiter = "_", bool ensureFilteringEnabled = true, bool useContext = true, int cacheDurationInSeconds = DefaultCacheDurationInSeconds,
      params string[] membersToExclude)
    {
      return FrmPersistantLocation.ShowControlInForm(new UsrCntrlEntityBrowser(linqMetaData, useSchema, prefixDelimiter,
        ensureFilteringEnabled, useContext, cacheDurationInSeconds, membersToExclude)
        , "Data Browser", parentForm, "DataBrowser");
    }

    public UsrCntrlEntityBrowser()
    {
      InitializeComponent();
    }

    public UsrCntrlEntityBrowser(Type baseType, bool useSchema = true, string prefixDelimiter = "_")
      : this()
    {
      _baseType = baseType;
      LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities, EntityHelper.GetEntitiesTypes(baseType, _linqMetaData), useSchema, prefixDelimiter);
    }

    public UsrCntrlEntityBrowser(ILinqMetaData linqMetaData, bool useSchema = true, string prefixDelimiter = "_",
      bool ensureFilteringEnabled = true, bool useContext = true, int cacheDurationInSeconds = DefaultCacheDurationInSeconds, params string[] membersToExclude)
      : this()
    {
      Initialize(linqMetaData, null, useSchema, prefixDelimiter, ensureFilteringEnabled, useContext, cacheDurationInSeconds, membersToExclude);
    }

    /// <summary>
    /// Initializes the specified linq meta data.
    /// </summary>
    /// <param name="linqMetaData">The linq meta data.</param>
    /// <param name="getQueryableForEntityDelegate">The get queryable for entity delegate.</param>
    /// <param name="useSchema">if set to <c>true</c> [use schema].</param>
    /// <param name="prefixDelimiter">The prefix delimiter.</param>
    /// <param name="ensureFilteringEnabled">if set to <c>true</c> [ensure filtering enabled].</param>
    /// <param name="useContext">if set to <c>true</c> [use context].</param>
    /// <param name="cacheDurationInSeconds">The cache duration in seconds, 0 means don't cache.</param>
    /// <param name="membersToExclude">The members to exclude.</param>
    public void Initialize(ILinqMetaData linqMetaData, EntityHelper.GetQueryableForEntityDelegate getQueryableForEntityDelegate = null,
      bool useSchema = true, string prefixDelimiter = "_", bool ensureFilteringEnabled = true,
      bool useContext = true, int cacheDurationInSeconds = DefaultCacheDurationInSeconds, params string[] membersToExclude)
    {
      _linqMetaData = linqMetaData;
      _getQueryableForEntityDelegate = getQueryableForEntityDelegate;
      EnsureFilteringEnabled = ensureFilteringEnabled;
      UseContext = useContext;
      CacheDurationInSeconds = cacheDurationInSeconds;
      gridDataEditor.MembersToExclude = membersToExclude;
      LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities.Nodes, linqMetaData, null, useSchema, prefixDelimiter);
    }

    public bool EnsureFilteringEnabled
    {
      get { return gridDataEditor.EnsureFilteringEnabled; }
      set { gridDataEditor.EnsureFilteringEnabled = value; }
    }

    #region Overrides of UserControl

    /// <summary>
    ///   Raises the CreateControl event.
    /// </summary>
    protected override void OnCreateControl()
    {
      if (treeViewEntities.Nodes.Count == 0)
        LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities, EntityHelper.GetEntitiesTypes(_baseType, _linqMetaData));
      base.OnCreateControl();
    }

    #endregion

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
      //  MaybeViewEntities(entityQueryable);
      else
      {
        var provider = entityQueryable.Provider as LLBLGenProProvider2;
        if (provider != null && gridDataEditor.DataEditorPersister == null)
          gridDataEditor.DataEditorPersister = new LLBLWinformHelper.DataEditorLLBLAdapterPersister(provider.AdapterToUse);
      }
      gridDataEditor.BindEnumerable(CacheResultset(entityQueryable));
    }

    private dynamic CacheResultset(dynamic entityQueryable)
    {
      return CacheDurationInSeconds>0 ? QueryableExtensionMethods.CacheResultset(entityQueryable, CacheDurationInSeconds) : entityQueryable;
    }

    private void MaybeBindAdapterCached(dynamic entityQueryable)
    {
      BindAdapterCached(entityQueryable);
    }

    private void MaybeBindSelfServicingCached(dynamic entityQueryable)
    {
      BindSelfServicingCached(entityQueryable);
    }

    private void BindSelfServicingCached<T>(IQueryable<T> entityQueryable) where T : class, IEntityCore
    {
      var queryableCached = entityQueryable.CacheResultset(DefaultCacheDurationInSeconds);
      gridDataEditor.BindEnumerable(queryableCached);
    }

    private void BindAdapterCached<T>(IQueryable<T> entityQueryable) where T : EntityBase2
    {
      var queryableCached = entityQueryable.CacheResultset(DefaultCacheDurationInSeconds);
      gridDataEditor.BindEnumerable(queryableCached);
    }

    private void MaybeViewEntities(dynamic entityQueryable)
    {
      ViewSelfServicingEntities(entityQueryable);
    }

    private void ViewSelfServicingEntities<T>(IQueryable<T> entityQueryable) where T : EntityBase
    {
      var queryableCached = entityQueryable.CacheResultset(10);
      var dataScope = new SelfServicingGenericDataScope<T>(queryableCached);
      dataScope.FetchData();
      gridDataEditor.DataEditorPersister = new DataEditorLLBLSelfServicingDataScopePersister<T>(dataScope);
      gridDataEditor.BindEnumerable(dataScope.EntityCollection);
    }

    private void ViewAdapterEntities<T>(IQueryable<T> entityQueryable) where T : EntityBase2
    {
      var queryableCached = entityQueryable.CacheResultset(10);
      var dataScope = new AdapterGenericDataScope<T>(queryableCached);
      dataScope.FetchData();
      gridDataEditor.DataEditorPersister = new DataEditorLLBLAdapterDataScopePersister<T>(dataScope);
      gridDataEditor.BindEnumerable(dataScope.EntityCollection);
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
  }
}