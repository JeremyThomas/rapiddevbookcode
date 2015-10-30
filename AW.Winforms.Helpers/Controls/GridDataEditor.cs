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
using AW.Winforms.Helpers.Forms;
using AW.Winforms.Helpers.Misc;
using AW.Winforms.Helpers.Properties;
using AW.Winforms.Helpers.QueryRunner;
using AW.Winforms.Helpers.Reporting;
using JesseJohnston;
using Microsoft.VisualBasic;

namespace AW.Winforms.Helpers.Controls
{
  public partial class GridDataEditor : UserControl, ISupportInitialize
  {
    public string[] MembersToExclude { get; set; }

    public const int DefaultPageSize = 30;

    /// <summary>
    ///   The maximum automatic generate column width - 300
    /// </summary>
    private const int MaxAutoGenerateColumnWidth = 300;

    private const bool AllowPagingWhenEditing = true;

    private readonly ArrayList _deleteItems = new ArrayList();
    protected bool IsBinding = true;
    private bool _loaded;
    private bool _canSave;
    private IEnumerable _superset;
    public IDataEditorPersister DataEditorPersister;
    private static readonly Dictionary<Type, FieldsToPropertiesTypeDescriptionProvider> FieldsToPropertiesTypeDescriptionProviders 
      = new Dictionary<Type, FieldsToPropertiesTypeDescriptionProvider>();

    static GridDataEditor()
    {
      AddConvertersAndDescriptors.AddIfNotAllready();
    }

    public GridDataEditor()
    {
      InitializeComponent();
      
      dataGridViewEnumerable.AutoGenerateColumns = true;
      toolStripButtonShowDatagrid_Click(null, null);
      var toolStripItemFromBeginButton = searchToolBar.Items["fromBeginButton"] as ToolStripButton;
      if (toolStripItemFromBeginButton != null)
      {
        toolStripItemFromBeginButton.Checked = false;
        searchToolBar.Items.Remove(toolStripItemFromBeginButton);
      }
      MoveLastItem(3);
      MoveLastItem(2);
    }

