using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using AW.Helper.PropertyDescriptors;

namespace AW.Helper
{
  public static class MetaDataHelper
  {
    /// <summary>
    ///   Gets the public concrete descendants of a type.
    /// </summary>
    /// <param name="ancestorType"> Type of the ancestor. </param>
    /// <returns> The descendants. </returns>
    public static IEnumerable<Type> GetDescendants(Type ancestorType)
    {
      return GetDescendants(ancestorType, ancestorType.Assembly.GetExportedTypes());
    }

    /// <summary>
    ///   Gets the public concrete descendant of a type for a list of types.
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

    public static IEnumerable<Type> GetAllLoadedDescendants(Type ancestorType)
    {
      return GetAssignable(ancestorType, GetAllExportedTypes());
    }

    public static IEnumerable<Type> GetTypeAndParentTypes(this Type type)
    {
      // is there any base type?
      if (type == null)
        yield break;
      // return all inherited types
      var currentBaseType = type;
      do
      {
        if (currentBaseType.IsGenericType)
          yield return currentBaseType.GetGenericTypeDefinition();
        else
          yield return currentBaseType;
        if (currentBaseType.IsNested)
        {
          if (currentBaseType.DeclaringType != null && currentBaseType.DeclaringType.BaseType != null)
          {
            var nestedTypeInBase = currentBaseType.DeclaringType.BaseType.GetNestedType(type.Name, BindingFlags.NonPublic | BindingFlags.Public);
            if (nestedTypeInBase != null)
              currentBaseType = nestedTypeInBase;
            else
              currentBaseType = currentBaseType.BaseType;
          }
        }
        else
          currentBaseType = currentBaseType.BaseType;
      } while (currentBaseType != null && currentBaseType != typeof (object) && currentBaseType.Implements(typeof (IEnumerable)));
    }

    /// <summary>
    ///   Gets all exported types in the Current Domain.
    /// </summary>
    /// <returns> All exported types in the Current Domain. </returns>
    private static IEnumerable<Type> GetAllExportedTypes()
    {
      return from assembly in AppDomain.CurrentDomain.GetAssemblies()
        from exportedType in GetPublicTypes(assembly)
        select exportedType;
    }

    private static Assembly GetAssembly(AssemblyName assemblyName)
    {
      return GetAssembly(AppDomain.CurrentDomain.GetAssemblies(), assemblyName);
    }

