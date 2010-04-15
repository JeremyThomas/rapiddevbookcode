using System;

namespace JesseJohnston
{
	internal class RelationalExpression
	{
		private string prop;
		private string value;
		private RelationalOperator op;

		public RelationalOperator Operator
		{
			get { return this.op; }
		}
		public string PropertyName
		{
			get { return this.prop; }
		}
		public string Value
		{
			get { return this.value; }
		}

		public RelationalExpression(string prop, string value, RelationalOperator op)
		{
			if (prop == null)
				throw new ArgumentNullException("prop");
			if (prop == "")
				throw new ArgumentException("prop");
			if (value == null)
				throw new ArgumentNullException("value");
			if (op == RelationalOperator.None)
				throw new ArgumentException("op");

			this.prop = prop;
			this.value = value;
			this.op = op;
		}
	}
}
