using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
	public static class LLBLWinformHelper
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Object"/> class.
		/// </summary>
		static LLBLWinformHelper()
		{
			BindingListHelper.RegisterbindingListViewCreater(typeof (IEntity), EntityHelper.CreateEntityView);
			BindingListHelper.RegisterbindingListViewCreater(typeof (IEntity2), EntityHelper.CreateEntityView2);
		}

		/// <summary>
		/// Dummy method which forces the initialization of LLBLWinformHelper via it's static constructor.
		/// </summary>
		public static void ForceInitialization()
		{
		}

		#region Validatation

		public static bool ValidatePropertyAssignment<T>(
			Control controltoValidate,
			int fieldToValidate,
			T value, string errorMessage,
			ErrorProvider myError,
			EntityBase entity)
		{
			var validated = true;
			try
			{
				var validator = entity.Validator;
				if (value.Equals(entity.GetCurrentFieldValue(fieldToValidate)) == false
				    && validator.ValidateFieldValue(entity, fieldToValidate, value) == false
					)
				{
					myError.SetError(controltoValidate, errorMessage);
					validated = false;
				}
				else
					myError.SetError(controltoValidate, "");
			}
			catch (Exception err)
			{
				myError.SetError(controltoValidate, err.Message);
				validated = false;
			}
			return validated;
		}

		public static bool ValidateForm(Control mycontrol, ErrorProvider myError)
		{
			var isValid = true;
			foreach (Control childControl in mycontrol.Controls)
			{
				if (myError.GetError(childControl) != "")
				{
					isValid = false;
					break;
				}
				if (childControl.Controls.Count > 0)
				{
					isValid = ValidateForm(childControl, myError);
					if (isValid == false)
						break;
				}
			}
			return isValid;
		}

		#endregion

		#region Self Servicing

		public class DataEditorLLBLSelfServicingPersister : IDataEditorPersister
		{
			public int Save(object dataToSave)
			{
				return EntityHelper.Save(dataToSave);
			}

			public int Delete(object dataToDelete)
			{
				return EntityHelper.Delete(dataToDelete);
			}

			public bool CanSave(Type typeToSave)
			{
				return typeof (EntityBase).IsAssignableFrom(typeToSave);
			}
		}

		public static IEnumerable<T> ShowSelfServicingInGrid<T>(this IEnumerable<T> enumerable, ushort pageSize) where T : EntityBase
		{
			return enumerable.ShowInGrid(new DataEditorLLBLSelfServicingPersister(), pageSize);
		}

		public static IEnumerable<T> ShowSelfServicingInGrid<T>(this IEnumerable<T> enumerable) where T : EntityBase
		{
			return enumerable.ShowSelfServicingInGrid(DataEditorExtensions.DefaultPageSize);
		}

		public static IEnumerable ShowSelfServicingInGrid(this IEnumerable enumerable, ushort pageSize)
		{
			return enumerable.ShowInGrid(new DataEditorLLBLSelfServicingPersister(), pageSize);
		}

		public static IEnumerable<T> ShowSelfServicingHierarchyInTree<T>(this IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : EntityBase
		{
			return enumerable.ShowHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn, new DataEditorLLBLSelfServicingPersister());
		}

		#endregion

		#region Adapter

		public static IEnumerable ShowInGrid(this IEnumerable enumerable, IDataAccessAdapter dataAccessAdapter, ushort pageSize)
		{
			return enumerable.ShowInGrid(new DataEditorLLBLAdapterPersister(dataAccessAdapter), pageSize);
		}

		public static IEnumerable<T> ShowInGrid<T>(this IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter, ushort pageSize) where T : EntityBase2
		{
			return enumerable.ShowInGrid(new DataEditorLLBLAdapterPersister(dataAccessAdapter), pageSize);
		}

		public static IEnumerable<T> ShowAdapterInGrid<T>(this IQueryable<T> query, ushort pageSize) where T : EntityBase2
		{
			return ShowInGrid(query, EntityHelper.GetDataAccessAdapter(query), pageSize);
		}

		public static IEnumerable<T> ShowAdapterInGrid<T>(this IQueryable<T> query) where T : EntityBase2
		{
			return ShowAdapterInGrid(query, DataEditorExtensions.DefaultPageSize);
		}

		public static IEnumerable<T> ShowHierarchyInTree<T>(this IEnumerable<T> enumerable, IDataAccessAdapter dataAccessAdapter, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : EntityBase2
		{
			return enumerable.ShowHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn, new DataEditorLLBLAdapterPersister(dataAccessAdapter));
		}

		public static IEnumerable<T> ShowAdapterHierarchyInTree<T>(this IQueryable<T> query, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : EntityBase2
		{
			return query.ShowHierarchyInTree(EntityHelper.GetDataAccessAdapter(query), iDPropertyName, parentIDPropertyName, nameColumn);
		}

		public class DataEditorLLBLAdapterPersister : IDataEditorPersister
		{
			private readonly IDataAccessAdapter _dataAccessAdapter;

			public DataEditorLLBLAdapterPersister(IDataAccessAdapter dataAccessAdapter)
			{
				_dataAccessAdapter = dataAccessAdapter;
			}

			public int Save(object dataToSave)
			{
				return EntityHelper.Save(dataToSave, _dataAccessAdapter);
			}

			public int Delete(object dataToDelete)
			{
				return EntityHelper.Delete(dataToDelete, _dataAccessAdapter);
			}

			public bool CanSave(Type typeToSave)
			{
				return typeof (EntityBase2).IsAssignableFrom(typeToSave);
			}
		}

		#endregion

		public static void PopulateTreeViewWithSchema(TreeView entityTreeView, IEnumerable<Type> entitiesTypes)
		{
			entityTreeView.Nodes.Clear();
			PopulateTreeViewWithSchema(entityTreeView.Nodes, entitiesTypes);
		}

		public static void PopulateTreeViewWithSchema(TreeNodeCollection schemaTreeNodeCollection, IEnumerable<Type> entitiesTypes)
		{
			foreach (var entityType in entitiesTypes.OrderBy(t => t.Name).ToList())
			{
				var entityNode = schemaTreeNodeCollection.Add(entityType.Name, entityType.Name.Replace("Entity", ""));
				entityNode.Tag = entityType;
				foreach (var browsableProperty in ListBindingHelper.GetListItemProperties(entityType).Cast<PropertyDescriptor>().
					Where(p => !typeof (IList).IsAssignableFrom(p.PropertyType)).OrderBy(p => p.Name))
					// All browseable properties that aren't a list
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

				foreach (var entityTypeProperty in EntityHelper.GetPropertiesOfTypeEntity(entityType))
					//All selfservicing entity types
				{
					var fieldNode = entityNode.Nodes.Add(entityTypeProperty.Name);

					fieldNode.ImageIndex = 3;
					fieldNode.Tag = entityTypeProperty;
				}

				foreach (var browsableProperty in ListBindingHelper.GetListItemProperties(entityType).Cast<PropertyDescriptor>().
					Where(p => typeof (IList).IsAssignableFrom(p.PropertyType)).OrderBy(p => p.Name))
					// All browseable list properties
				{
					var fieldNode = entityNode.Nodes.Add(browsableProperty.Name);
					fieldNode.Tag = browsableProperty;
					fieldNode.ImageIndex = 2;
				}
			}
		}

		public static void BrowseData(this ILinqMetaData linqMetaData)
		{
			FrmEntitiesAndFields.ShowEntitiesAndFields(linqMetaData, null);
		}
	}
}