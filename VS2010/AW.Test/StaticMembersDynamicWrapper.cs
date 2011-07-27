using System;
using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace AW.Tests
{
	/// <summary>
	/// http://blogs.msdn.com/b/davidebb/archive/2009/10/23/using-c-dynamic-to-call-static-members.aspx
	/// http://stackoverflow.com/questions/5749396/accessing-constants-with-a-dynamic-keyword
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
			if (prop == null)
			{
				result = null;
				return false;
			}

			result = prop.GetValue(null, null);
			return true;
		}

		// Handle static methods
		public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
		{
			var method = _type.GetMethod(binder.Name, BindingFlags.FlattenHierarchy | BindingFlags.Static | BindingFlags.Public,
																	 null, args == null ? null : args.Where(a => a != null).Select(a => a.GetType()).ToArray(), null);
			if (method == null)
			{
				result = null;
				return false;
			}

			result = method.Invoke(null, args);
			return true;
		}
	}
}