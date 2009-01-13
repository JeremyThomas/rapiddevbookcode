using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AW.Data.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data
{
  [DependencyInjectionInfo(typeof(EntityBase), "ConcurrencyPredicateFactoryToUse",
    ContextType = DependencyInjectionContextType.Singleton)]
  [Serializable]
  public class GeneralConcurrencyPredicateFactory : IConcurrencyPredicateFactory
  {
    private static GeneralConcurrencyPredicateFactory concurrencyPredicateFactory;

    public static GeneralConcurrencyPredicateFactory ConcurrencyPredicateFactory
    {
      get
      {
        if (concurrencyPredicateFactory == null)
          concurrencyPredicateFactory = new GeneralConcurrencyPredicateFactory();
        return concurrencyPredicateFactory; }
    }

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
          {
            if (field.IsChanged)
              toReturn.Add(field == field.DbValue);
          }
          
          break;
      }
      return toReturn;

    }
  }
}
