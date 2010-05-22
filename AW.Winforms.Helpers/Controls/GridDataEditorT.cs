using System;
using System.Collections.Generic;
using System.Linq;
using AW.Helper;
using JesseJohnston;

namespace AW.Winforms.Helpers.Controls
{
  public partial class GridDataEditorT<T> : GridDataEditor
  {
    private IEnumerable<T> _supersetG;

  	protected override Type ItemType
  	{
			get { return typeof(T); }
  	}

  	public bool BindEnumerable(IEnumerable<T> enumerable)
    {
      return BindEnumerable(enumerable, PageSize);
    }

    public bool BindEnumerable(IEnumerable<T> enumerable, ushort pageSize)
    {
      bindingSourcePaging.DataSource = CreatePageDataSource(pageSize, enumerable);
      return GetFirstPage(enumerable);
    }

    private bool GetFirstPage(IEnumerable<T> enumerable)
    {
      if (Paging())
        enumerable = enumerable.Take(PageSize);
      var isEnumerable = bindingSourceEnumerable.BindEnumerable(enumerable, EnumerableShouldBeReadonly(enumerable, typeof (T)));
      if (bindingSourceEnumerable.DataSource is ObjectListView<T>)
        ((ObjectListView<T>) bindingSourceEnumerable.DataSource).RemovingItem += GridDataEditor_RemovingItem;
      else
        SetRemovingItem();
      return isEnumerable;
    }

    protected IEnumerable<int> CreatePageDataSource(ushort pageSize, IEnumerable<T> enumerable)
    {
      PageSize = pageSize;
      if (pageSize == 0)
        return Enumerable.Empty<int>();
      _supersetG = enumerable;
      return Enumerable.Range(1, GetPageCount());
    }

    protected override int SuperSetCount()
    {
    	return _supersetG != null ? _supersetG.Count() : 0;
    }

  	protected override void BindPage()
    {
      if (GetPageIndex() > 0)
        bindingSourceEnumerable.BindEnumerable(SkipTake(), false);
      else
        GetFirstPage(_supersetG);
    }

    private IEnumerable<T> SkipTake()
    {
      return _supersetG.SkipTake(GetPageIndex(), PageSize);
    }
  }
}