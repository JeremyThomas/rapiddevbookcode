using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using AW.Winforms.Helpers.Controls;

namespace AW.Winforms.Helpers.DataEditor
{
	public static class DataEditorExtensions
	{
		#region DataGridView

		public static IQueryable ViewInDataGridView(this IQueryable enumerable)
		{
			return ViewInDataGridView(enumerable, 0) as IQueryable;
		}

		public static IEnumerable ViewInDataGridView(this IQueryable enumerable, ushort pageSize)
		{
			return EditInDataGridView(enumerable, null, null, pageSize);
		}

		public static IEnumerable EditInDataGridView(this IEnumerable enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction)
		{
			return EditInDataGridView(enumerable, saveFunction, deleteFunction, 0);
		}

		public static IEnumerable EditInDataGridView(this IEnumerable enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction, ushort pageSize, params Type[] saveableTypes)
		{
			if (enumerable != null)
			{
				CreateDataEditorForm(enumerable, saveFunction, deleteFunction, pageSize, false).ShowDialog();
			}
			return enumerable;
		}

		public static FrmDataEditor CreateDataEditorForm(IEnumerable enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction, ushort pageSize, bool readOnly, params Type[] saveableTypes)
		{
			string text;
			if (enumerable is DataView)
			{
				var dataView = ((DataView)enumerable);
				text = dataView.Table.TableName + " via a DataView";
			}
			else
			{
				text = enumerable.ToString();
			}
			var dataGridView = new FrmDataEditor {Text = text};
			var gridDataEditor = new GridDataEditor {Dock = DockStyle.Fill};
			dataGridView.Controls.Add(gridDataEditor);
			gridDataEditor.SaveableTypes = saveableTypes;
			if (saveFunction != null)
				gridDataEditor.SaveFunction += saveFunction;
			if (deleteFunction != null)
				gridDataEditor.DeleteFunction += deleteFunction;
			gridDataEditor.Readonly = readOnly;
			gridDataEditor.BindEnumerable(enumerable, pageSize);
			return dataGridView;
		}

		public static FrmDataEditor CreateDataViewForm(IEnumerable enumerable)
		{
			return CreateDataEditorForm(enumerable, null, null, 0, true);
		}

		#endregion

		#region DataGridViewGeneric

		public static IQueryable<T> ViewInDataGridView<T>(this IQueryable<T> enumerable)
		{
			return EditInDataGridView(enumerable, null).AsQueryable();
		}

		public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction)
		{
			return EditInDataGridView(enumerable, saveFunction, null);
		}

		public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction)
		{
			return EditInDataGridView(enumerable, saveFunction, deleteFunction, 0);
		}

		public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, Func<object, int> saveFunction, Func<object, int> deleteFunction, ushort pageSize)
		{
			if (enumerable != null)
			{
				var frmDataEditor = new FrmDataEditor {Text = enumerable.ToString()};
				var gridDataEditor = new GridDataEditorT<T> {Dock = DockStyle.Fill};
				frmDataEditor.Controls.Add(gridDataEditor);
				if (saveFunction != null)
					gridDataEditor.SaveFunction += saveFunction;
				if (deleteFunction != null)
					gridDataEditor.DeleteFunction += deleteFunction;
				gridDataEditor.BindEnumerable(enumerable, pageSize);
				frmDataEditor.ShowDialog();
			}
			return enumerable;
		}

		#endregion

		public static IEnumerable<T> EditInDataGridView<T>(this Table<T> enumerable) where T : class
		{
			return EditInDataGridView(enumerable, SubmitChangesToDataContext); 
		}

		/// <param name="aDataContext">A data context.</param>
		/// <returns>The number of persisted entities.</returns>
		public static int SubmitChangesToDataContext(object aDataContext)
		{
			var dataContext = ListBindingHelper.GetList(aDataContext) as DataContext;
			if (dataContext != null)
			{
				dataContext.SubmitChanges();
			}
			return 0;
		}

		public static void CopyEntireDataGridViewToClipboard(this DataGridView dataGridView)
		{
			dataGridView.SelectAll();
			Clipboard.SetDataObject(dataGridView.GetClipboardContent());
		}
	}
}