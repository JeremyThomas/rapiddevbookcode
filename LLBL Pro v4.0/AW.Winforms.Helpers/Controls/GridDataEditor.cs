using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Linq.Dynamic;
using System.Reflection;
using System.Windows.Forms;
using ADGV;
using AW.Helper;
using AW.Helper.TypeConverters;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.EntityViewer;
using DynamicTable;
using JesseJohnston;

namespace AW.Winforms.Helpers.Controls
{
  public partial class GridDataEditor : UserControl
  {
    private readonly string[] _membersToExclude;

    /// <summary>
    /// The maximum automatic generate column width - 300
    /// </summary>
    private const int MaxAutoGenerateColumnWidth = 300;
    private readonly ArrayList _deleteItems = new ArrayList();
    protected bool IsBinding = true;
    private bool _loaded;
    private bool _canSave;
    private IQueryable _superset;
    public IDataEditorPersister DataEditorPersister;
    private static readonly Dictionary<Type, FieldsToPropertiesTypeDescriptionProvider> FieldsToPropertiesTypeDescriptionProviders = new Dictionary<Type, FieldsToPropertiesTypeDescriptionProvider>();

    public GridDataEditor()
    {
      InitializeComponent();
      HumanizedEnumConverter.AddEnumerationConverter(typeof(DataGridViewClipboardCopyMode));
      dataGridViewEnumerable.AutoGenerateColumns = true;      
      toolStripButtonShowDatagrid_Click(null, null);
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="T:System.Windows.Forms.UserControl" /> class.
    /// </summary>
    public GridDataEditor(IEnumerable enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly, params string[] membersToExclude)
      : this()
    {
      _membersToExclude = membersToExclude;
      if (ValueTypeWrapper.TypeNeedsWrappingForBinding(MetaDataHelper.GetEnumerableItemType(enumerable)))
      {
        enumerable = ValueTypeWrapper.CreateWrapperForBinding(enumerable);
        readOnly = true;
      }
      InitialiseAndBindGridDataEditor(enumerable, dataEditorPersister, pageSize, readOnly);
    }

    public GridDataEditor(IEnumerable enumerable) : this(enumerable, null, DataEditorExtensions.DefaultPageSize, true)
    {
    }

    public void InitialiseAndBindGridDataEditor(IEnumerable enumerable, IDataEditorPersister dataEditorPersister,
      ushort pageSize, bool readOnly)
    {
      DataEditorPersister = dataEditorPersister;
      Readonly = readOnly;
      tabControlGrids.SelectedTab = tabPageDataGridView;
      BindEnumerable(enumerable, pageSize);
    }

    #region Properties

    [Category("Data"),
     Description("Size of the page")]
    public ushort PageSize
    {
      get { return _pageSize; }
      set
      {
        _pageSize = value;
        toolStripLabelCurrentPagesSize.Text = _pageSize.ToString(CultureInfo.InvariantCulture);
      }
    }

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
      get { return bindingNavigatorData; }
    }

    public BindingSource BindingSource
    {
      get { return bindingSourceEnumerable; }
    }

    /// <summary>
    /// Gets or sets a value indicating whether the grid was set read-only.
    /// </summary>
    /// <value>
    ///   <c>true</c> if [read-only]; otherwise, <c>false</c>.
    /// </value>
    public bool Readonly { get; set; }

    /// <summary>
    /// Was the last bound Enumerable not writable when grid is not read-only
    /// </summary>
    private bool _shouldBeReadonly;

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
      if (HasDeletes)
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
      SetButtonsOnEditEnded();
    }

    private bool HasDeletes
    {
      get { return _deleteItems != null && _deleteItems.Count > 0; }
    }

    private void SetButtonsOnEditEnded()
    {
      toolStripButtonCancelEdit.Enabled = false;
      bindingNavigatorPaging.Enabled = true;
    }

