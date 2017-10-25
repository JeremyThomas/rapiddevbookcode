using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Forms;
using AW.Helper;

namespace AW.Winforms.Helpers.Controls
{
  public partial class HierarchyEditor : UserControl, ISupportInitialize
  {
    private readonly bool _canDetectDirty;
    private bool _dontResize;

// ReSharper disable once MemberCanBePrivate.Global
    public HierarchyEditor()
    {
      InitializeComponent();
    }

    public HierarchyEditor(IEnumerable hierarchicalData, string nameColumn)
      : this()
    {
      if (hierarchicalData == null) throw new ArgumentNullException("hierarchicalData");
      bindingSourceHierarchicalData.BindEnumerable(hierarchicalData, false); //See http://blog.stephencleary.com/2013/01/async-oop-2-constructors.html
      bindingNavigatorDeleteItem.Enabled = bindingSourceHierarchicalData.AllowRemove;
      dataTreeView.NameColumn = nameColumn;
      dataTreeView.Sorted = true;
      bindingNavigatorAddNewItem.Enabled = dataTreeView.CanEdit;
      dataTreeView.LabelEdit = dataTreeView.CanEdit;
    }

    public HierarchyEditor(IEnumerable hierarchicalData, string nameColumn, IDataEditorPersister dataEditorPersister = null, params string[] membersToExclude)
      : this(hierarchicalData, nameColumn)
    {
      gridDataEditor.DataEditorPersister = dataEditorPersister;
      var dataEditorEventHandlers = dataEditorPersister as IDataEditorEventHandlers;
      if (dataEditorEventHandlers != null)
      {
        dataEditorEventHandlers.ContainedDataChanged += DataEditorEventHandlers_ContainedDataChanged;
        dataEditorEventHandlers.EntityAdded += DataEditorEventHandlers_ContainedDataChanged;
        _canDetectDirty = true;
      }
      else
        saveToolStripButton.Enabled = gridDataEditor.DataEditorPersister != null;
      gridDataEditor.MembersToExclude = membersToExclude;
      toolStripButtonCancelEdit.Enabled = saveToolStripButton.Enabled;
    }

    public HierarchyEditor(IEnumerable hierarchicalData, string iDPropertyName, string parentIDPropertyName, string nameColumn, IDataEditorPersister dataEditorPersister, params string[] membersToExclude)
      : this(hierarchicalData, nameColumn, dataEditorPersister, membersToExclude)
    {
      dataTreeView.IDColumn = iDPropertyName;
      dataTreeView.ParentIDColumn = parentIDPropertyName;
    }

    public HierarchyEditor(IEnumerable hierarchicalData, string nameColumn, string childCollectionPropertyName, IDataEditorPersister dataEditorPersister = null, params string[] membersToExclude)
      : this(hierarchicalData, nameColumn, dataEditorPersister, membersToExclude)
    {
      dataTreeView.ChildCollectionPropertyName = childCollectionPropertyName;
    }

    /// <summary>
    ///   HierarchyEditor constructor, needs to be a static method because of the generic paramaters
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TId">The type of the identifier.</typeparam>
    /// <typeparam name="TParentId">The type of the parent identifier.</typeparam>
    /// <typeparam name="TName">The type of the name.</typeparam>
    /// <param name="enumerable">The enumerable.</param>
    /// <param name="iDPropertyExpression">The ID property expression.</param>
    /// <param name="parentIDPropertyExpression">The parent identifier property expression.</param>
    /// <param name="namePropertyExpression">The name property expression.</param>
    /// <param name="dataEditorPersister">The data editor persister.</param>
    /// <param name="membersToExclude">The members to exclude.</param>
    /// <returns></returns>
    public static HierarchyEditor HierarchyEditorFactory<T, TId, TParentId, TName>(IEnumerable<T> enumerable, Expression<Func<T, TId>> iDPropertyExpression,
      Expression<Func<T, TParentId>> parentIDPropertyExpression, Expression<Func<T, TName>> namePropertyExpression,
      IDataEditorPersister dataEditorPersister, params string[] membersToExclude)
    {
      return new HierarchyEditor(enumerable, MemberName.For(iDPropertyExpression), MemberName.For(parentIDPropertyExpression), MemberName.For(namePropertyExpression), dataEditorPersister, membersToExclude);
    }

    public static HierarchyEditor HierarchyEditorFactory<T, TI, TName, TChildCollection>(IEnumerable<T> enumerable, Func<T, TI> iDFunc, Func<T, bool> isChildFunc, Func<T, TI> parentIDFunc, Action<T, T> assignToParentFunc,
      Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression, IDataEditorPersister dataEditorPersister, params string[] membersToExclude)
    {
      var topMostEntities = GeneralHelper.WireUpSelfJoinAndRemoveChildren(enumerable, iDFunc, isChildFunc, parentIDFunc, assignToParentFunc);
      return HierarchyEditorFactory(topMostEntities, namePropertyExpression, childCollectionPropertyExpression, dataEditorPersister, membersToExclude);
    }

