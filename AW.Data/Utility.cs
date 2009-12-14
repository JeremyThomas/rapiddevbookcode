using AW.Data.Linq;

namespace AW.Data
{
  public static class MetaSingletons
  {
    private static LinqMetaData _metaData;

    public static LinqMetaData MetaData
    {
      get { return _metaData ?? (_metaData = new LinqMetaData()); }
    }
  }
}