    public static Assembly GetAssembly(this IEnumerable<Assembly> assemblies, AssemblyName assemblyName)
    {
      try
      {
        return assemblies.SingleOrDefault(a => AssembliesMatch(a, assemblyName));
      }
      catch
      {
        return assemblies.SingleOrDefault(a => a.FullName.Equals(assemblyName.FullName));
      }
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
    ///   Assembly resolver that probes the assemblies loaded in the current Domain.
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
    ///   Adds the loaded assembly resolver if needed.
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

    public static Assembly LoadFrom(string directoryName, string name)
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
    ///   Adds the self assembly resolver if needed.
    /// </summary>
    /// <param name="assembly">The assembly.</param>
    public static void AddSelfAssemblyResolverIfNeeded(Assembly assembly)
    {
      if (AssemblyResolverIsNeeded(assembly))
        AddSelfAssemblyResolve(assembly);
    }

    /// <summary>
    ///   Adds a self assembly resolver if needed.
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

    public static string GetShortAssemblyQualifiedName(Type type)
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

    public static void LoadReferencedAssemblies(params string[] assembliesToIgnore)
    {
      var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();

      loadedAssemblies
          .SelectMany(x => x.GetReferencedAssemblies())
          .Distinct()
          .Where(y => loadedAssemblies.All(a => a.FullName != y.FullName) && assembliesToIgnore.All(a => !y.FullName.Contains(a)))
          .ToList()
          .ForEach(x => loadedAssemblies.Add(AppDomain.CurrentDomain.Load(x)));
    }

    /// <summary>
    ///   Gets the type, case insensitive, if it can't find it it then looks in the loaded assemblies.
    /// </summary>
    /// <param name="typeName">Name of the type.</param>
    /// <returns></returns>
    public static Type GetType(string typeName)
    {
      var type = Type.GetType(typeName, false, true);
      return type ?? Type.GetType(typeName, GetAssembly, TypeResolver);
    }

    /// <summary>
    ///   Resolves a type by stripping off the assembly name
    /// </summary>
    /// <param name="assembly">The assembly.</param>
    /// <param name="typeName">Name of the type.</param>
    /// <param name="ignoreCase">if set to <c>true</c> [ignore case].</param>
    /// <returns></returns>
    public static Type TypeResolver(Assembly assembly, string typeName, bool ignoreCase)
    {
      return assembly == null ? null : assembly.GetType(typeName.Before(",", typeName), false, ignoreCase);
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
    ///   Gets the loadable types.
    /// </summary>
    /// <remarks>http://haacked.com/archive/2012/07/23/get-all-types-in-an-assembly.aspx/</remarks>
    /// <param name="assembly">The assembly.</param>
    /// <returns></returns>
    /// <exception cref="System.ArgumentNullException">assembly</exception>
    public static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
    {
      if (assembly == null) throw new ArgumentNullException("assembly");
      try
      {
        return assembly.GetTypes();
      }
      catch (ReflectionTypeLoadException e)
      {
        return e.Types.Where(t => t != null);
      }
    }

    /// <summary>
    ///   Gets the concrete public implementations of the ancestor or interface type.
    /// </summary>
    /// <param name="assembly">The assembly.</param>
    /// <param name="ancestorTypeOrInterface">The ancestor type or interface.</param>
    /// <returns></returns>
    public static IEnumerable<Type> GetConcretePublicImplementations(this Assembly assembly, Type ancestorTypeOrInterface)
    {
      return ancestorTypeOrInterface.GetAssignable(assembly.GetLoadableTypes());
    }

    public static IEnumerable<Type> GetTypesContaining(Assembly assembly, string typeName)
    {
      return assembly.GetTypes().Where(t => t.AssemblyQualifiedName.ContainsIgnoreCase(typeName));
    }

    public static IEnumerable<Type> GetTypesContaining(string typeName)
    {
      return from assembly in AppDomain.CurrentDomain.GetAssemblies()
        from types in GetTypesContaining(assembly, typeName)
        select types;
    }

    public static IEnumerable<string> GetNamespaces(Assembly assembly)
    {
      return (assembly.GetTypes().Select(t => t.Namespace)
        .Where(n => !String.IsNullOrEmpty(n))
        .Distinct());
    }

    public static IEnumerable<string> GetNamespaces(params string[] assemblyPaths)
    {
      return GetNamespaces((IEnumerable<string>) assemblyPaths);
    }

    public static IEnumerable<string> GetNamespaces(IEnumerable<string> assemblyPaths)
    {
      var namespaces = new List<string>();
      foreach (var assembly in assemblyPaths.Where(File.Exists).Select(Assembly.LoadFrom))
        namespaces.AddRange(GetNamespaces(assembly));
      return namespaces;
    }


    /// <summary>
    ///   Gets the public concrete descendants of a type from a list of types.
    /// </summary>
    /// <param name="ancestorType"> Type of the ancestor. </param>
    /// <param name="descendantTypes"> The descendant types. </param>
    /// <returns> </returns>
    public static IEnumerable<Type> GetAssignable(this Type ancestorType, IEnumerable<Type> descendantTypes)
    {
      return from type in descendantTypes
        where type.IsPublic && !type.IsAbstract && ancestorType.IsAssignableFrom(type) && ancestorType != type
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

    public static bool ImplementsIComparable(Type coreType)
    {
      return coreType.Implements(typeof (IComparable)) || coreType.HasGenericTypeDefinition(typeof (IComparable<>));
    }

    public static bool Implements(this Type type, Type interfaceType)
    {
      return type.Implements(interfaceType.FullName);
    }

    public static bool Implements(this Type type, string interfaceName)
    {
      return type != null && type.GetInterface(interfaceName) != null;
    }

    public static bool HasGenericTypeDefinition(this Type type, Type genericTypeDefinition)
    {
      return type != null && type.IsGenericType && type.GetGenericTypeDefinition() == genericTypeDefinition;
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
      while (true)
      {
        if (type == null || type == typeof (object))
          return null;
        if (type.IsGenericType)
          return type.GetGenericArguments().First();
        type = type.BaseType;
      }
    }

    public static Type[] GetTypeParametersOfGenericType(Type type)
    {
      while (true)
      {
        if (type == typeof (object) || type == null)
          return null;
        if (type.IsGenericType)
          return type.GetGenericArguments();
        type = type.BaseType;
      }
    }

    public static bool IsSerializable(Type type)
    {
      if (type != typeof (Enum) && (type.IsSerializable || type.IsInterface))
      {
        var typeParametersOfGenericType = GetTypeParametersOfGenericType(type);
        return typeParametersOfGenericType.IsNullOrEmpty() || typeParametersOfGenericType.All(IsSerializable);
      }
      return false;
    }

    /// <summary>
    ///   Determine of specified type is nullable
    /// </summary>
    public static bool IsNullable(Type t)
    {
      return !t.IsValueType || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof (Nullable<>));
    }

    /// <summary>
    ///   Return underlying type if type is Nullable otherwise return the type
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
    ///   Creates the generic. http://geekswithblogs.net/marcel/archive/2007/03/24/109722.aspx
    /// </summary>
    /// <param name="generic"> The generic type. </param>
    /// <param name="innerType"> Type of the inner. </param>
    /// <param name="args"> The args. </param>
    /// <returns> </returns>
    public static object CreateGeneric(Type generic, Type innerType, params object[] args)
    {
      var specificType = generic.MakeGenericType(innerType);
      return Activator.CreateInstance(specificType, args);
    }

    public static IList CreateList(Type type, params object[] args)
    {
      return (IList) CreateGeneric(typeof (List<>), type, args);
    }

    public static Type CreateNullableType(Type innerType)
    {
      return typeof (Nullable<>).MakeGenericType(innerType);
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

    public static IEnumerable AsEnumerable(object potentialEnumerable)
    {
      var enumerable = potentialEnumerable as IEnumerable;
      if (enumerable == null)
      {
        var dataTable = potentialEnumerable as DataTable;
        if (dataTable != null)
          enumerable = dataTable.DefaultView;
      }
      return enumerable;
    }

    private static Array ConvertToArray(ICollection collection)
    {
      var array = collection as Array;
      if (array != null) return array;
      array = Array.CreateInstance(GetEnumerableItemType(collection), collection.Count);
      collection.CopyTo(array, 0);
      return array;
    }

    public static Type GetListItemType(object modifiedData)
    {
      return ListBindingHelper.GetListItemType(modifiedData);
    }

    /// <summary>
    /// Returns the data type of the items in the specified list.
    /// </summary>
    /// <param name="enumerable">The enumerable to be examined for type information.</param>
    /// <param name="getActual">if set to <c>true</c> attempt to get actual type if a non-concrete type is first found.</param>
    /// <returns>
    /// The System.Type of the items contained in the list.
    /// </returns>
    public static Type GetEnumerableItemType(IEnumerable enumerable, bool getActual = true)
    {
      var queryable = enumerable as IQueryable;
      if (queryable != null)
        return queryable.ElementType;
      Type itemType;
      var enumerableType = enumerable.GetType();
      var elementType = GetElementType(enumerableType);
      if (elementType != enumerableType && (IsTheActualType(elementType) || !getActual))
        return elementType;
      try
      {
        itemType = GetListItemType(enumerable);
        if (!IsTheActualType(itemType) && getActual)
          itemType = GetEnumerableItemTypeWithFirst(enumerable, itemType);
      }
      catch (NotImplementedException)
      {
        // ListBindingHelper.GetFirstItemByEnumerable catches NotSupportedException but doesn't catch NotImplementedException  - WTF
        itemType = GetEnumerableItemTypeWithFirst(enumerable, null);
      }
      return itemType;
    }

    public static bool IsTheActualType(Type itemType)
    {
      return itemType != typeof(object) && !itemType.IsInterface && !itemType.IsAbstract;
    }

    private static Type GetEnumerableItemTypeWithFirst(IEnumerable enumerable, Type itemType)
    {
      try
      {
        return GetEnumerableItemTypeWithFirst(enumerable) ?? itemType;
      }
      catch (Exception)
      {
        return itemType;
      }
    }

    private static Type GetEnumerableItemTypeWithFirst(IEnumerable enumerable)
    {
      var first = enumerable.Cast<object>().FirstOrDefault();
      return first == null ? null : first.GetType();
    }

    /// <summary>
    ///   Gets the type of the object type if it isn't enumerable or if it is get the enumerable Item Type.
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
    ///   Gets the properties to display in LINQPad's Dump method. They should be the same as would appear in a DataGridView
    ///   with AutoGenerateColumns.
    /// </summary>
    /// <remarks>
    ///   See CurrencyManager.GetItemProperties()
    ///   Where clause copied from DataGridViewDataConnection.GetCollectionOfBoundDataGridViewColumns()
    ///   ListBindingHelper.GetListItemProperties(type) calls TypeDescriptor.GetProperties(typeof(XElement), BrowsableAttributeList)
    ///   which eventually calls GetProperties(Attribute[] attributes) of any CustomTypeDescriptor.
    ///   But when the list is ObjectListView it gets its own list of properties via a straight TypeDescriptor.GetProperties(listItemType) then
    ///   supplies them via the ITypedList it implements but now if ListBindingHelper.GetListItemProperties() is called on the ObjectListView
    ///   it now returns those properties it wouldn't otherwise have.
    /// In the case of XElement's XTypeDescriptor. GetProperties(Attribute[] attributes) it only returns the 6 XPropertyDescriptors if attributes == null
    /// In response I have replaced TypeDescriptor.GetProperties(listItemType) in SetListItemType,ItemType Set,OnDeserialization with ListBindingHelper.GetListItemProperties(type)
    /// </remarks>
    /// <returns> The properties to display in LINQPad's Dump </returns>
    public static IEnumerable<PropertyDescriptor> GetPropertiesToDisplay(Type type)
    {
      return FilterToPropertiesToDisplay(ListBindingHelper.GetListItemProperties(type).AsEnumerable());
    }

    private static IEnumerable<PropertyDescriptor> FilterToPropertiesToDisplay(IEnumerable<PropertyDescriptor> properties)
    {
      return properties.Where(propertyDescriptor => !typeof (IList).IsAssignableFrom(propertyDescriptor.PropertyType) 
      || TypeDescriptor.GetConverter(typeof (Image)).CanConvertFrom(propertyDescriptor.PropertyType));
    }

    public static IEnumerable<PropertyDescriptor> GetPropertiesToDisplay(IEnumerable enumerable)
    {
      var target = ListBindingHelper.GetList(enumerable);
      var typedList = target as ITypedList;
      if (typedList != null)
        return FilterToPropertiesToDisplay(typedList.GetItemProperties(null).AsEnumerable());
      var enumerableItemType = GetEnumerableItemType(enumerable);
      return GetPropertiesToDisplay(enumerableItemType == typeof(object) ? enumerable.GetType() : enumerableItemType);
    }

    public static IEnumerable<PropertyDescriptor> GetPropertiesToDisplay<T>(IEnumerable<T> enumerable)
    {
      return GetPropertiesToDisplay(typeof (T));
    }

    /// <summary>
    ///   Gets the properties to serialize to display in a DataGridView.
    /// </summary>
    /// <param name="type"> The type. </param>
    /// <returns> </returns>
    public static IEnumerable<PropertyDescriptor> GetPropertiesToSerialize(Type type)
    {
      var fieldsToPropertiesTypeDescriptionProvider = new FieldsToPropertiesTypeDescriptionProvider(type, BindingFlags.Instance | BindingFlags.Public);
      TypeDescriptor.AddProvider(fieldsToPropertiesTypeDescriptionProvider, type);
      try
      {
        return GetPropertiesToDisplay(type);
      }
      finally
      {
        TypeDescriptor.RemoveProvider(fieldsToPropertiesTypeDescriptionProvider, type);
      }
    }

    /// <summary>
    ///   Gets the properties that can be serialized.
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
    ///   Gets the property descriptor for a property. If there are more than 1 get the one with the 'most' information
    ///   otherwise take the last.
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
            e.TraceOut();
          }
        }
      return result;
    }

