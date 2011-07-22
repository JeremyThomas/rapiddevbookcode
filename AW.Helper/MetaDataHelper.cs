using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace AW.Helper
{
	public static class MetaDataHelper
	{
		/// <summary>
		/// Gets the public concrete descendants of a type.
		/// </summary>
		/// <param name="ancestorType">Type of the ancestor.</param>
		/// <returns>The descendants.</returns>
		public static IEnumerable<Type> GetDescendants(Type ancestorType)
		{
			return GetDescendants(ancestorType, ancestorType.Assembly.GetExportedTypes());
		}

		/// <summary>
		/// Gets the public concrete descendant of a type for a list of types.
		/// </summary>
		/// <param name="ancestorType">Type of the ancestor.</param>
		/// <param name="exportedTypes">The types to select from.</param>
		/// <returns>The Descendants.</returns>
		public static IEnumerable<Type> GetDescendants(Type ancestorType, IEnumerable<Type> exportedTypes)
		{
			return from type in exportedTypes
			       where type.IsPublic && !type.IsAbstract && type.IsSubclassOf(ancestorType)
			       select type;
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
			return from assembly in AppDomain.CurrentDomain.GetAssemblies()
			       from exportedType in GetPublicTypes(assembly)
			       select exportedType;
		}

		private static IEnumerable<Type> GetPublicTypes(Assembly assembly)
		{
			try
			{
				return assembly.GetExportedTypes();
			}
			catch (Exception)
			{
				return new Type[] {};
			}
		}

		/// <summary>
		/// Gets the public concrete descendants of a type from a list of types.
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

		public static Type GetInterface(this Type type, Type interfaceType)
		{
			return type.GetInterface(interfaceType.FullName);
		}

		public static bool Implements(this Type type, Type interfaceType)
		{
			return type.Implements(interfaceType.FullName);
		}

		public static bool Implements(this Type type, string interfaceName)
		{
			return type.GetInterface(interfaceName) != null;
		}

		public static IEnumerable<Type> FilterByImplements(this IEnumerable<Type> types, string interfaceName)
		{
			return from type in types
						 where type.Implements(interfaceName) && type.IsClass
			       select type;
		}
		
		public static IEnumerable<Type> FilterByClassIsAssignableTo(this IEnumerable<Type> types, Type typeIsAssignableTo)
		{
			return typeIsAssignableTo.GetAssignable(types).Where(t=>t.IsClass);
		}

		public static IEnumerable<Type> GetInterfaceImplementersBothWays(this IEnumerable<Type> types, Type interfaceType)
		{
			var implementers = FilterByClassIsAssignableTo(types, interfaceType);
			if (!implementers.Any())
				implementers = FilterByImplements(types, interfaceType.FullName);
			return implementers;
		}

		public static Type GetTypeParameterOfGenericType(Type type)
		{
			if (type == typeof (object))
				return null;
			return type.IsGenericType ? type.GetGenericArguments().First() : GetTypeParameterOfGenericType(type.BaseType);
		}

		public static Type[] GetTypeParametersOfGenericType(Type type)
		{
			if (type == typeof (object))
				return null;
			return type.IsGenericType ? type.GetGenericArguments() : GetTypeParametersOfGenericType(type.BaseType);
		}

		public static bool IsSerializable(Type type)
		{
			if (type.IsSerializable)
			{
				var typeParametersOfGenericType = GetTypeParametersOfGenericType(type);
				return typeParametersOfGenericType.IsNullOrEmpty() || typeParametersOfGenericType.All(t => t.IsSerializable);
			}
			return false;
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

		public static Type GetElementType(Type enumerableType)
		{
			var ienumType = FindGenericType(typeof (IEnumerable<>), enumerableType);
			return ienumType == null ? enumerableType : GetTypeParameterOfGenericType(ienumType);
		}

		internal static Type FindGenericType(Type definition, Type type)
		{
			while (type != null && type != typeof (object))
			{
				if (type.IsGenericType && type.GetGenericTypeDefinition() == definition)
					return type;
				if (definition.IsInterface)
					foreach (var found in type.GetInterfaces().Select(itype => FindGenericType(definition, itype)).Where(found => found != null))
						return found;
				type = type.BaseType;
			}
			return null;
		}

		/// <summary>
		/// Creates the generic.
		/// http://geekswithblogs.net/marcel/archive/2007/03/24/109722.aspx
		/// </summary>
		/// <param name="generic">The generic type.</param>
		/// <param name="innerType">Type of the inner.</param>
		/// <param name="args">The args.</param>
		/// <returns></returns>
		public static object CreateGeneric(Type generic, Type innerType, params object[] args)
		{
			var specificType = generic.MakeGenericType(new[] {innerType});
			return Activator.CreateInstance(specificType, args);
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
			if (itemType == null || itemType == typeof (object))
			{
				var enumerableType = enumerable.GetType();
				var elementType = GetElementType(enumerableType);
				if (elementType != enumerableType)
					return elementType;
				//queryable = enumerable.AsQueryable();
				//return queryable.ElementType;
			}
			return itemType;
		}

		/// <summary>
		/// Gets the type of the object type if it isn't enumerable or if it is get the enumerable Item Type.
		/// </summary>
		/// <param name="o">The object.</param>
		/// <returns></returns>
		public static Type GetObjectTypeorEnumerableItemType(object o)
		{
			if (o == null)
				return null;
			var objects = o as IEnumerable;
			return objects == null ? o.GetType() : GetEnumerableItemType(objects);
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

		public static IEnumerable<PropertyDescriptor> GetPropertiesToDisplay(IEnumerable enumerable)
		{
			var enumerableItemType = GetEnumerableItemType(enumerable);
			return GetPropertiesToDisplay(enumerableItemType == typeof (object) ? enumerable.GetType() : enumerableItemType);
		}

		public static IEnumerable<PropertyDescriptor> GetPropertiesToDisplay<T>(IEnumerable<T> enumerable)
		{
			return GetPropertiesToDisplay(typeof (T));
		}

		/// <summary>
		/// Gets the properties to serialize to display in a DataGridView.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns></returns>
		public static IEnumerable<PropertyDescriptor> GetPropertiesToSerialize(Type type)
		{
			return GetPropertiesToDisplay(type).FilterBySerializable().FilterByIsNotAssignableFrom(typeof (IDictionary));
		}

		public static IEnumerable<PropertyDescriptor> GetPropertiesToSerialize(IEnumerable enumerable)
		{
			return GetPropertiesToSerialize(GetEnumerableItemType(enumerable));
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

		public static IEnumerable<PropertyDescriptor> FilterByIsNotAssignableFrom(this IEnumerable<PropertyDescriptor> propertyDescriptors, Type typeToFilterOut)
		{
			return from propertyDescriptor in propertyDescriptors
			       where !typeToFilterOut.IsAssignableFrom(propertyDescriptor.PropertyType)
			       select propertyDescriptor;
		}

		public static IEnumerable<PropertyDescriptor> FilterByIsEnumerable(this IEnumerable<PropertyDescriptor> propertyDescriptors, Type elementTypeToFilterBy)
		{
			return from propertyDescriptor in propertyDescriptors
			       let elementType = GetElementType(propertyDescriptor.PropertyType)
			       where elementTypeToFilterBy.IsAssignableFrom(elementType)
			       select propertyDescriptor;
		}

		public static PropertyDescriptor GetFieldPropertyDescriptor(this IEnumerable<PropertyDescriptor> propertyDescriptors, string fieldName)
		{
			return propertyDescriptors.FirstOrDefault(pd => pd.Name == fieldName);
		}

		/// <summary>
		/// Adds the associated metadata providers for each type. But doesn't seem to work for properties on inherited classes for version of .net before 4.0
		/// </summary>
		/// <see cref="http://blogs.msdn.com/davidebb/archive/2009/07/24/using-an-associated-metadata-class-outside-dynamic-data.aspx"/>
		/// <param name="typesWhichMayHaveBuddyClasses">The types which may have buddy classes.</param>
		public static void AddAssociatedMetadataProviders(IEnumerable<Type> typesWhichMayHaveBuddyClasses)
		{
			foreach (var typeWithBuddyClass in typesWhichMayHaveBuddyClasses)
				AddAssociatedMetadataProvider(typeWithBuddyClass);
		}

		public static void AddAssociatedMetadataProvider(Type typeWithBuddyClass)
		{
			TypeDescriptor.AddProvider(new AssociatedMetadataTypeTypeDescriptionProvider(typeWithBuddyClass), typeWithBuddyClass);
		}

		/// <summary>
		/// Adds the associated metadata providers for each type.
		/// </summary>
		/// <see cref="http://blogs.msdn.com/davidebb/archive/2009/07/24/using-an-associated-metadata-class-outside-dynamic-data.aspx"/>
		/// <param name="typesWhichMayHaveBuddyClasses">The types which may have buddy classes.</param>
		public static void AddAssociatedMetadataProviders(params Type[] typesWhichMayHaveBuddyClasses)
		{
			if (!typesWhichMayHaveBuddyClasses.IsNullOrEmpty())
				AddAssociatedMetadataProviders((IEnumerable<Type>) typesWhichMayHaveBuddyClasses);
		}

		/// <summary>
		/// Folds all of the associated metadata providers into the type of the subject.
		/// </summary>
		public static void FoldAllAssociatedMetadataProvidersIntoTheSubjectType(Type ancestorType)
		{
			AddAssociatedMetadataProviders(GetDescendants(ancestorType));
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
		/// Gets the property descriptors for a class.
		/// </summary>
		/// <param name="modelClass">The model class.</param>
		/// <param name="attributes">An array of type System.Attribute that is used as a filter.</param>
		/// <returns>The property descriptors for a class.</returns>
		public static IEnumerable<PropertyDescriptor> GetPropertyDescriptors(Type modelClass, params Attribute[] attributes)
		{
			var propertyDescriptorCollection = attributes.IsNullOrEmpty() ? TypeDescriptor.GetProperties(modelClass) : TypeDescriptor.GetProperties(modelClass, attributes);
			var modelClassProperties = propertyDescriptorCollection.AsEnumerable().ToList();
			if (TypeDescriptor.GetProvider(modelClass) is AssociatedMetadataTypeTypeDescriptionProvider)
				return modelClassProperties; //No need to get the MetadataType(buddy class)

			//if (Environment.Version.Major < 4) // Not needed if .net 4.0 and LinqMetaData.FoldAllAssociatedMetadataProvidersIntoTheSubjectType(); is used
			//{
			//  var metadataAttrib = modelClass.GetCustomAttributes(typeof (MetadataTypeAttribute), true).OfType<MetadataTypeAttribute>().FirstOrDefault();
			//  if (metadataAttrib != null)
			//    modelClassProperties.AddRange(TypeDescriptor.GetProperties(metadataAttrib.MetadataClassType).Cast<PropertyDescriptor>().ToList());
			//}
			return modelClassProperties;
		}

		public static IEnumerable<PropertyDescriptor> AsEnumerable(this PropertyDescriptorCollection propertyDescriptorCollection)
		{
			return propertyDescriptorCollection.Cast<PropertyDescriptor>();
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
		/// Gets the attributes from a collection of properties for a particular property name.
		/// </summary>
		/// <param name="properties">The properties.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>The validation attributes.</returns>
		public static IEnumerable<T> GetAttributes<T>(IEnumerable<PropertyDescriptor> properties, string fieldName) where T : Attribute
		{
			if (!String.IsNullOrEmpty(fieldName))
				properties = properties.Where(p => p.Name == fieldName);
			return properties.SelectMany(prop => prop.Attributes.OfType<T>());
		}

		public static IEnumerable<T> GetAttributes<T>(Type type, string fieldName) where T : Attribute
		{
			return GetAttributes<T>(GetPropertyDescriptors(type), fieldName);
		}

		public static IEnumerable<T> GetAttributes<T>(Type type) where T : Attribute
		{
			return GetAttributes<T>(type, "");
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

		public static IEnumerable<DisplayNameAttribute> GetDisplayNameAttributes(Type type, string fieldName)
		{
			return GetAttributes<DisplayNameAttribute>(type, fieldName);
		}

		public static IEnumerable<DisplayNameAttribute> GetDisplayNameAttributes(Type type)
		{
			return GetTypesAttributes<DisplayNameAttribute>(type);
		}

		public static IEnumerable<DescriptionAttribute> GetDescriptionAttributes(Type type, string fieldName)
		{
			return GetAttributes<DescriptionAttribute>(type, fieldName);
		}

		public static IEnumerable<DescriptionAttribute> GetDescriptionAttributes(Type type)
		{
			return GetTypesAttributes<DescriptionAttribute>(type);
		}

		private static IEnumerable<T> GetTypesAttributes<T>(Type type) where T : Attribute
		{
			return type.GetCustomAttributes(typeof (T), true).Cast<T>();
		}
	}
}