    private void MoveLastItem(int offset)
    {
      var toolStripItem = searchToolBar.Items[searchToolBar.Items.Count - 1];
      searchToolBar.Items.Remove(toolStripItem);
      searchToolBar.Items.Insert(searchToolBar.Items.Count - offset, toolStripItem);
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="T:System.Windows.Forms.UserControl" /> class.
    /// </summary>
    public GridDataEditor(IEnumerable enumerable, IDataEditorPersister dataEditorPersister = null, ushort pageSize = DefaultPageSize, bool readOnly = true, params string[] membersToExclude)
      : this()
    {
      MembersToExclude = membersToExclude;
      SetItemType(enumerable);
      if (ValueTypeWrapper.TypeNeedsWrappingForBinding(_itemType))
      {
        enumerable = ValueTypeWrapper.CreateWrapperForBinding(enumerable);
        SetItemType(enumerable);
        readOnly = readOnly || !_itemType.IsGenericType;
      }
      InitialiseAndBindGridDataEditor(enumerable, dataEditorPersister, pageSize, readOnly);
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
    ///   Gets or sets a value indicating whether the grid was set read-only.
    /// </summary>
    /// <value>
    ///   <c>true</c> if [read-only]; otherwise, <c>false</c>.
    /// </value>
    public bool Readonly
    {
      get { return dataGridViewEnumerable.ReadOnly; }
      set { dataGridViewEnumerable.ReadOnly = value; }
    }

    /// <summary>
    ///   Was the last bound Enumerable not writable when grid is not read-only
    /// </summary>
    private bool _shouldBeReadonly;

    #endregion

    private void printToolStripButton_Click(object sender, EventArgs e)
    {
      var frm = new FrmReportViewer {WindowState = FormWindowState.Normal};
      frm.OpenDataSet(bindingSourceEnumerable, false);
      frm.Show();
    }

    public static void CopyEntireDataGridViewToClipboard(DataGridView dataGridView)
    {
      dataGridView.SelectAll();
      Clipboard.SetDataObject(dataGridView.GetClipboardContent());
    }

    private void copyToolStripButton_Click(object sender, EventArgs e)
    {
      CopyEntireDataGridViewToClipboard(dataGridViewEnumerable);
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
      SaveEdits();
    }

    public void SaveEdits()
    {
      dataGridViewEnumerable.EndEdit();
      var numSaved = DataEditorPersister.Save(BindingSourceEnumerableList);
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
      e.Exception.TraceOut();
      if (_canSave && !toolStripButtonCancelEdit.Enabled && DataEditorPersister.IsDirty(PageSourceEnumerable))
      {
        toolStripButtonCancelEdit.Enabled = true;
      }
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

    protected bool EnumerableShouldBeReadonly(IEnumerable enumerable, Type typeToEdit)
    {
      if (Readonly)
        return Readonly;
      var queryable = enumerable as IQueryable;
      _shouldBeReadonly = queryable != null;
      if (_shouldBeReadonly)
      {
        if (typeToEdit == null)
// ReSharper disable once PossibleNullReferenceException
          typeToEdit = queryable.ElementType;
        _shouldBeReadonly = !CanSave(typeToEdit);
      }
      return _shouldBeReadonly;
    }

    private bool GetFirstPage()
    {
      return GetFirstPage(_superset);
    }

    private bool GetFirstPage(IEnumerable enumerable)
    {
      var firstPageEnumerable = enumerable;
      if (Paging())
      {
        var queryable = enumerable as IQueryable;
        firstPageEnumerable = queryable == null ? LinqHelper.Take(firstPageEnumerable, PageSize) : queryable.Take(PageSize);
      }
      UnBindGrids();

      var isEnumerable = bindingSourceEnumerable.BindEnumerable(firstPageEnumerable, EnumerableShouldBeReadonly(enumerable, null), EnsureFilteringEnabled, BindingListViewCreater);
      SetRemovingItem();
      IsBinding = false;
      return isEnumerable;
    }

    protected bool Paging()
    {
      return bindingSourcePaging.Count > 1;
    }

    private IEnumerable<int> CreatePageDataSource(ushort pageSize, IEnumerable enumerable)
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
        _superset = enumerable;
        if (ValueTypeWrapper.TypeNeedsWrappingForBinding(ItemType))
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
      return LinqHelper.GetPageCount(PageSize, SuperSetCount());
    }

    private int? _superSetCount;

    private int SuperSetCount()
    {
      if (!_superSetCount.HasValue)
      {
        var queryable = _superset as IQueryable;
        _superSetCount = queryable == null ? _superset.Cast<object>().Count() : queryable.Count();
        toolStripLabelSuperSetCount.Text = _superSetCount.ToString();
      }
      return _superSetCount.Value;
    }

    private void bindingSourcePaging_PositionChanged(object sender, EventArgs e)
    {
      if (Paging())
        BindPage();
    }

    private void BindPage()
    {
      try
      {
        IsBinding = true;
        if (GetPageIndex() > 0)
        {
          BindEnumerable();
          SetRemovingItem();
        }
        else
        {
          GetFirstPage();
        }
      }
      finally
      {
        IsBinding = false;
      }
    }

    private void BindEnumerable()
    {
      UnBindGrids();
      bindingSourceEnumerable.BindEnumerable(SkipTake(), false, EnsureFilteringEnabled, BindingListViewCreater);
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
        return BindingSourceEnumerableList != null;
      return GetFirstPage(enumerable);
    }

    private IEnumerable SkipTake()
    {
      var queryable = _superset as IQueryable;
      return  queryable == null ? LinqHelper.SkipTake(_superset, GetPageIndex(), PageSize) : AWHelper.SkipTakeDynamic(queryable, GetPageIndex(), PageSize);
    }

    protected int GetPageIndex()
    {
      if (bindingSourcePaging.Current == null || bindingSourcePaging.Current == bindingSourcePaging.DataSource)
        return 0;
      return (int) bindingSourcePaging.Current - 1;
    }

    private void SetRemovingItem()
    {
      if (SupportsNotifyPropertyChanged)
        saveToolStripButton.Enabled = false;
      MaybeSetRemovingItem(bindingSourceEnumerable.DataSource);
      if (_canSave && !saveToolStripButton.Enabled && DataEditorPersister.IsDirty(PageSourceEnumerable))
      {
        toolStripButtonCancelEdit.Enabled = true;
        saveToolStripButton.Enabled = true;
      }
    }
    private void MaybeSetRemovingItem(dynamic dataSource)
    {
      if (dataSource != null) SetRemovingItem(dataSource);
    }

    private void SetRemovingItem<T>(ObjectListView<T> objectListView)
    {
        objectListView.RemovingItem += GridDataEditor_RemovingItem;
    }

    private void SetRemovingItem(ObjectListView objectListView)
    {
      objectListView.RemovingItem += GridDataEditor_RemovingItem;
    }

    private void SetRemovingItem(object ignore)
    {
    }

    private void MaybeUnSetRemovingItem(dynamic dataSource)
    {
      if (dataSource != null) SetUnRemovingItem(dataSource);
    }

    private void SetUnRemovingItem<T>(ObjectListView<T> objectListView)
    {
      objectListView.RemovingItem -= GridDataEditor_RemovingItem;
    }

    private void SetUnRemovingItem(ObjectListView objectListView)
    {
      objectListView.RemovingItem -= GridDataEditor_RemovingItem;
    }

    private void SetUnRemovingItem(object ignore)
    {
    }

    private bool IsObjectListView()
    {
      return BindingListHelper.IsObjectListView(bindingSourceEnumerable.DataSource);
    }

    private bool DataSourceIsObjectListView
    {
      get { return IsObjectListView(); }
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

    private void TidyUp()
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
    public static OutputFormat SerializeToCSharpOutputFormat = OutputFormat.Compileable;

    private Type ItemType
    {
      get
      {
        if (_itemType == null && bindingSourceEnumerable.DataSource != null)
          ItemType = MetaDataHelper.GetEnumerableItemType(BindingSourceEnumerableList);
        return _itemType;
      }
      set
      {
        if (_itemType == value) return;
        TidyUp();
        _itemType = value;
        OnSetItemType();
      }
    }

    private void SetItemType(IEnumerable enumerable)
    {
      if (enumerable != null)
        ItemType = MetaDataHelper.GetEnumerableItemType(enumerable);
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
            bindingNavigatorPaging.Enabled = AllowPagingWhenEditing;
            break;

          case ListChangedType.ItemChanged:
          case ListChangedType.ItemAdded:
            saveToolStripButton.Enabled = _canSave;
            toolStripButtonCancelEdit.Enabled = true;
            bindingNavigatorPaging.Enabled = AllowPagingWhenEditing;
            break;
        }
    }

    private void toolStripButtonCancelEdit_Click(object sender, EventArgs e)
    {
      CancelEdits();
    }

    public bool CancelEdits()
    {
      bindingSourceEnumerable.CancelEdit();
      if (DataEditorPersister != null && DataEditorPersister.Undo(BindingSourceEnumerableList))
      {
        bindingSourceEnumerable.ResetBindings(false);
        saveToolStripButton.Enabled = false;
      }
      SetButtonsOnEditEnded();
      return !saveToolStripButton.Enabled;
    }

    private void toolStripButtonObjectListViewVisualizer_Click(object sender, EventArgs e)
    {
      var visualizerForm = ObjectListViewHelper.CreateVisualizerForm(BindingSourceEnumerableList);
      if (visualizerForm != null)
        visualizerForm.ShowDialog();
    }

    private void toolStripButtonObjectBrowser_Click(object sender, EventArgs e)
    {
      FrmEntityViewer.LaunchAsChildForm(BindingSourceEnumerableList, DataEditorPersister);
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
      MaybeUnSetRemovingItem(bindingSourceEnumerable.DataSource);
      dataGridViewEnumerable.ClearFilter();
      dataGridViewEnumerable.ClearSort();
      dataGridEnumerable.DataSource = null;
    }

    private void dataGridViewEnumerable_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
    {
      var dataGridView = e.Column.DataGridView;
      if (MembersToExclude != null && MembersToExclude.Contains(e.Column.DataPropertyName))
        dataGridView.Columns.Remove(e.Column);

      dataGridViewEnumerable.DefaultCellBehavior = bindingSourceEnumerable.SupportsFiltering ? ADGVColumnHeaderCellBehavior.SortingFiltering:ADGVColumnHeaderCellBehavior.SortingStandartGlyph;
      if (dataGridViewEnumerable.DefaultCellBehavior==ADGVColumnHeaderCellBehavior.SortingFiltering)
      {
        var adgvColumnHeaderCell = e.Column.HeaderCell as ADGVColumnHeaderCell;
        if (adgvColumnHeaderCell != null) adgvColumnHeaderCell.CellBehavior = ADGVColumnHeaderCellBehavior.SortingFiltering;
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
      var dataGridViewColumn = dataGridViewEnumerable.Columns[e.ColumnIndex];
      var valueType = MetaDataHelper.GetCoreType(dataGridViewColumn.ValueType);
      if (valueType != null && valueType.IsEnum)
      {
        if (e.Value == null || MetaDataHelper.GetCoreType(e.Value.GetType()).IsEnum && !Enum.IsDefined(valueType, e.Value))
        {
          e.Value = ""; //e.CellStyle.NullValue
          e.FormattingApplied = true;
        } //e.Value = e.Value.ToString();
        //else
        //  if (e.Value is ValueTypeWrapper)
        //  {
        //    e.Value = "";
        //    e.FormattingApplied = true;
        //  }//e.Value = e.Value.ToString();
      }
      else if (dataGridViewColumn is DataGridViewImageColumn)
      {
        if (e.Value == null || e.Value is ICollection && ((ICollection) e.Value).IsNullOrEmpty())
        {
        //  e.Value = dataGridViewColumn.CellTemplate.DefaultNewRowValue;
          e.Value = e.CellStyle.NullValue;
          e.FormattingApplied = true;
        }
      }
     
    }

    private void dataGridViewEnumerable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      if (dataGridViewEnumerable.Visible && (!IsBinding || e.ListChangedType == ListChangedType.PropertyDescriptorChanged))
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
    }

    private void dataGridViewEnumerable_FilterStringChanged(object sender, EventArgs e)
    {
      if (bindingSourceEnumerable.SupportsFiltering)
      {
        bindingSourceEnumerable.Filter = dataGridViewEnumerable.FilterString;
        toolStripButtonClearFilters.Visible = !String.IsNullOrWhiteSpace(dataGridViewEnumerable.FilterString);
        toolStripButtonClearFilters.ToolTipText = dataGridViewEnumerable.FilterString;
      }
    }

    private void dataGridViewEnumerable_SortStringChanged(object sender, EventArgs e)
    {
      //  if (bindingSourceEnumerable.SortProperty==null || !string.IsNullOrWhiteSpace(bindingSourceEnumerable.Sort))
      if (dataGridViewEnumerable.SortedColumn == null || dataGridViewEnumerable.SortedColumn.SortMode != DataGridViewColumnSortMode.Automatic)
      {
        var isBinding = IsBinding;
        IsBinding = true;
        try
        {
          bindingSourceEnumerable.Sort = dataGridViewEnumerable.SortString;
        }
        finally
        {
          IsBinding = isBinding;
        }
      }
    }

    private void toolStripButtonUnPage_Click(object sender, EventArgs e)
    {
      ChangePageSize(0);
    }

    private void toolStripButtonSetPageSize_Click(object sender, EventArgs e)
    {
      ChangePageSize(Convert.ToUInt16(toolStripTextBoxNewPageSize.Text));
    }

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

        //BindEnumerable(new Csla.ObjectListView(BindingSourceEnumerableList));
        toolStripButtonEnableFilter.Visible = false;
      }
    }

