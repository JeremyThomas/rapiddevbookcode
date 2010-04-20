using System;
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
      return GetAssignable(ancestorType, ancestorType.Assembly.GetExportedTypes());
    }

    public static IEnumerable<Type> GetAllLoadedDescendance(Type ancestorType)
    {
      return GetAssignable(ancestorType, GetAllExportedTypes());
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

    /// <summary>
    /// Gets the public concrete descendance of a type from a list of types.
    /// </summary>
    /// <param name="ancestorType">Type of the ancestor.</param>
    /// <param name="descendantTypes">The descendant types.</param>
    /// <returns></returns>
    public static IEnumerable<Type> GetAssignable(this Type ancestorType, IEnumerable<Type> descendantTypes)
    {
      return from type in descendantTypes
             where type.IsPublic && !type.IsAbstract && ancestorType.IsAssignableFrom(type)
             select type;
    }

    public static bool IsAssignableTo(this Type type, params Type[] ancestorTypes)
    {
      return (from ancestorType in ancestorTypes
              where ancestorType.IsAssignableFrom(type)
              select type).Count() > 0;
    }

    public static Type GetTypeParameterOfGenericType(Type type)
    {
      if (type == typeof (object))
        return null;
      return type.IsGenericType ? type.GetGenericArguments().First() : GetTypeParameterOfGenericType(type.BaseType);
    }

    /// <summary>
    /// Determine of specified type is nullable
    /// </summary>
    public static bool IsNullable(Type t)
    {
      return !t.IsValueType || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof (Nullable<>));
    }

    /// <summary>
    /// Return underlying type if type is Nullable otherwise return the type
    /// </summary>
    public static Type GetCoreType(Type t)
    {
      if (t != null && IsNullable(t))
        return t.IsValueType ? Nullable.GetUnderlyingType(t) : t;
      return t;
    }

    /// <summary>
    /// Returns the data type of the items in the specified list.
    /// </summary>
    /// <param name="enumerable">The enumerable to be examined for type information.</param>
    /// <returns>The System.Type of the items contained in the list.</returns>
    public static Type GetEnumerableItemType(IEnumerable enumerable)
    {
      var queryable = enumerable as IQueryable;
      if (queryable != null)
        return queryable.ElementType;
      Type itemType;
      try
      {
        itemType = ListBindingHelper.GetListItemType(enumerable);
      }
      catch (NotImplementedException)
      {
        itemType = null;
      }
      if (itemType == null)
      {
        queryable = enumerable.AsQueryable();
        return queryable.ElementType;
      }
      return itemType;
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
		/// Gets the properties to serialize to display in a DataGridView.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns></returns>
		public static IEnumerable<PropertyDescriptor> GetPropertiesToSerialize(Type type)
		{
			return GetPropertiesToDisplay(type).FilterBySerializable();
		}

		/// <summary>
		/// Gets the properties that can be serialized.
		/// </summary>
		/// <param name="propertyDescriptors">The property descriptors.</param>
		/// <returns></returns>
		public static IEnumerable<PropertyDescriptor> FilterBySerializable(this IEnumerable<PropertyDescriptor> propertyDescriptors)
		{
			return from propertyDescriptor in propertyDescriptors
						 where propertyDescriptor.PropertyType.IsSerializable
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
    /// Creates an instance of type if type is an ancestorType or a descendant
    /// </summary>
    /// <param name="ancestorType">Type of the ancestor.</param>
    /// <param name="type">The type.</param>
    /// <param name="args">The args.</param>
    /// <returns>The Instance</returns>
    public static object CreateInstanceOf(Type ancestorType, Type type, params Object[] args)
    {
      return ancestorType.IsAssignableFrom(type) ? Activator.CreateInstance(type, args) : null;
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

  }
}