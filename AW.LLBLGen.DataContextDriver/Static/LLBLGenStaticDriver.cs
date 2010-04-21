﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using LINQPad;
using LINQPad.Extensibility.DataContext;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.LLBLGen.DataContextDriver.Static
{
  /// <summary>
  /// This static driver let users query any data source that looks like a Data Context - in other words,
  /// that exposes properties of type IEnumerable of T.
  /// </summary>
  public class LLBLGenStaticDriver : StaticDataContextDriver
  {
    #region Overrides of DataContextDriver

    public override string Name
    {
      get { return "AW LLBL Driver"; }
    }

    public override string Author
    {
      get { return "Jeremy Thomas"; }
    }

    public override string GetConnectionDescription(IConnectionInfo cxInfo)
    {
      // For static drivers, we can use the description of the custom type & its assembly:
      return cxInfo.CustomTypeInfo.CustomTypeName + " - " + Name + " - " + cxInfo.DatabaseInfo.CustomCxString;
    }

    public override bool ShowConnectionDialog(IConnectionInfo cxInfo, bool isNewConnection)
    {
      // Prompt the user for a custom assembly and type name:
      return new ConnectionDialog(cxInfo).ShowDialog() == true;
    }

    public override void InitializeContext(IConnectionInfo cxInfo, object context, QueryExecutionManager executionManager)
    {
      //SD.LLBLGen.Pro.ORMSupportClasses. HelperClasses DbUtils.ActualConnectionString
      // var assembly = Assembly.GetAssembly(context.GetType());
      var assembly = Assembly.LoadFile(cxInfo.CustomTypeInfo.CustomAssemblyPath);
      var type = assembly.GetType("AW.Data.HelperClasses.DbUtils");
      if (type == null)
      {
         var dataAccessAdapterAssembly = Assembly.LoadFile(cxInfo.CustomTypeInfo.CustomMetadataPath);
        var types = dataAccessAdapterAssembly.GetTypes();
      }
      else
      {
       var actualConnectionString = type.GetField("ActualConnectionString");
        actualConnectionString.SetValue(context, cxInfo.DatabaseInfo.CustomCxString);
        var x = actualConnectionString.GetValue(context);
      }
    }

    public override List<ExplorerItem> GetSchema(IConnectionInfo cxInfo, Type customType)
    {
      // Return the objects with which to populate the Schema Explorer by reflecting over customType.

      // We'll start by retrieving all the properties of the custom type that implement IEnumerable<T>:
      var topLevelProps =
        (
          from prop in customType.GetProperties()
          where prop.PropertyType != typeof (string)
          // Display all properties of type IEnumerable<T> (except for string!)
          let ienumerableOfT = prop.PropertyType.GetInterface("System.Collections.Generic.IEnumerable`1")
          where ienumerableOfT != null
          orderby prop.Name
          select new ExplorerItem(prop.Name, ExplorerItemKind.QueryableObject, ExplorerIcon.Table)
                   {
                     IsEnumerable = true,
                     ToolTipText = FormatTypeName(prop.PropertyType, false),
                     // Store the entity type to the Tag property. We'll use it later.
                     Tag = ienumerableOfT.GetGenericArguments()[0]
                   }
        ).ToList();

      // Create a lookup keying each element type to the properties of that type. This will allow
      // us to build hyperlink targets allowing the user to click between associations:
      var elementTypeLookup = topLevelProps.ToLookup(tp => (Type) tp.Tag);

      // Populate the columns (properties) of each entity:
      foreach (var table in topLevelProps)
        table.Children = GetPropertiesToShowInSchema((Type) table.Tag)
          .Select(childProp => GetChildItem(elementTypeLookup, childProp))
          .OrderBy(childItem => childItem.Kind)
          .ToList();

      return topLevelProps;
    }

    public override IEnumerable<string> GetAssembliesToAdd()
    {
      return new[]
               {
                 "SD.LLBLGen.Pro.LinqSupportClasses.NET35.dll", "SD.LLBLGen.Pro.ORMSupportClasses.NET20.dll", "AW.Helper.dll",
                 "AW.Winforms.Helpers.dll", "System.Windows.Forms.dll", "AW.Helper.LLBL.dll", "AW.Winforms.Helpers.LLBL.dll"
               };
    }


    public override IEnumerable<string> GetNamespacesToAdd()
    {
      return new[]
               {
                 "SD.LLBLGen.Pro.ORMSupportClasses", "AW.Helper", "AW.Helper.LLBL",
                 "AW.Winforms.Helpers.DataEditor", "AW.Winforms.Helpers.LLBL"
               };
    }

    public override IEnumerable<string> GetNamespacesToRemove()
    {
      return new[] {"System.Data.Linq"};
    }

    /// <summary>
    /// Gets the custom display member provider.
    /// </summary>
    /// <param name="objectToWrite">The object to write.</param>
    /// <returns></returns>
    public override ICustomMemberProvider GetCustomDisplayMemberProvider(object objectToWrite)
    {
      return LLBLMemberProvider.IsEntityOrEntities(objectToWrite) ? new LLBLMemberProvider(objectToWrite) : null;
    }

    #endregion

    /// <summary>
    /// Gets the properties to show in schema. 
    /// They should be all the browsable properties with the addition of selfservicing entity properties.
    /// </summary>
    /// <remarks>See MetaDataHelper.GetPropertiesToDisplay</remarks>
    /// <param name="type">The type.</param>
    /// <returns></returns>
    private static IEnumerable<PropertyDescriptor> GetPropertiesToShowInSchema(Type type)
    {
      return ListBindingHelper.GetListItemProperties(type).Cast<PropertyDescriptor>().Union(GetPropertiesOfTypeEntity(type));
    }

    /// <summary>
    /// Gets the properties of type entity since for selfservicing these properties are not browsable so they need to be handled as a special case.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <returns></returns>
    private static IEnumerable<PropertyDescriptor> GetPropertiesOfTypeEntity(Type type)
    {
      return from propertyDescriptor in TypeDescriptor.GetProperties(type, null).Cast<PropertyDescriptor>()
             where typeof (IEntity).IsAssignableFrom(propertyDescriptor.PropertyType)
             select propertyDescriptor;
    }

    private static ExplorerItem GetChildItem(ILookup<Type, ExplorerItem> elementTypeLookup, PropertyDescriptor childProp)
    {
      // If the property's type is in our list of entities, then it's a Many:1 (or 1:1) reference.
      // We'll assume it's a Many:1 (we can't reliably identify 1:1s purely from reflection).
      if (elementTypeLookup.Contains(childProp.PropertyType))
        return new ExplorerItem(childProp.Name, ExplorerItemKind.ReferenceLink, ExplorerIcon.ManyToOne)
                 {
                   HyperlinkTarget = elementTypeLookup[childProp.PropertyType].First(),
                   // FormatTypeName is a helper method that returns a nicely formatted type name.
                   ToolTipText = FormatTypeName(childProp.PropertyType, true)
                 };

      // Is the property's type a collection of entities?
      var ienumerableOfT = childProp.PropertyType.GetInterface("System.Collections.Generic.IEnumerable`1");
      if (ienumerableOfT != null)
      {
        var elementType = ienumerableOfT.GetGenericArguments()[0];
        if (elementTypeLookup.Contains(elementType))
          return new ExplorerItem(childProp.Name, ExplorerItemKind.CollectionLink, ExplorerIcon.OneToMany)
                   {
                     HyperlinkTarget = elementTypeLookup[elementType].First(),
                     ToolTipText = FormatTypeName(elementType, true)
                   };
      }

      // Ordinary property:
      return new ExplorerItem(childProp.Name + " (" + FormatTypeName(childProp.PropertyType, false) + ")",
                              ExplorerItemKind.Property, ExplorerIcon.Column);
    }
  }
}