#pragma warning disable 1591	// Missing XML comment


using System;
using NUnit.Framework;

namespace JesseJohnston.Tests
{
  [TestFixture]
  public class FilterNodeTests
  {
    #region Types

    private class TestFilterNode : FilterNode
    {
      private readonly bool result;

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
      var exp = new RelationalExpression("Name", "Smith", RelationalOperator.Equal);
      var node = new FilterNode(exp);
      Assert.AreEqual(exp, node.Term);
      Assert.IsFalse(node.Evaluated.HasValue);
      Assert.IsNull(node.Left);
      Assert.IsNull(node.Right);
      Assert.AreEqual(LogicalOperator.None, node.Operator);
    }

    [Test]
    public void EvaluateTerminalNodeTrue()
    {
      var exp = new RelationalExpression("Name", "Smith", RelationalOperator.Equal);
      var node = new FilterNode(exp);

      node.Evaluate(delegate { return true; });

      Assert.IsTrue(node.Evaluated.HasValue);
      Assert.IsTrue(node.Evaluated.Value);
    }

    [Test]
    public void EvaluateTerminalNodeFalse()
    {
      var exp = new RelationalExpression("Name", "Smith", RelationalOperator.Equal);
      var node = new FilterNode(exp);

      node.Evaluate(delegate { return false; });

      Assert.IsTrue(node.Evaluated.HasValue);
      Assert.IsFalse(node.Evaluated.Value);
    }

    [Test]
    public void ConstructOrNode()
    {
      var expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
      var expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
      var nodeLeft = new FilterNode(expLeft);
      var nodeRight = new FilterNode(expRight);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

      Assert.IsNull(node.Term);
      Assert.IsFalse(node.Evaluated.HasValue);
      Assert.AreEqual(nodeLeft, node.Left);
      Assert.AreEqual(nodeRight, node.Right);
      Assert.AreEqual(LogicalOperator.Or, node.Operator);
    }

    [Test]
    public void EvaluateOrNodeFalseFalse()
    {
      var expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
      var expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
      var nodeLeft = new FilterNode(expLeft);
      var nodeRight = new FilterNode(expRight);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

      Assert.IsFalse(node.Evaluate(delegate { return false; }));

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
      var expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
      var expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
      var nodeLeft = new FilterNode(expLeft);
      var nodeRight = new FilterNode(expRight);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

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
      var expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
      var expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
      var nodeLeft = new FilterNode(expLeft);
      var nodeRight = new FilterNode(expRight);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

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
      var expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
      var expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
      var nodeLeft = new FilterNode(expLeft);
      var nodeRight = new FilterNode(expRight);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

      Assert.IsTrue(node.Evaluate(delegate { return true; }));

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
      var expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
      var expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
      var nodeLeft = new FilterNode(expLeft);
      var nodeRight = new FilterNode(expRight);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

      Assert.IsNull(node.Term);
      Assert.IsFalse(node.Evaluated.HasValue);
      Assert.AreEqual(nodeLeft, node.Left);
      Assert.AreEqual(nodeRight, node.Right);
      Assert.AreEqual(LogicalOperator.And, node.Operator);
    }

    [Test]
    public void EvaluateAndNodeFalseFalse()
    {
      var expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
      var expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
      var nodeLeft = new FilterNode(expLeft);
      var nodeRight = new FilterNode(expRight);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

      Assert.IsFalse(node.Evaluate(delegate { return false; }));

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
      var expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
      var expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
      var nodeLeft = new FilterNode(expLeft);
      var nodeRight = new FilterNode(expRight);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

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
      var expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
      var expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
      var nodeLeft = new FilterNode(expLeft);
      var nodeRight = new FilterNode(expRight);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

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
      var expLeft = new RelationalExpression("Name", "Smith", RelationalOperator.Less);
      var expRight = new RelationalExpression("Name", "Smith", RelationalOperator.Greater);
      var nodeLeft = new FilterNode(expLeft);
      var nodeRight = new FilterNode(expRight);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

      Assert.IsTrue(node.Evaluate(delegate { return true; }));

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
      var nodeLeft = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.Or);
      var nodeRight = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.Or);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

