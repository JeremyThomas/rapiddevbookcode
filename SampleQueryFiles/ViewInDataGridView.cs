//css_ref SD.LLBLGen.Pro.ORMSupportClasses.dll
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AW.Business;
using AW.Data;
using AW.Data.Linq;
using AW.Winforms.Helpers.QueryRunner;

public class Script
{
  public static IEnumerable Query()
  {
		var x = from soh in MetaSingletons.MetaData.SalesOrderHeader
						where soh.Customer.Individual.Contact.FirstName.Contains("Albert") && soh.Customer.CustomerAddresses.Any(ca => ca.Address.City == "Perth")
						select soh;

		return AW.Winforms.Helpers.AWHelper.ShowInGrid(x);

	}

}