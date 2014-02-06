using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AW.Helper;
using AW.Winforms.Helpers.DataEditor;
using JesseJohnston;

namespace AW.Winforms.Helpers.Controls
{
  public partial class GridDataEditorT<T> : GridDataEditor
  {
    private IQueryable<T> _supersetG;

    public GridDataEditorT()
    {
      OnSetItemType();
    }

    public static GridDataEditor GridDataEditorFactory(IEnumerable<T> enumerable)
    {
      return GridDataEditorFactory(enumerable, null, DataEditorExtensions.DefaultPageSize, true);
    }

    public static GridDataEditor GridDataEditorFactory(IEnumerable<T> enumerable, IDataEditorPersister dataEditorPersister, ushort pageSize, bool readOnly)
    {
      GridDataEditor gridDataEditor;
      if (ValueTypeWrapper<T>.TypeNeedsWrappingForBinding())
      {
        gridDataEditor = new GridDataEditorT<ValueTypeWrapper<T>>();
        var enumerableWrapperForBinding = ValueTypeWrapper<T>.CreateWrapperForBinding(enumerable);
        gridDataEditor.InitialiseAndBindGridDataEditor(enumerableWrapperForBinding, dataEditorPersister, pageSize, readOnly);
      }
      else
      {
        gridDataEditor = new GridDataEditorT<T>();
        gridDataEditor.InitialiseAndBindGridDataEditor(enumerable, dataEditorPersister, pageSize, readOnly);
      }
      return gridDataEditor;
    }

    protected override Type ItemType
    {
      get { return typeof (T); }
    }

    protected override bool GetFirstPage()
    {
      return GetFirstPage(_supersetG);
    }

    protected override bool GetFirstPage(IEnumerable enumerable)
    {
      return GetFirstPage((IEnumerable<T>) enumerable);
    }

    private bool GetFirstPage(IEnumerable<T> enumerable)
    {
      var firstPageEnumerable = enumerable;
      if (Paging())
        firstPageEnumerable = firstPageEnumerable.AsQueryable().Take(PageSize);
      var isEnumerable = bindingSourceEnumerable.BindEnumerable(firstPageEnumerable, EnumerableShouldBeReadonly(enumerable, typeof(T)), EnsureFilteringEnabled);
      IsBinding = false;
      return isEnumerable;
    }

    protected override IEnumerable<int> CreatePageDataSource(ushort pageSize, IEnumerable enumerable)
    {
      return CreatePageDataSourceImplementation(pageSize, (IQueryable<T>) enumerable.AsQueryable());
    }

    protected IEnumerable<int> CreatePageDataSourceImplementation(ushort pageSize, IQueryable<T> enumerable)
    {
      PageSize = pageSize;
      _supersetG = enumerable;
      if (pageSize == 0 || Empty())
        return Enumerable.Empty<int>();
      return Enumerable.Range(1, GetPageCount());
    }

    private bool Empty()
    {
      return SuperSetCount() == 0;
    }

    protected override int SuperSetCount()
    {
      if (!_superSetCount.HasValue)
        _superSetCount = _supersetG != null ? _supersetG.Count() : _superSetCount.GetValueOrDefault();
      return _superSetCount.Value;
    }

    protected override void SetRemovingItem()
    {
      if (SupportsNotifyPropertyChanged)
        saveToolStripButton.Enabled = false;
      if (bindingSourceEnumerable.DataSource is ObjectListView<T>)
        ((ObjectListView<T>) bindingSourceEnumerable.DataSource).RemovingItem += GridDataEditor_RemovingItem;
      else
        base.SetRemovingItem();
    }

    protected override void BindEnumerable()
    {
      bindingSourceEnumerable.BindEnumerable(SkipTake(), false);
    }

    protected override IEnumerable SourceEnumerable
    {
      get { return (IEnumerable)_supersetG ?? bindingSourceEnumerable.List; }
    }

    private IEnumerable<T> SkipTake()
    {
      return _supersetG.SkipTake(GetPageIndex(), PageSize);
    }

    protected override bool IsObjectListView()
    {
      return bindingSourceEnumerable.List is ObjectListView<T>;
    }
  }
}