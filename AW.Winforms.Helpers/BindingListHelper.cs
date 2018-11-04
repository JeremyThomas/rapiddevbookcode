using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AW.Helper;
using JesseJohnston;

namespace AW.Winforms.Helpers
{
  public static class BindingListHelper
  {
    private static readonly Dictionary<Type, Func<IEnumerable, Type, IBindingListView>> BindingListViewCreators = new Dictionary<Type, Func<IEnumerable, Type, IBindingListView>>();
    public static readonly Dictionary<Type, Func<IEnumerable, Type, CancellationToken, Task<IBindingListView>>> AsyncBindingListViewCreators 
      = new Dictionary<Type, Func<IEnumerable, Type, CancellationToken, Task<IBindingListView>>>();

    public static void RegisterBindingListViewCreator(Type itemType, Func<IEnumerable, Type, IBindingListView> bindingListViewCreator)
    {
        BindingListViewCreators[itemType] = bindingListViewCreator;
    }

    public static void RegisterAsyncBindingListViewCreator(Type itemType, Func<IEnumerable, Type, CancellationToken, Task<IBindingListView>> bindingListViewCreator)
    {
        AsyncBindingListViewCreators[itemType] = bindingListViewCreator;
    }

    private static readonly Dictionary<Type, Func<IBindingList, IEnumerable>> BindingListViewSources
      = new Dictionary<Type, Func<IBindingList, IEnumerable>>();

    public static void RegisterBindingListSourceProvider(Type itemType, Func<IBindingList, IEnumerable> bindingListViewCreator)
    {
      BindingListViewSources[itemType] = bindingListViewCreator;
    }

    //&& enumerable.ToString() != "System.Collections.Hashtable+KeyCollection"
    public static IBindingListView ToBindingListView(this IEnumerable enumerable, bool ensureFilteringEnabled = false
      , Func<IEnumerable, Type, IBindingListView> bindingListViewCreator = null)
    {
      var shownEnumerable = enumerable != null && !(enumerable is string);
      if (shownEnumerable)
      {
        var iBindingListView = enumerable as IBindingListView;
        if (iBindingListView != null && (!ensureFilteringEnabled || iBindingListView.SupportsFiltering))
          return iBindingListView;
        var listSource = enumerable as IListSource;
        if (listSource != null)
        {
          var bindingListView = ListSourceToBindingListView(listSource);
          if (bindingListView != null && (!ensureFilteringEnabled || bindingListView.SupportsFiltering))
            return bindingListView;
        }
        return MaybeCreateBindingListView(enumerable, ensureFilteringEnabled, bindingListViewCreator);
      }
      return null;
    }

    public static async Task<IBindingListView> ToBindingListViewAsync(this IEnumerable enumerable, CancellationToken cancellationToken, bool ensureFilteringEnabled = false
      , Func<IEnumerable, Type, CancellationToken, Task<IBindingListView>> bindingListViewCreator = null)
    {
      var shownEnumerable = enumerable != null && !(enumerable is string);
      if (shownEnumerable)
      {
        var iBindingListView = enumerable as IBindingListView;
        if (iBindingListView != null && (!ensureFilteringEnabled || iBindingListView.SupportsFiltering))
          return iBindingListView;
        var listSource = enumerable as IListSource;
        if (listSource != null)
        {
          var bindingListView = ListSourceToBindingListView(listSource);
          if (bindingListView != null && (!ensureFilteringEnabled || bindingListView.SupportsFiltering))
            return bindingListView;
        }
        return await MaybeCreateAsyncBindingListView(enumerable, cancellationToken, ensureFilteringEnabled, bindingListViewCreator);
      }
      return null;
    }

    public static IBindingListView ToBindingListView<T>(this IEnumerable<T> enumerable)
    {
      var shownEnumerable = enumerable != null && !(enumerable is string);
      if (shownEnumerable)
      {
        var view = enumerable as IBindingListView;
        if (view != null)
          return view;
        var listSource = enumerable as IListSource;
        if (listSource != null)
        {
          var bindingListView = ListSourceToBindingListView(listSource);
          if (bindingListView != null)
            return bindingListView;
        }
        return CreateBindingListView(enumerable);
      }
      return null;
    }