    /// <summary>
    ///   Folds all of the associated metadata providers into the type of the subject. Does not work properly before .net 4.
    /// </summary>
    public static void FoldAllAssociatedMetadataProvidersIntoTheSubjectType(Type ancestorType)
    {
      if (Environment.Version.Major >= 4)
        AddAssociatedMetadataProviders(GetDescendants(ancestorType));
    }

    /// <summary>
    ///   Adds the associated metadata providers for each type.
    /// </summary>
    /// <see
    ///   cref="http://blogs.msdn.com/davidebb/archive/2009/07/24/using-an-associated-metadata-class-outside-dynamic-data.aspx" />
    /// <param name="typesWhichMayHaveBuddyClasses"> The types which may have buddy classes. </param>
    internal static void AddAssociatedMetadataProviders(params Type[] typesWhichMayHaveBuddyClasses)
    {
      if (!typesWhichMayHaveBuddyClasses.IsNullOrEmpty())
        AddAssociatedMetadataProviders((IEnumerable<Type>) typesWhichMayHaveBuddyClasses);
    }

    /// <summary>
    ///   Adds the associated metadata providers for each type. But doesn't seem to work for properties on inherited classes
    ///   for version of .net before 4.0
    /// </summary>
    /// <see
    ///   cref="http://blogs.msdn.com/davidebb/archive/2009/07/24/using-an-associated-metadata-class-outside-dynamic-data.aspx" />
    /// <param name="typesWhichMayHaveBuddyClasses"> The types which may have buddy classes. </param>
    internal static void AddAssociatedMetadataProviders(IEnumerable<Type> typesWhichMayHaveBuddyClasses)
    {
      foreach (var typeWithBuddyClass in typesWhichMayHaveBuddyClasses)
        AddAssociatedMetadataProvider(typeWithBuddyClass);
    }