    private void dataGridViewEnumerable_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      GeneralHelper.TraceOut(e.Exception.ToString());
    }

    private void bindingSourceEnumerable_DataSourceChanged(object sender, EventArgs e)
    {
      if (bindingSourceEnumerable.Count > 0)
      {
        _canSave = CanSaveEnumerable();
        saveToolStripButton.Enabled = _canSave && !SupportsNotifyPropertyChanged;
        saveToolStripButton.Visible = _canSave;
        copyToolStripButton.Enabled = true;
        printToolStripButton.Enabled = true;
        toolStripButtonObjectBrowser.Enabled = true;
        toolStripButtonObjectListViewVisualizer.Enabled = IsObjectListView();
        toolStripButtonObjectListViewVisualizer.Visible = toolStripButtonObjectListViewVisualizer.Enabled;
        toolStripButtonEnableFilter.Visible = !bindingSourceEnumerable.SupportsFiltering;
        BindGrids();
        SetButtonsOnEditEnded();
      }
      else
      {
        toolStripButtonObjectBrowser.Enabled = false;
        saveToolStripButton.Enabled = false;
        bindingNavigatorPaging.Enabled = true;
      }
      toolStripLabelSaveResult.Text = "";
      toolStripLabelDeleteCount.Text = "";
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
      _shouldBeReadonly = queryable != null;
      if (_shouldBeReadonly)
      {
        if (typeToEdit == null)
          typeToEdit = queryable.ElementType;
        _shouldBeReadonly = !CanSave(typeToEdit);
      }
      return _shouldBeReadonly;
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
      UnBindGrids();

      var isEnumerable = bindingSourceEnumerable.BindEnumerable(firstPageEnumerable, EnumerableShouldBeReadonly(enumerable, null), EnsureFilteringEnabled);
      SetRemovingItem();
      IsBinding = false;
      return isEnumerable;
    }

    protected bool Paging()
    {
      return bindingSourcePaging.Count > 1;
    }

    protected virtual IEnumerable<int> CreatePageDataSource(ushort pageSize, IEnumerable enumerable)
    {
      _superSetCount = null;
      if (pageSize == 0 || enumerable == null)
      {
        _superset = null;
        return Enumerable.Empty<int>();
      }
      try
      {
        if (enumerable is ArrayList || enumerable is Array || enumerable is DataView || !(IsGenericType(enumerable)))
        {
          PageSize = 0;
          _superset = null;
          return Enumerable.Empty<int>();
        }
        _superset = enumerable.AsQueryable();
        if (ValueTypeWrapper.TypeNeedsWrappingForBinding(_superset.ElementType))
          _superset = ValueTypeWrapper.CreateWrapperForBinding(enumerable).AsQueryable();
      }
      catch (ArgumentException)
      {
        PageSize = 0;
        _superset = null;
        return Enumerable.Empty<int>();
      }
      PageSize = pageSize;
      return Enumerable.Range(1, GetPageCount());
    }

    private static bool IsGenericType(IEnumerable enumerable)
    {
      var type = enumerable.GetType();
      return type.IsGenericType || (type.BaseType != null && type.BaseType.IsGenericType);
    }

    protected int GetPageCount()
    {
      return GeneralHelper.GetPageCount(PageSize, SuperSetCount());
    }

    protected int? _superSetCount;

    protected virtual int SuperSetCount()
    {
      if (!_superSetCount.HasValue)
      {
        _superSetCount = _superset.Count();
        toolStripLabelSuperSetCount.Text = _superSetCount.ToString();
      }
      return _superSetCount.Value;
    }

    private void bindingSourcePaging_PositionChanged(object sender, EventArgs e)
    {
      if (bindingSourcePaging.Count != 0)
        BindPage();
    }

    protected void BindPage()
    {
      try
      {
        IsBinding = true;
        if (GetPageIndex() > 0)
          BindEnumerable();
        else
        {
          GetFirstPage();
        }
        SetRemovingItem();
      }
      finally
      {
        IsBinding = false;
      }
    }

    protected virtual void BindEnumerable()
    {
      UnBindGrids();
      bindingSourceEnumerable.BindEnumerable(SkipTake(), false, EnsureFilteringEnabled);
    }

    public bool BindEnumerable(IEnumerable enumerable)
    {
      return BindEnumerable(enumerable, PageSize);
    }

    public bool BindEnumerable(IEnumerable enumerable, ushort pageSize)
    {
      IsBinding = true;
      SetItemType(enumerable);
      bindingSourcePaging.DataSource = null;
      bindingSourcePaging.DataSource = CreatePageDataSource(pageSize, enumerable);
      if (Paging())
        return bindingSourceEnumerable.List != null;        
      return GetFirstPage(enumerable);
    }

    private IEnumerable SkipTake()
    {
      return _superset.SkipTakeDynamic(GetPageIndex(), PageSize);
    }

    protected int GetPageIndex()
    {
      if (bindingSourcePaging.Current == null || bindingSourcePaging.Current == bindingSourcePaging.DataSource)
        return 0;
      return (int) bindingSourcePaging.Current - 1;
    }

    protected virtual void SetRemovingItem()
    {
      if (SupportsNotifyPropertyChanged)
        saveToolStripButton.Enabled = false;
      if (DataSourceIsObjectListView)
        ((ObjectListView) bindingSourceEnumerable.DataSource).RemovingItem += GridDataEditor_RemovingItem;
    }

    private bool DataSourceIsObjectListView
    {
      get { return bindingSourceEnumerable.DataSource is ObjectListView; }
    }

    protected void GridDataEditor_RemovingItem(object sender, RemovingItemEventArgs e)
    {
      _deleteItems.Add(bindingSourceEnumerable[e.Index]);
      toolStripLabelDeleteCount.Text = @"Num removed=" + _deleteItems.Count;
    }

    private static void AddFieldsToPropertiesTypeDescriptionProvider(Type typeToEdit)
    {
      if (typeToEdit != null && !FieldsToPropertiesTypeDescriptionProviders.ContainsKey(typeToEdit))
      {
        var fieldsToPropertiesTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeToEdit, BindingFlags.Instance | BindingFlags.Public);
        FieldsToPropertiesTypeDescriptionProviders.Add(typeToEdit, fieldsToPropertiesTypeDescriptionProvider);
        TypeDescriptor.AddProvider(fieldsToPropertiesTypeDescriptionProvider, typeToEdit);
      }
    }

    protected void TidyUp()
    {
      if (ItemType != null && FieldsToPropertiesTypeDescriptionProviders.ContainsKey(ItemType))
      {
        TypeDescriptor.RemoveProvider(FieldsToPropertiesTypeDescriptionProviders[ItemType], ItemType);
        FieldsToPropertiesTypeDescriptionProviders.Remove(ItemType);
      }
    }

    protected override void OnHandleDestroyed(EventArgs e)
    {
      base.OnHandleDestroyed(e);
      TidyUp();
    }

    private Type _itemType;
    protected bool SupportsNotifyPropertyChanged;
    private ushort _pageSize;

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
        if (_itemType == value) return;
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
      if (!IsBinding && _loaded)
        switch (e.ListChangedType)
        {
          case ListChangedType.ItemDeleted:
            saveToolStripButton.Enabled = _canSave && (!DataSourceIsObjectListView || HasDeletes);
            toolStripButtonCancelEdit.Enabled = true;
            bindingNavigatorPaging.Enabled = false;
            break;
    
          case ListChangedType.ItemChanged:
          case ListChangedType.ItemAdded:
            saveToolStripButton.Enabled = _canSave;
            toolStripButtonCancelEdit.Enabled = true;
            bindingNavigatorPaging.Enabled = false;
            break;
        }
    }

    private void toolStripButtonCancelEdit_Click(object sender, EventArgs e)
    {
      bindingSourceEnumerable.CancelEdit();
      if (DataEditorPersister != null && DataEditorPersister.Undo(bindingSourceEnumerable.List))
      {
        bindingSourceEnumerable.ResetBindings(false);
        saveToolStripButton.Enabled = false;
      }
      SetButtonsOnEditEnded();
    }

    private void toolStripButtonObjectListViewVisualizer_Click(object sender, EventArgs e)
    {
      var visualizerForm = ObjectListViewHelper.CreateVisualizerForm(bindingSourceEnumerable.List);
      if (visualizerForm != null)
        visualizerForm.ShowDialog();
    }

    private void toolStripButtonObjectBrowser_Click(object sender, EventArgs e)
    {
      FrmEntityViewer.LaunchAsChildForm(bindingSourceEnumerable.List, DataEditorPersister);
    }

    private void tabControlGrids_SelectedIndexChanged(object sender, EventArgs e)
    {
      BindGrids(true);
    }

    private void BindGrids(bool fromUser = false)
    {
      if (tabControlGrids.SelectedTab == tabPageDataGrid)
      {
        dataGridEnumerable.DataSource = bindingSourceEnumerable;
      }
      else
      {
        if (!fromUser)
          dataGridEnumerable.DataSource = null;
        dataGridViewEnumerable.DataSource = bindingSourceEnumerable;
      }
    }

    private void UnBindGrids()
    {
      //  dataGridViewEnumerable.DataSource = null;
      dataGridEnumerable.DataSource = null;
    }

    private void dataGridViewEnumerable_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
    {
      var dataGridView = e.Column.DataGridView;
      if (_membersToExclude != null && _membersToExclude.Contains(e.Column.DataPropertyName))
        dataGridView.Columns.Remove(e.Column);

      dataGridViewEnumerable.AutoGenerateContextFilters = bindingSourceEnumerable.SupportsFiltering;
      if (dataGridViewEnumerable.AutoGenerateContextFilters)
      {
        var adgvColumnHeaderCell = e.Column.HeaderCell as ADGVColumnHeaderCell;
        if (adgvColumnHeaderCell != null) adgvColumnHeaderCell.FilterEnabled = true;
      }
      else
        e.Column.SortMode = DataGridViewColumnSortMode.Automatic;
      if (Readonly || _shouldBeReadonly) return;
      var coreType = MetaDataHelper.GetCoreType(e.Column.ValueType);
      if (e.Column.ValueType == null || e.Column is DataGridViewComboBoxColumn || e.Column is DataGridViewDateTimeColumn) return;

      if (coreType.IsEnum)
      {
        HumanizedEnumConverter.AddEnumerationConverter(e.Column.ValueType);
        var enumDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn
        {
          HeaderText = e.Column.HeaderText,
          ValueType = e.Column.ValueType,
          DataSource = coreType == e.Column.ValueType ? Enum.GetValues(coreType) : GeneralHelper.EnumsGetValuesPlusUndefined(coreType),
          DataPropertyName = e.Column.DataPropertyName,
          SortMode = e.Column.SortMode,
          DefaultCellStyle = e.Column.DefaultCellStyle,
          Name = e.Column.Name
        };
        dataGridView.Columns.Remove(e.Column);
        dataGridView.Columns.Add(enumDataGridViewComboBoxColumn);
        enumDataGridViewComboBoxColumn.SortMode = e.Column.SortMode;
      }
      else if (coreType == typeof (DateTime))
      {
        var dataGridViewDateTimeColumn = new DataGridViewDateTimeColumn
        {
          HeaderText = e.Column.HeaderText,
          ValueType = e.Column.ValueType,
          DataPropertyName = e.Column.DataPropertyName,
          SortMode = e.Column.SortMode,
          DefaultCellStyle = e.Column.DefaultCellStyle,
          Name = e.Column.Name
        };
        dataGridView.Columns.Remove(e.Column);
        dataGridView.Columns.Add(dataGridViewDateTimeColumn);
        dataGridViewDateTimeColumn.SortMode = e.Column.SortMode;
      }
    }

    private void dataGridViewEnumerable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      var valueType = MetaDataHelper.GetCoreType(dataGridViewEnumerable.Columns[e.ColumnIndex].ValueType);
      if (valueType != null && valueType.IsEnum)
      {
        if (e.Value == null || MetaDataHelper.GetCoreType(e.Value.GetType()).IsEnum && !Enum.IsDefined(valueType, e.Value))
        {
          e.Value = "";
          e.FormattingApplied = true;
        } //e.Value = e.Value.ToString();
        //else
        //  if (e.Value is ValueTypeWrapper)
        //  {
        //    e.Value = "";
        //    e.FormattingApplied = true;
        //  }//e.Value = e.Value.ToString();
      }
    }

    private void dataGridEnumerable_Navigate(object sender, NavigateEventArgs ne)
    {
    }

    private void dataGridEnumerable_DataSourceChanged(object sender, EventArgs e)
    {
      var count = dataGridEnumerable.TableStyles.Count;
    }

    private void dataGridViewEnumerable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      if (dataGridViewEnumerable.Columns.Count > 0 && dataGridViewEnumerable.Columns.Cast<DataGridViewColumn>().Any(c => !c.IsDataBound))
      {
        dataGridViewEnumerable.AutoGenerateColumns = false;
        dataGridViewEnumerable.AutoGenerateColumns = true;
      }
      // Resize the master DataGridView columns to fit the newly loaded data.
      dataGridViewEnumerable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
      foreach (var column in dataGridViewEnumerable.Columns.Cast<DataGridViewColumn>().Where(column => column.Width > MaxAutoGenerateColumnWidth))
        column.Width = MaxAutoGenerateColumnWidth;
      searchToolBar.SetColumns(dataGridViewEnumerable.Columns);
      toolStripButtonUnPage.Visible = Paging();
    }

    private void dataGridViewEnumerable_FilterStringChanged(object sender, EventArgs e)
    {
      if (bindingSourceEnumerable.SupportsFiltering)
      {
        bindingSourceEnumerable.Filter = dataGridViewEnumerable.FilterString;
        toolStripButtonClearFilters.Visible = !string.IsNullOrWhiteSpace(dataGridViewEnumerable.FilterString);
        toolStripButtonClearFilters.ToolTipText = dataGridViewEnumerable.FilterString;
      }
    }

    private void dataGridViewEnumerable_SortStringChanged(object sender, EventArgs e)
    {
      bindingSourceEnumerable.Sort = dataGridViewEnumerable.SortString;
    }

    private void toolStripButtonUnPage_Click(object sender, EventArgs e)
    {
      ChangePageSize(0);

    }

    private void toolStripButtonSetPageSize_Click(object sender, EventArgs e)
    {
      ChangePageSize(Convert.ToUInt16(toolStripTextBoxNewPageSize.Text));}

    private void ChangePageSize(ushort pageSize)
    {
      if (PageSize == pageSize) return;
      PageSize = pageSize;
      BindEnumerable(SourceEnumerable);
      if (pageSize == 0)
        toolStripLabelSuperSetCount.Text = "";
    }

    private void toolStripButtonEnableFilter_Click(object sender, EventArgs e)
    {
      if (!bindingSourceEnumerable.SupportsFiltering)
      {
        EnsureFilteringEnabled = true;
        BindEnumerable(SourceEnumerable);

         //BindEnumerable(new Csla.ObjectListView(bindingSourceEnumerable.List));
        toolStripButtonEnableFilter.Visible = false;
      }
    }

    protected virtual IEnumerable SourceEnumerable
    {
      get { return _superset ?? bindingSourceEnumerable.GetDataSource(); }
    }

    public bool EnsureFilteringEnabled { get; set; }

    private void toolStripButtonClearFilters_Click(object sender, EventArgs e)
    {
      dataGridViewEnumerable.ClearFilter(true);
      if (bindingSourceEnumerable.SupportsFiltering)
        bindingSourceEnumerable.RemoveFilter();
    }

    private void toolStripButtonClearSort_Click(object sender, EventArgs e)
    {
      dataGridViewEnumerable.ClearSort(true);
      if (bindingSourceEnumerable.SupportsSorting)
        bindingSourceEnumerable.RemoveSort();
    }

    private void toolStripButtonSearch_Click(object sender, EventArgs e)
    {
      if (toolStripButtonSearch.Checked)
        searchToolBar.Show();
      else
        searchToolBar.Hide();
    }

    private void searchToolBar_Search(object sender, ACS.UserControls.SearchToolBarSearchEventArgs e)
    {
      var startColumn = 0;
      var startRow = 0;
      if (!e.FromBegin)
      {
        var endcol = dataGridViewEnumerable.CurrentCell.ColumnIndex + 1 >= dataGridViewEnumerable.ColumnCount;
        var endrow = dataGridViewEnumerable.CurrentCell.RowIndex + 1 >= dataGridViewEnumerable.RowCount;

        if (endcol && endrow)
        {
          startColumn = dataGridViewEnumerable.CurrentCell.ColumnIndex;
          startRow = dataGridViewEnumerable.CurrentCell.RowIndex;
        }
        else
        {
          startColumn = endcol ? 0 : dataGridViewEnumerable.CurrentCell.ColumnIndex + 1;
          startRow = dataGridViewEnumerable.CurrentCell.RowIndex + (endcol ? 1 : 0);
        }
      }
      var c = dataGridViewEnumerable.FindCell(
        e.ValueToSearch,
        e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
        startRow,
        startColumn,
        e.WholeWord,
        e.CaseSensitive);

      if (c != null)
        dataGridViewEnumerable.CurrentCell = c;
    }

    private void searchToolBar_VisibleChanged(object sender, EventArgs e)
    {
      toolStripButtonSearch.Checked = searchToolBar.Visible;
    }

    private void toolStripButtonShowDatagrid_Click(object sender, EventArgs e)
    {
      if (toolStripButtonShowDatagrid.Checked)
      {
        tabControlGrids.ItemSize = new Size();
        tabControlGrids.SizeMode = TabSizeMode.Normal;
        tabControlGrids.Appearance = TabAppearance.Normal;
        tabControlGrids.TabPages.Add(tabPageDataGrid);
      }
      else
      {
        tabControlGrids.TabPages.Remove(tabPageDataGrid);
        tabControlGrids.ItemSize = new Size(0, 1);
        tabControlGrids.SizeMode = TabSizeMode.Fixed;
        tabControlGrids.Appearance = TabAppearance.FlatButtons;
      }
    }

  }
}