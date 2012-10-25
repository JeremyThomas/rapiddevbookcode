using System;
using System.ComponentModel;
using System.Linq;
using System.Web.DynamicData;
using System.Web.UI;
using AW.Helper.LLBL;
using Northwind.DAL.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Dynamic_Data
{
  public partial class ManyToManyField : FieldTemplateUserControl
  {
    protected override void OnDataBinding(EventArgs e)
    {
      base.OnDataBinding(e);

      IEntity2 entity;
      var rowDescriptor = Row as ICustomTypeDescriptor;
      if (rowDescriptor != null)
      {
        // Get the real entity from the wrapper
        entity = rowDescriptor.GetPropertyOwner(null) as IEntity2;
      }
      else
        entity = Row as IEntity2;

      //Get the collection and make sure it's loaded
      if (entity != null)
      {
        var entityCollection = Column.EntityTypeProperty.GetValue(entity, null) as IEntityCollection2;
        if (entityCollection == null)
          throw new InvalidOperationException(String.Format("The ManyToMany template does not support the collection type of the '{0}' column on the '{1}' table.", Column.Name, Table.Name));

        var bucket = EntityHelper.GetRelationInfo(entity, Column.EntityTypeProperty.Name, Column.Table.PrimaryKeyColumns.Select(primaryKeyColumn => primaryKeyColumn.Name));
        using (var dataAccessAdapter = new DataAccessAdapter())   
          dataAccessAdapter.FetchEntityCollection(entityCollection, bucket);

        // Bind the repeater to the list of children entities
        Repeater1.DataSource = entityCollection;
      }
      Repeater1.DataBind();
    }

    public override Control DataControl
    {
      get { return Repeater1; }
    }
  }
}