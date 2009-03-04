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
    private const string Version = "1.1.0.0";
    private const string Build = "04032009";
    public const string PluginName = "Rename related fields based on the related entity name";
    private const string Vendor = "AW: Jeremy Thomas";

    #region Overrides of PluginBase

    public override void Execute()
    {
      ProgressTaskInit(Entities.Count);
      foreach (EntityDefinition entity in Entities)
      {
        ProgressTaskStart("Processing entity: " + entity.Name);
        foreach (EntityRelation relation in entity.Relations)
        {
          var entityChanged = false;
          var oldPropertyName = relation.UtilizingPropertyName;
          var newPropertyName = GeneralUtils.CreateUtilizingPropertyName(relation, ProjectToTarget.Properties);
          //Make sure 'Setting up pluralization and singularization of names' is done as descibed here: http://www.llblgen.com/documentation/2.6/hh_start.htm
          //else newPropertyName will be singular
          if (relation.UtilizingPropertyName != newPropertyName)
          {
            relation.UtilizingPropertyName = newPropertyName;
            base.LogLineToApplicationOutput(string.Format("Related field '{0}' of entity '{1}' has been changed to '{2}' ", oldPropertyName, entity.Name, newPropertyName), "RenameRelatedFieldsPlugin", false, true);
            entityChanged = true;
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