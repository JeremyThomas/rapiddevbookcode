/********************************************************************
	created:	2005/03/27
	created:	27:3:2005   7:05
	filename: 	DataTreeView.cs	
	author:		Mike Chaliy
	url: http://www.codeproject.com/KB/tree/bindablehierarchicaltree.aspx
	purpose:	Data binding enabled hierarchical tree view control.
 
  Modifications by Jeremmy Thomas: Added Drag-drop, adding and deleting, Removed internal lists
                uses DataMemberListEditor and DataMemberFieldEditor
*********************************************************************/
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Chaliy.Windows.Forms
{
  /// <summary>
  /// Data binding enabled hierarchical tree view control.
  /// </summary>
  public class DataTreeView : TreeView
  {
    const int SB_HORZ = 0;

    #region Fields

    private System.ComponentModel.Container components = null;
    private BindingSource m_BindingSource;
    private CurrencyManager listManager;

    private string idPropertyName;
    private string namePropertyName;
    private string parentIdPropertyName;
    private string valuePropertyName;
    private Char[] DataMemberFieldSeperator = new Char[] { '.' };

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
      this.idPropertyName = string.Empty;
      this.namePropertyName = string.Empty;
      this.parentIdPropertyName = string.Empty;
      this.selectionChanging = false;

      m_BindingSource = new BindingSource();

      this.FullRowSelect = true;
      this.HideSelection = false;
      this.HotTracking = true;
      this.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DataTreeView_AfterSelect);
      this.BindingContextChanged += new System.EventHandler(this.DataTreeView_BindingContextChanged);
      this.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.DataTreeView_AfterLabelEdit);
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataTreeView_DragDrop);
      this.DragOver += new System.Windows.Forms.DragEventHandler(this.DataTreeView_DragOver);
      this.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.DataTreeView_ItemDrag);
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (components != null)
          components.Dispose();
      }
      base.Dispose(disposing);
    }

    #endregion

    #region Win32

    [DllImport("User32.dll")]
    static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

    #endregion

    #region Properties

    [AttributeProvider(typeof(IListSource)),
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
          this.ResetData();
        }
      }
    }

    [Editor("System.Windows.Forms.Design.DataMemberListEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)),
        RefreshProperties(RefreshProperties.Repaint),
    Category("Data"),
    Description("Data member of the tree.")]
    public string DataMember
    {
      get { return m_BindingSource.DataMember; }
      set
      {
        if (m_BindingSource.DataMember != value)
        {
          m_BindingSource.DataMember = value;
          //this.ResetData();
        }
      }
    }



    /// <summary>
    /// Identifier member, in most cases this is primary column of the table.
    /// </summary>
    [
    DefaultValue(""),
Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)),
    Category("Data"),
    Description("Identifier member, in most cases this is primary column of the table.")
    ]
    public string IDColumn
    {
      get
      {
        return this.idPropertyName;
      }
      set
      {
        if (this.idPropertyName != value)
          if (value == null)
          {
            DataMember = string.Empty;
            idPropertyName = string.Empty;
          }
          else
          {
            string[] split = value.Split(DataMemberFieldSeperator);
            string temp;
            if (split.Length > 1)
            {
              this.DataMember = split[0];
              temp = split[1];
            }
            else
            {
              DataMember = string.Empty;
              temp = value;
            }
            idProperty = null;
            if (this.DataSource != null && temp != string.Empty)
            {
              CurrencyManager currencyManager = new BindingContext()[DataSource, DataMember] as CurrencyManager;
              if (currencyManager != null)
              {
                PropertyDescriptorCollection APropertyDescriptorCollection = currencyManager.GetItemProperties();
                idProperty = APropertyDescriptorCollection.Find(temp, true);
                if (APropertyDescriptorCollection.Count == 0)
                {
                  this.idPropertyName = value;
                }
              }
              if (this.idProperty != null)
              {
                this.idPropertyName = value;
              }
            }
            else
              this.idPropertyName = value;
          }
        //  this.ResetData();
      }
    }

    /// <summary>
    /// Name member. Note: editing of this column available only with types that support converting from string.
    /// </summary>
    [
    DefaultValue(""),
Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)),
    Category("Data"),
    Description("Name member. Note: editing of this column available only with types that support converting from string.")
    ]
    public string NameColumn
    {
      get
      {
        return this.namePropertyName;
      }
      set
      {
        if (this.namePropertyName != value)
          if (value == null)
          {
            namePropertyName = string.Empty;
          }
          else
          {
            string[] split = value.Split(DataMemberFieldSeperator);
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
            if (this.DataSource != null && temp != string.Empty)
            {
              if (tempDataMember == DataMember || DataMember == string.Empty)
              {
                CurrencyManager currencyManager = new BindingContext()[DataSource, DataMember] as CurrencyManager;
                if (currencyManager != null)
                {
                  if (DataMember == null)
                    DataMember = tempDataMember;
                  PropertyDescriptorCollection APropertyDescriptorCollection = currencyManager.GetItemProperties();
                  nameProperty = APropertyDescriptorCollection.Find(temp, true);
                  if (APropertyDescriptorCollection.Count == 0)
                  {
                    this.namePropertyName = value;
                  }
                }
                if (this.nameProperty != null)
                {
                  this.namePropertyName = value;
                }
              }
            }
            else
              this.namePropertyName = value;
          }
        //  this.ResetData();
      }
    }

    /// <summary>
    /// Identifier of the parent. Note: this member must have the same type as identifier column.
    /// </summary>
    [
    DefaultValue(""),
Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)),
    Category("Data"),
    Description("Identifier of the parent. Note: this member must have the same type as identifier column.")
    ]
    public string ParentIDColumn
    {
      get
      {
        return this.parentIdPropertyName;
      }
      set
      {
        if (this.namePropertyName != value)
          if (value == null)
          {
            namePropertyName = string.Empty;
          }
          else
          {
            string[] split = value.Split(DataMemberFieldSeperator);
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
            if (this.DataSource != null && temp != string.Empty)
            {
              if (tempDataMember == DataMember || DataMember == string.Empty)
              {
                CurrencyManager currencyManager = new BindingContext()[DataSource, DataMember] as CurrencyManager;
                if (currencyManager != null)
                {
                  if (DataMember == null)
                    DataMember = tempDataMember;
                  PropertyDescriptorCollection APropertyDescriptorCollection = currencyManager.GetItemProperties();
                  parentIdProperty = APropertyDescriptorCollection.Find(temp, true);
                  if (APropertyDescriptorCollection.Count == 0)
                  {
                    this.parentIdPropertyName = value;
                  }
                }
                if (this.parentIdProperty != null)
                {
                  this.parentIdPropertyName = value;
                }
              }
            }
            else
              this.parentIdPropertyName = value;
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

    private void DataTreeView_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
    {
      if (!this.selectionChanging)
      {
        this.BeginSelectionChanging();
        try
        {
          if (e.Node != null)
          {
            MoveToItem(e.Node.Tag);
          }
        }
        finally
        {
          this.EndSelectionChanging();
        }
      }
    }

    private void DataTreeView_AfterLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
    {
      if (e.Node != null && e.Label != null)
      {
        if (this.PrepareValueConvertor()
          && this.valueConverter.IsValid(e.Label)
          )
        {
          this.nameProperty.SetValue(
            e.Node.Tag,
            this.valueConverter.ConvertFromString(e.Label)
            );
          this.listManager.EndCurrentEdit();
          return;
        }
      }
      e.CancelEdit = true;
    }

    private void DataTreeView_ItemDrag(object sender, ItemDragEventArgs e)
    {
      DoDragDrop((TreeNode)e.Item, DragDropEffects.Copy | DragDropEffects.Move); //Begin the drag-drop operation
    }

    private void DataTreeView_DragOver(object sender, DragEventArgs e)
    {
      TreeView tv = (TreeView)sender;
      Point position = tv.PointToClient(new Point(e.X, e.Y)); //Get the co-ordinates of the mouse
      TreeNode destinationNode = tv.GetNodeAt(position);     //Get the node at the current mouse position

      tv.SelectedNode = destinationNode;                     //Highlight the node in relations to the mouse position
      e.Effect = DragDropEffects.Move;
    }

    private void DataTreeView_DragDrop(object sender, DragEventArgs e)
    {
      TreeNode dragNode;                                             //Used to hold a reference to the node that is being dragged
      TreeNode dropNode;                                                     //Used to hold a reference to the destination node (where the dragged node is released)

      if (e.Data.GetDataPresent(typeof(TreeNode)))                   //Continue only if the item being dragged is a TreeNode object
      {
        TreeView tv = (TreeView)sender;
        Point position = tv.PointToClient(new Point(e.X, e.Y));               //Get the mouse co-ordinates
        dropNode = (TreeNode)tv.GetNodeAt(position);                          //Get the node at the current mouse position
        dragNode = (TreeNode)e.Data.GetData(typeof(TreeNode));    //Get the reference to node that is being dragged  
        if ((dropNode != null && dragNode != null) && (dropNode != dragNode))     //Continue only if we have both node references and that they are not the same reference
        {
          ChangeParent(dragNode, dropNode);
          dropNode.ExpandAll();                                                //Expand all the child nodes for the users sake 
        }
      }
    }

    private void DataTreeView_BindingContextChanged(object sender, System.EventArgs e)
    {
      this.ResetData();
    }

    private void listManager_PositionChanged(object sender, EventArgs e)
    {
      if (PropertyAreSet())
        this.SynchronizeSelection();
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
                if (TryAddNode(this.CreateNode(e.NewIndex)))
                {
                  Trace.Write(e);
                }
            }
            catch (System.ArgumentException ae)
            {
              Trace.Write(ae);
            }
            break;

          case ListChangedType.ItemChanged:

            TreeNode changedNode = GetDatasNode(e.NewIndex);
            if (changedNode != null)
            {
              RefreshData(changedNode, e.NewIndex);
            }
            else
              if (IsIDNull(GetCurrentID(e.NewIndex)))
              {
                throw new ApplicationException("Item not found or wrong type.");
              }
              else
              {
                if (TryAddNode(this.CreateNode(e.NewIndex)))
                  this.ResetData();
                else
                  throw new ApplicationException("Item not found or wrong type.");
              }
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
            this.ResetData();
            break;

        }
      else
        ResetData();
    }

    #endregion

    #region Implementation

    private void Clear()
    {
      this.Nodes.Clear();
    }

    private bool PrepareDataSource()
    {
      if (this.BindingContext != null)
      {
        if (this.m_BindingSource.DataSource != null)
        {
          this.listManager = this.BindingContext[this.m_BindingSource.DataSource, this.m_BindingSource.DataMember] as CurrencyManager;
          return listManager!=null;
        }
        else
        {
          this.listManager = null;
          this.Clear();
        }
      }
      return false;
    }

    #region Descriptors
    private bool PropertyAreSet()
    {
      return (this.idProperty != null
        && this.nameProperty != null
        && this.parentIdProperty != null);
    }

    private bool PrepareDescriptors()
    {
      if (this.idPropertyName.Length != 0
        && this.namePropertyName.Length != 0
        && this.parentIdPropertyName.Length != 0)
      {
        PropertyDescriptorCollection APropertyDescriptorCollection;
        APropertyDescriptorCollection = this.listManager.GetItemProperties();
        //APropertyDescriptorCollection.Find
        if (this.idProperty == null)
        {
          this.idProperty = APropertyDescriptorCollection[this.idPropertyName];
        }
        if (this.nameProperty == null)
        {
          this.nameProperty = APropertyDescriptorCollection[this.namePropertyName];
        }
        if (this.parentIdProperty == null)
        {
          this.parentIdProperty = APropertyDescriptorCollection[this.parentIdPropertyName];
        }
      }

      return PropertyAreSet();
    }

    private bool PrepareValueDescriptor()
    {
      if (this.valueProperty == null)
      {
        if (this.valuePropertyName == string.Empty)
        {
          this.valuePropertyName = this.idPropertyName;
        }
        this.valueProperty = this.listManager.GetItemProperties()[this.valuePropertyName];
      }

      return (this.valueProperty != null);
    }

    private bool PrepareValueConvertor()
    {
      if (this.valueConverter == null)
      {
        this.valueConverter = TypeDescriptor.GetConverter(this.nameProperty.PropertyType) as TypeConverter;
      }

      return (this.valueConverter != null
        && this.valueConverter.CanConvertFrom(typeof(string))
        );
    }
    #endregion

    private void WireDataSource()
    {
      this.listManager.PositionChanged += new EventHandler(listManager_PositionChanged);
      ((IBindingList)this.listManager.List).ListChanged += new ListChangedEventHandler(DataTreeView_ListChanged);
    }

    public void ResetData()
    {
      this.BeginUpdate();

      this.Clear();

      try
      {
        if (this.PrepareDataSource())
        {
          this.WireDataSource();
          if (this.PrepareDescriptors())
          {
            ArrayList unsortedNodes = new ArrayList();

            for (int i = 0; i < this.listManager.Count; i++)
            {
              unsortedNodes.Add(this.CreateNode(i));
            }

            int startCount;

            while (unsortedNodes.Count > 0)
            {
              startCount = unsortedNodes.Count;

              for (int i = unsortedNodes.Count - 1; i >= 0; i--)
              {
                if (this.TryAddNode((TreeNode)unsortedNodes[i]))
                {
                  unsortedNodes.RemoveAt(i);
                }
              }

              if (startCount == unsortedNodes.Count)
              {
                ApplicationException AE = new ApplicationException("Tree view confused when try to make your data hierarchical.");
                foreach (object Node in unsortedNodes)
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
        this.EndUpdate();
      }
    }

    private bool TryAddNode(TreeNode node)
    {
      if (this.HasParent(node))
      {
        TreeNode parentNode = GetDataParent(node);
        if (parentNode != null)
        {
          this.AddNode(parentNode.Nodes, node);
          return true;
        }
      }
      else
      {
        this.AddNode(this.Nodes, node);
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
        object ParentID = idProperty.GetValue(ParentNode.Tag);
        if (this.PrepareValueConvertor()
          && this.valueConverter.IsValid(ParentID)
          )
        {
          this.parentIdProperty.SetValue(
            Childnode.Tag,
            ParentID
            );
          this.listManager.EndCurrentEdit();
          return;
        }
      }
    }

    private TreeNode FindFirst(object iD)
    {
      TreeNode[] FoundNodes = this.Nodes.Find(iD.ToString(), true);
      if (FoundNodes.Length == 0)
        return null;
      else
      {
        return FoundNodes[0];
      }
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
      object dataID = idProperty.GetValue(DataObject);
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
      object dataParentID = this.parentIdProperty.GetValue(node.Tag);
      if (dataParentID != null)
      {
        if (node.Parent != null)
          CurrentParentID = idProperty.GetValue(node.Parent.Tag);
        if (!dataParentID.Equals(CurrentParentID))
        {
          if (HasParent(node, dataParentID) || node.Parent != null)
          {
            node.Remove();
            if (node.Nodes.Find(dataParentID.ToString(), true).Length > 0)
              throw new ApplicationException("A Parent can't be the child of a child!");
            TreeNode newParentNode = FindFirst(dataParentID);
            if (newParentNode != null)
              newParentNode.Nodes.Add(node);
          }
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
        node.Text = (string)this.nameProperty.GetValue(node.Tag);
      }
      catch (Exception e)
      {
        node.Text = e.Message;
      }
      this.ChangeParent(node);
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
      object DataObject = listManager.List[position];
      TreeNode Node = GetDatasNode(DataObject);
      if (Node != null)
      {
        RefreshData(Node, DataObject);
      }
    }

    private void RefreshAllData(int fromPosition)
    {
      for (int i = fromPosition; i < listManager.Count; i++)
      {
        RefreshData(i);
      }
    }

    private void SynchronizeSelection()
    {
      if (!this.selectionChanging)
      {
        this.BeginSelectionChanging();
        try
        {
          this.SelectedNode = GetCurrentNodeFromData();
        }
        finally
        {
          this.EndSelectionChanging();
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
      TreeNode node = new TreeNode();
      this.RefreshData(node, position);
      return node;
    }

    private TreeNode CreateNode()
    {
      TreeNode node = new TreeNode();
      this.RefreshData(node);
      return node;
    }

    private bool IsIDNull(object id)
    {
      if (id == null
        || Convert.IsDBNull(id))
      {
        return true;
      }
      else
      {
        if (id.GetType() == typeof(string))
        {
          return (((string)id).Length == 0);
        }
        else if (id.GetType() == typeof(Guid))
        {
          return ((Guid)id == Guid.Empty);
        }
        else if (id.GetType() == typeof(int))
        {
          return ((int)id == 0);
        }
      }
      return false;
    }

    private bool ObjectValuesEqual(object object1, object object2)
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
      this.selectionChanging = true;
    }

    private void EndSelectionChanging()
    {
      this.selectionChanging = false;
    }

    #endregion
  }
}
