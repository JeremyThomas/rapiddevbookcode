﻿using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.Properties;

namespace AW.Winforms.Helpers.DataEditor
{
	public partial class FrmDataEditor : Form
	{
		public FrmDataEditor()
		{
			InitializeComponent();
			AWHelper.SetWindowSizeAndLocation(this, Settings.Default.EntityViewerSizeLocation);
		}

		private void FrmDataEditor_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.EntityViewerSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
			Settings.Default.Save();
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
			return CreateDataEditorForm(enumerable, new GridDataEditor { Dock = DockStyle.Fill }, null, DataEditorExtensions.DefaultPageSize, true);
		}

		public static Form CreateDataEditorForm(IEnumerable enumerable, GridDataEditor gridDataEditor, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
		{
			return InitialiseDataEditorForm(new FrmDataEditor(), enumerable, gridDataEditor, dataEditorPersister, pageSize, readOnly);
		}

		public static Form InitialiseDataEditorForm(Form frmDataEditor, IEnumerable enumerable, GridDataEditor gridDataEditor, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
		{
			frmDataEditor.Text = GetEnumerableDescription(enumerable);
			if (enumerable is IEnumerable<string>)
			{
				enumerable = ((IEnumerable<string>) enumerable).CreateStringWrapperForBinding();
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