    public static async Task<IBindingListView> ToBindingListViewAsync<T>(this IEnumerable<T> enumerable, CancellationToken cancellationToken)
    {
      var shownEnumerable = enumerable != null && !(enumerable is string);
      if (shownEnumerable)
      {
        var view = enumerable as IBindingListView;
        if (view != null)
          return view;
        var listSource = enumerable as IListSource;
        if (listSource != null)
        {
          var bindingListView = ListSourceToBindingListView(listSource);
          if (bindingListView != null)
            return bindingListView;
        }
        return await CreateBindingListViewAsync(enumerable, cancellationToken);
      }
      return null;
    }

    public static IBindingListView ListSourceToBindingListView(IListSource listSource)
    {
      if (listSource != null)
      {
        var list = listSource.GetList();
        if (list != null)
          return list.ToBindingListView();
      }
      return null;
    }

    private static IBindingListView CreateBindingListView<T>(IEnumerable<T> enumerable, bool ensureFilteringEnabled = false,
      Func<IEnumerable, Type, IBindingListView> bindingListViewCreator = null)
    {
      var itemType = typeof(T);
      if (!MetaDataHelper.IsTheActualType(itemType))
      {
        var actualItemType = MetaDataHelper.GetEnumerableItemType(enumerable);
        if (actualItemType != itemType)
          return CreateBindingListView(enumerable, actualItemType, ensureFilteringEnabled, bindingListViewCreator); //else ListBindingHelper.GetListItemProperties doesn't get the properties
      }

      var bindingListView = bindingListViewCreator == null
        ? GetValidAndPotentialBindingListViews(enumerable, itemType, ensureFilteringEnabled, BindingListViewCreators)
        : bindingListViewCreator(enumerable, itemType);
      if (bindingListView != null && (!ensureFilteringEnabled || bindingListView.SupportsFiltering))
        return bindingListView;

      return ToObjectListView((IEnumerable<T>) GetDataSource(bindingListView, ensureFilteringEnabled) ?? enumerable);
    }

    private static async Task<IBindingListView> CreateBindingListViewAsync<T>(IEnumerable<T> enumerable, CancellationToken cancellationToken, bool ensureFilteringEnabled = false,
      Func<IEnumerable, Type, CancellationToken, Task<IBindingListView>> bindingListViewCreator = null)
    {
      var itemType = typeof(T);
      if (!MetaDataHelper.IsTheActualType(itemType))
      {
        var actualItemType = MetaDataHelper.GetEnumerableItemType(enumerable);
        if (actualItemType != itemType)
          return await CreateAsyncBindingListView(enumerable, actualItemType, cancellationToken, ensureFilteringEnabled, bindingListViewCreator); //else ListBindingHelper.GetListItemProperties doesn't get the properties
      }

      var bindingListView = bindingListViewCreator == null
        ? await GetValidAndPotentialAsyncBindingListViews(enumerable, itemType, cancellationToken, ensureFilteringEnabled, AsyncBindingListViewCreators)
        : await bindingListViewCreator(enumerable, itemType, cancellationToken);
      if (bindingListView != null && (!ensureFilteringEnabled || bindingListView.SupportsFiltering))
        return bindingListView;

      return ToObjectListView((IEnumerable<T>)GetDataSource(bindingListView, ensureFilteringEnabled) ?? enumerable);
    }

    private static IBindingListView MaybeCreateBindingListView(dynamic enumerable, bool ensureFilteringEnabled = false,
      Func<IEnumerable, Type, IBindingListView> bindingListViewCreator = null)
    {
      return CreateBindingListView(enumerable, ensureFilteringEnabled, bindingListViewCreator);
    }

