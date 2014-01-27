using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms.Design;
using AW.Winforms.Helpers.Properties;

namespace AW.Winforms.Helpers.PropGridEx
{
	/// <summary>
	/// A custom PropertyTab that simply list all instance fields
	/// </summary>
	public class RawMemberTab : PropertyTab
	{
		public RawMemberTab()
		{
		}

		public RawMemberTab(IServiceProvider serviceProvider)
		{
		}

		public RawMemberTab(IDesignerHost designerHost)
		{
		}

		/// <summary>
		/// extend everything
		/// </summary>
		public override bool CanExtend(object extendee)
		{
			return true;
		}

		/// <summary>
		/// the tab's iumage
		/// </summary>
		public override Bitmap Bitmap
		{
			get { return Resources.Members; }
		}

		/// <summary>
		/// the tab's name
		/// </summary>
		public override string TabName
		{
			get { return "Raw View"; }
		}


		/// <summary>
		/// used to filter implemented interfaces in a type
		/// </summary>
		/// <returns>true if the requested interfaces are implemented</returns>
		protected static bool InterfaceFilter(Type typeObj, Object criteriaObj)
		{
			var t = criteriaObj as Type;
			if (t == null)
				return false;
			return typeObj == t;
		}

		/// <summary>
		/// Add the instance fields of an object
		/// </summary>
		private static void AddTypeFields(Type type, ICollection<PropertyDescriptor> fields, ICollection<string> addedMemberNames)
		{
			// stop at List / ArrayList / Dictionary / SortedList / Hashtable 
			if ((type == typeof (ArrayList)) ||
			    (type == typeof (Hashtable)) ||
			    (type == typeof (SortedList)))
				return;


			// get all instance FieldInfos
			var fieldInfos = type.GetFields(BindingFlags.Instance |
			                                BindingFlags.Public |
			                                BindingFlags.NonPublic);


			foreach (var field in fieldInfos.Where(field => !addedMemberNames.Contains(field.Name)))
			{
				// this one made it in the list... 
				addedMemberNames.Add(field.Name);
				fields.Add(new FieldMemberDescriptor(field));
			}
		}

		public override PropertyDescriptorCollection GetProperties(object component)
		{
			return GetProperties(component, null);
		}

		/// <summary>
		/// Gather all PropertyDescriptors for the RawMemberTab
		/// </summary>
		public override PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes)
		{
			if (component == null)
				return new PropertyDescriptorCollection(null, true);

			// use a stack to reverse hierarchy
			// if fieldnames occure in more than one class
			// use the one from the class that is highest in the class hierarchy
			var objectHierarchy = new Stack<Type>();
			var curType = component.GetType();
			while (curType != null)
			{
				objectHierarchy.Push(curType);
				curType = curType.BaseType;
			}

			// list of the PropertyDescriptors that will be returned
			var fields = new List<PropertyDescriptor>();
			// list to rememnber already added names
			var addedMemberNames = new List<string>();

			// special treatment for classes implementing IList
			var list = component as IList;
			GetProperties(list, fields);

			// special treatment for classes implementing IDictionary
			var dict = component as IDictionary;
			if (dict != null)
				fields.AddRange((from object key in dict.Keys select new DictionaryItemMemberDescriptor(dict, key)).Cast<PropertyDescriptor>());


			// add all the instance fields
			while (objectHierarchy.Count > 0)
			{
				AddTypeFields(objectHierarchy.Pop(), fields, addedMemberNames);
			}

			return new PropertyDescriptorCollection(fields.ToArray());
		}

		public virtual void GetProperties(IList list, List<PropertyDescriptor> fields)
		{
			if (list != null)
			{
				// add an ListItemMemberDescriptor fore each item in the list
				fields.AddRange(list.Cast<object>().Select((t, i) => new ListItemMemberDescriptor(list, i)).Cast<PropertyDescriptor>());
			}
		}
	}
}