    public static HierarchyEditor HierarchyEditorFactory<T, TName, TChildCollection>(IEnumerable<T> enumerable, Expression<Func<T, TName>> namePropertyExpression,
      Expression<Func<T, TChildCollection>> childCollectionPropertyExpression, IDataEditorPersister dataEditorPersister, params string[] membersToExclude)
    {
      return new HierarchyEditor(enumerable, MemberName.For(namePropertyExpression), MemberName.For(childCollectionPropertyExpression), dataEditorPersister, membersToExclude);
    }

    private void HierarchyEditor_Load(object sender, EventArgs e)
    {
      ExpandIfSingleTopNode();
    }

    bool _fullyPainted;

    /// <summary>
    /// http://stackoverflow.com/questions/7309736/which-event-is-launched-right-after-control-is-fully-loaded
    /// </summary>
    /// <param name="m">The m.</param>
    protected override void WndProc(ref Message m)
    {
      base.WndProc(ref m);
      if (m.Msg == 15 && !_fullyPainted)
      {
        _fullyPainted = true;
        ResizeToFitNodes();
      }
    }

    private async void dataTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      var selectedNode = (dataTreeView).SelectedNode;
      if (selectedNode != null) toolStripStatusLabelSelectePath.Text = selectedNode.FullPath;
      propertyGrid1.SelectedObject = e.Node.Tag;
      splitContainerHorizontal.Panel2Collapsed = e.Node.Nodes.Count == 0;
      if (splitContainerHorizontal.Panel2Collapsed)
        gridDataEditor.DataSource = null;
      else
      {
        splitContainerHorizontal.Panel1Collapsed = ListBindingHelper.GetListItemProperties(propertyGrid1.SelectedObject.GetType()).Count < 2;
        gridDataEditor.BindEnumerable(await dataTreeView.GetChildEnumerableAsync(e));
      }
      ExpandIfSingleTopNode(selectedNode);
    }

    private static void ExpandIfSingleTopNode(TreeNode node)
    {
      if (node != null && (node.Level == 0 && node.TreeView.Nodes.Count == 1))
        node.Expand();
    }

    private void ExpandIfSingleTopNode()
    {
      if (dataTreeView.Nodes.Count == 1)
        dataTreeView.TopNode.Expand();
    }

    public void ResizeToFitNodes()
    {
      AWHelper.ResizeToFitNodes(dataTreeView);
    }

    private void toolStripButtonUnSelectNodes_Click(object sender, EventArgs e)
    {
      dataTreeView.SelectedNode = null;
      toolStripStatusLabelSelectePath.Text = "";
      propertyGrid1.SelectedObject = null;
      splitContainerHorizontal.Panel2Collapsed = bindingSourceHierarchicalData.Count == 0;
      if (splitContainerHorizontal.Panel2Collapsed)
        gridDataEditor.DataSource = null;
      else
      {
        splitContainerHorizontal.Panel1Collapsed = true;
        gridDataEditor.BindEnumerable(bindingSourceHierarchicalData);
      }
    }

    private void toolStripButtonExpandAll_Click(object sender, EventArgs e)
    {
      try
      {
        _dontResize = true;
        dataTreeView.ExpandAll();
      }
      finally
      {
        _dontResize = false;
        AWHelper.ResizeToFitNodes(dataTreeView);
      }
    }

    private void toolStripButtonCollapseAll_Click(object sender, EventArgs e)
    {
      try
      {
        _dontResize = true;
        dataTreeView.CollapseAll();
        ExpandIfSingleTopNode();
      }
      finally
      {
        _dontResize = false;
        AWHelper.ResizeToFitNodes(dataTreeView);
      }
    }

    private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
    {
      dataTreeView.AddNodeAndData();
    }

    private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
    {
      dataTreeView.RemoveSelectedNode();
    }

    private void dataTreeView_AfterExpand(object sender, TreeViewEventArgs e)
    {
      if (!_dontResize)
        AWHelper.ResizeToFitNodes(e);
    }

    private void DataEditorEventHandlers_ContainedDataChanged(object sender, EventArgs e)
    {
      saveToolStripButton.Enabled = true;
      toolStripButtonCancelEdit.Enabled = saveToolStripButton.Enabled;
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
      bindingSourceHierarchicalData.CancelEdit();
      if (gridDataEditor.DataEditorPersister != null && gridDataEditor.DataEditorPersister.Undo())
      {
        gridDataEditor.CancelEdits();
        SetSaveButtons();
      }
    }

    private void SetSaveButtons()
    {
      saveToolStripButton.Enabled = !_canDetectDirty;
      toolStripButtonCancelEdit.Enabled = saveToolStripButton.Enabled;
    }

    public void BeginInit()
    {
      ((ISupportInitialize) (bindingSourceHierarchicalData)).BeginInit();
      ((ISupportInitialize) (bindingNavigatorHierarchicalData)).BeginInit();
      ((ISupportInitialize) (gridDataEditor)).BeginInit();
      ((ISupportInitialize) (dataTreeView)).BeginInit();
    }

    public void EndInit()
    {
      ((ISupportInitialize) (bindingSourceHierarchicalData)).EndInit();
      ((ISupportInitialize) (bindingNavigatorHierarchicalData)).EndInit();
      ((ISupportInitialize) (dataTreeView)).EndInit();
      ((ISupportInitialize) (gridDataEditor)).EndInit();
    }


  }
}