    private static IBindingListView CreateBindingListView(IEnumerable enumerable, bool ensureFilteringEnabled = false,
      Func<IEnumerable, Type, IBindingListView> bindingListViewCreator = null)
    {
      var itemType = MetaDataHelper.GetEnumerableItemType(enumerable);
      return CreateBindingListView(enumerable, itemType, ensureFilteringEnabled, bindingListViewCreator);
    }

    private static Task<IBindingListView> MaybeCreateAsyncBindingListView(dynamic enumerable, CancellationToken cancellationToken, bool ensureFilteringEnabled = false,
      Func<IEnumerable, Type, CancellationToken, Task<IBindingListView>> bindingListViewCreator = null)
    {
      return CreateAsyncBindingListView(enumerable, cancellationToken, ensureFilteringEnabled, bindingListViewCreator);
    }

    private static Task<IBindingListView> CreateAsyncBindingListView(IEnumerable enumerable, CancellationToken cancellationToken, bool ensureFilteringEnabled = false,
      Func<IEnumerable, Type, CancellationToken, Task<IBindingListView>> bindingListViewCreator = null)
    {
      var itemType = MetaDataHelper.GetEnumerableItemType(enumerable);
      return CreateAsyncBindingListView(enumerable, itemType, cancellationToken, ensureFilteringEnabled, bindingListViewCreator);
    }

    /// <summary>
    ///   Creates the binding ListView.
    /// </summary>
    /// <param name="enumerable">The enumerable.</param>
    /// <param name="itemType">Type of the item.</param>
    /// <param name="ensureFilteringEnabled">if set to <c>true</c> [ensure filtering enabled].</param>
    /// <param name="bindingListViewCreator">The binding ListView creator.</param>
    /// <returns></returns>
    /// <remarks>
    ///   Get all valid bindingListViewCreator, then any and if ensureFilteringEnabled it get the first that supports it
    ///   else
    ///   CreateObjectListView from firs potential or enumerable if none
    /// </remarks>
    private static IBindingListView CreateBindingListView(IEnumerable enumerable, Type itemType, bool ensureFilteringEnabled = false,
      Func<IEnumerable, Type, IBindingListView> bindingListViewCreator = null)
    {
      var bindingListView = bindingListViewCreator == null
        ? GetValidAndPotentialBindingListViews(enumerable, itemType, ensureFilteringEnabled, BindingListViewCreators)
        : bindingListViewCreator(enumerable, itemType);
      if (bindingListView != null && (!ensureFilteringEnabled || bindingListView.SupportsFiltering))
        return bindingListView;
      return CreateObjectListView(GetDataSource(bindingListView) ?? enumerable, itemType);
    }

    private static IBindingListView GetValidAndPotentialBindingListViews(IEnumerable enumerable, Type itemType, bool ensureFilteringEnabled,
      Dictionary<Type, Func<IEnumerable, Type, IBindingListView>> bindingListViewCreators)
    {
      var potentialBindingListViewCreators = bindingListViewCreators.Where(bindingListViewCreator => bindingListViewCreator.Key.IsAssignableFrom(itemType));

      IBindingListView first = null;
      foreach (var bindingListView in potentialBindingListViewCreators.Select(bindingListViewCreator => bindingListViewCreator.Value(enumerable, itemType)))
      {
        if (bindingListView != null && (!ensureFilteringEnabled || bindingListView.SupportsFiltering))
          return bindingListView;
        if (first == null)
          first = bindingListView;
      }
      return first;
      //return potentialBindingListViews.FirstOrDefault(bindingListView => bindingListView != null && (!ensureFilteringEnabled || bindingListView.SupportsFiltering)) 
      //  ?? potentialBindingListViews.FirstOrDefault();
    }

