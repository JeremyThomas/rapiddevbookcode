using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AW.Helper;
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
			return CreateDataEditorForm(enumerable, new GridDataEditor {Dock = DockStyle.Fill}, null, DataEditorExtensions.DefaultPageSize, true);
		}

		public static Form CreateDataEditorForm(IEnumerable enumerable, GridDataEditor gridDataEditor, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
		{
			return InitialiseDataEditorForm(new FrmDataEditor(), enumerable, gridDataEditor, dataEditorPersister, pageSize, readOnly);
		}

		public static Form InitialiseDataEditorForm(Form frmDataEditor, IEnumerable enumerable, GridDataEditor gridDataEditor, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
		{
			frmDataEditor.Text = GetEnumerableDescription(enumerable);
			if (ValueTypeWrapper.TypeNeedsWrappingForBinding(MetaDataHelper.GetEnumerableItemType(enumerable)))
			{
				enumerable = ValueTypeWrapper.CreateWrapperForBinding(enumerable);
				readOnly = true;
			}
			frmDataEditor.Controls.Add(gridDataEditor);
			gridDataEditor.DataEditorPersister = dataEditorPersister;
			gridDataEditor.Readonly = readOnly;
			gridDataEditor.BindEnumerable(enumerable, pageSize);
			return frmDataEditor;
		}
	}
}