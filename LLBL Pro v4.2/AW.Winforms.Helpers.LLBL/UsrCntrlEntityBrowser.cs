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
    private Type BaseType { get; set; }
    private ILinqMetaData _linqMetaData;
    private bool _userHasInteracted;
    private EntityHelper.GetQueryableForEntityDelegate _getQueryableForEntityDelegate;

    public static FrmPersistantLocation ShowDataBrowser(ILinqMetaData linqMetaData, Form parentForm = null,
      bool useSchema = true, string prefixDelimiter = "_", bool ensureFilteringEnabled = true, params string[] membersToExclude)
    {
      return FrmPersistantLocation.ShowControlInForm(new UsrCntrlEntityBrowser(linqMetaData, useSchema, prefixDelimiter, ensureFilteringEnabled, membersToExclude) 
        , "Data Browser", parentForm, "DataBrowser");
    }

    public UsrCntrlEntityBrowser()
    {
      InitializeComponent();
    }

    public UsrCntrlEntityBrowser(Type baseType, bool useSchema = true, string prefixDelimiter = "_")
      : this()
    {
      BaseType = baseType;
      LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities, EntityHelper.GetEntitiesTypes(baseType, _linqMetaData), useSchema, prefixDelimiter);
    }

    public UsrCntrlEntityBrowser(ILinqMetaData linqMetaData, bool useSchema = true, string prefixDelimiter = "_", bool ensureFilteringEnabled = true, params string[] membersToExclude)
      : this()
    {
      Initialize(linqMetaData, null, useSchema, prefixDelimiter, ensureFilteringEnabled, membersToExclude);
    }

    public void Initialize(ILinqMetaData linqMetaData, EntityHelper.GetQueryableForEntityDelegate getQueryableForEntityDelegate=null, bool useSchema = true, string prefixDelimiter = "_", bool ensureFilteringEnabled = true, params string[] membersToExclude)
    {
      _linqMetaData = linqMetaData;
      _getQueryableForEntityDelegate = getQueryableForEntityDelegate;
      gridDataEditor.EnsureFilteringEnabled = ensureFilteringEnabled;
      gridDataEditor.MembersToExclude = membersToExclude;
      LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities.Nodes, linqMetaData, null, useSchema, prefixDelimiter);
    }

    #region Overrides of UserControl

    /// <summary>
    ///   Raises the CreateControl event.
    /// </summary>
    protected override void OnCreateControl()
    {
      if (treeViewEntities.Nodes.Count == 0)
        LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities, EntityHelper.GetEntitiesTypes(BaseType, _linqMetaData));
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
      return _getQueryableForEntityDelegate==null ? 
        EntityHelper.GetQueryableForEntityIgnoreIfNull(_linqMetaData, treeViewEntities.SelectedNode.Tag as Type) 
        : _getQueryableForEntityDelegate(_linqMetaData, treeViewEntities.SelectedNode.Tag as Type);
    }

    private void ViewEntities(IQueryable entityQueryable)
    {
      if (gridDataEditor.DataEditorPersister == null)
        if (typeof (IEntity).IsAssignableFrom(entityQueryable.ElementType))
          gridDataEditor.DataEditorPersister = new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister();
        else
        {
          var provider = entityQueryable.Provider as LLBLGenProProvider2;
          if (provider != null)
            gridDataEditor.DataEditorPersister = new LLBLWinformHelper.DataEditorLLBLAdapterPersister(provider.AdapterToUse);
        }
      gridDataEditor.BindEnumerable(entityQueryable);
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