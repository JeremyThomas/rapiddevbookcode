using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AW.Helper;
using AW.Helper.LLBL;
using Fasterflect;
using Northwind.DAL;
using Northwind.DAL.FactoryClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.Win.NorthwindODataSRSharedTypes
{
  public partial class LLBLGenProODataService : ILinqMetaData
  {
    private readonly ILinqMetaData _linqMetaData;
    private IEnumerable<PropertyInfo> _queryables;
    private static Dictionary<Type, MemberGetter> _memberGetters;

    public LLBLGenProODataService(Uri serviceRoot, ILinqMetaData linqMetaData) :
      this(serviceRoot)
    {
      _linqMetaData = linqMetaData;
    }

    #region Implementation of ILinqMetaData

    /// <summary>
    ///   returns the datasource to use in a Linq query for the entity type specified
    /// </summary>
    /// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
    /// <returns>
    ///   the requested datasource
    /// </returns>
    public IDataSource GetQueryableForEntity(int typeOfEntity)
    {
      return _linqMetaData.GetQueryableForEntity(typeOfEntity);
      //var entityFactory2 = GetFactory(typeOfEntity);
      //Type x;
      //if (entityFactory2 == null)
      //  return null;
      //else
      //{
      //  x = entityFactory2.Create().GetType();
      //  MetaDataHelper.GetPropertyDescriptors()
      //}
      //return null;
    }

    #endregion

    /// <summary>
    ///   Gets the factory of the entity with the integer version of AQD.Model.EntityType specified
    /// </summary>
    /// <param name="typeOfEntity">The type of entity.</param>
    /// <returns>factory to use or null if not found</returns>
    public static IEntityFactory2 GetFactory(int typeOfEntity)
    {
      return EntityFactoryFactory.GetFactory((EntityType) typeOfEntity);
    }

    public IQueryable GetDataServiceQueryableForEntity(ILinqMetaData linqMetaData, Type typeOfEntity)
    {
      if (_memberGetters == null)
        _memberGetters = new Dictionary<Type, MemberGetter>();
      var nameGetter = _memberGetters.GetValue(typeOfEntity);
      if (nameGetter == null)
      {
      //  var queryable = EntityHelper.GetQueryableForEntityIgnoreIfNull(linqMetaData, typeOfEntity);
     //   var typeParameterOfGenericType = MetaDataHelper.GetTypeParameterOfGenericType(queryable.GetType());
        if (_queryables == null)
          _queryables = GetType().Properties().Where(m => m.IsReadable() && m.Type().Implements<IQueryable>());
        var x = _queryables.FirstOrDefault(q => MetaDataHelper.GetTypeParameterOfGenericType(q.PropertyType) == typeOfEntity);
        if (x != null)
        {
          nameGetter = GetType().DelegateForGetPropertyValue(x.Name);
          _memberGetters.Add(typeOfEntity,nameGetter);
          return (IQueryable) nameGetter(this);
        }
        return null;
      }
      return (IQueryable) nameGetter(this);
    }
  }
}