using System;
using System.Collections;
using System.Windows.Forms;
using AW.Data.FactoryClasses;
using AW.Data.Linq;
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

    public static int Save(object dataToSave)
    {
      var listItemType = ListBindingHelper.GetListItemType(dataToSave);
      if (typeof (IEntity).IsAssignableFrom(listItemType))
      {
        var typeOfEntity = (EntityType) Enum.Parse(typeof (EntityType), listItemType.Name, false);
        var x = GeneralEntityCollectionFactory.Create(typeOfEntity);
        foreach (IEntity entityCore in (dataToSave as IEnumerable))
        {
          x.Add(entityCore);
        }
        //x.AddRange(dataToSave as IEnumerable);
        return x.SaveMulti(true);
      }
      return 0;
    }
  }
}