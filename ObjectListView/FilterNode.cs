using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Collections;
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
			private FilterNode tree;
			private FilterNode current;
			private Stack<FilterNode> nodes = new Stack<FilterNode>();

			public FilterNodeEnumerator(FilterNode tree)
			{
				this.tree = tree;
			}

			#region IEnumerator<FilterNode> Members
			public FilterNode Current
			{
				get
				{
					if (this.current == null)
						throw new InvalidOperationException("Current");
					else
						return this.current;
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
				get { return ((IEnumerator<FilterNode>)this).Current; }
			}
			public bool MoveNext()
			{
				// Initially, current is null, so we traverse the left edge.
				if (this.current == null)
				{
					this.current = this.tree;

					if (this.current.left == null && this.current.right == null)
						return true;

					// don't return it; we want to go down the left side first.
				}
				else if (this.current.right != null)
				{
					this.current = this.current.right;

					if (this.current.left == null && this.current.right == null)
						return true;

					// don't return it; we want to go down the left side first.
				}

				if (this.current.left != null)
				{
					while (this.current.left != null)
					{
						this.nodes.Push(this.current);
						this.current = this.current.left;
					}

					return true;
				}
				else if (this.nodes.Count > 0)
				{
					this.current = this.nodes.Pop();
					return true;
				}
				else
					return false;
			}
			public void Reset()
			{
				this.current = null;
				this.nodes.Clear();
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
			private string term;
			private LogicalOperator logOp;
			private RelationalOperator relOp;
			private RelationalExpression expr;
			private FilterNode node;
			private TokenType type;

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
					if (this.type != TokenType.Relation)
						throw new StrongTypingException("Token is not a relation.");
					return relOp;
				}
			}
			public RelationalExpression ResolvedExpression
			{
				get
				{
					if (this.type != TokenType.ResolvedExpression)
						throw new StrongTypingException("Token is not a resolved expression.");
					return this.expr;
				}
			}
			public FilterNode ResolvedNode
			{
				get
				{
					if (this.type != TokenType.ResolvedNode)
						throw new StrongTypingException("Token is not a resolved node.");
					return node;
				}
			}
			public string Term
			{
				get
				{
					if (this.type != TokenType.Term)
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
					this.type = TokenType.OpenParen;
				else if (term == ")")
					this.type = TokenType.CloseParen;
				else
				{
					this.type = TokenType.Term;
					this.term = term;
				}
			}
			public Token(LogicalOperator condition)
			{
				this.type = TokenType.Condition;
				this.logOp = condition;
			}
			public Token(RelationalOperator relation)
			{
				this.type = TokenType.Relation;
				this.relOp = relation;
			}
			public Token(RelationalExpression expression)
			{
				this.type = TokenType.ResolvedExpression;
				this.expr = expression;
			}
			public Token(FilterNode node)
			{
				this.type = TokenType.ResolvedNode;
				this.node = node;
			}
		}
		private class Tokenizer : IEnumerable<Token>
		{
			private List<Token> tokens = new List<Token>();
			private static Dictionary<string, LogicalOperator> logicalOps = new Dictionary<string,LogicalOperator>();
			private static Dictionary<string, RelationalOperator> relationalOps = new Dictionary<string,RelationalOperator>();
			private static List<string> multiCharRelationalOps = new List<string>();

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

				foreach (string op in relationalOps.Keys)
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
				ICollection<string> parts = ExtractTokens(expression,
														  new char[] { ' ', '<', '>', '=', '!', '(', ')' },
														  new char[] { '<', '>', '=', '!', '(', ')' },
														  new char[] { '\'', '"' });

				if (parts.Count == 0)
					throw new ArgumentException("expression");

				// Parse into tokens that are either operators, terms or a paren.
				Token prevToken = null;
				int parenCount = 0;

				foreach (string part in parts)
				{
					Token t = null;

					// Because a condition could also be the rvalue of a relation (e.g. State = OR), evaluate as a condition
					// only if it does not follow a relational operator.
					if (prevToken == null || prevToken.Type != TokenType.Relation)
					{
						foreach (KeyValuePair<string, LogicalOperator> pair in logicalOps)
						{
							if (string.Compare(part, pair.Key, true) == 0)
							{
								if (prevToken == null || (prevToken.Type != TokenType.Term && prevToken.Type != TokenType.CloseParen))
									throw new ArgumentException("An operator must be preceded by an expression term or closing paren.", "expression");
								t = new Token(pair.Value);
								break;
							}
						}
					}

					if (t == null)
					{
						foreach (KeyValuePair<string, RelationalOperator> pair in relationalOps)
						{
							if (string.Compare(part, pair.Key, true) == 0)
							{
								if (prevToken == null || prevToken.Type != TokenType.Term)
									throw new ArgumentException("An operator must be preceded by an expression term.", "expression");
								t = new Token(pair.Value);
								break;
							}
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
						else
						{
							if (prevToken != null && prevToken.Type != TokenType.Condition && prevToken.Type != TokenType.Relation && prevToken.Type != TokenType.OpenParen)
								throw new ArgumentException("An expression term must be preceded by an operator or opening paren.", "expression");
						}

						t = new Token(part);
					}

					tokens.Add(t);
					prevToken = t;
				}

				// The expression must end with a term or a closing paren.
				Token last = tokens[tokens.Count - 1];
				if (last.Type != TokenType.Term && last.Type != TokenType.CloseParen)
					throw new ArgumentException("An expression must end in an expression term or a closing paren.", "expression");

				// The expression must contain at least two terms and a relation.
				int terms = 0;
				int relations = 0;
				foreach (Token t in tokens)
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
				List<string> tokens = new List<string>();
				List<char> delims = new List<char>(delimiters);							// delimiters
				List<char> delimTokens = new List<char>(delimitersIncludedAsTokens);	// delimiters which are also tokens
				List<char> quoteChars = new List<char>(quotes);

				int tokenStart = 0;
				int tokenEnd = 0;
				bool inQuote = false;
				char prevQuote = ' ';

				// Remove leading and trailing whitespace.
				expression = expression.Trim();

				for (int i = 0; i < expression.Length; i++)
				{
					char c = expression[i];

					if (i == expression.Length - 1)				// Remainder of string (not ending in a delimiter)
					{
						if (inQuote && c == prevQuote)
							tokens.Add(expression.Substring(tokenStart, i - tokenStart));
						else if (!delims.Contains(c) || delimTokens.Contains(c))
							tokens.Add(expression.Substring(tokenStart));
					}
					else if (quoteChars.Contains(c))			// Quote found
					{
						if (inQuote)
						{
							if (c == prevQuote)
							{
								inQuote = false;

								tokenEnd = i;

								if (tokenEnd > tokenStart)		// Non-empty?
									tokens.Add(expression.Substring(tokenStart, tokenEnd - tokenStart));

								tokenStart = i + 1;				// Start parsing the next token
							}
						}
						else
						{
							inQuote = true;
							prevQuote = c;
							tokenStart = i + 1;					// Start parsing the next token
						}
					}
					else if (!inQuote && delims.Contains(c))	// Delimiter found
					{
						tokenEnd = i;

						if (tokenEnd > tokenStart)				// Non-empty?
							tokens.Add(expression.Substring(tokenStart, tokenEnd - tokenStart));

						if (delimTokens.Contains(c))			// If the delimiter is also a token, add it to the token list
							tokens.Add(new string(c, 1));

						tokenStart = i + 1;						// Start parsing the next token
					}
				}

				// Coalesce adjacent operators that form a multi-character operator (e.g. <>, !=, ==)
				string prevToken = "";
				string[] tokenArray = tokens.ToArray();
				int tokensRemoved = 0;
				for (int j = 0; j < tokenArray.Length ; j++)
				{
					string token = tokenArray[j];
					string compoundToken = prevToken + token;
					if (multiCharRelationalOps.Contains(compoundToken))
					{
						int newPosition = j - 1 - tokensRemoved;
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
			System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return ((System.Collections.IEnumerable)tokens).GetEnumerator();
			}
			#endregion
		}
		#endregion

		private LogicalOperator op;
		private RelationalExpression term;
		private FilterNode left;
		private FilterNode right;
		private bool? evaluated;

		public bool? Evaluated
		{
			get { return this.evaluated; }
		}
		public FilterNode Left
		{
			get { return this.left; }
		}
		public LogicalOperator Operator
		{
			get { return this.op; }
		}
		public FilterNode Right
		{
			get { return this.right; }
		}
		public RelationalExpression Term
		{
			get { return this.term; }
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
			List<Token> tokens = new List<Token>(new Tokenizer(expression));

			// Combine terms and relational operators into expressions.
			while (true)
			{
				int evaluationIndex = -1;
				for (int i = 0; i < tokens.Count; i++)
				{
					if (tokens[i].Type == TokenType.Relation)
					{
						evaluationIndex = i;
						break;
					}
				}

				if (evaluationIndex > -1)
				{
					RelationalExpression expr = new RelationalExpression(tokens[evaluationIndex - 1].Term,
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
			Dictionary<LogicalOperator, int> operatorPriorities = new Dictionary<LogicalOperator, int>();
			operatorPriorities.Add(LogicalOperator.Or, 1);
			operatorPriorities.Add(LogicalOperator.And, 2);
			int parenAddedPriority = operatorPriorities.Count;

			while (true)
			{
				int contextPriority = 0;
				int evaluationPriorityMax = -1;
				int evaluationIndex = -1;

				for (int i = 0; i < tokens.Count; i++)
				{
					TokenType type = tokens[i].Type;

					if (type == TokenType.Condition)
					{
						int evaluationPriority = operatorPriorities[tokens[i].Condition] + contextPriority;
						if (evaluationPriority > evaluationPriorityMax)
						{
							evaluationIndex = i;
							evaluationPriorityMax = evaluationPriority;
						}
					}
					else if (type == TokenType.OpenParen)
					{
						contextPriority += parenAddedPriority;
					}
					else if (type == TokenType.CloseParen)
					{
						contextPriority -= parenAddedPriority;
					}
				}

				if (evaluationIndex > -1)
				{
					Token prevToken = tokens[evaluationIndex - 1];
					Token nextToken = tokens[evaluationIndex + 1];

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

					FilterNode node = new FilterNode(nodeLeft, nodeRight, tokens[evaluationIndex].Condition);

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
			FilterNode current = this;
			Stack<FilterNode> nodes = new Stack<FilterNode>();

			while (true)
			{
				// A terminal expression?
				if (current.op == LogicalOperator.None)
				{
					current.evaluated = evaluator(current);
				}
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
			foreach (FilterNode node in this)
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
			return ((IEnumerable<FilterNode>)this).GetEnumerator();
		}
		#endregion
	}

	internal delegate bool ExpressionEvaluator(FilterNode expression);
}
