using System;
using System.ComponentModel;
using System.Web.DynamicData;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW_Dynamic_Data
{
  public partial class ManyToManyField : FieldTemplateUserControl
  {
    protected override void OnDataBinding(EventArgs e)
    {
      base.OnDataBinding(e);

      object entity;
      var rowDescriptor = Row as ICustomTypeDescriptor;
      if (rowDescriptor != null)
      {
        // Get the real entity from the wrapper
        entity = rowDescriptor.GetPropertyOwner(null);
      }
      else
      {
        entity = Row;
      }

      //Get the collection and make sure it's loaded
      var entityCollection = Column.EntityTypeProperty.GetValue(entity, null) as IEntityCollectionCore;
      if (entityCollection == null)
      {
        throw new InvalidOperationException(String.Format("The ManyToMany template does not support the collection type of the '{0}' column on the '{1}' table.", Column.Name, Table.Name));
      }

      // Bind the repeater to the list of children entities
      Repeater1.DataSource = entityCollection;
      Repeater1.DataBind();
    }

    public override Control DataControl
    {
      get { return Repeater1; }
    }
  }
}
