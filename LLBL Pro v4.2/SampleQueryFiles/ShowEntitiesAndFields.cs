//css_ref SD.LLBLGen.Pro.ORMSupportClasses.dll;
//css_ref SD.LLBLGen.Pro.LinqSupportClasses.NET35;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;
using AW.Business;
using AW.Data;
using AW.Data.Linq;
using AW.Helper.LLBL;
using AW.Winforms.Helpers.QueryRunner;

public class Script : MarshalByRefObject, IQueryScript
{
  public IEnumerable Query()
  {
     AW.Winforms.Helpers.LLBL.FrmEntitiesAndFields.ShowEntitiesAndFields(typeof(AW.Data.EntityClasses.CommonEntityBase), AW.Data.MetaSingletons.MetaData);
  }

}