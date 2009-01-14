using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data
{
  [DependencyInjectionInfo(typeof (EntityBase), "ConcurrencyPredicateFactoryToUse",
    ContextType = DependencyInjectionContextType.Singleton)]
  [Serializable]
  public class GeneralConcurrencyPredicateFactory: IConcurrencyPredicateFactory
  {
    private static GeneralConcurrencyPredicateFactory concurrencyPredicateFactory;

    public static GeneralConcurrencyPredicateFactory ConcurrencyPredicateFactory
    {
      get
      {
        if (concurrencyPredicateFactory == null)
          concurrencyPredicateFactory = new GeneralConcurrencyPredicateFactory();
        return concurrencyPredicateFactory;
      }
    }

    /// <summary>
    /// Creates the requested predicate of the type specified, Currently only does updates. 
    /// It is only comparing the fields the user changed; equivalent to Data.Linq.RefreshMode.KeepChanges
    /// </summary>
    /// <param name="predicateTypeToCreate">The type of predicate to create</param>
    /// <param name="containingEntity">the entity object containing this IConcurrencyPredicateFactory instance.</param>
    /// <returns>
    /// A ready to use predicate to use in the query to execute. Can be null/Nothing, in which case the predicate is ignored
    /// </returns>
    public IPredicateExpression CreatePredicate(ConcurrencyPredicateType predicateTypeToCreate,
                                                object containingEntity)
    {
      IPredicateExpression toReturn = new PredicateExpression();
      var entity = (IEntity)containingEntity;
      switch (predicateTypeToCreate)
      {
        case ConcurrencyPredicateType.Save:
          // only for updates
          foreach (EntityField field in entity.Fields)
            if (field.IsChanged)
              toReturn.Add(field == field.DbValue);

          break;
      }
      return toReturn;
    }
  }
}