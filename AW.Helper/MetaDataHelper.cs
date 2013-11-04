using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace AW.Helper
{
	public static class MetaDataHelper
	{
		/// <summary>
		/// 	Gets the public concrete descendants of a type.
		/// </summary>
		/// <param name="ancestorType"> Type of the ancestor. </param>
		/// <returns> The descendants. </returns>
		public static IEnumerable<Type> GetDescendants(Type ancestorType)
		{
			return GetDescendants(ancestorType, ancestorType.Assembly.GetExportedTypes());
		}

		/// <summary>
		/// 	Gets the public concrete descendant of a type for a list of types.
		/// </summary>
		/// <param name="ancestorType"> Type of the ancestor. </param>
		/// <param name="exportedTypes"> The types to select from. </param>
		/// <returns> The Descendants. </returns>
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
		/// 	Gets all exported types in the Current Domain.
		/// </summary>
		/// <returns> All exported types in the Current Domain. </returns>
		private static IEnumerable<Type> GetAllExportedTypes()
		{
			return from assembly in AppDomain.CurrentDomain.GetAssemblies()
			       from exportedType in GetPublicTypes(assembly)
			       select exportedType;
		}

		public static Assembly GetAssembly(string assemblyName)
		{
			return GetAssembly(AppDomain.CurrentDomain.GetAssemblies(), assemblyName);
		}

		public static Assembly GetAssembly(this IEnumerable<Assembly> assemblies, string assemblyName)
		{
			try
			{
				return assemblies.SingleOrDefault(a => AssembliesMatch(a, new AssemblyName(assemblyName)));
			}
			catch
			{
				return assemblies.SingleOrDefault(a => a.FullName.Equals(assemblyName));
			}
		}

		/// <summary>
		/// 	Assembly resolver that probes the assemblies loaded in the current Domain.
		/// </summary>
		/// <param name="sender"> The sender. </param>
		/// <param name="args"> The <see cref="System.ResolveEventArgs" /> instance containing the event data. </param>
		/// <returns> </returns>
		public static Assembly LoadedAssemblyResolver(object sender, ResolveEventArgs args)
		{
			return GetAssembly(args.Name);
		}

		public static void AddLoadedAssemblyResolverIfNeeded(Type type)
		{
			AddAssemblyResolverIfNeeded(type, LoadedAssemblyResolver);
		}

		public static void AddAssemblyResolverIfNeeded(Type type, ResolveEventHandler assemblyResolver)
		{
			if (AssemblyResolverIsNeeded(type))
				AppDomain.CurrentDomain.AssemblyResolve += assemblyResolver;
		}

		/// <summary>
		/// Adds the loaded assembly resolver if needed.
		/// </summary>
		/// <param name="assembly">The assembly.</param>
		public static void AddLoadedAssemblyResolverIfNeeded(Assembly assembly)
		{
			if (AssemblyResolverIsNeeded(assembly))
				AppDomain.CurrentDomain.AssemblyResolve += LoadedAssemblyResolver;
		}

		public static void AddDirectoryAssemblyResolverIfNeeded(Assembly assembly)
		{
			var directoryName = Path.GetDirectoryName(assembly.Location);
			if (AssemblyResolverIsNeeded(directoryName))
			{
				AppDomain.CurrentDomain.AssemblyResolve += LoadedAssemblyResolver;
				AppDomain.CurrentDomain.AssemblyResolve += (sender, args) => LoadFrom(directoryName, args.Name);
			}
		}

		private static Assembly LoadFrom(string directoryName, string name)
		{
			var assemblyName = new AssemblyName(name);
			var assemblyLocation = GetAssemblyLocation(directoryName, assemblyName.Name);
			return File.Exists(assemblyLocation) ? Assembly.LoadFrom(assemblyLocation) : null;
		}

		public static string GetAssemblyLocation(string directoryName, string shortAssemblyName)
		{
			return Path.Combine(directoryName, shortAssemblyName + ".dll");
		}

		/// <summary>
		/// Adds the self assembly resolver if needed.
		/// </summary>
		/// <param name="assembly">The assembly.</param>
		public static void AddSelfAssemblyResolverIfNeeded(Assembly assembly)
		{
			if (AssemblyResolverIsNeeded(assembly))
				AddSelfAssemblyResolve(assembly);
		}

		/// <summary>
		/// Adds a self assembly resolver if needed.
		/// </summary>
		/// <param name="type">The type.</param>
		public static void AddSelfAssemblyResolverIfNeeded(Type type)
		{
			if (AssemblyResolverIsNeeded(type))
				AddSelfAssemblyResolve(type.Assembly);
		}

		private static bool AssemblyResolverIsNeeded(Type type)
		{
			return Type.GetType(GetShortAssemblyQualifiedName(type)) == null;
		}

		private static string GetShortAssemblyQualifiedName(Type type)
		{
			return type.FullName + ", " + type.Assembly.GetName().Name;
		}

		private static void AddSelfAssemblyResolve(Assembly assembly)
		{
			AppDomain.CurrentDomain.AssemblyResolve += (sender, args) => ReturnAssemblyIfAMatch(assembly, args);
		}

		private static Assembly ReturnAssemblyIfAMatch(Assembly assembly, ResolveEventArgs args)
		{
			return AssembliesMatch(assembly, args.Name) ? assembly : null;
		}

		public static bool AssembliesMatch(Assembly assembly, String assemblyName)
		{
			var assemblyName1 = assembly.GetName();
			AssemblyName assemblyName2;
			try
			{
				assemblyName2 = new AssemblyName(assemblyName);
			}
			catch
			{
				return assemblyName1.Name.Equals(assemblyName);
			}
			return AssembliesMatch(assemblyName1, assemblyName2);
		}

		public static bool AssembliesMatch(Assembly assembly, AssemblyName assemblyName)
		{
			return AssembliesMatch(assembly.GetName(), assemblyName);
		}

		private static bool AssembliesMatch(AssemblyName assemblyName1, AssemblyName assemblyName2)
		{
			return assemblyName1.Equals(assemblyName2) || AssemblyName.ReferenceMatchesDefinition(assemblyName1, assemblyName2)
			       || assemblyName1.Name.Equals(assemblyName2.Name);
		}

		private static bool AssemblyResolverIsNeeded(Assembly assembly)
		{
			return AssemblyResolverIsNeeded(Path.GetDirectoryName(assembly.Location));
		}

		private static bool AssemblyResolverIsNeeded(string directoryPath)
		{
			return !AppDomain.CurrentDomain.BaseDirectory.Equals(directoryPath, StringComparison.OrdinalIgnoreCase);
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

	  public static IEnumerable<string> GetNamespaces(Assembly assembly)
    {
      return (assembly.GetTypes().Select(t => t.Namespace)
              .Where(n => !String.IsNullOrEmpty(n))
              .Distinct());
    }

    public static IEnumerable<string> GetNamespaces(params string[] assemblyPaths)
    {
      return GetNamespaces((IEnumerable<string>)assemblyPaths);
    }

    public static IEnumerable<string> GetNamespaces(IEnumerable<string> assemblyPaths)
	  {
	    var namespaces = new List<string>();
      foreach (var assembly in assemblyPaths.Where(File.Exists).Select(Assembly.LoadFrom))
	      namespaces.AddRange(GetNamespaces(assembly));
	    return namespaces;
	  }


	  /// <summary>
		/// 	Gets the public concrete descendants of a type from a list of types.
		/// </summary>
		/// <param name="ancestorType"> Type of the ancestor. </param>
		/// <param name="descendantTypes"> The descendant types. </param>
		/// <returns> </returns>
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
			        select type).Any();
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
			return typeIsAssignableTo.GetAssignable(types).Where(t => t.IsClass);
		}

		public static IEnumerable<Type> GetInterfaceImplementersBothWays(this IEnumerable<Type> types, Type interfaceType)
		{
			var implementers = types.FilterByClassIsAssignableTo(interfaceType);
			if (!implementers.Any())
				implementers = types.FilterByImplements(interfaceType.FullName);
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
			if (type == typeof(object) || type == null)
				return null;
			return type.IsGenericType ? type.GetGenericArguments() : GetTypeParametersOfGenericType(type.BaseType);
		}

		public static bool IsSerializable(Type type)
		{
			if (type.IsSerializable || type.IsInterface)
			{
				var typeParametersOfGenericType = GetTypeParametersOfGenericType(type);
				return typeParametersOfGenericType.IsNullOrEmpty() || typeParametersOfGenericType.All(IsSerializable);
			}
			return false;
		}

		/// <summary>
		/// 	Determine of specified type is nullable
		/// </summary>
		public static bool IsNullable(Type t)
		{
			return !t.IsValueType || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof (Nullable<>));
		}

		/// <summary>
		/// 	Return underlying type if type is Nullable otherwise return the type
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
		/// 	Creates the generic. http://geekswithblogs.net/marcel/archive/2007/03/24/109722.aspx
		/// </summary>
		/// <param name="generic"> The generic type. </param>
		/// <param name="innerType"> Type of the inner. </param>
		/// <param name="args"> The args. </param>
		/// <returns> </returns>
		public static object CreateGeneric(Type generic, Type innerType, params object[] args)
		{
			var specificType = generic.MakeGenericType(new[] {innerType});
			return Activator.CreateInstance(specificType, args);
		}

    public static IList CreateList(Type type, params object[] args)
	  {
      return (IList)CreateGeneric(typeof(List<>), type, args);
	  }

	  public static IList ConvertToList(IEnumerable enumerable)
	  {
	    var list = enumerable as IList;
	    return list ?? CreateList(GetEnumerableItemType(enumerable), enumerable);
	  }

    public static Array ConvertToArray(IEnumerable enumerable)
    {
      var collection = enumerable as ICollection;
      return ConvertToArray(collection ?? ConvertToList(enumerable));
    }

	  private static Array ConvertToArray(ICollection collection)
	  {
      var array = collection as Array;
      if (array != null) return array;
	    array = Array.CreateInstance(GetEnumerableItemType(collection), collection.Count);
	    collection.CopyTo(array, 0);
      return array; 
	  }

		/// <summary>
		/// 	Returns the data type of the items in the specified list.
		/// </summary>
		/// <param name="enumerable"> The enumerable to be examined for type information. </param>
		/// <returns> The System.Type of the items contained in the list. </returns>
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
		/// 	Gets the type of the object type if it isn't enumerable or if it is get the enumerable Item Type.
		/// </summary>
		/// <param name="o"> The object. </param>
		/// <returns> </returns>
		public static Type GetObjectTypeorEnumerableItemType(object o)
		{
			if (o == null)
				return null;
			var objects = o as IEnumerable;
			return objects == null ? o.GetType() : GetEnumerableItemType(objects);
		}

		/// <summary>
		/// 	Gets the properties to display in LINQPad's Dump method. They should be the same as would appear in a DataGridView with AutoGenerateColumns.
		/// </summary>
		/// <remarks>
		/// 	Where clause copied from DataGridViewDataConnection.GetCollectionOfBoundDataGridViewColumns()
		/// </remarks>
		/// <returns> The properties to display in LINQPad's Dump </returns>
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
		/// 	Gets the properties to serialize to display in a DataGridView.
		/// </summary>
		/// <param name="type"> The type. </param>
		/// <returns> </returns>
		public static IEnumerable<PropertyDescriptor> GetPropertiesToSerialize(Type type)
		{
			return GetPropertiesToDisplay(type).FilterBySerializable().FilterByIsNotAssignableFrom(typeof (IDictionary));
		}

		public static IEnumerable<PropertyDescriptor> GetPropertiesToSerialize(IEnumerable enumerable)
		{
			return GetPropertiesToSerialize(GetEnumerableItemType(enumerable));
		}

		/// <summary>
		/// 	Gets the properties that can be serialized.
		/// </summary>
		/// <param name="propertyDescriptors"> The property descriptors. </param>
		/// <returns> </returns>
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

		public static IEnumerable<PropertyDescriptor> FilterByName(this IEnumerable<PropertyDescriptor> propertyDescriptors, string name)
		{
			return from propertyDescriptor in propertyDescriptors
			       where propertyDescriptor.Name == name
			       select propertyDescriptor;
		}

		/// <summary>
		/// 	Gets the property descriptor for a property. If there are more than 1 get the one with the 'most' information otherwise take the last.
		/// </summary>
		/// <param name="propertyDescriptors"> The property descriptors. </param>
		/// <param name="name"> The property name. </param>
		/// <returns> </returns>
		public static PropertyDescriptor GetFieldPropertyDescriptor(this IEnumerable<PropertyDescriptor> propertyDescriptors, string name)
		{
			var descriptorsWithName = propertyDescriptors.FilterByName(name);
			PropertyDescriptor result = null;
			if (descriptorsWithName != null)
				foreach (var propertyDescriptor in descriptorsWithName)
				{
					result = propertyDescriptor;
					try
					{
						if (result.Name != result.DisplayName) 
							return result;
					}
					catch (Exception e)
					{
						GeneralHelper.TraceOut(e);
					}
				}
			return result;
		}

		/// <summary>
		/// 	Folds all of the associated metadata providers into the type of the subject. Does not work properly before .net 4.
		/// </summary>
		public static void FoldAllAssociatedMetadataProvidersIntoTheSubjectType(Type ancestorType)
		{
			if (Environment.Version.Major >= 4)
				AddAssociatedMetadataProviders(GetDescendants(ancestorType));
		}

		/// <summary>
		/// 	Adds the associated metadata providers for each type.
		/// </summary>
		/// <see
		/// 	cref="http://blogs.msdn.com/davidebb/archive/2009/07/24/using-an-associated-metadata-class-outside-dynamic-data.aspx" />
		/// <param name="typesWhichMayHaveBuddyClasses"> The types which may have buddy classes. </param>
		internal static void AddAssociatedMetadataProviders(params Type[] typesWhichMayHaveBuddyClasses)
		{
			if (!typesWhichMayHaveBuddyClasses.IsNullOrEmpty())
				AddAssociatedMetadataProviders((IEnumerable<Type>) typesWhichMayHaveBuddyClasses);
		}

		/// <summary>
		/// 	Adds the associated metadata providers for each type. But doesn't seem to work for properties on inherited classes for version of .net before 4.0
		/// </summary>
		/// <see
		/// 	cref="http://blogs.msdn.com/davidebb/archive/2009/07/24/using-an-associated-metadata-class-outside-dynamic-data.aspx" />
		/// <param name="typesWhichMayHaveBuddyClasses"> The types which may have buddy classes. </param>
		internal static void AddAssociatedMetadataProviders(IEnumerable<Type> typesWhichMayHaveBuddyClasses)
		{
			foreach (var typeWithBuddyClass in typesWhichMayHaveBuddyClasses)
				AddAssociatedMetadataProvider(typeWithBuddyClass);
		}

		/// <summary>
		/// 	Adds the associated metadata provider.
		/// </summary>
		/// <see
		/// 	cref="http://blogs.msdn.com/davidebb/archive/2009/07/24/using-an-associated-metadata-class-outside-dynamic-data.aspx" />
		/// <param name="typeWithBuddyClass"> The type with buddy class. </param>
		public static void AddAssociatedMetadataProvider(Type typeWithBuddyClass)
		{
			if (Environment.Version.Major >= 4)
				TypeDescriptor.AddProvider(new AssociatedMetadataTypeTypeDescriptionProvider(typeWithBuddyClass), typeWithBuddyClass);
		}

		/// <summary>
		/// 	Creates an instance of type if type is an ancestorType or a descendant
		/// </summary>
		/// <param name="ancestorType"> Type of the ancestor. </param>
		/// <param name="type"> The type. </param>
		/// <param name="args"> The args. </param>
		/// <returns> The Instance </returns>
		public static object CreateInstanceOf(Type ancestorType, Type type, params Object[] args)
		{
			return ancestorType.IsAssignableFrom(type) ? Activator.CreateInstance(type, args) : null;
		}

		/// <summary>
		/// 	Gets the property descriptors for a class.
		/// </summary>
		/// <param name="modelClass"> The model class. </param>
		/// <param name="attributes"> An array of type System.Attribute that is used as a filter. </param>
		/// <returns> The property descriptors for a class. </returns>
		public static IEnumerable<PropertyDescriptor> GetPropertyDescriptors(Type modelClass, params Attribute[] attributes)
		{
			var propertyDescriptorCollection = attributes.IsNullOrEmpty() ? TypeDescriptor.GetProperties(modelClass) : TypeDescriptor.GetProperties(modelClass, attributes);
			var modelClassProperties = propertyDescriptorCollection.AsEnumerable().ToList();
			if (TypeDescriptor.GetProvider(modelClass) is AssociatedMetadataTypeTypeDescriptionProvider)
				return modelClassProperties; //No need to get the MetadataType(buddy class)

			if (Environment.Version.Major < 4) // Not needed if .net 4.0 and FoldAllAssociatedMetadataProvidersIntoTheSubjectType(); is used
			{
				var metadataAttrib = modelClass.GetCustomAttributes(typeof (MetadataTypeAttribute), true).OfType<MetadataTypeAttribute>().FirstOrDefault();
				if (metadataAttrib != null)
					modelClassProperties.AddRange(TypeDescriptor.GetProperties(metadataAttrib.MetadataClassType).AsEnumerable());
			}
			return modelClassProperties;
		}

		public static IEnumerable<PropertyDescriptor> AsEnumerable(this PropertyDescriptorCollection propertyDescriptorCollection)
		{
			return propertyDescriptorCollection.Cast<PropertyDescriptor>();
		}

		/// <summary>
		/// 	Gets the attributes from a collection of properties for a particular property name.
		/// </summary>
		/// <param name="properties"> The properties. </param>
		/// <param name="fieldName"> Name of the field. </param>
		/// <returns> The validation attributes. </returns>
		public static IEnumerable<Attribute> GetAttributes(IEnumerable<PropertyDescriptor> properties, string fieldName)
		{
			return properties.Where(p => p.Name == fieldName).SelectMany(prop => prop.Attributes.Cast<Attribute>());
		}

		/// <summary>
		/// 	Gets the attributes from a collection of properties for a particular property name.
		/// </summary>
		/// <param name="properties"> The properties. </param>
		/// <param name="fieldName"> Name of the field. </param>
		/// <returns> The validation attributes. </returns>
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
		/// 	Gets the validation attributes from a collection of properties for a particular property name.
		/// </summary>
		/// <param name="properties"> The properties. </param>
		/// <param name="fieldName"> Name of the field. </param>
		/// <returns> The validation attributes. </returns>
		public static IEnumerable<ValidationAttribute> GetValidationAttributes(IEnumerable<PropertyDescriptor> properties, string fieldName)
		{
			return GetAttributes(properties, fieldName).OfType<ValidationAttribute>();
		}

		/// <summary>
		/// 	Gets the validation attributes of a type of entity.
		/// </summary>
		/// <param name="type"> The type. </param>
		/// <param name="fieldName"> Name of the field. </param>
		/// <returns> The validation attributes. </returns>
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

    public static string GetVersion(this Assembly assembly)
    {
      var assemblyFileVersionAttribute = GetCustomAttribute<AssemblyFileVersionAttribute>(assembly);
      if (assemblyFileVersionAttribute != null && !String.IsNullOrEmpty(assemblyFileVersionAttribute.Version)) return assemblyFileVersionAttribute.Version;
      var assemblyVersionAttribute = GetCustomAttribute<AssemblyVersionAttribute>(assembly);
      if (assemblyVersionAttribute != null && !String.IsNullOrEmpty(assemblyVersionAttribute.Version)) return assemblyVersionAttribute.Version;
      return assembly.GetName().Version.ToString();
    }

    public static string GetInformationalVersionAttribute(this Assembly assembly)
    {
      var assemblyInformationalVersionAttribute = GetCustomAttribute<AssemblyInformationalVersionAttribute>(assembly);
      return assemblyInformationalVersionAttribute == null ? null : assemblyInformationalVersionAttribute.InformationalVersion;
    }

    public static string GetTitle(this Assembly assembly)
    {
      var assemblyTitleAttribute = GetCustomAttribute<AssemblyTitleAttribute>(assembly);
      return assemblyTitleAttribute == null ? null : assemblyTitleAttribute.Title;
    }

    public static string GetDescription(this Assembly assembly)
    {
      var assemblyDescriptionAttribute = GetCustomAttribute<AssemblyDescriptionAttribute>(assembly);
      return assemblyDescriptionAttribute == null ? null : assemblyDescriptionAttribute.Description;
    }

    public static T GetCustomAttribute<T>(this Assembly assembly) where T : Attribute
    {
      return ((T)assembly.GetCustomAttributes(typeof(T), false).SingleOrDefault());
    }

    //public static CustomAttributeData GetCustomAttributeReflectionOnly<T>(this Assembly assembly) where T : Attribute
    //{
    //  var customAttributes = CustomAttributeData.GetCustomAttributes(assembly);
    //  return customAttributes.SingleOrDefault(ca=>ca.AttributeType==typeof(T));
    //}

		public static MethodInfo GetMethodInfo<T>(Expression<Action<T>> expression)
		{
			var methodCallExpression = expression.Body as MethodCallExpression;
			return methodCallExpression == null ? null : methodCallExpression.Method;
		}

		public static MemberInfo GetMemberInfo<T>(Expression<Func<T, object>> expression)
		{
			var memberExpression = expression.Body as MemberExpression;
			return memberExpression == null ? null : memberExpression.Member;
		}
	}
}