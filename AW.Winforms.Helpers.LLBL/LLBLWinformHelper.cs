using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers.LLBL
{
	public static class LLBLWinformHelper
	{
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

			public int Delete(object dataToSave)
			{
				return EntityHelper.Delete(dataToSave);
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

			public int Delete(object dataToSave)
			{
				return EntityHelper.Delete(dataToSave, _dataAccessAdapter);
			}

			public bool CanSave(Type typeToSave)
			{
				return typeof (EntityBase2).IsAssignableFrom(typeToSave);
			}
		}

		#endregion
	}
}