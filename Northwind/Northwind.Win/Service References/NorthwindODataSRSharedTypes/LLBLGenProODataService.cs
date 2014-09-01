using System;
using Northwind.DAL;
using Northwind.DAL.FactoryClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.Win.NorthwindODataSRSharedTypes
{
  public partial class LLBLGenProODataService : ILinqMetaData
  {
    private readonly ILinqMetaData _linqMetaData;

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
  }
}