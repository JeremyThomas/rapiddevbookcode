using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

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
      return from type in ancestorType.Assembly.GetExportedTypes()
             where type.IsPublic && !type.IsAbstract && type.IsSubclassOf(ancestorType)
             select type;
    }

    /// <summary>
    /// Gets the browsable properties of a type.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <returns>The browsable properties.</returns>
    public static IEnumerable<PropertyInfo> GetBrowsableProperties(Type type)
    {
      return from properties in type.GetProperties()
             let browsableAtt = properties.GetCustomAttributes(typeof(BrowsableAttribute), true).FirstOrDefault() as BrowsableAttribute
             where browsableAtt == null || browsableAtt.Browsable
             select properties;
    }

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