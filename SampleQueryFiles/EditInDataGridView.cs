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

public class Script : MarshalByRefObject, IQueryScript
{
  public IEnumerable Query()
  {
    var contacts = from contact in MetaSingletons.MetaData.Contact
                   where contact.FirstName.Contains("Albert")
                   select contact;

    //var t= x.ToList();
    //return  AW.Winforms.Helpers.AWHelper.ViewInDataGridView(x);
    //return AW.Winforms.Helpers.AWHelper.EditInDataGridView(t, MetaSingletons.Save, typeof(IEntity));
    return AW.Winforms.Helpers.DataEditor.DataEditorExtensions.EditInDataGridView(contacts, EntityHelper.Save, EntityHelper.Delete);
  }

}