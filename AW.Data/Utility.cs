using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using AW.Data.FactoryClasses;
using AW.Data.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data
{
  public static class MetaSingletons
  {
    private static LinqMetaData metaData;

    public static LinqMetaData MetaData
    {
      get
      {
        if (metaData == null)
          metaData = new LinqMetaData();
        return metaData;
      }
    }

    /// <summary>
    /// Saves any changes to the specified data to the DB.
    /// </summary>
    /// <param name="dataToSave">The data to save, must be a CommonEntityBase or a list of CommonEntityBase's.</param>
    /// <returns>The number of persisted entities.</returns>
    public static int Save(object dataToSave)
    {
      var listItemType = ListBindingHelper.GetListItemType(dataToSave);
      if (typeof(IEntity).IsAssignableFrom(listItemType))
      {
        var enumerable = dataToSave as IEnumerable;
        if (enumerable == null)
          return Convert.ToInt32(((IEntity)dataToSave).Save());
        if (enumerable is EntityCollectionBase<EntityBase>)
          return ((EntityCollectionBase<EntityBase>)enumerable).SaveMulti();
        var typeOfEntity = (EntityType)Enum.Parse(typeof(EntityType), listItemType.Name, false);
        var x = GeneralEntityCollectionFactory.Create(typeOfEntity);
        foreach (var entityCore in enumerable.Cast<IEntity>())
        {
          x.Add(entityCore);
        }
        //x.AddRange(dataToSave as IEnumerable);
        return x.SaveMulti(true);
      }
      return 0;
    }

    /// <summary>
    /// Executes the query this object represents and returns its results in its native container, e.g. an entity collection.
    /// </summary>
    /// <typeparam name="T">An EntityBase</typeparam>
    /// <param name="query">The query.</param>
    /// <returns></returns>
    //public static EntityCollectionBase<T> ToEntityCollection<T>(this IQueryable<T> query) where T : EntityBase
    //{
    //  return ((ILLBLGenProQuery)query).Execute<EntityCollectionBase<T>>();
    //}

    public static CollectionCore<T> ToEntityCollection<T>(this IQueryable<T> query) where T : class, IEntityCore
    {
      return ((ILLBLGenProQuery)query).Execute<CollectionCore<T>>();
    }

    //public static EntityCollectionBase2<T> ToEntityCollection<T>(this IQueryable<T> query) where T : EntityBase2
    //{
    //  return ((ILLBLGenProQuery)query).Execute<EntityCollectionBase2<T>>();
    //}

  }
}