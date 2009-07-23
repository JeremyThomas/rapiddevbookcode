using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Chaliy.Windows.Forms
{
  /// <summary>
  /// Data binding enabled hierarchical tree view control.
  /// </summary>
  /// <remarks>
  /// created:	2005/03/27
  /// created:	27:3:2005   7:05
  /// filename: 	DataTreeView.cs
  /// author:		Mike Chaliy
  /// url: http://www.codeproject.com/KB/tree/bindablehierarchicaltree.aspx
  /// purpose:	Data binding enabled hierarchical tree view control.
  /// Modifications by Jeremy Thomas: Added Drag-drop, adding and deleting, Removed internal lists,
  /// uses DataMemberListEditor and DataMemberFieldEditor
  /// </remarks>
  public class DataTreeView : TreeView
  {
    private const int SB_HORZ = 0;

    #region Fields

    private readonly Container components;
    private readonly BindingSource m_BindingSource;
    private CurrencyManager listManager;

    private string idPropertyName;
    private string namePropertyName;
    private string parentIdPropertyName;
    private string valuePropertyName;
    private readonly Char[] DataMemberFieldSeperator = new[] {'.'};

    private PropertyDescriptor idProperty;
    private PropertyDescriptor nameProperty;
    private PropertyDescriptor parentIdProperty;
    private PropertyDescriptor valueProperty;

    private TypeConverter valueConverter;

    private bool selectionChanging;

    #endregion

    #region Constructors

    /// <summary>
    /// Default constructor.
    /// </summary>
    public DataTreeView()
    {
      idPropertyName = string.Empty;
      namePropertyName = string.Empty;
      parentIdPropertyName = string.Empty;
      selectionChanging = false;

      m_BindingSource = new BindingSource();

      FullRowSelect = true;
      HideSelection = false;
      HotTracking = true;
      AfterSelect += DataTreeView_AfterSelect;
      BindingContextChanged += DataTreeView_BindingContextChanged;
      AfterLabelEdit += DataTreeView_AfterLabelEdit;
      DragDrop += DataTreeView_DragDrop;
      DragOver += DataTreeView_DragOver;
      ItemDrag += DataTreeView_ItemDrag;
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
        if (components != null)
          components.Dispose();
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
      get { return m_BindingSource.DataSource; }
      set
      {
        if (m_BindingSource.DataSource != value)
        {
          m_BindingSource.DataSource = value;
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
      get { return m_BindingSource.DataMember; }
      set
      {
        if (m_BindingSource.DataMember != value)
          m_BindingSource.DataMember = value;
        //this.ResetData();
      }
    }


    /// <summary>
    /// Identifier member, in most cases this is primary column of the table.
    /// </summary>
    [
      DefaultValue(""),
      Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor)),
      Category("Data"),
      Description("Identifier member, in most cases this is primary column of the table.")
    ]
    public string IDColumn
    {
      get { return idPropertyName; }
      set
      {
        if (idPropertyName != value)
          if (value == null)
          {
            DataMember = string.Empty;
            idPropertyName = string.Empty;
          }
          else
          {
            var split = value.Split(DataMemberFieldSeperator);
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
            idProperty = null;
            if (DataSource != null && temp != string.Empty)
            {
              var currencyManager = new BindingContext()[DataSource, DataMember] as CurrencyManager;
              if (currencyManager != null)
              {
                var APropertyDescriptorCollection = currencyManager.GetItemProperties();
                idProperty = APropertyDescriptorCollection.Find(temp, true);
                if (APropertyDescriptorCollection.Count == 0)
                  idPropertyName = value;
              }
              if (idProperty != null)
                idPropertyName = value;
            }
            else
              idPropertyName = value;
          }
        //  this.ResetData();
      }
    }

    /// <summary>
    /// Name member. Note: editing of this column available only with types that support converting from string.
    /// </summary>
    [
      DefaultValue(""),
      Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor)),
      Category("Data"),
      Description("Name member. Note: editing of this column available only with types that support converting from string.")
    ]
    public string NameColumn
    {
      get { return namePropertyName; }
      set
      {
        if (namePropertyName != value)
          if (value == null)
            namePropertyName = string.Empty;
          else
          {
            var split = value.Split(DataMemberFieldSeperator);
            string temp;
            string tempDataMember;
            if (split.Length > 1)
            {
              tempDataMember = split[0];
              temp = split[1];
            }
            else
            {
              tempDataMember = string.Empty;
              temp = value;
            }
            nameProperty = null;
            if (DataSource != null && temp != string.Empty)
            {
              if (tempDataMember == DataMember || DataMember == string.Empty)
              {
                var currencyManager = new BindingContext()[DataSource, DataMember] as CurrencyManager;
                if (currencyManager != null)
                {
                  if (DataMember == null)
                    DataMember = tempDataMember;
                  var APropertyDescriptorCollection = currencyManager.GetItemProperties();
                  nameProperty = APropertyDescriptorCollection.Find(temp, true);
                  if (APropertyDescriptorCollection.Count == 0)
                    namePropertyName = value;
                }
                if (nameProperty != null)
                  namePropertyName = value;
              }
            }
            else
              namePropertyName = value;
          }
        //  this.ResetData();
      }
    }

    /// <summary>
    /// Identifier of the parent. Note: this member must have the same type as identifier column.
    /// </summary>
    [
      DefaultValue(""),
      Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor)),
      Category("Data"),
      Description("Identifier of the parent. Note: this member must have the same type as identifier column.")
    ]
    public string ParentIDColumn
    {
      get { return parentIdPropertyName; }
      set
      {
        if (namePropertyName != value)
          if (value == null)
            namePropertyName = string.Empty;
          else
          {
            var split = value.Split(DataMemberFieldSeperator);
            string temp;
            string tempDataMember;
            if (split.Length > 1)
            {
              tempDataMember = split[0];
              temp = split[1];
            }
            else
            {
              tempDataMember = string.Empty;
              temp = value;
            }
            parentIdProperty = null;
            if (DataSource != null && temp != string.Empty)
            {
              if (tempDataMember == DataMember || DataMember == string.Empty)
              {
                var currencyManager = new BindingContext()[DataSource, DataMember] as CurrencyManager;
                if (currencyManager != null)
                {
                  if (DataMember == null)
                    DataMember = tempDataMember;
                  var APropertyDescriptorCollection = currencyManager.GetItemProperties();
                  parentIdProperty = APropertyDescriptorCollection.Find(temp, true);
                  if (APropertyDescriptorCollection.Count == 0)
                    parentIdPropertyName = value;
                }
                if (parentIdProperty != null)
                  parentIdPropertyName = value;
              }
            }
            else
              parentIdPropertyName = value;
          }
        //  this.ResetData();
      }
    }

    #endregion

    #region Events

    public void MoveToItem(object itemToSelect)
    {
      if (itemToSelect != null && listManager != null)
        listManager.Position = listManager.List.IndexOf(itemToSelect);
    }

    private void DataTreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (!selectionChanging)
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
        if (PrepareValueConvertor()
            && valueConverter.IsValid(e.Label)
          )
        {
          nameProperty.SetValue(
            e.Node.Tag,
            valueConverter.ConvertFromString(e.Label)
            );
          listManager.EndCurrentEdit();
          return;
        }
      e.CancelEdit = true;
    }

    private void DataTreeView_ItemDrag(object sender, ItemDragEventArgs e)
    {
      DoDragDrop(e.Item, DragDropEffects.Copy | DragDropEffects.Move); //Begin the drag-drop operation
    }

    private void DataTreeView_DragOver(object sender, DragEventArgs e)
    {
      var tv = (TreeView) sender;
      var position = tv.PointToClient(new Point(e.X, e.Y)); //Get the co-ordinates of the mouse
      var destinationNode = tv.GetNodeAt(position); //Get the node at the current mouse position

      tv.SelectedNode = destinationNode; //Highlight the node in relations to the mouse position
      e.Effect = DragDropEffects.Move;
    }

    private void DataTreeView_DragDrop(object sender, DragEventArgs e)
    {
      TreeNode dragNode; //Used to hold a reference to the node that is being dragged
      TreeNode dropNode; //Used to hold a reference to the destination node (where the dragged node is released)

      if (e.Data.GetDataPresent(typeof (TreeNode))) //Continue only if the item being dragged is a TreeNode object
      {
        var tv = (TreeView) sender;
        var position = tv.PointToClient(new Point(e.X, e.Y)); //Get the mouse co-ordinates
        dropNode = tv.GetNodeAt(position); //Get the node at the current mouse position
        dragNode = (TreeNode) e.Data.GetData(typeof (TreeNode)); //Get the reference to node that is being dragged  
        if ((dropNode != null && dragNode != null) && (dropNode != dragNode)) //Continue only if we have both node references and that they are not the same reference
        {
          ChangeParent(dragNode, dropNode);
          dropNode.ExpandAll(); //Expand all the child nodes for the users sake 
        }
      }
    }

    private void DataTreeView_BindingContextChanged(object sender, EventArgs e)
    {
      ResetData();
    }

    private void listManager_PositionChanged(object sender, EventArgs e)
    {
      if (PropertyAreSet())
        SynchronizeSelection();
      else
        ResetData();
    }

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

            var changedNode = GetDatasNode(e.NewIndex);
            if (changedNode != null)
              RefreshData(changedNode, e.NewIndex);
            else if (IsIDNull(GetCurrentID(e.NewIndex)))
              throw new ApplicationException("Item not found or wrong type.");
            else if (TryAddNode(CreateNode(e.NewIndex)))
              ResetData();
            else
              throw new ApplicationException("Item not found or wrong type.");
            break;

          case ListChangedType.ItemDeleted:
            if (SelectedNode != null && (listManager.List.IndexOf(SelectedNode.Tag) == -1)
                || listManager.List.IndexOf(SelectedNode.Tag) == e.NewIndex)
            {
              SelectedNode.Remove();
              RefreshAllData(e.NewIndex);
            }
            break;

          case ListChangedType.Reset:
            ResetData();
            break;
        }
      else
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
        if (m_BindingSource.DataSource != null)
        {
          listManager = BindingContext[m_BindingSource.DataSource, m_BindingSource.DataMember] as CurrencyManager;
          return listManager != null;
        }
        else
        {
          listManager = null;
          Clear();
        }
      return false;
    }

    #region Descriptors

    private bool PropertyAreSet()
    {
      return (idProperty != null
              && nameProperty != null
              && parentIdProperty != null);
    }

    private bool PrepareDescriptors()
    {
      if (idPropertyName.Length != 0
          && namePropertyName.Length != 0
          && parentIdPropertyName.Length != 0)
      {
        PropertyDescriptorCollection APropertyDescriptorCollection;
        APropertyDescriptorCollection = listManager.GetItemProperties();
        //APropertyDescriptorCollection.Find
        if (idProperty == null)
          idProperty = APropertyDescriptorCollection[idPropertyName];
        if (nameProperty == null)
          nameProperty = APropertyDescriptorCollection[namePropertyName];
        if (parentIdProperty == null)
          parentIdProperty = APropertyDescriptorCollection[parentIdPropertyName];
      }

      return PropertyAreSet();
    }

    private bool PrepareValueDescriptor()
    {
      if (valueProperty == null)
      {
        if (valuePropertyName == string.Empty)
          valuePropertyName = idPropertyName;
        valueProperty = listManager.GetItemProperties()[valuePropertyName];
      }

      return (valueProperty != null);
    }

    private bool PrepareValueConvertor()
    {
      if (valueConverter == null)
        valueConverter = TypeDescriptor.GetConverter(nameProperty.PropertyType);

      return (valueConverter != null
              && valueConverter.CanConvertFrom(typeof (string))
             );
    }

    #endregion

    private void WireDataSource()
    {
      listManager.PositionChanged += listManager_PositionChanged;
      ((IBindingList) listManager.List).ListChanged += DataTreeView_ListChanged;
    }

    public void ResetData()
    {
      BeginUpdate();

      Clear();

      try
      {
        if (PrepareDataSource())
        {
          WireDataSource();
          if (PrepareDescriptors())
          {
            var unsortedNodes = new ArrayList();

            for (var i = 0; i < listManager.Count; i++)
            {
              unsortedNodes.Add(CreateNode(i));
            }

            int startCount;

            while (unsortedNodes.Count > 0)
            {
              startCount = unsortedNodes.Count;

              for (var i = unsortedNodes.Count - 1; i >= 0; i--)
              {
                if (TryAddNode((TreeNode) unsortedNodes[i]))
                  unsortedNodes.RemoveAt(i);
              }

              if (startCount == unsortedNodes.Count)
              {
                var AE = new ApplicationException("Tree view confused when try to make your data hierarchical.");
                foreach (var Node in unsortedNodes)
                {
                  AE.Data.Add(Node.ToString(), Node);
                }
                throw AE;
              }
            }
          }
        }
      }
      finally
      {
        EndUpdate();
      }
    }

    private bool TryAddNode(TreeNode node)
    {
      if (HasParent(node))
      {
        var parentNode = GetDataParent(node);
        if (parentNode != null)
        {
          AddNode(parentNode.Nodes, node);
          return true;
        }
      }
      else
      {
        AddNode(Nodes, node);
        return true;
      }
      return false;
    }

    private void AddNode(TreeNodeCollection nodes, TreeNode node)
    {
      nodes.Add(node);
    }

    private void ChangeParent(TreeNode Childnode, TreeNode ParentNode)
    {
      if (Childnode != null && ParentNode != null)
      {
        var ParentID = idProperty.GetValue(ParentNode.Tag);
        if (PrepareValueConvertor()
            && valueConverter.IsValid(ParentID)
          )
        {
          parentIdProperty.SetValue(
            Childnode.Tag,
            ParentID
            );
          listManager.EndCurrentEdit();
          return;
        }
      }
    }

    private TreeNode FindFirst(object iD)
    {
      var FoundNodes = Nodes.Find(iD.ToString(), true);
      if (FoundNodes.Length == 0)
        return null;
      else
        return FoundNodes[0];
    }

    private object GetCurrentID()
    {
      return idProperty.GetValue(listManager.Current);
    }

    private object GetCurrentID(int index)
    {
      return idProperty.GetValue(listManager.List[index]);
    }

    private TreeNode GetCurrentNodeFromData()
    {
      return GetDatasNode(listManager.Current);
    }

    private TreeNode GetDatasNode(object DataObject)
    {
      var dataID = idProperty.GetValue(DataObject);
      return FindFirst(dataID);
    }

    private TreeNode GetDatasNode(int position)
    {
      return GetDatasNode(listManager.List[position]);
    }

    private TreeNode GetDataParent(TreeNode node)
    {
      return FindFirst(parentIdProperty.GetValue(node.Tag));
    }

    private void ChangeParent(TreeNode node)
    {
      object CurrentParentID = null;
      var dataParentID = parentIdProperty.GetValue(node.Tag);
      if (dataParentID != null)
      {
        if (node.Parent != null)
          CurrentParentID = idProperty.GetValue(node.Parent.Tag);
        if (!dataParentID.Equals(CurrentParentID))
          if (HasParent(node, dataParentID) || node.Parent != null)
          {
            node.Remove();
            if (node.Nodes.Find(dataParentID.ToString(), true).Length > 0)
              throw new ApplicationException("A Parent can't be the child of a child!");
            var newParentNode = FindFirst(dataParentID);
            if (newParentNode != null)
              newParentNode.Nodes.Add(node);
          }
      }
    }

    private object GetID(TreeNode node)
    {
      return idProperty.GetValue(node.Tag);
    }

    private void RefreshData(TreeNode node, object Data)
    {
      node.Tag = Data;
      node.Name = GetID(node).ToString();
      try
      {
        node.Text = (string) nameProperty.GetValue(node.Tag);
      }
      catch (Exception e)
      {
        node.Text = e.Message;
      }
      ChangeParent(node);
    }

    private void RefreshData(TreeNode node)
    {
      RefreshData(node, listManager.Current);
    }

    private void RefreshData(TreeNode node, int position)
    {
      RefreshData(node, listManager.List[position]);
    }

    private void RefreshData(int position)
    {
      var DataObject = listManager.List[position];
      var Node = GetDatasNode(DataObject);
      if (Node != null)
        RefreshData(Node, DataObject);
    }

    private void RefreshAllData(int fromPosition)
    {
      for (var i = fromPosition; i < listManager.Count; i++)
      {
        RefreshData(i);
      }
    }

    private void SynchronizeSelection()
    {
      if (!selectionChanging)
      {
        BeginSelectionChanging();
        try
        {
          SelectedNode = GetCurrentNodeFromData();
        }
        finally
        {
          EndSelectionChanging();
        }
      }
    }

    /// <summary>
    /// Create a TreeNode with currency manager and position.
    /// </summary>
    /// <param name="currencyManager"></param>
    /// <param name="position"></param>
    /// <returns></returns>
    private TreeNode CreateNode(int position)
    {
      var node = new TreeNode();
      RefreshData(node, position);
      return node;
    }

    private TreeNode CreateNode()
    {
      var node = new TreeNode();
      RefreshData(node);
      return node;
    }

    private static bool IsIDNull(object id)
    {
      if (id == null
          || Convert.IsDBNull(id))
        return true;
      else if (id.GetType() == typeof (string))
        return (((string) id).Length == 0);
      else if (id.GetType() == typeof (Guid))
        return ((Guid) id == Guid.Empty);
      else if (id.GetType() == typeof (int))
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
      return HasParent(node, parentIdProperty.GetValue(node.Tag));
    }

    protected override void InitLayout()
    {
      base.InitLayout();
      ShowScrollBar(Handle, SB_HORZ, false);
    }

    private void BeginSelectionChanging()
    {
      selectionChanging = true;
    }

    private void EndSelectionChanging()
    {
      selectionChanging = false;
    }

    #endregion
  }
}