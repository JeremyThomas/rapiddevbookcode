using System.Windows.Forms;
using NUnit.Extensions.Forms;

namespace AW.Test.Helpers
{
  public class DataGridViewTester : ControlTester<DataGridView, DataGridViewTester>
  {
    public DataGridViewTester()
    {
    }

    public DataGridViewTester(string name, string formName) : base(name, formName)
    {
    }

    public DataGridViewTester(string name, Form form) : base(name, form)
    {
    }

    public DataGridViewTester(string name) : base(name)
    {
    }

    public DataGridViewTester(ControlTester<DataGridView, DataGridViewTester> tester, int index) : base(tester, index)
    {
    }
  }
}