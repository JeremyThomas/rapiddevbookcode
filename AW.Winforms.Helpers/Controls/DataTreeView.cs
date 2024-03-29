using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;
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
	[ComplexBindingProperties("DataSource", "DataMember")]
	public class DataTreeView : TreeView
	{
		private const int SbHorz = 0;

		#region Fields

		private readonly Container components;
		private readonly BindingSource m_BindingSource;
		private CurrencyManager _listManager;

		private string _idPropertyName;
		private string _namePropertyName;
		private string _parentIdPropertyName;
/*
		private string valuePropertyName;
*/
		private readonly Char[] _dataMemberFieldSeperator = new[] {'.'};

		private PropertyDescriptor _idProperty;
		private PropertyDescriptor _nameProperty;
		private PropertyDescriptor _parentIdProperty;

		private FieldsToPropertiesTypeDescriptionProvider _fieldsToPropertiesTypeDescriptionProvider;

		private TypeConverter _valueConverter;

		private bool _selectionChanging;

		#endregion

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DataTreeView()
		{
			_idPropertyName = string.Empty;
			_namePropertyName = string.Empty;
			_parentIdPropertyName = string.Empty;
			_selectionChanging = false;

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
			if (_fieldsToPropertiesTypeDescriptionProvider != null && _idProperty != null)
			{
				TypeDescriptor.RemoveProvider(_fieldsToPropertiesTypeDescriptionProvider, _idProperty.ComponentType);
				_fieldsToPropertiesTypeDescriptionProvider = null;
			}
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
			get { return _idPropertyName; }
			set { SetProperty(ref _idProperty, ref _idPropertyName, value); }
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
					var split = value.Split(_dataMemberFieldSeperator);
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

						if (property != null)
							propertyName = value;
					}
					else
						propertyName = value;
				}
			//  this.ResetData();
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
			get { return _namePropertyName; }
			set { SetProperty(ref _nameProperty, ref _namePropertyName, value); }
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
			get { return _parentIdPropertyName; }
			set { SetProperty(ref _parentIdProperty, ref _parentIdPropertyName, value); }
		}

		#endregion

		#region Events

		public void MoveToItem(object itemToSelect)
		{
			if (itemToSelect != null && _listManager != null)
				_listManager.Position = _listManager.List.IndexOf(itemToSelect);
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
				if (PrepareValueConvertor()
				    && _valueConverter.IsValid(e.Label)
				    && !_nameProperty.IsReadOnly
					)
				{
					_nameProperty.SetValue(
						e.Node.Tag,
						_valueConverter.ConvertFromString(e.Label)
						);
					_listManager.EndCurrentEdit();
					return;
				}
			e.CancelEdit = true;
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
			TreeNode dropNode; //Used to hold a reference to the destination node (where the dragged node is released)

			if (e.Data.GetDataPresent(typeof (TreeNode))) //Continue only if the item being dragged is a TreeNode object
			{
				var tv = (TreeView) sender;
				var position = tv.PointToClient(new Point(e.X, e.Y)); //Get the mouse co-ordinates
				dropNode = tv.GetNodeAt(position); //Get the node at the current mouse position
				var dragNode = (TreeNode) e.Data.GetData(typeof (TreeNode)); //Used to hold a reference to the node that is being dragged
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

		private void ListManagerPositionChanged(object sender, EventArgs e)
		{
			if (PropertyAreSet())
				SynchronizeSelection();
			else
				ResetData();
		}

		private bool _handelingItemChanged;

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
								var changedNode = GetDatasNode(e.NewIndex);
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
						if (SelectedNode != null && ((_listManager.List.IndexOf(SelectedNode.Tag) == -1)
						                             || _listManager.List.IndexOf(SelectedNode.Tag) == e.NewIndex))
						{
							SelectedNode.Remove();
							RefreshAllData(e.NewIndex);
						}
						break;

					case ListChangedType.Reset:
						ResetData();
						break;

					case ListChangedType.ItemMoved:
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
					_listManager = BindingContext[m_BindingSource.DataSource, m_BindingSource.DataMember] as CurrencyManager;
					return _listManager != null;
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
			return (_idProperty != null
			        && _nameProperty != null
			        && _parentIdProperty != null);
		}

		private bool PrepareDescriptors()
		{
			if (!string.IsNullOrEmpty(_idPropertyName)
			    && _namePropertyName.Length != 0
			    && _parentIdPropertyName.Length != 0)
			{
				var propertyDescriptorCollection = _listManager.GetItemProperties();
				//APropertyDescriptorCollection.Find
				if (_idProperty == null)
					_idProperty = propertyDescriptorCollection[_idPropertyName];
				if (_nameProperty == null)
					_nameProperty = propertyDescriptorCollection[_namePropertyName];
				if (_parentIdProperty == null)
					_parentIdProperty = propertyDescriptorCollection[_parentIdPropertyName];
			}

			return PropertyAreSet();
		}

		private bool PrepareValueConvertor()
		{
			if (_valueConverter == null)
				_valueConverter = TypeDescriptor.GetConverter(_nameProperty.PropertyType);

			return (_valueConverter != null
			        && _valueConverter.CanConvertFrom(typeof (string))
			       );
		}

		#endregion

		private void WireDataSource()
		{
			_listManager.PositionChanged += ListManagerPositionChanged;
			((IBindingList) _listManager.List).ListChanged += DataTreeView_ListChanged;
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

						for (var i = 0; i < _listManager.Count; i++)
						{
							unsortedNodes.Add(CreateNode(i));
						}

						while (unsortedNodes.Count > 0)
						{
							var startCount = unsortedNodes.Count;

							for (var i = unsortedNodes.Count - 1; i >= 0; i--)
							{
								if (TryAddNode((TreeNode) unsortedNodes[i]))
									unsortedNodes.RemoveAt(i);
							}

							if (startCount == unsortedNodes.Count)
							{
								var ae = new ApplicationException("Tree view confused when try to make your data hierarchical.");
								foreach (var node in unsortedNodes)
								{
									ae.Data.Add(node.ToString(), node);
								}
								throw ae;
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
				if (parentNode != null && !parentNode.Nodes.Contains(node))
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

		private static void AddNode(TreeNodeCollection nodes, TreeNode node)
		{
			nodes.Add(node);
		}

		private TreeNode FindFirst(object iD)
		{
			var foundNodes = Nodes.Find(iD.ToString(), true);
			return foundNodes.Length == 0 ? null : foundNodes[0];
		}

		private object GetCurrentID(int index)
		{
			return _idProperty.GetValue(_listManager.List[index]);
		}

		private TreeNode GetCurrentNodeFromData()
		{
			return GetDatasNode(_listManager.Current);
		}

		private TreeNode GetDatasNode(object dataObject)
		{
			var dataID = _idProperty.GetValue(dataObject);
			return FindFirst(dataID);
		}

		private TreeNode GetDatasNode(int position)
		{
			return GetDatasNode(_listManager.List[position]);
		}

		private TreeNode GetDataParent(TreeNode node)
		{
			return FindFirst(_parentIdProperty.GetValue(node.Tag));
		}

		private void ChangeParent(TreeNode node)
		{
			object currentParentID = null;
			var dataParentID = _parentIdProperty.GetValue(node.Tag);
			if (dataParentID != null)
			{
				if (node.Parent != null)
					currentParentID = _idProperty.GetValue(node.Parent.Tag);
				if (!dataParentID.Equals(currentParentID))
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

		private void ChangeParent(TreeNode childnode, TreeNode parentNode)
		{
			if (childnode != null && parentNode != null)
			{
				var parentID = _idProperty.GetValue(parentNode.Tag);
				if (parentID != null)
				{
					_parentIdProperty.SetValue(
						childnode.Tag,
						parentID
						);
					_listManager.EndCurrentEdit();
					return;
				}
			}
		}

		private object GetID(TreeNode node)
		{
			return _idProperty.GetValue(node.Tag);
		}

		private void RefreshData(TreeNode node, object data)
		{
			node.Tag = data;
			node.Name = GetID(node).ToString();
			try
			{
				node.Text = (string) _nameProperty.GetValue(node.Tag);
			}
			catch (Exception e)
			{
				node.Text = e.Message;
			}
			ChangeParent(node);
		}

		private void RefreshData(TreeNode node, int position)
		{
			RefreshData(node, _listManager.List[position]);
		}

		private void RefreshData(int position)
		{
			var dataObject = _listManager.List[position];
			var node = GetDatasNode(dataObject);
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
				finally
				{
					EndSelectionChanging();
				}
			}
		}

		/// <summary>
		/// Create a TreeNode with currency manager and position.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		private TreeNode CreateNode(int position)
		{
			var node = new TreeNode();
			RefreshData(node, position);
			return node;
		}

		private static bool IsIDNull(object id)
		{
			if (id == null
			    || Convert.IsDBNull(id))
				return true;
			if (id.GetType() == typeof (string))
				return (((string) id).Length == 0);
			if (id.GetType() == typeof (Guid))
				return ((Guid) id == Guid.Empty);
			if (id.GetType() == typeof (int))
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
			return HasParent(node, _parentIdProperty.GetValue(node.Tag));
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
	}
}