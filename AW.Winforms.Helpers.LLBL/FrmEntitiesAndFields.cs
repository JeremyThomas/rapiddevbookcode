using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.LLBL.Properties;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
	public partial class FrmEntitiesAndFields: Form
	{
		private static FrmEntitiesAndFields _formSingleton;
		private readonly Type _baseType;
		private readonly Assembly _entityAssembly;
		private readonly ILinqMetaData _linqMetaData;
		private IDataAccessAdapter _dataAccessAdapter;

		public FrmEntitiesAndFields()
		{
			InitializeComponent();
		}

		public FrmEntitiesAndFields(Assembly entityAssembly): this()
		{
			_entityAssembly = entityAssembly;
		}

		public FrmEntitiesAndFields(Type baseType): this(baseType.Assembly)
		{
			_baseType = baseType;
		}

		public FrmEntitiesAndFields(Type baseType, ILinqMetaData linqMetaData): this(baseType)
		{
			_baseType = baseType;
			_linqMetaData = linqMetaData;
		}

		public static void ShowEntitiesAndFields(Type baseType, ILinqMetaData linqMetaData)
		{
			ShowEntitiesAndFields(baseType, linqMetaData, null);
		}

		public static void ShowEntitiesAndFields(Type baseType)
		{
			ShowEntitiesAndFields(baseType, null, null);
		}

		public static void ShowEntitiesAndFields(Type baseType, ILinqMetaData linqMetaData, Form parent)
		{
			if (_formSingleton == null)
				_formSingleton = new FrmEntitiesAndFields(baseType, linqMetaData);
			AWHelper.ShowFormModalIfParentLess(_formSingleton, parent);
		}

		private void FrmEntitiesAndFields_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.EntitiesAndFieldsSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
			Settings.Default.Save();
		}

		private void EntitiesAndFields_Load(object sender, EventArgs e)
		{
			AWHelper.SetWindowSizeAndLocation(this, Settings.Default.EntitiesAndFieldsSizeLocation);
			treeViewEntities.Nodes.Clear();
			foreach (var entityType in GetEntitiesTypes().OrderBy(t => t.Name))
			{
				var entityNode = treeViewEntities.Nodes.Add(entityType.Name, entityType.Name.Replace("Entity", ""));
				entityNode.Tag = entityType;
				foreach (var browsableProperty in ListBindingHelper.GetListItemProperties(entityType).Cast<PropertyDescriptor>().
					Where(p => !typeof (IList).IsAssignableFrom(p.PropertyType)).OrderBy(p => p.Name))
				{
					var fieldNode = entityNode.Nodes.Add(browsableProperty.Name);
					if (typeof (IEntityCore).IsAssignableFrom(browsableProperty.PropertyType))
					{
						fieldNode.ImageIndex = 3;
						fieldNode.Tag = browsableProperty;
					}
					else
						fieldNode.ImageIndex = 1;
				}

				foreach (var entityTypeProperty in GetPropertiesOfTypeEntity(entityType))
				{
					var fieldNode = entityNode.Nodes.Add(entityTypeProperty.Name);

					fieldNode.ImageIndex = 3;
					fieldNode.Tag = entityTypeProperty;
				}

				foreach (var browsableProperty in ListBindingHelper.GetListItemProperties(entityType).Cast<PropertyDescriptor>().
					Where(p => typeof (IList).IsAssignableFrom(p.PropertyType)).OrderBy(p => p.Name))
				{
					var fieldNode = entityNode.Nodes.Add(browsableProperty.Name);
					fieldNode.Tag = browsableProperty;
					fieldNode.ImageIndex = 2;
				}
			}
		}

		/// <summary>
		/// Gets the properties of type entity since for selfservicing these properties are not browsable so they need to be handled as a special case.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns></returns>
		public static IEnumerable<PropertyDescriptor> GetPropertiesOfTypeEntity(Type type)
		{
			return from propertyDescriptor in TypeDescriptor.GetProperties(type, null).Cast<PropertyDescriptor>()
			       where typeof (IEntity).IsAssignableFrom(propertyDescriptor.PropertyType)
			       select propertyDescriptor;
		}

		public IEnumerable<Type> GetEntitiesTypes()
		{
			if (_baseType != null)
				return MetaDataHelper.GetDescendance(_baseType);
			return _entityAssembly == null ? MetaDataHelper.GetAllLoadedDescendance(typeof (IEntityCore)) : typeof (IEntityCore).GetAssignable(_entityAssembly.GetExportedTypes());
		}

		private void treeViewEntities_ItemDrag(object sender, ItemDragEventArgs e)
		{
			DoDragDrop(((TreeNode)e.Item).Text, DragDropEffects.All);
		}

		private void treeViewEntities_AfterSelect(object sender, TreeViewEventArgs e)
		{
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
			toolStripStatusLabelSelected.Text = treeViewEntities.SelectedNode.Text;
		}

		private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
		{
			var typeOfEntity = treeViewEntities.SelectedNode.Tag as Type;
			if (typeOfEntity != null && _linqMetaData != null)
			{
				var dataSource = _linqMetaData.GetQueryableForEntity(EntityHelper.GetEntityTypeValueForType(typeOfEntity));
				var entityQueryable = dataSource as IQueryable;
				if (typeof (IEntity).IsAssignableFrom(typeOfEntity))
					entityQueryable.EditInDataGridViewx(EntityHelper.Save);
				else
				{
					var provider = dataSource.Provider as LLBLGenProProvider2;
					if (provider == null)
						entityQueryable.ViewInDataGridViewx();
					else
					{
						_dataAccessAdapter = provider.AdapterToUse;
						entityQueryable.EditInDataGridViewx(Save);
					}
				}
			}
		}

		public int Save(object dataToSave)
		{
			return EntityHelper.Save(dataToSave, _dataAccessAdapter);
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
	}
}