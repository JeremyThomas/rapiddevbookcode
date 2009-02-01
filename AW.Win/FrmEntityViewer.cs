using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Data.EntityClasses;
using AW.Win.Properties;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Win
{
  public partial class FrmEntityViewer : Form
  {
    private static TypeDescriptionProvider CommonEntityBaseTypeDescriptionProvider;
    private static TypeDescriptionProvider EntityFieldsTypeDescriptionProvider; //

    public FrmEntityViewer()
    {
      InitializeComponent();
      dataGridView1.AutoGenerateColumns = true;
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.EntityViewerSizeLocation);
      if (CommonEntityBaseTypeDescriptionProvider == null)
      {
        CommonEntityBaseTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof(CommonEntityBase));
        TypeDescriptor.AddProvider(CommonEntityBaseTypeDescriptionProvider, typeof(CommonEntityBase));
      }

      if (EntityFieldsTypeDescriptionProvider == null)
      {
        EntityFieldsTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof (EntityFields));
       // TypeDescriptor.AddProvider(EntityFieldsTypeDescriptionProvider, typeof(EntityFields));
      }
    }

    public FrmEntityViewer(object entity)
      : this()
    {
      if (entity == null) throw new ArgumentNullException("entity");
      propertyGrid1.SelectedObject = entity;

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

    private void propertyGrid1_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
    {
      var x = e.NewSelection;
      var t = x.PropertyDescriptor;
      if (!(e.OldSelection == null && dataGridView1.DataSource == propertyGrid1.SelectedObject))
        if (e.NewSelection.Value is IEnumerable)
        {
          var enumerable = (IEnumerable) e.NewSelection.Value;
          dataGridView1.DataSource = enumerable;
        }
    }

    private void propertyGrid2_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
    {
      var x = e.NewSelection;
      var t = x.PropertyDescriptor;
    }

    private void selectObjectToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (propertyGrid1.SelectedGridItem.Expandable)
      {
        propertyGrid1.SelectedObject = propertyGrid1.SelectedGridItem.Value;
      }
    }

    private void propertyGrid1_SelectedObjectsChanged(object sender, EventArgs e)
    {
      dataGridView1.DataSource = propertyGrid1.SelectedObject;
      if (propertyGrid1.SelectedObject is IEntity)
      {
        entityFieldBindingSource.DataSource = ((IEntity)propertyGrid1.SelectedObject).Fields.AsQueryable() ;
        dataGridView1.DataSource = ((IEntity)propertyGrid1.SelectedObject).Fields.OfType<EntityField>();
      }
    }
    }
  }