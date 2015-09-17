using AW.Data.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data
{
  public static class MetaSingletons
  {
    private static LinqMetaData _metaData;

    public static LinqMetaData MetaData
    {
      get { return _metaData ?? (_metaData = new LinqMetaData()); }
    }

    public static void AddContext()
    {
      MetaData.ContextToUse=new Context();
    }
  }
}