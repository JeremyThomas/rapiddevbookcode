using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Linq.Dynamic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADGV;
using AW.Helper;
using AW.Helper.Annotations;
using AW.Helper.PropertyDescriptors;
using AW.Helper.TypeConverters;
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
  public partial class GridDataEditor : UserControl, ISupportInitialize, INotifyPropertyChanged
  {
    /// <summary>
    /// Gets or sets the members(columns) to exclude from displaying in the grid.
    /// </summary>
    /// <value>
    /// The members to exclude.
    /// </value>
    public string[] MembersToExclude { get; set; }

    /// <summary>
    /// The default page size
    /// </summary>
    public const int DefaultPageSize = 30;

    /// <summary>
    ///   The maximum automatic generate column width - 300
    /// </summary>
    private const int MaxAutoGenerateColumnWidth = 300;
    private const bool AllowPagingWhenEditing = true;
    private IEnumerable _delayedEnumerable;
    private readonly ArrayList _deleteItems = new ArrayList();
    private bool _isBinding = true;
    private bool _loaded;
    private bool _canSave;
    private IEnumerable _superset;
    private IDataEditorPersister _dataEditorPersister;
    private IDataEditorPersisterWithCounts _dataEditorPersisterWithCounts;
    private bool _fullyPainted;

    private static readonly Dictionary<Type, FieldsToPropertiesTypeDescriptionProvider> FieldsToPropertiesTypeDescriptionProviders
      = new Dictionary<Type, FieldsToPropertiesTypeDescriptionProvider>();

    static GridDataEditor()
    {
      AddConvertersAndDescriptors.AddIfNotAllready();
    }

    public GridDataEditor()
    {
      InitializeComponent();

      toolStripComboBoxClipboardCopyMode.ComboBox.MakeFormatUsingTypeConverter();

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
      _searchToolStripButton = searchToolBar.Items[4] as ToolStripButton;
      _searchToolStripTextBox = searchToolBar.Items[3] as ToolStripTextBox;
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="T:System.Windows.Forms.UserControl" /> class.
    /// </summary>
    public GridDataEditor(IEnumerable enumerable, bool delayBind = false, IDataEditorPersister dataEditorPersister = null, ushort pageSize = DefaultPageSize, bool readOnly = true,
      bool showPublicFields = false,
      params string[] membersToExclude)
      : this()
    {
      MembersToExclude = membersToExclude;
      ShowPublicFields = showPublicFields;
      SetItemType(enumerable);
      if (ValueTypeWrapper.TypeNeedsWrappingForBinding(_itemType))
      {
        enumerable = ValueTypeWrapper.CreateWrapperForBinding(enumerable);
        SetItemType(enumerable);
        readOnly = readOnly || !_itemType.IsGenericType;
      }
      else if (_itemType.IsArray || _itemType.Implements(typeof(IList)))
      {
        var dt = enumerable.CopyToDataTable();
        enumerable = dt.DefaultView;
        SetItemType(enumerable);
      }
      DelayBind = delayBind;
      DataEditorPersister = dataEditorPersister;
      Readonly = readOnly;
      tabControlGrids.SelectedTab = tabPageDataGridView;
      if (DelayBind)
      {
        PageSize = pageSize;
        _delayedEnumerable = enumerable;
      }
      else
        BindEnumerable(enumerable, pageSize);
    }
    
    private void MoveLastItem(int offset)
    {
      var toolStripItem = searchToolBar.Items[searchToolBar.Items.Count - 1];
      searchToolBar.Items.Remove(toolStripItem);
      searchToolBar.Items.Insert(searchToolBar.Items.Count - offset, toolStripItem);
    }

    #region Properties

    [Category("Data"), Description("Delay binding until the grid is visible")]
    public bool DelayBind { get; set; }

    [Category("Data"), Description("Show public fields as well as properties, used by LINQPad LINQToSQL")]
    public bool ShowPublicFields { get; set; }

    [Category("Data"), Description("Size of the page")]
    public ushort PageSize
    {
      get { return _pageSize; }
      set
      {
        _pageSize = value;
        toolStripLabelCurrentPagesSize.Text = _pageSize.ToString(CultureInfo.InvariantCulture);
        OnPropertyChanged();
      }
    }

    [Description("Deletes cascade non-recursively to children of the selected entity")]
    public bool CascadeDeletes
    {
      get { return toolStripCheckBoxDeletesAreCascading.Checked; }
      set { toolStripCheckBoxDeletesAreCascading.Checked = value; }
    }

    [Category("GridDataEditor"), Description("Gets or sets wether filtering is enabled in the grid, even if the underlying collection doesn't support it.")]
    public bool EnsureFilteringEnabled { get; set; }

    [AttributeProvider(typeof(IListSource)),
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

    [Editor("System.Windows.Forms.Design.DataMemberListEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)),
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
    [
    Browsable(true),
    DefaultValue(false)
]
    public bool Readonly
    {
      get { return dataGridViewEnumerable.ReadOnly; }
      set { dataGridViewEnumerable.ReadOnly = value; }
    }

    /// <summary>
    ///   Was the last bound Enumerable not writable when grid is not read-only
    /// </summary>
    private bool _shouldBeReadonly;

    public event PropertyChangedEventHandler PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      switch (keyData)
      {
        case Keys.Control | Keys.F:
        case Keys.F3:
          if (!searchToolBar.Visible)
          {
            searchToolBar.Show();
            searchToolBar.Focus();
            _searchToolStripTextBox.Focus();
          }
          _searchToolStripButton.PerformClick();
          break;
      }
      return base.ProcessCmdKey(ref msg, keyData);
    }

    private void printToolStripButton_Click(object sender, EventArgs e)
    {
      var frm = new FrmReportViewer {WindowState = FormWindowState.Normal};
      frm.OpenDataSet(bindingSourceEnumerable, false);
      frm.Show();
    }

    public static void CopyEntireDataGridViewToClipboard(DataGridView dataGridView)
    {
      dataGridView.SelectAll();
      var clipboardContent = dataGridView.GetClipboardContent();
      if (clipboardContent != null)
        Clipboard.SetDataObject(clipboardContent);
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
      //   toolStripComboBoxClipboardCopyMode.
      //toolStripComboBoxClipboardCopyMode.ComboBox.Format += (s, ec) =>
      //  {
      //    ec.Value = Convert.ToString(ec.Value);
      //  };
      if (toolStripComboBoxClipboardCopyMode.ComboBox != null)
        toolStripComboBoxClipboardCopyMode.ComboBox.DataSource =
          //  new[]
          //{
          //  DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText,
          //  DataGridViewClipboardCopyMode.EnableWithAutoHeaderText, DataGridViewClipboardCopyMode.EnableWithoutHeaderText
          //};
          GeneralHelper.EnumAsEnumerable<DataGridViewClipboardCopyMode>().Where(cm => cm != DataGridViewClipboardCopyMode.Disable).ToList();
      toolStripComboBoxClipboardCopyMode.SelectedItem = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

      _loaded = true;
    }

    /// <summary>
    ///   http://stackoverflow.com/questions/7309736/which-event-is-launched-right-after-control-is-fully-loaded
    /// </summary>
    /// <param name="m">The m.</param>
    protected override void WndProc(ref Message m)
    {
      base.WndProc(ref m);
      if (m.Msg == 15 && !_fullyPainted)
      {
        _fullyPainted = true;
        if (DelayBind && _delayedEnumerable != null)
        {
          BindEnumerable(_delayedEnumerable, PageSize);
          _delayedEnumerable = null;
        }
      }
    }

    private void saveToolStripButton_Click(object sender, EventArgs e)
    {
      SaveEdits(false);
    }

    public void SaveEdits(bool external = true)
    {
      dataGridViewEnumerable.EndEdit();
      var numSaved = DataEditorPersister.Save(PageSourceEnumerable, CascadeDeletes);
      toolStripLabelSaveResult.Text = @"numSaved: " + numSaved;
      if (HasDeletes)
      {
        var numDeleted = DataEditorPersister.Delete(_deleteItems, CascadeDeletes);
        toolStripLabelSaveResult.Text += @" numDeleted: " + numDeleted;
        if (_deleteItems.Count == numDeleted)
        {
          _deleteItems.Clear();
          toolStripLabelDeleteCount.Text = "";
          saveToolStripButton.Enabled = !SupportsNotifyPropertyChanged;
        }
        else
        {
          toolStripButtonCancelEdit.Enabled = true;
        }
      }
      else
        saveToolStripButton.Enabled = (!external && numSaved == 0) || !SupportsNotifyPropertyChanged;
      SetButtonsOnEditEnded();
    }

    private void toolStripCheckBoxDeletesAreCascading_CheckedChanged(object sender, EventArgs e)
    {
      // ReSharper disable once ExplicitCallerInfoArgument
      OnPropertyChanged("CascadeDeletes");
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
      Trace.Write(Name + " " + PageSourceEnumerable + " ");
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
        toolStripCheckBoxDeletesAreCascading.Visible = _canSave;
        toolStripCheckBoxDeletesAreCascading.Enabled = true;
        toolStripButtonRelatedCounts.Enabled = DataEditorPersister != null;
        toolStripButtonCSharp.Enabled = true;
        toolStripButtonSearch.Enabled = true;
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
        toolStripCheckBoxDeletesAreCascading.Enabled = false;
        toolStripButtonRelatedCounts.Enabled = false;
        toolStripButtonCSharp.Enabled = false;
        toolStripButtonSearch.Enabled = false;
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
      _isBinding = false;
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
        if (enumerable is ArrayList || enumerable is Array || enumerable is DataView || !IsGenericType(enumerable))
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
        _isBinding = true;
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
        _isBinding = false;
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
      _isBinding = true;
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
      return queryable == null ? LinqHelper.SkipTake(_superset, GetPageIndex(), PageSize) : AWHelper.SkipTakeDynamic(queryable, GetPageIndex(), PageSize);
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
      if (DataEditorPersister != null && !DataEditorPersister.TracksRemoves(PageSourceEnumerable))
        MaybeSetRemovingItem(bindingSourceEnumerable.DataSource);
      if (DataEditorPersister != null && _canSave && !saveToolStripButton.Enabled && DataEditorPersister.IsDirty(PageSourceEnumerable))
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

    private static void SetRemovingItem(object ignore)
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

    private static void SetUnRemovingItem(object ignore)
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
      if (_itemType != null && FieldsToPropertiesTypeDescriptionProviders.ContainsKey(_itemType))
      {
        TypeDescriptor.RemoveProvider(FieldsToPropertiesTypeDescriptionProviders[_itemType], _itemType);
        FieldsToPropertiesTypeDescriptionProviders.Remove(_itemType);
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
      SupportsNotifyPropertyChanged = typeof(INotifyPropertyChanged).IsAssignableFrom(ItemType);
      if (ShowPublicFields)
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
      if (!_isBinding && _loaded)
      {
        toolStripButtonCancelEdit.Enabled = true;
        bindingNavigatorPaging.Enabled = AllowPagingWhenEditing;
        // ReSharper disable once SwitchStatementMissingSomeCases
        switch (e.ListChangedType)
        {
          case ListChangedType.ItemDeleted:
            saveToolStripButton.Enabled = _canSave && (DataEditorPersister.TracksRemoves(PageSourceEnumerable) || !DataSourceIsObjectListView || HasDeletes);
            break;
          case ListChangedType.ItemChanged:
            saveToolStripButton.Enabled = _canSave;
            break;
        }
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
      _deleteItems.Clear();
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

      var valueType = e.Column.ValueType;
      if (valueType == null)
      {
        PropertyInfo propertyInfo;
        try
        {
          propertyInfo = ItemType.GetProperty(e.Column.DataPropertyName);
        }
        catch (AmbiguousMatchException)
        {
          propertyInfo = ItemType.GetProperties().FirstOrDefault(p => p.Name == e.Column.DataPropertyName);
        }

        if (propertyInfo == null)
        {
          var dataView = SourceDataView;
          if (dataView != null)
          {
            var dataColumn = dataView.Table.Columns[e.Column.DataPropertyName];
            valueType = dataColumn.DataType;
          }
        }
        else
          valueType = propertyInfo.PropertyType;
      }
      var coreType = MetaDataHelper.GetCoreType(valueType);

      dataGridViewEnumerable.DefaultCellBehavior = bindingSourceEnumerable.SupportsFiltering ? ADGVColumnHeaderCellBehavior.SortingFiltering : ADGVColumnHeaderCellBehavior.SortingStandartGlyph;
      if (dataGridViewEnumerable.DefaultCellBehavior == ADGVColumnHeaderCellBehavior.SortingFiltering && coreType != null)
      {
        var adgvColumnHeaderCell = e.Column.HeaderCell as ADGVColumnHeaderCell;
        if (adgvColumnHeaderCell != null)
          if (!MetaDataHelper.ImplementsIComparable(coreType)) //For testing || e.Column.DataPropertyName == "ModifiedDate"
            adgvColumnHeaderCell.CellBehavior = ADGVColumnHeaderCellBehavior.DisabledHidden;
      }

      if (coreType == null || e.Column is DataGridViewComboBoxColumn || e.Column is DataGridViewDateTimeColumn || e.Column is DataGridViewCheckBoxColumn) return;

      if (coreType == typeof(bool) && !(e.Column is DataGridViewCheckBoxColumn))
      {
        var dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn
        {
          HeaderText = e.Column.HeaderText,
          ValueType = valueType,
          DataPropertyName = e.Column.DataPropertyName,
          SortMode = e.Column.SortMode,
          Name = e.Column.Name,
          DefaultCellStyle = e.Column.DefaultCellStyle,
        };
        dataGridViewCheckBoxColumn.SortMode = e.Column.SortMode;
        if (valueType == typeof(bool?))
        {
          dataGridViewCheckBoxColumn.ThreeState = true;
          dataGridViewCheckBoxColumn.DefaultCellStyle.NullValue = CheckState.Indeterminate;
        }
        dataGridView.Columns.Remove(e.Column);
        dataGridView.Columns.Add(dataGridViewCheckBoxColumn);
      }
      else
      {
        if (Readonly || _shouldBeReadonly) return;
        if (coreType.IsEnum)
        {
          var enumDataSource = coreType == valueType ? Enum.GetValues(coreType) : GeneralHelper.EnumsGetValuesPlusUndefined(coreType);
          var isDataTable = SourceDataView != null;
          if (isDataTable)
          {
            valueType = Enum.GetUnderlyingType(coreType);
            enumDataSource = GeneralHelper.Enum2DataTable(Enum.GetValues(coreType), valueType).DefaultView;
            //enumDataSource = enumDataSource.OfType<Enum>().Select(value => new {Display = value.EnumToString(), Value = Convert.ChangeType(value, valueType)}).ToList();
          }
          else
            HumanizedEnumConverter.AddEnumerationConverter(valueType);
          var enumDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn
          {
            HeaderText = e.Column.HeaderText,
            ValueType = valueType,
            DataSource = enumDataSource,
            DataPropertyName = e.Column.DataPropertyName,
            SortMode = e.Column.SortMode,
            DefaultCellStyle = e.Column.DefaultCellStyle,
            Name = e.Column.Name
          };

          if (isDataTable)
          {
            enumDataGridViewComboBoxColumn.ValueMember = "Value";
            enumDataGridViewComboBoxColumn.DisplayMember = "Display";
          }
          dataGridView.Columns.Remove(e.Column);
          dataGridView.Columns.Add(enumDataGridViewComboBoxColumn);
          enumDataGridViewComboBoxColumn.SortMode = e.Column.SortMode;
        }
        else if (coreType == typeof(DateTime))
        {
          var dataGridViewDateTimeColumn = new DataGridViewDateTimeColumn
          {
            HeaderText = e.Column.HeaderText,
            ValueType = valueType,
            DataPropertyName = e.Column.DataPropertyName,
            SortMode = e.Column.SortMode,
            DefaultCellStyle = e.Column.DefaultCellStyle,
            Name = e.Column.Name
          };
          dataGridViewDateTimeColumn.SortMode = e.Column.SortMode;
          dataGridView.Columns.Remove(e.Column);
          dataGridView.Columns.Add(dataGridViewDateTimeColumn);
        }
      }
      //else if(e.Column.Tag==null)
      //{
      //  dataGridView.Columns.Remove(e.Column);
      //  e.Column.Tag = true;
      //  dataGridView.Columns.Add(e.Column);
      //}
    }

    private void dataGridViewEnumerable_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
    {
      //TODO fix http://stackoverflow.com/questions/768170/datagridview-repeatedly-recreating-columns 
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
      if (dataGridViewEnumerable.Visible && (!_isBinding || e.ListChangedType == ListChangedType.PropertyDescriptorChanged))
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
        toolStripButtonClearFilters.Visible = !string.IsNullOrWhiteSpace(dataGridViewEnumerable.FilterString);
        toolStripButtonClearFilters.ToolTipText = dataGridViewEnumerable.FilterString;
      }
    }

    private void dataGridViewEnumerable_SortStringChanged(object sender, EventArgs e)
    {
      //  if (bindingSourceEnumerable.SortProperty==null || !string.IsNullOrWhiteSpace(bindingSourceEnumerable.Sort))
      if (dataGridViewEnumerable.SortedColumn == null || dataGridViewEnumerable.SortedColumn.SortMode != DataGridViewColumnSortMode.Automatic)
      {
        var isBinding = _isBinding;
        _isBinding = true;
        try
        {
          bindingSourceEnumerable.Sort = dataGridViewEnumerable.SortString;
        }
        finally
        {
          _isBinding = isBinding;
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
        // ReSharper disable once ExplicitCallerInfoArgument
        OnPropertyChanged("EnsureFilteringEnabled");
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

    private DataView SourceDataView
    {
      get { return SourceEnumerable as DataView; }
    }

    public IDataEditorPersister DataEditorPersister
    {
      get { return _dataEditorPersister; }
      set
      {
        _dataEditorPersister = value;
        _dataEditorPersisterWithCounts = value as IDataEditorPersisterWithCounts;
        toolStripButtonRelatedCounts.Enabled = _dataEditorPersisterWithCounts != null;
      }
    }

    public Func<IEnumerable, Type, IBindingListView> BindingListViewCreater;
    private readonly ToolStripButton _searchToolStripButton;
    private readonly ToolStripTextBox _searchToolStripTextBox;

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
      if (c == null && startRow != 0)
      {
        c = dataGridViewEnumerable.FindCell(
          e.ValueToSearch,
          e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
          0,
          0,
          e.WholeWord,
          e.CaseSensitive);
      }
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

      dataGridViewEnumerable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
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
      var frmQueryRunner = DataEditorPersister == null ? new FrmQueryRunner() : new FrmQueryRunner(DataEditorPersister.Save, DataEditorPersister.Delete);
      frmQueryRunner.ViewText(cSharp);
      frmQueryRunner.ShowDialog();
      Settings.Default.Save();
    }

    private string PromptForPropertiesToExclude()
    {
      Helper.Properties.Settings.Default.PropertiesToExclude = Interaction.InputBox(
        string.Format("Enter the properties to exclude from {0} and {1};{2}seperated by commas.",
          SourceEnumerable.GetType().FriendlyName(), ItemType.FriendlyName(), Environment.NewLine),
        "Choose Properties To Exclude", Helper.Properties.Settings.Default.PropertiesToExclude);
      return Helper.Properties.Settings.Default.PropertiesToExclude;
    }

    public void BeginInit()
    {
      ((ISupportInitialize) bindingSourceEnumerable).BeginInit();
      ((ISupportInitialize) bindingNavigatorData).BeginInit();
      ((ISupportInitialize) dataGridViewEnumerable).BeginInit();
      ((ISupportInitialize) bindingNavigatorPaging).BeginInit();
      ((ISupportInitialize) bindingSourcePaging).BeginInit();
      ((ISupportInitialize) dataGridEnumerable).BeginInit();
    }

    public void EndInit()
    {
      ((ISupportInitialize) bindingSourceEnumerable).EndInit();
      ((ISupportInitialize) bindingNavigatorData).EndInit();
      ((ISupportInitialize) dataGridViewEnumerable).EndInit();
      ((ISupportInitialize) bindingNavigatorPaging).EndInit();
      ((ISupportInitialize) bindingSourcePaging).EndInit();
      ((ISupportInitialize) dataGridEnumerable).EndInit();
    }

    private void toolStripButtonRelatedCounts_Click(object sender, EventArgs e)
    {
      if (bindingSourceEnumerable.Current != null)
      {
        var existingRelatedCounts = GetExistingRelatedCounts(bindingSourceEnumerable.Current);
        if (existingRelatedCounts.Any())
        {
          //toolStripLabelNumChildren.Text = existingRelatedCounts.JoinAsString(Environment.NewLine);
          MessageBox.Show(existingRelatedCounts.JoinAsString(Environment.NewLine), string.Format("Number of references to {0}", bindingSourceEnumerable.Current));
        }
      }
    }

    private IDictionary<string, int> GetExistingRelatedCounts(object entityThatMayHaveChildren)
    {
      return _dataEditorPersisterWithCounts.GetChildCounts(entityThatMayHaveChildren);
    }

    private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
    {
      if (dataGridViewEnumerable.SelectedRows.Count > 1)
      {
        dataGridViewEnumerable.Focus();
        SendKeys.Send("{DEL}");
      }
    }

    private void dataGridViewEnumerable_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
        DeleteCellsIfNotInEditMode();
    }

    private void DeleteCellsIfNotInEditMode()
    {
      if (!dataGridViewEnumerable.CurrentCell.IsInEditMode)
        foreach (DataGridViewCell selectedCell in dataGridViewEnumerable.SelectedCells)
          if (!selectedCell.OwningRow.Selected)
            selectedCell.Value = selectedCell.ValueType == typeof(string) ? string.Empty : MetaDataHelper.GetDefault(selectedCell.ValueType);
    }

    /// <summary>
    /// Handles the CurrentCellDirtyStateChanged event of the dataGridViewEnumerable control.
    /// </summary>
    /// <remarks>http://stackoverflow.com/questions/9608343/datagridview-combobox-column-change-cell-value-after-selection-from-dropdown-is</remarks>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void dataGridViewEnumerable_CurrentCellDirtyStateChanged(object sender, EventArgs e)
    {
      var dataGridView = sender as DataGridView;
      if (dataGridView == null)
        return;
      var isComboBox = dataGridView.CurrentCell is DataGridViewComboBoxCell;
      if ((isComboBox || dataGridView.CurrentCell is DataGridViewCheckBoxCell) 
        && dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit) 
        && isComboBox && dataGridView.EndEdit())
        dataGridView.BindingContext[dataGridView.DataSource].EndCurrentEdit();
    }
  }
}