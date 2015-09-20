using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.EntityViewer;

namespace Chaliy.Windows.Forms
{
  /// <summary>
  ///   Data binding enabled hierarchical tree view control.
  /// </summary>
  /// <remarks>
  ///   created:	2005/03/27
  ///   created:	27:3:2005   7:05
  ///   filename: 	DataTreeView.cs
  ///   author:		Mike Chaliy
  ///   url: http://www.codeproject.com/KB/tree/bindablehierarchicaltree.aspx
  ///   purpose:	Data binding enabled hierarchical tree view control.
  ///   Modifications by Jeremy Thomas: Added Drag-drop, adding and deleting, Removed internal lists,
  ///   uses DataMemberListEditor and DataMemberFieldEditor
  /// </remarks>
  [ComplexBindingProperties("DataSource", "DataMember")]
  public class DataTreeView : TreeView, ISupportInitialize
  {
    private const int SbHorz = 0;

    #region Fields

    private object _dataSource;
    private string _dataMember;
    private bool _initializing;
    private CurrencyManager _listManager;

    private string _idPropertyName;
    private string _namePropertyName;
    private string _parentIdPropertyName;
    private string _childCollectionPropertyName;
    /*
        private string valuePropertyName;
    */
    private readonly Char[] _dataMemberFieldSeparator = {'.'};

    private PropertyDescriptor _idProperty;
    private PropertyDescriptor _nameProperty;
    private PropertyDescriptor _childNameProperty;
    private PropertyDescriptor _parentIdProperty;
    private PropertyDescriptor _childCollectionProperty;

    private FieldsToPropertiesTypeDescriptionProvider _fieldsToPropertiesTypeDescriptionProvider;

    private TypeConverter _valueConverter;

    private bool _selectionChanging;

    #endregion

    #region Constructors

    /// <summary>
    ///   Default constructor.
    /// </summary>
    public DataTreeView()
    {
      InitializeComponent();
      _idPropertyName = string.Empty;
      _namePropertyName = string.Empty;
      _parentIdPropertyName = string.Empty;
      _selectionChanging = false;
      BindingContextChanged += DataTreeView_BindingContextChanged;
      FullRowSelect = true;
      HideSelection = false;
      HotTracking = true;
      AfterSelect += DataTreeView_AfterSelect;
      AfterLabelEdit += DataTreeView_AfterLabelEdit;
      DragDrop += DataTreeView_DragDrop;
      DragOver += DataTreeView_DragOver;
      ItemDrag += DataTreeView_ItemDrag;
      _bindingLists = new Dictionary<object, IBindingList>();
    }

    private void InitializeComponent()
    {
      SuspendLayout();
      // 
      // DataTreeView
      // 
      BindingContextChanged += DataTreeView_BindingContextChanged;
      ResumeLayout(false);
    }

    /// <summary>
    ///   Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (_fieldsToPropertiesTypeDescriptionProvider != null && _idProperty != null)
        {
          TypeDescriptor.RemoveProvider(_fieldsToPropertiesTypeDescriptionProvider, _idProperty.ComponentType);
          _fieldsToPropertiesTypeDescriptionProvider = null;
        }
        foreach (var bindingList in _bindingLists.Values)
          bindingList.ListChanged -= DataTreeView_ChildListChanged;
      }
      catch (Exception e)
      {
        e.TraceOut();
      }

