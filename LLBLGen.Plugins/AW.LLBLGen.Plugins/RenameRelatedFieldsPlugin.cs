using System;
using System.Windows.Forms;
using SD.LLBLGen.Pro.ApplicationCore;
using SD.LLBLGen.Pro.ApplicationCore.Entities;

namespace AW.LLBLGen.Plugins
{
  /// <summary>
  /// http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=15362
  /// </summary>
  public class RenameRelatedFieldsPlugin: PluginBase
  {
    public const string Description = "Plug-in to rename related fields based on the related entity name. Useful if you change the name of an entity and want the fields of related entities to change as well.";
    private const string Version = "1.0.0.0";
    private const string Build = "02032009";
    public const string PluginName = "Rename related fields based on the related entity name";
    private const string Vendor = "AW: Jeremy Thomas"; 

    #region Overrides of PluginBase

    public override void Execute()
    {
      var manyToManySeperator = ProjectToTarget.FieldMappedOnManyToManyPattern.Split('{', '}')[2]; //Brittle
      ProgressTaskInit(Entities.Count);
      foreach (EntityDefinition entity in Entities)
      {
        ProgressTaskStart("Processing entity: " + entity.Name);
        foreach (EntityRelation relation in entity.Relations)
        {
          var entityChanged = false;
          var intermediateName = string.Empty;
          if (relation.RelationType == EntityRelationType.ManyToMany)
            intermediateName = relation.FullDescription.Substring(relation.FullDescription.IndexOf("via ") + 4).Trim(')'); //Brittle
          if (!relation.UtilizingPropertyName.Contains(relation.RelationEndPoint.Name) || !relation.UtilizingPropertyName.Contains(intermediateName))
            //Condition will pass when it shouldn't if the new entity name is a subset of the old i.e. the name is shortened
          {
            var oldPropertyName = relation.UtilizingPropertyName;
            string newPropertyName;
            switch (relation.RelationType)
            {
              case EntityRelationType.OneToMany:
                newPropertyName = Inflector.Pluralize(relation.RelationEndPoint.Name);
                break;
              case EntityRelationType.ManyToOne:
                newPropertyName = relation.RelationEndPoint.Name;
                break;
              case EntityRelationType.ManyToMany:
                newPropertyName = relation.RelationEndName + manyToManySeperator + intermediateName;
                break;
              default:
                newPropertyName = oldPropertyName;
                break;
            }

            if (relation.UtilizingPropertyName != newPropertyName)
            {
              relation.UtilizingPropertyName = newPropertyName;
              base.LogLineToApplicationOutput(string.Format("Related field '{0}' of entity '{1}' has been changed to '{2}' ", oldPropertyName, entity.Name, newPropertyName), "RenameRelatedFieldsPlugin", false, true);
              entityChanged = true;
            }
          }
          if (entityChanged)
          {
            entity.MarkEntityDefinitionAsChanged(ObjectChangeType.EntityFields);
            entity.MarkEntityDefinitionRequiresRedraw(ObjectChangeType.EntityFields);
          }
        }
        ProgressTaskComplete();
      }      
    }

    public override PluginDescription Describe()
    {
      var toReturn = base.Describe();

      toReturn.Description = Description;
      toReturn.Id = new Guid("{04316D75-2286-4afd-A193-6DF2B59048C1}");
      toReturn.Name = PluginName;
      toReturn.ShowProgressViewerDuringExecution = true;
      toReturn.TargetType = PluginTargetType.Entity | PluginTargetType.Project;
      toReturn.TypeOfPlugin = PluginType.SingleAndMultiElementPlugin;
      toReturn.Vendor = Vendor;
      toReturn.Build = Build;
      toReturn.Version = Version;
      return toReturn;
    }
    
    /// <summary>
    /// Gets the configuration control.
    /// </summary>
    /// <returns></returns>
    public override Control GetConfigurationControl()
    {
      return new RenameRelatedFieldsControl();
    }

    #endregion
  }
}