    private IList BindingSourceEnumerableList
    {
      get { return bindingSourceEnumerable.List; }
    }

    private IEnumerable SourceEnumerable
    {
      get { return _superset ?? PageSourceEnumerable; }
    }

    private IEnumerable PageSourceEnumerable
    {
      get { return bindingSourceEnumerable.GetDataSource(); }
    }

    [Category("GridDataEditor"), Description("Gets or sets wether filtering is enabled in the grid, even if the underlying collection doesn't support it.")]
    public bool EnsureFilteringEnabled { get; set; }

    public Func<IEnumerable, Type, IBindingListView> BindingListViewCreater;

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

    private void searchToolBar_Search(object sender, SearchToolBarSearchEventArgs e)
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

    private void toolStripButtonMultiLine_Click(object sender, EventArgs e)
    {
      var selectedColumns = dataGridViewEnumerable.SelectedColumns.OfType<DataGridViewTextBoxColumn>().ToList();
      if (selectedColumns.Any())
      foreach (var selectedColumn in selectedColumns)
      {
        selectedColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
      }
      else
      {
        foreach (var dataGridTextBoxColumn in dataGridViewEnumerable.SelectedCells.OfType<DataGridViewTextBoxCell>())
        {
          dataGridTextBoxColumn.Style.WrapMode = DataGridViewTriState.True;
        }
     //         var currentDataGridTextBoxColumn = dataGridViewEnumerable.CurrentCell as ;
     // if (currentDataGridTextBoxColumn != null)
     // {
     ////   currentDataGridTextBoxColumn.WrapMode = DataGridViewTriState.True;
     //   dataGridViewEnumerable.CurrentCell.Style.WrapMode = DataGridViewTriState.True;
     //  // dataGridViewEnumerable.CurrentCell.
     // }
      }

      dataGridViewEnumerable.AutoSizeRowsMode=DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
    }