      base.Dispose(disposing);
    }

    #endregion

    #region Win32

    [DllImport("User32.dll")]
    private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

    #endregion

    #region Properties

    [AttributeProvider(typeof (IListSource)),
     Category("Data"),
     Description("Data source of the tree.")]
    public object DataSource
    {
      get { return _dataSource; }
      set
      {
        if (_dataSource != value)
        {
          _dataSource = value;
          ResetData();
        }
      }
    }

    [Editor("System.Windows.Forms.Design.DataMemberListEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor)),
     RefreshProperties(RefreshProperties.Repaint),
     Category("Data"),
     Description("Data member of the tree.")]
    public string DataMember
    {
      get { return _dataMember; }
      set
      {
        if (_dataMember != value)
        {
          _dataMember = value;
          ResetData();
        }
      }
    }

    private void SetProperty(ref PropertyDescriptor property, ref string propertyName, string value)
    {
      if (propertyName != value)
        if (value == null)
        {
          DataMember = string.Empty;
          propertyName = string.Empty;
        }
        else
        {
          var split = value.Split(_dataMemberFieldSeparator);
          string temp;
          if (split.Length > 1)
          {
            DataMember = split[0];
            temp = split[1];
          }
          else
          {
            DataMember = string.Empty;
            temp = value;
          }
          propertyName = null;
          if (DataSource != null && temp != string.Empty)
          {
            var propertyDescriptorCollection = ListBindingHelper.GetListItemProperties(DataSource, DataMember, null);
            if (propertyDescriptorCollection != null)
            {
              if (propertyDescriptorCollection.Count == 0)
                propertyName = value;
              else
              {
                property = propertyDescriptorCollection.Find(temp, true);
                if (property == null && _fieldsToPropertiesTypeDescriptionProvider == null)
                {
                  _fieldsToPropertiesTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(propertyDescriptorCollection[0].ComponentType, BindingFlags.Instance | BindingFlags.Public);
                  TypeDescriptor.AddProvider(_fieldsToPropertiesTypeDescriptionProvider, propertyDescriptorCollection[0].ComponentType);
                  propertyDescriptorCollection = ListBindingHelper.GetListItemProperties(DataSource, DataMember, null);
                  property = propertyDescriptorCollection.Find(temp, true);
                }
              }
            }
          }
          propertyName = value;
        }
      //   this.ResetData();
    }

    /// <summary>
    ///   Identifier member, in most cases this is primary column of the table.
    /// </summary>
    [
      DefaultValue(""),
      Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor)),
      Category("Data"),
      Description("Identifier member, in most cases this is primary column of the table.")
    ]
    public string IDColumn
    {
      get { return _idPropertyName; }
      set { SetProperty(ref _idProperty, ref _idPropertyName, value); }
    }

    /// <summary>
    ///   Name member. Note: editing of this column available only with types that support converting from string.
    /// </summary>
    [
      DefaultValue(""),
      Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor)),
      Category("Data"),
      Description("Name member. Note: editing of this column available only with types that support converting from string.")
    ]
    public string NameColumn
    {
      get { return _namePropertyName; }
      set { SetProperty(ref _nameProperty, ref _namePropertyName, value); }
    }

    /// <summary>
    ///   Identifier of the parent. Note: this member must have the same type as identifier column.
    /// </summary>
    [
      DefaultValue(""),
      Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor)),
      Category("Data"),
      Description("Identifier of the parent. Note: this member must have the same type as identifier column.")
    ]
    public string ParentIDColumn
    {
      get { return _parentIdPropertyName; }
      set { SetProperty(ref _parentIdProperty, ref _parentIdPropertyName, value); }
    }

    /// <summary>
    ///   Identifier of the parent. Note: this member must have the same type as identifier column.
    /// </summary>
    [
      DefaultValue(""),
      Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor)),
      Category("Data"),
      Description("ChildCollectionPropertName")
    ]
    public string ChildCollectionPropertyName
    {
      get { return _childCollectionPropertyName; }
      set { SetProperty(ref _childCollectionProperty, ref _childCollectionPropertyName, value); }
    }

    [
      //DefaultValue(true),
      Category("Behavior"),
      Description("Still try and display even if there are errors in the data")
    ]
    public bool IgnoreErrors { get; set; }

    #endregion

    #region Events

    private void MoveToItem(object itemToSelect)
    {
      if (itemToSelect != null && _listManager != null)
        _listManager.Position = IndexOf(itemToSelect);
    }

    private int IndexOf(object itemToSelect)
    {
      return _listManager.List.IndexOf(itemToSelect);
    }

    private void DataTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (!_selectionChanging)
      {
        BeginSelectionChanging();
        try
        {
          if (e.Node != null)
            MoveToItem(e.Node.Tag);
        }
        finally
        {
          EndSelectionChanging();
        }
      }
    }

    private void DataTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
      if (e.Node != null && e.Label != null)
        if (CanEdit && _valueConverter.IsValid(e.Label))
        {
          _nameProperty.SetValue(e.Node.Tag, _valueConverter.ConvertFromString(e.Label));
          _listManager.EndCurrentEdit();
          return;
        }
      e.CancelEdit = true;
    }

    public bool CanEdit
    {
      get { return PrepareValueConvertor() && !_nameProperty.IsReadOnly; }
    }

    private void DataTreeView_ItemDrag(object sender, ItemDragEventArgs e)
    {
      DoDragDrop(e.Item, DragDropEffects.Copy | DragDropEffects.Move); //Begin the drag-drop operation
    }

    private static void DataTreeView_DragOver(object sender, DragEventArgs e)
    {
      var tv = (TreeView) sender;
      var position = tv.PointToClient(new Point(e.X, e.Y)); //Get the co-ordinates of the mouse
      var destinationNode = tv.GetNodeAt(position); //Get the node at the current mouse position

      tv.SelectedNode = destinationNode; //Highlight the node in relations to the mouse position
      e.Effect = DragDropEffects.Move;
    }

    private void DataTreeView_DragDrop(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(typeof (TreeNode))) //Continue only if the item being dragged is a TreeNode object
      {
        var tv = (TreeView) sender;
        var position = tv.PointToClient(new Point(e.X, e.Y)); //Get the mouse co-ordinates
        var dropNode = tv.GetNodeAt(position); //Used to hold a reference to the destination node (where the dragged node is released)
        var dragNode = (TreeNode) e.Data.GetData(typeof (TreeNode)); //Used to hold a reference to the node that is being dragged
        if ((dropNode != null && dragNode != null) && (dropNode != dragNode)) //Continue only if we have both node references and that they are not the same reference
        {
          ChangeParent(dragNode, dropNode);
          dropNode.ExpandAll(); //Expand all the child nodes for the users sake 
        }
      }
    }

    private void BindingSourceOnBindingComplete(object sender, BindingCompleteEventArgs bindingCompleteEventArgs)
    {
      ResetData();
    }

    private void DataTreeView_BindingContextChanged(object sender, EventArgs e)
    {
      if (Visible)
        ResetIfEmpty();
    }

    private void ListManagerPositionChanged(object sender, EventArgs e)
    {
      if (PropertyAreSet())
        SynchronizeSelection();
      else
        ResetData();
    }

    private bool _handelingItemChanged;
    private bool _isSelfCollection;
    private bool _reseting;
    private bool _changingParent;
    private IBindingList _bindingList;
    private readonly Dictionary<object, IBindingList> _bindingLists;

    private void DataTreeView_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (PropertyAreSet())
        switch (e.ListChangedType)
        {
          case ListChangedType.ItemAdded:
            try
            {
              if (!IsIDNull(GetCurrentID(e.NewIndex)))
                if (TryAddNode(CreateNode(e.NewIndex)))
                  Trace.Write(e);
            }
            catch (ArgumentException ae)
            {
              Trace.Write(ae);
            }
            break;

          case ListChangedType.ItemChanged:
            if (!_handelingItemChanged)
              try
              {
                _handelingItemChanged = true;
                var changedNode = GetDataAsNode(e.NewIndex);
                if (changedNode != null)
                  RefreshData(changedNode, e.NewIndex);
                else if (IsIDNull(GetCurrentID(e.NewIndex)))
                  throw new ApplicationException("Item not found or wrong type.");
                else if (TryAddNode(CreateNode(e.NewIndex)))
                  ResetData();
                else
                  throw new ApplicationException("Item not found or wrong type.");
              }
              finally
              {
                _handelingItemChanged = false;
              }
            break;

          case ListChangedType.ItemDeleted:
            if (SelectedNode != null && ((IndexOf(SelectedNode.Tag) == -1)
                                         || IndexOf(SelectedNode.Tag) == e.NewIndex))
            {
              SelectedNode.Remove();
              RefreshAllData(e.NewIndex);
            }
            else
            {
              foreach (var node in Nodes.OfType<TreeNode>().Where(node => IndexOf(node.Tag) == -1))
              {
                node.Remove();
              }
            }
            break;

          case ListChangedType.Reset:
            ResetIfEmpty();
            break;

          case ListChangedType.ItemMoved:
            break;
        }
      else
        ResetIfEmpty();
    }

    private void DataTreeView_ChildListChanged(object sender, ListChangedEventArgs e)
    {
      var bindingList = sender as IBindingList;
      if (bindingList != null && !_changingParent)
        switch (e.ListChangedType)
        {
          case ListChangedType.ItemAdded:
            try
            {
              var dataObject = bindingList[e.NewIndex];
              var changedNode = GetDataAsNode(dataObject);
              if (changedNode == null && TryAddNode(CreateNode(dataObject)))
                Trace.Write(e);
            }
            catch (ArgumentException ae)
            {
              Trace.Write(ae);
            }
            break;

          case ListChangedType.ItemChanged:
            if (!_handelingItemChanged)
              try
              {
                _handelingItemChanged = true;
                var dataObject = bindingList[e.NewIndex];
                TreeNode changedNode;
                if (SelectedNode != null && SelectedNode.Tag == dataObject)
                  changedNode = SelectedNode;
                else
                {
                  changedNode = GetDataAsNode(dataObject);
                  if (changedNode == null && SelectedNode != null)
                    changedNode = SelectedNode.Nodes.AsEnumerable().FirstOrDefault(tn => tn.Tag == dataObject);
                }
                if (changedNode == null)
                  if (TryAddNode(CreateNode(dataObject)))
                    ResetData();
                  else
                    throw new ApplicationException("Item not found or wrong type.");
                else
                  RefreshData(changedNode, dataObject);
              }
              finally
              {
                _handelingItemChanged = false;
              }
            break;

          case ListChangedType.ItemDeleted:
            if (!_handelingItemChanged)
              try
              {
                _handelingItemChanged = true;
                if (SelectedNode != null && SelectedNode.Nodes.Count > e.NewIndex)
                {
                  foreach (TreeNode node in SelectedNode.Nodes)
                  {
                    if (node != null && !bindingList.Contains(node.Tag))
                    {
                      var children = Children(node.Tag);
                      if (children == null)
                        foreach (var childTag in DescendantTags(node).Where(childTag => _listManager.List != null && _listManager.List.Contains(childTag)))
                          _listManager.List.Remove(childTag);
                      //else
                      //{
                      //  var bindingListView = children.ToBindingListView();
                      //  while (bindingListView.Count > 0)
                      //    bindingListView.Remove(bindingListView[0]);
                      //}
                      node.Remove();
                    }
                  }
                }
              }
              finally
              {
                _handelingItemChanged = false;
              }
            break;

          case ListChangedType.Reset:
            if (SelectedNode != null)
              if (SelectedNode.Nodes.Count == 0 //|| SelectedNode.Nodes.Count != bindingList.Count
                )
                ResetData();
            break;

          case ListChangedType.ItemMoved:
            break;
        }
      else
        ResetIfEmpty();
    }

    private void ResetIfEmpty()
    {
      if (Nodes.Count == 0)
        ResetData();
    }

    #endregion

    #region Implementation

    private void Clear()
    {
      Nodes.Clear();
    }

    private bool PrepareDataSource()
    {
      if (BindingContext != null)
        if (_dataSource != null)
        {
          var bindingManagerBase = BindingContext[_dataSource, _dataMember];
          _listManager = bindingManagerBase as CurrencyManager;
          if (_listManager == null)
          {
            var propertyManager = bindingManagerBase as PropertyManager;
            if (propertyManager != null)
            {
              var list = ListBindingHelper.GetList(_dataSource, _dataMember);
              var enumerable = propertyManager.Current as IEnumerable;
              _dataSource = enumerable.ToBindingListView();
              _listManager = BindingContext[_dataSource, _dataMember] as CurrencyManager;
            }
          }
          return _listManager != null && !_listManager.IsBindingSuspended;
        }
        else
        {
          _listManager = null;
          Clear();
        }
      return false;
    }

    #region Descriptors

    private bool PropertyAreSet()
    {
      return _nameProperty != null && (UsingChildCollection || _nameProperty != null && _parentIdProperty != null);
    }

    private bool UsingChildCollection
    {
      get { return _childCollectionProperty != null || _isSelfCollection; }
    }

    private bool PrepareDescriptors()
    {
      var propertyDescriptorCollection = _listManager.GetItemProperties();
      var enumerableItemType = MetaDataHelper.GetEnumerableItemType(_listManager.List);
      _isSelfCollection = enumerableItemType.Implements(typeof (IEnumerable));
      if (propertyDescriptorCollection.Count == 0)
      {
        var implementedInterfaces = enumerableItemType.GetTypeInfo().ImplementedInterfaces;
        if (implementedInterfaces != null)
          foreach (var implementedInterface in implementedInterfaces)
          {
            propertyDescriptorCollection = TypeDescriptor.GetProperties(implementedInterface);
            if (propertyDescriptorCollection.Count > 0)
              break;
          }
      }
      PropertyDescriptorCollection childPropertyDescriptorCollection = null;
      if (_isSelfCollection & _listManager.Count > 0)
      {
        var childItemType = MetaDataHelper.GetEnumerableItemType(_listManager.Current as IEnumerable);
        childPropertyDescriptorCollection = TypeDescriptor.GetProperties(childItemType);
        if (!string.IsNullOrEmpty(_namePropertyName))
          _childNameProperty = childPropertyDescriptorCollection[_namePropertyName];
      }

      if (!string.IsNullOrEmpty(_namePropertyName))
      {
        if (_nameProperty == null)
          _nameProperty = propertyDescriptorCollection[_namePropertyName];
        if (_nameProperty == null)
          _nameProperty = propertyDescriptorCollection["Key"];
      }
      else if (propertyDescriptorCollection.Count == 1)
      {
        _nameProperty = propertyDescriptorCollection[0];
      }

      if (_nameProperty != null)
      {
        if (_nameProperty == null)
          _nameProperty = propertyDescriptorCollection[_namePropertyName];

        if (_idPropertyName.Length != 0 && _parentIdPropertyName.Length != 0)
        {
          if (_idProperty == null)
            _idProperty = propertyDescriptorCollection[_idPropertyName];
          if (_parentIdProperty == null)
            _parentIdProperty = propertyDescriptorCollection[_parentIdPropertyName];
        }
        else if (string.IsNullOrEmpty(_childCollectionPropertyName) && _nameProperty != null)
        {
          _isSelfCollection = _nameProperty.ComponentType.Implements(typeof (IEnumerable));
        }

        if (!string.IsNullOrEmpty(_childCollectionPropertyName))
          if (_childCollectionProperty == null)
          {
            _childCollectionProperty = propertyDescriptorCollection[_childCollectionPropertyName];
            if (_childCollectionProperty == null && childPropertyDescriptorCollection!=null)
            {
              _childCollectionProperty = childPropertyDescriptorCollection[_childCollectionPropertyName];
            }
          }
      }

      return PropertyAreSet();
    }

    private bool PrepareValueConvertor()
    {
      if (_valueConverter == null && _nameProperty != null)
        _valueConverter = TypeDescriptor.GetConverter(_nameProperty.PropertyType);

      return (_valueConverter != null && _valueConverter.CanConvertFrom(typeof (string)));
    }

    #endregion

    private void WireDataSource()
    {
      _listManager.PositionChanged += ListManagerPositionChanged;
      _bindingList = _listManager.List as IBindingList;
      if (_bindingList != null) _bindingList.ListChanged += DataTreeView_ListChanged;
    }

    public void ResetData()
    {
      BeginUpdate();

      Clear();
      if (!_reseting
        //  && !_initializing
        )
        try
        {
          _reseting = true;
          if (PrepareDataSource())
          {
            WireDataSource();
            if (PrepareDescriptors())
            {
              if (UsingChildCollection)
              {
                foreach (var item in _listManager.List)
                  AddChildren(Nodes, item);
              }
              else
              {
                var unsortedNodes = new ArrayList();
                for (var i = 0; i < _listManager.Count; i++)
                  unsortedNodes.Add(CreateNode(i));
                while (unsortedNodes.Count > 0)
                {
                  var startCount = unsortedNodes.Count;

                  for (var i = unsortedNodes.Count - 1; i >= 0; i--)
                    if (TryAddNode((TreeNode) unsortedNodes[i]))
                      unsortedNodes.RemoveAt(i);

                  if (startCount == unsortedNodes.Count)
                    if (IgnoreErrors)
                      break;
                    else
                    {
                      var ae = new ApplicationException("Tree view confused when try to make your data hierarchical.");
                      foreach (var node in unsortedNodes)
                        ae.Data.Add(node.ToString(), node);
                      throw ae;
                    }
                }
              }
            }
          }
        }
        finally
        {
          EndUpdate();
          _reseting = false;
        }
    }

    private void AddChildren(TreeNodeCollection treeNodeCollection, object item)
    {
      var treeNode = treeNodeCollection.Add(GetNodeText(item));
      treeNode.Tag = item;
      treeNode.Name = GetIdWithoutIdProperty(item);
      var children = Children(item);
      if (children != null)
      {
        var childBindingListView = children.ToBindingListView();
        if (childBindingListView != null)
        {
          childBindingListView.ListChanged += DataTreeView_ChildListChanged;
          _bindingLists.Add(item, childBindingListView);
        }
        foreach (var child in children)
          AddChildren(treeNode.Nodes, child);
      }
    }

    private IEnumerable Children(object item)
    {
      IBindingList bindingList;
      if (_bindingLists.TryGetValue(item, out bindingList))
        return bindingList;
      return (_childCollectionProperty == null || _childCollectionProperty .ComponentType!= item.GetType() ? item : _childCollectionProperty.GetValue(item)) as IEnumerable;
    }

    public IBindingListView GetChildEnumerable(TreeViewEventArgs e)
    {
      return GetChildEnumerable(e.Node);
    }

    private IBindingListView GetChildEnumerable(TreeNode treeNode)
    {
      var children = Children(treeNode.Tag);
      if (children == null)
      {
        var childBindingListView = ChildTags(treeNode).ToBindingListView();
        if (childBindingListView != null)
        {
          childBindingListView.ListChanged += DataTreeView_ChildListChanged;
          _bindingLists.Add(treeNode.Tag, childBindingListView);
        }
        return childBindingListView;
      }
      var bindingListView = children.ToBindingListView();
      return bindingListView;
    }

    public void RemoveSelectedNode()
    {
      var nodeToRemove = SelectedNode;
      if (nodeToRemove == null)
      {
        if (_listManager.Position > -1)
          _listManager.RemoveAt(_listManager.Position);
      }
      else
      {
        var indexOfSelectedNode = IndexOf(nodeToRemove.Tag);
        if (indexOfSelectedNode > -1)
          _listManager.RemoveAt(indexOfSelectedNode);
        else
        {
          var children = Children(nodeToRemove.Parent.Tag);
          var bindingListView = children.ToBindingListView();
          if (bindingListView != null)
          {
            bindingListView.Remove(nodeToRemove.Tag);
            nodeToRemove.Remove();
          }
        }
      }
    }

    public object AddNodeAndData()
    {
      var parentNode = SelectedNode;
      if (parentNode == null)
      {
        if (_bindingList != null) return _bindingList.AddNew();
      }
      else
      {
        var children = Children(parentNode.Tag);
        if (children == null)
        {
          if (_bindingList != null)
          {
            var newData = _bindingList.AddNew();
            SetParent(newData, parentNode);
            return newData;
          }
        }
        var bindingListView = children.ToBindingListView();
        if (bindingListView != null) return bindingListView.AddNew();
      }
      return null;
    }

    public TreeNode AddNode()
    {
      var treeNode = new TreeNode();
      if (SelectedNode == null)
        Nodes.Add(treeNode);
      else
        SelectedNode.Nodes.Add(treeNode);
      SelectedNode = treeNode;
      return treeNode;
    }

    private static IEnumerable<object> ChildTags(TreeNode treeNode)
    {
      return treeNode.Nodes.AsEnumerable().Select(tn => tn.Tag);
    }

    private static IEnumerable<object> DescendantTags(TreeNode treeNode)
    {
      return treeNode.Descendants(tn => tn.Nodes.AsEnumerable()).Select(tn => tn.Tag);
    }

    private static string GetIdWithoutIdProperty(object item)
    {
      return item.GetHashCode().ToString();
    }

    private bool TryAddNode(TreeNode node)
    {
      if (node.Parent != null)
        return true;
      if (HasParent(node))
      {
        var parentNode = GetDataParent(node);
        if (parentNode != null && !parentNode.Nodes.Contains(node))
        {
          parentNode.Nodes.AddDistinct(node);
          return true;
        }
      }
      else
      {
        if (SelectedNode != null)
        {
          var selectedData = SelectedNode.Tag;
          var children = Children(selectedData);
          if (children != null && children.Cast<object>().Any(child => child == node.Tag))
          {
            SelectedNode.Nodes.Add(node);
            return true;
          }
        }
        Nodes.AddDistinct(node);
        return true;
      }
      return false;
    }

    private TreeNode FindFirst(object iD)
    {
      var foundNodes = Nodes.Find(iD.ToString(), true);
      return foundNodes.Length == 0 ? null : foundNodes[0];
    }

    private object GetCurrentID(int index)
    {
      return GetDataID(_listManager.List[index]);
    }

    private TreeNode GetCurrentNodeFromData()
    {
      return GetDataAsNode(_listManager.Current);
    }

    private TreeNode GetDataAsNode(object dataObject)
    {
      var dataID = GetDataID(dataObject);
      return FindFirst(dataID);
    }

    private object GetDataID(object dataObject)
    {
      if (_idProperty == null)
        return GetIdWithoutIdProperty(dataObject);
      var dataID = _idProperty.GetValue(dataObject);
      return IsIDNull(dataID) ? GetIdWithoutIdProperty(dataObject) : dataID;
    }

    private TreeNode GetDataAsNode(int position)
    {
      return GetDataAsNode(_listManager.List[position]);
    }

    private TreeNode GetDataParent(TreeNode node)
    {
      return FindFirst(GetParent(node.Tag));
    }

    private object GetParent(object nodeObject)
    {
      return _parentIdProperty.GetValue(nodeObject);
    }

    private void ChangeParent(TreeNode node)
    {
      object currentParentID = null;
      if (_parentIdProperty == null)
      {
        //if (SelectedNode != null && SelectedNode!= node)
        //  SelectedNode.Nodes.AddDistinct(node);
      }
      else
      {
        var dataParentID = GetParent(node.Tag);
        if (dataParentID != null)
        {
          if (node.Parent != null)
            currentParentID = GetDataID(node.Parent.Tag);
          if (!dataParentID.Equals(currentParentID))
            if (HasParent(node, dataParentID) || node.Parent != null)
            {
              if (node.Nodes.Find(dataParentID.ToString(), true).Length > 0)
                throw new ApplicationException("A Parent can't be the child of a child!");
              var newParentNode = FindFirst(dataParentID);
              MoveNode(node, newParentNode);
            }
        }
      }
    }

    private static void MoveNode(TreeNode node, TreeNode newParentNode)
    {
      node.Remove();
      if (newParentNode != null)
        newParentNode.Nodes.Add(node);
    }

    private void ChangeParent(TreeNode childnode, TreeNode parentNode)
    {
      if (childnode != null && parentNode != null && parentNode != childnode.Parent)
      {
        if (_parentIdProperty == null)
        {
          var children = Children(parentNode.Tag) as IList;
          if (children != null)
            try
            {
              _changingParent = true;
              children.AddDistinct(childnode.Tag);
              MoveNode(childnode, parentNode);
            }
            finally
            {
              _changingParent = false;
            }
        }
        else
        {
          SetParent(childnode.Tag, parentNode);
        }
        _listManager.EndCurrentEdit();
      }
    }

    private void SetParent(object childnodeTag, TreeNode parentNode)
    {
      var parentID = GetDataID(parentNode.Tag);
      if (parentID != null)
        _parentIdProperty.SetValue(childnodeTag, parentID);
    }

    private object GetID(TreeNode node)
    {
      return GetDataID(node.Tag);
    }

    private void RefreshData(TreeNode node, object data)
    {
      node.Tag = data;
      node.Name = GetID(node).ToString();
      node.Text = GetNodeText(node.Tag);
      ChangeParent(node);
    }

    private string GetNodeText(object component)
    {
      try
      {
        var type = component.GetType();
        if (_childNameProperty != null && type.IsAssignableTo(_childNameProperty.ComponentType))
          return Convert.ToString(_childNameProperty.GetValue(component));
        //_childNameProperty
        if (type.IsAssignableTo(_nameProperty.ComponentType))
          return Convert.ToString(_nameProperty.GetValue(component));
        return Convert.ToString(component);
      }
      catch (Exception e)
      {
        return e.Message;
      }
    }

    private void RefreshData(TreeNode node, int position)
    {
      RefreshData(node, _listManager.List[position]);
    }

    private void RefreshData(int position)
    {
      var dataObject = _listManager.List[position];
      var node = GetDataAsNode(dataObject);
      if (node != null)
        RefreshData(node, dataObject);
    }

    private void RefreshAllData(int fromPosition)
    {
      for (var i = fromPosition; i < _listManager.Count; i++)
      {
        RefreshData(i);
      }
    }

    private void SynchronizeSelection()
    {
      if (!_selectionChanging)
      {
        BeginSelectionChanging();
        try
        {
          SelectedNode = GetCurrentNodeFromData();
        }
        catch (Exception)
        {
        }
        finally
        {
          EndSelectionChanging();
        }
      }
    }

    /// <summary>
    ///   Create a TreeNode with currency manager and position.
    /// </summary>
    /// <param name="position"></param>
    /// <returns></returns>
    private TreeNode CreateNode(int position)
    {
      var node = new TreeNode();
      RefreshData(node, position);
      return node;
    }

    private TreeNode CreateNode(object data)
    {
      var node = new TreeNode();
      RefreshData(node, data);
      return node;
    }

    private static bool IsIDNull(object id)
    {
      if (id == null
          || Convert.IsDBNull(id))
        return true;
      var s = id as string;
      if (s != null)
        return (s.Length == 0);
      if (id is Guid)
        return ((Guid) id == Guid.Empty);
      if (id is int)
        return ((int) id == 0);
      return false;
    }

    private static bool ObjectValuesEqual(object object1, object object2)
    {
      return object1.Equals(object2)
             || (object1.GetType() == object2.GetType() && object1.GetHashCode() == object2.GetHashCode());
    }

    private bool HasParent(TreeNode node, object parentID)
    {
      return !(IsIDNull(parentID) || ObjectValuesEqual(parentID, GetID(node)));
    }

    private bool HasParent(TreeNode node)
    {
      if (_parentIdProperty == null)
        return false;
      return HasParent(node, GetParent(node.Tag));
    }

    protected override void InitLayout()
    {
      base.InitLayout();
      ShowScrollBar(Handle, SbHorz, false);
    }

    private void BeginSelectionChanging()
    {
      _selectionChanging = true;
    }

    private void EndSelectionChanging()
    {
      _selectionChanging = false;
    }

    #endregion

    public void BeginInit()
    {
      _initializing = true;
    }

    public void EndInit()
    {
      _initializing = false;
      //ResetData();
    }
  }
}