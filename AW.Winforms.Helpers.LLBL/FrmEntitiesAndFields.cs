using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.EntityViewer;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
  public partial class FrmEntitiesAndFields : FrmThreePanelBase
  {
    private static FrmEntitiesAndFields _formSingleton;
    private readonly Type _baseType;
    private readonly ILinqMetaData _linqMetaData;

    public FrmEntitiesAndFields()
    {
      InitializeComponent();
    }

    public FrmEntitiesAndFields(Type baseType, bool useSchema = true, string prefixDelimiter = null)
      : this()
    {
      _baseType = baseType;
      LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities, EntityHelper.GetEntitiesTypes(_baseType, _linqMetaData), useSchema, prefixDelimiter);
    }

    public FrmEntitiesAndFields(ILinqMetaData linqMetaData, bool useSchema = true, string prefixDelimiter = null)
      : this()
    {
      _linqMetaData = linqMetaData;
      LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities.Nodes, linqMetaData, null, useSchema, prefixDelimiter);
    }

    public static void ShowEntitiesAndFields(Type baseType, Form parent = null, bool useSchema = true, string prefixDelimiter = null)
    {
      if (_formSingleton == null || _formSingleton.contextMenuStrip1.InvokeRequired)
        _formSingleton = new FrmEntitiesAndFields(baseType, useSchema, prefixDelimiter);
      AWHelper.ShowForm(_formSingleton, parent);
    }

    public static void ShowEntitiesAndFields(ILinqMetaData linqMetaData, Form parent = null, bool useSchema = true, string prefixDelimiter = null)
    {
      if (_formSingleton == null || _formSingleton.contextMenuStrip1.InvokeRequired)
        _formSingleton = new FrmEntitiesAndFields(linqMetaData, useSchema, prefixDelimiter);
      AWHelper.ShowForm(_formSingleton, parent);
    }

    #region Overrides of FrmPersistantLocation

    protected override void RestoreWindowSettings()
    {
      if (!DesignMode)
        if (splitContainerVertical.Panel2Collapsed)
          base.RestoreWindowSettings();
        else
        {
          var splitterDistanceBefore = splitContainerVertical.SplitterDistance;
          splitContainerVertical.Panel2Collapsed = true;
          base.RestoreWindowSettings();
          splitContainerVertical.Width = ClientSize.Width;
          if (splitterDistanceBefore != splitContainerVertical.SplitterDistance)
          {
            SetClientSizeCore(splitContainerVertical.SplitterDistance, ClientSize.Height);
            if (splitContainerVertical.Width > splitContainerVertical.SplitterDistance)
              ((Panel) splitContainerVertical.Panel2).Width = splitContainerVertical.Width - splitContainerVertical.SplitterDistance - splitContainerVertical.SplitterWidth;
          }
        }
    }

    #endregion

    #region Overrides of Form

    /// <summary>
    ///   Raises the CreateControl event.
    /// </summary>
    protected override void OnCreateControl()
    {
      gridDataEditor.bindingSourceEnumerable.CurrentChanged += bindingSourceEnumerable_CurrentChanged;
      if (treeViewEntities.Nodes.Count == 0)
        LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities, EntityHelper.GetEntitiesTypes(_baseType, _linqMetaData));
      base.OnCreateControl();
    }

    #endregion

    private void treeViewEntities_ItemDrag(object sender, ItemDragEventArgs e)
    {
      DoDragDrop(((TreeNode) e.Item).Text, DragDropEffects.All);
    }

    private void bindingSourceEnumerable_CurrentChanged(object sender, EventArgs e)
    {
      propertyGrid.SelectedObject = gridDataEditor.bindingSourceEnumerable.Current;
    }

    private void treeViewEntities_AfterSelect(object sender, TreeViewEventArgs e)
    {
      propertyGrid.SelectedObject = treeViewEntities.SelectedNode.Tag;
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
      }
      else if (!splitContainerVertical.Panel2Collapsed)
      {
        openPagedToolStripMenuItem_Click(sender, e);
      }
      toolStripStatusLabelSelected.Text = treeViewEntities.SelectedNode.Text;
    }

    private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
    {
      Open(0);
    }

    private void Open(ushort pageSize)
    {
      var entityQueryable = GetEntityQueryable();
      if (entityQueryable != null)
        ViewEntities(entityQueryable, pageSize);
    }

    private IQueryable GetEntityQueryable()
    {
      return EntityHelper.GetQueryableForEntityIgnoreIfNull(_linqMetaData, treeViewEntities.SelectedNode.Tag as Type);
    }

    private void ViewEntities(IQueryable entityQueryable, ushort pageSize)
    {
      if (splitContainerVertical.Panel2Collapsed)
        ExpandRightPanel();
      if (gridDataEditor.DataEditorPersister == null)
        if (typeof (IEntity).IsAssignableFrom(entityQueryable.ElementType))
          gridDataEditor.DataEditorPersister = new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister();
        else
        {
          var provider = entityQueryable.Provider as LLBLGenProProvider2;
          if (provider != null)
            gridDataEditor.DataEditorPersister = new LLBLWinformHelper.DataEditorLLBLAdapterPersister(provider.AdapterToUse);
        }
      gridDataEditor.BindEnumerable(entityQueryable, pageSize);
    }

    private void openPagedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Open(GridDataEditor.DefaultPageSize);
    }

    private void getCountToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var entityQueryable = GetEntityQueryable();
      if (entityQueryable != null)
        toolStripStatusLabelSelected.Text = entityQueryable.Count().ToString(CultureInfo.InvariantCulture);
    }

    private void treeViewEntities_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      if (!e.Node.IsExpanded)
        openPagedToolStripMenuItem_Click(sender, e);
    }

    private void treeViewEntities_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      if (e.Button == MouseButtons.Right && e.Node.Tag != null)
      {
        treeViewEntities.SelectedNode = e.Node;
        contextMenuStrip1.Show(treeViewEntities, e.Location);
      }
    }

    private void viewInPropertyGridToolStripMenuItem_Click(object sender, EventArgs e)
    {
      propertyGrid.SelectedObject = treeViewEntities.SelectedNode.Tag;
      if (splitContainerVertical.Panel2Collapsed)
        ExpandRightPanel();
    }

    private void viewToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var entityQueryable = GetEntityQueryable();
      if (entityQueryable != null)
      {
        propertyGrid.SelectedObject = entityQueryable;
        if (splitContainerVertical.Panel2Collapsed)
          ExpandRightPanel();
      }
    }

    private void viewFieldsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var typeOfEntity = treeViewEntities.SelectedNode.Tag as Type;
      var fields = EntityHelper.CreateEntity(typeOfEntity).Fields;
      propertyGrid.SelectedObject = fields;
      gridDataEditor.BindEnumerable(fields);
      if (splitContainerVertical.Panel2Collapsed)
        ExpandRightPanel();
    }

    private void viewPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var typeOfEntity = treeViewEntities.SelectedNode.Tag as Type;
      if (typeOfEntity != null)
      {
        var properties = typeOfEntity.GetProperties();
        propertyGrid.SelectedObject = properties;
        gridDataEditor.BindEnumerable(properties);
      }
      if (splitContainerVertical.Panel2Collapsed)
        ExpandRightPanel();
    }

    private void viewPropertyDescriptorsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var typeOfEntity = treeViewEntities.SelectedNode.Tag as Type;
      if (typeOfEntity != null)
      {
        var properties = MetaDataHelper.GetPropertyDescriptors(typeOfEntity);
        propertyGrid.SelectedObject = properties;
        gridDataEditor.BindEnumerable(properties);
      }
      if (splitContainerVertical.Panel2Collapsed)
        ExpandRightPanel();
    }

    private void viewAttributesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var typeOfEntity = treeViewEntities.SelectedNode.Tag as Type;
      if (typeOfEntity != null)
      {
        var properties = MetaDataHelper.GetPropertyDescriptors(typeOfEntity);
        var attributes = properties.SelectMany(prop => prop.Attributes.Cast<Attribute>());
        propertyGrid.SelectedObject = attributes;
        gridDataEditor.BindEnumerable(attributes);
      }
      if (splitContainerVertical.Panel2Collapsed)
        ExpandRightPanel();
    }

    private void viewInObjectBrowserToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var entityQueryable = GetEntityQueryable();
      if (entityQueryable != null)
      {
        FrmEntityViewer.LaunchAsChildForm(entityQueryable, gridDataEditor.DataEditorPersister);
      }
    }

    private void treeViewEntities_AfterExpand(object sender, TreeViewEventArgs e)
    {
      AWHelper.ResizeToFitNodes(treeViewEntities);
    }

    private void FrmEntitiesAndFields_Load(object sender, EventArgs e)
    {
      AWHelper.ResizeToFitNodes(treeViewEntities);
    }
  }
}