      Assert.IsNull(node.Term);
      Assert.IsFalse(node.Evaluated.HasValue);
      Assert.AreEqual(nodeLeft, node.Left);
      Assert.AreEqual(nodeRight, node.Right);
      Assert.AreEqual(LogicalOperator.Or, node.Operator);
    }

    [Test]
    public void EvaluateOrTreeFalseFalse()
    {
      var nodeLeft = new FilterNode(new TestFilterNode(false), new TestFilterNode(false), LogicalOperator.Or);
      var nodeRight = new FilterNode(new TestFilterNode(false), new TestFilterNode(true), LogicalOperator.And);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

      Assert.IsFalse(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode) n).Result; }));

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
      var nodeLeft = new FilterNode(new TestFilterNode(false), new TestFilterNode(false), LogicalOperator.Or);
      var nodeRight = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.And);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

      Assert.IsTrue(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode) n).Result; }));

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
      var nodeLeft = new FilterNode(new TestFilterNode(true), new TestFilterNode(false), LogicalOperator.Or);
      var nodeRight = new FilterNode(new TestFilterNode(false), new TestFilterNode(true), LogicalOperator.And);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

      Assert.IsTrue(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode) n).Result; }));

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
      var nodeLeft = new FilterNode(new TestFilterNode(true), new TestFilterNode(false), LogicalOperator.Or);
      var nodeRight = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.And);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.Or);

      Assert.IsTrue(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode) n).Result; }));

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
      var nodeLeft = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.Or);
      var nodeRight = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.Or);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

      Assert.IsNull(node.Term);
      Assert.IsFalse(node.Evaluated.HasValue);
      Assert.AreEqual(nodeLeft, node.Left);
      Assert.AreEqual(nodeRight, node.Right);
      Assert.AreEqual(LogicalOperator.And, node.Operator);
    }

    [Test]
    public void EvaluateAndTreeFalseFalse()
    {
      var nodeLeft = new FilterNode(new TestFilterNode(false), new TestFilterNode(false), LogicalOperator.Or);
      var nodeRight = new FilterNode(new TestFilterNode(false), new TestFilterNode(true), LogicalOperator.And);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

      Assert.IsFalse(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode) n).Result; }));

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
      var nodeLeft = new FilterNode(new TestFilterNode(false), new TestFilterNode(false), LogicalOperator.Or);
      var nodeRight = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.And);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

      Assert.IsFalse(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode) n).Result; }));

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
      var nodeLeft = new FilterNode(new TestFilterNode(true), new TestFilterNode(false), LogicalOperator.Or);
      var nodeRight = new FilterNode(new TestFilterNode(false), new TestFilterNode(true), LogicalOperator.And);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

      Assert.IsFalse(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode) n).Result; }));

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
      var nodeLeft = new FilterNode(new TestFilterNode(true), new TestFilterNode(false), LogicalOperator.Or);
      var nodeRight = new FilterNode(new TestFilterNode(true), new TestFilterNode(true), LogicalOperator.And);
      var node = new FilterNode(nodeLeft, nodeRight, LogicalOperator.And);

      Assert.IsTrue(node.Evaluate(delegate(FilterNode n) { return ((TestFilterNode) n).Result; }));

      Assert.IsTrue(nodeLeft.Evaluated.HasValue);
      Assert.IsTrue(nodeLeft.Evaluated.Value);
      Assert.IsTrue(nodeRight.Evaluated.HasValue);
      Assert.IsTrue(nodeRight.Evaluated.Value);
      Assert.IsTrue(node.Evaluated.HasValue);
      Assert.IsTrue(node.Evaluated.Value);
    }

    [Test]
    [ExpectedException(typeof (ArgumentNullException))]
    public void ParseNull()
    {
      FilterNode.Parse(null);
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void ParseEmpty()
    {
      FilterNode.Parse("");
    }

    [Test]
    [ExpectedException(typeof (ArgumentException))]
    public void ParseSingleTerm()
    {
      FilterNode.Parse("name");
    }

    [Test]
    public void ParseSingleRelationIn()
    {
      var node = FilterNode.Parse("name IN (value)");
      Assert.IsNotNull(node);
      Assert.IsNull(node.Evaluated);
      Assert.IsNull(node.Left);
      Assert.IsNull(node.Right);
      Assert.AreEqual(LogicalOperator.None, node.Operator);
      Assert.IsNotNull(node.Term);
      Assert.AreEqual(RelationalOperator.In, node.Term.Operator);
      Assert.AreEqual("name", node.Term.PropertyName);
      Assert.AreEqual("value", node.Term.Value);
    }

    [Test]
    public void ParseSingleRelationInEmpty()
    {
      var node = FilterNode.Parse("name IN ('')");
      Assert.IsNotNull(node);
      Assert.IsNull(node.Evaluated);
      Assert.IsNull(node.Left);
      Assert.IsNull(node.Right);
      Assert.AreEqual(LogicalOperator.None, node.Operator);
      Assert.IsNotNull(node.Term);
      Assert.AreEqual(RelationalOperator.In, node.Term.Operator);
      Assert.AreEqual("name", node.Term.PropertyName);
      Assert.AreEqual("", node.Term.Value);
    }

    [Test]
    public void ParseSingleRelationIs()
    {
      var node = FilterNode.Parse("name IS NULL");
      Assert.IsNotNull(node);
      Assert.IsNull(node.Evaluated);
      Assert.IsNull(node.Left);
      Assert.IsNull(node.Right);
      Assert.AreEqual(LogicalOperator.None, node.Operator);
      Assert.IsNotNull(node.Term);
      Assert.AreEqual(RelationalOperator.Is, node.Term.Operator);
      Assert.AreEqual("name", node.Term.PropertyName);
      Assert.AreEqual("NULL", node.Term.Value);
    }

    [Test]
    public void ParseSingleRelationEqual()
    {
      var node = FilterNode.Parse("name = value");
      AssertSingleRelationEqual(node);
    }

    [Test]
    public void ParseSingleRelationEqualBrackets()
    {
      var node = FilterNode.Parse("(name = value)");
      AssertSingleRelationEqual(node);
    }

    public void ParseSingleRelationEqualSquareBrackets()
    {
      var node = FilterNode.Parse("[name] = value");
      AssertSingleRelationEqual(node);
    }

    [Test]
    public void ParseSingleRelationEqualAlternate()
    {
      var node = FilterNode.Parse("name == value");
      AssertSingleRelationEqual(node);
    }

    private static void AssertSingleRelationEqual(FilterNode node)
    {
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
      var node = FilterNode.Parse("   name             =               value         ");
      AssertSingleRelationEqual(node);
    }

    [Test]
    public void ParseSingleRelationEqualQuotedWhitespace()
    {
      var node = FilterNode.Parse("name = ' value '");
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
      var node = FilterNode.Parse("Name=\"O'Reilly\"");
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
      var node = FilterNode.Parse("Name=\"O'Reilly");
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
      var node = FilterNode.Parse("name=value");
      AssertSingleRelationEqual(node);
    }

    [Test]
    public void ParseSingleRelationInequal()
    {
      var node = FilterNode.Parse("name != value");
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
      var node = FilterNode.Parse("name <> value");
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
      var node = FilterNode.Parse("name<>value");
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
      var node = FilterNode.Parse("name < value");
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
      var node = FilterNode.Parse("name <= value");
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
      var node = FilterNode.Parse("name > value");
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
      var node = FilterNode.Parse("name >= value");
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
    [ExpectedException(typeof (ArgumentException))]
    public void ParseBadCondition()
    {
      FilterNode.Parse("name = value But orders > 50");
    }

    [Test]
    public void ParseAnd()
    {
      var node = FilterNode.Parse("name = value and orders > 50");
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
      var node = FilterNode.Parse("   name     =      value     and    orders    >    50   ");
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
      var node = FilterNode.Parse("name=value AND orders>50");
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
      var node = FilterNode.Parse("LastName = 'Smi*' AND FirstName = 'J*'");
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
      var node = FilterNode.Parse("name = value Or orders > 50");
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
      var node = FilterNode.Parse("LastName = 'Smi*' OR FirstName = 'J*'");
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
      var node = FilterNode.Parse("name = value AND State = OR OR orders > 50");
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
      var node = FilterNode.Parse("name = value OR State = OR AND orders > 50");
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
      var node = FilterNode.Parse("(name = value OR State = OR) AND orders > 50");
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
      var node = FilterNode.Parse("Name = Smith AND ((State = WA OR orders >= 50) AND Id != 8) OR Active == true");
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