    private static async Task<IBindingListView> CreateAsyncBindingListView(IEnumerable enumerable, Type itemType, CancellationToken cancellationToken, bool ensureFilteringEnabled = false,
      Func<IEnumerable, Type, CancellationToken, Task<IBindingListView>> bindingListViewCreator = null)
    {
      var bindingListView = bindingListViewCreator == null
        ? await GetValidAndPotentialAsyncBindingListViews(enumerable, itemType, cancellationToken, ensureFilteringEnabled, AsyncBindingListViewCreators)
        : await bindingListViewCreator(enumerable, itemType, cancellationToken);
      if (bindingListView != null && (!ensureFilteringEnabled || bindingListView.SupportsFiltering))
        return bindingListView;
      return CreateObjectListView(GetDataSource(bindingListView) ?? enumerable, itemType);
    }

    private static async Task<IBindingListView> GetValidAndPotentialAsyncBindingListViews(IEnumerable enumerable, Type itemType, CancellationToken cancellationToken, bool ensureFilteringEnabled,
      Dictionary<Type, Func<IEnumerable, Type, CancellationToken, Task<IBindingListView>>> bindingListViewCreators)
    {
      var potentialBindingListViewCreators = bindingListViewCreators.Where(bindingListViewCreator => bindingListViewCreator.Key.IsAssignableFrom(itemType));

      IBindingListView first = null;
      foreach (var bindingListViewCreator in potentialBindingListViewCreators)
      {
        // ReSharper disable once PossibleMultipleEnumeration
        var bindingListView = await bindingListViewCreator.Value(enumerable, itemType, cancellationToken);
        if (bindingListView != null && (!ensureFilteringEnabled || bindingListView.SupportsFiltering))
          return bindingListView;
        if (first == null)
          first = bindingListView;
      }
      return first;
      //return potentialBindingListViews.FirstOrDefault(bindingListView => bindingListView != null && (!ensureFilteringEnabled || bindingListView.SupportsFiltering)) 
      //  ?? potentialBindingListViews.FirstOrDefault();
    }

    private static ObjectListView CreateObjectListView(ICollection collection)
    {
      return new ObjectListView(new ArrayList(collection));
    }

    /// <summary>
    ///   Creates the object list view.
    /// </summary>
    /// <param name="enumerable">The enumerable.</param>
    /// <param name="itemType">Type of the item.</param>
    /// <returns></returns>
    public static ObjectListView CreateObjectListView(IEnumerable enumerable, Type itemType)
    {
      enumerable = (IEnumerable) ListBindingHelper.GetList(enumerable);
      return CreateObjectListViewDirect(enumerable, itemType);
    }

    private static IBindingListView ToObjectListView<T>(IEnumerable<T> enumerable)
    {
      var list = enumerable as IList<T>;
      if (list != null)
        return ToObjectListView(list);
      enumerable = (IEnumerable<T>) ListBindingHelper.GetList(enumerable);
      return ToObjectListView(enumerable as IList<T> ?? enumerable.ToList());
    }

    private static ObjectListView<T> ToObjectListView<T>(IList<T> list)
    {
      if (list != null)
      {
        var objectListView = new ObjectListView<T>(list);
        return objectListView;
      }
      return null;
    }

    private static ObjectListView CreateObjectListViewDirect(IEnumerable enumerable, Type itemType)
    {
      var bindingList = enumerable as IBindingList;
      ObjectListView objectListView;
      if (bindingList == null)
      {
        var list = enumerable as IList;
        if (list == null)
        {
          var collection = enumerable as ICollection;
          if (collection == null)
          {
            objectListView = CreateObjectListView();
            foreach (var item in enumerable) //Might hit DB - make async
              objectListView.Add(item);
          }
          else
            objectListView = CreateObjectListView(collection);
        }
        else
          objectListView = new ObjectListView(list);
      }
      else
      {
        var dataSource = GetDataSource(bindingList);
        if (dataSource == bindingList)
          objectListView = new ObjectListView(bindingList);
        else
          return CreateObjectListViewDirect(dataSource, itemType);
      }
      if (objectListView.ItemType == null)
        objectListView.ItemType = itemType;
      return objectListView;
    }

