﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;
using System.Linq;
using System.Linq.Dynamic;
using System.Reflection;
using System.Windows.Forms;
using AW.Helper;
using AW.Winforms.Helpers.DataEditor;
using DynamicTable;
using JesseJohnston;

namespace AW.Winforms.Helpers.Controls
{
	public partial class GridDataEditor : UserControl
	{
		private readonly ArrayList _deleteItems = new ArrayList();
		private bool _binding = true;
		private bool _loaded;
		private bool _canSave;
		private IQueryable _superset;
		public IDataEditorPersister DataEditorPersister;
		private static FieldsToPropertiesTypeDescriptionProvider _fieldsToPropertiesTypeDescriptionProvider;

		public GridDataEditor()
		{
			InitializeComponent();
			dataGridViewEnumerable.AutoGenerateColumns = true;
		}

		#region Properties

		[Category("Data"),
		 Description("Size of the page")]
		public ushort PageSize { get; set; }

		[AttributeProvider(typeof (IListSource)),
		 Category("Data"),
		 Description("Data source of the tree.")]
		public object DataSource
		{
			get { return bindingSourceEnumerable.DataSource; }
			set
			{
				if (bindingSourceEnumerable.DataSource != value)
					bindingSourceEnumerable.DataSource = value;
			}
		}

