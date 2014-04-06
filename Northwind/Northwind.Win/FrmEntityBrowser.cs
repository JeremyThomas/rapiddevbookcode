using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.DAL.Linq;
using Northwind.DAL.SqlServer;

namespace Northwind.Win
{
  public partial class FrmEntityBrowser : Form
  {
    public FrmEntityBrowser()
    {
      InitializeComponent();
      usrCntrlEntityBrowser1.Initialize(new LinqMetaData(new DataAccessAdapter()));
    }
  }
}
