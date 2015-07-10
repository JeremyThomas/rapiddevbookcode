//css_ref SD.LLBLGen.Pro.ORMSupportClasses.dll;
//css_ref AW.Helper.dll;
//css_ref AW.Helper.llbl.dll;
//css_ref AW.Winforms.Helpers.dll;
//css_ref AW.Winforms.Helpers.LLBL.dll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using AW.Data;
using AW.Data.Linq;
using System.Windows.Forms;
using AW.Winforms.Helpers.QueryRunner;

public class Script : MarshalByRefObject, IQueryScript
{
  public IEnumerable Query()
  {
    return AW.Helper.LLBL.EntityHelper.GetEntitiesTypes();
  }

}