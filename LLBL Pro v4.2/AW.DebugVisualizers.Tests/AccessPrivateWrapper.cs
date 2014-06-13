using System;
using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace AW.DebugVisualizers.Tests
{
	/// <summary>
	/// A 10 minute wrapper to access private members, havn't tested in detail.
	/// Use under your own risk - amazedsaint@gmail.com
	/// http://amazedsaint.blogspot.com/2010/05/accessprivatewrapper-c-40-dynamic.html
	/// </summary>
	public class AccessPrivateWrapper
		
		: DynamicObject
	{
		/// <summary>
		/// The object we are going to wrap
		/// </summary>
		private readonly object _wrapped;

		/// <summary>
		/// Specify the flags for accessing members
		/// </summary>
		private const BindingFlags Flags = BindingFlags.NonPublic | BindingFlags.Instance
																			 | BindingFlags.Static | BindingFlags.Public;

		/// <summary>
		/// Create a simple private wrapper
		/// </summary>
		public AccessPrivateWrapper(object o)
		{
			_wrapped = o;
		}

		/// <summary>
		/// Create an instance via the constructor matching the args 
		/// </summary>
		public static dynamic FromType(Assembly asm, string type, params object[] args)
		{
			var allt = asm.GetTypes();
			var t = allt.First(item => item.Name == type);


			var types = args.Select(a => a.GetType()).ToArray();

			//Gets the constructor matching the specified set of args
			var ctor = t.GetConstructor(Flags, null, types, null);

			if (ctor != null)
			{
				var instance = ctor.Invoke(args);
				return new AccessPrivateWrapper(instance);
			}

			return null;
		}

		/// <summary>
		/// Try invoking a method
		/// </summary>
		public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
		{
			var method = GetMethod(_wrapped.GetType(), binder.Name, args.Select(a => a.GetType()).ToArray());

			if (method == null)
				return base.TryInvokeMember(binder, args, out result);
			result = method.Invoke(_wrapped, args);
			return true;
		}

		private static MethodInfo GetMethod(Type type, string name, params Type[] types)
		{
			var fld = type.GetMethod(name, Flags, null, types, null);
		  if (fld == null && type.BaseType != null)
		  {
		    fld = GetMethod(type.BaseType, name, types);
		  }
		  if (fld != null) return fld;
		  var method = type.GetMethod(name, Flags);
		  if (method == null) return fld;
		  var parameterInfos = method.GetParameters();
		  if (parameterInfos.Count() == types.Length)
		  {
		    var paramsMatch = false;
		    for (int index = 0; index < parameterInfos.Length; index++)
		    {
		      var parameterInfo = parameterInfos[index];
		      var type1 = types[index];
		      paramsMatch = parameterInfo.ParameterType.IsAssignableFrom(type1);
          if (!paramsMatch && parameterInfo.ParameterType.IsInterface)
          {
            var theInterface = type1.GetInterface(parameterInfo.ParameterType.Name);
            if (theInterface != null && theInterface.Assembly!=parameterInfo.ParameterType.Assembly)
              throw new ArgumentException(string.Format("Parameter {0} to {1} is from a different assembly: {2}", parameterInfo.ParameterType.AssemblyQualifiedName,
                name, theInterface.AssemblyQualifiedName));
          }
		      if (!paramsMatch)
		        break;
		    }
		    if (paramsMatch)
		      fld = method;
		  }
		  return fld;
		}

		/// <summary>
		/// Gets a property with the given name
		/// </summary>
		private PropertyInfo GetProperty(string name)
		{
			return GetProperty(_wrapped.GetType(), name);
		}

		private static PropertyInfo GetProperty(Type type, string name)
		{
			var fld = type.GetProperty(name, Flags);
			if (fld == null && type.BaseType != null)
				fld = GetProperty(type.BaseType, name);
			return fld;
		}

		/// <summary>
		/// Gets a Field with the given name
		/// </summary>
		private FieldInfo GetField(string name)
		{
			return GetField(_wrapped.GetType(), name);
		}

		private static FieldInfo GetField(Type type, string name)
		{
			var fld = type.GetField(name, Flags);
			if (fld == null && type.BaseType != null)
				fld = GetField(type.BaseType, name);
			return fld;
		}

		/// <summary>
		/// Tries to get a property or field with the given name
		/// </summary>
		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			//Try getting a property of that name
			var prop = GetProperty(binder.Name);

			if (prop == null)
			{
				//Try getting a field of that name
				var fld = GetField(binder.Name);
				if (fld != null)
				{
					result = fld.GetValue(_wrapped);
					return true;
				}
				return base.TryGetMember(binder, out result);
			}
			result = prop.GetValue(_wrapped, null);
			return true;
		}

		/// <summary>
		/// Tries to set a property or field with the given name
		/// </summary>
		public override bool TrySetMember(SetMemberBinder binder, object value)
		{
			var prop = GetProperty(binder.Name);
			if (prop == null)
			{
				var fld = GetField(binder.Name);				
				if (fld != null)
				{
					fld.SetValue(_wrapped, value);
					return true;
				}
				return base.TrySetMember(binder, value);
			}
			prop.SetValue(_wrapped, value, null);
			return true;
		}
	}
}