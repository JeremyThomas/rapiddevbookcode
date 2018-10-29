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
		public const string Description = "Plug-in to reset the names of navigators based on the related entity name. " +
		                                  "Useful if you change the name of an entity and want the navigators of related entities to change as well." +
		                                  "only works on the FK navigators of the selected entites";

		private const string Version = "4.2.0.0";
		private const string Build = "29102018";
		public const string PluginName = "Reset navigator names";
		private const string Vendor = "AW: Jeremy Thomas";

		#region Overrides of PluginBase

		/// <summary>
		///   This last worked in V3 needs updating for v4 and beyond
		/// </summary>
		public override void Execute()
		{
			//	ProgressTaskInit(Entities.Count);
			foreach (var entity in Entities)
			{
				ProgressTaskStart("Processing entity: " + entity.Name);

				foreach (var fieldElementCore in entity.GetAllFieldsInElement(false))

				foreach (var relation in entity.GetAllRelationshipsContainingFkField(fieldElementCore))
				{
					ApplicationUtils.CreateNavigatorNames(relation, ProjectToTarget.Properties, out var startNavigator, out var endNavigator);

					if (relation.StartEntityNavigator != startNavigator)
					{
						var oldPropertyName = relation.StartEntityNavigator;
						relation.StartEntityNavigator = startNavigator;
						base.LogLineToApplicationOutput($"Navigator '{oldPropertyName}' of entity '{entity.Name}' has been changed to '{startNavigator}' ", "RenameRelatedFieldsPlugin", false, true);
					}

					if (relation.NavigatorFkSide != startNavigator)
					{
						var oldPropertyName = relation.EndEntityNavigator;
						relation.EndEntityNavigator = endNavigator;
						base.LogLineToApplicationOutput($"Navigator '{oldPropertyName}' of entity '{relation.EntityFkSide.Name}' has been changed to '{endNavigator}' ", "RenameRelatedFieldsPlugin", false, true);
					}

					//		ProgressTaskComplete();
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