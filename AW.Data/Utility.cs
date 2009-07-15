using System.Diagnostics;
using AW.Data.Linq;

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
  }

}