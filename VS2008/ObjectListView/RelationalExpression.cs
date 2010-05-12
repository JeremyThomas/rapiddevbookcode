using System;

namespace JesseJohnston
{
  internal class RelationalExpression
  {
    private readonly string prop;
    private readonly string value;
    private readonly RelationalOperator op;

    public RelationalOperator Operator
    {
      get { return op; }
    }

    public string PropertyName
    {
      get { return prop; }
    }

    public string Value
    {
      get { return value; }
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