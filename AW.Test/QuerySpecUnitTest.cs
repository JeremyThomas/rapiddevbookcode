using AW.Data.CollectionClasses;
using AW.Data.FactoryClasses;
using AW.Data.HelperClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.SelfServicing;

namespace AW.Tests
{
	[TestClass]
	public class QuerySpecUnitTest
	{
		[TestMethod]
		public void FetchEntityWithRenamedPkField()
		{
			var qf = new QueryFactory();
			var q = qf.Address.Where(AddressFields.AddressID == 3);
			var addresses = new AddressCollection();
			addresses.GetMulti(q);
			Assert.AreEqual(1, addresses.Count);
		}
	}
}