    /// <summary>
    ///   Adds the associated metadata provider.
    /// </summary>
    /// <see
    ///   cref="http://blogs.msdn.com/davidebb/archive/2009/07/24/using-an-associated-metadata-class-outside-dynamic-data.aspx" />
    /// <param name="typeWithBuddyClass"> The type with buddy class. </param>
    public static void AddAssociatedMetadataProvider(Type typeWithBuddyClass)
    {
      if (Environment.Version.Major >= 4)
        TypeDescriptor.AddProvider(new AssociatedMetadataTypeTypeDescriptionProvider(typeWithBuddyClass), typeWithBuddyClass);
    }

    /// <summary>
    ///   Creates an instance of type if type is an ancestorType or a descendant
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
    ///   Gets the property descriptors for a class.
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
    ///   Gets the attributes from a collection of properties for a particular property name.
    /// </summary>
    /// <param name="properties"> The properties. </param>
    /// <param name="fieldName"> Name of the field. </param>
    /// <returns> The validation attributes. </returns>
    public static IEnumerable<Attribute> GetAttributes(IEnumerable<PropertyDescriptor> properties, string fieldName)
    {
      return properties.Where(p => p.Name == fieldName).SelectMany(prop => prop.Attributes.Cast<Attribute>());
    }

    /// <summary>
    ///   Gets the attributes from a collection of properties for a particular property name.
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
    ///   Gets the validation attributes from a collection of properties for a particular property name.
    /// </summary>
    /// <param name="properties"> The properties. </param>
    /// <param name="fieldName"> Name of the field. </param>
    /// <returns> The validation attributes. </returns>
    public static IEnumerable<ValidationAttribute> GetValidationAttributes(IEnumerable<PropertyDescriptor> properties, string fieldName)
    {
      return GetAttributes(properties, fieldName).OfType<ValidationAttribute>();
    }

    /// <summary>
    ///   Gets the validation attributes of a type of entity.
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
      return GetCustomAttributes<DisplayNameAttribute>(type);
    }

    public static IEnumerable<DisplayAttribute> GetDisplayAttributes(Type type, string fieldName)
    {
      return GetAttributes<DisplayAttribute>(type, fieldName);
    }

