using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.Properties;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.EntityViewer
{
	public partial class FrmEntitiesAndFields: Form
	{
		private static FrmEntitiesAndFields _formSingleton;
		private readonly Type _baseType;
		private readonly Assembly _entityAssembly;

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

		public static void ShowEntitiesAndFields(Type baseType)
		{
			ShowEntitiesAndFields(baseType, null);
		}

		public static void ShowEntitiesAndFields(Type baseType, Form parent)
		{
			if (_formSingleton == null)
				_formSingleton = new FrmEntitiesAndFields(baseType);
			_formSingleton.WindowState = FormWindowState.Normal;
			if (parent == null)
				_formSingleton.ShowDialog();
			else
			{
				_formSingleton.Parent = parent;
				_formSingleton.Show();
			}
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

				foreach (var browsableProperty in ListBindingHelper.GetListItemProperties(entityType).Cast<PropertyDescriptor>().
					Where(p => !typeof (IList).IsAssignableFrom(p.PropertyType)).OrderBy(p => p.Name))
				{
					var fieldNode = entityNode.Nodes.Add(browsableProperty.Name);
					if (typeof(IEntityCore).IsAssignableFrom(browsableProperty.PropertyType))
					{
						fieldNode.ImageIndex = 3;
						fieldNode.Tag = browsableProperty;
					}
					else
						fieldNode.ImageIndex = 1;
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

		public IEnumerable<Type> GetEntitiesTypes()
		{
			if (_baseType != null)
				return MetaDataHelper.GetDescendance(_baseType);
			if (_entityAssembly == null)
				return MetaDataHelper.GetAllLoadedDescendance(typeof (EntityBase));
			return MetaDataHelper.GetDescendance(typeof (EntityBase), _entityAssembly.GetExportedTypes());
		}

		private void treeViewEntities_ItemDrag(object sender, ItemDragEventArgs e)
		{
			DoDragDrop(((TreeNode)e.Item).Text, DragDropEffects.All);
		}

		private void treeViewEntities_Click(object sender, EventArgs e)
		{
		}

		private void treeViewEntities_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var prop = treeViewEntities.SelectedNode.Tag as PropertyDescriptor;
			if (prop != null)
			{
				var typeParameter = MetaDataHelper.GetTypeParameterOfGenericType(prop.PropertyType);
				if (typeParameter != null)

					if (treeViewEntities.Nodes.ContainsKey(typeParameter.Name))
					{
						treeViewEntities.SelectedNode = treeViewEntities.Nodes[typeParameter.Name];
						treeViewEntities.SelectedNode.Expand();
					}
			}
			toolStripStatusLabelSelected.Text = treeViewEntities.SelectedNode.Text;
		}
	}
}