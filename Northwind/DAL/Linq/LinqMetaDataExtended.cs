using System;
using Northwind.DAL.EntityClasses;

namespace Northwind.DAL.Linq
{
  partial class LinqMetaData
  {
    static LinqMetaData()
    {
      try
      {
        CommonEntityBase.Initialize();
      }
      catch (TypeInitializationException)
      {
        CommonEntityBase.Initialize(); //Can sometimes work on the second go
      }
    }

    public static void Initialize()
    {
    }
  }
}