    private void dataGridViewEnumerable_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
      var textBox = e.Control as TextBox;
      if (textBox != null)
      {
        //textBox.Multiline = true;
        textBox.ScrollBars = ScrollBars.Both;
      }
    }

    private void toolStripButtonCellPopOut_Click(object sender, EventArgs e)
    {
      var dataGridViewTextBoxCell = dataGridViewEnumerable.CurrentCell as DataGridViewTextBoxCell;
      if (dataGridViewTextBoxCell != null)
      {
        var text = Convert.ToString(dataGridViewTextBoxCell.Value);
        var editedText = TextEditor.ShowTextEditorDialog(text);
        if (editedText != null)
          dataGridViewTextBoxCell.Value = editedText;
      }
    }

    private void toolStripButtonCSharp_Click(object sender, EventArgs e)
    {
      var cSharp = SourceEnumerable.SerializeToCSharp(SerializeToCSharpOutputFormat, PromptForPropertiesToExclude());
      var frmQueryRunner = DataEditorPersister==null? new FrmQueryRunner(): new FrmQueryRunner(DataEditorPersister.Save, DataEditorPersister.Delete);
      frmQueryRunner.ViewText(cSharp);
      frmQueryRunner.ShowDialog();
      Settings.Default.Save();
    }

    private string PromptForPropertiesToExclude()
    {
      Helper.Properties.Settings.Default.PropertiesToExclude = Interaction.InputBox(
        String.Format("Enter the properties to exclude from {0} and {1};{2}seperated by commas.",
          SourceEnumerable.GetType().FriendlyName(), ItemType.FriendlyName(), Environment.NewLine),
        "Choose Properties To Exclude", Helper.Properties.Settings.Default.PropertiesToExclude);
      return Helper.Properties.Settings.Default.PropertiesToExclude;
    }

    public void BeginInit()
    {
      ((ISupportInitialize)(this.bindingSourceEnumerable)).BeginInit();
      ((ISupportInitialize)(this.bindingNavigatorData)).BeginInit();
      ((ISupportInitialize)(this.dataGridViewEnumerable)).BeginInit();
      ((ISupportInitialize)(this.bindingNavigatorPaging)).BeginInit();
      ((ISupportInitialize)(this.bindingSourcePaging)).BeginInit();
      ((ISupportInitialize)(this.dataGridEnumerable)).BeginInit();
    }

    public void EndInit()
    {
      ((ISupportInitialize)(this.bindingSourceEnumerable)).EndInit();
      ((ISupportInitialize)(this.bindingNavigatorData)).EndInit();
      ((ISupportInitialize)(this.dataGridViewEnumerable)).EndInit();
      ((ISupportInitialize)(this.bindingNavigatorPaging)).EndInit();
      ((ISupportInitialize)(this.bindingSourcePaging)).EndInit();
      ((ISupportInitialize)(this.dataGridEnumerable)).EndInit();
    }
  }
}