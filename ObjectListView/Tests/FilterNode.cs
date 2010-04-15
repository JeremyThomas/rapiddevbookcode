// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using NUnit.Framework;
using JesseJohnston;

namespace JesseJohnston.Tests
{
	[TestFixture]
	public class FilterNodeTests
	{
		#region Types
		private class TestFilterNode : FilterNode
		{
			private bool result;

			public bool Result
			{
				get { return result; }
			}

			public TestFilterNode(bool result) : base(new RelationalExpression("prop", "value", RelationalOperator.Equal))
			{
				this.result = result;
			}
		}
		#endregion

		[Test]
		public void ConstructTerminalNode()
		{
			RelationalExpression exp = new RelationalExpression("Name", "Smith", RelationalOperator.Equal);
			FilterNode node = new FilterNode(exp);
			Assert.AreEqual(exp, node.Term);
			Assert.IsFalse(node.Evaluated.HasValue);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
		}

		[Test]
		public void EvaluateTerminalNodeTrue()
		{
			RelationalExpression exp = new RelationalExpression("Name", "Smith", RelationalOperator.Equal);
			FilterNode node = new FilterNode(exp);

			node.Evaluate(delegate(FilterNode n) { return true; });

			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsTrue(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateTerminalNodeFalse()
		{
			RelationalExpression exp = new RelationalExpression("Name", "Smith", RelationalOperator.Equal);
			FilterNode node = new FilterNode(exp);

			node.Evaluate(delegate(FilterNode n) { return false; });

			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsFalse(node.Evaluated.Value);
		}

		[Test]
		public void ConstructOrNode()
		{
			RelationalExpression expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
			RelationalExpression expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
			FilterNode nodeLeft = new FilterNode(expLeft);
			FilterNode nodeRight = new FilterNode(expRight);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

			Assert.IsNull(node.Term);
			Assert.IsFalse(node.Evaluated.HasValue);
			Assert.AreEqual(nodeLeft, node.Left);
			Assert.AreEqual(nodeRight, node.Right);
			Assert.AreEqual(LogicalOperator.Or, node.Operator);
		}

		[Test]
		public void EvaluateOrNodeFalseFalse()
		{
			RelationalExpression expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
			RelationalExpression expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
			FilterNode nodeLeft = new FilterNode(expLeft);
			FilterNode nodeRight = new FilterNode(expRight);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

			Assert.IsFalse(node.Evaluate(delegate(FilterNode n) { return false; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsFalse(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsFalse(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsFalse(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateOrNodeFalseTrue()
		{
			RelationalExpression expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
			RelationalExpression expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
			FilterNode nodeLeft = new FilterNode(expLeft);
			FilterNode nodeRight = new FilterNode(expRight);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

			Assert.IsTrue(node.Evaluate(delegate(FilterNode n) { return n == nodeRight; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsFalse(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsTrue(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsTrue(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateOrNodeTrueFalse()
		{
			RelationalExpression expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
			RelationalExpression expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
			FilterNode nodeLeft = new FilterNode(expLeft);
			FilterNode nodeRight = new FilterNode(expRight);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

			Assert.IsTrue(node.Evaluate(delegate(FilterNode n) { return n == nodeLeft; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsTrue(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsFalse(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsTrue(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateOrNodeTrueTrue()
		{
			RelationalExpression expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
			RelationalExpression expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
			FilterNode nodeLeft = new FilterNode(expLeft);
			FilterNode nodeRight = new FilterNode(expRight);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

			Assert.IsTrue(node.Evaluate(delegate(FilterNode n) { return true; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsTrue(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsTrue(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsTrue(node.Evaluated.Value);
		}

		[Test]
		public void ConstructAndNode()
		{
			RelationalExpression expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
			RelationalExpression expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
			FilterNode nodeLeft = new FilterNode(expLeft);
			FilterNode nodeRight = new FilterNode(expRight);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

			Assert.IsNull(node.Term);
			Assert.IsFalse(node.Evaluated.HasValue);
			Assert.AreEqual(nodeLeft, node.Left);
			Assert.AreEqual(nodeRight, node.Right);
			Assert.AreEqual(LogicalOperator.And, node.Operator);
		}

		[Test]
		public void EvaluateAndNodeFalseFalse()
		{
			RelationalExpression expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
			RelationalExpression expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
			FilterNode nodeLeft = new FilterNode(expLeft);
			FilterNode nodeRight = new FilterNode(expRight);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

			Assert.IsFalse(node.Evaluate(delegate(FilterNode n) { return false; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsFalse(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsFalse(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsFalse(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateAndNodeFalseTrue()
		{
			RelationalExpression expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
			RelationalExpression expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
			FilterNode nodeLeft = new FilterNode(expLeft);
			FilterNode nodeRight = new FilterNode(expRight);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

			Assert.IsFalse(node.Evaluate(delegate(FilterNode n) { return n == nodeRight; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsFalse(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsTrue(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsFalse(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateAndNodeTrueFalse()
		{
			RelationalExpression expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
			RelationalExpression expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
			FilterNode nodeLeft = new FilterNode(expLeft);
			FilterNode nodeRight = new FilterNode(expRight);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

			Assert.IsFalse(node.Evaluate(delegate(FilterNode n) { return n == nodeLeft; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsTrue(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsFalse(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsFalse(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateAndNodeTrueTrue()
		{
			RelationalExpression expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
			RelationalExpression expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
			FilterNode nodeLeft = new FilterNode(expLeft);
			FilterNode nodeRight = new FilterNode(expRight);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

			Assert.IsTrue(node.Evaluate(delegate(FilterNode n) { return true; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsTrue(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsTrue(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsTrue(node.Evaluated.Value);
		}

		[Test]
		public void ConstructOrTree()
		{
			FilterNode nodeLeft = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.Or);
			FilterNode nodeRight = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.Or);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

			Assert.IsNull(node.Term);
			Assert.IsFalse(node.Evaluated.HasValue);
			Assert.AreEqual(nodeLeft, node.Left);
			Assert.AreEqual(nodeRight, node.Right);
			Assert.AreEqual(LogicalOperator.Or, node.Operator);
		}

		[Test]
		public void EvaluateOrTreeFalseFalse()
		{
			FilterNode nodeLeft = new FilterNode(new TestFilterNode(false), new TestFilterNode(false), LogicalOperator.Or);
			FilterNode nodeRight = new FilterNode(new TestFilterNode(false), new TestFilterNode(true), LogicalOperator.And);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

			Assert.IsFalse(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode)n).Result; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsFalse(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsFalse(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsFalse(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateOrTreeFalseTrue()
		{
			FilterNode nodeLeft = new FilterNode(new TestFilterNode(false), new TestFilterNode(false), LogicalOperator.Or);
			FilterNode nodeRight = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.And);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

			Assert.IsTrue(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode)n).Result; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsFalse(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsTrue(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsTrue(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateOrTreeTrueFalse()
		{
			FilterNode nodeLeft = new FilterNode(new TestFilterNode(true), new TestFilterNode(false), LogicalOperator.Or);
			FilterNode nodeRight = new FilterNode(new TestFilterNode(false), new TestFilterNode(true), LogicalOperator.And);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

			Assert.IsTrue(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode)n).Result; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsTrue(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsFalse(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsTrue(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateOrTreeTrueTrue()
		{
			FilterNode nodeLeft = new FilterNode(new TestFilterNode(true), new TestFilterNode(false), LogicalOperator.Or);
			FilterNode nodeRight = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.And);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

			Assert.IsTrue(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode)n).Result; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsTrue(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsTrue(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsTrue(node.Evaluated.Value);
		}

		[Test]
		public void ConstructAndTree()
		{
			FilterNode nodeLeft = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.Or);
			FilterNode nodeRight = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.Or);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

			Assert.IsNull(node.Term);
			Assert.IsFalse(node.Evaluated.HasValue);
			Assert.AreEqual(nodeLeft, node.Left);
			Assert.AreEqual(nodeRight, node.Right);
			Assert.AreEqual(LogicalOperator.And, node.Operator);
		}

		[Test]
		public void EvaluateAndTreeFalseFalse()
		{
			FilterNode nodeLeft = new FilterNode(new TestFilterNode(false), new TestFilterNode(false), LogicalOperator.Or);
			FilterNode nodeRight = new FilterNode(new TestFilterNode(false), new TestFilterNode(true), LogicalOperator.And);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

			Assert.IsFalse(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode)n).Result; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsFalse(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsFalse(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsFalse(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateAndTreeFalseTrue()
		{
			FilterNode nodeLeft = new FilterNode(new TestFilterNode(false), new TestFilterNode(false), LogicalOperator.Or);
			FilterNode nodeRight = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.And);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

			Assert.IsFalse(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode)n).Result; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsFalse(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsTrue(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsFalse(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateAndTreeTrueFalse()
		{
			FilterNode nodeLeft = new FilterNode(new TestFilterNode(true), new TestFilterNode(false), LogicalOperator.Or);
			FilterNode nodeRight = new FilterNode(new TestFilterNode(false), new TestFilterNode(true), LogicalOperator.And);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

			Assert.IsFalse(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode)n).Result; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsTrue(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsFalse(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsFalse(node.Evaluated.Value);
		}

		[Test]
		public void EvaluateAndTreeTrueTrue()
		{
			FilterNode nodeLeft = new FilterNode(new TestFilterNode(true), new TestFilterNode(false), LogicalOperator.Or);
			FilterNode nodeRight = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.And);
			FilterNode node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

			Assert.IsTrue(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode)n).Result; }));

			Assert.IsTrue(nodeLeft.Evaluated.HasValue);
			Assert.IsTrue(nodeLeft.Evaluated.Value);
			Assert.IsTrue(nodeRight.Evaluated.HasValue);
			Assert.IsTrue(nodeRight.Evaluated.Value);
			Assert.IsTrue(node.Evaluated.HasValue);
			Assert.IsTrue(node.Evaluated.Value);
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void ParseNull()
		{
			FilterNode.Parse(null);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void ParseEmpty()
		{
			FilterNode.Parse("");
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void ParseSingleTerm()
		{
			FilterNode.Parse("name");
		}

		[Test]
		public void ParseSingleRelationEqual()
		{
			FilterNode node = FilterNode.Parse("name = value");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Term.Operator);
			Assert.AreEqual("name", node.Term.PropertyName);
			Assert.AreEqual("value", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationEqualAlternate()
		{
			FilterNode node = FilterNode.Parse("name == value");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Term.Operator);
			Assert.AreEqual("name", node.Term.PropertyName);
			Assert.AreEqual("value", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationEqualWhitespace()
		{
			FilterNode node = FilterNode.Parse("   name             =               value         ");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Term.Operator);
			Assert.AreEqual("name", node.Term.PropertyName);
			Assert.AreEqual("value", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationEqualQuotedWhitespace()
		{
			FilterNode node = FilterNode.Parse("name = ' value '");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Term.Operator);
			Assert.AreEqual("name", node.Term.PropertyName);
			Assert.AreEqual(" value ", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationEqualDoubleQuotedValue()
		{
			FilterNode node = FilterNode.Parse("Name=\"O'Reilly\"");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Term.Operator);
			Assert.AreEqual("Name", node.Term.PropertyName);
			Assert.AreEqual("O'Reilly", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationEqualUnbalancedDoubleQuotedValue()
		{
			FilterNode node = FilterNode.Parse("Name=\"O'Reilly");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Term.Operator);
			Assert.AreEqual("Name", node.Term.PropertyName);
			Assert.AreEqual("O'Reilly", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationEqualNoWhitespace()
		{
			FilterNode node = FilterNode.Parse("name=value");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Term.Operator);
			Assert.AreEqual("name", node.Term.PropertyName);
			Assert.AreEqual("value", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationInequal()
		{
			FilterNode node = FilterNode.Parse("name != value");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.NotEqual, node.Term.Operator);
			Assert.AreEqual("name", node.Term.PropertyName);
			Assert.AreEqual("value", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationInequalAlternate()
		{
			FilterNode node = FilterNode.Parse("name <> value");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.NotEqual, node.Term.Operator);
			Assert.AreEqual("name", node.Term.PropertyName);
			Assert.AreEqual("value", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationInequalAlternateNoWhitespace()
		{
			FilterNode node = FilterNode.Parse("name<>value");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.NotEqual, node.Term.Operator);
			Assert.AreEqual("name", node.Term.PropertyName);
			Assert.AreEqual("value", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationLess()
		{
			FilterNode node = FilterNode.Parse("name < value");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.Less, node.Term.Operator);
			Assert.AreEqual("name", node.Term.PropertyName);
			Assert.AreEqual("value", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationLessEqual()
		{
			FilterNode node = FilterNode.Parse("name <= value");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.LessEqual, node.Term.Operator);
			Assert.AreEqual("name", node.Term.PropertyName);
			Assert.AreEqual("value", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationGreater()
		{
			FilterNode node = FilterNode.Parse("name > value");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.Greater, node.Term.Operator);
			Assert.AreEqual("name", node.Term.PropertyName);
			Assert.AreEqual("value", node.Term.Value);
		}

		[Test]
		public void ParseSingleRelationGreaterEqual()
		{
			FilterNode node = FilterNode.Parse("name >= value");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.IsNull(node.Left);
			Assert.IsNull(node.Right);
			Assert.AreEqual(LogicalOperator.None, node.Operator);
			Assert.IsNotNull(node.Term);
			Assert.AreEqual(RelationalOperator.GreaterEqual, node.Term.Operator);
			Assert.AreEqual("name", node.Term.PropertyName);
			Assert.AreEqual("value", node.Term.Value);
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void ParseBadCondition()
		{
			FilterNode.Parse("name = value But orders > 50");
		}

		[Test]
		public void ParseAnd()
		{
			FilterNode node = FilterNode.Parse("name = value and orders > 50");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);

			Assert.IsNotNull(node.Left);
			Assert.IsNull(node.Left.Evaluated);
			Assert.IsNull(node.Left.Left);
			Assert.IsNull(node.Left.Right);
			Assert.AreEqual(LogicalOperator.None, node.Left.Operator);
			Assert.IsNotNull(node.Left.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Term.Operator);
			Assert.AreEqual("name", node.Left.Term.PropertyName);
			Assert.AreEqual("value", node.Left.Term.Value);

			Assert.IsNotNull(node.Right);
			Assert.IsNull(node.Right.Evaluated);
			Assert.IsNull(node.Right.Left);
			Assert.IsNull(node.Right.Right);
			Assert.AreEqual(LogicalOperator.None, node.Right.Operator);
			Assert.IsNotNull(node.Right.Term);
			Assert.AreEqual(RelationalOperator.Greater, node.Right.Term.Operator);
			Assert.AreEqual("orders", node.Right.Term.PropertyName);
			Assert.AreEqual("50", node.Right.Term.Value);

			Assert.AreEqual(LogicalOperator.And, node.Operator);
			Assert.IsNull(node.Term);
		}

		[Test]
		public void ParseAndWhitespace()
		{
			FilterNode node = FilterNode.Parse("   name     =      value     and    orders    >    50   ");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);

			Assert.IsNotNull(node.Left);
			Assert.IsNull(node.Left.Evaluated);
			Assert.IsNull(node.Left.Left);
			Assert.IsNull(node.Left.Right);
			Assert.AreEqual(LogicalOperator.None, node.Left.Operator);
			Assert.IsNotNull(node.Left.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Term.Operator);
			Assert.AreEqual("name", node.Left.Term.PropertyName);
			Assert.AreEqual("value", node.Left.Term.Value);

			Assert.IsNotNull(node.Right);
			Assert.IsNull(node.Right.Evaluated);
			Assert.IsNull(node.Right.Left);
			Assert.IsNull(node.Right.Right);
			Assert.AreEqual(LogicalOperator.None, node.Right.Operator);
			Assert.IsNotNull(node.Right.Term);
			Assert.AreEqual(RelationalOperator.Greater, node.Right.Term.Operator);
			Assert.AreEqual("orders", node.Right.Term.PropertyName);
			Assert.AreEqual("50", node.Right.Term.Value);

			Assert.AreEqual(LogicalOperator.And, node.Operator);
			Assert.IsNull(node.Term);
		}

		[Test]
		public void ParseAndNoWhitespace()
		{
			FilterNode node = FilterNode.Parse("name=value AND orders>50");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);

			Assert.IsNotNull(node.Left);
			Assert.IsNull(node.Left.Evaluated);
			Assert.IsNull(node.Left.Left);
			Assert.IsNull(node.Left.Right);
			Assert.AreEqual(LogicalOperator.None, node.Left.Operator);
			Assert.IsNotNull(node.Left.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Term.Operator);
			Assert.AreEqual("name", node.Left.Term.PropertyName);
			Assert.AreEqual("value", node.Left.Term.Value);

			Assert.IsNotNull(node.Right);
			Assert.IsNull(node.Right.Evaluated);
			Assert.IsNull(node.Right.Left);
			Assert.IsNull(node.Right.Right);
			Assert.AreEqual(LogicalOperator.None, node.Right.Operator);
			Assert.IsNotNull(node.Right.Term);
			Assert.AreEqual(RelationalOperator.Greater, node.Right.Term.Operator);
			Assert.AreEqual("orders", node.Right.Term.PropertyName);
			Assert.AreEqual("50", node.Right.Term.Value);

			Assert.AreEqual(LogicalOperator.And, node.Operator);
			Assert.IsNull(node.Term);
		}

		[Test]
		public void ParseAndQuoted()
		{
			FilterNode node = FilterNode.Parse("LastName = 'Smi*' AND FirstName = 'J*'");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);

			Assert.IsNotNull(node.Left);
			Assert.IsNull(node.Left.Evaluated);
			Assert.IsNull(node.Left.Left);
			Assert.IsNull(node.Left.Right);
			Assert.AreEqual(LogicalOperator.None, node.Left.Operator);
			Assert.IsNotNull(node.Left.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Term.Operator);
			Assert.AreEqual("LastName", node.Left.Term.PropertyName);
			Assert.AreEqual("Smi*", node.Left.Term.Value);

			Assert.IsNotNull(node.Right);
			Assert.IsNull(node.Right.Evaluated);
			Assert.IsNull(node.Right.Left);
			Assert.IsNull(node.Right.Right);
			Assert.AreEqual(LogicalOperator.None, node.Right.Operator);
			Assert.IsNotNull(node.Right.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Right.Term.Operator);
			Assert.AreEqual("FirstName", node.Right.Term.PropertyName);
			Assert.AreEqual("J*", node.Right.Term.Value);

			Assert.AreEqual(LogicalOperator.And, node.Operator);
			Assert.IsNull(node.Term);
		}

		[Test]
		public void ParseOr()
		{
			FilterNode node = FilterNode.Parse("name = value Or orders > 50");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);

			Assert.IsNotNull(node.Left);
			Assert.IsNull(node.Left.Evaluated);
			Assert.IsNull(node.Left.Left);
			Assert.IsNull(node.Left.Right);
			Assert.AreEqual(LogicalOperator.None, node.Left.Operator);
			Assert.IsNotNull(node.Left.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Term.Operator);
			Assert.AreEqual("name", node.Left.Term.PropertyName);
			Assert.AreEqual("value", node.Left.Term.Value);

			Assert.IsNotNull(node.Right);
			Assert.IsNull(node.Right.Evaluated);
			Assert.IsNull(node.Right.Left);
			Assert.IsNull(node.Right.Right);
			Assert.AreEqual(LogicalOperator.None, node.Right.Operator);
			Assert.IsNotNull(node.Right.Term);
			Assert.AreEqual(RelationalOperator.Greater, node.Right.Term.Operator);
			Assert.AreEqual("orders", node.Right.Term.PropertyName);
			Assert.AreEqual("50", node.Right.Term.Value);

			Assert.AreEqual(LogicalOperator.Or, node.Operator);
			Assert.IsNull(node.Term);
		}

		[Test]
		public void ParseOrQuoted()
		{
			FilterNode node = FilterNode.Parse("LastName = 'Smi*' OR FirstName = 'J*'");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);

			Assert.IsNotNull(node.Left);
			Assert.IsNull(node.Left.Evaluated);
			Assert.IsNull(node.Left.Left);
			Assert.IsNull(node.Left.Right);
			Assert.AreEqual(LogicalOperator.None, node.Left.Operator);
			Assert.IsNotNull(node.Left.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Term.Operator);
			Assert.AreEqual("LastName", node.Left.Term.PropertyName);
			Assert.AreEqual("Smi*", node.Left.Term.Value);

			Assert.IsNotNull(node.Right);
			Assert.IsNull(node.Right.Evaluated);
			Assert.IsNull(node.Right.Left);
			Assert.IsNull(node.Right.Right);
			Assert.AreEqual(LogicalOperator.None, node.Right.Operator);
			Assert.IsNotNull(node.Right.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Right.Term.Operator);
			Assert.AreEqual("FirstName", node.Right.Term.PropertyName);
			Assert.AreEqual("J*", node.Right.Term.Value);

			Assert.AreEqual(LogicalOperator.Or, node.Operator);
			Assert.IsNull(node.Term);
		}

		[Test]
		public void ParseAndOr()
		{
			FilterNode node = FilterNode.Parse("name = value AND State = OR OR orders > 50");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);

			Assert.IsNotNull(node.Left);
			Assert.IsNull(node.Left.Evaluated);
			Assert.IsNotNull(node.Left.Left);
			Assert.IsNotNull(node.Left.Right);
			Assert.AreEqual(LogicalOperator.And, node.Left.Operator);
			Assert.IsNull(node.Left.Term);

			Assert.IsNotNull(node.Left.Left.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Left.Term.Operator);
			Assert.AreEqual("name", node.Left.Left.Term.PropertyName);
			Assert.AreEqual("value", node.Left.Left.Term.Value);

			Assert.IsNotNull(node.Left.Right.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Right.Term.Operator);
			Assert.AreEqual("State", node.Left.Right.Term.PropertyName);
			Assert.AreEqual("OR", node.Left.Right.Term.Value);

			Assert.IsNotNull(node.Right);
			Assert.IsNull(node.Right.Evaluated);
			Assert.IsNull(node.Right.Left);
			Assert.IsNull(node.Right.Right);
			Assert.AreEqual(LogicalOperator.None, node.Right.Operator);
			Assert.IsNotNull(node.Right.Term);
			Assert.AreEqual(RelationalOperator.Greater, node.Right.Term.Operator);
			Assert.AreEqual("orders", node.Right.Term.PropertyName);
			Assert.AreEqual("50", node.Right.Term.Value);

			Assert.AreEqual(LogicalOperator.Or, node.Operator);
			Assert.IsNull(node.Term);
		}

		[Test]
		public void ParseOrAnd()
		{
			FilterNode node = FilterNode.Parse("name = value OR State = OR AND orders > 50");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);

			Assert.IsNotNull(node.Left);
			Assert.IsNull(node.Left.Evaluated);
			Assert.IsNull(node.Left.Left);
			Assert.IsNull(node.Left.Right);
			Assert.AreEqual(LogicalOperator.None, node.Left.Operator);
			Assert.IsNotNull(node.Left.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Term.Operator);
			Assert.AreEqual("name", node.Left.Term.PropertyName);
			Assert.AreEqual("value", node.Left.Term.Value);

			Assert.IsNotNull(node.Right);
			Assert.IsNull(node.Right.Evaluated);
			Assert.IsNotNull(node.Right.Left);
			Assert.IsNotNull(node.Right.Right);
			Assert.AreEqual(LogicalOperator.And, node.Right.Operator);
			Assert.IsNull(node.Right.Term);

			Assert.IsNotNull(node.Right.Left.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Right.Left.Term.Operator);
			Assert.AreEqual("State", node.Right.Left.Term.PropertyName);
			Assert.AreEqual("OR", node.Right.Left.Term.Value);

			Assert.IsNotNull(node.Right.Right.Term);
			Assert.AreEqual(RelationalOperator.Greater, node.Right.Right.Term.Operator);
			Assert.AreEqual("orders", node.Right.Right.Term.PropertyName);
			Assert.AreEqual("50", node.Right.Right.Term.Value);

			Assert.AreEqual(LogicalOperator.Or, node.Operator);
			Assert.IsNull(node.Term);
		}

		[Test]
		public void ParseOrAndParens()
		{
			FilterNode node = FilterNode.Parse("(name = value OR State = OR) AND orders > 50");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);

			Assert.IsNotNull(node.Left);
			Assert.IsNull(node.Left.Evaluated);
			Assert.IsNotNull(node.Left.Left);
			Assert.IsNotNull(node.Left.Right);
			Assert.AreEqual(LogicalOperator.Or, node.Left.Operator);
			Assert.IsNull(node.Left.Term);

			Assert.IsNotNull(node.Left.Left.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Left.Term.Operator);
			Assert.AreEqual("name", node.Left.Left.Term.PropertyName);
			Assert.AreEqual("value", node.Left.Left.Term.Value);

			Assert.IsNotNull(node.Left.Right.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Right.Term.Operator);
			Assert.AreEqual("State", node.Left.Right.Term.PropertyName);
			Assert.AreEqual("OR", node.Left.Right.Term.Value);

			Assert.IsNotNull(node.Right);
			Assert.IsNull(node.Right.Evaluated);
			Assert.IsNull(node.Right.Left);
			Assert.IsNull(node.Right.Right);
			Assert.AreEqual(LogicalOperator.None, node.Right.Operator);

			Assert.IsNotNull(node.Right.Term);
			Assert.AreEqual(RelationalOperator.Greater, node.Right.Term.Operator);
			Assert.AreEqual("orders", node.Right.Term.PropertyName);
			Assert.AreEqual("50", node.Right.Term.Value);

			Assert.AreEqual(LogicalOperator.And, node.Operator);
			Assert.IsNull(node.Term);
		}

		[Test]
		public void ParseAndOrAndParens()
		{
			// Level 0
			FilterNode node = FilterNode.Parse("Name = Smith AND ((State = WA OR orders >= 50) AND Id != 8) OR Active == true");
			Assert.IsNotNull(node);
			Assert.IsNull(node.Evaluated);
			Assert.AreEqual(LogicalOperator.Or, node.Operator);
			Assert.IsNull(node.Term);
			Assert.IsNotNull(node.Left);
			Assert.IsNotNull(node.Right);

			// Level 1 Left
			Assert.IsNull(node.Left.Evaluated);
			Assert.IsNotNull(node.Left.Left);
			Assert.IsNotNull(node.Left.Right);
			Assert.AreEqual(LogicalOperator.And, node.Left.Operator);
			Assert.IsNull(node.Left.Term);

			// Level 1 Right
			Assert.IsNull(node.Right.Evaluated);
			Assert.IsNull(node.Right.Left);
			Assert.IsNull(node.Right.Right);
			Assert.AreEqual(LogicalOperator.None, node.Right.Operator);
			Assert.IsNotNull(node.Right.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Right.Term.Operator);
			Assert.AreEqual("Active", node.Right.Term.PropertyName);
			Assert.AreEqual("true", node.Right.Term.Value);

			// Level 2 LL
			Assert.IsNull(node.Left.Left.Evaluated);
			Assert.IsNull(node.Left.Left.Left);
			Assert.IsNull(node.Left.Left.Right);
			Assert.AreEqual(LogicalOperator.None, node.Left.Left.Operator);
			Assert.IsNotNull(node.Left.Left.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Left.Term.Operator);
			Assert.AreEqual("Name", node.Left.Left.Term.PropertyName);
			Assert.AreEqual("Smith", node.Left.Left.Term.Value);

			// Level 2 LR
			Assert.IsNull(node.Left.Right.Evaluated);
			Assert.IsNotNull(node.Left.Right.Left);
			Assert.IsNotNull(node.Left.Right.Right);
			Assert.AreEqual(LogicalOperator.And, node.Left.Right.Operator);
			Assert.IsNull(node.Left.Right.Term);

			// Level 3 LRL
			Assert.IsNull(node.Left.Right.Left.Evaluated);
			Assert.IsNotNull(node.Left.Right.Left.Left);
			Assert.IsNotNull(node.Left.Right.Left.Right);
			Assert.AreEqual(LogicalOperator.Or, node.Left.Right.Left.Operator);
			Assert.IsNull(node.Left.Right.Left.Term);

			// Level 3 LRR
			Assert.IsNull(node.Left.Right.Right.Evaluated);
			Assert.IsNull(node.Left.Right.Right.Left);
			Assert.IsNull(node.Left.Right.Right.Right);
			Assert.AreEqual(LogicalOperator.None, node.Left.Right.Right.Operator);
			Assert.IsNotNull(node.Left.Right.Right.Term);
			Assert.AreEqual(RelationalOperator.NotEqual, node.Left.Right.Right.Term.Operator);
			Assert.AreEqual("Id", node.Left.Right.Right.Term.PropertyName);
			Assert.AreEqual("8", node.Left.Right.Right.Term.Value);

			// Level 4 LRLL
			Assert.IsNotNull(node.Left.Right.Left.Left.Term);
			Assert.AreEqual(RelationalOperator.Equal, node.Left.Right.Left.Left.Term.Operator);
			Assert.AreEqual("State", node.Left.Right.Left.Left.Term.PropertyName);
			Assert.AreEqual("WA", node.Left.Right.Left.Left.Term.Value);

			// Level 4 LRLR
			Assert.IsNotNull(node.Left.Right.Left.Right.Term);
			Assert.AreEqual(RelationalOperator.GreaterEqual, node.Left.Right.Left.Right.Term.Operator);
			Assert.AreEqual("orders", node.Left.Right.Left.Right.Term.PropertyName);
			Assert.AreEqual("50", node.Left.Right.Left.Right.Term.Value);
		}
	}
}
#endif
