using System;
using System.Windows.Forms;
using SD.LLBLGen.Pro.ApplicationCore;
using SD.LLBLGen.Pro.ApplicationCore.Extensibility;

namespace AW.LLBLGen.Plugins
{
	/// <summary>
	///   http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=15362
	/// </summary>
	public class RenameRelatedFieldsPlugin : PluginBase
	{
		public const string Description = "Plug-in to rename related fields based on the related entity name. " +
		                                  "Useful if you change the name of an entity and want the fields of related entities to change as well.";
		private const string Version = "4.2.0.0";
		private const string Build = "29102018";
		public const string PluginName = "Rename related fields based on the related entity name";
		private const string Vendor = "AW: Jeremy Thomas";

		#region Overrides of PluginBase

		/// <summary>
		/// This last worked in V3 needs updating for v4 and beyond
		/// </summary>
		public override void Execute()
		{
			ProgressTaskInit(Entities.Count);
			var manyToManySeparator = ProjectToTarget.Properties.FieldMappedOntoRelatedFieldPattern.Split('{', '}')[2]; // FieldMappedOnManyToManyPattern
			foreach (var entity in Entities)
			{
				ProgressTaskStart("Processing entity: " + entity.Name);

				foreach (var fieldElementCore in entity.GetAllFieldsInElement(false))

				foreach (var relation in entity.GetAllRelationshipsContainingFkField(fieldElementCore))
				{
					// var entityChanged = false;
					var oldPropertyName = relation.NavigatorFkSide;
					//   var newPropertyName = GeneralUtils. CreateUtilizingPropertyName(relation, ProjectToTarget.Properties);
					var intermediateName = string.Empty;
					if (relation.RelationshipType == EntityRelationshipType.ManyToMany)
						intermediateName = relation.FullDescription.Substring(relation.FullDescription.IndexOf("via ", StringComparison.Ordinal) + 4).Trim(')');
					if (!relation.NavigatorFkSide.Contains(relation.EntityFkSide.Name))
					{
						string newPropertyName = null;
						switch (relation.RelationshipType)
						{
							case EntityRelationshipType.OneToOne:
								break;
							case EntityRelationshipType.OneToMany:
								newPropertyName =
									oldPropertyName + "s"; //Inflector.Pluralize(relation.EntityFkSide.Name);
								break;
							case EntityRelationshipType.ManyToMany:
								newPropertyName = relation.EntityFkSide + manyToManySeparator + intermediateName;
								break;
							case EntityRelationshipType.ManyToOne:
								newPropertyName = relation.EntityFkSide.Name;
								break;
							default:
								newPropertyName = oldPropertyName;
								break;
						}
							
						//Make sure 'Setting up pluralization and singularization of names' is done as described here: http://www.llblgen.com/documentation/2.6/hh_start.htm
						//else newPropertyName will be singular
						if (relation.NavigatorFkSide != newPropertyName)
						{
							relation.EndEntityNavigator = newPropertyName;
							base.LogLineToApplicationOutput($"Related field '{oldPropertyName}' of entity '{entity.Name}' has been changed to '{newPropertyName}' ","RenameRelatedFieldsPlugin", false, true);
							// //   entityChanged = true;
						}

						//if (entityChanged)
						//{
						//    entity.MarkEntityDefinitionAsChanged(ObjectChangeType.EntityFields);
						//    entity.MarkEntityDefinitionRequiresRedraw(ObjectChangeType.EntityFields);
						//}
					}

					ProgressTaskComplete();
				}
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
		///   Gets the configuration control.
		/// </summary>
		/// <returns></returns>
		public override Control GetConfigurationControl()
		{
			return new RenameRelatedFieldsControl();
		}

		#endregion
	}
}