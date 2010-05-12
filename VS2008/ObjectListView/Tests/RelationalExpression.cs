
#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests
{
	[TestFixture]
	public class RelationalExpressionTests
	{
		[Test]
		public void Construct()
		{
			RelationalExpression exp = new RelationalExpression("prop", "value", RelationalOperator.Equal);
			Assert.AreEqual("prop", exp.PropertyName);
			Assert.AreEqual("value", exp.Value);
			Assert.AreEqual(RelationalOperator.Equal, exp.Operator);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ConstructPropNull()
		{
			RelationalExpression exp = new RelationalExpression(null, "value", RelationalOperator.Equal);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void ConstructPropEmpty()
		{
			RelationalExpression exp = new RelationalExpression("", "value", RelationalOperator.Equal);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ConstructVauleNull()
		{
			RelationalExpression exp = new RelationalExpression("prop", null, RelationalOperator.Equal);
		}

		[Test]
		public void ConstructVauleEmpty()
		{
			RelationalExpression exp = new RelationalExpression("prop", "", RelationalOperator.Equal);
			Assert.AreEqual("prop", exp.PropertyName);
			Assert.AreEqual("", exp.Value);
			Assert.AreEqual(RelationalOperator.Equal, exp.Operator);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void ConstructOpNone()
		{
			RelationalExpression exp = new RelationalExpression("prop", "value", RelationalOperator.None);
		}
	}
}
#endif