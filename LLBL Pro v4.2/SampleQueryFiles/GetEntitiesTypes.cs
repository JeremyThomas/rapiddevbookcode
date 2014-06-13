//css_ref SD.LLBLGen.Pro.ORMSupportClasses.dll;
//css_ref SD.LLBLGen.Pro.LinqSupportClasses.NET35;
//css_ref AW.Winforms.Helpers.LLBL.dll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AW.Data;
using AW.Data.Linq;
using AW.Winforms.Helpers.QueryRunner;

public class Script : MarshalByRefObject, IQueryScript
{
  public IEnumerable Query()
  {
    return AW.Winforms.Helpers.LLBL.EntityViewer.FrmEntitiesAndFields.GetEntitiesTypes();
  }

}