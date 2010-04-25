using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Linq.Dynamic;
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
    private bool _canSave;
    private IQueryable _superset;
    public IGridDataEditorPersister GridDataEditorPersister;

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
    }

    private void saveToolStripButton_Click(object sender, EventArgs e)
    {
      var numSaved = GridDataEditorPersister.Save(bindingSourceEnumerable.List);
      toolStripLabelSaveResult.Text = @"numSaved: " + numSaved;
      if ( _deleteItems != null)
      {
        var numDeleted = GridDataEditorPersister.Delete(_deleteItems);
        toolStripLabelSaveResult.Text += @" numDeleted: " + numDeleted;
        if (_deleteItems.Count == numDeleted)
        {
          _deleteItems.Clear();
          toolStripLabelDeleteCount.Text = "";
          saveToolStripButton.Enabled = false;
        }
      }
      else
        saveToolStripButton.Enabled = numSaved == 0;
      toolStripButtonCancelEdit.Enabled = false;
    }

    private void dataGridViewEnumerable_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
    }

    private void bindingSourceEnumerable_DataSourceChanged(object sender, EventArgs e)
    {
      if (bindingSourceEnumerable.Count > 0)
      {
        _canSave = CanSaveEnumerable();
        copyToolStripButton.Enabled = true;
        printToolStripButton.Enabled = true;
        toolStripButtonObjectListViewVisualizer.Visible = bindingSourceEnumerable.List is ObjectListView || bindingSourceEnumerable.List.GetType() == typeof (ObjectListView<>);
        toolStripButtonObjectListViewVisualizer.Enabled = toolStripButtonObjectListViewVisualizer.Visible;
      }

      else
        saveToolStripButton.Enabled = false;
      toolStripLabelSaveResult.Text = "";
    }

    public bool BindEnumerable(IEnumerable enumerable)
    {
      return BindEnumerable(enumerable, PageSize);
    }

    public bool BindEnumerable(IEnumerable enumerable, ushort pageSize)
    {
      bindingSourcePaging.DataSource = CreatePageDataSource(pageSize, enumerable);
      return GetFirstPage(enumerable);
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

    private bool GetFirstPage(IEnumerable enumerable)
    {
      if (Paging())
        enumerable = enumerable.AsQueryable().Take(PageSize);
      var isEnumerable = bindingSourceEnumerable.BindEnumerable(enumerable, EnumerableShouldBeReadonly(enumerable, null));
      SetRemovingItem();
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
        _superset = enumerable.AsQueryable();
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

    protected virtual void BindPage()
    {
      if (GetPageIndex() > 0)
        bindingSourceEnumerable.BindEnumerable(SkipTake(), false);
      else
        GetFirstPage(_superset);
    }

    private IEnumerable SkipTake()
    {
      return _superset.Skip((GetPageIndex())*PageSize).Take(PageSize);
    }

    protected int GetPageIndex()
    {
      if (bindingSourcePaging.Current == null)
        return 0;
      return (int) bindingSourcePaging.Current - 1;
    }

    protected void SetRemovingItem()
    {
      if (bindingSourceEnumerable.DataSource is ObjectListView)
        ((ObjectListView) bindingSourceEnumerable.DataSource).RemovingItem += GridDataEditor_RemovingItem;
    }

    protected void GridDataEditor_RemovingItem(object sender, RemovingItemEventArgs e)
    {
      _deleteItems.Add(bindingSourceEnumerable[e.Index]);
      toolStripLabelDeleteCount.Text = @"Num removed=" + _deleteItems.Count;
    }

    private bool CanSave(Type typeToEdit)
    {
      return GridDataEditorPersister != null && GridDataEditorPersister.CanSave(typeToEdit);
    }

    private bool CanSaveEnumerable()
    {
      return CanSave(ListBindingHelper.GetListItemType(bindingSourceEnumerable.List));
    }

    private void bindingSourceEnumerable_BindingComplete(object sender, BindingCompleteEventArgs e)
    {
      bindingSourceEnumerable_DataSourceChanged(sender, e);
    }

    private void bindingSourceEnumerable_ListChanged(object sender, ListChangedEventArgs e)
    {
      toolStripLabelSaveResult.Text = "";
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

  public interface IGridDataEditorPersister
  {
    int Save(object dataToSave);
    int Delete(object dataToSave);
    bool CanSave(Type typeToSave);
  }

  public class GridDataEditorPersister : IGridDataEditorPersister
  {
    public Type[] SaveableTypes;
    public Func<object, int> SaveFunction;
    public Func<object, int> DeleteFunction;

    public GridDataEditorPersister(Func<object, int> saveFunction, Func<object, int> deleteFunction, params Type[] saveableTypes)
    {
      SaveableTypes = saveableTypes;
      SaveFunction = saveFunction;
      DeleteFunction = deleteFunction;
    }

    public int Save(object dataToSave)
    {
      return SaveFunction != null ? SaveFunction(dataToSave) : 0;
    }

    public int Delete(object dataToSave)
    {
      return DeleteFunction != null ? DeleteFunction(dataToSave) : 0;
    }

    public bool CanSave(Type typeToSave)
    {
      return SaveFunction != null && (SaveableTypes == null || typeToSave.IsAssignableTo(SaveableTypes));
    }

  }
}