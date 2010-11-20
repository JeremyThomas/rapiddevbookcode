﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Helper.LLBL;
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
			LLBLWinformHelper.PopulateTreeViewWithSchema(treeViewEntities, GetEntitiesTypes());
		}

		public FrmEntitiesAndFields(Type baseType) : this()
		{
			_baseType = baseType;
		}

		public FrmEntitiesAndFields(ILinqMetaData linqMetaData): this()
		{
			_linqMetaData = linqMetaData;
		}

		public static void ShowEntitiesAndFields(Type baseType, Form parent)
		{
			if (_formSingleton == null || _formSingleton.contextMenuStrip1.InvokeRequired)
				_formSingleton = new FrmEntitiesAndFields(baseType);
			AWHelper.ShowForm(_formSingleton, parent);
		}

		public static void ShowEntitiesAndFields(ILinqMetaData linqMetaData, Form parent)
		{
			if (_formSingleton == null || _formSingleton.contextMenuStrip1.InvokeRequired)
				_formSingleton = new FrmEntitiesAndFields(linqMetaData);
			AWHelper.ShowForm(_formSingleton, parent);
		}

		#region Overrides of FrmPersistantLocation

		protected override void RestoreWindowSettings()
		{
			if (!DesignMode)
				if (!splitContainerVertical.Panel2Collapsed)
				{
					splitContainerVertical.Panel2Collapsed = true;
					base.RestoreWindowSettings();
					splitContainerVertical.Width = ClientSize.Width;
					//splitContainerVertical.Width = splitContainerVertical.SplitterDistance;
					SetClientSizeCore(splitContainerVertical.SplitterDistance, ClientSize.Height);
					if (splitContainerVertical.Width > splitContainerVertical.SplitterDistance)
						((Panel) splitContainerVertical.Panel2).Width = splitContainerVertical.Width - splitContainerVertical.SplitterDistance - splitContainerVertical.SplitterWidth;
				}
		}

		#endregion

		private void EntitiesAndFields_Load(object sender, EventArgs e)
		{
			gridDataEditor.bindingSourceEnumerable.CurrentChanged += bindingSourceEnumerable_CurrentChanged;	
		}

		public IEnumerable<Type> GetEntitiesTypes()
		{
			if (_baseType != null)
				return EntityHelper.GetEntitiesTypes(_baseType);
			return _linqMetaData == null ? EntityHelper.GetEntitiesTypes() : EntityHelper.GetEntitiesTypes(_linqMetaData);
		}

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
				Open(30);
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
			var typeOfEntity = treeViewEntities.SelectedNode.Tag as Type;
			IQueryable entityQueryable = null;
			if (typeOfEntity != null && _linqMetaData != null)
			{
				var dataSource = _linqMetaData.GetQueryableForEntity(typeOfEntity);
				entityQueryable = dataSource as IQueryable;
			}
			return entityQueryable;
		}

		private void ViewEntities(IQueryable entityQueryable, ushort pageSize)
		{
			if (splitContainerVertical.Panel2Collapsed)
				ExpandRightPanel();
			gridDataEditor.BindEnumerable(entityQueryable, pageSize);
			if (gridDataEditor.DataEditorPersister == null)
				if (typeof (IEntity).IsAssignableFrom(entityQueryable.ElementType))
					gridDataEditor.DataEditorPersister = new LLBLWinformHelper.DataEditorLLBLSelfServicingPersister();
				else
				{
					var provider = entityQueryable.Provider as LLBLGenProProvider2;
					if (provider != null)
						gridDataEditor.DataEditorPersister = new LLBLWinformHelper.DataEditorLLBLAdapterPersister(provider.AdapterToUse);
				}
		}

		private void openPaged20ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Open(30);
		}

		private void getCountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var entityQueryable = GetEntityQueryable();
			if (entityQueryable != null)
				toolStripStatusLabelSelected.Text = entityQueryable.Count().ToString();
		}

		private void treeViewEntities_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (!e.Node.IsExpanded)
				toolStripMenuItemOpen_Click(sender, e);
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
	}
}