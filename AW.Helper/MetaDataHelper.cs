﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AW.Helper
{
  public static class MetaDataHelper
  {
    /// <summary>
    /// Gets the public concrete descendance of a type.
    /// </summary>
    /// <param name="ancestorType">Type of the ancestor.</param>
    /// <returns>the descendance.</returns>
    public static IEnumerable<Type> GetDescendance(Type ancestorType)
    {
      return GetDescendance(ancestorType, ancestorType.Assembly.GetExportedTypes());
    }

    public static IEnumerable<Type> GetAllLoadedDescendance(Type ancestorType)
    {
      return GetDescendance(ancestorType, GetAllExportedTypes());
    }

    /// <summary>
    /// Gets all exported types in the Current Domain.
    /// </summary>
    /// <returns>All exported types in the Current Domain.</returns>
    private static IEnumerable<Type> GetAllExportedTypes()
    {
      return from assemby in AppDomain.CurrentDomain.GetAssemblies()
             from exportedType in assemby.GetExportedTypes()
             select exportedType;
    }

    public static IEnumerable<Type> GetDescendance(Type ancestorType, IEnumerable<Type> exportedTypes)
    {
      return from type in exportedTypes
             where type.IsPublic && !type.IsAbstract && type.IsSubclassOf(ancestorType)
             select type;
    }

		public static Type GetTypeParameterOfGenericType(Type type)
		{
			if (type == typeof(object))
			return null;
			return type.IsGenericType ? type.GetGenericArguments().First() : GetTypeParameterOfGenericType(type.BaseType);
		}

    /// <summary>
    /// Gets the properties to display in LINQPad's Dump method. They should be the same as would appear in a DataGridView with AutoGenerateColumns.
    /// </summary>
    /// <remarks>Where clause copied from DataGridViewDataConnection.GetCollectionOfBoundDataGridViewColumns()</remarks>
    /// <returns>The properties to display in LINQPad's Dump</returns>
    public static IEnumerable<PropertyDescriptor> GetPropertiesToDisplay(Type type)
    {
      return from propertyDescriptor in ListBindingHelper.GetListItemProperties(type).Cast<PropertyDescriptor>()
             where (!typeof (IList).IsAssignableFrom(propertyDescriptor.PropertyType) || TypeDescriptor.GetConverter(typeof (Image)).CanConvertFrom(propertyDescriptor.PropertyType))
             select propertyDescriptor;
    }

    /// <summary>
    /// Adds the associated metadata providers for each type.
    /// </summary>
    /// <see cref="http://blogs.msdn.com/davidebb/archive/2009/07/24/using-an-associated-metadata-class-outside-dynamic-data.aspx"/>
    /// <param name="typesWhichMayHaveBuddyClasses">The types which may have buddy classes.</param>
    public static void AddAssociatedMetadataProviders(IEnumerable<Type> typesWhichMayHaveBuddyClasses)
    {
      foreach (var typeWithBuddyClass in typesWhichMayHaveBuddyClasses)
        TypeDescriptor.AddProvider(new AssociatedMetadataTypeTypeDescriptionProvider(typeWithBuddyClass), typeWithBuddyClass);
    }

    /// <summary>
    /// Gets the property descriptors for a class including those in any MetadataClass(buddy class).
    /// </summary>
    /// <param name="modelClass">The model class.</param>
    /// <returns>The property descriptors for a class including those in any MetadataClass.</returns>
    public static IEnumerable<PropertyDescriptor> GetPropertyDescriptors(Type modelClass)
    {     
      var modelClassProperties = TypeDescriptor.GetProperties(modelClass).Cast<PropertyDescriptor>();
      if (TypeDescriptor.GetProvider(modelClass) is AssociatedMetadataTypeTypeDescriptionProvider)
        return modelClassProperties; //No need to get the MetadataType(buddy class)
      var metadataAttrib = modelClass.GetCustomAttributes(typeof (MetadataTypeAttribute), true).OfType<MetadataTypeAttribute>().FirstOrDefault();
      return metadataAttrib == null ? modelClassProperties : modelClassProperties.Union(TypeDescriptor.GetProperties(metadataAttrib.MetadataClassType).Cast<PropertyDescriptor>());
    }

    /// <summary>
    /// Gets the attributes from a collection of properties for a particular property name.
    /// </summary>
    /// <param name="properties">The properties.</param>
    /// <param name="fieldName">Name of the field.</param>
    /// <returns>The validation attributes.</returns>
    public static IEnumerable<Attribute> GetAttributes(IEnumerable<PropertyDescriptor> properties, string fieldName)
    {
      return properties.Where(p => p.Name == fieldName).SelectMany(prop => prop.Attributes.Cast<Attribute>());
    }

    /// <summary>
    /// Gets the validation attributes from a collection of properties for a particular property name.
    /// </summary>
    /// <param name="properties">The properties.</param>
    /// <param name="fieldName">Name of the field.</param>
    /// <returns>The validation attributes.</returns>
    public static IEnumerable<ValidationAttribute> GetValidationAttributes(IEnumerable<PropertyDescriptor> properties, string fieldName)
    {
      return GetAttributes(properties, fieldName).OfType<ValidationAttribute>();
    }

    /// <summary>
    /// Gets the validation attributes of a type of entity.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <param name="fieldName">Name of the field.</param>
    /// <returns>The validation attributes.</returns>
    public static IEnumerable<ValidationAttribute> GetValidationAttributes(Type type, string fieldName)
    {
      return GetValidationAttributes(GetPropertyDescriptors(type), fieldName);
    }

    /// <summary>
    /// Gets the validation attributes of a type of entity if there is a MetaModel defined.
    /// </summary>
    /// <param name="metaModel">The meta model.</param>
    /// <param name="entityType">Type of the entity.</param>
    /// <param name="fieldName">Name of the field.</param>
    /// <returns>The validation attributes.</returns>
    /// <example>var model = new MetaModel();
    /// model.RegisterContext(new LLBLGenProDataModelProvider(typeof (EntityType), MetaData, new ElementCreator()));</example>
    //public static IEnumerable<ValidationAttribute> GetValidationAttributes(System.Web.DynamicData.MetaModel metaModel, Type entityType, string fieldName)
    //{
    //  return metaModel.GetTable(entityType).GetColumn(fieldName).Attributes.OfType<ValidationAttribute>();
    //}
  }
}

namespace LINQPad
{
  /// <summary>
  ///  To control what fields/properties of custom types are displayed via LINQPad's Dump method implement this interface
  /// </summary>
  /// <see cref="http://www.linqpad.net/FAQ.aspx"/>
  public interface ICustomMemberProvider
  {
    // Each of these methods must return a sequence
    // with the same number of elements:
    IEnumerable<string> GetNames();
    IEnumerable<Type> GetTypes();
    IEnumerable<object> GetValues();
  }
}