    public static IBindingListView CreateObjectListViewGeneric(Type type)
    {
      return (IBindingListView) MetaDataHelper.CreateGeneric(typeof(ObjectListView<>), type, MetaDataHelper.CreateList(type));
    }

    public static IBindingListView CreateObjectListView(Type type)
    {
      var objectListView = CreateObjectListView();
      objectListView.ItemType = type;
      return objectListView;
    }

    private static ObjectListView CreateObjectListView()
    {
      return new ObjectListView(new ArrayList());
    }

    public static bool BindEnumerable<T>(this BindingSource bindingSource, IEnumerable<T> enumerable, bool setReadonly)
    {
      var shownEnumerable = BindEnumerable(bindingSource, enumerable);
      if (shownEnumerable)
        if (setReadonly && bindingSource.AllowEdit && bindingSource.DataSource is IBindingList)
        {
          SetReadonly<T>(bindingSource);
        }
        else
          bindingSource.AllowNew = !setReadonly;
      return shownEnumerable;
    }

    private static void SetReadonly<T>(BindingSource bindingSource)
    {
      var bindingList = (IBindingList) bindingSource.DataSource;
      if (!(SetReadonly<T>(bindingList)))
      {
        var list = ((IEnumerable<T>) bindingList).ToList();
        bindingSource.DataSource = new ObjectListView<T>(list.AsReadOnly());
      }
    }

    public static bool BindEnumerable(this BindingSource bindingSource, IEnumerable enumerable, bool setReadonly, bool ensureFilteringEnabled = false
      , Func<IEnumerable, Type, IBindingListView> bindingListViewCreator = null)
    {
      var shownEnumerable = BindEnumerableInternal(bindingSource, enumerable, ensureFilteringEnabled, bindingListViewCreator);
      if (shownEnumerable)
      {
        var list = bindingSource.DataSource as IBindingList;
        if (setReadonly && (bindingSource.AllowEdit || bindingSource.AllowRemove) && list != null && SetReadonly(list))
        {
          bindingSource.ResetBindings(true); //To update UI for bindingSource.AllowRemove
        }
        else
          try
          {
            bindingSource.AllowNew = !setReadonly;
          }
          catch (InvalidOperationException e)
          {
            e.TraceOut();
          }
      }

      return shownEnumerable;
    }

    public static async Task<bool> BindEnumerableAsync(this BindingSource bindingSource, IEnumerable enumerable, bool setReadonly, CancellationToken cancellationToken, bool ensureFilteringEnabled = false
      , Func<IEnumerable, Type, CancellationToken, Task<IBindingListView>> bindingListViewCreator = null)
    {
      var shownEnumerable = await BindEnumerableInternalAsync(bindingSource, enumerable, cancellationToken, ensureFilteringEnabled, bindingListViewCreator);
      if (shownEnumerable)
      {
        var list = bindingSource.DataSource as IBindingList;
        if (setReadonly && (bindingSource.AllowEdit || bindingSource.AllowRemove) && list != null && SetReadonly(list))
        {
          bindingSource.ResetBindings(true); //To update UI for bindingSource.AllowRemove
        }
        else
          try
          {
            bindingSource.AllowNew = !setReadonly;
          }
          catch (InvalidOperationException e)
          {
            e.TraceOut();
          }
      }

      return shownEnumerable;
    }

    public static bool BindEnumerable<T>(BindingSource bindingSource, IEnumerable<T> enumerable)
    {
      bool shownEnumerable;
      try
      {
        bindingSource.DataSource = enumerable.ToBindingListView();
        shownEnumerable = bindingSource.List != null;
      }
      catch (Exception)
      {
        try
        {
          bindingSource.DataSource = enumerable;
        }
        catch (Exception)
        {
          bindingSource.DataSource = null;
        }
        shownEnumerable = bindingSource.List != null;
      }
      return shownEnumerable;
    }

