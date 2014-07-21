using System;
using System.Collections.Generic;
using System.Text;

using SD.LLBLGen.Pro.ApplicationCore;
using SD.LLBLGen.Pro.ApplicationCore.Entities;
using SD.LLBLGen.Pro.ApplicationCore.StoredProcedures;
using SD.LLBLGen.Pro.ApplicationCore.TypedLists;
using SD.LLBLGen.Pro.ApplicationCore.TypedViews;


namespace WB.LLBLGen.Pro.Plugins
{
  /// <summary>
  /// Plug-in for refreshing Custom Properties with data retrieved from the schema after a refresh. 
  /// Creator: Wayne Brantley
  /// Original: http://www.llblgen.com/pages/secure/ListDownloads.aspx?ProductVersion=4
  /// </summary>
  public class RefreshCustomProperties : PluginBase
  {
    private RefreshCustomPropertiesControl _control = null;
    private const string _version = "1.0.0.1";
    private const string _build = "02032009";


    /// <summary>
    /// Initializes a new instance of the RefreshCustomProperties class.
    /// </summary>
    public RefreshCustomProperties()
    {
    }

    /// <summary>
    /// Gets the configuration control for this plugin
    /// </summary>
    /// <returns></returns>
    public override System.Windows.Forms.Control GetConfigurationControl()
    {
      if (_control == null)
        _control = new RefreshCustomPropertiesControl();
      return _control;
    }

    /// <summary>
    /// Describes this plugin.
    /// </summary>
    /// <returns></returns>
    public override PluginDescription Describe()
    {
      PluginDescription toReturn = base.Describe();

      toReturn.Build = _build;
      toReturn.Description = "General plug-in to refresh custom properties from the project meta-data. These are only done when the entity is first added - so this allows you to refresh them.";
      toReturn.Id = new Guid("{58541101-730E-44f9-B188-60AEAEA81399}");
      toReturn.Name = "Refresh Custom Properties Plug-in";
      toReturn.ShowProgressViewerDuringExecution = true;
      toReturn.TargetType = PluginTargetType.ActionSPCall | PluginTargetType.Entity | PluginTargetType.Project | PluginTargetType.RetrievalSPCall | PluginTargetType.TypedList | PluginTargetType.TypedView;
      toReturn.TypeOfPlugin = PluginType.SingleAndMultiElementPlugin;
      toReturn.Vendor = "Wayne Brantley, Jeremy Thomas";
      toReturn.Version = _version;

      return toReturn;
    }