    public static IEnumerable<DescriptionAttribute> GetDescriptionAttributes(Type type, string fieldName)
    {
      return GetAttributes<DescriptionAttribute>(type, fieldName);
    }

    public static IEnumerable<DescriptionAttribute> GetDescriptionAttributes(Type type)
    {
      return GetCustomAttributes<DescriptionAttribute>(type);
    }

    public static string GetDisplayNameOrDescription(Enum value)
    {
      if (value == null)
        return null;
      var enumMember = value.GetType().GetField(value.ToString());
      if (enumMember == null)
        return null;
      return GetDisplayNameOrDescription(enumMember);
    }

    public static string GetDisplayNameOrDescription(MemberInfo enumMember)
    {
      var displayAttribute = enumMember.GetCustomAttribute<DisplayAttribute>();
      if (displayAttribute != null)
        return displayAttribute.GetName();
      var displayNameAttribute = enumMember.GetCustomAttribute<DisplayNameAttribute>();
      if (displayNameAttribute != null)
        return displayNameAttribute.DisplayName;
      var descriptionAttribute = enumMember.GetCustomAttribute<DescriptionAttribute>();
      return descriptionAttribute == null ? null : descriptionAttribute.Description;
    }

    public static T[] GetCustomAttributes<T>(Type type, bool inherit = true) where T : Attribute
    {
      return ((T[]) type.GetCustomAttributes(typeof (T), inherit));
    }

    /// <summary>
    ///   Gets the BCL major minor version. e.g. 4.5 or 4.6
    /// </summary>
    /// <returns></returns>
    public static string GetBclMajorMinorVersion()
    {
      return GetVersionInfo(typeof (Enumerable).Assembly).FileVersion.Substring(0, 3);
    }

    private static FileVersionInfo GetVersionInfo(Assembly assembly)
    {
      return FileVersionInfo.GetVersionInfo(assembly.Location);
    }

    public static string GetClassAssemblyName(Type t)
    {
      return t.AssemblyQualifiedName == null ? String.Empty : t.AssemblyQualifiedName.Substring(0, t.AssemblyQualifiedName.IndexOf(',', t.FullName.Length + 1));
    }

    public static string GetVersion(this Assembly assembly)
    {
      var assemblyFileVersionAttribute = GetCustomAttribute<AssemblyFileVersionAttribute>(assembly);
      if (assemblyFileVersionAttribute != null && !String.IsNullOrEmpty(assemblyFileVersionAttribute.Version)) return assemblyFileVersionAttribute.Version;
      var assemblyVersionAttribute = GetCustomAttribute<AssemblyVersionAttribute>(assembly);
      if (assemblyVersionAttribute != null && !String.IsNullOrEmpty(assemblyVersionAttribute.Version)) return assemblyVersionAttribute.Version;
      if (assembly == null) return null;
      var assemblyName = assembly.GetName();
      return Convert.ToString(assemblyName.Version);
    }

    public static string GetInformationalVersionAttribute(this Assembly assembly)
    {
      var assemblyInformationalVersionAttribute = GetCustomAttribute<AssemblyInformationalVersionAttribute>(assembly);
      return assemblyInformationalVersionAttribute == null ? null : assemblyInformationalVersionAttribute.InformationalVersion;
    }

    public static string GetProductVersion(this Assembly assembly)
    {
      var assemblyInformationalVersion = assembly.GetInformationalVersionAttribute();
      return String.IsNullOrWhiteSpace(assemblyInformationalVersion) ? GetVersionInfo(assembly).ProductVersion : assemblyInformationalVersion;
    }

    public static string GetTitle(this Assembly assembly)
    {
      var assemblyTitleAttribute = GetCustomAttribute<AssemblyTitleAttribute>(assembly);
      return assemblyTitleAttribute == null ? null : assemblyTitleAttribute.Title;
    }

    public static string GetProduct(this Assembly assembly)
    {
      var assemblyTitleAttribute = GetCustomAttribute<AssemblyProductAttribute>(assembly);
      return assemblyTitleAttribute == null ? null : assemblyTitleAttribute.Product;
    }

    public static string GetDescription(this Assembly assembly)
    {
      var assemblyDescriptionAttribute = GetCustomAttribute<AssemblyDescriptionAttribute>(assembly);
      return assemblyDescriptionAttribute == null ? null : assemblyDescriptionAttribute.Description;
    }

