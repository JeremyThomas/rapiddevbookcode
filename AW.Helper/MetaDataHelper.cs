using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AW.Helper
{
  public static class MetaDataHelper
  {
    /// <summary>
    /// Gets the property descriptors for a class including those in any MetadataClass.
    /// </summary>
    /// <param name="modelClass">The model class.</param>
    /// <returns>The property descriptors for a class including those in any MetadataClass.</returns>
    public static IEnumerable<PropertyDescriptor> GetPropertyDescriptors(Type modelClass)
    {
      var metadataAttrib = modelClass.GetCustomAttributes(typeof(MetadataTypeAttribute), true).OfType<MetadataTypeAttribute>().FirstOrDefault();
      var modelClassProperties = TypeDescriptor.GetProperties(modelClass).Cast<PropertyDescriptor>();
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
    /// <param name="entityType">The type of the entity.</param>
    /// <param name="fieldName">Name of the field.</param>
    /// <returns>The validation attributes.</returns>
    public static IEnumerable<ValidationAttribute> GetValidationAttributes(Type entityType, string fieldName)
    {
      return GetValidationAttributes(GetPropertyDescriptors(entityType), fieldName);
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