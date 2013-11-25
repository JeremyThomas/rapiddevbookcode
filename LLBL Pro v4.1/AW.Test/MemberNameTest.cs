using System;
using System.Collections.Generic;
using AW.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AW.Tests
{
	/// <summary>
	/// 	http://pastebin.com/j0neZ478 
	///   http://joelabrahamsson.com/entry/getting-property-and-method-names-using-static-reflection-in-c-sharp
	/// </summary>
	[TestClass]
	public class MemberNameTest
	{
		[TestMethod]
		public void FindsTheNameOfAVoidMethod()
		{
			var name = MemberName.For((List<string> x) => x.Reverse());
			Assert.AreEqual(name, "Reverse");
		}

		[TestMethod]
		public void FindsTheNameOfAMethodReturningValue()
		{
			var name = MemberName.For((string x) => x.GetHashCode());
			Assert.AreEqual(name, "GetHashCode");
		}

		[TestMethod]
		public void FindsTheNameOfAProperty()
		{
			var name = MemberName.For((string x) => x.Length);
			Assert.AreEqual(name, "Length");
		}

		[TestMethod]
		public void FindsTheNameOfAMethodWithArguments()
		{
			var name = MemberName.For((string x) => x.LastIndexOf(','));
			Assert.AreEqual(name, "LastIndexOf");
		}

		[TestMethod]
		public void FindsTheNameOfAStaticMethod()
		{
			var name = MemberName.For(() => Console.WriteLine());
			Assert.AreEqual(name, "WriteLine");
		}

		[TestMethod]
		public void FindsTheNameOfAStaticProperty()
		{
			var name = MemberName.For(() => string.Empty);
			Assert.AreEqual(name, "Empty");
		}

		//[TestMethod]
		//public void DoesNotAcceptInvalidExpressions() {
		//    Assert.AreEqual(() => MemberName.For(() => 0),
		//        Throws.InstanceOf<ArgumentException>().With.
		//        Message.EqualTo("Invalid expression [0]"));
		//}

		[TestMethod]
		public void CanUseInstanceToGetMemberName()
		{
			var dummy = new Dummy();
			Assert.AreEqual(dummy.Method(), "Method");
		}

		private class Dummy
		{
			public string Method()
			{
				return MemberName.For(this, x => x.Method());
			}
		}
	}
}