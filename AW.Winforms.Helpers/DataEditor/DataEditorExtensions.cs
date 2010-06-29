using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.Controls;

namespace AW.Winforms.Helpers.DataEditor
{
	public static class DataEditorExtensions
	{
		public const int DefaultPageSize = 30;

		#region DataGridView

		public static IQueryable ViewInDataGridView(this IQueryable enumerable)
		{
			return ViewInDataGridView(enumerable, DefaultPageSize) as IQueryable;
		}

		public static IEnumerable ViewInDataGridView(this IQueryable enumerable, ushort pageSize)
		{
			return EditInDataGridView(enumerable, null, pageSize);
		}

		public static IEnumerable EditInDataGridView(this IEnumerable enumerable, IDataEditorPersister dataEditorPersister)
		{
			return EditInDataGridView(enumerable, dataEditorPersister, DefaultPageSize);
		}

		public static IEnumerable EditInDataGridView(this IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize)
		{
			if (enumerable != null)
				CreateDataEditorForm(enumerable, dataEditorPersister, pageSize, false).ShowDialog();
			return enumerable;
		}

		public static Form CreateDataEditorForm(IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
		{
			string text = GetEnumerableDescription(enumerable);
			return InitialiseDataEditorForm(new FrmDataEditor(), enumerable, text, dataEditorPersister, readOnly, pageSize);
		}

		private static string GetEnumerableDescription(IEnumerable enumerable)
		{
			string text;
			if (enumerable is DataView)
			{
				var dataView = ((DataView) enumerable);
				text = dataView.Table.TableName + " via a DataView";
			}
			else
				text = enumerable.ToString();
			return text;
		}

		private static Form InitialiseDataEditorForm(Form frmDataEditor, IEnumerable enumerable, string formTitle, IDataEditorPersister dataEditorPersister, bool readOnly, ushort pageSize)
		{
			return InitialiseDataEditorForm(frmDataEditor, enumerable, new GridDataEditor { Dock = DockStyle.Fill }, formTitle, dataEditorPersister, readOnly, pageSize);
		}

		private static Form InitialiseDataEditorForm(Form frmDataEditor, IEnumerable enumerable, GridDataEditor gridDataEditor, string formTitle, IDataEditorPersister dataEditorPersister, bool readOnly, ushort pageSize)
		{
			frmDataEditor.Text = formTitle;
			frmDataEditor.Controls.Add(gridDataEditor);
			gridDataEditor.DataEditorPersister = dataEditorPersister;
			gridDataEditor.Readonly = readOnly;
			gridDataEditor.BindEnumerable(enumerable, pageSize);
			return frmDataEditor;
		}

		public static Form CreateDataViewForm(IEnumerable enumerable)
		{
			return CreateDataEditorForm(enumerable, null, DefaultPageSize, true);
		}

		#endregion

		#region DataGridViewGeneric

		public static IQueryable<T> ViewInDataGridView<T>(this IQueryable<T> enumerable)
		{
			return EditInDataGridView((IEnumerable<T>) enumerable, null).AsQueryable();
		}

		public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, IDataEditorPersister dataEditorPersister)
		{
			return EditInDataGridView(enumerable, dataEditorPersister, DefaultPageSize);
		}

		/// <summary>
		/// Edits the enumerable in a DataGridView.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="enumerable">The enumerable.</param>
		/// <param name="dataEditorPersister">The grid data editor persister.</param>
		/// <param name="pageSize">Size of the page.</param>
		/// <returns></returns>
		public static IEnumerable<T> EditInDataGridView<T>(this IEnumerable<T> enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize)
		{
			if (enumerable != null)
				if (typeof (T) == typeof (string))
					((IEnumerable<string>) enumerable).CreateStringWrapperForBinding().EditInDataGridView(dataEditorPersister, pageSize);
				else
				{
					InitialiseDataEditorForm(new FrmDataEditor(), enumerable, new GridDataEditorT<T> {Dock = DockStyle.Fill}, enumerable.ToString(), dataEditorPersister, false, pageSize).ShowDialog();
				}
			return enumerable;
		}

		#endregion

		#region LinqtoSQL

		public static IEnumerable<T> EditInDataGridView<T>(this Table<T> table) where T : class
		{
			return EditInDataGridView(table, DefaultPageSize);
		}

		public static IEnumerable<T> EditInDataGridView<T>(this Table<T> table, ushort pageSize) where T : class
		{
			return EditInDataGridView(table, table.Context, pageSize);
		}

		public static IEnumerable<T> EditInDataGridView<T>(this IQueryable<T> dataQuery, DataContext dataContext) where T : class
		{
			return EditInDataGridView(dataQuery, dataContext, DefaultPageSize);
		}

		/// <summary>
		/// Edits the DataQuery in a DataGridView.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="dataQuery">The data query (System.Data.Linq.DataQuery`1).</param>
		/// <param name="dataContext">The data context.</param>
		/// <param name="pageSize">Size of the page.</param>
		/// <returns></returns>
		public static IEnumerable<T> EditInDataGridView<T>(this IQueryable<T> dataQuery, DataContext dataContext, ushort pageSize) where T : class
		{
			return EditInDataGridView(dataQuery, new DataEditorLinqtoSQLPersister(dataContext), pageSize);
		}

		public class DataEditorLinqtoSQLPersister : IDataEditorPersister
		{
			private readonly DataContext _dataContext;

			public DataEditorLinqtoSQLPersister(DataContext dataContext)
			{
				_dataContext = dataContext;
			}

			public int Save(object dataToSave)
			{
				var changeSet = _dataContext.GetChangeSet();
				_dataContext.SubmitChanges();
				return changeSet.Inserts.Count + changeSet.Updates.Count;
			}

			public int Delete(object dataToSave)
			{
				_dataContext.SubmitChanges();
				return _dataContext.GetChangeSet().Deletes.Count;
			}

			public bool CanSave(Type typeToSave)
			{
				return true;
			}
		}

		public static IEnumerable<T> ShowHierarchyInTree<T>(this Table<T> table, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : class
		{
			return table.ShowHierarchyInTree(table.Context, iDPropertyName, parentIDPropertyName, nameColumn);
		}

		public static IEnumerable<T> ShowHierarchyInTree<T>(this IEnumerable<T> enumerable, DataContext dataContext, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : class
		{
			return enumerable.ShowHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn, new DataEditorLinqtoSQLPersister(dataContext));
		}

		#endregion

		public static void CopyEntireDataGridViewToClipboard(this DataGridView dataGridView)
		{
			dataGridView.SelectAll();
			Clipboard.SetDataObject(dataGridView.GetClipboardContent());
		}

		public static IEnumerable<T> ShowHierarchyInTree<T>(this IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn)
		{
			return ShowHierarchyInTree(enumerable, iDPropertyName, parentIDPropertyName, nameColumn, null);
		}

		public static IEnumerable<T> ShowHierarchyInTree<T>(this IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn, IDataEditorPersister dataEditorPersister)
		{
			FrmHierarchyEditor.LaunchForm(enumerable, iDPropertyName, parentIDPropertyName, nameColumn, dataEditorPersister);
			return enumerable;
		}
	}
}