    private static bool BindEnumerableInternal(BindingSource bindingSource, IEnumerable enumerable, bool ensureFilteringEnabled = false
      , Func<IEnumerable, Type, IBindingListView> bindingListViewCreator = null)
    {
      try
      {
        bindingSource.SuspendBinding();
        var raiseListChangedEvents = bindingSource.RaiseListChangedEvents;
        bindingSource.RaiseListChangedEvents = false;
        try
        {
          if (bindingSource.SupportsSorting && (bindingSource.IsSorted || !string.IsNullOrWhiteSpace(bindingSource.Sort)))
            bindingSource.RemoveSort();
          if (bindingSource.SupportsFiltering && !string.IsNullOrWhiteSpace(bindingSource.Filter))
            bindingSource.RemoveFilter();
        }
        finally
        {
          bindingSource.ResumeBinding();
          bindingSource.RaiseListChangedEvents = raiseListChangedEvents;
        }
      }
      catch (Exception e)
      {
        e.TraceOut();
      }
      bool shownEnumerable;
      try
      {
        var bindingListView = enumerable.ToBindingListView(ensureFilteringEnabled, bindingListViewCreator);
        bindingSource.DataSource = bindingListView;
        shownEnumerable = bindingSource.DataSource != null;
      }
      catch (ArgumentException) //From ObjectListView constructor
      {
        bindingSource.DataSource = enumerable; //To use default
        shownEnumerable = bindingSource.DataSource != null;
      }

      return shownEnumerable;
    }

    private static async Task<bool> BindEnumerableInternalAsync(BindingSource bindingSource, IEnumerable enumerable, CancellationToken cancellationToken, bool ensureFilteringEnabled = false
      , Func<IEnumerable, Type, CancellationToken, Task<IBindingListView>> bindingListViewCreator = null)
    {
      try
      {
        bindingSource.SuspendBinding();
        var raiseListChangedEvents = bindingSource.RaiseListChangedEvents;
        bindingSource.RaiseListChangedEvents = false;
        try
        {
          if (bindingSource.SupportsSorting && (bindingSource.IsSorted || !string.IsNullOrWhiteSpace(bindingSource.Sort)))
            bindingSource.RemoveSort();
          if (bindingSource.SupportsFiltering && !string.IsNullOrWhiteSpace(bindingSource.Filter))
            bindingSource.RemoveFilter();
        }
        finally
        {
          bindingSource.ResumeBinding();
          bindingSource.RaiseListChangedEvents = raiseListChangedEvents;
        }
      }
      catch (Exception e)
      {
        e.TraceOut();
      }
      bool shownEnumerable;
      try
      {
        var bindingListView = await enumerable.ToBindingListViewAsync(cancellationToken, ensureFilteringEnabled, bindingListViewCreator);
        bindingSource.DataSource = bindingListView;
        shownEnumerable = bindingSource.DataSource != null;
      }
      catch (ArgumentException) //From ObjectListView constructor
      {
        bindingSource.DataSource = enumerable; //To use default
        shownEnumerable = bindingSource.DataSource != null;
      }

      return shownEnumerable;
    }

    private static bool SetReadonly(IBindingList bindingList)
    {
      var objectListView = bindingList as ObjectListView;
      var result = objectListView != null;
      if (result)
      {
        objectListView.AllowEdit = false;
        objectListView.AllowRemove = false;
        objectListView.AllowNew = false;
      }
      else
      {
        var dataView = bindingList as DataView;
        result = dataView != null;
        if (result)
        {
          dataView.AllowEdit = false;
          dataView.AllowNew = false;
          dataView.AllowDelete = false;
        }
        else
        {
          SetPropertyFalse(bindingList, "AllowEdit");
          SetPropertyFalse(bindingList, "AllowRemove");
          SetPropertyFalse(bindingList, "AllowNew");
        }
      }
      return result;
    }

    private static void SetPropertyFalse(IEnumerable bindingList, string name)
    {
      var propertyInfo = bindingList.GetType().GetProperty(name);
      if (propertyInfo != null && propertyInfo.CanWrite)
        propertyInfo.SetValue(bindingList, false, null);
    }

