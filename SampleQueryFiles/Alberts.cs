//css_ref SD.LLBLGen.Pro.ORMSupportClasses.dll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AW.Data;
using AW.Data.Linq;
using AW.Helper.LLBL;

public class Script
{
  public static IEnumerable Query()
  {
    AW.Data.DaoClasses.CommonDaoBase.ActualConnectionString = @"data source=(local)\sqlexpress;initial catalog=AdventureWorks;integrated security=SSPI";
    return from contact in MetaSingletons.MetaData.Contact
           where contact.FirstName.Contains("Albert")
           select contact;
  }

}