    public override void Execute()
    {
      // 4 main tasks: entity
      base.ProgressTaskInit(5);

      base.ProgressTaskStart("Processing entities");
      base.ProgressSubtaskInit(base.Entities.Count);
      foreach (EntityDefinition entity in base.Entities)
      {
        bool entityChanged = false;
        base.ProgressSubtaskStart("Processing entity: " + entity.Name);
        if (UpdatePropertiesFromHashTable(entity.CustomProperties, entity.Target.CustomProperties))//JT
          entityChanged = true;// process all fields in the entity.
        foreach (EntityFieldDefinition field in entity.Fields)
        {
          if (UpdatePropertiesFromHashTable(field.CustomProperties, field.MappedField.CustomProperties))
            entityChanged = true;
          //                    object hashKeyValue;
          //                    foreach (string customItemKey in field.MappedField.CustomProperties.Keys)
          //                    {
          //                        hashKeyValue = field.MappedField.CustomProperties[customItemKey];
          //                        if (UpdateCustomProperty(field.CustomProperties, hashKeyValue, customItemKey))
          //                            entityChanged = true;
          //                    }
        }

        base.ProgressSubtaskComplete();
        if (entityChanged)
        {
          entity.MarkEntityDefinitionAsChanged(ObjectChangeType.EntityFields);
          entity.MarkEntityDefinitionRequiresRedraw(ObjectChangeType.EntityFields);
        }
      }
      base.ProgressTaskComplete();

      if (_control.MapFieldPropertiesForTypedList)
      {
        base.ProgressTaskStart("Processing typed lists");
        base.ProgressSubtaskInit(base.TypedLists.Count);
        foreach (TypedListDefinition typedList in base.TypedLists)
        {
          base.ProgressSubtaskStart("Processing typed list: " + typedList.Name);
          foreach (TypedListFieldDefinition field in typedList.Fields)
          {
            bool listUpdated = false;
            if (UpdatePropertiesFromHashTable(field.CustomProperties, field.Field.MappedField.CustomProperties))
              listUpdated = true;

            if (listUpdated)
            {
              typedList.MarkTypedListDefinitionAsChanged(ObjectChangeType.TypedListCustomProperties);
              typedList.MarkTypedListRequiresRedraw(ObjectChangeType.TypedListCustomProperties);
            }
          }
        }
      }
      base.ProgressTaskComplete();


      base.ProgressTaskStart("Processing views");
      base.ProgressSubtaskInit(base.TypedViews.Count);
      foreach (TypedViewDefinition typedView in base.TypedViews)
      {
        bool viewUpdated = false;
        base.ProgressSubtaskStart("Processing typed view: " + typedView.Name);
        if (UpdatePropertiesFromHashTable(typedView.CustomProperties, typedView.TargetView.CustomProperties))

          if (viewUpdated)
          {
            typedView.MarkTypedViewRequiresRedraw(ObjectChangeType.TypedViewCustomProperties);
            typedView.MarkTypedViewDefinitionAsChanged(ObjectChangeType.TypedViewCustomProperties);
          }
      }
      base.ProgressTaskComplete();


      base.ProgressTaskStart("Processing retrieval procs");
      base.ProgressSubtaskInit(base.RetrievalSPCalls.Count);
      foreach (SPCallDefinition callDef in base.RetrievalSPCalls)
      {
        base.ProgressSubtaskStart("Processing proc: " + callDef.Name);
        if (UpdatePropertiesFromHashTable(callDef.CustomProperties, callDef.TargetStoredProcedure.CustomProperties))
          callDef.IsChanged = true;
      }
      base.ProgressTaskComplete();

      base.ProgressTaskStart("Processing action procs");
      base.ProgressSubtaskInit(base.ActionSPCalls.Count);
      foreach (SPCallDefinition callDef in base.ActionSPCalls)
      {
        base.ProgressSubtaskStart("Processing proc: " + callDef.Name);
        if (UpdatePropertiesFromHashTable(callDef.CustomProperties, callDef.TargetStoredProcedure.CustomProperties))
          callDef.IsChanged = true;

      }
      base.ProgressTaskComplete();

    }

    private bool UpdateCustomProperty(CustomProperties customProperties, object hashKeyValue, string customItemKey)
    {
      if (_control.IgnoreMSDesignerInformation && customItemKey.IndexOf("MS_", StringComparison.OrdinalIgnoreCase) != -1)
        if (string.Compare(customItemKey, "MS_Description", true) != 0)
          return false;
      if (customProperties.ContainsKey(customItemKey))
      {
        if (customProperties[customItemKey] == hashKeyValue)
          return false;
        customProperties[customItemKey] = hashKeyValue;
      }
      else
      {
        customProperties.Add(customItemKey, hashKeyValue);
      }
      return true;
    }

    private bool UpdatePropertiesFromHashTable(CustomProperties customProperties, System.Collections.Hashtable customHashTable)
    {
      object hashKeyValue;
      bool entityChanged = false;
      foreach (string customItemKey in customHashTable.Keys)
      {
        hashKeyValue = customHashTable[customItemKey];
        if (UpdateCustomProperty(customProperties, hashKeyValue, customItemKey))
          entityChanged = true;
      }
      return entityChanged;
    }


  }
}