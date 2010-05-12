//css_ref SD.LLBLGen.Pro.ORMSupportClasses.NET20.dll;
//css_ref SD.LLBLGen.Pro.LinqSupportClasses.NET35;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Data;
using AW.Data.Linq;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.QueryRunner;
using AW.Winforms.Helpers.LLBL;

public class Script : MarshalByRefObject, IQueryScript
{
  public IEnumerable Query()
  {
    var addressTypes = from at in MetaSingletons.MetaData.AddressType
                       select at;

    return addressTypes.AsEnumerable().EditInDataGridView();
  }

}