    private static bool SetReadonly<T>(IBindingList bindingList)
    {
      var result = bindingList is ObjectListView<T>;
      if (result)
      {
        ((ObjectListView<T>) bindingList).AllowEdit = false;
        ((ObjectListView<T>) bindingList).AllowRemove = false;
        ((ObjectListView<T>) bindingList).AllowNew = false;
      }
      else
      {
        result = bindingList is BindingList<T>;
        if (result)
        {
          ((BindingList<T>) bindingList).AllowEdit = false;
          ((BindingList<T>) bindingList).AllowRemove = false;
          ((BindingList<T>) bindingList).AllowNew = false;
        }
        else
          result = SetReadonly(bindingList);
      }
      return result && !bindingList.AllowEdit;
    }

    public static bool IsObjectListView(object anObject)
    {
      return anObject != null && (anObject is ObjectListView || anObject.GetType().HasGenericTypeDefinition(typeof(ObjectListView<>)));
    }

    public static IEnumerable GetDataSource(this BindingSource bindingSource, bool wantRaiseItemChangedEvents = false)
    {
      var dataSource = bindingSource.List as BindingSource;
      if (dataSource != null)
        return GetDataSource(dataSource);
      var bindingList = bindingSource.List as IBindingList;
      return bindingList == null ? bindingSource.List : GetDataSource(bindingList, wantRaiseItemChangedEvents);
    }

    public static IEnumerable GetDataSource(IBindingList bindingList, bool wantRaiseItemChangedEvents = false)
    {
      if (bindingList == null)
        return null;
      var bindingSource = bindingList as BindingSource;
      if (bindingSource != null)
        return GetDataSource(bindingSource, wantRaiseItemChangedEvents);
      return MaybeGetObjectListViewDataSourcedynamic(bindingList, wantRaiseItemChangedEvents);
    }

    private static IEnumerable GetObjectListViewDataSource(IBindingList bindingList, bool wantRaiseItemChangedEvents = false)
    {
      var bindingListSourceProvider = BindingListViewSources.FirstOrDefault(b => b.Key.IsInstanceOfType(bindingList)).Value;
      if (bindingListSourceProvider != null)
      {
        var objectListViewDataSource = bindingListSourceProvider(bindingList);
        if (wantRaiseItemChangedEvents)
        {
          var raiseItemChangedEvents = objectListViewDataSource as IRaiseItemChangedEvents;
          if (raiseItemChangedEvents == null && bindingList is IRaiseItemChangedEvents && bindingList.GetType().HasGenericTypeDefinition(typeof(IList<>)))
            return bindingList;
        }
        return objectListViewDataSource;
      }
      return bindingList;
    }

    private static IEnumerable MaybeGetObjectListViewDataSourcedynamic(dynamic dataSource, bool wantRaiseItemChangedEvents = false)
    {
      return GetObjectListViewDataSource(dataSource, wantRaiseItemChangedEvents);
    }

    private static IEnumerable GetObjectListViewDataSource<T>(ObjectListView<T> objectListView, bool wantRaiseItemChangedEvents = false)
    {
      var objectListViewSource = objectListView.List as ObjectListView<T>;
      return objectListViewSource == null ? objectListView.List : GetObjectListViewDataSource(objectListViewSource, wantRaiseItemChangedEvents);
    }

    private static IEnumerable GetObjectListViewDataSource(ObjectListView objectListView, bool wantRaiseItemChangedEvents = false)
    {
      var bindingSource = objectListView.List as BindingSource;
      if (bindingSource != null)
        return GetDataSource(bindingSource, wantRaiseItemChangedEvents);
      var objectListViewSource = objectListView.List as ObjectListView;
      return objectListViewSource == null ? objectListView.List : GetObjectListViewDataSource(objectListViewSource, wantRaiseItemChangedEvents);
    }
  }
}