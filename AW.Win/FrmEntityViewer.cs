using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
//using JesseJohnston;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Win
{
  public partial class FrmEntityViewer : Form
  {
    public FrmEntityViewer()
    {
      InitializeComponent();
      dataGridView1.AutoGenerateColumns = true;
    }

    public FrmEntityViewer(IEntity entity):this()
    {
      if (entity == null) throw new ArgumentNullException("entity");
      propertyGrid1.SelectedObject = entity;
      //entityFieldsBindingSource.DataSource = entity.Fields.OfType<EntityField>();
      entityFieldsBindingSource.DataSource = entity.Fields.OfType<object>();
    }
    
  }
}
