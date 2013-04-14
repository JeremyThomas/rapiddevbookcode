using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AW.Winforms.Helpers.Controls;

namespace AW.Winforms.Helpers.DataEditor
{
	public partial class FrmDataEditor : FrmPersistantLocation
	{
		public FrmDataEditor()
		{
			InitializeComponent();
		}

		public static string GetEnumerableDescription(IEnumerable enumerable)
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

		public static Form CreateDataViewForm(IEnumerable enumerable)
		{
			return CreateDataEditorForm(enumerable, null, DataEditorExtensions.DefaultPageSize, true);
		}

		public static Form CreateDataEditorForm(IEnumerable enumerable, IDataEditorPersister dataEditorPersister,ushort pageSize)
		{
			return CreateDataEditorForm(enumerable, dataEditorPersister, pageSize, false);
		}

		public static Form CreateDataEditorForm(IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
		{
			return InitialiseDataEditorForm(new FrmDataEditor(), enumerable, dataEditorPersister, pageSize, readOnly);
		}

		private static Form InitialiseDataEditorForm(Form frmDataEditor, IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
		{
			frmDataEditor.Text = GetEnumerableDescription(enumerable);
			var gridDataEditor = new GridDataEditor(enumerable, dataEditorPersister, pageSize, readOnly){Dock = DockStyle.Fill};
			frmDataEditor.Controls.Add(gridDataEditor);
			return frmDataEditor;
		}

		public static Form CreateDataEditorForm<T>(IEnumerable<T> enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
		{
			return InitialiseDataEditorForm(new FrmDataEditor(), enumerable, dataEditorPersister, pageSize, readOnly);
		}

		private static Form InitialiseDataEditorForm<T>(Form frmDataEditor, IEnumerable<T> enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
		{
			frmDataEditor.Text = GetEnumerableDescription(enumerable);
			var gridDataEditor = GridDataEditorT<T>.GridDataEditorFactory(enumerable, dataEditorPersister, pageSize, readOnly);
			gridDataEditor.Dock = DockStyle.Fill;
			frmDataEditor.Controls.Add(gridDataEditor);
			return frmDataEditor;
		}
	}
}