    public static T GetCustomAttribute<T>(this Assembly assembly) where T : Attribute
    {
      if (assembly == null) return null;
      var customAttributes = assembly.GetCustomAttributes(typeof (T), false);
      return (T) customAttributes.SingleOrDefault();
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

    public static object GetPropertyValue(object obj, string propertyName)
    {
      var propertyInfo = obj.GetType().GetProperty(propertyName);
      return propertyInfo == null ? null : propertyInfo.GetValue(obj, null);
    }

    /// <summary>
    ///   Gets the display name of a field from the first DisplayNameAttribute found otherwise it returns the fieldName.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="propertySpecifier">The property specifier.</param>
    /// <returns></returns>
    public static string GetDisplayName<T>(Expression<Func<T, object>> propertySpecifier)
    {
      return GetDisplayName(typeof (T), MemberName.For(propertySpecifier));
    }

    public static string GetDisplayName(Type type)
    {
      var displayAttributes = Attribute.GetCustomAttribute(type, typeof (DisplayAttribute)) as DisplayAttribute;
      if (displayAttributes == null)
      {
        var displayNameAttributes = Attribute.GetCustomAttribute(type, typeof (DisplayNameAttribute)) as DisplayNameAttribute;
        if (displayNameAttributes != null) return displayNameAttributes.DisplayName;
      }
      else
      {
        return displayAttributes.Name;
      }
      return null;
    }

    private static readonly IComparer<DisplayNameAttribute> DisplayNameAttributePrecedence = AnonymousComparer.Create<DisplayNameAttribute>(DisplayNameAttributeComparer);

    /// <summary>
    ///   Gets the display name of a field from the first DisplayNameAttribute found otherwise it returns the fieldName.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <param name="fieldName">Name of the field.</param>
    /// <returns></returns>
    public static string GetDisplayName(Type type, string fieldName)
    {
      var displayAttributes = GetDisplayAttributes(type, fieldName);
      foreach (var displayName in displayAttributes.Select(displayNameAttribute => GetDisplayName(displayNameAttribute, fieldName)).Where(displayName => displayName != fieldName))
        return displayName;
      var displayNameAttributes = GetDisplayNameAttributes(type, fieldName);

      foreach (var displayName in displayNameAttributes.OrderBy(dna => dna, DisplayNameAttributePrecedence).Select(displayNameAttribute => GetDisplayName(displayNameAttribute, fieldName)).Where(displayName => displayName != fieldName))
        return displayName;
      return fieldName;
    }

    /// <summary>
    ///   DisplayNameAttribute comparer that gives precedent to LocalizedDisplayNameAttributeover others.
    /// </summary>
    /// <param name="displayNameAttributeX">The display name attribute X.</param>
    /// <param name="displayNameAttributeY">The display name attribute Y.</param>
    /// <returns></returns>
    private static int DisplayNameAttributeComparer(DisplayNameAttribute displayNameAttributeX, DisplayNameAttribute displayNameAttributeY)
    {
      return displayNameAttributeX.GetType() == displayNameAttributeY.GetType() ? 0 : 1;
    }

    public static string GetDisplayName(DisplayAttribute displayNameAttribute, string fieldName)
    {
      if (displayNameAttribute == null)
        return fieldName;
      var displayName = displayNameAttribute.GetName();
      return String.IsNullOrEmpty(displayName) ? fieldName : displayName;
    }

    public static string GetDisplayName(DisplayNameAttribute displayNameAttribute, string fieldName)
    {
      if (displayNameAttribute == null)
        return fieldName;
      var displayName = displayNameAttribute.DisplayName;
      return String.IsNullOrEmpty(displayName) ? fieldName : displayName;
    }

    public static string ListToString(ICollection list, bool enumWithUnderlyingType = true)
    {
      if (list.Count == 0)
        return String.Empty;
      var stringBuilder = new StringBuilder();
      foreach (var obj in list)
        stringBuilder.Append(DisplayAsString(obj, enumWithUnderlyingType) + GeneralHelper.StringJoinSeparator);
      return stringBuilder.ToString().TrimEnd(GeneralHelper.StringJoinSeparator.ToCharArray());
    }

    public static string StringDictionaryToString(StringDictionary stringDictionary)
    {
      if (stringDictionary.Count == 0)
        return String.Empty;
      var stringBuilder = new StringBuilder();
      foreach (DictionaryEntry de in stringDictionary)
        stringBuilder.AppendFormat("{0}=<{1}>, ", de.Key, de.Value);
      return stringBuilder.ToString().TrimEnd(GeneralHelper.StringJoinSeparator.ToCharArray());
    }

    public static string DictionaryToString(IDictionary dictionary)
    {
      if (dictionary.Count == 0)
        return String.Empty;
      var stringBuilder = new StringBuilder();
      foreach (DictionaryEntry de in dictionary)
        stringBuilder.AppendFormat("{0}=<{1}>, ", de.Key, de.Value);
      return stringBuilder.ToString().TrimEnd(GeneralHelper.StringJoinSeparator.ToCharArray());
    }

    public static string ConvertToString(object value)
    {
      if (value == null)
        return String.Empty;
      var converter = TypeDescriptor.GetConverter(value.GetType());
      return converter.CanConvertTo(typeof (string)) ? converter.ConvertToString(value) : String.Empty;
    }

    /// <summary>
    ///   Converts a value to a string for display.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="enumWithUnderlyingType">if set to <c>true</c> [enum with underlying type].</param>
    /// <returns></returns>
    public static string DisplayAsString(object value, bool enumWithUnderlyingType = true)
    {
      if (value == null)
        return String.Empty;
      if (value is Enum)
      {
        if (enumWithUnderlyingType)
        {
          var underlyingType = Enum.GetUnderlyingType(value.GetType());
          var asUnderlyingType = Convert.ChangeType(value, underlyingType);
          return value + "(" + asUnderlyingType + ")";
        }
        return ((Enum) value).EnumToString();
      }
      var dictionary = value as StringDictionary;
      if (dictionary != null)
        return StringDictionaryToString(dictionary);
      var value1 = value as IDictionary;
      if (value1 != null)
        return DictionaryToString(value1);
      var list = value as ICollection;
      if (list != null)
        return ListToString(list, enumWithUnderlyingType);
      var node = value as XmlNode;
      if (node != null)
        return node.Name + "{" + node.InnerXml + "}";
      return ConvertToString(value);
    }

    /// <summary>
    ///   Gets the properties and values as string list.
    /// </summary>
    /// <param name="myObject">My object.</param>
    /// <returns></returns>
    public static IEnumerable<string> GetPropertiesAndValuesAsStringList(object myObject)
    {
      return from kv in GetPropertiesAndValues(myObject, false)
        select String.Format("{0}={1}", kv.Key, DisplayAsString(kv.Value));
    }

    public static IEnumerable<string> GetReadablePropertiesAndValuesAsStringList(object myObject, params string[] propertiesToExclude)
    {
      return from kv in GetReadablePropertiesAndValuesAsStrings(myObject, propertiesToExclude)
             select String.Format("{0}={1}", kv.Key, DisplayAsString(kv.Value));
    }

    public static IEnumerable<string> GetSpecifiedPropertiesAndValuesAsStringList(object myObject, params string[] propertiesToInclude)
    {
      return from kv in GetSpecifiedPropertiesAndValues(myObject, false, propertiesToInclude)
        select String.Format("{0}={1}", kv.Key, DisplayAsString(kv.Value));
    }

    public static string ConvertToIdentifiableString(object myObject)
    {
      if (myObject == null) return "";
      var result = Convert.ToString(myObject);
      if (result == myObject.GetType().ToString())
        try
        {
          var identifiableString = GetPropertiesAndValuesAsStringList(myObject).JoinAsString();
          if (!String.IsNullOrWhiteSpace(identifiableString))
            return identifiableString;
        }
        catch (Exception e)
        {
          e.TraceOut();
        }
      return result;
    }

    /// <summary>
    ///   Gets the properties and values as a CSV string.
    /// </summary>
    /// <param name="myObject">My object.</param>
    /// <returns></returns>
    public static string GetPropertiesAndValuesAsString(object myObject)
    {
      return GetPropertiesAndValuesAsStringList(myObject).JoinAsString();
    }

    public static string GetSpecifiedPropertiesAndValuesAsString(object myObject, params string[] propertiesToInclude)
    {
      return GetSpecifiedPropertiesAndValuesAsStringList(myObject, propertiesToInclude).JoinAsString();
    }

    public static string GetReadablePropertiesAndValuesAsString(object myObject, params string[] propertiesToExclude)
    {
      return GetReadablePropertiesAndValuesAsStringList(myObject, propertiesToExclude).JoinAsString();
    }

    #region Default

    /// <summary>
    ///   Gets the default value of a value type.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <returns></returns>
    public static object GetDefault(Type type)
    {
      if (type.IsValueType)
        return Activator.CreateInstance(type);
      return null;
    }

    public static bool IsDefault(object value)
    {
      if (value == null) return true;
      var type = value.GetType();
      return IsDefault(value, type);
    }

    /// <summary>
    ///   Determines whether the specified value is default if IsValueType or object.ToString() = type.ToString() if not.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="type">The type.</param>
    /// <returns></returns>
    private static bool IsDefault(object value, Type type)
    {
      if (value == null) return true;
      var defaultValue = GetDefault(type);
      if (defaultValue == null)
      {
        var collection = value as ICollection;
        if (collection == null)
          return Convert.ToString(value) == type.ToString();
        return collection.Count == 0;
      }
      return value.Equals(defaultValue);
    }

    /// <summary>
    ///   Determines whether the specified object is null or DBNull.
    /// </summary>
    /// <param name="anObject">The object.</param>
    /// <returns>
    ///   <c>true</c> if the specified object is null; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsNull(object anObject)
    {
      return (anObject == null || Convert.IsDBNull(anObject));
    }

    /// <summary>
    ///   Determines whether [is null or empty or first is null] [the specified strings].
    /// </summary>
    /// <param name="strings">The strings.</param>
    /// <returns>
    ///   <c>true</c> if [is null or empty or first is null] [the specified strings]; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsNullOrEmptyOrFirstIsNull(this IEnumerable<string> strings)
    {
      return strings.IsNullOrEmpty() || String.IsNullOrWhiteSpace(strings.First());
    }

    /// <summary>
    ///   Determines whether [is null or empty] [the specified o].
    /// </summary>
    /// <param name="o">The o.</param>
    /// <returns>
    ///   <c>true</c> if [is null or empty] [the specified o]; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsNullOrEmpty(object o)
    {
      var enumerable = o as IEnumerable;
      if (enumerable == null)
        return IsNull(o);
      var strings = enumerable as IEnumerable<string>;
      if (strings == null)
        return !LinqHelper.Any(enumerable);
      return IsNullOrEmptyOrFirstIsNull(strings);
    }

    public static bool IsNullOrEmptyOrDefault(object value, Type type)
    {
      return IsNullOrEmpty(value) || IsDefault(value, type);
    }

    #endregion

    #region Serialize

    /// <summary>
    ///   Gets the properties and values as a dictionary.
    /// </summary>
    /// <param name="myObject">My object.</param>
    /// <param name="includeNullsAndDefault">if set to <c>true</c> [include nulls and default].</param>
    /// <param name="propertiesToExclude">The properties to exclude.</param>
    /// <returns></returns>
    public static Dictionary<string, object> GetPropertiesAndValues(object myObject, bool includeNullsAndDefault = false, params string[] propertiesToExclude)
    {
      return GetPropertiesAndValues(myObject, includeNullsAndDefault, GetPropertyDescriptors(myObject.GetType()).Where(p => !propertiesToExclude.Contains(p.Name)));
    }

    public static Dictionary<string, object> GetSpecifiedPropertiesAndValues(object myObject, bool includeNullsAndDefault = false, params string[] propertiesToInclude)
    {
      return GetPropertiesAndValues(myObject, includeNullsAndDefault, GetPropertyDescriptors(myObject.GetType()).Where(p => propertiesToInclude.Contains(p.Name)));
    }

    public static Dictionary<string, object> GetPropertiesAndValues(object myObject, bool includeNullsAndDefault, IEnumerable<PropertyDescriptor> propertyDescriptors)
    {
      var dictionary = new Dictionary<string, object>();
      foreach (var descriptor in propertyDescriptors)
        try
        {
          var value = descriptor.GetValue(myObject);
          if (!includeNullsAndDefault && IsNullOrEmptyOrDefault(value, descriptor.PropertyType)) continue;
          try
          {
            if (dictionary.ContainsKey(descriptor.DisplayName))
              dictionary[descriptor.DisplayName + "," + descriptor.Name] = value;
            else
              dictionary[descriptor.DisplayName] = value;
          }
          catch (ArgumentException)
          {
            dictionary[descriptor.Name + "," + descriptor.DisplayName] = value;
          }
        }
        catch (Exception e)
        {
          e.TraceOut();
        }
      return dictionary;
    }

    public static Dictionary<string, string> GetReadablePropertiesAndValuesAsStrings<T>(object myObject, params Expression<Func<T, object>>[] propertiesToExclude)
    {
      return GetReadablePropertiesAndValuesAsStrings(myObject, false, MemberName.For(propertiesToExclude));
    }

    public static Dictionary<string, string> GetReadablePropertiesAndValuesAsStrings(object myObject, params string[] propertiesToExclude)
    {
      return GetReadablePropertiesAndValuesAsStrings(myObject, false, (IEnumerable<string>)propertiesToExclude);
    }

    public static Dictionary<string, string> GetReadablePropertiesAndValuesAsStrings(object myObject, bool includeNullsAndDefault, IEnumerable<string> propertiesToExclude)
    {
      var modelClass = myObject.GetType();

      var dictionary = new Dictionary<string, string>();

      foreach (var propertyInfo in modelClass.GetProperties().Where(p => p.CanRead && !propertiesToExclude.Contains(p.Name)))
        try
        {
          var value = propertyInfo.GetValue(myObject);
          GetPropertyAndValueAsStrings(dictionary, value, propertyInfo.Name, propertyInfo.PropertyType, includeNullsAndDefault);
        }
        catch (ArgumentException)
        {
        }
        catch (NotSupportedException)
        {
        }
        catch (TargetInvocationException e)
        {
          GeneralHelper.TraceOut(propertyInfo.Name);
          e.TraceOut();
        }
      return dictionary;

      //return modelClass.GetProperties().Where(p => !propertiesToExclude.Contains(p.Name))
      //  .ToDictionary(descriptor => descriptor.Name, descriptor => descriptor.GetValue(myObject));//
    }

    private static void GetPropertyAndValueAsStrings(IDictionary<string, string> dictionary, object value, string propertyName, Type propertyType, bool includeNullsAndDefault = false)
    {
      if (IsNullOrEmptyOrDefault(value, propertyType))
      {
        if (includeNullsAndDefault)
          dictionary.Add(propertyName, null);
      }
      else
      {
        var serializeToString = ConvertOrSerializeToString(value, propertyType);
        if (includeNullsAndDefault || !String.IsNullOrWhiteSpace(serializeToString))
          dictionary.Add(propertyName, serializeToString);
      }
    }

    public static string ConvertOrSerializeToString(object value, Type propertyType = null)
    {
      return typeof (IConvertible).IsAssignableFrom(GetCoreType(propertyType ?? value.GetType())) ? Convert.ToString(value) : SerializeToXml(value);
    }

    /// <param name="value">The value.</param>
    /// <param name="type">The type.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns></returns>
    public static string SerializeToXml(object value, Type type = null, string defaultValue = null)
    {
      if (value == null) return defaultValue;
      type = type ?? value.GetType();
      if (type.IsPublic)
      {
        var x = new XmlSerializer(type);

        //we are saving the grid preferences
        var doc = new XDocument();
        using (var xw = doc.CreateWriter())
        {
          x.Serialize(xw, value);
          xw.Close();
        }
        var el = doc.Root;
        return el == null ? defaultValue : el.ToString();
      }
      return null;
    }

    #endregion
  }
}