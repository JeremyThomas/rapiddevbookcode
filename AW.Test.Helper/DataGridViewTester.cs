using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms.Testers
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
