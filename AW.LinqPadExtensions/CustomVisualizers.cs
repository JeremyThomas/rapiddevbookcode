using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.DataEditor;
using LINQPad;

namespace AW.LinqPadExtensions
{
	public static class CustomVisualizers
	{
		#region DataGridView

		/// <summary>
		/// 10
		/// </summary>
		public const int DefaultPageSize = 10;

		/// <summary>
		/// Displays the enumerable in a paged DataGridView Custom Visualizer.
		/// </summary>
		/// <param name="enumerable">The enumerable.</param>
		/// <returns></returns>
		public static IEnumerable DisplayInGrid(this IEnumerable enumerable)
		{
			return DisplayInGrid(enumerable, DefaultPageSize);
		}

		/// <summary>
		/// Displays the enumerable in a paged DataGridView Custom Visualizer.
		/// </summary>
		/// <param name="enumerable">The enumerable.</param>
		/// <param name="pageSize">Size of the page.</param>
		/// <returns></returns>
		public static IEnumerable DisplayInGrid(this IEnumerable enumerable, ushort pageSize)
		{
			return DisplayInGrid(enumerable, null, pageSize);
		}

		/// <summary>
		/// Displays the enumerable in a paged DataGridView Custom Visualizer.
		/// </summary>
		/// <param name="enumerable">The enumerable.</param>
		/// <param name="dataEditorPersister">The data editor persister.</param>
		/// <returns></returns>
		public static IEnumerable DisplayInGrid(this IEnumerable enumerable, IDataEditorPersister dataEditorPersister)
		{
			return DisplayInGrid(enumerable, dataEditorPersister, DefaultPageSize);
		}

		/// <summary>
		/// Displays the enumerable in a paged DataGridView Custom Visualizer.
		/// </summary>
		/// <param name="enumerable">The enumerable.</param>
		/// <param name="dataEditorPersister">The data editor persister.</param>
		/// <param name="pageSize">Size of the page.</param>
		/// <returns></returns>
		public static IEnumerable DisplayInGrid(this IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize)
		{
			if (enumerable != null)
				PanelManager.DisplayControl(new GridDataEditor(enumerable, dataEditorPersister, pageSize, false));
			return Enumerable.Empty<object>(); //So can be used in a linqpad expression
		}

		#endregion

		#region DataGridViewGeneric

		/// <summary>
		/// Displays the enumerable in a paged DataGridView Custom Visualizer.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="enumerable">The enumerable.</param>
		/// <returns></returns>
		public static IEnumerable<T> DisplayInGrid<T>(this IEnumerable<T> enumerable)
		{
			if (enumerable != null)
			{
				var contextField = enumerable.GetType().GetField("context", BindingFlags.Instance | BindingFlags.NonPublic);
				if (contextField != null)
				{
					var queryContext = contextField.GetValue(enumerable) as DataContext;
					if (queryContext != null)
						return DisplayInGrid(enumerable, queryContext);
				}
				return DisplayInGrid(enumerable, (IDataEditorPersister)null);
			}
			return null;
		}

		/// <summary>
		/// Displays the enumerable in a paged DataGridView Custom Visualizer.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="enumerable">The enumerable.</param>
		/// <param name="dataEditorPersister">The data editor persister.</param>
		/// <returns></returns>
		public static IEnumerable<T> DisplayInGrid<T>(this IEnumerable<T> enumerable, IDataEditorPersister dataEditorPersister)
		{
			return DisplayInGrid(enumerable, dataEditorPersister, DefaultPageSize);
		}

		/// <summary>
		/// Displays the enumerable in a paged DataGridView Custom Visualizer.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="enumerable">The enumerable.</param>
		/// <param name="dataEditorPersister">The data editor persister.</param>
		/// <param name="pageSize">Size of the page.</param>
		/// <returns></returns>
		public static IEnumerable<T> DisplayInGrid<T>(this IEnumerable<T> enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize)
		{
			if (enumerable != null)
				PanelManager.DisplayControl(GridDataEditorT<T>.GridDataEditorFactory(enumerable, dataEditorPersister, pageSize, false));
			return Enumerable.Empty<T>(); //So can be used in a linqpad expression
		}

		#endregion

		#region LinqtoSQL

		public static IEnumerable<T> DisplayInGrid<T>(this Table<T> table) where T : class
		{
			return DisplayInGrid(table, DataEditorExtensions.DefaultPageSize);
		}

		public static IEnumerable<T> DisplayInGrid<T>(this Table<T> table, ushort pageSize) where T : class
		{
			return DisplayInGrid(table, table.Context, pageSize);
		}

		public static IEnumerable<T> DisplayInGrid<T>(this IEnumerable<T> dataQuery, DataContext dataContext)
		{
			return DisplayInGrid(dataQuery, dataContext, DataEditorExtensions.DefaultPageSize);
		}

		/// <summary>
		/// 	Edits the DataQuery in a DataGridView.
		/// </summary>
		/// <typeparam name = "T"></typeparam>
		/// <param name = "dataQuery">The data query (System.Data.Linq.DataQuery`1).</param>
		/// <param name = "dataContext">The data context.</param>
		/// <param name = "pageSize">Size of the page.</param>
		/// <returns></returns>
		public static IEnumerable<T> DisplayInGrid<T>(this IEnumerable<T> dataQuery, DataContext dataContext, ushort pageSize)
		{
			return DisplayInGrid(dataQuery, new DataEditorLinqtoSQLPersister(dataContext), pageSize);
		}

		//public static IEnumerable<T> ShowHierarchyInTree<T>(this Table<T> table, string iDPropertyName, string parentIDPropertyName, string nameColumn) where T : class
		//{
		//  return table.ShowHierarchyInTree(table.Context, iDPropertyName, parentIDPropertyName, nameColumn);
		//}

		//public static IEnumerable<T> ShowHierarchyInTree<T>(this IEnumerable<T> enumerable, DataContext dataContext, string iDPropertyName, string parentIDPropertyName, string nameColumn)
		//{
		//  return enumerable.ShowHierarchyInTree(iDPropertyName, parentIDPropertyName, nameColumn, new DataEditorLinqtoSQLPersister(dataContext));
		//}

		#endregion

		//public static IEnumerable<T> DisplayHierarchyInTree<T>(this IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn)
		//{
		//  return DisplayHierarchyInTree(enumerable, iDPropertyName, parentIDPropertyName, nameColumn, null);
		//}

		//public static IEnumerable<T> DisplayHierarchyInTree<T>(this IEnumerable<T> enumerable, string iDPropertyName, string parentIDPropertyName, string nameColumn, IDataEditorPersister dataEditorPersister)
		//{
		//  if (enumerable != null)
		//    PanelManager.DisplayControl(new FrmHierarchyEditor(enumerable, iDPropertyName, parentIDPropertyName, nameColumn, dataEditorPersister));
		//  return enumerable;
		//}
	}
}