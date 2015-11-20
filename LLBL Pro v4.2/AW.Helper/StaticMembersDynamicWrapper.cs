using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;

namespace AW.Helper
{
  /// <summary>
  ///   A dynamic object that allows access to a type's static members, resolved dynamically at runtime.
  ///   http://blogs.msdn.com/b/davidebb/archive/2009/10/23/using-c-dynamic-to-call-static-members.aspx
  /// </summary>
  public class StaticMembersDynamicWrapper : DynamicObject
  {
    private readonly Type _type;

    public StaticMembersDynamicWrapper(Type type)
    {
      _type = type;
    }

    // Handle static properties
    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
      var prop = _type.GetProperty(binder.Name, BindingFlags.FlattenHierarchy | BindingFlags.Static | BindingFlags.Public);

      if (prop != null)
      {
        result = prop.GetValue(null, null);
        return true;
      }

      var field = _type.GetField(binder.Name, BindingFlags.FlattenHierarchy | BindingFlags.Static | BindingFlags.Public);

      if (field != null)
      {
        result = field.GetValue(null);
        return true;
      }

      result = null;
      return false;
    }

    /// <summary>
    ///   Sets a value for a static property defined by the wrapped type.
    /// </summary>
    /// <param name="binder">
    ///   Provides information about the object that called the dynamic operation. The binder.Name property provides the name of the member to which the value is being assigned. For
    ///   example, for the statement sampleObject.SampleProperty = "Test", where sampleObject is an instance of the class derived from the <see cref="T:System.Dynamic.DynamicObject" /> class, binder.Name
    ///   returns "SampleProperty". The binder.IgnoreCase property specifies whether the member name is case-sensitive.
    /// </param>
    /// <param name="value">
    ///   The value to set to the member. For example, for sampleObject.SampleProperty = "Test", where sampleObject is an instance of the class derived from the
    ///   <see cref="T:System.Dynamic.DynamicObject" /> class, the <paramref name="value" /> is "Test".
    /// </param>
    /// <returns>
    ///   true if the operation is successful; otherwise, false. If this method returns false, the run-time binder of the language determines the behavior. (In most cases, a language-specific run-time
    ///   exception is thrown.)
    /// </returns>
    public override bool TrySetMember(SetMemberBinder binder, object value)
    {
      var prop = _type.GetProperty(binder.Name, BindingFlags.FlattenHierarchy | BindingFlags.Static | BindingFlags.Public);

      if (prop != null)
      {
        prop.SetValue(null, value, null);
        return true;
      }

      var field = _type.GetField(binder.Name, BindingFlags.FlattenHierarchy | BindingFlags.Static | BindingFlags.Public);

      if (field != null)
      {
        field.SetValue(null, value);
        return true;
      }
      return false;
    }

    // Handle static methods
    public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
    {
      var method = _type.GetMethod(binder.Name, BindingFlags.FlattenHierarchy | BindingFlags.Static | BindingFlags.Public);
      if (method == null)
      {
        result = null;
        return false;
      }

      result = method.Invoke(null, args);
      return true;
    }
  }

  public static class StaticMembersDynamicWrapperExtensions
  {
    private static readonly Dictionary<Type, DynamicObject> Cache = new Dictionary<Type, DynamicObject>();

    /// <summary>
    ///   Allows access to static fields, properties, and methods, resolved at run-time.
    /// </summary>
    public static dynamic StaticMembers(this Type type)
    {
      DynamicObject retVal;
      if (!Cache.TryGetValue(type, out retVal))
      {
        var staticMembersDynamicWrapper = new StaticMembersDynamicWrapper(type);
        Cache[type] = staticMembersDynamicWrapper;
        return staticMembersDynamicWrapper;
      }
      return retVal;
    }
  }
}