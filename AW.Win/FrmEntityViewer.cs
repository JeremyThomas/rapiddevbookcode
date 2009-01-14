using System;
using System.Linq;
using System.Windows.Forms;
using AW.Win.Properties;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Win
{
  public partial class FrmEntityViewer : Form
  {
    public FrmEntityViewer()
    {
      InitializeComponent();
      //dataGridViewFields.AutoGenerateColumns = true;
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.EntityViewerSizeLocation);
    }

    public FrmEntityViewer(IEntity entity) : this()
    {
      if (entity == null) throw new ArgumentNullException("entity");
      propertyGrid1.SelectedObject = entity;
      //entityFieldsBindingSource.DataSource = entity.Fields.OfType<EntityField>();
      entityFieldBindingSource.DataSource = entity.Fields.OfType<object>();

    }

    private void FrmEntityViewer_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.EntityViewerSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
      Settings.Default.EntityFieldColumns = AWHelper.SaveColumnState(dataGridViewFields);
    }

    private void FrmEntityViewer_Load(object sender, EventArgs e)
    {
      propertyGrid1.RefreshSelectedObject();
      AWHelper.RestoreColumnsState(Settings.Default.EntityFieldColumns, dataGridViewFields);
    }
  }
}