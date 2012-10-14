using System;
using System.ComponentModel;
using System.Web.DynamicData;
using System.Web.UI;
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
      {
        entity = Row as IEntity2;
      }

      //Get the collection and make sure it's loaded
      if (entity != null)
      {
        var entityCollection = Column.EntityTypeProperty.GetValue(entity, null) as IEntityCollection2;
        if (entityCollection == null)
        {
          throw new InvalidOperationException(String.Format("The ManyToMany template does not support the collection type of the '{0}' column on the '{1}' table.", Column.Name, Table.Name));
        }
        // var llblGenProDataModelProvider = HttpContext.Current.Application[Constants.DataModelProviderKey] as LLBLGenProDataModelProvider;
        // var x = llblGenProDataModelProvider.CreateContext();
        var dataAccessAdapter = new DataAccessAdapter();
        IRelationPredicateBucket bucket = new RelationPredicateBucket();
        bucket.Relations.AddRange(entity.GetRelationsForFieldOfType(Column.EntityTypeProperty.Name));
        foreach (var primaryKeyColumn in Column.Table.PrimaryKeyColumns)
        {
          var entityField2 = entity.Fields[primaryKeyColumn.Name];
          bucket.PredicateExpression.Add(new FieldCompareValuePredicate(entityField2, null, ComparisonOperator.Equal, entityField2.CurrentValue, entity.LLBLGenProEntityName + "__"));
        }

        //(new System.Collections.Generic.Mscorlib_CollectionDebugView<System.Web.DynamicData.MetaColumn>(((System.Web.DynamicData.MetaChildrenColumn)(((System.Web.DynamicData.MetaChildrenColumn)(Column)).ColumnInOtherTable)).ChildTable.PrimaryKeyColumns)).Items[0].DisplayName
        //var y = Column.Table.ForeignKeyColumnsNames;
        //var x = (((System.Web.DynamicData.MetaChildrenColumn) (Column)).ColumnInOtherTable).Table.ForeignKeyColumnsNames;
        //var entityField2 = entity.Fields[x];
        //bucket.PredicateExpression.Add(new FieldCompareValuePredicate(entityField2, null, ComparisonOperator.Equal, entityField2.CurrentValue, "CustomerEntity__"));
        dataAccessAdapter.FetchEntityCollection(entityCollection, bucket);
        //if (!entityCollection.IsLoaded) {
        //    entityCollection.Load();
        // }

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