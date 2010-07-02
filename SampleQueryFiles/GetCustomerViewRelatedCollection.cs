//css_ref SD.LLBLGen.Pro.ORMSupportClasses.NET20.dll;
//css_ref SD.LLBLGen.Pro.LinqSupportClasses.NET35;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AW.Business;
using AW.Data;
using AW.Data.Linq;
using AW.Winforms.Helpers.QueryRunner;

public class Script : MarshalByRefObject, IQueryScript
{
	public IEnumerable Query()
	{
		return CustomerQueries.GetCustomerViewRelatedCollection();
	}

}