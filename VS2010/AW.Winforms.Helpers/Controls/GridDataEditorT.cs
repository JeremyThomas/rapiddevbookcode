using System;
using System.Collections;
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

		protected override bool GetFirstPage()
		{
			return GetFirstPage(_supersetG);
		}

		protected override bool GetFirstPage(IEnumerable enumerable)
		{
			return GetFirstPage((IEnumerable<T>)enumerable);
		}

		private bool GetFirstPage(IEnumerable<T> enumerable)
		{
			if (Paging())
				enumerable = enumerable.Take(PageSize);
			var isEnumerable = bindingSourceEnumerable.BindEnumerable(enumerable, EnumerableShouldBeReadonly(_supersetG, typeof(T)));
			return isEnumerable;
		}

		protected override IEnumerable<int> CreatePageDataSource(ushort pageSize, IEnumerable enumerable)
		{
			return CreatePageDataSource(pageSize, (IEnumerable<T>)enumerable);
		}

		protected IEnumerable<int> CreatePageDataSource(ushort pageSize, IEnumerable<T> enumerable)
		{
			PageSize = pageSize;
			_supersetG = enumerable;
			if (pageSize == 0 || !enumerable.Any())
				return Enumerable.Empty<int>();
			return Enumerable.Range(1, GetPageCount());
		}

		protected override int SuperSetCount()
		{
			return _supersetG != null ? _supersetG.Count() : 0;
		}

		protected override void SetRemovingItem()
		{			
			if (bindingSourceEnumerable.DataSource is ObjectListView<T>)
				((ObjectListView<T>)bindingSourceEnumerable.DataSource).RemovingItem += GridDataEditor_RemovingItem;
			else
				base.SetRemovingItem();
		}

		protected override void BindEnumerable()
		{
			bindingSourceEnumerable.BindEnumerable(SkipTake(), false);
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