		[Editor("System.Windows.Forms.Design.DataMemberListEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor)),
		 RefreshProperties(RefreshProperties.Repaint),
		 Category("Data"),
		 Description("Data member of the tree.")]
		public string DataMember
		{
			get { return bindingSourceEnumerable.DataMember; }
			set
			{
				if (bindingSourceEnumerable.DataMember != value)
					bindingSourceEnumerable.DataMember = value;
			}
		}

		[Description("ToolStripItemsDescr"), MergableProperty(false), Category("CatData"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ToolStripItemCollection Items
		{
			get { return BindingNavigator.Items; }
		}

		public BindingNavigator BindingNavigator
		{
			get { return bindingNavigator1; }
		}

		public BindingSource BindingSource
		{
			get { return bindingSourceEnumerable; }
		}

		public bool Readonly { get; set; }

		#endregion

		private void printToolStripButton_Click(object sender, EventArgs e)
		{
			var frm = new FrmReportViewer {WindowState = FormWindowState.Normal};
			frm.OpenDataSet(bindingSourceEnumerable, false);
			frm.Show();
		}

		private void copyToolStripButton_Click(object sender, EventArgs e)
		{
			dataGridViewEnumerable.CopyEntireDataGridViewToClipboard();
		}

		private void toolStripComboBoxClipboardCopyMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridViewEnumerable.ClipboardCopyMode = (DataGridViewClipboardCopyMode) toolStripComboBoxClipboardCopyMode.SelectedItem;
		}

		private void GridDataEditor_Load(object sender, EventArgs e)
		{
			var dataGridViewScriptClipboardCopyMode = dataGridViewEnumerable.ClipboardCopyMode;
			if (toolStripComboBoxClipboardCopyMode.ComboBox != null) toolStripComboBoxClipboardCopyMode.ComboBox.DataSource = Enum.GetValues(typeof (DataGridViewClipboardCopyMode));
			toolStripComboBoxClipboardCopyMode.SelectedItem = dataGridViewScriptClipboardCopyMode;
			_loaded = true;
		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{
			dataGridViewEnumerable.EndEdit();
			var numSaved = DataEditorPersister.Save(bindingSourceEnumerable.List);
			toolStripLabelSaveResult.Text = @"numSaved: " + numSaved;
			if (_deleteItems != null && _deleteItems.Count > 0)
			{
				var numDeleted = DataEditorPersister.Delete(_deleteItems);
				toolStripLabelSaveResult.Text += @" numDeleted: " + numDeleted;
				if (_deleteItems.Count == numDeleted)
				{
					_deleteItems.Clear();
					toolStripLabelDeleteCount.Text = "";
					saveToolStripButton.Enabled = !SupportsNotifyPropertyChanged;
				}
			}
			else
				saveToolStripButton.Enabled = numSaved == 0 || !SupportsNotifyPropertyChanged;
			toolStripButtonCancelEdit.Enabled = false;
		}

		private static void dataGridViewEnumerable_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
		}

		private void bindingSourceEnumerable_DataSourceChanged(object sender, EventArgs e)
		{
			if (bindingSourceEnumerable.Count > 0)
			{
				_canSave = CanSaveEnumerable();
				saveToolStripButton.Enabled = _canSave && !SupportsNotifyPropertyChanged;
				copyToolStripButton.Enabled = true;
				printToolStripButton.Enabled = true;
				toolStripButtonObjectListViewVisualizer.Enabled = IsObjectListView();
				toolStripButtonObjectListViewVisualizer.Visible = toolStripButtonObjectListViewVisualizer.Enabled;
			}

			else
				saveToolStripButton.Enabled = false;
			toolStripLabelSaveResult.Text = "";
		}

		protected virtual bool IsObjectListView()
		{
			return bindingSourceEnumerable.List is ObjectListView || bindingSourceEnumerable.List.GetType() == typeof (ObjectListView<>);
		}

		protected bool EnumerableShouldBeReadonly(IEnumerable enumerable, Type typeToEdit)
		{
			if (Readonly)
				return Readonly;
			var queryable = enumerable as IQueryable;
			var shouldBeReadonly = queryable != null;
			if (shouldBeReadonly)
			{
				if (typeToEdit == null)
					typeToEdit = queryable.ElementType;
				shouldBeReadonly = !CanSave(typeToEdit);
			}
			return shouldBeReadonly;
		}

		protected virtual bool GetFirstPage()
		{
			return GetFirstPage(_superset);
		}

		protected virtual bool GetFirstPage(IEnumerable enumerable)
		{
			var firstPageEnumerable = enumerable;
			if (Paging())
				firstPageEnumerable = firstPageEnumerable.AsQueryable().Take(PageSize);

			var isEnumerable = bindingSourceEnumerable.BindEnumerable(firstPageEnumerable, EnumerableShouldBeReadonly(enumerable, null));
			_binding = false;
			return isEnumerable;
		}

		protected bool Paging()
		{
			return bindingSourcePaging.Count > 0;
		}

		protected virtual IEnumerable<int> CreatePageDataSource(ushort pageSize, IEnumerable enumerable)
		{
			if (pageSize == 0 || enumerable == null)
				return Enumerable.Empty<int>();
			try
			{
				if (enumerable is ArrayList || enumerable is Array || enumerable is DataView)
				{
					PageSize = 0;
					return Enumerable.Empty<int>();
				}
				_superset = enumerable.AsQueryable();
				if (_superset.ElementType == typeof (string))
					_superset = ((IEnumerable<string>) enumerable).CreateStringWrapperForBinding().AsQueryable();
			}
			catch (ArgumentException)
			{
				PageSize = 0;
				return Enumerable.Empty<int>();
			}
			PageSize = pageSize;
			return Enumerable.Range(1, GetPageCount());
		}

		protected int GetPageCount()
		{
			return GeneralHelper.GetPageCount(PageSize, SuperSetCount());
		}

		protected virtual int SuperSetCount()
		{
			return _superset.Count();
		}

		private void bindingSourcePaging_PositionChanged(object sender, EventArgs e)
		{
			BindPage();
		}

		protected void BindPage()
		{
			try
			{
				_binding = true;
				if (GetPageIndex() > 0)
					BindEnumerable();
				else
					GetFirstPage();
				SetRemovingItem();
			}
			finally
			{
				_binding = false;
			}
		}

		protected virtual void BindEnumerable()
		{
			bindingSourceEnumerable.BindEnumerable(SkipTake(), false);
		}

		public bool BindEnumerable(IEnumerable enumerable)
		{
			return BindEnumerable(enumerable, PageSize);
		}

		public bool BindEnumerable(IEnumerable enumerable, ushort pageSize)
		{
			_binding = true;
			SetItemType(enumerable);
			bindingSourcePaging.DataSource = CreatePageDataSource(pageSize, enumerable);
			if (bindingSourcePaging.Count == 0)
				return GetFirstPage(enumerable);
			return bindingSourceEnumerable.List != null;
		}

		private IEnumerable SkipTake()
		{
			return _superset.Skip((GetPageIndex())*PageSize).Take(PageSize);
		}

		protected int GetPageIndex()
		{
			if (bindingSourcePaging.Current == null || bindingSourcePaging.Current == bindingSourcePaging.DataSource)
				return 0;
			return (int) bindingSourcePaging.Current - 1;
		}

		protected virtual void SetRemovingItem()
		{
			if (_superset is IQueryable && SupportsNotifyPropertyChanged)
				saveToolStripButton.Enabled = false;
			if (bindingSourceEnumerable.DataSource is ObjectListView)
				((ObjectListView) bindingSourceEnumerable.DataSource).RemovingItem += GridDataEditor_RemovingItem;
		}

		protected void GridDataEditor_RemovingItem(object sender, RemovingItemEventArgs e)
		{
			_deleteItems.Add(bindingSourceEnumerable[e.Index]);
			toolStripLabelDeleteCount.Text = @"Num removed=" + _deleteItems.Count;
		}

		private static void AddFieldsToPropertiesTypeDescriptionProvider(Type typeToEdit)
		{
			if (_fieldsToPropertiesTypeDescriptionProvider == null && typeToEdit != null)
			{
				_fieldsToPropertiesTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeToEdit, BindingFlags.Instance | BindingFlags.Public);
				TypeDescriptor.AddProvider(_fieldsToPropertiesTypeDescriptionProvider, typeToEdit);
			}
		}

		protected void TidyUp()
		{
			if (_fieldsToPropertiesTypeDescriptionProvider != null && ItemType != null)
			{
				TypeDescriptor.RemoveProvider(_fieldsToPropertiesTypeDescriptionProvider, ItemType);
				_fieldsToPropertiesTypeDescriptionProvider = null;
			}
		}

		protected override void OnHandleDestroyed(EventArgs e)
		{
			base.OnHandleDestroyed(e);
			TidyUp();
		}

		private Type _itemType;
		protected bool SupportsNotifyPropertyChanged;

		protected virtual Type ItemType
		{
			get
			{
				if (_itemType == null && bindingSourceEnumerable.DataSource != null)
					ItemType = MetaDataHelper.GetEnumerableItemType(bindingSourceEnumerable.List);
				return _itemType;
			}
			set
			{
				_itemType = value;
				OnSetItemType();
			}
		}

		private void SetItemType(IEnumerable list)
		{
			if (ItemType == null & list != null)
				ItemType = MetaDataHelper.GetEnumerableItemType(list);
		}

		protected void OnSetItemType()
		{
			SupportsNotifyPropertyChanged = typeof (INotifyPropertyChanged).IsAssignableFrom(ItemType);
			AddFieldsToPropertiesTypeDescriptionProvider(ItemType);
		}

		private bool CanSave(Type typeToEdit)
		{
			ItemType = typeToEdit;
			return DataEditorPersister != null && DataEditorPersister.CanSave(typeToEdit);
		}

		private bool CanSaveEnumerable()
		{
			return CanSave(ItemType);
		}

		private void bindingSourceEnumerable_BindingComplete(object sender, BindingCompleteEventArgs e)
		{
			bindingSourceEnumerable_DataSourceChanged(sender, e);
		}

		private void bindingSourceEnumerable_ListChanged(object sender, ListChangedEventArgs e)
		{
			toolStripLabelSaveResult.Text = "";
			if (!_binding && _loaded)
				switch (e.ListChangedType)
				{
					case ListChangedType.ItemDeleted:
					case ListChangedType.ItemChanged:
					case ListChangedType.ItemAdded:
						saveToolStripButton.Enabled = _canSave;
						toolStripButtonCancelEdit.Enabled = true;
						break;
				}
		}

		private void toolStripButtonCancelEdit_Click(object sender, EventArgs e)
		{
			bindingSourceEnumerable.CancelEdit();
			toolStripButtonCancelEdit.Enabled = false;
		}

		private void bindingSourceEnumerable_PositionChanged(object sender, EventArgs e)
		{
			toolStripButtonCancelEdit.Enabled = false;
		}

		private void toolStripButtonObjectListViewVisualizer_Click(object sender, EventArgs e)
		{
			var visualizerForm = ObjectListViewHelper.CreateVisualizerForm(bindingSourceEnumerable.List);
			if (visualizerForm != null)
				visualizerForm.ShowDialog();
		}
	}
}