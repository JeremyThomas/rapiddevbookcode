using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace JesseJohnston
{
  /// <summary>
  /// A node in the filter expression tree.  A node may be a terminal expression (i.e. property name, value, and relational operator)
  /// or a sub-tree containing a logical operator, left and right terms.
  /// </summary>
  internal class FilterNode : IEnumerable<FilterNode>
  {
    #region Types

    private class FilterNodeEnumerator : IEnumerator<FilterNode>
    {
      private readonly FilterNode tree;
      private FilterNode current;
      private readonly Stack<FilterNode> nodes = new Stack<FilterNode>();

      public FilterNodeEnumerator(FilterNode tree)
      {
        this.tree = tree;
      }

      #region IEnumerator<FilterNode> Members

      public FilterNode Current
      {
        get
        {
          if (current == null)
            throw new InvalidOperationException("Current");
          else
            return current;
        }
      }

      #endregion

      #region IDisposable Members

      public void Dispose()
      {
      }

      #endregion

      #region IEnumerator Members

      object IEnumerator.Current
      {
        get { return (this).Current; }
      }

      public bool MoveNext()
      {
        // Initially, current is null, so we traverse the left edge.
        if (current == null)
        {
          current = tree;

          if (current.left == null && current.right == null)
            return true;

          // don't return it; we want to go down the left side first.
        }
        else if (current.right != null)
        {
          current = current.right;

          if (current.left == null && current.right == null)
            return true;

          // don't return it; we want to go down the left side first.
        }

        if (current.left != null)
        {
          while (current.left != null)
          {
            nodes.Push(current);
            current = current.left;
          }

          return true;
        }
        else if (nodes.Count > 0)
        {
          current = nodes.Pop();
          return true;
        }
        else
          return false;
      }

      public void Reset()
      {
        current = null;
        nodes.Clear();
      }

      #endregion
    }

    private enum TokenType
    {
      Term,
      Relation,
      Condition,
      OpenParen,
      CloseParen,
      ResolvedExpression,
      ResolvedNode
    }

    private class Token
    {
      private readonly string term;
      private readonly LogicalOperator logOp;
      private readonly RelationalOperator relOp;
      private readonly RelationalExpression expr;
      private readonly FilterNode node;
      private readonly TokenType type;

      public LogicalOperator Condition
      {
        get
        {
          if (type != TokenType.Condition)
            throw new StrongTypingException("Token is not a condition.");
          return logOp;
        }
      }

      public RelationalOperator Relation
      {
        get
        {
          if (type != TokenType.Relation)
            throw new StrongTypingException("Token is not a relation.");
          return relOp;
        }
      }

      public RelationalExpression ResolvedExpression
      {
        get
        {
          if (type != TokenType.ResolvedExpression)
            throw new StrongTypingException("Token is not a resolved expression.");
          return expr;
        }
      }

      public FilterNode ResolvedNode
      {
        get
        {
          if (type != TokenType.ResolvedNode)
            throw new StrongTypingException("Token is not a resolved node.");
          return node;
        }
      }

      public string Term
      {
        get
        {
          if (type != TokenType.Term)
            throw new StrongTypingException("Token is not a term.");
          return term;
        }
      }

      public TokenType Type
      {
        get { return type; }
      }

      public Token(string term)
      {
        if (term == "(")
          type = TokenType.OpenParen;
        else if (term == ")")
          type = TokenType.CloseParen;
        else
        {
          type = TokenType.Term;
          this.term = term;
        }
      }

      public Token(LogicalOperator condition)
      {
        type = TokenType.Condition;
        logOp = condition;
      }

      public Token(RelationalOperator relation)
      {
        type = TokenType.Relation;
        relOp = relation;
      }

      public Token(RelationalExpression expression)
      {
        type = TokenType.ResolvedExpression;
        expr = expression;
      }

      public Token(FilterNode node)
      {
        type = TokenType.ResolvedNode;
        this.node = node;
      }
    }

    private class Tokenizer : IEnumerable<Token>
    {
      private readonly List<Token> tokens = new List<Token>();
      private static readonly Dictionary<string, LogicalOperator> logicalOps = new Dictionary<string, LogicalOperator>();
      private static readonly Dictionary<string, RelationalOperator> relationalOps = new Dictionary<string, RelationalOperator>();
      private static readonly List<string> multiCharRelationalOps = new List<string>();

      static Tokenizer()
      {
        logicalOps.Add("And", LogicalOperator.And);
        logicalOps.Add("Or", LogicalOperator.Or);

        relationalOps.Add("=", RelationalOperator.Equal);
        relationalOps.Add("==", RelationalOperator.Equal);
        relationalOps.Add("!=", RelationalOperator.NotEqual);
        relationalOps.Add("<>", RelationalOperator.NotEqual);
        relationalOps.Add("<", RelationalOperator.Less);
        relationalOps.Add("<=", RelationalOperator.LessEqual);
        relationalOps.Add(">", RelationalOperator.Greater);
        relationalOps.Add(">=", RelationalOperator.GreaterEqual);

        foreach (var op in relationalOps.Keys)
        {
          if (op.Length > 1)
            multiCharRelationalOps.Add(op);
        }
      }

      public Tokenizer(string expression)
      {
        if (expression == null)
          throw new ArgumentNullException("expression");
        if (expression == "")
          throw new ArgumentException("expression");

        // Split into tokens delimited by spaces, relational operators, and parentheses.  Remove extra spaces.
        var parts = ExtractTokens(expression,
                                  new[] {' ', '<', '>', '=', '!', '(', ')'},
                                  new[] {'<', '>', '=', '!', '(', ')'},
                                  new[] {'\'', '"'});

        if (parts.Count == 0)
          throw new ArgumentException("expression");

        // Parse into tokens that are either operators, terms or a paren.
        Token prevToken = null;
        var parenCount = 0;

        foreach (var part in parts)
        {
          Token t = null;

          // Because a condition could also be the rvalue of a relation (e.g. State = OR), evaluate as a condition
          // only if it does not follow a relational operator.
          if (prevToken == null || prevToken.Type != TokenType.Relation)
            foreach (var pair in logicalOps)
            {
              if (string.Compare(part, pair.Key, true) == 0)
              {
                if (prevToken == null || (prevToken.Type != TokenType.Term && prevToken.Type != TokenType.CloseParen))
                  throw new ArgumentException("An operator must be preceded by an expression term or closing paren.", "expression");
                t = new Token(pair.Value);
                break;
              }
            }

          if (t == null)
            foreach (var pair in relationalOps)
            {
              if (string.Compare(part, pair.Key, true) == 0)
              {
                if (prevToken == null || prevToken.Type != TokenType.Term)
                  throw new ArgumentException("An operator must be preceded by an expression term.", "expression");
                t = new Token(pair.Value);
                break;
              }
            }

          if (t == null)
          {
            if (part == "(")
            {
              if (prevToken != null && prevToken.Type != TokenType.Condition && prevToken.Type != TokenType.Relation && prevToken.Type != TokenType.OpenParen)
                throw new ArgumentException("An opening paren must be preceded by an operator or an opening paren.", "expression");
              parenCount++;
            }
            else if (part == ")")
            {
              if (prevToken == null || (prevToken.Type != TokenType.Term && prevToken.Type != TokenType.CloseParen))
                throw new ArgumentException("A closing paren must be preceded by an expression term or a closing paren.", "expression");
              if (parenCount == 0)
                throw new ArgumentException("Unbalanced parentheses.", "expression");
              parenCount--;
            }
            else if (prevToken != null && prevToken.Type != TokenType.Condition && prevToken.Type != TokenType.Relation && prevToken.Type != TokenType.OpenParen)
              throw new ArgumentException("An expression term must be preceded by an operator or opening paren.", "expression");

            t = new Token(part);
          }

          tokens.Add(t);
          prevToken = t;
        }

        // The expression must end with a term or a closing paren.
        var last = tokens[tokens.Count - 1];
        if (last.Type != TokenType.Term && last.Type != TokenType.CloseParen)
          throw new ArgumentException("An expression must end in an expression term or a closing paren.", "expression");

        // The expression must contain at least two terms and a relation.
        var terms = 0;
        var relations = 0;
        foreach (var t in tokens)
        {
          if (t.Type == TokenType.Term)
            terms++;
          else if (t.Type == TokenType.Relation)
            relations++;
        }

        if (terms < 2 || relations == 0)
          throw new ArgumentException("An expression must contain at least two terms and a relational operator.", "expression");
      }

      private ICollection<string> ExtractTokens(string expression, char[] delimiters, char[] delimitersIncludedAsTokens, char[] quotes)
      {
        var tokens = new List<string>();
        var delims = new List<char>(delimiters); // delimiters
        var delimTokens = new List<char>(delimitersIncludedAsTokens); // delimiters which are also tokens
        var quoteChars = new List<char>(quotes);

        var tokenStart = 0;
        var tokenEnd = 0;
        var inQuote = false;
        var prevQuote = ' ';

        // Remove leading and trailing whitespace.
        expression = expression.Trim();

        for (var i = 0; i < expression.Length; i++)
        {
          var c = expression[i];

          if (i == expression.Length - 1) // Remainder of string (not ending in a delimiter)
          {
            if (inQuote && c == prevQuote)
              tokens.Add(expression.Substring(tokenStart, i - tokenStart));
            else if (!delims.Contains(c) || delimTokens.Contains(c))
              tokens.Add(expression.Substring(tokenStart));
          }
          else if (quoteChars.Contains(c)) // Quote found
            if (inQuote)
            {
              if (c == prevQuote)
              {
                inQuote = false;

                tokenEnd = i;

                if (tokenEnd > tokenStart) // Non-empty?
                  tokens.Add(expression.Substring(tokenStart, tokenEnd - tokenStart));

                tokenStart = i + 1; // Start parsing the next token
              }
            }
            else
            {
              inQuote = true;
              prevQuote = c;
              tokenStart = i + 1; // Start parsing the next token
            }
          else if (!inQuote && delims.Contains(c)) // Delimiter found
          {
            tokenEnd = i;

            if (tokenEnd > tokenStart) // Non-empty?
              tokens.Add(expression.Substring(tokenStart, tokenEnd - tokenStart));

            if (delimTokens.Contains(c)) // If the delimiter is also a token, add it to the token list
              tokens.Add(new string(c, 1));

            tokenStart = i + 1; // Start parsing the next token
          }
        }

        // Coalesce adjacent operators that form a multi-character operator (e.g. <>, !=, ==)
        var prevToken = "";
        var tokenArray = tokens.ToArray();
        var tokensRemoved = 0;
        for (var j = 0; j < tokenArray.Length; j++)
        {
          var token = tokenArray[j];
          var compoundToken = prevToken + token;
          if (multiCharRelationalOps.Contains(compoundToken))
          {
            var newPosition = j - 1 - tokensRemoved;
            tokens.RemoveAt(newPosition);
            tokens.RemoveAt(newPosition);
            tokens.Insert(newPosition, compoundToken);
            tokensRemoved++;
          }

          prevToken = token;
        }

        return tokens;
      }

      #region IEnumerable<Token> Members

      public IEnumerator<Token> GetEnumerator()
      {
        return tokens.GetEnumerator();
      }

      #endregion

      #region IEnumerable Members

      IEnumerator IEnumerable.GetEnumerator()
      {
        return ((IEnumerable) tokens).GetEnumerator();
      }

      #endregion
    }

    #endregion

    private readonly LogicalOperator op;
    private readonly RelationalExpression term;
    private readonly FilterNode left;
    private readonly FilterNode right;
    private bool? evaluated;

    public bool? Evaluated
    {
      get { return evaluated; }
    }

    public FilterNode Left
    {
      get { return left; }
    }

    public LogicalOperator Operator
    {
      get { return op; }
    }

    public FilterNode Right
    {
      get { return right; }
    }

    public RelationalExpression Term
    {
      get { return term; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FilterNode"/> class that is a terminal node.
    /// </summary>
    /// <remarks>
    /// A terminal node is a relational expression, and contains no child nodes.
    /// </remarks>
    /// <param name="term">The expression term.</param>
    public FilterNode(RelationalExpression term)
    {
      if (term == null)
        throw new ArgumentNullException("term");
      this.term = term;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FilterNode"/> class that is not a terminal node.
    /// </summary>
    /// <param name="left">The left child node.</param>
    /// <param name="right">The right node.</param>
    /// <param name="op">The operator relating the child nodes.</param>
    public FilterNode(FilterNode left, FilterNode right, LogicalOperator op)
    {
      if (left == null)
        throw new ArgumentNullException("left");
      if (right == null)
        throw new ArgumentNullException("right");
      if (op == LogicalOperator.None)
        throw new ArgumentException("op");

      this.left = left;
      this.right = right;
      this.op = op;
    }

    /// <summary>
    /// Parses the specified text into a binary expression tree.
    /// </summary>
    /// <param name="expression">The expression text to parse.</param>
    /// <returns></returns>
    public static FilterNode Parse(string expression)
    {
      var tokens = new List<Token>(new Tokenizer(expression));

      // Combine terms and relational operators into expressions.
      while (true)
      {
        var evaluationIndex = -1;
        for (var i = 0; i < tokens.Count; i++)
        {
          if (tokens[i].Type == TokenType.Relation)
          {
            evaluationIndex = i;
            break;
          }
        }

        if (evaluationIndex > -1)
        {
          var expr = new RelationalExpression(tokens[evaluationIndex - 1].Term,
                                              tokens[evaluationIndex + 1].Term,
                                              tokens[evaluationIndex].Relation);
          tokens.RemoveAt(evaluationIndex - 1);
          tokens.RemoveAt(evaluationIndex - 1);
          tokens.RemoveAt(evaluationIndex - 1);

          tokens.Insert(evaluationIndex - 1, new Token(expr));

          // Remove parentheses surrounding a resolved expression.
          if (evaluationIndex - 2 > -1 && tokens[evaluationIndex - 2].Type == TokenType.OpenParen &&
              evaluationIndex < tokens.Count && tokens[evaluationIndex].Type == TokenType.CloseParen)
          {
            // New resolved expression is now at evaluationIndex - 1.
            tokens.RemoveAt(evaluationIndex - 2);
            // New resolved expression is now at evaluationIndex - 2.
            tokens.RemoveAt(evaluationIndex - 1);
          }
        }
        else
          break;
      }

      // If the token list contains only a single relational expression, we can return a simple filter node based on that.
      if (tokens.Count == 1 && tokens[0].Type == TokenType.ResolvedExpression)
        return new FilterNode(tokens[0].ResolvedExpression);

      // The token list now contains only RelationalExpressions, conditional operators (AND and OR) and parentheses.
      // Combine the expressions and operators into nodes, prioritizing binding according to the natural order of precedence
      // for boolean operators and parentheses.
      var operatorPriorities = new Dictionary<LogicalOperator, int>();
      operatorPriorities.Add(LogicalOperator.Or, 1);
      operatorPriorities.Add(LogicalOperator.And, 2);
      var parenAddedPriority = operatorPriorities.Count;

      while (true)
      {
        var contextPriority = 0;
        var evaluationPriorityMax = -1;
        var evaluationIndex = -1;

        for (var i = 0; i < tokens.Count; i++)
        {
          var type = tokens[i].Type;

          if (type == TokenType.Condition)
          {
            var evaluationPriority = operatorPriorities[tokens[i].Condition] + contextPriority;
            if (evaluationPriority > evaluationPriorityMax)
            {
              evaluationIndex = i;
              evaluationPriorityMax = evaluationPriority;
            }
          }
          else if (type == TokenType.OpenParen)
            contextPriority += parenAddedPriority;
          else if (type == TokenType.CloseParen)
            contextPriority -= parenAddedPriority;
        }

        if (evaluationIndex > -1)
        {
          var prevToken = tokens[evaluationIndex - 1];
          var nextToken = tokens[evaluationIndex + 1];

          FilterNode nodeLeft = null;
          FilterNode nodeRight = null;

          // Tokens surrounding the AND or OR must now be either a relational expression or a resolved FilterNode.
          if (prevToken.Type == TokenType.ResolvedExpression)
            nodeLeft = new FilterNode(prevToken.ResolvedExpression);
          else
            nodeLeft = prevToken.ResolvedNode;
          if (nextToken.Type == TokenType.ResolvedExpression)
            nodeRight = new FilterNode(nextToken.ResolvedExpression);
          else
            nodeRight = nextToken.ResolvedNode;

          var node = new FilterNode(nodeLeft, nodeRight, tokens[evaluationIndex].Condition);

          tokens.RemoveAt(evaluationIndex - 1);
          tokens.RemoveAt(evaluationIndex - 1);
          tokens.RemoveAt(evaluationIndex - 1);

          tokens.Insert(evaluationIndex - 1, new Token(node));

          // Remove parentheses surrounding a resolved node.
          if (evaluationIndex - 2 > -1 && tokens[evaluationIndex - 2].Type == TokenType.OpenParen &&
              evaluationIndex < tokens.Count && tokens[evaluationIndex].Type == TokenType.CloseParen)
          {
            // New resolved node is now at evaluationIndex - 1.
            tokens.RemoveAt(evaluationIndex - 2);
            // New resolved node is now at evaluationIndex - 2.
            tokens.RemoveAt(evaluationIndex - 1);
          }
        }
        else
          break;
      }

      // The token list should now contain a single FilterNode.
      return tokens[0].ResolvedNode;
    }

    /// <summary>
    /// Evaluates the current node and it's child nodes.
    /// </summary>
    /// <param name="evaluator">The delegate used to evaluate terminal nodes.</param>
    /// <returns>True if the current node and it's children evaluate to true; false otherwise.</returns>
    public bool Evaluate(ExpressionEvaluator evaluator)
    {
      var current = this;
      var nodes = new Stack<FilterNode>();

      while (true)
      {
        // A terminal expression?
        if (current.op == LogicalOperator.None)
          current.evaluated = evaluator(current);
        else
        {
          if (!current.left.evaluated.HasValue)
          {
            nodes.Push(current);
            current = current.left;
            continue;
          }

          if (!current.right.evaluated.HasValue)
          {
            nodes.Push(current);
            current = current.right;
            continue;
          }

          if (current.op == LogicalOperator.And)
            current.evaluated = current.left.evaluated.Value && current.right.evaluated.Value;
          else
            current.evaluated = current.left.evaluated.Value || current.right.evaluated.Value;
        }

        if (nodes.Count > 0)
          current = nodes.Pop();
        else
          return current.evaluated.Value;
      }
    }

    /// <summary>
    /// Resets the evaluation status for each node in the expression tree, so that it can be re-evaluated.
    /// </summary>
    public void Reset()
    {
      foreach (var node in this)
      {
        node.evaluated = null;
      }
    }

    #region IEnumerable<FilterNode> Members

    public IEnumerator<FilterNode> GetEnumerator()
    {
      return new FilterNodeEnumerator(this);
    }

    #endregion

    #region IEnumerable Members

    IEnumerator IEnumerable.GetEnumerator()
    {
      return ((IEnumerable<FilterNode>) this).GetEnumerator();
    }

    #endregion
  }

  internal delegate bool ExpressionEvaluator(FilterNode expression);
}