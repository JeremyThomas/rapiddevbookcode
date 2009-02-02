using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AW.Data.EntityClasses;
using href.Controls.Properties;
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
      dataGridViewEnumerable.AutoGenerateColumns = true;
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.EntityViewerSizeLocation);
      if (CommonEntityBaseTypeDescriptionProvider == null)
      {
        CommonEntityBaseTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(typeof (object));
        TypeDescriptor.AddProvider(CommonEntityBaseTypeDescriptionProvider, typeof (object));
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
      if (e.NewSelection.Value != null && !(e.OldSelection == null && dataGridViewEnumerable.DataSource == propertyGrid1.SelectedObject))
        if (!(e.NewSelection.Value is string))
          if (e.NewSelection.Value is IEnumerable)
          {
            var enumerable = (IEnumerable) e.NewSelection.Value;
            bindingSourceEnumerable.DataSource = enumerable.AsQueryable();
          }
          else if (!e.NewSelection.PropertyDescriptor.PropertyType.IsValueType)
            bindingSourceEnumerable.DataSource = e.NewSelection.Value;
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
      bindingSourceEnumerable.DataSource = propertyGrid1.SelectedObject;
      if (propertyGrid1.SelectedObject is IEntity)
      {
        entityFieldBindingSource.DataSource = ((IEntity) propertyGrid1.SelectedObject).Fields.AsQueryable();
      }
    }
  }
}